using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Lowscope.Tools;

[Token(Token = "0x2000002")]
public class ValidateHierarchy
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1297804", Offset = "0x1297804", VA = "0x1297804")]
	public static void Remove(MonoBehaviour monoBehaviour)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1297808", Offset = "0x1297808", VA = "0x1297808")]
	public static void Add(MonoBehaviour monoBehaviour)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x129780C", Offset = "0x129780C", VA = "0x129780C")]
	public ValidateHierarchy()
	{
	}
}
