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
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDCF1E4", Offset = "0xDCF1E4")]
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
	[Address(RVA = "0x2593424", Offset = "0x2593424", VA = "0x2593424")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2593480", Offset = "0x2593480", VA = "0x2593480")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x25934BC", Offset = "0x25934BC", VA = "0x25934BC")]
	private void NextDropdownElements()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x25934FC", Offset = "0x25934FC", VA = "0x25934FC")]
	public All1DemoDropdownScroller()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDCF244", Offset = "0xDCF244")]
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
	[Address(RVA = "0x259350C", Offset = "0x259350C", VA = "0x259350C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x25935D8", Offset = "0x25935D8", VA = "0x25935D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2593614", Offset = "0x2593614", VA = "0x2593614")]
	public void DoMouseLockToggle()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x259373C", Offset = "0x259373C", VA = "0x259373C")]
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
	[Address(RVA = "0x259374C", Offset = "0x259374C", VA = "0x259374C")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x25937B0", Offset = "0x25937B0", VA = "0x25937B0")]
	public void DropdownValueChanged()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x25937CC", Offset = "0x25937CC", VA = "0x25937CC")]
	private void SetProjectileObstacleN(int nIndex)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x259384C", Offset = "0x259384C", VA = "0x259384C")]
	public All1DemoProjectileObstacle()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDCF2A4", Offset = "0xDCF2A4")]
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
	[Address(RVA = "0x2593854", Offset = "0x2593854", VA = "0x2593854")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x25938DC", Offset = "0x25938DC", VA = "0x25938DC")]
	public void DropdownValueChanged()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x25938F8", Offset = "0x25938F8", VA = "0x25938F8")]
	private void SetSceneColor(int nIndex)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x25939E4", Offset = "0x25939E4", VA = "0x25939E4")]
	public All1DemoSceneColor()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xDCF304", Offset = "0xDCF304")]
public class All1VfxDemoEffect : ScriptableObject
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF504", Offset = "0xDCF504")]
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
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF53C", Offset = "0xDCF53C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF53C", Offset = "0xDCF53C")]
	public bool isShootProjectile;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF588", Offset = "0xDCF588")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF588", Offset = "0xDCF588")]
	public GameObject effectPrefab;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	public bool spawnTouchingFloor;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF5D4", Offset = "0xDCF5D4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF5D4", Offset = "0xDCF5D4")]
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
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF620", Offset = "0xDCF620")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF620", Offset = "0xDCF620")]
	public bool doCameraShake;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x54")]
	public float mainEffectShakeAmount;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF66C", Offset = "0xDCF66C")]
	public float projectileImpactShakeAmount;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF6A4", Offset = "0xDCF6A4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF6A4", Offset = "0xDCF6A4")]
	public Vector3 positionOffset;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x68")]
	public float scaleMultiplier;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x25939FC", Offset = "0x25939FC", VA = "0x25939FC")]
	public All1VfxDemoEffect()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xDCF364", Offset = "0xDCF364")]
public class All1VfxDemoEffectCollection : ScriptableObject
{
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	public All1VfxDemoEffect[] demoEffectCollection;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2593A2C", Offset = "0x2593A2C", VA = "0x2593A2C")]
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
	[Address(RVA = "0x2593A34", Offset = "0x2593A34", VA = "0x2593A34")]
	private void Update()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2593AA0", Offset = "0x2593AA0", VA = "0x2593AA0")]
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
	[Address(RVA = "0x2593ADC", Offset = "0x2593ADC", VA = "0x2593ADC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2593B9C", Offset = "0x2593B9C", VA = "0x2593B9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2593C2C", Offset = "0x2593C2C", VA = "0x2593C2C")]
	public void HideUiButtonPressed()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2593C88", Offset = "0x2593C88", VA = "0x2593C88")]
	private void MakeCanvasVisibleTween()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2593C9C", Offset = "0x2593C9C", VA = "0x2593C9C")]
	private void MakeCanvasInvisibleTween()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2593CAC", Offset = "0x2593CAC", VA = "0x2593CAC")]
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
	[Address(RVA = "0x2593CC8", Offset = "0x2593CC8", VA = "0x2593CC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2593CD8", Offset = "0x2593CD8", VA = "0x2593CD8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xDCFDC0", Offset = "0xDCFDC0")]
	private void ChangeFonts()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2593D88", Offset = "0x2593D88", VA = "0x2593D88")]
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
	[Address(RVA = "0x2593D90", Offset = "0x2593D90", VA = "0x2593D90")]
	public void Initialize(Transform hierarchyParent, Vector3 projectileDir, float speed, GameObject impactPrefab, float impactScaleSize)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2593F28", Offset = "0x2593F28", VA = "0x2593F28")]
	public void AddScreenShakeOnImpact(float projectileImpactShakeAmount)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2593EAC", Offset = "0x2593EAC", VA = "0x2593EAC")]
	private void ApplyPrecisionOffsetToProjectileDir(ref Vector3 projectileDir)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2593F38", Offset = "0x2593F38", VA = "0x2593F38")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x25940F4", Offset = "0x25940F4", VA = "0x25940F4")]
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
	[Address(RVA = "0x2594108", Offset = "0x2594108", VA = "0x2594108")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x259418C", Offset = "0x259418C", VA = "0x259418C")]
	private void UpdateScaleToApply()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2594198", Offset = "0x2594198", VA = "0x2594198")]
	private void ApplyScale()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2593724", Offset = "0x2593724", VA = "0x2593724")]
	public void ScaleUpTween()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x25941D0", Offset = "0x25941D0", VA = "0x25941D0")]
	public void ScaleDownTween()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x25941E8", Offset = "0x25941E8", VA = "0x25941E8")]
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
	[Address(RVA = "0x2594238", Offset = "0x2594238", VA = "0x2594238")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x25942D4", Offset = "0x25942D4", VA = "0x25942D4")]
	public void DoShake()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2594334", Offset = "0x2594334", VA = "0x2594334")]
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
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF810", Offset = "0xDCF810")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF810", Offset = "0xDCF810")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCF8BC", Offset = "0xDCF8BC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCF8BC", Offset = "0xDCF8BC")]
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
	[Address(RVA = "0x2594348", Offset = "0x2594348", VA = "0x2594348")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2594480", Offset = "0x2594480", VA = "0x2594480")]
	private void Update()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2594510", Offset = "0x2594510", VA = "0x2594510")]
	private void CamRotateAroundYAxis()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x25945EC", Offset = "0x25945EC", VA = "0x25945EC")]
	private void CamHeightTranslate()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x25946A8", Offset = "0x25946A8", VA = "0x25946A8")]
	private void CamZoom()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2594358", Offset = "0x2594358", VA = "0x2594358")]
	public void ToggleCursorLocked()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x259486C", Offset = "0x259486C", VA = "0x259486C")]
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
	[Address(RVA = "0x25948C8", Offset = "0x25948C8", VA = "0x25948C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x25949F4", Offset = "0x25949F4", VA = "0x25949F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2594A5C", Offset = "0x2594A5C", VA = "0x2594A5C")]
	private float SmoothShakeToApply()
	{
		return default(float);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2594B7C", Offset = "0x2594B7C", VA = "0x2594B7C")]
	private void ShakeRotation(float shake)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2594A68", Offset = "0x2594A68", VA = "0x2594A68")]
	private void ShakePosition(float shake)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2594CA0", Offset = "0x2594CA0", VA = "0x2594CA0")]
	public void DoCameraShake(float shakeAmount)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2594CA8", Offset = "0x2594CA8", VA = "0x2594CA8")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDCF9D8", Offset = "0xDCF9D8")]
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
	[Address(RVA = "0x2594D10", Offset = "0x2594D10", VA = "0x2594D10")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2594FB4", Offset = "0x2594FB4", VA = "0x2594FB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2595128", Offset = "0x2595128", VA = "0x2595128")]
	private void ChangeTimeScale(float changeAmount)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2594EAC", Offset = "0x2594EAC", VA = "0x2594EAC")]
	private void UpdateTimeScaleUI()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2595184", Offset = "0x2595184", VA = "0x2595184")]
	public void PauseUiButton()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x25951D0", Offset = "0x25951D0", VA = "0x25951D0")]
	public void CurrentEffectChanged()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2595224", Offset = "0x2595224", VA = "0x2595224")]
	public AllIn1TimeControl()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2595248", Offset = "0x2595248", VA = "0x2595248")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDCFDF8", Offset = "0xDCFDF8")]
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
	[Address(RVA = "0x259529C", Offset = "0x259529C", VA = "0x259529C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2595324", Offset = "0x2595324", VA = "0x2595324")]
	public AllIn1VfxAutoDestroy()
	{
	}
}
[Token(Token = "0x2000012")]
public class AllIn1VfxDemoController : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDCF3C4", Offset = "0xDCF3C4")]
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
			[Address(RVA = "0x259691C", Offset = "0x259691C", VA = "0x259691C", Slot = "4")]
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
			[Address(RVA = "0x2596964", Offset = "0x2596964", VA = "0x2596964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x25963F4", Offset = "0x25963F4", VA = "0x25963F4")]
		[DebuggerHidden]
		public <CurrentEffectLabelTweenEffectCR>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x25967E0", Offset = "0x25967E0", VA = "0x25967E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x25967E4", Offset = "0x25967E4", VA = "0x25967E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2596924", Offset = "0x2596924", VA = "0x2596924", Slot = "8")]
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
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCFA78", Offset = "0xDCFA78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCFA78", Offset = "0xDCFA78")]
	[SerializeField]
	private All1VfxDemoEffectCollection[] effectsToSpawnCollections;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCFAD4", Offset = "0xDCFAD4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCFAD4", Offset = "0xDCFAD4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCFAD4", Offset = "0xDCFAD4")]
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
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCFB60", Offset = "0xDCFB60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCFB60", Offset = "0xDCFB60")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCFBFC", Offset = "0xDCFBFC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCFBFC", Offset = "0xDCFBFC")]
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
	[Address(RVA = "0x2595334", Offset = "0x2595334", VA = "0x2595334")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x25955F8", Offset = "0x25955F8", VA = "0x25955F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2595F10", Offset = "0x2595F10", VA = "0x2595F10")]
	private void CooldownHandling()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x25957B4", Offset = "0x25957B4", VA = "0x25957B4")]
	public void PlayCurrentEffect(bool isAfterSetupAndInstantiateEffect = false)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2595E88", Offset = "0x2595E88", VA = "0x2595E88")]
	public void ChangeCurrentEffect(int changeAmount)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x259546C", Offset = "0x259546C", VA = "0x259546C")]
	private void SetupAndInstantiateCurrentEffect()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x25962EC", Offset = "0x25962EC", VA = "0x25962EC")]
	private void ComputeValidEffectAndCollectionIndex()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2596274", Offset = "0x2596274", VA = "0x2596274")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDCFE08", Offset = "0xDCFE08")]
	private IEnumerator CurrentEffectLabelTweenEffectCR()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2595FA0", Offset = "0x2595FA0", VA = "0x2595FA0")]
	private void DestroyAllChildren()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2596420", Offset = "0x2596420", VA = "0x2596420")]
	public AllIn1VfxDemoController()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDCF3D4", Offset = "0xDCF3D4")]
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
	[Address(RVA = "0x259643C", Offset = "0x259643C", VA = "0x259643C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x25964B4", Offset = "0x25964B4", VA = "0x25964B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2596598", Offset = "0x2596598", VA = "0x2596598")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCFD18", Offset = "0xDCFD18")]
	[SerializeField]
	private Vector2 simulationTimeRange;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xDCFD64", Offset = "0xDCFD64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDCFD64", Offset = "0xDCFD64")]
	[SerializeField]
	private ParticleSystem targetPs;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x30")]
	private bool isValid;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x25965BC", Offset = "0x25965BC", VA = "0x25965BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2596790", Offset = "0x2596790", VA = "0x2596790")]
	private void Update()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x25967A0", Offset = "0x25967A0", VA = "0x25967A0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x25965C0", Offset = "0x25965C0", VA = "0x25965C0")]
	private void SetSimulationTime()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x25967A4", Offset = "0x25967A4", VA = "0x25967A4")]
	public AllIn1VfxParticleSystemTime()
	{
	}
}
