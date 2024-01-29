using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
public class SceneReference : ISerializationCallbackReceiver
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string scenePath;

	[Token(Token = "0x17000001")]
	public string ScenePath
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x273D390", Offset = "0x273D390", VA = "0x273D390")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x273D398", Offset = "0x273D398", VA = "0x273D398")]
		set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x273D3A0", Offset = "0x273D3A0", VA = "0x273D3A0")]
	public static implicit operator string(SceneReference sceneReference)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x273D3B8", Offset = "0x273D3B8", VA = "0x273D3B8", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x273D3BC", Offset = "0x273D3BC", VA = "0x273D3BC", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x273D3C0", Offset = "0x273D3C0", VA = "0x273D3C0")]
	public SceneReference()
	{
	}
}
[Token(Token = "0x2000003")]
public class SceneReferenceTest : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public SceneReference exampleNull;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public SceneReference exampleMissing;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public SceneReference exampleDisabled;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	public SceneReference exampleEnabled;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x273D424", Offset = "0x273D424", VA = "0x273D424")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x273D45C", Offset = "0x273D45C", VA = "0x273D45C")]
	public void DisplayLevel(SceneReference scene)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x273D6A8", Offset = "0x273D6A8", VA = "0x273D6A8")]
	public SceneReferenceTest()
	{
	}
}
