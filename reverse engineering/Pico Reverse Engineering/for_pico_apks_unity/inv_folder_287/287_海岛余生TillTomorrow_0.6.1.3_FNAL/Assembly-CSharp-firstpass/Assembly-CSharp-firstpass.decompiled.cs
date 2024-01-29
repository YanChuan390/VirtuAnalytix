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
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x83DD08", Offset = "0x83DD08", VA = "0x83DD08")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x83DEB0", Offset = "0x83DEB0", VA = "0x83DEB0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x83E04C", Offset = "0x83E04C", VA = "0x83E04C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x83E1E8", Offset = "0x83E1E8", VA = "0x83E1E8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x83E384", Offset = "0x83E384", VA = "0x83E384")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x83E528", Offset = "0x83E528", VA = "0x83E528")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x83E780", Offset = "0x83E780", VA = "0x83E780")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x83EC60", Offset = "0x83EC60", VA = "0x83EC60")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x83EEC4", Offset = "0x83EEC4", VA = "0x83EEC4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x83F134", Offset = "0x83F134", VA = "0x83F134")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x83F2F8", Offset = "0x83F2F8", VA = "0x83F2F8")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x200000F")]
	public static class Utils
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x843E70", Offset = "0x843E70", VA = "0x843E70")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x83F8E8", Offset = "0x83F8E8", VA = "0x83F8E8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x83FA5C", Offset = "0x83FA5C", VA = "0x83FA5C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x83FBF8", Offset = "0x83FBF8", VA = "0x83FBF8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x83FD6C", Offset = "0x83FD6C", VA = "0x83FD6C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x83FF08", Offset = "0x83FF08", VA = "0x83FF08")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x84007C", Offset = "0x84007C", VA = "0x84007C")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x840214", Offset = "0x840214", VA = "0x840214")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8403F8", Offset = "0x8403F8", VA = "0x8403F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x840594", Offset = "0x840594", VA = "0x840594")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x840730", Offset = "0x840730", VA = "0x840730")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8408CC", Offset = "0x8408CC", VA = "0x8408CC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x840A68", Offset = "0x840A68", VA = "0x840A68")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x840BDC", Offset = "0x840BDC", VA = "0x840BDC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x840D60", Offset = "0x840D60", VA = "0x840D60")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x840EFC", Offset = "0x840EFC", VA = "0x840EFC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x841090", Offset = "0x841090", VA = "0x841090")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x841224", Offset = "0x841224", VA = "0x841224")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8413C8", Offset = "0x8413C8", VA = "0x8413C8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x841560", Offset = "0x841560", VA = "0x841560")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8416F8", Offset = "0x8416F8", VA = "0x8416F8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x841890", Offset = "0x841890", VA = "0x841890")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x841A2C", Offset = "0x841A2C", VA = "0x841A2C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x841BC8", Offset = "0x841BC8", VA = "0x841BC8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x841D4C", Offset = "0x841D4C", VA = "0x841D4C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x841ED4", Offset = "0x841ED4", VA = "0x841ED4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x84205C", Offset = "0x84205C", VA = "0x84205C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8421F8", Offset = "0x8421F8", VA = "0x8421F8")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x84239C", Offset = "0x84239C", VA = "0x84239C")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x842568", Offset = "0x842568", VA = "0x842568")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x84273C", Offset = "0x84273C", VA = "0x84273C")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x842B48", Offset = "0x842B48", VA = "0x842B48")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x842CD8", Offset = "0x842CD8", VA = "0x842CD8")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x842E58", Offset = "0x842E58", VA = "0x842E58")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x842FD8", Offset = "0x842FD8", VA = "0x842FD8")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x843164", Offset = "0x843164", VA = "0x843164")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x843300", Offset = "0x843300", VA = "0x843300")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x8434DC", Offset = "0x8434DC", VA = "0x8434DC")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x843650", Offset = "0x843650", VA = "0x843650")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x843870", Offset = "0x843870", VA = "0x843870")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x843A70", Offset = "0x843A70", VA = "0x843A70")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x843C70", Offset = "0x843C70", VA = "0x843C70")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000038")]
public static class DOTweenModuleUnityVersion
{
	[StructLayout(3)]
	[Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x8460AC", Offset = "0x8460AC", VA = "0x8460AC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x8462E4", Offset = "0x8462E4", VA = "0x8462E4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x8462F0", Offset = "0x8462F0", VA = "0x8462F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x84654C", Offset = "0x84654C", VA = "0x84654C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x846558", Offset = "0x846558", VA = "0x846558", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x84677C", Offset = "0x84677C", VA = "0x84677C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x846788", Offset = "0x846788", VA = "0x846788", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x8469C8", Offset = "0x8469C8", VA = "0x8469C8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x8469D4", Offset = "0x8469D4", VA = "0x8469D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x846C2C", Offset = "0x846C2C", VA = "0x846C2C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
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

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x846C38", Offset = "0x846C38", VA = "0x846C38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x846E64", Offset = "0x846E64", VA = "0x846E64", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x844DF8", Offset = "0x844DF8", VA = "0x844DF8")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x844FD8", Offset = "0x844FD8", VA = "0x844FD8")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8451C4", Offset = "0x8451C4", VA = "0x8451C4")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8452AC", Offset = "0x8452AC", VA = "0x8452AC")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x845394", Offset = "0x845394", VA = "0x845394")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x84547C", Offset = "0x84547C", VA = "0x84547C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x845574", Offset = "0x845574", VA = "0x845574")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x84567C", Offset = "0x84567C", VA = "0x84567C")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x845764", Offset = "0x845764", VA = "0x845764")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x845958", Offset = "0x845958", VA = "0x845958")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x845B4C", Offset = "0x845B4C", VA = "0x845B4C")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x845C14", Offset = "0x845C14", VA = "0x845C14")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x845CDC", Offset = "0x845CDC", VA = "0x845CDC")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x845DA4", Offset = "0x845DA4", VA = "0x845DA4")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x845E7C", Offset = "0x845E7C", VA = "0x845E7C")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x845F54", Offset = "0x845F54", VA = "0x845F54")]
	[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000041")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000042")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x846E70", Offset = "0x846E70", VA = "0x846E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x845284", Offset = "0x845284", VA = "0x845284")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000043")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x846EA0", Offset = "0x846EA0", VA = "0x846EA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x84536C", Offset = "0x84536C", VA = "0x84536C")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000044")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x846F00", Offset = "0x846F00", VA = "0x846F00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x845454", Offset = "0x845454", VA = "0x845454")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000045")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x846F1C", Offset = "0x846F1C", VA = "0x846F1C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x845544", Offset = "0x845544", VA = "0x845544")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x2000046")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x846F5C", Offset = "0x846F5C", VA = "0x846F5C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x845644", Offset = "0x845644", VA = "0x845644")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x2000047")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x846FB4", Offset = "0x846FB4", VA = "0x846FB4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x84573C", Offset = "0x84573C", VA = "0x84573C")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x2000049")]
	public static class Physics
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x847144", Offset = "0x847144", VA = "0x847144")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x847244", Offset = "0x847244", VA = "0x847244")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x84724C", Offset = "0x84724C", VA = "0x84724C")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x8472D8", Offset = "0x8472D8", VA = "0x8472D8")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x846FE8", Offset = "0x846FE8", VA = "0x846FE8")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x84709C", Offset = "0x84709C", VA = "0x84709C")]
	[Preserve]
	private static void Preserver()
	{
	}
}
