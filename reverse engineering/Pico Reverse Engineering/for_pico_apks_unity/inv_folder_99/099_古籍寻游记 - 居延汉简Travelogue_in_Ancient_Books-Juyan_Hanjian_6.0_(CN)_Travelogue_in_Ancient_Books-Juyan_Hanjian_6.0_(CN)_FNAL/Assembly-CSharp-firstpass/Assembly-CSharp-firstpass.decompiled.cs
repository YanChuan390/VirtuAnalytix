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
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModuleAudio
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x8E5E3C", Offset = "0x8E5E3C", VA = "0x8E5E3C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x8E5FF0", Offset = "0x8E5FF0", VA = "0x8E5FF0")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x8E617C", Offset = "0x8E617C", VA = "0x8E617C")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8E631C", Offset = "0x8E631C", VA = "0x8E631C")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x8E6384", Offset = "0x8E6384", VA = "0x8E6384")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x8E63EC", Offset = "0x8E63EC", VA = "0x8E63EC")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x8E6444", Offset = "0x8E6444", VA = "0x8E6444")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x8E64BC", Offset = "0x8E64BC", VA = "0x8E64BC")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x8E6514", Offset = "0x8E6514", VA = "0x8E6514")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8E656C", Offset = "0x8E656C", VA = "0x8E656C")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x8E65C4", Offset = "0x8E65C4", VA = "0x8E65C4")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8E661C", Offset = "0x8E661C", VA = "0x8E661C")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x8E667C", Offset = "0x8E667C", VA = "0x8E667C")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x8E66D8", Offset = "0x8E66D8", VA = "0x8E66D8")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x8E6730", Offset = "0x8E6730", VA = "0x8E6730")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x8E6850", Offset = "0x8E6850", VA = "0x8E6850")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x8E6A08", Offset = "0x8E6A08", VA = "0x8E6A08")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x8E6BB4", Offset = "0x8E6BB4", VA = "0x8E6BB4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x8E6D60", Offset = "0x8E6D60", VA = "0x8E6D60")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8E6F0C", Offset = "0x8E6F0C", VA = "0x8E6F0C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x8E70C0", Offset = "0x8E70C0", VA = "0x8E70C0")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8E7328", Offset = "0x8E7328", VA = "0x8E7328")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8E7834", Offset = "0x8E7834", VA = "0x8E7834")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8E7AA8", Offset = "0x8E7AA8", VA = "0x8E7AA8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8E7D3C", Offset = "0x8E7D3C", VA = "0x8E7D3C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8E7F10", Offset = "0x8E7F10", VA = "0x8E7F10")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8E8524", Offset = "0x8E8524", VA = "0x8E8524")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8E86D4", Offset = "0x8E86D4", VA = "0x8E86D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8E887C", Offset = "0x8E887C", VA = "0x8E887C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8E8A24", Offset = "0x8E8A24", VA = "0x8E8A24")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8E8BB4", Offset = "0x8E8BB4", VA = "0x8E8BB4")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8E8FE8", Offset = "0x8E8FE8", VA = "0x8E8FE8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8E92DC", Offset = "0x8E92DC", VA = "0x8E92DC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8E95F4", Offset = "0x8E95F4", VA = "0x8E95F4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8E97C8", Offset = "0x8E97C8", VA = "0x8E97C8")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x8E9DF4", Offset = "0x8E9DF4", VA = "0x8E9DF4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x8E9FA8", Offset = "0x8E9FA8", VA = "0x8E9FA8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x8EA134", Offset = "0x8EA134", VA = "0x8EA134")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x8EA310", Offset = "0x8EA310", VA = "0x8EA310")]
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
		[Address(RVA = "0x8EF0D4", Offset = "0x8EF0D4", VA = "0x8EF0D4")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8EA608", Offset = "0x8EA608", VA = "0x8EA608")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8EA794", Offset = "0x8EA794", VA = "0x8EA794")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8EA948", Offset = "0x8EA948", VA = "0x8EA948")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8EAAD4", Offset = "0x8EAAD4", VA = "0x8EAAD4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8EAC88", Offset = "0x8EAC88", VA = "0x8EAC88")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8EAE14", Offset = "0x8EAE14", VA = "0x8EAE14")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8EAFC4", Offset = "0x8EAFC4", VA = "0x8EAFC4")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8EB1A8", Offset = "0x8EB1A8", VA = "0x8EB1A8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8EB354", Offset = "0x8EB354", VA = "0x8EB354")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8EB500", Offset = "0x8EB500", VA = "0x8EB500")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8EB6AC", Offset = "0x8EB6AC", VA = "0x8EB6AC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8EB860", Offset = "0x8EB860", VA = "0x8EB860")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8EB9EC", Offset = "0x8EB9EC", VA = "0x8EB9EC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8EBB88", Offset = "0x8EBB88", VA = "0x8EBB88")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8EBD34", Offset = "0x8EBD34", VA = "0x8EBD34")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8EBED8", Offset = "0x8EBED8", VA = "0x8EBED8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8EC07C", Offset = "0x8EC07C", VA = "0x8EC07C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8EC230", Offset = "0x8EC230", VA = "0x8EC230")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8EC3D8", Offset = "0x8EC3D8", VA = "0x8EC3D8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8EC580", Offset = "0x8EC580", VA = "0x8EC580")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8EC728", Offset = "0x8EC728", VA = "0x8EC728")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8EC8D4", Offset = "0x8EC8D4", VA = "0x8EC8D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8ECA80", Offset = "0x8ECA80", VA = "0x8ECA80")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x8ECC1C", Offset = "0x8ECC1C", VA = "0x8ECC1C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8ECDBC", Offset = "0x8ECDBC", VA = "0x8ECDBC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x8ECF5C", Offset = "0x8ECF5C", VA = "0x8ECF5C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8ED108", Offset = "0x8ED108", VA = "0x8ED108")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x8ED2C4", Offset = "0x8ED2C4", VA = "0x8ED2C4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8ED4B0", Offset = "0x8ED4B0", VA = "0x8ED4B0")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8ED6A4", Offset = "0x8ED6A4", VA = "0x8ED6A4")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8EDACC", Offset = "0x8EDACC", VA = "0x8EDACC")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8EDC6C", Offset = "0x8EDC6C", VA = "0x8EDC6C")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8EDDFC", Offset = "0x8EDDFC", VA = "0x8EDDFC")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8EDF8C", Offset = "0x8EDF8C", VA = "0x8EDF8C")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8EE128", Offset = "0x8EE128", VA = "0x8EE128")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8EE2DC", Offset = "0x8EE2DC", VA = "0x8EE2DC")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8EE4D4", Offset = "0x8EE4D4", VA = "0x8EE4D4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8EE660", Offset = "0x8EE660", VA = "0x8EE660")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8EE898", Offset = "0x8EE898", VA = "0x8EE898")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8EEAB0", Offset = "0x8EEAB0", VA = "0x8EEAB0")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8EECC8", Offset = "0x8EECC8", VA = "0x8EECC8")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8EEEE0", Offset = "0x8EEEE0", VA = "0x8EEEE0")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
public static class DOTweenModuleUnityVersion
{
	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[CompilerGenerated]
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
		[Address(RVA = "0x8F14C8", Offset = "0x8F14C8", VA = "0x8F14C8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x8F1700", Offset = "0x8F1700", VA = "0x8F1700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[CompilerGenerated]
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
		[Address(RVA = "0x8F170C", Offset = "0x8F170C", VA = "0x8F170C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x8F1968", Offset = "0x8F1968", VA = "0x8F1968", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[CompilerGenerated]
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
		[Address(RVA = "0x8F1974", Offset = "0x8F1974", VA = "0x8F1974", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x8F1B98", Offset = "0x8F1B98", VA = "0x8F1B98", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[CompilerGenerated]
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
		[Address(RVA = "0x8F1BA4", Offset = "0x8F1BA4", VA = "0x8F1BA4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x8F1DE4", Offset = "0x8F1DE4", VA = "0x8F1DE4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[CompilerGenerated]
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
		[Address(RVA = "0x8F1DF0", Offset = "0x8F1DF0", VA = "0x8F1DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x8F2048", Offset = "0x8F2048", VA = "0x8F2048", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000053")]
	[CompilerGenerated]
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
		[Address(RVA = "0x8F2054", Offset = "0x8F2054", VA = "0x8F2054", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x8F2280", Offset = "0x8F2280", VA = "0x8F2280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x8F0094", Offset = "0x8F0094", VA = "0x8F0094")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x8F0274", Offset = "0x8F0274", VA = "0x8F0274")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x8F0460", Offset = "0x8F0460", VA = "0x8F0460")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x8F055C", Offset = "0x8F055C", VA = "0x8F055C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x8F0658", Offset = "0x8F0658", VA = "0x8F0658")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x8F0754", Offset = "0x8F0754", VA = "0x8F0754")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x8F0864", Offset = "0x8F0864", VA = "0x8F0864")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x8F0984", Offset = "0x8F0984", VA = "0x8F0984")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x8F0A80", Offset = "0x8F0A80", VA = "0x8F0A80")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x8F0C8C", Offset = "0x8F0C8C", VA = "0x8F0C8C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8F0E98", Offset = "0x8F0E98", VA = "0x8F0E98")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x8F0F84", Offset = "0x8F0F84", VA = "0x8F0F84")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x8F1070", Offset = "0x8F1070", VA = "0x8F1070")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x8F115C", Offset = "0x8F115C", VA = "0x8F115C")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x8F1250", Offset = "0x8F1250", VA = "0x8F1250")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x8F134C", Offset = "0x8F134C", VA = "0x8F134C")]
	[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
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
			[Address(RVA = "0x8F228C", Offset = "0x8F228C", VA = "0x8F228C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x8F052C", Offset = "0x8F052C", VA = "0x8F052C")]
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
			[Address(RVA = "0x8F22BC", Offset = "0x8F22BC", VA = "0x8F22BC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x8F0628", Offset = "0x8F0628", VA = "0x8F0628")]
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
			[Address(RVA = "0x8F231C", Offset = "0x8F231C", VA = "0x8F231C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x8F0724", Offset = "0x8F0724", VA = "0x8F0724")]
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
			[Address(RVA = "0x8F2338", Offset = "0x8F2338", VA = "0x8F2338", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x8F0828", Offset = "0x8F0828", VA = "0x8F0828")]
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
			[Address(RVA = "0x8F2378", Offset = "0x8F2378", VA = "0x8F2378", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8F0940", Offset = "0x8F0940", VA = "0x8F0940")]
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
			[Address(RVA = "0x8F23D0", Offset = "0x8F23D0", VA = "0x8F23D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8F0A50", Offset = "0x8F0A50", VA = "0x8F0A50")]
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
		[Address(RVA = "0x8F2560", Offset = "0x8F2560", VA = "0x8F2560")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x8F2660", Offset = "0x8F2660", VA = "0x8F2660")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x8F26EC", Offset = "0x8F26EC", VA = "0x8F26EC")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x8F2778", Offset = "0x8F2778", VA = "0x8F2778")]
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
	[Address(RVA = "0x8F2404", Offset = "0x8F2404", VA = "0x8F2404")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x8F24B8", Offset = "0x8F24B8", VA = "0x8F24B8")]
	[Preserve]
	private static void Preserver()
	{
	}
}
[Token(Token = "0x200005D")]
[AddComponentMenu("DOTween/DOTween Animation")]
public class DOTweenAnimation : ABSAnimationComponent
{
	[Token(Token = "0x200005E")]
	public enum AnimationType
	{
		[Token(Token = "0x40000B2")]
		None,
		[Token(Token = "0x40000B3")]
		Move,
		[Token(Token = "0x40000B4")]
		LocalMove,
		[Token(Token = "0x40000B5")]
		Rotate,
		[Token(Token = "0x40000B6")]
		LocalRotate,
		[Token(Token = "0x40000B7")]
		Scale,
		[Token(Token = "0x40000B8")]
		Color,
		[Token(Token = "0x40000B9")]
		Fade,
		[Token(Token = "0x40000BA")]
		Text,
		[Token(Token = "0x40000BB")]
		PunchPosition,
		[Token(Token = "0x40000BC")]
		PunchRotation,
		[Token(Token = "0x40000BD")]
		PunchScale,
		[Token(Token = "0x40000BE")]
		ShakePosition,
		[Token(Token = "0x40000BF")]
		ShakeRotation,
		[Token(Token = "0x40000C0")]
		ShakeScale,
		[Token(Token = "0x40000C1")]
		CameraAspect,
		[Token(Token = "0x40000C2")]
		CameraBackgroundColor,
		[Token(Token = "0x40000C3")]
		CameraFieldOfView,
		[Token(Token = "0x40000C4")]
		CameraOrthoSize,
		[Token(Token = "0x40000C5")]
		CameraPixelRect,
		[Token(Token = "0x40000C6")]
		CameraRect,
		[Token(Token = "0x40000C7")]
		UIWidthHeight
	}

	[Token(Token = "0x200005F")]
	public enum TargetType
	{
		[Token(Token = "0x40000C9")]
		Unset,
		[Token(Token = "0x40000CA")]
		Camera,
		[Token(Token = "0x40000CB")]
		CanvasGroup,
		[Token(Token = "0x40000CC")]
		Image,
		[Token(Token = "0x40000CD")]
		Light,
		[Token(Token = "0x40000CE")]
		RectTransform,
		[Token(Token = "0x40000CF")]
		Renderer,
		[Token(Token = "0x40000D0")]
		SpriteRenderer,
		[Token(Token = "0x40000D1")]
		Rigidbody,
		[Token(Token = "0x40000D2")]
		Rigidbody2D,
		[Token(Token = "0x40000D3")]
		Text,
		[Token(Token = "0x40000D4")]
		Transform,
		[Token(Token = "0x40000D5")]
		tk2dBaseSprite,
		[Token(Token = "0x40000D6")]
		tk2dTextMesh,
		[Token(Token = "0x40000D7")]
		TextMeshPro,
		[Token(Token = "0x40000D8")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public ShakeRandomnessMode optionalShakeRandomnessMode;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string optionalString;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _tweenAutoGenerationCalled;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int _playCount;

	[Token(Token = "0x14000001")]
	public static event Action<DOTweenAnimation> OnReset
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x8F294C", Offset = "0x8F294C", VA = "0x8F294C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x8F2A18", Offset = "0x8F2A18", VA = "0x8F2A18")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x8F2AE4", Offset = "0x8F2AE4", VA = "0x8F2AE4")]
	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x8F2B50", Offset = "0x8F2B50", VA = "0x8F2B50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8F415C", Offset = "0x8F415C", VA = "0x8F415C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x8F419C", Offset = "0x8F419C", VA = "0x8F419C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x8F41A0", Offset = "0x8F41A0", VA = "0x8F41A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x8F41D8", Offset = "0x8F41D8", VA = "0x8F41D8")]
	public void RewindThenRecreateTween()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x8F4210", Offset = "0x8F4210", VA = "0x8F4210")]
	public void RewindThenRecreateTweenAndPlay()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x8F4248", Offset = "0x8F4248", VA = "0x8F4248")]
	public void RecreateTween()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x8F4254", Offset = "0x8F4254", VA = "0x8F4254")]
	public void RecreateTweenAndPlay()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x8F2B9C", Offset = "0x8F2B9C", VA = "0x8F2B9C")]
	public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8F44A8", Offset = "0x8F44A8", VA = "0x8F44A8")]
	public List<Tween> GetTweens()
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x8F4600", Offset = "0x8F4600", VA = "0x8F4600")]
	public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x8F46EC", Offset = "0x8F46EC", VA = "0x8F46EC", Slot = "4")]
	public override void DOPlay()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x8F476C", Offset = "0x8F476C", VA = "0x8F476C", Slot = "5")]
	public override void DOPlayBackwards()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x8F47EC", Offset = "0x8F47EC", VA = "0x8F47EC", Slot = "6")]
	public override void DOPlayForward()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x8F486C", Offset = "0x8F486C", VA = "0x8F486C", Slot = "7")]
	public override void DOPause()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x8F48EC", Offset = "0x8F48EC", VA = "0x8F48EC", Slot = "8")]
	public override void DOTogglePause()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x8F496C", Offset = "0x8F496C", VA = "0x8F496C", Slot = "9")]
	public override void DORewind()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x8F4A50", Offset = "0x8F4A50", VA = "0x8F4A50", Slot = "10")]
	public override void DORestart()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x8F4A60", Offset = "0x8F4A60", VA = "0x8F4A60", Slot = "11")]
	public override void DORestart(bool fromHere)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x8F4DC0", Offset = "0x8F4DC0", VA = "0x8F4DC0", Slot = "12")]
	public override void DOComplete()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x8F4E44", Offset = "0x8F4E44", VA = "0x8F4E44", Slot = "13")]
	public override void DOKill()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x8F4ED8", Offset = "0x8F4ED8", VA = "0x8F4ED8")]
	public void DOPlayById(string id)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x8F4F60", Offset = "0x8F4F60", VA = "0x8F4F60")]
	public void DOPlayAllById(string id)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x8F4FB8", Offset = "0x8F4FB8", VA = "0x8F4FB8")]
	public void DOPauseAllById(string id)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x8F5010", Offset = "0x8F5010", VA = "0x8F5010")]
	public void DOPlayBackwardsById(string id)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x8F5098", Offset = "0x8F5098", VA = "0x8F5098")]
	public void DOPlayBackwardsAllById(string id)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x8F50F0", Offset = "0x8F50F0", VA = "0x8F50F0")]
	public void DOPlayForwardById(string id)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x8F5178", Offset = "0x8F5178", VA = "0x8F5178")]
	public void DOPlayForwardAllById(string id)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x8F51D0", Offset = "0x8F51D0", VA = "0x8F51D0")]
	public void DOPlayNext()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x8F530C", Offset = "0x8F530C", VA = "0x8F530C")]
	public void DORewindAndPlayNext()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x8F53A0", Offset = "0x8F53A0", VA = "0x8F53A0")]
	public void DORewindAllById(string id)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x8F5410", Offset = "0x8F5410", VA = "0x8F5410")]
	public void DORestartById(string id)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x8F54A8", Offset = "0x8F54A8", VA = "0x8F54A8")]
	public void DORestartAllById(string id)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x8F551C", Offset = "0x8F551C", VA = "0x8F551C")]
	public void DOKillById(string id)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x8F55A8", Offset = "0x8F55A8", VA = "0x8F55A8")]
	public void DOKillAllById(string id)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x8F4278", Offset = "0x8F4278", VA = "0x8F4278")]
	public static TargetType TypeToDOTargetType(Type t)
	{
		return default(TargetType);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x8F5604", Offset = "0x8F5604", VA = "0x8F5604")]
	public Tween CreateEditorPreview()
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x8F4260", Offset = "0x8F4260", VA = "0x8F4260")]
	private GameObject GetTweenGO()
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x8F4488", Offset = "0x8F4488", VA = "0x8F4488")]
	private GameObject GetTweenTarget()
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x8F4B6C", Offset = "0x8F4B6C", VA = "0x8F4B6C")]
	private void ReEvaluateRelativeTween()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x8F563C", Offset = "0x8F563C", VA = "0x8F563C")]
	public DOTweenAnimation()
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
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x8F5830", Offset = "0x8F5830", VA = "0x8F5830")]
	static DOTweenProShortcuts()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x8F5880", Offset = "0x8F5880", VA = "0x8F5880")]
	public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x8F5C44", Offset = "0x8F5C44", VA = "0x8F5C44")]
	public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}
}
