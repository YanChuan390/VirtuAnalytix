using System;
using System.Collections.Generic;
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
	[Address(RVA = "0x13DB514", Offset = "0x13DB514", VA = "0x13DB514")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13DB5F0", Offset = "0x13DB5F0", VA = "0x13DB5F0")]
	public HxSimpleRotate()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class HxDensityVolume : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	public enum DensityShape
	{
		[Token(Token = "0x400019F")]
		Square,
		[Token(Token = "0x40001A0")]
		Sphere,
		[Token(Token = "0x40001A1")]
		Cylinder
	}

	[Token(Token = "0x2000010")]
	public enum DensityBlendMode
	{
		[Token(Token = "0x40001A3")]
		Max,
		[Token(Token = "0x40001A4")]
		Add,
		[Token(Token = "0x40001A5")]
		Min,
		[Token(Token = "0x40001A6")]
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
	[Address(RVA = "0x13DA654", Offset = "0x13DA654", VA = "0x13DA654")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x13DAD28", Offset = "0x13DAD28", VA = "0x13DAD28")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13DADA0", Offset = "0x13DADA0", VA = "0x13DADA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x13DAED0", Offset = "0x13DAED0", VA = "0x13DAED0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13DAFE4", Offset = "0x13DAFE4", VA = "0x13DAFE4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13DB0F8", Offset = "0x13DB0F8", VA = "0x13DB0F8")]
	public void UpdateVolume()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x13DA80C", Offset = "0x13DA80C", VA = "0x13DA80C")]
	private void CalculateBounds()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x13DB240", Offset = "0x13DB240", VA = "0x13DB240")]
	public HxDensityVolume()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8874F0", Offset = "0x8874F0")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8875F4", Offset = "0x8875F4")]
	public float spotAngle;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887610", Offset = "0x887610")]
	public float intensity;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture cookie;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x13DB4C0", Offset = "0x13DB4C0", VA = "0x13DB4C0")]
	public void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x13DB4C4", Offset = "0x13DB4C4", VA = "0x13DB4C4")]
	public HxDummyLight()
	{
	}
}
[Token(Token = "0x2000005")]
public class HxOctree<T>
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887628", Offset = "0x887628")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8882F8", Offset = "0x8882F8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888308", Offset = "0x888308")]
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
	[Token(Token = "0x2000011")]
	public class NodeObject
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HxOctreeNode<T> Node;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMin;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMax;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Center;

		[Token(Token = "0x60000C9")]
		public NodeObject(T value, Vector3 boundsMin, Vector3 boundsMax)
		{
		}
	}

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887638", Offset = "0x887638")]
	private Vector3 <Origin>k__BackingField;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887648", Offset = "0x887648")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888318", Offset = "0x888318")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888328", Offset = "0x888328")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float Size
	{
		[Token(Token = "0x600001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888338", Offset = "0x888338")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888348", Offset = "0x888348")]
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
	[Token(Token = "0x2000012")]
	public enum hxRenderOrder
	{
		[Token(Token = "0x40001AD")]
		ImageEffect,
		[Token(Token = "0x40001AE")]
		ImageEffectOpaque
	}

	[Token(Token = "0x2000013")]
	public enum TransparencyQualities
	{
		[Token(Token = "0x40001B0")]
		Low,
		[Token(Token = "0x40001B1")]
		Medium,
		[Token(Token = "0x40001B2")]
		High,
		[Token(Token = "0x40001B3")]
		VeryHigh
	}

	[Token(Token = "0x2000014")]
	public enum DensityParticleQualities
	{
		[Token(Token = "0x40001B5")]
		Low,
		[Token(Token = "0x40001B6")]
		Medium,
		[Token(Token = "0x40001B7")]
		High,
		[Token(Token = "0x40001B8")]
		VeryHigh
	}

	[Token(Token = "0x2000015")]
	public enum HxAmbientMode
	{
		[Token(Token = "0x40001BA")]
		UseRenderSettings,
		[Token(Token = "0x40001BB")]
		Color,
		[Token(Token = "0x40001BC")]
		Gradient
	}

	[Token(Token = "0x2000016")]
	public enum HxTintMode
	{
		[Token(Token = "0x40001BE")]
		Off,
		[Token(Token = "0x40001BF")]
		Color,
		[Token(Token = "0x40001C0")]
		Edge,
		[Token(Token = "0x40001C1")]
		Gradient
	}

	[Token(Token = "0x2000017")]
	public enum Resolution
	{
		[Token(Token = "0x40001C3")]
		full,
		[Token(Token = "0x40001C4")]
		half,
		[Token(Token = "0x40001C5")]
		quarter
	}

	[Token(Token = "0x2000018")]
	public enum DensityResolution
	{
		[Token(Token = "0x40001C7")]
		full,
		[Token(Token = "0x40001C8")]
		half,
		[Token(Token = "0x40001C9")]
		quarter,
		[Token(Token = "0x40001CA")]
		eighth
	}

	[Token(Token = "0x2000019")]
	private struct TriangleIndices
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int v1;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int v2;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int v3;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x93C068", Offset = "0x93C068", VA = "0x93C068")]
		public TriangleIndices(int v1, int v2, int v3)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8875B4", Offset = "0x8875B4")]
	private sealed class <>c
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<HxDensityVolume> <>9__233_0;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x13EFF24", Offset = "0x13EFF24", VA = "0x13EFF24")]
		public <>c()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x13EFF2C", Offset = "0x13EFF2C", VA = "0x13EFF2C")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887658", Offset = "0x887658")]
	public float DitherSpeed;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887670", Offset = "0x887670")]
	public float LuminanceFeedback;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887688", Offset = "0x887688")]
	public float MaxFeedback;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8876A0", Offset = "0x8876A0")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8876B8", Offset = "0x8876B8")]
	public Resolution resolution;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8876F0", Offset = "0x8876F0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8876F0", Offset = "0x8876F0")]
	public int SampleCount;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887748", Offset = "0x887748")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887748", Offset = "0x887748")]
	public int DirectionalSampleCount;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8877A0", Offset = "0x8877A0")]
	public float MaxDirectionalRayDistance;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8877D8", Offset = "0x8877D8")]
	public float MaxLightDistance;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887810", Offset = "0x887810")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887810", Offset = "0x887810")]
	public float Density;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887864", Offset = "0x887864")]
	public float AmbientLightingStrength;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88787C", Offset = "0x88787C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88787C", Offset = "0x88787C")]
	public float MieScattering;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8878D4", Offset = "0x8878D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8878D4", Offset = "0x8878D4")]
	public float SunSize;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887928", Offset = "0x887928")]
	public bool SunBleed;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887960", Offset = "0x887960")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887960", Offset = "0x887960")]
	public float Extinction;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8879B4", Offset = "0x8879B4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8879B4", Offset = "0x8879B4")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887A08", Offset = "0x887A08")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887A40", Offset = "0x887A40")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887A58", Offset = "0x887A58")]
	public float TintGradient;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
	public Vector3 CurrentTint;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
	public Vector3 CurrentTintEdge;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887A70", Offset = "0x887A70")]
	public bool NoiseEnabled;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887AA8", Offset = "0x887AA8")]
	public Vector3 NoiseScale;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887AE0", Offset = "0x887AE0")]
	public Vector3 NoiseVelocity;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887B18", Offset = "0x887B18")]
	public bool ParticleDensitySupport;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887B50", Offset = "0x887B50")]
	public DensityResolution densityResolution;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887B88", Offset = "0x887B88")]
	public float densityDistance;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	private float densityBias;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887BC0", Offset = "0x887BC0")]
	public bool TransparencySupport;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887BF8", Offset = "0x887BF8")]
	public float transparencyDistance;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887C30", Offset = "0x887C30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887C30", Offset = "0x887C30")]
	public int BlurTransparency;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	private float transparencyBias;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887C84", Offset = "0x887C84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887C84", Offset = "0x887C84")]
	public int blurCount;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887CD8", Offset = "0x887CD8")]
	public float BlurDepthFalloff;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887D10", Offset = "0x887D10")]
	public float DownsampledBlurDepthFalloff;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887D48", Offset = "0x887D48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887D48", Offset = "0x887D48")]
	public int UpSampledblurCount;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887D9C", Offset = "0x887D9C")]
	public float DepthThreshold;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887DD4", Offset = "0x887DD4")]
	public bool GaussianWeights;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D9")]
	[HideInInspector]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887E0C", Offset = "0x887E0C")]
	public bool MapToLDR;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4DA")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887E58", Offset = "0x887E58")]
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
		[Address(RVA = "0x13DB5F8", Offset = "0x13DB5F8", VA = "0x13DB5F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x13DB688", Offset = "0x13DB688", VA = "0x13DB688")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	[HideInInspector]
	public Texture2D SpotLightCookie
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x13E0D4C", Offset = "0x13E0D4C", VA = "0x13E0D4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x13E0F30", Offset = "0x13E0F30", VA = "0x13E0F30")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	[HideInInspector]
	public Texture2D LightFalloff
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x13E0F9C", Offset = "0x13E0F9C", VA = "0x13E0F9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x13E1180", Offset = "0x13E1180", VA = "0x13E1180")]
		set
		{
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x13DB690", Offset = "0x13DB690", VA = "0x13DB690")]
	private void SetUpRenderOrder()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x13DB9AC", Offset = "0x13DB9AC", VA = "0x13DB9AC")]
	public static Material GetDirectionalMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x13DBDBC", Offset = "0x13DBDBC", VA = "0x13DBDBC")]
	public static Material GetProjectorMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x13DBF74", Offset = "0x13DBF74", VA = "0x13DBF74")]
	public static Material GetSpotMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x13DC12C", Offset = "0x13DC12C", VA = "0x13DC12C")]
	public static Material GetPointMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x13DC2E4", Offset = "0x13DC2E4", VA = "0x13DC2E4")]
	public TransparencyQualities compatibleTBuffer()
	{
		return default(TransparencyQualities);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x13DC3B0", Offset = "0x13DC3B0", VA = "0x13DC3B0")]
	private bool IsRenderBoth()
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13DC464", Offset = "0x13DC464", VA = "0x13DC464")]
	private DensityParticleQualities compatibleDBuffer()
	{
		return default(DensityParticleQualities);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13DC4CC", Offset = "0x13DC4CC", VA = "0x13DC4CC")]
	private void MyPreCull(Camera cam)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13DC6DC", Offset = "0x13DC6DC", VA = "0x13DC6DC")]
	public bool renderDensityParticleCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13DC6EC", Offset = "0x13DC6EC", VA = "0x13DC6EC")]
	private void WarmUp()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13DCAF8", Offset = "0x13DCAF8", VA = "0x13DCAF8")]
	private void CreateShaderVariant(Shader source, int i, ref Material[] material, ref ShaderVariantCollection.ShaderVariant[] Variant, bool point = true)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x13DBB5C", Offset = "0x13DBB5C", VA = "0x13DBB5C")]
	private static void CreateShader(Shader source, int i, out Material outMaterial, bool point = true)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x13DD1F8", Offset = "0x13DD1F8", VA = "0x13DD1F8")]
	private void CreatePIDs()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x13E067C", Offset = "0x13E067C", VA = "0x13E067C")]
	public static bool ActiveFull()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x13E06FC", Offset = "0x13E06FC", VA = "0x13E06FC")]
	private void DefineFull()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x13E0700", Offset = "0x13E0700", VA = "0x13E0700")]
	private static void UpdateLight(HxOctreeNode<HxVolumetricLight>.NodeObject node, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x13E07D4", Offset = "0x13E07D4", VA = "0x13E07D4")]
	public static HxOctreeNode<HxVolumetricLight>.NodeObject AddLightOctree(HxVolumetricLight light, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x13E0980", Offset = "0x13E0980", VA = "0x13E0980")]
	public static HxOctreeNode<HxVolumetricParticleSystem>.NodeObject AddParticleOctree(HxVolumetricParticleSystem particle, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x13E0B2C", Offset = "0x13E0B2C", VA = "0x13E0B2C")]
	public static void RemoveLightOctree(HxVolumetricLight light)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x13E0BEC", Offset = "0x13E0BEC", VA = "0x13E0BEC")]
	public static void RemoveParticletOctree(HxVolumetricParticleSystem Particle)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13E0CAC", Offset = "0x13E0CAC", VA = "0x13E0CAC")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x13E0CB4", Offset = "0x13E0CB4", VA = "0x13E0CB4")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x13E11EC", Offset = "0x13E11EC", VA = "0x13E11EC")]
	private Vector4 CalculateDensityDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x13E13D8", Offset = "0x13E13D8", VA = "0x13E13D8")]
	private Vector4 CalculateTransparencyDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x13E15C4", Offset = "0x13E15C4", VA = "0x13E15C4")]
	private void RenderParticles()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x13E33D0", Offset = "0x13E33D0", VA = "0x13E33D0")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13E28B0", Offset = "0x13E28B0", VA = "0x13E28B0")]
	private int RenderSlices()
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13E341C", Offset = "0x13E341C", VA = "0x13E341C")]
	private int GetCamPixelHeight()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13E34E8", Offset = "0x13E34E8", VA = "0x13E34E8")]
	private int GetCamPixelWidth()
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13E35F4", Offset = "0x13E35F4", VA = "0x13E35F4")]
	private void CreateTempTextures()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13E1B98", Offset = "0x13E1B98", VA = "0x13E1B98")]
	public static void ConstructPlanes(Camera cam, Transform camTransform, float near, float far)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13E5004", Offset = "0x13E5004", VA = "0x13E5004")]
	private void FindActiveLights()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x13E275C", Offset = "0x13E275C", VA = "0x13E275C")]
	private void FindActiveParticleSystems()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x13E5404", Offset = "0x13E5404", VA = "0x13E5404")]
	public void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13E588C", Offset = "0x13E588C", VA = "0x13E588C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x13E59B0", Offset = "0x13E59B0", VA = "0x13E59B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x13E5AD4", Offset = "0x13E5AD4", VA = "0x13E5AD4")]
	private void CreateApplyBuffer()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x13E5AD8", Offset = "0x13E5AD8", VA = "0x13E5AD8")]
	private void CreateSetupBuffer()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x13E60E4", Offset = "0x13E60E4", VA = "0x13E60E4")]
	private bool CheckBufferDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x13E62F4", Offset = "0x13E62F4", VA = "0x13E62F4")]
	private void CreateFinalizeBuffer()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x13E9580", Offset = "0x13E9580", VA = "0x13E9580")]
	private void BuildBuffer()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x13EBBB0", Offset = "0x13EBBB0", VA = "0x13EBBB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x13EC630", Offset = "0x13EC630", VA = "0x13EC630")]
	private void SaveUsedShaderVarience()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x13EC634", Offset = "0x13EC634", VA = "0x13EC634")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x13EB424", Offset = "0x13EB424", VA = "0x13EB424")]
	private void CalculateEvent()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x13EC9C8", Offset = "0x13EC9C8", VA = "0x13EC9C8")]
	public void EventOnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x13ECAA8", Offset = "0x13ECAA8", VA = "0x13ECAA8")]
	private int ScalePass()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x13ECACC", Offset = "0x13ECACC", VA = "0x13ECACC")]
	private void DownSampledFullBlur(RenderTexture mainColor, RenderBuffer NewColor, RenderBuffer depth, int pass)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x13EB53C", Offset = "0x13EB53C", VA = "0x13EB53C")]
	private void CheckTemporalTextures()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x13EBF3C", Offset = "0x13EBF3C", VA = "0x13EBF3C")]
	public void ReleaseTempTextures()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x13ECC80", Offset = "0x13ECC80", VA = "0x13ECC80")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x13ED1CC", Offset = "0x13ED1CC", VA = "0x13ED1CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x13ECD48", Offset = "0x13ECD48", VA = "0x13ECD48")]
	private void UpdateLightPoistions()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x13ED05C", Offset = "0x13ED05C", VA = "0x13ED05C")]
	private void UpdateParticlePoistions()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x13EE8A0", Offset = "0x13EE8A0", VA = "0x13EE8A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x13EEA10", Offset = "0x13EEA10", VA = "0x13EEA10")]
	private void start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x13DC594", Offset = "0x13DC594", VA = "0x13DC594")]
	public void ReleaseLightBuffers()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x13EB754", Offset = "0x13EB754", VA = "0x13EB754")]
	private void CreateLightbuffers()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x13DE4C8", Offset = "0x13DE4C8", VA = "0x13DE4C8")]
	private static void CreateTileTexture()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x13E02FC", Offset = "0x13E02FC", VA = "0x13E02FC")]
	public static Mesh CreateOrtho(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x13DFB34", Offset = "0x13DFB34", VA = "0x13DFB34")]
	public static Mesh CreateCone(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x13DE588", Offset = "0x13DE588", VA = "0x13DE588")]
	public static Mesh CreateQuad()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x13DE898", Offset = "0x13DE898", VA = "0x13DE898")]
	public static Mesh CreateBox()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x13DE980", Offset = "0x13DE980", VA = "0x13DE980")]
	public static Mesh CreateIcoSphere(int recursionLevel, float radius)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x13EEC80", Offset = "0x13EEC80", VA = "0x13EEC80")]
	private static int getMiddlePoint(int p1, int p2, ref List<Vector3> vertices, ref Dictionary<long, int> cache, float radius)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x13DE178", Offset = "0x13DE178", VA = "0x13DE178")]
	public void Create3DNoiseTexture()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x13EEEB8", Offset = "0x13EEEB8", VA = "0x13EEEB8")]
	private int PostoIndex(Vector3 pos)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x13EEF28", Offset = "0x13EEF28", VA = "0x13EEF28")]
	public HxVolumetricCamera()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class HxVolumetricImageEffect : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x13EFF88", Offset = "0x13EFF88", VA = "0x13EFF88")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x13F001C", Offset = "0x13F001C", VA = "0x13F001C")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x13F0158", Offset = "0x13F0158", VA = "0x13F0158")]
	public HxVolumetricImageEffect()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
public class HxVolumetricImageEffectOpaque : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x13F0160", Offset = "0x13F0160", VA = "0x13F0160")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x13F01F8", Offset = "0x13F01F8", VA = "0x13F01F8")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x13F0334", Offset = "0x13F0334", VA = "0x13F0334")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887EF0", Offset = "0x887EF0")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887F08", Offset = "0x887F08")]
	public float TintGradient;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887F20", Offset = "0x887F20")]
	public float Intensity;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887F38", Offset = "0x887F38")]
	public float Strength;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Color Color;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887F50", Offset = "0x887F50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887F50", Offset = "0x887F50")]
	public float MieScattering;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887FA8", Offset = "0x887FA8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887FA8", Offset = "0x887FA8")]
	public float SunSize;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887FFC", Offset = "0x887FFC")]
	public bool SunBleed;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888034", Offset = "0x888034")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888034", Offset = "0x888034")]
	public float Extinction;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888088", Offset = "0x888088")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888088", Offset = "0x888088")]
	public float Density;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8880DC", Offset = "0x8880DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8880DC", Offset = "0x8880DC")]
	public float ExtraDensity;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888130", Offset = "0x888130")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888130", Offset = "0x888130")]
	public int SampleCount;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888188", Offset = "0x888188")]
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
		[Address(RVA = "0x13F046C", Offset = "0x13F046C", VA = "0x13F046C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x13F04FC", Offset = "0x13F04FC", VA = "0x13F04FC")]
		set
		{
		}
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x13F033C", Offset = "0x13F033C", VA = "0x13F033C")]
	public Light LightSafe()
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x13F03D4", Offset = "0x13F03D4", VA = "0x13F03D4")]
	public HxDummyLight DummyLightSafe()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x13F0504", Offset = "0x13F0504", VA = "0x13F0504")]
	private LightType GetLightType()
	{
		return default(LightType);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x13F05F8", Offset = "0x13F05F8", VA = "0x13F05F8")]
	private LightShadows LightShadow()
	{
		return default(LightShadows);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x13F0698", Offset = "0x13F0698", VA = "0x13F0698")]
	private bool HasLight()
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x13F0754", Offset = "0x13F0754", VA = "0x13F0754")]
	private Texture LightCookie()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x13F0848", Offset = "0x13F0848", VA = "0x13F0848")]
	private Texture LightFalloffTexture()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x13F0904", Offset = "0x13F0904", VA = "0x13F0904")]
	private float LightShadowBias()
	{
		return default(float);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x13F09B0", Offset = "0x13F09B0", VA = "0x13F09B0")]
	private Color LightColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x13F0B74", Offset = "0x13F0B74", VA = "0x13F0B74")]
	private float LightSpotAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x13F0CC0", Offset = "0x13F0CC0", VA = "0x13F0CC0")]
	private bool LightEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x13F0EBC", Offset = "0x13F0EBC", VA = "0x13F0EBC")]
	private float LightRange()
	{
		return default(float);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x13F1008", Offset = "0x13F1008", VA = "0x13F1008")]
	private float LightShadowStrength()
	{
		return default(float);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x13F10A8", Offset = "0x13F10A8", VA = "0x13F10A8")]
	private float LightIntensity()
	{
		return default(float);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x13F11D4", Offset = "0x13F11D4", VA = "0x13F11D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x13F139C", Offset = "0x13F139C", VA = "0x13F139C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x13F14BC", Offset = "0x13F14BC", VA = "0x13F14BC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x13F15D0", Offset = "0x13F15D0", VA = "0x13F15D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x13EEB64", Offset = "0x13EEB64", VA = "0x13EEB64")]
	public void BuildBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x13EEA68", Offset = "0x13EEA68", VA = "0x13EEA68")]
	public void ReleaseBuffer()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x13DE204", Offset = "0x13DE204", VA = "0x13DE204")]
	public static void CreatePID()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x13F7290", Offset = "0x13F7290", VA = "0x13F7290")]
	private float LightNearPlane()
	{
		return default(float);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x13F7334", Offset = "0x13F7334", VA = "0x13F7334")]
	private int DirectionalPass(CommandBuffer buffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x13F78B0", Offset = "0x13F78B0", VA = "0x13F78B0")]
	private float getContrast()
	{
		return default(float);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x13F7940", Offset = "0x13F7940", VA = "0x13F7940")]
	private bool ShaderModel4()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x13F1640", Offset = "0x13F1640", VA = "0x13F1640")]
	private void BuildDirectionalBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x13F7F34", Offset = "0x13F7F34", VA = "0x13F7F34")]
	private void LoadVolumeDateIntoBuffer(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x13F89D4", Offset = "0x13F89D4", VA = "0x13F89D4")]
	private float CalcLightInstensityDistance(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x13F2CEC", Offset = "0x13F2CEC", VA = "0x13F2CEC")]
	private void BuildSpotLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x13F5BD0", Offset = "0x13F5BD0", VA = "0x13F5BD0")]
	private void BuildProjectorLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x13F911C", Offset = "0x13F911C", VA = "0x13F911C")]
	private void SetColors(CommandBuffer buffer, float distanceLerp)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x13F8000", Offset = "0x13F8000", VA = "0x13F8000")]
	private void SetColors(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x13F9D68", Offset = "0x13F9D68", VA = "0x13F9D68")]
	private Vector3 CalcTintColor(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x13FA01C", Offset = "0x13FA01C", VA = "0x13FA01C")]
	private Vector3 CalcTintColorEdge(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x13F4518", Offset = "0x13F4518", VA = "0x13F4518")]
	private void BuildPointBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x13F8720", Offset = "0x13F8720", VA = "0x13F8720")]
	public int MID(bool RenderShadows, bool full)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x13FA2D0", Offset = "0x13FA2D0", VA = "0x13FA2D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x13F7948", Offset = "0x13F7948", VA = "0x13F7948")]
	private float GetFogDensity()
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x13F8914", Offset = "0x13F8914", VA = "0x13F8914")]
	private Texture3D GetNoiseTexture()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x13F861C", Offset = "0x13F861C", VA = "0x13F861C")]
	private int GetSampleCount(bool RenderShadows)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x13FA2D8", Offset = "0x13FA2D8", VA = "0x13FA2D8")]
	public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x13F8AFC", Offset = "0x13F8AFC", VA = "0x13F8AFC")]
	private float ClosestDistanceToCone(Vector3 Point)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x13FA4C4", Offset = "0x13FA4C4", VA = "0x13FA4C4")]
	private void UpdateLightMatrix()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x13FA9AC", Offset = "0x13FA9AC", VA = "0x13FA9AC")]
	private void CheckLightType()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x13F79E0", Offset = "0x13F79E0", VA = "0x13F79E0")]
	private void LoadVolumeData()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x13FAB38", Offset = "0x13FAB38", VA = "0x13FAB38")]
	private bool BoundsIntersect(HxDensityVolume vol)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x13F97C0", Offset = "0x13F97C0", VA = "0x13F97C0")]
	private void LoadVolumeDataBounds()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x13FABD4", Offset = "0x13FABD4", VA = "0x13FABD4")]
	private Vector4 NormalOfTriangle(Vector3 a, Vector3 b, Vector3 c)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x13FAD28", Offset = "0x13FAD28", VA = "0x13FAD28")]
	private void DrawIntersect()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x13FB85C", Offset = "0x13FB85C", VA = "0x13FB85C")]
	private float GetAspect()
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x13FB8FC", Offset = "0x13FB8FC", VA = "0x13FB8FC")]
	private float GetOrthoSize()
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x13FB99C", Offset = "0x13FB99C", VA = "0x13FB99C")]
	private bool GetOrtho()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x13ED26C", Offset = "0x13ED26C", VA = "0x13ED26C")]
	public void UpdatePosition(bool first = false)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x13FBA3C", Offset = "0x13FBA3C", VA = "0x13FBA3C")]
	public void DrawBounds()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x13FC06C", Offset = "0x13FC06C", VA = "0x13FC06C")]
	public HxVolumetricLight()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
public class HxVolumetricParticleSystem : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	public enum ParticleBlendMode
	{
		[Token(Token = "0x40001D1")]
		Max,
		[Token(Token = "0x40001D2")]
		Add,
		[Token(Token = "0x40001D3")]
		Min,
		[Token(Token = "0x40001D4")]
		Sub
	}

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8881C0", Offset = "0x8881C0")]
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
	[Address(RVA = "0x1D5FAB0", Offset = "0x1D5FAB0", VA = "0x1D5FAB0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1D5FBDC", Offset = "0x1D5FBDC", VA = "0x1D5FBDC")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1D5FD74", Offset = "0x1D5FD74", VA = "0x1D5FD74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1D5FE1C", Offset = "0x1D5FE1C", VA = "0x1D5FE1C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1D5FEC4", Offset = "0x1D5FEC4", VA = "0x1D5FEC4")]
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
	[Address(RVA = "0x1D5FEDC", Offset = "0x1D5FEDC", VA = "0x1D5FEDC")]
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
	[Address(RVA = "0x1D5FEE4", Offset = "0x1D5FEE4", VA = "0x1D5FEE4")]
	private bool CheckDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1D60200", Offset = "0x1D60200", VA = "0x1D60200")]
	public HxVolumetricShadersUsed()
	{
	}
}
