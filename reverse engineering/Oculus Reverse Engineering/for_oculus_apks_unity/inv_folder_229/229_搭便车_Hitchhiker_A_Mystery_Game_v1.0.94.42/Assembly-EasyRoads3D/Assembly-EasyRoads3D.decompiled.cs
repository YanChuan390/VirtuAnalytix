using System.Reflection;
using EasyRoads3Dv3;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ERVegetationStudio : ScriptableObject
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x27398F0", Offset = "0x27398F0", VA = "0x27398F0")]
	public static bool VegetationStudio()
	{
		return default(bool);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x27398F8", Offset = "0x27398F8", VA = "0x27398F8")]
	public static bool VegetationStudioPro()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2739900", Offset = "0x2739900", VA = "0x2739900")]
	public static void CreateVegetationMaskLine(GameObject go, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2739904", Offset = "0x2739904", VA = "0x2739904")]
	public static void UpdateVegetationMaskLine(GameObject go, ERVSData[] vsData, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2739908", Offset = "0x2739908", VA = "0x2739908")]
	public static void UpdateHeightmap(Bounds bounds)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x273990C", Offset = "0x273990C", VA = "0x273990C")]
	public static void RemoveVegetationMaskLine(GameObject go)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2739910", Offset = "0x2739910", VA = "0x2739910")]
	public static void CreateBiomeArea(GameObject go, float distance, float blendDistance, float noise)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2739914", Offset = "0x2739914", VA = "0x2739914")]
	public static void UpdateBiomeArea(GameObject go, ERVSData[] vsData, float distance, float blendDistance, float noise)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2739918", Offset = "0x2739918", VA = "0x2739918")]
	public static void RemoveBiomeArea(GameObject go)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x273991C", Offset = "0x273991C", VA = "0x273991C")]
	public ERVegetationStudio()
	{
	}
}
[Token(Token = "0x2000003")]
public class runtimeScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public ERRoadNetwork roadNetwork;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public ERRoad road;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public GameObject go;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public int currentElement;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x34")]
	public float distance;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	public float speed;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2739924", Offset = "0x2739924", VA = "0x2739924")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2739C18", Offset = "0x2739C18", VA = "0x2739C18")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2739CC4", Offset = "0x2739CC4", VA = "0x2739CC4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2739D60", Offset = "0x2739D60", VA = "0x2739D60")]
	public runtimeScript()
	{
	}
}
