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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7054", Offset = "0x9C7054")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1C0EAD4", Offset = "0x1C0EAD4", VA = "0x1C0EAD4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1C0F2C4", Offset = "0x1C0F2C4", VA = "0x1C0F2C4")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1C0F2E0", Offset = "0x1C0F2E0", VA = "0x1C0F2E0")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7064", Offset = "0x9C7064")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1C0EC28", Offset = "0x1C0EC28", VA = "0x1C0EC28")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1C0F2FC", Offset = "0x1C0F2FC", VA = "0x1C0F2FC")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1C0F318", Offset = "0x1C0F318", VA = "0x1C0F318")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7074", Offset = "0x9C7074")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1C0ED90", Offset = "0x1C0ED90", VA = "0x1C0ED90")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1C0F334", Offset = "0x1C0F334", VA = "0x1C0F334")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1C0F374", Offset = "0x1C0F374", VA = "0x1C0F374")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1C0E960", Offset = "0x1C0E960", VA = "0x1C0E960")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1C0EADC", Offset = "0x1C0EADC", VA = "0x1C0EADC")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1C0EC30", Offset = "0x1C0EC30", VA = "0x1C0EC30")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1C0ED98", Offset = "0x1C0ED98", VA = "0x1C0ED98")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1C0EE10", Offset = "0x1C0EE10", VA = "0x1C0EE10")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1C0EE88", Offset = "0x1C0EE88", VA = "0x1C0EE88")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1C0EEF0", Offset = "0x1C0EEF0", VA = "0x1C0EEF0")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1C0EF78", Offset = "0x1C0EF78", VA = "0x1C0EF78")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1C0EFE0", Offset = "0x1C0EFE0", VA = "0x1C0EFE0")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1C0F048", Offset = "0x1C0F048", VA = "0x1C0F048")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1C0F0B0", Offset = "0x1C0F0B0", VA = "0x1C0F0B0")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1C0F118", Offset = "0x1C0F118", VA = "0x1C0F118")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1C0F188", Offset = "0x1C0F188", VA = "0x1C0F188")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1C0F1F4", Offset = "0x1C0F1F4", VA = "0x1C0F1F4")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1C0F25C", Offset = "0x1C0F25C", VA = "0x1C0F25C")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7084", Offset = "0x9C7084")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1C0F518", Offset = "0x1C0F518", VA = "0x1C0F518")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1C109A0", Offset = "0x1C109A0", VA = "0x1C109A0")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7094", Offset = "0x9C7094")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1C0F6B8", Offset = "0x1C0F6B8", VA = "0x1C0F6B8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1C10ADC", Offset = "0x1C10ADC", VA = "0x1C10ADC")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C70A4", Offset = "0x9C70A4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1C0F858", Offset = "0x1C0F858", VA = "0x1C0F858")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1C10AF8", Offset = "0x1C10AF8", VA = "0x1C10AF8")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C70B4", Offset = "0x9C70B4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1C0F9F8", Offset = "0x1C0F9F8", VA = "0x1C0F9F8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1C10B14", Offset = "0x1C10B14", VA = "0x1C10B14")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C70C4", Offset = "0x9C70C4")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1C0FB7C", Offset = "0x1C0FB7C", VA = "0x1C0FB7C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1C10B30", Offset = "0x1C10B30", VA = "0x1C10B30")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C70D4", Offset = "0x9C70D4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1C0FD78", Offset = "0x1C0FD78", VA = "0x1C0FD78")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1C10B4C", Offset = "0x1C10B4C", VA = "0x1C10B4C")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C70E4", Offset = "0x9C70E4")]
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
		[Address(RVA = "0x1C10230", Offset = "0x1C10230", VA = "0x1C10230")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1C10B68", Offset = "0x1C10B68", VA = "0x1C10B68")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1C10B84", Offset = "0x1C10B84", VA = "0x1C10B84")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1C10BB8", Offset = "0x1C10BB8", VA = "0x1C10BB8")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1C10BD4", Offset = "0x1C10BD4", VA = "0x1C10BD4")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1C10BF0", Offset = "0x1C10BF0", VA = "0x1C10BF0")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C70F4", Offset = "0x9C70F4")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1C10434", Offset = "0x1C10434", VA = "0x1C10434")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1C10CB0", Offset = "0x1C10CB0", VA = "0x1C10CB0")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7104", Offset = "0x9C7104")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1C10658", Offset = "0x1C10658", VA = "0x1C10658")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1C10CCC", Offset = "0x1C10CCC", VA = "0x1C10CCC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1C10CE8", Offset = "0x1C10CE8", VA = "0x1C10CE8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7114", Offset = "0x9C7114")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1C107E8", Offset = "0x1C107E8", VA = "0x1C107E8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1C10DEC", Offset = "0x1C10DEC", VA = "0x1C10DEC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7124", Offset = "0x9C7124")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1C10998", Offset = "0x1C10998", VA = "0x1C10998")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1C109BC", Offset = "0x1C109BC", VA = "0x1C109BC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1C109D8", Offset = "0x1C109D8", VA = "0x1C109D8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1C0F398", Offset = "0x1C0F398", VA = "0x1C0F398")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1C0F520", Offset = "0x1C0F520", VA = "0x1C0F520")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1C0F6C0", Offset = "0x1C0F6C0", VA = "0x1C0F6C0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1C0F860", Offset = "0x1C0F860", VA = "0x1C0F860")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1C0FA00", Offset = "0x1C0FA00", VA = "0x1C0FA00")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1C0FB84", Offset = "0x1C0FB84", VA = "0x1C0FB84")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1C0FD80", Offset = "0x1C0FD80", VA = "0x1C0FD80")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1C10238", Offset = "0x1C10238", VA = "0x1C10238")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1C1043C", Offset = "0x1C1043C", VA = "0x1C1043C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1C10660", Offset = "0x1C10660", VA = "0x1C10660")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1C107F0", Offset = "0x1C107F0", VA = "0x1C107F0")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7134", Offset = "0x9C7134")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1C10F80", Offset = "0x1C10F80", VA = "0x1C10F80")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1C11D54", Offset = "0x1C11D54", VA = "0x1C11D54")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7144", Offset = "0x9C7144")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1C1110C", Offset = "0x1C1110C", VA = "0x1C1110C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1C11D70", Offset = "0x1C11D70", VA = "0x1C11D70")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7154", Offset = "0x9C7154")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1C11298", Offset = "0x1C11298", VA = "0x1C11298")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1C11D8C", Offset = "0x1C11D8C", VA = "0x1C11D8C")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7164", Offset = "0x9C7164")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1C113F0", Offset = "0x1C113F0", VA = "0x1C113F0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1C11DA8", Offset = "0x1C11DA8", VA = "0x1C11DA8")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7174", Offset = "0x9C7174")]
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
		[Address(RVA = "0x1C117A4", Offset = "0x1C117A4", VA = "0x1C117A4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1C11DC4", Offset = "0x1C11DC4", VA = "0x1C11DC4")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1C11DE0", Offset = "0x1C11DE0", VA = "0x1C11DE0")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1C11DFC", Offset = "0x1C11DFC", VA = "0x1C11DFC")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1C11E30", Offset = "0x1C11E30", VA = "0x1C11E30")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1C11E4C", Offset = "0x1C11E4C", VA = "0x1C11E4C")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1C11E68", Offset = "0x1C11E68", VA = "0x1C11E68")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7184", Offset = "0x9C7184")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1C11A68", Offset = "0x1C11A68", VA = "0x1C11A68")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1C11F90", Offset = "0x1C11F90", VA = "0x1C11F90")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1C12020", Offset = "0x1C12020", VA = "0x1C12020")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7194", Offset = "0x9C7194")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1C11D4C", Offset = "0x1C11D4C", VA = "0x1C11D4C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1C120C4", Offset = "0x1C120C4", VA = "0x1C120C4")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1C120E0", Offset = "0x1C120E0", VA = "0x1C120E0")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1C10E08", Offset = "0x1C10E08", VA = "0x1C10E08")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1C10F88", Offset = "0x1C10F88", VA = "0x1C10F88")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1C11114", Offset = "0x1C11114", VA = "0x1C11114")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1C112A0", Offset = "0x1C112A0", VA = "0x1C112A0")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1C113F8", Offset = "0x1C113F8", VA = "0x1C113F8")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1C117AC", Offset = "0x1C117AC", VA = "0x1C117AC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1C11A70", Offset = "0x1C11A70", VA = "0x1C11A70")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C71A4", Offset = "0x9C71A4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1C12380", Offset = "0x1C12380", VA = "0x1C12380")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1C128B0", Offset = "0x1C128B0", VA = "0x1C128B0")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1C128CC", Offset = "0x1C128CC", VA = "0x1C128CC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C71B4", Offset = "0x9C71B4")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1C124D4", Offset = "0x1C124D4", VA = "0x1C124D4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1C128E8", Offset = "0x1C128E8", VA = "0x1C128E8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1C12904", Offset = "0x1C12904", VA = "0x1C12904")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C71C4", Offset = "0x9C71C4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1C128A8", Offset = "0x1C128A8", VA = "0x1C128A8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1C12920", Offset = "0x1C12920", VA = "0x1C12920")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1C1292C", Offset = "0x1C1292C", VA = "0x1C1292C")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1C1220C", Offset = "0x1C1220C", VA = "0x1C1220C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1C12388", Offset = "0x1C12388", VA = "0x1C12388")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1C124DC", Offset = "0x1C124DC", VA = "0x1C124DC")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1C126B4", Offset = "0x1C126B4", VA = "0x1C126B4")]
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
		[Address(RVA = "0x1C17DA8", Offset = "0x1C17DA8", VA = "0x1C17DA8")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C71D4", Offset = "0x9C71D4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1C12B24", Offset = "0x1C12B24", VA = "0x1C12B24")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1C16BBC", Offset = "0x1C16BBC", VA = "0x1C16BBC")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1C16BD8", Offset = "0x1C16BD8", VA = "0x1C16BD8")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C71E4", Offset = "0x9C71E4")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1C12CA0", Offset = "0x1C12CA0", VA = "0x1C12CA0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1C16E2C", Offset = "0x1C16E2C", VA = "0x1C16E2C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1C16E50", Offset = "0x1C16E50", VA = "0x1C16E50")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C71F4", Offset = "0x9C71F4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1C12DF4", Offset = "0x1C12DF4", VA = "0x1C12DF4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1C174B8", Offset = "0x1C174B8", VA = "0x1C174B8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1C174DC", Offset = "0x1C174DC", VA = "0x1C174DC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7204", Offset = "0x9C7204")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1C12F70", Offset = "0x1C12F70", VA = "0x1C12F70")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1C17984", Offset = "0x1C17984", VA = "0x1C17984")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1C179A8", Offset = "0x1C179A8", VA = "0x1C179A8")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7214", Offset = "0x9C7214")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1C130C4", Offset = "0x1C130C4", VA = "0x1C130C4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1C17A94", Offset = "0x1C17A94", VA = "0x1C17A94")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1C17AB8", Offset = "0x1C17AB8", VA = "0x1C17AB8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7224", Offset = "0x9C7224")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1C1323C", Offset = "0x1C1323C", VA = "0x1C1323C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1C17ADC", Offset = "0x1C17ADC", VA = "0x1C17ADC")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1C17AF8", Offset = "0x1C17AF8", VA = "0x1C17AF8")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7234", Offset = "0x9C7234")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1C13598", Offset = "0x1C13598", VA = "0x1C13598")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1C17B14", Offset = "0x1C17B14", VA = "0x1C17B14")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1C17B94", Offset = "0x1C17B94", VA = "0x1C17B94")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7244", Offset = "0x9C7244")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1C13714", Offset = "0x1C13714", VA = "0x1C13714")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1C17BF0", Offset = "0x1C17BF0", VA = "0x1C17BF0")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1C17C70", Offset = "0x1C17C70", VA = "0x1C17C70")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7254", Offset = "0x9C7254")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1C13890", Offset = "0x1C13890", VA = "0x1C13890")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1C17CCC", Offset = "0x1C17CCC", VA = "0x1C17CCC")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1C17D4C", Offset = "0x1C17D4C", VA = "0x1C17D4C")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7264", Offset = "0x9C7264")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1C13A0C", Offset = "0x1C13A0C", VA = "0x1C13A0C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1C16BF4", Offset = "0x1C16BF4", VA = "0x1C16BF4")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1C16C14", Offset = "0x1C16C14", VA = "0x1C16C14")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7274", Offset = "0x9C7274")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1C13B60", Offset = "0x1C13B60", VA = "0x1C13B60")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1C16C30", Offset = "0x1C16C30", VA = "0x1C16C30")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1C16C50", Offset = "0x1C16C50", VA = "0x1C16C50")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7284", Offset = "0x9C7284")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1C13CC4", Offset = "0x1C13CC4", VA = "0x1C13CC4")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1C16C6C", Offset = "0x1C16C6C", VA = "0x1C16C6C")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1C16C88", Offset = "0x1C16C88", VA = "0x1C16C88")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7294", Offset = "0x9C7294")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1C13E40", Offset = "0x1C13E40", VA = "0x1C13E40")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1C16CA4", Offset = "0x1C16CA4", VA = "0x1C16CA4")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1C16CC0", Offset = "0x1C16CC0", VA = "0x1C16CC0")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C72A4", Offset = "0x9C72A4")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1C13FC8", Offset = "0x1C13FC8", VA = "0x1C13FC8")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1C16CDC", Offset = "0x1C16CDC", VA = "0x1C16CDC")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1C16CF8", Offset = "0x1C16CF8", VA = "0x1C16CF8")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C72B4", Offset = "0x9C72B4")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1C14150", Offset = "0x1C14150", VA = "0x1C14150")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1C16D14", Offset = "0x1C16D14", VA = "0x1C16D14")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1C16D30", Offset = "0x1C16D30", VA = "0x1C16D30")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C72C4", Offset = "0x9C72C4")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1C142D4", Offset = "0x1C142D4", VA = "0x1C142D4")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1C16D4C", Offset = "0x1C16D4C", VA = "0x1C16D4C")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1C16D68", Offset = "0x1C16D68", VA = "0x1C16D68")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C72D4", Offset = "0x9C72D4")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1C14470", Offset = "0x1C14470", VA = "0x1C14470")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1C16D84", Offset = "0x1C16D84", VA = "0x1C16D84")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1C16DA0", Offset = "0x1C16DA0", VA = "0x1C16DA0")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C72E4", Offset = "0x9C72E4")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1C1460C", Offset = "0x1C1460C", VA = "0x1C1460C")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1C16DBC", Offset = "0x1C16DBC", VA = "0x1C16DBC")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1C16DD8", Offset = "0x1C16DD8", VA = "0x1C16DD8")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C72F4", Offset = "0x9C72F4")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1C147A8", Offset = "0x1C147A8", VA = "0x1C147A8")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1C16DF4", Offset = "0x1C16DF4", VA = "0x1C16DF4")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1C16E10", Offset = "0x1C16E10", VA = "0x1C16E10")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7304", Offset = "0x9C7304")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1C14924", Offset = "0x1C14924", VA = "0x1C14924")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1C16E74", Offset = "0x1C16E74", VA = "0x1C16E74")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1C16E90", Offset = "0x1C16E90", VA = "0x1C16E90")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7314", Offset = "0x9C7314")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1C14AA0", Offset = "0x1C14AA0", VA = "0x1C14AA0")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1C16EAC", Offset = "0x1C16EAC", VA = "0x1C16EAC")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1C16EC8", Offset = "0x1C16EC8", VA = "0x1C16EC8")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7324", Offset = "0x9C7324")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1C14C04", Offset = "0x1C14C04", VA = "0x1C14C04")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1C16EE4", Offset = "0x1C16EE4", VA = "0x1C16EE4")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1C16F00", Offset = "0x1C16F00", VA = "0x1C16F00")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7334", Offset = "0x9C7334")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1C14D88", Offset = "0x1C14D88", VA = "0x1C14D88")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1C16F1C", Offset = "0x1C16F1C", VA = "0x1C16F1C")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1C16F38", Offset = "0x1C16F38", VA = "0x1C16F38")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7344", Offset = "0x9C7344")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1C14F0C", Offset = "0x1C14F0C", VA = "0x1C14F0C")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1C16F54", Offset = "0x1C16F54", VA = "0x1C16F54")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1C16F70", Offset = "0x1C16F70", VA = "0x1C16F70")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7354", Offset = "0x9C7354")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1C15088", Offset = "0x1C15088", VA = "0x1C15088")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1C16F8C", Offset = "0x1C16F8C", VA = "0x1C16F8C")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1C16FA8", Offset = "0x1C16FA8", VA = "0x1C16FA8")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7364", Offset = "0x9C7364")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1C15250", Offset = "0x1C15250", VA = "0x1C15250")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1C16FC4", Offset = "0x1C16FC4", VA = "0x1C16FC4")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1C17054", Offset = "0x1C17054", VA = "0x1C17054")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7374", Offset = "0x9C7374")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1C153F0", Offset = "0x1C153F0", VA = "0x1C153F0")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1C170F8", Offset = "0x1C170F8", VA = "0x1C170F8")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1C17188", Offset = "0x1C17188", VA = "0x1C17188")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7384", Offset = "0x9C7384")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1C155DC", Offset = "0x1C155DC", VA = "0x1C155DC")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1C1722C", Offset = "0x1C1722C", VA = "0x1C1722C")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1C172BC", Offset = "0x1C172BC", VA = "0x1C172BC")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7394", Offset = "0x9C7394")]
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
		[Address(RVA = "0x1C15988", Offset = "0x1C15988", VA = "0x1C15988")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1C17360", Offset = "0x1C17360", VA = "0x1C17360")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1C1737C", Offset = "0x1C1737C", VA = "0x1C1737C")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1C17398", Offset = "0x1C17398", VA = "0x1C17398")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1C173CC", Offset = "0x1C173CC", VA = "0x1C173CC")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1C173E8", Offset = "0x1C173E8", VA = "0x1C173E8")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1C17404", Offset = "0x1C17404", VA = "0x1C17404")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C73A4", Offset = "0x9C73A4")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1C15AF8", Offset = "0x1C15AF8", VA = "0x1C15AF8")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1C17500", Offset = "0x1C17500", VA = "0x1C17500")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1C17570", Offset = "0x1C17570", VA = "0x1C17570")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C73B4", Offset = "0x9C73B4")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1C15C58", Offset = "0x1C15C58", VA = "0x1C15C58")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1C175BC", Offset = "0x1C175BC", VA = "0x1C175BC")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1C175D8", Offset = "0x1C175D8", VA = "0x1C175D8")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C73C4", Offset = "0x9C73C4")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1C15DB8", Offset = "0x1C15DB8", VA = "0x1C15DB8")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1C175F4", Offset = "0x1C175F4", VA = "0x1C175F4")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1C17610", Offset = "0x1C17610", VA = "0x1C17610")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C73D4", Offset = "0x9C73D4")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1C15F24", Offset = "0x1C15F24", VA = "0x1C15F24")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1C1762C", Offset = "0x1C1762C", VA = "0x1C1762C")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1C17650", Offset = "0x1C17650", VA = "0x1C17650")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C73E4", Offset = "0x9C73E4")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1C160A0", Offset = "0x1C160A0", VA = "0x1C160A0")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1C17674", Offset = "0x1C17674", VA = "0x1C17674")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1C17698", Offset = "0x1C17698", VA = "0x1C17698")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C73F4", Offset = "0x9C73F4")]
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
		[Address(RVA = "0x1C16268", Offset = "0x1C16268", VA = "0x1C16268")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1C176BC", Offset = "0x1C176BC", VA = "0x1C176BC")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1C176C4", Offset = "0x1C176C4", VA = "0x1C176C4")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7404", Offset = "0x9C7404")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1C163BC", Offset = "0x1C163BC", VA = "0x1C163BC")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1C17764", Offset = "0x1C17764", VA = "0x1C17764")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1C17788", Offset = "0x1C17788", VA = "0x1C17788")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7414", Offset = "0x9C7414")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1C165A8", Offset = "0x1C165A8", VA = "0x1C165A8")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1C177AC", Offset = "0x1C177AC", VA = "0x1C177AC")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1C177D0", Offset = "0x1C177D0", VA = "0x1C177D0")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7424", Offset = "0x9C7424")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1C167AC", Offset = "0x1C167AC", VA = "0x1C167AC")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1C177F4", Offset = "0x1C177F4", VA = "0x1C177F4")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1C17800", Offset = "0x1C17800", VA = "0x1C17800")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7434", Offset = "0x9C7434")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1C169B0", Offset = "0x1C169B0", VA = "0x1C169B0")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1C178BC", Offset = "0x1C178BC", VA = "0x1C178BC")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1C178C8", Offset = "0x1C178C8", VA = "0x1C178C8")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7444", Offset = "0x9C7444")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1C16BB4", Offset = "0x1C16BB4", VA = "0x1C16BB4")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1C179CC", Offset = "0x1C179CC", VA = "0x1C179CC")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1C179D8", Offset = "0x1C179D8", VA = "0x1C179D8")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1C129D8", Offset = "0x1C129D8", VA = "0x1C129D8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1C12B2C", Offset = "0x1C12B2C", VA = "0x1C12B2C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1C12CA8", Offset = "0x1C12CA8", VA = "0x1C12CA8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1C12DFC", Offset = "0x1C12DFC", VA = "0x1C12DFC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1C12F78", Offset = "0x1C12F78", VA = "0x1C12F78")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1C130CC", Offset = "0x1C130CC", VA = "0x1C130CC")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1C13244", Offset = "0x1C13244", VA = "0x1C13244")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1C13424", Offset = "0x1C13424", VA = "0x1C13424")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1C135A0", Offset = "0x1C135A0", VA = "0x1C135A0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1C1371C", Offset = "0x1C1371C", VA = "0x1C1371C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1C13898", Offset = "0x1C13898", VA = "0x1C13898")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1C13A14", Offset = "0x1C13A14", VA = "0x1C13A14")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1C13B68", Offset = "0x1C13B68", VA = "0x1C13B68")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1C13CCC", Offset = "0x1C13CCC", VA = "0x1C13CCC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1C13E48", Offset = "0x1C13E48", VA = "0x1C13E48")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1C13FD0", Offset = "0x1C13FD0", VA = "0x1C13FD0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1C14158", Offset = "0x1C14158", VA = "0x1C14158")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1C142DC", Offset = "0x1C142DC", VA = "0x1C142DC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1C14478", Offset = "0x1C14478", VA = "0x1C14478")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1C14614", Offset = "0x1C14614", VA = "0x1C14614")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1C147B0", Offset = "0x1C147B0", VA = "0x1C147B0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1C1492C", Offset = "0x1C1492C", VA = "0x1C1492C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1C14AA8", Offset = "0x1C14AA8", VA = "0x1C14AA8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1C14C0C", Offset = "0x1C14C0C", VA = "0x1C14C0C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1C14D90", Offset = "0x1C14D90", VA = "0x1C14D90")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1C14F14", Offset = "0x1C14F14", VA = "0x1C14F14")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1C15090", Offset = "0x1C15090", VA = "0x1C15090")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1C15258", Offset = "0x1C15258", VA = "0x1C15258")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1C153F8", Offset = "0x1C153F8", VA = "0x1C153F8")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1C155E4", Offset = "0x1C155E4", VA = "0x1C155E4")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1C15990", Offset = "0x1C15990", VA = "0x1C15990")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1C15B00", Offset = "0x1C15B00", VA = "0x1C15B00")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1C15C60", Offset = "0x1C15C60", VA = "0x1C15C60")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1C15DC0", Offset = "0x1C15DC0", VA = "0x1C15DC0")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1C15F2C", Offset = "0x1C15F2C", VA = "0x1C15F2C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1C160A8", Offset = "0x1C160A8", VA = "0x1C160A8")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1C16270", Offset = "0x1C16270", VA = "0x1C16270")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1C163C4", Offset = "0x1C163C4", VA = "0x1C163C4")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1C165B0", Offset = "0x1C165B0", VA = "0x1C165B0")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1C167B4", Offset = "0x1C167B4", VA = "0x1C167B4")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1C169B8", Offset = "0x1C169B8", VA = "0x1C169B8")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7454", Offset = "0x9C7454")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1C18B08", Offset = "0x1C18B08", VA = "0x1C18B08")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1C19338", Offset = "0x1C19338", VA = "0x1C19338")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1C1935C", Offset = "0x1C1935C", VA = "0x1C1935C")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7464", Offset = "0x9C7464")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1C18CE0", Offset = "0x1C18CE0", VA = "0x1C18CE0")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1C19380", Offset = "0x1C19380", VA = "0x1C19380")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1C193A4", Offset = "0x1C193A4", VA = "0x1C193A4")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7474", Offset = "0x9C7474")]
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
		[Address(RVA = "0xAC4EC4", Offset = "0xAC4EC4", VA = "0xAC4EC4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xAC4ECC", Offset = "0xAC4ECC", VA = "0xAC4ECC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7484", Offset = "0x9C7484")]
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
		[Address(RVA = "0xAC4F14", Offset = "0xAC4F14", VA = "0xAC4F14", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xAC4F1C", Offset = "0xAC4F1C", VA = "0xAC4F1C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7494", Offset = "0x9C7494")]
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
		[Address(RVA = "0xAC4EEC", Offset = "0xAC4EEC", VA = "0xAC4EEC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xAC4EF4", Offset = "0xAC4EF4", VA = "0xAC4EF4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C74A4", Offset = "0x9C74A4")]
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
		[Address(RVA = "0xAC4ED8", Offset = "0xAC4ED8", VA = "0xAC4ED8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xAC4EE0", Offset = "0xAC4EE0", VA = "0xAC4EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C74B4", Offset = "0x9C74B4")]
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
		[Address(RVA = "0xAC4F00", Offset = "0xAC4F00", VA = "0xAC4F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xAC4F08", Offset = "0xAC4F08", VA = "0xAC4F08", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C74C4", Offset = "0x9C74C4")]
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
		[Address(RVA = "0xAC4F28", Offset = "0xAC4F28", VA = "0xAC4F28", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xAC4F30", Offset = "0xAC4F30", VA = "0xAC4F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1C18054", Offset = "0x1C18054", VA = "0x1C18054")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1C18230", Offset = "0x1C18230", VA = "0x1C18230")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1C18420", Offset = "0x1C18420", VA = "0x1C18420")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1C184F4", Offset = "0x1C184F4", VA = "0x1C184F4")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1C185C8", Offset = "0x1C185C8", VA = "0x1C185C8")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1C1869C", Offset = "0x1C1869C", VA = "0x1C1869C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1C18780", Offset = "0x1C18780", VA = "0x1C18780")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1C18864", Offset = "0x1C18864", VA = "0x1C18864")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1C18938", Offset = "0x1C18938", VA = "0x1C18938")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1C18B10", Offset = "0x1C18B10", VA = "0x1C18B10")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1C18CE8", Offset = "0x1C18CE8", VA = "0x1C18CE8")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x9C7A54", Offset = "0x9C7A54")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1C18DF0", Offset = "0x1C18DF0", VA = "0x1C18DF0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x9C7AC8", Offset = "0x9C7AC8")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1C18EF8", Offset = "0x1C18EF8", VA = "0x1C18EF8")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x9C7B3C", Offset = "0x9C7B3C")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1C19000", Offset = "0x1C19000", VA = "0x1C19000")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x9C7BB0", Offset = "0x9C7BB0")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1C19118", Offset = "0x1C19118", VA = "0x1C19118")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x9C7C24", Offset = "0x9C7C24")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1C19230", Offset = "0x1C19230", VA = "0x1C19230")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x9C7C98", Offset = "0x9C7C98")]
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
			[Address(RVA = "0x1C0E668", Offset = "0x1C0E668", VA = "0x1C0E668", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1C0E69C", Offset = "0x1C0E69C", VA = "0x1C0E69C")]
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
			[Address(RVA = "0x1C0E860", Offset = "0x1C0E860", VA = "0x1C0E860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1C0E8C4", Offset = "0x1C0E8C4", VA = "0x1C0E8C4")]
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
			[Address(RVA = "0x1C0E764", Offset = "0x1C0E764", VA = "0x1C0E764", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1C0E780", Offset = "0x1C0E780", VA = "0x1C0E780")]
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
			[Address(RVA = "0x1C0E6D0", Offset = "0x1C0E6D0", VA = "0x1C0E6D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1C0E71C", Offset = "0x1C0E71C", VA = "0x1C0E71C")]
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
			[Address(RVA = "0x1C0E7B4", Offset = "0x1C0E7B4", VA = "0x1C0E7B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1C0E818", Offset = "0x1C0E818", VA = "0x1C0E818")]
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
			[Address(RVA = "0x1C0E8F8", Offset = "0x1C0E8F8", VA = "0x1C0E8F8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1C0E92C", Offset = "0x1C0E92C", VA = "0x1C0E92C")]
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
		[Address(RVA = "0x1C1A318", Offset = "0x1C1A318", VA = "0x1C1A318")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1C1A420", Offset = "0x1C1A420", VA = "0x1C1A420")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1C1A4B0", Offset = "0x1C1A4B0", VA = "0x1C1A4B0")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1C1A540", Offset = "0x1C1A540", VA = "0x1C1A540")]
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
	[Address(RVA = "0x1C1A1D4", Offset = "0x1C1A1D4", VA = "0x1C1A1D4")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1C1A278", Offset = "0x1C1A278", VA = "0x1C1A278")]
	[Preserve]
	private static void Preserver()
	{
	}
}
