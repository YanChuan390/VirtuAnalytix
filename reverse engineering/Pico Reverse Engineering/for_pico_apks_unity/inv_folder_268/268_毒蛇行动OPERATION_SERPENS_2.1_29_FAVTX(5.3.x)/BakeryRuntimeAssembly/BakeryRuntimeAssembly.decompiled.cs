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
	[Address(RVA = "0x17C3BE4", Offset = "0x17C3BE4", VA = "0x17C3BE4")]
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
	[Address(RVA = "0x17C3BEC", Offset = "0x17C3BEC", VA = "0x17C3BEC")]
	public BakeryDirectLight()
	{
	}
}
[Token(Token = "0x2000004")]
public struct BakeryLightmapGroupPlain
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string name;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int resolution;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int id;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderMode;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int renderDirMode;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int atlasPacker;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool vertexBake;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool containsTerrains;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool probes;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool isImplicit;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool computeSSS;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sssSamples;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssDensity;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssR;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssG;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float sssB;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fakeShadowBias;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool flipNormal;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string parentName;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int sceneLodLevel;
}
[Token(Token = "0x2000005")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x6F5D98", Offset = "0x6F5D98")]
public class BakeryLightmapGroup : ScriptableObject
{
	[Token(Token = "0x2000006")]
	public enum ftLMGroupMode
	{
		[Token(Token = "0x4000044")]
		OriginalUV,
		[Token(Token = "0x4000045")]
		PackAtlas,
		[Token(Token = "0x4000046")]
		Vertex
	}

	[Token(Token = "0x2000007")]
	public enum RenderMode
	{
		[Token(Token = "0x4000048")]
		FullLighting = 0,
		[Token(Token = "0x4000049")]
		Indirect = 1,
		[Token(Token = "0x400004A")]
		Shadowmask = 2,
		[Token(Token = "0x400004B")]
		Subtractive = 3,
		[Token(Token = "0x400004C")]
		AmbientOcclusionOnly = 4,
		[Token(Token = "0x400004D")]
		Auto = 1000
	}

	[Token(Token = "0x2000008")]
	public enum RenderDirMode
	{
		[Token(Token = "0x400004F")]
		None = 0,
		[Token(Token = "0x4000050")]
		BakedNormalMaps = 1,
		[Token(Token = "0x4000051")]
		DominantDirection = 2,
		[Token(Token = "0x4000052")]
		RNM = 3,
		[Token(Token = "0x4000053")]
		SH = 4,
		[Token(Token = "0x4000054")]
		ProbeSH = 5,
		[Token(Token = "0x4000055")]
		Auto = 1000
	}

	[Token(Token = "0x2000009")]
	public enum AtlasPacker
	{
		[Token(Token = "0x4000057")]
		Default = 0,
		[Token(Token = "0x4000058")]
		xatlas = 1,
		[Token(Token = "0x4000059")]
		Auto = 1000
	}

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6F5EB4", Offset = "0x6F5EB4")]
	[SerializeField]
	public int resolution;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int bitmask;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int id;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sortingID;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isImplicit;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float area;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int totalVertexCount;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int vertexCounter;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int sceneLodLevel;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string sceneName;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public bool containsTerrains;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	public bool probes;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public ftLMGroupMode mode;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public RenderMode renderMode;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	public RenderDirMode renderDirMode;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public AtlasPacker atlasPacker;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public bool computeSSS;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int sssSamples;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float sssDensity;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Color sssColor;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float sssScale;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float fakeShadowBias;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public bool transparentSelfShadow;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	[SerializeField]
	public bool flipNormal;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public string parentName;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public string overridePath;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	public bool fixPos3D;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public Vector3 voxelSize;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int passedFilter;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x17C3DC4", Offset = "0x17C3DC4", VA = "0x17C3DC4")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x17C3ED8", Offset = "0x17C3ED8", VA = "0x17C3ED8")]
	public BakeryLightmapGroup()
	{
	}
}
[Token(Token = "0x200000A")]
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Object lmgroupAsset;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool instanceResolutionOverride;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int instanceResolution;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x17C3F90", Offset = "0x17C3F90", VA = "0x17C3F90")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Token(Token = "0x200000B")]
[DisallowMultipleComponent]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x17C3FA0", Offset = "0x17C3FA0", VA = "0x17C3FA0")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryLightMesh : MonoBehaviour
{
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutoff;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int samples2;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int bitmask;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool selfShadow;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float indirectIntensity;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int lmid;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x17C3C50", Offset = "0x17C3C50", VA = "0x17C3C50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x17C3D54", Offset = "0x17C3D54", VA = "0x17C3D54")]
	public BakeryLightMesh()
	{
	}
}
[Token(Token = "0x200000D")]
public class BakeryPackAsSingleSquare : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x17C3FA8", Offset = "0x17C3FA8", VA = "0x17C3FA8")]
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
		[Token(Token = "0x4000083")]
		Omni,
		[Token(Token = "0x4000084")]
		Cookie,
		[Token(Token = "0x4000085")]
		Cubemap,
		[Token(Token = "0x4000086")]
		IES,
		[Token(Token = "0x4000087")]
		Cone
	}

	[Token(Token = "0x2000010")]
	public enum Direction
	{
		[Token(Token = "0x4000089")]
		NegativeY,
		[Token(Token = "0x400008A")]
		PositiveZ
	}

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shadowSpread;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cutoff;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool realisticFalloff;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ftLightProjectionMode projMode;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D cookie;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angle;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float innerAngle;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Cubemap cubemap;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Object iesFile;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int bitmask;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool shadowmask;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float indirectIntensity;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float falloffMinRadius;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int shadowmaskGroupID;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Direction directionMode;

	[Token(Token = "0x400007E")]
	private const float GIZMO_MAXSIZE = 0.1f;

	[Token(Token = "0x400007F")]
	private const float GIZMO_SCALE = 0.01f;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float screenRadius;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x17C3FB0", Offset = "0x17C3FB0", VA = "0x17C3FB0")]
	public BakeryPointLight()
	{
	}
}
[Token(Token = "0x2000011")]
public class BakerySector : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	public enum CaptureMode
	{
		[Token(Token = "0x4000092")]
		None = -1,
		[Token(Token = "0x4000093")]
		CaptureInPlace,
		[Token(Token = "0x4000094")]
		CaptureToAsset,
		[Token(Token = "0x4000095")]
		LoadCaptured
	}

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CaptureMode captureMode;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string captureAssetName;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BakerySectorCapture captureAsset;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool allowUVPaddingAdjustment;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Transform> tforms;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Transform> cpoints;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x17C4028", Offset = "0x17C4028", VA = "0x17C4028")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17C4160", Offset = "0x17C4160", VA = "0x17C4160")]
	public BakerySector()
	{
	}
}
[Token(Token = "0x2000013")]
public class BakerySectorCapture : ScriptableObject
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x17C423C", Offset = "0x17C423C", VA = "0x17C423C")]
	public BakerySectorCapture()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakerySkyLight : MonoBehaviour
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string texName;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float intensity;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int samples;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hemispherical;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bitmask;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool bakeToIndirect;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float indirectIntensity;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool tangentSH;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool correctRotation;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Cubemap cubemap;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x17C4244", Offset = "0x17C4244", VA = "0x17C4244")]
	public BakerySkyLight()
	{
	}
}
[Token(Token = "0x2000015")]
[ExecuteInEditMode]
public class BakeryVolume : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	public enum Encoding
	{
		[Token(Token = "0x40000B7")]
		Half4,
		[Token(Token = "0x40000B8")]
		RGBA8,
		[Token(Token = "0x40000B9")]
		RGBA8Mono
	}

	[Token(Token = "0x2000017")]
	public enum ShadowmaskEncoding
	{
		[Token(Token = "0x40000BB")]
		RGBA8,
		[Token(Token = "0x40000BC")]
		A8
	}

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableBaking;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bounds;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool adaptiveRes;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float voxelsPerUnit;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int resolutionX;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int resolutionY;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int resolutionZ;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Encoding encoding;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public ShadowmaskEncoding shadowmaskEncoding;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool denoise;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool isGlobal;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture3D bakedTexture0;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture3D bakedTexture1;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture3D bakedTexture2;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture3D bakedTexture3;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture3D bakedMask;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool supportRotationAfterBake;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BakeryVolume globalVolume;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform tform;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x17C42DC", Offset = "0x17C42DC", VA = "0x17C42DC")]
	public Vector3 GetMin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x17C42E8", Offset = "0x17C42E8", VA = "0x17C42E8")]
	public Vector3 GetInvSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x17C4354", Offset = "0x17C4354", VA = "0x17C4354")]
	public Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x17C44E0", Offset = "0x17C44E0", VA = "0x17C44E0")]
	public void SetGlobalParams()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x17C4744", Offset = "0x17C4744", VA = "0x17C4744")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x17C47E4", Offset = "0x17C47E4", VA = "0x17C47E4")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x17C4854", Offset = "0x17C4854", VA = "0x17C4854")]
	public BakeryVolume()
	{
	}
}
[Token(Token = "0x2000018")]
public class BakeryVolumeReceiver : MonoBehaviour
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool forceUsage;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	internal int enterCounter;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal BakeryVolumeTrigger movableTrigger;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer[] renderers;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock current;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x17C4910", Offset = "0x17C4910", VA = "0x17C4910")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x17C49C0", Offset = "0x17C49C0", VA = "0x17C49C0")]
	public void SetPropertyBlock(MaterialPropertyBlock mb)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x17C4A98", Offset = "0x17C4A98", VA = "0x17C4A98")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x17C4C0C", Offset = "0x17C4C0C", VA = "0x17C4C0C")]
	public BakeryVolumeReceiver()
	{
	}
}
[Token(Token = "0x2000019")]
public class BakeryVolumeTrigger : MonoBehaviour
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool movable;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private BakeryVolume vol;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MaterialPropertyBlock mb;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock mbEmpty;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int mVolumeMin;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int mVolumeInvSize;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x17C4C14", Offset = "0x17C4C14", VA = "0x17C4C14")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x17C501C", Offset = "0x17C501C", VA = "0x17C501C")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x17C5198", Offset = "0x17C5198", VA = "0x17C5198")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x17C4B3C", Offset = "0x17C4B3C", VA = "0x17C4B3C")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x17C531C", Offset = "0x17C531C", VA = "0x17C531C")]
	public BakeryVolumeTrigger()
	{
	}
}
[Token(Token = "0x200001A")]
public class VolumeTestScene2 : MonoBehaviour
{
	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform secondFloor;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BakeryVolumeTrigger[] secondFloorVolumes;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float secondFloorHeight;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool randomizeLastRoom;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform baseRoom;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform alternativeRoom;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x17C5324", Offset = "0x17C5324", VA = "0x17C5324")]
	private void SwapRooms()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x17C53AC", Offset = "0x17C53AC", VA = "0x17C53AC")]
	private void UpdateRooms()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x17C5414", Offset = "0x17C5414", VA = "0x17C5414")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x17C54C0", Offset = "0x17C54C0", VA = "0x17C54C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x17C5504", Offset = "0x17C5504", VA = "0x17C5504")]
	public VolumeTestScene2()
	{
	}
}
[Token(Token = "0x200001B")]
public class ftGlobalStorage : ScriptableObject
{
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x17C550C", Offset = "0x17C550C", VA = "0x17C550C")]
	public ftGlobalStorage()
	{
	}
}
[Token(Token = "0x200001C")]
public class ftLightmaps
{
	[Token(Token = "0x200001D")]
	private struct LightmapAdditionalData
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm1;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D rnm2;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mode;
	}

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int directionalMode;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x17C5514", Offset = "0x17C5514", VA = "0x17C5514")]
	static ftLightmaps()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x17C5604", Offset = "0x17C5604", VA = "0x17C5604")]
	private static void SetDirectionalMode()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x17C56A4", Offset = "0x17C56A4", VA = "0x17C56A4")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x17C56FC", Offset = "0x17C56FC", VA = "0x17C56FC")]
	public static void RefreshFull()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x17C7758", Offset = "0x17C7758", VA = "0x17C7758")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x17C789C", Offset = "0x17C789C", VA = "0x17C789C")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x17C58EC", Offset = "0x17C58EC", VA = "0x17C58EC")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x17C78B8", Offset = "0x17C78B8", VA = "0x17C78B8")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x17C7B90", Offset = "0x17C7B90", VA = "0x17C7B90")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x17C7E2C", Offset = "0x17C7E2C", VA = "0x17C7E2C")]
	public ftLightmaps()
	{
	}
}
[Token(Token = "0x200001E")]
[ExecuteInEditMode]
public class ftLightmapsStorage : MonoBehaviour
{
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> maps;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> masks;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Texture2D> dirMaps;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Texture2D> rnmMaps0;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Texture2D> rnmMaps1;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Texture2D> rnmMaps2;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> mapsMode;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Renderer> bakedRenderers;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> bakedIDs;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector4> bakedScaleOffset;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Mesh> bakedVertexColorMesh;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Renderer> nonBakedRenderers;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Light> bakedLights;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> bakedLightChannels;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Terrain> bakedRenderersTerrain;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> bakedIDsTerrain;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<string> assetList;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<int> uvOverlapAssetList;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] idremap;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool usesRealtimeGI;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D emptyDirectionTex;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool anyVolumes;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool compressedVolumes;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x17C7E34", Offset = "0x17C7E34", VA = "0x17C7E34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x17C7EC0", Offset = "0x17C7EC0", VA = "0x17C7EC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x17C7F3C", Offset = "0x17C7F3C", VA = "0x17C7F3C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x17C7FA4", Offset = "0x17C7FA4", VA = "0x17C7FA4")]
	public ftLightmapsStorage()
	{
	}
}
[Token(Token = "0x200001F")]
public class ftLocalStorage : ScriptableObject
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x17C83E8", Offset = "0x17C83E8", VA = "0x17C83E8")]
	public ftLocalStorage()
	{
	}
}
[Token(Token = "0x2000020")]
public static class ftUniqueIDRegistry
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> Mapping;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> MappingInv;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x17C84C8", Offset = "0x17C84C8", VA = "0x17C84C8")]
	public static void Deregister(int id)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x17C865C", Offset = "0x17C865C", VA = "0x17C865C")]
	public static void Register(int id, int value)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x17C85B0", Offset = "0x17C85B0", VA = "0x17C85B0")]
	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x17C8774", Offset = "0x17C8774", VA = "0x17C8774")]
	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
