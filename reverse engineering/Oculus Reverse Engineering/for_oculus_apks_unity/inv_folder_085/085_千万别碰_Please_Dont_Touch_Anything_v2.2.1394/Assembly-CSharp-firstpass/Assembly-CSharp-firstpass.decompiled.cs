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
	[Address(RVA = "0x84A178", Offset = "0x84A178", VA = "0x84A178")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x84A32C", Offset = "0x84A32C", VA = "0x84A32C")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x84A4B8", Offset = "0x84A4B8", VA = "0x84A4B8")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x84A658", Offset = "0x84A658", VA = "0x84A658")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x84A6C0", Offset = "0x84A6C0", VA = "0x84A6C0")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x84A728", Offset = "0x84A728", VA = "0x84A728")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x84A780", Offset = "0x84A780", VA = "0x84A780")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x84A7F8", Offset = "0x84A7F8", VA = "0x84A7F8")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x84A850", Offset = "0x84A850", VA = "0x84A850")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x84A8A8", Offset = "0x84A8A8", VA = "0x84A8A8")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x84A900", Offset = "0x84A900", VA = "0x84A900")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x84A958", Offset = "0x84A958", VA = "0x84A958")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x84A9B8", Offset = "0x84A9B8", VA = "0x84A9B8")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x84AA14", Offset = "0x84AA14", VA = "0x84AA14")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x84AA6C", Offset = "0x84AA6C", VA = "0x84AA6C")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x84AB8C", Offset = "0x84AB8C", VA = "0x84AB8C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x84AD44", Offset = "0x84AD44", VA = "0x84AD44")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x84AEF0", Offset = "0x84AEF0", VA = "0x84AEF0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x84B09C", Offset = "0x84B09C", VA = "0x84B09C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x84B248", Offset = "0x84B248", VA = "0x84B248")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x84B3FC", Offset = "0x84B3FC", VA = "0x84B3FC")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x84B664", Offset = "0x84B664", VA = "0x84B664")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x84BB70", Offset = "0x84BB70", VA = "0x84BB70")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x84BDE4", Offset = "0x84BDE4", VA = "0x84BDE4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x84C078", Offset = "0x84C078", VA = "0x84C078")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x84C24C", Offset = "0x84C24C", VA = "0x84C24C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x84C860", Offset = "0x84C860", VA = "0x84C860")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x84CA10", Offset = "0x84CA10", VA = "0x84CA10")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x84CBB8", Offset = "0x84CBB8", VA = "0x84CBB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x84CD60", Offset = "0x84CD60", VA = "0x84CD60")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x84CEF0", Offset = "0x84CEF0", VA = "0x84CEF0")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x84D324", Offset = "0x84D324", VA = "0x84D324")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x84D618", Offset = "0x84D618", VA = "0x84D618")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x84D930", Offset = "0x84D930", VA = "0x84D930")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x84DB04", Offset = "0x84DB04", VA = "0x84DB04")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x84E130", Offset = "0x84E130", VA = "0x84E130")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x84E2E4", Offset = "0x84E2E4", VA = "0x84E2E4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x84E470", Offset = "0x84E470", VA = "0x84E470")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x84E64C", Offset = "0x84E64C", VA = "0x84E64C")]
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
		[Address(RVA = "0x853400", Offset = "0x853400", VA = "0x853400")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x84E944", Offset = "0x84E944", VA = "0x84E944")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x84EAD0", Offset = "0x84EAD0", VA = "0x84EAD0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x84EC84", Offset = "0x84EC84", VA = "0x84EC84")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x84EE10", Offset = "0x84EE10", VA = "0x84EE10")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x84EFC4", Offset = "0x84EFC4", VA = "0x84EFC4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x84F150", Offset = "0x84F150", VA = "0x84F150")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x84F300", Offset = "0x84F300", VA = "0x84F300")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x84F4E4", Offset = "0x84F4E4", VA = "0x84F4E4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x84F690", Offset = "0x84F690", VA = "0x84F690")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x84F83C", Offset = "0x84F83C", VA = "0x84F83C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x84F9E8", Offset = "0x84F9E8", VA = "0x84F9E8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x84FB9C", Offset = "0x84FB9C", VA = "0x84FB9C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x84FD28", Offset = "0x84FD28", VA = "0x84FD28")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x84FEC4", Offset = "0x84FEC4", VA = "0x84FEC4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x850070", Offset = "0x850070", VA = "0x850070")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x850214", Offset = "0x850214", VA = "0x850214")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8503B8", Offset = "0x8503B8", VA = "0x8503B8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x85056C", Offset = "0x85056C", VA = "0x85056C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x850714", Offset = "0x850714", VA = "0x850714")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8508BC", Offset = "0x8508BC", VA = "0x8508BC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x850A64", Offset = "0x850A64", VA = "0x850A64")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x850C10", Offset = "0x850C10", VA = "0x850C10")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x850DBC", Offset = "0x850DBC", VA = "0x850DBC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x850F58", Offset = "0x850F58", VA = "0x850F58")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8510F8", Offset = "0x8510F8", VA = "0x8510F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x851298", Offset = "0x851298", VA = "0x851298")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x851444", Offset = "0x851444", VA = "0x851444")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x851600", Offset = "0x851600", VA = "0x851600")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8517E4", Offset = "0x8517E4", VA = "0x8517E4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8519D0", Offset = "0x8519D0", VA = "0x8519D0")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x851DF8", Offset = "0x851DF8", VA = "0x851DF8")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x851F98", Offset = "0x851F98", VA = "0x851F98")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x852128", Offset = "0x852128", VA = "0x852128")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8522B8", Offset = "0x8522B8", VA = "0x8522B8")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x852454", Offset = "0x852454", VA = "0x852454")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x852608", Offset = "0x852608", VA = "0x852608")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x852800", Offset = "0x852800", VA = "0x852800")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x85298C", Offset = "0x85298C", VA = "0x85298C")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x852BC4", Offset = "0x852BC4", VA = "0x852BC4")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x852DDC", Offset = "0x852DDC", VA = "0x852DDC")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x852FF4", Offset = "0x852FF4", VA = "0x852FF4")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x85320C", Offset = "0x85320C", VA = "0x85320C")]
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
		[Address(RVA = "0x8557F4", Offset = "0x8557F4", VA = "0x8557F4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x855A2C", Offset = "0x855A2C", VA = "0x855A2C", Slot = "5")]
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
		[Address(RVA = "0x855A38", Offset = "0x855A38", VA = "0x855A38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x855C94", Offset = "0x855C94", VA = "0x855C94", Slot = "5")]
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
		[Address(RVA = "0x855CA0", Offset = "0x855CA0", VA = "0x855CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x855EC4", Offset = "0x855EC4", VA = "0x855EC4", Slot = "5")]
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
		[Address(RVA = "0x855ED0", Offset = "0x855ED0", VA = "0x855ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x856110", Offset = "0x856110", VA = "0x856110", Slot = "5")]
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
		[Address(RVA = "0x85611C", Offset = "0x85611C", VA = "0x85611C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x856374", Offset = "0x856374", VA = "0x856374", Slot = "5")]
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
		[Address(RVA = "0x856380", Offset = "0x856380", VA = "0x856380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x8565AC", Offset = "0x8565AC", VA = "0x8565AC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x8543C0", Offset = "0x8543C0", VA = "0x8543C0")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x8545A0", Offset = "0x8545A0", VA = "0x8545A0")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x85478C", Offset = "0x85478C", VA = "0x85478C")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x854888", Offset = "0x854888", VA = "0x854888")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x854984", Offset = "0x854984", VA = "0x854984")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x854A80", Offset = "0x854A80", VA = "0x854A80")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x854B90", Offset = "0x854B90", VA = "0x854B90")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x854CB0", Offset = "0x854CB0", VA = "0x854CB0")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x854DAC", Offset = "0x854DAC", VA = "0x854DAC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x854FB8", Offset = "0x854FB8", VA = "0x854FB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8551C4", Offset = "0x8551C4", VA = "0x8551C4")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x8552B0", Offset = "0x8552B0", VA = "0x8552B0")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x85539C", Offset = "0x85539C", VA = "0x85539C")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x855488", Offset = "0x855488", VA = "0x855488")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x85557C", Offset = "0x85557C", VA = "0x85557C")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x855678", Offset = "0x855678", VA = "0x855678")]
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
			[Address(RVA = "0x8565B8", Offset = "0x8565B8", VA = "0x8565B8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x854858", Offset = "0x854858", VA = "0x854858")]
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
			[Address(RVA = "0x8565E8", Offset = "0x8565E8", VA = "0x8565E8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x854954", Offset = "0x854954", VA = "0x854954")]
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
			[Address(RVA = "0x856648", Offset = "0x856648", VA = "0x856648", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x854A50", Offset = "0x854A50", VA = "0x854A50")]
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
			[Address(RVA = "0x856664", Offset = "0x856664", VA = "0x856664", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x854B54", Offset = "0x854B54", VA = "0x854B54")]
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
			[Address(RVA = "0x8566A4", Offset = "0x8566A4", VA = "0x8566A4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x854C6C", Offset = "0x854C6C", VA = "0x854C6C")]
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
			[Address(RVA = "0x8566FC", Offset = "0x8566FC", VA = "0x8566FC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x854D7C", Offset = "0x854D7C", VA = "0x854D7C")]
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
		[Address(RVA = "0x85688C", Offset = "0x85688C", VA = "0x85688C")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x85698C", Offset = "0x85698C", VA = "0x85698C")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x856A18", Offset = "0x856A18", VA = "0x856A18")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x856AA4", Offset = "0x856AA4", VA = "0x856AA4")]
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
	[Address(RVA = "0x856730", Offset = "0x856730", VA = "0x856730")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x8567E4", Offset = "0x8567E4", VA = "0x8567E4")]
	[Preserve]
	private static void Preserver()
	{
	}
}
