using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class DebugExtension
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2714B14", Offset = "0x2714B14", VA = "0x2714B14")]
	public static void DebugPoint(Vector3 position, Color color, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2714D84", Offset = "0x2714D84", VA = "0x2714D84")]
	public static void DebugPoint(Vector3 position, float scale = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2714E18", Offset = "0x2714E18", VA = "0x2714E18")]
	public static void DebugBounds(Bounds bounds, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x27151AC", Offset = "0x27151AC", VA = "0x27151AC")]
	public static void DebugBounds(Bounds bounds, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2715204", Offset = "0x2715204", VA = "0x2715204")]
	public static void DebugLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x271564C", Offset = "0x271564C", VA = "0x271564C")]
	public static void DebugLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x27156FC", Offset = "0x27156FC", VA = "0x27156FC")]
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2715B88", Offset = "0x2715B88", VA = "0x2715B88")]
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2715C44", Offset = "0x2715C44", VA = "0x2715C44")]
	public static void DebugCircle(Vector3 position, Vector3 up, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2715F8C", Offset = "0x2715F8C", VA = "0x2715F8C")]
	public static void DebugCircle(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x271602C", Offset = "0x271602C", VA = "0x271602C")]
	public static void DebugCircle(Vector3 position, Vector3 up, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x27160C8", Offset = "0x27160C8", VA = "0x27160C8")]
	public static void DebugCircle(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x271616C", Offset = "0x271616C", VA = "0x271616C")]
	public static void DebugWireSphere(Vector3 position, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x27163BC", Offset = "0x27163BC", VA = "0x27163BC")]
	public static void DebugWireSphere(Vector3 position, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2716450", Offset = "0x2716450", VA = "0x2716450")]
	public static void DebugCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2716908", Offset = "0x2716908", VA = "0x2716908")]
	public static void DebugCylinder(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x27169A4", Offset = "0x27169A4", VA = "0x27169A4")]
	public static void DebugCone(Vector3 position, Vector3 direction, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2716F2C", Offset = "0x2716F2C", VA = "0x2716F2C")]
	public static void DebugCone(Vector3 position, Vector3 direction, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2716FC8", Offset = "0x2716FC8", VA = "0x2716FC8")]
	public static void DebugCone(Vector3 position, Color color, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2717068", Offset = "0x2717068", VA = "0x2717068")]
	public static void DebugCone(Vector3 position, float angle = 45f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x271710C", Offset = "0x271710C", VA = "0x271710C")]
	public static void DebugArrow(Vector3 position, Vector3 direction, Color color, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x271724C", Offset = "0x271724C", VA = "0x271724C")]
	public static void DebugArrow(Vector3 position, Vector3 direction, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x27172E0", Offset = "0x27172E0", VA = "0x27172E0")]
	public static void DebugCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2717DF8", Offset = "0x2717DF8", VA = "0x2717DF8")]
	public static void DebugCapsule(Vector3 start, Vector3 end, float radius = 1f, float duration = 0f, bool depthTest = true)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2717E94", Offset = "0x2717E94", VA = "0x2717E94")]
	public static void DrawPoint(Vector3 position, Color color, float scale = 1f)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2718000", Offset = "0x2718000", VA = "0x2718000")]
	public static void DrawPoint(Vector3 position, float scale = 1f)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2718068", Offset = "0x2718068", VA = "0x2718068")]
	public static void DrawBounds(Bounds bounds, Color color)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x27182C0", Offset = "0x27182C0", VA = "0x27182C0")]
	public static void DrawBounds(Bounds bounds)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x27182F8", Offset = "0x27182F8", VA = "0x27182F8")]
	public static void DrawLocalCube(Transform transform, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2718688", Offset = "0x2718688", VA = "0x2718688")]
	public static void DrawLocalCube(Transform transform, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2718720", Offset = "0x2718720", VA = "0x2718720")]
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Color color, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2718AA8", Offset = "0x2718AA8", VA = "0x2718AA8")]
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, [Optional] Vector3 center)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2718B44", Offset = "0x2718B44", VA = "0x2718B44")]
	public static void DrawCircle(Vector3 position, Vector3 up, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2718E9C", Offset = "0x2718E9C", VA = "0x2718E9C")]
	public static void DrawCircle(Vector3 position, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2718F24", Offset = "0x2718F24", VA = "0x2718F24")]
	public static void DrawCircle(Vector3 position, Vector3 up, float radius = 1f)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2718F8C", Offset = "0x2718F8C", VA = "0x2718F8C")]
	public static void DrawCircle(Vector3 position, float radius = 1f)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2719018", Offset = "0x2719018", VA = "0x2719018")]
	public static void DrawCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x27193A0", Offset = "0x27193A0", VA = "0x27193A0")]
	public static void DrawCylinder(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2719424", Offset = "0x2719424", VA = "0x2719424")]
	public static void DrawCone(Vector3 position, Vector3 direction, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x27198E8", Offset = "0x27198E8", VA = "0x27198E8")]
	public static void DrawCone(Vector3 position, Vector3 direction, float angle = 45f)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x271996C", Offset = "0x271996C", VA = "0x271996C")]
	public static void DrawCone(Vector3 position, Color color, float angle = 45f)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x27199F4", Offset = "0x27199F4", VA = "0x27199F4")]
	public static void DrawCone(Vector3 position, float angle = 45f)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2719A80", Offset = "0x2719A80", VA = "0x2719A80")]
	public static void DrawArrow(Vector3 position, Vector3 direction, Color color)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2719B8C", Offset = "0x2719B8C", VA = "0x2719B8C")]
	public static void DrawArrow(Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2719C00", Offset = "0x2719C00", VA = "0x2719C00")]
	public static void DrawCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x271A4A0", Offset = "0x271A4A0", VA = "0x271A4A0")]
	public static void DrawCapsule(Vector3 start, Vector3 end, float radius = 1f)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x271A524", Offset = "0x271A524", VA = "0x271A524")]
	public static string MethodsOfObject(object obj, bool includeInfo = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x271A664", Offset = "0x271A664", VA = "0x271A664")]
	public static string MethodsOfType(Type type, bool includeInfo = false)
	{
		return null;
	}
}
