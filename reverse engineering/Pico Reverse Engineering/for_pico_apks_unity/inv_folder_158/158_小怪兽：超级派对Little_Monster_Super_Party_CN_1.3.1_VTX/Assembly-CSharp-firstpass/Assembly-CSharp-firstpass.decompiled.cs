using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x562990", Offset = "0x562990")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x562990", Offset = "0x562990")]
[DisallowMultipleComponent]
public class Outline : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum Mode
	{
		[Token(Token = "0x4000009")]
		OutlineAll,
		[Token(Token = "0x400000A")]
		OutlineVisible,
		[Token(Token = "0x400000B")]
		OutlineHidden,
		[Token(Token = "0x400000C")]
		OutlineAndSilhouette,
		[Token(Token = "0x400000D")]
		SilhouetteOnly
	}

	[Serializable]
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x562A34", Offset = "0x562A34")]
	private sealed class <>c
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__23_0;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__23_1;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x13BA2C4", Offset = "0x13BA2C4", VA = "0x13BA2C4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x13BA2CC", Offset = "0x13BA2CC", VA = "0x13BA2CC")]
		internal KeyValuePair<Vector3, int> <GenerateSmoothNormals>b__23_0(Vector3 vertex, int index)
		{
			return default(KeyValuePair<Vector3, int>);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x13BA358", Offset = "0x13BA358", VA = "0x13BA358")]
		internal Vector3 <GenerateSmoothNormals>b__23_1(KeyValuePair<Vector3, int> pair)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Mode outlineMode;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color outlineColor;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x562A64", Offset = "0x562A64")]
	private float outlineWidth;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	private Material[] materials;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	private Material outlineMaskMaterial;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x40")]
	private Material outlineFillMaterial;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x48")]
	private bool needsUpdate;

	[Token(Token = "0x17000001")]
	public Mode OutlineMode
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x13B9184", Offset = "0x13B9184", VA = "0x13B9184")]
		get
		{
			return default(Mode);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x13B918C", Offset = "0x13B918C", VA = "0x13B918C")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Color OutlineColor
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x13B919C", Offset = "0x13B919C", VA = "0x13B919C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x13B91A8", Offset = "0x13B91A8", VA = "0x13B91A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float OutlineWidth
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x13B91BC", Offset = "0x13B91BC", VA = "0x13B91BC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x13B91C4", Offset = "0x13B91C4", VA = "0x13B91C4")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13B91D4", Offset = "0x13B91D4", VA = "0x13B91D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13B9E60", Offset = "0x13B9E60", VA = "0x13B9E60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x13B9F64", Offset = "0x13B9F64", VA = "0x13B9F64")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x13B9F70", Offset = "0x13B9F70", VA = "0x13B9F70")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x13BA150", Offset = "0x13BA150", VA = "0x13BA150")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x13BA1B0", Offset = "0x13BA1B0", VA = "0x13BA1B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x13B9350", Offset = "0x13B9350", VA = "0x13B9350")]
	private void GenerateSmoothNormals()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x13B9F84", Offset = "0x13B9F84", VA = "0x13B9F84")]
	private void UpdateMaterialProperties()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x13BA224", Offset = "0x13BA224", VA = "0x13BA224")]
	public Outline()
	{
	}
}
