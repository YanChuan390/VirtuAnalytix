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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A274", Offset = "0x95A274")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x16067C0", Offset = "0x16067C0", VA = "0x16067C0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1611270", Offset = "0x1611270", VA = "0x1611270")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1611290", Offset = "0x1611290", VA = "0x1611290")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A284", Offset = "0x95A284")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1606988", Offset = "0x1606988", VA = "0x1606988")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x16112B0", Offset = "0x16112B0", VA = "0x16112B0")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x16112D0", Offset = "0x16112D0", VA = "0x16112D0")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A294", Offset = "0x95A294")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1606B64", Offset = "0x1606B64", VA = "0x1606B64")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x16112F0", Offset = "0x16112F0", VA = "0x16112F0")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1611330", Offset = "0x1611330", VA = "0x1611330")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x16065D8", Offset = "0x16065D8", VA = "0x16065D8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x16067C8", Offset = "0x16067C8", VA = "0x16067C8")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1606990", Offset = "0x1606990", VA = "0x1606990")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1606B6C", Offset = "0x1606B6C", VA = "0x1606B6C")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1606BE0", Offset = "0x1606BE0", VA = "0x1606BE0")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1606C54", Offset = "0x1606C54", VA = "0x1606C54")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1606CC0", Offset = "0x1606CC0", VA = "0x1606CC0")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1606D44", Offset = "0x1606D44", VA = "0x1606D44")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1606DB0", Offset = "0x1606DB0", VA = "0x1606DB0")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1606E1C", Offset = "0x1606E1C", VA = "0x1606E1C")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1606E88", Offset = "0x1606E88", VA = "0x1606E88")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1606EF4", Offset = "0x1606EF4", VA = "0x1606EF4")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1606F68", Offset = "0x1606F68", VA = "0x1606F68")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1606FD8", Offset = "0x1606FD8", VA = "0x1606FD8")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1607044", Offset = "0x1607044", VA = "0x1607044")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A2B4", Offset = "0x95A2B4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x16072A8", Offset = "0x16072A8", VA = "0x16072A8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1611358", Offset = "0x1611358", VA = "0x1611358")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A2C4", Offset = "0x95A2C4")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x160749C", Offset = "0x160749C", VA = "0x160749C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1611498", Offset = "0x1611498", VA = "0x1611498")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A2D4", Offset = "0x95A2D4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1607690", Offset = "0x1607690", VA = "0x1607690")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x16114B8", Offset = "0x16114B8", VA = "0x16114B8")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A2E4", Offset = "0x95A2E4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1607884", Offset = "0x1607884", VA = "0x1607884")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x16114D8", Offset = "0x16114D8", VA = "0x16114D8")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A2F4", Offset = "0x95A2F4")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1607A80", Offset = "0x1607A80", VA = "0x1607A80")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x16114F8", Offset = "0x16114F8", VA = "0x16114F8")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A304", Offset = "0x95A304")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1607CF4", Offset = "0x1607CF4", VA = "0x1607CF4")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1611518", Offset = "0x1611518", VA = "0x1611518")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A314", Offset = "0x95A314")]
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
		[Address(RVA = "0x1608258", Offset = "0x1608258", VA = "0x1608258")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1611538", Offset = "0x1611538", VA = "0x1611538")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1611558", Offset = "0x1611558", VA = "0x1611558")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x161158C", Offset = "0x161158C", VA = "0x161158C")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x16115AC", Offset = "0x16115AC", VA = "0x16115AC")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x16115CC", Offset = "0x16115CC", VA = "0x16115CC")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A324", Offset = "0x95A324")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x16084DC", Offset = "0x16084DC", VA = "0x16084DC")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x161168C", Offset = "0x161168C", VA = "0x161168C")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A334", Offset = "0x95A334")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1608790", Offset = "0x1608790", VA = "0x1608790")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x16116AC", Offset = "0x16116AC", VA = "0x16116AC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x16116CC", Offset = "0x16116CC", VA = "0x16116CC")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A344", Offset = "0x95A344")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x160899C", Offset = "0x160899C", VA = "0x160899C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x16117CC", Offset = "0x16117CC", VA = "0x16117CC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A354", Offset = "0x95A354")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1608BBC", Offset = "0x1608BBC", VA = "0x1608BBC")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1611378", Offset = "0x1611378", VA = "0x1611378")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1611398", Offset = "0x1611398", VA = "0x1611398")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x16070B0", Offset = "0x16070B0", VA = "0x16070B0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x16072B0", Offset = "0x16072B0", VA = "0x16072B0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x16074A4", Offset = "0x16074A4", VA = "0x16074A4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1607698", Offset = "0x1607698", VA = "0x1607698")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x160788C", Offset = "0x160788C", VA = "0x160788C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1607A88", Offset = "0x1607A88", VA = "0x1607A88")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1607CFC", Offset = "0x1607CFC", VA = "0x1607CFC")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1608260", Offset = "0x1608260", VA = "0x1608260")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x16084E4", Offset = "0x16084E4", VA = "0x16084E4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1608798", Offset = "0x1608798", VA = "0x1608798")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x16089A4", Offset = "0x16089A4", VA = "0x16089A4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A374", Offset = "0x95A374")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1608DAC", Offset = "0x1608DAC", VA = "0x1608DAC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16117EC", Offset = "0x16117EC", VA = "0x16117EC")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A384", Offset = "0x95A384")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1608F9C", Offset = "0x1608F9C", VA = "0x1608F9C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x161180C", Offset = "0x161180C", VA = "0x161180C")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A394", Offset = "0x95A394")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x160918C", Offset = "0x160918C", VA = "0x160918C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x161182C", Offset = "0x161182C", VA = "0x161182C")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A3A4", Offset = "0x95A3A4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1609358", Offset = "0x1609358", VA = "0x1609358")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x161184C", Offset = "0x161184C", VA = "0x161184C")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A3B4", Offset = "0x95A3B4")]
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
		[Address(RVA = "0x16097D0", Offset = "0x16097D0", VA = "0x16097D0")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x161186C", Offset = "0x161186C", VA = "0x161186C")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x161188C", Offset = "0x161188C", VA = "0x161188C")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x16118AC", Offset = "0x16118AC", VA = "0x16118AC")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x16118E0", Offset = "0x16118E0", VA = "0x16118E0")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1611900", Offset = "0x1611900", VA = "0x1611900")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1611920", Offset = "0x1611920", VA = "0x1611920")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A3C4", Offset = "0x95A3C4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1609AEC", Offset = "0x1609AEC", VA = "0x1609AEC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x16119D8", Offset = "0x16119D8", VA = "0x16119D8")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1611A00", Offset = "0x1611A00", VA = "0x1611A00")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A3D4", Offset = "0x95A3D4")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1609E2C", Offset = "0x1609E2C", VA = "0x1609E2C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1611A20", Offset = "0x1611A20", VA = "0x1611A20")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1611A40", Offset = "0x1611A40", VA = "0x1611A40")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1608BC4", Offset = "0x1608BC4", VA = "0x1608BC4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1608DB4", Offset = "0x1608DB4", VA = "0x1608DB4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1608FA4", Offset = "0x1608FA4", VA = "0x1608FA4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1609194", Offset = "0x1609194", VA = "0x1609194")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1609360", Offset = "0x1609360", VA = "0x1609360")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x16097D8", Offset = "0x16097D8", VA = "0x16097D8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1609AF4", Offset = "0x1609AF4", VA = "0x1609AF4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A3F4", Offset = "0x95A3F4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x160A01C", Offset = "0x160A01C", VA = "0x160A01C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1611B38", Offset = "0x1611B38", VA = "0x1611B38")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1611B58", Offset = "0x1611B58", VA = "0x1611B58")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A404", Offset = "0x95A404")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x160A1E4", Offset = "0x160A1E4", VA = "0x160A1E4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1611B78", Offset = "0x1611B78", VA = "0x1611B78")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1611B98", Offset = "0x1611B98", VA = "0x1611B98")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A414", Offset = "0x95A414")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x160A650", Offset = "0x160A650", VA = "0x160A650")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1611BB8", Offset = "0x1611BB8", VA = "0x1611BB8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1611BC4", Offset = "0x1611BC4", VA = "0x1611BC4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1609E34", Offset = "0x1609E34", VA = "0x1609E34")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x160A024", Offset = "0x160A024", VA = "0x160A024")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x160A1EC", Offset = "0x160A1EC", VA = "0x160A1EC")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x160A3DC", Offset = "0x160A3DC", VA = "0x160A3DC")]
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
		[Address(RVA = "0x1612C14", Offset = "0x1612C14", VA = "0x1612C14")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A434", Offset = "0x95A434")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x160A818", Offset = "0x160A818", VA = "0x160A818")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1611C70", Offset = "0x1611C70", VA = "0x1611C70")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1611C90", Offset = "0x1611C90", VA = "0x1611C90")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A444", Offset = "0x95A444")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x160AA08", Offset = "0x160AA08", VA = "0x160AA08")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1611F38", Offset = "0x1611F38", VA = "0x1611F38")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1611F60", Offset = "0x1611F60", VA = "0x1611F60")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A454", Offset = "0x95A454")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x160ABD0", Offset = "0x160ABD0", VA = "0x160ABD0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1612348", Offset = "0x1612348", VA = "0x1612348")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1612370", Offset = "0x1612370", VA = "0x1612370")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A464", Offset = "0x95A464")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x160ADC0", Offset = "0x160ADC0", VA = "0x160ADC0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x161282C", Offset = "0x161282C", VA = "0x161282C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1612854", Offset = "0x1612854", VA = "0x1612854")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A474", Offset = "0x95A474")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x160AF88", Offset = "0x160AF88", VA = "0x160AF88")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1612944", Offset = "0x1612944", VA = "0x1612944")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x161296C", Offset = "0x161296C", VA = "0x161296C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A484", Offset = "0x95A484")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x160B174", Offset = "0x160B174", VA = "0x160B174")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1612994", Offset = "0x1612994", VA = "0x1612994")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x16129B4", Offset = "0x16129B4", VA = "0x16129B4")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A494", Offset = "0x95A494")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x160B558", Offset = "0x160B558", VA = "0x160B558")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16129D4", Offset = "0x16129D4", VA = "0x16129D4")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1612A38", Offset = "0x1612A38", VA = "0x1612A38")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A4A4", Offset = "0x95A4A4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x160B744", Offset = "0x160B744", VA = "0x160B744")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1612A94", Offset = "0x1612A94", VA = "0x1612A94")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1612AF8", Offset = "0x1612AF8", VA = "0x1612AF8")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A4B4", Offset = "0x95A4B4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x160B930", Offset = "0x160B930", VA = "0x160B930")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1612B54", Offset = "0x1612B54", VA = "0x1612B54")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1612BB8", Offset = "0x1612BB8", VA = "0x1612BB8")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A4C4", Offset = "0x95A4C4")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x160BB20", Offset = "0x160BB20", VA = "0x160BB20")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1611CB0", Offset = "0x1611CB0", VA = "0x1611CB0")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1611CD4", Offset = "0x1611CD4", VA = "0x1611CD4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A4D4", Offset = "0x95A4D4")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x160BCE8", Offset = "0x160BCE8", VA = "0x160BCE8")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1611CF4", Offset = "0x1611CF4", VA = "0x1611CF4")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1611D18", Offset = "0x1611D18", VA = "0x1611D18")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A4E4", Offset = "0x95A4E4")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x160BEC0", Offset = "0x160BEC0", VA = "0x160BEC0")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1611D38", Offset = "0x1611D38", VA = "0x1611D38")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1611D58", Offset = "0x1611D58", VA = "0x1611D58")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A4F4", Offset = "0x95A4F4")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x160C0AC", Offset = "0x160C0AC", VA = "0x160C0AC")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1611D78", Offset = "0x1611D78", VA = "0x1611D78")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1611D98", Offset = "0x1611D98", VA = "0x1611D98")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A504", Offset = "0x95A504")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x160C298", Offset = "0x160C298", VA = "0x160C298")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1611DB8", Offset = "0x1611DB8", VA = "0x1611DB8")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1611DD8", Offset = "0x1611DD8", VA = "0x1611DD8")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A514", Offset = "0x95A514")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x160C484", Offset = "0x160C484", VA = "0x160C484")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1611DF8", Offset = "0x1611DF8", VA = "0x1611DF8")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1611E18", Offset = "0x1611E18", VA = "0x1611E18")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A524", Offset = "0x95A524")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x160C680", Offset = "0x160C680", VA = "0x160C680")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1611E38", Offset = "0x1611E38", VA = "0x1611E38")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1611E58", Offset = "0x1611E58", VA = "0x1611E58")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A534", Offset = "0x95A534")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x160C870", Offset = "0x160C870", VA = "0x160C870")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1611E78", Offset = "0x1611E78", VA = "0x1611E78")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1611E98", Offset = "0x1611E98", VA = "0x1611E98")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A544", Offset = "0x95A544")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x160CA60", Offset = "0x160CA60", VA = "0x160CA60")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1611EB8", Offset = "0x1611EB8", VA = "0x1611EB8")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1611ED8", Offset = "0x1611ED8", VA = "0x1611ED8")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A554", Offset = "0x95A554")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x160CC50", Offset = "0x160CC50", VA = "0x160CC50")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1611EF8", Offset = "0x1611EF8", VA = "0x1611EF8")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1611F18", Offset = "0x1611F18", VA = "0x1611F18")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A564", Offset = "0x95A564")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x160CE3C", Offset = "0x160CE3C", VA = "0x160CE3C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1611F88", Offset = "0x1611F88", VA = "0x1611F88")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1611FA8", Offset = "0x1611FA8", VA = "0x1611FA8")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A574", Offset = "0x95A574")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x160D028", Offset = "0x160D028", VA = "0x160D028")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1611FC8", Offset = "0x1611FC8", VA = "0x1611FC8")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1611FE8", Offset = "0x1611FE8", VA = "0x1611FE8")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A584", Offset = "0x95A584")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x160D200", Offset = "0x160D200", VA = "0x160D200")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1612008", Offset = "0x1612008", VA = "0x1612008")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1612028", Offset = "0x1612028", VA = "0x1612028")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A594", Offset = "0x95A594")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x160D3DC", Offset = "0x160D3DC", VA = "0x160D3DC")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1612048", Offset = "0x1612048", VA = "0x1612048")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1612068", Offset = "0x1612068", VA = "0x1612068")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A5A4", Offset = "0x95A5A4")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x160D5B8", Offset = "0x160D5B8", VA = "0x160D5B8")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1612088", Offset = "0x1612088", VA = "0x1612088")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x16120A8", Offset = "0x16120A8", VA = "0x16120A8")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A5B4", Offset = "0x95A5B4")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x160D7A4", Offset = "0x160D7A4", VA = "0x160D7A4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x16120C8", Offset = "0x16120C8", VA = "0x16120C8")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x16120E8", Offset = "0x16120E8", VA = "0x16120E8")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A5C4", Offset = "0x95A5C4")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x160D99C", Offset = "0x160D99C", VA = "0x160D99C")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1612108", Offset = "0x1612108", VA = "0x1612108")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1612130", Offset = "0x1612130", VA = "0x1612130")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A5D4", Offset = "0x95A5D4")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x160DBB8", Offset = "0x160DBB8", VA = "0x160DBB8")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1612150", Offset = "0x1612150", VA = "0x1612150")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1612178", Offset = "0x1612178", VA = "0x1612178")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A5E4", Offset = "0x95A5E4")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x160DDD8", Offset = "0x160DDD8", VA = "0x160DDD8")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1612198", Offset = "0x1612198", VA = "0x1612198")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x16121C0", Offset = "0x16121C0", VA = "0x16121C0")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A5F4", Offset = "0x95A5F4")]
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
		[Address(RVA = "0x160E240", Offset = "0x160E240", VA = "0x160E240")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x16121E0", Offset = "0x16121E0", VA = "0x16121E0")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1612200", Offset = "0x1612200", VA = "0x1612200")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1612220", Offset = "0x1612220", VA = "0x1612220")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1612254", Offset = "0x1612254", VA = "0x1612254")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1612274", Offset = "0x1612274", VA = "0x1612274")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1612294", Offset = "0x1612294", VA = "0x1612294")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A604", Offset = "0x95A604")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x160E420", Offset = "0x160E420", VA = "0x160E420")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1612398", Offset = "0x1612398", VA = "0x1612398")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x16123EC", Offset = "0x16123EC", VA = "0x16123EC")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A614", Offset = "0x95A614")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x160E5F8", Offset = "0x160E5F8", VA = "0x160E5F8")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1612438", Offset = "0x1612438", VA = "0x1612438")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1612458", Offset = "0x1612458", VA = "0x1612458")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A624", Offset = "0x95A624")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x160E7D0", Offset = "0x160E7D0", VA = "0x160E7D0")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1612478", Offset = "0x1612478", VA = "0x1612478")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1612498", Offset = "0x1612498", VA = "0x1612498")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A634", Offset = "0x95A634")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x160E9B4", Offset = "0x160E9B4", VA = "0x160E9B4")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x16124B8", Offset = "0x16124B8", VA = "0x16124B8")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x16124E0", Offset = "0x16124E0", VA = "0x16124E0")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A644", Offset = "0x95A644")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x160EBA4", Offset = "0x160EBA4", VA = "0x160EBA4")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1612508", Offset = "0x1612508", VA = "0x1612508")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1612530", Offset = "0x1612530", VA = "0x1612530")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A654", Offset = "0x95A654")]
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
		[Address(RVA = "0x160EDDC", Offset = "0x160EDDC", VA = "0x160EDDC")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1612558", Offset = "0x1612558", VA = "0x1612558")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1612560", Offset = "0x1612560", VA = "0x1612560")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A664", Offset = "0x95A664")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x160EFA4", Offset = "0x160EFA4", VA = "0x160EFA4")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x16125FC", Offset = "0x16125FC", VA = "0x16125FC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1612624", Offset = "0x1612624", VA = "0x1612624")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A674", Offset = "0x95A674")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x160F210", Offset = "0x160F210", VA = "0x160F210")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x161264C", Offset = "0x161264C", VA = "0x161264C")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1612674", Offset = "0x1612674", VA = "0x1612674")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A684", Offset = "0x95A684")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x160F494", Offset = "0x160F494", VA = "0x160F494")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x161269C", Offset = "0x161269C", VA = "0x161269C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x16126A8", Offset = "0x16126A8", VA = "0x16126A8")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A694", Offset = "0x95A694")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x160F718", Offset = "0x160F718", VA = "0x160F718")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1612764", Offset = "0x1612764", VA = "0x1612764")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1612770", Offset = "0x1612770", VA = "0x1612770")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A6A4", Offset = "0x95A6A4")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x160F99C", Offset = "0x160F99C", VA = "0x160F99C")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x161287C", Offset = "0x161287C", VA = "0x161287C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1612888", Offset = "0x1612888", VA = "0x1612888")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x160A658", Offset = "0x160A658", VA = "0x160A658")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x160A820", Offset = "0x160A820", VA = "0x160A820")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x160AA10", Offset = "0x160AA10", VA = "0x160AA10")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x160ABD8", Offset = "0x160ABD8", VA = "0x160ABD8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x160ADC8", Offset = "0x160ADC8", VA = "0x160ADC8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x160AF90", Offset = "0x160AF90", VA = "0x160AF90")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x160B17C", Offset = "0x160B17C", VA = "0x160B17C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x160B374", Offset = "0x160B374", VA = "0x160B374")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x160B560", Offset = "0x160B560", VA = "0x160B560")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x160B74C", Offset = "0x160B74C", VA = "0x160B74C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x160B938", Offset = "0x160B938", VA = "0x160B938")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x160BB28", Offset = "0x160BB28", VA = "0x160BB28")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x160BCF0", Offset = "0x160BCF0", VA = "0x160BCF0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x160BEC8", Offset = "0x160BEC8", VA = "0x160BEC8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x160C0B4", Offset = "0x160C0B4", VA = "0x160C0B4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x160C2A0", Offset = "0x160C2A0", VA = "0x160C2A0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x160C48C", Offset = "0x160C48C", VA = "0x160C48C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x160C688", Offset = "0x160C688", VA = "0x160C688")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x160C878", Offset = "0x160C878", VA = "0x160C878")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x160CA68", Offset = "0x160CA68", VA = "0x160CA68")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x160CC58", Offset = "0x160CC58", VA = "0x160CC58")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x160CE44", Offset = "0x160CE44", VA = "0x160CE44")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x160D030", Offset = "0x160D030", VA = "0x160D030")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x160D208", Offset = "0x160D208", VA = "0x160D208")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x160D3E4", Offset = "0x160D3E4", VA = "0x160D3E4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x160D5C0", Offset = "0x160D5C0", VA = "0x160D5C0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x160D7AC", Offset = "0x160D7AC", VA = "0x160D7AC")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x160D9A4", Offset = "0x160D9A4", VA = "0x160D9A4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x160DBC0", Offset = "0x160DBC0", VA = "0x160DBC0")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x160DDE0", Offset = "0x160DDE0", VA = "0x160DDE0")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x160E248", Offset = "0x160E248", VA = "0x160E248")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x160E428", Offset = "0x160E428", VA = "0x160E428")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x160E600", Offset = "0x160E600", VA = "0x160E600")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x160E7D8", Offset = "0x160E7D8", VA = "0x160E7D8")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x160E9BC", Offset = "0x160E9BC", VA = "0x160E9BC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x160EBAC", Offset = "0x160EBAC", VA = "0x160EBAC")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x160EDE4", Offset = "0x160EDE4", VA = "0x160EDE4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x160EFAC", Offset = "0x160EFAC", VA = "0x160EFAC")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x160F218", Offset = "0x160F218", VA = "0x160F218")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x160F49C", Offset = "0x160F49C", VA = "0x160F49C")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x160F720", Offset = "0x160F720", VA = "0x160F720")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A6C4", Offset = "0x95A6C4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1610628", Offset = "0x1610628", VA = "0x1610628")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1612E58", Offset = "0x1612E58", VA = "0x1612E58")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1612E80", Offset = "0x1612E80", VA = "0x1612E80")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A6D4", Offset = "0x95A6D4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1610870", Offset = "0x1610870", VA = "0x1610870")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1612EA8", Offset = "0x1612EA8", VA = "0x1612EA8")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1612ED0", Offset = "0x1612ED0", VA = "0x1612ED0")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A6E4", Offset = "0x95A6E4")]
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
		[Address(RVA = "0x1612EF8", Offset = "0x1612EF8", VA = "0x1612EF8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x161313C", Offset = "0x161313C", VA = "0x161313C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A6F4", Offset = "0x95A6F4")]
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
		[Address(RVA = "0x161384C", Offset = "0x161384C", VA = "0x161384C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1613AB4", Offset = "0x1613AB4", VA = "0x1613AB4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A704", Offset = "0x95A704")]
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
		[Address(RVA = "0x16133A0", Offset = "0x16133A0", VA = "0x16133A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x16135D0", Offset = "0x16135D0", VA = "0x16135D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A714", Offset = "0x95A714")]
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
		[Address(RVA = "0x1613148", Offset = "0x1613148", VA = "0x1613148", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1613394", Offset = "0x1613394", VA = "0x1613394", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A724", Offset = "0x95A724")]
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
		[Address(RVA = "0x16135DC", Offset = "0x16135DC", VA = "0x16135DC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1613840", Offset = "0x1613840", VA = "0x1613840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x95A734", Offset = "0x95A734")]
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
		[Address(RVA = "0x1613AC0", Offset = "0x1613AC0", VA = "0x1613AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1613CF8", Offset = "0x1613CF8", VA = "0x1613CF8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x160F9A4", Offset = "0x160F9A4", VA = "0x160F9A4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x160FB98", Offset = "0x160FB98", VA = "0x160FB98")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x160FDA0", Offset = "0x160FDA0", VA = "0x160FDA0")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x160FEA0", Offset = "0x160FEA0", VA = "0x160FEA0")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x160FFA0", Offset = "0x160FFA0", VA = "0x160FFA0")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x16100A0", Offset = "0x16100A0", VA = "0x16100A0")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x16101C4", Offset = "0x16101C4", VA = "0x16101C4")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x16102E8", Offset = "0x16102E8", VA = "0x16102E8")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x16103E8", Offset = "0x16103E8", VA = "0x16103E8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1610630", Offset = "0x1610630", VA = "0x1610630")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1610878", Offset = "0x1610878", VA = "0x1610878")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x95ACC4", Offset = "0x95ACC4")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1610998", Offset = "0x1610998", VA = "0x1610998")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x95AD3C", Offset = "0x95AD3C")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1610AB8", Offset = "0x1610AB8", VA = "0x1610AB8")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x95ADB4", Offset = "0x95ADB4")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1610BD8", Offset = "0x1610BD8", VA = "0x1610BD8")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x95AE2C", Offset = "0x95AE2C")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1610D08", Offset = "0x1610D08", VA = "0x1610D08")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x95AEA4", Offset = "0x95AEA4")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1610E38", Offset = "0x1610E38", VA = "0x1610E38")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x95AF1C", Offset = "0x95AF1C")]
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
			[Address(RVA = "0x16110D0", Offset = "0x16110D0", VA = "0x16110D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x160FE6C", Offset = "0x160FE6C", VA = "0x160FE6C")]
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
			[Address(RVA = "0x16111D4", Offset = "0x16111D4", VA = "0x16111D4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x160FF6C", Offset = "0x160FF6C", VA = "0x160FF6C")]
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
			[Address(RVA = "0x1611150", Offset = "0x1611150", VA = "0x1611150", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x161006C", Offset = "0x161006C", VA = "0x161006C")]
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
			[Address(RVA = "0x1611104", Offset = "0x1611104", VA = "0x1611104", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x161017C", Offset = "0x161017C", VA = "0x161017C")]
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
			[Address(RVA = "0x1611170", Offset = "0x1611170", VA = "0x1611170", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x16102A0", Offset = "0x16102A0", VA = "0x16102A0")]
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
			[Address(RVA = "0x1611238", Offset = "0x1611238", VA = "0x1611238", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x16103B4", Offset = "0x16103B4", VA = "0x16103B4")]
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
		[Address(RVA = "0x1613D04", Offset = "0x1613D04", VA = "0x1613D04")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1613E08", Offset = "0x1613E08", VA = "0x1613E08")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1613EA0", Offset = "0x1613EA0", VA = "0x1613EA0")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1613F38", Offset = "0x1613F38", VA = "0x1613F38")]
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
	[Address(RVA = "0x1610F58", Offset = "0x1610F58", VA = "0x1610F58")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x161101C", Offset = "0x161101C", VA = "0x161101C")]
	[Preserve]
	private static void Preserver()
	{
	}
}
