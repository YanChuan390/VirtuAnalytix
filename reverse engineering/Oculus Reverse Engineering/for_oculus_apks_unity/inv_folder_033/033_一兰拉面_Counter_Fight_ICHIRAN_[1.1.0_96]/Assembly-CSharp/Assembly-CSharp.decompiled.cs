using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using PlayFab;
using PlayFab.ClientModels;
using RootMotion.FinalIK;
using TMPro;
using Unity.RemoteConfig;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CSVSerializer
{
	[Token(Token = "0x6000001")]
	public static T[] Deserialize<T>(string text)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	public static T[] Deserialize<T>(List<string[]> rows)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	public static T DeserializeIdValue<T>(string text, int id_col = 0, int value_col = 1)
	{
		return (T)null;
	}

	[Token(Token = "0x6000004")]
	public static T DeserializeIdValue<T>(List<string[]> rows, int id_col = 0, int value_col = 1)
	{
		return (T)null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xEBF0B8", Offset = "0xEBF0B8", VA = "0xEBF0B8")]
	private static object CreateArray(Type type, List<string[]> rows)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xEBF3C8", Offset = "0xEBF3C8", VA = "0xEBF3C8")]
	private static object Create(string[] cols, Dictionary<string, int> table, Type type)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xEBF524", Offset = "0xEBF524", VA = "0xEBF524")]
	private static void SetValue(object v, FieldInfo fieldinfo, string value)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xEBFAF0", Offset = "0xEBFAF0", VA = "0xEBFAF0")]
	private static object CreateIdValue(Type type, List<string[]> rows, int id_col = 0, int val_col = 1)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xEBFE38", Offset = "0xEBFE38", VA = "0xEBFE38")]
	public static List<string[]> ParseCSV(string text, char separator = ',')
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xEC02F8", Offset = "0xEC02F8", VA = "0xEC02F8")]
	public CSVSerializer()
	{
	}
}
[Token(Token = "0x2000003")]
public class CSVImportExample : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000160")]
	public class Sample
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int year;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string make;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string model;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string description;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float price;

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xEBF0B0", Offset = "0xEBF0B0", VA = "0xEBF0B0")]
		public Sample()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sample[] m_Sample;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xEBF0A8", Offset = "0xEBF0A8", VA = "0xEBF0A8")]
	public CSVImportExample()
	{
	}
}
[Token(Token = "0x2000004")]
public class ConstData : ScriptableObject
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int maxhp;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int[] intarray;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] floatarray;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] stringarray;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xEC4738", Offset = "0xEC4738", VA = "0xEC4738")]
	public ConstData()
	{
	}
}
[Token(Token = "0x2000005")]
public class LanguageStringData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000161")]
	public class Item
	{
		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string en;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string jp;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string ru;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ch;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string fr;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string ko;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1D59A68", Offset = "0x1D59A68", VA = "0x1D59A68")]
		public Item()
		{
		}
	}

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] m_Items;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1D59A60", Offset = "0x1D59A60", VA = "0x1D59A60")]
	public LanguageStringData()
	{
	}
}
[Token(Token = "0x2000006")]
public class RankingData : ScriptableObject
{
	[Token(Token = "0x2000162")]
	public enum Country
	{
		[Token(Token = "0x400085C")]
		gb = 1,
		[Token(Token = "0x400085D")]
		de,
		[Token(Token = "0x400085E")]
		fi,
		[Token(Token = "0x400085F")]
		be
	}

	[Serializable]
	[Token(Token = "0x2000163")]
	public class Item
	{
		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ranking;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string driver;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string constructor;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int score;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int podium;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite icon;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Country country;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string[] win;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xCFF5C8", Offset = "0xCFF5C8", VA = "0xCFF5C8")]
		public Item()
		{
		}
	}

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] m_Items;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xCFF5C0", Offset = "0xCFF5C0", VA = "0xCFF5C0")]
	public RankingData()
	{
	}
}
[Token(Token = "0x2000007")]
public class UIRanking : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_ListRoot;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_SlotPrefab;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_WinSlotPrefab;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RankingData m_RankingData;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite[] m_Country;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD4A120", Offset = "0xD4A120", VA = "0xD4A120")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD4A17C", Offset = "0xD4A17C", VA = "0xD4A17C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD4A5C0", Offset = "0xD4A5C0", VA = "0xD4A5C0")]
	private Sprite GetCountrySprite(string id)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD4A668", Offset = "0xD4A668", VA = "0xD4A668")]
	public UIRanking()
	{
	}
}
[Token(Token = "0x2000008")]
public class UIRankingSlot : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_TextRanking;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_TextConstructor;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text m_TextDriver;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text m_TextScore;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text m_TextPodium;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image m_Flag;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject m_Win;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform m_WinListRoot;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Image m_ImageCar;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x19237C8", Offset = "0x19237C8", VA = "0x19237C8")]
	public void Load(RankingData.Item item, Sprite flag, bool winlist)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x19238FC", Offset = "0x19238FC", VA = "0x19238FC")]
	public UIRankingSlot()
	{
	}
}
[Token(Token = "0x2000009")]
public class UIRankingWinSlot : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Text;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1923904", Offset = "0x1923904", VA = "0x1923904")]
	public void Load(string text)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1923928", Offset = "0x1923928", VA = "0x1923928")]
	public UIRankingWinSlot()
	{
	}
}
[Token(Token = "0x200000A")]
public class RotateSeeker : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD03284", Offset = "0xD03284", VA = "0xD03284")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD032E4", Offset = "0xD032E4", VA = "0xD032E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD03334", Offset = "0xD03334", VA = "0xD03334")]
	public RotateSeeker()
	{
	}
}
[Token(Token = "0x200000B")]
public class ApplyProceduralTextureProperties : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BF2D8", Offset = "0x9BF2D8")]
	public Material m_Material;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BF2EC", Offset = "0x9BF2EC")]
	public ProceduralTexture2D proceduralTexAssetAlbedo;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProceduralTexture2D proceduralTexAssetNormal;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProceduralTexture2D proceduralTexAssetMask;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xEB982C", Offset = "0xEB982C", VA = "0xEB982C")]
	public void SyncMatWithProceduralTextureAsset()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xEB9F00", Offset = "0xEB9F00", VA = "0xEB9F00")]
	public ApplyProceduralTextureProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9BEA0C", Offset = "0x9BEA0C")]
public class ProceduralTexture2D : ScriptableObject
{
	[Token(Token = "0x2000164")]
	public enum TextureType
	{
		[Token(Token = "0x4000869")]
		Color,
		[Token(Token = "0x400086A")]
		Normal,
		[Token(Token = "0x400086B")]
		Other
	}

	[Token(Token = "0x2000165")]
	public enum CompressionLevel
	{
		[Token(Token = "0x400086D")]
		None = -1,
		[Token(Token = "0x400086E")]
		LowQuality = 0,
		[Token(Token = "0x400086F")]
		NormalQuality = 50,
		[Token(Token = "0x4000870")]
		HighQuality = 100
	}

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D input;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextureType type;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool includeAlpha;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool generateMipMaps;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FilterMode filterMode;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int anisoLevel;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CompressionLevel compressionQuality;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D Tinput;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D invT;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 colorSpaceOrigin;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 colorSpaceVector1;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 colorSpaceVector2;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 colorSpaceVector3;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector4 compressionScalers;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public long memoryUsageBytes;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D currentInput;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextureType currentType;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool currentIncludeAlpha;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool currentGenerateMipMaps;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FilterMode currentFilterMode;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int currentAnisoLevel;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CompressionLevel currentCompressionQuality;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDC8C38", Offset = "0xDC8C38", VA = "0xDC8C38")]
	public ProceduralTexture2D()
	{
	}
}
[Token(Token = "0x200000D")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xEBB8A8", Offset = "0xEBB8A8", VA = "0xEBB8A8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xEBBE0C", Offset = "0xEBBE0C", VA = "0xEBBE0C")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xEBBFE4", Offset = "0xEBBFE4", VA = "0xEBBFE4")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x200000E")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDB6BF8", Offset = "0xDB6BF8", VA = "0xDB6BF8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDB6CD0", Offset = "0xDB6CD0", VA = "0xDB6CD0")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000F")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDB8AA0", Offset = "0xDB8AA0", VA = "0xDB8AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDB8C04", Offset = "0xDB8C04", VA = "0xDB8C04")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDB8E58", Offset = "0xDB8E58", VA = "0xDB8E58")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDB92E4", Offset = "0xDB92E4", VA = "0xDB92E4")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000010")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDB79B4", Offset = "0xDB79B4", VA = "0xDB79B4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDB7A8C", Offset = "0xDB7A8C", VA = "0xDB7A8C")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000011")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED18", Offset = "0x9BED18")]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xDB75A0", Offset = "0xDB75A0", VA = "0xDB75A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0xDB7608", Offset = "0xDB7608", VA = "0xDB7608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xDB729C", Offset = "0xDB729C", VA = "0xDB729C")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xDB741C", Offset = "0xDB741C", VA = "0xDB741C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xDB7420", Offset = "0xDB7420", VA = "0xDB7420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xDB75A8", Offset = "0xDB75A8", VA = "0xDB75A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDB6CD8", Offset = "0xDB6CD8", VA = "0xDB6CD8")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDB6DBC", Offset = "0xDB6DBC", VA = "0xDB6DBC")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDB7220", Offset = "0xDB7220", VA = "0xDB7220")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C685C", Offset = "0x9C685C")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDB72C8", Offset = "0xDB72C8", VA = "0xDB72C8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDB73A0", Offset = "0xDB73A0", VA = "0xDB73A0")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000012")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDB7610", Offset = "0xDB7610", VA = "0xDB7610")]
	private void Start()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDB766C", Offset = "0xDB766C", VA = "0xDB766C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDB76F8", Offset = "0xDB76F8", VA = "0xDB76F8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDB77D0", Offset = "0xDB77D0", VA = "0xDB77D0")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000013")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xDB77D8", Offset = "0xDB77D8", VA = "0xDB77D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xDB78CC", Offset = "0xDB78CC", VA = "0xDB78CC")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x2000014")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x6000033")]
	[Address(RVA = "0xDB78D4", Offset = "0xDB78D4", VA = "0xDB78D4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xDB79AC", Offset = "0xDB79AC", VA = "0xDB79AC")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x2000015")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xDB7A94", Offset = "0xDB7A94", VA = "0xDB7A94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xDB7C8C", Offset = "0xDB7C8C", VA = "0xDB7C8C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDB897C", Offset = "0xDB897C", VA = "0xDB897C")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDB8A98", Offset = "0xDB8A98", VA = "0xDB8A98")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x2000016")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDB92EC", Offset = "0xDB92EC", VA = "0xDB92EC")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDB93C4", Offset = "0xDB93C4", VA = "0xDB93C4")]
	public void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xDB946C", Offset = "0xDB946C", VA = "0xDB946C")]
	public void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDB96E0", Offset = "0xDB96E0", VA = "0xDB96E0")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Token(Token = "0x2000017")]
public class Movement : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 movementVector;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDBB584", Offset = "0xDBB584", VA = "0xDBB584")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDBB684", Offset = "0xDBB684", VA = "0xDBB684")]
	public Movement()
	{
	}
}
[Token(Token = "0x2000018")]
[ExecuteInEditMode]
public class MobilePostProcessing : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF300", Offset = "0x9BF300")]
	public int NumberOfPasses;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool Blur;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF318", Offset = "0x9BF318")]
	public float BlurAmount;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D BlurMask;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool Bloom;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color BloomColor;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF330", Offset = "0x9BF330")]
	public float BloomAmount;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF348", Offset = "0x9BF348")]
	public float BloomDiffuse;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF360", Offset = "0x9BF360")]
	public float BloomThreshold;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool LUT;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF378", Offset = "0x9BF378")]
	public int LutDimension;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF390", Offset = "0x9BF390")]
	public float LutAmount;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D SourceLut;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool ImageFiltering;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color Color;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF3A8", Offset = "0x9BF3A8")]
	public float Contrast;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF3C0", Offset = "0x9BF3C0")]
	public float Brightness;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF3D8", Offset = "0x9BF3D8")]
	public float Saturation;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF3F0", Offset = "0x9BF3F0")]
	public float Exposure;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF408", Offset = "0x9BF408")]
	public float Gamma;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF420", Offset = "0x9BF420")]
	public float Sharpness;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool ChromaticAberration;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float Offset;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF438", Offset = "0x9BF438")]
	public float FishEyeDistortion;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF450", Offset = "0x9BF450")]
	public float GlitchAmount;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool Distortion;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF468", Offset = "0x9BF468")]
	public float LensDistortion;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool Vignette;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Color VignetteColor;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF480", Offset = "0x9BF480")]
	public float VignetteAmount;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BF498", Offset = "0x9BF498")]
	public float VignetteSoftness;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int blurTexString;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int maskTextureString;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int blurAmountString;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int bloomColorString;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly int blAmountString;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static readonly int blDiffuseString;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int blThresholdString;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int lutTexture2DString;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly int lutTexture3DString;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly int lutAmountString;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly int colorString;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static readonly int contrastString;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly int brightnessString;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static readonly int saturationString;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly int exposureString;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly int gammaString;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly int centralFactorString;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static readonly int sideFactorString;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly int offsetString;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static readonly int fishEyeString;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly int lensdistortionString;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly int vignetteColorString;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static readonly int vignetteAmountString;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static readonly int vignetteSoftnessString;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly string bloomKeyword;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static readonly string blurKeyword;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly string chromaKeyword;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static readonly string lutKeyword;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly string filterKeyword;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static readonly string shaprenKeyword;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly string distortionKeyword;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Material material;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int previousLutDimension;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Texture2D previous;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Texture2D converted2D;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Texture3D converted3D;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float t;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float a;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDB98FC", Offset = "0xDB98FC", VA = "0xDB98FC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDB99E8", Offset = "0xDB99E8", VA = "0xDB99E8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDB9AC8", Offset = "0xDB9AC8", VA = "0xDB9AC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDB9B7C", Offset = "0xDB9B7C", VA = "0xDB9B7C")]
	private void Convert2D(Texture2D temp2DTex)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDB9E90", Offset = "0xDB9E90", VA = "0xDB9E90")]
	private void Convert3D(Texture2D temp3DTex)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDB9AB4", Offset = "0xDB9AB4", VA = "0xDB9AB4")]
	private void Convert(Texture2D source)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDBA070", Offset = "0xDBA070", VA = "0xDBA070")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDBB104", Offset = "0xDBB104", VA = "0xDBB104")]
	public MobilePostProcessing()
	{
	}
}
[Token(Token = "0x2000019")]
public class NavMeshCleaner : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Vector3> m_WalkablePoint;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_Height;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float m_Offset;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_MidLayerCount;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDBB894", Offset = "0xDBB894", VA = "0xDBB894")]
	public NavMeshCleaner()
	{
	}
}
[Token(Token = "0x200001A")]
public class BezierLineRendererScript : MonoBehaviour
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform trans1;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform trans2;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int middlePoints;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 controlPoint;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool considerDistance;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float distanceEffect;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xEBD52C", Offset = "0xEBD52C", VA = "0xEBD52C")]
	private void Start()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xEBD530", Offset = "0xEBD530", VA = "0xEBD530")]
	private void Update()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xEBD828", Offset = "0xEBD828", VA = "0xEBD828")]
	private Vector3 SampleCurve(Vector3 start, Vector3 end, Vector3 control, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xEBD934", Offset = "0xEBD934", VA = "0xEBD934")]
	public BezierLineRendererScript()
	{
	}
}
[Token(Token = "0x200001B")]
public class ScrollingUVs : MonoBehaviour
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float scrollSpeed;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer rend;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD08034", Offset = "0xD08034", VA = "0xD08034")]
	private void Start()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD08094", Offset = "0xD08094", VA = "0xD08094")]
	private void Update()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD0813C", Offset = "0xD0813C", VA = "0xD0813C")]
	public ScrollingUVs()
	{
	}
}
[Token(Token = "0x200001C")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000167")]
	public class Section
	{
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xCFF5D8", Offset = "0xCFF5D8", VA = "0xCFF5D8")]
		public Section()
		{
		}
	}

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xCFF5D0", Offset = "0xCFF5D0", VA = "0xCFF5D0")]
	public Readme()
	{
	}
}
[Token(Token = "0x200001D")]
public class ActivateByDevice : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000168")]
	public class Item
	{
		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlatformManager.DeviceType deviceType;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject targetObj;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xEB5D58", Offset = "0xEB5D58", VA = "0xEB5D58")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF4B4", Offset = "0x9BF4B4")]
	[SerializeField]
	private Item[] activateItems;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xEB5C38", Offset = "0xEB5C38", VA = "0xEB5C38")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xEB5D50", Offset = "0xEB5D50", VA = "0xEB5D50")]
	public ActivateByDevice()
	{
	}
}
[Token(Token = "0x200001E")]
public class ActivateByGameMode : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000169")]
	public class Item
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GeneralGameManager.GameMode gameMode;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject activateObj;

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xEB6738", Offset = "0xEB6738", VA = "0xEB6738")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF500", Offset = "0x9BF500")]
	[SerializeField]
	private Item[] items;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xEB6614", Offset = "0xEB6614", VA = "0xEB6614")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xEB6730", Offset = "0xEB6730", VA = "0xEB6730")]
	public ActivateByGameMode()
	{
	}
}
[Token(Token = "0x200001F")]
public class ActivateByGameObject : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016A")]
	public struct SetItem
	{
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject srcObj;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GameObject targetObj;
	}

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF54C", Offset = "0x9BF54C")]
	[SerializeField]
	private SetItem[] setItems;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xEB6740", Offset = "0xEB6740", VA = "0xEB6740")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C68C0", Offset = "0x9C68C0")]
	private void DetectChilds()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xEB6874", Offset = "0xEB6874", VA = "0xEB6874")]
	private void Update()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xEB6960", Offset = "0xEB6960", VA = "0xEB6960")]
	public ActivateByGameObject()
	{
	}
}
[Token(Token = "0x2000020")]
public class ActivateByLanguage : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016B")]
	public class LocalizeItem
	{
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GeneralGameManager.LangType language;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject targetObj;

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xEB6D3C", Offset = "0xEB6D3C", VA = "0xEB6D3C")]
		public LocalizeItem()
		{
		}
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED28", Offset = "0x9BED28")]
	private sealed class <CheckLang>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActivateByLanguage <>4__this;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xEB6CCC", Offset = "0xEB6CCC", VA = "0xEB6CCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xEB6D34", Offset = "0xEB6D34", VA = "0xEB6D34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xEB6B34", Offset = "0xEB6B34", VA = "0xEB6B34")]
		[DebuggerHidden]
		public <CheckLang>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xEB6B68", Offset = "0xEB6B68", VA = "0xEB6B68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xEB6B6C", Offset = "0xEB6B6C", VA = "0xEB6B6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xEB6CD4", Offset = "0xEB6CD4", VA = "0xEB6CD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF598", Offset = "0x9BF598")]
	[SerializeField]
	private LocalizeItem[] localizeItems;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xEB6968", Offset = "0xEB6968", VA = "0xEB6968")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xEB6AB8", Offset = "0xEB6AB8", VA = "0xEB6AB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C68F8", Offset = "0x9C68F8")]
	private IEnumerator CheckLang()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xEB6B60", Offset = "0xEB6B60", VA = "0xEB6B60")]
	public ActivateByLanguage()
	{
	}
}
[Token(Token = "0x2000021")]
public class AngleChangeSound : MonoBehaviour
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF5E4", Offset = "0x9BF5E4")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF630", Offset = "0x9BF630")]
	private AudioClip angleUpSound;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF67C", Offset = "0x9BF67C")]
	private float angleUpValue;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF6C8", Offset = "0x9BF6C8")]
	private AudioClip angleDownSound;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF714", Offset = "0x9BF714")]
	private float angleDownValue;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float lastAngleY;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xEB8BF0", Offset = "0xEB8BF0", VA = "0xEB8BF0")]
	private void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xEB8C28", Offset = "0xEB8C28", VA = "0xEB8C28")]
	private void Update()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xEB8C2C", Offset = "0xEB8C2C", VA = "0xEB8C2C")]
	private void CheckAngle()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xEB8D88", Offset = "0xEB8D88", VA = "0xEB8D88")]
	public AngleChangeSound()
	{
	}
}
[Token(Token = "0x2000022")]
public class AngleLimitter : MonoBehaviour
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float maxAngleY;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float minAngleY;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 initLocalAngle;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xEB8D90", Offset = "0xEB8D90", VA = "0xEB8D90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xEB8DCC", Offset = "0xEB8DCC", VA = "0xEB8DCC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xEB8ED0", Offset = "0xEB8ED0", VA = "0xEB8ED0")]
	public AngleLimitter()
	{
	}
}
[Token(Token = "0x2000023")]
public class BezierPointer : MonoBehaviour
{
	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF780", Offset = "0x9BF780")]
	[SerializeField]
	private GameObject pointerPf;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF7CC", Offset = "0x9BF7CC")]
	[SerializeField]
	private float distance;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF818", Offset = "0x9BF818")]
	private float dropHeight;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BF864", Offset = "0x9BF864")]
	private int density;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject pointer;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xEBD9A8", Offset = "0xEBD9A8", VA = "0xEBD9A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xEBDBB4", Offset = "0xEBDBB4", VA = "0xEBDBB4")]
	public bool IsPointing()
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xEBDBD0", Offset = "0xEBDBD0", VA = "0xEBDBD0")]
	public void SetLineColor(Color newColor)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xEBDCEC", Offset = "0xEBDCEC", VA = "0xEBDCEC")]
	public bool DrawLine(Transform rayOriginTf, out Vector3 hitPoint, out Quaternion rotation, out GameObject hitObj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xEBE140", Offset = "0xEBE140", VA = "0xEBE140")]
	public void DrawLineToTargetPos(Transform rayOriginTf, Vector3 targetPos, out Quaternion rotation)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xEBDB50", Offset = "0xEBDB50", VA = "0xEBDB50")]
	public void DestroyLine()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xEBE3D8", Offset = "0xEBE3D8", VA = "0xEBE3D8")]
	public BezierPointer()
	{
	}
}
[Token(Token = "0x2000024")]
public class CenterOfMass : MonoBehaviour
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 centerPosOffset;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xEC08A8", Offset = "0xEC08A8", VA = "0xEC08A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xEC0910", Offset = "0xEC0910", VA = "0xEC0910")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xEC09F4", Offset = "0xEC09F4", VA = "0xEC09F4")]
	public CenterOfMass()
	{
	}
}
[Token(Token = "0x2000025")]
public class ChangeSpriteByLanguage : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016D")]
	public class LocalizeItem
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GeneralGameManager.LangType language;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xEC4158", Offset = "0xEC4158", VA = "0xEC4158")]
		public LocalizeItem()
		{
		}
	}

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF8D0", Offset = "0x9BF8D0")]
	[SerializeField]
	private Image targetImage;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LocalizeItem[] localizeItems;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xEC4040", Offset = "0xEC4040", VA = "0xEC4040")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xEC4150", Offset = "0xEC4150", VA = "0xEC4150")]
	public ChangeSpriteByLanguage()
	{
	}
}
[Token(Token = "0x2000026")]
public class GrabSpawner : GrabReactor
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF92C", Offset = "0x9BF92C")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<GameObject> activeObjList;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BF988", Offset = "0x9BF988")]
	[SerializeField]
	private GameObject spawnObjPf;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform spawnPosTf;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private int maxObjCount;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1D51B3C", Offset = "0x1D51B3C", VA = "0x1D51B3C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1D51B6C", Offset = "0x1D51B6C", VA = "0x1D51B6C", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1D51C08", Offset = "0x1D51C08", VA = "0x1D51C08", Slot = "9")]
	protected virtual void Spawn()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1D51DB0", Offset = "0x1D51DB0", VA = "0x1D51DB0")]
	private void CheckList()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1D51E98", Offset = "0x1D51E98", VA = "0x1D51E98")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1D51EA4", Offset = "0x1D51EA4", VA = "0x1D51EA4")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1D51EAC", Offset = "0x1D51EAC", VA = "0x1D51EAC")]
	public GrabSpawner()
	{
	}
}
[Token(Token = "0x2000027")]
public class GroundLifeTimer : MonoBehaviour
{
	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED38", Offset = "0x9BED38")]
	private sealed class <CountDownRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GroundLifeTimer <>4__this;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1D528AC", Offset = "0x1D528AC", VA = "0x1D528AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1D52914", Offset = "0x1D52914", VA = "0x1D52914", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1D52768", Offset = "0x1D52768", VA = "0x1D52768")]
		[DebuggerHidden]
		public <CountDownRoutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1D527B0", Offset = "0x1D527B0", VA = "0x1D527B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1D527B4", Offset = "0x1D527B4", VA = "0x1D527B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1D528B4", Offset = "0x1D528B4", VA = "0x1D528B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float lifeTime;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float triggerHeight;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Coroutine countDownRoutine;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1D52544", Offset = "0x1D52544", VA = "0x1D52544")]
	private void Start()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1D525A4", Offset = "0x1D525A4", VA = "0x1D525A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1D52654", Offset = "0x1D52654", VA = "0x1D52654")]
	private void StartCountDown()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1D52724", Offset = "0x1D52724", VA = "0x1D52724")]
	public void Restart()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1D5260C", Offset = "0x1D5260C", VA = "0x1D5260C")]
	public void Stop()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1D526A8", Offset = "0x1D526A8", VA = "0x1D526A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C695C", Offset = "0x9C695C")]
	private IEnumerator CountDownRoutine()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1D52794", Offset = "0x1D52794", VA = "0x1D52794")]
	public GroundLifeTimer()
	{
	}
}
[Token(Token = "0x2000028")]
public class HitSound : MonoBehaviour
{
	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED48", Offset = "0x9BED48")]
	private sealed class <EnableDelayRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HitSound <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1D54338", Offset = "0x1D54338", VA = "0x1D54338", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1D543A0", Offset = "0x1D543A0", VA = "0x1D543A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1D54210", Offset = "0x1D54210", VA = "0x1D54210")]
		[DebuggerHidden]
		public <EnableDelayRoutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1D54264", Offset = "0x1D54264", VA = "0x1D54264", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1D54268", Offset = "0x1D54268", VA = "0x1D54268", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1D54340", Offset = "0x1D54340", VA = "0x1D54340", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFA04", Offset = "0x9BFA04")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFA50", Offset = "0x9BFA50")]
	[SerializeField]
	private AudioClip[] hitClips;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float soundPlayVelocity;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource audioSource;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float lastVelocity;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float enableDelay;

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1D53EE8", Offset = "0x1D53EE8", VA = "0x1D53EE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1D53F48", Offset = "0x1D53F48", VA = "0x1D53F48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1D53FF0", Offset = "0x1D53FF0", VA = "0x1D53FF0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1D54130", Offset = "0x1D54130", VA = "0x1D54130")]
	public void PlayHitSound()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1D541AC", Offset = "0x1D541AC", VA = "0x1D541AC")]
	public void PlayHitSoundNoCoolTime()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1D53F74", Offset = "0x1D53F74", VA = "0x1D53F74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C69C0", Offset = "0x9C69C0")]
	private IEnumerator EnableDelayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1D5423C", Offset = "0x1D5423C", VA = "0x1D5423C")]
	public HitSound()
	{
	}
}
[Token(Token = "0x2000029")]
public class LifeTimer : MonoBehaviour
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFAAC", Offset = "0x9BFAAC")]
	[SerializeField]
	private bool isNeverStartCount;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool isCountDown;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float lifeTimeRemain;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFB18", Offset = "0x9BFB18")]
	[SerializeField]
	private bool startCountIfGrabbing;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float lifeTime;

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1D5B1E0", Offset = "0x1D5B1E0", VA = "0x1D5B1E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1D5B228", Offset = "0x1D5B228", VA = "0x1D5B228")]
	private void Update()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1D5B208", Offset = "0x1D5B208", VA = "0x1D5B208")]
	public void StartCount()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1D5B390", Offset = "0x1D5B390", VA = "0x1D5B390")]
	public void ResetTimer()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1D5B39C", Offset = "0x1D5B39C", VA = "0x1D5B39C")]
	public void StopForceParmanent()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1D5B3A8", Offset = "0x1D5B3A8", VA = "0x1D5B3A8")]
	public LifeTimer()
	{
	}
}
[Token(Token = "0x200002A")]
public class OverlapGrabController : GrabReactorTriggerBase
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float adjustPosDistanceThreshold;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xDC1670", Offset = "0xDC1670", VA = "0xDC1670")]
	private void Update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDC1B44", Offset = "0xDC1B44", VA = "0xDC1B44")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDC1790", Offset = "0xDC1790", VA = "0xDC1790")]
	private void CheckGrabbableNearest()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDC18BC", Offset = "0xDC18BC", VA = "0xDC18BC")]
	private void CheckReleaseObject()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xDC1B50", Offset = "0xDC1B50", VA = "0xDC1B50", Slot = "6")]
	protected override void SetToFitPos()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xDC1DA0", Offset = "0xDC1DA0", VA = "0xDC1DA0")]
	public OverlapGrabController()
	{
	}
}
[Token(Token = "0x200002B")]
public class PointingManager : SingletonMonoBehaviour<PointingManager>
{
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFB84", Offset = "0x9BFB84")]
	public bool isEnable;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool isEnableWhenLastDisabled;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isRightActive;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isLeftActive;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFBBC", Offset = "0x9BFBBC")]
	[SerializeField]
	private GameObject pointerPf;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LineRenderer lineRendererRight;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LineRenderer lineRendererLeft;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public RaycastHit hitInfoR;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public RaycastHit hitInfoL;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject pointerObjRight;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject pointerObjLeft;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float rayDistance;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xDC7970", Offset = "0xDC7970", VA = "0xDC7970")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xDC7994", Offset = "0xDC7994", VA = "0xDC7994")]
	private void Update()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xDC7B48", Offset = "0xDC7B48", VA = "0xDC7B48")]
	private void CheckOverlayUI()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xDC7D28", Offset = "0xDC7D28", VA = "0xDC7D28")]
	private void CastingRay()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xDC7C64", Offset = "0xDC7C64", VA = "0xDC7C64")]
	private void SetActiveHand()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xDC8660", Offset = "0xDC8660", VA = "0xDC8660")]
	public Vector3 GetPointerPosition(bool isRight)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xDC844C", Offset = "0xDC844C", VA = "0xDC844C")]
	private void SetPointer(Vector3 startPos, Vector3 endPos, bool isRight)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xDC241C", Offset = "0xDC241C", VA = "0xDC241C")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xDBCED0", Offset = "0xDBCED0", VA = "0xDBCED0")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xDBD82C", Offset = "0xDBD82C", VA = "0xDBD82C")]
	public void EnableIfLastTimeDisabled()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xDC8774", Offset = "0xDC8774", VA = "0xDC8774")]
	public PointingManager()
	{
	}
}
[Token(Token = "0x200002C")]
public class PositionGizmo : MonoBehaviour
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color color;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask groundLayerMask;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xDC87CC", Offset = "0xDC87CC", VA = "0xDC87CC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6A24", Offset = "0x9C6A24")]
	private void FitGrounding()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xDC8918", Offset = "0xDC8918", VA = "0xDC8918")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xDC8968", Offset = "0xDC8968", VA = "0xDC8968")]
	public PositionGizmo()
	{
	}
}
[Token(Token = "0x200002D")]
public class PouringPosAnchor : MonoBehaviour
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFC88", Offset = "0x9BFC88")]
	public float pouringRate;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 targetPos;

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xDC89A8", Offset = "0xDC89A8", VA = "0xDC89A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xDC8C30", Offset = "0xDC8C30", VA = "0xDC8C30")]
	public PouringPosAnchor()
	{
	}
}
[Token(Token = "0x200002E")]
public class SceneLoader : SingletonMonoBehaviour<SceneLoader>
{
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED58", Offset = "0x9BED58")]
	private sealed class <LoadSceneRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xD06DC8", Offset = "0xD06DC8", VA = "0xD06DC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xD06E30", Offset = "0xD06E30", VA = "0xD06E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xD0661C", Offset = "0xD0661C", VA = "0xD0661C")]
		[DebuggerHidden]
		public <LoadSceneRoutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xD0692C", Offset = "0xD0692C", VA = "0xD0692C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xD06930", Offset = "0xD06930", VA = "0xD06930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xD06DD0", Offset = "0xD06DD0", VA = "0xD06DD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED68", Offset = "0x9BED68")]
	private sealed class <AllowSceneActivateRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SceneLoader <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xD068BC", Offset = "0xD068BC", VA = "0xD068BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xD06924", Offset = "0xD06924", VA = "0xD06924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xD06704", Offset = "0xD06704", VA = "0xD06704")]
		[DebuggerHidden]
		public <AllowSceneActivateRoutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xD067F0", Offset = "0xD067F0", VA = "0xD067F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xD067F4", Offset = "0xD067F4", VA = "0xD067F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xD068C4", Offset = "0xD068C4", VA = "0xD068C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFCC0", Offset = "0x9BFCC0")]
	public float progress;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isLoading;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFCF8", Offset = "0x9BFCF8")]
	public bool isAutoLoadStart;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool isAllowNextScene;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string nextSceneName;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AsyncOperation asyncOp;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD06520", Offset = "0xD06520", VA = "0xD06520")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD06598", Offset = "0xD06598", VA = "0xD06598")]
	public void SetNextSceneName(string value)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD06530", Offset = "0xD06530", VA = "0xD06530")]
	public void StartLoading()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD065A0", Offset = "0xD065A0", VA = "0xD065A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6A5C", Offset = "0x9C6A5C")]
	private IEnumerator LoadSceneRoutine(string sceneName = "")
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD06648", Offset = "0xD06648", VA = "0xD06648")]
	public void AllowSceneActivate(float delay = 0f)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD06678", Offset = "0xD06678", VA = "0xD06678")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6AC0", Offset = "0x9C6AC0")]
	private IEnumerator AllowSceneActivateRoutine(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD06730", Offset = "0xD06730", VA = "0xD06730")]
	public float GetProgress()
	{
		return default(float);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD06798", Offset = "0xD06798", VA = "0xD06798")]
	public SceneLoader()
	{
	}
}
[Token(Token = "0x200002F")]
public class ScreenFade : MonoBehaviour
{
	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED78", Offset = "0x9BED78")]
	private sealed class <FadeRoutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenFade <>4__this;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isFadeOut;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float delay;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Color <color>5__3;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xD078C8", Offset = "0xD078C8", VA = "0xD078C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xD07930", Offset = "0xD07930", VA = "0xD07930", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xD07344", Offset = "0xD07344", VA = "0xD07344")]
		[DebuggerHidden]
		public <FadeRoutine>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xD0768C", Offset = "0xD0768C", VA = "0xD0768C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xD07690", Offset = "0xD07690", VA = "0xD07690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xD078D0", Offset = "0xD078D0", VA = "0xD078D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED88", Offset = "0x9BED88")]
	private sealed class <SetSpecificAlphaRoutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenFade <>4__this;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float value;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xD07A34", Offset = "0xD07A34", VA = "0xD07A34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xD07A9C", Offset = "0xD07A9C", VA = "0xD07A9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xD07428", Offset = "0xD07428", VA = "0xD07428")]
		[DebuggerHidden]
		public <SetSpecificAlphaRoutine>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xD07938", Offset = "0xD07938", VA = "0xD07938", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xD0793C", Offset = "0xD0793C", VA = "0xD0793C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xD07A3C", Offset = "0xD07A3C", VA = "0xD07A3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ScreenFade instance;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFD30", Offset = "0x9BFD30")]
	public Material fadeTargetMat;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image fadeImage;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fadeTime;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fadeDelayOnAwake;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color fadeColor;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BFD78", Offset = "0x9BFD78")]
	private bool fadeinOnEnable;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Color defaultFadeColor;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private Color initColor;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFDE4", Offset = "0x9BFDE4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BFDE4", Offset = "0x9BFDE4")]
	public bool isFading;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Material fadeMaterial;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private YieldInstruction fadeInstruction;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool enableInitColor;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine fadeRoutine;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD06E38", Offset = "0xD06E38", VA = "0xD06E38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD06FAC", Offset = "0xD06FAC", VA = "0xD06FAC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xD06CC0", Offset = "0xD06CC0", VA = "0xD06CC0")]
	public void StartFade(bool isFadeout = false, float duration = 0.5f, float delay = 0f)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xD0706C", Offset = "0xD0706C", VA = "0xD0706C")]
	public void StartColorFade(Color color, bool isFadeOut = true, float duration = 0.1f, float delay = 0f)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xD0719C", Offset = "0xD0719C", VA = "0xD0719C")]
	public void SetInitColor()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD07260", Offset = "0xD07260", VA = "0xD07260")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD06FCC", Offset = "0xD06FCC", VA = "0xD06FCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6B24", Offset = "0x9C6B24")]
	private IEnumerator FadeRoutine(bool isFadeOut = false, float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD07370", Offset = "0xD07370", VA = "0xD07370")]
	public void SetSpecificAlpha(float value)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xD0739C", Offset = "0xD0739C", VA = "0xD0739C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6B88", Offset = "0x9C6B88")]
	private IEnumerator SetSpecificAlphaRoutine(float value)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xD07454", Offset = "0xD07454", VA = "0xD07454")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xD07498", Offset = "0xD07498", VA = "0xD07498")]
	private void SetFadePanel()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD0756C", Offset = "0xD0756C", VA = "0xD0756C")]
	public ScreenFade()
	{
	}
}
[Token(Token = "0x2000030")]
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
	[Token(Token = "0x2000174")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BED98", Offset = "0x9BED98")]
	private sealed class <PlayOneShotRoutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SoundManager <>4__this;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip clip;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xD0E194", Offset = "0xD0E194", VA = "0xD0E194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xD0E1FC", Offset = "0xD0E1FC", VA = "0xD0E1FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xD0DB6C", Offset = "0xD0DB6C", VA = "0xD0DB6C")]
		[DebuggerHidden]
		public <PlayOneShotRoutine>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xD0E0BC", Offset = "0xD0E0BC", VA = "0xD0E0BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xD0E0C0", Offset = "0xD0E0C0", VA = "0xD0E0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xD0E19C", Offset = "0xD0E19C", VA = "0xD0E19C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEDA8", Offset = "0x9BEDA8")]
	private sealed class <PlayOneShotRoutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SoundManager <>4__this;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip clip;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xD0E2E0", Offset = "0xD0E2E0", VA = "0xD0E2E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xD0E348", Offset = "0xD0E348", VA = "0xD0E348", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xD0DC74", Offset = "0xD0DC74", VA = "0xD0DC74")]
		[DebuggerHidden]
		public <PlayOneShotRoutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xD0E204", Offset = "0xD0E204", VA = "0xD0E204", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xD0E208", Offset = "0xD0E208", VA = "0xD0E208", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xD0E2E8", Offset = "0xD0E2E8", VA = "0xD0E2E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEDB8", Offset = "0x9BEDB8")]
	private sealed class <PlayMusicClipRoutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundManager <>4__this;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isLoop;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip clip;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <fadeTime>5__2;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xD0E04C", Offset = "0xD0E04C", VA = "0xD0E04C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xD0E0B4", Offset = "0xD0E0B4", VA = "0xD0E0B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xD0DD44", Offset = "0xD0DD44", VA = "0xD0DD44")]
		[DebuggerHidden]
		public <PlayMusicClipRoutine>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xD0DE38", Offset = "0xD0DE38", VA = "0xD0DE38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xD0DE3C", Offset = "0xD0DE3C", VA = "0xD0DE3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xD0E054", Offset = "0xD0E054", VA = "0xD0E054", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFE3C", Offset = "0x9BFE3C")]
	[SerializeField]
	private AudioMixer mixer;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip defaultMusic;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioSource musicAudioSource;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioSource soundAudioSource;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip confirmSound;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip cancelSound;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioClip uiButtonSound;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip uiHoverSound;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool playDefaultMusicOnAwake;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float defaultMusicVolume;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Coroutine playMusicClipRoutine;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public static string musicOffsetName;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static string seOffsetName;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xD0D700", Offset = "0xD0D700", VA = "0xD0D700", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD0D750", Offset = "0xD0D750", VA = "0xD0D750")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD0D8B4", Offset = "0xD0D8B4", VA = "0xD0D8B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD0D7FC", Offset = "0xD0D7FC", VA = "0xD0D7FC")]
	public void PlayDefaultMusic()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD0D9D0", Offset = "0xD0D9D0", VA = "0xD0D9D0")]
	public void PlayConfirmSound()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD0D9F4", Offset = "0xD0D9F4", VA = "0xD0D9F4")]
	public void PlayCancelSound()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD0DA18", Offset = "0xD0DA18", VA = "0xD0DA18")]
	public void PlayUiButtonSound()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD0DA3C", Offset = "0xD0DA3C", VA = "0xD0DA3C")]
	public void PlayUiHoverSound()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD0DA60", Offset = "0xD0DA60", VA = "0xD0DA60")]
	public void StopStageMusic()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xCFE0F4", Offset = "0xCFE0F4", VA = "0xCFE0F4")]
	public void PlayOneShot(AudioClip clip)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD0DA7C", Offset = "0xD0DA7C", VA = "0xD0DA7C")]
	public void PlayOneShotWithVolume(AudioClip clip, float volume)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD0DA98", Offset = "0xD0DA98", VA = "0xD0DA98")]
	public void PlayOneShot(AudioClip clip, float delay)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD0DAC4", Offset = "0xD0DAC4", VA = "0xD0DAC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6BEC", Offset = "0x9C6BEC")]
	private IEnumerator PlayOneShotRoutine(AudioClip clip, float delay)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD0DB98", Offset = "0xD0DB98", VA = "0xD0DB98")]
	public void PlayOneShot(AudioClip clip, float delay, float volume)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD0DBC4", Offset = "0xD0DBC4", VA = "0xD0DBC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6C50", Offset = "0x9C6C50")]
	private IEnumerator PlayOneShotRoutine(AudioClip clip, float delay, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xD0D94C", Offset = "0xD0D94C", VA = "0xD0D94C")]
	public void PlayMusicClip(AudioClip clip, bool isLoop = true)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xD0DCA0", Offset = "0xD0DCA0", VA = "0xD0DCA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6CB4", Offset = "0x9C6CB4")]
	private IEnumerator PlayMusicClipRoutine(AudioClip clip, bool isLoop = true)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xD0DD70", Offset = "0xD0DD70", VA = "0xD0DD70")]
	public SoundManager()
	{
	}
}
[Token(Token = "0x2000031")]
public class SyncPosition : MonoBehaviour
{
	[Token(Token = "0x2000177")]
	public enum LogicType
	{
		[Token(Token = "0x40008B2")]
		Rigidbody,
		[Token(Token = "0x40008B3")]
		Transform
	}

	[Token(Token = "0x2000178")]
	public enum TargetType
	{
		[Token(Token = "0x40008B5")]
		Head,
		[Token(Token = "0x40008B6")]
		LeftController,
		[Token(Token = "0x40008B7")]
		RightController,
		[Token(Token = "0x40008B8")]
		LeftHandColliderPos,
		[Token(Token = "0x40008B9")]
		RightHandColliderPos,
		[Token(Token = "0x40008BA")]
		LeftHandModelPos,
		[Token(Token = "0x40008BB")]
		RightHandModelPos
	}

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFEF0", Offset = "0x9BFEF0")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFF3C", Offset = "0x9BFF3C")]
	[SerializeField]
	private bool isSpecificPos;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 specificPos;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TargetType targetType;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LogicType logicType;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xD38B68", Offset = "0xD38B68", VA = "0xD38B68")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xD38BD0", Offset = "0xD38BD0", VA = "0xD38BD0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xD39600", Offset = "0xD39600", VA = "0xD39600")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xD3A0E4", Offset = "0xD3A0E4", VA = "0xD3A0E4")]
	public void SetEnable(bool value)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xD3A150", Offset = "0xD3A150", VA = "0xD3A150")]
	public void SetEnableSpecificPos(bool value)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xD3A15C", Offset = "0xD3A15C", VA = "0xD3A15C")]
	public void SetSpecificPos(Vector3 pos)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xD38BE0", Offset = "0xD38BE0", VA = "0xD38BE0")]
	private void SyncRigidbody()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xD39614", Offset = "0xD39614", VA = "0xD39614")]
	private void SyncTransform()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xD3A168", Offset = "0xD3A168", VA = "0xD3A168")]
	public SyncPosition()
	{
	}
}
[Token(Token = "0x2000032")]
public class VelocityTracker : MonoBehaviour
{
	[Token(Token = "0x2000179")]
	private struct Sample
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Time;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float SquaredLinearSpeed;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 LinearVelocity;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 AngularVelocity;
	}

	[Token(Token = "0x4000109")]
	public const float WINDOW_TIME = 1f / 90f;

	[Token(Token = "0x400010A")]
	public const float WINDOW_EPSILON = 0.0001f;

	[Token(Token = "0x400010B")]
	public const float LINEAR_SPEED_WINDOW = 4f / 45f;

	[Token(Token = "0x400010C")]
	public const float LINEAR_VELOCITY_WINDOW = 2f / 45f;

	[Token(Token = "0x400010D")]
	public const float ANGULAR_VELOCITY_WINDOW = 1f / 45f;

	[Token(Token = "0x400010E")]
	public const int MAX_SAMPLES = 45;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_showGizmos;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_index;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_count;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Sample[] m_samples;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 m_position;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Quaternion m_rotation;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 m_frameLinearVelocity;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 m_frameAngularVelocity;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 m_trackedLinearVelocity;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 m_trackedAngularVelocity;

	[Token(Token = "0x17000001")]
	public Vector3 FrameAngularVelocity
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1929984", Offset = "0x1929984", VA = "0x1929984")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000002")]
	public Vector3 FrameLinearVelocity
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1929990", Offset = "0x1929990", VA = "0x1929990")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000003")]
	public Vector3 TrackedAngularVelocity
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x192999C", Offset = "0x192999C", VA = "0x192999C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000004")]
	public Vector3 TrackedLinearVelocity
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x19299A8", Offset = "0x19299A8", VA = "0x19299A8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x19299B4", Offset = "0x19299B4", VA = "0x19299B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1929A10", Offset = "0x1929A10", VA = "0x1929A10")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x192A434", Offset = "0x192A434", VA = "0x192A434")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1929C24", Offset = "0x1929C24", VA = "0x1929C24")]
	private Vector3 DeltaRotation(Quaternion final, Quaternion initial)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1929D40", Offset = "0x1929D40", VA = "0x1929D40")]
	private void AddSample(Vector3 deltaPosition, Vector3 deltaRotation)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x192A49C", Offset = "0x192A49C", VA = "0x192A49C")]
	private int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x192A518", Offset = "0x192A518", VA = "0x192A518")]
	private int IndexPrev(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x192A528", Offset = "0x192A528", VA = "0x192A528")]
	private bool IsSampleValid(int index, float windowSize)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x192A274", Offset = "0x192A274", VA = "0x192A274")]
	private Vector3 ComputeAverageAngularVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1929F1C", Offset = "0x1929F1C", VA = "0x1929F1C")]
	private Vector3 ComputeAverageLinearVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x192A0DC", Offset = "0x192A0DC", VA = "0x192A0DC")]
	private float ComputeMaxLinearSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x192A5B8", Offset = "0x192A5B8", VA = "0x192A5B8")]
	public VelocityTracker()
	{
	}
}
[Token(Token = "0x2000033")]
public class VersionText : MonoBehaviour
{
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x192A6D4", Offset = "0x192A6D4", VA = "0x192A6D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x192A76C", Offset = "0x192A76C", VA = "0x192A76C")]
	public VersionText()
	{
	}
}
[Token(Token = "0x2000034")]
public class BeerLiquidDetector : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private BeerMug beerMug;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xEBC058", Offset = "0xEBC058", VA = "0xEBC058")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xEBC0B8", Offset = "0xEBC0B8", VA = "0xEBC0B8")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xEBC458", Offset = "0xEBC458", VA = "0xEBC458")]
	public BeerLiquidDetector()
	{
	}
}
[Token(Token = "0x2000035")]
public class BeerServerHandle : GrabReactor
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BFFC8", Offset = "0x9BFFC8")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float handDistance;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0024", Offset = "0x9C0024")]
	[SerializeField]
	private Transform handleTf;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ParticleSystem liquidParticle;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject leftHandObj;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject rightHandObj;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Vector3 handleAngle;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float distanceThreshold;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xEBCCE8", Offset = "0xEBCCE8", VA = "0xEBCCE8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xEBCD5C", Offset = "0xEBCD5C", VA = "0xEBCD5C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xEBD1D4", Offset = "0xEBD1D4", VA = "0xEBD1D4", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xEBD320", Offset = "0xEBD320", VA = "0xEBD320")]
	public void GrabByNpc()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xEBD3DC", Offset = "0xEBD3DC", VA = "0xEBD3DC")]
	public void ReleaseByNpc()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xEBD4AC", Offset = "0xEBD4AC", VA = "0xEBD4AC")]
	public void Enable()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xEBD4B8", Offset = "0xEBD4B8", VA = "0xEBD4B8")]
	public void Disable()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xEBD080", Offset = "0xEBD080", VA = "0xEBD080")]
	private void Release()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xEBCD18", Offset = "0xEBCD18", VA = "0xEBCD18")]
	private void ResetHandObj()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xEBD4C0", Offset = "0xEBD4C0", VA = "0xEBD4C0")]
	public BeerServerHandle()
	{
	}
}
[Token(Token = "0x2000036")]
public class Ingredient : MonoBehaviour
{
	[Token(Token = "0x200017A")]
	public enum Type
	{
		[Token(Token = "0x40008C1")]
		None,
		[Token(Token = "0x40008C2")]
		Kaeshi,
		[Token(Token = "0x40008C3")]
		Lard,
		[Token(Token = "0x40008C4")]
		GarlicPaste,
		[Token(Token = "0x40008C5")]
		Soup,
		[Token(Token = "0x40008C6")]
		SecretTare,
		[Token(Token = "0x40008C7")]
		Noodle,
		[Token(Token = "0x40008C8")]
		Meat,
		[Token(Token = "0x40008C9")]
		Leek_White,
		[Token(Token = "0x40008CA")]
		Rice,
		[Token(Token = "0x40008CB")]
		BeerLiquid,
		[Token(Token = "0x40008CC")]
		Leek_Green,
		[Token(Token = "0x40008CD")]
		Noodle_Raw,
		[Token(Token = "0x40008CE")]
		Renge
	}

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C00B0", Offset = "0x9C00B0")]
	public ObscuredBool isUsed;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C00E8", Offset = "0x9C00E8")]
	public Type type;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1D54908", Offset = "0x1D54908", VA = "0x1D54908")]
	public Ingredient()
	{
	}
}
[Token(Token = "0x2000037")]
public class IngredientReleaseCheck : MonoBehaviour
{
	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0120", Offset = "0x9C0120")]
	[SerializeField]
	private GameObject currentTarget;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ObscuredFloat targetDistance;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject rightTarget;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject leftTarget;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ObscuredFloat rightDistance;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ObscuredFloat leftDistance;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C01BC", Offset = "0x9C01BC")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image gaugeImage;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image iconImage;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private ParticleSystem excellentEffect;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ParticleSystem goodEffect;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private ParticleSystem badEffect;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private ParticleSystem tooBadEffect;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Color excellentColor;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Color goodColor;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Color badColor;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Color tooBadColor;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C02A8", Offset = "0x9C02A8")]
	[SerializeField]
	private Transform checkCenterTf;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Transform checkMeatPosTf;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Transform checkLeekPosTf;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private Ingredient.Type[] targetTypes;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ObscuredFloat detectDistance;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private RamenBowl ramenBowl;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OverlapGrabController leftGrabber;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private OverlapGrabController rightGrabber;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ObscuredFloat bestDistance;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ObscuredFloat badDistance;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private ObscuredFloat badDistanceThreshold;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private ObscuredFloat goodDistanceThreshold;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private ObscuredFloat excellentDistanceThreshold;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1D54D00", Offset = "0x1D54D00", VA = "0x1D54D00")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1D54F58", Offset = "0x1D54F58", VA = "0x1D54F58")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1D55108", Offset = "0x1D55108", VA = "0x1D55108")]
	private void CheckTarget()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1D557CC", Offset = "0x1D557CC", VA = "0x1D557CC")]
	private void CheckTargetRelease()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1D563C0", Offset = "0x1D563C0", VA = "0x1D563C0")]
	private void PlayJudgeEffect(float rate)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1D54E50", Offset = "0x1D54E50", VA = "0x1D54E50")]
	private void OffTarget()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1D55C38", Offset = "0x1D55C38", VA = "0x1D55C38")]
	private void CheckNearest()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1D56610", Offset = "0x1D56610", VA = "0x1D56610")]
	private void CheckRightHand(out GameObject ingredientObj)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1D568EC", Offset = "0x1D568EC", VA = "0x1D568EC")]
	private void CheckLeftHand(out GameObject ingredientObj)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1D56BC8", Offset = "0x1D56BC8", VA = "0x1D56BC8")]
	public IngredientReleaseCheck()
	{
	}
}
[Token(Token = "0x2000038")]
public class LeekRefillArea : MonoBehaviour
{
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1D5B1D8", Offset = "0x1D5B1D8", VA = "0x1D5B1D8")]
	public LeekRefillArea()
	{
	}
}
[Token(Token = "0x2000039")]
public class NoodleBoilArea : MonoBehaviour
{
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xDBBBE8", Offset = "0xDBBBE8", VA = "0xDBBBE8")]
	public NoodleBoilArea()
	{
	}
}
[Token(Token = "0x200003A")]
public class NoodleBoiled : MonoBehaviour
{
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0324", Offset = "0x9C0324")]
	public NoodleState.HardnessStep hardnessStep;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ObscuredFloat boilTime;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ObscuredBool isEnableReturnTebo;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C035C", Offset = "0x9C035C")]
	[SerializeField]
	private GameObject steamObj;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float enableReturnTeboTime;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xDBBBF0", Offset = "0xDBBBF0", VA = "0xDBBBF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xDBBC20", Offset = "0xDBBC20", VA = "0xDBBC20")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xDBBC7C", Offset = "0xDBBC7C", VA = "0xDBBC7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xDBBCD4", Offset = "0xDBBCD4", VA = "0xDBBCD4")]
	public NoodleBoiled()
	{
	}
}
[Token(Token = "0x200003B")]
public class NoodleState : MonoBehaviour
{
	[Token(Token = "0x200017B")]
	public enum HardnessStep
	{
		[Token(Token = "0x40008D0")]
		None,
		[Token(Token = "0x40008D1")]
		Rare,
		[Token(Token = "0x40008D2")]
		Soft,
		[Token(Token = "0x40008D3")]
		Normal,
		[Token(Token = "0x40008D4")]
		Hard
	}

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ObscuredFloat softBoilTime;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static ObscuredFloat normalBoilTime;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static ObscuredFloat hardBoilTime;

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xDBBCDC", Offset = "0xDBBCDC", VA = "0xDBBCDC")]
	public NoodleState()
	{
	}
}
[Token(Token = "0x200003C")]
public class ParticleLiquidAngle : MonoBehaviour
{
	[Token(Token = "0x6000101")]
	[Address(RVA = "0xDC1DB4", Offset = "0xDC1DB4", VA = "0xDC1DB4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xDC1E34", Offset = "0xDC1E34", VA = "0xDC1E34")]
	public ParticleLiquidAngle()
	{
	}
}
[Token(Token = "0x200003D")]
public class RamenBowl : CookBase
{
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C03A8", Offset = "0x9C03A8")]
	public ObscuredFloat qualityLifeTimeRemain;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C03E0", Offset = "0x9C03E0")]
	[SerializeField]
	private GameObject lifeTimeUi;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C042C", Offset = "0x9C042C")]
	public NoodleState.HardnessStep noodleHardness;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public ObscuredInt garlicPasteCount;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ObscuredBool isOnNoodle;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public ObscuredBool isFillSoup;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ObscuredBool isOnLeek;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public ObscuredBool isOnMeat;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ObscuredBool isOnSecretTare;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public ObscuredBool isOverTime;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0464", Offset = "0x9C0464")]
	public ObscuredFloat meatGoodRate;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public ObscuredFloat leekGoodRate;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C049C", Offset = "0x9C049C")]
	[SerializeField]
	private GameObject steamParticleObj;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private GameObject[] soupObjects;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	private GameObject[] noodleObjects;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	private GameObject[] secretTareObjects;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[SerializeField]
	private GameObject[] leekObjects;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private GameObject[] meatObjects;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private GameObject[] rengeObjects;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private GameObject meatPosGuide;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[SerializeField]
	private GameObject leekPosGuide;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[SerializeField]
	private GameObject rengeGuide;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0578", Offset = "0x9C0578")]
	[SerializeField]
	private ParticleSystem onSoupEffect;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private ParticleSystem onTareEffect;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private ParticleSystem onLeekEffect;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[HideInInspector]
	public bool dontReset;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xCFDAF0", Offset = "0xCFDAF0", VA = "0xCFDAF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xCFDDB4", Offset = "0xCFDDB4", VA = "0xCFDDB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xCFDB8C", Offset = "0xCFDB8C", VA = "0xCFDB8C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6D18", Offset = "0x9C6D18")]
	private void ResetCookState()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xCFDEDC", Offset = "0xCFDEDC", VA = "0xCFDEDC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6D50", Offset = "0x9C6D50")]
	public void SetSoup()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xCFE110", Offset = "0xCFE110", VA = "0xCFE110")]
	public void SetSecretTare()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xCFE314", Offset = "0xCFE314", VA = "0xCFE314")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6D88", Offset = "0x9C6D88")]
	private void SetNoodleSoft()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xCFE31C", Offset = "0xCFE31C", VA = "0xCFE31C")]
	public void SetNoodle(NoodleState.HardnessStep hardnessStep)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xCFE550", Offset = "0xCFE550", VA = "0xCFE550")]
	public void SetLeek(ObscuredFloat rate)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xCFE740", Offset = "0xCFE740", VA = "0xCFE740")]
	public void SetMeat(ObscuredFloat rate)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xCFEA18", Offset = "0xCFEA18", VA = "0xCFEA18")]
	public void SetRenge()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xCFEB68", Offset = "0xCFEB68", VA = "0xCFEB68")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C6DC0", Offset = "0x9C6DC0")]
	private void CheckComplete()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xCFEBB0", Offset = "0xCFEBB0", VA = "0xCFEBB0")]
	public RamenBowl()
	{
	}
}
[Token(Token = "0x200003E")]
public class RamenIngredientDetector : MonoBehaviour
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RamenBowl ramenBowl;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xCFEC30", Offset = "0xCFEC30", VA = "0xCFEC30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xCFEC90", Offset = "0xCFEC90", VA = "0xCFEC90")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xCFEF7C", Offset = "0xCFEF7C", VA = "0xCFEF7C")]
	public RamenIngredientDetector()
	{
	}
}
[Token(Token = "0x200003F")]
public class RamenSoupRefillArea : MonoBehaviour
{
	[Token(Token = "0x6000112")]
	[Address(RVA = "0xCFF348", Offset = "0xCFF348", VA = "0xCFF348")]
	public RamenSoupRefillArea()
	{
	}
}
[Token(Token = "0x2000040")]
public class RiceBowl : CookBase
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C05F4", Offset = "0x9C05F4")]
	[SerializeField]
	private ObscuredBool isOnRice;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0640", Offset = "0x9C0640")]
	[SerializeField]
	private GameObject riceObj;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform putOnRiceIkPosTf;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xD02C8C", Offset = "0xD02C8C", VA = "0xD02C8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xD02CAC", Offset = "0xD02CAC", VA = "0xD02CAC")]
	public void PutOnRice()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xD02EC8", Offset = "0xD02EC8", VA = "0xD02EC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xD03000", Offset = "0xD03000", VA = "0xD03000")]
	public RiceBowl()
	{
	}
}
[Token(Token = "0x2000041")]
public class RiceDetector : MonoBehaviour
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RiceBowl riceBowl;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD031D4", Offset = "0xD031D4", VA = "0xD031D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD0325C", Offset = "0xD0325C", VA = "0xD0325C")]
	public void PutOnRice()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xD03274", Offset = "0xD03274", VA = "0xD03274")]
	public RiceDetector()
	{
	}
}
[Token(Token = "0x2000042")]
public class RiceRefillArea : MonoBehaviour
{
	[Token(Token = "0x600011A")]
	[Address(RVA = "0xD0327C", Offset = "0xD0327C", VA = "0xD0327C")]
	public RiceRefillArea()
	{
	}
}
[Token(Token = "0x2000043")]
public class SecretTareRefillArea : MonoBehaviour
{
	[Token(Token = "0x600011B")]
	[Address(RVA = "0xD084B0", Offset = "0xD084B0", VA = "0xD084B0")]
	public SecretTareRefillArea()
	{
	}
}
[Token(Token = "0x2000044")]
public class SubBowlIngredientDetector : MonoBehaviour
{
	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SubBowl subBowl;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xD389D8", Offset = "0xD389D8", VA = "0xD389D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xD38A38", Offset = "0xD38A38", VA = "0xD38A38")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xD38B60", Offset = "0xD38B60", VA = "0xD38B60")]
	public SubBowlIngredientDetector()
	{
	}
}
[Token(Token = "0x2000045")]
public class WashedDishDetectArea : MonoBehaviour
{
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x192B464", Offset = "0x192B464", VA = "0x192B464")]
	public WashedDishDetectArea()
	{
	}
}
[Token(Token = "0x2000046")]
public class CustomerDishDetector : MonoBehaviour
{
	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CustomerState customerState;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CustomerOrder customerOrder;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float nextCheckTime;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int checkFrame;

	[Token(Token = "0x400016E")]
	private const float CHECK_INTERVAL = 0.5f;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xEC600C", Offset = "0xEC600C", VA = "0xEC600C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xEC60DC", Offset = "0xEC60DC", VA = "0xEC60DC")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xEC6FD8", Offset = "0xEC6FD8", VA = "0xEC6FD8")]
	public CustomerDishDetector()
	{
	}
}
[Token(Token = "0x2000047")]
public class CustomerIkControl : MonoBehaviour
{
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEDC8", Offset = "0x9BEDC8")]
	private sealed class <SetMasterWeightRoutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomerIkControl <>4__this;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <startWeight>5__3;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xEC8CFC", Offset = "0xEC8CFC", VA = "0xEC8CFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xEC8D64", Offset = "0xEC8D64", VA = "0xEC8D64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xEC8B90", Offset = "0xEC8B90", VA = "0xEC8B90")]
		[DebuggerHidden]
		public <SetMasterWeightRoutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xEC8BC4", Offset = "0xEC8BC4", VA = "0xEC8BC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xEC8BC8", Offset = "0xEC8BC8", VA = "0xEC8BC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xEC8D04", Offset = "0xEC8D04", VA = "0xEC8D04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FullBodyBipedIK ik;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform footLeftTarget;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform footRightTarget;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform handLeftTarget;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform handRightTarget;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xEC87F0", Offset = "0xEC87F0", VA = "0xEC87F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xEC8728", Offset = "0xEC8728", VA = "0xEC8728")]
	public void SetMasterWeight(float value, float duration)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xEC8B00", Offset = "0xEC8B00", VA = "0xEC8B00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6DF8", Offset = "0x9C6DF8")]
	private IEnumerator SetMasterWeightRoutine(float value, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xEC8BBC", Offset = "0xEC8BBC", VA = "0xEC8BBC")]
	public CustomerIkControl()
	{
	}
}
[Token(Token = "0x2000048")]
public class CustomerMain : MonoBehaviour
{
	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEDD8", Offset = "0x9BEDD8")]
	private sealed class <PlayEatSoundRoutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CustomerMain <>4__this;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip clip;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xECA3DC", Offset = "0xECA3DC", VA = "0xECA3DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xECA444", Offset = "0xECA444", VA = "0xECA444", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xEC9554", Offset = "0xEC9554", VA = "0xEC9554")]
		[DebuggerHidden]
		public <PlayEatSoundRoutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xECA304", Offset = "0xECA304", VA = "0xECA304", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xECA308", Offset = "0xECA308", VA = "0xECA308", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xECA3E4", Offset = "0xECA3E4", VA = "0xECA3E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEDE8", Offset = "0x9BEDE8")]
	private sealed class <MoveToChairRoutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomerMain <>4__this;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion <startRot>5__4;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <endRot>5__5;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xEC9F9C", Offset = "0xEC9F9C", VA = "0xEC9F9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xECA004", Offset = "0xECA004", VA = "0xECA004", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xEC98F8", Offset = "0xEC98F8", VA = "0xEC98F8")]
		[DebuggerHidden]
		public <MoveToChairRoutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xEC9A00", Offset = "0xEC9A00", VA = "0xEC9A00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xEC9A04", Offset = "0xEC9A04", VA = "0xEC9A04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xEC9FA4", Offset = "0xEC9FA4", VA = "0xEC9FA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEDF8", Offset = "0x9BEDF8")]
	private sealed class <MoveToExitRoutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomerMain <>4__this;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xECA294", Offset = "0xECA294", VA = "0xECA294", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xECA2FC", Offset = "0xECA2FC", VA = "0xECA2FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xEC99CC", Offset = "0xEC99CC", VA = "0xEC99CC")]
		[DebuggerHidden]
		public <MoveToExitRoutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xECA00C", Offset = "0xECA00C", VA = "0xECA00C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xECA010", Offset = "0xECA010", VA = "0xECA010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xECA29C", Offset = "0xECA29C", VA = "0xECA29C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve animCurve;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CustomerOrder customerOrder;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CustomerState customerState;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CustomerIkControl customerIkCtrl;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource eatAudioSource;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xEC8D6C", Offset = "0xEC8D6C", VA = "0xEC8D6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xEC8F18", Offset = "0xEC8F18", VA = "0xEC8F18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xEC72D4", Offset = "0xEC72D4", VA = "0xEC72D4")]
	public void PlayEatSound(AudioClip clip, float delay = 0f)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xEC94AC", Offset = "0xEC94AC", VA = "0xEC94AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6E5C", Offset = "0x9C6E5C")]
	private IEnumerator PlayEatSoundRoutine(AudioClip clip, float delay)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xEC740C", Offset = "0xEC740C", VA = "0xEC740C")]
	public void CheckEndEating()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xEC9580", Offset = "0xEC9580", VA = "0xEC9580")]
	public void SetRefillPlate()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xEC825C", Offset = "0xEC825C", VA = "0xEC825C")]
	public void SetSoupOnlyRamenBowl()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xEC77F0", Offset = "0xEC77F0", VA = "0xEC77F0")]
	public void SetDirtyBowl(CookBase.DishType dishType)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xEC8E9C", Offset = "0xEC8E9C", VA = "0xEC8E9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6EC0", Offset = "0x9C6EC0")]
	private IEnumerator MoveToChairRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xEC9924", Offset = "0xEC9924", VA = "0xEC9924")]
	public void MoveToExit()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xEC9950", Offset = "0xEC9950", VA = "0xEC9950")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6F24", Offset = "0x9C6F24")]
	private IEnumerator MoveToExitRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xEC99F8", Offset = "0xEC99F8", VA = "0xEC99F8")]
	public CustomerMain()
	{
	}
}
[Token(Token = "0x2000049")]
public class CustomerOrder : MonoBehaviour
{
	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CustomerState customerState;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool isQuickOrder;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xECA44C", Offset = "0xECA44C", VA = "0xECA44C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xECA4AC", Offset = "0xECA4AC", VA = "0xECA4AC")]
	public void Order()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xECAECC", Offset = "0xECAECC", VA = "0xECAECC")]
	public void SetQuickOrder(bool value)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xECAED8", Offset = "0xECAED8", VA = "0xECAED8")]
	public CustomerOrder()
	{
	}
}
[Token(Token = "0x200004A")]
public class CustomerState : MonoBehaviour
{
	[Token(Token = "0x2000180")]
	public enum CustomerType
	{
		[Token(Token = "0x40008EC")]
		Boy,
		[Token(Token = "0x40008ED")]
		Suits,
		[Token(Token = "0x40008EE")]
		OL,
		[Token(Token = "0x40008EF")]
		Drunk,
		[Token(Token = "0x40008F0")]
		Fat,
		[Token(Token = "0x40008F1")]
		Workman,
		[Token(Token = "0x40008F2")]
		Robot,
		[Token(Token = "0x40008F3")]
		Zuckerberg,
		[Token(Token = "0x40008F4")]
		CEO
	}

	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE08", Offset = "0x9BEE08")]
	private sealed class <RemoveObjectFromListRoutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomerState <>4__this;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CookBase.DishType dishType;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xECE2FC", Offset = "0xECE2FC", VA = "0xECE2FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xECE364", Offset = "0xECE364", VA = "0xECE364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xECDCA8", Offset = "0xECDCA8", VA = "0xECDCA8")]
		[DebuggerHidden]
		public <RemoveObjectFromListRoutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xECDF40", Offset = "0xECDF40", VA = "0xECDF40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xECDF44", Offset = "0xECDF44", VA = "0xECDF44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xECE304", Offset = "0xECE304", VA = "0xECE304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C06AC", Offset = "0x9C06AC")]
	public CustomerType customerType;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C06E4", Offset = "0x9C06E4")]
	public ObscuredInt chairNum;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ChairItem chairItem;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject soupOnlyRamenBowl;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject refillPlate;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C071C", Offset = "0x9C071C")]
	public string charaName;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ObscuredBool isWaiting;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public ObscuredBool isEating;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ObscuredBool isFinishEating;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public ObscuredFloat waitingTime;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<GameObject> detectDishList;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private CustomerMain customerMain;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xECBFE0", Offset = "0xECBFE0", VA = "0xECBFE0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xECC080", Offset = "0xECC080", VA = "0xECC080")]
	private void Start()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xECC0FC", Offset = "0xECC0FC", VA = "0xECC0FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xEC9F58", Offset = "0xEC9F58", VA = "0xEC9F58")]
	public void ResetWaitingTime()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xECC834", Offset = "0xECC834", VA = "0xECC834")]
	public Sprite GetFaceImage()
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xEC65E4", Offset = "0xEC65E4", VA = "0xEC65E4")]
	public void AddDetectDish(GameObject obj)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xEC34B4", Offset = "0xEC34B4", VA = "0xEC34B4")]
	public bool IsAnythingDishDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xECC8E8", Offset = "0xECC8E8", VA = "0xECC8E8")]
	private void CalcGetScore(GameObject obj)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xEC7ED0", Offset = "0xEC7ED0", VA = "0xEC7ED0")]
	public void DestroySoupOnlyRamenBowl()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xECDACC", Offset = "0xECDACC", VA = "0xECDACC")]
	private bool CheckKaedamaBowlReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xECC4A0", Offset = "0xECC4A0", VA = "0xECC4A0")]
	private bool CheckOrderDishAllReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xEC7158", Offset = "0xEC7158", VA = "0xEC7158")]
	public void RemoveKaedamaPlateFromList()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xEC7F84", Offset = "0xEC7F84", VA = "0xEC7F84")]
	public void RemoveSubBowlFromList()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xEC72A8", Offset = "0xEC72A8", VA = "0xEC72A8")]
	public void RemoveObjectFromList(CookBase.DishType dishType)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xECDC1C", Offset = "0xECDC1C", VA = "0xECDC1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6F88", Offset = "0x9C6F88")]
	private IEnumerator RemoveObjectFromListRoutine(CookBase.DishType dishType)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xECBA68", Offset = "0xECBA68", VA = "0xECBA68")]
	public bool IsRamenDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xECB888", Offset = "0xECB888", VA = "0xECB888")]
	public bool IsBeerDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xECB978", Offset = "0xECB978", VA = "0xECB978")]
	public bool IsRiceDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xECDCD4", Offset = "0xECDCD4", VA = "0xECDCD4")]
	public bool IsRefillBowlDetected()
	{
		return default(bool);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xECDDC4", Offset = "0xECDDC4", VA = "0xECDDC4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xECDF38", Offset = "0xECDF38", VA = "0xECDF38")]
	public CustomerState()
	{
	}
}
[Token(Token = "0x200004B")]
public class DebugAddStaffExp : UiItemBase
{
	[Token(Token = "0x600014C")]
	[Address(RVA = "0xECE36C", Offset = "0xECE36C", VA = "0xECE36C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xECE450", Offset = "0xECE450", VA = "0xECE450", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xECE534", Offset = "0xECE534", VA = "0xECE534")]
	public DebugAddStaffExp()
	{
	}
}
[Token(Token = "0x200004C")]
public class DebugAddTotalMoney : UiItemBase
{
	[Token(Token = "0x600014F")]
	[Address(RVA = "0xECE53C", Offset = "0xECE53C", VA = "0xECE53C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xECE620", Offset = "0xECE620", VA = "0xECE620", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xECE678", Offset = "0xECE678", VA = "0xECE678")]
	public DebugAddTotalMoney()
	{
	}
}
[Token(Token = "0x200004D")]
public class DebugController : MonoBehaviour
{
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE18", Offset = "0x9BEE18")]
	private sealed class <SpawnKaedamaBowlToTrayRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugController <>4__this;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OrderItem <orderItem>5__2;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject <subBowl>5__3;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1D483B0", Offset = "0x1D483B0", VA = "0x1D483B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1D48418", Offset = "0x1D48418", VA = "0x1D48418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1D46B10", Offset = "0x1D46B10", VA = "0x1D46B10")]
		[DebuggerHidden]
		public <SpawnKaedamaBowlToTrayRoutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1D480EC", Offset = "0x1D480EC", VA = "0x1D480EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1D480F0", Offset = "0x1D480F0", VA = "0x1D480F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1D483B8", Offset = "0x1D483B8", VA = "0x1D483B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE28", Offset = "0x9BEE28")]
	private sealed class <SpawnCompleteDishToTrayRoutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugController <>4__this;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ChairItem chairItem;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <beerObj>5__2;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x1D4807C", Offset = "0x1D4807C", VA = "0x1D4807C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x1D480E4", Offset = "0x1D480E4", VA = "0x1D480E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1D46BD4", Offset = "0x1D46BD4", VA = "0x1D46BD4")]
		[DebuggerHidden]
		public <SpawnCompleteDishToTrayRoutine>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1D47960", Offset = "0x1D47960", VA = "0x1D47960", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1D47964", Offset = "0x1D47964", VA = "0x1D47964", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1D48084", Offset = "0x1D48084", VA = "0x1D48084", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE38", Offset = "0x9BEE38")]
	private sealed class <SpawnCompleteDishToCounterRoutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int chairNum;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DebugController <>4__this;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OrderItem <orderItem>5__2;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject <beerObj>5__3;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1D478F0", Offset = "0x1D478F0", VA = "0x1D478F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1D47958", Offset = "0x1D47958", VA = "0x1D47958", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1D46CB8", Offset = "0x1D46CB8", VA = "0x1D46CB8")]
		[DebuggerHidden]
		public <SpawnCompleteDishToCounterRoutine>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1D47114", Offset = "0x1D47114", VA = "0x1D47114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1D47118", Offset = "0x1D47118", VA = "0x1D47118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1D478F8", Offset = "0x1D478F8", VA = "0x1D478F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE48", Offset = "0x9BEE48")]
	private sealed class <MakeRamenRoutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugController <>4__this;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int chairNum;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1D470A4", Offset = "0x1D470A4", VA = "0x1D470A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1D4710C", Offset = "0x1D4710C", VA = "0x1D4710C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1D46D70", Offset = "0x1D46D70", VA = "0x1D46D70")]
		[DebuggerHidden]
		public <MakeRamenRoutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1D46DAC", Offset = "0x1D46DAC", VA = "0x1D46DAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1D46DB0", Offset = "0x1D46DB0", VA = "0x1D46DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1D470AC", Offset = "0x1D470AC", VA = "0x1D470AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject ramenBowlPf;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject beerMugPf;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject ricePf;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject subBowlPf;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject kaedamaPlateHardPf;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject kaedamaPlateNormalPf;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject kaedamaPlateSoftPf;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform testTf;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<GameObject> testList;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isEnable;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject tempRamenBowl;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BezierPointer bezierPointer;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ToolTray toolTray;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1D43C44", Offset = "0x1D43C44", VA = "0x1D43C44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1D43CE0", Offset = "0x1D43CE0", VA = "0x1D43CE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1D44958", Offset = "0x1D44958", VA = "0x1D44958")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1D446A0", Offset = "0x1D446A0", VA = "0x1D446A0")]
	private void SpawnKaedamaBowl()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1D466C8", Offset = "0x1D466C8", VA = "0x1D466C8")]
	private void SpawnKaedamaBowlToTray()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1D46A94", Offset = "0x1D46A94", VA = "0x1D46A94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C6FEC", Offset = "0x9C6FEC")]
	private IEnumerator SpawnKaedamaBowlToTrayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1D44064", Offset = "0x1D44064", VA = "0x1D44064")]
	private void TakeAllOrderSheet()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1D441CC", Offset = "0x1D441CC", VA = "0x1D441CC")]
	private void CloseAllNoren()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1D4429C", Offset = "0x1D4429C", VA = "0x1D4429C")]
	private void SpawnKaedamaPlate()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1D465B8", Offset = "0x1D465B8", VA = "0x1D465B8")]
	private void SpawnCompleteDishToTray()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1D46B3C", Offset = "0x1D46B3C", VA = "0x1D46B3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7050", Offset = "0x9C7050")]
	private IEnumerator SpawnCompleteDishToTrayRoutine(ChairItem chairItem)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1D44124", Offset = "0x1D44124", VA = "0x1D44124")]
	private void SpawnCompleteDishToWaitingCustomer()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1D46C00", Offset = "0x1D46C00", VA = "0x1D46C00")]
	public void SpawnCompleteDishToCounter(int chairNum)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1D46C2C", Offset = "0x1D46C2C", VA = "0x1D46C2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C70B4", Offset = "0x9C70B4")]
	private IEnumerator SpawnCompleteDishToCounterRoutine(int chairNum)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1D46CE4", Offset = "0x1D46CE4", VA = "0x1D46CE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7118", Offset = "0x9C7118")]
	private IEnumerator MakeRamenRoutine(int chairNum)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1D46D9C", Offset = "0x1D46D9C", VA = "0x1D46D9C")]
	public DebugController()
	{
	}
}
[Token(Token = "0x200004E")]
public class DebugDeleteSaveData : UiItemBase
{
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1D48420", Offset = "0x1D48420", VA = "0x1D48420")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1D48504", Offset = "0x1D48504", VA = "0x1D48504", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1D48524", Offset = "0x1D48524", VA = "0x1D48524")]
	public DebugDeleteSaveData()
	{
	}
}
[Token(Token = "0x200004F")]
public class DebugEndGame : UiItemBase
{
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1D4852C", Offset = "0x1D4852C", VA = "0x1D4852C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1D48610", Offset = "0x1D48610", VA = "0x1D48610", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1D48764", Offset = "0x1D48764", VA = "0x1D48764")]
	public DebugEndGame()
	{
	}
}
[Token(Token = "0x2000050")]
public class DebugLogCanvas : MonoBehaviour
{
	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text logText;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text subText;

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1D4876C", Offset = "0x1D4876C", VA = "0x1D4876C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1D48874", Offset = "0x1D48874", VA = "0x1D48874")]
	private void Update()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1D488E4", Offset = "0x1D488E4", VA = "0x1D488E4")]
	private void OnLogMessage(string message, string stackTrace, LogType logType)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1D48AC8", Offset = "0x1D48AC8", VA = "0x1D48AC8")]
	public DebugLogCanvas()
	{
	}
}
[Token(Token = "0x2000051")]
public class DebugMatChange : MonoBehaviour
{
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0804", Offset = "0x9C0804")]
	[SerializeField]
	private bool isApplyNormalMap;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0850", Offset = "0x9C0850")]
	[SerializeField]
	private Material mat;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Texture normalMap;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1D48AD0", Offset = "0x1D48AD0", VA = "0x1D48AD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1D48ADC", Offset = "0x1D48ADC", VA = "0x1D48ADC")]
	private void Update()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1D48B70", Offset = "0x1D48B70", VA = "0x1D48B70")]
	private void Change()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1D48BF4", Offset = "0x1D48BF4", VA = "0x1D48BF4")]
	public DebugMatChange()
	{
	}
}
[Token(Token = "0x2000052")]
public class DebugMoveRigidbody : MonoBehaviour
{
	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody rb;

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1D48BFC", Offset = "0x1D48BFC", VA = "0x1D48BFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1D48C5C", Offset = "0x1D48C5C", VA = "0x1D48C5C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1D48E38", Offset = "0x1D48E38", VA = "0x1D48E38")]
	public DebugMoveRigidbody()
	{
	}
}
[Token(Token = "0x2000053")]
public class InGameDebug : MonoBehaviour
{
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1D543A8", Offset = "0x1D543A8", VA = "0x1D543A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1D544C0", Offset = "0x1D544C0", VA = "0x1D544C0")]
	public InGameDebug()
	{
	}
}
[Token(Token = "0x2000054")]
public class InteractionSystemDebugGUI : MonoBehaviour
{
	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float pickUpTime;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int num;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InteractionObject bothHandTargetObj;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform pivot;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform holdPos;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public InteractionObject[] targetInteractionObj;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform[] ikTargetTf;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private StaffMain staffMain;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private StaffIkControl staffIkControl;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private InteractionSystem interactionSystem;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 pickUpPos;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion pickUpRot;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float holdWeight;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float holdWeightVel;

	[Token(Token = "0x17000005")]
	private bool isHold
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1D58150", Offset = "0x1D58150", VA = "0x1D58150")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000006")]
	private bool isHoldLeft
	{
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1D58188", Offset = "0x1D58188", VA = "0x1D58188")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	private bool isHoldRight
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1D58240", Offset = "0x1D58240", VA = "0x1D58240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1D57D90", Offset = "0x1D57D90", VA = "0x1D57D90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1D57F30", Offset = "0x1D57F30", VA = "0x1D57F30")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1D582F8", Offset = "0x1D582F8", VA = "0x1D582F8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1D59080", Offset = "0x1D59080", VA = "0x1D59080")]
	private void OnInteractionPause(FullBodyBipedEffector effectorType, InteractionObject interactionObj)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1D591C4", Offset = "0x1D591C4", VA = "0x1D591C4")]
	private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObj)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1D592B4", Offset = "0x1D592B4", VA = "0x1D592B4")]
	private void RotatePivot()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1D594A8", Offset = "0x1D594A8", VA = "0x1D594A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1D59624", Offset = "0x1D59624", VA = "0x1D59624")]
	public InteractionSystemDebugGUI()
	{
	}
}
[Token(Token = "0x2000055")]
public class StaffGrabbable : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE58", Offset = "0x9BEE58")]
	private sealed class <OnPickUp>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffGrabbable <>4__this;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xD108A0", Offset = "0xD108A0", VA = "0xD108A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xD10908", Offset = "0xD10908", VA = "0xD10908", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD10438", Offset = "0xD10438", VA = "0xD10438")]
		[DebuggerHidden]
		public <OnPickUp>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD107A8", Offset = "0xD107A8", VA = "0xD107A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xD107AC", Offset = "0xD107AC", VA = "0xD107AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD108A8", Offset = "0xD108A8", VA = "0xD108A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE68", Offset = "0x9BEE68")]
	private sealed class <ReleaseRoutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffGrabbable <>4__this;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool setEnableGrabbing;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0xD10B70", Offset = "0xD10B70", VA = "0xD10B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0xD10BD8", Offset = "0xD10BD8", VA = "0xD10BD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xD10774", Offset = "0xD10774", VA = "0xD10774")]
		[DebuggerHidden]
		public <ReleaseRoutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xD10910", Offset = "0xD10910", VA = "0xD10910", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD10914", Offset = "0xD10914", VA = "0xD10914", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xD10B78", Offset = "0xD10B78", VA = "0xD10B78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C08BC", Offset = "0x9C08BC")]
	public FullBodyBipedEffector targetEffector;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OffsetPose offsetPoseRight;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OffsetPose offsetPoseLeft;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] normalHandPose;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject[] twoFingerHandPose;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GrabReactor[] grabReactors;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float holdWeight;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private InteractionObject interactionObj;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private FullBodyBipedIK triggeredIk;

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xD10338", Offset = "0xD10338", VA = "0xD10338")]
	private void Start()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xD103BC", Offset = "0xD103BC", VA = "0xD103BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C717C", Offset = "0x9C717C")]
	private IEnumerator OnPickUp()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xD10464", Offset = "0xD10464", VA = "0xD10464")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xD105A4", Offset = "0xD105A4", VA = "0xD105A4")]
	public void SetHandPose(bool isTwoFinger)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xD106B4", Offset = "0xD106B4", VA = "0xD106B4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C71E0", Offset = "0x9C71E0")]
	public void Release(bool setEnableGrabbing = true)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xD106E4", Offset = "0xD106E4", VA = "0xD106E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7218", Offset = "0x9C7218")]
	private IEnumerator ReleaseRoutine(bool setEnableGrabbing)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xD107A0", Offset = "0xD107A0", VA = "0xD107A0")]
	public StaffGrabbable()
	{
	}
}
[Token(Token = "0x2000056")]
public class TestBall : MonoBehaviour
{
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE78", Offset = "0x9BEE78")]
	private sealed class <OnPickedUp>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestBall <>4__this;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xD3CC8C", Offset = "0xD3CC8C", VA = "0xD3CC8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xD3CCF4", Offset = "0xD3CCF4", VA = "0xD3CCF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD3C750", Offset = "0xD3C750", VA = "0xD3C750")]
		[DebuggerHidden]
		public <OnPickedUp>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD3CB9C", Offset = "0xD3CB9C", VA = "0xD3CB9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD3CBA0", Offset = "0xD3CBA0", VA = "0xD3CBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xD3CC94", Offset = "0xD3CC94", VA = "0xD3CC94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000189")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE88", Offset = "0x9BEE88")]
	private sealed class <DropRoutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestBall <>4__this;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xD3CB2C", Offset = "0xD3CB2C", VA = "0xD3CB2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xD3CB94", Offset = "0xD3CB94", VA = "0xD3CB94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xD3C99C", Offset = "0xD3C99C", VA = "0xD3C99C")]
		[DebuggerHidden]
		public <DropRoutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xD3C9D0", Offset = "0xD3C9D0", VA = "0xD3C9D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xD3C9D4", Offset = "0xD3C9D4", VA = "0xD3C9D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xD3CB34", Offset = "0xD3CB34", VA = "0xD3CB34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OffsetPose offsetPose;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float holdWeight;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private InteractionObject interactionObj;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FullBodyBipedIK ik;

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xD3C674", Offset = "0xD3C674", VA = "0xD3C674")]
	private void Start()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xD3C6D4", Offset = "0xD3C6D4", VA = "0xD3C6D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C727C", Offset = "0x9C727C")]
	private IEnumerator OnPickedUp()
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xD3C77C", Offset = "0xD3C77C", VA = "0xD3C77C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xD3C878", Offset = "0xD3C878", VA = "0xD3C878")]
	private void Update()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xD3C920", Offset = "0xD3C920", VA = "0xD3C920")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C72E0", Offset = "0x9C72E0")]
	private IEnumerator DropRoutine()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xD3C9C8", Offset = "0xD3C9C8", VA = "0xD3C9C8")]
	public TestBall()
	{
	}
}
[Token(Token = "0x2000057")]
public class BeerServer : MonoBehaviour
{
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0944", Offset = "0x9C0944")]
	public BeerServerHandle[] serverHandles;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xEBC9E8", Offset = "0xEBC9E8", VA = "0xEBC9E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xEBCA48", Offset = "0xEBCA48", VA = "0xEBCA48")]
	private void Update()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xEBCB14", Offset = "0xEBCB14", VA = "0xEBCB14")]
	public BeerServer()
	{
	}
}
[Token(Token = "0x2000058")]
public class BowArea : MonoBehaviour
{
	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject bowGuideObj;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ObscuredInt chairNum;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xEBE3F4", Offset = "0xEBE3F4", VA = "0xEBE3F4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xEBE534", Offset = "0xEBE534", VA = "0xEBE534")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xEBE538", Offset = "0xEBE538", VA = "0xEBE538")]
	public void SetChairNum(int num)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xEBE3F8", Offset = "0xEBE3F8", VA = "0xEBE3F8")]
	private void CheckBowing(Collider other)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xEBE9B4", Offset = "0xEBE9B4", VA = "0xEBE9B4")]
	public BowArea()
	{
	}
}
[Token(Token = "0x2000059")]
public class DishDestroy : MonoBehaviour
{
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CookBase.DishType dishType;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1D4B614", Offset = "0x1D4B614", VA = "0x1D4B614")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1D4B848", Offset = "0x1D4B848", VA = "0x1D4B848")]
	public DishDestroy()
	{
	}
}
[Token(Token = "0x200005A")]
public class DishDestroyDetector : MonoBehaviour
{
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float radius;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GrabbableItem grabbable;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool preGrabbed;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CookBase cookBase;

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1D4B850", Offset = "0x1D4B850", VA = "0x1D4B850")]
	private void Start()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1D4B8D4", Offset = "0x1D4B8D4", VA = "0x1D4B8D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1D4B924", Offset = "0x1D4B924", VA = "0x1D4B924")]
	private void CheckNearDestroyer()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1D4BA68", Offset = "0x1D4BA68", VA = "0x1D4BA68")]
	public DishDestroyDetector()
	{
	}
}
[Token(Token = "0x200005B")]
public class GrabbableItemRecover : MonoBehaviour
{
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1D5232C", Offset = "0x1D5232C", VA = "0x1D5232C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1D5253C", Offset = "0x1D5253C", VA = "0x1D5253C")]
	public GrabbableItemRecover()
	{
	}
}
[Token(Token = "0x200005C")]
public class IngredientDestroy : MonoBehaviour
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Ingredient.Type ingredientType;

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1D54910", Offset = "0x1D54910", VA = "0x1D54910")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1D54ACC", Offset = "0x1D54ACC", VA = "0x1D54ACC")]
	public IngredientDestroy()
	{
	}
}
[Token(Token = "0x200005D")]
public class IngredientDestroyDetector : MonoBehaviour
{
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float radius;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GrabbableItem grabbable;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool preGrabbed;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Ingredient ingredient;

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1D54AD4", Offset = "0x1D54AD4", VA = "0x1D54AD4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1D54B58", Offset = "0x1D54B58", VA = "0x1D54B58")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1D54BA8", Offset = "0x1D54BA8", VA = "0x1D54BA8")]
	private void CheckNearDestroyer()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1D54CEC", Offset = "0x1D54CEC", VA = "0x1D54CEC")]
	public IngredientDestroyDetector()
	{
	}
}
[Token(Token = "0x200005E")]
public class LoadToMemory : MonoBehaviour
{
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEE98", Offset = "0x9BEE98")]
	private sealed class <Start>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadToMemory <>4__this;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1D5B58C", Offset = "0x1D5B58C", VA = "0x1D5B58C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1D5B5F4", Offset = "0x1D5B5F4", VA = "0x1D5B5F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1D5B434", Offset = "0x1D5B434", VA = "0x1D5B434")]
		[DebuggerHidden]
		public <Start>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1D5B468", Offset = "0x1D5B468", VA = "0x1D5B468", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1D5B46C", Offset = "0x1D5B46C", VA = "0x1D5B46C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1D5B594", Offset = "0x1D5B594", VA = "0x1D5B594", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1D5B3B8", Offset = "0x1D5B3B8", VA = "0x1D5B3B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7344", Offset = "0x9C7344")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1D5B460", Offset = "0x1D5B460", VA = "0x1D5B460")]
	public LoadToMemory()
	{
	}
}
[Token(Token = "0x200005F")]
public class NorenGrabReactor : GrabReactor
{
	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEEA8", Offset = "0x9BEEA8")]
	private sealed class <AutoCloseRoutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NorenGrabReactor <>4__this;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <startCloseRate>5__3;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <endCloseRate>5__4;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xDBC8D0", Offset = "0xDBC8D0", VA = "0xDBC8D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xDBC938", Offset = "0xDBC938", VA = "0xDBC938", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xDBC544", Offset = "0xDBC544", VA = "0xDBC544")]
		[DebuggerHidden]
		public <AutoCloseRoutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xDBC760", Offset = "0xDBC760", VA = "0xDBC760", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xDBC764", Offset = "0xDBC764", VA = "0xDBC764", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xDBC8D8", Offset = "0xDBC8D8", VA = "0xDBC8D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEEB8", Offset = "0x9BEEB8")]
	private sealed class <AutoOpenRoutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NorenGrabReactor <>4__this;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <startCloseRate>5__3;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <endCloseRate>5__4;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xDBCB1C", Offset = "0xDBCB1C", VA = "0xDBCB1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0xDBCB84", Offset = "0xDBCB84", VA = "0xDBCB84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xDBC680", Offset = "0xDBC680", VA = "0xDBC680")]
		[DebuggerHidden]
		public <AutoOpenRoutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xDBC940", Offset = "0xDBC940", VA = "0xDBC940", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xDBC944", Offset = "0xDBC944", VA = "0xDBC944", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xDBCB24", Offset = "0xDBCB24", VA = "0xDBCB24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C099C", Offset = "0x9C099C")]
	public bool isLocked;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool isClose;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool isParentKinematic;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float closingTime;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Vector3 clampedWorldPos;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C09F4", Offset = "0x9C09F4")]
	[SerializeField]
	private Transform openPosTf;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform closePosTf;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject penetrateBlocker;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float lockPosThreshold;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform rootTf;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator animator;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private OverlapGrabController grabbedOverlapController;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine autoRoutine;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ObscuredFloat closeKinematicTime;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ObscuredFloat closeHeight;

	[Token(Token = "0x40001D5")]
	private const string ANIM_CLOSE_RATE = "Close";

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xDBBDA8", Offset = "0xDBBDA8", VA = "0xDBBDA8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xDBBE50", Offset = "0xDBBE50", VA = "0xDBBE50", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xDBC084", Offset = "0xDBC084", VA = "0xDBC084")]
	private void CheckCloseState()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xDBC224", Offset = "0xDBC224", VA = "0xDBC224", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xDBBE90", Offset = "0xDBBE90", VA = "0xDBBE90")]
	private void MovePosition()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xDBBFE4", Offset = "0xDBBFE4", VA = "0xDBBFE4")]
	private void CheckRelease()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xDBC300", Offset = "0xDBC300", VA = "0xDBC300")]
	private void Release()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xDBC3B4", Offset = "0xDBC3B4", VA = "0xDBC3B4")]
	public void AutoClose(float duration = 0.5f)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xDBC4B8", Offset = "0xDBC4B8", VA = "0xDBC4B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C73A8", Offset = "0x9C73A8")]
	private IEnumerator AutoCloseRoutine(float duration)
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xDBC570", Offset = "0xDBC570", VA = "0xDBC570")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C740C", Offset = "0x9C740C")]
	public void AutoOpen()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xDBC42C", Offset = "0xDBC42C", VA = "0xDBC42C")]
	public void AutoOpen(float delay, float duration)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xDBC5EC", Offset = "0xDBC5EC", VA = "0xDBC5EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7444", Offset = "0x9C7444")]
	private IEnumerator AutoOpenRoutine(float delay, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xDBC6AC", Offset = "0xDBC6AC", VA = "0xDBC6AC")]
	public NorenGrabReactor()
	{
	}
}
[Token(Token = "0x2000060")]
public class ParticleStopInPause : MonoBehaviour
{
	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystemRenderer particleRenderer;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xDC1E3C", Offset = "0xDC1E3C", VA = "0xDC1E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xDC1FBC", Offset = "0xDC1FBC", VA = "0xDC1FBC")]
	public ParticleStopInPause()
	{
	}
}
[Token(Token = "0x2000061")]
public class PlayAreaLimit : MonoBehaviour
{
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xDC2C64", Offset = "0xDC2C64", VA = "0xDC2C64")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xDC2D80", Offset = "0xDC2D80", VA = "0xDC2D80")]
	public PlayAreaLimit()
	{
	}
}
[Token(Token = "0x2000062")]
public class TitleHuman : MonoBehaviour
{
	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEEC8", Offset = "0x9BEEC8")]
	private sealed class <Start>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TitleHuman <>4__this;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NavMeshAgent <navMeshAgent>5__2;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xD3DFE4", Offset = "0xD3DFE4", VA = "0xD3DFE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0xD3E04C", Offset = "0xD3E04C", VA = "0xD3E04C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xD3DE78", Offset = "0xD3DE78", VA = "0xD3DE78")]
		[DebuggerHidden]
		public <Start>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xD3DEAC", Offset = "0xD3DEAC", VA = "0xD3DEAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xD3DEB0", Offset = "0xD3DEB0", VA = "0xD3DEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD3DFEC", Offset = "0xD3DFEC", VA = "0xD3DFEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD3DDFC", Offset = "0xD3DDFC", VA = "0xD3DDFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C74A8", Offset = "0x9C74A8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD3DEA4", Offset = "0xD3DEA4", VA = "0xD3DEA4")]
	public TitleHuman()
	{
	}
}
[Token(Token = "0x2000063")]
public class WashWaterArea : MonoBehaviour
{
	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform waterSurfaceTf;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject splashEffectPf;

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x192ADF0", Offset = "0x192ADF0", VA = "0x192ADF0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x192B254", Offset = "0x192B254", VA = "0x192B254")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x192B068", Offset = "0x192B068", VA = "0x192B068")]
	private void SplashEffect(Collider other, [Optional] AudioClip clip)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x192B45C", Offset = "0x192B45C", VA = "0x192B45C")]
	public WashWaterArea()
	{
	}
}
[Token(Token = "0x2000064")]
public class TextLocalize : MonoBehaviour
{
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0A80", Offset = "0x9C0A80")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI tmproText;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0ADC", Offset = "0x9C0ADC")]
	[SerializeField]
	[Multiline]
	private string english;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Multiline]
	private string japanese;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Multiline]
	private string chinese;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0BA8", Offset = "0x9C0BA8")]
	[SerializeField]
	private bool showLog;

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xD3CFCC", Offset = "0xD3CFCC", VA = "0xD3CFCC")]
	private void Reset()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xD3CFD0", Offset = "0xD3CFD0", VA = "0xD3CFD0")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C750C", Offset = "0x9C750C")]
	private void DetectComponent()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xD3D054", Offset = "0xD3D054", VA = "0xD3D054")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xD3D4A4", Offset = "0xD3D4A4", VA = "0xD3D4A4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xD3D174", Offset = "0xD3D174", VA = "0xD3D174")]
	private void ApplyText()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD3D4A8", Offset = "0xD3D4A8", VA = "0xD3D4A8")]
	public TextLocalize()
	{
	}
}
[Token(Token = "0x2000065")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BEA88", Offset = "0x9BEA88")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BEA88", Offset = "0x9BEA88")]
public class MeshDrawer : MonoBehaviour
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform[] verticeTfs;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshFilter meshFilter;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xDB96E8", Offset = "0xDB96E8", VA = "0xDB96E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xDB97A0", Offset = "0xDB97A0", VA = "0xDB97A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xDB98F4", Offset = "0xDB98F4", VA = "0xDB98F4")]
	public MeshDrawer()
	{
	}
}
[Token(Token = "0x2000066")]
public class ProjectorMeshDrawer : MonoBehaviour
{
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0C04", Offset = "0x9C0C04")]
	public Transform originTf;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0C3C", Offset = "0x9C0C3C")]
	[SerializeField]
	private Transform[] topVerticeTfs;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform[] bottomVerticeTfs;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform[] leftVerticeTfs;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform[] rightVerticeTfs;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshFilter meshFilter;

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xDCA658", Offset = "0xDCA658", VA = "0xDCA658")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xDCA750", Offset = "0xDCA750", VA = "0xDCA750")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xDCA730", Offset = "0xDCA730", VA = "0xDCA730")]
	public void SetShow(bool value)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xDCAA20", Offset = "0xDCAA20", VA = "0xDCAA20")]
	public ProjectorMeshDrawer()
	{
	}
}
[Token(Token = "0x2000067")]
public class OculusPlatform : SingletonMonoBehaviour<OculusPlatform>
{
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEED8", Offset = "0x9BEED8")]
	private sealed class <Start>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OculusPlatform <>4__this;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xDBEB9C", Offset = "0xDBEB9C", VA = "0xDBEB9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0xDBEC04", Offset = "0xDBEC04", VA = "0xDBEC04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xDBCC08", Offset = "0xDBCC08", VA = "0xDBCC08")]
		[DebuggerHidden]
		public <Start>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xDBE6AC", Offset = "0xDBE6AC", VA = "0xDBE6AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xDBE6B0", Offset = "0xDBE6B0", VA = "0xDBE6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xDBEBA4", Offset = "0xDBEBA4", VA = "0xDBEBA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isLostInput;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool isTrackingLost;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string playerName;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong playerID;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool enableCheckInputFocus;

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xDBCB8C", Offset = "0xDBCB8C", VA = "0xDBCB8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7544", Offset = "0x9C7544")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xDBCC34", Offset = "0xDBCC34", VA = "0xDBCC34")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xDBCD24", Offset = "0xDBCD24", VA = "0xDBCD24")]
	private void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xDBD528", Offset = "0xDBD528", VA = "0xDBD528")]
	private void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xDBD9B4", Offset = "0xDBD9B4", VA = "0xDBD9B4")]
	private void OnTrackingLost()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xDBDAF8", Offset = "0xDBDAF8", VA = "0xDBDAF8")]
	private void OnTrackingAcquired()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xDBDBD0", Offset = "0xDBDBD0", VA = "0xDBDBD0")]
	private void OnMountedHmd()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xDBDCE4", Offset = "0xDBDCE4", VA = "0xDBDCE4")]
	private void OnUnmountedHmd()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xDBDECC", Offset = "0xDBDECC", VA = "0xDBDECC")]
	public void GetLoggedInUserCallBack(Message<User> msg)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xDBDFBC", Offset = "0xDBDFBC", VA = "0xDBDFBC")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xDBE534", Offset = "0xDBE534", VA = "0xDBE534")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xDBCC78", Offset = "0xDBCC78", VA = "0xDBCC78")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xDBE65C", Offset = "0xDBE65C", VA = "0xDBE65C")]
	public OculusPlatform()
	{
	}
}
[Token(Token = "0x2000068")]
public class OculusQuestSetting : MonoBehaviour
{
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xDBEC0C", Offset = "0xDBEC0C", VA = "0xDBEC0C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xDBEC88", Offset = "0xDBEC88", VA = "0xDBEC88")]
	public OculusQuestSetting()
	{
	}
}
[Token(Token = "0x2000069")]
public class PlatformManager : MonoBehaviour
{
	[Token(Token = "0x200018F")]
	public delegate void OnComplete();

	[Token(Token = "0x2000190")]
	public enum PlatformType
	{
		[Token(Token = "0x4000935")]
		Oculus,
		[Token(Token = "0x4000936")]
		Steam,
		[Token(Token = "0x4000937")]
		HTCViveport,
		[Token(Token = "0x4000938")]
		Vrotein,
		[Token(Token = "0x4000939")]
		PlayStationNetwork,
		[Token(Token = "0x400093A")]
		Other_SideQuest
	}

	[Token(Token = "0x2000191")]
	public enum DeviceType
	{
		[Token(Token = "0x400093C")]
		NULL,
		[Token(Token = "0x400093D")]
		RiftTouch,
		[Token(Token = "0x400093E")]
		ViveOpenVR,
		[Token(Token = "0x400093F")]
		OtherOpenVR,
		[Token(Token = "0x4000940")]
		RiftOpenVR,
		[Token(Token = "0x4000941")]
		PSVR,
		[Token(Token = "0x4000942")]
		Quest,
		[Token(Token = "0x4000943")]
		Quest2
	}

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlatformManager instance;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlatformType platformType;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public DeviceType deviceType;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string playerName;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string playerID;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0CB8", Offset = "0x9C0CB8")]
	[SerializeField]
	private bool forceDeviceType;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private DeviceType debugDeviceType;

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xDC27D4", Offset = "0xDC27D4", VA = "0xDC27D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xDC28E4", Offset = "0xDC28E4", VA = "0xDC28E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xDC2980", Offset = "0xDC2980", VA = "0xDC2980")]
	public string GetPlatformPrefix()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xDC2A04", Offset = "0xDC2A04", VA = "0xDC2A04")]
	public PlatformManager()
	{
	}
}
[Token(Token = "0x200006A")]
public class CalorieCalcManager : MonoBehaviour
{
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CalorieCalcManager instance;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform head;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform rightHand;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform leftHand;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0D54", Offset = "0x9C0D54")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C0D54", Offset = "0x9C0D54")]
	[SerializeField]
	private float totalDistance;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 lastHeadPos;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 lastRightHandPos;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 lastLeftHandPos;

	[Token(Token = "0x40001FE")]
	private const float HEAD_MULTIPLE = 1.5f;

	[Token(Token = "0x40001FF")]
	private const float CALORIES_BURN_RATE = 2.5f;

	[Token(Token = "0x4000200")]
	private const float IGNORE_DISTANCE_AT_FRAME = 0.1f;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xEC0300", Offset = "0xEC0300", VA = "0xEC0300")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xEC03CC", Offset = "0xEC03CC", VA = "0xEC03CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xEC0408", Offset = "0xEC0408", VA = "0xEC0408")]
	private float CalcDistance()
	{
		return default(float);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xEC0880", Offset = "0xEC0880", VA = "0xEC0880")]
	public void ResetDistance()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xEC0888", Offset = "0xEC0888", VA = "0xEC0888")]
	public float GetBurnedCalories()
	{
		return default(float);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xEC0898", Offset = "0xEC0898", VA = "0xEC0898")]
	public CalorieCalcManager()
	{
	}
}
[Token(Token = "0x200006B")]
public class DoorKnobGrabber : MonoBehaviour
{
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0DBC", Offset = "0x9C0DBC")]
	[SerializeField]
	private GameObject grabbingObj;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0E08", Offset = "0x9C0E08")]
	[SerializeField]
	private bool isRight;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OverlapGrabController overlapGrabController;

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1D4C040", Offset = "0x1D4C040", VA = "0x1D4C040")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1D4C0A0", Offset = "0x1D4C0A0", VA = "0x1D4C0A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1D4C1C4", Offset = "0x1D4C1C4", VA = "0x1D4C1C4")]
	private void CheckKnobCollider()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1D4C31C", Offset = "0x1D4C31C", VA = "0x1D4C31C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1D4C494", Offset = "0x1D4C494", VA = "0x1D4C494")]
	private void Grab(GameObject otherObj)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1D4C1C8", Offset = "0x1D4C1C8", VA = "0x1D4C1C8")]
	private void Release()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1D4C59C", Offset = "0x1D4C59C", VA = "0x1D4C59C")]
	public DoorKnobGrabber()
	{
	}
}
[Token(Token = "0x200006C")]
public class GrabPosAngle : MonoBehaviour
{
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isDefaultPos;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isFreePos;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 grabLocalPos;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 grabLocalAngle;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool isRightSpecific;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 grabLocalPosRight;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grabLocalAngleRight;

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1D5064C", Offset = "0x1D5064C", VA = "0x1D5064C")]
	public GrabPosAngle()
	{
	}
}
[Token(Token = "0x200006D")]
public class GrabbableItem : GrabReactor
{
	[Token(Token = "0x2000192")]
	public enum HandPose
	{
		[Token(Token = "0x4000945")]
		Grab,
		[Token(Token = "0x4000946")]
		Pinch
	}

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0E54", Offset = "0x9C0E54")]
	public float lastReleaseTime;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0E8C", Offset = "0x9C0E8C")]
	public HandPose handPose;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool disableHandIfGrabbed;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool needButtonToRelease;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip grabSound;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject[] disableObjectIfGrabbed;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Rigidbody rb;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 spawnPos;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion spawnRot;

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1D51EDC", Offset = "0x1D51EDC", VA = "0x1D51EDC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1D51F98", Offset = "0x1D51F98", VA = "0x1D51F98", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1D51FF4", Offset = "0x1D51FF4", VA = "0x1D51FF4")]
	public void ReturnSpawnPos()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1D51140", Offset = "0x1D51140", VA = "0x1D51140")]
	public void SetGrabState(bool grabValue, bool isRight, bool isChopsticks, GrabReactorTriggerBase trigger)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1D5204C", Offset = "0x1D5204C", VA = "0x1D5204C")]
	private void GrabSound()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1D52140", Offset = "0x1D52140", VA = "0x1D52140")]
	public void Release()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1D5221C", Offset = "0x1D5221C", VA = "0x1D5221C", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1D52308", Offset = "0x1D52308", VA = "0x1D52308")]
	public GrabbableItem()
	{
	}
}
[Token(Token = "0x200006E")]
public class HandAnimation : MonoBehaviour
{
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0EE4", Offset = "0x9C0EE4")]
	[SerializeField]
	private OverlapGrabController grabController;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0F30", Offset = "0x9C0F30")]
	[SerializeField]
	private bool isRight;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator handAnimator;

	[Token(Token = "0x4000217")]
	private const string ANIM_CLOSE_HAND = "Close";

	[Token(Token = "0x4000218")]
	private const string ANIM_GRAB = "Grab";

	[Token(Token = "0x4000219")]
	private const string ANIM_PINCH = "Pinch";

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1D53150", Offset = "0x1D53150", VA = "0x1D53150")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1D53214", Offset = "0x1D53214", VA = "0x1D53214")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1D53418", Offset = "0x1D53418", VA = "0x1D53418")]
	public HandAnimation()
	{
	}
}
[Token(Token = "0x200006F")]
public class HandGrabAnimation : MonoBehaviour
{
	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0F8C", Offset = "0x9C0F8C")]
	[SerializeField]
	private bool isRight;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator animator;

	[Token(Token = "0x400021C")]
	private const string ANIM_GRAB_VALUE = "GrabValue";

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1D53420", Offset = "0x1D53420", VA = "0x1D53420")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1D53480", Offset = "0x1D53480", VA = "0x1D53480")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1D53530", Offset = "0x1D53530", VA = "0x1D53530")]
	public HandGrabAnimation()
	{
	}
}
[Token(Token = "0x2000070")]
public class PlayerBow : MonoBehaviour
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isBowingAngle;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ObscuredFloat NEED_ANGLE;

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xDC2D88", Offset = "0xDC2D88", VA = "0xDC2D88")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xDC2E04", Offset = "0xDC2E04", VA = "0xDC2E04")]
	public PlayerBow()
	{
	}
}
[Token(Token = "0x2000071")]
public class PlayerDefaultPosition : SingletonMonoBehaviour<PlayerDefaultPosition>
{
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEEE8", Offset = "0x9BEEE8")]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerDefaultPosition <>4__this;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xDC3B94", Offset = "0xDC3B94", VA = "0xDC3B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xDC3BFC", Offset = "0xDC3BFC", VA = "0xDC3BFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xDC2EFC", Offset = "0xDC2EFC", VA = "0xDC2EFC")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xDC3AE0", Offset = "0xDC3AE0", VA = "0xDC3AE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xDC3AE4", Offset = "0xDC3AE4", VA = "0xDC3AE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xDC3B9C", Offset = "0xDC3B9C", VA = "0xDC3B9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEEF8", Offset = "0x9BEEF8")]
	private sealed class <RecenterRoutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerDefaultPosition <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xDC3A70", Offset = "0xDC3A70", VA = "0xDC3A70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xDC3AD8", Offset = "0xDC3AD8", VA = "0xDC3AD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xDC3120", Offset = "0xDC3120", VA = "0xDC3120")]
		[DebuggerHidden]
		public <RecenterRoutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xDC3550", Offset = "0xDC3550", VA = "0xDC3550", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xDC3554", Offset = "0xDC3554", VA = "0xDC3554", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xDC3A78", Offset = "0xDC3A78", VA = "0xDC3A78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF08", Offset = "0x9BEF08")]
	private sealed class <RecenterPositionWithWipeRoutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerDefaultPosition <>4__this;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xDC34E0", Offset = "0xDC34E0", VA = "0xDC34E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xDC3548", Offset = "0xDC3548", VA = "0xDC3548", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xDC31F4", Offset = "0xDC31F4", VA = "0xDC31F4")]
		[DebuggerHidden]
		public <RecenterPositionWithWipeRoutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xDC3270", Offset = "0xDC3270", VA = "0xDC3270", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xDC3274", Offset = "0xDC3274", VA = "0xDC3274", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xDC34E8", Offset = "0xDC34E8", VA = "0xDC34E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isRecentering;

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xDC2E80", Offset = "0xDC2E80", VA = "0xDC2E80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C75A8", Offset = "0x9C75A8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xDC2F28", Offset = "0xDC2F28", VA = "0xDC2F28")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xDC3078", Offset = "0xDC3078", VA = "0xDC3078")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C760C", Offset = "0x9C760C")]
	public void RecenterPosition()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xDC30A4", Offset = "0xDC30A4", VA = "0xDC30A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7644", Offset = "0x9C7644")]
	private IEnumerator RecenterRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xDC314C", Offset = "0xDC314C", VA = "0xDC314C")]
	public void RecenterPositionWithWipe()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xDC3178", Offset = "0xDC3178", VA = "0xDC3178")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C76A8", Offset = "0x9C76A8")]
	private IEnumerator RecenterPositionWithWipeRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xDC3220", Offset = "0xDC3220", VA = "0xDC3220")]
	public PlayerDefaultPosition()
	{
	}
}
[Token(Token = "0x2000072")]
public class PlayerFingerAngle : MonoBehaviour
{
	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C0FD8", Offset = "0x9C0FD8")]
	[SerializeField]
	private bool isClose;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1024", Offset = "0x9C1024")]
	[SerializeField]
	private bool isRight;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float angleRateStep;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float rayDistance;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C10A0", Offset = "0x9C10A0")]
	[SerializeField]
	private Transform[] indexJointTfs;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform[] midJointTfs;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform[] ringJointTfs;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform[] pinkyJointTfs;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform[] thumbJointTfs;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C112C", Offset = "0x9C112C")]
	[SerializeField]
	private Transform indexTipTf;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform midTipTf;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform ringTipTf;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform pinkyTipTf;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform thumbTipTf;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C11B8", Offset = "0x9C11B8")]
	[SerializeField]
	private float indexStartAngleZ;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float midStartAngleZ;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float ringStartAngleZ;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float pinkyStartAngleZ;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float thumbStartAngleZ;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1244", Offset = "0x9C1244")]
	[SerializeField]
	private float indexAngleLimitZ;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float midAngleLimitZ;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	private float ringAngleLimitZ;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private float pinkyAngleLimitZ;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float thumbAngleLimitZ;

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xDC3C04", Offset = "0xDC3C04", VA = "0xDC3C04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xDC3CBC", Offset = "0xDC3CBC", VA = "0xDC3CBC")]
	private void ClosingAngle()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xDC3EF8", Offset = "0xDC3EF8", VA = "0xDC3EF8")]
	private void OpenningAngle()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xDC40A4", Offset = "0xDC40A4", VA = "0xDC40A4")]
	public PlayerFingerAngle()
	{
	}
}
[Token(Token = "0x2000073")]
public class PlayerManager : SingletonMonoBehaviour<PlayerManager>
{
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C12D0", Offset = "0x9C12D0")]
	public GameObject head;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject rightController;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject leftController;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject rightHandColliderPos;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject leftHandColliderPos;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject rightHandModelPos;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject leftHandModelPos;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject rightHandModel;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject leftHandModel;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform rightRaycastTf;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform leftRaycastTf;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform rightProjectionOriginTf;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform leftProjectionOriginTf;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1308", Offset = "0x9C1308")]
	public Transform headIkTf;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform leftHandIkTf;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform rightHandIkTf;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xDC40B8", Offset = "0xDC40B8", VA = "0xDC40B8")]
	public void ToggleShowDeviceView()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xDC40DC", Offset = "0xDC40DC", VA = "0xDC40DC")]
	public PlayerManager()
	{
	}
}
[Token(Token = "0x2000074")]
public class PlayerNavMeshPosAdjust : MonoBehaviour
{
	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform posAdjustTf;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform headTf;

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xDC412C", Offset = "0xDC412C", VA = "0xDC412C")]
	private void Start()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xDC41D0", Offset = "0xDC41D0", VA = "0xDC41D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xDC42E4", Offset = "0xDC42E4", VA = "0xDC42E4")]
	public PlayerNavMeshPosAdjust()
	{
	}
}
[Token(Token = "0x2000075")]
public class PlayerRootManager : SingletonMonoBehaviour<PlayerRootManager>
{
	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1350", Offset = "0x9C1350")]
	public GameObject rightHand;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject leftHand;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject rightHandModel;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject leftHandModel;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform headTf;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x4000251")]
	private const float SITTING_HEIGHT = 1.3f;

	[Token(Token = "0x4000252")]
	private const float STANDING_HEIGHT = 1.4f;

	[Token(Token = "0x4000253")]
	private const float SITTING_HEIGHT_OFFSET = 0.35f;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xDC42EC", Offset = "0xDC42EC", VA = "0xDC42EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xDC43B4", Offset = "0xDC43B4", VA = "0xDC43B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xDC4524", Offset = "0xDC4524", VA = "0xDC4524")]
	private void CheckSitting()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xDC4788", Offset = "0xDC4788", VA = "0xDC4788")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xDC495C", Offset = "0xDC495C", VA = "0xDC495C")]
	public void ReleaseAllGrabbedItem()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xDC3A50", Offset = "0xDC3A50", VA = "0xDC3A50")]
	public void SetEnableNavMeshAgent(bool value)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xDC4AA0", Offset = "0xDC4AA0", VA = "0xDC4AA0")]
	public void SetActiveHandModel(bool isActive, bool isRight)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xDBCE4C", Offset = "0xDBCE4C", VA = "0xDBCE4C")]
	public void SetActiveBothHandModel(bool isActive)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xDC4B20", Offset = "0xDC4B20", VA = "0xDC4B20")]
	public PlayerRootManager()
	{
	}
}
[Token(Token = "0x2000076")]
public class PlayerRotater : MonoBehaviour
{
	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF18", Offset = "0x9BEF18")]
	private sealed class <RotateRoutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerRotater <>4__this;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isRight;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xDC512C", Offset = "0xDC512C", VA = "0xDC512C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xDC5194", Offset = "0xDC5194", VA = "0xDC5194", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xDC4DEC", Offset = "0xDC4DEC", VA = "0xDC4DEC")]
		[DebuggerHidden]
		public <RotateRoutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xDC4E30", Offset = "0xDC4E30", VA = "0xDC4E30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xDC4E34", Offset = "0xDC4E34", VA = "0xDC4E34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xDC5134", Offset = "0xDC5134", VA = "0xDC5134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1388", Offset = "0x9C1388")]
	[SerializeField]
	private float rotateAngleStep;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool isRotating;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float rotatingDelay;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xDC4B70", Offset = "0xDC4B70", VA = "0xDC4B70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xDC4D5C", Offset = "0xDC4D5C", VA = "0xDC4D5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C770C", Offset = "0x9C770C")]
	private IEnumerator RotateRoutine(bool isRight)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xDC4E18", Offset = "0xDC4E18", VA = "0xDC4E18")]
	public PlayerRotater()
	{
	}
}
[Token(Token = "0x2000077")]
public class PlayerTeleport : MonoBehaviour
{
	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF28", Offset = "0x9BEF28")]
	private sealed class <TeleportRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerTeleport <>4__this;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <hitPosTemp>5__2;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0xDC6084", Offset = "0xDC6084", VA = "0xDC6084", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0xDC60EC", Offset = "0xDC60EC", VA = "0xDC60EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xDC5C28", Offset = "0xDC5C28", VA = "0xDC5C28")]
		[DebuggerHidden]
		public <TeleportRoutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xDC5C5C", Offset = "0xDC5C5C", VA = "0xDC5C5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xDC5C60", Offset = "0xDC5C60", VA = "0xDC5C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xDC608C", Offset = "0xDC608C", VA = "0xDC608C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C13D4", Offset = "0x9C13D4")]
	[SerializeField]
	private Vector3 hitPos;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject hitObj;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1430", Offset = "0x9C1430")]
	[SerializeField]
	private Color movablePosColor;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color unmovablePosColor;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isRightPointing;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Quaternion hitRot;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private BezierPointer bezierPointer;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private LineRenderer lineRender;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isHit;

	[Token(Token = "0x4000260")]
	private const int LAYER_GOUND = 10;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xDC519C", Offset = "0xDC519C", VA = "0xDC519C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xDC5220", Offset = "0xDC5220", VA = "0xDC5220")]
	private void Update()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xDC5B80", Offset = "0xDC5B80", VA = "0xDC5B80")]
	private void Teleport()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xDC5BAC", Offset = "0xDC5BAC", VA = "0xDC5BAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7770", Offset = "0x9C7770")]
	private IEnumerator TeleportRoutine()
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xDC5ABC", Offset = "0xDC5ABC", VA = "0xDC5ABC")]
	private void SetLine(Vector3 originPos, Vector3 destPos)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xDC5C54", Offset = "0xDC5C54", VA = "0xDC5C54")]
	public PlayerTeleport()
	{
	}
}
[Token(Token = "0x2000078")]
public class WallPenetrateAvoid : MonoBehaviour
{
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float castRadius;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform leftHand;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform rightHand;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform headTf;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SyncPosition syncPosLeft;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SyncPosition syncPosRight;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x192A774", Offset = "0x192A774", VA = "0x192A774")]
	private void Start()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x192A9A0", Offset = "0x192A9A0", VA = "0x192A9A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x192A9C4", Offset = "0x192A9C4", VA = "0x192A9C4")]
	private void CheckLeftHand()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x192ABD0", Offset = "0x192ABD0", VA = "0x192ABD0")]
	private void CheckRightHand()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x192ADDC", Offset = "0x192ADDC", VA = "0x192ADDC")]
	public WallPenetrateAvoid()
	{
	}
}
[Token(Token = "0x2000079")]
public class WristWatch : SingletonMonoBehaviour<WristWatch>
{
	[Token(Token = "0x2000198")]
	public enum IconType
	{
		[Token(Token = "0x4000959")]
		Normal,
		[Token(Token = "0x400095A")]
		Miss,
		[Token(Token = "0x400095B")]
		Call,
		[Token(Token = "0x400095C")]
		Success
	}

	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF38", Offset = "0x9BEF38")]
	private sealed class <SetNormalRoutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WristWatch <>4__this;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x192D118", Offset = "0x192D118", VA = "0x192D118", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x192D180", Offset = "0x192D180", VA = "0x192D180", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x192CB7C", Offset = "0x192CB7C", VA = "0x192CB7C")]
		[DebuggerHidden]
		public <SetNormalRoutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x192D03C", Offset = "0x192D03C", VA = "0x192D03C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x192D040", Offset = "0x192D040", VA = "0x192D040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x192D120", Offset = "0x192D120", VA = "0x192D120", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SkinnedMeshRenderer leftRenderer;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SkinnedMeshRenderer rightRenderer;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float showDuration;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine setNormalRoutine;

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x192CA44", Offset = "0x192CA44", VA = "0x192CA44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x192CAB4", Offset = "0x192CAB4", VA = "0x192CAB4")]
	public void SetNormalIconWithDelay(float delay)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x192CAF0", Offset = "0x192CAF0", VA = "0x192CAF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C77D4", Offset = "0x9C77D4")]
	private IEnumerator SetNormalRoutine(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x192CBA8", Offset = "0x192CBA8", VA = "0x192CBA8")]
	public void SetIcon(IconType type)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x192CF28", Offset = "0x192CF28", VA = "0x192CF28")]
	private void SetSuccessIcon()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x192CE6C", Offset = "0x192CE6C", VA = "0x192CE6C")]
	private void SetCallIcon()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x192CDB0", Offset = "0x192CDB0", VA = "0x192CDB0")]
	private void SetMissIcon()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x192CA48", Offset = "0x192CA48", VA = "0x192CA48")]
	public void SetNormalIcon()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x192CFE4", Offset = "0x192CFE4", VA = "0x192CFE4")]
	public WristWatch()
	{
	}
}
[Token(Token = "0x200007A")]
public class LeaderboardManager : SingletonMonoBehaviour<LeaderboardManager>
{
	[Serializable]
	[Token(Token = "0x200019A")]
	public struct LeaderboardItem
	{
		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int rank;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int value;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool isMe;
	}

	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF48", Offset = "0x9BEF48")]
	private sealed class <LoadMyBestScoreRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LeaderboardManager <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1D5A634", Offset = "0x1D5A634", VA = "0x1D5A634", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1D5A69C", Offset = "0x1D5A69C", VA = "0x1D5A69C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1D59B28", Offset = "0x1D59B28", VA = "0x1D59B28")]
		[DebuggerHidden]
		public <LoadMyBestScoreRoutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1D5A568", Offset = "0x1D5A568", VA = "0x1D5A568", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1D5A56C", Offset = "0x1D5A56C", VA = "0x1D5A56C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1D5A63C", Offset = "0x1D5A63C", VA = "0x1D5A63C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C14CC", Offset = "0x9C14CC")]
	public ObscuredBool isMyBestScoreLoaded;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ObscuredInt myBestScore;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public ObscuredInt myLongestPlayTime;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1504", Offset = "0x9C1504")]
	public bool isRequestingTopBoard;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool isRequestingAroundBoard;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<LeaderboardItem> globalLeaderboardList;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<LeaderboardItem> aroundLeaderboardList;

	[Token(Token = "0x4000273")]
	private const int MAX_RESULT_COUNT = 10;

	[Token(Token = "0x4000274")]
	public const string STATS_BEST_SCORE = "BestScore";

	[Token(Token = "0x4000275")]
	public const string STATS_LONGEST_PLAYTIME = "LongestPlayTime";

	[Token(Token = "0x4000276")]
	public const string STATS_TOTAL_PLAY_COUNT = "PlayCount_TimeLimit";

	[Token(Token = "0x4000277")]
	public const string STATS_TOTAL_PLAY_COUNT_SHOP_MANAGE = "PlayCount_ShopManage";

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x1D59A70", Offset = "0x1D59A70", VA = "0x1D59A70")]
	public void LoadMyBestScore(float delay = 0f)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1D59A9C", Offset = "0x1D59A9C", VA = "0x1D59A9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7838", Offset = "0x9C7838")]
	private IEnumerator LoadMyBestScoreRoutine(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1D466F4", Offset = "0x1D466F4", VA = "0x1D466F4")]
	public void GetTopLeaderboard(string statsName)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1D59B54", Offset = "0x1D59B54", VA = "0x1D59B54")]
	private void OnGetTopLeaderboard(GetLeaderboardResult result)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1D468C4", Offset = "0x1D468C4", VA = "0x1D468C4")]
	public void GetAroundLeaderboard(string statsName)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1D59D78", Offset = "0x1D59D78", VA = "0x1D59D78")]
	private void OnGetLeaderboardAroundPlayer(GetLeaderboardAroundPlayerResult result)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1D59F9C", Offset = "0x1D59F9C", VA = "0x1D59F9C")]
	public void GetMyBestScore()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1D5A150", Offset = "0x1D5A150", VA = "0x1D5A150")]
	private void OnGetMyBestScore(GetLeaderboardAroundPlayerResult result)
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1D5A204", Offset = "0x1D5A204", VA = "0x1D5A204")]
	public void GetMyLongestPlayTime()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1D5A3B8", Offset = "0x1D5A3B8", VA = "0x1D5A3B8")]
	private void OnGetMyLongestPlayTime(GetLeaderboardAroundPlayerResult result)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1D5A458", Offset = "0x1D5A458", VA = "0x1D5A458")]
	private void OnError(PlayFabError error)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1D5A518", Offset = "0x1D5A518", VA = "0x1D5A518")]
	public LeaderboardManager()
	{
	}
}
[Token(Token = "0x200007B")]
public class PlayfabDataManager : SingletonMonoBehaviour<PlayfabDataManager>
{
	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C153C", Offset = "0x9C153C")]
	public bool isUpdating;

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xDC60F4", Offset = "0xDC60F4", VA = "0xDC60F4")]
	public void UpdateUserPlayData(bool isShopManageMode)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xDC63CC", Offset = "0xDC63CC", VA = "0xDC63CC")]
	private void OnUpdateUserData(UpdateUserDataResult result)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xDC63D4", Offset = "0xDC63D4", VA = "0xDC63D4")]
	private void OnError(PlayFabError error)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xDC6494", Offset = "0xDC6494", VA = "0xDC6494")]
	public PlayfabDataManager()
	{
	}
}
[Token(Token = "0x200007C")]
public class PlayfabManager : SingletonMonoBehaviour<PlayfabManager>
{
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF58", Offset = "0x9BEF58")]
	private sealed class <Start>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayfabManager <>4__this;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xDC70CC", Offset = "0xDC70CC", VA = "0xDC70CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xDC7134", Offset = "0xDC7134", VA = "0xDC7134", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xDC66C8", Offset = "0xDC66C8", VA = "0xDC66C8")]
		[DebuggerHidden]
		public <Start>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDC7018", Offset = "0xDC7018", VA = "0xDC7018", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xDC701C", Offset = "0xDC701C", VA = "0xDC701C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xDC70D4", Offset = "0xDC70D4", VA = "0xDC70D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF68", Offset = "0x9BEF68")]
	private sealed class <LoginOrRegisterRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayfabManager <>4__this;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0xDC6FA8", Offset = "0xDC6FA8", VA = "0xDC6FA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0xDC7010", Offset = "0xDC7010", VA = "0xDC7010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xDC6770", Offset = "0xDC6770", VA = "0xDC6770")]
		[DebuggerHidden]
		public <LoginOrRegisterRoutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xDC6ED8", Offset = "0xDC6ED8", VA = "0xDC6ED8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xDC6EDC", Offset = "0xDC6EDC", VA = "0xDC6EDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xDC6FB0", Offset = "0xDC6FB0", VA = "0xDC6FB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1574", Offset = "0x9C1574")]
	public ObscuredString playfabId;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string displayName;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredString sessionTicket;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isDisplayNameLoaded;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool isError;

	[Token(Token = "0x14000001")]
	public static event LoggedInEventHandler LoggedIn
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xDC64E4", Offset = "0xDC64E4", VA = "0xDC64E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C789C", Offset = "0x9C789C")]
		add
		{
		}
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xDC6598", Offset = "0xDC6598", VA = "0xDC6598")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C78AC", Offset = "0x9C78AC")]
		remove
		{
		}
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xDC664C", Offset = "0xDC664C", VA = "0xDC664C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C78BC", Offset = "0x9C78BC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xDC66F4", Offset = "0xDC66F4", VA = "0xDC66F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7920", Offset = "0x9C7920")]
	private IEnumerator LoginOrRegisterRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xDC679C", Offset = "0xDC679C", VA = "0xDC679C")]
	private void RunLogin()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xDC698C", Offset = "0xDC698C", VA = "0xDC698C")]
	private void OnLoginOrRegisterResult(LoginResult result)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xDC6AA4", Offset = "0xDC6AA4", VA = "0xDC6AA4")]
	public void GetDisplayNameOnServer()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xDC6BA8", Offset = "0xDC6BA8", VA = "0xDC6BA8")]
	private void OnGetAccountInfoResult(GetAccountInfoResult result)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xDC6C80", Offset = "0xDC6C80", VA = "0xDC6C80")]
	private void ChangeDisplayName(string name)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xDC6DA0", Offset = "0xDC6DA0", VA = "0xDC6DA0")]
	private void OnUpdateUserTitleDisplayName(UpdateUserTitleDisplayNameResult result)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xDC6DBC", Offset = "0xDC6DBC", VA = "0xDC6DBC")]
	private void OnError(PlayFabError error)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xDC6E88", Offset = "0xDC6E88", VA = "0xDC6E88")]
	public PlayfabManager()
	{
	}
}
[Token(Token = "0x200007D")]
public delegate void LoggedInEventHandler(string value);
[Token(Token = "0x200007E")]
public class PlayfabStatsManager : SingletonMonoBehaviour<PlayfabStatsManager>
{
	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C15BC", Offset = "0x9C15BC")]
	public bool isUpdating;

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xDC713C", Offset = "0xDC713C", VA = "0xDC713C")]
	public void UpdateScoreTest()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xDC7560", Offset = "0xDC7560", VA = "0xDC7560")]
	public void UpdateMyScoreToPlayfab()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xDC7374", Offset = "0xDC7374", VA = "0xDC7374")]
	public void UpdatePlayerStats(List<StatisticUpdate> itemList)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xDC7858", Offset = "0xDC7858", VA = "0xDC7858")]
	private void OnUpdatePlayerStats(UpdatePlayerStatisticsResult result)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xDC7860", Offset = "0xDC7860", VA = "0xDC7860")]
	private void OnError(PlayFabError error)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xDC7920", Offset = "0xDC7920", VA = "0xDC7920")]
	public PlayfabStatsManager()
	{
	}
}
[Token(Token = "0x200007F")]
public static class SaveDataBridge
{
	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float seVolume;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float musicVolume;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float heightOffset;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool isTutorialCompleted;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static bool isTutorialCompleteControl;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public static bool isTutorialCompleteOrder;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public static bool isTutorialCompleteCook;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool isTutorialCompleteCookRamen;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool isTutorialCompleteCookSide;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public static bool isTutorialCompleteCookRefill;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public static bool isTutorialCompleteWash;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static ObscuredInt totalPlayCount;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static ObscuredInt totalPlayCountShopManageMode;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static ObscuredInt totalMoney;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static ObscuredInt hallExtendLevel;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public static ObscuredInt riceCookerLevel;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static ObscuredInt beerServerLevel;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static ObscuredBool[] unlockStaffs;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static ObscuredInt[] staffExps;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static ObscuredBool[] unlockCostumes;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static AssignStaffItem[] assignStaffs;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static bool isInitialized;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	public static bool isPrefLoaded;

	[Token(Token = "0x4000297")]
	private const string PREF_TOTAL_PLAY_COUNT = "TotalPlayCount";

	[Token(Token = "0x4000298")]
	private const string PREF_TOTAL_PLAY_COUNT_SHOP_MANAGE_MODE = "TotalPlayCountShopManageMode";

	[Token(Token = "0x4000299")]
	private const string PREF_TUTORIAL_COMPLETED = "TutorialPlayed";

	[Token(Token = "0x400029A")]
	private const string PREF_TOTAL_MONEY = "OperatingFunds";

	[Token(Token = "0x400029B")]
	private const string PREF_SHOP_EXTEND = "ShopExtend";

	[Token(Token = "0x400029C")]
	private const string PREF_RICE_COOKER_LEVEL = "RiceCookerLevel";

	[Token(Token = "0x400029D")]
	private const string PREF_BEER_SERVER_LEVEL = "BeerServerLevel";

	[Token(Token = "0x400029E")]
	private const string PREF_SE_VOLUME = "SeVolume";

	[Token(Token = "0x400029F")]
	private const string PREF_MUSIC_VOLUME = "MusicVolume";

	[Token(Token = "0x40002A0")]
	private const string PREF_HEIGHT_OFFSET = "HeightOffset";

	[Token(Token = "0x40002A1")]
	private const string PREF_UNLOCK_STAFF_PREFIX = "StaffUnlock_";

	[Token(Token = "0x40002A2")]
	private const string PREF_STAFF_EXP_PREFIX = "StaffExp_";

	[Token(Token = "0x40002A3")]
	private const string PREF_UNLOCK_COSTUME_PREFIX = "UnlockCostume_";

	[Token(Token = "0x40002A4")]
	private const string PREF_ASSIGN_STAFF_TYPE_PREFIX = "AssignStaffType_";

	[Token(Token = "0x40002A5")]
	private const string PREF_ASSIGN_STAFF_COSTUME_PREFIX = "AssignStaffCostume_";

	[Token(Token = "0x40002A6")]
	private const string PREF_ASSIGN_STAFF_TAKE_ORDER_PREFIX = "AssignStaffTakeOrder_";

	[Token(Token = "0x40002A7")]
	private const string PREF_ASSIGN_STAFF_PREPARE_SIDEMENU_PREFIX = "AssignStaffSideMenu_";

	[Token(Token = "0x40002A8")]
	private const string PREF_ASSIGN_STAFF_SERVING_DISH_PREFIX = "AssignStaffServingDish_";

	[Token(Token = "0x40002A9")]
	private const string PREF_ASSIGN_STAFF_WASH_DISH_PREFIX = "AssignStaffWashDish_";

	[Token(Token = "0x40002AA")]
	private const string PREF_ASSIGN_STAFF_CHEERING_PREFIX = "AssignStaffCheering_";

	[Token(Token = "0x40002AB")]
	private const string PREF_TUTORIAL_COMPLETE_CONTROL = "TutorialComplete_Control";

	[Token(Token = "0x40002AC")]
	private const string PREF_TUTORIAL_COMPLETE_ORDER = "TutorialComplete_Order";

	[Token(Token = "0x40002AD")]
	private const string PREF_TUTORIAL_COMPLETE_COOK = "TutorialComplete_Cook";

	[Token(Token = "0x40002AE")]
	private const string PREF_TUTORIAL_COMPLETE_COOK_RAMEN = "TutorialComplete_CookRamen";

	[Token(Token = "0x40002AF")]
	private const string PREF_TUTORIAL_COMPLETE_COOK_SIDE = "TutorialComplete_CookSide";

	[Token(Token = "0x40002B0")]
	private const string PREF_TUTORIAL_COMPLETE_COOK_REFILL = "TutorialComplete_CookRefill";

	[Token(Token = "0x40002B1")]
	private const string PREF_TUTORIAL_COMPLETE_WASH = "TutorialComplete_Wash";

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xD03344", Offset = "0xD03344", VA = "0xD03344")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xD035A4", Offset = "0xD035A4", VA = "0xD035A4")]
	public static void LoadData()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xD03E80", Offset = "0xD03E80", VA = "0xD03E80")]
	public static void SaveData()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xD04864", Offset = "0xD04864", VA = "0xD04864")]
	public static void DeleteSaveData()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xD05374", Offset = "0xD05374", VA = "0xD05374")]
	public static void AddTotalMoney(ObscuredInt value)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xD054BC", Offset = "0xD054BC", VA = "0xD054BC")]
	public static void AddTotalPlayCount()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xD05548", Offset = "0xD05548", VA = "0xD05548")]
	public static void AddTotalPlayCountShopManageMode()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xD055D4", Offset = "0xD055D4", VA = "0xD055D4")]
	public static void ExtendHall(bool isShrink)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xD0569C", Offset = "0xD0569C", VA = "0xD0569C")]
	public static void LevelUpRiceCooker()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xD05734", Offset = "0xD05734", VA = "0xD05734")]
	public static void LevelUpBeerServer()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xD057CC", Offset = "0xD057CC", VA = "0xD057CC")]
	public static void HireStaff(ObscuredInt typeNum)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xD05888", Offset = "0xD05888", VA = "0xD05888")]
	public static void AddStaffExp(ObscuredInt staffType, ObscuredInt value)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xD01C58", Offset = "0xD01C58", VA = "0xD01C58")]
	public static int GetAssignStaffCount()
	{
		return default(int);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xD05A30", Offset = "0xD05A30", VA = "0xD05A30")]
	public static ObscuredInt GetStaffExp(ObscuredInt staffType)
	{
		return default(ObscuredInt);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD05AEC", Offset = "0xD05AEC", VA = "0xD05AEC")]
	public static void UnlockCostume(ObscuredInt costumeNum)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xD05BA8", Offset = "0xD05BA8", VA = "0xD05BA8")]
	public static void SetAssignStaff(ObscuredInt posNum, ObscuredInt typeNum)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xD05C74", Offset = "0xD05C74", VA = "0xD05C74")]
	public static void UnsetAssignStaff(ObscuredInt posNum)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xD05D38", Offset = "0xD05D38", VA = "0xD05D38")]
	public static void SetStaffCostume(ObscuredInt posNum, ObscuredInt costumeNum)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xD05E04", Offset = "0xD05E04", VA = "0xD05E04")]
	public static void SetTutorialCompleted()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xD05E8C", Offset = "0xD05E8C", VA = "0xD05E8C")]
	public static void SetSeVolume(float value)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xD05EE8", Offset = "0xD05EE8", VA = "0xD05EE8")]
	public static void SetMusicVolume(float value)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xD05F44", Offset = "0xD05F44", VA = "0xD05F44")]
	public static void SetHeightOffset(float value)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xD05FA0", Offset = "0xD05FA0", VA = "0xD05FA0")]
	public static void SaveSettings()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xD0606C", Offset = "0xD0606C", VA = "0xD0606C")]
	public static void LoadSettings()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xD0613C", Offset = "0xD0613C", VA = "0xD0613C")]
	public static void SaveTutorialState()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xD06284", Offset = "0xD06284", VA = "0xD06284")]
	public static void LoadTutorialState()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xD06400", Offset = "0xD06400", VA = "0xD06400")]
	public static void SetTutorialComplete(TutorialManager.Page category)
	{
	}
}
[Token(Token = "0x2000080")]
public class CharaProfileData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200019E")]
	public class Item
	{
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name_ja;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name_en;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name_cn;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xEC4168", Offset = "0xEC4168", VA = "0xEC4168")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] items;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xEC4160", Offset = "0xEC4160", VA = "0xEC4160")]
	public CharaProfileData()
	{
	}
}
[Token(Token = "0x2000081")]
public class CostumeNameData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200019F")]
	public class Item
	{
		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name_ja;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name_en;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name_cn;

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xEC5578", Offset = "0xEC5578", VA = "0xEC5578")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] items;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xEC5570", Offset = "0xEC5570", VA = "0xEC5570")]
	public CostumeNameData()
	{
	}
}
[Token(Token = "0x2000082")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9BEB14", Offset = "0x9BEB14")]
public class StaffExpTableData : ScriptableObject
{
	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ObscuredInt[] totalExp;

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xD10330", Offset = "0xD10330", VA = "0xD10330")]
	public StaffExpTableData()
	{
	}
}
[Token(Token = "0x2000083")]
public class StaffStatusData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20001A0")]
	public class Item
	{
		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string nameJa;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string nameEn;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string nameCn;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int hireCost;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int hourlyCost;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int technic;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int initSpeed;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int initStamina;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int maxSpeed;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int maxStamina;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xD348F4", Offset = "0xD348F4", VA = "0xD348F4")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] items;

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xD348EC", Offset = "0xD348EC", VA = "0xD348EC")]
	public StaffStatusData()
	{
	}
}
[Token(Token = "0x2000084")]
public class TipsLocalizeData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20001A1")]
	public class Item
	{
		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string title_ja;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string text_ja;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string title_en;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string text_en;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string title_cn;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string text_cn;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xD3DBE4", Offset = "0xD3DBE4", VA = "0xD3DBE4")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] items;

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xD3DBDC", Offset = "0xD3DBDC", VA = "0xD3DBDC")]
	public TipsLocalizeData()
	{
	}
}
[Token(Token = "0x2000085")]
public class UiLocalizeData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20001A2")]
	public class Item
	{
		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ja;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string en;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string cn;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1923FA0", Offset = "0x1923FA0", VA = "0x1923FA0")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] items;

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1923F98", Offset = "0x1923F98", VA = "0x1923F98")]
	public UiLocalizeData()
	{
	}
}
[Token(Token = "0x2000086")]
public class AssignStaffButton : UiItemBase
{
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C15F4", Offset = "0x9C15F4")]
	[SerializeField]
	private StaffManager.StaffType staffType;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image faceImage;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject checkMark;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color enableFaceColor;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color disableFaceColor;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private DialogAssignStaff dialogAssignStaff;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Collider col;

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xEB9F08", Offset = "0xEB9F08", VA = "0xEB9F08")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7984", Offset = "0x9C7984")]
	private void AutoDetect()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xEBA010", Offset = "0xEBA010", VA = "0xEBA010")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xEBA300", Offset = "0xEBA300", VA = "0xEBA300", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xEBA404", Offset = "0xEBA404", VA = "0xEBA404", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xEBAA40", Offset = "0xEBAA40", VA = "0xEBAA40")]
	public AssignStaffButton()
	{
	}
}
[Token(Token = "0x2000087")]
public class AssignStaffInfo : MonoBehaviour
{
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1690", Offset = "0x9C1690")]
	[SerializeField]
	private int posNum;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image profileImage;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text levelText;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text costText;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text speedText;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text staminaText;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text technicText;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ProgressBar expBar;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject takeOrderObj;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject sideMenuObj;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject washDishObj;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject servingObj;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject cheeringObj;

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xEBAA48", Offset = "0xEBAA48", VA = "0xEBAA48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xEBAA4C", Offset = "0xEBAA4C", VA = "0xEBAA4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xEBB228", Offset = "0xEBB228", VA = "0xEBB228")]
	public void SetPosNum(int num)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xEBB230", Offset = "0xEBB230", VA = "0xEBB230")]
	public AssignStaffInfo()
	{
	}
}
[Token(Token = "0x2000088")]
public class BeerServerFacility : SingletonMonoBehaviour<BeerServerFacility>
{
	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C17AC", Offset = "0x9C17AC")]
	[SerializeField]
	private GameObject enabledObj;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject disableObj;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject serverHandleForStaff;

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xEBCB1C", Offset = "0xEBCB1C", VA = "0xEBCB1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xEBCC0C", Offset = "0xEBCC0C", VA = "0xEBCC0C")]
	public void SetLevel(ObscuredInt level)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xEBCC98", Offset = "0xEBCC98", VA = "0xEBCC98")]
	public BeerServerFacility()
	{
	}
}
[Token(Token = "0x2000089")]
public class BuyCostumeButton : UiItemBase
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1808", Offset = "0x9C1808")]
	[SerializeField]
	private StaffManager.CostumeType cosType;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float nextEnableTime;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float enableDelay;

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xEBE9BC", Offset = "0xEBE9BC", VA = "0xEBE9BC", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xEBEA9C", Offset = "0xEBEA9C", VA = "0xEBEA9C")]
	public BuyCostumeButton()
	{
	}
}
[Token(Token = "0x200008A")]
public class BuyCostumeListItem : MonoBehaviour
{
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1854", Offset = "0x9C1854")]
	[SerializeField]
	private StaffManager.CostumeType cosType;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image cosImage;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text cosNameText;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text priceText;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image buttonImage;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Collider buttonCollider;

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xEBEAAC", Offset = "0xEBEAAC", VA = "0xEBEAAC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C79BC", Offset = "0x9C79BC")]
	private void AutoDetect()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xEBEBB4", Offset = "0xEBEBB4", VA = "0xEBEBB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xEBEC74", Offset = "0xEBEC74", VA = "0xEBEC74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xEBEEC0", Offset = "0xEBEEC0", VA = "0xEBEEC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xEBF0A0", Offset = "0xEBF0A0", VA = "0xEBF0A0")]
	public BuyCostumeListItem()
	{
	}
}
[Token(Token = "0x200008B")]
public class ChairCountText : MonoBehaviour
{
	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text text;

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xEC09FC", Offset = "0xEC09FC", VA = "0xEC09FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xEC0A5C", Offset = "0xEC0A5C", VA = "0xEC0A5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xEC0B0C", Offset = "0xEC0B0C", VA = "0xEC0B0C")]
	public ChairCountText()
	{
	}
}
[Token(Token = "0x200008C")]
public class ChangeCostumeButton : UiItemBase
{
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C18D0", Offset = "0x9C18D0")]
	[SerializeField]
	private StaffManager.CostumeType cosType;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image cosImage;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject checkMark;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color enableCosColor;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color disableCosColor;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private DialogChangeCostume dialogChangeCostume;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Collider col;

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xEC37B0", Offset = "0xEC37B0", VA = "0xEC37B0")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C79F4", Offset = "0x9C79F4")]
	private void AutoDetect()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xEC38B8", Offset = "0xEC38B8", VA = "0xEC38B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xEC3B2C", Offset = "0xEC3B2C", VA = "0xEC3B2C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xEC3C30", Offset = "0xEC3C30", VA = "0xEC3C30", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xEC3DB0", Offset = "0xEC3DB0", VA = "0xEC3DB0")]
	public ChangeCostumeButton()
	{
	}
}
[Token(Token = "0x200008D")]
public class DialogAssignStaff : MonoBehaviour
{
	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C196C", Offset = "0x9C196C")]
	public int staffPosNum;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1D49344", Offset = "0x1D49344", VA = "0x1D49344")]
	public void SetStaffPosNum(int num)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1D4934C", Offset = "0x1D4934C", VA = "0x1D4934C")]
	public DialogAssignStaff()
	{
	}
}
[Token(Token = "0x200008E")]
public class DialogBuyCostume : MonoBehaviour
{
	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C19A4", Offset = "0x9C19A4")]
	public bool isYes;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C19DC", Offset = "0x9C19DC")]
	[SerializeField]
	private Text priceText;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image cosImage;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text cosNameText;

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1D49354", Offset = "0x1D49354", VA = "0x1D49354")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1D4935C", Offset = "0x1D4935C", VA = "0x1D4935C")]
	public void SetState(bool yes)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1D49368", Offset = "0x1D49368", VA = "0x1D49368")]
	public void SetInfo(StaffManager.CostumeType cosType)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1D49550", Offset = "0x1D49550", VA = "0x1D49550")]
	public DialogBuyCostume()
	{
	}
}
[Token(Token = "0x200008F")]
public class DialogChangeCostume : MonoBehaviour
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1A48", Offset = "0x9C1A48")]
	public int staffPosNum;

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1D49558", Offset = "0x1D49558", VA = "0x1D49558")]
	public void SetStaffPosNum(int num)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1D49560", Offset = "0x1D49560", VA = "0x1D49560")]
	public DialogChangeCostume()
	{
	}
}
[Token(Token = "0x2000090")]
public class DialogCloseButton : UiItemBase
{
	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1A80", Offset = "0x9C1A80")]
	[SerializeField]
	private GameObject dialogRootObj;

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1D49568", Offset = "0x1D49568", VA = "0x1D49568", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1D49620", Offset = "0x1D49620", VA = "0x1D49620")]
	public DialogCloseButton()
	{
	}
}
[Token(Token = "0x2000091")]
public class DialogHireStaff : MonoBehaviour
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1ACC", Offset = "0x9C1ACC")]
	public bool isYes;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public StaffManager.StaffType staffType;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1B04", Offset = "0x9C1B04")]
	[SerializeField]
	private Image staffIcon;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text hourlyCostText;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text speedText;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text staminaText;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text technicText;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text hireCostText;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Collider[] buttonCols;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1D49628", Offset = "0x1D49628", VA = "0x1D49628")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1D49630", Offset = "0x1D49630", VA = "0x1D49630")]
	private void Update()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1D49730", Offset = "0x1D49730", VA = "0x1D49730")]
	public void SetState(bool yes)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1D4973C", Offset = "0x1D4973C", VA = "0x1D4973C")]
	public void SetStatus(StaffManager.StaffType type)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1D499BC", Offset = "0x1D499BC", VA = "0x1D499BC")]
	public DialogHireStaff()
	{
	}
}
[Token(Token = "0x2000092")]
public class DialogLevelup : MonoBehaviour
{
	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1BC0", Offset = "0x9C1BC0")]
	public bool isYes;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1BF8", Offset = "0x9C1BF8")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text levelUpText;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text levelDownText;

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1D499C4", Offset = "0x1D499C4", VA = "0x1D499C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1D499CC", Offset = "0x1D499CC", VA = "0x1D499CC")]
	public void SetState(bool yes)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1D499D8", Offset = "0x1D499D8", VA = "0x1D499D8")]
	public void SetCost(string value)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1D499FC", Offset = "0x1D499FC", VA = "0x1D499FC")]
	public void SetIsShrink(bool isShrink)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1D49A60", Offset = "0x1D49A60", VA = "0x1D49A60")]
	public DialogLevelup()
	{
	}
}
[Token(Token = "0x2000093")]
public class DialogRoleSetting : MonoBehaviour
{
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1C64", Offset = "0x9C1C64")]
	public int posNum;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ObscuredInt maxRoleCount;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredInt roleCountRemain;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1C9C", Offset = "0x9C1C9C")]
	[SerializeField]
	private Text remainText;

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1D49A68", Offset = "0x1D49A68", VA = "0x1D49A68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1D49BB0", Offset = "0x1D49BB0", VA = "0x1D49BB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1D49EE8", Offset = "0x1D49EE8", VA = "0x1D49EE8")]
	public void SetPosNum(int num)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1D49EF0", Offset = "0x1D49EF0", VA = "0x1D49EF0")]
	public DialogRoleSetting()
	{
	}
}
[Token(Token = "0x2000094")]
public class DialogStaffEdit : MonoBehaviour
{
	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1CE8", Offset = "0x9C1CE8")]
	public int posNum;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1D20", Offset = "0x9C1D20")]
	[SerializeField]
	private ShowDialogButton[] showDialogButtons;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Collider[] buttonCols;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x1D49EF8", Offset = "0x1D49EF8", VA = "0x1D49EF8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1D49F58", Offset = "0x1D49F58", VA = "0x1D49F58")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1D4A174", Offset = "0x1D4A174", VA = "0x1D4A174")]
	public DialogStaffEdit()
	{
	}
}
[Token(Token = "0x2000095")]
public class DialogYesButton : UiItemBase
{
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1D4A17C", Offset = "0x1D4A17C", VA = "0x1D4A17C", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1D4A580", Offset = "0x1D4A580", VA = "0x1D4A580")]
	public DialogYesButton()
	{
	}
}
[Token(Token = "0x2000096")]
public class FacilityInfo : MonoBehaviour
{
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1D7C", Offset = "0x9C1D7C")]
	[SerializeField]
	private Image beerServerImage;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image riceCookerImage;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite beerEnableSprite;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite beerDisableSprite;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite riceEnableSprite;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite riceDisableSprite;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text beerLevelText;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text riceLevelText;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text beerScoreText;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text riceScoreText;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text beerLevelupPriceText;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text riceLevelupPriceText;

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1D4D2A0", Offset = "0x1D4D2A0", VA = "0x1D4D2A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1D4DC8C", Offset = "0x1D4DC8C", VA = "0x1D4DC8C")]
	public FacilityInfo()
	{
	}
}
[Token(Token = "0x2000097")]
public class FacilityLevelUpButton : UiItemBase
{
	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1E78", Offset = "0x9C1E78")]
	[SerializeField]
	private bool isBeerServer;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Collider col;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Image buttonImage;

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x1D4DC94", Offset = "0x1D4DC94", VA = "0x1D4DC94", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x1D4DD24", Offset = "0x1D4DD24", VA = "0x1D4DD24", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x1D4DF98", Offset = "0x1D4DF98", VA = "0x1D4DF98", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x1D4E04C", Offset = "0x1D4E04C", VA = "0x1D4E04C")]
	public FacilityLevelUpButton()
	{
	}
}
[Token(Token = "0x2000098")]
public class HallExtendButton : UiItemBase
{
	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1EC4", Offset = "0x9C1EC4")]
	[SerializeField]
	private float nextEnableTime;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1F10", Offset = "0x9C1F10")]
	[SerializeField]
	private bool isShrinkButton;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Collider col;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Image buttonImage;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float enableDelay;

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1D5291C", Offset = "0x1D5291C", VA = "0x1D5291C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1D529AC", Offset = "0x1D529AC", VA = "0x1D529AC", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1D52C50", Offset = "0x1D52C50", VA = "0x1D52C50", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x1D52D30", Offset = "0x1D52D30", VA = "0x1D52D30")]
	public HallExtendButton()
	{
	}
}
[Token(Token = "0x2000099")]
public class HallExtendPriceText : MonoBehaviour
{
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1D52D40", Offset = "0x1D52D40", VA = "0x1D52D40")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x1D52F20", Offset = "0x1D52F20", VA = "0x1D52F20")]
	public HallExtendPriceText()
	{
	}
}
[Token(Token = "0x200009A")]
public class HallExtender : MonoBehaviour
{
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1F5C", Offset = "0x9C1F5C")]
	[SerializeField]
	private Transform wallStartPosTf;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform wallEndPosTf;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform wallTf;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int maxExlendLevel;

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1D52F28", Offset = "0x1D52F28", VA = "0x1D52F28")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1D5303C", Offset = "0x1D5303C", VA = "0x1D5303C")]
	public void SetExtendLevel(int extendLevel)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1D53148", Offset = "0x1D53148", VA = "0x1D53148")]
	public HallExtender()
	{
	}
}
[Token(Token = "0x200009B")]
public class HireStaffButton : UiItemBase
{
	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C1FD8", Offset = "0x9C1FD8")]
	[SerializeField]
	private StaffManager.StaffType staffType;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float nextEnableTime;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float enableDelay;

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1D53854", Offset = "0x1D53854", VA = "0x1D53854", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1D53934", Offset = "0x1D53934", VA = "0x1D53934")]
	public HireStaffButton()
	{
	}
}
[Token(Token = "0x200009C")]
public class HireStaffListItem : MonoBehaviour
{
	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2024", Offset = "0x9C2024")]
	[SerializeField]
	private StaffManager.StaffType staffType;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image faceImage;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text staffNameText;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text priceText;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image buttonImage;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Collider buttonCollider;

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x1D53944", Offset = "0x1D53944", VA = "0x1D53944")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7A2C", Offset = "0x9C7A2C")]
	private void AutoDetect()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x1D53A4C", Offset = "0x1D53A4C", VA = "0x1D53A4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x1D53B0C", Offset = "0x1D53B0C", VA = "0x1D53B0C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x1D53D04", Offset = "0x1D53D04", VA = "0x1D53D04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x1D53EE0", Offset = "0x1D53EE0", VA = "0x1D53EE0")]
	public HireStaffListItem()
	{
	}
}
[Token(Token = "0x200009D")]
public class RefurbishTabButton : UiItemBase
{
	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C20A0", Offset = "0x9C20A0")]
	[SerializeField]
	private bool isExtendButton;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[SerializeField]
	private bool isFacilityButton;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float nextEnableTime;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float enableDelay;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xCFF8DC", Offset = "0xCFF8DC", VA = "0xCFF8DC", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xCFFA9C", Offset = "0xCFFA9C", VA = "0xCFFA9C")]
	public RefurbishTabButton()
	{
	}
}
[Token(Token = "0x200009E")]
public class RiceCookerFacility : SingletonMonoBehaviour<RiceCookerFacility>
{
	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C20FC", Offset = "0x9C20FC")]
	[SerializeField]
	private GameObject enabledObj;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject disableObj;

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xD03008", Offset = "0xD03008", VA = "0xD03008")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xD030F8", Offset = "0xD030F8", VA = "0xD030F8")]
	public void SetLevel(ObscuredInt level)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xD03184", Offset = "0xD03184", VA = "0xD03184")]
	public RiceCookerFacility()
	{
	}
}
[Token(Token = "0x200009F")]
public class ShopManageChangePage : UiItemBase
{
	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ShopManager.Page page;

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xD084B8", Offset = "0xD084B8", VA = "0xD084B8", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xD085E0", Offset = "0xD085E0", VA = "0xD085E0")]
	public ShopManageChangePage()
	{
	}
}
[Token(Token = "0x20000A0")]
public class ShopManageOpen : UiItemBase
{
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xD085E8", Offset = "0xD085E8", VA = "0xD085E8", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xD08778", Offset = "0xD08778", VA = "0xD08778")]
	public ShopManageOpen()
	{
	}
}
[Token(Token = "0x20000A1")]
public class ShopManageRefurbish : MonoBehaviour
{
	[Token(Token = "0x20001A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF78", Offset = "0x9BEF78")]
	private sealed class <ExtendHallWaitDialogRoutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isShrink;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShopManageRefurbish <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xD09638", Offset = "0xD09638", VA = "0xD09638", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0xD096A0", Offset = "0xD096A0", VA = "0xD096A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xD08D90", Offset = "0xD08D90", VA = "0xD08D90")]
		[DebuggerHidden]
		public <ExtendHallWaitDialogRoutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xD090B8", Offset = "0xD090B8", VA = "0xD090B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xD090BC", Offset = "0xD090BC", VA = "0xD090BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xD09640", Offset = "0xD09640", VA = "0xD09640", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF88", Offset = "0x9BEF88")]
	private sealed class <LevelUpFacilityWaitDialogRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int price;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isBeer;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xD09A6C", Offset = "0xD09A6C", VA = "0xD09A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xD09AD4", Offset = "0xD09AD4", VA = "0xD09AD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD09084", Offset = "0xD09084", VA = "0xD09084")]
		[DebuggerHidden]
		public <LevelUpFacilityWaitDialogRoutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD096A8", Offset = "0xD096A8", VA = "0xD096A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xD096AC", Offset = "0xD096AC", VA = "0xD096AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xD09A74", Offset = "0xD09A74", VA = "0xD09A74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2168", Offset = "0x9C2168")]
	[SerializeField]
	private GameObject extensionObj;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject facilityObj;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C21C4", Offset = "0x9C21C4")]
	public Collider[] buttonCols;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredInt shrinkPrice;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ObscuredInt[] extendPrices;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ObscuredInt[] riceCookerUpgradePrices;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ObscuredInt[] beerServerUpgradePrices;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C21FC", Offset = "0x9C21FC")]
	[SerializeField]
	private Image[] sheetImages;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Sprite[] sheetEnableSprites;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite[] sheetDisableSprites;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private HallExtender hallExtender;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xD08780", Offset = "0xD08780", VA = "0xD08780")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xD087FC", Offset = "0xD087FC", VA = "0xD087FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xD0892C", Offset = "0xD0892C", VA = "0xD0892C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xD089B0", Offset = "0xD089B0", VA = "0xD089B0")]
	public bool IsShowDialog()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xD08AA0", Offset = "0xD08AA0", VA = "0xD08AA0")]
	public void ExtendHall(bool isShrink)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xD08D00", Offset = "0xD08D00", VA = "0xD08D00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7A64", Offset = "0x9C7A64")]
	private IEnumerator ExtendHallWaitDialogRoutine(bool isShrink)
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xD08DBC", Offset = "0xD08DBC", VA = "0xD08DBC")]
	public void LevelUpFacility(bool isBeer)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xD09000", Offset = "0xD09000", VA = "0xD09000")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7AC8", Offset = "0x9C7AC8")]
	private IEnumerator LevelUpFacilityWaitDialogRoutine(int price, bool isBeer)
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xD08820", Offset = "0xD08820", VA = "0xD08820")]
	private void SetSheetSprite()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xCFFA14", Offset = "0xCFFA14", VA = "0xCFFA14")]
	public void ShowExtendMenu()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xCFFA58", Offset = "0xCFFA58", VA = "0xCFFA58")]
	public void ShowFacilityMenu()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xD090B0", Offset = "0xD090B0", VA = "0xD090B0")]
	public ShopManageRefurbish()
	{
	}
}
[Token(Token = "0x20000A2")]
public class ShopManageStaffEdit : MonoBehaviour
{
	[Token(Token = "0x20001A5")]
	public enum Pages
	{
		[Token(Token = "0x4000996")]
		HireStaff,
		[Token(Token = "0x4000997")]
		StaffEdit,
		[Token(Token = "0x4000998")]
		BuyCustume
	}

	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF98", Offset = "0x9BEF98")]
	private sealed class <HireStaffWaitDialogRoutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffManager.StaffType staffType;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xD0A8A0", Offset = "0xD0A8A0", VA = "0xD0A8A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xD0A908", Offset = "0xD0A908", VA = "0xD0A908", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xD09DC8", Offset = "0xD09DC8", VA = "0xD09DC8")]
		[DebuggerHidden]
		public <HireStaffWaitDialogRoutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xD0A4A8", Offset = "0xD0A4A8", VA = "0xD0A4A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xD0A4AC", Offset = "0xD0A4AC", VA = "0xD0A4AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xD0A8A8", Offset = "0xD0A8A8", VA = "0xD0A8A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFA8", Offset = "0x9BEFA8")]
	private sealed class <BuyCostumeWaitDialogRoutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffManager.CostumeType cosType;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShopManageStaffEdit <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0xD0A438", Offset = "0xD0A438", VA = "0xD0A438", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xD0A4A0", Offset = "0xD0A4A0", VA = "0xD0A4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xD0A058", Offset = "0xD0A058", VA = "0xD0A058")]
		[DebuggerHidden]
		public <BuyCostumeWaitDialogRoutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xD0A08C", Offset = "0xD0A08C", VA = "0xD0A08C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xD0A090", Offset = "0xD0A090", VA = "0xD0A090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xD0A440", Offset = "0xD0A440", VA = "0xD0A440", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2268", Offset = "0x9C2268")]
	[SerializeField]
	private Pages currentPage;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C22B4", Offset = "0x9C22B4")]
	[SerializeField]
	private Collider[] buttonCols;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2300", Offset = "0x9C2300")]
	[SerializeField]
	private GameObject[] pageRootObjects;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C234C", Offset = "0x9C234C")]
	public ObscuredInt[] costumePrices;

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xD09ADC", Offset = "0xD09ADC", VA = "0xD09ADC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xD09B68", Offset = "0xD09B68", VA = "0xD09B68")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xD09BEC", Offset = "0xD09BEC", VA = "0xD09BEC")]
	public bool IsShowDialog()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xD09AE4", Offset = "0xD09AE4", VA = "0xD09AE4")]
	public void ShowPage(Pages page)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xD09D2C", Offset = "0xD09D2C", VA = "0xD09D2C")]
	public void HireStaff(StaffManager.StaffType staffType)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xD09D58", Offset = "0xD09D58", VA = "0xD09D58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7B2C", Offset = "0x9C7B2C")]
	private IEnumerator HireStaffWaitDialogRoutine(StaffManager.StaffType staffType)
	{
		return null;
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xD09DF4", Offset = "0xD09DF4", VA = "0xD09DF4")]
	public void BuyCostume(StaffManager.CostumeType cosType)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD09FCC", Offset = "0xD09FCC", VA = "0xD09FCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7B90", Offset = "0x9C7B90")]
	private IEnumerator BuyCostumeWaitDialogRoutine(StaffManager.CostumeType cosType)
	{
		return null;
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD0A084", Offset = "0xD0A084", VA = "0xD0A084")]
	public ShopManageStaffEdit()
	{
	}
}
[Token(Token = "0x20000A3")]
public class ShopManager : SingletonMonoBehaviour<ShopManager>
{
	[Token(Token = "0x20001A8")]
	public enum MachineType
	{
		[Token(Token = "0x40009A1")]
		NoodleCooker,
		[Token(Token = "0x40009A2")]
		BeerServer,
		[Token(Token = "0x40009A3")]
		RiceCooker
	}

	[Token(Token = "0x20001A9")]
	public enum Page
	{
		[Token(Token = "0x40009A5")]
		Main,
		[Token(Token = "0x40009A6")]
		Refurbish,
		[Token(Token = "0x40009A7")]
		Staff
	}

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2384", Offset = "0x9C2384")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] pages;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C23E0", Offset = "0x9C23E0")]
	public GameObject levelupDialog;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject hireDialog;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject buyCostumeDialog;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject alertDialog;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject assignStaffDialog;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject openTeamEditDialog;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject editStaffDialog;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject roleSettingDialog;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject costumeChangeDialog;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2418", Offset = "0x9C2418")]
	public ShopManageRefurbish refurbish;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ShopManageStaffEdit staffEdit;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isHiding;

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD0A910", Offset = "0xD0A910", VA = "0xD0A910")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD0AAD8", Offset = "0xD0AAD8", VA = "0xD0AAD8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD0AB68", Offset = "0xD0AB68", VA = "0xD0AB68")]
	private void SetHiding(bool isHide)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD08560", Offset = "0xD08560", VA = "0xD08560")]
	public void ShowPage(Page page)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xD0868C", Offset = "0xD0868C", VA = "0xD0868C")]
	public void OpenShop()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xD09560", Offset = "0xD09560", VA = "0xD09560")]
	public void ShowLevelupDialog(int cost, bool isShrink)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xD08CE0", Offset = "0xD08CE0", VA = "0xD08CE0")]
	public void ShowAlertDialog()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xD0A7D4", Offset = "0xD0A7D4", VA = "0xD0A7D4")]
	public void ShowHireDialog(StaffManager.StaffType staffType)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xD0A3B0", Offset = "0xD0A3B0", VA = "0xD0A3B0")]
	public void ShowBuyCostumeDialog(StaffManager.CostumeType cosType)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xD0AD54", Offset = "0xD0AD54", VA = "0xD0AD54")]
	public void ShowAssignStaffDialog(int posNum)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xD0ADD4", Offset = "0xD0ADD4", VA = "0xD0ADD4")]
	public void ShowEditStaffDialog(int posNum)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xD0AE74", Offset = "0xD0AE74", VA = "0xD0AE74")]
	public void ShowRoleSettingDialog(int posNum)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xD0AEF4", Offset = "0xD0AEF4", VA = "0xD0AEF4")]
	public void ShowUniformChangeDialog(int posNum)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xD0AF74", Offset = "0xD0AF74", VA = "0xD0AF74")]
	public void ShowOpenTeamEditDialog()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xD0AF94", Offset = "0xD0AF94", VA = "0xD0AF94")]
	public ShopManager()
	{
	}
}
[Token(Token = "0x20000A4")]
public class ShowDialogButton : UiItemBase
{
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2450", Offset = "0x9C2450")]
	[SerializeField]
	private int posNum;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private bool isAssignStaff;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	[SerializeField]
	private bool isStaffEdit;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	[SerializeField]
	private bool isRoleSetting;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
	[SerializeField]
	private bool isUniformChange;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float nextEnableTime;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float enableDelay;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xD0AFE4", Offset = "0xD0AFE4", VA = "0xD0AFE4")]
	public void SetPosNum(int num)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xD0AFEC", Offset = "0xD0AFEC", VA = "0xD0AFEC", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xD0B1C4", Offset = "0xD0B1C4", VA = "0xD0B1C4")]
	public ShowDialogButton()
	{
	}
}
[Token(Token = "0x20000A5")]
public class StaffEditTabButton : UiItemBase
{
	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C24DC", Offset = "0x9C24DC")]
	[SerializeField]
	private ShopManageStaffEdit.Pages page;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject dialogObj;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float nextEnableTime;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float enableDelay;

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xD101F8", Offset = "0xD101F8", VA = "0xD101F8", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xD10320", Offset = "0xD10320", VA = "0xD10320")]
	public StaffEditTabButton()
	{
	}
}
[Token(Token = "0x20000A6")]
public class StaffRoleToggle : UiItemBase
{
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2538", Offset = "0x9C2538")]
	[SerializeField]
	private bool isEnableRole;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2584", Offset = "0x9C2584")]
	[SerializeField]
	private bool isOrder;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	[SerializeField]
	private bool isSideMenu;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
	[SerializeField]
	private bool isWash;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private bool isServing;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	[SerializeField]
	private bool isCheering;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Color textEnableColor;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Color textDisableColor;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Color sliderEnableColor;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Color sliderDisableColor;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Vector3 sliderEnablePos;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private Vector3 sliderDisablePos;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Text text;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Image sliderImage;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private DialogRoleSetting dialogRoleSetting;

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xD153E8", Offset = "0xD153E8", VA = "0xD153E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xD15658", Offset = "0xD15658", VA = "0xD15658")]
	private void SetToggle(bool value)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xD15A34", Offset = "0xD15A34", VA = "0xD15A34", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xD15AC0", Offset = "0xD15AC0", VA = "0xD15AC0")]
	public StaffRoleToggle()
	{
	}
}
[Token(Token = "0x20000A7")]
public class StaffTeamInfo : MonoBehaviour
{
	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2670", Offset = "0x9C2670")]
	[SerializeField]
	private GameObject[] activeStaffUiObj;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] inactiveStaffUiObj;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Collider[] buttonCols;

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xD35844", Offset = "0xD35844", VA = "0xD35844")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xD35964", Offset = "0xD35964", VA = "0xD35964")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xD35C44", Offset = "0xD35C44", VA = "0xD35C44")]
	public StaffTeamInfo()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A8")]
public struct AssignStaffItem
{
	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ObscuredInt typeNum;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ObscuredInt costumeNum;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ObscuredBool takeOrder;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ObscuredBool prepareSideMenu;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ObscuredBool servingDish;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public ObscuredBool washDish;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ObscuredBool cheering;
}
[Token(Token = "0x20000A9")]
public class StaffBeerServerControl : MonoBehaviour
{
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xD0E350", Offset = "0xD0E350", VA = "0xD0E350")]
	public StaffBeerServerControl()
	{
	}
}
[Token(Token = "0x20000AA")]
public class StaffBothHandGrab : MonoBehaviour
{
	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFB8", Offset = "0x9BEFB8")]
	private sealed class <MoveHoldPosRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffBothHandGrab <>4__this;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform posTf;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 <startPos>5__3;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion <startRot>5__4;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xD0F3D0", Offset = "0xD0F3D0", VA = "0xD0F3D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0xD0F438", Offset = "0xD0F438", VA = "0xD0F438", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xD0EAB0", Offset = "0xD0EAB0", VA = "0xD0EAB0")]
		[DebuggerHidden]
		public <MoveHoldPosRoutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD0F0EC", Offset = "0xD0F0EC", VA = "0xD0F0EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xD0F0F0", Offset = "0xD0F0F0", VA = "0xD0F0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xD0F3D8", Offset = "0xD0F3D8", VA = "0xD0F3D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C26DC", Offset = "0x9C26DC")]
	[SerializeField]
	private bool isHoldEnd;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool isMovingPos;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InteractionObject bothHandTargetObj;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform holdPos;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float pickUpTime;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StaffMain staffMain;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private InteractionSystem interactionSystem;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 pickUpPos;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Quaternion pickUpRot;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float holdWeight;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float holdWeightVel;

	[Token(Token = "0x17000008")]
	private bool isHold
	{
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD0E73C", Offset = "0xD0E73C", VA = "0xD0E73C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	private bool isHoldLeft
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xD0EADC", Offset = "0xD0EADC", VA = "0xD0EADC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	private bool isHoldRight
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xD0EB94", Offset = "0xD0EB94", VA = "0xD0EB94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xD0E358", Offset = "0xD0E358", VA = "0xD0E358")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xD0E50C", Offset = "0xD0E50C", VA = "0xD0E50C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xD0E774", Offset = "0xD0E774", VA = "0xD0E774")]
	public void GrabBothHand(InteractionObject obj)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xD0E888", Offset = "0xD0E888", VA = "0xD0E888")]
	public void ResumeRightHand()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xD0E8A8", Offset = "0xD0E8A8", VA = "0xD0E8A8")]
	public void ResumeLeftHand()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xD0E8C8", Offset = "0xD0E8C8", VA = "0xD0E8C8")]
	public void ReleaseObject()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xD0E9DC", Offset = "0xD0E9DC", VA = "0xD0E9DC")]
	public void MoveHoldPos(Transform posTf, float duration)
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xD0EA08", Offset = "0xD0EA08", VA = "0xD0EA08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7BF4", Offset = "0x9C7BF4")]
	private IEnumerator MoveHoldPosRoutine(Transform posTf, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xD0EC4C", Offset = "0xD0EC4C", VA = "0xD0EC4C")]
	private void OnInteractionPause(FullBodyBipedEffector effectorType, InteractionObject interactionObj)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xD0ED90", Offset = "0xD0ED90", VA = "0xD0ED90")]
	private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObj)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xD0EF50", Offset = "0xD0EF50", VA = "0xD0EF50")]
	public void SetHoldEnd(bool value)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xD0EF5C", Offset = "0xD0EF5C", VA = "0xD0EF5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xD0F0D8", Offset = "0xD0F0D8", VA = "0xD0F0D8")]
	public StaffBothHandGrab()
	{
	}
}
[Token(Token = "0x20000AB")]
public class StaffCheering : MonoBehaviour
{
	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StaffMain.RoleType taskType;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private StaffMain staffMain;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float nextTypeChangeTime;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float typeChangeInterval;

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xD0F440", Offset = "0xD0F440", VA = "0xD0F440")]
	private void Start()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xD0F4D8", Offset = "0xD0F4D8", VA = "0xD0F4D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xD0F60C", Offset = "0xD0F60C", VA = "0xD0F60C")]
	private void ChangeAnimation()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xD0F708", Offset = "0xD0F708", VA = "0xD0F708")]
	public StaffCheering()
	{
	}
}
[Token(Token = "0x20000AC")]
public class StaffColliderCopy : MonoBehaviour
{
	[Token(Token = "0x600030F")]
	[Address(RVA = "0xD0F7E4", Offset = "0xD0F7E4", VA = "0xD0F7E4")]
	public StaffColliderCopy()
	{
	}
}
[Token(Token = "0x20000AD")]
public class StaffDamage : MonoBehaviour
{
	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFC8", Offset = "0x9BEFC8")]
	private sealed class <DamageRoutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffDamage <>4__this;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion <beforeRot>5__4;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <endRot>5__5;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion <startRot>5__6;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0xD10188", Offset = "0xD10188", VA = "0xD10188", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xD101F0", Offset = "0xD101F0", VA = "0xD101F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xD0FAE4", Offset = "0xD0FAE4", VA = "0xD0FAE4")]
		[DebuggerHidden]
		public <DamageRoutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xD0FB24", Offset = "0xD0FB24", VA = "0xD0FB24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xD0FB28", Offset = "0xD0FB28", VA = "0xD0FB28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xD10190", Offset = "0xD10190", VA = "0xD10190", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StaffMain staffMain;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private StaffState staffState;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float damageVelocity;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float nextDamageDelay;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float enableDamageTime;

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xD0F7EC", Offset = "0xD0F7EC", VA = "0xD0F7EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xD0F894", Offset = "0xD0F894", VA = "0xD0F894")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xD0FA68", Offset = "0xD0FA68", VA = "0xD0FA68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7C58", Offset = "0x9C7C58")]
	private IEnumerator DamageRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xD0FB10", Offset = "0xD0FB10", VA = "0xD0FB10")]
	public StaffDamage()
	{
	}
}
[Token(Token = "0x20000AE")]
public class StaffIkControl : MonoBehaviour
{
	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFD8", Offset = "0x9BEFD8")]
	private sealed class <SetHandTargetRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isRight;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StaffIkControl <>4__this;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform targetTf;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool withRotation;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xD112C0", Offset = "0xD112C0", VA = "0xD112C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xD11328", Offset = "0xD11328", VA = "0xD11328", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xD10F2C", Offset = "0xD10F2C", VA = "0xD10F2C")]
		[DebuggerHidden]
		public <SetHandTargetRoutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xD110A8", Offset = "0xD110A8", VA = "0xD110A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xD110AC", Offset = "0xD110AC", VA = "0xD110AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xD112C8", Offset = "0xD112C8", VA = "0xD112C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFE8", Offset = "0x9BEFE8")]
	private sealed class <SetWeightRoutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isRight;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StaffIkControl <>4__this;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool withRotation;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float value;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xD1156C", Offset = "0xD1156C", VA = "0xD1156C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xD115D4", Offset = "0xD115D4", VA = "0xD115D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD11074", Offset = "0xD11074", VA = "0xD11074")]
		[DebuggerHidden]
		public <SetWeightRoutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD11330", Offset = "0xD11330", VA = "0xD11330", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD11334", Offset = "0xD11334", VA = "0xD11334", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xD11574", Offset = "0xD11574", VA = "0xD11574", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationCurve animCurve;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform forwardPos;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform holdPos;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private InteractionSystem interactionSystem;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LookAtIK lookAtIk;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FullBodyBipedIK fullBodyIk;

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xD10C78", Offset = "0xD10C78", VA = "0xD10C78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xD10D8C", Offset = "0xD10D8C", VA = "0xD10D8C")]
	public void LookForward()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xD10DC0", Offset = "0xD10DC0", VA = "0xD10DC0")]
	public void LookHoldPos()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xD10DF4", Offset = "0xD10DF4", VA = "0xD10DF4")]
	public void SetHandTarget(bool isRight, Transform targetTf, float duration)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xD10EF4", Offset = "0xD10EF4", VA = "0xD10EF4")]
	public void SetHandTargetWithoutRotation(bool isRight, Transform targetTf, float duration)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xD10E2C", Offset = "0xD10E2C", VA = "0xD10E2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7CBC", Offset = "0x9C7CBC")]
	private IEnumerator SetHandTargetRoutine(bool isRight, bool withRotation, Transform targetTf, float duration)
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xD10F58", Offset = "0xD10F58", VA = "0xD10F58")]
	public void SetWeight(bool isRight, float value, float duration)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xD11040", Offset = "0xD11040", VA = "0xD11040")]
	public void SetWeightWithoutRotation(bool isRight, float value, float duration)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xD10F8C", Offset = "0xD10F8C", VA = "0xD10F8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7D20", Offset = "0x9C7D20")]
	private IEnumerator SetWeightRoutine(bool isRight, bool withRotation, float value, float duration)
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xD110A0", Offset = "0xD110A0", VA = "0xD110A0")]
	public StaffIkControl()
	{
	}
}
[Token(Token = "0x20000AF")]
public class StaffMain : MonoBehaviour
{
	[Token(Token = "0x20001AE")]
	public enum RoleType
	{
		[Token(Token = "0x40009C9")]
		None,
		[Token(Token = "0x40009CA")]
		TakeOrder,
		[Token(Token = "0x40009CB")]
		SideMenu,
		[Token(Token = "0x40009CC")]
		Wash,
		[Token(Token = "0x40009CD")]
		Serving,
		[Token(Token = "0x40009CE")]
		Cheering
	}

	[Token(Token = "0x20001AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEFF8", Offset = "0x9BEFF8")]
	private sealed class <MoveToStandbyPosRoutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffMain <>4__this;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion <startRot>5__2;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion <endRot>5__3;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <elapsedTime>5__4;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float <duration>5__5;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xD13D34", Offset = "0xD13D34", VA = "0xD13D34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xD13D9C", Offset = "0xD13D9C", VA = "0xD13D9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD13054", Offset = "0xD13054", VA = "0xD13054")]
		[DebuggerHidden]
		public <MoveToStandbyPosRoutine>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD13924", Offset = "0xD13924", VA = "0xD13924", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xD13928", Offset = "0xD13928", VA = "0xD13928", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD13D3C", Offset = "0xD13D3C", VA = "0xD13D3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF008", Offset = "0x9BF008")]
	private sealed class <ResetAnimatorTransformRoutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StaffMain <>4__this;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xD140E8", Offset = "0xD140E8", VA = "0xD140E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xD14150", Offset = "0xD14150", VA = "0xD14150", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD138A0", Offset = "0xD138A0", VA = "0xD138A0")]
		[DebuggerHidden]
		public <ResetAnimatorTransformRoutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xD13DA4", Offset = "0xD13DA4", VA = "0xD13DA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xD13DA8", Offset = "0xD13DA8", VA = "0xD13DA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xD140F0", Offset = "0xD140F0", VA = "0xD140F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2768", Offset = "0x9C2768")]
	public bool isWorking;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isStandby;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RoleType currentTask;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject grabObjLeft;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject grabObjRight;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredInt staffPosNum;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<RoleType> roleTypeList;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ToolTray[] toolTrays;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C27A0", Offset = "0x9C27A0")]
	public StaffManager.StaffType staffType;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool isTwoFinger;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Animator animator;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform holdPos;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform holdEndPos;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioSource audioSource;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private InteractionSystem interactionSystem;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private StaffWashDish staffWashDish;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private StaffServing staffServing;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private StaffTakeOrder staffTakeOrder;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private StaffSideDish staffSideDish;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public StaffState staffState;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Coroutine moveToStandbyPosRoutine;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ObscuredFloat nextCheckTime;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ObscuredFloat checkInterval;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float nextIdleAnimChangeTime;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float idleAnimationChangeTime;

	[Token(Token = "0x400039D")]
	private const string ANIM_SPEED = "Speed";

	[Token(Token = "0x400039E")]
	private const string ANIM_STANDBY = "Standby";

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xD115DC", Offset = "0xD115DC", VA = "0xD115DC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C7D84", Offset = "0x9C7D84")]
	private void AutoSetting()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xD119C8", Offset = "0xD119C8", VA = "0xD119C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xD12008", Offset = "0xD12008", VA = "0xD12008")]
	private void Update()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xD12AA0", Offset = "0xD12AA0", VA = "0xD12AA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xD12484", Offset = "0xD12484", VA = "0xD12484")]
	private void CheckIdleAnimation()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xD11BBC", Offset = "0xD11BBC", VA = "0xD11BBC")]
	public void SetRole()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xD12734", Offset = "0xD12734", VA = "0xD12734")]
	private void CheckTask()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xD12E78", Offset = "0xD12E78", VA = "0xD12E78")]
	public void EndTask()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xD125C4", Offset = "0xD125C4", VA = "0xD125C4")]
	private void RotateToForward()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xD12EFC", Offset = "0xD12EFC", VA = "0xD12EFC")]
	public void ResumeInteraction()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xD12F18", Offset = "0xD12F18", VA = "0xD12F18")]
	public void ResumeInteraction(bool isRight)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xD12F48", Offset = "0xD12F48", VA = "0xD12F48")]
	public void SetStaffPosNum(ObscuredInt num)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xD12F5C", Offset = "0xD12F5C", VA = "0xD12F5C")]
	public void MoveToPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xD12D88", Offset = "0xD12D88", VA = "0xD12D88")]
	public void MoveToStandbyPos()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xD12FD8", Offset = "0xD12FD8", VA = "0xD12FD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7DBC", Offset = "0x9C7DBC")]
	private IEnumerator MoveToStandbyPosRoutine()
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xD13080", Offset = "0xD13080", VA = "0xD13080")]
	public void Interaction(bool isRight, InteractionObject obj, bool interrupt)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xD130B4", Offset = "0xD130B4", VA = "0xD130B4")]
	public void Grab(FullBodyBipedEffector effector, InteractionObject obj, bool interrupt)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xD13258", Offset = "0xD13258", VA = "0xD13258")]
	public void Grab(bool isRight, InteractionObject obj, bool interrupt)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xD133EC", Offset = "0xD133EC", VA = "0xD133EC")]
	public void ReleaseRight(bool setEnableGrabbing = true)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xD134C8", Offset = "0xD134C8", VA = "0xD134C8")]
	public void ReleaseLeft(bool setEnableGrabbing = true)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xD135A4", Offset = "0xD135A4", VA = "0xD135A4")]
	public void ReleaseBothHand(bool setEnableGrabbing = true)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xD13708", Offset = "0xD13708", VA = "0xD13708")]
	public void ResetAnimatorTransform()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xD0F7B0", Offset = "0xD0F7B0", VA = "0xD0F7B0")]
	public void ResetAnimatorTransform(float duration)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xD13814", Offset = "0xD13814", VA = "0xD13814")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7E20", Offset = "0x9C7E20")]
	private IEnumerator ResetAnimatorTransformRoutine(float duration)
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xD138CC", Offset = "0xD138CC", VA = "0xD138CC")]
	public StaffMain()
	{
	}
}
[Token(Token = "0x20000B0")]
public class StaffManager : SingletonMonoBehaviour<StaffManager>
{
	[Token(Token = "0x20001B1")]
	public enum StaffType
	{
		[Token(Token = "0x40009DC")]
		Boy,
		[Token(Token = "0x40009DD")]
		Suits,
		[Token(Token = "0x40009DE")]
		OL,
		[Token(Token = "0x40009DF")]
		Drunk,
		[Token(Token = "0x40009E0")]
		Fat,
		[Token(Token = "0x40009E1")]
		Workman,
		[Token(Token = "0x40009E2")]
		Robot,
		[Token(Token = "0x40009E3")]
		Zuckerberg,
		[Token(Token = "0x40009E4")]
		CEO
	}

	[Token(Token = "0x20001B2")]
	public enum CostumeType
	{
		[Token(Token = "0x40009E6")]
		UniformRed,
		[Token(Token = "0x40009E7")]
		Ninja,
		[Token(Token = "0x40009E8")]
		Cube,
		[Token(Token = "0x40009E9")]
		Space,
		[Token(Token = "0x40009EA")]
		UniformBlack
	}

	[Serializable]
	[Token(Token = "0x20001B3")]
	public class StaffItem
	{
		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject[] staffPfs;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite[] profileSprites;

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xD153E0", Offset = "0xD153E0", VA = "0xD153E0")]
		public StaffItem()
		{
		}
	}

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C27E8", Offset = "0x9C27E8")]
	public GameObject[] assignedStaffs;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2820", Offset = "0x9C2820")]
	public Transform[] standbyPosTfs;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform washPosTf;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform trayBackPosTf;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform spongeSpawnPosTf;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public WashingHandPos washingHandPos;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform riceStandPosTf;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform riceBowlSpawnPosTf;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform shamojiSpawnPosTf;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform beerStandPosTf;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform beerMugSpawnPosTf;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform beerMugReadyPosTf;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public InteractionObject[] trayReleaseInteractionObj;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2858", Offset = "0x9C2858")]
	public StaffStatusData staffStatusData;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public CostumeNameData cosNameData;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public StaffExpTableData staffExpTableData;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public StaffItem[] staffItems;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ObscuredInt staffExpLimit;

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xD14158", Offset = "0xD14158", VA = "0xD14158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xD142CC", Offset = "0xD142CC", VA = "0xD142CC")]
	public void SetStaff()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xD146D4", Offset = "0xD146D4", VA = "0xD146D4")]
	public void AddExpToStaff(ObscuredInt exp)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xD14834", Offset = "0xD14834", VA = "0xD14834")]
	public void AddExpToStaffWithInitialize(ObscuredInt exp)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xD14994", Offset = "0xD14994", VA = "0xD14994")]
	public ObscuredInt GetStaffCost(ObscuredInt workHour)
	{
		return default(ObscuredInt);
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xD14B68", Offset = "0xD14B68", VA = "0xD14B68")]
	public ObscuredInt GetStaffHireCost(StaffType staffType)
	{
		return default(ObscuredInt);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xD14BB8", Offset = "0xD14BB8", VA = "0xD14BB8")]
	public bool IsSameTaskOnOtherStaff(int myPosNum)
	{
		return default(bool);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xD12BA4", Offset = "0xD12BA4", VA = "0xD12BA4")]
	public StaffMain.RoleType GetOtherStaffCurrentTask(int myPosNum)
	{
		return default(StaffMain.RoleType);
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xD0A85C", Offset = "0xD0A85C", VA = "0xD0A85C")]
	public StaffStatusData.Item GetStaffStatusData(StaffType staffType)
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xD02720", Offset = "0xD02720", VA = "0xD02720")]
	public string GetStaffName(StaffType staffType)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xD14CF8", Offset = "0xD14CF8", VA = "0xD14CF8")]
	public string GetCostumeName(CostumeType cosType)
	{
		return null;
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xD14ED0", Offset = "0xD14ED0", VA = "0xD14ED0")]
	public void ApplyRole(ObscuredInt posNum)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xD028F8", Offset = "0xD028F8", VA = "0xD028F8")]
	public ObscuredInt GetLvByExp(ObscuredInt exp)
	{
		return default(ObscuredInt);
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xD02A5C", Offset = "0xD02A5C", VA = "0xD02A5C")]
	public ObscuredFloat GetExpFillRate(float exp)
	{
		return default(ObscuredFloat);
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xD14F88", Offset = "0xD14F88", VA = "0xD14F88")]
	public ObscuredInt GetLvByStaffType(StaffType staffType)
	{
		return default(ObscuredInt);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xD15014", Offset = "0xD15014", VA = "0xD15014")]
	public ObscuredFloat GetSpeedByLevel(ObscuredInt level, StaffType staffType)
	{
		return default(ObscuredFloat);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xD151D8", Offset = "0xD151D8", VA = "0xD151D8")]
	public ObscuredInt GetStaminaByLevel(ObscuredInt level, StaffType staffType)
	{
		return default(ObscuredInt);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xD15390", Offset = "0xD15390", VA = "0xD15390")]
	public StaffManager()
	{
	}
}
[Token(Token = "0x20000B1")]
public class StaffServing : MonoBehaviour
{
	[Token(Token = "0x20001B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF018", Offset = "0x9BF018")]
	private sealed class <ServingRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffServing <>4__this;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <trayPos>5__2;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <duration>5__4;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion <startRot>5__5;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion <endRot>5__6;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ChairItem <chairItem>5__7;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 <startPos>5__8;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 <endPos>5__9;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int <i>5__10;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xD17968", Offset = "0xD17968", VA = "0xD17968", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xD179D0", Offset = "0xD179D0", VA = "0xD179D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xD15DFC", Offset = "0xD15DFC", VA = "0xD15DFC")]
		[DebuggerHidden]
		public <ServingRoutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xD16488", Offset = "0xD16488", VA = "0xD16488", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD1648C", Offset = "0xD1648C", VA = "0xD1648C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xD17970", Offset = "0xD17970", VA = "0xD17970", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF028", Offset = "0x9BF028")]
	private sealed class <ReturnTrayRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffServing <>4__this;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 trayPos;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <duration>5__3;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion <startRot>5__4;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion <endRot>5__5;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xD16418", Offset = "0xD16418", VA = "0xD16418", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xD16480", Offset = "0xD16480", VA = "0xD16480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xD15EC8", Offset = "0xD15EC8", VA = "0xD15EC8")]
		[DebuggerHidden]
		public <ReturnTrayRoutine>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xD15F0C", Offset = "0xD15F0C", VA = "0xD15F0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xD15F10", Offset = "0xD15F10", VA = "0xD15F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xD16420", Offset = "0xD16420", VA = "0xD16420", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2890", Offset = "0x9C2890")]
	[SerializeField]
	private ToolTray targetTray;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int serveChairNum;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool isServingStarted;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StaffMain.RoleType taskType;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StaffMain staffMain;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StaffState staffState;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private StaffIkControl staffIkControl;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private StaffBothHandGrab staffBothHandGrab;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float checkInterval;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float nextCheckTime;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Coroutine servingRoutine;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 trayInitPos;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Quaternion trayInitRot;

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xD15AC8", Offset = "0xD15AC8", VA = "0xD15AC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xD15BC4", Offset = "0xD15BC4", VA = "0xD15BC4")]
	private void Update()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xD15D24", Offset = "0xD15D24", VA = "0xD15D24")]
	private void StopTask()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xD12CA0", Offset = "0xD12CA0", VA = "0xD12CA0")]
	public bool CheckCompleteTray()
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xD15D80", Offset = "0xD15D80", VA = "0xD15D80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7E84", Offset = "0x9C7E84")]
	private IEnumerator ServingRoutine()
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xD15E28", Offset = "0xD15E28", VA = "0xD15E28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7EE8", Offset = "0x9C7EE8")]
	private IEnumerator ReturnTrayRoutine(Vector3 trayPos)
	{
		return null;
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xD15EF4", Offset = "0xD15EF4", VA = "0xD15EF4")]
	public StaffServing()
	{
	}
}
[Token(Token = "0x20000B2")]
public class StaffSideDish : MonoBehaviour
{
	[Token(Token = "0x20001B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF038", Offset = "0x9BF038")]
	private sealed class <MakeRiceRoutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffSideDish <>4__this;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion <startRot>5__4;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <endRot>5__5;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject <riceBowl>5__6;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ToolTray <targetTray>5__7;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xD33CA0", Offset = "0xD33CA0", VA = "0xD33CA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xD33D08", Offset = "0xD33D08", VA = "0xD33D08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xD319F8", Offset = "0xD319F8", VA = "0xD319F8")]
		[DebuggerHidden]
		public <MakeRiceRoutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xD32A64", Offset = "0xD32A64", VA = "0xD32A64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xD32A68", Offset = "0xD32A68", VA = "0xD32A68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xD33CA8", Offset = "0xD33CA8", VA = "0xD33CA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF048", Offset = "0x9BF048")]
	private sealed class <MakeBeerRoutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffSideDish <>4__this;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion <startRot>5__4;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <endRot>5__5;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject <beerMug>5__6;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float <forceEndTime>5__7;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ToolTray <targetTray>5__8;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xD329F4", Offset = "0xD329F4", VA = "0xD329F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xD32A5C", Offset = "0xD32A5C", VA = "0xD32A5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xD31A24", Offset = "0xD31A24", VA = "0xD31A24")]
		[DebuggerHidden]
		public <MakeBeerRoutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xD31A6C", Offset = "0xD31A6C", VA = "0xD31A6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xD31A70", Offset = "0xD31A70", VA = "0xD31A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xD329FC", Offset = "0xD329FC", VA = "0xD329FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C28FC", Offset = "0x9C28FC")]
	[SerializeField]
	private ObscuredBool isEnable;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject activeShamoji;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2958", Offset = "0x9C2958")]
	[SerializeField]
	private Transform putOnRiceIkPosTf;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StaffMain staffMain;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private StaffState staffState;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private StaffIkControl staffIkControl;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private InteractionObject beerServerInteractionObj;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isLastMakeRice;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float checkInterval;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float nextCheckTime;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float trayDistanceThreshold;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Coroutine makeDishRoutine;

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xD31680", Offset = "0xD31680", VA = "0xD31680")]
	private void Start()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xD317BC", Offset = "0xD317BC", VA = "0xD317BC")]
	public bool CheckNeedSideDish()
	{
		return default(bool);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xD31900", Offset = "0xD31900", VA = "0xD31900")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7F4C", Offset = "0x9C7F4C")]
	private IEnumerator MakeRiceRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xD3197C", Offset = "0xD3197C", VA = "0xD3197C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C7FB0", Offset = "0x9C7FB0")]
	private IEnumerator MakeBeerRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xD31A50", Offset = "0xD31A50", VA = "0xD31A50")]
	public StaffSideDish()
	{
	}
}
[Token(Token = "0x20000B3")]
public class StaffStaminaGauge : MonoBehaviour
{
	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C29A4", Offset = "0x9C29A4")]
	[SerializeField]
	private Text restTimeRemainText;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ProgressBar staminaGauge;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private StaffState staffState;

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xD33D10", Offset = "0xD33D10", VA = "0xD33D10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xD33D8C", Offset = "0xD33D8C", VA = "0xD33D8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xD33FEC", Offset = "0xD33FEC", VA = "0xD33FEC")]
	public StaffStaminaGauge()
	{
	}
}
[Token(Token = "0x20000B4")]
public class StaffState : MonoBehaviour
{
	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2A00", Offset = "0x9C2A00")]
	public ObscuredBool isResting;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ObscuredBool isDamage;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredFloat restingTime;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ObscuredInt staffLevel;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public ObscuredInt staffExp;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ObscuredInt lastStaffExp;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private ObscuredFloat staminaRemain;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public ObscuredFloat speed;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public ObscuredFloat stamina;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private StaffMain staffMain;

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xD33FF4", Offset = "0xD33FF4", VA = "0xD33FF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xD343C8", Offset = "0xD343C8", VA = "0xD343C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xD33E3C", Offset = "0xD33E3C", VA = "0xD33E3C")]
	public float GetStaminaRate()
	{
		return default(float);
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xD33F00", Offset = "0xD33F00", VA = "0xD33F00")]
	public int GetRestTimeRemain()
	{
		return default(int);
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xD34060", Offset = "0xD34060", VA = "0xD34060")]
	public void ApplyStaffExp(bool isInitialize = false)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xD34808", Offset = "0xD34808", VA = "0xD34808")]
	private void OutOfStamina()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xD346A4", Offset = "0xD346A4", VA = "0xD346A4")]
	private void Resting()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xD34874", Offset = "0xD34874", VA = "0xD34874")]
	public StaffState()
	{
	}
}
[Token(Token = "0x20000B5")]
public class StaffTakeOrder : MonoBehaviour
{
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF058", Offset = "0x9BF058")]
	private sealed class <TakeOrderRoutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffTakeOrder <>4__this;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ChairItem <chairItem>5__2;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform <chairPosTf>5__3;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <elapsedTime>5__4;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <duration>5__5;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <startRot>5__6;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion <endRot>5__7;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject <refillPlate>5__8;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xD357D4", Offset = "0xD357D4", VA = "0xD357D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xD3583C", Offset = "0xD3583C", VA = "0xD3583C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xD34C9C", Offset = "0xD34C9C", VA = "0xD34C9C")]
		[DebuggerHidden]
		public <TakeOrderRoutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xD34CD8", Offset = "0xD34CD8", VA = "0xD34CD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xD34CDC", Offset = "0xD34CDC", VA = "0xD34CDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xD357DC", Offset = "0xD357DC", VA = "0xD357DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2A58", Offset = "0x9C2A58")]
	[SerializeField]
	private bool isRefillPlateServing;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject targetOrderSheet;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int chairNum;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private StaffMain.RoleType taskType;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StaffMain staffMain;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StaffState staffState;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine takeOrderRoutine;

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xD348FC", Offset = "0xD348FC", VA = "0xD348FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xD349A4", Offset = "0xD349A4", VA = "0xD349A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xD34A6C", Offset = "0xD34A6C", VA = "0xD34A6C")]
	private void StopTask()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xD34ACC", Offset = "0xD34ACC", VA = "0xD34ACC")]
	public bool CheckOrderCall()
	{
		return default(bool);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xD34C20", Offset = "0xD34C20", VA = "0xD34C20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8014", Offset = "0x9C8014")]
	private IEnumerator TakeOrderRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xD34CC8", Offset = "0xD34CC8", VA = "0xD34CC8")]
	public StaffTakeOrder()
	{
	}
}
[Token(Token = "0x20000B6")]
public class StaffWashDish : MonoBehaviour
{
	[Token(Token = "0x20001B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF068", Offset = "0x9BF068")]
	private sealed class <WashDirtyDishRoutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StaffWashDish <>4__this;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ChairItem <chairItem>5__2;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform <chairPosTf>5__3;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <elapsedTime>5__4;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <duration>5__5;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion <startRot>5__6;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion <endRot>5__7;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <i>5__8;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xD37958", Offset = "0xD37958", VA = "0xD37958", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xD379C0", Offset = "0xD379C0", VA = "0xD379C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xD36280", Offset = "0xD36280", VA = "0xD36280")]
		[DebuggerHidden]
		public <WashDirtyDishRoutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xD362D0", Offset = "0xD362D0", VA = "0xD362D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xD362D4", Offset = "0xD362D4", VA = "0xD362D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD37960", Offset = "0xD37960", VA = "0xD37960", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2AC4", Offset = "0x9C2AC4")]
	[SerializeField]
	private GameObject activeSponge;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> targetDishList;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int chairNum;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private StaffMain.RoleType taskType;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StaffMain staffMain;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StaffState staffState;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private StaffIkControl staffIkControl;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float checkInterval;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float nextCheckTime;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float dishDistanceThreshold;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Coroutine washDirtyDishRoutine;

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xD35DD0", Offset = "0xD35DD0", VA = "0xD35DD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xD35E9C", Offset = "0xD35E9C", VA = "0xD35E9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xD36020", Offset = "0xD36020", VA = "0xD36020")]
	private void StopTask()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xD36130", Offset = "0xD36130", VA = "0xD36130")]
	public bool CheckDirtyDish()
	{
		return default(bool);
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xD36204", Offset = "0xD36204", VA = "0xD36204")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8078", Offset = "0x9C8078")]
	private IEnumerator WashDirtyDishRoutine()
	{
		return null;
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xD362AC", Offset = "0xD362AC", VA = "0xD362AC")]
	public StaffWashDish()
	{
	}
}
[Token(Token = "0x20000B7")]
public class WashingHandPos : MonoBehaviour
{
	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2B30", Offset = "0x9C2B30")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2B7C", Offset = "0x9C2B7C")]
	[SerializeField]
	private Vector3 maxLocalPos;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 minLocalPos;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve animCurve;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem washingEffect;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x192B46C", Offset = "0x192B46C", VA = "0x192B46C")]
	private void Start()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x192B540", Offset = "0x192B540", VA = "0x192B540")]
	private void Update()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x192B4D8", Offset = "0x192B4D8", VA = "0x192B4D8")]
	public void SetEnable(bool value)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x192B688", Offset = "0x192B688", VA = "0x192B688")]
	public WashingHandPos()
	{
	}
}
[Token(Token = "0x20000B8")]
public class CustomerDrinkBeerStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000370")]
	[Address(RVA = "0xEC6FE0", Offset = "0xEC6FE0", VA = "0xEC6FE0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xEC7300", Offset = "0xEC7300", VA = "0xEC7300", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xEC7CF8", Offset = "0xEC7CF8", VA = "0xEC7CF8")]
	public CustomerDrinkBeerStateMachine()
	{
	}
}
[Token(Token = "0x20000B9")]
public class CustomerEatRamenStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000373")]
	[Address(RVA = "0xEC7D00", Offset = "0xEC7D00", VA = "0xEC7D00", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xEC80C8", Offset = "0xEC80C8", VA = "0xEC80C8", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xEC8400", Offset = "0xEC8400", VA = "0xEC8400")]
	public CustomerEatRamenStateMachine()
	{
	}
}
[Token(Token = "0x20000BA")]
public class CustomerEatRiceStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000376")]
	[Address(RVA = "0xEC8408", Offset = "0xEC8408", VA = "0xEC8408", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xEC8580", Offset = "0xEC8580", VA = "0xEC8580", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xEC868C", Offset = "0xEC868C", VA = "0xEC868C")]
	public CustomerEatRiceStateMachine()
	{
	}
}
[Token(Token = "0x20000BB")]
public class CustomerIdleSitStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000379")]
	[Address(RVA = "0xEC8694", Offset = "0xEC8694", VA = "0xEC8694", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xEC8754", Offset = "0xEC8754", VA = "0xEC8754", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xEC87E8", Offset = "0xEC87E8", VA = "0xEC87E8")]
	public CustomerIdleSitStateMachine()
	{
	}
}
[Token(Token = "0x20000BC")]
public class CustomerOrderStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x600037C")]
	[Address(RVA = "0xECAEE0", Offset = "0xECAEE0", VA = "0xECAEE0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xECAF94", Offset = "0xECAF94", VA = "0xECAF94")]
	public CustomerOrderStateMachine()
	{
	}
}
[Token(Token = "0x20000BD")]
public class CustomerSitDownStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x600037E")]
	[Address(RVA = "0xECBB68", Offset = "0xECBB68", VA = "0xECBB68", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xECBC1C", Offset = "0xECBC1C", VA = "0xECBC1C")]
	public CustomerSitDownStateMachine()
	{
	}
}
[Token(Token = "0x20000BE")]
public class CustomerSitUpStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000380")]
	[Address(RVA = "0xECBC24", Offset = "0xECBC24", VA = "0xECBC24", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xECBC28", Offset = "0xECBC28", VA = "0xECBC28", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xECBCB4", Offset = "0xECBCB4", VA = "0xECBCB4")]
	public CustomerSitUpStateMachine()
	{
	}
}
[Token(Token = "0x20000BF")]
public class FloorMarkerCloseStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x1D4E9D0", Offset = "0x1D4E9D0", VA = "0x1D4E9D0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1D4EA4C", Offset = "0x1D4EA4C", VA = "0x1D4EA4C")]
	public FloorMarkerCloseStateMachine()
	{
	}
}
[Token(Token = "0x20000C0")]
public class FloorMarkerOpenStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1D4EA54", Offset = "0x1D4EA54", VA = "0x1D4EA54", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1D4EAD0", Offset = "0x1D4EAD0", VA = "0x1D4EAD0")]
	public FloorMarkerOpenStateMachine()
	{
	}
}
[Token(Token = "0x20000C1")]
public class StaffCheeringStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000387")]
	[Address(RVA = "0xD0F720", Offset = "0xD0F720", VA = "0xD0F720", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xD0F7DC", Offset = "0xD0F7DC", VA = "0xD0F7DC")]
	public StaffCheeringStateMachine()
	{
	}
}
[Token(Token = "0x20000C2")]
public class StaffIdleStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000389")]
	[Address(RVA = "0xD10BE0", Offset = "0xD10BE0", VA = "0xD10BE0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xD10C70", Offset = "0xD10C70", VA = "0xD10C70")]
	public StaffIdleStateMachine()
	{
	}
}
[Token(Token = "0x20000C3")]
public class StaffTiredStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x600038B")]
	[Address(RVA = "0xD35C4C", Offset = "0xD35C4C", VA = "0xD35C4C", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xD35CC8", Offset = "0xD35CC8", VA = "0xD35CC8")]
	public StaffTiredStateMachine()
	{
	}
}
[Token(Token = "0x20000C4")]
public class StaffWalkStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x600038D")]
	[Address(RVA = "0xD35CD0", Offset = "0xD35CD0", VA = "0xD35CD0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xD35D4C", Offset = "0xD35D4C", VA = "0xD35D4C", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xD35DC8", Offset = "0xD35DC8", VA = "0xD35DC8")]
	public StaffWalkStateMachine()
	{
	}
}
[Token(Token = "0x20000C5")]
public class UiButtonOverStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1923930", Offset = "0x1923930", VA = "0x1923930", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1923A04", Offset = "0x1923A04", VA = "0x1923A04")]
	public UiButtonOverStateMachine()
	{
	}
}
[Token(Token = "0x20000C6")]
public class WipeCloseStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x192C894", Offset = "0x192C894", VA = "0x192C894", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x192C920", Offset = "0x192C920", VA = "0x192C920")]
	public WipeCloseStateMachine()
	{
	}
}
[Token(Token = "0x20000C7")]
public class WipeOpenStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x192C928", Offset = "0x192C928", VA = "0x192C928", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x192C9B4", Offset = "0x192C9B4", VA = "0x192C9B4", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x192CA3C", Offset = "0x192CA3C", VA = "0x192CA3C")]
	public WipeOpenStateMachine()
	{
	}
}
[Token(Token = "0x20000C8")]
public class ActiveGameManager : SingletonMonoBehaviour<ActiveGameManager>
{
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2BF8", Offset = "0x9C2BF8")]
	public ObscuredBool isGameActive;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ObscuredBool isExtraPeakTimeTriggered;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ObscuredFloat currentTime;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public ObscuredFloat totalOpenMinutes;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public ObscuredInt currentScore;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ObscuredInt nextPeakTimeScore;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public ObscuredInt baseScore;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ObscuredInt beautyScore;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public ObscuredInt bowScore;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ObscuredInt washScore;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public ObscuredInt ramenOverLifePenalty;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public ObscuredInt overWaitingPenalty;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public ObscuredInt staffCost;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<GameObject> getScoreList;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2C30", Offset = "0x9C2C30")]
	[SerializeField]
	private GameObject getScorePf;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly ObscuredFloat startTimeOffset;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly ObscuredFloat timeSpeedMlp;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly ObscuredFloat closeTime;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xEB6D44", Offset = "0xEB6D44", VA = "0xEB6D44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xEB729C", Offset = "0xEB729C", VA = "0xEB729C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xEB78E0", Offset = "0xEB78E0", VA = "0xEB78E0")]
	private void ShowGetScore()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xEB8228", Offset = "0xEB8228", VA = "0xEB8228")]
	public void AddCurrentTime(float value)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xEB6EB4", Offset = "0xEB6EB4", VA = "0xEB6EB4")]
	public void StartGame()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xEB79F8", Offset = "0xEB79F8", VA = "0xEB79F8")]
	public void EndGame()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xEB86A0", Offset = "0xEB86A0", VA = "0xEB86A0")]
	public void ResetNextPeakTimeScore()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xEB82D0", Offset = "0xEB82D0", VA = "0xEB82D0")]
	public void AddScore(ObscuredInt value, bool viewScore = true)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xEB86E4", Offset = "0xEB86E4", VA = "0xEB86E4")]
	public void AddBaseScore(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xEB8788", Offset = "0xEB8788", VA = "0xEB8788")]
	public void AddBeautyScore(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xEB882C", Offset = "0xEB882C", VA = "0xEB882C")]
	public void AddBowScore(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xEB88D0", Offset = "0xEB88D0", VA = "0xEB88D0")]
	public void AddWashScore(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xEB8974", Offset = "0xEB8974", VA = "0xEB8974")]
	public void AddRamenOverLifePenalty(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xEB8A18", Offset = "0xEB8A18", VA = "0xEB8A18")]
	public void AddOverWaitingPenalty(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xEB8ABC", Offset = "0xEB8ABC", VA = "0xEB8ABC")]
	public void SetStaffCost(ObscuredInt value)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xEB8AD4", Offset = "0xEB8AD4", VA = "0xEB8AD4")]
	public ActiveGameManager()
	{
	}
}
[Token(Token = "0x20000C9")]
public class AnnotationManager : SingletonMonoBehaviour<AnnotationManager>
{
	[Token(Token = "0x20001BA")]
	public enum MsgType
	{
		[Token(Token = "0x4000A29")]
		WristWatch,
		[Token(Token = "0x4000A2A")]
		LifeTime_Rule,
		[Token(Token = "0x4000A2B")]
		Tray_Not_Serving,
		[Token(Token = "0x4000A2C")]
		Not_Connect_Internet
	}

	[Token(Token = "0x20001BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF078", Offset = "0x9BF078")]
	private sealed class <ShowMessageRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnnotationManager <>4__this;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MsgType msgType;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xEB97BC", Offset = "0xEB97BC", VA = "0xEB97BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xEB9824", Offset = "0xEB9824", VA = "0xEB9824", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xEB9284", Offset = "0xEB9284", VA = "0xEB9284")]
		[DebuggerHidden]
		public <ShowMessageRoutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xEB9300", Offset = "0xEB9300", VA = "0xEB9300", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xEB9304", Offset = "0xEB9304", VA = "0xEB9304", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xEB97C4", Offset = "0xEB97C4", VA = "0xEB97C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2C7C", Offset = "0x9C2C7C")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform headTf;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x4000409")]
	private const float SHOW_DURATION = 8f;

	[Token(Token = "0x400040A")]
	private const string ANIM_CLOSE = "Close";

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine showRoutine;

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xEB8ED8", Offset = "0xEB8ED8", VA = "0xEB8ED8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xEB8FB8", Offset = "0xEB8FB8", VA = "0xEB8FB8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xEB91A4", Offset = "0xEB91A4", VA = "0xEB91A4")]
	public void ShowMessage(MsgType msgType, float duration = 8f)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xEB91F8", Offset = "0xEB91F8", VA = "0xEB91F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C80DC", Offset = "0x9C80DC")]
	private IEnumerator ShowMessageRoutine(MsgType msgType, float duration)
	{
		return null;
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xEB92B0", Offset = "0xEB92B0", VA = "0xEB92B0")]
	public AnnotationManager()
	{
	}
}
[Token(Token = "0x20000CA")]
public class AutoCooker : SingletonMonoBehaviour<AutoCooker>
{
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject ramenBowlPf;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject beerMugPf;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ricePf;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject subBowlPf;

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xEBB238", Offset = "0xEBB238", VA = "0xEBB238")]
	public GameObject MakeRamen(OrderItem orderItem)
	{
		return null;
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xEBB458", Offset = "0xEBB458", VA = "0xEBB458")]
	public AutoCooker()
	{
	}
}
[Serializable]
[Token(Token = "0x20000CB")]
public class ChairItem
{
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject rootObj;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ObscuredFloat lastCallTime;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredBool isReady;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public ObscuredBool isBowed;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ObscuredFloat totalWaitTime;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public NorenGrabReactor noren;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ObscuredInt chairNum;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CustomerProfileIcon customerProfileIcon;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject teleportPoint;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject customerObj;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject orderSheetObj;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public CustomerState.CustomerType customerType;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string charaName;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Transform waitPosTf;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform orderSheetPosTf;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform kaedamaPlatePosTf;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform ramenPosTf;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Transform ricePosTf;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform beerPosTf;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform subBowlPosTf;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject bowGuideObj;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject norenGuideObj;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject refillPlateGuideObj;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public FloorCustomerNumber floorCustomerNumber;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform frontPosTf;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Transform refillPlateSpawnPosTf;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Transform servingPosTf;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public List<GameObject> dirtyDishList;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public OrderItem orderItem;

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xEC0B14", Offset = "0xEC0B14", VA = "0xEC0B14")]
	public Transform GetDishPos(CookBase.DishType dishType)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xEC0C3C", Offset = "0xEC0C3C", VA = "0xEC0C3C")]
	public ChairItem()
	{
	}
}
[Token(Token = "0x20000CC")]
public class ChairManager : SingletonMonoBehaviour<ChairManager>
{
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF088", Offset = "0x9BF088")]
	private sealed class <SetEnableChairCountRoutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ChairManager <>4__this;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int count;

		[Token(Token = "0x1700007C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0xEC3740", Offset = "0xEC3740", VA = "0xEC3740", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xEC37A8", Offset = "0xEC37A8", VA = "0xEC37A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xEC1920", Offset = "0xEC1920", VA = "0xEC1920")]
		[DebuggerHidden]
		public <SetEnableChairCountRoutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xEC35E8", Offset = "0xEC35E8", VA = "0xEC35E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xEC35EC", Offset = "0xEC35EC", VA = "0xEC35EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xEC3748", Offset = "0xEC3748", VA = "0xEC3748", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2D18", Offset = "0x9C2D18")]
	public ObscuredBool isFullSeat;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ChairItem[] chairItems;

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xEC0C44", Offset = "0xEC0C44", VA = "0xEC0C44")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xEC0FD4", Offset = "0xEC0FD4", VA = "0xEC0FD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xEC10B8", Offset = "0xEC10B8", VA = "0xEC10B8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8140", Offset = "0x9C8140")]
	private void DetectPosTf()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xEC1674", Offset = "0xEC1674", VA = "0xEC1674")]
	public int GetOrderCallCount()
	{
		return default(int);
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xEC1748", Offset = "0xEC1748", VA = "0xEC1748")]
	public int GetActiveCustomerCount()
	{
		return default(int);
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xEC0EAC", Offset = "0xEC0EAC", VA = "0xEC0EAC")]
	public void SetEnableChairCount()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xEC1894", Offset = "0xEC1894", VA = "0xEC1894")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8178", Offset = "0x9C8178")]
	private IEnumerator SetEnableChairCountRoutine(int count)
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xEC194C", Offset = "0xEC194C", VA = "0xEC194C")]
	public OrderItem GetOrderItem(int chairNum)
	{
		return default(OrderItem);
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xEC0C68", Offset = "0xEC0C68", VA = "0xEC0C68")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C81DC", Offset = "0x9C81DC")]
	private void InitializeState()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xEC1C78", Offset = "0xEC1C78", VA = "0xEC1C78")]
	public bool IsEmptyChairExist()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xEC1D40", Offset = "0xEC1D40", VA = "0xEC1D40")]
	public void ResetChairState(ObscuredInt chairNum)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xEBE57C", Offset = "0xEBE57C", VA = "0xEBE57C")]
	public void SetIsBowed(ObscuredInt chairNum)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xEC0FD8", Offset = "0xEC0FD8", VA = "0xEC0FD8")]
	private void CheckFullSeat()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xEC22D8", Offset = "0xEC22D8", VA = "0xEC22D8")]
	public bool IsAllChairReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xEC23A4", Offset = "0xEC23A4", VA = "0xEC23A4")]
	public int GetReadyChairNum()
	{
		return default(int);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xEC2558", Offset = "0xEC2558", VA = "0xEC2558")]
	public void SetCustomerToChair(int chairNum, GameObject customer)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xEC26A8", Offset = "0xEC26A8", VA = "0xEC26A8")]
	public void SetOrder(OrderItem order, ObscuredInt chairPos)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xEC2740", Offset = "0xEC2740", VA = "0xEC2740")]
	public void OrderTaked(ObscuredInt chairNum)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xEC298C", Offset = "0xEC298C", VA = "0xEC298C")]
	public int GetWaitingCustomerChairNum()
	{
		return default(int);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xEC2AC8", Offset = "0xEC2AC8", VA = "0xEC2AC8")]
	public void RemoveDirtyDishFromList(GameObject dirtyDish)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xEC1998", Offset = "0xEC1998", VA = "0xEC1998")]
	public void SetActiveBowGuide(ObscuredInt chairNum, bool isActive)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xEC1AD4", Offset = "0xEC1AD4", VA = "0xEC1AD4")]
	public void SetActiveNorenGuide(ObscuredInt chairNum, bool isActive)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xEC1BBC", Offset = "0xEC1BBC", VA = "0xEC1BBC")]
	public void SetActiveRefillPlateGuide(int chairNum, bool isActive)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xEC2C3C", Offset = "0xEC2C3C", VA = "0xEC2C3C")]
	public int GetDirtyDishChairNum(out List<GameObject> dirtyDishList)
	{
		return default(int);
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xEC2EAC", Offset = "0xEC2EAC", VA = "0xEC2EAC")]
	public int GetOrderCallChairNum()
	{
		return default(int);
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xEC2F78", Offset = "0xEC2F78", VA = "0xEC2F78")]
	public bool IsOrderMatch(List<GameObject> objList, int chairNum)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xEC3574", Offset = "0xEC3574", VA = "0xEC3574")]
	public ChairManager()
	{
	}
}
[Token(Token = "0x20000CD")]
public class ControllerManager
{
	[Token(Token = "0x400042F")]
	public const float GRAB_RELEASE_VALUE = 0.9f;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float triggerThreshold;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float horizontalThreshold;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float verticalThreshold;

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xEC4740", Offset = "0xEC4740", VA = "0xEC4740")]
	public static bool Recenter()
	{
		return default(bool);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xEC4848", Offset = "0xEC4848", VA = "0xEC4848")]
	public static bool GetDownPause()
	{
		return default(bool);
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xEC48B0", Offset = "0xEC48B0", VA = "0xEC48B0")]
	public static bool GetDownLeftTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xEC4918", Offset = "0xEC4918", VA = "0xEC4918")]
	public static bool GetDownRightTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xEC4980", Offset = "0xEC4980", VA = "0xEC4980")]
	public static bool GetUpLeftTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xEC49E8", Offset = "0xEC49E8", VA = "0xEC49E8")]
	public static bool GetUpRightTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xEC4A50", Offset = "0xEC4A50", VA = "0xEC4A50")]
	public static float GetLeftTrigger()
	{
		return default(float);
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xEC4AB8", Offset = "0xEC4AB8", VA = "0xEC4AB8")]
	public static float GetRightTrigger()
	{
		return default(float);
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xEC4B20", Offset = "0xEC4B20", VA = "0xEC4B20")]
	public static bool GetDownLeftHandTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xEC4B88", Offset = "0xEC4B88", VA = "0xEC4B88")]
	public static bool GetDownRightHandTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xEBD16C", Offset = "0xEBD16C", VA = "0xEBD16C")]
	public static bool GetUpLeftHandTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xEBD018", Offset = "0xEBD018", VA = "0xEBD018")]
	public static bool GetUpRightHandTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xEC4BF0", Offset = "0xEC4BF0", VA = "0xEC4BF0")]
	public static float GetLeftHandTrigger()
	{
		return default(float);
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xEC4C58", Offset = "0xEC4C58", VA = "0xEC4C58")]
	public static float GetRightHandTrigger()
	{
		return default(float);
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xEC4CC0", Offset = "0xEC4CC0", VA = "0xEC4CC0")]
	public static bool GetDownLeftButtonOne()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xEC4D28", Offset = "0xEC4D28", VA = "0xEC4D28")]
	public static bool GetDownRightButtonOne()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xEC4D90", Offset = "0xEC4D90", VA = "0xEC4D90")]
	public static bool GetUpLeftButtonOne()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xEC4DF8", Offset = "0xEC4DF8", VA = "0xEC4DF8")]
	public static bool GetUpRightButtonOne()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xEC4E60", Offset = "0xEC4E60", VA = "0xEC4E60")]
	public static bool GetLeftButtonOne()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xEC4EC8", Offset = "0xEC4EC8", VA = "0xEC4EC8")]
	public static bool GetRightButtonOne()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xEC4F30", Offset = "0xEC4F30", VA = "0xEC4F30")]
	public static bool GetDownLeftButtonTwo()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xEC4F98", Offset = "0xEC4F98", VA = "0xEC4F98")]
	public static bool GetDownRightButtonTwo()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xEC5000", Offset = "0xEC5000", VA = "0xEC5000")]
	public static bool GetLeftButtonTwo()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xEC5068", Offset = "0xEC5068", VA = "0xEC5068")]
	public static bool GetRightButtonTwo()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xEC50D0", Offset = "0xEC50D0", VA = "0xEC50D0")]
	public static bool GetDownLeftThumbstickButton()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xEC5138", Offset = "0xEC5138", VA = "0xEC5138")]
	public static bool GetDownRightThumbstickButton()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xEC51A0", Offset = "0xEC51A0", VA = "0xEC51A0")]
	public static float GetLeftHorizontal()
	{
		return default(float);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xEC5208", Offset = "0xEC5208", VA = "0xEC5208")]
	public static float GetLeftVertical()
	{
		return default(float);
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xEC5278", Offset = "0xEC5278", VA = "0xEC5278")]
	public static float GetRightHorizontal()
	{
		return default(float);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xEC52E0", Offset = "0xEC52E0", VA = "0xEC52E0")]
	public static float GetRightVertical()
	{
		return default(float);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xEC5350", Offset = "0xEC5350", VA = "0xEC5350")]
	public ControllerManager()
	{
	}
}
[Token(Token = "0x20000CE")]
public class CustomerSpawner : SingletonMonoBehaviour<CustomerSpawner>
{
	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2D50", Offset = "0x9C2D50")]
	[SerializeField]
	private ObscuredBool isEnable;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2D9C", Offset = "0x9C2D9C")]
	[SerializeField]
	private Transform spawnPosTf;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] customerPfs;

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xECBCBC", Offset = "0xECBCBC", VA = "0xECBCBC")]
	public void Activate()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xECBCEC", Offset = "0xECBCEC", VA = "0xECBCEC")]
	public void Disable()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xECBD1C", Offset = "0xECBD1C", VA = "0xECBD1C")]
	public void Spawn()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xECBEEC", Offset = "0xECBEEC", VA = "0xECBEEC")]
	public bool TrySpawn()
	{
		return default(bool);
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xECBF90", Offset = "0xECBF90", VA = "0xECBF90")]
	public CustomerSpawner()
	{
	}
}
[Token(Token = "0x20000CF")]
public class DemoVerManager : SingletonMonoBehaviour<DemoVerManager>
{
	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2DF8", Offset = "0x9C2DF8")]
	[SerializeField]
	private GameObject helpCanvasRoot;

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x1D48FE0", Offset = "0x1D48FE0", VA = "0x1D48FE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x1D4907C", Offset = "0x1D4907C", VA = "0x1D4907C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x1D48F38", Offset = "0x1D48F38", VA = "0x1D48F38")]
	public void CloseCanvas()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1D49174", Offset = "0x1D49174", VA = "0x1D49174")]
	public DemoVerManager()
	{
	}
}
[Token(Token = "0x20000D0")]
public class DishCountManager : SingletonMonoBehaviour<DishCountManager>
{
	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2E44", Offset = "0x9C2E44")]
	public int orderRiceTotal;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int orderBeerTotal;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> readyRiceList;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<GameObject> readyBeerList;

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1D4B2C4", Offset = "0x1D4B2C4", VA = "0x1D4B2C4")]
	public void AddOrderRice(int value)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1D4B2D4", Offset = "0x1D4B2D4", VA = "0x1D4B2D4")]
	public void AddOrderBeer(int value)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1D4B2E4", Offset = "0x1D4B2E4", VA = "0x1D4B2E4")]
	public void AddReadyRice(GameObject rice)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1D4B34C", Offset = "0x1D4B34C", VA = "0x1D4B34C")]
	public void AddReadyBeer(GameObject beer)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x1D4B3B4", Offset = "0x1D4B3B4", VA = "0x1D4B3B4")]
	public void RemoveRice(GameObject rice, bool isDetectedCustomer)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x1D4B460", Offset = "0x1D4B460", VA = "0x1D4B460")]
	public void RemoveBeer(GameObject beer, bool isDetectedCustomer)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x1D4B50C", Offset = "0x1D4B50C", VA = "0x1D4B50C")]
	public bool IsNeedRice()
	{
		return default(bool);
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x1D4B568", Offset = "0x1D4B568", VA = "0x1D4B568")]
	public bool IsNeedBeer()
	{
		return default(bool);
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x1D4B5C4", Offset = "0x1D4B5C4", VA = "0x1D4B5C4")]
	public DishCountManager()
	{
	}
}
[Token(Token = "0x20000D1")]
public class ExtraPeakTime : MonoBehaviour
{
	[Token(Token = "0x20001BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF098", Offset = "0x9BF098")]
	private sealed class <ExtraPeakTimeRoutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExtraPeakTime <>4__this;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <currentTime>5__2;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1D4D230", Offset = "0x1D4D230", VA = "0x1D4D230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x1D4D298", Offset = "0x1D4D298", VA = "0x1D4D298", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1D4C64C", Offset = "0x1D4C64C", VA = "0x1D4C64C")]
		[DebuggerHidden]
		public <ExtraPeakTimeRoutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1D4C76C", Offset = "0x1D4C76C", VA = "0x1D4C76C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1D4C770", Offset = "0x1D4C770", VA = "0x1D4C770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1D4D238", Offset = "0x1D4D238", VA = "0x1D4D238", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2E7C", Offset = "0x9C2E7C")]
	public bool isExtraPeakTime;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ObscuredInt peakTimeLevel;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredFloat spawnTimeRemain;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ObscuredInt nextTargetScore;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2EB4", Offset = "0x9C2EB4")]
	[SerializeField]
	private ObscuredFloat peakTimeSpawnInterval;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ObscuredFloat peakTimeDuration;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ObscuredFloat normalTimeDuration;

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x1D4C5A4", Offset = "0x1D4C5A4", VA = "0x1D4C5A4")]
	public void StartPeakTime()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1D4C5D0", Offset = "0x1D4C5D0", VA = "0x1D4C5D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8214", Offset = "0x9C8214")]
	private IEnumerator ExtraPeakTimeRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1D4C678", Offset = "0x1D4C678", VA = "0x1D4C678")]
	public ExtraPeakTime()
	{
	}
}
[Token(Token = "0x20000D2")]
public class FpsTimer : MonoBehaviour
{
	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isShow;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fps;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly float INTERVAL;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_prev_time;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_frame_count;

	[Token(Token = "0x4000448")]
	private const int targetFPS = 60;

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x1D4EAD8", Offset = "0x1D4EAD8", VA = "0x1D4EAD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1D4EAEC", Offset = "0x1D4EAEC", VA = "0x1D4EAEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x1D4ED44", Offset = "0x1D4ED44", VA = "0x1D4ED44")]
	public FpsTimer()
	{
	}
}
[Token(Token = "0x20000D3")]
public static class GameDefines
{
	[Token(Token = "0x4000449")]
	public const string TAG_PLAYER = "Player";

	[Token(Token = "0x400044A")]
	public const string TAG_PLAYER_HEAD = "PlayerHead";

	[Token(Token = "0x400044B")]
	public const string TAG_WASH_TOOL = "Sponge";

	[Token(Token = "0x400044C")]
	public const string TAG_WALL = "Wall";

	[Token(Token = "0x400044D")]
	public const string SCENE_NAME_TITLE = "Opening";

	[Token(Token = "0x400044E")]
	public const string SCENE_GAME_MAIN = "GameMain";

	[Token(Token = "0x400044F")]
	public const string ANIM_GRAB = "Grab";

	[Token(Token = "0x4000450")]
	public const string ANIM_EAT_RAMEN = "Ramen";

	[Token(Token = "0x4000451")]
	public const string ANIM_DRINK_BEER = "Beer";

	[Token(Token = "0x4000452")]
	public const string ANIM_EAT_RICE = "Rice";

	[Token(Token = "0x4000453")]
	public const string ANIM_EAT_FINISH = "EatFinish";

	[Token(Token = "0x4000454")]
	public const string ANIM_NOREN_CLOSE = "NorenClose";

	[Token(Token = "0x4000455")]
	public const int CHAIR_COUNT = 18;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly ObscuredFloat QUALITY_LIFE_TIME;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly ObscuredFloat MAX_DIRTY_VALUE;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly ObscuredFloat NEED_WASH_VELOCITY;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static readonly ObscuredFloat WASH_POWER_MLP;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static readonly ObscuredInt PEAK_TIME_NEED_START_SCORE;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public static readonly ObscuredInt NEXT_PEAK_TIME_NEED_SCORE_BASE;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static readonly ObscuredInt PEAK_TIME_NEED_SCORE_INCREASE_STEP;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public static readonly ObscuredInt SCORE_LIMIT;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static readonly ObscuredInt TOTAL_MONEY_LIMIT;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public static readonly ObscuredInt DEFAULT_HALL_EXTEND;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static readonly ObscuredInt FULL_ORDER_START_WAVE;

	[Token(Token = "0x4000461")]
	public const float TABLET_ALERT_DURATION = 8f;

	[Token(Token = "0x4000462")]
	public const float VOICE_SOUND_VOLUME = 0.7f;

	[Token(Token = "0x4000463")]
	public const float HEIGHT_ADJUST_STEP = 0.02f;

	[Token(Token = "0x4000464")]
	public const float STAFF_DEFAULT_INTERACTION_TIME = 0.5f;

	[Token(Token = "0x4000465")]
	public const float DEMO_VER_START_TIME = 1013f;

	[Token(Token = "0x4000466")]
	public const float DEMO_VER_SPAWN_TIME = 1020f;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public static readonly ObscuredInt RANK_SCORE_0;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public static readonly ObscuredInt RANK_SCORE_1;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public static readonly ObscuredInt RANK_SCORE_2;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public static readonly ObscuredInt RANK_SCORE_3;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public static readonly ObscuredInt RANK_SCORE_4;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public static readonly ObscuredInt RANK_SCORE_5;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public static readonly ObscuredInt RANK_SCORE_6;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public static readonly ObscuredInt WASH_DISH_SCORE;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public static readonly ObscuredInt BOW_SCORE;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public static readonly ObscuredInt REFILL_PLATE_SCORE;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	public static readonly ObscuredInt REFILL_BOWL_SCORE;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public static readonly ObscuredInt RAMEN_SCORE;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	public static readonly ObscuredInt MEAT_POS_MAX_SCORE;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public static readonly ObscuredInt LEEK_POS_MAX_SCORE;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	public static readonly ObscuredInt MEAT_UNMATCH_SCORE;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public static readonly ObscuredInt LEEK_UNMATCH_SCORE;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	public static readonly ObscuredInt SECRET_TARE_UNMATCH_SCORE;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public static readonly ObscuredInt NOODLE_HARDNESS_UNMATCH_SCORE;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	public static readonly ObscuredInt RICE_SCORE;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public static readonly ObscuredInt RICE_LEVEL_BASE_SCORE;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	public static readonly ObscuredInt BEER_SCORE;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public static readonly ObscuredInt BEER_LEVEL_BASE_SCORE;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	public static readonly ObscuredFloat WRONG_DISH_SCORE_MLP;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
	public static readonly ObscuredFloat OVER_WAIT_TIME;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
	public static readonly ObscuredInt OVER_WAIT_TIME_SCORE;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public static readonly ObscuredInt RAMEN_OVER_LIFE_TIME_SCORE;

	[Token(Token = "0x4000481")]
	public const string EVENT_START_GAME = "StartGame";

	[Token(Token = "0x4000482")]
	public const string EVENT_END_GAME = "EndGame";

	[Token(Token = "0x4000483")]
	public const string EVENT_TUTORIAL_CONTROL = "TutorialClear.Controls";

	[Token(Token = "0x4000484")]
	public const string EVENT_TUTORIAL_ORDER = "TutorialClear.Order";

	[Token(Token = "0x4000485")]
	public const string EVENT_TUTORIAL_COOK_ALL = "TutorialClear.Cook_All";

	[Token(Token = "0x4000486")]
	public const string EVENT_TUTORIAL_COOK_RAMEN = "TutorialClear.Cook_Ramen";

	[Token(Token = "0x4000487")]
	public const string EVENT_TUTORIAL_COOK_SIDE = "TutorialClear.Cook_Side";

	[Token(Token = "0x4000488")]
	public const string EVENT_TUTORIAL_COOK_REFILL = "TutorialClear.Cook_Refill";

	[Token(Token = "0x4000489")]
	public const string EVENT_TUTORIAL_WASH = "TutorialClear.Wash";

	[Token(Token = "0x400048A")]
	public const string EVENT_COMPLETE_TUTORIAL = "CompleteAllTutorial";

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
	public static readonly ObscuredFloat STAMINA_RECOVER_TIME;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	public static readonly ObscuredInt ASSIGNABLE_STAFF_COUNT;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public static readonly ObscuredInt STAFF_MAX_LEVEL;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	public static readonly ObscuredFloat NOREN_OPEN_GRAB_DURATION;
}
[Token(Token = "0x20000D4")]
public class GeneralGameManager : SingletonMonoBehaviour<GeneralGameManager>
{
	[Token(Token = "0x20001BE")]
	public enum LangType
	{
		[Token(Token = "0x4000A3A")]
		None,
		[Token(Token = "0x4000A3B")]
		English,
		[Token(Token = "0x4000A3C")]
		Japanese,
		[Token(Token = "0x4000A3D")]
		Chinese
	}

	[Token(Token = "0x20001BF")]
	public enum GameMode
	{
		[Token(Token = "0x4000A3F")]
		None,
		[Token(Token = "0x4000A40")]
		TimeLimit,
		[Token(Token = "0x4000A41")]
		ShopManager,
		[Token(Token = "0x4000A42")]
		Tutorial
	}

	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF0A8", Offset = "0x9BF0A8")]
	private sealed class <BackToTitleRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1D4FF94", Offset = "0x1D4FF94", VA = "0x1D4FF94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1D4FFFC", Offset = "0x1D4FFFC", VA = "0x1D4FFFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1D4F720", Offset = "0x1D4F720", VA = "0x1D4F720")]
		[DebuggerHidden]
		public <BackToTitleRoutine>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1D4FC80", Offset = "0x1D4FC80", VA = "0x1D4FC80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1D4FC84", Offset = "0x1D4FC84", VA = "0x1D4FC84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1D4FF9C", Offset = "0x1D4FF9C", VA = "0x1D4FF9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF0B8", Offset = "0x9BF0B8")]
	private sealed class <RestartSceneRoutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000082")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1D50178", Offset = "0x1D50178", VA = "0x1D50178", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1D501E0", Offset = "0x1D501E0", VA = "0x1D501E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1D4F7D8", Offset = "0x1D4F7D8", VA = "0x1D4F7D8")]
		[DebuggerHidden]
		public <RestartSceneRoutine>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1D50004", Offset = "0x1D50004", VA = "0x1D50004", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1D50008", Offset = "0x1D50008", VA = "0x1D50008", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1D50180", Offset = "0x1D50180", VA = "0x1D50180", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2F20", Offset = "0x9C2F20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2F20", Offset = "0x9C2F20")]
	public LangType language;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameMode gameMode;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string nextLoadSceneName;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isShowedSplash;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2F80", Offset = "0x9C2F80")]
	public bool isDemoVersion;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ObscuredBool isEnableDebugCmd;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioMixer mixer;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Font defaultFont;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Font chineseFont;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_FontAsset defaultFontAssetTMP;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_FontAsset chineseFontAssetTMP;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C2FC8", Offset = "0x9C2FC8")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C2FC8", Offset = "0x9C2FC8")]
	private bool enableDebugLanguage;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private LangType debugLanguage;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isSitting;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1D4F514", Offset = "0x1D4F514", VA = "0x1D4F514")]
	private void Start()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x1D4F5EC", Offset = "0x1D4F5EC", VA = "0x1D4F5EC")]
	private void CheckInternetConnection()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x1D4F694", Offset = "0x1D4F694", VA = "0x1D4F694")]
	public void BackToTitle()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1D4F6C0", Offset = "0x1D4F6C0", VA = "0x1D4F6C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8278", Offset = "0x9C8278")]
	private IEnumerator BackToTitleRoutine()
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x1D4F74C", Offset = "0x1D4F74C", VA = "0x1D4F74C")]
	public void RestartScene()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x1D4F778", Offset = "0x1D4F778", VA = "0x1D4F778")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C82DC", Offset = "0x9C82DC")]
	private IEnumerator RestartSceneRoutine()
	{
		return null;
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x1D4F804", Offset = "0x1D4F804", VA = "0x1D4F804")]
	public void SetLang(LangType lang)
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1D4F598", Offset = "0x1D4F598", VA = "0x1D4F598")]
	private void CheckLanguage()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1D4F80C", Offset = "0x1D4F80C", VA = "0x1D4F80C")]
	public bool IsControlEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1D4FC30", Offset = "0x1D4FC30", VA = "0x1D4FC30")]
	public GeneralGameManager()
	{
	}
}
[Token(Token = "0x20000D5")]
public class InitLoading : MonoBehaviour
{
	[Token(Token = "0x20001C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF0C8", Offset = "0x9BF0C8")]
	private sealed class <FakeLoadingRoutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InitLoading <>4__this;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x17000084")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1D57298", Offset = "0x1D57298", VA = "0x1D57298", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1D57300", Offset = "0x1D57300", VA = "0x1D57300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1D56D70", Offset = "0x1D56D70", VA = "0x1D56D70")]
		[DebuggerHidden]
		public <FakeLoadingRoutine>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1D56E4C", Offset = "0x1D56E4C", VA = "0x1D56E4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1D56E50", Offset = "0x1D56E50", VA = "0x1D56E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1D572A0", Offset = "0x1D572A0", VA = "0x1D572A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF0D8", Offset = "0x9BF0D8")]
	private sealed class <LoadingRoutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InitLoading <>4__this;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <asyncOp>5__2;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <duration>5__4;

		[Token(Token = "0x17000086")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1D575A4", Offset = "0x1D575A4", VA = "0x1D575A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1D5760C", Offset = "0x1D5760C", VA = "0x1D5760C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1D56E18", Offset = "0x1D56E18", VA = "0x1D56E18")]
		[DebuggerHidden]
		public <LoadingRoutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1D57308", Offset = "0x1D57308", VA = "0x1D57308", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1D5730C", Offset = "0x1D5730C", VA = "0x1D5730C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1D575AC", Offset = "0x1D575AC", VA = "0x1D575AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image progressBar;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CanvasGroup canvasGroup;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x1D56CAC", Offset = "0x1D56CAC", VA = "0x1D56CAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x1D56CF4", Offset = "0x1D56CF4", VA = "0x1D56CF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8340", Offset = "0x9C8340")]
	private IEnumerator FakeLoadingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1D56D9C", Offset = "0x1D56D9C", VA = "0x1D56D9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C83A4", Offset = "0x9C83A4")]
	private IEnumerator LoadingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x1D56E44", Offset = "0x1D56E44", VA = "0x1D56E44")]
	public InitLoading()
	{
	}
}
[Token(Token = "0x20000D6")]
public class LocalizeManager : SingletonMonoBehaviour<LocalizeManager>
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3068", Offset = "0x9C3068")]
	[SerializeField]
	private CharaProfileData charaProfileData;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UiLocalizeData uiLocalizeData;

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x1D5C5D4", Offset = "0x1D5C5D4", VA = "0x1D5C5D4")]
	public string GetCharaName(CustomerState.CustomerType type)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x1D4DA4C", Offset = "0x1D4DA4C", VA = "0x1D4DA4C")]
	public string GetUiText(string id)
	{
		return null;
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x1D5C96C", Offset = "0x1D5C96C", VA = "0x1D5C96C")]
	public LocalizeManager()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D7")]
public struct OrderItem
{
	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ObscuredBool isKaedamaPlateDetected;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ObscuredBool isOrderCall;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ObscuredBool isOrderRefillCall;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ObscuredBool isCleanupCall;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredBool isWaitRamen;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public ObscuredBool isWaitKaedamaBowl;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ObscuredBool isOverWaiting;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public NoodleState.HardnessStep noodleHardness;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ObscuredBool needMeat;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public ObscuredBool needLeek;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ObscuredBool needSecretTare;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public ObscuredBool rice;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ObscuredBool beer;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public ObscuredBool refillNoodle;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C30C4", Offset = "0x9C30C4")]
	public ObscuredFloat meatGoodRate;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ObscuredFloat leekGoodRate;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ObscuredBool isRamenOverLife;
}
[Token(Token = "0x20000D8")]
public class OrderManager
{
	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ObscuredFloat meatRate;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ObscuredFloat leekRate;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly ObscuredFloat secretTareRate;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly ObscuredFloat sideMenuRate;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly ObscuredFloat extraNoodleRate;

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xDBF43C", Offset = "0xDBF43C", VA = "0xDBF43C")]
	public static OrderItem GetRandomOrder()
	{
		return default(OrderItem);
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xDBFAB4", Offset = "0xDBFAB4", VA = "0xDBFAB4")]
	public static void SetSideMenu(ref OrderItem order)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xDBF870", Offset = "0xDBF870", VA = "0xDBF870")]
	public static void SetToppingOrder(ref OrderItem order)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xDBF7CC", Offset = "0xDBF7CC", VA = "0xDBF7CC")]
	public static NoodleState.HardnessStep GetRandomNoodleHardness()
	{
		return default(NoodleState.HardnessStep);
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xDBFC70", Offset = "0xDBFC70", VA = "0xDBFC70")]
	public static OrderItem GetNormalRamenOrder()
	{
		return default(OrderItem);
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xDBFD90", Offset = "0xDBFD90", VA = "0xDBFD90")]
	public static OrderItem GetFullSetOrder()
	{
		return default(OrderItem);
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xDBFEB0", Offset = "0xDBFEB0", VA = "0xDBFEB0")]
	public static OrderItem GetRamenWithRefillOrder()
	{
		return default(OrderItem);
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0xDBFFD0", Offset = "0xDBFFD0", VA = "0xDBFFD0")]
	public OrderManager()
	{
	}
}
[Token(Token = "0x20000D9")]
public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
	[Token(Token = "0x20001C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF0E8", Offset = "0x9BF0E8")]
	private sealed class <Start>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PauseManager <>4__this;

		[Token(Token = "0x17000088")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xDC26C4", Offset = "0xDC26C4", VA = "0xDC26C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0xDC272C", Offset = "0xDC272C", VA = "0xDC272C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xDC2040", Offset = "0xDC2040", VA = "0xDC2040")]
		[DebuggerHidden]
		public <Start>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xDC25F8", Offset = "0xDC25F8", VA = "0xDC25F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xDC25FC", Offset = "0xDC25FC", VA = "0xDC25FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xDC26CC", Offset = "0xDC26CC", VA = "0xDC26CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF0F8", Offset = "0x9BF0F8")]
	private sealed class <SetCanvasPosToFrontRoutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PauseManager <>4__this;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <resumeTime>5__2;

		[Token(Token = "0x1700008A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xDC2588", Offset = "0xDC2588", VA = "0xDC2588", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xDC25F0", Offset = "0xDC25F0", VA = "0xDC25F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xDC23D4", Offset = "0xDC23D4", VA = "0xDC23D4")]
		[DebuggerHidden]
		public <SetCanvasPosToFrontRoutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xDC24D8", Offset = "0xDC24D8", VA = "0xDC24D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xDC24DC", Offset = "0xDC24DC", VA = "0xDC24DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xDC2590", Offset = "0xDC2590", VA = "0xDC2590", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C30FC", Offset = "0x9C30FC")]
	public bool isPause;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3134", Offset = "0x9C3134")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject simpleCanvasRoot;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioMixer mixer;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip pauseSound;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject backTitleButton;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject shopCloseButton;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float headDistance;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AudioSource audioSource;

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xDC1FC4", Offset = "0xDC1FC4", VA = "0xDC1FC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8408", Offset = "0x9C8408")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xDC206C", Offset = "0xDC206C", VA = "0xDC206C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xDC2268", Offset = "0xDC2268", VA = "0xDC2268")]
	public void AddHeightPos(float value)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xDBE0E4", Offset = "0xDBE0E4", VA = "0xDBE0E4")]
	public void SetCanvasPositionToFront()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xDBD83C", Offset = "0xDBD83C", VA = "0xDBD83C")]
	public void SetCanvasPositionToFront(float delay)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xDC2348", Offset = "0xDC2348", VA = "0xDC2348")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C846C", Offset = "0x9C846C")]
	private IEnumerator SetCanvasPosToFrontRoutine(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xDC2400", Offset = "0xDC2400", VA = "0xDC2400")]
	public void PlayInPauseSoundOneShot(AudioClip clip)
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xDBD01C", Offset = "0xDBD01C", VA = "0xDBD01C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C84D0", Offset = "0x9C84D0")]
	public void Pause(bool isSimple = false)
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xDBD868", Offset = "0xDBD868", VA = "0xDBD868")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8508", Offset = "0x9C8508")]
	public void Resume()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xDC2480", Offset = "0xDC2480", VA = "0xDC2480")]
	public PauseManager()
	{
	}
}
[Token(Token = "0x20000DA")]
public class RecordCamAnchor : MonoBehaviour
{
	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float rate;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float forwardOffset;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform headTf;

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xCFF5E0", Offset = "0xCFF5E0", VA = "0xCFF5E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xCFF684", Offset = "0xCFF684", VA = "0xCFF684")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xCFF8C8", Offset = "0xCFF8C8", VA = "0xCFF8C8")]
	public RecordCamAnchor()
	{
	}
}
[Token(Token = "0x20000DB")]
public class RemoteConfig : SingletonMonoBehaviour<RemoteConfig>
{
	[Token(Token = "0x20001C6")]
	private struct UserAttributes
	{
	}

	[Token(Token = "0x20001C7")]
	private struct AppAttributes
	{
	}

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C31F0", Offset = "0x9C31F0")]
	public string assignId;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isLoaded;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool isLoadedRemote;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool isShowInfo;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string infoMainString;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string infoSubString;

	[Token(Token = "0x40004C9")]
	private const string SHOW_INFO_BOARD = "ShowInfoBoard";

	[Token(Token = "0x40004CA")]
	private const string INFO_MAIN_TEXT = "InfoMainText";

	[Token(Token = "0x40004CB")]
	private const string INFO_SUB_TEXT = "InfoSubText";

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xCFFAAC", Offset = "0xCFFAAC", VA = "0xCFFAAC")]
	private void Start()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xCFFBF0", Offset = "0xCFFBF0", VA = "0xCFFBF0")]
	private void ApplyRemoteSettings(ConfigResponse res)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xCFFF7C", Offset = "0xCFFF7C", VA = "0xCFFF7C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xCFFB4C", Offset = "0xCFFB4C", VA = "0xCFFB4C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8540", Offset = "0x9C8540")]
	public void Fetch()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xD00018", Offset = "0xD00018", VA = "0xD00018")]
	public RemoteConfig()
	{
	}
}
[Token(Token = "0x20000DC")]
public class ResourceManager : SingletonMonoBehaviour<ResourceManager>
{
	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3228", Offset = "0x9C3228")]
	public AudioClip dishCompleteSound;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip washCompleteSound;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioClip watchCallSound;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip charumeraSound;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip setSoupSound;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip setNoodleSound;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioClip putMeatSound;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip putRiceSound;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip yugiriSound;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioClip tareSound;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip spongeWashSound;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3260", Offset = "0x9C3260")]
	public AudioClip goodSound;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioClip badSound;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioClip alertSound;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AudioClip dissolveSound;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public AudioClip dishInWaterSound;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public AudioClip pauseSound;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AudioClip uiHoverSound;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AudioClip visitSound;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AudioClip casherSound;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public AudioClip hitSound;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public AudioClip levelUpSound;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3298", Offset = "0x9C3298")]
	public AudioClip refillAlertSound;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioClip lunchAlertSound;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public AudioClip peakAlertSound;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AudioClip washAlertSound;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public AudioClip welcomeAlertSound;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public AudioClip readySound;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public AudioClip openSound;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public AudioClip closeSound;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public AudioClip[] countSounds;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C32D0", Offset = "0x9C32D0")]
	public AudioClip tutorialAcceptOrderVoice;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public AudioClip tutorialControlsVoice;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public AudioClip tutorialCookingVoice;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public AudioClip tutorialCookRamenVoice;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public AudioClip tutorialCookKaedamaVoice;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public AudioClip tutorialCookSideMenuVoice;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public AudioClip tutorialWashupVoice;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public AudioClip tutorialDoneVoice;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3308", Offset = "0x9C3308")]
	public AudioClip drinkBeerSound;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public AudioClip eatRamenSound;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public AudioClip eatRiceSound;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3340", Offset = "0x9C3340")]
	public AudioClip gameEndMusic;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public AudioClip peakTimeMusic;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public AudioClip[] shopMusics;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3378", Offset = "0x9C3378")]
	public Transform exitPosTf;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C33B0", Offset = "0x9C33B0")]
	public GameObject orderSheetPf;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public GameObject soupOnlyRamenBowlPf;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public GameObject ramenBowlDirtyPf;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public GameObject riceBowlDirtyPf;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public GameObject beerMugDirtyPf;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public GameObject riceBowlPf;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public GameObject beerMugPf;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public GameObject refillPlateHardPf;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public GameObject refillPlateNormalPf;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public GameObject refillPlateSoftPf;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public GameObject refillPlateForCustomerPf;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public GameObject toolSpongePf;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public GameObject toolShamojiPf;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C33E8", Offset = "0x9C33E8")]
	public Sprite enableButtonSprite;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Sprite disableButtonSprite;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public Sprite dishupExcellentIcon;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public Sprite dishupGoodIcon;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public Sprite dishupBadIcon;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public Sprite dishupTooBadIcon;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public Sprite meatValidIcon;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public Sprite meatInvalidIcon;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Sprite leekValidIcon;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public Sprite leekInvalidIcon;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public Sprite secretTareValidIcon;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public Sprite secretTareInvalidIcon;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public Sprite beerValidIcon;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public Sprite beerInvalidIcon;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public Sprite riceValidIcon;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public Sprite riceInvalidIcon;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public Sprite[] rankSprites;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public Sprite[] staffFaceIcons;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public Sprite[] staffCostumeIcons;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3420", Offset = "0x9C3420")]
	public Sprite customerNormalProfileBackSprite;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public Sprite customerSmileProfileBackSprite;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public Sprite customerAngryProfileBackSprite;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public Sprite chairRamenIconNormal;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public Sprite chairRamenIconChecked;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public Sprite chairBeerIconNormal;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public Sprite chairBeerIconChecked;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public Sprite chairRiceIconNormal;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public Sprite chairRiceIconChecked;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public Sprite chairRefillIconNormal;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public Sprite chairRefillIconChecked;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public Sprite[] customerFaceSprites;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public Sprite[] customerSmileFaceSprites;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Sprite[] customerAngryFaceSprites;

	[Token(Token = "0x6000433")]
	[Address(RVA = "0xD00250", Offset = "0xD00250", VA = "0xD00250")]
	public ResourceManager()
	{
	}
}
[Token(Token = "0x20000DD")]
public class ResultManager : SingletonMonoBehaviour<ResultManager>
{
	[Token(Token = "0x20001C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF108", Offset = "0x9BF108")]
	private sealed class <ShowRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResultManager <>4__this;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <detailScore>5__2;

		[Token(Token = "0x1700008C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xD01D74", Offset = "0xD01D74", VA = "0xD01D74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xD01DDC", Offset = "0xD01DDC", VA = "0xD01DDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xD00AC0", Offset = "0xD00AC0", VA = "0xD00AC0")]
		[DebuggerHidden]
		public <ShowRoutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD00FC8", Offset = "0xD00FC8", VA = "0xD00FC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD00FCC", Offset = "0xD00FCC", VA = "0xD00FCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xD01D7C", Offset = "0xD01D7C", VA = "0xD01D7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3458", Offset = "0x9C3458")]
	public bool isShow;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int rankNum;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3490", Offset = "0x9C3490")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rankingButton;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text totalScoreText;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text scoreDetailTitleText;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text scoreDetailText;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text levelText;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text rankName;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image rankImage;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject staffInfoObj;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject homeButton;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Collider[] buttonCols;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isHiding;

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xD00490", Offset = "0xD00490", VA = "0xD00490")]
	private void Start()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xD00548", Offset = "0xD00548", VA = "0xD00548")]
	private void Update()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0xD008D0", Offset = "0xD008D0", VA = "0xD008D0")]
	private void SetHiding(bool isHide)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xD00A18", Offset = "0xD00A18", VA = "0xD00A18")]
	public void Show()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0xD00A44", Offset = "0xD00A44", VA = "0xD00A44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8578", Offset = "0x9C8578")]
	private IEnumerator ShowRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xD00AEC", Offset = "0xD00AEC", VA = "0xD00AEC")]
	private void SetRank()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xD00454", Offset = "0xD00454", VA = "0xD00454")]
	public void Close()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xD00F78", Offset = "0xD00F78", VA = "0xD00F78")]
	public ResultManager()
	{
	}
}
[Token(Token = "0x20000DE")]
public class SingleOrderUi : SingletonMonoBehaviour<SingleOrderUi>
{
	[Token(Token = "0x20001C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF118", Offset = "0x9BF118")]
	private sealed class <AnimationRoutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SingleOrderUi <>4__this;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 startPos;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <duration>5__3;

		[Token(Token = "0x1700008E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0xD0D028", Offset = "0xD0D028", VA = "0xD0D028", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0xD0D090", Offset = "0xD0D090", VA = "0xD0D090", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD0C7F0", Offset = "0xD0C7F0", VA = "0xD0C7F0")]
		[DebuggerHidden]
		public <AnimationRoutine>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD0C86C", Offset = "0xD0C86C", VA = "0xD0C86C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD0C870", Offset = "0xD0C870", VA = "0xD0C870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD0D030", Offset = "0xD0D030", VA = "0xD0D030", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C357C", Offset = "0x9C357C")]
	[SerializeField]
	private int chairNum;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C35C8", Offset = "0x9C35C8")]
	[SerializeField]
	private TextMeshProUGUI chairNumText;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image profileImage;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject extraNoodle;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI noodleHardnessText;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image meatImage;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image leekImage;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image secretTareImage;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image beerImage;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image riceImage;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C36A4", Offset = "0x9C36A4")]
	[SerializeField]
	private Transform sphereTf;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject uiRoot;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ParticleSystem particle;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isHiding;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Animator animator;

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xD0C02C", Offset = "0xD0C02C", VA = "0xD0C02C")]
	private void Start()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xD0C0A4", Offset = "0xD0C0A4", VA = "0xD0C0A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xD0C134", Offset = "0xD0C134", VA = "0xD0C134")]
	private void SetHiding(bool isHide)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xD0C27C", Offset = "0xD0C27C", VA = "0xD0C27C")]
	private void UpdateUiContent()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xD0C6F0", Offset = "0xD0C6F0", VA = "0xD0C6F0")]
	public void StartAnimation(Vector3 startPos, int chair)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xD0C750", Offset = "0xD0C750", VA = "0xD0C750")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C85DC", Offset = "0x9C85DC")]
	private IEnumerator AnimationRoutine(Vector3 startPos)
	{
		return null;
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xD0C81C", Offset = "0xD0C81C", VA = "0xD0C81C")]
	public SingleOrderUi()
	{
	}
}
[Token(Token = "0x20000DF")]
public class StandPosManager : SingletonMonoBehaviour<StandPosManager>
{
	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Vector3 initPos;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static Vector3 initHeadPos;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static float heightOffset;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3710", Offset = "0x9C3710")]
	public bool initialReseted;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3748", Offset = "0x9C3748")]
	public Transform defaultPosTf;

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xD379C8", Offset = "0xD379C8", VA = "0xD379C8")]
	public void MoveDefaultPosition()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xD37C80", Offset = "0xD37C80", VA = "0xD37C80")]
	public void RotateDefaultRotation()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xD37F7C", Offset = "0xD37F7C", VA = "0xD37F7C")]
	public StandPosManager()
	{
	}
}
[Token(Token = "0x20000E0")]
public class TextFPSCounter : MonoBehaviour
{
	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool show;

	[Token(Token = "0x400054D")]
	private const int targetFPS = 60;

	[Token(Token = "0x400054E")]
	private const float updateInterval = 0.5f;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int framesCount;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float framesTime;

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xD3CCFC", Offset = "0xD3CCFC", VA = "0xD3CCFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xD3CDB0", Offset = "0xD3CDB0", VA = "0xD3CDB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xD3CFC4", Offset = "0xD3CFC4", VA = "0xD3CFC4")]
	public TextFPSCounter()
	{
	}
}
[Token(Token = "0x20000E1")]
public class TitleHumanSpawner : MonoBehaviour
{
	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3780", Offset = "0x9C3780")]
	[SerializeField]
	private float spawnInterval;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] humanPfs;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PositionItem[] positionItems;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float nextSpawnTime;

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xD3E054", Offset = "0xD3E054", VA = "0xD3E054")]
	private void Update()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xD3E094", Offset = "0xD3E094", VA = "0xD3E094")]
	private void Spawn()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0xD3E378", Offset = "0xD3E378", VA = "0xD3E378")]
	public TitleHumanSpawner()
	{
	}
}
[Serializable]
[Token(Token = "0x20000E2")]
public struct PositionItem
{
	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Transform spawnPosTf;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Transform goalPosTf;
}
[Token(Token = "0x20000E3")]
public class ToolController : MonoBehaviour
{
	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C37EC", Offset = "0x9C37EC")]
	[SerializeField]
	private GameObject teboObj;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject soupLadleObj;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject chopsticksObj;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject leekRengeObj;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject tareHishakuObj;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject shamojiObj;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject refillPlateObj;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject trayObj;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject spongeObj;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C38B8", Offset = "0x9C38B8")]
	[SerializeField]
	private GrabSpawner rawNoodleSpawner;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GrabSpawner ramenBowlSpawner;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GrabSpawner subBowlSpawner;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GrabSpawner beerMugSpawner;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GrabSpawner riceBowlSpawner;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GrabSpawner rengeSpawner;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private BeerServerHandle[] beerServerHandles;

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xD3F54C", Offset = "0xD3F54C", VA = "0xD3F54C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8640", Offset = "0x9C8640")]
	private void Detect()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xD3F85C", Offset = "0xD3F85C", VA = "0xD3F85C")]
	public void DisableAll()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0xD3F9DC", Offset = "0xD3F9DC", VA = "0xD3F9DC")]
	public void SetToolActive(TutorialManager.Step step)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0xD3FB8C", Offset = "0xD3FB8C", VA = "0xD3FB8C")]
	public ToolController()
	{
	}
}
[Token(Token = "0x20000E4")]
public class TutorialManager : SingletonMonoBehaviour<TutorialManager>
{
	[Token(Token = "0x20001CA")]
	public enum Step
	{
		[Token(Token = "0x4000A65")]
		None,
		[Token(Token = "0x4000A66")]
		Order_TabletCall,
		[Token(Token = "0x4000A67")]
		Order_Move,
		[Token(Token = "0x4000A68")]
		Order_TakeOrderSheet,
		[Token(Token = "0x4000A69")]
		Order_CheckOrderData,
		[Token(Token = "0x4000A6A")]
		Order_Complete,
		[Token(Token = "0x4000A6B")]
		Order_OrderDataExplain,
		[Token(Token = "0x4000A6C")]
		Order_ShowOrderList,
		[Token(Token = "0x4000A6D")]
		RamenCook_ShowOrderList,
		[Token(Token = "0x4000A6E")]
		RamenCook_PourSoup,
		[Token(Token = "0x4000A6F")]
		RamenCook_BoilAndPutNoodle,
		[Token(Token = "0x4000A70")]
		RamenCook_PutMeat,
		[Token(Token = "0x4000A71")]
		RamenCook_PutLeek,
		[Token(Token = "0x4000A72")]
		RamenCook_PutSecretTare,
		[Token(Token = "0x4000A73")]
		RamenCook_PutRenge,
		[Token(Token = "0x4000A74")]
		RamenCook_Serving,
		[Token(Token = "0x4000A75")]
		RamenCook_Bow,
		[Token(Token = "0x4000A76")]
		RamenCook_DownNoren,
		[Token(Token = "0x4000A77")]
		RamenCook_Complete,
		[Token(Token = "0x4000A78")]
		RamenCook_ToppingTips,
		[Token(Token = "0x4000A79")]
		SideMenu_MoveBeerServer,
		[Token(Token = "0x4000A7A")]
		SideMenu_PullBeerLever,
		[Token(Token = "0x4000A7B")]
		SideMenu_BeerMugOnTray,
		[Token(Token = "0x4000A7C")]
		SideMenu_MoveRiceCooker,
		[Token(Token = "0x4000A7D")]
		SideMenu_PutRice,
		[Token(Token = "0x4000A7E")]
		SideMenu_RiceBowlOnTray,
		[Token(Token = "0x4000A7F")]
		SideMenu_Serving,
		[Token(Token = "0x4000A80")]
		SideMenu_Bow,
		[Token(Token = "0x4000A81")]
		SideMenu_DownNoren,
		[Token(Token = "0x4000A82")]
		SideMenu_Complete,
		[Token(Token = "0x4000A83")]
		SideMenu_Tips,
		[Token(Token = "0x4000A84")]
		Refill_TakeOrderSheet,
		[Token(Token = "0x4000A85")]
		Refill_CheckOrderData,
		[Token(Token = "0x4000A86")]
		Refill_ServingPlate,
		[Token(Token = "0x4000A87")]
		Refill_ServingRamen,
		[Token(Token = "0x4000A88")]
		Refill_TabletCall,
		[Token(Token = "0x4000A89")]
		Refill_CheckOrderList,
		[Token(Token = "0x4000A8A")]
		Refill_MakeRefillBowl,
		[Token(Token = "0x4000A8B")]
		Refill_ServingRefillBowl,
		[Token(Token = "0x4000A8C")]
		Refill_Bow,
		[Token(Token = "0x4000A8D")]
		Refill_DownNoren,
		[Token(Token = "0x4000A8E")]
		Refill_Complete,
		[Token(Token = "0x4000A8F")]
		Wash_TabletCall,
		[Token(Token = "0x4000A90")]
		Wash_MoveToCounter,
		[Token(Token = "0x4000A91")]
		Wash_TakeDirtyDish,
		[Token(Token = "0x4000A92")]
		Wash_MoveToWasher,
		[Token(Token = "0x4000A93")]
		Wash_CleanDish,
		[Token(Token = "0x4000A94")]
		Wash_DishPutOnTray,
		[Token(Token = "0x4000A95")]
		Wash_Complete
	}

	[Token(Token = "0x20001CB")]
	public enum Page
	{
		[Token(Token = "0x4000A97")]
		Controller,
		[Token(Token = "0x4000A98")]
		Order,
		[Token(Token = "0x4000A99")]
		Cook,
		[Token(Token = "0x4000A9A")]
		Cook_Ramen,
		[Token(Token = "0x4000A9B")]
		Cook_Side,
		[Token(Token = "0x4000A9C")]
		Cook_Refill,
		[Token(Token = "0x4000A9D")]
		Wash
	}

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3964", Offset = "0x9C3964")]
	public bool isTutorial;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Step currentStep;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject activeCustomer;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isPointerEnable;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C399C", Offset = "0x9C399C")]
	[SerializeField]
	private AudioClip nextStepSound;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip completeSound;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject customerPf;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform customerSpawnPos;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform tutorialBeerPos;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject naviCanvasRoot;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject mainMenu;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject control;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject order;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject cookMain;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject ramenCook;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject sideMenu;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject noodleRefill;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject wash;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject[] completeMarkObjects;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3AB8", Offset = "0x9C3AB8")]
	public TutorialOrder tutorialOrder;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TutorialRamenCook tutorialRamenCook;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TutorialSideMenu tutorialSideMenu;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TutorialNoodleRefill tutorialNoodleRefill;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public TutorialWash tutorialWash;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	public ChairItem chairItem;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool isHiding;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ToolController toolController;

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xD43E88", Offset = "0xD43E88", VA = "0xD43E88")]
	private void Start()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xD44370", Offset = "0xD44370", VA = "0xD44370")]
	private void Update()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0xD4445C", Offset = "0xD4445C", VA = "0xD4445C")]
	private void SetHiding(bool isHide)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xD441D0", Offset = "0xD441D0", VA = "0xD441D0")]
	private void SetCompleteMark()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xD4471C", Offset = "0xD4471C", VA = "0xD4471C")]
	public void SetComplete(Page category)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xD44964", Offset = "0xD44964", VA = "0xD44964")]
	public void OpenPage(Page page)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xD45494", Offset = "0xD45494", VA = "0xD45494")]
	private void SpawnCustomer()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xD383BC", Offset = "0xD383BC", VA = "0xD383BC")]
	public void ClearTutorialStep(Step clearStep, bool isPlaySound = true)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xD43FCC", Offset = "0xD43FCC", VA = "0xD43FCC")]
	private void StartTutorial()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xD45AE8", Offset = "0xD45AE8", VA = "0xD45AE8")]
	public void CloseAll()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xD453D8", Offset = "0xD453D8", VA = "0xD453D8")]
	private void CloseAllPage()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xD4598C", Offset = "0xD4598C", VA = "0xD4598C")]
	public void ShowMenu(bool isFirstTime = false)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xD45594", Offset = "0xD45594", VA = "0xD45594")]
	public void ResetCustomer()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xD45DFC", Offset = "0xD45DFC", VA = "0xD45DFC")]
	public TutorialManager()
	{
	}
}
[Token(Token = "0x20000E5")]
public class WaveManager : SingletonMonoBehaviour<WaveManager>
{
	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3B00", Offset = "0x9C3B00")]
	public ObscuredInt currentWave;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3B38", Offset = "0x9C3B38")]
	public ExtraPeakTime extraPeakTime;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WaveItem[] waveItems;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ObscuredFloat nextCheckTime;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float openCountDownTime;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isOpenCountDownPlayed;

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x192B690", Offset = "0x192B690", VA = "0x192B690")]
	private void Start()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x192BA80", Offset = "0x192BA80", VA = "0x192BA80")]
	public void Update()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x192B7EC", Offset = "0x192B7EC", VA = "0x192B7EC")]
	private void CalcSpawnCountRemain()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x192C660", Offset = "0x192C660", VA = "0x192C660")]
	public bool IsPeakTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x192C710", Offset = "0x192C710", VA = "0x192C710")]
	public bool IsLunchTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x192BDF4", Offset = "0x192BDF4", VA = "0x192BDF4")]
	private void StartWave(int waveNum)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x192C4B0", Offset = "0x192C4B0", VA = "0x192C4B0")]
	private void Spawn(int itemIdx)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x192C7C0", Offset = "0x192C7C0", VA = "0x192C7C0")]
	public int GetCurrentWaveSpawnRemain()
	{
		return default(int);
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x192C844", Offset = "0x192C844", VA = "0x192C844")]
	public WaveManager()
	{
	}
}
[Serializable]
[Token(Token = "0x20000E6")]
public struct WaveItem
{
	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ObscuredBool isLunchTime;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ObscuredBool isPeakTime;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ObscuredInt startTimeHour;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ObscuredInt startTimeMinutes;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ObscuredInt spawnCountRemain;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ObscuredFloat nextInterval;
}
[Token(Token = "0x20000E7")]
[ExecuteAlways]
public class BeerMug : CookBase
{
	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3B70", Offset = "0x9C3B70")]
	public ObscuredInt currentLiquid;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public ObscuredFloat targetLiquidFillRate;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public ObscuredFloat liquidFillRate;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3BA8", Offset = "0x9C3BA8")]
	[SerializeField]
	private ParticleSystem beerBubbleParticle;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject beerLiquidObj;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private SkinnedMeshRenderer beerMeshRenderer;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3C14", Offset = "0x9C3C14")]
	[SerializeField]
	private AnimationCurve scaleAnimCurve;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private AnimationCurve blendShapeCurve;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ObscuredInt maxLiquid;

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xEBC460", Offset = "0xEBC460", VA = "0xEBC460")]
	private void Start()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xEBC4EC", Offset = "0xEBC4EC", VA = "0xEBC4EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xEBC168", Offset = "0xEBC168", VA = "0xEBC168")]
	public void AddBeerLiquid()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xEBC778", Offset = "0xEBC778", VA = "0xEBC778")]
	public void SetFullFill()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xEBC858", Offset = "0xEBC858", VA = "0xEBC858")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xEBC990", Offset = "0xEBC990", VA = "0xEBC990")]
	public BeerMug()
	{
	}
}
[Token(Token = "0x20000E8")]
public class CollisionStackRecovery : MonoBehaviour
{
	[Token(Token = "0x20001CC")]
	public enum RecoveryType
	{
		[Token(Token = "0x4000A9F")]
		Destroy,
		[Token(Token = "0x4000AA0")]
		ReturnSpawnPos
	}

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3C70", Offset = "0x9C3C70")]
	[SerializeField]
	private float recoveryTimeRemain;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isStayWater;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3CCC", Offset = "0x9C3CCC")]
	[SerializeField]
	private RecoveryType recoveryType;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float recoveryTime;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 initPos;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion initRot;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int checkedFrame;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Rigidbody rb;

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xEC42C8", Offset = "0xEC42C8", VA = "0xEC42C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xEC439C", Offset = "0xEC439C", VA = "0xEC439C")]
	private void Update()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xEC43F0", Offset = "0xEC43F0", VA = "0xEC43F0")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xEC4484", Offset = "0xEC4484", VA = "0xEC4484")]
	private void Recovery()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xEC45D0", Offset = "0xEC45D0", VA = "0xEC45D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xEC467C", Offset = "0xEC467C", VA = "0xEC467C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xEC4724", Offset = "0xEC4724", VA = "0xEC4724")]
	public CollisionStackRecovery()
	{
	}
}
[Token(Token = "0x20000E9")]
public class DestroyTimer : MonoBehaviour
{
	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float time;

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x1D492A8", Offset = "0x1D492A8", VA = "0x1D492A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x1D49334", Offset = "0x1D49334", VA = "0x1D49334")]
	public DestroyTimer()
	{
	}
}
[Token(Token = "0x20000EA")]
public class DirtyDish : MonoBehaviour
{
	[Token(Token = "0x20001CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF128", Offset = "0x9BF128")]
	private sealed class <LifeTimeRoutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DirtyDish <>4__this;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000090")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x1D4B254", Offset = "0x1D4B254", VA = "0x1D4B254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1D4B2BC", Offset = "0x1D4B2BC", VA = "0x1D4B2BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1D4AC88", Offset = "0x1D4AC88", VA = "0x1D4AC88")]
		[DebuggerHidden]
		public <LifeTimeRoutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1D4B098", Offset = "0x1D4B098", VA = "0x1D4B098", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1D4B09C", Offset = "0x1D4B09C", VA = "0x1D4B09C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1D4B25C", Offset = "0x1D4B25C", VA = "0x1D4B25C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3D38", Offset = "0x9C3D38")]
	public ObscuredBool isWashCompleted;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ObscuredBool isWetted;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ObscuredInt chairNum;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public ObscuredBool withExtraNoodle;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ObscuredFloat meatGoodRate;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ObscuredFloat leekGoodRate;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ObscuredBool isRamenOverLifeTime;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public ObscuredBool isBowed;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public ObscuredFloat dirtyRemaining;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3D70", Offset = "0x9C3D70")]
	[SerializeField]
	private CookBase.DishType dishType;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject dissolveDish;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private MeshRenderer dirtMeshRenderer;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private float dirtEndThreshold;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private ParticleSystem completeEffect;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool isDissolving;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float dirtStartThreshold;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ObscuredFloat lifeTime;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool isGrabFirstTime;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Coroutine lifeTimeRoutine;

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x1D4A588", Offset = "0x1D4A588", VA = "0x1D4A588")]
	private void Start()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x1D4A638", Offset = "0x1D4A638", VA = "0x1D4A638")]
	private void Update()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x1D4A7F4", Offset = "0x1D4A7F4", VA = "0x1D4A7F4")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1D4A63C", Offset = "0x1D4A63C", VA = "0x1D4A63C")]
	private void CheckGrabEnable()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x1D4AC0C", Offset = "0x1D4AC0C", VA = "0x1D4AC0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8678", Offset = "0x9C8678")]
	private IEnumerator LifeTimeRoutine()
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x1D4ACB4", Offset = "0x1D4ACB4", VA = "0x1D4ACB4")]
	public void SetWetting()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x1D4ACE4", Offset = "0x1D4ACE4", VA = "0x1D4ACE4")]
	public void Washing(ObscuredFloat washValue)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x1D4AF04", Offset = "0x1D4AF04", VA = "0x1D4AF04")]
	public void WashComplete()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x1D4A8E4", Offset = "0x1D4A8E4", VA = "0x1D4A8E4")]
	public void DishDissolve()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x1D4B024", Offset = "0x1D4B024", VA = "0x1D4B024")]
	public DirtyDish()
	{
	}
}
[Token(Token = "0x20000EB")]
public class LadleSecretTareRefillPoint : MonoBehaviour
{
	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolLadleLiquid toolLadleLiquid;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x1D59638", Offset = "0x1D59638", VA = "0x1D59638")]
	private void Start()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x1D59698", Offset = "0x1D59698", VA = "0x1D59698")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x1D59758", Offset = "0x1D59758", VA = "0x1D59758")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1D59818", Offset = "0x1D59818", VA = "0x1D59818")]
	public LadleSecretTareRefillPoint()
	{
	}
}
[Token(Token = "0x20000EC")]
public class LadleSoupRefillPoint : MonoBehaviour
{
	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolLadleLiquid toolLadleSoup;

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x1D59820", Offset = "0x1D59820", VA = "0x1D59820")]
	private void Start()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x1D59880", Offset = "0x1D59880", VA = "0x1D59880")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x1D59998", Offset = "0x1D59998", VA = "0x1D59998")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x1D59A58", Offset = "0x1D59A58", VA = "0x1D59A58")]
	public LadleSoupRefillPoint()
	{
	}
}
[Token(Token = "0x20000ED")]
public class OrderSheet : GrabReactor
{
	[Token(Token = "0x20001CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF138", Offset = "0x9BF138")]
	private sealed class <LifeTimeRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OrderSheet <>4__this;

		[Token(Token = "0x17000092")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0xDC0A84", Offset = "0xDC0A84", VA = "0xDC0A84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0xDC0AEC", Offset = "0xDC0AEC", VA = "0xDC0AEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xDC0628", Offset = "0xDC0628", VA = "0xDC0628")]
		[DebuggerHidden]
		public <LifeTimeRoutine>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xDC097C", Offset = "0xDC097C", VA = "0xDC097C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xDC0980", Offset = "0xDC0980", VA = "0xDC0980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xDC0A8C", Offset = "0xDC0A8C", VA = "0xDC0A8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3DFC", Offset = "0x9C3DFC")]
	public ObscuredInt chairNum;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3E34", Offset = "0x9C3E34")]
	[SerializeField]
	private GameObject softNoodle;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject normalNoodle;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject hardNoodle;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject withoutLeek;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject withLeek;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject withoutMeat;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject withMeat;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject withoutSecretTare;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject withSecretTare;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject beerTicket;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject riceTicket;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject extraNoodleTicket;

	[Token(Token = "0x40005C5")]
	public const float LIFE_TIME = 2f;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xDC0100", Offset = "0xDC0100", VA = "0xDC0100", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xDC0180", Offset = "0xDC0180", VA = "0xDC0180")]
	private void ClearCheckMark()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xDC0214", Offset = "0xDC0214", VA = "0xDC0214")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C86DC", Offset = "0x9C86DC")]
	public void ForceReaction()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xDC02AC", Offset = "0xDC02AC", VA = "0xDC02AC", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xDC05AC", Offset = "0xDC05AC", VA = "0xDC05AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8714", Offset = "0x9C8714")]
	private IEnumerator LifeTimeRoutine()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xDC0654", Offset = "0xDC0654", VA = "0xDC0654")]
	public void SetChairNum(int value)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xDC0974", Offset = "0xDC0974", VA = "0xDC0974")]
	public OrderSheet()
	{
	}
}
[Token(Token = "0x20000EE")]
public class OrderSheetDissolve : MonoBehaviour
{
	[Token(Token = "0x20001CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF148", Offset = "0x9BF148")]
	private sealed class <ScaleRoutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OrderSheetDissolve <>4__this;

		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x17000094")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0xDC1600", Offset = "0xDC1600", VA = "0xDC1600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0xDC1668", Offset = "0xDC1668", VA = "0xDC1668", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xDC0C30", Offset = "0xDC0C30", VA = "0xDC0C30")]
		[DebuggerHidden]
		public <ScaleRoutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xDC1068", Offset = "0xDC1068", VA = "0xDC1068", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xDC106C", Offset = "0xDC106C", VA = "0xDC106C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xDC1608", Offset = "0xDC1608", VA = "0xDC1608", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF158", Offset = "0x9BF158")]
	private sealed class <DissolveRoutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OrderSheetDissolve <>4__this;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <duration>5__3;

		[Token(Token = "0x17000096")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0xDC0FF8", Offset = "0xDC0FF8", VA = "0xDC0FF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0xDC1060", Offset = "0xDC1060", VA = "0xDC1060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xDC0CD8", Offset = "0xDC0CD8", VA = "0xDC0CD8")]
		[DebuggerHidden]
		public <DissolveRoutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xDC0D24", Offset = "0xDC0D24", VA = "0xDC0D24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xDC0D28", Offset = "0xDC0D28", VA = "0xDC0D28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xDC1000", Offset = "0xDC1000", VA = "0xDC1000", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3F30", Offset = "0x9C3F30")]
	[SerializeField]
	private AnimationCurve sheetScaleCurve;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve dissolveCurve;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C3F8C", Offset = "0x9C3F8C")]
	[SerializeField]
	private Transform sphereTf;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform sheetRootTf;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material dissolveMat;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem particle;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private MeshRenderer[] meshRenderers;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float maxSphereScale;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float minSphereScale;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float cutoffStartValue;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float cutoffEndValue;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AudioSource audioSource;

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xDC0AF4", Offset = "0xDC0AF4", VA = "0xDC0AF4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8778", Offset = "0x9C8778")]
	private void Detect()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xDC0B54", Offset = "0xDC0B54", VA = "0xDC0B54")]
	private void Start()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xDC0A58", Offset = "0xDC0A58", VA = "0xDC0A58")]
	public void StartAnimation()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xDC0BB4", Offset = "0xDC0BB4", VA = "0xDC0BB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C87B0", Offset = "0x9C87B0")]
	private IEnumerator ScaleRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xDC0C5C", Offset = "0xDC0C5C", VA = "0xDC0C5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8814", Offset = "0x9C8814")]
	private IEnumerator DissolveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xDC0D04", Offset = "0xDC0D04", VA = "0xDC0D04")]
	public OrderSheetDissolve()
	{
	}
}
[Token(Token = "0x20000EF")]
public class RamenBowlKaedama : MonoBehaviour
{
	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] noodleObjects;

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xCFEBB8", Offset = "0xCFEBB8", VA = "0xCFEBB8")]
	public void RefillNoodle()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xCFEC28", Offset = "0xCFEC28", VA = "0xCFEC28")]
	public RamenBowlKaedama()
	{
	}
}
[Token(Token = "0x20000F0")]
public class RamenParticleDetector : MonoBehaviour
{
	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RamenBowl ramenBowl;

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xCFF1BC", Offset = "0xCFF1BC", VA = "0xCFF1BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xCFF21C", Offset = "0xCFF21C", VA = "0xCFF21C")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xCFF340", Offset = "0xCFF340", VA = "0xCFF340")]
	public RamenParticleDetector()
	{
	}
}
[Token(Token = "0x20000F1")]
public class RengeLeekRefillPoint : MonoBehaviour
{
	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolRengeForLeek rengeForLeek;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xD00068", Offset = "0xD00068", VA = "0xD00068")]
	private void Start()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0xD000C8", Offset = "0xD000C8", VA = "0xD000C8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0xD00188", Offset = "0xD00188", VA = "0xD00188")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xD00248", Offset = "0xD00248", VA = "0xD00248")]
	public RengeLeekRefillPoint()
	{
	}
}
[Token(Token = "0x20000F2")]
public class SubBowl : CookBase
{
	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4028", Offset = "0x9C4028")]
	public ObscuredBool isOnNoodle;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public NoodleState.HardnessStep noodleHardness;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4060", Offset = "0x9C4060")]
	[SerializeField]
	private GameObject noodleObj;

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xD38204", Offset = "0xD38204", VA = "0xD38204")]
	private void Start()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xD38224", Offset = "0xD38224", VA = "0xD38224")]
	public void SetNoodle(NoodleState.HardnessStep hardness)
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xD389D0", Offset = "0xD389D0", VA = "0xD389D0")]
	public SubBowl()
	{
	}
}
[Token(Token = "0x20000F3")]
public class TeboBoilPoint : MonoBehaviour
{
	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolTebo toolTebo;

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xD3B9B4", Offset = "0xD3B9B4", VA = "0xD3B9B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xD3BA14", Offset = "0xD3BA14", VA = "0xD3BA14")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xD3BB64", Offset = "0xD3BB64", VA = "0xD3BB64")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xD3BC64", Offset = "0xD3BC64", VA = "0xD3BC64")]
	public TeboBoilPoint()
	{
	}
}
[Token(Token = "0x20000F4")]
public class TeboDetector : MonoBehaviour
{
	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolTebo toolTebo;

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xD3BC6C", Offset = "0xD3BC6C", VA = "0xD3BC6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xD3BCCC", Offset = "0xD3BCCC", VA = "0xD3BCCC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xD3C0AC", Offset = "0xD3C0AC", VA = "0xD3C0AC")]
	public TeboDetector()
	{
	}
}
[Token(Token = "0x20000F5")]
public class TeboYugiri : MonoBehaviour
{
	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C40AC", Offset = "0x9C40AC")]
	[SerializeField]
	private ParticleSystem yugiriEffect;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ToolTebo toolTebo;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isTriggered;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float triggerVelocityY;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float stopVelocity;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource audioSource;

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xD3C0B4", Offset = "0xD3C0B4", VA = "0xD3C0B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xD3C15C", Offset = "0xD3C15C", VA = "0xD3C15C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xD3C310", Offset = "0xD3C310", VA = "0xD3C310")]
	public TeboYugiri()
	{
	}
}
[Token(Token = "0x20000F6")]
public class ToolChopsticks : GrabReactorTriggerBase
{
	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C40F8", Offset = "0x9C40F8")]
	[SerializeField]
	private Transform grabPosTf;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private SkinnedMeshRenderer chopsticksRenderer;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float maxShapeValue;

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xD3EDB8", Offset = "0xD3EDB8", VA = "0xD3EDB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xD3EE18", Offset = "0xD3EE18", VA = "0xD3EE18")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xD3EEBC", Offset = "0xD3EEBC", VA = "0xD3EEBC")]
	private void SetBlendShape()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xD3EFC4", Offset = "0xD3EFC4", VA = "0xD3EFC4")]
	private void CheckGrabbableNearest()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xD3F164", Offset = "0xD3F164", VA = "0xD3F164")]
	private void CheckReleaseObject()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xD3F460", Offset = "0xD3F460", VA = "0xD3F460", Slot = "6")]
	protected override void SetToFitPos()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xD3F53C", Offset = "0xD3F53C", VA = "0xD3F53C")]
	public ToolChopsticks()
	{
	}
}
[Token(Token = "0x20000F7")]
public class ToolHolder : MonoBehaviour
{
	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4154", Offset = "0x9C4154")]
	[SerializeField]
	private float returnTimeRemain;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isOut;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C41B0", Offset = "0x9C41B0")]
	public GameObject targetObject;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject targetObjectPref;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float returnTime;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool destroyWhenReturnPos;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool isCountActive;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	private bool isKinematic;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 initToolPosition;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion initToolRotation;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float isOutTimeRemain;

	[Token(Token = "0x40005F1")]
	private const float IS_OUT_TIME = 1f;

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xD3FB94", Offset = "0xD3FB94", VA = "0xD3FB94")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xD3FD30", Offset = "0xD3FD30", VA = "0xD3FD30")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xD3FF68", Offset = "0xD3FF68", VA = "0xD3FF68")]
	private void OutCheck()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xD3FE64", Offset = "0xD3FE64", VA = "0xD3FE64")]
	private void CountDown()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xD402A4", Offset = "0xD402A4", VA = "0xD402A4")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xD403C8", Offset = "0xD403C8", VA = "0xD403C8")]
	private void ResetOutTimeRemain()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xD3FD24", Offset = "0xD3FD24", VA = "0xD3FD24")]
	public void ResetReturnTime()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xD40008", Offset = "0xD40008", VA = "0xD40008")]
	public void ReturnPosition()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xD40178", Offset = "0xD40178", VA = "0xD40178")]
	private void InstantiateToPosition()
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xD403D4", Offset = "0xD403D4", VA = "0xD403D4")]
	public ToolHolder()
	{
	}
}
[Token(Token = "0x20000F8")]
public class ToolHolderDetector : MonoBehaviour
{
	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float radius;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GrabbableItem grabbable;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool preGrabbed;

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xD403E4", Offset = "0xD403E4", VA = "0xD403E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xD40444", Offset = "0xD40444", VA = "0xD40444")]
	private void Update()
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xD40494", Offset = "0xD40494", VA = "0xD40494")]
	private void CheckNearToolHolder()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xD405D8", Offset = "0xD405D8", VA = "0xD405D8")]
	public ToolHolderDetector()
	{
	}
}
[Token(Token = "0x20000F9")]
public class ToolKaedamaPlate : GrabReactor
{
	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4208", Offset = "0x9C4208")]
	public ObscuredInt chairNum;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4240", Offset = "0x9C4240")]
	public NoodleState.HardnessStep hardness;

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xD405EC", Offset = "0xD405EC", VA = "0xD405EC", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xD405F4", Offset = "0xD405F4", VA = "0xD405F4")]
	public void SetChairNum(int num)
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xD40638", Offset = "0xD40638", VA = "0xD40638")]
	public ToolKaedamaPlate()
	{
	}
}
[Token(Token = "0x20000FA")]
public class ToolLadleLiquid : MonoBehaviour
{
	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4278", Offset = "0x9C4278")]
	public ObscuredBool isFillLiquid;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ObscuredFloat liquidRemain;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C42B0", Offset = "0x9C42B0")]
	[SerializeField]
	private ParticleSystem liquidParticle;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PouringPosAnchor pouringAnchor;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject liquidSurface;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ObscuredFloat maxLiquidRemain;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Rigidbody rb;

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xD40640", Offset = "0xD40640", VA = "0xD40640")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xD40700", Offset = "0xD40700", VA = "0xD40700")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xD406A8", Offset = "0xD406A8", VA = "0xD406A8")]
	public void RefillLiquid()
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xD40848", Offset = "0xD40848", VA = "0xD40848")]
	public ToolLadleLiquid()
	{
	}
}
[Token(Token = "0x20000FB")]
public class ToolRengeForLeek : MonoBehaviour
{
	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C431C", Offset = "0x9C431C")]
	public ObscuredBool isHoldLeek;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject spawnedLeek;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject activeLeekObj;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4354", Offset = "0x9C4354")]
	[SerializeField]
	private Transform leekPosTf;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject spawnLeekPf;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PouringPosAnchor pouringAnchor;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform spawnPosTf;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xD40898", Offset = "0xD40898", VA = "0xD40898")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xD408F8", Offset = "0xD408F8", VA = "0xD408F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xD40968", Offset = "0xD40968", VA = "0xD40968")]
	private void ReleaseLeek()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xD40A3C", Offset = "0xD40A3C", VA = "0xD40A3C")]
	public void RefillLeek()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xD40C04", Offset = "0xD40C04", VA = "0xD40C04")]
	public ToolRengeForLeek()
	{
	}
}
[Token(Token = "0x20000FC")]
public class ToolShamoji : MonoBehaviour
{
	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C43D0", Offset = "0x9C43D0")]
	public ObscuredBool isHoldRice;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4408", Offset = "0x9C4408")]
	[SerializeField]
	private GameObject riceObj;

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xD40C0C", Offset = "0xD40C0C", VA = "0xD40C0C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xD40C10", Offset = "0xD40C10", VA = "0xD40C10")]
	public void RefillRice()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xD33B98", Offset = "0xD33B98", VA = "0xD33B98")]
	public void UseRice()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xD40C58", Offset = "0xD40C58", VA = "0xD40C58")]
	public ToolShamoji()
	{
	}
}
[Token(Token = "0x20000FD")]
public class ToolShamojiTip : MonoBehaviour
{
	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ToolShamoji toolShamoji;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xD40C60", Offset = "0xD40C60", VA = "0xD40C60")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xD40D14", Offset = "0xD40D14", VA = "0xD40D14")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xD40E20", Offset = "0xD40E20", VA = "0xD40E20")]
	public ToolShamojiTip()
	{
	}
}
[Token(Token = "0x20000FE")]
public class ToolSponge : MonoBehaviour
{
	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem bubbleEffect;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioSource washAudioSource;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float effectStopTime;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float effectDuration;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float washSoundVelocity;

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xD40E28", Offset = "0xD40E28", VA = "0xD40E28")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xD40E88", Offset = "0xD40E88", VA = "0xD40E88")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xD412A0", Offset = "0xD412A0", VA = "0xD412A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xD41304", Offset = "0xD41304", VA = "0xD41304")]
	private void PlayWashSound()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xD41168", Offset = "0xD41168", VA = "0xD41168")]
	private void Wash(DirtyDish dirtyDish, ObscuredFloat magnitude)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xD41360", Offset = "0xD41360", VA = "0xD41360")]
	public ToolSponge()
	{
	}
}
[Token(Token = "0x20000FF")]
public class ToolTebo : MonoBehaviour
{
	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4474", Offset = "0x9C4474")]
	[SerializeField]
	private float angleValue;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ObscuredBool isKeepNoodle;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ObscuredBool isStayBoilArea;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private NoodleState.HardnessStep hardnessStep;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ObscuredFloat currentBoilTime;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C44E0", Offset = "0x9C44E0")]
	[SerializeField]
	private GameObject noodleObj;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject noodleBoiledPf;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform angleCheckTf;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AudioSource boilAudioSource;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C455C", Offset = "0x9C455C")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private TextMeshProUGUI hardnessText;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image boilGaugeImage;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Color hardColor;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color normalColor;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color softColor;

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xD41374", Offset = "0xD41374", VA = "0xD41374")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xD413EC", Offset = "0xD413EC", VA = "0xD413EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xD41430", Offset = "0xD41430", VA = "0xD41430")]
	private void CheckSpawnBoiledNoodle()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xD3BF10", Offset = "0xD3BF10", VA = "0xD3BF10")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8878", Offset = "0x9C8878")]
	public void SetRawNoodle()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xD3C03C", Offset = "0xD3C03C", VA = "0xD3C03C")]
	public void SetNoodle(NoodleState.HardnessStep hardness, ObscuredFloat boilTime)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xD3BB00", Offset = "0xD3BB00", VA = "0xD3BB00")]
	public void EnterBoilArea()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xD3BC20", Offset = "0xD3BC20", VA = "0xD3BC20")]
	public void ExitBoilArea()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xD417A4", Offset = "0xD417A4", VA = "0xD417A4")]
	public void DoBoil()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xD41A14", Offset = "0xD41A14", VA = "0xD41A14")]
	private void UpdateBoilStateUi()
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xD42240", Offset = "0xD42240", VA = "0xD42240")]
	public ToolTebo()
	{
	}
}
[Token(Token = "0x2000100")]
public class ToolTray : MonoBehaviour
{
	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C45F8", Offset = "0x9C45F8")]
	public List<int> orderMatchChairNumList;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> collisionStayObjList;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> holdingObjList;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4630", Offset = "0x9C4630")]
	public int trayNum;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ToolHolder toolHolder;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform beerFitPosTf;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform ramenBowlFitPosTf;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform riceBowlFitPosTf;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public InteractionObject riceBowlReleaseInteractionObj;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InteractionObject beerMugReleaseInteractionObj;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float nextCheckTime;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float checkInterval;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int lastCollisionCheckFrame;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0xD42248", Offset = "0xD42248", VA = "0xD42248")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xD422A8", Offset = "0xD422A8", VA = "0xD422A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0xD42A80", Offset = "0xD42A80", VA = "0xD42A80")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0xD42DD0", Offset = "0xD42DD0", VA = "0xD42DD0")]
	public void SetGrabEnableToHoldObj(bool value)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xD42CCC", Offset = "0xD42CCC", VA = "0xD42CCC")]
	private bool IsHoldDish(CookBase.DishType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xD33BE0", Offset = "0xD33BE0", VA = "0xD33BE0")]
	public bool IsHoldRice()
	{
		return default(bool);
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0xD32934", Offset = "0xD32934", VA = "0xD32934")]
	public bool IsHoldBeer()
	{
		return default(bool);
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0xD42E88", Offset = "0xD42E88", VA = "0xD42E88")]
	public bool IsOrderMatchChairExits(out int chairNum)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0xD428A8", Offset = "0xD428A8", VA = "0xD428A8")]
	private void CheckOrderMatch()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xD42F30", Offset = "0xD42F30", VA = "0xD42F30")]
	public void CollisionStayCallFromChild(Collision collision)
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xD42F34", Offset = "0xD42F34", VA = "0xD42F34")]
	public bool IsStayListExist(GameObject obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xD42348", Offset = "0xD42348", VA = "0xD42348")]
	private void CheckCollisionStayObject()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0xD42F9C", Offset = "0xD42F9C", VA = "0xD42F9C")]
	private void FitToPos(CookBase cookBase)
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0xD4276C", Offset = "0xD4276C", VA = "0xD4276C")]
	private void CheckHoldingObject()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xD43148", Offset = "0xD43148", VA = "0xD43148")]
	public ToolTray()
	{
	}
}
[Token(Token = "0x2000101")]
public class ToolTrayCollisionCallAgent : MonoBehaviour
{
	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xD43230", Offset = "0xD43230", VA = "0xD43230")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0xD43290", Offset = "0xD43290", VA = "0xD43290")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xD433D4", Offset = "0xD433D4", VA = "0xD433D4")]
	public ToolTrayCollisionCallAgent()
	{
	}
}
[Token(Token = "0x2000102")]
public class DestroyInTutorial : MonoBehaviour
{
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x1D491C4", Offset = "0x1D491C4", VA = "0x1D491C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x1D492A0", Offset = "0x1D492A0", VA = "0x1D492A0")]
	public DestroyInTutorial()
	{
	}
}
[Token(Token = "0x2000103")]
public class StepForceActive : MonoBehaviour
{
	[Token(Token = "0x20001D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF168", Offset = "0x9BF168")]
	private sealed class <ActiveRoutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StepForceActive <>4__this;

		[Token(Token = "0x17000098")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xD38194", Offset = "0xD38194", VA = "0xD38194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xD381FC", Offset = "0xD381FC", VA = "0xD381FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xD38074", Offset = "0xD38074", VA = "0xD38074")]
		[DebuggerHidden]
		public <ActiveRoutine>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xD380A8", Offset = "0xD380A8", VA = "0xD380A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xD380AC", Offset = "0xD380AC", VA = "0xD380AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xD3819C", Offset = "0xD3819C", VA = "0xD3819C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xD37FCC", Offset = "0xD37FCC", VA = "0xD37FCC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xD37FF8", Offset = "0xD37FF8", VA = "0xD37FF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C88B0", Offset = "0x9C88B0")]
	private IEnumerator ActiveRoutine()
	{
		return null;
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xD380A0", Offset = "0xD380A0", VA = "0xD380A0")]
	public StepForceActive()
	{
	}
}
[Token(Token = "0x2000104")]
public class TutorialChopsticksNavigateSet : GrabReactor
{
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xD43AD4", Offset = "0xD43AD4", VA = "0xD43AD4", Slot = "6")]
	public override void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xD43C20", Offset = "0xD43C20", VA = "0xD43C20")]
	public TutorialChopsticksNavigateSet()
	{
	}
}
[Token(Token = "0x2000105")]
public class TutorialClearStep : UiItemBase
{
	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C46A8", Offset = "0x9C46A8")]
	[SerializeField]
	private TutorialManager.Step clearStep;

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xD43C28", Offset = "0xD43C28", VA = "0xD43C28", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xD43CC8", Offset = "0xD43CC8", VA = "0xD43CC8")]
	public TutorialClearStep()
	{
	}
}
[Token(Token = "0x2000106")]
public class TutorialClearTrigger : MonoBehaviour
{
	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C46F4", Offset = "0x9C46F4")]
	[SerializeField]
	private TutorialManager.Step step;

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xD43CD0", Offset = "0xD43CD0", VA = "0xD43CD0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xD43DA8", Offset = "0xD43DA8", VA = "0xD43DA8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xD43E80", Offset = "0xD43E80", VA = "0xD43E80")]
	public TutorialClearTrigger()
	{
	}
}
[Token(Token = "0x2000107")]
public class TutorialNoodleRefill : MonoBehaviour
{
	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4740", Offset = "0x9C4740")]
	[SerializeField]
	private GameObject completeRamenBowl;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C478C", Offset = "0x9C478C")]
	[SerializeField]
	private Transform bowlSpawnPosTf;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] pages;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] checkMarks;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator[] stepAnimators;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject subBowlSpawnNavigation;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject[] navigations;

	[Token(Token = "0x6000501")]
	[Address(RVA = "0xD45E4C", Offset = "0xD45E4C", VA = "0xD45E4C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0xD46B70", Offset = "0xD46B70", VA = "0xD46B70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0xD46124", Offset = "0xD46124", VA = "0xD46124")]
	private void SetStep(int num)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0xD421B8", Offset = "0xD421B8", VA = "0xD421B8")]
	public void SetNavigation(int num)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0xD43128", Offset = "0xD43128", VA = "0xD43128")]
	public void SetSubBowlNavigation(bool isActive)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0xD46034", Offset = "0xD46034", VA = "0xD46034")]
	public void CloseNavigation()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0xD458B4", Offset = "0xD458B4", VA = "0xD458B4")]
	public void ClearStep(int num)
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0xD460A4", Offset = "0xD460A4", VA = "0xD460A4")]
	public void SetPage(int num)
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0xD45C94", Offset = "0xD45C94", VA = "0xD45C94")]
	public void DestroyDish()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0xD46F5C", Offset = "0xD46F5C", VA = "0xD46F5C")]
	public TutorialNoodleRefill()
	{
	}
}
[Token(Token = "0x2000108")]
public class TutorialOrder : MonoBehaviour
{
	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4828", Offset = "0x9C4828")]
	[SerializeField]
	private GameObject[] pages;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] checkMarks;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator[] stepAnimators;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] navigations;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float forceClearCheckOrderTimeRemain;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float forceClearCheckOrderTime;

	[Token(Token = "0x600050B")]
	[Address(RVA = "0xD46F64", Offset = "0xD46F64", VA = "0xD46F64")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0xD47644", Offset = "0xD47644", VA = "0xD47644")]
	private void Update()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0xD47070", Offset = "0xD47070", VA = "0xD47070")]
	private void SetStep(int num)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0xD45774", Offset = "0xD45774", VA = "0xD45774")]
	public void ClearStep(int num)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0xD46FF0", Offset = "0xD46FF0", VA = "0xD46FF0")]
	public void SetPage(int num)
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0xD47930", Offset = "0xD47930", VA = "0xD47930")]
	public TutorialOrder()
	{
	}
}
[Token(Token = "0x2000109")]
public class TutorialRamenCook : MonoBehaviour
{
	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C48A4", Offset = "0x9C48A4")]
	[SerializeField]
	private GameObject activeRamenBowl;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C48F0", Offset = "0x9C48F0")]
	[SerializeField]
	private GameObject ramenBowlPf;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform bowlSpawnPosTf;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] pages;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject[] checkMarks;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator[] stepAnimators;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject[] navigations;

	[Token(Token = "0x6000511")]
	[Address(RVA = "0xD47940", Offset = "0xD47940", VA = "0xD47940")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0xD482E0", Offset = "0xD482E0", VA = "0xD482E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0xD47BA8", Offset = "0xD47BA8", VA = "0xD47BA8")]
	private void SetStep(int num)
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0xD42138", Offset = "0xD42138", VA = "0xD42138")]
	public void SetNavigation(int num)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0xD419A4", Offset = "0xD419A4", VA = "0xD419A4")]
	public void CloseNavigation()
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0xD457DC", Offset = "0xD457DC", VA = "0xD457DC")]
	public void ClearStep(int num)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0xD47B28", Offset = "0xD47B28", VA = "0xD47B28")]
	public void SetPage(int num)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0xD45B2C", Offset = "0xD45B2C", VA = "0xD45B2C")]
	public void DestroyDish()
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0xD48550", Offset = "0xD48550", VA = "0xD48550")]
	public TutorialRamenCook()
	{
	}
}
[Token(Token = "0x200010A")]
public class TutorialSideMenu : MonoBehaviour
{
	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C498C", Offset = "0x9C498C")]
	[SerializeField]
	private GameObject completeRamenBowl;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C49D8", Offset = "0x9C49D8")]
	[SerializeField]
	private Transform bowlSpawnPosTf;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] pages;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] checkMarks;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator[] stepAnimators;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject[] navigations;

	[Token(Token = "0x600051A")]
	[Address(RVA = "0xD48558", Offset = "0xD48558", VA = "0xD48558")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0xD48F10", Offset = "0xD48F10", VA = "0xD48F10")]
	private void Update()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0xD48830", Offset = "0xD48830", VA = "0xD48830")]
	private void SetStep(int num)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0xD4912C", Offset = "0xD4912C", VA = "0xD4912C")]
	public void SetNavigation(int num)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0xD48740", Offset = "0xD48740", VA = "0xD48740")]
	public void CloseNavigation()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0xD45848", Offset = "0xD45848", VA = "0xD45848")]
	public void ClearStep(int num)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0xD487B0", Offset = "0xD487B0", VA = "0xD487B0")]
	public void SetPage(int num)
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0xD45BE0", Offset = "0xD45BE0", VA = "0xD45BE0")]
	public void DestroyDish()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0xD491AC", Offset = "0xD491AC", VA = "0xD491AC")]
	public TutorialSideMenu()
	{
	}
}
[Token(Token = "0x200010B")]
public class TutorialWash : MonoBehaviour
{
	[Token(Token = "0x20001D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF178", Offset = "0x9BF178")]
	private sealed class <TabletCallDelayRoutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700009A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0xD4A0B0", Offset = "0xD4A0B0", VA = "0xD4A0B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0xD4A118", Offset = "0xD4A118", VA = "0xD4A118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xD49D38", Offset = "0xD49D38", VA = "0xD49D38")]
		[DebuggerHidden]
		public <TabletCallDelayRoutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xD49DEC", Offset = "0xD49DEC", VA = "0xD49DEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xD49DF0", Offset = "0xD49DF0", VA = "0xD49DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xD4A0B8", Offset = "0xD4A0B8", VA = "0xD4A0B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4A64", Offset = "0x9C4A64")]
	[SerializeField]
	private GameObject dirtyRamenBowl;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4AB0", Offset = "0x9C4AB0")]
	[SerializeField]
	private Transform bowlSpawnPosTf;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] pages;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] checkMarks;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator[] stepAnimators;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject[] navigations;

	[Token(Token = "0x6000523")]
	[Address(RVA = "0xD49270", Offset = "0xD49270", VA = "0xD49270")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0xD49B00", Offset = "0xD49B00", VA = "0xD49B00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xD49CD8", Offset = "0xD49CD8", VA = "0xD49CD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8914", Offset = "0x9C8914")]
	private IEnumerator TabletCallDelayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0xD49548", Offset = "0xD49548", VA = "0xD49548")]
	private void SetStep(int num)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0xD49D64", Offset = "0xD49D64", VA = "0xD49D64")]
	public void SetNavigation(int num)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0xD49458", Offset = "0xD49458", VA = "0xD49458")]
	public void CloseNavigation()
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0xD45920", Offset = "0xD45920", VA = "0xD45920")]
	public void ClearStep(int num)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0xD494C8", Offset = "0xD494C8", VA = "0xD494C8")]
	public void SetPage(int num)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0xD45D48", Offset = "0xD45D48", VA = "0xD45D48")]
	public void DestroyDish()
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0xD49DE4", Offset = "0xD49DE4", VA = "0xD49DE4")]
	public TutorialWash()
	{
	}
}
[Token(Token = "0x200010C")]
public class BackToCookMenu : UiItemBase
{
	[Token(Token = "0x600052D")]
	[Address(RVA = "0xEBB4A8", Offset = "0xEBB4A8", VA = "0xEBB4A8", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0xEBB5C8", Offset = "0xEBB5C8", VA = "0xEBB5C8")]
	public BackToCookMenu()
	{
	}
}
[Token(Token = "0x200010D")]
public class BackToTitleButton : UiItemBase
{
	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isSelected;

	[Token(Token = "0x600052F")]
	[Address(RVA = "0xEBB5D0", Offset = "0xEBB5D0", VA = "0xEBB5D0", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0xEBB7D4", Offset = "0xEBB7D4", VA = "0xEBB7D4")]
	public BackToTitleButton()
	{
	}
}
[Token(Token = "0x200010E")]
public class BackToTutorialMenu : UiItemBase
{
	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isSelected;

	[Token(Token = "0x6000531")]
	[Address(RVA = "0xEBB7DC", Offset = "0xEBB7DC", VA = "0xEBB7DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0xEBB7E4", Offset = "0xEBB7E4", VA = "0xEBB7E4", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0xEBB8A0", Offset = "0xEBB8A0", VA = "0xEBB8A0")]
	public BackToTutorialMenu()
	{
	}
}
[Token(Token = "0x200010F")]
public class CloseShopButton : UiItemBase
{
	[Token(Token = "0x6000534")]
	[Address(RVA = "0xEC4170", Offset = "0xEC4170", VA = "0xEC4170", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0xEC42C0", Offset = "0xEC42C0", VA = "0xEC42C0")]
	public CloseShopButton()
	{
	}
}
[Token(Token = "0x2000110")]
public class CountDownVoice : MonoBehaviour
{
	[Token(Token = "0x6000536")]
	[Address(RVA = "0xEC5580", Offset = "0xEC5580", VA = "0xEC5580")]
	private void CountFive()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0xEC567C", Offset = "0xEC567C", VA = "0xEC567C")]
	private void CountFour()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0xEC5778", Offset = "0xEC5778", VA = "0xEC5778")]
	private void CountThree()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0xEC5874", Offset = "0xEC5874", VA = "0xEC5874")]
	private void CountTwo()
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0xEC5970", Offset = "0xEC5970", VA = "0xEC5970")]
	private void CountOne()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0xEC5A68", Offset = "0xEC5A68", VA = "0xEC5A68")]
	private void ReadySound()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0xEC5B44", Offset = "0xEC5B44", VA = "0xEC5B44")]
	private void ShopOpenVoice()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0xEC5C20", Offset = "0xEC5C20", VA = "0xEC5C20")]
	private void ShopCloseVoice()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0xEC5CFC", Offset = "0xEC5CFC", VA = "0xEC5CFC")]
	public CountDownVoice()
	{
	}
}
[Token(Token = "0x2000111")]
public class CustomerProfileIcon : MonoBehaviour
{
	[Token(Token = "0x20001D3")]
	public enum FaceType
	{
		[Token(Token = "0x4000AB8")]
		Normal,
		[Token(Token = "0x4000AB9")]
		Smile,
		[Token(Token = "0x4000ABA")]
		Angry
	}

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image frameImage;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image backImage;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image faceImage;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject refillPlateObj;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject refillObj;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image ramenImage;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image beerImage;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image riceImage;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ChairItem chairItem;

	[Token(Token = "0x600053F")]
	[Address(RVA = "0xECAF9C", Offset = "0xECAF9C", VA = "0xECAF9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0xECAFFC", Offset = "0xECAFFC", VA = "0xECAFFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0xECB544", Offset = "0xECB544", VA = "0xECB544")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8978", Offset = "0x9C8978")]
	private void Detect()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0xEC1C0C", Offset = "0xEC1C0C", VA = "0xEC1C0C")]
	public void SetShow(bool isActive)
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0xECB768", Offset = "0xECB768", VA = "0xECB768")]
	private void CloseAllIcons()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0xECB80C", Offset = "0xECB80C", VA = "0xECB80C")]
	private void CloseOrderIcons()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0xECB000", Offset = "0xECB000", VA = "0xECB000")]
	public void SetIcons()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0xEC9208", Offset = "0xEC9208", VA = "0xEC9208")]
	public void SetFace(FaceType faceType, CustomerState.CustomerType customerType)
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0xECBB58", Offset = "0xECBB58", VA = "0xECBB58")]
	public void SetChairItem(ChairItem item)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0xECBB60", Offset = "0xECBB60", VA = "0xECBB60")]
	public CustomerProfileIcon()
	{
	}
}
[Token(Token = "0x2000112")]
public class DemoPlayStartButton : UiItemBase
{
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x1D48E48", Offset = "0x1D48E48", VA = "0x1D48E48", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x1D48FD8", Offset = "0x1D48FD8", VA = "0x1D48FD8")]
	public DemoPlayStartButton()
	{
	}
}
[Token(Token = "0x2000113")]
public class FacingToHead : MonoBehaviour
{
	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableGrabbingOnly;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 angleOffset;

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x1D4E054", Offset = "0x1D4E054", VA = "0x1D4E054")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x1D4E2FC", Offset = "0x1D4E2FC", VA = "0x1D4E2FC")]
	public FacingToHead()
	{
	}
}
[Token(Token = "0x2000114")]
public class FloorCustomerNumber : MonoBehaviour
{
	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4BBC", Offset = "0x9C4BBC")]
	[SerializeField]
	private ChairItem chairItem;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int chairNum;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4C18", Offset = "0x9C4C18")]
	[SerializeField]
	private Text customerNumberText;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4C64", Offset = "0x9C4C64")]
	[SerializeField]
	private bool showLog;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x4000663")]
	private const string ANIM_ORDERCALL = "OrderCall";

	[Token(Token = "0x4000664")]
	private const string ANIM_WAIT_PLATE = "WaitPlate";

	[Token(Token = "0x4000665")]
	private const string ANIM_WAIT_RAMEN = "WaitRamen";

	[Token(Token = "0x4000666")]
	private const string ANIM_WAIT_KAEDAMA = "WaitKaedama";

	[Token(Token = "0x4000667")]
	private const string ANIM_CLEANUP_CALL = "CleanupCall";

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x1D4E4B4", Offset = "0x1D4E4B4", VA = "0x1D4E4B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x1D4E534", Offset = "0x1D4E534", VA = "0x1D4E534")]
	private void Update()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x1D4E78C", Offset = "0x1D4E78C", VA = "0x1D4E78C")]
	public void SetChairNum(int num)
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x1D4E890", Offset = "0x1D4E890", VA = "0x1D4E890")]
	public void SetQuickRamenWait()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x1D4E8EC", Offset = "0x1D4E8EC", VA = "0x1D4E8EC")]
	public void SetActiveTeleportPoint(bool isActive)
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x1D4E9C0", Offset = "0x1D4E9C0", VA = "0x1D4E9C0")]
	public FloorCustomerNumber()
	{
	}
}
[Token(Token = "0x2000115")]
public class GetScore : MonoBehaviour
{
	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform headTf;

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x1D501E8", Offset = "0x1D501E8", VA = "0x1D501E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x1D502D0", Offset = "0x1D502D0", VA = "0x1D502D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x1D50580", Offset = "0x1D50580", VA = "0x1D50580")]
	public void SetScoreText(int score)
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x1D50644", Offset = "0x1D50644", VA = "0x1D50644")]
	public GetScore()
	{
	}
}
[Token(Token = "0x2000116")]
public class HeightAdjustButton : UiItemBase
{
	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool isDown;

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1D53538", Offset = "0x1D53538", VA = "0x1D53538", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1D53768", Offset = "0x1D53768", VA = "0x1D53768")]
	public HeightAdjustButton()
	{
	}
}
[Token(Token = "0x2000117")]
public class HeightOffset : MonoBehaviour
{
	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float minOffset;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float maxOffset;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text heightText;

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1D53770", Offset = "0x1D53770", VA = "0x1D53770")]
	private void Update()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1D535CC", Offset = "0x1D535CC", VA = "0x1D535CC")]
	public void ChangeOffset(bool isDown)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x1D53840", Offset = "0x1D53840", VA = "0x1D53840")]
	public HeightOffset()
	{
	}
}
[Token(Token = "0x2000118")]
public class InfoBoard : MonoBehaviour
{
	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4CE0", Offset = "0x9C4CE0")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text mainText;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text subText;

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x1D544C8", Offset = "0x1D544C8", VA = "0x1D544C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x1D54564", Offset = "0x1D54564", VA = "0x1D54564")]
	private void Update()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x1D54878", Offset = "0x1D54878", VA = "0x1D54878")]
	private void FetchRemoteConfig()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x1D54900", Offset = "0x1D54900", VA = "0x1D54900")]
	public InfoBoard()
	{
	}
}
[Token(Token = "0x2000119")]
public class LeaderboardUi : SingletonMonoBehaviour<LeaderboardUi>
{
	[Token(Token = "0x20001D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF188", Offset = "0x9BF188")]
	private sealed class <ShowRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeaderboardUi <>4__this;

		[Token(Token = "0x1700009C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1D5B0BC", Offset = "0x1D5B0BC", VA = "0x1D5B0BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1D5B124", Offset = "0x1D5B124", VA = "0x1D5B124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1D5A9E0", Offset = "0x1D5A9E0", VA = "0x1D5A9E0")]
		[DebuggerHidden]
		public <ShowRoutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1D5AE48", Offset = "0x1D5AE48", VA = "0x1D5AE48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1D5AE4C", Offset = "0x1D5AE4C", VA = "0x1D5AE4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1D5B0C4", Offset = "0x1D5B0C4", VA = "0x1D5B0C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4D4C", Offset = "0x9C4D4C")]
	public bool isShow;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4D84", Offset = "0x9C4D84")]
	[SerializeField]
	private GameObject rootObj;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject globalRankParent;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject aroundRankParent;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject loadingTextObj;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RankItem[] globalRankItems;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RankItem[] aroundRankItems;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isHiding;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x1D5A6A4", Offset = "0x1D5A6A4", VA = "0x1D5A6A4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C89B0", Offset = "0x9C89B0")]
	private void Detect()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x1D5A738", Offset = "0x1D5A738", VA = "0x1D5A738")]
	private void Start()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x1D5A758", Offset = "0x1D5A758", VA = "0x1D5A758")]
	private void Update()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x1D5A7E8", Offset = "0x1D5A7E8", VA = "0x1D5A7E8")]
	private void SetHiding(bool isHide)
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x1D5A930", Offset = "0x1D5A930", VA = "0x1D5A930")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C89E8", Offset = "0x9C89E8")]
	public void Show()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x1D5A964", Offset = "0x1D5A964", VA = "0x1D5A964")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8A20", Offset = "0x9C8A20")]
	private IEnumerator ShowRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x1D5AA0C", Offset = "0x1D5AA0C", VA = "0x1D5AA0C")]
	private void SetRankDataToUi()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x1D5ADD0", Offset = "0x1D5ADD0", VA = "0x1D5ADD0")]
	public void Close()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x1D5ADF8", Offset = "0x1D5ADF8", VA = "0x1D5ADF8")]
	public LeaderboardUi()
	{
	}
}
[Token(Token = "0x200011A")]
public class LeaderboardUiClose : UiItemBase
{
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x1D5B12C", Offset = "0x1D5B12C", VA = "0x1D5B12C", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x1D5B1D0", Offset = "0x1D5B1D0", VA = "0x1D5B1D0")]
	public LeaderboardUiClose()
	{
	}
}
[Token(Token = "0x200011B")]
public class LoadingBar : MonoBehaviour
{
	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Image image;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x1D5B5FC", Offset = "0x1D5B5FC", VA = "0x1D5B5FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x1D5B674", Offset = "0x1D5B674", VA = "0x1D5B674")]
	private void Update()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x1D5B710", Offset = "0x1D5B710", VA = "0x1D5B710")]
	public LoadingBar()
	{
	}
}
[Token(Token = "0x200011C")]
public class LoadingScene : MonoBehaviour
{
	[Token(Token = "0x20001D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF198", Offset = "0x9BF198")]
	private sealed class <LoadingRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadingScene <>4__this;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <nextScene>5__2;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <asyncOp>5__3;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <elapsedTime>5__4;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <duration>5__5;

		[Token(Token = "0x1700009E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1D5C2D0", Offset = "0x1D5C2D0", VA = "0x1D5C2D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1D5C338", Offset = "0x1D5C338", VA = "0x1D5C338", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1D5BDA0", Offset = "0x1D5BDA0", VA = "0x1D5BDA0")]
		[DebuggerHidden]
		public <LoadingRoutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1D5BDD4", Offset = "0x1D5BDD4", VA = "0x1D5BDD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1D5BDD8", Offset = "0x1D5BDD8", VA = "0x1D5BDD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1D5C2D8", Offset = "0x1D5C2D8", VA = "0x1D5C2D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4E20", Offset = "0x9C4E20")]
	[SerializeField]
	private TipsLocalizeData tipsLocalizeData;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ProgressBar progressBar;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image tipsImage;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text tipsTitle;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text tipsText;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite[] tipsSprites;

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x1D5B718", Offset = "0x1D5B718", VA = "0x1D5B718")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8A84", Offset = "0x9C8A84")]
	private void Detect()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x1D5B794", Offset = "0x1D5B794", VA = "0x1D5B794")]
	private void Start()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x1D5B7C8", Offset = "0x1D5B7C8", VA = "0x1D5B7C8")]
	private void SetTips()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x1D5B9F0", Offset = "0x1D5B9F0", VA = "0x1D5B9F0")]
	private string GetTitle(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x1D5BBC8", Offset = "0x1D5BBC8", VA = "0x1D5BBC8")]
	private string GetTipsText(int idx)
	{
		return null;
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x1D5B974", Offset = "0x1D5B974", VA = "0x1D5B974")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8ABC", Offset = "0x9C8ABC")]
	private IEnumerator LoadingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x1D5BDCC", Offset = "0x1D5BDCC", VA = "0x1D5BDCC")]
	public LoadingScene()
	{
	}
}
[Token(Token = "0x200011D")]
public class LocalizeFontSetter : MonoBehaviour
{
	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material defaultTmpMat;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material chineseTmpMat;

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x1D5C340", Offset = "0x1D5C340", VA = "0x1D5C340")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x1D5C5CC", Offset = "0x1D5C5CC", VA = "0x1D5C5CC")]
	public LocalizeFontSetter()
	{
	}
}
[Token(Token = "0x200011E")]
public class LogoSplash : SingletonMonoBehaviour<LogoSplash>
{
	[Token(Token = "0x20001D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF1A8", Offset = "0x9BF1A8")]
	private sealed class <Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LogoSplash <>4__this;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup <canvasGroup>5__2;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CanvasGroup <backCanvasGroup>5__3;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <elapsedTime>5__4;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <fadeTime>5__5;

		[Token(Token = "0x170000A0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1D5D604", Offset = "0x1D5D604", VA = "0x1D5D604", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1D5D66C", Offset = "0x1D5D66C", VA = "0x1D5D66C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1D5CE10", Offset = "0x1D5CE10", VA = "0x1D5CE10")]
		[DebuggerHidden]
		public <Start>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1D5D168", Offset = "0x1D5D168", VA = "0x1D5D168", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1D5D16C", Offset = "0x1D5D16C", VA = "0x1D5D16C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1D5D60C", Offset = "0x1D5D60C", VA = "0x1D5D60C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4EDC", Offset = "0x9C4EDC")]
	public Transform canvasRootTf;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform backCanvasTf;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float showDuration;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float distance;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float lerpRate;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioMixer mixer;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform headTf;

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x1D5CD94", Offset = "0x1D5CD94", VA = "0x1D5CD94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8B20", Offset = "0x9C8B20")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x1D5CE3C", Offset = "0x1D5CE3C", VA = "0x1D5CE3C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x1D5D100", Offset = "0x1D5D100", VA = "0x1D5D100")]
	public LogoSplash()
	{
	}
}
[Token(Token = "0x200011F")]
public class MusicVolume : MonoBehaviour
{
	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float minVolume;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float maxVolume;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SliderUi sliderUi;

	[Token(Token = "0x600057A")]
	[Address(RVA = "0xDBB68C", Offset = "0xDBB68C", VA = "0xDBB68C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0xDBB7C4", Offset = "0xDBB7C4", VA = "0xDBB7C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0xDBB880", Offset = "0xDBB880", VA = "0xDBB880")]
	public MusicVolume()
	{
	}
}
[Token(Token = "0x2000120")]
public class NextPeakTimeUi : MonoBehaviour
{
	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text levelText;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text nextScoreText;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text scoreText;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text timeText;

	[Token(Token = "0x600057D")]
	[Address(RVA = "0xDBB920", Offset = "0xDBB920", VA = "0xDBB920")]
	private void Update()
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0xDBBBE0", Offset = "0xDBBBE0", VA = "0xDBBBE0")]
	public NextPeakTimeUi()
	{
	}
}
[Token(Token = "0x2000121")]
public class OpenTutorialPageButton : UiItemBase
{
	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C4FA4", Offset = "0x9C4FA4")]
	[SerializeField]
	private TutorialManager.Page openPage;

	[Token(Token = "0x600057F")]
	[Address(RVA = "0xDBEC90", Offset = "0xDBEC90", VA = "0xDBEC90", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0xDBED30", Offset = "0xDBED30", VA = "0xDBED30")]
	public OpenTutorialPageButton()
	{
	}
}
[Token(Token = "0x2000122")]
public class OrderListDisplay : MonoBehaviour
{
	[Token(Token = "0x20001D7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF1B8", Offset = "0x9BF1B8")]
	private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OrderListDisplay <>4__this;

		[Token(Token = "0x170000A2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xDBF3CC", Offset = "0xDBF3CC", VA = "0xDBF3CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xDBF434", Offset = "0xDBF434", VA = "0xDBF434", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xDBEDB4", Offset = "0xDBEDB4", VA = "0xDBEDB4")]
		[DebuggerHidden]
		public <Start>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xDBF2C4", Offset = "0xDBF2C4", VA = "0xDBF2C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xDBF2C8", Offset = "0xDBF2C8", VA = "0xDBF2C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xDBF3D4", Offset = "0xDBF3D4", VA = "0xDBF3D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] uiOrderItemObjects;

	[Token(Token = "0x4000692")]
	private const int MAX_UI_ITEM_COUNT = 8;

	[Token(Token = "0x6000581")]
	[Address(RVA = "0xDBED38", Offset = "0xDBED38", VA = "0xDBED38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8B84", Offset = "0x9C8B84")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0xDBEDE0", Offset = "0xDBEDE0", VA = "0xDBEDE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0xDBEDE4", Offset = "0xDBEDE4", VA = "0xDBEDE4")]
	private void UpdateUiItems()
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0xDBF2BC", Offset = "0xDBF2BC", VA = "0xDBF2BC")]
	public OrderListDisplay()
	{
	}
}
[Token(Token = "0x2000123")]
public class PauseResume : UiItemBase
{
	[Token(Token = "0x6000585")]
	[Address(RVA = "0xDC2734", Offset = "0xDC2734", VA = "0xDC2734", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0xDC27CC", Offset = "0xDC27CC", VA = "0xDC27CC")]
	public PauseResume()
	{
	}
}
[Token(Token = "0x2000124")]
[ExecuteAlways]
public class ProgressBar : MonoBehaviour
{
	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isLerp;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5010", Offset = "0x9C5010")]
	private float rate;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 maxPos;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 minPos;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float currentRate;

	[Token(Token = "0x6000587")]
	[Address(RVA = "0xDC8D2C", Offset = "0xDC8D2C", VA = "0xDC8D2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0xDC8D38", Offset = "0xDC8D38", VA = "0xDC8D38")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0xDC8FD0", Offset = "0xDC8FD0", VA = "0xDC8FD0")]
	public void SetRate(float value)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0xDC8FD8", Offset = "0xDC8FD8", VA = "0xDC8FD8")]
	public ProgressBar()
	{
	}
}
[Token(Token = "0x2000125")]
public class ProjectionUiManager : SingletonMonoBehaviour<ProjectionUiManager>
{
	[Token(Token = "0x20001D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF1C8", Offset = "0x9BF1C8")]
	private sealed class <CloseRoutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProjectionUiManager <>4__this;

		[Token(Token = "0x170000A4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xDCA5E8", Offset = "0xDCA5E8", VA = "0xDCA5E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xDCA650", Offset = "0xDCA650", VA = "0xDCA650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xDCA2AC", Offset = "0xDCA2AC", VA = "0xDCA2AC")]
		[DebuggerHidden]
		public <CloseRoutine>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xDCA440", Offset = "0xDCA440", VA = "0xDCA440", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xDCA444", Offset = "0xDCA444", VA = "0xDCA444", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xDCA5F0", Offset = "0xDCA5F0", VA = "0xDCA5F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF1D8", Offset = "0x9BF1D8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<ChairItem> <>9__31_0;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xDCA3A8", Offset = "0xDCA3A8", VA = "0xDCA3A8")]
		public <>c()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xDCA3B0", Offset = "0xDCA3B0", VA = "0xDCA3B0")]
		internal int <SetUiItems>b__31_0(ChairItem a, ChairItem b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5070", Offset = "0x9C5070")]
	[SerializeField]
	private bool isShowForce;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C50BC", Offset = "0x9C50BC")]
	[SerializeField]
	private bool isEnable;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool isShow;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isRightHand;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] uiOrderItemObjects;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5138", Offset = "0x9C5138")]
	[SerializeField]
	private float headAngleRate;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5184", Offset = "0x9C5184")]
	[SerializeField]
	private Animator canvasAnimator;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject canvasRoot;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject itemsRoot;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject itemsRootTutorial;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject anchorCanvas;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform headTf;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float showHeadAngle;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float closeHeadAngle;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float headAngleThreshold;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float distanceThreshold;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float angleRateThreshold;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool isHiding;

	[Token(Token = "0x40006AA")]
	private const int MAX_UI_ITEM_COUNT = 8;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Coroutine closeRoutine;

	[Token(Token = "0x600058B")]
	[Address(RVA = "0xDC8FE8", Offset = "0xDC8FE8", VA = "0xDC8FE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0xDC90B4", Offset = "0xDC90B4", VA = "0xDC90B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0xDC9E48", Offset = "0xDC9E48", VA = "0xDC9E48")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C8BE8", Offset = "0x9C8BE8")]
	private void DetectItems()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0xDC9F74", Offset = "0xDC9F74", VA = "0xDC9F74")]
	private void SetHiding(bool isHide)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0xDCA0BC", Offset = "0xDCA0BC", VA = "0xDCA0BC")]
	private void SyncAnchorCanvas()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0xDC9D58", Offset = "0xDC9D58", VA = "0xDC9D58")]
	private void CheckHeadAngle()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0xDCA160", Offset = "0xDCA160", VA = "0xDCA160")]
	public void SetItemsToTutorial(bool isEnable)
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0xDCA1AC", Offset = "0xDCA1AC", VA = "0xDCA1AC")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0xDCA1B8", Offset = "0xDCA1B8", VA = "0xDCA1B8")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0xDC91B0", Offset = "0xDC91B0", VA = "0xDC91B0")]
	public void SetShow(bool show, bool isRight)
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0xDCA230", Offset = "0xDCA230", VA = "0xDCA230")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8C20", Offset = "0x9C8C20")]
	private IEnumerator CloseRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0xDC97C8", Offset = "0xDC97C8", VA = "0xDC97C8")]
	private void SetUiItems()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0xDCA1C0", Offset = "0xDCA1C0", VA = "0xDCA1C0")]
	private void ClearUiItems()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0xDCA2D8", Offset = "0xDCA2D8", VA = "0xDCA2D8")]
	public ProjectionUiManager()
	{
	}
}
[Token(Token = "0x2000126")]
public class RamenLifeTime : MonoBehaviour
{
	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text timeText;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image gaugeImage;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RamenBowl ramenBowl;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Animator animator;

	[Token(Token = "0x6000599")]
	[Address(RVA = "0xCFEF84", Offset = "0xCFEF84", VA = "0xCFEF84")]
	private void Start()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0xCFEFE4", Offset = "0xCFEFE4", VA = "0xCFEFE4")]
	private void Update()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0xCFF1B4", Offset = "0xCFF1B4", VA = "0xCFF1B4")]
	public RamenLifeTime()
	{
	}
}
[Token(Token = "0x2000127")]
public class RankItem : MonoBehaviour
{
	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5240", Offset = "0x9C5240")]
	[SerializeField]
	private Text rankText;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text scoreText;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject youMark;

	[Token(Token = "0x600059C")]
	[Address(RVA = "0xCFF350", Offset = "0xCFF350", VA = "0xCFF350")]
	private void Reset()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0xCFF4A4", Offset = "0xCFF4A4", VA = "0xCFF4A4")]
	public void SetData(string rank, string name, string score, bool isMe)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0xCFF5B8", Offset = "0xCFF5B8", VA = "0xCFF5B8")]
	public RankItem()
	{
	}
}
[Token(Token = "0x2000128")]
public class RestartSceneButton : UiItemBase
{
	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isSelected;

	[Token(Token = "0x600059F")]
	[Address(RVA = "0xD002A0", Offset = "0xD002A0", VA = "0xD002A0", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0xD00488", Offset = "0xD00488", VA = "0xD00488")]
	public RestartSceneButton()
	{
	}
}
[Token(Token = "0x2000129")]
public class ResultStaffInfo : MonoBehaviour
{
	[Token(Token = "0x20001DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF1E8", Offset = "0x9BF1E8")]
	private sealed class <ExpBarRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResultStaffInfo <>4__this;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <startLv>5__2;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <duration>5__4;

		[Token(Token = "0x170000A6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xD02C1C", Offset = "0xD02C1C", VA = "0xD02C1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xD02C84", Offset = "0xD02C84", VA = "0xD02C84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xD02014", Offset = "0xD02014", VA = "0xD02014")]
		[DebuggerHidden]
		public <ExpBarRoutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xD02048", Offset = "0xD02048", VA = "0xD02048", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xD0204C", Offset = "0xD0204C", VA = "0xD0204C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xD02C24", Offset = "0xD02C24", VA = "0xD02C24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C52BC", Offset = "0x9C52BC")]
	[SerializeField]
	private int posNum;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image faceImage;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text lvText;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject levelUpObj;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ProgressBar expBar;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int staffTypeNum;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private StaffState staffState;

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0xD01DE4", Offset = "0xD01DE4", VA = "0xD01DE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0xD01F98", Offset = "0xD01F98", VA = "0xD01F98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8C84", Offset = "0x9C8C84")]
	private IEnumerator ExpBarRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0xD02040", Offset = "0xD02040", VA = "0xD02040")]
	public ResultStaffInfo()
	{
	}
}
[Token(Token = "0x200012A")]
public class ScreenWipe : SingletonMonoBehaviour<ScreenWipe>
{
	[Token(Token = "0x20001DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF1F8", Offset = "0x9BF1F8")]
	private sealed class <LoadingShowDelayRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenWipe <>4__this;

		[Token(Token = "0x170000A8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xD07FC4", Offset = "0xD07FC4", VA = "0xD07FC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xD0802C", Offset = "0xD0802C", VA = "0xD0802C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xD07E1C", Offset = "0xD07E1C", VA = "0xD07E1C")]
		[DebuggerHidden]
		public <LoadingShowDelayRoutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xD07EAC", Offset = "0xD07EAC", VA = "0xD07EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xD07EB0", Offset = "0xD07EB0", VA = "0xD07EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xD07FCC", Offset = "0xD07FCC", VA = "0xD07FCC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5358", Offset = "0x9C5358")]
	public bool isWipe;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool isClosed;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5390", Offset = "0x9C5390")]
	[SerializeField]
	private bool isOpenAwake;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform canvasTf;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject loadingTextObj;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float distance;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float duration;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float wipeEndTime;

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0xD07AA4", Offset = "0xD07AA4", VA = "0xD07AA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0xD07B6C", Offset = "0xD07B6C", VA = "0xD07B6C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0xD07AF0", Offset = "0xD07AF0", VA = "0xD07AF0")]
	public void Open()
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0xD07D24", Offset = "0xD07D24", VA = "0xD07D24")]
	public void Close()
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0xD07DA0", Offset = "0xD07DA0", VA = "0xD07DA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8CE8", Offset = "0x9C8CE8")]
	private IEnumerator LoadingShowDelayRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0xD07E48", Offset = "0xD07E48", VA = "0xD07E48")]
	public ScreenWipe()
	{
	}
}
[Token(Token = "0x200012B")]
public class SeVolume : MonoBehaviour
{
	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float minVolume;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float maxVolume;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SliderUi sliderUi;

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0xD0814C", Offset = "0xD0814C", VA = "0xD0814C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0xD083E0", Offset = "0xD083E0", VA = "0xD083E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0xD0849C", Offset = "0xD0849C", VA = "0xD0849C")]
	public SeVolume()
	{
	}
}
[Token(Token = "0x200012C")]
public class ShowLeaderboardButton : UiItemBase
{
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0xD0B1D4", Offset = "0xD0B1D4", VA = "0xD0B1D4", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0xD0B27C", Offset = "0xD0B27C", VA = "0xD0B27C")]
	public ShowLeaderboardButton()
	{
	}
}
[Token(Token = "0x200012D")]
public class SignBoard : SingletonMonoBehaviour<SignBoard>
{
	[Token(Token = "0x20001DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF208", Offset = "0x9BF208")]
	private sealed class <ShowOpenCountDownRoutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SignBoard <>4__this;

		[Token(Token = "0x170000AA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xD0BFBC", Offset = "0xD0BFBC", VA = "0xD0BFBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xD0C024", Offset = "0xD0C024", VA = "0xD0C024", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xD0B4BC", Offset = "0xD0B4BC", VA = "0xD0B4BC")]
		[DebuggerHidden]
		public <ShowOpenCountDownRoutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xD0BD6C", Offset = "0xD0BD6C", VA = "0xD0BD6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xD0BD70", Offset = "0xD0BD70", VA = "0xD0BD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xD0BFC4", Offset = "0xD0BFC4", VA = "0xD0BFC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF218", Offset = "0x9BF218")]
	private sealed class <ShowCloseCountDownRoutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SignBoard <>4__this;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xD0BCFC", Offset = "0xD0BCFC", VA = "0xD0BCFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xD0BD64", Offset = "0xD0BD64", VA = "0xD0BD64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xD0B5AC", Offset = "0xD0B5AC", VA = "0xD0B5AC")]
		[DebuggerHidden]
		public <ShowCloseCountDownRoutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xD0BA8C", Offset = "0xD0BA8C", VA = "0xD0BA8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xD0BA90", Offset = "0xD0BA90", VA = "0xD0BA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xD0BD04", Offset = "0xD0BD04", VA = "0xD0BD04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF228", Offset = "0x9BF228")]
	private sealed class <CloseRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SignBoard <>4__this;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xD0BA1C", Offset = "0xD0BA1C", VA = "0xD0BA1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xD0BA84", Offset = "0xD0BA84", VA = "0xD0BA84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xD0B824", Offset = "0xD0B824", VA = "0xD0B824")]
		[DebuggerHidden]
		public <CloseRoutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xD0B8A0", Offset = "0xD0B8A0", VA = "0xD0B8A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xD0B8A4", Offset = "0xD0B8A4", VA = "0xD0B8A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xD0BA24", Offset = "0xD0BA24", VA = "0xD0BA24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C540C", Offset = "0x9C540C")]
	public bool isShowOpenSign;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool isShowCloseSign;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5444", Offset = "0x9C5444")]
	[SerializeField]
	private GameObject[] animRootObjects;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator[] animators;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isPeakTime;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine showOpenCountDownRoutine;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine closeCountDownRoutine;

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0xD0B284", Offset = "0xD0B284", VA = "0xD0B284")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0xD0B2DC", Offset = "0xD0B2DC", VA = "0xD0B2DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0xD0B3A8", Offset = "0xD0B3A8", VA = "0xD0B3A8")]
	public void ShowOpenCountDown()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0xD0B440", Offset = "0xD0B440", VA = "0xD0B440")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8D4C", Offset = "0x9C8D4C")]
	private IEnumerator ShowOpenCountDownRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0xD0B4E8", Offset = "0xD0B4E8", VA = "0xD0B4E8")]
	public void ShowCloseCountDown()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0xD0B530", Offset = "0xD0B530", VA = "0xD0B530")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8DB0", Offset = "0x9C8DB0")]
	private IEnumerator ShowCloseCountDownRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0xD0B5D8", Offset = "0xD0B5D8", VA = "0xD0B5D8")]
	public void StopCloseCountDown()
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0xD0B63C", Offset = "0xD0B63C", VA = "0xD0B63C")]
	public void ShowLunchTime()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0xD0B6B0", Offset = "0xD0B6B0", VA = "0xD0B6B0")]
	public void ShowPeakTime()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0xD0B728", Offset = "0xD0B728", VA = "0xD0B728")]
	public void ForceStop()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0xD0B2B0", Offset = "0xD0B2B0", VA = "0xD0B2B0")]
	public void Close()
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0xD0B7A8", Offset = "0xD0B7A8", VA = "0xD0B7A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8E14", Offset = "0x9C8E14")]
	private IEnumerator CloseRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0xD0B850", Offset = "0xD0B850", VA = "0xD0B850")]
	public SignBoard()
	{
	}
}
[Token(Token = "0x200012E")]
public class SittingStateText : MonoBehaviour
{
	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text text;

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0xD0D098", Offset = "0xD0D098", VA = "0xD0D098")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0xD0D0F8", Offset = "0xD0D0F8", VA = "0xD0D0F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0xD0D180", Offset = "0xD0D180", VA = "0xD0D180")]
	public SittingStateText()
	{
	}
}
[Token(Token = "0x200012F")]
public class SliderUi : MonoBehaviour
{
	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C54A0", Offset = "0x9C54A0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C54A0", Offset = "0x9C54A0")]
	public float rate;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isGrab;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[SerializeField]
	private bool isGrabRight;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5514", Offset = "0x9C5514")]
	[SerializeField]
	private float minLocalPosX;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxLocalPosX;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Collider col;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform rectTf;

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0xD0D188", Offset = "0xD0D188", VA = "0xD0D188")]
	private void Start()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0xD0D1E8", Offset = "0xD0D1E8", VA = "0xD0D1E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0xD0D5C8", Offset = "0xD0D5C8", VA = "0xD0D5C8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0xD0D364", Offset = "0xD0D364", VA = "0xD0D364")]
	private void CheckGrabThis()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0xD0D530", Offset = "0xD0D530", VA = "0xD0D530")]
	private void CheckReleaseThis()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0xD08280", Offset = "0xD08280", VA = "0xD08280")]
	public void SetRate(float rateValue)
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0xD0D6F8", Offset = "0xD0D6F8", VA = "0xD0D6F8")]
	public SliderUi()
	{
	}
}
[Token(Token = "0x2000130")]
public class TableTablet : SingletonMonoBehaviour<TableTablet>
{
	[Token(Token = "0x20001DF")]
	public enum AlertType
	{
		[Token(Token = "0x4000AE7")]
		None,
		[Token(Token = "0x4000AE8")]
		Welcome,
		[Token(Token = "0x4000AE9")]
		ExtraOrder,
		[Token(Token = "0x4000AEA")]
		Cleanup,
		[Token(Token = "0x4000AEB")]
		LunchTime,
		[Token(Token = "0x4000AEC")]
		PeakTime
	}

	[Token(Token = "0x20001E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF238", Offset = "0x9BF238")]
	private sealed class <Start>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TableTablet <>4__this;

		[Token(Token = "0x170000B0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xD3B944", Offset = "0xD3B944", VA = "0xD3B944", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xD3B9AC", Offset = "0xD3B9AC", VA = "0xD3B9AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xD3A1EC", Offset = "0xD3A1EC", VA = "0xD3A1EC")]
		[DebuggerHidden]
		public <Start>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xD3B884", Offset = "0xD3B884", VA = "0xD3B884", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xD3B888", Offset = "0xD3B888", VA = "0xD3B888", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xD3B94C", Offset = "0xD3B94C", VA = "0xD3B94C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF248", Offset = "0x9BF248")]
	private sealed class <SetAlertRoutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TableTablet <>4__this;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AlertType type;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int chairNum;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x170000B2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0xD3B814", Offset = "0xD3B814", VA = "0xD3B814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xD3B87C", Offset = "0xD3B87C", VA = "0xD3B87C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD3A798", Offset = "0xD3A798", VA = "0xD3A798")]
		[DebuggerHidden]
		public <SetAlertRoutine>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD3B730", Offset = "0xD3B730", VA = "0xD3B730", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xD3B734", Offset = "0xD3B734", VA = "0xD3B734", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD3B81C", Offset = "0xD3B81C", VA = "0xD3B81C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001E2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF258", Offset = "0x9BF258")]
	private sealed class <ClearAlertRoutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TableTablet <>4__this;

		[Token(Token = "0x170000B4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xD3B6C0", Offset = "0xD3B6C0", VA = "0xD3B6C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xD3B728", Offset = "0xD3B728", VA = "0xD3B728", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xD3AFF8", Offset = "0xD3AFF8", VA = "0xD3AFF8")]
		[DebuggerHidden]
		public <ClearAlertRoutine>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xD3B4A0", Offset = "0xD3B4A0", VA = "0xD3B4A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xD3B4A4", Offset = "0xD3B4A4", VA = "0xD3B4A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xD3B6C8", Offset = "0xD3B6C8", VA = "0xD3B6C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF268", Offset = "0x9BF268")]
	private sealed class <ClearAlertDelayRoutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TableTablet <>4__this;

		[Token(Token = "0x170000B6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xD3B430", Offset = "0xD3B430", VA = "0xD3B430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xD3B498", Offset = "0xD3B498", VA = "0xD3B498", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xD3B024", Offset = "0xD3B024", VA = "0xD3B024")]
		[DebuggerHidden]
		public <ClearAlertDelayRoutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xD3B310", Offset = "0xD3B310", VA = "0xD3B310", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xD3B314", Offset = "0xD3B314", VA = "0xD3B314", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xD3B438", Offset = "0xD3B438", VA = "0xD3B438", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5580", Offset = "0x9C5580")]
	[SerializeField]
	private bool noWaveAnimation;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text timeText;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text scoreText;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject normalDisp;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject welcomeAlert;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject refillOrderAlert;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject cleanupAlert;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject lunchTimeAlert;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject peakTimeAlert;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject nextPeakTime;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject bottomUI;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text bottomTimeText;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text bottomScoreText;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TextMeshProUGUI welcomeChairNumText;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TextMeshProUGUI refillOrderChairNumText;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TextMeshProUGUI cleanupChairNumText;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C56BC", Offset = "0x9C56BC")]
	[SerializeField]
	private GameObject waveAnimation;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Animator waveAnimator;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private TextMeshProUGUI fullSeatText;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private TextMeshProUGUI visitorsCountText;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool isPeakTime;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private AudioSource audioSource;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Coroutine clearAlertRoutine;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Coroutine setDefaultRoutine;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Coroutine setAlertRoutine;

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0xD3A170", Offset = "0xD3A170", VA = "0xD3A170")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8E78", Offset = "0x9C8E78")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0xD3A218", Offset = "0xD3A218", VA = "0xD3A218")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0xD3A598", Offset = "0xD3A598", VA = "0xD3A598")]
	public void SetAlert(AlertType type, int chairNum, float duration)
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0xD3A6F8", Offset = "0xD3A6F8", VA = "0xD3A6F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8EDC", Offset = "0x9C8EDC")]
	private IEnumerator SetAlertRoutine(AlertType type, int chairNum, float duration)
	{
		return null;
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0xD3A7C4", Offset = "0xD3A7C4", VA = "0xD3A7C4")]
	public void SetAlert(AlertType type, int chairNum)
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0xD3AF24", Offset = "0xD3AF24", VA = "0xD3AF24")]
	public void ClearAlert()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0xD3AF7C", Offset = "0xD3AF7C", VA = "0xD3AF7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8F40", Offset = "0x9C8F40")]
	private IEnumerator ClearAlertRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0xD3AE98", Offset = "0xD3AE98", VA = "0xD3AE98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C8FA4", Offset = "0x9C8FA4")]
	private IEnumerator ClearAlertDelayRoutine(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0xD3ABFC", Offset = "0xD3ABFC", VA = "0xD3ABFC")]
	private void SetDefault()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0xD3B050", Offset = "0xD3B050", VA = "0xD3B050")]
	public void ShowLunchTime()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0xD3B168", Offset = "0xD3B168", VA = "0xD3B168")]
	public void ShowPeakTime()
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0xD3B284", Offset = "0xD3B284", VA = "0xD3B284")]
	public void CloseWaveAnim()
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0xD3AE40", Offset = "0xD3AE40", VA = "0xD3AE40")]
	public void PlaySound(AudioClip clip)
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0xD3B2C0", Offset = "0xD3B2C0", VA = "0xD3B2C0")]
	public TableTablet()
	{
	}
}
[Token(Token = "0x2000131")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x20001E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF278", Offset = "0x9BF278")]
	private sealed class <CloseRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportPoint <>4__this;

		[Token(Token = "0x170000B8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xD3C604", Offset = "0xD3C604", VA = "0xD3C604", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xD3C66C", Offset = "0xD3C66C", VA = "0xD3C66C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xD3C4D0", Offset = "0xD3C4D0", VA = "0xD3C4D0")]
		[DebuggerHidden]
		public <CloseRoutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xD3C510", Offset = "0xD3C510", VA = "0xD3C510", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xD3C514", Offset = "0xD3C514", VA = "0xD3C514", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xD3C60C", Offset = "0xD3C60C", VA = "0xD3C60C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform linePosTf;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject disp;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float showDuration;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float closeTime;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine closeRoutine;

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0xD3C324", Offset = "0xD3C324", VA = "0xD3C324")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0xD3C3EC", Offset = "0xD3C3EC", VA = "0xD3C3EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0xD3C350", Offset = "0xD3C350", VA = "0xD3C350")]
	public void SetDisplayObject(bool isActive)
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0xD3C454", Offset = "0xD3C454", VA = "0xD3C454")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C9008", Offset = "0x9C9008")]
	private IEnumerator CloseRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0xD3C4FC", Offset = "0xD3C4FC", VA = "0xD3C4FC")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x2000132")]
public class TextLocalizeFromData : MonoBehaviour
{
	[Token(Token = "0x20001E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF288", Offset = "0x9BF288")]
	private sealed class <ApplyDelayRoutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextLocalizeFromData <>4__this;

		[Token(Token = "0x170000BA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xD3DB6C", Offset = "0xD3DB6C", VA = "0xD3DB6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xD3DBD4", Offset = "0xD3DBD4", VA = "0xD3DBD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xD3D9B8", Offset = "0xD3D9B8", VA = "0xD3D9B8")]
		[DebuggerHidden]
		public <ApplyDelayRoutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xD3D9EC", Offset = "0xD3D9EC", VA = "0xD3D9EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xD3D9F0", Offset = "0xD3D9F0", VA = "0xD3D9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xD3DB74", Offset = "0xD3DB74", VA = "0xD3DB74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string id;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material defaultTmpMat;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material chineseTmpMat;

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0xD3D4B0", Offset = "0xD3D4B0", VA = "0xD3D4B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0xD3D5D8", Offset = "0xD3D5D8", VA = "0xD3D5D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C906C", Offset = "0x9C906C")]
	private IEnumerator ApplyDelayRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0xD3D654", Offset = "0xD3D654", VA = "0xD3D654")]
	private void Apply()
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0xD3D9E4", Offset = "0xD3D9E4", VA = "0xD3D9E4")]
	public TextLocalizeFromData()
	{
	}
}
[Token(Token = "0x2000133")]
public class TitleGameStartButton : UiItemBase
{
	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GeneralGameManager.GameMode mode;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool isSelected;

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0xD3DBEC", Offset = "0xD3DBEC", VA = "0xD3DBEC", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0xD3DDF4", Offset = "0xD3DDF4", VA = "0xD3DDF4")]
	public TitleGameStartButton()
	{
	}
}
[Token(Token = "0x2000134")]
public class TitleMenu : SingletonMonoBehaviour<TitleMenu>
{
	[Token(Token = "0x20001E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF298", Offset = "0x9BF298")]
	private sealed class <Start>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TitleMenu <>4__this;

		[Token(Token = "0x170000BC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xD3ED48", Offset = "0xD3ED48", VA = "0xD3ED48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xD3EDB0", Offset = "0xD3EDB0", VA = "0xD3EDB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xD3E404", Offset = "0xD3E404", VA = "0xD3E404")]
		[DebuggerHidden]
		public <Start>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xD3EA00", Offset = "0xD3EA00", VA = "0xD3EA00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xD3EA04", Offset = "0xD3EA04", VA = "0xD3EA04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xD3ED50", Offset = "0xD3ED50", VA = "0xD3ED50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5798", Offset = "0x9C5798")]
	[SerializeField]
	private GameObject startBtn;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject shopManageBtn;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject leaderboardBtn;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip titleVoice;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Collider[] buttonColliders;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isLoadGameScene;

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0xD3E388", Offset = "0xD3E388", VA = "0xD3E388")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C90D0", Offset = "0x9C90D0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xD3E430", Offset = "0xD3E430", VA = "0xD3E430")]
	private void Update()
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xD3E73C", Offset = "0xD3E73C", VA = "0xD3E73C")]
	public void LoadGameScene()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xD3DCA4", Offset = "0xD3DCA4", VA = "0xD3DCA4")]
	public void StartGame(GeneralGameManager.GameMode mode)
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xD3E860", Offset = "0xD3E860", VA = "0xD3E860")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C9134", Offset = "0x9C9134")]
	public void StartTutorial()
	{
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xD3E9B0", Offset = "0xD3E9B0", VA = "0xD3E9B0")]
	public TitleMenu()
	{
	}
}
[Token(Token = "0x2000135")]
public class TotalMoneyText : MonoBehaviour
{
	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text text;

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xD433DC", Offset = "0xD433DC", VA = "0xD433DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xD4343C", Offset = "0xD4343C", VA = "0xD4343C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xD434C4", Offset = "0xD434C4", VA = "0xD434C4")]
	public TotalMoneyText()
	{
	}
}
[Token(Token = "0x2000136")]
public class TutorialStartButton : UiItemBase
{
	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isSelected;

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xD491B4", Offset = "0xD491B4", VA = "0xD491B4", Slot = "8")]
	public override void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0xD49268", Offset = "0xD49268", VA = "0xD49268")]
	public TutorialStartButton()
	{
	}
}
[Token(Token = "0x2000137")]
public class UiOrderItem : MonoBehaviour
{
	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5824", Offset = "0x9C5824")]
	[SerializeField]
	private int chairNum;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject customerObj;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OrderItem orderItem;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5890", Offset = "0x9C5890")]
	[SerializeField]
	private Image customerFaceImage;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private Image customerProfileBackImage;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Text timeText;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private Text nameText;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	private TextMeshProUGUI numText;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C591C", Offset = "0x9C591C")]
	[SerializeField]
	private GameObject orderCallObj;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[SerializeField]
	private GameObject kaedamaOrderObj;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private GameObject cleanupObj;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5988", Offset = "0x9C5988")]
	[SerializeField]
	private GameObject orderIconRoot;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private TextMeshProUGUI noodleHardnessText;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[SerializeField]
	private GameObject kaedamaIconObj;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[SerializeField]
	private Image meatImage;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Image leekImage;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private Image secretTareImage;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private Image beerImage;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private Image riceImage;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private TextMeshProUGUI kaedamaTitleText;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private TextMeshProUGUI kaedamaHardnessText;

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x1923FA8", Offset = "0x1923FA8", VA = "0x1923FA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x192405C", Offset = "0x192405C", VA = "0x192405C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x9C916C", Offset = "0x9C916C")]
	private void DetectComponent()
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x192454C", Offset = "0x192454C", VA = "0x192454C")]
	public void SetProfile(int posNum)
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x19246E0", Offset = "0x19246E0", VA = "0x19246E0")]
	private void SyncProfileImage()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x1923FAC", Offset = "0x1923FAC", VA = "0x1923FAC")]
	private void UpdateStatus()
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x1924DE0", Offset = "0x1924DE0", VA = "0x1924DE0")]
	private void SetOrderIcon()
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x192484C", Offset = "0x192484C", VA = "0x192484C")]
	private void SetOrderCall()
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x1924A70", Offset = "0x1924A70", VA = "0x1924A70")]
	private void SetKaedamaOrderCall()
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x1924D18", Offset = "0x1924D18", VA = "0x1924D18")]
	private void SetCleanupCall()
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x1925310", Offset = "0x1925310", VA = "0x1925310")]
	public UiOrderItem()
	{
	}
}
[Token(Token = "0x2000138")]
public class UiTrayBaloon : MonoBehaviour
{
	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5A64", Offset = "0x9C5A64")]
	[SerializeField]
	private GameObject uiCanvasRoot;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI noodleHardnessText;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image meatImage;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image leekImage;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image secretTareImage;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image beerImage;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image riceImage;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject[] chairNumObjects;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float checkTimeDelay;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Canvas canvas;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ToolTray toolTray;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GrabbableItem grabbableItem;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float nextCheckTime;

	[Token(Token = "0x4000726")]
	private const float CHECK_TRAY_INTERVAL = 1.5f;

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x1925318", Offset = "0x1925318", VA = "0x1925318")]
	private void Start()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x1925400", Offset = "0x1925400", VA = "0x1925400")]
	private void Update()
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x1925AC4", Offset = "0x1925AC4", VA = "0x1925AC4")]
	private void ResetContents()
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x1925D28", Offset = "0x1925D28", VA = "0x1925D28")]
	private void SetRamenData(RamenBowl ramen)
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x1925F3C", Offset = "0x1925F3C", VA = "0x1925F3C")]
	public UiTrayBaloon()
	{
	}
}
[Token(Token = "0x2000139")]
public class ActivateByDistance : MonoBehaviour
{
	[Token(Token = "0x20001E7")]
	public enum OriginPosTarget
	{
		[Token(Token = "0x4000B07")]
		Head,
		[Token(Token = "0x4000B08")]
		Hand,
		[Token(Token = "0x4000B09")]
		StandingPos
	}

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5B30", Offset = "0x9C5B30")]
	[SerializeField]
	private float distance;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5B7C", Offset = "0x9C5B7C")]
	[SerializeField]
	private OriginPosTarget originPosTarget;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float forwardOffset;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject targetObj;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float distanceThreshold;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform headTf;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform rightHandTf;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform leftHandTf;

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0xEB5D60", Offset = "0xEB5D60", VA = "0xEB5D60")]
	private void Start()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0xEB5EC4", Offset = "0xEB5EC4", VA = "0xEB5EC4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0xEB6498", Offset = "0xEB6498", VA = "0xEB6498")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0xEB6604", Offset = "0xEB6604", VA = "0xEB6604")]
	public ActivateByDistance()
	{
	}
}
[Token(Token = "0x200013A")]
public class ChangeMaterialByDistance : MonoBehaviour
{
	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5BF8", Offset = "0x9C5BF8")]
	[SerializeField]
	private float distance;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5C44", Offset = "0x9C5C44")]
	[SerializeField]
	private float disableDistance;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material changeMat;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material defaultMat;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0xEC3DB8", Offset = "0xEC3DB8", VA = "0xEC3DB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0xEC3E3C", Offset = "0xEC3E3C", VA = "0xEC3E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0xEC4030", Offset = "0xEC4030", VA = "0xEC4030")]
	public ChangeMaterialByDistance()
	{
	}
}
[Token(Token = "0x200013B")]
public class CookBase : MonoBehaviour
{
	[Token(Token = "0x20001E8")]
	public enum Rating
	{
		[Token(Token = "0x4000B0B")]
		None,
		[Token(Token = "0x4000B0C")]
		Good,
		[Token(Token = "0x4000B0D")]
		Bad,
		[Token(Token = "0x4000B0E")]
		Angry
	}

	[Token(Token = "0x20001E9")]
	public enum DishType
	{
		[Token(Token = "0x4000B10")]
		None,
		[Token(Token = "0x4000B11")]
		Ramen,
		[Token(Token = "0x4000B12")]
		Rice,
		[Token(Token = "0x4000B13")]
		Beer,
		[Token(Token = "0x4000B14")]
		RefillNoodle
	}

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5CA0", Offset = "0x9C5CA0")]
	public Rating rating;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public DishType dishType;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObscuredBool isComplete;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ObscuredBool isTakedByCustomer;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ObscuredBool isNeedWash;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public ObscuredBool isDetectedByCustomer;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5CD8", Offset = "0x9C5CD8")]
	public ParticleSystem completeEffectGood;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem completeEffectBad;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleSystem processEffectGood;

	[Token(Token = "0x6000600")]
	[Address(RVA = "0xEC53D0", Offset = "0xEC53D0", VA = "0xEC53D0", Slot = "4")]
	protected virtual void SetComplete()
	{
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0xEBC9E0", Offset = "0xEBC9E0", VA = "0xEBC9E0")]
	public CookBase()
	{
	}
}
[Token(Token = "0x200013C")]
public class DishSpawnerBase : MonoBehaviour
{
	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5D10", Offset = "0x9C5D10")]
	[SerializeField]
	protected float spawnTimeRemain;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected GameObject holdObject;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5D6C", Offset = "0x9C5D6C")]
	[SerializeField]
	protected float initSpawnTime;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected GameObject spawnObject;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected float spawnInterval;

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x1D4BA7C", Offset = "0x1D4BA7C", VA = "0x1D4BA7C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x1D4BA88", Offset = "0x1D4BA88", VA = "0x1D4BA88")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x1D4BAE4", Offset = "0x1D4BAE4", VA = "0x1D4BAE4")]
	protected void SpawnObject()
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x1D4BC60", Offset = "0x1D4BC60", VA = "0x1D4BC60", Slot = "4")]
	protected virtual void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x1D4BC54", Offset = "0x1D4BC54", VA = "0x1D4BC54")]
	protected void ResetSpawnTimeRemain()
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x1D4BD20", Offset = "0x1D4BD20", VA = "0x1D4BD20", Slot = "5")]
	protected virtual bool IsEnableSpawn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x1D4BD28", Offset = "0x1D4BD28", VA = "0x1D4BD28")]
	public DishSpawnerBase()
	{
	}
}
[Token(Token = "0x200013D")]
public class DoorKnobAgent : MonoBehaviour
{
	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5DD8", Offset = "0x9C5DD8")]
	public bool isEnable;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isGrabbed;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	protected bool isGrabbedRightHand;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5E20", Offset = "0x9C5E20")]
	[SerializeField]
	protected AudioClip lockedSound;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AudioSource audioSource;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected Transform doorHingeTf;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector3 grabPosOffset;

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x1D4BD44", Offset = "0x1D4BD44", VA = "0x1D4BD44", Slot = "4")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x1D4BD5C", Offset = "0x1D4BD5C", VA = "0x1D4BD5C")]
	protected void LookAt()
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x1D4BE94", Offset = "0x1D4BE94", VA = "0x1D4BE94")]
	public void Grab(bool isRight)
	{
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x1D4C00C", Offset = "0x1D4C00C", VA = "0x1D4C00C", Slot = "5")]
	protected virtual void PlayLockEffect()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x1D4C030", Offset = "0x1D4C030", VA = "0x1D4C030", Slot = "6")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x1D4C038", Offset = "0x1D4C038", VA = "0x1D4C038")]
	public DoorKnobAgent()
	{
	}
}
[Token(Token = "0x200013E")]
public class GrabReactor : MonoBehaviour
{
	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5E8C", Offset = "0x9C5E8C")]
	public bool isGrabEnable;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isGrabbed;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool isGrabbedRightHand;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isGrabbedChopsticks;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isGrabbedNpc;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GrabReactorTriggerBase grabReactorTrigger;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject grabMarkerObj;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5EC4", Offset = "0x9C5EC4")]
	public bool leftGrabReaction;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool rightGrabReaction;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool chopstickReaction;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float markerCloseTime;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float markerShowDuration;

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x1D50654", Offset = "0x1D50654", VA = "0x1D50654", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x1D50660", Offset = "0x1D50660", VA = "0x1D50660", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x1D506A8", Offset = "0x1D506A8", VA = "0x1D506A8", Slot = "6")]
	public virtual void Reaction(GameObject triggeredObject)
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x1D506AC", Offset = "0x1D506AC", VA = "0x1D506AC", Slot = "7")]
	public virtual void ShowMarker()
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x1D50750", Offset = "0x1D50750", VA = "0x1D50750", Slot = "8")]
	protected virtual void CloseMarker()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x1D507E8", Offset = "0x1D507E8", VA = "0x1D507E8")]
	public GrabReactor()
	{
	}
}
[Token(Token = "0x200013F")]
public class GrabReactorTriggerBase : MonoBehaviour
{
	[Token(Token = "0x20001EA")]
	public enum GrabMechanism
	{
		[Token(Token = "0x4000B16")]
		FixedJoint,
		[Token(Token = "0x4000B17")]
		Kinematic
	}

	[Token(Token = "0x20001EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF2A8", Offset = "0x9BF2A8")]
	private sealed class <SetActiveCollidersRoutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrabReactorTriggerBase <>4__this;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isActive;

		[Token(Token = "0x170000BE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x1D51ACC", Offset = "0x1D51ACC", VA = "0x1D51ACC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x1D51B34", Offset = "0x1D51B34", VA = "0x1D51B34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x1D518A4", Offset = "0x1D518A4", VA = "0x1D518A4")]
		[DebuggerHidden]
		public <SetActiveCollidersRoutine>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1D519B4", Offset = "0x1D519B4", VA = "0x1D519B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1D519B8", Offset = "0x1D519B8", VA = "0x1D519B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1D51AD4", Offset = "0x1D51AD4", VA = "0x1D51AD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5EFC", Offset = "0x9C5EFC")]
	public GameObject grabbedObj;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5F34", Offset = "0x9C5F34")]
	[SerializeField]
	protected GrabMechanism grabMechanism;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected Vector3 defaultGrabLocalPos;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected Transform fitPosAnchorTf;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform checkOriginPosTf;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float grabbableRadius;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float extendedGrabbableRadius;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float extendedRadiusHeight;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected float grabColDistance;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isRight;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool isChopsticks;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Collider[] disableColliderIfGrabbed;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected float colliderEnableDelayIfReleaseObject;

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x1D5080C", Offset = "0x1D5080C", VA = "0x1D5080C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x1D50884", Offset = "0x1D50884", VA = "0x1D50884", Slot = "4")]
	protected virtual bool GetNearestObject(out GameObject nearestObjParent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x1D50DC4", Offset = "0x1D50DC4", VA = "0x1D50DC4", Slot = "5")]
	public virtual void Grab(GameObject obj)
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x1D512F4", Offset = "0x1D512F4", VA = "0x1D512F4", Slot = "6")]
	protected virtual void SetToFitPos()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x1D512F8", Offset = "0x1D512F8", VA = "0x1D512F8", Slot = "7")]
	public virtual void Release(Vector3 velocity, Vector3 angularVelocity, bool isImmediately = true)
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x1D51540", Offset = "0x1D51540", VA = "0x1D51540", Slot = "8")]
	protected virtual void ReactorMarkerActivate(GameObject reactor)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x1D515F0", Offset = "0x1D515F0", VA = "0x1D515F0", Slot = "9")]
	protected virtual void ReactorTrigger(GameObject reactor)
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x1D516C0", Offset = "0x1D516C0", VA = "0x1D516C0", Slot = "10")]
	public virtual void DestroyGrabbedObject()
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x1D517D4", Offset = "0x1D517D4", VA = "0x1D517D4", Slot = "11")]
	public virtual void SetActiveColliders(bool isActive, float delay = 0f)
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x1D51804", Offset = "0x1D51804", VA = "0x1D51804")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C91A4", Offset = "0x9C91A4")]
	private IEnumerator SetActiveCollidersRoutine(bool isActive, float delay)
	{
		return null;
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x1D518D0", Offset = "0x1D518D0", VA = "0x1D518D0", Slot = "12")]
	protected virtual void SyncToPosition()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x1D5198C", Offset = "0x1D5198C", VA = "0x1D5198C")]
	public GrabReactorTriggerBase()
	{
	}
}
[Token(Token = "0x2000140")]
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C5FC0", Offset = "0x9C5FC0")]
	[SerializeField]
	private bool dontDestroyOnLoad;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x1700000B")]
	public static T Instance
	{
		[Token(Token = "0x6000621")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000622")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000623")]
	protected SingletonMonoBehaviour()
	{
	}
}
[Token(Token = "0x2000141")]
public class TouchMenuItem : MonoBehaviour
{
	[Token(Token = "0x20001EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF2B8", Offset = "0x9BF2B8")]
	private sealed class <Start>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TouchMenuItem <>4__this;

		[Token(Token = "0x170000C0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xD43A64", Offset = "0xD43A64", VA = "0xD43A64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xD43ACC", Offset = "0xD43ACC", VA = "0xD43ACC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xD43568", Offset = "0xD43568", VA = "0xD43568")]
		[DebuggerHidden]
		public <Start>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xD4397C", Offset = "0xD4397C", VA = "0xD4397C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xD43980", Offset = "0xD43980", VA = "0xD43980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xD43A6C", Offset = "0xD43A6C", VA = "0xD43A6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF2C8", Offset = "0x9BF2C8")]
	private sealed class <EnableDelayRoutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TouchMenuItem <>4__this;

		[Token(Token = "0x170000C2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xD4390C", Offset = "0xD4390C", VA = "0xD4390C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0xD43974", Offset = "0xD43974", VA = "0xD43974", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xD437E0", Offset = "0xD437E0", VA = "0xD437E0")]
		[DebuggerHidden]
		public <EnableDelayRoutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xD43824", Offset = "0xD43824", VA = "0xD43824", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xD43828", Offset = "0xD43828", VA = "0xD43828", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xD43914", Offset = "0xD43914", VA = "0xD43914", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Collider touchCollider;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected float awakeDelay;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AudioClip touchSound;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float enableDelay;

	[Token(Token = "0x6000624")]
	[Address(RVA = "0xD434CC", Offset = "0xD434CC", VA = "0xD434CC")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0xD434EC", Offset = "0xD434EC", VA = "0xD434EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C9208", Offset = "0x9C9208")]
	protected IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0xD43594", Offset = "0xD43594", VA = "0xD43594", Slot = "4")]
	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0xD43660", Offset = "0xD43660", VA = "0xD43660", Slot = "5")]
	protected virtual void Touched()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0xD43764", Offset = "0xD43764", VA = "0xD43764")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C926C", Offset = "0x9C926C")]
	private IEnumerator EnableDelayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0xD4380C", Offset = "0xD4380C", VA = "0xD4380C")]
	public TouchMenuItem()
	{
	}
}
[Token(Token = "0x2000142")]
public class UiItemBase : MonoBehaviour
{
	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C603C", Offset = "0x9C603C")]
	[SerializeField]
	protected float selectTimeRemain;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6088", Offset = "0x9C6088")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C6088", Offset = "0x9C6088")]
	protected GameObject selectObj;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C60F8", Offset = "0x9C60F8")]
	protected Color onPointerColor;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C6144", Offset = "0x9C6144")]
	protected Image changeColorTarget;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected AudioClip selectSound;

	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C61A0", Offset = "0x9C61A0")]
	[SerializeField]
	protected Animator buttonAnimator;

	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected string onPointerAnimTrigger;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected string exitPointerAnimTrigger;

	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C620C", Offset = "0x9C620C")]
	public bool rightTrigger;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool rightButton;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool leftTrigger;

	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	public bool leftButton;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected float selectDuration;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Color initColor;

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1923A0C", Offset = "0x1923A0C", VA = "0x1923A0C", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x1923AB4", Offset = "0x1923AB4", VA = "0x1923AB4", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x1923B18", Offset = "0x1923B18", VA = "0x1923B18", Slot = "6")]
	public virtual void OnPointer()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x1923C54", Offset = "0x1923C54", VA = "0x1923C54")]
	private void ResetSelectTimeRemain()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x1923C60", Offset = "0x1923C60", VA = "0x1923C60", Slot = "7")]
	protected virtual void ExitPointer()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x1923DBC", Offset = "0x1923DBC", VA = "0x1923DBC", Slot = "8")]
	public virtual void SelectItem(bool isRight = false)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x1923EF8", Offset = "0x1923EF8", VA = "0x1923EF8")]
	public UiItemBase()
	{
	}
}
[Token(Token = "0x2000143")]
public static class CustomExt
{
	[Token(Token = "0x6000631")]
	[Address(RVA = "0xEC5D04", Offset = "0xEC5D04", VA = "0xEC5D04")]
	public static string ToFullName(this NoodleState.HardnessStep self)
	{
		return null;
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0xEC5E88", Offset = "0xEC5E88", VA = "0xEC5E88")]
	public static string ToSymbol(this NoodleState.HardnessStep self)
	{
		return null;
	}
}
[Token(Token = "0x2000144")]
public static class FloatExt
{
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x1D4E360", Offset = "0x1D4E360", VA = "0x1D4E360")]
	public static string ToTime(this float self)
	{
		return null;
	}
}
[Token(Token = "0x2000145")]
public static class IntExt
{
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x1D57614", Offset = "0x1D57614", VA = "0x1D57614")]
	public static string ToKanji(this int self)
	{
		return null;
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x1D57684", Offset = "0x1D57684", VA = "0x1D57684")]
	public static string ToSeatNum(this int self)
	{
		return null;
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x1D57848", Offset = "0x1D57848", VA = "0x1D57848")]
	public static string ToVisitorCount(this int self)
	{
		return null;
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x1D57A00", Offset = "0x1D57A00", VA = "0x1D57A00")]
	public static string ToLevelUi(this int self)
	{
		return null;
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1D57BB0", Offset = "0x1D57BB0", VA = "0x1D57BB0")]
	public static string ToNextScoreUi(this int self)
	{
		return null;
	}
}
[Token(Token = "0x2000146")]
public static class VectorExt
{
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x1929854", Offset = "0x1929854", VA = "0x1929854")]
	public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
	{
		return default(float);
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x2000147")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20001EE")]
		private class CameraState
		{
			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1928D78", Offset = "0x1928D78", VA = "0x1928D78")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1929400", Offset = "0x1929400", VA = "0x1929400")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x19294D0", Offset = "0x19294D0", VA = "0x19294D0")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x19295F4", Offset = "0x19295F4", VA = "0x19295F4")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x192984C", Offset = "0x192984C", VA = "0x192984C")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6244", Offset = "0x9C6244")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C6244", Offset = "0x9C6244")]
		public float boost;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C62A4", Offset = "0x9C62A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C62A4", Offset = "0x9C62A4")]
		public float positionLerpTime;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C62FC", Offset = "0x9C62FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C62FC", Offset = "0x9C62FC")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C635C", Offset = "0x9C635C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C635C", Offset = "0x9C635C")]
		public float rotationLerpTime;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C63B4", Offset = "0x9C63B4")]
		public bool invertY;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1928D20", Offset = "0x1928D20", VA = "0x1928D20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1928E00", Offset = "0x1928E00", VA = "0x1928E00")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x19290BC", Offset = "0x19290BC", VA = "0x19290BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1929684", Offset = "0x1929684", VA = "0x1929684")]
		public SimpleCameraController()
		{
		}
	}
}
namespace UnityEngine.Rendering.Universal
{
	[Token(Token = "0x2000148")]
	public class PostProcessUrp : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x20001EF")]
		public class PostProcessSettings
		{
			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C66A8", Offset = "0x9C66A8")]
			public int NumberOfPasses;

			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool Blur;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C66C0", Offset = "0x9C66C0")]
			public float BlurAmount;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Texture2D BlurMask;

			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool Bloom;

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Color BloomColor;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C66D8", Offset = "0x9C66D8")]
			public float BloomAmount;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C66F0", Offset = "0x9C66F0")]
			public float BloomDiffuse;

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6708", Offset = "0x9C6708")]
			public float BloomThreshold;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool LUT;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6720", Offset = "0x9C6720")]
			public int LutDimension;

			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6738", Offset = "0x9C6738")]
			public float LutAmount;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Texture2D SourceLut;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public bool ImageFiltering;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Color Color;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6750", Offset = "0x9C6750")]
			public float Contrast;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6768", Offset = "0x9C6768")]
			public float Brightness;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6780", Offset = "0x9C6780")]
			public float Saturation;

			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6798", Offset = "0x9C6798")]
			public float Exposure;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C67B0", Offset = "0x9C67B0")]
			public float Gamma;

			[Token(Token = "0x4000B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C67C8", Offset = "0x9C67C8")]
			public float Sharpness;

			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public bool ChromaticAberration;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public float Offset;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C67E0", Offset = "0x9C67E0")]
			public float FishEyeDistortion;

			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C67F8", Offset = "0x9C67F8")]
			public float GlitchAmount;

			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public bool Distortion;

			[Token(Token = "0x4000B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6810", Offset = "0x9C6810")]
			public float LensDistortion;

			[Token(Token = "0x4000B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public bool Vignette;

			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Color VignetteColor;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6828", Offset = "0x9C6828")]
			public float VignetteAmount;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C6840", Offset = "0x9C6840")]
			public float VignetteSoftness;

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x19266A8", Offset = "0x19266A8", VA = "0x19266A8")]
			public PostProcessSettings()
			{
			}
		}

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PostProcessSettings settings;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PostProcessUrpPass ppsUrpPass;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1925F44", Offset = "0x1925F44", VA = "0x1925F44", Slot = "4")]
		public override void Create()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x19265D4", Offset = "0x19265D4", VA = "0x19265D4", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1926638", Offset = "0x1926638", VA = "0x1926638")]
		public PostProcessUrp()
		{
		}
	}
	[Token(Token = "0x2000149")]
	internal class PostProcessUrpPass : ScriptableRenderPass
	{
		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Material material;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C63EC", Offset = "0x9C63EC")]
		private FilterMode <filterMode>k__BackingField;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTargetIdentifier source;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTargetIdentifier blurTemp;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RenderTargetIdentifier blurTemp1;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTargetIdentifier blurTex;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RenderTargetIdentifier tempCopy;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool maskSet;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly string tag;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private readonly int numberOfPasses;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private readonly bool blur;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly float blurAmount;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly Texture2D blurMask;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private readonly bool bloom;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private readonly Color bloomColor;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private readonly float bloomAmount;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly float bloomDiffuse;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private readonly float bloomThreshold;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private readonly bool lut;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly Texture2D sourceLut;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly float lutAmount;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private readonly int lutDimension;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly bool imageFiltering;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private readonly Color color;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private readonly float contrast;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly float brightness;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private readonly float saturation;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly float exposure;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private readonly float gamma;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly float sharpness;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private readonly bool chromaticAberration;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly float offset;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private readonly float fishEyeDistortion;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly float glitchAmount;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private readonly bool distortion;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly float lensDistortion;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private readonly bool vignette;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly Color vignetteColor;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly float vignetteAmount;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private readonly float vignetteSoftness;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int blurTexString;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int maskTextureString;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int blurAmountString;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int bloomColorString;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int blAmountString;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int blDiffuseString;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int blThresholdString;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int lutTexture2DString;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int lutTexture3DString;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int lutAmountString;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int colorString;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int contrastString;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int brightnessString;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int saturationString;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int exposureString;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly int gammaString;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int centralFactorString;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly int sideFactorString;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly int offsetString;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static readonly int fishEyeString;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int lensdistortionString;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static readonly int vignetteColorString;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int vignetteAmountString;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static readonly int vignetteSoftnessString;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly int blurTempString;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static readonly int blurTemp1String;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly int tempCopyString;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly string bloomKeyword;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly string blurKeyword;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly string chromaKeyword;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static readonly string lutKeyword;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly string filterKeyword;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly string shaprenKeyword;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static readonly string distortionKeyword;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int previousLutDimension;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Texture2D previous;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Texture2D converted2D;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Texture3D converted3D;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float t;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float a;

		[Token(Token = "0x1700000C")]
		public FilterMode filterMode
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1926730", Offset = "0x1926730", VA = "0x1926730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C9350", Offset = "0x9C9350")]
			get
			{
				return default(FilterMode);
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1926738", Offset = "0x1926738", VA = "0x1926738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C9360", Offset = "0x9C9360")]
			set
			{
			}
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x19261C0", Offset = "0x19261C0", VA = "0x19261C0")]
		public PostProcessUrpPass(RenderPassEvent renderPassEvent, Material material, int numberOfPasses, bool blur, float blurAmount, Texture2D blurMask, bool bloom, Color bloomColor, float bloomAmount, float bloomDiffuse, float bloomThreshold, bool lut, int lutDimension, float lutAmount, Texture2D sourceLut, bool imageFiltering, Color color, float contrast, float saturation, float brightness, float exposure, float gamma, float sharpness, bool chromaticAberration, float offset, float fishEyeDistortion, float glitchAmount, bool distortion, float lensDistortion, bool vignette, Color vignetteColor, float vignetteAmount, float vignetteSoftness, string tag)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1926740", Offset = "0x1926740", VA = "0x1926740")]
		public void Setup(RenderTargetIdentifier source)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1926758", Offset = "0x1926758", VA = "0x1926758", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x19282D0", Offset = "0x19282D0", VA = "0x19282D0", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1928208", Offset = "0x1928208", VA = "0x1928208")]
		private void isConverted()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x19283A8", Offset = "0x19283A8", VA = "0x19283A8")]
		private void Convert2D(Texture2D temp2DTex)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x19286CC", Offset = "0x19286CC", VA = "0x19286CC")]
		private void Convert3D(Texture2D temp3DTex)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1928394", Offset = "0x1928394", VA = "0x1928394")]
		private void Convert(Texture2D source)
		{
		}
	}
}
namespace LuxURPEssentials
{
	[Token(Token = "0x200014A")]
	public class DecalManager : MonoBehaviour
	{
		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Gizmos;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DrawDecalGizmos;

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xDB4324", Offset = "0xDB4324", VA = "0xDB4324")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xDB4394", Offset = "0xDB4394", VA = "0xDB4394")]
		public DecalManager()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class LuxURP_HelpBtn : PropertyAttribute
	{
		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xDB44C0", Offset = "0xDB44C0", VA = "0xDB44C0")]
		public LuxURP_HelpBtn(string URL)
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LuxURP_HelpBtn", RVA = "0x9C63FC", Offset = "0x9C63FC")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C63FC", Offset = "0x9C63FC")]
		public LayerMask SmallDetailsLayer;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SmallDetailsDistance;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask MediumDetailsLayer;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MediumDetailsDistance;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xDB44F4", Offset = "0xDB44F4", VA = "0xDB44F4")]
		private int GetLayerNumber(int LayerValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xDB4514", Offset = "0xDB4514", VA = "0xDB4514")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xDB46C0", Offset = "0xDB46C0", VA = "0xDB46C0")]
		public LuxURP_LayerBasedCulling()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014D")]
	public enum RTSize
	{
		[Token(Token = "0x40007D7")]
		_128 = 0x80,
		[Token(Token = "0x40007D8")]
		_256 = 0x100,
		[Token(Token = "0x40007D9")]
		_512 = 0x200
	}
	[Serializable]
	[Token(Token = "0x200014E")]
	public enum RTFormat
	{
		[Token(Token = "0x40007DB")]
		ARGB32,
		[Token(Token = "0x40007DC")]
		ARGBHalf
	}
	[Serializable]
	[Token(Token = "0x200014F")]
	public enum GustMixLayer
	{
		[Token(Token = "0x40007DE")]
		Layer_0,
		[Token(Token = "0x40007DF")]
		Layer_1,
		[Token(Token = "0x40007E0")]
		Layer_2
	}
	[Token(Token = "0x2000150")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BEBA8", Offset = "0x9BEBA8")]
	public class LuxURP_Wind : MonoBehaviour
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C6460", Offset = "0x9C6460")]
		[AttributeAttribute(Name = "LuxURP_HelpBtn", RVA = "0x9C6460", Offset = "0x9C6460")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C6460", Offset = "0x9C6460")]
		public bool UpdateInEditMode;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C64C4", Offset = "0x9C64C4")]
		public RTSize Resolution;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RTFormat Format;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture WindBaseTex;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader WindCompositeShader;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C64FC", Offset = "0x9C64FC")]
		public float Grass;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Foliage;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6534", Offset = "0x9C6534")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C6534", Offset = "0x9C6534")]
		public float BaseWindSpeed;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C6594", Offset = "0x9C6594")]
		public float SizeInWorldSpace;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C65CC", Offset = "0x9C65CC")]
		public float speedLayer0;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float speedLayer1;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speedLayer2;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C65E0", Offset = "0x9C65E0")]
		public int GrassGustTiling;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float GrassGustSpeed;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public GustMixLayer LayerToMixWith;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6618", Offset = "0x9C6618")]
		public float JitterFrequency;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float JitterHighFrequency;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture WindRenderTexture;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_material;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 uvs;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 uvs1;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 uvs2;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 uvs3;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int WindRTPID;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform trans;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private WindZone windZone;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float mainWind;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turbulence;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int LuxLWRPWindDirSizePID;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int LuxLWRPWindStrengthMultipliersPID;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int LuxLWRPSinTimePID;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int LuxLWRPGustPID;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int LuxLWRPGustMixLayerPID;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int LuxLWRPWindUVsPID;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int LuxLWRPWindUVs1PID;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int LuxLWRPWindUVs2PID;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int LuxLWRPWindUVs3PID;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int previousRTSize;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int previousRTFormat;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector4 WindDirectionSize;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] MixLayers;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xDB46D8", Offset = "0xDB46D8", VA = "0xDB46D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xDB4B20", Offset = "0xDB4B20", VA = "0xDB4B20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xDB4874", Offset = "0xDB4874", VA = "0xDB4874")]
		private void SetupRT()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xDB49F0", Offset = "0xDB49F0", VA = "0xDB49F0")]
		private void GetPIDs()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xDB4C94", Offset = "0xDB4C94", VA = "0xDB4C94")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xDB4E78", Offset = "0xDB4E78", VA = "0xDB4E78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xDB53CC", Offset = "0xDB53CC", VA = "0xDB53CC")]
		public LuxURP_Wind()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BEC1C", Offset = "0x9BEC1C")]
	public class GetTerrainHeightNormalMap : MonoBehaviour
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData targetTerrainData;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string savePathTerrainHeightNormalMap;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xDB43F8", Offset = "0xDB43F8", VA = "0xDB43F8")]
		public void GetTerData()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xDB44B8", Offset = "0xDB44B8", VA = "0xDB44B8")]
		public GetTerrainHeightNormalMap()
		{
		}
	}
}
namespace Lux_SRP_GrassDisplacement
{
	[Token(Token = "0x2000152")]
	public class RotateAndMove : MonoBehaviour
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Rotate;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool MoveUpDown;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float posy;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform trans;

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xDB68C0", Offset = "0xDB68C0", VA = "0xDB68C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xDB693C", Offset = "0xDB693C", VA = "0xDB693C")]
		private void Update()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xDB6A54", Offset = "0xDB6A54", VA = "0xDB6A54")]
		public RotateAndMove()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetTransform;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothTime;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 velocity;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xDB6A64", Offset = "0xDB6A64", VA = "0xDB6A64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xDB6B74", Offset = "0xDB6B74", VA = "0xDB6B74")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[ExecuteInEditMode]
	public class ControlDisplacer : MonoBehaviour
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C6660", Offset = "0x9C6660")]
		public bool DebugRay;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Renderer rend;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock mpb;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xDB5658", Offset = "0xDB5658", VA = "0xDB5658")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xDB5740", Offset = "0xDB5740", VA = "0xDB5740")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xDB5780", Offset = "0xDB5780", VA = "0xDB5780")]
		private void Update()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xDB5924", Offset = "0xDB5924", VA = "0xDB5924")]
		public ControlDisplacer()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BEC90", Offset = "0x9BEC90")]
	public class ControlDisplacerParticleSys : MonoBehaviour
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9C6684", Offset = "0x9C6684")]
		public bool DebugRay;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem ps;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule main;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float min_alpha;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float max_alpha;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color min_StartColor;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color max_StartColor;

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xDB5940", Offset = "0xDB5940", VA = "0xDB5940")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xDB5A88", Offset = "0xDB5A88", VA = "0xDB5A88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xDB5CAC", Offset = "0xDB5CAC", VA = "0xDB5CAC")]
		public ControlDisplacerParticleSys()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class DebugGrassDisplacementTex : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001F0")]
		public enum DebugSize
		{
			[Token(Token = "0x4000B4B")]
			_128 = 0x80,
			[Token(Token = "0x4000B4C")]
			_256 = 0x100,
			[Token(Token = "0x4000B4D")]
			_512 = 0x200,
			[Token(Token = "0x4000B4E")]
			_1024 = 0x400
		}

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_EnableDebug;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DebugSize currentDebugSize;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xDB5CC8", Offset = "0xDB5CC8", VA = "0xDB5CC8")]
		public DebugGrassDisplacementTex()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class GrassDisplacementRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x20001F1")]
		public enum RTDisplacementSize
		{
			[Token(Token = "0x4000B50")]
			_128 = 0x80,
			[Token(Token = "0x4000B51")]
			_256 = 0x100,
			[Token(Token = "0x4000B52")]
			_512 = 0x200,
			[Token(Token = "0x4000B53")]
			_1024 = 0x400
		}

		[Serializable]
		[Token(Token = "0x20001F2")]
		public class GrassDisplacementSettings
		{
			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RTDisplacementSize Resolution;

			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Size;

			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool ShiftRenderTex;

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xDB68A4", Offset = "0xDB68A4", VA = "0xDB68A4")]
			public GrassDisplacementSettings()
			{
			}
		}

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrassDisplacementSettings settings;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GrassDisplacementPass m_GrassDisplacementPass;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xDB6730", Offset = "0xDB6730", VA = "0xDB6730", Slot = "4")]
		public override void Create()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xDB6800", Offset = "0xDB6800", VA = "0xDB6800", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xDB6824", Offset = "0xDB6824", VA = "0xDB6824")]
		public GrassDisplacementRenderFeature()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class GrassDisplacementPass : ScriptableRenderPass
	{
		[Token(Token = "0x400082D")]
		private const string k_RenderGrassDisplacementFXTag = "Render Lux Grass Displacement FX";

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ShaderTagId m_GrassDisplacementFXShaderTag;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color m_ClearColor;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTargetHandle m_GrassDisplacementFX;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Matrix4x4 worldToCameraMatrix;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float m_Size;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int m_Resolution;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool m_ShiftRenderTex;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float stepSize;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float oneOverStepSize;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector4 posSize;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int DisplacementTexPosSizePID;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6698", Offset = "0x9C6698")]
		private FilteringSettings <transparentFilterSettings>k__BackingField;

		[Token(Token = "0x1700000D")]
		private FilteringSettings transparentFilterSettings
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xDB5CE0", Offset = "0xDB5CE0", VA = "0xDB5CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C9370", Offset = "0x9C9370")]
			get
			{
				return default(FilteringSettings);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xDB5CF4", Offset = "0xDB5CF4", VA = "0xDB5CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C9380", Offset = "0x9C9380")]
			set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xDB5D08", Offset = "0xDB5D08", VA = "0xDB5D08")]
		public GrassDisplacementPass()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xDB5EB8", Offset = "0xDB5EB8", VA = "0xDB5EB8", Slot = "4")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xDB619C", Offset = "0xDB619C", VA = "0xDB619C", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xDB66A8", Offset = "0xDB66A8", VA = "0xDB66A8", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9BECF4", Offset = "0x9BECF4")]
	public class LayerAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000674")]
		[Address(RVA = "0xDB68B8", Offset = "0xDB68B8", VA = "0xDB68B8")]
		public LayerAttribute()
		{
		}
	}
}
namespace LuxLWRPEssentials.Demo
{
	[Token(Token = "0x200015A")]
	public class AnimateSphere : MonoBehaviour
	{
		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform trans;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float yPos;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1D5D674", Offset = "0x1D5D674", VA = "0x1D5D674")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1D5D6F0", Offset = "0x1D5D6F0", VA = "0x1D5D6F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1D5D7B0", Offset = "0x1D5D7B0", VA = "0x1D5D7B0")]
		public AnimateSphere()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class CheckSettings : MonoBehaviour
	{
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1D5D7B8", Offset = "0x1D5D7B8", VA = "0x1D5D7B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1D5D8E0", Offset = "0x1D5D8E0", VA = "0x1D5D8E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1D5D8E4", Offset = "0x1D5D8E4", VA = "0x1D5D8E4")]
		public CheckSettings()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class ExtendedFlycam : MonoBehaviour
	{
		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float climbSpeed;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float normalMoveSpeed;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoveFactor;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fastMoveFactor;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationX;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationY;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool isOrtho;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera cam;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isActive;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xDB3478", Offset = "0xDB3478", VA = "0xDB3478")]
		private void Start()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xDB3558", Offset = "0xDB3558", VA = "0xDB3558")]
		private void Update()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xDB3E88", Offset = "0xDB3E88", VA = "0xDB3E88")]
		public ExtendedFlycam()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class MouseSelect : MonoBehaviour
	{
		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform selectedTransform;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xDB3EAC", Offset = "0xDB3EAC", VA = "0xDB3EAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xDB413C", Offset = "0xDB413C", VA = "0xDB413C")]
		public MouseSelect()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class ToggleOutlineSelection : MonoBehaviour
	{
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SelectionMaterial;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material OutlineMaterial;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer rend;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material[] BaseMatArray;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material[] SelectedMatArray;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool Selected;

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xDB4144", Offset = "0xDB4144", VA = "0xDB4144")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xDB40E0", Offset = "0xDB40E0", VA = "0xDB40E0")]
		public void Select()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xDB429C", Offset = "0xDB429C", VA = "0xDB429C")]
		public ToggleOutlineSelection()
		{
		}
	}
}
