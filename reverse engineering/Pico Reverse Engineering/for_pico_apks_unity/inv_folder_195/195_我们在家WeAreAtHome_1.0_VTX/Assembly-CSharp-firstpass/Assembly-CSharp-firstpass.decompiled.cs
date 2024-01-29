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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AEF4", Offset = "0x77AEF4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x139CAB4", Offset = "0x139CAB4", VA = "0x139CAB4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x139D274", Offset = "0x139D274", VA = "0x139D274")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x139D290", Offset = "0x139D290", VA = "0x139D290")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF04", Offset = "0x77AF04")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x139CBF8", Offset = "0x139CBF8", VA = "0x139CBF8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x139D2AC", Offset = "0x139D2AC", VA = "0x139D2AC")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x139D2C8", Offset = "0x139D2C8", VA = "0x139D2C8")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF14", Offset = "0x77AF14")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x139CD40", Offset = "0x139CD40", VA = "0x139CD40")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x139D2E4", Offset = "0x139D2E4", VA = "0x139D2E4")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x139D324", Offset = "0x139D324", VA = "0x139D324")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x139C950", Offset = "0x139C950", VA = "0x139C950")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x139CABC", Offset = "0x139CABC", VA = "0x139CABC")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x139CC00", Offset = "0x139CC00", VA = "0x139CC00")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x139CD48", Offset = "0x139CD48", VA = "0x139CD48")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x139CDC0", Offset = "0x139CDC0", VA = "0x139CDC0")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x139CE38", Offset = "0x139CE38", VA = "0x139CE38")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x139CEA0", Offset = "0x139CEA0", VA = "0x139CEA0")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x139CF28", Offset = "0x139CF28", VA = "0x139CF28")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x139CF90", Offset = "0x139CF90", VA = "0x139CF90")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x139CFF8", Offset = "0x139CFF8", VA = "0x139CFF8")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x139D060", Offset = "0x139D060", VA = "0x139D060")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x139D0C8", Offset = "0x139D0C8", VA = "0x139D0C8")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x139D138", Offset = "0x139D138", VA = "0x139D138")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x139D1A4", Offset = "0x139D1A4", VA = "0x139D1A4")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x139D20C", Offset = "0x139D20C", VA = "0x139D20C")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF24", Offset = "0x77AF24")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x139D4B8", Offset = "0x139D4B8", VA = "0x139D4B8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x139E854", Offset = "0x139E854", VA = "0x139E854")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF34", Offset = "0x77AF34")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x139D648", Offset = "0x139D648", VA = "0x139D648")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x139E990", Offset = "0x139E990", VA = "0x139E990")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF44", Offset = "0x77AF44")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x139D7D8", Offset = "0x139D7D8", VA = "0x139D7D8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x139E9AC", Offset = "0x139E9AC", VA = "0x139E9AC")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF54", Offset = "0x77AF54")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x139D968", Offset = "0x139D968", VA = "0x139D968")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x139E9C8", Offset = "0x139E9C8", VA = "0x139E9C8")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF64", Offset = "0x77AF64")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x139DADC", Offset = "0x139DADC", VA = "0x139DADC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x139E9E4", Offset = "0x139E9E4", VA = "0x139E9E4")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF74", Offset = "0x77AF74")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x139DCC8", Offset = "0x139DCC8", VA = "0x139DCC8")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x139EA00", Offset = "0x139EA00", VA = "0x139EA00")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF84", Offset = "0x77AF84")]
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
		[Address(RVA = "0x139E144", Offset = "0x139E144", VA = "0x139E144")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x139EA1C", Offset = "0x139EA1C", VA = "0x139EA1C")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x139EA38", Offset = "0x139EA38", VA = "0x139EA38")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x139EA6C", Offset = "0x139EA6C", VA = "0x139EA6C")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x139EA88", Offset = "0x139EA88", VA = "0x139EA88")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x139EAA4", Offset = "0x139EAA4", VA = "0x139EAA4")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF94", Offset = "0x77AF94")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x139E338", Offset = "0x139E338", VA = "0x139E338")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x139EB64", Offset = "0x139EB64", VA = "0x139EB64")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AFA4", Offset = "0x77AFA4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x139E540", Offset = "0x139E540", VA = "0x139E540")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x139EB80", Offset = "0x139EB80", VA = "0x139EB80")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x139EB9C", Offset = "0x139EB9C", VA = "0x139EB9C")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AFB4", Offset = "0x77AFB4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x139E6C0", Offset = "0x139E6C0", VA = "0x139E6C0")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x139ECA0", Offset = "0x139ECA0", VA = "0x139ECA0")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AFC4", Offset = "0x77AFC4")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x139E84C", Offset = "0x139E84C", VA = "0x139E84C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x139E870", Offset = "0x139E870", VA = "0x139E870")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x139E88C", Offset = "0x139E88C", VA = "0x139E88C")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x139D348", Offset = "0x139D348", VA = "0x139D348")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x139D4C0", Offset = "0x139D4C0", VA = "0x139D4C0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x139D650", Offset = "0x139D650", VA = "0x139D650")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x139D7E0", Offset = "0x139D7E0", VA = "0x139D7E0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x139D970", Offset = "0x139D970", VA = "0x139D970")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x139DAE4", Offset = "0x139DAE4", VA = "0x139DAE4")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x139DCD0", Offset = "0x139DCD0", VA = "0x139DCD0")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x139E14C", Offset = "0x139E14C", VA = "0x139E14C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x139E340", Offset = "0x139E340", VA = "0x139E340")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x139E548", Offset = "0x139E548", VA = "0x139E548")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x139E6C8", Offset = "0x139E6C8", VA = "0x139E6C8")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AFD4", Offset = "0x77AFD4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x139EE24", Offset = "0x139EE24", VA = "0x139EE24")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x139FB64", Offset = "0x139FB64", VA = "0x139FB64")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AFE4", Offset = "0x77AFE4")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x139EFA0", Offset = "0x139EFA0", VA = "0x139EFA0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x139FB80", Offset = "0x139FB80", VA = "0x139FB80")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AFF4", Offset = "0x77AFF4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x139F11C", Offset = "0x139F11C", VA = "0x139F11C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x139FB9C", Offset = "0x139FB9C", VA = "0x139FB9C")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B004", Offset = "0x77B004")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x139F264", Offset = "0x139F264", VA = "0x139F264")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x139FBB8", Offset = "0x139FBB8", VA = "0x139FBB8")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B014", Offset = "0x77B014")]
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
		[Address(RVA = "0x139F5E4", Offset = "0x139F5E4", VA = "0x139F5E4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x139FBD4", Offset = "0x139FBD4", VA = "0x139FBD4")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x139FBF0", Offset = "0x139FBF0", VA = "0x139FBF0")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x139FC0C", Offset = "0x139FC0C", VA = "0x139FC0C")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x139FC40", Offset = "0x139FC40", VA = "0x139FC40")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x139FC5C", Offset = "0x139FC5C", VA = "0x139FC5C")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x139FC78", Offset = "0x139FC78", VA = "0x139FC78")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B024", Offset = "0x77B024")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x139F898", Offset = "0x139F898", VA = "0x139F898")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x139FDA0", Offset = "0x139FDA0", VA = "0x139FDA0")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x139FE30", Offset = "0x139FE30", VA = "0x139FE30")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B034", Offset = "0x77B034")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x139FB5C", Offset = "0x139FB5C", VA = "0x139FB5C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x139FED4", Offset = "0x139FED4", VA = "0x139FED4")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x139FEF0", Offset = "0x139FEF0", VA = "0x139FEF0")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x139ECBC", Offset = "0x139ECBC", VA = "0x139ECBC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x139EE2C", Offset = "0x139EE2C", VA = "0x139EE2C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x139EFA8", Offset = "0x139EFA8", VA = "0x139EFA8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x139F124", Offset = "0x139F124", VA = "0x139F124")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x139F26C", Offset = "0x139F26C", VA = "0x139F26C")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x139F5EC", Offset = "0x139F5EC", VA = "0x139F5EC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x139F8A0", Offset = "0x139F8A0", VA = "0x139F8A0")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B044", Offset = "0x77B044")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x13A0180", Offset = "0x13A0180", VA = "0x13A0180")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x13A0690", Offset = "0x13A0690", VA = "0x13A0690")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x13A06AC", Offset = "0x13A06AC", VA = "0x13A06AC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B054", Offset = "0x77B054")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x13A02C4", Offset = "0x13A02C4", VA = "0x13A02C4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x13A06C8", Offset = "0x13A06C8", VA = "0x13A06C8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x13A06E4", Offset = "0x13A06E4", VA = "0x13A06E4")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B064", Offset = "0x77B064")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x13A0688", Offset = "0x13A0688", VA = "0x13A0688")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x13A0700", Offset = "0x13A0700", VA = "0x13A0700")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x13A070C", Offset = "0x13A070C", VA = "0x13A070C")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x13A001C", Offset = "0x13A001C", VA = "0x13A001C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x13A0188", Offset = "0x13A0188", VA = "0x13A0188")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x13A02CC", Offset = "0x13A02CC", VA = "0x13A02CC")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x13A04A4", Offset = "0x13A04A4", VA = "0x13A04A4")]
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
		[Address(RVA = "0x13A5844", Offset = "0x13A5844", VA = "0x13A5844")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B074", Offset = "0x77B074")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x13A08F4", Offset = "0x13A08F4", VA = "0x13A08F4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x13A4658", Offset = "0x13A4658", VA = "0x13A4658")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x13A4674", Offset = "0x13A4674", VA = "0x13A4674")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B084", Offset = "0x77B084")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x13A0A60", Offset = "0x13A0A60", VA = "0x13A0A60")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x13A48C8", Offset = "0x13A48C8", VA = "0x13A48C8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x13A48EC", Offset = "0x13A48EC", VA = "0x13A48EC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B094", Offset = "0x77B094")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x13A0BA4", Offset = "0x13A0BA4", VA = "0x13A0BA4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x13A4F54", Offset = "0x13A4F54", VA = "0x13A4F54")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x13A4F78", Offset = "0x13A4F78", VA = "0x13A4F78")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0A4", Offset = "0x77B0A4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x13A0D10", Offset = "0x13A0D10", VA = "0x13A0D10")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x13A5420", Offset = "0x13A5420", VA = "0x13A5420")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x13A5444", Offset = "0x13A5444", VA = "0x13A5444")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0B4", Offset = "0x77B0B4")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x13A0E54", Offset = "0x13A0E54", VA = "0x13A0E54")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x13A5530", Offset = "0x13A5530", VA = "0x13A5530")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x13A5554", Offset = "0x13A5554", VA = "0x13A5554")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0C4", Offset = "0x77B0C4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x13A0FBC", Offset = "0x13A0FBC", VA = "0x13A0FBC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x13A5578", Offset = "0x13A5578", VA = "0x13A5578")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x13A5594", Offset = "0x13A5594", VA = "0x13A5594")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0D4", Offset = "0x77B0D4")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x13A1300", Offset = "0x13A1300", VA = "0x13A1300")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x13A55B0", Offset = "0x13A55B0", VA = "0x13A55B0")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x13A5630", Offset = "0x13A5630", VA = "0x13A5630")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0E4", Offset = "0x77B0E4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x13A1464", Offset = "0x13A1464", VA = "0x13A1464")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x13A568C", Offset = "0x13A568C", VA = "0x13A568C")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x13A570C", Offset = "0x13A570C", VA = "0x13A570C")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0F4", Offset = "0x77B0F4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x13A15C8", Offset = "0x13A15C8", VA = "0x13A15C8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x13A5768", Offset = "0x13A5768", VA = "0x13A5768")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x13A57E8", Offset = "0x13A57E8", VA = "0x13A57E8")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B104", Offset = "0x77B104")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x13A1734", Offset = "0x13A1734", VA = "0x13A1734")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x13A4690", Offset = "0x13A4690", VA = "0x13A4690")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x13A46B0", Offset = "0x13A46B0", VA = "0x13A46B0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B114", Offset = "0x77B114")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x13A1878", Offset = "0x13A1878", VA = "0x13A1878")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x13A46CC", Offset = "0x13A46CC", VA = "0x13A46CC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x13A46EC", Offset = "0x13A46EC", VA = "0x13A46EC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B124", Offset = "0x77B124")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x13A19CC", Offset = "0x13A19CC", VA = "0x13A19CC")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x13A4708", Offset = "0x13A4708", VA = "0x13A4708")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x13A4724", Offset = "0x13A4724", VA = "0x13A4724")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B134", Offset = "0x77B134")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x13A1B30", Offset = "0x13A1B30", VA = "0x13A1B30")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x13A4740", Offset = "0x13A4740", VA = "0x13A4740")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x13A475C", Offset = "0x13A475C", VA = "0x13A475C")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B144", Offset = "0x77B144")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x13A1CA8", Offset = "0x13A1CA8", VA = "0x13A1CA8")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x13A4778", Offset = "0x13A4778", VA = "0x13A4778")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x13A4794", Offset = "0x13A4794", VA = "0x13A4794")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B154", Offset = "0x77B154")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x13A1E20", Offset = "0x13A1E20", VA = "0x13A1E20")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x13A47B0", Offset = "0x13A47B0", VA = "0x13A47B0")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x13A47CC", Offset = "0x13A47CC", VA = "0x13A47CC")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B164", Offset = "0x77B164")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x13A1F8C", Offset = "0x13A1F8C", VA = "0x13A1F8C")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x13A47E8", Offset = "0x13A47E8", VA = "0x13A47E8")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x13A4804", Offset = "0x13A4804", VA = "0x13A4804")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B174", Offset = "0x77B174")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x13A2110", Offset = "0x13A2110", VA = "0x13A2110")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x13A4820", Offset = "0x13A4820", VA = "0x13A4820")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x13A483C", Offset = "0x13A483C", VA = "0x13A483C")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B184", Offset = "0x77B184")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x13A2294", Offset = "0x13A2294", VA = "0x13A2294")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x13A4858", Offset = "0x13A4858", VA = "0x13A4858")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x13A4874", Offset = "0x13A4874", VA = "0x13A4874")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B194", Offset = "0x77B194")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x13A2418", Offset = "0x13A2418", VA = "0x13A2418")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x13A4890", Offset = "0x13A4890", VA = "0x13A4890")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x13A48AC", Offset = "0x13A48AC", VA = "0x13A48AC")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1A4", Offset = "0x77B1A4")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x13A257C", Offset = "0x13A257C", VA = "0x13A257C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x13A4910", Offset = "0x13A4910", VA = "0x13A4910")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x13A492C", Offset = "0x13A492C", VA = "0x13A492C")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1B4", Offset = "0x77B1B4")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x13A26E0", Offset = "0x13A26E0", VA = "0x13A26E0")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x13A4948", Offset = "0x13A4948", VA = "0x13A4948")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x13A4964", Offset = "0x13A4964", VA = "0x13A4964")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1C4", Offset = "0x77B1C4")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x13A2834", Offset = "0x13A2834", VA = "0x13A2834")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x13A4980", Offset = "0x13A4980", VA = "0x13A4980")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x13A499C", Offset = "0x13A499C", VA = "0x13A499C")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1D4", Offset = "0x77B1D4")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x13A29A0", Offset = "0x13A29A0", VA = "0x13A29A0")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x13A49B8", Offset = "0x13A49B8", VA = "0x13A49B8")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x13A49D4", Offset = "0x13A49D4", VA = "0x13A49D4")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1E4", Offset = "0x77B1E4")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x13A2B0C", Offset = "0x13A2B0C", VA = "0x13A2B0C")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x13A49F0", Offset = "0x13A49F0", VA = "0x13A49F0")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x13A4A0C", Offset = "0x13A4A0C", VA = "0x13A4A0C")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1F4", Offset = "0x77B1F4")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x13A2C70", Offset = "0x13A2C70", VA = "0x13A2C70")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x13A4A28", Offset = "0x13A4A28", VA = "0x13A4A28")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x13A4A44", Offset = "0x13A4A44", VA = "0x13A4A44")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B204", Offset = "0x77B204")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x13A2E28", Offset = "0x13A2E28", VA = "0x13A2E28")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x13A4A60", Offset = "0x13A4A60", VA = "0x13A4A60")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x13A4AF0", Offset = "0x13A4AF0", VA = "0x13A4AF0")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B214", Offset = "0x77B214")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x13A2FB0", Offset = "0x13A2FB0", VA = "0x13A2FB0")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x13A4B94", Offset = "0x13A4B94", VA = "0x13A4B94")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x13A4C24", Offset = "0x13A4C24", VA = "0x13A4C24")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B224", Offset = "0x77B224")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x13A3184", Offset = "0x13A3184", VA = "0x13A3184")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x13A4CC8", Offset = "0x13A4CC8", VA = "0x13A4CC8")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x13A4D58", Offset = "0x13A4D58", VA = "0x13A4D58")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B234", Offset = "0x77B234")]
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
		[Address(RVA = "0x13A3508", Offset = "0x13A3508", VA = "0x13A3508")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x13A4DFC", Offset = "0x13A4DFC", VA = "0x13A4DFC")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x13A4E18", Offset = "0x13A4E18", VA = "0x13A4E18")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x13A4E34", Offset = "0x13A4E34", VA = "0x13A4E34")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x13A4E68", Offset = "0x13A4E68", VA = "0x13A4E68")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x13A4E84", Offset = "0x13A4E84", VA = "0x13A4E84")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x13A4EA0", Offset = "0x13A4EA0", VA = "0x13A4EA0")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B244", Offset = "0x77B244")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x13A3660", Offset = "0x13A3660", VA = "0x13A3660")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x13A4F9C", Offset = "0x13A4F9C", VA = "0x13A4F9C")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x13A500C", Offset = "0x13A500C", VA = "0x13A500C")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B254", Offset = "0x77B254")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x13A37A8", Offset = "0x13A37A8", VA = "0x13A37A8")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x13A5058", Offset = "0x13A5058", VA = "0x13A5058")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x13A5074", Offset = "0x13A5074", VA = "0x13A5074")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B264", Offset = "0x77B264")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x13A38F0", Offset = "0x13A38F0", VA = "0x13A38F0")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x13A5090", Offset = "0x13A5090", VA = "0x13A5090")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x13A50AC", Offset = "0x13A50AC", VA = "0x13A50AC")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B274", Offset = "0x77B274")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x13A3A44", Offset = "0x13A3A44", VA = "0x13A3A44")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x13A50C8", Offset = "0x13A50C8", VA = "0x13A50C8")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x13A50EC", Offset = "0x13A50EC", VA = "0x13A50EC")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B284", Offset = "0x77B284")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x13A3BB0", Offset = "0x13A3BB0", VA = "0x13A3BB0")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x13A5110", Offset = "0x13A5110", VA = "0x13A5110")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x13A5134", Offset = "0x13A5134", VA = "0x13A5134")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B294", Offset = "0x77B294")]
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
		[Address(RVA = "0x13A3D54", Offset = "0x13A3D54", VA = "0x13A3D54")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x13A5158", Offset = "0x13A5158", VA = "0x13A5158")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x13A5160", Offset = "0x13A5160", VA = "0x13A5160")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2A4", Offset = "0x77B2A4")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x13A3E98", Offset = "0x13A3E98", VA = "0x13A3E98")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x13A5200", Offset = "0x13A5200", VA = "0x13A5200")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x13A5224", Offset = "0x13A5224", VA = "0x13A5224")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2B4", Offset = "0x77B2B4")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x13A4074", Offset = "0x13A4074", VA = "0x13A4074")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x13A5248", Offset = "0x13A5248", VA = "0x13A5248")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x13A526C", Offset = "0x13A526C", VA = "0x13A526C")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2C4", Offset = "0x77B2C4")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x13A4268", Offset = "0x13A4268", VA = "0x13A4268")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x13A5290", Offset = "0x13A5290", VA = "0x13A5290")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x13A529C", Offset = "0x13A529C", VA = "0x13A529C")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2D4", Offset = "0x77B2D4")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x13A445C", Offset = "0x13A445C", VA = "0x13A445C")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x13A5358", Offset = "0x13A5358", VA = "0x13A5358")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x13A5364", Offset = "0x13A5364", VA = "0x13A5364")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2E4", Offset = "0x77B2E4")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x13A4650", Offset = "0x13A4650", VA = "0x13A4650")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x13A5468", Offset = "0x13A5468", VA = "0x13A5468")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x13A5474", Offset = "0x13A5474", VA = "0x13A5474")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x13A07B8", Offset = "0x13A07B8", VA = "0x13A07B8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x13A08FC", Offset = "0x13A08FC", VA = "0x13A08FC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x13A0A68", Offset = "0x13A0A68", VA = "0x13A0A68")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x13A0BAC", Offset = "0x13A0BAC", VA = "0x13A0BAC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x13A0D18", Offset = "0x13A0D18", VA = "0x13A0D18")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x13A0E5C", Offset = "0x13A0E5C", VA = "0x13A0E5C")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x13A0FC4", Offset = "0x13A0FC4", VA = "0x13A0FC4")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x13A11A4", Offset = "0x13A11A4", VA = "0x13A11A4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x13A1308", Offset = "0x13A1308", VA = "0x13A1308")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x13A146C", Offset = "0x13A146C", VA = "0x13A146C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x13A15D0", Offset = "0x13A15D0", VA = "0x13A15D0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x13A173C", Offset = "0x13A173C", VA = "0x13A173C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13A1880", Offset = "0x13A1880", VA = "0x13A1880")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x13A19D4", Offset = "0x13A19D4", VA = "0x13A19D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x13A1B38", Offset = "0x13A1B38", VA = "0x13A1B38")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x13A1CB0", Offset = "0x13A1CB0", VA = "0x13A1CB0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x13A1E28", Offset = "0x13A1E28", VA = "0x13A1E28")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x13A1F94", Offset = "0x13A1F94", VA = "0x13A1F94")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x13A2118", Offset = "0x13A2118", VA = "0x13A2118")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x13A229C", Offset = "0x13A229C", VA = "0x13A229C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x13A2420", Offset = "0x13A2420", VA = "0x13A2420")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x13A2584", Offset = "0x13A2584", VA = "0x13A2584")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x13A26E8", Offset = "0x13A26E8", VA = "0x13A26E8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x13A283C", Offset = "0x13A283C", VA = "0x13A283C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13A29A8", Offset = "0x13A29A8", VA = "0x13A29A8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13A2B14", Offset = "0x13A2B14", VA = "0x13A2B14")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13A2C78", Offset = "0x13A2C78", VA = "0x13A2C78")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13A2E30", Offset = "0x13A2E30", VA = "0x13A2E30")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13A2FB8", Offset = "0x13A2FB8", VA = "0x13A2FB8")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x13A318C", Offset = "0x13A318C", VA = "0x13A318C")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x13A3510", Offset = "0x13A3510", VA = "0x13A3510")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x13A3668", Offset = "0x13A3668", VA = "0x13A3668")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x13A37B0", Offset = "0x13A37B0", VA = "0x13A37B0")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x13A38F8", Offset = "0x13A38F8", VA = "0x13A38F8")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x13A3A4C", Offset = "0x13A3A4C", VA = "0x13A3A4C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x13A3BB8", Offset = "0x13A3BB8", VA = "0x13A3BB8")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x13A3D5C", Offset = "0x13A3D5C", VA = "0x13A3D5C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x13A3EA0", Offset = "0x13A3EA0", VA = "0x13A3EA0")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13A407C", Offset = "0x13A407C", VA = "0x13A407C")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x13A4270", Offset = "0x13A4270", VA = "0x13A4270")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x13A4464", Offset = "0x13A4464", VA = "0x13A4464")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2F4", Offset = "0x77B2F4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x13A654C", Offset = "0x13A654C", VA = "0x13A654C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x13A6CDC", Offset = "0x13A6CDC", VA = "0x13A6CDC")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x13A6D00", Offset = "0x13A6D00", VA = "0x13A6D00")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B304", Offset = "0x77B304")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x13A6714", Offset = "0x13A6714", VA = "0x13A6714")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x13A6D24", Offset = "0x13A6D24", VA = "0x13A6D24")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x13A6D48", Offset = "0x13A6D48", VA = "0x13A6D48")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B314", Offset = "0x77B314")]
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
		[Address(RVA = "0x13A6D6C", Offset = "0x13A6D6C", VA = "0x13A6D6C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x13A6FB0", Offset = "0x13A6FB0", VA = "0x13A6FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B324", Offset = "0x77B324")]
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
		[Address(RVA = "0x13A76C0", Offset = "0x13A76C0", VA = "0x13A76C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x13A7928", Offset = "0x13A7928", VA = "0x13A7928", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B334", Offset = "0x77B334")]
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
		[Address(RVA = "0x13A7214", Offset = "0x13A7214", VA = "0x13A7214", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x13A7444", Offset = "0x13A7444", VA = "0x13A7444", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B344", Offset = "0x77B344")]
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
		[Address(RVA = "0x13A6FBC", Offset = "0x13A6FBC", VA = "0x13A6FBC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x13A7208", Offset = "0x13A7208", VA = "0x13A7208", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B354", Offset = "0x77B354")]
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
		[Address(RVA = "0x13A7450", Offset = "0x13A7450", VA = "0x13A7450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x13A76B4", Offset = "0x13A76B4", VA = "0x13A76B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B364", Offset = "0x77B364")]
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
		[Address(RVA = "0x13A7934", Offset = "0x13A7934", VA = "0x13A7934", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x13A7B6C", Offset = "0x13A7B6C", VA = "0x13A7B6C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x13A5AF0", Offset = "0x13A5AF0", VA = "0x13A5AF0")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x13A5CCC", Offset = "0x13A5CCC", VA = "0x13A5CCC")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x13A5EBC", Offset = "0x13A5EBC", VA = "0x13A5EBC")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x13A5F84", Offset = "0x13A5F84", VA = "0x13A5F84")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x13A604C", Offset = "0x13A604C", VA = "0x13A604C")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x13A6114", Offset = "0x13A6114", VA = "0x13A6114")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x13A61EC", Offset = "0x13A61EC", VA = "0x13A61EC")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13A62C4", Offset = "0x13A62C4", VA = "0x13A62C4")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13A638C", Offset = "0x13A638C", VA = "0x13A638C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13A6554", Offset = "0x13A6554", VA = "0x13A6554")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13A671C", Offset = "0x13A671C", VA = "0x13A671C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B8F4", Offset = "0x77B8F4")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13A680C", Offset = "0x13A680C", VA = "0x13A680C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B968", Offset = "0x77B968")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13A68FC", Offset = "0x13A68FC", VA = "0x13A68FC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B9DC", Offset = "0x77B9DC")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x13A69EC", Offset = "0x13A69EC", VA = "0x13A69EC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x77BA50", Offset = "0x77BA50")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x13A6AEC", Offset = "0x13A6AEC", VA = "0x13A6AEC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x77BAC4", Offset = "0x77BAC4")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13A6BEC", Offset = "0x13A6BEC", VA = "0x13A6BEC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x77BB38", Offset = "0x77BB38")]
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
			[Address(RVA = "0x139C690", Offset = "0x139C690", VA = "0x139C690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x139C6C4", Offset = "0x139C6C4", VA = "0x139C6C4")]
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
			[Address(RVA = "0x139C860", Offset = "0x139C860", VA = "0x139C860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x139C8C4", Offset = "0x139C8C4", VA = "0x139C8C4")]
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
			[Address(RVA = "0x139C778", Offset = "0x139C778", VA = "0x139C778", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x139C794", Offset = "0x139C794", VA = "0x139C794")]
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
			[Address(RVA = "0x139C6F0", Offset = "0x139C6F0", VA = "0x139C6F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x139C73C", Offset = "0x139C73C", VA = "0x139C73C")]
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
			[Address(RVA = "0x139C7C0", Offset = "0x139C7C0", VA = "0x139C7C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x139C824", Offset = "0x139C824", VA = "0x139C824")]
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
			[Address(RVA = "0x139C8F0", Offset = "0x139C8F0", VA = "0x139C8F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x139C924", Offset = "0x139C924", VA = "0x139C924")]
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
		[Address(RVA = "0x13A7CBC", Offset = "0x13A7CBC", VA = "0x13A7CBC")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x13A7DC4", Offset = "0x13A7DC4", VA = "0x13A7DC4")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x13A7E54", Offset = "0x13A7E54", VA = "0x13A7E54")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x13A7EE4", Offset = "0x13A7EE4", VA = "0x13A7EE4")]
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
	[Address(RVA = "0x13A7B78", Offset = "0x13A7B78", VA = "0x13A7B78")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x13A7C1C", Offset = "0x13A7C1C", VA = "0x13A7C1C")]
	[Preserve]
	private static void Preserver()
	{
	}
}
