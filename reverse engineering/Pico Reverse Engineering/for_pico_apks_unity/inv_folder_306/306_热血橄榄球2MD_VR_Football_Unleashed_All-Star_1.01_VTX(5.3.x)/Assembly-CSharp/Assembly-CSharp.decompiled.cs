using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Serialization;
using Il2CppDummyDll;
using Pico.Platform;
using Pico.Platform.Models;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityStandardAssets.ImageEffects;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class MobilePostProcessing : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public bool Blur;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E04CC", Offset = "0x3E04CC")]
	public float BlurAmount;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D BlurMask;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public bool Bloom;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x2C")]
	public Color BloomColor;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E04E4", Offset = "0x3E04E4")]
	public float BloomAmount;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E04FC", Offset = "0x3E04FC")]
	public float BloomDiffuse;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0514", Offset = "0x3E0514")]
	public float BloomThreshold;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E052C", Offset = "0x3E052C")]
	public float BloomSoftness;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x4C")]
	public bool LUT;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0544", Offset = "0x3E0544")]
	public float LutAmount;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x58")]
	public Texture2D SourceLut;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x60")]
	public bool ImageFiltering;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x64")]
	public Color Color;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E055C", Offset = "0x3E055C")]
	public float Contrast;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0574", Offset = "0x3E0574")]
	public float Brightness;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E058C", Offset = "0x3E058C")]
	public float Saturation;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E05A4", Offset = "0x3E05A4")]
	public float Exposure;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E05BC", Offset = "0x3E05BC")]
	public float Gamma;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E05D4", Offset = "0x3E05D4")]
	public float Sharpness;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x8C")]
	public bool ChromaticAberration;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x90")]
	public float Offset;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E05EC", Offset = "0x3E05EC")]
	public float FishEyeDistortion;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0604", Offset = "0x3E0604")]
	public float GlitchAmount;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x9C")]
	public bool Distortion;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E061C", Offset = "0x3E061C")]
	public float LensDistortion;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0xA4")]
	public bool Vignette;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0xA8")]
	public Color VignetteColor;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0634", Offset = "0x3E0634")]
	public float VignetteAmount;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E064C", Offset = "0x3E064C")]
	public float VignetteSoftness;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int blurTexString;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int maskTextureString;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int blurAmountString;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int bloomColorString;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int blDiffuseString;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int blDataString;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int lutTextureString;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int lutAmountString;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int colorString;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int contrastString;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int brightnessString;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int saturationString;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int centralFactorString;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int sideFactorString;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int offsetString;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int fishEyeString;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int lensdistortionString;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int vignetteColorString;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int vignetteAmountString;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int vignetteSoftnessString;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x50")]
	private static readonly string bloomKeyword;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x58")]
	private static readonly string blurKeyword;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x60")]
	private static readonly string chromaKeyword;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x68")]
	private static readonly string lutKeyword;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x70")]
	private static readonly string filterKeyword;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x78")]
	private static readonly string shaprenKeyword;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x80")]
	private static readonly string distortionKeyword;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0xC0")]
	public Material material;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0xC8")]
	private Texture2D previous;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xD0")]
	private Texture3D converted3D;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0xD8")]
	private float t;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0xDC")]
	private float a;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0xE0")]
	private float knee;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0xE4")]
	private int numberOfPasses;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xEC0220", Offset = "0xEC0220", VA = "0xEC0220")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xEC030C", Offset = "0xEC030C", VA = "0xEC030C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xEC0590", Offset = "0xEC0590", VA = "0xEC0590")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xEC03A8", Offset = "0xEC03A8", VA = "0xEC03A8")]
	private void Convert3D(Texture2D temp3DTex)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xEC0638", Offset = "0xEC0638", VA = "0xEC0638")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xEC15B0", Offset = "0xEC15B0", VA = "0xEC15B0")]
	public MobilePostProcessing()
	{
	}
}
[Token(Token = "0x2000003")]
public class LocalizationSwap : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite english;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite german;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite chinese;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite japanese;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite korean;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x40")]
	private GameLanguage currentGameLanguage;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x48")]
	private SpriteRenderer sRend;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xEBF030", Offset = "0xEBF030", VA = "0xEBF030")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xEBF2F8", Offset = "0xEBF2F8", VA = "0xEBF2F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xEBF158", Offset = "0xEBF158", VA = "0xEBF158")]
	private void SwapSprite()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xEBF250", Offset = "0xEBF250", VA = "0xEBF250")]
	private static bool CheckSprite(Sprite sprite)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xEBF38C", Offset = "0xEBF38C", VA = "0xEBF38C")]
	public LocalizationSwap()
	{
	}
}
[Token(Token = "0x2000004")]
public class AIPasser : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody projectile1;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x20")]
	public GameObject player;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x28")]
	public Transform launcher;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E06B8", Offset = "0x3E06B8")]
	[SerializeField]
	private float angle;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xBFC5D0", Offset = "0xBFC5D0", VA = "0xBFC5D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xBFC7D4", Offset = "0xBFC7D4", VA = "0xBFC7D4")]
	private void FireCannonAtPoint(Vector3 point)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xBFCA64", Offset = "0xBFCA64", VA = "0xBFCA64")]
	private Vector3 BallisticVelocity(Vector3 destination, float angle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xBFCB74", Offset = "0xBFCB74", VA = "0xBFCB74")]
	public AIPasser()
	{
	}
}
[Token(Token = "0x2000005")]
public class AchievementManager : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x0")]
	private static string[] MVPAchievements;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xBFCB84", Offset = "0xBFCB84", VA = "0xBFCB84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xBFCB88", Offset = "0xBFCB88", VA = "0xBFCB88")]
	private void GetCompletedAchievements()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xBFCB8C", Offset = "0xBFCB8C", VA = "0xBFCB8C")]
	public static void IncrementAchievement(string achievement)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xBFCB90", Offset = "0xBFCB90", VA = "0xBFCB90")]
	public static bool IsUnlocked(string achievement)
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xBFCC24", Offset = "0xBFCC24", VA = "0xBFCC24")]
	public static void Unlock(string achievement, bool practiceOverride = false)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xBFCD78", Offset = "0xBFCD78", VA = "0xBFCD78")]
	public static void CheckMVP()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xBFCEA0", Offset = "0xBFCEA0", VA = "0xBFCEA0")]
	public AchievementManager()
	{
	}
}
[Token(Token = "0x2000006")]
public class ActivateBonusRings : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x18")]
	private bool ringsActivated;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xBFD500", Offset = "0xBFD500", VA = "0xBFD500")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xBFD5F4", Offset = "0xBFD5F4", VA = "0xBFD5F4")]
	public ActivateBonusRings()
	{
	}
}
[Token(Token = "0x2000007")]
public class ActivateByRound : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] objectsByRound;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xBFD5FC", Offset = "0xBFD5FC", VA = "0xBFD5FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xBFD6C8", Offset = "0xBFD6C8", VA = "0xBFD6C8")]
	public ActivateByRound()
	{
	}
}
[Token(Token = "0x2000008")]
public class ActivateOnSnap : MonoBehaviour
{
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PlayAction;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xBFD6D0", Offset = "0xBFD6D0", VA = "0xBFD6D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xBFD7C0", Offset = "0xBFD7C0", VA = "0xBFD7C0")]
	public void Reset()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xBFD7E0", Offset = "0xBFD7E0", VA = "0xBFD7E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xBFD870", Offset = "0xBFD870", VA = "0xBFD870")]
	public ActivateOnSnap()
	{
	}
}
[Token(Token = "0x2000009")]
public class ActivateOnTouchdown : FootballBehaviour
{
	[Token(Token = "0x6000021")]
	[Address(RVA = "0xBFD878", Offset = "0xBFD878", VA = "0xBFD878", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xBFDB28", Offset = "0xBFDB28", VA = "0xBFDB28")]
	public ActivateOnTouchdown()
	{
	}
}
[Token(Token = "0x200000A")]
public class AnimateOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x18")]
	public string triggerName;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x20")]
	public string[] tags;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xBFDB30", Offset = "0xBFDB30", VA = "0xBFDB30")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xBFDC38", Offset = "0xBFDC38", VA = "0xBFDC38")]
	public AnimateOnCollision()
	{
	}
}
[Token(Token = "0x200000B")]
public class AnimateOnLookAt : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x20")]
	public Transform head;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x28")]
	public float lookThresholdDegrees;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xBFDD18", Offset = "0xBFDD18", VA = "0xBFDD18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xBFDE30", Offset = "0xBFDE30", VA = "0xBFDE30")]
	public AnimateOnLookAt()
	{
	}
}
[Token(Token = "0x200000C")]
public class AnimationEvent : MonoBehaviour
{
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent animationEvents;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xBFDE40", Offset = "0xBFDE40", VA = "0xBFDE40")]
	public void RunAnimationEvents()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xBFDE54", Offset = "0xBFDE54", VA = "0xBFDE54")]
	public AnimationEvent()
	{
	}
}
[Token(Token = "0x200000D")]
public class AnimationRandomFrame : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x18")]
	public string animationName;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xBFDE5C", Offset = "0xBFDE5C", VA = "0xBFDE5C")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xBFDEDC", Offset = "0xBFDEDC", VA = "0xBFDEDC")]
	public AnimationRandomFrame()
	{
	}
}
[Token(Token = "0x200000E")]
public class AnimationRandomFrameTime : MonoBehaviour
{
	[Token(Token = "0x600002B")]
	[Address(RVA = "0xBFDF30", Offset = "0xBFDF30", VA = "0xBFDF30")]
	private void Start()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xBFDFF8", Offset = "0xBFDFF8", VA = "0xBFDFF8")]
	public AnimationRandomFrameTime()
	{
	}
}
[Token(Token = "0x200000F")]
public class AnimationRandomStart : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x18")]
	private int counter;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xBFE000", Offset = "0xBFE000", VA = "0xBFE000")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xBFE030", Offset = "0xBFE030", VA = "0xBFE030")]
	private void Update()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xBFE0FC", Offset = "0xBFE0FC", VA = "0xBFE0FC")]
	public AnimationRandomStart()
	{
	}
}
[Token(Token = "0x2000010")]
public class AnimatorScore : MonoBehaviour
{
	[Token(Token = "0x6000030")]
	[Address(RVA = "0xBFE104", Offset = "0xBFE104", VA = "0xBFE104")]
	private void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xBFE1FC", Offset = "0xBFE1FC", VA = "0xBFE1FC")]
	public AnimatorScore()
	{
	}
}
[Token(Token = "0x2000011")]
public class Announcer : FootballBehaviour
{
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] gameStartClips;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] touchdownClips;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] bigTouchdownClips;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip[] safetyClips;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip[] interceptionClips;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip[] turnOverClips;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip[] fourthDownClips;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip[] fourthAndGoalClips;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip[] sackClips;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip[] incompleteClips;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip[] hotStreakClips;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip[] firstDownClips;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip[] firstAndGoalClips;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip[] completionClips;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x88")]
	public AudioClip[] bigCompletionClips;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x90")]
	public AudioClip[] lostYardsClips;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x98")]
	public AudioClip[] redzoneClips;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0xA0")]
	public AudioClip[] winClips;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0xA8")]
	public AudioClip[] lossClips;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0xB0")]
	public AudioClip[] awardClips;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0xB8")]
	public AudioClip[] yasQueenClips;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0xC0")]
	public AudioClip[] reganomicsClips;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0xC8")]
	public AudioClip[] fieldGoalClips;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xBFE204", Offset = "0xBFE204", VA = "0xBFE204")]
	private void PlayClip(AudioClip[] clips, int max = -1)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xBFE2FC", Offset = "0xBFE2FC", VA = "0xBFE2FC", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xBFE440", Offset = "0xBFE440", VA = "0xBFE440", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xBFE5F4", Offset = "0xBFE5F4", VA = "0xBFE5F4", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xBFE600", Offset = "0xBFE600", VA = "0xBFE600", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xBFE60C", Offset = "0xBFE60C", VA = "0xBFE60C", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xBFE618", Offset = "0xBFE618", VA = "0xBFE618", Slot = "11")]
	protected override void OnFourthDown()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xBFE6A4", Offset = "0xBFE6A4", VA = "0xBFE6A4", Slot = "12")]
	protected override void OnSack()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xBFE6B0", Offset = "0xBFE6B0", VA = "0xBFE6B0", Slot = "13")]
	protected override void OnIncomplete()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xBFE6BC", Offset = "0xBFE6BC", VA = "0xBFE6BC", Slot = "14")]
	protected override void OnHotStreak()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xBFE6C8", Offset = "0xBFE6C8", VA = "0xBFE6C8", Slot = "15")]
	protected override void OnFirstDown()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xBFE854", Offset = "0xBFE854", VA = "0xBFE854", Slot = "16")]
	protected override void OnCompletion()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xBFE9EC", Offset = "0xBFE9EC", VA = "0xBFE9EC", Slot = "17")]
	protected override void OnLoss()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xBFE9F8", Offset = "0xBFE9F8", VA = "0xBFE9F8", Slot = "19")]
	protected override void OnFieldGoal()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xBFEA04", Offset = "0xBFEA04", VA = "0xBFEA04")]
	public Announcer()
	{
	}
}
[Token(Token = "0x2000012")]
public class ArcadeToggle : MonoBehaviour
{
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x0")]
	public static bool isArcade;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xBFF10C", Offset = "0xBFF10C", VA = "0xBFF10C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xBFF2A0", Offset = "0xBFF2A0", VA = "0xBFF2A0")]
	public ArcadeToggle()
	{
	}
}
[Token(Token = "0x2000013")]
public class AwardOverlay : MonoBehaviour
{
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x18")]
	public Image background;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x28")]
	private string[] vt;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xBFF460", Offset = "0xBFF460", VA = "0xBFF460")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xBFF584", Offset = "0xBFF584", VA = "0xBFF584")]
	public AwardOverlay()
	{
	}
}
[Token(Token = "0x2000014")]
public class AwardToggle : MonoBehaviour
{
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xBFF808", Offset = "0xBFF808", VA = "0xBFF808")]
	private void Start()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xBFF8FC", Offset = "0xBFF8FC", VA = "0xBFF8FC")]
	public AwardToggle()
	{
	}
}
[Token(Token = "0x2000015")]
public class BallLauncher : MonoBehaviour
{
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody projectile1;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody projectile2;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x28")]
	public Transform launcher;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x30")]
	public float launchforce;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x38")]
	public Animator anim;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xBFF90C", Offset = "0xBFF90C", VA = "0xBFF90C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xBFFBFC", Offset = "0xBFFBFC", VA = "0xBFFBFC")]
	public BallLauncher()
	{
	}
}
[Token(Token = "0x2000016")]
public class Bebop : MonoBehaviour
{
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x18")]
	public Transform swapTransform;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xBFFC10", Offset = "0xBFFC10", VA = "0xBFFC10")]
	private void Start()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xBFFD64", Offset = "0xBFFD64", VA = "0xBFFD64")]
	public Bebop()
	{
	}
}
[Token(Token = "0x2000017")]
public class BebopHeadBob : MonoBehaviour
{
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x18")]
	public Animator bebopAnimator;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xBFFD6C", Offset = "0xBFFD6C", VA = "0xBFFD6C")]
	private void Update()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xBFFE14", Offset = "0xBFFE14", VA = "0xBFFE14")]
	public BebopHeadBob()
	{
	}
}
[Token(Token = "0x2000018")]
public class Blimp : MonoBehaviour
{
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x18")]
	public float period;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x1C")]
	private float startY;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xBFFE1C", Offset = "0xBFFE1C", VA = "0xBFFE1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xBFFE74", Offset = "0xBFFE74", VA = "0xBFFE74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xBFFEDC", Offset = "0xBFFEDC", VA = "0xBFFEDC")]
	public Blimp()
	{
	}
}
[Token(Token = "0x2000019")]
public class BonusPlayer : MonoBehaviour
{
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x18")]
	public float xRange;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x1C")]
	public float runForce;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x20")]
	public float maxSpeed;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x28")]
	public Transform plusSevenPrefab;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E06FC", Offset = "0x3E06FC")]
	private bool <caught>k__BackingField;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x31")]
	private bool markedForDestruction;

	[Token(Token = "0x17000001")]
	public bool caught
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0xC00FA4", Offset = "0xC00FA4", VA = "0xC00FA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E151C", Offset = "0x3E151C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xC00FAC", Offset = "0xC00FAC", VA = "0xC00FAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E152C", Offset = "0x3E152C")]
		set
		{
		}
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xC00FB8", Offset = "0xC00FB8", VA = "0xC00FB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xC01180", Offset = "0xC01180", VA = "0xC01180")]
	private void Update()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xC014B4", Offset = "0xC014B4", VA = "0xC014B4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xC01718", Offset = "0xC01718", VA = "0xC01718")]
	public BonusPlayer()
	{
	}
}
[Token(Token = "0x200001A")]
public class BonusPointPopup : MonoBehaviour
{
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x18")]
	public Transform popupPrefab;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x0")]
	private static int points;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xC01734", Offset = "0xC01734", VA = "0xC01734")]
	private void Update()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xC01908", Offset = "0xC01908", VA = "0xC01908")]
	public static void Popup(int value)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xC01970", Offset = "0xC01970", VA = "0xC01970")]
	public BonusPointPopup()
	{
	}
}
[Token(Token = "0x200001B")]
public class BonusRing : MonoBehaviour
{
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x18")]
	public Transform reciever;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x20")]
	public Transform plusOnePrefab;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x28")]
	public Transform plusTwoPrefab;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x30")]
	public Material[] materials;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x38")]
	public float xOffset;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x3C")]
	public float yOffset;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x40")]
	public float zOffset;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x44")]
	public float xRange;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x48")]
	public float yRange;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x4C")]
	public float zRange;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x50")]
	public float resetTime;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x54")]
	private float resetTimer;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x58")]
	private int prevStreak;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x60")]
	private MeshRenderer ringMesh;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xC0197C", Offset = "0xC0197C", VA = "0xC0197C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xC01B3C", Offset = "0xC01B3C", VA = "0xC01B3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xC019D8", Offset = "0xC019D8", VA = "0xC019D8")]
	private void NewPosition()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xC01DA0", Offset = "0xC01DA0", VA = "0xC01DA0")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xC02250", Offset = "0xC02250", VA = "0xC02250")]
	public BonusRing()
	{
	}
}
[Token(Token = "0x200001C")]
public class BonusRingGold : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	private delegate void TDEvent();

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x18")]
	public Transform reciever;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x20")]
	public Transform plusFivePrefab;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x28")]
	public GameObject gold;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x0")]
	private static TDEvent OnBonusTD;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x30")]
	private float xPos;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x34")]
	private float speed;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x38")]
	private float dir;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x3C")]
	private float yOffset;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x40")]
	private float yRange;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x44")]
	private float zOffset;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x48")]
	private float zRange;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x4C")]
	private float resetTime;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x50")]
	private float resetTimer;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xC02270", Offset = "0xC02270", VA = "0xC02270")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xC02360", Offset = "0xC02360", VA = "0xC02360")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xC01410", Offset = "0xC01410", VA = "0xC01410")]
	public static void TriggerTD()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xC02450", Offset = "0xC02450", VA = "0xC02450")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xC02680", Offset = "0xC02680", VA = "0xC02680")]
	private void NewPosition()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xC0282C", Offset = "0xC0282C", VA = "0xC0282C")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xC02B7C", Offset = "0xC02B7C", VA = "0xC02B7C")]
	public BonusRingGold()
	{
	}
}
[Token(Token = "0x200001E")]
public class BonusRoundStart : MonoBehaviour
{
	[Token(Token = "0x600006C")]
	[Address(RVA = "0xC02B9C", Offset = "0xC02B9C", VA = "0xC02B9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xC02C00", Offset = "0xC02C00", VA = "0xC02C00")]
	public BonusRoundStart()
	{
	}
}
[Token(Token = "0x200001F")]
public class BonusTeamSelect : MonoBehaviour
{
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x18")]
	public bool offense;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] teams;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xC02C08", Offset = "0xC02C08", VA = "0xC02C08")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xC02E30", Offset = "0xC02E30", VA = "0xC02E30")]
	public BonusTeamSelect()
	{
	}
}
[Token(Token = "0x2000020")]
public class BonusTimeToggle : MonoBehaviour
{
	[Token(Token = "0x6000070")]
	[Address(RVA = "0xC02E40", Offset = "0xC02E40", VA = "0xC02E40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xC02ED8", Offset = "0xC02ED8", VA = "0xC02ED8")]
	public BonusTimeToggle()
	{
	}
}
[Token(Token = "0x2000021")]
public class Boombox : Clickable
{
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x50")]
	public GameObject[] indicators;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x58")]
	private int currentIndicator;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xC02EE0", Offset = "0xC02EE0", VA = "0xC02EE0", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xC02F3C", Offset = "0xC02F3C", VA = "0xC02F3C")]
	private void ToggleIndicator(int index, bool state)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xC02FA4", Offset = "0xC02FA4", VA = "0xC02FA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xC03044", Offset = "0xC03044", VA = "0xC03044")]
	public Boombox()
	{
	}
}
[Token(Token = "0x2000022")]
public class CameraFacingBillboard : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x18")]
	public Camera m_Camera;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xC0305C", Offset = "0xC0305C", VA = "0xC0305C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xC031C0", Offset = "0xC031C0", VA = "0xC031C0")]
	public CameraFacingBillboard()
	{
	}
}
[Token(Token = "0x2000023")]
public class CameraIcon : MonoBehaviour
{
	[Token(Token = "0x6000078")]
	[Address(RVA = "0xC031C8", Offset = "0xC031C8", VA = "0xC031C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xC03270", Offset = "0xC03270", VA = "0xC03270")]
	public CameraIcon()
	{
	}
}
[Token(Token = "0x2000024")]
public class Cheerleader : FootballBehaviour
{
	[Token(Token = "0x600007A")]
	[Address(RVA = "0xC05240", Offset = "0xC05240", VA = "0xC05240", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xC052B4", Offset = "0xC052B4", VA = "0xC052B4", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xC05328", Offset = "0xC05328", VA = "0xC05328", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xC0539C", Offset = "0xC0539C", VA = "0xC0539C", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xC05410", Offset = "0xC05410", VA = "0xC05410", Slot = "12")]
	protected override void OnSack()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xC05484", Offset = "0xC05484", VA = "0xC05484", Slot = "13")]
	protected override void OnIncomplete()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xC054F8", Offset = "0xC054F8", VA = "0xC054F8", Slot = "14")]
	protected override void OnHotStreak()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xC0556C", Offset = "0xC0556C", VA = "0xC0556C", Slot = "15")]
	protected override void OnFirstDown()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xC055E0", Offset = "0xC055E0", VA = "0xC055E0", Slot = "16")]
	protected override void OnCompletion()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xC05654", Offset = "0xC05654", VA = "0xC05654", Slot = "17")]
	protected override void OnLoss()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xC056C8", Offset = "0xC056C8", VA = "0xC056C8")]
	public Cheerleader()
	{
	}
}
[Token(Token = "0x2000025")]
public class Clickable : Interactable
{
	[Token(Token = "0x6000085")]
	[Address(RVA = "0xC056D0", Offset = "0xC056D0", VA = "0xC056D0", Slot = "8")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xC056D4", Offset = "0xC056D4", VA = "0xC056D4", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xC0570C", Offset = "0xC0570C", VA = "0xC0570C", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xC03054", Offset = "0xC03054", VA = "0xC03054")]
	public Clickable()
	{
	}
}
[Token(Token = "0x2000026")]
public class Coach : FootballBehaviour
{
	[Token(Token = "0x6000089")]
	[Address(RVA = "0xC05710", Offset = "0xC05710", VA = "0xC05710", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xC05784", Offset = "0xC05784", VA = "0xC05784", Slot = "14")]
	protected override void OnHotStreak()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xC057F8", Offset = "0xC057F8", VA = "0xC057F8", Slot = "15")]
	protected override void OnFirstDown()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xC0586C", Offset = "0xC0586C", VA = "0xC0586C", Slot = "16")]
	protected override void OnCompletion()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xC058E0", Offset = "0xC058E0", VA = "0xC058E0")]
	public Coach()
	{
	}
}
[Token(Token = "0x2000027")]
public class CoachHit : MonoBehaviour
{
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x18")]
	public AudioSource mustacheSource;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] grunts;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x28")]
	private int clip;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xC058E8", Offset = "0xC058E8", VA = "0xC058E8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xC05A18", Offset = "0xC05A18", VA = "0xC05A18")]
	public CoachHit()
	{
	}
}
[Token(Token = "0x2000028")]
public enum ColorType
{
	[Token(Token = "0x40000AA")]
	Red,
	[Token(Token = "0x40000AB")]
	Green,
	[Token(Token = "0x40000AC")]
	Blue
}
[Token(Token = "0x2000029")]
public class ColorSlider : Interactable
{
	[Token(Token = "0x200002A")]
	public delegate void ColorChangeDelegate();

	[Token(Token = "0x40000AD")]
	private const float COLOR_CHANGE_THRESHOLD = 0.1f;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x50")]
	public bool primary;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x54")]
	public ColorType type;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x0")]
	public static ColorChangeDelegate OnColorChange;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 startPos;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x8")]
	private static float lastColorChange;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xC0753C", Offset = "0xC0753C", VA = "0xC0753C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xC07640", Offset = "0xC07640", VA = "0xC07640")]
	private void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xC0786C", Offset = "0xC0786C", VA = "0xC0786C", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xC07870", Offset = "0xC07870", VA = "0xC07870", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xC07618", Offset = "0xC07618", VA = "0xC07618")]
	private float XFromColor(Color color)
	{
		return default(float);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xC07810", Offset = "0xC07810", VA = "0xC07810")]
	private Color NewColor(Color currentColor, float value)
	{
		return default(Color);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xC0790C", Offset = "0xC0790C", VA = "0xC0790C")]
	public ColorSlider()
	{
	}
}
[Token(Token = "0x200002B")]
public class Player
{
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x18")]
	public int number;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD3ABB8", Offset = "0xD3ABB8", VA = "0xD3ABB8")]
	public Player(string name, int number)
	{
	}
}
[Token(Token = "0x200002C")]
public class Team
{
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x18")]
	public int logo;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x2C")]
	public Color color2;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x40")]
	public Player[] roster;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x48")]
	public bool reverseLogo;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xB2F3F0", Offset = "0xB2F3F0", VA = "0xB2F3F0")]
	public Team(string name, bool reverseLogo, int logo, Color color, Color color2, Player[] roster)
	{
	}
}
[Token(Token = "0x200002D")]
public static class Conference
{
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x0")]
	public static int round;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x8")]
	public static Team[] teams;

	[Token(Token = "0x17000002")]
	public static int oppIndex
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xC02D3C", Offset = "0xC02D3C", VA = "0xC02D3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000003")]
	public static bool homeGame
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xC07B00", Offset = "0xC07B00", VA = "0xC07B00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000004")]
	public static string fieldName
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xC07BB0", Offset = "0xC07BB0", VA = "0xC07BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public static Team opponent
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xC07A70", Offset = "0xC07A70", VA = "0xC07A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xC07948", Offset = "0xC07948", VA = "0xC07948")]
	public static Player GetPlayer(bool offense, int index)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
public class CrowdAnimation : FootballBehaviour
{
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x18")]
	public bool yourTeam;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x19")]
	public bool useHomeTeam;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x20")]
	private Animator anim;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xC0B890", Offset = "0xC0B890", VA = "0xC0B890", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xC0B924", Offset = "0xC0B924", VA = "0xC0B924")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xC0BA0C", Offset = "0xC0BA0C", VA = "0xC0BA0C", Slot = "18")]
	protected override void OnCatch()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xC0BA7C", Offset = "0xC0BA7C", VA = "0xC0BA7C", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xC0BAEC", Offset = "0xC0BAEC", VA = "0xC0BAEC", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xC0BB5C", Offset = "0xC0BB5C", VA = "0xC0BB5C", Slot = "13")]
	protected override void OnIncomplete()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xC0BBCC", Offset = "0xC0BBCC", VA = "0xC0BBCC")]
	public CrowdAnimation()
	{
	}
}
[Token(Token = "0x200002F")]
public class CrowdCombiner : MonoBehaviour
{
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF150", Offset = "0x3DF150")]
	private sealed class <MergeMeshes>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x20")]
		public CrowdCombiner <>4__this;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Material, List<CombineInstance>> <combines>5__2;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x30")]
		private IEnumerator <>7__wrap2;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Material, List<CombineInstance>>.KeyCollection.Enumerator <>7__wrap3;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xB358A0", Offset = "0xB358A0", VA = "0xB358A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xB358E8", Offset = "0xB358E8", VA = "0xB358E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xB34CD4", Offset = "0xB34CD4", VA = "0xB34CD4")]
		[DebuggerHidden]
		public <MergeMeshes>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB34D00", Offset = "0xB34D00", VA = "0xB34D00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB34EB8", Offset = "0xB34EB8", VA = "0xB34EB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB34D9C", Offset = "0xB34D9C", VA = "0xB34D9C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB34E64", Offset = "0xB34E64", VA = "0xB34E64")]
		private void <>m__Finally2()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB358A8", Offset = "0xB358A8", VA = "0xB358A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C0")]
	private const int COLLECTIONS_PER_FRAME = 200;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x0")]
	public static int MergedCrowds;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x18")]
	private int collectionsThisFrame;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine mergeRoutine;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x28")]
	private bool doneMerging;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> burnAfterMerging;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xC0BBDC", Offset = "0xC0BBDC", VA = "0xC0BBDC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xC0BC40", Offset = "0xC0BC40", VA = "0xC0BC40")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xC0BDD4", Offset = "0xC0BDD4", VA = "0xC0BDD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E153C", Offset = "0x3E153C")]
	private IEnumerator MergeMeshes()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xC0BE40", Offset = "0xC0BE40", VA = "0xC0BE40")]
	public CrowdCombiner()
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
public class CrowdFlip : MonoBehaviour
{
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x18")]
	public bool flip;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x19")]
	private bool doneDidIt;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xC0BEBC", Offset = "0xC0BEBC", VA = "0xC0BEBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xC0BEE8", Offset = "0xC0BEE8", VA = "0xC0BEE8")]
	private void Flip()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xC0C004", Offset = "0xC0C004", VA = "0xC0C004")]
	public CrowdFlip()
	{
	}
}
[Token(Token = "0x2000032")]
public class CrowdNoise : FootballBehaviour
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF170", Offset = "0x3DF170")]
	private sealed class <PlayBells>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x20")]
		public CrowdNoise <>4__this;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xB35AAC", Offset = "0xB35AAC", VA = "0xB35AAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xB35AF4", Offset = "0xB35AF4", VA = "0xB35AF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xB358F0", Offset = "0xB358F0", VA = "0xB358F0")]
		[DebuggerHidden]
		public <PlayBells>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xB3591C", Offset = "0xB3591C", VA = "0xB3591C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xB35920", Offset = "0xB35920", VA = "0xB35920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB35AB4", Offset = "0xB35AB4", VA = "0xB35AB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x18")]
	private bool cheering;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x19")]
	private bool booing;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource bell1;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource bell2;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource bell3;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource uproar;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource boo;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x48")]
	public AudioSource whistle;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xC0C00C", Offset = "0xC0C00C", VA = "0xC0C00C", Slot = "5")]
	protected override void OnPlayStart()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xC0C104", Offset = "0xC0C104", VA = "0xC0C104", Slot = "6")]
	protected override void OnPlayStop()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xC0C120", Offset = "0xC0C120", VA = "0xC0C120")]
	private void Boo()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xC0C17C", Offset = "0xC0C17C", VA = "0xC0C17C")]
	private void Uproar()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xC0C1C4", Offset = "0xC0C1C4", VA = "0xC0C1C4", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xC0C1C8", Offset = "0xC0C1C8", VA = "0xC0C1C8", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xC0C1CC", Offset = "0xC0C1CC", VA = "0xC0C1CC", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xC0C1D0", Offset = "0xC0C1D0", VA = "0xC0C1D0", Slot = "18")]
	protected override void OnCatch()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xC0C1D4", Offset = "0xC0C1D4", VA = "0xC0C1D4", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xC0C1D8", Offset = "0xC0C1D8", VA = "0xC0C1D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xC0C098", Offset = "0xC0C098", VA = "0xC0C098")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E15EC", Offset = "0x3E15EC")]
	private IEnumerator PlayBells()
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xC0C29C", Offset = "0xC0C29C", VA = "0xC0C29C")]
	public CrowdNoise()
	{
	}
}
[Token(Token = "0x2000034")]
[ExecuteInEditMode]
public class CrowdPlacementHelper : MonoBehaviour
{
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 prevPosition;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xC0C2A4", Offset = "0xC0C2A4", VA = "0xC0C2A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xC0C2AC", Offset = "0xC0C2AC", VA = "0xC0C2AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xC0C334", Offset = "0xC0C334", VA = "0xC0C334")]
	private void SnapToGround()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xC0C4F4", Offset = "0xC0C4F4", VA = "0xC0C4F4")]
	public CrowdPlacementHelper()
	{
	}
}
[Token(Token = "0x2000035")]
public class CrowdRandomizer : MonoBehaviour
{
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF190", Offset = "0x3DF190")]
	private sealed class <PlaceCrowds>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x20")]
		public CrowdRandomizer <>4__this;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x28")]
		private GameObject[] <crowdLayers>5__2;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x30")]
		private List<Transform>.Enumerator <>7__wrap2;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xB36630", Offset = "0xB36630", VA = "0xB36630", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xB36678", Offset = "0xB36678", VA = "0xB36678", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xB35AFC", Offset = "0xB35AFC", VA = "0xB35AFC")]
		[DebuggerHidden]
		public <PlaceCrowds>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xB35B28", Offset = "0xB35B28", VA = "0xB35B28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xB35B98", Offset = "0xB35B98", VA = "0xB35B98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xB35B44", Offset = "0xB35B44", VA = "0xB35B44")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xB36638", Offset = "0xB36638", VA = "0xB36638", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000DA")]
	private const int MAX_CONCURRENT_PLACEMENTS = 200;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x0")]
	public static int unplacedCrowds;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x4")]
	private static int currentPlacements;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x18")]
	public int width;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x1C")]
	public int max;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x20")]
	public Material sibMaterial;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x28")]
	public Material homeAlternate;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x30")]
	public Material homeSibAlternate;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine placeRoutine;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xC0C528", Offset = "0xC0C528", VA = "0xC0C528")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xC0C574", Offset = "0xC0C574", VA = "0xC0C574")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xC0C5B4", Offset = "0xC0C5B4", VA = "0xC0C5B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E169C", Offset = "0x3E169C")]
	private IEnumerator PlaceCrowds()
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xC0C620", Offset = "0xC0C620", VA = "0xC0C620")]
	public CrowdRandomizer()
	{
	}
}
[Token(Token = "0x2000037")]
public class CrowdReaction : FootballBehaviour
{
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xC0C634", Offset = "0xC0C634", VA = "0xC0C634", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xC0C6F0", Offset = "0xC0C6F0", VA = "0xC0C6F0", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xC0C7B0", Offset = "0xC0C7B0", VA = "0xC0C7B0", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xC0C870", Offset = "0xC0C870", VA = "0xC0C870", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xC0C930", Offset = "0xC0C930", VA = "0xC0C930", Slot = "14")]
	protected override void OnHotStreak()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xC0C9EC", Offset = "0xC0C9EC", VA = "0xC0C9EC", Slot = "15")]
	protected override void OnFirstDown()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xC0CAA8", Offset = "0xC0CAA8", VA = "0xC0CAA8", Slot = "17")]
	protected override void OnLoss()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xC0CB68", Offset = "0xC0CB68", VA = "0xC0CB68")]
	public CrowdReaction()
	{
	}
}
[Token(Token = "0x2000038")]
public class CurrentDownMarker : MonoBehaviour
{
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] sticks;

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xC0CB70", Offset = "0xC0CB70", VA = "0xC0CB70")]
	public void Move()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xC0CCC0", Offset = "0xC0CCC0", VA = "0xC0CCC0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xC0CDB8", Offset = "0xC0CDB8", VA = "0xC0CDB8")]
	public CurrentDownMarker()
	{
	}
}
[Token(Token = "0x2000039")]
public class DPadHighlight : MonoBehaviour
{
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject left;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject up;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject right;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject down;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer lJoy;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer rJoy;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xC0CDC0", Offset = "0xC0CDC0", VA = "0xC0CDC0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xC0D0BC", Offset = "0xC0D0BC", VA = "0xC0D0BC")]
	public DPadHighlight()
	{
	}
}
[Token(Token = "0x200003A")]
public class DeActivateOnSnap : MonoBehaviour
{
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PlayAction;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xC0D0C4", Offset = "0xC0D0C4", VA = "0xC0D0C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xC0D1B4", Offset = "0xC0D1B4", VA = "0xC0D1B4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xC0D1D4", Offset = "0xC0D1D4", VA = "0xC0D1D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xC0D264", Offset = "0xC0D264", VA = "0xC0D264")]
	public DeActivateOnSnap()
	{
	}
}
[Token(Token = "0x200003B")]
public class Option
{
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x10")]
	public bool[] active;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x18")]
	public float chance;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xEC92C0", Offset = "0xEC92C0", VA = "0xEC92C0")]
	public Option(float chance, int size)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xEC933C", Offset = "0xEC933C", VA = "0xEC933C")]
	public void Roll()
	{
	}
}
[Token(Token = "0x200003C")]
public class Range
{
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x10")]
	private float min;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x14")]
	private float max;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E070C", Offset = "0x3E070C")]
	private float <value>k__BackingField;

	[Token(Token = "0x1700000C")]
	public float value
	{
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD49664", Offset = "0xD49664", VA = "0xD49664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E174C", Offset = "0x3E174C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xD4966C", Offset = "0xD4966C", VA = "0xD4966C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E175C", Offset = "0x3E175C")]
		set
		{
		}
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xD495F4", Offset = "0xD495F4", VA = "0xD495F4")]
	public Range(float min, float max)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD49638", Offset = "0xD49638", VA = "0xD49638")]
	public void Roll()
	{
	}
}
[Token(Token = "0x200003D")]
public enum DefenderRole
{
	[Token(Token = "0x40000F6")]
	Blitz,
	[Token(Token = "0x40000F7")]
	Cover,
	[Token(Token = "0x40000F8")]
	Zone
}
[Token(Token = "0x200003E")]
public class DefenderAssignment
{
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x10")]
	public Transform player;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x18")]
	public DefenderRole role;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x1C")]
	public int gap;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x20")]
	public Transform man;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x28")]
	public List<Transform> zone;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xC0D26C", Offset = "0xC0D26C", VA = "0xC0D26C")]
	public DefenderAssignment()
	{
	}
}
[Token(Token = "0x200003F")]
public class DefensePackage
{
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x10")]
	public float tackleboxWidth;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x18")]
	public Range gapLength;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x20")]
	public Range linemenOffset;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x28")]
	public Range linebackerOffset;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x30")]
	public Range linebackerCreep;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x38")]
	public Option linebackerBlitz;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x40")]
	public Option linebackerDrop;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x48")]
	public Range safetySpacing;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x50")]
	public Range safetyOffset;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x58")]
	public Range safetyCreep;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x60")]
	public float zoneHelp;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x68")]
	public Range zoneCreep;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x70")]
	public Range backOffset;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x78")]
	public Range backCreep;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x80")]
	public Option backZone;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x88")]
	public Range backSpacing;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x90")]
	public Option backUnderForce;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x98")]
	public Option backInsideForce;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0xA0")]
	public Option cornerBlitz;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0xA8")]
	public Option cornerZone;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0xB0")]
	public float interceptionChance;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xC1292C", Offset = "0xC1292C", VA = "0xC1292C")]
	public DefensePackage(float tackleboxWidth, Range gapLength, Range linemenOffset, Range linebackerOffset, Range linebackerCreep, Option linebackerBlitz, Option linebackerDrop, Range safetySpacing, Range safetyOffset, Range safetyCreep, float zoneHelp, Range zoneCreep, Range backOffset, Range backCreep, Option backZone, Range backSpacing, Option backUnderForce, Option backInsideForce, Option cornerBlitz, Option cornerZone, float interceptionChance)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xC0ED48", Offset = "0xC0ED48", VA = "0xC0ED48")]
	public void NewPlay()
	{
	}
}
[Token(Token = "0x2000040")]
public class Defense : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF1A0", Offset = "0x3DF1A0")]
	private sealed class <>c
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Transform> <>9__50_0;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<Transform> <>9__52_0;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<DefenderAssignment> <>9__52_1;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<DefenderAssignment> <>9__52_2;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xB366E0", Offset = "0xB366E0", VA = "0xB366E0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xB366E8", Offset = "0xB366E8", VA = "0xB366E8")]
		internal int <Start>b__50_0(Transform a, Transform b)
		{
			return default(int);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xB3674C", Offset = "0xB3674C", VA = "0xB3674C")]
		internal int <Update>b__52_0(Transform a, Transform b)
		{
			return default(int);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xB367B0", Offset = "0xB367B0", VA = "0xB367B0")]
		internal int <Update>b__52_1(DefenderAssignment a, DefenderAssignment b)
		{
			return default(int);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xB36830", Offset = "0xB36830", VA = "0xB36830")]
		internal int <Update>b__52_2(DefenderAssignment a, DefenderAssignment b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x0")]
	public static DefenderAssignment[] assignments;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x8")]
	public static Transform[] linemen;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x10")]
	private static List<Transform> uncovered;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x18")]
	public static List<Transform> receivers;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x20")]
	private static List<Transform> wideouts;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x28")]
	private static Transform[] tightends;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x30")]
	private static int wideCount;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x38")]
	private static DefensePackage[] packages;

	[Token(Token = "0x1700000D")]
	public static float tackleboxWidth
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xC0D2E4", Offset = "0xC0D2E4", VA = "0xC0D2E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700000E")]
	public static float gapLength
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xC0D3B4", Offset = "0xC0D3B4", VA = "0xC0D3B4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700000F")]
	private static float linemenOffset
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xC0D48C", Offset = "0xC0D48C", VA = "0xC0D48C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000010")]
	public static float linebackerOffset
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xC0D564", Offset = "0xC0D564", VA = "0xC0D564")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000011")]
	private static float linebackerCreep
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xC0D63C", Offset = "0xC0D63C", VA = "0xC0D63C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	private static bool[] linebackerBlitz
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xC0D714", Offset = "0xC0D714", VA = "0xC0D714")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	private static bool[] linebackerDrop
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xC0D7EC", Offset = "0xC0D7EC", VA = "0xC0D7EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	private static float safetySpacing
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xC0D8C4", Offset = "0xC0D8C4", VA = "0xC0D8C4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000015")]
	private static float safetyOffset
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xC0D99C", Offset = "0xC0D99C", VA = "0xC0D99C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000016")]
	private static float safetyCreep
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xC0DA74", Offset = "0xC0DA74", VA = "0xC0DA74")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000017")]
	private static float zoneHelp
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xC0DB4C", Offset = "0xC0DB4C", VA = "0xC0DB4C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000018")]
	public static float zoneCreep
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xC0DC1C", Offset = "0xC0DC1C", VA = "0xC0DC1C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000019")]
	public static float backOffset
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xC0DCF4", Offset = "0xC0DCF4", VA = "0xC0DCF4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001A")]
	private static float backCreep
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xC0DDCC", Offset = "0xC0DDCC", VA = "0xC0DDCC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001B")]
	private static bool[] backZone
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xC0DEA4", Offset = "0xC0DEA4", VA = "0xC0DEA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public static float backSpacing
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xC0DF7C", Offset = "0xC0DF7C", VA = "0xC0DF7C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001D")]
	public static bool[] backUnderForce
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xC0E054", Offset = "0xC0E054", VA = "0xC0E054")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool[] backInsideForce
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xC0E12C", Offset = "0xC0E12C", VA = "0xC0E12C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	private static bool[] cornerBlitz
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xC0E204", Offset = "0xC0E204", VA = "0xC0E204")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	private static bool[] cornerZone
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xC0E2DC", Offset = "0xC0E2DC", VA = "0xC0E2DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public static bool intercept
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xC0E3B4", Offset = "0xC0E3B4", VA = "0xC0E3B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xC0E4B8", Offset = "0xC0E4B8", VA = "0xC0E4B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xC0EA9C", Offset = "0xC0EA9C", VA = "0xC0EA9C")]
	public static void NewPlayCall()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xC0EE84", Offset = "0xC0EE84", VA = "0xC0EE84")]
	private void Update()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xC0FA90", Offset = "0xC0FA90", VA = "0xC0FA90")]
	private static void MergeZones(List<Transform> a, List<Transform> b, Transform defender)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xC0EB68", Offset = "0xC0EB68", VA = "0xC0EB68")]
	private static void AssignGaps()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xC0FCF4", Offset = "0xC0FCF4", VA = "0xC0FCF4")]
	public static Vector3 StartPosition(int playerIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xC0FDDC", Offset = "0xC0FDDC", VA = "0xC0FDDC")]
	private static Vector3 StartPositionLinemen(int playerIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xC0FF84", Offset = "0xC0FF84", VA = "0xC0FF84")]
	private static Vector3 StartPositionLinebacker(int playerIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xC104A0", Offset = "0xC104A0", VA = "0xC104A0")]
	private static Vector3 StartPositionCorner(int playerIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xC10940", Offset = "0xC10940", VA = "0xC10940")]
	private static Vector3 StartPositionBack(int playerIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xC1102C", Offset = "0xC1102C", VA = "0xC1102C")]
	public Defense()
	{
	}
}
[Token(Token = "0x2000042")]
public class DefenseSliderCB : MonoBehaviour
{
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x18")]
	public Transform receiver;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x20")]
	public int sign;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xC12A20", Offset = "0xC12A20", VA = "0xC12A20")]
	private void Update()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xC12C1C", Offset = "0xC12C1C", VA = "0xC12C1C")]
	public DefenseSliderCB()
	{
	}
}
[Token(Token = "0x2000043")]
public class DefenseSliderDB : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF1B0", Offset = "0x3DF1B0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Transform> <>9__3_0;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB36910", Offset = "0xB36910", VA = "0xB36910")]
		public <>c()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB36918", Offset = "0xB36918", VA = "0xB36918")]
		internal int <Update>b__3_0(Transform a, Transform b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> receivers;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x20")]
	public int sign;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xC12C30", Offset = "0xC12C30", VA = "0xC12C30")]
	private void Update()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xC13078", Offset = "0xC13078", VA = "0xC13078")]
	public DefenseSliderDB()
	{
	}
}
[Token(Token = "0x2000045")]
public class DefenseSliderLB : MonoBehaviour
{
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> receivers;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x20")]
	public int sign;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD13E4C", Offset = "0xD13E4C", VA = "0xD13E4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xD14118", Offset = "0xD14118", VA = "0xD14118")]
	public DefenseSliderLB()
	{
	}
}
[Token(Token = "0x2000046")]
public class DrawRoute : MonoBehaviour
{
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF1C0", Offset = "0x3DF1C0")]
	private sealed class <PerformDraw>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x20")]
		public DrawRoute <>4__this;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 <current>5__2;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x30")]
		private List<FieldPoint>.Enumerator <>7__wrap2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xB36C58", Offset = "0xB36C58", VA = "0xB36C58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xB36CA0", Offset = "0xB36CA0", VA = "0xB36CA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB3697C", Offset = "0xB3697C", VA = "0xB3697C")]
		[DebuggerHidden]
		public <PerformDraw>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB369A8", Offset = "0xB369A8", VA = "0xB369A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB36A18", Offset = "0xB36A18", VA = "0xB36A18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB369C4", Offset = "0xB369C4", VA = "0xB369C4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB36C60", Offset = "0xB36C60", VA = "0xB36C60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400012B")]
	private const float BETWEEN_DRAWS = 0.05f;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject routePrefab;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x20")]
	public Transform routeLine;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x28")]
	public Transform routeJoint;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x30")]
	private GameObject route;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x38")]
	private int playerIndex;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x3C")]
	private int drawnPlayIndex;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x40")]
	private bool flipped;

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD18050", Offset = "0xD18050", VA = "0xD18050")]
	private void Start()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xD180B0", Offset = "0xD180B0", VA = "0xD180B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xD18480", Offset = "0xD18480", VA = "0xD18480")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E176C", Offset = "0x3E176C")]
	private IEnumerator PerformDraw()
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xD184EC", Offset = "0xD184EC", VA = "0xD184EC")]
	private void Draw(Vector2 currentMark, Vector2 prevMark)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xD18814", Offset = "0xD18814", VA = "0xD18814")]
	public DrawRoute()
	{
	}
}
[Token(Token = "0x2000048")]
public class Drawing : MonoBehaviour
{
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x18")]
	public Transform marker;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x20")]
	public Pickupable markerPickupable;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x28")]
	public Transform eraser;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x30")]
	public List<Transform> playerSliders;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x38")]
	public Transform mark;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x40")]
	public Transform markJoint;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x48")]
	public AudioSource eraserSound;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource markerSound;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x58")]
	public int maxRouteSegments;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x5C")]
	public float minRouteSegmentLength;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x60")]
	public Transform leftBorder;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x68")]
	public Transform rightBorder;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x70")]
	public Transform topBorder;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x78")]
	public Transform bottomBorder;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x80")]
	private Transform closestPlayer;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x88")]
	private List<FieldPoint> route;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x90")]
	private float nextErase;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x94")]
	private float eraseInterval;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x98")]
	private float nextDraw;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x9C")]
	private float drawInterval;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0xA0")]
	private float prevDistance;

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xD18824", Offset = "0xD18824", VA = "0xD18824")]
	private Transform ClosestPlayerSlider(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xD18B84", Offset = "0xD18B84", VA = "0xD18B84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xD18CD0", Offset = "0xD18CD0", VA = "0xD18CD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD18E1C", Offset = "0xD18E1C", VA = "0xD18E1C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xD19030", Offset = "0xD19030", VA = "0xD19030")]
	private void StartDrawing()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD19794", Offset = "0xD19794", VA = "0xD19794")]
	private void StopDrawing()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD198E4", Offset = "0xD198E4", VA = "0xD198E4")]
	private void ContinueDrawing()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD191A8", Offset = "0xD191A8", VA = "0xD191A8")]
	public FieldPoint DrawLine(Vector3 fromPoint, Vector3 toPoint)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xD19C60", Offset = "0xD19C60", VA = "0xD19C60")]
	private Vector2 GetIntersectionPointCoordinates(Vector2 A1, Vector2 A2, Vector2 B1, Vector2 B2, out bool found)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xD19DB8", Offset = "0xD19DB8", VA = "0xD19DB8")]
	public Drawing()
	{
	}
}
[Token(Token = "0x2000049")]
public delegate void FootballEvent();
[Token(Token = "0x200004A")]
public static class Events
{
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x0")]
	public static bool touchdown;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x1")]
	public static bool safety;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x2")]
	public static bool interception;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x3")]
	public static bool turnover;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x4")]
	public static bool sacked;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x5")]
	public static bool incomplete;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x8")]
	public static float prevFieldPos;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x10")]
	public static FootballEvent OnPlayStart;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x18")]
	public static FootballEvent OnPlayStop;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x20")]
	public static FootballEvent OnTouchdown;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x28")]
	public static FootballEvent OnSafety;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x30")]
	public static FootballEvent OnInterception;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x38")]
	public static FootballEvent OnTurnover;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x40")]
	public static FootballEvent OnFourthDown;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x48")]
	public static FootballEvent OnSack;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x50")]
	public static FootballEvent OnIncomplete;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x58")]
	public static FootballEvent OnHotStreak;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x60")]
	public static FootballEvent OnFirstDown;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x68")]
	public static FootballEvent OnCompletion;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x70")]
	public static FootballEvent OnLoss;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x78")]
	public static FootballEvent OnCatch;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x80")]
	public static FootballEvent OnFieldGoal;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xD1A258", Offset = "0xD1A258", VA = "0xD1A258")]
	public static void Call(FootballEvent fEvent)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xD1A470", Offset = "0xD1A470", VA = "0xD1A470")]
	public static void CatchMade()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xD1A4E4", Offset = "0xD1A4E4", VA = "0xD1A4E4")]
	public static void FieldGoal()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xD1A558", Offset = "0xD1A558", VA = "0xD1A558")]
	public static void GameOver()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xD1A5CC", Offset = "0xD1A5CC", VA = "0xD1A5CC")]
	public static void PlayStart()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xD1A640", Offset = "0xD1A640", VA = "0xD1A640")]
	public static void PlayStop()
	{
	}
}
[Token(Token = "0x200004B")]
public class ExhibitionMode : Clickable
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF1D0", Offset = "0x3DF1D0")]
	private sealed class <StartExhibitionMode>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xB37C94", Offset = "0xB37C94", VA = "0xB37C94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xB37CDC", Offset = "0xB37CDC", VA = "0xB37CDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xB37A04", Offset = "0xB37A04", VA = "0xB37A04")]
		[DebuggerHidden]
		public <StartExhibitionMode>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xB37A30", Offset = "0xB37A30", VA = "0xB37A30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xB37A34", Offset = "0xB37A34", VA = "0xB37A34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xB37C9C", Offset = "0xB37C9C", VA = "0xB37C9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF1E0", Offset = "0x3DF1E0")]
	private sealed class <Start20MD>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xB379B4", Offset = "0xB379B4", VA = "0xB379B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xB379FC", Offset = "0xB379FC", VA = "0xB379FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xB37794", Offset = "0xB37794", VA = "0xB37794")]
		[DebuggerHidden]
		public <Start20MD>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xB377C0", Offset = "0xB377C0", VA = "0xB377C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xB377C4", Offset = "0xB377C4", VA = "0xB377C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xB379BC", Offset = "0xB379BC", VA = "0xB379BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF1F0", Offset = "0x3DF1F0")]
	private sealed class <EndExhibition>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x20")]
		public ExhibitionMode <>4__this;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xB37514", Offset = "0xB37514", VA = "0xB37514", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xB3755C", Offset = "0xB3755C", VA = "0xB3755C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB37190", Offset = "0xB37190", VA = "0xB37190")]
		[DebuggerHidden]
		public <EndExhibition>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB371BC", Offset = "0xB371BC", VA = "0xB371BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xB371C0", Offset = "0xB371C0", VA = "0xB371C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB3751C", Offset = "0xB3751C", VA = "0xB3751C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF200", Offset = "0x3DF200")]
	private sealed class <DelayOfGame>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x20")]
		public ExhibitionMode <>4__this;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xB37140", Offset = "0xB37140", VA = "0xB37140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xB37188", Offset = "0xB37188", VA = "0xB37188", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xB36F88", Offset = "0xB36F88", VA = "0xB36F88")]
		[DebuggerHidden]
		public <DelayOfGame>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xB36FB4", Offset = "0xB36FB4", VA = "0xB36FB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xB36FB8", Offset = "0xB36FB8", VA = "0xB36FB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xB37148", Offset = "0xB37148", VA = "0xB37148", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF210", Offset = "0x3DF210")]
	private sealed class <BonusTime>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xB36F38", Offset = "0xB36F38", VA = "0xB36F38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xB36F80", Offset = "0xB36F80", VA = "0xB36F80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xB36CA8", Offset = "0xB36CA8", VA = "0xB36CA8")]
		[DebuggerHidden]
		public <BonusTime>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xB36CD4", Offset = "0xB36CD4", VA = "0xB36CD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB36CD8", Offset = "0xB36CD8", VA = "0xB36CD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xB36F40", Offset = "0xB36F40", VA = "0xB36F40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF220", Offset = "0x3DF220")]
	private sealed class <NextOpponent>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x20")]
		public ExhibitionMode <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xB37744", Offset = "0xB37744", VA = "0xB37744", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xB3778C", Offset = "0xB3778C", VA = "0xB3778C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xB37564", Offset = "0xB37564", VA = "0xB37564")]
		[DebuggerHidden]
		public <NextOpponent>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB37590", Offset = "0xB37590", VA = "0xB37590", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB37594", Offset = "0xB37594", VA = "0xB37594", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB3774C", Offset = "0xB3774C", VA = "0xB3774C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x50")]
	public GameObject winOverlay;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x58")]
	public GameObject loseOverlay;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x60")]
	public GameObject tieOverlay;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x68")]
	public GameObject delayOverlay;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x70")]
	private string sceneName;

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xD1AB34", Offset = "0xD1AB34", VA = "0xD1AB34")]
	private void Start()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xD1ABB8", Offset = "0xD1ABB8", VA = "0xD1ABB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xD1AD44", Offset = "0xD1AD44", VA = "0xD1AD44", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xD1AEA0", Offset = "0xD1AEA0", VA = "0xD1AEA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E181C", Offset = "0x3E181C")]
	private IEnumerator StartExhibitionMode()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xD1AE44", Offset = "0xD1AE44", VA = "0xD1AE44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E187C", Offset = "0x3E187C")]
	private IEnumerator Start20MD()
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xD1AEFC", Offset = "0xD1AEFC", VA = "0xD1AEFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E18DC", Offset = "0x3E18DC")]
	public IEnumerator EndExhibition()
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xD1ACD8", Offset = "0xD1ACD8", VA = "0xD1ACD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E193C", Offset = "0x3E193C")]
	private IEnumerator DelayOfGame()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xD1AF68", Offset = "0xD1AF68", VA = "0xD1AF68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E199C", Offset = "0x3E199C")]
	private IEnumerator BonusTime()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xD1AFC4", Offset = "0xD1AFC4", VA = "0xD1AFC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E19FC", Offset = "0x3E19FC")]
	private IEnumerator NextOpponent()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xD1B030", Offset = "0xD1B030", VA = "0xD1B030")]
	public ExhibitionMode()
	{
	}
}
[Token(Token = "0x2000052")]
public class ExhibitionModeSlider : Interactable
{
	[Token(Token = "0x4000177")]
	private const float SINGLE_POSITION = -0.028f;

	[Token(Token = "0x4000178")]
	private const float SERIES_POSITION = 0.21f;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x5C")]
	private float meanPosition;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xD1B084", Offset = "0xD1B084", VA = "0xD1B084")]
	private void Start()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xD1B154", Offset = "0xD1B154", VA = "0xD1B154")]
	private void Update()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xD1B298", Offset = "0xD1B298", VA = "0xD1B298", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xD1B29C", Offset = "0xD1B29C", VA = "0xD1B29C", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xD1B380", Offset = "0xD1B380", VA = "0xD1B380")]
	public ExhibitionModeSlider()
	{
	}
}
[Token(Token = "0x2000053")]
public enum VisibleMode
{
	[Token(Token = "0x400017C")]
	Standard,
	[Token(Token = "0x400017D")]
	Exhibition
}
[Token(Token = "0x2000054")]
public class ExhibitionObjectToggle : MonoBehaviour
{
	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x18")]
	public VisibleMode showsForMode;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xD1B3B4", Offset = "0xD1B3B4", VA = "0xD1B3B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xD1B4A4", Offset = "0xD1B4A4", VA = "0xD1B4A4")]
	public ExhibitionObjectToggle()
	{
	}
}
[Token(Token = "0x2000055")]
public class FieldGoalZone : MonoBehaviour
{
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x18")]
	public Transform numberDisplay;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xD1B4AC", Offset = "0xD1B4AC", VA = "0xD1B4AC")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xD1B994", Offset = "0xD1B994", VA = "0xD1B994")]
	public FieldGoalZone()
	{
	}
}
[Token(Token = "0x2000056")]
public class FieldPosition : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	public delegate void ResetEvent();

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x0")]
	private static float _x;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x4")]
	public static float z;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x8")]
	public static ResetEvent OnReset;

	[Token(Token = "0x17000030")]
	public static float x
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0xD1BC68", Offset = "0xD1BC68", VA = "0xD1BC68")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600017E")]
		[Address(RVA = "0xD1BCCC", Offset = "0xD1BCCC", VA = "0xD1BCCC")]
		set
		{
		}
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xD1BD54", Offset = "0xD1BD54", VA = "0xD1BD54")]
	public static void ResetPosition(float zPos = 20f)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xD1BE04", Offset = "0xD1BE04", VA = "0xD1BE04")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xD1BEA8", Offset = "0xD1BEA8", VA = "0xD1BEA8")]
	public void Move()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xD1BF78", Offset = "0xD1BF78", VA = "0xD1BF78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xD1C070", Offset = "0xD1C070", VA = "0xD1C070")]
	public FieldPosition()
	{
	}
}
[Token(Token = "0x2000058")]
public class Firework : MonoBehaviour
{
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x18")]
	public float launchSpeedMin;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x1C")]
	public float launchSpeedMax;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x20")]
	public float launchConeDegrees;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x24")]
	public float fuseTimeMin;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x28")]
	public float fuseTimeMax;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem trail;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem explosion;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource explosionAudioSource;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioClip> explosionSounds;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x50")]
	public List<Color> colors;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x58")]
	private float launchSpeed;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x5C")]
	private float fuseTime;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xD1C0E0", Offset = "0xD1C0E0", VA = "0xD1C0E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xD1C248", Offset = "0xD1C248", VA = "0xD1C248")]
	private void Update()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xD1C3D8", Offset = "0xD1C3D8", VA = "0xD1C3D8")]
	public Firework()
	{
	}
}
[Token(Token = "0x2000059")]
public class FireworkLauncher : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	private delegate void LaunchEvent();

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] fireworkPrefabs;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x0")]
	private static LaunchEvent OnLaunch;

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xD1C4A4", Offset = "0xD1C4A4", VA = "0xD1C4A4")]
	public static void Launch()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xD1C548", Offset = "0xD1C548", VA = "0xD1C548")]
	private void LaunchFirework()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xD1C68C", Offset = "0xD1C68C", VA = "0xD1C68C")]
	private void Start()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xD1C77C", Offset = "0xD1C77C", VA = "0xD1C77C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xD1C86C", Offset = "0xD1C86C", VA = "0xD1C86C")]
	public FireworkLauncher()
	{
	}
}
[Token(Token = "0x200005B")]
public class FireworksShow : MonoBehaviour
{
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x18")]
	public float frequency;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x1C")]
	public float timer;

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xD1C878", Offset = "0xD1C878", VA = "0xD1C878")]
	private void Update()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xD1C914", Offset = "0xD1C914", VA = "0xD1C914")]
	public FireworksShow()
	{
	}
}
[Token(Token = "0x200005C")]
public class FloatingTitle : MonoBehaviour
{
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x24")]
	public float rotateSpeed;

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xD1CB1C", Offset = "0xD1CB1C", VA = "0xD1CB1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xD1CC34", Offset = "0xD1CC34", VA = "0xD1CC34")]
	public FloatingTitle()
	{
	}
}
[Token(Token = "0x200005D")]
public class Football : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF230", Offset = "0x3DF230")]
	private sealed class <CatcherTransition>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody receivingPlayerRb;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x28")]
		public Football <>4__this;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x30")]
		public Transform qb;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x38")]
		public Rigidbody qbRb;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 <bcPos>5__2;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 <recVel>5__3;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xB38AF4", Offset = "0xB38AF4", VA = "0xB38AF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xB38B3C", Offset = "0xB38B3C", VA = "0xB38B3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xB386AC", Offset = "0xB386AC", VA = "0xB386AC")]
		[DebuggerHidden]
		public <CatcherTransition>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xB386D8", Offset = "0xB386D8", VA = "0xB386D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xB386DC", Offset = "0xB386DC", VA = "0xB386DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xB38AFC", Offset = "0xB38AFC", VA = "0xB38AFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF240", Offset = "0x3DF240")]
	private sealed class <ReceiverTransition>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody receivingPlayerRb;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		public Football <>4__this;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		public Transform qb;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x38")]
		public Rigidbody qbRb;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 <bcPos>5__2;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 <recVel>5__3;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x58")]
		private float <elapsed>5__4;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xB3A18C", Offset = "0xB3A18C", VA = "0xB3A18C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xB3A1D4", Offset = "0xB3A1D4", VA = "0xB3A1D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xB39A20", Offset = "0xB39A20", VA = "0xB39A20")]
		[DebuggerHidden]
		public <ReceiverTransition>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xB39A4C", Offset = "0xB39A4C", VA = "0xB39A4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xB39A50", Offset = "0xB39A50", VA = "0xB39A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB3A194", Offset = "0xB3A194", VA = "0xB3A194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF250", Offset = "0x3DF250")]
	private sealed class <CaughtTransition>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x20")]
		public Football <>4__this;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x28")]
		private float <elapsed>5__2;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xB39208", Offset = "0xB39208", VA = "0xB39208", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xB39250", Offset = "0xB39250", VA = "0xB39250", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB38B44", Offset = "0xB38B44", VA = "0xB38B44")]
		[DebuggerHidden]
		public <CaughtTransition>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xB38B70", Offset = "0xB38B70", VA = "0xB38B70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xB38B74", Offset = "0xB38B74", VA = "0xB38B74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xB39210", Offset = "0xB39210", VA = "0xB39210", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF260", Offset = "0x3DF260")]
	private sealed class <DelaySpot>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x20")]
		public Football <>4__this;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xB39760", Offset = "0xB39760", VA = "0xB39760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xB397A8", Offset = "0xB397A8", VA = "0xB397A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xB39258", Offset = "0xB39258", VA = "0xB39258")]
		[DebuggerHidden]
		public <DelaySpot>d__66(int <>1__state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xB39284", Offset = "0xB39284", VA = "0xB39284", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xB39288", Offset = "0xB39288", VA = "0xB39288", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xB39768", Offset = "0xB39768", VA = "0xB39768", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF270", Offset = "0x3DF270")]
	private sealed class <RestartPlay>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x20")]
		public Football <>4__this;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xB3A4D0", Offset = "0xB3A4D0", VA = "0xB3A4D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xB3A518", Offset = "0xB3A518", VA = "0xB3A518", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB3A1DC", Offset = "0xB3A1DC", VA = "0xB3A1DC")]
		[DebuggerHidden]
		public <RestartPlay>d__67(int <>1__state)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB3A208", Offset = "0xB3A208", VA = "0xB3A208", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB3A20C", Offset = "0xB3A20C", VA = "0xB3A20C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB3A4D8", Offset = "0xB3A4D8", VA = "0xB3A4D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF280", Offset = "0x3DF280")]
	private sealed class <BonusTime>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xB3865C", Offset = "0xB3865C", VA = "0xB3865C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xB386A4", Offset = "0xB386A4", VA = "0xB386A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xB38384", Offset = "0xB38384", VA = "0xB38384")]
		[DebuggerHidden]
		public <BonusTime>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB383B0", Offset = "0xB383B0", VA = "0xB383B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xB383B4", Offset = "0xB383B4", VA = "0xB383B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xB38664", Offset = "0xB38664", VA = "0xB38664", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF290", Offset = "0x3DF290")]
	private sealed class <FirstOpponent>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xB399D0", Offset = "0xB399D0", VA = "0xB399D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xB39A18", Offset = "0xB39A18", VA = "0xB39A18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xB397B0", Offset = "0xB397B0", VA = "0xB397B0")]
		[DebuggerHidden]
		public <FirstOpponent>d__69(int <>1__state)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xB397DC", Offset = "0xB397DC", VA = "0xB397DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xB397E0", Offset = "0xB397E0", VA = "0xB397E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xB399D8", Offset = "0xB399D8", VA = "0xB399D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF2A0", Offset = "0x3DF2A0")]
	private sealed class <BlinkOut>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x20")]
		private float <elapsed>5__2;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xB38334", Offset = "0xB38334", VA = "0xB38334", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xB3837C", Offset = "0xB3837C", VA = "0xB3837C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xB38280", Offset = "0xB38280", VA = "0xB38280")]
		[DebuggerHidden]
		public <BlinkOut>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xB382AC", Offset = "0xB382AC", VA = "0xB382AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xB382B0", Offset = "0xB382B0", VA = "0xB382B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xB3833C", Offset = "0xB3833C", VA = "0xB3833C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF2B0", Offset = "0x3DF2B0")]
	private sealed class <BlinkIn>d__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x20")]
		private float <elapsed>5__2;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xB38230", Offset = "0xB38230", VA = "0xB38230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xB38278", Offset = "0xB38278", VA = "0xB38278", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xB3817C", Offset = "0xB3817C", VA = "0xB3817C")]
		[DebuggerHidden]
		public <BlinkIn>d__71(int <>1__state)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xB381A8", Offset = "0xB381A8", VA = "0xB381A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xB381AC", Offset = "0xB381AC", VA = "0xB381AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xB38238", Offset = "0xB38238", VA = "0xB38238", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000196")]
	public const float blinkTime = 0.4f;

	[Token(Token = "0x4000197")]
	private const float RECEIVER_TIME_TO_STOP = 0.25f;

	[Token(Token = "0x4000198")]
	private const float CATCH_TO_HAND_TIME = 0.12f;

	[Token(Token = "0x4000199")]
	private const float CATCH_CAPSULE_HEIGHT = 2.5f;

	[Token(Token = "0x400019A")]
	private const float CATCH_CAPSULE_RADIUS = 0.5f;

	[Token(Token = "0x400019B")]
	private const float LOOK_ANGLE_CATCH_RESET_THRESHOLD = 65f;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x0")]
	public static bool onFire;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x1")]
	public static bool transferringPossession;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x18")]
	public bool isBonusBall;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem fire;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject fireModel;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject normalTrail;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject receiverModeTrail;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> throwSounds;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioClip> onFireThrowSounds;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x50")]
	public List<AudioClip> fireLoopSounds;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip receiverTeleportClip;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x60")]
	public AudioSource igniteAugioSource;

	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x68")]
	public AudioSource fireAudioSource;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x70")]
	public AudioSource firstImpactAudioSource;

	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x78")]
	public AudioSource impactAudioSource;

	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x80")]
	public AudioSource catchAudioSource;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x88")]
	public Transform model;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x90")]
	public bool hideWhileCaught;

	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x91")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E071C", Offset = "0x3E071C")]
	private bool <freezePlayers>k__BackingField;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E072C", Offset = "0x3E072C")]
	private int <goldRingsHit>k__BackingField;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x98")]
	private bool isBurning;

	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x2")]
	private static bool tipped;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x99")]
	private bool restarting;

	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x9A")]
	private bool thrown;

	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x9B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E073C", Offset = "0x3E073C")]
	private bool <complete>k__BackingField;

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x9C")]
	private bool markedForDestruction;

	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x9D")]
	private bool landed;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0xA0")]
	private int spinDir;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0xA4")]
	private float spinSpeed;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x4")]
	private static float waitTime;

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0xA8")]
	private bool modelsHidden;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0xA9")]
	private bool spotting;

	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 spot;

	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0xB8")]
	private Rigidbody rb;

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0xC0")]
	private Animator teleportAnim;

	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0xC8")]
	private CapsuleCollider catchCapsule;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0xD0")]
	private Pickupable pickupable;

	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0xD8")]
	private Transform qbTransform;

	[Token(Token = "0x17000031")]
	public bool freezePlayers
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD1CC44", Offset = "0xD1CC44", VA = "0xD1CC44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E1C3C", Offset = "0x3E1C3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600019B")]
		[Address(RVA = "0xD1CC4C", Offset = "0xD1CC4C", VA = "0xD1CC4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E1C4C", Offset = "0x3E1C4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public int goldRingsHit
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD1CC58", Offset = "0xD1CC58", VA = "0xD1CC58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E1C5C", Offset = "0x3E1C5C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xD1CC60", Offset = "0xD1CC60", VA = "0xD1CC60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E1C6C", Offset = "0x3E1C6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public bool complete
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0xD1CC68", Offset = "0xD1CC68", VA = "0xD1CC68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E1C7C", Offset = "0x3E1C7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xD1CC70", Offset = "0xD1CC70", VA = "0xD1CC70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E1C8C", Offset = "0x3E1C8C")]
		set
		{
		}
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xD1CC7C", Offset = "0xD1CC7C", VA = "0xD1CC7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xD1CCD0", Offset = "0xD1CCD0", VA = "0xD1CCD0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xD1CD64", Offset = "0xD1CD64", VA = "0xD1CD64")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xD20064", Offset = "0xD20064", VA = "0xD20064")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xD1E7D4", Offset = "0xD1E7D4", VA = "0xD1E7D4")]
	public static void SpotBall(float yardsGained, float xYardsGained, int downsGained)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xD20E50", Offset = "0xD20E50", VA = "0xD20E50")]
	public void TransitionToCatcher(Rigidbody receivingPlayerRb, Transform qb, Rigidbody qbRb)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xD20FD4", Offset = "0xD20FD4", VA = "0xD20FD4")]
	public void TransitionToReceiver(Rigidbody receivingPlayerRb, Transform qb, Rigidbody qbRb)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD21108", Offset = "0xD21108", VA = "0xD21108")]
	public void TransitionToCaught()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xD20CE0", Offset = "0xD20CE0", VA = "0xD20CE0")]
	private void HideModels()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xD1E500", Offset = "0xD1E500", VA = "0xD1E500")]
	private void RevealModels()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD20F48", Offset = "0xD20F48", VA = "0xD20F48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1C9C", Offset = "0x3E1C9C")]
	private IEnumerator CatcherTransition(Rigidbody receivingPlayerRb, Transform qb, Rigidbody qbRb)
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD2107C", Offset = "0xD2107C", VA = "0xD2107C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1CFC", Offset = "0x3E1CFC")]
	private IEnumerator ReceiverTransition(Rigidbody receivingPlayerRb, Transform qb, Rigidbody qbRb)
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xD21188", Offset = "0xD21188", VA = "0xD21188")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1D5C", Offset = "0x3E1D5C")]
	private IEnumerator CaughtTransition()
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xD1F7CC", Offset = "0xD1F7CC", VA = "0xD1F7CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1DBC", Offset = "0x3E1DBC")]
	private IEnumerator DelaySpot()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xD1FFF8", Offset = "0xD1FFF8", VA = "0xD1FFF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1E1C", Offset = "0x3E1E1C")]
	private IEnumerator RestartPlay()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xD1FF9C", Offset = "0xD1FF9C", VA = "0xD1FF9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1E7C", Offset = "0x3E1E7C")]
	private IEnumerator BonusTime()
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xD1E4A4", Offset = "0xD1E4A4", VA = "0xD1E4A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1EDC", Offset = "0x3E1EDC")]
	private IEnumerator FirstOpponent()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xD211F4", Offset = "0xD211F4", VA = "0xD211F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1F3C", Offset = "0x3E1F3C")]
	public IEnumerator BlinkOut()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xD21250", Offset = "0xD21250", VA = "0xD21250")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E1F9C", Offset = "0x3E1F9C")]
	public IEnumerator BlinkIn()
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xD20D4C", Offset = "0xD20D4C", VA = "0xD20D4C")]
	private void RemoveCatchCapsule()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xD21330", Offset = "0xD21330", VA = "0xD21330")]
	public Football()
	{
	}
}
[Token(Token = "0x2000067")]
public class FootballBehaviour : MonoBehaviour
{
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD21474", Offset = "0xD21474", VA = "0xD21474")]
	private void Start()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xD21A04", Offset = "0xD21A04", VA = "0xD21A04", Slot = "4")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xD21A08", Offset = "0xD21A08", VA = "0xD21A08")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xD21F7C", Offset = "0xD21F7C", VA = "0xD21F7C", Slot = "5")]
	protected virtual void OnPlayStart()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xD21F80", Offset = "0xD21F80", VA = "0xD21F80", Slot = "6")]
	protected virtual void OnPlayStop()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xD21F84", Offset = "0xD21F84", VA = "0xD21F84", Slot = "7")]
	protected virtual void OnTouchdown()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xD21F88", Offset = "0xD21F88", VA = "0xD21F88", Slot = "8")]
	protected virtual void OnSafety()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xD21F8C", Offset = "0xD21F8C", VA = "0xD21F8C", Slot = "9")]
	protected virtual void OnInterception()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xD21F90", Offset = "0xD21F90", VA = "0xD21F90", Slot = "10")]
	protected virtual void OnTurnover()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xD21F94", Offset = "0xD21F94", VA = "0xD21F94", Slot = "11")]
	protected virtual void OnFourthDown()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD21F98", Offset = "0xD21F98", VA = "0xD21F98", Slot = "12")]
	protected virtual void OnSack()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD21F9C", Offset = "0xD21F9C", VA = "0xD21F9C", Slot = "13")]
	protected virtual void OnIncomplete()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD21FA0", Offset = "0xD21FA0", VA = "0xD21FA0", Slot = "14")]
	protected virtual void OnHotStreak()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xD21FA4", Offset = "0xD21FA4", VA = "0xD21FA4", Slot = "15")]
	protected virtual void OnFirstDown()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xD21FA8", Offset = "0xD21FA8", VA = "0xD21FA8", Slot = "16")]
	protected virtual void OnCompletion()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD21FAC", Offset = "0xD21FAC", VA = "0xD21FAC", Slot = "17")]
	protected virtual void OnLoss()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xD21FB0", Offset = "0xD21FB0", VA = "0xD21FB0", Slot = "18")]
	protected virtual void OnCatch()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xD21FB4", Offset = "0xD21FB4", VA = "0xD21FB4", Slot = "19")]
	protected virtual void OnFieldGoal()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD21FB8", Offset = "0xD21FB8", VA = "0xD21FB8")]
	public FootballBehaviour()
	{
	}
}
[Token(Token = "0x2000068")]
public class FootballDestroyer : MonoBehaviour
{
	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xD21FC0", Offset = "0xD21FC0", VA = "0xD21FC0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xD22104", Offset = "0xD22104", VA = "0xD22104")]
	public FootballDestroyer()
	{
	}
}
[Token(Token = "0x2000069")]
public class ForceAwardMode : MonoBehaviour
{
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x18")]
	public int trophyRound;

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xD22144", Offset = "0xD22144", VA = "0xD22144")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD221EC", Offset = "0xD221EC", VA = "0xD221EC")]
	public ForceAwardMode()
	{
	}
}
[Token(Token = "0x200006A")]
public class ForceBonusMode : MonoBehaviour
{
	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD221F4", Offset = "0xD221F4", VA = "0xD221F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD2225C", Offset = "0xD2225C", VA = "0xD2225C")]
	public ForceBonusMode()
	{
	}
}
[Token(Token = "0x200006B")]
public class FoveatedRendering : MonoBehaviour
{
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x18")]
	public FoveationLevel level;

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD22264", Offset = "0xD22264", VA = "0xD22264")]
	private void Start()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xD222CC", Offset = "0xD222CC", VA = "0xD222CC")]
	public FoveatedRendering()
	{
	}
}
[Token(Token = "0x200006C")]
public enum PlayState
{
	[Token(Token = "0x40001EA")]
	Start,
	[Token(Token = "0x40001EB")]
	Snapped,
	[Token(Token = "0x40001EC")]
	Thrown,
	[Token(Token = "0x40001ED")]
	Caught,
	[Token(Token = "0x40001EE")]
	Tackled,
	[Token(Token = "0x40001EF")]
	End,
	[Token(Token = "0x40001F0")]
	GameOver,
	[Token(Token = "0x40001F1")]
	BonusTime,
	[Token(Token = "0x40001F2")]
	Award,
	[Token(Token = "0x40001F3")]
	OpponentDrive
}
[Token(Token = "0x200006D")]
public enum PassAttemptResult
{
	[Token(Token = "0x40001F5")]
	Completion,
	[Token(Token = "0x40001F6")]
	Incomplete,
	[Token(Token = "0x40001F7")]
	Touchdown,
	[Token(Token = "0x40001F8")]
	Interception
}
[Token(Token = "0x200006E")]
public enum LeagueType
{
	[Token(Token = "0x40001FA")]
	Dummy,
	[Token(Token = "0x40001FB")]
	Bot,
	[Token(Token = "0x40001FC")]
	Bruiser,
	[Token(Token = "0x40001FD")]
	Amazon,
	[Token(Token = "0x40001FE")]
	Pro,
	[Token(Token = "0x40001FF")]
	Bonus,
	[Token(Token = "0x4000200")]
	National,
	[Token(Token = "0x4000201")]
	American
}
[Token(Token = "0x200006F")]
public enum CatchScheme
{
	[Token(Token = "0x4000203")]
	CatchZone,
	[Token(Token = "0x4000204")]
	Leading,
	[Token(Token = "0x4000205")]
	Facing
}
[Token(Token = "0x2000070")]
public enum GameLanguage
{
	[Token(Token = "0x4000207")]
	English,
	[Token(Token = "0x4000208")]
	German,
	[Token(Token = "0x4000209")]
	Chinese,
	[Token(Token = "0x400020A")]
	Japanese,
	[Token(Token = "0x400020B")]
	Korean
}
[Token(Token = "0x2000071")]
public class SaveGame
{
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x10")]
	public int highScore;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x14")]
	public float primaryR;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x18")]
	public float primaryG;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x1C")]
	public float primaryB;

	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x20")]
	public float secondaryR;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x24")]
	public float secondaryG;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x28")]
	public float secondaryB;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x2C")]
	public int team;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x30")]
	public int music;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x34")]
	public float musicVolume;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x38")]
	public int voice;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x3C")]
	public int tds;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x40")]
	public int completions;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x44")]
	public int conversions;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x48")]
	public int hotstreaks;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x4C")]
	public int teams;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x50")]
	public int tutorialStage;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x54")]
	public float throwTiming;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x58")]
	public float throwPower;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x5C")]
	public int selectedPlay;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x60")]
	public bool playFlipped;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x68")]
	public List<string> Achievements;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x70")]
	public int leagueType;

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x74")]
	public bool useGrip;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x78")]
	public int passTds;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x7C")]
	public int passesCompleted;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x80")]
	public int interceptions;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x84")]
	public float passingYards;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x88")]
	public int passAttempts;

	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x8C")]
	public float highestRatingAfter1;

	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x90")]
	public float highestRatingAfter2;

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x94")]
	public float highestRatingAfter3;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x98")]
	public float highestRatingAfter4;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x9C")]
	public float highestRatingAfter5;

	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0xA0")]
	public float highestRatingAfter6;

	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0xA4")]
	public float highestRatingChamp;

	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0xA8")]
	public int highestCompletionStreak;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0xAC")]
	public int totalWins;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0xB0")]
	public float qbRushYards;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0xB4")]
	public int qbRushTds;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0xB8")]
	public int championships;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0xBC")]
	public bool playAsReceiver;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0xBD")]
	public bool playCatch;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0xC0")]
	public float heightAdjustment;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0xC4")]
	public float exhibitionModeLength;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0xC8")]
	public int exhibitionModeDifficulty;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0xCC")]
	public bool playing20MD;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0xD0")]
	public float teleportTime;

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0xD4")]
	public CatchScheme catchScheme;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0xD8")]
	public GameLanguage gameLanguage;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0xDC")]
	public bool gameLanguageSet;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD4AA38", Offset = "0xD4AA38", VA = "0xD4AA38")]
	public SaveGame()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD39CB4", Offset = "0xD39CB4", VA = "0xD39CB4")]
	public void Save()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xD4AB50", Offset = "0xD4AB50", VA = "0xD4AB50")]
	public static SaveGame Load()
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xD4ADF8", Offset = "0xD4ADF8", VA = "0xD4ADF8")]
	public void PassAttemptMade(float yards, PassAttemptResult result)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD4AE58", Offset = "0xD4AE58", VA = "0xD4AE58")]
	private static string ComputeHash()
	{
		return null;
	}
}
[Token(Token = "0x2000072")]
public class SeriesStats
{
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x10")]
	public int passTds;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x14")]
	public int passesCompleted;

	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x18")]
	public int interceptions;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x1C")]
	public float passingYards;

	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x20")]
	public int passAttempts;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x24")]
	public float rushYards;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x28")]
	public int rushTDs;

	[Token(Token = "0x17000046")]
	public float SeriesPasserRating
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0xB2B73C", Offset = "0xB2B73C", VA = "0xB2B73C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xB2B6DC", Offset = "0xB2B6DC", VA = "0xB2B6DC")]
	public void PassAttemptMade(float yards, PassAttemptResult result)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xB2B868", Offset = "0xB2B868", VA = "0xB2B868")]
	public void ClearStats()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xB2B878", Offset = "0xB2B878", VA = "0xB2B878")]
	public SeriesStats()
	{
	}
}
[Token(Token = "0x2000073")]
public static class GameManager
{
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x0")]
	public static PlayState state;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x4")]
	public static bool practiceMode;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x5")]
	public static bool exhibitionMode;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x6")]
	public static bool fieldGoalTry;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x8")]
	private static int _score;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0xC")]
	public static int opponentScore;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x10")]
	public static float timeLeft;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x14")]
	public static float playClock;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x18")]
	public static int totalScore;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x1C")]
	public static bool clockStopped;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x20")]
	public static SaveGame saveGame;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x28")]
	public static int CompletionStreak;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x2C")]
	public static int InGameCompletionStreak;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x30")]
	public static bool hasSafety;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x38")]
	public static SeriesStats seriesStats;

	[Token(Token = "0x17000047")]
	public static int score
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0xD222D4", Offset = "0xD222D4", VA = "0xD222D4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xD1B7F4", Offset = "0xD1B7F4", VA = "0xD1B7F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public static Color primaryColor
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0xD225AC", Offset = "0xD225AC", VA = "0xD225AC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000214")]
		[Address(RVA = "0xD22640", Offset = "0xD22640", VA = "0xD22640")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public static Color secondaryColor
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0xD226EC", Offset = "0xD226EC", VA = "0xD226EC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000216")]
		[Address(RVA = "0xD22780", Offset = "0xD22780", VA = "0xD22780")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public static float TotalPasserRating
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0xD22910", Offset = "0xD22910", VA = "0xD22910")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700004B")]
	public static float ThrowPower
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0xD22E08", Offset = "0xD22E08", VA = "0xD22E08")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xD22338", Offset = "0xD22338", VA = "0xD22338")]
	static GameManager()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xD2282C", Offset = "0xD2282C", VA = "0xD2282C")]
	public static void Practice()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xD1E5F4", Offset = "0xD1E5F4", VA = "0xD1E5F4")]
	public static void PassAttemptMade(float yards, PassAttemptResult result)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xD1FA9C", Offset = "0xD1FA9C", VA = "0xD1FA9C")]
	public static void UpdateWinStats()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xD22AE4", Offset = "0xD22AE4", VA = "0xD22AE4")]
	public static void NewGame()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xD22C74", Offset = "0xD22C74", VA = "0xD22C74")]
	public static void UpdateHighScore()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xD1F838", Offset = "0xD1F838", VA = "0xD1F838")]
	public static void UnlockTeam()
	{
	}
}
[Token(Token = "0x2000074")]
public abstract class Hand : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	public delegate void OnCatchSchemeChange(CatchScheme newScheme);

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x18")]
	public Mouth mouth;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x20")]
	public Animator puntController;

	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x0")]
	public static float lastInputTime;

	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x8")]
	public static Hand RightHand;

	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x28")]
	public Transform bonusFootball;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x10")]
	public static float rumbleTime;

	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x30")]
	public bool isRight;

	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource highlightSound;

	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject neutralHand;

	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject hoverHand;

	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x50")]
	public bool overrideModel;

	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x58")]
	private GameObject closestTouched;

	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x60")]
	protected GameObject heldObject;

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x68")]
	private float feedbackTimer;

	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x70")]
	protected GameObject currentHand;

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x78")]
	protected float playChangeInterval;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x14")]
	protected static bool leftButtonOneDown;

	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x15")]
	protected static bool leftButtonTwoDown;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x16")]
	protected static bool leftButtonOnePressed;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x17")]
	protected static bool leftButtonTwoPressed;

	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x18")]
	protected static bool rightButtonOneDown;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x19")]
	protected static bool rightButtonTwoDown;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x1A")]
	protected static bool rightButtonOnePressed;

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x1B")]
	protected static bool rightButtonTwoPressed;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x1C")]
	protected static Vector3 inputDirectionLeft;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x28")]
	protected static Vector3 inputDirectionRight;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x34")]
	public static float lastPlayChange;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x38")]
	public static OnCatchSchemeChange catchSchemeChanged;

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x80")]
	protected GameObject football;

	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x88")]
	private GameObject arcadeSnapBall;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x90")]
	private SphereCollider sc;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x98")]
	private string activeSceneName;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x40")]
	private static bool finishedStartup;

	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x41")]
	public static bool InPocket;

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0xA0")]
	private float startupTime;

	[Token(Token = "0x1700004C")]
	public static Vector3 InputDirection
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0xD238E0", Offset = "0xD238E0", VA = "0xD238E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000220")]
	protected abstract bool ProcessControllerInput();

	[Token(Token = "0x6000221")]
	protected abstract void Rumble();

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xD2397C", Offset = "0xD2397C", VA = "0xD2397C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xD23A40", Offset = "0xD23A40", VA = "0xD23A40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xD23B94", Offset = "0xD23B94", VA = "0xD23B94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xD24584", Offset = "0xD24584", VA = "0xD24584")]
	protected void Disengage()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xD24744", Offset = "0xD24744", VA = "0xD24744")]
	protected void Interact()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xD24F88", Offset = "0xD24F88", VA = "0xD24F88")]
	public void BallToHand(GameObject football)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xD24F18", Offset = "0xD24F18", VA = "0xD24F18")]
	private void Highlight(GameObject target, bool toggle)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xD25064", Offset = "0xD25064", VA = "0xD25064")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xD252FC", Offset = "0xD252FC", VA = "0xD252FC")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xD256B4", Offset = "0xD256B4", VA = "0xD256B4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xD212AC", Offset = "0xD212AC", VA = "0xD212AC")]
	public void Untouch()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xD25760", Offset = "0xD25760", VA = "0xD25760")]
	public void Hide()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xD244B4", Offset = "0xD244B4", VA = "0xD244B4")]
	public void Show()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xD257B8", Offset = "0xD257B8", VA = "0xD257B8")]
	protected Hand()
	{
	}
}
[Token(Token = "0x2000076")]
public class HandXR : Hand
{
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF2C0", Offset = "0x3DF2C0")]
	private sealed class <PerformRumble>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x20")]
		public InputDevice controller;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xB3A90C", Offset = "0xB3A90C", VA = "0xB3A90C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xB3A954", Offset = "0xB3A954", VA = "0xB3A954", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xB3A818", Offset = "0xB3A818", VA = "0xB3A818")]
		[DebuggerHidden]
		public <PerformRumble>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB3A844", Offset = "0xB3A844", VA = "0xB3A844", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB3A848", Offset = "0xB3A848", VA = "0xB3A848", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xB3A914", Offset = "0xB3A914", VA = "0xB3A914", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x0")]
	private static InputDevice? leftController;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x18")]
	private static InputDevice? rightController;

	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0xA4")]
	private bool triggerPressed;

	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0xA8")]
	private float triggerDownOculus;

	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0xAC")]
	private float triggerUpOculus;

	[Token(Token = "0x1700004D")]
	public static InputDevice LeftController
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD25864", Offset = "0xD25864", VA = "0xD25864")]
		get
		{
			return default(InputDevice);
		}
	}

	[Token(Token = "0x1700004E")]
	public static InputDevice RightController
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD259CC", Offset = "0xD259CC", VA = "0xD259CC")]
		get
		{
			return default(InputDevice);
		}
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xD25B38", Offset = "0xD25B38", VA = "0xD25B38", Slot = "4")]
	protected override bool ProcessControllerInput()
	{
		return default(bool);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD26364", Offset = "0xD26364", VA = "0xD26364", Slot = "5")]
	protected override void Rumble()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xD263AC", Offset = "0xD263AC", VA = "0xD263AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E22CC", Offset = "0x3E22CC")]
	private IEnumerator PerformRumble(InputDevice controller)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD260E0", Offset = "0xD260E0", VA = "0xD260E0")]
	private bool ChangingPlay(InputDevice controller)
	{
		return default(bool);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD261F4", Offset = "0xD261F4", VA = "0xD261F4")]
	private bool HasTrackedPoints()
	{
		return default(bool);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xD26424", Offset = "0xD26424", VA = "0xD26424")]
	public HandXR()
	{
	}
}
[Token(Token = "0x2000078")]
public class HelmetField : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF2D0", Offset = "0x3DF2D0")]
	private sealed class <DelayExit>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xB3AAD0", Offset = "0xB3AAD0", VA = "0xB3AAD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xB3AB18", Offset = "0xB3AB18", VA = "0xB3AB18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB3A95C", Offset = "0xB3A95C", VA = "0xB3A95C")]
		[DebuggerHidden]
		public <DelayExit>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xB3A988", Offset = "0xB3A988", VA = "0xB3A988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xB3A98C", Offset = "0xB3A98C", VA = "0xB3A98C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xB3AAD8", Offset = "0xB3AAD8", VA = "0xB3AAD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000280")]
	private const float HELMET_REMOVE_SQ_DIST = 0.36f;

	[Token(Token = "0x4000281")]
	private const float HELMET_HEAD_SNAP_SQ_DIST = 0.09f;

	[Token(Token = "0x4000282")]
	private const float HELMET_START_FADE_SQ_DIST = 0.01f;

	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x20")]
	public GameObject helmetOverlay;

	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x28")]
	public GameObject helmetObject;

	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x38")]
	private Pickupable pickupable;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xEB8ED0", Offset = "0xEB8ED0", VA = "0xEB8ED0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xEB9000", Offset = "0xEB9000", VA = "0xEB9000")]
	private void Update()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xEB8FA4", Offset = "0xEB8FA4", VA = "0xEB8FA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E237C", Offset = "0x3E237C")]
	private IEnumerator DelayExit()
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xEB940C", Offset = "0xEB940C", VA = "0xEB940C")]
	public HelmetField()
	{
	}
}
[Token(Token = "0x200007A")]
public class HelmetLockerRoom : MonoBehaviour
{
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 origin;

	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion origRot;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x34")]
	private float resetTimer;

	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x38")]
	private Transform head;

	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject helmetOverlay;

	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject helmet;

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xEB9414", Offset = "0xEB9414", VA = "0xEB9414")]
	private void Start()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xEB94B8", Offset = "0xEB94B8", VA = "0xEB94B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xEB9690", Offset = "0xEB9690", VA = "0xEB9690")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xEB9A00", Offset = "0xEB9A00", VA = "0xEB9A00")]
	public HelmetLockerRoom()
	{
	}
}
[Token(Token = "0x200007B")]
public class HighScorePlaque : MonoBehaviour
{
	[Token(Token = "0x6000251")]
	[Address(RVA = "0xEB9A4C", Offset = "0xEB9A4C", VA = "0xEB9A4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xEB9B08", Offset = "0xEB9B08", VA = "0xEB9B08")]
	public HighScorePlaque()
	{
	}
}
[Token(Token = "0x200007C")]
public class HitBox : MonoBehaviour
{
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody qbRB;

	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x28")]
	private GameObject football;

	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x30")]
	public bool rotate;

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xEB9B10", Offset = "0xEB9B10", VA = "0xEB9B10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xEB9B64", Offset = "0xEB9B64", VA = "0xEB9B64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xEBAD00", Offset = "0xEBAD00", VA = "0xEBAD00")]
	public HitBox()
	{
	}
}
[Token(Token = "0x200007D")]
public abstract class Interactable : MonoBehaviour
{
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E074C", Offset = "0x3E074C")]
	private Transform <actor>k__BackingField;

	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource pickupSound;

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x28")]
	public GameObject leftHandHold;

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x30")]
	public GameObject rightHandHold;

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x38")]
	public Transform highlight;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x40")]
	private int highlightCount;

	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<Transform, Material[]> BaseMaterials;

	[Token(Token = "0x17000053")]
	public Transform actor
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xEBB278", Offset = "0xEBB278", VA = "0xEBB278")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E242C", Offset = "0x3E242C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xEBB280", Offset = "0xEBB280", VA = "0xEBB280")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E243C", Offset = "0x3E243C")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public bool activated
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEB93A0", Offset = "0xEB93A0", VA = "0xEB93A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000259")]
	protected abstract void OnActivate();

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xEBB288", Offset = "0xEBB288", VA = "0xEBB288", Slot = "5")]
	public virtual void Activate(Transform actor, bool process = true)
	{
	}

	[Token(Token = "0x600025B")]
	protected abstract void OnDeactivate();

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xEBB50C", Offset = "0xEBB50C", VA = "0xEBB50C", Slot = "7")]
	public virtual void Deactivate(bool process = true)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xEBB618", Offset = "0xEBB618", VA = "0xEBB618")]
	public void Highlight(bool toggle)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xEBB6D4", Offset = "0xEBB6D4", VA = "0xEBB6D4")]
	protected void Highlight(Transform target, bool toggle)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xEBBB5C", Offset = "0xEBBB5C", VA = "0xEBBB5C")]
	protected Interactable()
	{
	}
}
[Token(Token = "0x200007E")]
public class JumboCam : MonoBehaviour
{
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x0")]
	public static bool isEnabled;

	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x18")]
	public Transform trackTarget;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 startPos;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x2C")]
	public float zoomDist;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xEBBBD4", Offset = "0xEBBBD4", VA = "0xEBBBD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xEBBC64", Offset = "0xEBBC64", VA = "0xEBBC64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xEBBDD8", Offset = "0xEBBDD8", VA = "0xEBBDD8")]
	public static void Toggle()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xEBBE44", Offset = "0xEBBE44", VA = "0xEBBE44")]
	public JumboCam()
	{
	}
}
[Token(Token = "0x200007F")]
public class JumboEvents : FootballBehaviour
{
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject defaultAnim;

	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject touchdownAnim;

	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject safetyAnim;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject interceptionAnim;

	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject turnOverAnim;

	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject fourthDownAnim;

	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x48")]
	public GameObject sackAnim;

	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x50")]
	public GameObject incompleteAnim;

	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x58")]
	public GameObject hotStreakAnim;

	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject firstDownAnim;

	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x68")]
	public GameObject completionAnim;

	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x70")]
	public GameObject youLoseAnim;

	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x78")]
	public GameObject youWinAnim;

	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x80")]
	public GameObject bonusAnim;

	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x88")]
	private float timer;

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xEBBED4", Offset = "0xEBBED4", VA = "0xEBBED4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xEBBF88", Offset = "0xEBBF88", VA = "0xEBBF88")]
	private void PlayAnim(GameObject anim)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xEBC22C", Offset = "0xEBC22C", VA = "0xEBC22C", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xEBC310", Offset = "0xEBC310", VA = "0xEBC310", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xEBC318", Offset = "0xEBC318", VA = "0xEBC318", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xEBC320", Offset = "0xEBC320", VA = "0xEBC320", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xEBC328", Offset = "0xEBC328", VA = "0xEBC328", Slot = "11")]
	protected override void OnFourthDown()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xEBC330", Offset = "0xEBC330", VA = "0xEBC330", Slot = "12")]
	protected override void OnSack()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xEBC338", Offset = "0xEBC338", VA = "0xEBC338", Slot = "13")]
	protected override void OnIncomplete()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xEBC340", Offset = "0xEBC340", VA = "0xEBC340", Slot = "14")]
	protected override void OnHotStreak()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xEBC348", Offset = "0xEBC348", VA = "0xEBC348", Slot = "15")]
	protected override void OnFirstDown()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xEBC350", Offset = "0xEBC350", VA = "0xEBC350", Slot = "16")]
	protected override void OnCompletion()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xEBC358", Offset = "0xEBC358", VA = "0xEBC358", Slot = "17")]
	protected override void OnLoss()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xEBC360", Offset = "0xEBC360", VA = "0xEBC360")]
	public JumboEvents()
	{
	}
}
[Token(Token = "0x2000080")]
public class JumboTron : MonoBehaviour
{
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF2E0", Offset = "0x3DF2E0")]
	private sealed class <NextOpponent>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xB3AD6C", Offset = "0xB3AD6C", VA = "0xB3AD6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0xB3ADB4", Offset = "0xB3ADB4", VA = "0xB3ADB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xB3AB20", Offset = "0xB3AB20", VA = "0xB3AB20")]
		[DebuggerHidden]
		public <NextOpponent>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xB3AB4C", Offset = "0xB3AB4C", VA = "0xB3AB4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xB3AB50", Offset = "0xB3AB50", VA = "0xB3AB50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xB3AD74", Offset = "0xB3AD74", VA = "0xB3AD74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject jumboCamScreen;

	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject jumboCam;

	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject breakEffect;

	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x30")]
	public GameObject awardOverlay;

	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x0")]
	public static bool skip;

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xEBC368", Offset = "0xEBC368", VA = "0xEBC368")]
	private void Update()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xEBC80C", Offset = "0xEBC80C", VA = "0xEBC80C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E244C", Offset = "0x3E244C")]
	private IEnumerator NextOpponent()
	{
		return null;
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xEBC868", Offset = "0xEBC868", VA = "0xEBC868")]
	public JumboTron()
	{
	}
}
[Token(Token = "0x2000082")]
public class JumpCatch : MonoBehaviour
{
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x18")]
	public Animator anim;

	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x20")]
	public string animationName;

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xEBC874", Offset = "0xEBC874", VA = "0xEBC874")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xEBC908", Offset = "0xEBC908", VA = "0xEBC908")]
	public JumpCatch()
	{
	}
}
[Token(Token = "0x2000083")]
public class KickGoodDisplay : MonoBehaviour
{
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject displayObject;

	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x20")]
	public float timeToDisplay;

	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x24")]
	private float hideAt;

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xEBC95C", Offset = "0xEBC95C", VA = "0xEBC95C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xEBCA4C", Offset = "0xEBCA4C", VA = "0xEBCA4C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xEBCB3C", Offset = "0xEBCB3C", VA = "0xEBCB3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xEBCB8C", Offset = "0xEBCB8C", VA = "0xEBCB8C")]
	private void OnFieldGoal()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xEBCBD4", Offset = "0xEBCBD4", VA = "0xEBCBD4")]
	public KickGoodDisplay()
	{
	}
}
[Token(Token = "0x2000084")]
public class Kicker : MonoBehaviour
{
	[Token(Token = "0x6000284")]
	[Address(RVA = "0xEBCBE4", Offset = "0xEBCBE4", VA = "0xEBCBE4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xEBCCEC", Offset = "0xEBCCEC", VA = "0xEBCCEC")]
	public Kicker()
	{
	}
}
[Token(Token = "0x2000085")]
public static class Leaderboard
{
	[Token(Token = "0x40002BB")]
	private const string DUMMY_LB_NAME = "2mdvrfootball";

	[Token(Token = "0x40002BC")]
	private const string ROBOT_LB_NAME = "2MDRobotLeaderBoard";

	[Token(Token = "0x40002BD")]
	private const string BRUISER_LB_NAME = "2MDBruiserLeaderBoard";

	[Token(Token = "0x40002BE")]
	private const string AMAZON_LB_NAME = "2MDAmazonLeaderBoard";

	[Token(Token = "0x40002BF")]
	private const string PRO_LB_NAME = "2MDProLeaderBoard";

	[Token(Token = "0x40002C0")]
	private const string BONUS_LB_NAME = "2MDBonusLeaderboard";

	[Token(Token = "0x40002C1")]
	private const string NATIONAL_LB_NAME = "2MDNationalLeaderboard";

	[Token(Token = "0x40002C2")]
	private const string AMERICAN_LB_NAME = "2MDAmericanLeaderboard";

	[Token(Token = "0x40002C3")]
	private const int QUERY_COUNT = 8;

	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x0")]
	private static string currentLB;

	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x8")]
	private static bool querying;

	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x9")]
	private static bool leaderboardInitialized;

	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x10")]
	public static List<LeaderboardEntry> globalLeaderboard;

	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x18")]
	public static List<LeaderboardEntry> localLeaderboard;

	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x20")]
	public static List<LeaderboardEntry> friendLeaderboard;

	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x28")]
	public static List<LeaderboardEntry> displayedLeaderboard;

	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x30")]
	public static long currentUserHighScore;

	[Token(Token = "0x17000057")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0xEBCCF4", Offset = "0xEBCCF4", VA = "0xEBCCF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xEBCD58", Offset = "0xEBCD58", VA = "0xEBCD58")]
	public static void UpdateScore(int yourScore)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xEBCEC8", Offset = "0xEBCEC8", VA = "0xEBCEC8")]
	public static void GetLeaderboardResults()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xEBD594", Offset = "0xEBD594", VA = "0xEBD594")]
	private static void TopLeaderboardEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xEBD810", Offset = "0xEBD810", VA = "0xEBD810")]
	private static void LocalLeaderboardEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xEBDC28", Offset = "0xEBDC28", VA = "0xEBDC28")]
	private static void FriendLeaderboardEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xEBD1AC", Offset = "0xEBD1AC", VA = "0xEBD1AC")]
	private static void GetCurrentLeaderboardName()
	{
	}
}
[Token(Token = "0x2000086")]
public class LeaderboardScreenSlideshow : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF2F0", Offset = "0x3DF2F0")]
	private sealed class <SwitchScreen>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardScreenSlideshow <>4__this;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xB3AE94", Offset = "0xB3AE94", VA = "0xB3AE94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0xB3AEDC", Offset = "0xB3AEDC", VA = "0xB3AEDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xB3ADBC", Offset = "0xB3ADBC", VA = "0xB3ADBC")]
		[DebuggerHidden]
		public <SwitchScreen>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xB3ADE8", Offset = "0xB3ADE8", VA = "0xB3ADE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xB3ADEC", Offset = "0xB3ADEC", VA = "0xB3ADEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xB3AE9C", Offset = "0xB3AE9C", VA = "0xB3AE9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x18")]
	public float switchInterval;

	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject offlineScreen;

	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x28")]
	private int currentScreenIndex;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xEBDFF8", Offset = "0xEBDFF8", VA = "0xEBDFF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xEBE0D8", Offset = "0xEBE0D8", VA = "0xEBE0D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xEBE06C", Offset = "0xEBE06C", VA = "0xEBE06C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E24FC", Offset = "0x3E24FC")]
	private IEnumerator SwitchScreen()
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xEBE308", Offset = "0xEBE308", VA = "0xEBE308")]
	public LeaderboardScreenSlideshow()
	{
	}
}
[Token(Token = "0x2000088")]
public class LeaderboardUIElement : MonoBehaviour
{
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x18")]
	public bool isHeader;

	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x1C")]
	public int index;

	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x20")]
	public Text rankText;

	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x28")]
	public Text gamerTagText;

	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x30")]
	public Text scoreText;

	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x38")]
	private Color primary;

	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x48")]
	private Color secondary;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xEBE318", Offset = "0xEBE318", VA = "0xEBE318")]
	private void SetColorScheme()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xEBE4C8", Offset = "0xEBE4C8", VA = "0xEBE4C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xEBE4CC", Offset = "0xEBE4CC", VA = "0xEBE4CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xEBE8E4", Offset = "0xEBE8E4", VA = "0xEBE8E4")]
	public LeaderboardUIElement()
	{
	}
}
[Token(Token = "0x2000089")]
public class Lerp : MonoBehaviour
{
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x18")]
	public Transform trackedObject;

	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x24")]
	public bool lookAway;

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xEBE928", Offset = "0xEBE928", VA = "0xEBE928")]
	private void Update()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xEBE9E8", Offset = "0xEBE9E8", VA = "0xEBE9E8")]
	public Lerp()
	{
	}
}
[Token(Token = "0x200008A")]
public class LerpAndLook : MonoBehaviour
{
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x18")]
	public Transform trackedObject;

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x20")]
	public Transform lookObject;

	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x28")]
	public float interval;

	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x2C")]
	public bool lookAway;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xEBE9F8", Offset = "0xEBE9F8", VA = "0xEBE9F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xEBEB5C", Offset = "0xEBEB5C", VA = "0xEBEB5C")]
	public LerpAndLook()
	{
	}
}
[Token(Token = "0x200008B")]
public class LinearAlgebra : MonoBehaviour
{
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xEBEB6C", Offset = "0xEBEB6C", VA = "0xEBEB6C")]
	public static bool GetIntersection(Vector2 line1Start, Vector2 line1End, Vector2 line2Start, Vector2 line2End, out Vector2 intersection)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xEBEFC0", Offset = "0xEBEFC0", VA = "0xEBEFC0")]
	public static bool GetIntersection(Vector4 line1, Vector4 line2, out Vector2 intersection)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xEBECF4", Offset = "0xEBECF4", VA = "0xEBECF4")]
	private static bool IsParallel(Vector2 line1Normal, Vector2 line2Normal)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xEBEF20", Offset = "0xEBEF20", VA = "0xEBEF20")]
	private static bool IsOrthogonal(Vector2 lineBetween, Vector2 normal)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xEBEF44", Offset = "0xEBEF44", VA = "0xEBEF44")]
	private static bool IsBetween(Vector2 start, Vector2 end, Vector2 intersect)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xEBEFC4", Offset = "0xEBEFC4", VA = "0xEBEFC4")]
	public LinearAlgebra()
	{
	}
}
[Token(Token = "0x200008C")]
public class LoadSceneEvent : MonoBehaviour
{
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xEBEFCC", Offset = "0xEBEFCC", VA = "0xEBEFCC")]
	public void LoadNextScene()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xEBF028", Offset = "0xEBF028", VA = "0xEBF028")]
	public LoadSceneEvent()
	{
	}
}
[Token(Token = "0x200008D")]
public class LockIcon : MonoBehaviour
{
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x18")]
	public int unlockAt;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject div;

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xEBF394", Offset = "0xEBF394", VA = "0xEBF394")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xEBF44C", Offset = "0xEBF44C", VA = "0xEBF44C")]
	public LockIcon()
	{
	}
}
[Token(Token = "0x200008E")]
public class LogoSlider : Interactable
{
	[Token(Token = "0x200008F")]
	public delegate void LogoChangeDelegate();

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x0")]
	public static List<int> teams;

	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x8")]
	public static LogoChangeDelegate OnLogoChange;

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xEBF45C", Offset = "0xEBF45C", VA = "0xEBF45C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xEBF5BC", Offset = "0xEBF5BC", VA = "0xEBF5BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xEBF8BC", Offset = "0xEBF8BC", VA = "0xEBF8BC", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xEBF8C0", Offset = "0xEBF8C0", VA = "0xEBF8C0", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xEBF930", Offset = "0xEBF930", VA = "0xEBF930")]
	public LogoSlider()
	{
	}
}
[Token(Token = "0x2000090")]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject lookAtTarget;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x20")]
	public bool yOnly;

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xEBFA84", Offset = "0xEBFA84", VA = "0xEBFA84")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xEBFB40", Offset = "0xEBFB40", VA = "0xEBFB40")]
	public LookAt()
	{
	}
}
[Token(Token = "0x2000091")]
public class LowSettingsUnload : MonoBehaviour
{
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xEBFB50", Offset = "0xEBFB50", VA = "0xEBFB50")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xEBFBE4", Offset = "0xEBFBE4", VA = "0xEBFBE4")]
	public LowSettingsUnload()
	{
	}
}
[Token(Token = "0x2000092")]
public class Mascot : FootballBehaviour
{
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xEBFBEC", Offset = "0xEBFBEC", VA = "0xEBFBEC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xEBFD28", Offset = "0xEBFD28", VA = "0xEBFD28", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xEBFDC4", Offset = "0xEBFDC4", VA = "0xEBFDC4", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xEBFE60", Offset = "0xEBFE60", VA = "0xEBFE60", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xEBFEFC", Offset = "0xEBFEFC", VA = "0xEBFEFC", Slot = "12")]
	protected override void OnSack()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xEBFF98", Offset = "0xEBFF98", VA = "0xEBFF98", Slot = "13")]
	protected override void OnIncomplete()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xEC0034", Offset = "0xEC0034", VA = "0xEC0034", Slot = "17")]
	protected override void OnLoss()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xEC00D0", Offset = "0xEC00D0", VA = "0xEC00D0")]
	public Mascot()
	{
	}
}
[Token(Token = "0x2000093")]
public class MascotHead : MonoBehaviour
{
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x18")]
	public bool offense;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] heads;

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xEC00D8", Offset = "0xEC00D8", VA = "0xEC00D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xEC0210", Offset = "0xEC0210", VA = "0xEC0210")]
	public MascotHead()
	{
	}
}
[Serializable]
[Token(Token = "0x2000094")]
public class Voice
{
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x10")]
	public List<AudioClip> snapSounds;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x18")]
	public List<AudioClip> audible0Sounds;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x20")]
	public List<AudioClip> audible1Sounds;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> audible2Sounds;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> audible3Sounds;

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xB32F2C", Offset = "0xB32F2C", VA = "0xB32F2C")]
	public Voice()
	{
	}
}
[Token(Token = "0x2000095")]
public class Mouth : MonoBehaviour
{
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x18")]
	public float silentSnapFreq;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x1C")]
	public bool playsAudibles;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x20")]
	public List<Voice> voices;

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xEC1AB8", Offset = "0xEC1AB8", VA = "0xEC1AB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xEC1BA8", Offset = "0xEC1BA8", VA = "0xEC1BA8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xEC1C98", Offset = "0xEC1C98", VA = "0xEC1C98")]
	public void Snap()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xEC1E24", Offset = "0xEC1E24", VA = "0xEC1E24")]
	private void Audible()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xEC2088", Offset = "0xEC2088", VA = "0xEC2088")]
	public void PlaySample()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xEC22F4", Offset = "0xEC22F4", VA = "0xEC22F4")]
	public Mouth()
	{
	}
}
[Token(Token = "0x2000096")]
public class MoveTransform : MonoBehaviour
{
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Vector3 targetPos1;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 targetPos2;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float speed;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x34")]
	public bool canMove;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x35")]
	public bool firstMove;

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xEC2380", Offset = "0xEC2380", VA = "0xEC2380")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xEC238C", Offset = "0xEC238C", VA = "0xEC238C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xEC256C", Offset = "0xEC256C", VA = "0xEC256C")]
	public MoveTransform()
	{
	}
}
[Token(Token = "0x2000097")]
public class MoveTransformHorizontal : MonoBehaviour
{
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Vector3 targetPos1;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 targetPos2;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float speed;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x34")]
	public bool canMove;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x35")]
	public bool firstMove;

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xEC257C", Offset = "0xEC257C", VA = "0xEC257C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xEC2588", Offset = "0xEC2588", VA = "0xEC2588")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xEC271C", Offset = "0xEC271C", VA = "0xEC271C")]
	public MoveTransformHorizontal()
	{
	}
}
[Serializable]
[Token(Token = "0x2000098")]
public class MusicTrack
{
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x10")]
	public AudioClip lockerClip;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip fieldClip;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip fireClip;

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xEC33D4", Offset = "0xEC33D4", VA = "0xEC33D4")]
	public MusicTrack()
	{
	}
}
[Token(Token = "0x2000099")]
public class Music : MonoBehaviour
{
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x18")]
	public AudioMixer audioManager;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource lockerSource;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource fieldSource;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource fireSource;

	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x38")]
	public float fadeRate;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x40")]
	public MusicTrack[] tracks;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x48")]
	private float currentMusicVol;

	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x0")]
	private static Music self;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x4C")]
	private bool musicSet;

	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x50")]
	private int currentIndex;

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xEC272C", Offset = "0xEC272C", VA = "0xEC272C")]
	public static void NextTrack()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xEC2890", Offset = "0xEC2890", VA = "0xEC2890")]
	public void PlaySelectedTrack()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xEC29AC", Offset = "0xEC29AC", VA = "0xEC29AC")]
	private void StopSource(AudioSource source)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xEC29F4", Offset = "0xEC29F4", VA = "0xEC29F4")]
	private void PlaySource(AudioSource source)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xEC2A94", Offset = "0xEC2A94", VA = "0xEC2A94")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xEC2B50", Offset = "0xEC2B50", VA = "0xEC2B50")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xEC2C0C", Offset = "0xEC2C0C", VA = "0xEC2C0C")]
	private void Unset(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xEC2C14", Offset = "0xEC2C14", VA = "0xEC2C14")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xEC2D6C", Offset = "0xEC2D6C", VA = "0xEC2D6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xEC33B0", Offset = "0xEC33B0", VA = "0xEC33B0")]
	public Music()
	{
	}
}
[Token(Token = "0x200009A")]
public class Mustache : MonoBehaviour
{
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x0")]
	public static bool startSpeaking;

	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x8")]
	public static AudioClip speach;

	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x18")]
	public AudioMixer audioManager;

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x10")]
	public static bool stopSpeaking;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xEC33DC", Offset = "0xEC33DC", VA = "0xEC33DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xEC3698", Offset = "0xEC3698", VA = "0xEC3698")]
	public static void Speak(AudioClip clip)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xEC370C", Offset = "0xEC370C", VA = "0xEC370C")]
	public static void StopSpeaking()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xEC3774", Offset = "0xEC3774", VA = "0xEC3774")]
	public Mustache()
	{
	}
}
[Token(Token = "0x200009B")]
public class MuteMusic : MonoBehaviour
{
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xEC3780", Offset = "0xEC3780", VA = "0xEC3780")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xEC3848", Offset = "0xEC3848", VA = "0xEC3848")]
	public MuteMusic()
	{
	}
}
[Token(Token = "0x200009C")]
public class NewGame : MonoBehaviour
{
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xEC3850", Offset = "0xEC3850", VA = "0xEC3850")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xEC38AC", Offset = "0xEC38AC", VA = "0xEC38AC")]
	public NewGame()
	{
	}
}
[Token(Token = "0x200009D")]
public class NoSignalBox : MonoBehaviour
{
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF300", Offset = "0x3DF300")]
	private sealed class <MoveRandomly>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x20")]
		public NoSignalBox <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xB3B240", Offset = "0xB3B240", VA = "0xB3B240", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xB3B288", Offset = "0xB3B288", VA = "0xB3B288", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB3B128", Offset = "0xB3B128", VA = "0xB3B128")]
		[DebuggerHidden]
		public <MoveRandomly>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB3B154", Offset = "0xB3B154", VA = "0xB3B154", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB3B158", Offset = "0xB3B158", VA = "0xB3B158", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xB3B248", Offset = "0xB3B248", VA = "0xB3B248", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x18")]
	public float moveFrequency;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x1C")]
	public float xBound;

	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x20")]
	public float yBound;

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xEC38B4", Offset = "0xEC38B4", VA = "0xEC38B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xEC38E0", Offset = "0xEC38E0", VA = "0xEC38E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E25AC", Offset = "0x3E25AC")]
	private IEnumerator MoveRandomly()
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xEC394C", Offset = "0xEC394C", VA = "0xEC394C")]
	public NoSignalBox()
	{
	}
}
[Token(Token = "0x200009F")]
public static class NormalDistribution
{
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xEC53B8", Offset = "0xEC53B8", VA = "0xEC53B8")]
	public static float NormalizedRandom(float mean, float sigma)
	{
		return default(float);
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xEC53E4", Offset = "0xEC53E4", VA = "0xEC53E4")]
	public static float NextGaussianFloat()
	{
		return default(float);
	}
}
[Token(Token = "0x20000A0")]
public class NotebookTips : Clickable
{
	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x50")]
	private int currentTip;

	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x58")]
	public Transform tipsContainer;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xEC546C", Offset = "0xEC546C", VA = "0xEC546C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xEC54B0", Offset = "0xEC54B0", VA = "0xEC54B0", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xEC5554", Offset = "0xEC5554", VA = "0xEC5554")]
	public NotebookTips()
	{
	}
}
[Token(Token = "0x20000A1")]
public class ObjectShake : MonoBehaviour
{
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x18")]
	public float linearIntensity;

	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x1C")]
	public float angularIntensity;

	[NonSerialized]
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x20")]
	public bool isShaking;

	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x21")]
	private bool angularShaking;

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xEC555C", Offset = "0xEC555C", VA = "0xEC555C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xEC559C", Offset = "0xEC559C", VA = "0xEC559C")]
	private void LinearShaking()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xEC561C", Offset = "0xEC561C", VA = "0xEC561C")]
	private void AngularShaking()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xEC5688", Offset = "0xEC5688", VA = "0xEC5688")]
	public void SetAngularShaking(bool state)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xEC56DC", Offset = "0xEC56DC", VA = "0xEC56DC")]
	public void Enable()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xEC56E8", Offset = "0xEC56E8", VA = "0xEC56E8")]
	public void Disable()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xEC5754", Offset = "0xEC5754", VA = "0xEC5754")]
	public ObjectShake()
	{
	}
}
[Token(Token = "0x20000A2")]
public class SpaceTime
{
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 point;

	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x1C")]
	public float time;

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xB2E298", Offset = "0xB2E298", VA = "0xB2E298")]
	public SpaceTime(Vector3 point, float time)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xB2E2E4", Offset = "0xB2E2E4", VA = "0xB2E2E4")]
	public SpaceTime Delta(SpaceTime b, float t)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xB2E3B8", Offset = "0xB2E3B8", VA = "0xB2E3B8")]
	public static SpaceTime Middle(SpaceTime a, SpaceTime b, float f)
	{
		return null;
	}
}
[Token(Token = "0x20000A3")]
public class BlockAssignment
{
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x10")]
	public Transform player;

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x18")]
	public Transform responsibility;

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xBFFEEC", Offset = "0xBFFEEC", VA = "0xBFFEEC")]
	public BlockAssignment()
	{
	}
}
[Token(Token = "0x20000A4")]
public class Offense : MonoBehaviour
{
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF310", Offset = "0x3DF310")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 protectLocation;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 protectVelocity;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xB3B290", Offset = "0xB3B290", VA = "0xB3B290")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xB3B298", Offset = "0xB3B298", VA = "0xB3B298")]
		internal int <Update>b__0(Transform a, Transform b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF320", Offset = "0x3DF320")]
	private sealed class <DelayedReceiverMode>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x20")]
		public Offense <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xB3B6C8", Offset = "0xB3B6C8", VA = "0xB3B6C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xB3B710", Offset = "0xB3B710", VA = "0xB3B710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xB3B380", Offset = "0xB3B380", VA = "0xB3B380")]
		[DebuggerHidden]
		public <DelayedReceiverMode>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xB3B3AC", Offset = "0xB3B3AC", VA = "0xB3B3AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xB3B3B0", Offset = "0xB3B3B0", VA = "0xB3B3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xB3B6D0", Offset = "0xB3B6D0", VA = "0xB3B6D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400031C")]
	public const float MIN_BALL_IN_AIR_FOR_SWAP = 1f;

	[Token(Token = "0x400031D")]
	public const float DELAY_FOR__RECEIVER_SWAP = 0.5f;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x0")]
	private static Transform[] defenders;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x8")]
	public static BlockAssignment[] assignments;

	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x10")]
	private static Transform football;

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x18")]
	private static Transform qb;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x20")]
	public static Transform catcher;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x28")]
	public static SpaceTime catchST;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x30")]
	public static SpaceTime[] catchableZone;

	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x18")]
	public GameObject catchAreaDisplay;

	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x38")]
	private static Offense _instance;

	[Token(Token = "0x1700005C")]
	public static bool CatchAreaActive
	{
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xEC5770", Offset = "0xEC5770", VA = "0xEC5770")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005D")]
	public static Vector3 CatchAreaPosition
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xEC57E8", Offset = "0xEC57E8", VA = "0xEC57E8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xEC589C", Offset = "0xEC589C", VA = "0xEC589C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xEC5BE4", Offset = "0xEC5BE4", VA = "0xEC5BE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xEC6C90", Offset = "0xEC6C90", VA = "0xEC6C90")]
	public static void DetermineTarget()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xEC70C4", Offset = "0xEC70C4", VA = "0xEC70C4")]
	public static float InterceptTime(Transform defender, Vector3 target, Vector3 targetVel)
	{
		return default(float);
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xEC68B4", Offset = "0xEC68B4", VA = "0xEC68B4")]
	public static SpaceTime EstimateIntercept(Transform player, SpaceTime sp0, SpaceTime sp1)
	{
		return null;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xEC72B0", Offset = "0xEC72B0", VA = "0xEC72B0")]
	public static float TimeToPoint(Transform player, Vector3 point)
	{
		return default(float);
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xEC7568", Offset = "0xEC7568", VA = "0xEC7568")]
	private static float QuadraticRootMax(float a, float b, float c)
	{
		return default(float);
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xEC64F0", Offset = "0xEC64F0", VA = "0xEC64F0")]
	public static void GetCatchableZone()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xEC7058", Offset = "0xEC7058", VA = "0xEC7058")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E265C", Offset = "0x3E265C")]
	public IEnumerator DelayedReceiverMode()
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xEC75CC", Offset = "0xEC75CC", VA = "0xEC75CC")]
	public Offense()
	{
	}
}
[Token(Token = "0x20000A7")]
public class OnCatchSchemeChange : MonoBehaviour
{
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent onFacing;

	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent onLeading;

	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onCatchZone;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xEC76B8", Offset = "0xEC76B8", VA = "0xEC76B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xEC77A8", Offset = "0xEC77A8", VA = "0xEC77A8")]
	private void onDisable()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xEC7898", Offset = "0xEC7898", VA = "0xEC7898")]
	private void ChangeScheme(CatchScheme scheme)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xEC78D4", Offset = "0xEC78D4", VA = "0xEC78D4")]
	public OnCatchSchemeChange()
	{
	}
}
[Token(Token = "0x20000A8")]
public class OnLookingAt : MonoBehaviour
{
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x18")]
	public float lookingAtAudioThreshhold;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x1C")]
	public float lookingAtVisualThreshhold;

	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource lookingAtAudio;

	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer lookingAtVisual;

	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x30")]
	private GameObject cam;

	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x38")]
	private bool isLookingAtVisual;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x39")]
	private bool isHearingAudio;

	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x40")]
	private Pickupable pickupable;

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xEC78DC", Offset = "0xEC78DC", VA = "0xEC78DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xEC7A60", Offset = "0xEC7A60", VA = "0xEC7A60")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xEC7BA8", Offset = "0xEC7BA8", VA = "0xEC7BA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xEC7A64", Offset = "0xEC7A64", VA = "0xEC7A64")]
	private void HideLookAts()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xEC7EE4", Offset = "0xEC7EE4", VA = "0xEC7EE4")]
	public OnLookingAt()
	{
	}
}
[Token(Token = "0x20000A9")]
public class OnWin : FootballBehaviour
{
	[Token(Token = "0x600031B")]
	[Address(RVA = "0xEC7EFC", Offset = "0xEC7EFC", VA = "0xEC7EFC", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xEC8004", Offset = "0xEC8004", VA = "0xEC8004")]
	public OnWin()
	{
	}
}
[Token(Token = "0x20000AA")]
public class OpponentOffense : MonoBehaviour
{
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E07BC", Offset = "0x3E07BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E07BC", Offset = "0x3E07BC")]
	public float minScoringChance;

	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0810", Offset = "0x3E0810")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0810", Offset = "0x3E0810")]
	public float maxScoringChance;

	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0864", Offset = "0x3E0864")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0864", Offset = "0x3E0864")]
	public float perRoundMinScoreChance;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E08B8", Offset = "0x3E08B8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E08B8", Offset = "0x3E08B8")]
	public float minTurnoverChance;

	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E090C", Offset = "0x3E090C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E090C", Offset = "0x3E090C")]
	public float maxTurnoverChance;

	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0960", Offset = "0x3E0960")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0960", Offset = "0x3E0960")]
	public float perRoundMaxTurnoverChance;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E09B4", Offset = "0x3E09B4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E09B4", Offset = "0x3E09B4")]
	public float fgRatioOutside30;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0A08", Offset = "0x3E0A08")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0A08", Offset = "0x3E0A08")]
	public float fgRatioOpp30;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0A5C", Offset = "0x3E0A5C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0A5C", Offset = "0x3E0A5C")]
	public float fgRatioOpp1;

	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0AB0", Offset = "0x3E0AB0")]
	public float clocktoYardsRatio;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0AE8", Offset = "0x3E0AE8")]
	public float minTurnoverYards;

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0B20", Offset = "0x3E0B20")]
	public float maxTurnoverYards;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0B58", Offset = "0x3E0B58")]
	public float turnoverYardsPerRound;

	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0B90", Offset = "0x3E0B90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0B90", Offset = "0x3E0B90")]
	public float fgMaxDesperation;

	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0BE4", Offset = "0x3E0BE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0BE4", Offset = "0x3E0BE4")]
	public float desperationTurnoverAdjust;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0C38", Offset = "0x3E0C38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0C38", Offset = "0x3E0C38")]
	public float desperationScoringAdjust;

	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x0")]
	private static OpponentOffense _instance;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x8")]
	private static float startingFieldPosition;

	[Token(Token = "0x4000349")]
	[FieldOffset(Offset = "0xC")]
	private static float adjustedMinScoreChance;

	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0x10")]
	private static float adjustedMaxTurnoverChance;

	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x14")]
	private static float adjustedMinTurnoverYards;

	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x18")]
	private static float adjustedMaxTurnoverYards;

	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x1C")]
	private static bool desperationMode;

	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x1D")]
	private static bool fgOnly;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x1E")]
	private static bool tdOnly;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x58")]
	private Animator anim;

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xEC800C", Offset = "0xEC800C", VA = "0xEC800C")]
	private void Start()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xEC81F0", Offset = "0xEC81F0", VA = "0xEC81F0")]
	public static void OpponentOffenseStarts(float fieldPosition)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xEC8294", Offset = "0xEC8294", VA = "0xEC8294")]
	public void OpponentPossession()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xEC9140", Offset = "0xEC9140", VA = "0xEC9140")]
	public void IncrementScore()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xEC91AC", Offset = "0xEC91AC", VA = "0xEC91AC")]
	public void EndOpponentDrive()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xEC9214", Offset = "0xEC9214", VA = "0xEC9214")]
	public OpponentOffense()
	{
	}
}
[Token(Token = "0x20000AB")]
public class Orbit : MonoBehaviour
{
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x18")]
	public float xSpread;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x1C")]
	public float zSpread;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x20")]
	public float yOffset;

	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x28")]
	public Transform centerPoint;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x30")]
	public float rotSpeed;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x34")]
	public bool rotateClockwise;

	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xEC93D4", Offset = "0xEC93D4", VA = "0xEC93D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xEC9418", Offset = "0xEC9418", VA = "0xEC9418")]
	private void Rotate()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xEC9518", Offset = "0xEC9518", VA = "0xEC9518")]
	public Orbit()
	{
	}
}
[Token(Token = "0x20000AC")]
public class PauseMenu : MonoBehaviour
{
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ControlDisplay;

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xEC9520", Offset = "0xEC9520", VA = "0xEC9520")]
	private void Start()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xEC9540", Offset = "0xEC9540", VA = "0xEC9540")]
	private void Update()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xEC95B8", Offset = "0xEC95B8", VA = "0xEC95B8")]
	public PauseMenu()
	{
	}
}
[Token(Token = "0x20000AD")]
public class Persistent : MonoBehaviour
{
	[Token(Token = "0x600032A")]
	[Address(RVA = "0xEC95C0", Offset = "0xEC95C0", VA = "0xEC95C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xEC9638", Offset = "0xEC9638", VA = "0xEC9638")]
	public Persistent()
	{
	}
}
[Token(Token = "0x20000AE")]
public class TrackInfo
{
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 position;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 velocity;

	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x2C")]
	public bool tracked;

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xB310A8", Offset = "0xB310A8", VA = "0xB310A8")]
	public TrackInfo(Vector3 position, Vector3 velocity, float time, bool tracked)
	{
	}
}
[Token(Token = "0x20000AF")]
public class Pickupable : Interactable
{
	[Token(Token = "0x20000B0")]
	public delegate void SnapEvent();

	[Token(Token = "0x20000B1")]
	public delegate void UnSnapEvent();

	[Token(Token = "0x20000B2")]
	public delegate void StaySnappedEvent();

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x50")]
	public bool resets;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x54")]
	public float resetTime;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x58")]
	public bool snapPosition;

	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x59")]
	public bool snapRotation;

	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x60")]
	public Transform snapPlane;

	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x68")]
	public Transform snapPoint;

	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x70")]
	public float pickupSpeed;

	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x0")]
	private static int trackFrames;

	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x4")]
	private static float trackFrameDecay;

	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x74")]
	private float resetTimer;

	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 lastPosition;

	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion lastRotation;

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x98")]
	private List<TrackInfo> trackInfo;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 origin;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0xAC")]
	private Quaternion originRot;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0xBC")]
	private bool dropped;

	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0xBD")]
	private bool initialized;

	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 leftHandOffset;

	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0xCC")]
	private Quaternion leftHandRotation;

	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 rightHandOffset;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0xE8")]
	private Quaternion rightHandRotation;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0xF8")]
	private bool snapped;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x118")]
	private Rigidbody rb;

	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 playArea;

	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x12C")]
	private bool isFootball;

	[Token(Token = "0x17000060")]
	public static int TrackedFrames
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xECB1A0", Offset = "0xECB1A0", VA = "0xECB1A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x14000001")]
	public event SnapEvent OnSnap
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xEC9640", Offset = "0xEC9640", VA = "0xEC9640")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E270C", Offset = "0x3E270C")]
		add
		{
		}
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xEC96E4", Offset = "0xEC96E4", VA = "0xEC96E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E271C", Offset = "0x3E271C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event UnSnapEvent OnUnSnap
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xEC9788", Offset = "0xEC9788", VA = "0xEC9788")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E272C", Offset = "0x3E272C")]
		add
		{
		}
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xEC982C", Offset = "0xEC982C", VA = "0xEC982C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E273C", Offset = "0x3E273C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event StaySnappedEvent OnStaySnapped
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEC98D0", Offset = "0xEC98D0", VA = "0xEC98D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E274C", Offset = "0x3E274C")]
		add
		{
		}
		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEC9974", Offset = "0xEC9974", VA = "0xEC9974")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E275C", Offset = "0x3E275C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xEC9A18", Offset = "0xEC9A18", VA = "0xEC9A18")]
	public void Init()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xEC9E0C", Offset = "0xEC9E0C", VA = "0xEC9E0C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xEC9E1C", Offset = "0xEC9E1C", VA = "0xEC9E1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xECB204", Offset = "0xECB204", VA = "0xECB204")]
	public int GetTrackedPointCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xECB320", Offset = "0xECB320", VA = "0xECB320", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xECB50C", Offset = "0xECB50C", VA = "0xECB50C", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xECABFC", Offset = "0xECABFC", VA = "0xECABFC")]
	private void Release()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xECAA10", Offset = "0xECAA10", VA = "0xECAA10")]
	private void AddTrackInfo(bool tracked)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xEC9C4C", Offset = "0xEC9C4C", VA = "0xEC9C4C")]
	private void ResetTrackInfo()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xECB520", Offset = "0xECB520", VA = "0xECB520")]
	public Pickupable()
	{
	}
}
[Token(Token = "0x20000B3")]
public class PlatformManager : MonoBehaviour
{
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x0")]
	public static string myID;

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x8")]
	public static string myOculusID;

	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x10")]
	private static PlatformManager instance;

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xECB68C", Offset = "0xECB68C", VA = "0xECB68C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xECBA90", Offset = "0xECBA90", VA = "0xECBA90")]
	private void InitCallback(Message<PlatformInitializeResult> msg)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xECB8A4", Offset = "0xECB8A4", VA = "0xECB8A4")]
	private static void CheckLanguage()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xECBC1C", Offset = "0xECBC1C", VA = "0xECBC1C")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xECBD88", Offset = "0xECBD88", VA = "0xECBD88")]
	public PlatformManager()
	{
	}
}
[Token(Token = "0x20000B4")]
public class PlaySoundOnHit : MonoBehaviour
{
	[Token(Token = "0x6000351")]
	[Address(RVA = "0xD3976C", Offset = "0xD3976C", VA = "0xD3976C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xD39820", Offset = "0xD39820", VA = "0xD39820")]
	public PlaySoundOnHit()
	{
	}
}
[Token(Token = "0x20000B5")]
public class PlayTestMode : Clickable
{
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF330", Offset = "0x3DF330")]
	private sealed class <StartPracticeMode>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xE9C59C", Offset = "0xE9C59C", VA = "0xE9C59C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xE9C5E4", Offset = "0xE9C5E4", VA = "0xE9C5E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xE9C36C", Offset = "0xE9C36C", VA = "0xE9C36C")]
		[DebuggerHidden]
		public <StartPracticeMode>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xE9C398", Offset = "0xE9C398", VA = "0xE9C398", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE9C39C", Offset = "0xE9C39C", VA = "0xE9C39C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xE9C5A4", Offset = "0xE9C5A4", VA = "0xE9C5A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xD39828", Offset = "0xD39828", VA = "0xD39828", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xD39854", Offset = "0xD39854", VA = "0xD39854")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E276C", Offset = "0x3E276C")]
	private IEnumerator StartPracticeMode()
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xD398B0", Offset = "0xD398B0", VA = "0xD398B0")]
	public PlayTestMode()
	{
	}
}
[Token(Token = "0x20000B7")]
public enum AssignmentType
{
	[Token(Token = "0x400037F")]
	Block,
	[Token(Token = "0x4000380")]
	Route
}
[Token(Token = "0x20000B8")]
public class FieldPoint
{
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x10")]
	private float xInternal;

	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x14")]
	public float y;

	[Token(Token = "0x17000063")]
	public float x
	{
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xD1B99C", Offset = "0xD1B99C", VA = "0xD1B99C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xD1BA20", Offset = "0xD1BA20", VA = "0xD1BA20")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public static FieldPoint Zero
	{
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD1BC00", Offset = "0xD1BC00", VA = "0xD1BC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xD1BAB4", Offset = "0xD1BAB4", VA = "0xD1BAB4")]
	public FieldPoint()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xD19CD4", Offset = "0xD19CD4", VA = "0xD19CD4")]
	public FieldPoint(float x, float y)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xD1BAE8", Offset = "0xD1BAE8", VA = "0xD1BAE8")]
	public static FieldPoint operator +(FieldPoint a, FieldPoint b)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xD19D18", Offset = "0xD19D18", VA = "0xD19D18")]
	public static FieldPoint operator *(FieldPoint a, float b)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xD1BBA4", Offset = "0xD1BBA4", VA = "0xD1BBA4")]
	public static implicit operator Vector2(FieldPoint point)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xD1BBD0", Offset = "0xD1BBD0", VA = "0xD1BBD0")]
	public static implicit operator Vector3(FieldPoint point)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x20000B9")]
public class Assignment
{
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x10")]
	public AssignmentType type;

	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x18")]
	public FieldPoint start;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "XmlArrayItemAttribute", RVA = "0x3E0CBC", Offset = "0x3E0CBC")]
	[AttributeAttribute(Name = "XmlArrayAttribute", RVA = "0x3E0CBC", Offset = "0x3E0CBC")]
	public List<FieldPoint> route;

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xBFF2AC", Offset = "0xBFF2AC", VA = "0xBFF2AC")]
	public Assignment()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xBFF338", Offset = "0xBFF338", VA = "0xBFF338")]
	public Assignment(AssignmentType type, bool relative, FieldPoint start, List<FieldPoint> route)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xBFF378", Offset = "0xBFF378", VA = "0xBFF378")]
	public Vector3 RouteWaypoint(int index)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x20000BA")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x3DF340", Offset = "0x3DF340")]
public class Play
{
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "XmlArrayItemAttribute", RVA = "0x3E0D1C", Offset = "0x3E0D1C")]
	[AttributeAttribute(Name = "XmlArrayAttribute", RVA = "0x3E0D1C", Offset = "0x3E0D1C")]
	public List<Assignment> assignments;

	[Token(Token = "0x17000065")]
	public Assignment Item
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD39614", Offset = "0xD39614", VA = "0xD39614")]
		get
		{
			return null;
		}
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD39688", Offset = "0xD39688", VA = "0xD39688")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public int Count
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xD396F4", Offset = "0xD396F4", VA = "0xD396F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xD395A4", Offset = "0xD395A4", VA = "0xD395A4")]
	public Play()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xD39740", Offset = "0xD39740", VA = "0xD39740")]
	public Play(List<Assignment> assignments)
	{
	}
}
[Token(Token = "0x20000BB")]
[AttributeAttribute(Name = "XmlRootAttribute", RVA = "0x3DF378", Offset = "0x3DF378")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x3DF378", Offset = "0x3DF378")]
public class Plays
{
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "XmlArrayAttribute", RVA = "0x3E0D7C", Offset = "0x3E0D7C")]
	[AttributeAttribute(Name = "XmlArrayItemAttribute", RVA = "0x3E0D7C", Offset = "0x3E0D7C")]
	public List<Play> plays;

	[Token(Token = "0x17000067")]
	public Play Item
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD3A2F0", Offset = "0xD3A2F0", VA = "0xD3A2F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD3A364", Offset = "0xD3A364", VA = "0xD3A364")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public int Count
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xD3A8D4", Offset = "0xD3A8D4", VA = "0xD3A8D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xD44AD4", Offset = "0xD44AD4", VA = "0xD44AD4")]
	public Plays()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xD44B50", Offset = "0xD44B50", VA = "0xD44B50")]
	public Plays(List<Play> plays)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xD3A920", Offset = "0xD3A920", VA = "0xD3A920")]
	public void Save()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xD3A690", Offset = "0xD3A690", VA = "0xD3A690")]
	public static Plays LoadFile(string path)
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xD3A068", Offset = "0xD3A068", VA = "0xD3A068")]
	public static Plays LoadResource(string name)
	{
		return null;
	}
}
[Token(Token = "0x20000BC")]
public static class Playbook
{
	[Token(Token = "0x20000BD")]
	public delegate void OnPlayChange();

	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x0")]
	[XmlIgnore]
	public static int index;

	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x8")]
	public static OnPlayChange playChanged;

	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x10")]
	private static Plays plays;

	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x18")]
	private static Plays fieldGoalPlays;

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xD398B8", Offset = "0xD398B8", VA = "0xD398B8")]
	public static Assignment GetAssignment(int i)
	{
		return null;
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xD39A20", Offset = "0xD39A20", VA = "0xD39A20")]
	public static void ChangePlay(int playNum)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xD39F4C", Offset = "0xD39F4C", VA = "0xD39F4C")]
	public static void ResetPlayToDefault()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xD3A43C", Offset = "0xD3A43C", VA = "0xD3A43C")]
	static Playbook()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xD3A3D0", Offset = "0xD3A3D0", VA = "0xD3A3D0")]
	public static void Save()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BE")]
public class PlayerStats
{
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x10")]
	public bool offense;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x14")]
	public int strength;

	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x18")]
	public int size;

	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x1C")]
	public int speed;

	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x20")]
	public float speedBoost;

	[Token(Token = "0x17000069")]
	public int scale
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xD44104", Offset = "0xD44104", VA = "0xD44104")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700006A")]
	public float pushForce
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD415B4", Offset = "0xD415B4", VA = "0xD415B4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006B")]
	public float mass
	{
		[Token(Token = "0x6000380")]
		[Address(RVA = "0xD3AEAC", Offset = "0xD3AEAC", VA = "0xD3AEAC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006C")]
	public float maxSpeed
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD3EBD0", Offset = "0xD3EBD0", VA = "0xD3EBD0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006D")]
	public float tackleDist
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xD3F08C", Offset = "0xD3F08C", VA = "0xD3F08C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006E")]
	public float acceleration
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xD40398", Offset = "0xD40398", VA = "0xD40398")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006F")]
	public float deceleration
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xD40344", Offset = "0xD40344", VA = "0xD40344")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xD441BC", Offset = "0xD441BC", VA = "0xD441BC")]
	public PlayerStats()
	{
	}
}
[Token(Token = "0x20000BF")]
public class PlayerAI : MonoBehaviour
{
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x0")]
	public static bool[] inMotion;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x1C")]
	public bool isOffense;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x20")]
	public PlayerStats stats;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> blockSounds;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource tackleAudioSource;

	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x38")]
	public Transform model;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x40")]
	public PhysicMaterial noFric;

	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x48")]
	public PhysicMaterial fric;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x50")]
	private float lookSpeed;

	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x54")]
	private float collisionSoundThreshold;

	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x58")]
	private float tackleHeight;

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x5C")]
	private float tackleForce;

	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x60")]
	private float tackleAngularForce;

	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x64")]
	private float getUpTime;

	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x68")]
	private int routeIndex;

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x6C")]
	private float getUpTimer;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x70")]
	private float immunity;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 routeStart;

	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x80")]
	private bool tackled;

	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x88")]
	private Transform football;

	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x90")]
	private Rigidbody footballRb;

	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x98")]
	private Transform qb;

	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0xA0")]
	private Rigidbody qbRb;

	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0xA8")]
	private List<Transform> opponents;

	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0xB0")]
	private List<Transform> teammates;

	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0xB8")]
	private List<Transform> blockers;

	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0xC0")]
	private float prevZ;

	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0xC4")]
	private float timeSinceProgress;

	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0xC8")]
	private bool handoff;

	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 moveTarget;

	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 lookTarget;

	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0xE4")]
	private Vector3 moveTargetVelocity;

	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0xF0")]
	public Transform moveTargetIndicator;

	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0xF8")]
	private Rigidbody rb;

	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x100")]
	private PlayerAnimationController pac;

	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x108")]
	private Collider[] colliders;

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xD3ABF4", Offset = "0xD3ABF4", VA = "0xD3ABF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xD3AEE8", Offset = "0xD3AEE8", VA = "0xD3AEE8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xD3F0EC", Offset = "0xD3F0EC", VA = "0xD3F0EC")]
	private void ApplyMovement()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xD401E0", Offset = "0xD401E0", VA = "0xD401E0")]
	private float ETA()
	{
		return default(float);
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xD3FA14", Offset = "0xD3FA14", VA = "0xD3FA14")]
	private void Move()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xD403E0", Offset = "0xD403E0", VA = "0xD403E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xD404D4", Offset = "0xD404D4", VA = "0xD404D4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xD405C4", Offset = "0xD405C4", VA = "0xD405C4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xD41640", Offset = "0xD41640", VA = "0xD41640")]
	public void BreakStiffArm()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xD3E010", Offset = "0xD3E010", VA = "0xD3E010")]
	private bool TeammateInSpot(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xD3E1F8", Offset = "0xD3E1F8", VA = "0xD3E1F8")]
	public Transform ClosestOpponent(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xD41848", Offset = "0xD41848", VA = "0xD41848")]
	public Transform ClosestOpponentDownFieldOf(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xD41A50", Offset = "0xD41A50", VA = "0xD41A50")]
	private SpaceTime CoverSpaceTime(Vector3 targetVel)
	{
		return null;
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xD3E50C", Offset = "0xD3E50C", VA = "0xD3E50C")]
	public Vector3 CalculateCoverageLead(Transform target, Vector3 fallback)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xD3E3D8", Offset = "0xD3E3D8", VA = "0xD3E3D8")]
	public Vector3 CalculateLead(Transform target, Vector3 fallback)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xD3E854", Offset = "0xD3E854", VA = "0xD3E854")]
	public Vector3 CalculateLead(Vector3 targetPos, Vector3 velocity, Vector3 fallback)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xD41F10", Offset = "0xD41F10", VA = "0xD41F10")]
	private Vector3 FootballLandingLocation(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xD41F80", Offset = "0xD41F80", VA = "0xD41F80")]
	private float[] QuadraticRoots(float a, float b, float c)
	{
		return null;
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xD4206C", Offset = "0xD4206C", VA = "0xD4206C")]
	public float FootballLandingTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xD42390", Offset = "0xD42390", VA = "0xD42390")]
	private float TimeTillCollision(Transform target)
	{
		return default(float);
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xD4259C", Offset = "0xD4259C", VA = "0xD4259C")]
	private Vector3 Angle(Transform tackler)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xD3EC80", Offset = "0xD3EC80", VA = "0xD3EC80")]
	private Vector3 BestAngle()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xD42C5C", Offset = "0xD42C5C", VA = "0xD42C5C")]
	private bool IsFacing(Transform target)
	{
		return default(bool);
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xD3EB3C", Offset = "0xD3EB3C", VA = "0xD3EB3C")]
	private bool IsInFrontOf(Transform target)
	{
		return default(bool);
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xD42B30", Offset = "0xD42B30", VA = "0xD42B30")]
	private bool IsInTacklBox()
	{
		return default(bool);
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xD414CC", Offset = "0xD414CC", VA = "0xD414CC")]
	private bool CanShove(int playerIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xD42D14", Offset = "0xD42D14", VA = "0xD42D14")]
	public PlayerAI()
	{
	}
}
[Token(Token = "0x20000C0")]
public class PlayerAnimationController : MonoBehaviour
{
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x18")]
	public bool takesStanceBeforeSnap;

	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x20")]
	public string randomFrameAnimationName;

	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x0")]
	public static bool wonGame;

	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x30")]
	private Animator anim;

	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E0DEC", Offset = "0x3E0DEC")]
	private bool <HasRoute>k__BackingField;

	[Token(Token = "0x17000070")]
	public bool HasRoute
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD42ED0", Offset = "0xD42ED0", VA = "0xD42ED0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E281C", Offset = "0x3E281C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD42ED8", Offset = "0xD42ED8", VA = "0xD42ED8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E282C", Offset = "0x3E282C")]
		set
		{
		}
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xD42EE4", Offset = "0xD42EE4", VA = "0xD42EE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xD430C8", Offset = "0xD430C8", VA = "0xD430C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xD400C0", Offset = "0xD400C0", VA = "0xD400C0")]
	public void Running(bool isRunning)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xD431F0", Offset = "0xD431F0", VA = "0xD431F0")]
	public void TakeStance(bool inStance)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xD43060", Offset = "0xD43060", VA = "0xD43060")]
	public void Defeated(bool defeated)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xD42FF8", Offset = "0xD42FF8", VA = "0xD42FF8")]
	public void Celebrate(bool celebrating)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xD41474", Offset = "0xD41474", VA = "0xD41474")]
	public void GotTackled()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xD3F094", Offset = "0xD3F094", VA = "0xD3F094")]
	public void Tackling()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xD3EC18", Offset = "0xD3EC18", VA = "0xD3EC18")]
	public void Catch(bool caughtBall)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xD415E8", Offset = "0xD415E8", VA = "0xD415E8")]
	public void Pushing()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xD43258", Offset = "0xD43258", VA = "0xD43258")]
	public PlayerAnimationController()
	{
	}
}
[Token(Token = "0x20000C1")]
public class PlayerSlider : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF3D8", Offset = "0x3DF3D8")]
	private sealed class <PerformRedraw>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSlider <>4__this;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 <fromPoint>5__2;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x30")]
		private List<FieldPoint>.Enumerator <>7__wrap2;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xE9CBFC", Offset = "0xE9CBFC", VA = "0xE9CBFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xE9CC44", Offset = "0xE9CC44", VA = "0xE9CC44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE9C840", Offset = "0xE9C840", VA = "0xE9C840")]
		[DebuggerHidden]
		public <PerformRedraw>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xE9C86C", Offset = "0xE9C86C", VA = "0xE9C86C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xE9C8DC", Offset = "0xE9C8DC", VA = "0xE9C8DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xE9C888", Offset = "0xE9C888", VA = "0xE9C888")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xE9CC04", Offset = "0xE9CC04", VA = "0xE9CC04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x0")]
	public static float whiteBoardScale;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x18")]
	public float xMin;

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x1C")]
	public float xMax;

	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x20")]
	public float yMin;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x24")]
	public float yMax;

	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x28")]
	public int playerIndex;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x30")]
	public Transform markJoint;

	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x38")]
	public Transform mark;

	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x40")]
	public Transform routeContainer;

	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x48")]
	private int currentPlay;

	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x4C")]
	private bool flipped;

	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x4D")]
	public bool activated;

	[Token(Token = "0x17000071")]
	public int index
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xD432B0", Offset = "0xD432B0", VA = "0xD432B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xD432B8", Offset = "0xD432B8", VA = "0xD432B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xD432FC", Offset = "0xD432FC", VA = "0xD432FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xD43524", Offset = "0xD43524", VA = "0xD43524")]
	public void Activate()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xD43860", Offset = "0xD43860", VA = "0xD43860")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xD43594", Offset = "0xD43594", VA = "0xD43594")]
	public void DestroyRoute()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xD43A4C", Offset = "0xD43A4C", VA = "0xD43A4C")]
	public void DrawLine(Vector3 fromPoint, Vector3 toPoint)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xD432BC", Offset = "0xD432BC", VA = "0xD432BC")]
	public void ReDrawRoute()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xD43D04", Offset = "0xD43D04", VA = "0xD43D04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E283C", Offset = "0x3E283C")]
	private IEnumerator PerformRedraw()
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xD43D70", Offset = "0xD43D70", VA = "0xD43D70")]
	public PlayerSlider()
	{
	}
}
[Token(Token = "0x20000C3")]
public class PlayerSliderTarget : Interactable
{
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x50")]
	public Transform slider;

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xD43DD4", Offset = "0xD43DD4", VA = "0xD43DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xD44010", Offset = "0xD44010", VA = "0xD44010", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xD4406C", Offset = "0xD4406C", VA = "0xD4406C", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xD440FC", Offset = "0xD440FC", VA = "0xD440FC")]
	public PlayerSliderTarget()
	{
	}
}
[Token(Token = "0x20000C4")]
public class PlayerTypeFlipper : MonoBehaviour
{
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] bodies;

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xD441C4", Offset = "0xD441C4", VA = "0xD441C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xD44318", Offset = "0xD44318", VA = "0xD44318")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xD4446C", Offset = "0xD4446C", VA = "0xD4446C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xD44470", Offset = "0xD44470", VA = "0xD44470")]
	private void FlipType()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xD4455C", Offset = "0xD4455C", VA = "0xD4455C")]
	public PlayerTypeFlipper()
	{
	}
}
[Token(Token = "0x20000C5")]
public class PlayerTypeSlider : Interactable
{
	[Token(Token = "0x20000C6")]
	public delegate void PlayerChangeDelegate();

	[Token(Token = "0x40003CF")]
	private const float MIN_POSITION = -0.1181f;

	[Token(Token = "0x40003D0")]
	private const float MAX_POSITION = 0.12f;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x5C")]
	public int numberOfOptions;

	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerChangeDelegate OnPlayerTypeChange;

	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x60")]
	private float increment;

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x64")]
	private float range;

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xD44564", Offset = "0xD44564", VA = "0xD44564")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xD44630", Offset = "0xD44630", VA = "0xD44630")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xD446FC", Offset = "0xD446FC", VA = "0xD446FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xD447EC", Offset = "0xD447EC", VA = "0xD447EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xD449A8", Offset = "0xD449A8", VA = "0xD449A8", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xD449AC", Offset = "0xD449AC", VA = "0xD449AC", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xD44AA0", Offset = "0xD44AA0", VA = "0xD44AA0")]
	public PlayerTypeSlider()
	{
	}
}
[Token(Token = "0x20000C7")]
public class PlusIcon : MonoBehaviour
{
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x18")]
	public Transform number;

	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x20")]
	public float maxSize;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x24")]
	public float duration;

	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x28")]
	private float timePassed;

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xD44B7C", Offset = "0xD44B7C", VA = "0xD44B7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xD44C04", Offset = "0xD44C04", VA = "0xD44C04")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xD44C9C", Offset = "0xD44C9C", VA = "0xD44C9C")]
	public PlusIcon()
	{
	}
}
[Token(Token = "0x20000C8")]
public class PointPopup : MonoBehaviour
{
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xD44CB0", Offset = "0xD44CB0", VA = "0xD44CB0")]
	public void SetText(int value)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xD44D5C", Offset = "0xD44D5C", VA = "0xD44D5C")]
	public void DestroyPopup()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xD44DD4", Offset = "0xD44DD4", VA = "0xD44DD4")]
	public PointPopup()
	{
	}
}
[Token(Token = "0x20000C9")]
public class PopUpMessage : MonoBehaviour
{
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x18")]
	public Image icon;

	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x20")]
	public Text title;

	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x28")]
	public Text description;

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xD44E1C", Offset = "0xD44E1C", VA = "0xD44E1C")]
	public void SetMessage(Sprite icon, string title, string description)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xD44E90", Offset = "0xD44E90", VA = "0xD44E90")]
	public void DestroyPopUp()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xD44F08", Offset = "0xD44F08", VA = "0xD44F08")]
	public PopUpMessage()
	{
	}
}
[Token(Token = "0x20000CA")]
public class PopUp
{
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x10")]
	public int icon;

	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x18")]
	public string title;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xD44DDC", Offset = "0xD44DDC", VA = "0xD44DDC")]
	public PopUp(int icon, string title, string description)
	{
	}
}
[Token(Token = "0x20000CB")]
public class PopUpSystem : MonoBehaviour
{
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x0")]
	private static List<PopUp> messageQueue;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x18")]
	public Transform popUpPreab;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x20")]
	public Sprite[] icons;

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x28")]
	private Transform currentPopUp;

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xD44F10", Offset = "0xD44F10", VA = "0xD44F10")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xD451C4", Offset = "0xD451C4", VA = "0xD451C4")]
	public static void QueueMessage(int icon, string title, string description)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xD4529C", Offset = "0xD4529C", VA = "0xD4529C")]
	public PopUpSystem()
	{
	}
}
[Token(Token = "0x20000CC")]
public class PracticeMode : Clickable
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF3E8", Offset = "0x3DF3E8")]
	private sealed class <StartPracticeMode>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xE9D08C", Offset = "0xE9D08C", VA = "0xE9D08C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xE9D0D4", Offset = "0xE9D0D4", VA = "0xE9D0D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xE9CEA0", Offset = "0xE9CEA0", VA = "0xE9CEA0")]
		[DebuggerHidden]
		public <StartPracticeMode>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xE9CECC", Offset = "0xE9CECC", VA = "0xE9CECC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xE9CED0", Offset = "0xE9CED0", VA = "0xE9CED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xE9D094", Offset = "0xE9D094", VA = "0xE9D094", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xD46B34", Offset = "0xD46B34", VA = "0xD46B34", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xD46B78", Offset = "0xD46B78", VA = "0xD46B78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E28EC", Offset = "0x3E28EC")]
	private IEnumerator StartPracticeMode()
	{
		return null;
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xD46BD4", Offset = "0xD46BD4", VA = "0xD46BD4")]
	public PracticeMode()
	{
	}
}
[Token(Token = "0x20000CE")]
public class Pupper : Interactable
{
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xD46BDC", Offset = "0xD46BDC", VA = "0xD46BDC", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xD46BE0", Offset = "0xD46BE0", VA = "0xD46BE0", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xD46BE4", Offset = "0xD46BE4", VA = "0xD46BE4")]
	public Pupper()
	{
	}
}
[Token(Token = "0x20000CF")]
public class QB : MonoBehaviour
{
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x18")]
	public Transform awardMarker;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x20")]
	public Transform moveTarget;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x28")]
	public Transform cameraRig;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x0")]
	public static Transform playArea;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x8")]
	public static bool tackled;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x9")]
	public static bool heightChanged;

	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0xC")]
	public static float lastHeightAdjustment;

	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x10")]
	public static float lookAngle;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x30")]
	private string activeScene;

	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 nonFlippedEulers;

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xD46BEC", Offset = "0xD46BEC", VA = "0xD46BEC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xD46E88", Offset = "0xD46E88", VA = "0xD46E88")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xD47410", Offset = "0xD47410", VA = "0xD47410")]
	public QB()
	{
	}
}
[Token(Token = "0x20000D0")]
public class QBChallengeMode : Clickable
{
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF3F8", Offset = "0x3DF3F8")]
	private sealed class <StartPracticeMode>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xE9D2C8", Offset = "0xE9D2C8", VA = "0xE9D2C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xE9D310", Offset = "0xE9D310", VA = "0xE9D310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xE9D0DC", Offset = "0xE9D0DC", VA = "0xE9D0DC")]
		[DebuggerHidden]
		public <StartPracticeMode>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xE9D108", Offset = "0xE9D108", VA = "0xE9D108", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xE9D10C", Offset = "0xE9D10C", VA = "0xE9D10C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xE9D2D0", Offset = "0xE9D2D0", VA = "0xE9D2D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xD4741C", Offset = "0xD4741C", VA = "0xD4741C", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xD47448", Offset = "0xD47448", VA = "0xD47448")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E299C", Offset = "0x3E299C")]
	private IEnumerator StartPracticeMode()
	{
		return null;
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xD474A4", Offset = "0xD474A4", VA = "0xD474A4")]
	public QBChallengeMode()
	{
	}
}
[Token(Token = "0x20000D2")]
public class QBFGMode : Clickable
{
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF408", Offset = "0x3DF408")]
	private sealed class <StartPracticeMode>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xE9D510", Offset = "0xE9D510", VA = "0xE9D510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xE9D558", Offset = "0xE9D558", VA = "0xE9D558", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xE9D318", Offset = "0xE9D318", VA = "0xE9D318")]
		[DebuggerHidden]
		public <StartPracticeMode>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xE9D344", Offset = "0xE9D344", VA = "0xE9D344", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xE9D348", Offset = "0xE9D348", VA = "0xE9D348", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xE9D518", Offset = "0xE9D518", VA = "0xE9D518", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xD474AC", Offset = "0xD474AC", VA = "0xD474AC", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xD474D8", Offset = "0xD474D8", VA = "0xD474D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2A4C", Offset = "0x3E2A4C")]
	private IEnumerator StartPracticeMode()
	{
		return null;
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xD47534", Offset = "0xD47534", VA = "0xD47534")]
	public QBFGMode()
	{
	}
}
[Token(Token = "0x20000D4")]
public class QB_MoveTarget : MonoBehaviour
{
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x18")]
	private bool runningEnabled;

	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x20")]
	public QB qbScript;

	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x28")]
	public VignetteAndChromaticAberration vignetteL;

	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x30")]
	public VignetteAndChromaticAberration vignetteR;

	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x38")]
	public PlayerStats stats;

	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x40")]
	public float receiverSpeedIncrease;

	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x44")]
	public float timeTilNormalSpeed;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 moveTarget;

	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 moveTargetVelocity;

	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x60")]
	public float vignetteIntensityMin;

	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x64")]
	public float vignetteIntensityMax;

	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x68")]
	public float vignetteLerpSpeed;

	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x6C")]
	private float startY;

	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x70")]
	private int baseSpeed;

	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x0")]
	private static float timeAtIncreasedSpeed;

	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x4")]
	private static bool isReceiver;

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x78")]
	private AudioSource runAudio;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x80")]
	private Rigidbody rb;

	[Token(Token = "0x1700007A")]
	public static bool IsReceiver
	{
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD4753C", Offset = "0xD4753C", VA = "0xD4753C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD47374", Offset = "0xD47374", VA = "0xD47374")]
		set
		{
		}
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xD475A0", Offset = "0xD475A0", VA = "0xD475A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xD47648", Offset = "0xD47648", VA = "0xD47648")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xD48668", Offset = "0xD48668", VA = "0xD48668")]
	private float ETA()
	{
		return default(float);
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xD4823C", Offset = "0xD4823C", VA = "0xD4823C")]
	private void Move()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xD487CC", Offset = "0xD487CC", VA = "0xD487CC")]
	public QB_MoveTarget()
	{
	}
}
[Token(Token = "0x20000D5")]
public class Quest1Unload : MonoBehaviour
{
	[Token(Token = "0x600040E")]
	[Address(RVA = "0xD4918C", Offset = "0xD4918C", VA = "0xD4918C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xD4921C", Offset = "0xD4921C", VA = "0xD4921C")]
	public Quest1Unload()
	{
	}
}
[Token(Token = "0x20000D6")]
public class QuestPlayersLOD : MonoBehaviour
{
	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Quest1Offense;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Quest1Defense;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Quest1Celebration;

	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Quest2Offense;

	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Quest2Defense;

	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Quest2Celebration;

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xD49224", Offset = "0xD49224", VA = "0xD49224")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xD49354", Offset = "0xD49354", VA = "0xD49354")]
	public QuestPlayersLOD()
	{
	}
}
[Token(Token = "0x20000D7")]
public class RandomAudioSource : MonoBehaviour
{
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x18")]
	public List<AudioClip> clips;

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xD4935C", Offset = "0xD4935C", VA = "0xD4935C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xD49428", Offset = "0xD49428", VA = "0xD49428")]
	public RandomAudioSource()
	{
	}
}
[Token(Token = "0x20000D8")]
public class RandomChild : MonoBehaviour
{
	[Token(Token = "0x6000414")]
	[Address(RVA = "0xD494A0", Offset = "0xD494A0", VA = "0xD494A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xD49548", Offset = "0xD49548", VA = "0xD49548")]
	public RandomChild()
	{
	}
}
[Token(Token = "0x20000D9")]
public class RandomMesh : MonoBehaviour
{
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x18")]
	public Mesh[] meshes;

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xD49550", Offset = "0xD49550", VA = "0xD49550")]
	private void Start()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xD495EC", Offset = "0xD495EC", VA = "0xD495EC")]
	public RandomMesh()
	{
	}
}
[Token(Token = "0x20000DA")]
public class ReceiverChallengeMode : Clickable
{
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF418", Offset = "0x3DF418")]
	private sealed class <StartPracticeMode>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xE9D750", Offset = "0xE9D750", VA = "0xE9D750", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xE9D798", Offset = "0xE9D798", VA = "0xE9D798", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xE9D560", Offset = "0xE9D560", VA = "0xE9D560")]
		[DebuggerHidden]
		public <StartPracticeMode>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xE9D58C", Offset = "0xE9D58C", VA = "0xE9D58C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xE9D590", Offset = "0xE9D590", VA = "0xE9D590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xE9D758", Offset = "0xE9D758", VA = "0xE9D758", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xD49674", Offset = "0xD49674", VA = "0xD49674", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xD496A0", Offset = "0xD496A0", VA = "0xD496A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2AFC", Offset = "0x3E2AFC")]
	private IEnumerator StartPracticeMode()
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xD496FC", Offset = "0xD496FC", VA = "0xD496FC")]
	public ReceiverChallengeMode()
	{
	}
}
[Token(Token = "0x20000DC")]
public class Resetable : MonoBehaviour
{
	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x18")]
	private Transform parent;

	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 localPosition;

	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion localRotation;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x3C")]
	private RigidbodyConstraints rbConstraints;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x40")]
	private int layer;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x48")]
	private string startTag;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x50")]
	private bool isKinematic;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x51")]
	private bool detectCollision;

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xD49704", Offset = "0xD49704", VA = "0xD49704")]
	private void Start()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xD49930", Offset = "0xD49930", VA = "0xD49930")]
	public void OnReset()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xD49C3C", Offset = "0xD49C3C", VA = "0xD49C3C")]
	public Resetable()
	{
	}
}
[Token(Token = "0x20000DD")]
public class RingCounter : MonoBehaviour
{
	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x18")]
	public Text ringsHitCounter;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x20")]
	public Text streakCounter;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x28")]
	public Text hitsPerMinuteCounter;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x30")]
	public Text highestHPMDisplay;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x38")]
	public float hitsPerMinuteUpdateInterval;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x3C")]
	public int hitsPerMinuteMinThrows;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x0")]
	public static int ringsHit;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x4")]
	public static int highestStreak;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x8")]
	private static float highestHPM;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x40")]
	private float firstThrowTime;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x44")]
	private float nextHPMUpdate;

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xD49CB8", Offset = "0xD49CB8", VA = "0xD49CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xD49D1C", Offset = "0xD49D1C", VA = "0xD49D1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xD49F24", Offset = "0xD49F24", VA = "0xD49F24")]
	public RingCounter()
	{
	}
}
[Token(Token = "0x20000DE")]
public class RotateObject : MonoBehaviour
{
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x20")]
	public int speed;

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xD49F38", Offset = "0xD49F38", VA = "0xD49F38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xD4A020", Offset = "0xD4A020", VA = "0xD4A020")]
	private void Update()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xD4A0F0", Offset = "0xD4A0F0", VA = "0xD4A0F0")]
	public RotateObject()
	{
	}
}
[Token(Token = "0x20000DF")]
public class RoundAudioClip : MonoBehaviour
{
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] roundNumberClips;

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xD4A0F8", Offset = "0xD4A0F8", VA = "0xD4A0F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xD4A1E8", Offset = "0xD4A1E8", VA = "0xD4A1E8")]
	public RoundAudioClip()
	{
	}
}
[Token(Token = "0x20000E0")]
public class SC_CountdownTimer : MonoBehaviour
{
	[Token(Token = "0x20000E1")]
	public enum CountdownFormatting
	{
		[Token(Token = "0x400042E")]
		DaysHoursMinutesSeconds,
		[Token(Token = "0x400042F")]
		HoursMinutesSeconds,
		[Token(Token = "0x4000430")]
		MinutesSeconds,
		[Token(Token = "0x4000431")]
		Seconds
	}

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x18")]
	public CountdownFormatting countdownFormatting;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x1C")]
	public bool showMilliseconds;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x20")]
	public double countdownTime;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x28")]
	private Text countdownText;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x30")]
	private double countdownInternal;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x38")]
	private bool countdownOver;

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xD4A1F0", Offset = "0xD4A1F0", VA = "0xD4A1F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xD4A248", Offset = "0xD4A248", VA = "0xD4A248")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xD4A34C", Offset = "0xD4A34C", VA = "0xD4A34C")]
	private string FormatTime(double time, CountdownFormatting formatting, bool includeMilliseconds)
	{
		return null;
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xD4AA14", Offset = "0xD4AA14", VA = "0xD4AA14")]
	public SC_CountdownTimer()
	{
	}
}
[Token(Token = "0x20000E2")]
public class SceneLoader : MonoBehaviour
{
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF428", Offset = "0x3DF428")]
	private sealed class <FadeVolumeOut>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xE9DCE8", Offset = "0xE9DCE8", VA = "0xE9DCE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xE9DD30", Offset = "0xE9DD30", VA = "0xE9DD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xE9DBB4", Offset = "0xE9DBB4", VA = "0xE9DBB4")]
		[DebuggerHidden]
		public <FadeVolumeOut>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xE9DBE0", Offset = "0xE9DBE0", VA = "0xE9DBE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xE9DBE4", Offset = "0xE9DBE4", VA = "0xE9DBE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xE9DCF0", Offset = "0xE9DCF0", VA = "0xE9DCF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF438", Offset = "0x3DF438")]
	private sealed class <FadeVolumeIn>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xE9DB64", Offset = "0xE9DB64", VA = "0xE9DB64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xE9DBAC", Offset = "0xE9DBAC", VA = "0xE9DBAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xE9DA38", Offset = "0xE9DA38", VA = "0xE9DA38")]
		[DebuggerHidden]
		public <FadeVolumeIn>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xE9DA64", Offset = "0xE9DA64", VA = "0xE9DA64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xE9DA68", Offset = "0xE9DA68", VA = "0xE9DA68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xE9DB6C", Offset = "0xE9DB6C", VA = "0xE9DB6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF448", Offset = "0x3DF448")]
	private sealed class <FadeIn>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x17000082")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xE9D9E8", Offset = "0xE9D9E8", VA = "0xE9D9E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xE9DA30", Offset = "0xE9DA30", VA = "0xE9DA30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xE9D7A0", Offset = "0xE9D7A0", VA = "0xE9D7A0")]
		[DebuggerHidden]
		public <FadeIn>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xE9D7CC", Offset = "0xE9D7CC", VA = "0xE9D7CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xE9D7D0", Offset = "0xE9D7D0", VA = "0xE9D7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xE9D9F0", Offset = "0xE9D9F0", VA = "0xE9D9F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF458", Offset = "0x3DF458")]
	private sealed class <LoadLevel>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x17000084")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xE9DEE8", Offset = "0xE9DEE8", VA = "0xE9DEE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xE9DF30", Offset = "0xE9DF30", VA = "0xE9DF30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xE9DD38", Offset = "0xE9DD38", VA = "0xE9DD38")]
		[DebuggerHidden]
		public <LoadLevel>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xE9DD64", Offset = "0xE9DD64", VA = "0xE9DD64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xE9DD68", Offset = "0xE9DD68", VA = "0xE9DD68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xE9DEF0", Offset = "0xE9DEF0", VA = "0xE9DEF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x18")]
	public string scene;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x20")]
	public bool autoActivate;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x24")]
	public float autoActivateTime;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x28")]
	public bool preload;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x30")]
	public AudioMixer audioManager;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x0")]
	public static bool doneFading;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x1")]
	private static bool activating;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x8")]
	private static string sceneName;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x38")]
	private bool activated;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x39")]
	private bool initComplete;

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x10")]
	private static AsyncOperation loader;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x3C")]
	private float activateAt;

	[Token(Token = "0x1700007D")]
	public static float LoadPercentage
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0xB281E8", Offset = "0xB281E8", VA = "0xB281E8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xB27AB4", Offset = "0xB27AB4", VA = "0xB27AB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xB28044", Offset = "0xB28044", VA = "0xB28044")]
	private void Update()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xB283A0", Offset = "0xB283A0", VA = "0xB283A0")]
	public void BeginLoad()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xB28464", Offset = "0xB28464", VA = "0xB28464")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2BAC", Offset = "0x3E2BAC")]
	private IEnumerator FadeVolumeOut()
	{
		return null;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xB284D0", Offset = "0xB284D0", VA = "0xB284D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2C0C", Offset = "0x3E2C0C")]
	private IEnumerator FadeVolumeIn()
	{
		return null;
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0xB27FD8", Offset = "0xB27FD8", VA = "0xB27FD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2C6C", Offset = "0x3E2C6C")]
	private IEnumerator FadeIn()
	{
		return null;
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xB28334", Offset = "0xB28334", VA = "0xB28334")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2CCC", Offset = "0x3E2CCC")]
	private IEnumerator LoadLevel()
	{
		return null;
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0xB28298", Offset = "0xB28298", VA = "0xB28298")]
	public static void Activate()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xB2853C", Offset = "0xB2853C", VA = "0xB2853C")]
	public static void Activate(string scene)
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xB27D80", Offset = "0xB27D80", VA = "0xB27D80")]
	private static string GetSceneName(string fieldName)
	{
		return null;
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xB28718", Offset = "0xB28718", VA = "0xB28718")]
	public SceneLoader()
	{
	}
}
[Token(Token = "0x20000E7")]
public class SceneLoaderTitle : MonoBehaviour
{
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF468", Offset = "0x3DF468")]
	private sealed class <FadeVolumeOut>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoaderTitle <>4__this;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xE9E3A8", Offset = "0xE9E3A8", VA = "0xE9E3A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xE9E3F0", Offset = "0xE9E3F0", VA = "0xE9E3F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xE9E274", Offset = "0xE9E274", VA = "0xE9E274")]
		[DebuggerHidden]
		public <FadeVolumeOut>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xE9E2A0", Offset = "0xE9E2A0", VA = "0xE9E2A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xE9E2A4", Offset = "0xE9E2A4", VA = "0xE9E2A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xE9E3B0", Offset = "0xE9E3B0", VA = "0xE9E3B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF478", Offset = "0x3DF478")]
	private sealed class <FadeVolumeIn>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoaderTitle <>4__this;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xE9E224", Offset = "0xE9E224", VA = "0xE9E224", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xE9E26C", Offset = "0xE9E26C", VA = "0xE9E26C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xE9E0F8", Offset = "0xE9E0F8", VA = "0xE9E0F8")]
		[DebuggerHidden]
		public <FadeVolumeIn>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xE9E124", Offset = "0xE9E124", VA = "0xE9E124", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xE9E128", Offset = "0xE9E128", VA = "0xE9E128", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xE9E22C", Offset = "0xE9E22C", VA = "0xE9E22C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF488", Offset = "0x3DF488")]
	private sealed class <FadeIn>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoaderTitle <>4__this;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0xE9E0A8", Offset = "0xE9E0A8", VA = "0xE9E0A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0xE9E0F0", Offset = "0xE9E0F0", VA = "0xE9E0F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xE9DF38", Offset = "0xE9DF38", VA = "0xE9DF38")]
		[DebuggerHidden]
		public <FadeIn>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xE9DF64", Offset = "0xE9DF64", VA = "0xE9DF64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xE9DF68", Offset = "0xE9DF68", VA = "0xE9DF68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xE9E0B0", Offset = "0xE9E0B0", VA = "0xE9E0B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF498", Offset = "0x3DF498")]
	private sealed class <LoadLevel>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x20")]
		public SceneLoaderTitle <>4__this;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0xE9E5A8", Offset = "0xE9E5A8", VA = "0xE9E5A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0xE9E5F0", Offset = "0xE9E5F0", VA = "0xE9E5F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xE9E3F8", Offset = "0xE9E3F8", VA = "0xE9E3F8")]
		[DebuggerHidden]
		public <LoadLevel>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xE9E424", Offset = "0xE9E424", VA = "0xE9E424", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xE9E428", Offset = "0xE9E428", VA = "0xE9E428", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xE9E5B0", Offset = "0xE9E5B0", VA = "0xE9E5B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x18")]
	public string scene;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x20")]
	public bool autoActivate;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x24")]
	public float autoActivateTime;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x28")]
	public bool preload;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x30")]
	public AudioMixer audioManager;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x0")]
	public static bool doneFading;

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x1")]
	private static bool activating;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x8")]
	private static string sceneName;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x38")]
	private bool activated;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x39")]
	private bool initComplete;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x10")]
	private static AsyncOperation loader;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x3C")]
	private float activateAt;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x40")]
	private AudioSource activateSound;

	[Token(Token = "0x17000086")]
	public static float LoadPercentage
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0xB28ACC", Offset = "0xB28ACC", VA = "0xB28ACC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xB287F8", Offset = "0xB287F8", VA = "0xB287F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xB2894C", Offset = "0xB2894C", VA = "0xB2894C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xB28C84", Offset = "0xB28C84", VA = "0xB28C84")]
	public void BeginLoad()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xB28D48", Offset = "0xB28D48", VA = "0xB28D48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2E6C", Offset = "0x3E2E6C")]
	private IEnumerator FadeVolumeOut()
	{
		return null;
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xB28DB4", Offset = "0xB28DB4", VA = "0xB28DB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2ECC", Offset = "0x3E2ECC")]
	private IEnumerator FadeVolumeIn()
	{
		return null;
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xB288E0", Offset = "0xB288E0", VA = "0xB288E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2F2C", Offset = "0x3E2F2C")]
	private IEnumerator FadeIn()
	{
		return null;
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xB28C18", Offset = "0xB28C18", VA = "0xB28C18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E2F8C", Offset = "0x3E2F8C")]
	private IEnumerator LoadLevel()
	{
		return null;
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xB28B7C", Offset = "0xB28B7C", VA = "0xB28B7C")]
	public static void Activate()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xB28E20", Offset = "0xB28E20", VA = "0xB28E20")]
	public static void Activate(string scene)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xB28F34", Offset = "0xB28F34", VA = "0xB28F34")]
	public SceneLoaderTitle()
	{
	}
}
[Token(Token = "0x20000EC")]
public class ScoreCounter : MonoBehaviour
{
	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x18")]
	private float delay;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xB29014", Offset = "0xB29014", VA = "0xB29014")]
	private void Update()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xB2918C", Offset = "0xB2918C", VA = "0xB2918C")]
	public ScoreCounter()
	{
	}
}
[Token(Token = "0x20000ED")]
public class ScorePanel : MonoBehaviour
{
	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x18")]
	public bool scoreboard;

	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x20")]
	public Image backgroundO;

	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x28")]
	public Image backgroundD;

	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x30")]
	public Text nameO;

	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x38")]
	public Text nameD;

	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x40")]
	public Text scoreO;

	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x48")]
	public Text scoreD;

	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x50")]
	public Text clock;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0DFC", Offset = "0x3E0DFC")]
	public bool lerpClockTime;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0E34", Offset = "0x3E0E34")]
	public float catchupSpeed;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x60")]
	public Text playClock;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x68")]
	public Text downAndDist;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x70")]
	public Text total;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x78")]
	public Text record;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x80")]
	public Text round;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x88")]
	private string[] rounds;

	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x90")]
	private float displayClockTime;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xB2919C", Offset = "0xB2919C", VA = "0xB2919C")]
	private void Start()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xB29548", Offset = "0xB29548", VA = "0xB29548")]
	private void Update()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xB29CEC", Offset = "0xB29CEC", VA = "0xB29CEC")]
	public ScorePanel()
	{
	}
}
[Token(Token = "0x20000EE")]
public class ScreenShot : MonoBehaviour
{
	[Token(Token = "0x600047E")]
	[Address(RVA = "0xB2A178", Offset = "0xB2A178", VA = "0xB2A178")]
	private void Update()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xB2A344", Offset = "0xB2A344", VA = "0xB2A344")]
	public ScreenShot()
	{
	}
}
[Token(Token = "0x20000EF")]
public class ScrimmageLine : MonoBehaviour
{
	[Token(Token = "0x6000480")]
	[Address(RVA = "0xB2B470", Offset = "0xB2B470", VA = "0xB2B470")]
	public void Move()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xB2B540", Offset = "0xB2B540", VA = "0xB2B540")]
	private void Start()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xB2B63C", Offset = "0xB2B63C", VA = "0xB2B63C")]
	public ScrimmageLine()
	{
	}
}
[Token(Token = "0x20000F0")]
public class Set1stDownLineColor : MonoBehaviour
{
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x18")]
	public Material regularMaterial;

	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x20")]
	public Material fourthDownMaterial;

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xB2B880", Offset = "0xB2B880", VA = "0xB2B880")]
	private void Start()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xB2B964", Offset = "0xB2B964", VA = "0xB2B964")]
	public void UpdateColor()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xB2BA20", Offset = "0xB2BA20", VA = "0xB2BA20")]
	public Set1stDownLineColor()
	{
	}
}
[Token(Token = "0x20000F1")]
public enum ColorCategory
{
	[Token(Token = "0x4000479")]
	Primary,
	[Token(Token = "0x400047A")]
	Secondary
}
[Token(Token = "0x20000F2")]
public class SetMaterialProperties : MonoBehaviour
{
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF4A8", Offset = "0x3DF4A8")]
	private sealed class <SetProperties>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x20")]
		public SetMaterialProperties <>4__this;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xE9EB28", Offset = "0xE9EB28", VA = "0xE9EB28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xE9EB70", Offset = "0xE9EB70", VA = "0xE9EB70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE9E5F8", Offset = "0xE9E5F8", VA = "0xE9E5F8")]
		[DebuggerHidden]
		public <SetProperties>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE9E624", Offset = "0xE9E624", VA = "0xE9E624", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE9E628", Offset = "0xE9E628", VA = "0xE9E628", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE9EB30", Offset = "0xE9EB30", VA = "0xE9EB30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400047B")]
	private const int MAX_CONCURRENT = 30;

	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x0")]
	public static int currentSetCount;

	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x20")]
	public ColorCategory color;

	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x24")]
	public bool offense;

	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x25")]
	public bool ignoreColorDiff;

	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x26")]
	public bool swapForHomeGame;

	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x27")]
	public bool isLogo;

	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x28")]
	public Texture[] textures;

	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x30")]
	private bool hasBeenSet;

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xB2BA28", Offset = "0xB2BA28", VA = "0xB2BA28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xB2BC2C", Offset = "0xB2BC2C", VA = "0xB2BC2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xB2BE10", Offset = "0xB2BE10", VA = "0xB2BE10")]
	private void Update()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xB2BF04", Offset = "0xB2BF04", VA = "0xB2BF04")]
	private void ScheduleColorUpdate()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xB2BF0C", Offset = "0xB2BF0C", VA = "0xB2BF0C")]
	private static Vector3 Color2Vector(Color color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xB29438", Offset = "0xB29438", VA = "0xB29438")]
	public static bool ColorDiff(Color a, Color b)
	{
		return default(bool);
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xB2BE98", Offset = "0xB2BE98", VA = "0xB2BE98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E312C", Offset = "0x3E312C")]
	private IEnumerator SetProperties()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xB2BF10", Offset = "0xB2BF10", VA = "0xB2BF10")]
	public SetMaterialProperties()
	{
	}
}
[Token(Token = "0x20000F4")]
public class SetPlatform : MonoBehaviour
{
	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x0")]
	public static int systemMemorySize;

	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x4")]
	public static int processorCount;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x8")]
	public static int eyeTextureWidth;

	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0xC")]
	public static int eyeTextureHeight;

	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x10")]
	public static int eyeTextureResolutionScale;

	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x14")]
	public static int loadedDeviceName;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x18")]
	public static int processorType;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x18")]
	public bool applyExpensiveChanges;

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xB2BF20", Offset = "0xB2BF20", VA = "0xB2BF20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xB2C3DC", Offset = "0xB2C3DC", VA = "0xB2C3DC")]
	public SetPlatform()
	{
	}
}
[Token(Token = "0x20000F5")]
public class SetQualityQuest1 : Clickable
{
	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x50")]
	public bool applyExpensiveChanges;

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xB2C3EC", Offset = "0xB2C3EC", VA = "0xB2C3EC", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xB2C470", Offset = "0xB2C470", VA = "0xB2C470")]
	public SetQualityQuest1()
	{
	}
}
[Token(Token = "0x20000F6")]
public class SetQualityQuest2 : Clickable
{
	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x50")]
	public bool applyExpensiveChanges;

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xB2C480", Offset = "0xB2C480", VA = "0xB2C480", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xB2C504", Offset = "0xB2C504", VA = "0xB2C504")]
	public SetQualityQuest2()
	{
	}
}
[Token(Token = "0x20000F7")]
public class SetRoundNumber : MonoBehaviour
{
	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x18")]
	public Sprite[] roundNumbers;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xB2C514", Offset = "0xB2C514", VA = "0xB2C514")]
	private void Start()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0xB2C5E4", Offset = "0xB2C5E4", VA = "0xB2C5E4")]
	public SetRoundNumber()
	{
	}
}
[Token(Token = "0x20000F8")]
public class SetText : MonoBehaviour
{
	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x18")]
	public bool offense;

	[Token(Token = "0x600049C")]
	[Address(RVA = "0xB2C5EC", Offset = "0xB2C5EC", VA = "0xB2C5EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xB2C740", Offset = "0xB2C740", VA = "0xB2C740")]
	public SetText()
	{
	}
}
[Token(Token = "0x20000F9")]
public class SetTrophy : MonoBehaviour
{
	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] trophies;

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xB2C748", Offset = "0xB2C748", VA = "0xB2C748")]
	private void Start()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xB2C7E8", Offset = "0xB2C7E8", VA = "0xB2C7E8")]
	public SetTrophy()
	{
	}
}
[Token(Token = "0x20000FA")]
public class SetVictoryText : MonoBehaviour
{
	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x18")]
	private string[] vt;

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xB2C7F0", Offset = "0xB2C7F0", VA = "0xB2C7F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xB2C8C8", Offset = "0xB2C8C8", VA = "0xB2C8C8")]
	public SetVictoryText()
	{
	}
}
[Token(Token = "0x20000FB")]
public enum Setting
{
	[Token(Token = "0x4000497")]
	timing,
	[Token(Token = "0x4000498")]
	power,
	[Token(Token = "0x4000499")]
	grab,
	[Token(Token = "0x400049A")]
	height,
	[Token(Token = "0x400049B")]
	exModeLength,
	[Token(Token = "0x400049C")]
	exModeDiff,
	[Token(Token = "0x400049D")]
	receiverMode,
	[Token(Token = "0x400049E")]
	teleportTime,
	[Token(Token = "0x400049F")]
	catchScheme,
	[Token(Token = "0x40004A0")]
	language,
	[Token(Token = "0x40004A1")]
	musicVolume
}
[Token(Token = "0x20000FC")]
public class SettingSlider : Interactable
{
	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x50")]
	public Setting setting;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x54")]
	public bool slidesVertically;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x58")]
	public float min;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x5C")]
	public float max;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0E6C", Offset = "0x3E0E6C")]
	public int numberOfSnapPoints;

	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0EA4", Offset = "0x3E0EA4")]
	public float sliderMin;

	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 startPos;

	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x74")]
	private float range;

	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x78")]
	private float increment;

	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x7C")]
	private int index;

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xB2CB4C", Offset = "0xB2CB4C", VA = "0xB2CB4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xB2CFF4", Offset = "0xB2CFF4", VA = "0xB2CFF4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xB2D5B4", Offset = "0xB2D5B4", VA = "0xB2D5B4", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xB2D5B8", Offset = "0xB2D5B8", VA = "0xB2D5B8", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xB2CC18", Offset = "0xB2CC18", VA = "0xB2CC18")]
	private float ValueFromSetting()
	{
		return default(float);
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xB2D760", Offset = "0xB2D760", VA = "0xB2D760")]
	public SettingSlider()
	{
	}
}
[Token(Token = "0x20000FD")]
public class SettingsResetButton : Clickable
{
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xB2D7A0", Offset = "0xB2D7A0", VA = "0xB2D7A0", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xB2D854", Offset = "0xB2D854", VA = "0xB2D854")]
	public SettingsResetButton()
	{
	}
}
[Token(Token = "0x20000FE")]
public class SidelineReaction : FootballBehaviour
{
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xB2D85C", Offset = "0xB2D85C", VA = "0xB2D85C", Slot = "7")]
	protected override void OnTouchdown()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xB2D918", Offset = "0xB2D918", VA = "0xB2D918", Slot = "8")]
	protected override void OnSafety()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xB2D9D8", Offset = "0xB2D9D8", VA = "0xB2D9D8", Slot = "9")]
	protected override void OnInterception()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xB2DA98", Offset = "0xB2DA98", VA = "0xB2DA98", Slot = "10")]
	protected override void OnTurnover()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xB2DB58", Offset = "0xB2DB58", VA = "0xB2DB58", Slot = "12")]
	protected override void OnSack()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xB2DC18", Offset = "0xB2DC18", VA = "0xB2DC18", Slot = "13")]
	protected override void OnIncomplete()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xB2DCD8", Offset = "0xB2DCD8", VA = "0xB2DCD8", Slot = "14")]
	protected override void OnHotStreak()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xB2DD94", Offset = "0xB2DD94", VA = "0xB2DD94", Slot = "15")]
	protected override void OnFirstDown()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xB2DE50", Offset = "0xB2DE50", VA = "0xB2DE50", Slot = "16")]
	protected override void OnCompletion()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xB2DF0C", Offset = "0xB2DF0C", VA = "0xB2DF0C", Slot = "17")]
	protected override void OnLoss()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xB2DFCC", Offset = "0xB2DFCC", VA = "0xB2DFCC")]
	public SidelineReaction()
	{
	}
}
[Token(Token = "0x20000FF")]
public class SkipButton : Clickable
{
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xB2DFD4", Offset = "0xB2DFD4", VA = "0xB2DFD4", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xB2E074", Offset = "0xB2E074", VA = "0xB2E074")]
	public SkipButton()
	{
	}
}
[Token(Token = "0x2000100")]
public class SloMo : MonoBehaviour
{
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x18")]
	public TimeManager timeManager;

	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource audioSource;

	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x28")]
	public Animator anim;

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xB2E07C", Offset = "0xB2E07C", VA = "0xB2E07C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xB2E154", Offset = "0xB2E154", VA = "0xB2E154")]
	public SloMo()
	{
	}
}
[Token(Token = "0x2000101")]
public class SmartDisplay : MonoBehaviour
{
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject jumboCamScreen;

	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x0")]
	public static bool skip;

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xB2E15C", Offset = "0xB2E15C", VA = "0xB2E15C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xB2E28C", Offset = "0xB2E28C", VA = "0xB2E28C")]
	public SmartDisplay()
	{
	}
}
[Token(Token = "0x2000102")]
public class SpecialTeams : MonoBehaviour
{
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF4B8", Offset = "0x3DF4B8")]
	private sealed class <ToggleFieldGoal>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x20")]
		public SpecialTeams <>4__this;

		[Token(Token = "0x17000091")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xE9EE68", Offset = "0xE9EE68", VA = "0xE9EE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xE9EEB0", Offset = "0xE9EEB0", VA = "0xE9EEB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xE9EB78", Offset = "0xE9EB78", VA = "0xE9EB78")]
		[DebuggerHidden]
		public <ToggleFieldGoal>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xE9EBA4", Offset = "0xE9EBA4", VA = "0xE9EBA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xE9EBA8", Offset = "0xE9EBA8", VA = "0xE9EBA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xE9EE70", Offset = "0xE9EE70", VA = "0xE9EE70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004B1")]
	private const float PUNT_MEAN = 45f;

	[Token(Token = "0x40004B2")]
	private const float PUNT_SIGMA = 15f;

	[Token(Token = "0x40004B3")]
	private const float FG_BLINK_TIME = 0.5f;

	[Token(Token = "0x40004B4")]
	private const float OPP_PUNT_MEAN_MIN = 40f;

	[Token(Token = "0x40004B5")]
	private const float PUNT_MEAN_PER_DIFF = 2.5f;

	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x18")]
	private Football ball;

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xB2E3E4", Offset = "0xB2E3E4", VA = "0xB2E3E4")]
	public void Awake()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xB2E45C", Offset = "0xB2E45C", VA = "0xB2E45C")]
	public void FieldGoalSetup()
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xB2E4F4", Offset = "0xB2E4F4", VA = "0xB2E4F4")]
	public void PerformPunt()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xB2E7A0", Offset = "0xB2E7A0", VA = "0xB2E7A0")]
	public static float PerformOpponentPunt()
	{
		return default(float);
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xB2E488", Offset = "0xB2E488", VA = "0xB2E488")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E31DC", Offset = "0x3E31DC")]
	private IEnumerator ToggleFieldGoal()
	{
		return null;
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xB2E8A8", Offset = "0xB2E8A8", VA = "0xB2E8A8")]
	public SpecialTeams()
	{
	}
}
[Token(Token = "0x2000104")]
public class Spin : MonoBehaviour
{
	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x18")]
	public Animator anim;

	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0EDC", Offset = "0x3E0EDC")]
	private float timer;

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x24")]
	private float waitTime;

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xB2E8B0", Offset = "0xB2E8B0", VA = "0xB2E8B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xB2E9A8", Offset = "0xB2E9A8", VA = "0xB2E9A8")]
	public Spin()
	{
	}
}
[Token(Token = "0x2000105")]
public enum Stat
{
	[Token(Token = "0x40004BE")]
	TotalTouchdowns,
	[Token(Token = "0x40004BF")]
	TotalPassTouchdowns,
	[Token(Token = "0x40004C0")]
	TotalCompletions,
	[Token(Token = "0x40004C1")]
	CompletionPercentage,
	[Token(Token = "0x40004C2")]
	TotalAttempts,
	[Token(Token = "0x40004C3")]
	TotalConversions,
	[Token(Token = "0x40004C4")]
	TotalHotstreaks,
	[Token(Token = "0x40004C5")]
	HighestCompletionStreak,
	[Token(Token = "0x40004C6")]
	TotalPassingYards,
	[Token(Token = "0x40004C7")]
	TotalYards,
	[Token(Token = "0x40004C8")]
	TotalInterceptions,
	[Token(Token = "0x40004C9")]
	HighestRatingAfterRound1,
	[Token(Token = "0x40004CA")]
	HighestRatingAfterRound2,
	[Token(Token = "0x40004CB")]
	HighestRatingAfterRound3,
	[Token(Token = "0x40004CC")]
	HighestRatingAfterRound4,
	[Token(Token = "0x40004CD")]
	HighestRatingAfterRound5,
	[Token(Token = "0x40004CE")]
	HighestRatingAfterRound6,
	[Token(Token = "0x40004CF")]
	HighestRatingAsChampion,
	[Token(Token = "0x40004D0")]
	TotalPasserRating,
	[Token(Token = "0x40004D1")]
	TotalWins,
	[Token(Token = "0x40004D2")]
	QBTotalRushYards,
	[Token(Token = "0x40004D3")]
	QBTotalRushTDs,
	[Token(Token = "0x40004D4")]
	SeriesPassTDs,
	[Token(Token = "0x40004D5")]
	SeriesCompletions,
	[Token(Token = "0x40004D6")]
	SeriesCompletionPercentage,
	[Token(Token = "0x40004D7")]
	SeriesAttempts,
	[Token(Token = "0x40004D8")]
	SeriesInterceptions,
	[Token(Token = "0x40004D9")]
	SeriesPassYards,
	[Token(Token = "0x40004DA")]
	SeriesRushYards,
	[Token(Token = "0x40004DB")]
	SeriesRushTDs,
	[Token(Token = "0x40004DC")]
	SeriesTotalYards,
	[Token(Token = "0x40004DD")]
	SeriesTotalTDs,
	[Token(Token = "0x40004DE")]
	SeriesPasserRating,
	[Token(Token = "0x40004DF")]
	Championships
}
[Token(Token = "0x2000106")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF4C8", Offset = "0x3DF4C8")]
public class StatDisplayer : MonoBehaviour
{
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x18")]
	public Stat displayedStat;

	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0EF4", Offset = "0x3E0EF4")]
	public bool activeUpdates;

	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x20")]
	private Text textArea;

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xB2E9BC", Offset = "0xB2E9BC", VA = "0xB2E9BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xB2F398", Offset = "0xB2F398", VA = "0xB2F398")]
	private void Update()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xB2EA38", Offset = "0xB2EA38", VA = "0xB2EA38")]
	private string GetDisplayedStat()
	{
		return null;
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xB2F3E8", Offset = "0xB2F3E8", VA = "0xB2F3E8")]
	public StatDisplayer()
	{
	}
}
[Token(Token = "0x2000107")]
public class TeamNameAudio : MonoBehaviour
{
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x18")]
	public bool offense;

	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] teamNameClips;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xB2F498", Offset = "0xB2F498", VA = "0xB2F498")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xB2F5D0", Offset = "0xB2F5D0", VA = "0xB2F5D0")]
	public TeamNameAudio()
	{
	}
}
[Token(Token = "0x2000108")]
public class TextClock : MonoBehaviour
{
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x18")]
	private Text textClock;

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xB2F5E0", Offset = "0xB2F5E0", VA = "0xB2F5E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xB2F634", Offset = "0xB2F634", VA = "0xB2F634")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xB2F720", Offset = "0xB2F720", VA = "0xB2F720")]
	private string LeadingZero(int n)
	{
		return null;
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xB2F760", Offset = "0xB2F760", VA = "0xB2F760")]
	public TextClock()
	{
	}
}
[Token(Token = "0x2000109")]
public class TickerRandomizer : MonoBehaviour
{
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> tickers;

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xB2F768", Offset = "0xB2F768", VA = "0xB2F768")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xB2F838", Offset = "0xB2F838", VA = "0xB2F838")]
	public TickerRandomizer()
	{
	}
}
[Token(Token = "0x200010A")]
public class TimeManager : MonoBehaviour
{
	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x18")]
	public float slowdownFactor;

	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0x1C")]
	public float slowdownLength;

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xB2FB7C", Offset = "0xB2FB7C", VA = "0xB2FB7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xB2E120", Offset = "0xB2E120", VA = "0xB2E120")]
	public void DoSlowmotion()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xB2FC28", Offset = "0xB2FC28", VA = "0xB2FC28")]
	public TimeManager()
	{
	}
}
[Token(Token = "0x200010B")]
public class TitleSkip : MonoBehaviour
{
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x18")]
	public bool rightHand;

	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0x20")]
	private InputDevice controller;

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xB2FD60", Offset = "0xB2FD60", VA = "0xB2FD60")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xB2FD9C", Offset = "0xB2FD9C", VA = "0xB2FD9C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xB2FE84", Offset = "0xB2FE84", VA = "0xB2FE84")]
	public TitleSkip()
	{
	}
}
[Token(Token = "0x200010C")]
public class ToggleBody : MonoBehaviour
{
	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x18")]
	public Transform eyes;

	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0x20")]
	public Transform disablePoint;

	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x28")]
	public GameObject body;

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xB2FE8C", Offset = "0xB2FE8C", VA = "0xB2FE8C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xB2FEF0", Offset = "0xB2FEF0", VA = "0xB2FEF0")]
	public ToggleBody()
	{
	}
}
[Token(Token = "0x200010D")]
public class ToggleCollisions : MonoBehaviour
{
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xB2FEF8", Offset = "0xB2FEF8", VA = "0xB2FEF8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xB2FFDC", Offset = "0xB2FFDC", VA = "0xB2FFDC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xB30004", Offset = "0xB30004", VA = "0xB30004")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xB30098", Offset = "0xB30098", VA = "0xB30098")]
	public ToggleCollisions()
	{
	}
}
[Token(Token = "0x200010E")]
public class ToggleWithButtonInput : MonoBehaviour
{
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x18")]
	private int currentState;

	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x20")]
	public Transform Container;

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xB300A0", Offset = "0xB300A0", VA = "0xB300A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0xB300E4", Offset = "0xB300E4", VA = "0xB300E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xB301CC", Offset = "0xB301CC", VA = "0xB301CC")]
	public ToggleWithButtonInput()
	{
	}
}
[Token(Token = "0x200010F")]
public class Trophy : MonoBehaviour
{
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x18")]
	public string achievement;

	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject trophy;

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0xB319F0", Offset = "0xB319F0", VA = "0xB319F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0xB31A70", Offset = "0xB31A70", VA = "0xB31A70")]
	public Trophy()
	{
	}
}
[Token(Token = "0x2000110")]
public class TutorialRestart : Clickable
{
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xB31C70", Offset = "0xB31C70", VA = "0xB31C70", Slot = "8")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xB31CF0", Offset = "0xB31CF0", VA = "0xB31CF0")]
	public TutorialRestart()
	{
	}
}
[Token(Token = "0x2000111")]
public static class Tutorial
{
	[Token(Token = "0x17000093")]
	public static bool complete
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xB31AC4", Offset = "0xB31AC4", VA = "0xB31AC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000094")]
	public static int stage
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xB31AE0", Offset = "0xB31AE0", VA = "0xB31AE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xB31B50", Offset = "0xB31B50", VA = "0xB31B50")]
		set
		{
		}
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xB31BD4", Offset = "0xB31BD4", VA = "0xB31BD4")]
	public static void NextStage()
	{
	}
}
[Token(Token = "0x2000112")]
public class TutorialStage : MonoBehaviour
{
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x18")]
	public int stage;

	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x1C")]
	public bool repeats;

	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip soundClip;

	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] objects;

	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x3C")]
	private bool played;

	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x3D")]
	private bool active;

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xB31CF8", Offset = "0xB31CF8", VA = "0xB31CF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xB31ED0", Offset = "0xB31ED0", VA = "0xB31ED0")]
	public TutorialStage()
	{
	}
}
[Token(Token = "0x2000113")]
public class TvCamera : MonoBehaviour
{
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x0")]
	public static bool isEnabled;

	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x18")]
	public Transform trackTarget;

	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 startPos;

	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x2C")]
	public float zoomDist;

	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x38")]
	public Camera qbCam;

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0xB31EE0", Offset = "0xB31EE0", VA = "0xB31EE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0xB31F84", Offset = "0xB31F84", VA = "0xB31F84")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xB32250", Offset = "0xB32250", VA = "0xB32250")]
	public static void Toggle()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xB322BC", Offset = "0xB322BC", VA = "0xB322BC")]
	public TvCamera()
	{
	}
}
[Token(Token = "0x2000114")]
public class TvTicker : MonoBehaviour
{
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xB3234C", Offset = "0xB3234C", VA = "0xB3234C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xB323E8", Offset = "0xB323E8", VA = "0xB323E8")]
	public TvTicker()
	{
	}
}
[Token(Token = "0x2000115")]
public class UpdateHatLogo : MonoBehaviour
{
	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x18")]
	public Material[] mats;

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xB32460", Offset = "0xB32460", VA = "0xB32460")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xB32538", Offset = "0xB32538", VA = "0xB32538")]
	public UpdateHatLogo()
	{
	}
}
[Token(Token = "0x2000116")]
public class UpdateLogo : MonoBehaviour
{
	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x18")]
	public bool main;

	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x20")]
	private string loadedLogo;

	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x28")]
	private ResourceRequest request;

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xB32540", Offset = "0xB32540", VA = "0xB32540")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xB32738", Offset = "0xB32738", VA = "0xB32738")]
	public UpdateLogo()
	{
	}
}
[Token(Token = "0x2000117")]
public class UpdateLogoMaterial : MonoBehaviour
{
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x18")]
	public Material[] materials;

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xB32794", Offset = "0xB32794", VA = "0xB32794")]
	private void Update()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xB3286C", Offset = "0xB3286C", VA = "0xB3286C")]
	public UpdateLogoMaterial()
	{
	}
}
[Token(Token = "0x2000118")]
public class VoiceSlider : Interactable
{
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x0")]
	public static List<int> voices;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x60")]
	public Mouth mouth;

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xB3300C", Offset = "0xB3300C", VA = "0xB3300C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xB3316C", Offset = "0xB3316C", VA = "0xB3316C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xB33440", Offset = "0xB33440", VA = "0xB33440", Slot = "4")]
	protected override void OnActivate()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xB33444", Offset = "0xB33444", VA = "0xB33444", Slot = "6")]
	protected override void OnDeactivate()
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xB334B4", Offset = "0xB334B4", VA = "0xB334B4")]
	public VoiceSlider()
	{
	}
}
[Token(Token = "0x2000119")]
public class WinCounter : MonoBehaviour
{
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x18")]
	private float delay;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x6000502")]
	[Address(RVA = "0xB33674", Offset = "0xB33674", VA = "0xB33674")]
	private void Update()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0xB33798", Offset = "0xB33798", VA = "0xB33798")]
	public WinCounter()
	{
	}
}
[Token(Token = "0x200011A")]
public class Wind : MonoBehaviour
{
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x18")]
	public float minForce;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x1C")]
	public float maxForce;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x20")]
	public float minFrequency;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x24")]
	public float maxFrequency;

	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x6000504")]
	[Address(RVA = "0xB337A8", Offset = "0xB337A8", VA = "0xB337A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0xB3388C", Offset = "0xB3388C", VA = "0xB3388C")]
	public Wind()
	{
	}
}
[Token(Token = "0x200011B")]
public class XRDeviceTimeStep : MonoBehaviour
{
	[Token(Token = "0x6000506")]
	[Address(RVA = "0xB338A0", Offset = "0xB338A0", VA = "0xB338A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0xB338B0", Offset = "0xB338B0", VA = "0xB338B0")]
	public XRDeviceTimeStep()
	{
	}
}
[Token(Token = "0x200011C")]
public class XRScreenFade : MonoBehaviour
{
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF528", Offset = "0x3DF528")]
	private sealed class <ScreenFade>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x20")]
		public XRScreenFade <>4__this;

		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x28")]
		public float startAlpha;

		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x2C")]
		public float endAlpha;

		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000095")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0xE9EFF0", Offset = "0xE9EFF0", VA = "0xE9EFF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xE9F038", Offset = "0xE9F038", VA = "0xE9F038", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xE9EEB8", Offset = "0xE9EEB8", VA = "0xE9EEB8")]
		[DebuggerHidden]
		public <ScreenFade>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xE9EEE4", Offset = "0xE9EEE4", VA = "0xE9EEE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xE9EEE8", Offset = "0xE9EEE8", VA = "0xE9EEE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE9EFF8", Offset = "0xE9EFF8", VA = "0xE9EFF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0F2C", Offset = "0x3E0F2C")]
	public float fadeTime;

	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E0F64", Offset = "0x3E0F64")]
	public Color fadeColor;

	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x2C")]
	public bool fadeOnStart;

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x30")]
	public int renderQueue;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x38")]
	private MeshRenderer fadeMeshRenderer;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x40")]
	private MeshFilter fadeMeshFilter;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x48")]
	private Material fadeMaterial;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x50")]
	private bool isFading;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x54")]
	private float currentAlpha;

	[Token(Token = "0x6000508")]
	[Address(RVA = "0xB338B8", Offset = "0xB338B8", VA = "0xB338B8")]
	public static void SetFade(float level)
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0xB339F0", Offset = "0xB339F0", VA = "0xB339F0")]
	public static void FadeIn(float time)
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0xB33BB4", Offset = "0xB33BB4", VA = "0xB33BB4")]
	public static void FadeOut(float time)
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0xB33CF8", Offset = "0xB33CF8", VA = "0xB33CF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0xB340B8", Offset = "0xB340B8", VA = "0xB340B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0xB340F8", Offset = "0xB340F8", VA = "0xB340F8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0xB33D20", Offset = "0xB33D20", VA = "0xB33D20")]
	private void CreateFadeMesh()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0xB340FC", Offset = "0xB340FC", VA = "0xB340FC")]
	private void DestroyFadeMesh()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0xB339E8", Offset = "0xB339E8", VA = "0xB339E8")]
	private void SetCurrentAlpha(float alpha)
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0xB33B34", Offset = "0xB33B34", VA = "0xB33B34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3E328C", Offset = "0x3E328C")]
	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		return null;
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0xB3425C", Offset = "0xB3425C", VA = "0xB3425C")]
	private void SetMaterialAlpha()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0xB34368", Offset = "0xB34368", VA = "0xB34368")]
	public XRScreenFade()
	{
	}
}
[Token(Token = "0x200011E")]
public class YardSticks : MonoBehaviour
{
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x0")]
	public static float lineToGain;

	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x4")]
	public static int down;

	[Token(Token = "0x600051A")]
	[Address(RVA = "0xB2E6E0", Offset = "0xB2E6E0", VA = "0xB2E6E0")]
	public static void FirstDown()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0xB343D8", Offset = "0xB343D8", VA = "0xB343D8")]
	public void Move()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0xB344DC", Offset = "0xB344DC", VA = "0xB344DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0xB345C8", Offset = "0xB345C8", VA = "0xB345C8")]
	public YardSticks()
	{
	}
}
[Token(Token = "0x200011F")]
public class alwaysFaceQB : MonoBehaviour
{
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x18")]
	private GameObject target;

	[Token(Token = "0x600051F")]
	[Address(RVA = "0xB346DC", Offset = "0xB346DC", VA = "0xB346DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0xB34730", Offset = "0xB34730", VA = "0xB34730")]
	private void Update()
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0xB34780", Offset = "0xB34780", VA = "0xB34780")]
	public alwaysFaceQB()
	{
	}
}
[Token(Token = "0x2000120")]
public class alwaysFaceCamera : MonoBehaviour
{
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x18")]
	private GameObject target;

	[Token(Token = "0x6000522")]
	[Address(RVA = "0xB34630", Offset = "0xB34630", VA = "0xB34630")]
	private void Start()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0xB34684", Offset = "0xB34684", VA = "0xB34684")]
	private void Update()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0xB346D4", Offset = "0xB346D4", VA = "0xB346D4")]
	public alwaysFaceCamera()
	{
	}
}
[Token(Token = "0x2000121")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF538", Offset = "0x3DF538")]
public class rendercam : MonoBehaviour
{
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x18")]
	public float FPS;

	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x20")]
	public Camera renderCam;

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xB34788", Offset = "0xB34788", VA = "0xB34788")]
	private void Start()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0xB347E8", Offset = "0xB347E8", VA = "0xB347E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0xB347EC", Offset = "0xB347EC", VA = "0xB347EC")]
	private void Render()
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0xB3480C", Offset = "0xB3480C", VA = "0xB3480C")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0xB3482C", Offset = "0xB3482C", VA = "0xB3482C")]
	public rendercam()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000122")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool m_DetachSelf;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xB2FC3C", Offset = "0xB2FC3C", VA = "0xB2FC3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xB2FCD8", Offset = "0xB2FCD8", VA = "0xB2FCD8")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xB2FD50", Offset = "0xB2FD50", VA = "0xB2FD50")]
		public TimedObjectDestructor()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000123")]
	public enum AAMode
	{
		[Token(Token = "0x4000529")]
		FXAA2,
		[Token(Token = "0x400052A")]
		FXAA3Console,
		[Token(Token = "0x400052B")]
		FXAA1PresetA,
		[Token(Token = "0x400052C")]
		FXAA1PresetB,
		[Token(Token = "0x400052D")]
		NFAA,
		[Token(Token = "0x400052E")]
		SSAA,
		[Token(Token = "0x400052F")]
		DLAA
	}
	[Token(Token = "0x2000124")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF598", Offset = "0x3DF598")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF598", Offset = "0x3DF598")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xBFEA0C", Offset = "0xBFEA0C", VA = "0xBFEA0C")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xBFEA70", Offset = "0xBFEA70", VA = "0xBFEA70", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xBFEB5C", Offset = "0xBFEB5C", VA = "0xBFEB5C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xBFF0E8", Offset = "0xBFF0E8", VA = "0xBFF0E8")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF62C", Offset = "0x3DF62C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF62C", Offset = "0x3DF62C")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000126")]
		public enum Resolution
		{
			[Token(Token = "0x400054F")]
			Low,
			[Token(Token = "0x4000550")]
			High
		}

		[Token(Token = "0x2000127")]
		public enum BlurType
		{
			[Token(Token = "0x4000552")]
			Standard,
			[Token(Token = "0x4000553")]
			Sgx
		}

		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0FCC", Offset = "0x3E0FCC")]
		public float threshold;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0FE4", Offset = "0x3E0FE4")]
		public float intensity;

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E0FFC", Offset = "0x3E0FFC")]
		public float blurSize;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1014", Offset = "0x3E1014")]
		public int blurIterations;

		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xBFFEF4", Offset = "0xBFFEF4", VA = "0xBFFEF4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xBFFF58", Offset = "0xBFFF58", VA = "0xBFFF58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xC00004", Offset = "0xC00004", VA = "0xC00004")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xC003E4", Offset = "0xC003E4", VA = "0xC003E4")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF6C0", Offset = "0x3DF6C0")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E102C", Offset = "0x3E102C")]
		public int iterations;

		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1044", Offset = "0x3E1044")]
		public float blurSpread;

		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000097")]
		protected Material material
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xC00408", Offset = "0xC00408", VA = "0xC00408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xC00554", Offset = "0xC00554", VA = "0xC00554")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xC00658", Offset = "0xC00658", VA = "0xC00658")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xC00714", Offset = "0xC00714", VA = "0xC00714")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xC00838", Offset = "0xC00838", VA = "0xC00838")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xC00948", Offset = "0xC00948", VA = "0xC00948")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xC00AB0", Offset = "0xC00AB0", VA = "0xC00AB0")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF70C", Offset = "0x3DF70C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF70C", Offset = "0x3DF70C")]
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200012A")]
		public enum BlurType
		{
			[Token(Token = "0x400055F")]
			StandardGauss,
			[Token(Token = "0x4000560")]
			SgxGauss
		}

		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E105C", Offset = "0x3E105C")]
		public int downsample;

		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1074", Offset = "0x3E1074")]
		public float blurSize;

		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E108C", Offset = "0x3E108C")]
		public int blurIterations;

		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xC00ACC", Offset = "0xC00ACC", VA = "0xC00ACC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xC00B30", Offset = "0xC00B30", VA = "0xC00B30")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC00BDC", Offset = "0xC00BDC", VA = "0xC00BDC")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC00F88", Offset = "0xC00F88", VA = "0xC00F88")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF7A0", Offset = "0x3DF7A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF7A0", Offset = "0x3DF7A0")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200012C")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000580")]
			CameraMotion,
			[Token(Token = "0x4000581")]
			LocalBlur,
			[Token(Token = "0x4000582")]
			Reconstruction,
			[Token(Token = "0x4000583")]
			ReconstructionDX11,
			[Token(Token = "0x4000584")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0xE4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x124")]
		private int prevFrameCount;

		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x128")]
		private bool wasActive;

		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x12C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x138")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x144")]
		private Vector3 prevFramePos;

		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x150")]
		private Camera _camera;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xC03278", Offset = "0xC03278", VA = "0xC03278")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xC03384", Offset = "0xC03384", VA = "0xC03384")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xC03514", Offset = "0xC03514", VA = "0xC03514")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xC035DC", Offset = "0xC035DC", VA = "0xC035DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xC0373C", Offset = "0xC0373C", VA = "0xC0373C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC037D4", Offset = "0xC037D4", VA = "0xC037D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC03464", Offset = "0xC03464", VA = "0xC03464")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xC04DAC", Offset = "0xC04DAC", VA = "0xC04DAC")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xC04D1C", Offset = "0xC04D1C", VA = "0xC04D1C")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC04D9C", Offset = "0xC04D9C", VA = "0xC04D9C")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC05138", Offset = "0xC05138", VA = "0xC05138")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF834", Offset = "0x3DF834")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200012E")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x400059E")]
			Simple,
			[Token(Token = "0x400059F")]
			Advanced
		}

		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xC05A20", Offset = "0xC05A20", VA = "0xC05A20")]
		private new void Start()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC05A4C", Offset = "0xC05A4C", VA = "0xC05A4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC05A50", Offset = "0xC05A50", VA = "0xC05A50", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xC05CCC", Offset = "0xC05CCC", VA = "0xC05CCC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xC0608C", Offset = "0xC0608C", VA = "0xC0608C")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC06090", Offset = "0xC06090", VA = "0xC06090")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC063DC", Offset = "0xC063DC", VA = "0xC063DC")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF880", Offset = "0x3DF880")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xC06A18", Offset = "0xC06A18", VA = "0xC06A18", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xC06A78", Offset = "0xC06A78", VA = "0xC06A78")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC06B1C", Offset = "0xC06B1C", VA = "0xC06B1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC06BC0", Offset = "0xC06BC0", VA = "0xC06BC0")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xC06DDC", Offset = "0xC06DDC", VA = "0xC06DDC")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xC06EA4", Offset = "0xC06EA4", VA = "0xC06EA4")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC07200", Offset = "0xC07200", VA = "0xC07200")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC07418", Offset = "0xC07418", VA = "0xC07418")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF8CC", Offset = "0x3DF8CC")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xC0746C", Offset = "0xC0746C", VA = "0xC0746C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xC07534", Offset = "0xC07534", VA = "0xC07534")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF918", Offset = "0x3DF918")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF918", Offset = "0x3DF918")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E10A4", Offset = "0x3E10A4")]
		public float intensity;

		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E10BC", Offset = "0x3E10BC")]
		public float threshold;

		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E10D8", Offset = "0x3E10D8")]
		public float blurSpread;

		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xC0A3D4", Offset = "0xC0A3D4", VA = "0xC0A3D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xC0A454", Offset = "0xC0A454", VA = "0xC0A454")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xC0A7E8", Offset = "0xC0A7E8", VA = "0xC0A7E8")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF9AC", Offset = "0x3DF9AC")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E10F0", Offset = "0x3E10F0")]
		public float adaptationSpeed;

		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E110C", Offset = "0x3E110C")]
		public float limitMinimum;

		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1124", Offset = "0x3E1124")]
		public float limitMaximum;

		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000098")]
		protected Material materialLum
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xC0A800", Offset = "0xC0A800", VA = "0xC0A800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xC0A8CC", Offset = "0xC0A8CC", VA = "0xC0A8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xC0A998", Offset = "0xC0A998", VA = "0xC0A998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		protected Material materialApply
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xC0AA64", Offset = "0xC0AA64", VA = "0xC0AA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xC0AB30", Offset = "0xC0AB30", VA = "0xC0AB30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xC0ABC4", Offset = "0xC0ABC4", VA = "0xC0ABC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xC0AD1C", Offset = "0xC0AD1C", VA = "0xC0AD1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xC0AF40", Offset = "0xC0AF40", VA = "0xC0AF40")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xC0B1A4", Offset = "0xC0B1A4", VA = "0xC0B1A4")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xC0B3A0", Offset = "0xC0B3A0", VA = "0xC0B3A0")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DF9F8", Offset = "0x3DF9F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DF9F8", Offset = "0x3DF9F8")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xC0B414", Offset = "0xC0B414", VA = "0xC0B414", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xC0B4A0", Offset = "0xC0B4A0", VA = "0xC0B4A0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xC0B874", Offset = "0xC0B874", VA = "0xC0B874")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFA8C", Offset = "0x3DFA8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFA8C", Offset = "0x3DFA8C")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000135")]
		public enum BlurType
		{
			[Token(Token = "0x40005DC")]
			DiscBlur,
			[Token(Token = "0x40005DD")]
			DX11
		}

		[Token(Token = "0x2000136")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40005DF")]
			Low,
			[Token(Token = "0x40005E0")]
			Medium,
			[Token(Token = "0x40005E1")]
			High
		}

		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xD14198", Offset = "0xD14198", VA = "0xD14198", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xD14350", Offset = "0xD14350", VA = "0xD14350")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xD143C4", Offset = "0xD143C4", VA = "0xD143C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xD144C8", Offset = "0xD144C8", VA = "0xD144C8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xD1422C", Offset = "0xD1422C", VA = "0xD1422C")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xD1450C", Offset = "0xD1450C", VA = "0xD1450C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xD145FC", Offset = "0xD145FC", VA = "0xD145FC")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xD14930", Offset = "0xD14930", VA = "0xD14930")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xD15F50", Offset = "0xD15F50", VA = "0xD15F50")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFB20", Offset = "0x3DFB20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFB20", Offset = "0x3DFB20")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000138")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400060E")]
			OnlyBackground = 1,
			[Token(Token = "0x400060F")]
			BackgroundAndForeground
		}

		[Token(Token = "0x2000139")]
		public enum DofResolution
		{
			[Token(Token = "0x4000611")]
			High = 2,
			[Token(Token = "0x4000612")]
			Medium,
			[Token(Token = "0x4000613")]
			Low
		}

		[Token(Token = "0x200013A")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000615")]
			Low = 1,
			[Token(Token = "0x4000616")]
			High = 2,
			[Token(Token = "0x4000617")]
			VeryHigh = 4
		}

		[Token(Token = "0x200013B")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000619")]
			Background = 1,
			[Token(Token = "0x400061A")]
			Foreground,
			[Token(Token = "0x400061B")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xD15FA8", Offset = "0xD15FA8", VA = "0xD15FA8")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xD16084", Offset = "0xD16084", VA = "0xD16084", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xD16198", Offset = "0xD16198", VA = "0xD16198")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xD161F4", Offset = "0xD161F4", VA = "0xD161F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xD16268", Offset = "0xD16268", VA = "0xD16268")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xD16358", Offset = "0xD16358", VA = "0xD16358")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xD1637C", Offset = "0xD1637C", VA = "0xD1637C")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xD163A0", Offset = "0xD163A0", VA = "0xD163A0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xD171DC", Offset = "0xD171DC", VA = "0xD171DC")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xD178D0", Offset = "0xD178D0", VA = "0xD178D0")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xD17D48", Offset = "0xD17D48", VA = "0xD17D48")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xD1707C", Offset = "0xD1707C", VA = "0xD1707C")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xD17480", Offset = "0xD17480", VA = "0xD17480")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xD17BA0", Offset = "0xD17BA0", VA = "0xD17BA0")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xD16D4C", Offset = "0xD16D4C", VA = "0xD16D4C")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xD17F78", Offset = "0xD17F78", VA = "0xD17F78")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFBB4", Offset = "0x3DFBB4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFBB4", Offset = "0x3DFBB4")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200013D")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000628")]
			TriangleDepthNormals,
			[Token(Token = "0x4000629")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x400062A")]
			SobelDepth,
			[Token(Token = "0x400062B")]
			SobelDepthThin,
			[Token(Token = "0x400062C")]
			TriangleLuminance
		}

		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xD19E8C", Offset = "0xD19E8C", VA = "0xD19E8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xD19FCC", Offset = "0xD19FCC", VA = "0xD19FCC")]
		private new void Start()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xD19F10", Offset = "0xD19F10", VA = "0xD19F10")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xD19FD8", Offset = "0xD19FD8", VA = "0xD19FD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xD19FDC", Offset = "0xD19FDC", VA = "0xD19FDC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xD1A204", Offset = "0xD1A204", VA = "0xD1A204")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFC48", Offset = "0x3DFC48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFC48", Offset = "0x3DFC48")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E113C", Offset = "0x3E113C")]
		public float strengthX;

		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1154", Offset = "0x3E1154")]
		public float strengthY;

		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xD1C928", Offset = "0xD1C928", VA = "0xD1C928", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xD1C98C", Offset = "0xD1C98C", VA = "0xD1C98C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xD1CB04", Offset = "0xD1CB04", VA = "0xD1CB04")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFCDC", Offset = "0x3DFCDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFCDC", Offset = "0x3DFCDC")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E116C", Offset = "0x3E116C")]
		public bool distanceFog;

		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E11A4", Offset = "0x3E11A4")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E11DC", Offset = "0x3E11DC")]
		public bool useRadialDistance;

		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E1214", Offset = "0x3E1214")]
		public bool heightFog;

		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E124C", Offset = "0x3E124C")]
		public float height;

		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1284", Offset = "0x3E1284")]
		public float heightDensity;

		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3E12A0", Offset = "0x3E12A0")]
		public float startDistance;

		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xD22EF4", Offset = "0xD22EF4", VA = "0xD22EF4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xD22F58", Offset = "0xD22F58", VA = "0xD22F58")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xD2364C", Offset = "0xD2364C", VA = "0xD2364C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xD237B8", Offset = "0xD237B8", VA = "0xD237B8")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFD70", Offset = "0x3DFD70")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E12D8", Offset = "0x3E12D8")]
		public float rampOffset;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xD237DC", Offset = "0xD237DC", VA = "0xD237DC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xD238D8", Offset = "0xD238D8", VA = "0xD238D8")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFDBC", Offset = "0x3DFDBC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFDBC", Offset = "0x3DFDBC")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700009C")]
		protected Material material
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xEBADB4", Offset = "0xEBADB4", VA = "0xEBADB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xEBAD08", Offset = "0xEBAD08", VA = "0xEBAD08", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xEBAE80", Offset = "0xEBAE80", VA = "0xEBAE80", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xEBAF2C", Offset = "0xEBAF2C", VA = "0xEBAF2C")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFE40", Offset = "0x3DFE40")]
	public class ImageEffects
	{
		[Token(Token = "0x600059B")]
		[Address(RVA = "0xEBAF34", Offset = "0xEBAF34", VA = "0xEBAF34")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xEBB180", Offset = "0xEBB180", VA = "0xEBB180")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x3E335C", Offset = "0x3E335C")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xEBB1F4", Offset = "0xEBB1F4", VA = "0xEBB1F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x3E3394", Offset = "0x3E3394")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xEBB270", Offset = "0xEBB270", VA = "0xEBB270")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFE78", Offset = "0x3DFE78")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFE78", Offset = "0x3DFE78")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xEC396C", Offset = "0xEC396C", VA = "0xEC396C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xEC39C8", Offset = "0xEC39C8", VA = "0xEC39C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xEC3A50", Offset = "0xEC3A50", VA = "0xEC3A50")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xEC4280", Offset = "0xEC4280", VA = "0xEC4280")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xEC44B4", Offset = "0xEC44B4", VA = "0xEC44B4")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xEC4938", Offset = "0xEC4938", VA = "0xEC4938")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xEC4AC8", Offset = "0xEC4AC8", VA = "0xEC4AC8")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3DFF0C", Offset = "0x3DFF0C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFF0C", Offset = "0x3DFF0C")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E12F0", Offset = "0x3E12F0")]
		public float grainIntensityMin;

		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1308", Offset = "0x3E1308")]
		public float grainIntensityMax;

		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1320", Offset = "0x3E1320")]
		public float grainSize;

		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1340", Offset = "0x3E1340")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1358", Offset = "0x3E1358")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1370", Offset = "0x3E1370")]
		public float scratchFPS;

		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1388", Offset = "0x3E1388")]
		public float scratchJitter;

		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700009D")]
		protected Material material
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xEC4CAC", Offset = "0xEC4CAC", VA = "0xEC4CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xEC4B58", Offset = "0xEC4B58", VA = "0xEC4B58")]
		protected void Start()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xEC4E10", Offset = "0xEC4E10", VA = "0xEC4E10")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xEC4F10", Offset = "0xEC4F10", VA = "0xEC4F10")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xEC5004", Offset = "0xEC5004", VA = "0xEC5004")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xEC5384", Offset = "0xEC5384", VA = "0xEC5384")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000145")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3DFFA0", Offset = "0x3DFFA0")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xD4532C", Offset = "0xD4532C", VA = "0xD4532C")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xD45730", Offset = "0xD45730", VA = "0xD45730")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xD45938", Offset = "0xD45938", VA = "0xD45938")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xD45944", Offset = "0xD45944", VA = "0xD45944")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD45948", Offset = "0xD45948", VA = "0xD45948")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xD45A18", Offset = "0xD45A18", VA = "0xD45A18")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD45B24", Offset = "0xD45B24", VA = "0xD45B24", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xD45BE8", Offset = "0xD45BE8", VA = "0xD45BE8")]
		protected void Start()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xD45A20", Offset = "0xD45A20", VA = "0xD45A20")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xD45BF4", Offset = "0xD45BF4", VA = "0xD45BF4")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xD45C50", Offset = "0xD45C50", VA = "0xD45C50")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD45C58", Offset = "0xD45C58", VA = "0xD45C58")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xD45D14", Offset = "0xD45D14", VA = "0xD45D14")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xD45704", Offset = "0xD45704", VA = "0xD45704")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD45F40", Offset = "0xD45F40", VA = "0xD45F40")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD462BC", Offset = "0xD462BC", VA = "0xD462BC")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E0010", Offset = "0x3E0010")]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD46340", Offset = "0xD46340", VA = "0xD46340")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD463B4", Offset = "0xD463B4", VA = "0xD463B4")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD4660C", Offset = "0xD4660C", VA = "0xD4660C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD46984", Offset = "0xD46984", VA = "0xD46984")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD46B2C", Offset = "0xD46B2C", VA = "0xD46B2C")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000147")]
	internal class Quads
	{
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD48834", Offset = "0xD48834", VA = "0xD48834")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xD48960", Offset = "0xD48960", VA = "0xD48960")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD48B38", Offset = "0xD48B38", VA = "0xD48B38")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD48DC0", Offset = "0xD48DC0", VA = "0xD48DC0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xD49180", Offset = "0xD49180", VA = "0xD49180")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E0080", Offset = "0x3E0080")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E0080", Offset = "0x3E0080")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000149")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x400066F")]
			Additive,
			[Token(Token = "0x4000670")]
			ScreenBlend,
			[Token(Token = "0x4000671")]
			Multiply,
			[Token(Token = "0x4000672")]
			Overlay,
			[Token(Token = "0x4000673")]
			AlphaBlend
		}

		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xB29F78", Offset = "0xB29F78", VA = "0xB29F78", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xB29FDC", Offset = "0xB29FDC", VA = "0xB29FDC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xB2A164", Offset = "0xB2A164", VA = "0xB2A164")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E0114", Offset = "0x3E0114")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E0114", Offset = "0x3E0114")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E13A0", Offset = "0x3E13A0")]
		public float intensity;

		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E13B8", Offset = "0x3E13B8")]
		public float radius;

		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E13D4", Offset = "0x3E13D4")]
		public int blurIterations;

		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E13EC", Offset = "0x3E13EC")]
		public float blurFilterDistance;

		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1404", Offset = "0x3E1404")]
		public int downsample;

		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xB2A34C", Offset = "0xB2A34C", VA = "0xB2A34C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xB2A3B0", Offset = "0xB2A3B0", VA = "0xB2A3B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xB2A454", Offset = "0xB2A454", VA = "0xB2A454")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xB2AA44", Offset = "0xB2AA44", VA = "0xB2AA44")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E01A8", Offset = "0x3E01A8")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E01A8", Offset = "0x3E01A8")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200014C")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000688")]
			Low,
			[Token(Token = "0x4000689")]
			Medium,
			[Token(Token = "0x400068A")]
			High
		}

		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E141C", Offset = "0x3E141C")]
		public float m_Radius;

		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1438", Offset = "0x3E1438")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1450", Offset = "0x3E1450")]
		public int m_Blur;

		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1468", Offset = "0x3E1468")]
		public int m_Downsampling;

		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1480", Offset = "0x3E1480")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E149C", Offset = "0x3E149C")]
		public float m_MinZ;

		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xB2AA64", Offset = "0xB2AA64", VA = "0xB2AA64")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xB2AB1C", Offset = "0xB2AB1C", VA = "0xB2AB1C")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xB2ABB4", Offset = "0xB2ABB4", VA = "0xB2ABB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xB2ABBC", Offset = "0xB2ABBC", VA = "0xB2ABBC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xB2AD54", Offset = "0xB2AD54", VA = "0xB2AD54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xB2AC90", Offset = "0xB2AC90", VA = "0xB2AC90")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xB2ADC4", Offset = "0xB2ADC4", VA = "0xB2ADC4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xB2B43C", Offset = "0xB2B43C", VA = "0xB2B43C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E023C", Offset = "0x3E023C")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xB2B644", Offset = "0xB2B644", VA = "0xB2B644")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xB2B6D4", Offset = "0xB2B6D4", VA = "0xB2B6D4")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E0288", Offset = "0x3E0288")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E0288", Offset = "0x3E0288")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x200014F")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000693")]
			TiltShiftMode,
			[Token(Token = "0x4000694")]
			IrisMode
		}

		[Token(Token = "0x2000150")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000696")]
			Preview,
			[Token(Token = "0x4000697")]
			Normal,
			[Token(Token = "0x4000698")]
			High
		}

		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E14B8", Offset = "0x3E14B8")]
		public float blurArea;

		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E14D0", Offset = "0x3E14D0")]
		public float maxBlurSize;

		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E14E8", Offset = "0x3E14E8")]
		public int downsample;

		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xB2F840", Offset = "0xB2F840", VA = "0xB2F840", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xB2F8A4", Offset = "0xB2F8A4", VA = "0xB2F8A4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xB2FB60", Offset = "0xB2FB60", VA = "0xB2FB60")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E030C", Offset = "0x3E030C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E030C", Offset = "0x3E030C")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000152")]
		public enum TonemapperType
		{
			[Token(Token = "0x40006A7")]
			SimpleReinhard,
			[Token(Token = "0x40006A8")]
			UserCurve,
			[Token(Token = "0x40006A9")]
			Hable,
			[Token(Token = "0x40006AA")]
			Photographic,
			[Token(Token = "0x40006AB")]
			OptimizedHejiDawson,
			[Token(Token = "0x40006AC")]
			AdaptiveReinhard,
			[Token(Token = "0x40006AD")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000153")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x40006AF")]
			Square16 = 0x10,
			[Token(Token = "0x40006B0")]
			Square32 = 0x20,
			[Token(Token = "0x40006B1")]
			Square64 = 0x40,
			[Token(Token = "0x40006B2")]
			Square128 = 0x80,
			[Token(Token = "0x40006B3")]
			Square256 = 0x100,
			[Token(Token = "0x40006B4")]
			Square512 = 0x200,
			[Token(Token = "0x40006B5")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xB301D4", Offset = "0xB301D4", VA = "0xB301D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xB30324", Offset = "0xB30324", VA = "0xB30324")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xB305C8", Offset = "0xB305C8", VA = "0xB305C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xB3071C", Offset = "0xB3071C", VA = "0xB3071C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xB30814", Offset = "0xB30814", VA = "0xB30814")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xB31078", Offset = "0xB31078", VA = "0xB31078")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000154")]
	internal class Triangles
	{
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xB31124", Offset = "0xB31124", VA = "0xB31124")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xB31268", Offset = "0xB31268", VA = "0xB31268")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xB31440", Offset = "0xB31440", VA = "0xB31440")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xB316C8", Offset = "0xB316C8", VA = "0xB316C8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xB319E4", Offset = "0xB319E4", VA = "0xB319E4")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E03A0", Offset = "0x3E03A0")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3E1500", Offset = "0x3E1500")]
		public float angle;

		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xB323F8", Offset = "0xB323F8", VA = "0xB323F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xB32444", Offset = "0xB32444", VA = "0xB32444")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E03EC", Offset = "0x3E03EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E03EC", Offset = "0x3E03EC")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000157")]
		public enum AberrationMode
		{
			[Token(Token = "0x40006CA")]
			Simple,
			[Token(Token = "0x40006CB")]
			Advanced
		}

		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xB32874", Offset = "0xB32874", VA = "0xB32874", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xB3290C", Offset = "0xB3290C", VA = "0xB3290C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xB32EFC", Offset = "0xB32EFC", VA = "0xB32EFC")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000158")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3E0480", Offset = "0x3E0480")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xB3360C", Offset = "0xB3360C", VA = "0xB3360C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xB33658", Offset = "0xB33658", VA = "0xB33658")]
		public Vortex()
		{
		}
	}
}
