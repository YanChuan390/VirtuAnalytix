using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityAnalyticsHeatmap;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class GradientContainer : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Gradient ColorGradient;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12DB")]
	private static Color s_HighDensityColor;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private static Color s_MediumDensityColor;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E82C")]
	private static Color s_LowDensityColor;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x48B4BB8", Offset = "0x48B4BB8", VA = "0x48B4BB8")]
	public GradientContainer()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A0C1C", Offset = "0x10A0C1C")]
public class HeatmapController : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string dataPath;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string[] options;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int optionIndex;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12E3")]
	private int oldOptionIndex;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public float pointSize;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E83C")]
	private float oldPointSize;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private HeatmapDataParser m_DataParser;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<string, HeatPoint[]> m_Data;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Gradient gradient;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12EB")]
	private float m_MaxDensity;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private float m_MaxTime;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E84C")]
	private Vector3 m_LowSpace;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3 m_HighSpace;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3C69194", Offset = "0x3C69194", VA = "0x3C69194")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3C6927C", Offset = "0x3C6927C", VA = "0x3C6927C")]
	private void LoadData()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3C69368", Offset = "0x3C69368", VA = "0x3C69368")]
	private void parseHandler(Dictionary<string, HeatPoint[]> heatData, string[] options)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3C693CC", Offset = "0x3C693CC", VA = "0x3C693CC")]
	private void Render()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3C69C8C", Offset = "0x3C69C8C", VA = "0x3C69C8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3C698B8", Offset = "0x3C698B8", VA = "0x3C698B8")]
	private void SetLimits(HeatPoint[] points)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3C69EF0", Offset = "0x3C69EF0", VA = "0x3C69EF0")]
	public HeatmapController()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A0CCC", Offset = "0x10A0CCC")]
public class HeatmapMeshRenderer : MonoBehaviour, IHeatmapRenderer
{
	[Serializable]
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A2FEC", Offset = "0x10A2FEC")]
	private sealed class <>c
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<Vector3[], IEnumerable<Vector3>> <>9__54_0;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<Color32[], IEnumerable<Color32>> <>9__54_1;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x3C71EA4", Offset = "0x3C71EA4", VA = "0x3C71EA4")]
		public <>c()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x3C71ED4", Offset = "0x3C71ED4", VA = "0x3C71ED4")]
		internal IEnumerable<Vector3> <RenderSubmap>b__54_0(Vector3[] x)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x3C71EF8", Offset = "0x3C71EF8", VA = "0x3C71EF8")]
		internal IEnumerable<Color32> <RenderSubmap>b__54_1(Color32[] x)
		{
			return null;
		}
	}

	[Token(Token = "0x4000012")]
	private const int k_NotRendering = 0;

	[Token(Token = "0x4000013")]
	private const int k_BeginRenderer = 1;

	[Token(Token = "0x4000014")]
	private const int k_RenderInProgress = 2;

	[Token(Token = "0x4000015")]
	private const int k_UpdateMaterials = 4;

	[Token(Token = "0x4000016")]
	private const int k_VerticesPerMesh = 65000;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_HighThreshold;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowThreshold;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_StartTime;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12FB")]
	private float m_EndTime;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A33AC", Offset = "0x10A33AC")]
	private float m_ParticleSize;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E86C")]
	private bool m_Tips;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private HeatPoint[] m_Data;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_MaxDensity;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowX;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1303")]
	private float m_LowY;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private float m_LowZ;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E87C")]
	private float m_HighX;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_HighY;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_HighZ;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderShape m_RenderStyle;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130B")]
	private RenderDirection m_RenderDirection;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private Shader m_Shader;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E88C")]
	public Material[] m_Materials;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Gradient m_Gradient;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_RenderState;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<GameObject> m_GameObjects;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1313")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A33FC", Offset = "0x10A33FC")]
	private bool <allowRender>k__BackingField;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3438", Offset = "0x10A3438")]
	private int <currentPoints>k__BackingField;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E89C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3474", Offset = "0x10A3474")]
	private int <totalPoints>k__BackingField;

	[Token(Token = "0x17000001")]
	public float pointSize
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3C6AC04", Offset = "0x3C6AC04", VA = "0x3C6AC04", Slot = "12")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3C6AC34", Offset = "0x3C6AC34", VA = "0x3C6AC34", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public bool activateTips
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3C6ACB8", Offset = "0x3C6ACB8", VA = "0x3C6ACB8", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3C6ACFC", Offset = "0x3C6ACFC", VA = "0x3C6ACFC", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool allowRender
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3C6AFC4", Offset = "0x3C6AFC4", VA = "0x3C6AFC4", Slot = "14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AEE4C", Offset = "0x10AEE4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3C6B008", Offset = "0x3C6B008", VA = "0x3C6B008", Slot = "15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AEE88", Offset = "0x10AEE88")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public int currentPoints
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3C6B054", Offset = "0x3C6B054", VA = "0x3C6B054", Slot = "18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AEEC4", Offset = "0x10AEEC4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3C6B084", Offset = "0x3C6B084", VA = "0x3C6B084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AEF00", Offset = "0x10AEF00")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int totalPoints
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3C6B0BC", Offset = "0x3C6B0BC", VA = "0x3C6B0BC", Slot = "19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AEF3C", Offset = "0x10AEF3C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3C6B0EC", Offset = "0x3C6B0EC", VA = "0x3C6B0EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AEF78", Offset = "0x10AEF78")]
		set
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3C6A078", Offset = "0x3C6A078", VA = "0x3C6A078")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3C6A10C", Offset = "0x3C6A10C", VA = "0x3C6A10C", Slot = "4")]
	public void UpdatePointData(HeatPoint[] newData, float newMaxDensity)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3C6A170", Offset = "0x3C6A170", VA = "0x3C6A170", Slot = "5")]
	public void UpdateColors(Color[] colors)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3C6A188", Offset = "0x3C6A188", VA = "0x3C6A188", Slot = "7")]
	public void UpdateThresholds(float[] threshholds)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3C6A1A0", Offset = "0x3C6A1A0", VA = "0x3C6A1A0", Slot = "6")]
	public void UpdateGradient(Gradient gradient)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3C6A98C", Offset = "0x3C6A98C", VA = "0x3C6A98C", Slot = "8")]
	public void UpdateRenderMask(float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3C6B124", Offset = "0x3C6B124", VA = "0x3C6B124", Slot = "9")]
	public void UpdateTimeLimits(float startTime, float endTime)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3C6B1F4", Offset = "0x3C6B1F4", VA = "0x3C6B1F4", Slot = "11")]
	public void UpdateRenderStyle(RenderShape style, RenderDirection direction)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3C6B2B8", Offset = "0x3C6B2B8", VA = "0x3C6B2B8", Slot = "10")]
	public void RenderHeatmap()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3C6B910", Offset = "0x3C6B910", VA = "0x3C6B910")]
	private void CreatePoints()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x3C6CB20", Offset = "0x3C6CB20", VA = "0x3C6CB20")]
	private void RenderSubmap(GameObject go, List<HeatPoint> submap)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3C718E4", Offset = "0x3C718E4", VA = "0x3C718E4")]
	private Color32[] AddColorsToMesh(int count, HeatPoint pt)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3C6DCB8", Offset = "0x3C6DCB8", VA = "0x3C6DCB8")]
	private Vector3[] AddCubeVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3C6E460", Offset = "0x3C6E460", VA = "0x3C6E460")]
	private int[] AddCubeTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3C6E63C", Offset = "0x3C6E63C", VA = "0x3C6E63C")]
	private Vector3[] AddArrowVectorsToMesh(Vector3 position, Vector3 rotation)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3C6EE70", Offset = "0x3C6EE70", VA = "0x3C6EE70")]
	private int[] AddArrowTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3C6F04C", Offset = "0x3C6F04C", VA = "0x3C6F04C")]
	private Vector3[] AddSquareVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3C6F82C", Offset = "0x3C6F82C", VA = "0x3C6F82C")]
	private int[] AddSquareTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3C6FA78", Offset = "0x3C6FA78", VA = "0x3C6FA78")]
	private Vector3[] AddTriVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3C70070", Offset = "0x3C70070", VA = "0x3C70070")]
	private int[] AddTriTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3C701DC", Offset = "0x3C701DC", VA = "0x3C701DC")]
	private Vector3[] AddP2PVectorsToMesh(Vector3 fromVector, Vector3 toVector)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3C710F0", Offset = "0x3C710F0", VA = "0x3C710F0")]
	private int[] AddP2PTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3C6C92C", Offset = "0x3C6C92C", VA = "0x3C6C92C")]
	private bool hasData()
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3C6CA08", Offset = "0x3C6CA08", VA = "0x3C6CA08")]
	private int GetVecticesForShape()
	{
		return default(int);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3C71B80", Offset = "0x3C71B80", VA = "0x3C71B80")]
	private int GetTrianglesForShape()
	{
		return default(int);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3C71C98", Offset = "0x3C71C98", VA = "0x3C71C98")]
	private Color PickGradientColor(float percent)
	{
		return default(Color);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3C6A3C0", Offset = "0x3C6A3C0", VA = "0x3C6A3C0")]
	public static bool CompareGradients(Gradient gradient, Gradient otherGradient)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3C71D08", Offset = "0x3C71D08", VA = "0x3C71D08")]
	public HeatmapMeshRenderer()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A0D7C", Offset = "0x10A0D7C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A0D7C", Offset = "0x10A0D7C")]
[ExecuteInEditMode]
public class HeatmapSubmap : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131B")]
	public List<HeatPoint> m_PointData;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public int m_TrianglesPerShape;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3C71F1C", Offset = "0x3C71F1C", VA = "0x3C71F1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3C72054", Offset = "0x3C72054", VA = "0x3C72054")]
	public HeatmapSubmap()
	{
	}
}
[Token(Token = "0x2000006")]
public class MachBinding
{
	[Token(Token = "0x4000031")]
	private const double c_DeviceUptimeNotSupportedOnThisPlatform = -1.0;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass m_deviceStatusInterfaceClass;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3C8CDAC", Offset = "0x3C8CDAC", VA = "0x3C8CDAC")]
	public static double Uptime()
	{
		return default(double);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3C8CF7C", Offset = "0x3C8CF7C", VA = "0x3C8CF7C")]
	public static void InitMach()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3C8CF8C", Offset = "0x3C8CF8C", VA = "0x3C8CF8C")]
	public MachBinding()
	{
	}
}
[Token(Token = "0x2000007")]
public class MachTest : MonoBehaviour
{
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3C8D07C", Offset = "0x3C8D07C", VA = "0x3C8D07C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x3C8D160", Offset = "0x3C8D160", VA = "0x3C8D160")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x3C8D414", Offset = "0x3C8D414", VA = "0x3C8D414")]
	public static double GetDeviceUptime()
	{
		return default(double);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3C8D428", Offset = "0x3C8D428", VA = "0x3C8D428")]
	private void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3C8D458", Offset = "0x3C8D458", VA = "0x3C8D458")]
	public MachTest()
	{
	}
}
[Token(Token = "0x2000008")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject target;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float elapsedTime;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x44CC6CC", Offset = "0x44CC6CC", VA = "0x44CC6CC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x44CCAE4", Offset = "0x44CCAE4", VA = "0x44CCAE4")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000009")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3C86584", Offset = "0x3C86584", VA = "0x3C86584")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3C86628", Offset = "0x3C86628", VA = "0x3C86628")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000A")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1323")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E8BC")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3C895AC", Offset = "0x3C895AC", VA = "0x3C895AC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3C8974C", Offset = "0x3C8974C", VA = "0x3C8974C")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3C8A170", Offset = "0x3C8A170", VA = "0x3C8A170")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x200000B")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3C87A90", Offset = "0x3C87A90", VA = "0x3C87A90")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3C87B34", Offset = "0x3C87B34", VA = "0x3C87B34")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3028", Offset = "0x10A3028")]
	private sealed class <largeNumber>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578E8CC")]
		private int <>1__state;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x3C87184", Offset = "0x3C87184", VA = "0x3C87184", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x3C87254", Offset = "0x3C87254", VA = "0x3C87254", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x3C86C38", Offset = "0x3C86C38", VA = "0x3C86C38")]
		[DebuggerHidden]
		public <largeNumber>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x3C86DDC", Offset = "0x3C86DDC", VA = "0x3C86DDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x3C86DF0", Offset = "0x3C86DF0", VA = "0x3C86DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x3C871B4", Offset = "0x3C871B4", VA = "0x3C871B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject prefab;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x132B")]
	private MB3_MeshBaker mbd;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private GameObject[] objs;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3C86658", Offset = "0x3C86658", VA = "0x3C86658")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3C86B7C", Offset = "0x3C86B7C", VA = "0x3C86B7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AEFB4", Offset = "0x10AEFB4")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3C86C80", Offset = "0x3C86C80", VA = "0x3C86C80")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3C86D24", Offset = "0x3C86D24", VA = "0x3C86D24")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x200000D")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1333")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3C87284", Offset = "0x3C87284", VA = "0x3C87284")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3C87330", Offset = "0x3C87330", VA = "0x3C87330")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3C87474", Offset = "0x3C87474", VA = "0x3C87474")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x3C87518", Offset = "0x3C87518", VA = "0x3C87518")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x200000E")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public int axis;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x3C87548", Offset = "0x3C87548", VA = "0x3C87548")]
	private void Update()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3C87714", Offset = "0x3C87714", VA = "0x3C87714")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000F")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3C87744", Offset = "0x3C87744", VA = "0x3C87744")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3C877E8", Offset = "0x3C877E8", VA = "0x3C877E8")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x2000010")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E8DC")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x133B")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E8EC")]
	private GameObject swordInstance;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private GameObject glassesInstance;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private GameObject hatInstance;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3C87B64", Offset = "0x3C87B64", VA = "0x3C87B64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3C87E48", Offset = "0x3C87E48", VA = "0x3C87E48")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x3C892D4", Offset = "0x3C892D4", VA = "0x3C892D4")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x3C8957C", Offset = "0x3C8957C", VA = "0x3C8957C")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public class MB_AtlasesAndRects
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Texture2D[] atlases;

	[NonSerialized]
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1343")]
	public List<MB_MaterialAndUVRect> mat2rect_map;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public string[] texPropertyNames;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3C85520", Offset = "0x3C85520", VA = "0x3C85520")]
	public MB_AtlasesAndRects()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class MB_MultiMaterial
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E8FC")]
	public Material combinedMaterial;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<Material> sourceMaterials;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x3C733C0", Offset = "0x3C733C0", VA = "0x3C733C0")]
	public MB_MultiMaterial()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class MB_MaterialAndUVRect
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material material;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect atlasRect;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134B")]
	public Rect atlasSubrectMaterialOnly;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3C73158", Offset = "0x3C73158", VA = "0x3C73158")]
	public MB_MaterialAndUVRect(Material m, Rect destRect, Rect matTilingTransformRect)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3C87818", Offset = "0x3C87818", VA = "0x3C87818", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3C8788C", Offset = "0x3C8788C", VA = "0x3C8788C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000014")]
public class MB2_TextureBakeResults : ScriptableObject
{
	[Token(Token = "0x20000F8")]
	public class Material2AtlasRectangleMapper
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MB2_TextureBakeResults tbr;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] numTimesMatAppearsInAtlas;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MB_MaterialAndUVRect[] matsAndSrcUVRect;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x3C73F60", Offset = "0x3C73F60", VA = "0x3C73F60")]
		public Material2AtlasRectangleMapper(MB2_TextureBakeResults res)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x3C7474C", Offset = "0x3C7474C", VA = "0x3C7474C")]
		public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, MB3_MeshCombinerSingle.MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out Rect rectInAtlas, out Rect subrectInAtlasMatTiling, ref string errorMsg)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public MB_AtlasesAndRects[] combinedMaterialInfo;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E90C")]
	public Material[] materials;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect[] prefabUVRects;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_MaterialAndUVRect[] materialsAndUVRects;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material resultMaterial;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1353")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public bool doMultiMaterial;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E91C")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3C72084", Offset = "0x3C72084", VA = "0x3C72084")]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(Renderer r)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3C73478", Offset = "0x3C73478", VA = "0x3C73478")]
	public bool ContainsMaterial(Material m)
	{
		return default(bool);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3C73830", Offset = "0x3C73830", VA = "0x3C73830")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x3C73F30", Offset = "0x3C73F30", VA = "0x3C73F30")]
	public MB2_TextureBakeResults()
	{
	}
}
[Token(Token = "0x2000015")]
public class MB2_UpdateSkinnedMeshBoundsFromBones : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x135B")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private Transform[] bones;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x3C75504", Offset = "0x3C75504", VA = "0x3C75504")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x3C7576C", Offset = "0x3C7576C", VA = "0x3C7576C")]
	private void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3C758AC", Offset = "0x3C758AC", VA = "0x3C758AC")]
	public MB2_UpdateSkinnedMeshBoundsFromBones()
	{
	}
}
[Token(Token = "0x2000016")]
public class MB2_UpdateSkinnedMeshBoundsFromBounds : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E92C")]
	public List<GameObject> objects;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x3C758DC", Offset = "0x3C758DC", VA = "0x3C758DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x3C75F30", Offset = "0x3C75F30", VA = "0x3C75F30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x3C7609C", Offset = "0x3C7609C", VA = "0x3C7609C")]
	public MB2_UpdateSkinnedMeshBoundsFromBounds()
	{
	}
}
[Token(Token = "0x2000017")]
public class MB3_BatchPrefabBaker : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000F9")]
	public class MB3_PrefabBakerRow
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1363")]
		public GameObject sourcePrefab;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public GameObject resultPrefab;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x3C781DC", Offset = "0x3C781DC", VA = "0x3C781DC")]
		public MB3_PrefabBakerRow()
		{
		}
	}

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB3_PrefabBakerRow[] prefabRows;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string outputPrefabFolder;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x3C781AC", Offset = "0x3C781AC", VA = "0x3C781AC")]
	public MB3_BatchPrefabBaker()
	{
	}
}
[Token(Token = "0x2000018")]
public class MB3_BoneWeightCopier : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E93C")]
	public GameObject inputGameObject;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject outputPrefab;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float radius;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public SkinnedMeshRenderer seamMesh;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x136B")]
	public string outputFolder;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3C7820C", Offset = "0x3C7820C", VA = "0x3C7820C")]
	public MB3_BoneWeightCopier()
	{
	}
}
[Token(Token = "0x2000019")]
public class MB3_DisableHiddenAnimations : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public List<Animation> animationsToCull;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x3C78254", Offset = "0x3C78254", VA = "0x3C78254")]
	private void Start()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3C78448", Offset = "0x3C78448", VA = "0x3C78448")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x3C78668", Offset = "0x3C78668", VA = "0x3C78668")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3C78888", Offset = "0x3C78888", VA = "0x3C78888")]
	public MB3_DisableHiddenAnimations()
	{
	}
}
[Token(Token = "0x200001A")]
public class MB3_MeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E94C")]
	[SerializeField]
	protected MB3_MeshCombinerSingle _meshCombiner;

	[Token(Token = "0x17000006")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3C78940", Offset = "0x3C78940", VA = "0x3C78940", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x3C78970", Offset = "0x3C78970", VA = "0x3C78970")]
	public void BuildSceneMeshObject()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x3C789D4", Offset = "0x3C789D4", VA = "0x3C789D4", Slot = "23")]
	public virtual bool ShowHide(GameObject[] gos, GameObject[] deleteGOs)
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3C78A58", Offset = "0x3C78A58", VA = "0x3C78A58", Slot = "24")]
	public virtual void ApplyShowHide()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3C78AA0", Offset = "0x3C78AA0", VA = "0x3C78AA0", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x3C78BEC", Offset = "0x3C78BEC", VA = "0x3C78BEC", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x3C78D38", Offset = "0x3C78D38", VA = "0x3C78D38")]
	public MB3_MeshBaker()
	{
	}
}
[Token(Token = "0x200001B")]
public abstract class MB3_MeshBakerCommon : MB3_MeshBakerRoot
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool useObjsToMeshFromTexBaker;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool clearBuffersAfterBake;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1373")]
	public string bakeAssetsInPlaceFolderPath;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[HideInInspector]
	public GameObject resultPrefab;

	[Token(Token = "0x17000007")]
	public abstract MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000070")]
		get;
	}

	[Token(Token = "0x17000008")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3C78E3C", Offset = "0x3C78E3C", VA = "0x3C78E3C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3C78E94", Offset = "0x3C78E94", VA = "0x3C78E94", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3C78EF4", Offset = "0x3C78EF4", VA = "0x3C78EF4", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3C79300", Offset = "0x3C79300", VA = "0x3C79300")]
	public void EnableDisableSourceObjectRenderers(bool show)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x3C79604", Offset = "0x3C79604", VA = "0x3C79604", Slot = "8")]
	public virtual void ClearMesh()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3C79654", Offset = "0x3C79654", VA = "0x3C79654", Slot = "9")]
	public virtual void DestroyMesh()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3C796A4", Offset = "0x3C796A4", VA = "0x3C796A4", Slot = "10")]
	public virtual void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3C79704", Offset = "0x3C79704", VA = "0x3C79704", Slot = "11")]
	public virtual int GetNumObjectsInCombined()
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3C7975C", Offset = "0x3C7975C", VA = "0x3C7975C", Slot = "12")]
	public virtual int GetNumVerticesFor(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3C797C4", Offset = "0x3C797C4", VA = "0x3C797C4")]
	public MB3_TextureBaker GetTextureBaker()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	[Token(Token = "0x600007C")]
	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true);

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x3C79A38", Offset = "0x3C79A38", VA = "0x3C79A38", Slot = "15")]
	public virtual void Apply([Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x3C79B40", Offset = "0x3C79B40", VA = "0x3C79B40", Slot = "16")]
	public virtual void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3C79DF0", Offset = "0x3C79DF0", VA = "0x3C79DF0", Slot = "17")]
	public virtual bool CombinedMeshContains(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x3C79E6C", Offset = "0x3C79E6C", VA = "0x3C79E6C", Slot = "18")]
	public virtual void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV1 = false, bool updateUV2 = false, bool updateColors = false, bool updateSkinningInfo = false)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x3C7A0EC", Offset = "0x3C7A0EC", VA = "0x3C7A0EC", Slot = "19")]
	public virtual void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3C7A164", Offset = "0x3C7A164", VA = "0x3C7A164", Slot = "20")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3C7A1DC", Offset = "0x3C7A1DC", VA = "0x3C7A1DC", Slot = "21")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3C7A254", Offset = "0x3C7A254", VA = "0x3C7A254", Slot = "22")]
	protected virtual bool _ValidateForUpdateSkinnedMeshBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3C78DE0", Offset = "0x3C78DE0", VA = "0x3C78DE0")]
	protected MB3_MeshBakerCommon()
	{
	}
}
[Token(Token = "0x200001C")]
public class MB3_MeshBakerGrouper : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E95C")]
	public MB3_MeshBakerGrouperCore grouper;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public Bounds sourceObjectBounds;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3C7A710", Offset = "0x3C7A710", VA = "0x3C7A710")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3C7C4C0", Offset = "0x3C7C4C0", VA = "0x3C7C4C0")]
	public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x3C7CA34", Offset = "0x3C7CA34", VA = "0x3C7CA34")]
	public MB3_MeshBakerGrouper()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class MB3_MeshBakerGrouperCore
{
	[Token(Token = "0x20000FA")]
	public enum ClusterType
	{
		[Token(Token = "0x400062A")]
		none,
		[Token(Token = "0x400062B")]
		grid,
		[Token(Token = "0x400062C")]
		pie
	}

	[Serializable]
	[Token(Token = "0x20000FB")]
	public class ClusterGrouper
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ClusterType clusterType;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 origin;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1383")]
		public Vector3 cellSize;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public int pieNumSegments;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578E97C")]
		public Vector3 pieAxis;

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x3C7D740", Offset = "0x3C7D740", VA = "0x3C7D740")]
		public Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x3C7E2DC", Offset = "0x3C7E2DC", VA = "0x3C7E2DC")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsNone(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x3C7E5E8", Offset = "0x3C7E5E8", VA = "0x3C7E5E8")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsGrid(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x3C7F1CC", Offset = "0x3C7F1CC", VA = "0x3C7F1CC")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsPie(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x3C80164", Offset = "0x3C80164", VA = "0x3C80164")]
		public ClusterGrouper()
		{
		}
	}

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ClusterGrouper clusterGrouper;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool clusterOnLMIndex;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x3C7CB7C", Offset = "0x3C7CB7C", VA = "0x3C7CB7C")]
	public void DoClustering(MB3_TextureBaker tb)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3C7D8DC", Offset = "0x3C7D8DC", VA = "0x3C7D8DC")]
	private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x3C7DC80", Offset = "0x3C7DC80", VA = "0x3C7DC80")]
	private void AddMeshBaker(MB3_TextureBaker tb, string key, List<Renderer> gaws)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x3C7E2AC", Offset = "0x3C7E2AC", VA = "0x3C7E2AC")]
	public MB3_MeshBakerGrouperCore()
	{
	}
}
[Token(Token = "0x200001E")]
public abstract class MB3_MeshBakerRoot : MonoBehaviour
{
	[Token(Token = "0x17000009")]
	[HideInInspector]
	public abstract MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x600008D")]
		get;
		[Token(Token = "0x600008E")]
		set;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x3C80254", Offset = "0x3C80254", VA = "0x3C80254", Slot = "6")]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x3C80270", Offset = "0x3C80270", VA = "0x3C80270")]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x3C7A6E0", Offset = "0x3C7A6E0", VA = "0x3C7A6E0")]
	protected MB3_MeshBakerRoot()
	{
	}
}
[Token(Token = "0x200001F")]
public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected MB3_MultiMeshCombiner _meshCombiner;

	[Token(Token = "0x1700000A")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x3C816FC", Offset = "0x3C816FC", VA = "0x3C816FC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x3C8172C", Offset = "0x3C8172C", VA = "0x3C8172C", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x3C81A0C", Offset = "0x3C81A0C", VA = "0x3C81A0C", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x3C81CEC", Offset = "0x3C81CEC", VA = "0x3C81CEC")]
	public MB3_MultiMeshBaker()
	{
	}
}
[Token(Token = "0x2000020")]
public class MB3_TextureBaker : MB3_MeshBakerRoot
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected MB2_TextureBakeResults _textureBakeResults;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138B")]
	[SerializeField]
	protected int _atlasPadding;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected int _maxAtlasSize;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E98C")]
	[SerializeField]
	protected bool _resizePowerOfTwoTextures;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected int _maxTilingBakeSize;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1393")]
	[SerializeField]
	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected List<ShaderTextureProperty> _customShaderProperties;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E99C")]
	[SerializeField]
	protected List<string> _customShaderPropNames_Depricated;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected bool _doMultiMaterial;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected Material _resultMaterial;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected bool _considerNonTextureProperties;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139B")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x1700000B")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x3C81D94", Offset = "0x3C81D94", VA = "0x3C81D94", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3C81DC4", Offset = "0x3C81DC4", VA = "0x3C81DC4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public virtual int atlasPadding
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x3C81DFC", Offset = "0x3C81DFC", VA = "0x3C81DFC", Slot = "7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x3C81E2C", Offset = "0x3C81E2C", VA = "0x3C81E2C", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public virtual int maxAtlasSize
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3C81E64", Offset = "0x3C81E64", VA = "0x3C81E64", Slot = "9")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x3C81E94", Offset = "0x3C81E94", VA = "0x3C81E94", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual bool resizePowerOfTwoTextures
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3C81ECC", Offset = "0x3C81ECC", VA = "0x3C81ECC", Slot = "11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x3C81F10", Offset = "0x3C81F10", VA = "0x3C81F10", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public virtual bool fixOutOfBoundsUVs
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x3C81F5C", Offset = "0x3C81F5C", VA = "0x3C81F5C", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x3C81FA0", Offset = "0x3C81FA0", VA = "0x3C81FA0", Slot = "14")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public virtual int maxTilingBakeSize
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3C81FEC", Offset = "0x3C81FEC", VA = "0x3C81FEC", Slot = "15")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x3C8201C", Offset = "0x3C8201C", VA = "0x3C8201C", Slot = "16")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x3C82054", Offset = "0x3C82054", VA = "0x3C82054", Slot = "17")]
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x3C82084", Offset = "0x3C82084", VA = "0x3C82084", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x3C820BC", Offset = "0x3C820BC", VA = "0x3C820BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x3C82100", Offset = "0x3C82100", VA = "0x3C82100")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3C8214C", Offset = "0x3C8214C", VA = "0x3C8214C", Slot = "19")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3C8217C", Offset = "0x3C8217C", VA = "0x3C8217C", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public virtual List<string> customShaderPropNames
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x3C821B4", Offset = "0x3C821B4", VA = "0x3C821B4", Slot = "21")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3C821E4", Offset = "0x3C821E4", VA = "0x3C821E4", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public virtual bool doMultiMaterial
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3C8221C", Offset = "0x3C8221C", VA = "0x3C8221C", Slot = "23")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3C82260", Offset = "0x3C82260", VA = "0x3C82260", Slot = "24")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public virtual Material resultMaterial
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3C822AC", Offset = "0x3C822AC", VA = "0x3C822AC", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3C822DC", Offset = "0x3C822DC", VA = "0x3C822DC", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool considerNonTextureProperties
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3C82314", Offset = "0x3C82314", VA = "0x3C82314")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3C82358", Offset = "0x3C82358", VA = "0x3C82358")]
		set
		{
		}
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x3C823A4", Offset = "0x3C823A4", VA = "0x3C823A4", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x3C82488", Offset = "0x3C82488", VA = "0x3C82488")]
	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x3C824D4", Offset = "0x3C824D4", VA = "0x3C824D4")]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x3C82C54", Offset = "0x3C82C54", VA = "0x3C82C54")]
	private MB_AtlasesAndRects[] _CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x3C85550", Offset = "0x3C85550", VA = "0x3C85550")]
	private void unpackMat2RectMap(MB2_TextureBakeResults tbr)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x3C859CC", Offset = "0x3C859CC", VA = "0x3C859CC")]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x3C85F8C", Offset = "0x3C85F8C", VA = "0x3C85F8C")]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x3C844B4", Offset = "0x3C844B4", VA = "0x3C844B4")]
	private bool _ValidateResultMaterials()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x3C863D4", Offset = "0x3C863D4", VA = "0x3C863D4")]
	public MB3_TextureBaker()
	{
	}
}
[Token(Token = "0x2000021")]
public class MB_TextureCombinerRenderTexture
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E9AC")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Material mat;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderTexture _destinationTexture;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Camera myCamera;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13A3")]
	private int _padding;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private bool _isNormalMap;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E9BC")]
	private bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool _considerNonTextureProperties;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Rect[] rs;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13AB")]
	private List<MB3_TextureCombiner.MB_TexSet> textureSets;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private int indexOfTexSetToRender;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E9CC")]
	private ShaderTextureProperty _texPropertyName;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TextureBlender _resultMaterialTextureBlender;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Texture2D targTex;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MB3_TextureCombiner combiner;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x3C76348", Offset = "0x3C76348", VA = "0x3C76348")]
	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB3_TextureCombiner.MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, TextureBlender resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x3C76C80", Offset = "0x3C76C80", VA = "0x3C76C80")]
	public void OnRenderObject()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x3C8C9EC", Offset = "0x3C8C9EC", VA = "0x3C8C9EC")]
	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x3C8C934", Offset = "0x3C8C934", VA = "0x3C8C934")]
	private bool IsOpenGL()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x3C8A870", Offset = "0x3C8A870", VA = "0x3C8A870")]
	private void CopyScaledAndTiledToAtlas(MB3_TextureCombiner.MB_TexSet texSet, MB3_TextureCombiner.MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, TextureBlender resultMatTexBlender)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x3C8A1A0", Offset = "0x3C8A1A0", VA = "0x3C8A1A0")]
	private void _printTexture(Texture2D t)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3C76304", Offset = "0x3C76304", VA = "0x3C76304")]
	public MB_TextureCombinerRenderTexture()
	{
	}
}
[Token(Token = "0x2000022")]
[ExecuteInEditMode]
public class MB3_AtlasPackerRenderTexture : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13B3")]
	private MB_TextureCombinerRenderTexture fastRenderer;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E9DC")]
	public int width;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int height;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int padding;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isNormalMap;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13BB")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public bool considerNonTextureProperties;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E9EC")]
	public TextureBlender resultMaterialTextureBlender;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect[] rects;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Texture2D tex1;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<MB3_TextureCombiner.MB_TexSet> textureSets;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C3")]
	public int indexOfTexSetToRender;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public ShaderTextureProperty texPropertyName;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578E9FC")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Texture2D testTex;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material testMat;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3C760CC", Offset = "0x3C760CC", VA = "0x3C760CC")]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3C76C00", Offset = "0x3C76C00", VA = "0x3C76C00")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3C78168", Offset = "0x3C78168", VA = "0x3C78168")]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
[Token(Token = "0x2000023")]
public class BulletHole : MonoBehaviour
{
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3064", Offset = "0x10A3064")]
	private sealed class <DestroyDelayed>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13CB")]
		private int <>1__state;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private object <>2__current;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EA0C")]
		public BulletHole <>4__this;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x44CCF10", Offset = "0x44CCF10", VA = "0x44CCF10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x44CCFE0", Offset = "0x44CCFE0", VA = "0x44CCFE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x44CCC18", Offset = "0x44CCC18", VA = "0x44CCC18")]
		[DebuggerHidden]
		public <DestroyDelayed>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x44CCCA4", Offset = "0x44CCCA4", VA = "0x44CCCA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x44CCCB8", Offset = "0x44CCCB8", VA = "0x44CCCB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x44CCF40", Offset = "0x44CCF40", VA = "0x44CCF40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float lifeTime;

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x44CCB14", Offset = "0x44CCB14", VA = "0x44CCB14")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x44CCB5C", Offset = "0x44CCB5C", VA = "0x44CCB5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF064", Offset = "0x10AF064")]
	private IEnumerator DestroyDelayed()
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x44CCC60", Offset = "0x44CCC60", VA = "0x44CCC60")]
	public BulletHole()
	{
	}
}
[Token(Token = "0x2000024")]
public class ActivateTrigger : MonoBehaviour
{
	[Token(Token = "0x20000FD")]
	public enum Mode
	{
		[Token(Token = "0x4000636")]
		Trigger,
		[Token(Token = "0x4000637")]
		Replace,
		[Token(Token = "0x4000638")]
		Activate,
		[Token(Token = "0x4000639")]
		Enable,
		[Token(Token = "0x400063A")]
		Animate,
		[Token(Token = "0x400063B")]
		Deactivate
	}

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Mode action;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public UnityEngine.Object target;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject source;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13D3")]
	public int triggerCount;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public bool repeatTrigger;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x44CC00C", Offset = "0x44CC00C", VA = "0x44CC00C")]
	private void DoActivateTrigger()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x44CC640", Offset = "0x44CC640", VA = "0x44CC640")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x44CC674", Offset = "0x44CC674", VA = "0x44CC674")]
	public ActivateTrigger()
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A0ED0", Offset = "0x10A0ED0")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x53E970C", Offset = "0x53E970C", VA = "0x53E970C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x53E9774", Offset = "0x53E9774", VA = "0x53E9774")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x53E9814", Offset = "0x53E9814", VA = "0x53E9814")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x53E98B4", Offset = "0x53E98B4", VA = "0x53E98B4")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A0F9C", Offset = "0x10A0F9C")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x53E98E4", Offset = "0x53E98E4", VA = "0x53E98E4")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MeshContainer
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3[] vertices;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3[] normals;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x53E9914", Offset = "0x53E9914", VA = "0x53E9914")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x53E99B8", Offset = "0x53E99B8", VA = "0x53E99B8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1068", Offset = "0x10A1068")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13E3")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool reflectSkybox;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EA3C")]
		public Color clearColor;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string reflectionSampler;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13EB")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EA4C")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x53E9A40", Offset = "0x53E9A40", VA = "0x53E9A40")]
		public void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x53E9BDC", Offset = "0x53E9BDC", VA = "0x53E9BDC")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x53EA230", Offset = "0x53EA230", VA = "0x53EA230")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x53EA378", Offset = "0x53EA378", VA = "0x53EA378")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x53EA548", Offset = "0x53EA548", VA = "0x53EA548")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x53EBACC", Offset = "0x53EBACC", VA = "0x53EBACC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x53EBB88", Offset = "0x53EBB88", VA = "0x53EBB88")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x53EBDA4", Offset = "0x53EBDA4", VA = "0x53EBDA4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x53EBE44", Offset = "0x53EBE44", VA = "0x53EBE44")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x53EA870", Offset = "0x53EA870", VA = "0x53EA870")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x53EBEE4", Offset = "0x53EBEE4", VA = "0x53EBEE4")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x53EC884", Offset = "0x53EC884", VA = "0x53EC884")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x53EBFC0", Offset = "0x53EBFC0", VA = "0x53EBFC0")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x53ECC88", Offset = "0x53ECC88", VA = "0x53ECC88")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x53EC454", Offset = "0x53EC454", VA = "0x53EC454")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x53ECD10", Offset = "0x53ECD10", VA = "0x53ECD10")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1134", Offset = "0x10A1134")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform specularLight;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x53ECDCC", Offset = "0x53ECDCC", VA = "0x53ECDCC")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x53ECF60", Offset = "0x53ECF60", VA = "0x53ECF60")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x53ED350", Offset = "0x53ED350", VA = "0x53ED350")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x20000FE")]
		public enum WaterMode
		{
			[Token(Token = "0x400063D")]
			Simple,
			[Token(Token = "0x400063E")]
			Reflective,
			[Token(Token = "0x400063F")]
			Refractive
		}

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WaterMode waterMode;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13F3")]
		public bool disablePixelLights;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public int textureSize;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EA5C")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13FB")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EA80")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1403")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x53ED380", Offset = "0x53ED380", VA = "0x53ED380")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x53F0F88", Offset = "0x53F0F88", VA = "0x53F0F88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x53EFFF0", Offset = "0x53EFFF0", VA = "0x53EFFF0")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x53EED9C", Offset = "0x53EED9C", VA = "0x53EED9C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x53EED18", Offset = "0x53EED18", VA = "0x53EED18")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x53EEA18", Offset = "0x53EEA18", VA = "0x53EEA18")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x53F0B58", Offset = "0x53F0B58", VA = "0x53F0B58")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x53F05F8", Offset = "0x53F05F8", VA = "0x53F05F8")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x53F189C", Offset = "0x53F189C", VA = "0x53F189C")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000C4")]
		High = 2,
		[Token(Token = "0x40000C5")]
		Medium = 1,
		[Token(Token = "0x40000C6")]
		Low = 0
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material sharedMaterial;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool edgeBlend;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x53F1AB0", Offset = "0x53F1AB0", VA = "0x53F1AB0")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x53F1DF8", Offset = "0x53F1DF8", VA = "0x53F1DF8")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x53F1F78", Offset = "0x53F1F78", VA = "0x53F1F78")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x53F2090", Offset = "0x53F2090", VA = "0x53F2090")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1413")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public WaterBase waterBase;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x53F20EC", Offset = "0x53F20EC", VA = "0x53F20EC")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x53F211C", Offset = "0x53F211C", VA = "0x53F211C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x53F2568", Offset = "0x53F2568", VA = "0x53F2568")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x53F2794", Offset = "0x53F2794", VA = "0x53F2794")]
		public WaterTile()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200002E")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000641")]
			Update,
			[Token(Token = "0x4000642")]
			FixedUpdate,
			[Token(Token = "0x4000643")]
			LateUpdate
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EAB0")]
		public Transform target;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rotationSpace;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateMode updateMode;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool lockCursor;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141B")]
		public bool smoothFollow;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float followSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EAC0")]
		public float distance;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minDistance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxDistance;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSpeed;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1423")]
		public float zoomSensitivity;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float rotationSensitivity;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EAD0")]
		public float yMinLimit;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float yMaxLimit;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateAlways;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142B")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EAE0")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A38AC", Offset = "0x10A38AC")]
		private float <x>k__BackingField;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A38E8", Offset = "0x10A38E8")]
		private float <y>k__BackingField;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3924", Offset = "0x10A3924")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1433")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 position;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EAF0")]
		private Quaternion rotation;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Camera cam;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion r;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143B")]
		private Vector3 lastUp;

		[Token(Token = "0x17000018")]
		public float x
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x384134C", Offset = "0x384134C", VA = "0x384134C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF114", Offset = "0x10AF114")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x384137C", Offset = "0x384137C", VA = "0x384137C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF150", Offset = "0x10AF150")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float y
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x38413B4", Offset = "0x38413B4", VA = "0x38413B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF18C", Offset = "0x10AF18C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x38413E4", Offset = "0x38413E4", VA = "0x38413E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF1C8", Offset = "0x10AF1C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float distanceTarget
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x384141C", Offset = "0x384141C", VA = "0x384141C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF204", Offset = "0x10AF204")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x384144C", Offset = "0x384144C", VA = "0x384144C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF240", Offset = "0x10AF240")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		private float zoomAdd
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x3842000", Offset = "0x3842000", VA = "0x3842000")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x3841484", Offset = "0x3841484", VA = "0x3841484", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x38417B8", Offset = "0x38417B8", VA = "0x38417B8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x384184C", Offset = "0x384184C", VA = "0x384184C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x38418AC", Offset = "0x38418AC", VA = "0x38418AC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x3841918", Offset = "0x3841918", VA = "0x3841918")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x3841808", Offset = "0x3841808", VA = "0x3841808")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x384212C", Offset = "0x384212C", VA = "0x384212C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x3841E44", Offset = "0x3841E44", VA = "0x3841E44")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x3842C28", Offset = "0x3842C28", VA = "0x3842C28")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotationSensitivity;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1443")]
		public float yMinLimit;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float yMaxLimit;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EB10")]
		private float x;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float y;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x3842E34", Offset = "0x3842E34", VA = "0x3842E34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x3842EFC", Offset = "0x3842EFC", VA = "0x3842EFC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x384324C", Offset = "0x384324C", VA = "0x384324C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x3843408", Offset = "0x3843408", VA = "0x3843408")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public enum Axis
	{
		[Token(Token = "0x40000EF")]
		X,
		[Token(Token = "0x40000F0")]
		Y,
		[Token(Token = "0x40000F1")]
		Z
	}
	[Token(Token = "0x2000031")]
	public class AxisTools
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x3C8D488", Offset = "0x3C8D488", VA = "0x3C8D488")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x3C8D648", Offset = "0x3C8D648", VA = "0x3C8D648")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x3C8D870", Offset = "0x3C8D870", VA = "0x3C8D870")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x3C8DC80", Offset = "0x3C8DC80", VA = "0x3C8DC80")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x3C8DB00", Offset = "0x3C8DB00", VA = "0x3C8DB00")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x3C8DF10", Offset = "0x3C8DF10", VA = "0x3C8DF10")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x3C8E4E0", Offset = "0x3C8E4E0", VA = "0x3C8E4E0")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1453")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EB30")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x3C8E974", Offset = "0x3C8E974", VA = "0x3C8E974")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EB20")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700001C")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x3C8E5A0", Offset = "0x3C8E5A0", VA = "0x3C8E5A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x3C8EA6C", Offset = "0x3C8EA6C", VA = "0x3C8EA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x3C8E510", Offset = "0x3C8E510", VA = "0x3C8E510")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public enum BoneType
		{
			[Token(Token = "0x4000648")]
			Unassigned,
			[Token(Token = "0x4000649")]
			Spine,
			[Token(Token = "0x400064A")]
			Head,
			[Token(Token = "0x400064B")]
			Arm,
			[Token(Token = "0x400064C")]
			Leg,
			[Token(Token = "0x400064D")]
			Tail,
			[Token(Token = "0x400064E")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public enum BoneSide
		{
			[Token(Token = "0x4000650")]
			Center,
			[Token(Token = "0x4000651")]
			Left,
			[Token(Token = "0x4000652")]
			Right
		}

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeRight;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeSpine;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145B")]
		public static string[] typeHead;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeArm;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EB40")]
		public static string[] typeLeg;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeTail;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeEye;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExclude;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1463")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EB50")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x146B")]
		public static string[] pelvis;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] hand;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EB60")]
		public static string[] foot;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x3C8EE40", Offset = "0x3C8EE40", VA = "0x3C8EE40")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x3C8F628", Offset = "0x3C8F628", VA = "0x3C8F628")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x3C8FB90", Offset = "0x3C8FB90", VA = "0x3C8FB90")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x3C8FCD8", Offset = "0x3C8FCD8", VA = "0x3C8FCD8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x3C8FE6C", Offset = "0x3C8FE6C", VA = "0x3C8FE6C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x3C8F1EC", Offset = "0x3C8F1EC", VA = "0x3C8F1EC")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x3C8F9D4", Offset = "0x3C8F9D4", VA = "0x3C8F9D4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x3C91664", Offset = "0x3C91664", VA = "0x3C91664")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x3C910FC", Offset = "0x3C910FC", VA = "0x3C910FC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x3C913B0", Offset = "0x3C913B0", VA = "0x3C913B0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x3C903F4", Offset = "0x3C903F4", VA = "0x3C903F4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x3C90620", Offset = "0x3C90620", VA = "0x3C90620")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x3C9084C", Offset = "0x3C9084C", VA = "0x3C9084C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x3C90A78", Offset = "0x3C90A78", VA = "0x3C90A78")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x3C90CA4", Offset = "0x3C90CA4", VA = "0x3C90CA4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x3C90ED0", Offset = "0x3C90ED0", VA = "0x3C90ED0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x3C91B48", Offset = "0x3C91B48", VA = "0x3C91B48")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x3C90184", Offset = "0x3C90184", VA = "0x3C90184")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x3C919EC", Offset = "0x3C919EC", VA = "0x3C919EC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x3C91C6C", Offset = "0x3C91C6C", VA = "0x3C91C6C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x3C91E7C", Offset = "0x3C91E7C", VA = "0x3C91E7C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x3C918E0", Offset = "0x3C918E0", VA = "0x3C918E0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x3C9179C", Offset = "0x3C9179C", VA = "0x3C9179C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class BipedReferences
	{
		[Token(Token = "0x2000103")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EBA0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool includeEyes;

			[Token(Token = "0x170000B0")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x38412C4", Offset = "0x38412C4", VA = "0x38412C4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x384124C", Offset = "0x384124C", VA = "0x384124C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pelvis;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftThigh;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1483")]
		public Transform leftCalf;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform leftFoot;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EB90")]
		public Transform rightThigh;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightCalf;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightFoot;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148B")]
		public Transform leftForearm;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform leftHand;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EBA0")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightForearm;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHand;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform head;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1493")]
		public Transform[] spine;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform[] eyes;

		[Token(Token = "0x1700001E")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x3C94130", Offset = "0x3C94130", VA = "0x3C94130", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public bool isEmpty
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x3C94DA0", Offset = "0x3C94DA0", VA = "0x3C94DA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x3C94DF4", Offset = "0x3C94DF4", VA = "0x3C94DF4", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3C95B2C", Offset = "0x3C95B2C", VA = "0x3C95B2C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x3C9697C", Offset = "0x3C9697C", VA = "0x3C9697C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3C97AC8", Offset = "0x3C97AC8", VA = "0x3C97AC8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x3C97028", Offset = "0x3C97028", VA = "0x3C97028")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x3C990D0", Offset = "0x3C990D0", VA = "0x3C990D0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x3C9958C", Offset = "0x3C9958C", VA = "0x3C9958C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x3C9A818", Offset = "0x3C9A818", VA = "0x3C9A818")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x3C9A330", Offset = "0x3C9A330", VA = "0x3C9A330")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x3C99E20", Offset = "0x3C99E20", VA = "0x3C99E20")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x3C99A10", Offset = "0x3C99A10", VA = "0x3C99A10")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3C9A608", Offset = "0x3C9A608", VA = "0x3C9A608")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3C9AA80", Offset = "0x3C9AA80", VA = "0x3C9AA80")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3C9C164", Offset = "0x3C9C164", VA = "0x3C9C164")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x3C9B450", Offset = "0x3C9B450", VA = "0x3C9B450")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x3C9C5DC", Offset = "0x3C9C5DC", VA = "0x3C9C5DC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x3C9BCF4", Offset = "0x3C9BCF4", VA = "0x3C9BCF4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x3C9C604", Offset = "0x3C9C604", VA = "0x3C9C604")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x3C9C62C", Offset = "0x3C9C62C", VA = "0x3C9C62C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x3C9CA00", Offset = "0x3C9CA00", VA = "0x3C9CA00")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x3C9CE28", Offset = "0x3C9CE28", VA = "0x3C9CE28")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x3C96F60", Offset = "0x3C96F60", VA = "0x3C96F60")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x10A3960", Offset = "0x10A3960")]
		public string text;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x384347C", Offset = "0x384347C", VA = "0x384347C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string text;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149B")]
		public Color color;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x38434AC", Offset = "0x38434AC", VA = "0x38434AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x38435EC", Offset = "0x38435EC", VA = "0x38435EC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Hierarchy
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x53DA230", Offset = "0x53DA230", VA = "0x53DA230")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x53DA780", Offset = "0x53DA780", VA = "0x53DA780")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x53DA39C", Offset = "0x53DA39C", VA = "0x53DA39C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x53DAA38", Offset = "0x53DAA38", VA = "0x53DAA38")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x53DAD10", Offset = "0x53DAD10", VA = "0x53DAD10")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x53DB230", Offset = "0x53DB230", VA = "0x53DB230")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x53DB4E8", Offset = "0x53DB4E8", VA = "0x53DB4E8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x53DB8FC", Offset = "0x53DB8FC", VA = "0x53DB8FC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x53DC28C", Offset = "0x53DC28C", VA = "0x53DC28C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x53DBD30", Offset = "0x53DBD30", VA = "0x53DBD30")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x53DC708", Offset = "0x53DC708", VA = "0x53DC708")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400011D")]
		None,
		[Token(Token = "0x400011E")]
		InOutCubic,
		[Token(Token = "0x400011F")]
		InOutQuintic,
		[Token(Token = "0x4000120")]
		InOutSine,
		[Token(Token = "0x4000121")]
		InQuintic,
		[Token(Token = "0x4000122")]
		InQuartic,
		[Token(Token = "0x4000123")]
		InCubic,
		[Token(Token = "0x4000124")]
		InQuadratic,
		[Token(Token = "0x4000125")]
		InElastic,
		[Token(Token = "0x4000126")]
		InElasticSmall,
		[Token(Token = "0x4000127")]
		InElasticBig,
		[Token(Token = "0x4000128")]
		InSine,
		[Token(Token = "0x4000129")]
		InBack,
		[Token(Token = "0x400012A")]
		OutQuintic,
		[Token(Token = "0x400012B")]
		OutQuartic,
		[Token(Token = "0x400012C")]
		OutCubic,
		[Token(Token = "0x400012D")]
		OutInCubic,
		[Token(Token = "0x400012E")]
		OutInQuartic,
		[Token(Token = "0x400012F")]
		OutElastic,
		[Token(Token = "0x4000130")]
		OutElasticSmall,
		[Token(Token = "0x4000131")]
		OutElasticBig,
		[Token(Token = "0x4000132")]
		OutSine,
		[Token(Token = "0x4000133")]
		OutBack,
		[Token(Token = "0x4000134")]
		OutBackCubic,
		[Token(Token = "0x4000135")]
		OutBackQuartic,
		[Token(Token = "0x4000136")]
		BackInCubic,
		[Token(Token = "0x4000137")]
		BackInQuartic
	}
	[Token(Token = "0x2000039")]
	public class Interp
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x53DC738", Offset = "0x53DC738", VA = "0x53DC738")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x53DF448", Offset = "0x53DF448", VA = "0x53DF448")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x53DF634", Offset = "0x53DF634", VA = "0x53DF634")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x53DD0DC", Offset = "0x53DD0DC", VA = "0x53DD0DC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x53DD14C", Offset = "0x53DD14C", VA = "0x53DD14C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x53DD26C", Offset = "0x53DD26C", VA = "0x53DD26C")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x53DD3E8", Offset = "0x53DD3E8", VA = "0x53DD3E8")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x53DD4C8", Offset = "0x53DD4C8", VA = "0x53DD4C8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x53DD584", Offset = "0x53DD584", VA = "0x53DD584")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x53DD62C", Offset = "0x53DD62C", VA = "0x53DD62C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x53DD6C4", Offset = "0x53DD6C4", VA = "0x53DD6C4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x53DD8A4", Offset = "0x53DD8A4", VA = "0x53DD8A4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x53DDA40", Offset = "0x53DDA40", VA = "0x53DDA40")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x53DDB84", Offset = "0x53DDB84", VA = "0x53DDB84")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x53DF904", Offset = "0x53DF904", VA = "0x53DF904")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x53DDCE0", Offset = "0x53DDCE0", VA = "0x53DDCE0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x53DDE00", Offset = "0x53DDE00", VA = "0x53DDE00")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x53DDF60", Offset = "0x53DDF60", VA = "0x53DDF60")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x53DE0BC", Offset = "0x53DE0BC", VA = "0x53DE0BC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x53DE264", Offset = "0x53DE264", VA = "0x53DE264")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x53DE458", Offset = "0x53DE458", VA = "0x53DE458")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x53DE64C", Offset = "0x53DE64C", VA = "0x53DE64C")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x53DE804", Offset = "0x53DE804", VA = "0x53DE804")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x53DE9BC", Offset = "0x53DE9BC", VA = "0x53DE9BC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x53DEB34", Offset = "0x53DEB34", VA = "0x53DEB34")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x53DEC90", Offset = "0x53DEC90", VA = "0x53DEC90")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x53DFA60", Offset = "0x53DFA60", VA = "0x53DFA60")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x53DEE30", Offset = "0x53DEE30", VA = "0x53DEE30")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x53DF1F8", Offset = "0x53DF1F8", VA = "0x53DF1F8")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x53DF310", Offset = "0x53DF310", VA = "0x53DF310")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x53DFE34", Offset = "0x53DFE34", VA = "0x53DFE34")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C3")]
		public string color;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x53DFE64", Offset = "0x53DFE64", VA = "0x53DFE64")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x53DFF1C", Offset = "0x53DFF1C", VA = "0x53DFF1C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x53DFFDC", Offset = "0x53DFFDC", VA = "0x53DFFDC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x53E011C", Offset = "0x53E011C", VA = "0x53E011C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x53E03B8", Offset = "0x53E03B8", VA = "0x53E03B8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x53E0174", Offset = "0x53E0174", VA = "0x53E0174")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x53E0410", Offset = "0x53E0410", VA = "0x53E0410")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x53E063C", Offset = "0x53E063C", VA = "0x53E063C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x53E06F0", Offset = "0x53E06F0", VA = "0x53E06F0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x53E0808", Offset = "0x53E0808", VA = "0x53E0808")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x53E097C", Offset = "0x53E097C", VA = "0x53E097C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x53E0BF4", Offset = "0x53E0BF4", VA = "0x53E0BF4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x53E0E10", Offset = "0x53E0E10", VA = "0x53E0E10")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x53E0EEC", Offset = "0x53E0EEC", VA = "0x53E0EEC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class QuaTools
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x53E0F94", Offset = "0x53E0F94", VA = "0x53E0F94")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x53E118C", Offset = "0x53E118C", VA = "0x53E118C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x53E1384", Offset = "0x53E1384", VA = "0x53E1384")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x53E16C8", Offset = "0x53E16C8", VA = "0x53E16C8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x53E184C", Offset = "0x53E184C", VA = "0x53E184C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x53E1AC0", Offset = "0x53E1AC0", VA = "0x53E1AC0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x53E2154", Offset = "0x53E2154", VA = "0x53E2154")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x53E2620", Offset = "0x53E2620", VA = "0x53E2620")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000020")]
		public static T instance
		{
			[Token(Token = "0x6000185")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000186")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000187")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A399C", Offset = "0x10A399C")]
		public float timeStep;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3A00", Offset = "0x10A3A00")]
		public bool fixTransforms;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastTime;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animation legacy;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14CB")]
		private bool updateFrame;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool componentInitiated;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC20")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x53E2C24", Offset = "0x53E2C24", VA = "0x53E2C24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		private bool isAnimated
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x53E33B4", Offset = "0x53E33B4", VA = "0x53E33B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x53E2990", Offset = "0x53E2990", VA = "0x53E2990")]
		public void Disable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x53E2AB8", Offset = "0x53E2AB8", VA = "0x53E2AB8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x53E2ACC", Offset = "0x53E2ACC", VA = "0x53E2ACC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x53E2AE0", Offset = "0x53E2AE0", VA = "0x53E2AE0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x53E2AF4", Offset = "0x53E2AF4", VA = "0x53E2AF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x53E2BF4", Offset = "0x53E2BF4", VA = "0x53E2BF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x53E2B50", Offset = "0x53E2B50", VA = "0x53E2B50")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x53E3314", Offset = "0x53E3314", VA = "0x53E3314")]
		private void Update()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x53E2EA0", Offset = "0x53E2EA0", VA = "0x53E2EA0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x53E3594", Offset = "0x53E3594", VA = "0x53E3594")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x53E364C", Offset = "0x53E364C", VA = "0x53E364C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x53E37BC", Offset = "0x53E37BC", VA = "0x53E37BC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x53E38D4", Offset = "0x53E38D4", VA = "0x53E38D4")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject target;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x53E3918", Offset = "0x53E3918", VA = "0x53E3918")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x53E3A80", Offset = "0x53E3A80", VA = "0x53E3A80")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x53E3BE8", Offset = "0x53E3BE8", VA = "0x53E3BE8")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x53E3D50", Offset = "0x53E3D50", VA = "0x53E3D50")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class V3Tools
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x53E3D80", Offset = "0x53E3D80", VA = "0x53E3D80")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x53E3F74", Offset = "0x53E3F74", VA = "0x53E3F74")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x53E41A4", Offset = "0x53E41A4", VA = "0x53E41A4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x53E4760", Offset = "0x53E4760", VA = "0x53E4760")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x53E4D34", Offset = "0x53E4D34", VA = "0x53E4D34")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000041")]
	public static class Warning
	{
		[Token(Token = "0x2000104")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x53E5120", Offset = "0x53E5120", VA = "0x53E5120")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x53E566C", Offset = "0x53E566C", VA = "0x53E566C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000042")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AimIK aimIK;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D3")]
		public Transform pin;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x3843654", Offset = "0x3843654", VA = "0x3843654")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3843784", Offset = "0x3843784", VA = "0x3843784")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3A64", Offset = "0x10A3A64")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3AC8", Offset = "0x10A3AC8")]
		public AimIK aim;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3B2C", Offset = "0x10A3B2C")]
		public LookAtIK lookAt;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3B90", Offset = "0x10A3B90")]
		public Animator animator;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3BF4", Offset = "0x10A3BF4")]
		public float crossfadeTime;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14DB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3C58", Offset = "0x10A3C58")]
		public float minAimDistance;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC40")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3869C08", Offset = "0x3869C08", VA = "0x3869C08")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3869C88", Offset = "0x3869C88", VA = "0x3869C88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3869F7C", Offset = "0x3869F7C", VA = "0x3869F7C")]
		private void Pose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x386A444", Offset = "0x386A444", VA = "0x386A444")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x386A81C", Offset = "0x386A81C", VA = "0x386A81C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x386A9F0", Offset = "0x386A9F0", VA = "0x386A9F0")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AimIK aimIK;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E3")]
		public float min;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float max;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC50")]
		public float lerpSpeed;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit hit;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 offset;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x386C918", Offset = "0x386C918", VA = "0x386C918")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x386CE90", Offset = "0x386CE90", VA = "0x386CE90")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x386D390", Offset = "0x386D390", VA = "0x386D390")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Animator animator;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14EB")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC60")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtWeight;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F3")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC70")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14FB")]
		public float footPositionWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float footRotationWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC80")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float handPositionWeight;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float handRotationWeight;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x3846ED0", Offset = "0x3846ED0", VA = "0x3846ED0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x3847DEC", Offset = "0x3847DEC", VA = "0x3847DEC")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1503")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float scale;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EC90")]
		public Transform body;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float legRotationWeight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150B")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float breatheSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ECA0")]
		public float breatheMagnitude;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float height;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minHeight;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastHeight;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1513")]
		public float raycastDistance;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ECB0")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sine;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit rootHit;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x385D688", Offset = "0x385D688", VA = "0x385D688")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x385ED48", Offset = "0x385ED48", VA = "0x385ED48")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x385E6AC", Offset = "0x385E6AC", VA = "0x385E6AC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x385F094", Offset = "0x385F094", VA = "0x385F094")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpider mechSpider;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151B")]
		public Transform cameraTransform;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float speed;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ECC0")]
		public float turnSpeed;

		[Token(Token = "0x17000023")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x385F194", Offset = "0x385F194", VA = "0x385F194")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x385F294", Offset = "0x385F294", VA = "0x385F294")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x385F780", Offset = "0x385F780", VA = "0x385F780")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A30A0", Offset = "0x10A30A0")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int <>1__state;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578ECF0")]
			private object <>2__current;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x386173C", Offset = "0x386173C", VA = "0x386173C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x386180C", Offset = "0x386180C", VA = "0x386180C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x3860C34", Offset = "0x3860C34", VA = "0x3860C34")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x3860D48", Offset = "0x3860D48", VA = "0x3860D48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x3860D5C", Offset = "0x3860D5C", VA = "0x3860D5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x386176C", Offset = "0x386176C", VA = "0x386176C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1523")]
		public float minDelay;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float maxOffset;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ECD0")]
		public float stepSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float footHeight;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float velocityPrediction;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastFocus;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152B")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public ParticleSystem sand;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ECE0")]
		private IK ik;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float stepProgress;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastStepTime;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1533")]
		private RaycastHit hit;

		[Token(Token = "0x17000024")]
		public bool isStepping
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x385F7DC", Offset = "0x385F7DC", VA = "0x385F7DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 position
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x385F024", Offset = "0x385F024", VA = "0x385F024")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x385F85C", Offset = "0x385F85C", VA = "0x385F85C")]
			set
			{
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x385F8EC", Offset = "0x385F8EC", VA = "0x385F8EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x385FC70", Offset = "0x385FC70", VA = "0x385FC70")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x38605AC", Offset = "0x38605AC", VA = "0x38605AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3860AFC", Offset = "0x3860AFC", VA = "0x3860AFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF420", Offset = "0x10AF420")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x3860C7C", Offset = "0x3860C7C", VA = "0x3860C7C")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153B")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private ParticleSystem particles;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x386183C", Offset = "0x386183C", VA = "0x386183C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x38619B0", Offset = "0x38619B0", VA = "0x38619B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x3861B64", Offset = "0x3861B64", VA = "0x3861B64")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public struct Warp
		{
			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1533")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC14C", Offset = "0x10AC14C")]
			public int animationLayer;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC1B0", Offset = "0x10AC1B0")]
			public string animationState;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578ED00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC214", Offset = "0x10AC214")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC278", Offset = "0x10AC278")]
			public Transform warpFrom;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC2DC", Offset = "0x10AC2DC")]
			public Transform warpTo;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC340", Offset = "0x10AC340")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000107")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000661")]
			PositionOffset,
			[Token(Token = "0x4000662")]
			Position
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3CBC", Offset = "0x10A3CBC")]
		public Animator animator;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3D20", Offset = "0x10A3D20")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10A3D84", Offset = "0x10A3D84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3D84", Offset = "0x10A3D84")]
		public Warp[] warps;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private EffectorMode lastMode;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x38437B4", Offset = "0x38437B4", VA = "0x38437B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x38437FC", Offset = "0x38437FC", VA = "0x38437FC")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x3843D40", Offset = "0x3843D40", VA = "0x3843D40", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x3844758", Offset = "0x3844758", VA = "0x3844758")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x3844934", Offset = "0x3844934", VA = "0x3844934")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A12F0", Offset = "0x10A12F0")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotateSpeed;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float blendSpeed;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxAngle;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1553")]
		public float moveSpeed;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float rootMotionWeight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED30")]
		protected Animator animator;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveInput;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 velocity;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3844964", Offset = "0x3844964", VA = "0x3844964", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x38449F0", Offset = "0x38449F0", VA = "0x38449F0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x3844E40", Offset = "0x3844E40", VA = "0x3844E40", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3845504", Offset = "0x3845504", VA = "0x3845504")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A13A0", Offset = "0x10A13A0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A13A0", Offset = "0x10A13A0")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x155B")]
		[SerializeField]
		private bool useIK;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A3E50", Offset = "0x10A3E50")]
		public float headLookWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED40")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AimIK aim;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1563")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED50")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimTarget;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3845590", Offset = "0x3845590", VA = "0x3845590")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3845634", Offset = "0x3845634", VA = "0x3845634", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x3845840", Offset = "0x3845840", VA = "0x3845840", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x3845A60", Offset = "0x3845A60", VA = "0x3845A60")]
		private void Read()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x3845D50", Offset = "0x3845D50", VA = "0x3845D50")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x3845E04", Offset = "0x3845E04", VA = "0x3845E04")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x38466A0", Offset = "0x38466A0", VA = "0x38466A0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x3846B14", Offset = "0x3846B14", VA = "0x3846B14")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A149C", Offset = "0x10A149C")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x3849C3C", Offset = "0x3849C3C", VA = "0x3849C3C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x3849CDC", Offset = "0x3849CDC", VA = "0x3849CDC", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x384A1B8", Offset = "0x384A1B8", VA = "0x384A1B8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x384A56C", Offset = "0x384A56C", VA = "0x384A56C")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A154C", Offset = "0x10A154C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x156B")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000026")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x384C19C", Offset = "0x384C19C", VA = "0x384C19C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x384C298", Offset = "0x384C298", VA = "0x384C298")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x384BBD4", Offset = "0x384BBD4", VA = "0x384BBD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x384BC98", Offset = "0x384BC98", VA = "0x384BC98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x384C394", Offset = "0x384C394", VA = "0x384C394")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A3ED4", Offset = "0x10A3ED4")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED60")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1573")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED70")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x3851E9C", Offset = "0x3851E9C", VA = "0x3851E9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x3852F40", Offset = "0x3852F40", VA = "0x3852F40")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleLocomotion character;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x157B")]
		public float forceMlp;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float upForce;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED80")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve scale;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1583")]
		private float weight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 defaultScale;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578ED90")]
		private Rigidbody r;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3852F70", Offset = "0x3852F70", VA = "0x3852F70")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3853088", Offset = "0x3853088", VA = "0x3853088")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x3853AF8", Offset = "0x3853AF8", VA = "0x3853AF8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x3853C88", Offset = "0x3853C88", VA = "0x3853C88")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Limb
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1593")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EDB0")]
			public float mappingWeight;

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x3854138", Offset = "0x3854138", VA = "0x3854138")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x38543F8", Offset = "0x38543F8", VA = "0x38543F8")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool disableAfterStart;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158B")]
		public Limb leftArm;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Limb rightArm;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EDA0")]
		public Limb leftLeg;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb rightLeg;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootPin;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x3853D94", Offset = "0x3853D94", VA = "0x3853D94")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x385424C", Offset = "0x385424C", VA = "0x385424C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x3854384", Offset = "0x3854384", VA = "0x3854384")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x38543B4", Offset = "0x38543B4", VA = "0x38543B4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x385443C", Offset = "0x385443C", VA = "0x385443C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3854534", Offset = "0x3854534", VA = "0x3854534")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x3854724", Offset = "0x3854724", VA = "0x3854724")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3F1C", Offset = "0x10A3F1C")]
		public Transform target;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3F80", Offset = "0x10A3F80")]
		public Transform pin;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EDC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A3FE4", Offset = "0x10A3FE4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4048", Offset = "0x10A4048")]
		public AimIK aim;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A40AC", Offset = "0x10A40AC")]
		public float weight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4110", Offset = "0x10A4110")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4174", Offset = "0x10A4174")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Animator animator;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3854754", Offset = "0x3854754", VA = "0x3854754")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x38547E0", Offset = "0x38547E0", VA = "0x38547E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x3854C5C", Offset = "0x3854C5C", VA = "0x3854C5C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EDD0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool leftHanded;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x3854C8C", Offset = "0x3854C8C", VA = "0x3854C8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x3854DBC", Offset = "0x3854DBC", VA = "0x3854DBC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x3854F10", Offset = "0x3854F10", VA = "0x3854F10")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x3855C24", Offset = "0x3855C24", VA = "0x3855C24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x3855E04", Offset = "0x3855E04", VA = "0x3855E04")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A41D8", Offset = "0x10A41D8")]
		public float aimWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4220", Offset = "0x10A4220")]
		public float sightWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15AB")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4268", Offset = "0x10A4268")]
		public float maxAngle;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EDE0")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B3")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EDF0")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15BB")]
		public Recoil recoil;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4418", Offset = "0x10A4418")]
		public float cameraRecoilWeight;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x3855E34", Offset = "0x3855E34", VA = "0x3855E34")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x3856184", Offset = "0x3856184", VA = "0x3856184")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x38561B4", Offset = "0x38561B4", VA = "0x38561B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x3856970", Offset = "0x3856970", VA = "0x3856970")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x3856CC8", Offset = "0x3856CC8", VA = "0x3856CC8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x385639C", Offset = "0x385639C", VA = "0x385639C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x385856C", Offset = "0x385856C", VA = "0x385856C")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A15FC", Offset = "0x10A15FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A15FC", Offset = "0x10A15FC")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4460", Offset = "0x10A4460")]
		public float walkSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sVel;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x38585F0", Offset = "0x38585F0", VA = "0x38585F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x38586A8", Offset = "0x38586A8", VA = "0x38586A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3858A28", Offset = "0x3858A28", VA = "0x3858A28")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x3858C1C", Offset = "0x3858C1C", VA = "0x3858C1C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C3")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE10")]
		private string colliderName;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x3859DE8", Offset = "0x3859DE8", VA = "0x3859DE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x385A0D8", Offset = "0x385A0D8", VA = "0x385A0D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x385A220", Offset = "0x385A220", VA = "0x385A220")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHandTarget;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15CB")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float crossFade;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE20")]
		public float speed;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x385A264", Offset = "0x385A264", VA = "0x385A264")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x385A59C", Offset = "0x385A59C", VA = "0x385A59C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x385AD78", Offset = "0x385AD78", VA = "0x385AD78")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem character1;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D3")]
		public InteractionSystem character2;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionObject handShake;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x385ADBC", Offset = "0x385ADBC", VA = "0x385ADBC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x385AF04", Offset = "0x385AF04", VA = "0x385AF04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x385B190", Offset = "0x385B190", VA = "0x385B190")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE30")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool interrupt;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject ball;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject benchMain;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15DB")]
		public InteractionObject benchHands;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionObject button;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE40")]
		public InteractionObject cigarette;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject door;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isSitting;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x385B1C0", Offset = "0x385B1C0", VA = "0x385B1C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x385BAB8", Offset = "0x385BAB8", VA = "0x385BAB8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A16F8", Offset = "0x10A16F8")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4520", Offset = "0x10A4520")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A45A0", Offset = "0x10A45A0")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x385BAE8", Offset = "0x385BAE8", VA = "0x385BAE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x385BB74", Offset = "0x385BB74", VA = "0x385BB74")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x385C034", Offset = "0x385C034", VA = "0x385C034")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class Partner
		{
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15EB")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform mouth;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EE60")]
			public Transform mouthTarget;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15F3")]
			public float bodyWeightVertical;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float neckRotationWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EE70")]
			public float headTiltAngle;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000B3")]
			private Transform neck
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x385D4F4", Offset = "0x385D4F4", VA = "0x385D4F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x385C0CC", Offset = "0x385C0CC", VA = "0x385C0CC")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x385C208", Offset = "0x385C208", VA = "0x385C208")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x385D174", Offset = "0x385D174", VA = "0x385D174")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x385D5F4", Offset = "0x385D5F4", VA = "0x385D5F4")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE50")]
		public Partner partner1;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Partner partner2;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int iterations;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x385C064", Offset = "0x385C064", VA = "0x385C064")]
		private void Start()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x385C124", Offset = "0x385C124", VA = "0x385C124")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x385D130", Offset = "0x385D130", VA = "0x385D130")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class MotionAbsorb : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class Absorber
		{
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC3A4", Offset = "0x10AC3A4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1603")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC408", Offset = "0x10AC408")]
			public float weight;

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x3862C80", Offset = "0x3862C80", VA = "0x3862C80")]
			public void SetToBone(IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x3862E28", Offset = "0x3862E28", VA = "0x3862E28")]
			public void SetEffectorWeights(IKSolverFullBodyBiped solver, float w)
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x3863028", Offset = "0x3863028", VA = "0x3863028")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A30DC", Offset = "0x10A30DC")]
		private sealed class <AbsorbMotion>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int <>1__state;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EE90")]
			private object <>2__current;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MotionAbsorb <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x3862F28", Offset = "0x3862F28", VA = "0x3862F28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x3862FF8", Offset = "0x3862FF8", VA = "0x3862FF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x38625B8", Offset = "0x38625B8", VA = "0x38625B8")]
			[DebuggerHidden]
			public <AbsorbMotion>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x3862654", Offset = "0x3862654", VA = "0x3862654", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x3862668", Offset = "0x3862668", VA = "0x3862668", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x3862F58", Offset = "0x3862F58", VA = "0x3862F58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4620", Offset = "0x10A4620")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15FB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4684", Offset = "0x10A4684")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A46E8", Offset = "0x10A46E8")]
		public float weight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EE80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A474C", Offset = "0x10A474C")]
		public AnimationCurve falloff;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A47B0", Offset = "0x10A47B0")]
		public float falloffSpeed;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3862480", Offset = "0x3862480", VA = "0x3862480")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x38624FC", Offset = "0x38624FC", VA = "0x38624FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF4D0", Offset = "0x10AF4D0")]
		private IEnumerator AbsorbMotion()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x3862600", Offset = "0x3862600", VA = "0x3862600")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Animator animator;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160B")]
		public Transform cube;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EEA0")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x386306C", Offset = "0x386306C", VA = "0x386306C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x3863148", Offset = "0x3863148", VA = "0x3863148")]
		private void Update()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3863288", Offset = "0x3863288", VA = "0x3863288")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x3863564", Offset = "0x3863564", VA = "0x3863564")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public class EffectorLink
		{
			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EEB0")]
			public float weightMultiplier;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x3863D98", Offset = "0x3863D98", VA = "0x3863D98")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1613")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x38635AC", Offset = "0x38635AC", VA = "0x38635AC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3863840", Offset = "0x3863840", VA = "0x3863840", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3863D68", Offset = "0x3863D68", VA = "0x3863D68")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A17A8", Offset = "0x10A17A8")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4814", Offset = "0x10A4814")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4814", Offset = "0x10A4814")]
		public float weight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A48B0", Offset = "0x10A48B0")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4914", Offset = "0x10A4914")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4994", Offset = "0x10A4994")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EEC0")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1623")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EED0")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162B")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EEE0")]
		private float lastWeight;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3863DDC", Offset = "0x3863DDC", VA = "0x3863DDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x386454C", Offset = "0x386454C", VA = "0x386454C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x38655F4", Offset = "0x38655F4", VA = "0x38655F4")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject obj;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1633")]
		public Transform pivot;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform holdPoint;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EEF0")]
		public float pickUpTime;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float holdWeight;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float holdWeightVel;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163B")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000028")]
		private bool holding
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x3866100", Offset = "0x3866100", VA = "0x3866100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3865E6C", Offset = "0x3865E6C", VA = "0x3865E6C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600021B")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x3866170", Offset = "0x3866170", VA = "0x3866170")]
		private void Start()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x38663E4", Offset = "0x38663E4", VA = "0x38663E4")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x3866738", Offset = "0x3866738", VA = "0x3866738")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x38668D4", Offset = "0x38668D4", VA = "0x38668D4")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x3866B7C", Offset = "0x3866B7C", VA = "0x3866B7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x3866F30", Offset = "0x3866F30", VA = "0x3866F30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x3867258", Offset = "0x3867258", VA = "0x3867258")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x38672A0", Offset = "0x38672A0", VA = "0x38672A0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3867708", Offset = "0x3867708", VA = "0x3867708")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x3867738", Offset = "0x3867738", VA = "0x3867738", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3867AE8", Offset = "0x3867AE8", VA = "0x3867AE8")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EF00")]
		public Transform root;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x3868C78", Offset = "0x3868C78", VA = "0x3868C78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x3868D1C", Offset = "0x3868D1C", VA = "0x3868D1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x38690C0", Offset = "0x38690C0", VA = "0x38690C0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1858", Offset = "0x10A1858")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float magnitude;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Recoil recoil;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x38690F0", Offset = "0x38690F0", VA = "0x38690F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x386917C", Offset = "0x386917C", VA = "0x386917C")]
		private void Update()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3869224", Offset = "0x3869224", VA = "0x3869224")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x38692C8", Offset = "0x38692C8", VA = "0x38692C8")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3118", Offset = "0x10A3118")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164B")]
			private object <>2__current;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float resetTime;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EF20")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x3869B08", Offset = "0x3869B08", VA = "0x3869B08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x3869BD8", Offset = "0x3869BD8", VA = "0x3869BD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x38695C8", Offset = "0x38695C8", VA = "0x38695C8")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x3869654", Offset = "0x3869654", VA = "0x3869654", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x3869668", Offset = "0x3869668", VA = "0x3869668", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x3869B38", Offset = "0x3869B38", VA = "0x3869B38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1643")]
		public float resetDelay;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EF10")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform defaultParent;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody r;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x386930C", Offset = "0x386930C", VA = "0x386930C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3869460", Offset = "0x3869460", VA = "0x3869460")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x38694E4", Offset = "0x38694E4", VA = "0x38694E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF580", Offset = "0x10AF580")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3869610", Offset = "0x3869610", VA = "0x3869610")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1908", Offset = "0x10A1908")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3154", Offset = "0x10A3154")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1653")]
			private int <>1__state;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private object <>2__current;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EF30")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x386C818", Offset = "0x386C818", VA = "0x386C818", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x386C8E8", Offset = "0x386C8E8", VA = "0x386C8E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x386C4B8", Offset = "0x386C4B8", VA = "0x386C4B8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x386C530", Offset = "0x386C530", VA = "0x386C530", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x386C544", Offset = "0x386C544", VA = "0x386C544", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x386C848", Offset = "0x386C848", VA = "0x386C848", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x386C2B8", Offset = "0x386C2B8", VA = "0x386C2B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x386C3FC", Offset = "0x386C3FC", VA = "0x386C3FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF630", Offset = "0x10AF630")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x386C500", Offset = "0x386C500", VA = "0x386C500")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class EffectorLink
		{
			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x165B")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EF40")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float spherecastRadius;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float minDistance;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1663")]
			public float lerpSpeed;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float minSwitchTime;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EF50")]
			public float releaseDistance;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool sliding;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float raycastDistance;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x166B")]
			private bool inTouch;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private RaycastHit hit;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EF60")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool initiated;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float nextSwitchTime;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1673")]
			private float speedF;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x386D540", Offset = "0x386D540", VA = "0x386D540")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x386F198", Offset = "0x386F198", VA = "0x386F198")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x386DBD4", Offset = "0x386DBD4", VA = "0x386DBD4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x386F380", Offset = "0x386F380", VA = "0x386F380")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x386F6BC", Offset = "0x386F6BC", VA = "0x386F6BC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x386F81C", Offset = "0x386F81C", VA = "0x386F81C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x386F97C", Offset = "0x386F97C", VA = "0x386F97C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x386EED4", Offset = "0x386EED4", VA = "0x386EED4")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x386FADC", Offset = "0x386FADC", VA = "0x386FADC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x386D438", Offset = "0x386D438", VA = "0x386D438")]
		private void Start()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x386DAE0", Offset = "0x386DAE0", VA = "0x386DAE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x386ECF0", Offset = "0x386ECF0", VA = "0x386ECF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x386F168", Offset = "0x386F168", VA = "0x386F168")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4C6C", Offset = "0x10A4C6C")]
		public Transform to;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EF70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4CD0", Offset = "0x10A4CD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4CD0", Offset = "0x10A4CD0")]
		public float transferMotion;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastPosition;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x386FBA8", Offset = "0x386FBA8", VA = "0x386FBA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x386FC20", Offset = "0x386FC20", VA = "0x386FC20")]
		private void Update()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x386FED4", Offset = "0x386FED4", VA = "0x386FED4")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167B")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float enableInputAtProgress;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x387081C", Offset = "0x387081C", VA = "0x387081C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x3871308", Offset = "0x3871308", VA = "0x3871308")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x3871620", Offset = "0x3871620", VA = "0x3871620")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EF80")]
		public GameObject[] characters;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x3859AB8", Offset = "0x3859AB8", VA = "0x3859AB8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3859C8C", Offset = "0x3859C8C", VA = "0x3859C8C")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3859DB8", Offset = "0x3859DB8", VA = "0x3859DB8")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3190", Offset = "0x10A3190")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x3868B78", Offset = "0x3868B78", VA = "0x3868B78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x3868C48", Offset = "0x3868C48", VA = "0x3868C48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x38682C4", Offset = "0x38682C4", VA = "0x38682C4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x38687D4", Offset = "0x38687D4", VA = "0x38687D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x38687E8", Offset = "0x38687E8", VA = "0x38687E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x3868BA8", Offset = "0x3868BA8", VA = "0x3868BA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxAngle;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float switchRotationTime;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float random;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1683")]
		public float rotationSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 movePosition;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EF90")]
		public float moveSpeed;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int characterLayer;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168B")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 velocity;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EFA0")]
		private Rigidbody r;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3867B18", Offset = "0x3867B18", VA = "0x3867B18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x3867DCC", Offset = "0x3867DCC", VA = "0x3867DCC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3867D10", Offset = "0x3867D10", VA = "0x3867D10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF6E0", Offset = "0x10AF6E0")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x386830C", Offset = "0x386830C", VA = "0x386830C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x386853C", Offset = "0x386853C", VA = "0x386853C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x386873C", Offset = "0x386873C", VA = "0x386873C")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1693")]
		public LimbIK limbIK;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4E20", Offset = "0x10A4E20")]
		public float weight;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3846C20", Offset = "0x3846C20", VA = "0x3846C20")]
		private void Start()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3846D18", Offset = "0x3846D18", VA = "0x3846D18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x3846E8C", Offset = "0x3846E8C", VA = "0x3846E8C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public class Part
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x3870024", Offset = "0x3870024", VA = "0x3870024")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x3870264", Offset = "0x3870264", VA = "0x3870264")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EFB0")]
		public Transform target;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Part[] parts;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x386FF1C", Offset = "0x386FF1C", VA = "0x386FF1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x3870234", Offset = "0x3870234", VA = "0x3870234")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A19B8", Offset = "0x10A19B8")]
	public class FixFeet : MonoBehaviour
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A4E68", Offset = "0x10A4E68")]
		public float weight;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EFC0")]
		private Vector3 relativePosL;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 relativePosR;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion relativeRotL;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion relativeRotR;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3858C60", Offset = "0x3858C60", VA = "0x3858C60")]
		private void Start()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x3858D00", Offset = "0x3858D00", VA = "0x3858D00")]
		public void Sample()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x38591F4", Offset = "0x38591F4", VA = "0x38591F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3859A74", Offset = "0x3859A74", VA = "0x3859A74")]
		public FixFeet()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Mirror : MonoBehaviour
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A3")]
		public Transform target;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform[] children;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EFD0")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3861B94", Offset = "0x3861B94", VA = "0x3861B94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x3861E9C", Offset = "0x3861E9C", VA = "0x3861E9C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x38621D8", Offset = "0x38621D8", VA = "0x38621D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x38623B8", Offset = "0x38623B8", VA = "0x38623B8")]
		public Mirror()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Phone : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A31CC", Offset = "0x10A31CC")]
		private sealed class <EnableDisplay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578EFE0")]
			private int <>1__state;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Phone <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x3865D6C", Offset = "0x3865D6C", VA = "0x3865D6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x3865E3C", Offset = "0x3865E3C", VA = "0x3865E3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x3865944", Offset = "0x3865944", VA = "0x3865944")]
			[DebuggerHidden]
			public <EnableDisplay>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x3865B70", Offset = "0x3865B70", VA = "0x3865B70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x3865B84", Offset = "0x3865B84", VA = "0x3865B84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x3865D9C", Offset = "0x3865D9C", VA = "0x3865D9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4EB0", Offset = "0x10A4EB0")]
		public Collider pickUpCollider;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4F14", Offset = "0x10A4F14")]
		public InteractionObject pickUpObject;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16AB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A4F78", Offset = "0x10A4F78")]
		public GameObject display;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform parent;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x38656F4", Offset = "0x38656F4", VA = "0x38656F4")]
		private void OnPickUp()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3865888", Offset = "0x3865888", VA = "0x3865888")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10AF790", Offset = "0x10AF790")]
		private IEnumerator EnableDisplay()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x386598C", Offset = "0x386598C", VA = "0x386598C")]
		private void OnButton1()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x38659A0", Offset = "0x38659A0", VA = "0x38659A0")]
		private void OnButton2()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3865A60", Offset = "0x3865A60", VA = "0x3865A60")]
		private void DropPhone()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3865B40", Offset = "0x3865B40", VA = "0x3865B40")]
		public Phone()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1A68", Offset = "0x10A1A68")]
	public class VRAimingController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public struct Targets
		{
			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform leftHand;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16CB")]
			public Transform rightHand;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Transform bendGoalLeftArm;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F030")]
			public Transform bendGoalRightArm;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BoneRotationOffset[] boneRotationOffsets;
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public enum Handedness
		{
			[Token(Token = "0x40006A2")]
			Right,
			[Token(Token = "0x40006A3")]
			Left
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public class BoneRotationOffset
		{
			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform transform;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F050")]
			public Vector3 value;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x3875D1C", Offset = "0x3875D1C", VA = "0x3875D1C")]
			public BoneRotationOffset()
			{
			}
		}

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A4FDC", Offset = "0x10A4FDC")]
		public VRAnimatorController animatorController;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5040", Offset = "0x10A5040")]
		public WeaponBase currentWeapon;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A50A4", Offset = "0x10A50A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A50A4", Offset = "0x10A50A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A50A4", Offset = "0x10A50A4")]
		public float weight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578EFF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5188", Offset = "0x10A5188")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A5188", Offset = "0x10A5188")]
		public float spineTwistWeight;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A5224", Offset = "0x10A5224")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5224", Offset = "0x10A5224")]
		public Handedness handedness;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A52D0", Offset = "0x10A52D0")]
		public float sideOffset;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5334", Offset = "0x10A5334")]
		public Targets leftHandedTargets;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16BB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5398", Offset = "0x10A5398")]
		public Targets rightHandedTargets;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A53FC", Offset = "0x10A53FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A53FC", Offset = "0x10A53FC")]
		public Transform weaponsPivot;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A54A8", Offset = "0x10A54A8")]
		public Transform weaponsAnchor;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A550C", Offset = "0x10A550C")]
		public Transform pivotMotionTarget;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5570", Offset = "0x10A5570")]
		public float lerpSpeed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A55D4", Offset = "0x10A55D4")]
		public float pivotMotionSmoothSpeed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5638", Offset = "0x10A5638")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A5638", Offset = "0x10A5638")]
		public float pivotMotionWeight;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A56D4", Offset = "0x10A56D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A56D4", Offset = "0x10A56D4")]
		public float aimVerticalLimit;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F010")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5770", Offset = "0x10A5770")]
		public float aimZ;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poserLeftHand;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16CB")]
		private Poser poserRightHand;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 pivotRelativePosition;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F020")]
		private Vector3 weaponsPivotLocalPosition;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultWeaponsAnchorLocalPosition;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimVel;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimRandom;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D3")]
		private float x;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float y;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F030")]
		private float aimWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 cameraPosition;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastCharacterPosition;

		[Token(Token = "0x17000029")]
		private Transform cam
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x38716D8", Offset = "0x38716D8", VA = "0x38716D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform characterController
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x387171C", Offset = "0x387171C", VA = "0x387171C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private Targets targets
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x3874094", Offset = "0x3874094", VA = "0x3874094")]
			get
			{
				return default(Targets);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3871760", Offset = "0x3871760", VA = "0x3871760")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3872110", Offset = "0x3872110", VA = "0x3872110")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x38740F0", Offset = "0x38740F0", VA = "0x38740F0")]
		private void RotateWeapon(float horAdd, float vertAdd)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x3871C6C", Offset = "0x3871C6C", VA = "0x3871C6C")]
		private Vector3 TargetsCameraPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x3871B5C", Offset = "0x3871B5C", VA = "0x3871B5C")]
		private void SetHandedness(Handedness h)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x3875040", Offset = "0x3875040", VA = "0x3875040")]
		private void TwistSpine()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x38754DC", Offset = "0x38754DC", VA = "0x38754DC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x3875894", Offset = "0x3875894", VA = "0x3875894")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x3875A74", Offset = "0x3875A74", VA = "0x3875A74")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3875C30", Offset = "0x3875C30", VA = "0x3875C30")]
		public VRAimingController()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1B18", Offset = "0x10A1B18")]
	public class VRAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A57D4", Offset = "0x10A57D4")]
		public VRSetup oculusSetup;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform characterController;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform cam;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16EB")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A5838", Offset = "0x10A5838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5838", Offset = "0x10A5838")]
		public Vector3 cameraOffset;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A58E4", Offset = "0x10A58E4")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F060")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5948", Offset = "0x10A5948")]
		public float linearAcceleration;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A59AC", Offset = "0x10A59AC")]
		public float maxViewAngle;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5A10", Offset = "0x10A5A10")]
		public float locomotionSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A5A74", Offset = "0x10A5A74")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F3")]
		private Animator animator;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 velocityC;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F070")]
		private bool rootCorrection;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 playerVelocity;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 playerLastPosition;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FixFeet fixFeet;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16FB")]
		private Transform cameraPivot;

		[Token(Token = "0x1700002C")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x3875D4C", Offset = "0x3875D4C", VA = "0x3875D4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF840", Offset = "0x10AF840")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x3875D8C", Offset = "0x3875D8C", VA = "0x3875D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF87C", Offset = "0x10AF87C")]
			private set
			{
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x3875DEC", Offset = "0x3875DEC", VA = "0x3875DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x3876244", Offset = "0x3876244", VA = "0x3876244")]
		private void Update()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x3876C2C", Offset = "0x3876C2C", VA = "0x3876C2C")]
		private Vector3 GetVelocityTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x3874840", Offset = "0x3874840", VA = "0x3874840")]
		public void RotateCharacter(Vector3 forward, float maxAngle, [Optional] Transform fix)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3876FE0", Offset = "0x3876FE0", VA = "0x3876FE0")]
		public VRAnimatorController()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1BC8", Offset = "0x10A1BC8")]
	public class VRCharacterController : MonoBehaviour
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float moveSpeed;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F080")]
		public float rotationSpeed;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A5AB0", Offset = "0x10A5AB0")]
		public float rotationRatchet;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public KeyCode ratchetRight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public KeyCode ratchetLeft;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1703")]
		public Transform forwardDirection;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private CharacterController characterController;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4081498", Offset = "0x4081498", VA = "0x4081498")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x40815F8", Offset = "0x40815F8", VA = "0x40815F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x4081D68", Offset = "0x4081D68", VA = "0x4081D68")]
		public VRCharacterController()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1C78", Offset = "0x10A1C78")]
	public class VRInteractionController : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F090")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5AF8", Offset = "0x10A5AF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A5AF8", Offset = "0x10A5AF8")]
		public float triggerTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A5B94", Offset = "0x10A5B94")]
		private InteractionSystem <interactionSystem>k__BackingField;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A5BD0", Offset = "0x10A5BD0")]
		private InteractionTrigger <currentTrigger>k__BackingField;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x1700002D")]
		public InteractionSystem interactionSystem
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x4081DFC", Offset = "0x4081DFC", VA = "0x4081DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF8B8", Offset = "0x10AF8B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x4081E2C", Offset = "0x4081E2C", VA = "0x4081E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF8F4", Offset = "0x10AF8F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float triggerProgress
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x4081E64", Offset = "0x4081E64", VA = "0x4081E64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public InteractionTrigger currentTrigger
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x4081EEC", Offset = "0x4081EEC", VA = "0x4081EEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF930", Offset = "0x10AF930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x4081F1C", Offset = "0x4081F1C", VA = "0x4081F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF96C", Offset = "0x10AF96C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x4081F54", Offset = "0x4081F54", VA = "0x4081F54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x4081FEC", Offset = "0x4081FEC", VA = "0x4081FEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4082214", Offset = "0x4082214", VA = "0x4082214")]
		private bool CanTrigger(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x40822F4", Offset = "0x40822F4", VA = "0x40822F4")]
		public VRInteractionController()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1D28", Offset = "0x10A1D28")]
	public class VRInteractionUI : MonoBehaviour
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170B")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A5C0C", Offset = "0x10A5C0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5C0C", Offset = "0x10A5C0C")]
		public Slider slider;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5CB8", Offset = "0x10A5CB8")]
		public AnimationCurve alphaToProgress;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F0A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A5D1C", Offset = "0x10A5D1C")]
		public Transform cursor;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private VRInteractionController interactionController;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Image[] sliderImages;

		[Token(Token = "0x40002A4")]
		private const string showCursorTag = "ShowCursor";

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4082338", Offset = "0x4082338", VA = "0x4082338")]
		private void Start()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x4082404", Offset = "0x4082404", VA = "0x4082404")]
		private void Update()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4082444", Offset = "0x4082444", VA = "0x4082444")]
		private void UpdateInteractionSlider()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x4082854", Offset = "0x4082854", VA = "0x4082854")]
		private void UpdateCursor()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x4082BE4", Offset = "0x4082BE4", VA = "0x4082BE4")]
		private void SetSliderAlpha(float a)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x4083100", Offset = "0x4083100", VA = "0x4083100")]
		public VRInteractionUI()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class VRSetup : MonoBehaviour
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1713")]
		public Text text;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public GameObject model;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F0B0")]
		public GameObject[] enableOnR;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VRCharacterController characterController;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool disableMovement;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A5D80", Offset = "0x10A5D80")]
		private bool <isFinished>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171B")]
		private float moveSpeed;

		[Token(Token = "0x17000030")]
		public bool isFinished
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x4083130", Offset = "0x4083130", VA = "0x4083130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF9A8", Offset = "0x10AF9A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x4083174", Offset = "0x4083174", VA = "0x4083174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AF9E4", Offset = "0x10AF9E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x40831C0", Offset = "0x40831C0", VA = "0x40831C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x4083420", Offset = "0x4083420", VA = "0x4083420")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x4083A00", Offset = "0x4083A00", VA = "0x4083A00")]
		public VRSetup()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public abstract class WeaponBase : MonoBehaviour
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A5DBC", Offset = "0x10A5DBC")]
		public Vector3 recoilDirection;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F0C0")]
		public float recoilAngleVertical;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float recoilAngleHorizontal;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float recoilRandom;

		[Token(Token = "0x6000287")]
		public abstract void Fire();

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4083A30", Offset = "0x4083A30", VA = "0x4083A30")]
		protected WeaponBase()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class WeaponRifle : WeaponBase
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A5E20", Offset = "0x10A5E20")]
		public Transform shootFrom;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1723")]
		public float range;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LayerMask hitLayers;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F0D0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A5E84", Offset = "0x10A5E84")]
		public ParticleSystem muzzleFlash;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem muzzleSmoke;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bulletHole;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem bulletHit;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x172B")]
		public float smokeFadeOutSpeed;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float smokeEmission;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4083B70", Offset = "0x4083B70", VA = "0x4083B70", Slot = "4")]
		public override void Fire()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4084058", Offset = "0x4084058", VA = "0x4084058")]
		private void Update()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x40842E0", Offset = "0x40842E0", VA = "0x40842E0")]
		public WeaponRifle()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F0E0")]
		public bool smoothFollow;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastPosition;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 localPosition;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1733")]
		private Quaternion localRotation;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000031")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x3847EE8", Offset = "0x3847EE8", VA = "0x3847EE8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x3847E88", Offset = "0x3847E88", VA = "0x3847E88", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x3847F0C", Offset = "0x3847F0C", VA = "0x3847F0C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x384808C", Offset = "0x384808C", VA = "0x384808C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x38484F0", Offset = "0x38484F0", VA = "0x38484F0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3848988", Offset = "0x3848988", VA = "0x3848988")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1DD8", Offset = "0x10A1DD8")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F0F0")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x38489E4", Offset = "0x38489E4", VA = "0x38489E4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x3848A84", Offset = "0x3848A84", VA = "0x3848A84", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x3848C80", Offset = "0x3848C80", VA = "0x3848C80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x3848F54", Offset = "0x3848F54", VA = "0x3848F54")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1E88", Offset = "0x10A1E88")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x173B")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F100")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A6050", Offset = "0x10A6050")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Animator animator;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1743")]
		private Vector3 lastForward;

		[Token(Token = "0x40002CA")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40002CB")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x17000032")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x38490B4", Offset = "0x38490B4", VA = "0x38490B4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x3848F84", Offset = "0x3848F84", VA = "0x3848F84", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x384905C", Offset = "0x384905C", VA = "0x384905C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x3849294", Offset = "0x3849294", VA = "0x3849294", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x3849AE0", Offset = "0x3849AE0", VA = "0x3849AE0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x3849BB4", Offset = "0x3849BB4", VA = "0x3849BB4")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1F38", Offset = "0x10A1F38")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A1F38", Offset = "0x10A1F38")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A60C0", Offset = "0x10A60C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A60C0", Offset = "0x10A60C0")]
		public Transform gravityTarget;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A616C", Offset = "0x10A616C")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174B")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F120")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1753")]
		protected Rigidbody r;

		[Token(Token = "0x40002D6")]
		protected const float half = 0.5f;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F130")]
		protected float originalHeight;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600029C")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x384A59C", Offset = "0x384A59C", VA = "0x384A59C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x384A84C", Offset = "0x384A84C", VA = "0x384A84C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x384AACC", Offset = "0x384AACC", VA = "0x384AACC", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x384AFA4", Offset = "0x384AFA4", VA = "0x384AFA4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x384B124", Offset = "0x384B124", VA = "0x384B124")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x384B500", Offset = "0x384B500", VA = "0x384B500")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x384B864", Offset = "0x384B864", VA = "0x384B864")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x384B8BC", Offset = "0x384B8BC", VA = "0x384B8BC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x384B914", Offset = "0x384B914", VA = "0x384B914")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x384BB28", Offset = "0x384BB28", VA = "0x384BB28")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public enum MoveMode
		{
			[Token(Token = "0x40006A7")]
			Directional,
			[Token(Token = "0x40006A8")]
			Strafe
		}

		[Token(Token = "0x2000117")]
		public struct AnimState
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1793")]
			public bool jump;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool crouch;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F1C0")]
			public bool onGround;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isStrafing;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float yVelocity;
		}

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A6318", Offset = "0x10A6318")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x175B")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public CameraController cam;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F140")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A637C", Offset = "0x10A637C")]
		public MoveMode moveMode;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool smoothPhysics;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1763")]
		public float platformFriction;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float groundStickyEffect;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F150")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A63E0", Offset = "0x10A63E0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float turnSpeed;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x176B")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A6444", Offset = "0x10A6444")]
		public float airSpeed;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F160")]
		public float airControl;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float jumpPower;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A64A8", Offset = "0x10A64A8")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1773")]
		public float wallRunMaxLength;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F170")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x177B")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10A6528", Offset = "0x10A6528")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A658C", Offset = "0x10A658C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F180")]
		public AnimState animState;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 normal;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1783")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F190")]
		private RaycastHit hit;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float jumpLeg;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float jumpEndTime;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float forwardMlp;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178B")]
		private float groundDistance;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float lastAirTime;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F1A0")]
		private float stickyForce;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunWeight;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1793")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool fixedFrame;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunEndTime;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 gravity;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179B")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float velocityY;

		[Token(Token = "0x17000033")]
		public bool onGround
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x384C3C4", Offset = "0x384C3C4", VA = "0x384C3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFA20", Offset = "0x10AFA20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x384C408", Offset = "0x384C408", VA = "0x384C408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFA5C", Offset = "0x10AFA5C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x384C454", Offset = "0x384C454", VA = "0x384C454", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x384C744", Offset = "0x384C744", VA = "0x384C744")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x384C804", Offset = "0x384C804", VA = "0x384C804", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x384CA30", Offset = "0x384CA30", VA = "0x384CA30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x384ED98", Offset = "0x384ED98", VA = "0x384ED98", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x384F670", Offset = "0x384F670", VA = "0x384F670", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x384D4A0", Offset = "0x384D4A0", VA = "0x384D4A0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x384F8E0", Offset = "0x384F8E0", VA = "0x384F8E0")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x38507B8", Offset = "0x38507B8", VA = "0x38507B8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x384EFF4", Offset = "0x384EFF4", VA = "0x384EFF4")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x38509AC", Offset = "0x38509AC", VA = "0x38509AC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x3851250", Offset = "0x3851250", VA = "0x3851250")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x385188C", Offset = "0x385188C", VA = "0x385188C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x384E354", Offset = "0x384E354", VA = "0x384E354")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x3851CC4", Offset = "0x3851CC4", VA = "0x3851CC4")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A2034", Offset = "0x10A2034")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public enum RotationMode
		{
			[Token(Token = "0x40006B0")]
			Smooth,
			[Token(Token = "0x40006B1")]
			Linear
		}

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A65C8", Offset = "0x10A65C8")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17AB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6648", Offset = "0x10A6648")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A66C8", Offset = "0x10A66C8")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F1E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6748", Offset = "0x10A6748")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A67C8", Offset = "0x10A67C8")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6848", Offset = "0x10A6848")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A68C8", Offset = "0x10A68C8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17B3")]
		private Animator animator;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float speed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F1F0")]
		private float angleVel;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float speedVel;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CharacterController characterController;

		[Token(Token = "0x17000034")]
		public bool isGrounded
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x386AA50", Offset = "0x386AA50", VA = "0x386AA50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFA98", Offset = "0x10AFA98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x386AA94", Offset = "0x386AA94", VA = "0x386AA94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFAD4", Offset = "0x10AFAD4")]
			private set
			{
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x386AAE0", Offset = "0x386AAE0", VA = "0x386AAE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x386ABD0", Offset = "0x386ABD0", VA = "0x386ABD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x386BC08", Offset = "0x386BC08", VA = "0x386BC08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x386AC68", Offset = "0x386AC68", VA = "0x386AC68")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x386B5EC", Offset = "0x386B5EC", VA = "0x386B5EC")]
		private void Move()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x386BC70", Offset = "0x386BC70", VA = "0x386BC70")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x386BE90", Offset = "0x386BE90", VA = "0x386BE90")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x386BF90", Offset = "0x386BF90", VA = "0x386BF90")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform moveTarget;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stoppingDistance;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stoppingThreshold;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x3870294", Offset = "0x3870294", VA = "0x3870294", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x3870764", Offset = "0x3870764", VA = "0x3870764")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		public struct State
		{
			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17BB")]
			public Vector3 lookPos;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool crouch;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F210")]
			public bool jump;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int actionIndex;
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C3")]
		public bool walkByDefault;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool canCrouch;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F210")]
		public bool canJump;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public State state;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Transform cam;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x3871680", Offset = "0x3871680", VA = "0x3871680")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x3870ACC", Offset = "0x3870ACC", VA = "0x3870ACC", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x38707C0", Offset = "0x38707C0", VA = "0x38707C0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x3846B70", Offset = "0x3846B70", VA = "0x3846B70")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x3846BF0", Offset = "0x3846BF0", VA = "0x3846BF0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17D3")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x386C018", Offset = "0x386C018", VA = "0x386C018")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x386C0A0", Offset = "0x386C0A0", VA = "0x386C0A0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x386C270", Offset = "0x386C270", VA = "0x386C270")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A20E4", Offset = "0x10A20E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A20E4", Offset = "0x10A20E4")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F230")]
		public BipedReferences references;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4086224", Offset = "0x4086224", VA = "0x4086224")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFB10", Offset = "0x10AFB10")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x40862A8", Offset = "0x40862A8", VA = "0x40862A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFB74", Offset = "0x10AFB74")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x408632C", Offset = "0x408632C", VA = "0x408632C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFBD8", Offset = "0x10AFBD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x40863B0", Offset = "0x40863B0", VA = "0x40863B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFC3C", Offset = "0x10AFC3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4086434", Offset = "0x4086434", VA = "0x4086434")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x40865F8", Offset = "0x40865F8", VA = "0x40865F8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x408665C", Offset = "0x408665C", VA = "0x408665C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x40866C8", Offset = "0x40866C8", VA = "0x40866C8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x4086734", Offset = "0x4086734", VA = "0x4086734")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x40867C4", Offset = "0x40867C4", VA = "0x40867C4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x408692C", Offset = "0x408692C", VA = "0x408692C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x4086998", Offset = "0x4086998", VA = "0x4086998")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4086A10", Offset = "0x4086A10", VA = "0x4086A10")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4086ADC", Offset = "0x4086ADC", VA = "0x4086ADC")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x4086B68", Offset = "0x4086B68", VA = "0x4086B68")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4086BF4", Offset = "0x4086BF4", VA = "0x4086BF4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x4086498", Offset = "0x4086498", VA = "0x4086498")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x4086C60", Offset = "0x4086C60", VA = "0x4086C60")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x4086C90", Offset = "0x4086C90", VA = "0x4086C90")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4086CC0", Offset = "0x4086CC0", VA = "0x4086CC0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x40872C8", Offset = "0x40872C8", VA = "0x40872C8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x4087424", Offset = "0x4087424", VA = "0x4087424", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x4087DA8", Offset = "0x4087DA8", VA = "0x4087DA8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x4088728", Offset = "0x4088728", VA = "0x4088728")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x408878C", Offset = "0x408878C", VA = "0x408878C")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17DB")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F240")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverAim aim;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Constraints pelvis;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17E3")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000035")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x4087098", Offset = "0x4087098", VA = "0x4087098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x4088A88", Offset = "0x4088A88", VA = "0x4088A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x4087804", Offset = "0x4087804", VA = "0x4087804")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x4088868", Offset = "0x4088868", VA = "0x4088868")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F250")]
		public Transform transform;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x17000037")]
		public bool isValid
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x4089680", Offset = "0x4089680", VA = "0x4089680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EA")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x408979C", Offset = "0x408979C", VA = "0x408979C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x40897CC", Offset = "0x40897CC", VA = "0x40897CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x408999C", Offset = "0x408999C", VA = "0x408999C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x40899CC", Offset = "0x40899CC", VA = "0x40899CC")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17EB")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F260")]
		private bool initiated;

		[Token(Token = "0x17000038")]
		private bool positionChanged
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x4089E10", Offset = "0x4089E10", VA = "0x4089E10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x4089A14", Offset = "0x4089A14", VA = "0x4089A14", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4089F44", Offset = "0x4089F44", VA = "0x4089F44")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4089F74", Offset = "0x4089F74", VA = "0x4089F74")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion rotation;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4089FBC", Offset = "0x4089FBC", VA = "0x4089FBC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x408A19C", Offset = "0x408A19C", VA = "0x408A19C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x408A1CC", Offset = "0x408A1CC", VA = "0x408A1CC")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion offset;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17F3")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F270")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x17000039")]
		private bool rotationChanged
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x408A604", Offset = "0x408A604", VA = "0x408A604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x408A214", Offset = "0x408A214", VA = "0x408A214", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x408A734", Offset = "0x408A734", VA = "0x408A734")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x408A764", Offset = "0x408A764", VA = "0x408A764")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class Constraints
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform transform;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17FB")]
		public Vector3 position;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A69F4", Offset = "0x10A69F4")]
		public float positionWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F280")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rotation;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A6A3C", Offset = "0x10A6A3C")]
		public float rotationWeight;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x408A7AC", Offset = "0x408A7AC", VA = "0x408A7AC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4087CD4", Offset = "0x4087CD4", VA = "0x4087CD4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4088150", Offset = "0x4088150", VA = "0x4088150")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4088D80", Offset = "0x4088D80", VA = "0x4088D80")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class Finger
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6A84", Offset = "0x10A6A84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A6A84", Offset = "0x10A6A84")]
		public float weight;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1803")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6B20", Offset = "0x10A6B20")]
		public Transform bone1;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6B84", Offset = "0x10A6B84")]
		public Transform bone2;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F290")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6BE8", Offset = "0x10A6BE8")]
		public Transform bone3;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6C4C", Offset = "0x10A6C4C")]
		public Transform tip;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6CB0", Offset = "0x10A6CB0")]
		public Transform target;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A6D14", Offset = "0x10A6D14")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180B")]
		private IKSolverLimb solver;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F2A0")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x409B84C", Offset = "0x409B84C", VA = "0x409B84C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFCA0", Offset = "0x10AFCA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x409B890", Offset = "0x409B890", VA = "0x409B890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFCDC", Offset = "0x10AFCDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x409B8DC", Offset = "0x409B8DC", VA = "0x409B8DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x409B930", Offset = "0x409B930", VA = "0x409B930")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x409B9A4", Offset = "0x409B9A4", VA = "0x409B9A4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x409BA00", Offset = "0x409BA00", VA = "0x409BA00")]
			set
			{
			}
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x409BB48", Offset = "0x409BB48", VA = "0x409BB48")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x409BE10", Offset = "0x409BE10", VA = "0x409BE10")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x409C36C", Offset = "0x409C36C", VA = "0x409C36C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x409C538", Offset = "0x409C538", VA = "0x409C538")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x409CB2C", Offset = "0x409CB2C", VA = "0x409CB2C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6D50", Offset = "0x10A6D50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A6D50", Offset = "0x10A6D50")]
		public float weight;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Finger[] fingers;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1813")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A6DEC", Offset = "0x10A6DEC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700003D")]
		public bool initiated
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x409CB70", Offset = "0x409CB70", VA = "0x409CB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFD18", Offset = "0x10AFD18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x409CBB4", Offset = "0x409CBB4", VA = "0x409CBB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AFD54", Offset = "0x10AFD54")]
			private set
			{
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x409CC00", Offset = "0x409CC00", VA = "0x409CC00")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x409CD50", Offset = "0x409CD50", VA = "0x409CD50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFD90", Offset = "0x10AFD90")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x409D4E4", Offset = "0x409D4E4", VA = "0x409D4E4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x409D8CC", Offset = "0x409D8CC", VA = "0x409D8CC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x409D2F8", Offset = "0x409D2F8", VA = "0x409D2F8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x409DC0C", Offset = "0x409DC0C", VA = "0x409DC0C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x409DD9C", Offset = "0x409DD9C", VA = "0x409DD9C")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x409DED8", Offset = "0x409DED8", VA = "0x409DED8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x409DFD0", Offset = "0x409DFD0", VA = "0x409DFD0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x409E000", Offset = "0x409E000", VA = "0x409E000", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x409E030", Offset = "0x409E030", VA = "0x409E030")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200011A")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6E28", Offset = "0x10A6E28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A6E28", Offset = "0x10A6E28")]
		public float weight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F2B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6EC4", Offset = "0x10A6EC4")]
		public Grounding solver;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool initiated;

		[Token(Token = "0x6000316")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x40A03E0", Offset = "0x40A03E0", VA = "0x40A03E0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x40A09AC", Offset = "0x40A09AC", VA = "0x40A09AC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x40A067C", Offset = "0x40A067C", VA = "0x40A067C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x40A0A10", Offset = "0x40A0A10", VA = "0x40A0A10")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600031C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x40A0E34", Offset = "0x40A0E34", VA = "0x40A0E34")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2190", Offset = "0x10A2190")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2190", Offset = "0x10A2190")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6F28", Offset = "0x10A6F28")]
		public BipedIK ik;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6F8C", Offset = "0x10A6F8C")]
		public float spineBend;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F2C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A6FF0", Offset = "0x10A6FF0")]
		public float spineSpeed;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] feet;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1823")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F2D0")]
		private float lastWeight;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x40A136C", Offset = "0x40A136C", VA = "0x40A136C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFDF4", Offset = "0x10AFDF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x40A13F0", Offset = "0x40A13F0", VA = "0x40A13F0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFE58", Offset = "0x10AFE58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x40A1474", Offset = "0x40A1474", VA = "0x40A1474", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x40A16B4", Offset = "0x40A16B4", VA = "0x40A16B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x40A18F0", Offset = "0x40A18F0", VA = "0x40A18F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x40A1A98", Offset = "0x40A1A98", VA = "0x40A1A98")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x40A2558", Offset = "0x40A2558", VA = "0x40A2558")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x40A2638", Offset = "0x40A2638", VA = "0x40A2638")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x40A3B18", Offset = "0x40A3B18", VA = "0x40A3B18")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x40A3DE4", Offset = "0x40A3DE4", VA = "0x40A3DE4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x40A41AC", Offset = "0x40A41AC", VA = "0x40A41AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x40A4498", Offset = "0x40A4498", VA = "0x40A4498")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A223C", Offset = "0x10A223C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A223C", Offset = "0x10A223C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200011B")]
		public class SpineEffector
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC4A8", Offset = "0x10AC4A8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC50C", Offset = "0x10AC50C")]
			public float horizontalWeight;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1833")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC570", Offset = "0x10AC570")]
			public float verticalWeight;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x40A6468", Offset = "0x40A6468", VA = "0x40A6468")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7054", Offset = "0x10A7054")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A70B8", Offset = "0x10A70B8")]
		public float spineBend;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A711C", Offset = "0x10A711C")]
		public float spineSpeed;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182B")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform[] feet;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F2E0")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool firstSolve;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x40A4598", Offset = "0x40A4598", VA = "0x40A4598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFEBC", Offset = "0x10AFEBC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x40A461C", Offset = "0x40A461C", VA = "0x40A461C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFF20", Offset = "0x10AFF20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x40A46A0", Offset = "0x40A46A0", VA = "0x40A46A0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFF84", Offset = "0x10AFF84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x40A4724", Offset = "0x40A4724", VA = "0x40A4724", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x40A481C", Offset = "0x40A481C", VA = "0x40A481C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x40A49CC", Offset = "0x40A49CC", VA = "0x40A49CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x40A4F1C", Offset = "0x40A4F1C", VA = "0x40A4F1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x40A4F4C", Offset = "0x40A4F4C", VA = "0x40A4F4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x40A4B84", Offset = "0x40A4B84", VA = "0x40A4B84")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x40A4F7C", Offset = "0x40A4F7C", VA = "0x40A4F7C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x40A5A60", Offset = "0x40A5A60", VA = "0x40A5A60")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x40A5E8C", Offset = "0x40A5E8C", VA = "0x40A5E8C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x40A6160", Offset = "0x40A6160", VA = "0x40A6160")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x40A6360", Offset = "0x40A6360", VA = "0x40A6360")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A22E8", Offset = "0x10A22E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A22E8", Offset = "0x10A22E8")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IK[] legs;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F2F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7180", Offset = "0x10A7180")]
		public Transform pelvis;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A71E4", Offset = "0x10A71E4")]
		public Transform characterRoot;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7248", Offset = "0x10A7248")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7248", Offset = "0x10A7248")]
		public float rootRotationWeight;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A72E4", Offset = "0x10A72E4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x183B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7348", Offset = "0x10A7348")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform[] feet;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F300")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int solvedFeet;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1843")]
		private bool solved;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float lastWeight;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x40A64AC", Offset = "0x40A64AC", VA = "0x40A64AC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10AFFE8", Offset = "0x10AFFE8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x40A6530", Offset = "0x40A6530", VA = "0x40A6530", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B004C", Offset = "0x10B004C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x40A65B4", Offset = "0x40A65B4", VA = "0x40A65B4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x40A65FC", Offset = "0x40A65FC", VA = "0x40A65FC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x40A6A5C", Offset = "0x40A6A5C", VA = "0x40A6A5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x40A6CAC", Offset = "0x40A6CAC", VA = "0x40A6CAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x40A7A90", Offset = "0x40A7A90", VA = "0x40A7A90")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x40A8074", Offset = "0x40A8074", VA = "0x40A8074")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x40A85FC", Offset = "0x40A85FC", VA = "0x40A85FC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x40A8850", Offset = "0x40A8850", VA = "0x40A8850")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x40A8C6C", Offset = "0x40A8C6C", VA = "0x40A8C6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x40A8FFC", Offset = "0x40A8FFC", VA = "0x40A8FFC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2394", Offset = "0x10A2394")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2394", Offset = "0x10A2394")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200011C")]
		public struct Foot
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x185B")]
			public IKSolver solver;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Transform transform;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F350")]
			public Quaternion rotation;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x40AA8B0", Offset = "0x40AA8B0", VA = "0x40AA8B0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F310")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A73AC", Offset = "0x10A73AC")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7410", Offset = "0x10A7410")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7410", Offset = "0x10A7410")]
		public float rootRotationWeight;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A74AC", Offset = "0x10A74AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A74AC", Offset = "0x10A74AC")]
		public float minRootRotation;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7548", Offset = "0x10A7548")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7548", Offset = "0x10A7548")]
		public float maxRootRotation;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A75E4", Offset = "0x10A75E4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7648", Offset = "0x10A7648")]
		public float maxLegOffset;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F320")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A76AC", Offset = "0x10A76AC")]
		public float maxForeLegOffset;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7710", Offset = "0x10A7710")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7710", Offset = "0x10A7710")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A77AC", Offset = "0x10A77AC")]
		public Transform characterRoot;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7810", Offset = "0x10A7810")]
		public Transform pelvis;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1853")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7874", Offset = "0x10A7874")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A78D8", Offset = "0x10A78D8")]
		public Transform head;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F330")]
		public IK[] legs;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IK[] forelegs;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Foot[] feet;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x185B")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F340")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1863")]
		private int solvedFeet;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool solved;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F350")]
		private float angle;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headRotation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x40A90FC", Offset = "0x40A90FC", VA = "0x40A90FC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B00B0", Offset = "0x10B00B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x40A9180", Offset = "0x40A9180", VA = "0x40A9180", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0114", Offset = "0x10B0114")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x40A9204", Offset = "0x40A9204", VA = "0x40A9204", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x40A926C", Offset = "0x40A926C", VA = "0x40A926C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x40A9628", Offset = "0x40A9628", VA = "0x40A9628")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x40A999C", Offset = "0x40A999C", VA = "0x40A999C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x40A9AF4", Offset = "0x40A9AF4", VA = "0x40A9AF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x40A9CAC", Offset = "0x40A9CAC", VA = "0x40A9CAC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x40AA2DC", Offset = "0x40AA2DC", VA = "0x40AA2DC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x40AA95C", Offset = "0x40AA95C", VA = "0x40AA95C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x40AAC30", Offset = "0x40AAC30", VA = "0x40AAC30")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x40AB440", Offset = "0x40AB440", VA = "0x40AB440")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x40AC6E4", Offset = "0x40AC6E4", VA = "0x40AC6E4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x40ACC8C", Offset = "0x40ACC8C", VA = "0x40ACC8C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x40AD018", Offset = "0x40AD018", VA = "0x40AD018")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x40AD720", Offset = "0x40AD720", VA = "0x40AD720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x40AD7A0", Offset = "0x40AD7A0", VA = "0x40AD7A0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x40ADB10", Offset = "0x40ADB10", VA = "0x40ADB10")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public enum Quality
		{
			[Token(Token = "0x40006BF")]
			Fastest,
			[Token(Token = "0x40006C0")]
			Simple,
			[Token(Token = "0x40006C1")]
			Best
		}

		[Token(Token = "0x200011E")]
		public class Leg
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1893")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC5D4", Offset = "0x10AC5D4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC610", Offset = "0x10AC610")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F3B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC64C", Offset = "0x10AC64C")]
			private Quaternion <rotationOffset>k__BackingField;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC688", Offset = "0x10AC688")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC6C4", Offset = "0x10AC6C4")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC700", Offset = "0x10AC700")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x189B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC73C", Offset = "0x10AC73C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC778", Offset = "0x10AC778")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F3C0")]
			private Grounding grounding;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float lastTime;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float deltaTime;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18A3")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Quaternion r;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F3D0")]
			private RaycastHit heelHit;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 up;

			[Token(Token = "0x170000BE")]
			public bool isGrounded
			{
				[Token(Token = "0x6000806")]
				[Address(RVA = "0x40B1644", Offset = "0x40B1644", VA = "0x40B1644")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B335C", Offset = "0x10B335C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000807")]
				[Address(RVA = "0x40B1688", Offset = "0x40B1688", VA = "0x40B1688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3398", Offset = "0x10B3398")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x40B16D4", Offset = "0x40B16D4", VA = "0x40B16D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B33D4", Offset = "0x10B33D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000809")]
				[Address(RVA = "0x40B1714", Offset = "0x40B1714", VA = "0x40B1714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3410", Offset = "0x10B3410")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rotationOffset
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0x40B1774", Offset = "0x40B1774", VA = "0x40B1774")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B344C", Offset = "0x10B344C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600080B")]
				[Address(RVA = "0x40B17BC", Offset = "0x40B17BC", VA = "0x40B17BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3488", Offset = "0x10B3488")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public bool initiated
			{
				[Token(Token = "0x600080C")]
				[Address(RVA = "0x40B18EC", Offset = "0x40B18EC", VA = "0x40B18EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B34C4", Offset = "0x10B34C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600080D")]
				[Address(RVA = "0x40B1930", Offset = "0x40B1930", VA = "0x40B1930")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3500", Offset = "0x10B3500")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public float heightFromGround
			{
				[Token(Token = "0x600080E")]
				[Address(RVA = "0x40B197C", Offset = "0x40B197C", VA = "0x40B197C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B353C", Offset = "0x10B353C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600080F")]
				[Address(RVA = "0x40B19AC", Offset = "0x40B19AC", VA = "0x40B19AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3578", Offset = "0x10B3578")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0x40B19E4", Offset = "0x40B19E4", VA = "0x40B19E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B35B4", Offset = "0x10B35B4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000811")]
				[Address(RVA = "0x40B1A24", Offset = "0x40B1A24", VA = "0x40B1A24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B35F0", Offset = "0x10B35F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public Transform transform
			{
				[Token(Token = "0x6000812")]
				[Address(RVA = "0x40B1A84", Offset = "0x40B1A84", VA = "0x40B1A84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B362C", Offset = "0x10B362C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x40B1AB4", Offset = "0x40B1AB4", VA = "0x40B1AB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3668", Offset = "0x10B3668")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public float IKOffset
			{
				[Token(Token = "0x6000814")]
				[Address(RVA = "0x40B1AEC", Offset = "0x40B1AEC", VA = "0x40B1AEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B36A4", Offset = "0x10B36A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x40B1B1C", Offset = "0x40B1B1C", VA = "0x40B1B1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B36E0", Offset = "0x10B36E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600081A")]
				[Address(RVA = "0x40B2F84", Offset = "0x40B2F84", VA = "0x40B2F84")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C7")]
			private float rootYOffset
			{
				[Token(Token = "0x6000823")]
				[Address(RVA = "0x40B3528", Offset = "0x40B3528", VA = "0x40B3528")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x40AEDB0", Offset = "0x40AEDB0", VA = "0x40AEDB0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x40B1B54", Offset = "0x40B1B54", VA = "0x40B1B54")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x40B0E24", Offset = "0x40B0E24", VA = "0x40B0E24")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x40AF004", Offset = "0x40AF004", VA = "0x40AF004")]
			public void Process()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x40B2930", Offset = "0x40B2930", VA = "0x40B2930")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x40B1C10", Offset = "0x40B1C10", VA = "0x40B1C10")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x40B3278", Offset = "0x40B3278", VA = "0x40B3278")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x40B21B0", Offset = "0x40B21B0", VA = "0x40B21B0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x40B2384", Offset = "0x40B2384", VA = "0x40B2384")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x40B3440", Offset = "0x40B3440", VA = "0x40B3440")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x40B30D8", Offset = "0x40B30D8", VA = "0x40B30D8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x40B3764", Offset = "0x40B3764", VA = "0x40B3764")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x40AEC9C", Offset = "0x40AEC9C", VA = "0x40AEC9C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200011F")]
		public class Pelvis
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC7B4", Offset = "0x10AC7B4")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC7F0", Offset = "0x10AC7F0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18AB")]
			private Grounding grounding;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F3E0")]
			private float damperF;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool initiated;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float lastTime;

			[Token(Token = "0x170000C8")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000825")]
				[Address(RVA = "0x40B39B8", Offset = "0x40B39B8", VA = "0x40B39B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B371C", Offset = "0x10B371C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000826")]
				[Address(RVA = "0x40B39F8", Offset = "0x40B39F8", VA = "0x40B39F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3758", Offset = "0x10B3758")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public float heightOffset
			{
				[Token(Token = "0x6000827")]
				[Address(RVA = "0x40B3A58", Offset = "0x40B3A58", VA = "0x40B3A58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3794", Offset = "0x10B3794")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000828")]
				[Address(RVA = "0x40B3A88", Offset = "0x40B3A88", VA = "0x40B3A88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B37D0", Offset = "0x10B37D0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x40AEF3C", Offset = "0x40AEF3C", VA = "0x40AEF3C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x40B0C98", Offset = "0x40B0C98", VA = "0x40B0C98")]
			public void Reset()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x40B3AC0", Offset = "0x40B3AC0", VA = "0x40B3AC0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x40B060C", Offset = "0x40B060C", VA = "0x40B060C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x40AED80", Offset = "0x40AED80", VA = "0x40AED80")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7978", Offset = "0x10A7978")]
		public LayerMask layers;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A79DC", Offset = "0x10A79DC")]
		public float maxStep;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1873")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7A40", Offset = "0x10A7A40")]
		public float heightOffset;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7AA4", Offset = "0x10A7AA4")]
		public float footSpeed;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F370")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7B08", Offset = "0x10A7B08")]
		public float footRadius;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7B6C", Offset = "0x10A7B6C")]
		public float prediction;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7BD0", Offset = "0x10A7BD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7BD0", Offset = "0x10A7BD0")]
		public float footRotationWeight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7C6C", Offset = "0x10A7C6C")]
		public float footRotationSpeed;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x187B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7CD0", Offset = "0x10A7CD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7CD0", Offset = "0x10A7CD0")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7D6C", Offset = "0x10A7D6C")]
		public bool rotateSolver;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F380")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7DD0", Offset = "0x10A7DD0")]
		public float pelvisSpeed;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7E34", Offset = "0x10A7E34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A7E34", Offset = "0x10A7E34")]
		public float pelvisDamper;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7ED0", Offset = "0x10A7ED0")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7F34", Offset = "0x10A7F34")]
		public float liftPelvisWeight;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1883")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7F98", Offset = "0x10A7F98")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A7FFC", Offset = "0x10A7FFC")]
		public Quality quality;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F390")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A8060", Offset = "0x10A8060")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A809C", Offset = "0x10A809C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A80D8", Offset = "0x10A80D8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A8114", Offset = "0x10A8114")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A8150", Offset = "0x10A8150")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool initiated;

		[Token(Token = "0x1700003E")]
		public Leg[] legs
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x40ADCA8", Offset = "0x40ADCA8", VA = "0x40ADCA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B0178", Offset = "0x10B0178")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x40ADCD8", Offset = "0x40ADCD8", VA = "0x40ADCD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B01B4", Offset = "0x10B01B4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x40ADD10", Offset = "0x40ADD10", VA = "0x40ADD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B01F0", Offset = "0x10B01F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x40ADD40", Offset = "0x40ADD40", VA = "0x40ADD40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B022C", Offset = "0x10B022C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool isGrounded
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x40ADD78", Offset = "0x40ADD78", VA = "0x40ADD78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B0268", Offset = "0x10B0268")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x40ADDBC", Offset = "0x40ADDBC", VA = "0x40ADDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B02A4", Offset = "0x10B02A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Transform root
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x40ADE08", Offset = "0x40ADE08", VA = "0x40ADE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B02E0", Offset = "0x10B02E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x40ADE38", Offset = "0x40ADE38", VA = "0x40ADE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B031C", Offset = "0x10B031C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x40ADE70", Offset = "0x40ADE70", VA = "0x40ADE70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B0358", Offset = "0x10B0358")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x40ADE98", Offset = "0x40ADE98", VA = "0x40ADE98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B0394", Offset = "0x10B0394")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x40ADF04", Offset = "0x40ADF04", VA = "0x40ADF04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 up
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x40A3CC8", Offset = "0x40A3CC8", VA = "0x40A3CC8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		private bool useRootRotation
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x40B0FD8", Offset = "0x40B0FD8", VA = "0x40B0FD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x40ADFF8", Offset = "0x40ADFF8", VA = "0x40ADFF8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x40AE9A0", Offset = "0x40AE9A0", VA = "0x40AE9A0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x40A1FA4", Offset = "0x40A1FA4", VA = "0x40A1FA4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x40A3358", Offset = "0x40A3358", VA = "0x40A3358")]
		public void Update()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x40A75F8", Offset = "0x40A75F8", VA = "0x40A75F8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x40A156C", Offset = "0x40A156C", VA = "0x40A156C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x40AEFA0", Offset = "0x40AEFA0", VA = "0x40AEFA0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x40B1160", Offset = "0x40B1160", VA = "0x40B1160")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x40B1448", Offset = "0x40B1448", VA = "0x40B1448")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x40A0EEC", Offset = "0x40A0EEC", VA = "0x40A0EEC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2440", Offset = "0x10A2440")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2440", Offset = "0x10A2440")]
	public class AimIK : IK
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverAim solver;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x408433C", Offset = "0x408433C", VA = "0x408433C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B03D0", Offset = "0x10B03D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x40843C0", Offset = "0x40843C0", VA = "0x40843C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0434", Offset = "0x10B0434")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x4084444", Offset = "0x4084444", VA = "0x4084444")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0498", Offset = "0x10B0498")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x40844C8", Offset = "0x40844C8", VA = "0x40844C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B04FC", Offset = "0x10B04FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x408454C", Offset = "0x408454C", VA = "0x408454C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0560", Offset = "0x10B0560")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x40845D0", Offset = "0x40845D0", VA = "0x40845D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x4084600", Offset = "0x4084600", VA = "0x4084600")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A24EC", Offset = "0x10A24EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A24EC", Offset = "0x10A24EC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18B3")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4089398", Offset = "0x4089398", VA = "0x4089398", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B05C4", Offset = "0x10B05C4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x408941C", Offset = "0x408941C", VA = "0x408941C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0628", Offset = "0x10B0628")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x40894A0", Offset = "0x40894A0", VA = "0x40894A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B068C", Offset = "0x10B068C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4089524", Offset = "0x4089524", VA = "0x4089524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B06F0", Offset = "0x10B06F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x40895A8", Offset = "0x40895A8", VA = "0x40895A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x40895D8", Offset = "0x40895D8", VA = "0x40895D8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2598", Offset = "0x10A2598")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2598", Offset = "0x10A2598")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x408A8C8", Offset = "0x408A8C8", VA = "0x408A8C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0754", Offset = "0x10B0754")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x408A94C", Offset = "0x408A94C", VA = "0x408A94C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B07B8", Offset = "0x10B07B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x408A9D0", Offset = "0x408A9D0", VA = "0x408A9D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B081C", Offset = "0x10B081C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x408AA54", Offset = "0x408AA54", VA = "0x408AA54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0880", Offset = "0x10B0880")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x408AAD8", Offset = "0x408AAD8", VA = "0x408AAD8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x408AB08", Offset = "0x408AB08", VA = "0x408AB08")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2644", Offset = "0x10A2644")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2644", Offset = "0x10A2644")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F3F0")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x408BAF4", Offset = "0x408BAF4", VA = "0x408BAF4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B08E4", Offset = "0x10B08E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x408BB78", Offset = "0x408BB78", VA = "0x408BB78", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0948", Offset = "0x10B0948")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x408BBFC", Offset = "0x408BBFC", VA = "0x408BBFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B09AC", Offset = "0x10B09AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x408BC80", Offset = "0x408BC80", VA = "0x408BC80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0A10", Offset = "0x10B0A10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x408BD04", Offset = "0x408BD04", VA = "0x408BD04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x408BD34", Offset = "0x408BD34", VA = "0x408BD34")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A26F0", Offset = "0x10A26F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A26F0", Offset = "0x10A26F0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BipedReferences references;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x409E0E8", Offset = "0x409E0E8", VA = "0x409E0E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0A74", Offset = "0x10B0A74")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x409E16C", Offset = "0x409E16C", VA = "0x409E16C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0AD8", Offset = "0x10B0AD8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x409E1F0", Offset = "0x409E1F0", VA = "0x409E1F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0B3C", Offset = "0x10B0B3C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x409E274", Offset = "0x409E274", VA = "0x409E274")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0BA0", Offset = "0x10B0BA0")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x409E2F8", Offset = "0x409E2F8", VA = "0x409E2F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0C04", Offset = "0x10B0C04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x409E37C", Offset = "0x409E37C", VA = "0x409E37C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0C68", Offset = "0x10B0C68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x409E400", Offset = "0x409E400", VA = "0x409E400")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x409E480", Offset = "0x409E480", VA = "0x409E480", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x409E4B0", Offset = "0x409E4B0", VA = "0x409E4B0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x409EA04", Offset = "0x409EA04", VA = "0x409EA04")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x409F094", Offset = "0x409F094", VA = "0x409F094")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0CCC", Offset = "0x10B0CCC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x409F0FC", Offset = "0x409F0FC", VA = "0x409F0FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0D30", Offset = "0x10B0D30")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x409F300", Offset = "0x409F300", VA = "0x409F300")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000393")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x4B238D4", Offset = "0x4B238D4", VA = "0x4B238D4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x4B23AE0", Offset = "0x4B23AE0", VA = "0x4B23AE0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4B23EE8", Offset = "0x4B23EE8", VA = "0x4B23EE8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000397")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000398")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4B23F88", Offset = "0x4B23F88", VA = "0x4B23F88")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IK[] IKComponents;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4B2B3F0", Offset = "0x4B2B3F0", VA = "0x4B2B3F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4B2B4E4", Offset = "0x4B2B4E4", VA = "0x4B2B4E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4B2B5EC", Offset = "0x4B2B5EC", VA = "0x4B2B5EC")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A279C", Offset = "0x10A279C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A279C", Offset = "0x10A279C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18BB")]
		public IKSolverLimb solver;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x45AABEC", Offset = "0x45AABEC", VA = "0x45AABEC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0D94", Offset = "0x10B0D94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x45AAC70", Offset = "0x45AAC70", VA = "0x45AAC70", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0DF8", Offset = "0x10B0DF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x45AACF4", Offset = "0x45AACF4", VA = "0x45AACF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0E5C", Offset = "0x10B0E5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x45AAD78", Offset = "0x45AAD78", VA = "0x45AAD78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0EC0", Offset = "0x10B0EC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x45AADFC", Offset = "0x45AADFC", VA = "0x45AADFC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x45AAE2C", Offset = "0x45AAE2C", VA = "0x45AAE2C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2848", Offset = "0x10A2848")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2848", Offset = "0x10A2848")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x45AAED4", Offset = "0x45AAED4", VA = "0x45AAED4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0F24", Offset = "0x10B0F24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x45AAF58", Offset = "0x45AAF58", VA = "0x45AAF58", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0F88", Offset = "0x10B0F88")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x45AAFDC", Offset = "0x45AAFDC", VA = "0x45AAFDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B0FEC", Offset = "0x10B0FEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x45AB060", Offset = "0x45AB060", VA = "0x45AB060")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1050", Offset = "0x10B1050")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x45AB0E4", Offset = "0x45AB0E4", VA = "0x45AB0E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x45AB114", Offset = "0x45AB114", VA = "0x45AB114")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A28F4", Offset = "0x10A28F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A28F4", Offset = "0x10A28F4")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F400")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x45BBEC4", Offset = "0x45BBEC4", VA = "0x45BBEC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B10B4", Offset = "0x10B10B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x45BBF48", Offset = "0x45BBF48", VA = "0x45BBF48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1118", Offset = "0x10B1118")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x45BBFCC", Offset = "0x45BBFCC", VA = "0x45BBFCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B117C", Offset = "0x10B117C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x45BC050", Offset = "0x45BC050", VA = "0x45BC050")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B11E0", Offset = "0x10B11E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x45BC0D4", Offset = "0x45BC0D4", VA = "0x45BC0D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x45BC104", Offset = "0x45BC104", VA = "0x45BC104")]
		public TrigonometricIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FABRIK ik;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A818C", Offset = "0x10A818C")]
		public float pull;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A81D4", Offset = "0x10A81D4")]
		public float pin;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C3")]
		public int[] children;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x408ABB0", Offset = "0x408ABB0", VA = "0x408ABB0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x408ADB4", Offset = "0x408ADB4", VA = "0x408ADB4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x408AE0C", Offset = "0x408AE0C", VA = "0x408AE0C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x408B7B0", Offset = "0x408B7B0", VA = "0x408B7B0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x408B058", Offset = "0x408B058", VA = "0x408B058")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x408BA2C", Offset = "0x408BA2C", VA = "0x408BA2C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F410")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18CB")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F420")]
		private bool initiated;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x408BDDC", Offset = "0x408BDDC", VA = "0x408BDDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x408CA4C", Offset = "0x408CA4C", VA = "0x408CA4C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x408CE78", Offset = "0x408CE78", VA = "0x408CE78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x408D058", Offset = "0x408D058", VA = "0x408D058")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public class BendBone
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC82C", Offset = "0x10AC82C")]
			public Transform transform;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AC890", Offset = "0x10AC890")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AC890", Offset = "0x10AC890")]
			public float weight;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F4A0")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x4093D6C", Offset = "0x4093D6C", VA = "0x4093D6C")]
			public BendBone()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x4093E5C", Offset = "0x4093E5C", VA = "0x4093E5C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x408E094", Offset = "0x408E094", VA = "0x408E094")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x408EA04", Offset = "0x408EA04", VA = "0x408EA04")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A821C", Offset = "0x10A821C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10A8280", Offset = "0x10A8280")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8280", Offset = "0x10A8280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8280", Offset = "0x10A8280")]
		public float positionWeight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8364", Offset = "0x10A8364")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8364", Offset = "0x10A8364")]
		public float bodyWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18D3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8400", Offset = "0x10A8400")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8400", Offset = "0x10A8400")]
		public float thighWeight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10A849C", Offset = "0x10A849C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A849C", Offset = "0x10A849C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A849C", Offset = "0x10A849C")]
		public float rotationWeight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F430")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8580", Offset = "0x10A8580")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8580", Offset = "0x10A8580")]
		public float bodyClampWeight;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A861C", Offset = "0x10A861C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A861C", Offset = "0x10A861C")]
		public float headClampWeight;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A86B8", Offset = "0x10A86B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A86B8", Offset = "0x10A86B8")]
		public float bendWeight;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8754", Offset = "0x10A8754")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18DB")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10A87B8", Offset = "0x10A87B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A87B8", Offset = "0x10A87B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A87B8", Offset = "0x10A87B8")]
		public float CCDWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A889C", Offset = "0x10A889C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A889C", Offset = "0x10A889C")]
		public float roll;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F440")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8938", Offset = "0x10A8938")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8938", Offset = "0x10A8938")]
		public float damper;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A89D4", Offset = "0x10A89D4")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10A8A38", Offset = "0x10A8A38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8A38", Offset = "0x10A8A38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8A38", Offset = "0x10A8A38")]
		public float postStretchWeight;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8B1C", Offset = "0x10A8B1C")]
		public float maxStretch;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18E3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8B80", Offset = "0x10A8B80")]
		public float stretchDamper;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8BE4", Offset = "0x10A8BE4")]
		public bool fixHead;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F450")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A8C48", Offset = "0x10A8C48")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10A8CAC", Offset = "0x10A8CAC")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8D10", Offset = "0x10A8D10")]
		public float chestDirectionWeight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] chestBones;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18EB")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 offset;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F460")]
		private Vector3 headToBody;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18F3")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F470")]
		private float shoulderDist;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float leftShoulderDist;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float rightShoulderDist;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion chestRotation;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18FB")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F480")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1903")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F490")]
		private int bendBonesCount;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int ccdBonesCount;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int stretchBonesCount;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chestBonesCount;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x408D088", Offset = "0x408D088", VA = "0x408D088")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x408D640", Offset = "0x408D640", VA = "0x408D640")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x408E104", Offset = "0x408E104", VA = "0x408E104")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x408EA74", Offset = "0x408EA74", VA = "0x408EA74")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x408FFDC", Offset = "0x408FFDC", VA = "0x408FFDC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x40906C8", Offset = "0x40906C8", VA = "0x40906C8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x4090E78", Offset = "0x4090E78", VA = "0x4090E78")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4092958", Offset = "0x4092958", VA = "0x4092958")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x408F994", Offset = "0x408F994", VA = "0x408F994")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4092DD8", Offset = "0x4092DD8", VA = "0x4092DD8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x40926F0", Offset = "0x40926F0", VA = "0x40926F0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x40922B8", Offset = "0x40922B8", VA = "0x40922B8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x40935D4", Offset = "0x40935D4", VA = "0x40935D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4093AB8", Offset = "0x4093AB8", VA = "0x4093AB8")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000121")]
		public class ChildConstraint
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F4E0")]
			public float pushElasticity;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float pullElasticity;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1933")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC9A4", Offset = "0x10AC9A4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AC9E0", Offset = "0x10AC9E0")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F4F0")]
			private float crossFade;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float inverseCrossFade;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int chain1Index;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int chain2Index;

			[Token(Token = "0x170000CA")]
			public float nominalDistance
			{
				[Token(Token = "0x6000832")]
				[Address(RVA = "0x409B6C4", Offset = "0x409B6C4", VA = "0x409B6C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B380C", Offset = "0x10B380C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x409B6F4", Offset = "0x409B6F4", VA = "0x409B6F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3848", Offset = "0x10B3848")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public bool isRigid
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x409B72C", Offset = "0x409B72C", VA = "0x409B72C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3884", Offset = "0x10B3884")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000835")]
				[Address(RVA = "0x409B770", Offset = "0x409B770", VA = "0x409B770")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B38C0", Offset = "0x10B38C0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x409B7BC", Offset = "0x409B7BC", VA = "0x409B7BC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x4095AC4", Offset = "0x4095AC4", VA = "0x4095AC4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x409689C", Offset = "0x409689C", VA = "0x409689C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x409AF14", Offset = "0x409AF14", VA = "0x409AF14")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000122")]
		public enum Smoothing
		{
			[Token(Token = "0x40006E7")]
			None,
			[Token(Token = "0x40006E8")]
			Exponential,
			[Token(Token = "0x40006E9")]
			Cubic
		}

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8D58", Offset = "0x10A8D58")]
		public float pin;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8DA0", Offset = "0x10A8DA0")]
		public float pull;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8DE8", Offset = "0x10A8DE8")]
		public float push;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1913")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8E30", Offset = "0x10A8E30")]
		public float pushParent;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8E7C", Offset = "0x10A8E7C")]
		public float reach;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F4B0")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191B")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F4C0")]
		private float rootLength;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float length;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float distance;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1923")]
		private IKSolver.Point p;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float reachForce;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F4D0")]
		private float pullParentSum;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float[] crossFades;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sqrMag1;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sqrMag2;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192B")]
		private float sqrMagDif;

		[Token(Token = "0x4000402")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4093F7C", Offset = "0x4093F7C", VA = "0x4093F7C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x4094100", Offset = "0x4094100", VA = "0x4094100")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x40942F0", Offset = "0x40942F0", VA = "0x40942F0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x40944B0", Offset = "0x40944B0", VA = "0x40944B0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x4094694", Offset = "0x4094694", VA = "0x4094694")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4094954", Offset = "0x4094954", VA = "0x4094954")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4095B80", Offset = "0x4095B80", VA = "0x4095B80")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4094D60", Offset = "0x4094D60", VA = "0x4094D60")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x4096DF0", Offset = "0x4096DF0", VA = "0x4096DF0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x40977D0", Offset = "0x40977D0", VA = "0x40977D0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4098310", Offset = "0x4098310", VA = "0x4098310")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x409906C", Offset = "0x409906C", VA = "0x409906C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x409A0A8", Offset = "0x409A0A8", VA = "0x409A0A8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x409A7AC", Offset = "0x409A7AC", VA = "0x409A7AC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x4099E98", Offset = "0x4099E98", VA = "0x4099E98")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x4098C00", Offset = "0x4098C00", VA = "0x4098C00")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x4099DA4", Offset = "0x4099DA4", VA = "0x4099DA4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x409AA64", Offset = "0x409AA64", VA = "0x409AA64")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x4099AD4", Offset = "0x4099AD4", VA = "0x4099AD4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x409A404", Offset = "0x409A404", VA = "0x409A404")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone1;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone2;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1943")]
		public Transform bone3;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bendGoal;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F510")]
		public Vector3 direction;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8EC4", Offset = "0x10A8EC4")]
		public float weight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194B")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float clampF;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F520")]
		private int chainIndex1;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex1;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chainIndex2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex2;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1953")]
		private int chainIndex3;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int nodeIndex3;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F530")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A8F0C", Offset = "0x10A8F0C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000046")]
		public bool initiated
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x4B24594", Offset = "0x4B24594", VA = "0x4B24594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1244", Offset = "0x10B1244")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x4B245D8", Offset = "0x4B245D8", VA = "0x4B245D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1280", Offset = "0x10B1280")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x4B23FB8", Offset = "0x4B23FB8", VA = "0x4B23FB8")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x4B24624", Offset = "0x4B24624", VA = "0x4B24624")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x4B24718", Offset = "0x4B24718", VA = "0x4B24718")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x4B24848", Offset = "0x4B24848", VA = "0x4B24848")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4B248B0", Offset = "0x4B248B0", VA = "0x4B248B0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x4B2544C", Offset = "0x4B2544C", VA = "0x4B2544C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x4B258EC", Offset = "0x4B258EC", VA = "0x4B258EC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x4B26344", Offset = "0x4B26344", VA = "0x4B26344")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x4B2503C", Offset = "0x4B2503C", VA = "0x4B2503C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x4B25244", Offset = "0x4B25244", VA = "0x4B25244")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class IKEffector
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8F48", Offset = "0x10A8F48")]
		public float positionWeight;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x195B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A8F90", Offset = "0x10A8F90")]
		public float rotationWeight;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 position;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F540")]
		public Quaternion rotation;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 positionOffset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A8FD8", Offset = "0x10A8FD8")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool effectChildNodes;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1963")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9014", Offset = "0x10A9014")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform[] childBones;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F550")]
		public Transform planeBone1;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform planeBone2;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform planeBone3;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x196B")]
		private float posW;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float rotW;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F560")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1973")]
		private bool firstUpdate;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int chainIndex;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F570")]
		private int nodeIndex;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane1ChainIndex;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane1NodeIndex;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2ChainIndex;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x197B")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F580")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000047")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x4B273C8", Offset = "0x4B273C8", VA = "0x4B273C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B12BC", Offset = "0x10B12BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x4B2740C", Offset = "0x4B2740C", VA = "0x4B2740C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B12F8", Offset = "0x10B12F8")]
			private set
			{
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x4B27308", Offset = "0x4B27308", VA = "0x4B27308")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x4B27458", Offset = "0x4B27458", VA = "0x4B27458")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x4B27604", Offset = "0x4B27604", VA = "0x4B27604")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x4B278DC", Offset = "0x4B278DC", VA = "0x4B278DC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x4B27BEC", Offset = "0x4B27BEC", VA = "0x4B27BEC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4B285E8", Offset = "0x4B285E8", VA = "0x4B285E8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4B28C8C", Offset = "0x4B28C8C", VA = "0x4B28C8C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4B28F3C", Offset = "0x4B28F3C", VA = "0x4B28F3C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4B290C0", Offset = "0x4B290C0", VA = "0x4B290C0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x4B2A038", Offset = "0x4B2A038", VA = "0x4B2A038")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x4B2A10C", Offset = "0x4B2A10C", VA = "0x4B2A10C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x4B2A5E8", Offset = "0x4B2A5E8", VA = "0x4B2A5E8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x4B2ACC8", Offset = "0x4B2ACC8", VA = "0x4B2ACC8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public class BoneMap
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1983")]
			public int chainIndex;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int nodeIndex;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F590")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198B")]
			public Vector3 planePosition;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 ikPosition;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F5A0")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float length;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1993")]
			private Transform planeBone1;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Transform planeBone2;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F5B0")]
			private Transform planeBone3;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane1ChainIndex;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane1NodeIndex;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x199B")]
			private int plane2NodeIndex;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int plane3ChainIndex;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F5C0")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000CC")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600083B")]
				[Address(RVA = "0x4B2BC4C", Offset = "0x4B2BC4C", VA = "0x4B2BC4C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CD")]
			public bool isNodeBone
			{
				[Token(Token = "0x600083E")]
				[Address(RVA = "0x4B2BF3C", Offset = "0x4B2BF3C", VA = "0x4B2BF3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CE")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000852")]
				[Address(RVA = "0x4B2CAE4", Offset = "0x4B2CAE4", VA = "0x4B2CAE4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x4B2BBC0", Offset = "0x4B2BBC0", VA = "0x4B2BBC0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x4B2BD88", Offset = "0x4B2BD88", VA = "0x4B2BD88")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x4B2BE4C", Offset = "0x4B2BE4C", VA = "0x4B2BE4C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x4B2BFC4", Offset = "0x4B2BFC4", VA = "0x4B2BFC4")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x4B2C128", Offset = "0x4B2C128", VA = "0x4B2C128")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x4B2C16C", Offset = "0x4B2C16C", VA = "0x4B2C16C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x4B2C414", Offset = "0x4B2C414", VA = "0x4B2C414")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x4B2C608", Offset = "0x4B2C608", VA = "0x4B2C608")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x4B2C778", Offset = "0x4B2C778", VA = "0x4B2C778")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x4B2CF04", Offset = "0x4B2CF04", VA = "0x4B2CF04")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x4B2CF74", Offset = "0x4B2CF74", VA = "0x4B2CF74")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x4B2CFE4", Offset = "0x4B2CFE4", VA = "0x4B2CFE4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x4B2D054", Offset = "0x4B2D054", VA = "0x4B2D054")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x4B2D2E8", Offset = "0x4B2D2E8", VA = "0x4B2D2E8")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x4B2D9F0", Offset = "0x4B2D9F0", VA = "0x4B2D9F0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x4B2DA78", Offset = "0x4B2DA78", VA = "0x4B2DA78")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x4B2DD68", Offset = "0x4B2DD68", VA = "0x4B2DD68")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x4B2DE28", Offset = "0x4B2DE28", VA = "0x4B2DE28")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x4B2E2C4", Offset = "0x4B2E2C4", VA = "0x4B2E2C4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x4B2E710", Offset = "0x4B2E710", VA = "0x4B2E710")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x4B2E8C4", Offset = "0x4B2E8C4", VA = "0x4B2E8C4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x4B2D51C", Offset = "0x4B2D51C", VA = "0x4B2D51C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x4B2EC34", Offset = "0x4B2EC34", VA = "0x4B2EC34")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x4B2B61C", Offset = "0x4B2B61C", VA = "0x4B2B61C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x4B2B648", Offset = "0x4B2B648", VA = "0x4B2B648", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4B2B660", Offset = "0x4B2B660", VA = "0x4B2B660")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x4B2B980", Offset = "0x4B2B980", VA = "0x4B2B980")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4B2BB90", Offset = "0x4B2BB90", VA = "0x4B2BB90")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A905C", Offset = "0x10A905C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4B2ECD0", Offset = "0x4B2ECD0", VA = "0x4B2ECD0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x4B2EEB0", Offset = "0x4B2EEB0", VA = "0x4B2EEB0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x4B2EF68", Offset = "0x4B2EF68", VA = "0x4B2EF68")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x4B2F038", Offset = "0x4B2F038", VA = "0x4B2F038")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x4B2F080", Offset = "0x4B2F080", VA = "0x4B2F080")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x4B2F0D8", Offset = "0x4B2F0D8", VA = "0x4B2F0D8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x4B2F1E4", Offset = "0x4B2F1E4", VA = "0x4B2F1E4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x4B2F22C", Offset = "0x4B2F22C", VA = "0x4B2F22C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000124")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000701")]
			Parent,
			[Token(Token = "0x4000702")]
			Bone1,
			[Token(Token = "0x4000703")]
			Bone2,
			[Token(Token = "0x4000704")]
			Bone3
		}

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19A3")]
		public Transform parentBone;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bone1;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F5D0")]
		public Transform bone2;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone3;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A90A4", Offset = "0x10A90A4")]
		public float maintainRotationWeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A90EC", Offset = "0x10A90EC")]
		public float weight;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19AB")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneMap boneMap1;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F5E0")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x4B2F2A0", Offset = "0x4B2F2A0", VA = "0x4B2F2A0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x4B2F4A4", Offset = "0x4B2F4A4", VA = "0x4B2F4A4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x4B2F6B8", Offset = "0x4B2F6B8", VA = "0x4B2F6B8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x4B2FD50", Offset = "0x4B2FD50", VA = "0x4B2FD50")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x4B2FE80", Offset = "0x4B2FE80", VA = "0x4B2FE80")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x4B2FFFC", Offset = "0x4B2FFFC", VA = "0x4B2FFFC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x4B3007C", Offset = "0x4B3007C", VA = "0x4B3007C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x4B30214", Offset = "0x4B30214", VA = "0x4B30214")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x4B303E4", Offset = "0x4B303E4", VA = "0x4B303E4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x4B30948", Offset = "0x4B30948", VA = "0x4B30948")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x4B30AF4", Offset = "0x4B30AF4", VA = "0x4B30AF4")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] spineBones;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19BB")]
		public Transform leftThighBone;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rightThighBone;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F600")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9134", Offset = "0x10A9134")]
		public int iterations;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9180", Offset = "0x10A9180")]
		public float twistWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int rootNodeIndex;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap[] spine;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C3")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F610")]
		private BoneMap leftThigh;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap rightThigh;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool useFABRIK;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x4B30EA0", Offset = "0x4B30EA0", VA = "0x4B30EA0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x4B318DC", Offset = "0x4B318DC", VA = "0x4B318DC")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x4B31A58", Offset = "0x4B31A58", VA = "0x4B31A58")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x4B31C30", Offset = "0x4B31C30", VA = "0x4B31C30")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x4B31CC8", Offset = "0x4B31CC8", VA = "0x4B31CC8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x4B31DAC", Offset = "0x4B31DAC", VA = "0x4B31DAC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x4B31F6C", Offset = "0x4B31F6C", VA = "0x4B31F6C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x4B32F58", Offset = "0x4B32F58", VA = "0x4B32F58")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4B33030", Offset = "0x4B33030", VA = "0x4B33030")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x4B33644", Offset = "0x4B33644", VA = "0x4B33644")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x4B33F74", Offset = "0x4B33F74", VA = "0x4B33F74")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x4B34244", Offset = "0x4B34244", VA = "0x4B34244")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x4B34504", Offset = "0x4B34504", VA = "0x4B34504")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class Point
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F630")]
			public Transform transform;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10ACA1C", Offset = "0x10ACA1C")]
			public float weight;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19DB")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x4B38B28", Offset = "0x4B38B28", VA = "0x4B38B28")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x4B38BEC", Offset = "0x4B38BEC", VA = "0x4B38BEC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x4B38EC8", Offset = "0x4B38EC8", VA = "0x4B38EC8")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x4B38F38", Offset = "0x4B38F38", VA = "0x4B38F38")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x4B38FA8", Offset = "0x4B38FA8", VA = "0x4B38FA8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x4B3906C", Offset = "0x4B3906C", VA = "0x4B3906C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x4B382B0", Offset = "0x4B382B0", VA = "0x4B382B0")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000126")]
		public class Bone : Point
		{
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F640")]
			public float length;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float sqrMag;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 axis;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19E3")]
			private bool isLimited;

			[Token(Token = "0x170000CF")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0x4B368E0", Offset = "0x4B368E0", VA = "0x4B368E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x4B36B28", Offset = "0x4B36B28", VA = "0x4B36B28")]
				set
				{
				}
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x4B36C58", Offset = "0x4B36C58", VA = "0x4B36C58")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x4B371D8", Offset = "0x4B371D8", VA = "0x4B371D8")]
			public void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x4B37874", Offset = "0x4B37874", VA = "0x4B37874")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x4B37D34", Offset = "0x4B37D34", VA = "0x4B37D34")]
			public Quaternion GetSolverSwing(Vector3 swingTarget, float weight = 1f)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x4B38120", Offset = "0x4B38120", VA = "0x4B38120")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x4B38190", Offset = "0x4B38190", VA = "0x4B38190")]
			public Bone()
			{
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x4B383A0", Offset = "0x4B383A0", VA = "0x4B383A0")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x4B384D8", Offset = "0x4B384D8", VA = "0x4B384D8")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000127")]
		public class Node : Point
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float length;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F650")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 offset;

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x4B38A50", Offset = "0x4B38A50", VA = "0x4B38A50")]
			public Node()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x4B38A80", Offset = "0x4B38A80", VA = "0x4B38A80")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x4B38AC8", Offset = "0x4B38AC8", VA = "0x4B38AC8")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000128")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000129")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19CB")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9204", Offset = "0x10A9204")]
		public float IKPositionWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A924C", Offset = "0x10A924C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F620")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19D3")]
		protected bool firstInitiation;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000048")]
		public bool initiated
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x4B35198", Offset = "0x4B35198", VA = "0x4B35198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1334", Offset = "0x10B1334")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x4B351DC", Offset = "0x4B351DC", VA = "0x4B351DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1370", Offset = "0x10B1370")]
			private set
			{
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x4B34C50", Offset = "0x4B34C50", VA = "0x4B34C50")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x4B23B84", Offset = "0x4B23B84", VA = "0x4B23B84")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x4B239B4", Offset = "0x4B239B4", VA = "0x4B239B4")]
		public void Update()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x4B34F7C", Offset = "0x4B34F7C", VA = "0x4B34F7C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x4B34FBC", Offset = "0x4B34FBC", VA = "0x4B34FBC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4B3501C", Offset = "0x4B3501C", VA = "0x4B3501C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x4B3504C", Offset = "0x4B3504C", VA = "0x4B3504C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x4B35168", Offset = "0x4B35168", VA = "0x4B35168")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000427")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000428")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000429")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600042A")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600042B")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x4B35228", Offset = "0x4B35228", VA = "0x4B35228")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x4B35288", Offset = "0x4B35288", VA = "0x4B35288")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x4B3557C", Offset = "0x4B3557C", VA = "0x4B3557C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x4B35710", Offset = "0x4B35710", VA = "0x4B35710")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4B36240", Offset = "0x4B36240", VA = "0x4B36240")]
		public static void SolverRotateBonesAroundPoint(Bone[] bones, int index, Vector3 point, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x4B366E4", Offset = "0x4B366E4", VA = "0x4B366E4")]
		public static void SolverRotate(Bone[] bones, int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x4B36884", Offset = "0x4B36884", VA = "0x4B36884")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform transform;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19EB")]
		public Vector3 axis;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 poleAxis;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F660")]
		public Vector3 polePosition;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A92E4", Offset = "0x10A92E4")]
		public float poleWeight;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform poleTarget;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A932C", Offset = "0x10A932C")]
		public float clampWeight;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19F3")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9374", Offset = "0x10A9374")]
		public int clampSmoothing;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F670")]
		private float step;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lastTransform;

		[Token(Token = "0x17000049")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x4B393C0", Offset = "0x4B393C0", VA = "0x4B393C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x4B394FC", Offset = "0x4B394FC", VA = "0x4B394FC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		protected override int minBones
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x4B3B560", Offset = "0x4B3B560", VA = "0x4B3B560", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x4B3C378", Offset = "0x4B3C378", VA = "0x4B3C378", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x4B3922C", Offset = "0x4B3922C", VA = "0x4B3922C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x4B39638", Offset = "0x4B39638", VA = "0x4B39638", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x4B39BC4", Offset = "0x4B39BC4", VA = "0x4B39BC4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x4B3B258", Offset = "0x4B3B258", VA = "0x4B3B258")]
		private void Solve()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x4B3A980", Offset = "0x4B3A980", VA = "0x4B3A980")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x4B3B57C", Offset = "0x4B3B57C", VA = "0x4B3B57C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x4B3C4A4", Offset = "0x4B3C4A4", VA = "0x4B3C4A4")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19FB")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x4B3C6AC", Offset = "0x4B3C6AC", VA = "0x4B3C6AC")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x4B3C8C8", Offset = "0x4B3C8C8", VA = "0x4B3C8C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x4B3D590", Offset = "0x4B3D590", VA = "0x4B3D590", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x4B3E684", Offset = "0x4B3E684", VA = "0x4B3E684")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x4B3F76C", Offset = "0x4B3F76C", VA = "0x4B3F76C")]
		public static void SolveVirtual(Bone[] bones, Vector3 targetPosition, float weight)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x4B3FD4C", Offset = "0x4B3FD4C", VA = "0x4B3FD4C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F680")]
		private bool[] limitedBones;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x4B42760", Offset = "0x4B42760", VA = "0x4B42760", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x4B3FD7C", Offset = "0x4B3FD7C", VA = "0x4B3FD7C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x4B40E34", Offset = "0x4B40E34", VA = "0x4B40E34")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x4B410BC", Offset = "0x4B410BC", VA = "0x4B410BC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x4B411E8", Offset = "0x4B411E8", VA = "0x4B411E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x4B41DB0", Offset = "0x4B41DB0", VA = "0x4B41DB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x4B42784", Offset = "0x4B42784", VA = "0x4B42784")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x4B3FE98", Offset = "0x4B3FE98", VA = "0x4B3FE98")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x4B41020", Offset = "0x4B41020", VA = "0x4B41020")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x4B42670", Offset = "0x4B42670", VA = "0x4B42670")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x4B40908", Offset = "0x4B40908", VA = "0x4B40908")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x4B43E98", Offset = "0x4B43E98", VA = "0x4B43E98")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x4B4409C", Offset = "0x4B4409C", VA = "0x4B4409C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x4B44304", Offset = "0x4B44304", VA = "0x4B44304")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x4B44538", Offset = "0x4B44538", VA = "0x4B44538")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x4B41880", Offset = "0x4B41880", VA = "0x4B41880")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x4B41B20", Offset = "0x4B41B20", VA = "0x4B41B20")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x4B44928", Offset = "0x4B44928", VA = "0x4B44928")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x4B42F54", Offset = "0x4B42F54", VA = "0x4B42F54")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x4B40F54", Offset = "0x4B40F54", VA = "0x4B40F54")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x4B45A80", Offset = "0x4B45A80", VA = "0x4B45A80")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x4B44C64", Offset = "0x4B44C64", VA = "0x4B44C64")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x4B429E0", Offset = "0x4B429E0", VA = "0x4B429E0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x4B42CE8", Offset = "0x4B42CE8", VA = "0x4B42CE8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x4B45D40", Offset = "0x4B45D40", VA = "0x4B45D40")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int iterations;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A93BC", Offset = "0x10A93BC")]
		public float rootPin;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A03")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F690")]
		private bool[] isRoot;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x4B45E14", Offset = "0x4B45E14", VA = "0x4B45E14", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x4B472E4", Offset = "0x4B472E4", VA = "0x4B472E4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x4B47434", Offset = "0x4B47434", VA = "0x4B47434", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x4B47584", Offset = "0x4B47584", VA = "0x4B47584", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x4B477BC", Offset = "0x4B477BC", VA = "0x4B477BC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x4B479C0", Offset = "0x4B479C0", VA = "0x4B479C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x4B48684", Offset = "0x4B48684", VA = "0x4B48684", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x4B48ABC", Offset = "0x4B48ABC", VA = "0x4B48ABC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x4B487F4", Offset = "0x4B487F4", VA = "0x4B487F4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x4B47FE0", Offset = "0x4B47FE0", VA = "0x4B47FE0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x4B48C30", Offset = "0x4B48C30", VA = "0x4B48C30")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9404", Offset = "0x10A9404")]
		public int iterations;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0B")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F6A0")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A13")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F6B0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x4B48CE8", Offset = "0x4B48CE8", VA = "0x4B48CE8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x4B48F08", Offset = "0x4B48F08", VA = "0x4B48F08")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x4B48FDC", Offset = "0x4B48FDC", VA = "0x4B48FDC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x4B2725C", Offset = "0x4B2725C", VA = "0x4B2725C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x4B24F00", Offset = "0x4B24F00", VA = "0x4B24F00")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4B492AC", Offset = "0x4B492AC", VA = "0x4B492AC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4B49628", Offset = "0x4B49628", VA = "0x4B49628", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4B49980", Offset = "0x4B49980", VA = "0x4B49980", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x4B49F80", Offset = "0x4B49F80", VA = "0x4B49F80", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x4B4A18C", Offset = "0x4B4A18C", VA = "0x4B4A18C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x4B4A3CC", Offset = "0x4B4A3CC", VA = "0x4B4A3CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x4B4A770", Offset = "0x4B4A770", VA = "0x4B4A770", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4B4AB5C", Offset = "0x4B4AB5C", VA = "0x4B4AB5C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x4B4B1E4", Offset = "0x4B4B1E4", VA = "0x4B4B1E4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x4B4BA10", Offset = "0x4B4BA10", VA = "0x4B4BA10", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x4B4BA90", Offset = "0x4B4BA90", VA = "0x4B4BA90", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x4B4BD08", Offset = "0x4B4BD08", VA = "0x4B4BD08")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400047E")]
		Body,
		[Token(Token = "0x400047F")]
		LeftShoulder,
		[Token(Token = "0x4000480")]
		RightShoulder,
		[Token(Token = "0x4000481")]
		LeftThigh,
		[Token(Token = "0x4000482")]
		RightThigh,
		[Token(Token = "0x4000483")]
		LeftHand,
		[Token(Token = "0x4000484")]
		RightHand,
		[Token(Token = "0x4000485")]
		LeftFoot,
		[Token(Token = "0x4000486")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000488")]
		LeftArm,
		[Token(Token = "0x4000489")]
		RightArm,
		[Token(Token = "0x400048A")]
		LeftLeg,
		[Token(Token = "0x400048B")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rootNode;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A944C", Offset = "0x10A944C")]
		public float spineStiffness;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9494", Offset = "0x10A9494")]
		public float pullBodyVertical;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A33")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A94E0", Offset = "0x10A94E0")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A952C", Offset = "0x10A952C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F6F0")]
		private Vector3 offset;

		[Token(Token = "0x1700004E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x4B4BE74", Offset = "0x4B4BE74", VA = "0x4B4BE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x4B4BEB4", Offset = "0x4B4BEB4", VA = "0x4B4BEB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x4B4BEF4", Offset = "0x4B4BEF4", VA = "0x4B4BEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x4B4BF34", Offset = "0x4B4BF34", VA = "0x4B4BF34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x4B4BF74", Offset = "0x4B4BF74", VA = "0x4B4BF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x4B4BFB4", Offset = "0x4B4BFB4", VA = "0x4B4BFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x4B4BFF4", Offset = "0x4B4BFF4", VA = "0x4B4BFF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x4B4C034", Offset = "0x4B4C034", VA = "0x4B4C034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x4B4C074", Offset = "0x4B4C074", VA = "0x4B4C074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x4B4C0B4", Offset = "0x4B4C0B4", VA = "0x4B4C0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x4B4C114", Offset = "0x4B4C114", VA = "0x4B4C114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x4B4C174", Offset = "0x4B4C174", VA = "0x4B4C174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x4B4C1D4", Offset = "0x4B4C1D4", VA = "0x4B4C1D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x4B4C234", Offset = "0x4B4C234", VA = "0x4B4C234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x4B4C288", Offset = "0x4B4C288", VA = "0x4B4C288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x4B4C2E8", Offset = "0x4B4C2E8", VA = "0x4B4C2E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x4B4C348", Offset = "0x4B4C348", VA = "0x4B4C348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x4B4C3A8", Offset = "0x4B4C3A8", VA = "0x4B4C3A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x4B511F0", Offset = "0x4B511F0", VA = "0x4B511F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B13AC", Offset = "0x10B13AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x4B51230", Offset = "0x4B51230", VA = "0x4B51230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B13E8", Offset = "0x10B13E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x4B4C3FC", Offset = "0x4B4C3FC", VA = "0x4B4C3FC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x4B4C670", Offset = "0x4B4C670", VA = "0x4B4C670")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x4B4C4A0", Offset = "0x4B4C4A0", VA = "0x4B4C4A0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x4B4C80C", Offset = "0x4B4C80C", VA = "0x4B4C80C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x4B234E4", Offset = "0x4B234E4", VA = "0x4B234E4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x4B4CBCC", Offset = "0x4B4CBCC", VA = "0x4B4CBCC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x4B4CD9C", Offset = "0x4B4CD9C", VA = "0x4B4CD9C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x4B4CF60", Offset = "0x4B4CF60", VA = "0x4B4CF60")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x4B4D2BC", Offset = "0x4B4D2BC", VA = "0x4B4D2BC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x4B4D2EC", Offset = "0x4B4D2EC", VA = "0x4B4D2EC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x4B4D340", Offset = "0x4B4D340", VA = "0x4B4D340")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x4B4D560", Offset = "0x4B4D560", VA = "0x4B4D560", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x4B4DAA8", Offset = "0x4B4DAA8", VA = "0x4B4DAA8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x4B4FFB0", Offset = "0x4B4FFB0", VA = "0x4B4FFB0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4B50B78", Offset = "0x4B50B78", VA = "0x4B50B78")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x4B50C84", Offset = "0x4B50C84", VA = "0x4B50C84")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x4B50770", Offset = "0x4B50770", VA = "0x4B50770")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x4B50974", Offset = "0x4B50974", VA = "0x4B50974")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4B51290", Offset = "0x4B51290", VA = "0x4B51290")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x4B5148C", Offset = "0x4B5148C", VA = "0x4B5148C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x4B517DC", Offset = "0x4B517DC", VA = "0x4B517DC")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x4B51BA0", Offset = "0x4B51BA0", VA = "0x4B51BA0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4B51F44", Offset = "0x4B51F44", VA = "0x4B51F44")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4B523D4", Offset = "0x4B523D4", VA = "0x4B523D4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4B52B60", Offset = "0x4B52B60", VA = "0x4B52B60", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4B52D28", Offset = "0x4B52D28", VA = "0x4B52D28")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float tolerance;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int maxIterations;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A3B")]
		public bool useRotationLimits;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool XY;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F700")]
		public Bone[] bones;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float chainLength;

		[Token(Token = "0x17000061")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x4B53F74", Offset = "0x4B53F74", VA = "0x4B53F74", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x4B53F90", Offset = "0x4B53F90", VA = "0x4B53F90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x4B53FB4", Offset = "0x4B53FB4", VA = "0x4B53FB4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x4B54000", Offset = "0x4B54000", VA = "0x4B54000", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000065")]
		protected float positionOffset
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x4B3E53C", Offset = "0x4B3E53C", VA = "0x4B3E53C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4B52D7C", Offset = "0x4B52D7C", VA = "0x4B52D7C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x4B53108", Offset = "0x4B53108", VA = "0x4B53108")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x4B53388", Offset = "0x4B53388", VA = "0x4B53388", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4B5346C", Offset = "0x4B5346C", VA = "0x4B5346C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4B53584", Offset = "0x4B53584", VA = "0x4B53584", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4B53D0C", Offset = "0x4B53D0C", VA = "0x4B53D0C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4B53D54", Offset = "0x4B53D54", VA = "0x4B53D54", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4B53FD8", Offset = "0x4B53FD8", VA = "0x4B53FD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4B53FEC", Offset = "0x4B53FEC", VA = "0x4B53FEC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x4B3C9E0", Offset = "0x4B3C9E0", VA = "0x4B3C9E0")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x4B3DDAC", Offset = "0x4B3DDAC", VA = "0x4B3DDAC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x4B54268", Offset = "0x4B54268", VA = "0x4B54268")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4B3C5DC", Offset = "0x4B3C5DC", VA = "0x4B3C5DC")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public enum BendModifier
		{
			[Token(Token = "0x4000715")]
			Animation,
			[Token(Token = "0x4000716")]
			Target,
			[Token(Token = "0x4000717")]
			Parent,
			[Token(Token = "0x4000718")]
			Arm,
			[Token(Token = "0x4000719")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200012B")]
		public struct AxisDirection
		{
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 axis;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float dot;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x4586F48", Offset = "0x4586F48", VA = "0x4586F48")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A43")]
		public BendModifier bendModifier;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9568", Offset = "0x10A9568")]
		public float maintainRotationWeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F710")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A95B0", Offset = "0x10A95B0")]
		public float bendModifierWeight;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bendGoal;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4B")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F720")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A53")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F730")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000066")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x4B57700", Offset = "0x4B57700", VA = "0x4B57700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x4B54894", Offset = "0x4B54894", VA = "0x4B54894")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x4B54954", Offset = "0x4B54954", VA = "0x4B54954")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x4B54A00", Offset = "0x4B54A00", VA = "0x4B54A00", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x4B55640", Offset = "0x4B55640", VA = "0x4B55640", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x4B572D8", Offset = "0x4B572D8", VA = "0x4B572D8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x4B57538", Offset = "0x4B57538", VA = "0x4B57538")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x4B57610", Offset = "0x4B57610", VA = "0x4B57610")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x4B551A8", Offset = "0x4B551A8", VA = "0x4B551A8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x4B55924", Offset = "0x4B55924", VA = "0x4B55924")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200012C")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000D0")]
			public Vector3 forward
			{
				[Token(Token = "0x6000875")]
				[Address(RVA = "0x458B97C", Offset = "0x458B97C", VA = "0x458B97C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x458C99C", Offset = "0x458C99C", VA = "0x458C99C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x4589BB4", Offset = "0x4589BB4", VA = "0x4589BB4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x458A610", Offset = "0x458A610", VA = "0x458A610")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x458C3B4", Offset = "0x458C3B4", VA = "0x458C3B4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A63")]
		public Transform target;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F750")]
		public LookAtBone head;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A95F8", Offset = "0x10A95F8")]
		public float bodyWeight;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9640", Offset = "0x10A9640")]
		public float headWeight;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A6B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9688", Offset = "0x10A9688")]
		public float eyesWeight;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A96D0", Offset = "0x10A96D0")]
		public float clampWeight;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F760")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9718", Offset = "0x10A9718")]
		public float clampWeightHead;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9760", Offset = "0x10A9760")]
		public float clampWeightEyes;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A97A8", Offset = "0x10A97A8")]
		public int clampSmoothing;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A73")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3[] headForwards;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F770")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000067")]
		private bool spineIsValid
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x458855C", Offset = "0x458855C", VA = "0x458855C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x4588B70", Offset = "0x4588B70", VA = "0x4588B70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private bool headIsValid
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x4588824", Offset = "0x4588824", VA = "0x4588824")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x4588BEC", Offset = "0x4588BEC", VA = "0x4588BEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x45888A8", Offset = "0x45888A8", VA = "0x45888A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4588D1C", Offset = "0x4588D1C", VA = "0x4588D1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x4587008", Offset = "0x4587008", VA = "0x4587008")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x4587124", Offset = "0x4587124", VA = "0x4587124")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x4587274", Offset = "0x4587274", VA = "0x4587274")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x45873F4", Offset = "0x45873F4", VA = "0x45873F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x45875A4", Offset = "0x45875A4", VA = "0x45875A4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x45877B4", Offset = "0x45877B4", VA = "0x45877B4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x45879F4", Offset = "0x45879F4", VA = "0x45879F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4587CE4", Offset = "0x4587CE4", VA = "0x4587CE4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4588008", Offset = "0x4588008", VA = "0x4588008", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4588D98", Offset = "0x4588D98", VA = "0x4588D98", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x4589308", Offset = "0x4589308", VA = "0x4589308", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4589770", Offset = "0x4589770", VA = "0x4589770")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x4589BFC", Offset = "0x4589BFC", VA = "0x4589BFC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x458A838", Offset = "0x458A838", VA = "0x458A838", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x458AA30", Offset = "0x458AA30", VA = "0x458AA30")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x458AE8C", Offset = "0x458AE8C", VA = "0x458AE8C")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x458B45C", Offset = "0x458B45C", VA = "0x458B45C")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x458BAB8", Offset = "0x458BAB8", VA = "0x458BAB8")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x45898B8", Offset = "0x45898B8", VA = "0x45898B8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x458C638", Offset = "0x458C638", VA = "0x458C638")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200012D")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A83")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x4590D14", Offset = "0x4590D14", VA = "0x4590D14")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x459292C", Offset = "0x459292C", VA = "0x459292C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x4592184", Offset = "0x4592184", VA = "0x4592184")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x4592C84", Offset = "0x4592C84", VA = "0x4592C84")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A97F0", Offset = "0x10A97F0")]
		public float IKRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A7B")]
		public Vector3 bendNormal;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F780")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool directHierarchy;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x458C9CC", Offset = "0x458C9CC", VA = "0x458C9CC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x458CE48", Offset = "0x458CE48", VA = "0x458CE48")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x458D1E0", Offset = "0x458D1E0", VA = "0x458D1E0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x458D310", Offset = "0x458D310", VA = "0x458D310")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x458D42C", Offset = "0x458D42C", VA = "0x458D42C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x458D474", Offset = "0x458D474", VA = "0x458D474")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x458D4A4", Offset = "0x458D4A4", VA = "0x458D4A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x458D5EC", Offset = "0x458D5EC", VA = "0x458D5EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x458D8E8", Offset = "0x458D8E8", VA = "0x458D8E8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x458D970", Offset = "0x458D970", VA = "0x458D970", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x458D9F8", Offset = "0x458D9F8", VA = "0x458D9F8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x458E168", Offset = "0x458E168", VA = "0x458E168")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x458E258", Offset = "0x458E258", VA = "0x458E258")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x458F098", Offset = "0x458F098", VA = "0x458F098")]
		public static void SolveVirtual(Bone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x458FC48", Offset = "0x458FC48", VA = "0x458FC48")]
		public static void SolveVirtualPositions(Bone bone1, Bone bone2, Bone bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x458EC08", Offset = "0x458EC08", VA = "0x458EC08")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x4590614", Offset = "0x4590614", VA = "0x4590614", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4590A88", Offset = "0x4590A88", VA = "0x4590A88")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x4590900", Offset = "0x4590900", VA = "0x4590900")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x45910A4", Offset = "0x45910A4", VA = "0x45910A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4592AC8", Offset = "0x4592AC8", VA = "0x4592AC8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4592ADC", Offset = "0x4592ADC", VA = "0x4592ADC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4592AF0", Offset = "0x4592AF0", VA = "0x4592AF0", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x45922C0", Offset = "0x45922C0", VA = "0x45922C0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4592B04", Offset = "0x4592B04", VA = "0x4592B04")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F790")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9838", Offset = "0x10A9838")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A9838", Offset = "0x10A9838")]
		public float weight;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A98D4", Offset = "0x10A98D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10A98D4", Offset = "0x10A98D4")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9970", Offset = "0x10A9970")]
		public Transform parent;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A99D4", Offset = "0x10A99D4")]
		public Transform child;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9A38", Offset = "0x10A9A38")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9A9C", Offset = "0x10A9A9C")]
		public Vector3 axis;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F7A0")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x45BC1AC", Offset = "0x45BC1AC", VA = "0x45BC1AC")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x45BC984", Offset = "0x45BC984", VA = "0x45BC984")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x45BCCB0", Offset = "0x45BCCB0", VA = "0x45BCCB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x45BCCE0", Offset = "0x45BCCE0", VA = "0x45BCCE0")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class InteractionEffector
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A9B00", Offset = "0x10A9B00")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A9B3C", Offset = "0x10A9B3C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A93")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A9B78", Offset = "0x10A9B78")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Poser poser;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F7B0")]
		private IKEffector effector;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float length;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weight;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A9B")]
		private float fadeInSpeed;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F7C0")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPull;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultReach;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPush;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AA3")]
		private float defaultPushParent;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float resetTimer;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F7D0")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pullUsed;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool reachUsed;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AAB")]
		private bool pushUsed;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool pushParentUsed;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F7E0")]
		private bool pickedUp;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool defaults;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AB3")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F7F0")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform target;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<bool> triggered;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ABB")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool started;

		[Token(Token = "0x1700006D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x4593DCC", Offset = "0x4593DCC", VA = "0x4593DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1424", Offset = "0x10B1424")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x4593DFC", Offset = "0x4593DFC", VA = "0x4593DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1460", Offset = "0x10B1460")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isPaused
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x4593E34", Offset = "0x4593E34", VA = "0x4593E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B149C", Offset = "0x10B149C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x4593E78", Offset = "0x4593E78", VA = "0x4593E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B14D8", Offset = "0x10B14D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x4593EC4", Offset = "0x4593EC4", VA = "0x4593EC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1514", Offset = "0x10B1514")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x4593EF4", Offset = "0x4593EF4", VA = "0x4593EF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1550", Offset = "0x10B1550")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool inInteraction
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x4593F2C", Offset = "0x4593F2C", VA = "0x4593F2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public float progress
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x459A848", Offset = "0x459A848", VA = "0x459A848")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x459404C", Offset = "0x459404C", VA = "0x459404C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4594120", Offset = "0x4594120", VA = "0x4594120")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x459429C", Offset = "0x459429C", VA = "0x459429C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4594698", Offset = "0x4594698", VA = "0x4594698")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4595264", Offset = "0x4595264", VA = "0x4595264")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x45958B0", Offset = "0x45958B0", VA = "0x45958B0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x45959E4", Offset = "0x45959E4", VA = "0x45959E4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4597618", Offset = "0x4597618", VA = "0x4597618")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4599104", Offset = "0x4599104", VA = "0x4599104")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4599970", Offset = "0x4599970", VA = "0x4599970")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x459A438", Offset = "0x459A438", VA = "0x459A438")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x459B0B4", Offset = "0x459B0B4", VA = "0x459B0B4")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F800")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9BB4", Offset = "0x10A9BB4")]
		public LookAtIK ik;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9C18", Offset = "0x10A9C18")]
		public float lerpSpeed;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9C7C", Offset = "0x10A9C7C")]
		public float weightSpeed;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC3")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float stopLookTime;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F810")]
		private float weight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x459B6A4", Offset = "0x459B6A4", VA = "0x459B6A4")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x459BA54", Offset = "0x459BA54", VA = "0x459BA54")]
		public void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x459C06C", Offset = "0x459C06C", VA = "0x459C06C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x459C394", Offset = "0x459C394", VA = "0x459C394")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x459C5E0", Offset = "0x459C5E0", VA = "0x459C5E0")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A29A0", Offset = "0x10A29A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A29A0", Offset = "0x10A29A0")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class InteractionEvent
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACA64", Offset = "0x10ACA64")]
			public float time;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F830")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACAC8", Offset = "0x10ACAC8")]
			public bool pause;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACB2C", Offset = "0x10ACB2C")]
			public bool pickUp;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACB90", Offset = "0x10ACB90")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACBF4", Offset = "0x10ACBF4")]
			public Message[] messages;

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x459A908", Offset = "0x459A908", VA = "0x459A908")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x459F6A8", Offset = "0x459F6A8", VA = "0x459F6A8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012F")]
		public class Message
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ADB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACC58", Offset = "0x10ACC58")]
			public string function;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACCBC", Offset = "0x10ACCBC")]
			public GameObject recipient;

			[Token(Token = "0x4000726")]
			private const string empty = "";

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x459F4A0", Offset = "0x459F4A0", VA = "0x459F4A0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x459F6D8", Offset = "0x459F6D8", VA = "0x459F6D8")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACD20", Offset = "0x10ACD20")]
			public Animator animator;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACD84", Offset = "0x10ACD84")]
			public Animation animation;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACDE8", Offset = "0x10ACDE8")]
			public string animationState;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AE3")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACE4C", Offset = "0x10ACE4C")]
			public float crossfadeTime;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACEB0", Offset = "0x10ACEB0")]
			public int layer;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F850")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACF14", Offset = "0x10ACF14")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400072D")]
			private const string empty = "";

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x459EEE4", Offset = "0x459EEE4", VA = "0x459EEE4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x459F128", Offset = "0x459F128", VA = "0x459F128")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x459F2A4", Offset = "0x459F2A4", VA = "0x459F2A4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x459F458", Offset = "0x459F458", VA = "0x459F458")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000131")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200016B")]
			public enum Type
			{
				[Token(Token = "0x4000814")]
				PositionWeight,
				[Token(Token = "0x4000815")]
				RotationWeight,
				[Token(Token = "0x4000816")]
				PositionOffsetX,
				[Token(Token = "0x4000817")]
				PositionOffsetY,
				[Token(Token = "0x4000818")]
				PositionOffsetZ,
				[Token(Token = "0x4000819")]
				Pull,
				[Token(Token = "0x400081A")]
				Reach,
				[Token(Token = "0x400081B")]
				RotateBoneWeight,
				[Token(Token = "0x400081C")]
				Push,
				[Token(Token = "0x400081D")]
				PushParent,
				[Token(Token = "0x400081E")]
				PoserWeight
			}

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACF78", Offset = "0x10ACF78")]
			public Type type;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ACFDC", Offset = "0x10ACFDC")]
			public AnimationCurve curve;

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x459D750", Offset = "0x459D750", VA = "0x459D750")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x459F74C", Offset = "0x459F74C", VA = "0x459F74C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000132")]
		public class Multiplier
		{
			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AFB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD040", Offset = "0x10AD040")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD0A4", Offset = "0x10AD0A4")]
			public float multiplier;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F880")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD108", Offset = "0x10AD108")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x459EB80", Offset = "0x459EB80", VA = "0x459EB80")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x459F708", Offset = "0x459F708", VA = "0x459F708")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9D1C", Offset = "0x10A9D1C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9D80", Offset = "0x10A9D80")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ACB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9DE4", Offset = "0x10A9DE4")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F820")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A9E48", Offset = "0x10A9E48")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A9E84", Offset = "0x10A9E84")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AD3")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000072")]
		public float length
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x459C954", Offset = "0x459C954", VA = "0x459C954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B17E4", Offset = "0x10B17E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x459C984", Offset = "0x459C984", VA = "0x459C984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1820", Offset = "0x10B1820")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x459C9BC", Offset = "0x459C9BC", VA = "0x459C9BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B185C", Offset = "0x10B185C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x459C9EC", Offset = "0x459C9EC", VA = "0x459C9EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1898", Offset = "0x10B1898")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x459CF1C", Offset = "0x459CF1C", VA = "0x459CF1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x459AE3C", Offset = "0x459AE3C", VA = "0x459AE3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x459C63C", Offset = "0x459C63C", VA = "0x459C63C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B158C", Offset = "0x10B158C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x459C6C0", Offset = "0x459C6C0", VA = "0x459C6C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B15F0", Offset = "0x10B15F0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x459C744", Offset = "0x459C744", VA = "0x459C744")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1654", Offset = "0x10B1654")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x459C7C8", Offset = "0x459C7C8", VA = "0x459C7C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B16B8", Offset = "0x10B16B8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x459C84C", Offset = "0x459C84C", VA = "0x459C84C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B171C", Offset = "0x10B171C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x459C8D0", Offset = "0x459C8D0", VA = "0x459C8D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1780", Offset = "0x10B1780")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x459CA24", Offset = "0x459CA24", VA = "0x459CA24")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x459D068", Offset = "0x459D068", VA = "0x459D068")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x45968B0", Offset = "0x45968B0", VA = "0x45968B0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x459D440", Offset = "0x459D440", VA = "0x459D440")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x4596568", Offset = "0x4596568", VA = "0x4596568")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x4596870", Offset = "0x4596870", VA = "0x4596870")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x45986B0", Offset = "0x45986B0", VA = "0x45986B0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4599E74", Offset = "0x4599E74", VA = "0x4599E74")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x459EBF4", Offset = "0x459EBF4", VA = "0x459EBF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x459D7B0", Offset = "0x459D7B0", VA = "0x459D7B0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x459D470", Offset = "0x459D470", VA = "0x459D470")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x459EA68", Offset = "0x459EA68", VA = "0x459EA68")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x459EC24", Offset = "0x459EC24", VA = "0x459EC24")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x459ED3C", Offset = "0x459ED3C", VA = "0x459ED3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B18D4", Offset = "0x10B18D4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x459EDC0", Offset = "0x459EDC0", VA = "0x459EDC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1938", Offset = "0x10B1938")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x459EE44", Offset = "0x459EE44", VA = "0x459EE44")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2A4C", Offset = "0x10A2A4C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2A4C", Offset = "0x10A2A4C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000134")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9EC0", Offset = "0x10A9EC0")]
		public string targetTag;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9F24", Offset = "0x10A9F24")]
		public float fadeInTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9F88", Offset = "0x10A9F88")]
		public float speed;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B03")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10A9FEC", Offset = "0x10A9FEC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10AA050", Offset = "0x10AA050")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA050", Offset = "0x10AA050")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x10AA050", Offset = "0x10AA050")]
		public Collider characterCollider;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F890")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA144", Offset = "0x10AA144")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x10AA144", Offset = "0x10AA144")]
		public Transform FPSCamera;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA1F0", Offset = "0x10AA1F0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA254", Offset = "0x10AA254")]
		public float camRaycastDistance;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10AA2B8", Offset = "0x10AA2B8")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0B")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F8A0")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B13")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F8B0")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10AA2F4", Offset = "0x10AA2F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA2F4", Offset = "0x10AA2F4")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA3A0", Offset = "0x10AA3A0")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1B")]
		private bool initiated;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Collider lastCollider;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F8C0")]
		private Collider c;

		[Token(Token = "0x17000076")]
		public bool inInteraction
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x459FA94", Offset = "0x459FA94", VA = "0x459FA94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x45A4740", Offset = "0x45A4740", VA = "0x45A4740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x45A4770", Offset = "0x45A4770", VA = "0x45A4770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1BF4", Offset = "0x10B1BF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x45A47A0", Offset = "0x45A47A0", VA = "0x45A47A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B1C30", Offset = "0x10B1C30")]
			private set
			{
			}
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x459F77C", Offset = "0x459F77C", VA = "0x459F77C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B199C", Offset = "0x10B199C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x459F800", Offset = "0x459F800", VA = "0x459F800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1A00", Offset = "0x10B1A00")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x459F884", Offset = "0x459F884", VA = "0x459F884")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1A64", Offset = "0x10B1A64")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x459F908", Offset = "0x459F908", VA = "0x459F908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1AC8", Offset = "0x10B1AC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x459F98C", Offset = "0x459F98C", VA = "0x459F98C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1B2C", Offset = "0x10B1B2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x459FA10", Offset = "0x459FA10", VA = "0x459FA10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1B90", Offset = "0x10B1B90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x459FEB4", Offset = "0x459FEB4", VA = "0x459FEB4")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x45A0140", Offset = "0x45A0140", VA = "0x45A0140")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x45A0394", Offset = "0x45A0394", VA = "0x45A0394")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x45A0568", Offset = "0x45A0568", VA = "0x45A0568")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x45A0838", Offset = "0x45A0838", VA = "0x45A0838")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x45A0B64", Offset = "0x45A0B64", VA = "0x45A0B64")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x45A0D3C", Offset = "0x45A0D3C", VA = "0x45A0D3C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x45A0F14", Offset = "0x45A0F14", VA = "0x45A0F14")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x45A10EC", Offset = "0x45A10EC", VA = "0x45A10EC")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x45A1208", Offset = "0x45A1208", VA = "0x45A1208")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x45A1324", Offset = "0x45A1324", VA = "0x45A1324")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x45A140C", Offset = "0x45A140C", VA = "0x45A140C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x45A15C0", Offset = "0x45A15C0", VA = "0x45A15C0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x45A176C", Offset = "0x45A176C", VA = "0x45A176C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x45A1990", Offset = "0x45A1990", VA = "0x45A1990")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x45A214C", Offset = "0x45A214C", VA = "0x45A214C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x45A26DC", Offset = "0x45A26DC", VA = "0x45A26DC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x45A2E58", Offset = "0x45A2E58", VA = "0x45A2E58")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x45A34DC", Offset = "0x45A34DC", VA = "0x45A34DC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x45A35B4", Offset = "0x45A35B4", VA = "0x45A35B4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x45A3728", Offset = "0x45A3728", VA = "0x45A3728")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x45A398C", Offset = "0x45A398C", VA = "0x45A398C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x45A3D08", Offset = "0x45A3D08", VA = "0x45A3D08")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x45A44FC", Offset = "0x45A44FC", VA = "0x45A44FC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x45A3080", Offset = "0x45A3080", VA = "0x45A3080")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x45A47D8", Offset = "0x45A47D8", VA = "0x45A47D8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x45A5698", Offset = "0x45A5698", VA = "0x45A5698")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x45A56EC", Offset = "0x45A56EC", VA = "0x45A56EC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x45A5740", Offset = "0x45A5740", VA = "0x45A5740")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x45A5794", Offset = "0x45A5794", VA = "0x45A5794")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x45A587C", Offset = "0x45A587C", VA = "0x45A587C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x45A5A78", Offset = "0x45A5A78", VA = "0x45A5A78")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x45A5C1C", Offset = "0x45A5C1C", VA = "0x45A5C1C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x45A6458", Offset = "0x45A6458", VA = "0x45A6458")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x45A6688", Offset = "0x45A6688", VA = "0x45A6688")]
		private void Update()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x45A6B54", Offset = "0x45A6B54", VA = "0x45A6B54")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x45A4F90", Offset = "0x45A4F90", VA = "0x45A4F90")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x45A6D70", Offset = "0x45A6D70", VA = "0x45A6D70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x45A7058", Offset = "0x45A7058", VA = "0x45A7058")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x45A71C0", Offset = "0x45A71C0", VA = "0x45A71C0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x45A73E4", Offset = "0x45A73E4", VA = "0x45A73E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x459FC6C", Offset = "0x459FC6C", VA = "0x459FC6C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x45A1EB0", Offset = "0x45A1EB0", VA = "0x45A1EB0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x45A78A8", Offset = "0x45A78A8", VA = "0x45A78A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1C6C", Offset = "0x10B1C6C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x45A792C", Offset = "0x45A792C", VA = "0x45A792C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1CD0", Offset = "0x10B1CD0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x45A79B0", Offset = "0x45A79B0", VA = "0x45A79B0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2AF8", Offset = "0x10A2AF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2AF8", Offset = "0x10A2AF8")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class Multiplier
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD16C", Offset = "0x10AD16C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F8E0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD1D0", Offset = "0x10AD1D0")]
			public float multiplier;

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x45A8690", Offset = "0x45A8690", VA = "0x45A8690")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA404", Offset = "0x10AA404")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA468", Offset = "0x10AA468")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA4CC", Offset = "0x10AA4CC")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B23")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA530", Offset = "0x10AA530")]
		public Transform pivot;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA594", Offset = "0x10AA594")]
		public Vector3 twistAxis;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F8D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA5F8", Offset = "0x10AA5F8")]
		public float twistWeight;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA65C", Offset = "0x10AA65C")]
		public float swingWeight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA6C0", Offset = "0x10AA6C0")]
		public bool rotateOnce;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B2B")]
		private Transform lastPivot;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x45A8168", Offset = "0x45A8168", VA = "0x45A8168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1D34", Offset = "0x10B1D34")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x45A81EC", Offset = "0x45A81EC", VA = "0x45A81EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1D98", Offset = "0x10B1D98")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x45A8270", Offset = "0x45A8270", VA = "0x45A8270")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1DFC", Offset = "0x10B1DFC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x45A82F4", Offset = "0x45A82F4", VA = "0x45A82F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1E60", Offset = "0x10B1E60")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x45A8378", Offset = "0x45A8378", VA = "0x45A8378")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1EC4", Offset = "0x10B1EC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x45A83FC", Offset = "0x45A83FC", VA = "0x45A83FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1F28", Offset = "0x10B1F28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x459D5EC", Offset = "0x459D5EC", VA = "0x459D5EC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x459AF88", Offset = "0x459AF88", VA = "0x459AF88")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x4596AE4", Offset = "0x4596AE4", VA = "0x4596AE4")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x45A8480", Offset = "0x45A8480", VA = "0x45A8480")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1F8C", Offset = "0x10B1F8C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x45A8504", Offset = "0x45A8504", VA = "0x45A8504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B1FF0", Offset = "0x10B1FF0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x45A8588", Offset = "0x45A8588", VA = "0x45A8588")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2BA4", Offset = "0x10A2BA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2BA4", Offset = "0x10A2BA4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD234", Offset = "0x10AD234")]
			public bool use;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD298", Offset = "0x10AD298")]
			public Vector2 offset;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B33")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD2FC", Offset = "0x10AD2FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AD2FC", Offset = "0x10AD2FC")]
			public float angleOffset;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD39C", Offset = "0x10AD39C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AD39C", Offset = "0x10AD39C")]
			public float maxAngle;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F8F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD438", Offset = "0x10AD438")]
			public float radius;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD49C", Offset = "0x10AD49C")]
			public bool orbit;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD500", Offset = "0x10AD500")]
			public bool fixYAxis;

			[Token(Token = "0x170000D1")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600088F")]
				[Address(RVA = "0x45A979C", Offset = "0x45A979C", VA = "0x45A979C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x45A984C", Offset = "0x45A984C", VA = "0x45A984C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x45A99FC", Offset = "0x45A99FC", VA = "0x45A99FC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x45AAB1C", Offset = "0x45AAB1C", VA = "0x45AAB1C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000137")]
		public class CameraPosition
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD564", Offset = "0x10AD564")]
			public Collider lookAtTarget;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B3B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD5C8", Offset = "0x10AD5C8")]
			public Vector3 direction;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD62C", Offset = "0x10AD62C")]
			public float maxDistance;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F900")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD690", Offset = "0x10AD690")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AD690", Offset = "0x10AD690")]
			public float maxAngle;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD72C", Offset = "0x10AD72C")]
			public bool fixYAxis;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x45A8BE0", Offset = "0x45A8BE0", VA = "0x45A8BE0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x45A8FEC", Offset = "0x45A8FEC", VA = "0x45A8FEC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x45A966C", Offset = "0x45A966C", VA = "0x45A966C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000138")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200016C")]
			public class Interaction
			{
				[Token(Token = "0x400081F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE900", Offset = "0x10AE900")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE964", Offset = "0x10AE964")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000947")]
				[Address(RVA = "0x45AABBC", Offset = "0x45AABBC", VA = "0x45AABBC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B43")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD848", Offset = "0x10AD848")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD8AC", Offset = "0x10AD8AC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F910")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD910", Offset = "0x10AD910")]
			public Interaction[] interactions;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x45A8860", Offset = "0x45A8860", VA = "0x45A8860")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x45AAB78", Offset = "0x45AAB78", VA = "0x45AAB78")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA724", Offset = "0x10AA724")]
		public Range[] ranges;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x45A86C0", Offset = "0x45A86C0", VA = "0x45A86C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2054", Offset = "0x10B2054")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x45A8744", Offset = "0x45A8744", VA = "0x45A8744")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B20B8", Offset = "0x10B20B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x45A87C8", Offset = "0x45A87C8", VA = "0x45A87C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B211C", Offset = "0x10B211C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x45A884C", Offset = "0x45A884C", VA = "0x45A884C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x45A6094", Offset = "0x45A6094", VA = "0x45A6094")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x45A8B40", Offset = "0x45A8B40", VA = "0x45A8B40")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class Map
		{
			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4B")]
			public Transform bone;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform target;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F920")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x409FA0C", Offset = "0x409FA0C", VA = "0x409FA0C")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x409FB60", Offset = "0x409FB60", VA = "0x409FB60")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x409FD08", Offset = "0x409FD08", VA = "0x409FD08")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x40A00AC", Offset = "0x40A00AC", VA = "0x40A00AC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Map[] maps;

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x409F3DC", Offset = "0x409F3DC", VA = "0x409F3DC", Slot = "4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2180", Offset = "0x10B2180")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x409FA7C", Offset = "0x409FA7C", VA = "0x409FA7C", Slot = "5")]
		public override void StoreDefaultState()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x409FC24", Offset = "0x409FC24", VA = "0x409FC24", Slot = "6")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x409F8A4", Offset = "0x409F8A4", VA = "0x409F8A4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x409FDCC", Offset = "0x409FDCC", VA = "0x409FDCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x40A03B0", Offset = "0x40A03B0", VA = "0x40A03B0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform _poseRoot;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] children;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B53")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F930")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x40B3BA8", Offset = "0x40B3BA8", VA = "0x40B3BA8", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x40B3C48", Offset = "0x40B3C48", VA = "0x40B3C48", Slot = "5")]
		public override void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x40B3EBC", Offset = "0x40B3EBC", VA = "0x40B3EBC", Slot = "6")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x40B4084", Offset = "0x40B4084", VA = "0x40B4084", Slot = "4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x40B4224", Offset = "0x40B4224", VA = "0x40B4224")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x40B49A4", Offset = "0x40B49A4", VA = "0x40B49A4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class Poser : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform poseRoot;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AA788", Offset = "0x10AA788")]
		public float weight;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AA7D0", Offset = "0x10AA7D0")]
		public float localRotationWeight;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AA818", Offset = "0x10AA818")]
		public float localPositionWeight;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool fixTransforms;

		[Token(Token = "0x6000585")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000586")]
		public abstract void StoreDefaultState();

		[Token(Token = "0x6000587")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x45AD21C", Offset = "0x45AD21C", VA = "0x45AD21C", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x45AD24C", Offset = "0x45AD24C", VA = "0x45AD24C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x45AD298", Offset = "0x45AD298", VA = "0x45AD298")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10A2C50", Offset = "0x10A2C50")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public class Rigidbone
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B73")]
			public Rigidbody r;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform t;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F970")]
			public Collider collider;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Joint joint;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody c;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool updateAnchor;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B7B")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F980")]
			public float deltaTime;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion lastRotation;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x45ADEB4", Offset = "0x45ADEB4", VA = "0x45ADEB4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x45AFC6C", Offset = "0x45AFC6C", VA = "0x45AFC6C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x45AF778", Offset = "0x45AF778", VA = "0x45AF778")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200013B")]
		public class Child
		{
			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform t;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B83")]
			public Vector3 localPosition;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Quaternion localRotation;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x45AE1B8", Offset = "0x45AE1B8", VA = "0x45AE1B8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x45B004C", Offset = "0x45B004C", VA = "0x45B004C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x45AFF88", Offset = "0x45AFF88", VA = "0x45AFF88")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3208", Offset = "0x10A3208")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F990")]
			private int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x45B0FDC", Offset = "0x45B0FDC", VA = "0x45B0FDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A7")]
				[Address(RVA = "0x45B10AC", Offset = "0x45B10AC", VA = "0x45B10AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x45AE2A0", Offset = "0x45AE2A0", VA = "0x45AE2A0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x45B0774", Offset = "0x45B0774", VA = "0x45B0774", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x45B0788", Offset = "0x45B0788", VA = "0x45B0788", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x45B100C", Offset = "0x45B100C", VA = "0x45B100C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F940")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA860", Offset = "0x10AA860")]
		public IK ik;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA8C4", Offset = "0x10AA8C4")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA928", Offset = "0x10AA928")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA98C", Offset = "0x10AA98C")]
		public float applyVelocity;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B63")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AA9F0", Offset = "0x10AA9F0")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Animator animator;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F950")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Child[] children;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B6B")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F960")]
		private float ragdollWeight;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float ragdollWeightV;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool fixedFrame;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000079")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x45AD378", Offset = "0x45AD378", VA = "0x45AD378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		private bool ikUsed
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x45AECAC", Offset = "0x45AECAC", VA = "0x45AECAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x45AD304", Offset = "0x45AD304", VA = "0x45AD304")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x45AD4AC", Offset = "0x45AD4AC", VA = "0x45AD4AC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x45AD6EC", Offset = "0x45AD6EC", VA = "0x45AD6EC")]
		public void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x45AD630", Offset = "0x45AD630", VA = "0x45AD630")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10B21E4", Offset = "0x10B21E4")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x45AE2E8", Offset = "0x45AE2E8", VA = "0x45AE2E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x45AE97C", Offset = "0x45AE97C", VA = "0x45AE97C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x45AEB14", Offset = "0x45AEB14", VA = "0x45AEB14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x45AF0B0", Offset = "0x45AF0B0", VA = "0x45AF0B0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x45AEC34", Offset = "0x45AEC34", VA = "0x45AEC34")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x45AF028", Offset = "0x45AF028", VA = "0x45AF028")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x45AF200", Offset = "0x45AF200", VA = "0x45AF200")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x45AF108", Offset = "0x45AF108", VA = "0x45AF108")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x45AD538", Offset = "0x45AD538", VA = "0x45AD538")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x45AEA0C", Offset = "0x45AEA0C", VA = "0x45AEA0C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x45B03FC", Offset = "0x45B03FC", VA = "0x45B03FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x45B05EC", Offset = "0x45B05EC", VA = "0x45B05EC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 axis;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8B")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool initiated;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F9A0")]
		private bool applicationQuit;

		[Token(Token = "0x1700007B")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x45B4240", Offset = "0x45B4240", VA = "0x45B4240")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x45B4300", Offset = "0x45B4300", VA = "0x45B4300")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x45B3B64", Offset = "0x45B3B64", VA = "0x45B3B64")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x45B3BDC", Offset = "0x45B3BDC", VA = "0x45B3BDC")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x45B40D0", Offset = "0x45B40D0", VA = "0x45B40D0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x45B41B8", Offset = "0x45B41B8", VA = "0x45B41B8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005A3")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x45B3F30", Offset = "0x45B3F30", VA = "0x45B3F30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x45B4428", Offset = "0x45B4428", VA = "0x45B4428")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x45B4458", Offset = "0x45B4458", VA = "0x45B4458")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x45B44BC", Offset = "0x45B44BC", VA = "0x45B44BC")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x45B46A0", Offset = "0x45B46A0", VA = "0x45B46A0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x45B4B98", Offset = "0x45B4B98", VA = "0x45B4B98")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x45B4CF8", Offset = "0x45B4CF8", VA = "0x45B4CF8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2D00", Offset = "0x10A2D00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2D00", Offset = "0x10A2D00")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AAA90", Offset = "0x10AAA90")]
		public float limit;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AAAD8", Offset = "0x10AAAD8")]
		public float twistLimit;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x45B4DDC", Offset = "0x45B4DDC", VA = "0x45B4DDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2294", Offset = "0x10B2294")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x45B4E60", Offset = "0x45B4E60", VA = "0x45B4E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B22F8", Offset = "0x10B22F8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x45B4EE4", Offset = "0x45B4EE4", VA = "0x45B4EE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B235C", Offset = "0x10B235C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x45B4F68", Offset = "0x45B4F68", VA = "0x45B4F68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B23C0", Offset = "0x10B23C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x45B4FEC", Offset = "0x45B4FEC", VA = "0x45B4FEC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x45B512C", Offset = "0x45B512C", VA = "0x45B512C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x45B5690", Offset = "0x45B5690", VA = "0x45B5690")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2DAC", Offset = "0x10A2DAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2DAC", Offset = "0x10A2DAC")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useLimits;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B93")]
		public float min;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float max;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F9B0")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastAngle;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x45B56EC", Offset = "0x45B56EC", VA = "0x45B56EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2424", Offset = "0x10B2424")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x45B5770", Offset = "0x45B5770", VA = "0x45B5770")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2488", Offset = "0x10B2488")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x45B57F4", Offset = "0x45B57F4", VA = "0x45B57F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B24EC", Offset = "0x10B24EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x45B5878", Offset = "0x45B5878", VA = "0x45B5878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2550", Offset = "0x10B2550")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x45B58FC", Offset = "0x45B58FC", VA = "0x45B58FC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x45B59B0", Offset = "0x45B59B0", VA = "0x45B59B0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x45B60DC", Offset = "0x45B60DC", VA = "0x45B60DC")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2E58", Offset = "0x10A2E58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2E58", Offset = "0x10A2E58")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public class ReachCone
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float volume;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BA3")]
			public Vector3 S;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 B;

			[Token(Token = "0x170000D5")]
			public Vector3 o
			{
				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x45BA2B4", Offset = "0x45BA2B4", VA = "0x45BA2B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D6")]
			public Vector3 a
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x45BA314", Offset = "0x45BA314", VA = "0x45BA314")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D7")]
			public Vector3 b
			{
				[Token(Token = "0x60008AA")]
				[Address(RVA = "0x45BA374", Offset = "0x45BA374", VA = "0x45BA374")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D8")]
			public Vector3 c
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x45BA3D4", Offset = "0x45BA3D4", VA = "0x45BA3D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D9")]
			public bool isValid
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x45B8190", Offset = "0x45B8190", VA = "0x45B8190")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x45B8F88", Offset = "0x45B8F88", VA = "0x45B8F88")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x45B9264", Offset = "0x45B9264", VA = "0x45B9264")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public class LimitPoint
		{
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F9D0")]
			public Vector3 point;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float tangentWeight;

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x45B820C", Offset = "0x45B820C", VA = "0x45B820C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AAB5C", Offset = "0x10AAB5C")]
		public float twistLimit;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AABA4", Offset = "0x10AABA4")]
		public int smoothIterations;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F9C0")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x45B61EC", Offset = "0x45B61EC", VA = "0x45B61EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B25B4", Offset = "0x10B25B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x45B6270", Offset = "0x45B6270", VA = "0x45B6270")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2618", Offset = "0x10B2618")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x45B62F4", Offset = "0x45B62F4", VA = "0x45B62F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B267C", Offset = "0x10B267C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x45B6378", Offset = "0x45B6378", VA = "0x45B6378")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B26E0", Offset = "0x10B26E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x45B63FC", Offset = "0x45B63FC", VA = "0x45B63FC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x45B6D14", Offset = "0x45B6D14", VA = "0x45B6D14", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x45B6E94", Offset = "0x45B6E94", VA = "0x45B6E94")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x45B79D8", Offset = "0x45B79D8", VA = "0x45B79D8")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x45B64E8", Offset = "0x45B64E8", VA = "0x45B64E8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x45B82F8", Offset = "0x45B82F8", VA = "0x45B82F8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x45B95D0", Offset = "0x45B95D0", VA = "0x45B95D0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x45B9700", Offset = "0x45B9700", VA = "0x45B9700")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x45B99CC", Offset = "0x45B99CC", VA = "0x45B99CC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x45B72B4", Offset = "0x45B72B4", VA = "0x45B72B4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x45B9D5C", Offset = "0x45B9D5C", VA = "0x45B9D5C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x45BA1FC", Offset = "0x45BA1FC", VA = "0x45BA1FC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10A2F04", Offset = "0x10A2F04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10A2F04", Offset = "0x10A2F04")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AAD00", Offset = "0x10AAD00")]
		public float twistLimit;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x45BA434", Offset = "0x45BA434", VA = "0x45BA434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2744", Offset = "0x10B2744")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x45BA4B8", Offset = "0x45BA4B8", VA = "0x45BA4B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B27A8", Offset = "0x10B27A8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x45BA53C", Offset = "0x45BA53C", VA = "0x45BA53C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B280C", Offset = "0x10B280C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x45BA5C0", Offset = "0x45BA5C0", VA = "0x45BA5C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10B2870", Offset = "0x10B2870")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x45BA644", Offset = "0x45BA644", VA = "0x45BA644")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x45BA69C", Offset = "0x45BA69C", VA = "0x45BA69C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x45BA7DC", Offset = "0x45BA7DC", VA = "0x45BA7DC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x45BAF6C", Offset = "0x45BAF6C", VA = "0x45BAF6C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		public class Pose
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578F9E0")]
			public bool visualize;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float yaw;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BB3")]
			public float pitch;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float angleBuffer;

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x40848AC", Offset = "0x40848AC", VA = "0x40848AC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x40851CC", Offset = "0x40851CC", VA = "0x40851CC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x4085204", Offset = "0x4085204", VA = "0x4085204")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BAB")]
		public float angleBuffer;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Pose[] poses;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x40846A8", Offset = "0x40846A8", VA = "0x40846A8")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x4084F70", Offset = "0x4084F70", VA = "0x4084F70")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x4085114", Offset = "0x4085114", VA = "0x4085114")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200016D")]
			public class EffectorLink
			{
				[Token(Token = "0x4000821")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1BC3")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE9C8", Offset = "0x10AE9C8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEA2C", Offset = "0x10AEA2C")]
				public float weight;

				[Token(Token = "0x6000948")]
				[Address(RVA = "0x40861F4", Offset = "0x40861F4", VA = "0x40861F4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD974", Offset = "0x10AD974")]
			public Transform transform;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AD9D8", Offset = "0x10AD9D8")]
			public Transform relativeTo;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADA3C", Offset = "0x10ADA3C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BBB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADAA0", Offset = "0x10ADAA0")]
			public float verticalWeight;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADB04", Offset = "0x10ADB04")]
			public float horizontalWeight;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FA00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADB68", Offset = "0x10ADB68")]
			public float speed;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool firstUpdate;

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x40854B4", Offset = "0x40854B4", VA = "0x40854B4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x4086038", Offset = "0x4086038", VA = "0x4086038")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x4086188", Offset = "0x4086188", VA = "0x4086188")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578F9F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AADA4", Offset = "0x10AADA4")]
		public Body[] bodies;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x4085278", Offset = "0x4085278", VA = "0x4085278", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x4086008", Offset = "0x4086008", VA = "0x4086008")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FA10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AAE08", Offset = "0x10AAE08")]
		public float tiltSpeed;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AAE6C", Offset = "0x10AAE6C")]
		public float tiltSensitivity;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AAED0", Offset = "0x10AAED0")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AAF34", Offset = "0x10AAF34")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BCB")]
		private float tiltAngle;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x4088DB0", Offset = "0x4088DB0", VA = "0x4088DB0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x4088E34", Offset = "0x4088E34", VA = "0x4088E34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x4089338", Offset = "0x4089338", VA = "0x4089338")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADBCC", Offset = "0x10ADBCC")]
			public string name;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADC30", Offset = "0x10ADC30")]
			public string colliderSearchName;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BD3")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADC94", Offset = "0x10ADC94")]
			public Collider collider;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADCF8", Offset = "0x10ADCF8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ADD78", Offset = "0x10ADD78")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ADDB4", Offset = "0x10ADDB4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ADDF0", Offset = "0x10ADDF0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ADE2C", Offset = "0x10ADE2C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BDB")]
			private float length;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float crossFadeSpeed;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FA40")]
			private float lastTime;

			[Token(Token = "0x170000DA")]
			protected float crossFader
			{
				[Token(Token = "0x60008B6")]
				[Address(RVA = "0x40B6140", Offset = "0x40B6140", VA = "0x40B6140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3A28", Offset = "0x10B3A28")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008B7")]
				[Address(RVA = "0x40B6170", Offset = "0x40B6170", VA = "0x40B6170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3A64", Offset = "0x10B3A64")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			protected float timer
			{
				[Token(Token = "0x60008B8")]
				[Address(RVA = "0x40B61A8", Offset = "0x40B61A8", VA = "0x40B61A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3AA0", Offset = "0x10B3AA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008B9")]
				[Address(RVA = "0x40B61D8", Offset = "0x40B61D8", VA = "0x40B61D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3ADC", Offset = "0x10B3ADC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			protected Vector3 force
			{
				[Token(Token = "0x60008BA")]
				[Address(RVA = "0x40B6210", Offset = "0x40B6210", VA = "0x40B6210")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3B18", Offset = "0x10B3B18")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008BB")]
				[Address(RVA = "0x40B6250", Offset = "0x40B6250", VA = "0x40B6250")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3B54", Offset = "0x10B3B54")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			protected Vector3 point
			{
				[Token(Token = "0x60008BC")]
				[Address(RVA = "0x40B62B0", Offset = "0x40B62B0", VA = "0x40B62B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3B90", Offset = "0x10B3B90")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008BD")]
				[Address(RVA = "0x40B62F0", Offset = "0x40B62F0", VA = "0x40B62F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10B3BCC", Offset = "0x10B3BCC")]
				private set
				{
				}
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x40B5E78", Offset = "0x40B5E78", VA = "0x40B5E78")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x40B5650", Offset = "0x40B5650", VA = "0x40B5650")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008C0")]
			protected abstract float GetLength();

			[Token(Token = "0x60008C1")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60008C2")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x40B6350", Offset = "0x40B6350", VA = "0x40B6350")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000142")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200016E")]
			public class EffectorLink
			{
				[Token(Token = "0x4000823")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1BE3")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEA90", Offset = "0x10AEA90")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000824")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEAF4", Offset = "0x10AEAF4")]
				public float weight;

				[Token(Token = "0x4000825")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x578FA50")]
				private Vector3 lastValue;

				[Token(Token = "0x4000826")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Vector3 current;

				[Token(Token = "0x6000949")]
				[Address(RVA = "0x4B23234", Offset = "0x4B23234", VA = "0x4B23234")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600094A")]
				[Address(RVA = "0x4B22D80", Offset = "0x4B22D80", VA = "0x4B22D80")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600094B")]
				[Address(RVA = "0x4B238A4", Offset = "0x4B238A4", VA = "0x4B238A4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADE68", Offset = "0x10ADE68")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADECC", Offset = "0x10ADECC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADF30", Offset = "0x10ADF30")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x4B22994", Offset = "0x4B22994", VA = "0x4B22994", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x4B22C88", Offset = "0x4B22C88", VA = "0x4B22C88", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x4B22DD8", Offset = "0x4B22DD8", VA = "0x4B22DD8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x4B234B4", Offset = "0x4B234B4", VA = "0x4B234B4")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000143")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200016F")]
			public class BoneLink
			{
				[Token(Token = "0x4000827")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEB58", Offset = "0x10AEB58")]
				public string boneSearchName;

				[Token(Token = "0x4000828")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x578FA60")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEBBC", Offset = "0x10AEBBC")]
				public Transform bone;

				[Token(Token = "0x4000829")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEC20", Offset = "0x10AEC20")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AEC20", Offset = "0x10AEC20")]
				public float weight;

				[Token(Token = "0x400082A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion lastValue;

				[Token(Token = "0x400082B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion current;

				[Token(Token = "0x600094C")]
				[Address(RVA = "0x4B2258C", Offset = "0x4B2258C", VA = "0x4B2258C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600094D")]
				[Address(RVA = "0x4B2202C", Offset = "0x4B2202C", VA = "0x4B2202C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600094E")]
				[Address(RVA = "0x4B22878", Offset = "0x4B22878", VA = "0x4B22878")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADF94", Offset = "0x10ADF94")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10ADFF8", Offset = "0x10ADFF8")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BEB")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x4B21E28", Offset = "0x4B21E28", VA = "0x4B21E28", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x4B21F34", Offset = "0x4B21F34", VA = "0x4B21F34", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x4B22084", Offset = "0x4B22084", VA = "0x4B22084", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x4B22848", Offset = "0x4B22848", VA = "0x4B22848")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FA20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AAF98", Offset = "0x10AAF98")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AAFFC", Offset = "0x10AAFFC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x40B49D4", Offset = "0x40B49D4", VA = "0x40B49D4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x40B4EC4", Offset = "0x40B4EC4", VA = "0x40B4EC4")]
		public Transform FindDeepChild(Transform aParent, string aName)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x40B5428", Offset = "0x40B5428", VA = "0x40B5428", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x40B5978", Offset = "0x40B5978", VA = "0x40B5978")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x40B6110", Offset = "0x40B6110", VA = "0x40B6110")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000144")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000170")]
			public class EffectorLink
			{
				[Token(Token = "0x400082C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AECBC", Offset = "0x10AECBC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x578FA90")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AED20", Offset = "0x10AED20")]
				public float weight;

				[Token(Token = "0x600094F")]
				[Address(RVA = "0x4593D9C", Offset = "0x4593D9C", VA = "0x4593D9C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FA70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE05C", Offset = "0x10AE05C")]
			public Transform transform;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE0C0", Offset = "0x10AE0C0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE124", Offset = "0x10AE124")]
			public float speed;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE188", Offset = "0x10AE188")]
			public float acceleration;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BFB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE1EC", Offset = "0x10AE1EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AE1EC", Offset = "0x10AE1EC")]
			public float matchVelocity;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE288", Offset = "0x10AE288")]
			public float gravity;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FA80")]
			private Vector3 delta;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 direction;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C03")]
			private bool firstUpdate;

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x4592DAC", Offset = "0x4592DAC", VA = "0x4592DAC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x4593158", Offset = "0x4593158", VA = "0x4593158")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x4593D28", Offset = "0x4593D28", VA = "0x4593D28")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB060", Offset = "0x10AB060")]
		public Body[] bodies;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB0C4", Offset = "0x10AB0C4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x4592CB4", Offset = "0x4592CB4", VA = "0x4592CB4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x4592FB4", Offset = "0x4592FB4", VA = "0x4592FB4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4593CB4", Offset = "0x4593CB4", VA = "0x4593CB4")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		public class OffsetLimits
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE2EC", Offset = "0x10AE2EC")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE350", Offset = "0x10AE350")]
			public float spring;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FAA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE3B4", Offset = "0x10AE3B4")]
			public bool x;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE418", Offset = "0x10AE418")]
			public bool y;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE47C", Offset = "0x10AE47C")]
			public bool z;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE4E0", Offset = "0x10AE4E0")]
			public float minX;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C13")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE544", Offset = "0x10AE544")]
			public float maxX;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE5A8", Offset = "0x10AE5A8")]
			public float minY;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FAB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE60C", Offset = "0x10AE60C")]
			public float maxY;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE670", Offset = "0x10AE670")]
			public float minZ;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE6D4", Offset = "0x10AE6D4")]
			public float maxZ;

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x45AB5A0", Offset = "0x45AB5A0", VA = "0x45AB5A0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x45AC26C", Offset = "0x45AC26C", VA = "0x45AC26C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x45AC3BC", Offset = "0x45AC3BC", VA = "0x45AC3BC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x45AC620", Offset = "0x45AC620", VA = "0x45AC620")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3244", Offset = "0x10A3244")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C1B")]
			private object <>2__current;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D6")]
				[Address(RVA = "0x45AC16C", Offset = "0x45AC16C", VA = "0x45AC16C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D8")]
				[Address(RVA = "0x45AC23C", Offset = "0x45AC23C", VA = "0x45AC23C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x45AB2C0", Offset = "0x45AB2C0", VA = "0x45AB2C0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x45ABDE8", Offset = "0x45ABDE8", VA = "0x45ABDE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x45ABDFC", Offset = "0x45ABDFC", VA = "0x45ABDFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x45AC19C", Offset = "0x45AC19C", VA = "0x45AC19C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB128", Offset = "0x10AB128")]
		public float weight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB18C", Offset = "0x10AB18C")]
		[SerializeField]
		protected FullBodyBipedIK ik;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastTime;

		[Token(Token = "0x1700007D")]
		protected float deltaTime
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x4593110", Offset = "0x4593110", VA = "0x4593110")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E2")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x45AB1BC", Offset = "0x45AB1BC", VA = "0x45AB1BC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x45AB204", Offset = "0x45AB204", VA = "0x45AB204")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10B28D4", Offset = "0x10B28D4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x45AB308", Offset = "0x45AB308", VA = "0x45AB308")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x4593B0C", Offset = "0x4593B0C", VA = "0x4593B0C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x45ABC08", Offset = "0x45ABC08", VA = "0x45ABC08", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x4593CE4", Offset = "0x4593CE4", VA = "0x4593CE4")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000147")]
		public class EffectorLink
		{
			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 offset;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pin;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C23")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x45AC79C", Offset = "0x45AC79C", VA = "0x45AC79C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x45AD1EC", Offset = "0x45AD1EC", VA = "0x45AD1EC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FAC0")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x45AC650", Offset = "0x45AC650", VA = "0x45AC650")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x45ACF24", Offset = "0x45ACF24", VA = "0x45ACF24")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x45AD14C", Offset = "0x45AD14C", VA = "0x45AD14C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000148")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000171")]
			public class EffectorLink
			{
				[Token(Token = "0x400082E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AED84", Offset = "0x10AED84")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AEDE8", Offset = "0x10AEDE8")]
				public float weight;

				[Token(Token = "0x6000950")]
				[Address(RVA = "0x45B3B34", Offset = "0x45B3B34", VA = "0x45B3B34")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE738", Offset = "0x10AE738")]
			public Vector3 offset;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE79C", Offset = "0x10AE79C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10AE79C", Offset = "0x10AE79C")]
			public float additivity;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C43")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE838", Offset = "0x10AE838")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AE89C", Offset = "0x10AE89C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FB10")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x45B17A0", Offset = "0x45B17A0", VA = "0x45B17A0")]
			public void Start()
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x45B2D74", Offset = "0x45B2D74", VA = "0x45B2D74")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x45B3AD4", Offset = "0x45B3AD4", VA = "0x45B3AD4")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public enum Handedness
		{
			[Token(Token = "0x40007A5")]
			Right,
			[Token(Token = "0x40007A6")]
			Left
		}

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB20C", Offset = "0x10AB20C")]
		public AimIK aimIK;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FAD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB270", Offset = "0x10AB270")]
		public Handedness handedness;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB2D4", Offset = "0x10AB2D4")]
		public bool twoHanded;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB338", Offset = "0x10AB338")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB39C", Offset = "0x10AB39C")]
		public float magnitudeRandom;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB400", Offset = "0x10AB400")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB464", Offset = "0x10AB464")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FAE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB4C8", Offset = "0x10AB4C8")]
		public float blendTime;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10AB52C", Offset = "0x10AB52C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB52C", Offset = "0x10AB52C")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float magnitudeMlp;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C33")]
		private float endTime;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion handRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FAF0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float length;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3B")]
		private float blendWeight;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float w;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FB00")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool handRotationsSet;

		[Token(Token = "0x1700007E")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x45B33A8", Offset = "0x45B33A8", VA = "0x45B33A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x45B3474", Offset = "0x45B3474", VA = "0x45B3474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x45B3310", Offset = "0x45B3310", VA = "0x45B3310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x45B335C", Offset = "0x45B335C", VA = "0x45B335C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x45B10DC", Offset = "0x45B10DC", VA = "0x45B10DC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x45B1354", Offset = "0x45B1354", VA = "0x45B1354")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x45B1924", Offset = "0x45B1924", VA = "0x45B1924", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x45B3540", Offset = "0x45B3540", VA = "0x45B3540")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x45B3768", Offset = "0x45B3768", VA = "0x45B3768", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x45B3974", Offset = "0x45B3974", VA = "0x45B3974")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB5F8", Offset = "0x10AB5F8")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10AB65C", Offset = "0x10AB65C")]
		public float offset;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C53")]
		private bool skip;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x45BAFB0", Offset = "0x45BAFB0", VA = "0x45BAFB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x45BB10C", Offset = "0x45BB10C", VA = "0x45BB10C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x45BB374", Offset = "0x45BB374", VA = "0x45BB374")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x45BBBEC", Offset = "0x45BBBEC", VA = "0x45BBBEC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x45BBC84", Offset = "0x45BBC84", VA = "0x45BBC84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x45BBE64", Offset = "0x45BBE64", VA = "0x45BBE64")]
		public ShoulderRotator()
		{
		}
	}
}
namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000CE")]
	public class MBVersionConcrete : MBVersionInterface
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector2 _HALF_UV;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x48A96C0", Offset = "0x48A96C0", VA = "0x48A96C0", Slot = "4")]
		public string version()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x48A9734", Offset = "0x48A9734", VA = "0x48A9734", Slot = "5")]
		public int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x48A9750", Offset = "0x48A9750", VA = "0x48A9750", Slot = "6")]
		public int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x48A976C", Offset = "0x48A976C", VA = "0x48A976C", Slot = "7")]
		public bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x48A97D0", Offset = "0x48A97D0", VA = "0x48A97D0", Slot = "8")]
		public void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x48A983C", Offset = "0x48A983C", VA = "0x48A983C", Slot = "9")]
		public void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x48A98A8", Offset = "0x48A98A8", VA = "0x48A98A8", Slot = "10")]
		public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x48A99A4", Offset = "0x48A99A4", VA = "0x48A99A4", Slot = "11")]
		public bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x48A9A84", Offset = "0x48A9A84", VA = "0x48A9A84")]
		public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x48A9DC8", Offset = "0x48A9DC8", VA = "0x48A9DC8", Slot = "12")]
		public Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x48AA240", Offset = "0x48AA240", VA = "0x48AA240", Slot = "13")]
		public void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x48AA2AC", Offset = "0x48AA2AC", VA = "0x48AA2AC", Slot = "14")]
		public void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x48AA304", Offset = "0x48AA304", VA = "0x48AA304", Slot = "15")]
		public void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x48AA35C", Offset = "0x48AA35C", VA = "0x48AA35C", Slot = "16")]
		public Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x48AA3BC", Offset = "0x48AA3BC", VA = "0x48AA3BC", Slot = "17")]
		public Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x48AA600", Offset = "0x48AA600", VA = "0x48AA600")]
		public MBVersionConcrete()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public interface TextureBlender
	{
		[Token(Token = "0x600060C")]
		bool DoesShaderNameMatch(string shaderName);

		[Token(Token = "0x600060D")]
		void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName);

		[Token(Token = "0x600060E")]
		Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor);

		[Token(Token = "0x600060F")]
		bool NonTexturePropertiesAreEqual(Material a, Material b);

		[Token(Token = "0x6000610")]
		void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial);

		[Token(Token = "0x6000611")]
		Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName);
	}
	[Token(Token = "0x20000D0")]
	public class TextureBlenderFallback : TextureBlender
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FB30")]
		private bool m_doTintColor;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_tintColor;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultColor;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_defaultMetallic;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5B")]
		private float m_defaultGlossiness;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_defaultEmission;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FB40")]
		private Color m_defaultNormal;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x48ADA2C", Offset = "0x48ADA2C", VA = "0x48ADA2C", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x48ADA54", Offset = "0x48ADA54", VA = "0x48ADA54", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x48ADBEC", Offset = "0x48ADBEC", VA = "0x48ADBEC", Slot = "6")]
		public Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x48ADE78", Offset = "0x48ADE78", VA = "0x48ADE78", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x48AE17C", Offset = "0x48AE17C", VA = "0x48AE17C", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x48AE274", Offset = "0x48AE274", VA = "0x48AE274", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x48ADF64", Offset = "0x48ADF64", VA = "0x48ADF64")]
		public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x48AFA44", Offset = "0x48AFA44", VA = "0x48AFA44")]
		public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4888318", Offset = "0x4888318", VA = "0x4888318")]
		public TextureBlenderFallback()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class TextureBlenderLegacyBumpDiffuse : TextureBlender
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool doColor;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_tintColor;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultTintColor;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x48AFC08", Offset = "0x48AFC08", VA = "0x48AFC08", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x48AFD4C", Offset = "0x48AFD4C", VA = "0x48AFD4C", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x48AFE64", Offset = "0x48AFE64", VA = "0x48AFE64", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x48B00F0", Offset = "0x48B00F0", VA = "0x48B00F0", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x48B01B8", Offset = "0x48B01B8", VA = "0x48B01B8", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x48B026C", Offset = "0x48B026C", VA = "0x48B026C", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x48B0728", Offset = "0x48B0728", VA = "0x48B0728")]
		public TextureBlenderLegacyBumpDiffuse()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class TextureBlenderLegacyDiffuse : TextureBlender
	{
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C63")]
		private bool doColor;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_tintColor;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FB50")]
		private Color m_defaultTintColor;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x48B0790", Offset = "0x48B0790", VA = "0x48B0790", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x48B08D4", Offset = "0x48B08D4", VA = "0x48B08D4", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x48B09EC", Offset = "0x48B09EC", VA = "0x48B09EC", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x48B0C78", Offset = "0x48B0C78", VA = "0x48B0C78", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x48B0D40", Offset = "0x48B0D40", VA = "0x48B0D40", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x48B0DF4", Offset = "0x48B0DF4", VA = "0x48B0DF4", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x48B11DC", Offset = "0x48B11DC", VA = "0x48B11DC")]
		public TextureBlenderLegacyDiffuse()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class TextureBlenderStandardMetallic : TextureBlender
	{
		[Token(Token = "0x200014A")]
		private enum Prop
		{
			[Token(Token = "0x40007A8")]
			doColor,
			[Token(Token = "0x40007A9")]
			doMetallic,
			[Token(Token = "0x40007AA")]
			doEmission,
			[Token(Token = "0x40007AB")]
			doNone
		}

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_tintColor;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_emission;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Prop propertyToDo;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6B")]
		private Color m_defaultColor;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float m_defaultMetallic;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FB60")]
		private float m_defaultGlossiness;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultEmission;

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x48B1244", Offset = "0x48B1244", VA = "0x48B1244", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x48B12FC", Offset = "0x48B12FC", VA = "0x48B12FC", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x48B1650", Offset = "0x48B1650", VA = "0x48B1650", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x48B1B0C", Offset = "0x48B1B0C", VA = "0x48B1B0C", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x48B1D44", Offset = "0x48B1D44", VA = "0x48B1D44", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x48B1FDC", Offset = "0x48B1FDC", VA = "0x48B1FDC", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x48B2DC4", Offset = "0x48B2DC4", VA = "0x48B2DC4")]
		public TextureBlenderStandardMetallic()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class TextureBlenderStandardSpecular : TextureBlender
	{
		[Token(Token = "0x200014B")]
		private enum Prop
		{
			[Token(Token = "0x40007AD")]
			doColor,
			[Token(Token = "0x40007AE")]
			doSpecular,
			[Token(Token = "0x40007AF")]
			doEmission,
			[Token(Token = "0x40007B0")]
			doNone
		}

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_tintColor;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_emission;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Prop propertyToDo;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7B")]
		private Color m_defaultColor;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_defaultSpecular;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FB80")]
		private float m_defaultGlossiness;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultEmission;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x48B2E7C", Offset = "0x48B2E7C", VA = "0x48B2E7C", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x48B2F34", Offset = "0x48B2F34", VA = "0x48B2F34", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x48B3288", Offset = "0x48B3288", VA = "0x48B3288", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x48B3744", Offset = "0x48B3744", VA = "0x48B3744", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x48B39A4", Offset = "0x48B39A4", VA = "0x48B39A4", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x48B3C5C", Offset = "0x48B3C5C", VA = "0x48B3C5C", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x48B4AC8", Offset = "0x48B4AC8", VA = "0x48B4AC8")]
		public TextureBlenderStandardSpecular()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public delegate void ProgressUpdateDelegate(string msg, float progress);
	[Token(Token = "0x20000D6")]
	public enum MB_ObjsToCombineTypes
	{
		[Token(Token = "0x4000595")]
		prefabOnly,
		[Token(Token = "0x4000596")]
		sceneObjOnly,
		[Token(Token = "0x4000597")]
		dontCare
	}
	[Token(Token = "0x20000D7")]
	public enum MB_OutputOptions
	{
		[Token(Token = "0x4000599")]
		bakeIntoPrefab,
		[Token(Token = "0x400059A")]
		bakeMeshsInPlace,
		[Token(Token = "0x400059B")]
		bakeTextureAtlasesOnly,
		[Token(Token = "0x400059C")]
		bakeIntoSceneObject
	}
	[Token(Token = "0x20000D8")]
	public enum MB_RenderType
	{
		[Token(Token = "0x400059E")]
		meshRenderer,
		[Token(Token = "0x400059F")]
		skinnedMeshRenderer
	}
	[Token(Token = "0x20000D9")]
	public enum MB2_OutputOptions
	{
		[Token(Token = "0x40005A1")]
		bakeIntoSceneObject,
		[Token(Token = "0x40005A2")]
		bakeMeshAssetsInPlace,
		[Token(Token = "0x40005A3")]
		bakeIntoPrefab
	}
	[Token(Token = "0x20000DA")]
	public enum MB2_LightmapOptions
	{
		[Token(Token = "0x40005A5")]
		preserve_current_lightmapping,
		[Token(Token = "0x40005A6")]
		ignore_UV2,
		[Token(Token = "0x40005A7")]
		copy_UV2_unchanged,
		[Token(Token = "0x40005A8")]
		generate_new_UV2_layout
	}
	[Token(Token = "0x20000DB")]
	public enum MB2_PackingAlgorithmEnum
	{
		[Token(Token = "0x40005AA")]
		UnitysPackTextures,
		[Token(Token = "0x40005AB")]
		MeshBakerTexturePacker,
		[Token(Token = "0x40005AC")]
		MeshBakerTexturePacker_Fast
	}
	[Token(Token = "0x20000DC")]
	public enum MB2_ValidationLevel
	{
		[Token(Token = "0x40005AE")]
		none,
		[Token(Token = "0x40005AF")]
		quick,
		[Token(Token = "0x40005B0")]
		robust
	}
	[Token(Token = "0x20000DD")]
	public interface MB2_EditorMethodsInterface
	{
		[Token(Token = "0x600063B")]
		void Clear();

		[Token(Token = "0x600063C")]
		void SetReadFlags(ProgressUpdateDelegate progressInfo);

		[Token(Token = "0x600063D")]
		void SetReadWriteFlag(Texture2D tx, bool isReadable, bool addToList);

		[Token(Token = "0x600063E")]
		void AddTextureFormat(Texture2D tx, bool isNormalMap);

		[Token(Token = "0x600063F")]
		void SaveAtlasToAssetDatabase(Texture2D atlas, ShaderTextureProperty texPropertyName, int atlasNum, Material resMat);

		[Token(Token = "0x6000640")]
		void SetMaterialTextureProperty(Material target, ShaderTextureProperty texPropName, string texturePath);

		[Token(Token = "0x6000641")]
		void SetNormalMap(Texture2D tx);

		[Token(Token = "0x6000642")]
		bool IsNormalMap(Texture2D tx);

		[Token(Token = "0x6000643")]
		string GetPlatformString();

		[Token(Token = "0x6000644")]
		void SetTextureSize(Texture2D tx, int size);

		[Token(Token = "0x6000645")]
		bool IsCompressed(Texture2D tx);

		[Token(Token = "0x6000646")]
		void CheckBuildSettings(long estimatedAtlasSize);

		[Token(Token = "0x6000647")]
		bool CheckPrefabTypes(MB_ObjsToCombineTypes prefabType, List<GameObject> gos);

		[Token(Token = "0x6000648")]
		bool ValidateSkinnedMeshes(List<GameObject> mom);

		[Token(Token = "0x6000649")]
		void CommitChangesToAssets();

		[Token(Token = "0x600064A")]
		void Destroy(UnityEngine.Object o);
	}
	[Token(Token = "0x20000DE")]
	public enum MB2_LogLevel
	{
		[Token(Token = "0x40005B2")]
		none,
		[Token(Token = "0x40005B3")]
		error,
		[Token(Token = "0x40005B4")]
		warn,
		[Token(Token = "0x40005B5")]
		info,
		[Token(Token = "0x40005B6")]
		debug,
		[Token(Token = "0x40005B7")]
		trace
	}
	[Token(Token = "0x20000DF")]
	public class MB2_Log
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x44CE1D0", Offset = "0x44CE1D0", VA = "0x44CE1D0")]
		public static void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x44CE6F8", Offset = "0x44CE6F8", VA = "0x44CE6F8")]
		public static string Error(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x44CE89C", Offset = "0x44CE89C", VA = "0x44CE89C")]
		public static string Warn(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x44CEA40", Offset = "0x44CEA40", VA = "0x44CEA40")]
		public static string Info(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x44CEBE4", Offset = "0x44CEBE4", VA = "0x44CEBE4")]
		public static string LogDebug(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x44CED88", Offset = "0x44CED88", VA = "0x44CED88")]
		public static string Trace(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x44CEF2C", Offset = "0x44CEF2C", VA = "0x44CEF2C")]
		public MB2_Log()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class ObjectLog
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int pos;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string[] logMessages;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x48AD188", Offset = "0x48AD188", VA = "0x48AD188")]
		private void _CacheLogMessage(string msg)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x48AD2B4", Offset = "0x48AD2B4", VA = "0x48AD2B4")]
		public ObjectLog(short bufferSize)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x48AD364", Offset = "0x48AD364", VA = "0x48AD364")]
		public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x48AD3DC", Offset = "0x48AD3DC", VA = "0x48AD3DC")]
		public void Error(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x48AD440", Offset = "0x48AD440", VA = "0x48AD440")]
		public void Warn(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x48AD4A4", Offset = "0x48AD4A4", VA = "0x48AD4A4")]
		public void Info(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x48AD508", Offset = "0x48AD508", VA = "0x48AD508")]
		public void LogDebug(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x48AD56C", Offset = "0x48AD56C", VA = "0x48AD56C")]
		public void Trace(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x48AD5D0", Offset = "0x48AD5D0", VA = "0x48AD5D0")]
		public string Dump()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	public interface MBVersionInterface
	{
		[Token(Token = "0x600065B")]
		string version();

		[Token(Token = "0x600065C")]
		int GetMajorVersion();

		[Token(Token = "0x600065D")]
		int GetMinorVersion();

		[Token(Token = "0x600065E")]
		bool GetActive(GameObject go);

		[Token(Token = "0x600065F")]
		void SetActive(GameObject go, bool isActive);

		[Token(Token = "0x6000660")]
		void SetActiveRecursively(GameObject go, bool isActive);

		[Token(Token = "0x6000661")]
		UnityEngine.Object[] FindSceneObjectsOfType(Type t);

		[Token(Token = "0x6000662")]
		bool IsRunningAndMeshNotReadWriteable(Mesh m);

		[Token(Token = "0x6000663")]
		Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x6000664")]
		void MeshClear(Mesh m, bool t);

		[Token(Token = "0x6000665")]
		void MeshAssignUV3(Mesh m, Vector2[] uv3s);

		[Token(Token = "0x6000666")]
		void MeshAssignUV4(Mesh m, Vector2[] uv4s);

		[Token(Token = "0x6000667")]
		Vector4 GetLightmapTilingOffset(Renderer r);

		[Token(Token = "0x6000668")]
		Transform[] GetBones(Renderer r);
	}
	[Token(Token = "0x20000E2")]
	public class MBVersion
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MBVersionInterface _MBVersion;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x48A84A8", Offset = "0x48A84A8", VA = "0x48A84A8")]
		private static MBVersionInterface _CreateMBVersionConcrete()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x48A85F4", Offset = "0x48A85F4", VA = "0x48A85F4")]
		public static string version()
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x48A870C", Offset = "0x48A870C", VA = "0x48A870C")]
		public static int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x48A8824", Offset = "0x48A8824", VA = "0x48A8824")]
		public static int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x48A893C", Offset = "0x48A893C", VA = "0x48A893C")]
		public static bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x48A8A78", Offset = "0x48A8A78", VA = "0x48A8A78")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x48A8BBC", Offset = "0x48A8BBC", VA = "0x48A8BBC")]
		public static void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x48A8D00", Offset = "0x48A8D00", VA = "0x48A8D00")]
		public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x48A8E28", Offset = "0x48A8E28", VA = "0x48A8E28")]
		public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x48A8F64", Offset = "0x48A8F64", VA = "0x48A8F64")]
		public static Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x48A90C0", Offset = "0x48A90C0", VA = "0x48A90C0")]
		public static void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x48A9204", Offset = "0x48A9204", VA = "0x48A9204")]
		public static void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x48A9334", Offset = "0x48A9334", VA = "0x48A9334")]
		public static void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x48A9464", Offset = "0x48A9464", VA = "0x48A9464")]
		public static Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x48A9568", Offset = "0x48A9568", VA = "0x48A9568")]
		public static Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x48A9690", Offset = "0x48A9690", VA = "0x48A9690")]
		public MBVersion()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class MB2_TexturePacker
	{
		[Token(Token = "0x200014C")]
		private class PixRect
		{
			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int y;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int w;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC3")]
			public int h;

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x44D6664", Offset = "0x44D6664", VA = "0x44D6664")]
			public PixRect()
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x44D0C70", Offset = "0x44D0C70", VA = "0x44D0C70")]
			public PixRect(int xx, int yy, int ww, int hh)
			{
			}
		}

		[Token(Token = "0x200014D")]
		private class Image
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int imgId;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FC10")]
			public int w;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int h;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int y;

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x44D5908", Offset = "0x44D5908", VA = "0x44D5908")]
			public Image(int id, int tw, int th, int padding, int minImageSizeX, int minImageSizeY)
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x44D6074", Offset = "0x44D6074", VA = "0x44D6074")]
			public Image(Image im)
			{
			}
		}

		[Token(Token = "0x200014E")]
		private class ImgIDComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x44D647C", Offset = "0x44D647C", VA = "0x44D647C", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x44D5CE0", Offset = "0x44D5CE0", VA = "0x44D5CE0")]
			public ImgIDComparer()
			{
			}
		}

		[Token(Token = "0x200014F")]
		private class ImageHeightComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x44D62A4", Offset = "0x44D62A4", VA = "0x44D62A4", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x44D5AE4", Offset = "0x44D5AE4", VA = "0x44D5AE4")]
			public ImageHeightComparer()
			{
			}
		}

		[Token(Token = "0x2000150")]
		private class ImageWidthComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x44D6390", Offset = "0x44D6390", VA = "0x44D6390", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x44D5B14", Offset = "0x44D5B14", VA = "0x44D5B14")]
			public ImageWidthComparer()
			{
			}
		}

		[Token(Token = "0x2000151")]
		private class ImageAreaComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x44D6170", Offset = "0x44D6170", VA = "0x44D6170", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x44D5B44", Offset = "0x44D5B44", VA = "0x44D5B44")]
			public ImageAreaComparer()
			{
			}
		}

		[Token(Token = "0x2000152")]
		private class ProbeResult
		{
			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CCB")]
			public int w;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int h;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FC20")]
			public Node root;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool fitsInMaxSize;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float efficiency;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float squareness;

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x44D1D60", Offset = "0x44D1D60", VA = "0x44D1D60")]
			public void Set(int ww, int hh, Node r, bool fits, float e, float sq)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x44D5BA4", Offset = "0x44D5BA4", VA = "0x44D5BA4")]
			public float GetScore(bool doPowerOfTwoScore)
			{
				return default(float);
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x44D5B74", Offset = "0x44D5B74", VA = "0x44D5B74")]
			public ProbeResult()
			{
			}
		}

		[Token(Token = "0x2000153")]
		private class Node
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CD3")]
			public Node[] child;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public PixRect r;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FC30")]
			public Image img;

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x44D6568", Offset = "0x44D6568", VA = "0x44D6568")]
			private bool isLeaf()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x44D0D00", Offset = "0x44D0D00", VA = "0x44D0D00")]
			public Node Insert(Image im, bool handed)
			{
				return null;
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x44D0BD0", Offset = "0x44D0BD0", VA = "0x44D0BD0")]
			public Node()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CBB")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private ProbeResult bestRoot;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC00")]
		public bool doPowerOfTwoTextures;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x44CEF5C", Offset = "0x44CEF5C", VA = "0x44CEF5C")]
		private static void printTree(Node r, string spc)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x44CF18C", Offset = "0x44CF18C", VA = "0x44CF18C")]
		private static void flattenTree(Node r, List<Image> putHere)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x44CF4C0", Offset = "0x44CF4C0", VA = "0x44CF4C0")]
		private static void drawGizmosNode(Node r)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x44CFAF8", Offset = "0x44CFAF8", VA = "0x44CFAF8")]
		private static Texture2D createFilledTex(Color c, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x44CFDE4", Offset = "0x44CFDE4", VA = "0x44CFDE4")]
		public void DrawGizmos()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x44CFE64", Offset = "0x44CFE64", VA = "0x44CFE64")]
		private bool Probe(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDim, ProbeResult pr)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x44D17D0", Offset = "0x44D17D0", VA = "0x44D17D0")]
		private void GetExtent(Node r, ref int x, ref int y)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x44D1E24", Offset = "0x44D1E24", VA = "0x44D1E24")]
		private int StepWidthHeight(int oldVal, int step, int maxDim)
		{
			return default(int);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x44D1F58", Offset = "0x44D1F58", VA = "0x44D1F58")]
		public int RoundToNearestPositivePowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x44D1C08", Offset = "0x44D1C08", VA = "0x44D1C08")]
		public int CeilToNearestPowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x44D20F4", Offset = "0x44D20F4", VA = "0x44D20F4")]
		public Rect[] GetRects(List<Vector2> imgWidthHeights, int maxDimension, int padding, out int outW, out int outH)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x44D22A8", Offset = "0x44D22A8", VA = "0x44D22A8")]
		private Rect[] _GetRects(List<Vector2> imgWidthHeights, int maxDimension, int padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, out int outW, out int outH, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x44D5D10", Offset = "0x44D5D10", VA = "0x44D5D10")]
		public void RunTestHarness()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x44D6018", Offset = "0x44D6018", VA = "0x44D6018")]
		public MB2_TexturePacker()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class MB3_CopyBoneWeights
	{
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x44D6694", Offset = "0x44D6694", VA = "0x44D6694")]
		public static void CopyBoneWeightsFromSeamMeshToOtherMeshes(float radius, Mesh seamMesh, Mesh[] targetMeshes)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x44D78A4", Offset = "0x44D78A4", VA = "0x44D78A4")]
		public MB3_CopyBoneWeights()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E5")]
	public abstract class MB3_MeshCombiner
	{
		[Token(Token = "0x2000154")]
		public delegate void GenerateUV2Delegate(Mesh m, float hardAngle, float packMargin);

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected MBVersion _MBVersion;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_LogLevel _LOG_LEVEL;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_ValidationLevel _validationLevel;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CDB")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC40")]
		[SerializeField]
		protected GameObject _resultSceneObject;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Renderer _targetRenderer;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB_RenderType _renderType;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE3")]
		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _doNorm;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC50")]
		[SerializeField]
		protected bool _doTan;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doCol;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doUV;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doUV3;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CEB")]
		[SerializeField]
		protected bool _doUV4;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		public float uv2UnwrappingParamsHardAngle;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC60")]
		[SerializeField]
		public float uv2UnwrappingParamsPackMargin;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool _usingTemporaryTextureBakeResult;

		[Token(Token = "0x17000082")]
		public static bool EVAL_VERSION
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x44D78D4", Offset = "0x44D78D4", VA = "0x44D78D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public virtual MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x44D78F4", Offset = "0x44D78F4", VA = "0x44D78F4", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x44D7924", Offset = "0x44D7924", VA = "0x44D7924", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public virtual MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x44D795C", Offset = "0x44D795C", VA = "0x44D795C", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x44D798C", Offset = "0x44D798C", VA = "0x44D798C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public string name
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x44D79C4", Offset = "0x44D79C4", VA = "0x44D79C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x44D79F4", Offset = "0x44D79F4", VA = "0x44D79F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public virtual MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x44D7A2C", Offset = "0x44D7A2C", VA = "0x44D7A2C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x44D7A5C", Offset = "0x44D7A5C", VA = "0x44D7A5C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public virtual GameObject resultSceneObject
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x44D7A94", Offset = "0x44D7A94", VA = "0x44D7A94", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x44D7AC4", Offset = "0x44D7AC4", VA = "0x44D7AC4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public virtual Renderer targetRenderer
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x44D7AFC", Offset = "0x44D7AFC", VA = "0x44D7AFC", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x44D7B2C", Offset = "0x44D7B2C", VA = "0x44D7B2C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public virtual MB_RenderType renderType
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x44D7D90", Offset = "0x44D7D90", VA = "0x44D7D90", Slot = "14")]
			get
			{
				return default(MB_RenderType);
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x44D7DC0", Offset = "0x44D7DC0", VA = "0x44D7DC0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public virtual MB2_OutputOptions outputOption
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x44D7DF8", Offset = "0x44D7DF8", VA = "0x44D7DF8", Slot = "16")]
			get
			{
				return default(MB2_OutputOptions);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x44D7E28", Offset = "0x44D7E28", VA = "0x44D7E28", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public virtual MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x44D7E60", Offset = "0x44D7E60", VA = "0x44D7E60", Slot = "18")]
			get
			{
				return default(MB2_LightmapOptions);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x44D7E90", Offset = "0x44D7E90", VA = "0x44D7E90", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public virtual bool doNorm
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x44D7EC8", Offset = "0x44D7EC8", VA = "0x44D7EC8", Slot = "20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x44D7F0C", Offset = "0x44D7F0C", VA = "0x44D7F0C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual bool doTan
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x44D7F58", Offset = "0x44D7F58", VA = "0x44D7F58", Slot = "22")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x44D7F9C", Offset = "0x44D7F9C", VA = "0x44D7F9C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual bool doCol
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x44D7FE8", Offset = "0x44D7FE8", VA = "0x44D7FE8", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x44D802C", Offset = "0x44D802C", VA = "0x44D802C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual bool doUV
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x44D8078", Offset = "0x44D8078", VA = "0x44D8078", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x44D80BC", Offset = "0x44D80BC", VA = "0x44D80BC", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public virtual bool doUV1
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x44D8108", Offset = "0x44D8108", VA = "0x44D8108", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x44D812C", Offset = "0x44D812C", VA = "0x44D812C", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public virtual bool doUV3
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x44D820C", Offset = "0x44D820C", VA = "0x44D820C", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x44D8250", Offset = "0x44D8250", VA = "0x44D8250", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public virtual bool doUV4
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x44D829C", Offset = "0x44D829C", VA = "0x44D829C", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x44D82E0", Offset = "0x44D82E0", VA = "0x44D82E0", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x44D814C", Offset = "0x44D814C", VA = "0x44D814C", Slot = "30")]
		public virtual bool doUV2()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		public abstract int GetLightmapIndex();

		[Token(Token = "0x60006AC")]
		public abstract void ClearBuffers();

		[Token(Token = "0x60006AD")]
		public abstract void ClearMesh();

		[Token(Token = "0x60006AE")]
		public abstract void DestroyMesh();

		[Token(Token = "0x60006AF")]
		public abstract void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods);

		[Token(Token = "0x60006B0")]
		public abstract List<GameObject> GetObjectsInCombined();

		[Token(Token = "0x60006B1")]
		public abstract int GetNumObjectsInCombined();

		[Token(Token = "0x60006B2")]
		public abstract int GetNumVerticesFor(GameObject go);

		[Token(Token = "0x60006B3")]
		public abstract int GetNumVerticesFor(int instanceID);

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x44D832C", Offset = "0x44D832C", VA = "0x44D832C", Slot = "44")]
		public virtual void Apply()
		{
		}

		[Token(Token = "0x60006B5")]
		public abstract void Apply(GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60006B6")]
		public abstract void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60006B7")]
		public abstract void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false);

		[Token(Token = "0x60006B8")]
		public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

		[Token(Token = "0x60006B9")]
		public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource);

		[Token(Token = "0x60006BA")]
		public abstract bool CombinedMeshContains(GameObject go);

		[Token(Token = "0x60006BB")]
		public abstract void UpdateSkinnedMeshApproximateBounds();

		[Token(Token = "0x60006BC")]
		public abstract void UpdateSkinnedMeshApproximateBoundsFromBones();

		[Token(Token = "0x60006BD")]
		public abstract void CheckIntegrity();

		[Token(Token = "0x60006BE")]
		public abstract void UpdateSkinnedMeshApproximateBoundsFromBounds();

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x44D8364", Offset = "0x44D8364", VA = "0x44D8364")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x44D8D2C", Offset = "0x44D8D2C", VA = "0x44D8D2C")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x44D9144", Offset = "0x44D9144", VA = "0x44D9144", Slot = "55")]
		protected virtual bool _CheckIfAllObjsToAddUseSameMaterialsAndCreateTemporaryTextrueBakeResult(GameObject[] gos)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x44D99C0", Offset = "0x44D99C0", VA = "0x44D99C0")]
		protected MB3_MeshCombiner()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E6")]
	public class MB3_MeshCombinerSingle : MB3_MeshCombiner
	{
		[Serializable]
		[Token(Token = "0x2000155")]
		public class MB_DynamicGameObject : IComparable<MB_DynamicGameObject>
		{
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int instanceID;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0B")]
			public string name;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int vertIdx;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FCA0")]
			public int numVerts;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[] indexesOfBonesUsed;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int lightmapIndex;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 lightmapTilingOffset;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D13")]
			public bool show;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public bool invertTriangles;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FCB0")]
			public int[] submeshTriIdxs;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[] submeshNumTris;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[] targetSubmeshIdxs;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect[] uvRects;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D1B")]
			public Rect[] uvSubRectInAtlas;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Rect[] uvRectsInSrcFull;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FCC0")]
			public Rect[] obUVRects;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[][] _submeshTris;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool _beingDeleted;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _triangleIdxAdjustment;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D23")]
			public Transform[] _tmpCachedBones;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Matrix4x4[] _tmpCachedBindposes;

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x44F6614", Offset = "0x44F6614", VA = "0x44F6614", Slot = "4")]
			public int CompareTo(MB_DynamicGameObject b)
			{
				return default(int);
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x44E6DCC", Offset = "0x44E6DCC", VA = "0x44E6DCC")]
			public MB_DynamicGameObject()
			{
			}
		}

		[Token(Token = "0x2000156")]
		public class MeshChannels
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FCD0")]
			public Vector3[] vertices;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3[] normals;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4[] tangents;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv0raw;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D2B")]
			public Vector2[] uv0modified;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector2[] uv2;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FCE0")]
			public Vector2[] uv3;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv4;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Color[] colors;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BoneWeight[] boneWeights;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D33")]
			public Matrix4x4[] bindPoses;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int[] triangles;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x44F666C", Offset = "0x44F666C", VA = "0x44F666C")]
			public MeshChannels()
			{
			}
		}

		[Token(Token = "0x2000157")]
		public class MeshChannelsCache
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FCF0")]
			private MB3_MeshCombinerSingle mc;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Dictionary<int, MeshChannels> meshID2MeshChannels;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector2 _HALF_UV;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x44E6C20", Offset = "0x44E6C20", VA = "0x44E6C20")]
			public MeshChannelsCache(MB3_MeshCombinerSingle mcs)
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x44E83CC", Offset = "0x44E83CC", VA = "0x44E83CC")]
			public Vector3[] GetVertices(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x44E85E8", Offset = "0x44E85E8", VA = "0x44E85E8")]
			public Vector3[] GetNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x44E8800", Offset = "0x44E8800", VA = "0x44E8800")]
			public Vector4[] GetTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x44DCFFC", Offset = "0x44DCFFC", VA = "0x44DCFFC")]
			public Vector2[] GetUv0Raw(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x44F718C", Offset = "0x44F718C", VA = "0x44F718C")]
			public Vector2[] GetUv0Modified(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x44EB084", Offset = "0x44EB084", VA = "0x44EB084")]
			public Vector2[] GetUv2(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x44E9D30", Offset = "0x44E9D30", VA = "0x44E9D30")]
			public Vector2[] GetUv3(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x44E9F90", Offset = "0x44E9F90", VA = "0x44E9F90")]
			public Vector2[] GetUv4(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x44EA1F0", Offset = "0x44EA1F0", VA = "0x44EA1F0")]
			public Color[] GetColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x44F5B08", Offset = "0x44F5B08", VA = "0x44F5B08")]
			public Matrix4x4[] GetBindposes(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x44F0D28", Offset = "0x44F0D28", VA = "0x44F0D28")]
			public BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x44F8178", Offset = "0x44F8178", VA = "0x44F8178")]
			public int[] GetTriangles(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x44F76A8", Offset = "0x44F76A8", VA = "0x44F76A8")]
			private Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x44F669C", Offset = "0x44F669C", VA = "0x44F669C")]
			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x44F6A20", Offset = "0x44F6A20", VA = "0x44F6A20")]
			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x44F6E6C", Offset = "0x44F6E6C", VA = "0x44F6E6C")]
			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x44F7388", Offset = "0x44F7388", VA = "0x44F7388")]
			private Vector2[] _getMeshUV2s(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x44F79DC", Offset = "0x44F79DC", VA = "0x44F79DC")]
			public static Matrix4x4[] _getBindPoses(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x44F7D10", Offset = "0x44F7D10", VA = "0x44F7D10")]
			public static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x44F8394", Offset = "0x44F8394", VA = "0x44F8394")]
			private void _generateTangents(int[] triangles, Vector3[] verts, Vector2[] uvs, Vector3[] normals, Vector4[] outTangents)
			{
			}
		}

		[Token(Token = "0x2000158")]
		public struct BoneAndBindpose
		{
			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform bone;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D2B")]
			public Matrix4x4 bindPose;

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x44F5D60", Offset = "0x44F5D60", VA = "0x44F5D60")]
			public BoneAndBindpose(Transform t, Matrix4x4 bp)
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x44F627C", Offset = "0x44F627C", VA = "0x44F627C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x44F6568", Offset = "0x44F6568", VA = "0x44F6568", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3280", Offset = "0x10A3280")]
		private sealed class <>c__DisplayClass49_0
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public GameObject[] _goToAdd;

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x44E5D6C", Offset = "0x44E5D6C", VA = "0x44E5D6C")]
			public <>c__DisplayClass49_0()
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A32BC", Offset = "0x10A32BC")]
		private sealed class <>c__DisplayClass49_1
		{
			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD00")]
			public int i;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass49_0 CS$<>8__locals1;

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x44E6D9C", Offset = "0x44E6D9C", VA = "0x44E6D9C")]
			public <>c__DisplayClass49_1()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x44F6198", Offset = "0x44F6198", VA = "0x44F6198")]
			internal bool <_addToCombined>b__0(int o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<GameObject> objectsInCombinedMesh;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int lightmapIndex;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF3")]
		[SerializeField]
		private List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Dictionary<int, MB_DynamicGameObject> _instance2combined_map;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC70")]
		[SerializeField]
		private Vector3[] verts;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector3[] normals;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector4[] tangents;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector2[] uvs;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CFB")]
		[SerializeField]
		private Vector2[] uv2s;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Vector2[] uv3s;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC80")]
		[SerializeField]
		private Vector2[] uv4s;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Color[] colors;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Matrix4x4[] bindPoses;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform[] bones;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D03")]
		[SerializeField]
		private Mesh _mesh;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int[][] submeshTris;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FC90")]
		private BoneWeight[] boneWeights;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject[] empty;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] emptyIDs;

		[Token(Token = "0x17000093")]
		public override MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x44DA0D4", Offset = "0x44DA0D4", VA = "0x44DA0D4", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public override MB_RenderType renderType
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x44DA3C4", Offset = "0x44DA3C4", VA = "0x44DA3C4", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public override GameObject resultSceneObject
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x44DA564", Offset = "0x44DA564", VA = "0x44DA564", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x44DA80C", Offset = "0x44DA80C", VA = "0x44DA80C")]
		private MB_DynamicGameObject instance2Combined_MapGet(int gameObjectID)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x44DA8B4", Offset = "0x44DA8B4", VA = "0x44DA8B4")]
		private void instance2Combined_MapAdd(int gameObjectID, MB_DynamicGameObject dgo)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x44DA964", Offset = "0x44DA964", VA = "0x44DA964")]
		private void instance2Combined_MapRemove(int gameObjectID)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x44DAA04", Offset = "0x44DAA04", VA = "0x44DAA04")]
		private bool instance2Combined_MapTryGetValue(int gameObjectID, out MB_DynamicGameObject dgo)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x44DAAD0", Offset = "0x44DAAD0", VA = "0x44DAAD0")]
		private int instance2Combined_MapCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x44DAB68", Offset = "0x44DAB68", VA = "0x44DAB68")]
		private void instance2Combined_MapClear()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x44DABF8", Offset = "0x44DABF8", VA = "0x44DABF8")]
		private bool instance2Combined_MapContainsKey(int gameObjectID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x44DACB4", Offset = "0x44DACB4", VA = "0x44DACB4", Slot = "41")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x44DAD4C", Offset = "0x44DAD4C", VA = "0x44DAD4C", Slot = "40")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x44DAE24", Offset = "0x44DAE24", VA = "0x44DAE24")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x44DAF80", Offset = "0x44DAF80", VA = "0x44DAF80")]
		public Transform[] GetBones()
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x44DAFB0", Offset = "0x44DAFB0", VA = "0x44DAFB0", Slot = "35")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x44DB04C", Offset = "0x44DB04C", VA = "0x44DB04C", Slot = "42")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x44DB0B8", Offset = "0x44DB0B8", VA = "0x44DB0B8", Slot = "43")]
		public override int GetNumVerticesFor(int instanceID)
		{
			return default(int);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x44DB150", Offset = "0x44DB150", VA = "0x44DB150")]
		private void _initialize()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x44DBD94", Offset = "0x44DBD94", VA = "0x44DBD94")]
		private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x44DC994", Offset = "0x44DC994", VA = "0x44DC994")]
		private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults, MeshChannelsCache meshChannelCache)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x44DD214", Offset = "0x44DD214", VA = "0x44DD214")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x44DD880", Offset = "0x44DD880", VA = "0x44DD880")]
		private bool _validateMeshFlags()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x44DDCF4", Offset = "0x44DDCF4", VA = "0x44DDCF4")]
		private bool _showHide(GameObject[] goToShow, GameObject[] goToHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x44DE434", Offset = "0x44DE434", VA = "0x44DE434")]
		private bool _addToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x44E8A18", Offset = "0x44E8A18", VA = "0x44E8A18")]
		private void _copyAndAdjustUVsFromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x44E97A8", Offset = "0x44E97A8", VA = "0x44E97A8")]
		private void _copyAndAdjustUV2FromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x44EB29C", Offset = "0x44EB29C", VA = "0x44EB29C", Slot = "51")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x44EB2CC", Offset = "0x44EB2CC", VA = "0x44EB2CC", Slot = "52")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x44EB8F0", Offset = "0x44EB8F0", VA = "0x44EB8F0", Slot = "54")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x44EBF54", Offset = "0x44EBF54", VA = "0x44EBF54")]
		private int _getNumBones(Renderer r)
		{
			return default(int);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x44EC168", Offset = "0x44EC168", VA = "0x44EC168")]
		private Transform[] _getBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x44EC1AC", Offset = "0x44EC1AC", VA = "0x44EC1AC", Slot = "45")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x44EC374", Offset = "0x44EC374", VA = "0x44EC374", Slot = "56")]
		public virtual void ApplyShowHide()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x44ED25C", Offset = "0x44ED25C", VA = "0x44ED25C", Slot = "46")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x44EC8E4", Offset = "0x44EC8E4", VA = "0x44EC8E4")]
		public int[][] GetSubmeshTrisWithShowHideApplied()
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x44EEFC0", Offset = "0x44EEFC0", VA = "0x44EEFC0", Slot = "47")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x44EF1B8", Offset = "0x44EF1B8", VA = "0x44EF1B8")]
		private void _updateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x44EF748", Offset = "0x44EF748", VA = "0x44EF748")]
		private void _updateGameObject(GameObject go, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x44F0F90", Offset = "0x44F0F90", VA = "0x44F0F90")]
		public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x44F0FFC", Offset = "0x44F0FFC", VA = "0x44F0FFC", Slot = "48")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x44F142C", Offset = "0x44F142C", VA = "0x44F142C", Slot = "49")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x44F250C", Offset = "0x44F250C", VA = "0x44F250C", Slot = "50")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x44F25C8", Offset = "0x44F25C8", VA = "0x44F25C8", Slot = "36")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x44F2960", Offset = "0x44F2960", VA = "0x44F2960", Slot = "37")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x44F2AE4", Offset = "0x44F2AE4", VA = "0x44F2AE4", Slot = "38")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x44F2CD0", Offset = "0x44F2CD0", VA = "0x44F2CD0", Slot = "39")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x44E5D9C", Offset = "0x44E5D9C", VA = "0x44E5D9C")]
		public bool ValidateTargRendererAndMeshAndResultSceneObj()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x44F2EF4", Offset = "0x44F2EF4", VA = "0x44F2EF4")]
		public static Renderer BuildSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, bool createNewChild = false, [Optional] GameObject[] objsToBeAdded)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x44F2314", Offset = "0x44F2314", VA = "0x44F2314")]
		public void BuildSceneMeshObject([Optional] GameObject[] gos, bool createNewChild = false)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x44E7690", Offset = "0x44E7690", VA = "0x44E7690")]
		private bool IsMirrored(Matrix4x4 tm)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x44F4F98", Offset = "0x44F4F98", VA = "0x44F4F98", Slot = "53")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x44E6888", Offset = "0x44E6888", VA = "0x44E6888")]
		private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x44E6F88", Offset = "0x44E6F88", VA = "0x44E6F88")]
		private void _CollectBonesToAddForDGO(MB_DynamicGameObject dgo, List<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Renderer r, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x44E79D8", Offset = "0x44E79D8", VA = "0x44E79D8")]
		private void _CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(List<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Transform[] nbones, Matrix4x4[] nbindPoses, BoneWeight[] nboneWeights, int totalDeleteVerts)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x44EA408", Offset = "0x44EA408", VA = "0x44EA408")]
		private void _AddBonesToNewBonesArrayAndAdjustBWIndexes(MB_DynamicGameObject dgo, Renderer r, int vertsIdx, Transform[] nbones, BoneWeight[] nboneWeights, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x44F5DEC", Offset = "0x44F5DEC", VA = "0x44F5DEC")]
		public MB3_MeshCombinerSingle()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E7")]
	public class MB3_MultiMeshCombiner : MB3_MeshCombiner
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public class CombinedMesh
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MB3_MeshCombinerSingle combinedMesh;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int extraSpace;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numVertsInListToDelete;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4B")]
			public int numVertsInListToAdd;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public List<GameObject> gosToAdd;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD20")]
			public List<int> gosToDelete;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<GameObject> gosToUpdate;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isDirty;

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x4884188", Offset = "0x4884188", VA = "0x4884188")]
			public CombinedMesh(int maxNumVertsInMesh, GameObject resultSceneObject, MB2_LogLevel ll)
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x488439C", Offset = "0x488439C", VA = "0x488439C")]
			public bool isEmpty()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject[] empty;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] emptyIDs;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D43")]
		public Dictionary<int, CombinedMesh> obj2MeshCombinerMap;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		public List<CombinedMesh> meshCombiners;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FD10")]
		[SerializeField]
		private int _maxVertsInMesh;

		[Token(Token = "0x17000096")]
		public override MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x44F9890", Offset = "0x44F9890", VA = "0x44F9890", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x44F98C0", Offset = "0x44F98C0", VA = "0x44F98C0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public override MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x44F9BBC", Offset = "0x44F9BBC", VA = "0x44F9BBC", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x44F9A3C", Offset = "0x44F9A3C", VA = "0x44F9A3C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int maxVertsInMesh
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x44F9BEC", Offset = "0x44F9BEC", VA = "0x44F9BEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x44F9C1C", Offset = "0x44F9C1C", VA = "0x44F9C1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x44F9E5C", Offset = "0x44F9E5C", VA = "0x44F9E5C", Slot = "41")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x44F9EF4", Offset = "0x44F9EF4", VA = "0x44F9EF4", Slot = "42")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x44FA050", Offset = "0x44FA050", VA = "0x44FA050", Slot = "43")]
		public override int GetNumVerticesFor(int gameObjectID)
		{
			return default(int);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x44FA18C", Offset = "0x44FA18C", VA = "0x44FA18C", Slot = "40")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x44FA374", Offset = "0x44FA374", VA = "0x44FA374", Slot = "35")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x44FA4BC", Offset = "0x44FA4BC", VA = "0x44FA4BC", Slot = "50")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x44FA594", Offset = "0x44FA594", VA = "0x44FA594")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x44FAC00", Offset = "0x44FAC00", VA = "0x44FAC00", Slot = "45")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x44FAE2C", Offset = "0x44FAE2C", VA = "0x44FAE2C", Slot = "46")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x44FB1FC", Offset = "0x44FB1FC", VA = "0x44FB1FC", Slot = "51")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x44FB354", Offset = "0x44FB354", VA = "0x44FB354", Slot = "52")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x44FB4AC", Offset = "0x44FB4AC", VA = "0x44FB4AC", Slot = "54")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x44FB604", Offset = "0x44FB604", VA = "0x44FB604", Slot = "47")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x44FBF74", Offset = "0x44FBF74", VA = "0x44FBF74", Slot = "48")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x44FC3A4", Offset = "0x44FC3A4", VA = "0x44FC3A4", Slot = "49")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x44FCC20", Offset = "0x44FCC20", VA = "0x44FCC20")]
		private bool _validate(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x44FDBB0", Offset = "0x44FDBB0", VA = "0x44FDBB0")]
		private void _distributeAmongBakers(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x44FED1C", Offset = "0x44FED1C", VA = "0x44FED1C")]
		private bool _bakeStep1(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x4500E58", Offset = "0x4500E58", VA = "0x4500E58", Slot = "36")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x4500FB0", Offset = "0x4500FB0", VA = "0x4500FB0", Slot = "37")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x4500FE0", Offset = "0x4500FE0", VA = "0x4500FE0", Slot = "38")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x4501348", Offset = "0x4501348", VA = "0x4501348", Slot = "39")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x4500A7C", Offset = "0x4500A7C", VA = "0x4500A7C")]
		private void _setMBValues(MB3_MeshCombinerSingle targ)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x45016E4", Offset = "0x45016E4", VA = "0x45016E4", Slot = "53")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x450183C", Offset = "0x450183C", VA = "0x450183C")]
		public MB3_MultiMeshCombiner()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E8")]
	public class ShaderTextureProperty
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D53")]
		public bool isNormalMap;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x48A6518", Offset = "0x48A6518", VA = "0x48A6518")]
		public ShaderTextureProperty(string n, bool norm)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x489CD94", Offset = "0x489CD94", VA = "0x489CD94")]
		public static string[] GetNames(List<ShaderTextureProperty> props)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000E9")]
	public class MB3_TextureCombiner
	{
		[Token(Token = "0x200015C")]
		public class MeshBakerMaterialTexture
		{
			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Texture2D t;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD60")]
			public float texelDensity;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DRect fullSamplingRect;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DRect matTilingRect;

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x48A7590", Offset = "0x48A7590", VA = "0x48A7590")]
			public MeshBakerMaterialTexture()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x48A75C0", Offset = "0x48A75C0", VA = "0x48A75C0")]
			public MeshBakerMaterialTexture(Texture2D tx)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x48915EC", Offset = "0x48915EC", VA = "0x48915EC")]
			public MeshBakerMaterialTexture(Texture2D tx, Vector2 o, Vector2 s, float texelDens)
			{
			}
		}

		[Token(Token = "0x200015D")]
		public class MatAndTransformToMerged
		{
			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Material mat;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D73")]
			public DRect matSubrectInFullSamplingRect;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public DRect obUVRectIfTilingSame;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD70")]
			public DRect samplingRectMatAndUVTiling;

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x4891BF0", Offset = "0x4891BF0", VA = "0x4891BF0")]
			public MatAndTransformToMerged(Material m)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x48A71E8", Offset = "0x48A71E8", VA = "0x48A71E8", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x48A74CC", Offset = "0x48A74CC", VA = "0x48A74CC", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200015E")]
		public class SamplingRectEnclosesComparer : IComparer<MatAndTransformToMerged>
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x48A7608", Offset = "0x48A7608", VA = "0x48A7608", Slot = "4")]
			public int Compare(MatAndTransformToMerged x, MatAndTransformToMerged y)
			{
				return default(int);
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x48A29E0", Offset = "0x48A29E0", VA = "0x48A29E0")]
			public SamplingRectEnclosesComparer()
			{
			}
		}

		[Token(Token = "0x200015F")]
		public class MB_TexSet
		{
			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MeshBakerMaterialTexture[] ts;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<MatAndTransformToMerged> mats;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<GameObject> gos;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D7B")]
			public bool allTexturesUseSameMatTiling;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector2 obUVoffset;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD80")]
			public Vector2 obUVscale;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int idealWidth;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int idealHeight;

			[Token(Token = "0x170000E0")]
			public DRect obUVrect
			{
				[Token(Token = "0x600091C")]
				[Address(RVA = "0x48A6E94", Offset = "0x48A6E94", VA = "0x48A6E94")]
				get
				{
					return default(DRect);
				}
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x4891828", Offset = "0x4891828", VA = "0x4891828")]
			public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale)
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x48A67AC", Offset = "0x48A67AC", VA = "0x48A67AC")]
			public bool IsEqual(object obj, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, TextureBlender resultMaterialTextureBlender)
			{
				return default(bool);
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x48A1220", Offset = "0x48A1220", VA = "0x48A1220")]
			public void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x48A1668", Offset = "0x48A1668", VA = "0x48A1668")]
			public void CalcMatAndUVSamplingRectsIfAllMatTilingSame()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x48A1BC8", Offset = "0x48A1BC8", VA = "0x48A1BC8")]
			public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, TextureBlender resultMaterialTextureBlender)
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x48A0CE4", Offset = "0x48A0CE4", VA = "0x48A0CE4")]
			internal string GetDescription()
			{
				return null;
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x48A6F2C", Offset = "0x48A6F2C", VA = "0x48A6F2C")]
			internal string GetMatSubrectDescriptions()
			{
				return null;
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A32F8", Offset = "0x10A32F8")]
		private sealed class <>c__DisplayClass58_0
		{
			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<ShaderTextureProperty> texPropertyNames;

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x4887C9C", Offset = "0x4887C9C", VA = "0x4887C9C")]
			public <>c__DisplayClass58_0()
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3334", Offset = "0x10A3334")]
		private sealed class <>c__DisplayClass58_1
		{
			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D83")]
			public int i;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public <>c__DisplayClass58_0 CS$<>8__locals1;

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x4887CCC", Offset = "0x4887CCC", VA = "0x4887CCC")]
			public <>c__DisplayClass58_1()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x48A658C", Offset = "0x48A658C", VA = "0x48A658C")]
			internal bool <_CollectPropertyNames>b__0(ShaderTextureProperty x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10A3370", Offset = "0x10A3370")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD90")]
			public MB_TexSet setOfTexs;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x4891340", Offset = "0x4891340", VA = "0x4891340")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x48A66B4", Offset = "0x48A66B4", VA = "0x48A66B4")]
			internal bool <__Step1_CollectDistinctMatTexturesAndUsedObjects>b__0(MB_TexSet x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static bool DO_INTEGRITY_CHECKS;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FD30")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ShaderTextureProperty[] shaderTexPropertyNames;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected int _atlasPadding;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5B")]
		[SerializeField]
		protected int _maxAtlasSize;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _resizePowerOfTwoTextures;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FD40")]
		[SerializeField]
		protected bool _fixOutOfBoundsUVs;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected int _maxTilingBakeSize;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _saveAtlasesAsAssets;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_PackingAlgorithmEnum _packingAlgorithm;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D63")]
		[SerializeField]
		protected bool _meshBakerTexturePackerForcePowerOfTwo;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected List<ShaderTextureProperty> _customShaderPropNames;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FD50")]
		[SerializeField]
		protected bool _normalizeTexelDensity;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _considerNonTextureProperties;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TextureBlender resultMaterialTextureBlender;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TextureBlender[] textureBlenders;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6B")]
		protected List<Texture2D> _temporaryTextures;

		[Token(Token = "0x17000099")]
		public MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x488473C", Offset = "0x488473C", VA = "0x488473C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x488476C", Offset = "0x488476C", VA = "0x488476C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int atlasPadding
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x48847A4", Offset = "0x48847A4", VA = "0x48847A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x48847D4", Offset = "0x48847D4", VA = "0x48847D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public int maxAtlasSize
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x488480C", Offset = "0x488480C", VA = "0x488480C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x488483C", Offset = "0x488483C", VA = "0x488483C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool resizePowerOfTwoTextures
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x4884874", Offset = "0x4884874", VA = "0x4884874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x48848B8", Offset = "0x48848B8", VA = "0x48848B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool fixOutOfBoundsUVs
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x4884904", Offset = "0x4884904", VA = "0x4884904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x4884948", Offset = "0x4884948", VA = "0x4884948")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public int maxTilingBakeSize
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x4884994", Offset = "0x4884994", VA = "0x4884994")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x48849C4", Offset = "0x48849C4", VA = "0x48849C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool saveAtlasesAsAssets
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x48849FC", Offset = "0x48849FC", VA = "0x48849FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x4884A40", Offset = "0x4884A40", VA = "0x4884A40")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public MB2_PackingAlgorithmEnum packingAlgorithm
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x4884A8C", Offset = "0x4884A8C", VA = "0x4884A8C")]
			get
			{
				return default(MB2_PackingAlgorithmEnum);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x4884ABC", Offset = "0x4884ABC", VA = "0x4884ABC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool meshBakerTexturePackerForcePowerOfTwo
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x4884AF4", Offset = "0x4884AF4", VA = "0x4884AF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x4884B38", Offset = "0x4884B38", VA = "0x4884B38")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public List<ShaderTextureProperty> customShaderPropNames
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x4884B84", Offset = "0x4884B84", VA = "0x4884B84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x4884BB4", Offset = "0x4884BB4", VA = "0x4884BB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool considerNonTextureProperties
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x4884BEC", Offset = "0x4884BEC", VA = "0x4884BEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x4884C30", Offset = "0x4884C30", VA = "0x4884C30")]
			set
			{
			}
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4884C7C", Offset = "0x4884C7C", VA = "0x4884C7C")]
		public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, [Optional] MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x4885D64", Offset = "0x4885D64", VA = "0x4885D64")]
		private static bool InterfaceFilter(Type typeObj, object criteriaObj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4885E04", Offset = "0x4885E04", VA = "0x4885E04")]
		private void _LoadTextureBlenders()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x4886854", Offset = "0x4886854", VA = "0x4886854")]
		private bool _CollectPropertyNames(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x4884D28", Offset = "0x4884D28", VA = "0x4884D28")]
		private bool _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x488840C", Offset = "0x488840C", VA = "0x488840C")]
		private bool __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x48892D4", Offset = "0x48892D4", VA = "0x48892D4")]
		private bool __Step1_CollectDistinctMatTexturesAndUsedObjects(List<GameObject> allObjsToMesh, List<Material> allowedMaterialsFilter, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface textureEditorMethods, List<MB_TexSet> distinctMaterialTextures, List<GameObject> usedObjsToMesh)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x488B318", Offset = "0x488B318", VA = "0x488B318")]
		private int __Step2_CalculateIdealSizesForTexturesInAtlasAndPadding(List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor)
		{
			return default(int);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x488D864", Offset = "0x488D864", VA = "0x488D864")]
		private void __Step3_BuildAndSaveAtlasesAndStoreResults(ProgressUpdateDelegate progressInfo, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, int _padding, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4897CB4", Offset = "0x4897CB4", VA = "0x4897CB4")]
		private Rect[] __CreateAtlasesMBTexturePacker(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4899DB4", Offset = "0x4899DB4", VA = "0x4899DB4")]
		private Rect[] __CreateAtlasesMBTexturePackerFast(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x48957E8", Offset = "0x48957E8", VA = "0x48957E8")]
		private Rect[] __CreateAtlasesUnityTexturePacker(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x48A0220", Offset = "0x48A0220", VA = "0x48A0220")]
		private void _addWatermark(Texture2D[] texToPack)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x48A073C", Offset = "0x48A073C", VA = "0x48A073C")]
		private Texture2D _addWatermark(Texture2D texToPack)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x48A0238", Offset = "0x48A0238", VA = "0x48A0238")]
		private Texture2D _copyTexturesIntoAtlas(Texture2D[] texToPack, int padding, Rect[] rs, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x489575C", Offset = "0x489575C", VA = "0x489575C")]
		private bool IsPowerOfTwo(int x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x4891D70", Offset = "0x4891D70", VA = "0x4891D70")]
		private void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures, bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x4894BF4", Offset = "0x4894BF4", VA = "0x4894BF4")]
		private Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x489F148", Offset = "0x489F148", VA = "0x489F148")]
		public Texture2D GetAdjustedForScaleAndOffset2(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x48A2A10", Offset = "0x48A2A10", VA = "0x48A2A10")]
		internal static DRect GetSourceSamplingRect(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x489FCD0", Offset = "0x489FCD0", VA = "0x489FCD0")]
		private Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x489CF5C", Offset = "0x489CF5C", VA = "0x489CF5C")]
		public void CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, bool _fixOutOfBoundsUVs, int maxSize, Color[][] atlasPixels, int atlasWidth, bool isNormalMap, [Optional] ProgressUpdateDelegate progressInfo)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x489E9D8", Offset = "0x489E9D8", VA = "0x489E9D8")]
		public Texture2D _createTemporaryTexture(int w, int h, TextureFormat texFormat, bool mipMaps)
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x48A2C6C", Offset = "0x48A2C6C", VA = "0x48A2C6C")]
		internal Texture2D _createTextureCopy(Texture2D t)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x489FBCC", Offset = "0x489FBCC", VA = "0x489FBCC")]
		private Texture2D _resizeTexture(Texture2D t, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x488902C", Offset = "0x488902C", VA = "0x488902C")]
		private void _destroyTemporaryTextures()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x48A2E9C", Offset = "0x48A2E9C", VA = "0x48A2E9C")]
		public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4888160", Offset = "0x4888160", VA = "0x4888160")]
		private TextureBlender FindMatchingTextureBlender(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x489BEA0", Offset = "0x489BEA0", VA = "0x489BEA0")]
		private void AdjustNonTextureProperties(Material mat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, bool considerTintColor, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x489ED6C", Offset = "0x489ED6C", VA = "0x489ED6C")]
		public static Color GetColorIfNoTexture(ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x48A56BC", Offset = "0x48A56BC", VA = "0x48A56BC")]
		private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x4890DD4", Offset = "0x4890DD4", VA = "0x4890DD4")]
		private float GetSubmeshArea(Mesh m, int submeshIdx)
		{
			return default(float);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x48A54DC", Offset = "0x48A54DC", VA = "0x48A54DC")]
		private string PrintList(List<GameObject> gos)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x48A5A7C", Offset = "0x48A5A7C", VA = "0x48A5A7C")]
		public MB3_TextureCombiner()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public struct DRect
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double y;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7B")]
		public double width;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
		public double height;

		[Token(Token = "0x170000A4")]
		public Vector2 min
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x44CD458", Offset = "0x44CD458", VA = "0x44CD458")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector2 max
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x44CD4E8", Offset = "0x44CD4E8", VA = "0x44CD4E8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170000A6")]
		public Vector2 size
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x44CD5B0", Offset = "0x44CD5B0", VA = "0x44CD5B0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x44CD010", Offset = "0x44CD010", VA = "0x44CD010")]
		public DRect(Rect r)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x44CD120", Offset = "0x44CD120", VA = "0x44CD120")]
		public DRect(Vector2 o, Vector2 s)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x44CD288", Offset = "0x44CD288", VA = "0x44CD288")]
		public DRect(float xx, float yy, float w, float h)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x44CD318", Offset = "0x44CD318", VA = "0x44CD318")]
		public DRect(double xx, double yy, double w, double h)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x44CD398", Offset = "0x44CD398", VA = "0x44CD398")]
		public Rect GetRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x44CD640", Offset = "0x44CD640", VA = "0x44CD640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x44CD880", Offset = "0x44CD880", VA = "0x44CD880")]
		public static bool operator ==(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x44CD9B4", Offset = "0x44CD9B4", VA = "0x44CD9B4")]
		public static bool operator !=(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x44CDB28", Offset = "0x44CDB28", VA = "0x44CDB28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x44CDD48", Offset = "0x44CDD48", VA = "0x44CDD48")]
		public bool Encloses(DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x44CE11C", Offset = "0x44CE11C", VA = "0x44CE11C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000EB")]
	public class MB3_UVTransformUtility
	{
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x48A7848", Offset = "0x48A7848", VA = "0x48A7848")]
		public static float TransformX(DRect r, double x)
		{
			return default(float);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x48A2820", Offset = "0x48A2820", VA = "0x48A2820")]
		public static DRect CombineTransforms(ref DRect r1, ref DRect r2)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x48A7900", Offset = "0x48A7900", VA = "0x48A7900")]
		public static Rect CombineTransforms(ref Rect r1, ref Rect r2)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x48A10BC", Offset = "0x48A10BC", VA = "0x48A10BC")]
		public static DRect InverseTransform(ref DRect t)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x48A236C", Offset = "0x48A236C", VA = "0x48A236C")]
		public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x48A0B80", Offset = "0x48A0B80", VA = "0x48A0B80")]
		public static void InvertHierarchy(ref DRect uvRect, ref DRect matRect)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x48A7B14", Offset = "0x48A7B14", VA = "0x48A7B14")]
		public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x48A7ED4", Offset = "0x48A7ED4", VA = "0x48A7ED4")]
		public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x48A82F8", Offset = "0x48A82F8", VA = "0x48A82F8")]
		internal static Vector2 TransformPoint(ref DRect r, Vector2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x48A8478", Offset = "0x48A8478", VA = "0x48A8478")]
		public MB3_UVTransformUtility()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class MB_Utility
	{
		[Token(Token = "0x2000163")]
		public struct MeshAnalysisResult
		{
			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FD90")]
			public Rect uvRect;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasOutOfBoundsUVs;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasOverlappingSubmeshVerts;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasOverlappingSubmeshTris;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D83")]
			public float submeshArea;
		}

		[Token(Token = "0x2000164")]
		private class MB_Triangle
		{
			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int submeshIdx;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578FDB0")]
			private int[] vs;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x48AC024", Offset = "0x48AC024", VA = "0x48AC024")]
			public bool isSame(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x48AC32C", Offset = "0x48AC32C", VA = "0x48AC32C")]
			public bool sharesVerts(MB_Triangle obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x48ABE30", Offset = "0x48ABE30", VA = "0x48ABE30")]
			public void Initialize(int[] ts, int idx, int sIdx)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x48ABD90", Offset = "0x48ABD90", VA = "0x48ABD90")]
			public MB_Triangle()
			{
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x48A2D50", Offset = "0x48A2D50", VA = "0x48A2D50")]
		public static Texture2D createTextureCopy(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x48AA6D4", Offset = "0x48AA6D4", VA = "0x48AA6D4")]
		public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x489009C", Offset = "0x489009C", VA = "0x489009C")]
		public static Material[] GetGOMaterials(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x488FC84", Offset = "0x488FC84", VA = "0x488FC84")]
		public static Mesh GetMesh(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x48AA8BC", Offset = "0x48AA8BC", VA = "0x48AA8BC")]
		public static Renderer GetRenderer(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x48AABC4", Offset = "0x48AABC4", VA = "0x48AABC4")]
		public static void DisableRendererInSource(GameObject go)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x48AAEF0", Offset = "0x48AAEF0", VA = "0x48AAEF0")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x4890BF4", Offset = "0x4890BF4", VA = "0x4890BF4")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x48AAFA8", Offset = "0x48AAFA8", VA = "0x48AAFA8")]
		public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x489EB2C", Offset = "0x489EB2C", VA = "0x489EB2C")]
		public static void setSolidColor(Texture2D t, Color c)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x48A0760", Offset = "0x48A0760", VA = "0x48A0760")]
		public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4891370", Offset = "0x4891370", VA = "0x4891370")]
		public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x48A4E68", Offset = "0x48A4E68", VA = "0x48A4E68")]
		public static int doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x48ACACC", Offset = "0x48ACACC", VA = "0x48ACACC")]
		public static bool GetBounds(GameObject go, out Bounds b)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x489E840", Offset = "0x489E840", VA = "0x489E840")]
		public static void Destroy(UnityEngine.Object o)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x48AD158", Offset = "0x48AD158", VA = "0x48AD158")]
		public MB_Utility()
		{
		}
	}
}
namespace HeatMap.MiniJSON
{
	[Token(Token = "0x20000ED")]
	public static class Json
	{
		[Token(Token = "0x2000165")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000172")]
			private enum TOKEN
			{
				[Token(Token = "0x4000831")]
				NONE,
				[Token(Token = "0x4000832")]
				CURLY_OPEN,
				[Token(Token = "0x4000833")]
				CURLY_CLOSE,
				[Token(Token = "0x4000834")]
				SQUARED_OPEN,
				[Token(Token = "0x4000835")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000836")]
				COLON,
				[Token(Token = "0x4000837")]
				COMMA,
				[Token(Token = "0x4000838")]
				STRING,
				[Token(Token = "0x4000839")]
				NUMBER,
				[Token(Token = "0x400083A")]
				TRUE,
				[Token(Token = "0x400083B")]
				FALSE,
				[Token(Token = "0x400083C")]
				NULL
			}

			[Token(Token = "0x4000810")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private StringReader json;

			[Token(Token = "0x170000E1")]
			private char PeekChar
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x48B7578", Offset = "0x48B7578", VA = "0x48B7578")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000E2")]
			private char NextChar
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x48B7120", Offset = "0x48B7120", VA = "0x48B7120")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000E3")]
			private string NextWord
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x48B7240", Offset = "0x48B7240", VA = "0x48B7240")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0x48B5BC0", Offset = "0x48B5BC0", VA = "0x48B5BC0")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x48B55EC", Offset = "0x48B55EC", VA = "0x48B55EC")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x48B57B8", Offset = "0x48B57B8", VA = "0x48B57B8")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x48B5324", Offset = "0x48B5324", VA = "0x48B5324")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x48B58D4", Offset = "0x48B58D4", VA = "0x48B58D4", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x48B5930", Offset = "0x48B5930", VA = "0x48B5930")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x48B6A38", Offset = "0x48B6A38", VA = "0x48B6A38")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x48B5870", Offset = "0x48B5870", VA = "0x48B5870")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x48B6C60", Offset = "0x48B6C60", VA = "0x48B6C60")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x48B62D8", Offset = "0x48B62D8", VA = "0x48B62D8")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x48B6F04", Offset = "0x48B6F04", VA = "0x48B6F04")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x48B73DC", Offset = "0x48B73DC", VA = "0x48B73DC")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000166")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DAB")]
			private StringBuilder builder;

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x3C678A4", Offset = "0x3C678A4", VA = "0x3C678A4")]
			private Serializer()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x3C6794C", Offset = "0x3C6794C", VA = "0x3C6794C")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x3C67A40", Offset = "0x3C67A40", VA = "0x3C67A40")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x3C687D4", Offset = "0x3C687D4", VA = "0x3C687D4")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x3C683E4", Offset = "0x3C683E4", VA = "0x3C683E4")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x3C67DDC", Offset = "0x3C67DDC", VA = "0x3C67DDC")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x3C68CB4", Offset = "0x3C68CB4", VA = "0x3C68CB4")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x48B52A4", Offset = "0x48B52A4", VA = "0x48B52A4")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x48B55AC", Offset = "0x48B55AC", VA = "0x48B55AC")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace UnityAnalyticsHeatmap
{
	[Token(Token = "0x20000EE")]
	public class HeatmapDataParser
	{
		[Token(Token = "0x2000167")]
		public delegate void ParseHandler(Dictionary<string, HeatPoint[]> heatData, string[] options);

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private ParseHandler m_ParseHandler;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x53E5920", Offset = "0x53E5920", VA = "0x53E5920")]
		public HeatmapDataParser()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x53E5950", Offset = "0x53E5950", VA = "0x53E5950")]
		public void LoadData(string path, ParseHandler handler, bool asResource = false)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x53E5B04", Offset = "0x53E5B04", VA = "0x53E5B04")]
		protected void LoadStream(string path)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x53E5A20", Offset = "0x53E5A20", VA = "0x53E5A20")]
		protected void LoadResource(string path)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x53E5DA0", Offset = "0x53E5DA0", VA = "0x53E5DA0")]
		protected void ConsumeHeatmapData(string text)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class HeatmapEvent
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FDE0")]
		private static Dictionary<string, object> s_Dictionary;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x53E7B14", Offset = "0x53E7B14", VA = "0x53E7B14")]
		public static AnalyticsResult Send(string eventName, Vector3 v, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x53E853C", Offset = "0x53E853C", VA = "0x53E853C")]
		public static AnalyticsResult Send(string eventName, Vector3 v, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x53E8800", Offset = "0x53E8800", VA = "0x53E8800")]
		public static AnalyticsResult Send(string eventName, Vector3 v, float time, float rotation, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x53E89F0", Offset = "0x53E89F0", VA = "0x53E89F0")]
		public static AnalyticsResult Send(string eventName, Transform trans, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x53E8E4C", Offset = "0x53E8E4C", VA = "0x53E8E4C")]
		public static AnalyticsResult Send(string eventName, Transform trans, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x53E90A8", Offset = "0x53E90A8", VA = "0x53E90A8")]
		public static AnalyticsResult Send(string eventName, Vector3 v, Vector3 v1, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x53E9464", Offset = "0x53E9464", VA = "0x53E9464")]
		public static AnalyticsResult Send(string eventName, Vector3 v, Vector3 v1, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x53E83D0", Offset = "0x53E83D0", VA = "0x53E83D0")]
		protected static AnalyticsResult Commit(string eventName)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x53E7C64", Offset = "0x53E7C64", VA = "0x53E7C64")]
		protected static void AddXY(float x, float y)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x53E7E34", Offset = "0x53E7E34", VA = "0x53E7E34")]
		protected static void AddZ(float z)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x53E86A4", Offset = "0x53E86A4", VA = "0x53E86A4")]
		protected static void AddTime(float time)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x53E8C34", Offset = "0x53E8C34", VA = "0x53E8C34")]
		protected static void AddRotation(Vector3 r)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x53E924C", Offset = "0x53E924C", VA = "0x53E924C")]
		protected static void AddDestination(Vector3 v)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x53E7F90", Offset = "0x53E7F90", VA = "0x53E7F90")]
		protected static void AddOptions(Dictionary<string, object> options)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x53E9628", Offset = "0x53E9628", VA = "0x53E9628")]
		public HeatmapEvent()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public enum AggregationMethod
	{
		[Token(Token = "0x4000604")]
		Increment,
		[Token(Token = "0x4000605")]
		Cumulative,
		[Token(Token = "0x4000606")]
		Average,
		[Token(Token = "0x4000607")]
		Max,
		[Token(Token = "0x4000608")]
		Min,
		[Token(Token = "0x4000609")]
		First,
		[Token(Token = "0x400060A")]
		Last,
		[Token(Token = "0x400060B")]
		Percentile
	}
	[Token(Token = "0x20000F1")]
	public struct HeatPoint
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DAB")]
		public Vector3 position;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
		public Vector3 rotation;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578FDF0")]
		public Vector3 destination;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float density;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;
	}
	[Token(Token = "0x20000F2")]
	public interface IHeatmapRenderer
	{
		[Token(Token = "0x170000A7")]
		float pointSize
		{
			[Token(Token = "0x600079D")]
			get;
			[Token(Token = "0x600079E")]
			set;
		}

		[Token(Token = "0x170000A8")]
		bool allowRender
		{
			[Token(Token = "0x600079F")]
			get;
			[Token(Token = "0x60007A0")]
			set;
		}

		[Token(Token = "0x170000A9")]
		bool activateTips
		{
			[Token(Token = "0x60007A1")]
			get;
			[Token(Token = "0x60007A2")]
			set;
		}

		[Token(Token = "0x170000AA")]
		int currentPoints
		{
			[Token(Token = "0x60007A3")]
			get;
		}

		[Token(Token = "0x170000AB")]
		int totalPoints
		{
			[Token(Token = "0x60007A4")]
			get;
		}

		[Token(Token = "0x6000795")]
		void UpdatePointData(HeatPoint[] data, float maxDensity);

		[Token(Token = "0x6000796")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x10B2984", Offset = "0x10B2984")]
		void UpdateColors(Color[] colors);

		[Token(Token = "0x6000797")]
		void UpdateGradient(Gradient gradient);

		[Token(Token = "0x6000798")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x10B29C0", Offset = "0x10B29C0")]
		void UpdateThresholds(float[] thresholds);

		[Token(Token = "0x6000799")]
		void UpdateRenderMask(float lowX, float highX, float lowY, float highY, float lowZ, float highZ);

		[Token(Token = "0x600079A")]
		void UpdateTimeLimits(float startTime, float endTime);

		[Token(Token = "0x600079B")]
		void RenderHeatmap();

		[Token(Token = "0x600079C")]
		void UpdateRenderStyle(RenderShape style, RenderDirection direction);
	}
	[Token(Token = "0x20000F3")]
	public enum RenderDirection
	{
		[Token(Token = "0x4000612")]
		YZ,
		[Token(Token = "0x4000613")]
		XZ,
		[Token(Token = "0x4000614")]
		XY
	}
	[Token(Token = "0x20000F4")]
	public enum RenderShape
	{
		[Token(Token = "0x4000616")]
		Cube,
		[Token(Token = "0x4000617")]
		Arrow,
		[Token(Token = "0x4000618")]
		PointToPoint,
		[Token(Token = "0x4000619")]
		Square,
		[Token(Token = "0x400061A")]
		Triangle
	}
}
