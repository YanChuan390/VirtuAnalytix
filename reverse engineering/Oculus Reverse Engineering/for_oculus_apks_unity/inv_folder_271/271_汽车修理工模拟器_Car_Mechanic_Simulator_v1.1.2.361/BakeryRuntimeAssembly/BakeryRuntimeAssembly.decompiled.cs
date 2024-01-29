using System;
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
	[Address(RVA = "0x13710A8", Offset = "0x13710A8", VA = "0x13710A8")]
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
	public bool supersample;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int UID;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject objShownError;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13710B0", Offset = "0x13710B0", VA = "0x13710B0")]
	public BakeryDirectLight()
	{
	}
}
[Token(Token = "0x2000004")]
public struct BakeryLightmapGroupPlain
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string name;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int resolution;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int id;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderMode;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int renderDirMode;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int atlasPacker;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool vertexBake;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool containsTerrains;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool probes;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool isImplicit;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool computeSSS;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sssSamples;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssDensity;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssR;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssG;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float sssB;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fakeShadowBias;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool flipNormal;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string parentName;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int sceneLodLevel;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool autoResolution;
}
[Token(Token = "0x2000005")]
[CreateAssetMenu(menuName = "Bakery lightmap group")]
public class BakeryLightmapGroup : ScriptableObject
{
	[Token(Token = "0x2000006")]
	public enum ftLMGroupMode
	{
		[Token(Token = "0x4000049")]
		OriginalUV,
		[Token(Token = "0x400004A")]
		PackAtlas,
		[Token(Token = "0x400004B")]
		Vertex
	}

	[Token(Token = "0x2000007")]
	public enum RenderMode
	{
		[Token(Token = "0x400004D")]
		FullLighting = 0,
		[Token(Token = "0x400004E")]
		Indirect = 1,
		[Token(Token = "0x400004F")]
		Shadowmask = 2,
		[Token(Token = "0x4000050")]
		Subtractive = 3,
		[Token(Token = "0x4000051")]
		AmbientOcclusionOnly = 4,
		[Token(Token = "0x4000052")]
		Auto = 1000
	}

	[Token(Token = "0x2000008")]
	public enum RenderDirMode
	{
		[Token(Token = "0x4000054")]
		None = 0,
		[Token(Token = "0x4000055")]
		BakedNormalMaps = 1,
		[Token(Token = "0x4000056")]
		DominantDirection = 2,
		[Token(Token = "0x4000057")]
		RNM = 3,
		[Token(Token = "0x4000058")]
		SH = 4,
		[Token(Token = "0x4000059")]
		ProbeSH = 5,
		[Token(Token = "0x400005A")]
		MonoSH = 6,
		[Token(Token = "0x400005B")]
		Auto = 1000
	}

	[Token(Token = "0x2000009")]
	public enum AtlasPacker
	{
		[Token(Token = "0x400005D")]
		Default = 0,
		[Token(Token = "0x400005E")]
		xatlas = 1,
		[Token(Token = "0x400005F")]
		Auto = 1000
	}

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(1f, 8192f)]
	[SerializeField]
	public int resolution;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int bitmask;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int id;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int sortingID;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool isImplicit;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float area;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int totalVertexCount;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int vertexCounter;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int sceneLodLevel;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public bool autoResolution;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string sceneName;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int tag;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public bool containsTerrains;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	[SerializeField]
	public bool probes;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public ftLMGroupMode mode;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	public RenderMode renderMode;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public RenderDirMode renderDirMode;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public AtlasPacker atlasPacker;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public bool computeSSS;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	public int sssSamples;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public float sssDensity;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public Color sssColor;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float sssScale;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public float fakeShadowBias;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	[SerializeField]
	public bool flipNormal;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public string parentName;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public string overridePath;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	public bool fixPos3D;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public Vector3 voxelSize;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int passedFilter;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x13710F4", Offset = "0x13710F4", VA = "0x13710F4")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1371208", Offset = "0x1371208", VA = "0x1371208")]
	public BakeryLightmapGroup()
	{
	}
}
[Token(Token = "0x200000A")]
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEngine.Object lmgroupAsset;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool instanceResolutionOverride;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int instanceResolution;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13712E0", Offset = "0x13712E0", VA = "0x13712E0")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Token(Token = "0x200000B")]
[DisallowMultipleComponent]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x13712F0", Offset = "0x13712F0", VA = "0x13712F0")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryLightMesh : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutoff;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int samples2;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int bitmask;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool selfShadow;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool bakeToIndirect;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool shadowmask;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float indirectIntensity;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool shadowmaskFalloff;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int lmid;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject objShownError;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13712F8", Offset = "0x13712F8", VA = "0x13712F8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1371400", Offset = "0x1371400", VA = "0x1371400")]
	public BakeryLightMesh()
	{
	}
}
[Token(Token = "0x200000D")]
public class BakeryPackAsSingleSquare : MonoBehaviour
{
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1371448", Offset = "0x1371448", VA = "0x1371448")]
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
		[Token(Token = "0x4000090")]
		Omni,
		[Token(Token = "0x4000091")]
		Cookie,
		[Token(Token = "0x4000092")]
		Cubemap,
		[Token(Token = "0x4000093")]
		IES,
		[Token(Token = "0x4000094")]
		Cone
	}

	[Token(Token = "0x2000010")]
	public enum Direction
	{
		[Token(Token = "0x4000096")]
		NegativeY,
		[Token(Token = "0x4000097")]
		PositiveZ
	}

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int UID;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float shadowSpread;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cutoff;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool realisticFalloff;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool legacySampling;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int samples;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ftLightProjectionMode projMode;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D cookie;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angle;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float innerAngle;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Cubemap cubemap;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UnityEngine.Object iesFile;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int bitmask;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool shadowmask;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
	public bool shadowmaskFalloff;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float indirectIntensity;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float falloffMinRadius;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int shadowmaskGroupID;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Direction directionMode;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int maskChannel;

	[Token(Token = "0x400008A")]
	private const float GIZMO_MAXSIZE = 0.1f;

	[Token(Token = "0x400008B")]
	private const float GIZMO_SCALE = 0.01f;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float screenRadius;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject objShownError;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1371450", Offset = "0x1371450", VA = "0x1371450")]
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
		[Token(Token = "0x400009F")]
		None = -1,
		[Token(Token = "0x40000A0")]
		CaptureInPlace,
		[Token(Token = "0x40000A1")]
		CaptureToAsset,
		[Token(Token = "0x40000A2")]
		LoadCaptured
	}

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CaptureMode captureMode;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string captureAssetName;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BakerySectorCapture captureAsset;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool allowUVPaddingAdjustment;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Transform> tforms;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Transform> cpoints;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x13714A8", Offset = "0x13714A8", VA = "0x13714A8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x13715C0", Offset = "0x13715C0", VA = "0x13715C0")]
	public BakerySector()
	{
	}
}
[Token(Token = "0x2000013")]
public class BakerySectorCapture : ScriptableObject
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x137169C", Offset = "0x137169C", VA = "0x137169C")]
	public BakerySectorCapture()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakerySkyLight : MonoBehaviour
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string texName;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float intensity;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int samples;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hemispherical;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bitmask;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool bakeToIndirect;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float indirectIntensity;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool tangentSH;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool correctRotation;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Cubemap cubemap;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int UID;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject objShownError;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x13716A4", Offset = "0x13716A4", VA = "0x13716A4")]
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
		[Token(Token = "0x40000C6")]
		Half4,
		[Token(Token = "0x40000C7")]
		RGBA8,
		[Token(Token = "0x40000C8")]
		RGBA8Mono
	}

	[Token(Token = "0x2000017")]
	public enum ShadowmaskEncoding
	{
		[Token(Token = "0x40000CA")]
		RGBA8,
		[Token(Token = "0x40000CB")]
		A8
	}

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableBaking;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bounds;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool adaptiveRes;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float voxelsPerUnit;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int resolutionX;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int resolutionY;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int resolutionZ;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Encoding encoding;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public ShadowmaskEncoding shadowmaskEncoding;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool firstLightIsAlwaysAlpha;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool denoise;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool isGlobal;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture3D bakedTexture0;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture3D bakedTexture1;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture3D bakedTexture2;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture3D bakedTexture3;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture3D bakedMask;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool supportRotationAfterBake;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BakeryVolume globalVolume;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform tform;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1371724", Offset = "0x1371724", VA = "0x1371724")]
	public Vector3 GetMin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1371730", Offset = "0x1371730", VA = "0x1371730")]
	public Vector3 GetInvSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1371798", Offset = "0x1371798", VA = "0x1371798")]
	public Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1371940", Offset = "0x1371940", VA = "0x1371940")]
	public void SetGlobalParams()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1371B90", Offset = "0x1371B90", VA = "0x1371B90")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1371C24", Offset = "0x1371C24", VA = "0x1371C24")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1371C98", Offset = "0x1371C98", VA = "0x1371C98")]
	public BakeryVolume()
	{
	}
}
[Token(Token = "0x2000018")]
public class ftGlobalStorage : ScriptableObject
{
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1371D8C", Offset = "0x1371D8C", VA = "0x1371D8C")]
	public ftGlobalStorage()
	{
	}
}
[Token(Token = "0x2000019")]
public class ftLightmaps
{
	[Token(Token = "0x200001A")]
	private struct LightmapAdditionalData
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm1;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D rnm2;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mode;
	}

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int directionalMode;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1371D94", Offset = "0x1371D94", VA = "0x1371D94")]
	static ftLightmaps()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1371E68", Offset = "0x1371E68", VA = "0x1371E68")]
	private static void SetDirectionalMode()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1371EF4", Offset = "0x1371EF4", VA = "0x1371EF4")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1371F40", Offset = "0x1371F40", VA = "0x1371F40")]
	public static void RefreshFull()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1373E18", Offset = "0x1373E18", VA = "0x1373E18")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1373F48", Offset = "0x1373F48", VA = "0x1373F48")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x13720C0", Offset = "0x13720C0", VA = "0x13720C0")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1373F60", Offset = "0x1373F60", VA = "0x1373F60")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1374204", Offset = "0x1374204", VA = "0x1374204")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x137446C", Offset = "0x137446C", VA = "0x137446C")]
	public ftLightmaps()
	{
	}
}
[Token(Token = "0x200001B")]
[ExecuteInEditMode]
public class ftLightmapsStorage : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> maps;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> masks;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Texture2D> dirMaps;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Texture2D> rnmMaps0;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Texture2D> rnmMaps1;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Texture2D> rnmMaps2;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> mapsMode;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Renderer> bakedRenderers;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> bakedIDs;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector4> bakedScaleOffset;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Mesh> bakedVertexColorMesh;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Renderer> nonBakedRenderers;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Light> bakedLights;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> bakedLightChannels;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Terrain> bakedRenderersTerrain;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> bakedIDsTerrain;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<string> assetList;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<int> uvOverlapAssetList;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int[] idremap;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool usesRealtimeGI;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Texture2D emptyDirectionTex;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool anyVolumes;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool compressedVolumes;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1374474", Offset = "0x1374474", VA = "0x1374474")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x13744F4", Offset = "0x13744F4", VA = "0x13744F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1374564", Offset = "0x1374564", VA = "0x1374564")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x13745B8", Offset = "0x13745B8", VA = "0x13745B8")]
	public ftLightmapsStorage()
	{
	}
}
[Token(Token = "0x200001C")]
public class ftLocalStorage : ScriptableObject
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1374A40", Offset = "0x1374A40", VA = "0x1374A40")]
	public ftLocalStorage()
	{
	}
}
[Token(Token = "0x200001D")]
public static class ftUniqueIDRegistry
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> Mapping;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> MappingInv;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1374B18", Offset = "0x1374B18", VA = "0x1374B18")]
	public static void Deregister(int id)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1374C8C", Offset = "0x1374C8C", VA = "0x1374C8C")]
	public static void Register(int id, int value)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1374BEC", Offset = "0x1374BEC", VA = "0x1374BEC")]
	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1374D90", Offset = "0x1374D90", VA = "0x1374D90")]
	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
[Token(Token = "0x200001E")]
public class SS_LightmapSwapper : MonoBehaviour
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool applyNewLightmapOnEnable;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space]
	public int lightmapIndex;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D newLightmap;

	[NonSerialized]
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D savedLightmap;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer ren;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LightmapData[] lightmaps;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SS_LightProbeStorage lpStorage;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1374EFC", Offset = "0x1374EFC", VA = "0x1374EFC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1374F00", Offset = "0x1374F00", VA = "0x1374F00")]
	public void GetLightmapIndex()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1375040", Offset = "0x1375040", VA = "0x1375040")]
	public void SaveLightmap()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1375098", Offset = "0x1375098", VA = "0x1375098")]
	public void SwapLightmap(Texture2D tex, int index)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1375110", Offset = "0x1375110", VA = "0x1375110")]
	public void RestoreLightmap(Texture2D tex, int index)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1375184", Offset = "0x1375184", VA = "0x1375184")]
	[ContextMenu("Swap Lightmap")]
	public void SwapLightmap()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1375560", Offset = "0x1375560", VA = "0x1375560")]
	[ContextMenu("Restore Lightmap")]
	public void RestoreLightmap()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13755E4", Offset = "0x13755E4", VA = "0x13755E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1375660", Offset = "0x1375660", VA = "0x1375660")]
	public SS_LightmapSwapper()
	{
	}
}
[Token(Token = "0x200001F")]
public class SS_LightProbeStorage : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public struct TCachedHarmonics
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float[] c1;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] c2;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] c3;
	}

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool applyHarmonicsOnEnable;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool applyHarmonicsOnStart;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 2f)]
	[Tooltip("Multiplier for spherical harmonics value")]
	public float harmonicsMul;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LightProbeGroup lightProbeComponent;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Vector3[] positions;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public TCachedHarmonics[] harmonics;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int harmonicsCount;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Header("Position Precision")]
	[Range(0f, 0.1f)]
	public float precision;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1375670", Offset = "0x1375670", VA = "0x1375670")]
	[ContextMenu("Grab Harmonics")]
	public void GrabHarmonics()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1375D34", Offset = "0x1375D34", VA = "0x1375D34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1375D44", Offset = "0x1375D44", VA = "0x1375D44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1375218", Offset = "0x1375218", VA = "0x1375218")]
	[ContextMenu("Apply Harmonics")]
	public void ApplyHarmonics()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1375C34", Offset = "0x1375C34", VA = "0x1375C34")]
	public int GetHarmonicsIdByPosition(ref Vector3[] pss, Vector3 pos, float precision)
	{
		return default(int);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1375D54", Offset = "0x1375D54", VA = "0x1375D54")]
	public SS_LightProbeStorage()
	{
	}
}
