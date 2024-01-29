using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xEE68FC", Offset = "0xEE68FC")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEE68FC", Offset = "0xEE68FC")]
[ExecuteInEditMode]
public class MobileBloom : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0xC")]
	public float intensity;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x10")]
	public float threshhold;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x14")]
	public float blurWidth;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public bool extraBlurry;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x1C")]
	public Material bloomMaterial;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	private bool supported;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x24")]
	private RenderTexture tempRtA;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture tempRtB;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xDE5EB0", Offset = "0xDE5EB0", VA = "0xDE5EB0")]
	public MobileBloom()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDE5EF0", Offset = "0xDE5EF0", VA = "0xDE5EF0", Slot = "4")]
	public virtual bool Supported()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDE5F98", Offset = "0xDE5F98", VA = "0xDE5F98", Slot = "5")]
	public virtual void CreateBuffers()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xDE618C", Offset = "0xDE618C", VA = "0xDE618C", Slot = "6")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDE62F8", Offset = "0xDE62F8", VA = "0xDE62F8", Slot = "7")]
	public virtual bool EarlyOutIfNotSupported(RenderTexture source, RenderTexture destination)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDE63C4", Offset = "0xDE63C4", VA = "0xDE63C4", Slot = "8")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDE6B88", Offset = "0xDE6B88", VA = "0xDE6B88", Slot = "9")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class Animate : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 distortSpeed1;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 distortSpeed2;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDE5BF4", Offset = "0xDE5BF4", VA = "0xDE5BF4")]
	public Animate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDE5BFC", Offset = "0xDE5BFC", VA = "0xDE5BFC", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDE5CE0", Offset = "0xDE5CE0", VA = "0xDE5CE0", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDE5EAC", Offset = "0xDE5EAC", VA = "0xDE5EAC", Slot = "6")]
	public virtual void Main()
	{
	}
}
