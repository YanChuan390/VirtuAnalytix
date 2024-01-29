using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
public class HxSimpleRotate : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotateSpeed;

	[Address(RVA = "0x14102E8", Offset = "0x14102E8", VA = "0x14102E8")]
	private void Update()
	{
	}

	[Address(RVA = "0x14103C4", Offset = "0x14103C4", VA = "0x14103C4")]
	public HxSimpleRotate()
	{
	}
}
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BD20", Offset = "0x87BD20")]
public class HxDensityVolume : MonoBehaviour
{
	public enum DensityShape
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Square,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sphere,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Cylinder
	}

	public enum DensityBlendMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Max,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Add,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Min,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sub
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static HxOctree<HxDensityVolume> DensityOctree;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HxOctreeNode<HxDensityVolume>.NodeObject octreeNode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DensityShape Shape;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public DensityBlendMode BlendMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87DDF8", Offset = "0x87DDF8")]
	public Vector3 minBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87DE08", Offset = "0x87DE08")]
	public Vector3 maxBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87DE18", Offset = "0x87DE18")]
	public Matrix4x4 ToLocalSpace;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float Density;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Color gizmoColor;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Vector3 c1;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static Vector3 c2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 c3;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static Vector3 c4;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Vector3 c5;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static Vector3 c6;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Vector3 c7;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private static Vector3 c8;

	[Address(RVA = "0x140F428", Offset = "0x140F428", VA = "0x140F428")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x140FAFC", Offset = "0x140FAFC", VA = "0x140FAFC")]
	private void OnDrawGizmos()
	{
	}

	[Address(RVA = "0x140FB74", Offset = "0x140FB74", VA = "0x140FB74")]
	private void OnDrawGizmosSelected()
	{
	}

	[Address(RVA = "0x140FCA4", Offset = "0x140FCA4", VA = "0x140FCA4")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x140FDB8", Offset = "0x140FDB8", VA = "0x140FDB8")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x140FECC", Offset = "0x140FECC", VA = "0x140FECC")]
	public void UpdateVolume()
	{
	}

	[Address(RVA = "0x140F5E0", Offset = "0x140F5E0", VA = "0x140F5E0")]
	private void CalculateBounds()
	{
	}

	[Address(RVA = "0x1410014", Offset = "0x1410014", VA = "0x1410014")]
	public HxDensityVolume()
	{
	}
}
[AttributeAttribute(Name = "RequireComponent", RVA = "0x87BD30", Offset = "0x87BD30")]
public class HxDummyLight : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightType type;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float range;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DE28", Offset = "0x87DE28")]
	public float spotAngle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DE44", Offset = "0x87DE44")]
	public float intensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture cookie;

	[Address(RVA = "0x1410294", Offset = "0x1410294", VA = "0x1410294")]
	public void Update()
	{
	}

	[Address(RVA = "0x1410298", Offset = "0x1410298", VA = "0x1410298")]
	public HxDummyLight()
	{
	}
}
public class HxOctree<T>
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DE5C", Offset = "0x87DE5C")]
	private int <Count>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private HxOctreeNode<T> Root;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float Overlap;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float InitialSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float MinNodeSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<T, HxOctreeNode<T>.NodeObject> NodeMap;

	public int Count
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8888E8", Offset = "0x8888E8")]
		get
		{
			return default(int);
		}
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8888F8", Offset = "0x8888F8")]
		private set
		{
		}
	}

	public HxOctree([Optional] Vector3 origin, float initialSize = 10f, float overlap = 0f, float minNodeSize = 1f)
	{
	}

	public HxOctreeNode<T>.NodeObject Add(T value, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	public void Print()
	{
	}

	public void Move(HxOctreeNode<T>.NodeObject value, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	public void Move(T value, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	public void TryShrink()
	{
	}

	public bool Remove(T value)
	{
		return default(bool);
	}

	private void ExpandRoot(Vector3 center)
	{
	}

	public void GetObjects(Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	public void GetObjectsBoundsPlane(ref Plane[] planes, Vector3 min, Vector3 max, List<T> items)
	{
	}

	public void Draw()
	{
	}
}
[Serializable]
public class HxOctreeNode<T>
{
	[Serializable]
	public class NodeObject
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HxOctreeNode<T> Node;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 BoundsMax;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Center;

		public NodeObject(T value, Vector3 boundsMin, Vector3 boundsMax)
		{
		}
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DE6C", Offset = "0x87DE6C")]
	private Vector3 <Origin>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DE7C", Offset = "0x87DE7C")]
	private float <Size>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public HxOctreeNode<T> Parent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float MinSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float Overlap;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float SizeWithOverlap;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 BoundsMin;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 BoundsMax;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly List<NodeObject> Objects;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private const int MaxObjectCount = 8;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public HxOctreeNode<T>[] Children;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3[] ChildrenBoundsMin;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3[] ChildrenBoundsMax;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int ID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int _idCtr;

	public Vector3 Origin
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888908", Offset = "0x888908")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888918", Offset = "0x888918")]
		private set
		{
		}
	}

	public float Size
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888928", Offset = "0x888928")]
		get
		{
			return default(float);
		}
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888938", Offset = "0x888938")]
		private set
		{
		}
	}

	public HxOctreeNode(float size, float overlap, float minSize, Vector3 origin, HxOctreeNode<T> parent)
	{
	}

	private void Init(float size, float overlap, float minSize, Vector3 origin, HxOctreeNode<T> parent)
	{
	}

	public void Add(NodeObject node)
	{
	}

	public bool Remove(T value)
	{
		return default(bool);
	}

	public void GetObjects(Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	public void GetObjects2(Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	public void GetObjects2BoundsPlane(ref Plane[] planes, Vector3 boundsMin, Vector3 boundsMax, List<T> items)
	{
	}

	private void DrawBounds(Vector3 min, Vector3 max)
	{
	}

	private int BoundsInPlanes(Vector3 min, Vector3 max, ref Plane[] planes)
	{
		return default(int);
	}

	private bool ObjectInPlanes(Vector3 min, Vector3 max, ref Plane[] planes)
	{
		return default(bool);
	}

	private Vector3 GetVertexP(Vector3 min, Vector3 max, Vector3 normal)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	private Vector3 GetVertexN(Vector3 min, Vector3 max, Vector3 normal)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	private void addAllObjectsToList(List<T> items)
	{
	}

	private void addAllObjectsToList(List<T> items, ref Vector3 min, ref Vector3 max)
	{
	}

	public HxOctreeNode<T> TryShrink(float minSize)
	{
		return null;
	}

	private Vector3 GetVertexP(Vector3 normal)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	private bool HasObjects()
	{
		return default(bool);
	}

	public static bool BoundsIntersects(Vector3 aMin, Vector3 aMax, Vector3 bMin, Vector3 bMax)
	{
		return default(bool);
	}

	public static bool BoundsContains(Vector3 outerMin, Vector3 outerMax, Vector3 innerMin, Vector3 innerMax)
	{
		return default(bool);
	}

	private int OctantIndex(Vector3 point)
	{
		return default(int);
	}

	public void Draw(int counter = 0)
	{
	}
}
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BD94", Offset = "0x87BD94")]
public class HxVolumetricCamera : MonoBehaviour
{
	public enum hxRenderOrder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		ImageEffect,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		ImageEffectOpaque
	}

	public enum TransparencyQualities
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Low,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Medium,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		High,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		VeryHigh
	}

	public enum DensityParticleQualities
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Low,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Medium,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		High,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		VeryHigh
	}

	public enum HxAmbientMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		UseRenderSettings,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Color,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Gradient
	}

	public enum HxTintMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Off,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Color,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Edge,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Gradient
	}

	public enum Resolution
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		full,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		half,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		quarter
	}

	public enum DensityResolution
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		full,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		half,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		quarter,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		eighth
	}

	private struct TriangleIndices
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int v1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int v2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int v3;

		[Address(RVA = "0x95FA84", Offset = "0x95FA84", VA = "0x95FA84")]
		public TriangleIndices(int v1, int v2, int v3)
		{
		}
	}

	[Serializable]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD28", Offset = "0x87DD28")]
	private sealed class <>c
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<HxDensityVolume> <>9__229_0;

		[Address(RVA = "0x1425020", Offset = "0x1425020", VA = "0x1425020")]
		public <>c()
		{
		}

		[Address(RVA = "0x1425028", Offset = "0x1425028", VA = "0x1425028")]
		internal int <FindActiveLights>b__229_0(HxDensityVolume a, HxDensityVolume b)
		{
			return default(int);
		}
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public hxRenderOrder RenderOrder;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HxVolumetricRenderCallback callBackImageEffect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HxVolumetricRenderCallback callBackImageEffectOpaque;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool ShadowFix;

	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool TemporalFirst;

	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool TemporalSampling;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DE8C", Offset = "0x87DE8C")]
	public float DitherSpeed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DEA4", Offset = "0x87DEA4")]
	public float LuminanceFeedback;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DEBC", Offset = "0x87DEBC")]
	public float MaxFeedback;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DED4", Offset = "0x87DED4")]
	public float NoiseContrast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Shader directionalShader;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Shader pointShader;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Shader spotShader;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Shader ProjectorShader;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool FullUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool LowResUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool HeightFogUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
	public bool HeightFogOffUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool NoiseUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool NoiseOffUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool TransparencyUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	public bool TransparencyOffUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool DensityParticlesUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool PointUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool SpotUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	public bool ProjectorUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool DirectionalUsed;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool SinglePassStereoUsed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static TransparencyQualities TransparencyBufferDepth;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static DensityParticleQualities DensityBufferDepth;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int EnumBufferDepthLength;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Matrix4x4 CurrentView;

	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Matrix4x4 CurrentProj;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Matrix4x4 CurrentInvers;

	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Matrix4x4 CurrentView2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Matrix4x4 CurrentProj2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Matrix4x4 CurrentInvers2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private RenderTexture TemporalTexture;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private RenderTargetIdentifier TemporalTextureRTID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private RenderTexture VolumetricTexture;

	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private RenderTexture FullBlurRT;

	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private RenderTargetIdentifier FullBlurRTID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private RenderTexture downScaledBlurRT;

	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private RenderTargetIdentifier downScaledBlurRTID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private RenderTexture FullBlurRT2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private RenderTargetIdentifier FullBlurRT2ID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private RenderTargetIdentifier[] VolumetricUpsampledBlurTextures;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private RenderTexture[] VolumetricDensityTextures;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private int[] VolumetricDensityPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private int[] VolumetricTransparencyPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private RenderTexture[] VolumetricTransparencyTextures;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public RenderTargetIdentifier[][] VolumetricDensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public RenderTargetIdentifier[][] VolumetricTransparency;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public RenderTargetIdentifier[][] VolumetricTransparencyI;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public RenderTexture[] ScaledDepthTexture;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static ShaderVariantCollection CollectionAll;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Texture2D Tile5x5;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int VolumetricTexturePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int ScaledDepthTexturePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static int ShadowMapTexturePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static RenderTargetIdentifier VolumetricTextureRTID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public RenderTargetIdentifier[] ScaledDepthTextureRTID;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static Material DownSampleMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static Material VolumeBlurMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static Material TransparencyBlurMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static Material ApplyMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static Material ApplyDirectMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static Material ApplyQueueMaterial;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public Texture3D NoiseTexture3D;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Matrix4x4 BlitMatrix;

	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public Matrix4x4 BlitMatrixMV;

	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public Matrix4x4 BlitMatrixMVP;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public Vector3 BlitScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87DEEC", Offset = "0x87DEEC")]
	public Resolution resolution;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87DF24", Offset = "0x87DF24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DF24", Offset = "0x87DF24")]
	public int SampleCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87DF7C", Offset = "0x87DF7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87DF7C", Offset = "0x87DF7C")]
	public int DirectionalSampleCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87DFD4", Offset = "0x87DFD4")]
	public float MaxDirectionalRayDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E00C", Offset = "0x87E00C")]
	public float MaxLightDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E044", Offset = "0x87E044")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E044", Offset = "0x87E044")]
	public float Density;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E098", Offset = "0x87E098")]
	public float AmbientLightingStrength;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E0B0", Offset = "0x87E0B0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E0B0", Offset = "0x87E0B0")]
	public float MieScattering;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E108", Offset = "0x87E108")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E108", Offset = "0x87E108")]
	public float SunSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E15C", Offset = "0x87E15C")]
	public bool SunBleed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E194", Offset = "0x87E194")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E194", Offset = "0x87E194")]
	public float Extinction;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E1E8", Offset = "0x87E1E8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E1E8", Offset = "0x87E1E8")]
	public float ExtinctionEffect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
	public bool FogHeightEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	public float FogHeight;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
	public float FogTransitionSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public float AboveFogPercent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E23C", Offset = "0x87E23C")]
	public HxAmbientMode Ambient;

	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public Color AmbientSky;

	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	public Color AmbientEquator;

	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	public Color AmbientGround;

	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E274", Offset = "0x87E274")]
	public float AmbientIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
	public HxTintMode TintMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	public Color TintColor;

	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	public Color TintColor2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
	public float TintIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x464")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E28C", Offset = "0x87E28C")]
	public float TintGradient;

	[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
	public Vector3 CurrentTint;

	[Il2CppDummyDll.FieldOffset(Offset = "0x474")]
	public Vector3 CurrentTintEdge;

	[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E2A4", Offset = "0x87E2A4")]
	public bool NoiseEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x484")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E2DC", Offset = "0x87E2DC")]
	public Vector3 NoiseScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E314", Offset = "0x87E314")]
	public Vector3 NoiseVelocity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E34C", Offset = "0x87E34C")]
	public bool ParticleDensitySupport;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E384", Offset = "0x87E384")]
	public DensityResolution densityResolution;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E3BC", Offset = "0x87E3BC")]
	public float densityDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	private float densityBias;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E3F4", Offset = "0x87E3F4")]
	public bool TransparencySupport;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E42C", Offset = "0x87E42C")]
	public float transparencyDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E464", Offset = "0x87E464")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E464", Offset = "0x87E464")]
	public int BlurTransparency;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
	private float transparencyBias;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E4B8", Offset = "0x87E4B8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E4B8", Offset = "0x87E4B8")]
	public int blurCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E50C", Offset = "0x87E50C")]
	public float BlurDepthFalloff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E544", Offset = "0x87E544")]
	public float DownsampledBlurDepthFalloff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E57C", Offset = "0x87E57C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E57C", Offset = "0x87E57C")]
	public int UpSampledblurCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E5D0", Offset = "0x87E5D0")]
	public float DepthThreshold;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E608", Offset = "0x87E608")]
	public bool GaussianWeights;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4D1")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E640", Offset = "0x87E640")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E640", Offset = "0x87E640")]
	public bool MapToLDR;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4D2")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E68C", Offset = "0x87E68C")]
	public bool RemoveColorBanding;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
	public Vector3 Offset;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static int DepthThresholdPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private static int BlurDepthFalloffPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static int VolumeScalePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int InverseViewMatrixPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static int InverseProjectionMatrixPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private static int InverseProjectionMatrix2PID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static int NoiseOffsetPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private static int ShadowDistancePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static HxVolumetricShadersUsed UsedShaderSettings;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private static List<string> ShaderVariantList;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E6C4", Offset = "0x87E6C4")]
	public static List<HxDensityVolume> ActiveVolumes;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static List<HxVolumetricLight> ActiveLights;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static List<HxVolumetricParticleSystem> ActiveParticleSystems;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static HxOctree<HxVolumetricLight> LightOctree;

	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public static HxOctree<HxVolumetricParticleSystem> ParticleOctree;

	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public static HashSet<HxDensityVolume> AllDensityVolumes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public static HashSet<HxVolumetricLight> AllVolumetricLight;

	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public static HashSet<HxVolumetricParticleSystem> AllParticleSystems;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
	private bool test;

	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public static Mesh QuadMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public static Mesh BoxMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public static Mesh SphereMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public static Mesh SpotLightMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public static Mesh OrthoProjectorMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E6D4", Offset = "0x87E6D4")]
	private Camera Mycamera;

	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private static float[] ResolutionScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public static float[] SampleScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
	private CommandBuffer BufferSetup;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
	private CommandBuffer BufferRender;

	[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
	private CommandBuffer BufferRenderLights;

	[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
	private CommandBuffer BufferFinalize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
	private bool dirty;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public static bool PIDCreated;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private static Dictionary<int, Material> DirectionalMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private static Dictionary<int, Material> PointMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private static Dictionary<int, Material> SpotMaterial;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private static Dictionary<int, Material> ProjectorMaterial;

	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public static ShaderVariant[] DirectionalVariant;

	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public static ShaderVariant[] PointVariant;

	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public static ShaderVariant[] SpotVariant;

	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public static Material ShadowMaterial;

	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public static Material DensityMaterial;

	[Il2CppDummyDll.FieldOffset(Offset = "0x514")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E6E4", Offset = "0x87E6E4")]
	public Matrix4x4 MatrixVP;

	[Il2CppDummyDll.FieldOffset(Offset = "0x554")]
	public Matrix4x4 LastMatrixVP;

	[Il2CppDummyDll.FieldOffset(Offset = "0x594")]
	public Matrix4x4 LastMatrixVPInv;

	[Il2CppDummyDll.FieldOffset(Offset = "0x5D4")]
	public Matrix4x4 LastMatrixVP2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x614")]
	public Matrix4x4 LastMatrixVPInv2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x654")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E6F4", Offset = "0x87E6F4")]
	public Matrix4x4 MatrixV;

	[Il2CppDummyDll.FieldOffset(Offset = "0x694")]
	private bool OffsetUpdated;

	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E704", Offset = "0x87E704")]
	private static Texture2D _SpotLightCookie;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87E714", Offset = "0x87E714")]
	private static Texture2D _LightFalloff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
	private int ParticleDensityRenderCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private static Matrix4x4 particleMatrix;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public static HxVolumetricCamera Active;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public static Camera ActiveCamera;

	[Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
	private CameraEvent LightRenderEvent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
	private CameraEvent SetupEvent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6A4")]
	private CameraEvent RenderEvent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
	private CameraEvent FinalizeEvent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public static List<HxVolumetricLight> ActiveDirectionalLights;

	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private static Vector3 MinBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private static Vector3 MaxBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private static Plane[] CameraPlanes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6AC")]
	private bool preCullEventAdded;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6AD")]
	private bool BuffersBuilt;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6AE")]
	private bool LightBufferAdded;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6AF")]
	private bool SetupBufferAdded;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
	private bool SetupBufferDirty;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6B1")]
	private bool FinalizeBufferAdded;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6B2")]
	private bool FinalizeBufferDirty;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6B4")]
	private CameraEvent lastApply;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
	private CameraEvent lastRender;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6BC")]
	private CameraEvent lastSetup;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
	private CameraEvent lastFinalize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C4")]
	private CameraEvent lastLightRender;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
	private bool LastPlaying;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private static int lastRes;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6CC")]
	private int lastBlurCount;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
	private int lastupSampleBlurCount;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
	private int lastLDR;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
	private int lastBanding;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6DC")]
	private int lastH;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
	private int lastW;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E4")]
	private int lastPath;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
	private int lastGaussian;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6EC")]
	private int lastTransparency;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
	private int lastDensity;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F4")]
	private int lastDensityRes;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
	private float lastDepthFalloff;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6FC")]
	private float lastDownDepthFalloff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
	private float currentDitherOffset;

	[Il2CppDummyDll.FieldOffset(Offset = "0x704")]
	private float MaxLightDistanceUsed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	public static bool FirstDirectional;

	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private static int[] Tile5x5int;

	[AttributeAttribute(Name = "HideInInspector", RVA = "0x88C56C", Offset = "0x88C56C")]
	public Texture2D SpotLightCookie
	{
		[Address(RVA = "0x1415E34", Offset = "0x1415E34", VA = "0x1415E34")]
		get
		{
			return null;
		}
		[Address(RVA = "0x1416018", Offset = "0x1416018", VA = "0x1416018")]
		set
		{
		}
	}

	[AttributeAttribute(Name = "HideInInspector", RVA = "0x88C57C", Offset = "0x88C57C")]
	public Texture2D LightFalloff
	{
		[Address(RVA = "0x1416084", Offset = "0x1416084", VA = "0x1416084")]
		get
		{
			return null;
		}
		[Address(RVA = "0x1416268", Offset = "0x1416268", VA = "0x1416268")]
		set
		{
		}
	}

	[Address(RVA = "0x14103CC", Offset = "0x14103CC", VA = "0x14103CC")]
	private void SetUpRenderOrder()
	{
	}

	[Address(RVA = "0x14106E8", Offset = "0x14106E8", VA = "0x14106E8")]
	public static Material GetDirectionalMaterial(int mid)
	{
		return null;
	}

	[Address(RVA = "0x1410AF8", Offset = "0x1410AF8", VA = "0x1410AF8")]
	public static Material GetProjectorMaterial(int mid)
	{
		return null;
	}

	[Address(RVA = "0x1410CB0", Offset = "0x1410CB0", VA = "0x1410CB0")]
	public static Material GetSpotMaterial(int mid)
	{
		return null;
	}

	[Address(RVA = "0x1410E68", Offset = "0x1410E68", VA = "0x1410E68")]
	public static Material GetPointMaterial(int mid)
	{
		return null;
	}

	[Address(RVA = "0x1411020", Offset = "0x1411020", VA = "0x1411020")]
	public TransparencyQualities compatibleTBuffer()
	{
		return default(TransparencyQualities);
	}

	[Address(RVA = "0x14110EC", Offset = "0x14110EC", VA = "0x14110EC")]
	private bool IsRenderBoth()
	{
		return default(bool);
	}

	[Address(RVA = "0x14111A0", Offset = "0x14111A0", VA = "0x14111A0")]
	private DensityParticleQualities compatibleDBuffer()
	{
		return default(DensityParticleQualities);
	}

	[Address(RVA = "0x1411208", Offset = "0x1411208", VA = "0x1411208")]
	private void MyPreCull(Camera cam)
	{
	}

	[Address(RVA = "0x1411418", Offset = "0x1411418", VA = "0x1411418")]
	public bool renderDensityParticleCheck()
	{
		return default(bool);
	}

	[Address(RVA = "0x1411428", Offset = "0x1411428", VA = "0x1411428")]
	private void WarmUp()
	{
	}

	[Address(RVA = "0x1411834", Offset = "0x1411834", VA = "0x1411834")]
	private void CreateShaderVariant(Shader source, int i, ref Material[] material, ref ShaderVariant[] Variant, bool point = true)
	{
	}

	[Address(RVA = "0x1410898", Offset = "0x1410898", VA = "0x1410898")]
	private static void CreateShader(Shader source, int i, out Material outMaterial, bool point = true)
	{
	}

	[Address(RVA = "0x1411F34", Offset = "0x1411F34", VA = "0x1411F34")]
	private void CreatePIDs()
	{
	}

	[Address(RVA = "0x1415704", Offset = "0x1415704", VA = "0x1415704")]
	public static bool ActiveFull()
	{
		return default(bool);
	}

	[Address(RVA = "0x1415784", Offset = "0x1415784", VA = "0x1415784")]
	private void DefineFull()
	{
	}

	[Address(RVA = "0x1415788", Offset = "0x1415788", VA = "0x1415788")]
	private static void UpdateLight(HxOctreeNode<HxVolumetricLight>.NodeObject node, Vector3 boundsMin, Vector3 boundsMax)
	{
	}

	[Address(RVA = "0x141585C", Offset = "0x141585C", VA = "0x141585C")]
	public static HxOctreeNode<HxVolumetricLight>.NodeObject AddLightOctree(HxVolumetricLight light, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Address(RVA = "0x1415A08", Offset = "0x1415A08", VA = "0x1415A08")]
	public static HxOctreeNode<HxVolumetricParticleSystem>.NodeObject AddParticleOctree(HxVolumetricParticleSystem particle, Vector3 boundsMin, Vector3 boundsMax)
	{
		return null;
	}

	[Address(RVA = "0x1415BB4", Offset = "0x1415BB4", VA = "0x1415BB4")]
	public static void RemoveLightOctree(HxVolumetricLight light)
	{
	}

	[Address(RVA = "0x1415C74", Offset = "0x1415C74", VA = "0x1415C74")]
	public static void RemoveParticletOctree(HxVolumetricParticleSystem Particle)
	{
	}

	[Address(RVA = "0x1415D34", Offset = "0x1415D34", VA = "0x1415D34")]
	private void OnApplicationQuit()
	{
	}

	[Address(RVA = "0x1415D9C", Offset = "0x1415D9C", VA = "0x1415D9C")]
	public Camera GetCamera()
	{
		return null;
	}

	[Address(RVA = "0x14162D4", Offset = "0x14162D4", VA = "0x14162D4")]
	private Vector4 CalculateDensityDistance(int i)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector4);
	}

	[Address(RVA = "0x14164C0", Offset = "0x14164C0", VA = "0x14164C0")]
	private Vector4 CalculateTransparencyDistance(int i)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector4);
	}

	[Address(RVA = "0x14166AC", Offset = "0x14166AC", VA = "0x14166AC")]
	private void RenderParticles()
	{
	}

	[Address(RVA = "0x14184E8", Offset = "0x14184E8", VA = "0x14184E8")]
	private void OnPostRender()
	{
	}

	[Address(RVA = "0x14179C8", Offset = "0x14179C8", VA = "0x14179C8")]
	private int RenderSlices()
	{
		return default(int);
	}

	[Address(RVA = "0x1418534", Offset = "0x1418534", VA = "0x1418534")]
	private int GetCamPixelHeight()
	{
		return default(int);
	}

	[Address(RVA = "0x1418600", Offset = "0x1418600", VA = "0x1418600")]
	private int GetCamPixelWidth()
	{
		return default(int);
	}

	[Address(RVA = "0x1418760", Offset = "0x1418760", VA = "0x1418760")]
	private void CreateTempTextures()
	{
	}

	[Address(RVA = "0x1416C6C", Offset = "0x1416C6C", VA = "0x1416C6C")]
	public static void ConstructPlanes(Camera cam, float near, float far)
	{
	}

	[Address(RVA = "0x141A140", Offset = "0x141A140", VA = "0x141A140")]
	private void FindActiveLights()
	{
	}

	[Address(RVA = "0x1417874", Offset = "0x1417874", VA = "0x1417874")]
	private void FindActiveParticleSystems()
	{
	}

	[Address(RVA = "0x141A540", Offset = "0x141A540", VA = "0x141A540")]
	public void Update()
	{
	}

	[Address(RVA = "0x141A9CC", Offset = "0x141A9CC", VA = "0x141A9CC")]
	private void Start()
	{
	}

	[Address(RVA = "0x141AAF0", Offset = "0x141AAF0", VA = "0x141AAF0")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x141AC14", Offset = "0x141AC14", VA = "0x141AC14")]
	private void CreateApplyBuffer()
	{
	}

	[Address(RVA = "0x141AC18", Offset = "0x141AC18", VA = "0x141AC18")]
	private void CreateSetupBuffer()
	{
	}

	[Address(RVA = "0x141B0A8", Offset = "0x141B0A8", VA = "0x141B0A8")]
	private bool CheckBufferDirty()
	{
		return default(bool);
	}

	[Address(RVA = "0x141B2B8", Offset = "0x141B2B8", VA = "0x141B2B8")]
	private void CreateFinalizeBuffer()
	{
	}

	[Address(RVA = "0x141E558", Offset = "0x141E558", VA = "0x141E558")]
	private void BuildBuffer()
	{
	}

	[Address(RVA = "0x1420C94", Offset = "0x1420C94", VA = "0x1420C94")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x1421714", Offset = "0x1421714", VA = "0x1421714")]
	private void SaveUsedShaderVarience()
	{
	}

	[Address(RVA = "0x1421718", Offset = "0x1421718", VA = "0x1421718")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x1420510", Offset = "0x1420510", VA = "0x1420510")]
	private void CalculateEvent()
	{
	}

	[Address(RVA = "0x1421AAC", Offset = "0x1421AAC", VA = "0x1421AAC")]
	public void EventOnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Address(RVA = "0x1421B8C", Offset = "0x1421B8C", VA = "0x1421B8C")]
	private int ScalePass()
	{
		return default(int);
	}

	[Address(RVA = "0x1421BB0", Offset = "0x1421BB0", VA = "0x1421BB0")]
	private void DownSampledFullBlur(RenderTexture mainColor, RenderBuffer NewColor, RenderBuffer depth, int pass)
	{
	}

	[Address(RVA = "0x1420628", Offset = "0x1420628", VA = "0x1420628")]
	private void CheckTemporalTextures()
	{
	}

	[Address(RVA = "0x1421020", Offset = "0x1421020", VA = "0x1421020")]
	public void ReleaseTempTextures()
	{
	}

	[Address(RVA = "0x1421D64", Offset = "0x1421D64", VA = "0x1421D64")]
	private void OnPreCull()
	{
	}

	[Address(RVA = "0x1422290", Offset = "0x1422290", VA = "0x1422290")]
	private void LateUpdate()
	{
	}

	[Address(RVA = "0x1421E0C", Offset = "0x1421E0C", VA = "0x1421E0C")]
	private void UpdateLightPoistions()
	{
	}

	[Address(RVA = "0x1422120", Offset = "0x1422120", VA = "0x1422120")]
	private void UpdateParticlePoistions()
	{
	}

	[Address(RVA = "0x1423998", Offset = "0x1423998", VA = "0x1423998")]
	private void Awake()
	{
	}

	[Address(RVA = "0x1423B08", Offset = "0x1423B08", VA = "0x1423B08")]
	private void start()
	{
	}

	[Address(RVA = "0x14112D0", Offset = "0x14112D0", VA = "0x14112D0")]
	public void ReleaseLightBuffers()
	{
	}

	[Address(RVA = "0x1420838", Offset = "0x1420838", VA = "0x1420838")]
	private void CreateLightbuffers()
	{
	}

	[Address(RVA = "0x1413220", Offset = "0x1413220", VA = "0x1413220")]
	private static void CreateTileTexture()
	{
	}

	[Address(RVA = "0x1415384", Offset = "0x1415384", VA = "0x1415384")]
	public static Mesh CreateOrtho(int sides, bool inner = true)
	{
		return null;
	}

	[Address(RVA = "0x1414BBC", Offset = "0x1414BBC", VA = "0x1414BBC")]
	public static Mesh CreateCone(int sides, bool inner = true)
	{
		return null;
	}

	[Address(RVA = "0x1413610", Offset = "0x1413610", VA = "0x1413610")]
	public static Mesh CreateQuad()
	{
		return null;
	}

	[Address(RVA = "0x1413920", Offset = "0x1413920", VA = "0x1413920")]
	public static Mesh CreateBox()
	{
		return null;
	}

	[Address(RVA = "0x1413A08", Offset = "0x1413A08", VA = "0x1413A08")]
	public static Mesh CreateIcoSphere(int recursionLevel, float radius)
	{
		return null;
	}

	[Address(RVA = "0x1423D78", Offset = "0x1423D78", VA = "0x1423D78")]
	private static int getMiddlePoint(int p1, int p2, ref List<Vector3> vertices, ref Dictionary<long, int> cache, float radius)
	{
		return default(int);
	}

	[Address(RVA = "0x1412ED0", Offset = "0x1412ED0", VA = "0x1412ED0")]
	public void Create3DNoiseTexture()
	{
	}

	[Address(RVA = "0x1423FB0", Offset = "0x1423FB0", VA = "0x1423FB0")]
	private int PostoIndex(Vector3 pos)
	{
		return default(int);
	}

	[Address(RVA = "0x1424020", Offset = "0x1424020", VA = "0x1424020")]
	public HxVolumetricCamera()
	{
	}
}
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BDA4", Offset = "0x87BDA4")]
public class HxVolumetricImageEffect : HxVolumetricRenderCallback
{
	[Address(RVA = "0x1425084", Offset = "0x1425084", VA = "0x1425084")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x1425118", Offset = "0x1425118", VA = "0x1425118")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Address(RVA = "0x1425254", Offset = "0x1425254", VA = "0x1425254")]
	public HxVolumetricImageEffect()
	{
	}
}
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BDB4", Offset = "0x87BDB4")]
public class HxVolumetricImageEffectOpaque : HxVolumetricRenderCallback
{
	[Address(RVA = "0x142525C", Offset = "0x142525C", VA = "0x142525C")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x14252F4", Offset = "0x14252F4", VA = "0x14252F4")]
	[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x888948", Offset = "0x888948")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Address(RVA = "0x1425430", Offset = "0x1425430", VA = "0x1425430")]
	public HxVolumetricImageEffectOpaque()
	{
	}
}
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BDC4", Offset = "0x87BDC4")]
public class HxVolumetricLight : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float ShadowDistanceExtra;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Light myLight;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HxDummyLight myDummyLight;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture3D NoiseTexture3D;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CommandBuffer BufferRender;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CommandBuffer BufferCopy;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Projector myProjector;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 NoiseScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 NoiseVelocity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool dirty;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture LightFalloff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float NearPlane;

	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool NoiseEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool CustomMieScatter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
	public bool CustomExtinction;

	[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
	public bool CustomExtinctionEffect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool CustomDensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool CustomSampleCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	public bool CustomColor;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
	public bool CustomNoiseEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool CustomNoiseTexture;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool CustomNoiseScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool CustomNoiseVelocity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
	public bool CustomNoiseContrast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool CustomFogHeightEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool CustomFogHeight;

	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	public bool CustomFogTransitionSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	public bool CustomAboveFogPercent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool CustomSunSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	public bool CustomSunBleed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	public bool ShadowCasting;

	[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
	public bool CustomStrength;

	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool CustomIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool CustomTintMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	public bool CustomTintColor;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
	public bool CustomTintColor2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool CustomTintGradient;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	public bool CustomTintIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
	public bool CustomMaxLightDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E724", Offset = "0x87E724")]
	public float NoiseContrast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public HxVolumetricCamera.HxTintMode TintMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color TintColor;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color TintColor2;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float TintIntensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E73C", Offset = "0x87E73C")]
	public float TintGradient;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E754", Offset = "0x87E754")]
	public float Intensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E76C", Offset = "0x87E76C")]
	public float Strength;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Color Color;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E784", Offset = "0x87E784")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E784", Offset = "0x87E784")]
	public float MieScattering;

	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E7DC", Offset = "0x87E7DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E7DC", Offset = "0x87E7DC")]
	public float SunSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E830", Offset = "0x87E830")]
	public bool SunBleed;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E868", Offset = "0x87E868")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E868", Offset = "0x87E868")]
	public float Extinction;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E8BC", Offset = "0x87E8BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E8BC", Offset = "0x87E8BC")]
	public float Density;

	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E910", Offset = "0x87E910")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E910", Offset = "0x87E910")]
	public float ExtraDensity;

	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E964", Offset = "0x87E964")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E964", Offset = "0x87E964")]
	public int SampleCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87E9BC", Offset = "0x87E9BC")]
	public bool Shadows;

	[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
	public bool FogHeightEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float FogHeight;

	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float FogTransitionSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float MaxLightDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float AboveFogPercent;

	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool OffsetUpdated;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public Vector3 Offset;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static MaterialPropertyBlock propertyBlock;

	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool bufferBuilt;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int VolumetricBMVPPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int VolumetricMVPPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static int VolumetricMVP2PID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static int VolumetricMVPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int LightColourPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static int LightColour2PID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int FogHeightsPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static int PhasePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int _LightParamsPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int DensityPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int ShadowBiasPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int _CustomLightPositionPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int hxNearPlanePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int NoiseScalePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int NoiseOffsetPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static int _SpotLightParamsPID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static int _LightTexture0PID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int _hxProjectorTexturePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static int _hxProjectorFalloffTexturePID;

	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	private bool LastBufferDirectional;

	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private float LastSpotAngle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float LastRange;

	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float LastAspect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private LightType lastType;

	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Matrix4x4 LightMatrix;

	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private Bounds lastBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Vector3 minBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Vector3 maxBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private HxOctreeNode<HxVolumetricLight>.NodeObject octreeNode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Vector4 TopFrustumNormal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Vector4 BottomFrustumNormal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Vector4 LeftFrustumNormal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Vector4 RightFrustumNormal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Matrix4x4[] VolumeMatrixArrays;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Vector4[] VolumeSettingsArrays;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static Matrix4x4[] VolumeMatrixArraysOld;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static Vector4[] VolumeSettingsArraysOld;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private float LastOrthoSize;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private bool LastOrtho;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
	private bool matrixReconstruct;

	[Address(RVA = "0x1425438", Offset = "0x1425438", VA = "0x1425438")]
	public Light LightSafe()
	{
		return null;
	}

	[Address(RVA = "0x14254D0", Offset = "0x14254D0", VA = "0x14254D0")]
	public HxDummyLight DummyLightSafe()
	{
		return null;
	}

	[Address(RVA = "0x1425568", Offset = "0x1425568", VA = "0x1425568")]
	private LightType GetLightType()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(LightType);
	}

	[Address(RVA = "0x142565C", Offset = "0x142565C", VA = "0x142565C")]
	private LightShadows LightShadow()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(LightShadows);
	}

	[Address(RVA = "0x14256FC", Offset = "0x14256FC", VA = "0x14256FC")]
	private bool HasLight()
	{
		return default(bool);
	}

	[Address(RVA = "0x14257B8", Offset = "0x14257B8", VA = "0x14257B8")]
	private Texture LightCookie()
	{
		return null;
	}

	[Address(RVA = "0x14258AC", Offset = "0x14258AC", VA = "0x14258AC")]
	private Texture LightFalloffTexture()
	{
		return null;
	}

	[Address(RVA = "0x1425968", Offset = "0x1425968", VA = "0x1425968")]
	private float LightShadowBias()
	{
		return default(float);
	}

	[Address(RVA = "0x1425A14", Offset = "0x1425A14", VA = "0x1425A14")]
	private Color LightColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Address(RVA = "0x1425BD8", Offset = "0x1425BD8", VA = "0x1425BD8")]
	private float LightSpotAngle()
	{
		return default(float);
	}

	[Address(RVA = "0x1425D24", Offset = "0x1425D24", VA = "0x1425D24")]
	private bool LightEnabled()
	{
		return default(bool);
	}

	[Address(RVA = "0x1425F20", Offset = "0x1425F20", VA = "0x1425F20")]
	private float LightRange()
	{
		return default(float);
	}

	[Address(RVA = "0x142606C", Offset = "0x142606C", VA = "0x142606C")]
	private float LightShadowStrength()
	{
		return default(float);
	}

	[Address(RVA = "0x142610C", Offset = "0x142610C", VA = "0x142610C")]
	private float LightIntensity()
	{
		return default(float);
	}

	[Address(RVA = "0x1426238", Offset = "0x1426238", VA = "0x1426238")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x1426400", Offset = "0x1426400", VA = "0x1426400")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x1426520", Offset = "0x1426520", VA = "0x1426520")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x1426634", Offset = "0x1426634", VA = "0x1426634")]
	private void Start()
	{
	}

	[Address(RVA = "0x1423C5C", Offset = "0x1423C5C", VA = "0x1423C5C")]
	public void BuildBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Address(RVA = "0x1423B60", Offset = "0x1423B60", VA = "0x1423B60")]
	public void ReleaseBuffer()
	{
	}

	[Address(RVA = "0x1412F5C", Offset = "0x1412F5C", VA = "0x1412F5C")]
	public static void CreatePID()
	{
	}

	[Address(RVA = "0x142C350", Offset = "0x142C350", VA = "0x142C350")]
	private float LightNearPlane()
	{
		return default(float);
	}

	[Address(RVA = "0x142C3F4", Offset = "0x142C3F4", VA = "0x142C3F4")]
	private int DirectionalPass(CommandBuffer buffer)
	{
		return default(int);
	}

	[Address(RVA = "0x142C970", Offset = "0x142C970", VA = "0x142C970")]
	private float getContrast()
	{
		return default(float);
	}

	[Address(RVA = "0x142CA00", Offset = "0x142CA00", VA = "0x142CA00")]
	private bool ShaderModel4()
	{
		return default(bool);
	}

	[Address(RVA = "0x14266A4", Offset = "0x14266A4", VA = "0x14266A4")]
	private void BuildDirectionalBuffer(CommandBuffer CameraBuffer)
	{
	}

	[Address(RVA = "0x142CFF4", Offset = "0x142CFF4", VA = "0x142CFF4")]
	private void LoadVolumeDateIntoBuffer(CommandBuffer buffer)
	{
	}

	[Address(RVA = "0x142DA94", Offset = "0x142DA94", VA = "0x142DA94")]
	private float CalcLightInstensityDistance(float distance)
	{
		return default(float);
	}

	[Address(RVA = "0x1427D7C", Offset = "0x1427D7C", VA = "0x1427D7C")]
	private void BuildSpotLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Address(RVA = "0x142AC7C", Offset = "0x142AC7C", VA = "0x142AC7C")]
	private void BuildProjectorLightBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Address(RVA = "0x142E1F8", Offset = "0x142E1F8", VA = "0x142E1F8")]
	private void SetColors(CommandBuffer buffer, float distanceLerp)
	{
	}

	[Address(RVA = "0x142D0C0", Offset = "0x142D0C0", VA = "0x142D0C0")]
	private void SetColors(CommandBuffer buffer)
	{
	}

	[Address(RVA = "0x142EE44", Offset = "0x142EE44", VA = "0x142EE44")]
	private Vector3 CalcTintColor(Vector4 c)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0x142F0F8", Offset = "0x142F0F8", VA = "0x142F0F8")]
	private Vector3 CalcTintColorEdge(Vector4 c)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0x14295B8", Offset = "0x14295B8", VA = "0x14295B8")]
	private void BuildPointBuffer(CommandBuffer cameraBuffer)
	{
	}

	[Address(RVA = "0x142D7E0", Offset = "0x142D7E0", VA = "0x142D7E0")]
	public int MID(bool RenderShadows, bool full)
	{
		return default(int);
	}

	[Address(RVA = "0x142F3AC", Offset = "0x142F3AC", VA = "0x142F3AC")]
	private void Update()
	{
	}

	[Address(RVA = "0x142CA08", Offset = "0x142CA08", VA = "0x142CA08")]
	private float GetFogDensity()
	{
		return default(float);
	}

	[Address(RVA = "0x142D9D4", Offset = "0x142D9D4", VA = "0x142D9D4")]
	private Texture3D GetNoiseTexture()
	{
		return null;
	}

	[Address(RVA = "0x142D6DC", Offset = "0x142D6DC", VA = "0x142D6DC")]
	private int GetSampleCount(bool RenderShadows)
	{
		return default(int);
	}

	[Address(RVA = "0x142F3B4", Offset = "0x142F3B4", VA = "0x142F3B4")]
	public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0x142DBBC", Offset = "0x142DBBC", VA = "0x142DBBC")]
	private float ClosestDistanceToCone(Vector3 Point)
	{
		return default(float);
	}

	[Address(RVA = "0x142F5A0", Offset = "0x142F5A0", VA = "0x142F5A0")]
	private void UpdateLightMatrix()
	{
	}

	[Address(RVA = "0x142FAA4", Offset = "0x142FAA4", VA = "0x142FAA4")]
	private void CheckLightType()
	{
	}

	[Address(RVA = "0x142CAA0", Offset = "0x142CAA0", VA = "0x142CAA0")]
	private void LoadVolumeData()
	{
	}

	[Address(RVA = "0x142FC30", Offset = "0x142FC30", VA = "0x142FC30")]
	private bool BoundsIntersect(HxDensityVolume vol)
	{
		return default(bool);
	}

	[Address(RVA = "0x142E89C", Offset = "0x142E89C", VA = "0x142E89C")]
	private void LoadVolumeDataBounds()
	{
	}

	[Address(RVA = "0x142FCCC", Offset = "0x142FCCC", VA = "0x142FCCC")]
	private Vector4 NormalOfTriangle(Vector3 a, Vector3 b, Vector3 c)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector4);
	}

	[Address(RVA = "0x142FE20", Offset = "0x142FE20", VA = "0x142FE20")]
	private void DrawIntersect()
	{
	}

	[Address(RVA = "0x1430964", Offset = "0x1430964", VA = "0x1430964")]
	private float GetAspect()
	{
		return default(float);
	}

	[Address(RVA = "0x1430A04", Offset = "0x1430A04", VA = "0x1430A04")]
	private float GetOrthoSize()
	{
		return default(float);
	}

	[Address(RVA = "0x1430AA4", Offset = "0x1430AA4", VA = "0x1430AA4")]
	private bool GetOrtho()
	{
		return default(bool);
	}

	[Address(RVA = "0x1422330", Offset = "0x1422330", VA = "0x1422330")]
	public void UpdatePosition(bool first = false)
	{
	}

	[Address(RVA = "0x1430B44", Offset = "0x1430B44", VA = "0x1430B44")]
	public void DrawBounds()
	{
	}

	[Address(RVA = "0x1431174", Offset = "0x1431174", VA = "0x1431174")]
	public HxVolumetricLight()
	{
	}
}
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BDD4", Offset = "0x87BDD4")]
public class HxVolumetricParticleSystem : MonoBehaviour
{
	public enum ParticleBlendMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Max,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Add,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Min,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sub
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87E9F4", Offset = "0x87E9F4")]
	public float DensityStrength;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HxOctreeNode<HxVolumetricParticleSystem>.NodeObject octreeNode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA0C", Offset = "0x87EA0C")]
	public Renderer particleRenderer;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleBlendMode BlendMode;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 minBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 maxBounds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Bounds LastBounds;

	[Address(RVA = "0xFBD018", Offset = "0xFBD018", VA = "0xFBD018")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0xFBD144", Offset = "0xFBD144", VA = "0xFBD144")]
	public void UpdatePosition()
	{
	}

	[Address(RVA = "0xFBD2DC", Offset = "0xFBD2DC", VA = "0xFBD2DC")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0xFBD384", Offset = "0xFBD384", VA = "0xFBD384")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0xFBD42C", Offset = "0xFBD42C", VA = "0xFBD42C")]
	public HxVolumetricParticleSystem()
	{
	}
}
public class HxVolumetricRenderCallback : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HxVolumetricCamera volumetricCamera;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA1C", Offset = "0x87EA1C")]
	public HxVolumetricCamera.hxRenderOrder RenderOrder;

	[Address(RVA = "0xFBD444", Offset = "0xFBD444", VA = "0xFBD444")]
	public HxVolumetricRenderCallback()
	{
	}
}
public class HxVolumetricShadersUsed : ScriptableObject
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HxVolumetricCamera.TransparencyQualities TransperencyQuality;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public HxVolumetricCamera.DensityParticleQualities DensityParticleQuality;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA2C", Offset = "0x87EA2C")]
	public HxVolumetricCamera.DensityParticleQualities LastDensityParticleQuality;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA3C", Offset = "0x87EA3C")]
	public HxVolumetricCamera.TransparencyQualities LastTransperencyQuality;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HxVolumetricShadersUsed instance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Full;

	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool LowRes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool HeightFog;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool HeightFogOff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool Noise;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool NoiseOff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool Transparency;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool TransparencyOff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool DensityParticles;

	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool Point;

	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool Spot;

	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool Directional;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool SinglePassStereo;

	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool Projector;

	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA4C", Offset = "0x87EA4C")]
	public bool FullLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA5C", Offset = "0x87EA5C")]
	public bool LowResLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA6C", Offset = "0x87EA6C")]
	public bool HeightFogLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA7C", Offset = "0x87EA7C")]
	public bool HeightFogOffLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA8C", Offset = "0x87EA8C")]
	public bool NoiseLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EA9C", Offset = "0x87EA9C")]
	public bool NoiseOffLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EAAC", Offset = "0x87EAAC")]
	public bool TransparencyLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EABC", Offset = "0x87EABC")]
	public bool TransparencyOffLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EACC", Offset = "0x87EACC")]
	public bool DensityParticlesLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EADC", Offset = "0x87EADC")]
	public bool PointLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EAEC", Offset = "0x87EAEC")]
	public bool SpotLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EAFC", Offset = "0x87EAFC")]
	public bool DirectionalLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EB0C", Offset = "0x87EB0C")]
	public bool SinglePassStereoLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EB1C", Offset = "0x87EB1C")]
	public bool ProjectorLast;

	[Address(RVA = "0xFBD44C", Offset = "0xFBD44C", VA = "0xFBD44C")]
	private bool CheckDirty()
	{
		return default(bool);
	}

	[Address(RVA = "0xFBD768", Offset = "0xFBD768", VA = "0xFBD768")]
	public HxVolumetricShadersUsed()
	{
	}
}
public class LeanAudioStream
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Address(RVA = "0xFD7AFC", Offset = "0xFD7AFC", VA = "0xFD7AFC")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Address(RVA = "0xFD8400", Offset = "0xFD8400", VA = "0xFD8400")]
	public void OnAudioRead(float[] data)
	{
	}

	[Address(RVA = "0xFD84C0", Offset = "0xFD84C0", VA = "0xFD84C0")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
public class LeanAudio
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Address(RVA = "0xFD6B58", Offset = "0xFD6B58", VA = "0xFD6B58")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Address(RVA = "0xFD6C7C", Offset = "0xFD6C7C", VA = "0xFD6C7C")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Address(RVA = "0xFD7A3C", Offset = "0xFD7A3C", VA = "0xFD7A3C")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Address(RVA = "0xFD6D54", Offset = "0xFD6D54", VA = "0xFD6D54")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Address(RVA = "0xFD72D0", Offset = "0xFD72D0", VA = "0xFD72D0")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Address(RVA = "0xFD7B28", Offset = "0xFD7B28", VA = "0xFD7B28")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Address(RVA = "0xFD7B2C", Offset = "0xFD7B2C", VA = "0xFD7B2C")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Address(RVA = "0xFD7CDC", Offset = "0xFD7CDC", VA = "0xFD7CDC")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Address(RVA = "0xFD7F28", Offset = "0xFD7F28", VA = "0xFD7F28")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Address(RVA = "0xFD7FDC", Offset = "0xFD7FDC", VA = "0xFD7FDC")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Address(RVA = "0xFD8068", Offset = "0xFD8068", VA = "0xFD8068")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Address(RVA = "0xFD7DB8", Offset = "0xFD7DB8", VA = "0xFD7DB8")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Address(RVA = "0xFD8148", Offset = "0xFD8148", VA = "0xFD8148")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Address(RVA = "0xFD8330", Offset = "0xFD8330", VA = "0xFD8330")]
	public LeanAudio()
	{
	}
}
public class LeanAudioOptions
{
	public enum LeanAudioWaveStyle
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Square,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sawtooth,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Noise
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Address(RVA = "0xFD6C58", Offset = "0xFD6C58", VA = "0xFD6C58")]
	public LeanAudioOptions()
	{
	}

	[Address(RVA = "0xFD83AC", Offset = "0xFD83AC", VA = "0xFD83AC")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Address(RVA = "0xFD83B4", Offset = "0xFD83B4", VA = "0xFD83B4")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Address(RVA = "0xFD83BC", Offset = "0xFD83BC", VA = "0xFD83BC")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Address(RVA = "0xFD83C4", Offset = "0xFD83C4", VA = "0xFD83C4")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Address(RVA = "0xFD83D0", Offset = "0xFD83D0", VA = "0xFD83D0")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Address(RVA = "0xFD83DC", Offset = "0xFD83DC", VA = "0xFD83DC")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Address(RVA = "0xFD83E8", Offset = "0xFD83E8", VA = "0xFD83E8")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Address(RVA = "0xFD83F0", Offset = "0xFD83F0", VA = "0xFD83F0")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Address(RVA = "0xFD83F8", Offset = "0xFD83F8", VA = "0xFD83F8")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
public class LeanTester : MonoBehaviour
{
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD38", Offset = "0x87DD38")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0xFD9704", Offset = "0xFD9704", VA = "0xFD9704", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xFD9774", Offset = "0xFD9774", VA = "0xFD9774", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xFD955C", Offset = "0xFD955C", VA = "0xFD955C")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Address(RVA = "0xFD9598", Offset = "0xFD9598", VA = "0xFD9598", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Address(RVA = "0xFD959C", Offset = "0xFD959C", VA = "0xFD959C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Address(RVA = "0xFD970C", Offset = "0xFD970C", VA = "0xFD970C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Address(RVA = "0xFD94BC", Offset = "0xFD94BC", VA = "0xFD94BC")]
	public void Start()
	{
	}

	[Address(RVA = "0xFD94E8", Offset = "0xFD94E8", VA = "0xFD94E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x888958", Offset = "0x888958")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Address(RVA = "0xFD9588", Offset = "0xFD9588", VA = "0xFD9588")]
	public LeanTester()
	{
	}
}
public class LeanTest
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Address(RVA = "0xFD84C8", Offset = "0xFD84C8", VA = "0xFD84C8")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Address(RVA = "0xFD8544", Offset = "0xFD8544", VA = "0xFD8544")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Address(RVA = "0xFD9348", Offset = "0xFD9348", VA = "0xFD9348")]
	public static string padRight(int len)
	{
		return null;
	}

	[Address(RVA = "0xFD8BE4", Offset = "0xFD8BE4", VA = "0xFD8BE4")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Address(RVA = "0xFD93B8", Offset = "0xFD93B8", VA = "0xFD93B8")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Address(RVA = "0xFD8D40", Offset = "0xFD8D40", VA = "0xFD8D40")]
	public static string formatB(string str)
	{
		return null;
	}

	[Address(RVA = "0xFD8DA0", Offset = "0xFD8DA0", VA = "0xFD8DA0")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Address(RVA = "0xFD8F9C", Offset = "0xFD8F9C", VA = "0xFD8F9C")]
	public static void overview()
	{
	}

	[Address(RVA = "0xFD9430", Offset = "0xFD9430", VA = "0xFD9430")]
	public LeanTest()
	{
	}
}
public enum TweenAction
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_X,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_Y,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_Z,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_LOCAL_X,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_LOCAL_Y,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_LOCAL_Z,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_CURVED,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_CURVED_LOCAL,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_SPLINE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_SPLINE_LOCAL,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	SCALE_X,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	SCALE_Y,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	SCALE_Z,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE_X,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE_Y,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE_Z,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE_AROUND,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE_AROUND_LOCAL,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_ROTATEAROUND,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_PLAYSPRITE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ALPHA,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	TEXT_ALPHA,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_ALPHA,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVASGROUP_ALPHA,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ALPHA_VERTEX,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	COLOR,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CALLBACK_COLOR,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	TEXT_COLOR,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_COLOR,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_MOVE_X,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_MOVE_Y,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_MOVE_Z,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CALLBACK,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_LOCAL,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	MOVE_TO_TRANSFORM,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	ROTATE_LOCAL,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	SCALE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	VALUE3,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	GUI_MOVE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	GUI_MOVE_MARGIN,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	GUI_SCALE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	GUI_ALPHA,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	GUI_ROTATE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	DELAYED_SOUND,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_MOVE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_SCALE,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	CANVAS_SIZEDELTA
}
public enum LeanTweenType
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	notUsed,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	linear,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutQuad,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInQuad,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutQuad,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInCubic,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutCubic,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutCubic,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInQuart,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutQuart,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutQuart,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInQuint,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutQuint,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutQuint,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInSine,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutSine,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutSine,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInExpo,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutExpo,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutExpo,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInCirc,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutCirc,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutCirc,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInBounce,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutBounce,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutBounce,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInBack,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutBack,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutBack,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInElastic,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeOutElastic,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeInOutElastic,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeSpring,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	easeShake,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	punch,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	once,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	clamp,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	pingPong,
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	animationCurve
}
public class LeanTween : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool forceRealtimeTweens;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTSeq[] sequences;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr[] tweens;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int[] tweensFinished;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] tweensFinishedIds;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static LTDescr tween;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int tweenMaxSearch;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int maxTweens;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int maxSequences;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int frameRendered;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static GameObject _tweenEmpty;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static float dtEstimated;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static float dtManual;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static float dtActual;

	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static uint global_counter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static int i;

	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static int j;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int finishedCnt;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static AnimationCurve punch;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static AnimationCurve shake;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static int maxTweenReached;

	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public static int startSearch;

	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static LTDescr d;

	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Action<LTEvent>[] eventListeners;

	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static GameObject[] goListeners;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static int eventsMaxSearch;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public static int EVENTS_MAX;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static int LISTENERS_MAX;

	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int INIT_LISTENERS_MAX;

	public static int maxSearch
	{
		[Address(RVA = "0xFD9854", Offset = "0xFD9854", VA = "0xFD9854")]
		get
		{
			return default(int);
		}
	}

	public static int maxSimulataneousTweens
	{
		[Address(RVA = "0xFD98BC", Offset = "0xFD98BC", VA = "0xFD98BC")]
		get
		{
			return default(int);
		}
	}

	public static int tweensRunning
	{
		[Address(RVA = "0xFD9924", Offset = "0xFD9924", VA = "0xFD9924")]
		get
		{
			return default(int);
		}
	}

	public static GameObject tweenEmpty
	{
		[Address(RVA = "0xFDE11C", Offset = "0xFDE11C", VA = "0xFDE11C")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xFD977C", Offset = "0xFD977C", VA = "0xFD977C")]
	public static void init()
	{
	}

	[Address(RVA = "0xFD9A20", Offset = "0xFD9A20", VA = "0xFD9A20")]
	public static LTDescr AddTween(GameObject gameObject, Vector3 to, float time, TweenAction tweenAction, LTDescr tween)
	{
		return null;
	}

	[Address(RVA = "0xFD97E4", Offset = "0xFD97E4", VA = "0xFD97E4")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Address(RVA = "0xFD9BDC", Offset = "0xFD9BDC", VA = "0xFD9BDC")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Address(RVA = "0xFDA048", Offset = "0xFDA048", VA = "0xFDA048")]
	public static void reset()
	{
	}

	[Address(RVA = "0xFDA204", Offset = "0xFDA204", VA = "0xFDA204")]
	public void Update()
	{
	}

	[Address(RVA = "0xFDA870", Offset = "0xFDA870", VA = "0xFDA870")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Address(RVA = "0xFDA8E0", Offset = "0xFDA8E0", VA = "0xFDA8E0")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Address(RVA = "0xFDA260", Offset = "0xFDA260", VA = "0xFDA260")]
	public static void update()
	{
	}

	[Address(RVA = "0xFBFA28", Offset = "0xFBFA28", VA = "0xFBFA28")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Address(RVA = "0xFDA93C", Offset = "0xFDA93C", VA = "0xFDA93C")]
	public static void removeTween(int i)
	{
	}

	[Address(RVA = "0xFDAE7C", Offset = "0xFDAE7C", VA = "0xFDAE7C")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Address(RVA = "0xFCBE4C", Offset = "0xFCBE4C", VA = "0xFCBE4C")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Address(RVA = "0xFDB068", Offset = "0xFDB068", VA = "0xFDB068")]
	public static void cancelAll()
	{
	}

	[Address(RVA = "0xFDB0C8", Offset = "0xFDB0C8", VA = "0xFDB0C8")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Address(RVA = "0xFDB334", Offset = "0xFDB334", VA = "0xFDB334")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Address(RVA = "0xFDB39C", Offset = "0xFDB39C", VA = "0xFDB39C")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Address(RVA = "0xFDB698", Offset = "0xFDB698", VA = "0xFDB698")]
	public static void cancel(RectTransform rect)
	{
	}

	[Address(RVA = "0xFDB720", Offset = "0xFDB720", VA = "0xFDB720")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Address(RVA = "0xFDBA88", Offset = "0xFDBA88", VA = "0xFDBA88")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Address(RVA = "0xFDBC0C", Offset = "0xFDBC0C", VA = "0xFDBC0C")]
	public static void cancel(int uniqueId)
	{
	}

	[Address(RVA = "0xFDBC74", Offset = "0xFDBC74", VA = "0xFDBC74")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Address(RVA = "0xFDBFE4", Offset = "0xFDBFE4", VA = "0xFDBFE4")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Address(RVA = "0xFDC34C", Offset = "0xFDC34C", VA = "0xFDC34C")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Address(RVA = "0xFDC3B0", Offset = "0xFDC3B0", VA = "0xFDC3B0")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Address(RVA = "0xFDC654", Offset = "0xFDC654", VA = "0xFDC654")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8889BC", Offset = "0x8889BC")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Address(RVA = "0xFDC6B8", Offset = "0xFDC6B8", VA = "0xFDC6B8")]
	public static void pause(int uniqueId)
	{
	}

	[Address(RVA = "0xFDC7F0", Offset = "0xFDC7F0", VA = "0xFDC7F0")]
	public static void pause(GameObject gameObject)
	{
	}

	[Address(RVA = "0xFDC9A8", Offset = "0xFDC9A8", VA = "0xFDC9A8")]
	public static void pauseAll()
	{
	}

	[Address(RVA = "0xFDCABC", Offset = "0xFDCABC", VA = "0xFDCABC")]
	public static void resumeAll()
	{
	}

	[Address(RVA = "0xFDCBC4", Offset = "0xFDCBC4", VA = "0xFDCBC4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8889F4", Offset = "0x8889F4")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Address(RVA = "0xFDCC28", Offset = "0xFDCC28", VA = "0xFDCC28")]
	public static void resume(int uniqueId)
	{
	}

	[Address(RVA = "0xFDCD54", Offset = "0xFDCD54", VA = "0xFDCD54")]
	public static void resume(GameObject gameObject)
	{
	}

	[Address(RVA = "0xFDCF00", Offset = "0xFDCF00", VA = "0xFDCF00")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Address(RVA = "0xFDD18C", Offset = "0xFDD18C", VA = "0xFDD18C")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Address(RVA = "0xFDD210", Offset = "0xFDD210", VA = "0xFDD210")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Address(RVA = "0xFDD370", Offset = "0xFDD370", VA = "0xFDD370")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Address(RVA = "0xFDD4F0", Offset = "0xFDD4F0", VA = "0xFDD4F0")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Address(RVA = "0xFBE2C0", Offset = "0xFBE2C0", VA = "0xFBE2C0")]
	public static object logError(string error)
	{
		return null;
	}

	[Address(RVA = "0xFDDC68", Offset = "0xFDDC68", VA = "0xFDDC68")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Address(RVA = "0xFDDCDC", Offset = "0xFDDCDC", VA = "0xFDDCDC")]
	public static LTDescr options()
	{
		return null;
	}

	[Address(RVA = "0xFD9AC4", Offset = "0xFD9AC4", VA = "0xFD9AC4")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Address(RVA = "0xFDE194", Offset = "0xFDE194", VA = "0xFDE194")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Address(RVA = "0xFDE2F8", Offset = "0xFDE2F8", VA = "0xFDE2F8")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFD45BC", Offset = "0xFD45BC", VA = "0xFD45BC")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Address(RVA = "0xFDE3FC", Offset = "0xFDE3FC", VA = "0xFDE3FC")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDE504", Offset = "0xFDE504", VA = "0xFDE504")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDE5E8", Offset = "0xFDE5E8", VA = "0xFDE5E8")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDE6CC", Offset = "0xFDE6CC", VA = "0xFDE6CC")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDE7B0", Offset = "0xFDE7B0", VA = "0xFDE7B0")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDE878", Offset = "0xFDE878", VA = "0xFDE878")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDE9F4", Offset = "0xFDE9F4", VA = "0xFDE9F4")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDEB50", Offset = "0xFDEB50", VA = "0xFDEB50")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFD4A5C", Offset = "0xFD4A5C", VA = "0xFD4A5C")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Address(RVA = "0xFD4CAC", Offset = "0xFD4CAC", VA = "0xFD4CAC")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Address(RVA = "0xFD4E4C", Offset = "0xFD4E4C", VA = "0xFD4E4C")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Address(RVA = "0xFD5018", Offset = "0xFD5018", VA = "0xFD5018")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Address(RVA = "0xFDECAC", Offset = "0xFDECAC", VA = "0xFDECAC")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Address(RVA = "0xFDEDBC", Offset = "0xFDEDBC", VA = "0xFDEDBC")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDEE6C", Offset = "0xFDEE6C", VA = "0xFDEE6C")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDEF6C", Offset = "0xFDEF6C", VA = "0xFDEF6C")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF160", Offset = "0xFDF160", VA = "0xFDF160")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF26C", Offset = "0xFDF26C", VA = "0xFDF26C")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF378", Offset = "0xFDF378", VA = "0xFDF378")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF4C0", Offset = "0xFDF4C0", VA = "0xFDF4C0")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF5CC", Offset = "0xFDF5CC", VA = "0xFDF5CC")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF714", Offset = "0xFDF714", VA = "0xFDF714")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF82C", Offset = "0xFDF82C", VA = "0xFDF82C")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDF944", Offset = "0xFDF944", VA = "0xFDF944")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFA0C", Offset = "0xFDFA0C", VA = "0xFDFA0C")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFAD4", Offset = "0xFDFAD4", VA = "0xFDFAD4")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFB9C", Offset = "0xFDFB9C", VA = "0xFDFB9C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFC4C", Offset = "0xFDFC4C", VA = "0xFDFC4C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFE40", Offset = "0xFDFE40", VA = "0xFDFE40")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFF08", Offset = "0xFDFF08", VA = "0xFDFF08")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFDFFD0", Offset = "0xFDFFD0", VA = "0xFDFFD0")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0098", Offset = "0xFE0098", VA = "0xFE0098")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE01A4", Offset = "0xFE01A4", VA = "0xFE01A4")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE02B0", Offset = "0xFE02B0", VA = "0xFE02B0")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE03A8", Offset = "0xFE03A8", VA = "0xFE03A8")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0458", Offset = "0xFE0458", VA = "0xFE0458")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE054C", Offset = "0xFE054C", VA = "0xFE054C")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE05FC", Offset = "0xFE05FC", VA = "0xFE05FC")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE06C4", Offset = "0xFE06C4", VA = "0xFE06C4")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE078C", Offset = "0xFE078C", VA = "0xFE078C")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0854", Offset = "0xFE0854", VA = "0xFE0854")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0958", Offset = "0xFE0958", VA = "0xFE0958")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0A64", Offset = "0xFE0A64", VA = "0xFE0A64")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0B14", Offset = "0xFE0B14", VA = "0xFE0B14")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0C2C", Offset = "0xFE0C2C", VA = "0xFE0C2C")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0CF4", Offset = "0xFE0CF4", VA = "0xFE0CF4")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0DBC", Offset = "0xFE0DBC", VA = "0xFE0DBC")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0E84", Offset = "0xFE0E84", VA = "0xFE0E84")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE0F94", Offset = "0xFE0F94", VA = "0xFE0F94")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE10A8", Offset = "0xFE10A8", VA = "0xFE10A8")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE1204", Offset = "0xFE1204", VA = "0xFE1204")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE12EC", Offset = "0xFE12EC", VA = "0xFE12EC")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE14A4", Offset = "0xFE14A4", VA = "0xFE14A4")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE1620", Offset = "0xFE1620", VA = "0xFE1620")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE179C", Offset = "0xFE179C", VA = "0xFE179C")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE19AC", Offset = "0xFE19AC", VA = "0xFE19AC")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE1BBC", Offset = "0xFE1BBC", VA = "0xFE1BBC")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE1D48", Offset = "0xFE1D48", VA = "0xFE1D48")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE1E7C", Offset = "0xFE1E7C", VA = "0xFE1E7C")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE1FEC", Offset = "0xFE1FEC", VA = "0xFE1FEC")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Address(RVA = "0xFE212C", Offset = "0xFE212C", VA = "0xFE212C")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Address(RVA = "0xFE2268", Offset = "0xFE2268", VA = "0xFE2268")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE234C", Offset = "0xFE234C", VA = "0xFE234C")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2444", Offset = "0xFE2444", VA = "0xFE2444")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE253C", Offset = "0xFE253C", VA = "0xFE253C")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2634", Offset = "0xFE2634", VA = "0xFE2634")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2780", Offset = "0xFE2780", VA = "0xFE2780")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE28C0", Offset = "0xFE28C0", VA = "0xFE28C0")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2A00", Offset = "0xFE2A00", VA = "0xFE2A00")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2B40", Offset = "0xFE2B40", VA = "0xFE2B40")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2C24", Offset = "0xFE2C24", VA = "0xFE2C24")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2D40", Offset = "0xFE2D40", VA = "0xFE2D40")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2E38", Offset = "0xFE2E38", VA = "0xFE2E38")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Address(RVA = "0xFE2FA0", Offset = "0xFE2FA0", VA = "0xFE2FA0")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3038", Offset = "0xFE3038", VA = "0xFE3038")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFE3198", Offset = "0xFE3198", VA = "0xFE3198")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Address(RVA = "0xFE31B0", Offset = "0xFE31B0", VA = "0xFE31B0")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Address(RVA = "0xFE31C0", Offset = "0xFE31C0", VA = "0xFE31C0")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3210", Offset = "0xFE3210", VA = "0xFE3210")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFE334C", Offset = "0xFE334C", VA = "0xFE334C")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE33D4", Offset = "0xFE33D4", VA = "0xFE33D4")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE34A0", Offset = "0xFE34A0", VA = "0xFE34A0")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE35A4", Offset = "0xFE35A4", VA = "0xFE35A4")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE35B8", Offset = "0xFE35B8", VA = "0xFE35B8")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE35D4", Offset = "0xFE35D4", VA = "0xFE35D4")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3628", Offset = "0xFE3628", VA = "0xFE3628")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Address(RVA = "0xFE365C", Offset = "0xFE365C", VA = "0xFE365C")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3674", Offset = "0xFE3674", VA = "0xFE3674")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE369C", Offset = "0xFE369C", VA = "0xFE369C")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE36F4", Offset = "0xFE36F4", VA = "0xFE36F4")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3710", Offset = "0xFE3710", VA = "0xFE3710")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3738", Offset = "0xFE3738", VA = "0xFE3738")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3794", Offset = "0xFE3794", VA = "0xFE3794")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE37B4", Offset = "0xFE37B4", VA = "0xFE37B4")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE37E4", Offset = "0xFE37E4", VA = "0xFE37E4")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE384C", Offset = "0xFE384C", VA = "0xFE384C")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE38E4", Offset = "0xFE38E4", VA = "0xFE38E4")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3978", Offset = "0xFE3978", VA = "0xFE3978")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3A1C", Offset = "0xFE3A1C", VA = "0xFE3A1C")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3AB4", Offset = "0xFE3AB4", VA = "0xFE3AB4")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3B4C", Offset = "0xFE3B4C", VA = "0xFE3B4C")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3C3C", Offset = "0xFE3C3C", VA = "0xFE3C3C")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3CE8", Offset = "0xFE3CE8", VA = "0xFE3CE8")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3D94", Offset = "0xFE3D94", VA = "0xFE3D94")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFC8918", Offset = "0xFC8918", VA = "0xFC8918")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFC842C", Offset = "0xFC842C", VA = "0xFC842C")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3E8C", Offset = "0xFE3E8C", VA = "0xFE3E8C")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3F64", Offset = "0xFE3F64", VA = "0xFE3F64")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3F98", Offset = "0xFE3F98", VA = "0xFE3F98")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Address(RVA = "0xFE3FD8", Offset = "0xFE3FD8", VA = "0xFE3FD8")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Address(RVA = "0xFC8E60", Offset = "0xFC8E60", VA = "0xFC8E60")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Address(RVA = "0xFC909C", Offset = "0xFC909C", VA = "0xFC909C")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Address(RVA = "0xFC92C8", Offset = "0xFC92C8", VA = "0xFC92C8")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Address(RVA = "0xFE4070", Offset = "0xFE4070", VA = "0xFE4070")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Address(RVA = "0xFE40E8", Offset = "0xFE40E8", VA = "0xFE40E8")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Address(RVA = "0xFE4608", Offset = "0xFE4608", VA = "0xFE4608")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Address(RVA = "0xFE48FC", Offset = "0xFE48FC", VA = "0xFE48FC")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Address(RVA = "0xFE4680", Offset = "0xFE4680", VA = "0xFE4680")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Address(RVA = "0xFE49F0", Offset = "0xFE49F0", VA = "0xFE49F0")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Address(RVA = "0xFE4A58", Offset = "0xFE4A58", VA = "0xFE4A58")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Address(RVA = "0xFE4CD4", Offset = "0xFE4CD4", VA = "0xFE4CD4")]
	public LeanTween()
	{
	}
}
public class LTUtility
{
	[Address(RVA = "0xFCA628", Offset = "0xFCA628", VA = "0xFCA628")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Address(RVA = "0xFD6B50", Offset = "0xFD6B50", VA = "0xFD6B50")]
	public LTUtility()
	{
	}
}
public class LTBezier
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Address(RVA = "0xFBD77C", Offset = "0xFBD77C", VA = "0xFBD77C")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Address(RVA = "0xFBDBF4", Offset = "0xFBDBF4", VA = "0xFBDBF4")]
	private float map(float u)
	{
		return default(float);
	}

	[Address(RVA = "0xFBDB1C", Offset = "0xFBDB1C", VA = "0xFBDB1C")]
	private Vector3 bezierPoint(float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFBDE14", Offset = "0xFBDE14", VA = "0xFBDE14")]
	public Vector3 point(float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
public class LTBezierPath
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	public float distance
	{
		[Address(RVA = "0xFBE380", Offset = "0xFBE380", VA = "0xFBE380")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0xFBDE38", Offset = "0xFBDE38", VA = "0xFBDE38")]
	public LTBezierPath()
	{
	}

	[Address(RVA = "0xFBDE40", Offset = "0xFBDE40", VA = "0xFBDE40")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Address(RVA = "0xFBDE70", Offset = "0xFBDE70", VA = "0xFBDE70")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Address(RVA = "0xFBE388", Offset = "0xFBE388", VA = "0xFBE388")]
	public Vector3 point(float ratio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFBE560", Offset = "0xFBE560", VA = "0xFBE560")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFBE718", Offset = "0xFBE718", VA = "0xFBE718")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFBE8D0", Offset = "0xFBE8D0", VA = "0xFBE8D0")]
	public void place(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFBE974", Offset = "0xFBE974", VA = "0xFBE974")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Address(RVA = "0xFBEA6C", Offset = "0xFBEA6C", VA = "0xFBEA6C")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFBEB10", Offset = "0xFBEB10", VA = "0xFBEB10")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Address(RVA = "0xFBECC8", Offset = "0xFBECC8", VA = "0xFBECC8")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
public class LTSpline
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Address(RVA = "0xFCA7B0", Offset = "0xFCA7B0", VA = "0xFCA7B0")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Address(RVA = "0xFD56C0", Offset = "0xFD56C0", VA = "0xFD56C0")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Address(RVA = "0xFD52B0", Offset = "0xFD52B0", VA = "0xFD52B0")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Address(RVA = "0xFD5BD8", Offset = "0xFD5BD8", VA = "0xFD5BD8")]
	public Vector3 map(float u)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFD570C", Offset = "0xFD570C", VA = "0xFD570C")]
	public Vector3 interp(float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFD5DEC", Offset = "0xFD5DEC", VA = "0xFD5DEC")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Address(RVA = "0xFCB5DC", Offset = "0xFCB5DC", VA = "0xFCB5DC")]
	public Vector3 point(float ratio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFCB380", Offset = "0xFCB380", VA = "0xFCB380")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFCB7BC", Offset = "0xFCB7BC", VA = "0xFCB7BC")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFCB538", Offset = "0xFCB538", VA = "0xFCB538")]
	public void place(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFD5F44", Offset = "0xFD5F44", VA = "0xFD5F44")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Address(RVA = "0xFCB9F4", Offset = "0xFCB9F4", VA = "0xFCB9F4")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Address(RVA = "0xFD603C", Offset = "0xFD603C", VA = "0xFD603C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Address(RVA = "0xFD6190", Offset = "0xFD6190", VA = "0xFD6190")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Address(RVA = "0xFD628C", Offset = "0xFD628C", VA = "0xFD628C")]
	public void drawGizmo(Color color)
	{
	}

	[Address(RVA = "0xFD641C", Offset = "0xFD641C", VA = "0xFD641C")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Address(RVA = "0xFD66E0", Offset = "0xFD66E0", VA = "0xFD66E0")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Address(RVA = "0xFD66EC", Offset = "0xFD66EC", VA = "0xFD66EC")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Address(RVA = "0xFD6958", Offset = "0xFD6958", VA = "0xFD6958")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
public class LTRect
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EB2C", Offset = "0x87EB2C")]
	public bool rotateFinished;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x87EB3C", Offset = "0x87EB3C")]
	public int counter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	public bool hasInitiliazed
	{
		[Address(RVA = "0xFD296C", Offset = "0xFD296C", VA = "0xFD296C")]
		get
		{
			return default(bool);
		}
	}

	public int id
	{
		[Address(RVA = "0xFD31B4", Offset = "0xFD31B4", VA = "0xFD31B4")]
		get
		{
			return default(int);
		}
	}

	public float x
	{
		[Address(RVA = "0xFD3DFC", Offset = "0xFD3DFC", VA = "0xFD3DFC")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0xFD3E08", Offset = "0xFD3E08", VA = "0xFD3E08")]
		set
		{
		}
	}

	public float y
	{
		[Address(RVA = "0xFD3E14", Offset = "0xFD3E14", VA = "0xFD3E14")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0xFD3E20", Offset = "0xFD3E20", VA = "0xFD3E20")]
		set
		{
		}
	}

	public float width
	{
		[Address(RVA = "0xFD3E2C", Offset = "0xFD3E2C", VA = "0xFD3E2C")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0xFD3E38", Offset = "0xFD3E38", VA = "0xFD3E38")]
		set
		{
		}
	}

	public float height
	{
		[Address(RVA = "0xFD3E44", Offset = "0xFD3E44", VA = "0xFD3E44")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0xFD3E50", Offset = "0xFD3E50", VA = "0xFD3E50")]
		set
		{
		}
	}

	public Rect rect
	{
		[Address(RVA = "0xFD06B8", Offset = "0xFD06B8", VA = "0xFD06B8")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Rect);
		}
		[Address(RVA = "0xFD0A18", Offset = "0xFD0A18", VA = "0xFD0A18")]
		set
		{
		}
	}

	[Address(RVA = "0xFD3998", Offset = "0xFD3998", VA = "0xFD3998")]
	public LTRect()
	{
	}

	[Address(RVA = "0xFCA1DC", Offset = "0xFCA1DC", VA = "0xFCA1DC")]
	public LTRect(Rect rect)
	{
	}

	[Address(RVA = "0xFD3AF4", Offset = "0xFD3AF4", VA = "0xFD3AF4")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Address(RVA = "0xFD3BE4", Offset = "0xFD3BE4", VA = "0xFD3BE4")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Address(RVA = "0xFD3CE4", Offset = "0xFD3CE4", VA = "0xFD3CE4")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Address(RVA = "0xFD31C0", Offset = "0xFD31C0", VA = "0xFD31C0")]
	public void setId(int id, int counter)
	{
	}

	[Address(RVA = "0xFD3A70", Offset = "0xFD3A70", VA = "0xFD3A70")]
	public void reset()
	{
	}

	[Address(RVA = "0xFD0F10", Offset = "0xFD0F10", VA = "0xFD0F10")]
	public void resetForRotation()
	{
	}

	[Address(RVA = "0xFD3E5C", Offset = "0xFD3E5C", VA = "0xFD3E5C")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Address(RVA = "0xFD3E64", Offset = "0xFD3E64", VA = "0xFD3E64")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Address(RVA = "0xFD3E70", Offset = "0xFD3E70", VA = "0xFD3E70")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Address(RVA = "0xFD3E84", Offset = "0xFD3E84", VA = "0xFD3E84")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Address(RVA = "0xFD3E8C", Offset = "0xFD3E8C", VA = "0xFD3E8C")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Address(RVA = "0xFD3E94", Offset = "0xFD3E94", VA = "0xFD3E94")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Address(RVA = "0xFD3EA8", Offset = "0xFD3EA8", VA = "0xFD3EA8")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Address(RVA = "0xFD3F24", Offset = "0xFD3F24", VA = "0xFD3F24")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Address(RVA = "0xFD3F30", Offset = "0xFD3F30", VA = "0xFD3F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
public class LTEvent
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Address(RVA = "0xFD137C", Offset = "0xFD137C", VA = "0xFD137C")]
	public LTEvent(int id, object data)
	{
	}
}
public class LTGUI
{
	public enum Element_Type
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Texture,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Label
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Address(RVA = "0xFD13B8", Offset = "0xFD13B8", VA = "0xFD13B8")]
	public static void init()
	{
	}

	[Address(RVA = "0xFD1488", Offset = "0xFD1488", VA = "0xFD1488")]
	public static void initRectCheck()
	{
	}

	[Address(RVA = "0xFD1628", Offset = "0xFD1628", VA = "0xFD1628")]
	public static void reset()
	{
	}

	[Address(RVA = "0xFD17FC", Offset = "0xFD17FC", VA = "0xFD17FC")]
	public static void update(int updateLevel)
	{
	}

	[Address(RVA = "0xFD26AC", Offset = "0xFD26AC", VA = "0xFD26AC")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Address(RVA = "0xFD278C", Offset = "0xFD278C", VA = "0xFD278C")]
	public static void destroy(int id)
	{
	}

	[Address(RVA = "0xFD297C", Offset = "0xFD297C", VA = "0xFD297C")]
	public static void destroyAll(int depth)
	{
	}

	[Address(RVA = "0xFD2A8C", Offset = "0xFD2A8C", VA = "0xFD2A8C")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Address(RVA = "0xFD2B4C", Offset = "0xFD2B4C", VA = "0xFD2B4C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Address(RVA = "0xFD3054", Offset = "0xFD3054", VA = "0xFD3054")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Address(RVA = "0xFD3114", Offset = "0xFD3114", VA = "0xFD3114")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Address(RVA = "0xFD2BF4", Offset = "0xFD2BF4", VA = "0xFD2BF4")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Address(RVA = "0xFD31C8", Offset = "0xFD31C8", VA = "0xFD31C8")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Address(RVA = "0xFD35DC", Offset = "0xFD35DC", VA = "0xFD35DC")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Address(RVA = "0xFD3820", Offset = "0xFD3820", VA = "0xFD3820")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Address(RVA = "0xFD3700", Offset = "0xFD3700", VA = "0xFD3700")]
	public static Vector2 firstTouch()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Address(RVA = "0xFD38F4", Offset = "0xFD38F4", VA = "0xFD38F4")]
	public LTGUI()
	{
	}
}
public class LTDescr
{
	public delegate Vector3 EaseTypeDelegate();

	public delegate void ActionMethodDelegate();

	[Serializable]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD48", Offset = "0x87DD48")]
	private sealed class <>c
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__109_0;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ActionMethodDelegate <>9__110_0;

		[Address(RVA = "0xFD1288", Offset = "0xFD1288", VA = "0xFD1288")]
		public <>c()
		{
		}

		[Address(RVA = "0xFD1290", Offset = "0xFD1290", VA = "0xFD1290")]
		internal void <setCallback>b__109_0()
		{
		}

		[Address(RVA = "0xFD1294", Offset = "0xFD1294", VA = "0xFD1294")]
		internal void <setValue3>b__110_0()
		{
		}
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal Vector3 fromInternal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	internal Vector3 toInternal;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal Vector3 diff;

	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	internal Vector3 diffDiv2;

	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TweenAction type;

	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private LeanTweenType easeType;

	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LeanTweenType loopType;

	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool hasUpdateCallback;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public EaseTypeDelegate easeMethod;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EB4C", Offset = "0x87EB4C")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EB5C", Offset = "0x87EB5C")]
	private ActionMethodDelegate <initInternal>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SpriteRenderer spriteRen;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform rectTransform;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text uiText;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image uiImage;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public RawImage rawImage;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Sprite[] sprites;

	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public LTDescrOptional _optional;

	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	public Vector3 from
	{
		[Address(RVA = "0xFBEDA4", Offset = "0xFBEDA4", VA = "0xFBEDA4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Address(RVA = "0xFBEDB0", Offset = "0xFBEDB0", VA = "0xFBEDB0")]
		set
		{
		}
	}

	public Vector3 to
	{
		[Address(RVA = "0xFBEDBC", Offset = "0xFBEDBC", VA = "0xFBEDBC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Address(RVA = "0xFBEDC8", Offset = "0xFBEDC8", VA = "0xFBEDC8")]
		set
		{
		}
	}

	public ActionMethodDelegate easeInternal
	{
		[Address(RVA = "0xFBEDD4", Offset = "0xFBEDD4", VA = "0xFBEDD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888A2C", Offset = "0x888A2C")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFBEDDC", Offset = "0xFBEDDC", VA = "0xFBEDDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888A3C", Offset = "0x888A3C")]
		set
		{
		}
	}

	public ActionMethodDelegate initInternal
	{
		[Address(RVA = "0xFBEDE4", Offset = "0xFBEDE4", VA = "0xFBEDE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888A4C", Offset = "0x888A4C")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFBEDEC", Offset = "0xFBEDEC", VA = "0xFBEDEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888A5C", Offset = "0x888A5C")]
		set
		{
		}
	}

	public int uniqueId
	{
		[Address(RVA = "0xFBFA18", Offset = "0xFBFA18", VA = "0xFBFA18")]
		get
		{
			return default(int);
		}
	}

	public int id
	{
		[Address(RVA = "0xFBF8B0", Offset = "0xFBF8B0", VA = "0xFBF8B0")]
		get
		{
			return default(int);
		}
	}

	public LTDescrOptional optional
	{
		[Address(RVA = "0xFBFB2C", Offset = "0xFBFB2C", VA = "0xFBFB2C")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFBFB34", Offset = "0xFBFB34", VA = "0xFBFB34")]
		set
		{
		}
	}

	[Address(RVA = "0xFBEDF4", Offset = "0xFBEDF4", VA = "0xFBEDF4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Address(RVA = "0xFBF8C0", Offset = "0xFBF8C0", VA = "0xFBF8C0")]
	public LTDescr()
	{
	}

	[Address(RVA = "0xFBF938", Offset = "0xFBF938", VA = "0xFBF938")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x888A6C", Offset = "0x888A6C")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Address(RVA = "0xFBFB38", Offset = "0xFBFB38", VA = "0xFBFB38")]
	public void reset()
	{
	}

	[Address(RVA = "0xFBFCE4", Offset = "0xFBFCE4", VA = "0xFBFCE4")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Address(RVA = "0xFBFD8C", Offset = "0xFBFD8C", VA = "0xFBFD8C")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Address(RVA = "0xFBFE28", Offset = "0xFBFE28", VA = "0xFBFE28")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Address(RVA = "0xFBFEC4", Offset = "0xFBFEC4", VA = "0xFBFEC4")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Address(RVA = "0xFBFF60", Offset = "0xFBFF60", VA = "0xFBFF60")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Address(RVA = "0xFBFFFC", Offset = "0xFBFFFC", VA = "0xFBFFFC")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Address(RVA = "0xFC0098", Offset = "0xFC0098", VA = "0xFC0098")]
	private void initFromInternal()
	{
	}

	[Address(RVA = "0xFC00A0", Offset = "0xFC00A0", VA = "0xFC00A0")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Address(RVA = "0xFC013C", Offset = "0xFC013C", VA = "0xFC013C")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Address(RVA = "0xFC01D8", Offset = "0xFC01D8", VA = "0xFC01D8")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Address(RVA = "0xFC0274", Offset = "0xFC0274", VA = "0xFC0274")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Address(RVA = "0xFC0310", Offset = "0xFC0310", VA = "0xFC0310")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Address(RVA = "0xFC03AC", Offset = "0xFC03AC", VA = "0xFC03AC")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Address(RVA = "0xFC0448", Offset = "0xFC0448", VA = "0xFC0448")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Address(RVA = "0xFC04E4", Offset = "0xFC04E4", VA = "0xFC04E4")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Address(RVA = "0xFC0580", Offset = "0xFC0580", VA = "0xFC0580")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Address(RVA = "0xFC061C", Offset = "0xFC061C", VA = "0xFC061C")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Address(RVA = "0xFC06B8", Offset = "0xFC06B8", VA = "0xFC06B8")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Address(RVA = "0xFC0754", Offset = "0xFC0754", VA = "0xFC0754")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Address(RVA = "0xFC07F0", Offset = "0xFC07F0", VA = "0xFC07F0")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Address(RVA = "0xFC088C", Offset = "0xFC088C", VA = "0xFC088C")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Address(RVA = "0xFC0928", Offset = "0xFC0928", VA = "0xFC0928")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Address(RVA = "0xFC09C4", Offset = "0xFC09C4", VA = "0xFC09C4")]
	public LTDescr setColor()
	{
		return null;
	}

	[Address(RVA = "0xFC0A60", Offset = "0xFC0A60", VA = "0xFC0A60")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Address(RVA = "0xFC0AFC", Offset = "0xFC0AFC", VA = "0xFC0AFC")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Address(RVA = "0xFC0B98", Offset = "0xFC0B98", VA = "0xFC0B98")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Address(RVA = "0xFC0C34", Offset = "0xFC0C34", VA = "0xFC0C34")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Address(RVA = "0xFC0CD0", Offset = "0xFC0CD0", VA = "0xFC0CD0")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Address(RVA = "0xFC0D6C", Offset = "0xFC0D6C", VA = "0xFC0D6C")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Address(RVA = "0xFC0E08", Offset = "0xFC0E08", VA = "0xFC0E08")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Address(RVA = "0xFC0EA4", Offset = "0xFC0EA4", VA = "0xFC0EA4")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Address(RVA = "0xFC0F40", Offset = "0xFC0F40", VA = "0xFC0F40")]
	private void initCanvasRotateAround()
	{
	}

	[Address(RVA = "0xFC0FC0", Offset = "0xFC0FC0", VA = "0xFC0FC0")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Address(RVA = "0xFC105C", Offset = "0xFC105C", VA = "0xFC105C")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Address(RVA = "0xFC10F8", Offset = "0xFC10F8", VA = "0xFC10F8")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Address(RVA = "0xFC1194", Offset = "0xFC1194", VA = "0xFC1194")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Address(RVA = "0xFC1230", Offset = "0xFC1230", VA = "0xFC1230")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Address(RVA = "0xFC12CC", Offset = "0xFC12CC", VA = "0xFC12CC")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Address(RVA = "0xFC1368", Offset = "0xFC1368", VA = "0xFC1368")]
	private void callback()
	{
	}

	[Address(RVA = "0xFC1818", Offset = "0xFC1818", VA = "0xFC1818")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Address(RVA = "0xFC1924", Offset = "0xFC1924", VA = "0xFC1924")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Address(RVA = "0xFC1A30", Offset = "0xFC1A30", VA = "0xFC1A30")]
	public LTDescr setMove()
	{
		return null;
	}

	[Address(RVA = "0xFC1ACC", Offset = "0xFC1ACC", VA = "0xFC1ACC")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Address(RVA = "0xFC1B68", Offset = "0xFC1B68", VA = "0xFC1B68")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Address(RVA = "0xFC1C04", Offset = "0xFC1C04", VA = "0xFC1C04")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Address(RVA = "0xFC1CA0", Offset = "0xFC1CA0", VA = "0xFC1CA0")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Address(RVA = "0xFC1D3C", Offset = "0xFC1D3C", VA = "0xFC1D3C")]
	public LTDescr setScale()
	{
		return null;
	}

	[Address(RVA = "0xFC1DD8", Offset = "0xFC1DD8", VA = "0xFC1DD8")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Address(RVA = "0xFC1E74", Offset = "0xFC1E74", VA = "0xFC1E74")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Address(RVA = "0xFC1F10", Offset = "0xFC1F10", VA = "0xFC1F10")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Address(RVA = "0xFC1FAC", Offset = "0xFC1FAC", VA = "0xFC1FAC")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Address(RVA = "0xFC2048", Offset = "0xFC2048", VA = "0xFC2048")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Address(RVA = "0xFC20E4", Offset = "0xFC20E4", VA = "0xFC20E4")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Address(RVA = "0xFC2180", Offset = "0xFC2180", VA = "0xFC2180")]
	private void init()
	{
	}

	[Address(RVA = "0xFC2950", Offset = "0xFC2950", VA = "0xFC2950")]
	private void initSpeed()
	{
	}

	[Address(RVA = "0xFC2AA0", Offset = "0xFC2AA0", VA = "0xFC2AA0")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Address(RVA = "0xFC2AC4", Offset = "0xFC2AC4", VA = "0xFC2AC4")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Address(RVA = "0xFC2778", Offset = "0xFC2778", VA = "0xFC2778")]
	public void callOnCompletes()
	{
	}

	[Address(RVA = "0xFC3004", Offset = "0xFC3004", VA = "0xFC3004")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Address(RVA = "0xFC30F4", Offset = "0xFC30F4", VA = "0xFC30F4")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Address(RVA = "0xFC364C", Offset = "0xFC364C", VA = "0xFC364C")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Address(RVA = "0xFC3A58", Offset = "0xFC3A58", VA = "0xFC3A58")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Address(RVA = "0xFC3E90", Offset = "0xFC3E90", VA = "0xFC3E90")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Address(RVA = "0xFC4294", Offset = "0xFC4294", VA = "0xFC4294")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Address(RVA = "0xFC46EC", Offset = "0xFC46EC", VA = "0xFC46EC")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Address(RVA = "0xFC4B28", Offset = "0xFC4B28", VA = "0xFC4B28")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Address(RVA = "0xFC4ED4", Offset = "0xFC4ED4", VA = "0xFC4ED4")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Address(RVA = "0xFC5280", Offset = "0xFC5280", VA = "0xFC5280")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Address(RVA = "0xFC562C", Offset = "0xFC562C", VA = "0xFC562C")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Address(RVA = "0xFC57DC", Offset = "0xFC57DC", VA = "0xFC57DC")]
	public LTDescr pause()
	{
		return null;
	}

	[Address(RVA = "0xFC57F4", Offset = "0xFC57F4", VA = "0xFC57F4")]
	public LTDescr resume()
	{
		return null;
	}

	[Address(RVA = "0xFC5800", Offset = "0xFC5800", VA = "0xFC5800")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Address(RVA = "0xFC5854", Offset = "0xFC5854", VA = "0xFC5854")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Address(RVA = "0xFC585C", Offset = "0xFC585C", VA = "0xFC585C")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Address(RVA = "0xFC5998", Offset = "0xFC5998", VA = "0xFC5998")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Address(RVA = "0xFC69B0", Offset = "0xFC69B0", VA = "0xFC69B0")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Address(RVA = "0xFC5A88", Offset = "0xFC5A88", VA = "0xFC5A88")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Address(RVA = "0xFC5A10", Offset = "0xFC5A10", VA = "0xFC5A10")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Address(RVA = "0xFC5B00", Offset = "0xFC5B00", VA = "0xFC5B00")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Address(RVA = "0xFC5B78", Offset = "0xFC5B78", VA = "0xFC5B78")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Address(RVA = "0xFC5BF0", Offset = "0xFC5BF0", VA = "0xFC5BF0")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Address(RVA = "0xFC5C68", Offset = "0xFC5C68", VA = "0xFC5C68")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Address(RVA = "0xFC5CE0", Offset = "0xFC5CE0", VA = "0xFC5CE0")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Address(RVA = "0xFC5D58", Offset = "0xFC5D58", VA = "0xFC5D58")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Address(RVA = "0xFC5DD0", Offset = "0xFC5DD0", VA = "0xFC5DD0")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Address(RVA = "0xFC5E48", Offset = "0xFC5E48", VA = "0xFC5E48")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Address(RVA = "0xFC5EC0", Offset = "0xFC5EC0", VA = "0xFC5EC0")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Address(RVA = "0xFC5F38", Offset = "0xFC5F38", VA = "0xFC5F38")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Address(RVA = "0xFC5FB0", Offset = "0xFC5FB0", VA = "0xFC5FB0")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Address(RVA = "0xFC6028", Offset = "0xFC6028", VA = "0xFC6028")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Address(RVA = "0xFC60A0", Offset = "0xFC60A0", VA = "0xFC60A0")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Address(RVA = "0xFC6118", Offset = "0xFC6118", VA = "0xFC6118")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Address(RVA = "0xFC6190", Offset = "0xFC6190", VA = "0xFC6190")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Address(RVA = "0xFC6208", Offset = "0xFC6208", VA = "0xFC6208")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Address(RVA = "0xFC6280", Offset = "0xFC6280", VA = "0xFC6280")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Address(RVA = "0xFC62F8", Offset = "0xFC62F8", VA = "0xFC62F8")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Address(RVA = "0xFC6370", Offset = "0xFC6370", VA = "0xFC6370")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Address(RVA = "0xFC63E8", Offset = "0xFC63E8", VA = "0xFC63E8")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Address(RVA = "0xFC6460", Offset = "0xFC6460", VA = "0xFC6460")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Address(RVA = "0xFC64D8", Offset = "0xFC64D8", VA = "0xFC64D8")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Address(RVA = "0xFC6550", Offset = "0xFC6550", VA = "0xFC6550")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Address(RVA = "0xFC65C8", Offset = "0xFC65C8", VA = "0xFC65C8")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Address(RVA = "0xFC6640", Offset = "0xFC6640", VA = "0xFC6640")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Address(RVA = "0xFC66B8", Offset = "0xFC66B8", VA = "0xFC66B8")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Address(RVA = "0xFC6730", Offset = "0xFC6730", VA = "0xFC6730")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Address(RVA = "0xFC67A8", Offset = "0xFC67A8", VA = "0xFC67A8")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Address(RVA = "0xFC6820", Offset = "0xFC6820", VA = "0xFC6820")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Address(RVA = "0xFC68E8", Offset = "0xFC68E8", VA = "0xFC68E8")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Address(RVA = "0xFC6A28", Offset = "0xFC6A28", VA = "0xFC6A28")]
	private Vector3 tweenOnCurve()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC6B64", Offset = "0xFC6B64", VA = "0xFC6B64")]
	private Vector3 easeInOutQuad()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC6C50", Offset = "0xFC6C50", VA = "0xFC6C50")]
	private Vector3 easeInQuad()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC6D04", Offset = "0xFC6D04", VA = "0xFC6D04")]
	private Vector3 easeOutQuad()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC6DE0", Offset = "0xFC6DE0", VA = "0xFC6DE0")]
	private Vector3 easeLinear()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC6E90", Offset = "0xFC6E90", VA = "0xFC6E90")]
	private Vector3 easeSpring()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7034", Offset = "0xFC7034", VA = "0xFC7034")]
	private Vector3 easeInCubic()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC70EC", Offset = "0xFC70EC", VA = "0xFC70EC")]
	private Vector3 easeOutCubic()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC71C4", Offset = "0xFC71C4", VA = "0xFC71C4")]
	private Vector3 easeInOutCubic()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC72C8", Offset = "0xFC72C8", VA = "0xFC72C8")]
	private Vector3 easeInQuart()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7394", Offset = "0xFC7394", VA = "0xFC7394")]
	private Vector3 easeOutQuart()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7470", Offset = "0xFC7470", VA = "0xFC7470")]
	private Vector3 easeInOutQuart()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC75E4", Offset = "0xFC75E4", VA = "0xFC75E4")]
	private Vector3 easeInQuint()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC76B4", Offset = "0xFC76B4", VA = "0xFC76B4")]
	private Vector3 easeOutQuint()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7794", Offset = "0xFC7794", VA = "0xFC7794")]
	private Vector3 easeInOutQuint()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC78A8", Offset = "0xFC78A8", VA = "0xFC78A8")]
	private Vector3 easeInSine()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC79C8", Offset = "0xFC79C8", VA = "0xFC79C8")]
	private Vector3 easeOutSine()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7AD8", Offset = "0xFC7AD8", VA = "0xFC7AD8")]
	private Vector3 easeInOutSine()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7BCC", Offset = "0xFC7BCC", VA = "0xFC7BCC")]
	private Vector3 easeInExpo()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7CB8", Offset = "0xFC7CB8", VA = "0xFC7CB8")]
	private Vector3 easeOutExpo()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7DA4", Offset = "0xFC7DA4", VA = "0xFC7DA4")]
	private Vector3 easeInOutExpo()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC7F28", Offset = "0xFC7F28", VA = "0xFC7F28")]
	private Vector3 easeInCirc()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC802C", Offset = "0xFC802C", VA = "0xFC802C")]
	private Vector3 easeOutCirc()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC8144", Offset = "0xFC8144", VA = "0xFC8144")]
	private Vector3 easeInOutCirc()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC82CC", Offset = "0xFC82CC", VA = "0xFC82CC")]
	private Vector3 easeInBounce()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC84FC", Offset = "0xFC84FC", VA = "0xFC84FC")]
	private Vector3 easeOutBounce()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC86F8", Offset = "0xFC86F8", VA = "0xFC86F8")]
	private Vector3 easeInOutBounce()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC89B0", Offset = "0xFC89B0", VA = "0xFC89B0")]
	private Vector3 easeInBack()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC8AC0", Offset = "0xFC8AC0", VA = "0xFC8AC0")]
	private Vector3 easeOutBack()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC8BC4", Offset = "0xFC8BC4", VA = "0xFC8BC4")]
	private Vector3 easeInOutBack()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC8D58", Offset = "0xFC8D58", VA = "0xFC8D58")]
	private Vector3 easeInElastic()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC8F94", Offset = "0xFC8F94", VA = "0xFC8F94")]
	private Vector3 easeOutElastic()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC91C0", Offset = "0xFC91C0", VA = "0xFC91C0")]
	private Vector3 easeInOutElastic()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Address(RVA = "0xFC9488", Offset = "0xFC9488", VA = "0xFC9488")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Address(RVA = "0xFC9490", Offset = "0xFC9490", VA = "0xFC9490")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Address(RVA = "0xFC9498", Offset = "0xFC9498", VA = "0xFC9498")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Address(RVA = "0xFC94A0", Offset = "0xFC94A0", VA = "0xFC94A0")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Address(RVA = "0xFC9538", Offset = "0xFC9538", VA = "0xFC9538")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Address(RVA = "0xFC9600", Offset = "0xFC9600", VA = "0xFC9600")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Address(RVA = "0xFC9648", Offset = "0xFC9648", VA = "0xFC9648")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Address(RVA = "0xFC9758", Offset = "0xFC9758", VA = "0xFC9758")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Address(RVA = "0xFC97A8", Offset = "0xFC97A8", VA = "0xFC97A8")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Address(RVA = "0xFC97B4", Offset = "0xFC97B4", VA = "0xFC97B4")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Address(RVA = "0xFC97C0", Offset = "0xFC97C0", VA = "0xFC97C0")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Address(RVA = "0xFC97CC", Offset = "0xFC97CC", VA = "0xFC97CC")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Address(RVA = "0xFC97D4", Offset = "0xFC97D4", VA = "0xFC97D4")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Address(RVA = "0xFC97F0", Offset = "0xFC97F0", VA = "0xFC97F0")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Address(RVA = "0xFC9824", Offset = "0xFC9824", VA = "0xFC9824")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Address(RVA = "0xFC9878", Offset = "0xFC9878", VA = "0xFC9878")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Address(RVA = "0xFC9880", Offset = "0xFC9880", VA = "0xFC9880")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Address(RVA = "0xFC9890", Offset = "0xFC9890", VA = "0xFC9890")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Address(RVA = "0xFC98A0", Offset = "0xFC98A0", VA = "0xFC98A0")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Address(RVA = "0xFC98B0", Offset = "0xFC98B0", VA = "0xFC98B0")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Address(RVA = "0xFC98C0", Offset = "0xFC98C0", VA = "0xFC98C0")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Address(RVA = "0xFC98D0", Offset = "0xFC98D0", VA = "0xFC98D0")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Address(RVA = "0xFC98DC", Offset = "0xFC98DC", VA = "0xFC98DC")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Address(RVA = "0xFC98FC", Offset = "0xFC98FC", VA = "0xFC98FC")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Address(RVA = "0xFC9904", Offset = "0xFC9904", VA = "0xFC9904")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Address(RVA = "0xFC9924", Offset = "0xFC9924", VA = "0xFC9924")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Address(RVA = "0xFC9964", Offset = "0xFC9964", VA = "0xFC9964")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Address(RVA = "0xFC99B4", Offset = "0xFC99B4", VA = "0xFC99B4")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Address(RVA = "0xFC9A04", Offset = "0xFC9A04", VA = "0xFC9A04")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9A70", Offset = "0xFC9A70", VA = "0xFC9A70")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9AB8", Offset = "0xFC9AB8", VA = "0xFC9AB8")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9B08", Offset = "0xFC9B08", VA = "0xFC9B08")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9B58", Offset = "0xFC9B58", VA = "0xFC9B58")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9BA8", Offset = "0xFC9BA8", VA = "0xFC9BA8")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9BF8", Offset = "0xFC9BF8", VA = "0xFC9BF8")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9C48", Offset = "0xFC9C48", VA = "0xFC9C48")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9C98", Offset = "0xFC9C98", VA = "0xFC9C98")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9CE8", Offset = "0xFC9CE8", VA = "0xFC9CE8")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9D30", Offset = "0xFC9D30", VA = "0xFC9D30")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Address(RVA = "0xFC9D78", Offset = "0xFC9D78", VA = "0xFC9D78")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9DE4", Offset = "0xFC9DE4", VA = "0xFC9DE4")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9E50", Offset = "0xFC9E50", VA = "0xFC9E50")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9EB4", Offset = "0xFC9EB4", VA = "0xFC9EB4")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9F18", Offset = "0xFC9F18", VA = "0xFC9F18")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Address(RVA = "0xFC9F58", Offset = "0xFC9F58", VA = "0xFC9F58")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Address(RVA = "0xFCA058", Offset = "0xFCA058", VA = "0xFCA058")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Address(RVA = "0xFCA0EC", Offset = "0xFCA0EC", VA = "0xFCA0EC")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Address(RVA = "0xFCA134", Offset = "0xFCA134", VA = "0xFCA134")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Address(RVA = "0xFCA298", Offset = "0xFCA298", VA = "0xFCA298")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Address(RVA = "0xFCA2D8", Offset = "0xFCA2D8", VA = "0xFCA2D8")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Address(RVA = "0xFCA338", Offset = "0xFCA338", VA = "0xFCA338")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Address(RVA = "0xFCA344", Offset = "0xFCA344", VA = "0xFCA344")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Address(RVA = "0xFC986C", Offset = "0xFC986C", VA = "0xFC986C")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Address(RVA = "0xFCA384", Offset = "0xFCA384", VA = "0xFCA384")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Address(RVA = "0xFCA390", Offset = "0xFCA390", VA = "0xFCA390")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Address(RVA = "0xFCA398", Offset = "0xFCA398", VA = "0xFCA398")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Address(RVA = "0xFCA3A0", Offset = "0xFCA3A0", VA = "0xFCA3A0")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Address(RVA = "0xFCA3EC", Offset = "0xFCA3EC", VA = "0xFCA3EC")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Address(RVA = "0xFCA434", Offset = "0xFCA434", VA = "0xFCA434")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Address(RVA = "0xFCA7F4", Offset = "0xFCA7F4", VA = "0xFCA7F4")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Address(RVA = "0xFCA800", Offset = "0xFCA800", VA = "0xFCA800")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888AA4", Offset = "0x888AA4")]
	private void <setMoveX>b__70_0()
	{
	}

	[Address(RVA = "0xFCA83C", Offset = "0xFCA83C", VA = "0xFCA83C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888AB4", Offset = "0x888AB4")]
	private void <setMoveX>b__70_1()
	{
	}

	[Address(RVA = "0xFCA908", Offset = "0xFCA908", VA = "0xFCA908")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888AC4", Offset = "0x888AC4")]
	private void <setMoveY>b__71_0()
	{
	}

	[Address(RVA = "0xFCA944", Offset = "0xFCA944", VA = "0xFCA944")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888AD4", Offset = "0x888AD4")]
	private void <setMoveY>b__71_1()
	{
	}

	[Address(RVA = "0xFCAA0C", Offset = "0xFCAA0C", VA = "0xFCAA0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888AE4", Offset = "0x888AE4")]
	private void <setMoveZ>b__72_0()
	{
	}

	[Address(RVA = "0xFCAA48", Offset = "0xFCAA48", VA = "0xFCAA48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888AF4", Offset = "0x888AF4")]
	private void <setMoveZ>b__72_1()
	{
	}

	[Address(RVA = "0xFCAB14", Offset = "0xFCAB14", VA = "0xFCAB14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B04", Offset = "0x888B04")]
	private void <setMoveLocalX>b__73_0()
	{
	}

	[Address(RVA = "0xFCAB50", Offset = "0xFCAB50", VA = "0xFCAB50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B14", Offset = "0x888B14")]
	private void <setMoveLocalX>b__73_1()
	{
	}

	[Address(RVA = "0xFCAC1C", Offset = "0xFCAC1C", VA = "0xFCAC1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B24", Offset = "0x888B24")]
	private void <setMoveLocalY>b__74_0()
	{
	}

	[Address(RVA = "0xFCAC58", Offset = "0xFCAC58", VA = "0xFCAC58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B34", Offset = "0x888B34")]
	private void <setMoveLocalY>b__74_1()
	{
	}

	[Address(RVA = "0xFCAD20", Offset = "0xFCAD20", VA = "0xFCAD20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B44", Offset = "0x888B44")]
	private void <setMoveLocalZ>b__75_0()
	{
	}

	[Address(RVA = "0xFCAD5C", Offset = "0xFCAD5C", VA = "0xFCAD5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B54", Offset = "0x888B54")]
	private void <setMoveLocalZ>b__75_1()
	{
	}

	[Address(RVA = "0xFCAE28", Offset = "0xFCAE28", VA = "0xFCAE28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B64", Offset = "0x888B64")]
	private void <setMoveCurved>b__77_0()
	{
	}

	[Address(RVA = "0xFCAFF0", Offset = "0xFCAFF0", VA = "0xFCAFF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B74", Offset = "0x888B74")]
	private void <setMoveCurvedLocal>b__78_0()
	{
	}

	[Address(RVA = "0xFCB1B8", Offset = "0xFCB1B8", VA = "0xFCB1B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B84", Offset = "0x888B84")]
	private void <setMoveSpline>b__79_0()
	{
	}

	[Address(RVA = "0xFCB5F4", Offset = "0xFCB5F4", VA = "0xFCB5F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888B94", Offset = "0x888B94")]
	private void <setMoveSplineLocal>b__80_0()
	{
	}

	[Address(RVA = "0xFCBA98", Offset = "0xFCBA98", VA = "0xFCBA98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888BA4", Offset = "0x888BA4")]
	private void <setScaleX>b__81_0()
	{
	}

	[Address(RVA = "0xFCBAD4", Offset = "0xFCBAD4", VA = "0xFCBAD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888BB4", Offset = "0x888BB4")]
	private void <setScaleX>b__81_1()
	{
	}

	[Address(RVA = "0xFCBBA0", Offset = "0xFCBBA0", VA = "0xFCBBA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888BC4", Offset = "0x888BC4")]
	private void <setScaleY>b__82_0()
	{
	}

	[Address(RVA = "0xFCBBDC", Offset = "0xFCBBDC", VA = "0xFCBBDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888BD4", Offset = "0x888BD4")]
	private void <setScaleY>b__82_1()
	{
	}

	[Address(RVA = "0xFCBCA4", Offset = "0xFCBCA4", VA = "0xFCBCA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888BE4", Offset = "0x888BE4")]
	private void <setScaleZ>b__83_0()
	{
	}

	[Address(RVA = "0xFCBCE0", Offset = "0xFCBCE0", VA = "0xFCBCE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888BF4", Offset = "0x888BF4")]
	private void <setScaleZ>b__83_1()
	{
	}

	[Address(RVA = "0xFCBDAC", Offset = "0xFCBDAC", VA = "0xFCBDAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C04", Offset = "0x888C04")]
	private void <setRotateX>b__84_0()
	{
	}

	[Address(RVA = "0xFCBF10", Offset = "0xFCBF10", VA = "0xFCBF10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C14", Offset = "0x888C14")]
	private void <setRotateX>b__84_1()
	{
	}

	[Address(RVA = "0xFCBFDC", Offset = "0xFCBFDC", VA = "0xFCBFDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C24", Offset = "0x888C24")]
	private void <setRotateY>b__85_0()
	{
	}

	[Address(RVA = "0xFCC07C", Offset = "0xFCC07C", VA = "0xFCC07C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C34", Offset = "0x888C34")]
	private void <setRotateY>b__85_1()
	{
	}

	[Address(RVA = "0xFCC144", Offset = "0xFCC144", VA = "0xFCC144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C44", Offset = "0x888C44")]
	private void <setRotateZ>b__86_0()
	{
	}

	[Address(RVA = "0xFCC1E4", Offset = "0xFCC1E4", VA = "0xFCC1E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C54", Offset = "0x888C54")]
	private void <setRotateZ>b__86_1()
	{
	}

	[Address(RVA = "0xFCC2B0", Offset = "0xFCC2B0", VA = "0xFCC2B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C64", Offset = "0x888C64")]
	private void <setRotateAround>b__87_0()
	{
	}

	[Address(RVA = "0xFCC320", Offset = "0xFCC320", VA = "0xFCC320")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C74", Offset = "0x888C74")]
	private void <setRotateAround>b__87_1()
	{
	}

	[Address(RVA = "0xFCC68C", Offset = "0xFCC68C", VA = "0xFCC68C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C84", Offset = "0x888C84")]
	private void <setRotateAroundLocal>b__88_0()
	{
	}

	[Address(RVA = "0xFCC6FC", Offset = "0xFCC6FC", VA = "0xFCC6FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888C94", Offset = "0x888C94")]
	private void <setRotateAroundLocal>b__88_1()
	{
	}

	[Address(RVA = "0xFCCAA8", Offset = "0xFCCAA8", VA = "0xFCCAA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888CA4", Offset = "0x888CA4")]
	private void <setAlpha>b__89_0()
	{
	}

	[Address(RVA = "0xFCD17C", Offset = "0xFCD17C", VA = "0xFCD17C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888CB4", Offset = "0x888CB4")]
	private void <setAlpha>b__89_2()
	{
	}

	[Address(RVA = "0xFCD318", Offset = "0xFCD318", VA = "0xFCD318")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888CC4", Offset = "0x888CC4")]
	private void <setAlpha>b__89_1()
	{
	}

	[Address(RVA = "0xFCD4C4", Offset = "0xFCD4C4", VA = "0xFCD4C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888CD4", Offset = "0x888CD4")]
	private void <setTextAlpha>b__90_0()
	{
	}

	[Address(RVA = "0xFCD594", Offset = "0xFCD594", VA = "0xFCD594")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888CE4", Offset = "0x888CE4")]
	private void <setTextAlpha>b__90_1()
	{
	}

	[Address(RVA = "0xFCD5DC", Offset = "0xFCD5DC", VA = "0xFCD5DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888CF4", Offset = "0x888CF4")]
	private void <setAlphaVertex>b__91_0()
	{
	}

	[Address(RVA = "0xFCD6A0", Offset = "0xFCD6A0", VA = "0xFCD6A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D04", Offset = "0x888D04")]
	private void <setAlphaVertex>b__91_1()
	{
	}

	[Address(RVA = "0xFCD978", Offset = "0xFCD978", VA = "0xFCD978")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D14", Offset = "0x888D14")]
	private void <setColor>b__92_0()
	{
	}

	[Address(RVA = "0xFCE03C", Offset = "0xFCE03C", VA = "0xFCE03C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D24", Offset = "0x888D24")]
	private void <setColor>b__92_1()
	{
	}

	[Address(RVA = "0xFCE2DC", Offset = "0xFCE2DC", VA = "0xFCE2DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D34", Offset = "0x888D34")]
	private void <setCallbackColor>b__93_0()
	{
	}

	[Address(RVA = "0xFCE330", Offset = "0xFCE330", VA = "0xFCE330")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D44", Offset = "0x888D44")]
	private void <setCallbackColor>b__93_1()
	{
	}

	[Address(RVA = "0xFCE5B8", Offset = "0xFCE5B8", VA = "0xFCE5B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D54", Offset = "0x888D54")]
	private void <setTextColor>b__94_0()
	{
	}

	[Address(RVA = "0xFCE68C", Offset = "0xFCE68C", VA = "0xFCE68C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D64", Offset = "0x888D64")]
	private void <setTextColor>b__94_1()
	{
	}

	[Address(RVA = "0xFCE840", Offset = "0xFCE840", VA = "0xFCE840")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D74", Offset = "0x888D74")]
	private void <setCanvasAlpha>b__95_0()
	{
	}

	[Address(RVA = "0xFCE97C", Offset = "0xFCE97C", VA = "0xFCE97C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D84", Offset = "0x888D84")]
	private void <setCanvasAlpha>b__95_1()
	{
	}

	[Address(RVA = "0xFCEB64", Offset = "0xFCEB64", VA = "0xFCEB64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888D94", Offset = "0x888D94")]
	private void <setCanvasGroupAlpha>b__96_0()
	{
	}

	[Address(RVA = "0xFCEBE4", Offset = "0xFCEBE4", VA = "0xFCEBE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888DA4", Offset = "0x888DA4")]
	private void <setCanvasGroupAlpha>b__96_1()
	{
	}

	[Address(RVA = "0xFCEC88", Offset = "0xFCEC88", VA = "0xFCEC88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888DB4", Offset = "0x888DB4")]
	private void <setCanvasColor>b__97_0()
	{
	}

	[Address(RVA = "0xFCEDC8", Offset = "0xFCEDC8", VA = "0xFCEDC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888DC4", Offset = "0x888DC4")]
	private void <setCanvasColor>b__97_1()
	{
	}

	[Address(RVA = "0xFCEFD0", Offset = "0xFCEFD0", VA = "0xFCEFD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888DD4", Offset = "0x888DD4")]
	private void <setCanvasMoveX>b__98_0()
	{
	}

	[Address(RVA = "0xFCF00C", Offset = "0xFCF00C", VA = "0xFCF00C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888DE4", Offset = "0x888DE4")]
	private void <setCanvasMoveX>b__98_1()
	{
	}

	[Address(RVA = "0xFCF0B4", Offset = "0xFCF0B4", VA = "0xFCF0B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888DF4", Offset = "0x888DF4")]
	private void <setCanvasMoveY>b__99_0()
	{
	}

	[Address(RVA = "0xFCF0F0", Offset = "0xFCF0F0", VA = "0xFCF0F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E04", Offset = "0x888E04")]
	private void <setCanvasMoveY>b__99_1()
	{
	}

	[Address(RVA = "0xFCF19C", Offset = "0xFCF19C", VA = "0xFCF19C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E14", Offset = "0x888E14")]
	private void <setCanvasMoveZ>b__100_0()
	{
	}

	[Address(RVA = "0xFCF1D8", Offset = "0xFCF1D8", VA = "0xFCF1D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E24", Offset = "0x888E24")]
	private void <setCanvasMoveZ>b__100_1()
	{
	}

	[Address(RVA = "0xFCF284", Offset = "0xFCF284", VA = "0xFCF284")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E34", Offset = "0x888E34")]
	private void <setCanvasRotateAround>b__102_0()
	{
	}

	[Address(RVA = "0xFCF5B0", Offset = "0xFCF5B0", VA = "0xFCF5B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E44", Offset = "0x888E44")]
	private void <setCanvasRotateAroundLocal>b__103_0()
	{
	}

	[Address(RVA = "0xFCF93C", Offset = "0xFCF93C", VA = "0xFCF93C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E54", Offset = "0x888E54")]
	private void <setCanvasPlaySprite>b__104_0()
	{
	}

	[Address(RVA = "0xFCF9A8", Offset = "0xFCF9A8", VA = "0xFCF9A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E64", Offset = "0x888E64")]
	private void <setCanvasPlaySprite>b__104_1()
	{
	}

	[Address(RVA = "0xFCFB34", Offset = "0xFCFB34", VA = "0xFCFB34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E74", Offset = "0x888E74")]
	private void <setCanvasMove>b__105_0()
	{
	}

	[Address(RVA = "0xFCFB74", Offset = "0xFCFB74", VA = "0xFCFB74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E84", Offset = "0x888E84")]
	private void <setCanvasMove>b__105_1()
	{
	}

	[Address(RVA = "0xFCFBE4", Offset = "0xFCFBE4", VA = "0xFCFBE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888E94", Offset = "0x888E94")]
	private void <setCanvasScale>b__106_0()
	{
	}

	[Address(RVA = "0xFCFC24", Offset = "0xFCFC24", VA = "0xFCFC24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888EA4", Offset = "0x888EA4")]
	private void <setCanvasScale>b__106_1()
	{
	}

	[Address(RVA = "0xFCFC94", Offset = "0xFCFC94", VA = "0xFCFC94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888EB4", Offset = "0x888EB4")]
	private void <setCanvasSizeDelta>b__107_0()
	{
	}

	[Address(RVA = "0xFCFD38", Offset = "0xFCFD38", VA = "0xFCFD38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888EC4", Offset = "0x888EC4")]
	private void <setCanvasSizeDelta>b__107_1()
	{
	}

	[Address(RVA = "0xFCFE08", Offset = "0xFCFE08", VA = "0xFCFE08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888ED4", Offset = "0x888ED4")]
	private void <setMove>b__111_0()
	{
	}

	[Address(RVA = "0xFCFE48", Offset = "0xFCFE48", VA = "0xFCFE48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888EE4", Offset = "0x888EE4")]
	private void <setMove>b__111_1()
	{
	}

	[Address(RVA = "0xFCFEF8", Offset = "0xFCFEF8", VA = "0xFCFEF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888EF4", Offset = "0x888EF4")]
	private void <setMoveLocal>b__112_0()
	{
	}

	[Address(RVA = "0xFCFF38", Offset = "0xFCFF38", VA = "0xFCFF38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F04", Offset = "0x888F04")]
	private void <setMoveLocal>b__112_1()
	{
	}

	[Address(RVA = "0xFCFFE8", Offset = "0xFCFFE8", VA = "0xFCFFE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F14", Offset = "0x888F14")]
	private void <setMoveToTransform>b__113_0()
	{
	}

	[Address(RVA = "0xFD0028", Offset = "0xFD0028", VA = "0xFD0028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F24", Offset = "0x888F24")]
	private void <setMoveToTransform>b__113_1()
	{
	}

	[Address(RVA = "0xFD018C", Offset = "0xFD018C", VA = "0xFD018C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F34", Offset = "0x888F34")]
	private void <setRotate>b__114_0()
	{
	}

	[Address(RVA = "0xFD028C", Offset = "0xFD028C", VA = "0xFD028C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F44", Offset = "0x888F44")]
	private void <setRotate>b__114_1()
	{
	}

	[Address(RVA = "0xFD033C", Offset = "0xFD033C", VA = "0xFD033C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F54", Offset = "0x888F54")]
	private void <setRotateLocal>b__115_0()
	{
	}

	[Address(RVA = "0xFD043C", Offset = "0xFD043C", VA = "0xFD043C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F64", Offset = "0x888F64")]
	private void <setRotateLocal>b__115_1()
	{
	}

	[Address(RVA = "0xFD04EC", Offset = "0xFD04EC", VA = "0xFD04EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F74", Offset = "0x888F74")]
	private void <setScale>b__116_0()
	{
	}

	[Address(RVA = "0xFD052C", Offset = "0xFD052C", VA = "0xFD052C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F84", Offset = "0x888F84")]
	private void <setScale>b__116_1()
	{
	}

	[Address(RVA = "0xFD05DC", Offset = "0xFD05DC", VA = "0xFD05DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888F94", Offset = "0x888F94")]
	private void <setGUIMove>b__117_0()
	{
	}

	[Address(RVA = "0xFD08E0", Offset = "0xFD08E0", VA = "0xFD08E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888FA4", Offset = "0x888FA4")]
	private void <setGUIMove>b__117_1()
	{
	}

	[Address(RVA = "0xFD0A24", Offset = "0xFD0A24", VA = "0xFD0A24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888FB4", Offset = "0x888FB4")]
	private void <setGUIMoveMargin>b__118_0()
	{
	}

	[Address(RVA = "0xFD0B0C", Offset = "0xFD0B0C", VA = "0xFD0B0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888FC4", Offset = "0x888FC4")]
	private void <setGUIMoveMargin>b__118_1()
	{
	}

	[Address(RVA = "0xFD0B98", Offset = "0xFD0B98", VA = "0xFD0B98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888FD4", Offset = "0x888FD4")]
	private void <setGUIScale>b__119_0()
	{
	}

	[Address(RVA = "0xFD0C74", Offset = "0xFD0C74", VA = "0xFD0C74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888FE4", Offset = "0x888FE4")]
	private void <setGUIScale>b__119_1()
	{
	}

	[Address(RVA = "0xFD0DAC", Offset = "0xFD0DAC", VA = "0xFD0DAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x888FF4", Offset = "0x888FF4")]
	private void <setGUIAlpha>b__120_0()
	{
	}

	[Address(RVA = "0xFD0DF0", Offset = "0xFD0DF0", VA = "0xFD0DF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889004", Offset = "0x889004")]
	private void <setGUIAlpha>b__120_1()
	{
	}

	[Address(RVA = "0xFD0E54", Offset = "0xFD0E54", VA = "0xFD0E54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889014", Offset = "0x889014")]
	private void <setGUIRotate>b__121_0()
	{
	}

	[Address(RVA = "0xFD11B4", Offset = "0xFD11B4", VA = "0xFD11B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889024", Offset = "0x889024")]
	private void <setGUIRotate>b__121_1()
	{
	}

	[Address(RVA = "0xFD1218", Offset = "0xFD1218", VA = "0xFD1218")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889034", Offset = "0x889034")]
	private void <setDelayedSound>b__122_0()
	{
	}
}
public class LTDescrOptional
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EB6C", Offset = "0x87EB6C")]
	private Transform <toTrans>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EB7C", Offset = "0x87EB7C")]
	private Vector3 <point>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EB8C", Offset = "0x87EB8C")]
	private Vector3 <axis>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EB9C", Offset = "0x87EB9C")]
	private float <lastVal>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EBAC", Offset = "0x87EBAC")]
	private Quaternion <origRotation>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EBBC", Offset = "0x87EBBC")]
	private LTBezierPath <path>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EBCC", Offset = "0x87EBCC")]
	private LTSpline <spline>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EBDC", Offset = "0x87EBDC")]
	private LTRect <ltRect>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EBEC", Offset = "0x87EBEC")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EBFC", Offset = "0x87EBFC")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC0C", Offset = "0x87EC0C")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC1C", Offset = "0x87EC1C")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC2C", Offset = "0x87EC2C")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC3C", Offset = "0x87EC3C")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC4C", Offset = "0x87EC4C")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC5C", Offset = "0x87EC5C")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC6C", Offset = "0x87EC6C")]
	private Action <onComplete>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC7C", Offset = "0x87EC7C")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC8C", Offset = "0x87EC8C")]
	private object <onCompleteParam>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87EC9C", Offset = "0x87EC9C")]
	private object <onUpdateParam>k__BackingField;

	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87ECAC", Offset = "0x87ECAC")]
	private Action <onStart>k__BackingField;

	public Transform toTrans
	{
		[Address(RVA = "0xFD0184", Offset = "0xFD0184", VA = "0xFD0184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889044", Offset = "0x889044")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9640", Offset = "0xFC9640", VA = "0xFC9640")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889054", Offset = "0x889054")]
		set
		{
		}
	}

	public Vector3 point
	{
		[Address(RVA = "0xFC57C4", Offset = "0xFC57C4", VA = "0xFC57C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889064", Offset = "0x889064")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Address(RVA = "0xFCA32C", Offset = "0xFCA32C", VA = "0xFCA32C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889074", Offset = "0x889074")]
		set
		{
		}
	}

	public Vector3 axis
	{
		[Address(RVA = "0xFC57D0", Offset = "0xFC57D0", VA = "0xFC57D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889084", Offset = "0x889084")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Address(RVA = "0xFC30E8", Offset = "0xFC30E8", VA = "0xFC30E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889094", Offset = "0x889094")]
		set
		{
		}
	}

	public float lastVal
	{
		[Address(RVA = "0xFCC670", Offset = "0xFCC670", VA = "0xFCC670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8890A4", Offset = "0x8890A4")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0xFCC684", Offset = "0xFCC684", VA = "0xFCC684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8890B4", Offset = "0x8890B4")]
		set
		{
		}
	}

	public Quaternion origRotation
	{
		[Address(RVA = "0xFCC678", Offset = "0xFCC678", VA = "0xFCC678")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8890C4", Offset = "0x8890C4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Address(RVA = "0xFC0FB4", Offset = "0xFC0FB4", VA = "0xFC0FB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8890D4", Offset = "0x8890D4")]
		set
		{
		}
	}

	public LTBezierPath path
	{
		[Address(RVA = "0xFC2A90", Offset = "0xFC2A90", VA = "0xFC2A90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8890E4", Offset = "0x8890E4")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFCA050", Offset = "0xFCA050", VA = "0xFCA050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8890F4", Offset = "0x8890F4")]
		set
		{
		}
	}

	public LTSpline spline
	{
		[Address(RVA = "0xFC2A98", Offset = "0xFC2A98", VA = "0xFC2A98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889104", Offset = "0x889104")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFCA7EC", Offset = "0xFCA7EC", VA = "0xFCA7EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889114", Offset = "0x889114")]
		set
		{
		}
	}

	public LTRect ltRect
	{
		[Address(RVA = "0xFC2FE4", Offset = "0xFC2FE4", VA = "0xFC2FE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889124", Offset = "0x889124")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFCA12C", Offset = "0xFCA12C", VA = "0xFCA12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889134", Offset = "0x889134")]
		set
		{
		}
	}

	public Action<float> onUpdateFloat
	{
		[Address(RVA = "0xFD134C", Offset = "0xFD134C", VA = "0xFD134C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889144", Offset = "0x889144")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9B00", Offset = "0xFC9B00", VA = "0xFC9B00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889154", Offset = "0x889154")]
		set
		{
		}
	}

	public Action<float, float> onUpdateFloatRatio
	{
		[Address(RVA = "0xFD1354", Offset = "0xFD1354", VA = "0xFD1354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889164", Offset = "0x889164")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9B50", Offset = "0xFC9B50", VA = "0xFC9B50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889174", Offset = "0x889174")]
		set
		{
		}
	}

	public Action<float, object> onUpdateFloatObject
	{
		[Address(RVA = "0xFD135C", Offset = "0xFD135C", VA = "0xFD135C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889184", Offset = "0x889184")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9BA0", Offset = "0xFC9BA0", VA = "0xFC9BA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889194", Offset = "0x889194")]
		set
		{
		}
	}

	public Action<Vector2> onUpdateVector2
	{
		[Address(RVA = "0xFD1364", Offset = "0xFD1364", VA = "0xFD1364")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8891A4", Offset = "0x8891A4")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9BF0", Offset = "0xFC9BF0", VA = "0xFC9BF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8891B4", Offset = "0x8891B4")]
		set
		{
		}
	}

	public Action<Vector3> onUpdateVector3
	{
		[Address(RVA = "0xFD136C", Offset = "0xFD136C", VA = "0xFD136C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8891C4", Offset = "0x8891C4")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9C40", Offset = "0xFC9C40", VA = "0xFC9C40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8891D4", Offset = "0x8891D4")]
		set
		{
		}
	}

	public Action<Vector3, object> onUpdateVector3Object
	{
		[Address(RVA = "0xFD1374", Offset = "0xFD1374", VA = "0xFD1374")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8891E4", Offset = "0x8891E4")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9E48", Offset = "0xFC9E48", VA = "0xFC9E48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8891F4", Offset = "0x8891F4")]
		set
		{
		}
	}

	public Action<Color> onUpdateColor
	{
		[Address(RVA = "0xFCE2C4", Offset = "0xFCE2C4", VA = "0xFCE2C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889204", Offset = "0x889204")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9C90", Offset = "0xFC9C90", VA = "0xFC9C90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889214", Offset = "0x889214")]
		set
		{
		}
	}

	public Action<Color, object> onUpdateColorObject
	{
		[Address(RVA = "0xFCE2CC", Offset = "0xFCE2CC", VA = "0xFCE2CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889224", Offset = "0x889224")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9CE0", Offset = "0xFC9CE0", VA = "0xFC9CE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889234", Offset = "0x889234")]
		set
		{
		}
	}

	public Action onComplete
	{
		[Address(RVA = "0xFC2FF4", Offset = "0xFC2FF4", VA = "0xFC2FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889244", Offset = "0x889244")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC99AC", Offset = "0xFC99AC", VA = "0xFC99AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889254", Offset = "0x889254")]
		set
		{
		}
	}

	public Action<object> onCompleteObject
	{
		[Address(RVA = "0xFC2FFC", Offset = "0xFC2FFC", VA = "0xFC2FFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889264", Offset = "0x889264")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC99FC", Offset = "0xFC99FC", VA = "0xFC99FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889274", Offset = "0x889274")]
		set
		{
		}
	}

	public object onCompleteParam
	{
		[Address(RVA = "0xFC2FEC", Offset = "0xFC2FEC", VA = "0xFC2FEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889284", Offset = "0x889284")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9A68", Offset = "0xFC9A68", VA = "0xFC9A68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889294", Offset = "0x889294")]
		set
		{
		}
	}

	public object onUpdateParam
	{
		[Address(RVA = "0xFCE2D4", Offset = "0xFCE2D4", VA = "0xFCE2D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8892A4", Offset = "0x8892A4")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFC9DDC", Offset = "0xFC9DDC", VA = "0xFC9DDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8892B4", Offset = "0x8892B4")]
		set
		{
		}
	}

	public Action onStart
	{
		[Address(RVA = "0xFC2770", Offset = "0xFC2770", VA = "0xFC2770")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8892C4", Offset = "0x8892C4")]
		get
		{
			return null;
		}
		[Address(RVA = "0xFCA42C", Offset = "0xFCA42C", VA = "0xFCA42C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8892D4", Offset = "0x8892D4")]
		set
		{
		}
	}

	[Address(RVA = "0xFBFC50", Offset = "0xFBFC50", VA = "0xFBFC50")]
	public void reset()
	{
	}

	[Address(RVA = "0xFC2E48", Offset = "0xFC2E48", VA = "0xFC2E48")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Address(RVA = "0xFBF930", Offset = "0xFBF930", VA = "0xFBF930")]
	public LTDescrOptional()
	{
	}
}
public class LTSeq
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTSeq previous;

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LTSeq current;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LTDescr tween;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDelay;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int debugIter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool toggle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint _id;

	public int id
	{
		[Address(RVA = "0xFD42A4", Offset = "0xFD42A4", VA = "0xFD42A4")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0xFD42B4", Offset = "0xFD42B4", VA = "0xFD42B4")]
	public void reset()
	{
	}

	[Address(RVA = "0xFD42C4", Offset = "0xFD42C4", VA = "0xFD42C4")]
	public void init(uint id, uint global_counter)
	{
	}

	[Address(RVA = "0xFD42DC", Offset = "0xFD42DC", VA = "0xFD42DC")]
	private LTSeq addOn()
	{
		return null;
	}

	[Address(RVA = "0xFD48F8", Offset = "0xFD48F8", VA = "0xFD48F8")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Address(RVA = "0xFD4978", Offset = "0xFD4978", VA = "0xFD4978")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Address(RVA = "0xFD49D4", Offset = "0xFD49D4", VA = "0xFD49D4")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Address(RVA = "0xFD4BF8", Offset = "0xFD4BF8", VA = "0xFD4BF8")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Address(RVA = "0xFD4DBC", Offset = "0xFD4DBC", VA = "0xFD4DBC")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Address(RVA = "0xFD4F54", Offset = "0xFD4F54", VA = "0xFD4F54")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Address(RVA = "0xFD4B6C", Offset = "0xFD4B6C", VA = "0xFD4B6C")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Address(RVA = "0xFD5120", Offset = "0xFD5120", VA = "0xFD5120")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Address(RVA = "0xFD5184", Offset = "0xFD5184", VA = "0xFD5184")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Address(RVA = "0xFD51B0", Offset = "0xFD51B0", VA = "0xFD51B0")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Address(RVA = "0xFD52A4", Offset = "0xFD52A4", VA = "0xFD52A4")]
	public LTSeq reverse()
	{
		return null;
	}

	[Address(RVA = "0xFD52A8", Offset = "0xFD52A8", VA = "0xFD52A8")]
	public LTSeq()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		FXAA2,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		FXAA3Console,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		FXAA1PresetA,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		FXAA1PresetB,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		NFAA,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		SSAA,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		DLAA
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BDE4", Offset = "0x87BDE4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87BDE4", Offset = "0x87BDE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87BDE4", Offset = "0x87BDE4")]
	public class Antialiasing : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Address(RVA = "0x17A5C2C", Offset = "0x17A5C2C", VA = "0x17A5C2C")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Address(RVA = "0x17A5C90", Offset = "0x17A5C90", VA = "0x17A5C90", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17A6170", Offset = "0x17A6170", VA = "0x17A6170")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17A6770", Offset = "0x17A6770", VA = "0x17A6770")]
		public Antialiasing()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BE7C", Offset = "0x87BE7C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87BE7C", Offset = "0x87BE7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87BE7C", Offset = "0x87BE7C")]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Ghosting,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Anamorphic,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Combined
		}

		public enum TweakMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Basic,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Complex
		}

		public enum HDRBloomMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Auto,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			On,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Off
		}

		public enum BloomScreenBlendMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Screen,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Add
		}

		public enum BloomQuality
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Cheap,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Address(RVA = "0x17A680C", Offset = "0x17A680C", VA = "0x17A680C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17A6CD4", Offset = "0x17A6CD4", VA = "0x17A6CD4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17A8304", Offset = "0x17A8304", VA = "0x17A8304")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A8058", Offset = "0x17A8058", VA = "0x17A8058")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A7D48", Offset = "0x17A7D48", VA = "0x17A7D48")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A7C40", Offset = "0x17A7C40", VA = "0x17A7C40")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A7E38", Offset = "0x17A7E38", VA = "0x17A7E38")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A83DC", Offset = "0x17A83DC", VA = "0x17A83DC")]
		public Bloom()
		{
		}
	}
	public enum LensflareStyle34
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Ghosting,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Anamorphic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Combined
	}
	public enum TweakMode34
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Basic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Complex
	}
	public enum HDRBloomMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Auto,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		On,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Off
	}
	public enum BloomScreenBlendMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Screen,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Add
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BF14", Offset = "0x87BF14")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87BF14", Offset = "0x87BF14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87BF14", Offset = "0x87BF14")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Address(RVA = "0x17A8558", Offset = "0x17A8558", VA = "0x17A8558", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17A8610", Offset = "0x17A8610", VA = "0x17A8610")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17A9808", Offset = "0x17A9808", VA = "0x17A9808")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A9574", Offset = "0x17A9574", VA = "0x17A9574")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A92C4", Offset = "0x17A92C4", VA = "0x17A92C4")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A93FC", Offset = "0x17A93FC", VA = "0x17A93FC")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17A98C4", Offset = "0x17A98C4", VA = "0x17A98C4")]
		public BloomAndFlares()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87BFAC", Offset = "0x87BFAC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87BFAC", Offset = "0x87BFAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87BFAC", Offset = "0x87BFAC")]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Low,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High
		}

		public enum BlurType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Standard,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Sgx
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ECBC", Offset = "0x87ECBC")]
		public float threshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ECD4", Offset = "0x87ECD4")]
		public float intensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ECEC", Offset = "0x87ECEC")]
		public float blurSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED04", Offset = "0x87ED04")]
		public int blurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Address(RVA = "0x17A9A2C", Offset = "0x17A9A2C", VA = "0x17A9A2C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17A9A84", Offset = "0x17A9A84", VA = "0x17A9A84")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17A9B34", Offset = "0x17A9B34", VA = "0x17A9B34")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17A9F90", Offset = "0x17A9F90", VA = "0x17A9F90")]
		public BloomOptimized()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C044", Offset = "0x87C044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C044", Offset = "0x87C044")]
	public class Blur : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED1C", Offset = "0x87ED1C")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED34", Offset = "0x87ED34")]
		public float blurSpread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		protected Material material
		{
			[Address(RVA = "0x17A9FB0", Offset = "0x17A9FB0", VA = "0x17A9FB0")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x17AA0F0", Offset = "0x17AA0F0", VA = "0x17AA0F0")]
		protected void OnDisable()
		{
		}

		[Address(RVA = "0x17AA1EC", Offset = "0x17AA1EC", VA = "0x17AA1EC")]
		protected void Start()
		{
		}

		[Address(RVA = "0x17AA2C0", Offset = "0x17AA2C0", VA = "0x17AA2C0")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Address(RVA = "0x17AA49C", Offset = "0x17AA49C", VA = "0x17AA49C")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Address(RVA = "0x17AA654", Offset = "0x17AA654", VA = "0x17AA654")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17AA7D0", Offset = "0x17AA7D0", VA = "0x17AA7D0")]
		public Blur()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C090", Offset = "0x87C090")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C090", Offset = "0x87C090")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C090", Offset = "0x87C090")]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			StandardGauss,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			SgxGauss
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED4C", Offset = "0x87ED4C")]
		public int downsample;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED64", Offset = "0x87ED64")]
		public float blurSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED7C", Offset = "0x87ED7C")]
		public int blurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Address(RVA = "0x17AA7EC", Offset = "0x17AA7EC", VA = "0x17AA7EC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17AA844", Offset = "0x17AA844", VA = "0x17AA844")]
		public void OnDisable()
		{
		}

		[Address(RVA = "0x17AA8F4", Offset = "0x17AA8F4", VA = "0x17AA8F4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17AAD24", Offset = "0x17AAD24", VA = "0x17AAD24")]
		public BlurOptimized()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C128", Offset = "0x87C128")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C128", Offset = "0x87C128")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C128", Offset = "0x87C128")]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			CameraMotion,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LocalBlur,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Reconstruction,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			ReconstructionDX11,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			ReconstructionDisc
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Address(RVA = "0x17AAD3C", Offset = "0x17AAD3C", VA = "0x17AAD3C")]
		private void CalculateViewProjection()
		{
		}

		[Address(RVA = "0x17AB04C", Offset = "0x17AB04C", VA = "0x17AB04C")]
		private new void Start()
		{
		}

		[Address(RVA = "0x17AB36C", Offset = "0x17AB36C", VA = "0x17AB36C")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17AB44C", Offset = "0x17AB44C", VA = "0x17AB44C")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17AB5B0", Offset = "0x17AB5B0", VA = "0x17AB5B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17AB694", Offset = "0x17AB694", VA = "0x17AB694")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17AB154", Offset = "0x17AB154", VA = "0x17AB154")]
		private void Remember()
		{
		}

		[Address(RVA = "0x17AD4A0", Offset = "0x17AD4A0", VA = "0x17AD4A0")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Address(RVA = "0x17AD3AC", Offset = "0x17AD3AC", VA = "0x17AD3AC")]
		private void StartFrame()
		{
		}

		[Address(RVA = "0x17AD490", Offset = "0x17AD490", VA = "0x17AD490")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Address(RVA = "0x17AD944", Offset = "0x17AD944", VA = "0x17AD944")]
		public CameraMotionBlur()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C1C0", Offset = "0x87C1C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C1C0", Offset = "0x87C1C0")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Simple,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Advanced
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Address(RVA = "0x17ADA90", Offset = "0x17ADA90", VA = "0x17ADA90")]
		private new void Start()
		{
		}

		[Address(RVA = "0x17ADACC", Offset = "0x17ADACC", VA = "0x17ADACC")]
		private void Awake()
		{
		}

		[Address(RVA = "0x17ADAD0", Offset = "0x17ADAD0", VA = "0x17ADAD0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17ADD74", Offset = "0x17ADD74", VA = "0x17ADD74")]
		public void UpdateParameters()
		{
		}

		[Address(RVA = "0x17AE218", Offset = "0x17AE218", VA = "0x17AE218")]
		private void UpdateTextures()
		{
		}

		[Address(RVA = "0x17AE21C", Offset = "0x17AE21C", VA = "0x17AE21C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17AE608", Offset = "0x17AE608", VA = "0x17AE608")]
		public ColorCorrectionCurves()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C20C", Offset = "0x87C20C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C20C", Offset = "0x87C20C")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Address(RVA = "0x17AED40", Offset = "0x17AED40", VA = "0x17AED40", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17AED94", Offset = "0x17AED94", VA = "0x17AED94")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17AEE3C", Offset = "0x17AEE3C", VA = "0x17AEE3C")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x17AEEE4", Offset = "0x17AEEE4", VA = "0x17AEEE4")]
		public void SetIdentityLut()
		{
		}

		[Address(RVA = "0x17AF12C", Offset = "0x17AF12C", VA = "0x17AF12C")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Address(RVA = "0x17AF230", Offset = "0x17AF230", VA = "0x17AF230")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Address(RVA = "0x17AF630", Offset = "0x17AF630", VA = "0x17AF630")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17AF85C", Offset = "0x17AF85C", VA = "0x17AF85C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C258", Offset = "0x87C258")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C258", Offset = "0x87C258")]
	public class ColorCorrectionLut2D : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture2D sourceLut;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D converted2DLut;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string basedOnTempTex;

		[Address(RVA = "0x17AF8B0", Offset = "0x17AF8B0", VA = "0x17AF8B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17AF908", Offset = "0x17AF908", VA = "0x17AF908")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17AF9B0", Offset = "0x17AF9B0", VA = "0x17AF9B0")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x17AFA58", Offset = "0x17AFA58", VA = "0x17AFA58")]
		public void SetIdentityLut()
		{
		}

		[Address(RVA = "0x17AFCE4", Offset = "0x17AFCE4", VA = "0x17AFCE4")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Address(RVA = "0x17AFDF0", Offset = "0x17AFDF0", VA = "0x17AFDF0")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Address(RVA = "0x17B02F0", Offset = "0x17B02F0", VA = "0x17B02F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B05C4", Offset = "0x17B05C4", VA = "0x17B05C4")]
		public ColorCorrectionLut2D()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C2A4", Offset = "0x87C2A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C2A4", Offset = "0x87C2A4")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Address(RVA = "0x17B0618", Offset = "0x17B0618", VA = "0x17B0618")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B07AC", Offset = "0x17B07AC", VA = "0x17B07AC")]
		public ColorCorrectionRamp()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C2F0", Offset = "0x87C2F0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C2F0", Offset = "0x87C2F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C2F0", Offset = "0x87C2F0")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87ED94", Offset = "0x87ED94")]
		public float intensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EDAC", Offset = "0x87EDAC")]
		public float threshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EDC8", Offset = "0x87EDC8")]
		public float blurSpread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Address(RVA = "0x17B07BC", Offset = "0x17B07BC", VA = "0x17B07BC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B082C", Offset = "0x17B082C", VA = "0x17B082C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B0BE8", Offset = "0x17B0BE8", VA = "0x17B0BE8")]
		public ContrastEnhance()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C388", Offset = "0x87C388")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C388", Offset = "0x87C388")]
	public class ContrastStretch : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EDE0", Offset = "0x87EDE0")]
		public float adaptationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EDFC", Offset = "0x87EDFC")]
		public float limitMinimum;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EE14", Offset = "0x87EE14")]
		public float limitMaximum;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		protected Material materialLum
		{
			[Address(RVA = "0x17B0BFC", Offset = "0x17B0BFC", VA = "0x17B0BFC")]
			get
			{
				return null;
			}
		}

		protected Material materialReduce
		{
			[Address(RVA = "0x17B0CC4", Offset = "0x17B0CC4", VA = "0x17B0CC4")]
			get
			{
				return null;
			}
		}

		protected Material materialAdapt
		{
			[Address(RVA = "0x17B0D8C", Offset = "0x17B0D8C", VA = "0x17B0D8C")]
			get
			{
				return null;
			}
		}

		protected Material materialApply
		{
			[Address(RVA = "0x17B0E54", Offset = "0x17B0E54", VA = "0x17B0E54")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x17B0F1C", Offset = "0x17B0F1C", VA = "0x17B0F1C")]
		private void Start()
		{
		}

		[Address(RVA = "0x17B0FDC", Offset = "0x17B0FDC", VA = "0x17B0FDC")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17B117C", Offset = "0x17B117C", VA = "0x17B117C")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17B13CC", Offset = "0x17B13CC", VA = "0x17B13CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B1660", Offset = "0x17B1660", VA = "0x17B1660")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Address(RVA = "0x17B18CC", Offset = "0x17B18CC", VA = "0x17B18CC")]
		public ContrastStretch()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C3D4", Offset = "0x87C3D4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C3D4", Offset = "0x87C3D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C3D4", Offset = "0x87C3D4")]
	public class CreaseShading : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Address(RVA = "0x17B194C", Offset = "0x17B194C", VA = "0x17B194C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B19C4", Offset = "0x17B19C4", VA = "0x17B19C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B1DB4", Offset = "0x17B1DB4", VA = "0x17B1DB4")]
		public CreaseShading()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C46C", Offset = "0x87C46C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C46C", Offset = "0x87C46C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C46C", Offset = "0x87C46C")]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			DiscBlur,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			DX11
		}

		public enum BlurSampleCount
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Low,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Medium,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Address(RVA = "0x17B1DCC", Offset = "0x17B1DCC", VA = "0x17B1DCC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B1FC4", Offset = "0x17B1FC4", VA = "0x17B1FC4")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17B2060", Offset = "0x17B2060", VA = "0x17B2060")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17B2168", Offset = "0x17B2168", VA = "0x17B2168")]
		private void ReleaseComputeResources()
		{
		}

		[Address(RVA = "0x17B1E50", Offset = "0x17B1E50", VA = "0x17B1E50")]
		private void CreateComputeResources()
		{
		}

		[Address(RVA = "0x17B21AC", Offset = "0x17B21AC", VA = "0x17B21AC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Address(RVA = "0x17B2380", Offset = "0x17B2380", VA = "0x17B2380")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Address(RVA = "0x17B2714", Offset = "0x17B2714", VA = "0x17B2714")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B4170", Offset = "0x17B4170", VA = "0x17B4170")]
		public DepthOfField()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C504", Offset = "0x87C504")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C504", Offset = "0x87C504")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C504", Offset = "0x87C504")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			OnlyBackground = 1,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High = 2,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Medium,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Low
		}

		public enum DofBlurriness
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Low = 1,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High = 2,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Background = 1,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Foreground,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			BackgroundAndForeground
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Address(RVA = "0x17B41D0", Offset = "0x17B41D0", VA = "0x17B41D0")]
		private void CreateMaterials()
		{
		}

		[Address(RVA = "0x17B42A8", Offset = "0x17B42A8", VA = "0x17B42A8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B43B0", Offset = "0x17B43B0", VA = "0x17B43B0")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17B462C", Offset = "0x17B462C", VA = "0x17B462C")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17B46C8", Offset = "0x17B46C8", VA = "0x17B46C8")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Address(RVA = "0x17B489C", Offset = "0x17B489C", VA = "0x17B489C")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Address(RVA = "0x17B48C0", Offset = "0x17B48C0", VA = "0x17B48C0")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Address(RVA = "0x17B48E4", Offset = "0x17B48E4", VA = "0x17B48E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B58BC", Offset = "0x17B58BC", VA = "0x17B58BC")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Address(RVA = "0x17B6038", Offset = "0x17B6038", VA = "0x17B6038")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Address(RVA = "0x17B64DC", Offset = "0x17B64DC", VA = "0x17B64DC")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Address(RVA = "0x17B5758", Offset = "0x17B5758", VA = "0x17B5758")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Address(RVA = "0x17B5B88", Offset = "0x17B5B88", VA = "0x17B5B88")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Address(RVA = "0x17B6330", Offset = "0x17B6330", VA = "0x17B6330")]
		private void ReleaseTextures()
		{
		}

		[Address(RVA = "0x17B5378", Offset = "0x17B5378", VA = "0x17B5378")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Address(RVA = "0x17B69F8", Offset = "0x17B69F8", VA = "0x17B69F8")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C59C", Offset = "0x87C59C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C59C", Offset = "0x87C59C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C59C", Offset = "0x87C59C")]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			TriangleDepthNormals,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RobertsCrossDepthNormals,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			SobelDepth,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			SobelDepthThin,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			TriangleLuminance
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Address(RVA = "0x17B6AD4", Offset = "0x17B6AD4", VA = "0x17B6AD4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B6C58", Offset = "0x17B6C58", VA = "0x17B6C58")]
		private new void Start()
		{
		}

		[Address(RVA = "0x17B6B4C", Offset = "0x17B6B4C", VA = "0x17B6B4C")]
		private void SetCameraFlag()
		{
		}

		[Address(RVA = "0x17B6C64", Offset = "0x17B6C64", VA = "0x17B6C64")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17B6C68", Offset = "0x17B6C68", VA = "0x17B6C68")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x8892E4", Offset = "0x8892E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B6ED0", Offset = "0x17B6ED0", VA = "0x17B6ED0")]
		public EdgeDetection()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C634", Offset = "0x87C634")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C634", Offset = "0x87C634")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C634", Offset = "0x87C634")]
	public class Fisheye : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EE2C", Offset = "0x87EE2C")]
		public float strengthX;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EE44", Offset = "0x87EE44")]
		public float strengthY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Address(RVA = "0x17B6F20", Offset = "0x17B6F20", VA = "0x17B6F20", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B6F78", Offset = "0x17B6F78", VA = "0x17B6F78")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B7100", Offset = "0x17B7100", VA = "0x17B7100")]
		public Fisheye()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C6CC", Offset = "0x87C6CC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C6CC", Offset = "0x87C6CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C6CC", Offset = "0x87C6CC")]
	internal class GlobalFog : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87EE5C", Offset = "0x87EE5C")]
		public bool distanceFog;

		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87EE94", Offset = "0x87EE94")]
		public bool excludeFarPixels;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87EECC", Offset = "0x87EECC")]
		public bool useRadialDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87EF04", Offset = "0x87EF04")]
		public bool heightFog;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87EF3C", Offset = "0x87EF3C")]
		public float height;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EF74", Offset = "0x87EF74")]
		public float heightDensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87EF90", Offset = "0x87EF90")]
		public float startDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Address(RVA = "0x17B7118", Offset = "0x17B7118", VA = "0x17B7118", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B7170", Offset = "0x17B7170", VA = "0x17B7170")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x8892F4", Offset = "0x8892F4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B7AB4", Offset = "0x17B7AB4", VA = "0x17B7AB4")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Address(RVA = "0x17B7C60", Offset = "0x17B7C60", VA = "0x17B7C60")]
		public GlobalFog()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C764", Offset = "0x87C764")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C764", Offset = "0x87C764")]
	public class Grayscale : ImageEffectBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EFC8", Offset = "0x87EFC8")]
		public float rampOffset;

		[Address(RVA = "0x17B7C80", Offset = "0x17B7C80", VA = "0x17B7C80")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B7D88", Offset = "0x17B7D88", VA = "0x17B7D88")]
		public Grayscale()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C7B0", Offset = "0x87C7B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C7B0", Offset = "0x87C7B0")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		protected Material material
		{
			[Address(RVA = "0x17B06E4", Offset = "0x17B06E4", VA = "0x17B06E4")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x17B7D90", Offset = "0x17B7D90", VA = "0x17B7D90", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0x17B7E48", Offset = "0x17B7E48", VA = "0x17B7E48", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Address(RVA = "0x17B07B4", Offset = "0x17B07B4", VA = "0x17B07B4")]
		public ImageEffectBase()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C838", Offset = "0x87C838")]
	public class ImageEffects
	{
		[Address(RVA = "0x17B7EF8", Offset = "0x17B7EF8", VA = "0x17B7EF8")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Address(RVA = "0x17B8188", Offset = "0x17B8188", VA = "0x17B8188")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x889304", Offset = "0x889304")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Address(RVA = "0x17B8200", Offset = "0x17B8200", VA = "0x17B8200")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x88933C", Offset = "0x88933C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Address(RVA = "0x17B8280", Offset = "0x17B8280", VA = "0x17B8280")]
		public ImageEffects()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C870", Offset = "0x87C870")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C870", Offset = "0x87C870")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C870", Offset = "0x87C870")]
	public class MotionBlur : ImageEffectBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EFE0", Offset = "0x87EFE0")]
		public float blurAmount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Address(RVA = "0x17B8288", Offset = "0x17B8288", VA = "0x17B8288", Slot = "4")]
		protected override void Start()
		{
		}

		[Address(RVA = "0x17B828C", Offset = "0x17B828C", VA = "0x17B828C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Address(RVA = "0x17B8300", Offset = "0x17B8300", VA = "0x17B8300")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B86EC", Offset = "0x17B86EC", VA = "0x17B86EC")]
		public MotionBlur()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C908", Offset = "0x87C908")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C908", Offset = "0x87C908")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C908", Offset = "0x87C908")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Address(RVA = "0x17B8700", Offset = "0x17B8700", VA = "0x17B8700")]
		private void Awake()
		{
		}

		[Address(RVA = "0x17B8760", Offset = "0x17B8760", VA = "0x17B8760", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B87D8", Offset = "0x17B87D8", VA = "0x17B87D8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17B92C4", Offset = "0x17B92C4", VA = "0x17B92C4")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Address(RVA = "0x17B9608", Offset = "0x17B9608", VA = "0x17B9608")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Address(RVA = "0x17B9D44", Offset = "0x17B9D44", VA = "0x17B9D44")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Address(RVA = "0x17B9FC8", Offset = "0x17B9FC8", VA = "0x17B9FC8")]
		public NoiseAndGrain()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87C9A0", Offset = "0x87C9A0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87C9A0", Offset = "0x87C9A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87C9A0", Offset = "0x87C9A0")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87EFFC", Offset = "0x87EFFC")]
		public float grainIntensityMin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F014", Offset = "0x87F014")]
		public float grainIntensityMax;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F02C", Offset = "0x87F02C")]
		public float grainSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F04C", Offset = "0x87F04C")]
		public float scratchIntensityMin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F064", Offset = "0x87F064")]
		public float scratchIntensityMax;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F07C", Offset = "0x87F07C")]
		public float scratchFPS;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F094", Offset = "0x87F094")]
		public float scratchJitter;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		protected Material material
		{
			[Address(RVA = "0x17BA224", Offset = "0x17BA224", VA = "0x17BA224")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x17BA0D0", Offset = "0x17BA0D0", VA = "0x17BA0D0")]
		protected void Start()
		{
		}

		[Address(RVA = "0x17BA38C", Offset = "0x17BA38C", VA = "0x17BA38C")]
		protected void OnDisable()
		{
		}

		[Address(RVA = "0x17BA490", Offset = "0x17BA490", VA = "0x17BA490")]
		private void SanitizeParameters()
		{
		}

		[Address(RVA = "0x17BA5CC", Offset = "0x17BA5CC", VA = "0x17BA5CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BA970", Offset = "0x17BA970", VA = "0x17BA970")]
		public NoiseAndScratches()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CA38", Offset = "0x87CA38")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CA38", Offset = "0x87CA38")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Address(RVA = "0x17A6894", Offset = "0x17A6894", VA = "0x17A6894")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Address(RVA = "0x17A5E9C", Offset = "0x17A5E9C", VA = "0x17A5E9C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Address(RVA = "0x17BA9A4", Offset = "0x17BA9A4", VA = "0x17BA9A4")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17BA9B0", Offset = "0x17BA9B0", VA = "0x17BA9B0")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x17BA9B4", Offset = "0x17BA9B4", VA = "0x17BA9B4")]
		private void RemoveCreatedMaterials()
		{
		}

		[Address(RVA = "0x17BAAAC", Offset = "0x17BAAAC", VA = "0x17BAAAC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BAAB4", Offset = "0x17BAAB4", VA = "0x17BAAB4", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17ADAC0", Offset = "0x17ADAC0", VA = "0x17ADAC0")]
		protected void Start()
		{
		}

		[Address(RVA = "0x17A5D70", Offset = "0x17A5D70", VA = "0x17A5D70")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Address(RVA = "0x17AB638", Offset = "0x17AB638", VA = "0x17AB638")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Address(RVA = "0x17BAB64", Offset = "0x17BAB64", VA = "0x17BAB64")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Address(RVA = "0x17A60C8", Offset = "0x17A60C8", VA = "0x17A60C8")]
		protected void ReportAutoDisable()
		{
		}

		[Address(RVA = "0x17BAB6C", Offset = "0x17BAB6C", VA = "0x17BAB6C")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Address(RVA = "0x17A609C", Offset = "0x17A609C", VA = "0x17A609C")]
		protected void NotSupported()
		{
		}

		[Address(RVA = "0x17BADFC", Offset = "0x17BADFC", VA = "0x17BADFC")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Address(RVA = "0x17A6790", Offset = "0x17A6790", VA = "0x17A6790")]
		public PostEffectsBase()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CAAC", Offset = "0x87CAAC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CAAC", Offset = "0x87CAAC")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Address(RVA = "0x17BB1A4", Offset = "0x17BB1A4", VA = "0x17BB1A4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BB210", Offset = "0x17BB210", VA = "0x17BB210")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Address(RVA = "0x17BB4A8", Offset = "0x17BB4A8", VA = "0x17BB4A8")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Address(RVA = "0x17BB84C", Offset = "0x17BB84C", VA = "0x17BB84C")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Address(RVA = "0x17BBA04", Offset = "0x17BBA04", VA = "0x17BBA04")]
		public PostEffectsHelper()
		{
		}
	}
	internal class Quads
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Address(RVA = "0x17BBA0C", Offset = "0x17BBA0C", VA = "0x17BBA0C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Address(RVA = "0x17B440C", Offset = "0x17B440C", VA = "0x17B440C")]
		public static void Cleanup()
		{
		}

		[Address(RVA = "0x17B6720", Offset = "0x17B6720", VA = "0x17B6720")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Address(RVA = "0x17BBB24", Offset = "0x17BBB24", VA = "0x17BBB24")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Address(RVA = "0x17BC238", Offset = "0x17BC238", VA = "0x17BC238")]
		public Quads()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CB20", Offset = "0x87CB20")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CB20", Offset = "0x87CB20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CB20", Offset = "0x87CB20")]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Additive,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			ScreenBlend,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Multiply,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Overlay,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			AlphaBlend
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Address(RVA = "0x17BC244", Offset = "0x17BC244", VA = "0x17BC244", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BC29C", Offset = "0x17BC29C", VA = "0x17BC29C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BC454", Offset = "0x17BC454", VA = "0x17BC454")]
		public ScreenOverlay()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CBB8", Offset = "0x87CBB8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CBB8", Offset = "0x87CBB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CBB8", Offset = "0x87CBB8")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F0AC", Offset = "0x87F0AC")]
		public float intensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F0C4", Offset = "0x87F0C4")]
		public float radius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F0E0", Offset = "0x87F0E0")]
		public int blurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F0F8", Offset = "0x87F0F8")]
		public float blurFilterDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F110", Offset = "0x87F110")]
		public int downsample;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Address(RVA = "0x17BC464", Offset = "0x17BC464", VA = "0x17BC464", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BC4BC", Offset = "0x17BC4BC", VA = "0x17BC4BC")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17BC564", Offset = "0x17BC564", VA = "0x17BC564")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x889374", Offset = "0x889374")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BCEBC", Offset = "0x17BCEBC", VA = "0x17BCEBC")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CC50", Offset = "0x87CC50")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CC50", Offset = "0x87CC50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CC50", Offset = "0x87CC50")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		public enum SSAOSamples
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Low,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Medium,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F128", Offset = "0x87F128")]
		public float m_Radius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F144", Offset = "0x87F144")]
		public float m_OcclusionIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F15C", Offset = "0x87F15C")]
		public int m_Blur;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F174", Offset = "0x87F174")]
		public int m_Downsampling;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F18C", Offset = "0x87F18C")]
		public float m_OcclusionAttenuation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F1A8", Offset = "0x87F1A8")]
		public float m_MinZ;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Address(RVA = "0x17BCED8", Offset = "0x17BCED8", VA = "0x17BCED8")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Address(RVA = "0x17BCF8C", Offset = "0x17BCF8C", VA = "0x17BCF8C")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Address(RVA = "0x17BD028", Offset = "0x17BD028", VA = "0x17BD028")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17BD030", Offset = "0x17BD030", VA = "0x17BD030")]
		private void Start()
		{
		}

		[Address(RVA = "0x17BD1F0", Offset = "0x17BD1F0", VA = "0x17BD1F0")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x17BD110", Offset = "0x17BD110", VA = "0x17BD110")]
		private void CreateMaterials()
		{
		}

		[Address(RVA = "0x17BD288", Offset = "0x17BD288", VA = "0x17BD288")]
		[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x889384", Offset = "0x889384")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BDA40", Offset = "0x17BDA40", VA = "0x17BDA40")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CCE8", Offset = "0x87CCE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CCE8", Offset = "0x87CCE8")]
	public class SepiaTone : ImageEffectBase
	{
		[Address(RVA = "0x17BDA78", Offset = "0x17BDA78", VA = "0x17BDA78")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BDB08", Offset = "0x17BDB08", VA = "0x17BDB08")]
		public SepiaTone()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CD34", Offset = "0x87CD34")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CD34", Offset = "0x87CD34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CD34", Offset = "0x87CD34")]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Low,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Normal,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High
		}

		public enum ShaftsScreenBlendMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Screen,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Add
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Address(RVA = "0x17BDB10", Offset = "0x17BDB10", VA = "0x17BDB10", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BDB78", Offset = "0x17BDB78", VA = "0x17BDB78")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BE48C", Offset = "0x17BE48C", VA = "0x17BE48C")]
		public SunShafts()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CDCC", Offset = "0x87CDCC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CDCC", Offset = "0x87CDCC")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			TiltShiftMode,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			IrisMode
		}

		public enum TiltShiftQuality
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Preview,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Normal,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			High
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F1C4", Offset = "0x87F1C4")]
		public float blurArea;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F1DC", Offset = "0x87F1DC")]
		public float maxBlurSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F1F4", Offset = "0x87F1F4")]
		public int downsample;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Address(RVA = "0x17BE534", Offset = "0x17BE534", VA = "0x17BE534", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BE58C", Offset = "0x17BE58C", VA = "0x17BE58C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BE894", Offset = "0x17BE894", VA = "0x17BE894")]
		public TiltShift()
		{
		}
	}
	[AttributeAttribute(Name = "ImageEffectAllowedInSceneView", RVA = "0x87CE54", Offset = "0x87CE54")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CE54", Offset = "0x87CE54")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CE54", Offset = "0x87CE54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CE54", Offset = "0x87CE54")]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			SimpleReinhard,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			UserCurve,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Hable,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Photographic,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			OptimizedHejiDawson,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			AdaptiveReinhard,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square16 = 0x10,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square32 = 0x20,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square64 = 0x40,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square128 = 0x80,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square256 = 0x100,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square512 = 0x200,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Square1024 = 0x400
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Address(RVA = "0x17BE8AC", Offset = "0x17BE8AC", VA = "0x17BE8AC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BEA04", Offset = "0x17BEA04", VA = "0x17BEA04")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Address(RVA = "0x17BED24", Offset = "0x17BED24", VA = "0x17BED24")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17BEE7C", Offset = "0x17BEE7C", VA = "0x17BEE7C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BEF70", Offset = "0x17BEF70", VA = "0x17BEF70")]
		[AttributeAttribute(Name = "ImageEffectTransformsToLDR", RVA = "0x889394", Offset = "0x889394")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17BF8C0", Offset = "0x17BF8C0", VA = "0x17BF8C0")]
		public Tonemapping()
		{
		}
	}
	internal class Triangles
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Address(RVA = "0x17BF8EC", Offset = "0x17BF8EC", VA = "0x17BF8EC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Address(RVA = "0x17BFA48", Offset = "0x17BFA48", VA = "0x17BFA48")]
		private static void Cleanup()
		{
		}

		[Address(RVA = "0x17BFC68", Offset = "0x17BFC68", VA = "0x17BFC68")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Address(RVA = "0x17BFF40", Offset = "0x17BFF40", VA = "0x17BFF40")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Address(RVA = "0x17C04C8", Offset = "0x17C04C8", VA = "0x17C04C8")]
		public Triangles()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CEFC", Offset = "0x87CEFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CEFC", Offset = "0x87CEFC")]
	public class Twirl : ImageEffectBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F20C", Offset = "0x87F20C")]
		public float angle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Address(RVA = "0x17C04D4", Offset = "0x17C04D4", VA = "0x17C04D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17C0518", Offset = "0x17C0518", VA = "0x17C0518")]
		public Twirl()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CF48", Offset = "0x87CF48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87CF48", Offset = "0x87CF48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CF48", Offset = "0x87CF48")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Simple,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Advanced
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Address(RVA = "0x17C0594", Offset = "0x17C0594", VA = "0x17C0594", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Address(RVA = "0x17C0618", Offset = "0x17C0618", VA = "0x17C0618")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17C0D10", Offset = "0x17C0D10", VA = "0x17C0D10")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x87CFE0", Offset = "0x87CFE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87CFE0", Offset = "0x87CFE0")]
	public class Vortex : ImageEffectBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Address(RVA = "0x17C0D44", Offset = "0x17C0D44", VA = "0x17C0D44")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Address(RVA = "0x17C0D88", Offset = "0x17C0D88", VA = "0x17C0D88")]
		public Vortex()
		{
		}
	}
}
namespace RootMotion
{
	[Serializable]
	public enum Axis
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		X,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Y,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Z
	}
	public class AxisTools
	{
		[Address(RVA = "0x14C34DC", Offset = "0x14C34DC", VA = "0x14C34DC")]
		public static Vector3 ToVector3(Axis axis)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14C359C", Offset = "0x14C359C", VA = "0x14C359C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Address(RVA = "0x14C3648", Offset = "0x14C3648", VA = "0x14C3648")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Address(RVA = "0x14C3830", Offset = "0x14C3830", VA = "0x14C3830")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Address(RVA = "0x14C3764", Offset = "0x14C3764", VA = "0x14C3764")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14C394C", Offset = "0x14C394C", VA = "0x14C394C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14C3B94", Offset = "0x14C3B94", VA = "0x14C3B94")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	public class BipedLimbOrientations
	{
		[Serializable]
		public class LimbOrientation
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Address(RVA = "0x14C3E5C", Offset = "0x14C3E5C", VA = "0x14C3E5C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		public static BipedLimbOrientations UMA
		{
			[Address(RVA = "0x14C3BE8", Offset = "0x14C3BE8", VA = "0x14C3BE8")]
			get
			{
				return null;
			}
		}

		public static BipedLimbOrientations MaxBiped
		{
			[Address(RVA = "0x14C3ED8", Offset = "0x14C3ED8", VA = "0x14C3ED8")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x14C3B9C", Offset = "0x14C3B9C", VA = "0x14C3B9C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	public static class BipedNaming
	{
		[Serializable]
		public enum BoneType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Unassigned,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Spine,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Arm,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Leg,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Tail,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Eye
		}

		[Serializable]
		public enum BoneSide
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Center,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Left,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Right
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Address(RVA = "0x14C414C", Offset = "0x14C414C", VA = "0x14C414C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0x14C4490", Offset = "0x14C4490", VA = "0x14C4490")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0x14C4724", Offset = "0x14C4724", VA = "0x14C4724")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0x14C47A8", Offset = "0x14C47A8", VA = "0x14C47A8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0x14C485C", Offset = "0x14C485C", VA = "0x14C485C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Address(RVA = "0x14C4340", Offset = "0x14C4340", VA = "0x14C4340")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Address(RVA = "0x14C4684", Offset = "0x14C4684", VA = "0x14C4684")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Address(RVA = "0x14C50B0", Offset = "0x14C50B0", VA = "0x14C50B0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Address(RVA = "0x14C4EC8", Offset = "0x14C4EC8", VA = "0x14C4EC8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4FBC", Offset = "0x14C4FBC", VA = "0x14C4FBC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4A90", Offset = "0x14C4A90", VA = "0x14C4A90")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4B44", Offset = "0x14C4B44", VA = "0x14C4B44")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4BF8", Offset = "0x14C4BF8", VA = "0x14C4BF8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4CAC", Offset = "0x14C4CAC", VA = "0x14C4CAC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4D60", Offset = "0x14C4D60", VA = "0x14C4D60")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C4E14", Offset = "0x14C4E14", VA = "0x14C4E14")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C532C", Offset = "0x14C532C", VA = "0x14C532C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C499C", Offset = "0x14C499C", VA = "0x14C499C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C5294", Offset = "0x14C5294", VA = "0x14C5294")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C539C", Offset = "0x14C539C", VA = "0x14C539C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C5470", Offset = "0x14C5470", VA = "0x14C5470")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C5200", Offset = "0x14C5200", VA = "0x14C5200")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Address(RVA = "0x14C5140", Offset = "0x14C5140", VA = "0x14C5140")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	public class BipedReferences
	{
		public struct AutoDetectParams
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			public static AutoDetectParams Default
			{
				[Address(RVA = "0x14CBF68", Offset = "0x14CBF68", VA = "0x14CBF68")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Address(RVA = "0x960A30", Offset = "0x960A30", VA = "0x960A30")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		public virtual bool isFilled
		{
			[Address(RVA = "0x14C7F54", Offset = "0x14C7F54", VA = "0x14C7F54", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		public bool isEmpty
		{
			[Address(RVA = "0x14C8358", Offset = "0x14C8358", VA = "0x14C8358")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x14C8368", Offset = "0x14C8368", VA = "0x14C8368", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C87AC", Offset = "0x14C87AC", VA = "0x14C87AC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C8BF4", Offset = "0x14C8BF4", VA = "0x14C8BF4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Address(RVA = "0x14C943C", Offset = "0x14C943C", VA = "0x14C943C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Address(RVA = "0x14C8E78", Offset = "0x14C8E78", VA = "0x14C8E78")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Address(RVA = "0x14C9F20", Offset = "0x14C9F20", VA = "0x14C9F20")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CA018", Offset = "0x14CA018", VA = "0x14CA018")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CA648", Offset = "0x14CA648", VA = "0x14CA648")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CA418", Offset = "0x14CA418", VA = "0x14CA418")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CA260", Offset = "0x14CA260", VA = "0x14CA260")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CA0F0", Offset = "0x14CA0F0", VA = "0x14CA0F0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Address(RVA = "0x14CA530", Offset = "0x14CA530", VA = "0x14CA530")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Address(RVA = "0x14CA754", Offset = "0x14CA754", VA = "0x14CA754")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CB5F8", Offset = "0x14CB5F8", VA = "0x14CB5F8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CAEE4", Offset = "0x14CAEE4", VA = "0x14CAEE4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CB9B0", Offset = "0x14CB9B0", VA = "0x14CB9B0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CB3A4", Offset = "0x14CB3A4", VA = "0x14CB3A4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CB9B8", Offset = "0x14CB9B8", VA = "0x14CB9B8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CB9C0", Offset = "0x14CB9C0", VA = "0x14CB9C0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CBBCC", Offset = "0x14CBBCC", VA = "0x14CBBCC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CBE30", Offset = "0x14CBE30", VA = "0x14CBE30")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Address(RVA = "0x14C8E08", Offset = "0x14C8E08", VA = "0x14C8E08")]
		public BipedReferences()
		{
		}
	}
	public class Comments : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x87F228", Offset = "0x87F228")]
		public string text;

		[Address(RVA = "0x14CBF70", Offset = "0x14CBF70", VA = "0x14CBF70")]
		public Comments()
		{
		}
	}
	public class DemoGUIMessage : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Address(RVA = "0x14CBF78", Offset = "0x14CBF78", VA = "0x14CBF78")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0x14CC038", Offset = "0x14CC038", VA = "0x14CC038")]
		public DemoGUIMessage()
		{
		}
	}
	public class Hierarchy
	{
		[Address(RVA = "0x135F8C8", Offset = "0x135F8C8", VA = "0x135F8C8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Address(RVA = "0x135FAFC", Offset = "0x135FAFC", VA = "0x135FAFC")]
		public static Object ContainsDuplicate(Object[] objects)
		{
			return null;
		}

		[Address(RVA = "0x135F978", Offset = "0x135F978", VA = "0x135F978")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Address(RVA = "0x135FC48", Offset = "0x135FC48", VA = "0x135FC48")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Address(RVA = "0x135FD70", Offset = "0x135FD70", VA = "0x135FD70")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Address(RVA = "0x13600C0", Offset = "0x13600C0", VA = "0x13600C0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Address(RVA = "0x1360204", Offset = "0x1360204", VA = "0x1360204")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Address(RVA = "0x13603B0", Offset = "0x13603B0", VA = "0x13603B0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Address(RVA = "0x1360798", Offset = "0x1360798", VA = "0x1360798")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Address(RVA = "0x1360564", Offset = "0x1360564", VA = "0x1360564")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Address(RVA = "0x1360948", Offset = "0x1360948", VA = "0x1360948")]
		public Hierarchy()
		{
		}
	}
	public class InspectorComment : PropertyAttribute
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Address(RVA = "0x1360950", Offset = "0x1360950", VA = "0x1360950")]
		public InspectorComment(string name)
		{
		}

		[Address(RVA = "0x13609C0", Offset = "0x13609C0", VA = "0x13609C0")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	public enum InterpolationMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		None,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InOutCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InOutQuintic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InOutSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InQuintic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InQuadratic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InElastic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InElasticSmall,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InElasticBig,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InBack,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutQuintic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutInCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutInQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutElastic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutElasticSmall,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutElasticBig,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutBack,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutBackCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutBackQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		BackInCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		BackInQuartic
	}
	public class Interp
	{
		[Address(RVA = "0x1343110", Offset = "0x1343110", VA = "0x1343110")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Address(RVA = "0x1361130", Offset = "0x1361130", VA = "0x1361130")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x1361238", Offset = "0x1361238", VA = "0x1361238")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Address(RVA = "0x1360A30", Offset = "0x1360A30", VA = "0x1360A30")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360A3C", Offset = "0x1360A3C", VA = "0x1360A3C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360A64", Offset = "0x1360A64", VA = "0x1360A64")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360AA0", Offset = "0x1360AA0", VA = "0x1360AA0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360AB8", Offset = "0x1360AB8", VA = "0x1360AB8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360ACC", Offset = "0x1360ACC", VA = "0x1360ACC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360AE0", Offset = "0x1360AE0", VA = "0x1360AE0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360AF0", Offset = "0x1360AF0", VA = "0x1360AF0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360B38", Offset = "0x1360B38", VA = "0x1360B38")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360B70", Offset = "0x1360B70", VA = "0x1360B70")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360B98", Offset = "0x1360B98", VA = "0x1360B98")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1361334", Offset = "0x1361334", VA = "0x1361334")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360BCC", Offset = "0x1360BCC", VA = "0x1360BCC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360BF4", Offset = "0x1360BF4", VA = "0x1360BF4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360C24", Offset = "0x1360C24", VA = "0x1360C24")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360C58", Offset = "0x1360C58", VA = "0x1360C58")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360C9C", Offset = "0x1360C9C", VA = "0x1360C9C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360D00", Offset = "0x1360D00", VA = "0x1360D00")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360D64", Offset = "0x1360D64", VA = "0x1360D64")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360DB8", Offset = "0x1360DB8", VA = "0x1360DB8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360E0C", Offset = "0x1360E0C", VA = "0x1360E0C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360EA4", Offset = "0x1360EA4", VA = "0x1360EA4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360F38", Offset = "0x1360F38", VA = "0x1360F38")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1361368", Offset = "0x1361368", VA = "0x1361368")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1360FDC", Offset = "0x1360FDC", VA = "0x1360FDC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x13610C0", Offset = "0x13610C0", VA = "0x13610C0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x13610F0", Offset = "0x13610F0", VA = "0x13610F0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x1361450", Offset = "0x1361450", VA = "0x1361450")]
		public Interp()
		{
		}
	}
	public class LargeHeader : PropertyAttribute
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Address(RVA = "0x1361458", Offset = "0x1361458", VA = "0x1361458")]
		public LargeHeader(string name)
		{
		}

		[Address(RVA = "0x13614C8", Offset = "0x13614C8", VA = "0x13614C8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	public static class LayerMaskExtensions
	{
		[Address(RVA = "0x1361538", Offset = "0x1361538", VA = "0x1361538")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Address(RVA = "0x1361594", Offset = "0x1361594", VA = "0x1361594")]
		public static LayerMask Create(params string[] layerNames)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x136166C", Offset = "0x136166C", VA = "0x136166C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x13615AC", Offset = "0x13615AC", VA = "0x13615AC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x1361684", Offset = "0x1361684", VA = "0x1361684")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x1361734", Offset = "0x1361734", VA = "0x1361734")]
		public static LayerMask Inverse(this LayerMask original)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x1361760", Offset = "0x1361760", VA = "0x1361760")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x13617B0", Offset = "0x13617B0", VA = "0x13617B0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LayerMask);
		}

		[Address(RVA = "0x136181C", Offset = "0x136181C", VA = "0x136181C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Address(RVA = "0x136191C", Offset = "0x136191C", VA = "0x136191C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Address(RVA = "0x1361A00", Offset = "0x1361A00", VA = "0x1361A00")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Address(RVA = "0x1361A60", Offset = "0x1361A60", VA = "0x1361A60")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	public static class QuaTools
	{
		[Address(RVA = "0x17A2ADC", Offset = "0x17A2ADC", VA = "0x17A2ADC")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A2C28", Offset = "0x17A2C28", VA = "0x17A2C28")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A2D74", Offset = "0x17A2D74", VA = "0x17A2D74")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A2E88", Offset = "0x17A2E88", VA = "0x17A2E88")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A2F9C", Offset = "0x17A2F9C", VA = "0x17A2F9C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A3128", Offset = "0x17A3128", VA = "0x17A3128")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A31F8", Offset = "0x17A31F8", VA = "0x17A31F8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A334C", Offset = "0x17A334C", VA = "0x17A334C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A35D0", Offset = "0x17A35D0", VA = "0x17A35D0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A37E4", Offset = "0x17A37E4", VA = "0x17A37E4")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Address(RVA = "0x17A3964", Offset = "0x17A3964", VA = "0x17A3964")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17A3AD4", Offset = "0x17A3AD4", VA = "0x17A3AD4")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A3BE4", Offset = "0x17A3BE4", VA = "0x17A3BE4")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		public static T instance => null;

		protected virtual void Awake()
		{
		}
	}
	public class SolverManager : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F238", Offset = "0x87F238")]
		public bool fixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		private bool animatePhysics
		{
			[Address(RVA = "0x17A3D78", Offset = "0x17A3D78", VA = "0x17A3D78")]
			get
			{
				return default(bool);
			}
		}

		private bool isAnimated
		{
			[Address(RVA = "0x17A40CC", Offset = "0x17A40CC", VA = "0x17A40CC")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x17A3C40", Offset = "0x17A3C40", VA = "0x17A3C40")]
		public void Disable()
		{
		}

		[Address(RVA = "0x17A3CD8", Offset = "0x17A3CD8", VA = "0x17A3CD8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Address(RVA = "0x17A3CDC", Offset = "0x17A3CDC", VA = "0x17A3CDC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Address(RVA = "0x17A3CE0", Offset = "0x17A3CE0", VA = "0x17A3CE0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Address(RVA = "0x17A3CE4", Offset = "0x17A3CE4", VA = "0x17A3CE4")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x17A3D74", Offset = "0x17A3D74", VA = "0x17A3D74")]
		private void Start()
		{
		}

		[Address(RVA = "0x17A3D1C", Offset = "0x17A3D1C", VA = "0x17A3D1C")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x17A407C", Offset = "0x17A407C", VA = "0x17A407C")]
		private void Update()
		{
		}

		[Address(RVA = "0x17A3E7C", Offset = "0x17A3E7C", VA = "0x17A3E7C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Address(RVA = "0x17A4188", Offset = "0x17A4188", VA = "0x17A4188")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x17A41E4", Offset = "0x17A41E4", VA = "0x17A41E4")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x17A4244", Offset = "0x17A4244", VA = "0x17A4244")]
		public void UpdateSolverExternal()
		{
		}

		[Address(RVA = "0x17A428C", Offset = "0x17A428C", VA = "0x17A428C")]
		public SolverManager()
		{
		}
	}
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Address(RVA = "0x17A429C", Offset = "0x17A429C", VA = "0x17A429C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Address(RVA = "0x17A435C", Offset = "0x17A435C", VA = "0x17A435C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Address(RVA = "0x17A441C", Offset = "0x17A441C", VA = "0x17A441C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Address(RVA = "0x17A44DC", Offset = "0x17A44DC", VA = "0x17A44DC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	public static class V3Tools
	{
		[Address(RVA = "0x17A44E4", Offset = "0x17A44E4", VA = "0x17A44E4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A45DC", Offset = "0x17A45DC", VA = "0x17A45DC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A46D4", Offset = "0x17A46D4", VA = "0x17A46D4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A47CC", Offset = "0x17A47CC", VA = "0x17A47CC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A48CC", Offset = "0x17A48CC", VA = "0x17A48CC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A4AF0", Offset = "0x17A4AF0", VA = "0x17A4AF0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A4D2C", Offset = "0x17A4D2C", VA = "0x17A4D2C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A4F7C", Offset = "0x17A4F7C", VA = "0x17A4F7C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17A518C", Offset = "0x17A518C", VA = "0x17A518C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}
	public static class Warning
	{
		public delegate void Logger(string message);

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Address(RVA = "0x17A5368", Offset = "0x17A5368", VA = "0x17A5368")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Address(RVA = "0x17A5B34", Offset = "0x17A5B34", VA = "0x17A5B34")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator
	{
		public enum State
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Idle,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Seeking,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			OnPath
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F270", Offset = "0x87F270")]
		public bool activeTargetSeeking;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F2A8", Offset = "0x87F2A8")]
		public float cornerRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F2E0", Offset = "0x87F2E0")]
		public float recalculateOnPathDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F318", Offset = "0x87F318")]
		public float maxSampleDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F350", Offset = "0x87F350")]
		public float nextPathInterval;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F388", Offset = "0x87F388")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F398", Offset = "0x87F398")]
		private State <state>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		public Vector3 normalizedDeltaPosition
		{
			[Address(RVA = "0x14CC06C", Offset = "0x14CC06C", VA = "0x14CC06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889414", Offset = "0x889414")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x14CC078", Offset = "0x14CC078", VA = "0x14CC078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889424", Offset = "0x889424")]
			private set
			{
			}
		}

		public State state
		{
			[Address(RVA = "0x14CC084", Offset = "0x14CC084", VA = "0x14CC084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889434", Offset = "0x889434")]
			get
			{
				return default(State);
			}
			[Address(RVA = "0x14CC08C", Offset = "0x14CC08C", VA = "0x14CC08C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889444", Offset = "0x889444")]
			private set
			{
			}
		}

		[Address(RVA = "0x14CC094", Offset = "0x14CC094", VA = "0x14CC094")]
		public void Initiate(Transform transform)
		{
		}

		[Address(RVA = "0x14CC168", Offset = "0x14CC168", VA = "0x14CC168")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0x14CC724", Offset = "0x14CC724", VA = "0x14CC724")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0x14CC794", Offset = "0x14CC794", VA = "0x14CC794")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Address(RVA = "0x14CC5EC", Offset = "0x14CC5EC", VA = "0x14CC5EC")]
		private void Stop()
		{
		}

		[Address(RVA = "0x14CC660", Offset = "0x14CC660", VA = "0x14CC660")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Address(RVA = "0x14CC8FC", Offset = "0x14CC8FC", VA = "0x14CC8FC")]
		public void Visualize()
		{
		}

		[Address(RVA = "0x14CCB8C", Offset = "0x14CCB8C", VA = "0x14CCB8C")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	public class AnimationBlocker : MonoBehaviour
	{
		[Address(RVA = "0x14CCBF8", Offset = "0x14CCBF8", VA = "0x14CCBF8")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x14CCD24", Offset = "0x14CCD24", VA = "0x14CCD24")]
		public AnimationBlocker()
		{
		}
	}
	public abstract class BehaviourBase : MonoBehaviour
	{
		public delegate void BehaviourDelegate();

		public delegate void HitDelegate(MuscleHit hit);

		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		public struct PuppetEvent
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8849AC", Offset = "0x8849AC")]
			public string switchToBehaviour;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8849E4", Offset = "0x8849E4")]
			public AnimatorEvent[] animations;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884A1C", Offset = "0x884A1C")]
			public UnityEvent unityEvent;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const string empty = "";

			public bool switchBehaviour
			{
				[Address(RVA = "0x960AD4", Offset = "0x960AD4", VA = "0x960AD4")]
				get
				{
					return default(bool);
				}
			}

			[Address(RVA = "0x960ADC", Offset = "0x960ADC", VA = "0x960ADC")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const string empty = "";

			[Address(RVA = "0x14CEF74", Offset = "0x14CEF74", VA = "0x14CEF74")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Address(RVA = "0x14CF048", Offset = "0x14CF048", VA = "0x14CF048")]
			private void Activate(Animator animator)
			{
			}

			[Address(RVA = "0x14CF1A8", Offset = "0x14CF1A8", VA = "0x14CF1A8")]
			private void Activate(Animation animation)
			{
			}

			[Address(RVA = "0x14CF2D4", Offset = "0x14CF2D4", VA = "0x14CF2D4")]
			public AnimatorEvent()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x87F3A8", Offset = "0x87F3A8")]
		public PuppetMaster puppetMaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x87F3B8", Offset = "0x87F3B8")]
		public bool deactivated;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3C8", Offset = "0x87F3C8")]
		private bool <forceActive>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		public bool forceActive
		{
			[Address(RVA = "0x14CD1A0", Offset = "0x14CD1A0", VA = "0x14CD1A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889454", Offset = "0x889454")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x14CD1A8", Offset = "0x14CD1A8", VA = "0x14CD1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889464", Offset = "0x889464")]
			protected set
			{
			}
		}

		public abstract void OnReactivate();

		[Address(RVA = "0x14CCD2C", Offset = "0x14CCD2C", VA = "0x14CCD2C", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Address(RVA = "0x14CCD30", Offset = "0x14CCD30", VA = "0x14CCD30", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Address(RVA = "0x14CCD34", Offset = "0x14CCD34", VA = "0x14CCD34", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Address(RVA = "0x14CCD38", Offset = "0x14CCD38", VA = "0x14CCD38", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Address(RVA = "0x14CCD3C", Offset = "0x14CCD3C", VA = "0x14CCD3C", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Address(RVA = "0x14CCD40", Offset = "0x14CCD40", VA = "0x14CCD40", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Address(RVA = "0x14CCD44", Offset = "0x14CCD44", VA = "0x14CCD44", Slot = "11")]
		public virtual void OnMuscleDisconnected(Muscle m)
		{
		}

		[Address(RVA = "0x14CCD48", Offset = "0x14CCD48", VA = "0x14CCD48", Slot = "12")]
		public virtual void OnMuscleReconnected(Muscle m)
		{
		}

		[Address(RVA = "0x14CCD4C", Offset = "0x14CCD4C", VA = "0x14CCD4C", Slot = "13")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Address(RVA = "0x14CD15C", Offset = "0x14CD15C", VA = "0x14CD15C", Slot = "14")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Address(RVA = "0x14CD16C", Offset = "0x14CD16C", VA = "0x14CD16C", Slot = "15")]
		protected virtual void OnActivate()
		{
		}

		[Address(RVA = "0x14CD170", Offset = "0x14CD170", VA = "0x14CD170", Slot = "16")]
		protected virtual void OnDeactivate()
		{
		}

		[Address(RVA = "0x14CD174", Offset = "0x14CD174", VA = "0x14CD174", Slot = "17")]
		protected virtual void OnInitiate()
		{
		}

		[Address(RVA = "0x14CD178", Offset = "0x14CD178", VA = "0x14CD178", Slot = "18")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Address(RVA = "0x14CD17C", Offset = "0x14CD17C", VA = "0x14CD17C", Slot = "19")]
		protected virtual void OnUpdate()
		{
		}

		[Address(RVA = "0x14CD180", Offset = "0x14CD180", VA = "0x14CD180", Slot = "20")]
		protected virtual void OnLateUpdate()
		{
		}

		[Address(RVA = "0x14CD184", Offset = "0x14CD184", VA = "0x14CD184", Slot = "21")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Address(RVA = "0x14CD188", Offset = "0x14CD188", VA = "0x14CD188", Slot = "22")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Address(RVA = "0x14CD18C", Offset = "0x14CD18C", VA = "0x14CD18C", Slot = "23")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Address(RVA = "0x14CD190", Offset = "0x14CD190", VA = "0x14CD190", Slot = "24")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Address(RVA = "0x14CD194", Offset = "0x14CD194", VA = "0x14CD194", Slot = "25")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Address(RVA = "0x14CD198", Offset = "0x14CD198", VA = "0x14CD198", Slot = "26")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Address(RVA = "0x14CD19C", Offset = "0x14CD19C", VA = "0x14CD19C", Slot = "27")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Address(RVA = "0x14CD1B4", Offset = "0x14CD1B4", VA = "0x14CD1B4")]
		public void Initiate()
		{
		}

		[Address(RVA = "0x14CD20C", Offset = "0x14CD20C", VA = "0x14CD20C")]
		public void OnFixTransforms()
		{
		}

		[Address(RVA = "0x14CD274", Offset = "0x14CD274", VA = "0x14CD274")]
		public void OnRead()
		{
		}

		[Address(RVA = "0x14CD2DC", Offset = "0x14CD2DC", VA = "0x14CD2DC")]
		public void OnWrite()
		{
		}

		[Address(RVA = "0x14CD344", Offset = "0x14CD344", VA = "0x14CD344")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Address(RVA = "0x14CD980", Offset = "0x14CD980", VA = "0x14CD980")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Address(RVA = "0x14CE008", Offset = "0x14CE008", VA = "0x14CE008")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Address(RVA = "0x14CE0B8", Offset = "0x14CE0B8", VA = "0x14CE0B8")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x14CE0C8", Offset = "0x14CE0C8", VA = "0x14CE0C8")]
		public void Activate()
		{
		}

		[Address(RVA = "0x14CE20C", Offset = "0x14CE20C", VA = "0x14CE20C")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x14CE264", Offset = "0x14CE264", VA = "0x14CE264")]
		public void FixedUpdateB()
		{
		}

		[Address(RVA = "0x14CE33C", Offset = "0x14CE33C", VA = "0x14CE33C")]
		public void UpdateB()
		{
		}

		[Address(RVA = "0x14CE414", Offset = "0x14CE414", VA = "0x14CE414")]
		public void LateUpdateB()
		{
		}

		[Address(RVA = "0x14CE4EC", Offset = "0x14CE4EC", VA = "0x14CE4EC", Slot = "28")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Address(RVA = "0x14CE538", Offset = "0x14CE538", VA = "0x14CE538")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Address(RVA = "0x14CE784", Offset = "0x14CE784", VA = "0x14CE784")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Address(RVA = "0x14CEA4C", Offset = "0x14CEA4C", VA = "0x14CEA4C")]
		protected void RemovePropMuscles()
		{
		}

		[Address(RVA = "0x14CECAC", Offset = "0x14CECAC", VA = "0x14CECAC", Slot = "29")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Address(RVA = "0x14CEBF4", Offset = "0x14CEBF4", VA = "0x14CEBF4")]
		protected bool ContainsRemovablePropMuscle()
		{
			return default(bool);
		}

		[Address(RVA = "0x14CEF6C", Offset = "0x14CEF6C", VA = "0x14CEF6C")]
		protected BehaviourBase()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D03C", Offset = "0x87D03C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D03C", Offset = "0x87D03C")]
	public class BehaviourFall : BehaviourBase
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD58", Offset = "0x87DD58")]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x14D0694", Offset = "0x14D0694", VA = "0x14D0694", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x14D0704", Offset = "0x14D0704", VA = "0x14D0704", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x14CF950", Offset = "0x14CF950", VA = "0x14CF950")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Address(RVA = "0x14D0388", Offset = "0x14D0388", VA = "0x14D0388", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x14D038C", Offset = "0x14D038C", VA = "0x14D038C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x14D069C", Offset = "0x14D069C", VA = "0x14D069C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87F3D8", Offset = "0x87F3D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F3D8", Offset = "0x87F3D8")]
		public string stateName;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F438", Offset = "0x87F438")]
		public float transitionDuration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F470", Offset = "0x87F470")]
		public int layer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F4A8", Offset = "0x87F4A8")]
		public float fixedTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87F4E0", Offset = "0x87F4E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F4E0", Offset = "0x87F4E0")]
		public LayerMask raycastLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F540", Offset = "0x87F540")]
		public string blendParameter;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F578", Offset = "0x87F578")]
		public float writheHeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F5B0", Offset = "0x87F5B0")]
		public float writheYVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F5E8", Offset = "0x87F5E8")]
		public float blendSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F620", Offset = "0x87F620")]
		public float blendMappingSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87F658", Offset = "0x87F658")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F658", Offset = "0x87F658")]
		public bool canEnd;

		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F6B8", Offset = "0x87F6B8")]
		public float minTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F6F0", Offset = "0x87F6F0")]
		public float maxEndVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F728", Offset = "0x87F728")]
		public PuppetEvent onEnd;

		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Address(RVA = "0x14CF7F0", Offset = "0x14CF7F0", VA = "0x14CF7F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889474", Offset = "0x889474")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x14CF83C", Offset = "0x14CF83C", VA = "0x14CF83C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8894AC", Offset = "0x8894AC")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x14CF888", Offset = "0x14CF888", VA = "0x14CF888", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Address(RVA = "0x14CF93C", Offset = "0x14CF93C", VA = "0x14CF93C", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Address(RVA = "0x14CF944", Offset = "0x14CF944", VA = "0x14CF944", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Address(RVA = "0x14CF8C8", Offset = "0x14CF8C8", VA = "0x14CF8C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8894E4", Offset = "0x8894E4")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Address(RVA = "0x14CF97C", Offset = "0x14CF97C", VA = "0x14CF97C", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Address(RVA = "0x14CFFC0", Offset = "0x14CFFC0", VA = "0x14CFFC0", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Address(RVA = "0x14D01E4", Offset = "0x14D01E4", VA = "0x14D01E4", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Address(RVA = "0x14CFDC0", Offset = "0x14CFDC0", VA = "0x14CFDC0")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Address(RVA = "0x14CFC10", Offset = "0x14CFC10", VA = "0x14CFC10")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Address(RVA = "0x14D0270", Offset = "0x14D0270", VA = "0x14D0270", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Address(RVA = "0x14D02F4", Offset = "0x14D02F4", VA = "0x14D02F4")]
		public BehaviourFall()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D09C", Offset = "0x87D09C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D09C", Offset = "0x87D09C")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		public enum State
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Puppet,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Unpinned,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			GetUp
		}

		[Serializable]
		public enum NormalMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Active,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Unmapped,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Kinematic
		}

		[Serializable]
		public class MasterProps
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Address(RVA = "0x14D60E0", Offset = "0x14D60E0", VA = "0x14D60E0")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		public struct MuscleProps
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884A54", Offset = "0x884A54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884A54", Offset = "0x884A54")]
			public float unpinParents;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884AA8", Offset = "0x884AA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884AA8", Offset = "0x884AA8")]
			public float unpinChildren;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884AFC", Offset = "0x884AFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884AFC", Offset = "0x884AFC")]
			public float unpinGroup;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884B50", Offset = "0x884B50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884B50", Offset = "0x884B50")]
			public float minMappingWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884BA4", Offset = "0x884BA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884BA4", Offset = "0x884BA4")]
			public float maxMappingWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884BF8", Offset = "0x884BF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884BF8", Offset = "0x884BF8")]
			public float minPinWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884C4C", Offset = "0x884C4C")]
			public bool disableColliders;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884C84", Offset = "0x884C84")]
			public float regainPinSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884CBC", Offset = "0x884CBC")]
			public float collisionResistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884CF4", Offset = "0x884CF4")]
			public float knockOutDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884D2C", Offset = "0x884D2C")]
			public PhysicMaterial puppetMaterial;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884D64", Offset = "0x884D64")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		public struct MusclePropsGroup
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x884D9C", Offset = "0x884D9C")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884DAC", Offset = "0x884DAC")]
			public Muscle.Group[] groups;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884DE4", Offset = "0x884DE4")]
			public MuscleProps props;
		}

		[Serializable]
		public struct CollisionResistanceMultiplier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884E1C", Offset = "0x884E1C")]
			public float multiplier;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884E54", Offset = "0x884E54")]
			public float collisionThreshold;
		}

		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87F760", Offset = "0x87F760")]
		public MasterProps masterProps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F798", Offset = "0x87F798")]
		public LayerMask groundLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F7D0", Offset = "0x87F7D0")]
		public LayerMask collisionLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F808", Offset = "0x87F808")]
		public float collisionThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F840", Offset = "0x87F840")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F878", Offset = "0x87F878")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F878", Offset = "0x87F878")]
		public int maxCollisions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F8CC", Offset = "0x87F8CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F8CC", Offset = "0x87F8CC")]
		public float regainPinSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F924", Offset = "0x87F924")]
		public float boostFalloff;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87F95C", Offset = "0x87F95C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F95C", Offset = "0x87F95C")]
		public MuscleProps defaults;

		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F9BC", Offset = "0x87F9BC")]
		public MusclePropsGroup[] groupOverrides;

		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87F9F4", Offset = "0x87F9F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87F9F4", Offset = "0x87F9F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F9F4", Offset = "0x87F9F4")]
		public float knockOutDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FA70", Offset = "0x87FA70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87FA70", Offset = "0x87FA70")]
		public float unpinnedMuscleWeightMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FAC4", Offset = "0x87FAC4")]
		public float maxRigidbodyVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FAFC", Offset = "0x87FAFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87FAFC", Offset = "0x87FAFC")]
		public float pinWeightThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FB50", Offset = "0x87FB50")]
		public bool unpinnedMuscleKnockout;

		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FB88", Offset = "0x87FB88")]
		public bool dropProps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87FBC0", Offset = "0x87FBC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FBC0", Offset = "0x87FBC0")]
		public bool canGetUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FC20", Offset = "0x87FC20")]
		public float getUpDelay;

		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FC58", Offset = "0x87FC58")]
		public float blendToAnimationTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FC90", Offset = "0x87FC90")]
		public float maxGetUpVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FCC8", Offset = "0x87FCC8")]
		public float minGetUpDuration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FD00", Offset = "0x87FD00")]
		public float getUpCollisionResistanceMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FD38", Offset = "0x87FD38")]
		public float getUpRegainPinSpeedMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FD70", Offset = "0x87FD70")]
		public float getUpKnockOutDistanceMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FDA8", Offset = "0x87FDA8")]
		public Vector3 getUpOffsetProne;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FDE0", Offset = "0x87FDE0")]
		public Vector3 getUpOffsetSupine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x87FE18", Offset = "0x87FE18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FE18", Offset = "0x87FE18")]
		public PuppetEvent onGetUpProne;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FE78", Offset = "0x87FE78")]
		public PuppetEvent onGetUpSupine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FEB0", Offset = "0x87FEB0")]
		public PuppetEvent onLoseBalance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FEE8", Offset = "0x87FEE8")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FF20", Offset = "0x87FF20")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87FF58", Offset = "0x87FF58")]
		public PuppetEvent onRegainBalance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionDelegate OnCollision;

		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FF90", Offset = "0x87FF90")]
		private State <state>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x87FFA0", Offset = "0x87FFA0")]
		public bool canMoveTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private float unpinnedTimer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private float getUpTimer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Vector3 hipsForward;

		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private Vector3 hipsUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float getupAnimationBlendWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float getupAnimationBlendWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool getUpTargetFixed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private NormalMode lastNormalMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private int collisions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private bool eventsEnabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private float lastKnockOutDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private float knockOutDistanceSqr;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private bool getupDisabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		private bool hasCollidedSinceGetUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2A2")]
		private bool hasBoosted;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private MuscleCollisionBroadcaster broadcaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private Vector3 getUpPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private bool dropPropFlag;

		public State state
		{
			[Address(RVA = "0x14D07A4", Offset = "0x14D07A4", VA = "0x14D07A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8895B8", Offset = "0x8895B8")]
			get
			{
				return default(State);
			}
			[Address(RVA = "0x14D07AC", Offset = "0x14D07AC", VA = "0x14D07AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8895C8", Offset = "0x8895C8")]
			private set
			{
			}
		}

		[Address(RVA = "0x14D070C", Offset = "0x14D070C", VA = "0x14D070C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889548", Offset = "0x889548")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x14D0758", Offset = "0x14D0758", VA = "0x14D0758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889580", Offset = "0x889580")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x14D07B4", Offset = "0x14D07B4", VA = "0x14D07B4", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Address(RVA = "0x14D0B04", Offset = "0x14D0B04", VA = "0x14D0B04")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Address(RVA = "0x14D0B70", Offset = "0x14D0B70", VA = "0x14D0B70", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Address(RVA = "0x14D0CDC", Offset = "0x14D0CDC", VA = "0x14D0CDC", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x14D1438", Offset = "0x14D1438", VA = "0x14D1438", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Address(RVA = "0x14D1EDC", Offset = "0x14D1EDC", VA = "0x14D1EDC", Slot = "8")]
		public override void KillStart()
		{
		}

		[Address(RVA = "0x14D1F98", Offset = "0x14D1F98", VA = "0x14D1F98", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Address(RVA = "0x14D1FA0", Offset = "0x14D1FA0", VA = "0x14D1FA0", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Address(RVA = "0x14D2048", Offset = "0x14D2048", VA = "0x14D2048", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Address(RVA = "0x14D2054", Offset = "0x14D2054", VA = "0x14D2054", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Address(RVA = "0x14D2B78", Offset = "0x14D2B78", VA = "0x14D2B78", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Address(RVA = "0x14D3004", Offset = "0x14D3004", VA = "0x14D3004")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Address(RVA = "0x14D3130", Offset = "0x14D3130", VA = "0x14D3130", Slot = "23")]
		protected override void OnReadBehaviour()
		{
		}

		[Address(RVA = "0x14D2D9C", Offset = "0x14D2D9C", VA = "0x14D2D9C")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Address(RVA = "0x14D3684", Offset = "0x14D3684", VA = "0x14D3684", Slot = "13")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Address(RVA = "0x14D36C4", Offset = "0x14D36C4", VA = "0x14D36C4", Slot = "14")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Address(RVA = "0x14D3600", Offset = "0x14D3600", VA = "0x14D3600")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Address(RVA = "0x14D36FC", Offset = "0x14D36FC", VA = "0x14D36FC")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Address(RVA = "0x14D3788", Offset = "0x14D3788", VA = "0x14D3788", Slot = "29")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Address(RVA = "0x14D379C", Offset = "0x14D379C", VA = "0x14D379C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0x14D3A8C", Offset = "0x14D3A8C", VA = "0x14D3A8C")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Address(RVA = "0x14D3B24", Offset = "0x14D3B24", VA = "0x14D3B24")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Address(RVA = "0x14D3DE4", Offset = "0x14D3DE4", VA = "0x14D3DE4")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Address(RVA = "0x14D40E0", Offset = "0x14D40E0", VA = "0x14D40E0")]
		public void BoostImmunity(float immunity)
		{
		}

		[Address(RVA = "0x14D3B68", Offset = "0x14D3B68", VA = "0x14D3B68")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Address(RVA = "0x14D4168", Offset = "0x14D4168", VA = "0x14D4168")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Address(RVA = "0x14D4214", Offset = "0x14D4214", VA = "0x14D4214")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Address(RVA = "0x14D3CA8", Offset = "0x14D3CA8", VA = "0x14D3CA8")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Address(RVA = "0x14D4294", Offset = "0x14D4294", VA = "0x14D4294")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Address(RVA = "0x14D4340", Offset = "0x14D4340", VA = "0x14D4340")]
		public void Unpin()
		{
		}

		[Address(RVA = "0x14D43BC", Offset = "0x14D43BC", VA = "0x14D43BC", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Address(RVA = "0x14D4778", Offset = "0x14D4778", VA = "0x14D4778", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Address(RVA = "0x14D4C44", Offset = "0x14D4C44", VA = "0x14D4C44")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Address(RVA = "0x14D452C", Offset = "0x14D452C", VA = "0x14D452C")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Address(RVA = "0x14D56D4", Offset = "0x14D56D4", VA = "0x14D56D4")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Address(RVA = "0x14D542C", Offset = "0x14D542C", VA = "0x14D542C")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Address(RVA = "0x14D5B40", Offset = "0x14D5B40", VA = "0x14D5B40")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Address(RVA = "0x14D3F14", Offset = "0x14D3F14", VA = "0x14D3F14")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Address(RVA = "0x14D5514", Offset = "0x14D5514", VA = "0x14D5514")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Address(RVA = "0x14D5CF0", Offset = "0x14D5CF0", VA = "0x14D5CF0")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Address(RVA = "0x14D2A20", Offset = "0x14D2A20", VA = "0x14D2A20")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Address(RVA = "0x14D152C", Offset = "0x14D152C", VA = "0x14D152C")]
		public void SetState(State newState)
		{
		}

		[Address(RVA = "0x14D5E28", Offset = "0x14D5E28", VA = "0x14D5E28")]
		public void SetColliders(bool unpinned)
		{
		}

		[Address(RVA = "0x14D08DC", Offset = "0x14D08DC", VA = "0x14D08DC")]
		public void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Address(RVA = "0x14D5ECC", Offset = "0x14D5ECC", VA = "0x14D5ECC", Slot = "11")]
		public override void OnMuscleDisconnected(Muscle m)
		{
		}

		[Address(RVA = "0x14D5ED4", Offset = "0x14D5ED4", VA = "0x14D5ED4", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Address(RVA = "0x14D5FE8", Offset = "0x14D5FE8", VA = "0x14D5FE8")]
		public BehaviourPuppet()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D0FC", Offset = "0x87D0FC")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Address(RVA = "0x14D61C0", Offset = "0x14D61C0", VA = "0x14D61C0", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x14D6208", Offset = "0x14D6208", VA = "0x14D6208", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Address(RVA = "0x14D620C", Offset = "0x14D620C", VA = "0x14D620C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Address(RVA = "0x14D6210", Offset = "0x14D6210", VA = "0x14D6210", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Address(RVA = "0x14D6214", Offset = "0x14D6214", VA = "0x14D6214", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Address(RVA = "0x14D6270", Offset = "0x14D6270", VA = "0x14D6270", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Address(RVA = "0x14D6274", Offset = "0x14D6274", VA = "0x14D6274", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Address(RVA = "0x14D627C", Offset = "0x14D627C", VA = "0x14D627C", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Address(RVA = "0x14D6284", Offset = "0x14D6284", VA = "0x14D6284")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		public class Settings
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884E8C", Offset = "0x884E8C")]
			public float damperForSpring;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884EC4", Offset = "0x884EC4")]
			public float maxForceMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884EFC", Offset = "0x884EFC")]
			public float IMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884F34", Offset = "0x884F34")]
			public float velocityF;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884F6C", Offset = "0x884F6C")]
			public Vector3 copOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884FA4", Offset = "0x884FA4")]
			public float torqueMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884FDC", Offset = "0x884FDC")]
			public float maxTorqueMag;

			[Address(RVA = "0x10BF2C8", Offset = "0x10BF2C8", VA = "0x10BF2C8")]
			public Settings()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FFB0", Offset = "0x87FFB0")]
		private ConfigurableJoint <joint>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FFC0", Offset = "0x87FFC0")]
		private Vector3 <dir>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FFD0", Offset = "0x87FFD0")]
		private Vector3 <dirVel>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FFE0", Offset = "0x87FFE0")]
		private Vector3 <cop>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FFF0", Offset = "0x87FFF0")]
		private Vector3 <com>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880000", Offset = "0x880000")]
		private Vector3 <comV>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		public ConfigurableJoint joint
		{
			[Address(RVA = "0x10BE8F4", Offset = "0x10BE8F4", VA = "0x10BE8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8895D8", Offset = "0x8895D8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x10BE8FC", Offset = "0x10BE8FC", VA = "0x10BE8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8895E8", Offset = "0x8895E8")]
			private set
			{
			}
		}

		public Vector3 dir
		{
			[Address(RVA = "0x10BE904", Offset = "0x10BE904", VA = "0x10BE904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8895F8", Offset = "0x8895F8")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BE910", Offset = "0x10BE910", VA = "0x10BE910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889608", Offset = "0x889608")]
			private set
			{
			}
		}

		public Vector3 dirVel
		{
			[Address(RVA = "0x10BE91C", Offset = "0x10BE91C", VA = "0x10BE91C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889618", Offset = "0x889618")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BE928", Offset = "0x10BE928", VA = "0x10BE928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889628", Offset = "0x889628")]
			private set
			{
			}
		}

		public Vector3 cop
		{
			[Address(RVA = "0x10BE934", Offset = "0x10BE934", VA = "0x10BE934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889638", Offset = "0x889638")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BE940", Offset = "0x10BE940", VA = "0x10BE940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889648", Offset = "0x889648")]
			private set
			{
			}
		}

		public Vector3 com
		{
			[Address(RVA = "0x10BE94C", Offset = "0x10BE94C", VA = "0x10BE94C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889658", Offset = "0x889658")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BE958", Offset = "0x10BE958", VA = "0x10BE958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889668", Offset = "0x889668")]
			private set
			{
			}
		}

		public Vector3 comV
		{
			[Address(RVA = "0x10BE964", Offset = "0x10BE964", VA = "0x10BE964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889678", Offset = "0x889678")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BE970", Offset = "0x10BE970", VA = "0x10BE970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889688", Offset = "0x889688")]
			private set
			{
			}
		}

		[Address(RVA = "0x10BE97C", Offset = "0x10BE97C", VA = "0x10BE97C")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Address(RVA = "0x10BEAE0", Offset = "0x10BEAE0", VA = "0x10BEAE0")]
		private void Solve()
		{
		}

		[Address(RVA = "0x10BF218", Offset = "0x10BF218", VA = "0x10BF218")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	public abstract class SubBehaviourBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Address(RVA = "0x10BF2E4", Offset = "0x10BF2E4", VA = "0x10BF2E4")]
		protected static Vector2 XZ(Vector3 v)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}

		[Address(RVA = "0x10BF314", Offset = "0x10BF314", VA = "0x10BF314")]
		protected static Vector3 XYZ(Vector2 v)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BF350", Offset = "0x10BF350", VA = "0x10BF350")]
		protected static Vector3 Flatten(Vector3 v)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BF388", Offset = "0x10BF388", VA = "0x10BF388")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BF2C0", Offset = "0x10BF2C0", VA = "0x10BF2C0")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		public enum Mode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			FeetCentroid,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			CenterOfPressure
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880010", Offset = "0x880010")]
		private Vector3 <position>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880020", Offset = "0x880020")]
		private Vector3 <direction>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880030", Offset = "0x880030")]
		private float <angle>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880040", Offset = "0x880040")]
		private Vector3 <velocity>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880050", Offset = "0x880050")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880060", Offset = "0x880060")]
		private Quaternion <rotation>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880070", Offset = "0x880070")]
		private Quaternion <inverseRotation>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880080", Offset = "0x880080")]
		private bool <isGrounded>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x880090", Offset = "0x880090")]
		private float <lastGroundedTime>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8800A0", Offset = "0x8800A0")]
		public bool[] groundContacts;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8800B0", Offset = "0x8800B0")]
		public Vector3[] groundContactPoints;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		public Vector3 position
		{
			[Address(RVA = "0x10BF3C0", Offset = "0x10BF3C0", VA = "0x10BF3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889698", Offset = "0x889698")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BF3CC", Offset = "0x10BF3CC", VA = "0x10BF3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8896A8", Offset = "0x8896A8")]
			private set
			{
			}
		}

		public Vector3 direction
		{
			[Address(RVA = "0x10BF3D8", Offset = "0x10BF3D8", VA = "0x10BF3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8896B8", Offset = "0x8896B8")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BF3E4", Offset = "0x10BF3E4", VA = "0x10BF3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8896C8", Offset = "0x8896C8")]
			private set
			{
			}
		}

		public float angle
		{
			[Address(RVA = "0x10BF3F0", Offset = "0x10BF3F0", VA = "0x10BF3F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8896D8", Offset = "0x8896D8")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0x10BF3F8", Offset = "0x10BF3F8", VA = "0x10BF3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8896E8", Offset = "0x8896E8")]
			private set
			{
			}
		}

		public Vector3 velocity
		{
			[Address(RVA = "0x10BF400", Offset = "0x10BF400", VA = "0x10BF400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8896F8", Offset = "0x8896F8")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BF40C", Offset = "0x10BF40C", VA = "0x10BF40C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889708", Offset = "0x889708")]
			private set
			{
			}
		}

		public Vector3 centerOfPressure
		{
			[Address(RVA = "0x10BF418", Offset = "0x10BF418", VA = "0x10BF418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889718", Offset = "0x889718")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10BF424", Offset = "0x10BF424", VA = "0x10BF424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889728", Offset = "0x889728")]
			private set
			{
			}
		}

		public Quaternion rotation
		{
			[Address(RVA = "0x10BF430", Offset = "0x10BF430", VA = "0x10BF430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889738", Offset = "0x889738")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
			[Address(RVA = "0x10BF43C", Offset = "0x10BF43C", VA = "0x10BF43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889748", Offset = "0x889748")]
			private set
			{
			}
		}

		public Quaternion inverseRotation
		{
			[Address(RVA = "0x10BF448", Offset = "0x10BF448", VA = "0x10BF448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889758", Offset = "0x889758")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
			[Address(RVA = "0x10BF454", Offset = "0x10BF454", VA = "0x10BF454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889768", Offset = "0x889768")]
			private set
			{
			}
		}

		public bool isGrounded
		{
			[Address(RVA = "0x10BF460", Offset = "0x10BF460", VA = "0x10BF460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889778", Offset = "0x889778")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x10BF468", Offset = "0x10BF468", VA = "0x10BF468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889788", Offset = "0x889788")]
			private set
			{
			}
		}

		public float lastGroundedTime
		{
			[Address(RVA = "0x10BF474", Offset = "0x10BF474", VA = "0x10BF474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889798", Offset = "0x889798")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0x10BF47C", Offset = "0x10BF47C", VA = "0x10BF47C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8897A8", Offset = "0x8897A8")]
			private set
			{
			}
		}

		[Address(RVA = "0x10BF484", Offset = "0x10BF484", VA = "0x10BF484")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Address(RVA = "0x10BF928", Offset = "0x10BF928", VA = "0x10BF928")]
		private void OnHierarchyChanged()
		{
		}

		[Address(RVA = "0x10BFA04", Offset = "0x10BFA04", VA = "0x10BFA04")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Address(RVA = "0x10BFD10", Offset = "0x10BFD10", VA = "0x10BFD10")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Address(RVA = "0x10BFE64", Offset = "0x10BFE64", VA = "0x10BFE64")]
		private void OnPreActivate()
		{
		}

		[Address(RVA = "0x10C042C", Offset = "0x10C042C", VA = "0x10C042C")]
		private void OnPreLateUpdate()
		{
		}

		[Address(RVA = "0x10C0D1C", Offset = "0x10C0D1C", VA = "0x10C0D1C")]
		private void OnPreDeactivate()
		{
		}

		[Address(RVA = "0x10BFB60", Offset = "0x10BFB60", VA = "0x10BFB60")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C07DC", Offset = "0x10C07DC", VA = "0x10C07DC")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Address(RVA = "0x10BFF80", Offset = "0x10BFF80", VA = "0x10BFF80")]
		private Vector3 GetCenterOfMass()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C0A2C", Offset = "0x10C0A2C", VA = "0x10C0A2C")]
		private Vector3 GetCenterOfMassVelocity()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C0D8C", Offset = "0x10C0D8C", VA = "0x10C0D8C")]
		private Vector3 GetMomentum()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C086C", Offset = "0x10C086C", VA = "0x10C086C")]
		private Vector3 GetCenterOfPressure()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C01C0", Offset = "0x10C01C0", VA = "0x10C01C0")]
		private Vector3 GetFeetCentroid()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C0FFC", Offset = "0x10C0FFC", VA = "0x10C0FFC")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	public class Booster
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8800C0", Offset = "0x8800C0")]
		public bool fullBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8800F8", Offset = "0x8800F8")]
		public ConfigurableJoint[] muscles;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880130", Offset = "0x880130")]
		public Muscle.Group[] groups;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880168", Offset = "0x880168")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x880168", Offset = "0x880168")]
		public float immunity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8801BC", Offset = "0x8801BC")]
		public float impulseMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8801F4", Offset = "0x8801F4")]
		public float boostParents;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88022C", Offset = "0x88022C")]
		public float boostChildren;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880264", Offset = "0x880264")]
		public float delay;

		[Address(RVA = "0x14DB918", Offset = "0x14DB918", VA = "0x14DB918")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Address(RVA = "0x14DBC0C", Offset = "0x14DBC0C", VA = "0x14DBC0C")]
		public Booster()
		{
		}
	}
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88029C", Offset = "0x88029C")]
		public PuppetMaster puppetMaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8802D4", Offset = "0x8802D4")]
		public int muscleIndex;

		[Address(RVA = "0x14DBC84", Offset = "0x14DBC84", VA = "0x14DBC84")]
		private void OnJointBreak()
		{
		}

		[Address(RVA = "0x14DBD30", Offset = "0x14DBD30", VA = "0x14DBD30")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	public class Muscle
	{
		[Serializable]
		public enum Group
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Hips,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Spine,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Arm,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Hand,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Leg,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Foot,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Tail,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Prop
		}

		[Serializable]
		public class InternalCollisionIgnoreSettings
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ConfigurableJoint[] muscles;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Group[] groups;

			[Address(RVA = "0x15F2A90", Offset = "0x15F2A90", VA = "0x15F2A90")]
			public InternalCollisionIgnoreSettings()
			{
			}
		}

		[Serializable]
		public class Props
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885014", Offset = "0x885014")]
			public Group group;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88504C", Offset = "0x88504C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88504C", Offset = "0x88504C")]
			public float mappingWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8850A0", Offset = "0x8850A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8850A0", Offset = "0x8850A0")]
			public float pinWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8850F4", Offset = "0x8850F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8850F4", Offset = "0x8850F4")]
			public float muscleWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885148", Offset = "0x885148")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885148", Offset = "0x885148")]
			public float muscleDamper;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88519C", Offset = "0x88519C")]
			public bool mapPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8851D4", Offset = "0x8851D4")]
			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88520C", Offset = "0x88520C")]
			public Transform[] animatedTargetChildren;

			[Address(RVA = "0x15F2B08", Offset = "0x15F2B08", VA = "0x15F2B08")]
			public Props()
			{
			}

			[Address(RVA = "0x15F2BA4", Offset = "0x15F2BA4", VA = "0x15F2BA4")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Address(RVA = "0x15F2C70", Offset = "0x15F2C70", VA = "0x15F2C70")]
			public void Clamp()
			{
			}
		}

		public struct State
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isDisconnected;

			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool resetFlag;

			public static State Default
			{
				[Address(RVA = "0x15F2D4C", Offset = "0x15F2D4C", VA = "0x15F2D4C")]
				get
				{
					return default(State);
				}
			}

			[Address(RVA = "0x962B14", Offset = "0x962B14", VA = "0x962B14")]
			public void Clamp()
			{
			}
		}

		public class TargetChild
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion defaultLocalRotation;

			[Address(RVA = "0x15F2E5C", Offset = "0x15F2E5C", VA = "0x15F2E5C")]
			public TargetChild(Transform t)
			{
			}

			[Address(RVA = "0x15F2F3C", Offset = "0x15F2F3C", VA = "0x15F2F3C")]
			public void Map()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88030C", Offset = "0x88030C")]
		public string name;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88031C", Offset = "0x88031C")]
		public int[] parentIndexes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88032C", Offset = "0x88032C")]
		public int[] childIndexes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88033C", Offset = "0x88033C")]
		public bool[] childFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88034C", Offset = "0x88034C")]
		public int[] kinshipDegrees;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88035C", Offset = "0x88035C")]
		public MuscleCollisionBroadcaster broadcaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88036C", Offset = "0x88036C")]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88037C", Offset = "0x88037C")]
		public Vector3 positionOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88038C", Offset = "0x88038C")]
		private Transform <transform>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88039C", Offset = "0x88039C")]
		private Rigidbody <rigidbody>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8803AC", Offset = "0x8803AC")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8803BC", Offset = "0x8803BC")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8803CC", Offset = "0x8803CC")]
		private Quaternion <targetAnimatedWorldRotation>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8803DC", Offset = "0x8803DC")]
		private Vector3 <targetVelocity>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8803EC", Offset = "0x8803EC")]
		private Vector3 <targetAngularVelocity>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8803FC", Offset = "0x8803FC")]
		private Rigidbody <additionalRigidbody>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88040C", Offset = "0x88040C")]
		public ConfigurableJoint additionalPin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x880444", Offset = "0x880444")]
		public Transform additionalPinTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88047C", Offset = "0x88047C")]
		public float additionalPinWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8804B4", Offset = "0x8804B4")]
		public Vector3 mappedVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8804C4", Offset = "0x8804C4")]
		public Vector3 mappedAngularVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8804D4", Offset = "0x8804D4")]
		public bool isPropMuscle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8804E4", Offset = "0x8804E4")]
		public int index;

		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88051C", Offset = "0x88051C")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88052C", Offset = "0x88052C")]
		private Rigidbody <rebuildConnectedBody>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88053C", Offset = "0x88053C")]
		private Transform <rebuildTargetParent>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88054C", Offset = "0x88054C")]
		private Vector3 <defaultTargetPosRelToMuscle>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88055C", Offset = "0x88055C")]
		private Quaternion <defaultTargetRotRelToMuscle>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Transform rebuildParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 rebuildPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion rebuildRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 rebuildTargetPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion rebuildTargetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ConfigurableJointMotion rebuildAngularXMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private ConfigurableJointMotion rebuildAngularYMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ConfigurableJointMotion rebuildAngularZMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88056C", Offset = "0x88056C")]
		public Vector3 targetMappedPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88057C", Offset = "0x88057C")]
		public Quaternion targetMappedRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88058C", Offset = "0x88058C")]
		public Vector3 targetSampledPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88059C", Offset = "0x88059C")]
		public Quaternion targetSampledRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private JointDrive slerpDrive;

		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private float lastJointDriveRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private float lastRotationDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Vector3 defaultPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 defaultTargetLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Vector3 lastMappedPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Quaternion localRotationConvert;

		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Quaternion toParentSpace;

		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Quaternion toJointSpaceInverse;

		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private Quaternion toJointSpaceDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private Quaternion targetAnimatedRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private Quaternion defaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private Quaternion rotationRelativeToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private Quaternion defaultTargetLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private Quaternion lastMappedRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private Transform targetParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Transform connectedBodyTransform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private bool directTargetParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2FD")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Collider[] _colliders;

		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float lastReadTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float lastWriteTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private bool[] disabledColliders;

		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private TargetChild[] targetChildren;

		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Vector3 additionalTargetAnimatedPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private Vector3 additionalTargetVelocity;

		public Transform transform
		{
			[Address(RVA = "0x14CEA44", Offset = "0x14CEA44", VA = "0x14CEA44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8897B8", Offset = "0x8897B8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD25C", Offset = "0x14DD25C", VA = "0x14DD25C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8897C8", Offset = "0x8897C8")]
			private set
			{
			}
		}

		public Rigidbody rigidbody
		{
			[Address(RVA = "0x14CE77C", Offset = "0x14CE77C", VA = "0x14CE77C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8897D8", Offset = "0x8897D8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD264", Offset = "0x14DD264", VA = "0x14DD264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8897E8", Offset = "0x8897E8")]
			private set
			{
			}
		}

		public Transform connectedBodyTarget
		{
			[Address(RVA = "0x14DD26C", Offset = "0x14DD26C", VA = "0x14DD26C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8897F8", Offset = "0x8897F8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD274", Offset = "0x14DD274", VA = "0x14DD274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889808", Offset = "0x889808")]
			private set
			{
			}
		}

		public Vector3 targetAnimatedPosition
		{
			[Address(RVA = "0x14DD27C", Offset = "0x14DD27C", VA = "0x14DD27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889818", Offset = "0x889818")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x14DD288", Offset = "0x14DD288", VA = "0x14DD288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889828", Offset = "0x889828")]
			private set
			{
			}
		}

		public Quaternion targetAnimatedWorldRotation
		{
			[Address(RVA = "0x14DD294", Offset = "0x14DD294", VA = "0x14DD294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889838", Offset = "0x889838")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
			[Address(RVA = "0x14DD2A0", Offset = "0x14DD2A0", VA = "0x14DD2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889848", Offset = "0x889848")]
			private set
			{
			}
		}

		public Collider[] colliders
		{
			[Address(RVA = "0x14D5EC4", Offset = "0x14D5EC4", VA = "0x14D5EC4")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD2AC", Offset = "0x14DD2AC", VA = "0x14DD2AC")]
			set
			{
			}
		}

		public Vector3 targetVelocity
		{
			[Address(RVA = "0x14D5B34", Offset = "0x14D5B34", VA = "0x14D5B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889858", Offset = "0x889858")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x14DD2B4", Offset = "0x14DD2B4", VA = "0x14DD2B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889868", Offset = "0x889868")]
			private set
			{
			}
		}

		public Vector3 targetAngularVelocity
		{
			[Address(RVA = "0x14DD2C0", Offset = "0x14DD2C0", VA = "0x14DD2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889878", Offset = "0x889878")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x14DD2CC", Offset = "0x14DD2CC", VA = "0x14DD2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889888", Offset = "0x889888")]
			private set
			{
			}
		}

		public Rigidbody additionalRigidbody
		{
			[Address(RVA = "0x14DD2D8", Offset = "0x14DD2D8", VA = "0x14DD2D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889898", Offset = "0x889898")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD2E0", Offset = "0x14DD2E0", VA = "0x14DD2E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8898A8", Offset = "0x8898A8")]
			private set
			{
			}
		}

		public Quaternion targetRotationRelative
		{
			[Address(RVA = "0x14DD2E8", Offset = "0x14DD2E8", VA = "0x14DD2E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8898B8", Offset = "0x8898B8")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
			[Address(RVA = "0x14DD2FC", Offset = "0x14DD2FC", VA = "0x14DD2FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8898C8", Offset = "0x8898C8")]
			private set
			{
			}
		}

		public Rigidbody rebuildConnectedBody
		{
			[Address(RVA = "0x14DD508", Offset = "0x14DD508", VA = "0x14DD508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8898D8", Offset = "0x8898D8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD510", Offset = "0x14DD510", VA = "0x14DD510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8898E8", Offset = "0x8898E8")]
			private set
			{
			}
		}

		public Transform rebuildTargetParent
		{
			[Address(RVA = "0x14DD518", Offset = "0x14DD518", VA = "0x14DD518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8898F8", Offset = "0x8898F8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x14DD520", Offset = "0x14DD520", VA = "0x14DD520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889908", Offset = "0x889908")]
			private set
			{
			}
		}

		public Vector3 defaultTargetPosRelToMuscle
		{
			[Address(RVA = "0x14DD528", Offset = "0x14DD528", VA = "0x14DD528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889918", Offset = "0x889918")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x14DD538", Offset = "0x14DD538", VA = "0x14DD538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889928", Offset = "0x889928")]
			private set
			{
			}
		}

		public Quaternion defaultTargetRotRelToMuscle
		{
			[Address(RVA = "0x14DD548", Offset = "0x14DD548", VA = "0x14DD548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889938", Offset = "0x889938")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
			[Address(RVA = "0x14DD55C", Offset = "0x14DD55C", VA = "0x14DD55C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889948", Offset = "0x889948")]
			private set
			{
			}
		}

		private Quaternion localRotation
		{
			[Address(RVA = "0x14DF018", Offset = "0x14DF018", VA = "0x14DF018")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
		}

		private Quaternion parentRotation
		{
			[Address(RVA = "0x14DF1C8", Offset = "0x14DF1C8", VA = "0x14DF1C8")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
		}

		private Quaternion targetParentRotation
		{
			[Address(RVA = "0x14DF108", Offset = "0x14DF108", VA = "0x14DF108")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
		}

		private Quaternion targetLocalRotation
		{
			[Address(RVA = "0x14DF35C", Offset = "0x14DF35C", VA = "0x14DF35C")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
		}

		[Address(RVA = "0x14DD310", Offset = "0x14DD310", VA = "0x14DD310")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Address(RVA = "0x14DD570", Offset = "0x14DD570", VA = "0x14DD570")]
		public void Rebuild()
		{
		}

		[Address(RVA = "0x14DD7B4", Offset = "0x14DD7B4", VA = "0x14DD7B4", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Address(RVA = "0x14DED2C", Offset = "0x14DED2C", VA = "0x14DED2C")]
		public void InitiateAdditionalPin()
		{
		}

		[Address(RVA = "0x14DEEC0", Offset = "0x14DEEC0", VA = "0x14DEEC0")]
		public void UpdateColliders()
		{
		}

		[Address(RVA = "0x14DFC38", Offset = "0x14DFC38", VA = "0x14DFC38")]
		public void DisableColliders()
		{
		}

		[Address(RVA = "0x14DFDCC", Offset = "0x14DFDCC", VA = "0x14DFDCC")]
		public void EnableColliders()
		{
		}

		[Address(RVA = "0x14DF838", Offset = "0x14DF838", VA = "0x14DF838")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Address(RVA = "0x14DFB14", Offset = "0x14DFB14", VA = "0x14DFB14")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Address(RVA = "0x14DFED8", Offset = "0x14DFED8", VA = "0x14DFED8")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Address(RVA = "0x14E0114", Offset = "0x14E0114", VA = "0x14E0114")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Address(RVA = "0x14E036C", Offset = "0x14E036C", VA = "0x14E036C")]
		private bool ForceIgnore(Muscle otherMuscle)
		{
			return default(bool);
		}

		[Address(RVA = "0x14E0660", Offset = "0x14E0660", VA = "0x14E0660")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Address(RVA = "0x14E0738", Offset = "0x14E0738", VA = "0x14E0738")]
		public void FixTargetTransforms()
		{
		}

		[Address(RVA = "0x14E07EC", Offset = "0x14E07EC", VA = "0x14E07EC")]
		public void Reset()
		{
		}

		[Address(RVA = "0x14E0AEC", Offset = "0x14E0AEC", VA = "0x14E0AEC")]
		public void MoveToTarget()
		{
		}

		[Address(RVA = "0x14D4684", Offset = "0x14D4684", VA = "0x14D4684")]
		public void SetKinematic(bool to)
		{
		}

		[Address(RVA = "0x14DF484", Offset = "0x14DF484", VA = "0x14DF484")]
		public void Read()
		{
		}

		[Address(RVA = "0x14E0D64", Offset = "0x14E0D64", VA = "0x14E0D64")]
		public void ClearVelocities()
		{
		}

		[Address(RVA = "0x14E0F1C", Offset = "0x14E0F1C", VA = "0x14E0F1C")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Address(RVA = "0x14E1328", Offset = "0x14E1328", VA = "0x14E1328", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, float deltaTime)
		{
		}

		[Address(RVA = "0x14E1984", Offset = "0x14E1984", VA = "0x14E1984")]
		public void StoreTargetMappedPosition()
		{
		}

		[Address(RVA = "0x14E19C8", Offset = "0x14E19C8", VA = "0x14E19C8")]
		public void StoreTargetMappedRotation()
		{
		}

		[Address(RVA = "0x14E1A10", Offset = "0x14E1A10", VA = "0x14E1A10")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Address(RVA = "0x14E1F38", Offset = "0x14E1F38", VA = "0x14E1F38")]
		public void ResetTargetLocalPosition()
		{
		}

		[Address(RVA = "0x14E1F90", Offset = "0x14E1F90", VA = "0x14E1F90")]
		public void CalculateMappedVelocity()
		{
		}

		[Address(RVA = "0x14E2194", Offset = "0x14E2194", VA = "0x14E2194")]
		public void MapDisconnected()
		{
		}

		[Address(RVA = "0x14E1468", Offset = "0x14E1468", VA = "0x14E1468")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Address(RVA = "0x14E23A4", Offset = "0x14E23A4", VA = "0x14E23A4")]
		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Address(RVA = "0x14E1748", Offset = "0x14E1748", VA = "0x14E1748")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Address(RVA = "0x14E2698", Offset = "0x14E2698", VA = "0x14E2698")]
		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Address(RVA = "0x14E25A4", Offset = "0x14E25A4", VA = "0x14E25A4")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x14E1208", Offset = "0x14E1208", VA = "0x14E1208")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14E2888", Offset = "0x14E2888", VA = "0x14E2888")]
		public Muscle()
		{
		}
	}
	public struct MuscleCollision
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Address(RVA = "0x962B68", Offset = "0x962B68", VA = "0x962B68")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	public struct MuscleHit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Address(RVA = "0x962B7C", Offset = "0x962B7C", VA = "0x962B7C")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D134", Offset = "0x87D134")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8805AC", Offset = "0x8805AC")]
		public PuppetMaster puppetMaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8805E4", Offset = "0x8805E4")]
		public int muscleIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const string onMuscleHit = "OnMuscleHit";

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Address(RVA = "0x15F2FDC", Offset = "0x15F2FDC", VA = "0x15F2FDC")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Address(RVA = "0x15F3108", Offset = "0x15F3108", VA = "0x15F3108")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Address(RVA = "0x15F3368", Offset = "0x15F3368", VA = "0x15F3368")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Address(RVA = "0x15F3664", Offset = "0x15F3664", VA = "0x15F3664")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Address(RVA = "0x15F395C", Offset = "0x15F395C", VA = "0x15F395C")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	public static class PhysXTools
	{
		[Address(RVA = "0x15F3964", Offset = "0x15F3964", VA = "0x15F3964")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation)
		{
		}

		[Address(RVA = "0x15F3A20", Offset = "0x15F3A20", VA = "0x15F3A20")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Address(RVA = "0x15F3B70", Offset = "0x15F3B70", VA = "0x15F3B70")]
		public static void Predict(ref Vector3 position, ref Quaternion rotation, ref Vector3 velocity, ref Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Address(RVA = "0x15F3E60", Offset = "0x15F3E60", VA = "0x15F3E60")]
		public static Vector3 GetCenterOfMass(PuppetMaster puppet)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F4180", Offset = "0x15F4180", VA = "0x15F4180")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F43E8", Offset = "0x15F43E8", VA = "0x15F43E8")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F4650", Offset = "0x15F4650", VA = "0x15F4650")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Address(RVA = "0x15F4790", Offset = "0x15F4790", VA = "0x15F4790")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Address(RVA = "0x15F48CC", Offset = "0x15F48CC", VA = "0x15F48CC")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F4A30", Offset = "0x15F4A30", VA = "0x15F4A30")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F4CC0", Offset = "0x15F4CC0", VA = "0x15F4CC0")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Address(RVA = "0x15F5004", Offset = "0x15F5004", VA = "0x15F5004")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Address(RVA = "0x15F5340", Offset = "0x15F5340", VA = "0x15F5340")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Address(RVA = "0x15F5634", Offset = "0x15F5634", VA = "0x15F5634")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F5708", Offset = "0x15F5708", VA = "0x15F5708")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x15F5874", Offset = "0x15F5874", VA = "0x15F5874")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x15F4750", Offset = "0x15F4750", VA = "0x15F4750")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}
	public class PressureSensor : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88061C", Offset = "0x88061C")]
		private Vector3 <center>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88062C", Offset = "0x88062C")]
		private bool <inContact>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88063C", Offset = "0x88063C")]
		private Vector3 <bottom>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88064C", Offset = "0x88064C")]
		private Rigidbody <r>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		public Vector3 center
		{
			[Address(RVA = "0x15F58D8", Offset = "0x15F58D8", VA = "0x15F58D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889958", Offset = "0x889958")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x15F58E4", Offset = "0x15F58E4", VA = "0x15F58E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889968", Offset = "0x889968")]
			private set
			{
			}
		}

		public bool inContact
		{
			[Address(RVA = "0x15F58F0", Offset = "0x15F58F0", VA = "0x15F58F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889978", Offset = "0x889978")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x15F58F8", Offset = "0x15F58F8", VA = "0x15F58F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889988", Offset = "0x889988")]
			private set
			{
			}
		}

		public Vector3 bottom
		{
			[Address(RVA = "0x15F5904", Offset = "0x15F5904", VA = "0x15F5904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889998", Offset = "0x889998")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x15F5910", Offset = "0x15F5910", VA = "0x15F5910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8899A8", Offset = "0x8899A8")]
			private set
			{
			}
		}

		public Rigidbody r
		{
			[Address(RVA = "0x15F591C", Offset = "0x15F591C", VA = "0x15F591C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8899B8", Offset = "0x8899B8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x15F5924", Offset = "0x15F5924", VA = "0x15F5924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8899C8", Offset = "0x8899C8")]
			private set
			{
			}
		}

		[Address(RVA = "0x15F592C", Offset = "0x15F592C", VA = "0x15F592C")]
		private void Awake()
		{
		}

		[Address(RVA = "0x15F59B0", Offset = "0x15F59B0", VA = "0x15F59B0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Address(RVA = "0x15F5BFC", Offset = "0x15F5BFC", VA = "0x15F5BFC")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Address(RVA = "0x15F5C00", Offset = "0x15F5C00", VA = "0x15F5C00")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Address(RVA = "0x15F5C08", Offset = "0x15F5C08", VA = "0x15F5C08")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x15F5CA4", Offset = "0x15F5CA4", VA = "0x15F5CA4")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x15F59B4", Offset = "0x15F59B4", VA = "0x15F59B4")]
		private void ProcessCollision(Collision c)
		{
		}

		[Address(RVA = "0x15F5D54", Offset = "0x15F5D54", VA = "0x15F5D54")]
		private void OnDrawGizmos()
		{
		}

		[Address(RVA = "0x15F5D78", Offset = "0x15F5D78", VA = "0x15F5D78")]
		public PressureSensor()
		{
		}
	}
	public abstract class Prop : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88065C", Offset = "0x88065C")]
		public int propType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880694", Offset = "0x880694")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880694", Offset = "0x880694")]
		public ConfigurableJoint muscle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8806F4", Offset = "0x8806F4")]
		public Muscle.Props muscleProps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88072C", Offset = "0x88072C")]
		public bool forceLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880764", Offset = "0x880764")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880764", Offset = "0x880764")]
		public ConfigurableJoint additionalPin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8807C4", Offset = "0x8807C4")]
		public Transform additionalPinTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8807FC", Offset = "0x8807FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8807FC", Offset = "0x8807FC")]
		public float additionalPinWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880850", Offset = "0x880850")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880850", Offset = "0x880850")]
		public PhysicMaterial pickedUpMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8808B0", Offset = "0x8808B0")]
		public PhysicMaterial droppedMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8808E8", Offset = "0x8808E8")]
		private PropRoot <propRoot>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8808F8", Offset = "0x8808F8")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion xMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ConfigurableJointMotion yMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ConfigurableJointMotion zMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJointMotion angularXMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ConfigurableJointMotion angularYMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ConfigurableJointMotion angularZMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		public bool isPickedUp
		{
			[Address(RVA = "0x15F5D80", Offset = "0x15F5D80", VA = "0x15F5D80")]
			get
			{
				return default(bool);
			}
		}

		public PropRoot propRoot
		{
			[Address(RVA = "0x15F5DF0", Offset = "0x15F5DF0", VA = "0x15F5DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8899D8", Offset = "0x8899D8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x15F5DF8", Offset = "0x15F5DF8", VA = "0x15F5DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8899E8", Offset = "0x8899E8")]
			private set
			{
			}
		}

		public bool initiated
		{
			[Address(RVA = "0x15F61A4", Offset = "0x15F61A4", VA = "0x15F61A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8899F8", Offset = "0x8899F8")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x15F61AC", Offset = "0x15F61AC", VA = "0x15F61AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889A08", Offset = "0x889A08")]
			private set
			{
			}
		}

		[Address(RVA = "0x15F5E00", Offset = "0x15F5E00", VA = "0x15F5E00")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Address(RVA = "0x15F6168", Offset = "0x15F6168", VA = "0x15F6168")]
		public void Drop()
		{
		}

		[Address(RVA = "0x15F619C", Offset = "0x15F619C", VA = "0x15F619C")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Address(RVA = "0x15F61B8", Offset = "0x15F61B8", VA = "0x15F61B8", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Address(RVA = "0x15F61BC", Offset = "0x15F61BC", VA = "0x15F61BC", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Address(RVA = "0x15F61C0", Offset = "0x15F61C0", VA = "0x15F61C0", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Address(RVA = "0x15F61C4", Offset = "0x15F61C4", VA = "0x15F61C4")]
		private void Start()
		{
		}

		[Address(RVA = "0x15F647C", Offset = "0x15F647C", VA = "0x15F647C")]
		private void ReleaseJoint()
		{
		}

		[Address(RVA = "0x15F6080", Offset = "0x15F6080", VA = "0x15F6080")]
		private void SetMaterial(PhysicMaterial material)
		{
		}

		[Address(RVA = "0x15F6668", Offset = "0x15F6668", VA = "0x15F6668")]
		private void OnDrawGizmos()
		{
		}

		[Address(RVA = "0x15F68D0", Offset = "0x15F68D0", VA = "0x15F68D0")]
		protected Prop()
		{
		}
	}
	public class PropMuscle : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x880908", Offset = "0x880908")]
		public PuppetMaster puppetMaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880940", Offset = "0x880940")]
		public PuppetMasterProp currentProp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880978", Offset = "0x880978")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880978", Offset = "0x880978")]
		public Vector3 additionalPinOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8809D8", Offset = "0x8809D8")]
		private PuppetMasterProp <activeProp>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Muscle _muscle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PuppetMasterProp lastProp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 targetDefaultLocalPos;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 lastAdditionalPinOffset;

		public Muscle muscle
		{
			[Address(RVA = "0x15F695C", Offset = "0x15F695C", VA = "0x15F695C")]
			get
			{
				return null;
			}
		}

		public PuppetMasterProp activeProp
		{
			[Address(RVA = "0x15F6A50", Offset = "0x15F6A50", VA = "0x15F6A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889A18", Offset = "0x889A18")]
			get
			{
				return null;
			}
			[Address(RVA = "0x15F6A58", Offset = "0x15F6A58", VA = "0x15F6A58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889A28", Offset = "0x889A28")]
			private set
			{
			}
		}

		[Address(RVA = "0x15F6A60", Offset = "0x15F6A60", VA = "0x15F6A60")]
		public bool AddAdditionalPin()
		{
			return default(bool);
		}

		[Address(RVA = "0x15F718C", Offset = "0x15F718C", VA = "0x15F718C")]
		public bool RemoveAdditionalPin()
		{
			return default(bool);
		}

		[Address(RVA = "0x15F7354", Offset = "0x15F7354", VA = "0x15F7354")]
		public void OnInitiate()
		{
		}

		[Address(RVA = "0x15F7614", Offset = "0x15F7614", VA = "0x15F7614")]
		public void TakeOver()
		{
		}

		[Address(RVA = "0x15F766C", Offset = "0x15F766C", VA = "0x15F766C")]
		public void OnUpdate()
		{
		}

		[Address(RVA = "0x15F9048", Offset = "0x15F9048", VA = "0x15F9048")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0x15F9490", Offset = "0x15F9490", VA = "0x15F9490")]
		public PropMuscle()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D16C", Offset = "0x87D16C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D16C", Offset = "0x87D16C")]
	public class PropRoot : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8809E8", Offset = "0x8809E8")]
		public PuppetMaster puppetMaster;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880A20", Offset = "0x880A20")]
		public Rigidbody connectTo;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880A58", Offset = "0x880A58")]
		public Prop currentProp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Address(RVA = "0x15F9508", Offset = "0x15F9508", VA = "0x15F9508")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889A38", Offset = "0x889A38")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x15F9554", Offset = "0x15F9554", VA = "0x15F9554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889A70", Offset = "0x889A70")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x15F95A0", Offset = "0x15F95A0", VA = "0x15F95A0")]
		public void DropImmediate()
		{
		}

		[Address(RVA = "0x15FB0E0", Offset = "0x15FB0E0", VA = "0x15FB0E0")]
		private void Awake()
		{
		}

		[Address(RVA = "0x15FB1B8", Offset = "0x15FB1B8", VA = "0x15FB1B8")]
		private void Update()
		{
		}

		[Address(RVA = "0x15FB308", Offset = "0x15FB308", VA = "0x15FB308")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x15FB560", Offset = "0x15FB560", VA = "0x15FB560")]
		private void AttachProp(Prop prop)
		{
		}

		[Address(RVA = "0x15FC680", Offset = "0x15FC680", VA = "0x15FC680")]
		public PropRoot()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D1CC", Offset = "0x87D1CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D1CC", Offset = "0x87D1CC")]
	public class PropTemplate : Prop
	{
		[Address(RVA = "0x15FC688", Offset = "0x15FC688", VA = "0x15FC688", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Address(RVA = "0x15FC68C", Offset = "0x15FC68C", VA = "0x15FC68C", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Address(RVA = "0x15FC690", Offset = "0x15FC690", VA = "0x15FC690", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Address(RVA = "0x15FC694", Offset = "0x15FC694", VA = "0x15FC694")]
		public PropTemplate()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D22C", Offset = "0x87D22C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D22C", Offset = "0x87D22C")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Active,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Kinematic,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Disabled
		}

		public delegate void UpdateDelegate();

		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		public enum UpdateMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Normal,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			AnimatePhysics,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			FixedUpdate
		}

		[Serializable]
		public enum State
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Alive,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Dead,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Frozen
		}

		[Serializable]
		public struct StateSettings
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885244", Offset = "0x885244")]
			public float killDuration;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88527C", Offset = "0x88527C")]
			public float deadMuscleWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8852B4", Offset = "0x8852B4")]
			public float deadMuscleDamper;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8852EC", Offset = "0x8852EC")]
			public float maxFreezeSqrVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885324", Offset = "0x885324")]
			public bool freezePermanently;

			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88535C", Offset = "0x88535C")]
			public bool enableAngularLimitsOnKill;

			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885394", Offset = "0x885394")]
			public bool enableInternalCollisionsOnKill;

			public static StateSettings Default
			{
				[Address(RVA = "0x15FC884", Offset = "0x15FC884", VA = "0x15FC884")]
				get
				{
					return default(StateSettings);
				}
			}

			[Address(RVA = "0x962C28", Offset = "0x962C28", VA = "0x962C28")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD68", Offset = "0x87DD68")]
		private sealed class <DisabledToActive>d__166 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x160F97C", Offset = "0x160F97C", VA = "0x160F97C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x160F9EC", Offset = "0x160F9EC", VA = "0x160F9EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1608B54", Offset = "0x1608B54", VA = "0x1608B54")]
			[DebuggerHidden]
			public <DisabledToActive>d__166(int <>1__state)
			{
			}

			[Address(RVA = "0x160F5A4", Offset = "0x160F5A4", VA = "0x160F5A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x160F5A8", Offset = "0x160F5A8", VA = "0x160F5A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x160F984", Offset = "0x160F984", VA = "0x160F984", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD78", Offset = "0x87DD78")]
		private sealed class <KinematicToActive>d__168 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x160FD0C", Offset = "0x160FD0C", VA = "0x160FD0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x160FD7C", Offset = "0x160FD7C", VA = "0x160FD7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1608B80", Offset = "0x1608B80", VA = "0x1608B80")]
			[DebuggerHidden]
			public <KinematicToActive>d__168(int <>1__state)
			{
			}

			[Address(RVA = "0x160F9F4", Offset = "0x160F9F4", VA = "0x160F9F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x160F9F8", Offset = "0x160F9F8", VA = "0x160F9F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x160FD14", Offset = "0x160FD14", VA = "0x160FD14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD88", Offset = "0x87DD88")]
		private sealed class <ActiveToDisabled>d__169 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x160ECF4", Offset = "0x160ECF4", VA = "0x160ECF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x160ED64", Offset = "0x160ED64", VA = "0x160ED64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1608BAC", Offset = "0x1608BAC", VA = "0x1608BAC")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__169(int <>1__state)
			{
			}

			[Address(RVA = "0x160EAF8", Offset = "0x160EAF8", VA = "0x160EAF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x160EAFC", Offset = "0x160EAFC", VA = "0x160EAFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x160ECFC", Offset = "0x160ECFC", VA = "0x160ECFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD98", Offset = "0x87DD98")]
		private sealed class <ActiveToKinematic>d__170 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x160EFB0", Offset = "0x160EFB0", VA = "0x160EFB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x160F020", Offset = "0x160F020", VA = "0x160F020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1608BD8", Offset = "0x1608BD8", VA = "0x1608BD8")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__170(int <>1__state)
			{
			}

			[Address(RVA = "0x160ED6C", Offset = "0x160ED6C", VA = "0x160ED6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x160ED70", Offset = "0x160ED70", VA = "0x160ED70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x160EFB8", Offset = "0x160EFB8", VA = "0x160EFB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDA8", Offset = "0x87DDA8")]
		private sealed class <AliveToDead>d__220 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x160F52C", Offset = "0x160F52C", VA = "0x160F52C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x160F59C", Offset = "0x160F59C", VA = "0x160F59C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x160CE0C", Offset = "0x160CE0C", VA = "0x160CE0C")]
			[DebuggerHidden]
			public <AliveToDead>d__220(int <>1__state)
			{
			}

			[Address(RVA = "0x160F028", Offset = "0x160F028", VA = "0x160F028", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x160F02C", Offset = "0x160F02C", VA = "0x160F02C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x160F534", Offset = "0x160F534", VA = "0x160F534", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880A90", Offset = "0x880A90")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880AC8", Offset = "0x880AC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880AC8", Offset = "0x880AC8")]
		public State state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x880B28", Offset = "0x880B28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880B28", Offset = "0x880B28")]
		public StateSettings stateSettings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880BA4", Offset = "0x880BA4")]
		public Mode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880BDC", Offset = "0x880BDC")]
		public float blendTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880C14", Offset = "0x880C14")]
		public bool fixTargetTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880C4C", Offset = "0x880C4C")]
		public int solverIterationCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880C84", Offset = "0x880C84")]
		public bool visualizeTargetPose;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880CBC", Offset = "0x880CBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880CBC", Offset = "0x880CBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x880CBC", Offset = "0x880CBC")]
		public float mappingWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880D34", Offset = "0x880D34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x880D34", Offset = "0x880D34")]
		public float pinWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880D88", Offset = "0x880D88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x880D88", Offset = "0x880D88")]
		public float muscleWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x880DDC", Offset = "0x880DDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880DDC", Offset = "0x880DDC")]
		public float muscleSpring;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880E3C", Offset = "0x880E3C")]
		public float muscleDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880E74", Offset = "0x880E74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x880E74", Offset = "0x880E74")]
		public float pinPow;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880EC8", Offset = "0x880EC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x880EC8", Offset = "0x880EC8")]
		public float pinDistanceFalloff;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880F20", Offset = "0x880F20")]
		public bool updateJointAnchors;

		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880F58", Offset = "0x880F58")]
		public bool supportTranslationAnimation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880F90", Offset = "0x880F90")]
		public bool angularLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x880FC8", Offset = "0x880FC8")]
		public bool internalCollisions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x881000", Offset = "0x881000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881000", Offset = "0x881000")]
		public Muscle[] muscles;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881060", Offset = "0x881060")]
		public PropMuscle[] propMuscles;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MuscleDelegate OnMuscleDisconnected;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MuscleDelegate OnMuscleReconnected;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Animator _targetAnimator;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x881098", Offset = "0x881098")]
		private Animation <targetAnimation>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8810A8", Offset = "0x8810A8")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8810B8", Offset = "0x8810B8")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8810C8", Offset = "0x8810C8")]
		public List<SolverManager> solvers;

		[NonSerialized]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8810D8", Offset = "0x8810D8")]
		public bool manualInternalCollisionControl;

		[NonSerialized]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8810E8", Offset = "0x8810E8")]
		public bool manualAngularLimitControl;

		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		private bool internalCollisionsEnabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool angularLimitsEnabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool fixedFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSolverIterationCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool isLegacy;

		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool animatorDisabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool awakeFailed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool interpolated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool freezeFlag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool hasBeenDisabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool hierarchyIsFlat;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		private bool teleport;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 teleportPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion teleportRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool teleportMoveToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool rebuildFlag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		private bool onPostRebuildFlag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool[] disconnectMuscleFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private MuscleDisconnectMode[] muscleDisconnectModes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool[] disconnectDeactivateFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool[] reconnectMuscleFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Muscle[] defaultMuscles;

		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 rebuildPelvisPos;

		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion rebuildPelvisRot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8810F8", Offset = "0x8810F8")]
		private bool <isSwitchingMode>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Mode activeMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Mode lastMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float mappingBlend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x881108", Offset = "0x881108")]
		private bool <isKilling>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public UpdateDelegate OnFreeze;

		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UpdateDelegate OnUnfreeze;

		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UpdateDelegate OnDeath;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UpdateDelegate OnResurrection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private State activeState;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private State lastState;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool angularLimitsEnabledOnKill;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
		private bool internalCollisionsEnabledOnKill;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
		private bool animationDisabledbyStates;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881118", Offset = "0x881118")]
		public bool storeTargetMappedState;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private bool targetMappedStateStored;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		private bool targetMappedStateSampled;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
		private bool sampleTargetMappedState;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1B7")]
		private bool hasProp;

		public Animator targetAnimator
		{
			[Address(RVA = "0x15FC8AC", Offset = "0x15FC8AC", VA = "0x15FC8AC")]
			get
			{
				return null;
			}
			[Address(RVA = "0x15FCA20", Offset = "0x15FCA20", VA = "0x15FCA20")]
			set
			{
			}
		}

		public Animation targetAnimation
		{
			[Address(RVA = "0x15FCA28", Offset = "0x15FCA28", VA = "0x15FCA28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889BF8", Offset = "0x889BF8")]
			get
			{
				return null;
			}
			[Address(RVA = "0x15FCA30", Offset = "0x15FCA30", VA = "0x15FCA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889C08", Offset = "0x889C08")]
			private set
			{
			}
		}

		public BehaviourBase[] behaviours
		{
			[Address(RVA = "0x15F30E8", Offset = "0x15F30E8", VA = "0x15F30E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889C18", Offset = "0x889C18")]
			get
			{
				return null;
			}
			[Address(RVA = "0x15FCA38", Offset = "0x15FCA38", VA = "0x15FCA38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889C28", Offset = "0x889C28")]
			private set
			{
			}
		}

		public bool isActive
		{
			[Address(RVA = "0x15FCA40", Offset = "0x15FCA40", VA = "0x15FCA40")]
			get
			{
				return default(bool);
			}
		}

		public bool initiated
		{
			[Address(RVA = "0x15F7184", Offset = "0x15F7184", VA = "0x15F7184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889C38", Offset = "0x889C38")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x15FCADC", Offset = "0x15FCADC", VA = "0x15FCADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889C48", Offset = "0x889C48")]
			private set
			{
			}
		}

		public UpdateMode updateMode
		{
			[Address(RVA = "0x15FCAE8", Offset = "0x15FCAE8", VA = "0x15FCAE8")]
			get
			{
				return default(UpdateMode);
			}
		}

		public bool controlsAnimator
		{
			[Address(RVA = "0x15FCC38", Offset = "0x15FCC38", VA = "0x15FCC38")]
			get
			{
				return default(bool);
			}
		}

		public bool isBlending
		{
			[Address(RVA = "0x15FCAB8", Offset = "0x15FCAB8", VA = "0x15FCAB8")]
			get
			{
				return default(bool);
			}
		}

		private bool autoSimulate
		{
			[Address(RVA = "0x15FDC08", Offset = "0x15FDC08", VA = "0x15FDC08")]
			get
			{
				return default(bool);
			}
		}

		private AnimatorUpdateMode targetUpdateMode
		{
			[Address(RVA = "0x15FCB28", Offset = "0x15FCB28", VA = "0x15FCB28")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(AnimatorUpdateMode);
			}
		}

		public bool isSwitchingMode
		{
			[Address(RVA = "0x15FCC98", Offset = "0x15FCC98", VA = "0x15FCC98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889D00", Offset = "0x889D00")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x15FE318", Offset = "0x15FE318", VA = "0x15FE318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889D10", Offset = "0x889D10")]
			private set
			{
			}
		}

		public bool isSwitchingState
		{
			[Address(RVA = "0x15FCCA0", Offset = "0x15FCCA0", VA = "0x15FCCA0")]
			get
			{
				return default(bool);
			}
		}

		public bool isKilling
		{
			[Address(RVA = "0x16086D8", Offset = "0x16086D8", VA = "0x16086D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889EB0", Offset = "0x889EB0")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x15FE324", Offset = "0x15FE324", VA = "0x15FE324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889EC0", Offset = "0x889EC0")]
			private set
			{
			}
		}

		public bool isAlive
		{
			[Address(RVA = "0x1604148", Offset = "0x1604148", VA = "0x1604148")]
			get
			{
				return default(bool);
			}
		}

		public bool isFrozen
		{
			[Address(RVA = "0x1602878", Offset = "0x1602878", VA = "0x1602878")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x15FC698", Offset = "0x15FC698", VA = "0x15FC698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889AA8", Offset = "0x889AA8")]
		private void OpenUserManualSetup()
		{
		}

		[Address(RVA = "0x15FC6E4", Offset = "0x15FC6E4", VA = "0x15FC6E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889AE0", Offset = "0x889AE0")]
		private void OpenUserManualComponent()
		{
		}

		[Address(RVA = "0x15FC730", Offset = "0x15FC730", VA = "0x15FC730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889B18", Offset = "0x889B18")]
		private void OpenUserManualPerformance()
		{
		}

		[Address(RVA = "0x15FC77C", Offset = "0x15FC77C", VA = "0x15FC77C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889B50", Offset = "0x889B50")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x15FC7C8", Offset = "0x15FC7C8", VA = "0x15FC7C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889B88", Offset = "0x889B88")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0x15FC814", Offset = "0x15FC814", VA = "0x15FC814")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889BC0", Offset = "0x889BC0")]
		private void OpenComponentTutorial()
		{
		}

		[Address(RVA = "0x15FC860", Offset = "0x15FC860", VA = "0x15FC860")]
		private void ResetStateSettings()
		{
		}

		[Address(RVA = "0x15FCCB4", Offset = "0x15FCCB4", VA = "0x15FCCB4")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Address(RVA = "0x15FD9C8", Offset = "0x15FD9C8", VA = "0x15FD9C8")]
		public void SetInternalCollisionsManual(bool collide, bool useInternalCollisionIgnores)
		{
		}

		[Address(RVA = "0x15FDB10", Offset = "0x15FDB10", VA = "0x15FDB10")]
		public void SetAngularLimitsManual(bool limited)
		{
		}

		[Address(RVA = "0x15FDC10", Offset = "0x15FDC10", VA = "0x15FDC10")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x15FDCD8", Offset = "0x15FDCD8", VA = "0x15FDCD8")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0x15FE714", Offset = "0x15FE714", VA = "0x15FE714")]
		private void Awake()
		{
		}

		[Address(RVA = "0x15FF624", Offset = "0x15FF624", VA = "0x15FF624")]
		private void Start()
		{
		}

		[Address(RVA = "0x15FF6DC", Offset = "0x15FF6DC", VA = "0x15FF6DC")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Address(RVA = "0x15FE760", Offset = "0x15FE760", VA = "0x15FE760")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x16012A4", Offset = "0x16012A4", VA = "0x16012A4")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Address(RVA = "0x16017DC", Offset = "0x16017DC", VA = "0x16017DC")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x1601944", Offset = "0x1601944", VA = "0x1601944")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Address(RVA = "0x16019F4", Offset = "0x16019F4", VA = "0x16019F4")]
		private void OnRebuild()
		{
		}

		[Address(RVA = "0x1601E14", Offset = "0x1601E14", VA = "0x1601E14")]
		public void OnPreSimulate(float deltaTime)
		{
		}

		[Address(RVA = "0x16029E0", Offset = "0x16029E0", VA = "0x16029E0")]
		public void OnPostSimulate()
		{
		}

		[Address(RVA = "0x16033C4", Offset = "0x16033C4", VA = "0x16033C4", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Address(RVA = "0x1603A08", Offset = "0x1603A08", VA = "0x1603A08", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Address(RVA = "0x1603B10", Offset = "0x1603B10", VA = "0x1603B10", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Address(RVA = "0x1603D70", Offset = "0x1603D70", VA = "0x1603D70", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Address(RVA = "0x1602ECC", Offset = "0x1602ECC", VA = "0x1602ECC")]
		private void MoveToTarget()
		{
		}

		[Address(RVA = "0x15FCCF4", Offset = "0x15FCCF4", VA = "0x15FCCF4")]
		private void Read()
		{
		}

		[Address(RVA = "0x1602668", Offset = "0x1602668", VA = "0x1602668")]
		private void FixTargetTransforms()
		{
		}

		[Address(RVA = "0x1604158", Offset = "0x1604158", VA = "0x1604158")]
		private void VisualizeTargetPose()
		{
		}

		[Address(RVA = "0x1604494", Offset = "0x1604494", VA = "0x1604494")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Address(RVA = "0x16010B0", Offset = "0x16010B0", VA = "0x16010B0")]
		public void FlagInternalCollisionsForUpdate()
		{
		}

		[Address(RVA = "0x1602888", Offset = "0x1602888", VA = "0x1602888")]
		private void UpdateInternalCollisions()
		{
		}

		[Address(RVA = "0x1604890", Offset = "0x1604890", VA = "0x1604890")]
		public void UpdateInternalCollisions(Muscle m)
		{
		}

		[Address(RVA = "0x1604768", Offset = "0x1604768", VA = "0x1604768")]
		private void IgnoreInternalCollisions()
		{
		}

		[Address(RVA = "0x160495C", Offset = "0x160495C", VA = "0x160495C")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Address(RVA = "0x1604638", Offset = "0x1604638", VA = "0x1604638")]
		private void ResetInternalCollisions()
		{
		}

		[Address(RVA = "0x16049F8", Offset = "0x16049F8", VA = "0x16049F8")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Address(RVA = "0x16010CC", Offset = "0x16010CC", VA = "0x16010CC")]
		public void FlagAngularLimitsForUpdate()
		{
		}

		[Address(RVA = "0x16028C0", Offset = "0x16028C0", VA = "0x16028C0")]
		private void UpdateAngularLimits()
		{
		}

		[Address(RVA = "0x1604AA4", Offset = "0x1604AA4", VA = "0x1604AA4")]
		public bool AddPropMuscle(ConfigurableJoint addPropMuscleTo, Vector3 position, Quaternion rotation, Vector3 additionalPinOffset, [Optional] Transform targetParent, [Optional] PuppetMasterProp initiateWithProp)
		{
			return default(bool);
		}

		[Address(RVA = "0x15F7E30", Offset = "0x15F7E30", VA = "0x15F7E30")]
		public bool IsDisconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Address(RVA = "0x15F7E84", Offset = "0x15F7E84", VA = "0x15F7E84")]
		public bool IsReconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Address(RVA = "0x15F7468", Offset = "0x15F7468", VA = "0x15F7468")]
		public void DisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Address(RVA = "0x15F8610", Offset = "0x15F8610", VA = "0x15F8610")]
		public void ReconnectMuscleRecursive(int index)
		{
		}

		[Address(RVA = "0x15FB8B4", Offset = "0x15FB8B4", VA = "0x15FB8B4")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Address(RVA = "0x1605A24", Offset = "0x1605A24", VA = "0x1605A24")]
		public void Rebuild()
		{
		}

		[Address(RVA = "0x15F9690", Offset = "0x15F9690", VA = "0x15F9690")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Address(RVA = "0x16065E8", Offset = "0x16065E8", VA = "0x16065E8")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Address(RVA = "0x1606688", Offset = "0x1606688", VA = "0x1606688")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Address(RVA = "0x1606728", Offset = "0x1606728", VA = "0x1606728")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Address(RVA = "0x16067C8", Offset = "0x16067C8", VA = "0x16067C8")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Address(RVA = "0x1606868", Offset = "0x1606868", VA = "0x1606868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889C58", Offset = "0x889C58")]
		public void FlattenHierarchy()
		{
		}

		[Address(RVA = "0x160699C", Offset = "0x160699C", VA = "0x160699C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889C90", Offset = "0x889C90")]
		public void TreeHierarchy()
		{
		}

		[Address(RVA = "0x1606B50", Offset = "0x1606B50", VA = "0x1606B50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889CC8", Offset = "0x889CC8")]
		public void FixMusclePositions()
		{
		}

		[Address(RVA = "0x1600F80", Offset = "0x1600F80", VA = "0x1600F80")]
		public bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Address(RVA = "0x16053EC", Offset = "0x16053EC", VA = "0x16053EC")]
		private int GetHighestDisconnectedParentIndex(int index)
		{
			return default(int);
		}

		[Address(RVA = "0x16023D8", Offset = "0x16023D8", VA = "0x16023D8")]
		private void ProcessDisconnects()
		{
		}

		[Address(RVA = "0x1602574", Offset = "0x1602574", VA = "0x1602574")]
		private void ProcessReconnects()
		{
		}

		[Address(RVA = "0x1606CDC", Offset = "0x1606CDC", VA = "0x1606CDC")]
		private void OnDisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Address(RVA = "0x1607504", Offset = "0x1607504", VA = "0x1607504")]
		private void DisconnectMuscle(Muscle m, bool sever, bool deactivate)
		{
		}

		[Address(RVA = "0x1607238", Offset = "0x1607238", VA = "0x1607238")]
		private void OnReconnectMuscleRecursive(int index)
		{
		}

		[Address(RVA = "0x1607C7C", Offset = "0x1607C7C", VA = "0x1607C7C")]
		private void ReconnectMuscle(Muscle m)
		{
		}

		[Address(RVA = "0x16081E0", Offset = "0x16081E0", VA = "0x16081E0")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Address(RVA = "0x1605C28", Offset = "0x1605C28", VA = "0x1605C28")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Address(RVA = "0x1605DA0", Offset = "0x1605DA0", VA = "0x1605DA0")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Address(RVA = "0x160846C", Offset = "0x160846C", VA = "0x160846C")]
		public void DisableImmediately()
		{
		}

		[Address(RVA = "0x160853C", Offset = "0x160853C", VA = "0x160853C", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Address(RVA = "0x16086E0", Offset = "0x16086E0", VA = "0x16086E0")]
		private void DisabledToKinematic()
		{
		}

		[Address(RVA = "0x16088B4", Offset = "0x16088B4", VA = "0x16088B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x889D20", Offset = "0x889D20")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Address(RVA = "0x1608928", Offset = "0x1608928", VA = "0x1608928")]
		private void KinematicToDisabled()
		{
		}

		[Address(RVA = "0x16089F8", Offset = "0x16089F8", VA = "0x16089F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x889D84", Offset = "0x889D84")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Address(RVA = "0x1608A6C", Offset = "0x1608A6C", VA = "0x1608A6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x889DE8", Offset = "0x889DE8")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Address(RVA = "0x1608AE0", Offset = "0x1608AE0", VA = "0x1608AE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x889E4C", Offset = "0x889E4C")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Address(RVA = "0x1608C04", Offset = "0x1608C04", VA = "0x1608C04")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Address(RVA = "0x1608D20", Offset = "0x1608D20", VA = "0x1608D20")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Address(RVA = "0x1609230", Offset = "0x1609230", VA = "0x1609230")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Address(RVA = "0x16094FC", Offset = "0x16094FC", VA = "0x16094FC")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Address(RVA = "0x1609654", Offset = "0x1609654", VA = "0x1609654")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Address(RVA = "0x16097C4", Offset = "0x16097C4", VA = "0x16097C4")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Address(RVA = "0x1608FB0", Offset = "0x1608FB0", VA = "0x1608FB0")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Address(RVA = "0x1609850", Offset = "0x1609850", VA = "0x1609850")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Address(RVA = "0x16055E4", Offset = "0x16055E4", VA = "0x16055E4")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Address(RVA = "0x15F69E4", Offset = "0x15F69E4", VA = "0x15F69E4")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Address(RVA = "0x1601D1C", Offset = "0x1601D1C", VA = "0x1601D1C")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Address(RVA = "0x16092BC", Offset = "0x16092BC", VA = "0x16092BC")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Address(RVA = "0x1608DAC", Offset = "0x1608DAC", VA = "0x1608DAC")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Address(RVA = "0x16098BC", Offset = "0x16098BC", VA = "0x16098BC")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Address(RVA = "0x1605A30", Offset = "0x1605A30", VA = "0x1605A30")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Address(RVA = "0x1609AD0", Offset = "0x1609AD0", VA = "0x1609AD0")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Address(RVA = "0x160ABA4", Offset = "0x160ABA4", VA = "0x160ABA4")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Address(RVA = "0x1609BDC", Offset = "0x1609BDC", VA = "0x1609BDC")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Address(RVA = "0x160AD58", Offset = "0x160AD58", VA = "0x160AD58")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Address(RVA = "0x160B6B4", Offset = "0x160B6B4", VA = "0x160B6B4")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Address(RVA = "0x160C17C", Offset = "0x160C17C", VA = "0x160C17C")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Address(RVA = "0x160B1BC", Offset = "0x160B1BC", VA = "0x160B1BC")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Address(RVA = "0x160C6DC", Offset = "0x160C6DC", VA = "0x160C6DC")]
		public void Kill()
		{
		}

		[Address(RVA = "0x160C6E8", Offset = "0x160C6E8", VA = "0x160C6E8")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Address(RVA = "0x160C704", Offset = "0x160C704", VA = "0x160C704")]
		public void Freeze()
		{
		}

		[Address(RVA = "0x160C710", Offset = "0x160C710", VA = "0x160C710")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Address(RVA = "0x160C72C", Offset = "0x160C72C", VA = "0x160C72C")]
		public void Resurrect()
		{
		}

		[Address(RVA = "0x160C734", Offset = "0x160C734", VA = "0x160C734", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Address(RVA = "0x160C834", Offset = "0x160C834", VA = "0x160C834")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x889ED0", Offset = "0x889ED0")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Address(RVA = "0x1603080", Offset = "0x1603080", VA = "0x1603080")]
		private void OnFreezeFlag()
		{
		}

		[Address(RVA = "0x160C8D0", Offset = "0x160C8D0", VA = "0x160C8D0")]
		private void DeadToAlive()
		{
		}

		[Address(RVA = "0x15FE330", Offset = "0x15FE330", VA = "0x15FE330")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Address(RVA = "0x160CA48", Offset = "0x160CA48", VA = "0x160CA48")]
		private void DeadToFrozen()
		{
		}

		[Address(RVA = "0x160CA54", Offset = "0x160CA54", VA = "0x160CA54")]
		private void FrozenToAlive()
		{
		}

		[Address(RVA = "0x160CD20", Offset = "0x160CD20", VA = "0x160CD20")]
		private void FrozenToDead()
		{
		}

		[Address(RVA = "0x15FE444", Offset = "0x15FE444", VA = "0x15FE444")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Address(RVA = "0x160CE38", Offset = "0x160CE38", VA = "0x160CE38")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Address(RVA = "0x160CF10", Offset = "0x160CF10", VA = "0x160CF10")]
		public void SampleTargetMappedState()
		{
		}

		[Address(RVA = "0x160D0C4", Offset = "0x160D0C4", VA = "0x160D0C4")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Address(RVA = "0x16010E8", Offset = "0x16010E8", VA = "0x16010E8")]
		public void StoreTargetMappedState()
		{
		}

		[Address(RVA = "0x1600BFC", Offset = "0x1600BFC", VA = "0x1600BFC")]
		private void UpdateHierarchies()
		{
		}

		[Address(RVA = "0x160DE00", Offset = "0x160DE00", VA = "0x160DE00")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Address(RVA = "0x160DBF4", Offset = "0x160DBF4", VA = "0x160DBF4")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Address(RVA = "0x160D564", Offset = "0x160D564", VA = "0x160D564")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Address(RVA = "0x160DE9C", Offset = "0x160DE9C", VA = "0x160DE9C")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Address(RVA = "0x160E050", Offset = "0x160E050", VA = "0x160E050")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Address(RVA = "0x160DA64", Offset = "0x160DA64", VA = "0x160DA64")]
		private void AssignKinshipDegrees()
		{
		}

		[Address(RVA = "0x160E3F8", Offset = "0x160E3F8", VA = "0x160E3F8")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Address(RVA = "0x160E5D0", Offset = "0x160E5D0", VA = "0x160E5D0")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Address(RVA = "0x160E2F8", Offset = "0x160E2F8", VA = "0x160E2F8")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Address(RVA = "0x15FFAC8", Offset = "0x15FFAC8", VA = "0x15FFAC8")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Address(RVA = "0x1605650", Offset = "0x1605650", VA = "0x1605650")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Address(RVA = "0x1605554", Offset = "0x1605554", VA = "0x1605554")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Address(RVA = "0x160E934", Offset = "0x160E934", VA = "0x160E934")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	public enum MuscleRemoveMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sever,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Explode,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Numb
	}
	[Serializable]
	public enum MuscleDisconnectMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Sever,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Explode
	}
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x87D28C", Offset = "0x87D28C")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		public class HumanoidMuscle
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x8853CC", Offset = "0x8853CC")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Address(RVA = "0x1610040", Offset = "0x1610040", VA = "0x1610040")]
			public HumanoidMuscle()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x881128", Offset = "0x881128")]
		public PuppetMaster.State state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x881160", Offset = "0x881160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881160", Offset = "0x881160")]
		public float mappingWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8811B4", Offset = "0x8811B4")]
		public float pinWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8811CC", Offset = "0x8811CC")]
		public float muscleWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8811E4", Offset = "0x8811E4")]
		public float muscleSpring;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88121C", Offset = "0x88121C")]
		public float pinPow;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881234", Offset = "0x881234")]
		public float pinDistanceFalloff;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool updateJointAnchors;

		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool supportTranslationAnimation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool angularLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool internalCollisions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x881250", Offset = "0x881250")]
		public HumanoidMuscle[] muscles;

		[Address(RVA = "0x16007EC", Offset = "0x16007EC", VA = "0x16007EC")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Address(RVA = "0x160FE38", Offset = "0x160FE38", VA = "0x160FE38")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Address(RVA = "0x160FF88", Offset = "0x160FF88", VA = "0x160FF88")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	public class PuppetMasterProp : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881288", Offset = "0x881288")]
		public Transform meshRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8812C0", Offset = "0x8812C0")]
		public Muscle.Props muscleProps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8812F8", Offset = "0x8812F8")]
		public bool forceLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881330", Offset = "0x881330")]
		public float mass;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881368", Offset = "0x881368")]
		public int propType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8813A0", Offset = "0x8813A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8813A0", Offset = "0x8813A0")]
		public PhysicMaterial pickedUpMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x881400", Offset = "0x881400")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881400", Offset = "0x881400")]
		public Vector3 additionalPinOffsetAdd;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881460", Offset = "0x881460")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881460", Offset = "0x881460")]
		public float additionalPinWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8814B4", Offset = "0x8814B4")]
		public float additionalPinMass;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8814EC", Offset = "0x8814EC")]
		private bool <isPickedUp>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8814FC", Offset = "0x8814FC")]
		private Muscle <propMuscle>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int defaultLayer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform defaultParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PhysicMaterial[] droppedMaterials;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody r;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _mass;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _drag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _angularDrag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _useGravity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isKinematic;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RigidbodyInterpolation _interpolation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private CollisionDetectionMode _collisionDetectionMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RigidbodyConstraints _constraints;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] emptyColliders;

		public bool isPickedUp
		{
			[Address(RVA = "0x1610048", Offset = "0x1610048", VA = "0x1610048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F34", Offset = "0x889F34")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x1610050", Offset = "0x1610050", VA = "0x1610050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F44", Offset = "0x889F44")]
			private set
			{
			}
		}

		protected Muscle propMuscle
		{
			[Address(RVA = "0x1610064", Offset = "0x1610064", VA = "0x1610064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F54", Offset = "0x889F54")]
			get
			{
				return null;
			}
			[Address(RVA = "0x161006C", Offset = "0x161006C", VA = "0x161006C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F64", Offset = "0x889F64")]
			private set
			{
			}
		}

		[Address(RVA = "0x161005C", Offset = "0x161005C", VA = "0x161005C", Slot = "4")]
		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Address(RVA = "0x1610060", Offset = "0x1610060", VA = "0x1610060", Slot = "5")]
		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Address(RVA = "0x15F89C8", Offset = "0x15F89C8", VA = "0x15F89C8")]
		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Address(RVA = "0x15F7ED8", Offset = "0x15F7ED8", VA = "0x15F7ED8")]
		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Address(RVA = "0x161041C", Offset = "0x161041C", VA = "0x161041C", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Address(RVA = "0x16105C4", Offset = "0x16105C4", VA = "0x16105C4", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0x1610808", Offset = "0x1610808", VA = "0x1610808", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Address(RVA = "0x1610074", Offset = "0x1610074", VA = "0x1610074")]
		private void RemoveRigidbody()
		{
		}

		[Address(RVA = "0x1610230", Offset = "0x1610230", VA = "0x1610230")]
		private void ReattachRigidbody()
		{
		}

		[Address(RVA = "0x1610950", Offset = "0x1610950", VA = "0x1610950")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0x1610B44", Offset = "0x1610B44", VA = "0x1610B44")]
		public PuppetMasterProp()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D2FC", Offset = "0x87D2FC")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		public class PuppetUpdateLimit
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885404", Offset = "0x885404")]
			public int puppetsPerFrame;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Address(RVA = "0x1611248", Offset = "0x1611248", VA = "0x1611248")]
			public PuppetUpdateLimit()
			{
			}

			[Address(RVA = "0x161108C", Offset = "0x161108C", VA = "0x161108C")]
			public void Step(int puppetCount)
			{
			}

			[Address(RVA = "0x1610C1C", Offset = "0x1610C1C", VA = "0x1610C1C")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x88150C", Offset = "0x88150C")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x881544", Offset = "0x881544")]
		private int <currentlyActivePuppets>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x881554", Offset = "0x881554")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x881564", Offset = "0x881564")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		public int currentlyActivePuppets
		{
			[Address(RVA = "0x1610BE4", Offset = "0x1610BE4", VA = "0x1610BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F74", Offset = "0x889F74")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x1610BEC", Offset = "0x1610BEC", VA = "0x1610BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F84", Offset = "0x889F84")]
			private set
			{
			}
		}

		public int currentlyKinematicPuppets
		{
			[Address(RVA = "0x1610BF4", Offset = "0x1610BF4", VA = "0x1610BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889F94", Offset = "0x889F94")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x1610BFC", Offset = "0x1610BFC", VA = "0x1610BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889FA4", Offset = "0x889FA4")]
			private set
			{
			}
		}

		public int currentlyDisabledPuppets
		{
			[Address(RVA = "0x1610C04", Offset = "0x1610C04", VA = "0x1610C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889FB4", Offset = "0x889FB4")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x1610C0C", Offset = "0x1610C0C", VA = "0x1610C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x889FC4", Offset = "0x889FC4")]
			private set
			{
			}
		}

		public List<PuppetMaster> puppets
		{
			[Address(RVA = "0x1610C14", Offset = "0x1610C14", VA = "0x1610C14")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x16011F8", Offset = "0x16011F8", VA = "0x16011F8")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Address(RVA = "0x16018D4", Offset = "0x16018D4", VA = "0x16018D4")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Address(RVA = "0x1604104", Offset = "0x1604104", VA = "0x1604104")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Address(RVA = "0x1610D9C", Offset = "0x1610D9C", VA = "0x1610D9C")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Address(RVA = "0x1610DE0", Offset = "0x1610DE0", VA = "0x1610DE0")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Address(RVA = "0x1610E24", Offset = "0x1610E24", VA = "0x1610E24")]
		private void Update()
		{
		}

		[Address(RVA = "0x16110A8", Offset = "0x16110A8", VA = "0x16110A8")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x1611140", Offset = "0x1611140", VA = "0x1611140")]
		public PuppetMasterSettings()
		{
		}
	}
	public static class PuppetMasterTools
	{
		[Address(RVA = "0x1611274", Offset = "0x1611274", VA = "0x1611274")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Address(RVA = "0x1611BF4", Offset = "0x1611BF4", VA = "0x1611BF4")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Address(RVA = "0x16129B0", Offset = "0x16129B0", VA = "0x16129B0")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x1612A70", Offset = "0x1612A70", VA = "0x1612A70")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	public class Weight
	{
		[Serializable]
		public enum Mode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Float,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Curve
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Address(RVA = "0x10C1010", Offset = "0x10C1010", VA = "0x10C1010")]
		public Weight(float floatValue)
		{
		}

		[Address(RVA = "0x10C107C", Offset = "0x10C107C", VA = "0x10C107C")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Address(RVA = "0x10C10F8", Offset = "0x10C10F8", VA = "0x10C10F8")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D334", Offset = "0x87D334")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D334", Offset = "0x87D334")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		public struct Options
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x885420", Offset = "0x885420")]
			public bool spine;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x885458", Offset = "0x885458")]
			public JointType joints;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x885490", Offset = "0x885490")]
			public float colliderLengthOverlap;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			public static Options Default
			{
				[Address(RVA = "0x14D65C0", Offset = "0x14D65C0", VA = "0x14D65C0")]
				get
				{
					return default(Options);
				}
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Address(RVA = "0x14D6294", Offset = "0x14D6294", VA = "0x14D6294")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x889FD4", Offset = "0x889FD4")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x14D62E0", Offset = "0x14D62E0", VA = "0x14D62E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A00C", Offset = "0x88A00C")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x14D632C", Offset = "0x14D632C", VA = "0x14D632C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A044", Offset = "0x88A044")]
		private void OpenTutorial()
		{
		}

		[Address(RVA = "0x14D6378", Offset = "0x14D6378", VA = "0x14D6378")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Address(RVA = "0x14D66E0", Offset = "0x14D66E0", VA = "0x14D66E0")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Address(RVA = "0x14D71EC", Offset = "0x14D71EC", VA = "0x14D71EC")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Address(RVA = "0x14D8FB8", Offset = "0x14D8FB8", VA = "0x14D8FB8")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Address(RVA = "0x14D9330", Offset = "0x14D9330", VA = "0x14D9330")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Address(RVA = "0x14D9A6C", Offset = "0x14D9A6C", VA = "0x14D9A6C")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14D7FD0", Offset = "0x14D7FD0", VA = "0x14D7FD0")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Address(RVA = "0x14D8640", Offset = "0x14D8640", VA = "0x14D8640")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Address(RVA = "0x14D9C48", Offset = "0x14D9C48", VA = "0x14D9C48")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Address(RVA = "0x14DA484", Offset = "0x14DA484", VA = "0x14DA484")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Address(RVA = "0x14DAA2C", Offset = "0x14DAA2C", VA = "0x14DAA2C")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Address(RVA = "0x14D8ECC", Offset = "0x14D8ECC", VA = "0x14D8ECC")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14D65F8", Offset = "0x14D65F8", VA = "0x14D65F8")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x14DAB34", Offset = "0x14DAB34", VA = "0x14DAB34")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	public struct BipedRagdollReferences
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Address(RVA = "0x960CD8", Offset = "0x960CD8", VA = "0x960CD8")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Address(RVA = "0x960CE0", Offset = "0x960CE0", VA = "0x960CE0")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Address(RVA = "0x960CE8", Offset = "0x960CE8", VA = "0x960CE8")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Address(RVA = "0x960CF4", Offset = "0x960CF4", VA = "0x960CF4")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Address(RVA = "0x960D00", Offset = "0x960D00", VA = "0x960D00")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Address(RVA = "0x14DB3DC", Offset = "0x14DB3DC", VA = "0x14DB3DC")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Address(RVA = "0x14DB7D0", Offset = "0x14DB7D0", VA = "0x14DB7D0")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	public static class JointConverter
	{
		[Address(RVA = "0x14DBD38", Offset = "0x14DBD38", VA = "0x14DBD38")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Address(RVA = "0x14DC4DC", Offset = "0x14DC4DC", VA = "0x14DC4DC")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Address(RVA = "0x14DC978", Offset = "0x14DC978", VA = "0x14DC978")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Address(RVA = "0x14DCB84", Offset = "0x14DCB84", VA = "0x14DCB84")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Address(RVA = "0x14DC024", Offset = "0x14DC024", VA = "0x14DC024")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Address(RVA = "0x14DCE48", Offset = "0x14DCE48", VA = "0x14DCE48")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Address(RVA = "0x14DD08C", Offset = "0x14DD08C", VA = "0x14DD08C")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(SoftJointLimit);
		}

		[Address(RVA = "0x14DD144", Offset = "0x14DD144", VA = "0x14DD144")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(SoftJointLimit);
		}

		[Address(RVA = "0x14DD0F0", Offset = "0x14DD0F0", VA = "0x14DD0F0")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(SoftJointLimitSpring);
		}

		[Address(RVA = "0x14DD1A8", Offset = "0x14DD1A8", VA = "0x14DD1A8")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(SoftJointLimit);
		}

		[Address(RVA = "0x14DD208", Offset = "0x14DD208", VA = "0x14DD208")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(SoftJointLimitSpring);
		}
	}
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		public enum ColliderType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Box,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Capsule
		}

		[Serializable]
		public enum JointType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Configurable,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Character
		}

		[Serializable]
		public enum Direction
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			X,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Y,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Z
		}

		public struct CreateJointParams
		{
			public struct Limits
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Address(RVA = "0x9554E8", Offset = "0x9554E8", VA = "0x9554E8")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Address(RVA = "0x9554C8", Offset = "0x9554C8", VA = "0x9554C8")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Address(RVA = "0x10BC724", Offset = "0x10BC724", VA = "0x10BC724")]
		public static void ClearAll(Transform root)
		{
		}

		[Address(RVA = "0x10BC96C", Offset = "0x10BC96C", VA = "0x10BC96C")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Address(RVA = "0x10BCBC8", Offset = "0x10BCBC8", VA = "0x10BCBC8")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Address(RVA = "0x10BD2D0", Offset = "0x10BD2D0", VA = "0x10BD2D0")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Address(RVA = "0x10BD138", Offset = "0x10BD138", VA = "0x10BD138")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Address(RVA = "0x10BD760", Offset = "0x10BD760", VA = "0x10BD760")]
		protected static Vector3 Abs(Vector3 v)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BD790", Offset = "0x10BD790", VA = "0x10BD790")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Address(RVA = "0x10BD814", Offset = "0x10BD814", VA = "0x10BD814")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BD8D4", Offset = "0x10BD8D4", VA = "0x10BD8D4")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BD178", Offset = "0x10BD178", VA = "0x10BD178")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Address(RVA = "0x10BD994", Offset = "0x10BD994", VA = "0x10BD994")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10BDCD4", Offset = "0x10BDCD4", VA = "0x10BDCD4")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0x10BDEBC", Offset = "0x10BDEBC", VA = "0x10BDEBC")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Address(RVA = "0x10BE798", Offset = "0x10BE798", VA = "0x10BE798")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(SoftJointLimit);
		}

		[Address(RVA = "0x10BE7CC", Offset = "0x10BE7CC", VA = "0x10BE7CC")]
		protected RagdollCreator()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D394", Offset = "0x87D394")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D394", Offset = "0x87D394")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Colliders,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Joints
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881574", Offset = "0x881574")]
		public Rigidbody selectedRigidbody;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881584", Offset = "0x881584")]
		public Collider selectedCollider;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881594", Offset = "0x881594")]
		public bool symmetry;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x8815A4", Offset = "0x8815A4")]
		public Mode mode;

		[Address(RVA = "0x10BE800", Offset = "0x10BE800", VA = "0x10BE800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A07C", Offset = "0x88A07C")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x10BE84C", Offset = "0x10BE84C", VA = "0x10BE84C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A0B4", Offset = "0x88A0B4")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10BE898", Offset = "0x10BE898", VA = "0x10BE898")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A0EC", Offset = "0x88A0EC")]
		private void OpenTutorial()
		{
		}

		[Address(RVA = "0x10BE8E4", Offset = "0x10BE8E4", VA = "0x10BE8E4")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D3F4", Offset = "0x87D3F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D3F4", Offset = "0x87D3F4")]
	public class BipedIK : SolverManager
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Address(RVA = "0x10C3694", Offset = "0x10C3694", VA = "0x10C3694")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A124", Offset = "0x88A124")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x10C36E0", Offset = "0x10C36E0", VA = "0x10C36E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A15C", Offset = "0x88A15C")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10C372C", Offset = "0x10C372C", VA = "0x10C372C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A194", Offset = "0x88A194")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10C3778", Offset = "0x10C3778", VA = "0x10C3778")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A1CC", Offset = "0x88A1CC")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10C37C4", Offset = "0x10C37C4", VA = "0x10C37C4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Address(RVA = "0x10C3894", Offset = "0x10C3894", VA = "0x10C3894")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Address(RVA = "0x10C38C4", Offset = "0x10C38C4", VA = "0x10C38C4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Address(RVA = "0x10C3904", Offset = "0x10C3904", VA = "0x10C3904")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Address(RVA = "0x10C3944", Offset = "0x10C3944", VA = "0x10C3944")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Address(RVA = "0x10C399C", Offset = "0x10C399C", VA = "0x10C399C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Address(RVA = "0x10C39FC", Offset = "0x10C39FC", VA = "0x10C39FC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C3A30", Offset = "0x10C3A30", VA = "0x10C3A30")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x10C3A60", Offset = "0x10C3A60", VA = "0x10C3A60")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Address(RVA = "0x10C3AF8", Offset = "0x10C3AF8", VA = "0x10C3AF8")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Address(RVA = "0x10C3B60", Offset = "0x10C3B60", VA = "0x10C3B60")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Address(RVA = "0x10C3BC8", Offset = "0x10C3BC8", VA = "0x10C3BC8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Address(RVA = "0x10C37F4", Offset = "0x10C37F4", VA = "0x10C37F4")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Address(RVA = "0x10C3C18", Offset = "0x10C3C18", VA = "0x10C3C18")]
		public void InitiateBipedIK()
		{
		}

		[Address(RVA = "0x10C3C24", Offset = "0x10C3C24", VA = "0x10C3C24")]
		public void UpdateBipedIK()
		{
		}

		[Address(RVA = "0x10C3C30", Offset = "0x10C3C30", VA = "0x10C3C30")]
		public void SetToDefaults()
		{
		}

		[Address(RVA = "0x10C407C", Offset = "0x10C407C", VA = "0x10C407C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Address(RVA = "0x10C4174", Offset = "0x10C4174", VA = "0x10C4174", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0x10C46B8", Offset = "0x10C46B8", VA = "0x10C46B8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0x10C4D88", Offset = "0x10C4D88", VA = "0x10C4D88")]
		public void LogWarning(string message)
		{
		}

		[Address(RVA = "0x10C4DBC", Offset = "0x10C4DBC", VA = "0x10C4DBC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	public class BipedIKSolvers
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		public IKSolverLimb[] limbs
		{
			[Address(RVA = "0x10C3EC4", Offset = "0x10C3EC4", VA = "0x10C3EC4")]
			get
			{
				return null;
			}
		}

		public IKSolver[] ikSolvers
		{
			[Address(RVA = "0x10C4F88", Offset = "0x10C4F88", VA = "0x10C4F88")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x10C43FC", Offset = "0x10C43FC", VA = "0x10C43FC")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Address(RVA = "0x10C4E40", Offset = "0x10C4E40", VA = "0x10C4E40")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	public abstract class Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		public bool isValid
		{
			[Address(RVA = "0x10C56A0", Offset = "0x10C56A0", VA = "0x10C56A0")]
			get
			{
				return default(bool);
			}
		}

		public abstract void UpdateConstraint();

		[Address(RVA = "0x10C5710", Offset = "0x10C5710", VA = "0x10C5710")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Address(RVA = "0x10C5718", Offset = "0x10C5718", VA = "0x10C5718", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0x10C584C", Offset = "0x10C584C", VA = "0x10C584C")]
		public ConstraintPosition()
		{
		}

		[Address(RVA = "0x10C5854", Offset = "0x10C5854", VA = "0x10C5854")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		private bool positionChanged
		{
			[Address(RVA = "0x10C5AAC", Offset = "0x10C5AAC", VA = "0x10C5AAC")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x10C5880", Offset = "0x10C5880", VA = "0x10C5880", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0x10C5B70", Offset = "0x10C5B70", VA = "0x10C5B70")]
		public ConstraintPositionOffset()
		{
		}

		[Address(RVA = "0x10C5B78", Offset = "0x10C5B78", VA = "0x10C5B78")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Address(RVA = "0x10C5BA4", Offset = "0x10C5BA4", VA = "0x10C5BA4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0x10C5CFC", Offset = "0x10C5CFC", VA = "0x10C5CFC")]
		public ConstraintRotation()
		{
		}

		[Address(RVA = "0x10C5D04", Offset = "0x10C5D04", VA = "0x10C5D04")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		private bool rotationChanged
		{
			[Address(RVA = "0x10C5F70", Offset = "0x10C5F70", VA = "0x10C5F70")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x10C5D30", Offset = "0x10C5D30", VA = "0x10C5D30", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0x10C6048", Offset = "0x10C6048", VA = "0x10C6048")]
		public ConstraintRotationOffset()
		{
		}

		[Address(RVA = "0x10C6050", Offset = "0x10C6050", VA = "0x10C6050")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	public class Constraints
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8815B4", Offset = "0x8815B4")]
		public float positionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8815CC", Offset = "0x8815CC")]
		public float rotationWeight;

		[Address(RVA = "0x10C607C", Offset = "0x10C607C", VA = "0x10C607C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Address(RVA = "0x10C4640", Offset = "0x10C4640", VA = "0x10C4640")]
		public void Initiate(Transform transform)
		{
		}

		[Address(RVA = "0x10C4954", Offset = "0x10C4954", VA = "0x10C4954")]
		public void Update()
		{
		}

		[Address(RVA = "0x10C5224", Offset = "0x10C5224", VA = "0x10C5224")]
		public Constraints()
		{
		}
	}
	[Serializable]
	public class Finger
	{
		[Serializable]
		public enum DOF
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			One,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Three
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8815E4", Offset = "0x8815E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8815E4", Offset = "0x8815E4")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881638", Offset = "0x881638")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881638", Offset = "0x881638")]
		public float rotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88168C", Offset = "0x88168C")]
		public DOF rotationDOF;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8816C4", Offset = "0x8816C4")]
		public Transform bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8816FC", Offset = "0x8816FC")]
		public Transform bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881734", Offset = "0x881734")]
		public Transform bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88176C", Offset = "0x88176C")]
		public Transform tip;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8817A4", Offset = "0x8817A4")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8817DC", Offset = "0x8817DC")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		public bool initiated
		{
			[Address(RVA = "0x10D051C", Offset = "0x10D051C", VA = "0x10D051C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A204", Offset = "0x88A204")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x10D0524", Offset = "0x10D0524", VA = "0x10D0524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A214", Offset = "0x88A214")]
			private set
			{
			}
		}

		public Vector3 IKPosition
		{
			[Address(RVA = "0x10D0530", Offset = "0x10D0530", VA = "0x10D0530")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x10D0560", Offset = "0x10D0560", VA = "0x10D0560")]
			set
			{
			}
		}

		public Quaternion IKRotation
		{
			[Address(RVA = "0x10D05AC", Offset = "0x10D05AC", VA = "0x10D05AC")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}
			[Address(RVA = "0x10D05DC", Offset = "0x10D05DC", VA = "0x10D05DC")]
			set
			{
			}
		}

		[Address(RVA = "0x10D062C", Offset = "0x10D062C", VA = "0x10D062C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x10D072C", Offset = "0x10D072C", VA = "0x10D072C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Address(RVA = "0x10D0C38", Offset = "0x10D0C38", VA = "0x10D0C38")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0x10D0D68", Offset = "0x10D0D68", VA = "0x10D0D68")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x10D0E50", Offset = "0x10D0E50", VA = "0x10D0E50")]
		public void Update(float masterWeight)
		{
		}

		[Address(RVA = "0x10D1494", Offset = "0x10D1494", VA = "0x10D1494")]
		public Finger()
		{
		}
	}
	public class FingerRig : SolverManager
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8817EC", Offset = "0x8817EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8817EC", Offset = "0x8817EC")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x881840", Offset = "0x881840")]
		private bool <initiated>k__BackingField;

		public bool initiated
		{
			[Address(RVA = "0x10D14A4", Offset = "0x10D14A4", VA = "0x10D14A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A224", Offset = "0x88A224")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x10D14AC", Offset = "0x10D14AC", VA = "0x10D14AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A234", Offset = "0x88A234")]
			private set
			{
			}
		}

		[Address(RVA = "0x10D14B8", Offset = "0x10D14B8", VA = "0x10D14B8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x10D154C", Offset = "0x10D154C", VA = "0x10D154C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A244", Offset = "0x88A244")]
		public void AutoDetect()
		{
		}

		[Address(RVA = "0x10D1998", Offset = "0x10D1998", VA = "0x10D1998")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Address(RVA = "0x10D1BAC", Offset = "0x10D1BAC", VA = "0x10D1BAC")]
		public void RemoveFinger(int index)
		{
		}

		[Address(RVA = "0x10D184C", Offset = "0x10D184C", VA = "0x10D184C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Address(RVA = "0x10D1DA4", Offset = "0x10D1DA4", VA = "0x10D1DA4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0x10D1EAC", Offset = "0x10D1EAC", VA = "0x10D1EAC")]
		public void UpdateFingerSolvers()
		{
		}

		[Address(RVA = "0x10D1F40", Offset = "0x10D1F40", VA = "0x10D1F40")]
		public void FixFingerTransforms()
		{
		}

		[Address(RVA = "0x10D1FCC", Offset = "0x10D1FCC", VA = "0x10D1FCC")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x10D204C", Offset = "0x10D204C", VA = "0x10D204C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0x10D2050", Offset = "0x10D2050", VA = "0x10D2050", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Address(RVA = "0x10D2064", Offset = "0x10D2064", VA = "0x10D2064")]
		public FingerRig()
		{
		}
	}
	public abstract class Grounder : MonoBehaviour
	{
		public delegate void GrounderDelegate();

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881850", Offset = "0x881850")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881850", Offset = "0x881850")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8818A4", Offset = "0x8818A4")]
		public Grounding solver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8818DC", Offset = "0x8818DC")]
		private bool <initiated>k__BackingField;

		public bool initiated
		{
			[Address(RVA = "0x10D341C", Offset = "0x10D341C", VA = "0x10D341C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A27C", Offset = "0x88A27C")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x10D3424", Offset = "0x10D3424", VA = "0x10D3424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A28C", Offset = "0x88A28C")]
			protected set
			{
			}
		}

		public abstract void ResetPosition();

		[Address(RVA = "0x10D3430", Offset = "0x10D3430", VA = "0x10D3430")]
		protected Vector3 GetSpineOffsetTarget()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10D3780", Offset = "0x10D3780", VA = "0x10D3780")]
		protected void LogWarning(string message)
		{
		}

		[Address(RVA = "0x10D35B8", Offset = "0x10D35B8", VA = "0x10D35B8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10D37B4", Offset = "0x10D37B4", VA = "0x10D37B4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();

		[Address(RVA = "0x10D3A34", Offset = "0x10D3A34", VA = "0x10D3A34")]
		protected Grounder()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D454", Offset = "0x87D454")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D454", Offset = "0x87D454")]
	public class GrounderBipedIK : Grounder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8818EC", Offset = "0x8818EC")]
		public BipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881924", Offset = "0x881924")]
		public float spineBend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88195C", Offset = "0x88195C")]
		public float spineSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Address(RVA = "0x10D3FA0", Offset = "0x10D3FA0", VA = "0x10D3FA0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A29C", Offset = "0x88A29C")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10D3FEC", Offset = "0x10D3FEC", VA = "0x10D3FEC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A2D4", Offset = "0x88A2D4")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10D4038", Offset = "0x10D4038", VA = "0x10D4038", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0x10D416C", Offset = "0x10D416C", VA = "0x10D416C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0x10D426C", Offset = "0x10D426C", VA = "0x10D426C")]
		private void Update()
		{
		}

		[Address(RVA = "0x10D4320", Offset = "0x10D4320", VA = "0x10D4320")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x10D4AB4", Offset = "0x10D4AB4", VA = "0x10D4AB4")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x10D4B40", Offset = "0x10D4B40", VA = "0x10D4B40")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0x10D5540", Offset = "0x10D5540", VA = "0x10D5540")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Address(RVA = "0x10D572C", Offset = "0x10D572C", VA = "0x10D572C")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0x10D599C", Offset = "0x10D599C", VA = "0x10D599C")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10D5BF0", Offset = "0x10D5BF0", VA = "0x10D5BF0")]
		public GrounderBipedIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D4B4", Offset = "0x87D4B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D4B4", Offset = "0x87D4B4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		public class SpineEffector
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8854C8", Offset = "0x8854C8")]
			public FullBodyBipedEffector effectorType;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885500", Offset = "0x885500")]
			public float horizontalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885538", Offset = "0x885538")]
			public float verticalWeight;

			[Address(RVA = "0x10D6DE8", Offset = "0x10D6DE8", VA = "0x10D6DE8")]
			public SpineEffector()
			{
			}

			[Address(RVA = "0x10D6DF8", Offset = "0x10D6DF8", VA = "0x10D6DF8")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881994", Offset = "0x881994")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8819CC", Offset = "0x8819CC")]
		public float spineBend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881A04", Offset = "0x881A04")]
		public float spineSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Address(RVA = "0x10D5C70", Offset = "0x10D5C70", VA = "0x10D5C70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A30C", Offset = "0x88A30C")]
		private void OpenTutorial()
		{
		}

		[Address(RVA = "0x10D5CBC", Offset = "0x10D5CBC", VA = "0x10D5CBC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A344", Offset = "0x88A344")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10D5D08", Offset = "0x10D5D08", VA = "0x10D5D08", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A37C", Offset = "0x88A37C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10D5D54", Offset = "0x10D5D54", VA = "0x10D5D54", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0x10D5DDC", Offset = "0x10D5DDC", VA = "0x10D5DDC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0x10D5E8C", Offset = "0x10D5E8C", VA = "0x10D5E8C")]
		private void Update()
		{
		}

		[Address(RVA = "0x10D627C", Offset = "0x10D627C", VA = "0x10D627C")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x10D6288", Offset = "0x10D6288", VA = "0x10D6288")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x10D5F48", Offset = "0x10D5F48", VA = "0x10D5F48")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x10D6294", Offset = "0x10D6294", VA = "0x10D6294")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0x10D68BC", Offset = "0x10D68BC", VA = "0x10D68BC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Address(RVA = "0x10D6AC8", Offset = "0x10D6AC8", VA = "0x10D6AC8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0x10D6C00", Offset = "0x10D6C00", VA = "0x10D6C00")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10D6D68", Offset = "0x10D6D68", VA = "0x10D6D68")]
		public GrounderFBBIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D514", Offset = "0x87D514")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D514", Offset = "0x87D514")]
	public class GrounderIK : Grounder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881A3C", Offset = "0x881A3C")]
		public Transform pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881A74", Offset = "0x881A74")]
		public Transform characterRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881AAC", Offset = "0x881AAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881AAC", Offset = "0x881AAC")]
		public float rootRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881B00", Offset = "0x881B00")]
		public float rootRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881B38", Offset = "0x881B38")]
		public float maxRootRotationAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Address(RVA = "0x10D6E40", Offset = "0x10D6E40", VA = "0x10D6E40", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A3B4", Offset = "0x88A3B4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10D6E8C", Offset = "0x10D6E8C", VA = "0x10D6E8C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A3EC", Offset = "0x88A3EC")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10D6ED8", Offset = "0x10D6ED8", VA = "0x10D6ED8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0x10D6F04", Offset = "0x10D6F04", VA = "0x10D6F04")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0x10D7104", Offset = "0x10D7104", VA = "0x10D7104")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x10D7250", Offset = "0x10D7250", VA = "0x10D7250")]
		private void Update()
		{
		}

		[Address(RVA = "0x10D7A9C", Offset = "0x10D7A9C", VA = "0x10D7A9C")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x10D80E0", Offset = "0x10D80E0", VA = "0x10D80E0")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0x10D83D0", Offset = "0x10D83D0", VA = "0x10D83D0")]
		private void SetLegIK(int index)
		{
		}

		[Address(RVA = "0x10D8918", Offset = "0x10D8918", VA = "0x10D8918")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0x10D8B94", Offset = "0x10D8B94", VA = "0x10D8B94")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10D8E2C", Offset = "0x10D8E2C", VA = "0x10D8E2C")]
		public GrounderIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D574", Offset = "0x87D574")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D574", Offset = "0x87D574")]
	public class GrounderQuadruped : Grounder
	{
		public struct Foot
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Address(RVA = "0x95554C", Offset = "0x95554C", VA = "0x95554C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881B70", Offset = "0x881B70")]
		public Grounding forelegSolver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881BA8", Offset = "0x881BA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881BA8", Offset = "0x881BA8")]
		public float rootRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881BFC", Offset = "0x881BFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881BFC", Offset = "0x881BFC")]
		public float minRootRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881C54", Offset = "0x881C54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881C54", Offset = "0x881C54")]
		public float maxRootRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881CAC", Offset = "0x881CAC")]
		public float rootRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881CE4", Offset = "0x881CE4")]
		public float maxLegOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881D1C", Offset = "0x881D1C")]
		public float maxForeLegOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881D54", Offset = "0x881D54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x881D54", Offset = "0x881D54")]
		public float maintainHeadRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881DA8", Offset = "0x881DA8")]
		public Transform characterRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881DE0", Offset = "0x881DE0")]
		public Transform pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881E18", Offset = "0x881E18")]
		public Transform lastSpineBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881E50", Offset = "0x881E50")]
		public Transform head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881E88", Offset = "0x881E88")]
		public Vector3 gravity;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Address(RVA = "0x10D8EAC", Offset = "0x10D8EAC", VA = "0x10D8EAC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A424", Offset = "0x88A424")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10D8EF8", Offset = "0x10D8EF8", VA = "0x10D8EF8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A45C", Offset = "0x88A45C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10D8F44", Offset = "0x10D8F44", VA = "0x10D8F44", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0x10D8F8C", Offset = "0x10D8F8C", VA = "0x10D8F8C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0x10D90C8", Offset = "0x10D90C8", VA = "0x10D90C8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Address(RVA = "0x10D9280", Offset = "0x10D9280", VA = "0x10D9280")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x10D9360", Offset = "0x10D9360", VA = "0x10D9360")]
		private void Update()
		{
		}

		[Address(RVA = "0x10D9418", Offset = "0x10D9418", VA = "0x10D9418")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x10D9824", Offset = "0x10D9824", VA = "0x10D9824")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Address(RVA = "0x10D9D2C", Offset = "0x10D9D2C", VA = "0x10D9D2C")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x10D9E78", Offset = "0x10D9E78", VA = "0x10D9E78")]
		private void RootRotation()
		{
		}

		[Address(RVA = "0x10DA3DC", Offset = "0x10DA3DC", VA = "0x10DA3DC")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0x10DAE24", Offset = "0x10DAE24", VA = "0x10DAE24")]
		private void UpdateForefeetRoot()
		{
		}

		[Address(RVA = "0x10DB180", Offset = "0x10DB180", VA = "0x10DB180")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Address(RVA = "0x10DB314", Offset = "0x10DB314", VA = "0x10DB314")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0x10DB70C", Offset = "0x10DB70C", VA = "0x10DB70C")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10DB750", Offset = "0x10DB750", VA = "0x10DB750")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Address(RVA = "0x10DB9E0", Offset = "0x10DB9E0", VA = "0x10DB9E0")]
		public GrounderQuadruped()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D5D4", Offset = "0x87D5D4")]
	public class GrounderVRIK : Grounder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881E98", Offset = "0x881E98")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Address(RVA = "0x10DBAFC", Offset = "0x10DBAFC", VA = "0x10DBAFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A494", Offset = "0x88A494")]
		private void OpenTutorial()
		{
		}

		[Address(RVA = "0x10DBB00", Offset = "0x10DBB00", VA = "0x10DBB00", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A4CC", Offset = "0x88A4CC")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10DBB04", Offset = "0x10DBB04", VA = "0x10DBB04", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A504", Offset = "0x88A504")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10DBB08", Offset = "0x10DBB08", VA = "0x10DBB08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0x10DBB34", Offset = "0x10DBB34", VA = "0x10DBB34")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0x10DBBE4", Offset = "0x10DBBE4", VA = "0x10DBBE4")]
		private void Update()
		{
		}

		[Address(RVA = "0x10DBC98", Offset = "0x10DBC98", VA = "0x10DBC98")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x10DBFE4", Offset = "0x10DBFE4", VA = "0x10DBFE4")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0x10DC3C4", Offset = "0x10DC3C4", VA = "0x10DC3C4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Address(RVA = "0x10DC500", Offset = "0x10DC500", VA = "0x10DC500")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0x10DC830", Offset = "0x10DC830", VA = "0x10DC830")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0x10DC968", Offset = "0x10DC968", VA = "0x10DC968")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10DCB9C", Offset = "0x10DCB9C", VA = "0x10DCB9C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	public class Grounding
	{
		[Serializable]
		public enum Quality
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Fastest,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Simple,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Best
		}

		public class Leg
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885570", Offset = "0x885570")]
			private bool <isGrounded>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885580", Offset = "0x885580")]
			private Vector3 <IKPosition>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885590", Offset = "0x885590")]
			private bool <initiated>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8855A0", Offset = "0x8855A0")]
			private float <heightFromGround>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8855B0", Offset = "0x8855B0")]
			private Vector3 <velocity>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8855C0", Offset = "0x8855C0")]
			private Transform <transform>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8855D0", Offset = "0x8855D0")]
			private float <IKOffset>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			public bool isGrounded
			{
				[Address(RVA = "0x10DDD1C", Offset = "0x10DDD1C", VA = "0x10DDD1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BFAC", Offset = "0x88BFAC")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0x10DE244", Offset = "0x10DE244", VA = "0x10DE244")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BFBC", Offset = "0x88BFBC")]
				private set
				{
				}
			}

			public Vector3 IKPosition
			{
				[Address(RVA = "0x10D3A20", Offset = "0x10D3A20", VA = "0x10D3A20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BFCC", Offset = "0x88BFCC")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x10DE250", Offset = "0x10DE250", VA = "0x10DE250")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BFDC", Offset = "0x88BFDC")]
				private set
				{
				}
			}

			public bool initiated
			{
				[Address(RVA = "0x10DE25C", Offset = "0x10DE25C", VA = "0x10DE25C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BFEC", Offset = "0x88BFEC")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0x10DE264", Offset = "0x10DE264", VA = "0x10DE264")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BFFC", Offset = "0x88BFFC")]
				private set
				{
				}
			}

			public float heightFromGround
			{
				[Address(RVA = "0x10DE270", Offset = "0x10DE270", VA = "0x10DE270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C00C", Offset = "0x88C00C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x10DE278", Offset = "0x10DE278", VA = "0x10DE278")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C01C", Offset = "0x88C01C")]
				private set
				{
				}
			}

			public Vector3 velocity
			{
				[Address(RVA = "0x10DE280", Offset = "0x10DE280", VA = "0x10DE280")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C02C", Offset = "0x88C02C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x10DE28C", Offset = "0x10DE28C", VA = "0x10DE28C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C03C", Offset = "0x88C03C")]
				private set
				{
				}
			}

			public Transform transform
			{
				[Address(RVA = "0x10D3A2C", Offset = "0x10D3A2C", VA = "0x10D3A2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C04C", Offset = "0x88C04C")]
				get
				{
					return null;
				}
				[Address(RVA = "0x10DE298", Offset = "0x10DE298", VA = "0x10DE298")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C05C", Offset = "0x88C05C")]
				private set
				{
				}
			}

			public float IKOffset
			{
				[Address(RVA = "0x10DDD14", Offset = "0x10DDD14", VA = "0x10DDD14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C06C", Offset = "0x88C06C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x10DE2A0", Offset = "0x10DE2A0", VA = "0x10DE2A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C07C", Offset = "0x88C07C")]
				private set
				{
				}
			}

			public float stepHeightFromGround
			{
				[Address(RVA = "0x10DF1BC", Offset = "0x10DF1BC", VA = "0x10DF1BC")]
				get
				{
					return default(float);
				}
			}

			private float rootYOffset
			{
				[Address(RVA = "0x10DF540", Offset = "0x10DF540", VA = "0x10DF540")]
				get
				{
					return default(float);
				}
			}

			[Address(RVA = "0x10DD228", Offset = "0x10DD228", VA = "0x10DD228")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Address(RVA = "0x10DE2A8", Offset = "0x10DE2A8", VA = "0x10DE2A8")]
			public void OnEnable()
			{
			}

			[Address(RVA = "0x10DDD24", Offset = "0x10DDD24", VA = "0x10DDD24")]
			public void Reset()
			{
			}

			[Address(RVA = "0x10DD328", Offset = "0x10DD328", VA = "0x10DD328")]
			public void Process()
			{
			}

			[Address(RVA = "0x10DEB6C", Offset = "0x10DEB6C", VA = "0x10DEB6C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(RaycastHit);
			}

			[Address(RVA = "0x10DE2FC", Offset = "0x10DE2FC", VA = "0x10DE2FC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(RaycastHit);
			}

			[Address(RVA = "0x10DF380", Offset = "0x10DF380", VA = "0x10DF380")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x10DE7F0", Offset = "0x10DE7F0", VA = "0x10DE7F0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Address(RVA = "0x10DE8F8", Offset = "0x10DE8F8", VA = "0x10DE8F8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Address(RVA = "0x10DF490", Offset = "0x10DF490", VA = "0x10DF490")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Address(RVA = "0x10DF26C", Offset = "0x10DF26C", VA = "0x10DF26C")]
			private void RotateFoot()
			{
			}

			[Address(RVA = "0x10DF6AC", Offset = "0x10DF6AC", VA = "0x10DF6AC")]
			private Quaternion GetRotationOffsetTarget()
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}

			[Address(RVA = "0x10DD180", Offset = "0x10DD180", VA = "0x10DD180")]
			public Leg()
			{
			}
		}

		public class Pelvis
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8855E0", Offset = "0x8855E0")]
			private Vector3 <IKOffset>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8855F0", Offset = "0x8855F0")]
			private float <heightOffset>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			public Vector3 IKOffset
			{
				[Address(RVA = "0x16E0D08", Offset = "0x16E0D08", VA = "0x16E0D08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C08C", Offset = "0x88C08C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x16E0D14", Offset = "0x16E0D14", VA = "0x16E0D14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C09C", Offset = "0x88C09C")]
				private set
				{
				}
			}

			public float heightOffset
			{
				[Address(RVA = "0x16E0D20", Offset = "0x16E0D20", VA = "0x16E0D20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C0AC", Offset = "0x88C0AC")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x16E0D28", Offset = "0x16E0D28", VA = "0x16E0D28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C0BC", Offset = "0x88C0BC")]
				private set
				{
				}
			}

			[Address(RVA = "0x16E0D30", Offset = "0x16E0D30", VA = "0x16E0D30")]
			public void Initiate(Grounding grounding)
			{
			}

			[Address(RVA = "0x16E0DC4", Offset = "0x16E0DC4", VA = "0x16E0DC4")]
			public void Reset()
			{
			}

			[Address(RVA = "0x16E0D40", Offset = "0x16E0D40", VA = "0x16E0D40")]
			public void OnEnable()
			{
			}

			[Address(RVA = "0x16E0E98", Offset = "0x16E0E98", VA = "0x16E0E98")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Address(RVA = "0x16E116C", Offset = "0x16E116C", VA = "0x16E116C")]
			public Pelvis()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881ED0", Offset = "0x881ED0")]
		public LayerMask layers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881F08", Offset = "0x881F08")]
		public float maxStep;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881F40", Offset = "0x881F40")]
		public float heightOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881F78", Offset = "0x881F78")]
		public float footSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881FB0", Offset = "0x881FB0")]
		public float footRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x881FE8", Offset = "0x881FE8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x881FE8", Offset = "0x881FE8")]
		public float footCenterOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882034", Offset = "0x882034")]
		public float prediction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88206C", Offset = "0x88206C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88206C", Offset = "0x88206C")]
		public float footRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8820C0", Offset = "0x8820C0")]
		public float footRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8820F8", Offset = "0x8820F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8820F8", Offset = "0x8820F8")]
		public float maxFootRotationAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882150", Offset = "0x882150")]
		public bool rotateSolver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882188", Offset = "0x882188")]
		public float pelvisSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8821C0", Offset = "0x8821C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8821C0", Offset = "0x8821C0")]
		public float pelvisDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882214", Offset = "0x882214")]
		public float lowerPelvisWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88224C", Offset = "0x88224C")]
		public float liftPelvisWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882284", Offset = "0x882284")]
		public float rootSphereCastRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8822BC", Offset = "0x8822BC")]
		public bool overstepFallsDown;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8822F4", Offset = "0x8822F4")]
		public Quality quality;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88232C", Offset = "0x88232C")]
		private Leg[] <legs>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88233C", Offset = "0x88233C")]
		private Pelvis <pelvis>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88234C", Offset = "0x88234C")]
		private bool <isGrounded>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88235C", Offset = "0x88235C")]
		private Transform <root>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88236C", Offset = "0x88236C")]
		private RaycastHit <rootHit>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		public Leg[] legs
		{
			[Address(RVA = "0x10D35B0", Offset = "0x10D35B0", VA = "0x10D35B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A53C", Offset = "0x88A53C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x10DCBF8", Offset = "0x10DCBF8", VA = "0x10DCBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A54C", Offset = "0x88A54C")]
			private set
			{
			}
		}

		public Pelvis pelvis
		{
			[Address(RVA = "0x10D5538", Offset = "0x10D5538", VA = "0x10D5538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A55C", Offset = "0x88A55C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x10DCC00", Offset = "0x10DCC00", VA = "0x10DCC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A56C", Offset = "0x88A56C")]
			private set
			{
			}
		}

		public bool isGrounded
		{
			[Address(RVA = "0x10DCC08", Offset = "0x10DCC08", VA = "0x10DCC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A57C", Offset = "0x88A57C")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x10DCC10", Offset = "0x10DCC10", VA = "0x10DCC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A58C", Offset = "0x88A58C")]
			private set
			{
			}
		}

		public Transform root
		{
			[Address(RVA = "0x10D3A18", Offset = "0x10D3A18", VA = "0x10D3A18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A59C", Offset = "0x88A59C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x10DCC1C", Offset = "0x10DCC1C", VA = "0x10DCC1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A5AC", Offset = "0x88A5AC")]
			private set
			{
			}
		}

		public RaycastHit rootHit
		{
			[Address(RVA = "0x10DA3C0", Offset = "0x10DA3C0", VA = "0x10DA3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A5BC", Offset = "0x88A5BC")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(RaycastHit);
			}
			[Address(RVA = "0x10DCC24", Offset = "0x10DCC24", VA = "0x10DCC24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88A5CC", Offset = "0x88A5CC")]
			private set
			{
			}
		}

		public bool rootGrounded
		{
			[Address(RVA = "0x10DCC44", Offset = "0x10DCC44", VA = "0x10DCC44")]
			get
			{
				return default(bool);
			}
		}

		public Vector3 up
		{
			[Address(RVA = "0x10D5698", Offset = "0x10D5698", VA = "0x10D5698")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		private bool useRootRotation
		{
			[Address(RVA = "0x10DDDEC", Offset = "0x10DDDEC", VA = "0x10DDDEC")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x10DCC9C", Offset = "0x10DCC9C", VA = "0x10DCC9C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(RaycastHit);
		}

		[Address(RVA = "0x10DD0A4", Offset = "0x10DD0A4", VA = "0x10DD0A4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x10D47B0", Offset = "0x10D47B0", VA = "0x10D47B0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Address(RVA = "0x10D5294", Offset = "0x10D5294", VA = "0x10D5294")]
		public void Update()
		{
		}

		[Address(RVA = "0x10D7828", Offset = "0x10D7828", VA = "0x10D7828")]
		public Vector3 GetLegsPlaneNormal()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10D40C0", Offset = "0x10D40C0", VA = "0x10D40C0")]
		public void Reset()
		{
		}

		[Address(RVA = "0x10DD310", Offset = "0x10DD310", VA = "0x10DD310")]
		public void LogWarning(string message)
		{
		}

		[Address(RVA = "0x10DDEC4", Offset = "0x10DDEC4", VA = "0x10DDEC4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Address(RVA = "0x10DE034", Offset = "0x10DE034", VA = "0x10DE034")]
		public Vector3 Flatten(Vector3 v)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10DE140", Offset = "0x10DE140", VA = "0x10DE140")]
		public Vector3 GetFootCenterOffset()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10D3AF8", Offset = "0x10D3AF8", VA = "0x10D3AF8")]
		public Grounding()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D60C", Offset = "0x87D60C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D60C", Offset = "0x87D60C")]
	public class AimIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Address(RVA = "0x10C2660", Offset = "0x10C2660", VA = "0x10C2660", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A5DC", Offset = "0x88A5DC")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10C26AC", Offset = "0x10C26AC", VA = "0x10C26AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A614", Offset = "0x88A614")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10C26F8", Offset = "0x10C26F8", VA = "0x10C26F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A64C", Offset = "0x88A64C")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0x10C2744", Offset = "0x10C2744", VA = "0x10C2744")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A684", Offset = "0x88A684")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10C2790", Offset = "0x10C2790", VA = "0x10C2790")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A6BC", Offset = "0x88A6BC")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10C27DC", Offset = "0x10C27DC", VA = "0x10C27DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x10C27E4", Offset = "0x10C27E4", VA = "0x10C27E4")]
		public AimIK()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D66C", Offset = "0x87D66C")]
	public class ArmIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Address(RVA = "0x10C34B4", Offset = "0x10C34B4", VA = "0x10C34B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A6F4", Offset = "0x88A6F4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10C3520", Offset = "0x10C3520", VA = "0x10C3520", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A72C", Offset = "0x88A72C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10C358C", Offset = "0x10C358C", VA = "0x10C358C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A764", Offset = "0x88A764")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10C35D8", Offset = "0x10C35D8", VA = "0x10C35D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A79C", Offset = "0x88A79C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10C3624", Offset = "0x10C3624", VA = "0x10C3624", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x10C362C", Offset = "0x10C362C", VA = "0x10C362C")]
		public ArmIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D6A4", Offset = "0x87D6A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D6A4", Offset = "0x87D6A4")]
	public class CCDIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Address(RVA = "0x10C5500", Offset = "0x10C5500", VA = "0x10C5500", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A7D4", Offset = "0x88A7D4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10C554C", Offset = "0x10C554C", VA = "0x10C554C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A80C", Offset = "0x88A80C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10C5598", Offset = "0x10C5598", VA = "0x10C5598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A844", Offset = "0x88A844")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10C55E4", Offset = "0x10C55E4", VA = "0x10C55E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A87C", Offset = "0x88A87C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10C5630", Offset = "0x10C5630", VA = "0x10C5630", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x10C5638", Offset = "0x10C5638", VA = "0x10C5638")]
		public CCDIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D704", Offset = "0x87D704")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D704", Offset = "0x87D704")]
	public class FABRIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Address(RVA = "0x10C60EC", Offset = "0x10C60EC", VA = "0x10C60EC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A8B4", Offset = "0x88A8B4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10C6138", Offset = "0x10C6138", VA = "0x10C6138", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A8EC", Offset = "0x88A8EC")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10C6184", Offset = "0x10C6184", VA = "0x10C6184")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A924", Offset = "0x88A924")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10C61D0", Offset = "0x10C61D0", VA = "0x10C61D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A95C", Offset = "0x88A95C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10C621C", Offset = "0x10C621C", VA = "0x10C621C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x10C6224", Offset = "0x10C6224", VA = "0x10C6224")]
		public FABRIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D764", Offset = "0x87D764")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D764", Offset = "0x87D764")]
	public class FABRIKRoot : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Address(RVA = "0x10C6B88", Offset = "0x10C6B88", VA = "0x10C6B88", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A994", Offset = "0x88A994")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10C6BD4", Offset = "0x10C6BD4", VA = "0x10C6BD4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88A9CC", Offset = "0x88A9CC")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10C6C20", Offset = "0x10C6C20", VA = "0x10C6C20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AA04", Offset = "0x88AA04")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10C6C6C", Offset = "0x10C6C6C", VA = "0x10C6C6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AA3C", Offset = "0x88AA3C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10C6CB8", Offset = "0x10C6CB8", VA = "0x10C6CB8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x10C6CC0", Offset = "0x10C6CC0", VA = "0x10C6CC0")]
		public FABRIKRoot()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D7C4", Offset = "0x87D7C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D7C4", Offset = "0x87D7C4")]
	public class FullBodyBipedIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Address(RVA = "0x10D20CC", Offset = "0x10D20CC", VA = "0x10D20CC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AA74", Offset = "0x88AA74")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x10D2118", Offset = "0x10D2118", VA = "0x10D2118", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AAAC", Offset = "0x88AAAC")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x10D2164", Offset = "0x10D2164", VA = "0x10D2164")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AAE4", Offset = "0x88AAE4")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0x10D21B0", Offset = "0x10D21B0", VA = "0x10D21B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AB1C", Offset = "0x88AB1C")]
		private void OpenInspectorTutorial()
		{
		}

		[Address(RVA = "0x10D21FC", Offset = "0x10D21FC", VA = "0x10D21FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AB54", Offset = "0x88AB54")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x10D2248", Offset = "0x10D2248", VA = "0x10D2248")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AB8C", Offset = "0x88AB8C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x10D2294", Offset = "0x10D2294", VA = "0x10D2294")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Address(RVA = "0x10D22E0", Offset = "0x10D22E0", VA = "0x10D22E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x10D22E8", Offset = "0x10D22E8", VA = "0x10D22E8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x10D250C", Offset = "0x10D250C", VA = "0x10D250C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0x10D28FC", Offset = "0x10D28FC", VA = "0x10D28FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88ABC4", Offset = "0x88ABC4")]
		private void Reinitiate()
		{
		}

		[Address(RVA = "0x10D293C", Offset = "0x10D293C", VA = "0x10D293C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88ABFC", Offset = "0x88ABFC")]
		private void AutoDetectReferences()
		{
		}

		[Address(RVA = "0x10D2A50", Offset = "0x10D2A50", VA = "0x10D2A50")]
		public FullBodyBipedIK()
		{
		}
	}
	public abstract class IK : SolverManager
	{
		public abstract IKSolver GetIKSolver();

		[Address(RVA = "0x16E471C", Offset = "0x16E471C", VA = "0x16E471C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0x16E4828", Offset = "0x16E4828", VA = "0x16E4828", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0x16E49F4", Offset = "0x16E49F4", VA = "0x16E49F4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();

		[Address(RVA = "0x16E4A64", Offset = "0x16E4A64", VA = "0x16E4A64")]
		protected IK()
		{
		}
	}
	public class IKExecutionOrder : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88237C", Offset = "0x88237C")]
		public IK[] IKComponents;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8823B4", Offset = "0x8823B4")]
		public Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		private bool animatePhysics
		{
			[Address(RVA = "0x16E82F8", Offset = "0x16E82F8", VA = "0x16E82F8")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x16E839C", Offset = "0x16E839C", VA = "0x16E839C")]
		private void Start()
		{
		}

		[Address(RVA = "0x16E843C", Offset = "0x16E843C", VA = "0x16E843C")]
		private void Update()
		{
		}

		[Address(RVA = "0x16E8574", Offset = "0x16E8574", VA = "0x16E8574")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x16E85B0", Offset = "0x16E85B0", VA = "0x16E85B0")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x16E8470", Offset = "0x16E8470", VA = "0x16E8470")]
		private void FixTransforms()
		{
		}

		[Address(RVA = "0x16E8678", Offset = "0x16E8678", VA = "0x16E8678")]
		public IKExecutionOrder()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D824", Offset = "0x87D824")]
	public class LegIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Address(RVA = "0x134D234", Offset = "0x134D234", VA = "0x134D234", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AC34", Offset = "0x88AC34")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x134D2A0", Offset = "0x134D2A0", VA = "0x134D2A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AC6C", Offset = "0x88AC6C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x134D30C", Offset = "0x134D30C", VA = "0x134D30C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88ACA4", Offset = "0x88ACA4")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x134D358", Offset = "0x134D358", VA = "0x134D358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88ACDC", Offset = "0x88ACDC")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x134D3A4", Offset = "0x134D3A4", VA = "0x134D3A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x134D3AC", Offset = "0x134D3AC", VA = "0x134D3AC")]
		public LegIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D85C", Offset = "0x87D85C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D85C", Offset = "0x87D85C")]
	public class LimbIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Address(RVA = "0x134D414", Offset = "0x134D414", VA = "0x134D414", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AD14", Offset = "0x88AD14")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x134D460", Offset = "0x134D460", VA = "0x134D460", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AD4C", Offset = "0x88AD4C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x134D4AC", Offset = "0x134D4AC", VA = "0x134D4AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AD84", Offset = "0x88AD84")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x134D4F8", Offset = "0x134D4F8", VA = "0x134D4F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88ADBC", Offset = "0x88ADBC")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x134D544", Offset = "0x134D544", VA = "0x134D544", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x134D54C", Offset = "0x134D54C", VA = "0x134D54C")]
		public LimbIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D8BC", Offset = "0x87D8BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D8BC", Offset = "0x87D8BC")]
	public class LookAtIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Address(RVA = "0x134E694", Offset = "0x134E694", VA = "0x134E694", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88ADF4", Offset = "0x88ADF4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x134E6E0", Offset = "0x134E6E0", VA = "0x134E6E0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AE2C", Offset = "0x88AE2C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x134E72C", Offset = "0x134E72C", VA = "0x134E72C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AE64", Offset = "0x88AE64")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x134E778", Offset = "0x134E778", VA = "0x134E778")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AE9C", Offset = "0x88AE9C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x134E7C4", Offset = "0x134E7C4", VA = "0x134E7C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x134E7CC", Offset = "0x134E7CC", VA = "0x134E7CC")]
		public LookAtIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D91C", Offset = "0x87D91C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D91C", Offset = "0x87D91C")]
	public class TrigonometricIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Address(RVA = "0x135876C", Offset = "0x135876C", VA = "0x135876C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AED4", Offset = "0x88AED4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x13587B8", Offset = "0x13587B8", VA = "0x13587B8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AF0C", Offset = "0x88AF0C")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1358804", Offset = "0x1358804", VA = "0x1358804")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AF44", Offset = "0x88AF44")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x1358850", Offset = "0x1358850", VA = "0x1358850")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AF7C", Offset = "0x88AF7C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x135889C", Offset = "0x135889C", VA = "0x135889C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x13588A4", Offset = "0x13588A4", VA = "0x13588A4")]
		public TrigonometricIK()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D97C", Offset = "0x87D97C")]
	public class VRIK : IK
	{
		[Serializable]
		public class References
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885600", Offset = "0x885600")]
			public Transform chest;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885638", Offset = "0x885638")]
			public Transform neck;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885670", Offset = "0x885670")]
			public Transform leftShoulder;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8856A8", Offset = "0x8856A8")]
			public Transform rightShoulder;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8856E0", Offset = "0x8856E0")]
			public Transform leftThigh;

			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885718", Offset = "0x885718")]
			public Transform leftCalf;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885750", Offset = "0x885750")]
			public Transform leftFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885788", Offset = "0x885788")]
			public Transform leftToes;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8857C0", Offset = "0x8857C0")]
			public Transform rightThigh;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8857F8", Offset = "0x8857F8")]
			public Transform rightCalf;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885830", Offset = "0x885830")]
			public Transform rightFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885868", Offset = "0x885868")]
			public Transform rightToes;

			public bool isFilled
			{
				[Address(RVA = "0x135A1F4", Offset = "0x135A1F4", VA = "0x135A1F4")]
				get
				{
					return default(bool);
				}
			}

			public bool isEmpty
			{
				[Address(RVA = "0x1359D78", Offset = "0x1359D78", VA = "0x1359D78")]
				get
				{
					return default(bool);
				}
			}

			[Address(RVA = "0x135A898", Offset = "0x135A898", VA = "0x135A898")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Address(RVA = "0x1359720", Offset = "0x1359720", VA = "0x1359720")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Address(RVA = "0x135A890", Offset = "0x135A890", VA = "0x135A890")]
			public References()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x8823EC", Offset = "0x8823EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8823EC", Offset = "0x8823EC")]
		public References references;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882468", Offset = "0x882468")]
		public IKSolverVR solver;

		[Address(RVA = "0x13595D4", Offset = "0x13595D4", VA = "0x13595D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AFB4", Offset = "0x88AFB4")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x1359640", Offset = "0x1359640", VA = "0x1359640", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88AFEC", Offset = "0x88AFEC")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x13596AC", Offset = "0x13596AC", VA = "0x13596AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B024", Offset = "0x88B024")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0x13596F8", Offset = "0x13596F8", VA = "0x13596F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B05C", Offset = "0x88B05C")]
		public void AutoDetectReferences()
		{
		}

		[Address(RVA = "0x1359C9C", Offset = "0x1359C9C", VA = "0x1359C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B094", Offset = "0x88B094")]
		public void GuessHandOrientations()
		{
		}

		[Address(RVA = "0x1359CD4", Offset = "0x1359CD4", VA = "0x1359CD4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x1359CDC", Offset = "0x1359CDC", VA = "0x1359CDC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0x135A678", Offset = "0x135A678", VA = "0x135A678", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0x135A808", Offset = "0x135A808", VA = "0x135A808")]
		public VRIK()
		{
		}
	}
	[Serializable]
	public class FABRIKChain
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8824A0", Offset = "0x8824A0")]
		public float pull;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8824B8", Offset = "0x8824B8")]
		public float pin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Address(RVA = "0x10C628C", Offset = "0x10C628C", VA = "0x10C628C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x10C6364", Offset = "0x10C6364", VA = "0x10C6364")]
		public void Initiate()
		{
		}

		[Address(RVA = "0x10C6398", Offset = "0x10C6398", VA = "0x10C6398")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Address(RVA = "0x10C6918", Offset = "0x10C6918", VA = "0x10C6918")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Address(RVA = "0x10C6520", Offset = "0x10C6520", VA = "0x10C6520")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10C6B20", Offset = "0x10C6B20", VA = "0x10C6B20")]
		public FABRIKChain()
		{
		}
	}
	public class FBBIKArmBending : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Address(RVA = "0x10C6D28", Offset = "0x10C6D28", VA = "0x10C6D28")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x10C7498", Offset = "0x10C7498", VA = "0x10C7498")]
		private void OnPostFBBIK()
		{
		}

		[Address(RVA = "0x10C776C", Offset = "0x10C776C", VA = "0x10C776C")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10C78CC", Offset = "0x10C78CC", VA = "0x10C78CC")]
		public FBBIKArmBending()
		{
		}
	}
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		public class BendBone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8858A0", Offset = "0x8858A0")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8858D8", Offset = "0x8858D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8858D8", Offset = "0x8858D8")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Address(RVA = "0x10CBCB0", Offset = "0x10CBCB0", VA = "0x10CBCB0")]
			public BendBone()
			{
			}

			[Address(RVA = "0x10CBD30", Offset = "0x10CBD30", VA = "0x10CBD30")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Address(RVA = "0x10C8554", Offset = "0x10C8554", VA = "0x10C8554")]
			public void StoreDefaultLocalState()
			{
			}

			[Address(RVA = "0x10C8BA0", Offset = "0x10C8BA0", VA = "0x10C8BA0")]
			public void FixTransforms()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8824D0", Offset = "0x8824D0")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x882508", Offset = "0x882508")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882508", Offset = "0x882508")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882508", Offset = "0x882508")]
		public float positionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882580", Offset = "0x882580")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882580", Offset = "0x882580")]
		public float bodyWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8825D4", Offset = "0x8825D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8825D4", Offset = "0x8825D4")]
		public float thighWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882628", Offset = "0x882628")]
		public bool handsPullBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x882660", Offset = "0x882660")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882660", Offset = "0x882660")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882660", Offset = "0x882660")]
		public float rotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8826D8", Offset = "0x8826D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8826D8", Offset = "0x8826D8")]
		public float bodyClampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88272C", Offset = "0x88272C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88272C", Offset = "0x88272C")]
		public float headClampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882780", Offset = "0x882780")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882780", Offset = "0x882780")]
		public float bendWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8827D4", Offset = "0x8827D4")]
		public BendBone[] bendBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x88280C", Offset = "0x88280C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88280C", Offset = "0x88280C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88280C", Offset = "0x88280C")]
		public float CCDWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882884", Offset = "0x882884")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882884", Offset = "0x882884")]
		public float roll;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8828D8", Offset = "0x8828D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8828D8", Offset = "0x8828D8")]
		public float damper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882930", Offset = "0x882930")]
		public Transform[] CCDBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x882968", Offset = "0x882968")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882968", Offset = "0x882968")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882968", Offset = "0x882968")]
		public float postStretchWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8829E0", Offset = "0x8829E0")]
		public float maxStretch;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882A18", Offset = "0x882A18")]
		public float stretchDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882A50", Offset = "0x882A50")]
		public bool fixHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882A88", Offset = "0x882A88")]
		public Transform[] stretchBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x882AC0", Offset = "0x882AC0")]
		public Vector3 chestDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882AF8", Offset = "0x882AF8")]
		public float chestDirectionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Address(RVA = "0x10C78D4", Offset = "0x10C78D4", VA = "0x10C78D4")]
		private void Start()
		{
		}

		[Address(RVA = "0x10C7E5C", Offset = "0x10C7E5C", VA = "0x10C7E5C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x10C8594", Offset = "0x10C8594", VA = "0x10C8594")]
		private void OnFixTransforms()
		{
		}

		[Address(RVA = "0x10C8BF8", Offset = "0x10C8BF8", VA = "0x10C8BF8")]
		private void OnPreRead()
		{
		}

		[Address(RVA = "0x10C98AC", Offset = "0x10C98AC", VA = "0x10C98AC")]
		private void SpineBend()
		{
		}

		[Address(RVA = "0x10C9D1C", Offset = "0x10C9D1C", VA = "0x10C9D1C")]
		private void CCDPass()
		{
		}

		[Address(RVA = "0x10CA1FC", Offset = "0x10CA1FC", VA = "0x10CA1FC")]
		private void Iterate(int iteration)
		{
		}

		[Address(RVA = "0x10CAF44", Offset = "0x10CAF44", VA = "0x10CAF44")]
		private void OnPostUpdate()
		{
		}

		[Address(RVA = "0x10C9520", Offset = "0x10C9520", VA = "0x10C9520")]
		private void ChestDirection()
		{
		}

		[Address(RVA = "0x10CB22C", Offset = "0x10CB22C", VA = "0x10CB22C")]
		private void PostStretching()
		{
		}

		[Address(RVA = "0x10CADC4", Offset = "0x10CADC4", VA = "0x10CADC4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Address(RVA = "0x10CAC28", Offset = "0x10CAC28", VA = "0x10CAC28")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Address(RVA = "0x10CB690", Offset = "0x10CB690", VA = "0x10CB690")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x10CBB30", Offset = "0x10CBB30", VA = "0x10CBB30")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	public class FBIKChain
	{
		[Serializable]
		public class ChildConstraint
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88594C", Offset = "0x88594C")]
			private float <nominalDistance>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88595C", Offset = "0x88595C")]
			private bool <isRigid>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			public float nominalDistance
			{
				[Address(RVA = "0x10D04AC", Offset = "0x10D04AC", VA = "0x10D04AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C0CC", Offset = "0x88C0CC")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x10D04B4", Offset = "0x10D04B4", VA = "0x10D04B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C0DC", Offset = "0x88C0DC")]
				private set
				{
				}
			}

			public bool isRigid
			{
				[Address(RVA = "0x10D04BC", Offset = "0x10D04BC", VA = "0x10D04BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C0EC", Offset = "0x88C0EC")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0x10D04C4", Offset = "0x10D04C4", VA = "0x10D04C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C0FC", Offset = "0x88C0FC")]
				private set
				{
				}
			}

			[Address(RVA = "0x10D04D0", Offset = "0x10D04D0", VA = "0x10D04D0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Address(RVA = "0x10CCF38", Offset = "0x10CCF38", VA = "0x10CCF38")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0x10CD8BC", Offset = "0x10CD8BC", VA = "0x10CD8BC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0x10D0060", Offset = "0x10D0060", VA = "0x10D0060")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		public enum Smoothing
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			None,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Exponential,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Cubic
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882B10", Offset = "0x882B10")]
		public float pin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882B28", Offset = "0x882B28")]
		public float pull;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882B40", Offset = "0x882B40")]
		public float push;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882B58", Offset = "0x882B58")]
		public float pushParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882B70", Offset = "0x882B70")]
		public float reach;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const float maxLimbLength = 0.99999f;

		[Address(RVA = "0x10CBDD4", Offset = "0x10CBDD4", VA = "0x10CBDD4")]
		public FBIKChain()
		{
		}

		[Address(RVA = "0x10CBEA0", Offset = "0x10CBEA0", VA = "0x10CBEA0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Address(RVA = "0x10CBFAC", Offset = "0x10CBFAC", VA = "0x10CBFAC")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Address(RVA = "0x10CC0FC", Offset = "0x10CC0FC", VA = "0x10CC0FC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Address(RVA = "0x10CC1FC", Offset = "0x10CC1FC", VA = "0x10CC1FC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x10CC31C", Offset = "0x10CC31C", VA = "0x10CC31C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x10CCFB0", Offset = "0x10CCFB0", VA = "0x10CCFB0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Address(RVA = "0x10CC5B0", Offset = "0x10CC5B0", VA = "0x10CC5B0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x10CDB9C", Offset = "0x10CDB9C", VA = "0x10CDB9C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x10CE074", Offset = "0x10CE074", VA = "0x10CE074")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10CE5A4", Offset = "0x10CE5A4", VA = "0x10CE5A4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Address(RVA = "0x10CECB8", Offset = "0x10CECB8", VA = "0x10CECB8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x10CF7A8", Offset = "0x10CF7A8", VA = "0x10CF7A8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Address(RVA = "0x10CFC58", Offset = "0x10CFC58", VA = "0x10CFC58")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x10CF6A0", Offset = "0x10CF6A0", VA = "0x10CF6A0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10CEAA0", Offset = "0x10CEAA0", VA = "0x10CEAA0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x10CF5F8", Offset = "0x10CF5F8", VA = "0x10CF5F8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x10CFE7C", Offset = "0x10CFE7C", VA = "0x10CFE7C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Address(RVA = "0x10CF3B0", Offset = "0x10CF3B0", VA = "0x10CF3B0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x10CF9CC", Offset = "0x10CF9CC", VA = "0x10CF9CC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	public class IKConstraintBend
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882B88", Offset = "0x882B88")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x882BA0", Offset = "0x882BA0")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		public bool initiated
		{
			[Address(RVA = "0x16E4C4C", Offset = "0x16E4C4C", VA = "0x16E4C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B0CC", Offset = "0x88B0CC")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x16E4C54", Offset = "0x16E4C54", VA = "0x16E4C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B0DC", Offset = "0x88B0DC")]
			private set
			{
			}
		}

		[Address(RVA = "0x16E4A6C", Offset = "0x16E4A6C", VA = "0x16E4A6C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Address(RVA = "0x16E4C60", Offset = "0x16E4C60", VA = "0x16E4C60")]
		public IKConstraintBend()
		{
		}

		[Address(RVA = "0x16E4CE4", Offset = "0x16E4CE4", VA = "0x16E4CE4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Address(RVA = "0x16E4D90", Offset = "0x16E4D90", VA = "0x16E4D90")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Address(RVA = "0x16E4D9C", Offset = "0x16E4D9C", VA = "0x16E4D9C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16E5404", Offset = "0x16E5404", VA = "0x16E5404")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Address(RVA = "0x16E563C", Offset = "0x16E563C", VA = "0x16E563C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Address(RVA = "0x16E5BB4", Offset = "0x16E5BB4", VA = "0x16E5BB4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16E5174", Offset = "0x16E5174", VA = "0x16E5174")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16E52BC", Offset = "0x16E52BC", VA = "0x16E52BC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}
	[Serializable]
	public class IKEffector
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882BB0", Offset = "0x882BB0")]
		public float positionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882BC8", Offset = "0x882BC8")]
		public float rotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x882BE0", Offset = "0x882BE0")]
		private bool <isEndEffector>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882BF0", Offset = "0x882BF0")]
		public float maintainRelativePositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		public bool isEndEffector
		{
			[Address(RVA = "0x16E6368", Offset = "0x16E6368", VA = "0x16E6368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B0EC", Offset = "0x88B0EC")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x16E6370", Offset = "0x16E6370", VA = "0x16E6370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B0FC", Offset = "0x88B0FC")]
			private set
			{
			}
		}

		[Address(RVA = "0x16E62B8", Offset = "0x16E62B8", VA = "0x16E62B8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Address(RVA = "0x16E637C", Offset = "0x16E637C", VA = "0x16E637C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Address(RVA = "0x16E6464", Offset = "0x16E6464", VA = "0x16E6464")]
		public IKEffector()
		{
		}

		[Address(RVA = "0x16E65A0", Offset = "0x16E65A0", VA = "0x16E65A0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Address(RVA = "0x16E66F8", Offset = "0x16E66F8", VA = "0x16E66F8")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16E6A50", Offset = "0x16E6A50", VA = "0x16E6A50")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16E6DEC", Offset = "0x16E6DEC", VA = "0x16E6DEC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16E6FC0", Offset = "0x16E6FC0", VA = "0x16E6FC0")]
		public void SetToTarget()
		{
		}

		[Address(RVA = "0x16E7080", Offset = "0x16E7080", VA = "0x16E7080")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16E7870", Offset = "0x16E7870", VA = "0x16E7870")]
		public void OnPostWrite()
		{
		}

		[Address(RVA = "0x16E78E0", Offset = "0x16E78E0", VA = "0x16E78E0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x16E7B40", Offset = "0x16E7B40", VA = "0x16E7B40")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16E7F9C", Offset = "0x16E7F9C", VA = "0x16E7F9C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}
	[Serializable]
	public class IKMapping
	{
		[Serializable]
		public class BoneMap
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			public Vector3 swingDirection
			{
				[Address(RVA = "0x16E8924", Offset = "0x16E8924", VA = "0x16E8924")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public bool isNodeBone
			{
				[Address(RVA = "0x16E8AEC", Offset = "0x16E8AEC", VA = "0x16E8AEC")]
				get
				{
					return default(bool);
				}
			}

			private Quaternion lastAnimatedTargetRotation
			{
				[Address(RVA = "0x16E9190", Offset = "0x16E9190", VA = "0x16E9190")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
			}

			[Address(RVA = "0x16E88D4", Offset = "0x16E88D4", VA = "0x16E88D4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0x16E89F8", Offset = "0x16E89F8", VA = "0x16E89F8")]
			public void StoreDefaultLocalState()
			{
			}

			[Address(RVA = "0x16E8A5C", Offset = "0x16E8A5C", VA = "0x16E8A5C")]
			public void FixTransform(bool position)
			{
			}

			[Address(RVA = "0x16E8AFC", Offset = "0x16E8AFC", VA = "0x16E8AFC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Address(RVA = "0x16E8C00", Offset = "0x16E8C00", VA = "0x16E8C00")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Address(RVA = "0x16E8C08", Offset = "0x16E8C08", VA = "0x16E8C08")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Address(RVA = "0x16E8DC0", Offset = "0x16E8DC0", VA = "0x16E8DC0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Address(RVA = "0x16E8ED4", Offset = "0x16E8ED4", VA = "0x16E8ED4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Address(RVA = "0x16E8FC0", Offset = "0x16E8FC0", VA = "0x16E8FC0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Address(RVA = "0x16E9404", Offset = "0x16E9404", VA = "0x16E9404")]
			public void SetIKPosition()
			{
			}

			[Address(RVA = "0x16E9444", Offset = "0x16E9444", VA = "0x16E9444")]
			public void MaintainRotation()
			{
			}

			[Address(RVA = "0x16E9484", Offset = "0x16E9484", VA = "0x16E9484")]
			public void SetToIKPosition()
			{
			}

			[Address(RVA = "0x16E94D8", Offset = "0x16E94D8", VA = "0x16E94D8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Address(RVA = "0x16E9648", Offset = "0x16E9648", VA = "0x16E9648")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x16E99F8", Offset = "0x16E99F8", VA = "0x16E99F8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0x16E9A54", Offset = "0x16E9A54", VA = "0x16E9A54")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Address(RVA = "0x16E9C24", Offset = "0x16E9C24", VA = "0x16E9C24")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Address(RVA = "0x16E9C9C", Offset = "0x16E9C9C", VA = "0x16E9C9C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Address(RVA = "0x16E9F38", Offset = "0x16E9F38", VA = "0x16E9F38")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Address(RVA = "0x16EA1B8", Offset = "0x16EA1B8", VA = "0x16EA1B8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Address(RVA = "0x16EA300", Offset = "0x16EA300", VA = "0x16EA300")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Address(RVA = "0x16E97A8", Offset = "0x16E97A8", VA = "0x16E97A8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}

			[Address(RVA = "0x16EA514", Offset = "0x16EA514", VA = "0x16EA514")]
			public BoneMap()
			{
			}
		}

		[Address(RVA = "0x16E8680", Offset = "0x16E8680", VA = "0x16E8680", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16E8688", Offset = "0x16E8688", VA = "0x16E8688", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16E868C", Offset = "0x16E868C", VA = "0x16E868C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Address(RVA = "0x16E87C4", Offset = "0x16E87C4", VA = "0x16E87C4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16E88CC", Offset = "0x16E88CC", VA = "0x16E88CC")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882C08", Offset = "0x882C08")]
		public float maintainRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Address(RVA = "0x16EA52C", Offset = "0x16EA52C", VA = "0x16EA52C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16EA5CC", Offset = "0x16EA5CC", VA = "0x16EA5CC")]
		public IKMappingBone()
		{
		}

		[Address(RVA = "0x16EA650", Offset = "0x16EA650", VA = "0x16EA650")]
		public IKMappingBone(Transform bone)
		{
		}

		[Address(RVA = "0x16EA6E8", Offset = "0x16EA6E8", VA = "0x16EA6E8")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x16EA714", Offset = "0x16EA714", VA = "0x16EA714")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0x16EA744", Offset = "0x16EA744", VA = "0x16EA744", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16EA7F0", Offset = "0x16EA7F0", VA = "0x16EA7F0")]
		public void ReadPose()
		{
		}

		[Address(RVA = "0x16EA81C", Offset = "0x16EA81C", VA = "0x16EA81C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		public enum BoneMapType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Parent,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Bone1,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Bone2,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Bone3
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882C20", Offset = "0x882C20")]
		public float maintainRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882C38", Offset = "0x882C38")]
		public float weight;

		[NonSerialized]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Address(RVA = "0x16EA85C", Offset = "0x16EA85C", VA = "0x16EA85C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16EA8E0", Offset = "0x16EA8E0", VA = "0x16EA8E0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Address(RVA = "0x16EA9B4", Offset = "0x16EA9B4", VA = "0x16EA9B4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Address(RVA = "0x16EAD84", Offset = "0x16EAD84", VA = "0x16EAD84")]
		public IKMappingLimb()
		{
		}

		[Address(RVA = "0x16EAE8C", Offset = "0x16EAE8C", VA = "0x16EAE8C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Address(RVA = "0x16EAFC0", Offset = "0x16EAFC0", VA = "0x16EAFC0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Address(RVA = "0x16EAFCC", Offset = "0x16EAFCC", VA = "0x16EAFCC")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x16EB0A0", Offset = "0x16EB0A0", VA = "0x16EB0A0")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0x16EB184", Offset = "0x16EB184", VA = "0x16EB184", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16EB4A0", Offset = "0x16EB4A0", VA = "0x16EB4A0")]
		public void ReadPose()
		{
		}

		[Address(RVA = "0x16EB590", Offset = "0x16EB590", VA = "0x16EB590")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882C50", Offset = "0x882C50")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882C68", Offset = "0x882C68")]
		public float twistWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Address(RVA = "0x16EB7BC", Offset = "0x16EB7BC", VA = "0x16EB7BC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16EBAE0", Offset = "0x16EBAE0", VA = "0x16EBAE0")]
		public IKMappingSpine()
		{
		}

		[Address(RVA = "0x16EBBFC", Offset = "0x16EBBFC", VA = "0x16EBBFC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Address(RVA = "0x16EBD4C", Offset = "0x16EBD4C", VA = "0x16EBD4C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Address(RVA = "0x16EBD5C", Offset = "0x16EBD5C", VA = "0x16EBD5C")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x16EBDF4", Offset = "0x16EBDF4", VA = "0x16EBDF4")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0x16EBEC4", Offset = "0x16EBEC4", VA = "0x16EBEC4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16EC8E8", Offset = "0x16EC8E8", VA = "0x16EC8E8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Address(RVA = "0x16EC934", Offset = "0x16EC934", VA = "0x16EC934")]
		public void ReadPose()
		{
		}

		[Address(RVA = "0x16ECE18", Offset = "0x16ECE18", VA = "0x16ECE18")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0x16ED454", Offset = "0x16ED454", VA = "0x16ED454")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x16ED6B0", Offset = "0x16ED6B0", VA = "0x16ED6B0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x16ED8C4", Offset = "0x16ED8C4", VA = "0x16ED8C4")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	public abstract class IKSolver
	{
		[Serializable]
		public class Point
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88596C", Offset = "0x88596C")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Address(RVA = "0x16EFF68", Offset = "0x16EFF68", VA = "0x16EFF68")]
			public void StoreDefaultLocalState()
			{
			}

			[Address(RVA = "0x16EFFCC", Offset = "0x16EFFCC", VA = "0x16EFFCC")]
			public void FixTransform()
			{
			}

			[Address(RVA = "0x16F019C", Offset = "0x16F019C", VA = "0x16F019C")]
			public void UpdateSolverPosition()
			{
			}

			[Address(RVA = "0x16F01DC", Offset = "0x16F01DC", VA = "0x16F01DC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Address(RVA = "0x16F021C", Offset = "0x16F021C", VA = "0x16F021C")]
			public void UpdateSolverState()
			{
			}

			[Address(RVA = "0x16F0280", Offset = "0x16F0280", VA = "0x16F0280")]
			public void UpdateSolverLocalState()
			{
			}

			[Address(RVA = "0x16EF85C", Offset = "0x16EF85C", VA = "0x16EF85C")]
			public Point()
			{
			}
		}

		[Serializable]
		public class Bone : Point
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			public RotationLimit rotationLimit
			{
				[Address(RVA = "0x16EEC50", Offset = "0x16EEC50", VA = "0x16EEC50")]
				get
				{
					return null;
				}
				[Address(RVA = "0x16EED4C", Offset = "0x16EED4C", VA = "0x16EED4C")]
				set
				{
				}
			}

			[Address(RVA = "0x16EEDD4", Offset = "0x16EEDD4", VA = "0x16EEDD4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0x16EF0DC", Offset = "0x16EF0DC", VA = "0x16EF0DC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0x16EF4D4", Offset = "0x16EF4D4", VA = "0x16EF4D4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0x16EF784", Offset = "0x16EF784", VA = "0x16EF784")]
			public void SetToSolverPosition()
			{
			}

			[Address(RVA = "0x16EF7D8", Offset = "0x16EF7D8", VA = "0x16EF7D8")]
			public Bone()
			{
			}

			[Address(RVA = "0x16EF8DC", Offset = "0x16EF8DC", VA = "0x16EF8DC")]
			public Bone(Transform transform)
			{
			}

			[Address(RVA = "0x16EF974", Offset = "0x16EF974", VA = "0x16EF974")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		public class Node : Point
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Address(RVA = "0x16EFF04", Offset = "0x16EFF04", VA = "0x16EFF04")]
			public Node()
			{
			}

			[Address(RVA = "0x16EFF08", Offset = "0x16EFF08", VA = "0x16EFF08")]
			public Node(Transform transform)
			{
			}

			[Address(RVA = "0x16EFF30", Offset = "0x16EFF30", VA = "0x16EFF30")]
			public Node(Transform transform, float weight)
			{
			}
		}

		public delegate void UpdateDelegate();

		public delegate void IterationDelegate(int i);

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x882C80", Offset = "0x882C80")]
		public Vector3 IKPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882C90", Offset = "0x882C90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882C90", Offset = "0x882C90")]
		public float IKPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x882CE4", Offset = "0x882CE4")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x882CF4", Offset = "0x882CF4")]
		protected Transform root;

		public bool initiated
		{
			[Address(RVA = "0x16E47B8", Offset = "0x16E47B8", VA = "0x16E47B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B10C", Offset = "0x88B10C")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x16EE24C", Offset = "0x16EE24C", VA = "0x16EE24C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B11C", Offset = "0x88B11C")]
			private set
			{
			}
		}

		[Address(RVA = "0x16EDDD0", Offset = "0x16EDDD0", VA = "0x16EDDD0")]
		public bool IsValid()
		{
			return default(bool);
		}

		public abstract bool IsValid(ref string message);

		[Address(RVA = "0x16E48A8", Offset = "0x16E48A8", VA = "0x16E48A8")]
		public void Initiate(Transform root)
		{
		}

		[Address(RVA = "0x16E47C0", Offset = "0x16E47C0", VA = "0x16E47C0")]
		public void Update()
		{
		}

		[Address(RVA = "0x16EE258", Offset = "0x16EE258", VA = "0x16EE258", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16EE264", Offset = "0x16EE264", VA = "0x16EE264")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Address(RVA = "0x16EE270", Offset = "0x16EE270", VA = "0x16EE270")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Address(RVA = "0x16EE278", Offset = "0x16EE278", VA = "0x16EE278")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Address(RVA = "0x16E2E14", Offset = "0x16E2E14", VA = "0x16E2E14")]
		public Transform GetRoot()
		{
			return null;
		}

		public abstract Point[] GetPoints();

		public abstract Point GetPoint(Transform transform);

		public abstract void FixTransforms();

		public abstract void StoreDefaultLocalState();

		protected abstract void OnInitiate();

		protected abstract void OnUpdate();

		[Address(RVA = "0x16EE2FC", Offset = "0x16EE2FC", VA = "0x16EE2FC")]
		protected void LogWarning(string message)
		{
		}

		[Address(RVA = "0x16EE314", Offset = "0x16EE314", VA = "0x16EE314")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Address(RVA = "0x16EE490", Offset = "0x16EE490", VA = "0x16EE490")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Address(RVA = "0x16EE564", Offset = "0x16EE564", VA = "0x16EE564")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Address(RVA = "0x16EEC38", Offset = "0x16EEC38", VA = "0x16EEC38")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882D2C", Offset = "0x882D2C")]
		public float poleWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882D44", Offset = "0x882D44")]
		public float clampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882D5C", Offset = "0x882D5C")]
		public int clampSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		public Vector3 transformAxis
		{
			[Address(RVA = "0x16F043C", Offset = "0x16F043C", VA = "0x16F043C")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		public Vector3 transformPoleAxis
		{
			[Address(RVA = "0x16F0510", Offset = "0x16F0510", VA = "0x16F0510")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		protected override int minBones
		{
			[Address(RVA = "0x16F14FC", Offset = "0x16F14FC", VA = "0x16F14FC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		protected override Vector3 localDirection
		{
			[Address(RVA = "0x16F1B8C", Offset = "0x16F1B8C", VA = "0x16F1B8C", Slot = "15")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		[Address(RVA = "0x16F0334", Offset = "0x16F0334", VA = "0x16F0334")]
		public float GetAngle()
		{
			return default(float);
		}

		[Address(RVA = "0x16F05E4", Offset = "0x16F05E4", VA = "0x16F05E4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x16F08EC", Offset = "0x16F08EC", VA = "0x16F08EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16F1320", Offset = "0x16F1320", VA = "0x16F1320")]
		private void Solve()
		{
		}

		[Address(RVA = "0x16F0EF8", Offset = "0x16F0EF8", VA = "0x16F0EF8")]
		private Vector3 GetClampedIKPosition()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16F1504", Offset = "0x16F1504", VA = "0x16F1504")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Address(RVA = "0x16F1C94", Offset = "0x16F1C94", VA = "0x16F1C94")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882D74", Offset = "0x882D74")]
		public float IKRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Address(RVA = "0x16F1DA4", Offset = "0x16F1DA4", VA = "0x16F1DA4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16F223C", Offset = "0x16F223C", VA = "0x16F223C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x16F22FC", Offset = "0x16F22FC", VA = "0x16F22FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x16F24E8", Offset = "0x16F24E8", VA = "0x16F24E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x16F26A4", Offset = "0x16F26A4", VA = "0x16F26A4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x16F271C", Offset = "0x16F271C", VA = "0x16F271C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x16F27A8", Offset = "0x16F27A8", VA = "0x16F27A8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x16F2E30", Offset = "0x16F2E30", VA = "0x16F2E30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16F2E5C", Offset = "0x16F2E5C", VA = "0x16F2E5C")]
		private void Solve()
		{
		}

		[Address(RVA = "0x16F2830", Offset = "0x16F2830", VA = "0x16F2830")]
		private void Read()
		{
		}

		[Address(RVA = "0x16F2F04", Offset = "0x16F2F04", VA = "0x16F2F04")]
		private void Write()
		{
		}

		[Address(RVA = "0x16F3204", Offset = "0x16F3204", VA = "0x16F3204")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Address(RVA = "0x16F3354", Offset = "0x16F3354", VA = "0x16F3354")]
		public void FadeOutBoneWeights()
		{
		}

		[Address(RVA = "0x16F34AC", Offset = "0x16F34AC", VA = "0x16F34AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x16F3D88", Offset = "0x16F3D88", VA = "0x16F3D88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16F4660", Offset = "0x16F4660", VA = "0x16F4660")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0x16F512C", Offset = "0x16F512C", VA = "0x16F512C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		protected override bool boneLengthCanBeZero
		{
			[Address(RVA = "0x16F6B24", Offset = "0x16F6B24", VA = "0x16F6B24", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x16F5130", Offset = "0x16F5130", VA = "0x16F5130")]
		public void SolveForward(Vector3 position)
		{
		}

		[Address(RVA = "0x16F5D48", Offset = "0x16F5D48", VA = "0x16F5D48")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Address(RVA = "0x16F5E80", Offset = "0x16F5E80", VA = "0x16F5E80", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16F5F24", Offset = "0x16F5F24", VA = "0x16F5F24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x16F677C", Offset = "0x16F677C", VA = "0x16F677C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16F6B2C", Offset = "0x16F6B2C", VA = "0x16F6B2C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16F5204", Offset = "0x16F5204", VA = "0x16F5204")]
		private void OnPreSolve()
		{
		}

		[Address(RVA = "0x16F5E2C", Offset = "0x16F5E2C", VA = "0x16F5E2C")]
		private void OnPostSolve()
		{
		}

		[Address(RVA = "0x16F6AAC", Offset = "0x16F6AAC", VA = "0x16F6AAC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0x16F599C", Offset = "0x16F599C", VA = "0x16F599C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x16F77E0", Offset = "0x16F77E0", VA = "0x16F77E0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Address(RVA = "0x16F7908", Offset = "0x16F7908", VA = "0x16F7908")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Address(RVA = "0x16F7AA0", Offset = "0x16F7AA0", VA = "0x16F7AA0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Address(RVA = "0x16F7C38", Offset = "0x16F7C38", VA = "0x16F7C38")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Address(RVA = "0x16F63E4", Offset = "0x16F63E4", VA = "0x16F63E4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x16F65B0", Offset = "0x16F65B0", VA = "0x16F65B0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16F7ED8", Offset = "0x16F7ED8", VA = "0x16F7ED8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x16F7000", Offset = "0x16F7000", VA = "0x16F7000")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Address(RVA = "0x16F5E1C", Offset = "0x16F5E1C", VA = "0x16F5E1C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x16F89E0", Offset = "0x16F89E0", VA = "0x16F89E0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Address(RVA = "0x16F80D0", Offset = "0x16F80D0", VA = "0x16F80D0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Address(RVA = "0x16F6C44", Offset = "0x16F6C44", VA = "0x16F6C44")]
		private void MapToSolverPositions()
		{
		}

		[Address(RVA = "0x16F6E24", Offset = "0x16F6E24", VA = "0x16F6E24")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Address(RVA = "0x16F8BF8", Offset = "0x16F8BF8", VA = "0x16F8BF8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882D8C", Offset = "0x882D8C")]
		public float rootPin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Address(RVA = "0x16F8C6C", Offset = "0x16F8C6C", VA = "0x16F8C6C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16F9BC8", Offset = "0x16F9BC8", VA = "0x16F9BC8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x16F9CAC", Offset = "0x16F9CAC", VA = "0x16F9CAC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x16F9DB4", Offset = "0x16F9DB4", VA = "0x16F9DB4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x16F9F20", Offset = "0x16F9F20", VA = "0x16F9F20")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Address(RVA = "0x16FA078", Offset = "0x16FA078", VA = "0x16FA078", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16FA7D0", Offset = "0x16FA7D0", VA = "0x16FA7D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x16FAA5C", Offset = "0x16FAA5C", VA = "0x16FAA5C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x16FA8A4", Offset = "0x16FA8A4", VA = "0x16FA8A4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Address(RVA = "0x16FA3AC", Offset = "0x16FA3AC", VA = "0x16FA3AC")]
		private Vector3 GetCentroid()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x16FAB34", Offset = "0x16FAB34", VA = "0x16FAB34")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882DA4", Offset = "0x882DA4")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Address(RVA = "0x16FABAC", Offset = "0x16FABAC", VA = "0x16FABAC")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Address(RVA = "0x16FACE0", Offset = "0x16FACE0", VA = "0x16FACE0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x16FAD4C", Offset = "0x16FAD4C", VA = "0x16FAD4C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Address(RVA = "0x16E6214", Offset = "0x16E6214", VA = "0x16E6214")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Address(RVA = "0x16E50D0", Offset = "0x16E50D0", VA = "0x16E50D0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Address(RVA = "0x16FAF00", Offset = "0x16FAF00", VA = "0x16FAF00", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x16FB170", Offset = "0x16FB170", VA = "0x16FB170", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x16FB398", Offset = "0x16FB398", VA = "0x16FB398", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16FB63C", Offset = "0x16FB63C", VA = "0x16FB63C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x16FB778", Offset = "0x16FB778", VA = "0x16FB778", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x16FB8C8", Offset = "0x16FB8C8", VA = "0x16FB8C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x16FBAC8", Offset = "0x16FBAC8", VA = "0x16FBAC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16FBD00", Offset = "0x16FBD00", VA = "0x16FBD00", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Address(RVA = "0x16FC138", Offset = "0x16FC138", VA = "0x16FC138", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Address(RVA = "0x16FC6EC", Offset = "0x16FC6EC", VA = "0x16FC6EC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Address(RVA = "0x16FC750", Offset = "0x16FC750", VA = "0x16FC750", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Address(RVA = "0x16FC8B0", Offset = "0x16FC8B0", VA = "0x16FC8B0")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	public enum FullBodyBipedEffector
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Body,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftShoulder,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightShoulder,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftThigh,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightThigh,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftHand,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightHand,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftFoot,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightFoot
	}
	[Serializable]
	public enum FullBodyBipedChain
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftArm,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightArm,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftLeg,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightLeg
	}
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882DBC", Offset = "0x882DBC")]
		public float spineStiffness;

		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882DD4", Offset = "0x882DD4")]
		public float pullBodyVertical;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882DEC", Offset = "0x882DEC")]
		public float pullBodyHorizontal;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x882E04", Offset = "0x882E04")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		public IKEffector bodyEffector
		{
			[Address(RVA = "0x16FC990", Offset = "0x16FC990", VA = "0x16FC990")]
			get
			{
				return null;
			}
		}

		public IKEffector leftShoulderEffector
		{
			[Address(RVA = "0x16FC998", Offset = "0x16FC998", VA = "0x16FC998")]
			get
			{
				return null;
			}
		}

		public IKEffector rightShoulderEffector
		{
			[Address(RVA = "0x16FC9A0", Offset = "0x16FC9A0", VA = "0x16FC9A0")]
			get
			{
				return null;
			}
		}

		public IKEffector leftThighEffector
		{
			[Address(RVA = "0x16FC9A8", Offset = "0x16FC9A8", VA = "0x16FC9A8")]
			get
			{
				return null;
			}
		}

		public IKEffector rightThighEffector
		{
			[Address(RVA = "0x16FC9B0", Offset = "0x16FC9B0", VA = "0x16FC9B0")]
			get
			{
				return null;
			}
		}

		public IKEffector leftHandEffector
		{
			[Address(RVA = "0x16FC9B8", Offset = "0x16FC9B8", VA = "0x16FC9B8")]
			get
			{
				return null;
			}
		}

		public IKEffector rightHandEffector
		{
			[Address(RVA = "0x16FC9C0", Offset = "0x16FC9C0", VA = "0x16FC9C0")]
			get
			{
				return null;
			}
		}

		public IKEffector leftFootEffector
		{
			[Address(RVA = "0x16FC9C8", Offset = "0x16FC9C8", VA = "0x16FC9C8")]
			get
			{
				return null;
			}
		}

		public IKEffector rightFootEffector
		{
			[Address(RVA = "0x16FC9D0", Offset = "0x16FC9D0", VA = "0x16FC9D0")]
			get
			{
				return null;
			}
		}

		public FBIKChain leftArmChain
		{
			[Address(RVA = "0x16FC9D8", Offset = "0x16FC9D8", VA = "0x16FC9D8")]
			get
			{
				return null;
			}
		}

		public FBIKChain rightArmChain
		{
			[Address(RVA = "0x16FCA20", Offset = "0x16FCA20", VA = "0x16FCA20")]
			get
			{
				return null;
			}
		}

		public FBIKChain leftLegChain
		{
			[Address(RVA = "0x16FCA68", Offset = "0x16FCA68", VA = "0x16FCA68")]
			get
			{
				return null;
			}
		}

		public FBIKChain rightLegChain
		{
			[Address(RVA = "0x16FCAB0", Offset = "0x16FCAB0", VA = "0x16FCAB0")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb leftArmMapping
		{
			[Address(RVA = "0x16FCAF8", Offset = "0x16FCAF8", VA = "0x16FCAF8")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb rightArmMapping
		{
			[Address(RVA = "0x16FCB3C", Offset = "0x16FCB3C", VA = "0x16FCB3C")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb leftLegMapping
		{
			[Address(RVA = "0x16FCB84", Offset = "0x16FCB84", VA = "0x16FCB84")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb rightLegMapping
		{
			[Address(RVA = "0x16FCBCC", Offset = "0x16FCBCC", VA = "0x16FCBCC")]
			get
			{
				return null;
			}
		}

		public IKMappingBone headMapping
		{
			[Address(RVA = "0x16FCC14", Offset = "0x16FCC14", VA = "0x16FCC14")]
			get
			{
				return null;
			}
		}

		public Vector3 pullBodyOffset
		{
			[Address(RVA = "0x16FFB38", Offset = "0x16FFB38", VA = "0x16FFB38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B12C", Offset = "0x88B12C")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x16FFB44", Offset = "0x16FFB44", VA = "0x16FFB44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B13C", Offset = "0x88B13C")]
			private set
			{
			}
		}

		[Address(RVA = "0x16FCC58", Offset = "0x16FCC58", VA = "0x16FCC58")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Address(RVA = "0x16FCDD0", Offset = "0x16FCDD0", VA = "0x16FCDD0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Address(RVA = "0x16FCCC0", Offset = "0x16FCCC0", VA = "0x16FCCC0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Address(RVA = "0x16FCEC0", Offset = "0x16FCEC0", VA = "0x16FCEC0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Address(RVA = "0x16E2F78", Offset = "0x16E2F78", VA = "0x16E2F78")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Address(RVA = "0x16FD000", Offset = "0x16FD000", VA = "0x16FD000")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Address(RVA = "0x16FD110", Offset = "0x16FD110", VA = "0x16FD110")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Address(RVA = "0x16FD21C", Offset = "0x16FD21C", VA = "0x16FD21C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Address(RVA = "0x16FD328", Offset = "0x16FD328", VA = "0x16FD328")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Address(RVA = "0x16FD330", Offset = "0x16FD330", VA = "0x16FD330")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Address(RVA = "0x16FD374", Offset = "0x16FD374", VA = "0x16FD374")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Address(RVA = "0x16FD498", Offset = "0x16FD498", VA = "0x16FD498", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x16FD764", Offset = "0x16FD764", VA = "0x16FD764")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Address(RVA = "0x16FF2A4", Offset = "0x16FF2A4", VA = "0x16FF2A4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Address(RVA = "0x16FF83C", Offset = "0x16FF83C", VA = "0x16FF83C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Address(RVA = "0x16FF8FC", Offset = "0x16FF8FC", VA = "0x16FF8FC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Address(RVA = "0x16FF66C", Offset = "0x16FF66C", VA = "0x16FF66C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Address(RVA = "0x16FF754", Offset = "0x16FF754", VA = "0x16FF754")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Address(RVA = "0x16FFB50", Offset = "0x16FFB50", VA = "0x16FFB50")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Address(RVA = "0x16FFC28", Offset = "0x16FFC28", VA = "0x16FFC28", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Address(RVA = "0x16FFE20", Offset = "0x16FFE20", VA = "0x16FFE20")]
		private void PullBody()
		{
		}

		[Address(RVA = "0x16FFFE0", Offset = "0x16FFFE0", VA = "0x16FFFE0")]
		private Vector3 GetBodyOffset()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17001E8", Offset = "0x17001E8", VA = "0x17001E8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x170045C", Offset = "0x170045C", VA = "0x170045C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Address(RVA = "0x1700970", Offset = "0x1700970", VA = "0x1700970", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Address(RVA = "0x1700AAC", Offset = "0x1700AAC", VA = "0x1700AAC")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		protected virtual int minBones
		{
			[Address(RVA = "0x1701524", Offset = "0x1701524", VA = "0x1701524", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		protected virtual bool boneLengthCanBeZero
		{
			[Address(RVA = "0x170152C", Offset = "0x170152C", VA = "0x170152C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		protected virtual bool allowCommonParent
		{
			[Address(RVA = "0x1701534", Offset = "0x1701534", VA = "0x1701534", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		protected virtual Vector3 localDirection
		{
			[Address(RVA = "0x1701544", Offset = "0x1701544", VA = "0x1701544", Slot = "15")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		protected float positionOffset
		{
			[Address(RVA = "0x16F459C", Offset = "0x16F459C", VA = "0x16F459C")]
			get
			{
				return default(float);
			}
		}

		[Address(RVA = "0x1700AB8", Offset = "0x1700AB8", VA = "0x1700AB8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x1700CC4", Offset = "0x1700CC4", VA = "0x1700CC4")]
		public void AddBone(Transform bone)
		{
		}

		[Address(RVA = "0x1700E90", Offset = "0x1700E90", VA = "0x1700E90", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x1700F28", Offset = "0x1700F28", VA = "0x1700F28", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x1700FD4", Offset = "0x1700FD4", VA = "0x1700FD4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x17013E8", Offset = "0x17013E8", VA = "0x17013E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x17013F0", Offset = "0x17013F0", VA = "0x17013F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x170153C", Offset = "0x170153C", VA = "0x170153C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1701540", Offset = "0x1701540", VA = "0x1701540", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x16F355C", Offset = "0x16F355C", VA = "0x16F355C")]
		protected void InitiateBones()
		{
		}

		[Address(RVA = "0x16F40D8", Offset = "0x16F40D8", VA = "0x16F40D8")]
		protected Vector3 GetSingularityOffset()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x1701724", Offset = "0x1701724", VA = "0x1701724")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Address(RVA = "0x16F1D28", Offset = "0x16F1D28", VA = "0x16F1D28")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882E14", Offset = "0x882E14")]
		public float IKRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Address(RVA = "0x1701A8C", Offset = "0x1701A8C", VA = "0x1701A8C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1701F24", Offset = "0x1701F24", VA = "0x1701F24")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x1701FE4", Offset = "0x1701FE4", VA = "0x1701FE4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x17021D0", Offset = "0x17021D0", VA = "0x17021D0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x170238C", Offset = "0x170238C", VA = "0x170238C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x1702404", Offset = "0x1702404", VA = "0x1702404", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x1702490", Offset = "0x1702490", VA = "0x1702490", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1702B1C", Offset = "0x1702B1C", VA = "0x1702B1C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x1702B48", Offset = "0x1702B48", VA = "0x1702B48")]
		private void Solve()
		{
		}

		[Address(RVA = "0x1702518", Offset = "0x1702518", VA = "0x1702518")]
		private void Read()
		{
		}

		[Address(RVA = "0x1702C84", Offset = "0x1702C84", VA = "0x1702C84")]
		private void Write()
		{
		}

		[Address(RVA = "0x1702F84", Offset = "0x1702F84", VA = "0x1702F84")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		public enum BendModifier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Animation,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Target,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Parent,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Arm,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Goal
		}

		[Serializable]
		public struct AxisDirection
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Address(RVA = "0x967838", Offset = "0x967838", VA = "0x967838")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882E2C", Offset = "0x882E2C")]
		public float maintainRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882E44", Offset = "0x882E44")]
		public float bendModifierWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		private AxisDirection[] axisDirections
		{
			[Address(RVA = "0x1746314", Offset = "0x1746314", VA = "0x1746314")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x17448F0", Offset = "0x17448F0", VA = "0x17448F0")]
		public void MaintainRotation()
		{
		}

		[Address(RVA = "0x1744954", Offset = "0x1744954", VA = "0x1744954")]
		public void MaintainBend()
		{
		}

		[Address(RVA = "0x1744A7C", Offset = "0x1744A7C", VA = "0x1744A7C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Address(RVA = "0x1745200", Offset = "0x1745200", VA = "0x1745200", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Address(RVA = "0x1745F64", Offset = "0x1745F64", VA = "0x1745F64", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Address(RVA = "0x1746108", Offset = "0x1746108", VA = "0x1746108")]
		public IKSolverLimb()
		{
		}

		[Address(RVA = "0x174628C", Offset = "0x174628C", VA = "0x174628C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Address(RVA = "0x1744EBC", Offset = "0x1744EBC", VA = "0x1744EBC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Address(RVA = "0x174533C", Offset = "0x174533C", VA = "0x174533C")]
		private Vector3 GetModifiedBendNormal()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		public class LookAtBone : Bone
		{
			public Vector3 forward
			{
				[Address(RVA = "0x1748888", Offset = "0x1748888", VA = "0x1748888")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			[Address(RVA = "0x174910C", Offset = "0x174910C", VA = "0x174910C")]
			public LookAtBone()
			{
			}

			[Address(RVA = "0x17478F0", Offset = "0x17478F0", VA = "0x17478F0")]
			public LookAtBone(Transform transform)
			{
			}

			[Address(RVA = "0x1747D34", Offset = "0x1747D34", VA = "0x1747D34")]
			public void Initiate(Transform root)
			{
			}

			[Address(RVA = "0x1748D4C", Offset = "0x1748D4C", VA = "0x1748D4C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882E5C", Offset = "0x882E5C")]
		public float bodyWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882E74", Offset = "0x882E74")]
		public float headWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882E8C", Offset = "0x882E8C")]
		public float eyesWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882EA4", Offset = "0x882EA4")]
		public float clampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882EBC", Offset = "0x882EBC")]
		public float clampWeightHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882ED4", Offset = "0x882ED4")]
		public float clampWeightEyes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882EEC", Offset = "0x882EEC")]
		public int clampSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 eyesOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AnimationCurve spineWeightCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] spineForwards;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] headForwards;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] eyeForward;

		private bool spineIsValid
		{
			[Address(RVA = "0x1746DC4", Offset = "0x1746DC4", VA = "0x1746DC4")]
			get
			{
				return default(bool);
			}
		}

		private bool spineIsEmpty
		{
			[Address(RVA = "0x1747064", Offset = "0x1747064", VA = "0x1747064")]
			get
			{
				return default(bool);
			}
		}

		private bool headIsValid
		{
			[Address(RVA = "0x1746F0C", Offset = "0x1746F0C", VA = "0x1746F0C")]
			get
			{
				return default(bool);
			}
		}

		private bool headIsEmpty
		{
			[Address(RVA = "0x1747098", Offset = "0x1747098", VA = "0x1747098")]
			get
			{
				return default(bool);
			}
		}

		private bool eyesIsValid
		{
			[Address(RVA = "0x1746F1C", Offset = "0x1746F1C", VA = "0x1746F1C")]
			get
			{
				return default(bool);
			}
		}

		private bool eyesIsEmpty
		{
			[Address(RVA = "0x1747118", Offset = "0x1747118", VA = "0x1747118")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x1746390", Offset = "0x1746390", VA = "0x1746390")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Address(RVA = "0x1746414", Offset = "0x1746414", VA = "0x1746414")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Address(RVA = "0x17464C0", Offset = "0x17464C0", VA = "0x17464C0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Address(RVA = "0x1746588", Offset = "0x1746588", VA = "0x1746588")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Address(RVA = "0x1746674", Offset = "0x1746674", VA = "0x1746674")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Address(RVA = "0x1746780", Offset = "0x1746780", VA = "0x1746780")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Address(RVA = "0x17468C8", Offset = "0x17468C8", VA = "0x17468C8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x1746A68", Offset = "0x1746A68", VA = "0x1746A68", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x1746C14", Offset = "0x1746C14", VA = "0x1746C14", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x174714C", Offset = "0x174714C", VA = "0x174714C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x174745C", Offset = "0x174745C", VA = "0x174745C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x174761C", Offset = "0x174761C", VA = "0x174761C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x174791C", Offset = "0x174791C", VA = "0x174791C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1747E80", Offset = "0x1747E80", VA = "0x1747E80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x1747F8C", Offset = "0x1747F8C", VA = "0x1747F8C")]
		private void SolveSpine()
		{
		}

		[Address(RVA = "0x1748260", Offset = "0x1748260", VA = "0x1748260")]
		private void SolveHead()
		{
		}

		[Address(RVA = "0x174855C", Offset = "0x174855C", VA = "0x174855C")]
		private void SolveEyes()
		{
		}

		[Address(RVA = "0x174895C", Offset = "0x174895C", VA = "0x174895C")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Address(RVA = "0x17476D0", Offset = "0x17476D0", VA = "0x17476D0")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Address(RVA = "0x1748EE4", Offset = "0x1748EE4", VA = "0x1748EE4")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		public class TrigonometricBone : Bone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Address(RVA = "0x174AB30", Offset = "0x174AB30", VA = "0x174AB30")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Address(RVA = "0x174B9C8", Offset = "0x174B9C8", VA = "0x174B9C8")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}

			[Address(RVA = "0x17449A8", Offset = "0x17449A8", VA = "0x17449A8")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x174BA90", Offset = "0x174BA90", VA = "0x174BA90")]
			public TrigonometricBone()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882F04", Offset = "0x882F04")]
		public float IKRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Address(RVA = "0x1749114", Offset = "0x1749114", VA = "0x1749114")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Address(RVA = "0x1749338", Offset = "0x1749338", VA = "0x1749338")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Address(RVA = "0x1749540", Offset = "0x1749540", VA = "0x1749540")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Address(RVA = "0x174954C", Offset = "0x174954C", VA = "0x174954C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Address(RVA = "0x17495D0", Offset = "0x17495D0", VA = "0x17495D0")]
		public Quaternion GetIKRotation()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x17495DC", Offset = "0x17495DC", VA = "0x17495DC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Address(RVA = "0x17495E4", Offset = "0x17495E4", VA = "0x17495E4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x1749738", Offset = "0x1749738", VA = "0x1749738", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x174986C", Offset = "0x174986C", VA = "0x174986C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x17498D8", Offset = "0x17498D8", VA = "0x17498D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x174995C", Offset = "0x174995C", VA = "0x174995C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1749E4C", Offset = "0x1749E4C", VA = "0x1749E4C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x1749EDC", Offset = "0x1749EDC", VA = "0x1749EDC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Address(RVA = "0x174A568", Offset = "0x174A568", VA = "0x174A568")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x174A780", Offset = "0x174A780", VA = "0x174A780", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x174A9F4", Offset = "0x174A9F4", VA = "0x174A9F4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Address(RVA = "0x174A8DC", Offset = "0x174A8DC", VA = "0x174A8DC")]
		private void InitiateBones()
		{
		}

		[Address(RVA = "0x174ACF0", Offset = "0x174ACF0", VA = "0x174ACF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x174BA84", Offset = "0x174BA84", VA = "0x174BA84", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Address(RVA = "0x174BA88", Offset = "0x174BA88", VA = "0x174BA88", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Address(RVA = "0x174BA8C", Offset = "0x174BA8C", VA = "0x174BA8C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Address(RVA = "0x174B684", Offset = "0x174B684", VA = "0x174B684")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x174617C", Offset = "0x174617C", VA = "0x174617C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		public class Arm : BodyPart
		{
			[Serializable]
			public enum ShoulderRotationMode
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				YawPitch,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				FromTo
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885984", Offset = "0x885984")]
			public Transform target;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8859BC", Offset = "0x8859BC")]
			public Transform bendGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8859F4", Offset = "0x8859F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8859F4", Offset = "0x8859F4")]
			public float positionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885A48", Offset = "0x885A48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885A48", Offset = "0x885A48")]
			public float rotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885A9C", Offset = "0x885A9C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885AD4", Offset = "0x885AD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885AD4", Offset = "0x885AD4")]
			public float shoulderRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885B28", Offset = "0x885B28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885B28", Offset = "0x885B28")]
			public float shoulderTwistWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885B7C", Offset = "0x885B7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885B7C", Offset = "0x885B7C")]
			public float bendGoalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885BD0", Offset = "0x885BD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885BD0", Offset = "0x885BD0")]
			public float swivelOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885C2C", Offset = "0x885C2C")]
			public Vector3 wristToPalmAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885C64", Offset = "0x885C64")]
			public Vector3 palmToThumbAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885C9C", Offset = "0x885C9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885C9C", Offset = "0x885C9C")]
			public float armLengthMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885CF4", Offset = "0x885CF4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x885D2C", Offset = "0x885D2C")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x885D3C", Offset = "0x885D3C")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x885D4C", Offset = "0x885D4C")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x885D5C", Offset = "0x885D5C")]
			public Vector3 handPositionOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885D6C", Offset = "0x885D6C")]
			private Vector3 <position>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885D7C", Offset = "0x885D7C")]
			private Quaternion <rotation>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmTwistAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const float yawOffsetAngle = 45f;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const float pitchOffsetAngle = -30f;

			public Vector3 position
			{
				[Address(RVA = "0x17570B8", Offset = "0x17570B8", VA = "0x17570B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C10C", Offset = "0x88C10C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x17570C4", Offset = "0x17570C4", VA = "0x17570C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C11C", Offset = "0x88C11C")]
				private set
				{
				}
			}

			public Quaternion rotation
			{
				[Address(RVA = "0x17570D0", Offset = "0x17570D0", VA = "0x17570D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C12C", Offset = "0x88C12C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
				[Address(RVA = "0x17570DC", Offset = "0x17570DC", VA = "0x17570DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C13C", Offset = "0x88C13C")]
				private set
				{
				}
			}

			private VirtualBone shoulder
			{
				[Address(RVA = "0x17570E8", Offset = "0x17570E8", VA = "0x17570E8")]
				get
				{
					return null;
				}
			}

			private VirtualBone upperArm
			{
				[Address(RVA = "0x175712C", Offset = "0x175712C", VA = "0x175712C")]
				get
				{
					return null;
				}
			}

			private VirtualBone forearm
			{
				[Address(RVA = "0x175717C", Offset = "0x175717C", VA = "0x175717C")]
				get
				{
					return null;
				}
			}

			private VirtualBone hand
			{
				[Address(RVA = "0x17571D8", Offset = "0x17571D8", VA = "0x17571D8")]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1757234", Offset = "0x1757234", VA = "0x1757234", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x17583E0", Offset = "0x17583E0", VA = "0x17583E0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Address(RVA = "0x1758628", Offset = "0x1758628", VA = "0x1758628", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Address(RVA = "0x17586D4", Offset = "0x17586D4", VA = "0x17586D4")]
			private void Stretching()
			{
			}

			[Address(RVA = "0x1754C84", Offset = "0x1754C84", VA = "0x1754C84")]
			public void Solve(bool isLeft)
			{
			}

			[Address(RVA = "0x17598E8", Offset = "0x17598E8", VA = "0x17598E8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Address(RVA = "0x1759958", Offset = "0x1759958", VA = "0x1759958", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Address(RVA = "0x1758BBC", Offset = "0x1758BBC", VA = "0x1758BBC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Address(RVA = "0x1757DB4", Offset = "0x1757DB4", VA = "0x1757DB4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x1759CA4", Offset = "0x1759CA4", VA = "0x1759CA4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Address(RVA = "0x1756DB4", Offset = "0x1756DB4", VA = "0x1756DB4")]
			public Arm()
			{
			}
		}

		[Serializable]
		public abstract class BodyPart
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885D8C", Offset = "0x885D8C")]
			private float <sqrMag>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885D9C", Offset = "0x885D9C")]
			private float <mag>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x885DAC", Offset = "0x885DAC")]
			public VirtualBone[] bones;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			public float sqrMag
			{
				[Address(RVA = "0x1759E94", Offset = "0x1759E94", VA = "0x1759E94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C14C", Offset = "0x88C14C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x1759E9C", Offset = "0x1759E9C", VA = "0x1759E9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C15C", Offset = "0x88C15C")]
				private set
				{
				}
			}

			public float mag
			{
				[Address(RVA = "0x1758C94", Offset = "0x1758C94", VA = "0x1758C94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C16C", Offset = "0x88C16C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x1759EA4", Offset = "0x1759EA4", VA = "0x1759EA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C17C", Offset = "0x88C17C")]
				private set
				{
				}
			}

			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			public abstract void PreSolve();

			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			public abstract void ApplyOffsets();

			public abstract void ResetOffsets();

			[Address(RVA = "0x1751F18", Offset = "0x1751F18", VA = "0x1751F18")]
			public void SetLOD(int LOD)
			{
			}

			[Address(RVA = "0x17519E8", Offset = "0x17519E8", VA = "0x17519E8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x175A3F0", Offset = "0x175A3F0", VA = "0x175A3F0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Address(RVA = "0x175A588", Offset = "0x175A588", VA = "0x175A588")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Address(RVA = "0x175A910", Offset = "0x175A910", VA = "0x175A910")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Address(RVA = "0x17543BC", Offset = "0x17543BC", VA = "0x17543BC")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Address(RVA = "0x17596D0", Offset = "0x17596D0", VA = "0x17596D0")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Address(RVA = "0x175A964", Offset = "0x175A964", VA = "0x175A964")]
			public void Visualize(Color color)
			{
			}

			[Address(RVA = "0x175AB04", Offset = "0x175AB04", VA = "0x175AB04")]
			public void Visualize()
			{
			}

			[Address(RVA = "0x1759DFC", Offset = "0x1759DFC", VA = "0x1759DFC")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		public class Footstep
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x885DBC", Offset = "0x885DBC")]
			private float <stepProgress>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			public bool isStepping
			{
				[Address(RVA = "0x175AB2C", Offset = "0x175AB2C", VA = "0x175AB2C")]
				get
				{
					return default(bool);
				}
			}

			public float stepProgress
			{
				[Address(RVA = "0x175AB40", Offset = "0x175AB40", VA = "0x175AB40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C18C", Offset = "0x88C18C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x175AB48", Offset = "0x175AB48", VA = "0x175AB48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C19C", Offset = "0x88C19C")]
				private set
				{
				}
			}

			[Address(RVA = "0x175AB50", Offset = "0x175AB50", VA = "0x175AB50")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Address(RVA = "0x175ACE4", Offset = "0x175ACE4", VA = "0x175ACE4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Address(RVA = "0x175AD2C", Offset = "0x175AD2C", VA = "0x175AD2C")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Address(RVA = "0x175AE38", Offset = "0x175AE38", VA = "0x175AE38")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Address(RVA = "0x175B010", Offset = "0x175B010", VA = "0x175B010")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Address(RVA = "0x175B1FC", Offset = "0x175B1FC", VA = "0x175B1FC")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		public class Leg : BodyPart
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885DCC", Offset = "0x885DCC")]
			public Transform target;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885E04", Offset = "0x885E04")]
			public Transform bendGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885E3C", Offset = "0x885E3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885E3C", Offset = "0x885E3C")]
			public float positionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885E90", Offset = "0x885E90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885E90", Offset = "0x885E90")]
			public float rotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885EE4", Offset = "0x885EE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885EE4", Offset = "0x885EE4")]
			public float bendGoalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885F38", Offset = "0x885F38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885F38", Offset = "0x885F38")]
			public float swivelOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885F94", Offset = "0x885F94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885F94", Offset = "0x885F94")]
			public float bendToTargetWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x885FE8", Offset = "0x885FE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x885FE8", Offset = "0x885FE8")]
			public float legLengthMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886040", Offset = "0x886040")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886078", Offset = "0x886078")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886088", Offset = "0x886088")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886098", Offset = "0x886098")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x8860A8", Offset = "0x8860A8")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x8860B8", Offset = "0x8860B8")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x8860C8", Offset = "0x8860C8")]
			public float currentMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x8860D8", Offset = "0x8860D8")]
			public bool useAnimatedBendNormal;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8860E8", Offset = "0x8860E8")]
			private Vector3 <position>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8860F8", Offset = "0x8860F8")]
			private Quaternion <rotation>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x886108", Offset = "0x886108")]
			private bool <hasToes>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x886118", Offset = "0x886118")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			public Vector3 position
			{
				[Address(RVA = "0x1754238", Offset = "0x1754238", VA = "0x1754238")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C1AC", Offset = "0x88C1AC")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x175B41C", Offset = "0x175B41C", VA = "0x175B41C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C1BC", Offset = "0x88C1BC")]
				private set
				{
				}
			}

			public Quaternion rotation
			{
				[Address(RVA = "0x175B428", Offset = "0x175B428", VA = "0x175B428")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C1CC", Offset = "0x88C1CC")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
				[Address(RVA = "0x175B434", Offset = "0x175B434", VA = "0x175B434")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C1DC", Offset = "0x88C1DC")]
				private set
				{
				}
			}

			public bool hasToes
			{
				[Address(RVA = "0x175B440", Offset = "0x175B440", VA = "0x175B440")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C1EC", Offset = "0x88C1EC")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0x175B448", Offset = "0x175B448", VA = "0x175B448")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C1FC", Offset = "0x88C1FC")]
				private set
				{
				}
			}

			public VirtualBone thigh
			{
				[Address(RVA = "0x175B454", Offset = "0x175B454", VA = "0x175B454")]
				get
				{
					return null;
				}
			}

			private VirtualBone calf
			{
				[Address(RVA = "0x175B498", Offset = "0x175B498", VA = "0x175B498")]
				get
				{
					return null;
				}
			}

			private VirtualBone foot
			{
				[Address(RVA = "0x175B4E0", Offset = "0x175B4E0", VA = "0x175B4E0")]
				get
				{
					return null;
				}
			}

			private VirtualBone toes
			{
				[Address(RVA = "0x175B528", Offset = "0x175B528", VA = "0x175B528")]
				get
				{
					return null;
				}
			}

			public VirtualBone lastBone
			{
				[Address(RVA = "0x17541DC", Offset = "0x17541DC", VA = "0x17541DC")]
				get
				{
					return null;
				}
			}

			public Vector3 thighRelativeToPelvis
			{
				[Address(RVA = "0x175B570", Offset = "0x175B570", VA = "0x175B570")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C20C", Offset = "0x88C20C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x175B57C", Offset = "0x175B57C", VA = "0x175B57C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C21C", Offset = "0x88C21C")]
				private set
				{
				}
			}

			[Address(RVA = "0x175B588", Offset = "0x175B588", VA = "0x175B588", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x175BD98", Offset = "0x175BD98", VA = "0x175BD98", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Address(RVA = "0x175C720", Offset = "0x175C720", VA = "0x175C720", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Address(RVA = "0x175C61C", Offset = "0x175C61C", VA = "0x175C61C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Address(RVA = "0x175C3E4", Offset = "0x175C3E4", VA = "0x175C3E4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Address(RVA = "0x17545B4", Offset = "0x17545B4", VA = "0x17545B4")]
			public void Solve(bool stretch)
			{
			}

			[Address(RVA = "0x175CD38", Offset = "0x175CD38", VA = "0x175CD38")]
			private void Stretching()
			{
			}

			[Address(RVA = "0x175D33C", Offset = "0x175D33C", VA = "0x175D33C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Address(RVA = "0x175D684", Offset = "0x175D684", VA = "0x175D684", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Address(RVA = "0x1756EDC", Offset = "0x1756EDC", VA = "0x1756EDC")]
			public Leg()
			{
			}
		}

		[Serializable]
		public class Locomotion
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886128", Offset = "0x886128")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886128", Offset = "0x886128")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88617C", Offset = "0x88617C")]
			public float footDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8861B4", Offset = "0x8861B4")]
			public float stepThreshold;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8861EC", Offset = "0x8861EC")]
			public float angleThreshold;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886224", Offset = "0x886224")]
			public float comAngleMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88625C", Offset = "0x88625C")]
			public float maxVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886294", Offset = "0x886294")]
			public float velocityFactor;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8862CC", Offset = "0x8862CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8862CC", Offset = "0x8862CC")]
			public float maxLegStretch;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886324", Offset = "0x886324")]
			public float rootSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88635C", Offset = "0x88635C")]
			public float stepSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886394", Offset = "0x886394")]
			public AnimationCurve stepHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8863CC", Offset = "0x8863CC")]
			public AnimationCurve heelHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886404", Offset = "0x886404")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886404", Offset = "0x886404")]
			public float relaxLegTwistMinAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88645C", Offset = "0x88645C")]
			public float relaxLegTwistSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886494", Offset = "0x886494")]
			public InterpolationMode stepInterpolation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8864CC", Offset = "0x8864CC")]
			public Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886504", Offset = "0x886504")]
			public bool blockingEnabled;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886514", Offset = "0x886514")]
			public LayerMask blockingLayers;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886524", Offset = "0x886524")]
			public float raycastRadius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886534", Offset = "0x886534")]
			public float raycastHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886544", Offset = "0x886544")]
			public UnityEvent onLeftFootstep;

			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88657C", Offset = "0x88657C")]
			public UnityEvent onRightFootstep;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8865B4", Offset = "0x8865B4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			public Vector3 centerOfMass
			{
				[Address(RVA = "0x175D734", Offset = "0x175D734", VA = "0x175D734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C22C", Offset = "0x88C22C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x175D740", Offset = "0x175D740", VA = "0x175D740")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C23C", Offset = "0x88C23C")]
				private set
				{
				}
			}

			public Vector3 leftFootstepPosition
			{
				[Address(RVA = "0x175DBB4", Offset = "0x175DBB4", VA = "0x175DBB4")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public Vector3 rightFootstepPosition
			{
				[Address(RVA = "0x175DC0C", Offset = "0x175DC0C", VA = "0x175DC0C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public Quaternion leftFootstepRotation
			{
				[Address(RVA = "0x175DC68", Offset = "0x175DC68", VA = "0x175DC68")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
			}

			public Quaternion rightFootstepRotation
			{
				[Address(RVA = "0x175DCC0", Offset = "0x175DCC0", VA = "0x175DCC0")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
			}

			[Address(RVA = "0x1751B30", Offset = "0x1751B30", VA = "0x1751B30")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Address(RVA = "0x174E238", Offset = "0x174E238", VA = "0x174E238")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Address(RVA = "0x174D374", Offset = "0x174D374", VA = "0x174D374")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Address(RVA = "0x174D1B8", Offset = "0x174D1B8", VA = "0x174D1B8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Address(RVA = "0x17525D4", Offset = "0x17525D4", VA = "0x17525D4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Address(RVA = "0x175D79C", Offset = "0x175D79C", VA = "0x175D79C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Address(RVA = "0x175D940", Offset = "0x175D940", VA = "0x175D940")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Address(RVA = "0x175D9E8", Offset = "0x175D9E8", VA = "0x175D9E8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Address(RVA = "0x1756FD0", Offset = "0x1756FD0", VA = "0x1756FD0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		public class Spine : BodyPart
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8865C4", Offset = "0x8865C4")]
			public Transform headTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8865FC", Offset = "0x8865FC")]
			public Transform pelvisTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886634", Offset = "0x886634")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886634", Offset = "0x886634")]
			public float positionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886688", Offset = "0x886688")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886688", Offset = "0x886688")]
			public float rotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8866DC", Offset = "0x8866DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8866DC", Offset = "0x8866DC")]
			public float pelvisPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886730", Offset = "0x886730")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886730", Offset = "0x886730")]
			public float pelvisRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886784", Offset = "0x886784")]
			public Transform chestGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8867BC", Offset = "0x8867BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8867BC", Offset = "0x8867BC")]
			public float chestGoalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886810", Offset = "0x886810")]
			public float minHeadHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886848", Offset = "0x886848")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886848", Offset = "0x886848")]
			public float bodyPosStiffness;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88689C", Offset = "0x88689C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x88689C", Offset = "0x88689C")]
			public float bodyRotStiffness;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8868F0", Offset = "0x8868F0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8868F0", Offset = "0x8868F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8868F0", Offset = "0x8868F0")]
			public float neckStiffness;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886968", Offset = "0x886968")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886968", Offset = "0x886968")]
			public float rotateChestByHands;

			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8869BC", Offset = "0x8869BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8869BC", Offset = "0x8869BC")]
			public float chestClampWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886A10", Offset = "0x886A10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886A10", Offset = "0x886A10")]
			public float headClampWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886A64", Offset = "0x886A64")]
			public float moveBodyBackWhenCrouching;

			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886A9C", Offset = "0x886A9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886A9C", Offset = "0x886A9C")]
			public float maintainPelvisPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886AF0", Offset = "0x886AF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886AF0", Offset = "0x886AF0")]
			public float maxRootAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886B48", Offset = "0x886B48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x886B48", Offset = "0x886B48")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886BA4", Offset = "0x886BA4")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886BB4", Offset = "0x886BB4")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886BC4", Offset = "0x886BC4")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886BD4", Offset = "0x886BD4")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886BE4", Offset = "0x886BE4")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886BF4", Offset = "0x886BF4")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C04", Offset = "0x886C04")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C14", Offset = "0x886C14")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C24", Offset = "0x886C24")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C34", Offset = "0x886C34")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C44", Offset = "0x886C44")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C54", Offset = "0x886C54")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C64", Offset = "0x886C64")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x886C74", Offset = "0x886C74")]
			public Vector3 headPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x886C84", Offset = "0x886C84")]
			private Quaternion <anchorRotation>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x886C94", Offset = "0x886C94")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			public VirtualBone pelvis
			{
				[Address(RVA = "0x174E5F8", Offset = "0x174E5F8", VA = "0x174E5F8")]
				get
				{
					return null;
				}
			}

			public VirtualBone firstSpineBone
			{
				[Address(RVA = "0x175DD1C", Offset = "0x175DD1C", VA = "0x175DD1C")]
				get
				{
					return null;
				}
			}

			public VirtualBone chest
			{
				[Address(RVA = "0x1754C1C", Offset = "0x1754C1C", VA = "0x1754C1C")]
				get
				{
					return null;
				}
			}

			private VirtualBone neck
			{
				[Address(RVA = "0x175DD6C", Offset = "0x175DD6C", VA = "0x175DD6C")]
				get
				{
					return null;
				}
			}

			public VirtualBone head
			{
				[Address(RVA = "0x175D74C", Offset = "0x175D74C", VA = "0x175D74C")]
				get
				{
					return null;
				}
			}

			public Quaternion anchorRotation
			{
				[Address(RVA = "0x175DDBC", Offset = "0x175DDBC", VA = "0x175DDBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C24C", Offset = "0x88C24C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
				[Address(RVA = "0x175DDD0", Offset = "0x175DDD0", VA = "0x175DDD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C25C", Offset = "0x88C25C")]
				private set
				{
				}
			}

			public Quaternion anchorRelativeToHead
			{
				[Address(RVA = "0x175187C", Offset = "0x175187C", VA = "0x175187C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C26C", Offset = "0x88C26C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Quaternion);
				}
				[Address(RVA = "0x175DDE4", Offset = "0x175DDE4", VA = "0x175DDE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C27C", Offset = "0x88C27C")]
				private set
				{
				}
			}

			[Address(RVA = "0x175DDF8", Offset = "0x175DDF8", VA = "0x175DDF8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x175EC3C", Offset = "0x175EC3C", VA = "0x175EC3C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Address(RVA = "0x175EE9C", Offset = "0x175EE9C", VA = "0x175EE9C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Address(RVA = "0x175F51C", Offset = "0x175F51C", VA = "0x175F51C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Address(RVA = "0x1751F20", Offset = "0x1751F20", VA = "0x1751F20")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Address(RVA = "0x175FF3C", Offset = "0x175FF3C", VA = "0x175FF3C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Address(RVA = "0x17606EC", Offset = "0x17606EC", VA = "0x17606EC")]
			private void SolvePelvis()
			{
			}

			[Address(RVA = "0x17610F4", Offset = "0x17610F4", VA = "0x17610F4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Address(RVA = "0x1761470", Offset = "0x1761470", VA = "0x1761470", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Address(RVA = "0x175F750", Offset = "0x175F750", VA = "0x175F750")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Address(RVA = "0x1754244", Offset = "0x1754244", VA = "0x1754244")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Address(RVA = "0x175FB14", Offset = "0x175FB14", VA = "0x175FB14")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Address(RVA = "0x176156C", Offset = "0x176156C", VA = "0x176156C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x176044C", Offset = "0x176044C", VA = "0x176044C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Address(RVA = "0x1760158", Offset = "0x1760158", VA = "0x1760158")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Address(RVA = "0x1756C00", Offset = "0x1756C00", VA = "0x1756C00")]
			public Spine()
			{
			}
		}

		[Serializable]
		public enum PositionOffset
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Pelvis,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Chest,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LeftHand,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RightHand,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LeftFoot,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RightFoot,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LeftHeel,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RightHeel
		}

		[Serializable]
		public enum RotationOffset
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Pelvis,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Chest,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head
		}

		[Serializable]
		public class VirtualBone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Address(RVA = "0x1751944", Offset = "0x1751944", VA = "0x1751944")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Address(RVA = "0x17519C8", Offset = "0x17519C8", VA = "0x17519C8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Address(RVA = "0x176191C", Offset = "0x176191C", VA = "0x176191C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0x1759EAC", Offset = "0x1759EAC", VA = "0x1759EAC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Address(RVA = "0x175A684", Offset = "0x175A684", VA = "0x175A684")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Address(RVA = "0x1761C58", Offset = "0x1761C58", VA = "0x1761C58")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Address(RVA = "0x1758C9C", Offset = "0x1758C9C", VA = "0x1758C9C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Address(RVA = "0x1761F60", Offset = "0x1761F60", VA = "0x1761F60")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Address(RVA = "0x1758FAC", Offset = "0x1758FAC", VA = "0x1758FAC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Address(RVA = "0x1762060", Offset = "0x1762060", VA = "0x1762060")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x1760A7C", Offset = "0x1760A7C", VA = "0x1760A7C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Address(RVA = "0x1762278", Offset = "0x1762278", VA = "0x1762278")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x1762380", Offset = "0x1762380", VA = "0x1762380")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882F1C", Offset = "0x882F1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x882F1C", Offset = "0x882F1C")]
		public int LOD;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882F70", Offset = "0x882F70")]
		public bool plantFeet;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x882FA8", Offset = "0x882FA8")]
		private VirtualBone <rootBone>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882FB8", Offset = "0x882FB8")]
		public Spine spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x882FF0", Offset = "0x882FF0")]
		public Arm leftArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883028", Offset = "0x883028")]
		public Arm rightArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883060", Offset = "0x883060")]
		public Leg leftLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883098", Offset = "0x883098")]
		public Leg rightLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8830D0", Offset = "0x8830D0")]
		public Locomotion locomotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88C58C", Offset = "0x88C58C")]
		public VirtualBone rootBone
		{
			[Address(RVA = "0x174E230", Offset = "0x174E230", VA = "0x174E230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B14C", Offset = "0x88B14C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x17519C0", Offset = "0x17519C0", VA = "0x17519C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B15C", Offset = "0x88B15C")]
			private set
			{
			}
		}

		[Address(RVA = "0x174BA98", Offset = "0x174BA98", VA = "0x174BA98")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Address(RVA = "0x174C018", Offset = "0x174C018", VA = "0x174C018")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Address(RVA = "0x174BE34", Offset = "0x174BE34", VA = "0x174BE34")]
		public void DefaultAnimationCurves()
		{
		}

		[Address(RVA = "0x174CC1C", Offset = "0x174CC1C", VA = "0x174CC1C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Address(RVA = "0x174CDB8", Offset = "0x174CDB8", VA = "0x174CDB8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Address(RVA = "0x174CE5C", Offset = "0x174CE5C", VA = "0x174CE5C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Address(RVA = "0x174D004", Offset = "0x174D004", VA = "0x174D004")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Address(RVA = "0x174D758", Offset = "0x174D758", VA = "0x174D758")]
		public void Reset()
		{
		}

		[Address(RVA = "0x174E648", Offset = "0x174E648", VA = "0x174E648", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x174E87C", Offset = "0x174E87C", VA = "0x174E87C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x174EB48", Offset = "0x174EB48", VA = "0x174EB48", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x174EBBC", Offset = "0x174EBBC", VA = "0x174EBBC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x174EC30", Offset = "0x174EC30", VA = "0x174EC30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x174EE60", Offset = "0x174EE60", VA = "0x174EE60")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x174C3D8", Offset = "0x174C3D8", VA = "0x174C3D8")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x174C5C8", Offset = "0x174C5C8", VA = "0x174C5C8")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x174CAA4", Offset = "0x174CAA4", VA = "0x174CAA4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Address(RVA = "0x174D914", Offset = "0x174D914", VA = "0x174D914")]
		private void UpdateSolverTransforms()
		{
		}

		[Address(RVA = "0x174F1A4", Offset = "0x174F1A4", VA = "0x174F1A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x174F1EC", Offset = "0x174F1EC", VA = "0x174F1EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x1751204", Offset = "0x1751204", VA = "0x1751204")]
		private void WriteTransforms()
		{
		}

		[Address(RVA = "0x174DB38", Offset = "0x174DB38", VA = "0x174DB38")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Address(RVA = "0x174F85C", Offset = "0x174F85C", VA = "0x174F85C")]
		private void Solve()
		{
		}

		[Address(RVA = "0x1751890", Offset = "0x1751890", VA = "0x1751890")]
		private Vector3 GetPosition(int index)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x17518EC", Offset = "0x17518EC", VA = "0x17518EC")]
		private Quaternion GetRotation(int index)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1751028", Offset = "0x1751028", VA = "0x1751028")]
		private void Write()
		{
		}

		[Address(RVA = "0x1756358", Offset = "0x1756358", VA = "0x1756358")]
		private Vector3 GetPelvisOffset()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x1756A58", Offset = "0x1756A58", VA = "0x1756A58")]
		public IKSolverVR()
		{
		}
	}
	public class TwistRelaxer : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883108", Offset = "0x883108")]
		public Transform parent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883140", Offset = "0x883140")]
		public Transform child;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883178", Offset = "0x883178")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883178", Offset = "0x883178")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8831CC", Offset = "0x8831CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8831CC", Offset = "0x8831CC")]
		public float parentChildCrossfade;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883220", Offset = "0x883220")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883220", Offset = "0x883220")]
		public float twistAngleOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Address(RVA = "0x135890C", Offset = "0x135890C", VA = "0x135890C")]
		public void Relax()
		{
		}

		[Address(RVA = "0x1358D50", Offset = "0x1358D50", VA = "0x1358D50")]
		private void Start()
		{
		}

		[Address(RVA = "0x13592C4", Offset = "0x13592C4", VA = "0x13592C4")]
		private void OnPostUpdate()
		{
		}

		[Address(RVA = "0x135934C", Offset = "0x135934C", VA = "0x135934C")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x13593D4", Offset = "0x13593D4", VA = "0x13593D4")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x1359540", Offset = "0x1359540", VA = "0x1359540")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	public class InteractionEffector
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88327C", Offset = "0x88327C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88328C", Offset = "0x88328C")]
		private bool <isPaused>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88329C", Offset = "0x88329C")]
		private InteractionObject <interactionObject>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		public FullBodyBipedEffector effectorType
		{
			[Address(RVA = "0x1762C84", Offset = "0x1762C84", VA = "0x1762C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B16C", Offset = "0x88B16C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Address(RVA = "0x1762C8C", Offset = "0x1762C8C", VA = "0x1762C8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B17C", Offset = "0x88B17C")]
			private set
			{
			}
		}

		public bool isPaused
		{
			[Address(RVA = "0x1762C94", Offset = "0x1762C94", VA = "0x1762C94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B18C", Offset = "0x88B18C")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0x1762C9C", Offset = "0x1762C9C", VA = "0x1762C9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B19C", Offset = "0x88B19C")]
			private set
			{
			}
		}

		public InteractionObject interactionObject
		{
			[Address(RVA = "0x1762CA8", Offset = "0x1762CA8", VA = "0x1762CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B1AC", Offset = "0x88B1AC")]
			get
			{
				return null;
			}
			[Address(RVA = "0x1762CB0", Offset = "0x1762CB0", VA = "0x1762CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B1BC", Offset = "0x88B1BC")]
			private set
			{
			}
		}

		public bool inInteraction
		{
			[Address(RVA = "0x1762CB8", Offset = "0x1762CB8", VA = "0x1762CB8")]
			get
			{
				return default(bool);
			}
		}

		public float progress
		{
			[Address(RVA = "0x1765248", Offset = "0x1765248", VA = "0x1765248")]
			get
			{
				return default(float);
			}
		}

		[Address(RVA = "0x1762D28", Offset = "0x1762D28", VA = "0x1762D28")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Address(RVA = "0x1762DAC", Offset = "0x1762DAC", VA = "0x1762DAC")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Address(RVA = "0x1762E88", Offset = "0x1762E88", VA = "0x1762E88")]
		private void StoreDefaults()
		{
		}

		[Address(RVA = "0x176315C", Offset = "0x176315C", VA = "0x176315C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Address(RVA = "0x1763820", Offset = "0x1763820", VA = "0x1763820")]
		public bool Pause()
		{
			return default(bool);
		}

		[Address(RVA = "0x17639E0", Offset = "0x17639E0", VA = "0x17639E0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Address(RVA = "0x1763A70", Offset = "0x1763A70", VA = "0x1763A70")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Address(RVA = "0x1763FEC", Offset = "0x1763FEC", VA = "0x1763FEC")]
		public void Update(Transform root, float speed)
		{
		}

		[Address(RVA = "0x1764900", Offset = "0x1764900", VA = "0x1764900")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Address(RVA = "0x1764DCC", Offset = "0x1764DCC", VA = "0x1764DCC")]
		private void PickUp(Transform root)
		{
		}

		[Address(RVA = "0x17650A0", Offset = "0x17650A0", VA = "0x17650A0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Address(RVA = "0x1765284", Offset = "0x1765284", VA = "0x1765284")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	public class InteractionLookAt
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8832AC", Offset = "0x8832AC")]
		public LookAtIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8832E4", Offset = "0x8832E4")]
		public float lerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88331C", Offset = "0x88331C")]
		public float weightSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883354", Offset = "0x883354")]
		public bool isPaused;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Address(RVA = "0x1342B58", Offset = "0x1342B58", VA = "0x1342B58")]
		public void Look(Transform target, float time)
		{
		}

		[Address(RVA = "0x1342D64", Offset = "0x1342D64", VA = "0x1342D64")]
		public void OnFixTransforms()
		{
		}

		[Address(RVA = "0x1342E2C", Offset = "0x1342E2C", VA = "0x1342E2C")]
		public void Update()
		{
		}

		[Address(RVA = "0x1343480", Offset = "0x1343480", VA = "0x1343480")]
		public void SolveSpine()
		{
		}

		[Address(RVA = "0x1343614", Offset = "0x1343614", VA = "0x1343614")]
		public void SolveHead()
		{
		}

		[Address(RVA = "0x1343738", Offset = "0x1343738", VA = "0x1343738")]
		public InteractionLookAt()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87D9B4", Offset = "0x87D9B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87D9B4", Offset = "0x87D9B4")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		public class InteractionEvent
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886CA4", Offset = "0x886CA4")]
			public float time;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886CDC", Offset = "0x886CDC")]
			public bool pause;

			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886D14", Offset = "0x886D14")]
			public bool pickUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886D4C", Offset = "0x886D4C")]
			public AnimatorEvent[] animations;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886D84", Offset = "0x886D84")]
			public Message[] messages;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886DBC", Offset = "0x886DBC")]
			public UnityEvent unityEvent;

			[Address(RVA = "0x1345C18", Offset = "0x1345C18", VA = "0x1345C18")]
			public void Activate(Transform t)
			{
			}

			[Address(RVA = "0x1345E30", Offset = "0x1345E30", VA = "0x1345E30")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		public class Message
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886DF4", Offset = "0x886DF4")]
			public string function;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886E2C", Offset = "0x886E2C")]
			public GameObject recipient;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const string empty = "";

			[Address(RVA = "0x1345D34", Offset = "0x1345D34", VA = "0x1345D34")]
			public void Send(Transform t)
			{
			}

			[Address(RVA = "0x1345E38", Offset = "0x1345E38", VA = "0x1345E38")]
			public Message()
			{
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886E64", Offset = "0x886E64")]
			public Animator animator;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886E9C", Offset = "0x886E9C")]
			public Animation animation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886ED4", Offset = "0x886ED4")]
			public string animationState;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886F0C", Offset = "0x886F0C")]
			public float crossfadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886F44", Offset = "0x886F44")]
			public int layer;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886F7C", Offset = "0x886F7C")]
			public bool resetNormalizedTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const string empty = "";

			[Address(RVA = "0x13458F4", Offset = "0x13458F4", VA = "0x13458F4")]
			public void Activate(bool pickUp)
			{
			}

			[Address(RVA = "0x13459F0", Offset = "0x13459F0", VA = "0x13459F0")]
			private void Activate(Animator animator)
			{
			}

			[Address(RVA = "0x1345AD8", Offset = "0x1345AD8", VA = "0x1345AD8")]
			private void Activate(Animation animation)
			{
			}

			[Address(RVA = "0x1345C04", Offset = "0x1345C04", VA = "0x1345C04")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		public class WeightCurve
		{
			[Serializable]
			public enum Type
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				RotationWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionOffsetX,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionOffsetY,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionOffsetZ,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				Pull,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				Reach,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				RotateBoneWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				Push,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PushParent,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PoserWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				BendGoalWeight
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886FB4", Offset = "0x886FB4")]
			public Type type;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x886FEC", Offset = "0x886FEC")]
			public AnimationCurve curve;

			[Address(RVA = "0x1344A7C", Offset = "0x1344A7C", VA = "0x1344A7C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Address(RVA = "0x1345E50", Offset = "0x1345E50", VA = "0x1345E50")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		public class Multiplier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887024", Offset = "0x887024")]
			public WeightCurve.Type curve;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88705C", Offset = "0x88705C")]
			public float multiplier;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887094", Offset = "0x887094")]
			public WeightCurve.Type result;

			[Address(RVA = "0x13453D4", Offset = "0x13453D4", VA = "0x13453D4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Address(RVA = "0x1345E40", Offset = "0x1345E40", VA = "0x1345E40")]
			public Multiplier()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883364", Offset = "0x883364")]
		public Transform otherLookAtTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88339C", Offset = "0x88339C")]
		public Transform otherTargetsRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8833D4", Offset = "0x8833D4")]
		public Transform positionOffsetSpace;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88340C", Offset = "0x88340C")]
		private float <length>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88341C", Offset = "0x88341C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		public float length
		{
			[Address(RVA = "0x1343914", Offset = "0x1343914", VA = "0x1343914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B31C", Offset = "0x88B31C")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0x134391C", Offset = "0x134391C", VA = "0x134391C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B32C", Offset = "0x88B32C")]
			private set
			{
			}
		}

		public InteractionSystem lastUsedInteractionSystem
		{
			[Address(RVA = "0x1343924", Offset = "0x1343924", VA = "0x1343924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B33C", Offset = "0x88B33C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x134392C", Offset = "0x134392C", VA = "0x134392C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B34C", Offset = "0x88B34C")]
			private set
			{
			}
		}

		public Transform lookAtTarget
		{
			[Address(RVA = "0x1343CD4", Offset = "0x1343CD4", VA = "0x1343CD4")]
			get
			{
				return null;
			}
		}

		public Transform targetsRoot
		{
			[Address(RVA = "0x1343C44", Offset = "0x1343C44", VA = "0x1343C44")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x134374C", Offset = "0x134374C", VA = "0x134374C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B1CC", Offset = "0x88B1CC")]
		private void OpenTutorial1()
		{
		}

		[Address(RVA = "0x1343798", Offset = "0x1343798", VA = "0x1343798")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B204", Offset = "0x88B204")]
		private void OpenTutorial2()
		{
		}

		[Address(RVA = "0x13437E4", Offset = "0x13437E4", VA = "0x13437E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B23C", Offset = "0x88B23C")]
		private void OpenTutorial3()
		{
		}

		[Address(RVA = "0x1343830", Offset = "0x1343830", VA = "0x1343830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B274", Offset = "0x88B274")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0x134387C", Offset = "0x134387C", VA = "0x134387C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B2AC", Offset = "0x88B2AC")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x13438C8", Offset = "0x13438C8", VA = "0x13438C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B2E4", Offset = "0x88B2E4")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x1343934", Offset = "0x1343934", VA = "0x1343934")]
		public void Initiate()
		{
		}

		[Address(RVA = "0x1343D64", Offset = "0x1343D64", VA = "0x1343D64")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Address(RVA = "0x1343F30", Offset = "0x1343F30", VA = "0x1343F30")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Address(RVA = "0x1344030", Offset = "0x1344030", VA = "0x1344030")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Address(RVA = "0x1344038", Offset = "0x1344038", VA = "0x1344038")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Address(RVA = "0x1344304", Offset = "0x1344304", VA = "0x1344304")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Address(RVA = "0x134430C", Offset = "0x134430C", VA = "0x134430C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Address(RVA = "0x1345420", Offset = "0x1345420", VA = "0x1345420")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Address(RVA = "0x1345748", Offset = "0x1345748", VA = "0x1345748")]
		private void Start()
		{
		}

		[Address(RVA = "0x1344ABC", Offset = "0x1344ABC", VA = "0x1344ABC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Address(RVA = "0x1344210", Offset = "0x1344210", VA = "0x1344210")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Address(RVA = "0x1345324", Offset = "0x1345324", VA = "0x1345324")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Address(RVA = "0x134574C", Offset = "0x134574C", VA = "0x134574C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Address(RVA = "0x13457FC", Offset = "0x13457FC", VA = "0x13457FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B35C", Offset = "0x88B35C")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x1345848", Offset = "0x1345848", VA = "0x1345848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B394", Offset = "0x88B394")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1345894", Offset = "0x1345894", VA = "0x1345894")]
		public InteractionObject()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DA14", Offset = "0x87DA14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DA14", Offset = "0x87DA14")]
	public class InteractionSystem : MonoBehaviour
	{
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88342C", Offset = "0x88342C")]
		public string targetTag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883464", Offset = "0x883464")]
		public float fadeInTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88349C", Offset = "0x88349C")]
		public float speed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8834D4", Offset = "0x8834D4")]
		public float resetToDefaultsSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x88350C", Offset = "0x88350C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88350C", Offset = "0x88350C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x88350C", Offset = "0x88350C")]
		public Collider characterCollider;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883590", Offset = "0x883590")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x883590", Offset = "0x883590")]
		public Transform FPSCamera;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8835F0", Offset = "0x8835F0")]
		public LayerMask camRaycastLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883628", Offset = "0x883628")]
		public float camRaycastDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x883660", Offset = "0x883660")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x883670", Offset = "0x883670")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883670", Offset = "0x883670")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8836D0", Offset = "0x8836D0")]
		public InteractionLookAt lookAt;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		public bool inInteraction
		{
			[Address(RVA = "0x1346020", Offset = "0x1346020", VA = "0x1346020")]
			get
			{
				return default(bool);
			}
		}

		public FullBodyBipedIK ik
		{
			[Address(RVA = "0x1348A2C", Offset = "0x1348A2C", VA = "0x1348A2C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x1348A34", Offset = "0x1348A34", VA = "0x1348A34")]
			set
			{
			}
		}

		public List<InteractionTrigger> triggersInRange
		{
			[Address(RVA = "0x134759C", Offset = "0x134759C", VA = "0x134759C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B51C", Offset = "0x88B51C")]
			get
			{
				return null;
			}
			[Address(RVA = "0x1348A3C", Offset = "0x1348A3C", VA = "0x1348A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88B52C", Offset = "0x88B52C")]
			private set
			{
			}
		}

		[Address(RVA = "0x1345E58", Offset = "0x1345E58", VA = "0x1345E58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B3CC", Offset = "0x88B3CC")]
		private void OpenTutorial1()
		{
		}

		[Address(RVA = "0x1345EA4", Offset = "0x1345EA4", VA = "0x1345EA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B404", Offset = "0x88B404")]
		private void OpenTutorial2()
		{
		}

		[Address(RVA = "0x1345EF0", Offset = "0x1345EF0", VA = "0x1345EF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B43C", Offset = "0x88B43C")]
		private void OpenTutorial3()
		{
		}

		[Address(RVA = "0x1345F3C", Offset = "0x1345F3C", VA = "0x1345F3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B474", Offset = "0x88B474")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0x1345F88", Offset = "0x1345F88", VA = "0x1345F88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B4AC", Offset = "0x88B4AC")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x1345FD4", Offset = "0x1345FD4", VA = "0x1345FD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B4E4", Offset = "0x88B4E4")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x134620C", Offset = "0x134620C", VA = "0x134620C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0x1346378", Offset = "0x1346378", VA = "0x1346378")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0x13464E8", Offset = "0x13464E8", VA = "0x13464E8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Address(RVA = "0x13465F0", Offset = "0x13465F0", VA = "0x13465F0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Address(RVA = "0x1346784", Offset = "0x1346784", VA = "0x1346784")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Address(RVA = "0x1346934", Offset = "0x1346934", VA = "0x1346934")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0x1346A50", Offset = "0x1346A50", VA = "0x1346A50")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0x1346B6C", Offset = "0x1346B6C", VA = "0x1346B6C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0x1346C88", Offset = "0x1346C88", VA = "0x1346C88")]
		public void PauseAll()
		{
		}

		[Address(RVA = "0x1346D30", Offset = "0x1346D30", VA = "0x1346D30")]
		public void ResumeAll()
		{
		}

		[Address(RVA = "0x1346DD8", Offset = "0x1346DD8", VA = "0x1346DD8")]
		public void StopAll()
		{
		}

		[Address(RVA = "0x1346E74", Offset = "0x1346E74", VA = "0x1346E74")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Address(RVA = "0x1346F90", Offset = "0x1346F90", VA = "0x1346F90")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Address(RVA = "0x13470AC", Offset = "0x13470AC", VA = "0x13470AC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Address(RVA = "0x13471C8", Offset = "0x13471C8", VA = "0x13471C8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Address(RVA = "0x13475A4", Offset = "0x13475A4", VA = "0x13475A4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Address(RVA = "0x1347854", Offset = "0x1347854", VA = "0x1347854")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Address(RVA = "0x1347C14", Offset = "0x1347C14", VA = "0x1347C14")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Address(RVA = "0x1347FB8", Offset = "0x1347FB8", VA = "0x1347FB8")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Address(RVA = "0x1348014", Offset = "0x1348014", VA = "0x1348014")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Address(RVA = "0x134810C", Offset = "0x134810C", VA = "0x134810C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Address(RVA = "0x1348284", Offset = "0x1348284", VA = "0x1348284")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Address(RVA = "0x134843C", Offset = "0x134843C", VA = "0x134843C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Address(RVA = "0x13488D4", Offset = "0x13488D4", VA = "0x13488D4")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Address(RVA = "0x1347D4C", Offset = "0x1347D4C", VA = "0x1347D4C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Address(RVA = "0x1348A44", Offset = "0x1348A44", VA = "0x1348A44")]
		public void Start()
		{
		}

		[Address(RVA = "0x13493C0", Offset = "0x13493C0", VA = "0x13493C0")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0x13493F0", Offset = "0x13493F0", VA = "0x13493F0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0x134941C", Offset = "0x134941C", VA = "0x134941C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0x1349448", Offset = "0x1349448", VA = "0x1349448")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0x13494CC", Offset = "0x13494CC", VA = "0x13494CC")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Address(RVA = "0x1349604", Offset = "0x1349604", VA = "0x1349604")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Address(RVA = "0x1349710", Offset = "0x1349710", VA = "0x1349710")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Address(RVA = "0x1349AE4", Offset = "0x1349AE4", VA = "0x1349AE4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0x1349BD0", Offset = "0x1349BD0", VA = "0x1349BD0")]
		public void Update()
		{
		}

		[Address(RVA = "0x1349E98", Offset = "0x1349E98", VA = "0x1349E98")]
		private void Raycasting()
		{
		}

		[Address(RVA = "0x1349100", Offset = "0x1349100", VA = "0x1349100")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Address(RVA = "0x1349FEC", Offset = "0x1349FEC", VA = "0x1349FEC")]
		private void UpdateEffectors()
		{
		}

		[Address(RVA = "0x134A188", Offset = "0x134A188", VA = "0x134A188")]
		private void OnPreFBBIK()
		{
		}

		[Address(RVA = "0x134A228", Offset = "0x134A228", VA = "0x134A228")]
		private void OnPostFBBIK()
		{
		}

		[Address(RVA = "0x134A344", Offset = "0x134A344", VA = "0x134A344")]
		private void OnFixTransforms()
		{
		}

		[Address(RVA = "0x134A370", Offset = "0x134A370", VA = "0x134A370")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x1346128", Offset = "0x1346128", VA = "0x1346128")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Address(RVA = "0x134746C", Offset = "0x134746C", VA = "0x134746C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Address(RVA = "0x134A8D8", Offset = "0x134A8D8", VA = "0x134A8D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B53C", Offset = "0x88B53C")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x134A924", Offset = "0x134A924", VA = "0x134A924")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B574", Offset = "0x88B574")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x134A970", Offset = "0x134A970", VA = "0x134A970")]
		public InteractionSystem()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DA74", Offset = "0x87DA74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DA74", Offset = "0x87DA74")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		public class Multiplier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8870CC", Offset = "0x8870CC")]
			public InteractionObject.WeightCurve.Type curve;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887104", Offset = "0x887104")]
			public float multiplier;

			[Address(RVA = "0x134C22C", Offset = "0x134C22C", VA = "0x134C22C")]
			public Multiplier()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883708", Offset = "0x883708")]
		public FullBodyBipedEffector effectorType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883740", Offset = "0x883740")]
		public Multiplier[] multipliers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883778", Offset = "0x883778")]
		public float interactionSpeedMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8837B0", Offset = "0x8837B0")]
		public Transform pivot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8837E8", Offset = "0x8837E8")]
		public Vector3 twistAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883820", Offset = "0x883820")]
		public float twistWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883858", Offset = "0x883858")]
		public float swingWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883890", Offset = "0x883890")]
		public bool rotateOnce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Address(RVA = "0x134B860", Offset = "0x134B860", VA = "0x134B860")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B5AC", Offset = "0x88B5AC")]
		private void OpenTutorial1()
		{
		}

		[Address(RVA = "0x134B8AC", Offset = "0x134B8AC", VA = "0x134B8AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B5E4", Offset = "0x88B5E4")]
		private void OpenTutorial2()
		{
		}

		[Address(RVA = "0x134B8F8", Offset = "0x134B8F8", VA = "0x134B8F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B61C", Offset = "0x88B61C")]
		private void OpenTutorial3()
		{
		}

		[Address(RVA = "0x134B944", Offset = "0x134B944", VA = "0x134B944")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B654", Offset = "0x88B654")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0x134B990", Offset = "0x134B990", VA = "0x134B990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B68C", Offset = "0x88B68C")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x134B9DC", Offset = "0x134B9DC", VA = "0x134B9DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B6C4", Offset = "0x88B6C4")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x134497C", Offset = "0x134497C", VA = "0x134497C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Address(RVA = "0x134BA28", Offset = "0x134BA28", VA = "0x134BA28")]
		public void ResetRotation()
		{
		}

		[Address(RVA = "0x134BAF4", Offset = "0x134BAF4", VA = "0x134BAF4")]
		public void RotateTo(Vector3 position)
		{
		}

		[Address(RVA = "0x134C108", Offset = "0x134C108", VA = "0x134C108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B6FC", Offset = "0x88B6FC")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x134C154", Offset = "0x134C154", VA = "0x134C154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B734", Offset = "0x88B734")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x134C1A0", Offset = "0x134C1A0", VA = "0x134C1A0")]
		public InteractionTarget()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DAD4", Offset = "0x87DAD4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DAD4", Offset = "0x87DAD4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		public class CharacterPosition
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88713C", Offset = "0x88713C")]
			public bool use;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887174", Offset = "0x887174")]
			public Vector2 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8871AC", Offset = "0x8871AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8871AC", Offset = "0x8871AC")]
			public float angleOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887208", Offset = "0x887208")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887208", Offset = "0x887208")]
			public float maxAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887260", Offset = "0x887260")]
			public float radius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887298", Offset = "0x887298")]
			public bool orbit;

			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8872D0", Offset = "0x8872D0")]
			public bool fixYAxis;

			public Vector3 offset3D
			{
				[Address(RVA = "0x134CA00", Offset = "0x134CA00", VA = "0x134CA00")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public Vector3 direction3D
			{
				[Address(RVA = "0x134CA3C", Offset = "0x134CA3C", VA = "0x134CA3C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			[Address(RVA = "0x134CB34", Offset = "0x134CB34", VA = "0x134CB34")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Address(RVA = "0x134D208", Offset = "0x134D208", VA = "0x134D208")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		public class CameraPosition
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887308", Offset = "0x887308")]
			public Collider lookAtTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887340", Offset = "0x887340")]
			public Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887378", Offset = "0x887378")]
			public float maxDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8873B0", Offset = "0x8873B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8873B0", Offset = "0x8873B0")]
			public float maxAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887408", Offset = "0x887408")]
			public bool fixYAxis;

			[Address(RVA = "0x134C4BC", Offset = "0x134C4BC", VA = "0x134C4BC")]
			public Quaternion GetRotation()
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Quaternion);
			}

			[Address(RVA = "0x134C690", Offset = "0x134C690", VA = "0x134C690")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Address(RVA = "0x134C974", Offset = "0x134C974", VA = "0x134C974")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		public class Range
		{
			[Serializable]
			public class Interaction
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8884C0", Offset = "0x8884C0")]
				public InteractionObject interactionObject;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8884F8", Offset = "0x8884F8")]
				public FullBodyBipedEffector[] effectors;

				[Address(RVA = "0x134D22C", Offset = "0x134D22C", VA = "0x134D22C")]
				public Interaction()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x887440", Offset = "0x887440")]
			[SerializeField]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x887478", Offset = "0x887478")]
			[SerializeField]
			public bool show;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8874B0", Offset = "0x8874B0")]
			public CharacterPosition characterPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8874E8", Offset = "0x8874E8")]
			public CameraPosition cameraPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887520", Offset = "0x887520")]
			public Interaction[] interactions;

			[Address(RVA = "0x134C31C", Offset = "0x134C31C", VA = "0x134C31C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Address(RVA = "0x134D21C", Offset = "0x134D21C", VA = "0x134D21C")]
			public Range()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8838C8", Offset = "0x8838C8")]
		public Range[] ranges;

		[Address(RVA = "0x134C234", Offset = "0x134C234", VA = "0x134C234")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B76C", Offset = "0x88B76C")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0x134C280", Offset = "0x134C280", VA = "0x134C280")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B7A4", Offset = "0x88B7A4")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x134C2CC", Offset = "0x134C2CC", VA = "0x134C2CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B7DC", Offset = "0x88B7DC")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x134C318", Offset = "0x134C318", VA = "0x134C318")]
		private void Start()
		{
		}

		[Address(RVA = "0x13498F8", Offset = "0x13498F8", VA = "0x13498F8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Address(RVA = "0x134C45C", Offset = "0x134C45C", VA = "0x134C45C")]
		public InteractionTrigger()
		{
		}
	}
	public class GenericPoser : Poser
	{
		[Serializable]
		public class Map
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Address(RVA = "0x10D2E68", Offset = "0x10D2E68", VA = "0x10D2E68")]
			public Map(Transform bone, Transform target)
			{
			}

			[Address(RVA = "0x10D33B0", Offset = "0x10D33B0", VA = "0x10D33B0")]
			public void StoreDefaultState()
			{
			}

			[Address(RVA = "0x10D3324", Offset = "0x10D3324", VA = "0x10D3324")]
			public void FixTransform()
			{
			}

			[Address(RVA = "0x10D3078", Offset = "0x10D3078", VA = "0x10D3078")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Address(RVA = "0x10D2AD8", Offset = "0x10D2AD8", VA = "0x10D2AD8", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B814", Offset = "0x88B814")]
		public override void AutoMapping()
		{
		}

		[Address(RVA = "0x10D2F3C", Offset = "0x10D2F3C", VA = "0x10D2F3C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Address(RVA = "0x10D2F40", Offset = "0x10D2F40", VA = "0x10D2F40", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Address(RVA = "0x10D328C", Offset = "0x10D328C", VA = "0x10D328C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Address(RVA = "0x10D2EA4", Offset = "0x10D2EA4", VA = "0x10D2EA4")]
		private void StoreDefaultState()
		{
		}

		[Address(RVA = "0x10D2DA0", Offset = "0x10D2DA0", VA = "0x10D2DA0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Address(RVA = "0x10D3414", Offset = "0x10D3414", VA = "0x10D3414")]
		public GenericPoser()
		{
		}
	}
	public class HandPoser : Poser
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Address(RVA = "0x16E1174", Offset = "0x16E1174", VA = "0x16E1174", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Address(RVA = "0x16E1230", Offset = "0x16E1230", VA = "0x16E1230", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Address(RVA = "0x16E1490", Offset = "0x16E1490", VA = "0x16E1490", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Address(RVA = "0x16E1620", Offset = "0x16E1620", VA = "0x16E1620", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Address(RVA = "0x16E128C", Offset = "0x16E128C", VA = "0x16E128C")]
		protected void StoreDefaultState()
		{
		}

		[Address(RVA = "0x16E1B44", Offset = "0x16E1B44", VA = "0x16E1B44")]
		public HandPoser()
		{
		}
	}
	public abstract class Poser : SolverManager
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883900", Offset = "0x883900")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883918", Offset = "0x883918")]
		public float localRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883930", Offset = "0x883930")]
		public float localPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		public abstract void AutoMapping();

		[Address(RVA = "0x13505A0", Offset = "0x13505A0", VA = "0x13505A0")]
		public void UpdateManual()
		{
		}

		protected abstract void InitiatePoser();

		protected abstract void UpdatePoser();

		protected abstract void FixPoserTransforms();

		[Address(RVA = "0x13505AC", Offset = "0x13505AC", VA = "0x13505AC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0x1350600", Offset = "0x1350600", VA = "0x1350600", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0x135063C", Offset = "0x135063C", VA = "0x135063C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Address(RVA = "0x1350654", Offset = "0x1350654", VA = "0x1350654")]
		protected Poser()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x87DB34", Offset = "0x87DB34")]
	public class RagdollUtility : MonoBehaviour
	{
		public class Rigidbone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Address(RVA = "0x1350D2C", Offset = "0x1350D2C", VA = "0x1350D2C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Address(RVA = "0x1351D40", Offset = "0x1351D40", VA = "0x1351D40")]
			public void RecordVelocity()
			{
			}

			[Address(RVA = "0x1351A88", Offset = "0x1351A88", VA = "0x1351A88")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		public class Child
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Address(RVA = "0x1350EC4", Offset = "0x1350EC4", VA = "0x1350EC4")]
			public Child(Transform transform)
			{
			}

			[Address(RVA = "0x1351F1C", Offset = "0x1351F1C", VA = "0x1351F1C")]
			public void FixTransform(float weight)
			{
			}

			[Address(RVA = "0x1351EB8", Offset = "0x1351EB8", VA = "0x1351EB8")]
			public void StoreLocalState()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDB8", Offset = "0x87DDB8")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x13526B4", Offset = "0x13526B4", VA = "0x13526B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x1352724", Offset = "0x1352724", VA = "0x1352724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1350F34", Offset = "0x1350F34", VA = "0x1350F34")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Address(RVA = "0x135238C", Offset = "0x135238C", VA = "0x135238C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x1352390", Offset = "0x1352390", VA = "0x1352390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x13526BC", Offset = "0x13526BC", VA = "0x13526BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883948", Offset = "0x883948")]
		public IK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883980", Offset = "0x883980")]
		public float ragdollToAnimationTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8839B8", Offset = "0x8839B8")]
		public bool applyIkOnRagdoll;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8839F0", Offset = "0x8839F0")]
		public float applyVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883A28", Offset = "0x883A28")]
		public float applyAngularVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		private bool isRagdoll
		{
			[Address(RVA = "0x135069C", Offset = "0x135069C", VA = "0x135069C")]
			get
			{
				return default(bool);
			}
		}

		private bool ikUsed
		{
			[Address(RVA = "0x135149C", Offset = "0x135149C", VA = "0x135149C")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x1350664", Offset = "0x1350664", VA = "0x1350664")]
		public void EnableRagdoll()
		{
		}

		[Address(RVA = "0x135073C", Offset = "0x135073C", VA = "0x135073C")]
		public void DisableRagdoll()
		{
		}

		[Address(RVA = "0x1350888", Offset = "0x1350888", VA = "0x1350888")]
		public void Start()
		{
		}

		[Address(RVA = "0x1350814", Offset = "0x1350814", VA = "0x1350814")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x88B84C", Offset = "0x88B84C")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Address(RVA = "0x1350F60", Offset = "0x1350F60", VA = "0x1350F60")]
		private void Update()
		{
		}

		[Address(RVA = "0x13512FC", Offset = "0x13512FC", VA = "0x13512FC")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x13513CC", Offset = "0x13513CC", VA = "0x13513CC")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x1351660", Offset = "0x1351660", VA = "0x1351660")]
		private void AfterLastIK()
		{
		}

		[Address(RVA = "0x1351460", Offset = "0x1351460", VA = "0x1351460")]
		private void AfterAnimation()
		{
		}

		[Address(RVA = "0x135161C", Offset = "0x135161C", VA = "0x135161C")]
		private void OnFinalPose()
		{
		}

		[Address(RVA = "0x1351714", Offset = "0x1351714", VA = "0x1351714")]
		private void RagdollEnabler()
		{
		}

		[Address(RVA = "0x1351694", Offset = "0x1351694", VA = "0x1351694")]
		private void RecordVelocities()
		{
		}

		[Address(RVA = "0x1350794", Offset = "0x1350794", VA = "0x1350794")]
		private void StoreLocalState()
		{
		}

		[Address(RVA = "0x135133C", Offset = "0x135133C", VA = "0x135133C")]
		private void FixTransforms(float weight)
		{
		}

		[Address(RVA = "0x1352154", Offset = "0x1352154", VA = "0x1352154")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x13522C0", Offset = "0x13522C0", VA = "0x13522C0")]
		public RagdollUtility()
		{
		}
	}
	public abstract class RotationLimit : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883A60", Offset = "0x883A60")]
		public Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		public Vector3 secondaryAxis
		{
			[Address(RVA = "0x13543AC", Offset = "0x13543AC", VA = "0x13543AC")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		public Vector3 crossAxis
		{
			[Address(RVA = "0x13543E8", Offset = "0x13543E8", VA = "0x13543E8")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		[Address(RVA = "0x1353FE8", Offset = "0x1353FE8", VA = "0x1353FE8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Address(RVA = "0x1354034", Offset = "0x1354034", VA = "0x1354034")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x13542C4", Offset = "0x13542C4", VA = "0x13542C4")]
		public bool Apply()
		{
			return default(bool);
		}

		[Address(RVA = "0x1354374", Offset = "0x1354374", VA = "0x1354374")]
		public void Disable()
		{
		}

		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Address(RVA = "0x13541D4", Offset = "0x13541D4", VA = "0x13541D4")]
		private void Awake()
		{
		}

		[Address(RVA = "0x13544B8", Offset = "0x13544B8", VA = "0x13544B8")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x13544BC", Offset = "0x13544BC", VA = "0x13544BC")]
		public void LogWarning(string message)
		{
		}

		[Address(RVA = "0x13544F0", Offset = "0x13544F0", VA = "0x13544F0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x13545D4", Offset = "0x13545D4", VA = "0x13545D4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1354854", Offset = "0x1354854", VA = "0x1354854")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Address(RVA = "0x1354910", Offset = "0x1354910", VA = "0x1354910")]
		protected RotationLimit()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DB98", Offset = "0x87DB98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DB98", Offset = "0x87DB98")]
	public class RotationLimitAngle : RotationLimit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883A70", Offset = "0x883A70")]
		public float limit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883A8C", Offset = "0x883A8C")]
		public float twistLimit;

		[Address(RVA = "0x1354988", Offset = "0x1354988", VA = "0x1354988")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B8B0", Offset = "0x88B8B0")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x13549D4", Offset = "0x13549D4", VA = "0x13549D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B8E8", Offset = "0x88B8E8")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1354A20", Offset = "0x1354A20", VA = "0x1354A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B920", Offset = "0x88B920")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x1354A6C", Offset = "0x1354A6C", VA = "0x1354A6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B958", Offset = "0x88B958")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x1354AB8", Offset = "0x1354AB8", VA = "0x1354AB8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1354B70", Offset = "0x1354B70", VA = "0x1354B70")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1354DB8", Offset = "0x1354DB8", VA = "0x1354DB8")]
		public RotationLimitAngle()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DBF8", Offset = "0x87DBF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DBF8", Offset = "0x87DBF8")]
	public class RotationLimitHinge : RotationLimit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883AA8", Offset = "0x883AA8")]
		public float zeroAxisDisplayOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Address(RVA = "0x1354DC8", Offset = "0x1354DC8", VA = "0x1354DC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B990", Offset = "0x88B990")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x1354E14", Offset = "0x1354E14", VA = "0x1354E14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88B9C8", Offset = "0x88B9C8")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1354E60", Offset = "0x1354E60", VA = "0x1354E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BA00", Offset = "0x88BA00")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x1354EAC", Offset = "0x1354EAC", VA = "0x1354EAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BA38", Offset = "0x88BA38")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x1354EF8", Offset = "0x1354EF8", VA = "0x1354EF8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1354F20", Offset = "0x1354F20", VA = "0x1354F20")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1355220", Offset = "0x1355220", VA = "0x1355220")]
		public RotationLimitHinge()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DC58", Offset = "0x87DC58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DC58", Offset = "0x87DC58")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		public class ReachCone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			public Vector3 o
			{
				[Address(RVA = "0x1357714", Offset = "0x1357714", VA = "0x1357714")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public Vector3 a
			{
				[Address(RVA = "0x135775C", Offset = "0x135775C", VA = "0x135775C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public Vector3 b
			{
				[Address(RVA = "0x13577A8", Offset = "0x13577A8", VA = "0x13577A8")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public Vector3 c
			{
				[Address(RVA = "0x13577F4", Offset = "0x13577F4", VA = "0x13577F4")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
			}

			public bool isValid
			{
				[Address(RVA = "0x1356650", Offset = "0x1356650", VA = "0x1356650")]
				get
				{
					return default(bool);
				}
			}

			[Address(RVA = "0x1356DF8", Offset = "0x1356DF8", VA = "0x1356DF8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Address(RVA = "0x1356FA8", Offset = "0x1356FA8", VA = "0x1356FA8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		public class LimitPoint
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Address(RVA = "0x1356660", Offset = "0x1356660", VA = "0x1356660")]
			public LimitPoint()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883AB8", Offset = "0x883AB8")]
		public float twistLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883AD4", Offset = "0x883AD4")]
		public int smoothIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883AEC", Offset = "0x883AEC")]
		public LimitPoint[] points;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883B24", Offset = "0x883B24")]
		public Vector3[] P;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883B5C", Offset = "0x883B5C")]
		public ReachCone[] reachCones;

		[Address(RVA = "0x13552A8", Offset = "0x13552A8", VA = "0x13552A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BA70", Offset = "0x88BA70")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x13552F4", Offset = "0x13552F4", VA = "0x13552F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BAA8", Offset = "0x88BAA8")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1355340", Offset = "0x1355340", VA = "0x1355340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BAE0", Offset = "0x88BAE0")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x135538C", Offset = "0x135538C", VA = "0x135538C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BB18", Offset = "0x88BB18")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x13553D8", Offset = "0x13553D8", VA = "0x13553D8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Address(RVA = "0x1355A14", Offset = "0x1355A14", VA = "0x1355A14", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1355B10", Offset = "0x1355B10", VA = "0x1355B10")]
		private void Start()
		{
		}

		[Address(RVA = "0x13561DC", Offset = "0x13561DC", VA = "0x13561DC")]
		public void ResetToDefault()
		{
		}

		[Address(RVA = "0x135547C", Offset = "0x135547C", VA = "0x135547C")]
		public void BuildReachCones()
		{
		}

		[Address(RVA = "0x13566E4", Offset = "0x13566E4", VA = "0x13566E4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Address(RVA = "0x1357168", Offset = "0x1357168", VA = "0x1357168")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Address(RVA = "0x13571AC", Offset = "0x13571AC", VA = "0x13571AC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x13572F4", Offset = "0x13572F4", VA = "0x13572F4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Address(RVA = "0x1355E70", Offset = "0x1355E70", VA = "0x1355E70")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1357484", Offset = "0x1357484", VA = "0x1357484")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Address(RVA = "0x13576B0", Offset = "0x13576B0", VA = "0x13576B0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87DCB8", Offset = "0x87DCB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87DCB8", Offset = "0x87DCB8")]
	public class RotationLimitSpline : RotationLimit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883B94", Offset = "0x883B94")]
		public float twistLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x883BB0", Offset = "0x883BB0")]
		public AnimationCurve spline;

		[Address(RVA = "0x1357840", Offset = "0x1357840", VA = "0x1357840")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BB50", Offset = "0x88BB50")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x135788C", Offset = "0x135788C", VA = "0x135788C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BB88", Offset = "0x88BB88")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x13578D8", Offset = "0x13578D8", VA = "0x13578D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BBC0", Offset = "0x88BBC0")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x1357924", Offset = "0x1357924", VA = "0x1357924")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x88BBF8", Offset = "0x88BBF8")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x1357970", Offset = "0x1357970", VA = "0x1357970")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Address(RVA = "0x13579A8", Offset = "0x13579A8", VA = "0x13579A8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1357A60", Offset = "0x1357A60", VA = "0x1357A60")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}

		[Address(RVA = "0x1357D98", Offset = "0x1357D98", VA = "0x1357D98")]
		public RotationLimitSpline()
		{
		}
	}
	public class AimController : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDC8", Offset = "0x87DDC8")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x10C25E8", Offset = "0x10C25E8", VA = "0x10C25E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x10C2658", Offset = "0x10C2658", VA = "0x10C2658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x10C2374", Offset = "0x10C2374", VA = "0x10C2374")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Address(RVA = "0x10C246C", Offset = "0x10C246C", VA = "0x10C246C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x10C2470", Offset = "0x10C2470", VA = "0x10C2470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x10C25F0", Offset = "0x10C25F0", VA = "0x10C25F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883BE8", Offset = "0x883BE8")]
		public AimIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883C20", Offset = "0x883C20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883C20", Offset = "0x883C20")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x883C74", Offset = "0x883C74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883C74", Offset = "0x883C74")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883CD4", Offset = "0x883CD4")]
		public float targetSwitchSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883D0C", Offset = "0x883D0C")]
		public float weightSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x883D44", Offset = "0x883D44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883D44", Offset = "0x883D44")]
		public bool smoothTurnTowardsTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883DA4", Offset = "0x883DA4")]
		public float maxRadiansDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883DDC", Offset = "0x883DDC")]
		public float maxMagnitudeDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883E14", Offset = "0x883E14")]
		public float slerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883E4C", Offset = "0x883E4C")]
		public Vector3 pivotOffsetFromRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883E84", Offset = "0x883E84")]
		public float minDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883EBC", Offset = "0x883EBC")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x883EF4", Offset = "0x883EF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883EF4", Offset = "0x883EF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x883EF4", Offset = "0x883EF4")]
		public float maxRootAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883F70", Offset = "0x883F70")]
		public bool turnToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883FA8", Offset = "0x883FA8")]
		public float turnToTargetTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x883FE0", Offset = "0x883FE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x883FE0", Offset = "0x883FE0")]
		public bool useAnimatedAimDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884040", Offset = "0x884040")]
		public Vector3 animatedAimDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		private Vector3 pivot
		{
			[Address(RVA = "0x10C1288", Offset = "0x10C1288", VA = "0x10C1288")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		[Address(RVA = "0x10C1158", Offset = "0x10C1158", VA = "0x10C1158")]
		private void Start()
		{
		}

		[Address(RVA = "0x10C1400", Offset = "0x10C1400", VA = "0x10C1400")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x10C1D30", Offset = "0x10C1D30", VA = "0x10C1D30")]
		private void ApplyMinDistance()
		{
		}

		[Address(RVA = "0x10C1EFC", Offset = "0x10C1EFC", VA = "0x10C1EFC")]
		private void RootRotation()
		{
		}

		[Address(RVA = "0x10C2300", Offset = "0x10C2300", VA = "0x10C2300")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x88BC30", Offset = "0x88BC30")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Address(RVA = "0x10C23A0", Offset = "0x10C23A0", VA = "0x10C23A0")]
		public AimController()
		{
		}
	}
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		public class Pose
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Address(RVA = "0x10C29AC", Offset = "0x10C29AC", VA = "0x10C29AC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Address(RVA = "0x10C2D40", Offset = "0x10C2D40", VA = "0x10C2D40")]
			public void SetAngleBuffer(float value)
			{
			}

			[Address(RVA = "0x10C2DB0", Offset = "0x10C2DB0", VA = "0x10C2DB0")]
			public Pose()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Address(RVA = "0x10C284C", Offset = "0x10C284C", VA = "0x10C284C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Address(RVA = "0x10C2C48", Offset = "0x10C2C48", VA = "0x10C2C48")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Address(RVA = "0x10C2D48", Offset = "0x10C2D48", VA = "0x10C2D48")]
		public AimPoser()
		{
		}
	}
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888530", Offset = "0x888530")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888568", Offset = "0x888568")]
				public float weight;

				[Address(RVA = "0x10C34AC", Offset = "0x10C34AC", VA = "0x10C34AC")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887558", Offset = "0x887558")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887590", Offset = "0x887590")]
			public Transform relativeTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8875C8", Offset = "0x8875C8")]
			public EffectorLink[] effectorLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887600", Offset = "0x887600")]
			public float verticalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887638", Offset = "0x887638")]
			public float horizontalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887670", Offset = "0x887670")]
			public float speed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Address(RVA = "0x10C2F2C", Offset = "0x10C2F2C", VA = "0x10C2F2C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Address(RVA = "0x10C3484", Offset = "0x10C3484", VA = "0x10C3484")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x10C3494", Offset = "0x10C3494", VA = "0x10C3494")]
			public Body()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884078", Offset = "0x884078")]
		public Body[] bodies;

		[Address(RVA = "0x10C2DCC", Offset = "0x10C2DCC", VA = "0x10C2DCC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x10C347C", Offset = "0x10C347C", VA = "0x10C347C")]
		public Amplifier()
		{
		}
	}
	public class BodyTilt : OffsetModifier
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8840B0", Offset = "0x8840B0")]
		public float tiltSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8840E8", Offset = "0x8840E8")]
		public float tiltSensitivity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884120", Offset = "0x884120")]
		public OffsetPose poseLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884158", Offset = "0x884158")]
		public OffsetPose poseRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Address(RVA = "0x10C522C", Offset = "0x10C522C", VA = "0x10C522C", Slot = "5")]
		protected override void Start()
		{
		}

		[Address(RVA = "0x10C527C", Offset = "0x10C527C", VA = "0x10C527C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x10C54E8", Offset = "0x10C54E8", VA = "0x10C54E8")]
		public BodyTilt()
		{
		}
	}
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		public abstract class HitPoint
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8876A8", Offset = "0x8876A8")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8876E0", Offset = "0x8876E0")]
			public Collider collider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887718", Offset = "0x887718")]
			[SerializeField]
			private float crossFadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887764", Offset = "0x887764")]
			private float <crossFader>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887774", Offset = "0x887774")]
			private float <timer>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887784", Offset = "0x887784")]
			private Vector3 <force>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887794", Offset = "0x887794")]
			private Vector3 <point>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			public bool inProgress
			{
				[Address(RVA = "0x16E1C48", Offset = "0x16E1C48", VA = "0x16E1C48")]
				get
				{
					return default(bool);
				}
			}

			protected float crossFader
			{
				[Address(RVA = "0x16E2280", Offset = "0x16E2280", VA = "0x16E2280")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C32C", Offset = "0x88C32C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x16E2288", Offset = "0x16E2288", VA = "0x16E2288")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C33C", Offset = "0x88C33C")]
				private set
				{
				}
			}

			protected float timer
			{
				[Address(RVA = "0x16E2278", Offset = "0x16E2278", VA = "0x16E2278")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C34C", Offset = "0x88C34C")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x16E2290", Offset = "0x16E2290", VA = "0x16E2290")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C35C", Offset = "0x88C35C")]
				private set
				{
				}
			}

			protected Vector3 force
			{
				[Address(RVA = "0x16E2298", Offset = "0x16E2298", VA = "0x16E2298")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C36C", Offset = "0x88C36C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x16E22A4", Offset = "0x16E22A4", VA = "0x16E22A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C37C", Offset = "0x88C37C")]
				private set
				{
				}
			}

			protected Vector3 point
			{
				[Address(RVA = "0x16E22B0", Offset = "0x16E22B0", VA = "0x16E22B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C38C", Offset = "0x88C38C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x16E22BC", Offset = "0x16E22BC", VA = "0x16E22BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C39C", Offset = "0x88C39C")]
				private set
				{
				}
			}

			[Address(RVA = "0x16E2144", Offset = "0x16E2144", VA = "0x16E2144")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Address(RVA = "0x16E1D90", Offset = "0x16E1D90", VA = "0x16E1D90")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			protected abstract float GetLength();

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Address(RVA = "0x16E22C8", Offset = "0x16E22C8", VA = "0x16E22C8")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8885A0", Offset = "0x8885A0")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8885D8", Offset = "0x8885D8")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Address(RVA = "0x16E2E1C", Offset = "0x16E2E1C", VA = "0x16E2E1C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Address(RVA = "0x16E2BB8", Offset = "0x16E2BB8", VA = "0x16E2BB8")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0x16E3188", Offset = "0x16E3188", VA = "0x16E3188")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8877A4", Offset = "0x8877A4")]
			public AnimationCurve offsetInForceDirection;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8877DC", Offset = "0x8877DC")]
			public AnimationCurve offsetInUpDirection;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887814", Offset = "0x887814")]
			public EffectorLink[] effectorLinks;

			[Address(RVA = "0x16E2930", Offset = "0x16E2930", VA = "0x16E2930", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Address(RVA = "0x16E2B30", Offset = "0x16E2B30", VA = "0x16E2B30", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0x16E2BCC", Offset = "0x16E2BCC", VA = "0x16E2BCC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Address(RVA = "0x16E2F64", Offset = "0x16E2F64", VA = "0x16E2F64")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			public class BoneLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888610", Offset = "0x888610")]
				public Transform bone;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888648", Offset = "0x888648")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888648", Offset = "0x888648")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Address(RVA = "0x16E2708", Offset = "0x16E2708", VA = "0x16E2708")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Address(RVA = "0x16E2448", Offset = "0x16E2448", VA = "0x16E2448")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0x16E28A8", Offset = "0x16E28A8", VA = "0x16E28A8")]
				public BoneLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88784C", Offset = "0x88784C")]
			public AnimationCurve aroundCenterOfMass;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887884", Offset = "0x887884")]
			public BoneLink[] boneLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Address(RVA = "0x16E22DC", Offset = "0x16E22DC", VA = "0x16E22DC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Address(RVA = "0x16E23B8", Offset = "0x16E23B8", VA = "0x16E23B8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0x16E2464", Offset = "0x16E2464", VA = "0x16E2464", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Address(RVA = "0x16E2894", Offset = "0x16E2894", VA = "0x16E2894")]
			public HitPointBone()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884190", Offset = "0x884190")]
		public HitPointEffector[] effectorHitPoints;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8841C8", Offset = "0x8841C8")]
		public HitPointBone[] boneHitPoints;

		public bool inProgress
		{
			[Address(RVA = "0x16E1B4C", Offset = "0x16E1B4C", VA = "0x16E1B4C")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x16E1C5C", Offset = "0x16E1C5C", VA = "0x16E1C5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x16E1EDC", Offset = "0x16E1EDC", VA = "0x16E1EDC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Address(RVA = "0x16E2270", Offset = "0x16E2270", VA = "0x16E2270")]
		public HitReaction()
		{
		}
	}
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		public abstract class Offset
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8878BC", Offset = "0x8878BC")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8878F4", Offset = "0x8878F4")]
			public Collider collider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88792C", Offset = "0x88792C")]
			[SerializeField]
			private float crossFadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887978", Offset = "0x887978")]
			private float <crossFader>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887988", Offset = "0x887988")]
			private float <timer>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x887998", Offset = "0x887998")]
			private Vector3 <force>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8879A8", Offset = "0x8879A8")]
			private Vector3 <point>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			protected float crossFader
			{
				[Address(RVA = "0x16E37C0", Offset = "0x16E37C0", VA = "0x16E37C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C3AC", Offset = "0x88C3AC")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x16E37C8", Offset = "0x16E37C8", VA = "0x16E37C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C3BC", Offset = "0x88C3BC")]
				private set
				{
				}
			}

			protected float timer
			{
				[Address(RVA = "0x16E37D0", Offset = "0x16E37D0", VA = "0x16E37D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C3CC", Offset = "0x88C3CC")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x16E37D8", Offset = "0x16E37D8", VA = "0x16E37D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C3DC", Offset = "0x88C3DC")]
				private set
				{
				}
			}

			protected Vector3 force
			{
				[Address(RVA = "0x16E37E0", Offset = "0x16E37E0", VA = "0x16E37E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C3EC", Offset = "0x88C3EC")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x16E37EC", Offset = "0x16E37EC", VA = "0x16E37EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C3FC", Offset = "0x88C3FC")]
				private set
				{
				}
			}

			protected Vector3 point
			{
				[Address(RVA = "0x16E37F8", Offset = "0x16E37F8", VA = "0x16E37F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C40C", Offset = "0x88C40C")]
				get
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					return default(Vector3);
				}
				[Address(RVA = "0x16E3804", Offset = "0x16E3804", VA = "0x16E3804")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88C41C", Offset = "0x88C41C")]
				private set
				{
				}
			}

			[Address(RVA = "0x16E3678", Offset = "0x16E3678", VA = "0x16E3678")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Address(RVA = "0x16E32B4", Offset = "0x16E32B4", VA = "0x16E32B4")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			protected abstract float GetLength(AnimationCurve[] curves);

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Address(RVA = "0x16E3810", Offset = "0x16E3810", VA = "0x16E3810")]
			protected Offset()
			{
			}
		}

		[Serializable]
		public class PositionOffset : Offset
		{
			[Serializable]
			public class PositionOffsetLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88869C", Offset = "0x88869C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8886D4", Offset = "0x8886D4")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Address(RVA = "0x16E3E50", Offset = "0x16E3E50", VA = "0x16E3E50")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Address(RVA = "0x16E3B94", Offset = "0x16E3B94", VA = "0x16E3B94")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0x16E3FA0", Offset = "0x16E3FA0", VA = "0x16E3FA0")]
				public PositionOffsetLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8879B8", Offset = "0x8879B8")]
			public int forceDirCurveIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8879F0", Offset = "0x8879F0")]
			public int upDirCurveIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887A28", Offset = "0x887A28")]
			public PositionOffsetLink[] offsetLinks;

			[Address(RVA = "0x16E3824", Offset = "0x16E3824", VA = "0x16E3824", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Address(RVA = "0x16E3B0C", Offset = "0x16E3B0C", VA = "0x16E3B0C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0x16E3BA8", Offset = "0x16E3BA8", VA = "0x16E3BA8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Address(RVA = "0x16E3F84", Offset = "0x16E3F84", VA = "0x16E3F84")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		public class RotationOffset : Offset
		{
			[Serializable]
			public class RotationOffsetLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88870C", Offset = "0x88870C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888744", Offset = "0x888744")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888744", Offset = "0x888744")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Address(RVA = "0x16E451C", Offset = "0x16E451C", VA = "0x16E451C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Address(RVA = "0x16E419C", Offset = "0x16E419C", VA = "0x16E419C")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0x16E4694", Offset = "0x16E4694", VA = "0x16E4694")]
				public RotationOffsetLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887A60", Offset = "0x887A60")]
			public int curveIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887A98", Offset = "0x887A98")]
			public RotationOffsetLink[] offsetLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Address(RVA = "0x16E3FA8", Offset = "0x16E3FA8", VA = "0x16E3FA8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Address(RVA = "0x16E410C", Offset = "0x16E410C", VA = "0x16E410C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0x16E41B8", Offset = "0x16E41B8", VA = "0x16E41B8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Address(RVA = "0x16E4680", Offset = "0x16E4680", VA = "0x16E4680")]
			public RotationOffset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884200", Offset = "0x884200")]
		public PositionOffset[] positionOffsets;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884238", Offset = "0x884238")]
		public RotationOffset[] rotationOffsets;

		[Address(RVA = "0x16E3190", Offset = "0x16E3190", VA = "0x16E3190", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x16E3408", Offset = "0x16E3408", VA = "0x16E3408")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Address(RVA = "0x16E37B8", Offset = "0x16E37B8", VA = "0x16E37B8")]
		public HitReactionVRIK()
		{
		}
	}
	public class Inertia : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888798", Offset = "0x888798")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8887D0", Offset = "0x8887D0")]
				public float weight;

				[Address(RVA = "0x1762C7C", Offset = "0x1762C7C", VA = "0x1762C7C")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887AD0", Offset = "0x887AD0")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887B08", Offset = "0x887B08")]
			public EffectorLink[] effectorLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887B40", Offset = "0x887B40")]
			public float speed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887B78", Offset = "0x887B78")]
			public float acceleration;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887BB0", Offset = "0x887BB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887BB0", Offset = "0x887BB0")]
			public float matchVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887C04", Offset = "0x887C04")]
			public float gravity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Address(RVA = "0x17626CC", Offset = "0x17626CC", VA = "0x17626CC")]
			public void Reset()
			{
			}

			[Address(RVA = "0x1762890", Offset = "0x1762890", VA = "0x1762890")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Address(RVA = "0x1762C60", Offset = "0x1762C60", VA = "0x1762C60")]
			public Body()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884270", Offset = "0x884270")]
		public Body[] bodies;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8842A8", Offset = "0x8842A8")]
		public OffsetLimits[] limits;

		[Address(RVA = "0x176263C", Offset = "0x176263C", VA = "0x176263C")]
		public void ResetBodies()
		{
		}

		[Address(RVA = "0x17627BC", Offset = "0x17627BC", VA = "0x17627BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x1762C58", Offset = "0x1762C58", VA = "0x1762C58")]
		public Inertia()
		{
		}
	}
	public class LookAtController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8842E0", Offset = "0x8842E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8842E0", Offset = "0x8842E0")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884340", Offset = "0x884340")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884358", Offset = "0x884358")]
		public float targetSwitchSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884390", Offset = "0x884390")]
		public float weightSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8843C8", Offset = "0x8843C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8843C8", Offset = "0x8843C8")]
		public bool smoothTurnTowardsTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884428", Offset = "0x884428")]
		public float maxRadiansDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884460", Offset = "0x884460")]
		public float maxMagnitudeDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884498", Offset = "0x884498")]
		public float slerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8844D0", Offset = "0x8844D0")]
		public Vector3 pivotOffsetFromRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884508", Offset = "0x884508")]
		public float minDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x884540", Offset = "0x884540")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884540", Offset = "0x884540")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x884540", Offset = "0x884540")]
		public float maxRootAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		private Vector3 pivot
		{
			[Address(RVA = "0x134D6C0", Offset = "0x134D6C0", VA = "0x134D6C0")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
		}

		[Address(RVA = "0x134D5B4", Offset = "0x134D5B4", VA = "0x134D5B4")]
		private void Start()
		{
		}

		[Address(RVA = "0x134D838", Offset = "0x134D838", VA = "0x134D838")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x134E06C", Offset = "0x134E06C", VA = "0x134E06C")]
		private void ApplyMinDistance()
		{
		}

		[Address(RVA = "0x134E238", Offset = "0x134E238", VA = "0x134E238")]
		private void RootRotation()
		{
		}

		[Address(RVA = "0x134E5E8", Offset = "0x134E5E8", VA = "0x134E5E8")]
		public LookAtController()
		{
		}
	}
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		public class OffsetLimits
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887C3C", Offset = "0x887C3C")]
			public FullBodyBipedEffector effector;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887C74", Offset = "0x887C74")]
			public float spring;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887CAC", Offset = "0x887CAC")]
			public bool x;

			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887CE4", Offset = "0x887CE4")]
			public bool y;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887D1C", Offset = "0x887D1C")]
			public bool z;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887D54", Offset = "0x887D54")]
			public float minX;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887D8C", Offset = "0x887D8C")]
			public float maxX;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887DC4", Offset = "0x887DC4")]
			public float minY;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887DFC", Offset = "0x887DFC")]
			public float maxY;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887E34", Offset = "0x887E34")]
			public float minZ;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887E6C", Offset = "0x887E6C")]
			public float maxZ;

			[Address(RVA = "0x134EB24", Offset = "0x134EB24", VA = "0x134EB24")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Address(RVA = "0x134F140", Offset = "0x134F140", VA = "0x134F140")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Address(RVA = "0x134F170", Offset = "0x134F170", VA = "0x134F170")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Address(RVA = "0x134F248", Offset = "0x134F248", VA = "0x134F248")]
			public OffsetLimits()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDD8", Offset = "0x87DDD8")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x134F0C8", Offset = "0x134F0C8", VA = "0x134F0C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x134F138", Offset = "0x134F138", VA = "0x134F138", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x134E900", Offset = "0x134E900", VA = "0x134E900")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Address(RVA = "0x134EF18", Offset = "0x134EF18", VA = "0x134EF18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x134EF1C", Offset = "0x134EF1C", VA = "0x134EF1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x134F0D0", Offset = "0x134F0D0", VA = "0x134F0D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8845BC", Offset = "0x8845BC")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8845F4", Offset = "0x8845F4")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		protected float deltaTime
		{
			[Address(RVA = "0x134E834", Offset = "0x134E834", VA = "0x134E834")]
			get
			{
				return default(float);
			}
		}

		protected abstract void OnModifyOffset();

		[Address(RVA = "0x134E860", Offset = "0x134E860", VA = "0x134E860", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0x134E88C", Offset = "0x134E88C", VA = "0x134E88C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x88BC94", Offset = "0x88BC94")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Address(RVA = "0x134E92C", Offset = "0x134E92C", VA = "0x134E92C")]
		private void ModifyOffset()
		{
		}

		[Address(RVA = "0x134EA38", Offset = "0x134EA38", VA = "0x134EA38")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Address(RVA = "0x134EDA8", Offset = "0x134EDA8", VA = "0x134EDA8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Address(RVA = "0x134EF08", Offset = "0x134EF08", VA = "0x134EF08")]
		protected OffsetModifier()
		{
		}
	}
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDE8", Offset = "0x87DDE8")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x134F774", Offset = "0x134F774", VA = "0x134F774", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x134F7E4", Offset = "0x134F7E4", VA = "0x134F7E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x134F31C", Offset = "0x134F31C", VA = "0x134F31C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Address(RVA = "0x134F5C4", Offset = "0x134F5C4", VA = "0x134F5C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0x134F5C8", Offset = "0x134F5C8", VA = "0x134F5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0x134F77C", Offset = "0x134F77C", VA = "0x134F77C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88462C", Offset = "0x88462C")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884664", Offset = "0x884664")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		protected float deltaTime
		{
			[Address(RVA = "0x134F250", Offset = "0x134F250", VA = "0x134F250")]
			get
			{
				return default(float);
			}
		}

		protected abstract void OnModifyOffset();

		[Address(RVA = "0x134F27C", Offset = "0x134F27C", VA = "0x134F27C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0x134F2A8", Offset = "0x134F2A8", VA = "0x134F2A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x88BCF8", Offset = "0x88BCF8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Address(RVA = "0x134F348", Offset = "0x134F348", VA = "0x134F348")]
		private void ModifyOffset()
		{
		}

		[Address(RVA = "0x134F454", Offset = "0x134F454", VA = "0x134F454", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Address(RVA = "0x134F5B4", Offset = "0x134F5B4", VA = "0x134F5B4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		public class EffectorLink
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Address(RVA = "0x134F904", Offset = "0x134F904", VA = "0x134F904")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Address(RVA = "0x134FE40", Offset = "0x134FE40", VA = "0x134FE40")]
			public EffectorLink()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Address(RVA = "0x134F7EC", Offset = "0x134F7EC", VA = "0x134F7EC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Address(RVA = "0x134FCF8", Offset = "0x134FCF8", VA = "0x134FCF8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Address(RVA = "0x134FDE0", Offset = "0x134FDE0", VA = "0x134FDE0")]
		public OffsetPose()
		{
		}
	}
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		public class Avoider
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888808", Offset = "0x888808")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888840", Offset = "0x888840")]
				public float weight;

				[Address(RVA = "0x1350598", Offset = "0x1350598", VA = "0x1350598")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887EA4", Offset = "0x887EA4")]
			public Transform[] raycastFrom;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887EDC", Offset = "0x887EDC")]
			public Transform raycastTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887F14", Offset = "0x887F14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x887F14", Offset = "0x887F14")]
			public float raycastRadius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887F68", Offset = "0x887F68")]
			public EffectorLink[] effectors;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887FA0", Offset = "0x887FA0")]
			public float smoothTimeIn;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x887FD8", Offset = "0x887FD8")]
			public float smoothTimeOut;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888010", Offset = "0x888010")]
			public LayerMask layers;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Address(RVA = "0x134FEFC", Offset = "0x134FEFC", VA = "0x134FEFC")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Address(RVA = "0x1350124", Offset = "0x1350124", VA = "0x1350124")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x1350308", Offset = "0x1350308", VA = "0x1350308")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}

			[Address(RVA = "0x135057C", Offset = "0x135057C", VA = "0x135057C")]
			public Avoider()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88469C", Offset = "0x88469C")]
		public Avoider[] avoiders;

		[Address(RVA = "0x134FE48", Offset = "0x134FE48", VA = "0x134FE48", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x1350114", Offset = "0x1350114", VA = "0x1350114")]
		public PenetrationAvoidance()
		{
		}
	}
	public class Recoil : OffsetModifier
	{
		[Serializable]
		public class RecoilOffset
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888878", Offset = "0x888878")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8888B0", Offset = "0x8888B0")]
				public float weight;

				[Address(RVA = "0x1353FE0", Offset = "0x1353FE0", VA = "0x1353FE0")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888048", Offset = "0x888048")]
			public Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888080", Offset = "0x888080")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888080", Offset = "0x888080")]
			public float additivity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8880D4", Offset = "0x8880D4")]
			public float maxAdditiveOffsetMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88810C", Offset = "0x88810C")]
			public EffectorLink[] effectorLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Address(RVA = "0x1352990", Offset = "0x1352990", VA = "0x1352990")]
			public void Start()
			{
			}

			[Address(RVA = "0x1353700", Offset = "0x1353700", VA = "0x1353700")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Address(RVA = "0x1353FC8", Offset = "0x1353FC8", VA = "0x1353FC8")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		public enum Handedness
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Right,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Left
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8846D4", Offset = "0x8846D4")]
		public AimIK aimIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88470C", Offset = "0x88470C")]
		public bool aimIKSolvedLast;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884744", Offset = "0x884744")]
		public Handedness handedness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88477C", Offset = "0x88477C")]
		public bool twoHanded;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8847B4", Offset = "0x8847B4")]
		public AnimationCurve recoilWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8847EC", Offset = "0x8847EC")]
		public float magnitudeRandom;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884824", Offset = "0x884824")]
		public Vector3 rotationRandom;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88485C", Offset = "0x88485C")]
		public Vector3 handRotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884894", Offset = "0x884894")]
		public float blendTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8848CC", Offset = "0x8848CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8848CC", Offset = "0x8848CC")]
		public RecoilOffset[] offsets;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x88491C", Offset = "0x88491C")]
		public Quaternion rotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		public bool isFinished
		{
			[Address(RVA = "0x135272C", Offset = "0x135272C", VA = "0x135272C")]
			get
			{
				return default(bool);
			}
		}

		private IKEffector primaryHandEffector
		{
			[Address(RVA = "0x13539E8", Offset = "0x13539E8", VA = "0x13539E8")]
			get
			{
				return null;
			}
		}

		private IKEffector secondaryHandEffector
		{
			[Address(RVA = "0x1353A48", Offset = "0x1353A48", VA = "0x1353A48")]
			get
			{
				return null;
			}
		}

		private Transform primaryHand
		{
			[Address(RVA = "0x1353990", Offset = "0x1353990", VA = "0x1353990")]
			get
			{
				return null;
			}
		}

		private Transform secondaryHand
		{
			[Address(RVA = "0x13539BC", Offset = "0x13539BC", VA = "0x13539BC")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x135275C", Offset = "0x135275C", VA = "0x135275C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Address(RVA = "0x1352788", Offset = "0x1352788", VA = "0x1352788")]
		public void Fire(float magnitude)
		{
		}

		[Address(RVA = "0x1352A40", Offset = "0x1352A40", VA = "0x1352A40", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0x1353AA8", Offset = "0x1353AA8", VA = "0x1353AA8")]
		private void AfterFBBIK()
		{
		}

		[Address(RVA = "0x1353C44", Offset = "0x1353C44", VA = "0x1353C44")]
		private void AfterAimIK()
		{
		}

		[Address(RVA = "0x1353CA0", Offset = "0x1353CA0", VA = "0x1353CA0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Address(RVA = "0x1353F14", Offset = "0x1353F14", VA = "0x1353F14")]
		public Recoil()
		{
		}
	}
	public class ShoulderRotator : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88492C", Offset = "0x88492C")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x884964", Offset = "0x884964")]
		public float offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Address(RVA = "0x1357DA4", Offset = "0x1357DA4", VA = "0x1357DA4")]
		private void Start()
		{
		}

		[Address(RVA = "0x1357EE0", Offset = "0x1357EE0", VA = "0x1357EE0")]
		private void RotateShoulders()
		{
		}

		[Address(RVA = "0x1357FF8", Offset = "0x1357FF8", VA = "0x1357FF8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Address(RVA = "0x1358590", Offset = "0x1358590", VA = "0x1358590")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Address(RVA = "0x13585F4", Offset = "0x13585F4", VA = "0x13585F4")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x1358754", Offset = "0x1358754", VA = "0x1358754")]
		public ShoulderRotator()
		{
		}
	}
	public static class VRIKCalibrator
	{
		[Serializable]
		public class Settings
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888144", Offset = "0x888144")]
			public float scaleMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88817C", Offset = "0x88817C")]
			public Vector3 headTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8881B4", Offset = "0x8881B4")]
			public Vector3 headTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8881EC", Offset = "0x8881EC")]
			public Vector3 bodyTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888224", Offset = "0x888224")]
			public Vector3 bodyTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88825C", Offset = "0x88825C")]
			public Vector3 handTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888294", Offset = "0x888294")]
			public Vector3 handTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8882CC", Offset = "0x8882CC")]
			public Vector3 footTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888304", Offset = "0x888304")]
			public Vector3 footTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x88833C", Offset = "0x88833C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88833C", Offset = "0x88833C")]
			public Vector3 headOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x88838C", Offset = "0x88838C")]
			public Vector3 handOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8883C4", Offset = "0x8883C4")]
			public float footForwardOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8883FC", Offset = "0x8883FC")]
			public float footInwardOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x888434", Offset = "0x888434")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888434", Offset = "0x888434")]
			public float footHeadingOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x888490", Offset = "0x888490")]
			public float pelvisPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8884A8", Offset = "0x8884A8")]
			public float pelvisRotationWeight;

			[Address(RVA = "0x135EBCC", Offset = "0x135EBCC", VA = "0x135EBCC")]
			public Settings()
			{
			}
		}

		[Serializable]
		public class CalibrationData
		{
			[Serializable]
			public class Target
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Address(RVA = "0x135D8A0", Offset = "0x135D8A0", VA = "0x135D8A0")]
				public Target(Transform t)
				{
				}

				[Address(RVA = "0x135E6DC", Offset = "0x135E6DC", VA = "0x135E6DC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Address(RVA = "0x135CC8C", Offset = "0x135CC8C", VA = "0x135CC8C")]
			public CalibrationData()
			{
			}
		}

		[Address(RVA = "0x135AF90", Offset = "0x135AF90", VA = "0x135AF90")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Address(RVA = "0x135B188", Offset = "0x135B188", VA = "0x135B188")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Address(RVA = "0x135CC94", Offset = "0x135CC94", VA = "0x135CC94")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Address(RVA = "0x135D994", Offset = "0x135D994", VA = "0x135D994")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Address(RVA = "0x135E780", Offset = "0x135E780", VA = "0x135E780")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	public class VRIKLODController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Address(RVA = "0x135ECC4", Offset = "0x135ECC4", VA = "0x135ECC4")]
		private void Start()
		{
		}

		[Address(RVA = "0x135ED1C", Offset = "0x135ED1C", VA = "0x135ED1C")]
		private void Update()
		{
		}

		[Address(RVA = "0x135ED68", Offset = "0x135ED68", VA = "0x135ED68")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Address(RVA = "0x135EF28", Offset = "0x135EF28", VA = "0x135EF28")]
		public VRIKLODController()
		{
		}
	}
	public class VRIKRootController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88499C", Offset = "0x88499C")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		public Vector3 pelvisTargetRight
		{
			[Address(RVA = "0x135D988", Offset = "0x135D988", VA = "0x135D988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BD5C", Offset = "0x88BD5C")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Vector3);
			}
			[Address(RVA = "0x135EF40", Offset = "0x135EF40", VA = "0x135EF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x88BD6C", Offset = "0x88BD6C")]
			private set
			{
			}
		}

		[Address(RVA = "0x135EF4C", Offset = "0x135EF4C", VA = "0x135EF4C")]
		private void Awake()
		{
		}

		[Address(RVA = "0x135D5FC", Offset = "0x135D5FC", VA = "0x135D5FC")]
		public void Calibrate()
		{
		}

		[Address(RVA = "0x135E9FC", Offset = "0x135E9FC", VA = "0x135E9FC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Address(RVA = "0x135F090", Offset = "0x135F090", VA = "0x135F090")]
		private void OnPreUpdate()
		{
		}

		[Address(RVA = "0x135F760", Offset = "0x135F760", VA = "0x135F760")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x135F8C0", Offset = "0x135F8C0", VA = "0x135F8C0")]
		public VRIKRootController()
		{
		}
	}
}
namespace DentedPixel
{
	public class LeanDummy
	{
		[Address(RVA = "0x140F420", Offset = "0x140F420", VA = "0x140F420")]
		public LeanDummy()
		{
		}
	}
}
