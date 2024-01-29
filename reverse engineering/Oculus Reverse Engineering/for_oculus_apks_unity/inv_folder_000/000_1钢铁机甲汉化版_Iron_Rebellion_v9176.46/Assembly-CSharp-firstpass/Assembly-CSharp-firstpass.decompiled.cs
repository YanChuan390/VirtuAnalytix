using System;
using System.Collections.Generic;
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
using Microsoft.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C698", Offset = "0x92C698")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1364800", Offset = "0x1364800", VA = "0x1364800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C6D0", Offset = "0x92C6D0")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1364808", Offset = "0x1364808", VA = "0x1364808")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000004")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C718", Offset = "0x92C718")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000001")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x13578C0", Offset = "0x13578C0", VA = "0x13578C0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000013")]
			[Address(RVA = "0x13657A0", Offset = "0x13657A0", VA = "0x13657A0")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x13657BC", Offset = "0x13657BC", VA = "0x13657BC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000006")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C728", Offset = "0x92C728")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1357A70", Offset = "0x1357A70", VA = "0x1357A70")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x13657D8", Offset = "0x13657D8", VA = "0x13657D8")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x13657F4", Offset = "0x13657F4", VA = "0x13657F4")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C738", Offset = "0x92C738")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1357C34", Offset = "0x1357C34", VA = "0x1357C34")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1365810", Offset = "0x1365810", VA = "0x1365810")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1365850", Offset = "0x1365850", VA = "0x1365850")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x13576F0", Offset = "0x13576F0", VA = "0x13576F0")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x13578C8", Offset = "0x13578C8", VA = "0x13578C8")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1357A78", Offset = "0x1357A78", VA = "0x1357A78")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1357C3C", Offset = "0x1357C3C", VA = "0x1357C3C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1357CB0", Offset = "0x1357CB0", VA = "0x1357CB0")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1357D24", Offset = "0x1357D24", VA = "0x1357D24")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1357D88", Offset = "0x1357D88", VA = "0x1357D88")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1357E0C", Offset = "0x1357E0C", VA = "0x1357E0C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1357E70", Offset = "0x1357E70", VA = "0x1357E70")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1357ED4", Offset = "0x1357ED4", VA = "0x1357ED4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1357F38", Offset = "0x1357F38", VA = "0x1357F38")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1357F9C", Offset = "0x1357F9C", VA = "0x1357F9C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1358008", Offset = "0x1358008", VA = "0x1358008")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1358070", Offset = "0x1358070", VA = "0x1358070")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x13580D4", Offset = "0x13580D4", VA = "0x13580D4")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000008")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C758", Offset = "0x92C758")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1358138", Offset = "0x1358138", VA = "0x1358138")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1365874", Offset = "0x1365874", VA = "0x1365874")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C768", Offset = "0x92C768")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1358310", Offset = "0x1358310", VA = "0x1358310")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x13659AC", Offset = "0x13659AC", VA = "0x13659AC")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C778", Offset = "0x92C778")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x13584E8", Offset = "0x13584E8", VA = "0x13584E8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x13659C8", Offset = "0x13659C8", VA = "0x13659C8")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C788", Offset = "0x92C788")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x13586C0", Offset = "0x13586C0", VA = "0x13586C0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x13659E4", Offset = "0x13659E4", VA = "0x13659E4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C798", Offset = "0x92C798")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x13586C8", Offset = "0x13586C8", VA = "0x13586C8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1365A00", Offset = "0x1365A00", VA = "0x1365A00")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C7A8", Offset = "0x92C7A8")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1358924", Offset = "0x1358924", VA = "0x1358924")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1365A1C", Offset = "0x1365A1C", VA = "0x1365A1C")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C7B8", Offset = "0x92C7B8")]
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

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1358E60", Offset = "0x1358E60", VA = "0x1358E60")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1365A38", Offset = "0x1365A38", VA = "0x1365A38")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1365A54", Offset = "0x1365A54", VA = "0x1365A54")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1365A88", Offset = "0x1365A88", VA = "0x1365A88")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1365AA4", Offset = "0x1365AA4", VA = "0x1365AA4")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1365AC0", Offset = "0x1365AC0", VA = "0x1365AC0")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C7C8", Offset = "0x92C7C8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x13590E4", Offset = "0x13590E4", VA = "0x13590E4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1365B80", Offset = "0x1365B80", VA = "0x1365B80")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C7D8", Offset = "0x92C7D8")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1359388", Offset = "0x1359388", VA = "0x1359388")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1365B9C", Offset = "0x1365B9C", VA = "0x1365B9C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1365BB8", Offset = "0x1365BB8", VA = "0x1365BB8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C7E8", Offset = "0x92C7E8")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1359580", Offset = "0x1359580", VA = "0x1359580")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1365CB8", Offset = "0x1365CB8", VA = "0x1365CB8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C7F8", Offset = "0x92C7F8")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1359798", Offset = "0x1359798", VA = "0x1359798")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1365890", Offset = "0x1365890", VA = "0x1365890")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x13658AC", Offset = "0x13658AC", VA = "0x13658AC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1354484", Offset = "0x1354484", VA = "0x1354484")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1358140", Offset = "0x1358140", VA = "0x1358140")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1358318", Offset = "0x1358318", VA = "0x1358318")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x13584F0", Offset = "0x13584F0", VA = "0x13584F0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1354834", Offset = "0x1354834", VA = "0x1354834")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x13586D0", Offset = "0x13586D0", VA = "0x13586D0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x135892C", Offset = "0x135892C", VA = "0x135892C")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1358E68", Offset = "0x1358E68", VA = "0x1358E68")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x13590EC", Offset = "0x13590EC", VA = "0x13590EC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1359390", Offset = "0x1359390", VA = "0x1359390")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1359588", Offset = "0x1359588", VA = "0x1359588")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C818", Offset = "0x92C818")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x13597A0", Offset = "0x13597A0", VA = "0x13597A0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1365CD4", Offset = "0x1365CD4", VA = "0x1365CD4")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C828", Offset = "0x92C828")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1359974", Offset = "0x1359974", VA = "0x1359974")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1365CF0", Offset = "0x1365CF0", VA = "0x1365CF0")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C838", Offset = "0x92C838")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1359B48", Offset = "0x1359B48", VA = "0x1359B48")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1365D0C", Offset = "0x1365D0C", VA = "0x1365D0C")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C848", Offset = "0x92C848")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1359B50", Offset = "0x1359B50", VA = "0x1359B50")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1365D28", Offset = "0x1365D28", VA = "0x1365D28")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C858", Offset = "0x92C858")]
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
			[Address(RVA = "0x1359FB4", Offset = "0x1359FB4", VA = "0x1359FB4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1365D44", Offset = "0x1365D44", VA = "0x1365D44")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1365D60", Offset = "0x1365D60", VA = "0x1365D60")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1365D7C", Offset = "0x1365D7C", VA = "0x1365D7C")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1365DB0", Offset = "0x1365DB0", VA = "0x1365DB0")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1365DCC", Offset = "0x1365DCC", VA = "0x1365DCC")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1365DE8", Offset = "0x1365DE8", VA = "0x1365DE8")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C868", Offset = "0x92C868")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x135A2BC", Offset = "0x135A2BC", VA = "0x135A2BC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1365EA0", Offset = "0x1365EA0", VA = "0x1365EA0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1365EC8", Offset = "0x1365EC8", VA = "0x1365EC8")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C878", Offset = "0x92C878")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x135A5E8", Offset = "0x135A5E8", VA = "0x135A5E8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1365EE4", Offset = "0x1365EE4", VA = "0x1365EE4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1365F00", Offset = "0x1365F00", VA = "0x1365F00")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1354660", Offset = "0x1354660", VA = "0x1354660")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x13597A8", Offset = "0x13597A8", VA = "0x13597A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x135997C", Offset = "0x135997C", VA = "0x135997C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1354A0C", Offset = "0x1354A0C", VA = "0x1354A0C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1359B58", Offset = "0x1359B58", VA = "0x1359B58")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1359FBC", Offset = "0x1359FBC", VA = "0x1359FBC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x135A2C4", Offset = "0x135A2C4", VA = "0x135A2C4")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C898", Offset = "0x92C898")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x135A5F0", Offset = "0x135A5F0", VA = "0x135A5F0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1365FF8", Offset = "0x1365FF8", VA = "0x1365FF8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0x1366014", Offset = "0x1366014", VA = "0x1366014")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C8A8", Offset = "0x92C8A8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000065")]
			[Address(RVA = "0x135A5F8", Offset = "0x135A5F8", VA = "0x135A5F8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0x1366030", Offset = "0x1366030", VA = "0x1366030")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x136604C", Offset = "0x136604C", VA = "0x136604C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C8B8", Offset = "0x92C8B8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x135AA48", Offset = "0x135AA48", VA = "0x135AA48")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x1366068", Offset = "0x1366068", VA = "0x1366068")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1366074", Offset = "0x1366074", VA = "0x1366074")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1354D88", Offset = "0x1354D88", VA = "0x1354D88")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x13554C8", Offset = "0x13554C8", VA = "0x13554C8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x135A600", Offset = "0x135A600", VA = "0x135A600")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x135A7EC", Offset = "0x135A7EC", VA = "0x135A7EC")]
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
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x1354068", Offset = "0x1354068", VA = "0x1354068")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C8D8", Offset = "0x92C8D8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x135AA50", Offset = "0x135AA50", VA = "0x135AA50")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1366120", Offset = "0x1366120", VA = "0x1366120")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x136613C", Offset = "0x136613C", VA = "0x136613C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C8E8", Offset = "0x92C8E8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x135AA58", Offset = "0x135AA58", VA = "0x135AA58")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1366390", Offset = "0x1366390", VA = "0x1366390")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x13663B4", Offset = "0x13663B4", VA = "0x13663B4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C8F8", Offset = "0x92C8F8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x135AA60", Offset = "0x135AA60", VA = "0x135AA60")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x136674C", Offset = "0x136674C", VA = "0x136674C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1366770", Offset = "0x1366770", VA = "0x1366770")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C908", Offset = "0x92C908")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x135AC38", Offset = "0x135AC38", VA = "0x135AC38")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1366BF8", Offset = "0x1366BF8", VA = "0x1366BF8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1366C1C", Offset = "0x1366C1C", VA = "0x1366C1C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C918", Offset = "0x92C918")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x135ADE8", Offset = "0x135ADE8", VA = "0x135ADE8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1366D08", Offset = "0x1366D08", VA = "0x1366D08")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1366D2C", Offset = "0x1366D2C", VA = "0x1366D2C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C928", Offset = "0x92C928")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x135AFBC", Offset = "0x135AFBC", VA = "0x135AFBC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1366D50", Offset = "0x1366D50", VA = "0x1366D50")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1366D6C", Offset = "0x1366D6C", VA = "0x1366D6C")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C938", Offset = "0x92C938")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x135B388", Offset = "0x135B388", VA = "0x135B388")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1366D88", Offset = "0x1366D88", VA = "0x1366D88")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1366DEC", Offset = "0x1366DEC", VA = "0x1366DEC")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C948", Offset = "0x92C948")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x135B560", Offset = "0x135B560", VA = "0x135B560")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1366E48", Offset = "0x1366E48", VA = "0x1366E48")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1366EAC", Offset = "0x1366EAC", VA = "0x1366EAC")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C958", Offset = "0x92C958")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x135B738", Offset = "0x135B738", VA = "0x135B738")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1366F08", Offset = "0x1366F08", VA = "0x1366F08")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1366F6C", Offset = "0x1366F6C", VA = "0x1366F6C")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C968", Offset = "0x92C968")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x135B910", Offset = "0x135B910", VA = "0x135B910")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1366158", Offset = "0x1366158", VA = "0x1366158")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1366178", Offset = "0x1366178", VA = "0x1366178")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C978", Offset = "0x92C978")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x135BAC0", Offset = "0x135BAC0", VA = "0x135BAC0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1366194", Offset = "0x1366194", VA = "0x1366194")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x13661B4", Offset = "0x13661B4", VA = "0x13661B4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C988", Offset = "0x92C988")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x135BC80", Offset = "0x135BC80", VA = "0x135BC80")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x13661D0", Offset = "0x13661D0", VA = "0x13661D0")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x13661EC", Offset = "0x13661EC", VA = "0x13661EC")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C998", Offset = "0x92C998")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x135BE58", Offset = "0x135BE58", VA = "0x135BE58")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1366208", Offset = "0x1366208", VA = "0x1366208")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1366224", Offset = "0x1366224", VA = "0x1366224")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C9A8", Offset = "0x92C9A8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x135C028", Offset = "0x135C028", VA = "0x135C028")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1366240", Offset = "0x1366240", VA = "0x1366240")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x136625C", Offset = "0x136625C", VA = "0x136625C")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C9B8", Offset = "0x92C9B8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x135C1F8", Offset = "0x135C1F8", VA = "0x135C1F8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1366278", Offset = "0x1366278", VA = "0x1366278")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1366294", Offset = "0x1366294", VA = "0x1366294")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C9C8", Offset = "0x92C9C8")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x135C200", Offset = "0x135C200", VA = "0x135C200")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x13662B0", Offset = "0x13662B0", VA = "0x13662B0")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x13662CC", Offset = "0x13662CC", VA = "0x13662CC")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C9D8", Offset = "0x92C9D8")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x135C3D4", Offset = "0x135C3D4", VA = "0x135C3D4")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x13662E8", Offset = "0x13662E8", VA = "0x13662E8")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1366304", Offset = "0x1366304", VA = "0x1366304")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C9E8", Offset = "0x92C9E8")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x135C5A8", Offset = "0x135C5A8", VA = "0x135C5A8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1366320", Offset = "0x1366320", VA = "0x1366320")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x136633C", Offset = "0x136633C", VA = "0x136633C")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C9F8", Offset = "0x92C9F8")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x135C77C", Offset = "0x135C77C", VA = "0x135C77C")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1366358", Offset = "0x1366358", VA = "0x1366358")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1366374", Offset = "0x1366374", VA = "0x1366374")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA08", Offset = "0x92CA08")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x135C954", Offset = "0x135C954", VA = "0x135C954")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x13663D8", Offset = "0x13663D8", VA = "0x13663D8")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x13663F4", Offset = "0x13663F4", VA = "0x13663F4")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA18", Offset = "0x92CA18")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x135CB2C", Offset = "0x135CB2C", VA = "0x135CB2C")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1366410", Offset = "0x1366410", VA = "0x1366410")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x136642C", Offset = "0x136642C", VA = "0x136642C")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA28", Offset = "0x92CA28")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x135CCEC", Offset = "0x135CCEC", VA = "0x135CCEC")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1366448", Offset = "0x1366448", VA = "0x1366448")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1366464", Offset = "0x1366464", VA = "0x1366464")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA38", Offset = "0x92CA38")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x135CEB0", Offset = "0x135CEB0", VA = "0x135CEB0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1366480", Offset = "0x1366480", VA = "0x1366480")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x136649C", Offset = "0x136649C", VA = "0x136649C")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA48", Offset = "0x92CA48")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x135D074", Offset = "0x135D074", VA = "0x135D074")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x13664B8", Offset = "0x13664B8", VA = "0x13664B8")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x13664D4", Offset = "0x13664D4", VA = "0x13664D4")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA58", Offset = "0x92CA58")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x135D07C", Offset = "0x135D07C", VA = "0x135D07C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x13664F0", Offset = "0x13664F0", VA = "0x13664F0")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x136650C", Offset = "0x136650C", VA = "0x136650C")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA68", Offset = "0x92CA68")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x135D084", Offset = "0x135D084", VA = "0x135D084")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x1366528", Offset = "0x1366528", VA = "0x1366528")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1366550", Offset = "0x1366550", VA = "0x1366550")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA78", Offset = "0x92CA78")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x135D28C", Offset = "0x135D28C", VA = "0x135D28C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x136656C", Offset = "0x136656C", VA = "0x136656C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1366594", Offset = "0x1366594", VA = "0x1366594")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA88", Offset = "0x92CA88")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x135D294", Offset = "0x135D294", VA = "0x135D294")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x13665B0", Offset = "0x13665B0", VA = "0x13665B0")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x13665D8", Offset = "0x13665D8", VA = "0x13665D8")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CA98", Offset = "0x92CA98")]
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

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x135D6F0", Offset = "0x135D6F0", VA = "0x135D6F0")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x13665F4", Offset = "0x13665F4", VA = "0x13665F4")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1366610", Offset = "0x1366610", VA = "0x1366610")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x136662C", Offset = "0x136662C", VA = "0x136662C")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1366660", Offset = "0x1366660", VA = "0x1366660")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x136667C", Offset = "0x136667C", VA = "0x136667C")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1366698", Offset = "0x1366698", VA = "0x1366698")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CAA8", Offset = "0x92CAA8")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x135D8BC", Offset = "0x135D8BC", VA = "0x135D8BC")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1366794", Offset = "0x1366794", VA = "0x1366794")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x13667E8", Offset = "0x13667E8", VA = "0x13667E8")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CAB8", Offset = "0x92CAB8")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x135DA78", Offset = "0x135DA78", VA = "0x135DA78")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1366834", Offset = "0x1366834", VA = "0x1366834")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1366850", Offset = "0x1366850", VA = "0x1366850")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CAC8", Offset = "0x92CAC8")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x135DC34", Offset = "0x135DC34", VA = "0x135DC34")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x136686C", Offset = "0x136686C", VA = "0x136686C")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1366888", Offset = "0x1366888", VA = "0x1366888")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CAD8", Offset = "0x92CAD8")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x135DDFC", Offset = "0x135DDFC", VA = "0x135DDFC")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x13668A4", Offset = "0x13668A4", VA = "0x13668A4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x13668C8", Offset = "0x13668C8", VA = "0x13668C8")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CAE8", Offset = "0x92CAE8")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x135DE04", Offset = "0x135DE04", VA = "0x135DE04")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x13668EC", Offset = "0x13668EC", VA = "0x13668EC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1366910", Offset = "0x1366910", VA = "0x1366910")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CAF8", Offset = "0x92CAF8")]
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

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x135E034", Offset = "0x135E034", VA = "0x135E034")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1366934", Offset = "0x1366934", VA = "0x1366934")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x136693C", Offset = "0x136693C", VA = "0x136693C")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB08", Offset = "0x92CB08")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x135E03C", Offset = "0x135E03C", VA = "0x135E03C")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x13669D8", Offset = "0x13669D8", VA = "0x13669D8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x13669FC", Offset = "0x13669FC", VA = "0x13669FC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB18", Offset = "0x92CB18")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x135E044", Offset = "0x135E044", VA = "0x135E044")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1366A20", Offset = "0x1366A20", VA = "0x1366A20")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1366A44", Offset = "0x1366A44", VA = "0x1366A44")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB28", Offset = "0x92CB28")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x135E2B0", Offset = "0x135E2B0", VA = "0x135E2B0")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1366A68", Offset = "0x1366A68", VA = "0x1366A68")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1366A74", Offset = "0x1366A74", VA = "0x1366A74")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB38", Offset = "0x92CB38")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x135E51C", Offset = "0x135E51C", VA = "0x135E51C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1366B30", Offset = "0x1366B30", VA = "0x1366B30")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1366B3C", Offset = "0x1366B3C", VA = "0x1366B3C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB48", Offset = "0x92CB48")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x135E788", Offset = "0x135E788", VA = "0x135E788")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1366C40", Offset = "0x1366C40", VA = "0x1366C40")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1366C4C", Offset = "0x1366C4C", VA = "0x1366C4C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x13559C0", Offset = "0x13559C0", VA = "0x13559C0")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1354F58", Offset = "0x1354F58", VA = "0x1354F58")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1355670", Offset = "0x1355670", VA = "0x1355670")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x135AA68", Offset = "0x135AA68", VA = "0x135AA68")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x135AC40", Offset = "0x135AC40", VA = "0x135AC40")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x135ADF0", Offset = "0x135ADF0", VA = "0x135ADF0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x135AFC4", Offset = "0x135AFC4", VA = "0x135AFC4")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x135B1B8", Offset = "0x135B1B8", VA = "0x135B1B8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x135B390", Offset = "0x135B390", VA = "0x135B390")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x135B568", Offset = "0x135B568", VA = "0x135B568")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x135B740", Offset = "0x135B740", VA = "0x135B740")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x135B918", Offset = "0x135B918", VA = "0x135B918")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x135BAC8", Offset = "0x135BAC8", VA = "0x135BAC8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x135BC88", Offset = "0x135BC88", VA = "0x135BC88")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x135BE60", Offset = "0x135BE60", VA = "0x135BE60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x135C030", Offset = "0x135C030", VA = "0x135C030")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x13542AC", Offset = "0x13542AC", VA = "0x13542AC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x135C208", Offset = "0x135C208", VA = "0x135C208")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x135C3DC", Offset = "0x135C3DC", VA = "0x135C3DC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x135C5B0", Offset = "0x135C5B0", VA = "0x135C5B0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x135C784", Offset = "0x135C784", VA = "0x135C784")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x135C95C", Offset = "0x135C95C", VA = "0x135C95C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x135CB34", Offset = "0x135CB34", VA = "0x135CB34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x135CCF4", Offset = "0x135CCF4", VA = "0x135CCF4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x135CEB8", Offset = "0x135CEB8", VA = "0x135CEB8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1354BB8", Offset = "0x1354BB8", VA = "0x1354BB8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x135613C", Offset = "0x135613C", VA = "0x135613C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x135D08C", Offset = "0x135D08C", VA = "0x135D08C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1356314", Offset = "0x1356314", VA = "0x1356314")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x135D29C", Offset = "0x135D29C", VA = "0x135D29C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x135D6F8", Offset = "0x135D6F8", VA = "0x135D6F8")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x135D8C4", Offset = "0x135D8C4", VA = "0x135D8C4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x135DA80", Offset = "0x135DA80", VA = "0x135DA80")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x135DC3C", Offset = "0x135DC3C", VA = "0x135DC3C")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1355128", Offset = "0x1355128", VA = "0x1355128")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x135DE0C", Offset = "0x135DE0C", VA = "0x135DE0C")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1355818", Offset = "0x1355818", VA = "0x1355818")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1355D10", Offset = "0x1355D10", VA = "0x1355D10")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x135E04C", Offset = "0x135E04C", VA = "0x135E04C")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x135E2B8", Offset = "0x135E2B8", VA = "0x135E2B8")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x135E524", Offset = "0x135E524", VA = "0x135E524")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB68", Offset = "0x92CB68")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x135F3F4", Offset = "0x135F3F4", VA = "0x135F3F4")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1366FC8", Offset = "0x1366FC8", VA = "0x1366FC8")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1366FEC", Offset = "0x1366FEC", VA = "0x1366FEC")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB78", Offset = "0x92CB78")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x135F624", Offset = "0x135F624", VA = "0x135F624")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1367010", Offset = "0x1367010", VA = "0x1367010")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1367034", Offset = "0x1367034", VA = "0x1367034")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB88", Offset = "0x92CB88")]
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

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x87D00C", Offset = "0x87D00C", VA = "0x87D00C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x87D014", Offset = "0x87D014", VA = "0x87D014", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB98", Offset = "0x92CB98")]
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

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x87D05C", Offset = "0x87D05C", VA = "0x87D05C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x87D064", Offset = "0x87D064", VA = "0x87D064", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CBA8", Offset = "0x92CBA8")]
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

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x87D034", Offset = "0x87D034", VA = "0x87D034", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x87D03C", Offset = "0x87D03C", VA = "0x87D03C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CBB8", Offset = "0x92CBB8")]
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

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x87D020", Offset = "0x87D020", VA = "0x87D020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600012E")]
			[Address(RVA = "0x87D028", Offset = "0x87D028", VA = "0x87D028", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CBC8", Offset = "0x92CBC8")]
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

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x87D048", Offset = "0x87D048", VA = "0x87D048", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x87D050", Offset = "0x87D050", VA = "0x87D050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CBD8", Offset = "0x92CBD8")]
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

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x87D070", Offset = "0x87D070", VA = "0x87D070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x87D078", Offset = "0x87D078", VA = "0x87D078", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x135E790", Offset = "0x135E790", VA = "0x135E790")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x135E980", Offset = "0x135E980", VA = "0x135E980")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x135EB84", Offset = "0x135EB84", VA = "0x135EB84")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x135EC84", Offset = "0x135EC84", VA = "0x135EC84")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x135ED84", Offset = "0x135ED84", VA = "0x135ED84")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x135EE84", Offset = "0x135EE84", VA = "0x135EE84")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x135EFA8", Offset = "0x135EFA8", VA = "0x135EFA8")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x135F0CC", Offset = "0x135F0CC", VA = "0x135F0CC")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x135F1CC", Offset = "0x135F1CC", VA = "0x135F1CC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x135F3FC", Offset = "0x135F3FC", VA = "0x135F3FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x135F62C", Offset = "0x135F62C", VA = "0x135F62C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x92D380", Offset = "0x92D380")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x135F748", Offset = "0x135F748", VA = "0x135F748")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x92D3F0", Offset = "0x92D3F0")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x135F864", Offset = "0x135F864", VA = "0x135F864")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x92D460", Offset = "0x92D460")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x135F980", Offset = "0x135F980", VA = "0x135F980")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x92D4D0", Offset = "0x92D4D0")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x135FAAC", Offset = "0x135FAAC", VA = "0x135FAAC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x92D540", Offset = "0x92D540")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x135FBD8", Offset = "0x135FBD8", VA = "0x135FBD8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x92D5B0", Offset = "0x92D5B0")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000054")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000001")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000133")]
				[Address(RVA = "0x1365608", Offset = "0x1365608", VA = "0x1365608", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x135EC50", Offset = "0x135EC50", VA = "0x135EC50")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000055")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000002")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x1365708", Offset = "0x1365708", VA = "0x1365708", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x135ED50", Offset = "0x135ED50", VA = "0x135ED50")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000056")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000003")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x1365688", Offset = "0x1365688", VA = "0x1365688", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x135EE50", Offset = "0x135EE50", VA = "0x135EE50")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000057")]
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
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x136563C", Offset = "0x136563C", VA = "0x136563C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x135EF60", Offset = "0x135EF60", VA = "0x135EF60")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000058")]
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
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x13656A4", Offset = "0x13656A4", VA = "0x13656A4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x135F084", Offset = "0x135F084", VA = "0x135F084")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000059")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000006")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x136576C", Offset = "0x136576C", VA = "0x136576C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x135F198", Offset = "0x135F198", VA = "0x135F198")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200005A")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200005B")]
		public static class Physics
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1367E94", Offset = "0x1367E94", VA = "0x1367E94")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1367F98", Offset = "0x1367F98", VA = "0x1367F98")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1368030", Offset = "0x1368030", VA = "0x1368030")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x13680C8", Offset = "0x13680C8", VA = "0x13680C8")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x135FCF4", Offset = "0x135FCF4", VA = "0x135FCF4")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x135FDB8", Offset = "0x135FDB8", VA = "0x135FDB8")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x92CBE8", Offset = "0x92CBE8")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x200005D")]
		public enum AnimationType
		{
			[Token(Token = "0x40000AB")]
			None,
			[Token(Token = "0x40000AC")]
			Move,
			[Token(Token = "0x40000AD")]
			LocalMove,
			[Token(Token = "0x40000AE")]
			Rotate,
			[Token(Token = "0x40000AF")]
			LocalRotate,
			[Token(Token = "0x40000B0")]
			Scale,
			[Token(Token = "0x40000B1")]
			Color,
			[Token(Token = "0x40000B2")]
			Fade,
			[Token(Token = "0x40000B3")]
			Text,
			[Token(Token = "0x40000B4")]
			PunchPosition,
			[Token(Token = "0x40000B5")]
			PunchRotation,
			[Token(Token = "0x40000B6")]
			PunchScale,
			[Token(Token = "0x40000B7")]
			ShakePosition,
			[Token(Token = "0x40000B8")]
			ShakeRotation,
			[Token(Token = "0x40000B9")]
			ShakeScale,
			[Token(Token = "0x40000BA")]
			CameraAspect,
			[Token(Token = "0x40000BB")]
			CameraBackgroundColor,
			[Token(Token = "0x40000BC")]
			CameraFieldOfView,
			[Token(Token = "0x40000BD")]
			CameraOrthoSize,
			[Token(Token = "0x40000BE")]
			CameraPixelRect,
			[Token(Token = "0x40000BF")]
			CameraRect,
			[Token(Token = "0x40000C0")]
			UIWidthHeight
		}

		[Token(Token = "0x200005E")]
		public enum TargetType
		{
			[Token(Token = "0x40000C2")]
			Unset,
			[Token(Token = "0x40000C3")]
			Camera,
			[Token(Token = "0x40000C4")]
			CanvasGroup,
			[Token(Token = "0x40000C5")]
			Image,
			[Token(Token = "0x40000C6")]
			Light,
			[Token(Token = "0x40000C7")]
			RectTransform,
			[Token(Token = "0x40000C8")]
			Renderer,
			[Token(Token = "0x40000C9")]
			SpriteRenderer,
			[Token(Token = "0x40000CA")]
			Rigidbody,
			[Token(Token = "0x40000CB")]
			Rigidbody2D,
			[Token(Token = "0x40000CC")]
			Text,
			[Token(Token = "0x40000CD")]
			Transform,
			[Token(Token = "0x40000CE")]
			tk2dBaseSprite,
			[Token(Token = "0x40000CF")]
			tk2dTextMesh,
			[Token(Token = "0x40000D0")]
			TextMeshPro,
			[Token(Token = "0x40000D1")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1352464", Offset = "0x1352464", VA = "0x1352464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D6C0", Offset = "0x92D6C0")]
			add
			{
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1352520", Offset = "0x1352520", VA = "0x1352520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D6D0", Offset = "0x92D6D0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x13525DC", Offset = "0x13525DC", VA = "0x13525DC")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1352658", Offset = "0x1352658", VA = "0x1352658")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1353D98", Offset = "0x1353D98", VA = "0x1353D98")]
		private void Start()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1353DDC", Offset = "0x1353DDC", VA = "0x1353DDC")]
		private void Reset()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1353DE0", Offset = "0x1353DE0", VA = "0x1353DE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x13526A8", Offset = "0x13526A8", VA = "0x13526A8")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x135651C", Offset = "0x135651C", VA = "0x135651C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1356594", Offset = "0x1356594", VA = "0x1356594", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x135660C", Offset = "0x135660C", VA = "0x135660C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1356684", Offset = "0x1356684", VA = "0x1356684", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x13566FC", Offset = "0x13566FC", VA = "0x13566FC", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1356774", Offset = "0x1356774", VA = "0x1356774", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x135686C", Offset = "0x135686C", VA = "0x135686C", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x135687C", Offset = "0x135687C", VA = "0x135687C", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1356BF8", Offset = "0x1356BF8", VA = "0x1356BF8", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1356C74", Offset = "0x1356C74", VA = "0x1356C74", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1356D00", Offset = "0x1356D00", VA = "0x1356D00")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1356D88", Offset = "0x1356D88", VA = "0x1356D88")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1356DEC", Offset = "0x1356DEC", VA = "0x1356DEC")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1356E50", Offset = "0x1356E50", VA = "0x1356E50")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1356ED8", Offset = "0x1356ED8", VA = "0x1356ED8")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1356F3C", Offset = "0x1356F3C", VA = "0x1356F3C")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1356FC4", Offset = "0x1356FC4", VA = "0x1356FC4")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1357028", Offset = "0x1357028", VA = "0x1357028")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1357170", Offset = "0x1357170", VA = "0x1357170")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x13571FC", Offset = "0x13571FC", VA = "0x13571FC")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1357278", Offset = "0x1357278", VA = "0x1357278")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1357310", Offset = "0x1357310", VA = "0x1357310")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1357390", Offset = "0x1357390", VA = "0x1357390")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1353E44", Offset = "0x1353E44", VA = "0x1353E44")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x135749C", Offset = "0x135749C", VA = "0x135749C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1353E2C", Offset = "0x1353E2C", VA = "0x1353E2C")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1356990", Offset = "0x1356990", VA = "0x1356990")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x13574D8", Offset = "0x13574D8", VA = "0x13574D8")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x13576E4", Offset = "0x13576E4", VA = "0x13576E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D6E0", Offset = "0x92D6E0")]
		private void <CreateTween>b__47_0()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x600016A")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000060")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CC40", Offset = "0x92CC40")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x13601E8", Offset = "0x13601E8", VA = "0x13601E8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1368218", Offset = "0x1368218", VA = "0x1368218")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1368234", Offset = "0x1368234", VA = "0x1368234")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CC50", Offset = "0x92CC50")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1360524", Offset = "0x1360524", VA = "0x1360524")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1368250", Offset = "0x1368250", VA = "0x1368250")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x135FE6C", Offset = "0x135FE6C", VA = "0x135FE6C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x135FEB8", Offset = "0x135FEB8", VA = "0x135FEB8")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x13601F0", Offset = "0x13601F0", VA = "0x13601F0")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public enum TMPSkewSpanMode
	{
		[Token(Token = "0x40000D5")]
		Default,
		[Token(Token = "0x40000D6")]
		AsMaxSkewFactor
	}
	[Token(Token = "0x2000064")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CC70", Offset = "0x92CC70")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1364810", Offset = "0x1364810", VA = "0x1364810")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1369C6C", Offset = "0x1369C6C", VA = "0x1369C6C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1369C90", Offset = "0x1369C90", VA = "0x1369C90")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CC80", Offset = "0x92CC80")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1364A00", Offset = "0x1364A00", VA = "0x1364A00")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1369CFC", Offset = "0x1369CFC", VA = "0x1369CFC")]
			internal Color <DOFaceColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1369D28", Offset = "0x1369D28", VA = "0x1369D28")]
			internal void <DOFaceColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CC90", Offset = "0x92CC90")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1364BF0", Offset = "0x1364BF0", VA = "0x1364BF0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1369D60", Offset = "0x1369D60", VA = "0x1369D60")]
			internal Color <DOOutlineColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1369D8C", Offset = "0x1369D8C", VA = "0x1369D8C")]
			internal void <DOOutlineColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CCA0", Offset = "0x92CCA0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1364CEC", Offset = "0x1364CEC", VA = "0x1364CEC")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1369DC4", Offset = "0x1369DC4", VA = "0x1369DC4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1369DE8", Offset = "0x1369DE8", VA = "0x1369DE8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CCB0", Offset = "0x92CCB0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1364E9C", Offset = "0x1364E9C", VA = "0x1364E9C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1369E0C", Offset = "0x1369E0C", VA = "0x1369E0C")]
			internal Color <DOFaceFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1369E38", Offset = "0x1369E38", VA = "0x1369E38")]
			internal void <DOFaceFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CCC0", Offset = "0x92CCC0")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1365060", Offset = "0x1365060", VA = "0x1365060")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1369E70", Offset = "0x1369E70", VA = "0x1369E70")]
			internal Vector3 <DOScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1369E8C", Offset = "0x1369E8C", VA = "0x1369E8C")]
			internal void <DOScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CCD0", Offset = "0x92CCD0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TMP_Text target;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1365290", Offset = "0x1365290", VA = "0x1365290")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1369EA8", Offset = "0x1369EA8", VA = "0x1369EA8")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1369EB0", Offset = "0x1369EB0", VA = "0x1369EB0")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CCE0", Offset = "0x92CCE0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1365440", Offset = "0x1365440", VA = "0x1365440")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1369F4C", Offset = "0x1369F4C", VA = "0x1369F4C")]
			internal float <DOFontSize>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1369F68", Offset = "0x1369F68", VA = "0x1369F68")]
			internal void <DOFontSize>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CCF0", Offset = "0x92CCF0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x13655F8", Offset = "0x13655F8", VA = "0x13655F8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1369F84", Offset = "0x1369F84", VA = "0x1369F84")]
			internal int <DOMaxVisibleCharacters>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1369FA0", Offset = "0x1369FA0", VA = "0x1369FA0")]
			internal void <DOMaxVisibleCharacters>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD00", Offset = "0x92CD00")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TMP_Text target;

			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1365600", Offset = "0x1365600", VA = "0x1365600")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1369CB4", Offset = "0x1369CB4", VA = "0x1369CB4")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x1369CD8", Offset = "0x1369CD8", VA = "0x1369CD8")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x13552F8", Offset = "0x13552F8", VA = "0x13552F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1364818", Offset = "0x1364818", VA = "0x1364818")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1364A08", Offset = "0x1364A08", VA = "0x1364A08")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1364BF8", Offset = "0x1364BF8", VA = "0x1364BF8")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1355B68", Offset = "0x1355B68", VA = "0x1355B68")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1364CF4", Offset = "0x1364CF4", VA = "0x1364CF4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1364EA4", Offset = "0x1364EA4", VA = "0x1364EA4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1365068", Offset = "0x1365068", VA = "0x1365068")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this TMP_Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1365298", Offset = "0x1365298", VA = "0x1365298")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1365448", Offset = "0x1365448", VA = "0x1365448")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1355F64", Offset = "0x1355F64", VA = "0x1355F64")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public class DOTweenTMPAnimator : IDisposable
	{
		[Token(Token = "0x2000070")]
		private struct CharVertices
		{
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 bottomLeft;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 topLeft;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 topRight;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 bottomRight;

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x87D204", Offset = "0x87D204", VA = "0x87D204")]
			public CharVertices(Vector3 bottomLeft, Vector3 topLeft, Vector3 topRight, Vector3 bottomRight)
			{
			}
		}

		[Token(Token = "0x2000071")]
		private struct CharTransform
		{
			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int charIndex;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CDF0", Offset = "0x92CDF0")]
			private bool <isVisible>k__BackingField;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 offset;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion rotation;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 scale;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 _topLeftShift;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 _topRightShift;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 _bottomLeftShift;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 _bottomRightShift;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 _charMidBaselineOffset;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int _matIndex;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _firstVertexIndex;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TMP_MeshInfo _meshInfo;

			[Token(Token = "0x17000009")]
			public bool isVisible
			{
				[Token(Token = "0x60001C5")]
				[Address(RVA = "0x87D0C0", Offset = "0x87D0C0", VA = "0x87D0C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D810", Offset = "0x92D810")]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C6")]
				[Address(RVA = "0x87D0C8", Offset = "0x87D0C8", VA = "0x87D0C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D848", Offset = "0x92D848")]
				private set
				{
				}
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x87D0D4", Offset = "0x87D0D4", VA = "0x87D0D4")]
			public CharTransform(int charIndex, TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x87D0DC", Offset = "0x87D0DC", VA = "0x87D0DC")]
			public void Refresh(TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x87D0E4", Offset = "0x87D0E4", VA = "0x87D0E4")]
			public void ResetAll(TMP_Text target, TMP_MeshInfo[] meshInfos, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x87D128", Offset = "0x87D128", VA = "0x87D128")]
			public void ResetTransformationData()
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x87D130", Offset = "0x87D130", VA = "0x87D130")]
			public void ResetGeometry(TMP_Text target, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x87D138", Offset = "0x87D138", VA = "0x87D138")]
			public void ResetColors(TMP_Text target, TMP_MeshInfo[] meshInfos)
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x87D140", Offset = "0x87D140", VA = "0x87D140")]
			public Color32 GetColor(TMP_MeshInfo[] meshInfos)
			{
				return default(Color32);
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x87D15C", Offset = "0x87D15C", VA = "0x87D15C")]
			public CharVertices GetVertices()
			{
				return default(CharVertices);
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x87D19C", Offset = "0x87D19C", VA = "0x87D19C")]
			public void UpdateAlpha(TMP_Text target, Color alphaColor, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x87D1A8", Offset = "0x87D1A8", VA = "0x87D1A8")]
			public void UpdateColor(TMP_Text target, Color32 color, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x87D1B8", Offset = "0x87D1B8", VA = "0x87D1B8")]
			public void UpdateGeometry(TMP_Text target, Vector3 offset, Quaternion rotation, Vector3 scale, TMP_MeshInfo[] cachedMeshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x87D1D4", Offset = "0x87D1D4", VA = "0x87D1D4")]
			public void ShiftVertices(TMP_Text target, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x87D1FC", Offset = "0x87D1FC", VA = "0x87D1FC")]
			public void ResetVerticesShift(TMP_Text target)
			{
			}
		}

		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD10", Offset = "0x92CD10")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x1363174", Offset = "0x1363174", VA = "0x1363174")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x136826C", Offset = "0x136826C", VA = "0x136826C")]
			internal Color <DOFadeChar>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1368340", Offset = "0x1368340", VA = "0x1368340")]
			internal void <DOFadeChar>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD20", Offset = "0x92CD20")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x136335C", Offset = "0x136335C", VA = "0x136335C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1368530", Offset = "0x1368530", VA = "0x1368530")]
			internal Color <DOColorChar>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1368604", Offset = "0x1368604", VA = "0x1368604")]
			internal void <DOColorChar>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD30", Offset = "0x92CD30")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x1363530", Offset = "0x1363530", VA = "0x1363530")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x136871C", Offset = "0x136871C", VA = "0x136871C")]
			internal Vector3 <DOOffsetChar>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x136879C", Offset = "0x136879C", VA = "0x136879C")]
			internal void <DOOffsetChar>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD40", Offset = "0x92CD40")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1363708", Offset = "0x1363708", VA = "0x1363708")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1368908", Offset = "0x1368908", VA = "0x1368908")]
			internal Quaternion <DORotateChar>b__0()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1368988", Offset = "0x1368988", VA = "0x1368988")]
			internal void <DORotateChar>b__1(Quaternion x)
			{
			}
		}

		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD50", Offset = "0x92CD50")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x13638EC", Offset = "0x13638EC", VA = "0x13638EC")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x1368AFC", Offset = "0x1368AFC", VA = "0x1368AFC")]
			internal Vector3 <DOScaleChar>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x1368B7C", Offset = "0x1368B7C", VA = "0x1368B7C")]
			internal void <DOScaleChar>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD60", Offset = "0x92CD60")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x1363B60", Offset = "0x1363B60", VA = "0x1363B60")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x1368CD8", Offset = "0x1368CD8", VA = "0x1368CD8")]
			internal Vector3 <DOPunchCharOffset>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1368D58", Offset = "0x1368D58", VA = "0x1368D58")]
			internal void <DOPunchCharOffset>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD70", Offset = "0x92CD70")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1363DD4", Offset = "0x1363DD4", VA = "0x1363DD4")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x1368EC4", Offset = "0x1368EC4", VA = "0x1368EC4")]
			internal Vector3 <DOPunchCharRotation>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x1368F70", Offset = "0x1368F70", VA = "0x1368F70")]
			internal void <DOPunchCharRotation>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD80", Offset = "0x92CD80")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x136405C", Offset = "0x136405C", VA = "0x136405C")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1369124", Offset = "0x1369124", VA = "0x1369124")]
			internal Vector3 <DOPunchCharScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x13691A4", Offset = "0x13691A4", VA = "0x13691A4")]
			internal void <DOPunchCharScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CD90", Offset = "0x92CD90")]
		private sealed class <>c__DisplayClass43_0
		{
			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x13642EC", Offset = "0x13642EC", VA = "0x13642EC")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x1369300", Offset = "0x1369300", VA = "0x1369300")]
			internal Vector3 <DOShakeCharOffset>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x1369380", Offset = "0x1369380", VA = "0x1369380")]
			internal void <DOShakeCharOffset>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CDA0", Offset = "0x92CDA0")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1364568", Offset = "0x1364568", VA = "0x1364568")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x13694EC", Offset = "0x13694EC", VA = "0x13694EC")]
			internal Vector3 <DOShakeCharRotation>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1369598", Offset = "0x1369598", VA = "0x1369598")]
			internal void <DOShakeCharRotation>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CDB0", Offset = "0x92CDB0")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DOTweenTMPAnimator <>4__this;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int charIndex;

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x13647F8", Offset = "0x13647F8", VA = "0x13647F8")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x136974C", Offset = "0x136974C", VA = "0x136974C")]
			internal Vector3 <DOShakeCharScale>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x13697CC", Offset = "0x13697CC", VA = "0x13697CC")]
			internal void <DOShakeCharScale>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CDD0", Offset = "0x92CDD0")]
		private TMP_Text <target>k__BackingField;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CDE0", Offset = "0x92CDE0")]
		private TMP_TextInfo <textInfo>k__BackingField;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<CharTransform> _charTransforms;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_MeshInfo[] _cachedMeshInfos;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _ignoreTextChangedEvent;

		[Token(Token = "0x17000007")]
		public TMP_Text target
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x136052C", Offset = "0x136052C", VA = "0x136052C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D7D0", Offset = "0x92D7D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1360534", Offset = "0x1360534", VA = "0x1360534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D7E0", Offset = "0x92D7E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public TMP_TextInfo textInfo
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x136053C", Offset = "0x136053C", VA = "0x136053C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D7F0", Offset = "0x92D7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1360544", Offset = "0x1360544", VA = "0x1360544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92D800", Offset = "0x92D800")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x136054C", Offset = "0x136054C", VA = "0x136054C")]
		public DOTweenTMPAnimator(TMP_Text target)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x136096C", Offset = "0x136096C", VA = "0x136096C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x13606FC", Offset = "0x13606FC", VA = "0x13606FC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1360D00", Offset = "0x1360D00", VA = "0x1360D00")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1360E48", Offset = "0x1360E48", VA = "0x1360E48")]
		private void OnTextChanged(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1360F14", Offset = "0x1360F14", VA = "0x1360F14")]
		private bool ValidateChar(int charIndex, bool isTween = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x13610B8", Offset = "0x13610B8", VA = "0x13610B8")]
		private bool ValidateSpan(int fromCharIndex, int toCharIndex, out int firstVisibleCharIndex, out int lastVisibleCharIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1361220", Offset = "0x1361220", VA = "0x1361220")]
		public void SkewSpanX(int fromCharIndex, int toCharIndex, float skewFactor, bool skewTop = true)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1361608", Offset = "0x1361608", VA = "0x1361608")]
		public void SkewSpanY(int fromCharIndex, int toCharIndex, float skewFactor, TMPSkewSpanMode mode = TMPSkewSpanMode.Default, bool skewRight = true)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1361DAC", Offset = "0x1361DAC", VA = "0x1361DAC")]
		public Color GetCharColor(int charIndex)
		{
			return default(Color);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1361EE4", Offset = "0x1361EE4", VA = "0x1361EE4")]
		public Vector3 GetCharOffset(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1361F80", Offset = "0x1361F80", VA = "0x1361F80")]
		public Vector3 GetCharRotation(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x136204C", Offset = "0x136204C", VA = "0x136204C")]
		public Vector3 GetCharScale(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x13620E8", Offset = "0x13620E8", VA = "0x13620E8")]
		public void SetCharColor(int charIndex, Color32 color)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1361C50", Offset = "0x1361C50", VA = "0x1361C50")]
		public void SetCharOffset(int charIndex, Vector3 offset)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1362708", Offset = "0x1362708", VA = "0x1362708")]
		public void SetCharRotation(int charIndex, Vector3 rotation)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x13628A4", Offset = "0x13628A4", VA = "0x13628A4")]
		public void SetCharScale(int charIndex, Vector3 scale)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x13629F0", Offset = "0x13629F0", VA = "0x13629F0")]
		public void ShiftCharVertices(int charIndex, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1361450", Offset = "0x1361450", VA = "0x1361450")]
		public float SkewCharX(int charIndex, float skewFactor, bool skewTop = true)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1361A48", Offset = "0x1361A48", VA = "0x1361A48")]
		public float SkewCharY(int charIndex, float skewFactor, bool skewRight = true, bool fixedSkew = false)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1362D30", Offset = "0x1362D30", VA = "0x1362D30")]
		public void ResetVerticesShift(int charIndex)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1362FC4", Offset = "0x1362FC4", VA = "0x1362FC4")]
		public TweenerCore<Color, Color, ColorOptions> DOFadeChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x136317C", Offset = "0x136317C", VA = "0x136317C")]
		public TweenerCore<Color, Color, ColorOptions> DOColorChar(int charIndex, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1363364", Offset = "0x1363364", VA = "0x1363364")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOOffsetChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1363538", Offset = "0x1363538", VA = "0x1363538")]
		public TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateChar(int charIndex, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1363710", Offset = "0x1363710", VA = "0x1363710")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1363720", Offset = "0x1363720", VA = "0x1363720")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x13638F4", Offset = "0x13638F4", VA = "0x13638F4")]
		public Tweener DOPunchCharOffset(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1363B68", Offset = "0x1363B68", VA = "0x1363B68")]
		public Tweener DOPunchCharRotation(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1363DDC", Offset = "0x1363DDC", VA = "0x1363DDC")]
		public Tweener DOPunchCharScale(int charIndex, float punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1363DF0", Offset = "0x1363DF0", VA = "0x1363DF0")]
		public Tweener DOPunchCharScale(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1364064", Offset = "0x1364064", VA = "0x1364064")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1364078", Offset = "0x1364078", VA = "0x1364078")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x13642F4", Offset = "0x13642F4", VA = "0x13642F4")]
		public Tweener DOShakeCharRotation(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1364570", Offset = "0x1364570", VA = "0x1364570")]
		public Tweener DOShakeCharScale(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1364584", Offset = "0x1364584", VA = "0x1364584")]
		public Tweener DOShakeCharScale(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}
	}
}
