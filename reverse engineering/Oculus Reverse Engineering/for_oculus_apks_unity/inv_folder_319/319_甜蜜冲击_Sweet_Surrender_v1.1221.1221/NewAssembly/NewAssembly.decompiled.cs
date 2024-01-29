using System.Reflection;
using GE.Events;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace GE.Progression;

[Token(Token = "0x2000002")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x103B518", Offset = "0x103B518")]
public class ProgressionItem : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public ValueData unlockKey;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x235F2E8", Offset = "0x235F2E8", VA = "0x235F2E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x235F3F0", Offset = "0x235F3F0", VA = "0x235F3F0")]
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
	[Address(RVA = "0x235F3F8", Offset = "0x235F3F8", VA = "0x235F3F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x235F4D8", Offset = "0x235F4D8", VA = "0x235F4D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x235F574", Offset = "0x235F574", VA = "0x235F574")]
	public ProgressionSettings()
	{
	}
}
