using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class ColorExtensions
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1B967E0", Offset = "0x1B967E0", VA = "0x1B967E0")]
	public static Color FadeAlpha(this Color col, float t)
	{
		return default(Color);
	}
}
[Token(Token = "0x2000003")]
public static class Colors
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Color darkRed;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly Color darkGreen;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly Color darkBlue;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly Color darkCyan;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly Color darkYellow;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly Color darkMagenta;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static readonly Color orange;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static readonly Color lime;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static readonly Color mint;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static readonly Color teal;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static readonly Color skyblue;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static readonly Color darkskyblue;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public static readonly Color purple;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public static readonly Color lightpurple;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static readonly Color fuscia;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public static readonly Color rose;
}
[Token(Token = "0x2000004")]
public static class DebugDraw
{
	[Token(Token = "0x2000005")]
	private enum CE
	{
		[Token(Token = "0x4000014")]
		T = 1,
		[Token(Token = "0x4000015")]
		TL = 2,
		[Token(Token = "0x4000016")]
		TR = 4,
		[Token(Token = "0x4000017")]
		B = 8,
		[Token(Token = "0x4000018")]
		BL = 0x10,
		[Token(Token = "0x4000019")]
		BR = 0x20,
		[Token(Token = "0x400001A")]
		N = 0x40,
		[Token(Token = "0x400001B")]
		NE = 0x80,
		[Token(Token = "0x400001C")]
		E = 0x100,
		[Token(Token = "0x400001D")]
		SE = 0x200,
		[Token(Token = "0x400001E")]
		S = 0x400,
		[Token(Token = "0x400001F")]
		SW = 0x800,
		[Token(Token = "0x4000020")]
		W = 0x1000,
		[Token(Token = "0x4000021")]
		NW = 0x2000,
		[Token(Token = "0x4000022")]
		DT = 0x4000,
		[Token(Token = "0x4000023")]
		CM = 0x8000
	}

	[Token(Token = "0x2000006")]
	public class ElementCoords
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x0;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y0;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float x1;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float y1;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1BA1D8C", Offset = "0x1BA1D8C", VA = "0x1BA1D8C")]
		public ElementCoords(float _x0, float _y0, float _x1, float _y1)
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<CE, ElementCoords> ElementLookup;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<char, CE> CharElementLookup;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1B9692C", Offset = "0x1B9692C", VA = "0x1B9692C")]
	public static void Point(Vector3 position, Quaternion rotation, Color color, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1B96D98", Offset = "0x1B96D98", VA = "0x1B96D98")]
	public static void Gnomon(Matrix4x4 trsMatrix, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1B97054", Offset = "0x1B97054", VA = "0x1B97054")]
	public static void Gnomon(Matrix4x4 trsMatrix, float radiusA, float radiusB, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B97360", Offset = "0x1B97360", VA = "0x1B97360")]
	public static void Gnomon(Vector3 position, Quaternion rotation, float radiusA = 0f, float radiusB = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B974C0", Offset = "0x1B974C0", VA = "0x1B974C0")]
	public static void GnomonArrow(Vector3 position, Quaternion rotation, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B97868", Offset = "0x1B97868", VA = "0x1B97868")]
	public static void Point(Vector3 position, Color color, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B97970", Offset = "0x1B97970", VA = "0x1B97970")]
	public static void Point(Vector3 position, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B97A20", Offset = "0x1B97A20", VA = "0x1B97A20")]
	public static void Bounds(Bounds bounds, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B97DCC", Offset = "0x1B97DCC", VA = "0x1B97DCC")]
	public static void Bounds(Bounds bounds, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1B97E7C", Offset = "0x1B97E7C", VA = "0x1B97E7C")]
	public static void LocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1B982B0", Offset = "0x1B982B0", VA = "0x1B982B0")]
	public static void LocalCube(Transform transform, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1B98384", Offset = "0x1B98384", VA = "0x1B98384")]
	public static void LocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1B98808", Offset = "0x1B98808", VA = "0x1B98808")]
	public static void LocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1B98904", Offset = "0x1B98904", VA = "0x1B98904")]
	public static void NGon(Vector3 position, int sides, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1B98DC0", Offset = "0x1B98DC0", VA = "0x1B98DC0")]
	public static void NGon(Vector3 position, int sides, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1B98ED8", Offset = "0x1B98ED8", VA = "0x1B98ED8")]
	public static void NGon(Vector3 position, int sides, Vector3 up, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B98FB0", Offset = "0x1B98FB0", VA = "0x1B98FB0")]
	public static void NGon(Vector3 position, int sides, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B990B4", Offset = "0x1B990B4", VA = "0x1B990B4")]
	private static void DrawCharacter(CE ce, Vector3 position, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B9982C", Offset = "0x1B9982C", VA = "0x1B9982C")]
	public static void String(string message, Vector3 position, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1B99E64", Offset = "0x1B99E64", VA = "0x1B99E64")]
	public static void String(string message, Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1B99F70", Offset = "0x1B99F70", VA = "0x1B99F70")]
	public static void String(string message, Vector3 position, Vector3 up, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1B9A048", Offset = "0x1B9A048", VA = "0x1B9A048")]
	public static void String(string message, Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1B9A14C", Offset = "0x1B9A14C", VA = "0x1B9A14C")]
	public static void Circle(Vector3 position, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1B9A5CC", Offset = "0x1B9A5CC", VA = "0x1B9A5CC")]
	public static void Circle(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1B9A6CC", Offset = "0x1B9A6CC", VA = "0x1B9A6CC")]
	public static void Circle(Vector3 position, Vector3 up, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1B9A794", Offset = "0x1B9A794", VA = "0x1B9A794")]
	public static void Circle(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1B9A888", Offset = "0x1B9A888", VA = "0x1B9A888")]
	public static void Arc(Vector3 position, Vector3 up, Vector3 forward, float angle, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1B9BB2C", Offset = "0x1B9BB2C", VA = "0x1B9BB2C")]
	public static void Arc(Vector3 position, Vector3 forward, Quaternion rotation, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1B9BC60", Offset = "0x1B9BC60", VA = "0x1B9BC60")]
	public static void Arc(Vector3 position, Vector3 forward, float angle, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1B9BD84", Offset = "0x1B9BD84", VA = "0x1B9BD84")]
	public static void Arc(Vector3 position, Vector3 up, Vector3 forward, float angle, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1B9BE84", Offset = "0x1B9BE84", VA = "0x1B9BE84")]
	public static void Arc(Vector3 position, float angle, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1B9BFB4", Offset = "0x1B9BFB4", VA = "0x1B9BFB4")]
	public static void WireSphere(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1B9C1AC", Offset = "0x1B9C1AC", VA = "0x1B9C1AC")]
	public static void WireSphere(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1B9C25C", Offset = "0x1B9C25C", VA = "0x1B9C25C")]
	public static void Cylinder(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1B9C85C", Offset = "0x1B9C85C", VA = "0x1B9C85C")]
	public static void Cylinder(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1B9B0E8", Offset = "0x1B9B0E8", VA = "0x1B9B0E8")]
	public static void Cone(Vector3 position, Vector3 direction, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1B9C924", Offset = "0x1B9C924", VA = "0x1B9C924")]
	public static void Cone(Vector3 position, Vector3 direction, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1B9C9EC", Offset = "0x1B9C9EC", VA = "0x1B9C9EC")]
	public static void Cone(Vector3 position, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1B9CAEC", Offset = "0x1B9CAEC", VA = "0x1B9CAEC")]
	public static void Cone(Vector3 position, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1B9CBE0", Offset = "0x1B9CBE0", VA = "0x1B9CBE0")]
	public static void Sweep(Vector3 position, Vector3 startDir, Vector3 endDir, int subdivisions, Color color)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1B97700", Offset = "0x1B97700", VA = "0x1B97700")]
	public static void Arrow(Vector3 position, Vector3 direction, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1B9CD18", Offset = "0x1B9CD18", VA = "0x1B9CD18")]
	public static void Arrow(Ray ray, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1B9CE18", Offset = "0x1B9CE18", VA = "0x1B9CE18")]
	public static void Arrow(Vector3 position, Vector3 direction, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1B9CED8", Offset = "0x1B9CED8", VA = "0x1B9CED8")]
	public static void Arrow(Ray ray, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1B9CFA8", Offset = "0x1B9CFA8", VA = "0x1B9CFA8")]
	public static void Capsule(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1B9DD90", Offset = "0x1B9DD90", VA = "0x1B9DD90")]
	public static void Capsule(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1B9DE58", Offset = "0x1B9DE58", VA = "0x1B9DE58")]
	public static void GPoint(Vector3 position, Color color, float scale = 1f)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1B9E00C", Offset = "0x1B9E00C", VA = "0x1B9E00C")]
	public static void GPoint(Vector3 position, float scale = 1f)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1B9E098", Offset = "0x1B9E098", VA = "0x1B9E098")]
	public static void GBounds(Bounds bounds, Color color)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1B9E2E4", Offset = "0x1B9E2E4", VA = "0x1B9E2E4")]
	public static void GBounds(Bounds bounds)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1B9E374", Offset = "0x1B9E374", VA = "0x1B9E374")]
	public static void GLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1B9E6F4", Offset = "0x1B9E6F4", VA = "0x1B9E6F4")]
	public static void GLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1B9E7A8", Offset = "0x1B9E7A8", VA = "0x1B9E7A8")]
	public static void GLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1B9EB1C", Offset = "0x1B9EB1C", VA = "0x1B9EB1C")]
	public static void GLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1B9EBF8", Offset = "0x1B9EBF8", VA = "0x1B9EBF8")]
	public static void GCircle(Vector3 position, Vector3 up, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1B9F0BC", Offset = "0x1B9F0BC", VA = "0x1B9F0BC")]
	public static void GCircle(Vector3 position, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1B9F1B0", Offset = "0x1B9F1B0", VA = "0x1B9F1B0")]
	public static void GCircle(Vector3 position, Vector3 up, float radius = 1f)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1B9F24C", Offset = "0x1B9F24C", VA = "0x1B9F24C")]
	public static void GCircle(Vector3 position, float radius = 1f)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1B9F330", Offset = "0x1B9F330", VA = "0x1B9F330")]
	public static void GCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1B9F810", Offset = "0x1B9F810", VA = "0x1B9F810")]
	public static void GCylinder(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1B9F8C8", Offset = "0x1B9F8C8", VA = "0x1B9F8C8")]
	public static void GCone(Vector3 position, Vector3 direction, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1BA0264", Offset = "0x1BA0264", VA = "0x1BA0264")]
	public static void GCone(Vector3 position, Vector3 direction, float angle = 45f)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1BA031C", Offset = "0x1BA031C", VA = "0x1BA031C")]
	public static void GCone(Vector3 position, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1BA0410", Offset = "0x1BA0410", VA = "0x1BA0410")]
	public static void GCone(Vector3 position, float angle = 45f)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1BA04F4", Offset = "0x1BA04F4", VA = "0x1BA04F4")]
	public static void GArrow(Vector3 position, Vector3 direction, Color color)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1BA0644", Offset = "0x1BA0644", VA = "0x1BA0644")]
	public static void GArrow(Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1BA06EC", Offset = "0x1BA06EC", VA = "0x1BA06EC")]
	public static void GCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1BA122C", Offset = "0x1BA122C", VA = "0x1BA122C")]
	public static void GCapsule(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1BA12E4", Offset = "0x1BA12E4", VA = "0x1BA12E4")]
	public static string MethodsOfObject(object obj, bool includeInfo = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1BA1410", Offset = "0x1BA1410", VA = "0x1BA1410")]
	public static string MethodsOfType(Type type, bool includeInfo = false)
	{
		return null;
	}
}
