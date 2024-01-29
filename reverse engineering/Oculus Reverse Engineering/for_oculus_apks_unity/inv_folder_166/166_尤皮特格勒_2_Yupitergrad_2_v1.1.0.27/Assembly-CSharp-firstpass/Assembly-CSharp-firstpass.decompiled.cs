using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Koenigz.PerfectCulling.Demos;

[Token(Token = "0x2000002")]
public class FlyCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[Range(30f, 150f)]
	[SerializeField]
	private float MouseSensitivity;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	private float m_rotationX;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	private float m_rotationY;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD53574", Offset = "0xD53574", VA = "0xD53574")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD538DC", Offset = "0xD538DC", VA = "0xD538DC")]
	public FlyCamera()
	{
	}
}
[Token(Token = "0x2000003")]
public class RedCube : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD538EC", Offset = "0xD538EC", VA = "0xD538EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD53A04", Offset = "0xD53A04", VA = "0xD53A04")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD53B1C", Offset = "0xD53B1C", VA = "0xD53B1C")]
	public RedCube()
	{
	}
}
