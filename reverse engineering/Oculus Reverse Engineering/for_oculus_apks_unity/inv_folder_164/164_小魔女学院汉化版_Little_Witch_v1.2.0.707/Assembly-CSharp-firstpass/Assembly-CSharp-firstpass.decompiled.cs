using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using FluffyUnderware.Curvy.Controllers;
using FluffyUnderware.Curvy.Generator;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using FluffyUnderware.DevTools;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE90A0C", Offset = "0xE90A0C")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92A48", Offset = "0xE92A48")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92A5C", Offset = "0xE92A5C")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92A70", Offset = "0xE92A70")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92A84", Offset = "0xE92A84")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x17000001")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <B>j__TPar B
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000003")]
	public <C>j__TPar C
	{
		[Token(Token = "0x6000003")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000004")]
	public <D>j__TPar D
	{
		[Token(Token = "0x6000004")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D)
	{
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE90A1C", Offset = "0xE90A1C")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar, <F>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92A98", Offset = "0xE92A98")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92AAC", Offset = "0xE92AAC")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92AC0", Offset = "0xE92AC0")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92AD4", Offset = "0xE92AD4")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92AE8", Offset = "0xE92AE8")]
	private readonly <E>j__TPar <E>i__Field;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xE92AFC", Offset = "0xE92AFC")]
	private readonly <F>j__TPar <F>i__Field;

	[Token(Token = "0x17000005")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000006")]
	public <B>j__TPar B
	{
		[Token(Token = "0x600000A")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000007")]
	public <C>j__TPar C
	{
		[Token(Token = "0x600000B")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000008")]
	public <D>j__TPar D
	{
		[Token(Token = "0x600000C")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x17000009")]
	public <E>j__TPar E
	{
		[Token(Token = "0x600000D")]
		get
		{
			return (<E>j__TPar)null;
		}
	}

	[Token(Token = "0x1700000A")]
	public <F>j__TPar F
	{
		[Token(Token = "0x600000E")]
		get
		{
			return (<F>j__TPar)null;
		}
	}

	[Token(Token = "0x600000F")]
	[DebuggerHidden]
	public <>f__AnonymousType1(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D, <E>j__TPar E, <F>j__TPar F)
	{
	}

	[Token(Token = "0x6000010")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000012")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE90A2C", Offset = "0xE90A2C")]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x13DA580", Offset = "0x13DA580", VA = "0x13DA580")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE90A64", Offset = "0xE90A64")]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x13DB190", Offset = "0x13DB190", VA = "0x13DB190")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000006")]
public class AnimationHelper : MonoBehaviour
{
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x17F769C", Offset = "0x17F769C", VA = "0x17F769C")]
	public void Play(Animation animation)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x17F76B8", Offset = "0x17F76B8", VA = "0x17F76B8")]
	public void RewindThenPlay(Animation animation)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x17F76F0", Offset = "0x17F76F0", VA = "0x17F76F0")]
	public AnimationHelper()
	{
	}
}
[Token(Token = "0x2000007")]
public class SinusoidalMover : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float MovementAmplitude;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x13DB06C", Offset = "0x13DB06C", VA = "0x13DB06C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x13DB180", Offset = "0x13DB180", VA = "0x13DB180")]
	public SinusoidalMover()
	{
	}
}
[Token(Token = "0x2000008")]
public class ToggleBehaviourByTrigger : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Behaviour UIElement;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x13DB198", Offset = "0x13DB198", VA = "0x13DB198")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x13DB240", Offset = "0x13DB240", VA = "0x13DB240")]
	public ToggleBehaviourByTrigger()
	{
	}
}
[Token(Token = "0x2000009")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x13DA588", Offset = "0x13DA588", VA = "0x13DA588")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x13DAA30", Offset = "0x13DAA30", VA = "0x13DAA30")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x200000A")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x13DAA38", Offset = "0x13DAA38", VA = "0x13DAA38")]
	private void Start()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x13DADA8", Offset = "0x13DADA8", VA = "0x13DADA8")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x200000B")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x13DADB0", Offset = "0x13DADB0", VA = "0x13DADB0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x13DB064", Offset = "0x13DB064", VA = "0x13DB064")]
	public SampleInfo()
	{
	}
}
[Token(Token = "0x200000C")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000130")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000131")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000132")]
	public enum EaseType
	{
		[Token(Token = "0x40004A4")]
		easeInQuad,
		[Token(Token = "0x40004A5")]
		easeOutQuad,
		[Token(Token = "0x40004A6")]
		easeInOutQuad,
		[Token(Token = "0x40004A7")]
		easeInCubic,
		[Token(Token = "0x40004A8")]
		easeOutCubic,
		[Token(Token = "0x40004A9")]
		easeInOutCubic,
		[Token(Token = "0x40004AA")]
		easeInQuart,
		[Token(Token = "0x40004AB")]
		easeOutQuart,
		[Token(Token = "0x40004AC")]
		easeInOutQuart,
		[Token(Token = "0x40004AD")]
		easeInQuint,
		[Token(Token = "0x40004AE")]
		easeOutQuint,
		[Token(Token = "0x40004AF")]
		easeInOutQuint,
		[Token(Token = "0x40004B0")]
		easeInSine,
		[Token(Token = "0x40004B1")]
		easeOutSine,
		[Token(Token = "0x40004B2")]
		easeInOutSine,
		[Token(Token = "0x40004B3")]
		easeInExpo,
		[Token(Token = "0x40004B4")]
		easeOutExpo,
		[Token(Token = "0x40004B5")]
		easeInOutExpo,
		[Token(Token = "0x40004B6")]
		easeInCirc,
		[Token(Token = "0x40004B7")]
		easeOutCirc,
		[Token(Token = "0x40004B8")]
		easeInOutCirc,
		[Token(Token = "0x40004B9")]
		linear,
		[Token(Token = "0x40004BA")]
		spring,
		[Token(Token = "0x40004BB")]
		easeInBounce,
		[Token(Token = "0x40004BC")]
		easeOutBounce,
		[Token(Token = "0x40004BD")]
		easeInOutBounce,
		[Token(Token = "0x40004BE")]
		easeInBack,
		[Token(Token = "0x40004BF")]
		easeOutBack,
		[Token(Token = "0x40004C0")]
		easeInOutBack,
		[Token(Token = "0x40004C1")]
		easeInElastic,
		[Token(Token = "0x40004C2")]
		easeOutElastic,
		[Token(Token = "0x40004C3")]
		easeInOutElastic,
		[Token(Token = "0x40004C4")]
		punch
	}

	[Token(Token = "0x2000133")]
	public enum LoopType
	{
		[Token(Token = "0x40004C6")]
		none,
		[Token(Token = "0x40004C7")]
		loop,
		[Token(Token = "0x40004C8")]
		pingPong
	}

	[Token(Token = "0x2000134")]
	public enum NamedValueColor
	{
		[Token(Token = "0x40004CA")]
		_Color,
		[Token(Token = "0x40004CB")]
		_SpecColor,
		[Token(Token = "0x40004CC")]
		_Emission,
		[Token(Token = "0x40004CD")]
		_ReflectColor
	}

	[Token(Token = "0x2000135")]
	public static class Defaults
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000136")]
	private class CRSpline
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x2BD9EF4", Offset = "0x2BD9EF4", VA = "0x2BD9EF4")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x2BD9F7C", Offset = "0x2BD9F7C", VA = "0x2BD9F7C")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92918", Offset = "0xE92918")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000251")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x2BD9AB4", Offset = "0x2BD9AB4", VA = "0x2BD9AB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000252")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x2BD9B1C", Offset = "0x2BD9B1C", VA = "0x2BD9B1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x2BD99B0", Offset = "0x2BD99B0", VA = "0x2BD99B0")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x2BD99DC", Offset = "0x2BD99DC", VA = "0x2BD99DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x2BD99E0", Offset = "0x2BD99E0", VA = "0x2BD99E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x2BD9ABC", Offset = "0x2BD9ABC", VA = "0x2BD9ABC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92928", Offset = "0xE92928")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000253")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x2BD9C30", Offset = "0x2BD9C30", VA = "0x2BD9C30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000254")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x2BD9C98", Offset = "0x2BD9C98", VA = "0x2BD9C98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2BD9B24", Offset = "0x2BD9B24", VA = "0x2BD9B24")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x2BD9B50", Offset = "0x2BD9B50", VA = "0x2BD9B50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x2BD9B54", Offset = "0x2BD9B54", VA = "0x2BD9B54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x2BD9C38", Offset = "0x2BD9C38", VA = "0x2BD9C38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92938", Offset = "0xE92938")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000255")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x2BD9940", Offset = "0x2BD9940", VA = "0x2BD9940", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000256")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x2BD99A8", Offset = "0x2BD99A8", VA = "0x2BD99A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x2BD9864", Offset = "0x2BD9864", VA = "0x2BD9864")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x2BD9890", Offset = "0x2BD9890", VA = "0x2BD9890", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x2BD9894", Offset = "0x2BD9894", VA = "0x2BD9894", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x2BD9948", Offset = "0x2BD9948", VA = "0x2BD9948", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x13DCCC0", Offset = "0x13DCCC0", VA = "0x13DCCC0")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x13DCF44", Offset = "0x13DCF44", VA = "0x13DCF44")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x13DDF0C", Offset = "0x13DDF0C", VA = "0x13DDF0C")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x13DE0BC", Offset = "0x13DE0BC", VA = "0x13DE0BC")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x13DEB20", Offset = "0x13DEB20", VA = "0x13DEB20")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x13DECD0", Offset = "0x13DECD0", VA = "0x13DECD0")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x13DF240", Offset = "0x13DF240", VA = "0x13DF240")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x13DE130", Offset = "0x13DE130", VA = "0x13DE130")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x13DF41C", Offset = "0x13DF41C", VA = "0x13DF41C")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x13DED44", Offset = "0x13DED44", VA = "0x13DED44")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x13DF5F8", Offset = "0x13DF5F8", VA = "0x13DF5F8")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x13DF824", Offset = "0x13DF824", VA = "0x13DF824")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x13DFC2C", Offset = "0x13DFC2C", VA = "0x13DFC2C")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x13DFE58", Offset = "0x13DFE58", VA = "0x13DFE58")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x13DFFB4", Offset = "0x13DFFB4", VA = "0x13DFFB4")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x13E0148", Offset = "0x13E0148", VA = "0x13E0148")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13E01F8", Offset = "0x13E01F8", VA = "0x13E01F8")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x13E03C4", Offset = "0x13E03C4", VA = "0x13E03C4")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x13E0A24", Offset = "0x13E0A24", VA = "0x13E0A24")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x13E0BF0", Offset = "0x13E0BF0", VA = "0x13E0BF0")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x13E0F10", Offset = "0x13E0F10", VA = "0x13E0F10")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x13E10DC", Offset = "0x13E10DC", VA = "0x13E10DC")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x13E147C", Offset = "0x13E147C", VA = "0x13E147C")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x13E1648", Offset = "0x13E1648", VA = "0x13E1648")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x13E1F48", Offset = "0x13E1F48", VA = "0x13E1F48")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x13E2114", Offset = "0x13E2114", VA = "0x13E2114")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x13DCD78", Offset = "0x13DCD78", VA = "0x13DCD78")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x13DA954", Offset = "0x13DA954", VA = "0x13DA954")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13E21F0", Offset = "0x13E21F0", VA = "0x13E21F0")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13E23BC", Offset = "0x13E23BC", VA = "0x13E23BC")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13E2754", Offset = "0x13E2754", VA = "0x13E2754")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13E2920", Offset = "0x13E2920", VA = "0x13E2920")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13E2DCC", Offset = "0x13E2DCC", VA = "0x13E2DCC")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x13E2F98", Offset = "0x13E2F98", VA = "0x13E2F98")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x13E3074", Offset = "0x13E3074", VA = "0x13E3074")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x13E3240", Offset = "0x13E3240", VA = "0x13E3240")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x13E331C", Offset = "0x13E331C", VA = "0x13E331C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x13E34E8", Offset = "0x13E34E8", VA = "0x13E34E8")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x13E3888", Offset = "0x13E3888", VA = "0x13E3888")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x13E3A54", Offset = "0x13E3A54", VA = "0x13E3A54")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x13E3FB8", Offset = "0x13E3FB8", VA = "0x13E3FB8")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x13E4184", Offset = "0x13E4184", VA = "0x13E4184")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13E4260", Offset = "0x13E4260", VA = "0x13E4260")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x13DACCC", Offset = "0x13DACCC", VA = "0x13DACCC")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x13E442C", Offset = "0x13E442C", VA = "0x13E442C")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x13E45F8", Offset = "0x13E45F8", VA = "0x13E45F8")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x13E46D4", Offset = "0x13E46D4", VA = "0x13E46D4")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x13E48A0", Offset = "0x13E48A0", VA = "0x13E48A0")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x13E497C", Offset = "0x13E497C", VA = "0x13E497C")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x13E4B48", Offset = "0x13E4B48", VA = "0x13E4B48")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x13E4C24", Offset = "0x13E4C24", VA = "0x13E4C24")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x13E4DF0", Offset = "0x13E4DF0", VA = "0x13E4DF0")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13E4F10", Offset = "0x13E4F10", VA = "0x13E4F10")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13E50DC", Offset = "0x13E50DC", VA = "0x13E50DC")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13E51FC", Offset = "0x13E51FC", VA = "0x13E51FC")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13E53C8", Offset = "0x13E53C8", VA = "0x13E53C8")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13E54E8", Offset = "0x13E54E8", VA = "0x13E54E8")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13E6568", Offset = "0x13E6568", VA = "0x13E6568")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x13E63FC", Offset = "0x13E63FC", VA = "0x13E63FC")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x13E619C", Offset = "0x13E619C", VA = "0x13E619C")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13E5F08", Offset = "0x13E5F08", VA = "0x13E5F08")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x13E5D14", Offset = "0x13E5D14", VA = "0x13E5D14")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x13E66A4", Offset = "0x13E66A4", VA = "0x13E66A4")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x13E6FFC", Offset = "0x13E6FFC", VA = "0x13E6FFC")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x13EBDA0", Offset = "0x13EBDA0", VA = "0x13EBDA0")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x13EB574", Offset = "0x13EB574", VA = "0x13EB574")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x13E7308", Offset = "0x13E7308", VA = "0x13E7308")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x13E7A38", Offset = "0x13E7A38", VA = "0x13E7A38")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x13E8084", Offset = "0x13E8084", VA = "0x13E8084")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x13E8680", Offset = "0x13E8680", VA = "0x13E8680")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x13E8BD0", Offset = "0x13E8BD0", VA = "0x13E8BD0")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x13E9024", Offset = "0x13E9024", VA = "0x13E9024")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x13E946C", Offset = "0x13E946C", VA = "0x13E946C")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x13E9A9C", Offset = "0x13E9A9C", VA = "0x13E9A9C")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x13E9EEC", Offset = "0x13E9EEC", VA = "0x13E9EEC")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x13EA3A8", Offset = "0x13EA3A8", VA = "0x13EA3A8")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x13EA69C", Offset = "0x13EA69C", VA = "0x13EA69C")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x13EA964", Offset = "0x13EA964", VA = "0x13EA964")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x13EAC2C", Offset = "0x13EAC2C", VA = "0x13EAC2C")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x13EAF64", Offset = "0x13EAF64", VA = "0x13EAF64")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x13EB270", Offset = "0x13EB270", VA = "0x13EB270")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x13EC4A4", Offset = "0x13EC4A4", VA = "0x13EC4A4")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x13EC7A4", Offset = "0x13EC7A4", VA = "0x13EC7A4")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x13EC9D4", Offset = "0x13EC9D4", VA = "0x13EC9D4")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x13ECBC8", Offset = "0x13ECBC8", VA = "0x13ECBC8")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x13ECD68", Offset = "0x13ECD68", VA = "0x13ECD68")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x13ECEC0", Offset = "0x13ECEC0", VA = "0x13ECEC0")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x13ED420", Offset = "0x13ED420", VA = "0x13ED420")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x13ED58C", Offset = "0x13ED58C", VA = "0x13ED58C")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x13ED590", Offset = "0x13ED590", VA = "0x13ED590")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x13ED8F0", Offset = "0x13ED8F0", VA = "0x13ED8F0")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x13EDAFC", Offset = "0x13EDAFC", VA = "0x13EDAFC")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x13EDE3C", Offset = "0x13EDE3C", VA = "0x13EDE3C")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x13EDFA4", Offset = "0x13EDFA4", VA = "0x13EDFA4")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x13EE17C", Offset = "0x13EE17C", VA = "0x13EE17C")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x13EE4AC", Offset = "0x13EE4AC", VA = "0x13EE4AC")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x13EE740", Offset = "0x13EE740", VA = "0x13EE740")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x13EEB58", Offset = "0x13EEB58", VA = "0x13EEB58")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x13EED6C", Offset = "0x13EED6C", VA = "0x13EED6C")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x13EEFDC", Offset = "0x13EEFDC", VA = "0x13EEFDC")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x13EF490", Offset = "0x13EF490", VA = "0x13EF490")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x13EF7D8", Offset = "0x13EF7D8", VA = "0x13EF7D8")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x13EFA38", Offset = "0x13EFA38", VA = "0x13EFA38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE9D140", Offset = "0xE9D140")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x13EFAA8", Offset = "0x13EFAA8", VA = "0x13EFAA8")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x13F0444", Offset = "0x13F0444", VA = "0x13F0444")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE9D1A4", Offset = "0xE9D1A4")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x13F04B4", Offset = "0x13F04B4", VA = "0x13F04B4")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x13F0598", Offset = "0x13F0598", VA = "0x13F0598")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x13F0668", Offset = "0x13F0668", VA = "0x13F0668")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x13F070C", Offset = "0x13F070C", VA = "0x13F070C")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x13F08D4", Offset = "0x13F08D4", VA = "0x13F08D4")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x13F09E0", Offset = "0x13F09E0", VA = "0x13F09E0")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x13F0894", Offset = "0x13F0894", VA = "0x13F0894")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x13F0AC4", Offset = "0x13F0AC4", VA = "0x13F0AC4")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x13F1550", Offset = "0x13F1550", VA = "0x13F1550")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x13F0B84", Offset = "0x13F0B84", VA = "0x13F0B84")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x13F1700", Offset = "0x13F1700", VA = "0x13F1700")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x13F18DC", Offset = "0x13F18DC", VA = "0x13F18DC")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x13F1D8C", Offset = "0x13F1D8C", VA = "0x13F1D8C")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x13F1FB8", Offset = "0x13F1FB8", VA = "0x13F1FB8")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x13F25E0", Offset = "0x13F25E0", VA = "0x13F25E0")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x13F27AC", Offset = "0x13F27AC", VA = "0x13F27AC")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x13F2D94", Offset = "0x13F2D94", VA = "0x13F2D94")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x13F2F60", Offset = "0x13F2F60", VA = "0x13F2F60")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x13F40D0", Offset = "0x13F40D0", VA = "0x13F40D0")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x13F37C4", Offset = "0x13F37C4", VA = "0x13F37C4")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x13F429C", Offset = "0x13F429C", VA = "0x13F429C")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x13F4468", Offset = "0x13F4468", VA = "0x13F4468")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x13EC32C", Offset = "0x13EC32C", VA = "0x13EC32C")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x13F4D4C", Offset = "0x13F4D4C", VA = "0x13F4D4C")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x13F4DFC", Offset = "0x13F4DFC", VA = "0x13F4DFC")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x13F4E94", Offset = "0x13F4E94", VA = "0x13F4E94")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x13F4FCC", Offset = "0x13F4FCC", VA = "0x13F4FCC")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x13F50EC", Offset = "0x13F50EC", VA = "0x13F50EC")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x13F51F8", Offset = "0x13F51F8", VA = "0x13F51F8")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x13F545C", Offset = "0x13F545C", VA = "0x13F545C")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x13F5520", Offset = "0x13F5520", VA = "0x13F5520")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x13F5694", Offset = "0x13F5694", VA = "0x13F5694")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x13F57E8", Offset = "0x13F57E8", VA = "0x13F57E8")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x13F58CC", Offset = "0x13F58CC", VA = "0x13F58CC")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x13F5990", Offset = "0x13F5990", VA = "0x13F5990")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x13F5B04", Offset = "0x13F5B04", VA = "0x13F5B04")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x13F5C58", Offset = "0x13F5C58", VA = "0x13F5C58")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x13F5D3C", Offset = "0x13F5D3C", VA = "0x13F5D3C")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x13F5E00", Offset = "0x13F5E00", VA = "0x13F5E00")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x13F5F74", Offset = "0x13F5F74", VA = "0x13F5F74")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x13F60C8", Offset = "0x13F60C8", VA = "0x13F60C8")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x13F6140", Offset = "0x13F6140", VA = "0x13F6140")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x13F6418", Offset = "0x13F6418", VA = "0x13F6418")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x13F64DC", Offset = "0x13F64DC", VA = "0x13F64DC")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x13F6650", Offset = "0x13F6650", VA = "0x13F6650")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x13F67A4", Offset = "0x13F67A4", VA = "0x13F67A4")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x13F6888", Offset = "0x13F6888", VA = "0x13F6888")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x13F694C", Offset = "0x13F694C", VA = "0x13F694C")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x13F6AC0", Offset = "0x13F6AC0", VA = "0x13F6AC0")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x13F6C14", Offset = "0x13F6C14", VA = "0x13F6C14")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x13F6CF8", Offset = "0x13F6CF8", VA = "0x13F6CF8")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x13F6DBC", Offset = "0x13F6DBC", VA = "0x13F6DBC")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x13F6F30", Offset = "0x13F6F30", VA = "0x13F6F30")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x13F7084", Offset = "0x13F7084", VA = "0x13F7084")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x13F7174", Offset = "0x13F7174", VA = "0x13F7174")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x13F7430", Offset = "0x13F7430", VA = "0x13F7430")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x13F7588", Offset = "0x13F7588", VA = "0x13F7588")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x13F7934", Offset = "0x13F7934", VA = "0x13F7934")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x13F7A54", Offset = "0x13F7A54", VA = "0x13F7A54")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x13F7C84", Offset = "0x13F7C84", VA = "0x13F7C84")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x13F7DD0", Offset = "0x13F7DD0", VA = "0x13F7DD0")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x13F808C", Offset = "0x13F808C", VA = "0x13F808C")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x13F8238", Offset = "0x13F8238", VA = "0x13F8238")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x13F8638", Offset = "0x13F8638", VA = "0x13F8638")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x13F8758", Offset = "0x13F8758", VA = "0x13F8758")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x13F8988", Offset = "0x13F8988", VA = "0x13F8988")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x13F89FC", Offset = "0x13F89FC", VA = "0x13F89FC")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x13F8BD8", Offset = "0x13F8BD8", VA = "0x13F8BD8")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x13F8C3C", Offset = "0x13F8C3C", VA = "0x13F8C3C")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x13F8D98", Offset = "0x13F8D98", VA = "0x13F8D98")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x13F8FD0", Offset = "0x13F8FD0", VA = "0x13F8FD0")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x13F9350", Offset = "0x13F9350", VA = "0x13F9350")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x13F8EE8", Offset = "0x13F8EE8", VA = "0x13F8EE8")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x13F9690", Offset = "0x13F9690", VA = "0x13F9690")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x13F9200", Offset = "0x13F9200", VA = "0x13F9200")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x13F9580", Offset = "0x13F9580", VA = "0x13F9580")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x13F994C", Offset = "0x13F994C", VA = "0x13F994C")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x13F9CF0", Offset = "0x13F9CF0", VA = "0x13F9CF0")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x13DA824", Offset = "0x13DA824", VA = "0x13DA824")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x13FA054", Offset = "0x13FA054", VA = "0x13FA054")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x13FA080", Offset = "0x13FA080", VA = "0x13FA080")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x13FB0EC", Offset = "0x13FB0EC", VA = "0x13FB0EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE9D208", Offset = "0xE9D208")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x13FB15C", Offset = "0x13FB15C", VA = "0x13FB15C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x13FB19C", Offset = "0x13FB19C", VA = "0x13FB19C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x13FB1DC", Offset = "0x13FB1DC", VA = "0x13FB1DC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x13FB2F0", Offset = "0x13FB2F0", VA = "0x13FB2F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x13FB36C", Offset = "0x13FB36C", VA = "0x13FB36C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x13F52DC", Offset = "0x13F52DC", VA = "0x13F52DC")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x13F6224", Offset = "0x13F6224", VA = "0x13F6224")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x13F465C", Offset = "0x13F465C", VA = "0x13F465C")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x13F4920", Offset = "0x13F4920", VA = "0x13F4920")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x13DDDB8", Offset = "0x13DDDB8", VA = "0x13DDDB8")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x13DD420", Offset = "0x13DD420", VA = "0x13DD420")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x13FB370", Offset = "0x13FB370", VA = "0x13FB370")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x13FA0BC", Offset = "0x13FA0BC", VA = "0x13FA0BC")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x13FB3F0", Offset = "0x13FB3F0", VA = "0x13FB3F0")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x13F0520", Offset = "0x13F0520", VA = "0x13F0520")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x13EFC20", Offset = "0x13EFC20", VA = "0x13EFC20")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x13EC0BC", Offset = "0x13EC0BC", VA = "0x13EC0BC")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x13EFEF8", Offset = "0x13EFEF8", VA = "0x13EFEF8")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x13F0440", Offset = "0x13F0440", VA = "0x13F0440")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x13F0708", Offset = "0x13F0708", VA = "0x13F0708")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x13FB318", Offset = "0x13FB318", VA = "0x13FB318")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x13FB7E4", Offset = "0x13FB7E4", VA = "0x13FB7E4")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x13EC258", Offset = "0x13EC258", VA = "0x13EC258")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x13FB86C", Offset = "0x13FB86C", VA = "0x13FB86C")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x13FB970", Offset = "0x13FB970", VA = "0x13FB970")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x13FB984", Offset = "0x13FB984", VA = "0x13FB984")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x13FB9A0", Offset = "0x13FB9A0", VA = "0x13FB9A0")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x13FB9F4", Offset = "0x13FB9F4", VA = "0x13FB9F4")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x13FBA0C", Offset = "0x13FBA0C", VA = "0x13FBA0C")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x13FBA34", Offset = "0x13FBA34", VA = "0x13FBA34")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x13FBA8C", Offset = "0x13FBA8C", VA = "0x13FBA8C")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x13FBAA8", Offset = "0x13FBAA8", VA = "0x13FBAA8")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x13FBAD0", Offset = "0x13FBAD0", VA = "0x13FBAD0")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x13FBB2C", Offset = "0x13FBB2C", VA = "0x13FBB2C")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x13FBB4C", Offset = "0x13FBB4C", VA = "0x13FBB4C")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x13FBB7C", Offset = "0x13FBB7C", VA = "0x13FBB7C")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x13FBBE4", Offset = "0x13FBBE4", VA = "0x13FBBE4")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x13FBC7C", Offset = "0x13FBC7C", VA = "0x13FBC7C")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x13FBD10", Offset = "0x13FBD10", VA = "0x13FBD10")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x13FBDB4", Offset = "0x13FBDB4", VA = "0x13FBDB4")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x13FBE4C", Offset = "0x13FBE4C", VA = "0x13FBE4C")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x13FBEE4", Offset = "0x13FBEE4", VA = "0x13FBEE4")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x13FBFD4", Offset = "0x13FBFD4", VA = "0x13FBFD4")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x13FC080", Offset = "0x13FC080", VA = "0x13FC080")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x13FC12C", Offset = "0x13FC12C", VA = "0x13FC12C")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x13FC224", Offset = "0x13FC224", VA = "0x13FC224")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x13FC260", Offset = "0x13FC260", VA = "0x13FC260")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x13FC32C", Offset = "0x13FC32C", VA = "0x13FC32C")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x13FC3B0", Offset = "0x13FC3B0", VA = "0x13FC3B0")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x13FC3E0", Offset = "0x13FC3E0", VA = "0x13FC3E0")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x13FC420", Offset = "0x13FC420", VA = "0x13FC420")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x13EF3D0", Offset = "0x13EF3D0", VA = "0x13EF3D0")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x13FC4A4", Offset = "0x13FC4A4", VA = "0x13FC4A4")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x13FC58C", Offset = "0x13FC58C", VA = "0x13FC58C")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x13FC670", Offset = "0x13FC670", VA = "0x13FC670")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
namespace XcaliburGames.MFO
{
	[Token(Token = "0x200000D")]
	public class Combine : MonoBehaviour
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject go;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isDelEmptyGO;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isSaveHierarchy;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x13DB248", Offset = "0x13DB248", VA = "0x13DB248")]
		public Combine()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class MFOArrayOfArray : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public class MFOArray
		{
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] array;

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x13DB260", Offset = "0x13DB260", VA = "0x13DB260")]
			public MFOArray()
			{
			}
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MFOArray[] array;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x13DB258", Offset = "0x13DB258", VA = "0x13DB258")]
		public MFOArrayOfArray()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class Optimization : MonoBehaviour
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> cameras;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GameObject> camerasNotProcessed;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MFOArrayOfArray trisToDel;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject go;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Mesh originalMesh;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Mesh optimizedMesh;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int textureSize;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x13DB268", Offset = "0x13DB268", VA = "0x13DB268")]
		public Optimization()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class TriTriOverlap
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x13DB278", Offset = "0x13DB278", VA = "0x13DB278")]
		private static void Sort(ref Vector2 v)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x13DB28C", Offset = "0x13DB28C", VA = "0x13DB28C")]
		private static bool EdgeEdgeTest(Vector3 v0, Vector3 v1, Vector3 u0, Vector3 u1, int i0, int i1)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x13DB478", Offset = "0x13DB478", VA = "0x13DB478")]
		private static bool EdgeAgainstTriEdges(Vector3 v0, Vector3 v1, Vector3 u0, Vector3 u1, Vector3 u2, short i0, short i1)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x13DB5D8", Offset = "0x13DB5D8", VA = "0x13DB5D8")]
		private static bool PointInTri(Vector3 v0, Vector3 u0, Vector3 u1, Vector3 u2, short i0, short i1)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x13DB8B4", Offset = "0x13DB8B4", VA = "0x13DB8B4")]
		private static bool TriTriCoplanar(Vector3 N, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 u0, Vector3 u1, Vector3 u2)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x13DBB8C", Offset = "0x13DBB8C", VA = "0x13DBB8C")]
		private static bool ComputeIntervals(float VV0, float VV1, float VV2, float D0, float D1, float D2, float D0D1, float D0D2, ref float A, ref float B, ref float C, ref float X0, ref float X1)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x13DBC54", Offset = "0x13DBC54", VA = "0x13DBC54")]
		public static bool TriTriIntersect(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 u0, Vector3 u1, Vector3 u2)
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x13DC4D4", Offset = "0x13DC4D4", VA = "0x13DC4D4")]
		public static bool TriTriIntersect(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 u0, Vector3 u1, Vector3 u2, Vector3 e1, Vector3 e2, Vector3 n1, float d1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000011")]
	public class YSlice : MonoBehaviour
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject go;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mesh originalMesh;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mesh optimizedMesh;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cutYPos;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Material[] matOriginal;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material[] matOptimized;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x13DCCB8", Offset = "0x13DCCB8", VA = "0x13DCCB8")]
		public YSlice()
		{
		}
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x2000012")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x1700000B")]
		string Path
		{
			[Token(Token = "0x6000121")]
			get;
		}
	}
	[Token(Token = "0x2000013")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x2000014")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x2000015")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE90A9C", Offset = "0xE90A9C")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x13D1D88", Offset = "0x13D1D88", VA = "0x13D1D88")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE90AD0", Offset = "0xE90AD0")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B10", Offset = "0xE92B10")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x1700000C")]
		public int TypeSort
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x13CC4E0", Offset = "0x13CC4E0", VA = "0x13CC4E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D26C", Offset = "0xE9D26C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x13CC4E8", Offset = "0x13CC4E8", VA = "0x13CC4E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D27C", Offset = "0xE9D27C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x13CC4F0", Offset = "0x13CC4F0", VA = "0x13CC4F0", Slot = "8")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x13C9FF0", Offset = "0x13C9FF0", VA = "0x13C9FF0")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B20", Offset = "0xE92B20")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x1700000D")]
		public string Path
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x13D6778", Offset = "0x13D6778", VA = "0x13D6778", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x13D6780", Offset = "0x13D6780", VA = "0x13D6780")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x13D6848", Offset = "0x13D6848", VA = "0x13D6848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D28C", Offset = "0xE9D28C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x13D6850", Offset = "0x13D6850", VA = "0x13D6850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D29C", Offset = "0xE9D29C")]
			private set
			{
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x13CA374", Offset = "0x13CA374", VA = "0x13CA374")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x200013B")]
		public enum ActionEnum
		{
			[Token(Token = "0x40004E9")]
			Show,
			[Token(Token = "0x40004EA")]
			Hide,
			[Token(Token = "0x40004EB")]
			Enable,
			[Token(Token = "0x40004EC")]
			Disable,
			[Token(Token = "0x40004ED")]
			ShowInfo,
			[Token(Token = "0x40004EE")]
			ShowWarning,
			[Token(Token = "0x40004EF")]
			ShowError,
			[Token(Token = "0x40004F0")]
			Callback
		}

		[Token(Token = "0x200013C")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x40004F2")]
			Above,
			[Token(Token = "0x40004F3")]
			Below
		}

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x13C9F94", Offset = "0x13C9F94", VA = "0x13C9F94")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x13CA038", Offset = "0x13CA038", VA = "0x13CA038")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x200013D")]
		public enum OperatorEnum
		{
			[Token(Token = "0x40004F5")]
			AND,
			[Token(Token = "0x40004F6")]
			OR
		}

		[Token(Token = "0x200013E")]
		public class Condition
		{
			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x13CBC00", Offset = "0x13CBC00", VA = "0x13CBC00")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x13CBAE0", Offset = "0x13CBAE0", VA = "0x13CBAE0")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x13CBC08", Offset = "0x13CBC08", VA = "0x13CBC08")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x13CBDA4", Offset = "0x13CBDA4", VA = "0x13CBDA4")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x13CBF98", Offset = "0x13CBF98", VA = "0x13CBF98")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x13CC0A0", Offset = "0x13CC0A0", VA = "0x13CC0A0", Slot = "9")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x13CC16C", Offset = "0x13CC16C", VA = "0x13CC16C")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001B")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x13D933C", Offset = "0x13D933C", VA = "0x13D933C")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x13CA31C", Offset = "0x13CA31C", VA = "0x13CA31C")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x13D9374", Offset = "0x13D9374", VA = "0x13D9374")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x13D942C", Offset = "0x13D942C", VA = "0x13D942C")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001E")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x13D7034", Offset = "0x13D7034", VA = "0x13D7034")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x13D6F98", Offset = "0x13D6F98", VA = "0x13D6F98")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x13D6894", Offset = "0x13D6894", VA = "0x13D6894")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x13D68CC", Offset = "0x13D68CC", VA = "0x13D68CC")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x13CA2D4", Offset = "0x13CA2D4", VA = "0x13CA2D4")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x13D6008", Offset = "0x13D6008", VA = "0x13D6008")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x13D671C", Offset = "0x13D671C", VA = "0x13D671C")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x13D6064", Offset = "0x13D6064", VA = "0x13D6064")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x13D60A4", Offset = "0x13D60A4", VA = "0x13D60A4")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x13D60B0", Offset = "0x13D60B0", VA = "0x13D60B0")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x13D60D0", Offset = "0x13D60D0", VA = "0x13D60D0")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x13D685C", Offset = "0x13D685C", VA = "0x13D685C")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x13D6864", Offset = "0x13D6864", VA = "0x13D6864")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x13D6870", Offset = "0x13D6870", VA = "0x13D6870")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x13D6890", Offset = "0x13D6890", VA = "0x13D6890")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B30", Offset = "0xE92B30")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B40", Offset = "0xE92B40")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700000F")]
		public T1 First
		{
			[Token(Token = "0x6000147")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D2AC", Offset = "0xE9D2AC")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x6000148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D2BC", Offset = "0xE9D2BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public T2 Second
		{
			[Token(Token = "0x6000149")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D2CC", Offset = "0xE9D2CC")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x600014A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D2DC", Offset = "0xE9D2DC")]
			set
			{
			}
		}

		[Token(Token = "0x600014B")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class DTTween
	{
		[Token(Token = "0x200013F")]
		public enum EasingMethod
		{
			[Token(Token = "0x4000500")]
			Linear,
			[Token(Token = "0x4000501")]
			ExponentialIn,
			[Token(Token = "0x4000502")]
			ExponentialOut,
			[Token(Token = "0x4000503")]
			ExponentialInOut,
			[Token(Token = "0x4000504")]
			ExponentialOutIn,
			[Token(Token = "0x4000505")]
			CircularIn,
			[Token(Token = "0x4000506")]
			CircularOut,
			[Token(Token = "0x4000507")]
			CircularInOut,
			[Token(Token = "0x4000508")]
			CircularOutIn,
			[Token(Token = "0x4000509")]
			QuadraticIn,
			[Token(Token = "0x400050A")]
			QuadraticOut,
			[Token(Token = "0x400050B")]
			QuadraticInOut,
			[Token(Token = "0x400050C")]
			QuadraticOutIn,
			[Token(Token = "0x400050D")]
			SinusIn,
			[Token(Token = "0x400050E")]
			SinusOut,
			[Token(Token = "0x400050F")]
			SinusInOut,
			[Token(Token = "0x4000510")]
			SinusOutIn,
			[Token(Token = "0x4000511")]
			CubicIn,
			[Token(Token = "0x4000512")]
			CubicOut,
			[Token(Token = "0x4000513")]
			CubicInOut,
			[Token(Token = "0x4000514")]
			CubicOutIn,
			[Token(Token = "0x4000515")]
			QuarticIn,
			[Token(Token = "0x4000516")]
			QuarticOut,
			[Token(Token = "0x4000517")]
			QuarticInOut,
			[Token(Token = "0x4000518")]
			QuarticOutIn,
			[Token(Token = "0x4000519")]
			QuinticIn,
			[Token(Token = "0x400051A")]
			QuinticOut,
			[Token(Token = "0x400051B")]
			QuinticInOut,
			[Token(Token = "0x400051C")]
			QuinticOutIn
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x13CF1E8", Offset = "0x13CF1E8", VA = "0x13CF1E8")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x13D0864", Offset = "0x13D0864", VA = "0x13D0864")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x13D07D8", Offset = "0x13D07D8", VA = "0x13D07D8")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x13D1710", Offset = "0x13D1710", VA = "0x13D1710")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x13CF344", Offset = "0x13CF344", VA = "0x13CF344")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x13D0BA0", Offset = "0x13D0BA0", VA = "0x13D0BA0")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x13CF27C", Offset = "0x13CF27C", VA = "0x13CF27C")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x13D0AF8", Offset = "0x13D0AF8", VA = "0x13D0AF8")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x13CF408", Offset = "0x13CF408", VA = "0x13CF408")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x13D0C44", Offset = "0x13D0C44", VA = "0x13D0C44")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x13CF534", Offset = "0x13CF534", VA = "0x13CF534")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x13D0D58", Offset = "0x13D0D58", VA = "0x13D0D58")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x13CF6A8", Offset = "0x13CF6A8", VA = "0x13CF6A8")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x13D0E34", Offset = "0x13D0E34", VA = "0x13D0E34")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x13CF5F4", Offset = "0x13CF5F4", VA = "0x13CF5F4")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x13D0D84", Offset = "0x13D0D84", VA = "0x13D0D84")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x13CF75C", Offset = "0x13CF75C", VA = "0x13CF75C")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x13D0EE4", Offset = "0x13D0EE4", VA = "0x13D0EE4")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x13CF874", Offset = "0x13CF874", VA = "0x13CF874")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x13D0FE0", Offset = "0x13D0FE0", VA = "0x13D0FE0")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x13CF9C4", Offset = "0x13CF9C4", VA = "0x13CF9C4")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x13D1020", Offset = "0x13D1020", VA = "0x13D1020")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x13CF934", Offset = "0x13CF934", VA = "0x13CF934")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x13D100C", Offset = "0x13D100C", VA = "0x13D100C")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x13CFA5C", Offset = "0x13CFA5C", VA = "0x13CFA5C")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x13D103C", Offset = "0x13D103C", VA = "0x13D103C")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x13CFB74", Offset = "0x13CFB74", VA = "0x13CFB74")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x13D1138", Offset = "0x13D1138", VA = "0x13D1138")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x13CFCD4", Offset = "0x13CFCD4", VA = "0x13CFCD4")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x13D1228", Offset = "0x13D1228", VA = "0x13D1228")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x13CFC34", Offset = "0x13CFC34", VA = "0x13CFC34")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x13D118C", Offset = "0x13D118C", VA = "0x13D118C")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x13CFD70", Offset = "0x13CFD70", VA = "0x13CFD70")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x13D12C0", Offset = "0x13D12C0", VA = "0x13D12C0")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x13CFE8C", Offset = "0x13CFE8C", VA = "0x13CFE8C")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x13D13C4", Offset = "0x13D13C4", VA = "0x13D13C4")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x13CFFE0", Offset = "0x13CFFE0", VA = "0x13CFFE0")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x13D1408", Offset = "0x13D1408", VA = "0x13D1408")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x13CFF4C", Offset = "0x13CFF4C", VA = "0x13CFF4C")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x13D13F0", Offset = "0x13D13F0", VA = "0x13D13F0")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x13D0084", Offset = "0x13D0084", VA = "0x13D0084")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x13D1430", Offset = "0x13D1430", VA = "0x13D1430")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x13D0158", Offset = "0x13D0158", VA = "0x13D0158")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x13D1484", Offset = "0x13D1484", VA = "0x13D1484")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x13D02B0", Offset = "0x13D02B0", VA = "0x13D02B0")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x13D1500", Offset = "0x13D1500", VA = "0x13D1500")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x13D0218", Offset = "0x13D0218", VA = "0x13D0218")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x13D14E4", Offset = "0x13D14E4", VA = "0x13D14E4")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x13D0354", Offset = "0x13D0354", VA = "0x13D0354")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x13D1528", Offset = "0x13D1528", VA = "0x13D1528")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x13D042C", Offset = "0x13D042C", VA = "0x13D042C")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x13D1584", Offset = "0x13D1584", VA = "0x13D1584")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x13D0588", Offset = "0x13D0588", VA = "0x13D0588")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x13D160C", Offset = "0x13D160C", VA = "0x13D160C")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x13D04EC", Offset = "0x13D04EC", VA = "0x13D04EC")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x13D15EC", Offset = "0x13D15EC", VA = "0x13D15EC")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x13D0634", Offset = "0x13D0634", VA = "0x13D0634")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x13D163C", Offset = "0x13D163C", VA = "0x13D163C")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x13D0718", Offset = "0x13D0718", VA = "0x13D0718")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x13D16A0", Offset = "0x13D16A0", VA = "0x13D16A0")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000029")]
	public class DTObjectDump
	{
		[Token(Token = "0x400005E")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x13CDFE0", Offset = "0x13CDFE0", VA = "0x13CDFE0")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x13CEF60", Offset = "0x13CEF60", VA = "0x13CEF60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x13CE2FC", Offset = "0x13CE2FC", VA = "0x13CE2FC")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x13CE384", Offset = "0x13CE384", VA = "0x13CE384")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class DTUtility
	{
		[Token(Token = "0x17000011")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x13D1728", Offset = "0x13D1728", VA = "0x13D1728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x13D1720", Offset = "0x13D1720", VA = "0x13D1720")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x13D1730", Offset = "0x13D1730", VA = "0x13D1730")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x600018F")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x6000190")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x13D1A5C", Offset = "0x13D1A5C", VA = "0x13D1A5C")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x13D1A88", Offset = "0x13D1A88", VA = "0x13D1A88")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x13D1AF8", Offset = "0x13D1AF8", VA = "0x13D1AF8")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x13D1C20", Offset = "0x13D1C20", VA = "0x13D1C20")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000195")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	public static class DTTime
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x17000012")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x13CA74C", Offset = "0x13CA74C", VA = "0x13CA74C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000013")]
		public static float deltaTime
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x13CF0AC", Offset = "0x13CF0AC", VA = "0x13CF0AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x13CF118", Offset = "0x13CF118", VA = "0x13CF118")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x13CF17C", Offset = "0x13CF17C", VA = "0x13CF17C")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x17000014")]
		public double LastTicks
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x13D9EC8", Offset = "0x13D9EC8", VA = "0x13D9EC8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000015")]
		public double LastMS
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x13D9F38", Offset = "0x13D9F38", VA = "0x13D9F38")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000016")]
		public double AverageMS
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x13D9F58", Offset = "0x13D9F58", VA = "0x13D9F58")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000017")]
		public double MinimumMS
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x13DA034", Offset = "0x13DA034", VA = "0x13DA034")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000018")]
		public double MaximumMS
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x13DA138", Offset = "0x13DA138", VA = "0x13DA138")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000019")]
		public double AverageTicks
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x13DA23C", Offset = "0x13DA23C", VA = "0x13DA23C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001A")]
		public double MinimumTicks
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x13DA30C", Offset = "0x13DA30C", VA = "0x13DA30C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001B")]
		public double MaximumTicks
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x13DA404", Offset = "0x13DA404", VA = "0x13DA404")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x13D9D88", Offset = "0x13D9D88", VA = "0x13D9D88")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x13D9E08", Offset = "0x13D9E08", VA = "0x13D9E08")]
		public void Start()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x13D9E24", Offset = "0x13D9E24", VA = "0x13D9E24")]
		public void Stop()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x13D9EAC", Offset = "0x13D9EAC", VA = "0x13D9EAC")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class DTMath
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x13CCBC4", Offset = "0x13CCBC4", VA = "0x13CCBC4")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x13CCDD4", Offset = "0x13CCDD4", VA = "0x13CCDD4")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x13CCE84", Offset = "0x13CCE84", VA = "0x13CCE84")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x13CCF34", Offset = "0x13CCF34", VA = "0x13CCF34")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x13CCFBC", Offset = "0x13CCFBC", VA = "0x13CCFBC")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x13CD03C", Offset = "0x13CD03C", VA = "0x13CD03C")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x13CD06C", Offset = "0x13CD06C", VA = "0x13CD06C")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x13CD0C0", Offset = "0x13CD0C0", VA = "0x13CD0C0")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x13C825C", Offset = "0x13C825C", VA = "0x13C825C")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x13CD130", Offset = "0x13CD130", VA = "0x13CD130")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x13CD1B8", Offset = "0x13CD1B8", VA = "0x13CD1B8")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x13CD218", Offset = "0x13CD218", VA = "0x13CD218")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x13CD2AC", Offset = "0x13CD2AC", VA = "0x13CD2AC")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x13CD508", Offset = "0x13CD508", VA = "0x13CD508")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x13CD678", Offset = "0x13CD678", VA = "0x13CD678")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x13CDA64", Offset = "0x13CDA64", VA = "0x13CDA64")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x13CDBE8", Offset = "0x13CDBE8", VA = "0x13CDBE8")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x13CDD64", Offset = "0x13CDD64", VA = "0x13CDD64")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002E")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x60001B8")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x60001B9")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x60001BB")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public static class DTLog
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x13CC5C4", Offset = "0x13CC5C4", VA = "0x13CC5C4")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x13CC62C", Offset = "0x13CC62C", VA = "0x13CC62C")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x13CC6A4", Offset = "0x13CC6A4", VA = "0x13CC6A4")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x13CC70C", Offset = "0x13CC70C", VA = "0x13CC70C")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x13CC784", Offset = "0x13CC784", VA = "0x13CC784")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x13CC7FC", Offset = "0x13CC7FC", VA = "0x13CC7FC")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x13CC87C", Offset = "0x13CC87C", VA = "0x13CC87C")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x13CC8E4", Offset = "0x13CC8E4", VA = "0x13CC8E4")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x13CC95C", Offset = "0x13CC95C", VA = "0x13CC95C")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x13CC9D4", Offset = "0x13CC9D4", VA = "0x13CC9D4")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x13CA5F4", Offset = "0x13CA5F4", VA = "0x13CA5F4")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x13CCA54", Offset = "0x13CCA54", VA = "0x13CCA54")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x13CCACC", Offset = "0x13CCACC", VA = "0x13CCACC")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x13CCB44", Offset = "0x13CCB44", VA = "0x13CCB44")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public struct FloatRegion
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x1700001C")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x13D60F0", Offset = "0x13D60F0", VA = "0x13D60F0")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x1700001D")]
		public bool Positive
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xFC16EC", Offset = "0xFC16EC", VA = "0xFC16EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public float Low
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xFC16FC", Offset = "0xFC16FC", VA = "0xFC16FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xFC170C", Offset = "0xFC170C", VA = "0xFC170C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float High
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xFC1728", Offset = "0xFC1728", VA = "0xFC1728")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xFC1738", Offset = "0xFC1738", VA = "0xFC1738")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float Random
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xFC1754", Offset = "0xFC1754", VA = "0xFC1754")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float Next
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xFC1760", Offset = "0xFC1760", VA = "0xFC1760")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public float Length
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xFC177C", Offset = "0xFC177C", VA = "0xFC177C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		public float LengthPositive
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xFC1788", Offset = "0xFC1788", VA = "0xFC1788")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xFC16B4", Offset = "0xFC16B4", VA = "0xFC16B4")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xFC16C4", Offset = "0xFC16C4", VA = "0xFC16C4")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xFC16D0", Offset = "0xFC16D0", VA = "0xFC16D0")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xFC16E4", Offset = "0xFC16E4", VA = "0xFC16E4")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xFC17A0", Offset = "0xFC17A0", VA = "0xFC17A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xFC17A8", Offset = "0xFC17A8", VA = "0xFC17A8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xFC17E4", Offset = "0xFC17E4", VA = "0xFC17E4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x13D6418", Offset = "0x13D6418", VA = "0x13D6418")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x13D644C", Offset = "0x13D644C", VA = "0x13D644C")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x13D6480", Offset = "0x13D6480", VA = "0x13D6480")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x13D6498", Offset = "0x13D6498", VA = "0x13D6498")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x13D64C0", Offset = "0x13D64C0", VA = "0x13D64C0")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x13D64E8", Offset = "0x13D64E8", VA = "0x13D64E8")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x13D6510", Offset = "0x13D6510", VA = "0x13D6510")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x13D6618", Offset = "0x13D6618", VA = "0x13D6618")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public struct IntRegion
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000024")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x13D6928", Offset = "0x13D6928", VA = "0x13D6928")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000025")]
		public bool Positive
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xFC1868", Offset = "0xFC1868", VA = "0xFC1868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public int Low
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xFC1878", Offset = "0xFC1878", VA = "0xFC1878")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xFC1888", Offset = "0xFC1888", VA = "0xFC1888")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public int High
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xFC18A4", Offset = "0xFC18A4", VA = "0xFC18A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xFC18B4", Offset = "0xFC18B4", VA = "0xFC18B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int Random
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xFC18D0", Offset = "0xFC18D0", VA = "0xFC18D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public int Length
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xFC18E0", Offset = "0xFC18E0", VA = "0xFC18E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002A")]
		public int LengthPositive
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xFC18EC", Offset = "0xFC18EC", VA = "0xFC18EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xFC1830", Offset = "0xFC1830", VA = "0xFC1830")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xFC1840", Offset = "0xFC1840", VA = "0xFC1840")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xFC184C", Offset = "0xFC184C", VA = "0xFC184C")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xFC1860", Offset = "0xFC1860", VA = "0xFC1860")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xFC1900", Offset = "0xFC1900", VA = "0xFC1900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xFC1908", Offset = "0xFC1908", VA = "0xFC1908", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xFC1944", Offset = "0xFC1944", VA = "0xFC1944", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x13D6C20", Offset = "0x13D6C20", VA = "0x13D6C20")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x13D6C3C", Offset = "0x13D6C3C", VA = "0x13D6C3C")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x13D6C58", Offset = "0x13D6C58", VA = "0x13D6C58")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x13D6C70", Offset = "0x13D6C70", VA = "0x13D6C70")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x13D6C88", Offset = "0x13D6C88", VA = "0x13D6C88")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x13D6CA4", Offset = "0x13D6CA4", VA = "0x13D6CA4")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x13D6CBC", Offset = "0x13D6CBC", VA = "0x13D6CBC")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x13D6CF4", Offset = "0x13D6CF4", VA = "0x13D6CF4")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000032")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B50", Offset = "0xE92B50")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B60", Offset = "0xE92B60")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x1700002B")]
		public int Seed
		{
			[Token(Token = "0x60001FB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D2EC", Offset = "0xE9D2EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D2FC", Offset = "0xE9D2FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60001FD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D30C", Offset = "0xE9D30C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D31C", Offset = "0xE9D31C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		private int Capacity
		{
			[Token(Token = "0x60001FF")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public int Size
		{
			[Token(Token = "0x6000200")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000201")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x6000202")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x6000203")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x6000204")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000205")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE90B08", Offset = "0xE90B08")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B70", Offset = "0xE92B70")]
		private int <Size>k__BackingField;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700002F")]
		public int Size
		{
			[Token(Token = "0x6000206")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D32C", Offset = "0xE9D32C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000207")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D33C", Offset = "0xE9D33C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public T Item
		{
			[Token(Token = "0x600020E")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600020F")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public int Count
		{
			[Token(Token = "0x6000213")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000032")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000214")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000208")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x6000209")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x600020A")]
		public void Clear()
		{
		}

		[Token(Token = "0x600020B")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600020C")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600020D")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000210")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000215")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B80", Offset = "0xE92B80")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92B90", Offset = "0xE92B90")]
		private PoolSettings <Settings>k__BackingField;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x17000033")]
		public string Identifier
		{
			[Token(Token = "0x6000217")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D34C", Offset = "0xE9D34C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D35C", Offset = "0xE9D35C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000219")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D36C", Offset = "0xE9D36C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D37C", Offset = "0xE9D37C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Type Type
		{
			[Token(Token = "0x600021B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public int Count
		{
			[Token(Token = "0x6000220")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600021C")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x600021D")]
		public void Update()
		{
		}

		[Token(Token = "0x600021E")]
		public void Reset()
		{
		}

		[Token(Token = "0x600021F")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000221")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x6000222")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x6000223")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x6000224")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x6000225")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x6000226")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x6000227")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x6000228")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class PoolSettings
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Positive]
		[SerializeField]
		private int m_MinItems;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000037")]
		public bool Prewarm
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x13D83B8", Offset = "0x13D83B8", VA = "0x13D83B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x13D81D0", Offset = "0x13D81D0", VA = "0x13D81D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool AutoCreate
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x13D83C0", Offset = "0x13D83C0", VA = "0x13D83C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x13D81F0", Offset = "0x13D81F0", VA = "0x13D81F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x13D83C8", Offset = "0x13D83C8", VA = "0x13D83C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x13D83D0", Offset = "0x13D83D0", VA = "0x13D83D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public int MinItems
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x13D83F0", Offset = "0x13D83F0", VA = "0x13D83F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x13D8210", Offset = "0x13D8210", VA = "0x13D8210")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int Threshold
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x13D83F8", Offset = "0x13D83F8", VA = "0x13D83F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x13D829C", Offset = "0x13D829C", VA = "0x13D829C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public float Speed
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x13D8400", Offset = "0x13D8400", VA = "0x13D8400")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x13D832C", Offset = "0x13D832C", VA = "0x13D832C")]
			set
			{
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x13D81B8", Offset = "0x13D81B8", VA = "0x13D81B8")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x13D7B40", Offset = "0x13D7B40", VA = "0x13D7B40")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x13CA3E8", Offset = "0x13CA3E8", VA = "0x13CA3E8")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public interface IPool
	{
		[Token(Token = "0x1700003D")]
		string Identifier
		{
			[Token(Token = "0x6000238")]
			get;
			[Token(Token = "0x6000239")]
			set;
		}

		[Token(Token = "0x1700003E")]
		PoolSettings Settings
		{
			[Token(Token = "0x600023A")]
			get;
		}

		[Token(Token = "0x1700003F")]
		int Count
		{
			[Token(Token = "0x600023E")]
			get;
		}

		[Token(Token = "0x600023B")]
		void Clear();

		[Token(Token = "0x600023C")]
		void Reset();

		[Token(Token = "0x600023D")]
		void Update();
	}
	[Token(Token = "0x2000037")]
	public interface IPoolable
	{
		[Token(Token = "0x600023F")]
		void OnBeforePush();

		[Token(Token = "0x6000240")]
		void OnAfterPop();
	}
	[Token(Token = "0x2000038")]
	public enum DTMessageType
	{
		[Token(Token = "0x4000083")]
		None,
		[Token(Token = "0x4000084")]
		Info,
		[Token(Token = "0x4000085")]
		Warning,
		[Token(Token = "0x4000086")]
		Error
	}
	[Token(Token = "0x2000039")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x4000088")]
		None = 0,
		[Token(Token = "0x4000089")]
		Compact = 1,
		[Token(Token = "0x400008A")]
		Clipboard = 128,
		[Token(Token = "0x400008B")]
		Zero = 256,
		[Token(Token = "0x400008C")]
		One = 512,
		[Token(Token = "0x400008D")]
		Negate = 1024,
		[Token(Token = "0x400008E")]
		Full = 1920,
		[Token(Token = "0x400008F")]
		FullCompact = 1921
	}
	[Token(Token = "0x200003A")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Label;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tooltip;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Color;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Precision;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x13CA294", Offset = "0x13CA294", VA = "0x13CA294")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x13D6D30", Offset = "0x13D6D30", VA = "0x13D6D30")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x13D6D94", Offset = "0x13D6D94", VA = "0x13D6D94")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x13DA4F8", Offset = "0x13DA4F8", VA = "0x13DA4F8")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x13D6DD4", Offset = "0x13D6DD4", VA = "0x13D6DD4")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x13D959C", Offset = "0x13D959C", VA = "0x13D959C")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x13DA538", Offset = "0x13DA538", VA = "0x13DA538")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x13CA24C", Offset = "0x13CA24C", VA = "0x13CA24C")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x13D6EAC", Offset = "0x13D6EAC", VA = "0x13D6EAC")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x13D6EFC", Offset = "0x13D6EFC", VA = "0x13D6EFC")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x13D8408", Offset = "0x13D8408", VA = "0x13D8408")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxValue;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x13D6E14", Offset = "0x13D6E14", VA = "0x13D6E14")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x13D6E64", Offset = "0x13D6E64", VA = "0x13D6E64")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxValue;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Slider;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x13D91BC", Offset = "0x13D91BC", VA = "0x13D91BC")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x13D921C", Offset = "0x13D921C", VA = "0x13D921C")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x13D927C", Offset = "0x13D927C", VA = "0x13D927C")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x13D92DC", Offset = "0x13D92DC", VA = "0x13D92DC")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string MaxValueField;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Min;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Max;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x13D6F44", Offset = "0x13D6F44", VA = "0x13D6F44")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x13D242C", Offset = "0x13D242C", VA = "0x13D242C")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x13D70B8", Offset = "0x13D70B8", VA = "0x13D70B8")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x2000140")]
		public enum DialogMode
		{
			[Token(Token = "0x400051E")]
			OpenFile,
			[Token(Token = "0x400051F")]
			OpenFolder,
			[Token(Token = "0x4000520")]
			CreateFile
		}

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DialogMode Mode;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Title;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Directory;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Extension;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string DefaultName;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x13D70F8", Offset = "0x13D70F8", VA = "0x13D70F8")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x13D246C", Offset = "0x13D246C", VA = "0x13D246C")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RegionIsOptional;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSlider;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x13CF040", Offset = "0x13CF040", VA = "0x13CF040")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x13D6718", Offset = "0x13D6718", VA = "0x13D6718")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x13D6D2C", Offset = "0x13D6D2C", VA = "0x13D6D2C")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x17000040")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x600025A")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x600025B")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x200004E")]
	public enum DTValueClamping
	{
		[Token(Token = "0x40000B5")]
		None,
		[Token(Token = "0x40000B6")]
		Min,
		[Token(Token = "0x40000B7")]
		Max,
		[Token(Token = "0x40000B8")]
		Range
	}
	[Token(Token = "0x200004F")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x600025C")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x600025D")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600025E")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000260")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000261")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000262")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D38C", Offset = "0xE9D38C")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000263")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D39C", Offset = "0xE9D39C")]
		private void <.ctor>b__6_1(object state)
		{
		}
	}
	[Token(Token = "0x2000050")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x6000264")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x6000265")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000266")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x2000051")]
	internal class QueuedCallback
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x13D91B4", Offset = "0x13D91B4", VA = "0x13D91B4")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x2000052")]
	internal class LoopState<T>
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x6000268")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class ThreadPoolWorker : IDisposable
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92948", Offset = "0xE92948")]
		private sealed class <>c__4<T>
		{
			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static WaitCallback <>9__4_0;

			[Token(Token = "0x6000B16")]
			public <>c__4()
			{
			}

			[Token(Token = "0x6000B17")]
			internal void <ParralelFor>b__4_0(object state)
			{
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92958", Offset = "0xE92958")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x13D98FC", Offset = "0x13D98FC", VA = "0x13D98FC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x13D9D6C", Offset = "0x13D9D6C", VA = "0x13D9D6C")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x13D95DC", Offset = "0x13D95DC", VA = "0x13D95DC")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x13D9664", Offset = "0x13D9664", VA = "0x13D9664")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x600026B")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x13D9744", Offset = "0x13D9744", VA = "0x13D9744")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x13D95E4", Offset = "0x13D95E4", VA = "0x13D95E4")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x13D966C", Offset = "0x13D966C", VA = "0x13D966C")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x13D9904", Offset = "0x13D9904", VA = "0x13D9904")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x13D9A50", Offset = "0x13D9A50", VA = "0x13D9A50")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x13D9910", Offset = "0x13D9910", VA = "0x13D9910")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x13D9B54", Offset = "0x13D9B54", VA = "0x13D9B54")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x13D9A9C", Offset = "0x13D9A9C", VA = "0x13D9A9C")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x13D9854", Offset = "0x13D9854", VA = "0x13D9854")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x13D9C44", Offset = "0x13D9C44", VA = "0x13D9C44", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x13D9CF8", Offset = "0x13D9CF8", VA = "0x13D9CF8")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92968", Offset = "0xE92968")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x13CB91C", Offset = "0x13CB91C", VA = "0x13CB91C")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x13CBA9C", Offset = "0x13CBA9C", VA = "0x13CBA9C")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Identifier;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UnityEngine.Component> mObjects;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x17000041")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x13CA3C0", Offset = "0x13CA3C0", VA = "0x13CA3C0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x13CA3C8", Offset = "0x13CA3C8", VA = "0x13CA3C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x13CA420", Offset = "0x13CA420", VA = "0x13CA420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public string Identifier
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x13CA4B8", Offset = "0x13CA4B8", VA = "0x13CA4B8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x13CA4C0", Offset = "0x13CA4C0", VA = "0x13CA4C0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Type Type
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x13CA52C", Offset = "0x13CA52C", VA = "0x13CA52C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public int Count
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x13CA65C", Offset = "0x13CA65C", VA = "0x13CA65C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x13CA6AC", Offset = "0x13CA6AC", VA = "0x13CA6AC")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x13CA8AC", Offset = "0x13CA8AC", VA = "0x13CA8AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x13CA8D0", Offset = "0x13CA8D0", VA = "0x13CA8D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x13CA94C", Offset = "0x13CA94C", VA = "0x13CA94C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x13CA950", Offset = "0x13CA950", VA = "0x13CA950", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x13CA768", Offset = "0x13CA768", VA = "0x13CA768", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x13CAE28", Offset = "0x13CAE28", VA = "0x13CAE28")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x13CAF1C", Offset = "0x13CAF1C", VA = "0x13CAF1C", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x13CAFF0", Offset = "0x13CAFF0", VA = "0x13CAFF0")]
		public void Push(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x13CB2E4", Offset = "0x13CB2E4", VA = "0x13CB2E4")]
		public UnityEngine.Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		public T Pop<T>(Transform parent) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x13CAD40", Offset = "0x13CAD40", VA = "0x13CAD40")]
		private UnityEngine.Component create()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x13CAC84", Offset = "0x13CAC84", VA = "0x13CAC84")]
		private void destroy(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x13CB658", Offset = "0x13CB658", VA = "0x13CB658")]
		private void setParent(UnityEngine.Component item, Transform parent)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x13CB4B0", Offset = "0x13CB4B0", VA = "0x13CB4B0")]
		private void sendAfterPop(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x13CB140", Offset = "0x13CB140", VA = "0x13CB140")]
		private void sendBeforePush(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x13CABB8", Offset = "0x13CABB8", VA = "0x13CABB8")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x13CB708", Offset = "0x13CB708", VA = "0x13CB708", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x13CB70C", Offset = "0x13CB70C", VA = "0x13CB70C", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x13CBA2C", Offset = "0x13CBA2C", VA = "0x13CBA2C")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x17000046")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000292")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public static T Instance
		{
			[Token(Token = "0x6000293")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000294")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000295")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000296")]
		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000297")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x6000298")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public interface IDTSingleton
	{
		[Token(Token = "0x600029A")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x2000057")]
	public class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		[Token(Token = "0x17000048")]
		public string Version
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x13D1DB4", Offset = "0x13D1DB4", VA = "0x13D1DB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x13D1DBC", Offset = "0x13D1DBC", VA = "0x13D1DBC")]
			protected set
			{
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x13D1DC4", Offset = "0x13D1DC4", VA = "0x13D1DC4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9D3AC", Offset = "0xE9D3AC")]
		protected void CheckForVersionUpgrade()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x13D1DC8", Offset = "0x13D1DC8", VA = "0x13D1DC8", Slot = "4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9D3E4", Offset = "0xE9D3E4")]
		protected virtual bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x13D2058", Offset = "0x13D2058", VA = "0x13D2058")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x13D210C", Offset = "0x13D210C", VA = "0x13D210C")]
		public DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	public class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000049")]
		public MeshFilter Filter
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x13D2114", Offset = "0x13D2114", VA = "0x13D2114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x13D21AC", Offset = "0x13D21AC", VA = "0x13D21AC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x13D2424", Offset = "0x13D2424", VA = "0x13D2424")]
		public DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xE92D20", Offset = "0xE92D20")]
		[SerializeField]
		private string m_Note;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x13D6904", Offset = "0x13D6904", VA = "0x13D6904")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE92D60", Offset = "0xE92D60")]
		[SerializeField]
		private bool m_AutoCreatePools;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0xE92DB8", Offset = "0xE92DB8")]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92DFC", Offset = "0xE92DFC")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x1700004A")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x13D7178", Offset = "0x13D7178", VA = "0x13D7178")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x13D7180", Offset = "0x13D7180", VA = "0x13D7180")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x13D71A0", Offset = "0x13D71A0", VA = "0x13D71A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x13D71A8", Offset = "0x13D71A8", VA = "0x13D71A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool IsInitialized
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x13D71C8", Offset = "0x13D71C8", VA = "0x13D71C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D41C", Offset = "0xE9D41C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x13D71D0", Offset = "0x13D71D0", VA = "0x13D71D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D42C", Offset = "0xE9D42C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int Count
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x13D71DC", Offset = "0x13D71DC", VA = "0x13D71DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x13D725C", Offset = "0x13D725C", VA = "0x13D725C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x13D7264", Offset = "0x13D7264", VA = "0x13D7264")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x13D73F8", Offset = "0x13D73F8", VA = "0x13D73F8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x13D7824", Offset = "0x13D7824", VA = "0x13D7824")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		public ComponentPool GetComponentPool<T>() where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x13D78DC", Offset = "0x13D78DC", VA = "0x13D78DC")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x13D79D8", Offset = "0x13D79D8", VA = "0x13D79D8")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x13D7D00", Offset = "0x13D7D00", VA = "0x13D7D00")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x13D7E70", Offset = "0x13D7E70", VA = "0x13D7E70")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x13D7F20", Offset = "0x13D7F20", VA = "0x13D7F20")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x60002B9")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x13D80D0", Offset = "0x13D80D0", VA = "0x13D80D0")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE90B88", Offset = "0xE90B88")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE92E0C", Offset = "0xE92E0C")]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x1700004E")]
		public string Identifier
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x13D8470", Offset = "0x13D8470", VA = "0x13D8470", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x13D8478", Offset = "0x13D8478", VA = "0x13D8478", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x13D856C", Offset = "0x13D856C", VA = "0x13D856C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x13D8574", Offset = "0x13D8574", VA = "0x13D8574")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x13D8588", Offset = "0x13D8588", VA = "0x13D8588", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x13D8590", Offset = "0x13D8590", VA = "0x13D8590")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public PoolManager Manager
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x13D84D4", Offset = "0x13D84D4", VA = "0x13D84D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public int Count
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x13D8984", Offset = "0x13D8984", VA = "0x13D8984", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x13D85B0", Offset = "0x13D85B0", VA = "0x13D85B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x13D85B4", Offset = "0x13D85B4", VA = "0x13D85B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x13D7BF4", Offset = "0x13D7BF4", VA = "0x13D7BF4")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x13D871C", Offset = "0x13D871C", VA = "0x13D871C", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x13D85D8", Offset = "0x13D85D8", VA = "0x13D85D8", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x13D8BB8", Offset = "0x13D8BB8", VA = "0x13D8BB8", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x13D8C8C", Offset = "0x13D8C8C", VA = "0x13D8C8C")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x13D8EA8", Offset = "0x13D8EA8", VA = "0x13D8EA8", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x13D8B08", Offset = "0x13D8B08", VA = "0x13D8B08")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x13D9078", Offset = "0x13D9078", VA = "0x13D9078")]
		public static GameObject SuperInstantiate(GameObject Prefab)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x13D8AA0", Offset = "0x13D8AA0", VA = "0x13D8AA0")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x13D89D4", Offset = "0x13D89D4", VA = "0x13D89D4")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x13D9080", Offset = "0x13D9080", VA = "0x13D9080")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x13D8E48", Offset = "0x13D8E48", VA = "0x13D8E48")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x13D9018", Offset = "0x13D9018", VA = "0x13D9018")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x13D9124", Offset = "0x13D9124", VA = "0x13D9124")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x200005C")]
	public static class TransformExt
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x13D4BA0", Offset = "0x13D4BA0", VA = "0x13D4BA0")]
		public static void CopyFrom(this Transform t, Transform other)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x13D4C10", Offset = "0x13D4C10", VA = "0x13D4C10")]
		public static void SetChildrenHideFlags(this Transform t, HideFlags flags)
		{
		}
	}
	[Token(Token = "0x200005D")]
	public static class ObjectExt
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x13D4048", Offset = "0x13D4048", VA = "0x13D4048")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x13D40B0", Offset = "0x13D40B0", VA = "0x13D40B0")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	public static class Vector2Ext
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x13D596C", Offset = "0x13D596C", VA = "0x13D596C")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x13D59D8", Offset = "0x13D59D8", VA = "0x13D59D8")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x13D5AB0", Offset = "0x13D5AB0", VA = "0x13D5AB0")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x13D5AE8", Offset = "0x13D5AE8", VA = "0x13D5AE8")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x13D5B20", Offset = "0x13D5B20", VA = "0x13D5B20")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x13D5BE4", Offset = "0x13D5BE4", VA = "0x13D5BE4")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200005F")]
	public static class Vector3Ext
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x13D5C88", Offset = "0x13D5C88", VA = "0x13D5C88")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x13D5DCC", Offset = "0x13D5DCC", VA = "0x13D5DCC")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x13D5EFC", Offset = "0x13D5EFC", VA = "0x13D5EFC")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x13D5F28", Offset = "0x13D5F28", VA = "0x13D5F28")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x13D5FEC", Offset = "0x13D5FEC", VA = "0x13D5FEC")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000060")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x13D4124", Offset = "0x13D4124", VA = "0x13D4124")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x13D4224", Offset = "0x13D4224", VA = "0x13D4224")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000061")]
	public static class CameraExt
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x13D24AC", Offset = "0x13D24AC", VA = "0x13D24AC")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x13D27FC", Offset = "0x13D27FC", VA = "0x13D27FC")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000062")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x13D3778", Offset = "0x13D3778", VA = "0x13D3778")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x13D30A8", Offset = "0x13D30A8", VA = "0x13D30A8")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class ComponentExt
	{
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x13D2FC8", Offset = "0x13D2FC8", VA = "0x13D2FC8")]
		public static void StripComponents(this UnityEngine.Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x13D3290", Offset = "0x13D3290", VA = "0x13D3290")]
		public static GameObject AddChildGameObject(this UnityEngine.Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		public static T AddChildGameObject<T>(this UnityEngine.Component c, string name) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		public static T DuplicateGameObject<T>(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x13D333C", Offset = "0x13D333C", VA = "0x13D333C")]
		public static UnityEngine.Component DuplicateGameObject(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public static class ColorExt
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x13D2DEC", Offset = "0x13D2DEC", VA = "0x13D2DEC")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public static class EnumExt
	{
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x13D3560", Offset = "0x13D3560", VA = "0x13D3560")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F2")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F3")]
		public static T Toggle<T>(this Enum value, T toggleValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F4")]
		public static T SetAll<T>(this Enum value)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000066")]
	public static class RectExt
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x13D4324", Offset = "0x13D4324", VA = "0x13D4324")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x13D4380", Offset = "0x13D4380", VA = "0x13D4380")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x13D43DC", Offset = "0x13D43DC", VA = "0x13D43DC")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x13D4448", Offset = "0x13D4448", VA = "0x13D4448")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x13D44B4", Offset = "0x13D44B4", VA = "0x13D44B4")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x13D4514", Offset = "0x13D4514", VA = "0x13D4514")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x13D4580", Offset = "0x13D4580", VA = "0x13D4580")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x13D4588", Offset = "0x13D4588", VA = "0x13D4588")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x13D4660", Offset = "0x13D4660", VA = "0x13D4660")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x13D46F0", Offset = "0x13D46F0", VA = "0x13D46F0")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x2000067")]
	public static class StringExt
	{
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x13D485C", Offset = "0x13D485C", VA = "0x13D485C")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x13D4AEC", Offset = "0x13D4AEC", VA = "0x13D4AEC")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x13D4B40", Offset = "0x13D4B40", VA = "0x13D4B40")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x6000302")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public static class ArrayExt
	{
		[Token(Token = "0x6000303")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x13D3874", Offset = "0x13D3874", VA = "0x13D3874")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x13D39F8", Offset = "0x13D39F8", VA = "0x13D39F8")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class TypeExt
	{
		[Serializable]
		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92978", Offset = "0xE92978")]
		private sealed class <>c
		{
			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__1_0;

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x13D5940", Offset = "0x13D5940", VA = "0x13D5940")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x13D5948", Offset = "0x13D5948", VA = "0x13D5948")]
			internal IEnumerable<Type> <GetLoadedTypes>b__1_0(Assembly a)
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x13D4CE0", Offset = "0x13D4CE0", VA = "0x13D4CE0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9D7DC", Offset = "0xE9D7DC")]
		public static Type[] GetAllTypes(this Type typeFromAssembly)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x13CB924", Offset = "0x13CB924", VA = "0x13CB924")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x13D4D18", Offset = "0x13D4D18", VA = "0x13D4D18")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x13CA218", Offset = "0x13CA218", VA = "0x13CA218")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x13CC470", Offset = "0x13CC470", VA = "0x13CC470")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x13CC4AC", Offset = "0x13CC4AC", VA = "0x13CC4AC")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x13CE17C", Offset = "0x13CE17C", VA = "0x13CE17C")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x13CEDE0", Offset = "0x13CEDE0", VA = "0x13CEDE0")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x13D51A8", Offset = "0x13D51A8", VA = "0x13D51A8")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x13D52B4", Offset = "0x13D52B4", VA = "0x13D52B4")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x13CEF80", Offset = "0x13CEF80", VA = "0x13CEF80")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x13D539C", Offset = "0x13D539C", VA = "0x13D539C")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x13D4D3C", Offset = "0x13D4D3C", VA = "0x13D4D3C")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x13D4EB0", Offset = "0x13D4EB0", VA = "0x13D4EB0")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x13D5034", Offset = "0x13D5034", VA = "0x13D5034")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x13D57E0", Offset = "0x13D57E0", VA = "0x13D57E0")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006C")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x6000321")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE90CFC", Offset = "0xE90CFC")]
	public class MetaCGOptions : CurvyMetadataBase, ICurvyMetadata
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_MaterialID;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_HardEdge;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		[SerializeField]
		private float m_MaxStepDistance;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE92F70", Offset = "0xE92F70")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE92F70", Offset = "0xE92F70")]
		[SerializeField]
		private bool m_UVEdge;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE93064", Offset = "0xE93064")]
		[SerializeField]
		private bool m_ExplicitU;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE93128", Offset = "0xE93128")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE93128", Offset = "0xE93128")]
		[Positive]
		[SerializeField]
		private float m_FirstU;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE93214", Offset = "0xE93214")]
		[Positive]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x17000053")]
		public int MaterialID
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1905FC8", Offset = "0x1905FC8", VA = "0x1905FC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1905FD0", Offset = "0x1905FD0", VA = "0x1905FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool HardEdge
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1906074", Offset = "0x1906074", VA = "0x1906074")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x190607C", Offset = "0x190607C", VA = "0x190607C")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool UVEdge
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x19060A4", Offset = "0x19060A4", VA = "0x19060A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x19060AC", Offset = "0x19060AC", VA = "0x19060AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool ExplicitU
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x19060D4", Offset = "0x19060D4", VA = "0x19060D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x19060DC", Offset = "0x19060DC", VA = "0x19060DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public float FirstU
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1906104", Offset = "0x1906104", VA = "0x1906104")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x190610C", Offset = "0x190610C", VA = "0x190610C")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float SecondU
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1906128", Offset = "0x1906128", VA = "0x1906128")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1906130", Offset = "0x1906130", VA = "0x1906130")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public float MaxStepDistance
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x190614C", Offset = "0x190614C", VA = "0x190614C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1906154", Offset = "0x1906154", VA = "0x1906154")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1905250", Offset = "0x1905250", VA = "0x1905250")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private bool showUVEdge
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x19061F8", Offset = "0x19061F8", VA = "0x19061F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		private bool showExplicitU
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1906348", Offset = "0x1906348", VA = "0x1906348")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		private bool showFirstU
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x19063DC", Offset = "0x19063DC", VA = "0x19063DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		private bool showSecondU
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x190647C", Offset = "0x190647C", VA = "0x190647C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1906490", Offset = "0x1906490", VA = "0x1906490")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x190519C", Offset = "0x190519C", VA = "0x190519C")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x19051E8", Offset = "0x19051E8", VA = "0x19051E8")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1906548", Offset = "0x1906548", VA = "0x1906548")]
		public MetaCGOptions()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public interface ICurvyMetadata
	{
	}
	[Token(Token = "0x200006F")]
	public interface ICurvyInterpolatableMetadata : ICurvyMetadata
	{
		[Token(Token = "0x1700005F")]
		object Value
		{
			[Token(Token = "0x6000339")]
			get;
		}

		[Token(Token = "0x600033A")]
		object InterpolateObject(ICurvyMetadata b, float f);
	}
	[Token(Token = "0x2000070")]
	public interface ICurvyInterpolatableMetadata<U> : ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x600033B")]
		U Interpolate(ICurvyMetadata b, float f);
	}
	[Token(Token = "0x2000071")]
	public enum OrientationModeEnum
	{
		[Token(Token = "0x40000F0")]
		None,
		[Token(Token = "0x40000F1")]
		Orientation,
		[Token(Token = "0x40000F2")]
		Tangent
	}
	[Token(Token = "0x2000072")]
	public enum OrientationAxisEnum
	{
		[Token(Token = "0x40000F4")]
		Up,
		[Token(Token = "0x40000F5")]
		Down,
		[Token(Token = "0x40000F6")]
		Forward,
		[Token(Token = "0x40000F7")]
		Backward,
		[Token(Token = "0x40000F8")]
		Left,
		[Token(Token = "0x40000F9")]
		Right
	}
	[Token(Token = "0x2000073")]
	public enum ConnectionHeadingEnum
	{
		[Token(Token = "0x40000FB")]
		Minus = -1,
		[Token(Token = "0x40000FC")]
		Sharp,
		[Token(Token = "0x40000FD")]
		Plus,
		[Token(Token = "0x40000FE")]
		Auto
	}
	[Token(Token = "0x2000074")]
	public static class ConnectionHeadingEnumMethods
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x17F8B6C", Offset = "0x17F8B6C", VA = "0x17F8B6C")]
		public static ConnectionHeadingEnum ResolveAuto(this ConnectionHeadingEnum heading, CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}
	}
	[Token(Token = "0x2000075")]
	public enum CurvyUpdateMethod
	{
		[Token(Token = "0x4000100")]
		Update,
		[Token(Token = "0x4000101")]
		LateUpdate,
		[Token(Token = "0x4000102")]
		FixedUpdate
	}
	[Token(Token = "0x2000076")]
	public enum CurvyRepeatingOrderEnum
	{
		[Token(Token = "0x4000104")]
		Random,
		[Token(Token = "0x4000105")]
		Row
	}
	[Token(Token = "0x2000077")]
	public enum CurvyPlane
	{
		[Token(Token = "0x4000107")]
		XY,
		[Token(Token = "0x4000108")]
		XZ,
		[Token(Token = "0x4000109")]
		YZ
	}
	[Token(Token = "0x2000078")]
	public enum CurvyPositionMode
	{
		[Token(Token = "0x400010B")]
		Relative,
		[Token(Token = "0x400010C")]
		WorldUnits
	}
	[Token(Token = "0x2000079")]
	[Flags]
	public enum CurvyBezierModeEnum
	{
		[Token(Token = "0x400010E")]
		None = 0,
		[Token(Token = "0x400010F")]
		Direction = 1,
		[Token(Token = "0x4000110")]
		Length = 2,
		[Token(Token = "0x4000111")]
		Connections = 4,
		[Token(Token = "0x4000112")]
		Combine = 8
	}
	[Token(Token = "0x200007A")]
	public enum CurvyAdvBezierModeEnum
	{
		[Token(Token = "0x4000114")]
		None = 0,
		[Token(Token = "0x4000115")]
		Direction = 1,
		[Token(Token = "0x4000116")]
		Length = 2,
		[Token(Token = "0x4000117")]
		Combine = 8
	}
	[Token(Token = "0x200007B")]
	public enum CurvyInterpolation
	{
		[Token(Token = "0x4000119")]
		Linear,
		[Token(Token = "0x400011A")]
		CatmullRom,
		[Token(Token = "0x400011B")]
		TCB,
		[Token(Token = "0x400011C")]
		Bezier
	}
	[Token(Token = "0x200007C")]
	public enum CurvyClamping
	{
		[Token(Token = "0x400011E")]
		Clamp,
		[Token(Token = "0x400011F")]
		Loop,
		[Token(Token = "0x4000120")]
		PingPong
	}
	[Token(Token = "0x200007D")]
	public enum CurvyOrientation
	{
		[Token(Token = "0x4000122")]
		None,
		[Token(Token = "0x4000123")]
		Dynamic,
		[Token(Token = "0x4000124")]
		Static
	}
	[Token(Token = "0x200007E")]
	public enum CurvyOrientationSwirl
	{
		[Token(Token = "0x4000126")]
		None,
		[Token(Token = "0x4000127")]
		Segment,
		[Token(Token = "0x4000128")]
		AnchorGroup,
		[Token(Token = "0x4000129")]
		AnchorGroupAbs
	}
	[Token(Token = "0x200007F")]
	[Flags]
	public enum CurvySplineGizmos
	{
		[Token(Token = "0x400012B")]
		None = 0,
		[Token(Token = "0x400012C")]
		Curve = 2,
		[Token(Token = "0x400012D")]
		Approximation = 4,
		[Token(Token = "0x400012E")]
		Tangents = 8,
		[Token(Token = "0x400012F")]
		Orientation = 0x10,
		[Token(Token = "0x4000130")]
		Labels = 0x20,
		[Token(Token = "0x4000131")]
		Metadata = 0x40,
		[Token(Token = "0x4000132")]
		Bounds = 0x80,
		[Token(Token = "0x4000133")]
		All = 0xFFFF
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE90D64", Offset = "0xE90D64")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE90D64", Offset = "0xE90D64")]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92988", Offset = "0xE92988")]
		private sealed class <>c
		{
			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<CurvySplineSegment> <>9__24_0;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<CurvySplineSegment> <>9__25_0;

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1803474", Offset = "0x1803474", VA = "0x1803474")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x180347C", Offset = "0x180347C", VA = "0x180347C")]
			internal bool <OnBeforeSerialize>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1803488", Offset = "0x1803488", VA = "0x1803488")]
			internal bool <OnAfterDeserialize>b__25_0(CurvySplineSegment cp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Hide]
		private List<CurvySplineSegment> m_ControlPoints;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<CurvySplineSegment, Couple<Vector3, Quaternion>> processedControlPointsCoordinates;

		[Token(Token = "0x17000060")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x17FEEB8", Offset = "0x17FEEB8", VA = "0x17FEEB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public int Count
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1801D78", Offset = "0x1801D78", VA = "0x1801D78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1801DC8", Offset = "0x1801DC8", VA = "0x1801DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1801E40", Offset = "0x1801E40", VA = "0x1801E40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1802040", Offset = "0x1802040", VA = "0x1802040")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1802044", Offset = "0x1802044", VA = "0x1802044")]
		private void Update()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1802490", Offset = "0x1802490", VA = "0x1802490")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x18024C8", Offset = "0x18024C8", VA = "0x18024C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1802500", Offset = "0x1802500", VA = "0x1802500")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1802628", Offset = "0x1802628", VA = "0x1802628")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x18027C4", Offset = "0x18027C4", VA = "0x18027C4")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x18029A4", Offset = "0x18029A4", VA = "0x18029A4")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1802C70", Offset = "0x1802C70", VA = "0x1802C70")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1802D38", Offset = "0x1802D38", VA = "0x1802D38")]
		public void Delete()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1802DCC", Offset = "0x1802DCC", VA = "0x1802DCC")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1802E68", Offset = "0x1802E68", VA = "0x1802E68")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x180207C", Offset = "0x180207C", VA = "0x180207C")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1803188", Offset = "0x1803188", VA = "0x1803188", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1803280", Offset = "0x1803280", VA = "0x1803280", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1803378", Offset = "0x1803378", VA = "0x1803378")]
		public CurvyConnection()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class CurvyEventArgs : EventArgs
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly object Data;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x17FB2CC", Offset = "0x17FB2CC", VA = "0x17FB2CC")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x17A190C", Offset = "0x17A190C", VA = "0x17A190C")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1803494", Offset = "0x1803494", VA = "0x1803494")]
		public CurvyControlPointEvent()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class CurvyControlPointEventArgs : CurvySplineEventArgs
	{
		[Token(Token = "0x2000146")]
		public enum ModeEnum
		{
			[Token(Token = "0x400052B")]
			None,
			[Token(Token = "0x400052C")]
			AddBefore,
			[Token(Token = "0x400052D")]
			AddAfter,
			[Token(Token = "0x400052E")]
			Delete
		}

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ModeEnum Mode;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly CurvySplineSegment ControlPoint;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x18034E4", Offset = "0x18034E4", VA = "0x18034E4")]
		public CurvyControlPointEventArgs(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, ModeEnum mode = ModeEnum.None, [Optional] object data)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class CurvySplineEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvySpline Spline;

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x17A195C", Offset = "0x17A195C", VA = "0x17A195C")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1801C18", Offset = "0x1801C18", VA = "0x1801C18")]
		public CurvyCGEvent()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class CurvyCGEventArgs : EventArgs
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CurvyGenerator Generator;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CGModule Module;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1801C68", Offset = "0x1801C68", VA = "0x1801C68")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1801CF4", Offset = "0x1801CF4", VA = "0x1801CF4")]
		public CurvyCGEventArgs(CurvyGenerator generator, CGModule module)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public static class CurvyGizmoHelper
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Matrix4x4 Matrix;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1803524", Offset = "0x1803524", VA = "0x1803524")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1803758", Offset = "0x1803758", VA = "0x1803758")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x18039D0", Offset = "0x18039D0", VA = "0x18039D0")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1803C74", Offset = "0x1803C74", VA = "0x1803C74")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1803F50", Offset = "0x1803F50", VA = "0x1803F50")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x18041C0", Offset = "0x18041C0", VA = "0x18041C0")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1804584", Offset = "0x1804584", VA = "0x1804584")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE90DD4", Offset = "0xE90DD4")]
	public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager>
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool HideManager;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float SceneViewResolution;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Color DefaultGizmoColor;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Color DefaultGizmoSelectionColor;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static CurvyInterpolation DefaultInterpolation;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float GizmoControlPointSize;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float GizmoOrientationLength;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static Color GizmoOrientationColor;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int SplineLayer;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static CurvySplineGizmos Gizmos;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PoolManager mPoolManager;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComponentPool mControlPointPool;

		[Token(Token = "0x17000063")]
		public static bool ShowCurveGizmo
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x180479C", Offset = "0x180479C", VA = "0x180479C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1804808", Offset = "0x1804808", VA = "0x1804808")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x18048A4", Offset = "0x18048A4", VA = "0x18048A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1804910", Offset = "0x1804910", VA = "0x1804910")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x18049AC", Offset = "0x18049AC", VA = "0x18049AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1804A18", Offset = "0x1804A18", VA = "0x1804A18")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1804AB4", Offset = "0x1804AB4", VA = "0x1804AB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1804B20", Offset = "0x1804B20", VA = "0x1804B20")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1804BBC", Offset = "0x1804BBC", VA = "0x1804BBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1804C28", Offset = "0x1804C28", VA = "0x1804C28")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1804CC4", Offset = "0x1804CC4", VA = "0x1804CC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x1804D30", Offset = "0x1804D30", VA = "0x1804D30")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1804DCC", Offset = "0x1804DCC", VA = "0x1804DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1804E38", Offset = "0x1804E38", VA = "0x1804E38")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1804ED4", Offset = "0x1804ED4", VA = "0x1804ED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1804F6C", Offset = "0x1804F6C", VA = "0x1804F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1804F74", Offset = "0x1804F74", VA = "0x1804F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1804FC4", Offset = "0x1804FC4", VA = "0x1804FC4")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1805770", Offset = "0x1805770", VA = "0x1805770", Slot = "5")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x18058D8", Offset = "0x18058D8", VA = "0x18058D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x180596C", Offset = "0x180596C", VA = "0x180596C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xE9D938", Offset = "0xE9D938")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1805BF4", Offset = "0x1805BF4", VA = "0x1805BF4")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1805DD8", Offset = "0x1805DD8", VA = "0x1805DD8", Slot = "7")]
		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1805EF4", Offset = "0x1805EF4", VA = "0x1805EF4")]
		public CurvyGlobalManager()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	public class CurvyMetadataBase : MonoBehaviour
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700006D")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x18060A0", Offset = "0x18060A0", VA = "0x18060A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x18060A8", Offset = "0x18060A8", VA = "0x18060A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1806134", Offset = "0x1806134", VA = "0x1806134", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600037D")]
		public T GetPreviousData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : MonoBehaviour, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		public T GetNextData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : MonoBehaviour, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x180618C", Offset = "0x180618C", VA = "0x180618C")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1806230", Offset = "0x1806230", VA = "0x1806230")]
		public CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE90E58", Offset = "0xE90E58")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string ResourceName;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ReadOnly;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x17F778C", Offset = "0x17F778C", VA = "0x17F778C")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE90E90", Offset = "0xE90E90")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ShowCount;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x17F7764", Offset = "0x17F7764", VA = "0x17F7764")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE90EC8", Offset = "0xE90EC8")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Type DataType;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x17F76F8", Offset = "0x17F76F8", VA = "0x17F76F8")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE90F00", Offset = "0xE90F00")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE90F00", Offset = "0xE90F00")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE93310", Offset = "0xE93310")]
		private CurvyPlane m_Plane;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private bool m_Persistent;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvySpline mSpline;

		[NonSerialized]
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Dirty;

		[Token(Token = "0x1700006F")]
		public CurvyPlane Plane
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1806238", Offset = "0x1806238", VA = "0x1806238")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x1806240", Offset = "0x1806240", VA = "0x1806240")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool Persistent
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x180625C", Offset = "0x180625C", VA = "0x180625C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1806264", Offset = "0x1806264", VA = "0x1806264")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1806298", Offset = "0x1806298", VA = "0x1806298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1807920", Offset = "0x1807920", VA = "0x1807920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x180632C", Offset = "0x180632C", VA = "0x180632C")]
		private void Update()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1806460", Offset = "0x1806460", VA = "0x1806460", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1806478", Offset = "0x1806478", VA = "0x1806478")]
		public void Delete()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x180636C", Offset = "0x180636C", VA = "0x180636C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x18065D4", Offset = "0x18065D4", VA = "0x18065D4")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x18068D8", Offset = "0x18068D8", VA = "0x18068D8")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1806BC8", Offset = "0x1806BC8", VA = "0x1806BC8")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1806C70", Offset = "0x1806C70", VA = "0x1806C70")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1806D20", Offset = "0x1806D20", VA = "0x1806D20")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1806D28", Offset = "0x1806D28", VA = "0x1806D28")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1807008", Offset = "0x1807008", VA = "0x1807008")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1806F64", Offset = "0x1806F64", VA = "0x1806F64")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1807164", Offset = "0x1807164", VA = "0x1807164")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x18072CC", Offset = "0x18072CC", VA = "0x18072CC", Slot = "6")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x18072D0", Offset = "0x18072D0", VA = "0x18072D0")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1807A3C", Offset = "0x1807A3C", VA = "0x1807A3C")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1807BD0", Offset = "0x1807BD0", VA = "0x1807BD0")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1807E34", Offset = "0x1807E34", VA = "0x1807E34")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1806744", Offset = "0x1806744", VA = "0x1806744")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x18064E0", Offset = "0x18064E0", VA = "0x18064E0")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1807FA0", Offset = "0x1807FA0", VA = "0x1807FA0")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x18082CC", Offset = "0x18082CC", VA = "0x18082CC")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE90F98", Offset = "0xE90F98")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool Is2D;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x18083C0", Offset = "0x18083C0", VA = "0x18083C0")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1808350", Offset = "0x1808350", VA = "0x1808350")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE90FD0", Offset = "0xE90FD0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE90FD0", Offset = "0xE90FD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE90FD0", Offset = "0xE90FD0")]
	[ExecuteInEditMode]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92998", Offset = "0xE92998")]
		private sealed class <>c__DisplayClass188_0
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x17A1858", Offset = "0x17A1858", VA = "0x17A1858")]
			public <>c__DisplayClass188_0()
			{
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x17A1860", Offset = "0x17A1860", VA = "0x17A1860")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE929A8", Offset = "0xE929A8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<CurvySplineSegment> <>9__302_0;

			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x17A169C", Offset = "0x17A169C", VA = "0x17A169C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x17A16A4", Offset = "0x17A16A4", VA = "0x17A16A4")]
			internal void <ProcessDirtyControlPoints>b__302_0(CurvySplineSegment controlPoint)
			{
			}
		}

		[Token(Token = "0x4000159")]
		public const string VERSION = "5.2.2";

		[Token(Token = "0x400015A")]
		public const string APIVERSION = "520";

		[Token(Token = "0x400015B")]
		public const string WEBROOT = "https://curvyeditor.com/";

		[Token(Token = "0x400015C")]
		public const string DOCLINK = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private List<CurvySplineSegment> ControlPoints;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool ShowGizmos;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE933F0", Offset = "0xE933F0")]
		private Action<CurvySpline> <OnGlobalCoordinatesChanged>k__BackingField;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE93400", Offset = "0xE93400")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93400", Offset = "0xE93400")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE93400", Offset = "0xE93400")]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE934B0", Offset = "0xE934B0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE934B0", Offset = "0xE934B0")]
		[SerializeField]
		private bool m_RestrictTo2D;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE93524", Offset = "0xE93524")]
		private bool m_Closed;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE93570", Offset = "0xE93570")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93570", Offset = "0xE93570")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE93570", Offset = "0xE93570")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9360C", Offset = "0xE9360C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE9360C", Offset = "0xE9360C")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9367C", Offset = "0xE9367C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0xE9367C", Offset = "0xE9367C")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9367C", Offset = "0xE9367C")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE937A4", Offset = "0xE937A4")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0xE937A4", Offset = "0xE937A4")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0xE937A4", Offset = "0xE937A4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE937A4", Offset = "0xE937A4")]
		private float m_Tension;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE938E8", Offset = "0xE938E8")]
		private float m_Continuity;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE93934", Offset = "0xE93934")]
		private float m_Bias;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE93980", Offset = "0xE93980")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE93980", Offset = "0xE93980")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE93980", Offset = "0xE93980")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE93A54", Offset = "0xE93A54")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE93ABC", Offset = "0xE93ABC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE93ABC", Offset = "0xE93ABC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93ABC", Offset = "0xE93ABC")]
		private int m_CacheDensity;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93B78", Offset = "0xE93B78")]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93BC4", Offset = "0xE93BC4")]
		private bool m_UsePooling;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93C10", Offset = "0xE93C10")]
		private bool m_UseThreading;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93C5C", Offset = "0xE93C5C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE93C5C", Offset = "0xE93C5C")]
		private bool m_CheckTransform;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93CDC", Offset = "0xE93CDC")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0xE93CDC", Offset = "0xE93CDC")]
		[SerializeField]
		private CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93D58", Offset = "0xE93D58")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0xE93D58", Offset = "0xE93D58")]
		[SerializeField]
		private CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93DC0", Offset = "0xE93DC0")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0xE93DC0", Offset = "0xE93DC0")]
		[SerializeField]
		private CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93E28", Offset = "0xE93E28")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0xE93E28", Offset = "0xE93E28")]
		[SerializeField]
		private CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93E90", Offset = "0xE93E90")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0xE93E90", Offset = "0xE93E90")]
		[SerializeField]
		private CurvyControlPointEvent m_OnBeforeControlPointDelete;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool mIsInitialized;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool isStarted;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private bool sendOnRefreshEventNextUpdate;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object controlPointsRelationshipCacheLock;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<CurvySplineSegment> mSegments;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float length;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int mCacheSize;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Bounds? mBounds;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool mDirtyCurve;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		private bool mDirtyOrientation;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<CurvySplineSegment> dirtyCpsExtendedList;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool allControlPointsAreDirty;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private CurvySplineSegment _lastDistToSeg;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly Action<CurvySplineSegment> refreshCurveAction;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 lastProcessedPosition;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Quaternion lastProcessedRotation;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 lastProcessedScale;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool globalCoordinatesChangedThisFrame;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool isCpsRelationshipCacheValid;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private CurvySplineSegment firstSegment;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private CurvySplineSegment lastSegment;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private CurvySplineSegment firstVisibleControlPoint;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CurvySplineSegment lastVisibleControlPoint;

		[Token(Token = "0x17000073")]
		public CurvyInterpolation Interpolation
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x18086F0", Offset = "0x18086F0", VA = "0x18086F0")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1806A28", Offset = "0x1806A28", VA = "0x1806A28")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1808A74", Offset = "0x1808A74", VA = "0x1808A74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1806B9C", Offset = "0x1806B9C", VA = "0x1806B9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1808A7C", Offset = "0x1808A7C", VA = "0x1808A7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1808A84", Offset = "0x1808A84", VA = "0x1808A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool Closed
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1808B28", Offset = "0x1808B28", VA = "0x1808B28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1806B44", Offset = "0x1806B44", VA = "0x1806B44")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1808B30", Offset = "0x1808B30", VA = "0x1808B30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x18089F4", Offset = "0x18089F4", VA = "0x18089F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1808B5C", Offset = "0x1808B5C", VA = "0x1808B5C")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1806A74", Offset = "0x1806A74", VA = "0x1806A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1808B64", Offset = "0x1808B64", VA = "0x1808B64")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1808B6C", Offset = "0x1808B6C", VA = "0x1808B6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Color GizmoColor
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1808B80", Offset = "0x1808B80", VA = "0x1808B80")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1808B8C", Offset = "0x1808B8C", VA = "0x1808B8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1808BF8", Offset = "0x1808BF8", VA = "0x1808BF8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1808C04", Offset = "0x1808C04", VA = "0x1808C04")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public int CacheDensity
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1808C70", Offset = "0x1808C70", VA = "0x1808C70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1806A98", Offset = "0x1806A98", VA = "0x1806A98")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1808C78", Offset = "0x1808C78", VA = "0x1808C78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1808C80", Offset = "0x1808C80", VA = "0x1808C80")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool UsePooling
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1808D34", Offset = "0x1808D34", VA = "0x1808D34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1808D3C", Offset = "0x1808D3C", VA = "0x1808D3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool UseThreading
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1808D5C", Offset = "0x1808D5C", VA = "0x1808D5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1808D64", Offset = "0x1808D64", VA = "0x1808D64")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool CheckTransform
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1808D84", Offset = "0x1808D84", VA = "0x1808D84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1808D8C", Offset = "0x1808D8C", VA = "0x1808D8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public float Tension
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1808DB8", Offset = "0x1808DB8", VA = "0x1808DB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1808DC0", Offset = "0x1808DC0", VA = "0x1808DC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public float Continuity
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1808DE0", Offset = "0x1808DE0", VA = "0x1808DE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1808DE8", Offset = "0x1808DE8", VA = "0x1808DE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public float Bias
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1808E08", Offset = "0x1808E08", VA = "0x1808E08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1808E10", Offset = "0x1808E10", VA = "0x1808E10")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool IsInitialized
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1808E30", Offset = "0x1808E30", VA = "0x1808E30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public Bounds Bounds
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1808E38", Offset = "0x1808E38", VA = "0x1808E38")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000086")]
		public int Count
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x17FCF54", Offset = "0x17FCF54", VA = "0x17FCF54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		public int ControlPointCount
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1806F14", Offset = "0x1806F14", VA = "0x1806F14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		public int CacheSize
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1809090", Offset = "0x1809090", VA = "0x1809090")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public float Length
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x17FBE44", Offset = "0x17FBE44", VA = "0x17FBE44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008A")]
		public bool Dirty
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x17FDC6C", Offset = "0x17FDC6C", VA = "0x17FDC6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x17FF1F8", Offset = "0x17FF1F8", VA = "0x17FF1F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1805708", Offset = "0x1805708", VA = "0x1805708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		[CanBeNull]
		public CurvySplineSegment FirstVisibleControlPoint
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x17F8C74", Offset = "0x17F8C74", VA = "0x17F8C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		[CanBeNull]
		public CurvySplineSegment LastVisibleControlPoint
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x17F8CA8", Offset = "0x17F8CA8", VA = "0x17F8CA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x18096B8", Offset = "0x18096B8", VA = "0x18096B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x18096EC", Offset = "0x18096EC", VA = "0x18096EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9E5C0", Offset = "0xE9E5C0")]
		public bool IsClosed
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1809720", Offset = "0x1809720", VA = "0x1809720")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		public CurvySpline NextSpline
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1809728", Offset = "0x1809728", VA = "0x1809728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public CurvySpline PreviousSpline
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1809800", Offset = "0x1809800", VA = "0x1809800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x18098D8", Offset = "0x18098D8", VA = "0x18098D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public Action<CurvySpline> OnGlobalCoordinatesChanged
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x18098E0", Offset = "0x18098E0", VA = "0x18098E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D948", Offset = "0xE9D948")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x18098E8", Offset = "0x18098E8", VA = "0x18098E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9D958", Offset = "0xE9D958")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x18098F0", Offset = "0x18098F0", VA = "0x18098F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x18098F8", Offset = "0x18098F8", VA = "0x18098F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x180990C", Offset = "0x180990C", VA = "0x180990C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1809914", Offset = "0x1809914", VA = "0x1809914")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1809928", Offset = "0x1809928", VA = "0x1809928")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1809930", Offset = "0x1809930", VA = "0x1809930")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1809944", Offset = "0x1809944", VA = "0x1809944")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x180994C", Offset = "0x180994C", VA = "0x180994C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1809960", Offset = "0x1809960", VA = "0x1809960")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1809968", Offset = "0x1809968", VA = "0x1809968")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		private List<CurvySplineSegment> controlPoints
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1812930", Offset = "0x1812930", VA = "0x1812930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x180905C", Offset = "0x180905C", VA = "0x180905C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1808400", Offset = "0x1808400", VA = "0x1808400")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x180997C", Offset = "0x180997C", VA = "0x180997C")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1809B44", Offset = "0x1809B44", VA = "0x1809B44")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1809CB8", Offset = "0x1809CB8", VA = "0x1809CB8")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1809D48", Offset = "0x1809D48", VA = "0x1809D48")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1809E34", Offset = "0x1809E34", VA = "0x1809E34")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1809F84", Offset = "0x1809F84", VA = "0x1809F84")]
		public static float BezierTangent(float T0, float P0, float P1, float T1, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1809FD4", Offset = "0x1809FD4", VA = "0x1809FD4")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x180A2D8", Offset = "0x180A2D8", VA = "0x180A2D8")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x180A460", Offset = "0x180A460", VA = "0x180A460")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x17FC70C", Offset = "0x17FC70C", VA = "0x17FC70C")]
		public Vector3 Interpolate(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x180A708", Offset = "0x180A708", VA = "0x180A708")]
		public Vector3 Interpolate(float tf, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x17FC714", Offset = "0x17FC714", VA = "0x17FC714")]
		public Vector3 InterpolateFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EF")]
		public T GetMetadata<T>(float tf) where T : UnityEngine.Component, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x180A808", Offset = "0x180A808", VA = "0x180A808")]
		public UnityEngine.Component GetMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		public U InterpolateMetadata<T, U>(float tf) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x180A8DC", Offset = "0x180A8DC", VA = "0x180A8DC")]
		public object InterpolateMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x180A9B0", Offset = "0x180A9B0", VA = "0x180A9B0")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17FCB4C", Offset = "0x17FCB4C", VA = "0x17FCB4C")]
		public Vector3 GetOrientationUpFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x180AA90", Offset = "0x180AA90", VA = "0x180AA90")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x17FCCCC", Offset = "0x17FCCCC", VA = "0x17FCCCC")]
		public Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x17FCA44", Offset = "0x17FCA44", VA = "0x17FCA44")]
		public Vector3 GetTangent(float tf, Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x17FC964", Offset = "0x17FC964", VA = "0x17FC964")]
		public Vector3 GetTangentFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x180AB88", Offset = "0x180AB88", VA = "0x180AB88")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9D968", Offset = "0xE9D968")]
		public Vector3 GetExtrusionPoint(float tf, float radius, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x180AD14", Offset = "0x180AD14", VA = "0x180AD14")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9D9A0", Offset = "0xE9D9A0")]
		public Vector3 GetExtrusionPointFast(float tf, float radius, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x180AE90", Offset = "0x180AE90", VA = "0x180AE90")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9D9D8", Offset = "0xE9D9D8")]
		public Vector3 GetRotatedUp(float tf, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x180AF7C", Offset = "0x180AF7C", VA = "0x180AF7C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9DA10", Offset = "0xE9DA10")]
		public Vector3 GetRotatedUpFast(float tf, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x180B068", Offset = "0x180B068", VA = "0x180B068")]
		public Vector3 GetTangentByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x180B090", Offset = "0x180B090", VA = "0x180B090")]
		public Vector3 GetTangentByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x180B0B8", Offset = "0x180B0B8", VA = "0x180B0B8")]
		public Vector3 InterpolateByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x180B0E4", Offset = "0x180B0E4", VA = "0x180B0E4")]
		public Vector3 InterpolateByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x180B10C", Offset = "0x180B10C", VA = "0x180B10C")]
		public float ExtrapolateDistanceToTF(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x180B2DC", Offset = "0x180B2DC", VA = "0x180B2DC")]
		public float ExtrapolateDistanceToTFFast(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x17FC418", Offset = "0x17FC418", VA = "0x17FC418")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x17FE2B8", Offset = "0x17FE2B8", VA = "0x17FE2B8")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x180B4A4", Offset = "0x180B4A4", VA = "0x180B4A4")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x180B4CC", Offset = "0x180B4CC", VA = "0x180B4CC")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x180A800", Offset = "0x180A800", VA = "0x180A800")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x17FF334", Offset = "0x17FF334", VA = "0x17FF334")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x17FE6D0", Offset = "0x17FE6D0", VA = "0x17FE6D0")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x17FC55C", Offset = "0x17FC55C", VA = "0x17FC55C")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x180B57C", Offset = "0x180B57C", VA = "0x180B57C")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x17FE43C", Offset = "0x17FE43C", VA = "0x17FE43C")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x180B654", Offset = "0x180B654", VA = "0x180B654")]
		public Vector3 Move(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x180B6A4", Offset = "0x180B6A4", VA = "0x180B6A4")]
		public Vector3 MoveFast(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x180B6F0", Offset = "0x180B6F0", VA = "0x180B6F0")]
		public Vector3 MoveBy(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x180B740", Offset = "0x180B740", VA = "0x180B740")]
		public Vector3 MoveByFast(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x180B7AC", Offset = "0x180B7AC", VA = "0x180B7AC")]
		public Vector3 MoveByLengthFast(ref float tf, ref int direction, float distance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x180B838", Offset = "0x180B838", VA = "0x180B838")]
		public Vector3 MoveByAngle(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x180BAFC", Offset = "0x180BAFC", VA = "0x180BAFC")]
		public Vector3 MoveByAngleFast(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x180BDA0", Offset = "0x180BDA0", VA = "0x180BDA0")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x180BDDC", Offset = "0x180BDDC", VA = "0x180BDDC")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x17FDB78", Offset = "0x17FDB78", VA = "0x17FDB78")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x180BE30", Offset = "0x180BE30", VA = "0x180BE30")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x180BE8C", Offset = "0x180BE8C", VA = "0x180BE8C")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x180BE98", Offset = "0x180BE98", VA = "0x180BE98")]
		public CurvySplineSegment[] Add(params Vector3[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x180C25C", Offset = "0x180C25C", VA = "0x180C25C")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x180C4BC", Offset = "0x180C4BC", VA = "0x180C4BC")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x18074F4", Offset = "0x18074F4", VA = "0x18074F4")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x180C0A0", Offset = "0x180C0A0", VA = "0x180C0A0")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x180C9EC", Offset = "0x180C9EC", VA = "0x180C9EC")]
		public void Clear()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x180770C", Offset = "0x180770C", VA = "0x180770C")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x17F898C", Offset = "0x17F898C", VA = "0x17F898C")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x180CF48", Offset = "0x180CF48", VA = "0x180CF48")]
		public Vector3[] GetApproximationT()
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x180D068", Offset = "0x180D068", VA = "0x180D068")]
		public Vector3[] GetApproximationUpVectors()
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x180D188", Offset = "0x180D188", VA = "0x180D188")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x180D1FC", Offset = "0x180D1FC", VA = "0x180D1FC")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest)
		{
			return default(float);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x180D230", Offset = "0x180D230", VA = "0x180D230")]
		public float GetNearestPointTF(Vector3 localPosition, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x180D1C8", Offset = "0x180D1C8", VA = "0x180D1C8")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x180D270", Offset = "0x180D270", VA = "0x180D270")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestSegmentF, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x17FDCD4", Offset = "0x17FDCD4", VA = "0x17FDCD4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x18065C8", Offset = "0x18065C8", VA = "0x18065C8")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x18087A8", Offset = "0x18087A8", VA = "0x18087A8")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x180E1C8", Offset = "0x180E1C8", VA = "0x180E1C8")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1803130", Offset = "0x1803130", VA = "0x1803130")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x180E668", Offset = "0x180E668", VA = "0x180E668")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x180E6B4", Offset = "0x180E6B4", VA = "0x180E6B4")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x180E90C", Offset = "0x180E90C", VA = "0x180E90C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9DA48", Offset = "0xE9DA48")]
		public Vector3[] GetPolygonByAngle(float angle, float minDistance)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x180EB4C", Offset = "0x180EB4C", VA = "0x180EB4C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9DA80", Offset = "0xE9DA80")]
		public Vector3[] GetPolygon(float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x180F118", Offset = "0x180F118", VA = "0x180F118")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x180F4EC", Offset = "0x180F4EC", VA = "0x180F4EC")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x180F568", Offset = "0x180F568", VA = "0x180F568")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x180F7F0", Offset = "0x180F7F0", VA = "0x180F7F0")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x180F9B8", Offset = "0x180F9B8", VA = "0x180F9B8")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x180FE50", Offset = "0x180FE50", VA = "0x180FE50")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x18104FC", Offset = "0x18104FC", VA = "0x18104FC")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x18107F8", Offset = "0x18107F8", VA = "0x18107F8")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1810BAC", Offset = "0x1810BAC", VA = "0x1810BAC")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1810DD0", Offset = "0x1810DD0", VA = "0x1810DD0")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1810F78", Offset = "0x1810F78", VA = "0x1810F78")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x18112E8", Offset = "0x18112E8", VA = "0x18112E8")]
		public void Flip()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x18115DC", Offset = "0x18115DC", VA = "0x18115DC")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x181198C", Offset = "0x181198C", VA = "0x181198C")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1811A78", Offset = "0x1811A78", VA = "0x1811A78")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1811CC8", Offset = "0x1811CC8", VA = "0x1811CC8")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1811E40", Offset = "0x1811E40", VA = "0x1811E40")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1802C2C", Offset = "0x1802C2C", VA = "0x1802C2C")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x180B538", Offset = "0x180B538", VA = "0x180B538")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1811F50", Offset = "0x1811F50", VA = "0x1811F50")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9DAB8", Offset = "0xE9DAB8")]
		public short GetSegementIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x180B4F4", Offset = "0x180B4F4", VA = "0x180B4F4")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x17FE83C", Offset = "0x17FE83C", VA = "0x17FE83C")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1811F54", Offset = "0x1811F54", VA = "0x1811F54")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1811F98", Offset = "0x1811F98", VA = "0x1811F98")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x17FEA94", Offset = "0x17FEA94", VA = "0x17FEA94")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x181216C", Offset = "0x181216C", VA = "0x181216C")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x18121B0", Offset = "0x18121B0", VA = "0x18121B0")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x180B5A4", Offset = "0x180B5A4", VA = "0x180B5A4")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x18122A0", Offset = "0x18122A0", VA = "0x18122A0")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x180C478", Offset = "0x180C478", VA = "0x180C478")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x17FEB44", Offset = "0x17FEB44", VA = "0x17FEB44")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1812350", Offset = "0x1812350", VA = "0x1812350")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1812394", Offset = "0x1812394", VA = "0x1812394")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1812938", Offset = "0x1812938", VA = "0x1812938")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x18129B8", Offset = "0x18129B8", VA = "0x18129B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1809B00", Offset = "0x1809B00", VA = "0x1809B00")]
		public void Start()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1812A30", Offset = "0x1812A30", VA = "0x1812A30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1812A38", Offset = "0x1812A38", VA = "0x1812A38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1812B9C", Offset = "0x1812B9C", VA = "0x1812B9C", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1812D4C", Offset = "0x1812D4C", VA = "0x1812D4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x18130B8", Offset = "0x18130B8", VA = "0x18130B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x18130FC", Offset = "0x18130FC", VA = "0x18130FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x18129F0", Offset = "0x18129F0", VA = "0x18129F0")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1812D8C", Offset = "0x1812D8C", VA = "0x1812D8C")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1808B38", Offset = "0x1808B38", VA = "0x1808B38")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x180E220", Offset = "0x180E220", VA = "0x180E220")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x180E174", Offset = "0x180E174", VA = "0x180E174")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x181156C", Offset = "0x181156C", VA = "0x181156C")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x18131CC", Offset = "0x18131CC", VA = "0x18131CC")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x18131E8", Offset = "0x18131E8", VA = "0x18131E8")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x181320C", Offset = "0x181320C", VA = "0x181320C")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1812088", Offset = "0x1812088", VA = "0x1812088")]
		[NotNull]
		private static CurvySplineSegment GetFollowUpNextControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headToDirection)
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x180E7BC", Offset = "0x180E7BC", VA = "0x180E7BC")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1811838", Offset = "0x1811838", VA = "0x1811838")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x180CD88", Offset = "0x180CD88", VA = "0x180CD88")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x180CC40", Offset = "0x180CC40", VA = "0x180CC40")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x18086F8", Offset = "0x18086F8", VA = "0x18086F8")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1809168", Offset = "0x1809168", VA = "0x1809168")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x180D518", Offset = "0x180D518", VA = "0x180D518")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x18134CC", Offset = "0x18134CC", VA = "0x18134CC")]
		private void PrepareTTransforms()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1813244", Offset = "0x1813244", VA = "0x1813244")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1806224", Offset = "0x1806224", VA = "0x1806224")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x18136B4", Offset = "0x18136B4", VA = "0x18136B4")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1813140", Offset = "0x1813140", VA = "0x1813140")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x180C5D0", Offset = "0x180C5D0", VA = "0x180C5D0")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 globalPosition, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x180E108", Offset = "0x180E108", VA = "0x180E108")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x180C034", Offset = "0x180C034", VA = "0x180C034")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x180C184", Offset = "0x180C184", VA = "0x180C184")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x180CBD4", Offset = "0x180CBD4", VA = "0x180CBD4")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x180C1F0", Offset = "0x180C1F0", VA = "0x180C1F0")]
		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x18136B8", Offset = "0x18136B8", VA = "0x18136B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DB80", Offset = "0xE9DB80")]
		private void <.ctor>b__4_0(CurvySplineSegment controlPoint)
		{
		}
	}
	[Token(Token = "0x2000092")]
	public enum SplineDirtyingType
	{
		[Token(Token = "0x4000194")]
		OrientationOnly,
		[Token(Token = "0x4000195")]
		Everything
	}
	[Token(Token = "0x2000093")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91068", Offset = "0xE91068")]
	public class CurvySplineSegment : MonoBehaviour, IPoolable
	{
		[Token(Token = "0x2000149")]
		internal readonly struct ControlPointExtrinsicProperties : IEquatable<ControlPointExtrinsicProperties>
		{
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly bool isVisible;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private readonly short segmentIndex;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private readonly short controlPointIndex;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			private readonly short nextControlPointIndex;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly short previousControlPointIndex;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly bool previousControlPointIsSegment;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			private readonly bool nextControlPointIsSegment;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly bool canHaveFollowUp;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			private readonly short orientationAnchorIndex;

			[Token(Token = "0x17000257")]
			internal bool IsVisible
			{
				[Token(Token = "0x6000B28")]
				[Address(RVA = "0xFCFBDC", Offset = "0xFCFBDC", VA = "0xFCFBDC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000258")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0xFCFBE4", Offset = "0xFCFBE4", VA = "0xFCFBE4")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x17000259")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000B2A")]
				[Address(RVA = "0xFCFBEC", Offset = "0xFCFBEC", VA = "0xFCFBEC")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700025A")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000B2B")]
				[Address(RVA = "0xFCFBF4", Offset = "0xFCFBF4", VA = "0xFCFBF4")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700025B")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000B2C")]
				[Address(RVA = "0xFCFBFC", Offset = "0xFCFBFC", VA = "0xFCFBFC")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700025C")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000B2D")]
				[Address(RVA = "0xFCFC04", Offset = "0xFCFC04", VA = "0xFCFC04")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700025D")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x6000B2E")]
				[Address(RVA = "0xFCFC0C", Offset = "0xFCFC0C", VA = "0xFCFC0C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700025E")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0xFCFC14", Offset = "0xFCFC14", VA = "0xFCFC14")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700025F")]
			internal bool IsSegment
			{
				[Token(Token = "0x6000B30")]
				[Address(RVA = "0xFCFC1C", Offset = "0xFCFC1C", VA = "0xFCFC1C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000260")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x6000B31")]
				[Address(RVA = "0xFCFC2C", Offset = "0xFCFC2C", VA = "0xFCFC2C")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xFCFC34", Offset = "0xFCFC34", VA = "0xFCFC34")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xFCFC74", Offset = "0xFCFC74", VA = "0xFCFC74", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xFCFC7C", Offset = "0xFCFC7C", VA = "0xFCFC7C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B35")]
			[Address(RVA = "0xFCFC84", Offset = "0xFCFC84", VA = "0xFCFC84", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x17A9858", Offset = "0x17A9858", VA = "0x17A9858")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x17A9888", Offset = "0x17A9888", VA = "0x17A9888")]
			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color GizmoTangentColor;

		[NonSerialized]
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Approximation;

		[NonSerialized]
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] ApproximationDistances;

		[NonSerialized]
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] ApproximationT;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE93EF8", Offset = "0xE93EF8")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE93F08", Offset = "0xE93F08")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93F18", Offset = "0xE93F18")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE93F18", Offset = "0xE93F18")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE93F18", Offset = "0xE93F18")]
		[SerializeField]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE93FD4", Offset = "0xE93FD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE93FD4", Offset = "0xE93FD4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE93FD4", Offset = "0xE93FD4")]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE940D0", Offset = "0xE940D0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE940D0", Offset = "0xE940D0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE940D0", Offset = "0xE940D0")]
		[SerializeField]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE941E0", Offset = "0xE941E0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE941E0", Offset = "0xE941E0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE941E0", Offset = "0xE941E0")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE94334", Offset = "0xE94334")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0xE94334", Offset = "0xE94334")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE94424", Offset = "0xE94424")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94424", Offset = "0xE94424")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE94520", Offset = "0xE94520")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94520", Offset = "0xE94520")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE945C8", Offset = "0xE945C8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE945C8", Offset = "0xE945C8")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE94670", Offset = "0xE94670")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0xE94670", Offset = "0xE94670")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0xE94670", Offset = "0xE94670")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94670", Offset = "0xE94670")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94670", Offset = "0xE94670")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE947F0", Offset = "0xE947F0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE947F0", Offset = "0xE947F0")]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE9487C", Offset = "0xE9487C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE9487C", Offset = "0xE9487C")]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE94908", Offset = "0xE94908")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94908", Offset = "0xE94908")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94978", Offset = "0xE94978")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94978", Offset = "0xE94978")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94978", Offset = "0xE94978")]
		private float m_StartTension;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94A88", Offset = "0xE94A88")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94A88", Offset = "0xE94A88")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94A88", Offset = "0xE94A88")]
		private float m_EndTension;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94BD4", Offset = "0xE94BD4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94BD4", Offset = "0xE94BD4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94BD4", Offset = "0xE94BD4")]
		private float m_StartContinuity;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94CE4", Offset = "0xE94CE4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94CE4", Offset = "0xE94CE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94CE4", Offset = "0xE94CE4")]
		private float m_EndContinuity;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94E30", Offset = "0xE94E30")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94E30", Offset = "0xE94E30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94E30", Offset = "0xE94E30")]
		private float m_StartBias;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE94F40", Offset = "0xE94F40")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE94F40", Offset = "0xE94F40")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE94F40", Offset = "0xE94F40")]
		private float m_EndBias;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncPosition;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncRotation;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int cacheSize;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 threadSafeLocalPosition;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion threadSafeLocalRotation;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CurvySpline mSpline;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float mStepSize;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Bounds? mBounds;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int mCacheLastDistanceToLocalFIndex;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<UnityEngine.Component> mMetaData;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 lastProcessedLocalPosition;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion lastProcessedLocalRotation;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		[Token(Token = "0x1700009D")]
		public bool AutoBakeOrientation
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x17A198C", Offset = "0x17A198C", VA = "0x17A198C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x17A1994", Offset = "0x17A1994", VA = "0x17A1994")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x17A19B4", Offset = "0x17A19B4", VA = "0x17A19B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x17A19BC", Offset = "0x17A19BC", VA = "0x17A19BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x17A1A28", Offset = "0x17A1A28", VA = "0x17A1A28")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x17A1A30", Offset = "0x17A1A30", VA = "0x17A1A30")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public float SwirlTurns
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x17A1A6C", Offset = "0x17A1A6C", VA = "0x17A1A6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x17A1A74", Offset = "0x17A1A74", VA = "0x17A1A74")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x17A1AAC", Offset = "0x17A1AAC", VA = "0x17A1AAC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x17A1AB8", Offset = "0x17A1AB8", VA = "0x17A1AB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x17A1BA0", Offset = "0x17A1BA0", VA = "0x17A1BA0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x17A1BAC", Offset = "0x17A1BAC", VA = "0x17A1BAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x17A1C94", Offset = "0x17A1C94", VA = "0x17A1C94")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x17A1DDC", Offset = "0x17A1DDC", VA = "0x17A1DDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x17A1ED0", Offset = "0x17A1ED0", VA = "0x17A1ED0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x17A2018", Offset = "0x17A2018", VA = "0x17A2018")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool AutoHandles
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x17A210C", Offset = "0x17A210C", VA = "0x17A210C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x17A2114", Offset = "0x17A2114", VA = "0x17A2114")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x17A22C0", Offset = "0x17A22C0", VA = "0x17A22C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x17A22C8", Offset = "0x17A22C8", VA = "0x17A22C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x17A2384", Offset = "0x17A2384", VA = "0x17A2384")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x17A238C", Offset = "0x17A238C", VA = "0x17A238C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x17A23D4", Offset = "0x17A23D4", VA = "0x17A23D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x17A23DC", Offset = "0x17A23DC", VA = "0x17A23DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x17A2424", Offset = "0x17A2424", VA = "0x17A2424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x17A242C", Offset = "0x17A242C", VA = "0x17A242C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x17A2474", Offset = "0x17A2474", VA = "0x17A2474")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x17A247C", Offset = "0x17A247C", VA = "0x17A247C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float StartTension
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x17A24C4", Offset = "0x17A24C4", VA = "0x17A24C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x17A24CC", Offset = "0x17A24CC", VA = "0x17A24CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public float StartContinuity
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x17A2504", Offset = "0x17A2504", VA = "0x17A2504")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x17A250C", Offset = "0x17A250C", VA = "0x17A250C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public float StartBias
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x17A2544", Offset = "0x17A2544", VA = "0x17A2544")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x17A254C", Offset = "0x17A254C", VA = "0x17A254C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float EndTension
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x17A2584", Offset = "0x17A2584", VA = "0x17A2584")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x17A258C", Offset = "0x17A258C", VA = "0x17A258C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public float EndContinuity
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x17A25C4", Offset = "0x17A25C4", VA = "0x17A25C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x17A25CC", Offset = "0x17A25CC", VA = "0x17A25CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public float EndBias
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x17A2604", Offset = "0x17A2604", VA = "0x17A2604")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x17A260C", Offset = "0x17A260C", VA = "0x17A260C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x17A2644", Offset = "0x17A2644", VA = "0x17A2644")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x17A264C", Offset = "0x17A264C", VA = "0x17A264C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x17A272C", Offset = "0x17A272C", VA = "0x17A272C")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x17A2734", Offset = "0x17A2734", VA = "0x17A2734")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x17A27F0", Offset = "0x17A27F0", VA = "0x17A27F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x17A27F8", Offset = "0x17A27F8", VA = "0x17A27F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x17A2818", Offset = "0x17A2818", VA = "0x17A2818")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x17A2820", Offset = "0x17A2820", VA = "0x17A2820")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x17A2840", Offset = "0x17A2840", VA = "0x17A2840")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x17A2848", Offset = "0x17A2848", VA = "0x17A2848")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public int CacheSize
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x17A2A04", Offset = "0x17A2A04", VA = "0x17A2A04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x17A2A0C", Offset = "0x17A2A0C", VA = "0x17A2A0C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public Bounds Bounds
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x17A2A14", Offset = "0x17A2A14", VA = "0x17A2A14")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000B8")]
		public float Length
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x17A2CAC", Offset = "0x17A2CAC", VA = "0x17A2CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DB90", Offset = "0xE9DB90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x17A2CB4", Offset = "0x17A2CB4", VA = "0x17A2CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DBA0", Offset = "0xE9DBA0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public float Distance
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x17A2CBC", Offset = "0x17A2CBC", VA = "0x17A2CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DBB0", Offset = "0xE9DBB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x17A2CC4", Offset = "0x17A2CC4", VA = "0x17A2CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DBC0", Offset = "0xE9DBC0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public float TF
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x17A2CCC", Offset = "0x17A2CCC", VA = "0x17A2CCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BB")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x17A2CF4", Offset = "0x17A2CF4", VA = "0x17A2CF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BC")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x17A2D24", Offset = "0x17A2D24", VA = "0x17A2D24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public List<UnityEngine.Component> MetaData
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x17A2D7C", Offset = "0x17A2D7C", VA = "0x17A2D7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x17A2E5C", Offset = "0x17A2E5C", VA = "0x17A2E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x17A2E64", Offset = "0x17A2E64", VA = "0x17A2E64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x17A2F28", Offset = "0x17A2F28", VA = "0x17A2F28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x17A2F70", Offset = "0x17A2F70", VA = "0x17A2F70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x17A6CD0", Offset = "0x17A6CD0", VA = "0x17A6CD0")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x17A6D5C", Offset = "0x17A6D5C", VA = "0x17A6D5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x17A6DF0", Offset = "0x17A6DF0", VA = "0x17A6DF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x17A6EF8", Offset = "0x17A6EF8", VA = "0x17A6EF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x17A3020", Offset = "0x17A3020", VA = "0x17A3020")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x17A3568", Offset = "0x17A3568", VA = "0x17A3568")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x17A3AB0", Offset = "0x17A3AB0", VA = "0x17A3AB0")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x17A3DE4", Offset = "0x17A3DE4", VA = "0x17A3DE4")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x17A2DAC", Offset = "0x17A2DAC", VA = "0x17A2DAC")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x17A3FF8", Offset = "0x17A3FF8", VA = "0x17A3FF8")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x17A40CC", Offset = "0x17A40CC", VA = "0x17A40CC")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x17A4160", Offset = "0x17A4160", VA = "0x17A4160")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x17A41B4", Offset = "0x17A41B4", VA = "0x17A41B4")]
		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x17A41D0", Offset = "0x17A41D0", VA = "0x17A41D0")]
		public Vector3 Interpolate(float localF, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x17A4B00", Offset = "0x17A4B00", VA = "0x17A4B00")]
		public Vector3 InterpolateFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x17A4D5C", Offset = "0x17A4D5C", VA = "0x17A4D5C")]
		public UnityEngine.Component GetMetaData(Type type, bool autoCreate = false)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		public T GetMetadata<T>(bool autoCreate = false) where T : UnityEngine.Component, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		public U InterpolateMetadata<T, U>(float f) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x17A4FD8", Offset = "0x17A4FD8", VA = "0x17A4FD8")]
		public object InterpolateMetadata(Type type, float f)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x17A514C", Offset = "0x17A514C", VA = "0x17A514C")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x17A51FC", Offset = "0x17A51FC", VA = "0x17A51FC")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x17A5364", Offset = "0x17A5364", VA = "0x17A5364")]
		public Vector3 GetTangent(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x17A5408", Offset = "0x17A5408", VA = "0x17A5408")]
		public Vector3 GetTangent(float localF, Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x17A5624", Offset = "0x17A5624", VA = "0x17A5624")]
		public Vector3 GetTangentFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x17A5788", Offset = "0x17A5788", VA = "0x17A5788")]
		public Quaternion GetOrientationFast(float localF)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x17A5790", Offset = "0x17A5790", VA = "0x17A5790")]
		public Quaternion GetOrientationFast(float localF, bool inverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x17A5930", Offset = "0x17A5930", VA = "0x17A5930")]
		public Vector3 GetOrientationUpFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x17A5A94", Offset = "0x17A5A94", VA = "0x17A5A94")]
		public float GetNearestPointF(Vector3 p)
		{
			return default(float);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x17A5CC0", Offset = "0x17A5CC0", VA = "0x17A5CC0")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x17A5E98", Offset = "0x17A5E98", VA = "0x17A5E98")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x17A2CD4", Offset = "0x17A2CD4", VA = "0x17A2CD4")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x17A5FC8", Offset = "0x17A5FC8", VA = "0x17A5FC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x17A6090", Offset = "0x17A6090", VA = "0x17A6090")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x17A4C64", Offset = "0x17A4C64", VA = "0x17A4C64")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x17A6370", Offset = "0x17A6370", VA = "0x17A6370")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x17A6378", Offset = "0x17A6378", VA = "0x17A6378")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x17A6380", Offset = "0x17A6380", VA = "0x17A6380")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x17A658C", Offset = "0x17A658C", VA = "0x17A658C")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x17A6138", Offset = "0x17A6138", VA = "0x17A6138")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x17A6798", Offset = "0x17A6798", VA = "0x17A6798")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x17A69D0", Offset = "0x17A69D0", VA = "0x17A69D0", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x17A6ABC", Offset = "0x17A6ABC", VA = "0x17A6ABC", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x17A6BF0", Offset = "0x17A6BF0", VA = "0x17A6BF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x17A6BF4", Offset = "0x17A6BF4", VA = "0x17A6BF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x17A6BF8", Offset = "0x17A6BF8", VA = "0x17A6BF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x17A6C5C", Offset = "0x17A6C5C", VA = "0x17A6C5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x17A6C94", Offset = "0x17A6C94", VA = "0x17A6C94")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x17A6CCC", Offset = "0x17A6CCC", VA = "0x17A6CCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x17A6AC0", Offset = "0x17A6AC0", VA = "0x17A6AC0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x17A6FF8", Offset = "0x17A6FF8", VA = "0x17A6FF8")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x17A700C", Offset = "0x17A700C", VA = "0x17A700C")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x17A6C30", Offset = "0x17A6C30", VA = "0x17A6C30")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x17A2904", Offset = "0x17A2904", VA = "0x17A2904")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x17A2160", Offset = "0x17A2160", VA = "0x17A2160")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x17A5CB0", Offset = "0x17A5CB0", VA = "0x17A5CB0")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x17A4980", Offset = "0x17A4980", VA = "0x17A4980")]
		private Vector3 interpolateLinear(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x17A42F4", Offset = "0x17A42F4", VA = "0x17A42F4")]
		private Vector3 interpolateBezier(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x17A44B0", Offset = "0x17A44B0", VA = "0x17A44B0")]
		private Vector3 interpolateCatmull(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x17A46D8", Offset = "0x17A46D8", VA = "0x17A46D8")]
		private Vector3 interpolateTCB(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x17A7014", Offset = "0x17A7014", VA = "0x17A7014")]
		internal void refreshCurveINTERNAL(CurvyInterpolation splineInterpolation, bool isControlPointASegment, CurvySpline spline)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x17A76E0", Offset = "0x17A76E0", VA = "0x17A76E0")]
		private float InterpolateBezierSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x17A804C", Offset = "0x17A804C", VA = "0x17A804C")]
		private float InterpolateTCBSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x17A7B64", Offset = "0x17A7B64", VA = "0x17A7B64")]
		private float InterpolateCatmullSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x17A86BC", Offset = "0x17A86BC", VA = "0x17A86BC")]
		private float InterpolateLinearSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x17A89A0", Offset = "0x17A89A0", VA = "0x17A89A0")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x17A16BC", Offset = "0x17A16BC", VA = "0x17A16BC")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x17A8CAC", Offset = "0x17A8CAC", VA = "0x17A8CAC")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x17A8EE4", Offset = "0x17A8EE4", VA = "0x17A8EE4")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x17A89E4", Offset = "0x17A89E4", VA = "0x17A89E4")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x17A8B14", Offset = "0x17A8B14", VA = "0x17A8B14")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x17A8EF8", Offset = "0x17A8EF8", VA = "0x17A8EF8")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x17A8F08", Offset = "0x17A8F08", VA = "0x17A8F08")]
		private bool SnapToFitSplineLength(float newSplineLength, float stepSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x17A9338", Offset = "0x17A9338", VA = "0x17A9338")]
		internal void PrepareThreadSafeTransfromINTERNAL()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x17A938C", Offset = "0x17A938C", VA = "0x17A938C")]
		public CurvySplineSegment()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public static class CurvySplineSegmentDefaultValues
	{
		[Token(Token = "0x40001BF")]
		public const CurvyOrientationSwirl Swirl = CurvyOrientationSwirl.None;

		[Token(Token = "0x40001C0")]
		public const bool AutoHandles = true;

		[Token(Token = "0x40001C1")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 HandleIn;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector3 HandleOut;
	}
	[Token(Token = "0x2000095")]
	public static class CurvySplineDefaultValues
	{
		[Token(Token = "0x40001C4")]
		public const bool AutoEndTangents = true;

		[Token(Token = "0x40001C5")]
		public const CurvyOrientation Orientation = CurvyOrientation.Dynamic;

		[Token(Token = "0x40001C6")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x40001C7")]
		public const int CacheDensity = 50;

		[Token(Token = "0x40001C8")]
		public const float MaxPointsPerUnit = 8f;

		[Token(Token = "0x40001C9")]
		public const bool UsePooling = true;

		[Token(Token = "0x40001CA")]
		public const CurvyUpdateMethod UpdateIn = CurvyUpdateMethod.Update;

		[Token(Token = "0x40001CB")]
		public const bool CheckTransform = true;
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE910B4", Offset = "0xE910B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE910B4", Offset = "0xE910B4")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x17A9978", Offset = "0x17A9978", VA = "0x17A9978")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x17A9AEC", Offset = "0x17A9AEC", VA = "0x17A9AEC", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x17A9AA8", Offset = "0x17A9AA8", VA = "0x17A9AA8")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x17A9B14", Offset = "0x17A9B14", VA = "0x17A9B14")]
		public CurvyUISpline()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x2000097")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x200014A")]
		public class Node
		{
			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x17000261")]
			public TValue Key
			{
				[Token(Token = "0x6000B38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000262")]
			public Node Prev
			{
				[Token(Token = "0x6000B39")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000263")]
			public Node Next
			{
				[Token(Token = "0x6000B3A")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B3B")]
			public Node()
			{
			}
		}

		[Token(Token = "0x200014B")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x600050B")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x600050C")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x2000098")]
	internal static class Geom
	{
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1908D5C", Offset = "0x1908D5C", VA = "0x1908D5C")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1908E38", Offset = "0x1908E38", VA = "0x1908E38")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1908E8C", Offset = "0x1908E8C", VA = "0x1908E8C")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1908ED0", Offset = "0x1908ED0", VA = "0x1908ED0")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1908F20", Offset = "0x1908F20", VA = "0x1908F20")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1908F94", Offset = "0x1908F94", VA = "0x1908F94")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1908FF8", Offset = "0x1908FF8", VA = "0x1908FF8")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1909048", Offset = "0x1909048", VA = "0x1909048")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x19090BC", Offset = "0x19090BC", VA = "0x19090BC")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1909120", Offset = "0x1909120", VA = "0x1909120")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1909168", Offset = "0x1909168", VA = "0x1909168")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1909190", Offset = "0x1909190", VA = "0x1909190")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x190922C", Offset = "0x190922C", VA = "0x190922C")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1909278", Offset = "0x1909278", VA = "0x1909278")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x19092D4", Offset = "0x19092D4", VA = "0x19092D4")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x19092E8", Offset = "0x19092E8", VA = "0x19092E8")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x2000099")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1909648", Offset = "0x1909648", VA = "0x1909648")]
		public LTMesh()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x19097A0", Offset = "0x19097A0", VA = "0x19097A0", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x19097AC", Offset = "0x19097AC", VA = "0x19097AC", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x19098AC", Offset = "0x19098AC", VA = "0x19098AC")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1909AD8", Offset = "0x1909AD8", VA = "0x1909AD8")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1909D14", Offset = "0x1909D14", VA = "0x1909D14")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1909F0C", Offset = "0x1909F0C", VA = "0x1909F0C")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1909F80", Offset = "0x1909F80", VA = "0x1909F80")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x190A074", Offset = "0x190A074", VA = "0x190A074")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x190A144", Offset = "0x190A144", VA = "0x190A144")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x190A270", Offset = "0x190A270", VA = "0x190A270")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x190A440", Offset = "0x190A440", VA = "0x190A440")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xE9DBD0", Offset = "0xE9DBD0")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE91140", Offset = "0xE91140")]
	public struct Vec3
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x170000C6")]
		public float Item
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xFC1658", Offset = "0xFC1658", VA = "0xFC1658")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0xFC1660", Offset = "0xFC1660", VA = "0xFC1660")]
			set
			{
			}
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x13C7CB4", Offset = "0x13C7CB4", VA = "0x13C7CB4")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x13C7CE8", Offset = "0x13C7CE8", VA = "0x13C7CE8")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x13C7D04", Offset = "0x13C7D04", VA = "0x13C7D04")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x13C7D30", Offset = "0x13C7D30", VA = "0x13C7D30")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x13C7DE8", Offset = "0x13C7DE8", VA = "0x13C7DE8")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xFC1668", Offset = "0xFC1668", VA = "0xFC1668", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009B")]
	internal static class MeshUtils
	{
		[Token(Token = "0x200014C")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x6000B40")]
			public abstract void Reset();

			[Token(Token = "0x6000B41")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x6000B42")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x6000B43")]
			public void Free()
			{
			}

			[Token(Token = "0x6000B44")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x200014D")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x190A7DC", Offset = "0x190A7DC", VA = "0x190A7DC", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x190A868", Offset = "0x190A868", VA = "0x190A868")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x200014E")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x17000264")]
			internal int VertsCount
			{
				[Token(Token = "0x6000B47")]
				[Address(RVA = "0x190A3F0", Offset = "0x190A3F0", VA = "0x190A3F0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x190A77C", Offset = "0x190A77C", VA = "0x190A77C", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x190A78C", Offset = "0x190A78C", VA = "0x190A78C")]
			public Face()
			{
			}
		}

		[Token(Token = "0x200014F")]
		public struct EdgePair
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x190972C", Offset = "0x190972C", VA = "0x190972C")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0xFD4A58", Offset = "0xFD4A58", VA = "0xFD4A58")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000150")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x17000265")]
			internal Face _Rface
			{
				[Token(Token = "0x6000B4C")]
				[Address(RVA = "0x1909E38", Offset = "0x1909E38", VA = "0x1909E38")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B4D")]
				[Address(RVA = "0x190A058", Offset = "0x190A058", VA = "0x190A058")]
				set
				{
				}
			}

			[Token(Token = "0x17000266")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000B4E")]
				[Address(RVA = "0x190914C", Offset = "0x190914C", VA = "0x190914C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B4F")]
				[Address(RVA = "0x190A03C", Offset = "0x190A03C", VA = "0x190A03C")]
				set
				{
				}
			}

			[Token(Token = "0x17000267")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000B50")]
				[Address(RVA = "0x1909E54", Offset = "0x1909E54", VA = "0x1909E54")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B51")]
				[Address(RVA = "0x190A5BC", Offset = "0x190A5BC", VA = "0x190A5BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000268")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000B52")]
				[Address(RVA = "0x190A424", Offset = "0x190A424", VA = "0x190A424")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B53")]
				[Address(RVA = "0x190A5D8", Offset = "0x190A5D8", VA = "0x190A5D8")]
				set
				{
				}
			}

			[Token(Token = "0x17000269")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000B54")]
				[Address(RVA = "0x190A5F4", Offset = "0x190A5F4", VA = "0x190A5F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B55")]
				[Address(RVA = "0x190A610", Offset = "0x190A610", VA = "0x190A610")]
				set
				{
				}
			}

			[Token(Token = "0x1700026A")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000B56")]
				[Address(RVA = "0x190A62C", Offset = "0x190A62C", VA = "0x190A62C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B57")]
				[Address(RVA = "0x190A648", Offset = "0x190A648", VA = "0x190A648")]
				set
				{
				}
			}

			[Token(Token = "0x1700026B")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000B58")]
				[Address(RVA = "0x190A664", Offset = "0x190A664", VA = "0x190A664")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B59")]
				[Address(RVA = "0x190A68C", Offset = "0x190A68C", VA = "0x190A68C")]
				set
				{
				}
			}

			[Token(Token = "0x1700026C")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0x190A6B4", Offset = "0x190A6B4", VA = "0x190A6B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5B")]
				[Address(RVA = "0x190A6DC", Offset = "0x190A6DC", VA = "0x190A6DC")]
				set
				{
				}
			}

			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x190A528", Offset = "0x190A528", VA = "0x190A528")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x190A704", Offset = "0x190A704", VA = "0x190A704", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x190A72C", Offset = "0x190A72C", VA = "0x190A72C")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x40001D6")]
		public const int Undef = -1;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1909900", Offset = "0x1909900", VA = "0x1909900")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1909CC8", Offset = "0x1909CC8", VA = "0x1909CC8")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1909994", Offset = "0x1909994", VA = "0x1909994")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1909A30", Offset = "0x1909A30", VA = "0x1909A30")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1909E70", Offset = "0x1909E70", VA = "0x1909E70")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1909B98", Offset = "0x1909B98", VA = "0x1909B98")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1909C30", Offset = "0x1909C30", VA = "0x1909C30")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x190A558", Offset = "0x190A558", VA = "0x190A558")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200009C")]
	internal struct PQHandle
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x200009D")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x2000151")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x2000152")]
		protected class HandleElem
		{
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x6000B63")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000C7")]
		public bool Empty
		{
			[Token(Token = "0x600053F")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000540")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000541")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x6000542")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x6000543")]
		public void Init()
		{
		}

		[Token(Token = "0x6000544")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000545")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x200009E")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x2000153")]
		private class StackItem
		{
			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000B64")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000C8")]
		public bool Empty
		{
			[Token(Token = "0x6000548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000549")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x600054A")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x600054B")]
		public void Init()
		{
		}

		[Token(Token = "0x600054C")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x600054D")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class Tess
	{
		[Token(Token = "0x2000154")]
		internal class ActiveRegion
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x13C7754", Offset = "0x13C7754", VA = "0x13C7754")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x170000C9")]
		public Vec3 Normal
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x190CC4C", Offset = "0x190CC4C", VA = "0x190CC4C")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x190CC58", Offset = "0x190CC58", VA = "0x190CC58")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x190CC64", Offset = "0x190CC64", VA = "0x190CC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public int VertexCount
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x190CC6C", Offset = "0x190CC6C", VA = "0x190CC6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CC")]
		public int[] Elements
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x190CC74", Offset = "0x190CC74", VA = "0x190CC74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public int ElementCount
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x190CC7C", Offset = "0x190CC7C", VA = "0x190CC7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x190A90C", Offset = "0x190A90C", VA = "0x190A90C")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x190A938", Offset = "0x190A938", VA = "0x190A938")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x190A964", Offset = "0x190A964", VA = "0x190A964")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x190AA78", Offset = "0x190AA78", VA = "0x190AA78")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x190AAF0", Offset = "0x190AAF0", VA = "0x190AAF0")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x190AB38", Offset = "0x190AB38", VA = "0x190AB38")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x190ABF8", Offset = "0x190ABF8", VA = "0x190ABF8")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x190AC58", Offset = "0x190AC58", VA = "0x190AC58")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x190AD0C", Offset = "0x190AD0C", VA = "0x190AD0C")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x190AD64", Offset = "0x190AD64", VA = "0x190AD64")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x190AD98", Offset = "0x190AD98", VA = "0x190AD98")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x190AECC", Offset = "0x190AECC", VA = "0x190AECC")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x190B458", Offset = "0x190B458", VA = "0x190B458")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x190B470", Offset = "0x190B470", VA = "0x190B470")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x190B56C", Offset = "0x190B56C", VA = "0x190B56C")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x190B08C", Offset = "0x190B08C", VA = "0x190B08C")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x190B7E4", Offset = "0x190B7E4", VA = "0x190B7E4")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x190B954", Offset = "0x190B954", VA = "0x190B954")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x190B228", Offset = "0x190B228", VA = "0x190B228")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x190BF40", Offset = "0x190BF40", VA = "0x190BF40")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x190C140", Offset = "0x190C140", VA = "0x190C140")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x190C328", Offset = "0x190C328", VA = "0x190C328")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x190C250", Offset = "0x190C250", VA = "0x190C250")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x190C548", Offset = "0x190C548", VA = "0x190C548")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x190C660", Offset = "0x190C660", VA = "0x190C660")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x190C72C", Offset = "0x190C72C", VA = "0x190C72C")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x190C7A8", Offset = "0x190C7A8", VA = "0x190C7A8")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x190C8EC", Offset = "0x190C8EC", VA = "0x190C8EC")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x190CAA8", Offset = "0x190CAA8", VA = "0x190CAA8")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x190CAB0", Offset = "0x190CAB0", VA = "0x190CAB0")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x190CB48", Offset = "0x190CB48", VA = "0x190CB48")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x190CC84", Offset = "0x190CC84", VA = "0x190CC84")]
		public Tess()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x190CD38", Offset = "0x190CD38", VA = "0x190CD38")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x190D36C", Offset = "0x190D36C", VA = "0x190D36C")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x190D484", Offset = "0x190D484", VA = "0x190D484")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x190D788", Offset = "0x190D788", VA = "0x190D788")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x190D978", Offset = "0x190D978", VA = "0x190D978")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x190D9E4", Offset = "0x190D9E4", VA = "0x190D9E4")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x190DA4C", Offset = "0x190DA4C", VA = "0x190DA4C")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x190DB1C", Offset = "0x190DB1C", VA = "0x190DB1C")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x190DB58", Offset = "0x190DB58", VA = "0x190DB58")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x190DF8C", Offset = "0x190DF8C", VA = "0x190DF8C")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x190E1A0", Offset = "0x190E1A0", VA = "0x190E1A0")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x190E240", Offset = "0x190E240", VA = "0x190E240")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x190E248", Offset = "0x190E248", VA = "0x190E248")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x190E418", Offset = "0x190E418", VA = "0x190E418")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x190E420", Offset = "0x190E420", VA = "0x190E420")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public enum WindingRule
	{
		[Token(Token = "0x40001FE")]
		EvenOdd,
		[Token(Token = "0x40001FF")]
		NonZero,
		[Token(Token = "0x4000200")]
		Positive,
		[Token(Token = "0x4000201")]
		Negative,
		[Token(Token = "0x4000202")]
		AbsGeqTwo
	}
	[Token(Token = "0x20000A1")]
	public enum ElementType
	{
		[Token(Token = "0x4000204")]
		Polygons,
		[Token(Token = "0x4000205")]
		ConnectedPolygons,
		[Token(Token = "0x4000206")]
		BoundaryContours
	}
	[Token(Token = "0x20000A2")]
	public enum ContourOrientation
	{
		[Token(Token = "0x4000208")]
		Original,
		[Token(Token = "0x4000209")]
		Clockwise,
		[Token(Token = "0x400020A")]
		CounterClockwise
	}
	[Token(Token = "0x20000A3")]
	public struct ContourVertex
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xFD4A14", Offset = "0xFD4A14", VA = "0xFD4A14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A4")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x20000A5")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x190A510", Offset = "0x190A510", VA = "0x190A510")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x190A514", Offset = "0x190A514", VA = "0x190A514")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x20000A6")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x190A4DC", Offset = "0x190A4DC", VA = "0x190A4DC")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000A7")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x13C775C", Offset = "0x13C775C", VA = "0x13C775C")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x13C7850", Offset = "0x13C7850", VA = "0x13C7850")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x13C78D0", Offset = "0x13C78D0", VA = "0x13C78D0")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x13C7A1C", Offset = "0x13C7A1C", VA = "0x13C7A1C")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ImportExport
{
	[Token(Token = "0x20000A8")]
	public enum CurvySerializationSpace
	{
		[Token(Token = "0x400020E")]
		Global,
		[Token(Token = "0x400020F")]
		Local
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class SerializedCurvySpline
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CurvyInterpolation Interpolation;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool RestrictTo2D;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool Closed;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool AutoEndTangents;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CurvyOrientation Orientation;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float AutoHandleDistance;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int CacheDensity;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxPointsPerUnit;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UsePooling;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool UseThreading;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool CheckTransform;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SerializedCurvySplineSegment[] ControlPoints;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1905658", Offset = "0x1905658", VA = "0x1905658")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1905718", Offset = "0x1905718", VA = "0x1905718")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1905A88", Offset = "0x1905A88", VA = "0x1905A88")]
		public void WriteIntoSpline([NotNull] CurvySpline deserializedSpline, CurvySerializationSpace space)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class SerializedCurvySplineSegment
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool AutoBakeOrientation;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool OrientationAnchor;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CurvyOrientationSwirl Swirl;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float SwirlTurns;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AutoHandles;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AutoHandleDistance;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 HandleOut;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 HandleIn;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1905F18", Offset = "0x1905F18", VA = "0x1905F18")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x190597C", Offset = "0x190597C", VA = "0x190597C")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1905D30", Offset = "0x1905D30", VA = "0x1905D30")]
		public void WriteIntoControlPoint([NotNull] CurvySplineSegment controlPoint, CurvySerializationSpace space)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Controllers
{
	[Token(Token = "0x20000AB")]
	public abstract class ConnectedControlPointsSelector : MonoBehaviour
	{
		[Token(Token = "0x6000597")]
		public abstract CurvySplineSegment SelectConnectedControlPoint(SplineController caller, CurvyConnection connection, CurvySplineSegment currentControlPoint);

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x17F8CDC", Offset = "0x17F8CDC", VA = "0x17F8CDC")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x17F8CE4", Offset = "0x17F8CE4", VA = "0x17F8CE4")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvyController Controller;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x17FB2A0", Offset = "0x17FB2A0", VA = "0x17FB2A0")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x17FB34C", Offset = "0x17FB34C", VA = "0x17FB34C")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE951A4", Offset = "0xE951A4")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE951B4", Offset = "0xE951B4")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE951C4", Offset = "0xE951C4")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE951D4", Offset = "0xE951D4")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE951E4", Offset = "0xE951E4")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE951F4", Offset = "0xE951F4")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE95204", Offset = "0xE95204")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170000CE")]
		public SplineController Sender
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x17FB39C", Offset = "0x17FB39C", VA = "0x17FB39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC38", Offset = "0xE9DC38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x17FB3A4", Offset = "0x17FB3A4", VA = "0x17FB3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC48", Offset = "0xE9DC48")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x17FB3AC", Offset = "0x17FB3AC", VA = "0x17FB3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC58", Offset = "0xE9DC58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x17FB3B4", Offset = "0x17FB3B4", VA = "0x17FB3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC68", Offset = "0xE9DC68")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x17FB3BC", Offset = "0x17FB3BC", VA = "0x17FB3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC78", Offset = "0xE9DC78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x17FB3C4", Offset = "0x17FB3C4", VA = "0x17FB3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC88", Offset = "0xE9DC88")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public bool WorldUnits
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x17FB3CC", Offset = "0x17FB3CC", VA = "0x17FB3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DC98", Offset = "0xE9DC98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x17FB3D4", Offset = "0x17FB3D4", VA = "0x17FB3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DCA8", Offset = "0xE9DCA8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x17FB3E0", Offset = "0x17FB3E0", VA = "0x17FB3E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DCB8", Offset = "0xE9DCB8")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x17FB3E8", Offset = "0x17FB3E8", VA = "0x17FB3E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DCC8", Offset = "0xE9DCC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public float Delta
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x17FB3F0", Offset = "0x17FB3F0", VA = "0x17FB3F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DCD8", Offset = "0xE9DCD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x17FB3F8", Offset = "0x17FB3F8", VA = "0x17FB3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DCE8", Offset = "0xE9DCE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public float Position
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x17FB400", Offset = "0x17FB400", VA = "0x17FB400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DCF8", Offset = "0xE9DCF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x17FB408", Offset = "0x17FB408", VA = "0x17FB408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD08", Offset = "0xE9DD08")]
			private set
			{
			}
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x17FB410", Offset = "0x17FB410", VA = "0x17FB410")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x17FB484", Offset = "0x17FB484", VA = "0x17FB484")]
		internal void Set_INTERNAL(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, float delta, MovementDirection direction, bool usingWorldUnits)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[ExecuteInEditMode]
	public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000155")]
		public enum MoveModeEnum
		{
			[Token(Token = "0x400056D")]
			Relative,
			[Token(Token = "0x400056E")]
			AbsolutePrecise
		}

		[Token(Token = "0x2000156")]
		public enum CurvyControllerState
		{
			[Token(Token = "0x4000570")]
			Stopped,
			[Token(Token = "0x4000571")]
			Playing,
			[Token(Token = "0x4000572")]
			Paused
		}

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE95214", Offset = "0xE95214")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE95214", Offset = "0xE95214")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE95298", Offset = "0xE95298")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE95310", Offset = "0xE95310")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE95310", Offset = "0xE95310")]
		protected float m_Position;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE953BC", Offset = "0xE953BC")]
		[SerializeField]
		private MoveModeEnum m_MoveMode;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MovementDirection m_Direction;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyClamping m_Clamping;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE95484", Offset = "0xE95484")]
		private bool m_PlayAutomatically;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE954D0", Offset = "0xE954D0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE954D0", Offset = "0xE954D0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE954D0", Offset = "0xE954D0")]
		[SerializeField]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE95610", Offset = "0xE95610")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE95678", Offset = "0xE95678")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE95678", Offset = "0xE95678")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE957AC", Offset = "0xE957AC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE957AC", Offset = "0xE957AC")]
		[SerializeField]
		private bool m_IgnoreDirection;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xE958CC", Offset = "0xE958CC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE958CC", Offset = "0xE958CC")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xE959C8", Offset = "0xE959C8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE959C8", Offset = "0xE959C8")]
		[SerializeField]
		private float m_DampingUp;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE95AC4", Offset = "0xE95AC4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE95AC4", Offset = "0xE95AC4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE95AC4", Offset = "0xE95AC4")]
		[SerializeField]
		private float m_OffsetAngle;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE95C50", Offset = "0xE95C50")]
		[SerializeField]
		private float m_OffsetRadius;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE95D4C", Offset = "0xE95D4C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE95D4C", Offset = "0xE95D4C")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE95E80", Offset = "0xE95E80")]
		[SerializeField]
		private ControllerEvent onInitialized;

		[Token(Token = "0x4000244")]
		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE95EE0", Offset = "0xE95EE0")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private CurvyControllerState state;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 directionDampingVelocity;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 upDampingVelocity;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float prePlayPosition;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion lockedRotation;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private MovementDirection prePlayDirection;

		[Token(Token = "0x170000D5")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x17F8D34", Offset = "0x17F8D34", VA = "0x17F8D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x17F8D3C", Offset = "0x17F8D3C", VA = "0x17F8D3C")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x17F8D44", Offset = "0x17F8D44", VA = "0x17F8D44")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x17F8D4C", Offset = "0x17F8D4C", VA = "0x17F8D4C")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x17F8D54", Offset = "0x17F8D54", VA = "0x17F8D54")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x17F8D68", Offset = "0x17F8D68", VA = "0x17F8D68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x17F8D70", Offset = "0x17F8D70", VA = "0x17F8D70")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x17F8D90", Offset = "0x17F8D90", VA = "0x17F8D90")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x17F8D98", Offset = "0x17F8D98", VA = "0x17F8D98")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x17F8DAC", Offset = "0x17F8DAC", VA = "0x17F8DAC")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x17F8DB4", Offset = "0x17F8DB4", VA = "0x17F8DB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public bool LockRotation
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x17F8DC8", Offset = "0x17F8DC8", VA = "0x17F8DC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x17F8DD0", Offset = "0x17F8DD0", VA = "0x17F8DD0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x17F8E38", Offset = "0x17F8E38", VA = "0x17F8E38")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x17F8E40", Offset = "0x17F8E40", VA = "0x17F8E40")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x17F8E54", Offset = "0x17F8E54", VA = "0x17F8E54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x17F8E5C", Offset = "0x17F8E5C", VA = "0x17F8E5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public float UpDampingTime
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x17F8EE8", Offset = "0x17F8EE8", VA = "0x17F8EE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x17F8EF0", Offset = "0x17F8EF0", VA = "0x17F8EF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x17F8F7C", Offset = "0x17F8F7C", VA = "0x17F8F7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x17F8F84", Offset = "0x17F8F84", VA = "0x17F8F84")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public float OffsetAngle
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x17F8FA4", Offset = "0x17F8FA4", VA = "0x17F8FA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x17F8FAC", Offset = "0x17F8FAC", VA = "0x17F8FAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public float OffsetRadius
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x17F8FC0", Offset = "0x17F8FC0", VA = "0x17F8FC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x17F8FC8", Offset = "0x17F8FC8", VA = "0x17F8FC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x17F8FDC", Offset = "0x17F8FDC", VA = "0x17F8FDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x17F8FE4", Offset = "0x17F8FE4", VA = "0x17F8FE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public float Speed
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x17F8FF0", Offset = "0x17F8FF0", VA = "0x17F8FF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x17F8FF8", Offset = "0x17F8FF8", VA = "0x17F8FF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public float RelativePosition
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x17F900C", Offset = "0x17F900C", VA = "0x17F900C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x17F91F8", Offset = "0x17F91F8", VA = "0x17F91F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public float AbsolutePosition
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x17F92F0", Offset = "0x17F92F0", VA = "0x17F92F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x17F9420", Offset = "0x17F9420", VA = "0x17F9420")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public float Position
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x17F94F0", Offset = "0x17F94F0", VA = "0x17F94F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x17F9584", Offset = "0x17F9584", VA = "0x17F9584")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x17F9630", Offset = "0x17F9630", VA = "0x17F9630")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x17F9638", Offset = "0x17F9638", VA = "0x17F9638")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x17F9640", Offset = "0x17F9640", VA = "0x17F9640")]
			get
			{
				return default(CurvyControllerState);
			}
		}

		[Token(Token = "0x170000E9")]
		public abstract bool IsReady
		{
			[Token(Token = "0x60005D2")]
			get;
		}

		[Token(Token = "0x170000EA")]
		protected bool isInitialized
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x17F9648", Offset = "0x17F9648", VA = "0x17F9648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD18", Offset = "0xE9DD18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x17F9650", Offset = "0x17F9650", VA = "0x17F9650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD28", Offset = "0xE9DD28")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public virtual Transform Transform
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x17F99D0", Offset = "0x17F99D0", VA = "0x17F99D0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x17FA9C4", Offset = "0x17FA9C4", VA = "0x17FA9C4", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x17FA9CC", Offset = "0x17FA9CC", VA = "0x17FA9CC", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public abstract float Length
		{
			[Token(Token = "0x60005EA")]
			get;
		}

		[Token(Token = "0x170000EF")]
		private float TimeSinceLastUpdate
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x17F97F0", Offset = "0x17F97F0", VA = "0x17F97F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F0")]
		private float maxPosition
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x17FB11C", Offset = "0x17FB11C", VA = "0x17FB11C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x17F965C", Offset = "0x17F965C", VA = "0x17F965C", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x17F96C4", Offset = "0x17F96C4", VA = "0x17F96C4", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x17F97A0", Offset = "0x17F97A0", VA = "0x17F97A0", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x17F97BC", Offset = "0x17F97BC", VA = "0x17F97BC", Slot = "11")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x17F98A8", Offset = "0x17F98A8", VA = "0x17F98A8", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x17F9900", Offset = "0x17F9900", VA = "0x17F9900", Slot = "13")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x17F9938", Offset = "0x17F9938", VA = "0x17F9938", Slot = "14")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x17F99D8", Offset = "0x17F99D8", VA = "0x17F99D8", Slot = "16")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x17FA068", Offset = "0x17FA068", VA = "0x17FA068", Slot = "17")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x17FA5B8", Offset = "0x17FA5B8", VA = "0x17FA5B8")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x17FA874", Offset = "0x17FA874", VA = "0x17FA874", Slot = "18")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x17FA95C", Offset = "0x17FA95C", VA = "0x17FA95C", Slot = "19")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x17FA98C", Offset = "0x17FA98C", VA = "0x17FA98C", Slot = "20")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x17FA990", Offset = "0x17FA990", VA = "0x17FA990", Slot = "21")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x17FA994", Offset = "0x17FA994", VA = "0x17FA994", Slot = "22")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x17FA9A8", Offset = "0x17FA9A8", VA = "0x17FA9A8", Slot = "23")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x17FA9BC", Offset = "0x17FA9BC", VA = "0x17FA9BC", Slot = "24")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x17FA9C0", Offset = "0x17FA9C0", VA = "0x17FA9C0", Slot = "25")]
		protected virtual void UserAfterUpdate()
		{
		}

		[Token(Token = "0x60005EB")]
		protected abstract void Advance(float speed, float deltaTime);

		[Token(Token = "0x60005EC")]
		protected abstract void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime);

		[Token(Token = "0x60005ED")]
		protected abstract float AbsoluteToRelative(float worldUnitDistance);

		[Token(Token = "0x60005EE")]
		protected abstract float RelativeToAbsolute(float relativeDistance);

		[Token(Token = "0x60005EF")]
		protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

		[Token(Token = "0x60005F0")]
		protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

		[Token(Token = "0x60005F1")]
		protected abstract Vector3 GetOrientation(float tf);

		[Token(Token = "0x60005F2")]
		protected abstract Vector3 GetTangent(float tf);

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x17F9760", Offset = "0x17F9760", VA = "0x17F9760")]
		public void Play()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x17FA9D4", Offset = "0x17FA9D4", VA = "0x17FA9D4")]
		public void Stop()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x17FAA10", Offset = "0x17FAA10", VA = "0x17FAA10")]
		public void Pause()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x17FAA28", Offset = "0x17FAA28", VA = "0x17FAA28")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x17F97F8", Offset = "0x17F97F8", VA = "0x17F97F8")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x17FAA30", Offset = "0x17FAA30", VA = "0x17FAA30")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x17FAAC4", Offset = "0x17FAAC4", VA = "0x17FAAC4")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x17FAB80", Offset = "0x17FAB80", VA = "0x17FAB80")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x17FA744", Offset = "0x17FA744", VA = "0x17FA744")]
		private static Vector3 ApplyOffset(Vector3 pos, Vector3 tan, Vector3 up, float angle, float radius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x17F9130", Offset = "0x17F9130", VA = "0x17F9130")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x17F9DE4", Offset = "0x17F9DE4", VA = "0x17F9DE4")]
		private float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x17FB1D4", Offset = "0x17FB1D4", VA = "0x17FB1D4", Slot = "37")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x17FB278", Offset = "0x17FB278", VA = "0x17FB278", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x17FB27C", Offset = "0x17FB27C", VA = "0x17FB27C")]
		protected CurvyController()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public enum MovementDirection
	{
		[Token(Token = "0x400024D")]
		Forward,
		[Token(Token = "0x400024E")]
		Backward
	}
	[Token(Token = "0x20000B2")]
	public static class MovementDirectionMethods
	{
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x17FB4A4", Offset = "0x17FB4A4", VA = "0x17FB4A4")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x17FB4AC", Offset = "0x17FB4AC", VA = "0x17FB4AC")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x17FB534", Offset = "0x17FB534", VA = "0x17FB534")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE911B8", Offset = "0xE911B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE911B8", Offset = "0xE911B8")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE95EF0", Offset = "0xE95EF0")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0xE95EF0", Offset = "0xE95EF0")]
		private CGDataReference m_Path;

		[Token(Token = "0x170000F1")]
		public CGDataReference Path
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x17FB5BC", Offset = "0x17FB5BC", VA = "0x17FB5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x17FB5C4", Offset = "0x17FB5C4", VA = "0x17FB5C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public CGPath PathData
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x17FB5CC", Offset = "0x17FB5CC", VA = "0x17FB5CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		public override float Length
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x17FB644", Offset = "0x17FB644", VA = "0x17FB644", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F4")]
		public override bool IsReady
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x17FB684", Offset = "0x17FB684", VA = "0x17FB684", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x17FB6D4", Offset = "0x17FB6D4", VA = "0x17FB6D4", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x17FB730", Offset = "0x17FB730", VA = "0x17FB730", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x17FB78C", Offset = "0x17FB78C", VA = "0x17FB78C", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x17FB800", Offset = "0x17FB800", VA = "0x17FB800", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x17FB8D8", Offset = "0x17FB8D8", VA = "0x17FB8D8", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x17FB94C", Offset = "0x17FB94C", VA = "0x17FB94C", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x17FB9C0", Offset = "0x17FB9C0", VA = "0x17FB9C0", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x17FBA34", Offset = "0x17FBA34", VA = "0x17FBA34", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x17FBB44", Offset = "0x17FBB44", VA = "0x17FBB44")]
		public PathController()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public enum SplineControllerConnectionBehavior
	{
		[Token(Token = "0x4000251")]
		CurrentSpline,
		[Token(Token = "0x4000252")]
		FollowUpSpline,
		[Token(Token = "0x4000253")]
		RandomSpline,
		[Token(Token = "0x4000254")]
		FollowUpOtherwiseRandom,
		[Token(Token = "0x4000255")]
		Custom
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE9121C", Offset = "0xE9121C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9121C", Offset = "0xE9121C")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE95FAC", Offset = "0xE95FAC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE95FAC", Offset = "0xE95FAC")]
		[SerializeField]
		protected CurvySpline m_Spline;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE96058", Offset = "0xE96058")]
		private bool m_UseCache;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE960A4", Offset = "0xE960A4")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE960A4", Offset = "0xE960A4")]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE9614C", Offset = "0xE9614C")]
		private bool allowDirectionChange;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE961AC", Offset = "0xE961AC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE961AC", Offset = "0xE961AC")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE96298", Offset = "0xE96298")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE96298", Offset = "0xE96298")]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE96384", Offset = "0xE96384")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE96384", Offset = "0xE96384")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE96408", Offset = "0xE96408")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE96408", Offset = "0xE96408")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE96408", Offset = "0xE96408")]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9653C", Offset = "0xE9653C")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnControlPointReached;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnEndReached;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnSwitch;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE965C4", Offset = "0xE965C4")]
		private bool <IsSwitching>k__BackingField;

		[Token(Token = "0x4000262")]
		private const float StepSize = 0.002f;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CurvySpline prePlaySpline;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float switchStartTime;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float switchDuration;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CurvySpline switchTarget;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float tfOnSwitchTarget;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private MovementDirection directionOnSwitchTarget;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		[Token(Token = "0x170000F5")]
		public virtual CurvySpline Spline
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x17FBCA4", Offset = "0x17FBCA4", VA = "0x17FBCA4", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x17FBCAC", Offset = "0x17FBCAC", VA = "0x17FBCAC", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public bool UseCache
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x17FBCB4", Offset = "0x17FBCB4", VA = "0x17FBCB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x17FBCBC", Offset = "0x17FBCBC", VA = "0x17FBCBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x17FBCDC", Offset = "0x17FBCDC", VA = "0x17FBCDC")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x17FBCE4", Offset = "0x17FBCE4", VA = "0x17FBCE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x17FBCEC", Offset = "0x17FBCEC", VA = "0x17FBCEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x17FBCF4", Offset = "0x17FBCF4", VA = "0x17FBCF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x17FBCFC", Offset = "0x17FBCFC", VA = "0x17FBCFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x17FBD04", Offset = "0x17FBD04", VA = "0x17FBD04")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x17FBD10", Offset = "0x17FBD10", VA = "0x17FBD10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x17FBD18", Offset = "0x17FBD18", VA = "0x17FBD18")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x17FBD24", Offset = "0x17FBD24", VA = "0x17FBD24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x17FBD2C", Offset = "0x17FBD2C", VA = "0x17FBD2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x17FBD38", Offset = "0x17FBD38", VA = "0x17FBD38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x17FBD40", Offset = "0x17FBD40", VA = "0x17FBD40")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x17FBD48", Offset = "0x17FBD48", VA = "0x17FBD48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x17FBD50", Offset = "0x17FBD50", VA = "0x17FBD50")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x17FBD58", Offset = "0x17FBD58", VA = "0x17FBD58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x17FBD60", Offset = "0x17FBD60", VA = "0x17FBD60")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x17FBD68", Offset = "0x17FBD68", VA = "0x17FBD68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x17FBD70", Offset = "0x17FBD70", VA = "0x17FBD70")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool IsSwitching
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x17FBD78", Offset = "0x17FBD78", VA = "0x17FBD78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD58", Offset = "0xE9DD58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x17FBD80", Offset = "0x17FBD80", VA = "0x17FBD80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD68", Offset = "0xE9DD68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public override float Length
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x17FBD8C", Offset = "0x17FBD8C", VA = "0x17FBD8C", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000102")]
		private float SwitchProgress
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x17FBF44", Offset = "0x17FBF44", VA = "0x17FBF44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000103")]
		public override bool IsReady
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x17FC290", Offset = "0x17FC290", VA = "0x17FC290", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000104")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x17FF33C", Offset = "0x17FF33C", VA = "0x17FF33C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x17FBBC8", Offset = "0x17FBBC8", VA = "0x17FBBC8")]
		public SplineController()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x17FBFF0", Offset = "0x17FBFF0", VA = "0x17FBFF0", Slot = "40")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x17FC09C", Offset = "0x17FC09C", VA = "0x17FC09C")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x17FC0E4", Offset = "0x17FC0E4", VA = "0x17FC0E4")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x17FC0F4", Offset = "0x17FC0F4", VA = "0x17FC0F4")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x17FC350", Offset = "0x17FC350", VA = "0x17FC350", Slot = "22")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x17FC390", Offset = "0x17FC390", VA = "0x17FC390", Slot = "23")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x17FC3D0", Offset = "0x17FC3D0", VA = "0x17FC3D0", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x17FC514", Offset = "0x17FC514", VA = "0x17FC514", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x17FC664", Offset = "0x17FC664", VA = "0x17FC664", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x17FC7F4", Offset = "0x17FC7F4", VA = "0x17FC7F4", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x17FCC2C", Offset = "0x17FCC2C", VA = "0x17FCC2C", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x17FCDAC", Offset = "0x17FCDAC", VA = "0x17FCDAC", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x17FCE24", Offset = "0x17FCE24", VA = "0x17FCE24", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x17FDB14", Offset = "0x17FDB14", VA = "0x17FDB14", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x17FD9B8", Offset = "0x17FD9B8", VA = "0x17FD9B8")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x17FDBBC", Offset = "0x17FDBBC", VA = "0x17FDBBC", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x17FDCFC", Offset = "0x17FDCFC", VA = "0x17FDCFC", Slot = "17")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x17FE018", Offset = "0x17FE018", VA = "0x17FE018")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint)
		{
			return default(float);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x17FE8EC", Offset = "0x17FE8EC", VA = "0x17FE8EC")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float position)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x17FCFB8", Offset = "0x17FCFB8", VA = "0x17FCFB8")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x17FEA58", Offset = "0x17FEA58", VA = "0x17FEA58")]
		private CurvySplineSegment GetCurrentControlPoint(out bool isOnControlPoint, out float position, CurvyPositionMode positionMode)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x17FEC8C", Offset = "0x17FEC8C", VA = "0x17FEC8C")]
		private void HandleReachingNewControlPoint(CurvySplineSegment newControlPoint, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x17FF010", Offset = "0x17FF010", VA = "0x17FF010")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x17FC248", Offset = "0x17FC248", VA = "0x17FC248")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x17FEF20", Offset = "0x17FEF20", VA = "0x17FEF20")]
		private CurvySplineSegment HandleFolloUpConnectionBahavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x17FF284", Offset = "0x17FF284", VA = "0x17FF284")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x17FEB88", Offset = "0x17FEB88", VA = "0x17FEB88")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode, MovementDirection movementDirection)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE91280", Offset = "0xE91280")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE91280", Offset = "0xE91280")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91280", Offset = "0xE91280")]
	public class UITextSplineController : SplineController, IMeshModifier
	{
		[Token(Token = "0x2000157")]
		protected class GlyphQuad
		{
			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIVertex[] V;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x1700026D")]
			public Vector3 Center
			{
				[Token(Token = "0x6000B66")]
				[Address(RVA = "0x18004D0", Offset = "0x18004D0", VA = "0x18004D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x1800DC0", Offset = "0x1800DC0", VA = "0x1800DC0")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x18002B4", Offset = "0x18002B4", VA = "0x18002B4")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x1800FDC", Offset = "0x1800FDC", VA = "0x1800FDC")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x1801050", Offset = "0x1801050", VA = "0x1801050")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x1800754", Offset = "0x1800754", VA = "0x1800754")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x1800558", Offset = "0x1800558", VA = "0x1800558")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x1800660", Offset = "0x1800660", VA = "0x1800660")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x1800254", Offset = "0x1800254", VA = "0x1800254")]
			public GlyphQuad()
			{
			}
		}

		[Token(Token = "0x2000158")]
		protected class GlyphPlain
		{
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] V;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x1700026E")]
			public Vector3 Center
			{
				[Token(Token = "0x6000B6F")]
				[Address(RVA = "0x17FFABC", Offset = "0x17FFABC", VA = "0x17FFABC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x17FF984", Offset = "0x17FF984", VA = "0x17FF984")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x1800D4C", Offset = "0x1800D4C", VA = "0x1800D4C")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x17FFD40", Offset = "0x17FFD40", VA = "0x17FFD40")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x17FFB44", Offset = "0x17FFB44", VA = "0x17FFB44")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x17FFC4C", Offset = "0x17FFC4C", VA = "0x17FFC4C")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x17FF924", Offset = "0x17FF924", VA = "0x17FF924")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE965D4", Offset = "0xE965D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE965D4", Offset = "0xE965D4")]
		[SerializeField]
		private bool staticOrientation;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Graphic m_Graphic;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform mRect;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Text mText;

		[Token(Token = "0x17000105")]
		public bool StaticOrientation
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x17FF350", Offset = "0x17FF350", VA = "0x17FF350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x17FF358", Offset = "0x17FF358", VA = "0x17FF358")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x17FF364", Offset = "0x17FF364", VA = "0x17FF364", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000107")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x17FF36C", Offset = "0x17FF36C", VA = "0x17FF36C", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000108")]
		protected Text Text
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x17FF374", Offset = "0x17FF374", VA = "0x17FF374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x17FF40C", Offset = "0x17FF40C", VA = "0x17FF40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x17FF4A4", Offset = "0x17FF4A4", VA = "0x17FF4A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x18008F4", Offset = "0x18008F4", VA = "0x18008F4", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x18008FC", Offset = "0x18008FC", VA = "0x18008FC", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x17FF53C", Offset = "0x17FF53C", VA = "0x17FF53C", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x17FF578", Offset = "0x17FF578", VA = "0x17FF578", Slot = "41")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x17FFE78", Offset = "0x17FFE78", VA = "0x17FFE78", Slot = "42")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1800778", Offset = "0x1800778", VA = "0x1800778", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x180082C", Offset = "0x180082C", VA = "0x180082C", Slot = "10")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1800BDC", Offset = "0x1800BDC", VA = "0x1800BDC", Slot = "20")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1800BE0", Offset = "0x1800BE0", VA = "0x1800BE0", Slot = "21")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1800AC4", Offset = "0x1800AC4", VA = "0x1800AC4")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x18009B4", Offset = "0x18009B4", VA = "0x18009B4")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1800BE4", Offset = "0x1800BE4", VA = "0x1800BE4")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1800D48", Offset = "0x1800D48", VA = "0x1800D48")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE9132C", Offset = "0xE9132C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9132C", Offset = "0xE9132C")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x400026E")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x400026F")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE96650", Offset = "0xE96650")]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0xE96650", Offset = "0xE96650")]
		[SerializeField]
		private CGDataReference m_Volume;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE96704", Offset = "0xE96704")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE967B8", Offset = "0xE967B8")]
		[SerializeField]
		private float crossRelativePosition;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE96860", Offset = "0xE96860")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x1700010C")]
		public CGDataReference Volume
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x180120C", Offset = "0x180120C", VA = "0x180120C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1801214", Offset = "0x1801214", VA = "0x1801214")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x180121C", Offset = "0x180121C", VA = "0x180121C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public float CrossFrom
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1801294", Offset = "0x1801294", VA = "0x1801294")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x180129C", Offset = "0x180129C", VA = "0x180129C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float CrossTo
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1801320", Offset = "0x1801320", VA = "0x1801320")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1801328", Offset = "0x1801328", VA = "0x1801328")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public float CrossLength
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x18013B0", Offset = "0x18013B0", VA = "0x18013B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000111")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x18013BC", Offset = "0x18013BC", VA = "0x18013BC")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x18013C4", Offset = "0x18013C4", VA = "0x18013C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x18013CC", Offset = "0x18013CC", VA = "0x18013CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x18013F8", Offset = "0x18013F8", VA = "0x18013F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public override float Length
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1801428", Offset = "0x1801428", VA = "0x1801428", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000114")]
		public override bool IsReady
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1801548", Offset = "0x1801548", VA = "0x1801548", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1801AA0", Offset = "0x1801AA0", VA = "0x1801AA0")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000116")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1801AF8", Offset = "0x1801AF8", VA = "0x1801AF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000117")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1801B00", Offset = "0x1801B00", VA = "0x1801B00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1801468", Offset = "0x1801468", VA = "0x1801468")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x18014D8", Offset = "0x18014D8", VA = "0x18014D8")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1801598", Offset = "0x1801598", VA = "0x1801598", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x18015F4", Offset = "0x18015F4", VA = "0x18015F4", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1801650", Offset = "0x1801650", VA = "0x1801650", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x18016E8", Offset = "0x18016E8", VA = "0x18016E8", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x18017EC", Offset = "0x18017EC", VA = "0x18017EC", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1801884", Offset = "0x1801884", VA = "0x1801884", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x180191C", Offset = "0x180191C", VA = "0x180191C", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1801990", Offset = "0x1801990", VA = "0x1801990", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x18013E4", Offset = "0x18013E4", VA = "0x18013E4")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1801B08", Offset = "0x1801B08", VA = "0x1801B08", Slot = "37")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1801B5C", Offset = "0x1801B5C", VA = "0x1801B5C")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91390", Offset = "0xE91390")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE91390", Offset = "0xE91390")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ArrayEx]
		public List<GLSlotData> Splines;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material lineMaterial;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x17F77F8", Offset = "0x17F77F8", VA = "0x17F77F8")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x17F78F8", Offset = "0x17F78F8", VA = "0x17F78F8")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x17F7ACC", Offset = "0x17F7ACC", VA = "0x17F7ACC")]
		private void sanitize()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x17F7F24", Offset = "0x17F7F24", VA = "0x17F7F24")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x17F8078", Offset = "0x17F8078", VA = "0x17F8078")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x17F81F4", Offset = "0x17F81F4", VA = "0x17F81F4")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x17F8364", Offset = "0x17F8364", VA = "0x17F8364")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x17F8468", Offset = "0x17F8468", VA = "0x17F8468")]
		public CurvyGLRenderer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class GLSlotData
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public CurvySpline Spline;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color LineColor;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3[]> VertexData;

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x17F7BFC", Offset = "0x17F7BFC", VA = "0x17F7BFC")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x17F7D3C", Offset = "0x17F7D3C", VA = "0x17F7D3C")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x17F82C4", Offset = "0x17F82C4", VA = "0x17F82C4")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE913F0", Offset = "0xE913F0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE913F0", Offset = "0xE913F0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE913F0", Offset = "0xE913F0")]
	public class CurvyLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline m_Spline;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer mRenderer;

		[Token(Token = "0x17000118")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x17F84D8", Offset = "0x17F84D8", VA = "0x17F84D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x17F84E0", Offset = "0x17F84E0", VA = "0x17F84E0")]
			set
			{
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x17F8880", Offset = "0x17F8880", VA = "0x17F8880")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x17F8928", Offset = "0x17F8928", VA = "0x17F8928")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x17F8984", Offset = "0x17F8984", VA = "0x17F8984")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x17F8988", Offset = "0x17F8988", VA = "0x17F8988")]
		private void Start()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x17F875C", Offset = "0x17F875C", VA = "0x17F875C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x17F8B60", Offset = "0x17F8B60", VA = "0x17F8B60")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x17F8674", Offset = "0x17F8674", VA = "0x17F8674")]
		private void bindEvents()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x17F858C", Offset = "0x17F858C", VA = "0x17F858C")]
		private void unbindEvents()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x17F8B64", Offset = "0x17F8B64", VA = "0x17F8B64")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0xE914AC", Offset = "0xE914AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE914AC", Offset = "0xE914AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE914AC", Offset = "0xE914AC")]
	public class CSCircle : CurvyShape2D
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x17000119")]
		public int Count
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1906550", Offset = "0x1906550", VA = "0x1906550")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1906558", Offset = "0x1906558", VA = "0x1906558")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public float Radius
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x19065EC", Offset = "0x19065EC", VA = "0x19065EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x19065F4", Offset = "0x19065F4", VA = "0x19065F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1906688", Offset = "0x1906688", VA = "0x1906688", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x19066C0", Offset = "0x19066C0", VA = "0x19066C0", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x190684C", Offset = "0x190684C", VA = "0x190684C")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0xE9155C", Offset = "0xE9155C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE9155C", Offset = "0xE9155C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE9155C", Offset = "0xE9155C")]
	public class CSPie : CSCircle
	{
		[Token(Token = "0x2000159")]
		public enum EatModeEnum
		{
			[Token(Token = "0x4000578")]
			Left,
			[Token(Token = "0x4000579")]
			Right,
			[Token(Token = "0x400057A")]
			Center
		}

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE9695C", Offset = "0xE9695C")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9699C", Offset = "0xE9699C")]
		private int m_Empty;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE96A1C", Offset = "0xE96A1C")]
		[SerializeField]
		private EatModeEnum m_Eat;

		[Token(Token = "0x1700011B")]
		public float Roundness
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1906860", Offset = "0x1906860", VA = "0x1906860")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1906868", Offset = "0x1906868", VA = "0x1906868")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public int Empty
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x19068F8", Offset = "0x19068F8", VA = "0x19068F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1906900", Offset = "0x1906900", VA = "0x1906900")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		private int maxEmpty
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x190699C", Offset = "0x190699C", VA = "0x190699C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700011E")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x19069A4", Offset = "0x19069A4", VA = "0x19069A4")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x19069AC", Offset = "0x19069AC", VA = "0x19069AC")]
			set
			{
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x19069C8", Offset = "0x19069C8", VA = "0x19069C8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1906A18", Offset = "0x1906A18", VA = "0x1906A18")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1906B68", Offset = "0x1906B68", VA = "0x1906B68", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x19072BC", Offset = "0x19072BC", VA = "0x19072BC")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0xE9160C", Offset = "0xE9160C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE9160C", Offset = "0xE9160C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE9160C", Offset = "0xE9160C")]
	public class CSRectangle : CurvyShape2D
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x1700011F")]
		public float Width
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x19072D8", Offset = "0x19072D8", VA = "0x19072D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x19072E0", Offset = "0x19072E0", VA = "0x19072E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public float Height
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1907374", Offset = "0x1907374", VA = "0x1907374")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x190737C", Offset = "0x190737C", VA = "0x190737C")]
			set
			{
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1907410", Offset = "0x1907410", VA = "0x1907410", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1907454", Offset = "0x1907454", VA = "0x1907454", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x190766C", Offset = "0x190766C", VA = "0x190766C")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0xE916BC", Offset = "0xE916BC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE916BC", Offset = "0xE916BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE916BC", Offset = "0xE916BC")]
	public class CSRoundedRectangle : CurvyShape2D
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE96B48", Offset = "0xE96B48")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x17000121")]
		public float Width
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x190767C", Offset = "0x190767C", VA = "0x190767C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1907684", Offset = "0x1907684", VA = "0x1907684")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public float Height
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1907718", Offset = "0x1907718", VA = "0x1907718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1907720", Offset = "0x1907720", VA = "0x1907720")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public float Roundness
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x19077B4", Offset = "0x19077B4", VA = "0x19077B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x19077BC", Offset = "0x19077BC", VA = "0x19077BC")]
			set
			{
			}
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x190784C", Offset = "0x190784C", VA = "0x190784C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x190789C", Offset = "0x190789C", VA = "0x190789C", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1907DFC", Offset = "0x1907DFC", VA = "0x1907DFC")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0xE9176C", Offset = "0xE9176C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE9176C", Offset = "0xE9176C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE9176C", Offset = "0xE9176C")]
	public class CSSpiral : CurvyShape2D
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Circles;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Positive]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE96C6C", Offset = "0xE96C6C")]
		[SerializeField]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x17000124")]
		public int Count
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1907E14", Offset = "0x1907E14", VA = "0x1907E14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1907E1C", Offset = "0x1907E1C", VA = "0x1907E1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public float Circles
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1907EB0", Offset = "0x1907EB0", VA = "0x1907EB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1907EB8", Offset = "0x1907EB8", VA = "0x1907EB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public float Radius
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1907F4C", Offset = "0x1907F4C", VA = "0x1907F4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1907F54", Offset = "0x1907F54", VA = "0x1907F54")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1907FE8", Offset = "0x1907FE8", VA = "0x1907FE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1907FF0", Offset = "0x1907FF0", VA = "0x1907FF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public AnimationCurve Z
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x190800C", Offset = "0x190800C", VA = "0x190800C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1908014", Offset = "0x1908014", VA = "0x1908014")]
			set
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1908030", Offset = "0x1908030", VA = "0x1908030", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x19080D8", Offset = "0x19080D8", VA = "0x19080D8", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x19082AC", Offset = "0x19082AC", VA = "0x19082AC")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0xE9181C", Offset = "0xE9181C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE9181C", Offset = "0xE9181C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE9181C", Offset = "0xE9181C")]
	public class CSStar : CurvyShape2D
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Sides;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_OuterRadius;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE96D58", Offset = "0xE96D58")]
		private float m_OuterRoundness;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Positive]
		private float m_InnerRadius;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE96E00", Offset = "0xE96E00")]
		private float m_InnerRoundness;

		[Token(Token = "0x17000129")]
		public int Sides
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1908328", Offset = "0x1908328", VA = "0x1908328")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1908330", Offset = "0x1908330", VA = "0x1908330")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public float OuterRadius
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x19083C4", Offset = "0x19083C4", VA = "0x19083C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x19083CC", Offset = "0x19083CC", VA = "0x19083CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public float OuterRoundness
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1908464", Offset = "0x1908464", VA = "0x1908464")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x190846C", Offset = "0x190846C", VA = "0x190846C")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public float InnerRadius
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1908500", Offset = "0x1908500", VA = "0x1908500")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1908508", Offset = "0x1908508", VA = "0x1908508")]
			set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public float InnerRoundness
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x190859C", Offset = "0x190859C", VA = "0x190859C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x19085A4", Offset = "0x19085A4", VA = "0x19085A4")]
			set
			{
			}
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1908638", Offset = "0x1908638", VA = "0x1908638", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1908694", Offset = "0x1908694", VA = "0x1908694", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1908920", Offset = "0x1908920", VA = "0x1908920")]
		public CSStar()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Utils
{
	[Token(Token = "0x20000C1")]
	public static class CurvyUtility
	{
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x13C7FB4", Offset = "0x13C7FB4", VA = "0x13C7FB4")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x13C80E4", Offset = "0x13C80E4", VA = "0x13C80E4")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x13C8278", Offset = "0x13C8278", VA = "0x13C8278")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x13C83AC", Offset = "0x13C83AC", VA = "0x13C83AC")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x13C8534", Offset = "0x13C8534", VA = "0x13C8534")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x13C8640", Offset = "0x13C8640", VA = "0x13C8640")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x13C8798", Offset = "0x13C8798", VA = "0x13C8798")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x13C88F8", Offset = "0x13C88F8", VA = "0x13C88F8")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x13C8A98", Offset = "0x13C8A98", VA = "0x13C8A98")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x13C8B94", Offset = "0x13C8B94", VA = "0x13C8B94")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C2")]
	public class Spline2Mesh
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SplinePolyLine> Lines;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WindingRule Winding;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVTiling;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVOffset;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool SuppressUVMapping;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool UV2;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string MeshName;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool VertexLineOnly;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE96E70", Offset = "0xE96E70")]
		private string <Error>k__BackingField;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tess mTess;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh mMesh;

		[Token(Token = "0x1700012E")]
		public string Error
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x13C8CFC", Offset = "0x13C8CFC", VA = "0x13C8CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD88", Offset = "0xE9DD88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x13C8D04", Offset = "0x13C8D04", VA = "0x13C8D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DD98", Offset = "0xE9DD98")]
			private set
			{
			}
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x13C8D0C", Offset = "0x13C8D0C", VA = "0x13C8D0C")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x13C91F0", Offset = "0x13C91F0", VA = "0x13C91F0")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x13C963C", Offset = "0x13C963C", VA = "0x13C963C")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x13C96D8", Offset = "0x13C96D8", VA = "0x13C96D8")]
		public Spline2Mesh()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class SplinePolyLine
	{
		[Token(Token = "0x200015A")]
		public enum VertexCalculation
		{
			[Token(Token = "0x400057C")]
			ByApproximation,
			[Token(Token = "0x400057D")]
			ByAngle
		}

		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE929C8", Offset = "0xE929C8")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x13C9EE0", Offset = "0x13C9EE0", VA = "0x13C9EE0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x13C9EE8", Offset = "0x13C9EE8", VA = "0x13C9EE8")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContourOrientation Orientation;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VertexCalculation VertexMode;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Angle;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Distance;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Space Space;

		[Token(Token = "0x1700012F")]
		public bool IsClosed
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x13C986C", Offset = "0x13C986C", VA = "0x13C986C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x13C9798", Offset = "0x13C9798", VA = "0x13C9798")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x13C9820", Offset = "0x13C9820", VA = "0x13C9820")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x13C97C8", Offset = "0x13C97C8", VA = "0x13C97C8")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x13C9500", Offset = "0x13C9500", VA = "0x13C9500")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x13C9900", Offset = "0x13C9900", VA = "0x13C9900")]
		private static Vector3[] GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy.Generator
{
	[Token(Token = "0x20000C4")]
	public abstract class SplineInputModuleBase : CGModule
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE96E80", Offset = "0xE96E80")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE96E80", Offset = "0xE96E80")]
		private bool m_UseCache;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE96EF0", Offset = "0xE96EF0")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE96F3C", Offset = "0xE96F3C")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE96F88", Offset = "0xE96F88")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x17000130")]
		public bool UseCache
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x19033F0", Offset = "0x19033F0", VA = "0x19033F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x19033F8", Offset = "0x19033F8", VA = "0x19033F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1903420", Offset = "0x1903420", VA = "0x1903420")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1903428", Offset = "0x1903428", VA = "0x1903428")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x19034C4", Offset = "0x19034C4", VA = "0x19034C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x19034CC", Offset = "0x19034CC", VA = "0x19034CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public bool UseGlobalSpace
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x1903568", Offset = "0x1903568", VA = "0x1903568")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1903570", Offset = "0x1903570", VA = "0x1903570")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public override bool IsConfigured
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1903584", Offset = "0x1903584", VA = "0x1903584", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000135")]
		public override bool IsInitialized
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x190362C", Offset = "0x190362C", VA = "0x190362C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000136")]
		public float PathLength
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x19036FC", Offset = "0x19036FC", VA = "0x19036FC", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000137")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1903868", Offset = "0x1903868", VA = "0x1903868", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000138")]
		protected abstract CurvySpline InputSpline
		{
			[Token(Token = "0x6000702")]
			get;
			[Token(Token = "0x6000703")]
			set;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1903988", Offset = "0x1903988", VA = "0x1903988", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x19039D0", Offset = "0x19039D0", VA = "0x19039D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1903B68", Offset = "0x1903B68", VA = "0x1903B68", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1903BE8", Offset = "0x1903BE8", VA = "0x1903BE8")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1903D48", Offset = "0x1903D48", VA = "0x1903D48")]
		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1903D3C", Offset = "0x1903D3C", VA = "0x1903D3C")]
		private void ForceRefresh()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1903754", Offset = "0x1903754", VA = "0x1903754")]
		private float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x19038C0", Offset = "0x19038C0", VA = "0x19038C0")]
		private bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x18FD624", Offset = "0x18FD624", VA = "0x18FD624")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1904044", Offset = "0x1904044", VA = "0x1904044")]
		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, Bounds bounds, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1903EC4", Offset = "0x1903EC4", VA = "0x1903EC4")]
		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x190434C", Offset = "0x190434C", VA = "0x190434C")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1904DD4", Offset = "0x1904DD4", VA = "0x1904DD4")]
		private static void GetPositionAndTangent(CurvySpline spline, bool useCache, out Vector3 position, out Vector3 tangent, float tf)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x19045E4", Offset = "0x19045E4", VA = "0x19045E4")]
		private void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1904EAC", Offset = "0x1904EAC", VA = "0x1904EAC")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1905004", Offset = "0x1905004", VA = "0x1905004")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x18FF2F8", Offset = "0x18FF2F8", VA = "0x18FF2F8", Slot = "19")]
		protected virtual void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x18FD1FC", Offset = "0x18FD1FC", VA = "0x18FD1FC")]
		protected void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x18FED8C", Offset = "0x18FED8C", VA = "0x18FED8C")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class TRSModuleBase : CGModule
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE96FF0", Offset = "0xE96FF0")]
		private Vector3 m_Transpose;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97058", Offset = "0xE97058")]
		private Vector3 m_Rotation;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE970C0", Offset = "0xE970C0")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000139")]
		public Vector3 Transpose
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1905308", Offset = "0x1905308", VA = "0x1905308")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1905314", Offset = "0x1905314", VA = "0x1905314")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x19053D8", Offset = "0x19053D8", VA = "0x19053D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x19053E4", Offset = "0x19053E4", VA = "0x19053E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public Vector3 Scale
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x19054A8", Offset = "0x19054A8", VA = "0x19054A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x19054B4", Offset = "0x19054B4", VA = "0x19054B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x190153C", Offset = "0x190153C", VA = "0x190153C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1905578", Offset = "0x1905578", VA = "0x1905578", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x19055C0", Offset = "0x19055C0", VA = "0x19055C0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x19016E0", Offset = "0x19016E0", VA = "0x19016E0")]
		public TRSModuleBase()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public enum CGYesNoAuto
	{
		[Token(Token = "0x40002A9")]
		Yes,
		[Token(Token = "0x40002AA")]
		No,
		[Token(Token = "0x40002AB")]
		Auto
	}
	[Token(Token = "0x20000C7")]
	public enum CGReferenceMode
	{
		[Token(Token = "0x40002AD")]
		Source,
		[Token(Token = "0x40002AE")]
		Self
	}
	[Token(Token = "0x20000C8")]
	public enum CGKeepAspectMode
	{
		[Token(Token = "0x40002B0")]
		Off,
		[Token(Token = "0x40002B1")]
		ScaleU,
		[Token(Token = "0x40002B2")]
		ScaleV
	}
	[Token(Token = "0x20000C9")]
	public enum CGUVEnum
	{
		[Token(Token = "0x40002B4")]
		U,
		[Token(Token = "0x40002B5")]
		V
	}
	[Token(Token = "0x20000CA")]
	public enum CGColliderEnum
	{
		[Token(Token = "0x40002B7")]
		None,
		[Token(Token = "0x40002B8")]
		Mesh,
		[Token(Token = "0x40002B9")]
		Box,
		[Token(Token = "0x40002BA")]
		Sphere
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public struct CGSpot : IEquatable<CGSpot>
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE97128", Offset = "0xE97128")]
		private int m_Index;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97188", Offset = "0xE97188")]
		private Vector3 m_Position;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE971F8", Offset = "0xE971F8")]
		private Quaternion m_Rotation;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97268", Offset = "0xE97268")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700013D")]
		public int Index
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xFD5EE0", Offset = "0xFD5EE0", VA = "0xFD5EE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013E")]
		public Vector3 Position
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xFD5EE8", Offset = "0xFD5EE8", VA = "0xFD5EE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0xFD5EF4", Offset = "0xFD5EF4", VA = "0xFD5EF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xFD5EFC", Offset = "0xFD5EFC", VA = "0xFD5EFC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0xFD5F08", Offset = "0xFD5F08", VA = "0xFD5F08")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0xFD5F10", Offset = "0xFD5F10", VA = "0xFD5F10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xFD5F1C", Offset = "0xFD5F1C", VA = "0xFD5F1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xFD5F24", Offset = "0xFD5F24", VA = "0xFD5F24")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xFD5F2C", Offset = "0xFD5F2C", VA = "0xFD5F2C")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xFD5F34", Offset = "0xFD5F34", VA = "0xFD5F34")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xFD5F5C", Offset = "0xFD5F5C", VA = "0xFD5F5C")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xFD5F64", Offset = "0xFD5F64", VA = "0xFD5F64", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xFD5F9C", Offset = "0xFD5F9C", VA = "0xFD5F9C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xFD5FA4", Offset = "0xFD5FA4", VA = "0xFD5FA4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x19B68F4", Offset = "0x19B68F4", VA = "0x19B68F4")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x19B6928", Offset = "0x19B6928", VA = "0x19B6928")]
		public static bool operator !=(CGSpot left, CGSpot right)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public class CGMaterialSettings
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool SwapUV;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CGKeepAspectMode KeepAspect;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UVRotation;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVOffset;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVScale;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x17B55E0", Offset = "0x17B55E0", VA = "0x17B55E0")]
		public CGMaterialSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CD")]
	public class CGMaterialSettingsEx : CGMaterialSettings
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int MaterialID;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x17B5660", Offset = "0x17B5660", VA = "0x17B5660")]
		public CGMaterialSettingsEx()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class CGMeshProperties
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material[] m_Material;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE972F8", Offset = "0xE972F8")]
		private Vector3 m_Translation;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97360", Offset = "0xE97360")]
		private Vector3 m_Rotation;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE973C8", Offset = "0xE973C8")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000142")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x17B5664", Offset = "0x17B5664", VA = "0x17B5664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x17B566C", Offset = "0x17B566C", VA = "0x17B566C")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public Material[] Material
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x17B5784", Offset = "0x17B5784", VA = "0x17B5784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x17B578C", Offset = "0x17B578C", VA = "0x17B578C")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x17B57A0", Offset = "0x17B57A0", VA = "0x17B57A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x17B57AC", Offset = "0x17B57AC", VA = "0x17B57AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x17B5864", Offset = "0x17B5864", VA = "0x17B5864")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x17B5870", Offset = "0x17B5870", VA = "0x17B5870")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public Vector3 Scale
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x17B5928", Offset = "0x17B5928", VA = "0x17B5928")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x17B5934", Offset = "0x17B5934", VA = "0x17B5934")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x17B59EC", Offset = "0x17B59EC", VA = "0x17B59EC")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x17B5B0C", Offset = "0x17B5B0C", VA = "0x17B5B0C")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x17B5B9C", Offset = "0x17B5B9C", VA = "0x17B5B9C")]
		public CGMeshProperties(Mesh mesh)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public class CGGameObjectProperties
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject m_Object;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97440", Offset = "0xE97440")]
		private Vector3 m_Translation;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE974A8", Offset = "0xE974A8")]
		private Vector3 m_Rotation;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97510", Offset = "0xE97510")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000148")]
		public GameObject Object
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x17B4C5C", Offset = "0x17B4C5C", VA = "0x17B4C5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x17B4C64", Offset = "0x17B4C64", VA = "0x17B4C64")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x17B4CEC", Offset = "0x17B4CEC", VA = "0x17B4CEC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x17B4CF8", Offset = "0x17B4CF8", VA = "0x17B4CF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x17B4DB0", Offset = "0x17B4DB0", VA = "0x17B4DB0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x17B4DBC", Offset = "0x17B4DBC", VA = "0x17B4DBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x17B4E74", Offset = "0x17B4E74", VA = "0x17B4E74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x17B4E80", Offset = "0x17B4E80", VA = "0x17B4E80")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x17B4F38", Offset = "0x17B4F38", VA = "0x17B4F38")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x17B5058", Offset = "0x17B5058", VA = "0x17B5058")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x17B50D0", Offset = "0x17B50D0", VA = "0x17B50D0")]
		public CGGameObjectProperties(GameObject gameObject)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class CGBoundsGroup
	{
		[Token(Token = "0x200015C")]
		public enum DistributionModeEnum
		{
			[Token(Token = "0x4000587")]
			Parent,
			[Token(Token = "0x4000588")]
			Self
		}

		[Token(Token = "0x200015D")]
		public enum RotationModeEnum
		{
			[Token(Token = "0x400058A")]
			Full,
			[Token(Token = "0x400058B")]
			Direction,
			[Token(Token = "0x400058C")]
			Horizontal,
			[Token(Token = "0x400058D")]
			Independent
		}

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_KeepTogether;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceBefore;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceAfter;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE97630", Offset = "0xE97630")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE97714", Offset = "0xE97714")]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_Height;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE97810", Offset = "0xE97810")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE97810", Offset = "0xE97810")]
		[SerializeField]
		private RotationModeEnum m_RotationMode;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE9789C", Offset = "0xE9789C")]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE97904", Offset = "0xE97904")]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<CGBoundsGroupItem> m_Items;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WeightedRandom<int> mItemBag;

		[Token(Token = "0x1700014D")]
		public string Name
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x17B2C98", Offset = "0x17B2C98", VA = "0x17B2C98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x17B2CA0", Offset = "0x17B2CA0", VA = "0x17B2CA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public bool KeepTogether
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x17B2CD4", Offset = "0x17B2CD4", VA = "0x17B2CD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x17B2CDC", Offset = "0x17B2CDC", VA = "0x17B2CDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x17B2CFC", Offset = "0x17B2CFC", VA = "0x17B2CFC")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x17B2D0C", Offset = "0x17B2D0C", VA = "0x17B2D0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x17B2D5C", Offset = "0x17B2D5C", VA = "0x17B2D5C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x17B2D6C", Offset = "0x17B2D6C", VA = "0x17B2D6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public float Weight
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x17B2DBC", Offset = "0x17B2DBC", VA = "0x17B2DBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x17B2DC4", Offset = "0x17B2DC4", VA = "0x17B2DC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x17B2E4C", Offset = "0x17B2E4C", VA = "0x17B2E4C")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x17B2E54", Offset = "0x17B2E54", VA = "0x17B2E54")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x17B2E68", Offset = "0x17B2E68", VA = "0x17B2E68")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x17B2E78", Offset = "0x17B2E78", VA = "0x17B2E78")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public DistributionModeEnum DistributionMode
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x17B2EC8", Offset = "0x17B2EC8", VA = "0x17B2EC8")]
			get
			{
				return default(DistributionModeEnum);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x17B2ED0", Offset = "0x17B2ED0", VA = "0x17B2ED0")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public FloatRegion PositionOffset
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x17B2EE4", Offset = "0x17B2EE4", VA = "0x17B2EE4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x17B2EF4", Offset = "0x17B2EF4", VA = "0x17B2EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public FloatRegion Height
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x17B2F44", Offset = "0x17B2F44", VA = "0x17B2F44")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x17B2F54", Offset = "0x17B2F54", VA = "0x17B2F54")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x17B2FA4", Offset = "0x17B2FA4", VA = "0x17B2FA4")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x17B2FAC", Offset = "0x17B2FAC", VA = "0x17B2FAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public Vector3 RotationOffset
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x17B2FC0", Offset = "0x17B2FC0", VA = "0x17B2FC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x17B2FCC", Offset = "0x17B2FCC", VA = "0x17B2FCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public Vector3 RotationScatter
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x17B3084", Offset = "0x17B3084", VA = "0x17B3084")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x17B3090", Offset = "0x17B3090", VA = "0x17B3090")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x17B3148", Offset = "0x17B3148", VA = "0x17B3148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x17B3150", Offset = "0x17B3150", VA = "0x17B3150")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x17B3158", Offset = "0x17B3158", VA = "0x17B3158")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public int LastRepeating
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x17B3258", Offset = "0x17B3258", VA = "0x17B3258")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x17B3260", Offset = "0x17B3260", VA = "0x17B3260")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public int ItemCount
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x17B3208", Offset = "0x17B3208", VA = "0x17B3208")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015E")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x17B3420", Offset = "0x17B3420", VA = "0x17B3420")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x1700015F")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x17B34C4", Offset = "0x17B34C4", VA = "0x17B34C4")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000160")]
		private int lastItemIndex
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x17B351C", Offset = "0x17B351C", VA = "0x17B351C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x17B3314", Offset = "0x17B3314", VA = "0x17B3314")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x17B3598", Offset = "0x17B3598", VA = "0x17B3598")]
		internal void PrepareINTERNAL()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x17B36F8", Offset = "0x17B36F8", VA = "0x17B36F8")]
		internal int getRandomItemINTERNAL()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D1")]
	public class CGBoundsGroupItem
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Index;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9797C", Offset = "0xE9797C")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x17000161")]
		public float Weight
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x17B3750", Offset = "0x17B3750", VA = "0x17B3750")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x17B3758", Offset = "0x17B3758", VA = "0x17B3758")]
			set
			{
			}
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x17B37E0", Offset = "0x17B37E0", VA = "0x17B37E0")]
		public CGBoundsGroupItem()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public struct ControlPointOption : IEquatable<ControlPointOption>
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float TF;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Distance;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool Include;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MaterialID;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool HardEdge;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxStepDistance;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UVEdge;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UVShift;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FirstU;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SecondU;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xFD6078", Offset = "0xFD6078", VA = "0xFD6078")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xFD60BC", Offset = "0xFD60BC", VA = "0xFD60BC", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xFD60F4", Offset = "0xFD60F4", VA = "0xFD60F4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xFD60FC", Offset = "0xFD60FC", VA = "0xFD60FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x19BB61C", Offset = "0x19BB61C", VA = "0x19BB61C")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x19BB650", Offset = "0x19BB650", VA = "0x19BB650")]
		public static bool operator !=(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D3")]
	public struct SamplePointsPatch : IEquatable<SamplePointsPatch>
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Start;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x17000162")]
		public int End
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xFD484C", Offset = "0xFD484C", VA = "0xFD484C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xFD4858", Offset = "0xFD4858", VA = "0xFD4858")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public int TriangleCount
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xFD4860", Offset = "0xFD4860", VA = "0xFD4860")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xFD486C", Offset = "0xFD486C", VA = "0xFD486C")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xFD4874", Offset = "0xFD4874", VA = "0xFD4874", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xFD487C", Offset = "0xFD487C", VA = "0xFD487C", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xFD48A4", Offset = "0xFD48A4", VA = "0xFD48A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xFD48AC", Offset = "0xFD48AC", VA = "0xFD48AC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x19032C4", Offset = "0x19032C4", VA = "0x19032C4")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x19032E4", Offset = "0x19032E4", VA = "0x19032E4")]
		public static bool operator !=(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D4")]
	public class SamplePointsMaterialGroup
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MaterialID;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SamplePointsPatch> Patches;

		[Token(Token = "0x17000164")]
		public int TriangleCount
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1902828", Offset = "0x1902828", VA = "0x1902828")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000165")]
		public int StartVertex
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x19028E0", Offset = "0x19028E0", VA = "0x19028E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000166")]
		public int EndVertex
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x1902944", Offset = "0x1902944", VA = "0x1902944")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000167")]
		public int VertexCount
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x19029C0", Offset = "0x19029C0", VA = "0x19029C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x19029F4", Offset = "0x19029F4", VA = "0x19029F4")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1902A78", Offset = "0x1902A78", VA = "0x1902A78")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1900D4C", Offset = "0x1900D4C", VA = "0x1900D4C")]
		public SamplePointsMaterialGroup Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x20000D5")]
	public struct SamplePointUData : IEquatable<SamplePointUData>
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Vertex;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool UVEdge;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float FirstU;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SecondU;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xFD4818", Offset = "0xFD4818", VA = "0xFD4818")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xFD482C", Offset = "0xFD482C", VA = "0xFD482C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xFD4834", Offset = "0xFD4834", VA = "0xFD4834", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xFD483C", Offset = "0xFD483C", VA = "0xFD483C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xFD4844", Offset = "0xFD4844", VA = "0xFD4844", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x19027C4", Offset = "0x19027C4", VA = "0x19027C4")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x19027F4", Offset = "0x19027F4", VA = "0x19027F4")]
		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D6")]
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaterialID;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AspectCorrection;

		[Token(Token = "0x17000168")]
		public int TriangleCount
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1902C50", Offset = "0x1902C50", VA = "0x1902C50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1902CF4", Offset = "0x1902CF4", VA = "0x1902CF4")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1902D6C", Offset = "0x1902D6C", VA = "0x1902D6C")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1902DF4", Offset = "0x1902DF4", VA = "0x1902DF4")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1902E7C", Offset = "0x1902E7C", VA = "0x1902E7C")]
		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D7")]
	public class CGDataReference
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CGModule m_Module;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CGModuleOutputSlot mSlot;

		[Token(Token = "0x17000169")]
		public CGData[] Data
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x17B3A3C", Offset = "0x17B3A3C", VA = "0x17B3A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x17B3AB4", Offset = "0x17B3AB4", VA = "0x17B3AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		public bool HasValue
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x17B3CB8", Offset = "0x17B3CB8", VA = "0x17B3CB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016C")]
		public bool IsEmpty
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x17B3CE8", Offset = "0x17B3CE8", VA = "0x17B3CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016D")]
		public CGModule Module
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x17B3CF4", Offset = "0x17B3CF4", VA = "0x17B3CF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		public string SlotName
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x17B3CFC", Offset = "0x17B3CFC", VA = "0x17B3CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x17B3D04", Offset = "0x17B3D04", VA = "0x17B3D04")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x17B3D0C", Offset = "0x17B3D0C", VA = "0x17B3D0C")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x17B3D54", Offset = "0x17B3D54", VA = "0x17B3D54")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x17B3DE0", Offset = "0x17B3DE0", VA = "0x17B3DE0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000791")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000792")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x17B3D48", Offset = "0x17B3D48", VA = "0x17B3D48")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x17B3D9C", Offset = "0x17B3D9C", VA = "0x17B3D9C")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Color Color;

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x17B3940", Offset = "0x17B3940", VA = "0x17B3940")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x17B398C", Offset = "0x17B398C", VA = "0x17B398C")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x17B3A00", Offset = "0x17B3A00", VA = "0x17B3A00")]
		public CGDataInfoAttribute(string htmlColor)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class CGData
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x1700016F")]
		public virtual int Count
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x17B37F0", Offset = "0x17B37F0", VA = "0x17B37F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x17B37F8", Offset = "0x17B37F8", VA = "0x17B37F8")]
		public static implicit operator bool(CGData a)
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		public virtual T Clone<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x17B3804", Offset = "0x17B3804", VA = "0x17B3804")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x17B2AEC", Offset = "0x17B2AEC", VA = "0x17B2AEC")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE918DC", Offset = "0xE918DC")]
	public class CGShape : CGData
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE929D8", Offset = "0xE929D8")]
		private sealed class <>c
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__17_0;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__19_0;

			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x19B5E7C", Offset = "0x19B5E7C", VA = "0x19B5E7C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x19B5E84", Offset = "0x19B5E84", VA = "0x19B5E84")]
			internal SamplePointsMaterialGroup <.ctor>b__17_0(SamplePointsMaterialGroup g)
			{
				return null;
			}

			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x19B5EA0", Offset = "0x19B5EA0", VA = "0x19B5EA0")]
			internal SamplePointsMaterialGroup <Copy>b__19_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] SourceF;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] F;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] Position;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] Normal;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] Map;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE97A18", Offset = "0xE97A18")]
		public Bounds Bounds;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SamplePointsMaterialGroup> MaterialGroups;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool SourceIsManaged;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool Closed;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool Seamless;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float Length;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float mCacheLastF;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int mCacheLastIndex;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float mCacheLastFrag;

		[Token(Token = "0x17000170")]
		public override int Count
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x19B5280", Offset = "0x19B5280", VA = "0x19B5280", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x19B3950", Offset = "0x19B3950", VA = "0x19B3950")]
		public CGShape()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x19B3AE0", Offset = "0x19B3AE0", VA = "0x19B3AE0")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x60007A0")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x19B3E4C", Offset = "0x19B3E4C", VA = "0x19B3E4C")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x19B529C", Offset = "0x19B529C", VA = "0x19B529C")]
		public void Copy(CGShape source)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x19B52A0", Offset = "0x19B52A0", VA = "0x19B52A0")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x19B532C", Offset = "0x19B532C", VA = "0x19B532C")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x19B42A0", Offset = "0x19B42A0", VA = "0x19B42A0")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x19B53AC", Offset = "0x19B53AC", VA = "0x19B53AC")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x19B54E0", Offset = "0x19B54E0", VA = "0x19B54E0")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x19B5614", Offset = "0x19B5614", VA = "0x19B5614")]
		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x19B57C0", Offset = "0x19B57C0", VA = "0x19B57C0")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x19B57F8", Offset = "0x19B57F8", VA = "0x19B57F8")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x19B474C", Offset = "0x19B474C", VA = "0x19B474C", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x19B586C", Offset = "0x19B586C", VA = "0x19B586C")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE91908", Offset = "0xE91908")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3[] Direction;

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x19B38F4", Offset = "0x19B38F4", VA = "0x19B38F4")]
		public CGPath()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x19B3A30", Offset = "0x19B3A30", VA = "0x19B3A30")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x60007AF")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x19B3DB0", Offset = "0x19B3DB0", VA = "0x19B3DB0")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x19B4098", Offset = "0x19B4098", VA = "0x19B4098")]
		public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x19B4310", Offset = "0x19B4310", VA = "0x19B4310")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x19B4404", Offset = "0x19B4404", VA = "0x19B4404")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x19B4538", Offset = "0x19B4538", VA = "0x19B4538", Slot = "6")]
		public override void Recalculate()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE91934", Offset = "0xE91934")]
	public class CGVolume : CGPath
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3[] Vertex;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector3[] VertexNormal;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float[] CrossF;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float[] CrossMap;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float[] SegmentLength;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool CrossClosed;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool CrossSeamless;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float CrossFShift;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		[Token(Token = "0x17000171")]
		public int CrossSize
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x19B76C8", Offset = "0x19B76C8", VA = "0x19B76C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000172")]
		public int VertexCount
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x19B99EC", Offset = "0x19B99EC", VA = "0x19B99EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x19B9A08", Offset = "0x19B9A08", VA = "0x19B9A08")]
		public CGVolume()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x19B9A9C", Offset = "0x19B9A9C", VA = "0x19B9A9C")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x19B9C50", Offset = "0x19B9C50", VA = "0x19B9C50")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x19B9E14", Offset = "0x19B9E14", VA = "0x19B9E14")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x19B9FEC", Offset = "0x19B9FEC", VA = "0x19B9FEC")]
		public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x19BA1B0", Offset = "0x19BA1B0", VA = "0x19BA1B0")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x19BA57C", Offset = "0x19BA57C", VA = "0x19BA57C")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x19BA864", Offset = "0x19BA864", VA = "0x19BA864")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x19BAA24", Offset = "0x19BAA24", VA = "0x19BAA24")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x19BACA4", Offset = "0x19BACA4", VA = "0x19BACA4")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x19BB084", Offset = "0x19BB084", VA = "0x19BB084")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x19BB0C8", Offset = "0x19BB0C8", VA = "0x19BB0C8")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x19BAE2C", Offset = "0x19BAE2C", VA = "0x19BAE2C")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x19BB110", Offset = "0x19BB110", VA = "0x19BB110")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x19BB130", Offset = "0x19BB130", VA = "0x19BB130")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x19BB1E0", Offset = "0x19BB1E0", VA = "0x19BB1E0")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x19BA52C", Offset = "0x19BA52C", VA = "0x19BA52C")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x19BB264", Offset = "0x19BB264", VA = "0x19BB264")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x19BAF18", Offset = "0x19BAF18", VA = "0x19BAF18")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE9195C", Offset = "0xE9195C")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Bounds? mBounds;

		[Token(Token = "0x17000173")]
		public Bounds Bounds
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x17B2914", Offset = "0x17B2914", VA = "0x17B2914")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x17B2990", Offset = "0x17B2990", VA = "0x17B2990")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public float Depth
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x17B2A9C", Offset = "0x17B2A9C", VA = "0x17B2A9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x17B2AE4", Offset = "0x17B2AE4", VA = "0x17B2AE4")]
		public CGBounds()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x17B2AF4", Offset = "0x17B2AF4", VA = "0x17B2AF4")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x17B2B40", Offset = "0x17B2B40", VA = "0x17B2B40")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x17B2BE0", Offset = "0x17B2BE0", VA = "0x17B2BE0", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x60007D2")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x17B2C08", Offset = "0x17B2C08", VA = "0x17B2C08")]
		public static void Copy(CGBounds dest, CGBounds source)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class CGVSubMesh : CGData
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Triangles;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material Material;

		[Token(Token = "0x17000175")]
		public override int Count
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x19B9864", Offset = "0x19B9864", VA = "0x19B9864", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x19B931C", Offset = "0x19B931C", VA = "0x19B931C")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x19B7D48", Offset = "0x19B7D48", VA = "0x19B7D48")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x19B9880", Offset = "0x19B9880", VA = "0x19B9880")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x19B7910", Offset = "0x19B7910", VA = "0x19B7910")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x60007D9")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x19B98F8", Offset = "0x19B98F8", VA = "0x19B98F8")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x19B9990", Offset = "0x19B9990", VA = "0x19B9990")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x19B88DC", Offset = "0x19B88DC", VA = "0x19B88DC")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE91980", Offset = "0xE91980")]
	public class CGVMesh : CGBounds
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] Vertex;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] UV;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] UV2;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3[] Normal;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector4[] Tangents;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CGVSubMesh[] SubMeshes;

		[Token(Token = "0x17000176")]
		public override int Count
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x19B733C", Offset = "0x19B733C", VA = "0x19B733C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000177")]
		public bool HasUV
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x19B7358", Offset = "0x19B7358", VA = "0x19B7358")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000178")]
		public bool HasUV2
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x19B737C", Offset = "0x19B737C", VA = "0x19B737C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000179")]
		public bool HasNormals
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x19B73A0", Offset = "0x19B73A0", VA = "0x19B73A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		public bool HasTangents
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x19B73C4", Offset = "0x19B73C4", VA = "0x19B73C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017B")]
		public int TriangleCount
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x19B73E8", Offset = "0x19B73E8", VA = "0x19B73E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x19B7474", Offset = "0x19B7474", VA = "0x19B7474")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x19B748C", Offset = "0x19B748C", VA = "0x19B748C")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x19B7594", Offset = "0x19B7594", VA = "0x19B7594")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x19B75F0", Offset = "0x19B75F0", VA = "0x19B75F0")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x19B76E4", Offset = "0x19B76E4", VA = "0x19B76E4")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x19B79B8", Offset = "0x19B79B8", VA = "0x19B79B8")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x19B7A24", Offset = "0x19B7A24", VA = "0x19B7A24")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x60007EA")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x19B7FD8", Offset = "0x19B7FD8", VA = "0x19B7FD8")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x19B8060", Offset = "0x19B8060", VA = "0x19B8060")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x19B8314", Offset = "0x19B8314", VA = "0x19B8314")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x19B8374", Offset = "0x19B8374", VA = "0x19B8374")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x19B83DC", Offset = "0x19B83DC", VA = "0x19B83DC")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x19B89C4", Offset = "0x19B89C4", VA = "0x19B89C4")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x19B8BC4", Offset = "0x19B8BC4", VA = "0x19B8BC4")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x19B851C", Offset = "0x19B851C", VA = "0x19B851C")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x19B87A8", Offset = "0x19B87A8", VA = "0x19B87A8")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x19B9390", Offset = "0x19B9390", VA = "0x19B9390")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x19B9408", Offset = "0x19B9408", VA = "0x19B9408")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x19B9544", Offset = "0x19B9544", VA = "0x19B9544")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x19B9628", Offset = "0x19B9628", VA = "0x19B9628", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x19B983C", Offset = "0x19B983C", VA = "0x19B983C")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x19B7D80", Offset = "0x19B7D80", VA = "0x19B7D80")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60007FA")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE919A4", Offset = "0xE919A4")]
	public class CGGameObject : CGBounds
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject Object;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 Translate;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Rotate;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 Scale;

		[Token(Token = "0x1700017C")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x17B4314", Offset = "0x17B4314", VA = "0x17B4314")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x17B4434", Offset = "0x17B4434", VA = "0x17B4434")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x17B44AC", Offset = "0x17B44AC", VA = "0x17B44AC")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x17B4620", Offset = "0x17B4620", VA = "0x17B4620")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x17B44F4", Offset = "0x17B44F4", VA = "0x17B44F4")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x17B4708", Offset = "0x17B4708", VA = "0x17B4708")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x6000801")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x17B47D0", Offset = "0x17B47D0", VA = "0x17B47D0")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x17B48E8", Offset = "0x17B48E8", VA = "0x17B48E8", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0xE919DC", Offset = "0xE919DC")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CGSpot[] Points;

		[Token(Token = "0x1700017D")]
		public override int Count
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x19B6960", Offset = "0x19B6960", VA = "0x19B6960", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x19B697C", Offset = "0x19B697C", VA = "0x19B697C")]
		public CGSpots()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x19B69E0", Offset = "0x19B69E0", VA = "0x19B69E0")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x19B6A0C", Offset = "0x19B6A0C", VA = "0x19B6A0C")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x19B6B40", Offset = "0x19B6B40", VA = "0x19B6B40")]
		public CGSpots(CGSpots source)
		{
		}

		[Token(Token = "0x6000809")]
		public override T Clone<T>()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E2")]
	public class CGDataRequestParameter
	{
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x17B4064", Offset = "0x17B4064", VA = "0x17B4064")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x17B3EA0", Offset = "0x17B3EA0", VA = "0x17B3EA0")]
		public CGDataRequestParameter()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool CheckHardEdges;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool CheckMaterialID;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool IncludeControlPoints;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool CheckExtendedUV;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x17B3E3C", Offset = "0x17B3E3C", VA = "0x17B3E3C")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x17B3EA8", Offset = "0x17B3EA8", VA = "0x17B3EA8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x17B3FBC", Offset = "0x17B3FBC", VA = "0x17B3FBC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E4")]
	public class CGDataRequestRasterization : CGDataRequestParameter
	{
		[Token(Token = "0x200015F")]
		public enum ModeEnum
		{
			[Token(Token = "0x4000592")]
			Even,
			[Token(Token = "0x4000593")]
			Optimized
		}

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RasterizedRelativeLength;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Resolution;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SplineAbsoluteLength;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AngleThreshold;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ModeEnum Mode;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x17B4070", Offset = "0x17B4070", VA = "0x17B4070")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float splineAbsoluteLength, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x17B413C", Offset = "0x17B413C", VA = "0x17B413C")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x17B4164", Offset = "0x17B4164", VA = "0x17B4164", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x17B425C", Offset = "0x17B425C", VA = "0x17B425C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E5")]
	public interface INoProcessing
	{
	}
	[Token(Token = "0x20000E6")]
	public interface IExternalInput
	{
		[Token(Token = "0x1700017E")]
		bool SupportsIPE
		{
			[Token(Token = "0x6000813")]
			get;
		}
	}
	[Token(Token = "0x20000E7")]
	public interface IOnRequestProcessing
	{
		[Token(Token = "0x6000814")]
		CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests);
	}
	[Token(Token = "0x20000E8")]
	public interface IOnRequestPath : IOnRequestProcessing
	{
		[Token(Token = "0x1700017F")]
		float PathLength
		{
			[Token(Token = "0x6000815")]
			get;
		}

		[Token(Token = "0x17000180")]
		bool PathIsClosed
		{
			[Token(Token = "0x6000816")]
			get;
		}
	}
	[Token(Token = "0x20000E9")]
	public interface ICGResourceLoader
	{
		[Token(Token = "0x6000817")]
		UnityEngine.Component Create(CGModule cgModule, string context);

		[Token(Token = "0x6000818")]
		void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill);
	}
	[Token(Token = "0x20000EA")]
	public interface ICGResourceCollection
	{
		[Token(Token = "0x17000181")]
		int Count
		{
			[Token(Token = "0x6000819")]
			get;
		}

		[Token(Token = "0x17000182")]
		UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x600081A")]
			get;
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE91A00", Offset = "0xE91A00")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE91A00", Offset = "0xE91A00")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer mRenderer;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider mCollider;

		[Token(Token = "0x17000183")]
		public MeshRenderer Renderer
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x17B5CB4", Offset = "0x17B5CB4", VA = "0x17B5CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		public Collider Collider
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x17B5D4C", Offset = "0x17B5D4C", VA = "0x17B5D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x17B5DE4", Offset = "0x17B5DE4", VA = "0x17B5DE4")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x17B5E40", Offset = "0x17B5E40", VA = "0x17B5E40")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x17B5FBC", Offset = "0x17B5FBC", VA = "0x17B5FBC")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x17B60A4", Offset = "0x17B60A4", VA = "0x17B60A4")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x17B661C", Offset = "0x17B661C", VA = "0x17B661C", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x17B6620", Offset = "0x17B6620", VA = "0x17B6620", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x17B6624", Offset = "0x17B6624", VA = "0x17B6624")]
		public CGMeshResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EC")]
	public class CGMeshResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<CGMeshResource> Items;

		[Token(Token = "0x17000185")]
		public int Count
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x17B662C", Offset = "0x17B662C", VA = "0x17B662C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000186")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x17B667C", Offset = "0x17B667C", VA = "0x17B667C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x17B66D4", Offset = "0x17B66D4", VA = "0x17B66D4")]
		public CGMeshResourceCollection()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[ExecuteInEditMode]
	public class CGModule : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE97A50", Offset = "0xE97A50")]
		[SerializeField]
		private CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE97AA8", Offset = "0xE97AA8")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE97B64", Offset = "0xE97B64")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0xE97B64", Offset = "0xE97B64")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE97B64", Offset = "0xE97B64")]
		[SerializeField]
		private bool m_RandomizeSeed;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private int m_Seed;

		[NonSerialized]
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> UIMessages;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CurvyGenerator mGenerator;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private int m_UniqueID;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97C80", Offset = "0xE97C80")]
		private bool <CircularReferenceError>k__BackingField;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int SortAncestors;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public CGModuleProperties Properties;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97CC0", Offset = "0xE97CC0")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97CD0", Offset = "0xE97CD0")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97CE0", Offset = "0xE97CE0")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97CF0", Offset = "0xE97CF0")]
		private List<CGModuleOutputSlot> <Output>k__BackingField;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ModuleInfoAttribute mInfo;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mDirty;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool mInitialized;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool mIsConfiguredInternal;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool mStateChangeDirty;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool mLastIsConfiguredState;

		[Token(Token = "0x17000187")]
		public CurvyCGEvent OnBeforeRefresh
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x17B6A40", Offset = "0x17B6A40", VA = "0x17B6A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x17B6A48", Offset = "0x17B6A48", VA = "0x17B6A48")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x17B6A5C", Offset = "0x17B6A5C", VA = "0x17B6A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x17B6A64", Offset = "0x17B6A64", VA = "0x17B6A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public string ModuleName
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x17B6B50", Offset = "0x17B6B50", VA = "0x17B6B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x17B6B58", Offset = "0x17B6B58", VA = "0x17B6B58")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public bool Active
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x17B6D94", Offset = "0x17B6D94", VA = "0x17B6D94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x17B6D9C", Offset = "0x17B6D9C", VA = "0x17B6D9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public int Seed
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x17B6EEC", Offset = "0x17B6EEC", VA = "0x17B6EEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x17B6EF4", Offset = "0x17B6EF4", VA = "0x17B6EF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x17B6F0C", Offset = "0x17B6F0C", VA = "0x17B6F0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x17B6F14", Offset = "0x17B6F14", VA = "0x17B6F14")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x17B6F34", Offset = "0x17B6F34", VA = "0x17B6F34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		public int UniqueID
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x17B6F3C", Offset = "0x17B6F3C", VA = "0x17B6F3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018F")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x17B6F44", Offset = "0x17B6F44", VA = "0x17B6F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DDA8", Offset = "0xE9DDA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x17B6F4C", Offset = "0x17B6F4C", VA = "0x17B6F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DDB8", Offset = "0xE9DDB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x17B6F58", Offset = "0x17B6F58", VA = "0x17B6F58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DDC8", Offset = "0xE9DDC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x17B6F60", Offset = "0x17B6F60", VA = "0x17B6F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DDD8", Offset = "0xE9DDD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x17B6F68", Offset = "0x17B6F68", VA = "0x17B6F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DDE8", Offset = "0xE9DDE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x17B6F70", Offset = "0x17B6F70", VA = "0x17B6F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DDF8", Offset = "0xE9DDF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x17B6F78", Offset = "0x17B6F78", VA = "0x17B6F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE08", Offset = "0xE9DE08")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x17B6F80", Offset = "0x17B6F80", VA = "0x17B6F80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE18", Offset = "0xE9DE18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x17B6F88", Offset = "0x17B6F88", VA = "0x17B6F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE28", Offset = "0xE9DE28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x17B6F90", Offset = "0x17B6F90", VA = "0x17B6F90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE38", Offset = "0xE9DE38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x17B6F98", Offset = "0x17B6F98", VA = "0x17B6F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		public bool Dirty
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x17B70B8", Offset = "0x17B70B8", VA = "0x17B70B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x17B6DF8", Offset = "0x17B6DF8", VA = "0x17B6DF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x17B87AC", Offset = "0x17B87AC", VA = "0x17B87AC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000197")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x17B89DC", Offset = "0x17B89DC", VA = "0x17B89DC", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x17B6A78", Offset = "0x17B6A78", VA = "0x17B6A78")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x17B6AE4", Offset = "0x17B6AE4", VA = "0x17B6AE4")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x17B72A4", Offset = "0x17B72A4", VA = "0x17B72A4", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x17B72FC", Offset = "0x17B72FC", VA = "0x17B72FC", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x17B7394", Offset = "0x17B7394", VA = "0x17B7394")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x17B7914", Offset = "0x17B7914", VA = "0x17B7914", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x17B7918", Offset = "0x17B7918", VA = "0x17B7918", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x17B87A4", Offset = "0x17B87A4", VA = "0x17B87A4")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x17B89E4", Offset = "0x17B89E4", VA = "0x17B89E4", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x17B8A3C", Offset = "0x17B8A3C", VA = "0x17B8A3C", Slot = "12")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x17B8B68", Offset = "0x17B8B68", VA = "0x17B8B68")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x17B8C6C", Offset = "0x17B8C6C", VA = "0x17B8C6C", Slot = "13")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x17B8D10", Offset = "0x17B8D10", VA = "0x17B8D10", Slot = "14")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000851")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x17B8D14", Offset = "0x17B8D14", VA = "0x17B8D14")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x17B8DC4", Offset = "0x17B8DC4", VA = "0x17B8DC4")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x17B8EA4", Offset = "0x17B8EA4", VA = "0x17B8EA4")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x17B8FBC", Offset = "0x17B8FBC", VA = "0x17B8FBC")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x17B8FC4", Offset = "0x17B8FC4", VA = "0x17B8FC4")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x17B8DCC", Offset = "0x17B8DCC", VA = "0x17B8DCC")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x17B8EAC", Offset = "0x17B8EAC", VA = "0x17B8EAC")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x17B8FCC", Offset = "0x17B8FCC", VA = "0x17B8FCC")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x17B90E8", Offset = "0x17B90E8", VA = "0x17B90E8")]
		public UnityEngine.Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x17B8250", Offset = "0x17B8250", VA = "0x17B8250")]
		public void DeleteManagedResource(string resourceName, UnityEngine.Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x17B9364", Offset = "0x17B9364", VA = "0x17B9364")]
		public bool IsManagedResource(UnityEngine.Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x17B91DC", Offset = "0x17B91DC", VA = "0x17B91DC")]
		protected void RenameResource(string resourceName, UnityEngine.Component resource, int index = -1)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x17B9450", Offset = "0x17B9450", VA = "0x17B9450")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x17B95A8", Offset = "0x17B95A8", VA = "0x17B95A8")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x17B9678", Offset = "0x17B9678", VA = "0x17B9678")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x17B9748", Offset = "0x17B9748", VA = "0x17B9748")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x17B97F0", Offset = "0x17B97F0", VA = "0x17B97F0")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x17B832C", Offset = "0x17B832C", VA = "0x17B832C")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x17B3C24", Offset = "0x17B3C24", VA = "0x17B3C24")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x17B8568", Offset = "0x17B8568", VA = "0x17B8568")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x17B7DF0", Offset = "0x17B7DF0", VA = "0x17B7DF0")]
		public bool GetManagedResources(out List<UnityEngine.Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x17B90BC", Offset = "0x17B90BC", VA = "0x17B90BC")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x17B9884", Offset = "0x17B9884", VA = "0x17B9884")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x17B9974", Offset = "0x17B9974", VA = "0x17B9974")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x17B9B60", Offset = "0x17B9B60", VA = "0x17B9B60")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x17B9CA0", Offset = "0x17B9CA0", VA = "0x17B9CA0")]
		private static void setSeed(int seed)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x17B6FC8", Offset = "0x17B6FC8", VA = "0x17B6FC8")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x17B9CA8", Offset = "0x17B9CA8", VA = "0x17B9CA8")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x17B7574", Offset = "0x17B7574", VA = "0x17B7574")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x17B9D14", Offset = "0x17B9D14", VA = "0x17B9D14")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x17B7C3C", Offset = "0x17B7C3C", VA = "0x17B7C3C")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x17B70C0", Offset = "0x17B70C0", VA = "0x17B70C0")]
		private void setTreeDirtyState()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x17BA0B4", Offset = "0x17BA0B4", VA = "0x17BA0B4")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x17B6BB0", Offset = "0x17B6BB0", VA = "0x17B6BB0")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x17BA0F0", Offset = "0x17BA0F0", VA = "0x17BA0F0")]
		public CGModule()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE91A9C", Offset = "0xE91A9C")]
	public sealed class ModuleInfoAttribute : Attribute, IComparable
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string MenuName;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ModuleName;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool UsesRandom;

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x19BE310", Offset = "0x19BE310", VA = "0x19BE310")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x19BE33C", Offset = "0x19BE33C", VA = "0x19BE33C", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000EF")]
	public class CGModuleProperties
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect Dimensions;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinWidth;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LabelWidth;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color BackgroundColor;

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x19B3388", Offset = "0x19B3388", VA = "0x19B3388")]
		public CGModuleProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F0")]
	public class CGModuleLink
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ModuleID;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_TargetModuleID;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_TargetSlotName;

		[Token(Token = "0x17000198")]
		public int ModuleID
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x19B2548", Offset = "0x19B2548", VA = "0x19B2548")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000199")]
		public string SlotName
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x19B2550", Offset = "0x19B2550", VA = "0x19B2550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public int TargetModuleID
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x19B2558", Offset = "0x19B2558", VA = "0x19B2558")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019B")]
		public string TargetSlotName
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x19B2560", Offset = "0x19B2560", VA = "0x19B2560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x19B2568", Offset = "0x19B2568", VA = "0x19B2568")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x19B1818", Offset = "0x19B1818", VA = "0x19B1818")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x19B2618", Offset = "0x19B2618", VA = "0x19B2618")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x19B2690", Offset = "0x19B2690", VA = "0x19B2690")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x19B27AC", Offset = "0x19B27AC", VA = "0x19B27AC")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x19B2850", Offset = "0x19B2850", VA = "0x19B2850")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x19B28F4", Offset = "0x19B28F4", VA = "0x19B28F4")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x19B292C", Offset = "0x19B292C", VA = "0x19B292C")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x19B29A4", Offset = "0x19B29A4", VA = "0x19B29A4")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x19B180C", Offset = "0x19B180C", VA = "0x19B180C")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x19B29B0", Offset = "0x19B29B0", VA = "0x19B29B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F1")]
	public class CGModuleSlot
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97D40", Offset = "0xE97D40")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97D50", Offset = "0xE97D50")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97D60", Offset = "0xE97D60")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE97D70", Offset = "0xE97D70")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x1700019C")]
		public CGModule Module
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x19B33C4", Offset = "0x19B33C4", VA = "0x19B33C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE48", Offset = "0xE9DE48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x19B33CC", Offset = "0x19B33CC", VA = "0x19B33CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE58", Offset = "0xE9DE58")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public SlotInfo Info
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x19B33D4", Offset = "0x19B33D4", VA = "0x19B33D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE68", Offset = "0xE9DE68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x19B33DC", Offset = "0x19B33DC", VA = "0x19B33DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE78", Offset = "0xE9DE78")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public Vector2 Origin
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x19B33E4", Offset = "0x19B33E4", VA = "0x19B33E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE88", Offset = "0xE9DE88")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x19B33EC", Offset = "0x19B33EC", VA = "0x19B33EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DE98", Offset = "0xE9DE98")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public Rect DropZone
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x19B33F4", Offset = "0x19B33F4", VA = "0x19B33F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DEA8", Offset = "0xE9DEA8")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x19B3400", Offset = "0x19B3400", VA = "0x19B3400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DEB8", Offset = "0xE9DEB8")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public bool IsLinked
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x19B30A8", Offset = "0x19B30A8", VA = "0x19B30A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A1")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x19B340C", Offset = "0x19B340C", VA = "0x19B340C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A2")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x19B2264", Offset = "0x19B2264", VA = "0x19B2264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x19B34E8", Offset = "0x19B34E8", VA = "0x19B34E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A4")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x19B3538", Offset = "0x19B3538", VA = "0x19B3538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A5")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x19B1A1C", Offset = "0x19B1A1C", VA = "0x19B1A1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A6")]
		public int Count
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x19B2128", Offset = "0x19B2128", VA = "0x19B2128")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A7")]
		public string Name
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x19B25BC", Offset = "0x19B25BC", VA = "0x19B25BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x19B1420", Offset = "0x19B1420", VA = "0x19B1420")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x19B1C2C", Offset = "0x19B1C2C", VA = "0x19B1C2C")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x19B3588", Offset = "0x19B3588", VA = "0x19B3588")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x19B1CEC", Offset = "0x19B1CEC", VA = "0x19B1CEC", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x19B1F50", Offset = "0x19B1F50", VA = "0x19B1F50", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x19B368C", Offset = "0x19B368C", VA = "0x19B368C", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x19B18E0", Offset = "0x19B18E0", VA = "0x19B18E0")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x19B3690", Offset = "0x19B3690", VA = "0x19B3690")]
		public void ReInitializeLinkedTargetModules()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x19B175C", Offset = "0x19B175C", VA = "0x19B175C", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x19B37D4", Offset = "0x19B37D4", VA = "0x19B37D4")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x19B37E0", Offset = "0x19B37E0", VA = "0x19B37E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class CGModuleInputSlot : CGModuleSlot
	{
		[Token(Token = "0x170001A8")]
		public InputSlotInfo InputInfo
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x19B13B0", Offset = "0x19B13B0", VA = "0x19B13B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x19B1418", Offset = "0x19B1418", VA = "0x19B1418")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x19B1428", Offset = "0x19B1428", VA = "0x19B1428", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x19B18E8", Offset = "0x19B18E8", VA = "0x19B18E8", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x19B1AA4", Offset = "0x19B1AA4", VA = "0x19B1AA4", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x19B1DEC", Offset = "0x19B1DEC", VA = "0x19B1DEC", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x19B2050", Offset = "0x19B2050", VA = "0x19B2050")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x19B217C", Offset = "0x19B217C", VA = "0x19B217C")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x19B231C", Offset = "0x19B231C", VA = "0x19B231C")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x19B24A4", Offset = "0x19B24A4", VA = "0x19B24A4")]
		private CGModule SourceModule(int index)
		{
			return null;
		}

		[Token(Token = "0x60008AC")]
		public T GetData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008AD")]
		public List<T> GetAllData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		private CGData[] GetData<T>(int slotIndex, params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		private static CGData[] cloneData<T>(ref CGData[] source) where T : CGData
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public class CGModuleOutputSlot : CGModuleSlot
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CGData[] Data;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CGDataRequestParameter[] LastRequestParameters;

		[Token(Token = "0x170001A9")]
		public OutputSlotInfo OutputInfo
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x19B22B4", Offset = "0x19B22B4", VA = "0x19B22B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AA")]
		public bool HasData
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x19B3274", Offset = "0x19B3274", VA = "0x19B3274")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x19B2B60", Offset = "0x19B2B60", VA = "0x19B2B60")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x19B2BC0", Offset = "0x19B2BC0", VA = "0x19B2BC0", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x19B2EF4", Offset = "0x19B2EF4", VA = "0x19B2EF4", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x19B3110", Offset = "0x19B3110", VA = "0x19B3110", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x19B32B4", Offset = "0x19B32B4", VA = "0x19B32B4")]
		public void ClearData()
		{
		}

		[Token(Token = "0x60008B7")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x19B330C", Offset = "0x19B330C", VA = "0x19B330C")]
		public void SetData(params CGData[] data)
		{
		}

		[Token(Token = "0x60008B9")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60008BA")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}
	}
	[Token(Token = "0x20000F4")]
	public class SlotInfo : Attribute, IComparable
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type[] DataTypes;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string displayName;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Tooltip;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Array;

		[Token(Token = "0x170001AB")]
		public string DisplayName
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1903304", Offset = "0x1903304", VA = "0x1903304")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x190331C", Offset = "0x190331C", VA = "0x190331C")]
			set
			{
			}
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x19023E0", Offset = "0x19023E0", VA = "0x19023E0")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1903324", Offset = "0x1903324", VA = "0x1903324")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1903350", Offset = "0x1903350", VA = "0x1903350", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE91AB0", Offset = "0xE91AB0")]
	public sealed class InputSlotInfo : SlotInfo
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool RequestDataOnly;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Optional;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool ModifiesData;

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x19BE2F8", Offset = "0x19BE2F8", VA = "0x19BE2F8")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x19BE300", Offset = "0x19BE300", VA = "0x19BE300")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x19B2398", Offset = "0x19B2398", VA = "0x19B2398")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE91AE4", Offset = "0xE91AE4")]
	public sealed class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x170001AC")]
		public Type DataType
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x19022E4", Offset = "0x19022E4", VA = "0x19022E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1902318", Offset = "0x1902318", VA = "0x1902318")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1902324", Offset = "0x1902324", VA = "0x1902324")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE91B18", Offset = "0xE91B18")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ResourceName;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1902418", Offset = "0x1902418", VA = "0x1902418")]
		public ResourceLoaderAttribute(string resName)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public static class CGResourceHandler
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, ICGResourceLoader> Loader;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x19B4A48", Offset = "0x19B4A48", VA = "0x19B4A48")]
		public static UnityEngine.Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x19B4EE8", Offset = "0x19B4EE8", VA = "0x19B4EE8")]
		public static void DestroyResource(CGModule module, string resName, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x19B4C58", Offset = "0x19B4C58", VA = "0x19B4C58")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0xE91B2C", Offset = "0xE91B2C")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x19B605C", Offset = "0x19B605C", VA = "0x19B605C", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x19B61F8", Offset = "0x19B61F8", VA = "0x19B61F8", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x19B6298", Offset = "0x19B6298", VA = "0x19B6298")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0xE91B64", Offset = "0xE91B64")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x19B5EBC", Offset = "0x19B5EBC", VA = "0x19B5EBC", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x19B5FB4", Offset = "0x19B5FB4", VA = "0x19B5FB4", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x19B6054", Offset = "0x19B6054", VA = "0x19B6054")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0xE91B9C", Offset = "0xE91B9C")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x17B6744", Offset = "0x17B6744", VA = "0x17B6744", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x17B67BC", Offset = "0x17B67BC", VA = "0x17B67BC", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x17B6A38", Offset = "0x17B6A38", VA = "0x17B6A38")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0xE91BD4", Offset = "0xE91BD4")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x17B52A0", Offset = "0x17B52A0", VA = "0x17B52A0", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x17B53C0", Offset = "0x17B53C0", VA = "0x17B53C0", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x17B55D8", Offset = "0x17B55D8", VA = "0x17B55D8")]
		public CGGameObjectResourceLoader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FD")]
	public class CGGameObjectResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Transform> Items;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> PoolNames;

		[Token(Token = "0x170001AD")]
		public int Count
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x17B5160", Offset = "0x17B5160", VA = "0x17B5160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AE")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x17B51B0", Offset = "0x17B51B0", VA = "0x17B51B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x17B5208", Offset = "0x17B5208", VA = "0x17B5208")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public static class CGUtility
	{
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x19B6B78", Offset = "0x19B6B78", VA = "0x19B6B78")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x19B6C9C", Offset = "0x19B6C9C", VA = "0x19B6C9C")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FF")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91C0C", Offset = "0xE91C0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE91C0C", Offset = "0xE91C0C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE91C0C", Offset = "0xE91C0C")]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE929E8", Offset = "0xE929E8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGModule, bool> <>9__47_0;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGModule, float> <>9__47_1;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__65_0;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<CGModule, float> <>9__65_1;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__66_0;

			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x19BE204", Offset = "0x19BE204", VA = "0x19BE204")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x19BE20C", Offset = "0x19BE20C", VA = "0x19BE20C")]
			internal bool <ReorderModules>b__47_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x19BE270", Offset = "0x19BE270", VA = "0x19BE270")]
			internal float <ReorderModules>b__47_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x19BE298", Offset = "0x19BE298", VA = "0x19BE298")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x19BE2B0", Offset = "0x19BE2B0", VA = "0x19BE2B0")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x19BE2D8", Offset = "0x19BE2D8", VA = "0x19BE2D8")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE929F8", Offset = "0xE929F8")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x19BE0C4", Offset = "0x19BE0C4", VA = "0x19BE0C4")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x19BE2F0", Offset = "0x19BE2F0", VA = "0x19BE2F0")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE97D80", Offset = "0xE97D80")]
		[SerializeField]
		private bool m_ShowDebug;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE97DCC", Offset = "0xE97DCC")]
		[SerializeField]
		private bool m_AutoRefresh;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE97E18", Offset = "0xE97E18")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelay;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE97EF0", Offset = "0xE97EF0")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE97FC8", Offset = "0xE97FC8")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<CGModule> Modules;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE98078", Offset = "0xE98078")]
		private bool <Destroying>k__BackingField;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<int, CGModule> ModulesByID;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool mInitialized;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool mInitializedPhaseOne;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool mNeedSort;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private double mLastUpdateTime;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PoolManager mPoolManager;

		[Token(Token = "0x4000370")]
		private const int ModulesReorderingDeltaX = 50;

		[Token(Token = "0x4000371")]
		private const int ModulesReorderingDeltaY = 20;

		[Token(Token = "0x170001AF")]
		public bool ShowDebug
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x19BB688", Offset = "0x19BB688", VA = "0x19BB688")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x19BB690", Offset = "0x19BB690", VA = "0x19BB690")]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public bool AutoRefresh
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x19BB6B0", Offset = "0x19BB6B0", VA = "0x19BB6B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x19BB6B8", Offset = "0x19BB6B8", VA = "0x19BB6B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public int RefreshDelay
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x19BB6D8", Offset = "0x19BB6D8", VA = "0x19BB6D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x19BB6E0", Offset = "0x19BB6E0", VA = "0x19BB6E0")]
			set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x19BB76C", Offset = "0x19BB76C", VA = "0x19BB76C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x19BB774", Offset = "0x19BB774", VA = "0x19BB774")]
			set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x19BB800", Offset = "0x19BB800", VA = "0x19BB800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x19BB898", Offset = "0x19BB898", VA = "0x19BB898")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x19BB8A0", Offset = "0x19BB8A0", VA = "0x19BB8A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001B5")]
		public bool IsInitialized
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x19BB8B4", Offset = "0x19BB8B4", VA = "0x19BB8B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B6")]
		public bool Destroying
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x19BB8BC", Offset = "0x19BB8BC", VA = "0x19BB8BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DEC8", Offset = "0xE9DEC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x19BB8C4", Offset = "0x19BB8C4", VA = "0x19BB8C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DED8", Offset = "0xE9DED8")]
			private set
			{
			}
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x19BB8D0", Offset = "0x19BB8D0", VA = "0x19BB8D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x19BB8D4", Offset = "0x19BB8D4", VA = "0x19BB8D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x19BB8F8", Offset = "0x19BB8F8", VA = "0x19BB8F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x19BB908", Offset = "0x19BB908", VA = "0x19BB908")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x19BB914", Offset = "0x19BB914", VA = "0x19BB914")]
		private void Update()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x19BC360", Offset = "0x19BC360", VA = "0x19BC360")]
		public static CurvyGenerator Create()
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		public T AddModule<T>() where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x19BC478", Offset = "0x19BC478", VA = "0x19BC478")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x19BC5C8", Offset = "0x19BC5C8", VA = "0x19BC5C8")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x19BC8F0", Offset = "0x19BC8F0", VA = "0x19BC8F0")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x19BD4F8", Offset = "0x19BD4F8", VA = "0x19BD4F8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x19BD610", Offset = "0x19BD610", VA = "0x19BD610")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x60008F6")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x19BD69C", Offset = "0x19BD69C", VA = "0x19BD69C")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x19B1760", Offset = "0x19B1760", VA = "0x19B1760")]
		public CGModule GetModule(int moduleID, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		public T GetModule<T>(int moduleID, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x19BD7EC", Offset = "0x19BD7EC", VA = "0x19BD7EC")]
		public CGModule GetModule(string moduleName, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		public T GetModule<T>(string moduleName, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x19BD92C", Offset = "0x19BD92C", VA = "0x19BD92C")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x19BD9EC", Offset = "0x19BD9EC", VA = "0x19BD9EC")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x19BB9B0", Offset = "0x19BB9B0", VA = "0x19BB9B0")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x19BBD6C", Offset = "0x19BBD6C", VA = "0x19BBD6C")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x19BDE40", Offset = "0x19BDE40", VA = "0x19BDE40")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x19BD4FC", Offset = "0x19BD4FC", VA = "0x19BD4FC")]
		private void clearModules()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x19BDEAC", Offset = "0x19BDEAC", VA = "0x19BDEAC")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x19B3680", Offset = "0x19B3680", VA = "0x19B3680")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x19BDAAC", Offset = "0x19BDAAC", VA = "0x19BDAAC")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x19BD058", Offset = "0x19BD058", VA = "0x19BD058")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x19BCE00", Offset = "0x19BCE00", VA = "0x19BCE00")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x19BE0CC", Offset = "0x19BE0CC", VA = "0x19BE0CC")]
		public CurvyGenerator()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91CCC", Offset = "0xE91CCC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91CCC", Offset = "0xE91CCC")]
	public class BuildRasterizedPath : CGModule
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE98088", Offset = "0xE98088")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE98140", Offset = "0xE98140")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE98234", Offset = "0xE98234")]
		private int m_Resolution;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE982B0", Offset = "0xE982B0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE982B0", Offset = "0xE982B0")]
		private float m_AngleTreshold;

		[Token(Token = "0x170001B7")]
		public float From
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x19BE3C0", Offset = "0x19BE3C0", VA = "0x19BE3C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x19BE3C8", Offset = "0x19BE3C8", VA = "0x19BE3C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public float To
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x19BE460", Offset = "0x19BE460", VA = "0x19BE460")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x19BE468", Offset = "0x19BE468", VA = "0x19BE468")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public float Length
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x19BE630", Offset = "0x19BE630", VA = "0x19BE630")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x19BE660", Offset = "0x19BE660", VA = "0x19BE660")]
			set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public int Resolution
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x19BE6B4", Offset = "0x19BE6B4", VA = "0x19BE6B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x19BE6BC", Offset = "0x19BE6BC", VA = "0x19BE6BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001BB")]
		public bool Optimize
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x19BE758", Offset = "0x19BE758", VA = "0x19BE758")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x19BE760", Offset = "0x19BE760", VA = "0x19BE760")]
			set
			{
			}
		}

		[Token(Token = "0x170001BC")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x19BE788", Offset = "0x19BE788", VA = "0x19BE788")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x19BE790", Offset = "0x19BE790", VA = "0x19BE790")]
			set
			{
			}
		}

		[Token(Token = "0x170001BD")]
		public CGPath Path
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x19BE834", Offset = "0x19BE834", VA = "0x19BE834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x19BE540", Offset = "0x19BE540", VA = "0x19BE540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BF")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x19BE88C", Offset = "0x19BE88C", VA = "0x19BE88C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x19BE944", Offset = "0x19BE944", VA = "0x19BE944", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x19BE98C", Offset = "0x19BE98C", VA = "0x19BE98C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x19BEA00", Offset = "0x19BEA00", VA = "0x19BEA00", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x19BEC84", Offset = "0x19BEC84", VA = "0x19BEC84")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91D4C", Offset = "0xE91D4C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91D4C", Offset = "0xE91D4C")]
	public class BuildShapeExtrusion : CGModule
	{
		[Token(Token = "0x2000162")]
		public enum ScaleModeEnum
		{
			[Token(Token = "0x400059C")]
			Simple,
			[Token(Token = "0x400059D")]
			Advanced
		}

		[Token(Token = "0x2000163")]
		public enum CrossShiftModeEnum
		{
			[Token(Token = "0x400059F")]
			None,
			[Token(Token = "0x40005A0")]
			ByOrientation,
			[Token(Token = "0x40005A1")]
			Custom
		}

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE983AC", Offset = "0xE983AC")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE98454", Offset = "0xE98454")]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE984FC", Offset = "0xE984FC")]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE98570", Offset = "0xE98570")]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE985E4", Offset = "0xE985E4")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE98664", Offset = "0xE98664")]
		private int m_Resolution;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE986E0", Offset = "0xE986E0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE986E0", Offset = "0xE986E0")]
		private float m_AngleThreshold;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE987EC", Offset = "0xE987EC")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE987EC", Offset = "0xE987EC")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE98898", Offset = "0xE98898")]
		private int m_CrossResolution;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98918", Offset = "0xE98918")]
		private bool m_CrossOptimize;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE98978", Offset = "0xE98978")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE98978", Offset = "0xE98978")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98A84", Offset = "0xE98A84")]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98AE4", Offset = "0xE98AE4")]
		private bool m_CrossHardEdges;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98B44", Offset = "0xE98B44")]
		private bool m_CrossMaterials;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98BA4", Offset = "0xE98BA4")]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98C04", Offset = "0xE98C04")]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE98C78", Offset = "0xE98C78")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE98C78", Offset = "0xE98C78")]
		private float m_CrossShiftValue;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98D74", Offset = "0xE98D74")]
		[SerializeField]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE98DDC", Offset = "0xE98DDC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98DDC", Offset = "0xE98DDC")]
		[SerializeField]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE98E68", Offset = "0xE98E68")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98E68", Offset = "0xE98E68")]
		[SerializeField]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE98F54", Offset = "0xE98F54")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE98F54", Offset = "0xE98F54")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE99040", Offset = "0xE99040")]
		private bool m_ScaleUniform;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE990C4", Offset = "0xE990C4")]
		private float m_ScaleY;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE99174", Offset = "0xE99174")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0xE99174", Offset = "0xE99174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE99174", Offset = "0xE99174")]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE99284", Offset = "0xE99284")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0xE99284", Offset = "0xE99284")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE99284", Offset = "0xE99284")]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE993D8", Offset = "0xE993D8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE993D8", Offset = "0xE993D8")]
		[SerializeField]
		private float m_HollowInset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE99484", Offset = "0xE99484")]
		[SerializeField]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE994EC", Offset = "0xE994EC")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE994FC", Offset = "0xE994FC")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9950C", Offset = "0xE9950C")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9951C", Offset = "0xE9951C")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9952C", Offset = "0xE9952C")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170001C0")]
		public float From
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x19BED24", Offset = "0x19BED24", VA = "0x19BED24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x19BED2C", Offset = "0x19BED2C", VA = "0x19BED2C")]
			set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public float To
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x19BEDC4", Offset = "0x19BEDC4", VA = "0x19BEDC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x19BEDCC", Offset = "0x19BEDCC", VA = "0x19BEDCC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C2")]
		public float Length
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x19BEF7C", Offset = "0x19BEF7C", VA = "0x19BEF7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x19BEFAC", Offset = "0x19BEFAC", VA = "0x19BEFAC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C3")]
		public int Resolution
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x19BF000", Offset = "0x19BF000", VA = "0x19BF000")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x19BF008", Offset = "0x19BF008", VA = "0x19BF008")]
			set
			{
			}
		}

		[Token(Token = "0x170001C4")]
		public bool Optimize
		{
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x19BF0A4", Offset = "0x19BF0A4", VA = "0x19BF0A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x19BF0AC", Offset = "0x19BF0AC", VA = "0x19BF0AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C5")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x19BF0D4", Offset = "0x19BF0D4", VA = "0x19BF0D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x19BF0DC", Offset = "0x19BF0DC", VA = "0x19BF0DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C6")]
		public float CrossFrom
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x19BF180", Offset = "0x19BF180", VA = "0x19BF180")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x19BF188", Offset = "0x19BF188", VA = "0x19BF188")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		public float CrossTo
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x19BF220", Offset = "0x19BF220", VA = "0x19BF220")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x19BF228", Offset = "0x19BF228", VA = "0x19BF228")]
			set
			{
			}
		}

		[Token(Token = "0x170001C8")]
		public float CrossLength
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x19BF3D8", Offset = "0x19BF3D8", VA = "0x19BF3D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x19BF408", Offset = "0x19BF408", VA = "0x19BF408")]
			set
			{
			}
		}

		[Token(Token = "0x170001C9")]
		public int CrossResolution
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x19BF45C", Offset = "0x19BF45C", VA = "0x19BF45C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x19BF464", Offset = "0x19BF464", VA = "0x19BF464")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public bool CrossOptimize
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x19BF500", Offset = "0x19BF500", VA = "0x19BF500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x19BF508", Offset = "0x19BF508", VA = "0x19BF508")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x19BF530", Offset = "0x19BF530", VA = "0x19BF530")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x19BF538", Offset = "0x19BF538", VA = "0x19BF538")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x19BF5DC", Offset = "0x19BF5DC", VA = "0x19BF5DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x19BF5E4", Offset = "0x19BF5E4", VA = "0x19BF5E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x19BF60C", Offset = "0x19BF60C", VA = "0x19BF60C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x19BF614", Offset = "0x19BF614", VA = "0x19BF614")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public bool CrossMaterials
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x19BF63C", Offset = "0x19BF63C", VA = "0x19BF63C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x19BF644", Offset = "0x19BF644", VA = "0x19BF644")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x19BF66C", Offset = "0x19BF66C", VA = "0x19BF66C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x19BF674", Offset = "0x19BF674", VA = "0x19BF674")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x19BF69C", Offset = "0x19BF69C", VA = "0x19BF69C")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x19BF6A4", Offset = "0x19BF6A4", VA = "0x19BF6A4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		public float CrossShiftValue
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x19BF6C0", Offset = "0x19BF6C0", VA = "0x19BF6C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x19BF6C8", Offset = "0x19BF6C8", VA = "0x19BF6C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x19BF760", Offset = "0x19BF760", VA = "0x19BF760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x19BF768", Offset = "0x19BF768", VA = "0x19BF768")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x19BF790", Offset = "0x19BF790", VA = "0x19BF790")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x19BF798", Offset = "0x19BF798", VA = "0x19BF798")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x19BF7B4", Offset = "0x19BF7B4", VA = "0x19BF7B4")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x19BF7BC", Offset = "0x19BF7BC", VA = "0x19BF7BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public bool ScaleUniform
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x19BF7D8", Offset = "0x19BF7D8", VA = "0x19BF7D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x19BF7E0", Offset = "0x19BF7E0", VA = "0x19BF7E0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public float ScaleOffset
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x19BF808", Offset = "0x19BF808", VA = "0x19BF808")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x19BF810", Offset = "0x19BF810", VA = "0x19BF810")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public float ScaleX
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x19BF82C", Offset = "0x19BF82C", VA = "0x19BF82C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x19BF834", Offset = "0x19BF834", VA = "0x19BF834")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public float ScaleY
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x19BF850", Offset = "0x19BF850", VA = "0x19BF850")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x19BF858", Offset = "0x19BF858", VA = "0x19BF858")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x19BF874", Offset = "0x19BF874", VA = "0x19BF874")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x19BF87C", Offset = "0x19BF87C", VA = "0x19BF87C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x19BF898", Offset = "0x19BF898", VA = "0x19BF898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x19BF8A0", Offset = "0x19BF8A0", VA = "0x19BF8A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		public float HollowInset
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x19BF8BC", Offset = "0x19BF8BC", VA = "0x19BF8BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x19BF8C4", Offset = "0x19BF8C4", VA = "0x19BF8C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x19BF958", Offset = "0x19BF958", VA = "0x19BF958")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x19BF960", Offset = "0x19BF960", VA = "0x19BF960")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public int PathSamples
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x19BF988", Offset = "0x19BF988", VA = "0x19BF988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DEE8", Offset = "0xE9DEE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x19BF990", Offset = "0x19BF990", VA = "0x19BF990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DEF8", Offset = "0xE9DEF8")]
			private set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public int CrossSamples
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x19BF998", Offset = "0x19BF998", VA = "0x19BF998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF08", Offset = "0xE9DF08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x19BF9A0", Offset = "0x19BF9A0", VA = "0x19BF9A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF18", Offset = "0xE9DF18")]
			private set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public int CrossGroups
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x19BF9A8", Offset = "0x19BF9A8", VA = "0x19BF9A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF28", Offset = "0xE9DF28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x19BF9B0", Offset = "0x19BF9B0", VA = "0x19BF9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF38", Offset = "0xE9DF38")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public IExternalInput Cross
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x19BF9B8", Offset = "0x19BF9B8", VA = "0x19BF9B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E1")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x19BFA0C", Offset = "0x19BFA0C", VA = "0x19BFA0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF48", Offset = "0xE9DF48")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x19BFA1C", Offset = "0x19BFA1C", VA = "0x19BFA1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF58", Offset = "0xE9DF58")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x19BFA2C", Offset = "0x19BFA2C", VA = "0x19BFA2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF68", Offset = "0xE9DF68")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x19BFA40", Offset = "0x19BFA40", VA = "0x19BFA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF78", Offset = "0xE9DF78")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		private bool ClampPath
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x19BEE8C", Offset = "0x19BEE8C", VA = "0x19BEE8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E4")]
		private bool ClampCross
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x19BF2E8", Offset = "0x19BF2E8", VA = "0x19BF2E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E5")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x19BFA54", Offset = "0x19BFA54", VA = "0x19BFA54")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x170001E6")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x19BFB0C", Offset = "0x19BFB0C", VA = "0x19BFB0C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x19BFBC4", Offset = "0x19BFBC4", VA = "0x19BFBC4", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x19BFC0C", Offset = "0x19BFC0C", VA = "0x19BFC0C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x19BFEE8", Offset = "0x19BFEE8", VA = "0x19BFEE8", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x19C0DC4", Offset = "0x19C0DC4", VA = "0x19C0DC4")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x19C0D00", Offset = "0x19C0D00", VA = "0x19C0D00")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x19C0EC4", Offset = "0x19C0EC4", VA = "0x19C0EC4")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91DCC", Offset = "0xE91DCC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91DCC", Offset = "0xE91DCC")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9953C", Offset = "0xE9953C")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE995CC", Offset = "0xE995CC")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE99678", Offset = "0xE99678")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE996F8", Offset = "0xE996F8")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE99754", Offset = "0xE99754")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE997B0", Offset = "0xE997B0")]
		[Inline]
		[SerializeField]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE9980C", Offset = "0xE9980C")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE99874", Offset = "0xE99874")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0xE998C0", Offset = "0xE998C0")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0xE998C0", Offset = "0xE998C0")]
		[SerializeField]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0xE99984", Offset = "0xE99984")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE99984", Offset = "0xE99984")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE99984", Offset = "0xE99984")]
		[SerializeField]
		private Material m_EndMaterial;

		[Token(Token = "0x170001E7")]
		public bool GenerateUV
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x19C1010", Offset = "0x19C1010", VA = "0x19C1010")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x19C1018", Offset = "0x19C1018", VA = "0x19C1018")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x19C1040", Offset = "0x19C1040", VA = "0x19C1040")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x19C1048", Offset = "0x19C1048", VA = "0x19C1048")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x19C1070", Offset = "0x19C1070", VA = "0x19C1070")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x19C1078", Offset = "0x19C1078", VA = "0x19C1078")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public Material StartMaterial
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x19C1094", Offset = "0x19C1094", VA = "0x19C1094")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x19C109C", Offset = "0x19C109C", VA = "0x19C109C")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x19C1130", Offset = "0x19C1130", VA = "0x19C1130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EC")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x19C1138", Offset = "0x19C1138", VA = "0x19C1138")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x19C1140", Offset = "0x19C1140", VA = "0x19C1140")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public bool CloneStartCap
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x19C115C", Offset = "0x19C115C", VA = "0x19C115C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x19C1164", Offset = "0x19C1164", VA = "0x19C1164")]
			set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x19C118C", Offset = "0x19C118C", VA = "0x19C118C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EF")]
		public Material EndMaterial
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x19C1194", Offset = "0x19C1194", VA = "0x19C1194")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x19C119C", Offset = "0x19C119C", VA = "0x19C119C")]
			set
			{
			}
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x19C1230", Offset = "0x19C1230", VA = "0x19C1230", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x19C1320", Offset = "0x19C1320", VA = "0x19C1320", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x19C1474", Offset = "0x19C1474", VA = "0x19C1474", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x19C1FB0", Offset = "0x19C1FB0", VA = "0x19C1FB0")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x19C2528", Offset = "0x19C2528", VA = "0x19C2528")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x19C22A4", Offset = "0x19C22A4", VA = "0x19C22A4")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x19C1E44", Offset = "0x19C1E44", VA = "0x19C1E44")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int index)
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x19C25B0", Offset = "0x19C25B0", VA = "0x19C25B0")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x19C28CC", Offset = "0x19C28CC", VA = "0x19C28CC")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91E4C", Offset = "0xE91E4C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91E4C", Offset = "0xE91E4C")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE99A90", Offset = "0xE99A90")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE99B20", Offset = "0xE99B20")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE99BA0", Offset = "0xE99BA0")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE99BFC", Offset = "0xE99BFC")]
		[SerializeField]
		private float m_SplitLength;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0xE99CCC", Offset = "0xE99CCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE99CCC", Offset = "0xE99CCC")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

		[Token(Token = "0x170001F0")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x19C29BC", Offset = "0x19C29BC", VA = "0x19C29BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x19C29C4", Offset = "0x19C29C4", VA = "0x19C29C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x19C29EC", Offset = "0x19C29EC", VA = "0x19C29EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x19C29F4", Offset = "0x19C29F4", VA = "0x19C29F4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public bool Split
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x19C2A1C", Offset = "0x19C2A1C", VA = "0x19C2A1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x19C2A24", Offset = "0x19C2A24", VA = "0x19C2A24")]
			set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public float SplitLength
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x19C2A4C", Offset = "0x19C2A4C", VA = "0x19C2A4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x19C2A54", Offset = "0x19C2A54", VA = "0x19C2A54")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x19C2AEC", Offset = "0x19C2AEC", VA = "0x19C2AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F5")]
		public int MaterialCount
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x19C2AF4", Offset = "0x19C2AF4", VA = "0x19C2AF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x19C2B44", Offset = "0x19C2B44", VA = "0x19C2B44", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x19C2C48", Offset = "0x19C2C48", VA = "0x19C2C48", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x19C2DFC", Offset = "0x19C2DFC", VA = "0x19C2DFC", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x19C2B84", Offset = "0x19C2B84", VA = "0x19C2B84")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x19C3658", Offset = "0x19C3658", VA = "0x19C3658")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x19C37B4", Offset = "0x19C37B4", VA = "0x19C37B4")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x19C3928", Offset = "0x19C3928", VA = "0x19C3928")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x19C327C", Offset = "0x19C327C", VA = "0x19C327C")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x19C32A0", Offset = "0x19C32A0", VA = "0x19C32A0")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x19C3CA8", Offset = "0x19C3CA8", VA = "0x19C3CA8")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x19C3E84", Offset = "0x19C3E84", VA = "0x19C3E84")]
		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x19C4028", Offset = "0x19C4028", VA = "0x19C4028")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x19C3984", Offset = "0x19C3984", VA = "0x19C3984")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x19C370C", Offset = "0x19C370C", VA = "0x19C370C")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x19C4184", Offset = "0x19C4184", VA = "0x19C4184")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91ECC", Offset = "0xE91ECC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91ECC", Offset = "0xE91ECC")]
	public class BuildVolumeSpots : CGModule
	{
		[Token(Token = "0x2000164")]
		private class GroupSet
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CGBoundsGroup Group;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Length;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int> Items;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<float> Distances;

			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x18F8744", Offset = "0x18F8744", VA = "0x18F8744")]
			public GroupSet()
			{
			}
		}

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE99DB0", Offset = "0xE99DB0")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE99E68", Offset = "0xE99E68")]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE99F10", Offset = "0xE99F10")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE99F84", Offset = "0xE99F84")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE99FFC", Offset = "0xE99FFC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE99FFC", Offset = "0xE99FFC")]
		[SerializeField]
		private bool m_UseVolume;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A080", Offset = "0xE9A080")]
		[SerializeField]
		private bool m_Simulate;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9A0CC", Offset = "0xE9A0CC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9A0CC", Offset = "0xE9A0CC")]
		private float m_CrossBase;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9A17C", Offset = "0xE9A17C")]
		[ArrayEx]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_FitEnd;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9A25C", Offset = "0xE9A25C")]
		private int <Count>k__BackingField;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public CGSpots SimulatedSpots;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private WeightedRandom<int> mGroupBag;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<CGBounds> mBounds;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9A26C", Offset = "0xE9A26C")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9A27C", Offset = "0xE9A27C")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x170001F6")]
		public FloatRegion Range
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x19C4258", Offset = "0x19C4258", VA = "0x19C4258")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x19C4268", Offset = "0x19C4268", VA = "0x19C4268")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		public bool UseVolume
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x19C42C4", Offset = "0x19C42C4", VA = "0x19C42C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x19C42CC", Offset = "0x19C42CC", VA = "0x19C42CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public bool Simulate
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x19C42F4", Offset = "0x19C42F4", VA = "0x19C42F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x19C42FC", Offset = "0x19C42FC", VA = "0x19C42FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public float CrossBase
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x19C4324", Offset = "0x19C4324", VA = "0x19C4324")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x19C432C", Offset = "0x19C432C", VA = "0x19C432C")]
			set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x19C43C4", Offset = "0x19C43C4", VA = "0x19C43C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x19C43CC", Offset = "0x19C43CC", VA = "0x19C43CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x19C43E8", Offset = "0x19C43E8", VA = "0x19C43E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x19C43F0", Offset = "0x19C43F0", VA = "0x19C43F0")]
			set
			{
			}
		}

		[Token(Token = "0x170001FC")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x19C4404", Offset = "0x19C4404", VA = "0x19C4404")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x19C440C", Offset = "0x19C440C", VA = "0x19C440C")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public int FirstRepeating
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x19C4428", Offset = "0x19C4428", VA = "0x19C4428")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x19C4430", Offset = "0x19C4430", VA = "0x19C4430")]
			set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		public int LastRepeating
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x19C453C", Offset = "0x19C453C", VA = "0x19C453C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x19C4544", Offset = "0x19C4544", VA = "0x19C4544")]
			set
			{
			}
		}

		[Token(Token = "0x170001FF")]
		public bool FitEnd
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x19C4604", Offset = "0x19C4604", VA = "0x19C4604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x19C460C", Offset = "0x19C460C", VA = "0x19C460C")]
			set
			{
			}
		}

		[Token(Token = "0x17000200")]
		public int GroupCount
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x19C44EC", Offset = "0x19C44EC", VA = "0x19C44EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000201")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x19C4634", Offset = "0x19C4634", VA = "0x19C4634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000202")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x19C4818", Offset = "0x19C4818", VA = "0x19C4818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000203")]
		public int Count
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x19C48D4", Offset = "0x19C48D4", VA = "0x19C48D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF88", Offset = "0xE9DF88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x19C48DC", Offset = "0x19C48DC", VA = "0x19C48DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DF98", Offset = "0xE9DF98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000204")]
		private int lastGroupIndex
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x19C48E4", Offset = "0x19C48E4", VA = "0x19C48E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000205")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x19C4960", Offset = "0x19C4960", VA = "0x19C4960")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000206")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x19C49B8", Offset = "0x19C49B8", VA = "0x19C49B8")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000207")]
		private CGPath Path
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x19C4A5C", Offset = "0x19C4A5C", VA = "0x19C4A5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DFA8", Offset = "0xE9DFA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x19C4A64", Offset = "0x19C4A64", VA = "0x19C4A64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DFB8", Offset = "0xE9DFB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		private CGVolume Volume
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x19C4A6C", Offset = "0x19C4A6C", VA = "0x19C4A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000209")]
		private float Length
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x19C4AF0", Offset = "0x19C4AF0", VA = "0x19C4AF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700020A")]
		private float StartDistance
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x19C4B2C", Offset = "0x19C4B2C", VA = "0x19C4B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DFC8", Offset = "0xE9DFC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x19C4B34", Offset = "0x19C4B34", VA = "0x19C4B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DFD8", Offset = "0xE9DFD8")]
			set
			{
			}
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x19C4B3C", Offset = "0x19C4B3C", VA = "0x19C4B3C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x19C4B74", Offset = "0x19C4B74", VA = "0x19C4B74", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x19C4DB0", Offset = "0x19C4DB0", VA = "0x19C4DB0", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x19C4DF8", Offset = "0x19C4DF8", VA = "0x19C4DF8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x19C4ED0", Offset = "0x19C4ED0", VA = "0x19C4ED0", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x19C4CD0", Offset = "0x19C4CD0", VA = "0x19C4CD0")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x19C66F8", Offset = "0x19C66F8", VA = "0x19C66F8")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x19C5D18", Offset = "0x19C5D18", VA = "0x19C5D18")]
		private GroupSet addGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, ref float remainingLength, ref float currentDistance, bool calcLengthOnly = false)
		{
			return null;
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x19C64C0", Offset = "0x19C64C0", VA = "0x19C64C0")]
		private void rebase(ref List<CGSpot> spots, ref List<GroupSet> sets, float currentDistance)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x19C67F8", Offset = "0x19C67F8", VA = "0x19C67F8")]
		private CGSpot getSpot(int itemID, ref CGBoundsGroup group, ref CGBounds bounds, float startDist)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x19C5B7C", Offset = "0x19C5B7C", VA = "0x19C5B7C")]
		private void prepare()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x19C6770", Offset = "0x19C6770", VA = "0x19C6770")]
		private CGBounds getItemBounds(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x19C6CA0", Offset = "0x19C6CA0", VA = "0x19C6CA0")]
		private float getCrossValue(float globalF, CGBoundsGroup group)
		{
			return default(float);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x19C6D74", Offset = "0x19C6D74", VA = "0x19C6D74")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91F54", Offset = "0xE91F54")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91F54", Offset = "0xE91F54")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9A28C", Offset = "0xE9A28C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9A344", Offset = "0xE9A344")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0xE9A3B8", Offset = "0xE9A3B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A3B8", Offset = "0xE9A3B8")]
		private Vector3 m_Direction;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A444", Offset = "0xE9A444")]
		private float m_MaxDistance;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A490", Offset = "0xE9A490")]
		private float m_Offset;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A4DC", Offset = "0xE9A4DC")]
		private bool m_Warp;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A528", Offset = "0xE9A528")]
		private LayerMask m_LayerMask;

		[Token(Token = "0x1700020B")]
		public Vector3 Direction
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x18F87DC", Offset = "0x18F87DC", VA = "0x18F87DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x18F87E8", Offset = "0x18F87E8", VA = "0x18F87E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020C")]
		public float MaxDistance
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x18F88AC", Offset = "0x18F88AC", VA = "0x18F88AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x18F88B4", Offset = "0x18F88B4", VA = "0x18F88B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public float Offset
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x18F88D0", Offset = "0x18F88D0", VA = "0x18F88D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x18F88D8", Offset = "0x18F88D8", VA = "0x18F88D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public bool Warp
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x18F88F4", Offset = "0x18F88F4", VA = "0x18F88F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x18F88FC", Offset = "0x18F88FC", VA = "0x18F88FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x18F8924", Offset = "0x18F8924", VA = "0x18F8924")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x18F892C", Offset = "0x18F892C", VA = "0x18F892C")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public float PathLength
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x18F8A9C", Offset = "0x18F8A9C", VA = "0x18F8A9C", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000211")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x18F8BC8", Offset = "0x18F8BC8", VA = "0x18F8BC8", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x18F8988", Offset = "0x18F8988", VA = "0x18F8988", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x18F89C0", Offset = "0x18F89C0", VA = "0x18F89C0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x18F8CC0", Offset = "0x18F8CC0", VA = "0x18F8CC0", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x18F8E1C", Offset = "0x18F8E1C", VA = "0x18F8E1C")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x18F922C", Offset = "0x18F922C", VA = "0x18F922C")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE91FD4", Offset = "0xE91FD4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE91FD4", Offset = "0xE91FD4")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9A574", Offset = "0xE9A574")]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9A62C", Offset = "0xE9A62C")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0xE9A6D4", Offset = "0xE9A6D4")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9A72C", Offset = "0xE9A72C")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0xE9A778", Offset = "0xE9A778")]
		private int m_Layer;

		[Token(Token = "0x17000212")]
		public int Layer
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x18F92F4", Offset = "0x18F92F4", VA = "0x18F92F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x18F92FC", Offset = "0x18F92FC", VA = "0x18F92FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public bool MakeStatic
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x18F9398", Offset = "0x18F9398", VA = "0x18F9398")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x18F93A0", Offset = "0x18F93A0", VA = "0x18F93A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x18F93C8", Offset = "0x18F93C8", VA = "0x18F93C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000215")]
		public int GameObjectCount
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x18F93D0", Offset = "0x18F93D0", VA = "0x18F93D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x18F93EC", Offset = "0x18F93EC", VA = "0x18F93EC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x18F956C", Offset = "0x18F956C", VA = "0x18F956C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x18F9608", Offset = "0x18F9608", VA = "0x18F9608", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x18F943C", Offset = "0x18F943C", VA = "0x18F943C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x18F960C", Offset = "0x18F960C", VA = "0x18F960C", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x18F9654", Offset = "0x18F9654", VA = "0x18F9654", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x18F9E74", Offset = "0x18F9E74", VA = "0x18F9E74")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE92044", Offset = "0xE92044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE92044", Offset = "0xE92044")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92A08", Offset = "0xE92A08")]
		private sealed class <>c
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<CGSpot> <>9__107_0;

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x18FC464", Offset = "0x18FC464", VA = "0x18FC464")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x18FC46C", Offset = "0x18FC46C", VA = "0x18FC46C")]
			internal int <createSpotMeshes>b__107_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40003CD")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9A7E0", Offset = "0xE9A7E0")]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9A898", Offset = "0xE9A898")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0xE9A950", Offset = "0xE9A950")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9A9A8", Offset = "0xE9A9A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9A9A8", Offset = "0xE9A9A8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9A9A8", Offset = "0xE9A9A8")]
		[SerializeField]
		private bool m_Combine;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9AAAC", Offset = "0xE9AAAC")]
		[SerializeField]
		private bool m_GroupMeshes;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9AAF8", Offset = "0xE9AAF8")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9ABB4", Offset = "0xE9ABB4")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9AC70", Offset = "0xE9AC70")]
		private bool m_AddUV2;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9AD2C", Offset = "0xE9AD2C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9AD2C", Offset = "0xE9AD2C")]
		private bool m_MakeStatic;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9AE0C", Offset = "0xE9AE0C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9AE0C", Offset = "0xE9AE0C")]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0xE9AE0C", Offset = "0xE9AE0C")]
		private int m_Layer;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9AF24", Offset = "0xE9AF24")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9AF24", Offset = "0xE9AF24")]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0xE9AF24", Offset = "0xE9AF24")]
		private string m_Tag;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9B03C", Offset = "0xE9B03C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B03C", Offset = "0xE9B03C")]
		private bool m_RendererEnabled;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B11C", Offset = "0xE9B11C")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B1D8", Offset = "0xE9B1D8")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B294", Offset = "0xE9B294")]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B350", Offset = "0xE9B350")]
		private bool m_UseLightProbes;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B41C", Offset = "0xE9B41C")]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B4D8", Offset = "0xE9B4D8")]
		private Transform m_AnchorOverride;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9B594", Offset = "0xE9B594")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B594", Offset = "0xE9B594")]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B674", Offset = "0xE9B674")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B674", Offset = "0xE9B674")]
		private bool m_Convex;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9B790", Offset = "0xE9B790")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B790", Offset = "0xE9B790")]
		[SerializeField]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0xE9B790", Offset = "0xE9B790")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9B790", Offset = "0xE9B790")]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0xE9B908", Offset = "0xE9B908")]
		[SerializeField]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9B980", Offset = "0xE9B980")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mCurrentMeshCount;

		[Token(Token = "0x17000216")]
		public bool Combine
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x18F9F1C", Offset = "0x18F9F1C", VA = "0x18F9F1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x18F9F24", Offset = "0x18F9F24", VA = "0x18F9F24")]
			set
			{
			}
		}

		[Token(Token = "0x17000217")]
		public bool GroupMeshes
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x18F9F4C", Offset = "0x18F9F4C", VA = "0x18F9F4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x18F9F54", Offset = "0x18F9F54", VA = "0x18F9F54")]
			set
			{
			}
		}

		[Token(Token = "0x17000218")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x18F9F7C", Offset = "0x18F9F7C", VA = "0x18F9F7C")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x18F9F84", Offset = "0x18F9F84", VA = "0x18F9F84")]
			set
			{
			}
		}

		[Token(Token = "0x17000219")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x18F9FA0", Offset = "0x18F9FA0", VA = "0x18F9FA0")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x18F9FA8", Offset = "0x18F9FA8", VA = "0x18F9FA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700021A")]
		public bool AddUV2
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x18F9FC4", Offset = "0x18F9FC4", VA = "0x18F9FC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x18F9FCC", Offset = "0x18F9FCC", VA = "0x18F9FCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700021B")]
		public int Layer
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x18F9FF4", Offset = "0x18F9FF4", VA = "0x18F9FF4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x18F9FFC", Offset = "0x18F9FFC", VA = "0x18F9FFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public string Tag
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x18FA098", Offset = "0x18FA098", VA = "0x18FA098")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x18FA0A0", Offset = "0x18FA0A0", VA = "0x18FA0A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public bool MakeStatic
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x18FA0E0", Offset = "0x18FA0E0", VA = "0x18FA0E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x18FA0E8", Offset = "0x18FA0E8", VA = "0x18FA0E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700021E")]
		public bool RendererEnabled
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x18FA110", Offset = "0x18FA110", VA = "0x18FA110")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x18FA118", Offset = "0x18FA118", VA = "0x18FA118")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x18FA140", Offset = "0x18FA140", VA = "0x18FA140")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x18FA148", Offset = "0x18FA148", VA = "0x18FA148")]
			set
			{
			}
		}

		[Token(Token = "0x17000220")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x18FA164", Offset = "0x18FA164", VA = "0x18FA164")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x18FA16C", Offset = "0x18FA16C", VA = "0x18FA16C")]
			set
			{
			}
		}

		[Token(Token = "0x17000221")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x18FA194", Offset = "0x18FA194", VA = "0x18FA194")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x18FA19C", Offset = "0x18FA19C", VA = "0x18FA19C")]
			set
			{
			}
		}

		[Token(Token = "0x17000222")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x18FA1C4", Offset = "0x18FA1C4", VA = "0x18FA1C4")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x18FA1CC", Offset = "0x18FA1CC", VA = "0x18FA1CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x18FA1E8", Offset = "0x18FA1E8", VA = "0x18FA1E8")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x18FA1F0", Offset = "0x18FA1F0", VA = "0x18FA1F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x18FA20C", Offset = "0x18FA20C", VA = "0x18FA20C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x18FA214", Offset = "0x18FA214", VA = "0x18FA214")]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x18FA2A8", Offset = "0x18FA2A8", VA = "0x18FA2A8")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x18FA2B0", Offset = "0x18FA2B0", VA = "0x18FA2B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000226")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x18FA2CC", Offset = "0x18FA2CC", VA = "0x18FA2CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x18FA2D4", Offset = "0x18FA2D4", VA = "0x18FA2D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000227")]
		public bool Convex
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x18FA2FC", Offset = "0x18FA2FC", VA = "0x18FA2FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x18FA304", Offset = "0x18FA304", VA = "0x18FA304")]
			set
			{
			}
		}

		[Token(Token = "0x17000228")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x18FA32C", Offset = "0x18FA32C", VA = "0x18FA32C")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x18FA334", Offset = "0x18FA334", VA = "0x18FA334")]
			set
			{
			}
		}

		[Token(Token = "0x17000229")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x18FA350", Offset = "0x18FA350", VA = "0x18FA350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x18FA358", Offset = "0x18FA358", VA = "0x18FA358")]
			set
			{
			}
		}

		[Token(Token = "0x1700022A")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x18FA3EC", Offset = "0x18FA3EC", VA = "0x18FA3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022B")]
		public int MeshCount
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x18FA3F4", Offset = "0x18FA3F4", VA = "0x18FA3F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700022C")]
		public int VertexCount
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x18FA410", Offset = "0x18FA410", VA = "0x18FA410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DFE8", Offset = "0xE9DFE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x18FA418", Offset = "0x18FA418", VA = "0x18FA418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9DFF8", Offset = "0xE9DFF8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700022D")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x18FA420", Offset = "0x18FA420", VA = "0x18FA420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700022E")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x18FA468", Offset = "0x18FA468", VA = "0x18FA468")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700022F")]
		private bool canUpdate
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x18FA470", Offset = "0x18FA470", VA = "0x18FA470")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x18FA4AC", Offset = "0x18FA4AC", VA = "0x18FA4AC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x18FA788", Offset = "0x18FA788", VA = "0x18FA788", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x18FA76C", Offset = "0x18FA76C", VA = "0x18FA76C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x18FA8B4", Offset = "0x18FA8B4", VA = "0x18FA8B4", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x18FA908", Offset = "0x18FA908", VA = "0x18FA908", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x18FB944", Offset = "0x18FB944", VA = "0x18FB944")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x18FB840", Offset = "0x18FB840", VA = "0x18FB840")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x18FB468", Offset = "0x18FB468", VA = "0x18FB468")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x18FABB0", Offset = "0x18FABB0", VA = "0x18FABB0")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, ref CGSpots spots, bool combine)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x18FBD84", Offset = "0x18FBD84", VA = "0x18FBD84")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x18FA7A4", Offset = "0x18FA7A4", VA = "0x18FA7A4")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x18FC038", Offset = "0x18FC038", VA = "0x18FC038")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x18FC308", Offset = "0x18FC308", VA = "0x18FC308")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE920B4", Offset = "0xE920B4")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9B990", Offset = "0xE9B990")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000230")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x18FC49C", Offset = "0x18FC49C", VA = "0x18FC49C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000231")]
		public override bool IsConfigured
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x18FC534", Offset = "0x18FC534", VA = "0x18FC534", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000232")]
		public override bool IsInitialized
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x18FC53C", Offset = "0x18FC53C", VA = "0x18FC53C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x18FC544", Offset = "0x18FC544", VA = "0x18FC544", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x18FC664", Offset = "0x18FC664", VA = "0x18FC664", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x18FC66C", Offset = "0x18FC66C", VA = "0x18FC66C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x18FC674", Offset = "0x18FC674", VA = "0x18FC674", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x18FC56C", Offset = "0x18FC56C", VA = "0x18FC56C")]
		private void createLR()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x18FC7CC", Offset = "0x18FC7CC", VA = "0x18FC7CC")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE92110", Offset = "0xE92110")]
	public class DebugRasterizedPath : CGModule
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9BA38", Offset = "0xE9BA38")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9BAE0", Offset = "0xE9BAE0")]
		public bool ShowNormals;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9BB18", Offset = "0xE9BB18")]
		public bool ShowOrientation;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x18FC834", Offset = "0x18FC834", VA = "0x18FC834", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x18FC860", Offset = "0x18FC860", VA = "0x18FC860")]
		public DebugRasterizedPath()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9216C", Offset = "0xE9216C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9216C", Offset = "0xE9216C")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9BB50", Offset = "0xE9BB50")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9BBF8", Offset = "0xE9BBF8")]
		public bool ShowVertices;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowVertexID;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool ShowUV;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x18FC8D0", Offset = "0x18FC8D0", VA = "0x18FC8D0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x18FC8FC", Offset = "0x18FC8FC", VA = "0x18FC8FC")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE921DC", Offset = "0xE921DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE921DC", Offset = "0xE921DC")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9BC30", Offset = "0xE9BC30")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9BCD8", Offset = "0xE9BCD8")]
		public bool ShowPathSamples;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowCrossSamples;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9BD10", Offset = "0xE9BD10")]
		[IntRegion]
		public IntRegion LimitCross;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool ShowNormals;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool ShowIndex;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool ShowMap;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Color PathColor;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Color VolumeColor;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Color NormalColor;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9BDD4", Offset = "0xE9BDD4")]
		public bool Interpolate;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9BE0C", Offset = "0xE9BE0C")]
		public float InterpolatePathF;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9BE60", Offset = "0xE9BE60")]
		public float InterpolateCrossF;

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x18FC964", Offset = "0x18FC964", VA = "0x18FC964")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9224C", Offset = "0xE9224C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9224C", Offset = "0xE9224C")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9BEB4", Offset = "0xE9BEB4")]
		public CGModuleOutputSlot OutGameObject;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		[Token(Token = "0x17000233")]
		public List<CGGameObjectProperties> GameObjects
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x18FCA3C", Offset = "0x18FCA3C", VA = "0x18FCA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x18FCA44", Offset = "0x18FCA44", VA = "0x18FCA44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x18FCA4C", Offset = "0x18FCA4C", VA = "0x18FCA4C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x18FCAC0", Offset = "0x18FCAC0", VA = "0x18FCAC0", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x18FCC6C", Offset = "0x18FCC6C", VA = "0x18FCC6C", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x18FCCD0", Offset = "0x18FCCD0", VA = "0x18FCCD0")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE922CC", Offset = "0xE922CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE922CC", Offset = "0xE922CC")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9BF6C", Offset = "0xE9BF6C")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		[Token(Token = "0x17000235")]
		public List<CGMeshProperties> Meshes
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x18FCD60", Offset = "0x18FCD60", VA = "0x18FCD60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000236")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x18FCD68", Offset = "0x18FCD68", VA = "0x18FCD68", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x18FCD70", Offset = "0x18FCD70", VA = "0x18FCD70", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x18FCDE4", Offset = "0x18FCDE4", VA = "0x18FCDE4", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x18FCFC8", Offset = "0x18FCFC8", VA = "0x18FCFC8", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x18FD02C", Offset = "0x18FD02C", VA = "0x18FD02C")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9234C", Offset = "0xE9234C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9234C", Offset = "0xE9234C")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C024", Offset = "0xE9C024")]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9C098", Offset = "0xE9C098")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0xE9C098", Offset = "0xE9C098")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0xE9C098", Offset = "0xE9C098")]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000237")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x18FD144", Offset = "0x18FD144", VA = "0x18FD144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x18FD14C", Offset = "0x18FD14C", VA = "0x18FD14C")]
			set
			{
			}
		}

		[Token(Token = "0x17000238")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x18FD47C", Offset = "0x18FD47C", VA = "0x18FD47C", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000239")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x18FED18", Offset = "0x18FED18", VA = "0x18FED18", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x18FED20", Offset = "0x18FED20", VA = "0x18FED20", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x18FD484", Offset = "0x18FD484", VA = "0x18FD484", Slot = "23")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x18FEC70", Offset = "0x18FEC70", VA = "0x18FEC70", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x18FED24", Offset = "0x18FED24", VA = "0x18FED24")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE923CC", Offset = "0xE923CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE923CC", Offset = "0xE923CC")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C154", Offset = "0xE9C154")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0xE9C1C8", Offset = "0xE9C1C8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0xE9C1C8", Offset = "0xE9C1C8")]
		private CurvySpline m_Shape;

		[Token(Token = "0x1700023A")]
		public CurvySpline Shape
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x18FED94", Offset = "0x18FED94", VA = "0x18FED94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x18FED9C", Offset = "0x18FED9C", VA = "0x18FED9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x18FEE4C", Offset = "0x18FEE4C", VA = "0x18FEE4C", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700023C")]
		public bool FreeForm
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x18FEE50", Offset = "0x18FEE50", VA = "0x18FEE50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x18FEF2C", Offset = "0x18FEF2C", VA = "0x18FEF2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700023D")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x18FF250", Offset = "0x18FF250", VA = "0x18FF250", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x18FF258", Offset = "0x18FF258", VA = "0x18FF258", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x18FF078", Offset = "0x18FF078", VA = "0x18FF078", Slot = "23")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A4E")]
		public T SetManagedShape<T>() where T : CurvyShape2D
		{
			return null;
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x18FF1A8", Offset = "0x18FF1A8", VA = "0x18FF1A8")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x18FF25C", Offset = "0x18FF25C", VA = "0x18FF25C", Slot = "19")]
		protected override void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x18FF484", Offset = "0x18FF484", VA = "0x18FF484")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9244C", Offset = "0xE9244C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9244C", Offset = "0xE9244C")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C23C", Offset = "0xE9C23C")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGSpot> m_Spots;

		[Token(Token = "0x1700023E")]
		public List<CGSpot> Spots
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x18FF4EC", Offset = "0x18FF4EC", VA = "0x18FF4EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x18FF4F4", Offset = "0x18FF4F4", VA = "0x18FF4F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x18FF510", Offset = "0x18FF510", VA = "0x18FF510", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x18FF548", Offset = "0x18FF548", VA = "0x18FF548", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x18FF5BC", Offset = "0x18FF5BC", VA = "0x18FF5BC", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x18FF5C4", Offset = "0x18FF5C4", VA = "0x18FF5C4", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x18FF6E4", Offset = "0x18FF6E4", VA = "0x18FF6E4")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE924CC", Offset = "0xE924CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE924CC", Offset = "0xE924CC")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9C2E8", Offset = "0xE9C2E8")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9C390", Offset = "0xE9C390")]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C438", Offset = "0xE9C438")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9C4AC", Offset = "0xE9C4AC")]
		private float m_Mix;

		[Token(Token = "0x1700023F")]
		public float Mix
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x18FF774", Offset = "0x18FF774", VA = "0x18FF774")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x18FF77C", Offset = "0x18FF77C", VA = "0x18FF77C")]
			set
			{
			}
		}

		[Token(Token = "0x17000240")]
		public float PathLength
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x18FF798", Offset = "0x18FF798", VA = "0x18FF798", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000241")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x18FF964", Offset = "0x18FF964", VA = "0x18FF964", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x18FFAF8", Offset = "0x18FFAF8", VA = "0x18FFAF8", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x18FFB40", Offset = "0x18FFB40", VA = "0x18FFB40", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x18FFB80", Offset = "0x18FFB80", VA = "0x18FFB80", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x18FFCB0", Offset = "0x18FFCB0", VA = "0x18FFCB0")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1900544", Offset = "0x1900544", VA = "0x1900544")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9254C", Offset = "0xE9254C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9254C", Offset = "0xE9254C")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92A18", Offset = "0xE92A18")]
		private sealed class <>c
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__15_0;

			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x1900D2C", Offset = "0x1900D2C", VA = "0x1900D2C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x1900D34", Offset = "0x1900D34", VA = "0x1900D34")]
			internal SamplePointsMaterialGroup <InterpolateShape>b__15_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9C530", Offset = "0xE9C530")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9C5D8", Offset = "0xE9C5D8")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C680", Offset = "0xE9C680")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9C6F4", Offset = "0xE9C6F4")]
		private float m_Mix;

		[Token(Token = "0x17000242")]
		public float Mix
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x19005EC", Offset = "0x19005EC", VA = "0x19005EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x19005F4", Offset = "0x19005F4", VA = "0x19005F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000243")]
		public float PathLength
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x1900610", Offset = "0x1900610", VA = "0x1900610", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000244")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x19007DC", Offset = "0x19007DC", VA = "0x19007DC", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x1900970", Offset = "0x1900970", VA = "0x1900970", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x19009B8", Offset = "0x19009B8", VA = "0x19009B8", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x19009F8", Offset = "0x19009F8", VA = "0x19009F8", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x1900B1C", Offset = "0x1900B1C", VA = "0x1900B1C")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x18FFFA4", Offset = "0x18FFFA4", VA = "0x18FFFA4")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape mainShape, CGShape secondaryShape, float mix, [NotNull] List<string> warningsContainer)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1900C20", Offset = "0x1900C20", VA = "0x1900C20")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE925CC", Offset = "0xE925CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE925CC", Offset = "0xE925CC")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9C778", Offset = "0xE9C778")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C830", Offset = "0xE9C830")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE9C8A4", Offset = "0xE9C8A4")]
		private float lateralTranslation;

		[Token(Token = "0x17000245")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1900DF0", Offset = "0x1900DF0", VA = "0x1900DF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x1900DF8", Offset = "0x1900DF8", VA = "0x1900DF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public float PathLength
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1900E18", Offset = "0x1900E18", VA = "0x1900E18", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000247")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1900F0C", Offset = "0x1900F0C", VA = "0x1900F0C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x1901004", Offset = "0x1901004", VA = "0x1901004", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x190124C", Offset = "0x190124C", VA = "0x190124C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1901294", Offset = "0x1901294", VA = "0x1901294", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x19012E0", Offset = "0x19012E0", VA = "0x19012E0")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9264C", Offset = "0xE9264C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9264C", Offset = "0xE9264C")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9C8F0", Offset = "0xE9C8F0")]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9C99C", Offset = "0xE9C99C")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1901368", Offset = "0x1901368", VA = "0x1901368", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x190165C", Offset = "0x190165C", VA = "0x190165C")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE926CC", Offset = "0xE926CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE926CC", Offset = "0xE926CC")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9CA1C", Offset = "0xE9CA1C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9CAD4", Offset = "0xE9CAD4")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000248")]
		public float PathLength
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1901758", Offset = "0x1901758", VA = "0x1901758", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000249")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x190184C", Offset = "0x190184C", VA = "0x190184C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1901944", Offset = "0x1901944", VA = "0x1901944", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1901C40", Offset = "0x1901C40", VA = "0x1901C40")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE9274C", Offset = "0xE9274C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE9274C", Offset = "0xE9274C")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0xE9CB48", Offset = "0xE9CB48")]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0xE9CC00", Offset = "0xE9CC00")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x1700024A")]
		public float PathLength
		{
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1901CC4", Offset = "0x1901CC4", VA = "0x1901CC4", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700024B")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x1901DB8", Offset = "0x1901DB8", VA = "0x1901DB8", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1901EB0", Offset = "0x1901EB0", VA = "0x1901EB0", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x19021AC", Offset = "0x19021AC", VA = "0x19021AC")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0xE927CC", Offset = "0xE927CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE927CC", Offset = "0xE927CC")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xE9CC74", Offset = "0xE9CC74")]
		private string m_Note;

		[Token(Token = "0x1700024C")]
		public string NoteText
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1902230", Offset = "0x1902230", VA = "0x1902230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1902238", Offset = "0x1902238", VA = "0x1902238")]
			set
			{
			}
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x190226C", Offset = "0x190226C", VA = "0x190226C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x19022B4", Offset = "0x19022B4", VA = "0x19022B4", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x19022DC", Offset = "0x19022DC", VA = "0x19022DC")]
		public Note()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Examples
{
	[Token(Token = "0x2000118")]
	public class CameraLook : MonoBehaviour
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE9CCB4", Offset = "0xE9CCB4")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x17A9B1C", Offset = "0x17A9B1C", VA = "0x17A9B1C")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x17A9C14", Offset = "0x17A9C14", VA = "0x17A9C14")]
		public CameraLook()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[ExecuteInEditMode]
	public class ChaseCam : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform LookAt;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform MoveTo;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform RollTo;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		public float ChaseTime;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 mLastPos;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 mVelocity;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 mRollVelocity;

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x17A9C24", Offset = "0x17A9C24", VA = "0x17A9C24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x17A9ED4", Offset = "0x17A9ED4", VA = "0x17A9ED4")]
		public ChaseCam()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CurvyCamController : SplineController
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9CD04", Offset = "0xE9CD04")]
		public float MinSpeed;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float MaxSpeed;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float Mass;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float Down;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float Up;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float Fric;

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x17A9EE4", Offset = "0x17A9EE4", VA = "0x17A9EE4", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x17A9F14", Offset = "0x17A9F14", VA = "0x17A9F14", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x17AA068", Offset = "0x17AA068", VA = "0x17AA068")]
		public CurvyCamController()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class HeightMetadata : CurvyMetadataBase, ICurvyInterpolatableMetadata<float>, ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9CD48", Offset = "0xE9CD48")]
		private float m_Height;

		[Token(Token = "0x1700024D")]
		public object Value
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x17AA07C", Offset = "0x17AA07C", VA = "0x17AA07C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x17AA0E0", Offset = "0x17AA0E0", VA = "0x17AA0E0", Slot = "7")]
		public object InterpolateObject(ICurvyMetadata b, float f)
		{
			return null;
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x17AA280", Offset = "0x17AA280", VA = "0x17AA280", Slot = "5")]
		public float Interpolate(ICurvyMetadata b, float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x17AA31C", Offset = "0x17AA31C", VA = "0x17AA31C")]
		public HeightMetadata()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class InfiniteTrack : MonoBehaviour
	{
		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92A28", Offset = "0xE92A28")]
		private sealed class <setup>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InfiniteTrack <>4__this;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700026F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B8F")]
				[Address(RVA = "0x17AB35C", Offset = "0x17AB35C", VA = "0x17AB35C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000270")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B91")]
				[Address(RVA = "0x17AB3C4", Offset = "0x17AB3C4", VA = "0x17AB3C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x17AA5D8", Offset = "0x17AA5D8", VA = "0x17AA5D8")]
			[DebuggerHidden]
			public <setup>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x17AB024", Offset = "0x17AB024", VA = "0x17AB024", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x17AB028", Offset = "0x17AB028", VA = "0x17AB028", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B90")]
			[Address(RVA = "0x17AB364", Offset = "0x17AB364", VA = "0x17AB364", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline TrackSpline;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvyController Controller;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material RoadMaterial;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text TxtStats;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		public float CurvationX;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Positive]
		public float CurvationY;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Positive]
		public float CPStepSize;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Positive]
		public int HeadCP;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Positive]
		public int TailCP;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xE9CE14", Offset = "0xE9CE14")]
		public int Sections;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xE9CE6C", Offset = "0xE9CE6C")]
		public int SectionCPCount;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int mInitState;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool mUpdateSpline;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int mUpdateIn;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CurvyGenerator[] mGenerators;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int mCurrentGen;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastSectionEndV;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 mDir;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TimeMeasure timeSpline;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TimeMeasure timeCG;

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x17AA324", Offset = "0x17AA324", VA = "0x17AA324")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x17AA380", Offset = "0x17AA380", VA = "0x17AA380")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x17AA568", Offset = "0x17AA568", VA = "0x17AA568")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE9E008", Offset = "0xE9E008")]
		private IEnumerator setup()
		{
			return null;
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x17AA604", Offset = "0x17AA604", VA = "0x17AA604")]
		private CurvyGenerator buildGenerator()
		{
			return null;
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x17AA404", Offset = "0x17AA404", VA = "0x17AA404")]
		private void advanceTrack()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x17AABC4", Offset = "0x17AABC4", VA = "0x17AABC4")]
		private void advanceSections()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x17AAE6C", Offset = "0x17AAE6C", VA = "0x17AAE6C")]
		private void updateStats()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x17AAC5C", Offset = "0x17AAC5C", VA = "0x17AAC5C")]
		private void updateSectionGenerator(CurvyGenerator gen, int startCP, int endCP)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x17AAF50", Offset = "0x17AAF50", VA = "0x17AAF50")]
		public void Track_OnControlPointReached(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x17AA944", Offset = "0x17AA944", VA = "0x17AA944")]
		private void addTrackCP()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x17AAF78", Offset = "0x17AAF78", VA = "0x17AAF78")]
		public InfiniteTrack()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class MDJunctionControl : CurvyMetadataBase, ICurvyMetadata
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool UseJunction;

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x17AB3CC", Offset = "0x17AB3CC", VA = "0x17AB3CC")]
		public void Toggle()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x17AB3DC", Offset = "0x17AB3DC", VA = "0x17AB3DC")]
		public MDJunctionControl()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class MetaDataController : SplineController
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9CEC4", Offset = "0xE9CEC4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9CEC4", Offset = "0xE9CEC4")]
		[SerializeField]
		private float m_MaxHeight;

		[Token(Token = "0x1700024E")]
		public float MaxHeight
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x17AB3E4", Offset = "0x17AB3E4", VA = "0x17AB3E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x17AB3EC", Offset = "0x17AB3EC", VA = "0x17AB3EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x17AB400", Offset = "0x17AB400", VA = "0x17AB400", Slot = "24")]
		protected override void UserAfterInit()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x17AB4FC", Offset = "0x17AB4FC", VA = "0x17AB4FC", Slot = "25")]
		protected override void UserAfterUpdate()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x17AB404", Offset = "0x17AB404", VA = "0x17AB404")]
		private void setHeight()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x17AB500", Offset = "0x17AB500", VA = "0x17AB500")]
		public MetaDataController()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class MotorController : SplineController
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9CF68", Offset = "0xE9CF68")]
		public float MaxSpeed;

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x17AB510", Offset = "0x17AB510", VA = "0x17AB510", Slot = "11")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x17AB5CC", Offset = "0x17AB5CC", VA = "0x17AB5CC")]
		public MotorController()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[ExecuteInEditMode]
	public class MoveToNearestPoint : MonoBehaviour
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Lookup;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvySpline Spline;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text StatisticsText;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Slider Density;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TimeMeasure Timer;

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x17AB5DC", Offset = "0x17AB5DC", VA = "0x17AB5DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x17AB844", Offset = "0x17AB844", VA = "0x17AB844")]
		public void OnSliderChange()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x17AB890", Offset = "0x17AB890", VA = "0x17AB890")]
		public MoveToNearestPoint()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class PaintSpline : MonoBehaviour
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StepDistance;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController Controller;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text InfoText;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvySpline mSpline;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 mLastControlPointPos;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool mResetSpline;

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x17AB8FC", Offset = "0x17AB8FC", VA = "0x17AB8FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x17AB954", Offset = "0x17AB954", VA = "0x17AB954")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x17ABBE8", Offset = "0x17ABBE8", VA = "0x17ABBE8")]
		private CurvySplineSegment addCP(Vector3 mousePos)
		{
			return null;
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x17ABCFC", Offset = "0x17ABCFC", VA = "0x17ABCFC")]
		public PaintSpline()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class PerformanceAPI : MonoBehaviour
	{
		[Token(Token = "0x400044A")]
		private const int LOOPS = 20;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<string> mTests;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<string> mTestResults;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvyInterpolation mInterpolation;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CurvyOrientation mOrientation;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int mCacheSize;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int mControlPointCount;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int mTotalSplineLength;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool mUseCache;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool mUseMultiThreads;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int mCurrentTest;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool mExecuting;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeMeasure Timer;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MethodInfo mGUIMethod;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MethodInfo mRunMethod;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool mInterpolate_UseDistance;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int mRefresh_Mode;

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x17ABD14", Offset = "0x17ABD14", VA = "0x17ABD14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x17ABD94", Offset = "0x17ABD94", VA = "0x17ABD94")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x17AD7B0", Offset = "0x17AD7B0", VA = "0x17AD7B0")]
		private void GUI_Interpolate()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x17AD944", Offset = "0x17AD944", VA = "0x17AD944")]
		private void Test_Interpolate()
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x17ADF04", Offset = "0x17ADF04", VA = "0x17ADF04")]
		private void GUI_Refresh()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x17AE258", Offset = "0x17AE258", VA = "0x17AE258")]
		private void Work()
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x17AE2CC", Offset = "0x17AE2CC", VA = "0x17AE2CC")]
		private void work()
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x17AE340", Offset = "0x17AE340", VA = "0x17AE340")]
		private void Test_Refresh()
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x17ADC14", Offset = "0x17ADC14", VA = "0x17ADC14")]
		private CurvySpline getSpline()
		{
			return null;
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x17ADC90", Offset = "0x17ADC90", VA = "0x17ADC90")]
		private void addRandomCP(ref CurvySpline spline, int count, int totalLength)
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x17AE578", Offset = "0x17AE578", VA = "0x17AE578")]
		private void runTest()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x17AE5B4", Offset = "0x17AE5B4", VA = "0x17AE5B4")]
		public PerformanceAPI()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class PerformanceDynamicSpline : MonoBehaviour
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySpline mSpline;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvyGenerator Generator;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		public int UpdateInterval;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0xE9CFBC", Offset = "0xE9CFBC")]
		public int CPCount;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		public float Radius;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AlwaysClear;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool UpdateCG;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float mAngleStep;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float mCurrentAngle;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float mLastUpdateTime;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeMeasure ExecTimes;

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x17AE68C", Offset = "0x17AE68C", VA = "0x17AE68C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x17AE6E4", Offset = "0x17AE6E4", VA = "0x17AE6E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x17AE8B8", Offset = "0x17AE8B8", VA = "0x17AE8B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x17AE754", Offset = "0x17AE754", VA = "0x17AE754")]
		private void addCP()
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x17AEA28", Offset = "0x17AEA28", VA = "0x17AEA28")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x17AF414", Offset = "0x17AF414", VA = "0x17AF414")]
		public PerformanceDynamicSpline()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class PoolTestRunner : MonoBehaviour
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text PoolCountInfo;

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x17AF494", Offset = "0x17AF494", VA = "0x17AF494")]
		private void Start()
		{
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x17AF560", Offset = "0x17AF560", VA = "0x17AF560")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x17AF498", Offset = "0x17AF498", VA = "0x17AF498")]
		private void checkForSpline()
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x17AF648", Offset = "0x17AF648", VA = "0x17AF648")]
		public void AddCP()
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x17AF750", Offset = "0x17AF750", VA = "0x17AF750")]
		public void DeleteCP()
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x17AF84C", Offset = "0x17AF84C", VA = "0x17AF84C")]
		public void ClearSpline()
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x17AF8DC", Offset = "0x17AF8DC", VA = "0x17AF8DC")]
		public void DeleteSpline()
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x17AF96C", Offset = "0x17AF96C", VA = "0x17AF96C")]
		public PoolTestRunner()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE92874", Offset = "0xE92874")]
	public class RigidBodySplineController : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController CameraController;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float VSpeed;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float HSpeed;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CenterDrag;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float JumpForce;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody mRigidBody;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float mTF;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float velocity;

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x17AF974", Offset = "0x17AF974", VA = "0x17AF974")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x17AF9CC", Offset = "0x17AF9CC", VA = "0x17AF9CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x17AFAD8", Offset = "0x17AFAD8", VA = "0x17AFAD8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x17AFECC", Offset = "0x17AFECC", VA = "0x17AFECC")]
		public RigidBodySplineController()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class RunnerController : SplineController
	{
		[Token(Token = "0x2000168")]
		private enum GuideMode
		{
			[Token(Token = "0x40005AF")]
			Guided,
			[Token(Token = "0x40005B0")]
			Jumping,
			[Token(Token = "0x40005B1")]
			FreeFall
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE92A38", Offset = "0xE92A38")]
		private sealed class <Jump>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RunnerController <>4__this;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <start>5__2;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <f>5__3;

			[Token(Token = "0x17000271")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B95")]
				[Address(RVA = "0x17B0820", Offset = "0x17B0820", VA = "0x17B0820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000272")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B97")]
				[Address(RVA = "0x17B0888", Offset = "0x17B0888", VA = "0x17B0888", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x17B04A4", Offset = "0x17B04A4", VA = "0x17B04A4")]
			[DebuggerHidden]
			public <Jump>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x17B06EC", Offset = "0x17B06EC", VA = "0x17B06EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x17B06F0", Offset = "0x17B06F0", VA = "0x17B06F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x17B0828", Offset = "0x17B0828", VA = "0x17B0828", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0xE9D02C", Offset = "0xE9D02C")]
		public float JumpHeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float JumpSpeed;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AnimationCurve JumpCurve;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float Gravity;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private GuideMode mMode;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float jumpHeight;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float fallingSpeed;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private SplineRefMetadata mPossibleSwitchTarget;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int mSwitchInProgress;

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x17AFEE0", Offset = "0x17AFEE0", VA = "0x17AFEE0", Slot = "10")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x17AFF0C", Offset = "0x17AFF0C", VA = "0x17AFF0C", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x17B0210", Offset = "0x17B0210", VA = "0x17B0210")]
		private void Switch(int dir)
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x17B01A0", Offset = "0x17B01A0", VA = "0x17B01A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE9E06C", Offset = "0xE9E06C")]
		private IEnumerator Jump()
		{
			return null;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x17B03C4", Offset = "0x17B03C4", VA = "0x17B03C4")]
		public void OnCPReached(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x17B04D0", Offset = "0x17B04D0", VA = "0x17B04D0")]
		public void UseFollowUpOrFall(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x17B0698", Offset = "0x17B0698", VA = "0x17B0698")]
		public RunnerController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class SceneSwitcher : MonoBehaviour
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text Text;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dropdown DropDown;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> scenesAlternativeNames;

		[Token(Token = "0x1700024F")]
		private int CurrentLevel
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x17B0BC8", Offset = "0x17B0BC8", VA = "0x17B0BC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x17B0BF8", Offset = "0x17B0BF8", VA = "0x17B0BF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x17B0890", Offset = "0x17B0890", VA = "0x17B0890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x17B0A1C", Offset = "0x17B0A1C", VA = "0x17B0A1C")]
		private List<string> getScenes()
		{
			return null;
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x17B0C44", Offset = "0x17B0C44", VA = "0x17B0C44")]
		private void OnValueChanged(int value)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x17B0C60", Offset = "0x17B0C60", VA = "0x17B0C60")]
		public SceneSwitcher()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x17B0F94", Offset = "0x17B0F94", VA = "0x17B0F94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x17B0F98", Offset = "0x17B0F98", VA = "0x17B0F98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x17B12C4", Offset = "0x17B12C4", VA = "0x17B12C4")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class SplineControllerInputRail : MonoBehaviour
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float acceleration;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float limit;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController splineController;

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x17B12D8", Offset = "0x17B12D8", VA = "0x17B12D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x17B13BC", Offset = "0x17B13BC", VA = "0x17B13BC")]
		public SplineControllerInputRail()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class SplineRefMetadata : MonoBehaviour, ICurvyMetadata
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvySplineSegment CP;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Options;

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x17B13D0", Offset = "0x17B13D0", VA = "0x17B13D0")]
		public SplineRefMetadata()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[ExecuteInEditMode]
	public class TrainCarDrifter : MonoBehaviour
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float wheelSpacing;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SplineController controllerWheelLeading;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplineController controllerWheelTrailing;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform trainCar;

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x17B13D8", Offset = "0x17B13D8", VA = "0x17B13D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x17B13FC", Offset = "0x17B13FC", VA = "0x17B13FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x17B18EC", Offset = "0x17B18EC", VA = "0x17B18EC")]
		public TrainCarDrifter()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[ExecuteInEditMode]
	public class TrainCarManager : MonoBehaviour
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SplineController Waggon;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController FrontAxis;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SplineController BackAxis;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TrainManager mTrain;

		[Token(Token = "0x17000250")]
		public float Position
		{
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x17B1958", Offset = "0x17B1958", VA = "0x17B1958")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x17B1974", Offset = "0x17B1974", VA = "0x17B1974")]
			set
			{
			}
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x17B1A28", Offset = "0x17B1A28", VA = "0x17B1A28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x17B1C8C", Offset = "0x17B1C8C", VA = "0x17B1C8C")]
		public void setup()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x17B1D80", Offset = "0x17B1D80", VA = "0x17B1D80")]
		private void setController(SplineController c, CurvySpline spline, float speed)
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x17B1E5C", Offset = "0x17B1E5C", VA = "0x17B1E5C")]
		public void OnCPReached(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x17B1F24", Offset = "0x17B1F24", VA = "0x17B1F24")]
		public TrainCarManager()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[ExecuteInEditMode]
	public class TrainManager : MonoBehaviour
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Speed;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Position;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CarSize;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AxisDistance;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CarGap;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Limit;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isSetup;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TrainCarManager[] Cars;

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x17B1F2C", Offset = "0x17B1F2C", VA = "0x17B1F2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x17B2138", Offset = "0x17B2138", VA = "0x17B2138")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x17B2140", Offset = "0x17B2140", VA = "0x17B2140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x17B1F30", Offset = "0x17B1F30", VA = "0x17B1F30")]
		private void setup()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x17B2380", Offset = "0x17B2380", VA = "0x17B2380")]
		public TrainManager()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class VolumeControllerInput : MonoBehaviour
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngularVelocity;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem explosionEmitter;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VolumeController volumeController;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rotatedTransform;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxSpeed;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float accelerationForward;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float accelerationBackward;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool mGameOver;

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x17B2394", Offset = "0x17B2394", VA = "0x17B2394")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x17B2420", Offset = "0x17B2420", VA = "0x17B2420")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x17B24F0", Offset = "0x17B24F0", VA = "0x17B24F0")]
		private void ResetController()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x17B2548", Offset = "0x17B2548", VA = "0x17B2548")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x17B2824", Offset = "0x17B2824", VA = "0x17B2824")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x17B2828", Offset = "0x17B2828", VA = "0x17B2828")]
		public void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x17B28C4", Offset = "0x17B28C4", VA = "0x17B28C4")]
		private void StartOver()
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x17B28E8", Offset = "0x17B28E8", VA = "0x17B28E8")]
		public VolumeControllerInput()
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x17B2910", Offset = "0x17B2910", VA = "0x17B2910")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE9E0D0", Offset = "0xE9E0D0")]
		private void <Start>b__9_0(CurvyController arg0)
		{
		}
	}
}
