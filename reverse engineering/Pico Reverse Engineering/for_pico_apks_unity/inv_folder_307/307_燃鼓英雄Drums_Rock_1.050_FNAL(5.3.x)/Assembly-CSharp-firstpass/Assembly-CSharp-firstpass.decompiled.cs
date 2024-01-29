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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AB6C", Offset = "0xA5AB6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1DA1C2C", Offset = "0x1DA1C2C", VA = "0x1DA1C2C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1DA241C", Offset = "0x1DA241C", VA = "0x1DA241C")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1DA2438", Offset = "0x1DA2438", VA = "0x1DA2438")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AB7C", Offset = "0xA5AB7C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1DA1D80", Offset = "0x1DA1D80", VA = "0x1DA1D80")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1DA2454", Offset = "0x1DA2454", VA = "0x1DA2454")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1DA2470", Offset = "0x1DA2470", VA = "0x1DA2470")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AB8C", Offset = "0xA5AB8C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1DA1EE8", Offset = "0x1DA1EE8", VA = "0x1DA1EE8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1DA248C", Offset = "0x1DA248C", VA = "0x1DA248C")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1DA24CC", Offset = "0x1DA24CC", VA = "0x1DA24CC")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1DA1AB8", Offset = "0x1DA1AB8", VA = "0x1DA1AB8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1DA1C34", Offset = "0x1DA1C34", VA = "0x1DA1C34")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1DA1D88", Offset = "0x1DA1D88", VA = "0x1DA1D88")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1DA1EF0", Offset = "0x1DA1EF0", VA = "0x1DA1EF0")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1DA1F68", Offset = "0x1DA1F68", VA = "0x1DA1F68")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1DA1FE0", Offset = "0x1DA1FE0", VA = "0x1DA1FE0")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1DA2048", Offset = "0x1DA2048", VA = "0x1DA2048")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1DA20D0", Offset = "0x1DA20D0", VA = "0x1DA20D0")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1DA2138", Offset = "0x1DA2138", VA = "0x1DA2138")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1DA21A0", Offset = "0x1DA21A0", VA = "0x1DA21A0")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1DA2208", Offset = "0x1DA2208", VA = "0x1DA2208")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1DA2270", Offset = "0x1DA2270", VA = "0x1DA2270")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1DA22E0", Offset = "0x1DA22E0", VA = "0x1DA22E0")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1DA234C", Offset = "0x1DA234C", VA = "0x1DA234C")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1DA23B4", Offset = "0x1DA23B4", VA = "0x1DA23B4")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AB9C", Offset = "0xA5AB9C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1DA2670", Offset = "0x1DA2670", VA = "0x1DA2670")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1DA3AF8", Offset = "0x1DA3AF8", VA = "0x1DA3AF8")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ABAC", Offset = "0xA5ABAC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1DA2810", Offset = "0x1DA2810", VA = "0x1DA2810")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1DA3C34", Offset = "0x1DA3C34", VA = "0x1DA3C34")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ABBC", Offset = "0xA5ABBC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1DA29B0", Offset = "0x1DA29B0", VA = "0x1DA29B0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1DA3C50", Offset = "0x1DA3C50", VA = "0x1DA3C50")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ABCC", Offset = "0xA5ABCC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1DA2B50", Offset = "0x1DA2B50", VA = "0x1DA2B50")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1DA3C6C", Offset = "0x1DA3C6C", VA = "0x1DA3C6C")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ABDC", Offset = "0xA5ABDC")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1DA2CD4", Offset = "0x1DA2CD4", VA = "0x1DA2CD4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1DA3C88", Offset = "0x1DA3C88", VA = "0x1DA3C88")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ABEC", Offset = "0xA5ABEC")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1DA2ED0", Offset = "0x1DA2ED0", VA = "0x1DA2ED0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1DA3CA4", Offset = "0x1DA3CA4", VA = "0x1DA3CA4")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ABFC", Offset = "0xA5ABFC")]
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
		[Address(RVA = "0x1DA3388", Offset = "0x1DA3388", VA = "0x1DA3388")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1DA3CC0", Offset = "0x1DA3CC0", VA = "0x1DA3CC0")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1DA3CDC", Offset = "0x1DA3CDC", VA = "0x1DA3CDC")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1DA3D10", Offset = "0x1DA3D10", VA = "0x1DA3D10")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1DA3D2C", Offset = "0x1DA3D2C", VA = "0x1DA3D2C")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1DA3D48", Offset = "0x1DA3D48", VA = "0x1DA3D48")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC0C", Offset = "0xA5AC0C")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1DA358C", Offset = "0x1DA358C", VA = "0x1DA358C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1DA3E08", Offset = "0x1DA3E08", VA = "0x1DA3E08")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC1C", Offset = "0xA5AC1C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1DA37B0", Offset = "0x1DA37B0", VA = "0x1DA37B0")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1DA3E24", Offset = "0x1DA3E24", VA = "0x1DA3E24")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1DA3E40", Offset = "0x1DA3E40", VA = "0x1DA3E40")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC2C", Offset = "0xA5AC2C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1DA3940", Offset = "0x1DA3940", VA = "0x1DA3940")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1DA3F44", Offset = "0x1DA3F44", VA = "0x1DA3F44")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC3C", Offset = "0xA5AC3C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1DA3AF0", Offset = "0x1DA3AF0", VA = "0x1DA3AF0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1DA3B14", Offset = "0x1DA3B14", VA = "0x1DA3B14")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1DA3B30", Offset = "0x1DA3B30", VA = "0x1DA3B30")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1DA24F0", Offset = "0x1DA24F0", VA = "0x1DA24F0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1DA2678", Offset = "0x1DA2678", VA = "0x1DA2678")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1DA2818", Offset = "0x1DA2818", VA = "0x1DA2818")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1DA29B8", Offset = "0x1DA29B8", VA = "0x1DA29B8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1DA2B58", Offset = "0x1DA2B58", VA = "0x1DA2B58")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1DA2CDC", Offset = "0x1DA2CDC", VA = "0x1DA2CDC")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1DA2ED8", Offset = "0x1DA2ED8", VA = "0x1DA2ED8")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1DA3390", Offset = "0x1DA3390", VA = "0x1DA3390")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1DA3594", Offset = "0x1DA3594", VA = "0x1DA3594")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1DA37B8", Offset = "0x1DA37B8", VA = "0x1DA37B8")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1DA3948", Offset = "0x1DA3948", VA = "0x1DA3948")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC4C", Offset = "0xA5AC4C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1DA40D8", Offset = "0x1DA40D8", VA = "0x1DA40D8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1DA4EAC", Offset = "0x1DA4EAC", VA = "0x1DA4EAC")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC5C", Offset = "0xA5AC5C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1DA4264", Offset = "0x1DA4264", VA = "0x1DA4264")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1DA4EC8", Offset = "0x1DA4EC8", VA = "0x1DA4EC8")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC6C", Offset = "0xA5AC6C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1DA43F0", Offset = "0x1DA43F0", VA = "0x1DA43F0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1DA4EE4", Offset = "0x1DA4EE4", VA = "0x1DA4EE4")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC7C", Offset = "0xA5AC7C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1DA4548", Offset = "0x1DA4548", VA = "0x1DA4548")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1DA4F00", Offset = "0x1DA4F00", VA = "0x1DA4F00")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC8C", Offset = "0xA5AC8C")]
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
		[Address(RVA = "0x1DA48FC", Offset = "0x1DA48FC", VA = "0x1DA48FC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1DA4F1C", Offset = "0x1DA4F1C", VA = "0x1DA4F1C")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1DA4F38", Offset = "0x1DA4F38", VA = "0x1DA4F38")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1DA4F54", Offset = "0x1DA4F54", VA = "0x1DA4F54")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1DA4F88", Offset = "0x1DA4F88", VA = "0x1DA4F88")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1DA4FA4", Offset = "0x1DA4FA4", VA = "0x1DA4FA4")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1DA4FC0", Offset = "0x1DA4FC0", VA = "0x1DA4FC0")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AC9C", Offset = "0xA5AC9C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1DA4BC0", Offset = "0x1DA4BC0", VA = "0x1DA4BC0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1DA50E8", Offset = "0x1DA50E8", VA = "0x1DA50E8")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1DA5178", Offset = "0x1DA5178", VA = "0x1DA5178")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ACAC", Offset = "0xA5ACAC")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1DA4EA4", Offset = "0x1DA4EA4", VA = "0x1DA4EA4")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1DA521C", Offset = "0x1DA521C", VA = "0x1DA521C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1DA5238", Offset = "0x1DA5238", VA = "0x1DA5238")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1DA3F60", Offset = "0x1DA3F60", VA = "0x1DA3F60")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1DA40E0", Offset = "0x1DA40E0", VA = "0x1DA40E0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1DA426C", Offset = "0x1DA426C", VA = "0x1DA426C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1DA43F8", Offset = "0x1DA43F8", VA = "0x1DA43F8")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1DA4550", Offset = "0x1DA4550", VA = "0x1DA4550")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1DA4904", Offset = "0x1DA4904", VA = "0x1DA4904")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1DA4BC8", Offset = "0x1DA4BC8", VA = "0x1DA4BC8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ACBC", Offset = "0xA5ACBC")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1DA54D8", Offset = "0x1DA54D8", VA = "0x1DA54D8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1DA5A08", Offset = "0x1DA5A08", VA = "0x1DA5A08")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1DA5A24", Offset = "0x1DA5A24", VA = "0x1DA5A24")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ACCC", Offset = "0xA5ACCC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1DA562C", Offset = "0x1DA562C", VA = "0x1DA562C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1DA5A40", Offset = "0x1DA5A40", VA = "0x1DA5A40")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1DA5A5C", Offset = "0x1DA5A5C", VA = "0x1DA5A5C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ACDC", Offset = "0xA5ACDC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1DA5A00", Offset = "0x1DA5A00", VA = "0x1DA5A00")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1DA5A78", Offset = "0x1DA5A78", VA = "0x1DA5A78")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1DA5A84", Offset = "0x1DA5A84", VA = "0x1DA5A84")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1DA5364", Offset = "0x1DA5364", VA = "0x1DA5364")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1DA54E0", Offset = "0x1DA54E0", VA = "0x1DA54E0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1DA5634", Offset = "0x1DA5634", VA = "0x1DA5634")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1DA580C", Offset = "0x1DA580C", VA = "0x1DA580C")]
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
		[Address(RVA = "0x1DAAF00", Offset = "0x1DAAF00", VA = "0x1DAAF00")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ACEC", Offset = "0xA5ACEC")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1DA5C7C", Offset = "0x1DA5C7C", VA = "0x1DA5C7C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1DA9D14", Offset = "0x1DA9D14", VA = "0x1DA9D14")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1DA9D30", Offset = "0x1DA9D30", VA = "0x1DA9D30")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ACFC", Offset = "0xA5ACFC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1DA5DF8", Offset = "0x1DA5DF8", VA = "0x1DA5DF8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1DA9F84", Offset = "0x1DA9F84", VA = "0x1DA9F84")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1DA9FA8", Offset = "0x1DA9FA8", VA = "0x1DA9FA8")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD0C", Offset = "0xA5AD0C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1DA5F4C", Offset = "0x1DA5F4C", VA = "0x1DA5F4C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1DAA610", Offset = "0x1DAA610", VA = "0x1DAA610")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1DAA634", Offset = "0x1DAA634", VA = "0x1DAA634")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD1C", Offset = "0xA5AD1C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1DA60C8", Offset = "0x1DA60C8", VA = "0x1DA60C8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1DAAADC", Offset = "0x1DAAADC", VA = "0x1DAAADC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1DAAB00", Offset = "0x1DAAB00", VA = "0x1DAAB00")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD2C", Offset = "0xA5AD2C")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1DA621C", Offset = "0x1DA621C", VA = "0x1DA621C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1DAABEC", Offset = "0x1DAABEC", VA = "0x1DAABEC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1DAAC10", Offset = "0x1DAAC10", VA = "0x1DAAC10")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD3C", Offset = "0xA5AD3C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1DA6394", Offset = "0x1DA6394", VA = "0x1DA6394")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1DAAC34", Offset = "0x1DAAC34", VA = "0x1DAAC34")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1DAAC50", Offset = "0x1DAAC50", VA = "0x1DAAC50")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD4C", Offset = "0xA5AD4C")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1DA66F0", Offset = "0x1DA66F0", VA = "0x1DA66F0")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1DAAC6C", Offset = "0x1DAAC6C", VA = "0x1DAAC6C")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1DAACEC", Offset = "0x1DAACEC", VA = "0x1DAACEC")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD5C", Offset = "0xA5AD5C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1DA686C", Offset = "0x1DA686C", VA = "0x1DA686C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1DAAD48", Offset = "0x1DAAD48", VA = "0x1DAAD48")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1DAADC8", Offset = "0x1DAADC8", VA = "0x1DAADC8")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD6C", Offset = "0xA5AD6C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1DA69E8", Offset = "0x1DA69E8", VA = "0x1DA69E8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1DAAE24", Offset = "0x1DAAE24", VA = "0x1DAAE24")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1DAAEA4", Offset = "0x1DAAEA4", VA = "0x1DAAEA4")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD7C", Offset = "0xA5AD7C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1DA6B64", Offset = "0x1DA6B64", VA = "0x1DA6B64")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1DA9D4C", Offset = "0x1DA9D4C", VA = "0x1DA9D4C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1DA9D6C", Offset = "0x1DA9D6C", VA = "0x1DA9D6C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD8C", Offset = "0xA5AD8C")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1DA6CB8", Offset = "0x1DA6CB8", VA = "0x1DA6CB8")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1DA9D88", Offset = "0x1DA9D88", VA = "0x1DA9D88")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1DA9DA8", Offset = "0x1DA9DA8", VA = "0x1DA9DA8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AD9C", Offset = "0xA5AD9C")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1DA6E1C", Offset = "0x1DA6E1C", VA = "0x1DA6E1C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1DA9DC4", Offset = "0x1DA9DC4", VA = "0x1DA9DC4")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1DA9DE0", Offset = "0x1DA9DE0", VA = "0x1DA9DE0")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ADAC", Offset = "0xA5ADAC")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1DA6F98", Offset = "0x1DA6F98", VA = "0x1DA6F98")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1DA9DFC", Offset = "0x1DA9DFC", VA = "0x1DA9DFC")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1DA9E18", Offset = "0x1DA9E18", VA = "0x1DA9E18")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ADBC", Offset = "0xA5ADBC")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1DA7120", Offset = "0x1DA7120", VA = "0x1DA7120")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1DA9E34", Offset = "0x1DA9E34", VA = "0x1DA9E34")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1DA9E50", Offset = "0x1DA9E50", VA = "0x1DA9E50")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ADCC", Offset = "0xA5ADCC")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1DA72A8", Offset = "0x1DA72A8", VA = "0x1DA72A8")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1DA9E6C", Offset = "0x1DA9E6C", VA = "0x1DA9E6C")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1DA9E88", Offset = "0x1DA9E88", VA = "0x1DA9E88")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ADDC", Offset = "0xA5ADDC")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1DA742C", Offset = "0x1DA742C", VA = "0x1DA742C")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1DA9EA4", Offset = "0x1DA9EA4", VA = "0x1DA9EA4")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1DA9EC0", Offset = "0x1DA9EC0", VA = "0x1DA9EC0")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ADEC", Offset = "0xA5ADEC")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1DA75C8", Offset = "0x1DA75C8", VA = "0x1DA75C8")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1DA9EDC", Offset = "0x1DA9EDC", VA = "0x1DA9EDC")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1DA9EF8", Offset = "0x1DA9EF8", VA = "0x1DA9EF8")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5ADFC", Offset = "0xA5ADFC")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1DA7764", Offset = "0x1DA7764", VA = "0x1DA7764")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1DA9F14", Offset = "0x1DA9F14", VA = "0x1DA9F14")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1DA9F30", Offset = "0x1DA9F30", VA = "0x1DA9F30")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE0C", Offset = "0xA5AE0C")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1DA7900", Offset = "0x1DA7900", VA = "0x1DA7900")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1DA9F4C", Offset = "0x1DA9F4C", VA = "0x1DA9F4C")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1DA9F68", Offset = "0x1DA9F68", VA = "0x1DA9F68")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE1C", Offset = "0xA5AE1C")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1DA7A7C", Offset = "0x1DA7A7C", VA = "0x1DA7A7C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1DA9FCC", Offset = "0x1DA9FCC", VA = "0x1DA9FCC")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1DA9FE8", Offset = "0x1DA9FE8", VA = "0x1DA9FE8")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE2C", Offset = "0xA5AE2C")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1DA7BF8", Offset = "0x1DA7BF8", VA = "0x1DA7BF8")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1DAA004", Offset = "0x1DAA004", VA = "0x1DAA004")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1DAA020", Offset = "0x1DAA020", VA = "0x1DAA020")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE3C", Offset = "0xA5AE3C")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1DA7D5C", Offset = "0x1DA7D5C", VA = "0x1DA7D5C")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1DAA03C", Offset = "0x1DAA03C", VA = "0x1DAA03C")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1DAA058", Offset = "0x1DAA058", VA = "0x1DAA058")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE4C", Offset = "0xA5AE4C")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1DA7EE0", Offset = "0x1DA7EE0", VA = "0x1DA7EE0")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1DAA074", Offset = "0x1DAA074", VA = "0x1DAA074")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1DAA090", Offset = "0x1DAA090", VA = "0x1DAA090")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE5C", Offset = "0xA5AE5C")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1DA8064", Offset = "0x1DA8064", VA = "0x1DA8064")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1DAA0AC", Offset = "0x1DAA0AC", VA = "0x1DAA0AC")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1DAA0C8", Offset = "0x1DAA0C8", VA = "0x1DAA0C8")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE6C", Offset = "0xA5AE6C")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1DA81E0", Offset = "0x1DA81E0", VA = "0x1DA81E0")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1DAA0E4", Offset = "0x1DAA0E4", VA = "0x1DAA0E4")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1DAA100", Offset = "0x1DAA100", VA = "0x1DAA100")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE7C", Offset = "0xA5AE7C")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1DA83A8", Offset = "0x1DA83A8", VA = "0x1DA83A8")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1DAA11C", Offset = "0x1DAA11C", VA = "0x1DAA11C")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1DAA1AC", Offset = "0x1DAA1AC", VA = "0x1DAA1AC")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE8C", Offset = "0xA5AE8C")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1DA8548", Offset = "0x1DA8548", VA = "0x1DA8548")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1DAA250", Offset = "0x1DAA250", VA = "0x1DAA250")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1DAA2E0", Offset = "0x1DAA2E0", VA = "0x1DAA2E0")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AE9C", Offset = "0xA5AE9C")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1DA8734", Offset = "0x1DA8734", VA = "0x1DA8734")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1DAA384", Offset = "0x1DAA384", VA = "0x1DAA384")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1DAA414", Offset = "0x1DAA414", VA = "0x1DAA414")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AEAC", Offset = "0xA5AEAC")]
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
		[Address(RVA = "0x1DA8AE0", Offset = "0x1DA8AE0", VA = "0x1DA8AE0")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1DAA4B8", Offset = "0x1DAA4B8", VA = "0x1DAA4B8")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1DAA4D4", Offset = "0x1DAA4D4", VA = "0x1DAA4D4")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1DAA4F0", Offset = "0x1DAA4F0", VA = "0x1DAA4F0")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1DAA524", Offset = "0x1DAA524", VA = "0x1DAA524")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1DAA540", Offset = "0x1DAA540", VA = "0x1DAA540")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1DAA55C", Offset = "0x1DAA55C", VA = "0x1DAA55C")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AEBC", Offset = "0xA5AEBC")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1DA8C50", Offset = "0x1DA8C50", VA = "0x1DA8C50")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1DAA658", Offset = "0x1DAA658", VA = "0x1DAA658")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1DAA6C8", Offset = "0x1DAA6C8", VA = "0x1DAA6C8")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AECC", Offset = "0xA5AECC")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1DA8DB0", Offset = "0x1DA8DB0", VA = "0x1DA8DB0")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1DAA714", Offset = "0x1DAA714", VA = "0x1DAA714")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1DAA730", Offset = "0x1DAA730", VA = "0x1DAA730")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AEDC", Offset = "0xA5AEDC")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1DA8F10", Offset = "0x1DA8F10", VA = "0x1DA8F10")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1DAA74C", Offset = "0x1DAA74C", VA = "0x1DAA74C")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1DAA768", Offset = "0x1DAA768", VA = "0x1DAA768")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AEEC", Offset = "0xA5AEEC")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1DA907C", Offset = "0x1DA907C", VA = "0x1DA907C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1DAA784", Offset = "0x1DAA784", VA = "0x1DAA784")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1DAA7A8", Offset = "0x1DAA7A8", VA = "0x1DAA7A8")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AEFC", Offset = "0xA5AEFC")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1DA91F8", Offset = "0x1DA91F8", VA = "0x1DA91F8")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1DAA7CC", Offset = "0x1DAA7CC", VA = "0x1DAA7CC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1DAA7F0", Offset = "0x1DAA7F0", VA = "0x1DAA7F0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF0C", Offset = "0xA5AF0C")]
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
		[Address(RVA = "0x1DA93C0", Offset = "0x1DA93C0", VA = "0x1DA93C0")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1DAA814", Offset = "0x1DAA814", VA = "0x1DAA814")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1DAA81C", Offset = "0x1DAA81C", VA = "0x1DAA81C")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF1C", Offset = "0xA5AF1C")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1DA9514", Offset = "0x1DA9514", VA = "0x1DA9514")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1DAA8BC", Offset = "0x1DAA8BC", VA = "0x1DAA8BC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1DAA8E0", Offset = "0x1DAA8E0", VA = "0x1DAA8E0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF2C", Offset = "0xA5AF2C")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1DA9700", Offset = "0x1DA9700", VA = "0x1DA9700")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1DAA904", Offset = "0x1DAA904", VA = "0x1DAA904")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1DAA928", Offset = "0x1DAA928", VA = "0x1DAA928")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF3C", Offset = "0xA5AF3C")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1DA9904", Offset = "0x1DA9904", VA = "0x1DA9904")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1DAA94C", Offset = "0x1DAA94C", VA = "0x1DAA94C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1DAA958", Offset = "0x1DAA958", VA = "0x1DAA958")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF4C", Offset = "0xA5AF4C")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1DA9B08", Offset = "0x1DA9B08", VA = "0x1DA9B08")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1DAAA14", Offset = "0x1DAAA14", VA = "0x1DAAA14")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1DAAA20", Offset = "0x1DAAA20", VA = "0x1DAAA20")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF5C", Offset = "0xA5AF5C")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1DA9D0C", Offset = "0x1DA9D0C", VA = "0x1DA9D0C")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1DAAB24", Offset = "0x1DAAB24", VA = "0x1DAAB24")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1DAAB30", Offset = "0x1DAAB30", VA = "0x1DAAB30")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1DA5B30", Offset = "0x1DA5B30", VA = "0x1DA5B30")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1DA5C84", Offset = "0x1DA5C84", VA = "0x1DA5C84")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1DA5E00", Offset = "0x1DA5E00", VA = "0x1DA5E00")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1DA5F54", Offset = "0x1DA5F54", VA = "0x1DA5F54")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1DA60D0", Offset = "0x1DA60D0", VA = "0x1DA60D0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1DA6224", Offset = "0x1DA6224", VA = "0x1DA6224")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1DA639C", Offset = "0x1DA639C", VA = "0x1DA639C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1DA657C", Offset = "0x1DA657C", VA = "0x1DA657C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1DA66F8", Offset = "0x1DA66F8", VA = "0x1DA66F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1DA6874", Offset = "0x1DA6874", VA = "0x1DA6874")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1DA69F0", Offset = "0x1DA69F0", VA = "0x1DA69F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1DA6B6C", Offset = "0x1DA6B6C", VA = "0x1DA6B6C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1DA6CC0", Offset = "0x1DA6CC0", VA = "0x1DA6CC0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1DA6E24", Offset = "0x1DA6E24", VA = "0x1DA6E24")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1DA6FA0", Offset = "0x1DA6FA0", VA = "0x1DA6FA0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1DA7128", Offset = "0x1DA7128", VA = "0x1DA7128")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1DA72B0", Offset = "0x1DA72B0", VA = "0x1DA72B0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1DA7434", Offset = "0x1DA7434", VA = "0x1DA7434")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1DA75D0", Offset = "0x1DA75D0", VA = "0x1DA75D0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1DA776C", Offset = "0x1DA776C", VA = "0x1DA776C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1DA7908", Offset = "0x1DA7908", VA = "0x1DA7908")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1DA7A84", Offset = "0x1DA7A84", VA = "0x1DA7A84")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1DA7C00", Offset = "0x1DA7C00", VA = "0x1DA7C00")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1DA7D64", Offset = "0x1DA7D64", VA = "0x1DA7D64")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1DA7EE8", Offset = "0x1DA7EE8", VA = "0x1DA7EE8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1DA806C", Offset = "0x1DA806C", VA = "0x1DA806C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1DA81E8", Offset = "0x1DA81E8", VA = "0x1DA81E8")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1DA83B0", Offset = "0x1DA83B0", VA = "0x1DA83B0")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1DA8550", Offset = "0x1DA8550", VA = "0x1DA8550")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1DA873C", Offset = "0x1DA873C", VA = "0x1DA873C")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1DA8AE8", Offset = "0x1DA8AE8", VA = "0x1DA8AE8")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1DA8C58", Offset = "0x1DA8C58", VA = "0x1DA8C58")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1DA8DB8", Offset = "0x1DA8DB8", VA = "0x1DA8DB8")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1DA8F18", Offset = "0x1DA8F18", VA = "0x1DA8F18")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1DA9084", Offset = "0x1DA9084", VA = "0x1DA9084")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1DA9200", Offset = "0x1DA9200", VA = "0x1DA9200")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1DA93C8", Offset = "0x1DA93C8", VA = "0x1DA93C8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1DA951C", Offset = "0x1DA951C", VA = "0x1DA951C")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1DA9708", Offset = "0x1DA9708", VA = "0x1DA9708")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1DA990C", Offset = "0x1DA990C", VA = "0x1DA990C")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1DA9B10", Offset = "0x1DA9B10", VA = "0x1DA9B10")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF6C", Offset = "0xA5AF6C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1DABC60", Offset = "0x1DABC60", VA = "0x1DABC60")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1DAC490", Offset = "0x1DAC490", VA = "0x1DAC490")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1DAC4B4", Offset = "0x1DAC4B4", VA = "0x1DAC4B4")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF7C", Offset = "0xA5AF7C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1DABE38", Offset = "0x1DABE38", VA = "0x1DABE38")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1DAC4D8", Offset = "0x1DAC4D8", VA = "0x1DAC4D8")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1DAC4FC", Offset = "0x1DAC4FC", VA = "0x1DAC4FC")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF8C", Offset = "0xA5AF8C")]
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
		[Address(RVA = "0xB62240", Offset = "0xB62240", VA = "0xB62240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xB62248", Offset = "0xB62248", VA = "0xB62248", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AF9C", Offset = "0xA5AF9C")]
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
		[Address(RVA = "0xB62290", Offset = "0xB62290", VA = "0xB62290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB62298", Offset = "0xB62298", VA = "0xB62298", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AFAC", Offset = "0xA5AFAC")]
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
		[Address(RVA = "0xB62268", Offset = "0xB62268", VA = "0xB62268", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB62270", Offset = "0xB62270", VA = "0xB62270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AFBC", Offset = "0xA5AFBC")]
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
		[Address(RVA = "0xB62254", Offset = "0xB62254", VA = "0xB62254", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xB6225C", Offset = "0xB6225C", VA = "0xB6225C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AFCC", Offset = "0xA5AFCC")]
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
		[Address(RVA = "0xB6227C", Offset = "0xB6227C", VA = "0xB6227C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xB62284", Offset = "0xB62284", VA = "0xB62284", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xA5AFDC", Offset = "0xA5AFDC")]
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
		[Address(RVA = "0xB622A4", Offset = "0xB622A4", VA = "0xB622A4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xB622AC", Offset = "0xB622AC", VA = "0xB622AC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1DAB1AC", Offset = "0x1DAB1AC", VA = "0x1DAB1AC")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1DAB388", Offset = "0x1DAB388", VA = "0x1DAB388")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1DAB578", Offset = "0x1DAB578", VA = "0x1DAB578")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1DAB64C", Offset = "0x1DAB64C", VA = "0x1DAB64C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1DAB720", Offset = "0x1DAB720", VA = "0x1DAB720")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1DAB7F4", Offset = "0x1DAB7F4", VA = "0x1DAB7F4")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1DAB8D8", Offset = "0x1DAB8D8", VA = "0x1DAB8D8")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1DAB9BC", Offset = "0x1DAB9BC", VA = "0x1DAB9BC")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1DABA90", Offset = "0x1DABA90", VA = "0x1DABA90")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1DABC68", Offset = "0x1DABC68", VA = "0x1DABC68")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1DABE40", Offset = "0x1DABE40", VA = "0x1DABE40")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA5B56C", Offset = "0xA5B56C")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1DABF48", Offset = "0x1DABF48", VA = "0x1DABF48")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA5B5E0", Offset = "0xA5B5E0")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1DAC050", Offset = "0x1DAC050", VA = "0x1DAC050")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA5B654", Offset = "0xA5B654")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1DAC158", Offset = "0x1DAC158", VA = "0x1DAC158")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA5B6C8", Offset = "0xA5B6C8")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1DAC270", Offset = "0x1DAC270", VA = "0x1DAC270")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA5B73C", Offset = "0xA5B73C")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1DAC388", Offset = "0x1DAC388", VA = "0x1DAC388")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA5B7B0", Offset = "0xA5B7B0")]
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
			[Address(RVA = "0x1DA17C0", Offset = "0x1DA17C0", VA = "0x1DA17C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1DA17F4", Offset = "0x1DA17F4", VA = "0x1DA17F4")]
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
			[Address(RVA = "0x1DA19B8", Offset = "0x1DA19B8", VA = "0x1DA19B8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1DA1A1C", Offset = "0x1DA1A1C", VA = "0x1DA1A1C")]
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
			[Address(RVA = "0x1DA18BC", Offset = "0x1DA18BC", VA = "0x1DA18BC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1DA18D8", Offset = "0x1DA18D8", VA = "0x1DA18D8")]
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
			[Address(RVA = "0x1DA1828", Offset = "0x1DA1828", VA = "0x1DA1828", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1DA1874", Offset = "0x1DA1874", VA = "0x1DA1874")]
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
			[Address(RVA = "0x1DA190C", Offset = "0x1DA190C", VA = "0x1DA190C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1DA1970", Offset = "0x1DA1970", VA = "0x1DA1970")]
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
			[Address(RVA = "0x1DA1A50", Offset = "0x1DA1A50", VA = "0x1DA1A50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1DA1A84", Offset = "0x1DA1A84", VA = "0x1DA1A84")]
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
		[Address(RVA = "0x1DAD470", Offset = "0x1DAD470", VA = "0x1DAD470")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1DAD578", Offset = "0x1DAD578", VA = "0x1DAD578")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1DAD608", Offset = "0x1DAD608", VA = "0x1DAD608")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1DAD698", Offset = "0x1DAD698", VA = "0x1DAD698")]
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
	[Address(RVA = "0x1DAD32C", Offset = "0x1DAD32C", VA = "0x1DAD32C")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1DAD3D0", Offset = "0x1DAD3D0", VA = "0x1DAD3D0")]
	[Preserve]
	private static void Preserver()
	{
	}
}
