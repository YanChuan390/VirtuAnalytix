using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class HxSimpleRotate : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 RotateSpeed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xC04868", Offset = "0xC04868", VA = "0xC04868")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC04968", Offset = "0xC04968", VA = "0xC04968")]
	public HxSimpleRotate()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class HxDensityVolume : MonoBehaviour
{
	[Token(Token = "0x200003C")]
	public enum DensityShape
	{
		[Token(Token = "0x400026B")]
		Square,
		[Token(Token = "0x400026C")]
		Sphere,
		[Token(Token = "0x400026D")]
		Cylinder
	}

	[Token(Token = "0x200003D")]
	public enum DensityBlendMode
	{
		[Token(Token = "0x400026F")]
		Max,
		[Token(Token = "0x4000270")]
		Add,
		[Token(Token = "0x4000271")]
		Min,
		[Token(Token = "0x4000272")]
		Sub
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static HxOctree<HxDensityVolume> DensityOctree;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private HxOctreeNode<HxDensityVolume>.NodeObject octreeNode;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public DensityShape Shape;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public DensityBlendMode BlendMode;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Vector3 minBounds;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 maxBounds;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Matrix4x4 ToLocalSpace;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float Density;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Color gizmoColor;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Vector3 c1;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Vector3 c2;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static Vector3 c3;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Vector3 c4;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static Vector3 c5;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Vector3 c6;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static Vector3 c7;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Vector3 c8;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC035B8", Offset = "0xC035B8", VA = "0xC035B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC03E90", Offset = "0xC03E90", VA = "0xC03E90")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC03F3C", Offset = "0xC03F3C", VA = "0xC03F3C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xC040E0", Offset = "0xC040E0", VA = "0xC040E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xC04268", Offset = "0xC04268", VA = "0xC04268")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC043F0", Offset = "0xC043F0", VA = "0xC043F0")]
	public void UpdateVolume()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC03810", Offset = "0xC03810", VA = "0xC03810")]
	private void CalculateBounds()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC04554", Offset = "0xC04554", VA = "0xC04554")]
	public HxDensityVolume()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x2E3A0C", Offset = "0x2E3A0C")]
public class HxDummyLight : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public LightType type;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float range;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3DD4", Offset = "0x2E3DD4")]
	public float spotAngle;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color color;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3DF0", Offset = "0x2E3DF0")]
	public float intensity;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Texture cookie;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC047F8", Offset = "0xC047F8", VA = "0xC047F8")]
	public void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xC047FC", Offset = "0xC047FC", VA = "0xC047FC")]
	public HxDummyLight()
	{
	}
}
[Token(Token = "0x2000005")]
public class HxOctree<T>
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3E08", Offset = "0x2E3E08")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4EA4", Offset = "0x2E4EA4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4EB4", Offset = "0x2E4EB4")]
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
	[Token(Token = "0x200003E")]
	public class NodeObject
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HxOctreeNode<T> Node;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMin;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMax;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Center;

		[Token(Token = "0x60001B7")]
		public NodeObject(T value, Vector3 boundsMin, Vector3 boundsMax)
		{
		}
	}

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3E18", Offset = "0x2E3E18")]
	private Vector3 <Origin>k__BackingField;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3E28", Offset = "0x2E3E28")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4EC4", Offset = "0x2E4EC4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4ED4", Offset = "0x2E4ED4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float Size
	{
		[Token(Token = "0x600001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4EE4", Offset = "0x2E4EE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4EF4", Offset = "0x2E4EF4")]
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
	[Token(Token = "0x200003F")]
	public enum hxRenderOrder
	{
		[Token(Token = "0x4000279")]
		ImageEffect,
		[Token(Token = "0x400027A")]
		ImageEffectOpaque
	}

	[Token(Token = "0x2000040")]
	public enum TransparencyQualities
	{
		[Token(Token = "0x400027C")]
		Low,
		[Token(Token = "0x400027D")]
		Medium,
		[Token(Token = "0x400027E")]
		High,
		[Token(Token = "0x400027F")]
		VeryHigh
	}

	[Token(Token = "0x2000041")]
	public enum DensityParticleQualities
	{
		[Token(Token = "0x4000281")]
		Low,
		[Token(Token = "0x4000282")]
		Medium,
		[Token(Token = "0x4000283")]
		High,
		[Token(Token = "0x4000284")]
		VeryHigh
	}

	[Token(Token = "0x2000042")]
	public enum HxAmbientMode
	{
		[Token(Token = "0x4000286")]
		UseRenderSettings,
		[Token(Token = "0x4000287")]
		Color,
		[Token(Token = "0x4000288")]
		Gradient
	}

	[Token(Token = "0x2000043")]
	public enum HxTintMode
	{
		[Token(Token = "0x400028A")]
		Off,
		[Token(Token = "0x400028B")]
		Color,
		[Token(Token = "0x400028C")]
		Edge,
		[Token(Token = "0x400028D")]
		Gradient
	}

	[Token(Token = "0x2000044")]
	public enum Resolution
	{
		[Token(Token = "0x400028F")]
		full,
		[Token(Token = "0x4000290")]
		half,
		[Token(Token = "0x4000291")]
		quarter
	}

	[Token(Token = "0x2000045")]
	public enum DensityResolution
	{
		[Token(Token = "0x4000293")]
		full,
		[Token(Token = "0x4000294")]
		half,
		[Token(Token = "0x4000295")]
		quarter,
		[Token(Token = "0x4000296")]
		eighth
	}

	[Token(Token = "0x2000046")]
	private struct TriangleIndices
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int v1;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int v2;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int v3;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x3B764C", Offset = "0x3B764C", VA = "0x3B764C")]
		public TriangleIndices(int v1, int v2, int v3)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3CD4", Offset = "0x2E3CD4")]
	private sealed class <>c
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Comparison<HxDensityVolume> <>9__229_0;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xC20A30", Offset = "0xC20A30", VA = "0xC20A30")]
		public <>c()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xC20A38", Offset = "0xC20A38", VA = "0xC20A38")]
		internal int <FindActiveLights>b__229_0(HxDensityVolume a, HxDensityVolume b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public hxRenderOrder RenderOrder;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public HxVolumetricRenderCallback callBackImageEffect;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public HxVolumetricRenderCallback callBackImageEffectOpaque;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool ShadowFix;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool TemporalFirst;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool TemporalSampling;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3E38", Offset = "0x2E3E38")]
	public float DitherSpeed;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3E50", Offset = "0x2E3E50")]
	public float LuminanceFeedback;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3E68", Offset = "0x2E3E68")]
	public float MaxFeedback;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3E80", Offset = "0x2E3E80")]
	public float NoiseContrast;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Shader directionalShader;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Shader pointShader;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Shader spotShader;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Shader ProjectorShader;

	[NonSerialized]
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool FullUsed;

	[NonSerialized]
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool LowResUsed;

	[NonSerialized]
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool HeightFogUsed;

	[NonSerialized]
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool HeightFogOffUsed;

	[NonSerialized]
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool NoiseUsed;

	[NonSerialized]
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool NoiseOffUsed;

	[NonSerialized]
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool TransparencyUsed;

	[NonSerialized]
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool TransparencyOffUsed;

	[NonSerialized]
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool DensityParticlesUsed;

	[NonSerialized]
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool PointUsed;

	[NonSerialized]
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool SpotUsed;

	[NonSerialized]
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	public bool ProjectorUsed;

	[NonSerialized]
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool DirectionalUsed;

	[NonSerialized]
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool SinglePassStereoUsed;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static TransparencyQualities TransparencyBufferDepth;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static DensityParticleQualities DensityBufferDepth;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int EnumBufferDepthLength;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Matrix4x4 CurrentView;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Matrix4x4 CurrentProj;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Matrix4x4 CurrentInvers;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Matrix4x4 CurrentView2;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Matrix4x4 CurrentProj2;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Matrix4x4 CurrentInvers2;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private RenderTexture TemporalTexture;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private RenderTargetIdentifier TemporalTextureRTID;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static RenderTexture VolumetricTexture;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static RenderTexture FullBlurRT;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static RenderTargetIdentifier FullBlurRTID;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static RenderTexture downScaledBlurRT;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static RenderTargetIdentifier downScaledBlurRTID;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static RenderTexture FullBlurRT2;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static RenderTargetIdentifier FullBlurRT2ID;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private static RenderTargetIdentifier[] VolumetricUpsampledBlurTextures;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static RenderTexture[] VolumetricDensityTextures;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private static int[] VolumetricDensityPID;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static int[] VolumetricTransparencyPID;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private static RenderTexture[] VolumetricTransparencyTextures;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static RenderTargetIdentifier[][] VolumetricDensity;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public static RenderTargetIdentifier[][] VolumetricTransparency;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static RenderTargetIdentifier[][] VolumetricTransparencyI;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private static RenderTexture[] ScaledDepthTexture;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static ShaderVariantCollection CollectionAll;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public static Texture2D Tile5x5;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static int VolumetricTexturePID;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int ScaledDepthTexturePID;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static int ShadowMapTexturePID;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public static RenderTargetIdentifier VolumetricTextureRTID;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public static RenderTargetIdentifier[] ScaledDepthTextureRTID;

	[NonSerialized]
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public static Material DownSampleMaterial;

	[NonSerialized]
	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static Material VolumeBlurMaterial;

	[NonSerialized]
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public static Material TransparencyBlurMaterial;

	[NonSerialized]
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static Material ApplyMaterial;

	[NonSerialized]
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public static Material ApplyDirectMaterial;

	[NonSerialized]
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static Material ApplyQueueMaterial;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public Texture3D NoiseTexture3D;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public static Matrix4x4 BlitMatrix;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public static Matrix4x4 BlitMatrixMV;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public static Matrix4x4 BlitMatrixMVP;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	public static Vector3 BlitScale;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E3E9C", Offset = "0x2E3E9C")]
	public Resolution resolution;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E3ED0", Offset = "0x2E3ED0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3ED0", Offset = "0x2E3ED0")]
	public int SampleCount;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E3F24", Offset = "0x2E3F24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E3F24", Offset = "0x2E3F24")]
	public int DirectionalSampleCount;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E3F78", Offset = "0x2E3F78")]
	public float MaxDirectionalRayDistance;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E3FD8", Offset = "0x2E3FD8")]
	public float MaxLightDistance;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4040", Offset = "0x2E4040")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4040", Offset = "0x2E4040")]
	public float Density;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4090", Offset = "0x2E4090")]
	public float AmbientLightingStrength;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E40A8", Offset = "0x2E40A8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E40A8", Offset = "0x2E40A8")]
	public float MieScattering;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E40FC", Offset = "0x2E40FC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E40FC", Offset = "0x2E40FC")]
	public float SunSize;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4168", Offset = "0x2E4168")]
	public bool SunBleed;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E419C", Offset = "0x2E419C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E419C", Offset = "0x2E419C")]
	public float Extinction;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E41EC", Offset = "0x2E41EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E41EC", Offset = "0x2E41EC")]
	public float ExtinctionEffect;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	public bool FogHeightEnabled;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public float FogHeight;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	public float FogTransitionSize;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public float AboveFogPercent;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4260", Offset = "0x2E4260")]
	public HxAmbientMode Ambient;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public Color AmbientSky;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Color AmbientEquator;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public Color AmbientGround;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E42BC", Offset = "0x2E42BC")]
	public float AmbientIntensity;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	public HxTintMode TintMode;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public Color TintColor;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public Color TintColor2;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public float TintIntensity;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E42D4", Offset = "0x2E42D4")]
	public float TintGradient;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public Vector3 CurrentTint;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
	public Vector3 CurrentTintEdge;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E42EC", Offset = "0x2E42EC")]
	public bool NoiseEnabled;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4328", Offset = "0x2E4328")]
	public Vector3 NoiseScale;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4374", Offset = "0x2E4374")]
	public Vector3 NoiseVelocity;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E43BC", Offset = "0x2E43BC")]
	public bool ParticleDensitySupport;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4418", Offset = "0x2E4418")]
	public DensityResolution densityResolution;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E444C", Offset = "0x2E444C")]
	public float densityDistance;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private float densityBias;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E449C", Offset = "0x2E449C")]
	public bool TransparencySupport;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E44D0", Offset = "0x2E44D0")]
	public float transparencyDistance;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4504", Offset = "0x2E4504")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4504", Offset = "0x2E4504")]
	public int BlurTransparency;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private float transparencyBias;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4558", Offset = "0x2E4558")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4558", Offset = "0x2E4558")]
	public int blurCount;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E45C4", Offset = "0x2E45C4")]
	public float BlurDepthFalloff;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4630", Offset = "0x2E4630")]
	public float DownsampledBlurDepthFalloff;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4664", Offset = "0x2E4664")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4664", Offset = "0x2E4664")]
	public int UpSampledblurCount;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E46D4", Offset = "0x2E46D4")]
	public float DepthThreshold;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4740", Offset = "0x2E4740")]
	public bool GaussianWeights;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F1")]
	[HideInInspector]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4774", Offset = "0x2E4774")]
	public bool MapToLDR;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F2")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E47EC", Offset = "0x2E47EC")]
	public bool RemoveColorBanding;

	[NonSerialized]
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	public Vector3 Offset;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private static int DepthThresholdPID;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private static int BlurDepthFalloffPID;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private static int VolumeScalePID;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private static int InverseViewMatrixPID;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private static int InverseProjectionMatrixPID;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private static int InverseProjectionMatrix2PID;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private static int NoiseOffsetPID;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private static int ShadowDistancePID;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private static HxVolumetricShadersUsed UsedShaderSettings;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private static List<string> ShaderVariantList;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[HideInInspector]
	public static List<HxDensityVolume> ActiveVolumes;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public static List<HxVolumetricLight> ActiveLights;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public static List<HxVolumetricParticleSystem> ActiveParticleSystems;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	public static HxOctree<HxVolumetricLight> LightOctree;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public static HxOctree<HxVolumetricParticleSystem> ParticleOctree;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	public static HashSet<HxDensityVolume> AllDensityVolumes;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public static HashSet<HxVolumetricLight> AllVolumetricLight;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	public static HashSet<HxVolumetricParticleSystem> AllParticleSystems;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private bool test;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public static Mesh QuadMesh;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	public static Mesh BoxMesh;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public static Mesh SphereMesh;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public static Mesh SpotLightMesh;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public static Mesh OrthoProjectorMesh;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
	[HideInInspector]
	private Camera Mycamera;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private static float[] ResolutionScale;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public static float[] SampleScale;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private CommandBuffer BufferSetup;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
	private CommandBuffer BufferRender;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private CommandBuffer BufferRenderLights;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	private CommandBuffer BufferFinalize;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private bool dirty;

	[NonSerialized]
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	public static bool PIDCreated;

	[NonSerialized]
	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private static Dictionary<int, Material> DirectionalMaterial;

	[NonSerialized]
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private static Dictionary<int, Material> PointMaterial;

	[NonSerialized]
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private static Dictionary<int, Material> SpotMaterial;

	[NonSerialized]
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private static Dictionary<int, Material> ProjectorMaterial;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public static ShaderVariantCollection.ShaderVariant[] DirectionalVariant;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	public static ShaderVariantCollection.ShaderVariant[] PointVariant;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public static ShaderVariantCollection.ShaderVariant[] SpotVariant;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	public static Material ShadowMaterial;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public static Material DensityMaterial;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	[HideInInspector]
	public Matrix4x4 MatrixVP;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	public Matrix4x4 LastMatrixVP;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
	public Matrix4x4 LastMatrixVPInv;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
	public Matrix4x4 LastMatrixVP2;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
	public Matrix4x4 LastMatrixVPInv2;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
	[HideInInspector]
	public Matrix4x4 MatrixV;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
	private bool OffsetUpdated;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	[HideInInspector]
	private static Texture2D _SpotLightCookie;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	[HideInInspector]
	private static Texture2D _LightFalloff;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
	private int ParticleDensityRenderCount;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	private static Matrix4x4 particleMatrix;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
	public static HxVolumetricCamera Active;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public static Camera ActiveCamera;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
	private CameraEvent LightRenderEvent;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	private CameraEvent SetupEvent;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	private CameraEvent RenderEvent;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	private CameraEvent FinalizeEvent;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
	public static List<HxVolumetricLight> ActiveDirectionalLights;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private static Vector3 MinBounds;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	private static Vector3 MaxBounds;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private static Plane[] CameraPlanes;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
	private bool preCullEventAdded;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B5")]
	private bool BuffersBuilt;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B6")]
	private bool LightBufferAdded;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B7")]
	private bool SetupBufferAdded;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
	private bool SetupBufferDirty;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B9")]
	private bool FinalizeBufferAdded;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4BA")]
	private bool FinalizeBufferDirty;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
	private CameraEvent lastApply;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	private CameraEvent lastRender;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
	private CameraEvent lastSetup;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
	private CameraEvent lastFinalize;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
	private CameraEvent lastLightRender;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	private bool LastPlaying;

	[NonSerialized]
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	private static int lastRes;

	[NonSerialized]
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
	private int lastBlurCount;

	[NonSerialized]
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
	private int lastupSampleBlurCount;

	[NonSerialized]
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4DC")]
	private int lastLDR;

	[NonSerialized]
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
	private int lastBanding;

	[NonSerialized]
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E4")]
	private int lastH;

	[NonSerialized]
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
	private int lastW;

	[NonSerialized]
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4EC")]
	private int lastPath;

	[NonSerialized]
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
	private int lastGaussian;

	[NonSerialized]
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F4")]
	private int lastTransparency;

	[NonSerialized]
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
	private int lastDensity;

	[NonSerialized]
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4FC")]
	private int lastDensityRes;

	[NonSerialized]
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
	private float lastDepthFalloff;

	[NonSerialized]
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x504")]
	private float lastDownDepthFalloff;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
	private float currentDitherOffset;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50C")]
	private float MaxLightDistanceUsed;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public static bool FirstDirectional;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
	private static int[] Tile5x5int;

	[Token(Token = "0x17000004")]
	[HideInInspector]
	public Texture2D SpotLightCookie
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0xC0BCD0", Offset = "0xC0BCD0", VA = "0xC0BCD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0xC0BF14", Offset = "0xC0BF14", VA = "0xC0BF14")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	[HideInInspector]
	public Texture2D LightFalloff
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0xC0BFA4", Offset = "0xC0BFA4", VA = "0xC0BFA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0xC0C1E8", Offset = "0xC0C1E8", VA = "0xC0C1E8")]
		set
		{
		}
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xC04970", Offset = "0xC04970", VA = "0xC04970")]
	private void SetUpRenderOrder()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xC04D7C", Offset = "0xC04D7C", VA = "0xC04D7C")]
	public static Material GetDirectionalMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xC05278", Offset = "0xC05278", VA = "0xC05278")]
	public static Material GetProjectorMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xC054E0", Offset = "0xC054E0", VA = "0xC054E0")]
	public static Material GetSpotMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xC05748", Offset = "0xC05748", VA = "0xC05748")]
	public static Material GetPointMaterial(int mid)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xC059B0", Offset = "0xC059B0", VA = "0xC059B0")]
	public TransparencyQualities compatibleTBuffer()
	{
		return default(TransparencyQualities);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xC05AC0", Offset = "0xC05AC0", VA = "0xC05AC0")]
	private bool IsRenderBoth()
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xC05BA0", Offset = "0xC05BA0", VA = "0xC05BA0")]
	private DensityParticleQualities compatibleDBuffer()
	{
		return default(DensityParticleQualities);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xC05C2C", Offset = "0xC05C2C", VA = "0xC05C2C")]
	private void MyPreCull(Camera cam)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xC05EAC", Offset = "0xC05EAC", VA = "0xC05EAC")]
	public bool renderDensityParticleCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xC05EC0", Offset = "0xC05EC0", VA = "0xC05EC0")]
	private void WarmUp()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xC06428", Offset = "0xC06428", VA = "0xC06428")]
	private void CreateShaderVariant(Shader source, int i, ref Material[] material, ref ShaderVariantCollection.ShaderVariant[] Variant, bool point = true)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xC04FE0", Offset = "0xC04FE0", VA = "0xC04FE0")]
	private static void CreateShader(Shader source, int i, out Material outMaterial, bool point = true)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xC06D08", Offset = "0xC06D08", VA = "0xC06D08")]
	private void CreatePIDs()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xC0B3C8", Offset = "0xC0B3C8", VA = "0xC0B3C8")]
	public static bool ActiveFull()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xC0B474", Offset = "0xC0B474", VA = "0xC0B474")]
	private void DefineFull()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xC0B478", Offset = "0xC0B478", VA = "0xC0B478")]
	private static void UpdateLight(HxOctreeNode<HxVolumetricLight>.NodeObject node, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xC0B56C", Offset = "0xC0B56C", VA = "0xC0B56C")]
	public static HxOctreeNode<HxVolumetricLight>.NodeObject AddLightOctree(HxVolumetricLight light, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xC0B780", Offset = "0xC0B780", VA = "0xC0B780")]
	public static HxOctreeNode<HxVolumetricParticleSystem>.NodeObject AddParticleOctree(HxVolumetricParticleSystem particle, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xC0B994", Offset = "0xC0B994", VA = "0xC0B994")]
	public static void RemoveLightOctree(HxVolumetricLight light)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xC0BA90", Offset = "0xC0BA90", VA = "0xC0BA90")]
	public static void RemoveParticletOctree(HxVolumetricParticleSystem Particle)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xC0BB8C", Offset = "0xC0BB8C", VA = "0xC0BB8C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xC0BC1C", Offset = "0xC0BC1C", VA = "0xC0BC1C")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xC0C278", Offset = "0xC0C278", VA = "0xC0C278")]
	private Vector4 CalculateDensityDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xC0C510", Offset = "0xC0C510", VA = "0xC0C510")]
	private Vector4 CalculateTransparencyDistance(int i)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xC0C730", Offset = "0xC0C730", VA = "0xC0C730")]
	private void RenderParticles()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xC0F28C", Offset = "0xC0F28C", VA = "0xC0F28C")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xC0E018", Offset = "0xC0E018", VA = "0xC0E018")]
	private int RenderSlices()
	{
		return default(int);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xC0F2EC", Offset = "0xC0F2EC", VA = "0xC0F2EC")]
	private int GetCamPixelHeight()
	{
		return default(int);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xC0F3E8", Offset = "0xC0F3E8", VA = "0xC0F3E8")]
	private int GetCamPixelWidth()
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xC0F588", Offset = "0xC0F588", VA = "0xC0F588")]
	private void CreateTempTextures()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xC0CFE8", Offset = "0xC0CFE8", VA = "0xC0CFE8")]
	public static void ConstructPlanes(Camera cam, float near, float far)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xC11068", Offset = "0xC11068", VA = "0xC11068")]
	private void FindActiveLights()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xC0DEA0", Offset = "0xC0DEA0", VA = "0xC0DEA0")]
	private void FindActiveParticleSystems()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xC11588", Offset = "0xC11588", VA = "0xC11588")]
	public void Update()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xC11BB4", Offset = "0xC11BB4", VA = "0xC11BB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xC11CAC", Offset = "0xC11CAC", VA = "0xC11CAC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xC11DA4", Offset = "0xC11DA4", VA = "0xC11DA4")]
	private void CreateApplyBuffer()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xC11DA8", Offset = "0xC11DA8", VA = "0xC11DA8")]
	private void CreateSetupBuffer()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xC12398", Offset = "0xC12398", VA = "0xC12398")]
	private bool CheckBufferDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xC125C8", Offset = "0xC125C8", VA = "0xC125C8")]
	private void CreateFinalizeBuffer()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xC16DE4", Offset = "0xC16DE4", VA = "0xC16DE4")]
	private void BuildBuffer()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xC1C13C", Offset = "0xC1C13C", VA = "0xC1C13C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xC1C570", Offset = "0xC1C570", VA = "0xC1C570")]
	private void SaveUsedShaderVarience()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xC1C574", Offset = "0xC1C574", VA = "0xC1C574")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xC1A9F0", Offset = "0xC1A9F0", VA = "0xC1A9F0")]
	private void CalculateEvent()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xC1C9B0", Offset = "0xC1C9B0", VA = "0xC1C9B0")]
	public void EventOnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xC1CABC", Offset = "0xC1CABC", VA = "0xC1CABC")]
	private int ScalePass()
	{
		return default(int);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xC1CADC", Offset = "0xC1CADC", VA = "0xC1CADC")]
	private void DownSampledFullBlur(RenderTexture mainColor, RenderBuffer NewColor, RenderBuffer depth, int pass)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xC1AB28", Offset = "0xC1AB28", VA = "0xC1AB28")]
	private void CheckTemporalTextures()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xC1ADA4", Offset = "0xC1ADA4", VA = "0xC1ADA4")]
	public static void ReleaseTempTextures()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xC1CCD4", Offset = "0xC1CCD4", VA = "0xC1CCD4")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xC1CDA0", Offset = "0xC1CDA0", VA = "0xC1CDA0")]
	private void UpdateLightPoistions()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xC1D1A8", Offset = "0xC1D1A8", VA = "0xC1D1A8")]
	private void UpdateParticlePoistions()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xC1EF20", Offset = "0xC1EF20", VA = "0xC1EF20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xC1F0A8", Offset = "0xC1F0A8", VA = "0xC1F0A8")]
	private void start()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xC05D10", Offset = "0xC05D10", VA = "0xC05D10")]
	public void ReleaseLightBuffers()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xC1BBA0", Offset = "0xC1BBA0", VA = "0xC1BBA0")]
	private void CreateLightbuffers()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xC0876C", Offset = "0xC0876C", VA = "0xC0876C")]
	private static void CreateTileTexture()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xC0AFE8", Offset = "0xC0AFE8", VA = "0xC0AFE8")]
	public static Mesh CreateOrtho(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xC0A6AC", Offset = "0xC0A6AC", VA = "0xC0A6AC")]
	public static Mesh CreateCone(int sides, bool inner = true)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xC08C98", Offset = "0xC08C98", VA = "0xC08C98")]
	public static Mesh CreateQuad()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xC09000", Offset = "0xC09000", VA = "0xC09000")]
	public static Mesh CreateBox()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xC09120", Offset = "0xC09120", VA = "0xC09120")]
	public static Mesh CreateIcoSphere(int recursionLevel, float radius)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xC1F38C", Offset = "0xC1F38C", VA = "0xC1F38C")]
	private static int getMiddlePoint(int p1, int p2, ref List<Vector3> vertices, ref Dictionary<long, int> cache, float radius)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xC08380", Offset = "0xC08380", VA = "0xC08380")]
	public void Create3DNoiseTexture()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xC1F62C", Offset = "0xC1F62C", VA = "0xC1F62C")]
	private int PostoIndex(Vector3 pos)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xC1F6D0", Offset = "0xC1F6D0", VA = "0xC1F6D0")]
	public HxVolumetricCamera()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class HxVolumetricImageEffect : HxVolumetricRenderCallback
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0xC20A94", Offset = "0xC20A94", VA = "0xC20A94")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xC20B4C", Offset = "0xC20B4C", VA = "0xC20B4C")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xC20CB8", Offset = "0xC20CB8", VA = "0xC20CB8")]
	public HxVolumetricImageEffect()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
public class HxVolumetricImageEffectOpaque : HxVolumetricRenderCallback
{
	[Token(Token = "0x6000081")]
	[Address(RVA = "0xC20CC0", Offset = "0xC20CC0", VA = "0xC20CC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xC20D78", Offset = "0xC20D78", VA = "0xC20D78")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xC20EE4", Offset = "0xC20EE4", VA = "0xC20EE4")]
	public HxVolumetricImageEffectOpaque()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class HxVolumetricLight : MonoBehaviour
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float ShadowDistanceExtra;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Light myLight;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private HxDummyLight myDummyLight;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Texture3D NoiseTexture3D;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CommandBuffer BufferRender;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CommandBuffer BufferCopy;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Projector myProjector;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 NoiseScale;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 NoiseVelocity;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool dirty;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture LightFalloff;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float NearPlane;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool NoiseEnabled;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool CustomMieScatter;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool CustomExtinction;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	public bool CustomExtinctionEffect;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool CustomDensity;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool CustomSampleCount;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool CustomColor;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	public bool CustomNoiseEnabled;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool CustomNoiseTexture;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool CustomNoiseScale;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool CustomNoiseVelocity;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool CustomNoiseContrast;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool CustomFogHeightEnabled;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool CustomFogHeight;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool CustomFogTransitionSize;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
	public bool CustomAboveFogPercent;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool CustomSunSize;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool CustomSunBleed;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool ShadowCasting;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	public bool CustomStrength;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool CustomIntensity;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool CustomTintMode;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	public bool CustomTintColor;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	public bool CustomTintColor2;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool CustomTintGradient;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool CustomTintIntensity;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool CustomMaxLightDistance;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4880", Offset = "0x2E4880")]
	public float NoiseContrast;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public HxVolumetricCamera.HxTintMode TintMode;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color TintColor;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Color TintColor2;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float TintIntensity;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E489C", Offset = "0x2E489C")]
	public float TintGradient;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E48B4", Offset = "0x2E48B4")]
	public float Intensity;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E48CC", Offset = "0x2E48CC")]
	public float Strength;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Color Color;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E48E4", Offset = "0x2E48E4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E48E4", Offset = "0x2E48E4")]
	public float MieScattering;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4938", Offset = "0x2E4938")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4938", Offset = "0x2E4938")]
	public float SunSize;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E49A4", Offset = "0x2E49A4")]
	public bool SunBleed;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E49D8", Offset = "0x2E49D8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E49D8", Offset = "0x2E49D8")]
	public float Extinction;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4A2C", Offset = "0x2E4A2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4A2C", Offset = "0x2E4A2C")]
	public float Density;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4A7C", Offset = "0x2E4A7C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4A7C", Offset = "0x2E4A7C")]
	public float ExtraDensity;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4B00", Offset = "0x2E4B00")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4B00", Offset = "0x2E4B00")]
	public int SampleCount;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2E4B54", Offset = "0x2E4B54")]
	public bool Shadows;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool FogHeightEnabled;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float FogHeight;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float FogTransitionSize;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float MaxLightDistance;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float AboveFogPercent;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool OffsetUpdated;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Vector3 Offset;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static MaterialPropertyBlock propertyBlock;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool bufferBuilt;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int VolumetricBMVPPID;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int VolumetricMVPPID;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int VolumetricMVP2PID;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int VolumetricMVPID;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int LightColourPID;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int LightColour2PID;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int FogHeightsPID;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static int PhasePID;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int _LightParamsPID;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static int DensityPID;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int ShadowBiasPID;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int _CustomLightPositionPID;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int hxNearPlanePID;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int NoiseScalePID;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int NoiseOffsetPID;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int _SpotLightParamsPID;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int _LightTexture0PID;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static int _hxProjectorTexturePID;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static int _hxProjectorFalloffTexturePID;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
	private bool LastBufferDirectional;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float LastSpotAngle;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float LastRange;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float LastAspect;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private LightType lastType;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Matrix4x4 LightMatrix;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Bounds lastBounds;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector3 minBounds;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private Vector3 maxBounds;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private HxOctreeNode<HxVolumetricLight>.NodeObject octreeNode;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private Vector4 TopFrustumNormal;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Vector4 BottomFrustumNormal;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private Vector4 LeftFrustumNormal;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private Vector4 RightFrustumNormal;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static Matrix4x4[] VolumeMatrixArrays;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static Vector4[] VolumeSettingsArrays;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static Matrix4x4[] VolumeMatrixArraysOld;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Vector4[] VolumeSettingsArraysOld;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private float LastOrthoSize;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool LastOrtho;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
	private bool matrixReconstruct;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xC20EEC", Offset = "0xC20EEC", VA = "0xC20EEC")]
	public Light LightSafe()
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xC20FA0", Offset = "0xC20FA0", VA = "0xC20FA0")]
	public HxDummyLight DummyLightSafe()
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xC21054", Offset = "0xC21054", VA = "0xC21054")]
	private LightType GetLightType()
	{
		return default(LightType);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xC21174", Offset = "0xC21174", VA = "0xC21174")]
	private LightShadows LightShadow()
	{
		return default(LightShadows);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xC2122C", Offset = "0xC2122C", VA = "0xC2122C")]
	private bool HasLight()
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xC21304", Offset = "0xC21304", VA = "0xC21304")]
	private Texture LightCookie()
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xC21424", Offset = "0xC21424", VA = "0xC21424")]
	private Texture LightFalloffTexture()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xC21514", Offset = "0xC21514", VA = "0xC21514")]
	private float LightShadowBias()
	{
		return default(float);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xC215E8", Offset = "0xC215E8", VA = "0xC215E8")]
	private Color LightColor()
	{
		return default(Color);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xC21870", Offset = "0xC21870", VA = "0xC21870")]
	private float LightSpotAngle()
	{
		return default(float);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xC21A00", Offset = "0xC21A00", VA = "0xC21A00")]
	private bool LightEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xC21C88", Offset = "0xC21C88", VA = "0xC21C88")]
	private float LightRange()
	{
		return default(float);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xC21E1C", Offset = "0xC21E1C", VA = "0xC21E1C")]
	private float LightShadowStrength()
	{
		return default(float);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xC21ED4", Offset = "0xC21ED4", VA = "0xC21ED4")]
	private float LightIntensity()
	{
		return default(float);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xC22048", Offset = "0xC22048", VA = "0xC22048")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xC2224C", Offset = "0xC2224C", VA = "0xC2224C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xC223BC", Offset = "0xC223BC", VA = "0xC223BC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xC22524", Offset = "0xC22524", VA = "0xC22524")]
	private void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xC1F240", Offset = "0xC1F240", VA = "0xC1F240")]
	public void BuildBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xC1F110", Offset = "0xC1F110", VA = "0xC1F110")]
	public void ReleaseBuffer()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xC08430", Offset = "0xC08430", VA = "0xC08430")]
	public static void CreatePID()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xC2AC84", Offset = "0xC2AC84", VA = "0xC2AC84")]
	private float LightNearPlane()
	{
		return default(float);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xC2AD44", Offset = "0xC2AD44", VA = "0xC2AD44")]
	private int DirectionalPass(CommandBuffer buffer)
	{
		return default(int);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xC2B4C4", Offset = "0xC2B4C4", VA = "0xC2B4C4")]
	private float getContrast()
	{
		return default(float);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xC2B580", Offset = "0xC2B580", VA = "0xC2B580")]
	private bool ShaderModel4()
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xC225A8", Offset = "0xC225A8", VA = "0xC225A8")]
	private void BuildDirectionalBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xC2BE60", Offset = "0xC2BE60", VA = "0xC2BE60")]
	private void LoadVolumeDateIntoBuffer(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xC2CCD4", Offset = "0xC2CCD4", VA = "0xC2CCD4")]
	private float CalcLightInstensityDistance(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xC24508", Offset = "0xC24508", VA = "0xC24508")]
	private void BuildSpotLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xC28BA8", Offset = "0xC28BA8", VA = "0xC28BA8")]
	private void BuildProjectorLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xC2D600", Offset = "0xC2D600", VA = "0xC2D600")]
	private void SetColors(CommandBuffer buffer, float distanceLerp)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xC2BF80", Offset = "0xC2BF80", VA = "0xC2BF80")]
	private void SetColors(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xC2E778", Offset = "0xC2E778", VA = "0xC2E778")]
	private Vector3 CalcTintColor(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xC2EB18", Offset = "0xC2EB18", VA = "0xC2EB18")]
	private Vector3 CalcTintColorEdge(Vector4 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xC268B8", Offset = "0xC268B8", VA = "0xC268B8")]
	private void BuildPointBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xC2C938", Offset = "0xC2C938", VA = "0xC2C938")]
	public int MID(bool RenderShadows, bool full)
	{
		return default(int);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xC2EEB8", Offset = "0xC2EEB8", VA = "0xC2EEB8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xC2B5A8", Offset = "0xC2B5A8", VA = "0xC2B5A8")]
	private float GetFogDensity()
	{
		return default(float);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xC2CB9C", Offset = "0xC2CB9C", VA = "0xC2CB9C")]
	private Texture3D GetNoiseTexture()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xC2C7E0", Offset = "0xC2C7E0", VA = "0xC2C7E0")]
	private int GetSampleCount(bool RenderShadows)
	{
		return default(int);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xC2EEC4", Offset = "0xC2EEC4", VA = "0xC2EEC4")]
	public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xC2CE54", Offset = "0xC2CE54", VA = "0xC2CE54")]
	private float ClosestDistanceToCone(Vector3 Point)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xC2F11C", Offset = "0xC2F11C", VA = "0xC2F11C")]
	private void UpdateLightMatrix()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xC2F7C8", Offset = "0xC2F7C8", VA = "0xC2F7C8")]
	private void CheckLightType()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xC2B670", Offset = "0xC2B670", VA = "0xC2B670")]
	private void LoadVolumeData()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xC2F984", Offset = "0xC2F984", VA = "0xC2F984")]
	private bool BoundsIntersect(HxDensityVolume vol)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xC2DF00", Offset = "0xC2DF00", VA = "0xC2DF00")]
	private void LoadVolumeDataBounds()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xC2FA30", Offset = "0xC2FA30", VA = "0xC2FA30")]
	private Vector4 NormalOfTriangle(Vector3 a, Vector3 b, Vector3 c)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xC2FB70", Offset = "0xC2FB70", VA = "0xC2FB70")]
	private void DrawIntersect()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xC308FC", Offset = "0xC308FC", VA = "0xC308FC")]
	private float GetAspect()
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xC309B4", Offset = "0xC309B4", VA = "0xC309B4")]
	private float GetOrthoSize()
	{
		return default(float);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xC30A6C", Offset = "0xC30A6C", VA = "0xC30A6C")]
	private bool GetOrtho()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xC1D398", Offset = "0xC1D398", VA = "0xC1D398")]
	public void UpdatePosition(bool first = false)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xC30B24", Offset = "0xC30B24", VA = "0xC30B24")]
	public void DrawBounds()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xC311D0", Offset = "0xC311D0", VA = "0xC311D0")]
	public HxVolumetricLight()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
public class HxVolumetricParticleSystem : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	public enum ParticleBlendMode
	{
		[Token(Token = "0x400029D")]
		Max,
		[Token(Token = "0x400029E")]
		Add,
		[Token(Token = "0x400029F")]
		Min,
		[Token(Token = "0x40002A0")]
		Sub
	}

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2E4B88", Offset = "0x2E4B88")]
	public float DensityStrength;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private HxOctreeNode<HxVolumetricParticleSystem>.NodeObject octreeNode;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public Renderer particleRenderer;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleBlendMode BlendMode;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 minBounds;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 maxBounds;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Bounds LastBounds;

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x10D7B70", Offset = "0x10D7B70", VA = "0x10D7B70")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x10D7D10", Offset = "0x10D7D10", VA = "0x10D7D10")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x10D7EEC", Offset = "0x10D7EEC", VA = "0x10D7EEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x10D7FC8", Offset = "0x10D7FC8", VA = "0x10D7FC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x10D80A4", Offset = "0x10D80A4", VA = "0x10D80A4")]
	public HxVolumetricParticleSystem()
	{
	}
}
[Token(Token = "0x200000C")]
public class HxVolumetricRenderCallback : MonoBehaviour
{
	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected HxVolumetricCamera volumetricCamera;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public HxVolumetricCamera.hxRenderOrder RenderOrder;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x10D80BC", Offset = "0x10D80BC", VA = "0x10D80BC")]
	public HxVolumetricRenderCallback()
	{
	}
}
[Token(Token = "0x200000D")]
public class HxVolumetricShadersUsed : ScriptableObject
{
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public HxVolumetricCamera.TransparencyQualities TransperencyQuality;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public HxVolumetricCamera.DensityParticleQualities DensityParticleQuality;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public HxVolumetricCamera.DensityParticleQualities LastDensityParticleQuality;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public HxVolumetricCamera.TransparencyQualities LastTransperencyQuality;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HxVolumetricShadersUsed instance;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool Full;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool LowRes;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool HeightFog;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool HeightFogOff;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool Noise;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool NoiseOff;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool Transparency;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool TransparencyOff;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool DensityParticles;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool Point;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool Spot;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool Directional;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool SinglePassStereo;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool Projector;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	[HideInInspector]
	public bool FullLast;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	[HideInInspector]
	public bool LowResLast;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public bool HeightFogLast;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[HideInInspector]
	public bool HeightFogOffLast;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	[HideInInspector]
	public bool NoiseLast;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	[HideInInspector]
	public bool NoiseOffLast;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool TransparencyLast;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[HideInInspector]
	public bool TransparencyOffLast;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[HideInInspector]
	public bool DensityParticlesLast;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	[HideInInspector]
	public bool PointLast;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool SpotLast;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[HideInInspector]
	public bool DirectionalLast;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[HideInInspector]
	public bool SinglePassStereoLast;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	[HideInInspector]
	public bool ProjectorLast;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x10D80C4", Offset = "0x10D80C4", VA = "0x10D80C4")]
	private bool CheckDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x10D83F8", Offset = "0x10D83F8", VA = "0x10D83F8")]
	public HxVolumetricShadersUsed()
	{
	}
}
[Token(Token = "0x200000E")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected Image _image;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xC02C28", Offset = "0xC02C28", VA = "0xC02C28")]
	public void Start()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xC02E54", Offset = "0xC02E54", VA = "0xC02E54", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xC0338C", Offset = "0xC0338C", VA = "0xC0338C")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x200000F")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xC03394", Offset = "0xC03394", VA = "0xC03394")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xC034E0", Offset = "0xC034E0", VA = "0xC034E0")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x2E3AD4", Offset = "0x2E3AD4")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xC034E8", Offset = "0xC034E8", VA = "0xC034E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xC035B0", Offset = "0xC035B0", VA = "0xC035B0")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000011")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum Mode
		{
			[Token(Token = "0x40002A2")]
			Trigger,
			[Token(Token = "0x40002A3")]
			Replace,
			[Token(Token = "0x40002A4")]
			Activate,
			[Token(Token = "0x40002A5")]
			Enable,
			[Token(Token = "0x40002A6")]
			Animate,
			[Token(Token = "0x40002A7")]
			Deactivate
		}

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Mode action;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object target;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GameObject source;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int triggerCount;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool repeatTrigger;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x10E0710", Offset = "0x10E0710", VA = "0x10E0710")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x10E0C64", Offset = "0x10E0C64", VA = "0x10E0C64")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x10E0C68", Offset = "0x10E0C68", VA = "0x10E0C68")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200004A")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Shader original;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Shader replacement;

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x10E1C28", Offset = "0x10E1C28", VA = "0x10E1C28")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004B")]
		public class ReplacementList
		{
			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x10E1C30", Offset = "0x10E1C30", VA = "0x10E1C30")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x10E0C80", Offset = "0x10E0C80", VA = "0x10E0C80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x10E1C20", Offset = "0x10E1C20", VA = "0x10E1C20")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200004C")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 value;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Space space;

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x10E1E9C", Offset = "0x10E1E9C", VA = "0x10E1E9C")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool ignoreTimescale;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_LastRealTime;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x10E1CA4", Offset = "0x10E1CA4", VA = "0x10E1CA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x10E1CC0", Offset = "0x10E1CC0", VA = "0x10E1CC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x10E1E94", Offset = "0x10E1E94", VA = "0x10E1E94")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class CameraRefocus
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Camera Camera;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Parent;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Refocus;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x10E1EAC", Offset = "0x10E1EAC", VA = "0x10E1EAC")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x10E1EEC", Offset = "0x10E1EEC", VA = "0x10E1EEC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x10E1EF4", Offset = "0x10E1EF4", VA = "0x10E1EF4")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x10E1EFC", Offset = "0x10E1EFC", VA = "0x10E1EFC")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x10E20A0", Offset = "0x10E20A0", VA = "0x10E20A0")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float HorizontalBobRange;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float VerticalBobRange;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_CyclePositionX;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_CyclePositionY;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Time;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x10E2120", Offset = "0x10E2120", VA = "0x10E2120")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x10E2220", Offset = "0x10E2220", VA = "0x10E2220")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x10E2368", Offset = "0x10E2368", VA = "0x10E2368")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3CE4", Offset = "0x2E3CE4")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float distance;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0x10E30F0", Offset = "0x10E30F0", VA = "0x10E30F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x10E3180", Offset = "0x10E3180", VA = "0x10E3180", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x10E2CD0", Offset = "0x10E2CD0", VA = "0x10E2CD0")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x10E2CF8", Offset = "0x10E2CF8", VA = "0x10E2CF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x10E2CFC", Offset = "0x10E2CFC", VA = "0x10E2CFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x10E30F8", Offset = "0x10E30F8", VA = "0x10E30F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		private const float k_Spring = 50f;

		[Token(Token = "0x40001B2")]
		private const float k_Damper = 5f;

		[Token(Token = "0x40001B3")]
		private const float k_Drag = 10f;

		[Token(Token = "0x40001B4")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x40001B5")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x40001B6")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x10E2640", Offset = "0x10E2640", VA = "0x10E2640")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x10E2C1C", Offset = "0x10E2C1C", VA = "0x10E2C1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E4F14", Offset = "0x2E4F14")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x10E2B50", Offset = "0x10E2B50", VA = "0x10E2B50")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x10E2CF0", Offset = "0x10E2CF0", VA = "0x10E2CF0")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Light sunLight;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minHeight;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float minShadowDistance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minShadowBias;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxHeight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxShadowDistance;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxShadowBias;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float adaptTime;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_SmoothHeight;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_ChangeSpeed;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_OriginalStrength;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x10E3188", Offset = "0x10E3188", VA = "0x10E3188")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x10E31BC", Offset = "0x10E31BC", VA = "0x10E31BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x10E3518", Offset = "0x10E3518", VA = "0x10E3518")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x10E3F20", Offset = "0x10E3F20", VA = "0x10E3F20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x10E4028", Offset = "0x10E4028", VA = "0x10E4028")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class FOVKick
	{
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3CF4", Offset = "0x2E3CF4")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FOVKick <>4__this;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x10E3CF4", Offset = "0x10E3CF4", VA = "0x10E3CF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x10E3D84", Offset = "0x10E3D84", VA = "0x10E3D84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x10E3768", Offset = "0x10E3768", VA = "0x10E3768")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x10E3B18", Offset = "0x10E3B18", VA = "0x10E3B18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x10E3B1C", Offset = "0x10E3B1C", VA = "0x10E3B1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x10E3CFC", Offset = "0x10E3CFC", VA = "0x10E3CFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D04", Offset = "0x2E3D04")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FOVKick <>4__this;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x10E3A80", Offset = "0x10E3A80", VA = "0x10E3A80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x10E3B10", Offset = "0x10E3B10", VA = "0x10E3B10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x10E3814", Offset = "0x10E3814", VA = "0x10E3814")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x10E3854", Offset = "0x10E3854", VA = "0x10E3854", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x10E3858", Offset = "0x10E3858", VA = "0x10E3858", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x10E3A88", Offset = "0x10E3A88", VA = "0x10E3A88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Camera Camera;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float FOVIncrease;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float TimeToIncrease;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float TimeToDecrease;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x10E3560", Offset = "0x10E3560", VA = "0x10E3560")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x10E359C", Offset = "0x10E359C", VA = "0x10E359C")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x10E36D4", Offset = "0x10E36D4", VA = "0x10E36D4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x10E36DC", Offset = "0x10E36DC", VA = "0x10E36DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E4F8C", Offset = "0x2E4F8C")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x10E3788", Offset = "0x10E3788", VA = "0x10E3788")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E5004", Offset = "0x2E5004")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10E3834", Offset = "0x10E3834", VA = "0x10E3834")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2E3B4C", Offset = "0x2E3B4C")]
	public class FPSCounterTMP : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int m_FpsAccumulator;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_CurrentFps;

		[Token(Token = "0x40001CF")]
		private const string display = "{0} FPS";

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_Text;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x10E3D8C", Offset = "0x10E3D8C", VA = "0x10E3D8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x10E3E0C", Offset = "0x10E3E0C", VA = "0x10E3E0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x10E3F18", Offset = "0x10E3F18", VA = "0x10E3F18")]
		public FPSCounterTMP()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D14", Offset = "0x2E3D14")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x10E43BC", Offset = "0x10E43BC", VA = "0x10E43BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x10E444C", Offset = "0x10E444C", VA = "0x10E444C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x10E411C", Offset = "0x10E411C", VA = "0x10E411C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x10E4144", Offset = "0x10E4144", VA = "0x10E4144", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x10E4148", Offset = "0x10E4148", VA = "0x10E4148", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x10E43C4", Offset = "0x10E43C4", VA = "0x10E43C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float BobDuration;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float BobAmount;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_Offset;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10E4088", Offset = "0x10E4088", VA = "0x10E4088")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10E4090", Offset = "0x10E4090", VA = "0x10E4090")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E507C", Offset = "0x2E507C")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10E413C", Offset = "0x10E413C", VA = "0x10E413C")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D24", Offset = "0x2E3D24")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delay;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000015")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x10E49C8", Offset = "0x10E49C8", VA = "0x10E49C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x10E4A58", Offset = "0x10E4A58", VA = "0x10E4A58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x10E4650", Offset = "0x10E4650", VA = "0x10E4650")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x10E4678", Offset = "0x10E4678", VA = "0x10E4678", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x10E467C", Offset = "0x10E467C", VA = "0x10E467C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x10E49D0", Offset = "0x10E49D0", VA = "0x10E49D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vector3 originalPosition;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Quaternion originalRotation;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Transform> originalStructure;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10E4454", Offset = "0x10E4454", VA = "0x10E4454")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10DF7BC", Offset = "0x10DF7BC", VA = "0x10DF7BC")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x10E459C", Offset = "0x10E459C", VA = "0x10E459C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E50F4", Offset = "0x2E50F4")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x10E4670", Offset = "0x10E4670", VA = "0x10E4670")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D34", Offset = "0x2E3D34")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x10E4FA4", Offset = "0x10E4FA4", VA = "0x10E4FA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x10E5034", Offset = "0x10E5034", VA = "0x10E5034", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x10E4AEC", Offset = "0x10E4AEC", VA = "0x10E4AEC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x10E4B34", Offset = "0x10E4B34", VA = "0x10E4B34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x10E4B38", Offset = "0x10E4B38", VA = "0x10E4B38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x10E4FAC", Offset = "0x10E4FAC", VA = "0x10E4FAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float minDuration;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float maxDuration;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_MaxLifetime;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_EarlyStop;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x10E4A60", Offset = "0x10E4A60", VA = "0x10E4A60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E516C", Offset = "0x2E516C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x10E4B0C", Offset = "0x10E4B0C", VA = "0x10E4B0C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10E4B18", Offset = "0x10E4B18", VA = "0x10E4B18")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40002CA")]
			Standalone,
			[Token(Token = "0x40002CB")]
			Mobile
		}

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x10E503C", Offset = "0x10E503C", VA = "0x10E503C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x10E5040", Offset = "0x10E5040", VA = "0x10E5040")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10E5054", Offset = "0x10E5054", VA = "0x10E5054")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10E554C", Offset = "0x10E554C", VA = "0x10E554C")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GUIText camSwitchButton;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject[] objects;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10E55DC", Offset = "0x10E55DC", VA = "0x10E55DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10E5668", Offset = "0x10E5668", VA = "0x10E5668")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10E57B4", Offset = "0x10E57B4", VA = "0x10E57B4")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector2 rotationRange;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationSpeed;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float dampingTime;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool relative;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10E57BC", Offset = "0x10E57BC", VA = "0x10E57BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10E5814", Offset = "0x10E5814", VA = "0x10E5814")]
		private void Update()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10E5CA0", Offset = "0x10E5CA0", VA = "0x10E5CA0")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float height;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x10E5D98", Offset = "0x10E5D98", VA = "0x10E5D98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x10E5D9C", Offset = "0x10E5D9C", VA = "0x10E5D9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x10E623C", Offset = "0x10E623C", VA = "0x10E623C")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		public enum Action
		{
			[Token(Token = "0x40002CD")]
			Activate,
			[Token(Token = "0x40002CE")]
			Deactivate,
			[Token(Token = "0x40002CF")]
			Destroy,
			[Token(Token = "0x40002D0")]
			ReloadLevel,
			[Token(Token = "0x40002D1")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000055")]
		public class Entry
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject target;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Action action;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delay;

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x10E6B18", Offset = "0x10E6B18", VA = "0x10E6B18")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000056")]
		public class Entries
		{
			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Entry[] entries;

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x10E6644", Offset = "0x10E6644", VA = "0x10E6644")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D44", Offset = "0x2E3D44")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry entry;

			[Token(Token = "0x17000019")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x10E6750", Offset = "0x10E6750", VA = "0x10E6750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x10E67E0", Offset = "0x10E67E0", VA = "0x10E67E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x10E6568", Offset = "0x10E6568", VA = "0x10E6568")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x10E664C", Offset = "0x10E664C", VA = "0x10E664C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x10E6650", Offset = "0x10E6650", VA = "0x10E6650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x10E6758", Offset = "0x10E6758", VA = "0x10E6758", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D54", Offset = "0x2E3D54")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry entry;

			[Token(Token = "0x1700001B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x10E68EC", Offset = "0x10E68EC", VA = "0x10E68EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F0")]
				[Address(RVA = "0x10E697C", Offset = "0x10E697C", VA = "0x10E697C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x10E6588", Offset = "0x10E6588", VA = "0x10E6588")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x10E67E8", Offset = "0x10E67E8", VA = "0x10E67E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x10E67EC", Offset = "0x10E67EC", VA = "0x10E67EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x10E68F4", Offset = "0x10E68F4", VA = "0x10E68F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D64", Offset = "0x2E3D64")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry entry;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x10E6A80", Offset = "0x10E6A80", VA = "0x10E6A80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x10E6B10", Offset = "0x10E6B10", VA = "0x10E6B10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x10E65A8", Offset = "0x10E65A8", VA = "0x10E65A8")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x10E6984", Offset = "0x10E6984", VA = "0x10E6984", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x10E6988", Offset = "0x10E6988", VA = "0x10E6988", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x10E6A88", Offset = "0x10E6A88", VA = "0x10E6A88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Entries entries;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x10E625C", Offset = "0x10E625C", VA = "0x10E625C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x10E63C4", Offset = "0x10E63C4", VA = "0x10E63C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E51E4", Offset = "0x2E51E4")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10E6450", Offset = "0x10E6450", VA = "0x10E6450")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E525C", Offset = "0x2E525C")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x10E64DC", Offset = "0x10E64DC", VA = "0x10E64DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E52D4", Offset = "0x2E52D4")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10E65C8", Offset = "0x10E65C8", VA = "0x10E65C8")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x10E6B20", Offset = "0x10E6B20", VA = "0x10E6B20")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10E6B8C", Offset = "0x10E6B8C", VA = "0x10E6B8C")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10E6C58", Offset = "0x10E6C58", VA = "0x10E6C58")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005A")]
		public class WaypointList
		{
			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform[] items;

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x10E813C", Offset = "0x10E813C", VA = "0x10E813C")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200005B")]
		public struct RoutePoint
		{
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x3C2908", Offset = "0x3C2908", VA = "0x3C2908")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WaypointList waypointList;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int numPoints;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] points;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float[] distances;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4DA4", Offset = "0x2E4DA4")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int p0n;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int p1n;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int p2n;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int p3n;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float i;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 P0;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 P1;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P2;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P3;

		[Token(Token = "0x17000006")]
		public float Length
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x10E6C68", Offset = "0x10E6C68", VA = "0x10E6C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E534C", Offset = "0x2E534C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x10E6C70", Offset = "0x10E6C70", VA = "0x10E6C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E535C", Offset = "0x2E535C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x10E6C78", Offset = "0x10E6C78", VA = "0x10E6C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10E6C9C", Offset = "0x10E6C9C", VA = "0x10E6C9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10E7224", Offset = "0x10E7224", VA = "0x10E7224")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x10E7344", Offset = "0x10E7344", VA = "0x10E7344")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x10E788C", Offset = "0x10E788C", VA = "0x10E788C")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x10E6D14", Offset = "0x10E6D14", VA = "0x10E6D14")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x10E7C68", Offset = "0x10E7C68", VA = "0x10E7C68")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x10E80A8", Offset = "0x10E80A8", VA = "0x10E80A8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10E7C70", Offset = "0x10E7C70", VA = "0x10E7C70")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10E80B0", Offset = "0x10E80B0", VA = "0x10E80B0")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40002E4")]
			SmoothAlongRoute,
			[Token(Token = "0x40002E5")]
			PointToPoint
		}

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E24", Offset = "0x2E4E24")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E34", Offset = "0x2E4E34")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E44", Offset = "0x2E4E44")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform target;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float progressDistance;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int progressNum;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float speed;

		[Token(Token = "0x17000008")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x10E81B0", Offset = "0x10E81B0", VA = "0x10E81B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E536C", Offset = "0x2E536C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x10E81C8", Offset = "0x10E81C8", VA = "0x10E81C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E537C", Offset = "0x2E537C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x10E81EC", Offset = "0x10E81EC", VA = "0x10E81EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E538C", Offset = "0x2E538C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x10E8204", Offset = "0x10E8204", VA = "0x10E8204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E539C", Offset = "0x2E539C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x10E8228", Offset = "0x10E8228", VA = "0x10E8228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E53AC", Offset = "0x2E53AC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x10E8240", Offset = "0x10E8240", VA = "0x10E8240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E53BC", Offset = "0x2E53BC")]
			private set
			{
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x10E8264", Offset = "0x10E8264", VA = "0x10E8264")]
		private void Start()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10E836C", Offset = "0x10E836C", VA = "0x10E836C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10E8500", Offset = "0x10E8500", VA = "0x10E8500")]
		private void Update()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10E8D30", Offset = "0x10E8D30", VA = "0x10E8D30")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10E8F70", Offset = "0x10E8F70", VA = "0x10E8F70")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2E3BC4", Offset = "0x2E3BC4")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float effectAngle;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float effectWidth;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float effectDistance;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10DD208", Offset = "0x10DD208", VA = "0x10DD208")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10DD2B8", Offset = "0x10DD2B8", VA = "0x10DD2B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10DD99C", Offset = "0x10DD99C", VA = "0x10DD99C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10DE160", Offset = "0x10DE160", VA = "0x10DE160")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D74", Offset = "0x2E3D74")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <multiplier>5__2;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x10DEBF4", Offset = "0x10DEBF4", VA = "0x10DEBF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x10DEC84", Offset = "0x10DEC84", VA = "0x10DEC84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x10DE214", Offset = "0x10DE214", VA = "0x10DE214")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x10DE3DC", Offset = "0x10DE3DC", VA = "0x10DE3DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x10DE3E0", Offset = "0x10DE3E0", VA = "0x10DE3E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x10DEBFC", Offset = "0x10DEBFC", VA = "0x10DEBFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform firePrefab;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numDebrisPieces;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numFires;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x10DE188", Offset = "0x10DE188", VA = "0x10DE188")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E53CC", Offset = "0x2E53CC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x10DE234", Offset = "0x10DE234", VA = "0x10DE234")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x10DE3D4", Offset = "0x10DE3D4", VA = "0x10DE3D4")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D84", Offset = "0x2E3D84")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x10DF1B8", Offset = "0x10DF1B8", VA = "0x10DF1B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0x10DF248", Offset = "0x10DF248", VA = "0x10DF248", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x10DED18", Offset = "0x10DED18", VA = "0x10DED18")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x10DED4C", Offset = "0x10DED4C", VA = "0x10DED4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x10DED50", Offset = "0x10DED50", VA = "0x10DED50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x10DF1C0", Offset = "0x10DF1C0", VA = "0x10DF1C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float explosionForce;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x10DEC8C", Offset = "0x10DEC8C", VA = "0x10DEC8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E5444", Offset = "0x2E5444")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x10DED38", Offset = "0x10DED38", VA = "0x10DED38")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E3D94", Offset = "0x2E3D94")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Explosive <>4__this;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Collision col;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0x10DF7E0", Offset = "0x10DF7E0", VA = "0x10DF7E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600020A")]
				[Address(RVA = "0x10DF870", Offset = "0x10DF870", VA = "0x10DF870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x10DF360", Offset = "0x10DF360", VA = "0x10DF360")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x10DF3B4", Offset = "0x10DF3B4", VA = "0x10DF3B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x10DF3B8", Offset = "0x10DF3B8", VA = "0x10DF3B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x10DF7E8", Offset = "0x10DF7E8", VA = "0x10DF7E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform explosionPrefab;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float detonationImpactVelocity;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float sizeMultiplier;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool reset;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float resetTimeDelay;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Exploded;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10DF250", Offset = "0x10DF250", VA = "0x10DF250")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10DF2B8", Offset = "0x10DF2B8", VA = "0x10DF2B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E54BC", Offset = "0x2E54BC")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10DF380", Offset = "0x10DF380", VA = "0x10DF380")]
		public void Reset()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10DF38C", Offset = "0x10DF38C", VA = "0x10DF38C")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float multiplier;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10DF878", Offset = "0x10DF878", VA = "0x10DF878")]
		private void Start()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10DF8E0", Offset = "0x10DF8E0", VA = "0x10DF8E0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10DF978", Offset = "0x10DF978", VA = "0x10DF978")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float m_Rnd;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Burning;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Light m_Light;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x10DF988", Offset = "0x10DF988", VA = "0x10DF988")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x10DFA0C", Offset = "0x10DFA0C", VA = "0x10DFA0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x10DFD00", Offset = "0x10DFD00", VA = "0x10DFD00")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x10DFD38", Offset = "0x10DFD38", VA = "0x10DFD38")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float maxPower;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minPower;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float changeSpeed;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_Power;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10DFD48", Offset = "0x10DFD48", VA = "0x10DFD48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x10DFF90", Offset = "0x10DFF90", VA = "0x10DFF90")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float multiplier;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10DFFB4", Offset = "0x10DFFB4", VA = "0x10DFFB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x10E01A4", Offset = "0x10E01A4", VA = "0x10E01A4")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x10E01B4", Offset = "0x10E01B4", VA = "0x10E01B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x10E02E8", Offset = "0x10E02E8", VA = "0x10E02E8")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float force;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x10E02F0", Offset = "0x10E02F0", VA = "0x10E02F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x10E0358", Offset = "0x10E0358", VA = "0x10E0358")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10E067C", Offset = "0x10E067C", VA = "0x10E067C")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000030")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string axisName;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float axisValue;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float responseSpeed;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float returnToCentreSpeed;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10D8420", Offset = "0x10D8420", VA = "0x10D8420")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x10D8784", Offset = "0x10D8784", VA = "0x10D8784")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x10D8964", Offset = "0x10D8964", VA = "0x10D8964")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10D8A10", Offset = "0x10D8A10", VA = "0x10D8A10", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10D8B28", Offset = "0x10D8B28", VA = "0x10D8B28", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10D8BF0", Offset = "0x10D8BF0", VA = "0x10D8BF0")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Name;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10D8C70", Offset = "0x10D8C70", VA = "0x10D8C70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10D8C74", Offset = "0x10D8C74", VA = "0x10D8C74")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10D8DB0", Offset = "0x10D8DB0", VA = "0x10D8DB0")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10D8EEC", Offset = "0x10D8EEC", VA = "0x10D8EEC")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x10D9028", Offset = "0x10D9028", VA = "0x10D9028")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x10D9164", Offset = "0x10D9164", VA = "0x10D9164")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10D92A0", Offset = "0x10D92A0", VA = "0x10D92A0")]
		public void Update()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x10D92A4", Offset = "0x10D92A4", VA = "0x10D92A4")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000060")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40002F2")]
			Hardware,
			[Token(Token = "0x40002F3")]
			Touch
		}

		[Token(Token = "0x2000061")]
		public class VirtualAxis
		{
			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E64", Offset = "0x2E4E64")]
			private string <name>k__BackingField;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private float m_Value;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E74", Offset = "0x2E4E74")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000025")]
			public string name
			{
				[Token(Token = "0x600020B")]
				[Address(RVA = "0x10DA688", Offset = "0x10DA688", VA = "0x10DA688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5914", Offset = "0x2E5914")]
				get
				{
					return null;
				}
				[Token(Token = "0x600020C")]
				[Address(RVA = "0x10DA690", Offset = "0x10DA690", VA = "0x10DA690")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5924", Offset = "0x2E5924")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600020D")]
				[Address(RVA = "0x10DA698", Offset = "0x10DA698", VA = "0x10DA698")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5934", Offset = "0x2E5934")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x10DA6A0", Offset = "0x10DA6A0", VA = "0x10DA6A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5944", Offset = "0x2E5944")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public float GetValue
			{
				[Token(Token = "0x6000213")]
				[Address(RVA = "0x10DA6D8", Offset = "0x10DA6D8", VA = "0x10DA6D8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000028")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0x10DA6E0", Offset = "0x10DA6E0", VA = "0x10DA6E0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x10D8604", Offset = "0x10D8604", VA = "0x10D8604")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x10DA6A8", Offset = "0x10DA6A8", VA = "0x10DA6A8")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x10D898C", Offset = "0x10D898C", VA = "0x10D898C")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x10DA6D0", Offset = "0x10DA6D0", VA = "0x10DA6D0")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000062")]
		public class VirtualButton
		{
			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E84", Offset = "0x2E4E84")]
			private string <name>k__BackingField;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E94", Offset = "0x2E4E94")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_Pressed;

			[Token(Token = "0x17000029")]
			public string name
			{
				[Token(Token = "0x6000215")]
				[Address(RVA = "0x10DA6E8", Offset = "0x10DA6E8", VA = "0x10DA6E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5954", Offset = "0x2E5954")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000216")]
				[Address(RVA = "0x10DA6F0", Offset = "0x10DA6F0", VA = "0x10DA6F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5964", Offset = "0x2E5964")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000217")]
				[Address(RVA = "0x10DA6F8", Offset = "0x10DA6F8", VA = "0x10DA6F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5974", Offset = "0x2E5974")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000218")]
				[Address(RVA = "0x10DA700", Offset = "0x10DA700", VA = "0x10DA700")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5984", Offset = "0x2E5984")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public bool GetButton
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x10DA850", Offset = "0x10DA850", VA = "0x10DA850")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002C")]
			public bool GetButtonDown
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x10DA858", Offset = "0x10DA858", VA = "0x10DA858")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002D")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x10DA884", Offset = "0x10DA884", VA = "0x10DA884")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x10DA708", Offset = "0x10DA708", VA = "0x10DA708")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x10DA740", Offset = "0x10DA740", VA = "0x10DA740")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x10DA778", Offset = "0x10DA778", VA = "0x10DA778")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x10DA7A8", Offset = "0x10DA7A8", VA = "0x10DA7A8")]
			public void Released()
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x10DA7CC", Offset = "0x10DA7CC", VA = "0x10DA7CC")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000B")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x10DA244", Offset = "0x10DA244", VA = "0x10DA244")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x10D92AC", Offset = "0x10D92AC", VA = "0x10D92AC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x10D9364", Offset = "0x10D9364", VA = "0x10D9364")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x10D8558", Offset = "0x10D8558", VA = "0x10D8558")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x10D94D4", Offset = "0x10D94D4", VA = "0x10D94D4")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x10D862C", Offset = "0x10D862C", VA = "0x10D862C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x10D9780", Offset = "0x10D9780", VA = "0x10D9780")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x10D99AC", Offset = "0x10D99AC", VA = "0x10D99AC")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x10D9B70", Offset = "0x10D9B70", VA = "0x10D9B70")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x10D86D8", Offset = "0x10D86D8", VA = "0x10D86D8")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x10D9D94", Offset = "0x10D9D94", VA = "0x10D9D94")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x10D9ED8", Offset = "0x10D9ED8", VA = "0x10D9ED8")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x10D9E18", Offset = "0x10D9E18", VA = "0x10D9E18")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x10D9F5C", Offset = "0x10D9F5C", VA = "0x10D9F5C")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x10DA014", Offset = "0x10DA014", VA = "0x10DA014")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x10DA0CC", Offset = "0x10DA0CC", VA = "0x10DA0CC")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x10D8CF8", Offset = "0x10D8CF8", VA = "0x10D8CF8")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10D8E34", Offset = "0x10D8E34", VA = "0x10D8E34")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10D8F70", Offset = "0x10D8F70", VA = "0x10D8F70")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10D91E8", Offset = "0x10D91E8", VA = "0x10D91E8")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10D90AC", Offset = "0x10D90AC", VA = "0x10D90AC")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10DA184", Offset = "0x10DA184", VA = "0x10DA184")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10DA2FC", Offset = "0x10DA2FC", VA = "0x10DA2FC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x10DA428", Offset = "0x10DA428", VA = "0x10DA428")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10DA558", Offset = "0x10DA558", VA = "0x10DA558")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string axis;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x10DA8B0", Offset = "0x10DA8B0", VA = "0x10DA8B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10DA8B4", Offset = "0x10DA8B4", VA = "0x10DA8B4")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10DA958", Offset = "0x10DA958", VA = "0x10DA958")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000063")]
		public enum AxisOption
		{
			[Token(Token = "0x40002FD")]
			Both,
			[Token(Token = "0x40002FE")]
			OnlyHorizontal,
			[Token(Token = "0x40002FF")]
			OnlyVertical
		}

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MovementRange;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string horizontalAxisName;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string verticalAxisName;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_UseX;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_UseY;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x10DA960", Offset = "0x10DA960", VA = "0x10DA960")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10DAAF0", Offset = "0x10DAAF0", VA = "0x10DAAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x10DAB40", Offset = "0x10DAB40", VA = "0x10DAB40")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10DA964", Offset = "0x10DA964", VA = "0x10DA964")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10DAC94", Offset = "0x10DAC94", VA = "0x10DAC94", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10DAEE4", Offset = "0x10DAEE4", VA = "0x10DAEE4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x10DAF4C", Offset = "0x10DAF4C", VA = "0x10DAF4C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x10DAF50", Offset = "0x10DAF50", VA = "0x10DAF50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x10DAFB0", Offset = "0x10DAFB0", VA = "0x10DAFB0")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x10DB038", Offset = "0x10DB038", VA = "0x10DB038")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x10DB048", Offset = "0x10DB048", VA = "0x10DB048")]
		private void Start()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x10DB040", Offset = "0x10DB040", VA = "0x10DB040")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x10DB17C", Offset = "0x10DB17C", VA = "0x10DB17C")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x10DB50C", Offset = "0x10DB50C", VA = "0x10DB50C")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000301")]
			ForwardAxis,
			[Token(Token = "0x4000302")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000065")]
		public class AxisMapping
		{
			[Token(Token = "0x200006B")]
			public enum MappingType
			{
				[Token(Token = "0x400030E")]
				NamedAxis,
				[Token(Token = "0x400030F")]
				MousePositionX,
				[Token(Token = "0x4000310")]
				MousePositionY,
				[Token(Token = "0x4000311")]
				MousePositionZ
			}

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MappingType type;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string axisName;

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x10DC90C", Offset = "0x10DC90C", VA = "0x10DC90C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisMapping mapping;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fullTiltAngle;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float centreAngleOffset;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x10DC4C0", Offset = "0x10DC4C0", VA = "0x10DC4C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x10DC5A8", Offset = "0x10DC5A8", VA = "0x10DC5A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x10DC8D0", Offset = "0x10DC8D0", VA = "0x10DC8D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x10DC8F8", Offset = "0x10DC8F8", VA = "0x10DC8F8")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2E3C4C", Offset = "0x2E3C4C")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000066")]
		public enum AxisOption
		{
			[Token(Token = "0x4000306")]
			Both,
			[Token(Token = "0x4000307")]
			OnlyHorizontal,
			[Token(Token = "0x4000308")]
			OnlyVertical
		}

		[Token(Token = "0x2000067")]
		public enum ControlStyle
		{
			[Token(Token = "0x400030A")]
			Absolute,
			[Token(Token = "0x400030B")]
			Relative,
			[Token(Token = "0x400030C")]
			Swipe
		}

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string horizontalAxisName;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string verticalAxisName;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Xsensitivity;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Ysensitivity;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_UseX;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_UseY;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Dragging;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_Id;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_Center;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Image m_Image;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x10DC914", Offset = "0x10DC914", VA = "0x10DC914")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x10DCAA4", Offset = "0x10DCAA4", VA = "0x10DCAA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x10DC918", Offset = "0x10DC918", VA = "0x10DC918")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x10DCB64", Offset = "0x10DCB64", VA = "0x10DCB64")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x10DCBF4", Offset = "0x10DCBF4", VA = "0x10DCBF4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x10DCCCC", Offset = "0x10DCCCC", VA = "0x10DCCCC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x10DCF74", Offset = "0x10DCF74", VA = "0x10DCF74", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x10DD01C", Offset = "0x10DD01C", VA = "0x10DD01C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x10DD158", Offset = "0x10DD158", VA = "0x10DD158")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E4E54", Offset = "0x2E4E54")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000C")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x10DD1E8", Offset = "0x10DD1E8", VA = "0x10DD1E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5534", Offset = "0x2E5534")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x10DD1FC", Offset = "0x10DD1FC", VA = "0x10DD1FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2E5544", Offset = "0x2E5544")]
			private set
			{
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x10D9454", Offset = "0x10D9454", VA = "0x10D9454")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x10D9580", Offset = "0x10D9580", VA = "0x10D9580")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x10D9600", Offset = "0x10D9600", VA = "0x10D9600")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x10D982C", Offset = "0x10D982C", VA = "0x10D982C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x10D9AB8", Offset = "0x10D9AB8", VA = "0x10D9AB8")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x10D9C1C", Offset = "0x10D9C1C", VA = "0x10D9C1C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x10D9CD4", Offset = "0x10D9CD4", VA = "0x10D9CD4")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x10DA3DC", Offset = "0x10DA3DC", VA = "0x10DA3DC")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x10DA508", Offset = "0x10DA508", VA = "0x10DA508")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x10DA638", Offset = "0x10DA638", VA = "0x10DA638")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000191")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000192")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000193")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000194")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000195")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000196")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000197")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000198")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000199")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600019A")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600019B")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x10DBFD4", Offset = "0x10DBFD4", VA = "0x10DBFD4")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000039")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x10DB514", Offset = "0x10DB514", VA = "0x10DB514")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x10DB5D0", Offset = "0x10DB5D0", VA = "0x10DB5D0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x10DB67C", Offset = "0x10DB67C", VA = "0x10DB67C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x10DB750", Offset = "0x10DB750", VA = "0x10DB750", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x10DB840", Offset = "0x10DB840", VA = "0x10DB840", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x10DB924", Offset = "0x10DB924", VA = "0x10DB924", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x10DB9FC", Offset = "0x10DB9FC", VA = "0x10DB9FC", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x10DBAD8", Offset = "0x10DBAD8", VA = "0x10DBAD8", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x10DBBB0", Offset = "0x10DBBB0", VA = "0x10DBBB0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x10DBC94", Offset = "0x10DBC94", VA = "0x10DBC94", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x10DBDAC", Offset = "0x10DBDAC", VA = "0x10DBDAC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x10DBEC4", Offset = "0x10DBEC4", VA = "0x10DBEC4", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x10DBFC0", Offset = "0x10DBFC0", VA = "0x10DBFC0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x10D935C", Offset = "0x10D935C", VA = "0x10D935C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x10DC0C8", Offset = "0x10DC0C8", VA = "0x10DC0C8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x10DC0E0", Offset = "0x10DC0E0", VA = "0x10DC0E0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10DC0EC", Offset = "0x10DC0EC", VA = "0x10DC0EC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x10DC0F8", Offset = "0x10DC0F8", VA = "0x10DC0F8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x10DC104", Offset = "0x10DC104", VA = "0x10DC104", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x10DC1A0", Offset = "0x10DC1A0", VA = "0x10DC1A0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x10DC23C", Offset = "0x10DC23C", VA = "0x10DC23C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x10DC2D8", Offset = "0x10DC2D8", VA = "0x10DC2D8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x10DC374", Offset = "0x10DC374", VA = "0x10DC374", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10DC410", Offset = "0x10DC410", VA = "0x10DC410", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10DC4AC", Offset = "0x10DC4AC", VA = "0x10DC4AC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10D9360", Offset = "0x10D9360", VA = "0x10D9360")]
		public StandaloneInput()
		{
		}
	}
}
