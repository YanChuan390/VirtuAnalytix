using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Ywz;

[Token(Token = "0x2000002")]
public class AssetInfo : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x273D8BC", Offset = "0x273D8BC", VA = "0x273D8BC")]
	public AssetInfo()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class HideGameObject : MonoBehaviour
{
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x273D8C4", Offset = "0x273D8C4", VA = "0x273D8C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x273D8EC", Offset = "0x273D8EC", VA = "0x273D8EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x273D914", Offset = "0x273D914", VA = "0x273D914")]
	public HideGameObject()
	{
	}
}
