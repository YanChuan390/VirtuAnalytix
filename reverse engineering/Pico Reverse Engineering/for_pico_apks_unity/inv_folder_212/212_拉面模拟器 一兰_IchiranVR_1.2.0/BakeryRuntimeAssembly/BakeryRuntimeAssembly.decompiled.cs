using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BakeryAlwaysRender : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1B126B4", Offset = "0x1B126B4", VA = "0x1B126B4")]
	public BakeryAlwaysRender()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryDirectLight : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color color;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float intensity;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float shadowSpread;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int samples;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int bitmask;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool shadowmask;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool shadowmaskDenoise;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float indirectIntensity;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int UID;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1B126BC", Offset = "0x1B126BC", VA = "0x1B126BC")]
	public BakeryDirectLight()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryLightMesh : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<MeshFilter> All;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutoff;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int samples2;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int bitmask;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool selfShadow;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float indirectIntensity;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int lmid;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1B1270C", Offset = "0x1B1270C", VA = "0x1B1270C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1B12808", Offset = "0x1B12808", VA = "0x1B12808")]
	public BakeryLightMesh()
	{
	}
}
[Token(Token = "0x2000005")]
public struct BakeryLightmapGroupPlain
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string name;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int resolution;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int id;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderMode;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int renderDirMode;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool vertexBake;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool containsTerrains;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool probes;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isImplicit;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool computeSSS;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int sssSamples;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float sssDensity;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssR;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssG;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssB;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fakeShadowBias;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool flipNormal;
}
[Token(Token = "0x2000006")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x927AF0", Offset = "0x927AF0")]
public class BakeryLightmapGroup : ScriptableObject
{
	[Token(Token = "0x2000010")]
	public enum ftLMGroupMode
	{
		[Token(Token = "0x4000082")]
		OriginalUV,
		[Token(Token = "0x4000083")]
		PackAtlas,
		[Token(Token = "0x4000084")]
		Vertex
	}

	[Token(Token = "0x2000011")]
	public enum RenderMode
	{
		[Token(Token = "0x4000086")]
		FullLighting = 0,
		[Token(Token = "0x4000087")]
		Indirect = 1,
		[Token(Token = "0x4000088")]
		Shadowmask = 2,
		[Token(Token = "0x4000089")]
		Subtractive = 3,
		[Token(Token = "0x400008A")]
		AmbientOcclusionOnly = 4,
		[Token(Token = "0x400008B")]
		Auto = 1000
	}

	[Token(Token = "0x2000012")]
	public enum RenderDirMode
	{
		[Token(Token = "0x400008D")]
		None = 0,
		[Token(Token = "0x400008E")]
		BakedNormalMaps = 1,
		[Token(Token = "0x400008F")]
		DominantDirection = 2,
		[Token(Token = "0x4000090")]
		RNM = 3,
		[Token(Token = "0x4000091")]
		SH = 4,
		[Token(Token = "0x4000092")]
		ProbeSH = 5,
		[Token(Token = "0x4000093")]
		Auto = 1000
	}

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x927BC4", Offset = "0x927BC4")]
	public int resolution;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int bitmask;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int id;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sortingID;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isImplicit;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float area;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int totalVertexCount;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int vertexCounter;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int sceneLodLevel;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string sceneName;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public bool containsTerrains;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	public bool probes;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public ftLMGroupMode mode;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public RenderMode renderMode;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	public RenderDirMode renderDirMode;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public bool computeSSS;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public int sssSamples;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float sssDensity;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	public Color sssColor;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	public float fakeShadowBias;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public bool transparentSelfShadow;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[SerializeField]
	public bool flipNormal;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public string overridePath;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B128EC", Offset = "0x1B128EC", VA = "0x1B128EC")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B129C0", Offset = "0x1B129C0", VA = "0x1B129C0")]
	public BakeryLightmapGroup()
	{
	}
}
[Token(Token = "0x2000007")]
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Object lmgroupAsset;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool instanceResolutionOverride;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int instanceResolution;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B12A64", Offset = "0x1B12A64", VA = "0x1B12A64")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Token(Token = "0x2000008")]
[DisallowMultipleComponent]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B12A74", Offset = "0x1B12A74", VA = "0x1B12A74")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryPointLight : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	public enum ftLightProjectionMode
	{
		[Token(Token = "0x4000095")]
		Omni,
		[Token(Token = "0x4000096")]
		Cookie,
		[Token(Token = "0x4000097")]
		Cubemap,
		[Token(Token = "0x4000098")]
		IES,
		[Token(Token = "0x4000099")]
		Cone
	}

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shadowSpread;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cutoff;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool realisticFalloff;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ftLightProjectionMode projMode;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D cookie;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angle;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float innerAngle;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Cubemap cubemap;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Object iesFile;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int bitmask;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool shadowmask;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float indirectIntensity;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float falloffMinRadius;

	[Token(Token = "0x4000056")]
	private const float GIZMO_MAXSIZE = 0.1f;

	[Token(Token = "0x4000057")]
	private const float GIZMO_SCALE = 0.01f;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float screenRadius;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B12A7C", Offset = "0x1B12A7C", VA = "0x1B12A7C")]
	public BakeryPointLight()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakerySkyLight : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string texName;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float intensity;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int samples;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hemispherical;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bitmask;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float indirectIntensity;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool tangentSH;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Cubemap cubemap;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B12AF0", Offset = "0x1B12AF0", VA = "0x1B12AF0")]
	public BakerySkyLight()
	{
	}
}
[Token(Token = "0x200000B")]
public class ftGlobalStorage : ScriptableObject
{
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1B12B80", Offset = "0x1B12B80", VA = "0x1B12B80")]
	public ftGlobalStorage()
	{
	}
}
[Token(Token = "0x200000C")]
public class ftLightmaps
{
	[Token(Token = "0x2000014")]
	private struct LightmapAdditionalData
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm1;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D rnm2;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mode;
	}

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int directionalMode;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1B12B88", Offset = "0x1B12B88", VA = "0x1B12B88")]
	static ftLightmaps()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1B12C50", Offset = "0x1B12C50", VA = "0x1B12C50")]
	private static void SetDirectionalMode()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1B12CF4", Offset = "0x1B12CF4", VA = "0x1B12CF4")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1B12D50", Offset = "0x1B12D50", VA = "0x1B12D50")]
	public static void RefreshFull()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1B14A08", Offset = "0x1B14A08", VA = "0x1B14A08")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1B14B50", Offset = "0x1B14B50", VA = "0x1B14B50")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B12F2C", Offset = "0x1B12F2C", VA = "0x1B12F2C")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B14B68", Offset = "0x1B14B68", VA = "0x1B14B68")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B14E08", Offset = "0x1B14E08", VA = "0x1B14E08")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1B15018", Offset = "0x1B15018", VA = "0x1B15018")]
	public ftLightmaps()
	{
	}
}
[Token(Token = "0x200000D")]
[ExecuteInEditMode]
public class ftLightmapsStorage : MonoBehaviour
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> maps;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> masks;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Texture2D> dirMaps;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Texture2D> rnmMaps0;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Texture2D> rnmMaps1;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Texture2D> rnmMaps2;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> mapsMode;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Renderer> bakedRenderers;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> bakedIDs;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector4> bakedScaleOffset;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Mesh> bakedVertexColorMesh;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Renderer> nonBakedRenderers;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Light> bakedLights;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> bakedLightChannels;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Terrain> bakedRenderersTerrain;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> bakedIDsTerrain;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<string> assetList;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<int> uvOverlapAssetList;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] idremap;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool usesRealtimeGI;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D emptyDirectionTex;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1B15020", Offset = "0x1B15020", VA = "0x1B15020")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1B150B0", Offset = "0x1B150B0", VA = "0x1B150B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1B15130", Offset = "0x1B15130", VA = "0x1B15130")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1B15194", Offset = "0x1B15194", VA = "0x1B15194")]
	public ftLightmapsStorage()
	{
	}
}
[Token(Token = "0x200000E")]
public class ftLocalStorage : ScriptableObject
{
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1B15520", Offset = "0x1B15520", VA = "0x1B15520")]
	public ftLocalStorage()
	{
	}
}
[Token(Token = "0x200000F")]
public static class ftUniqueIDRegistry
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> Mapping;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> MappingInv;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1B155D0", Offset = "0x1B155D0", VA = "0x1B155D0")]
	public static void Deregister(int id)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1B15754", Offset = "0x1B15754", VA = "0x1B15754")]
	public static void Register(int id, int value)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1B156B0", Offset = "0x1B156B0", VA = "0x1B156B0")]
	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1B15858", Offset = "0x1B15858", VA = "0x1B15858")]
	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
