using System;
using System.Collections.Generic;
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
using UnityEngine.Events;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening
{
	[Token(Token = "0x2000002")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512BB8", Offset = "0x512BB8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000001")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000010")]
			[Address(RVA = "0xB44704", Offset = "0xB44704", VA = "0xB44704")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0xB4E7D0", Offset = "0xB4E7D0", VA = "0xB4E7D0")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0xB4E7EC", Offset = "0xB4E7EC", VA = "0xB4E7EC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512BC8", Offset = "0x512BC8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000013")]
			[Address(RVA = "0xB448B4", Offset = "0xB448B4", VA = "0xB448B4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0xB4E808", Offset = "0xB4E808", VA = "0xB4E808")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000015")]
			[Address(RVA = "0xB4E824", Offset = "0xB4E824", VA = "0xB4E824")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512BD8", Offset = "0x512BD8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000016")]
			[Address(RVA = "0xB44A78", Offset = "0xB44A78", VA = "0xB44A78")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0xB4E840", Offset = "0xB4E840", VA = "0xB4E840")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0xB4E880", Offset = "0xB4E880", VA = "0xB4E880")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xB44534", Offset = "0xB44534", VA = "0xB44534")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xB4470C", Offset = "0xB4470C", VA = "0xB4470C")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xB448BC", Offset = "0xB448BC", VA = "0xB448BC")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xB44A80", Offset = "0xB44A80", VA = "0xB44A80")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xB44AF4", Offset = "0xB44AF4", VA = "0xB44AF4")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xB44B68", Offset = "0xB44B68", VA = "0xB44B68")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xB44BCC", Offset = "0xB44BCC", VA = "0xB44BCC")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xB44C50", Offset = "0xB44C50", VA = "0xB44C50")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xB44CB4", Offset = "0xB44CB4", VA = "0xB44CB4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xB44D18", Offset = "0xB44D18", VA = "0xB44D18")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xB44D7C", Offset = "0xB44D7C", VA = "0xB44D7C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xB44DE0", Offset = "0xB44DE0", VA = "0xB44DE0")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xB44E4C", Offset = "0xB44E4C", VA = "0xB44E4C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xB44EB4", Offset = "0xB44EB4", VA = "0xB44EB4")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xB44F18", Offset = "0xB44F18", VA = "0xB44F18")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000006")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512BF8", Offset = "0x512BF8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000024")]
			[Address(RVA = "0xB44F7C", Offset = "0xB44F7C", VA = "0xB44F7C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0xB4E8A4", Offset = "0xB4E8A4", VA = "0xB4E8A4")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C08", Offset = "0x512C08")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000026")]
			[Address(RVA = "0xB45154", Offset = "0xB45154", VA = "0xB45154")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0xB4E9DC", Offset = "0xB4E9DC", VA = "0xB4E9DC")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C18", Offset = "0x512C18")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0xB4532C", Offset = "0xB4532C", VA = "0xB4532C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0xB4E9F8", Offset = "0xB4E9F8", VA = "0xB4E9F8")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C28", Offset = "0x512C28")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002A")]
			[Address(RVA = "0xB45504", Offset = "0xB45504", VA = "0xB45504")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0xB4EA14", Offset = "0xB4EA14", VA = "0xB4EA14")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C38", Offset = "0x512C38")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002C")]
			[Address(RVA = "0xB4550C", Offset = "0xB4550C", VA = "0xB4550C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0xB4EA30", Offset = "0xB4EA30", VA = "0xB4EA30")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C48", Offset = "0x512C48")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002E")]
			[Address(RVA = "0xB45768", Offset = "0xB45768", VA = "0xB45768")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0xB4EA4C", Offset = "0xB4EA4C", VA = "0xB4EA4C")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C58", Offset = "0x512C58")]
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
			[Address(RVA = "0xB45CA4", Offset = "0xB45CA4", VA = "0xB45CA4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0xB4EA68", Offset = "0xB4EA68", VA = "0xB4EA68")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0xB4EA84", Offset = "0xB4EA84", VA = "0xB4EA84")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0xB4EAB8", Offset = "0xB4EAB8", VA = "0xB4EAB8")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0xB4EAD4", Offset = "0xB4EAD4", VA = "0xB4EAD4")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0xB4EAF0", Offset = "0xB4EAF0", VA = "0xB4EAF0")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C68", Offset = "0x512C68")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000036")]
			[Address(RVA = "0xB45F28", Offset = "0xB45F28", VA = "0xB45F28")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xB4EBB0", Offset = "0xB4EBB0", VA = "0xB4EBB0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C78", Offset = "0x512C78")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000038")]
			[Address(RVA = "0xB461CC", Offset = "0xB461CC", VA = "0xB461CC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0xB4EBCC", Offset = "0xB4EBCC", VA = "0xB4EBCC")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0xB4EBE8", Offset = "0xB4EBE8", VA = "0xB4EBE8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C88", Offset = "0x512C88")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600003B")]
			[Address(RVA = "0xB463C4", Offset = "0xB463C4", VA = "0xB463C4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0xB4ECE8", Offset = "0xB4ECE8", VA = "0xB4ECE8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512C98", Offset = "0x512C98")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600003D")]
			[Address(RVA = "0xB465DC", Offset = "0xB465DC", VA = "0xB465DC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xB4E8C0", Offset = "0xB4E8C0", VA = "0xB4E8C0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0xB4E8DC", Offset = "0xB4E8DC", VA = "0xB4E8DC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xB414D4", Offset = "0xB414D4", VA = "0xB414D4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xB44F84", Offset = "0xB44F84", VA = "0xB44F84")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xB4515C", Offset = "0xB4515C", VA = "0xB4515C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xB45334", Offset = "0xB45334", VA = "0xB45334")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xB41884", Offset = "0xB41884", VA = "0xB41884")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xB45514", Offset = "0xB45514", VA = "0xB45514")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB45770", Offset = "0xB45770", VA = "0xB45770")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB45CAC", Offset = "0xB45CAC", VA = "0xB45CAC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB45F30", Offset = "0xB45F30", VA = "0xB45F30")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB461D4", Offset = "0xB461D4", VA = "0xB461D4")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB463CC", Offset = "0xB463CC", VA = "0xB463CC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000012")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512CB8", Offset = "0x512CB8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000049")]
			[Address(RVA = "0xB465E4", Offset = "0xB465E4", VA = "0xB465E4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0xB4ED04", Offset = "0xB4ED04", VA = "0xB4ED04")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512CC8", Offset = "0x512CC8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600004B")]
			[Address(RVA = "0xB467B8", Offset = "0xB467B8", VA = "0xB467B8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0xB4ED20", Offset = "0xB4ED20", VA = "0xB4ED20")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512CD8", Offset = "0x512CD8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600004D")]
			[Address(RVA = "0xB4698C", Offset = "0xB4698C", VA = "0xB4698C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xB4ED3C", Offset = "0xB4ED3C", VA = "0xB4ED3C")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512CE8", Offset = "0x512CE8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600004F")]
			[Address(RVA = "0xB46994", Offset = "0xB46994", VA = "0xB46994")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0xB4ED58", Offset = "0xB4ED58", VA = "0xB4ED58")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512CF8", Offset = "0x512CF8")]
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
			[Address(RVA = "0xB46DF8", Offset = "0xB46DF8", VA = "0xB46DF8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0xB4ED74", Offset = "0xB4ED74", VA = "0xB4ED74")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0xB4ED90", Offset = "0xB4ED90", VA = "0xB4ED90")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0xB4EDAC", Offset = "0xB4EDAC", VA = "0xB4EDAC")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0xB4EDE0", Offset = "0xB4EDE0", VA = "0xB4EDE0")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0xB4EDFC", Offset = "0xB4EDFC", VA = "0xB4EDFC")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0xB4EE18", Offset = "0xB4EE18", VA = "0xB4EE18")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D08", Offset = "0x512D08")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000058")]
			[Address(RVA = "0xB47100", Offset = "0xB47100", VA = "0xB47100")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0xB4EED0", Offset = "0xB4EED0", VA = "0xB4EED0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0xB4EEF8", Offset = "0xB4EEF8", VA = "0xB4EEF8")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D18", Offset = "0x512D18")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x600005B")]
			[Address(RVA = "0xB4742C", Offset = "0xB4742C", VA = "0xB4742C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0xB4EF14", Offset = "0xB4EF14", VA = "0xB4EF14")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0xB4EF30", Offset = "0xB4EF30", VA = "0xB4EF30")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D28", Offset = "0x512D28")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600005E")]
			[Address(RVA = "0xB47620", Offset = "0xB47620", VA = "0xB47620")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600005F")]
			[Address(RVA = "0xB4F028", Offset = "0xB4F028", VA = "0xB4F028")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0xB4F050", Offset = "0xB4F050", VA = "0xB4F050")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D38", Offset = "0x512D38")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000061")]
			[Address(RVA = "0xB47838", Offset = "0xB47838", VA = "0xB47838")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0xB4F06C", Offset = "0xB4F06C", VA = "0xB4F06C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0xB4F088", Offset = "0xB4F088", VA = "0xB4F088")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xB416B0", Offset = "0xB416B0", VA = "0xB416B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB465EC", Offset = "0xB465EC", VA = "0xB465EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB467C0", Offset = "0xB467C0", VA = "0xB467C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB41A5C", Offset = "0xB41A5C", VA = "0xB41A5C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB4699C", Offset = "0xB4699C", VA = "0xB4699C")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB46E00", Offset = "0xB46E00", VA = "0xB46E00")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB47108", Offset = "0xB47108", VA = "0xB47108")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB47434", Offset = "0xB47434", VA = "0xB47434")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB47628", Offset = "0xB47628", VA = "0xB47628")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D58", Offset = "0x512D58")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000068")]
			[Address(RVA = "0xB47840", Offset = "0xB47840", VA = "0xB47840")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0xB4F180", Offset = "0xB4F180", VA = "0xB4F180")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0xB4F19C", Offset = "0xB4F19C", VA = "0xB4F19C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D68", Offset = "0x512D68")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xB47848", Offset = "0xB47848", VA = "0xB47848")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0xB4F1B8", Offset = "0xB4F1B8", VA = "0xB4F1B8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0xB4F1D4", Offset = "0xB4F1D4", VA = "0xB4F1D4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D78", Offset = "0x512D78")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0xB47C98", Offset = "0xB47C98", VA = "0xB47C98")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0xB4F1F0", Offset = "0xB4F1F0", VA = "0xB4F1F0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0xB4F1FC", Offset = "0xB4F1FC", VA = "0xB4F1FC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB41DD8", Offset = "0xB41DD8", VA = "0xB41DD8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB42348", Offset = "0xB42348", VA = "0xB42348")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB47850", Offset = "0xB47850", VA = "0xB47850")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB47A3C", Offset = "0xB47A3C", VA = "0xB47A3C")]
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
			[Address(RVA = "0x1223894", Offset = "0x1223894", VA = "0x1223894")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D98", Offset = "0x512D98")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x600009C")]
			[Address(RVA = "0xB47CA0", Offset = "0xB47CA0", VA = "0xB47CA0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0xB4F2A8", Offset = "0xB4F2A8", VA = "0xB4F2A8")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0xB4F2C4", Offset = "0xB4F2C4", VA = "0xB4F2C4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512DA8", Offset = "0x512DA8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xB47CA8", Offset = "0xB47CA8", VA = "0xB47CA8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xB4F518", Offset = "0xB4F518", VA = "0xB4F518")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xB4F53C", Offset = "0xB4F53C", VA = "0xB4F53C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512DB8", Offset = "0x512DB8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xB47CB0", Offset = "0xB47CB0", VA = "0xB47CB0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xB4F8D4", Offset = "0xB4F8D4", VA = "0xB4F8D4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xB4F8F8", Offset = "0xB4F8F8", VA = "0xB4F8F8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512DC8", Offset = "0x512DC8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x122344C", Offset = "0x122344C", VA = "0x122344C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1223454", Offset = "0x1223454", VA = "0x1223454")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1223478", Offset = "0x1223478", VA = "0x1223478")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512DD8", Offset = "0x512DD8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x12235AC", Offset = "0x12235AC", VA = "0x12235AC")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x12235B4", Offset = "0x12235B4", VA = "0x12235B4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x12235D8", Offset = "0x12235D8", VA = "0x12235D8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512DE8", Offset = "0x512DE8")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x12235FC", Offset = "0x12235FC", VA = "0x12235FC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1223604", Offset = "0x1223604", VA = "0x1223604")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1223620", Offset = "0x1223620", VA = "0x1223620")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512DF8", Offset = "0x512DF8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x122363C", Offset = "0x122363C", VA = "0x122363C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1223644", Offset = "0x1223644", VA = "0x1223644")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x12236A8", Offset = "0x12236A8", VA = "0x12236A8")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E08", Offset = "0x512E08")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1223704", Offset = "0x1223704", VA = "0x1223704")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x122370C", Offset = "0x122370C", VA = "0x122370C")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1223770", Offset = "0x1223770", VA = "0x1223770")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E18", Offset = "0x512E18")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x12237CC", Offset = "0x12237CC", VA = "0x12237CC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x12237D4", Offset = "0x12237D4", VA = "0x12237D4")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1223838", Offset = "0x1223838", VA = "0x1223838")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E28", Offset = "0x512E28")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xB48B30", Offset = "0xB48B30", VA = "0xB48B30")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xB4F2E0", Offset = "0xB4F2E0", VA = "0xB4F2E0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xB4F300", Offset = "0xB4F300", VA = "0xB4F300")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E38", Offset = "0x512E38")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xB48CE0", Offset = "0xB48CE0", VA = "0xB48CE0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xB4F31C", Offset = "0xB4F31C", VA = "0xB4F31C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xB4F33C", Offset = "0xB4F33C", VA = "0xB4F33C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E48", Offset = "0x512E48")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xB48EA0", Offset = "0xB48EA0", VA = "0xB48EA0")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xB4F358", Offset = "0xB4F358", VA = "0xB4F358")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xB4F374", Offset = "0xB4F374", VA = "0xB4F374")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E58", Offset = "0x512E58")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xB49078", Offset = "0xB49078", VA = "0xB49078")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xB4F390", Offset = "0xB4F390", VA = "0xB4F390")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xB4F3AC", Offset = "0xB4F3AC", VA = "0xB4F3AC")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E68", Offset = "0x512E68")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xB49248", Offset = "0xB49248", VA = "0xB49248")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xB4F3C8", Offset = "0xB4F3C8", VA = "0xB4F3C8")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xB4F3E4", Offset = "0xB4F3E4", VA = "0xB4F3E4")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E78", Offset = "0x512E78")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xB49418", Offset = "0xB49418", VA = "0xB49418")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xB4F400", Offset = "0xB4F400", VA = "0xB4F400")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xB4F41C", Offset = "0xB4F41C", VA = "0xB4F41C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E88", Offset = "0x512E88")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xB49420", Offset = "0xB49420", VA = "0xB49420")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xB4F438", Offset = "0xB4F438", VA = "0xB4F438")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xB4F454", Offset = "0xB4F454", VA = "0xB4F454")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512E98", Offset = "0x512E98")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xB495F4", Offset = "0xB495F4", VA = "0xB495F4")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xB4F470", Offset = "0xB4F470", VA = "0xB4F470")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xB4F48C", Offset = "0xB4F48C", VA = "0xB4F48C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512EA8", Offset = "0x512EA8")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xB497C8", Offset = "0xB497C8", VA = "0xB497C8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xB4F4A8", Offset = "0xB4F4A8", VA = "0xB4F4A8")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xB4F4C4", Offset = "0xB4F4C4", VA = "0xB4F4C4")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512EB8", Offset = "0x512EB8")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xB4999C", Offset = "0xB4999C", VA = "0xB4999C")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xB4F4E0", Offset = "0xB4F4E0", VA = "0xB4F4E0")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xB4F4FC", Offset = "0xB4F4FC", VA = "0xB4F4FC")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512EC8", Offset = "0x512EC8")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xB49B74", Offset = "0xB49B74", VA = "0xB49B74")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xB4F560", Offset = "0xB4F560", VA = "0xB4F560")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xB4F57C", Offset = "0xB4F57C", VA = "0xB4F57C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512ED8", Offset = "0x512ED8")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xB49D4C", Offset = "0xB49D4C", VA = "0xB49D4C")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xB4F598", Offset = "0xB4F598", VA = "0xB4F598")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xB4F5B4", Offset = "0xB4F5B4", VA = "0xB4F5B4")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512EE8", Offset = "0x512EE8")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xB49F0C", Offset = "0xB49F0C", VA = "0xB49F0C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xB4F5D0", Offset = "0xB4F5D0", VA = "0xB4F5D0")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xB4F5EC", Offset = "0xB4F5EC", VA = "0xB4F5EC")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512EF8", Offset = "0x512EF8")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xB4A0D0", Offset = "0xB4A0D0", VA = "0xB4A0D0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xB4F608", Offset = "0xB4F608", VA = "0xB4F608")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xB4F624", Offset = "0xB4F624", VA = "0xB4F624")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F08", Offset = "0x512F08")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xB4A294", Offset = "0xB4A294", VA = "0xB4A294")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xB4F640", Offset = "0xB4F640", VA = "0xB4F640")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xB4F65C", Offset = "0xB4F65C", VA = "0xB4F65C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F18", Offset = "0x512F18")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xB4A29C", Offset = "0xB4A29C", VA = "0xB4A29C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xB4F678", Offset = "0xB4F678", VA = "0xB4F678")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xB4F694", Offset = "0xB4F694", VA = "0xB4F694")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F28", Offset = "0x512F28")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xB4A2A4", Offset = "0xB4A2A4", VA = "0xB4A2A4")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xB4F6B0", Offset = "0xB4F6B0", VA = "0xB4F6B0")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xB4F6D8", Offset = "0xB4F6D8", VA = "0xB4F6D8")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F38", Offset = "0x512F38")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xB4A4AC", Offset = "0xB4A4AC", VA = "0xB4A4AC")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xB4F6F4", Offset = "0xB4F6F4", VA = "0xB4F6F4")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xB4F71C", Offset = "0xB4F71C", VA = "0xB4F71C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F48", Offset = "0x512F48")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xB4A4B4", Offset = "0xB4A4B4", VA = "0xB4A4B4")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xB4F738", Offset = "0xB4F738", VA = "0xB4F738")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xB4F760", Offset = "0xB4F760", VA = "0xB4F760")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F58", Offset = "0x512F58")]
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
			[Address(RVA = "0xB4A910", Offset = "0xB4A910", VA = "0xB4A910")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xB4F77C", Offset = "0xB4F77C", VA = "0xB4F77C")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xB4F798", Offset = "0xB4F798", VA = "0xB4F798")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xB4F7B4", Offset = "0xB4F7B4", VA = "0xB4F7B4")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xB4F7E8", Offset = "0xB4F7E8", VA = "0xB4F7E8")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xB4F804", Offset = "0xB4F804", VA = "0xB4F804")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xB4F820", Offset = "0xB4F820", VA = "0xB4F820")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F68", Offset = "0x512F68")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1222F98", Offset = "0x1222F98", VA = "0x1222F98")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1222FA0", Offset = "0x1222FA0", VA = "0x1222FA0")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1222FF4", Offset = "0x1222FF4", VA = "0x1222FF4")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F78", Offset = "0x512F78")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1223040", Offset = "0x1223040", VA = "0x1223040")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1223048", Offset = "0x1223048", VA = "0x1223048")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1223064", Offset = "0x1223064", VA = "0x1223064")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F88", Offset = "0x512F88")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1223080", Offset = "0x1223080", VA = "0x1223080")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1223088", Offset = "0x1223088", VA = "0x1223088")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x12230A4", Offset = "0x12230A4", VA = "0x12230A4")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512F98", Offset = "0x512F98")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x12230C0", Offset = "0x12230C0", VA = "0x12230C0")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x12230C8", Offset = "0x12230C8", VA = "0x12230C8")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x12230EC", Offset = "0x12230EC", VA = "0x12230EC")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512FA8", Offset = "0x512FA8")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1223110", Offset = "0x1223110", VA = "0x1223110")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1223118", Offset = "0x1223118", VA = "0x1223118")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x122313C", Offset = "0x122313C", VA = "0x122313C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512FB8", Offset = "0x512FB8")]
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
			[Address(RVA = "0x1223160", Offset = "0x1223160", VA = "0x1223160")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1223168", Offset = "0x1223168", VA = "0x1223168")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1223170", Offset = "0x1223170", VA = "0x1223170")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512FC8", Offset = "0x512FC8")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x122320C", Offset = "0x122320C", VA = "0x122320C")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1223214", Offset = "0x1223214", VA = "0x1223214")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1223238", Offset = "0x1223238", VA = "0x1223238")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512FD8", Offset = "0x512FD8")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x122325C", Offset = "0x122325C", VA = "0x122325C")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1223264", Offset = "0x1223264", VA = "0x1223264")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1223288", Offset = "0x1223288", VA = "0x1223288")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512FE8", Offset = "0x512FE8")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x600010F")]
			[Address(RVA = "0x12232AC", Offset = "0x12232AC", VA = "0x12232AC")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x12232B4", Offset = "0x12232B4", VA = "0x12232B4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0x12232C0", Offset = "0x12232C0", VA = "0x12232C0")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512FF8", Offset = "0x512FF8")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000112")]
			[Address(RVA = "0x122337C", Offset = "0x122337C", VA = "0x122337C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1223384", Offset = "0x1223384", VA = "0x1223384")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1223390", Offset = "0x1223390", VA = "0x1223390")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513008", Offset = "0x513008")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x122349C", Offset = "0x122349C", VA = "0x122349C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x12234A4", Offset = "0x12234A4", VA = "0x12234A4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x12234B0", Offset = "0x12234B0", VA = "0x12234B0")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513018", Offset = "0x513018")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x122356C", Offset = "0x122356C", VA = "0x122356C")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1223574", Offset = "0x1223574", VA = "0x1223574")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1223590", Offset = "0x1223590", VA = "0x1223590")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xB42840", Offset = "0xB42840", VA = "0xB42840")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB41FA8", Offset = "0xB41FA8", VA = "0xB41FA8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB424F0", Offset = "0xB424F0", VA = "0xB424F0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB47CB8", Offset = "0xB47CB8", VA = "0xB47CB8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB47E88", Offset = "0xB47E88", VA = "0xB47E88")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB48030", Offset = "0xB48030", VA = "0xB48030")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB481FC", Offset = "0xB481FC", VA = "0xB481FC")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB483F0", Offset = "0xB483F0", VA = "0xB483F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB485C0", Offset = "0xB485C0", VA = "0xB485C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB48790", Offset = "0xB48790", VA = "0xB48790")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB48960", Offset = "0xB48960", VA = "0xB48960")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB48B38", Offset = "0xB48B38", VA = "0xB48B38")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB48CE8", Offset = "0xB48CE8", VA = "0xB48CE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB48EA8", Offset = "0xB48EA8", VA = "0xB48EA8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB49080", Offset = "0xB49080", VA = "0xB49080")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB49250", Offset = "0xB49250", VA = "0xB49250")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB412FC", Offset = "0xB412FC", VA = "0xB412FC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB49428", Offset = "0xB49428", VA = "0xB49428")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB495FC", Offset = "0xB495FC", VA = "0xB495FC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB497D0", Offset = "0xB497D0", VA = "0xB497D0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB499A4", Offset = "0xB499A4", VA = "0xB499A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB49B7C", Offset = "0xB49B7C", VA = "0xB49B7C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB49D54", Offset = "0xB49D54", VA = "0xB49D54")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB49F14", Offset = "0xB49F14", VA = "0xB49F14")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB4A0D8", Offset = "0xB4A0D8", VA = "0xB4A0D8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB41C08", Offset = "0xB41C08", VA = "0xB41C08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB42C3C", Offset = "0xB42C3C", VA = "0xB42C3C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB4A2AC", Offset = "0xB4A2AC", VA = "0xB4A2AC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB42E14", Offset = "0xB42E14", VA = "0xB42E14")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB4A4BC", Offset = "0xB4A4BC", VA = "0xB4A4BC")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB4A918", Offset = "0xB4A918", VA = "0xB4A918")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB4AADC", Offset = "0xB4AADC", VA = "0xB4AADC")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB4AC90", Offset = "0xB4AC90", VA = "0xB4AC90")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB4AE44", Offset = "0xB4AE44", VA = "0xB4AE44")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB42178", Offset = "0xB42178", VA = "0xB42178")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB4B004", Offset = "0xB4B004", VA = "0xB4B004")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB42698", Offset = "0xB42698", VA = "0xB42698")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB429E8", Offset = "0xB429E8", VA = "0xB429E8")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB4B22C", Offset = "0xB4B22C", VA = "0xB4B22C")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB4B490", Offset = "0xB4B490", VA = "0xB4B490")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB4B6F4", Offset = "0xB4B6F4", VA = "0xB4B6F4")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xB4B958", Offset = "0xB4B958", VA = "0xB4B958")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513038", Offset = "0x513038")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1223AD8", Offset = "0x1223AD8", VA = "0x1223AD8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1223AE0", Offset = "0x1223AE0", VA = "0x1223AE0")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1223B04", Offset = "0x1223B04", VA = "0x1223B04")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513048", Offset = "0x513048")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1223B28", Offset = "0x1223B28", VA = "0x1223B28")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1223B30", Offset = "0x1223B30", VA = "0x1223B30")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1223B54", Offset = "0x1223B54", VA = "0x1223B54")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513058", Offset = "0x513058")]
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
			[Address(RVA = "0x1223B78", Offset = "0x1223B78", VA = "0x1223B78", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1223DBC", Offset = "0x1223DBC", VA = "0x1223DBC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513068", Offset = "0x513068")]
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
			[Address(RVA = "0x12244CC", Offset = "0x12244CC", VA = "0x12244CC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1224734", Offset = "0x1224734", VA = "0x1224734", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513078", Offset = "0x513078")]
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
			[Address(RVA = "0x1224020", Offset = "0x1224020", VA = "0x1224020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1224250", Offset = "0x1224250", VA = "0x1224250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513088", Offset = "0x513088")]
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
			[Address(RVA = "0x1223DC8", Offset = "0x1223DC8", VA = "0x1223DC8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1224014", Offset = "0x1224014", VA = "0x1224014", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513098", Offset = "0x513098")]
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
			[Address(RVA = "0x122425C", Offset = "0x122425C", VA = "0x122425C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x12244C0", Offset = "0x12244C0", VA = "0x12244C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5130A8", Offset = "0x5130A8")]
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
			[Address(RVA = "0x1224740", Offset = "0x1224740", VA = "0x1224740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1224978", Offset = "0x1224978", VA = "0x1224978", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xB4BB68", Offset = "0xB4BB68", VA = "0xB4BB68")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xB4BD58", Offset = "0xB4BD58", VA = "0xB4BD58")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xB4BF5C", Offset = "0xB4BF5C", VA = "0xB4BF5C")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xB4C05C", Offset = "0xB4C05C", VA = "0xB4C05C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xB4C15C", Offset = "0xB4C15C", VA = "0xB4C15C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xB4C25C", Offset = "0xB4C25C", VA = "0xB4C25C")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB4C380", Offset = "0xB4C380", VA = "0xB4C380")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB4C4A4", Offset = "0xB4C4A4", VA = "0xB4C4A4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB4C5A4", Offset = "0xB4C5A4", VA = "0xB4C5A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xB4C7CC", Offset = "0xB4C7CC", VA = "0xB4C7CC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xB4C9F4", Offset = "0xB4C9F4", VA = "0xB4C9F4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x513A10", Offset = "0x513A10")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xB4CB10", Offset = "0xB4CB10", VA = "0xB4CB10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x513A80", Offset = "0x513A80")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xB4CC2C", Offset = "0xB4CC2C", VA = "0xB4CC2C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x513AF0", Offset = "0x513AF0")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xB4CD48", Offset = "0xB4CD48", VA = "0xB4CD48")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x513B60", Offset = "0x513B60")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xB4CE74", Offset = "0xB4CE74", VA = "0xB4CE74")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x513BD0", Offset = "0x513BD0")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB4CFA0", Offset = "0xB4CFA0", VA = "0xB4CFA0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x513C40", Offset = "0x513C40")]
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
				[Address(RVA = "0xB4E638", Offset = "0xB4E638", VA = "0xB4E638", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0xB4C028", Offset = "0xB4C028", VA = "0xB4C028")]
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
				[Address(RVA = "0xB4E738", Offset = "0xB4E738", VA = "0xB4E738", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0xB4C128", Offset = "0xB4C128", VA = "0xB4C128")]
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
				[Address(RVA = "0xB4E6B8", Offset = "0xB4E6B8", VA = "0xB4E6B8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0xB4C228", Offset = "0xB4C228", VA = "0xB4C228")]
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
				[Address(RVA = "0xB4E66C", Offset = "0xB4E66C", VA = "0xB4E66C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0xB4C338", Offset = "0xB4C338", VA = "0xB4C338")]
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
				[Address(RVA = "0xB4E6D4", Offset = "0xB4E6D4", VA = "0xB4E6D4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0xB4C45C", Offset = "0xB4C45C", VA = "0xB4C45C")]
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
				[Address(RVA = "0xB4E79C", Offset = "0xB4E79C", VA = "0xB4E79C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0xB4C570", Offset = "0xB4C570", VA = "0xB4C570")]
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
			[Address(RVA = "0x1224984", Offset = "0x1224984", VA = "0x1224984")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1224A88", Offset = "0x1224A88", VA = "0x1224A88")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1224B20", Offset = "0x1224B20", VA = "0x1224B20")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1224BB8", Offset = "0x1224BB8", VA = "0x1224BB8")]
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
		[Address(RVA = "0xB4D0BC", Offset = "0xB4D0BC", VA = "0xB4D0BC")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xB4D180", Offset = "0xB4D180", VA = "0xB4D180")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5130B8", Offset = "0x5130B8")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x200005E")]
		public enum AnimationType
		{
			[Token(Token = "0x40000B1")]
			None,
			[Token(Token = "0x40000B2")]
			Move,
			[Token(Token = "0x40000B3")]
			LocalMove,
			[Token(Token = "0x40000B4")]
			Rotate,
			[Token(Token = "0x40000B5")]
			LocalRotate,
			[Token(Token = "0x40000B6")]
			Scale,
			[Token(Token = "0x40000B7")]
			Color,
			[Token(Token = "0x40000B8")]
			Fade,
			[Token(Token = "0x40000B9")]
			Text,
			[Token(Token = "0x40000BA")]
			PunchPosition,
			[Token(Token = "0x40000BB")]
			PunchRotation,
			[Token(Token = "0x40000BC")]
			PunchScale,
			[Token(Token = "0x40000BD")]
			ShakePosition,
			[Token(Token = "0x40000BE")]
			ShakeRotation,
			[Token(Token = "0x40000BF")]
			ShakeScale,
			[Token(Token = "0x40000C0")]
			CameraAspect,
			[Token(Token = "0x40000C1")]
			CameraBackgroundColor,
			[Token(Token = "0x40000C2")]
			CameraFieldOfView,
			[Token(Token = "0x40000C3")]
			CameraOrthoSize,
			[Token(Token = "0x40000C4")]
			CameraPixelRect,
			[Token(Token = "0x40000C5")]
			CameraRect,
			[Token(Token = "0x40000C6")]
			UIWidthHeight
		}

		[Token(Token = "0x200005F")]
		public enum TargetType
		{
			[Token(Token = "0x40000C8")]
			Unset,
			[Token(Token = "0x40000C9")]
			Camera,
			[Token(Token = "0x40000CA")]
			CanvasGroup,
			[Token(Token = "0x40000CB")]
			Image,
			[Token(Token = "0x40000CC")]
			Light,
			[Token(Token = "0x40000CD")]
			RectTransform,
			[Token(Token = "0x40000CE")]
			Renderer,
			[Token(Token = "0x40000CF")]
			SpriteRenderer,
			[Token(Token = "0x40000D0")]
			Rigidbody,
			[Token(Token = "0x40000D1")]
			Rigidbody2D,
			[Token(Token = "0x40000D2")]
			Text,
			[Token(Token = "0x40000D3")]
			Transform,
			[Token(Token = "0x40000D4")]
			tk2dBaseSprite,
			[Token(Token = "0x40000D5")]
			tk2dTextMesh,
			[Token(Token = "0x40000D6")]
			TextMeshPro,
			[Token(Token = "0x40000D7")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xB3F758", Offset = "0xB3F758", VA = "0xB3F758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513D50", Offset = "0x513D50")]
			add
			{
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xB3F814", Offset = "0xB3F814", VA = "0xB3F814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513D60", Offset = "0x513D60")]
			remove
			{
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xB3F8D0", Offset = "0xB3F8D0", VA = "0xB3F8D0")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xB3F94C", Offset = "0xB3F94C", VA = "0xB3F94C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xB40F8C", Offset = "0xB40F8C", VA = "0xB40F8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xB40FD8", Offset = "0xB40FD8", VA = "0xB40FD8")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xB40FDC", Offset = "0xB40FDC", VA = "0xB40FDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xB41020", Offset = "0xB41020", VA = "0xB41020")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xB41064", Offset = "0xB41064", VA = "0xB41064")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xB410A8", Offset = "0xB410A8", VA = "0xB410A8")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xB410B4", Offset = "0xB410B4", VA = "0xB410B4")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xB3F9A4", Offset = "0xB3F9A4", VA = "0xB3F9A4")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xB4303C", Offset = "0xB4303C", VA = "0xB4303C")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB43154", Offset = "0xB43154", VA = "0xB43154")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB4324C", Offset = "0xB4324C", VA = "0xB4324C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xB432D8", Offset = "0xB432D8", VA = "0xB432D8", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xB43364", Offset = "0xB43364", VA = "0xB43364", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB433F0", Offset = "0xB433F0", VA = "0xB433F0", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xB4347C", Offset = "0xB4347C", VA = "0xB4347C", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xB43508", Offset = "0xB43508", VA = "0xB43508", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xB43600", Offset = "0xB43600", VA = "0xB43600", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xB43610", Offset = "0xB43610", VA = "0xB43610", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xB439A0", Offset = "0xB439A0", VA = "0xB439A0", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xB43A30", Offset = "0xB43A30", VA = "0xB43A30", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xB43AD0", Offset = "0xB43AD0", VA = "0xB43AD0")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xB43B6C", Offset = "0xB43B6C", VA = "0xB43B6C")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xB43BD0", Offset = "0xB43BD0", VA = "0xB43BD0")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB43C34", Offset = "0xB43C34", VA = "0xB43C34")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xB43CD0", Offset = "0xB43CD0", VA = "0xB43CD0")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xB43D34", Offset = "0xB43D34", VA = "0xB43D34")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xB43DD0", Offset = "0xB43DD0", VA = "0xB43DD0")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xB43E34", Offset = "0xB43E34", VA = "0xB43E34")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB43F84", Offset = "0xB43F84", VA = "0xB43F84")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB44024", Offset = "0xB44024", VA = "0xB44024")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xB440A0", Offset = "0xB440A0", VA = "0xB440A0")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB4414C", Offset = "0xB4414C", VA = "0xB4414C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xB441CC", Offset = "0xB441CC", VA = "0xB441CC")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xB4426C", Offset = "0xB4426C", VA = "0xB4426C")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xB410D8", Offset = "0xB410D8", VA = "0xB410D8")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xB442D4", Offset = "0xB442D4", VA = "0xB442D4")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xB410C0", Offset = "0xB410C0", VA = "0xB410C0")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xB4301C", Offset = "0xB4301C", VA = "0xB4301C")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xB43738", Offset = "0xB43738", VA = "0xB43738")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB44318", Offset = "0xB44318", VA = "0xB44318")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xB44528", Offset = "0xB44528", VA = "0xB44528")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513D70", Offset = "0x513D70")]
		private void <CreateTween>b__53_0()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x600017C")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000061")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513110", Offset = "0x513110")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1224DA8", Offset = "0x1224DA8", VA = "0x1224DA8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1224DB0", Offset = "0x1224DB0", VA = "0x1224DB0")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1224DCC", Offset = "0x1224DCC", VA = "0x1224DCC")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513120", Offset = "0x513120")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1224DE8", Offset = "0x1224DE8", VA = "0x1224DE8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1224DF0", Offset = "0x1224DF0", VA = "0x1224DF0")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xB4D234", Offset = "0xB4D234", VA = "0xB4D234")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB4D280", Offset = "0xB4D280", VA = "0xB4D280")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB4D5B0", Offset = "0xB4D5B0", VA = "0xB4D5B0")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
namespace BezierSolution
{
	[Token(Token = "0x2000064")]
	public class BezierPoint : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000065")]
		public struct ExtraData
		{
			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float c1;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float c2;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float c3;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float c4;

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xB4DF98", Offset = "0xB4DF98", VA = "0xB4DF98")]
			public ExtraData(float c1 = 0f, float c2 = 0f, float c3 = 0f, float c4 = 0f)
			{
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xB4DFA4", Offset = "0xB4DFA4", VA = "0xB4DFA4")]
			public static ExtraData Lerp(ExtraData a, ExtraData b, float t)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xB4E034", Offset = "0xB4E034", VA = "0xB4E034")]
			public static ExtraData LerpUnclamped(ExtraData a, ExtraData b, float t)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xB4E06C", Offset = "0xB4E06C", VA = "0xB4E06C")]
			public static implicit operator ExtraData(Vector2 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xB4E078", Offset = "0xB4E078", VA = "0xB4E078")]
			public static implicit operator ExtraData(Vector3 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xB4E080", Offset = "0xB4E080", VA = "0xB4E080")]
			public static implicit operator ExtraData(Vector4 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xB3E35C", Offset = "0xB3E35C", VA = "0xB3E35C")]
			public static implicit operator ExtraData(Quaternion q)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xB4E084", Offset = "0xB4E084", VA = "0xB4E084")]
			public static implicit operator ExtraData(Rect r)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xB4E100", Offset = "0xB4E100", VA = "0xB4E100")]
			public static implicit operator ExtraData(Vector2Int v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xB4E118", Offset = "0xB4E118", VA = "0xB4E118")]
			public static implicit operator ExtraData(Vector3Int v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xB4E17C", Offset = "0xB4E17C", VA = "0xB4E17C")]
			public static implicit operator ExtraData(RectInt r)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xB4E1F4", Offset = "0xB4E1F4", VA = "0xB4E1F4")]
			public static implicit operator Vector2(ExtraData v)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xB4E1F8", Offset = "0xB4E1F8", VA = "0xB4E1F8")]
			public static implicit operator Vector3(ExtraData v)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xB4E1FC", Offset = "0xB4E1FC", VA = "0xB4E1FC")]
			public static implicit operator Vector4(ExtraData v)
			{
				return default(Vector4);
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xB3E32C", Offset = "0xB3E32C", VA = "0xB3E32C")]
			public static implicit operator Quaternion(ExtraData v)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xB4E22C", Offset = "0xB4E22C", VA = "0xB4E22C")]
			public static implicit operator Rect(ExtraData v)
			{
				return default(Rect);
			}

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xB4E25C", Offset = "0xB4E25C", VA = "0xB4E25C")]
			public static implicit operator Vector2Int(ExtraData v)
			{
				return default(Vector2Int);
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xB4E2A4", Offset = "0xB4E2A4", VA = "0xB4E2A4")]
			public static implicit operator Vector3Int(ExtraData v)
			{
				return default(Vector3Int);
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xB4E304", Offset = "0xB4E304", VA = "0xB4E304")]
			public static implicit operator RectInt(ExtraData v)
			{
				return default(RectInt);
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xB4E3A4", Offset = "0xB4E3A4", VA = "0xB4E3A4")]
			public static bool operator ==(ExtraData d1, ExtraData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xB4E3D4", Offset = "0xB4E3D4", VA = "0xB4E3D4")]
			public static bool operator !=(ExtraData d1, ExtraData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xB4E404", Offset = "0xB4E404", VA = "0xB4E404", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xB4E4C8", Offset = "0xB4E4C8", VA = "0xB4E4C8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xB4E500", Offset = "0xB4E500", VA = "0xB4E500", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000066")]
		public enum HandleMode
		{
			[Token(Token = "0x40000E6")]
			Free,
			[Token(Token = "0x40000E7")]
			Aligned,
			[Token(Token = "0x40000E8")]
			Mirrored
		}

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private Vector3 m_position;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_precedingControlPointLocalPosition;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_precedingControlPointPosition;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		[SerializeField]
		private Vector3 m_followingControlPointLocalPosition;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_followingControlPointPosition;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		[SerializeField]
		private HandleMode m_handleMode;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ExtraData extraData;

		[Token(Token = "0x17000007")]
		public Vector3 localPosition
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xB39758", Offset = "0xB39758", VA = "0xB39758")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xB3977C", Offset = "0xB3977C", VA = "0xB3977C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Vector3 position
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xB397C8", Offset = "0xB397C8", VA = "0xB397C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xB398B4", Offset = "0xB398B4", VA = "0xB398B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Quaternion localRotation
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xB39900", Offset = "0xB39900", VA = "0xB39900")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xB39924", Offset = "0xB39924", VA = "0xB39924")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Quaternion rotation
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xB39978", Offset = "0xB39978", VA = "0xB39978")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xB3999C", Offset = "0xB3999C", VA = "0xB3999C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Vector3 localEulerAngles
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xB399F0", Offset = "0xB399F0", VA = "0xB399F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xB39A14", Offset = "0xB39A14", VA = "0xB39A14")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xB39A60", Offset = "0xB39A60", VA = "0xB39A60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xB39A84", Offset = "0xB39A84", VA = "0xB39A84")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector3 localScale
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xB39AD0", Offset = "0xB39AD0", VA = "0xB39AD0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xB39AF4", Offset = "0xB39AF4", VA = "0xB39AF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 precedingControlPointLocalPosition
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xB39B40", Offset = "0xB39B40", VA = "0xB39B40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xB39B4C", Offset = "0xB39B4C", VA = "0xB39B4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector3 precedingControlPointPosition
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xB39C50", Offset = "0xB39C50", VA = "0xB39C50")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xB39C98", Offset = "0xB39C98", VA = "0xB39C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 followingControlPointLocalPosition
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xB39E50", Offset = "0xB39E50", VA = "0xB39E50")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xB39E5C", Offset = "0xB39E5C", VA = "0xB39E5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 followingControlPointPosition
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xB39F60", Offset = "0xB39F60", VA = "0xB39F60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xB39FA8", Offset = "0xB39FA8", VA = "0xB39FA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public HandleMode handleMode
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xB3A160", Offset = "0xB3A160", VA = "0xB3A160")]
			get
			{
				return default(HandleMode);
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xB3A168", Offset = "0xB3A168", VA = "0xB3A168")]
			set
			{
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB3A188", Offset = "0xB3A188", VA = "0xB3A188")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xB3A1B0", Offset = "0xB3A1B0", VA = "0xB3A1B0")]
		public void CopyTo(BezierPoint other)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB39810", Offset = "0xB39810", VA = "0xB39810")]
		private void Revalidate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB3A2B0", Offset = "0xB3A2B0", VA = "0xB3A2B0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x513DB0", Offset = "0x513DB0")]
		private void SetSplineDirty()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB3A2B4", Offset = "0xB3A2B4", VA = "0xB3A2B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB3A33C", Offset = "0xB3A33C", VA = "0xB3A33C")]
		public BezierPoint()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x513130", Offset = "0x513130")]
	[ExecuteInEditMode]
	public class BezierSpline : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		public struct PointIndexTuple
		{
			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly int index1;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly int index2;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly float t;

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xB3C7C4", Offset = "0xB3C7C4", VA = "0xB3C7C4")]
			public PointIndexTuple(int index1, int index2, float t)
			{
			}
		}

		[Token(Token = "0x2000069")]
		public delegate BezierPoint.ExtraData ExtraDataLerpFunction(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT);

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ExtraDataLerpFunction defaultExtraDataLerpFunction;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material gizmoMaterial;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<BezierPoint> endPoints;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool loop;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool drawGizmos;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color gizmoColor;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float gizmoStep;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_gizmoSmoothness;

		[Token(Token = "0x17000013")]
		public int gizmoSmoothness
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xB3A388", Offset = "0xB3A388", VA = "0xB3A388")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xB3A390", Offset = "0xB3A390", VA = "0xB3A390")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public int Count
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xB3A414", Offset = "0xB3A414", VA = "0xB3A414")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public float Length
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xB3A460", Offset = "0xB3A460", VA = "0xB3A460")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public BezierPoint Item
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xB3A5C4", Offset = "0xB3A5C4", VA = "0xB3A5C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB3A704", Offset = "0xB3A704", VA = "0xB3A704")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xB3A78C", Offset = "0xB3A78C", VA = "0xB3A78C")]
		public void Initialize(int endPointsCount)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB3A708", Offset = "0xB3A708", VA = "0xB3A708")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xB3A974", Offset = "0xB3A974", VA = "0xB3A974")]
		public BezierPoint InsertNewPointAt(int index)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xB3ADD8", Offset = "0xB3ADD8", VA = "0xB3ADD8")]
		public BezierPoint DuplicatePointAt(int index)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xB3B0B4", Offset = "0xB3B0B4", VA = "0xB3B0B4")]
		public void RemovePointAt(int index)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xB3B42C", Offset = "0xB3B42C", VA = "0xB3B42C")]
		public void SwapPointsAt(int index1, int index2)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xB3B744", Offset = "0xB3B744", VA = "0xB3B744")]
		public void MovePoint(int previousIndex, int newIndex)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xB3B748", Offset = "0xB3B748", VA = "0xB3B748")]
		public void Internal_MovePoint(int previousIndex, int newIndex, string undo)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xB3BB20", Offset = "0xB3BB20", VA = "0xB3BB20")]
		public int IndexOf(BezierPoint point)
		{
			return default(int);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xB3BB84", Offset = "0xB3BB84", VA = "0xB3BB84")]
		public Vector3 GetPoint(float normalizedT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xB3BDD0", Offset = "0xB3BDD0", VA = "0xB3BDD0")]
		public Vector3 GetTangent(float normalizedT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xB3C0F0", Offset = "0xB3C0F0", VA = "0xB3C0F0")]
		public BezierPoint.ExtraData GetExtraData(float normalizedT)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xB3C16C", Offset = "0xB3C16C", VA = "0xB3C16C")]
		public BezierPoint.ExtraData GetExtraData(float normalizedT, ExtraDataLerpFunction lerpFunction)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB3A474", Offset = "0xB3A474", VA = "0xB3A474")]
		public float GetLengthApproximately(float startNormalizedT, float endNormalizedT, float accuracy = 50f)
		{
			return default(float);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB3C6D0", Offset = "0xB3C6D0", VA = "0xB3C6D0")]
		public PointIndexTuple GetNearestPointIndicesTo(float normalizedT)
		{
			return default(PointIndexTuple);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB3C7D0", Offset = "0xB3C7D0", VA = "0xB3C7D0")]
		public Vector3 FindNearestPointTo(Vector3 worldPos, float accuracy = 100f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xB3C7F4", Offset = "0xB3C7F4", VA = "0xB3C7F4")]
		public Vector3 FindNearestPointTo(Vector3 worldPos, out float normalizedT, float accuracy = 100f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB3C918", Offset = "0xB3C918", VA = "0xB3C918")]
		public Vector3 MoveAlongSpline(ref float normalizedT, float deltaMovement, int accuracy = 3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xB3C9F4", Offset = "0xB3C9F4", VA = "0xB3C9F4")]
		public void ConstructLinearPath()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xB3CC98", Offset = "0xB3CC98", VA = "0xB3CC98")]
		public void AutoConstructSpline()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB3D6D8", Offset = "0xB3D6D8", VA = "0xB3D6D8")]
		private static Vector3[] GetFirstControlPoints(Vector3[] rhs)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xB3D8F4", Offset = "0xB3D8F4", VA = "0xB3D8F4")]
		public void AutoConstructSpline2()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xB3C69C", Offset = "0xB3C69C", VA = "0xB3C69C")]
		private float AccuracyToStepSize(float accuracy)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xB3DDD0", Offset = "0xB3DDD0", VA = "0xB3DDD0")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xB3E138", Offset = "0xB3E138", VA = "0xB3E138")]
		public BezierSpline()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public enum TravelMode
	{
		[Token(Token = "0x40000F5")]
		Once,
		[Token(Token = "0x40000F6")]
		Loop,
		[Token(Token = "0x40000F7")]
		PingPong
	}
	[Token(Token = "0x200006B")]
	public enum LookAtMode
	{
		[Token(Token = "0x40000F9")]
		None,
		[Token(Token = "0x40000FA")]
		Forward,
		[Token(Token = "0x40000FB")]
		SplineExtraData
	}
	[Token(Token = "0x200006C")]
	public abstract class BezierWalker : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly BezierSpline.ExtraDataLerpFunction extraDataLerpAsQuaternionFunction;

		[Token(Token = "0x17000017")]
		public abstract BezierSpline Spline
		{
			[Token(Token = "0x60001E0")]
			get;
		}

		[Token(Token = "0x17000018")]
		public abstract bool MovingForward
		{
			[Token(Token = "0x60001E1")]
			get;
		}

		[Token(Token = "0x17000019")]
		public abstract float NormalizedT
		{
			[Token(Token = "0x60001E2")]
			get;
			[Token(Token = "0x60001E3")]
			set;
		}

		[Token(Token = "0x60001E4")]
		public abstract void Execute(float deltaTime);

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xB3E290", Offset = "0xB3E290", VA = "0xB3E290")]
		private static BezierPoint.ExtraData InterpolateExtraDataAsQuaternion(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xB3E360", Offset = "0xB3E360", VA = "0xB3E360")]
		protected BezierWalker()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BezierWalkerLocomotion : BezierWalker
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierWalker walker;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> tailObjects;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<float> tailObjectDistances;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float movementLerpModifier;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationLerpModifier;

		[NonSerialized]
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x51332C", Offset = "0x51332C")]
		public bool lookForward;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LookAtMode lookAt;

		[Token(Token = "0x1700001A")]
		public List<Transform> Tail
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xB3E408", Offset = "0xB3E408", VA = "0xB3E408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public List<float> TailDistances
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xB3E410", Offset = "0xB3E410", VA = "0xB3E410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xB3E418", Offset = "0xB3E418", VA = "0xB3E418", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public override bool MovingForward
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xB3E438", Offset = "0xB3E438", VA = "0xB3E438", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public override float NormalizedT
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xB3E458", Offset = "0xB3E458", VA = "0xB3E458", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xB3E478", Offset = "0xB3E478", VA = "0xB3E478", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xB3E498", Offset = "0xB3E498", VA = "0xB3E498")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xB3E62C", Offset = "0xB3E62C", VA = "0xB3E62C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xB3E65C", Offset = "0xB3E65C", VA = "0xB3E65C", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xB3E9B8", Offset = "0xB3E9B8", VA = "0xB3E9B8")]
		public void AddToTail(Transform transform, float distanceToPreviousObject)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xB3EAEC", Offset = "0xB3EAEC", VA = "0xB3EAEC")]
		public void InsertIntoTail(int index, Transform transform, float distanceToPreviousObject)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xB3EC2C", Offset = "0xB3EC2C", VA = "0xB3EC2C")]
		public void RemoveFromTail(Transform transform)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xB3EDF8", Offset = "0xB3EDF8", VA = "0xB3EDF8")]
		public BezierWalkerLocomotion()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class BezierWalkerWithSpeed : BezierWalker
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierSpline spline;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TravelMode travelMode;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x513368", Offset = "0x513368")]
		[SerializeField]
		private float m_normalizedT;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float rotationLerpModifier;

		[NonSerialized]
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5133A8", Offset = "0x5133A8")]
		public bool lookForward;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LookAtMode lookAt;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isGoingForward;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onPathCompleted;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool onPathCompletedCalledAt1;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool onPathCompletedCalledAt0;

		[Token(Token = "0x1700001F")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xB3EE70", Offset = "0xB3EE70", VA = "0xB3EE70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public override float NormalizedT
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xB3EE78", Offset = "0xB3EE78", VA = "0xB3EE78", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xB3EE80", Offset = "0xB3EE80", VA = "0xB3EE80", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public override bool MovingForward
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xB3EE88", Offset = "0xB3EE88", VA = "0xB3EE88", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xB3EEA8", Offset = "0xB3EEA8", VA = "0xB3EEA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xB3EED8", Offset = "0xB3EED8", VA = "0xB3EED8", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xB3F21C", Offset = "0xB3F21C", VA = "0xB3F21C")]
		public BezierWalkerWithSpeed()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class BezierWalkerWithTime : BezierWalker
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierSpline spline;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TravelMode travelMode;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float travelTime;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5133E4", Offset = "0x5133E4")]
		[SerializeField]
		private float m_normalizedT;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float movementLerpModifier;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rotationLerpModifier;

		[NonSerialized]
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x513424", Offset = "0x513424")]
		public bool lookForward;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LookAtMode lookAt;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool isGoingForward;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onPathCompleted;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool onPathCompletedCalledAt1;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool onPathCompletedCalledAt0;

		[Token(Token = "0x17000022")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xB3F2D8", Offset = "0xB3F2D8", VA = "0xB3F2D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public override float NormalizedT
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xB3F2E0", Offset = "0xB3F2E0", VA = "0xB3F2E0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xB3F2E8", Offset = "0xB3F2E8", VA = "0xB3F2E8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public override bool MovingForward
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xB3F2F0", Offset = "0xB3F2F0", VA = "0xB3F2F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB3F2F8", Offset = "0xB3F2F8", VA = "0xB3F2F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB3F328", Offset = "0xB3F328", VA = "0xB3F328", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB3F69C", Offset = "0xB3F69C", VA = "0xB3F69C")]
		public BezierWalkerWithTime()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[ExecuteInEditMode]
	public class ParticlesFollowBezier : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		public enum FollowMode
		{
			[Token(Token = "0x4000124")]
			Relaxed,
			[Token(Token = "0x4000125")]
			Strict
		}

		[Token(Token = "0x400011B")]
		private const int MAX_PARTICLE_COUNT = 25000;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierSpline spline;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FollowMode followMode;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform cachedTransform;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem cachedPS;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule cachedMainModule;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector4> particleData;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB4D8E4", Offset = "0xB4D8E4", VA = "0xB4D8E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB4DA40", Offset = "0xB4DA40", VA = "0xB4DA40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xB4DF90", Offset = "0xB4DF90", VA = "0xB4DF90")]
		public ParticlesFollowBezier()
		{
		}
	}
}
