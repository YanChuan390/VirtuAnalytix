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
		[Address(RVA = "0x1379A08", Offset = "0x1379A08", VA = "0x1379A08")]
		public ListVector3()
		{
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
	[Range(0f, 10f)]
	private float outlineWidth;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x50")]
	[Header("Optional")]
	[SerializeField]
	[Tooltip("Precompute enabled: Per-vertex calculations are performed in the editor and serialized with the object. Precompute disabled: Per-vertex calculations are performed at runtime in Awake(). This may cause a pause for large meshes.")]
	private bool precomputeOutline;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[HideInInspector]
	private List<Mesh> bakeKeys;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[HideInInspector]
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
		[Address(RVA = "0x137814C", Offset = "0x137814C", VA = "0x137814C")]
		get
		{
			return default(Mode);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1378154", Offset = "0x1378154", VA = "0x1378154")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Color OutlineColor
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1378164", Offset = "0x1378164", VA = "0x1378164")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1378170", Offset = "0x1378170", VA = "0x1378170")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float OutlineWidth
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1378184", Offset = "0x1378184", VA = "0x1378184")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x137818C", Offset = "0x137818C", VA = "0x137818C")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x137819C", Offset = "0x137819C", VA = "0x137819C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13786AC", Offset = "0x13786AC", VA = "0x13786AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1378810", Offset = "0x1378810", VA = "0x1378810")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1378BA0", Offset = "0x1378BA0", VA = "0x1378BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1378D60", Offset = "0x1378D60", VA = "0x1378D60")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1378E30", Offset = "0x1378E30", VA = "0x1378E30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1378928", Offset = "0x1378928", VA = "0x1378928")]
	private void Bake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x137833C", Offset = "0x137833C", VA = "0x137833C")]
	private void LoadSmoothNormals()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1378E98", Offset = "0x1378E98", VA = "0x1378E98")]
	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1379A10", Offset = "0x1379A10", VA = "0x1379A10")]
	private void CombineSubmeshes(Mesh mesh, Material[] materials)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1378BB4", Offset = "0x1378BB4", VA = "0x1378BB4")]
	private void UpdateMaterialProperties()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1379AB8", Offset = "0x1379AB8", VA = "0x1379AB8")]
	public void SetHoverColor()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1379ACC", Offset = "0x1379ACC", VA = "0x1379ACC")]
	public void SetGrabColor()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1379AE0", Offset = "0x1379AE0", VA = "0x1379AE0")]
	public Outline()
	{
	}
}
