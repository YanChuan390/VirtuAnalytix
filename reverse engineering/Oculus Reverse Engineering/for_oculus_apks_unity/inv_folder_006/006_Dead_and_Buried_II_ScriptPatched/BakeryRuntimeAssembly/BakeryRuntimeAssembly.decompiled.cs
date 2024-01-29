using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("3.7.1.6")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x87B9A0", Offset = "0x87B9A0")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0x87B9A0", Offset = "0x87B9A0")]
public class BakeryDirectLight : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float intensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float shadowSpread;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int samples;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int bitmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool bakeToIndirect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool shadowmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool shadowmaskDenoise;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float indirectIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int UID;

	[Address(RVA = "0x1C18418", Offset = "0x1C18418", VA = "0x1C18418")]
	public BakeryDirectLight()
	{
	}
}
public struct BakeryLightmapGroupPlain
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string name;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int resolution;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int id;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int renderDirMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool vertexBake;

	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool containsTerrains;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool probes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isImplicit;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool computeSSS;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int sssSamples;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float sssDensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssR;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssG;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssB;
}
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x87B9D8", Offset = "0x87B9D8")]
public class BakeryLightmapGroup : ScriptableObject
{
	public enum ftLMGroupMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OriginalUV,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		PackAtlas,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Vertex
	}

	public enum RenderMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		FullLighting = 0,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Indirect = 1,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Shadowmask = 2,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Auto = 1000
	}

	public enum RenderDirMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		None = 0,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		BakedNormalMaps = 1,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		DominantDirection = 2,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RNM = 3,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		SH = 4,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		ProbeSH = 5,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Auto = 1000
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x87BAE4", Offset = "0x87BAE4")]
	public int resolution;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int bitmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int id;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sortingID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isImplicit;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float area;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int totalVertexCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int vertexCounter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int sceneLodLevel;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string sceneName;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public bool containsTerrains;

	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	public bool probes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public ftLMGroupMode mode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public RenderMode renderMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	public RenderDirMode renderDirMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public bool computeSSS;

	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public int sssSamples;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float sssDensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	public Color sssColor;

	[Address(RVA = "0x1C18650", Offset = "0x1C18650", VA = "0x1C18650")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Address(RVA = "0x1C186D0", Offset = "0x1C186D0", VA = "0x1C186D0")]
	public BakeryLightmapGroup()
	{
	}
}
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Object lmgroupAsset;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool instanceResolutionOverride;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int instanceResolution;

	[Address(RVA = "0x1C18734", Offset = "0x1C18734", VA = "0x1C18734")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Attribute(Name = "DisallowMultipleComponent", RVA = "0x87BA1C", Offset = "0x87BA1C")]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Address(RVA = "0x1C18744", Offset = "0x1C18744", VA = "0x1C18744")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Attribute(Name = "ExecuteInEditMode", RVA = "0x87BA2C", Offset = "0x87BA2C")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0x87BA2C", Offset = "0x87BA2C")]
public class BakeryLightMesh : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<MeshFilter> All;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutoff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int samples2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int bitmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool selfShadow;

	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool bakeToIndirect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float indirectIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int lmid;

	[Address(RVA = "0x1C1846C", Offset = "0x1C1846C", VA = "0x1C1846C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Address(RVA = "0x1C18578", Offset = "0x1C18578", VA = "0x1C18578")]
	public BakeryLightMesh()
	{
	}
}
[Attribute(Name = "ExecuteInEditMode", RVA = "0x87BA64", Offset = "0x87BA64")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0x87BA64", Offset = "0x87BA64")]
public class BakeryPointLight : MonoBehaviour
{
	public enum ftLightProjectionMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Omni,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Cookie,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Cubemap,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		IES
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shadowSpread;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cutoff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool realisticFalloff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ftLightProjectionMode projMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D cookie;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Cubemap cubemap;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Object iesFile;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int bitmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool bakeToIndirect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool shadowmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float indirectIntensity;

	[Address(RVA = "0x1C1874C", Offset = "0x1C1874C", VA = "0x1C1874C")]
	public BakeryPointLight()
	{
	}
}
[Attribute(Name = "ExecuteInEditMode", RVA = "0x87BA9C", Offset = "0x87BA9C")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0x87BA9C", Offset = "0x87BA9C")]
public class BakerySkyLight : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string texName;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float intensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int samples;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hemispherical;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bitmask;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool bakeToIndirect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float indirectIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool tangentSH;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Cubemap cubemap;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Address(RVA = "0x1C187B8", Offset = "0x1C187B8", VA = "0x1C187B8")]
	public BakerySkyLight()
	{
	}
}
public class ftGlobalStorage : ScriptableObject
{
	[Address(RVA = "0x1C18840", Offset = "0x1C18840", VA = "0x1C18840")]
	public ftGlobalStorage()
	{
	}
}
public class ftLightmaps
{
	private struct LightmapAdditionalData
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D rnm2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mode;
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool directionalMode;

	[Address(RVA = "0x1C18848", Offset = "0x1C18848", VA = "0x1C18848")]
	static ftLightmaps()
	{
	}

	[Address(RVA = "0x1C188F0", Offset = "0x1C188F0", VA = "0x1C188F0")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Address(RVA = "0x1C1895C", Offset = "0x1C1895C", VA = "0x1C1895C")]
	public static void RefreshFull()
	{
	}

	[Address(RVA = "0x1C1ABBC", Offset = "0x1C1ABBC", VA = "0x1C1ABBC")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Address(RVA = "0x1C1AD50", Offset = "0x1C1AD50", VA = "0x1C1AD50")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Address(RVA = "0x1C18A8C", Offset = "0x1C18A8C", VA = "0x1C18A8C")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Address(RVA = "0x1C1AD78", Offset = "0x1C1AD78", VA = "0x1C1AD78")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Address(RVA = "0x1C1B0EC", Offset = "0x1C1B0EC", VA = "0x1C1B0EC")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}

	[Address(RVA = "0x1C1B3C0", Offset = "0x1C1B3C0", VA = "0x1C1B3C0")]
	public ftLightmaps()
	{
	}
}
[Attribute(Name = "ExecuteInEditMode", RVA = "0x87BAD4", Offset = "0x87BAD4")]
public class ftLightmapsStorage : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> maps;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> masks;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Texture2D> dirMaps;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Texture2D> rnmMaps0;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Texture2D> rnmMaps1;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Texture2D> rnmMaps2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> mapsMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<MeshRenderer> bakedRenderers;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> bakedIDs;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector4> bakedScaleOffset;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Mesh> bakedVertexColorMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<MeshRenderer> nonBakedRenderers;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Light> bakedLights;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> bakedLightChannels;

	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Terrain> bakedRenderersTerrain;

	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> bakedIDsTerrain;

	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<string> assetList;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<int> uvOverlapAssetList;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] idremap;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool usesRealtimeGI;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D emptyDirectionTex;

	[Address(RVA = "0x1C1B3C8", Offset = "0x1C1B3C8", VA = "0x1C1B3C8")]
	private void Awake()
	{
	}

	[Address(RVA = "0x1C1B460", Offset = "0x1C1B460", VA = "0x1C1B460")]
	private void Start()
	{
	}

	[Address(RVA = "0x1C1B4E8", Offset = "0x1C1B4E8", VA = "0x1C1B4E8")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x1C1B54C", Offset = "0x1C1B54C", VA = "0x1C1B54C")]
	public ftLightmapsStorage()
	{
	}
}
public class ftLocalStorage : ScriptableObject
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Address(RVA = "0x1C1B7F4", Offset = "0x1C1B7F4", VA = "0x1C1B7F4")]
	public ftLocalStorage()
	{
	}
}
public static class ftUniqueIDRegistry
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> Mapping;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> MappingInv;

	[Address(RVA = "0x1C1B88C", Offset = "0x1C1B88C", VA = "0x1C1B88C")]
	public static void Deregister(int id)
	{
	}

	[Address(RVA = "0x1C1BA38", Offset = "0x1C1BA38", VA = "0x1C1BA38")]
	public static void Register(int id, int value)
	{
	}

	[Address(RVA = "0x1C1B98C", Offset = "0x1C1B98C", VA = "0x1C1B98C")]
	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	[Address(RVA = "0x1C1BB68", Offset = "0x1C1BB68", VA = "0x1C1BB68")]
	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
