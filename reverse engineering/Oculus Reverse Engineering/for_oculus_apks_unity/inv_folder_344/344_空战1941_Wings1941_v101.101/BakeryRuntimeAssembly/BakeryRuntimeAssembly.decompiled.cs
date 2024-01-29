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
	[Address(RVA = "0x238B4AC", Offset = "0x238B4AC", VA = "0x238B4AC")]
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
	[Address(RVA = "0x238B4B4", Offset = "0x238B4B4", VA = "0x238B4B4")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutoff;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int samples2;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int bitmask;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool selfShadow;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool bakeToIndirect;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float indirectIntensity;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int lmid;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x238B514", Offset = "0x238B514", VA = "0x238B514")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x238B610", Offset = "0x238B610", VA = "0x238B610")]
	public BakeryLightMesh()
	{
	}
}
[Token(Token = "0x2000005")]
public struct BakeryLightmapGroupPlain
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string name;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int resolution;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int id;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderMode;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int renderDirMode;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int atlasPacker;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool vertexBake;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool containsTerrains;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool probes;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool isImplicit;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool computeSSS;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sssSamples;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssDensity;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssR;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssG;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float sssB;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fakeShadowBias;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool flipNormal;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string parentName;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int sceneLodLevel;
}
[Token(Token = "0x2000006")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xE1A5B4", Offset = "0xE1A5B4")]
public class BakeryLightmapGroup : ScriptableObject
{
	[Token(Token = "0x2000007")]
	public enum ftLMGroupMode
	{
		[Token(Token = "0x400004F")]
		OriginalUV,
		[Token(Token = "0x4000050")]
		PackAtlas,
		[Token(Token = "0x4000051")]
		Vertex
	}

	[Token(Token = "0x2000008")]
	public enum RenderMode
	{
		[Token(Token = "0x4000053")]
		FullLighting = 0,
		[Token(Token = "0x4000054")]
		Indirect = 1,
		[Token(Token = "0x4000055")]
		Shadowmask = 2,
		[Token(Token = "0x4000056")]
		Subtractive = 3,
		[Token(Token = "0x4000057")]
		AmbientOcclusionOnly = 4,
		[Token(Token = "0x4000058")]
		Auto = 1000
	}

	[Token(Token = "0x2000009")]
	public enum RenderDirMode
	{
		[Token(Token = "0x400005A")]
		None = 0,
		[Token(Token = "0x400005B")]
		BakedNormalMaps = 1,
		[Token(Token = "0x400005C")]
		DominantDirection = 2,
		[Token(Token = "0x400005D")]
		RNM = 3,
		[Token(Token = "0x400005E")]
		SH = 4,
		[Token(Token = "0x400005F")]
		ProbeSH = 5,
		[Token(Token = "0x4000060")]
		Auto = 1000
	}

	[Token(Token = "0x200000A")]
	public enum AtlasPacker
	{
		[Token(Token = "0x4000062")]
		Default = 0,
		[Token(Token = "0x4000063")]
		xatlas = 1,
		[Token(Token = "0x4000064")]
		Auto = 1000
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0xE1A698", Offset = "0xE1A698")]
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

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public bool fixPos3D;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	public Vector3 voxelSize;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x238B67C", Offset = "0x238B67C", VA = "0x238B67C")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x238B77C", Offset = "0x238B77C", VA = "0x238B77C")]
	public BakeryLightmapGroup()
	{
	}
}
[Token(Token = "0x200000B")]
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Object lmgroupAsset;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool instanceResolutionOverride;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int instanceResolution;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x238B848", Offset = "0x238B848", VA = "0x238B848")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Token(Token = "0x200000C")]
[DisallowMultipleComponent]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x238B858", Offset = "0x238B858", VA = "0x238B858")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Token(Token = "0x200000D")]
public class BakeryPackAsSingleSquare : MonoBehaviour
{
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x238B860", Offset = "0x238B860", VA = "0x238B860")]
	public BakeryPackAsSingleSquare()
	{
	}
}
[Token(Token = "0x200000E")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class BakeryPointLight : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	public enum ftLightProjectionMode
	{
		[Token(Token = "0x4000080")]
		Omni,
		[Token(Token = "0x4000081")]
		Cookie,
		[Token(Token = "0x4000082")]
		Cubemap,
		[Token(Token = "0x4000083")]
		IES,
		[Token(Token = "0x4000084")]
		Cone
	}

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shadowSpread;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cutoff;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool realisticFalloff;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ftLightProjectionMode projMode;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D cookie;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angle;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float innerAngle;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Cubemap cubemap;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Object iesFile;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int bitmask;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool shadowmask;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float indirectIntensity;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float falloffMinRadius;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int shadowmaskGroupID;

	[Token(Token = "0x400007B")]
	private const float GIZMO_MAXSIZE = 0.1f;

	[Token(Token = "0x400007C")]
	private const float GIZMO_SCALE = 0.01f;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float screenRadius;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x238B868", Offset = "0x238B868", VA = "0x238B868")]
	public BakeryPointLight()
	{
	}
}
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakerySkyLight : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string texName;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float intensity;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int samples;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hemispherical;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bitmask;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool bakeToIndirect;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float indirectIntensity;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool tangentSH;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool correctRotation;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Cubemap cubemap;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x238B8DC", Offset = "0x238B8DC", VA = "0x238B8DC")]
	public BakerySkyLight()
	{
	}
}
[Token(Token = "0x2000011")]
[ExecuteInEditMode]
public class BakeryVolume : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	public enum Encoding
	{
		[Token(Token = "0x40000A3")]
		Half4,
		[Token(Token = "0x40000A4")]
		RGBA8,
		[Token(Token = "0x40000A5")]
		RGBA8Mono
	}

	[Token(Token = "0x2000013")]
	public enum ShadowmaskEncoding
	{
		[Token(Token = "0x40000A7")]
		RGBA8,
		[Token(Token = "0x40000A8")]
		A8
	}

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableBaking;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bounds;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool adaptiveRes;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float voxelsPerUnit;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int resolutionX;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int resolutionY;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int resolutionZ;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Encoding encoding;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public ShadowmaskEncoding shadowmaskEncoding;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool denoise;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool isGlobal;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture3D bakedTexture0;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture3D bakedTexture1;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture3D bakedTexture2;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture3D bakedMask;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BakeryVolume globalVolume;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x238B96C", Offset = "0x238B96C", VA = "0x238B96C")]
	public Vector3 GetMin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x238B978", Offset = "0x238B978", VA = "0x238B978")]
	public Vector3 GetInvSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x238BA00", Offset = "0x238BA00", VA = "0x238BA00")]
	public void SetGlobalParams()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x238BBAC", Offset = "0x238BBAC", VA = "0x238BBAC")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x238BC4C", Offset = "0x238BC4C", VA = "0x238BC4C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x238BCC0", Offset = "0x238BCC0", VA = "0x238BCC0")]
	public BakeryVolume()
	{
	}
}
[Token(Token = "0x2000014")]
public class BakeryVolumeReceiver : MonoBehaviour
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool forceUsage;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	internal int enterCounter;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal BakeryVolumeTrigger movableTrigger;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer[] renderers;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock current;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x238BDC0", Offset = "0x238BDC0", VA = "0x238BDC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x238BE5C", Offset = "0x238BE5C", VA = "0x238BE5C")]
	public void SetPropertyBlock(MaterialPropertyBlock mb)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x238BEE4", Offset = "0x238BEE4", VA = "0x238BEE4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x238C09C", Offset = "0x238C09C", VA = "0x238C09C")]
	public BakeryVolumeReceiver()
	{
	}
}
[Token(Token = "0x2000015")]
public class BakeryVolumeTrigger : MonoBehaviour
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool movable;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private BakeryVolume vol;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MaterialPropertyBlock mb;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock mbEmpty;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int mVolumeMin;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int mVolumeInvSize;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x238C0A4", Offset = "0x238C0A4", VA = "0x238C0A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x238C3C4", Offset = "0x238C3C4", VA = "0x238C3C4")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x238C514", Offset = "0x238C514", VA = "0x238C514")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x238BF80", Offset = "0x238BF80", VA = "0x238BF80")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x238C660", Offset = "0x238C660", VA = "0x238C660")]
	public BakeryVolumeTrigger()
	{
	}
}
[Token(Token = "0x2000016")]
public class VolumeTestScene2 : MonoBehaviour
{
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform secondFloor;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BakeryVolumeTrigger[] secondFloorVolumes;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float secondFloorHeight;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool randomizeLastRoom;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform baseRoom;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform alternativeRoom;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x238C668", Offset = "0x238C668", VA = "0x238C668")]
	private void SwapRooms()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x238C6F0", Offset = "0x238C6F0", VA = "0x238C6F0")]
	private void UpdateRooms()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x238C758", Offset = "0x238C758", VA = "0x238C758")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x238C858", Offset = "0x238C858", VA = "0x238C858")]
	private void Update()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x238C89C", Offset = "0x238C89C", VA = "0x238C89C")]
	public VolumeTestScene2()
	{
	}
}
[Token(Token = "0x2000017")]
public class ftGlobalStorage : ScriptableObject
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x238C8A4", Offset = "0x238C8A4", VA = "0x238C8A4")]
	public ftGlobalStorage()
	{
	}
}
[Token(Token = "0x2000018")]
public class ftLightmaps
{
	[Token(Token = "0x2000019")]
	private struct LightmapAdditionalData
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm1;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D rnm2;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mode;
	}

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int directionalMode;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x238C8AC", Offset = "0x238C8AC", VA = "0x238C8AC")]
	static ftLightmaps()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x238C974", Offset = "0x238C974", VA = "0x238C974")]
	private static void SetDirectionalMode()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x238CA18", Offset = "0x238CA18", VA = "0x238CA18")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x238CA74", Offset = "0x238CA74", VA = "0x238CA74")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x238CBBC", Offset = "0x238CBBC", VA = "0x238CBBC")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x238CBD4", Offset = "0x238CBD4", VA = "0x238CBD4")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x238E868", Offset = "0x238E868", VA = "0x238E868")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x238EB08", Offset = "0x238EB08", VA = "0x238EB08")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}
}
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
public class ftLightmapsStorage : MonoBehaviour
{
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> maps;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> masks;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Texture2D> dirMaps;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Texture2D> rnmMaps0;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Texture2D> rnmMaps1;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Texture2D> rnmMaps2;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> mapsMode;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Renderer> bakedRenderers;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> bakedIDs;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector4> bakedScaleOffset;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Mesh> bakedVertexColorMesh;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Renderer> nonBakedRenderers;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Light> bakedLights;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> bakedLightChannels;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Terrain> bakedRenderersTerrain;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> bakedIDsTerrain;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<string> assetList;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<int> uvOverlapAssetList;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] idremap;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool usesRealtimeGI;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D emptyDirectionTex;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x238ED18", Offset = "0x238ED18", VA = "0x238ED18")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x238EDA8", Offset = "0x238EDA8", VA = "0x238EDA8")]
	private void Start()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x238EE28", Offset = "0x238EE28", VA = "0x238EE28")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x238EE8C", Offset = "0x238EE8C", VA = "0x238EE8C")]
	public ftLightmapsStorage()
	{
	}
}
[Token(Token = "0x200001B")]
public class ftLocalStorage : ScriptableObject
{
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x238F218", Offset = "0x238F218", VA = "0x238F218")]
	public ftLocalStorage()
	{
	}
}
