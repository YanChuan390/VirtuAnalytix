using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DisablePS4VR : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x11AA978", Offset = "0x11AA978", VA = "0x11AA978")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x11AA97C", Offset = "0x11AA97C", VA = "0x11AA97C")]
	public DisablePS4VR()
	{
	}
}
[Token(Token = "0x2000003")]
public class EnablePS4VR : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x11AA984", Offset = "0x11AA984", VA = "0x11AA984")]
	public EnablePS4VR()
	{
	}
}
[Token(Token = "0x2000004")]
public class PSVRManager : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x11AA98C", Offset = "0x11AA98C", VA = "0x11AA98C")]
	public PSVRManager()
	{
	}
}
