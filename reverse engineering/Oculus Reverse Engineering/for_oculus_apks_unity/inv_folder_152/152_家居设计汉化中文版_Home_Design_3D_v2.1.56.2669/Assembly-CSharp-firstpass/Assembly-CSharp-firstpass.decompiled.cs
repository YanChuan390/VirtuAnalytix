using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CodeStage.AdvancedFPSCounter.CountersData;
using CodeStage.AdvancedFPSCounter.Labels;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal class LabelEffect
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 distance;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int padding;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE32290", Offset = "0xE32290", VA = "0xE32290")]
	internal LabelEffect(bool enabled, Color color, int padding)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE32330", Offset = "0xE32330", VA = "0xE32330")]
	internal LabelEffect(bool enabled, Color color, Vector2 distance)
	{
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000003")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xE32394", Offset = "0xE32394", VA = "0xE32394")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xE32548", Offset = "0xE32548", VA = "0xE32548")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xE326D4", Offset = "0xE326D4", VA = "0xE326D4")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xE32874", Offset = "0xE32874", VA = "0xE32874")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xE328DC", Offset = "0xE328DC", VA = "0xE328DC")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xE32944", Offset = "0xE32944", VA = "0xE32944")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xE3299C", Offset = "0xE3299C", VA = "0xE3299C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xE32A14", Offset = "0xE32A14", VA = "0xE32A14")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xE32A6C", Offset = "0xE32A6C", VA = "0xE32A6C")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE32AC4", Offset = "0xE32AC4", VA = "0xE32AC4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xE32B1C", Offset = "0xE32B1C", VA = "0xE32B1C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE32B74", Offset = "0xE32B74", VA = "0xE32B74")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE32BD4", Offset = "0xE32BD4", VA = "0xE32BD4")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE32C30", Offset = "0xE32C30", VA = "0xE32C30")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE32C88", Offset = "0xE32C88", VA = "0xE32C88")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000007")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE32DA8", Offset = "0xE32DA8", VA = "0xE32DA8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE32F60", Offset = "0xE32F60", VA = "0xE32F60")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE3310C", Offset = "0xE3310C", VA = "0xE3310C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE332B8", Offset = "0xE332B8", VA = "0xE332B8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE33464", Offset = "0xE33464", VA = "0xE33464")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE33618", Offset = "0xE33618", VA = "0xE33618")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE33880", Offset = "0xE33880", VA = "0xE33880")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE33D8C", Offset = "0xE33D8C", VA = "0xE33D8C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE34000", Offset = "0xE34000", VA = "0xE34000")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE34294", Offset = "0xE34294", VA = "0xE34294")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE34468", Offset = "0xE34468", VA = "0xE34468")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000013")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE34A7C", Offset = "0xE34A7C", VA = "0xE34A7C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xE34C2C", Offset = "0xE34C2C", VA = "0xE34C2C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE34DD4", Offset = "0xE34DD4", VA = "0xE34DD4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xE34F7C", Offset = "0xE34F7C", VA = "0xE34F7C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xE3510C", Offset = "0xE3510C", VA = "0xE3510C")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xE35540", Offset = "0xE35540", VA = "0xE35540")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xE35834", Offset = "0xE35834", VA = "0xE35834")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xE35B4C", Offset = "0xE35B4C", VA = "0xE35B4C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE35D20", Offset = "0xE35D20", VA = "0xE35D20")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE3634C", Offset = "0xE3634C", VA = "0xE3634C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE36500", Offset = "0xE36500", VA = "0xE36500")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE3668C", Offset = "0xE3668C", VA = "0xE3668C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE36868", Offset = "0xE36868", VA = "0xE36868")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000021")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000022")]
		public static class Utils
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0xE3B62C", Offset = "0xE3B62C", VA = "0xE3B62C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE36B60", Offset = "0xE36B60", VA = "0xE36B60")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE36CEC", Offset = "0xE36CEC", VA = "0xE36CEC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE36EA0", Offset = "0xE36EA0", VA = "0xE36EA0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE3702C", Offset = "0xE3702C", VA = "0xE3702C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE371E0", Offset = "0xE371E0", VA = "0xE371E0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE3736C", Offset = "0xE3736C", VA = "0xE3736C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE3751C", Offset = "0xE3751C", VA = "0xE3751C")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE37700", Offset = "0xE37700", VA = "0xE37700")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE378AC", Offset = "0xE378AC", VA = "0xE378AC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE37A58", Offset = "0xE37A58", VA = "0xE37A58")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE37C04", Offset = "0xE37C04", VA = "0xE37C04")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE37DB8", Offset = "0xE37DB8", VA = "0xE37DB8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE37F44", Offset = "0xE37F44", VA = "0xE37F44")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE380E0", Offset = "0xE380E0", VA = "0xE380E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE3828C", Offset = "0xE3828C", VA = "0xE3828C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE38430", Offset = "0xE38430", VA = "0xE38430")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE385D4", Offset = "0xE385D4", VA = "0xE385D4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE38788", Offset = "0xE38788", VA = "0xE38788")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE38930", Offset = "0xE38930", VA = "0xE38930")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE38AD8", Offset = "0xE38AD8", VA = "0xE38AD8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE38C80", Offset = "0xE38C80", VA = "0xE38C80")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE38E2C", Offset = "0xE38E2C", VA = "0xE38E2C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE38FD8", Offset = "0xE38FD8", VA = "0xE38FD8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE39174", Offset = "0xE39174", VA = "0xE39174")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE39314", Offset = "0xE39314", VA = "0xE39314")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE394B4", Offset = "0xE394B4", VA = "0xE394B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE39660", Offset = "0xE39660", VA = "0xE39660")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE3981C", Offset = "0xE3981C", VA = "0xE3981C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE39A08", Offset = "0xE39A08", VA = "0xE39A08")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE39BFC", Offset = "0xE39BFC", VA = "0xE39BFC")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE3A024", Offset = "0xE3A024", VA = "0xE3A024")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE3A1C4", Offset = "0xE3A1C4", VA = "0xE3A1C4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE3A354", Offset = "0xE3A354", VA = "0xE3A354")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE3A4E4", Offset = "0xE3A4E4", VA = "0xE3A4E4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE3A680", Offset = "0xE3A680", VA = "0xE3A680")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE3A834", Offset = "0xE3A834", VA = "0xE3A834")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE3AA2C", Offset = "0xE3AA2C", VA = "0xE3AA2C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE3ABB8", Offset = "0xE3ABB8", VA = "0xE3ABB8")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE3ADF0", Offset = "0xE3ADF0", VA = "0xE3ADF0")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE3B008", Offset = "0xE3B008", VA = "0xE3B008")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE3B220", Offset = "0xE3B220", VA = "0xE3B220")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE3B438", Offset = "0xE3B438", VA = "0xE3B438")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
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
			[Address(RVA = "0xE3DA20", Offset = "0xE3DA20", VA = "0xE3DA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0xE3DC58", Offset = "0xE3DC58", VA = "0xE3DC58", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
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
			[Address(RVA = "0xE3DC64", Offset = "0xE3DC64", VA = "0xE3DC64", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0xE3DEC0", Offset = "0xE3DEC0", VA = "0xE3DEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
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
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000137")]
			[Address(RVA = "0xE3DECC", Offset = "0xE3DECC", VA = "0xE3DECC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0xE3E0F0", Offset = "0xE3E0F0", VA = "0xE3E0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE3E0FC", Offset = "0xE3E0FC", VA = "0xE3E0FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0xE3E33C", Offset = "0xE3E33C", VA = "0xE3E33C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600013B")]
			[Address(RVA = "0xE3E348", Offset = "0xE3E348", VA = "0xE3E348", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0xE3E5A0", Offset = "0xE3E5A0", VA = "0xE3E5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600013D")]
			[Address(RVA = "0xE3E5AC", Offset = "0xE3E5AC", VA = "0xE3E5AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0xE3E7D8", Offset = "0xE3E7D8", VA = "0xE3E7D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE3C5EC", Offset = "0xE3C5EC", VA = "0xE3C5EC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE3C7CC", Offset = "0xE3C7CC", VA = "0xE3C7CC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE3C9B8", Offset = "0xE3C9B8", VA = "0xE3C9B8")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE3CAB4", Offset = "0xE3CAB4", VA = "0xE3CAB4")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE3CBB0", Offset = "0xE3CBB0", VA = "0xE3CBB0")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE3CCAC", Offset = "0xE3CCAC", VA = "0xE3CCAC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE3CDBC", Offset = "0xE3CDBC", VA = "0xE3CDBC")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE3CEDC", Offset = "0xE3CEDC", VA = "0xE3CEDC")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE3CFD8", Offset = "0xE3CFD8", VA = "0xE3CFD8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE3D1E4", Offset = "0xE3D1E4", VA = "0xE3D1E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE3D3F0", Offset = "0xE3D3F0", VA = "0xE3D3F0")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE3D4DC", Offset = "0xE3D4DC", VA = "0xE3D4DC")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE3D5C8", Offset = "0xE3D5C8", VA = "0xE3D5C8")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE3D6B4", Offset = "0xE3D6B4", VA = "0xE3D6B4")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE3D7A8", Offset = "0xE3D7A8", VA = "0xE3D7A8")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE3D8A4", Offset = "0xE3D8A4", VA = "0xE3D8A4")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000055")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000056")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000001")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0xE3E7E4", Offset = "0xE3E7E4", VA = "0xE3E7E4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0xE3CA84", Offset = "0xE3CA84", VA = "0xE3CA84")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000057")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000002")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000141")]
				[Address(RVA = "0xE3E814", Offset = "0xE3E814", VA = "0xE3E814", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0xE3CB80", Offset = "0xE3CB80", VA = "0xE3CB80")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000058")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000003")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000143")]
				[Address(RVA = "0xE3E874", Offset = "0xE3E874", VA = "0xE3E874", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0xE3CC7C", Offset = "0xE3CC7C", VA = "0xE3CC7C")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000059")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000004")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0xE3E890", Offset = "0xE3E890", VA = "0xE3E890", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE3CD80", Offset = "0xE3CD80", VA = "0xE3CD80")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200005A")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000005")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000147")]
				[Address(RVA = "0xE3E8D0", Offset = "0xE3E8D0", VA = "0xE3E8D0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE3CE98", Offset = "0xE3CE98", VA = "0xE3CE98")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200005B")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000006")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000149")]
				[Address(RVA = "0xE3E928", Offset = "0xE3E928", VA = "0xE3E928", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE3CFA8", Offset = "0xE3CFA8", VA = "0xE3CFA8")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200005C")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200005D")]
		public static class Physics
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE3EAB8", Offset = "0xE3EAB8", VA = "0xE3EAB8")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0xE3EBB8", Offset = "0xE3EBB8", VA = "0xE3EBB8")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0xE3EC44", Offset = "0xE3EC44", VA = "0xE3EC44")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0xE3ECD0", Offset = "0xE3ECD0", VA = "0xE3ECD0")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE3E95C", Offset = "0xE3E95C", VA = "0xE3E95C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE3EA10", Offset = "0xE3EA10", VA = "0xE3EA10")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x200005E")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Code Stage/Advanced FPS Counter")]
	public class AFPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		private const string MENU_PATH = "Code Stage/Advanced FPS Counter";

		[Token(Token = "0x400008D")]
		private const string COMPONENT_NAME = "Advanced FPS Counter";

		[Token(Token = "0x400008E")]
		internal const string LOG_PREFIX = "<b>[AFPSCounter]:</b> ";

		[Token(Token = "0x400008F")]
		internal const char NEW_LINE = '\n';

		[Token(Token = "0x4000090")]
		internal const char SPACE = ' ';

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FPSCounterData fpsCounter;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MemoryCounterData memoryCounter;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DeviceInfoCounterData deviceInfoCounter;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Used to enable / disable plugin at runtime.\nSet to None to disable.")]
		public KeyCode hotKey;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Used to enable / disable plugin at runtime.\nMake two circle gestures with your finger \\ mouse to switch plugin on and off.")]
		public bool circleGesture;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[Tooltip("Hot key modifier: any Control on Windows or any Command on Mac.")]
		public bool hotKeyCtrl;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[Tooltip("Hot key modifier: any Shift.")]
		public bool hotKeyShift;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[Tooltip("Hot key modifier: any Alt.")]
		public bool hotKeyAlt;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Prevents current or other topmost Game Object from destroying on level (scene) load.\nApplied once, on Start phase.")]
		[SerializeField]
		private bool keepAlive;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Canvas canvas;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool externalCanvas;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DrawableLabel[] labels;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int anchorsCount;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int cachedVSync;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int cachedFrameRate;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool inited;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<Vector2> gesturePoints;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int gestureCount;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Disabled: removes labels and stops all internal processes except Hot Key listener.\n\nBackground: removes labels keeping counters alive; use for hidden performance monitoring.\n\nNormal: shows labels and runs all internal processes as usual.")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[Tooltip("Allows to see how your game performs on specified frame rate.\nDoes not guarantee selected frame rate. Set -1 to render as fast as possible in current conditions.\nIMPORTANT: this option disables VSync while enabled!")]
		private bool forceFrameRate;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Range(-1f, 200f)]
		private int forcedFrameRate;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Tooltip("Background for all texts. Cheapest effect. Overhead: 1 Draw Call.")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("Color of the background.")]
		private Color backgroundColor;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Padding of the background.")]
		[SerializeField]
		[Range(0f, 30f)]
		private int backgroundPadding;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Tooltip("Shadow effect for all texts. This effect uses extra resources. Overhead: medium CPU and light GPU usage.")]
		private bool shadow;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("Color of the shadow effect.")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("Distance of the shadow effect.")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("Outline effect for all texts. Resource-heaviest effect. Overhead: huge CPU and medium GPU usage. Not recommended for use unless really necessary.")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Tooltip("Color of the outline effect.")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[Tooltip("Distance of the outline effect.")]
		private Vector2 outlineDistance;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("Controls own canvas scaler scale mode. Chec to use ScaleWithScreenSize. Otherwise ConstantPixelSize will be used.")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("Controls global scale of all texts.")]
		[Range(0f, 30f)]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Tooltip("Leave blank to use default font.")]
		private Font labelsFont;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Range(0f, 100f)]
		[Tooltip("Set to 0 to use font size specified in the font importer.")]
		[SerializeField]
		private int fontSize;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[Tooltip("Space between lines in labels.")]
		[Range(0f, 10f)]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("Lines count between different counters in a single label.")]
		[Range(0f, 10f)]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[Tooltip("Pixel offset for anchored labels. Automatically applied to all labels.")]
		private Vector2 paddingOffset;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[Tooltip("Controls own canvas Pixel Perfect property.")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Sorting order to use for the canvas.\nSet higher value to get closer to the user.")]
		[SerializeField]
		private int sortingOrder;

		[Token(Token = "0x17000007")]
		public bool KeepAlive
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xE3EEA4", Offset = "0xE3EEA4", VA = "0xE3EEA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xE3EEAC", Offset = "0xE3EEAC", VA = "0xE3EEAC")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xE3EEB4", Offset = "0xE3EEB4", VA = "0xE3EEB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xE3F518", Offset = "0xE3F518", VA = "0xE3F518")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xE3F520", Offset = "0xE3F520", VA = "0xE3F520")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xE3F57C", Offset = "0xE3F57C", VA = "0xE3F57C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xE3F584", Offset = "0xE3F584", VA = "0xE3F584")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool Background
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xE3F5D8", Offset = "0xE3F5D8", VA = "0xE3F5D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xE3F5E0", Offset = "0xE3F5E0", VA = "0xE3F5E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color BackgroundColor
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xE3F698", Offset = "0xE3F698", VA = "0xE3F698")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xE3F6A4", Offset = "0xE3F6A4", VA = "0xE3F6A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int BackgroundPadding
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xE3F7B8", Offset = "0xE3F7B8", VA = "0xE3F7B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xE3F7C0", Offset = "0xE3F7C0", VA = "0xE3F7C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool Shadow
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xE3F880", Offset = "0xE3F880", VA = "0xE3F880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xE3F888", Offset = "0xE3F888", VA = "0xE3F888")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Color ShadowColor
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xE3F940", Offset = "0xE3F940", VA = "0xE3F940")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xE3F94C", Offset = "0xE3F94C", VA = "0xE3F94C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xE3FA60", Offset = "0xE3FA60", VA = "0xE3FA60")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xE3FA68", Offset = "0xE3FA68", VA = "0xE3FA68")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool Outline
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xE3FB44", Offset = "0xE3FB44", VA = "0xE3FB44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xE3FB4C", Offset = "0xE3FB4C", VA = "0xE3FB4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Color OutlineColor
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xE3FC04", Offset = "0xE3FC04", VA = "0xE3FC04")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xE3FC10", Offset = "0xE3FC10", VA = "0xE3FC10")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xE3FD24", Offset = "0xE3FD24", VA = "0xE3FD24")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xE3FD2C", Offset = "0xE3FD2C", VA = "0xE3FD2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool AutoScale
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xE3FE08", Offset = "0xE3FE08", VA = "0xE3FE08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xE3FE10", Offset = "0xE3FE10", VA = "0xE3FE10")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float ScaleFactor
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xE3FEBC", Offset = "0xE3FEBC", VA = "0xE3FEBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xE3FEC4", Offset = "0xE3FEC4", VA = "0xE3FEC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Font LabelsFont
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xE3FFD8", Offset = "0xE3FFD8", VA = "0xE3FFD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xE3FFE0", Offset = "0xE3FFE0", VA = "0xE3FFE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public int FontSize
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xE400F8", Offset = "0xE400F8", VA = "0xE400F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xE40100", Offset = "0xE40100", VA = "0xE40100")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float LineSpacing
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xE4022C", Offset = "0xE4022C", VA = "0xE4022C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xE40234", Offset = "0xE40234", VA = "0xE40234")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int CountersSpacing
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xE403AC", Offset = "0xE403AC", VA = "0xE403AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xE403B4", Offset = "0xE403B4", VA = "0xE403B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xE40450", Offset = "0xE40450", VA = "0xE40450")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xE40458", Offset = "0xE40458", VA = "0xE40458")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool PixelPerfect
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xE405B8", Offset = "0xE405B8", VA = "0xE405B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xE405C0", Offset = "0xE405C0", VA = "0xE405C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int SortingOrder
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xE4062C", Offset = "0xE4062C", VA = "0xE4062C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xE40634", Offset = "0xE40634", VA = "0xE40634")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE409E8", Offset = "0xE409E8", VA = "0xE409E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE40A30", Offset = "0xE40A30", VA = "0xE40A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE406E4", Offset = "0xE406E4", VA = "0xE406E4")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE40A88", Offset = "0xE40A88", VA = "0xE40A88")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE40D00", Offset = "0xE40D00", VA = "0xE40D00")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE40D08", Offset = "0xE40D08", VA = "0xE40D08")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE40D10", Offset = "0xE40D10", VA = "0xE40D10")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE40EC4", Offset = "0xE40EC4", VA = "0xE40EC4")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE40BE8", Offset = "0xE40BE8", VA = "0xE40BE8")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE40F7C", Offset = "0xE40F7C", VA = "0xE40F7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE41790", Offset = "0xE41790", VA = "0xE41790")]
		private void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE418A4", Offset = "0xE418A4", VA = "0xE418A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE41DC4", Offset = "0xE41DC4", VA = "0xE41DC4")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE41DC8", Offset = "0xE41DC8", VA = "0xE41DC8")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE3F0EC", Offset = "0xE3F0EC", VA = "0xE3F0EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE3F44C", Offset = "0xE3F44C", VA = "0xE3F44C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE42040", Offset = "0xE42040", VA = "0xE42040")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE42314", Offset = "0xE42314", VA = "0xE42314")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE3F160", Offset = "0xE3F160", VA = "0xE3F160")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE4110C", Offset = "0xE4110C", VA = "0xE4110C")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE414B0", Offset = "0xE414B0", VA = "0xE414B0")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE40DE0", Offset = "0xE40DE0", VA = "0xE40DE0")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE418E0", Offset = "0xE418E0", VA = "0xE418E0")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE419E0", Offset = "0xE419E0", VA = "0xE419E0")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE41DA0", Offset = "0xE41DA0", VA = "0xE41DA0")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE41E54", Offset = "0xE41E54", VA = "0xE41E54")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE41EE0", Offset = "0xE41EE0", VA = "0xE41EE0")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE3F574", Offset = "0xE3F574", VA = "0xE3F574")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE41FC0", Offset = "0xE41FC0", VA = "0xE41FC0")]
		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
	[Token(Token = "0x200005F")]
	public enum FPSLevel : byte
	{
		[Token(Token = "0x40000BB")]
		Normal,
		[Token(Token = "0x40000BC")]
		Warning,
		[Token(Token = "0x40000BD")]
		Critical
	}
	[Token(Token = "0x2000060")]
	public enum OperationMode : byte
	{
		[Token(Token = "0x40000BF")]
		Disabled,
		[Token(Token = "0x40000C0")]
		Background,
		[Token(Token = "0x40000C1")]
		Normal
	}
	[Token(Token = "0x2000061")]
	internal class UIUtils
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE428CC", Offset = "0xE428CC", VA = "0xE428CC")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE42BE0", Offset = "0xE42BE0", VA = "0xE42BE0")]
		public UIUtils()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class WaitForSecondsUnscaled : CustomYieldInstruction
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float waitTime;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float runUntil;

		[Token(Token = "0x1700001E")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xE42BE8", Offset = "0xE42BE8", VA = "0xE42BE8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE42C0C", Offset = "0xE42C0C", VA = "0xE42C0C")]
		public new void Reset()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE42C30", Offset = "0xE42C30", VA = "0xE42C30")]
		public WaitForSecondsUnscaled(float time)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x2000063")]
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool recording;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float renderTime;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE42C58", Offset = "0xE42C58", VA = "0xE42C58")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE42D0C", Offset = "0xE42D0C", VA = "0xE42D0C")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE42E50", Offset = "0xE42E50", VA = "0xE42E50")]
		public AFPSRenderRecorder()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	[Token(Token = "0x2000064")]
	internal class DrawableLabel
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal GameObject container;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal LabelAnchor anchor;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal StringBuilder newText;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool dirty;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject labelGameObject;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform labelTransform;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ContentSizeFitter labelFitter;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HorizontalLayoutGroup labelGroup;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject uiTextGameObject;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Text uiText;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Font font;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int fontSize;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lineSpacing;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 pixelOffset;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly LabelEffect background;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image backgroundImage;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly LabelEffect shadow;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Shadow shadowComponent;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly LabelEffect outline;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Outline outlineComponent;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE42AA8", Offset = "0xE42AA8", VA = "0xE42AA8")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE4235C", Offset = "0xE4235C", VA = "0xE4235C")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE3EFAC", Offset = "0xE3EFAC", VA = "0xE3EFAC")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE422F4", Offset = "0xE422F4", VA = "0xE422F4")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE400D4", Offset = "0xE400D4", VA = "0xE400D4")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE40198", Offset = "0xE40198", VA = "0xE40198")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE40518", Offset = "0xE40518", VA = "0xE40518")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE40318", Offset = "0xE40318", VA = "0xE40318")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE3F678", Offset = "0xE3F678", VA = "0xE3F678")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE3F798", Offset = "0xE3F798", VA = "0xE3F798")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE3F864", Offset = "0xE3F864", VA = "0xE3F864")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE3F920", Offset = "0xE3F920", VA = "0xE3F920")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE3FA40", Offset = "0xE3FA40", VA = "0xE3FA40")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE3FB28", Offset = "0xE3FB28", VA = "0xE3FB28")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE3FBE4", Offset = "0xE3FBE4", VA = "0xE3FBE4")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE3FD04", Offset = "0xE3FD04", VA = "0xE3FD04")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE3FDEC", Offset = "0xE3FDEC", VA = "0xE3FDEC")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE4330C", Offset = "0xE4330C", VA = "0xE4330C")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE42E58", Offset = "0xE42E58", VA = "0xE42E58")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE43830", Offset = "0xE43830", VA = "0xE43830")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE42EC0", Offset = "0xE42EC0", VA = "0xE42EC0")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE43064", Offset = "0xE43064", VA = "0xE43064")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE43208", Offset = "0xE43208", VA = "0xE43208")]
		private void ApplyFont()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public enum LabelAnchor : byte
	{
		[Token(Token = "0x40000DB")]
		UpperLeft,
		[Token(Token = "0x40000DC")]
		UpperRight,
		[Token(Token = "0x40000DD")]
		LowerLeft,
		[Token(Token = "0x40000DE")]
		LowerRight,
		[Token(Token = "0x40000DF")]
		UpperCenter,
		[Token(Token = "0x40000E0")]
		LowerCenter
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[Token(Token = "0x2000066")]
	[AddComponentMenu("")]
	public abstract class BaseCounterData
	{
		[Token(Token = "0x40000E1")]
		protected const string BOLD_START = "<b>";

		[Token(Token = "0x40000E2")]
		protected const string BOLD_END = "</b>";

		[Token(Token = "0x40000E3")]
		protected const string ITALIC_START = "<i>";

		[Token(Token = "0x40000E4")]
		protected const string ITALIC_END = "</i>";

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal StringBuilder text;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool dirty;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AFPSCounter main;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string colorCached;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool inited;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool enabled;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[SerializeField]
		[Tooltip("Current anchoring label for the counter output.\nRefreshes both previous and specified label when switching anchor.")]
		protected LabelAnchor anchor;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Regular color of the counter output.")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Controls text style.")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Additional text to append to the end of the counter in normal Operation Mode.")]
		protected string extraText;

		[Token(Token = "0x1700001F")]
		public bool Enabled
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xE43B00", Offset = "0xE43B00", VA = "0xE43B00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xE43B08", Offset = "0xE43B08", VA = "0xE43B08")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xE43B78", Offset = "0xE43B78", VA = "0xE43B78")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xE43B80", Offset = "0xE43B80", VA = "0xE43B80")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Color Color
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xE43BF0", Offset = "0xE43BF0", VA = "0xE43BF0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xE43BFC", Offset = "0xE43BFC", VA = "0xE43BFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public FontStyle Style
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xE43CFC", Offset = "0xE43CFC", VA = "0xE43CFC")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE43D04", Offset = "0xE43D04", VA = "0xE43D04")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public string ExtraText
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xE43D54", Offset = "0xE43D54", VA = "0xE43D54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xE43D5C", Offset = "0xE43D5C", VA = "0xE43D5C")]
			set
			{
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE43CB0", Offset = "0xE43CB0", VA = "0xE43CB0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE43DC0", Offset = "0xE43DC0", VA = "0xE43DC0", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x60001C4")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE43DD0", Offset = "0xE43DD0", VA = "0xE43DD0")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE42290", Offset = "0xE42290", VA = "0xE42290")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE43DD8", Offset = "0xE43DD8", VA = "0xE43DD8", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE43F04", Offset = "0xE43F04", VA = "0xE43F04", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE43F74", Offset = "0xE43F74", VA = "0xE43F74", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE43F78", Offset = "0xE43F78", VA = "0xE43F78", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE43F7C", Offset = "0xE43F7C", VA = "0xE43F7C", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60001CC")]
		protected abstract bool HasData();

		[Token(Token = "0x60001CD")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE43F80", Offset = "0xE43F80", VA = "0xE43F80")]
		protected void ApplyTextStyles()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE44140", Offset = "0xE44140", VA = "0xE44140")]
		protected BaseCounterData()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public abstract class UpdatebleCounterData : BaseCounterData
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Coroutine updateCoroutine;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected WaitForSecondsUnscaled cachedWaitForSecondsUnscaled;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Update interval in seconds.")]
		[SerializeField]
		[Range(0.1f, 10f)]
		protected float updateInterval;

		[Token(Token = "0x17000024")]
		public float UpdateInterval
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xE44150", Offset = "0xE44150", VA = "0xE44150")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xE44158", Offset = "0xE44158", VA = "0xE44158")]
			set
			{
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE44260", Offset = "0xE44260", VA = "0xE44260", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE442B4", Offset = "0xE442B4", VA = "0xE442B4", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE442B8", Offset = "0xE442B8", VA = "0xE442B8", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60001D5")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE44264", Offset = "0xE44264", VA = "0xE44264")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE442BC", Offset = "0xE442BC", VA = "0xE442BC")]
		private void StoptUpdateCoroutine()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE441F0", Offset = "0xE441F0", VA = "0xE441F0")]
		private void CacheWaitForSeconds()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE442E0", Offset = "0xE442E0", VA = "0xE442E0")]
		protected UpdatebleCounterData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	[AddComponentMenu("")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Shows operating system & platform info.")]
		[SerializeField]
		private bool platform;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[Tooltip("CPU model and cores (including virtual cores from Intel's Hyper Threading) count.")]
		[SerializeField]
		private bool cpuModel;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[SerializeField]
		[Tooltip("Shows GPU model name.")]
		private bool gpuModel;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[Tooltip("Shows graphics API version and type (if possible).")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Shows graphics supported shader model (if possible), approximate pixel fill-rate (if possible) and total Video RAM size (if possible).")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[Tooltip("Shows total RAM size.")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[Tooltip("Shows screen resolution, size and DPI (if possible).")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[SerializeField]
		[Tooltip("Shows device model. Actual for mobile devices.")]
		private bool deviceModel;

		[Token(Token = "0x17000025")]
		public bool Platform
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE442F8", Offset = "0xE442F8", VA = "0xE442F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE44300", Offset = "0xE44300", VA = "0xE44300")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool CpuModel
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE44350", Offset = "0xE44350", VA = "0xE44350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE44358", Offset = "0xE44358", VA = "0xE44358")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool GpuModel
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE443A8", Offset = "0xE443A8", VA = "0xE443A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xE443B0", Offset = "0xE443B0", VA = "0xE443B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool GpuApi
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xE44400", Offset = "0xE44400", VA = "0xE44400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE44408", Offset = "0xE44408", VA = "0xE44408")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool GpuSpec
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xE44458", Offset = "0xE44458", VA = "0xE44458")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xE44460", Offset = "0xE44460", VA = "0xE44460")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool RamSize
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xE444B0", Offset = "0xE444B0", VA = "0xE444B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xE444B8", Offset = "0xE444B8", VA = "0xE444B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool ScreenData
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xE44508", Offset = "0xE44508", VA = "0xE44508")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xE44510", Offset = "0xE44510", VA = "0xE44510")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool DeviceModel
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xE44560", Offset = "0xE44560", VA = "0xE44560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xE44568", Offset = "0xE44568", VA = "0xE44568")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public string LastValue
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xE445B8", Offset = "0xE445B8", VA = "0xE445B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xE445C0", Offset = "0xE445C0", VA = "0xE445C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE409A8", Offset = "0xE409A8", VA = "0xE409A8")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE445C8", Offset = "0xE445C8", VA = "0xE445C8", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE44E94", Offset = "0xE44E94", VA = "0xE44E94", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE44EC4", Offset = "0xE44EC4", VA = "0xE44EC4", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	[AddComponentMenu("")]
	public class FPSCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class <UpdateCounter>d__147 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FPSCounterData <>4__this;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <previousUpdateTime>5__2;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <previousUpdateFrames>5__3;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000237")]
				[Address(RVA = "0xE47984", Offset = "0xE47984", VA = "0xE47984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0xE479CC", Offset = "0xE479CC", VA = "0xE479CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0xE47868", Offset = "0xE47868", VA = "0xE47868")]
			[DebuggerHidden]
			public <UpdateCounter>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0xE47890", Offset = "0xE47890", VA = "0xE47890", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0xE47894", Offset = "0xE47894", VA = "0xE47894", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0xE4798C", Offset = "0xE4798C", VA = "0xE4798C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000FB")]
		private const string COLOR_TEXT_START = "<color=#{0}>";

		[Token(Token = "0x40000FC")]
		private const string COLOR_TEXT_END = "</color>";

		[Token(Token = "0x40000FD")]
		private const string FPS_TEXT_START = "<color=#{0}>FPS: ";

		[Token(Token = "0x40000FE")]
		private const string MS_TEXT_START = " <color=#{0}>[";

		[Token(Token = "0x40000FF")]
		private const string MS_TEXT_END = " MS]</color>";

		[Token(Token = "0x4000100")]
		private const string MIN_TEXT_START = "<color=#{0}>MIN: ";

		[Token(Token = "0x4000101")]
		private const string MAX_TEXT_START = "<color=#{0}>MAX: ";

		[Token(Token = "0x4000102")]
		private const string AVG_TEXT_START = "<color=#{0}>AVG: ";

		[Token(Token = "0x4000103")]
		private const string RENDER_TEXT_START = "<color=#{0}>REN: ";

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int warningLevelValue;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int criticalLevelValue;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Average FPS counter accumulative data will be reset on new scene load if enabled.")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[Tooltip("Minimum and maximum FPS readouts will be reset on new scene load if enabled")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Amount of update intervals to skip before recording minimum and maximum FPS.\nUse it to skip initialization performance spikes and drops.")]
		[Range(0f, 10f)]
		public int minMaxIntervalsToSkip;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal float newValue;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string colorCachedMs;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string colorCachedMin;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string colorCachedMax;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string colorCachedAvg;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string colorCachedRender;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string colorWarningCached;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string colorWarningCachedMs;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string colorWarningCachedMin;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string colorWarningCachedMax;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string colorWarningCachedAvg;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string colorCriticalCached;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string colorCriticalCachedMs;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string colorCriticalCachedMin;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string colorCriticalCachedMax;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string colorCriticalCachedAvg;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int currentAverageSamples;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float currentAverageRaw;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float[] accumulatedAverageSamples;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int minMaxIntervalsSkipped;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float renderTimeBank;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int previousFrameCount;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[Tooltip("Shows time in milliseconds spent to render 1 frame.")]
		private bool milliseconds;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[SerializeField]
		[Tooltip("Shows Average FPS calculated from specified Samples amount or since game / scene start, depending on Samples value and 'Reset On Load' toggle.")]
		private bool average;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		[Tooltip("Shows time in milliseconds for the average FPS.")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		[Tooltip("Controls placing Average on the new line.")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Range(0f, 100f)]
		[Tooltip("Amount of last samples to get average from. Set 0 to get average from all samples since startup or level load.\nOne Sample recorded per one Interval.")]
		private int averageSamples;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		[Tooltip("Shows minimum and maximum FPS readouts since game / scene start, depending on 'Reset On Load' toggle.")]
		private bool minMax;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		[Tooltip("Shows time in milliseconds for the Min Max FPS.")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		[Tooltip("Controls placing Min Max on the new line.")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		[Tooltip("Check to place Min Max on two separate lines. Otherwise they will be placed on a single line.")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Tooltip("Shows time spent on Camera.Render excluding Image Effects. Add AFPSRenderRecorder to the cameras you wish to count.")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[Tooltip("Controls placing Render on the new line.")]
		[SerializeField]
		private bool renderNewLine;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		[SerializeField]
		[Tooltip("Check to automatically add AFPSRenderRecorder to the Main Camera if present.")]
		private bool renderAutoAdd;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[SerializeField]
		[Tooltip("Color of the FPS counter while FPS is between Critical and Warning levels.")]
		private Color colorWarning;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[Tooltip("Color of the FPS counter while FPS is below Critical level.")]
		private Color colorCritical;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[Tooltip("Color of the Render Time output.")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x1700002E")]
		public bool Milliseconds
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xE4535C", Offset = "0xE4535C", VA = "0xE4535C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xE45364", Offset = "0xE45364", VA = "0xE45364")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool Average
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xE453C0", Offset = "0xE453C0", VA = "0xE453C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xE453C8", Offset = "0xE453C8", VA = "0xE453C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xE45474", Offset = "0xE45474", VA = "0xE45474")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xE4547C", Offset = "0xE4547C", VA = "0xE4547C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool AverageNewLine
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xE454D8", Offset = "0xE454D8", VA = "0xE454D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xE454E0", Offset = "0xE454E0", VA = "0xE454E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int AverageSamples
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xE45530", Offset = "0xE45530", VA = "0xE45530")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xE45538", Offset = "0xE45538", VA = "0xE45538")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool MinMax
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xE4562C", Offset = "0xE4562C", VA = "0xE4562C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xE45634", Offset = "0xE45634", VA = "0xE45634")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xE456E4", Offset = "0xE456E4", VA = "0xE456E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xE456EC", Offset = "0xE456EC", VA = "0xE456EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xE45760", Offset = "0xE45760", VA = "0xE45760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xE45768", Offset = "0xE45768", VA = "0xE45768")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xE457B8", Offset = "0xE457B8", VA = "0xE457B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xE457C0", Offset = "0xE457C0", VA = "0xE457C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool Render
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xE45810", Offset = "0xE45810", VA = "0xE45810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xE45818", Offset = "0xE45818", VA = "0xE45818")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool RenderNewLine
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xE45A74", Offset = "0xE45A74", VA = "0xE45A74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xE45A7C", Offset = "0xE45A7C", VA = "0xE45A7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xE45ACC", Offset = "0xE45ACC", VA = "0xE45ACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0xE45AD4", Offset = "0xE45AD4", VA = "0xE45AD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Color ColorWarning
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0xE45B28", Offset = "0xE45B28", VA = "0xE45B28")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0xE45B3C", Offset = "0xE45B3C", VA = "0xE45B3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Color ColorCritical
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xE45FFC", Offset = "0xE45FFC", VA = "0xE45FFC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xE46010", Offset = "0xE46010", VA = "0xE46010")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Color ColorRender
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xE464D0", Offset = "0xE464D0", VA = "0xE464D0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xE464E4", Offset = "0xE464E4", VA = "0xE464E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public int LastValue
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xE465A8", Offset = "0xE465A8", VA = "0xE465A8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xE465B0", Offset = "0xE465B0", VA = "0xE465B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xE465B8", Offset = "0xE465B8", VA = "0xE465B8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xE465C0", Offset = "0xE465C0", VA = "0xE465C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float LastRenderValue
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xE465C8", Offset = "0xE465C8", VA = "0xE465C8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xE465D0", Offset = "0xE465D0", VA = "0xE465D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public int LastAverageValue
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xE465D8", Offset = "0xE465D8", VA = "0xE465D8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xE465E0", Offset = "0xE465E0", VA = "0xE465E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xE465E8", Offset = "0xE465E8", VA = "0xE465E8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xE465F0", Offset = "0xE465F0", VA = "0xE465F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int LastMinimumValue
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xE465F8", Offset = "0xE465F8", VA = "0xE465F8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xE46600", Offset = "0xE46600", VA = "0xE46600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int LastMaximumValue
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xE46608", Offset = "0xE46608", VA = "0xE46608")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xE46610", Offset = "0xE46610", VA = "0xE46610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xE46618", Offset = "0xE46618", VA = "0xE46618")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xE46620", Offset = "0xE46620", VA = "0xE46620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xE46628", Offset = "0xE46628", VA = "0xE46628")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xE46630", Offset = "0xE46630", VA = "0xE46630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xE46638", Offset = "0xE46638", VA = "0xE46638")]
			[CompilerGenerated]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xE46640", Offset = "0xE46640", VA = "0xE46640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xE451FC", Offset = "0xE451FC", VA = "0xE451FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xE452AC", Offset = "0xE452AC", VA = "0xE452AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE408E8", Offset = "0xE408E8", VA = "0xE408E8")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE45428", Offset = "0xE45428", VA = "0xE45428")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE45698", Offset = "0xE45698", VA = "0xE45698")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE41DF8", Offset = "0xE41DF8", VA = "0xE41DF8")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE42E30", Offset = "0xE42E30", VA = "0xE42E30")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE46648", Offset = "0xE46648", VA = "0xE46648", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE46FF8", Offset = "0xE46FF8", VA = "0xE46FF8", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE470FC", Offset = "0xE470FC", VA = "0xE470FC", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE4712C", Offset = "0xE4712C", VA = "0xE4712C", Slot = "13")]
		[IteratorStateMachine(typeof(<UpdateCounter>d__147))]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE471A0", Offset = "0xE471A0", VA = "0xE471A0", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE471A8", Offset = "0xE471A8", VA = "0xE471A8", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE45BF8", Offset = "0xE45BF8", VA = "0xE45BF8")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE460CC", Offset = "0xE460CC", VA = "0xE460CC")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE46F7C", Offset = "0xE46F7C", VA = "0xE46F7C")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE4597C", Offset = "0xE4597C", VA = "0xE4597C")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE45894", Offset = "0xE45894", VA = "0xE45894")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	[AddComponentMenu("")]
	public class MemoryCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class <UpdateCounter>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MemoryCounterData <>4__this;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000252")]
				[Address(RVA = "0xE48A9C", Offset = "0xE48A9C", VA = "0xE48A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000254")]
				[Address(RVA = "0xE48AE4", Offset = "0xE48AE4", VA = "0xE48AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0xE486A4", Offset = "0xE486A4", VA = "0xE486A4")]
			[DebuggerHidden]
			public <UpdateCounter>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0xE48A10", Offset = "0xE48A10", VA = "0xE48A10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0xE48A14", Offset = "0xE48A14", VA = "0xE48A14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0xE48AA4", Offset = "0xE48AA4", VA = "0xE48AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400013E")]
		public const long MEMORY_DIVIDER = 1048576L;

		[Token(Token = "0x400013F")]
		private const string TEXT_START = "<color=#{0}>";

		[Token(Token = "0x4000140")]
		private const string LINE_START_TOTAL = "MEM TOTAL: ";

		[Token(Token = "0x4000141")]
		private const string LINE_START_ALLOCATED = "MEM ALLOC: ";

		[Token(Token = "0x4000142")]
		private const string LINE_START_MONO = "MEM MONO: ";

		[Token(Token = "0x4000143")]
		private const string LINE_END = " MB";

		[Token(Token = "0x4000144")]
		private const string TEXT_END = "</color>";

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Allows to output memory usage more precisely thus using a bit more system resources.")]
		[SerializeField]
		private bool precise;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[Tooltip("Allows to see private memory amount reserved for application. This memory can’t be used by other applications.")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		[Tooltip("Allows to see amount of memory, currently allocated by application.")]
		[SerializeField]
		private bool allocated;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		[SerializeField]
		[Tooltip("Allows to see amount of memory, allocated by managed Mono objects, such as UnityEngine.Object and everything derived from it for example.")]
		private bool monoUsage;

		[Token(Token = "0x17000049")]
		public bool Precise
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xE479D4", Offset = "0xE479D4", VA = "0xE479D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xE479DC", Offset = "0xE479DC", VA = "0xE479DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool Total
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xE47A30", Offset = "0xE47A30", VA = "0xE47A30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xE47A38", Offset = "0xE47A38", VA = "0xE47A38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool Allocated
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xE47A98", Offset = "0xE47A98", VA = "0xE47A98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xE47AA0", Offset = "0xE47AA0", VA = "0xE47AA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool MonoUsage
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xE47B00", Offset = "0xE47B00", VA = "0xE47B00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xE47B08", Offset = "0xE47B08", VA = "0xE47B08")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public long LastTotalValue
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xE47B68", Offset = "0xE47B68", VA = "0xE47B68")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0xE47B70", Offset = "0xE47B70", VA = "0xE47B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xE47B78", Offset = "0xE47B78", VA = "0xE47B78")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xE47B80", Offset = "0xE47B80", VA = "0xE47B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public long LastMonoValue
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xE47B88", Offset = "0xE47B88", VA = "0xE47B88")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xE47B90", Offset = "0xE47B90", VA = "0xE47B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE47B98", Offset = "0xE47B98", VA = "0xE47B98")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE47BD8", Offset = "0xE47BD8", VA = "0xE47BD8", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE48068", Offset = "0xE48068", VA = "0xE48068", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE485F0", Offset = "0xE485F0", VA = "0xE485F0", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE48630", Offset = "0xE48630", VA = "0xE48630", Slot = "13")]
		[IteratorStateMachine(typeof(<UpdateCounter>d__39))]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE486CC", Offset = "0xE486CC", VA = "0xE486CC", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE486F4", Offset = "0xE486F4", VA = "0xE486F4", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
