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
	[Address(RVA = "0xDF60A0", Offset = "0xDF60A0", VA = "0xDF60A0")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDF623C", Offset = "0xDF623C", VA = "0xDF623C")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDF63B0", Offset = "0xDF63B0", VA = "0xDF63B0")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xDF6528", Offset = "0xDF6528", VA = "0xDF6528")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDF6590", Offset = "0xDF6590", VA = "0xDF6590")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDF65F8", Offset = "0xDF65F8", VA = "0xDF65F8")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDF6650", Offset = "0xDF6650", VA = "0xDF6650")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDF66C8", Offset = "0xDF66C8", VA = "0xDF66C8")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDF6720", Offset = "0xDF6720", VA = "0xDF6720")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDF6778", Offset = "0xDF6778", VA = "0xDF6778")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDF67D0", Offset = "0xDF67D0", VA = "0xDF67D0")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDF6828", Offset = "0xDF6828", VA = "0xDF6828")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDF6888", Offset = "0xDF6888", VA = "0xDF6888")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDF68E4", Offset = "0xDF68E4", VA = "0xDF68E4")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDF693C", Offset = "0xDF693C", VA = "0xDF693C")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDF6A5C", Offset = "0xDF6A5C", VA = "0xDF6A5C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDF6C04", Offset = "0xDF6C04", VA = "0xDF6C04")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDF6DA0", Offset = "0xDF6DA0", VA = "0xDF6DA0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDF6F3C", Offset = "0xDF6F3C", VA = "0xDF6F3C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDF70D8", Offset = "0xDF70D8", VA = "0xDF70D8")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDF727C", Offset = "0xDF727C", VA = "0xDF727C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDF74D4", Offset = "0xDF74D4", VA = "0xDF74D4")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDF79B4", Offset = "0xDF79B4", VA = "0xDF79B4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDF7C18", Offset = "0xDF7C18", VA = "0xDF7C18")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDF7E88", Offset = "0xDF7E88", VA = "0xDF7E88")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDF804C", Offset = "0xDF804C", VA = "0xDF804C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDF863C", Offset = "0xDF863C", VA = "0xDF863C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDF87DC", Offset = "0xDF87DC", VA = "0xDF87DC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDF8974", Offset = "0xDF8974", VA = "0xDF8974")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDF8B0C", Offset = "0xDF8B0C", VA = "0xDF8B0C")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDF8C8C", Offset = "0xDF8C8C", VA = "0xDF8C8C")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDF9094", Offset = "0xDF9094", VA = "0xDF9094")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDF9374", Offset = "0xDF9374", VA = "0xDF9374")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDF966C", Offset = "0xDF966C", VA = "0xDF966C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDF9828", Offset = "0xDF9828", VA = "0xDF9828")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x6000064")]
	[Address(RVA = "0xDF9E30", Offset = "0xDF9E30", VA = "0xDF9E30")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xDF9FCC", Offset = "0xDF9FCC", VA = "0xDF9FCC")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xDFA140", Offset = "0xDFA140", VA = "0xDFA140")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xDFA31C", Offset = "0xDFA31C", VA = "0xDFA31C")]
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
		[Address(RVA = "0xDFED60", Offset = "0xDFED60", VA = "0xDFED60")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xDFA5FC", Offset = "0xDFA5FC", VA = "0xDFA5FC")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xDFA770", Offset = "0xDFA770", VA = "0xDFA770")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xDFA90C", Offset = "0xDFA90C", VA = "0xDFA90C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xDFAA80", Offset = "0xDFAA80", VA = "0xDFAA80")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xDFAC1C", Offset = "0xDFAC1C", VA = "0xDFAC1C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xDFAD90", Offset = "0xDFAD90", VA = "0xDFAD90")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xDFAF28", Offset = "0xDFAF28", VA = "0xDFAF28")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xDFB10C", Offset = "0xDFB10C", VA = "0xDFB10C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xDFB2A8", Offset = "0xDFB2A8", VA = "0xDFB2A8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xDFB444", Offset = "0xDFB444", VA = "0xDFB444")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xDFB5E0", Offset = "0xDFB5E0", VA = "0xDFB5E0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xDFB77C", Offset = "0xDFB77C", VA = "0xDFB77C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xDFB8F0", Offset = "0xDFB8F0", VA = "0xDFB8F0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xDFBA74", Offset = "0xDFBA74", VA = "0xDFBA74")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xDFBC10", Offset = "0xDFBC10", VA = "0xDFBC10")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xDFBDA4", Offset = "0xDFBDA4", VA = "0xDFBDA4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xDFBF38", Offset = "0xDFBF38", VA = "0xDFBF38")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xDFC0DC", Offset = "0xDFC0DC", VA = "0xDFC0DC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xDFC274", Offset = "0xDFC274", VA = "0xDFC274")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xDFC40C", Offset = "0xDFC40C", VA = "0xDFC40C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xDFC5A4", Offset = "0xDFC5A4", VA = "0xDFC5A4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xDFC740", Offset = "0xDFC740", VA = "0xDFC740")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xDFC8DC", Offset = "0xDFC8DC", VA = "0xDFC8DC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xDFCA60", Offset = "0xDFCA60", VA = "0xDFCA60")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xDFCBE8", Offset = "0xDFCBE8", VA = "0xDFCBE8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDFCD70", Offset = "0xDFCD70", VA = "0xDFCD70")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDFCF0C", Offset = "0xDFCF0C", VA = "0xDFCF0C")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDFD0B0", Offset = "0xDFD0B0", VA = "0xDFD0B0")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xDFD27C", Offset = "0xDFD27C", VA = "0xDFD27C")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xDFD450", Offset = "0xDFD450", VA = "0xDFD450")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xDFD85C", Offset = "0xDFD85C", VA = "0xDFD85C")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xDFD9EC", Offset = "0xDFD9EC", VA = "0xDFD9EC")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xDFDB6C", Offset = "0xDFDB6C", VA = "0xDFDB6C")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xDFDCEC", Offset = "0xDFDCEC", VA = "0xDFDCEC")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xDFDE78", Offset = "0xDFDE78", VA = "0xDFDE78")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xDFE014", Offset = "0xDFE014", VA = "0xDFE014")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xDFE1F0", Offset = "0xDFE1F0", VA = "0xDFE1F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xDFE364", Offset = "0xDFE364", VA = "0xDFE364")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xDFE584", Offset = "0xDFE584", VA = "0xDFE584")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xDFE784", Offset = "0xDFE784", VA = "0xDFE784")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xDFE984", Offset = "0xDFE984", VA = "0xDFE984")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xDFEB84", Offset = "0xDFEB84", VA = "0xDFEB84")]
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
		[Address(RVA = "0xE00FD4", Offset = "0xE00FD4", VA = "0xE00FD4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE0120C", Offset = "0xE0120C", VA = "0xE0120C", Slot = "5")]
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
		[Address(RVA = "0xE01218", Offset = "0xE01218", VA = "0xE01218", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE01474", Offset = "0xE01474", VA = "0xE01474", Slot = "5")]
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
		[Address(RVA = "0xE01480", Offset = "0xE01480", VA = "0xE01480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE016A4", Offset = "0xE016A4", VA = "0xE016A4", Slot = "5")]
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
		[Address(RVA = "0xE016B0", Offset = "0xE016B0", VA = "0xE016B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE018F0", Offset = "0xE018F0", VA = "0xE018F0", Slot = "5")]
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
		[Address(RVA = "0xE018FC", Offset = "0xE018FC", VA = "0xE018FC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE01B54", Offset = "0xE01B54", VA = "0xE01B54", Slot = "5")]
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
		[Address(RVA = "0xE01B60", Offset = "0xE01B60", VA = "0xE01B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE01D8C", Offset = "0xE01D8C", VA = "0xE01D8C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xDFFD20", Offset = "0xDFFD20", VA = "0xDFFD20")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xDFFF00", Offset = "0xDFFF00", VA = "0xDFFF00")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE000EC", Offset = "0xE000EC", VA = "0xE000EC")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE001D4", Offset = "0xE001D4", VA = "0xE001D4")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE002BC", Offset = "0xE002BC", VA = "0xE002BC")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE003A4", Offset = "0xE003A4", VA = "0xE003A4")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE0049C", Offset = "0xE0049C", VA = "0xE0049C")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE005A4", Offset = "0xE005A4", VA = "0xE005A4")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE0068C", Offset = "0xE0068C", VA = "0xE0068C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE00880", Offset = "0xE00880", VA = "0xE00880")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE00A74", Offset = "0xE00A74", VA = "0xE00A74")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE00B3C", Offset = "0xE00B3C", VA = "0xE00B3C")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE00C04", Offset = "0xE00C04", VA = "0xE00C04")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE00CCC", Offset = "0xE00CCC", VA = "0xE00CCC")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xE00DA4", Offset = "0xE00DA4", VA = "0xE00DA4")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xE00E7C", Offset = "0xE00E7C", VA = "0xE00E7C")]
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
			[Address(RVA = "0xE01D98", Offset = "0xE01D98", VA = "0xE01D98", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE001AC", Offset = "0xE001AC", VA = "0xE001AC")]
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
			[Address(RVA = "0xE01DC8", Offset = "0xE01DC8", VA = "0xE01DC8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE00294", Offset = "0xE00294", VA = "0xE00294")]
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
			[Address(RVA = "0xE01E28", Offset = "0xE01E28", VA = "0xE01E28", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE0037C", Offset = "0xE0037C", VA = "0xE0037C")]
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
			[Address(RVA = "0xE01E44", Offset = "0xE01E44", VA = "0xE01E44", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE0046C", Offset = "0xE0046C", VA = "0xE0046C")]
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
			[Address(RVA = "0xE01E84", Offset = "0xE01E84", VA = "0xE01E84", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE0056C", Offset = "0xE0056C", VA = "0xE0056C")]
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
			[Address(RVA = "0xE01EDC", Offset = "0xE01EDC", VA = "0xE01EDC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE00664", Offset = "0xE00664", VA = "0xE00664")]
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
		[Address(RVA = "0xE0206C", Offset = "0xE0206C", VA = "0xE0206C")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE0216C", Offset = "0xE0216C", VA = "0xE0216C")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE021F8", Offset = "0xE021F8", VA = "0xE021F8")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE02284", Offset = "0xE02284", VA = "0xE02284")]
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
	[Address(RVA = "0xE01F10", Offset = "0xE01F10", VA = "0xE01F10")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xE01FC4", Offset = "0xE01FC4", VA = "0xE01FC4")]
	[Preserve]
	private static void Preserver()
	{
	}
}
