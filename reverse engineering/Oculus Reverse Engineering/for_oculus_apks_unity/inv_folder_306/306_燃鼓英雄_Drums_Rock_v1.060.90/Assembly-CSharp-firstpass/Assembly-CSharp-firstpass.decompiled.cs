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
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xCDC1D4", Offset = "0xCDC1D4", VA = "0xCDC1D4")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xCDC388", Offset = "0xCDC388", VA = "0xCDC388")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xCDC514", Offset = "0xCDC514", VA = "0xCDC514")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xCDC6B4", Offset = "0xCDC6B4", VA = "0xCDC6B4")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xCDC71C", Offset = "0xCDC71C", VA = "0xCDC71C")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xCDC784", Offset = "0xCDC784", VA = "0xCDC784")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xCDC7DC", Offset = "0xCDC7DC", VA = "0xCDC7DC")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xCDC854", Offset = "0xCDC854", VA = "0xCDC854")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xCDC8AC", Offset = "0xCDC8AC", VA = "0xCDC8AC")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xCDC904", Offset = "0xCDC904", VA = "0xCDC904")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xCDC95C", Offset = "0xCDC95C", VA = "0xCDC95C")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xCDC9B4", Offset = "0xCDC9B4", VA = "0xCDC9B4")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xCDCA14", Offset = "0xCDCA14", VA = "0xCDCA14")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xCDCA70", Offset = "0xCDCA70", VA = "0xCDCA70")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xCDCAC8", Offset = "0xCDCAC8", VA = "0xCDCAC8")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xCDCBE8", Offset = "0xCDCBE8", VA = "0xCDCBE8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xCDCDA0", Offset = "0xCDCDA0", VA = "0xCDCDA0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xCDCF4C", Offset = "0xCDCF4C", VA = "0xCDCF4C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xCDD0F8", Offset = "0xCDD0F8", VA = "0xCDD0F8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xCDD2A4", Offset = "0xCDD2A4", VA = "0xCDD2A4")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xCDD458", Offset = "0xCDD458", VA = "0xCDD458")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xCDD6C0", Offset = "0xCDD6C0", VA = "0xCDD6C0")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xCDDBCC", Offset = "0xCDDBCC", VA = "0xCDDBCC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xCDDE40", Offset = "0xCDDE40", VA = "0xCDDE40")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xCDE0D4", Offset = "0xCDE0D4", VA = "0xCDE0D4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xCDE2A8", Offset = "0xCDE2A8", VA = "0xCDE2A8")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x6000040")]
	[Address(RVA = "0xCDE8BC", Offset = "0xCDE8BC", VA = "0xCDE8BC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xCDEA6C", Offset = "0xCDEA6C", VA = "0xCDEA6C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xCDEC14", Offset = "0xCDEC14", VA = "0xCDEC14")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xCDEDBC", Offset = "0xCDEDBC", VA = "0xCDEDBC")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xCDEF4C", Offset = "0xCDEF4C", VA = "0xCDEF4C")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xCDF380", Offset = "0xCDF380", VA = "0xCDF380")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xCDF670", Offset = "0xCDF670", VA = "0xCDF670")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0xCDFC78", Offset = "0xCDFC78", VA = "0xCDFC78")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xCDFE2C", Offset = "0xCDFE2C", VA = "0xCDFE2C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xCDFFB8", Offset = "0xCDFFB8", VA = "0xCDFFB8")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xCE0194", Offset = "0xCE0194", VA = "0xCE0194")]
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
		[Address(RVA = "0xCE4D54", Offset = "0xCE4D54", VA = "0xCE4D54")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xCE048C", Offset = "0xCE048C", VA = "0xCE048C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xCE0618", Offset = "0xCE0618", VA = "0xCE0618")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xCE07CC", Offset = "0xCE07CC", VA = "0xCE07CC")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xCE0958", Offset = "0xCE0958", VA = "0xCE0958")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xCE0B0C", Offset = "0xCE0B0C", VA = "0xCE0B0C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xCE0C98", Offset = "0xCE0C98", VA = "0xCE0C98")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xCE0E48", Offset = "0xCE0E48", VA = "0xCE0E48")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xCE102C", Offset = "0xCE102C", VA = "0xCE102C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xCE11D8", Offset = "0xCE11D8", VA = "0xCE11D8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xCE1384", Offset = "0xCE1384", VA = "0xCE1384")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xCE1530", Offset = "0xCE1530", VA = "0xCE1530")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xCE16E4", Offset = "0xCE16E4", VA = "0xCE16E4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xCE1870", Offset = "0xCE1870", VA = "0xCE1870")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xCE1A0C", Offset = "0xCE1A0C", VA = "0xCE1A0C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xCE1BB8", Offset = "0xCE1BB8", VA = "0xCE1BB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xCE1D5C", Offset = "0xCE1D5C", VA = "0xCE1D5C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xCE1F00", Offset = "0xCE1F00", VA = "0xCE1F00")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xCE20B4", Offset = "0xCE20B4", VA = "0xCE20B4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xCE225C", Offset = "0xCE225C", VA = "0xCE225C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xCE2404", Offset = "0xCE2404", VA = "0xCE2404")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xCE25AC", Offset = "0xCE25AC", VA = "0xCE25AC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xCE2758", Offset = "0xCE2758", VA = "0xCE2758")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xCE2904", Offset = "0xCE2904", VA = "0xCE2904")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xCE2AA0", Offset = "0xCE2AA0", VA = "0xCE2AA0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xCE2C40", Offset = "0xCE2C40", VA = "0xCE2C40")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xCE2DE0", Offset = "0xCE2DE0", VA = "0xCE2DE0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xCE2F8C", Offset = "0xCE2F8C", VA = "0xCE2F8C")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xCE3148", Offset = "0xCE3148", VA = "0xCE3148")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xCE332C", Offset = "0xCE332C", VA = "0xCE332C")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xCE3518", Offset = "0xCE3518", VA = "0xCE3518")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xCE3940", Offset = "0xCE3940", VA = "0xCE3940")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xCE3AE0", Offset = "0xCE3AE0", VA = "0xCE3AE0")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xCE3C70", Offset = "0xCE3C70", VA = "0xCE3C70")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xCE3E00", Offset = "0xCE3E00", VA = "0xCE3E00")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xCE3F9C", Offset = "0xCE3F9C", VA = "0xCE3F9C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xCE4150", Offset = "0xCE4150", VA = "0xCE4150")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xCE4348", Offset = "0xCE4348", VA = "0xCE4348")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xCE44D4", Offset = "0xCE44D4", VA = "0xCE44D4")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xCE470C", Offset = "0xCE470C", VA = "0xCE470C")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xCE4924", Offset = "0xCE4924", VA = "0xCE4924")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xCE4B3C", Offset = "0xCE4B3C", VA = "0xCE4B3C")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUnityVersion
{
	[StructLayout(3)]
	[Token(Token = "0x200004B")]
	[CompilerGenerated]
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
		[Address(RVA = "0xCE7110", Offset = "0xCE7110", VA = "0xCE7110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xCE7348", Offset = "0xCE7348", VA = "0xCE7348", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[CompilerGenerated]
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
		[Address(RVA = "0xCE7354", Offset = "0xCE7354", VA = "0xCE7354", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xCE75B0", Offset = "0xCE75B0", VA = "0xCE75B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[CompilerGenerated]
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
		[Address(RVA = "0xCE75BC", Offset = "0xCE75BC", VA = "0xCE75BC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xCE77E0", Offset = "0xCE77E0", VA = "0xCE77E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[CompilerGenerated]
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
		[Address(RVA = "0xCE77EC", Offset = "0xCE77EC", VA = "0xCE77EC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xCE7A2C", Offset = "0xCE7A2C", VA = "0xCE7A2C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[CompilerGenerated]
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
		[Address(RVA = "0xCE7A38", Offset = "0xCE7A38", VA = "0xCE7A38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xCE7C90", Offset = "0xCE7C90", VA = "0xCE7C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[CompilerGenerated]
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
		[Address(RVA = "0xCE7C9C", Offset = "0xCE7C9C", VA = "0xCE7C9C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xCE7EC8", Offset = "0xCE7EC8", VA = "0xCE7EC8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xCE5CDC", Offset = "0xCE5CDC", VA = "0xCE5CDC")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xCE5EBC", Offset = "0xCE5EBC", VA = "0xCE5EBC")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xCE60A8", Offset = "0xCE60A8", VA = "0xCE60A8")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xCE61A4", Offset = "0xCE61A4", VA = "0xCE61A4")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xCE62A0", Offset = "0xCE62A0", VA = "0xCE62A0")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xCE639C", Offset = "0xCE639C", VA = "0xCE639C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xCE64AC", Offset = "0xCE64AC", VA = "0xCE64AC")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xCE65CC", Offset = "0xCE65CC", VA = "0xCE65CC")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xCE66C8", Offset = "0xCE66C8", VA = "0xCE66C8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xCE68D4", Offset = "0xCE68D4", VA = "0xCE68D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xCE6AE0", Offset = "0xCE6AE0", VA = "0xCE6AE0")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xCE6BCC", Offset = "0xCE6BCC", VA = "0xCE6BCC")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xCE6CB8", Offset = "0xCE6CB8", VA = "0xCE6CB8")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xCE6DA4", Offset = "0xCE6DA4", VA = "0xCE6DA4")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xCE6E98", Offset = "0xCE6E98", VA = "0xCE6E98")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xCE6F94", Offset = "0xCE6F94", VA = "0xCE6F94")]
	[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
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
			[Address(RVA = "0xCE7ED4", Offset = "0xCE7ED4", VA = "0xCE7ED4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xCE6174", Offset = "0xCE6174", VA = "0xCE6174")]
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
			[Address(RVA = "0xCE7F04", Offset = "0xCE7F04", VA = "0xCE7F04", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xCE6270", Offset = "0xCE6270", VA = "0xCE6270")]
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
			[Address(RVA = "0xCE7F64", Offset = "0xCE7F64", VA = "0xCE7F64", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xCE636C", Offset = "0xCE636C", VA = "0xCE636C")]
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
			[Address(RVA = "0xCE7F80", Offset = "0xCE7F80", VA = "0xCE7F80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xCE6470", Offset = "0xCE6470", VA = "0xCE6470")]
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
			[Address(RVA = "0xCE7FC0", Offset = "0xCE7FC0", VA = "0xCE7FC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xCE6588", Offset = "0xCE6588", VA = "0xCE6588")]
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
			[Address(RVA = "0xCE8018", Offset = "0xCE8018", VA = "0xCE8018", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xCE6698", Offset = "0xCE6698", VA = "0xCE6698")]
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
		[Address(RVA = "0xCE81A8", Offset = "0xCE81A8", VA = "0xCE81A8")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xCE82A8", Offset = "0xCE82A8", VA = "0xCE82A8")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xCE8334", Offset = "0xCE8334", VA = "0xCE8334")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xCE83C0", Offset = "0xCE83C0", VA = "0xCE83C0")]
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
	[Address(RVA = "0xCE804C", Offset = "0xCE804C", VA = "0xCE804C")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xCE8100", Offset = "0xCE8100", VA = "0xCE8100")]
	[Preserve]
	private static void Preserver()
	{
	}
}
