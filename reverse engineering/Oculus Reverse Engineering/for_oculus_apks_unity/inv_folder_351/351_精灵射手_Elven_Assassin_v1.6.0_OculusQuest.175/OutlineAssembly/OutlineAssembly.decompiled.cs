using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[DisallowMultipleComponent]
public class Outline : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum Mode
	{
		[Token(Token = "0x400000F")]
		OutlineAll,
		[Token(Token = "0x4000010")]
		OutlineVisible,
		[Token(Token = "0x4000011")]
		OutlineHidden,
		[Token(Token = "0x4000012")]
		OutlineAndSilhouette,
		[Token(Token = "0x4000013")]
		SilhouetteOnly
	}

	[Serializable]
	[Token(Token = "0x2000004")]
	private class ListVector3
	{
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector3> data;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x134FF6C", Offset = "0x134FF6C", VA = "0x134FF6C")]
		public ListVector3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000005")]
	private sealed class <>c
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__32_0;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__32_1;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1350234", Offset = "0x1350234", VA = "0x1350234")]
		public <>c()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x135023C", Offset = "0x135023C", VA = "0x135023C")]
		internal KeyValuePair<Vector3, int> <SmoothNormals>b__32_0(Vector3 vertex, int index)
		{
			return default(KeyValuePair<Vector3, int>);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x13502C4", Offset = "0x13502C4", VA = "0x13502C4")]
		internal Vector3 <SmoothNormals>b__32_1(KeyValuePair<Vector3, int> pair)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<Mesh> registeredMeshes;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Mode outlineMode;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color outlineColor;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Color hoverColor;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Color grabColor;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float outlineWidth;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool precomputeOutline;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<Mesh> bakeKeys;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<ListVector3> bakeValues;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x68")]
	private Renderer renderer;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x70")]
	private Material outlineMaskMaterial;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x78")]
	private Material outlineFillMaterial;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x80")]
	private bool needsUpdate;

	[Token(Token = "0x17000001")]
	public Mode OutlineMode
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x134E6B0", Offset = "0x134E6B0", VA = "0x134E6B0")]
		get
		{
			return default(Mode);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x134E6B8", Offset = "0x134E6B8", VA = "0x134E6B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Color OutlineColor
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x134E6C8", Offset = "0x134E6C8", VA = "0x134E6C8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x134E6D4", Offset = "0x134E6D4", VA = "0x134E6D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float OutlineWidth
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x134E6E8", Offset = "0x134E6E8", VA = "0x134E6E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x134E6F0", Offset = "0x134E6F0", VA = "0x134E6F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x134E700", Offset = "0x134E700", VA = "0x134E700")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x134EC10", Offset = "0x134EC10", VA = "0x134EC10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x134ED74", Offset = "0x134ED74", VA = "0x134ED74")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x134F104", Offset = "0x134F104", VA = "0x134F104")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x134F2C4", Offset = "0x134F2C4", VA = "0x134F2C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x134F394", Offset = "0x134F394", VA = "0x134F394")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x134EE8C", Offset = "0x134EE8C", VA = "0x134EE8C")]
	private void Bake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x134E8A0", Offset = "0x134E8A0", VA = "0x134E8A0")]
	private void LoadSmoothNormals()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x134F3FC", Offset = "0x134F3FC", VA = "0x134F3FC")]
	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x134FF74", Offset = "0x134FF74", VA = "0x134FF74")]
	private void CombineSubmeshes(Mesh mesh, Material[] materials)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x134F118", Offset = "0x134F118", VA = "0x134F118")]
	private void UpdateMaterialProperties()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x135001C", Offset = "0x135001C", VA = "0x135001C")]
	public void SetHoverColor()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1350030", Offset = "0x1350030", VA = "0x1350030")]
	public void SetGrabColor()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1350044", Offset = "0x1350044", VA = "0x1350044")]
	public Outline()
	{
	}
}
