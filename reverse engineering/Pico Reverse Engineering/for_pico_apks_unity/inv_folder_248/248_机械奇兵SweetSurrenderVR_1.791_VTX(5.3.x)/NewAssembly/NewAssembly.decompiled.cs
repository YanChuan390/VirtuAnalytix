using System.Reflection;
using GE.Events;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace GE.Progression;

[Token(Token = "0x2000002")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0xE0AD8C", Offset = "0xE0AD8C")]
public class ProgressionItem : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public ValueData unlockKey;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x22E5BF0", Offset = "0x22E5BF0", VA = "0x22E5BF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x22E5CF8", Offset = "0x22E5CF8", VA = "0x22E5CF8")]
	public ProgressionItem()
	{
	}
}
[Token(Token = "0x2000003")]
public class ProgressionSettings : GenericValues
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	public static ProgressionSettings Instance;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x22E5D00", Offset = "0x22E5D00", VA = "0x22E5D00")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x22E5DE0", Offset = "0x22E5DE0", VA = "0x22E5DE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x22E5E7C", Offset = "0x22E5E7C", VA = "0x22E5E7C")]
	public ProgressionSettings()
	{
	}
}
