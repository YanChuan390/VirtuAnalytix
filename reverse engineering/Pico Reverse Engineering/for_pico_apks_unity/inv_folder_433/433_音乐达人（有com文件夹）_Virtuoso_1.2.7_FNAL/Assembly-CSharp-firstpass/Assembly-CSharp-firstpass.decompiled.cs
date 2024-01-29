using System.Reflection;
using System.Runtime.InteropServices;
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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93370C", Offset = "0x93370C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1668118", Offset = "0x1668118", VA = "0x1668118")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x16710C0", Offset = "0x16710C0", VA = "0x16710C0")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x16710DC", Offset = "0x16710DC", VA = "0x16710DC")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93371C", Offset = "0x93371C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x16682B8", Offset = "0x16682B8", VA = "0x16682B8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x16710F8", Offset = "0x16710F8", VA = "0x16710F8")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1671114", Offset = "0x1671114", VA = "0x1671114")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93372C", Offset = "0x93372C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x166845C", Offset = "0x166845C", VA = "0x166845C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1671130", Offset = "0x1671130", VA = "0x1671130")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1671170", Offset = "0x1671170", VA = "0x1671170")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1667F58", Offset = "0x1667F58", VA = "0x1667F58")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1668120", Offset = "0x1668120", VA = "0x1668120")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x16682C0", Offset = "0x16682C0", VA = "0x16682C0")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1668464", Offset = "0x1668464", VA = "0x1668464")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x16684D8", Offset = "0x16684D8", VA = "0x16684D8")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x166854C", Offset = "0x166854C", VA = "0x166854C")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x16685B0", Offset = "0x16685B0", VA = "0x16685B0")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1668634", Offset = "0x1668634", VA = "0x1668634")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1668698", Offset = "0x1668698", VA = "0x1668698")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x16686FC", Offset = "0x16686FC", VA = "0x16686FC")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1668760", Offset = "0x1668760", VA = "0x1668760")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x16687C4", Offset = "0x16687C4", VA = "0x16687C4")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1668830", Offset = "0x1668830", VA = "0x1668830")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1668898", Offset = "0x1668898", VA = "0x1668898")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x16688FC", Offset = "0x16688FC", VA = "0x16688FC")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93374C", Offset = "0x93374C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1668B2C", Offset = "0x1668B2C", VA = "0x1668B2C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1671194", Offset = "0x1671194", VA = "0x1671194")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93375C", Offset = "0x93375C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1668CF4", Offset = "0x1668CF4", VA = "0x1668CF4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x16712CC", Offset = "0x16712CC", VA = "0x16712CC")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93376C", Offset = "0x93376C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1668EBC", Offset = "0x1668EBC", VA = "0x1668EBC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x16712E8", Offset = "0x16712E8", VA = "0x16712E8")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93377C", Offset = "0x93377C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1669084", Offset = "0x1669084", VA = "0x1669084")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1671304", Offset = "0x1671304", VA = "0x1671304")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93378C", Offset = "0x93378C")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1669254", Offset = "0x1669254", VA = "0x1669254")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1671320", Offset = "0x1671320", VA = "0x1671320")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93379C", Offset = "0x93379C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x16694A0", Offset = "0x16694A0", VA = "0x16694A0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x167133C", Offset = "0x167133C", VA = "0x167133C")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337AC", Offset = "0x9337AC")]
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
		[Address(RVA = "0x16699A0", Offset = "0x16699A0", VA = "0x16699A0")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1671358", Offset = "0x1671358", VA = "0x1671358")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1671374", Offset = "0x1671374", VA = "0x1671374")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x16713A8", Offset = "0x16713A8", VA = "0x16713A8")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x16713C4", Offset = "0x16713C4", VA = "0x16713C4")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x16713E0", Offset = "0x16713E0", VA = "0x16713E0")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337BC", Offset = "0x9337BC")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1669C14", Offset = "0x1669C14", VA = "0x1669C14")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x16714A0", Offset = "0x16714A0", VA = "0x16714A0")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337CC", Offset = "0x9337CC")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1669E9C", Offset = "0x1669E9C", VA = "0x1669E9C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x16714BC", Offset = "0x16714BC", VA = "0x16714BC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x16714D8", Offset = "0x16714D8", VA = "0x16714D8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337DC", Offset = "0x9337DC")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x166A084", Offset = "0x166A084", VA = "0x166A084")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x16715D8", Offset = "0x16715D8", VA = "0x16715D8")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337EC", Offset = "0x9337EC")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x166A278", Offset = "0x166A278", VA = "0x166A278")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x16711B0", Offset = "0x16711B0", VA = "0x16711B0")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x16711CC", Offset = "0x16711CC", VA = "0x16711CC")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1668960", Offset = "0x1668960", VA = "0x1668960")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1668B34", Offset = "0x1668B34", VA = "0x1668B34")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1668CFC", Offset = "0x1668CFC", VA = "0x1668CFC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1668EC4", Offset = "0x1668EC4", VA = "0x1668EC4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x166908C", Offset = "0x166908C", VA = "0x166908C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x166925C", Offset = "0x166925C", VA = "0x166925C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x16694A8", Offset = "0x16694A8", VA = "0x16694A8")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x16699A8", Offset = "0x16699A8", VA = "0x16699A8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1669C1C", Offset = "0x1669C1C", VA = "0x1669C1C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1669EA4", Offset = "0x1669EA4", VA = "0x1669EA4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x166A08C", Offset = "0x166A08C", VA = "0x166A08C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93380C", Offset = "0x93380C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x166A444", Offset = "0x166A444", VA = "0x166A444")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x16715F4", Offset = "0x16715F4", VA = "0x16715F4")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93381C", Offset = "0x93381C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x166A608", Offset = "0x166A608", VA = "0x166A608")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1671610", Offset = "0x1671610", VA = "0x1671610")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93382C", Offset = "0x93382C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x166A7CC", Offset = "0x166A7CC", VA = "0x166A7CC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x167162C", Offset = "0x167162C", VA = "0x167162C")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93383C", Offset = "0x93383C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x166A970", Offset = "0x166A970", VA = "0x166A970")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1671648", Offset = "0x1671648", VA = "0x1671648")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93384C", Offset = "0x93384C")]
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

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x166ADA0", Offset = "0x166ADA0", VA = "0x166ADA0")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1671664", Offset = "0x1671664", VA = "0x1671664")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1671680", Offset = "0x1671680", VA = "0x1671680")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x167169C", Offset = "0x167169C", VA = "0x167169C")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x16716D0", Offset = "0x16716D0", VA = "0x16716D0")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x16716EC", Offset = "0x16716EC", VA = "0x16716EC")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1671708", Offset = "0x1671708", VA = "0x1671708")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x166A280", Offset = "0x166A280", VA = "0x166A280")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x166A44C", Offset = "0x166A44C", VA = "0x166A44C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x166A610", Offset = "0x166A610", VA = "0x166A610")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x166A7D4", Offset = "0x166A7D4", VA = "0x166A7D4")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x166A978", Offset = "0x166A978", VA = "0x166A978")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x2000018")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93386C", Offset = "0x93386C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x166AF68", Offset = "0x166AF68", VA = "0x166AF68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x16717C0", Offset = "0x16717C0", VA = "0x16717C0")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x16717DC", Offset = "0x16717DC", VA = "0x16717DC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93387C", Offset = "0x93387C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x166B108", Offset = "0x166B108", VA = "0x166B108")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x16717F8", Offset = "0x16717F8", VA = "0x16717F8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1671814", Offset = "0x1671814", VA = "0x1671814")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93388C", Offset = "0x93388C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x166B548", Offset = "0x166B548", VA = "0x166B548")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1671830", Offset = "0x1671830", VA = "0x1671830")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x167183C", Offset = "0x167183C", VA = "0x167183C")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x166ADA8", Offset = "0x166ADA8", VA = "0x166ADA8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x166AF70", Offset = "0x166AF70", VA = "0x166AF70")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x166B110", Offset = "0x166B110", VA = "0x166B110")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x166B2FC", Offset = "0x166B2FC", VA = "0x166B2FC")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x200001D")]
	public static class Utils
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x16726EC", Offset = "0x16726EC", VA = "0x16726EC")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338AC", Offset = "0x9338AC")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x166B6E8", Offset = "0x166B6E8", VA = "0x166B6E8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x16718E8", Offset = "0x16718E8", VA = "0x16718E8")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1671904", Offset = "0x1671904", VA = "0x1671904")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338BC", Offset = "0x9338BC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x166B8B0", Offset = "0x166B8B0", VA = "0x166B8B0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1671B58", Offset = "0x1671B58", VA = "0x1671B58")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1671B7C", Offset = "0x1671B7C", VA = "0x1671B7C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338CC", Offset = "0x9338CC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x166BA50", Offset = "0x166BA50", VA = "0x166BA50")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1671F14", Offset = "0x1671F14", VA = "0x1671F14")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1671F38", Offset = "0x1671F38", VA = "0x1671F38")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338DC", Offset = "0x9338DC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x166BC18", Offset = "0x166BC18", VA = "0x166BC18")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x16723E4", Offset = "0x16723E4", VA = "0x16723E4")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1672408", Offset = "0x1672408", VA = "0x1672408")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338EC", Offset = "0x9338EC")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x166BDB8", Offset = "0x166BDB8", VA = "0x166BDB8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x167242C", Offset = "0x167242C", VA = "0x167242C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1672450", Offset = "0x1672450", VA = "0x1672450")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338FC", Offset = "0x9338FC")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x166BF7C", Offset = "0x166BF7C", VA = "0x166BF7C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1672474", Offset = "0x1672474", VA = "0x1672474")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1672490", Offset = "0x1672490", VA = "0x1672490")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93390C", Offset = "0x93390C")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x166C330", Offset = "0x166C330", VA = "0x166C330")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x16724AC", Offset = "0x16724AC", VA = "0x16724AC")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1672510", Offset = "0x1672510", VA = "0x1672510")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93391C", Offset = "0x93391C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x166C4F0", Offset = "0x166C4F0", VA = "0x166C4F0")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x167256C", Offset = "0x167256C", VA = "0x167256C")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x16725D0", Offset = "0x16725D0", VA = "0x16725D0")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93392C", Offset = "0x93392C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x166C6B0", Offset = "0x166C6B0", VA = "0x166C6B0")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x167262C", Offset = "0x167262C", VA = "0x167262C")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1672690", Offset = "0x1672690", VA = "0x1672690")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93393C", Offset = "0x93393C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x166C878", Offset = "0x166C878", VA = "0x166C878")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1671920", Offset = "0x1671920", VA = "0x1671920")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1671940", Offset = "0x1671940", VA = "0x1671940")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93394C", Offset = "0x93394C")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x166CA18", Offset = "0x166CA18", VA = "0x166CA18")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x167195C", Offset = "0x167195C", VA = "0x167195C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x167197C", Offset = "0x167197C", VA = "0x167197C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93395C", Offset = "0x93395C")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x166CBC8", Offset = "0x166CBC8", VA = "0x166CBC8")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1671998", Offset = "0x1671998", VA = "0x1671998")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x16719B4", Offset = "0x16719B4", VA = "0x16719B4")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93396C", Offset = "0x93396C")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x166CD88", Offset = "0x166CD88", VA = "0x166CD88")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x16719D0", Offset = "0x16719D0", VA = "0x16719D0")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x16719EC", Offset = "0x16719EC", VA = "0x16719EC")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93397C", Offset = "0x93397C")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x166CF40", Offset = "0x166CF40", VA = "0x166CF40")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1671A08", Offset = "0x1671A08", VA = "0x1671A08")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1671A24", Offset = "0x1671A24", VA = "0x1671A24")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93398C", Offset = "0x93398C")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x166D0F8", Offset = "0x166D0F8", VA = "0x166D0F8")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1671A40", Offset = "0x1671A40", VA = "0x1671A40")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1671A5C", Offset = "0x1671A5C", VA = "0x1671A5C")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x93399C", Offset = "0x93399C")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x166D2C0", Offset = "0x166D2C0", VA = "0x166D2C0")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1671A78", Offset = "0x1671A78", VA = "0x1671A78")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1671A94", Offset = "0x1671A94", VA = "0x1671A94")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9339AC", Offset = "0x9339AC")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x166D47C", Offset = "0x166D47C", VA = "0x166D47C")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1671AB0", Offset = "0x1671AB0", VA = "0x1671AB0")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1671ACC", Offset = "0x1671ACC", VA = "0x1671ACC")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9339BC", Offset = "0x9339BC")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x166D638", Offset = "0x166D638", VA = "0x166D638")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1671AE8", Offset = "0x1671AE8", VA = "0x1671AE8")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1671B04", Offset = "0x1671B04", VA = "0x1671B04")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9339CC", Offset = "0x9339CC")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x166D7F4", Offset = "0x166D7F4", VA = "0x166D7F4")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1671B20", Offset = "0x1671B20", VA = "0x1671B20")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1671B3C", Offset = "0x1671B3C", VA = "0x1671B3C")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9339DC", Offset = "0x9339DC")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x166D9B4", Offset = "0x166D9B4", VA = "0x166D9B4")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1671BA0", Offset = "0x1671BA0", VA = "0x1671BA0")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1671BBC", Offset = "0x1671BBC", VA = "0x1671BBC")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9339EC", Offset = "0x9339EC")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x166DB74", Offset = "0x166DB74", VA = "0x166DB74")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1671BD8", Offset = "0x1671BD8", VA = "0x1671BD8")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1671BF4", Offset = "0x1671BF4", VA = "0x1671BF4")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9339FC", Offset = "0x9339FC")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x166DD24", Offset = "0x166DD24", VA = "0x166DD24")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1671C10", Offset = "0x1671C10", VA = "0x1671C10")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1671C2C", Offset = "0x1671C2C", VA = "0x1671C2C")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A0C", Offset = "0x933A0C")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x166DED8", Offset = "0x166DED8", VA = "0x166DED8")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1671C48", Offset = "0x1671C48", VA = "0x1671C48")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1671C64", Offset = "0x1671C64", VA = "0x1671C64")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A1C", Offset = "0x933A1C")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x166E08C", Offset = "0x166E08C", VA = "0x166E08C")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1671C80", Offset = "0x1671C80", VA = "0x1671C80")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1671C9C", Offset = "0x1671C9C", VA = "0x1671C9C")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A2C", Offset = "0x933A2C")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x166E24C", Offset = "0x166E24C", VA = "0x166E24C")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1671CB8", Offset = "0x1671CB8", VA = "0x1671CB8")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1671CD4", Offset = "0x1671CD4", VA = "0x1671CD4")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A3C", Offset = "0x933A3C")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x166E41C", Offset = "0x166E41C", VA = "0x166E41C")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1671CF0", Offset = "0x1671CF0", VA = "0x1671CF0")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1671D18", Offset = "0x1671D18", VA = "0x1671D18")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A4C", Offset = "0x933A4C")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x166E60C", Offset = "0x166E60C", VA = "0x166E60C")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1671D34", Offset = "0x1671D34", VA = "0x1671D34")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1671D5C", Offset = "0x1671D5C", VA = "0x1671D5C")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A5C", Offset = "0x933A5C")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x166E804", Offset = "0x166E804", VA = "0x166E804")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1671D78", Offset = "0x1671D78", VA = "0x1671D78")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1671DA0", Offset = "0x1671DA0", VA = "0x1671DA0")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A6C", Offset = "0x933A6C")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x166EC38", Offset = "0x166EC38", VA = "0x166EC38")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1671DBC", Offset = "0x1671DBC", VA = "0x1671DBC")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1671DD8", Offset = "0x1671DD8", VA = "0x1671DD8")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1671DF4", Offset = "0x1671DF4", VA = "0x1671DF4")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1671E28", Offset = "0x1671E28", VA = "0x1671E28")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1671E44", Offset = "0x1671E44", VA = "0x1671E44")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1671E60", Offset = "0x1671E60", VA = "0x1671E60")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A7C", Offset = "0x933A7C")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x166EDEC", Offset = "0x166EDEC", VA = "0x166EDEC")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1671F5C", Offset = "0x1671F5C", VA = "0x1671F5C")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1671FB0", Offset = "0x1671FB0", VA = "0x1671FB0")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A8C", Offset = "0x933A8C")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x166EF90", Offset = "0x166EF90", VA = "0x166EF90")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1671FFC", Offset = "0x1671FFC", VA = "0x1671FFC")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1672018", Offset = "0x1672018", VA = "0x1672018")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A9C", Offset = "0x933A9C")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x166F134", Offset = "0x166F134", VA = "0x166F134")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1672034", Offset = "0x1672034", VA = "0x1672034")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1672050", Offset = "0x1672050", VA = "0x1672050")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AAC", Offset = "0x933AAC")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x166F2E4", Offset = "0x166F2E4", VA = "0x166F2E4")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x167206C", Offset = "0x167206C", VA = "0x167206C")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1672090", Offset = "0x1672090", VA = "0x1672090")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933ABC", Offset = "0x933ABC")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x166F4AC", Offset = "0x166F4AC", VA = "0x166F4AC")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x16720B4", Offset = "0x16720B4", VA = "0x16720B4")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x16720D8", Offset = "0x16720D8", VA = "0x16720D8")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933ACC", Offset = "0x933ACC")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x166F64C", Offset = "0x166F64C", VA = "0x166F64C")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x16720FC", Offset = "0x16720FC", VA = "0x16720FC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1672120", Offset = "0x1672120", VA = "0x1672120")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933ADC", Offset = "0x933ADC")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x166F898", Offset = "0x166F898", VA = "0x166F898")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1672144", Offset = "0x1672144", VA = "0x1672144")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1672168", Offset = "0x1672168", VA = "0x1672168")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AEC", Offset = "0x933AEC")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x166FAF4", Offset = "0x166FAF4", VA = "0x166FAF4")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x167218C", Offset = "0x167218C", VA = "0x167218C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1672198", Offset = "0x1672198", VA = "0x1672198")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AFC", Offset = "0x933AFC")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x166FD50", Offset = "0x166FD50", VA = "0x166FD50")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1672254", Offset = "0x1672254", VA = "0x1672254")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1672260", Offset = "0x1672260", VA = "0x1672260")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933B0C", Offset = "0x933B0C")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x166FFAC", Offset = "0x166FFAC", VA = "0x166FFAC")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x167231C", Offset = "0x167231C", VA = "0x167231C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1672328", Offset = "0x1672328", VA = "0x1672328")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x166B550", Offset = "0x166B550", VA = "0x166B550")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x166B6F0", Offset = "0x166B6F0", VA = "0x166B6F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x166B8B8", Offset = "0x166B8B8", VA = "0x166B8B8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x166BA58", Offset = "0x166BA58", VA = "0x166BA58")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x166BC20", Offset = "0x166BC20", VA = "0x166BC20")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x166BDC0", Offset = "0x166BDC0", VA = "0x166BDC0")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x166BF84", Offset = "0x166BF84", VA = "0x166BF84")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x166C178", Offset = "0x166C178", VA = "0x166C178")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x166C338", Offset = "0x166C338", VA = "0x166C338")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x166C4F8", Offset = "0x166C4F8", VA = "0x166C4F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x166C6B8", Offset = "0x166C6B8", VA = "0x166C6B8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x166C880", Offset = "0x166C880", VA = "0x166C880")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x166CA20", Offset = "0x166CA20", VA = "0x166CA20")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x166CBD0", Offset = "0x166CBD0", VA = "0x166CBD0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x166CD90", Offset = "0x166CD90", VA = "0x166CD90")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x166CF48", Offset = "0x166CF48", VA = "0x166CF48")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x166D100", Offset = "0x166D100", VA = "0x166D100")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x166D2C8", Offset = "0x166D2C8", VA = "0x166D2C8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x166D484", Offset = "0x166D484", VA = "0x166D484")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x166D640", Offset = "0x166D640", VA = "0x166D640")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x166D7FC", Offset = "0x166D7FC", VA = "0x166D7FC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x166D9BC", Offset = "0x166D9BC", VA = "0x166D9BC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x166DB7C", Offset = "0x166DB7C", VA = "0x166DB7C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x166DD2C", Offset = "0x166DD2C", VA = "0x166DD2C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x166DEE0", Offset = "0x166DEE0", VA = "0x166DEE0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x166E094", Offset = "0x166E094", VA = "0x166E094")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x166E254", Offset = "0x166E254", VA = "0x166E254")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x166E424", Offset = "0x166E424", VA = "0x166E424")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x166E614", Offset = "0x166E614", VA = "0x166E614")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x166E80C", Offset = "0x166E80C", VA = "0x166E80C")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x166EC40", Offset = "0x166EC40", VA = "0x166EC40")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x166EDF4", Offset = "0x166EDF4", VA = "0x166EDF4")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x166EF98", Offset = "0x166EF98", VA = "0x166EF98")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x166F13C", Offset = "0x166F13C", VA = "0x166F13C")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x166F2EC", Offset = "0x166F2EC", VA = "0x166F2EC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x166F4B4", Offset = "0x166F4B4", VA = "0x166F4B4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x166F654", Offset = "0x166F654", VA = "0x166F654")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x166F8A0", Offset = "0x166F8A0", VA = "0x166F8A0")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x166FAFC", Offset = "0x166FAFC", VA = "0x166FAFC")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x166FD58", Offset = "0x166FD58", VA = "0x166FD58")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933B2C", Offset = "0x933B2C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1670B88", Offset = "0x1670B88", VA = "0x1670B88")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1672930", Offset = "0x1672930", VA = "0x1672930")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1672954", Offset = "0x1672954", VA = "0x1672954")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x933B3C", Offset = "0x933B3C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1670DA8", Offset = "0x1670DA8", VA = "0x1670DA8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1672978", Offset = "0x1672978", VA = "0x1672978")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x167299C", Offset = "0x167299C", VA = "0x167299C")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x166FFB4", Offset = "0x166FFB4", VA = "0x166FFB4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x16701A4", Offset = "0x16701A4", VA = "0x16701A4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x16703A8", Offset = "0x16703A8", VA = "0x16703A8")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1670494", Offset = "0x1670494", VA = "0x1670494")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1670580", Offset = "0x1670580", VA = "0x1670580")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x167066C", Offset = "0x167066C", VA = "0x167066C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1670778", Offset = "0x1670778", VA = "0x1670778")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1670884", Offset = "0x1670884", VA = "0x1670884")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1670970", Offset = "0x1670970", VA = "0x1670970")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1670B90", Offset = "0x1670B90", VA = "0x1670B90")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000049")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1670F28", Offset = "0x1670F28", VA = "0x1670F28", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1670468", Offset = "0x1670468", VA = "0x1670468")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x200004A")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1671028", Offset = "0x1671028", VA = "0x1671028", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1670554", Offset = "0x1670554", VA = "0x1670554")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x200004B")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1670FA8", Offset = "0x1670FA8", VA = "0x1670FA8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1670640", Offset = "0x1670640", VA = "0x1670640")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x200004C")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1670F5C", Offset = "0x1670F5C", VA = "0x1670F5C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x167073C", Offset = "0x167073C", VA = "0x167073C")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x200004D")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1670FC4", Offset = "0x1670FC4", VA = "0x1670FC4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1670848", Offset = "0x1670848", VA = "0x1670848")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x200004E")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x167108C", Offset = "0x167108C", VA = "0x167108C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1670944", Offset = "0x1670944", VA = "0x1670944")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x200004F")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x2000050")]
	public static class Physics
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x16729C0", Offset = "0x16729C0", VA = "0x16729C0")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1672AC4", Offset = "0x1672AC4", VA = "0x1672AC4")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1672B5C", Offset = "0x1672B5C", VA = "0x1672B5C")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1672BF4", Offset = "0x1672BF4", VA = "0x1672BF4")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1670DB0", Offset = "0x1670DB0", VA = "0x1670DB0")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1670E74", Offset = "0x1670E74", VA = "0x1670E74")]
	[Preserve]
	private static void Preserver()
	{
	}
}
