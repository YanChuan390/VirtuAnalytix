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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D18C", Offset = "0x81D18C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x190D6D8", Offset = "0x190D6D8", VA = "0x190D6D8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x19174CC", Offset = "0x19174CC", VA = "0x19174CC")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x19174E8", Offset = "0x19174E8", VA = "0x19174E8")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D19C", Offset = "0x81D19C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x190D878", Offset = "0x190D878", VA = "0x190D878")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1917504", Offset = "0x1917504", VA = "0x1917504")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1917520", Offset = "0x1917520", VA = "0x1917520")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D1AC", Offset = "0x81D1AC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x190DA1C", Offset = "0x190DA1C", VA = "0x190DA1C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x191753C", Offset = "0x191753C", VA = "0x191753C")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x191757C", Offset = "0x191757C", VA = "0x191757C")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x190D518", Offset = "0x190D518", VA = "0x190D518")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x190D6E0", Offset = "0x190D6E0", VA = "0x190D6E0")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x190D880", Offset = "0x190D880", VA = "0x190D880")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x190DA24", Offset = "0x190DA24", VA = "0x190DA24")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x190DA98", Offset = "0x190DA98", VA = "0x190DA98")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x190DB0C", Offset = "0x190DB0C", VA = "0x190DB0C")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x190DB70", Offset = "0x190DB70", VA = "0x190DB70")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x190DBF4", Offset = "0x190DBF4", VA = "0x190DBF4")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x190DC58", Offset = "0x190DC58", VA = "0x190DC58")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x190DCBC", Offset = "0x190DCBC", VA = "0x190DCBC")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x190DD20", Offset = "0x190DD20", VA = "0x190DD20")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x190DD84", Offset = "0x190DD84", VA = "0x190DD84")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x190DDF0", Offset = "0x190DDF0", VA = "0x190DDF0")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x190DE58", Offset = "0x190DE58", VA = "0x190DE58")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x190DEBC", Offset = "0x190DEBC", VA = "0x190DEBC")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D1CC", Offset = "0x81D1CC")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x190E0EC", Offset = "0x190E0EC", VA = "0x190E0EC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x19175A0", Offset = "0x19175A0", VA = "0x19175A0")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D1DC", Offset = "0x81D1DC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x190E2B4", Offset = "0x190E2B4", VA = "0x190E2B4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x19176D8", Offset = "0x19176D8", VA = "0x19176D8")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D1EC", Offset = "0x81D1EC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x190E47C", Offset = "0x190E47C", VA = "0x190E47C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x19176F4", Offset = "0x19176F4", VA = "0x19176F4")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D1FC", Offset = "0x81D1FC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x190E644", Offset = "0x190E644", VA = "0x190E644")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1917710", Offset = "0x1917710", VA = "0x1917710")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D20C", Offset = "0x81D20C")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x190E814", Offset = "0x190E814", VA = "0x190E814")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x191772C", Offset = "0x191772C", VA = "0x191772C")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D21C", Offset = "0x81D21C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x190EA60", Offset = "0x190EA60", VA = "0x190EA60")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1917748", Offset = "0x1917748", VA = "0x1917748")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D22C", Offset = "0x81D22C")]
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
		[Address(RVA = "0x190EF60", Offset = "0x190EF60", VA = "0x190EF60")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1917764", Offset = "0x1917764", VA = "0x1917764")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1917780", Offset = "0x1917780", VA = "0x1917780")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x19177B4", Offset = "0x19177B4", VA = "0x19177B4")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x19177D0", Offset = "0x19177D0", VA = "0x19177D0")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x19177EC", Offset = "0x19177EC", VA = "0x19177EC")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D23C", Offset = "0x81D23C")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x190F1D4", Offset = "0x190F1D4", VA = "0x190F1D4")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x19178AC", Offset = "0x19178AC", VA = "0x19178AC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D24C", Offset = "0x81D24C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x190F45C", Offset = "0x190F45C", VA = "0x190F45C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x19178C8", Offset = "0x19178C8", VA = "0x19178C8")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x19178E4", Offset = "0x19178E4", VA = "0x19178E4")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D25C", Offset = "0x81D25C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x190F644", Offset = "0x190F644", VA = "0x190F644")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x19179E4", Offset = "0x19179E4", VA = "0x19179E4")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D26C", Offset = "0x81D26C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x190F838", Offset = "0x190F838", VA = "0x190F838")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x19175BC", Offset = "0x19175BC", VA = "0x19175BC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x19175D8", Offset = "0x19175D8", VA = "0x19175D8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x190DF20", Offset = "0x190DF20", VA = "0x190DF20")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x190E0F4", Offset = "0x190E0F4", VA = "0x190E0F4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x190E2BC", Offset = "0x190E2BC", VA = "0x190E2BC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x190E484", Offset = "0x190E484", VA = "0x190E484")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x190E64C", Offset = "0x190E64C", VA = "0x190E64C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x190E81C", Offset = "0x190E81C", VA = "0x190E81C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x190EA68", Offset = "0x190EA68", VA = "0x190EA68")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x190EF68", Offset = "0x190EF68", VA = "0x190EF68")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x190F1DC", Offset = "0x190F1DC", VA = "0x190F1DC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x190F464", Offset = "0x190F464", VA = "0x190F464")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x190F64C", Offset = "0x190F64C", VA = "0x190F64C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D28C", Offset = "0x81D28C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x190FA04", Offset = "0x190FA04", VA = "0x190FA04")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1917A00", Offset = "0x1917A00", VA = "0x1917A00")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D29C", Offset = "0x81D29C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x190FBC8", Offset = "0x190FBC8", VA = "0x190FBC8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1917A1C", Offset = "0x1917A1C", VA = "0x1917A1C")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D2AC", Offset = "0x81D2AC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x190FD8C", Offset = "0x190FD8C", VA = "0x190FD8C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1917A38", Offset = "0x1917A38", VA = "0x1917A38")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D2BC", Offset = "0x81D2BC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x190FF30", Offset = "0x190FF30", VA = "0x190FF30")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1917A54", Offset = "0x1917A54", VA = "0x1917A54")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D2CC", Offset = "0x81D2CC")]
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
		[Address(RVA = "0x1910360", Offset = "0x1910360", VA = "0x1910360")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1917A70", Offset = "0x1917A70", VA = "0x1917A70")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1917A8C", Offset = "0x1917A8C", VA = "0x1917A8C")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1917AA8", Offset = "0x1917AA8", VA = "0x1917AA8")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1917ADC", Offset = "0x1917ADC", VA = "0x1917ADC")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1917AF8", Offset = "0x1917AF8", VA = "0x1917AF8")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1917B14", Offset = "0x1917B14", VA = "0x1917B14")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D2DC", Offset = "0x81D2DC")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1910658", Offset = "0x1910658", VA = "0x1910658")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1917BCC", Offset = "0x1917BCC", VA = "0x1917BCC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1917BF4", Offset = "0x1917BF4", VA = "0x1917BF4")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D2EC", Offset = "0x81D2EC")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1910968", Offset = "0x1910968", VA = "0x1910968")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1917C10", Offset = "0x1917C10", VA = "0x1917C10")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1917C2C", Offset = "0x1917C2C", VA = "0x1917C2C")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x190F840", Offset = "0x190F840", VA = "0x190F840")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x190FA0C", Offset = "0x190FA0C", VA = "0x190FA0C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x190FBD0", Offset = "0x190FBD0", VA = "0x190FBD0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x190FD94", Offset = "0x190FD94", VA = "0x190FD94")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x190FF38", Offset = "0x190FF38", VA = "0x190FF38")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1910368", Offset = "0x1910368", VA = "0x1910368")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1910660", Offset = "0x1910660", VA = "0x1910660")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D30C", Offset = "0x81D30C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1910B30", Offset = "0x1910B30", VA = "0x1910B30")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1917D24", Offset = "0x1917D24", VA = "0x1917D24")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1917D40", Offset = "0x1917D40", VA = "0x1917D40")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D31C", Offset = "0x81D31C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1910CD0", Offset = "0x1910CD0", VA = "0x1910CD0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1917D5C", Offset = "0x1917D5C", VA = "0x1917D5C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1917D78", Offset = "0x1917D78", VA = "0x1917D78")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D32C", Offset = "0x81D32C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1911110", Offset = "0x1911110", VA = "0x1911110")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1917D94", Offset = "0x1917D94", VA = "0x1917D94")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1917DA0", Offset = "0x1917DA0", VA = "0x1917DA0")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1910970", Offset = "0x1910970", VA = "0x1910970")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1910B38", Offset = "0x1910B38", VA = "0x1910B38")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1910CD8", Offset = "0x1910CD8", VA = "0x1910CD8")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1910EC4", Offset = "0x1910EC4", VA = "0x1910EC4")]
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
		[Address(RVA = "0x1918CF4", Offset = "0x1918CF4", VA = "0x1918CF4")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D34C", Offset = "0x81D34C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x19112B0", Offset = "0x19112B0", VA = "0x19112B0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1917E4C", Offset = "0x1917E4C", VA = "0x1917E4C")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1917E68", Offset = "0x1917E68", VA = "0x1917E68")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D35C", Offset = "0x81D35C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1911478", Offset = "0x1911478", VA = "0x1911478")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x19180BC", Offset = "0x19180BC", VA = "0x19180BC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x19180E0", Offset = "0x19180E0", VA = "0x19180E0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D36C", Offset = "0x81D36C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1911618", Offset = "0x1911618", VA = "0x1911618")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1918478", Offset = "0x1918478", VA = "0x1918478")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x191849C", Offset = "0x191849C", VA = "0x191849C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D37C", Offset = "0x81D37C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x19117E0", Offset = "0x19117E0", VA = "0x19117E0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1918924", Offset = "0x1918924", VA = "0x1918924")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1918948", Offset = "0x1918948", VA = "0x1918948")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D38C", Offset = "0x81D38C")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1911980", Offset = "0x1911980", VA = "0x1911980")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1918A34", Offset = "0x1918A34", VA = "0x1918A34")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1918A58", Offset = "0x1918A58", VA = "0x1918A58")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D39C", Offset = "0x81D39C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1911B44", Offset = "0x1911B44", VA = "0x1911B44")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1918A7C", Offset = "0x1918A7C", VA = "0x1918A7C")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1918A98", Offset = "0x1918A98", VA = "0x1918A98")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D3AC", Offset = "0x81D3AC")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1911EF8", Offset = "0x1911EF8", VA = "0x1911EF8")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1918AB4", Offset = "0x1918AB4", VA = "0x1918AB4")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1918B18", Offset = "0x1918B18", VA = "0x1918B18")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D3BC", Offset = "0x81D3BC")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x19120B8", Offset = "0x19120B8", VA = "0x19120B8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1918B74", Offset = "0x1918B74", VA = "0x1918B74")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1918BD8", Offset = "0x1918BD8", VA = "0x1918BD8")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D3CC", Offset = "0x81D3CC")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1912278", Offset = "0x1912278", VA = "0x1912278")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1918C34", Offset = "0x1918C34", VA = "0x1918C34")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1918C98", Offset = "0x1918C98", VA = "0x1918C98")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D3DC", Offset = "0x81D3DC")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1912440", Offset = "0x1912440", VA = "0x1912440")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1917E84", Offset = "0x1917E84", VA = "0x1917E84")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1917EA4", Offset = "0x1917EA4", VA = "0x1917EA4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D3EC", Offset = "0x81D3EC")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x19125E0", Offset = "0x19125E0", VA = "0x19125E0")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1917EC0", Offset = "0x1917EC0", VA = "0x1917EC0")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1917EE0", Offset = "0x1917EE0", VA = "0x1917EE0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D3FC", Offset = "0x81D3FC")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1912790", Offset = "0x1912790", VA = "0x1912790")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1917EFC", Offset = "0x1917EFC", VA = "0x1917EFC")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1917F18", Offset = "0x1917F18", VA = "0x1917F18")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D40C", Offset = "0x81D40C")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1912950", Offset = "0x1912950", VA = "0x1912950")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1917F34", Offset = "0x1917F34", VA = "0x1917F34")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1917F50", Offset = "0x1917F50", VA = "0x1917F50")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D41C", Offset = "0x81D41C")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1912B08", Offset = "0x1912B08", VA = "0x1912B08")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1917F6C", Offset = "0x1917F6C", VA = "0x1917F6C")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1917F88", Offset = "0x1917F88", VA = "0x1917F88")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D42C", Offset = "0x81D42C")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1912CC0", Offset = "0x1912CC0", VA = "0x1912CC0")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1917FA4", Offset = "0x1917FA4", VA = "0x1917FA4")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1917FC0", Offset = "0x1917FC0", VA = "0x1917FC0")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D43C", Offset = "0x81D43C")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1912E88", Offset = "0x1912E88", VA = "0x1912E88")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1917FDC", Offset = "0x1917FDC", VA = "0x1917FDC")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1917FF8", Offset = "0x1917FF8", VA = "0x1917FF8")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D44C", Offset = "0x81D44C")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1913044", Offset = "0x1913044", VA = "0x1913044")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1918014", Offset = "0x1918014", VA = "0x1918014")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1918030", Offset = "0x1918030", VA = "0x1918030")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D45C", Offset = "0x81D45C")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1913200", Offset = "0x1913200", VA = "0x1913200")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x191804C", Offset = "0x191804C", VA = "0x191804C")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1918068", Offset = "0x1918068", VA = "0x1918068")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D46C", Offset = "0x81D46C")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x19133BC", Offset = "0x19133BC", VA = "0x19133BC")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1918084", Offset = "0x1918084", VA = "0x1918084")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x19180A0", Offset = "0x19180A0", VA = "0x19180A0")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D47C", Offset = "0x81D47C")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x191357C", Offset = "0x191357C", VA = "0x191357C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1918104", Offset = "0x1918104", VA = "0x1918104")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1918120", Offset = "0x1918120", VA = "0x1918120")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D48C", Offset = "0x81D48C")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x191373C", Offset = "0x191373C", VA = "0x191373C")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x191813C", Offset = "0x191813C", VA = "0x191813C")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1918158", Offset = "0x1918158", VA = "0x1918158")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D49C", Offset = "0x81D49C")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x19138EC", Offset = "0x19138EC", VA = "0x19138EC")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1918174", Offset = "0x1918174", VA = "0x1918174")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1918190", Offset = "0x1918190", VA = "0x1918190")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D4AC", Offset = "0x81D4AC")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1913AA0", Offset = "0x1913AA0", VA = "0x1913AA0")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x19181AC", Offset = "0x19181AC", VA = "0x19181AC")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x19181C8", Offset = "0x19181C8", VA = "0x19181C8")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D4BC", Offset = "0x81D4BC")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1913C54", Offset = "0x1913C54", VA = "0x1913C54")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x19181E4", Offset = "0x19181E4", VA = "0x19181E4")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1918200", Offset = "0x1918200", VA = "0x1918200")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D4CC", Offset = "0x81D4CC")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1913E14", Offset = "0x1913E14", VA = "0x1913E14")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x191821C", Offset = "0x191821C", VA = "0x191821C")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1918238", Offset = "0x1918238", VA = "0x1918238")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D4DC", Offset = "0x81D4DC")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1913FE4", Offset = "0x1913FE4", VA = "0x1913FE4")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1918254", Offset = "0x1918254", VA = "0x1918254")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x191827C", Offset = "0x191827C", VA = "0x191827C")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D4EC", Offset = "0x81D4EC")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x19141D4", Offset = "0x19141D4", VA = "0x19141D4")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1918298", Offset = "0x1918298", VA = "0x1918298")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x19182C0", Offset = "0x19182C0", VA = "0x19182C0")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D4FC", Offset = "0x81D4FC")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x19143CC", Offset = "0x19143CC", VA = "0x19143CC")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x19182DC", Offset = "0x19182DC", VA = "0x19182DC")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1918304", Offset = "0x1918304", VA = "0x1918304")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D50C", Offset = "0x81D50C")]
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
		[Address(RVA = "0x1914800", Offset = "0x1914800", VA = "0x1914800")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1918320", Offset = "0x1918320", VA = "0x1918320")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x191833C", Offset = "0x191833C", VA = "0x191833C")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1918358", Offset = "0x1918358", VA = "0x1918358")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x191838C", Offset = "0x191838C", VA = "0x191838C")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19183A8", Offset = "0x19183A8", VA = "0x19183A8")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x19183C4", Offset = "0x19183C4", VA = "0x19183C4")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D51C", Offset = "0x81D51C")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x19149B4", Offset = "0x19149B4", VA = "0x19149B4")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x19184C0", Offset = "0x19184C0", VA = "0x19184C0")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1918514", Offset = "0x1918514", VA = "0x1918514")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D52C", Offset = "0x81D52C")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1914B58", Offset = "0x1914B58", VA = "0x1914B58")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1918560", Offset = "0x1918560", VA = "0x1918560")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x191857C", Offset = "0x191857C", VA = "0x191857C")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D53C", Offset = "0x81D53C")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1914CFC", Offset = "0x1914CFC", VA = "0x1914CFC")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1918598", Offset = "0x1918598", VA = "0x1918598")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x19185B4", Offset = "0x19185B4", VA = "0x19185B4")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D54C", Offset = "0x81D54C")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1914EAC", Offset = "0x1914EAC", VA = "0x1914EAC")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x19185D0", Offset = "0x19185D0", VA = "0x19185D0")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x19185F4", Offset = "0x19185F4", VA = "0x19185F4")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D55C", Offset = "0x81D55C")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1915074", Offset = "0x1915074", VA = "0x1915074")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1918618", Offset = "0x1918618", VA = "0x1918618")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x191863C", Offset = "0x191863C", VA = "0x191863C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D56C", Offset = "0x81D56C")]
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
		[Address(RVA = "0x1915280", Offset = "0x1915280", VA = "0x1915280")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1918660", Offset = "0x1918660", VA = "0x1918660")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1918668", Offset = "0x1918668", VA = "0x1918668")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D57C", Offset = "0x81D57C")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1915420", Offset = "0x1915420", VA = "0x1915420")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1918704", Offset = "0x1918704", VA = "0x1918704")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1918728", Offset = "0x1918728", VA = "0x1918728")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D58C", Offset = "0x81D58C")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x191566C", Offset = "0x191566C", VA = "0x191566C")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x191874C", Offset = "0x191874C", VA = "0x191874C")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1918770", Offset = "0x1918770", VA = "0x1918770")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D59C", Offset = "0x81D59C")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x19158C8", Offset = "0x19158C8", VA = "0x19158C8")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1918794", Offset = "0x1918794", VA = "0x1918794")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x19187A0", Offset = "0x19187A0", VA = "0x19187A0")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D5AC", Offset = "0x81D5AC")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1915B24", Offset = "0x1915B24", VA = "0x1915B24")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x191885C", Offset = "0x191885C", VA = "0x191885C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1918868", Offset = "0x1918868", VA = "0x1918868")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D5BC", Offset = "0x81D5BC")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1915D80", Offset = "0x1915D80", VA = "0x1915D80")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x191896C", Offset = "0x191896C", VA = "0x191896C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1918978", Offset = "0x1918978", VA = "0x1918978")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1911118", Offset = "0x1911118", VA = "0x1911118")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x19112B8", Offset = "0x19112B8", VA = "0x19112B8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1911480", Offset = "0x1911480", VA = "0x1911480")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1911620", Offset = "0x1911620", VA = "0x1911620")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x19117E8", Offset = "0x19117E8", VA = "0x19117E8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1911988", Offset = "0x1911988", VA = "0x1911988")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1911B4C", Offset = "0x1911B4C", VA = "0x1911B4C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1911D40", Offset = "0x1911D40", VA = "0x1911D40")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1911F00", Offset = "0x1911F00", VA = "0x1911F00")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x19120C0", Offset = "0x19120C0", VA = "0x19120C0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1912280", Offset = "0x1912280", VA = "0x1912280")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1912448", Offset = "0x1912448", VA = "0x1912448")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x19125E8", Offset = "0x19125E8", VA = "0x19125E8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1912798", Offset = "0x1912798", VA = "0x1912798")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1912958", Offset = "0x1912958", VA = "0x1912958")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1912B10", Offset = "0x1912B10", VA = "0x1912B10")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1912CC8", Offset = "0x1912CC8", VA = "0x1912CC8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1912E90", Offset = "0x1912E90", VA = "0x1912E90")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x191304C", Offset = "0x191304C", VA = "0x191304C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1913208", Offset = "0x1913208", VA = "0x1913208")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x19133C4", Offset = "0x19133C4", VA = "0x19133C4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1913584", Offset = "0x1913584", VA = "0x1913584")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1913744", Offset = "0x1913744", VA = "0x1913744")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x19138F4", Offset = "0x19138F4", VA = "0x19138F4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1913AA8", Offset = "0x1913AA8", VA = "0x1913AA8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1913C5C", Offset = "0x1913C5C", VA = "0x1913C5C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1913E1C", Offset = "0x1913E1C", VA = "0x1913E1C")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1913FEC", Offset = "0x1913FEC", VA = "0x1913FEC")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x19141DC", Offset = "0x19141DC", VA = "0x19141DC")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x19143D4", Offset = "0x19143D4", VA = "0x19143D4")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1914808", Offset = "0x1914808", VA = "0x1914808")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x19149BC", Offset = "0x19149BC", VA = "0x19149BC")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1914B60", Offset = "0x1914B60", VA = "0x1914B60")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1914D04", Offset = "0x1914D04", VA = "0x1914D04")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1914EB4", Offset = "0x1914EB4", VA = "0x1914EB4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x191507C", Offset = "0x191507C", VA = "0x191507C")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1915288", Offset = "0x1915288", VA = "0x1915288")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1915428", Offset = "0x1915428", VA = "0x1915428")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1915674", Offset = "0x1915674", VA = "0x1915674")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x19158D0", Offset = "0x19158D0", VA = "0x19158D0")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1915B2C", Offset = "0x1915B2C", VA = "0x1915B2C")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D5DC", Offset = "0x81D5DC")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x191695C", Offset = "0x191695C", VA = "0x191695C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1918F38", Offset = "0x1918F38", VA = "0x1918F38")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1918F5C", Offset = "0x1918F5C", VA = "0x1918F5C")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D5EC", Offset = "0x81D5EC")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1916B7C", Offset = "0x1916B7C", VA = "0x1916B7C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1918F80", Offset = "0x1918F80", VA = "0x1918F80")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1918FA4", Offset = "0x1918FA4", VA = "0x1918FA4")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D5FC", Offset = "0x81D5FC")]
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
		[Address(RVA = "0x1918FC8", Offset = "0x1918FC8", VA = "0x1918FC8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x191920C", Offset = "0x191920C", VA = "0x191920C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D60C", Offset = "0x81D60C")]
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
		[Address(RVA = "0x191991C", Offset = "0x191991C", VA = "0x191991C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1919B84", Offset = "0x1919B84", VA = "0x1919B84", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D61C", Offset = "0x81D61C")]
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
		[Address(RVA = "0x1919470", Offset = "0x1919470", VA = "0x1919470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x19196A0", Offset = "0x19196A0", VA = "0x19196A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D62C", Offset = "0x81D62C")]
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
		[Address(RVA = "0x1919218", Offset = "0x1919218", VA = "0x1919218", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1919464", Offset = "0x1919464", VA = "0x1919464", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D63C", Offset = "0x81D63C")]
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
		[Address(RVA = "0x19196AC", Offset = "0x19196AC", VA = "0x19196AC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1919910", Offset = "0x1919910", VA = "0x1919910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81D64C", Offset = "0x81D64C")]
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
		[Address(RVA = "0x1919B90", Offset = "0x1919B90", VA = "0x1919B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1919DC8", Offset = "0x1919DC8", VA = "0x1919DC8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1915D88", Offset = "0x1915D88", VA = "0x1915D88")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1915F78", Offset = "0x1915F78", VA = "0x1915F78")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x191617C", Offset = "0x191617C", VA = "0x191617C")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1916268", Offset = "0x1916268", VA = "0x1916268")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1916354", Offset = "0x1916354", VA = "0x1916354")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1916440", Offset = "0x1916440", VA = "0x1916440")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x191654C", Offset = "0x191654C", VA = "0x191654C")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1916658", Offset = "0x1916658", VA = "0x1916658")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1916744", Offset = "0x1916744", VA = "0x1916744")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1916964", Offset = "0x1916964", VA = "0x1916964")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1916B84", Offset = "0x1916B84", VA = "0x1916B84")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x81DBDC", Offset = "0x81DBDC")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1916C88", Offset = "0x1916C88", VA = "0x1916C88")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x81DC4C", Offset = "0x81DC4C")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1916D8C", Offset = "0x1916D8C", VA = "0x1916D8C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x81DCBC", Offset = "0x81DCBC")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1916E90", Offset = "0x1916E90", VA = "0x1916E90")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x81DD2C", Offset = "0x81DD2C")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1916FA4", Offset = "0x1916FA4", VA = "0x1916FA4")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x81DD9C", Offset = "0x81DD9C")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x19170B8", Offset = "0x19170B8", VA = "0x19170B8")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x81DE0C", Offset = "0x81DE0C")]
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
			[Address(RVA = "0x1917334", Offset = "0x1917334", VA = "0x1917334", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x191623C", Offset = "0x191623C", VA = "0x191623C")]
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
			[Address(RVA = "0x1917434", Offset = "0x1917434", VA = "0x1917434", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1916328", Offset = "0x1916328", VA = "0x1916328")]
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
			[Address(RVA = "0x19173B4", Offset = "0x19173B4", VA = "0x19173B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1916414", Offset = "0x1916414", VA = "0x1916414")]
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
			[Address(RVA = "0x1917368", Offset = "0x1917368", VA = "0x1917368", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1916510", Offset = "0x1916510", VA = "0x1916510")]
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
			[Address(RVA = "0x19173D0", Offset = "0x19173D0", VA = "0x19173D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x191661C", Offset = "0x191661C", VA = "0x191661C")]
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
			[Address(RVA = "0x1917498", Offset = "0x1917498", VA = "0x1917498", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1916718", Offset = "0x1916718", VA = "0x1916718")]
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
		[Address(RVA = "0x1919DD4", Offset = "0x1919DD4", VA = "0x1919DD4")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1919ED8", Offset = "0x1919ED8", VA = "0x1919ED8")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1919F70", Offset = "0x1919F70", VA = "0x1919F70")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x191A008", Offset = "0x191A008", VA = "0x191A008")]
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
	[Address(RVA = "0x19171BC", Offset = "0x19171BC", VA = "0x19171BC")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1917280", Offset = "0x1917280", VA = "0x1917280")]
	[Preserve]
	private static void Preserver()
	{
	}
}
