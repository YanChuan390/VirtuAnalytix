using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace AllIn1VfxToolkit.DemoAssets.TexturesDemo.Scripts;

[Token(Token = "0x2000002")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xF22C74", Offset = "0xF22C74")]
public class All1VfxDemoTextureCollection : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public string collectionName;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public Texture[] demoTextureCollection;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x38BBB20", Offset = "0x38BBB20", VA = "0x38BBB20")]
	public All1VfxDemoTextureCollection()
	{
	}
}
[Token(Token = "0x2000003")]
public class AllIn1DemoScaleTween : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float maxTweenScale;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float minTweenScale;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float tweenSpeed;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x24")]
	private bool isTweening;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	private float currentScale;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x2C")]
	private float iniScale;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 scaleToApply;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x38BBB28", Offset = "0x38BBB28", VA = "0x38BBB28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x38BBB60", Offset = "0x38BBB60", VA = "0x38BBB60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x38BBBE4", Offset = "0x38BBBE4", VA = "0x38BBBE4")]
	private void UpdateScaleToApply()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x38BBBF0", Offset = "0x38BBBF0", VA = "0x38BBBF0")]
	private void ApplyScale()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x38BBC28", Offset = "0x38BBC28", VA = "0x38BBC28")]
	public void ScaleUpTween()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x38BBC48", Offset = "0x38BBC48", VA = "0x38BBC48")]
	public void ScaleDownTween()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x38BBC68", Offset = "0x38BBC68", VA = "0x38BBC68")]
	public AllIn1DemoScaleTween()
	{
	}
}
[Token(Token = "0x2000004")]
public class AllIn1VfxTextureDemoManager : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int startingCollectionIndex;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int startingPageIndex;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "SpaceAttribute", RVA = "0xF22D24", Offset = "0xF22D24")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xF22D24", Offset = "0xF22D24")]
	[SerializeField]
	private All1VfxDemoTextureCollection[] textureCollections;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "SpaceAttribute", RVA = "0xF22D80", Offset = "0xF22D80")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xF22D80", Offset = "0xF22D80")]
	[SerializeField]
	private KeyCode nextPageKey;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private KeyCode nextPageKeyAlt;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private KeyCode previousPageKey;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private KeyCode previousPageKeyAlt;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private KeyCode nextCollectionKey;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private KeyCode nextCollectionKeyAlt;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private KeyCode previousCollectionKey;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private KeyCode previousCollectionKeyAlt;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "SpaceAttribute", RVA = "0xF22E4C", Offset = "0xF22E4C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xF22E4C", Offset = "0xF22E4C")]
	[SerializeField]
	private RawImage[] images;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text collectionText;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text pageText;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AllIn1DemoScaleTween expositorTween;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AllIn1DemoScaleTween nextPageButtTween;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AllIn1DemoScaleTween prevPageButtTween;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AllIn1DemoScaleTween nextCollectionButtTween;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AllIn1DemoScaleTween prevCollectionButtTween;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x88")]
	private int currTextureCollectionIndex;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x8C")]
	private int currTextureIndex;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x90")]
	private int numberOfImagesPerPage;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x38BBCB8", Offset = "0x38BBCB8", VA = "0x38BBCB8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x38BBFD4", Offset = "0x38BBFD4", VA = "0x38BBFD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x38BC0A8", Offset = "0x38BC0A8", VA = "0x38BC0A8")]
	public void ChangeTextureIndex(int pagesAmount)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x38BC1A0", Offset = "0x38BC1A0", VA = "0x38BC1A0")]
	public void ChangeCollectionIndex(int collectionChangeAmount)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x38BBCF8", Offset = "0x38BBCF8", VA = "0x38BBCF8")]
	private void RefreshCollectionAndPageText()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x38BBE9C", Offset = "0x38BBE9C", VA = "0x38BBE9C")]
	private void AssignCurrentImages()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x38BC2C0", Offset = "0x38BC2C0", VA = "0x38BC2C0")]
	public AllIn1VfxTextureDemoManager()
	{
	}
}
