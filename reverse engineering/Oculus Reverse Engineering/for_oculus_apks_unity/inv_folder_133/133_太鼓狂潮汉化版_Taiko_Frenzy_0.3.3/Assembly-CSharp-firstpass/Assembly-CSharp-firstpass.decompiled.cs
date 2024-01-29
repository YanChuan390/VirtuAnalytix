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
	[Address(RVA = "0xE4080C", Offset = "0xE4080C", VA = "0xE4080C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE409C0", Offset = "0xE409C0", VA = "0xE409C0")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE40B4C", Offset = "0xE40B4C", VA = "0xE40B4C")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE40CEC", Offset = "0xE40CEC", VA = "0xE40CEC")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE40D54", Offset = "0xE40D54", VA = "0xE40D54")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE40DBC", Offset = "0xE40DBC", VA = "0xE40DBC")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE40E14", Offset = "0xE40E14", VA = "0xE40E14")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE40E8C", Offset = "0xE40E8C", VA = "0xE40E8C")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE40EE4", Offset = "0xE40EE4", VA = "0xE40EE4")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE40F3C", Offset = "0xE40F3C", VA = "0xE40F3C")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE40F94", Offset = "0xE40F94", VA = "0xE40F94")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE40FEC", Offset = "0xE40FEC", VA = "0xE40FEC")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE4104C", Offset = "0xE4104C", VA = "0xE4104C")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE410A8", Offset = "0xE410A8", VA = "0xE410A8")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE41100", Offset = "0xE41100", VA = "0xE41100")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE41220", Offset = "0xE41220", VA = "0xE41220")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE413D8", Offset = "0xE413D8", VA = "0xE413D8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE41584", Offset = "0xE41584", VA = "0xE41584")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE41730", Offset = "0xE41730", VA = "0xE41730")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE418DC", Offset = "0xE418DC", VA = "0xE418DC")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE41A90", Offset = "0xE41A90", VA = "0xE41A90")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE41CF8", Offset = "0xE41CF8", VA = "0xE41CF8")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE42204", Offset = "0xE42204", VA = "0xE42204")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE42478", Offset = "0xE42478", VA = "0xE42478")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE4270C", Offset = "0xE4270C", VA = "0xE4270C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE428E0", Offset = "0xE428E0", VA = "0xE428E0")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE42EF4", Offset = "0xE42EF4", VA = "0xE42EF4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE430A4", Offset = "0xE430A4", VA = "0xE430A4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE4324C", Offset = "0xE4324C", VA = "0xE4324C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE433F4", Offset = "0xE433F4", VA = "0xE433F4")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE43584", Offset = "0xE43584", VA = "0xE43584")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE439B8", Offset = "0xE439B8", VA = "0xE439B8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE43CAC", Offset = "0xE43CAC", VA = "0xE43CAC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE43FC4", Offset = "0xE43FC4", VA = "0xE43FC4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE44198", Offset = "0xE44198", VA = "0xE44198")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x6000064")]
	[Address(RVA = "0xE447C4", Offset = "0xE447C4", VA = "0xE447C4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xE44978", Offset = "0xE44978", VA = "0xE44978")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xE44B04", Offset = "0xE44B04", VA = "0xE44B04")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xE44CE0", Offset = "0xE44CE0", VA = "0xE44CE0")]
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
		[Address(RVA = "0xE49A94", Offset = "0xE49A94", VA = "0xE49A94")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE44FD8", Offset = "0xE44FD8", VA = "0xE44FD8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE45164", Offset = "0xE45164", VA = "0xE45164")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE45318", Offset = "0xE45318", VA = "0xE45318")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xE454A4", Offset = "0xE454A4", VA = "0xE454A4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xE45658", Offset = "0xE45658", VA = "0xE45658")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xE457E4", Offset = "0xE457E4", VA = "0xE457E4")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xE45994", Offset = "0xE45994", VA = "0xE45994")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xE45B78", Offset = "0xE45B78", VA = "0xE45B78")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xE45D24", Offset = "0xE45D24", VA = "0xE45D24")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xE45ED0", Offset = "0xE45ED0", VA = "0xE45ED0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xE4607C", Offset = "0xE4607C", VA = "0xE4607C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xE46230", Offset = "0xE46230", VA = "0xE46230")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xE463BC", Offset = "0xE463BC", VA = "0xE463BC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xE46558", Offset = "0xE46558", VA = "0xE46558")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xE46704", Offset = "0xE46704", VA = "0xE46704")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xE468A8", Offset = "0xE468A8", VA = "0xE468A8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xE46A4C", Offset = "0xE46A4C", VA = "0xE46A4C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xE46C00", Offset = "0xE46C00", VA = "0xE46C00")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xE46DA8", Offset = "0xE46DA8", VA = "0xE46DA8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xE46F50", Offset = "0xE46F50", VA = "0xE46F50")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xE470F8", Offset = "0xE470F8", VA = "0xE470F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xE472A4", Offset = "0xE472A4", VA = "0xE472A4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xE47450", Offset = "0xE47450", VA = "0xE47450")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xE475EC", Offset = "0xE475EC", VA = "0xE475EC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xE4778C", Offset = "0xE4778C", VA = "0xE4778C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xE4792C", Offset = "0xE4792C", VA = "0xE4792C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xE47AD8", Offset = "0xE47AD8", VA = "0xE47AD8")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xE47C94", Offset = "0xE47C94", VA = "0xE47C94")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xE47E78", Offset = "0xE47E78", VA = "0xE47E78")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xE48064", Offset = "0xE48064", VA = "0xE48064")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xE4848C", Offset = "0xE4848C", VA = "0xE4848C")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xE4862C", Offset = "0xE4862C", VA = "0xE4862C")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xE487BC", Offset = "0xE487BC", VA = "0xE487BC")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xE4894C", Offset = "0xE4894C", VA = "0xE4894C")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xE48AE8", Offset = "0xE48AE8", VA = "0xE48AE8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xE48C9C", Offset = "0xE48C9C", VA = "0xE48C9C")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE48E94", Offset = "0xE48E94", VA = "0xE48E94")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE49020", Offset = "0xE49020", VA = "0xE49020")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE49258", Offset = "0xE49258", VA = "0xE49258")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xE49470", Offset = "0xE49470", VA = "0xE49470")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE49688", Offset = "0xE49688", VA = "0xE49688")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xE498A0", Offset = "0xE498A0", VA = "0xE498A0")]
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
		[Address(RVA = "0xE4BE88", Offset = "0xE4BE88", VA = "0xE4BE88", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE4C0C0", Offset = "0xE4C0C0", VA = "0xE4C0C0", Slot = "5")]
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
		[Address(RVA = "0xE4C0CC", Offset = "0xE4C0CC", VA = "0xE4C0CC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE4C328", Offset = "0xE4C328", VA = "0xE4C328", Slot = "5")]
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
		[Address(RVA = "0xE4C334", Offset = "0xE4C334", VA = "0xE4C334", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE4C558", Offset = "0xE4C558", VA = "0xE4C558", Slot = "5")]
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
		[Address(RVA = "0xE4C564", Offset = "0xE4C564", VA = "0xE4C564", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE4C7A4", Offset = "0xE4C7A4", VA = "0xE4C7A4", Slot = "5")]
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
		[Address(RVA = "0xE4C7B0", Offset = "0xE4C7B0", VA = "0xE4C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE4CA08", Offset = "0xE4CA08", VA = "0xE4CA08", Slot = "5")]
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
		[Address(RVA = "0xE4CA14", Offset = "0xE4CA14", VA = "0xE4CA14", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE4CC40", Offset = "0xE4CC40", VA = "0xE4CC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE4AA54", Offset = "0xE4AA54", VA = "0xE4AA54")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE4AC34", Offset = "0xE4AC34", VA = "0xE4AC34")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE4AE20", Offset = "0xE4AE20", VA = "0xE4AE20")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE4AF1C", Offset = "0xE4AF1C", VA = "0xE4AF1C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE4B018", Offset = "0xE4B018", VA = "0xE4B018")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE4B114", Offset = "0xE4B114", VA = "0xE4B114")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE4B224", Offset = "0xE4B224", VA = "0xE4B224")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE4B344", Offset = "0xE4B344", VA = "0xE4B344")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE4B440", Offset = "0xE4B440", VA = "0xE4B440")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE4B64C", Offset = "0xE4B64C", VA = "0xE4B64C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE4B858", Offset = "0xE4B858", VA = "0xE4B858")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE4B944", Offset = "0xE4B944", VA = "0xE4B944")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE4BA30", Offset = "0xE4BA30", VA = "0xE4BA30")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE4BB1C", Offset = "0xE4BB1C", VA = "0xE4BB1C")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xE4BC10", Offset = "0xE4BC10", VA = "0xE4BC10")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xE4BD0C", Offset = "0xE4BD0C", VA = "0xE4BD0C")]
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
			[Address(RVA = "0xE4CC4C", Offset = "0xE4CC4C", VA = "0xE4CC4C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE4AEEC", Offset = "0xE4AEEC", VA = "0xE4AEEC")]
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
			[Address(RVA = "0xE4CC7C", Offset = "0xE4CC7C", VA = "0xE4CC7C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE4AFE8", Offset = "0xE4AFE8", VA = "0xE4AFE8")]
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
			[Address(RVA = "0xE4CCDC", Offset = "0xE4CCDC", VA = "0xE4CCDC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE4B0E4", Offset = "0xE4B0E4", VA = "0xE4B0E4")]
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
			[Address(RVA = "0xE4CCF8", Offset = "0xE4CCF8", VA = "0xE4CCF8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE4B1E8", Offset = "0xE4B1E8", VA = "0xE4B1E8")]
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
			[Address(RVA = "0xE4CD38", Offset = "0xE4CD38", VA = "0xE4CD38", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE4B300", Offset = "0xE4B300", VA = "0xE4B300")]
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
			[Address(RVA = "0xE4CD90", Offset = "0xE4CD90", VA = "0xE4CD90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE4B410", Offset = "0xE4B410", VA = "0xE4B410")]
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
		[Address(RVA = "0xE4CF20", Offset = "0xE4CF20", VA = "0xE4CF20")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE4D020", Offset = "0xE4D020", VA = "0xE4D020")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE4D0AC", Offset = "0xE4D0AC", VA = "0xE4D0AC")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE4D138", Offset = "0xE4D138", VA = "0xE4D138")]
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
	[Address(RVA = "0xE4CDC4", Offset = "0xE4CDC4", VA = "0xE4CDC4")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xE4CE78", Offset = "0xE4CE78", VA = "0xE4CE78")]
	[Preserve]
	private static void Preserver()
	{
	}
}
