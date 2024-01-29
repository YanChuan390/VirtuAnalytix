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
	[Address(RVA = "0xD6A1B8", Offset = "0xD6A1B8", VA = "0xD6A1B8")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Color color;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float intensity;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float shadowSpread;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int samples;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int bitmask;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool shadowmask;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool shadowmaskDenoise;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float indirectIntensity;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Texture2D cloudShadow;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cloudShadowTilingX;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float cloudShadowTilingY;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float cloudShadowOffsetX;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float cloudShadowOffsetY;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int UID;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD6A1C0", Offset = "0xD6A1C0", VA = "0xD6A1C0")]
	public BakeryDirectLight()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryLightMesh : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int UID;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Texture2D texture;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float cutoff;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int samples;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int samples2;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int bitmask;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool selfShadow;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool bakeToIndirect;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float indirectIntensity;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int lmid;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD6A230", Offset = "0xD6A230", VA = "0xD6A230")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD6A38C", Offset = "0xD6A38C", VA = "0xD6A38C")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int resolution;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int renderMode;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int renderDirMode;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int atlasPacker;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool vertexBake;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool containsTerrains;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool probes;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isImplicit;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool computeSSS;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int sssSamples;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float sssDensity;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sssR;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sssG;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sssB;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fakeShadowBias;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool transparentSelfShadow;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool flipNormal;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public string parentName;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int sceneLodLevel;
}
[Token(Token = "0x2000006")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x6EBEF8", Offset = "0x6EBEF8")]
public class BakeryLightmapGroup : ScriptableObject
{
	[Token(Token = "0x2000014")]
	public enum ftLMGroupMode
	{
		[Token(Token = "0x40000B1")]
		OriginalUV,
		[Token(Token = "0x40000B2")]
		PackAtlas,
		[Token(Token = "0x40000B3")]
		Vertex
	}

	[Token(Token = "0x2000015")]
	public enum RenderMode
	{
		[Token(Token = "0x40000B5")]
		FullLighting = 0,
		[Token(Token = "0x40000B6")]
		Indirect = 1,
		[Token(Token = "0x40000B7")]
		Shadowmask = 2,
		[Token(Token = "0x40000B8")]
		Subtractive = 3,
		[Token(Token = "0x40000B9")]
		AmbientOcclusionOnly = 4,
		[Token(Token = "0x40000BA")]
		Auto = 1000
	}

	[Token(Token = "0x2000016")]
	public enum RenderDirMode
	{
		[Token(Token = "0x40000BC")]
		None = 0,
		[Token(Token = "0x40000BD")]
		BakedNormalMaps = 1,
		[Token(Token = "0x40000BE")]
		DominantDirection = 2,
		[Token(Token = "0x40000BF")]
		RNM = 3,
		[Token(Token = "0x40000C0")]
		SH = 4,
		[Token(Token = "0x40000C1")]
		ProbeSH = 5,
		[Token(Token = "0x40000C2")]
		Auto = 1000
	}

	[Token(Token = "0x2000017")]
	public enum AtlasPacker
	{
		[Token(Token = "0x40000C4")]
		Default = 0,
		[Token(Token = "0x40000C5")]
		xatlas = 1,
		[Token(Token = "0x40000C6")]
		Auto = 1000
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x6EBFC8", Offset = "0x6EBFC8")]
	public int resolution;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int bitmask;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int id;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int sortingID;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool isImplicit;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float area;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int totalVertexCount;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int vertexCounter;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int sceneLodLevel;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string sceneName;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool containsTerrains;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[SerializeField]
	public bool probes;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ftLMGroupMode mode;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public RenderMode renderMode;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public RenderDirMode renderDirMode;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	public AtlasPacker atlasPacker;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public bool computeSSS;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int sssSamples;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float sssDensity;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	public Color sssColor;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float sssScale;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public float fakeShadowBias;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public bool transparentSelfShadow;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	[SerializeField]
	public bool flipNormal;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	public string parentName;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	public string overridePath;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public bool fixPos3D;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public Vector3 voxelSize;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int passedFilter;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD6A40C", Offset = "0xD6A40C", VA = "0xD6A40C")]
	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD6A538", Offset = "0xD6A538", VA = "0xD6A538")]
	public BakeryLightmapGroup()
	{
	}
}
[Token(Token = "0x2000007")]
public class BakeryLightmapGroupSelector : MonoBehaviour
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Object lmgroupAsset;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool instanceResolutionOverride;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int instanceResolution;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD6A678", Offset = "0xD6A678", VA = "0xD6A678")]
	public BakeryLightmapGroupSelector()
	{
	}
}
[Token(Token = "0x2000008")]
[DisallowMultipleComponent]
public class BakeryLightmappedPrefab : MonoBehaviour
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD6A688", Offset = "0xD6A688", VA = "0xD6A688")]
	public BakeryLightmappedPrefab()
	{
	}
}
[Token(Token = "0x2000009")]
public class BakeryPackAsSingleSquare : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD6A690", Offset = "0xD6A690", VA = "0xD6A690")]
	public BakeryPackAsSingleSquare()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryPointLight : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	public enum ftLightProjectionMode
	{
		[Token(Token = "0x40000C8")]
		Omni,
		[Token(Token = "0x40000C9")]
		Cookie,
		[Token(Token = "0x40000CA")]
		Cubemap,
		[Token(Token = "0x40000CB")]
		IES,
		[Token(Token = "0x40000CC")]
		Cone
	}

	[Token(Token = "0x2000019")]
	public enum Direction
	{
		[Token(Token = "0x40000CE")]
		NegativeY,
		[Token(Token = "0x40000CF")]
		PositiveZ
	}

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int UID;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float shadowSpread;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float cutoff;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool realisticFalloff;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int samples;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ftLightProjectionMode projMode;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D cookie;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float angle;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float innerAngle;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Cubemap cubemap;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Object iesFile;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int bitmask;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool shadowmask;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float indirectIntensity;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float falloffMinRadius;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int shadowmaskGroupID;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Direction directionMode;

	[Token(Token = "0x4000067")]
	private const float GIZMO_MAXSIZE = 0.1f;

	[Token(Token = "0x4000068")]
	private const float GIZMO_SCALE = 0.01f;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float screenRadius;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD6A698", Offset = "0xD6A698", VA = "0xD6A698")]
	public BakeryPointLight()
	{
	}
}
[Token(Token = "0x200000B")]
public class BakerySector : MonoBehaviour
{
	[Token(Token = "0x200001A")]
	public enum CaptureMode
	{
		[Token(Token = "0x40000D1")]
		None = -1,
		[Token(Token = "0x40000D2")]
		CaptureInPlace,
		[Token(Token = "0x40000D3")]
		CaptureToAsset,
		[Token(Token = "0x40000D4")]
		LoadCaptured
	}

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public CaptureMode captureMode;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string captureAssetName;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public BakerySectorCapture captureAsset;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool allowUVPaddingAdjustment;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public List<Transform> tforms;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Transform> cpoints;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD6A72C", Offset = "0xD6A72C", VA = "0xD6A72C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD6A88C", Offset = "0xD6A88C", VA = "0xD6A88C")]
	public BakerySector()
	{
	}
}
[Token(Token = "0x200000C")]
public class BakerySectorCapture : ScriptableObject
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD6A958", Offset = "0xD6A958", VA = "0xD6A958")]
	public BakerySectorCapture()
	{
	}
}
[Token(Token = "0x200000D")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakerySkyLight : MonoBehaviour
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public string texName;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int samples;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hemispherical;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int bitmask;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool bakeToIndirect;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float indirectIntensity;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool tangentSH;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool correctRotation;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Cubemap cubemap;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int UID;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int lightsChanged;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD6A960", Offset = "0xD6A960", VA = "0xD6A960")]
	public BakerySkyLight()
	{
	}
}
[Token(Token = "0x200000E")]
[ExecuteInEditMode]
public class BakeryVolume : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	public enum Encoding
	{
		[Token(Token = "0x40000D6")]
		Half4,
		[Token(Token = "0x40000D7")]
		RGBA8,
		[Token(Token = "0x40000D8")]
		RGBA8Mono
	}

	[Token(Token = "0x200001C")]
	public enum ShadowmaskEncoding
	{
		[Token(Token = "0x40000DA")]
		RGBA8,
		[Token(Token = "0x40000DB")]
		A8
	}

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool enableBaking;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Bounds bounds;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool adaptiveRes;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float voxelsPerUnit;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int resolutionX;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int resolutionY;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int resolutionZ;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Encoding encoding;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ShadowmaskEncoding shadowmaskEncoding;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool denoise;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool isGlobal;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture3D bakedTexture0;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Texture3D bakedTexture1;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture3D bakedTexture2;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Texture3D bakedTexture3;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture3D bakedMask;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool supportRotationAfterBake;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BakeryVolume globalVolume;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform tform;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD6AA18", Offset = "0xD6AA18", VA = "0xD6AA18")]
	public Vector3 GetMin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD6AA30", Offset = "0xD6AA30", VA = "0xD6AA30")]
	public Vector3 GetInvSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD6AAE0", Offset = "0xD6AAE0", VA = "0xD6AAE0")]
	public Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD6ACE0", Offset = "0xD6ACE0", VA = "0xD6ACE0")]
	public void SetGlobalParams()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD6B020", Offset = "0xD6B020", VA = "0xD6B020")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD6B0DC", Offset = "0xD6B0DC", VA = "0xD6B0DC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD6B158", Offset = "0xD6B158", VA = "0xD6B158")]
	public BakeryVolume()
	{
	}
}
[Token(Token = "0x200000F")]
public class ftGlobalStorage : ScriptableObject
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD6B274", Offset = "0xD6B274", VA = "0xD6B274")]
	public ftGlobalStorage()
	{
	}
}
[Token(Token = "0x2000010")]
public class ftLightmaps
{
	[Token(Token = "0x200001D")]
	private struct LightmapAdditionalData
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D rnm0;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Texture2D rnm1;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D rnm2;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mode;
	}

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<int> lightmapRefCount;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static List<LightmapAdditionalData> globalMapsAdditional;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int directionalMode;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD6B27C", Offset = "0xD6B27C", VA = "0xD6B27C")]
	static ftLightmaps()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD6B35C", Offset = "0xD6B35C", VA = "0xD6B35C")]
	private static void SetDirectionalMode()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD6B41C", Offset = "0xD6B41C", VA = "0xD6B41C")]
	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD6B48C", Offset = "0xD6B48C", VA = "0xD6B48C")]
	public static void RefreshFull()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD6DE40", Offset = "0xD6DE40", VA = "0xD6DE40")]
	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD6DFD0", Offset = "0xD6DFD0", VA = "0xD6DFD0")]
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD6B6AC", Offset = "0xD6B6AC", VA = "0xD6B6AC")]
	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD6DFF0", Offset = "0xD6DFF0", VA = "0xD6DFF0")]
	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD6E388", Offset = "0xD6E388", VA = "0xD6E388")]
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD6E68C", Offset = "0xD6E68C", VA = "0xD6E68C")]
	public ftLightmaps()
	{
	}
}
[Token(Token = "0x2000011")]
[ExecuteInEditMode]
public class ftLightmapsStorage : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public List<Texture2D> maps;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Texture2D> masks;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public List<Texture2D> dirMaps;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Texture2D> rnmMaps0;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public List<Texture2D> rnmMaps1;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> rnmMaps2;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public List<int> mapsMode;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Renderer> bakedRenderers;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public List<int> bakedIDs;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector4> bakedScaleOffset;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public List<Mesh> bakedVertexColorMesh;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Renderer> nonBakedRenderers;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public List<Light> bakedLights;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<int> bakedLightChannels;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public List<Terrain> bakedRenderersTerrain;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> bakedIDsTerrain;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public List<Vector4> bakedScaleOffsetTerrain;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<string> assetList;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public List<int> uvOverlapAssetList;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int[] idremap;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool usesRealtimeGI;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D emptyDirectionTex;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool anyVolumes;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool compressedVolumes;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD6E694", Offset = "0xD6E694", VA = "0xD6E694")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD6E740", Offset = "0xD6E740", VA = "0xD6E740")]
	private void Start()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD6E7E0", Offset = "0xD6E7E0", VA = "0xD6E7E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD6E858", Offset = "0xD6E858", VA = "0xD6E858")]
	public ftLightmapsStorage()
	{
	}
}
[Token(Token = "0x2000012")]
public class ftLocalStorage : ScriptableObject
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<int> modifiedAssetPaddingHash;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD6EC38", Offset = "0xD6EC38", VA = "0xD6EC38")]
	public ftLocalStorage()
	{
	}
}
[Token(Token = "0x2000013")]
public static class ftUniqueIDRegistry
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> Mapping;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static Dictionary<int, int> MappingInv;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD6ED08", Offset = "0xD6ED08", VA = "0xD6ED08")]
	public static void Deregister(int id)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xD6EED0", Offset = "0xD6EED0", VA = "0xD6EED0")]
	public static void Register(int id, int value)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD6EE08", Offset = "0xD6EE08", VA = "0xD6EE08")]
	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD6F008", Offset = "0xD6F008", VA = "0xD6F008")]
	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
