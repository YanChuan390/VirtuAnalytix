using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Lowscope.Tools;

[Token(Token = "0x2000002")]
public class ValidateHierarchy
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x13CB5C4", Offset = "0x13CB5C4", VA = "0x13CB5C4")]
	public static void Remove(MonoBehaviour monoBehaviour)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13CB5C8", Offset = "0x13CB5C8", VA = "0x13CB5C8")]
	public static void Add(MonoBehaviour monoBehaviour)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x13CB5CC", Offset = "0x13CB5CC", VA = "0x13CB5CC")]
	public ValidateHierarchy()
	{
	}
}
