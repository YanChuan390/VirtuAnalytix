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
	[Address(RVA = "0x13D6ED8", Offset = "0x13D6ED8", VA = "0x13D6ED8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13D6F9C", Offset = "0x13D6F9C", VA = "0x13D6F9C")]
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
	[Address(RVA = "0x13D61A0", Offset = "0x13D61A0", VA = "0x13D61A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x13D6780", Offset = "0x13D6780", VA = "0x13D6780")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13D67F0", Offset = "0x13D67F0", VA = "0x13D67F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x13D6918", Offset = "0x13D6918", VA = "0x13D6918")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13D6A20", Offset = "0x13D6A20", VA = "0x13D6A20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13D6B28", Offset = "0x13D6B28", VA = "0x13D6B28")]
	public void UpdateVolume()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x13D6314", Offset = "0x13D6314", VA = "0x13D6314")]
	private void CalculateBounds()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x13D6C04", Offset = "0x13D6C04", VA = "0x13D6C04")]
	public HxDensityVolume()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BEBB8", Offset = "0x8BEBB8")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF254", Offset = "0x8BF254")]
	public float spotAngle;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF270", Offset = "0x8BF270")]
	public float intensity;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture cookie;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x13D6E84", Offset = "0x13D6E84", VA = "0x13D6E84")]
	public void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x13D6E88", Offset = "0x13D6E88", VA = "0x13D6E88")]
	public HxDummyLight()
	{
	}
}
[Token(Token = "0x2000005")]
public class HxOctree<T>
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BF288", Offset = "0x8BF288")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0798", Offset = "0x8C0798")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C07A8", Offset = "0x8C07A8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BF298", Offset = "0x8BF298")]
	private Vector3 <Origin>k__BackingField;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BF2A8", Offset = "0x8BF2A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C07B8", Offset = "0x8C07B8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C07C8", Offset = "0x8C07C8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float Size
	{
		[Token(Token = "0x600001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C07D8", Offset = "0x8C07D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C07E8", Offset = "0x8C07E8")]
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
		[Address(RVA = "0x989654", Offset = "0x989654", VA = "0x989654")]
		public TriangleIndices(int v1, int v2, int v3)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BF1F4", Offset = "0x8BF1F4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<HxDensityVolume> <>9__233_0;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x13E8CF8", Offset = "0x13E8CF8", VA = "0x13E8CF8")]
		public <>c()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x13E8D00", Offset = "0x13E8D00", VA = "0x13E8D00")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF2B8", Offset = "0x8BF2B8")]
	public float DitherSpeed;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF2D0", Offset = "0x8BF2D0")]
	public float LuminanceFeedback;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF2E8", Offset = "0x8BF2E8")]
	public float MaxFeedback;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF300", Offset = "0x8BF300")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF318", Offset = "0x8BF318")]
	public Resolution resolution;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF350", Offset = "0x8BF350")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF350", Offset = "0x8BF350")]
	public int SampleCount;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF3A8", Offset = "0x8BF3A8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF3A8", Offset = "0x8BF3A8")]
	public int DirectionalSampleCount;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF400", Offset = "0x8BF400")]
	public float MaxDirectionalRayDistance;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF438", Offset = "0x8BF438")]
	public float MaxLightDistance;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF470", Offset = "0x8BF470")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF470", Offset = "0x8BF470")]
	public float Density;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF4C4", Offset = "0x8BF4C4")]
	public float AmbientLightingStrength;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF4DC", Offset = "0x8BF4DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF4DC", Offset = "0x8BF4DC")]
	public float MieScattering;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF534", Offset = "0x8BF534")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF534", Offset = "0x8BF534")]
	public float SunSize;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF588", Offset = "0x8BF588")]
	public bool SunBleed;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF5C0", Offset = "0x8BF5C0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF5C0", Offset = "0x8BF5C0")]
	public float Extinction;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF614", Offset = "0x8BF614")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF614", Offset = "0x8BF614")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF668", Offset = "0x8BF668")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF6A0", Offset = "0x8BF6A0")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF6B8", Offset = "0x8BF6B8")]
	public float TintGradient;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
	public Vector3 CurrentTint;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
	public Vector3 CurrentTintEdge;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF6D0", Offset = "0x8BF6D0")]
	public bool NoiseEnabled;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF708", Offset = "0x8BF708")]
	public Vector3 NoiseScale;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF740", Offset = "0x8BF740")]
	public Vector3 NoiseVelocity;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF778", Offset = "0x8BF778")]
	public bool ParticleDensitySupport;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF7B0", Offset = "0x8BF7B0")]
	public DensityResolution densityResolution;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF7E8", Offset = "0x8BF7E8")]
	public float densityDistance;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	private float densityBias;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF820", Offset = "0x8BF820")]
	public bool TransparencySupport;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF858", Offset = "0x8BF858")]
	public float transparencyDistance;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF890", Offset = "0x8BF890")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF890", Offset = "0x8BF890")]
	public int BlurTransparency;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	private float transparencyBias;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF8E4", Offset = "0x8BF8E4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF8E4", Offset = "0x8BF8E4")]
	public int blurCount;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF938", Offset = "0x8BF938")]
	public float BlurDepthFalloff;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF970", Offset = "0x8BF970")]
	public float DownsampledBlurDepthFalloff;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BF9A8", Offset = "0x8BF9A8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF9A8", Offset = "0x8BF9A8")]
	public int UpSampledblurCount;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BF9FC", Offset = "0x8BF9FC")]
	public float DepthThreshold;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFA34", Offset = "0x8BFA34")]
	public bool GaussianWeights;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D9")]
	[HideInInspector]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFA6C", Offset = "0x8BFA6C")]
	public bool MapToLDR;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4DA")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFAB8", Offset = "0x8BFAB8")]
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
		[Address(RVA = "0x13D6FA4", Offset = "0x13D6FA4", VA = "0x13D6FA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x13D7034", Offset = "0x13D7034", VA = "0x13D7034")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	[HideInInspector]
	public Texture2D SpotLightCookie
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x13DBA74", Offset = "0x13DBA74", VA = "0x13DBA74")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x13DBC0C", Offset = "0x13DBC0C", VA = "0x13DBC0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	[HideInInspector]
	public Texture2D LightFalloff
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x13DBC78", Offset = "0x13DBC78", VA = "0x13DBC78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x13DBE10", Offset = "0x13DBE10", VA = "0x13DBE10")]
		set
		{
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x13D703C", Offset = "0x13D703C", VA = "0x13D703C")]
	private void SetUpRenderOrder()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x13D72EC", Offset = "0x13D72EC", VA = "0x13D72EC")]
	public static Material GetDirectionalMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x13D7684", Offset = "0x13D7684", VA = "0x13D7684")]
	public static Material GetProjectorMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x13D7824", Offset = "0x13D7824", VA = "0x13D7824")]
	public static Material GetSpotMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x13D79C4", Offset = "0x13D79C4", VA = "0x13D79C4")]
	public static Material GetPointMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x13D7B64", Offset = "0x13D7B64", VA = "0x13D7B64")]
	public TransparencyQualities compatibleTBuffer()
	{
		return default(TransparencyQualities);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x13D7C30", Offset = "0x13D7C30", VA = "0x13D7C30")]
	private bool IsRenderBoth()
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13D7CDC", Offset = "0x13D7CDC", VA = "0x13D7CDC")]
	private DensityParticleQualities compatibleDBuffer()
	{
		return default(DensityParticleQualities);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13D7D44", Offset = "0x13D7D44", VA = "0x13D7D44")]
	private void MyPreCull(Camera cam)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13D7F1C", Offset = "0x13D7F1C", VA = "0x13D7F1C")]
	public bool renderDensityParticleCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13D7F2C", Offset = "0x13D7F2C", VA = "0x13D7F2C")]
	private void WarmUp()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13D82C0", Offset = "0x13D82C0", VA = "0x13D82C0")]
	private void CreateShaderVariant(Shader source, int i, ref Material[] material, ref ShaderVariantCollection.ShaderVariant[] Variant, bool point = true)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x13D7484", Offset = "0x13D7484", VA = "0x13D7484")]
	private static void CreateShader(Shader source, int i, out Material outMaterial, bool point = true)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x13D8814", Offset = "0x13D8814", VA = "0x13D8814")]
	private void CreatePIDs()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x13DB3C4", Offset = "0x13DB3C4", VA = "0x13DB3C4")]
	public static bool ActiveFull()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x13DB444", Offset = "0x13DB444", VA = "0x13DB444")]
	private void DefineFull()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x13DB448", Offset = "0x13DB448", VA = "0x13DB448")]
	private static void UpdateLight(HxOctreeNode<HxVolumetricLight>.NodeObject node, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x13DB514", Offset = "0x13DB514", VA = "0x13DB514")]
	public static HxOctreeNode<HxVolumetricLight>.NodeObject AddLightOctree(HxVolumetricLight light, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x13DB6B8", Offset = "0x13DB6B8", VA = "0x13DB6B8")]
	public static HxOctreeNode<HxVolumetricParticleSystem>.NodeObject AddParticleOctree(HxVolumetricParticleSystem particle, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x13DB85C", Offset = "0x13DB85C", VA = "0x13DB85C")]
	public static void RemoveLightOctree(HxVolumetricLight light)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x13DB918", Offset = "0x13DB918", VA = "0x13DB918")]
	public static void RemoveParticletOctree(HxVolumetricParticleSystem Particle)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13DB9D4", Offset = "0x13DB9D4", VA = "0x13DB9D4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x13DB9DC", Offset = "0x13DB9DC", VA = "0x13DB9DC")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x13DBE7C", Offset = "0x13DBE7C", VA = "0x13DBE7C")]
	private Vector4 CalculateDensityDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x13DC0B0", Offset = "0x13DC0B0", VA = "0x13DC0B0")]
	private Vector4 CalculateTransparencyDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x13DC29C", Offset = "0x13DC29C", VA = "0x13DC29C")]
	private void RenderParticles()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x13DDD8C", Offset = "0x13DDD8C", VA = "0x13DDD8C")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13DD324", Offset = "0x13DD324", VA = "0x13DD324")]
	private int RenderSlices()
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13DDDD8", Offset = "0x13DDDD8", VA = "0x13DDDD8")]
	private int GetCamPixelHeight()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13DDE90", Offset = "0x13DDE90", VA = "0x13DDE90")]
	private int GetCamPixelWidth()
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13DDF88", Offset = "0x13DDF88", VA = "0x13DDF88")]
	private void CreateTempTextures()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13DC7D4", Offset = "0x13DC7D4", VA = "0x13DC7D4")]
	public static void ConstructPlanes(Camera cam, Transform camTransform, float near, float far)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13DF3C8", Offset = "0x13DF3C8", VA = "0x13DF3C8")]
	private void FindActiveLights()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x13DD234", Offset = "0x13DD234", VA = "0x13DD234")]
	private void FindActiveParticleSystems()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x13DF6F8", Offset = "0x13DF6F8", VA = "0x13DF6F8")]
	public void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13DFB6C", Offset = "0x13DFB6C", VA = "0x13DFB6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x13DFC4C", Offset = "0x13DFC4C", VA = "0x13DFC4C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x13DFD2C", Offset = "0x13DFD2C", VA = "0x13DFD2C")]
	private void CreateApplyBuffer()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x13DFD30", Offset = "0x13DFD30", VA = "0x13DFD30")]
	private void CreateSetupBuffer()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x13E01D8", Offset = "0x13E01D8", VA = "0x13E01D8")]
	private bool CheckBufferDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x13E03D4", Offset = "0x13E03D4", VA = "0x13E03D4")]
	private void CreateFinalizeBuffer()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x13E31C8", Offset = "0x13E31C8", VA = "0x13E31C8")]
	private void BuildBuffer()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x13E5358", Offset = "0x13E5358", VA = "0x13E5358")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x13E5B0C", Offset = "0x13E5B0C", VA = "0x13E5B0C")]
	private void SaveUsedShaderVarience()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x13E5B10", Offset = "0x13E5B10", VA = "0x13E5B10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x13E4CF4", Offset = "0x13E4CF4", VA = "0x13E4CF4")]
	private void CalculateEvent()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x13E5E00", Offset = "0x13E5E00", VA = "0x13E5E00")]
	public void EventOnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x13E5EE0", Offset = "0x13E5EE0", VA = "0x13E5EE0")]
	private int ScalePass()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x13E5F04", Offset = "0x13E5F04", VA = "0x13E5F04")]
	private void DownSampledFullBlur(RenderTexture mainColor, RenderBuffer NewColor, RenderBuffer depth, int pass)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x13E4DD4", Offset = "0x13E4DD4", VA = "0x13E4DD4")]
	private void CheckTemporalTextures()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x13E5640", Offset = "0x13E5640", VA = "0x13E5640")]
	public void ReleaseTempTextures()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x13E60A4", Offset = "0x13E60A4", VA = "0x13E60A4")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x13E6520", Offset = "0x13E6520", VA = "0x13E6520")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x13E616C", Offset = "0x13E616C", VA = "0x13E616C")]
	private void UpdateLightPoistions()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x13E63EC", Offset = "0x13E63EC", VA = "0x13E63EC")]
	private void UpdateParticlePoistions()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x13E7A2C", Offset = "0x13E7A2C", VA = "0x13E7A2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x13E7B5C", Offset = "0x13E7B5C", VA = "0x13E7B5C")]
	private void start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x13D7E0C", Offset = "0x13D7E0C", VA = "0x13D7E0C")]
	public void ReleaseLightBuffers()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x13E4FCC", Offset = "0x13E4FCC", VA = "0x13E4FCC")]
	private void CreateLightbuffers()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x13D9A38", Offset = "0x13D9A38", VA = "0x13D9A38")]
	private static void CreateTileTexture()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x13DB0EC", Offset = "0x13DB0EC", VA = "0x13DB0EC")]
	public static Mesh CreateOrtho(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x13DAA9C", Offset = "0x13DAA9C", VA = "0x13DAA9C")]
	public static Mesh CreateCone(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x13D9AF8", Offset = "0x13D9AF8", VA = "0x13D9AF8")]
	public static Mesh CreateQuad()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x13D9D24", Offset = "0x13D9D24", VA = "0x13D9D24")]
	public static Mesh CreateBox()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x13D9E00", Offset = "0x13D9E00", VA = "0x13D9E00")]
	public static Mesh CreateIcoSphere(int recursionLevel, float radius)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x13E7DA0", Offset = "0x13E7DA0", VA = "0x13E7DA0")]
	private static int getMiddlePoint(int p1, int p2, ref List<Vector3> vertices, ref Dictionary<long, int> cache, float radius)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x13D96E8", Offset = "0x13D96E8", VA = "0x13D96E8")]
	public void Create3DNoiseTexture()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x13E7F9C", Offset = "0x13E7F9C", VA = "0x13E7F9C")]
	private int PostoIndex(Vector3 pos)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x13E800C", Offset = "0x13E800C", VA = "0x13E800C")]
	public HxVolumetricCamera()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class HxVolumetricImageEffect : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x13E8D44", Offset = "0x13E8D44", VA = "0x13E8D44")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x13E8DD8", Offset = "0x13E8DD8", VA = "0x13E8DD8")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x13E8F0C", Offset = "0x13E8F0C", VA = "0x13E8F0C")]
	public HxVolumetricImageEffect()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
public class HxVolumetricImageEffectOpaque : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x13E8F14", Offset = "0x13E8F14", VA = "0x13E8F14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x13E8FAC", Offset = "0x13E8FAC", VA = "0x13E8FAC")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x13E90E0", Offset = "0x13E90E0", VA = "0x13E90E0")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFB50", Offset = "0x8BFB50")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFB68", Offset = "0x8BFB68")]
	public float TintGradient;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFB80", Offset = "0x8BFB80")]
	public float Intensity;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFB98", Offset = "0x8BFB98")]
	public float Strength;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Color Color;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFBB0", Offset = "0x8BFBB0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFBB0", Offset = "0x8BFBB0")]
	public float MieScattering;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFC08", Offset = "0x8BFC08")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFC08", Offset = "0x8BFC08")]
	public float SunSize;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFC5C", Offset = "0x8BFC5C")]
	public bool SunBleed;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFC94", Offset = "0x8BFC94")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFC94", Offset = "0x8BFC94")]
	public float Extinction;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFCE8", Offset = "0x8BFCE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFCE8", Offset = "0x8BFCE8")]
	public float Density;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFD3C", Offset = "0x8BFD3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFD3C", Offset = "0x8BFD3C")]
	public float ExtraDensity;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFD90", Offset = "0x8BFD90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFD90", Offset = "0x8BFD90")]
	public int SampleCount;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8BFDE8", Offset = "0x8BFDE8")]
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
		[Address(RVA = "0x13E9218", Offset = "0x13E9218", VA = "0x13E9218")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x13E92A8", Offset = "0x13E92A8", VA = "0x13E92A8")]
		set
		{
		}
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x13E90E8", Offset = "0x13E90E8", VA = "0x13E90E8")]
	public Light LightSafe()
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x13E9180", Offset = "0x13E9180", VA = "0x13E9180")]
	public HxDummyLight DummyLightSafe()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x13E92B0", Offset = "0x13E92B0", VA = "0x13E92B0")]
	private LightType GetLightType()
	{
		return default(LightType);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x13E939C", Offset = "0x13E939C", VA = "0x13E939C")]
	private LightShadows LightShadow()
	{
		return default(LightShadows);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x13E9434", Offset = "0x13E9434", VA = "0x13E9434")]
	private bool HasLight()
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x13E94F0", Offset = "0x13E94F0", VA = "0x13E94F0")]
	private Texture LightCookie()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x13E95DC", Offset = "0x13E95DC", VA = "0x13E95DC")]
	private Texture LightFalloffTexture()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x13E9698", Offset = "0x13E9698", VA = "0x13E9698")]
	private float LightShadowBias()
	{
		return default(float);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x13E973C", Offset = "0x13E973C", VA = "0x13E973C")]
	private Color LightColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x13E98DC", Offset = "0x13E98DC", VA = "0x13E98DC")]
	private float LightSpotAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x13E9A14", Offset = "0x13E9A14", VA = "0x13E9A14")]
	private bool LightEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x13E9C04", Offset = "0x13E9C04", VA = "0x13E9C04")]
	private float LightRange()
	{
		return default(float);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x13E9D3C", Offset = "0x13E9D3C", VA = "0x13E9D3C")]
	private float LightShadowStrength()
	{
		return default(float);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x13E9DD4", Offset = "0x13E9DD4", VA = "0x13E9DD4")]
	private float LightIntensity()
	{
		return default(float);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x13E9EF8", Offset = "0x13E9EF8", VA = "0x13E9EF8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x13EA0A0", Offset = "0x13EA0A0", VA = "0x13EA0A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x13EA1A0", Offset = "0x13EA1A0", VA = "0x13EA1A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x13EA294", Offset = "0x13EA294", VA = "0x13EA294")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x13E7C84", Offset = "0x13E7C84", VA = "0x13E7C84")]
	public void BuildBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x13E7BB4", Offset = "0x13E7BB4", VA = "0x13E7BB4")]
	public void ReleaseBuffer()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x13D9774", Offset = "0x13D9774", VA = "0x13D9774")]
	public static void CreatePID()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x13EF1A4", Offset = "0x13EF1A4", VA = "0x13EF1A4")]
	private float LightNearPlane()
	{
		return default(float);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x13EF240", Offset = "0x13EF240", VA = "0x13EF240")]
	private int DirectionalPass(CommandBuffer buffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x13EF5EC", Offset = "0x13EF5EC", VA = "0x13EF5EC")]
	private float getContrast()
	{
		return default(float);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x13EF67C", Offset = "0x13EF67C", VA = "0x13EF67C")]
	private bool ShaderModel4()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x13EA304", Offset = "0x13EA304", VA = "0x13EA304")]
	private void BuildDirectionalBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x13EFBDC", Offset = "0x13EFBDC", VA = "0x13EFBDC")]
	private void LoadVolumeDateIntoBuffer(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x13F0534", Offset = "0x13F0534", VA = "0x13F0534")]
	private float CalcLightInstensityDistance(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x13EB60C", Offset = "0x13EB60C", VA = "0x13EB60C")]
	private void BuildSpotLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x13EDE94", Offset = "0x13EDE94", VA = "0x13EDE94")]
	private void BuildProjectorLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x13F0C40", Offset = "0x13F0C40", VA = "0x13F0C40")]
	private void SetColors(CommandBuffer buffer, float distanceLerp)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x13EFC8C", Offset = "0x13EFC8C", VA = "0x13EFC8C")]
	private void SetColors(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x13F1708", Offset = "0x13F1708", VA = "0x13F1708")]
	private Vector3 CalcTintColor(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x13F19B4", Offset = "0x13F19B4", VA = "0x13F19B4")]
	private Vector3 CalcTintColorEdge(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x13ECAA8", Offset = "0x13ECAA8", VA = "0x13ECAA8")]
	private void BuildPointBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x13F029C", Offset = "0x13F029C", VA = "0x13F029C")]
	public int MID(bool RenderShadows, bool full)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x13F1C60", Offset = "0x13F1C60", VA = "0x13F1C60")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x13EF684", Offset = "0x13EF684", VA = "0x13EF684")]
	private float GetFogDensity()
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x13F0474", Offset = "0x13F0474", VA = "0x13F0474")]
	private Texture3D GetNoiseTexture()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x13F01A0", Offset = "0x13F01A0", VA = "0x13F01A0")]
	private int GetSampleCount(bool RenderShadows)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x13F1C68", Offset = "0x13F1C68", VA = "0x13F1C68")]
	public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x13F0648", Offset = "0x13F0648", VA = "0x13F0648")]
	private float ClosestDistanceToCone(Vector3 Point)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x13F1E54", Offset = "0x13F1E54", VA = "0x13F1E54")]
	private void UpdateLightMatrix()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x13F22D8", Offset = "0x13F22D8", VA = "0x13F22D8")]
	private void CheckLightType()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x13EF71C", Offset = "0x13EF71C", VA = "0x13EF71C")]
	private void LoadVolumeData()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x13F2450", Offset = "0x13F2450", VA = "0x13F2450")]
	private bool BoundsIntersect(HxDensityVolume vol)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x13F11E8", Offset = "0x13F11E8", VA = "0x13F11E8")]
	private void LoadVolumeDataBounds()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x13F24D0", Offset = "0x13F24D0", VA = "0x13F24D0")]
	private Vector4 NormalOfTriangle(Vector3 a, Vector3 b, Vector3 c)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x13F2624", Offset = "0x13F2624", VA = "0x13F2624")]
	private void DrawIntersect()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x13F3134", Offset = "0x13F3134", VA = "0x13F3134")]
	private float GetAspect()
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x13F31CC", Offset = "0x13F31CC", VA = "0x13F31CC")]
	private float GetOrthoSize()
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x13F3264", Offset = "0x13F3264", VA = "0x13F3264")]
	private bool GetOrtho()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x13E65B8", Offset = "0x13E65B8", VA = "0x13E65B8")]
	public void UpdatePosition(bool first = false)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x13F32FC", Offset = "0x13F32FC", VA = "0x13F32FC")]
	public void DrawBounds()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x13F392C", Offset = "0x13F392C", VA = "0x13F392C")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFE20", Offset = "0x8BFE20")]
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
	[Address(RVA = "0x1657FF4", Offset = "0x1657FF4", VA = "0x1657FF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x165810C", Offset = "0x165810C", VA = "0x165810C")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x165822C", Offset = "0x165822C", VA = "0x165822C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x16582CC", Offset = "0x16582CC", VA = "0x16582CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x165836C", Offset = "0x165836C", VA = "0x165836C")]
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
	[Address(RVA = "0x1658384", Offset = "0x1658384", VA = "0x1658384")]
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
	[Address(RVA = "0x165838C", Offset = "0x165838C", VA = "0x165838C")]
	private bool CheckDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x16586A8", Offset = "0x16586A8", VA = "0x16586A8")]
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
	[Address(RVA = "0x165A7F4", Offset = "0x165A7F4", VA = "0x165A7F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x165A7F8", Offset = "0x165A7F8", VA = "0x165A7F8")]
	private void Init()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x165AB28", Offset = "0x165AB28", VA = "0x165AB28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x165AB60", Offset = "0x165AB60", VA = "0x165AB60")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x165AD40", Offset = "0x165AD40", VA = "0x165AD40")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x165AE04", Offset = "0x165AE04", VA = "0x165AE04")]
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
	[Address(RVA = "0x165AE7C", Offset = "0x165AE7C", VA = "0x165AE7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x165B120", Offset = "0x165B120", VA = "0x165B120")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x165B194", Offset = "0x165B194", VA = "0x165B194")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x165B23C", Offset = "0x165B23C", VA = "0x165B23C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x165B274", Offset = "0x165B274", VA = "0x165B274")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x165B328", Offset = "0x165B328", VA = "0x165B328")]
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
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BEC6C", Offset = "0x8BEC6C")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFF78", Offset = "0x8BFF78")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFF94", Offset = "0x8BFF94")]
	public float Frequency;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFFB0", Offset = "0x8BFFB0")]
	public float OffsetSpeed;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool RandomTurbulenceOffset;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFFCC", Offset = "0x8BFFCC")]
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
	[Address(RVA = "0x1659870", Offset = "0x1659870", VA = "0x1659870")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x165A1C8", Offset = "0x165A1C8", VA = "0x165A1C8")]
	private void ClearTrails()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1659A48", Offset = "0x1659A48", VA = "0x1659A48")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x165A3E0", Offset = "0x165A3E0", VA = "0x165A3E0")]
	private void InitTrailRenderer(GameObject go)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x165A2DC", Offset = "0x165A2DC", VA = "0x165A2DC")]
	private void RemoveEmptyTrails()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x165A4D0", Offset = "0x165A4D0", VA = "0x165A4D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x165A664", Offset = "0x165A664", VA = "0x165A664")]
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
		[Address(RVA = "0x99D4D0", Offset = "0x99D4D0", VA = "0x99D4D0")]
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
	[Address(RVA = "0x16586BC", Offset = "0x16586BC", VA = "0x16586BC")]
	public static HSBColor ColorToHSV(Color color)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x16588BC", Offset = "0x16588BC", VA = "0x16588BC")]
	public static Color HSVToColor(HSBColor hsbColor)
	{
		return default(Color);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1658B30", Offset = "0x1658B30", VA = "0x1658B30")]
	public static Color ConvertRGBColorByHUE(Color rgbColor, float hue)
	{
		return default(Color);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1658C50", Offset = "0x1658C50", VA = "0x1658C50")]
	public static void ChangeObjectColorByHUE(GameObject go, float hue)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1659510", Offset = "0x1659510", VA = "0x1659510")]
	private static Material setMatHUEColor(Material mat, string name, float hueColor)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x16595F0", Offset = "0x16595F0", VA = "0x16595F0")]
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
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BECD0", Offset = "0x8BECD0")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8BFFE8", Offset = "0x8BFFE8")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0004", Offset = "0x8C0004")]
	public float Frequency;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0020", Offset = "0x8C0020")]
	public float OffsetSpeed;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool RandomTurbulenceOffset;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C003C", Offset = "0x8C003C")]
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
	[Address(RVA = "0x165B374", Offset = "0x165B374", VA = "0x165B374")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x165B5B4", Offset = "0x165B5B4", VA = "0x165B5B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x165B39C", Offset = "0x165B39C", VA = "0x165B39C")]
	private void Init()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x165B5C4", Offset = "0x165B5C4", VA = "0x165B5C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x165C408", Offset = "0x165C408", VA = "0x165C408")]
	private int GetLastDeletedIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x165B6E4", Offset = "0x165B6E4", VA = "0x165B6E4")]
	private void UpdatePositionsCount()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x165CC58", Offset = "0x165CC58", VA = "0x165CC58")]
	private void AddInterpolatedPositions(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x165C518", Offset = "0x165C518", VA = "0x165C518")]
	private void RemovePositionsBeforeIndex(int lastDeletedIndex)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x165B8CC", Offset = "0x165B8CC", VA = "0x165B8CC")]
	private void UpdateForce()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x165BEC4", Offset = "0x165BEC4", VA = "0x165BEC4")]
	private void UpdateImpulse()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x165C0E8", Offset = "0x165C0E8", VA = "0x165C0E8")]
	private void UpdateVelocity()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x165C628", Offset = "0x165C628", VA = "0x165C628")]
	public void InterpolateBezier(List<Vector3> segmentPoints, float scale)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x165CB6C", Offset = "0x165CB6C", VA = "0x165CB6C")]
	public List<Vector3> GetDrawingPoints()
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x165CE6C", Offset = "0x165CE6C", VA = "0x165CE6C")]
	private List<Vector3> FindDrawingPoints(int curveIndex)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x165D148", Offset = "0x165D148", VA = "0x165D148")]
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector3> pointList, int insertionIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x165CF90", Offset = "0x165CF90", VA = "0x165CF90")]
	public Vector3 CalculateBezierPoint(int curveIndex, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x165D420", Offset = "0x165D420", VA = "0x165D420")]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x165D5E8", Offset = "0x165D5E8", VA = "0x165D5E8")]
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
	[Address(RVA = "0x165D6EC", Offset = "0x165D6EC", VA = "0x165D6EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x165D984", Offset = "0x165D984", VA = "0x165D984")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x165D9AC", Offset = "0x165D9AC", VA = "0x165D9AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x165D6FC", Offset = "0x165D6FC", VA = "0x165D6FC")]
	private void InitDefaultVariables()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x165DF98", Offset = "0x165DF98", VA = "0x165DF98")]
	private void InitializeMaterial()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x165D9F8", Offset = "0x165D9F8", VA = "0x165D9F8")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x165DBA4", Offset = "0x165DBA4", VA = "0x165DBA4")]
	private void SetSpriteAnimation()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x165DDFC", Offset = "0x165DDFC", VA = "0x165DDFC")]
	private void SetSpriteAnimationIterpolated()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x165E174", Offset = "0x165E174", VA = "0x165E174")]
	public RFX4_UVAnimation()
	{
	}
}
namespace VLB
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8BED34", Offset = "0x8BED34")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BED34", Offset = "0x8BED34")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BF204", Offset = "0x8BF204")]
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
				[Address(RVA = "0x1662838", Offset = "0x1662838", VA = "0x1662838", Slot = "4")]
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
				[Address(RVA = "0x16628A4", Offset = "0x16628A4", VA = "0x16628A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x165E4E4", Offset = "0x165E4E4", VA = "0x165E4E4")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x16627BC", Offset = "0x16627BC", VA = "0x16627BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x16627C0", Offset = "0x16627C0", VA = "0x16627C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x1662840", Offset = "0x1662840", VA = "0x1662840", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0068", Offset = "0x8C0068")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0078", Offset = "0x8C0078")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0088", Offset = "0x8C0088")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DynamicOcclusion _dynamicOcclusion;

		[Token(Token = "0x17000008")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x165E208", Offset = "0x165E208", VA = "0x165E208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0808", Offset = "0x8C0808")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x165E210", Offset = "0x165E210", VA = "0x165E210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0818", Offset = "0x8C0818")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x165E218", Offset = "0x165E218", VA = "0x165E218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0828", Offset = "0x8C0828")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x165E220", Offset = "0x165E220", VA = "0x165E220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0838", Offset = "0x8C0838")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x165E228", Offset = "0x165E228", VA = "0x165E228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0848", Offset = "0x8C0848")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x165E230", Offset = "0x165E230", VA = "0x165E230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0858", Offset = "0x8C0858")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool visible
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x165E238", Offset = "0x165E238", VA = "0x165E238")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x165E254", Offset = "0x165E254", VA = "0x165E254")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x165E274", Offset = "0x165E274", VA = "0x165E274")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x165E290", Offset = "0x165E290", VA = "0x165E290")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int sortingOrder
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x165E2AC", Offset = "0x165E2AC", VA = "0x165E2AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x165E2C8", Offset = "0x165E2C8", VA = "0x165E2C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x165ED54", Offset = "0x165ED54", VA = "0x165ED54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1660E24", Offset = "0x1660E24", VA = "0x1660E24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1661018", Offset = "0x1661018", VA = "0x1661018")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x16610EC", Offset = "0x16610EC", VA = "0x16610EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public DynamicOcclusion dynamicOcclusion
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1662084", Offset = "0x1662084", VA = "0x1662084")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x166208C", Offset = "0x166208C", VA = "0x166208C")]
			set
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x165E2E4", Offset = "0x165E2E4", VA = "0x165E2E4")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x165E470", Offset = "0x165E470", VA = "0x165E470")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C0868", Offset = "0x8C0868")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x165E510", Offset = "0x165E510", VA = "0x165E510")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x165E6FC", Offset = "0x165E6FC", VA = "0x165E6FC")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x165EA10", Offset = "0x165EA10", VA = "0x165EA10")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x165EACC", Offset = "0x165EACC", VA = "0x165EACC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x165EB8C", Offset = "0x165EB8C", VA = "0x165EB8C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x165EC34", Offset = "0x165EC34", VA = "0x165EC34")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x165ECC4", Offset = "0x165ECC4", VA = "0x165ECC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x165ED5C", Offset = "0x165ED5C", VA = "0x165ED5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x165EDF4", Offset = "0x165EDF4", VA = "0x165EDF4")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x165F650", Offset = "0x165F650", VA = "0x165F650")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1660CB8", Offset = "0x1660CB8", VA = "0x1660CB8")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x165F338", Offset = "0x165F338", VA = "0x165F338")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x165E854", Offset = "0x165E854", VA = "0x165E854")]
		private void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1661724", Offset = "0x1661724", VA = "0x1661724")]
		private void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1661848", Offset = "0x1661848", VA = "0x1661848")]
		private void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x166196C", Offset = "0x166196C", VA = "0x166196C")]
		private void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x165E78C", Offset = "0x165E78C", VA = "0x165E78C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x165E948", Offset = "0x165E948", VA = "0x165E948")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1661AB8", Offset = "0x1661AB8", VA = "0x1661AB8")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1660560", Offset = "0x1660560", VA = "0x1660560")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x16621D0", Offset = "0x16621D0", VA = "0x16621D0")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1662570", Offset = "0x1662570", VA = "0x1662570")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1662610", Offset = "0x1662610", VA = "0x1662610")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x16621D8", Offset = "0x16621D8", VA = "0x16621D8")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x16627B4", Offset = "0x16627B4", VA = "0x16627B4")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BEDA4", Offset = "0x8BEDA4")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0098", Offset = "0x8C0098")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0108", Offset = "0x8C0108")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0108", Offset = "0x8C0108")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0188", Offset = "0x8C0188")]
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
			[Address(RVA = "0x165F194", Offset = "0x165F194", VA = "0x165F194")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000014")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x165F93C", Offset = "0x165F93C", VA = "0x165F93C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public Shader beamShader
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x16628AC", Offset = "0x16628AC", VA = "0x16628AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x16628C8", Offset = "0x16628C8", VA = "0x16628C8")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000017")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x165E678", Offset = "0x165E678", VA = "0x165E678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public static Config Instance
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x165E618", Offset = "0x165E618", VA = "0x165E618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1662900", Offset = "0x1662900", VA = "0x1662900")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x16629A0", Offset = "0x16629A0", VA = "0x16629A0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x8C08CC", Offset = "0x8C08CC")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1662A18", Offset = "0x1662A18", VA = "0x1662A18")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1662AB4", Offset = "0x1662AB4", VA = "0x1662AB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1662C74", Offset = "0x1662C74", VA = "0x1662C74")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1662E14", Offset = "0x1662E14", VA = "0x1662E14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1662E44", Offset = "0x1662E44", VA = "0x1662E44")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1662EE8", Offset = "0x1662EE8", VA = "0x1662EE8")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1663060", Offset = "0x1663060", VA = "0x1663060")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BEDDC", Offset = "0x8BEDDC")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400023F")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x166313C", Offset = "0x166313C", VA = "0x166313C")]
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
			[Address(RVA = "0x165F120", Offset = "0x165F120", VA = "0x165F120")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BEE14", Offset = "0x8BEE14")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BEE14", Offset = "0x8BEE14")]
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
				[Address(RVA = "0x1664564", Offset = "0x1664564", VA = "0x1664564")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000048")]
			public string name
			{
				[Token(Token = "0x6000203")]
				[Address(RVA = "0x1664B08", Offset = "0x1664B08", VA = "0x1664B08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000049")]
			public Bounds bounds
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0x1664BE4", Offset = "0x1664BE4", VA = "0x1664BE4")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1664068", Offset = "0x1664068", VA = "0x1664068")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x166416C", Offset = "0x166416C", VA = "0x166416C")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x16640D8", Offset = "0x16640D8", VA = "0x16640D8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C01D4", Offset = "0x8C01D4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C01E4", Offset = "0x8C01E4")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001A")]
		public HitResult currentHit
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1663270", Offset = "0x1663270", VA = "0x1663270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C08DC", Offset = "0x8C08DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1663278", Offset = "0x1663278", VA = "0x1663278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C08EC", Offset = "0x8C08EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1663280", Offset = "0x1663280", VA = "0x1663280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C08FC", Offset = "0x8C08FC")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x166328C", Offset = "0x166328C", VA = "0x166328C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C090C", Offset = "0x8C090C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x16639E8", Offset = "0x16639E8", VA = "0x16639E8")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x16639FC", Offset = "0x16639FC", VA = "0x16639FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1663298", Offset = "0x1663298", VA = "0x1663298")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1663344", Offset = "0x1663344", VA = "0x1663344")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x166339C", Offset = "0x166339C", VA = "0x166339C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x16633E4", Offset = "0x16633E4", VA = "0x16633E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x16634C8", Offset = "0x16634C8", VA = "0x16634C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x16638EC", Offset = "0x16638EC", VA = "0x16638EC")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1663A48", Offset = "0x1663A48", VA = "0x1663A48")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1663A5C", Offset = "0x1663A5C", VA = "0x1663A5C")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1663CC0", Offset = "0x1663CC0", VA = "0x1663CC0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1664254", Offset = "0x1664254", VA = "0x1664254")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1664454", Offset = "0x1664454", VA = "0x1664454")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1663508", Offset = "0x1663508", VA = "0x1663508")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1664618", Offset = "0x1664618", VA = "0x1664618")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x16633C0", Offset = "0x16633C0", VA = "0x16633C0")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1664730", Offset = "0x1664730", VA = "0x1664730")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1664874", Offset = "0x1664874", VA = "0x1664874")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x16649B8", Offset = "0x16649B8", VA = "0x16649B8")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1664A64", Offset = "0x1664A64", VA = "0x1664A64")]
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
		[Address(RVA = "0x1660348", Offset = "0x1660348", VA = "0x1660348")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1664CDC", Offset = "0x1664CDC", VA = "0x1664CDC")]
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
			[Address(RVA = "0x1661134", Offset = "0x1661134", VA = "0x1661134")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1664DE0", Offset = "0x1664DE0", VA = "0x1664DE0")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1664E80", Offset = "0x1664E80", VA = "0x1664E80")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1664FD0", Offset = "0x1664FD0", VA = "0x1664FD0")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x16650F8", Offset = "0x16650F8", VA = "0x16650F8")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x16651A4", Offset = "0x16651A4", VA = "0x16651A4")]
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
		[Address(RVA = "0x16651AC", Offset = "0x16651AC", VA = "0x16651AC")]
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
				[Address(RVA = "0x166523C", Offset = "0x166523C", VA = "0x166523C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1661280", Offset = "0x1661280", VA = "0x1661280")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1661278", Offset = "0x1661278", VA = "0x1661278")]
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
			[Address(RVA = "0x16651B4", Offset = "0x16651B4", VA = "0x16651B4")]
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
		[Address(RVA = "0x165F19C", Offset = "0x165F19C", VA = "0x165F19C")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1661488", Offset = "0x1661488", VA = "0x1661488")]
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
		[Address(RVA = "0x16653C8", Offset = "0x16653C8", VA = "0x16653C8")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x16653E0", Offset = "0x16653E0", VA = "0x16653E0")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x16654AC", Offset = "0x16654AC", VA = "0x16654AC")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x165F94C", Offset = "0x165F94C", VA = "0x165F94C")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x16654C0", Offset = "0x16654C0", VA = "0x16654C0")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x16654DC", Offset = "0x16654DC", VA = "0x16654DC")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1665504", Offset = "0x1665504", VA = "0x1665504")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x16655A0", Offset = "0x16655A0", VA = "0x16655A0")]
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
			[Address(RVA = "0x1660EC8", Offset = "0x1660EC8", VA = "0x1660EC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x16656E0", Offset = "0x16656E0", VA = "0x16656E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1665640", Offset = "0x1665640", VA = "0x1665640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1665778", Offset = "0x1665778", VA = "0x1665778")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x8C091C", Offset = "0x8C091C")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1661E64", Offset = "0x1661E64", VA = "0x1661E64")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x16657D4", Offset = "0x16657D4", VA = "0x16657D4")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BEEBC", Offset = "0x8BEEBC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BEEBC", Offset = "0x8BEEBC")]
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
		[Address(RVA = "0x1665E84", Offset = "0x1665E84", VA = "0x1665E84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x16660A8", Offset = "0x16660A8", VA = "0x16660A8")]
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
		[Address(RVA = "0x16660C0", Offset = "0x16660C0", VA = "0x16660C0")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x165F528", Offset = "0x165F528", VA = "0x165F528")]
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
		[Address(RVA = "0x1666148", Offset = "0x1666148", VA = "0x1666148")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1666230", Offset = "0x1666230", VA = "0x1666230")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x166625C", Offset = "0x166625C", VA = "0x166625C")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x166628C", Offset = "0x166628C", VA = "0x166628C")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x16662C0", Offset = "0x16662C0", VA = "0x16662C0")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x16662F8", Offset = "0x16662F8", VA = "0x16662F8")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x166632C", Offset = "0x166632C", VA = "0x166632C")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x166635C", Offset = "0x166635C", VA = "0x166635C")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1663F7C", Offset = "0x1663F7C", VA = "0x1663F7C")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x16663B0", Offset = "0x16663B0", VA = "0x16663B0")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x16663E4", Offset = "0x16663E4", VA = "0x16663E4")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1664898", Offset = "0x1664898", VA = "0x1664898")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x16667EC", Offset = "0x16667EC", VA = "0x16667EC")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x16621AC", Offset = "0x16621AC", VA = "0x16621AC")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1662AA0", Offset = "0x1662AA0", VA = "0x1662AA0")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1661CE8", Offset = "0x1661CE8", VA = "0x1661CE8")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1666934", Offset = "0x1666934", VA = "0x1666934")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1666A44", Offset = "0x1666A44", VA = "0x1666A44")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1666838", Offset = "0x1666838", VA = "0x1666838")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x16611A8", Offset = "0x16611A8", VA = "0x16611A8")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1666AF0", Offset = "0x1666AF0", VA = "0x1666AF0")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1662EE4", Offset = "0x1662EE4", VA = "0x1662EE4")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BEF64", Offset = "0x8BEF64")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BEF64", Offset = "0x8BEF64")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C01F4", Offset = "0x8C01F4")]
		public float alpha;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C020C", Offset = "0x8C020C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C022C", Offset = "0x8C022C")]
		public float spawnMinDistance;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0244", Offset = "0x8C0244")]
		public float spawnMaxDistance;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C025C", Offset = "0x8C025C")]
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
			[Address(RVA = "0x1666AF8", Offset = "0x1666AF8", VA = "0x1666AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0A4C", Offset = "0x8C0A4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1666B00", Offset = "0x1666B00", VA = "0x1666B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0A5C", Offset = "0x8C0A5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1666B0C", Offset = "0x1666B0C", VA = "0x1666B0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1666B78", Offset = "0x1666B78", VA = "0x1666B78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1666C0C", Offset = "0x1666C0C", VA = "0x1666C0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1666CB8", Offset = "0x1666CB8", VA = "0x1666CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1666F10", Offset = "0x1666F10", VA = "0x1666F10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1666F78", Offset = "0x1666F78", VA = "0x1666F78")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x16671E8", Offset = "0x16671E8", VA = "0x16671E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x166712C", Offset = "0x166712C", VA = "0x166712C")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x16678A8", Offset = "0x16678A8", VA = "0x16678A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1667948", Offset = "0x1667948", VA = "0x1667948")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1667A08", Offset = "0x1667A08", VA = "0x1667A08")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x16671EC", Offset = "0x16671EC", VA = "0x16671EC")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1667A3C", Offset = "0x1667A3C", VA = "0x1667A3C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1667DA0", Offset = "0x1667DA0", VA = "0x1667DA0")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8BF00C", Offset = "0x8BF00C")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8BF214", Offset = "0x8BF214")]
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
				[Address(RVA = "0x16694FC", Offset = "0x16694FC", VA = "0x16694FC", Slot = "4")]
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
				[Address(RVA = "0x1669568", Offset = "0x1669568", VA = "0x1669568", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1668F64", Offset = "0x1668F64", VA = "0x1668F64")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x1669470", Offset = "0x1669470", VA = "0x1669470", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x1669474", Offset = "0x1669474", VA = "0x1669474", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1669504", Offset = "0x1669504", VA = "0x1669504", Slot = "8")]
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
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x8C026C", Offset = "0x8C026C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C026C", Offset = "0x8C026C")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C02C0", Offset = "0x8C02C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C02C0", Offset = "0x8C02C0")]
		public float intensityInside;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0314", Offset = "0x8C0314")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0314", Offset = "0x8C0314")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0314", Offset = "0x8C0314")]
		public float intensityOutside;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C038C", Offset = "0x8C038C")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C03C4", Offset = "0x8C03C4")]
		public float spotAngle;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C03E4", Offset = "0x8C03E4")]
		public float coneRadiusStart;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C041C", Offset = "0x8C041C")]
		public int geomCustomSides;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0454", Offset = "0x8C0454")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C048C", Offset = "0x8C048C")]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C04A4", Offset = "0x8C04A4")]
		public float fallOffStart;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C04DC", Offset = "0x8C04DC")]
		public float fallOffEnd;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0514", Offset = "0x8C0514")]
		public float glareFrontal;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C052C", Offset = "0x8C052C")]
		public float glareBehind;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0544", Offset = "0x8C0544")]
		public float fresnelPow;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C057C", Offset = "0x8C057C")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C05C8", Offset = "0x8C05C8")]
		public float noiseIntensity;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C05E0", Offset = "0x8C05E0")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C060C", Offset = "0x8C060C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0678", Offset = "0x8C0678")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0BE8", Offset = "0x8C0BE8")]
		public float alphaInside
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1667E54", Offset = "0x1667E54", VA = "0x1667E54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1667E5C", Offset = "0x1667E5C", VA = "0x1667E5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0C20", Offset = "0x8C0C20")]
		public float alphaOutside
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x1667E64", Offset = "0x1667E64", VA = "0x1667E64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x1667E6C", Offset = "0x1667E6C", VA = "0x1667E6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float intensityGlobal
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1667E74", Offset = "0x1667E74", VA = "0x1667E74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x1667E7C", Offset = "0x1667E7C", VA = "0x1667E7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float coneAngle
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1661BF0", Offset = "0x1661BF0", VA = "0x1661BF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1660DAC", Offset = "0x1660DAC", VA = "0x1660DAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneVolume
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1667E84", Offset = "0x1667E84", VA = "0x1667E84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1661C90", Offset = "0x1661C90", VA = "0x1661C90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public int geomSides
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1667ED8", Offset = "0x1667ED8", VA = "0x1667ED8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1667F60", Offset = "0x1667F60", VA = "0x1667F60")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSegments
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1667FE0", Offset = "0x1667FE0", VA = "0x1667FE0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1668068", Offset = "0x1668068", VA = "0x1668068")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0C58", Offset = "0x8C0C58")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x16680E8", Offset = "0x16680E8", VA = "0x16680E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x16680F0", Offset = "0x16680F0", VA = "0x16680F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1661E3C", Offset = "0x1661E3C", VA = "0x1661E3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0C90", Offset = "0x8C0C90")]
		public float fadeStart
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x16680FC", Offset = "0x16680FC", VA = "0x16680FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1668104", Offset = "0x1668104", VA = "0x1668104")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0CC8", Offset = "0x8C0CC8")]
		public float fadeEnd
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x166810C", Offset = "0x166810C", VA = "0x166810C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1668114", Offset = "0x1668114", VA = "0x1668114")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1660EB8", Offset = "0x1660EB8", VA = "0x1660EB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0D00", Offset = "0x8C0D00")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x166811C", Offset = "0x166811C", VA = "0x166811C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x166812C", Offset = "0x166812C", VA = "0x166812C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x165E460", Offset = "0x165E460", VA = "0x165E460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public int sortingLayerID
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1668148", Offset = "0x1668148", VA = "0x1668148")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1668150", Offset = "0x1668150", VA = "0x1668150")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public string sortingLayerName
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x16681F4", Offset = "0x16681F4", VA = "0x16681F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1668200", Offset = "0x1668200", VA = "0x1668200")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int sortingOrder
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1668230", Offset = "0x1668230", VA = "0x1668230")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x1668238", Offset = "0x1668238", VA = "0x1668238")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x16682DC", Offset = "0x16682DC", VA = "0x16682DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x16682E4", Offset = "0x16682E4", VA = "0x16682E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1668344", Offset = "0x1668344", VA = "0x1668344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool hasGeometry
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1667C00", Offset = "0x1667C00", VA = "0x1667C00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public Bounds bounds
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x1667C70", Offset = "0x1667C70", VA = "0x1667C70")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700003E")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x16684FC", Offset = "0x16684FC", VA = "0x16684FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x16685F4", Offset = "0x16685F4", VA = "0x16685F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0A6C", Offset = "0x8C0A6C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x16685FC", Offset = "0x16685FC", VA = "0x16685FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C0A7C", Offset = "0x8C0A7C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public string meshStats
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1668604", Offset = "0x1668604", VA = "0x1668604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1668790", Offset = "0x1668790", VA = "0x1668790")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1668870", Offset = "0x1668870", VA = "0x1668870")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000043")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1668968", Offset = "0x1668968", VA = "0x1668968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x16649C4", Offset = "0x16649C4", VA = "0x16649C4")]
		public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1668354", Offset = "0x1668354", VA = "0x1668354")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1668A60", Offset = "0x1668A60", VA = "0x1668A60")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1662618", Offset = "0x1662618", VA = "0x1662618")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1668AC0", Offset = "0x1668AC0", VA = "0x1668AC0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8C0A8C", Offset = "0x8C0A8C")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1668ACC", Offset = "0x1668ACC", VA = "0x1668ACC", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1668D38", Offset = "0x1668D38", VA = "0x1668D38", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1668DCC", Offset = "0x1668DCC", VA = "0x1668DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1668DD8", Offset = "0x1668DD8", VA = "0x1668DD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1668E64", Offset = "0x1668E64", VA = "0x1668E64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x16682F0", Offset = "0x16682F0", VA = "0x16682F0")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1668EF0", Offset = "0x1668EF0", VA = "0x1668EF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8C0AC4", Offset = "0x8C0AC4")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1668F90", Offset = "0x1668F90", VA = "0x1668F90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1668F94", Offset = "0x1668F94", VA = "0x1668F94")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1669054", Offset = "0x1669054", VA = "0x1669054")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1669158", Offset = "0x1669158", VA = "0x1669158")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1668D08", Offset = "0x1668D08", VA = "0x1668D08")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1668BE4", Offset = "0x1668BE4", VA = "0x1668BE4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1669344", Offset = "0x1669344", VA = "0x1669344")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BF078", Offset = "0x8BF078")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1669570", Offset = "0x1669570", VA = "0x1669570")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1669670", Offset = "0x1669670", VA = "0x1669670")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BF0DC", Offset = "0x8BF0DC")]
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
		[Address(RVA = "0x1669680", Offset = "0x1669680", VA = "0x1669680")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1669740", Offset = "0x1669740", VA = "0x1669740")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1669800", Offset = "0x1669800", VA = "0x1669800")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1669808", Offset = "0x1669808", VA = "0x1669808")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x16698C8", Offset = "0x16698C8", VA = "0x16698C8")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8BF180", Offset = "0x8BF180")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x16698D0", Offset = "0x16698D0", VA = "0x16698D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x16699A4", Offset = "0x16699A4", VA = "0x16699A4")]
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
			[Address(RVA = "0x16699AC", Offset = "0x16699AC", VA = "0x16699AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x16699B4", Offset = "0x16699B4", VA = "0x16699B4")]
			set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x16699F0", Offset = "0x16699F0", VA = "0x16699F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1669A88", Offset = "0x1669A88", VA = "0x1669A88")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x166A144", Offset = "0x166A144", VA = "0x166A144")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C0698", Offset = "0x8C0698")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8C06DC", Offset = "0x8C06DC")]
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
		[Address(RVA = "0x166A168", Offset = "0x166A168", VA = "0x166A168")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x166A9B0", Offset = "0x166A9B0", VA = "0x166A9B0")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8C0760", Offset = "0x8C0760")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x166A9D0", Offset = "0x166A9D0", VA = "0x166A9D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x166AB50", Offset = "0x166AB50", VA = "0x166AB50")]
		public Rotater()
		{
		}
	}
}
