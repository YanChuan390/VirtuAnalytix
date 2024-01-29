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
	[Address(RVA = "0x2F0B8E8", Offset = "0x2F0B8E8", VA = "0x2F0B8E8")]
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
	public Texture2D cloudShadow;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float cloudShadowTilingX;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float cloudShadowTilingY;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float cloudShadowOffsetX;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float cloudShadowOffsetY;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2F0B8F0", Offset = "0x2F0B8F0", VA = "0x2F0B8F0")]
	public BakeryDirectLight()
	{
	}
}
[Token(Token = "0x2000004")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class BakeryLightMesh : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<MeshFilter> All;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutoff;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int samples2;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int bitmask;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool selfShadow;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool bakeToIndirect;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float indirectIntensity;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int lmid;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int lightsChanged;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2F0B954", Offset = "0x2F0B954", VA = "0x2F0B954")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2F0BA58", Offset = "0x2F0BA58", VA = "0x2F0BA58")]
	public BakeryLightMesh()
	{
	}
}
[Token(Token = "0x2000005")]
public struct BakeryLightmapGroupPlain
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string name;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int resolution;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int id;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderMode;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int renderDirMode;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int atlasPacker;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool vertexBake;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool containsTerrains;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool probes;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool isImplicit;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool computeSSS;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sssSamples;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssDensity;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssR;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssG;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float sssB;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fakeShadowBias;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool flipNormal;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string parentName;
}
[Token(Token = "0x2000006")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xD5F648", Offset = "0xD5F648")]
public class BakeryLightmapGroup : ScriptableObject
{
	[Token(Token = "0x2000007")]
	public enum ftLMGroupMode
	{
		[Token(Token = "0x400004D")]
		OriginalUV,
		[Token(Token = "0x400004E")]
		PackAtlas,
		[Token(Token = "0x400004F")]
		Vertex
	}

	[Token(Token = "0x2000008")]
	public enum RenderMode
	{
		[Token(Token = "0x4000051")]
		FullLighting = 0,
		[Token(Token = "0x4000052")]
		Indirect = 1,
		[Token(Token = "0x4000053")]
		Shadowmask = 2,
		[Token(Token = "0x4000054")]
		Subtractive = 3,
		[Token(Token = "0x4000055")]
		AmbientOcclusionOnly = 4,
		[Token(Token = "0x4000056")]
		Auto = 1000
	}

	[Token(Token = "0x2000009")]
	public enum RenderDirMode
	{
		[Token(Token = "0x4000058")]
		None = 0,
		[Token(Token = "0x4000059")]
		BakedNormalMaps = 1,
		[Token(Token = "0x400005A")]
		DominantDirection = 2,
		[Token(Token = "0x400005B")]
		RNM = 3,
		[Token(Token = "0x400005C")]
		SH = 4,
		[Token(Token = "0x400005D")]
		ProbeSH = 5,
		[Token(Token = "0x400005E")]
		Auto = 1000
	}

	[Token(Token = "0x200000A")]
	public enum AtlasPacker
	{
		[Token(Token = "0x4000060")]
		Default = 0,
		[Token(Token = "0x4000061")]
		xatlas = 1,
		[Token(Token = "0x4000062")]
		Auto = 1000
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0xD5F71C", Offset = "0xD5F71C")]
	public int resolution;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int bitmask;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int id;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sortingID;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isImplicit;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float area;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int totalVertexCount;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int vertexCounter;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int sceneLodLevel;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string sceneName;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public bool containsTerrains;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	public bool probes;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public ftLMGroupMode mode;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public RenderMode renderMode;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	public RenderDirMode renderDirMode;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public AtlasPacker atlasPacker;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public bool computeSSS;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int sssSamples;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float sssDensity;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Color sssColor;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float fakeShadowBias;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	[SerializeField]
	public bool flipNormal;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public string parentName;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public string overridePath;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2F0BB60", Offset = "0x2F0BB60", VA = "0x2F0BB60")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2F0BC50", Offset = "0x2F0BC50", VA = "0x2F0BC50")]
	public BakeryLightmapGroup()
	{
	}
}
[Token(Token = "0x200000B")]
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Object lmgroupAsset;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool instanceResolutionOverride;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int instanceResolution;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2F0BCE8", Offset = "0x2F0BCE8", VA = "0x2F0BCE8")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Token(Token = "0x200000C")]
[DisallowMultipleComponent]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2F0BCF8", Offset = "0x2F0BCF8", VA = "0x2F0BCF8")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Token(Token = "0x200000D")]
public class BakeryPackAsSingleSquare : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2F0BD00", Offset = "0x2F0BD00", VA = "0x2F0BD00")]
	public BakeryPackAsSingleSquare()
	{
	}
}
[Token(Token = "0x200000E")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryPointLight : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	public enum ftLightProjectionMode
	{
		[Token(Token = "0x400007D")]
		Omni,
		[Token(Token = "0x400007E")]
		Cookie,
		[Token(Token = "0x400007F")]
		Cubemap,
		[Token(Token = "0x4000080")]
		IES,
		[Token(Token = "0x4000081")]
		Cone
	}

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shadowSpread;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cutoff;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool realisticFalloff;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ftLightProjectionMode projMode;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D cookie;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angle;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float innerAngle;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Cubemap cubemap;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Object iesFile;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int bitmask;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool shadowmask;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float indirectIntensity;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float falloffMinRadius;

	[Token(Token = "0x4000078")]
	private const float GIZMO_MAXSIZE = 0.1f;

	[Token(Token = "0x4000079")]
	private const float GIZMO_SCALE = 0.01f;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float screenRadius;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2F0BD08", Offset = "0x2F0BD08", VA = "0x2F0BD08")]
	public BakeryPointLight()
	{
	}
}
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakerySkyLight : MonoBehaviour
{
	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string texName;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float intensity;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int samples;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hemispherical;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bitmask;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float indirectIntensity;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool tangentSH;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Cubemap cubemap;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2F0BD80", Offset = "0x2F0BD80", VA = "0x2F0BD80")]
	public BakerySkyLight()
	{
	}
}
[Token(Token = "0x2000011")]
public class ftGlobalStorage : ScriptableObject
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2F0BE10", Offset = "0x2F0BE10", VA = "0x2F0BE10")]
	public ftGlobalStorage()
	{
	}
}
[Token(Token = "0x2000012")]
public class ftLightmaps
{
	[Token(Token = "0x2000013")]
	private struct LightmapAdditionalData
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm1;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D rnm2;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mode;
	}

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int directionalMode;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2F0BE18", Offset = "0x2F0BE18", VA = "0x2F0BE18")]
	static ftLightmaps()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2F0BF00", Offset = "0x2F0BF00", VA = "0x2F0BF00")]
	private static void SetDirectionalMode()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2F0BFA0", Offset = "0x2F0BFA0", VA = "0x2F0BFA0")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2F0BFF8", Offset = "0x2F0BFF8", VA = "0x2F0BFF8")]
	public static void RefreshFull()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2F0DEC8", Offset = "0x2F0DEC8", VA = "0x2F0DEC8")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2F0E00C", Offset = "0x2F0E00C", VA = "0x2F0E00C")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2F0C1E8", Offset = "0x2F0C1E8", VA = "0x2F0C1E8")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2F0E024", Offset = "0x2F0E024", VA = "0x2F0E024")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2F0E2FC", Offset = "0x2F0E2FC", VA = "0x2F0E2FC")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2F0E544", Offset = "0x2F0E544", VA = "0x2F0E544")]
	public ftLightmaps()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteInEditMode]
public class ftLightmapsStorage : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> maps;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> masks;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Texture2D> dirMaps;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Texture2D> rnmMaps0;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Texture2D> rnmMaps1;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Texture2D> rnmMaps2;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> mapsMode;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Renderer> bakedRenderers;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> bakedIDs;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector4> bakedScaleOffset;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Mesh> bakedVertexColorMesh;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Renderer> nonBakedRenderers;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Light> bakedLights;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> bakedLightChannels;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Terrain> bakedRenderersTerrain;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> bakedIDsTerrain;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<string> assetList;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<int> uvOverlapAssetList;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] idremap;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool usesRealtimeGI;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D emptyDirectionTex;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2F0E54C", Offset = "0x2F0E54C", VA = "0x2F0E54C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2F0E5D8", Offset = "0x2F0E5D8", VA = "0x2F0E5D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2F0E654", Offset = "0x2F0E654", VA = "0x2F0E654")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2F0E6B4", Offset = "0x2F0E6B4", VA = "0x2F0E6B4")]
	public ftLightmapsStorage()
	{
	}
}
[Token(Token = "0x2000015")]
public class ftLocalStorage : ScriptableObject
{
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2F0EAF0", Offset = "0x2F0EAF0", VA = "0x2F0EAF0")]
	public ftLocalStorage()
	{
	}
}
[Token(Token = "0x2000016")]
public static class ftUniqueIDRegistry
{
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> Mapping;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> MappingInv;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2F0EBC0", Offset = "0x2F0EBC0", VA = "0x2F0EBC0")]
	public static void Deregister(int id)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2F0ED54", Offset = "0x2F0ED54", VA = "0x2F0ED54")]
	public static void Register(int id, int value)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2F0ECA8", Offset = "0x2F0ECA8", VA = "0x2F0ECA8")]
	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2F0EE6C", Offset = "0x2F0EE6C", VA = "0x2F0EE6C")]
	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
