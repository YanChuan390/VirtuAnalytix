using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class HxSimpleRotate : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotateSpeed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1169FA4", Offset = "0x1169FA4", VA = "0x1169FA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x116A068", Offset = "0x116A068", VA = "0x116A068")]
	public HxSimpleRotate()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class HxDensityVolume : MonoBehaviour
{
	[Token(Token = "0x200003A")]
	public enum DensityShape
	{
		[Token(Token = "0x4000343")]
		Square,
		[Token(Token = "0x4000344")]
		Sphere,
		[Token(Token = "0x4000345")]
		Cylinder
	}

	[Token(Token = "0x200003B")]
	public enum DensityBlendMode
	{
		[Token(Token = "0x4000347")]
		Max,
		[Token(Token = "0x4000348")]
		Add,
		[Token(Token = "0x4000349")]
		Min,
		[Token(Token = "0x400034A")]
		Sub
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static HxOctree<HxDensityVolume> DensityOctree;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HxOctreeNode<HxDensityVolume>.NodeObject octreeNode;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DensityShape Shape;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public DensityBlendMode BlendMode;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Vector3 minBounds;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public Vector3 maxBounds;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Matrix4x4 ToLocalSpace;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float Density;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Color gizmoColor;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Vector3 c1;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static Vector3 c2;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 c3;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static Vector3 c4;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Vector3 c5;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static Vector3 c6;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Vector3 c7;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private static Vector3 c8;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x116926C", Offset = "0x116926C", VA = "0x116926C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x116984C", Offset = "0x116984C", VA = "0x116984C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x11698BC", Offset = "0x11698BC", VA = "0x11698BC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x11699E4", Offset = "0x11699E4", VA = "0x11699E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1169AEC", Offset = "0x1169AEC", VA = "0x1169AEC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1169BF4", Offset = "0x1169BF4", VA = "0x1169BF4")]
	public void UpdateVolume()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x11693E0", Offset = "0x11693E0", VA = "0x11693E0")]
	private void CalculateBounds()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1169CD0", Offset = "0x1169CD0", VA = "0x1169CD0")]
	public HxDensityVolume()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D1624", Offset = "0x7D1624")]
public class HxDummyLight : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightType type;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float range;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1CC0", Offset = "0x7D1CC0")]
	public float spotAngle;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1CDC", Offset = "0x7D1CDC")]
	public float intensity;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture cookie;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1169F50", Offset = "0x1169F50", VA = "0x1169F50")]
	public void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1169F54", Offset = "0x1169F54", VA = "0x1169F54")]
	public HxDummyLight()
	{
	}
}
[Token(Token = "0x2000005")]
public class HxOctree<T>
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D1CF4", Offset = "0x7D1CF4")]
	private int <Count>k__BackingField;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private HxOctreeNode<T> Root;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float Overlap;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float InitialSize;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float MinNodeSize;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<T, HxOctreeNode<T>.NodeObject> NodeMap;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x600000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3204", Offset = "0x7D3204")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3214", Offset = "0x7D3214")]
		private set
		{
		}
	}

	[Token(Token = "0x6000010")]
	public HxOctree([Optional] Vector3 origin, float initialSize = 10f, float overlap = 0f, float minNodeSize = 1f)
	{
	}

	[Token(Token = "0x6000011")]
	public HxOctreeNode<T>.NodeObject Add(T value, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	public void Print()
	{
	}

	[Token(Token = "0x6000013")]
	public void Move(HxOctreeNode<T>.NodeObject value, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Token(Token = "0x6000014")]
	public void Move(T value, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Token(Token = "0x6000015")]
	public void TryShrink()
	{
	}

	[Token(Token = "0x6000016")]
	public bool Remove(T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	private void ExpandRoot(Vector3 center)
	{
	}

	[Token(Token = "0x6000018")]
	public void GetObjects(Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	[Token(Token = "0x6000019")]
	public void GetObjectsBoundsPlane(ref Plane[] planes, Vector3 min, Vector3 max, List<T> items)
	{
	}

	[Token(Token = "0x600001A")]
	public void Draw()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class HxOctreeNode<T>
{
	[Serializable]
	[Token(Token = "0x200003C")]
	public class NodeObject
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HxOctreeNode<T> Node;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMin;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMax;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Center;

		[Token(Token = "0x60001F3")]
		public NodeObject(T value, Vector3 boundsMin, Vector3 boundsMax)
		{
		}
	}

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D1D04", Offset = "0x7D1D04")]
	private Vector3 <Origin>k__BackingField;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D1D14", Offset = "0x7D1D14")]
	private float <Size>k__BackingField;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public HxOctreeNode<T> Parent;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float MinSize;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float Overlap;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float SizeWithOverlap;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 BoundsMin;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 BoundsMax;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly List<NodeObject> Objects;

	[Token(Token = "0x4000028")]
	private const int MaxObjectCount = 8;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public HxOctreeNode<T>[] Children;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3[] ChildrenBoundsMin;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3[] ChildrenBoundsMax;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int ID;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int _idCtr;

	[Token(Token = "0x17000002")]
	public Vector3 Origin
	{
		[Token(Token = "0x600001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3224", Offset = "0x7D3224")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3234", Offset = "0x7D3234")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float Size
	{
		[Token(Token = "0x600001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3244", Offset = "0x7D3244")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3254", Offset = "0x7D3254")]
		private set
		{
		}
	}

	[Token(Token = "0x600001F")]
	public HxOctreeNode(float size, float overlap, float minSize, Vector3 origin, HxOctreeNode<T> parent)
	{
	}

	[Token(Token = "0x6000020")]
	private void Init(float size, float overlap, float minSize, Vector3 origin, HxOctreeNode<T> parent)
	{
	}

	[Token(Token = "0x6000021")]
	public void Add(NodeObject node)
	{
	}

	[Token(Token = "0x6000022")]
	public bool Remove(T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	public void GetObjects(Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	[Token(Token = "0x6000024")]
	public void GetObjects2(Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	[Token(Token = "0x6000025")]
	public void GetObjects2BoundsPlane(ref Plane[] planes, Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	[Token(Token = "0x6000026")]
	private void DrawBounds(Vector3 min, Vector3 max)
	{
	}

	[Token(Token = "0x6000027")]
	private int BoundsInPlanes(Vector3 min, Vector3 max, ref Plane[] planes)
	{
		return default(int);
	}

	[Token(Token = "0x6000028")]
	private bool ObjectInPlanes(Vector3 min, Vector3 max, ref Plane[] planes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000029")]
	private Vector3 GetVertexP(Vector3 min, Vector3 max, Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002A")]
	private Vector3 GetVertexN(Vector3 min, Vector3 max, Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002B")]
	private void addAllObjectsToList(List<T> items)
	{
	}

	[Token(Token = "0x600002C")]
	private void addAllObjectsToList(List<T> items, ref Vector3 min, ref Vector3 max)
	{
	}

	[Token(Token = "0x600002D")]
	public HxOctreeNode<T> TryShrink(float minSize)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	private Vector3 GetVertexP(Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002F")]
	private bool HasObjects()
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	public static bool BoundsIntersects(Vector3 aMin, Vector3 aMax, Vector3 bMin, Vector3 bMax)
	{
		return default(bool);
	}

	[Token(Token = "0x6000031")]
	public static bool BoundsContains(Vector3 outerMin, Vector3 outerMax, Vector3 innerMin, Vector3 innerMax)
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	private int OctantIndex(Vector3 point)
	{
		return default(int);
	}

	[Token(Token = "0x6000033")]
	public void Draw(int counter = 0)
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
public class HxVolumetricCamera : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	public enum hxRenderOrder
	{
		[Token(Token = "0x4000351")]
		ImageEffect,
		[Token(Token = "0x4000352")]
		ImageEffectOpaque
	}

	[Token(Token = "0x200003E")]
	public enum TransparencyQualities
	{
		[Token(Token = "0x4000354")]
		Low,
		[Token(Token = "0x4000355")]
		Medium,
		[Token(Token = "0x4000356")]
		High,
		[Token(Token = "0x4000357")]
		VeryHigh
	}

	[Token(Token = "0x200003F")]
	public enum DensityParticleQualities
	{
		[Token(Token = "0x4000359")]
		Low,
		[Token(Token = "0x400035A")]
		Medium,
		[Token(Token = "0x400035B")]
		High,
		[Token(Token = "0x400035C")]
		VeryHigh
	}

	[Token(Token = "0x2000040")]
	public enum HxAmbientMode
	{
		[Token(Token = "0x400035E")]
		UseRenderSettings,
		[Token(Token = "0x400035F")]
		Color,
		[Token(Token = "0x4000360")]
		Gradient
	}

	[Token(Token = "0x2000041")]
	public enum HxTintMode
	{
		[Token(Token = "0x4000362")]
		Off,
		[Token(Token = "0x4000363")]
		Color,
		[Token(Token = "0x4000364")]
		Edge,
		[Token(Token = "0x4000365")]
		Gradient
	}

	[Token(Token = "0x2000042")]
	public enum Resolution
	{
		[Token(Token = "0x4000367")]
		full,
		[Token(Token = "0x4000368")]
		half,
		[Token(Token = "0x4000369")]
		quarter
	}

	[Token(Token = "0x2000043")]
	public enum DensityResolution
	{
		[Token(Token = "0x400036B")]
		full,
		[Token(Token = "0x400036C")]
		half,
		[Token(Token = "0x400036D")]
		quarter,
		[Token(Token = "0x400036E")]
		eighth
	}

	[Token(Token = "0x2000044")]
	private struct TriangleIndices
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int v1;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int v2;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int v3;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x87B0E4", Offset = "0x87B0E4", VA = "0x87B0E4")]
		public TriangleIndices(int v1, int v2, int v3)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D1C60", Offset = "0x7D1C60")]
	private sealed class <>c
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<HxDensityVolume> <>9__233_0;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x117BDC4", Offset = "0x117BDC4", VA = "0x117BDC4")]
		public <>c()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x117BDCC", Offset = "0x117BDCC", VA = "0x117BDCC")]
		internal int <FindActiveLights>b__233_0(HxDensityVolume a, HxDensityVolume b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transform;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public hxRenderOrder RenderOrder;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HxVolumetricRenderCallback callBackImageEffect;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HxVolumetricRenderCallback callBackImageEffectOpaque;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool ShadowFix;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool TemporalFirst;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool TemporalSampling;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1D24", Offset = "0x7D1D24")]
	public float DitherSpeed;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1D3C", Offset = "0x7D1D3C")]
	public float LuminanceFeedback;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1D54", Offset = "0x7D1D54")]
	public float MaxFeedback;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1D6C", Offset = "0x7D1D6C")]
	public float NoiseContrast;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Shader directionalShader;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Shader pointShader;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Shader spotShader;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Shader ProjectorShader;

	[NonSerialized]
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool FullUsed;

	[NonSerialized]
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool LowResUsed;

	[NonSerialized]
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool HeightFogUsed;

	[NonSerialized]
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	public bool HeightFogOffUsed;

	[NonSerialized]
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool NoiseUsed;

	[NonSerialized]
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool NoiseOffUsed;

	[NonSerialized]
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool TransparencyUsed;

	[NonSerialized]
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool TransparencyOffUsed;

	[NonSerialized]
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool DensityParticlesUsed;

	[NonSerialized]
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool PointUsed;

	[NonSerialized]
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool SpotUsed;

	[NonSerialized]
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
	public bool ProjectorUsed;

	[NonSerialized]
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool DirectionalUsed;

	[NonSerialized]
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool SinglePassStereoUsed;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static TransparencyQualities TransparencyBufferDepth;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static DensityParticleQualities DensityBufferDepth;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int EnumBufferDepthLength;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Matrix4x4 CurrentView;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Matrix4x4 CurrentProj;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Matrix4x4 CurrentInvers;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Matrix4x4 CurrentView2;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Matrix4x4 CurrentProj2;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Matrix4x4 CurrentInvers2;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private RenderTexture TemporalTexture;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private RenderTargetIdentifier TemporalTextureRTID;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private RenderTexture VolumetricTexture;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private RenderTexture FullBlurRT;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private RenderTargetIdentifier FullBlurRTID;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private RenderTexture downScaledBlurRT;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private RenderTargetIdentifier downScaledBlurRTID;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private RenderTexture FullBlurRT2;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private RenderTargetIdentifier FullBlurRT2ID;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private RenderTargetIdentifier[] VolumetricUpsampledBlurTextures;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private RenderTexture[] VolumetricDensityTextures;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private int[] VolumetricDensityPID;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private int[] VolumetricTransparencyPID;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private RenderTexture[] VolumetricTransparencyTextures;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public RenderTargetIdentifier[][] VolumetricDensity;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public RenderTargetIdentifier[][] VolumetricTransparency;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public RenderTargetIdentifier[][] VolumetricTransparencyI;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public RenderTexture[] ScaledDepthTexture;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static ShaderVariantCollection CollectionAll;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Texture2D Tile5x5;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int VolumetricTexturePID;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int ScaledDepthTexturePID;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static int ShadowMapTexturePID;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static RenderTargetIdentifier VolumetricTextureRTID;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public RenderTargetIdentifier[] ScaledDepthTextureRTID;

	[NonSerialized]
	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static Material DownSampleMaterial;

	[NonSerialized]
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static Material VolumeBlurMaterial;

	[NonSerialized]
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static Material TransparencyBlurMaterial;

	[NonSerialized]
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static Material ApplyMaterial;

	[NonSerialized]
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static Material ApplyDirectMaterial;

	[NonSerialized]
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static Material ApplyQueueMaterial;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Texture3D NoiseTexture3D;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public Matrix4x4 BlitMatrix;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public Matrix4x4 BlitMatrixMV;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public Matrix4x4 BlitMatrixMVP;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	public Vector3 BlitScale;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1D84", Offset = "0x7D1D84")]
	public Resolution resolution;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1DBC", Offset = "0x7D1DBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1DBC", Offset = "0x7D1DBC")]
	public int SampleCount;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1E14", Offset = "0x7D1E14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1E14", Offset = "0x7D1E14")]
	public int DirectionalSampleCount;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1E6C", Offset = "0x7D1E6C")]
	public float MaxDirectionalRayDistance;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1EA4", Offset = "0x7D1EA4")]
	public float MaxLightDistance;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1EDC", Offset = "0x7D1EDC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1EDC", Offset = "0x7D1EDC")]
	public float Density;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1F30", Offset = "0x7D1F30")]
	public float AmbientLightingStrength;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1F48", Offset = "0x7D1F48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1F48", Offset = "0x7D1F48")]
	public float MieScattering;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D1FA0", Offset = "0x7D1FA0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1FA0", Offset = "0x7D1FA0")]
	public float SunSize;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D1FF4", Offset = "0x7D1FF4")]
	public bool SunBleed;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D202C", Offset = "0x7D202C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D202C", Offset = "0x7D202C")]
	public float Extinction;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2080", Offset = "0x7D2080")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2080", Offset = "0x7D2080")]
	public float ExtinctionEffect;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
	public bool FogHeightEnabled;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public float FogHeight;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
	public float FogTransitionSize;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public float AboveFogPercent;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D20D4", Offset = "0x7D20D4")]
	public HxAmbientMode Ambient;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	public Color AmbientSky;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	public Color AmbientEquator;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	public Color AmbientGround;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D210C", Offset = "0x7D210C")]
	public float AmbientIntensity;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x444")]
	public HxTintMode TintMode;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
	public Color TintColor;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
	public Color TintColor2;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
	public float TintIntensity;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2124", Offset = "0x7D2124")]
	public float TintGradient;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
	public Vector3 CurrentTint;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
	public Vector3 CurrentTintEdge;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D213C", Offset = "0x7D213C")]
	public bool NoiseEnabled;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2174", Offset = "0x7D2174")]
	public Vector3 NoiseScale;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D21AC", Offset = "0x7D21AC")]
	public Vector3 NoiseVelocity;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D21E4", Offset = "0x7D21E4")]
	public bool ParticleDensitySupport;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D221C", Offset = "0x7D221C")]
	public DensityResolution densityResolution;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2254", Offset = "0x7D2254")]
	public float densityDistance;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	private float densityBias;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D228C", Offset = "0x7D228C")]
	public bool TransparencySupport;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D22C4", Offset = "0x7D22C4")]
	public float transparencyDistance;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D22FC", Offset = "0x7D22FC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D22FC", Offset = "0x7D22FC")]
	public int BlurTransparency;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	private float transparencyBias;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2350", Offset = "0x7D2350")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2350", Offset = "0x7D2350")]
	public int blurCount;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D23A4", Offset = "0x7D23A4")]
	public float BlurDepthFalloff;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D23DC", Offset = "0x7D23DC")]
	public float DownsampledBlurDepthFalloff;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2414", Offset = "0x7D2414")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2414", Offset = "0x7D2414")]
	public int UpSampledblurCount;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2468", Offset = "0x7D2468")]
	public float DepthThreshold;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D24A0", Offset = "0x7D24A0")]
	public bool GaussianWeights;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D9")]
	[HideInInspector]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D24D8", Offset = "0x7D24D8")]
	public bool MapToLDR;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4DA")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2524", Offset = "0x7D2524")]
	public bool RemoveColorBanding;

	[NonSerialized]
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4DC")]
	public Vector3 Offset;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static int DepthThresholdPID;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private static int BlurDepthFalloffPID;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static int VolumeScalePID;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int InverseViewMatrixPID;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static int InverseProjectionMatrixPID;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private static int InverseProjectionMatrix2PID;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static int NoiseOffsetPID;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private static int ShadowDistancePID;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static HxVolumetricShadersUsed UsedShaderSettings;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private static List<string> ShaderVariantList;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public static List<HxDensityVolume> ActiveVolumes;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static List<HxVolumetricLight> ActiveLights;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static List<HxVolumetricParticleSystem> ActiveParticleSystems;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static HxOctree<HxVolumetricLight> LightOctree;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public static HxOctree<HxVolumetricParticleSystem> ParticleOctree;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public static HashSet<HxDensityVolume> AllDensityVolumes;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public static HashSet<HxVolumetricLight> AllVolumetricLight;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public static HashSet<HxVolumetricParticleSystem> AllParticleSystems;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
	private bool test;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public static Mesh QuadMesh;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public static Mesh BoxMesh;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public static Mesh SphereMesh;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public static Mesh SpotLightMesh;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public static Mesh OrthoProjectorMesh;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
	[HideInInspector]
	private Camera Mycamera;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private static float[] ResolutionScale;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public static float[] SampleScale;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
	private CommandBuffer BufferSetup;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
	private CommandBuffer BufferRender;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
	private CommandBuffer BufferRenderLights;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
	private CommandBuffer BufferFinalize;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
	private bool dirty;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x519")]
	private bool PIDCreated;

	[NonSerialized]
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private static Dictionary<int, Material> DirectionalMaterial;

	[NonSerialized]
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private static Dictionary<int, Material> PointMaterial;

	[NonSerialized]
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private static Dictionary<int, Material> SpotMaterial;

	[NonSerialized]
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private static Dictionary<int, Material> ProjectorMaterial;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public static ShaderVariantCollection.ShaderVariant[] DirectionalVariant;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public static ShaderVariantCollection.ShaderVariant[] PointVariant;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public static ShaderVariantCollection.ShaderVariant[] SpotVariant;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public static Material ShadowMaterial;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public static Material DensityMaterial;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51C")]
	[HideInInspector]
	public Matrix4x4 MatrixVP;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55C")]
	public Matrix4x4 LastMatrixVP;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59C")]
	public Matrix4x4 LastMatrixVPInv;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5DC")]
	public Matrix4x4 LastMatrixVP2;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61C")]
	public Matrix4x4 LastMatrixVPInv2;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65C")]
	[HideInInspector]
	public Matrix4x4 MatrixV;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
	private bool OffsetUpdated;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[HideInInspector]
	private static Texture2D _SpotLightCookie;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[HideInInspector]
	private static Texture2D _LightFalloff;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
	private int ParticleDensityRenderCount;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private static Matrix4x4 particleMatrix;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public static HxVolumetricCamera Active;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public static Camera ActiveCamera;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A4")]
	private CameraEvent LightRenderEvent;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
	private CameraEvent SetupEvent;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6AC")]
	private CameraEvent RenderEvent;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
	private CameraEvent FinalizeEvent;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public static List<HxVolumetricLight> ActiveDirectionalLights;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private static Vector3 MinBounds;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private static Vector3 MaxBounds;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private static Plane[] CameraPlanes;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B4")]
	private bool preCullEventAdded;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B5")]
	private bool BuffersBuilt;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B6")]
	private bool LightBufferAdded;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B7")]
	private bool SetupBufferAdded;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
	private bool SetupBufferDirty;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B9")]
	private bool FinalizeBufferAdded;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6BA")]
	private bool FinalizeBufferDirty;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6BC")]
	private CameraEvent lastApply;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
	private CameraEvent lastRender;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C4")]
	private CameraEvent lastSetup;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
	private CameraEvent lastFinalize;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6CC")]
	private CameraEvent lastLightRender;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
	private bool LastPlaying;

	[NonSerialized]
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private static int lastRes;

	[NonSerialized]
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
	private int lastBlurCount;

	[NonSerialized]
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
	private int lastupSampleBlurCount;

	[NonSerialized]
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6DC")]
	private int lastLDR;

	[NonSerialized]
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
	private int lastBanding;

	[NonSerialized]
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E4")]
	private int lastH;

	[NonSerialized]
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
	private int lastW;

	[NonSerialized]
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6EC")]
	private int lastPath;

	[NonSerialized]
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
	private int lastGaussian;

	[NonSerialized]
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F4")]
	private int lastTransparency;

	[NonSerialized]
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
	private int lastDensity;

	[NonSerialized]
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6FC")]
	private int lastDensityRes;

	[NonSerialized]
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
	private float lastDepthFalloff;

	[NonSerialized]
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x704")]
	private float lastDownDepthFalloff;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
	private float currentDitherOffset;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70C")]
	private float MaxLightDistanceUsed;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	public static bool FirstDirectional;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private static int[] Tile5x5int;

	[Token(Token = "0x17000004")]
	public Transform myTransform
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x116A070", Offset = "0x116A070", VA = "0x116A070")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x116A100", Offset = "0x116A100", VA = "0x116A100")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	[HideInInspector]
	public Texture2D SpotLightCookie
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x116EB40", Offset = "0x116EB40", VA = "0x116EB40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x116ECD8", Offset = "0x116ECD8", VA = "0x116ECD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	[HideInInspector]
	public Texture2D LightFalloff
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x116ED44", Offset = "0x116ED44", VA = "0x116ED44")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x116EEDC", Offset = "0x116EEDC", VA = "0x116EEDC")]
		set
		{
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x116A108", Offset = "0x116A108", VA = "0x116A108")]
	private void SetUpRenderOrder()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x116A3B8", Offset = "0x116A3B8", VA = "0x116A3B8")]
	public static Material GetDirectionalMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x116A750", Offset = "0x116A750", VA = "0x116A750")]
	public static Material GetProjectorMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x116A8F0", Offset = "0x116A8F0", VA = "0x116A8F0")]
	public static Material GetSpotMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x116AA90", Offset = "0x116AA90", VA = "0x116AA90")]
	public static Material GetPointMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x116AC30", Offset = "0x116AC30", VA = "0x116AC30")]
	public TransparencyQualities compatibleTBuffer()
	{
		return default(TransparencyQualities);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x116ACFC", Offset = "0x116ACFC", VA = "0x116ACFC")]
	private bool IsRenderBoth()
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x116ADA8", Offset = "0x116ADA8", VA = "0x116ADA8")]
	private DensityParticleQualities compatibleDBuffer()
	{
		return default(DensityParticleQualities);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x116AE10", Offset = "0x116AE10", VA = "0x116AE10")]
	private void MyPreCull(Camera cam)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x116AFE8", Offset = "0x116AFE8", VA = "0x116AFE8")]
	public bool renderDensityParticleCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x116AFF8", Offset = "0x116AFF8", VA = "0x116AFF8")]
	private void WarmUp()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x116B38C", Offset = "0x116B38C", VA = "0x116B38C")]
	private void CreateShaderVariant(Shader source, int i, ref Material[] material, ref ShaderVariantCollection.ShaderVariant[] Variant, bool point = true)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x116A550", Offset = "0x116A550", VA = "0x116A550")]
	private static void CreateShader(Shader source, int i, out Material outMaterial, bool point = true)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x116B8E0", Offset = "0x116B8E0", VA = "0x116B8E0")]
	private void CreatePIDs()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x116E490", Offset = "0x116E490", VA = "0x116E490")]
	public static bool ActiveFull()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x116E510", Offset = "0x116E510", VA = "0x116E510")]
	private void DefineFull()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x116E514", Offset = "0x116E514", VA = "0x116E514")]
	private static void UpdateLight(HxOctreeNode<HxVolumetricLight>.NodeObject node, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x116E5E0", Offset = "0x116E5E0", VA = "0x116E5E0")]
	public static HxOctreeNode<HxVolumetricLight>.NodeObject AddLightOctree(HxVolumetricLight light, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x116E784", Offset = "0x116E784", VA = "0x116E784")]
	public static HxOctreeNode<HxVolumetricParticleSystem>.NodeObject AddParticleOctree(HxVolumetricParticleSystem particle, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x116E928", Offset = "0x116E928", VA = "0x116E928")]
	public static void RemoveLightOctree(HxVolumetricLight light)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x116E9E4", Offset = "0x116E9E4", VA = "0x116E9E4")]
	public static void RemoveParticletOctree(HxVolumetricParticleSystem Particle)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x116EAA0", Offset = "0x116EAA0", VA = "0x116EAA0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x116EAA8", Offset = "0x116EAA8", VA = "0x116EAA8")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x116EF48", Offset = "0x116EF48", VA = "0x116EF48")]
	private Vector4 CalculateDensityDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x116F17C", Offset = "0x116F17C", VA = "0x116F17C")]
	private Vector4 CalculateTransparencyDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x116F368", Offset = "0x116F368", VA = "0x116F368")]
	private void RenderParticles()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1170E58", Offset = "0x1170E58", VA = "0x1170E58")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x11703F0", Offset = "0x11703F0", VA = "0x11703F0")]
	private int RenderSlices()
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1170EA4", Offset = "0x1170EA4", VA = "0x1170EA4")]
	private int GetCamPixelHeight()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1170F5C", Offset = "0x1170F5C", VA = "0x1170F5C")]
	private int GetCamPixelWidth()
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1171054", Offset = "0x1171054", VA = "0x1171054")]
	private void CreateTempTextures()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x116F8A0", Offset = "0x116F8A0", VA = "0x116F8A0")]
	public static void ConstructPlanes(Camera cam, Transform camTransform, float near, float far)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1172494", Offset = "0x1172494", VA = "0x1172494")]
	private void FindActiveLights()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1170300", Offset = "0x1170300", VA = "0x1170300")]
	private void FindActiveParticleSystems()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x11727C4", Offset = "0x11727C4", VA = "0x11727C4")]
	public void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1172C38", Offset = "0x1172C38", VA = "0x1172C38")]
	private void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1172D18", Offset = "0x1172D18", VA = "0x1172D18")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1172DF8", Offset = "0x1172DF8", VA = "0x1172DF8")]
	private void CreateApplyBuffer()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1172DFC", Offset = "0x1172DFC", VA = "0x1172DFC")]
	private void CreateSetupBuffer()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x11732A4", Offset = "0x11732A4", VA = "0x11732A4")]
	private bool CheckBufferDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x11734A0", Offset = "0x11734A0", VA = "0x11734A0")]
	private void CreateFinalizeBuffer()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1176294", Offset = "0x1176294", VA = "0x1176294")]
	private void BuildBuffer()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1178424", Offset = "0x1178424", VA = "0x1178424")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1178BD8", Offset = "0x1178BD8", VA = "0x1178BD8")]
	private void SaveUsedShaderVarience()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1178BDC", Offset = "0x1178BDC", VA = "0x1178BDC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1177DC0", Offset = "0x1177DC0", VA = "0x1177DC0")]
	private void CalculateEvent()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1178ECC", Offset = "0x1178ECC", VA = "0x1178ECC")]
	public void EventOnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1178FAC", Offset = "0x1178FAC", VA = "0x1178FAC")]
	private int ScalePass()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1178FD0", Offset = "0x1178FD0", VA = "0x1178FD0")]
	private void DownSampledFullBlur(RenderTexture mainColor, RenderBuffer NewColor, RenderBuffer depth, int pass)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1177EA0", Offset = "0x1177EA0", VA = "0x1177EA0")]
	private void CheckTemporalTextures()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x117870C", Offset = "0x117870C", VA = "0x117870C")]
	public void ReleaseTempTextures()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1179170", Offset = "0x1179170", VA = "0x1179170")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x11795EC", Offset = "0x11795EC", VA = "0x11795EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1179238", Offset = "0x1179238", VA = "0x1179238")]
	private void UpdateLightPoistions()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x11794B8", Offset = "0x11794B8", VA = "0x11794B8")]
	private void UpdateParticlePoistions()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x117AAF8", Offset = "0x117AAF8", VA = "0x117AAF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x117AC28", Offset = "0x117AC28", VA = "0x117AC28")]
	private void start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x116AED8", Offset = "0x116AED8", VA = "0x116AED8")]
	public void ReleaseLightBuffers()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1178098", Offset = "0x1178098", VA = "0x1178098")]
	private void CreateLightbuffers()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x116CB04", Offset = "0x116CB04", VA = "0x116CB04")]
	private static void CreateTileTexture()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x116E1B8", Offset = "0x116E1B8", VA = "0x116E1B8")]
	public static Mesh CreateOrtho(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x116DB68", Offset = "0x116DB68", VA = "0x116DB68")]
	public static Mesh CreateCone(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x116CBC4", Offset = "0x116CBC4", VA = "0x116CBC4")]
	public static Mesh CreateQuad()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x116CDF0", Offset = "0x116CDF0", VA = "0x116CDF0")]
	public static Mesh CreateBox()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x116CECC", Offset = "0x116CECC", VA = "0x116CECC")]
	public static Mesh CreateIcoSphere(int recursionLevel, float radius)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x117AE6C", Offset = "0x117AE6C", VA = "0x117AE6C")]
	private static int getMiddlePoint(int p1, int p2, ref List<Vector3> vertices, ref Dictionary<long, int> cache, float radius)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x116C7B4", Offset = "0x116C7B4", VA = "0x116C7B4")]
	public void Create3DNoiseTexture()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x117B068", Offset = "0x117B068", VA = "0x117B068")]
	private int PostoIndex(Vector3 pos)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x117B0D8", Offset = "0x117B0D8", VA = "0x117B0D8")]
	public HxVolumetricCamera()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class HxVolumetricImageEffect : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x117BE10", Offset = "0x117BE10", VA = "0x117BE10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x117BEA4", Offset = "0x117BEA4", VA = "0x117BEA4")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x117BFD8", Offset = "0x117BFD8", VA = "0x117BFD8")]
	public HxVolumetricImageEffect()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
public class HxVolumetricImageEffectOpaque : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x117BFE0", Offset = "0x117BFE0", VA = "0x117BFE0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x117C078", Offset = "0x117C078", VA = "0x117C078")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x117C1AC", Offset = "0x117C1AC", VA = "0x117C1AC")]
	public HxVolumetricImageEffectOpaque()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class HxVolumetricLight : MonoBehaviour
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float ShadowDistanceExtra;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Light myLight;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HxDummyLight myDummyLight;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture3D NoiseTexture3D;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _transform;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CommandBuffer BufferRender;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CommandBuffer BufferCopy;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Projector myProjector;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 NoiseScale;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 NoiseVelocity;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool dirty;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture LightFalloff;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float NearPlane;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool NoiseEnabled;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool CustomMieScatter;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool CustomExtinction;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
	public bool CustomExtinctionEffect;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool CustomDensity;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool CustomSampleCount;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	public bool CustomColor;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	public bool CustomNoiseEnabled;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool CustomNoiseTexture;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	public bool CustomNoiseScale;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	public bool CustomNoiseVelocity;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
	public bool CustomNoiseContrast;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool CustomFogHeightEnabled;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool CustomFogHeight;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	public bool CustomFogTransitionSize;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
	public bool CustomAboveFogPercent;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool CustomSunSize;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	public bool CustomSunBleed;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
	public bool ShadowCasting;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8F")]
	public bool CustomStrength;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool CustomIntensity;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool CustomTintMode;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool CustomTintColor;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool CustomTintColor2;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool CustomTintGradient;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool CustomTintIntensity;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool CustomMaxLightDistance;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D25BC", Offset = "0x7D25BC")]
	public float NoiseContrast;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public HxVolumetricCamera.HxTintMode TintMode;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Color TintColor;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Color TintColor2;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float TintIntensity;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D25D4", Offset = "0x7D25D4")]
	public float TintGradient;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D25EC", Offset = "0x7D25EC")]
	public float Intensity;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2604", Offset = "0x7D2604")]
	public float Strength;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Color Color;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D261C", Offset = "0x7D261C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D261C", Offset = "0x7D261C")]
	public float MieScattering;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2674", Offset = "0x7D2674")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2674", Offset = "0x7D2674")]
	public float SunSize;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D26C8", Offset = "0x7D26C8")]
	public bool SunBleed;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2700", Offset = "0x7D2700")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2700", Offset = "0x7D2700")]
	public float Extinction;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2754", Offset = "0x7D2754")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2754", Offset = "0x7D2754")]
	public float Density;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D27A8", Offset = "0x7D27A8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D27A8", Offset = "0x7D27A8")]
	public float ExtraDensity;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D27FC", Offset = "0x7D27FC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D27FC", Offset = "0x7D27FC")]
	public int SampleCount;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D2854", Offset = "0x7D2854")]
	public bool Shadows;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
	public bool FogHeightEnabled;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float FogHeight;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float FogTransitionSize;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float MaxLightDistance;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float AboveFogPercent;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool OffsetUpdated;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public Vector3 Offset;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static MaterialPropertyBlock propertyBlock;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool bufferBuilt;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int VolumetricBMVPPID;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int VolumetricMVPPID;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static int VolumetricMVP2PID;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static int VolumetricMVPID;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int LightColourPID;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static int LightColour2PID;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int FogHeightsPID;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static int PhasePID;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int _LightParamsPID;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int DensityPID;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int ShadowBiasPID;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int _CustomLightPositionPID;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int hxNearPlanePID;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int NoiseScalePID;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int NoiseOffsetPID;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static int _SpotLightParamsPID;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static int _LightTexture0PID;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int _hxProjectorTexturePID;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static int _hxProjectorFalloffTexturePID;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	private bool LastBufferDirectional;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float LastSpotAngle;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private float LastRange;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private float LastAspect;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private LightType lastType;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Matrix4x4 LightMatrix;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private Bounds lastBounds;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private Vector3 minBounds;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Vector3 maxBounds;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private HxOctreeNode<HxVolumetricLight>.NodeObject octreeNode;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector4 TopFrustumNormal;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Vector4 BottomFrustumNormal;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Vector4 LeftFrustumNormal;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private Vector4 RightFrustumNormal;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Matrix4x4[] VolumeMatrixArrays;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Vector4[] VolumeSettingsArrays;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static Matrix4x4[] VolumeMatrixArraysOld;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static Vector4[] VolumeSettingsArraysOld;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private float LastOrthoSize;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private bool LastOrtho;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F5")]
	private bool matrixReconstruct;

	[Token(Token = "0x17000007")]
	public Transform myTransform
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x117C2E4", Offset = "0x117C2E4", VA = "0x117C2E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x117C374", Offset = "0x117C374", VA = "0x117C374")]
		set
		{
		}
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x117C1B4", Offset = "0x117C1B4", VA = "0x117C1B4")]
	public Light LightSafe()
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x117C24C", Offset = "0x117C24C", VA = "0x117C24C")]
	public HxDummyLight DummyLightSafe()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x117C37C", Offset = "0x117C37C", VA = "0x117C37C")]
	private LightType GetLightType()
	{
		return default(LightType);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x117C468", Offset = "0x117C468", VA = "0x117C468")]
	private LightShadows LightShadow()
	{
		return default(LightShadows);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x117C500", Offset = "0x117C500", VA = "0x117C500")]
	private bool HasLight()
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x117C5BC", Offset = "0x117C5BC", VA = "0x117C5BC")]
	private Texture LightCookie()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x117C6A8", Offset = "0x117C6A8", VA = "0x117C6A8")]
	private Texture LightFalloffTexture()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x117C764", Offset = "0x117C764", VA = "0x117C764")]
	private float LightShadowBias()
	{
		return default(float);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x117C808", Offset = "0x117C808", VA = "0x117C808")]
	private Color LightColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x117C9A8", Offset = "0x117C9A8", VA = "0x117C9A8")]
	private float LightSpotAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x117CAE0", Offset = "0x117CAE0", VA = "0x117CAE0")]
	private bool LightEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x117CCD0", Offset = "0x117CCD0", VA = "0x117CCD0")]
	private float LightRange()
	{
		return default(float);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x117CE08", Offset = "0x117CE08", VA = "0x117CE08")]
	private float LightShadowStrength()
	{
		return default(float);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x117CEA0", Offset = "0x117CEA0", VA = "0x117CEA0")]
	private float LightIntensity()
	{
		return default(float);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x117CFC4", Offset = "0x117CFC4", VA = "0x117CFC4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x117D16C", Offset = "0x117D16C", VA = "0x117D16C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x117D26C", Offset = "0x117D26C", VA = "0x117D26C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x117D360", Offset = "0x117D360", VA = "0x117D360")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x117AD50", Offset = "0x117AD50", VA = "0x117AD50")]
	public void BuildBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x117AC80", Offset = "0x117AC80", VA = "0x117AC80")]
	public void ReleaseBuffer()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x116C840", Offset = "0x116C840", VA = "0x116C840")]
	public static void CreatePID()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1182270", Offset = "0x1182270", VA = "0x1182270")]
	private float LightNearPlane()
	{
		return default(float);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x118230C", Offset = "0x118230C", VA = "0x118230C")]
	private int DirectionalPass(CommandBuffer buffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x11826B8", Offset = "0x11826B8", VA = "0x11826B8")]
	private float getContrast()
	{
		return default(float);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1182748", Offset = "0x1182748", VA = "0x1182748")]
	private bool ShaderModel4()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x117D3D0", Offset = "0x117D3D0", VA = "0x117D3D0")]
	private void BuildDirectionalBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1182CA8", Offset = "0x1182CA8", VA = "0x1182CA8")]
	private void LoadVolumeDateIntoBuffer(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1183600", Offset = "0x1183600", VA = "0x1183600")]
	private float CalcLightInstensityDistance(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x117E6D8", Offset = "0x117E6D8", VA = "0x117E6D8")]
	private void BuildSpotLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1180F60", Offset = "0x1180F60", VA = "0x1180F60")]
	private void BuildProjectorLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1183D0C", Offset = "0x1183D0C", VA = "0x1183D0C")]
	private void SetColors(CommandBuffer buffer, float distanceLerp)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1182D58", Offset = "0x1182D58", VA = "0x1182D58")]
	private void SetColors(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x11847D4", Offset = "0x11847D4", VA = "0x11847D4")]
	private Vector3 CalcTintColor(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1184A80", Offset = "0x1184A80", VA = "0x1184A80")]
	private Vector3 CalcTintColorEdge(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x117FB74", Offset = "0x117FB74", VA = "0x117FB74")]
	private void BuildPointBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1183368", Offset = "0x1183368", VA = "0x1183368")]
	public int MID(bool RenderShadows, bool full)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1184D2C", Offset = "0x1184D2C", VA = "0x1184D2C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1182750", Offset = "0x1182750", VA = "0x1182750")]
	private float GetFogDensity()
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1183540", Offset = "0x1183540", VA = "0x1183540")]
	private Texture3D GetNoiseTexture()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x118326C", Offset = "0x118326C", VA = "0x118326C")]
	private int GetSampleCount(bool RenderShadows)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1184D34", Offset = "0x1184D34", VA = "0x1184D34")]
	public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1183714", Offset = "0x1183714", VA = "0x1183714")]
	private float ClosestDistanceToCone(Vector3 Point)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1184F20", Offset = "0x1184F20", VA = "0x1184F20")]
	private void UpdateLightMatrix()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x11853A4", Offset = "0x11853A4", VA = "0x11853A4")]
	private void CheckLightType()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x11827E8", Offset = "0x11827E8", VA = "0x11827E8")]
	private void LoadVolumeData()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x118551C", Offset = "0x118551C", VA = "0x118551C")]
	private bool BoundsIntersect(HxDensityVolume vol)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x11842B4", Offset = "0x11842B4", VA = "0x11842B4")]
	private void LoadVolumeDataBounds()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x118559C", Offset = "0x118559C", VA = "0x118559C")]
	private Vector4 NormalOfTriangle(Vector3 a, Vector3 b, Vector3 c)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x11856F0", Offset = "0x11856F0", VA = "0x11856F0")]
	private void DrawIntersect()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1186200", Offset = "0x1186200", VA = "0x1186200")]
	private float GetAspect()
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1186298", Offset = "0x1186298", VA = "0x1186298")]
	private float GetOrthoSize()
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1186330", Offset = "0x1186330", VA = "0x1186330")]
	private bool GetOrtho()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1179684", Offset = "0x1179684", VA = "0x1179684")]
	public void UpdatePosition(bool first = false)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x11863C8", Offset = "0x11863C8", VA = "0x11863C8")]
	public void DrawBounds()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x11869F8", Offset = "0x11869F8", VA = "0x11869F8")]
	public HxVolumetricLight()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
public class HxVolumetricParticleSystem : MonoBehaviour
{
	[Token(Token = "0x2000046")]
	public enum ParticleBlendMode
	{
		[Token(Token = "0x4000375")]
		Max,
		[Token(Token = "0x4000376")]
		Add,
		[Token(Token = "0x4000377")]
		Min,
		[Token(Token = "0x4000378")]
		Sub
	}

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D288C", Offset = "0x7D288C")]
	public float DensityStrength;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HxOctreeNode<HxVolumetricParticleSystem>.NodeObject octreeNode;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Renderer particleRenderer;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleBlendMode BlendMode;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 minBounds;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 maxBounds;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Bounds LastBounds;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1450F30", Offset = "0x1450F30", VA = "0x1450F30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1451048", Offset = "0x1451048", VA = "0x1451048")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1451168", Offset = "0x1451168", VA = "0x1451168")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1451208", Offset = "0x1451208", VA = "0x1451208")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x14512A8", Offset = "0x14512A8", VA = "0x14512A8")]
	public HxVolumetricParticleSystem()
	{
	}
}
[Token(Token = "0x200000C")]
public class HxVolumetricRenderCallback : MonoBehaviour
{
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HxVolumetricCamera volumetricCamera;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public HxVolumetricCamera.hxRenderOrder RenderOrder;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x14512C0", Offset = "0x14512C0", VA = "0x14512C0")]
	public HxVolumetricRenderCallback()
	{
	}
}
[Token(Token = "0x200000D")]
public class HxVolumetricShadersUsed : ScriptableObject
{
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HxVolumetricCamera.TransparencyQualities TransperencyQuality;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public HxVolumetricCamera.DensityParticleQualities DensityParticleQuality;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public HxVolumetricCamera.DensityParticleQualities LastDensityParticleQuality;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public HxVolumetricCamera.TransparencyQualities LastTransperencyQuality;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HxVolumetricShadersUsed instance;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Full;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool LowRes;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool HeightFog;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool HeightFogOff;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool Noise;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool NoiseOff;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool Transparency;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool TransparencyOff;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool DensityParticles;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool Point;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool Spot;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool Directional;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool SinglePassStereo;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool Projector;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[HideInInspector]
	public bool FullLast;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	[HideInInspector]
	public bool LowResLast;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool HeightFogLast;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[HideInInspector]
	public bool HeightFogOffLast;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[HideInInspector]
	public bool NoiseLast;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	[HideInInspector]
	public bool NoiseOffLast;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool TransparencyLast;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool TransparencyOffLast;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[HideInInspector]
	public bool DensityParticlesLast;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	[HideInInspector]
	public bool PointLast;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool SpotLast;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[HideInInspector]
	public bool DirectionalLast;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[HideInInspector]
	public bool SinglePassStereoLast;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	[HideInInspector]
	public bool ProjectorLast;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x14512C8", Offset = "0x14512C8", VA = "0x14512C8")]
	private bool CheckDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x14515E4", Offset = "0x14515E4", VA = "0x14515E4")]
	public HxVolumetricShadersUsed()
	{
	}
}
[Token(Token = "0x200000E")]
public class RFX4_ShaderColorGradient : MonoBehaviour
{
	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFX4_ShaderProperties ShaderColorProperty;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Gradient Color;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float TimeMultiplier;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool IsLoop;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool UseSharedMaterial;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float HUE;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool canUpdate;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material mat;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int propertyID;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float startTime;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color startColor;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isInitialized;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string shaderProperty;

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1453730", Offset = "0x1453730", VA = "0x1453730")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1453734", Offset = "0x1453734", VA = "0x1453734")]
	private void Init()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1453A64", Offset = "0x1453A64", VA = "0x1453A64")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1453A9C", Offset = "0x1453A9C", VA = "0x1453A9C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1453C7C", Offset = "0x1453C7C", VA = "0x1453C7C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1453D40", Offset = "0x1453D40", VA = "0x1453D40")]
	public RFX4_ShaderColorGradient()
	{
	}
}
[Token(Token = "0x200000F")]
public class RFX4_ShaderFloatCurve : MonoBehaviour
{
	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFX4_ShaderProperties ShaderFloatProperty;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve FloatCurve;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsLoop;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool UseSharedMaterial;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool canUpdate;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float startTime;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material mat;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float startFloat;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int propertyID;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string shaderProperty;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isInitialized;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1453DB8", Offset = "0x1453DB8", VA = "0x1453DB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x145405C", Offset = "0x145405C", VA = "0x145405C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x14540D0", Offset = "0x14540D0", VA = "0x14540D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1454178", Offset = "0x1454178", VA = "0x1454178")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x14541B0", Offset = "0x14541B0", VA = "0x14541B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1454264", Offset = "0x1454264", VA = "0x1454264")]
	public RFX4_ShaderFloatCurve()
	{
	}
}
[Token(Token = "0x2000010")]
public enum RFX4_ShaderProperties
{
	[Token(Token = "0x40001B5")]
	_TintColor,
	[Token(Token = "0x40001B6")]
	_Cutoff,
	[Token(Token = "0x40001B7")]
	_Color,
	[Token(Token = "0x40001B8")]
	_EmissionColor,
	[Token(Token = "0x40001B9")]
	_MaskPow,
	[Token(Token = "0x40001BA")]
	_Cutout,
	[Token(Token = "0x40001BB")]
	_Speed,
	[Token(Token = "0x40001BC")]
	_BumpAmt
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D16D8", Offset = "0x7D16D8")]
public class RFX4_ParticleTrail : MonoBehaviour
{
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Target;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 DefaultSizeMultiplayer;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float VertexLifeTime;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float TrailLifeTime;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool UseShaderMaterial;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material TrailMaterial;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool UseColorOverLifeTime;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Gradient ColorOverLifeTime;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float ColorLifeTime;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool UseUvAnimation;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int TilesX;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int TilesY;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int FPS;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool IsLoop;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D29E4", Offset = "0x7D29E4")]
	public float MinVertexDistance;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool GetVelocityFromParticleSystem;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float Gravity;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Vector3 Force;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float InheritVelocity;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float Drag;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2A00", Offset = "0x7D2A00")]
	public float Frequency;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2A1C", Offset = "0x7D2A1C")]
	public float OffsetSpeed;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool RandomTurbulenceOffset;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2A38", Offset = "0x7D2A38")]
	public float Amplitude;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float TurbulenceStrength;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public AnimationCurve VelocityByDistance;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float AproximatedFlyDistance;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool SmoothCurves;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Dictionary<int, LineRenderer> dict;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ParticleSystem ps;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private TrailRenderer[] trails;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Color psColor;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Transform targetT;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int layer;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool isLocalSpace;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Transform t;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x14527AC", Offset = "0x14527AC", VA = "0x14527AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1453104", Offset = "0x1453104", VA = "0x1453104")]
	private void ClearTrails()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1452984", Offset = "0x1452984", VA = "0x1452984")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x145331C", Offset = "0x145331C", VA = "0x145331C")]
	private void InitTrailRenderer(GameObject go)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1453218", Offset = "0x1453218", VA = "0x1453218")]
	private void RemoveEmptyTrails()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x145340C", Offset = "0x145340C", VA = "0x145340C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x14535A0", Offset = "0x14535A0", VA = "0x14535A0")]
	public RFX4_ParticleTrail()
	{
	}
}
[Token(Token = "0x2000012")]
public static class RFX4_ColorHelper
{
	[Token(Token = "0x2000047")]
	public struct HSBColor
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float H;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float S;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float B;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float A;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x890724", Offset = "0x890724", VA = "0x890724")]
		public HSBColor(float h, float s, float b, float a)
		{
		}
	}

	[Token(Token = "0x40001E2")]
	private const float TOLERANCE = 0.0001f;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string[] colorProperties;

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x14515F8", Offset = "0x14515F8", VA = "0x14515F8")]
	public static HSBColor ColorToHSV(Color color)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x14517F8", Offset = "0x14517F8", VA = "0x14517F8")]
	public static Color HSVToColor(HSBColor hsbColor)
	{
		return default(Color);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1451A6C", Offset = "0x1451A6C", VA = "0x1451A6C")]
	public static Color ConvertRGBColorByHUE(Color rgbColor, float hue)
	{
		return default(Color);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1451B8C", Offset = "0x1451B8C", VA = "0x1451B8C")]
	public static void ChangeObjectColorByHUE(GameObject go, float hue)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x145244C", Offset = "0x145244C", VA = "0x145244C")]
	private static Material setMatHUEColor(Material mat, string name, float hueColor)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x145252C", Offset = "0x145252C", VA = "0x145252C")]
	private static Material setMatAlphaColor(Material mat, string name, float alpha)
	{
		return null;
	}
}
[Token(Token = "0x2000013")]
public enum RFX4_TextureShaderProperties
{
	[Token(Token = "0x40001E5")]
	_MainTex,
	[Token(Token = "0x40001E6")]
	_DistortTex,
	[Token(Token = "0x40001E7")]
	_Mask,
	[Token(Token = "0x40001E8")]
	_Cutout,
	[Token(Token = "0x40001E9")]
	_CutoutTex,
	[Token(Token = "0x40001EA")]
	_Bump,
	[Token(Token = "0x40001EB")]
	_BumpTex,
	[Token(Token = "0x40001EC")]
	_EmissionTex
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D173C", Offset = "0x7D173C")]
public class RFX4_TrailRenderer : MonoBehaviour
{
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float VertexLifeTime;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float TrailLifeTime;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2A54", Offset = "0x7D2A54")]
	public float MinVertexDistance;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Gravity;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 Force;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float InheritVelocity;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float Drag;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2A70", Offset = "0x7D2A70")]
	public float Frequency;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2A8C", Offset = "0x7D2A8C")]
	public float OffsetSpeed;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool RandomTurbulenceOffset;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2AA8", Offset = "0x7D2AA8")]
	public float Amplitude;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float TurbulenceStrength;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve VelocityByDistance;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float AproximatedFlyDistance;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool SmoothCurves;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<Vector3> positions;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<float> currentTimes;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Vector3> velocities;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float currentLifeTime;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform t;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 prevPosition;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 startPosition;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Vector3> controlPoints;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int curveCount;

	[Token(Token = "0x4000206")]
	private const float MinimumSqrDistance = 0.01f;

	[Token(Token = "0x4000207")]
	private const float DivisionThreshold = -0.99f;

	[Token(Token = "0x4000208")]
	private const float SmoothCurvesScale = 0.5f;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float currentVelocity;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float turbulenceRandomOffset;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool isInitialized;

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x14542B0", Offset = "0x14542B0", VA = "0x14542B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x14544F0", Offset = "0x14544F0", VA = "0x14544F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x14542D8", Offset = "0x14542D8", VA = "0x14542D8")]
	private void Init()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1454500", Offset = "0x1454500", VA = "0x1454500")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1455344", Offset = "0x1455344", VA = "0x1455344")]
	private int GetLastDeletedIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1454620", Offset = "0x1454620", VA = "0x1454620")]
	private void UpdatePositionsCount()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1455B94", Offset = "0x1455B94", VA = "0x1455B94")]
	private void AddInterpolatedPositions(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1455454", Offset = "0x1455454", VA = "0x1455454")]
	private void RemovePositionsBeforeIndex(int lastDeletedIndex)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1454808", Offset = "0x1454808", VA = "0x1454808")]
	private void UpdateForce()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1454E00", Offset = "0x1454E00", VA = "0x1454E00")]
	private void UpdateImpulse()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1455024", Offset = "0x1455024", VA = "0x1455024")]
	private void UpdateVelocity()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1455564", Offset = "0x1455564", VA = "0x1455564")]
	public void InterpolateBezier(List<Vector3> segmentPoints, float scale)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1455AA8", Offset = "0x1455AA8", VA = "0x1455AA8")]
	public List<Vector3> GetDrawingPoints()
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1455DA8", Offset = "0x1455DA8", VA = "0x1455DA8")]
	private List<Vector3> FindDrawingPoints(int curveIndex)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1456084", Offset = "0x1456084", VA = "0x1456084")]
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector3> pointList, int insertionIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1455ECC", Offset = "0x1455ECC", VA = "0x1455ECC")]
	public Vector3 CalculateBezierPoint(int curveIndex, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x145635C", Offset = "0x145635C", VA = "0x145635C")]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1456524", Offset = "0x1456524", VA = "0x1456524")]
	public RFX4_TrailRenderer()
	{
	}
}
[Token(Token = "0x2000015")]
public class RFX4_UVAnimation : MonoBehaviour
{
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TilesX;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int TilesY;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int FPS;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int StartFrameOffset;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float StartDelay;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsReverse;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool IsInterpolateFrames;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFX4_TextureShaderProperties[] TextureNames;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve FrameOverTime;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int count;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Renderer currentRenderer;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Projector projector;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material instanceMaterial;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float animationStartTime;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool canUpdate;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int previousIndex;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int totalFrames;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float currentInterpolatedTime;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int currentIndex;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector2 size;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isInitialized;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1456628", Offset = "0x1456628", VA = "0x1456628")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x14568C0", Offset = "0x14568C0", VA = "0x14568C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x14568E8", Offset = "0x14568E8", VA = "0x14568E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1456638", Offset = "0x1456638", VA = "0x1456638")]
	private void InitDefaultVariables()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1456ED4", Offset = "0x1456ED4", VA = "0x1456ED4")]
	private void InitializeMaterial()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1456934", Offset = "0x1456934", VA = "0x1456934")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1456AE0", Offset = "0x1456AE0", VA = "0x1456AE0")]
	private void SetSpriteAnimation()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1456D38", Offset = "0x1456D38", VA = "0x1456D38")]
	private void SetSpriteAnimationIterpolated()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x14570B0", Offset = "0x14570B0", VA = "0x14570B0")]
	public RFX4_UVAnimation()
	{
	}
}
namespace VLB
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7D17A0", Offset = "0x7D17A0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D17A0", Offset = "0x7D17A0")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D1C70", Offset = "0x7D1C70")]
		private sealed class <CoUpdateFadeOut>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x145B774", Offset = "0x145B774", VA = "0x145B774", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x145B7E0", Offset = "0x145B7E0", VA = "0x145B7E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1457420", Offset = "0x1457420", VA = "0x1457420")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x145B6F8", Offset = "0x145B6F8", VA = "0x145B6F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x145B6FC", Offset = "0x145B6FC", VA = "0x145B6FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x145B77C", Offset = "0x145B77C", VA = "0x145B77C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D2AD4", Offset = "0x7D2AD4")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D2AE4", Offset = "0x7D2AE4")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D2AF4", Offset = "0x7D2AF4")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DynamicOcclusion _dynamicOcclusion;

		[Token(Token = "0x17000008")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1457144", Offset = "0x1457144", VA = "0x1457144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3274", Offset = "0x7D3274")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x145714C", Offset = "0x145714C", VA = "0x145714C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3284", Offset = "0x7D3284")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1457154", Offset = "0x1457154", VA = "0x1457154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3294", Offset = "0x7D3294")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x145715C", Offset = "0x145715C", VA = "0x145715C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D32A4", Offset = "0x7D32A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1457164", Offset = "0x1457164", VA = "0x1457164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D32B4", Offset = "0x7D32B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x145716C", Offset = "0x145716C", VA = "0x145716C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D32C4", Offset = "0x7D32C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool visible
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1457174", Offset = "0x1457174", VA = "0x1457174")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1457190", Offset = "0x1457190", VA = "0x1457190")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x14571B0", Offset = "0x14571B0", VA = "0x14571B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x14571CC", Offset = "0x14571CC", VA = "0x14571CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int sortingOrder
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x14571E8", Offset = "0x14571E8", VA = "0x14571E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1457204", Offset = "0x1457204", VA = "0x1457204")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1457C90", Offset = "0x1457C90", VA = "0x1457C90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1459D60", Offset = "0x1459D60", VA = "0x1459D60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1459F54", Offset = "0x1459F54", VA = "0x1459F54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x145A028", Offset = "0x145A028", VA = "0x145A028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public DynamicOcclusion dynamicOcclusion
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x145AFC0", Offset = "0x145AFC0", VA = "0x145AFC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x145AFC8", Offset = "0x145AFC8", VA = "0x145AFC8")]
			set
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1457220", Offset = "0x1457220", VA = "0x1457220")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x14573AC", Offset = "0x14573AC", VA = "0x14573AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D32D4", Offset = "0x7D32D4")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x145744C", Offset = "0x145744C", VA = "0x145744C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1457638", Offset = "0x1457638", VA = "0x1457638")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x145794C", Offset = "0x145794C", VA = "0x145794C")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1457A08", Offset = "0x1457A08", VA = "0x1457A08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1457AC8", Offset = "0x1457AC8", VA = "0x1457AC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1457B70", Offset = "0x1457B70", VA = "0x1457B70")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1457C00", Offset = "0x1457C00", VA = "0x1457C00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1457C98", Offset = "0x1457C98", VA = "0x1457C98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1457D30", Offset = "0x1457D30", VA = "0x1457D30")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x145858C", Offset = "0x145858C", VA = "0x145858C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1459BF4", Offset = "0x1459BF4", VA = "0x1459BF4")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1458274", Offset = "0x1458274", VA = "0x1458274")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1457790", Offset = "0x1457790", VA = "0x1457790")]
		private void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x145A660", Offset = "0x145A660", VA = "0x145A660")]
		private void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x145A784", Offset = "0x145A784", VA = "0x145A784")]
		private void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x145A8A8", Offset = "0x145A8A8", VA = "0x145A8A8")]
		private void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x14576C8", Offset = "0x14576C8", VA = "0x14576C8")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1457884", Offset = "0x1457884", VA = "0x1457884")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x145A9F4", Offset = "0x145A9F4", VA = "0x145A9F4")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x145949C", Offset = "0x145949C", VA = "0x145949C")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x145B10C", Offset = "0x145B10C", VA = "0x145B10C")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x145B4AC", Offset = "0x145B4AC", VA = "0x145B4AC")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x145B54C", Offset = "0x145B54C", VA = "0x145B54C")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x145B114", Offset = "0x145B114", VA = "0x145B114")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x145B6F0", Offset = "0x145B6F0", VA = "0x145B6F0")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D1810", Offset = "0x7D1810")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D2B04", Offset = "0x7D2B04")]
		public bool forceSinglePass;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2B74", Offset = "0x7D2B74")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2B74", Offset = "0x7D2B74")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int sharedMeshSides;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2BF4", Offset = "0x7D2BF4")]
		public float globalNoiseScale;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int noise3DSize;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400023D")]
		private const string kAssetName = "Config";

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000013")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x14580D0", Offset = "0x14580D0", VA = "0x14580D0")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000014")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1458878", Offset = "0x1458878", VA = "0x1458878")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public Shader beamShader
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x145B7E8", Offset = "0x145B7E8", VA = "0x145B7E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x145B804", Offset = "0x145B804", VA = "0x145B804")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000017")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x14575B4", Offset = "0x14575B4", VA = "0x14575B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public static Config Instance
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1457554", Offset = "0x1457554", VA = "0x1457554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x145B83C", Offset = "0x145B83C", VA = "0x145B83C")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x145B8DC", Offset = "0x145B8DC", VA = "0x145B8DC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7D3338", Offset = "0x7D3338")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x145B954", Offset = "0x145B954", VA = "0x145B954")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x145B9F0", Offset = "0x145B9F0", VA = "0x145B9F0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x145BBB0", Offset = "0x145BBB0", VA = "0x145BBB0")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x145BD50", Offset = "0x145BD50", VA = "0x145BD50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x145BD80", Offset = "0x145BD80", VA = "0x145BD80")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x145BE24", Offset = "0x145BE24", VA = "0x145BE24")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x145BF9C", Offset = "0x145BF9C", VA = "0x145BF9C")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D1848", Offset = "0x7D1848")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400023F")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x145C078", Offset = "0x145C078", VA = "0x145C078")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class Consts
	{
		[Token(Token = "0x4000240")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000241")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000242")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000243")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x4000244")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000245")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000248")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000249")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x400024A")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x400024B")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x400024C")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x400024D")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x400024E")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x400024F")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000250")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000251")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000252")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000253")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000254")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000255")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000256")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000257")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000258")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000259")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x400025A")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x400025B")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x400025C")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x400025D")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x400025E")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x400025F")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000260")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000261")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000262")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000263")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x4000264")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000265")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000266")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x4000267")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000268")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000269")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x400026B")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x400026C")]
		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x400026E")]
		public const bool DynOcclusionConsiderTriggersDefault = false;

		[Token(Token = "0x400026F")]
		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		[Token(Token = "0x4000270")]
		public const int DynOcclusionWaitFrameCountDefault = 3;

		[Token(Token = "0x4000271")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000272")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000273")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000274")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000275")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000276")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000277")]
		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x4000278")]
		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000279")]
		public const float DynOcclusionFadeDistanceToPlaneDefault = 0.25f;

		[Token(Token = "0x400027A")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x400027B")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x400027C")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400027D")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x400027E")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400027F")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x4000280")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x4000281")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000282")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000283")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x17000019")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x145805C", Offset = "0x145805C", VA = "0x145805C")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D1880", Offset = "0x7D1880")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D1880", Offset = "0x7D1880")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public class HitResult
		{
			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000047")]
			public bool hasCollider
			{
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x145D4A0", Offset = "0x145D4A0", VA = "0x145D4A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000048")]
			public string name
			{
				[Token(Token = "0x6000203")]
				[Address(RVA = "0x145DA44", Offset = "0x145DA44", VA = "0x145DA44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000049")]
			public Bounds bounds
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0x145DB20", Offset = "0x145DB20", VA = "0x145DB20")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x145CFA4", Offset = "0x145CFA4", VA = "0x145CFA4")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x145D0A8", Offset = "0x145D0A8", VA = "0x145D0A8")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x145D014", Offset = "0x145D014", VA = "0x145D014")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x200004A")]
		private enum Direction
		{
			[Token(Token = "0x4000386")]
			Up,
			[Token(Token = "0x4000387")]
			Right,
			[Token(Token = "0x4000388")]
			Down,
			[Token(Token = "0x4000389")]
			Left
		}

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool considerTriggers;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minOccluderArea;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int waitFrameCount;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float minSurfaceRatio;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxSurfaceDot;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float planeOffset;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float fadeDistanceToPlane;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D2C40", Offset = "0x7D2C40")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_FrameCountToWait;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D2C50", Offset = "0x7D2C50")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001A")]
		public HitResult currentHit
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x145C1AC", Offset = "0x145C1AC", VA = "0x145C1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3348", Offset = "0x7D3348")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x145C1B4", Offset = "0x145C1B4", VA = "0x145C1B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3358", Offset = "0x7D3358")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x145C1BC", Offset = "0x145C1BC", VA = "0x145C1BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3368", Offset = "0x7D3368")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x145C1C8", Offset = "0x145C1C8", VA = "0x145C1C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3378", Offset = "0x7D3378")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x145C924", Offset = "0x145C924", VA = "0x145C924")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x145C938", Offset = "0x145C938", VA = "0x145C938")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x145C1D4", Offset = "0x145C1D4", VA = "0x145C1D4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x145C280", Offset = "0x145C280", VA = "0x145C280")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x145C2D8", Offset = "0x145C2D8", VA = "0x145C2D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x145C320", Offset = "0x145C320", VA = "0x145C320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x145C404", Offset = "0x145C404", VA = "0x145C404")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x145C828", Offset = "0x145C828", VA = "0x145C828")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x145C984", Offset = "0x145C984", VA = "0x145C984")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x145C998", Offset = "0x145C998", VA = "0x145C998")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x145CBFC", Offset = "0x145CBFC", VA = "0x145CBFC")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x145D190", Offset = "0x145D190", VA = "0x145D190")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x145D390", Offset = "0x145D390", VA = "0x145D390")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x145C444", Offset = "0x145C444", VA = "0x145C444")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x145D554", Offset = "0x145D554", VA = "0x145D554")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x145C2FC", Offset = "0x145C2FC", VA = "0x145C2FC")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x145D66C", Offset = "0x145D66C", VA = "0x145D66C")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x145D7B0", Offset = "0x145D7B0", VA = "0x145D7B0")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x145D8F4", Offset = "0x145D8F4", VA = "0x145D8F4")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x145D9A0", Offset = "0x145D9A0", VA = "0x145D9A0")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public enum ColorMode
	{
		[Token(Token = "0x4000295")]
		Flat,
		[Token(Token = "0x4000296")]
		Gradient
	}
	[Token(Token = "0x200001C")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000298")]
		Linear,
		[Token(Token = "0x4000299")]
		Quadratic,
		[Token(Token = "0x400029A")]
		Blend
	}
	[Token(Token = "0x200001D")]
	public enum BlendingMode
	{
		[Token(Token = "0x400029C")]
		Additive,
		[Token(Token = "0x400029D")]
		SoftAdditive,
		[Token(Token = "0x400029E")]
		TraditionalTransparency
	}
	[Token(Token = "0x200001E")]
	public enum NoiseMode
	{
		[Token(Token = "0x40002A0")]
		Disabled,
		[Token(Token = "0x40002A1")]
		WorldSpace,
		[Token(Token = "0x40002A2")]
		LocalSpace
	}
	[Token(Token = "0x200001F")]
	public enum MeshType
	{
		[Token(Token = "0x40002A4")]
		Shared,
		[Token(Token = "0x40002A5")]
		Custom
	}
	[Token(Token = "0x2000020")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40002A7")]
		BuiltIn,
		[Token(Token = "0x40002A8")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x2000021")]
	public enum RenderingMode
	{
		[Token(Token = "0x40002AA")]
		MultiPass,
		[Token(Token = "0x40002AB")]
		SinglePass,
		[Token(Token = "0x40002AC")]
		GPUInstancing
	}
	[Token(Token = "0x2000022")]
	public enum RenderQueue
	{
		[Token(Token = "0x40002AE")]
		Custom = 0,
		[Token(Token = "0x40002AF")]
		Background = 1000,
		[Token(Token = "0x40002B0")]
		Geometry = 2000,
		[Token(Token = "0x40002B1")]
		AlphaTest = 2450,
		[Token(Token = "0x40002B2")]
		GeometryLast = 2500,
		[Token(Token = "0x40002B3")]
		Transparent = 3000,
		[Token(Token = "0x40002B4")]
		Overlay = 4000
	}
	[Token(Token = "0x2000023")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x40002B6")]
		Occluders3D,
		[Token(Token = "0x40002B7")]
		Occluders2D
	}
	[Token(Token = "0x2000024")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40002B9")]
		Surface,
		[Token(Token = "0x40002BA")]
		Beam
	}
	[Token(Token = "0x2000025")]
	public enum FadeOutCameraMode
	{
		[Token(Token = "0x40002BC")]
		MainCamera,
		[Token(Token = "0x40002BD")]
		CustomObject
	}
	[Token(Token = "0x2000026")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1459284", Offset = "0x1459284", VA = "0x1459284")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x145DC18", Offset = "0x145DC18", VA = "0x145DC18")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class GpuInstancing
	{
		[Token(Token = "0x40002C0")]
		public const bool isSupported = true;

		[Token(Token = "0x1700001E")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x145A070", Offset = "0x145A070", VA = "0x145A070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x145DD1C", Offset = "0x145DD1C", VA = "0x145DD1C")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x145DDBC", Offset = "0x145DDBC", VA = "0x145DDBC")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x145DF0C", Offset = "0x145DF0C", VA = "0x145DF0C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x145E034", Offset = "0x145E034", VA = "0x145E034")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x145E0E0", Offset = "0x145E0E0", VA = "0x145E0E0")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x40002C1")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x145E0E8", Offset = "0x145E0E8", VA = "0x145E0E8")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class MaterialManager
	{
		[Token(Token = "0x200004B")]
		public enum BlendingMode
		{
			[Token(Token = "0x400038B")]
			Additive,
			[Token(Token = "0x400038C")]
			SoftAdditive,
			[Token(Token = "0x400038D")]
			TraditionalTransparency,
			[Token(Token = "0x400038E")]
			Count
		}

		[Token(Token = "0x200004C")]
		public enum Noise3D
		{
			[Token(Token = "0x4000390")]
			Off,
			[Token(Token = "0x4000391")]
			On,
			[Token(Token = "0x4000392")]
			Count
		}

		[Token(Token = "0x200004D")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000394")]
			Off,
			[Token(Token = "0x4000395")]
			On,
			[Token(Token = "0x4000396")]
			Count
		}

		[Token(Token = "0x200004E")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000398")]
			Off,
			[Token(Token = "0x4000399")]
			MatrixLow,
			[Token(Token = "0x400039A")]
			MatrixHigh,
			[Token(Token = "0x400039B")]
			Count
		}

		[Token(Token = "0x200004F")]
		public enum ClippingPlane
		{
			[Token(Token = "0x400039D")]
			Off,
			[Token(Token = "0x400039E")]
			On,
			[Token(Token = "0x400039F")]
			Count
		}

		[Token(Token = "0x2000050")]
		public class StaticProperties
		{
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ClippingPlane clippingPlane;

			[Token(Token = "0x1700004A")]
			public int materialID
			{
				[Token(Token = "0x6000205")]
				[Address(RVA = "0x145E178", Offset = "0x145E178", VA = "0x145E178")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x145A1BC", Offset = "0x145A1BC", VA = "0x145A1BC")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x145A1B4", Offset = "0x145A1B4", VA = "0x145A1B4")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000051")]
		private class MaterialsGroup
		{
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x6000208")]
			[Address(RVA = "0x145E0F0", Offset = "0x145E0F0", VA = "0x145E0F0")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x14580D8", Offset = "0x14580D8", VA = "0x14580D8")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x145A3C4", Offset = "0x145A3C4", VA = "0x145A3C4")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40002C8")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x145E304", Offset = "0x145E304", VA = "0x145E304")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x145E31C", Offset = "0x145E31C", VA = "0x145E31C")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x145E3E8", Offset = "0x145E3E8", VA = "0x145E3E8")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1458888", Offset = "0x1458888", VA = "0x1458888")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x145E3FC", Offset = "0x145E3FC", VA = "0x145E3FC")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x145E418", Offset = "0x145E418", VA = "0x145E418")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x145E440", Offset = "0x145E440", VA = "0x145E440")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x145E4DC", Offset = "0x145E4DC", VA = "0x145E4DC")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002C")]
	public static class Noise3D
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40002CC")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40002CD")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700001F")]
		public static bool isSupported
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1459E04", Offset = "0x1459E04", VA = "0x1459E04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x145E61C", Offset = "0x145E61C", VA = "0x145E61C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x145E57C", Offset = "0x145E57C", VA = "0x145E57C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x145E6B4", Offset = "0x145E6B4", VA = "0x145E6B4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7D3388", Offset = "0x7D3388")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x145ADA0", Offset = "0x145ADA0", VA = "0x145ADA0")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x145E710", Offset = "0x145E710", VA = "0x145E710")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;
	}
	[Token(Token = "0x200002E")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D1928", Offset = "0x7D1928")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D1928", Offset = "0x7D1928")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40002E9")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x145EDC0", Offset = "0x145EDC0", VA = "0x145EDC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x145EFE4", Offset = "0x145EFE4", VA = "0x145EFE4")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public static class Utils
	{
		[Token(Token = "0x2000052")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40003A7")]
			High = 64,
			[Token(Token = "0x40003A8")]
			Low = 8,
			[Token(Token = "0x40003A9")]
			Undef = 0
		}

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40002EC")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x145EFFC", Offset = "0x145EFFC", VA = "0x145EFFC")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1458464", Offset = "0x1458464", VA = "0x1458464")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x145F084", Offset = "0x145F084", VA = "0x145F084")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x145F16C", Offset = "0x145F16C", VA = "0x145F16C")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x145F198", Offset = "0x145F198", VA = "0x145F198")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x145F1C8", Offset = "0x145F1C8", VA = "0x145F1C8")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x145F1FC", Offset = "0x145F1FC", VA = "0x145F1FC")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x145F234", Offset = "0x145F234", VA = "0x145F234")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x145F268", Offset = "0x145F268", VA = "0x145F268")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x145F298", Offset = "0x145F298", VA = "0x145F298")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x145CEB8", Offset = "0x145CEB8", VA = "0x145CEB8")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x145F2EC", Offset = "0x145F2EC", VA = "0x145F2EC")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x145F320", Offset = "0x145F320", VA = "0x145F320")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x145D7D4", Offset = "0x145D7D4", VA = "0x145D7D4")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x145F728", Offset = "0x145F728", VA = "0x145F728")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x145B0E8", Offset = "0x145B0E8", VA = "0x145B0E8")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x145B9DC", Offset = "0x145B9DC", VA = "0x145B9DC")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x145AC24", Offset = "0x145AC24", VA = "0x145AC24")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x145F870", Offset = "0x145F870", VA = "0x145F870")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x145F980", Offset = "0x145F980", VA = "0x145F980")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x145F774", Offset = "0x145F774", VA = "0x145F774")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x145A0E4", Offset = "0x145A0E4", VA = "0x145A0E4")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x145FA2C", Offset = "0x145FA2C", VA = "0x145FA2C")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x145BE20", Offset = "0x145BE20", VA = "0x145BE20")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class Version
	{
		[Token(Token = "0x40002ED")]
		public const int Current = 1750;
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D19D0", Offset = "0x7D19D0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D19D0", Offset = "0x7D19D0")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		public enum Direction
		{
			[Token(Token = "0x40003AB")]
			Beam,
			[Token(Token = "0x40003AC")]
			Random
		}

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2C60", Offset = "0x7D2C60")]
		public float alpha;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2C78", Offset = "0x7D2C78")]
		public float size;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2C98", Offset = "0x7D2C98")]
		public float spawnMinDistance;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2CB0", Offset = "0x7D2CB0")]
		public float spawnMaxDistance;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D2CC8", Offset = "0x7D2CC8")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000022")]
		public bool isCulled
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x145FA34", Offset = "0x145FA34", VA = "0x145FA34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D34B8", Offset = "0x7D34B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x145FA3C", Offset = "0x145FA3C", VA = "0x145FA3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D34C8", Offset = "0x7D34C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x145FA48", Offset = "0x145FA48", VA = "0x145FA48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x145FAB4", Offset = "0x145FAB4", VA = "0x145FAB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x145FB48", Offset = "0x145FB48", VA = "0x145FB48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x145FBF4", Offset = "0x145FBF4", VA = "0x145FBF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x145FE4C", Offset = "0x145FE4C", VA = "0x145FE4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x145FEB4", Offset = "0x145FEB4", VA = "0x145FEB4")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1460124", Offset = "0x1460124", VA = "0x1460124")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1460068", Offset = "0x1460068", VA = "0x1460068")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x14607E4", Offset = "0x14607E4", VA = "0x14607E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1460884", Offset = "0x1460884", VA = "0x1460884")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1460944", Offset = "0x1460944", VA = "0x1460944")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1460128", Offset = "0x1460128", VA = "0x1460128")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1460978", Offset = "0x1460978", VA = "0x1460978")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1460CDC", Offset = "0x1460CDC", VA = "0x1460CDC")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7D1A78", Offset = "0x7D1A78")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D1C80", Offset = "0x7D1C80")]
		private sealed class <CoPlaytimeUpdate>d__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0x1462438", Offset = "0x1462438", VA = "0x1462438", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x14624A4", Offset = "0x14624A4", VA = "0x14624A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1461EA0", Offset = "0x1461EA0", VA = "0x1461EA0")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x14623AC", Offset = "0x14623AC", VA = "0x14623AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x14623B0", Offset = "0x14623B0", VA = "0x14623B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1462440", Offset = "0x1462440", VA = "0x1462440", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x7D2CD8", Offset = "0x7D2CD8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2CD8", Offset = "0x7D2CD8")]
		public Color color;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2D2C", Offset = "0x7D2D2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2D2C", Offset = "0x7D2D2C")]
		public float intensityInside;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2D80", Offset = "0x7D2D80")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2D80", Offset = "0x7D2D80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2D80", Offset = "0x7D2D80")]
		public float intensityOutside;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2DF8", Offset = "0x7D2DF8")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2E30", Offset = "0x7D2E30")]
		public float spotAngle;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2E50", Offset = "0x7D2E50")]
		public float coneRadiusStart;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2E88", Offset = "0x7D2E88")]
		public int geomCustomSides;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2EC0", Offset = "0x7D2EC0")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2EF8", Offset = "0x7D2EF8")]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2F10", Offset = "0x7D2F10")]
		public float fallOffStart;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2F48", Offset = "0x7D2F48")]
		public float fallOffEnd;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2F80", Offset = "0x7D2F80")]
		public float glareFrontal;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D2F98", Offset = "0x7D2F98")]
		public float glareBehind;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2FB0", Offset = "0x7D2FB0")]
		public float fresnelPow;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D2FE8", Offset = "0x7D2FE8")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D3034", Offset = "0x7D3034")]
		public float noiseIntensity;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D304C", Offset = "0x7D304C")]
		public float noiseScaleLocal;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float fadeOutBegin;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float fadeOutEnd;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D3078", Offset = "0x7D3078")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D30E4", Offset = "0x7D30E4")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Light _CachedLight;

		[Token(Token = "0x17000027")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D3654", Offset = "0x7D3654")]
		public float alphaInside
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1460D90", Offset = "0x1460D90", VA = "0x1460D90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1460D98", Offset = "0x1460D98", VA = "0x1460D98")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D368C", Offset = "0x7D368C")]
		public float alphaOutside
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x1460DA0", Offset = "0x1460DA0", VA = "0x1460DA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x1460DA8", Offset = "0x1460DA8", VA = "0x1460DA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float intensityGlobal
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1460DB0", Offset = "0x1460DB0", VA = "0x1460DB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x1460DB8", Offset = "0x1460DB8", VA = "0x1460DB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float coneAngle
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x145AB2C", Offset = "0x145AB2C", VA = "0x145AB2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1459CE8", Offset = "0x1459CE8", VA = "0x1459CE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneVolume
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1460DC0", Offset = "0x1460DC0", VA = "0x1460DC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x145ABCC", Offset = "0x145ABCC", VA = "0x145ABCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public int geomSides
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1460E14", Offset = "0x1460E14", VA = "0x1460E14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1460E9C", Offset = "0x1460E9C", VA = "0x1460E9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSegments
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1460F1C", Offset = "0x1460F1C", VA = "0x1460F1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1460FA4", Offset = "0x1460FA4", VA = "0x1460FA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D36C4", Offset = "0x7D36C4")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1461024", Offset = "0x1461024", VA = "0x1461024")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x146102C", Offset = "0x146102C", VA = "0x146102C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x145AD78", Offset = "0x145AD78", VA = "0x145AD78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D36FC", Offset = "0x7D36FC")]
		public float fadeStart
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1461038", Offset = "0x1461038", VA = "0x1461038")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1461040", Offset = "0x1461040", VA = "0x1461040")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D3734", Offset = "0x7D3734")]
		public float fadeEnd
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1461048", Offset = "0x1461048", VA = "0x1461048")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1461050", Offset = "0x1461050", VA = "0x1461050")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1459DF4", Offset = "0x1459DF4", VA = "0x1459DF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D376C", Offset = "0x7D376C")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1461058", Offset = "0x1461058", VA = "0x1461058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1461068", Offset = "0x1461068", VA = "0x1461068")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x145739C", Offset = "0x145739C", VA = "0x145739C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public int sortingLayerID
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1461084", Offset = "0x1461084", VA = "0x1461084")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x146108C", Offset = "0x146108C", VA = "0x146108C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public string sortingLayerName
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1461130", Offset = "0x1461130", VA = "0x1461130")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x146113C", Offset = "0x146113C", VA = "0x146113C")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int sortingOrder
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x146116C", Offset = "0x146116C", VA = "0x146116C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x1461174", Offset = "0x1461174", VA = "0x1461174")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1461218", Offset = "0x1461218", VA = "0x1461218")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1461220", Offset = "0x1461220", VA = "0x1461220")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1461280", Offset = "0x1461280", VA = "0x1461280")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool hasGeometry
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1460B3C", Offset = "0x1460B3C", VA = "0x1460B3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public Bounds bounds
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x1460BAC", Offset = "0x1460BAC", VA = "0x1460BAC")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700003E")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x1461438", Offset = "0x1461438", VA = "0x1461438")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1461530", Offset = "0x1461530", VA = "0x1461530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D34D8", Offset = "0x7D34D8")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x1461538", Offset = "0x1461538", VA = "0x1461538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D34E8", Offset = "0x7D34E8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public string meshStats
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1461540", Offset = "0x1461540", VA = "0x1461540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x14616CC", Offset = "0x14616CC", VA = "0x14616CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x14617AC", Offset = "0x14617AC", VA = "0x14617AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000043")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x14618A4", Offset = "0x14618A4", VA = "0x14618A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x145D900", Offset = "0x145D900", VA = "0x145D900")]
		public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1461290", Offset = "0x1461290", VA = "0x1461290")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x146199C", Offset = "0x146199C", VA = "0x146199C")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x145B554", Offset = "0x145B554", VA = "0x145B554")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x14619FC", Offset = "0x14619FC", VA = "0x14619FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D34F8", Offset = "0x7D34F8")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1461A08", Offset = "0x1461A08", VA = "0x1461A08", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1461C74", Offset = "0x1461C74", VA = "0x1461C74", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1461D08", Offset = "0x1461D08", VA = "0x1461D08")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1461D14", Offset = "0x1461D14", VA = "0x1461D14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1461DA0", Offset = "0x1461DA0", VA = "0x1461DA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x146122C", Offset = "0x146122C", VA = "0x146122C")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1461E2C", Offset = "0x1461E2C", VA = "0x1461E2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D3530", Offset = "0x7D3530")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1461ECC", Offset = "0x1461ECC", VA = "0x1461ECC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1461ED0", Offset = "0x1461ED0", VA = "0x1461ED0")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1461F90", Offset = "0x1461F90", VA = "0x1461F90")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1462094", Offset = "0x1462094", VA = "0x1462094")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1461C44", Offset = "0x1461C44", VA = "0x1461C44")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1461B20", Offset = "0x1461B20", VA = "0x1461B20")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1462280", Offset = "0x1462280", VA = "0x1462280")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D1AE4", Offset = "0x7D1AE4")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x14624AC", Offset = "0x14624AC", VA = "0x14624AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x14625AC", Offset = "0x14625AC", VA = "0x14625AC")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D1B48", Offset = "0x7D1B48")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x14625BC", Offset = "0x14625BC", VA = "0x14625BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x146267C", Offset = "0x146267C", VA = "0x146267C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x146273C", Offset = "0x146273C", VA = "0x146273C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1462744", Offset = "0x1462744", VA = "0x1462744")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1462804", Offset = "0x1462804", VA = "0x1462804")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D1BEC", Offset = "0x7D1BEC")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x146280C", Offset = "0x146280C", VA = "0x146280C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x14628E0", Offset = "0x14628E0", VA = "0x14628E0")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000044")]
		private bool useMouseView
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x14628E8", Offset = "0x14628E8", VA = "0x14628E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x14628F0", Offset = "0x14628F0", VA = "0x14628F0")]
			set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x146292C", Offset = "0x146292C", VA = "0x146292C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x14629C4", Offset = "0x14629C4", VA = "0x14629C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1463080", Offset = "0x1463080", VA = "0x1463080")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D3104", Offset = "0x7D3104")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D3148", Offset = "0x7D3148")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x14630A4", Offset = "0x14630A4", VA = "0x14630A4")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x14638EC", Offset = "0x14638EC", VA = "0x14638EC")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7D31CC", Offset = "0x7D31CC")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x146390C", Offset = "0x146390C", VA = "0x146390C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1463A8C", Offset = "0x1463A8C", VA = "0x1463A8C")]
		public Rotater()
		{
		}
	}
}
