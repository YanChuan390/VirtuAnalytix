using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class PhotonBridge : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static PhotonBridge instance;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public UnityAction<GameObject> beforeDestroy;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public UnityAction afterDestroy;

	[Token(Token = "0x17000001")]
	public static PhotonBridge Instance
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2139790", Offset = "0x2139790", VA = "0x2139790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x213985C", Offset = "0x213985C", VA = "0x213985C")]
	public void BeforeDestroy(GameObject go)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x21398D0", Offset = "0x21398D0", VA = "0x21398D0")]
	public void AfterDestroy()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x21398E4", Offset = "0x21398E4", VA = "0x21398E4")]
	public PhotonBridge()
	{
	}
}
