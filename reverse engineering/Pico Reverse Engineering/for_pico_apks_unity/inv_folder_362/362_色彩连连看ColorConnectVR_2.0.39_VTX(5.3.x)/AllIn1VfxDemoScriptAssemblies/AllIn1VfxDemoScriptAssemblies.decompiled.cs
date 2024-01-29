using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace AllIn1VfxToolkit.Demo.Scripts;

[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEF6D60", Offset = "0xEF6D60")]
public class All1DemoDropdownScroller : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int dropdownElementCount;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private KeyCode nextDropdownElementKey;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	private Dropdown dropdown;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3842C7C", Offset = "0x3842C7C", VA = "0x3842C7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x3842CD8", Offset = "0x3842CD8", VA = "0x3842CD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3842D14", Offset = "0x3842D14", VA = "0x3842D14")]
	private void NextDropdownElements()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3842D54", Offset = "0x3842D54", VA = "0x3842D54")]
	public All1DemoDropdownScroller()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEF6DC0", Offset = "0xEF6DC0")]
public class All1DemoMouseLocker : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private KeyCode mouseLockerKey;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image lockButtonImage;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color lockButtonColor;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	private AllIn1MouseRotate allIn1MouseRotate;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	private AllIn1DemoScaleTween lockedTween;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	private Text pausedButtonText;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x50")]
	private bool currentlyLocked;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3842D64", Offset = "0x3842D64", VA = "0x3842D64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3842E30", Offset = "0x3842E30", VA = "0x3842E30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3842E6C", Offset = "0x3842E6C", VA = "0x3842E6C")]
	public void DoMouseLockToggle()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3842F94", Offset = "0x3842F94", VA = "0x3842F94")]
	public All1DemoMouseLocker()
	{
	}
}
[Token(Token = "0x2000004")]
public class All1DemoProjectileObstacle : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] projectileObstacles;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	private Dropdown projectileObstacleDropdown;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3842FA4", Offset = "0x3842FA4", VA = "0x3842FA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3843008", Offset = "0x3843008", VA = "0x3843008")]
	public void DropdownValueChanged()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3843024", Offset = "0x3843024", VA = "0x3843024")]
	private void SetProjectileObstacleN(int nIndex)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x38430A4", Offset = "0x38430A4", VA = "0x38430A4")]
	public All1DemoProjectileObstacle()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEF6E20", Offset = "0xEF6E20")]
public class All1DemoSceneColor : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color[] sceneColors;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera targetCamera;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float cameraColorMult;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MeshRenderer floorMeshRenderer;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float floorColorMult;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float fogColorMult;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x40")]
	private Dropdown sceneColorDropdown;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x48")]
	private Material floorMaterial;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x38430AC", Offset = "0x38430AC", VA = "0x38430AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3843134", Offset = "0x3843134", VA = "0x3843134")]
	public void DropdownValueChanged()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3843150", Offset = "0x3843150", VA = "0x3843150")]
	private void SetSceneColor(int nIndex)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x384323C", Offset = "0x384323C", VA = "0x384323C")]
	public All1DemoSceneColor()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xEF6E80", Offset = "0xEF6E80")]
public class All1VfxDemoEffect : ScriptableObject
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7080", Offset = "0xEF7080")]
	public bool onlyOneAtATime;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x19")]
	public bool canBePlayedAgain;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x1C")]
	public float randomSpreadRadius;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	public float cooldown;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF70B8", Offset = "0xEF70B8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF70B8", Offset = "0xEF70B8")]
	public bool isShootProjectile;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7104", Offset = "0xEF7104")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7104", Offset = "0xEF7104")]
	public GameObject effectPrefab;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	public bool spawnTouchingFloor;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7150", Offset = "0xEF7150")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7150", Offset = "0xEF7150")]
	public float projectileSpeed;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject projectilePrefab;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject muzzleFlashPrefab;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject impactPrefab;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF719C", Offset = "0xEF719C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF719C", Offset = "0xEF719C")]
	public bool doCameraShake;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x54")]
	public float mainEffectShakeAmount;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF71E8", Offset = "0xEF71E8")]
	public float projectileImpactShakeAmount;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7220", Offset = "0xEF7220")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7220", Offset = "0xEF7220")]
	public Vector3 positionOffset;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x68")]
	public float scaleMultiplier;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3843254", Offset = "0x3843254", VA = "0x3843254")]
	public All1VfxDemoEffect()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xEF6EE0", Offset = "0xEF6EE0")]
public class All1VfxDemoEffectCollection : ScriptableObject
{
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	public All1VfxDemoEffect[] demoEffectCollection;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3843284", Offset = "0x3843284", VA = "0x3843284")]
	public All1VfxDemoEffectCollection()
	{
	}
}
[Token(Token = "0x2000008")]
public class AllIn1AutoRotate : MonoBehaviour
{
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float rotationSpeed;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 rotationAxis;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x384328C", Offset = "0x384328C", VA = "0x384328C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x38432F8", Offset = "0x38432F8", VA = "0x38432F8")]
	public AllIn1AutoRotate()
	{
	}
}
[Token(Token = "0x2000009")]
public class AllIn1CanvasFader : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private KeyCode fadeToggleKey;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float tweenSpeed;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AllIn1DemoScaleTween hideUiButtonTween;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x28")]
	private bool isTweening;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x2C")]
	private float currentAlpha;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x30")]
	private float targetAlpha;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x38")]
	private CanvasGroup canvasGroup;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x40")]
	private bool hideUiButtonTweenNotNull;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3843334", Offset = "0x3843334", VA = "0x3843334")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x38433F4", Offset = "0x38433F4", VA = "0x38433F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3843484", Offset = "0x3843484", VA = "0x3843484")]
	public void HideUiButtonPressed()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x38434E0", Offset = "0x38434E0", VA = "0x38434E0")]
	private void MakeCanvasVisibleTween()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x38434F4", Offset = "0x38434F4", VA = "0x38434F4")]
	private void MakeCanvasInvisibleTween()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3843504", Offset = "0x3843504", VA = "0x3843504")]
	public AllIn1CanvasFader()
	{
	}
}
[Token(Token = "0x200000A")]
public class AllIn1ChangeAllChildTextFonts : MonoBehaviour
{
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Font newFont;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool changeFontOnStart;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3843520", Offset = "0x3843520", VA = "0x3843520")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3843530", Offset = "0x3843530", VA = "0x3843530")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xEF793C", Offset = "0xEF793C")]
	private void ChangeFonts()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x38435E0", Offset = "0x38435E0", VA = "0x38435E0")]
	public AllIn1ChangeAllChildTextFonts()
	{
	}
}
[Token(Token = "0x200000B")]
public class AllIn1DemoProjectile : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float inaccurateAmount;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	private GameObject currentImpactPrefab;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	private Transform currentHierarchyParent;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x30")]
	private bool doImpactSpawn;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x31")]
	private bool doShake;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x34")]
	private float shakeAmountOnImpact;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x38")]
	private float impactScaleSize;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x38435E8", Offset = "0x38435E8", VA = "0x38435E8")]
	public void Initialize(Transform hierarchyParent, Vector3 projectileDir, float speed, GameObject impactPrefab, float impactScaleSize)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3843780", Offset = "0x3843780", VA = "0x3843780")]
	public void AddScreenShakeOnImpact(float projectileImpactShakeAmount)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3843704", Offset = "0x3843704", VA = "0x3843704")]
	private void ApplyPrecisionOffsetToProjectileDir(ref Vector3 projectileDir)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3843790", Offset = "0x3843790", VA = "0x3843790")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x384394C", Offset = "0x384394C", VA = "0x384394C")]
	public AllIn1DemoProjectile()
	{
	}
}
[Token(Token = "0x200000C")]
public class AllIn1DemoScaleTween : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float maxTweenScale;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float minTweenScale;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float tweenSpeed;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x24")]
	private bool isTweening;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x28")]
	private float currentScale;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 scaleToApply;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3843960", Offset = "0x3843960", VA = "0x3843960")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x38439E4", Offset = "0x38439E4", VA = "0x38439E4")]
	private void UpdateScaleToApply()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x38439F0", Offset = "0x38439F0", VA = "0x38439F0")]
	private void ApplyScale()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3842F7C", Offset = "0x3842F7C", VA = "0x3842F7C")]
	public void ScaleUpTween()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3843A28", Offset = "0x3843A28", VA = "0x3843A28")]
	public void ScaleDownTween()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3843A40", Offset = "0x3843A40", VA = "0x3843A40")]
	public AllIn1DemoScaleTween()
	{
	}
}
[Token(Token = "0x200000D")]
public class AllIn1DoShake : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float shakeAmount;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool doShakeOnStart;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float shakeOnStartDelay;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3843A90", Offset = "0x3843A90", VA = "0x3843A90")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3843B2C", Offset = "0x3843B2C", VA = "0x3843B2C")]
	public void DoShake()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3843B8C", Offset = "0x3843B8C", VA = "0x3843B8C")]
	public AllIn1DoShake()
	{
	}
}
[Token(Token = "0x200000E")]
public class AllIn1MouseRotate : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform objectToRotate;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float rotationSpeedHorizontal;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float translateVerticalSpeed;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float translateScrollSpeed;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF738C", Offset = "0xEF738C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF738C", Offset = "0xEF738C")]
	private bool lockCursor;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private KeyCode lockCursorKeyCode;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AllIn1DemoScaleTween hideUiButtonTween;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image lockedButtonImage;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text lockedButtonText;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color lockedButtonColor;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x60")]
	private bool cursorIsLocked;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7438", Offset = "0xEF7438")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7438", Offset = "0xEF7438")]
	private float maxHeight;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float maxZoom;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float minZoom;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 currPosition;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x7C")]
	private float dt;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3843BA0", Offset = "0x3843BA0", VA = "0x3843BA0")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3843CD8", Offset = "0x3843CD8", VA = "0x3843CD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3843D68", Offset = "0x3843D68", VA = "0x3843D68")]
	private void CamRotateAroundYAxis()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3843E44", Offset = "0x3843E44", VA = "0x3843E44")]
	private void CamHeightTranslate()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3843F00", Offset = "0x3843F00", VA = "0x3843F00")]
	private void CamZoom()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3843BB0", Offset = "0x3843BB0", VA = "0x3843BB0")]
	public void ToggleCursorLocked()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x38440C4", Offset = "0x38440C4", VA = "0x38440C4")]
	public AllIn1MouseRotate()
	{
	}
}
[Token(Token = "0x200000F")]
public class AllIn1Shaker : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 maximumTranslationShake;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 maximumAngularShake;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float shakeFrequency;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float shakeSmoothingExponent;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float shakeRecoverPerSecond;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x0")]
	public static AllIn1Shaker i;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x3C")]
	private float currentShakeAmount;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x40")]
	private float seed;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3844120", Offset = "0x3844120", VA = "0x3844120")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x384424C", Offset = "0x384424C", VA = "0x384424C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x38442B4", Offset = "0x38442B4", VA = "0x38442B4")]
	private float SmoothShakeToApply()
	{
		return default(float);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x38443D4", Offset = "0x38443D4", VA = "0x38443D4")]
	private void ShakeRotation(float shake)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x38442C0", Offset = "0x38442C0", VA = "0x38442C0")]
	private void ShakePosition(float shake)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x38444F8", Offset = "0x38444F8", VA = "0x38444F8")]
	public void DoCameraShake(float shakeAmount)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3844500", Offset = "0x3844500", VA = "0x3844500")]
	public AllIn1Shaker()
	{
	}
}
[Token(Token = "0x2000010")]
public class AllIn1TimeControl : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private KeyCode increaseTimeScale;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private KeyCode increaseTimeScaleAlt;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private KeyCode decreaseTimeScale;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private KeyCode decreaseTimeScaleAlt;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private KeyCode pauseKey;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEF7554", Offset = "0xEF7554")]
	private float timeScaleInterval;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider timeScaleSlider;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image pausedButtonImage;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color pausedButtonColor;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x50")]
	private bool timeScaleSliderNotNull;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x54")]
	private float lastChangeTime;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x58")]
	private AllIn1DemoScaleTween pausedButtonTween;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x60")]
	private Text pausedButtonText;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3844568", Offset = "0x3844568", VA = "0x3844568")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x384480C", Offset = "0x384480C", VA = "0x384480C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3844980", Offset = "0x3844980", VA = "0x3844980")]
	private void ChangeTimeScale(float changeAmount)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3844704", Offset = "0x3844704", VA = "0x3844704")]
	private void UpdateTimeScaleUI()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x38449DC", Offset = "0x38449DC", VA = "0x38449DC")]
	public void PauseUiButton()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3844A28", Offset = "0x3844A28", VA = "0x3844A28")]
	public void CurrentEffectChanged()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3844A7C", Offset = "0x3844A7C", VA = "0x3844A7C")]
	public AllIn1TimeControl()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3844AA0", Offset = "0x3844AA0", VA = "0x3844AA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEF7974", Offset = "0xEF7974")]
	private void <Start>b__13_0(float <p0>)
	{
	}
}
[Token(Token = "0x2000011")]
public class AllIn1VfxAutoDestroy : MonoBehaviour
{
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float destroyTime;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3844AF4", Offset = "0x3844AF4", VA = "0x3844AF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3844B7C", Offset = "0x3844B7C", VA = "0x3844B7C")]
	public AllIn1VfxAutoDestroy()
	{
	}
}
[Token(Token = "0x2000012")]
public class AllIn1VfxDemoController : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEF6F40", Offset = "0xEF6F40")]
	private sealed class <CurrentEffectLabelTweenEffectCR>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		public AllIn1VfxDemoController <>4__this;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x28")]
		private Color <startColor>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x3846174", Offset = "0x3846174", VA = "0x3846174", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x38461BC", Offset = "0x38461BC", VA = "0x38461BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x3845C4C", Offset = "0x3845C4C", VA = "0x3845C4C")]
		[DebuggerHidden]
		public <CurrentEffectLabelTweenEffectCR>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3846038", Offset = "0x3846038", VA = "0x3846038", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x384603C", Offset = "0x384603C", VA = "0x384603C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x384617C", Offset = "0x384617C", VA = "0x384617C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int startingCollectionIndex;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int startingEffectIndex;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF75F4", Offset = "0xEF75F4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF75F4", Offset = "0xEF75F4")]
	[SerializeField]
	private All1VfxDemoEffectCollection[] effectsToSpawnCollections;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7650", Offset = "0xEF7650")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7650", Offset = "0xEF7650")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7650", Offset = "0xEF7650")]
	[SerializeField]
	private GameObject projectileBasePrefab;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject projectileSceneSetupObject;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform projectileSpawnPoint;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF76DC", Offset = "0xEF76DC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF76DC", Offset = "0xEF76DC")]
	[SerializeField]
	private KeyCode playEffectKey;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private KeyCode nextEffectKey;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private KeyCode nextEffectKeyAlt;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private KeyCode previousEffectKey;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private KeyCode previousEffectKeyAlt;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7778", Offset = "0xEF7778")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF7778", Offset = "0xEF7778")]
	private Text currentEffectLabel;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button playEffectButton;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject playEffectInstructionsGo;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Button nextEffectButton;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button previousEffectButton;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform groundSpawnTransform;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform cameraPivotTransform;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float camPivotHeightSmoothing;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject projectileEffectUI;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject normalEffectUI;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0xA8")]
	private All1VfxDemoEffect currDemoEffect;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0xB0")]
	private int currDemoCollectionIndex;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0xB4")]
	private int currDemoEffectIndex;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0xB8")]
	private int currentEffectPlays;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0xC0")]
	private AllIn1DemoScaleTween currLabelTween;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0xC8")]
	private AllIn1DemoScaleTween playButtTween;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0xD0")]
	private AllIn1DemoScaleTween nextButtTween;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0xD8")]
	private AllIn1DemoScaleTween prevButtTween;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0xE0")]
	private float timeSinceEffectPlay;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0xE8")]
	private AllIn1TimeControl allIn1TimeControl;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3844B8C", Offset = "0x3844B8C", VA = "0x3844B8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3844E50", Offset = "0x3844E50", VA = "0x3844E50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3845768", Offset = "0x3845768", VA = "0x3845768")]
	private void CooldownHandling()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x384500C", Offset = "0x384500C", VA = "0x384500C")]
	public void PlayCurrentEffect(bool isAfterSetupAndInstantiateEffect = false)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x38456E0", Offset = "0x38456E0", VA = "0x38456E0")]
	public void ChangeCurrentEffect(int changeAmount)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3844CC4", Offset = "0x3844CC4", VA = "0x3844CC4")]
	private void SetupAndInstantiateCurrentEffect()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3845B44", Offset = "0x3845B44", VA = "0x3845B44")]
	private void ComputeValidEffectAndCollectionIndex()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x3845ACC", Offset = "0x3845ACC", VA = "0x3845ACC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xEF7984", Offset = "0xEF7984")]
	private IEnumerator CurrentEffectLabelTweenEffectCR()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x38457F8", Offset = "0x38457F8", VA = "0x38457F8")]
	private void DestroyAllChildren()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3845C78", Offset = "0x3845C78", VA = "0x3845C78")]
	public AllIn1VfxDemoController()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEF6F50", Offset = "0xEF6F50")]
public class AllIn1VfxFadeLight : MonoBehaviour
{
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float fadeDuration;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool destroyWhenFaded;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	private Light targetLight;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	private float animationRatioRemaining;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x2C")]
	private float iniLightIntensity;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3845C94", Offset = "0x3845C94", VA = "0x3845C94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x3845D0C", Offset = "0x3845D0C", VA = "0x3845D0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3845DF0", Offset = "0x3845DF0", VA = "0x3845DF0")]
	public AllIn1VfxFadeLight()
	{
	}
}
[Token(Token = "0x2000015")]
[ExecuteInEditMode]
public class AllIn1VfxParticleSystemTime : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool updateEveryFrame;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF7894", Offset = "0xEF7894")]
	[SerializeField]
	private Vector2 simulationTimeRange;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xEF78E0", Offset = "0xEF78E0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xEF78E0", Offset = "0xEF78E0")]
	[SerializeField]
	private ParticleSystem targetPs;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x30")]
	private bool isValid;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3845E14", Offset = "0x3845E14", VA = "0x3845E14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3845FE8", Offset = "0x3845FE8", VA = "0x3845FE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3845FF8", Offset = "0x3845FF8", VA = "0x3845FF8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3845E18", Offset = "0x3845E18", VA = "0x3845E18")]
	private void SetSimulationTime()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3845FFC", Offset = "0x3845FFC", VA = "0x3845FFC")]
	public AllIn1VfxParticleSystemTime()
	{
	}
}
