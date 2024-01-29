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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Color s_HighDensityColor;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Color s_MediumDensityColor;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF03")]
	private static Color s_LowDensityColor;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x47A144C", Offset = "0x47A144C", VA = "0x47A144C")]
	public GradientContainer()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C568", Offset = "0x105C568")]
public class HeatmapController : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public string dataPath;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F163C")]
	public string[] options;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int optionIndex;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int oldOptionIndex;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float pointSize;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0B")]
	private float oldPointSize;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private HeatmapDataParser m_DataParser;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F164C")]
	private Dictionary<string, HeatPoint[]> m_Data;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Gradient gradient;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_MaxDensity;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_MaxTime;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF13")]
	private Vector3 m_LowSpace;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private Vector3 m_HighSpace;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3A8E288", Offset = "0x3A8E288", VA = "0x3A8E288")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3A8E370", Offset = "0x3A8E370", VA = "0x3A8E370")]
	private void LoadData()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3A8E45C", Offset = "0x3A8E45C", VA = "0x3A8E45C")]
	private void parseHandler(Dictionary<string, HeatPoint[]> heatData, string[] options)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3A8E4C0", Offset = "0x3A8E4C0", VA = "0x3A8E4C0")]
	private void Render()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3A8ED80", Offset = "0x3A8ED80", VA = "0x3A8ED80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3A8E9AC", Offset = "0x3A8E9AC", VA = "0x3A8E9AC")]
	private void SetLimits(HeatPoint[] points)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3A8EFE4", Offset = "0x3A8EFE4", VA = "0x3A8EFE4")]
	public HeatmapController()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C618", Offset = "0x105C618")]
public class HeatmapMeshRenderer : MonoBehaviour, IHeatmapRenderer
{
	[Serializable]
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105E938", Offset = "0x105E938")]
	private sealed class <>c
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static readonly <>c <>9;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F16AC")]
		public static Func<Vector3[], IEnumerable<Vector3>> <>9__54_0;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<Color32[], IEnumerable<Color32>> <>9__54_1;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x3A96F98", Offset = "0x3A96F98", VA = "0x3A96F98")]
		public <>c()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x3A96FC8", Offset = "0x3A96FC8", VA = "0x3A96FC8")]
		internal IEnumerable<Vector3> <RenderSubmap>b__54_0(Vector3[] x)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x3A96FEC", Offset = "0x3A96FEC", VA = "0x3A96FEC")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private float m_HighThreshold;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F166C")]
	private float m_LowThreshold;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_StartTime;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_EndTime;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105ECF8", Offset = "0x105ECF8")]
	private float m_ParticleSize;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF23")]
	private bool m_Tips;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private HeatPoint[] m_Data;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F167C")]
	private float m_MaxDensity;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowX;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowY;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowZ;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF2B")]
	private float m_HighX;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private float m_HighY;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F168C")]
	private float m_HighZ;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderShape m_RenderStyle;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderDirection m_RenderDirection;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Shader m_Shader;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF33")]
	public Material[] m_Materials;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private Gradient m_Gradient;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F169C")]
	private int m_RenderState;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<GameObject> m_GameObjects;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105ED48", Offset = "0x105ED48")]
	private bool <allowRender>k__BackingField;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105ED84", Offset = "0x105ED84")]
	private int <currentPoints>k__BackingField;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF3B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EDC0", Offset = "0x105EDC0")]
	private int <totalPoints>k__BackingField;

	[Token(Token = "0x17000001")]
	public float pointSize
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3A8FCF8", Offset = "0x3A8FCF8", VA = "0x3A8FCF8", Slot = "12")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3A8FD28", Offset = "0x3A8FD28", VA = "0x3A8FD28", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public bool activateTips
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3A8FDAC", Offset = "0x3A8FDAC", VA = "0x3A8FDAC", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3A8FDF0", Offset = "0x3A8FDF0", VA = "0x3A8FDF0", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool allowRender
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3A900B8", Offset = "0x3A900B8", VA = "0x3A900B8", Slot = "14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106A798", Offset = "0x106A798")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3A900FC", Offset = "0x3A900FC", VA = "0x3A900FC", Slot = "15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106A7D4", Offset = "0x106A7D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public int currentPoints
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3A90148", Offset = "0x3A90148", VA = "0x3A90148", Slot = "18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106A810", Offset = "0x106A810")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3A90178", Offset = "0x3A90178", VA = "0x3A90178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106A84C", Offset = "0x106A84C")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int totalPoints
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3A901B0", Offset = "0x3A901B0", VA = "0x3A901B0", Slot = "19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106A888", Offset = "0x106A888")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3A901E0", Offset = "0x3A901E0", VA = "0x3A901E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106A8C4", Offset = "0x106A8C4")]
		set
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3A8F16C", Offset = "0x3A8F16C", VA = "0x3A8F16C")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3A8F200", Offset = "0x3A8F200", VA = "0x3A8F200", Slot = "4")]
	public void UpdatePointData(HeatPoint[] newData, float newMaxDensity)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3A8F264", Offset = "0x3A8F264", VA = "0x3A8F264", Slot = "5")]
	public void UpdateColors(Color[] colors)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3A8F27C", Offset = "0x3A8F27C", VA = "0x3A8F27C", Slot = "7")]
	public void UpdateThresholds(float[] threshholds)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3A8F294", Offset = "0x3A8F294", VA = "0x3A8F294", Slot = "6")]
	public void UpdateGradient(Gradient gradient)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3A8FA80", Offset = "0x3A8FA80", VA = "0x3A8FA80", Slot = "8")]
	public void UpdateRenderMask(float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3A90218", Offset = "0x3A90218", VA = "0x3A90218", Slot = "9")]
	public void UpdateTimeLimits(float startTime, float endTime)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3A902E8", Offset = "0x3A902E8", VA = "0x3A902E8", Slot = "11")]
	public void UpdateRenderStyle(RenderShape style, RenderDirection direction)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3A903AC", Offset = "0x3A903AC", VA = "0x3A903AC", Slot = "10")]
	public void RenderHeatmap()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3A90A04", Offset = "0x3A90A04", VA = "0x3A90A04")]
	private void CreatePoints()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x3A91C14", Offset = "0x3A91C14", VA = "0x3A91C14")]
	private void RenderSubmap(GameObject go, List<HeatPoint> submap)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3A969D8", Offset = "0x3A969D8", VA = "0x3A969D8")]
	private Color32[] AddColorsToMesh(int count, HeatPoint pt)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3A92DAC", Offset = "0x3A92DAC", VA = "0x3A92DAC")]
	private Vector3[] AddCubeVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3A93554", Offset = "0x3A93554", VA = "0x3A93554")]
	private int[] AddCubeTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3A93730", Offset = "0x3A93730", VA = "0x3A93730")]
	private Vector3[] AddArrowVectorsToMesh(Vector3 position, Vector3 rotation)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3A93F64", Offset = "0x3A93F64", VA = "0x3A93F64")]
	private int[] AddArrowTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3A94140", Offset = "0x3A94140", VA = "0x3A94140")]
	private Vector3[] AddSquareVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3A94920", Offset = "0x3A94920", VA = "0x3A94920")]
	private int[] AddSquareTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3A94B6C", Offset = "0x3A94B6C", VA = "0x3A94B6C")]
	private Vector3[] AddTriVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3A95164", Offset = "0x3A95164", VA = "0x3A95164")]
	private int[] AddTriTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3A952D0", Offset = "0x3A952D0", VA = "0x3A952D0")]
	private Vector3[] AddP2PVectorsToMesh(Vector3 fromVector, Vector3 toVector)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3A961E4", Offset = "0x3A961E4", VA = "0x3A961E4")]
	private int[] AddP2PTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3A91A20", Offset = "0x3A91A20", VA = "0x3A91A20")]
	private bool hasData()
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3A91AFC", Offset = "0x3A91AFC", VA = "0x3A91AFC")]
	private int GetVecticesForShape()
	{
		return default(int);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3A96C74", Offset = "0x3A96C74", VA = "0x3A96C74")]
	private int GetTrianglesForShape()
	{
		return default(int);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3A96D8C", Offset = "0x3A96D8C", VA = "0x3A96D8C")]
	private Color PickGradientColor(float percent)
	{
		return default(Color);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3A8F4B4", Offset = "0x3A8F4B4", VA = "0x3A8F4B4")]
	public static bool CompareGradients(Gradient gradient, Gradient otherGradient)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3A96DFC", Offset = "0x3A96DFC", VA = "0x3A96DFC")]
	public HeatmapMeshRenderer()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C6C8", Offset = "0x105C6C8")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C6C8", Offset = "0x105C6C8")]
[ExecuteInEditMode]
public class HeatmapSubmap : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<HeatPoint> m_PointData;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int m_TrianglesPerShape;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3A97010", Offset = "0x3A97010", VA = "0x3A97010")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3A97148", Offset = "0x3A97148", VA = "0x3A97148")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private static AndroidJavaClass m_deviceStatusInterfaceClass;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3AB1EA0", Offset = "0x3AB1EA0", VA = "0x3AB1EA0")]
	public static double Uptime()
	{
		return default(double);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3AB2070", Offset = "0x3AB2070", VA = "0x3AB2070")]
	public static void InitMach()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3AB2080", Offset = "0x3AB2080", VA = "0x3AB2080")]
	public MachBinding()
	{
	}
}
[Token(Token = "0x2000007")]
public class MachTest : MonoBehaviour
{
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3AB2170", Offset = "0x3AB2170", VA = "0x3AB2170")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x3AB2254", Offset = "0x3AB2254", VA = "0x3AB2254")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x3AB2508", Offset = "0x3AB2508", VA = "0x3AB2508")]
	public static double GetDeviceUptime()
	{
		return default(double);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3AB251C", Offset = "0x3AB251C", VA = "0x3AB251C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3AB254C", Offset = "0x3AB254C", VA = "0x3AB254C")]
	public MachTest()
	{
	}
}
[Token(Token = "0x2000008")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F16BC")]
	public GameObject target;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float elapsedTime;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x44D875C", Offset = "0x44D875C", VA = "0x44D875C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x44D8B74", Offset = "0x44D8B74", VA = "0x44D8B74")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000009")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3AAB678", Offset = "0x3AAB678", VA = "0x3AAB678")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3AAB71C", Offset = "0x3AAB71C", VA = "0x3AAB71C")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000A")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4B")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3AAE6A0", Offset = "0x3AAE6A0", VA = "0x3AAE6A0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3AAE840", Offset = "0x3AAE840", VA = "0x3AAE840")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3AAF264", Offset = "0x3AAF264", VA = "0x3AAF264")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x200000B")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3AACB84", Offset = "0x3AACB84", VA = "0x3AACB84")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3AACC28", Offset = "0x3AACC28", VA = "0x3AACC28")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105E974", Offset = "0x105E974")]
	private sealed class <largeNumber>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF53")]
		private int <>1__state;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private object <>2__current;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F16DC")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x3AAC278", Offset = "0x3AAC278", VA = "0x3AAC278", Slot = "4")]
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
			[Address(RVA = "0x3AAC348", Offset = "0x3AAC348", VA = "0x3AAC348", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x3AABD2C", Offset = "0x3AABD2C", VA = "0x3AABD2C")]
		[DebuggerHidden]
		public <largeNumber>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x3AABED0", Offset = "0x3AABED0", VA = "0x3AABED0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x3AABEE4", Offset = "0x3AABEE4", VA = "0x3AABEE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x3AAC2A8", Offset = "0x3AAC2A8", VA = "0x3AAC2A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F16CC")]
	public GameObject prefab;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MB3_MeshBaker mbd;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private GameObject[] objs;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3AAB74C", Offset = "0x3AAB74C", VA = "0x3AAB74C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3AABC70", Offset = "0x3AABC70", VA = "0x3AABC70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106A900", Offset = "0x106A900")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3AABD74", Offset = "0x3AABD74", VA = "0x3AABD74")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3AABE18", Offset = "0x3AABE18", VA = "0x3AABE18")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3AAC378", Offset = "0x3AAC378", VA = "0x3AAC378")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3AAC424", Offset = "0x3AAC424", VA = "0x3AAC424")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3AAC568", Offset = "0x3AAC568", VA = "0x3AAC568")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x3AAC60C", Offset = "0x3AAC60C", VA = "0x3AAC60C")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x200000E")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int axis;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x3AAC63C", Offset = "0x3AAC63C", VA = "0x3AAC63C")]
	private void Update()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3AAC808", Offset = "0x3AAC808", VA = "0x3AAC808")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000F")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3AAC838", Offset = "0x3AAC838", VA = "0x3AAC838")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3AAC8DC", Offset = "0x3AAC8DC", VA = "0x3AAC8DC")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x2000010")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF5B")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F16EC")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF63")]
	private GameObject swordInstance;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private GameObject glassesInstance;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F16FC")]
	private GameObject hatInstance;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3AACC58", Offset = "0x3AACC58", VA = "0x3AACC58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3AACF3C", Offset = "0x3AACF3C", VA = "0x3AACF3C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x3AAE3C8", Offset = "0x3AAE3C8", VA = "0x3AAE3C8")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x3AAE670", Offset = "0x3AAE670", VA = "0x3AAE670")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<MB_MaterialAndUVRect> mat2rect_map;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string[] texPropertyNames;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3AAA614", Offset = "0x3AAA614", VA = "0x3AAA614")]
	public MB_AtlasesAndRects()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class MB_MultiMaterial
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF6B")]
	public Material combinedMaterial;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public List<Material> sourceMaterials;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x3A984B4", Offset = "0x3A984B4", VA = "0x3A984B4")]
	public MB_MultiMaterial()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class MB_MaterialAndUVRect
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F170C")]
	public Material material;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect atlasRect;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect atlasSubrectMaterialOnly;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3A9824C", Offset = "0x3A9824C", VA = "0x3A9824C")]
	public MB_MaterialAndUVRect(Material m, Rect destRect, Rect matTilingTransformRect)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3AAC90C", Offset = "0x3AAC90C", VA = "0x3AAC90C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3AAC980", Offset = "0x3AAC980", VA = "0x3AAC980", Slot = "0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private MB2_TextureBakeResults tbr;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F172C")]
		private int[] numTimesMatAppearsInAtlas;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MB_MaterialAndUVRect[] matsAndSrcUVRect;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x3A99054", Offset = "0x3A99054", VA = "0x3A99054")]
		public Material2AtlasRectangleMapper(MB2_TextureBakeResults res)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x3A99840", Offset = "0x3A99840", VA = "0x3A99840")]
		public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, MB3_MeshCombinerSingle.MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out Rect rectInAtlas, out Rect subrectInAtlasMatTiling, ref string errorMsg)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_AtlasesAndRects[] combinedMaterialInfo;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF73")]
	public Material[] materials;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Rect[] prefabUVRects;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F171C")]
	public MB_MaterialAndUVRect[] materialsAndUVRects;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material resultMaterial;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool doMultiMaterial;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF7B")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3A97178", Offset = "0x3A97178", VA = "0x3A97178")]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(Renderer r)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3A9856C", Offset = "0x3A9856C", VA = "0x3A9856C")]
	public bool ContainsMaterial(Material m)
	{
		return default(bool);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3A98924", Offset = "0x3A98924", VA = "0x3A98924")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x3A99024", Offset = "0x3A99024", VA = "0x3A99024")]
	public MB2_TextureBakeResults()
	{
	}
}
[Token(Token = "0x2000015")]
public class MB2_UpdateSkinnedMeshBoundsFromBones : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Transform[] bones;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x3A9A5F8", Offset = "0x3A9A5F8", VA = "0x3A9A5F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x3A9A860", Offset = "0x3A9A860", VA = "0x3A9A860")]
	private void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3A9A9A0", Offset = "0x3A9A9A0", VA = "0x3A9A9A0")]
	public MB2_UpdateSkinnedMeshBoundsFromBones()
	{
	}
}
[Token(Token = "0x2000016")]
public class MB2_UpdateSkinnedMeshBoundsFromBounds : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF83")]
	public List<GameObject> objects;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x3A9A9D0", Offset = "0x3A9A9D0", VA = "0x3A9A9D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x3A9B024", Offset = "0x3A9B024", VA = "0x3A9B024")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x3A9B190", Offset = "0x3A9B190", VA = "0x3A9B190")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject sourcePrefab;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject resultPrefab;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x3A9D2D0", Offset = "0x3A9D2D0", VA = "0x3A9D2D0")]
		public MB3_PrefabBakerRow()
		{
		}
	}

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F173C")]
	public MB3_PrefabBakerRow[] prefabRows;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string outputPrefabFolder;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x3A9D2A0", Offset = "0x3A9D2A0", VA = "0x3A9D2A0")]
	public MB3_BatchPrefabBaker()
	{
	}
}
[Token(Token = "0x2000018")]
public class MB3_BoneWeightCopier : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8B")]
	public GameObject inputGameObject;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public GameObject outputPrefab;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F174C")]
	public float radius;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public SkinnedMeshRenderer seamMesh;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string outputFolder;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3A9D300", Offset = "0x3A9D300", VA = "0x3A9D300")]
	public MB3_BoneWeightCopier()
	{
	}
}
[Token(Token = "0x2000019")]
public class MB3_DisableHiddenAnimations : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<Animation> animationsToCull;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x3A9D348", Offset = "0x3A9D348", VA = "0x3A9D348")]
	private void Start()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3A9D53C", Offset = "0x3A9D53C", VA = "0x3A9D53C")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x3A9D75C", Offset = "0x3A9D75C", VA = "0x3A9D75C")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3A9D97C", Offset = "0x3A9D97C", VA = "0x3A9D97C")]
	public MB3_DisableHiddenAnimations()
	{
	}
}
[Token(Token = "0x200001A")]
public class MB3_MeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF93")]
	[SerializeField]
	protected MB3_MeshCombinerSingle _meshCombiner;

	[Token(Token = "0x17000006")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3A9DA34", Offset = "0x3A9DA34", VA = "0x3A9DA34", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x3A9DA64", Offset = "0x3A9DA64", VA = "0x3A9DA64")]
	public void BuildSceneMeshObject()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x3A9DAC8", Offset = "0x3A9DAC8", VA = "0x3A9DAC8", Slot = "23")]
	public virtual bool ShowHide(GameObject[] gos, GameObject[] deleteGOs)
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3A9DB4C", Offset = "0x3A9DB4C", VA = "0x3A9DB4C", Slot = "24")]
	public virtual void ApplyShowHide()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3A9DB94", Offset = "0x3A9DB94", VA = "0x3A9DB94", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x3A9DCE0", Offset = "0x3A9DCE0", VA = "0x3A9DCE0", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x3A9DE2C", Offset = "0x3A9DE2C", VA = "0x3A9DE2C")]
	public MB3_MeshBaker()
	{
	}
}
[Token(Token = "0x200001B")]
public abstract class MB3_MeshBakerCommon : MB3_MeshBakerRoot
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F175C")]
	public bool useObjsToMeshFromTexBaker;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool clearBuffersAfterBake;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string bakeAssetsInPlaceFolderPath;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
		[Address(RVA = "0x3A9DF30", Offset = "0x3A9DF30", VA = "0x3A9DF30", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3A9DF88", Offset = "0x3A9DF88", VA = "0x3A9DF88", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3A9DFE8", Offset = "0x3A9DFE8", VA = "0x3A9DFE8", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3A9E3F4", Offset = "0x3A9E3F4", VA = "0x3A9E3F4")]
	public void EnableDisableSourceObjectRenderers(bool show)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x3A9E6F8", Offset = "0x3A9E6F8", VA = "0x3A9E6F8", Slot = "8")]
	public virtual void ClearMesh()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3A9E748", Offset = "0x3A9E748", VA = "0x3A9E748", Slot = "9")]
	public virtual void DestroyMesh()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3A9E798", Offset = "0x3A9E798", VA = "0x3A9E798", Slot = "10")]
	public virtual void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3A9E7F8", Offset = "0x3A9E7F8", VA = "0x3A9E7F8", Slot = "11")]
	public virtual int GetNumObjectsInCombined()
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3A9E850", Offset = "0x3A9E850", VA = "0x3A9E850", Slot = "12")]
	public virtual int GetNumVerticesFor(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3A9E8B8", Offset = "0x3A9E8B8", VA = "0x3A9E8B8")]
	public MB3_TextureBaker GetTextureBaker()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	[Token(Token = "0x600007C")]
	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true);

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x3A9EB2C", Offset = "0x3A9EB2C", VA = "0x3A9EB2C", Slot = "15")]
	public virtual void Apply([Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x3A9EC34", Offset = "0x3A9EC34", VA = "0x3A9EC34", Slot = "16")]
	public virtual void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3A9EEE4", Offset = "0x3A9EEE4", VA = "0x3A9EEE4", Slot = "17")]
	public virtual bool CombinedMeshContains(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x3A9EF60", Offset = "0x3A9EF60", VA = "0x3A9EF60", Slot = "18")]
	public virtual void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV1 = false, bool updateUV2 = false, bool updateColors = false, bool updateSkinningInfo = false)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x3A9F1E0", Offset = "0x3A9F1E0", VA = "0x3A9F1E0", Slot = "19")]
	public virtual void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3A9F258", Offset = "0x3A9F258", VA = "0x3A9F258", Slot = "20")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3A9F2D0", Offset = "0x3A9F2D0", VA = "0x3A9F2D0", Slot = "21")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3A9F348", Offset = "0x3A9F348", VA = "0x3A9F348", Slot = "22")]
	protected virtual bool _ValidateForUpdateSkinnedMeshBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3A9DED4", Offset = "0x3A9DED4", VA = "0x3A9DED4")]
	protected MB3_MeshBakerCommon()
	{
	}
}
[Token(Token = "0x200001C")]
public class MB3_MeshBakerGrouper : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF9B")]
	public MB3_MeshBakerGrouperCore grouper;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[HideInInspector]
	public Bounds sourceObjectBounds;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3A9F804", Offset = "0x3A9F804", VA = "0x3A9F804")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3AA15B4", Offset = "0x3AA15B4", VA = "0x3AA15B4")]
	public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x3AA1B28", Offset = "0x3AA1B28", VA = "0x3AA1B28")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F177C")]
		public ClusterType clusterType;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 origin;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 cellSize;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int pieNumSegments;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFAB")]
		public Vector3 pieAxis;

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x3AA2834", Offset = "0x3AA2834", VA = "0x3AA2834")]
		public Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x3AA33D0", Offset = "0x3AA33D0", VA = "0x3AA33D0")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsNone(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x3AA36DC", Offset = "0x3AA36DC", VA = "0x3AA36DC")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsGrid(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x3AA42C0", Offset = "0x3AA42C0", VA = "0x3AA42C0")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsPie(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x3AA5258", Offset = "0x3AA5258", VA = "0x3AA5258")]
		public ClusterGrouper()
		{
		}
	}

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F176C")]
	public ClusterGrouper clusterGrouper;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool clusterOnLMIndex;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x3AA1C70", Offset = "0x3AA1C70", VA = "0x3AA1C70")]
	public void DoClustering(MB3_TextureBaker tb)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3AA29D0", Offset = "0x3AA29D0", VA = "0x3AA29D0")]
	private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x3AA2D74", Offset = "0x3AA2D74", VA = "0x3AA2D74")]
	private void AddMeshBaker(MB3_TextureBaker tb, string key, List<Renderer> gaws)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x3AA33A0", Offset = "0x3AA33A0", VA = "0x3AA33A0")]
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
	[Address(RVA = "0x3AA5348", Offset = "0x3AA5348", VA = "0x3AA5348", Slot = "6")]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x3AA5364", Offset = "0x3AA5364", VA = "0x3AA5364")]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x3A9F7D4", Offset = "0x3A9F7D4", VA = "0x3A9F7D4")]
	protected MB3_MeshBakerRoot()
	{
	}
}
[Token(Token = "0x200001F")]
public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected MB3_MultiMeshCombiner _meshCombiner;

	[Token(Token = "0x1700000A")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x3AA67F0", Offset = "0x3AA67F0", VA = "0x3AA67F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x3AA6820", Offset = "0x3AA6820", VA = "0x3AA6820", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x3AA6B00", Offset = "0x3AA6B00", VA = "0x3AA6B00", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x3AA6DE0", Offset = "0x3AA6DE0", VA = "0x3AA6DE0")]
	public MB3_MultiMeshBaker()
	{
	}
}
[Token(Token = "0x2000020")]
public class MB3_TextureBaker : MB3_MeshBakerRoot
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F178C")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected MB2_TextureBakeResults _textureBakeResults;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected int _atlasPadding;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected int _maxAtlasSize;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFB3")]
	[SerializeField]
	protected bool _resizePowerOfTwoTextures;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F179C")]
	[SerializeField]
	protected int _maxTilingBakeSize;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected List<ShaderTextureProperty> _customShaderProperties;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFBB")]
	[SerializeField]
	protected List<string> _customShaderPropNames_Depricated;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected bool _doMultiMaterial;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F17AC")]
	[SerializeField]
	protected Material _resultMaterial;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected bool _considerNonTextureProperties;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x1700000B")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x3AA6E88", Offset = "0x3AA6E88", VA = "0x3AA6E88", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3AA6EB8", Offset = "0x3AA6EB8", VA = "0x3AA6EB8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public virtual int atlasPadding
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x3AA6EF0", Offset = "0x3AA6EF0", VA = "0x3AA6EF0", Slot = "7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x3AA6F20", Offset = "0x3AA6F20", VA = "0x3AA6F20", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public virtual int maxAtlasSize
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3AA6F58", Offset = "0x3AA6F58", VA = "0x3AA6F58", Slot = "9")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x3AA6F88", Offset = "0x3AA6F88", VA = "0x3AA6F88", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual bool resizePowerOfTwoTextures
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3AA6FC0", Offset = "0x3AA6FC0", VA = "0x3AA6FC0", Slot = "11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x3AA7004", Offset = "0x3AA7004", VA = "0x3AA7004", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public virtual bool fixOutOfBoundsUVs
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x3AA7050", Offset = "0x3AA7050", VA = "0x3AA7050", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x3AA7094", Offset = "0x3AA7094", VA = "0x3AA7094", Slot = "14")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public virtual int maxTilingBakeSize
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3AA70E0", Offset = "0x3AA70E0", VA = "0x3AA70E0", Slot = "15")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x3AA7110", Offset = "0x3AA7110", VA = "0x3AA7110", Slot = "16")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x3AA7148", Offset = "0x3AA7148", VA = "0x3AA7148", Slot = "17")]
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x3AA7178", Offset = "0x3AA7178", VA = "0x3AA7178", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x3AA71B0", Offset = "0x3AA71B0", VA = "0x3AA71B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x3AA71F4", Offset = "0x3AA71F4", VA = "0x3AA71F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3AA7240", Offset = "0x3AA7240", VA = "0x3AA7240", Slot = "19")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3AA7270", Offset = "0x3AA7270", VA = "0x3AA7270", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public virtual List<string> customShaderPropNames
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x3AA72A8", Offset = "0x3AA72A8", VA = "0x3AA72A8", Slot = "21")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3AA72D8", Offset = "0x3AA72D8", VA = "0x3AA72D8", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public virtual bool doMultiMaterial
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3AA7310", Offset = "0x3AA7310", VA = "0x3AA7310", Slot = "23")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3AA7354", Offset = "0x3AA7354", VA = "0x3AA7354", Slot = "24")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public virtual Material resultMaterial
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3AA73A0", Offset = "0x3AA73A0", VA = "0x3AA73A0", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3AA73D0", Offset = "0x3AA73D0", VA = "0x3AA73D0", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool considerNonTextureProperties
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3AA7408", Offset = "0x3AA7408", VA = "0x3AA7408")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3AA744C", Offset = "0x3AA744C", VA = "0x3AA744C")]
		set
		{
		}
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x3AA7498", Offset = "0x3AA7498", VA = "0x3AA7498", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x3AA757C", Offset = "0x3AA757C", VA = "0x3AA757C")]
	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x3AA75C8", Offset = "0x3AA75C8", VA = "0x3AA75C8")]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x3AA7D48", Offset = "0x3AA7D48", VA = "0x3AA7D48")]
	private MB_AtlasesAndRects[] _CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x3AAA644", Offset = "0x3AAA644", VA = "0x3AAA644")]
	private void unpackMat2RectMap(MB2_TextureBakeResults tbr)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x3AAAAC0", Offset = "0x3AAAAC0", VA = "0x3AAAAC0")]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x3AAB080", Offset = "0x3AAB080", VA = "0x3AAB080")]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x3AA95A8", Offset = "0x3AA95A8", VA = "0x3AA95A8")]
	private bool _ValidateResultMaterials()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x3AAB4C8", Offset = "0x3AAB4C8", VA = "0x3AAB4C8")]
	public MB3_TextureBaker()
	{
	}
}
[Token(Token = "0x2000021")]
public class MB_TextureCombinerRenderTexture
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC3")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private Material mat;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F17BC")]
	private RenderTexture _destinationTexture;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Camera myCamera;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int _padding;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool _isNormalMap;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFCB")]
	private bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private bool _considerNonTextureProperties;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F17CC")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Rect[] rs;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<MB3_TextureCombiner.MB_TexSet> textureSets;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int indexOfTexSetToRender;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFD3")]
	private ShaderTextureProperty _texPropertyName;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private TextureBlender _resultMaterialTextureBlender;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F17DC")]
	private Texture2D targTex;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MB3_TextureCombiner combiner;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x3A9B43C", Offset = "0x3A9B43C", VA = "0x3A9B43C")]
	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB3_TextureCombiner.MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, TextureBlender resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x3A9BD74", Offset = "0x3A9BD74", VA = "0x3A9BD74")]
	public void OnRenderObject()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x3AB1AE0", Offset = "0x3AB1AE0", VA = "0x3AB1AE0")]
	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x3AB1A28", Offset = "0x3AB1A28", VA = "0x3AB1A28")]
	private bool IsOpenGL()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x3AAF964", Offset = "0x3AAF964", VA = "0x3AAF964")]
	private void CopyScaledAndTiledToAtlas(MB3_TextureCombiner.MB_TexSet texSet, MB3_TextureCombiner.MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, TextureBlender resultMatTexBlender)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x3AAF294", Offset = "0x3AAF294", VA = "0x3AAF294")]
	private void _printTexture(Texture2D t)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3A9B3F8", Offset = "0x3A9B3F8", VA = "0x3A9B3F8")]
	public MB_TextureCombinerRenderTexture()
	{
	}
}
[Token(Token = "0x2000022")]
[ExecuteInEditMode]
public class MB3_AtlasPackerRenderTexture : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MB_TextureCombinerRenderTexture fastRenderer;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFDB")]
	public int width;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public int height;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F17EC")]
	public int padding;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isNormalMap;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool considerNonTextureProperties;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFE3")]
	public TextureBlender resultMaterialTextureBlender;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Rect[] rects;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F17FC")]
	public Texture2D tex1;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<MB3_TextureCombiner.MB_TexSet> textureSets;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int indexOfTexSetToRender;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ShaderTextureProperty texPropertyName;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFEB")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Texture2D testTex;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F180C")]
	public Material testMat;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3A9B1C0", Offset = "0x3A9B1C0", VA = "0x3A9B1C0")]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3A9BCF4", Offset = "0x3A9BCF4", VA = "0x3A9BCF4")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3A9D25C", Offset = "0x3A9D25C", VA = "0x3A9D25C")]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
[Token(Token = "0x2000023")]
public class BulletHole : MonoBehaviour
{
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105E9B0", Offset = "0x105E9B0")]
	private sealed class <DestroyDelayed>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF3")]
		public BulletHole <>4__this;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x44D8FA0", Offset = "0x44D8FA0", VA = "0x44D8FA0", Slot = "4")]
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
			[Address(RVA = "0x44D9070", Offset = "0x44D9070", VA = "0x44D9070", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x44D8CA8", Offset = "0x44D8CA8", VA = "0x44D8CA8")]
		[DebuggerHidden]
		public <DestroyDelayed>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x44D8D34", Offset = "0x44D8D34", VA = "0x44D8D34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x44D8D48", Offset = "0x44D8D48", VA = "0x44D8D48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x44D8FD0", Offset = "0x44D8FD0", VA = "0x44D8FD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float lifeTime;

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x44D8BA4", Offset = "0x44D8BA4", VA = "0x44D8BA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x44D8BEC", Offset = "0x44D8BEC", VA = "0x44D8BEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106A9B0", Offset = "0x106A9B0")]
	private IEnumerator DestroyDelayed()
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x44D8CF0", Offset = "0x44D8CF0", VA = "0x44D8CF0")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Mode action;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55F181C")]
	public UnityEngine.Object target;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject source;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int triggerCount;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool repeatTrigger;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x44D809C", Offset = "0x44D809C", VA = "0x44D809C")]
	private void DoActivateTrigger()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x44D86D0", Offset = "0x44D86D0", VA = "0x44D86D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x44D8704", Offset = "0x44D8704", VA = "0x44D8704")]
	public ActivateTrigger()
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C81C", Offset = "0x105C81C")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x527F27C", Offset = "0x527F27C", VA = "0x527F27C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x527F2E4", Offset = "0x527F2E4", VA = "0x527F2E4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x527F384", Offset = "0x527F384", VA = "0x527F384")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x527F424", Offset = "0x527F424", VA = "0x527F424")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C8E8", Offset = "0x105C8E8")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x527F454", Offset = "0x527F454", VA = "0x527F454")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MeshContainer
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Mesh mesh;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F183C")]
		public Vector3[] vertices;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3[] normals;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x527F484", Offset = "0x527F484", VA = "0x527F484")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x527F528", Offset = "0x527F528", VA = "0x527F528")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105C9B4", Offset = "0x105C9B4")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool reflectSkybox;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100B")]
		public Color clearColor;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public string reflectionSampler;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F184C")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1013")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x527F5B0", Offset = "0x527F5B0", VA = "0x527F5B0")]
		public void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x527F74C", Offset = "0x527F74C", VA = "0x527F74C")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x527FDA0", Offset = "0x527FDA0", VA = "0x527FDA0")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x527FEE8", Offset = "0x527FEE8", VA = "0x527FEE8")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x52800B8", Offset = "0x52800B8", VA = "0x52800B8")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x528163C", Offset = "0x528163C", VA = "0x528163C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x52816F8", Offset = "0x52816F8", VA = "0x52816F8")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5281914", Offset = "0x5281914", VA = "0x5281914")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x52819B4", Offset = "0x52819B4", VA = "0x52819B4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x52803E0", Offset = "0x52803E0", VA = "0x52803E0")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5281A54", Offset = "0x5281A54", VA = "0x5281A54")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x52823F4", Offset = "0x52823F4", VA = "0x52823F4")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5281B30", Offset = "0x5281B30", VA = "0x5281B30")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x52827F8", Offset = "0x52827F8", VA = "0x52827F8")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5281FC4", Offset = "0x5281FC4", VA = "0x5281FC4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5282880", Offset = "0x5282880", VA = "0x5282880")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CA80", Offset = "0x105CA80")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform specularLight;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F185C")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x528293C", Offset = "0x528293C", VA = "0x528293C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5282AD0", Offset = "0x5282AD0", VA = "0x5282AD0")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5282EC0", Offset = "0x5282EC0", VA = "0x5282EC0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool disablePixelLights;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int textureSize;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101B")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F186C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1023")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F187C")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5282EF0", Offset = "0x5282EF0", VA = "0x5282EF0")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x5286AF8", Offset = "0x5286AF8", VA = "0x5286AF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5285B60", Offset = "0x5285B60", VA = "0x5285B60")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x528490C", Offset = "0x528490C", VA = "0x528490C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5284888", Offset = "0x5284888", VA = "0x5284888")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x5284588", Offset = "0x5284588", VA = "0x5284588")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x52866C8", Offset = "0x52866C8", VA = "0x52866C8")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5286168", Offset = "0x5286168", VA = "0x5286168")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x528740C", Offset = "0x528740C", VA = "0x528740C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Material sharedMaterial;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F189C")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool edgeBlend;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5287620", Offset = "0x5287620", VA = "0x5287620")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5287968", Offset = "0x5287968", VA = "0x5287968")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5287AE8", Offset = "0x5287AE8", VA = "0x5287AE8")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5287C00", Offset = "0x5287C00", VA = "0x5287C00")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WaterBase waterBase;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5287C5C", Offset = "0x5287C5C", VA = "0x5287C5C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5287C8C", Offset = "0x5287C8C", VA = "0x5287C8C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x52880D8", Offset = "0x52880D8", VA = "0x52880D8")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5288304", Offset = "0x5288304", VA = "0x5288304")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x103B")]
		public Transform target;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rotationSpace;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F18AC")]
		public UpdateMode updateMode;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool lockCursor;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool smoothFollow;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float followSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1043")]
		public float distance;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float minDistance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F18BC")]
		public float maxDistance;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSpeed;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSensitivity;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotationSensitivity;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104B")]
		public float yMinLimit;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float yMaxLimit;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F18CC")]
		public Vector3 offset;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateAlways;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1053")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105F1F8", Offset = "0x105F1F8")]
		private float <x>k__BackingField;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F18DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105F234", Offset = "0x105F234")]
		private float <y>k__BackingField;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105F270", Offset = "0x105F270")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 position;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105B")]
		private Quaternion rotation;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F18EC")]
		private Camera cam;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion r;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastUp;

		[Token(Token = "0x17000018")]
		public float x
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x381A98C", Offset = "0x381A98C", VA = "0x381A98C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106AA60", Offset = "0x106AA60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x381A9BC", Offset = "0x381A9BC", VA = "0x381A9BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106AA9C", Offset = "0x106AA9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float y
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x381A9F4", Offset = "0x381A9F4", VA = "0x381A9F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106AAD8", Offset = "0x106AAD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x381AA24", Offset = "0x381AA24", VA = "0x381AA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106AB14", Offset = "0x106AB14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float distanceTarget
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x381AA5C", Offset = "0x381AA5C", VA = "0x381AA5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106AB50", Offset = "0x106AB50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x381AA8C", Offset = "0x381AA8C", VA = "0x381AA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106AB8C", Offset = "0x106AB8C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		private float zoomAdd
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x381B640", Offset = "0x381B640", VA = "0x381B640")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x381AAC4", Offset = "0x381AAC4", VA = "0x381AAC4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x381ADF8", Offset = "0x381ADF8", VA = "0x381ADF8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x381AE8C", Offset = "0x381AE8C", VA = "0x381AE8C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x381AEEC", Offset = "0x381AEEC", VA = "0x381AEEC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x381AF58", Offset = "0x381AF58", VA = "0x381AF58")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x381AE48", Offset = "0x381AE48", VA = "0x381AE48")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x381B76C", Offset = "0x381B76C", VA = "0x381B76C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x381B484", Offset = "0x381B484", VA = "0x381B484")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x381C268", Offset = "0x381C268", VA = "0x381C268")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float yMinLimit;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float yMaxLimit;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106B")]
		private float x;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float y;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x381C474", Offset = "0x381C474", VA = "0x381C474")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x381C53C", Offset = "0x381C53C", VA = "0x381C53C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x381C88C", Offset = "0x381C88C", VA = "0x381C88C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x381CA48", Offset = "0x381CA48", VA = "0x381CA48")]
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
		[Address(RVA = "0x3AB257C", Offset = "0x3AB257C", VA = "0x3AB257C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x3AB273C", Offset = "0x3AB273C", VA = "0x3AB273C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x3AB2964", Offset = "0x3AB2964", VA = "0x3AB2964")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x3AB2D74", Offset = "0x3AB2D74", VA = "0x3AB2D74")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x3AB2BF4", Offset = "0x3AB2BF4", VA = "0x3AB2BF4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x3AB3004", Offset = "0x3AB3004", VA = "0x3AB3004")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x3AB35D4", Offset = "0x3AB35D4", VA = "0x3AB35D4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x107B")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x3AB3A68", Offset = "0x3AB3A68", VA = "0x3AB3A68")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1073")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F191C")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700001C")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x3AB3694", Offset = "0x3AB3694", VA = "0x3AB3694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x3AB3B60", Offset = "0x3AB3B60", VA = "0x3AB3B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x3AB3604", Offset = "0x3AB3604", VA = "0x3AB3604")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeLeft;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F192C")]
		public static string[] typeRight;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeSpine;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeHead;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeArm;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1083")]
		public static string[] typeLeg;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeTail;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F193C")]
		public static string[] typeEye;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExclude;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108B")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F194C")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] pelvis;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] hand;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1093")]
		public static string[] foot;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x3AB3F34", Offset = "0x3AB3F34", VA = "0x3AB3F34")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x3AB471C", Offset = "0x3AB471C", VA = "0x3AB471C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x3AB4C84", Offset = "0x3AB4C84", VA = "0x3AB4C84")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x3AB4DCC", Offset = "0x3AB4DCC", VA = "0x3AB4DCC")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x3AB4F60", Offset = "0x3AB4F60", VA = "0x3AB4F60")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x3AB42E0", Offset = "0x3AB42E0", VA = "0x3AB42E0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x3AB4AC8", Offset = "0x3AB4AC8", VA = "0x3AB4AC8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x3AB6758", Offset = "0x3AB6758", VA = "0x3AB6758")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x3AB61F0", Offset = "0x3AB61F0", VA = "0x3AB61F0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x3AB64A4", Offset = "0x3AB64A4", VA = "0x3AB64A4")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x3AB54E8", Offset = "0x3AB54E8", VA = "0x3AB54E8")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x3AB5714", Offset = "0x3AB5714", VA = "0x3AB5714")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x3AB5940", Offset = "0x3AB5940", VA = "0x3AB5940")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x3AB5B6C", Offset = "0x3AB5B6C", VA = "0x3AB5B6C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x3AB5D98", Offset = "0x3AB5D98", VA = "0x3AB5D98")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x3AB5FC4", Offset = "0x3AB5FC4", VA = "0x3AB5FC4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x3AB6C3C", Offset = "0x3AB6C3C", VA = "0x3AB6C3C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x3AB5278", Offset = "0x3AB5278", VA = "0x3AB5278")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x3AB6AE0", Offset = "0x3AB6AE0", VA = "0x3AB6AE0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x3AB6D60", Offset = "0x3AB6D60", VA = "0x3AB6D60")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x3AB6F70", Offset = "0x3AB6F70", VA = "0x3AB6F70")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x3AB69D4", Offset = "0x3AB69D4", VA = "0x3AB69D4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x3AB6890", Offset = "0x3AB6890", VA = "0x3AB6890")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10AB")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool includeEyes;

			[Token(Token = "0x170000B0")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x381A904", Offset = "0x381A904", VA = "0x381A904")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x381A88C", Offset = "0x381A88C", VA = "0x381A88C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform root;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F197C")]
		public Transform pelvis;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftThigh;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftCalf;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftFoot;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10AB")]
		public Transform rightThigh;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rightCalf;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F198C")]
		public Transform rightFoot;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftForearm;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftHand;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B3")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rightForearm;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F199C")]
		public Transform rightHand;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform head;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] spine;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] eyes;

		[Token(Token = "0x1700001E")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x3AB9224", Offset = "0x3AB9224", VA = "0x3AB9224", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public bool isEmpty
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x3AB9E94", Offset = "0x3AB9E94", VA = "0x3AB9E94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x3AB9EE8", Offset = "0x3AB9EE8", VA = "0x3AB9EE8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3ABAC20", Offset = "0x3ABAC20", VA = "0x3ABAC20", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x3ABBA70", Offset = "0x3ABBA70", VA = "0x3ABBA70")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3ABCBBC", Offset = "0x3ABCBBC", VA = "0x3ABCBBC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x3ABC11C", Offset = "0x3ABC11C", VA = "0x3ABC11C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x3ABE1C4", Offset = "0x3ABE1C4", VA = "0x3ABE1C4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x3ABE680", Offset = "0x3ABE680", VA = "0x3ABE680")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x3ABF90C", Offset = "0x3ABF90C", VA = "0x3ABF90C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x3ABF424", Offset = "0x3ABF424", VA = "0x3ABF424")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x3ABEF14", Offset = "0x3ABEF14", VA = "0x3ABEF14")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x3ABEB04", Offset = "0x3ABEB04", VA = "0x3ABEB04")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3ABF6FC", Offset = "0x3ABF6FC", VA = "0x3ABF6FC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3ABFB74", Offset = "0x3ABFB74", VA = "0x3ABFB74")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3AC1258", Offset = "0x3AC1258", VA = "0x3AC1258")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x3AC0544", Offset = "0x3AC0544", VA = "0x3AC0544")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x3AC16D0", Offset = "0x3AC16D0", VA = "0x3AC16D0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x3AC0DE8", Offset = "0x3AC0DE8", VA = "0x3AC0DE8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x3AC16F8", Offset = "0x3AC16F8", VA = "0x3AC16F8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x3AC1720", Offset = "0x3AC1720", VA = "0x3AC1720")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x3AC1AF4", Offset = "0x3AC1AF4", VA = "0x3AC1AF4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x3AC1F1C", Offset = "0x3AC1F1C", VA = "0x3AC1F1C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x3ABC054", Offset = "0x3ABC054", VA = "0x3ABC054")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F19AC")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x105F2AC", Offset = "0x105F2AC")]
		public string text;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x381CABC", Offset = "0x381CABC", VA = "0x381CABC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color color;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x381CAEC", Offset = "0x381CAEC", VA = "0x381CAEC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x381CC2C", Offset = "0x381CC2C", VA = "0x381CC2C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Hierarchy
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x526FDA0", Offset = "0x526FDA0", VA = "0x526FDA0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x52702F0", Offset = "0x52702F0", VA = "0x52702F0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x526FF0C", Offset = "0x526FF0C", VA = "0x526FF0C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x52705A8", Offset = "0x52705A8", VA = "0x52705A8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x5270880", Offset = "0x5270880", VA = "0x5270880")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5270DA0", Offset = "0x5270DA0", VA = "0x5270DA0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x5271058", Offset = "0x5271058", VA = "0x5271058")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x527146C", Offset = "0x527146C", VA = "0x527146C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x5271DFC", Offset = "0x5271DFC", VA = "0x5271DFC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x52718A0", Offset = "0x52718A0", VA = "0x52718A0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x5272278", Offset = "0x5272278", VA = "0x5272278")]
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
		[Address(RVA = "0x52722A8", Offset = "0x52722A8", VA = "0x52722A8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x5274FB8", Offset = "0x5274FB8", VA = "0x5274FB8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x52751A4", Offset = "0x52751A4", VA = "0x52751A4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x5272C4C", Offset = "0x5272C4C", VA = "0x5272C4C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5272CBC", Offset = "0x5272CBC", VA = "0x5272CBC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5272DDC", Offset = "0x5272DDC", VA = "0x5272DDC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5272F58", Offset = "0x5272F58", VA = "0x5272F58")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x5273038", Offset = "0x5273038", VA = "0x5273038")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x52730F4", Offset = "0x52730F4", VA = "0x52730F4")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x527319C", Offset = "0x527319C", VA = "0x527319C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x5273234", Offset = "0x5273234", VA = "0x5273234")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5273414", Offset = "0x5273414", VA = "0x5273414")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x52735B0", Offset = "0x52735B0", VA = "0x52735B0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x52736F4", Offset = "0x52736F4", VA = "0x52736F4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5275474", Offset = "0x5275474", VA = "0x5275474")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x5273850", Offset = "0x5273850", VA = "0x5273850")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x5273970", Offset = "0x5273970", VA = "0x5273970")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x5273AD0", Offset = "0x5273AD0", VA = "0x5273AD0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5273C2C", Offset = "0x5273C2C", VA = "0x5273C2C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x5273DD4", Offset = "0x5273DD4", VA = "0x5273DD4")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5273FC8", Offset = "0x5273FC8", VA = "0x5273FC8")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x52741BC", Offset = "0x52741BC", VA = "0x52741BC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5274374", Offset = "0x5274374", VA = "0x5274374")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x527452C", Offset = "0x527452C", VA = "0x527452C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x52746A4", Offset = "0x52746A4", VA = "0x52746A4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x5274800", Offset = "0x5274800", VA = "0x5274800")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x52755D0", Offset = "0x52755D0", VA = "0x52755D0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x52749A0", Offset = "0x52749A0", VA = "0x52749A0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x5274D68", Offset = "0x5274D68", VA = "0x5274D68")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5274E80", Offset = "0x5274E80", VA = "0x5274E80")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x52759A4", Offset = "0x52759A4", VA = "0x52759A4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string color;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x52759D4", Offset = "0x52759D4", VA = "0x52759D4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x5275A8C", Offset = "0x5275A8C", VA = "0x5275A8C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5275B4C", Offset = "0x5275B4C", VA = "0x5275B4C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x5275C8C", Offset = "0x5275C8C", VA = "0x5275C8C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5275F28", Offset = "0x5275F28", VA = "0x5275F28")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5275CE4", Offset = "0x5275CE4", VA = "0x5275CE4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5275F80", Offset = "0x5275F80", VA = "0x5275F80")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x52761AC", Offset = "0x52761AC", VA = "0x52761AC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5276260", Offset = "0x5276260", VA = "0x5276260")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x5276378", Offset = "0x5276378", VA = "0x5276378")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x52764EC", Offset = "0x52764EC", VA = "0x52764EC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5276764", Offset = "0x5276764", VA = "0x5276764")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5276980", Offset = "0x5276980", VA = "0x5276980")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5276A5C", Offset = "0x5276A5C", VA = "0x5276A5C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class QuaTools
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5276B04", Offset = "0x5276B04", VA = "0x5276B04")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5276CFC", Offset = "0x5276CFC", VA = "0x5276CFC")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5276EF4", Offset = "0x5276EF4", VA = "0x5276EF4")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5277238", Offset = "0x5277238", VA = "0x5277238")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x52773BC", Offset = "0x52773BC", VA = "0x52773BC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5277630", Offset = "0x5277630", VA = "0x5277630")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5277CC4", Offset = "0x5277CC4", VA = "0x5277CC4")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5278190", Offset = "0x5278190", VA = "0x5278190")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F2E8", Offset = "0x105F2E8")]
		public float timeStep;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10EB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F34C", Offset = "0x105F34C")]
		public bool fixTransforms;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float lastTime;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A0C")]
		private Animator animator;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animation legacy;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool componentInitiated;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F3")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x5278794", Offset = "0x5278794", VA = "0x5278794")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		private bool isAnimated
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x5278F24", Offset = "0x5278F24", VA = "0x5278F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x5278500", Offset = "0x5278500", VA = "0x5278500")]
		public void Disable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5278628", Offset = "0x5278628", VA = "0x5278628", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x527863C", Offset = "0x527863C", VA = "0x527863C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5278650", Offset = "0x5278650", VA = "0x5278650", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x5278664", Offset = "0x5278664", VA = "0x5278664")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x5278764", Offset = "0x5278764", VA = "0x5278764")]
		private void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x52786C0", Offset = "0x52786C0", VA = "0x52786C0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x5278E84", Offset = "0x5278E84", VA = "0x5278E84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5278A10", Offset = "0x5278A10", VA = "0x5278A10")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5279104", Offset = "0x5279104", VA = "0x5279104")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x52791BC", Offset = "0x52791BC", VA = "0x52791BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x527932C", Offset = "0x527932C", VA = "0x527932C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5279444", Offset = "0x5279444", VA = "0x5279444")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public GameObject target;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5279488", Offset = "0x5279488", VA = "0x5279488")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x52795F0", Offset = "0x52795F0", VA = "0x52795F0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x5279758", Offset = "0x5279758", VA = "0x5279758")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x52798C0", Offset = "0x52798C0", VA = "0x52798C0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class V3Tools
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x52798F0", Offset = "0x52798F0", VA = "0x52798F0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x5279AE4", Offset = "0x5279AE4", VA = "0x5279AE4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5279D14", Offset = "0x5279D14", VA = "0x5279D14")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x527A2D0", Offset = "0x527A2D0", VA = "0x527A2D0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x527A8A4", Offset = "0x527A8A4", VA = "0x527A8A4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A1C")]
		public static bool logged;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x527AC90", Offset = "0x527AC90", VA = "0x527AC90")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x527B1DC", Offset = "0x527B1DC", VA = "0x527B1DC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pin;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x381CC94", Offset = "0x381CC94", VA = "0x381CC94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x381CDC4", Offset = "0x381CDC4", VA = "0x381CDC4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F3B0", Offset = "0x105F3B0")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10FB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F414", Offset = "0x105F414")]
		public AimIK aim;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F478", Offset = "0x105F478")]
		public LookAtIK lookAt;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F4DC", Offset = "0x105F4DC")]
		public Animator animator;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F540", Offset = "0x105F540")]
		public float crossfadeTime;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F5A4", Offset = "0x105F5A4")]
		public float minAimDistance;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1103")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3843248", Offset = "0x3843248", VA = "0x3843248")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x38432C8", Offset = "0x38432C8", VA = "0x38432C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x38435BC", Offset = "0x38435BC", VA = "0x38435BC")]
		private void Pose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x3843A84", Offset = "0x3843A84", VA = "0x3843A84")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3843E5C", Offset = "0x3843E5C", VA = "0x3843E5C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3844030", Offset = "0x3844030", VA = "0x3844030")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public AimIK aimIK;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A3C")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float max;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110B")]
		public float lerpSpeed;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private RaycastHit hit;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A4C")]
		private Vector3 offset;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3845F58", Offset = "0x3845F58", VA = "0x3845F58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x38464D0", Offset = "0x38464D0", VA = "0x38464D0")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x38469D0", Offset = "0x38469D0", VA = "0x38469D0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1113")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float lookAtWeight;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A5C")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111B")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A6C")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float footPositionWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float footRotationWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1123")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A7C")]
		public float handPositionWeight;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float handRotationWeight;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x3820510", Offset = "0x3820510", VA = "0x3820510")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x382142C", Offset = "0x382142C", VA = "0x382142C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float scale;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112B")]
		public Transform body;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A8C")]
		public float legRotationWeight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float breatheSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1133")]
		public float breatheMagnitude;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float height;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1A9C")]
		public float minHeight;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastHeight;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastDistance;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x113B")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float sine;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1AAC")]
		private RaycastHit rootHit;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x3836CC8", Offset = "0x3836CC8", VA = "0x3836CC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x3838388", Offset = "0x3838388", VA = "0x3838388")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3837CEC", Offset = "0x3837CEC", VA = "0x3837CEC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x38386D4", Offset = "0x38386D4", VA = "0x38386D4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform cameraTransform;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float speed;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1143")]
		public float turnSpeed;

		[Token(Token = "0x17000023")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x38387D4", Offset = "0x38387D4", VA = "0x38387D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x38388D4", Offset = "0x38388D4", VA = "0x38388D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3838DC0", Offset = "0x3838DC0", VA = "0x3838DC0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105E9EC", Offset = "0x105E9EC")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x115B")]
			private object <>2__current;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1AEC")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x383AD7C", Offset = "0x383AD7C", VA = "0x383AD7C", Slot = "4")]
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
				[Address(RVA = "0x383AE4C", Offset = "0x383AE4C", VA = "0x383AE4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x383A274", Offset = "0x383A274", VA = "0x383A274")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x383A388", Offset = "0x383A388", VA = "0x383A388", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x383A39C", Offset = "0x383A39C", VA = "0x383A39C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x383ADAC", Offset = "0x383ADAC", VA = "0x383ADAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1ABC")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minDelay;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxOffset;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114B")]
		public float stepSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float footHeight;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1ACC")]
		public float velocityPrediction;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastFocus;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem sand;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1153")]
		private IK ik;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float stepProgress;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1ADC")]
		private float lastStepTime;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit hit;

		[Token(Token = "0x17000024")]
		public bool isStepping
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x3838E1C", Offset = "0x3838E1C", VA = "0x3838E1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 position
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x3838664", Offset = "0x3838664", VA = "0x3838664")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x3838E9C", Offset = "0x3838E9C", VA = "0x3838E9C")]
			set
			{
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x3838F2C", Offset = "0x3838F2C", VA = "0x3838F2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x38392B0", Offset = "0x38392B0", VA = "0x38392B0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3839BEC", Offset = "0x3839BEC", VA = "0x3839BEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x383A13C", Offset = "0x383A13C", VA = "0x383A13C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106AD6C", Offset = "0x106AD6C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x383A2BC", Offset = "0x383A2BC", VA = "0x383A2BC")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ParticleSystem particles;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x383AE7C", Offset = "0x383AE7C", VA = "0x383AE7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x383AFF0", Offset = "0x383AFF0", VA = "0x383AFF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x383B1A4", Offset = "0x383B1A4", VA = "0x383B1A4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067A98", Offset = "0x1067A98")]
			public int animationLayer;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067AFC", Offset = "0x1067AFC")]
			public string animationState;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x115B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067B60", Offset = "0x1067B60")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067BC4", Offset = "0x1067BC4")]
			public Transform warpFrom;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1AFC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067C28", Offset = "0x1067C28")]
			public Transform warpTo;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067C8C", Offset = "0x1067C8C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1163")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F608", Offset = "0x105F608")]
		public Animator animator;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F66C", Offset = "0x105F66C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1AFC")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x105F6D0", Offset = "0x105F6D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F6D0", Offset = "0x105F6D0")]
		public Warp[] warps;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private EffectorMode lastMode;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x381CDF4", Offset = "0x381CDF4", VA = "0x381CDF4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x381CE3C", Offset = "0x381CE3C", VA = "0x381CE3C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x381D380", Offset = "0x381D380", VA = "0x381D380", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x381DD98", Offset = "0x381DD98", VA = "0x381DD98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x381DF74", Offset = "0x381DF74", VA = "0x381DF74")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CC3C", Offset = "0x105CC3C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float rotateSpeed;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B1C")]
		public float blendSpeed;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxAngle;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float moveSpeed;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootMotionWeight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x117B")]
		protected Animator animator;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B2C")]
		protected Vector3 moveInput;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 velocity;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x381DFA4", Offset = "0x381DFA4", VA = "0x381DFA4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x381E030", Offset = "0x381E030", VA = "0x381E030")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x381E480", Offset = "0x381E480", VA = "0x381E480", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x381EB44", Offset = "0x381EB44", VA = "0x381EB44")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CCEC", Offset = "0x105CCEC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CCEC", Offset = "0x105CCEC")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool useIK;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105F79C", Offset = "0x105F79C")]
		public float headLookWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1183")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B3C")]
		private AimIK aim;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118B")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 aimTarget;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x381EBD0", Offset = "0x381EBD0", VA = "0x381EBD0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x381EC74", Offset = "0x381EC74", VA = "0x381EC74", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x381EE80", Offset = "0x381EE80", VA = "0x381EE80", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x381F0A0", Offset = "0x381F0A0", VA = "0x381F0A0")]
		private void Read()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x381F390", Offset = "0x381F390", VA = "0x381F390")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x381F444", Offset = "0x381F444", VA = "0x381F444")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x381FCE0", Offset = "0x381FCE0", VA = "0x381FCE0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x3820154", Offset = "0x3820154", VA = "0x3820154")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CDE8", Offset = "0x105CDE8")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B4C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x382327C", Offset = "0x382327C", VA = "0x382327C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x382331C", Offset = "0x382331C", VA = "0x382331C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x38237F8", Offset = "0x38237F8", VA = "0x38237F8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x3823BAC", Offset = "0x3823BAC", VA = "0x3823BAC")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CE98", Offset = "0x105CE98")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000026")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x38257DC", Offset = "0x38257DC", VA = "0x38257DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x38258D8", Offset = "0x38258D8", VA = "0x38258D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x3825214", Offset = "0x3825214", VA = "0x3825214")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x38252D8", Offset = "0x38252D8", VA = "0x38252D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x38259D4", Offset = "0x38259D4", VA = "0x38259D4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105F820", Offset = "0x105F820")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1193")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B5C")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119B")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B6C")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x382B4DC", Offset = "0x382B4DC", VA = "0x382B4DC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x382C580", Offset = "0x382C580", VA = "0x382C580")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float forceMlp;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float upForce;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A3")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B7C")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve scale;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultScale;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11AB")]
		private Rigidbody r;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x382C5B0", Offset = "0x382C5B0", VA = "0x382C5B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x382C6C8", Offset = "0x382C6C8", VA = "0x382C6C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x382D138", Offset = "0x382D138", VA = "0x382D138")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x382D2C8", Offset = "0x382D2C8", VA = "0x382D2C8")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11BB")]
			public float mappingWeight;

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x382D778", Offset = "0x382D778", VA = "0x382D778")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x382DA38", Offset = "0x382DA38", VA = "0x382DA38")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B8C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool disableAfterStart;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb leftArm;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb rightArm;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11B3")]
		public Limb leftLeg;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Limb rightLeg;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1B9C")]
		public float rootPin;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x382D3D4", Offset = "0x382D3D4", VA = "0x382D3D4")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x382D88C", Offset = "0x382D88C", VA = "0x382D88C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x382D9C4", Offset = "0x382D9C4", VA = "0x382D9C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x382D9F4", Offset = "0x382D9F4", VA = "0x382D9F4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1BAC")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x382DA7C", Offset = "0x382DA7C", VA = "0x382DA7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x382DB74", Offset = "0x382DB74", VA = "0x382DB74")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x382DD64", Offset = "0x382DD64", VA = "0x382DD64")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F868", Offset = "0x105F868")]
		public Transform target;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F8CC", Offset = "0x105F8CC")]
		public Transform pin;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F930", Offset = "0x105F930")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F994", Offset = "0x105F994")]
		public AimIK aim;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1BBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105F9F8", Offset = "0x105F9F8")]
		public float weight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105FA5C", Offset = "0x105FA5C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105FAC0", Offset = "0x105FAC0")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x382DD94", Offset = "0x382DD94", VA = "0x382DD94")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x382DE20", Offset = "0x382DE20", VA = "0x382DE20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x382E29C", Offset = "0x382E29C", VA = "0x382E29C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11CB")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool leftHanded;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x382E2CC", Offset = "0x382E2CC", VA = "0x382E2CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x382E3FC", Offset = "0x382E3FC", VA = "0x382E3FC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x382E550", Offset = "0x382E550", VA = "0x382E550")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x382F264", Offset = "0x382F264", VA = "0x382F264")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x382F444", Offset = "0x382F444", VA = "0x382F444")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1BCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105FB24", Offset = "0x105FB24")]
		public float aimWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105FB6C", Offset = "0x105FB6C")]
		public float sightWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105FBB4", Offset = "0x105FBB4")]
		public float maxAngle;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D3")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1BDC")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11DB")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1BEC")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recoil recoil;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105FD64", Offset = "0x105FD64")]
		public float cameraRecoilWeight;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x382F474", Offset = "0x382F474", VA = "0x382F474")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x382F7C4", Offset = "0x382F7C4", VA = "0x382F7C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x382F7F4", Offset = "0x382F7F4", VA = "0x382F7F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x382FFB0", Offset = "0x382FFB0", VA = "0x382FFB0")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x3830308", Offset = "0x3830308", VA = "0x3830308")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x382F9DC", Offset = "0x382F9DC", VA = "0x382F9DC")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x3831BAC", Offset = "0x3831BAC", VA = "0x3831BAC")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CF48", Offset = "0x105CF48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105CF48", Offset = "0x105CF48")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E3")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x105FDAC", Offset = "0x105FDAC")]
		public float walkSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float sVel;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1BFC")]
		private Animator animator;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3831C30", Offset = "0x3831C30", VA = "0x3831C30")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x3831CE8", Offset = "0x3831CE8", VA = "0x3831CE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3832068", Offset = "0x3832068", VA = "0x3832068")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x383225C", Offset = "0x383225C", VA = "0x383225C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11EB")]
		private string colliderName;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x3833428", Offset = "0x3833428", VA = "0x3833428")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x3833718", Offset = "0x3833718", VA = "0x3833718")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x3833860", Offset = "0x3833860", VA = "0x3833860")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C0C")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHandTarget;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float crossFade;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F3")]
		public float speed;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C1C")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x38338A4", Offset = "0x38338A4", VA = "0x38338A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3833BDC", Offset = "0x3833BDC", VA = "0x3833BDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x38343B8", Offset = "0x38343B8", VA = "0x38343B8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem character2;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject handShake;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x38343FC", Offset = "0x38343FC", VA = "0x38343FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x3834544", Offset = "0x3834544", VA = "0x3834544")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x38347D0", Offset = "0x38347D0", VA = "0x38347D0")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11FB")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool interrupt;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C2C")]
		public InteractionObject ball;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject benchMain;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject benchHands;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject button;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1203")]
		public InteractionObject cigarette;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionObject door;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C3C")]
		private bool isSitting;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3834800", Offset = "0x3834800", VA = "0x3834800")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x38350F8", Offset = "0x38350F8", VA = "0x38350F8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D044", Offset = "0x105D044")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105FE6C", Offset = "0x105FE6C")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105FEEC", Offset = "0x105FEEC")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3835128", Offset = "0x3835128", VA = "0x3835128")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x38351B4", Offset = "0x38351B4", VA = "0x38351B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x3835674", Offset = "0x3835674", VA = "0x3835674")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform mouth;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1213")]
			public Transform mouthTarget;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C5C")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float bodyWeightVertical;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float neckRotationWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x121B")]
			public float headTiltAngle;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C6C")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000B3")]
			private Transform neck
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x3836B34", Offset = "0x3836B34", VA = "0x3836B34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x383570C", Offset = "0x383570C", VA = "0x383570C")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x3835848", Offset = "0x3835848", VA = "0x3835848")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x38367B4", Offset = "0x38367B4", VA = "0x38367B4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x3836C34", Offset = "0x3836C34", VA = "0x3836C34")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120B")]
		public Partner partner1;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Partner partner2;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C4C")]
		public float weight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int iterations;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x38356A4", Offset = "0x38356A4", VA = "0x38356A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x3835764", Offset = "0x3835764", VA = "0x3835764")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3836770", Offset = "0x3836770", VA = "0x3836770")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067CF0", Offset = "0x1067CF0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067D54", Offset = "0x1067D54")]
			public float weight;

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x383C2C0", Offset = "0x383C2C0", VA = "0x383C2C0")]
			public void SetToBone(IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x383C468", Offset = "0x383C468", VA = "0x383C468")]
			public void SetEffectorWeights(IKSolverFullBodyBiped solver, float w)
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x383C668", Offset = "0x383C668", VA = "0x383C668")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EA28", Offset = "0x105EA28")]
		private sealed class <AbsorbMotion>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x122B")]
			private object <>2__current;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public MotionAbsorb <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x383C568", Offset = "0x383C568", VA = "0x383C568", Slot = "4")]
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
				[Address(RVA = "0x383C638", Offset = "0x383C638", VA = "0x383C638", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x383BBF8", Offset = "0x383BBF8", VA = "0x383BBF8")]
			[DebuggerHidden]
			public <AbsorbMotion>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x383BC94", Offset = "0x383BC94", VA = "0x383BC94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x383BCA8", Offset = "0x383BCA8", VA = "0x383BCA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x383C598", Offset = "0x383C598", VA = "0x383C598", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105FF6C", Offset = "0x105FF6C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x105FFD0", Offset = "0x105FFD0")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060034", Offset = "0x1060034")]
		public float weight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1223")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060098", Offset = "0x1060098")]
		public AnimationCurve falloff;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10600FC", Offset = "0x10600FC")]
		public float falloffSpeed;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C7C")]
		private float timer;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x383BAC0", Offset = "0x383BAC0", VA = "0x383BAC0")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x383BB3C", Offset = "0x383BB3C", VA = "0x383BB3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106AE1C", Offset = "0x106AE1C")]
		private IEnumerator AbsorbMotion()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x383BC40", Offset = "0x383BC40", VA = "0x383BC40")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C8C")]
		public Animator animator;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform cube;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1233")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1C9C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x383C6AC", Offset = "0x383C6AC", VA = "0x383C6AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x383C788", Offset = "0x383C788", VA = "0x383C788")]
		private void Update()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x383C8C8", Offset = "0x383C8C8", VA = "0x383C8C8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x383CBA4", Offset = "0x383CBA4", VA = "0x383CBA4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x123B")]
			public float weightMultiplier;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x383D3D8", Offset = "0x383D3D8", VA = "0x383D3D8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x383CBEC", Offset = "0x383CBEC", VA = "0x383CBEC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x383CE80", Offset = "0x383CE80", VA = "0x383CE80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x383D3A8", Offset = "0x383D3A8", VA = "0x383D3A8")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D0F4", Offset = "0x105D0F4")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1CAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060160", Offset = "0x1060160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1060160", Offset = "0x1060160")]
		public float weight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10601FC", Offset = "0x10601FC")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060260", Offset = "0x1060260")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10602E0", Offset = "0x10602E0")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1243")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1CBC")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124B")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1CCC")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1253")]
		private float lastWeight;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x383D41C", Offset = "0x383D41C", VA = "0x383D41C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x383DB8C", Offset = "0x383DB8C", VA = "0x383DB8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x383EC34", Offset = "0x383EC34", VA = "0x383EC34")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1CDC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject obj;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pivot;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform holdPoint;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125B")]
		public float pickUpTime;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float holdWeight;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1CEC")]
		private float holdWeightVel;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000028")]
		private bool holding
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x383F740", Offset = "0x383F740", VA = "0x383F740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x383F4AC", Offset = "0x383F4AC", VA = "0x383F4AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600021B")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x383F7B0", Offset = "0x383F7B0", VA = "0x383F7B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x383FA24", Offset = "0x383FA24", VA = "0x383FA24")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x383FD78", Offset = "0x383FD78", VA = "0x383FD78")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x383FF14", Offset = "0x383FF14", VA = "0x383FF14")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x38401BC", Offset = "0x38401BC", VA = "0x38401BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x3840570", Offset = "0x3840570", VA = "0x3840570")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x3840898", Offset = "0x3840898", VA = "0x3840898")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x38408E0", Offset = "0x38408E0", VA = "0x38408E0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3840D48", Offset = "0x3840D48", VA = "0x3840D48")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x3840D78", Offset = "0x3840D78", VA = "0x3840D78", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3841128", Offset = "0x3841128", VA = "0x3841128")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1263")]
		public Transform root;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x38422B8", Offset = "0x38422B8", VA = "0x38422B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x384235C", Offset = "0x384235C", VA = "0x384235C")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x3842700", Offset = "0x3842700", VA = "0x3842700")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D1A4", Offset = "0x105D1A4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1CFC")]
		public float magnitude;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Recoil recoil;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x3842730", Offset = "0x3842730", VA = "0x3842730")]
		private void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x38427BC", Offset = "0x38427BC", VA = "0x38427BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3842864", Offset = "0x3842864", VA = "0x3842864")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x3842908", Offset = "0x3842908", VA = "0x3842908")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EA64", Offset = "0x105EA64")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float resetTime;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1273")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x3843148", Offset = "0x3843148", VA = "0x3843148", Slot = "4")]
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
				[Address(RVA = "0x3843218", Offset = "0x3843218", VA = "0x3843218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x3842C08", Offset = "0x3842C08", VA = "0x3842C08")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x3842C94", Offset = "0x3842C94", VA = "0x3842C94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x3842CA8", Offset = "0x3842CA8", VA = "0x3842CA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x3843178", Offset = "0x3843178", VA = "0x3843178", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float resetDelay;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126B")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform defaultParent;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D0C")]
		private Rigidbody r;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x384294C", Offset = "0x384294C", VA = "0x384294C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3842AA0", Offset = "0x3842AA0", VA = "0x3842AA0")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3842B24", Offset = "0x3842B24", VA = "0x3842B24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106AECC", Offset = "0x106AECC")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3842C50", Offset = "0x3842C50", VA = "0x3842C50")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D254", Offset = "0x105D254")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EAA0", Offset = "0x105EAA0")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x127B")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x3845E58", Offset = "0x3845E58", VA = "0x3845E58", Slot = "4")]
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
				[Address(RVA = "0x3845F28", Offset = "0x3845F28", VA = "0x3845F28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x3845AF8", Offset = "0x3845AF8", VA = "0x3845AF8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x3845B70", Offset = "0x3845B70", VA = "0x3845B70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x3845B84", Offset = "0x3845B84", VA = "0x3845B84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x3845E88", Offset = "0x3845E88", VA = "0x3845E88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Animator animator;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x38458F8", Offset = "0x38458F8", VA = "0x38458F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3845A3C", Offset = "0x3845A3C", VA = "0x3845A3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106AF7C", Offset = "0x106AF7C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3845B40", Offset = "0x3845B40", VA = "0x3845B40")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1283")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float spherecastRadius;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D3C")]
			public float minDistance;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float lerpSpeed;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float minSwitchTime;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128B")]
			public float releaseDistance;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public bool sliding;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D4C")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float raycastDistance;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool inTouch;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RaycastHit hit;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1293")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D5C")]
			private bool initiated;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float nextSwitchTime;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float speedF;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x3846B80", Offset = "0x3846B80", VA = "0x3846B80")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x38487D8", Offset = "0x38487D8", VA = "0x38487D8")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x3847214", Offset = "0x3847214", VA = "0x3847214")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x38489C0", Offset = "0x38489C0", VA = "0x38489C0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x3848CFC", Offset = "0x3848CFC", VA = "0x3848CFC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x3848E5C", Offset = "0x3848E5C", VA = "0x3848E5C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x3848FBC", Offset = "0x3848FBC", VA = "0x3848FBC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x3848514", Offset = "0x3848514", VA = "0x3848514")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x384911C", Offset = "0x384911C", VA = "0x384911C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D2C")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3846A78", Offset = "0x3846A78", VA = "0x3846A78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3847120", Offset = "0x3847120", VA = "0x3847120")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x3848330", Offset = "0x3848330", VA = "0x3848330")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x38487A8", Offset = "0x38487A8", VA = "0x38487A8")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10605B8", Offset = "0x10605B8")]
		public Transform to;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106061C", Offset = "0x106061C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106061C", Offset = "0x106061C")]
		public float transferMotion;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 lastPosition;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x38491E8", Offset = "0x38491E8", VA = "0x38491E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x3849260", Offset = "0x3849260", VA = "0x3849260")]
		private void Update()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x3849514", Offset = "0x3849514", VA = "0x3849514")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D6C")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float enableInputAtProgress;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x3849E5C", Offset = "0x3849E5C", VA = "0x3849E5C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x384A948", Offset = "0x384A948", VA = "0x384A948")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x384AC60", Offset = "0x384AC60", VA = "0x384AC60")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A3")]
		public GameObject[] characters;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x38330F8", Offset = "0x38330F8", VA = "0x38330F8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x38332CC", Offset = "0x38332CC", VA = "0x38332CC")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x38333F8", Offset = "0x38333F8", VA = "0x38333F8")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EADC", Offset = "0x105EADC")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int <>1__state;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D9C")]
			private object <>2__current;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x38421B8", Offset = "0x38421B8", VA = "0x38421B8", Slot = "4")]
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
				[Address(RVA = "0x3842288", Offset = "0x3842288", VA = "0x3842288", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x3841904", Offset = "0x3841904", VA = "0x3841904")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x3841E14", Offset = "0x3841E14", VA = "0x3841E14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x3841E28", Offset = "0x3841E28", VA = "0x3841E28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x38421E8", Offset = "0x38421E8", VA = "0x38421E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float maxAngle;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D7C")]
		public float switchRotationTime;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float random;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotationSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 movePosition;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12AB")]
		public float moveSpeed;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public int characterLayer;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1D8C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 velocity;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12B3")]
		private Rigidbody r;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3841158", Offset = "0x3841158", VA = "0x3841158")]
		private void Start()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x384140C", Offset = "0x384140C", VA = "0x384140C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3841350", Offset = "0x3841350", VA = "0x3841350")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106B02C", Offset = "0x106B02C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x384194C", Offset = "0x384194C", VA = "0x384194C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x3841B7C", Offset = "0x3841B7C", VA = "0x3841B7C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x3841D7C", Offset = "0x3841D7C", VA = "0x3841D7C")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbIK limbIK;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106076C", Offset = "0x106076C")]
		public float weight;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3820260", Offset = "0x3820260", VA = "0x3820260")]
		private void Start()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3820358", Offset = "0x3820358", VA = "0x3820358")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x38204CC", Offset = "0x38204CC", VA = "0x38204CC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1DAC")]
			public Transform transform;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x3849664", Offset = "0x3849664", VA = "0x3849664")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x38498A4", Offset = "0x38498A4", VA = "0x38498A4")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12BB")]
		public Transform target;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Part[] parts;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x384955C", Offset = "0x384955C", VA = "0x384955C")]
		private void Update()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x3849874", Offset = "0x3849874", VA = "0x3849874")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D304", Offset = "0x105D304")]
	public class FixFeet : MonoBehaviour
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10607B4", Offset = "0x10607B4")]
		public float weight;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C3")]
		private Vector3 relativePosL;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 relativePosR;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1DBC")]
		private Quaternion relativeRotL;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion relativeRotR;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x38322A0", Offset = "0x38322A0", VA = "0x38322A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x3832340", Offset = "0x3832340", VA = "0x3832340")]
		public void Sample()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x3832834", Offset = "0x3832834", VA = "0x3832834")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x38330B4", Offset = "0x38330B4", VA = "0x38330B4")]
		public FixFeet()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Mirror : MonoBehaviour
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] children;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12CB")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x383B1D4", Offset = "0x383B1D4", VA = "0x383B1D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x383B4DC", Offset = "0x383B4DC", VA = "0x383B4DC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x383B818", Offset = "0x383B818", VA = "0x383B818")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x383B9F8", Offset = "0x383B9F8", VA = "0x383B9F8")]
		public Mirror()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Phone : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EB18", Offset = "0x105EB18")]
		private sealed class <EnableDisplay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12D3")]
			private int <>1__state;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private object <>2__current;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1DDC")]
			public Phone <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x383F3AC", Offset = "0x383F3AC", VA = "0x383F3AC", Slot = "4")]
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
				[Address(RVA = "0x383F47C", Offset = "0x383F47C", VA = "0x383F47C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x383EF84", Offset = "0x383EF84", VA = "0x383EF84")]
			[DebuggerHidden]
			public <EnableDisplay>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x383F1B0", Offset = "0x383F1B0", VA = "0x383F1B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x383F1C4", Offset = "0x383F1C4", VA = "0x383F1C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x383F3DC", Offset = "0x383F3DC", VA = "0x383F3DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1DCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10607FC", Offset = "0x10607FC")]
		public Collider pickUpCollider;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060860", Offset = "0x1060860")]
		public InteractionObject pickUpObject;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10608C4", Offset = "0x10608C4")]
		public GameObject display;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform parent;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x383ED34", Offset = "0x383ED34", VA = "0x383ED34")]
		private void OnPickUp()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x383EEC8", Offset = "0x383EEC8", VA = "0x383EEC8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106B0DC", Offset = "0x106B0DC")]
		private IEnumerator EnableDisplay()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x383EFCC", Offset = "0x383EFCC", VA = "0x383EFCC")]
		private void OnButton1()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x383EFE0", Offset = "0x383EFE0", VA = "0x383EFE0")]
		private void OnButton2()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x383F0A0", Offset = "0x383F0A0", VA = "0x383F0A0")]
		private void DropPhone()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x383F180", Offset = "0x383F180", VA = "0x383F180")]
		public Phone()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D3B4", Offset = "0x105D3B4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform rightHand;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform bendGoalLeftArm;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12F3")]
			public Transform bendGoalRightArm;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130B")]
			public Vector3 value;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x384F35C", Offset = "0x384F35C", VA = "0x384F35C")]
			public BoneRotationOffset()
			{
			}
		}

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1060928", Offset = "0x1060928")]
		public VRAnimatorController animatorController;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106098C", Offset = "0x106098C")]
		public WeaponBase currentWeapon;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10609F0", Offset = "0x10609F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10609F0", Offset = "0x10609F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10609F0", Offset = "0x10609F0")]
		public float weight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12DB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060AD4", Offset = "0x1060AD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1060AD4", Offset = "0x1060AD4")]
		public float spineTwistWeight;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1060B70", Offset = "0x1060B70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060B70", Offset = "0x1060B70")]
		public Handedness handedness;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1DEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060C1C", Offset = "0x1060C1C")]
		public float sideOffset;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060C80", Offset = "0x1060C80")]
		public Targets leftHandedTargets;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060CE4", Offset = "0x1060CE4")]
		public Targets rightHandedTargets;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1060D48", Offset = "0x1060D48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060D48", Offset = "0x1060D48")]
		public Transform weaponsPivot;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12E3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060DF4", Offset = "0x1060DF4")]
		public Transform weaponsAnchor;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060E58", Offset = "0x1060E58")]
		public Transform pivotMotionTarget;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1DFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060EBC", Offset = "0x1060EBC")]
		public float lerpSpeed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060F20", Offset = "0x1060F20")]
		public float pivotMotionSmoothSpeed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1060F84", Offset = "0x1060F84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1060F84", Offset = "0x1060F84")]
		public float pivotMotionWeight;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061020", Offset = "0x1061020")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1061020", Offset = "0x1061020")]
		public float aimVerticalLimit;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12EB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10610BC", Offset = "0x10610BC")]
		public float aimZ;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E0C")]
		private float lastWeight;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poserLeftHand;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poserRightHand;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pivotRelativePosition;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12F3")]
		private Vector3 weaponsPivotLocalPosition;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 defaultWeaponsAnchorLocalPosition;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E1C")]
		private Vector3 aimVel;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimRandom;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float x;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float y;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12FB")]
		private float aimWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 cameraPosition;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E2C")]
		private Vector3 lastCharacterPosition;

		[Token(Token = "0x17000029")]
		private Transform cam
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x384AD18", Offset = "0x384AD18", VA = "0x384AD18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform characterController
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x384AD5C", Offset = "0x384AD5C", VA = "0x384AD5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private Targets targets
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x384D6D4", Offset = "0x384D6D4", VA = "0x384D6D4")]
			get
			{
				return default(Targets);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x384ADA0", Offset = "0x384ADA0", VA = "0x384ADA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x384B750", Offset = "0x384B750", VA = "0x384B750")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x384D730", Offset = "0x384D730", VA = "0x384D730")]
		private void RotateWeapon(float horAdd, float vertAdd)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x384B2AC", Offset = "0x384B2AC", VA = "0x384B2AC")]
		private Vector3 TargetsCameraPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x384B19C", Offset = "0x384B19C", VA = "0x384B19C")]
		private void SetHandedness(Handedness h)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x384E680", Offset = "0x384E680", VA = "0x384E680")]
		private void TwistSpine()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x384EB1C", Offset = "0x384EB1C", VA = "0x384EB1C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x384EED4", Offset = "0x384EED4", VA = "0x384EED4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x384F0B4", Offset = "0x384F0B4", VA = "0x384F0B4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x384F270", Offset = "0x384F270", VA = "0x384F270")]
		public VRAimingController()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D464", Offset = "0x105D464")]
	public class VRAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061120", Offset = "0x1061120")]
		public VRSetup oculusSetup;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E4C")]
		public Transform characterController;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform cam;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061184", Offset = "0x1061184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061184", Offset = "0x1061184")]
		public Vector3 cameraOffset;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061230", Offset = "0x1061230")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1313")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061294", Offset = "0x1061294")]
		public float linearAcceleration;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10612F8", Offset = "0x10612F8")]
		public float maxViewAngle;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106135C", Offset = "0x106135C")]
		public float locomotionSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10613C0", Offset = "0x10613C0")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 velocityC;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131B")]
		private bool rootCorrection;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 playerVelocity;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E6C")]
		private Vector3 playerLastPosition;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FixFeet fixFeet;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform cameraPivot;

		[Token(Token = "0x1700002C")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x384F38C", Offset = "0x384F38C", VA = "0x384F38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B18C", Offset = "0x106B18C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x384F3CC", Offset = "0x384F3CC", VA = "0x384F3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B1C8", Offset = "0x106B1C8")]
			private set
			{
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x384F42C", Offset = "0x384F42C", VA = "0x384F42C")]
		private void Start()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x384F884", Offset = "0x384F884", VA = "0x384F884")]
		private void Update()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x385026C", Offset = "0x385026C", VA = "0x385026C")]
		private Vector3 GetVelocityTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x384DE80", Offset = "0x384DE80", VA = "0x384DE80")]
		public void RotateCharacter(Vector3 forward, float maxAngle, [Optional] Transform fix)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3850620", Offset = "0x3850620", VA = "0x3850620")]
		public VRAnimatorController()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D514", Offset = "0x105D514")]
	public class VRCharacterController : MonoBehaviour
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float moveSpeed;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1323")]
		public float rotationSpeed;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10613FC", Offset = "0x10613FC")]
		public float rotationRatchet;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E7C")]
		public KeyCode ratchetRight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public KeyCode ratchetLeft;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform forwardDirection;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CharacterController characterController;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x3E6BCFC", Offset = "0x3E6BCFC", VA = "0x3E6BCFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x3E6BE5C", Offset = "0x3E6BE5C", VA = "0x3E6BE5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3E6C5CC", Offset = "0x3E6C5CC", VA = "0x3E6C5CC")]
		public VRCharacterController()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D5C4", Offset = "0x105D5C4")]
	public class VRInteractionController : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061444", Offset = "0x1061444")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1061444", Offset = "0x1061444")]
		public float triggerTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10614E0", Offset = "0x10614E0")]
		private InteractionSystem <interactionSystem>k__BackingField;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106151C", Offset = "0x106151C")]
		private InteractionTrigger <currentTrigger>k__BackingField;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x1700002D")]
		public InteractionSystem interactionSystem
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x3E6C660", Offset = "0x3E6C660", VA = "0x3E6C660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B204", Offset = "0x106B204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x3E6C690", Offset = "0x3E6C690", VA = "0x3E6C690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B240", Offset = "0x106B240")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float triggerProgress
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x3E6C6C8", Offset = "0x3E6C6C8", VA = "0x3E6C6C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public InteractionTrigger currentTrigger
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x3E6C750", Offset = "0x3E6C750", VA = "0x3E6C750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B27C", Offset = "0x106B27C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x3E6C780", Offset = "0x3E6C780", VA = "0x3E6C780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B2B8", Offset = "0x106B2B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x3E6C7B8", Offset = "0x3E6C7B8", VA = "0x3E6C7B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x3E6C850", Offset = "0x3E6C850", VA = "0x3E6C850")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x3E6CA78", Offset = "0x3E6CA78", VA = "0x3E6CA78")]
		private bool CanTrigger(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x3E6CB58", Offset = "0x3E6CB58", VA = "0x3E6CB58")]
		public VRInteractionController()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D674", Offset = "0x105D674")]
	public class VRInteractionUI : MonoBehaviour
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061558", Offset = "0x1061558")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061558", Offset = "0x1061558")]
		public Slider slider;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061604", Offset = "0x1061604")]
		public AnimationCurve alphaToProgress;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1333")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061668", Offset = "0x1061668")]
		public Transform cursor;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private VRInteractionController interactionController;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1E9C")]
		private Image[] sliderImages;

		[Token(Token = "0x40002A4")]
		private const string showCursorTag = "ShowCursor";

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x3E6CB9C", Offset = "0x3E6CB9C", VA = "0x3E6CB9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3E6CC68", Offset = "0x3E6CC68", VA = "0x3E6CC68")]
		private void Update()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x3E6CCA8", Offset = "0x3E6CCA8", VA = "0x3E6CCA8")]
		private void UpdateInteractionSlider()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x3E6D0B8", Offset = "0x3E6D0B8", VA = "0x3E6D0B8")]
		private void UpdateCursor()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x3E6D448", Offset = "0x3E6D448", VA = "0x3E6D448")]
		private void SetSliderAlpha(float a)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x3E6D964", Offset = "0x3E6D964", VA = "0x3E6D964")]
		public VRInteractionUI()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class VRSetup : MonoBehaviour
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Text text;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject model;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x133B")]
		public GameObject[] enableOnR;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public VRCharacterController characterController;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1EAC")]
		public bool disableMovement;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10616CC", Offset = "0x10616CC")]
		private bool <isFinished>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float moveSpeed;

		[Token(Token = "0x17000030")]
		public bool isFinished
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x3E6D994", Offset = "0x3E6D994", VA = "0x3E6D994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B2F4", Offset = "0x106B2F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x3E6D9D8", Offset = "0x3E6D9D8", VA = "0x3E6D9D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B330", Offset = "0x106B330")]
			private set
			{
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x3E6DA24", Offset = "0x3E6DA24", VA = "0x3E6DA24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x3E6DC84", Offset = "0x3E6DC84", VA = "0x3E6DC84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x3E6E264", Offset = "0x3E6E264", VA = "0x3E6E264")]
		public VRSetup()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public abstract class WeaponBase : MonoBehaviour
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061708", Offset = "0x1061708")]
		public Vector3 recoilDirection;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1343")]
		public float recoilAngleVertical;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float recoilAngleHorizontal;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1EBC")]
		public float recoilRandom;

		[Token(Token = "0x6000287")]
		public abstract void Fire();

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x3E6E294", Offset = "0x3E6E294", VA = "0x3E6E294")]
		protected WeaponBase()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class WeaponRifle : WeaponBase
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x106176C", Offset = "0x106176C")]
		public Transform shootFrom;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float range;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask hitLayers;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134B")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10617D0", Offset = "0x10617D0")]
		public ParticleSystem muzzleFlash;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public ParticleSystem muzzleSmoke;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1ECC")]
		public Transform bulletHole;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem bulletHit;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float smokeFadeOutSpeed;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float smokeEmission;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x3E6E3D4", Offset = "0x3E6E3D4", VA = "0x3E6E3D4", Slot = "4")]
		public override void Fire()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x3E6E8BC", Offset = "0x3E6E8BC", VA = "0x3E6E8BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x3E6EB44", Offset = "0x3E6EB44", VA = "0x3E6EB44")]
		public WeaponRifle()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1353")]
		public bool smoothFollow;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1EDC")]
		private Vector3 lastPosition;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 localPosition;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion localRotation;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000031")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x3821528", Offset = "0x3821528", VA = "0x3821528", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x38214C8", Offset = "0x38214C8", VA = "0x38214C8", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x382154C", Offset = "0x382154C", VA = "0x382154C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x38216CC", Offset = "0x38216CC", VA = "0x38216CC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3821B30", Offset = "0x3821B30", VA = "0x3821B30", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3821FC8", Offset = "0x3821FC8", VA = "0x3821FC8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D724", Offset = "0x105D724")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135B")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1EEC")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3822024", Offset = "0x3822024", VA = "0x3822024", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x38220C4", Offset = "0x38220C4", VA = "0x38220C4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x38222C0", Offset = "0x38222C0", VA = "0x38222C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x3822594", Offset = "0x3822594", VA = "0x3822594")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D7D4", Offset = "0x105D7D4")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1363")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1EFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106199C", Offset = "0x106199C")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Animator animator;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastForward;

		[Token(Token = "0x40002CA")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40002CB")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x17000032")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x38226F4", Offset = "0x38226F4", VA = "0x38226F4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x38225C4", Offset = "0x38225C4", VA = "0x38225C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x382269C", Offset = "0x382269C", VA = "0x382269C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x38228D4", Offset = "0x38228D4", VA = "0x38228D4", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x3823120", Offset = "0x3823120", VA = "0x3823120")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x38231F4", Offset = "0x38231F4", VA = "0x38231F4")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D884", Offset = "0x105D884")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D884", Offset = "0x105D884")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061A0C", Offset = "0x1061A0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061A0C", Offset = "0x1061A0C")]
		public Transform gravityTarget;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061AB8", Offset = "0x1061AB8")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1373")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F1C")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Rigidbody r;

		[Token(Token = "0x40002D6")]
		protected const float half = 0.5f;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x137B")]
		protected float originalHeight;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F2C")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600029C")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x3823BDC", Offset = "0x3823BDC", VA = "0x3823BDC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x3823E8C", Offset = "0x3823E8C", VA = "0x3823E8C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x382410C", Offset = "0x382410C", VA = "0x382410C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x38245E4", Offset = "0x38245E4", VA = "0x38245E4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x3824764", Offset = "0x3824764", VA = "0x3824764")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x3824B40", Offset = "0x3824B40", VA = "0x3824B40")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x3824EA4", Offset = "0x3824EA4", VA = "0x3824EA4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x3824EFC", Offset = "0x3824EFC", VA = "0x3824EFC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x3824F54", Offset = "0x3824F54", VA = "0x3824F54")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x3825168", Offset = "0x3825168", VA = "0x3825168")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool jump;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool crouch;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13BB")]
			public bool onGround;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool isStrafing;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F1FBC")]
			public float yVelocity;
		}

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061C64", Offset = "0x1061C64")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CameraController cam;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1383")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061CC8", Offset = "0x1061CC8")]
		public MoveMode moveMode;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool smoothPhysics;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F3C")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float platformFriction;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float groundStickyEffect;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138B")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061D2C", Offset = "0x1061D2C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float turnSpeed;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061D90", Offset = "0x1061D90")]
		public float airSpeed;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1393")]
		public float airControl;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float jumpPower;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F5C")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061DF4", Offset = "0x1061DF4")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139B")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F6C")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1061E74", Offset = "0x1061E74")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1061ED8", Offset = "0x1061ED8")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A3")]
		public AnimState animState;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F7C")]
		private Animator animator;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 normal;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13AB")]
		private RaycastHit hit;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float jumpLeg;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F8C")]
		private float jumpEndTime;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float forwardMlp;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float groundDistance;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastAirTime;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B3")]
		private float stickyForce;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1F9C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunWeight;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13BB")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool fixedFrame;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1FAC")]
		private float wallRunEndTime;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 gravity;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float velocityY;

		[Token(Token = "0x17000033")]
		public bool onGround
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x3825A04", Offset = "0x3825A04", VA = "0x3825A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B36C", Offset = "0x106B36C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x3825A48", Offset = "0x3825A48", VA = "0x3825A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B3A8", Offset = "0x106B3A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x3825A94", Offset = "0x3825A94", VA = "0x3825A94", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x3825D84", Offset = "0x3825D84", VA = "0x3825D84")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x3825E44", Offset = "0x3825E44", VA = "0x3825E44", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x3826070", Offset = "0x3826070", VA = "0x3826070")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x38283D8", Offset = "0x38283D8", VA = "0x38283D8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x3828CB0", Offset = "0x3828CB0", VA = "0x3828CB0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x3826AE0", Offset = "0x3826AE0", VA = "0x3826AE0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x3828F20", Offset = "0x3828F20", VA = "0x3828F20")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x3829DF8", Offset = "0x3829DF8", VA = "0x3829DF8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x3828634", Offset = "0x3828634", VA = "0x3828634")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x3829FEC", Offset = "0x3829FEC", VA = "0x3829FEC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x382A890", Offset = "0x382A890", VA = "0x382A890")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x382AECC", Offset = "0x382AECC", VA = "0x382AECC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x3827994", Offset = "0x3827994", VA = "0x3827994")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x382B304", Offset = "0x382B304", VA = "0x382B304")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105D980", Offset = "0x105D980")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061F14", Offset = "0x1061F14")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1061F94", Offset = "0x1061F94")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062014", Offset = "0x1062014")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062094", Offset = "0x1062094")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062114", Offset = "0x1062114")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1FDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062194", Offset = "0x1062194")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1062214", Offset = "0x1062214")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float speed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13DB")]
		private float angleVel;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float speedVel;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1FEC")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CharacterController characterController;

		[Token(Token = "0x17000034")]
		public bool isGrounded
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x3844090", Offset = "0x3844090", VA = "0x3844090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B3E4", Offset = "0x106B3E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x38440D4", Offset = "0x38440D4", VA = "0x38440D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B420", Offset = "0x106B420")]
			private set
			{
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x3844120", Offset = "0x3844120", VA = "0x3844120")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x3844210", Offset = "0x3844210", VA = "0x3844210")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x3845248", Offset = "0x3845248", VA = "0x3845248")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x38442A8", Offset = "0x38442A8", VA = "0x38442A8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x3844C2C", Offset = "0x3844C2C", VA = "0x3844C2C")]
		private void Move()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x38452B0", Offset = "0x38452B0", VA = "0x38452B0")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x38454D0", Offset = "0x38454D0", VA = "0x38454D0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x38455D0", Offset = "0x38455D0", VA = "0x38455D0")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform moveTarget;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F1FFC")]
		public float stoppingDistance;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stoppingThreshold;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x38498D4", Offset = "0x38498D4", VA = "0x38498D4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x3849DA4", Offset = "0x3849DA4", VA = "0x3849DA4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lookPos;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool crouch;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13E3")]
			public bool jump;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public int actionIndex;
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool walkByDefault;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool canCrouch;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13EB")]
		public bool canJump;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public State state;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F200C")]
		protected Transform cam;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x384ACC0", Offset = "0x384ACC0", VA = "0x384ACC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x384A10C", Offset = "0x384A10C", VA = "0x384A10C", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x3849E00", Offset = "0x3849E00", VA = "0x3849E00")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x38201B0", Offset = "0x38201B0", VA = "0x38201B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x3820230", Offset = "0x3820230", VA = "0x3820230")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F201C")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x3845658", Offset = "0x3845658", VA = "0x3845658")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x38456E0", Offset = "0x38456E0", VA = "0x38456E0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x38458B0", Offset = "0x38458B0", VA = "0x38458B0")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DA30", Offset = "0x105DA30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DA30", Offset = "0x105DA30")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13FB")]
		public BipedReferences references;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x3E70A88", Offset = "0x3E70A88", VA = "0x3E70A88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B45C", Offset = "0x106B45C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x3E70B0C", Offset = "0x3E70B0C", VA = "0x3E70B0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B4C0", Offset = "0x106B4C0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x3E70B90", Offset = "0x3E70B90", VA = "0x3E70B90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B524", Offset = "0x106B524")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x3E70C14", Offset = "0x3E70C14", VA = "0x3E70C14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B588", Offset = "0x106B588")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x3E70C98", Offset = "0x3E70C98", VA = "0x3E70C98")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x3E70E5C", Offset = "0x3E70E5C", VA = "0x3E70E5C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x3E70EC0", Offset = "0x3E70EC0", VA = "0x3E70EC0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x3E70F2C", Offset = "0x3E70F2C", VA = "0x3E70F2C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x3E70F98", Offset = "0x3E70F98", VA = "0x3E70F98")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x3E71028", Offset = "0x3E71028", VA = "0x3E71028")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x3E71190", Offset = "0x3E71190", VA = "0x3E71190")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x3E711FC", Offset = "0x3E711FC", VA = "0x3E711FC")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x3E71274", Offset = "0x3E71274", VA = "0x3E71274")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x3E71340", Offset = "0x3E71340", VA = "0x3E71340")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x3E713CC", Offset = "0x3E713CC", VA = "0x3E713CC")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x3E71458", Offset = "0x3E71458", VA = "0x3E71458")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x3E70CFC", Offset = "0x3E70CFC", VA = "0x3E70CFC")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x3E714C4", Offset = "0x3E714C4", VA = "0x3E714C4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x3E714F4", Offset = "0x3E714F4", VA = "0x3E714F4")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x3E71524", Offset = "0x3E71524", VA = "0x3E71524")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x3E71B2C", Offset = "0x3E71B2C", VA = "0x3E71B2C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x3E71C88", Offset = "0x3E71C88", VA = "0x3E71C88", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x3E7260C", Offset = "0x3E7260C", VA = "0x3E7260C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x3E72F8C", Offset = "0x3E72F8C", VA = "0x3E72F8C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x3E72FF0", Offset = "0x3E72FF0", VA = "0x3E72FF0")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F202C")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1403")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F203C")]
		public IKSolverAim aim;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Constraints pelvis;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000035")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x3E718FC", Offset = "0x3E718FC", VA = "0x3E718FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x3E732EC", Offset = "0x3E732EC", VA = "0x3E732EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x3E72068", Offset = "0x3E72068", VA = "0x3E72068")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x3E730CC", Offset = "0x3E730CC", VA = "0x3E730CC")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140B")]
		public Transform transform;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float weight;

		[Token(Token = "0x17000037")]
		public bool isValid
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x3E73EE4", Offset = "0x3E73EE4", VA = "0x3E73EE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EA")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x3E74000", Offset = "0x3E74000", VA = "0x3E74000")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F204C")]
		public Vector3 position;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x3E74030", Offset = "0x3E74030", VA = "0x3E74030", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x3E74200", Offset = "0x3E74200", VA = "0x3E74200")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x3E74230", Offset = "0x3E74230", VA = "0x3E74230")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1413")]
		private bool initiated;

		[Token(Token = "0x17000038")]
		private bool positionChanged
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x3E74674", Offset = "0x3E74674", VA = "0x3E74674")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x3E74278", Offset = "0x3E74278", VA = "0x3E74278", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x3E747A8", Offset = "0x3E747A8", VA = "0x3E747A8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x3E747D8", Offset = "0x3E747D8", VA = "0x3E747D8")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Quaternion rotation;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x3E74820", Offset = "0x3E74820", VA = "0x3E74820", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x3E74A00", Offset = "0x3E74A00", VA = "0x3E74A00")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x3E74A30", Offset = "0x3E74A30", VA = "0x3E74A30")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F205C")]
		public Quaternion offset;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141B")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool initiated;

		[Token(Token = "0x17000039")]
		private bool rotationChanged
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x3E74E68", Offset = "0x3E74E68", VA = "0x3E74E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x3E74A78", Offset = "0x3E74A78", VA = "0x3E74A78", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x3E74F98", Offset = "0x3E74F98", VA = "0x3E74F98")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x3E74FC8", Offset = "0x3E74FC8", VA = "0x3E74FC8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class Constraints
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F206C")]
		public Transform transform;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062340", Offset = "0x1062340")]
		public float positionWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1423")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 rotation;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F207C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062388", Offset = "0x1062388")]
		public float rotationWeight;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x3E75010", Offset = "0x3E75010", VA = "0x3E75010")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x3E72538", Offset = "0x3E72538", VA = "0x3E72538")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x3E729B4", Offset = "0x3E729B4", VA = "0x3E729B4")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x3E735E4", Offset = "0x3E735E4", VA = "0x3E735E4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10623D0", Offset = "0x10623D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10623D0", Offset = "0x10623D0")]
		public float weight;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106246C", Offset = "0x106246C")]
		public Transform bone1;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10624D0", Offset = "0x10624D0")]
		public Transform bone2;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062534", Offset = "0x1062534")]
		public Transform bone3;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062598", Offset = "0x1062598")]
		public Transform tip;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F208C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10625FC", Offset = "0x10625FC")]
		public Transform target;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1062660", Offset = "0x1062660")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolverLimb solver;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1433")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x3E860B0", Offset = "0x3E860B0", VA = "0x3E860B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B5EC", Offset = "0x106B5EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x3E860F4", Offset = "0x3E860F4", VA = "0x3E860F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B628", Offset = "0x106B628")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x3E86140", Offset = "0x3E86140", VA = "0x3E86140")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x3E86194", Offset = "0x3E86194", VA = "0x3E86194")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x3E86208", Offset = "0x3E86208", VA = "0x3E86208")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x3E86264", Offset = "0x3E86264", VA = "0x3E86264")]
			set
			{
			}
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x3E863AC", Offset = "0x3E863AC", VA = "0x3E863AC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x3E86674", Offset = "0x3E86674", VA = "0x3E86674")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x3E86BD0", Offset = "0x3E86BD0", VA = "0x3E86BD0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x3E86D9C", Offset = "0x3E86D9C", VA = "0x3E86D9C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x3E87390", Offset = "0x3E87390", VA = "0x3E87390")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F209C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106269C", Offset = "0x106269C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106269C", Offset = "0x106269C")]
		public float weight;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Finger[] fingers;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1062738", Offset = "0x1062738")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700003D")]
		public bool initiated
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x3E873D4", Offset = "0x3E873D4", VA = "0x3E873D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B664", Offset = "0x106B664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x3E87418", Offset = "0x3E87418", VA = "0x3E87418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106B6A0", Offset = "0x106B6A0")]
			private set
			{
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x3E87464", Offset = "0x3E87464", VA = "0x3E87464")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x3E875B4", Offset = "0x3E875B4", VA = "0x3E875B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B6DC", Offset = "0x106B6DC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x3E87D48", Offset = "0x3E87D48", VA = "0x3E87D48")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x3E88130", Offset = "0x3E88130", VA = "0x3E88130")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x3E87B5C", Offset = "0x3E87B5C", VA = "0x3E87B5C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x3E88470", Offset = "0x3E88470", VA = "0x3E88470", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x3E88600", Offset = "0x3E88600", VA = "0x3E88600")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x3E8873C", Offset = "0x3E8873C", VA = "0x3E8873C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x3E88834", Offset = "0x3E88834", VA = "0x3E88834", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x3E88864", Offset = "0x3E88864", VA = "0x3E88864", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x3E88894", Offset = "0x3E88894", VA = "0x3E88894")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062774", Offset = "0x1062774")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062774", Offset = "0x1062774")]
		public float weight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062810", Offset = "0x1062810")]
		public Grounding solver;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F20AC")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool initiated;

		[Token(Token = "0x6000316")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x3E8AC44", Offset = "0x3E8AC44", VA = "0x3E8AC44")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x3E8B210", Offset = "0x3E8B210", VA = "0x3E8B210")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x3E8AEE0", Offset = "0x3E8AEE0", VA = "0x3E8AEE0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x3E8B274", Offset = "0x3E8B274", VA = "0x3E8B274")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600031C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x3E8B698", Offset = "0x3E8B698", VA = "0x3E8B698")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DADC", Offset = "0x105DADC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DADC", Offset = "0x105DADC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062874", Offset = "0x1062874")]
		public BipedIK ik;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10628D8", Offset = "0x10628D8")]
		public float spineBend;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1443")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106293C", Offset = "0x106293C")]
		public float spineSpeed;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform[] feet;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F20BC")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144B")]
		private float lastWeight;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x3E8BBD0", Offset = "0x3E8BBD0", VA = "0x3E8BBD0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B740", Offset = "0x106B740")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x3E8BC54", Offset = "0x3E8BC54", VA = "0x3E8BC54", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B7A4", Offset = "0x106B7A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x3E8BCD8", Offset = "0x3E8BCD8", VA = "0x3E8BCD8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x3E8BF18", Offset = "0x3E8BF18", VA = "0x3E8BF18")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x3E8C154", Offset = "0x3E8C154", VA = "0x3E8C154")]
		private void Update()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x3E8C2FC", Offset = "0x3E8C2FC", VA = "0x3E8C2FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x3E8CDBC", Offset = "0x3E8CDBC", VA = "0x3E8CDBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x3E8CE9C", Offset = "0x3E8CE9C", VA = "0x3E8CE9C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x3E8E37C", Offset = "0x3E8E37C", VA = "0x3E8E37C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x3E8E648", Offset = "0x3E8E648", VA = "0x3E8E648")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x3E8EA10", Offset = "0x3E8EA10", VA = "0x3E8EA10")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x3E8ECFC", Offset = "0x3E8ECFC", VA = "0x3E8ECFC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DB88", Offset = "0x105DB88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DB88", Offset = "0x105DB88")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200011B")]
		public class SpineEffector
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F20DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067DF4", Offset = "0x1067DF4")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067E58", Offset = "0x1067E58")]
			public float horizontalWeight;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1067EBC", Offset = "0x1067EBC")]
			public float verticalWeight;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x3E90CCC", Offset = "0x3E90CCC", VA = "0x3E90CCC")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10629A0", Offset = "0x10629A0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F20CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062A04", Offset = "0x1062A04")]
		public float spineBend;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062A68", Offset = "0x1062A68")]
		public float spineSpeed;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] feet;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1453")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool firstSolve;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x3E8EDFC", Offset = "0x3E8EDFC", VA = "0x3E8EDFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B808", Offset = "0x106B808")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x3E8EE80", Offset = "0x3E8EE80", VA = "0x3E8EE80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B86C", Offset = "0x106B86C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x3E8EF04", Offset = "0x3E8EF04", VA = "0x3E8EF04", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B8D0", Offset = "0x106B8D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x3E8EF88", Offset = "0x3E8EF88", VA = "0x3E8EF88", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x3E8F080", Offset = "0x3E8F080", VA = "0x3E8F080")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x3E8F230", Offset = "0x3E8F230", VA = "0x3E8F230")]
		private void Update()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x3E8F780", Offset = "0x3E8F780", VA = "0x3E8F780")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x3E8F7B0", Offset = "0x3E8F7B0", VA = "0x3E8F7B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x3E8F3E8", Offset = "0x3E8F3E8", VA = "0x3E8F3E8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x3E8F7E0", Offset = "0x3E8F7E0", VA = "0x3E8F7E0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x3E902C4", Offset = "0x3E902C4", VA = "0x3E902C4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x3E906F0", Offset = "0x3E906F0", VA = "0x3E906F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x3E909C4", Offset = "0x3E909C4", VA = "0x3E909C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x3E90BC4", Offset = "0x3E90BC4", VA = "0x3E90BC4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DC34", Offset = "0x105DC34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DC34", Offset = "0x105DC34")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IK[] legs;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062ACC", Offset = "0x1062ACC")]
		public Transform pelvis;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062B30", Offset = "0x1062B30")]
		public Transform characterRoot;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F20EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062B94", Offset = "0x1062B94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062B94", Offset = "0x1062B94")]
		public float rootRotationWeight;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062C30", Offset = "0x1062C30")]
		public float rootRotationSpeed;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062C94", Offset = "0x1062C94")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] feet;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1463")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F20FC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int solvedFeet;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool solved;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x3E90D10", Offset = "0x3E90D10", VA = "0x3E90D10", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B934", Offset = "0x106B934")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x3E90D94", Offset = "0x3E90D94", VA = "0x3E90D94", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B998", Offset = "0x106B998")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x3E90E18", Offset = "0x3E90E18", VA = "0x3E90E18", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x3E90E60", Offset = "0x3E90E60", VA = "0x3E90E60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x3E912C0", Offset = "0x3E912C0", VA = "0x3E912C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x3E91510", Offset = "0x3E91510", VA = "0x3E91510")]
		private void Update()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x3E922F4", Offset = "0x3E922F4", VA = "0x3E922F4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x3E928D8", Offset = "0x3E928D8", VA = "0x3E928D8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x3E92E60", Offset = "0x3E92E60", VA = "0x3E92E60")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x3E930B4", Offset = "0x3E930B4", VA = "0x3E930B4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x3E934D0", Offset = "0x3E934D0", VA = "0x3E934D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x3E93860", Offset = "0x3E93860", VA = "0x3E93860")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DCE0", Offset = "0x105DCE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DCE0", Offset = "0x105DCE0")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200011C")]
		public struct Foot
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1483")]
			public Quaternion rotation;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x3E95114", Offset = "0x3E95114", VA = "0x3E95114")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x146B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062CF8", Offset = "0x1062CF8")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062D5C", Offset = "0x1062D5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062D5C", Offset = "0x1062D5C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F210C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062DF8", Offset = "0x1062DF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062DF8", Offset = "0x1062DF8")]
		public float minRootRotation;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062E94", Offset = "0x1062E94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1062E94", Offset = "0x1062E94")]
		public float maxRootRotation;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062F30", Offset = "0x1062F30")]
		public float rootRotationSpeed;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062F94", Offset = "0x1062F94")]
		public float maxLegOffset;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1473")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1062FF8", Offset = "0x1062FF8")]
		public float maxForeLegOffset;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106305C", Offset = "0x106305C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106305C", Offset = "0x106305C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F211C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10630F8", Offset = "0x10630F8")]
		public Transform characterRoot;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106315C", Offset = "0x106315C")]
		public Transform pelvis;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10631C0", Offset = "0x10631C0")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063224", Offset = "0x1063224")]
		public Transform head;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x147B")]
		public IK[] legs;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IK[] forelegs;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F212C")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Foot[] feet;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1483")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F213C")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int solvedFeet;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool solved;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148B")]
		private float angle;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F214C")]
		private Quaternion headRotation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x3E93960", Offset = "0x3E93960", VA = "0x3E93960", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106B9FC", Offset = "0x106B9FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x3E939E4", Offset = "0x3E939E4", VA = "0x3E939E4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BA60", Offset = "0x106BA60")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x3E93A68", Offset = "0x3E93A68", VA = "0x3E93A68", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x3E93AD0", Offset = "0x3E93AD0", VA = "0x3E93AD0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x3E93E8C", Offset = "0x3E93E8C", VA = "0x3E93E8C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x3E94200", Offset = "0x3E94200", VA = "0x3E94200")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x3E94358", Offset = "0x3E94358", VA = "0x3E94358")]
		private void Update()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x3E94510", Offset = "0x3E94510", VA = "0x3E94510")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x3E94B40", Offset = "0x3E94B40", VA = "0x3E94B40")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3E951C0", Offset = "0x3E951C0", VA = "0x3E951C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x3E95494", Offset = "0x3E95494", VA = "0x3E95494")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3E95CA4", Offset = "0x3E95CA4", VA = "0x3E95CA4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x3E96F48", Offset = "0x3E96F48", VA = "0x3E96F48")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x3E974F0", Offset = "0x3E974F0", VA = "0x3E974F0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x3E9787C", Offset = "0x3E9787C", VA = "0x3E9787C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x3E97F84", Offset = "0x3E97F84", VA = "0x3E97F84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x3E98004", Offset = "0x3E98004", VA = "0x3E98004")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x3E98374", Offset = "0x3E98374", VA = "0x3E98374")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1067F20", Offset = "0x1067F20")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1067F5C", Offset = "0x1067F5C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14BB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1067F98", Offset = "0x1067F98")]
			private Quaternion <rotationOffset>k__BackingField;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1067FD4", Offset = "0x1067FD4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F21AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1068010", Offset = "0x1068010")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106804C", Offset = "0x106804C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1068088", Offset = "0x1068088")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10680C4", Offset = "0x10680C4")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C3")]
			private Grounding grounding;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float lastTime;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F21BC")]
			private float deltaTime;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion r;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14CB")]
			private RaycastHit heelHit;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 up;

			[Token(Token = "0x170000BE")]
			public bool isGrounded
			{
				[Token(Token = "0x6000806")]
				[Address(RVA = "0x3E9BEA8", Offset = "0x3E9BEA8", VA = "0x3E9BEA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106ECA8", Offset = "0x106ECA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000807")]
				[Address(RVA = "0x3E9BEEC", Offset = "0x3E9BEEC", VA = "0x3E9BEEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106ECE4", Offset = "0x106ECE4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x3E9BF38", Offset = "0x3E9BF38", VA = "0x3E9BF38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106ED20", Offset = "0x106ED20")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000809")]
				[Address(RVA = "0x3E9BF78", Offset = "0x3E9BF78", VA = "0x3E9BF78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106ED5C", Offset = "0x106ED5C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rotationOffset
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0x3E9BFD8", Offset = "0x3E9BFD8", VA = "0x3E9BFD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106ED98", Offset = "0x106ED98")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600080B")]
				[Address(RVA = "0x3E9C020", Offset = "0x3E9C020", VA = "0x3E9C020")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EDD4", Offset = "0x106EDD4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public bool initiated
			{
				[Token(Token = "0x600080C")]
				[Address(RVA = "0x3E9C150", Offset = "0x3E9C150", VA = "0x3E9C150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EE10", Offset = "0x106EE10")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600080D")]
				[Address(RVA = "0x3E9C194", Offset = "0x3E9C194", VA = "0x3E9C194")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EE4C", Offset = "0x106EE4C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public float heightFromGround
			{
				[Token(Token = "0x600080E")]
				[Address(RVA = "0x3E9C1E0", Offset = "0x3E9C1E0", VA = "0x3E9C1E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EE88", Offset = "0x106EE88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600080F")]
				[Address(RVA = "0x3E9C210", Offset = "0x3E9C210", VA = "0x3E9C210")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EEC4", Offset = "0x106EEC4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0x3E9C248", Offset = "0x3E9C248", VA = "0x3E9C248")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EF00", Offset = "0x106EF00")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000811")]
				[Address(RVA = "0x3E9C288", Offset = "0x3E9C288", VA = "0x3E9C288")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EF3C", Offset = "0x106EF3C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public Transform transform
			{
				[Token(Token = "0x6000812")]
				[Address(RVA = "0x3E9C2E8", Offset = "0x3E9C2E8", VA = "0x3E9C2E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EF78", Offset = "0x106EF78")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x3E9C318", Offset = "0x3E9C318", VA = "0x3E9C318")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EFB4", Offset = "0x106EFB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public float IKOffset
			{
				[Token(Token = "0x6000814")]
				[Address(RVA = "0x3E9C350", Offset = "0x3E9C350", VA = "0x3E9C350")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106EFF0", Offset = "0x106EFF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x3E9C380", Offset = "0x3E9C380", VA = "0x3E9C380")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F02C", Offset = "0x106F02C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600081A")]
				[Address(RVA = "0x3E9D7E8", Offset = "0x3E9D7E8", VA = "0x3E9D7E8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C7")]
			private float rootYOffset
			{
				[Token(Token = "0x6000823")]
				[Address(RVA = "0x3E9DD8C", Offset = "0x3E9DD8C", VA = "0x3E9DD8C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x3E99614", Offset = "0x3E99614", VA = "0x3E99614")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x3E9C3B8", Offset = "0x3E9C3B8", VA = "0x3E9C3B8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x3E9B688", Offset = "0x3E9B688", VA = "0x3E9B688")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x3E99868", Offset = "0x3E99868", VA = "0x3E99868")]
			public void Process()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x3E9D194", Offset = "0x3E9D194", VA = "0x3E9D194")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x3E9C474", Offset = "0x3E9C474", VA = "0x3E9C474")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x3E9DADC", Offset = "0x3E9DADC", VA = "0x3E9DADC")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x3E9CA14", Offset = "0x3E9CA14", VA = "0x3E9CA14")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x3E9CBE8", Offset = "0x3E9CBE8", VA = "0x3E9CBE8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x3E9DCA4", Offset = "0x3E9DCA4", VA = "0x3E9DCA4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x3E9D93C", Offset = "0x3E9D93C", VA = "0x3E9D93C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x3E9DFC8", Offset = "0x3E9DFC8", VA = "0x3E9DFC8")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x3E99500", Offset = "0x3E99500", VA = "0x3E99500")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200011F")]
		public class Pelvis
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F21CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1068100", Offset = "0x1068100")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106813C", Offset = "0x106813C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Grounding grounding;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14D3")]
			private float damperF;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private bool initiated;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F21DC")]
			private float lastTime;

			[Token(Token = "0x170000C8")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000825")]
				[Address(RVA = "0x3E9E21C", Offset = "0x3E9E21C", VA = "0x3E9E21C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F068", Offset = "0x106F068")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000826")]
				[Address(RVA = "0x3E9E25C", Offset = "0x3E9E25C", VA = "0x3E9E25C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F0A4", Offset = "0x106F0A4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public float heightOffset
			{
				[Token(Token = "0x6000827")]
				[Address(RVA = "0x3E9E2BC", Offset = "0x3E9E2BC", VA = "0x3E9E2BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F0E0", Offset = "0x106F0E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000828")]
				[Address(RVA = "0x3E9E2EC", Offset = "0x3E9E2EC", VA = "0x3E9E2EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F11C", Offset = "0x106F11C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x3E997A0", Offset = "0x3E997A0", VA = "0x3E997A0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x3E9B4FC", Offset = "0x3E9B4FC", VA = "0x3E9B4FC")]
			public void Reset()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x3E9E324", Offset = "0x3E9E324", VA = "0x3E9E324")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x3E9AE70", Offset = "0x3E9AE70", VA = "0x3E9AE70")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x3E995E4", Offset = "0x3E995E4", VA = "0x3E995E4")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F215C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10632C4", Offset = "0x10632C4")]
		public LayerMask layers;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063328", Offset = "0x1063328")]
		public float maxStep;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106338C", Offset = "0x106338C")]
		public float heightOffset;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10633F0", Offset = "0x10633F0")]
		public float footSpeed;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063454", Offset = "0x1063454")]
		public float footRadius;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10634B8", Offset = "0x10634B8")]
		public float prediction;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F216C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106351C", Offset = "0x106351C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106351C", Offset = "0x106351C")]
		public float footRotationWeight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10635B8", Offset = "0x10635B8")]
		public float footRotationSpeed;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106361C", Offset = "0x106361C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106361C", Offset = "0x106361C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10636B8", Offset = "0x10636B8")]
		public bool rotateSolver;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106371C", Offset = "0x106371C")]
		public float pelvisSpeed;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063780", Offset = "0x1063780")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063780", Offset = "0x1063780")]
		public float pelvisDamper;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F217C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106381C", Offset = "0x106381C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063880", Offset = "0x1063880")]
		public float liftPelvisWeight;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10638E4", Offset = "0x10638E4")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063948", Offset = "0x1063948")]
		public Quality quality;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10639AC", Offset = "0x10639AC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10639E8", Offset = "0x10639E8")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F218C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1063A24", Offset = "0x1063A24")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1063A60", Offset = "0x1063A60")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1063A9C", Offset = "0x1063A9C")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x1700003E")]
		public Leg[] legs
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x3E9850C", Offset = "0x3E9850C", VA = "0x3E9850C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BAC4", Offset = "0x106BAC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x3E9853C", Offset = "0x3E9853C", VA = "0x3E9853C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BB00", Offset = "0x106BB00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x3E98574", Offset = "0x3E98574", VA = "0x3E98574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BB3C", Offset = "0x106BB3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x3E985A4", Offset = "0x3E985A4", VA = "0x3E985A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BB78", Offset = "0x106BB78")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool isGrounded
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x3E985DC", Offset = "0x3E985DC", VA = "0x3E985DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BBB4", Offset = "0x106BBB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x3E98620", Offset = "0x3E98620", VA = "0x3E98620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BBF0", Offset = "0x106BBF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Transform root
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x3E9866C", Offset = "0x3E9866C", VA = "0x3E9866C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BC2C", Offset = "0x106BC2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x3E9869C", Offset = "0x3E9869C", VA = "0x3E9869C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BC68", Offset = "0x106BC68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x3E986D4", Offset = "0x3E986D4", VA = "0x3E986D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BCA4", Offset = "0x106BCA4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x3E986FC", Offset = "0x3E986FC", VA = "0x3E986FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106BCE0", Offset = "0x106BCE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x3E98768", Offset = "0x3E98768", VA = "0x3E98768")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 up
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x3E8E52C", Offset = "0x3E8E52C", VA = "0x3E8E52C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		private bool useRootRotation
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x3E9B83C", Offset = "0x3E9B83C", VA = "0x3E9B83C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x3E9885C", Offset = "0x3E9885C", VA = "0x3E9885C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x3E99204", Offset = "0x3E99204", VA = "0x3E99204")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x3E8C808", Offset = "0x3E8C808", VA = "0x3E8C808")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x3E8DBBC", Offset = "0x3E8DBBC", VA = "0x3E8DBBC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x3E91E5C", Offset = "0x3E91E5C", VA = "0x3E91E5C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x3E8BDD0", Offset = "0x3E8BDD0", VA = "0x3E8BDD0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x3E99804", Offset = "0x3E99804", VA = "0x3E99804")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x3E9B9C4", Offset = "0x3E9B9C4", VA = "0x3E9B9C4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x3E9BCAC", Offset = "0x3E9BCAC", VA = "0x3E9BCAC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x3E8B750", Offset = "0x3E8B750", VA = "0x3E8B750")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DD8C", Offset = "0x105DD8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DD8C", Offset = "0x105DD8C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverAim solver;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x3E6EBA0", Offset = "0x3E6EBA0", VA = "0x3E6EBA0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BD1C", Offset = "0x106BD1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x3E6EC24", Offset = "0x3E6EC24", VA = "0x3E6EC24", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BD80", Offset = "0x106BD80")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x3E6ECA8", Offset = "0x3E6ECA8", VA = "0x3E6ECA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BDE4", Offset = "0x106BDE4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x3E6ED2C", Offset = "0x3E6ED2C", VA = "0x3E6ED2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BE48", Offset = "0x106BE48")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x3E6EDB0", Offset = "0x3E6EDB0", VA = "0x3E6EDB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BEAC", Offset = "0x106BEAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x3E6EE34", Offset = "0x3E6EE34", VA = "0x3E6EE34", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x3E6EE64", Offset = "0x3E6EE64", VA = "0x3E6EE64")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DE38", Offset = "0x105DE38")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DE38", Offset = "0x105DE38")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x3E73BFC", Offset = "0x3E73BFC", VA = "0x3E73BFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BF10", Offset = "0x106BF10")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x3E73C80", Offset = "0x3E73C80", VA = "0x3E73C80", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BF74", Offset = "0x106BF74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x3E73D04", Offset = "0x3E73D04", VA = "0x3E73D04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106BFD8", Offset = "0x106BFD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x3E73D88", Offset = "0x3E73D88", VA = "0x3E73D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C03C", Offset = "0x106C03C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x3E73E0C", Offset = "0x3E73E0C", VA = "0x3E73E0C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x3E73E3C", Offset = "0x3E73E3C", VA = "0x3E73E3C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DEE4", Offset = "0x105DEE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DEE4", Offset = "0x105DEE4")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x3E7512C", Offset = "0x3E7512C", VA = "0x3E7512C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C0A0", Offset = "0x106C0A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x3E751B0", Offset = "0x3E751B0", VA = "0x3E751B0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C104", Offset = "0x106C104")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x3E75234", Offset = "0x3E75234", VA = "0x3E75234")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C168", Offset = "0x106C168")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x3E752B8", Offset = "0x3E752B8", VA = "0x3E752B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C1CC", Offset = "0x106C1CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x3E7533C", Offset = "0x3E7533C", VA = "0x3E7533C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x3E7536C", Offset = "0x3E7536C", VA = "0x3E7536C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105DF90", Offset = "0x105DF90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105DF90", Offset = "0x105DF90")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14DB")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x3E76358", Offset = "0x3E76358", VA = "0x3E76358", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C230", Offset = "0x106C230")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x3E763DC", Offset = "0x3E763DC", VA = "0x3E763DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C294", Offset = "0x106C294")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x3E76460", Offset = "0x3E76460", VA = "0x3E76460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C2F8", Offset = "0x106C2F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x3E764E4", Offset = "0x3E764E4", VA = "0x3E764E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C35C", Offset = "0x106C35C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x3E76568", Offset = "0x3E76568", VA = "0x3E76568", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x3E76598", Offset = "0x3E76598", VA = "0x3E76598")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E03C", Offset = "0x105E03C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E03C", Offset = "0x105E03C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public BipedReferences references;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F21EC")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x3E8894C", Offset = "0x3E8894C", VA = "0x3E8894C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C3C0", Offset = "0x106C3C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x3E889D0", Offset = "0x3E889D0", VA = "0x3E889D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C424", Offset = "0x106C424")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x3E88A54", Offset = "0x3E88A54", VA = "0x3E88A54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C488", Offset = "0x106C488")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x3E88AD8", Offset = "0x3E88AD8", VA = "0x3E88AD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C4EC", Offset = "0x106C4EC")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x3E88B5C", Offset = "0x3E88B5C", VA = "0x3E88B5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C550", Offset = "0x106C550")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x3E88BE0", Offset = "0x3E88BE0", VA = "0x3E88BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C5B4", Offset = "0x106C5B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x3E88C64", Offset = "0x3E88C64", VA = "0x3E88C64")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x3E88CE4", Offset = "0x3E88CE4", VA = "0x3E88CE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x3E88D14", Offset = "0x3E88D14", VA = "0x3E88D14")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x3E89268", Offset = "0x3E89268", VA = "0x3E89268")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x3E898F8", Offset = "0x3E898F8", VA = "0x3E898F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C618", Offset = "0x106C618")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x3E89960", Offset = "0x3E89960", VA = "0x3E89960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C67C", Offset = "0x106C67C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x3E89B64", Offset = "0x3E89B64", VA = "0x3E89B64")]
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
		[Address(RVA = "0x49C0920", Offset = "0x49C0920", VA = "0x49C0920", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x49C0B2C", Offset = "0x49C0B2C", VA = "0x49C0B2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x49C0F34", Offset = "0x49C0F34", VA = "0x49C0F34", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000397")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000398")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x49C0FD4", Offset = "0x49C0FD4", VA = "0x49C0FD4")]
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
		[Address(RVA = "0x49C843C", Offset = "0x49C843C", VA = "0x49C843C")]
		private void Start()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x49C8530", Offset = "0x49C8530", VA = "0x49C8530")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x49C8638", Offset = "0x49C8638", VA = "0x49C8638")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E0E8", Offset = "0x105E0E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E0E8", Offset = "0x105E0E8")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb solver;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x457BBD4", Offset = "0x457BBD4", VA = "0x457BBD4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C6E0", Offset = "0x106C6E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x457BC58", Offset = "0x457BC58", VA = "0x457BC58", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C744", Offset = "0x106C744")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x457BCDC", Offset = "0x457BCDC", VA = "0x457BCDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C7A8", Offset = "0x106C7A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x457BD60", Offset = "0x457BD60", VA = "0x457BD60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C80C", Offset = "0x106C80C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x457BDE4", Offset = "0x457BDE4", VA = "0x457BDE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x457BE14", Offset = "0x457BE14", VA = "0x457BE14")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E194", Offset = "0x105E194")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E194", Offset = "0x105E194")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x457BEBC", Offset = "0x457BEBC", VA = "0x457BEBC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C870", Offset = "0x106C870")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x457BF40", Offset = "0x457BF40", VA = "0x457BF40", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C8D4", Offset = "0x106C8D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x457BFC4", Offset = "0x457BFC4", VA = "0x457BFC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C938", Offset = "0x106C938")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x457C048", Offset = "0x457C048", VA = "0x457C048")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106C99C", Offset = "0x106C99C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x457C0CC", Offset = "0x457C0CC", VA = "0x457C0CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x457C0FC", Offset = "0x457C0FC", VA = "0x457C0FC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E240", Offset = "0x105E240")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E240", Offset = "0x105E240")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E3")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x458CEAC", Offset = "0x458CEAC", VA = "0x458CEAC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CA00", Offset = "0x106CA00")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x458CF30", Offset = "0x458CF30", VA = "0x458CF30", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CA64", Offset = "0x106CA64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x458CFB4", Offset = "0x458CFB4", VA = "0x458CFB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CAC8", Offset = "0x106CAC8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x458D038", Offset = "0x458D038", VA = "0x458D038")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CB2C", Offset = "0x106CB2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x458D0BC", Offset = "0x458D0BC", VA = "0x458D0BC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x458D0EC", Offset = "0x458D0EC", VA = "0x458D0EC")]
		public TrigonometricIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public FABRIK ik;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F21FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063AD8", Offset = "0x1063AD8")]
		public float pull;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063B20", Offset = "0x1063B20")]
		public float pin;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x3E75414", Offset = "0x3E75414", VA = "0x3E75414")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x3E75618", Offset = "0x3E75618", VA = "0x3E75618")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x3E75670", Offset = "0x3E75670", VA = "0x3E75670")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x3E76014", Offset = "0x3E76014", VA = "0x3E76014")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x3E758BC", Offset = "0x3E758BC", VA = "0x3E758BC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x3E76290", Offset = "0x3E76290", VA = "0x3E76290")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14EB")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F220C")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F3")]
		private bool initiated;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x3E76640", Offset = "0x3E76640", VA = "0x3E76640")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x3E772B0", Offset = "0x3E772B0", VA = "0x3E772B0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x3E776DC", Offset = "0x3E776DC", VA = "0x3E776DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x3E778BC", Offset = "0x3E778BC", VA = "0x3E778BC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068178", Offset = "0x1068178")]
			public Transform transform;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10681DC", Offset = "0x10681DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10681DC", Offset = "0x10681DC")]
			public float weight;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1533")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x3E7E5D0", Offset = "0x3E7E5D0", VA = "0x3E7E5D0")]
			public BendBone()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x3E7E6C0", Offset = "0x3E7E6C0", VA = "0x3E7E6C0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x3E788F8", Offset = "0x3E788F8", VA = "0x3E788F8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x3E79268", Offset = "0x3E79268", VA = "0x3E79268")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063B68", Offset = "0x1063B68")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F221C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1063BCC", Offset = "0x1063BCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063BCC", Offset = "0x1063BCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063BCC", Offset = "0x1063BCC")]
		public float positionWeight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063CB0", Offset = "0x1063CB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063CB0", Offset = "0x1063CB0")]
		public float bodyWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063D4C", Offset = "0x1063D4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063D4C", Offset = "0x1063D4C")]
		public float thighWeight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1063DE8", Offset = "0x1063DE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063DE8", Offset = "0x1063DE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063DE8", Offset = "0x1063DE8")]
		public float rotationWeight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14FB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063ECC", Offset = "0x1063ECC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063ECC", Offset = "0x1063ECC")]
		public float bodyClampWeight;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1063F68", Offset = "0x1063F68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1063F68", Offset = "0x1063F68")]
		public float headClampWeight;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F222C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064004", Offset = "0x1064004")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064004", Offset = "0x1064004")]
		public float bendWeight;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10640A0", Offset = "0x10640A0")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1064104", Offset = "0x1064104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064104", Offset = "0x1064104")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064104", Offset = "0x1064104")]
		public float CCDWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10641E8", Offset = "0x10641E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10641E8", Offset = "0x10641E8")]
		public float roll;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1503")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064284", Offset = "0x1064284")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064284", Offset = "0x1064284")]
		public float damper;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064320", Offset = "0x1064320")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F223C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1064384", Offset = "0x1064384")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064384", Offset = "0x1064384")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064384", Offset = "0x1064384")]
		public float postStretchWeight;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064468", Offset = "0x1064468")]
		public float maxStretch;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10644CC", Offset = "0x10644CC")]
		public float stretchDamper;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064530", Offset = "0x1064530")]
		public bool fixHead;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1064594", Offset = "0x1064594")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10645F8", Offset = "0x10645F8")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F224C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106465C", Offset = "0x106465C")]
		public float chestDirectionWeight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] chestBones;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 offset;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1513")]
		private Vector3 headToBody;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F225C")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151B")]
		private float shoulderDist;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float leftShoulderDist;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F226C")]
		private float rightShoulderDist;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion chestRotation;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1523")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F227C")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152B")]
		private int bendBonesCount;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int ccdBonesCount;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F228C")]
		private int stretchBonesCount;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chestBonesCount;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x3E778EC", Offset = "0x3E778EC", VA = "0x3E778EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x3E77EA4", Offset = "0x3E77EA4", VA = "0x3E77EA4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x3E78968", Offset = "0x3E78968", VA = "0x3E78968")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x3E792D8", Offset = "0x3E792D8", VA = "0x3E792D8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x3E7A840", Offset = "0x3E7A840", VA = "0x3E7A840")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x3E7AF2C", Offset = "0x3E7AF2C", VA = "0x3E7AF2C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x3E7B6DC", Offset = "0x3E7B6DC", VA = "0x3E7B6DC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x3E7D1BC", Offset = "0x3E7D1BC", VA = "0x3E7D1BC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x3E7A1F8", Offset = "0x3E7A1F8", VA = "0x3E7A1F8")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x3E7D63C", Offset = "0x3E7D63C", VA = "0x3E7D63C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x3E7CF54", Offset = "0x3E7CF54", VA = "0x3E7CF54")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x3E7CB1C", Offset = "0x3E7CB1C", VA = "0x3E7CB1C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x3E7DE38", Offset = "0x3E7DE38", VA = "0x3E7DE38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3E7E31C", Offset = "0x3E7E31C", VA = "0x3E7E31C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1553")]
			public float pushElasticity;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float pullElasticity;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F22DC")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10682F0", Offset = "0x10682F0")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106832C", Offset = "0x106832C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x155B")]
			private float crossFade;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float inverseCrossFade;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F22EC")]
			private int chain1Index;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int chain2Index;

			[Token(Token = "0x170000CA")]
			public float nominalDistance
			{
				[Token(Token = "0x6000832")]
				[Address(RVA = "0x3E85F28", Offset = "0x3E85F28", VA = "0x3E85F28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F158", Offset = "0x106F158")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x3E85F58", Offset = "0x3E85F58", VA = "0x3E85F58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F194", Offset = "0x106F194")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public bool isRigid
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x3E85F90", Offset = "0x3E85F90", VA = "0x3E85F90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F1D0", Offset = "0x106F1D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000835")]
				[Address(RVA = "0x3E85FD4", Offset = "0x3E85FD4", VA = "0x3E85FD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F20C", Offset = "0x106F20C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x3E86020", Offset = "0x3E86020", VA = "0x3E86020")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x3E80328", Offset = "0x3E80328", VA = "0x3E80328")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x3E81100", Offset = "0x3E81100", VA = "0x3E81100")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x3E85778", Offset = "0x3E85778", VA = "0x3E85778")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10646A4", Offset = "0x10646A4")]
		public float pin;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F229C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10646EC", Offset = "0x10646EC")]
		public float pull;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064734", Offset = "0x1064734")]
		public float push;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106477C", Offset = "0x106477C")]
		public float pushParent;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10647C8", Offset = "0x10647C8")]
		public float reach;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153B")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F22AC")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1543")]
		private float rootLength;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool initiated;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F22BC")]
		private float length;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float distance;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolver.Point p;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float reachForce;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154B")]
		private float pullParentSum;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float[] crossFades;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F22CC")]
		private float sqrMag1;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sqrMag2;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sqrMagDif;

		[Token(Token = "0x4000402")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x3E7E7E0", Offset = "0x3E7E7E0", VA = "0x3E7E7E0")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3E7E964", Offset = "0x3E7E964", VA = "0x3E7E964")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x3E7EB54", Offset = "0x3E7EB54", VA = "0x3E7EB54")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x3E7ED14", Offset = "0x3E7ED14", VA = "0x3E7ED14")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x3E7EEF8", Offset = "0x3E7EEF8", VA = "0x3E7EEF8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x3E7F1B8", Offset = "0x3E7F1B8", VA = "0x3E7F1B8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x3E803E4", Offset = "0x3E803E4", VA = "0x3E803E4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x3E7F5C4", Offset = "0x3E7F5C4", VA = "0x3E7F5C4")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x3E81654", Offset = "0x3E81654", VA = "0x3E81654")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x3E82034", Offset = "0x3E82034", VA = "0x3E82034")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x3E82B74", Offset = "0x3E82B74", VA = "0x3E82B74")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3E838D0", Offset = "0x3E838D0", VA = "0x3E838D0")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x3E8490C", Offset = "0x3E8490C", VA = "0x3E8490C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x3E85010", Offset = "0x3E85010", VA = "0x3E85010")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x3E846FC", Offset = "0x3E846FC", VA = "0x3E846FC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x3E83464", Offset = "0x3E83464", VA = "0x3E83464")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x3E84608", Offset = "0x3E84608", VA = "0x3E84608")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x3E852C8", Offset = "0x3E852C8", VA = "0x3E852C8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x3E84338", Offset = "0x3E84338", VA = "0x3E84338")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x3E84C68", Offset = "0x3E84C68", VA = "0x3E84C68")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F22FC")]
		public Transform bone1;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone2;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone3;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bendGoal;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x156B")]
		public Vector3 direction;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F230C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064810", Offset = "0x1064810")]
		public float weight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float clampF;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1573")]
		private int chainIndex1;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int nodeIndex1;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F231C")]
		private int chainIndex2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex2;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chainIndex3;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex3;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x157B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1064858", Offset = "0x1064858")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000046")]
		public bool initiated
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x49C15E0", Offset = "0x49C15E0", VA = "0x49C15E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CB90", Offset = "0x106CB90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x49C1624", Offset = "0x49C1624", VA = "0x49C1624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CBCC", Offset = "0x106CBCC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x49C1004", Offset = "0x49C1004", VA = "0x49C1004")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x49C1670", Offset = "0x49C1670", VA = "0x49C1670")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x49C1764", Offset = "0x49C1764", VA = "0x49C1764")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x49C1894", Offset = "0x49C1894", VA = "0x49C1894")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x49C18FC", Offset = "0x49C18FC", VA = "0x49C18FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x49C2498", Offset = "0x49C2498", VA = "0x49C2498")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x49C2938", Offset = "0x49C2938", VA = "0x49C2938")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x49C3390", Offset = "0x49C3390", VA = "0x49C3390")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x49C2088", Offset = "0x49C2088", VA = "0x49C2088")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x49C2290", Offset = "0x49C2290", VA = "0x49C2290")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bone;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F232C")]
		public Transform target;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064894", Offset = "0x1064894")]
		public float positionWeight;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10648DC", Offset = "0x10648DC")]
		public float rotationWeight;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1583")]
		public Quaternion rotation;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 positionOffset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F233C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1064924", Offset = "0x1064924")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool effectChildNodes;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064960", Offset = "0x1064960")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] childBones;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158B")]
		public Transform planeBone1;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform planeBone2;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F234C")]
		public Transform planeBone3;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float posW;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float rotW;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1593")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F235C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool firstUpdate;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chainIndex;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159B")]
		private int nodeIndex;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int plane1ChainIndex;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F236C")]
		private int plane1NodeIndex;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2ChainIndex;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A3")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F237C")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000047")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x49C4414", Offset = "0x49C4414", VA = "0x49C4414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CC08", Offset = "0x106CC08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x49C4458", Offset = "0x49C4458", VA = "0x49C4458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CC44", Offset = "0x106CC44")]
			private set
			{
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x49C4354", Offset = "0x49C4354", VA = "0x49C4354")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x49C44A4", Offset = "0x49C44A4", VA = "0x49C44A4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x49C4650", Offset = "0x49C4650", VA = "0x49C4650")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x49C4928", Offset = "0x49C4928", VA = "0x49C4928")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x49C4C38", Offset = "0x49C4C38", VA = "0x49C4C38")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x49C5634", Offset = "0x49C5634", VA = "0x49C5634")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x49C5CD8", Offset = "0x49C5CD8", VA = "0x49C5CD8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x49C5F88", Offset = "0x49C5F88", VA = "0x49C5F88")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x49C610C", Offset = "0x49C610C", VA = "0x49C610C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x49C7084", Offset = "0x49C7084", VA = "0x49C7084")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x49C7158", Offset = "0x49C7158", VA = "0x49C7158")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x49C7634", Offset = "0x49C7634", VA = "0x49C7634")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x49C7D14", Offset = "0x49C7D14", VA = "0x49C7D14")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int chainIndex;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nodeIndex;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15AB")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F238C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 planePosition;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 ikPosition;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15B3")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F239C")]
			public float length;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Transform planeBone1;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Transform planeBone2;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15BB")]
			private Transform planeBone3;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int plane1ChainIndex;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F23AC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2NodeIndex;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane3ChainIndex;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C3")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000CC")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600083B")]
				[Address(RVA = "0x49C8C98", Offset = "0x49C8C98", VA = "0x49C8C98")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CD")]
			public bool isNodeBone
			{
				[Token(Token = "0x600083E")]
				[Address(RVA = "0x49C8F88", Offset = "0x49C8F88", VA = "0x49C8F88")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CE")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000852")]
				[Address(RVA = "0x49C9B30", Offset = "0x49C9B30", VA = "0x49C9B30")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x49C8C0C", Offset = "0x49C8C0C", VA = "0x49C8C0C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x49C8DD4", Offset = "0x49C8DD4", VA = "0x49C8DD4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x49C8E98", Offset = "0x49C8E98", VA = "0x49C8E98")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x49C9010", Offset = "0x49C9010", VA = "0x49C9010")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x49C9174", Offset = "0x49C9174", VA = "0x49C9174")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x49C91B8", Offset = "0x49C91B8", VA = "0x49C91B8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x49C9460", Offset = "0x49C9460", VA = "0x49C9460")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x49C9654", Offset = "0x49C9654", VA = "0x49C9654")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x49C97C4", Offset = "0x49C97C4", VA = "0x49C97C4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x49C9F50", Offset = "0x49C9F50", VA = "0x49C9F50")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x49C9FC0", Offset = "0x49C9FC0", VA = "0x49C9FC0")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x49CA030", Offset = "0x49CA030", VA = "0x49CA030")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x49CA0A0", Offset = "0x49CA0A0", VA = "0x49CA0A0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x49CA334", Offset = "0x49CA334", VA = "0x49CA334")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x49CAA3C", Offset = "0x49CAA3C", VA = "0x49CAA3C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x49CAAC4", Offset = "0x49CAAC4", VA = "0x49CAAC4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x49CADB4", Offset = "0x49CADB4", VA = "0x49CADB4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x49CAE74", Offset = "0x49CAE74", VA = "0x49CAE74")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x49CB310", Offset = "0x49CB310", VA = "0x49CB310")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x49CB75C", Offset = "0x49CB75C", VA = "0x49CB75C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x49CB910", Offset = "0x49CB910", VA = "0x49CB910")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x49CA568", Offset = "0x49CA568", VA = "0x49CA568")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x49CBC80", Offset = "0x49CBC80", VA = "0x49CBC80")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x49C8668", Offset = "0x49C8668", VA = "0x49C8668", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x49C8694", Offset = "0x49C8694", VA = "0x49C8694", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x49C86AC", Offset = "0x49C86AC", VA = "0x49C86AC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x49C89CC", Offset = "0x49C89CC", VA = "0x49C89CC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x49C8BDC", Offset = "0x49C8BDC", VA = "0x49C8BDC")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bone;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F23BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10649A8", Offset = "0x10649A8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x49CBD1C", Offset = "0x49CBD1C", VA = "0x49CBD1C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x49CBEFC", Offset = "0x49CBEFC", VA = "0x49CBEFC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x49CBFB4", Offset = "0x49CBFB4", VA = "0x49CBFB4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x49CC084", Offset = "0x49CC084", VA = "0x49CC084")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x49CC0CC", Offset = "0x49CC0CC", VA = "0x49CC0CC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x49CC124", Offset = "0x49CC124", VA = "0x49CC124", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x49CC230", Offset = "0x49CC230", VA = "0x49CC230")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x49CC278", Offset = "0x49CC278", VA = "0x49CC278")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform parentBone;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone1;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15CB")]
		public Transform bone2;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bone3;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F23CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10649F0", Offset = "0x10649F0")]
		public float maintainRotationWeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064A38", Offset = "0x1064A38")]
		public float weight;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap1;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D3")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x49CC2EC", Offset = "0x49CC2EC", VA = "0x49CC2EC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x49CC4F0", Offset = "0x49CC4F0", VA = "0x49CC4F0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x49CC704", Offset = "0x49CC704", VA = "0x49CC704")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x49CCD9C", Offset = "0x49CCD9C", VA = "0x49CCD9C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x49CCECC", Offset = "0x49CCECC", VA = "0x49CCECC")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x49CD048", Offset = "0x49CD048", VA = "0x49CD048")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x49CD0C8", Offset = "0x49CD0C8", VA = "0x49CD0C8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x49CD260", Offset = "0x49CD260", VA = "0x49CD260")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x49CD430", Offset = "0x49CD430", VA = "0x49CD430", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x49CD994", Offset = "0x49CD994", VA = "0x49CD994")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x49CDB40", Offset = "0x49CDB40", VA = "0x49CDB40")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform[] spineBones;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F23EC")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftThighBone;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightThighBone;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E3")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064A80", Offset = "0x1064A80")]
		public int iterations;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064ACC", Offset = "0x1064ACC")]
		public float twistWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F23FC")]
		private int rootNodeIndex;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap[] spine;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15EB")]
		private BoneMap leftThigh;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneMap rightThigh;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F240C")]
		private bool useFABRIK;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x49CDEEC", Offset = "0x49CDEEC", VA = "0x49CDEEC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x49CE928", Offset = "0x49CE928", VA = "0x49CE928")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x49CEAA4", Offset = "0x49CEAA4", VA = "0x49CEAA4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x49CEC7C", Offset = "0x49CEC7C", VA = "0x49CEC7C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x49CED14", Offset = "0x49CED14", VA = "0x49CED14")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x49CEDF8", Offset = "0x49CEDF8", VA = "0x49CEDF8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x49CEFB8", Offset = "0x49CEFB8", VA = "0x49CEFB8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x49CFFA4", Offset = "0x49CFFA4", VA = "0x49CFFA4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x49D007C", Offset = "0x49D007C", VA = "0x49D007C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x49D0690", Offset = "0x49D0690", VA = "0x49D0690")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x49D0FC0", Offset = "0x49D0FC0", VA = "0x49D0FC0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x49D1290", Offset = "0x49D1290", VA = "0x49D1290")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x49D1550", Offset = "0x49D1550", VA = "0x49D1550")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x15FB")]
			public Transform transform;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1068368", Offset = "0x1068368")]
			public float weight;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F242C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x49D5B74", Offset = "0x49D5B74", VA = "0x49D5B74")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x49D5C38", Offset = "0x49D5C38", VA = "0x49D5C38")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x49D5F14", Offset = "0x49D5F14", VA = "0x49D5F14")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x49D5F84", Offset = "0x49D5F84", VA = "0x49D5F84")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x49D5FF4", Offset = "0x49D5FF4", VA = "0x49D5FF4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x49D60B8", Offset = "0x49D60B8", VA = "0x49D60B8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x49D52FC", Offset = "0x49D52FC", VA = "0x49D52FC")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000126")]
		public class Bone : Point
		{
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1603")]
			public float length;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float sqrMag;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F243C")]
			public Vector3 axis;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool isLimited;

			[Token(Token = "0x170000CF")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0x49D392C", Offset = "0x49D392C", VA = "0x49D392C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x49D3B74", Offset = "0x49D3B74", VA = "0x49D3B74")]
				set
				{
				}
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x49D3CA4", Offset = "0x49D3CA4", VA = "0x49D3CA4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x49D4224", Offset = "0x49D4224", VA = "0x49D4224")]
			public void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x49D48C0", Offset = "0x49D48C0", VA = "0x49D48C0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x49D4D80", Offset = "0x49D4D80", VA = "0x49D4D80")]
			public Quaternion GetSolverSwing(Vector3 swingTarget, float weight = 1f)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x49D516C", Offset = "0x49D516C", VA = "0x49D516C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x49D51DC", Offset = "0x49D51DC", VA = "0x49D51DC")]
			public Bone()
			{
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x49D53EC", Offset = "0x49D53EC", VA = "0x49D53EC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x49D5524", Offset = "0x49D5524", VA = "0x49D5524")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000127")]
		public class Node : Point
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float length;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160B")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F244C")]
			public Vector3 offset;

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x49D5A9C", Offset = "0x49D5A9C", VA = "0x49D5A9C")]
			public Node()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x49D5ACC", Offset = "0x49D5ACC", VA = "0x49D5ACC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x49D5B14", Offset = "0x49D5B14", VA = "0x49D5B14")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064B50", Offset = "0x1064B50")]
		public float IKPositionWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1064B98", Offset = "0x1064B98")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F3")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F241C")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool firstInitiation;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000048")]
		public bool initiated
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x49D21E4", Offset = "0x49D21E4", VA = "0x49D21E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CC80", Offset = "0x106CC80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x49D2228", Offset = "0x49D2228", VA = "0x49D2228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CCBC", Offset = "0x106CCBC")]
			private set
			{
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x49D1C9C", Offset = "0x49D1C9C", VA = "0x49D1C9C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x49C0BD0", Offset = "0x49C0BD0", VA = "0x49C0BD0")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x49C0A00", Offset = "0x49C0A00", VA = "0x49C0A00")]
		public void Update()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x49D1FC8", Offset = "0x49D1FC8", VA = "0x49D1FC8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x49D2008", Offset = "0x49D2008", VA = "0x49D2008")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x49D2068", Offset = "0x49D2068", VA = "0x49D2068")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x49D2098", Offset = "0x49D2098", VA = "0x49D2098")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x49D21B4", Offset = "0x49D21B4", VA = "0x49D21B4")]
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
		[Address(RVA = "0x49D2274", Offset = "0x49D2274", VA = "0x49D2274")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x49D22D4", Offset = "0x49D22D4", VA = "0x49D22D4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x49D25C8", Offset = "0x49D25C8", VA = "0x49D25C8")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x49D275C", Offset = "0x49D275C", VA = "0x49D275C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x49D328C", Offset = "0x49D328C", VA = "0x49D328C")]
		public static void SolverRotateBonesAroundPoint(Bone[] bones, int index, Vector3 point, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x49D3730", Offset = "0x49D3730", VA = "0x49D3730")]
		public static void SolverRotate(Bone[] bones, int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x49D38D0", Offset = "0x49D38D0", VA = "0x49D38D0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 axis;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 poleAxis;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1613")]
		public Vector3 polePosition;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064C30", Offset = "0x1064C30")]
		public float poleWeight;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F245C")]
		public Transform poleTarget;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064C78", Offset = "0x1064C78")]
		public float clampWeight;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064CC0", Offset = "0x1064CC0")]
		public int clampSmoothing;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161B")]
		private float step;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F246C")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lastTransform;

		[Token(Token = "0x17000049")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x49D640C", Offset = "0x49D640C", VA = "0x49D640C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x49D6548", Offset = "0x49D6548", VA = "0x49D6548")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		protected override int minBones
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x49D85AC", Offset = "0x49D85AC", VA = "0x49D85AC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x49D93C4", Offset = "0x49D93C4", VA = "0x49D93C4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x49D6278", Offset = "0x49D6278", VA = "0x49D6278")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x49D6684", Offset = "0x49D6684", VA = "0x49D6684", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x49D6C10", Offset = "0x49D6C10", VA = "0x49D6C10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x49D82A4", Offset = "0x49D82A4", VA = "0x49D82A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x49D79CC", Offset = "0x49D79CC", VA = "0x49D79CC")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x49D85C8", Offset = "0x49D85C8", VA = "0x49D85C8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x49D94F0", Offset = "0x49D94F0", VA = "0x49D94F0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x49D96F8", Offset = "0x49D96F8", VA = "0x49D96F8")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x49D9914", Offset = "0x49D9914", VA = "0x49D9914", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x49DA5DC", Offset = "0x49DA5DC", VA = "0x49DA5DC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x49DB6D0", Offset = "0x49DB6D0", VA = "0x49DB6D0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x49DC7B8", Offset = "0x49DC7B8", VA = "0x49DC7B8")]
		public static void SolveVirtual(Bone[] bones, Vector3 targetPosition, float weight)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x49DCD98", Offset = "0x49DCD98", VA = "0x49DCD98")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1623")]
		private bool[] limitedBones;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x49DF7AC", Offset = "0x49DF7AC", VA = "0x49DF7AC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x49DCDC8", Offset = "0x49DCDC8", VA = "0x49DCDC8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x49DDE80", Offset = "0x49DDE80", VA = "0x49DDE80")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x49DE108", Offset = "0x49DE108", VA = "0x49DE108", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x49DE234", Offset = "0x49DE234", VA = "0x49DE234", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x49DEDFC", Offset = "0x49DEDFC", VA = "0x49DEDFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x49DF7D0", Offset = "0x49DF7D0", VA = "0x49DF7D0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x49DCEE4", Offset = "0x49DCEE4", VA = "0x49DCEE4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x49DE06C", Offset = "0x49DE06C", VA = "0x49DE06C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x49DF6BC", Offset = "0x49DF6BC", VA = "0x49DF6BC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x49DD954", Offset = "0x49DD954", VA = "0x49DD954")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x49E0EE4", Offset = "0x49E0EE4", VA = "0x49E0EE4")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x49E10E8", Offset = "0x49E10E8", VA = "0x49E10E8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x49E1350", Offset = "0x49E1350", VA = "0x49E1350")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x49E1584", Offset = "0x49E1584", VA = "0x49E1584")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x49DE8CC", Offset = "0x49DE8CC", VA = "0x49DE8CC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x49DEB6C", Offset = "0x49DEB6C", VA = "0x49DEB6C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x49E1974", Offset = "0x49E1974", VA = "0x49E1974")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x49DFFA0", Offset = "0x49DFFA0", VA = "0x49DFFA0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x49DDFA0", Offset = "0x49DDFA0", VA = "0x49DDFA0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x49E2ACC", Offset = "0x49E2ACC", VA = "0x49E2ACC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x49E1CB0", Offset = "0x49E1CB0", VA = "0x49E1CB0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x49DFA2C", Offset = "0x49DFA2C", VA = "0x49DFA2C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x49DFD34", Offset = "0x49DFD34", VA = "0x49DFD34")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x49E2D8C", Offset = "0x49E2D8C", VA = "0x49E2D8C")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F247C")]
		public int iterations;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064D08", Offset = "0x1064D08")]
		public float rootPin;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162B")]
		private bool[] isRoot;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x49E2E60", Offset = "0x49E2E60", VA = "0x49E2E60", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x49E4330", Offset = "0x49E4330", VA = "0x49E4330", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x49E4480", Offset = "0x49E4480", VA = "0x49E4480", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x49E45D0", Offset = "0x49E45D0", VA = "0x49E45D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x49E4808", Offset = "0x49E4808", VA = "0x49E4808")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x49E4A0C", Offset = "0x49E4A0C", VA = "0x49E4A0C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x49E56D0", Offset = "0x49E56D0", VA = "0x49E56D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x49E5B08", Offset = "0x49E5B08", VA = "0x49E5B08", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x49E5840", Offset = "0x49E5840", VA = "0x49E5840")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x49E502C", Offset = "0x49E502C", VA = "0x49E502C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x49E5C7C", Offset = "0x49E5C7C", VA = "0x49E5C7C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F248C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064D50", Offset = "0x1064D50")]
		public int iterations;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1633")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F249C")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163B")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F24AC")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x49E5D34", Offset = "0x49E5D34", VA = "0x49E5D34")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x49E5F54", Offset = "0x49E5F54", VA = "0x49E5F54")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x49E6028", Offset = "0x49E6028", VA = "0x49E6028")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x49C42A8", Offset = "0x49C42A8", VA = "0x49C42A8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x49C1F4C", Offset = "0x49C1F4C", VA = "0x49C1F4C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x49E62F8", Offset = "0x49E62F8", VA = "0x49E62F8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x49E6674", Offset = "0x49E6674", VA = "0x49E6674", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x49E69CC", Offset = "0x49E69CC", VA = "0x49E69CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x49E6FCC", Offset = "0x49E6FCC", VA = "0x49E6FCC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x49E71D8", Offset = "0x49E71D8", VA = "0x49E71D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x49E7418", Offset = "0x49E7418", VA = "0x49E7418", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x49E77BC", Offset = "0x49E77BC", VA = "0x49E77BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x49E7BA8", Offset = "0x49E7BA8", VA = "0x49E7BA8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x49E8230", Offset = "0x49E8230", VA = "0x49E8230", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x49E8A5C", Offset = "0x49E8A5C", VA = "0x49E8A5C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x49E8ADC", Offset = "0x49E8ADC", VA = "0x49E8ADC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x49E8D54", Offset = "0x49E8D54", VA = "0x49E8D54")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rootNode;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F24DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064D98", Offset = "0x1064D98")]
		public float spineStiffness;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064DE0", Offset = "0x1064DE0")]
		public float pullBodyVertical;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064E2C", Offset = "0x1064E2C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1064E78", Offset = "0x1064E78")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165B")]
		private Vector3 offset;

		[Token(Token = "0x1700004E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x49E8EC0", Offset = "0x49E8EC0", VA = "0x49E8EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x49E8F00", Offset = "0x49E8F00", VA = "0x49E8F00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x49E8F40", Offset = "0x49E8F40", VA = "0x49E8F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x49E8F80", Offset = "0x49E8F80", VA = "0x49E8F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x49E8FC0", Offset = "0x49E8FC0", VA = "0x49E8FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x49E9000", Offset = "0x49E9000", VA = "0x49E9000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x49E9040", Offset = "0x49E9040", VA = "0x49E9040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x49E9080", Offset = "0x49E9080", VA = "0x49E9080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x49E90C0", Offset = "0x49E90C0", VA = "0x49E90C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x49E9100", Offset = "0x49E9100", VA = "0x49E9100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x49E9160", Offset = "0x49E9160", VA = "0x49E9160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x49E91C0", Offset = "0x49E91C0", VA = "0x49E91C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x49E9220", Offset = "0x49E9220", VA = "0x49E9220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x49E9280", Offset = "0x49E9280", VA = "0x49E9280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x49E92D4", Offset = "0x49E92D4", VA = "0x49E92D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x49E9334", Offset = "0x49E9334", VA = "0x49E9334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x49E9394", Offset = "0x49E9394", VA = "0x49E9394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x49E93F4", Offset = "0x49E93F4", VA = "0x49E93F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x49EE23C", Offset = "0x49EE23C", VA = "0x49EE23C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CCF8", Offset = "0x106CCF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x49EE27C", Offset = "0x49EE27C", VA = "0x49EE27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CD34", Offset = "0x106CD34")]
			private set
			{
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x49E9448", Offset = "0x49E9448", VA = "0x49E9448")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x49E96BC", Offset = "0x49E96BC", VA = "0x49E96BC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x49E94EC", Offset = "0x49E94EC", VA = "0x49E94EC")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x49E9858", Offset = "0x49E9858", VA = "0x49E9858")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x49C0530", Offset = "0x49C0530", VA = "0x49C0530")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x49E9C18", Offset = "0x49E9C18", VA = "0x49E9C18")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x49E9DE8", Offset = "0x49E9DE8", VA = "0x49E9DE8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x49E9FAC", Offset = "0x49E9FAC", VA = "0x49E9FAC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x49EA308", Offset = "0x49EA308", VA = "0x49EA308")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x49EA338", Offset = "0x49EA338", VA = "0x49EA338")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x49EA38C", Offset = "0x49EA38C", VA = "0x49EA38C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x49EA5AC", Offset = "0x49EA5AC", VA = "0x49EA5AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x49EAAF4", Offset = "0x49EAAF4", VA = "0x49EAAF4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x49ECFFC", Offset = "0x49ECFFC", VA = "0x49ECFFC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x49EDBC4", Offset = "0x49EDBC4", VA = "0x49EDBC4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x49EDCD0", Offset = "0x49EDCD0", VA = "0x49EDCD0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x49ED7BC", Offset = "0x49ED7BC", VA = "0x49ED7BC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x49ED9C0", Offset = "0x49ED9C0", VA = "0x49ED9C0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x49EE2DC", Offset = "0x49EE2DC", VA = "0x49EE2DC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x49EE4D8", Offset = "0x49EE4D8", VA = "0x49EE4D8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x49EE828", Offset = "0x49EE828", VA = "0x49EE828")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x49EEBEC", Offset = "0x49EEBEC", VA = "0x49EEBEC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x49EEF90", Offset = "0x49EEF90", VA = "0x49EEF90")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x49EF420", Offset = "0x49EF420", VA = "0x49EF420", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x49EFBAC", Offset = "0x49EFBAC", VA = "0x49EFBAC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x49EFD74", Offset = "0x49EFD74", VA = "0x49EFD74")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform target;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F24EC")]
		public float tolerance;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int maxIterations;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useRotationLimits;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool XY;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1663")]
		public Bone[] bones;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F24FC")]
		protected float chainLength;

		[Token(Token = "0x17000061")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x49F0FC0", Offset = "0x49F0FC0", VA = "0x49F0FC0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x49F0FDC", Offset = "0x49F0FDC", VA = "0x49F0FDC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x49F1000", Offset = "0x49F1000", VA = "0x49F1000", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x49F104C", Offset = "0x49F104C", VA = "0x49F104C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000065")]
		protected float positionOffset
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x49DB588", Offset = "0x49DB588", VA = "0x49DB588")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x49EFDC8", Offset = "0x49EFDC8", VA = "0x49EFDC8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x49F0154", Offset = "0x49F0154", VA = "0x49F0154")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x49F03D4", Offset = "0x49F03D4", VA = "0x49F03D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x49F04B8", Offset = "0x49F04B8", VA = "0x49F04B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x49F05D0", Offset = "0x49F05D0", VA = "0x49F05D0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x49F0D58", Offset = "0x49F0D58", VA = "0x49F0D58", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x49F0DA0", Offset = "0x49F0DA0", VA = "0x49F0DA0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x49F1024", Offset = "0x49F1024", VA = "0x49F1024", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x49F1038", Offset = "0x49F1038", VA = "0x49F1038", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x49D9A2C", Offset = "0x49D9A2C", VA = "0x49D9A2C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x49DADF8", Offset = "0x49DADF8", VA = "0x49DADF8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x49F12B4", Offset = "0x49F12B4", VA = "0x49F12B4")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x49D9628", Offset = "0x49D9628", VA = "0x49D9628")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Vector3 direction;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F252C")]
			public Vector3 axis;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float dot;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x4557F30", Offset = "0x4557F30", VA = "0x4557F30")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BendModifier bendModifier;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064EB4", Offset = "0x1064EB4")]
		public float maintainRotationWeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x166B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064EFC", Offset = "0x1064EFC")]
		public float bendModifierWeight;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bendGoal;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F250C")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1673")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F251C")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167B")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000066")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x49F474C", Offset = "0x49F474C", VA = "0x49F474C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x49F18E0", Offset = "0x49F18E0", VA = "0x49F18E0")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x49F19A0", Offset = "0x49F19A0", VA = "0x49F19A0")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x49F1A4C", Offset = "0x49F1A4C", VA = "0x49F1A4C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x49F268C", Offset = "0x49F268C", VA = "0x49F268C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x49F4324", Offset = "0x49F4324", VA = "0x49F4324", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x49F4584", Offset = "0x49F4584", VA = "0x49F4584")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x49F465C", Offset = "0x49F465C", VA = "0x49F465C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x49F21F4", Offset = "0x49F21F4", VA = "0x49F21F4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x49F2970", Offset = "0x49F2970", VA = "0x49F2970")]
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
				[Address(RVA = "0x455C964", Offset = "0x455C964", VA = "0x455C964")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x455D984", Offset = "0x455D984", VA = "0x455D984")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x455AB9C", Offset = "0x455AB9C", VA = "0x455AB9C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x455B5F8", Offset = "0x455B5F8", VA = "0x455B5F8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x455D39C", Offset = "0x455D39C", VA = "0x455D39C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168B")]
		public LookAtBone head;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F254C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064F44", Offset = "0x1064F44")]
		public float bodyWeight;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064F8C", Offset = "0x1064F8C")]
		public float headWeight;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1064FD4", Offset = "0x1064FD4")]
		public float eyesWeight;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106501C", Offset = "0x106501C")]
		public float clampWeight;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1693")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1065064", Offset = "0x1065064")]
		public float clampWeightHead;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10650AC", Offset = "0x10650AC")]
		public float clampWeightEyes;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F255C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10650F4", Offset = "0x10650F4")]
		public int clampSmoothing;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] headForwards;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169B")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000067")]
		private bool spineIsValid
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x4559544", Offset = "0x4559544", VA = "0x4559544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x4559B58", Offset = "0x4559B58", VA = "0x4559B58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private bool headIsValid
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x455980C", Offset = "0x455980C", VA = "0x455980C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x4559BD4", Offset = "0x4559BD4", VA = "0x4559BD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x4559890", Offset = "0x4559890", VA = "0x4559890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4559D04", Offset = "0x4559D04", VA = "0x4559D04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x4557FF0", Offset = "0x4557FF0", VA = "0x4557FF0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x455810C", Offset = "0x455810C", VA = "0x455810C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x455825C", Offset = "0x455825C", VA = "0x455825C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x45583DC", Offset = "0x45583DC", VA = "0x45583DC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x455858C", Offset = "0x455858C", VA = "0x455858C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x455879C", Offset = "0x455879C", VA = "0x455879C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x45589DC", Offset = "0x45589DC", VA = "0x45589DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4558CCC", Offset = "0x4558CCC", VA = "0x4558CCC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4558FF0", Offset = "0x4558FF0", VA = "0x4558FF0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4559D80", Offset = "0x4559D80", VA = "0x4559D80", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x455A2F0", Offset = "0x455A2F0", VA = "0x455A2F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x455A758", Offset = "0x455A758", VA = "0x455A758")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x455ABE4", Offset = "0x455ABE4", VA = "0x455ABE4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x455B820", Offset = "0x455B820", VA = "0x455B820", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x455BA18", Offset = "0x455BA18", VA = "0x455BA18")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x455BE74", Offset = "0x455BE74", VA = "0x455BE74")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x455C444", Offset = "0x455C444", VA = "0x455C444")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x455CAA0", Offset = "0x455CAA0", VA = "0x455CAA0")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x455A8A0", Offset = "0x455A8A0", VA = "0x455A8A0")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x455D620", Offset = "0x455D620", VA = "0x455D620")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x4561CFC", Offset = "0x4561CFC", VA = "0x4561CFC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x4563914", Offset = "0x4563914", VA = "0x4563914")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x456316C", Offset = "0x456316C", VA = "0x456316C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x4563C6C", Offset = "0x4563C6C", VA = "0x4563C6C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform target;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F256C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106513C", Offset = "0x106513C")]
		public float IKRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 bendNormal;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A3")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F257C")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool directHierarchy;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x455D9B4", Offset = "0x455D9B4", VA = "0x455D9B4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x455DE30", Offset = "0x455DE30", VA = "0x455DE30")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x455E1C8", Offset = "0x455E1C8", VA = "0x455E1C8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x455E2F8", Offset = "0x455E2F8", VA = "0x455E2F8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x455E414", Offset = "0x455E414", VA = "0x455E414")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x455E45C", Offset = "0x455E45C", VA = "0x455E45C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x455E48C", Offset = "0x455E48C", VA = "0x455E48C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x455E5D4", Offset = "0x455E5D4", VA = "0x455E5D4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x455E8D0", Offset = "0x455E8D0", VA = "0x455E8D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x455E958", Offset = "0x455E958", VA = "0x455E958", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x455E9E0", Offset = "0x455E9E0", VA = "0x455E9E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x455F150", Offset = "0x455F150", VA = "0x455F150")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x455F240", Offset = "0x455F240", VA = "0x455F240")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4560080", Offset = "0x4560080", VA = "0x4560080")]
		public static void SolveVirtual(Bone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4560C30", Offset = "0x4560C30", VA = "0x4560C30")]
		public static void SolveVirtualPositions(Bone bone1, Bone bone2, Bone bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x455FBF0", Offset = "0x455FBF0", VA = "0x455FBF0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x45615FC", Offset = "0x45615FC", VA = "0x45615FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4561A70", Offset = "0x4561A70", VA = "0x4561A70")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x45618E8", Offset = "0x45618E8", VA = "0x45618E8")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x456208C", Offset = "0x456208C", VA = "0x456208C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4563AB0", Offset = "0x4563AB0", VA = "0x4563AB0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4563AC4", Offset = "0x4563AC4", VA = "0x4563AC4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4563AD8", Offset = "0x4563AD8", VA = "0x4563AD8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x45632A8", Offset = "0x45632A8", VA = "0x45632A8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4563AEC", Offset = "0x4563AEC", VA = "0x4563AEC")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16AB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065184", Offset = "0x1065184")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1065184", Offset = "0x1065184")]
		public float weight;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065220", Offset = "0x1065220")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1065220", Offset = "0x1065220")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F258C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10652BC", Offset = "0x10652BC")]
		public Transform parent;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065320", Offset = "0x1065320")]
		public Transform child;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065384", Offset = "0x1065384")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10653E8", Offset = "0x10653E8")]
		public Vector3 axis;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B3")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x458D194", Offset = "0x458D194", VA = "0x458D194")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x458D96C", Offset = "0x458D96C", VA = "0x458D96C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x458DC98", Offset = "0x458DC98", VA = "0x458DC98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x458DCC8", Offset = "0x458DCC8", VA = "0x458DCC8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class InteractionEffector
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F259C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106544C", Offset = "0x106544C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1065488", Offset = "0x1065488")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10654C4", Offset = "0x10654C4")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poser;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16BB")]
		private IKEffector effector;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float timer;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F25AC")]
		private float length;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weight;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float fadeInSpeed;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C3")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float defaultPull;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F25BC")]
		private float defaultReach;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPush;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPushParent;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float resetTimer;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16CB")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F25CC")]
		private bool pullUsed;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool reachUsed;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pushUsed;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pushParentUsed;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D3")]
		private bool pickedUp;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool defaults;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F25DC")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16DB")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F25EC")]
		private Transform target;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<bool> triggered;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool started;

		[Token(Token = "0x1700006D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x4564DB4", Offset = "0x4564DB4", VA = "0x4564DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CD70", Offset = "0x106CD70")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x4564DE4", Offset = "0x4564DE4", VA = "0x4564DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CDAC", Offset = "0x106CDAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isPaused
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x4564E1C", Offset = "0x4564E1C", VA = "0x4564E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CDE8", Offset = "0x106CDE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x4564E60", Offset = "0x4564E60", VA = "0x4564E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CE24", Offset = "0x106CE24")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x4564EAC", Offset = "0x4564EAC", VA = "0x4564EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CE60", Offset = "0x106CE60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x4564EDC", Offset = "0x4564EDC", VA = "0x4564EDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106CE9C", Offset = "0x106CE9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool inInteraction
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x4564F14", Offset = "0x4564F14", VA = "0x4564F14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public float progress
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x456B830", Offset = "0x456B830", VA = "0x456B830")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x4565034", Offset = "0x4565034", VA = "0x4565034")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4565108", Offset = "0x4565108", VA = "0x4565108")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4565284", Offset = "0x4565284", VA = "0x4565284")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4565680", Offset = "0x4565680", VA = "0x4565680")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x456624C", Offset = "0x456624C", VA = "0x456624C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4566898", Offset = "0x4566898", VA = "0x4566898")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x45669CC", Offset = "0x45669CC", VA = "0x45669CC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4568600", Offset = "0x4568600", VA = "0x4568600")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x456A0EC", Offset = "0x456A0EC", VA = "0x456A0EC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x456A958", Offset = "0x456A958", VA = "0x456A958")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x456B420", Offset = "0x456B420", VA = "0x456B420")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x456C09C", Offset = "0x456C09C", VA = "0x456C09C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065500", Offset = "0x1065500")]
		public LookAtIK ik;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065564", Offset = "0x1065564")]
		public float lerpSpeed;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F25FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10655C8", Offset = "0x10655C8")]
		public float weightSpeed;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float stopLookTime;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16EB")]
		private float weight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x456C68C", Offset = "0x456C68C", VA = "0x456C68C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x456CA3C", Offset = "0x456CA3C", VA = "0x456CA3C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x456D054", Offset = "0x456D054", VA = "0x456D054")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x456D37C", Offset = "0x456D37C", VA = "0x456D37C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x456D5C8", Offset = "0x456D5C8", VA = "0x456D5C8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E2EC", Offset = "0x105E2EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E2EC", Offset = "0x105E2EC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class InteractionEvent
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10683B0", Offset = "0x10683B0")]
			public float time;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16FB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068414", Offset = "0x1068414")]
			public bool pause;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068478", Offset = "0x1068478")]
			public bool pickUp;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F262C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10684DC", Offset = "0x10684DC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068540", Offset = "0x1068540")]
			public Message[] messages;

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x456B8F0", Offset = "0x456B8F0", VA = "0x456B8F0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x4570690", Offset = "0x4570690", VA = "0x4570690")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012F")]
		public class Message
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10685A4", Offset = "0x10685A4")]
			public string function;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068608", Offset = "0x1068608")]
			public GameObject recipient;

			[Token(Token = "0x4000726")]
			private const string empty = "";

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x4570488", Offset = "0x4570488", VA = "0x4570488")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x45706C0", Offset = "0x45706C0", VA = "0x45706C0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106866C", Offset = "0x106866C")]
			public Animator animator;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F263C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10686D0", Offset = "0x10686D0")]
			public Animation animation;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068734", Offset = "0x1068734")]
			public string animationState;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068798", Offset = "0x1068798")]
			public float crossfadeTime;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10687FC", Offset = "0x10687FC")]
			public int layer;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068860", Offset = "0x1068860")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400072D")]
			private const string empty = "";

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x456FECC", Offset = "0x456FECC", VA = "0x456FECC")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x4570110", Offset = "0x4570110", VA = "0x4570110")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x457028C", Offset = "0x457028C", VA = "0x457028C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x4570440", Offset = "0x4570440", VA = "0x4570440")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F264C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10688C4", Offset = "0x10688C4")]
			public Type type;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068928", Offset = "0x1068928")]
			public AnimationCurve curve;

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x456E738", Offset = "0x456E738", VA = "0x456E738")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x4570734", Offset = "0x4570734", VA = "0x4570734")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000132")]
		public class Multiplier
		{
			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106898C", Offset = "0x106898C")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10689F0", Offset = "0x10689F0")]
			public float multiplier;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1723")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068A54", Offset = "0x1068A54")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x456FB68", Offset = "0x456FB68", VA = "0x456FB68")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x45706F0", Offset = "0x45706F0", VA = "0x45706F0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F260C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065668", Offset = "0x1065668")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10656CC", Offset = "0x10656CC")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065730", Offset = "0x1065730")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F3")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F261C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1065794", Offset = "0x1065794")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10657D0", Offset = "0x10657D0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000072")]
		public float length
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x456D93C", Offset = "0x456D93C", VA = "0x456D93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106D130", Offset = "0x106D130")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x456D96C", Offset = "0x456D96C", VA = "0x456D96C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106D16C", Offset = "0x106D16C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x456D9A4", Offset = "0x456D9A4", VA = "0x456D9A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106D1A8", Offset = "0x106D1A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x456D9D4", Offset = "0x456D9D4", VA = "0x456D9D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106D1E4", Offset = "0x106D1E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x456DF04", Offset = "0x456DF04", VA = "0x456DF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x456BE24", Offset = "0x456BE24", VA = "0x456BE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x456D624", Offset = "0x456D624", VA = "0x456D624")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CED8", Offset = "0x106CED8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x456D6A8", Offset = "0x456D6A8", VA = "0x456D6A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CF3C", Offset = "0x106CF3C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x456D72C", Offset = "0x456D72C", VA = "0x456D72C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106CFA0", Offset = "0x106CFA0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x456D7B0", Offset = "0x456D7B0", VA = "0x456D7B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D004", Offset = "0x106D004")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x456D834", Offset = "0x456D834", VA = "0x456D834")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D068", Offset = "0x106D068")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x456D8B8", Offset = "0x456D8B8", VA = "0x456D8B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D0CC", Offset = "0x106D0CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x456DA0C", Offset = "0x456DA0C", VA = "0x456DA0C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x456E050", Offset = "0x456E050", VA = "0x456E050")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x4567898", Offset = "0x4567898", VA = "0x4567898")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x456E428", Offset = "0x456E428", VA = "0x456E428")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x4567550", Offset = "0x4567550", VA = "0x4567550")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x4567858", Offset = "0x4567858", VA = "0x4567858")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x4569698", Offset = "0x4569698", VA = "0x4569698")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x456AE5C", Offset = "0x456AE5C", VA = "0x456AE5C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x456FBDC", Offset = "0x456FBDC", VA = "0x456FBDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x456E798", Offset = "0x456E798", VA = "0x456E798")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x456E458", Offset = "0x456E458", VA = "0x456E458")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x456FA50", Offset = "0x456FA50", VA = "0x456FA50")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x456FC0C", Offset = "0x456FC0C", VA = "0x456FC0C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x456FD24", Offset = "0x456FD24", VA = "0x456FD24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D220", Offset = "0x106D220")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x456FDA8", Offset = "0x456FDA8", VA = "0x456FDA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D284", Offset = "0x106D284")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x456FE2C", Offset = "0x456FE2C", VA = "0x456FE2C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E398", Offset = "0x105E398")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E398", Offset = "0x105E398")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000134")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106580C", Offset = "0x106580C")]
		public string targetTag;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F267C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065870", Offset = "0x1065870")]
		public float fadeInTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10658D4", Offset = "0x10658D4")]
		public float speed;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065938", Offset = "0x1065938")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x106599C", Offset = "0x106599C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106599C", Offset = "0x106599C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x106599C", Offset = "0x106599C")]
		public Collider characterCollider;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x172B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065A90", Offset = "0x1065A90")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1065A90", Offset = "0x1065A90")]
		public Transform FPSCamera;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065B3C", Offset = "0x1065B3C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F268C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065BA0", Offset = "0x1065BA0")]
		public float camRaycastDistance;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1065C04", Offset = "0x1065C04")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1733")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F269C")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x173B")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1065C40", Offset = "0x1065C40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065C40", Offset = "0x1065C40")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F26AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065CEC", Offset = "0x1065CEC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Collider lastCollider;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1743")]
		private Collider c;

		[Token(Token = "0x17000076")]
		public bool inInteraction
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x4570A7C", Offset = "0x4570A7C", VA = "0x4570A7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x4575728", Offset = "0x4575728", VA = "0x4575728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x4575758", Offset = "0x4575758", VA = "0x4575758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106D540", Offset = "0x106D540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x4575788", Offset = "0x4575788", VA = "0x4575788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106D57C", Offset = "0x106D57C")]
			private set
			{
			}
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x4570764", Offset = "0x4570764", VA = "0x4570764")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D2E8", Offset = "0x106D2E8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x45707E8", Offset = "0x45707E8", VA = "0x45707E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D34C", Offset = "0x106D34C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x457086C", Offset = "0x457086C", VA = "0x457086C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D3B0", Offset = "0x106D3B0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x45708F0", Offset = "0x45708F0", VA = "0x45708F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D414", Offset = "0x106D414")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x4570974", Offset = "0x4570974", VA = "0x4570974")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D478", Offset = "0x106D478")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x45709F8", Offset = "0x45709F8", VA = "0x45709F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D4DC", Offset = "0x106D4DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x4570E9C", Offset = "0x4570E9C", VA = "0x4570E9C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x4571128", Offset = "0x4571128", VA = "0x4571128")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x457137C", Offset = "0x457137C", VA = "0x457137C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x4571550", Offset = "0x4571550", VA = "0x4571550")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x4571820", Offset = "0x4571820", VA = "0x4571820")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x4571B4C", Offset = "0x4571B4C", VA = "0x4571B4C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x4571D24", Offset = "0x4571D24", VA = "0x4571D24")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x4571EFC", Offset = "0x4571EFC", VA = "0x4571EFC")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x45720D4", Offset = "0x45720D4", VA = "0x45720D4")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x45721F0", Offset = "0x45721F0", VA = "0x45721F0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x457230C", Offset = "0x457230C", VA = "0x457230C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x45723F4", Offset = "0x45723F4", VA = "0x45723F4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x45725A8", Offset = "0x45725A8", VA = "0x45725A8")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x4572754", Offset = "0x4572754", VA = "0x4572754")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x4572978", Offset = "0x4572978", VA = "0x4572978")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4573134", Offset = "0x4573134", VA = "0x4573134")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x45736C4", Offset = "0x45736C4", VA = "0x45736C4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x4573E40", Offset = "0x4573E40", VA = "0x4573E40")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x45744C4", Offset = "0x45744C4", VA = "0x45744C4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x457459C", Offset = "0x457459C", VA = "0x457459C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x4574710", Offset = "0x4574710", VA = "0x4574710")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x4574974", Offset = "0x4574974", VA = "0x4574974")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x4574CF0", Offset = "0x4574CF0", VA = "0x4574CF0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x45754E4", Offset = "0x45754E4", VA = "0x45754E4")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x4574068", Offset = "0x4574068", VA = "0x4574068")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x45757C0", Offset = "0x45757C0", VA = "0x45757C0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x4576680", Offset = "0x4576680", VA = "0x4576680")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x45766D4", Offset = "0x45766D4", VA = "0x45766D4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x4576728", Offset = "0x4576728", VA = "0x4576728")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x457677C", Offset = "0x457677C", VA = "0x457677C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x4576864", Offset = "0x4576864", VA = "0x4576864")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x4576A60", Offset = "0x4576A60", VA = "0x4576A60")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x4576C04", Offset = "0x4576C04", VA = "0x4576C04")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x4577440", Offset = "0x4577440", VA = "0x4577440")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x4577670", Offset = "0x4577670", VA = "0x4577670")]
		private void Update()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x4577B3C", Offset = "0x4577B3C", VA = "0x4577B3C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x4575F78", Offset = "0x4575F78", VA = "0x4575F78")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x4577D58", Offset = "0x4577D58", VA = "0x4577D58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x4578040", Offset = "0x4578040", VA = "0x4578040")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x45781A8", Offset = "0x45781A8", VA = "0x45781A8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x45783CC", Offset = "0x45783CC", VA = "0x45783CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x4570C54", Offset = "0x4570C54", VA = "0x4570C54")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x4572E98", Offset = "0x4572E98", VA = "0x4572E98")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x4578890", Offset = "0x4578890", VA = "0x4578890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D5B8", Offset = "0x106D5B8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x4578914", Offset = "0x4578914", VA = "0x4578914")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D61C", Offset = "0x106D61C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x4578998", Offset = "0x4578998", VA = "0x4578998")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E444", Offset = "0x105E444")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E444", Offset = "0x105E444")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class Multiplier
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068AB8", Offset = "0x1068AB8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1753")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068B1C", Offset = "0x1068B1C")]
			public float multiplier;

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x4579678", Offset = "0x4579678", VA = "0x4579678")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065D50", Offset = "0x1065D50")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F26BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065DB4", Offset = "0x1065DB4")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065E18", Offset = "0x1065E18")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065E7C", Offset = "0x1065E7C")]
		public Transform pivot;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065EE0", Offset = "0x1065EE0")]
		public Vector3 twistAxis;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065F44", Offset = "0x1065F44")]
		public float twistWeight;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1065FA8", Offset = "0x1065FA8")]
		public float swingWeight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F26CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106600C", Offset = "0x106600C")]
		public bool rotateOnce;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lastPivot;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x4579150", Offset = "0x4579150", VA = "0x4579150")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D680", Offset = "0x106D680")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x45791D4", Offset = "0x45791D4", VA = "0x45791D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D6E4", Offset = "0x106D6E4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x4579258", Offset = "0x4579258", VA = "0x4579258")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D748", Offset = "0x106D748")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x45792DC", Offset = "0x45792DC", VA = "0x45792DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D7AC", Offset = "0x106D7AC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x4579360", Offset = "0x4579360", VA = "0x4579360")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D810", Offset = "0x106D810")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x45793E4", Offset = "0x45793E4", VA = "0x45793E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D874", Offset = "0x106D874")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x456E5D4", Offset = "0x456E5D4", VA = "0x456E5D4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x456BF70", Offset = "0x456BF70", VA = "0x456BF70")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x4567ACC", Offset = "0x4567ACC", VA = "0x4567ACC")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x4579468", Offset = "0x4579468", VA = "0x4579468")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D8D8", Offset = "0x106D8D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x45794EC", Offset = "0x45794EC", VA = "0x45794EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D93C", Offset = "0x106D93C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x4579570", Offset = "0x4579570", VA = "0x4579570")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E4F0", Offset = "0x105E4F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E4F0", Offset = "0x105E4F0")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F26DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068B80", Offset = "0x1068B80")]
			public bool use;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068BE4", Offset = "0x1068BE4")]
			public Vector2 offset;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068C48", Offset = "0x1068C48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1068C48", Offset = "0x1068C48")]
			public float angleOffset;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068CE8", Offset = "0x1068CE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1068CE8", Offset = "0x1068CE8")]
			public float maxAngle;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x175B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068D84", Offset = "0x1068D84")]
			public float radius;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068DE8", Offset = "0x1068DE8")]
			public bool orbit;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F26EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068E4C", Offset = "0x1068E4C")]
			public bool fixYAxis;

			[Token(Token = "0x170000D1")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600088F")]
				[Address(RVA = "0x457A784", Offset = "0x457A784", VA = "0x457A784")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x457A834", Offset = "0x457A834", VA = "0x457A834")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x457A9E4", Offset = "0x457A9E4", VA = "0x457A9E4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x457BB04", Offset = "0x457BB04", VA = "0x457BB04")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068EB0", Offset = "0x1068EB0")]
			public Collider lookAtTarget;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068F14", Offset = "0x1068F14")]
			public Vector3 direction;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068F78", Offset = "0x1068F78")]
			public float maxDistance;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1763")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1068FDC", Offset = "0x1068FDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1068FDC", Offset = "0x1068FDC")]
			public float maxAngle;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069078", Offset = "0x1069078")]
			public bool fixYAxis;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x4579BC8", Offset = "0x4579BC8", VA = "0x4579BC8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x4579FD4", Offset = "0x4579FD4", VA = "0x4579FD4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x457A654", Offset = "0x457A654", VA = "0x457A654")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A24C", Offset = "0x106A24C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x55F270C")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A2B0", Offset = "0x106A2B0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000947")]
				[Address(RVA = "0x457BBA4", Offset = "0x457BBA4", VA = "0x457BBA4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F26FC")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069194", Offset = "0x1069194")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10691F8", Offset = "0x10691F8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x176B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106925C", Offset = "0x106925C")]
			public Interaction[] interactions;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x4579848", Offset = "0x4579848", VA = "0x4579848")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x457BB60", Offset = "0x457BB60", VA = "0x457BB60")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066070", Offset = "0x1066070")]
		public Range[] ranges;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x45796A8", Offset = "0x45796A8", VA = "0x45796A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106D9A0", Offset = "0x106D9A0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x457972C", Offset = "0x457972C", VA = "0x457972C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DA04", Offset = "0x106DA04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x45797B0", Offset = "0x45797B0", VA = "0x45797B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DA68", Offset = "0x106DA68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x4579834", Offset = "0x4579834", VA = "0x4579834")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x457707C", Offset = "0x457707C", VA = "0x457707C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x4579B28", Offset = "0x4579B28", VA = "0x4579B28")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform bone;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform target;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1773")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x3E8A270", Offset = "0x3E8A270", VA = "0x3E8A270")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x3E8A3C4", Offset = "0x3E8A3C4", VA = "0x3E8A3C4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x3E8A56C", Offset = "0x3E8A56C", VA = "0x3E8A56C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x3E8A910", Offset = "0x3E8A910", VA = "0x3E8A910")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Map[] maps;

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x3E89C40", Offset = "0x3E89C40", VA = "0x3E89C40", Slot = "4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DACC", Offset = "0x106DACC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x3E8A2E0", Offset = "0x3E8A2E0", VA = "0x3E8A2E0", Slot = "5")]
		public override void StoreDefaultState()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x3E8A488", Offset = "0x3E8A488", VA = "0x3E8A488", Slot = "6")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x3E8A108", Offset = "0x3E8A108", VA = "0x3E8A108")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x3E8A630", Offset = "0x3E8A630", VA = "0x3E8A630")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x3E8AC14", Offset = "0x3E8AC14", VA = "0x3E8AC14")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F271C")]
		private Transform _poseRoot;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] children;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x177B")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x3E9E40C", Offset = "0x3E9E40C", VA = "0x3E9E40C", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x3E9E4AC", Offset = "0x3E9E4AC", VA = "0x3E9E4AC", Slot = "5")]
		public override void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x3E9E720", Offset = "0x3E9E720", VA = "0x3E9E720", Slot = "6")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x3E9E8E8", Offset = "0x3E9E8E8", VA = "0x3E9E8E8", Slot = "4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x3E9EA88", Offset = "0x3E9EA88", VA = "0x3E9EA88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x3E9F208", Offset = "0x3E9F208", VA = "0x3E9F208")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class Poser : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform poseRoot;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F272C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10660D4", Offset = "0x10660D4")]
		public float weight;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106611C", Offset = "0x106611C")]
		public float localRotationWeight;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1066164", Offset = "0x1066164")]
		public float localPositionWeight;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool fixTransforms;

		[Token(Token = "0x6000585")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000586")]
		public abstract void StoreDefaultState();

		[Token(Token = "0x6000587")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x457E204", Offset = "0x457E204", VA = "0x457E204", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x457E234", Offset = "0x457E234", VA = "0x457E234", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x457E280", Offset = "0x457E280", VA = "0x457E280")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x105E59C", Offset = "0x105E59C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public class Rigidbone
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody r;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform t;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x179B")]
			public Collider collider;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Joint joint;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F276C")]
			public Rigidbody c;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool updateAnchor;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17A3")]
			public float deltaTime;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F277C")]
			public Quaternion lastRotation;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x457EE9C", Offset = "0x457EE9C", VA = "0x457EE9C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x4580C54", Offset = "0x4580C54", VA = "0x4580C54")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x4580760", Offset = "0x4580760", VA = "0x4580760")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localPosition;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion localRotation;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x457F1A0", Offset = "0x457F1A0", VA = "0x457F1A0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x4581034", Offset = "0x4581034", VA = "0x4581034")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x4580F70", Offset = "0x4580F70", VA = "0x4580F70")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EB54", Offset = "0x105EB54")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17AB")]
			private int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private object <>2__current;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F278C")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x4581FC4", Offset = "0x4581FC4", VA = "0x4581FC4", Slot = "4")]
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
				[Address(RVA = "0x4582094", Offset = "0x4582094", VA = "0x4582094", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x457F288", Offset = "0x457F288", VA = "0x457F288")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x458175C", Offset = "0x458175C", VA = "0x458175C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x4581770", Offset = "0x4581770", VA = "0x4581770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x4581FF4", Offset = "0x4581FF4", VA = "0x4581FF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1783")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10661AC", Offset = "0x10661AC")]
		public IK ik;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066210", Offset = "0x1066210")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F273C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066274", Offset = "0x1066274")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10662D8", Offset = "0x10662D8")]
		public float applyVelocity;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106633C", Offset = "0x106633C")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178B")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Child[] children;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F274C")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1793")]
		private float ragdollWeight;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float ragdollWeightV;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F275C")]
		private bool fixedFrame;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000079")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x457E360", Offset = "0x457E360", VA = "0x457E360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		private bool ikUsed
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x457FC94", Offset = "0x457FC94", VA = "0x457FC94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x457E2EC", Offset = "0x457E2EC", VA = "0x457E2EC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x457E494", Offset = "0x457E494", VA = "0x457E494")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x457E6D4", Offset = "0x457E6D4", VA = "0x457E6D4")]
		public void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x457E618", Offset = "0x457E618", VA = "0x457E618")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106DB30", Offset = "0x106DB30")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x457F2D0", Offset = "0x457F2D0", VA = "0x457F2D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x457F964", Offset = "0x457F964", VA = "0x457F964")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x457FAFC", Offset = "0x457FAFC", VA = "0x457FAFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x4580098", Offset = "0x4580098", VA = "0x4580098")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x457FC1C", Offset = "0x457FC1C", VA = "0x457FC1C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4580010", Offset = "0x4580010", VA = "0x4580010")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x45801E8", Offset = "0x45801E8", VA = "0x45801E8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x45800F0", Offset = "0x45800F0", VA = "0x45800F0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x457E520", Offset = "0x457E520", VA = "0x457E520")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x457F9F4", Offset = "0x457F9F4", VA = "0x457F9F4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x45813E4", Offset = "0x45813E4", VA = "0x45813E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x45815D4", Offset = "0x45815D4", VA = "0x45815D4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17B3")]
		private bool applicationQuit;

		[Token(Token = "0x1700007B")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x4585228", Offset = "0x4585228", VA = "0x4585228")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x45852E8", Offset = "0x45852E8", VA = "0x45852E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x4584B4C", Offset = "0x4584B4C", VA = "0x4584B4C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x4584BC4", Offset = "0x4584BC4", VA = "0x4584BC4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x45850B8", Offset = "0x45850B8", VA = "0x45850B8")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x45851A0", Offset = "0x45851A0", VA = "0x45851A0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005A3")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x4584F18", Offset = "0x4584F18", VA = "0x4584F18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x4585410", Offset = "0x4585410", VA = "0x4585410")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x4585440", Offset = "0x4585440", VA = "0x4585440")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x45854A4", Offset = "0x45854A4", VA = "0x45854A4")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x4585688", Offset = "0x4585688", VA = "0x4585688")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x4585B80", Offset = "0x4585B80", VA = "0x4585B80")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x4585CE0", Offset = "0x4585CE0", VA = "0x4585CE0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E64C", Offset = "0x105E64C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E64C", Offset = "0x105E64C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10663DC", Offset = "0x10663DC")]
		public float limit;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F279C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1066424", Offset = "0x1066424")]
		public float twistLimit;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x4585DC4", Offset = "0x4585DC4", VA = "0x4585DC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DBE0", Offset = "0x106DBE0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x4585E48", Offset = "0x4585E48", VA = "0x4585E48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DC44", Offset = "0x106DC44")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x4585ECC", Offset = "0x4585ECC", VA = "0x4585ECC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DCA8", Offset = "0x106DCA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x4585F50", Offset = "0x4585F50", VA = "0x4585F50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DD0C", Offset = "0x106DD0C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x4585FD4", Offset = "0x4585FD4", VA = "0x4585FD4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x4586114", Offset = "0x4586114", VA = "0x4586114")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x4586678", Offset = "0x4586678", VA = "0x4586678")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E6F8", Offset = "0x105E6F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E6F8", Offset = "0x105E6F8")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useLimits;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float max;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17BB")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F27AC")]
		private float lastAngle;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x45866D4", Offset = "0x45866D4", VA = "0x45866D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DD70", Offset = "0x106DD70")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x4586758", Offset = "0x4586758", VA = "0x4586758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DDD4", Offset = "0x106DDD4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x45867DC", Offset = "0x45867DC", VA = "0x45867DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DE38", Offset = "0x106DE38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x4586860", Offset = "0x4586860", VA = "0x4586860")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DE9C", Offset = "0x106DE9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x45868E4", Offset = "0x45868E4", VA = "0x45868E4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x4586998", Offset = "0x4586998", VA = "0x4586998")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x45870C4", Offset = "0x45870C4", VA = "0x45870C4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E7A4", Offset = "0x105E7A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E7A4", Offset = "0x105E7A4")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public class ReachCone
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F27BC")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float volume;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 S;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 B;

			[Token(Token = "0x170000D5")]
			public Vector3 o
			{
				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x458B29C", Offset = "0x458B29C", VA = "0x458B29C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D6")]
			public Vector3 a
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x458B2FC", Offset = "0x458B2FC", VA = "0x458B2FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D7")]
			public Vector3 b
			{
				[Token(Token = "0x60008AA")]
				[Address(RVA = "0x458B35C", Offset = "0x458B35C", VA = "0x458B35C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D8")]
			public Vector3 c
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x458B3BC", Offset = "0x458B3BC", VA = "0x458B3BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D9")]
			public bool isValid
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x4589178", Offset = "0x4589178", VA = "0x4589178")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x4589F70", Offset = "0x4589F70", VA = "0x4589F70")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x458A24C", Offset = "0x458A24C", VA = "0x458A24C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public class LimitPoint
		{
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17CB")]
			public Vector3 point;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float tangentWeight;

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x45891F4", Offset = "0x45891F4", VA = "0x45891F4")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10664A8", Offset = "0x10664A8")]
		public float twistLimit;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10664F0", Offset = "0x10664F0")]
		public int smoothIterations;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C3")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x45871D4", Offset = "0x45871D4", VA = "0x45871D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DF00", Offset = "0x106DF00")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x4587258", Offset = "0x4587258", VA = "0x4587258")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DF64", Offset = "0x106DF64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x45872DC", Offset = "0x45872DC", VA = "0x45872DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106DFC8", Offset = "0x106DFC8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x4587360", Offset = "0x4587360", VA = "0x4587360")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106E02C", Offset = "0x106E02C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x45873E4", Offset = "0x45873E4", VA = "0x45873E4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x4587CFC", Offset = "0x4587CFC", VA = "0x4587CFC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x4587E7C", Offset = "0x4587E7C", VA = "0x4587E7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x45889C0", Offset = "0x45889C0", VA = "0x45889C0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x45874D0", Offset = "0x45874D0", VA = "0x45874D0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x45892E0", Offset = "0x45892E0", VA = "0x45892E0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x458A5B8", Offset = "0x458A5B8", VA = "0x458A5B8")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x458A6E8", Offset = "0x458A6E8", VA = "0x458A6E8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x458A9B4", Offset = "0x458A9B4", VA = "0x458A9B4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x458829C", Offset = "0x458829C", VA = "0x458829C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x458AD44", Offset = "0x458AD44", VA = "0x458AD44")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x458B1E4", Offset = "0x458B1E4", VA = "0x458B1E4")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x105E850", Offset = "0x105E850")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x105E850", Offset = "0x105E850")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F27CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106664C", Offset = "0x106664C")]
		public float twistLimit;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x458B41C", Offset = "0x458B41C", VA = "0x458B41C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106E090", Offset = "0x106E090")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x458B4A0", Offset = "0x458B4A0", VA = "0x458B4A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106E0F4", Offset = "0x106E0F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x458B524", Offset = "0x458B524", VA = "0x458B524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106E158", Offset = "0x106E158")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x458B5A8", Offset = "0x458B5A8", VA = "0x458B5A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x106E1BC", Offset = "0x106E1BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x458B62C", Offset = "0x458B62C", VA = "0x458B62C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x458B684", Offset = "0x458B684", VA = "0x458B684", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x458B7C4", Offset = "0x458B7C4", VA = "0x458B7C4")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x458BF54", Offset = "0x458BF54", VA = "0x458BF54")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x17D3")]
			public bool visualize;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public string name;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F27DC")]
			public Vector3 direction;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float yaw;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float pitch;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float angleBuffer;

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x3E6F110", Offset = "0x3E6F110", VA = "0x3E6F110")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x3E6FA30", Offset = "0x3E6FA30", VA = "0x3E6FA30")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x3E6FA68", Offset = "0x3E6FA68", VA = "0x3E6FA68")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float angleBuffer;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Pose[] poses;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x3E6EF0C", Offset = "0x3E6EF0C", VA = "0x3E6EF0C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x3E6F7D4", Offset = "0x3E6F7D4", VA = "0x3E6F7D4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x3E6F978", Offset = "0x3E6F978", VA = "0x3E6F978")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A314", Offset = "0x106A314")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A378", Offset = "0x106A378")]
				public float weight;

				[Token(Token = "0x6000948")]
				[Address(RVA = "0x3E70A58", Offset = "0x3E70A58", VA = "0x3E70A58")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10692C0", Offset = "0x10692C0")]
			public Transform transform;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F27EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069324", Offset = "0x1069324")]
			public Transform relativeTo;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069388", Offset = "0x1069388")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10693EC", Offset = "0x10693EC")]
			public float verticalWeight;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069450", Offset = "0x1069450")]
			public float horizontalWeight;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17E3")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10694B4", Offset = "0x10694B4")]
			public float speed;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F27FC")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool firstUpdate;

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x3E6FD18", Offset = "0x3E6FD18", VA = "0x3E6FD18")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x3E7089C", Offset = "0x3E7089C", VA = "0x3E7089C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x3E709EC", Offset = "0x3E709EC", VA = "0x3E709EC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17DB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10666F0", Offset = "0x10666F0")]
		public Body[] bodies;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x3E6FADC", Offset = "0x3E6FADC", VA = "0x3E6FADC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x3E7086C", Offset = "0x3E7086C", VA = "0x3E7086C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17EB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066754", Offset = "0x1066754")]
		public float tiltSpeed;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10667B8", Offset = "0x10667B8")]
		public float tiltSensitivity;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F280C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106681C", Offset = "0x106681C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066880", Offset = "0x1066880")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float tiltAngle;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x3E73614", Offset = "0x3E73614", VA = "0x3E73614", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x3E73698", Offset = "0x3E73698", VA = "0x3E73698", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x3E73B9C", Offset = "0x3E73B9C", VA = "0x3E73B9C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F281C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069518", Offset = "0x1069518")]
			public string name;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106957C", Offset = "0x106957C")]
			public string colliderSearchName;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10695E0", Offset = "0x10695E0")]
			public Collider collider;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069644", Offset = "0x1069644")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17FB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10696C4", Offset = "0x10696C4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1069700", Offset = "0x1069700")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F282C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106973C", Offset = "0x106973C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1069778", Offset = "0x1069778")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float length;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float crossFadeSpeed;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1803")]
			private float lastTime;

			[Token(Token = "0x170000DA")]
			protected float crossFader
			{
				[Token(Token = "0x60008B6")]
				[Address(RVA = "0x3EA09A4", Offset = "0x3EA09A4", VA = "0x3EA09A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F374", Offset = "0x106F374")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008B7")]
				[Address(RVA = "0x3EA09D4", Offset = "0x3EA09D4", VA = "0x3EA09D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F3B0", Offset = "0x106F3B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			protected float timer
			{
				[Token(Token = "0x60008B8")]
				[Address(RVA = "0x3EA0A0C", Offset = "0x3EA0A0C", VA = "0x3EA0A0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F3EC", Offset = "0x106F3EC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008B9")]
				[Address(RVA = "0x3EA0A3C", Offset = "0x3EA0A3C", VA = "0x3EA0A3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F428", Offset = "0x106F428")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			protected Vector3 force
			{
				[Token(Token = "0x60008BA")]
				[Address(RVA = "0x3EA0A74", Offset = "0x3EA0A74", VA = "0x3EA0A74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F464", Offset = "0x106F464")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008BB")]
				[Address(RVA = "0x3EA0AB4", Offset = "0x3EA0AB4", VA = "0x3EA0AB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F4A0", Offset = "0x106F4A0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			protected Vector3 point
			{
				[Token(Token = "0x60008BC")]
				[Address(RVA = "0x3EA0B14", Offset = "0x3EA0B14", VA = "0x3EA0B14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F4DC", Offset = "0x106F4DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008BD")]
				[Address(RVA = "0x3EA0B54", Offset = "0x3EA0B54", VA = "0x3EA0B54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x106F518", Offset = "0x106F518")]
				private set
				{
				}
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x3EA06DC", Offset = "0x3EA06DC", VA = "0x3EA06DC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x3E9FEB4", Offset = "0x3E9FEB4", VA = "0x3E9FEB4")]
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
			[Address(RVA = "0x3EA0BB4", Offset = "0x3EA0BB4", VA = "0x3EA0BB4")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A3DC", Offset = "0x106A3DC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000824")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A440", Offset = "0x106A440")]
				public float weight;

				[Token(Token = "0x4000825")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x180B")]
				private Vector3 lastValue;

				[Token(Token = "0x4000826")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				private Vector3 current;

				[Token(Token = "0x6000949")]
				[Address(RVA = "0x49C0280", Offset = "0x49C0280", VA = "0x49C0280")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600094A")]
				[Address(RVA = "0x49BFDCC", Offset = "0x49BFDCC", VA = "0x49BFDCC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600094B")]
				[Address(RVA = "0x49C08F0", Offset = "0x49C08F0", VA = "0x49C08F0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10697B4", Offset = "0x10697B4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F283C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069818", Offset = "0x1069818")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106987C", Offset = "0x106987C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x49BF9E0", Offset = "0x49BF9E0", VA = "0x49BF9E0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x49BFCD4", Offset = "0x49BFCD4", VA = "0x49BFCD4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x49BFE24", Offset = "0x49BFE24", VA = "0x49BFE24", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x49C0500", Offset = "0x49C0500", VA = "0x49C0500")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A4A4", Offset = "0x106A4A4")]
				public string boneSearchName;

				[Token(Token = "0x4000828")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1813")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A508", Offset = "0x106A508")]
				public Transform bone;

				[Token(Token = "0x4000829")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A56C", Offset = "0x106A56C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106A56C", Offset = "0x106A56C")]
				public float weight;

				[Token(Token = "0x400082A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x55F285C")]
				private Quaternion lastValue;

				[Token(Token = "0x400082B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion current;

				[Token(Token = "0x600094C")]
				[Address(RVA = "0x49BF5D8", Offset = "0x49BF5D8", VA = "0x49BF5D8")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600094D")]
				[Address(RVA = "0x49BF078", Offset = "0x49BF078", VA = "0x49BF078")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600094E")]
				[Address(RVA = "0x49BF8C4", Offset = "0x49BF8C4", VA = "0x49BF8C4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F284C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10698E0", Offset = "0x10698E0")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069944", Offset = "0x1069944")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x49BEE74", Offset = "0x49BEE74", VA = "0x49BEE74", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x49BEF80", Offset = "0x49BEF80", VA = "0x49BEF80", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x49BF0D0", Offset = "0x49BF0D0", VA = "0x49BF0D0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x49BF894", Offset = "0x49BF894", VA = "0x49BF894")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17F3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10668E4", Offset = "0x10668E4")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066948", Offset = "0x1066948")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x3E9F238", Offset = "0x3E9F238", VA = "0x3E9F238", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x3E9F728", Offset = "0x3E9F728", VA = "0x3E9F728")]
		public Transform FindDeepChild(Transform aParent, string aName)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x3E9FC8C", Offset = "0x3E9FC8C", VA = "0x3E9FC8C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x3EA01DC", Offset = "0x3EA01DC", VA = "0x3EA01DC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x3EA0974", Offset = "0x3EA0974", VA = "0x3EA0974")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A608", Offset = "0x106A608")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x182B")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A66C", Offset = "0x106A66C")]
				public float weight;

				[Token(Token = "0x600094F")]
				[Address(RVA = "0x4564D84", Offset = "0x4564D84", VA = "0x4564D84")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x181B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10699A8", Offset = "0x10699A8")]
			public Transform transform;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069A0C", Offset = "0x1069A0C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F286C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069A70", Offset = "0x1069A70")]
			public float speed;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069AD4", Offset = "0x1069AD4")]
			public float acceleration;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069B38", Offset = "0x1069B38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1069B38", Offset = "0x1069B38")]
			public float matchVelocity;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069BD4", Offset = "0x1069BD4")]
			public float gravity;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1823")]
			private Vector3 delta;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F287C")]
			private Vector3 direction;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool firstUpdate;

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x4563D94", Offset = "0x4563D94", VA = "0x4563D94")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x4564140", Offset = "0x4564140", VA = "0x4564140")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x4564D10", Offset = "0x4564D10", VA = "0x4564D10")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10669AC", Offset = "0x10669AC")]
		public Body[] bodies;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066A10", Offset = "0x1066A10")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x4563C9C", Offset = "0x4563C9C", VA = "0x4563C9C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x4563F9C", Offset = "0x4563F9C", VA = "0x4563F9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4564C9C", Offset = "0x4564C9C", VA = "0x4564C9C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069C38", Offset = "0x1069C38")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069C9C", Offset = "0x1069C9C")]
			public float spring;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1833")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069D00", Offset = "0x1069D00")]
			public bool x;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069D64", Offset = "0x1069D64")]
			public bool y;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F289C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069DC8", Offset = "0x1069DC8")]
			public bool z;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069E2C", Offset = "0x1069E2C")]
			public float minX;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069E90", Offset = "0x1069E90")]
			public float maxX;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069EF4", Offset = "0x1069EF4")]
			public float minY;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x183B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069F58", Offset = "0x1069F58")]
			public float maxY;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1069FBC", Offset = "0x1069FBC")]
			public float minZ;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F28AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A020", Offset = "0x106A020")]
			public float maxZ;

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x457C588", Offset = "0x457C588", VA = "0x457C588")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x457D254", Offset = "0x457D254", VA = "0x457D254")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x457D3A4", Offset = "0x457D3A4", VA = "0x457D3A4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x457D608", Offset = "0x457D608", VA = "0x457D608")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EB90", Offset = "0x105EB90")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D6")]
				[Address(RVA = "0x457D154", Offset = "0x457D154", VA = "0x457D154", Slot = "4")]
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
				[Address(RVA = "0x457D224", Offset = "0x457D224", VA = "0x457D224", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x457C2A8", Offset = "0x457C2A8", VA = "0x457C2A8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x457CDD0", Offset = "0x457CDD0", VA = "0x457CDD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x457CDE4", Offset = "0x457CDE4", VA = "0x457CDE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x457D184", Offset = "0x457D184", VA = "0x457D184", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066A74", Offset = "0x1066A74")]
		public float weight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F288C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066AD8", Offset = "0x1066AD8")]
		[SerializeField]
		protected FullBodyBipedIK ik;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastTime;

		[Token(Token = "0x1700007D")]
		protected float deltaTime
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x45640F8", Offset = "0x45640F8", VA = "0x45640F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E2")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x457C1A4", Offset = "0x457C1A4", VA = "0x457C1A4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x457C1EC", Offset = "0x457C1EC", VA = "0x457C1EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x106E220", Offset = "0x106E220")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x457C2F0", Offset = "0x457C2F0", VA = "0x457C2F0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x4564AF4", Offset = "0x4564AF4", VA = "0x4564AF4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x457CBF0", Offset = "0x457CBF0", VA = "0x457CBF0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x4564CCC", Offset = "0x4564CCC", VA = "0x4564CCC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F28BC")]
			public Vector3 offset;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pin;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x457D784", Offset = "0x457D784", VA = "0x457D784")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x457E1D4", Offset = "0x457E1D4", VA = "0x457E1D4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1843")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x457D638", Offset = "0x457D638", VA = "0x457D638")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x457DF0C", Offset = "0x457DF0C", VA = "0x457DF0C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x457E134", Offset = "0x457E134", VA = "0x457E134")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x55F290C")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A6D0", Offset = "0x106A6D0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A734", Offset = "0x106A734")]
				public float weight;

				[Token(Token = "0x6000950")]
				[Address(RVA = "0x4584B1C", Offset = "0x4584B1C", VA = "0x4584B1C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F28FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A084", Offset = "0x106A084")]
			public Vector3 offset;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A0E8", Offset = "0x106A0E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x106A0E8", Offset = "0x106A0E8")]
			public float additivity;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A184", Offset = "0x106A184")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x106A1E8", Offset = "0x106A1E8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x186B")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x4582788", Offset = "0x4582788", VA = "0x4582788")]
			public void Start()
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x4583D5C", Offset = "0x4583D5C", VA = "0x4583D5C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x4584ABC", Offset = "0x4584ABC", VA = "0x4584ABC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066B58", Offset = "0x1066B58")]
		public AimIK aimIK;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066BBC", Offset = "0x1066BBC")]
		public Handedness handedness;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066C20", Offset = "0x1066C20")]
		public bool twoHanded;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F28CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066C84", Offset = "0x1066C84")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066CE8", Offset = "0x1066CE8")]
		public float magnitudeRandom;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066D4C", Offset = "0x1066D4C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066DB0", Offset = "0x1066DB0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1853")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066E14", Offset = "0x1066E14")]
		public float blendTime;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1066E78", Offset = "0x1066E78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066E78", Offset = "0x1066E78")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F28DC")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float magnitudeMlp;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float endTime;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion handRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x185B")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion randomRotation;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F28EC")]
		private float length;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float blendWeight;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float w;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1863")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool handRotationsSet;

		[Token(Token = "0x1700007E")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x4584390", Offset = "0x4584390", VA = "0x4584390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x458445C", Offset = "0x458445C", VA = "0x458445C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x45842F8", Offset = "0x45842F8", VA = "0x45842F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x4584344", Offset = "0x4584344", VA = "0x4584344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x45820C4", Offset = "0x45820C4", VA = "0x45820C4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x458233C", Offset = "0x458233C", VA = "0x458233C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x458290C", Offset = "0x458290C", VA = "0x458290C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x4584528", Offset = "0x4584528", VA = "0x4584528")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x4584750", Offset = "0x4584750", VA = "0x4584750", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x458495C", Offset = "0x458495C", VA = "0x458495C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066F44", Offset = "0x1066F44")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F291C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1066FA8", Offset = "0x1066FA8")]
		public float offset;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool skip;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x458BF98", Offset = "0x458BF98", VA = "0x458BF98")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x458C0F4", Offset = "0x458C0F4", VA = "0x458C0F4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x458C35C", Offset = "0x458C35C", VA = "0x458C35C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x458CBD4", Offset = "0x458CBD4", VA = "0x458CBD4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x458CC6C", Offset = "0x458CC6C", VA = "0x458CC6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x458CE4C", Offset = "0x458CE4C", VA = "0x458CE4C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector2 _HALF_UV;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x4795F54", Offset = "0x4795F54", VA = "0x4795F54", Slot = "4")]
		public string version()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4795FC8", Offset = "0x4795FC8", VA = "0x4795FC8", Slot = "5")]
		public int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4795FE4", Offset = "0x4795FE4", VA = "0x4795FE4", Slot = "6")]
		public int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4796000", Offset = "0x4796000", VA = "0x4796000", Slot = "7")]
		public bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x4796064", Offset = "0x4796064", VA = "0x4796064", Slot = "8")]
		public void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x47960D0", Offset = "0x47960D0", VA = "0x47960D0", Slot = "9")]
		public void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x479613C", Offset = "0x479613C", VA = "0x479613C", Slot = "10")]
		public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4796238", Offset = "0x4796238", VA = "0x4796238", Slot = "11")]
		public bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x4796318", Offset = "0x4796318", VA = "0x4796318")]
		public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x479665C", Offset = "0x479665C", VA = "0x479665C", Slot = "12")]
		public Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4796AD4", Offset = "0x4796AD4", VA = "0x4796AD4", Slot = "13")]
		public void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x4796B40", Offset = "0x4796B40", VA = "0x4796B40", Slot = "14")]
		public void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x4796B98", Offset = "0x4796B98", VA = "0x4796B98", Slot = "15")]
		public void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4796BF0", Offset = "0x4796BF0", VA = "0x4796BF0", Slot = "16")]
		public Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x4796C50", Offset = "0x4796C50", VA = "0x4796C50", Slot = "17")]
		public Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x4796E94", Offset = "0x4796E94", VA = "0x4796E94")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x187B")]
		private bool m_doTintColor;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_tintColor;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F292C")]
		private Color m_defaultColor;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_defaultMetallic;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_defaultGlossiness;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultEmission;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1883")]
		private Color m_defaultNormal;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x479A2C0", Offset = "0x479A2C0", VA = "0x479A2C0", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x479A2E8", Offset = "0x479A2E8", VA = "0x479A2E8", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x479A480", Offset = "0x479A480", VA = "0x479A480", Slot = "6")]
		public Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x479A70C", Offset = "0x479A70C", VA = "0x479A70C", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x479AA10", Offset = "0x479AA10", VA = "0x479AA10", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x479AB08", Offset = "0x479AB08", VA = "0x479AB08", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x479A7F8", Offset = "0x479A7F8", VA = "0x479A7F8")]
		public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x479C2D8", Offset = "0x479C2D8", VA = "0x479C2D8")]
		public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4774BAC", Offset = "0x4774BAC", VA = "0x4774BAC")]
		public TextureBlenderFallback()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class TextureBlenderLegacyBumpDiffuse : TextureBlender
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool doColor;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F293C")]
		private Color m_tintColor;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultTintColor;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x479C49C", Offset = "0x479C49C", VA = "0x479C49C", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x479C5E0", Offset = "0x479C5E0", VA = "0x479C5E0", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x479C6F8", Offset = "0x479C6F8", VA = "0x479C6F8", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x479C984", Offset = "0x479C984", VA = "0x479C984", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x479CA4C", Offset = "0x479CA4C", VA = "0x479CA4C", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x479CB00", Offset = "0x479CB00", VA = "0x479CB00", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x479CFBC", Offset = "0x479CFBC", VA = "0x479CFBC")]
		public TextureBlenderLegacyBumpDiffuse()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class TextureBlenderLegacyDiffuse : TextureBlender
	{
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool doColor;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_tintColor;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188B")]
		private Color m_defaultTintColor;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x479D024", Offset = "0x479D024", VA = "0x479D024", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x479D168", Offset = "0x479D168", VA = "0x479D168", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x479D280", Offset = "0x479D280", VA = "0x479D280", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x479D50C", Offset = "0x479D50C", VA = "0x479D50C", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x479D5D4", Offset = "0x479D5D4", VA = "0x479D5D4", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x479D688", Offset = "0x479D688", VA = "0x479D688", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x479DA70", Offset = "0x479DA70", VA = "0x479DA70")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_tintColor;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F294C")]
		private Color m_emission;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Prop propertyToDo;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultColor;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_defaultMetallic;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1893")]
		private float m_defaultGlossiness;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_defaultEmission;

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x479DAD8", Offset = "0x479DAD8", VA = "0x479DAD8", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x479DB90", Offset = "0x479DB90", VA = "0x479DB90", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x479DEE4", Offset = "0x479DEE4", VA = "0x479DEE4", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x479E3A0", Offset = "0x479E3A0", VA = "0x479E3A0", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x479E5D8", Offset = "0x479E5D8", VA = "0x479E5D8", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x479E870", Offset = "0x479E870", VA = "0x479E870", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x479F658", Offset = "0x479F658", VA = "0x479F658")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_tintColor;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F296C")]
		private Color m_emission;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Prop propertyToDo;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultColor;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultSpecular;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18A3")]
		private float m_defaultGlossiness;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_defaultEmission;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x479F710", Offset = "0x479F710", VA = "0x479F710", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x479F7C8", Offset = "0x479F7C8", VA = "0x479F7C8", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x479FB1C", Offset = "0x479FB1C", VA = "0x479FB1C", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x479FFD8", Offset = "0x479FFD8", VA = "0x479FFD8", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x47A0238", Offset = "0x47A0238", VA = "0x47A0238", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x47A04F0", Offset = "0x47A04F0", VA = "0x47A04F0", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x47A135C", Offset = "0x47A135C", VA = "0x47A135C")]
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
		[Address(RVA = "0x44DA260", Offset = "0x44DA260", VA = "0x44DA260")]
		public static void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x44DA788", Offset = "0x44DA788", VA = "0x44DA788")]
		public static string Error(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x44DA92C", Offset = "0x44DA92C", VA = "0x44DA92C")]
		public static string Warn(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x44DAAD0", Offset = "0x44DAAD0", VA = "0x44DAAD0")]
		public static string Info(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x44DAC74", Offset = "0x44DAC74", VA = "0x44DAC74")]
		public static string LogDebug(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x44DAE18", Offset = "0x44DAE18", VA = "0x44DAE18")]
		public static string Trace(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x44DAFBC", Offset = "0x44DAFBC", VA = "0x44DAFBC")]
		public MB2_Log()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class ObjectLog
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int pos;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F29EC")]
		private string[] logMessages;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4799A1C", Offset = "0x4799A1C", VA = "0x4799A1C")]
		private void _CacheLogMessage(string msg)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x4799B48", Offset = "0x4799B48", VA = "0x4799B48")]
		public ObjectLog(short bufferSize)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4799BF8", Offset = "0x4799BF8", VA = "0x4799BF8")]
		public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4799C70", Offset = "0x4799C70", VA = "0x4799C70")]
		public void Error(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4799CD4", Offset = "0x4799CD4", VA = "0x4799CD4")]
		public void Warn(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x4799D38", Offset = "0x4799D38", VA = "0x4799D38")]
		public void Info(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x4799D9C", Offset = "0x4799D9C", VA = "0x4799D9C")]
		public void LogDebug(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x4799E00", Offset = "0x4799E00", VA = "0x4799E00")]
		public void Trace(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x4799E64", Offset = "0x4799E64", VA = "0x4799E64")]
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
		[Address(RVA = "0x4794D3C", Offset = "0x4794D3C", VA = "0x4794D3C")]
		private static MBVersionInterface _CreateMBVersionConcrete()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x4794E88", Offset = "0x4794E88", VA = "0x4794E88")]
		public static string version()
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x4794FA0", Offset = "0x4794FA0", VA = "0x4794FA0")]
		public static int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x47950B8", Offset = "0x47950B8", VA = "0x47950B8")]
		public static int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x47951D0", Offset = "0x47951D0", VA = "0x47951D0")]
		public static bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x479530C", Offset = "0x479530C", VA = "0x479530C")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x4795450", Offset = "0x4795450", VA = "0x4795450")]
		public static void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4795594", Offset = "0x4795594", VA = "0x4795594")]
		public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x47956BC", Offset = "0x47956BC", VA = "0x47956BC")]
		public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x47957F8", Offset = "0x47957F8", VA = "0x47957F8")]
		public static Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x4795954", Offset = "0x4795954", VA = "0x4795954")]
		public static void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x4795A98", Offset = "0x4795A98", VA = "0x4795A98")]
		public static void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x4795BC8", Offset = "0x4795BC8", VA = "0x4795BC8")]
		public static void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x4795CF8", Offset = "0x4795CF8", VA = "0x4795CF8")]
		public static Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x4795DFC", Offset = "0x4795DFC", VA = "0x4795DFC")]
		public static Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x4795F24", Offset = "0x4795F24", VA = "0x4795F24")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int x;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F29FC")]
			public int y;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int w;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int h;

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x44E26F4", Offset = "0x44E26F4", VA = "0x44E26F4")]
			public PixRect()
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x44DCD00", Offset = "0x44DCD00", VA = "0x44DCD00")]
			public PixRect(int xx, int yy, int ww, int hh)
			{
			}
		}

		[Token(Token = "0x200014D")]
		private class Image
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int imgId;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18EB")]
			public int w;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int h;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A0C")]
			public int x;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int y;

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x44E1998", Offset = "0x44E1998", VA = "0x44E1998")]
			public Image(int id, int tw, int th, int padding, int minImageSizeX, int minImageSizeY)
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x44E2104", Offset = "0x44E2104", VA = "0x44E2104")]
			public Image(Image im)
			{
			}
		}

		[Token(Token = "0x200014E")]
		private class ImgIDComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x44E250C", Offset = "0x44E250C", VA = "0x44E250C", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x44E1D70", Offset = "0x44E1D70", VA = "0x44E1D70")]
			public ImgIDComparer()
			{
			}
		}

		[Token(Token = "0x200014F")]
		private class ImageHeightComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x44E2334", Offset = "0x44E2334", VA = "0x44E2334", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x44E1B74", Offset = "0x44E1B74", VA = "0x44E1B74")]
			public ImageHeightComparer()
			{
			}
		}

		[Token(Token = "0x2000150")]
		private class ImageWidthComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x44E2420", Offset = "0x44E2420", VA = "0x44E2420", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x44E1BA4", Offset = "0x44E1BA4", VA = "0x44E1BA4")]
			public ImageWidthComparer()
			{
			}
		}

		[Token(Token = "0x2000151")]
		private class ImageAreaComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x44E2200", Offset = "0x44E2200", VA = "0x44E2200", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x44E1BD4", Offset = "0x44E1BD4", VA = "0x44E1BD4")]
			public ImageAreaComparer()
			{
			}
		}

		[Token(Token = "0x2000152")]
		private class ProbeResult
		{
			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int w;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int h;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18F3")]
			public Node root;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public bool fitsInMaxSize;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A1C")]
			public float efficiency;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float squareness;

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x44DDDF0", Offset = "0x44DDDF0", VA = "0x44DDDF0")]
			public void Set(int ww, int hh, Node r, bool fits, float e, float sq)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x44E1C34", Offset = "0x44E1C34", VA = "0x44E1C34")]
			public float GetScore(bool doPowerOfTwoScore)
			{
				return default(float);
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x44E1C04", Offset = "0x44E1C04", VA = "0x44E1C04")]
			public ProbeResult()
			{
			}
		}

		[Token(Token = "0x2000153")]
		private class Node
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Node[] child;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PixRect r;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18FB")]
			public Image img;

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x44E25F8", Offset = "0x44E25F8", VA = "0x44E25F8")]
			private bool isLeaf()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x44DCD90", Offset = "0x44DCD90", VA = "0x44DCD90")]
			public Node Insert(Image im, bool handed)
			{
				return null;
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x44DCC60", Offset = "0x44DCC60", VA = "0x44DCC60")]
			public Node()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ProbeResult bestRoot;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18E3")]
		public bool doPowerOfTwoTextures;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x44DAFEC", Offset = "0x44DAFEC", VA = "0x44DAFEC")]
		private static void printTree(Node r, string spc)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x44DB21C", Offset = "0x44DB21C", VA = "0x44DB21C")]
		private static void flattenTree(Node r, List<Image> putHere)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x44DB550", Offset = "0x44DB550", VA = "0x44DB550")]
		private static void drawGizmosNode(Node r)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x44DBB88", Offset = "0x44DBB88", VA = "0x44DBB88")]
		private static Texture2D createFilledTex(Color c, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x44DBE74", Offset = "0x44DBE74", VA = "0x44DBE74")]
		public void DrawGizmos()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x44DBEF4", Offset = "0x44DBEF4", VA = "0x44DBEF4")]
		private bool Probe(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDim, ProbeResult pr)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x44DD860", Offset = "0x44DD860", VA = "0x44DD860")]
		private void GetExtent(Node r, ref int x, ref int y)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x44DDEB4", Offset = "0x44DDEB4", VA = "0x44DDEB4")]
		private int StepWidthHeight(int oldVal, int step, int maxDim)
		{
			return default(int);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x44DDFE8", Offset = "0x44DDFE8", VA = "0x44DDFE8")]
		public int RoundToNearestPositivePowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x44DDC98", Offset = "0x44DDC98", VA = "0x44DDC98")]
		public int CeilToNearestPowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x44DE184", Offset = "0x44DE184", VA = "0x44DE184")]
		public Rect[] GetRects(List<Vector2> imgWidthHeights, int maxDimension, int padding, out int outW, out int outH)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x44DE338", Offset = "0x44DE338", VA = "0x44DE338")]
		private Rect[] _GetRects(List<Vector2> imgWidthHeights, int maxDimension, int padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, out int outW, out int outH, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x44E1DA0", Offset = "0x44E1DA0", VA = "0x44E1DA0")]
		public void RunTestHarness()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x44E20A8", Offset = "0x44E20A8", VA = "0x44E20A8")]
		public MB2_TexturePacker()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class MB3_CopyBoneWeights
	{
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x44E2724", Offset = "0x44E2724", VA = "0x44E2724")]
		public static void CopyBoneWeightsFromSeamMeshToOtherMeshes(float radius, Mesh seamMesh, Mesh[] targetMeshes)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x44E3934", Offset = "0x44E3934", VA = "0x44E3934")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected MBVersion _MBVersion;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A2C")]
		[SerializeField]
		protected MB2_LogLevel _LOG_LEVEL;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_ValidationLevel _validationLevel;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1903")]
		[SerializeField]
		protected GameObject _resultSceneObject;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected Renderer _targetRenderer;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A3C")]
		[SerializeField]
		protected MB_RenderType _renderType;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doNorm;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190B")]
		[SerializeField]
		protected bool _doTan;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _doCol;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A4C")]
		[SerializeField]
		protected bool _doUV;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doUV3;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doUV4;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public float uv2UnwrappingParamsHardAngle;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1913")]
		[SerializeField]
		public float uv2UnwrappingParamsPackMargin;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected bool _usingTemporaryTextureBakeResult;

		[Token(Token = "0x17000082")]
		public static bool EVAL_VERSION
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x44E3964", Offset = "0x44E3964", VA = "0x44E3964")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public virtual MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x44E3984", Offset = "0x44E3984", VA = "0x44E3984", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x44E39B4", Offset = "0x44E39B4", VA = "0x44E39B4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public virtual MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x44E39EC", Offset = "0x44E39EC", VA = "0x44E39EC", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x44E3A1C", Offset = "0x44E3A1C", VA = "0x44E3A1C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public string name
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x44E3A54", Offset = "0x44E3A54", VA = "0x44E3A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x44E3A84", Offset = "0x44E3A84", VA = "0x44E3A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public virtual MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x44E3ABC", Offset = "0x44E3ABC", VA = "0x44E3ABC", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x44E3AEC", Offset = "0x44E3AEC", VA = "0x44E3AEC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public virtual GameObject resultSceneObject
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x44E3B24", Offset = "0x44E3B24", VA = "0x44E3B24", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x44E3B54", Offset = "0x44E3B54", VA = "0x44E3B54", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public virtual Renderer targetRenderer
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x44E3B8C", Offset = "0x44E3B8C", VA = "0x44E3B8C", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x44E3BBC", Offset = "0x44E3BBC", VA = "0x44E3BBC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public virtual MB_RenderType renderType
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x44E3E20", Offset = "0x44E3E20", VA = "0x44E3E20", Slot = "14")]
			get
			{
				return default(MB_RenderType);
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x44E3E50", Offset = "0x44E3E50", VA = "0x44E3E50", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public virtual MB2_OutputOptions outputOption
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x44E3E88", Offset = "0x44E3E88", VA = "0x44E3E88", Slot = "16")]
			get
			{
				return default(MB2_OutputOptions);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x44E3EB8", Offset = "0x44E3EB8", VA = "0x44E3EB8", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public virtual MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x44E3EF0", Offset = "0x44E3EF0", VA = "0x44E3EF0", Slot = "18")]
			get
			{
				return default(MB2_LightmapOptions);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x44E3F20", Offset = "0x44E3F20", VA = "0x44E3F20", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public virtual bool doNorm
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x44E3F58", Offset = "0x44E3F58", VA = "0x44E3F58", Slot = "20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x44E3F9C", Offset = "0x44E3F9C", VA = "0x44E3F9C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual bool doTan
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x44E3FE8", Offset = "0x44E3FE8", VA = "0x44E3FE8", Slot = "22")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x44E402C", Offset = "0x44E402C", VA = "0x44E402C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual bool doCol
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x44E4078", Offset = "0x44E4078", VA = "0x44E4078", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x44E40BC", Offset = "0x44E40BC", VA = "0x44E40BC", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual bool doUV
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x44E4108", Offset = "0x44E4108", VA = "0x44E4108", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x44E414C", Offset = "0x44E414C", VA = "0x44E414C", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public virtual bool doUV1
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x44E4198", Offset = "0x44E4198", VA = "0x44E4198", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x44E41BC", Offset = "0x44E41BC", VA = "0x44E41BC", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public virtual bool doUV3
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x44E429C", Offset = "0x44E429C", VA = "0x44E429C", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x44E42E0", Offset = "0x44E42E0", VA = "0x44E42E0", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public virtual bool doUV4
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x44E432C", Offset = "0x44E432C", VA = "0x44E432C", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x44E4370", Offset = "0x44E4370", VA = "0x44E4370", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x44E41DC", Offset = "0x44E41DC", VA = "0x44E41DC", Slot = "30")]
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
		[Address(RVA = "0x44E43BC", Offset = "0x44E43BC", VA = "0x44E43BC", Slot = "44")]
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
		[Address(RVA = "0x44E43F4", Offset = "0x44E43F4", VA = "0x44E43F4")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x44E4DBC", Offset = "0x44E4DBC", VA = "0x44E4DBC")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x44E51D4", Offset = "0x44E51D4", VA = "0x44E51D4", Slot = "55")]
		protected virtual bool _CheckIfAllObjsToAddUseSameMaterialsAndCreateTemporaryTextrueBakeResult(GameObject[] gos)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x44E5A50", Offset = "0x44E5A50", VA = "0x44E5A50")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int vertIdx;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1933")]
			public int numVerts;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int[] indexesOfBonesUsed;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A9C")]
			public int lightmapIndex;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 lightmapTilingOffset;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool show;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool invertTriangles;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x193B")]
			public int[] submeshTriIdxs;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int[] submeshNumTris;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2AAC")]
			public int[] targetSubmeshIdxs;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect[] uvRects;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect[] uvSubRectInAtlas;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect[] uvRectsInSrcFull;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1943")]
			public Rect[] obUVRects;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int[][] _submeshTris;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2ABC")]
			public bool _beingDeleted;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _triangleIdxAdjustment;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform[] _tmpCachedBones;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Matrix4x4[] _tmpCachedBindposes;

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x45026A4", Offset = "0x45026A4", VA = "0x45026A4", Slot = "4")]
			public int CompareTo(MB_DynamicGameObject b)
			{
				return default(int);
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x44F2E5C", Offset = "0x44F2E5C", VA = "0x44F2E5C")]
			public MB_DynamicGameObject()
			{
			}
		}

		[Token(Token = "0x2000156")]
		public class MeshChannels
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194B")]
			public Vector3[] vertices;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3[] normals;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2ACC")]
			public Vector4[] tangents;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv0raw;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv0modified;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv2;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1953")]
			public Vector2[] uv3;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector2[] uv4;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2ADC")]
			public Color[] colors;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BoneWeight[] boneWeights;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Matrix4x4[] bindPoses;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[] triangles;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x45026FC", Offset = "0x45026FC", VA = "0x45026FC")]
			public MeshChannels()
			{
			}
		}

		[Token(Token = "0x2000157")]
		public class MeshChannelsCache
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x195B")]
			private MB3_MeshCombinerSingle mc;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			protected Dictionary<int, MeshChannels> meshID2MeshChannels;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2AEC")]
			private Vector2 _HALF_UV;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x44F2CB0", Offset = "0x44F2CB0", VA = "0x44F2CB0")]
			public MeshChannelsCache(MB3_MeshCombinerSingle mcs)
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x44F445C", Offset = "0x44F445C", VA = "0x44F445C")]
			public Vector3[] GetVertices(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x44F4678", Offset = "0x44F4678", VA = "0x44F4678")]
			public Vector3[] GetNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x44F4890", Offset = "0x44F4890", VA = "0x44F4890")]
			public Vector4[] GetTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x44E908C", Offset = "0x44E908C", VA = "0x44E908C")]
			public Vector2[] GetUv0Raw(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x450321C", Offset = "0x450321C", VA = "0x450321C")]
			public Vector2[] GetUv0Modified(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x44F7114", Offset = "0x44F7114", VA = "0x44F7114")]
			public Vector2[] GetUv2(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x44F5DC0", Offset = "0x44F5DC0", VA = "0x44F5DC0")]
			public Vector2[] GetUv3(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x44F6020", Offset = "0x44F6020", VA = "0x44F6020")]
			public Vector2[] GetUv4(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x44F6280", Offset = "0x44F6280", VA = "0x44F6280")]
			public Color[] GetColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x4501B98", Offset = "0x4501B98", VA = "0x4501B98")]
			public Matrix4x4[] GetBindposes(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x44FCDB8", Offset = "0x44FCDB8", VA = "0x44FCDB8")]
			public BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x4504208", Offset = "0x4504208", VA = "0x4504208")]
			public int[] GetTriangles(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x4503738", Offset = "0x4503738", VA = "0x4503738")]
			private Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x450272C", Offset = "0x450272C", VA = "0x450272C")]
			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x4502AB0", Offset = "0x4502AB0", VA = "0x4502AB0")]
			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x4502EFC", Offset = "0x4502EFC", VA = "0x4502EFC")]
			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x4503418", Offset = "0x4503418", VA = "0x4503418")]
			private Vector2[] _getMeshUV2s(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x4503A6C", Offset = "0x4503A6C", VA = "0x4503A6C")]
			public static Matrix4x4[] _getBindPoses(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x4503DA0", Offset = "0x4503DA0", VA = "0x4503DA0")]
			public static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x4504424", Offset = "0x4504424", VA = "0x4504424")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Matrix4x4 bindPose;

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x4501DF0", Offset = "0x4501DF0", VA = "0x4501DF0")]
			public BoneAndBindpose(Transform t, Matrix4x4 bp)
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x450230C", Offset = "0x450230C", VA = "0x450230C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x45025F8", Offset = "0x45025F8", VA = "0x45025F8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EBCC", Offset = "0x105EBCC")]
		private sealed class <>c__DisplayClass49_0
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject[] _goToAdd;

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x44F1DFC", Offset = "0x44F1DFC", VA = "0x44F1DFC")]
			public <>c__DisplayClass49_0()
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EC08", Offset = "0x105EC08")]
		private sealed class <>c__DisplayClass49_1
		{
			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1963")]
			public int i;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public <>c__DisplayClass49_0 CS$<>8__locals1;

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x44F2E2C", Offset = "0x44F2E2C", VA = "0x44F2E2C")]
			public <>c__DisplayClass49_1()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x4502228", Offset = "0x4502228", VA = "0x4502228")]
			internal bool <_addToCombined>b__0(int o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A5C")]
		[SerializeField]
		protected List<GameObject> objectsInCombinedMesh;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int lightmapIndex;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<int, MB_DynamicGameObject> _instance2combined_map;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191B")]
		[SerializeField]
		private Vector3[] verts;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Vector3[] normals;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A6C")]
		[SerializeField]
		private Vector4[] tangents;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector2[] uvs;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector2[] uv2s;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector2[] uv3s;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1923")]
		[SerializeField]
		private Vector2[] uv4s;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Color[] colors;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A7C")]
		[SerializeField]
		private Matrix4x4[] bindPoses;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform[] bones;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Mesh _mesh;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[][] submeshTris;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192B")]
		private BoneWeight[] boneWeights;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private GameObject[] empty;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2A8C")]
		private int[] emptyIDs;

		[Token(Token = "0x17000093")]
		public override MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x44E6164", Offset = "0x44E6164", VA = "0x44E6164", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public override MB_RenderType renderType
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x44E6454", Offset = "0x44E6454", VA = "0x44E6454", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public override GameObject resultSceneObject
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x44E65F4", Offset = "0x44E65F4", VA = "0x44E65F4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x44E689C", Offset = "0x44E689C", VA = "0x44E689C")]
		private MB_DynamicGameObject instance2Combined_MapGet(int gameObjectID)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x44E6944", Offset = "0x44E6944", VA = "0x44E6944")]
		private void instance2Combined_MapAdd(int gameObjectID, MB_DynamicGameObject dgo)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x44E69F4", Offset = "0x44E69F4", VA = "0x44E69F4")]
		private void instance2Combined_MapRemove(int gameObjectID)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x44E6A94", Offset = "0x44E6A94", VA = "0x44E6A94")]
		private bool instance2Combined_MapTryGetValue(int gameObjectID, out MB_DynamicGameObject dgo)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x44E6B60", Offset = "0x44E6B60", VA = "0x44E6B60")]
		private int instance2Combined_MapCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x44E6BF8", Offset = "0x44E6BF8", VA = "0x44E6BF8")]
		private void instance2Combined_MapClear()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x44E6C88", Offset = "0x44E6C88", VA = "0x44E6C88")]
		private bool instance2Combined_MapContainsKey(int gameObjectID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x44E6D44", Offset = "0x44E6D44", VA = "0x44E6D44", Slot = "41")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x44E6DDC", Offset = "0x44E6DDC", VA = "0x44E6DDC", Slot = "40")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x44E6EB4", Offset = "0x44E6EB4", VA = "0x44E6EB4")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x44E7010", Offset = "0x44E7010", VA = "0x44E7010")]
		public Transform[] GetBones()
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x44E7040", Offset = "0x44E7040", VA = "0x44E7040", Slot = "35")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x44E70DC", Offset = "0x44E70DC", VA = "0x44E70DC", Slot = "42")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x44E7148", Offset = "0x44E7148", VA = "0x44E7148", Slot = "43")]
		public override int GetNumVerticesFor(int instanceID)
		{
			return default(int);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x44E71E0", Offset = "0x44E71E0", VA = "0x44E71E0")]
		private void _initialize()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x44E7E24", Offset = "0x44E7E24", VA = "0x44E7E24")]
		private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x44E8A24", Offset = "0x44E8A24", VA = "0x44E8A24")]
		private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults, MeshChannelsCache meshChannelCache)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x44E92A4", Offset = "0x44E92A4", VA = "0x44E92A4")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x44E9910", Offset = "0x44E9910", VA = "0x44E9910")]
		private bool _validateMeshFlags()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x44E9D84", Offset = "0x44E9D84", VA = "0x44E9D84")]
		private bool _showHide(GameObject[] goToShow, GameObject[] goToHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x44EA4C4", Offset = "0x44EA4C4", VA = "0x44EA4C4")]
		private bool _addToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x44F4AA8", Offset = "0x44F4AA8", VA = "0x44F4AA8")]
		private void _copyAndAdjustUVsFromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x44F5838", Offset = "0x44F5838", VA = "0x44F5838")]
		private void _copyAndAdjustUV2FromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x44F732C", Offset = "0x44F732C", VA = "0x44F732C", Slot = "51")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x44F735C", Offset = "0x44F735C", VA = "0x44F735C", Slot = "52")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x44F7980", Offset = "0x44F7980", VA = "0x44F7980", Slot = "54")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x44F7FE4", Offset = "0x44F7FE4", VA = "0x44F7FE4")]
		private int _getNumBones(Renderer r)
		{
			return default(int);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x44F81F8", Offset = "0x44F81F8", VA = "0x44F81F8")]
		private Transform[] _getBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x44F823C", Offset = "0x44F823C", VA = "0x44F823C", Slot = "45")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x44F8404", Offset = "0x44F8404", VA = "0x44F8404", Slot = "56")]
		public virtual void ApplyShowHide()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x44F92EC", Offset = "0x44F92EC", VA = "0x44F92EC", Slot = "46")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x44F8974", Offset = "0x44F8974", VA = "0x44F8974")]
		public int[][] GetSubmeshTrisWithShowHideApplied()
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x44FB050", Offset = "0x44FB050", VA = "0x44FB050", Slot = "47")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x44FB248", Offset = "0x44FB248", VA = "0x44FB248")]
		private void _updateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x44FB7D8", Offset = "0x44FB7D8", VA = "0x44FB7D8")]
		private void _updateGameObject(GameObject go, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x44FD020", Offset = "0x44FD020", VA = "0x44FD020")]
		public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x44FD08C", Offset = "0x44FD08C", VA = "0x44FD08C", Slot = "48")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x44FD4BC", Offset = "0x44FD4BC", VA = "0x44FD4BC", Slot = "49")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x44FE59C", Offset = "0x44FE59C", VA = "0x44FE59C", Slot = "50")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x44FE658", Offset = "0x44FE658", VA = "0x44FE658", Slot = "36")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x44FE9F0", Offset = "0x44FE9F0", VA = "0x44FE9F0", Slot = "37")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x44FEB74", Offset = "0x44FEB74", VA = "0x44FEB74", Slot = "38")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x44FED60", Offset = "0x44FED60", VA = "0x44FED60", Slot = "39")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x44F1E2C", Offset = "0x44F1E2C", VA = "0x44F1E2C")]
		public bool ValidateTargRendererAndMeshAndResultSceneObj()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x44FEF84", Offset = "0x44FEF84", VA = "0x44FEF84")]
		public static Renderer BuildSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, bool createNewChild = false, [Optional] GameObject[] objsToBeAdded)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x44FE3A4", Offset = "0x44FE3A4", VA = "0x44FE3A4")]
		public void BuildSceneMeshObject([Optional] GameObject[] gos, bool createNewChild = false)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x44F3720", Offset = "0x44F3720", VA = "0x44F3720")]
		private bool IsMirrored(Matrix4x4 tm)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x4501028", Offset = "0x4501028", VA = "0x4501028", Slot = "53")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x44F2918", Offset = "0x44F2918", VA = "0x44F2918")]
		private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x44F3018", Offset = "0x44F3018", VA = "0x44F3018")]
		private void _CollectBonesToAddForDGO(MB_DynamicGameObject dgo, List<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Renderer r, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x44F3A68", Offset = "0x44F3A68", VA = "0x44F3A68")]
		private void _CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(List<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Transform[] nbones, Matrix4x4[] nbindPoses, BoneWeight[] nboneWeights, int totalDeleteVerts)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x44F6498", Offset = "0x44F6498", VA = "0x44F6498")]
		private void _AddBonesToNewBonesArrayAndAdjustBWIndexes(MB_DynamicGameObject dgo, Renderer r, int vertsIdx, Transform[] nbones, BoneWeight[] nboneWeights, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x4501E7C", Offset = "0x4501E7C", VA = "0x4501E7C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public MB3_MeshCombinerSingle combinedMesh;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B0C")]
			public int extraSpace;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numVertsInListToDelete;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numVertsInListToAdd;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<GameObject> gosToAdd;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1973")]
			public List<int> gosToDelete;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public List<GameObject> gosToUpdate;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B1C")]
			public bool isDirty;

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x4770A1C", Offset = "0x4770A1C", VA = "0x4770A1C")]
			public CombinedMesh(int maxNumVertsInMesh, GameObject resultSceneObject, MB2_LogLevel ll)
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x4770C30", Offset = "0x4770C30", VA = "0x4770C30")]
			public bool isEmpty()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2AFC")]
		private static GameObject[] empty;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] emptyIDs;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<int, CombinedMesh> obj2MeshCombinerMap;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public List<CombinedMesh> meshCombiners;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x196B")]
		[SerializeField]
		private int _maxVertsInMesh;

		[Token(Token = "0x17000096")]
		public override MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x4505920", Offset = "0x4505920", VA = "0x4505920", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x4505950", Offset = "0x4505950", VA = "0x4505950", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public override MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x4505C4C", Offset = "0x4505C4C", VA = "0x4505C4C", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x4505ACC", Offset = "0x4505ACC", VA = "0x4505ACC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int maxVertsInMesh
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x4505C7C", Offset = "0x4505C7C", VA = "0x4505C7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x4505CAC", Offset = "0x4505CAC", VA = "0x4505CAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x4505EEC", Offset = "0x4505EEC", VA = "0x4505EEC", Slot = "41")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x4505F84", Offset = "0x4505F84", VA = "0x4505F84", Slot = "42")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x45060E0", Offset = "0x45060E0", VA = "0x45060E0", Slot = "43")]
		public override int GetNumVerticesFor(int gameObjectID)
		{
			return default(int);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x450621C", Offset = "0x450621C", VA = "0x450621C", Slot = "40")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x4506404", Offset = "0x4506404", VA = "0x4506404", Slot = "35")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x450654C", Offset = "0x450654C", VA = "0x450654C", Slot = "50")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x4506624", Offset = "0x4506624", VA = "0x4506624")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x4506C90", Offset = "0x4506C90", VA = "0x4506C90", Slot = "45")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x4506EBC", Offset = "0x4506EBC", VA = "0x4506EBC", Slot = "46")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x450728C", Offset = "0x450728C", VA = "0x450728C", Slot = "51")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x45073E4", Offset = "0x45073E4", VA = "0x45073E4", Slot = "52")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x450753C", Offset = "0x450753C", VA = "0x450753C", Slot = "54")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x4507694", Offset = "0x4507694", VA = "0x4507694", Slot = "47")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x4508004", Offset = "0x4508004", VA = "0x4508004", Slot = "48")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x4508434", Offset = "0x4508434", VA = "0x4508434", Slot = "49")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x4508CB0", Offset = "0x4508CB0", VA = "0x4508CB0")]
		private bool _validate(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x4509C40", Offset = "0x4509C40", VA = "0x4509C40")]
		private void _distributeAmongBakers(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x450ADAC", Offset = "0x450ADAC", VA = "0x450ADAC")]
		private bool _bakeStep1(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x450CEE8", Offset = "0x450CEE8", VA = "0x450CEE8", Slot = "36")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x450D040", Offset = "0x450D040", VA = "0x450D040", Slot = "37")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x450D070", Offset = "0x450D070", VA = "0x450D070", Slot = "38")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x450D3D8", Offset = "0x450D3D8", VA = "0x450D3D8", Slot = "39")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x450CB0C", Offset = "0x450CB0C", VA = "0x450CB0C")]
		private void _setMBValues(MB3_MeshCombinerSingle targ)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x450D774", Offset = "0x450D774", VA = "0x450D774", Slot = "53")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x450D8CC", Offset = "0x450D8CC", VA = "0x450D8CC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool isNormalMap;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x4792DAC", Offset = "0x4792DAC", VA = "0x4792DAC")]
		public ShaderTextureProperty(string n, bool norm)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x4789628", Offset = "0x4789628", VA = "0x4789628")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Texture2D t;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1993")]
			public float texelDensity;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public DRect fullSamplingRect;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B5C")]
			public DRect matTilingRect;

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x4793E24", Offset = "0x4793E24", VA = "0x4793E24")]
			public MeshBakerMaterialTexture()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x4793E54", Offset = "0x4793E54", VA = "0x4793E54")]
			public MeshBakerMaterialTexture(Texture2D tx)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x477DE80", Offset = "0x477DE80", VA = "0x477DE80")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DRect matSubrectInFullSamplingRect;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DRect obUVRectIfTilingSame;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x199B")]
			public DRect samplingRectMatAndUVTiling;

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x477E484", Offset = "0x477E484", VA = "0x477E484")]
			public MatAndTransformToMerged(Material m)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x4793A7C", Offset = "0x4793A7C", VA = "0x4793A7C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x4793D60", Offset = "0x4793D60", VA = "0x4793D60", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200015E")]
		public class SamplingRectEnclosesComparer : IComparer<MatAndTransformToMerged>
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x4793E9C", Offset = "0x4793E9C", VA = "0x4793E9C", Slot = "4")]
			public int Compare(MatAndTransformToMerged x, MatAndTransformToMerged y)
			{
				return default(int);
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x478F274", Offset = "0x478F274", VA = "0x478F274")]
			public SamplingRectEnclosesComparer()
			{
			}
		}

		[Token(Token = "0x200015F")]
		public class MB_TexSet
		{
			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public MeshBakerMaterialTexture[] ts;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B6C")]
			public List<MatAndTransformToMerged> mats;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<GameObject> gos;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool allTexturesUseSameMatTiling;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 obUVoffset;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19A3")]
			public Vector2 obUVscale;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int idealWidth;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B7C")]
			public int idealHeight;

			[Token(Token = "0x170000E0")]
			public DRect obUVrect
			{
				[Token(Token = "0x600091C")]
				[Address(RVA = "0x4793728", Offset = "0x4793728", VA = "0x4793728")]
				get
				{
					return default(DRect);
				}
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x477E0BC", Offset = "0x477E0BC", VA = "0x477E0BC")]
			public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale)
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x4793040", Offset = "0x4793040", VA = "0x4793040")]
			public bool IsEqual(object obj, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, TextureBlender resultMaterialTextureBlender)
			{
				return default(bool);
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x478DAB4", Offset = "0x478DAB4", VA = "0x478DAB4")]
			public void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x478DEFC", Offset = "0x478DEFC", VA = "0x478DEFC")]
			public void CalcMatAndUVSamplingRectsIfAllMatTilingSame()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x478E45C", Offset = "0x478E45C", VA = "0x478E45C")]
			public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, TextureBlender resultMaterialTextureBlender)
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x478D578", Offset = "0x478D578", VA = "0x478D578")]
			internal string GetDescription()
			{
				return null;
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x47937C0", Offset = "0x47937C0", VA = "0x47937C0")]
			internal string GetMatSubrectDescriptions()
			{
				return null;
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EC44", Offset = "0x105EC44")]
		private sealed class <>c__DisplayClass58_0
		{
			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<ShaderTextureProperty> texPropertyNames;

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x4774530", Offset = "0x4774530", VA = "0x4774530")]
			public <>c__DisplayClass58_0()
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105EC80", Offset = "0x105EC80")]
		private sealed class <>c__DisplayClass58_1
		{
			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass58_0 CS$<>8__locals1;

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x4774560", Offset = "0x4774560", VA = "0x4774560")]
			public <>c__DisplayClass58_1()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x4792E20", Offset = "0x4792E20", VA = "0x4792E20")]
			internal bool <_CollectPropertyNames>b__0(ShaderTextureProperty x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x105ECBC", Offset = "0x105ECBC")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19AB")]
			public MB_TexSet setOfTexs;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x477DBD4", Offset = "0x477DBD4", VA = "0x477DBD4")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x4792F48", Offset = "0x4792F48", VA = "0x4792F48")]
			internal bool <__Step1_CollectDistinctMatTexturesAndUsedObjects>b__0(MB_TexSet x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DO_INTEGRITY_CHECKS;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x197B")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static ShaderTextureProperty[] shaderTexPropertyNames;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B2C")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected int _atlasPadding;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected int _maxAtlasSize;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _resizePowerOfTwoTextures;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1983")]
		[SerializeField]
		protected bool _fixOutOfBoundsUVs;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected int _maxTilingBakeSize;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B3C")]
		[SerializeField]
		protected bool _saveAtlasesAsAssets;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_PackingAlgorithmEnum _packingAlgorithm;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _meshBakerTexturePackerForcePowerOfTwo;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<ShaderTextureProperty> _customShaderPropNames;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198B")]
		[SerializeField]
		protected bool _normalizeTexelDensity;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _considerNonTextureProperties;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B4C")]
		protected TextureBlender resultMaterialTextureBlender;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TextureBlender[] textureBlenders;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<Texture2D> _temporaryTextures;

		[Token(Token = "0x17000099")]
		public MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x4770FD0", Offset = "0x4770FD0", VA = "0x4770FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x4771000", Offset = "0x4771000", VA = "0x4771000")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int atlasPadding
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x4771038", Offset = "0x4771038", VA = "0x4771038")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x4771068", Offset = "0x4771068", VA = "0x4771068")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public int maxAtlasSize
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x47710A0", Offset = "0x47710A0", VA = "0x47710A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x47710D0", Offset = "0x47710D0", VA = "0x47710D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool resizePowerOfTwoTextures
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x4771108", Offset = "0x4771108", VA = "0x4771108")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x477114C", Offset = "0x477114C", VA = "0x477114C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool fixOutOfBoundsUVs
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x4771198", Offset = "0x4771198", VA = "0x4771198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x47711DC", Offset = "0x47711DC", VA = "0x47711DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public int maxTilingBakeSize
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x4771228", Offset = "0x4771228", VA = "0x4771228")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x4771258", Offset = "0x4771258", VA = "0x4771258")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool saveAtlasesAsAssets
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x4771290", Offset = "0x4771290", VA = "0x4771290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x47712D4", Offset = "0x47712D4", VA = "0x47712D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public MB2_PackingAlgorithmEnum packingAlgorithm
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x4771320", Offset = "0x4771320", VA = "0x4771320")]
			get
			{
				return default(MB2_PackingAlgorithmEnum);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x4771350", Offset = "0x4771350", VA = "0x4771350")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool meshBakerTexturePackerForcePowerOfTwo
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x4771388", Offset = "0x4771388", VA = "0x4771388")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x47713CC", Offset = "0x47713CC", VA = "0x47713CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public List<ShaderTextureProperty> customShaderPropNames
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x4771418", Offset = "0x4771418", VA = "0x4771418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x4771448", Offset = "0x4771448", VA = "0x4771448")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool considerNonTextureProperties
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x4771480", Offset = "0x4771480", VA = "0x4771480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x47714C4", Offset = "0x47714C4", VA = "0x47714C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4771510", Offset = "0x4771510", VA = "0x4771510")]
		public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, [Optional] MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x47725F8", Offset = "0x47725F8", VA = "0x47725F8")]
		private static bool InterfaceFilter(Type typeObj, object criteriaObj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4772698", Offset = "0x4772698", VA = "0x4772698")]
		private void _LoadTextureBlenders()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x47730E8", Offset = "0x47730E8", VA = "0x47730E8")]
		private bool _CollectPropertyNames(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x47715BC", Offset = "0x47715BC", VA = "0x47715BC")]
		private bool _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4774CA0", Offset = "0x4774CA0", VA = "0x4774CA0")]
		private bool __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x4775B68", Offset = "0x4775B68", VA = "0x4775B68")]
		private bool __Step1_CollectDistinctMatTexturesAndUsedObjects(List<GameObject> allObjsToMesh, List<Material> allowedMaterialsFilter, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface textureEditorMethods, List<MB_TexSet> distinctMaterialTextures, List<GameObject> usedObjsToMesh)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x4777BAC", Offset = "0x4777BAC", VA = "0x4777BAC")]
		private int __Step2_CalculateIdealSizesForTexturesInAtlasAndPadding(List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor)
		{
			return default(int);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x477A0F8", Offset = "0x477A0F8", VA = "0x477A0F8")]
		private void __Step3_BuildAndSaveAtlasesAndStoreResults(ProgressUpdateDelegate progressInfo, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, int _padding, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4784548", Offset = "0x4784548", VA = "0x4784548")]
		private Rect[] __CreateAtlasesMBTexturePacker(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4786648", Offset = "0x4786648", VA = "0x4786648")]
		private Rect[] __CreateAtlasesMBTexturePackerFast(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x478207C", Offset = "0x478207C", VA = "0x478207C")]
		private Rect[] __CreateAtlasesUnityTexturePacker(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x478CAB4", Offset = "0x478CAB4", VA = "0x478CAB4")]
		private void _addWatermark(Texture2D[] texToPack)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x478CFD0", Offset = "0x478CFD0", VA = "0x478CFD0")]
		private Texture2D _addWatermark(Texture2D texToPack)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x478CACC", Offset = "0x478CACC", VA = "0x478CACC")]
		private Texture2D _copyTexturesIntoAtlas(Texture2D[] texToPack, int padding, Rect[] rs, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x4781FF0", Offset = "0x4781FF0", VA = "0x4781FF0")]
		private bool IsPowerOfTwo(int x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x477E604", Offset = "0x477E604", VA = "0x477E604")]
		private void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures, bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x4781488", Offset = "0x4781488", VA = "0x4781488")]
		private Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x478B9DC", Offset = "0x478B9DC", VA = "0x478B9DC")]
		public Texture2D GetAdjustedForScaleAndOffset2(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x478F2A4", Offset = "0x478F2A4", VA = "0x478F2A4")]
		internal static DRect GetSourceSamplingRect(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x478C564", Offset = "0x478C564", VA = "0x478C564")]
		private Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x47897F0", Offset = "0x47897F0", VA = "0x47897F0")]
		public void CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, bool _fixOutOfBoundsUVs, int maxSize, Color[][] atlasPixels, int atlasWidth, bool isNormalMap, [Optional] ProgressUpdateDelegate progressInfo)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x478B26C", Offset = "0x478B26C", VA = "0x478B26C")]
		public Texture2D _createTemporaryTexture(int w, int h, TextureFormat texFormat, bool mipMaps)
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x478F500", Offset = "0x478F500", VA = "0x478F500")]
		internal Texture2D _createTextureCopy(Texture2D t)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x478C460", Offset = "0x478C460", VA = "0x478C460")]
		private Texture2D _resizeTexture(Texture2D t, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x47758C0", Offset = "0x47758C0", VA = "0x47758C0")]
		private void _destroyTemporaryTextures()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x478F730", Offset = "0x478F730", VA = "0x478F730")]
		public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x47749F4", Offset = "0x47749F4", VA = "0x47749F4")]
		private TextureBlender FindMatchingTextureBlender(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x4788734", Offset = "0x4788734", VA = "0x4788734")]
		private void AdjustNonTextureProperties(Material mat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, bool considerTintColor, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x478B600", Offset = "0x478B600", VA = "0x478B600")]
		public static Color GetColorIfNoTexture(ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4791F50", Offset = "0x4791F50", VA = "0x4791F50")]
		private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x477D668", Offset = "0x477D668", VA = "0x477D668")]
		private float GetSubmeshArea(Mesh m, int submeshIdx)
		{
			return default(float);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4791D70", Offset = "0x4791D70", VA = "0x4791D70")]
		private string PrintList(List<GameObject> gos)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x4792310", Offset = "0x4792310", VA = "0x4792310")]
		public MB3_TextureCombiner()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public struct DRect
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B7C")]
		public double x;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double y;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double width;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double height;

		[Token(Token = "0x170000A4")]
		public Vector2 min
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x44D94E8", Offset = "0x44D94E8", VA = "0x44D94E8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector2 max
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x44D9578", Offset = "0x44D9578", VA = "0x44D9578")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170000A6")]
		public Vector2 size
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x44D9640", Offset = "0x44D9640", VA = "0x44D9640")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x44D90A0", Offset = "0x44D90A0", VA = "0x44D90A0")]
		public DRect(Rect r)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x44D91B0", Offset = "0x44D91B0", VA = "0x44D91B0")]
		public DRect(Vector2 o, Vector2 s)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x44D9318", Offset = "0x44D9318", VA = "0x44D9318")]
		public DRect(float xx, float yy, float w, float h)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x44D93A8", Offset = "0x44D93A8", VA = "0x44D93A8")]
		public DRect(double xx, double yy, double w, double h)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x44D9428", Offset = "0x44D9428", VA = "0x44D9428")]
		public Rect GetRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x44D96D0", Offset = "0x44D96D0", VA = "0x44D96D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x44D9910", Offset = "0x44D9910", VA = "0x44D9910")]
		public static bool operator ==(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x44D9A44", Offset = "0x44D9A44", VA = "0x44D9A44")]
		public static bool operator !=(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x44D9BB8", Offset = "0x44D9BB8", VA = "0x44D9BB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x44D9DD8", Offset = "0x44D9DD8", VA = "0x44D9DD8")]
		public bool Encloses(DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x44DA1AC", Offset = "0x44DA1AC", VA = "0x44DA1AC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000EB")]
	public class MB3_UVTransformUtility
	{
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x47940DC", Offset = "0x47940DC", VA = "0x47940DC")]
		public static float TransformX(DRect r, double x)
		{
			return default(float);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x478F0B4", Offset = "0x478F0B4", VA = "0x478F0B4")]
		public static DRect CombineTransforms(ref DRect r1, ref DRect r2)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4794194", Offset = "0x4794194", VA = "0x4794194")]
		public static Rect CombineTransforms(ref Rect r1, ref Rect r2)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x478D950", Offset = "0x478D950", VA = "0x478D950")]
		public static DRect InverseTransform(ref DRect t)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x478EC00", Offset = "0x478EC00", VA = "0x478EC00")]
		public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x478D414", Offset = "0x478D414", VA = "0x478D414")]
		public static void InvertHierarchy(ref DRect uvRect, ref DRect matRect)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x47943A8", Offset = "0x47943A8", VA = "0x47943A8")]
		public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4794768", Offset = "0x4794768", VA = "0x4794768")]
		public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x4794B8C", Offset = "0x4794B8C", VA = "0x4794B8C")]
		internal static Vector2 TransformPoint(ref DRect r, Vector2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4794D0C", Offset = "0x4794D0C", VA = "0x4794D0C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x19A3")]
			public Rect uvRect;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool hasOutOfBoundsUVs;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2B8C")]
			public bool hasOverlappingSubmeshVerts;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasOverlappingSubmeshTris;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float submeshArea;
		}

		[Token(Token = "0x2000164")]
		private class MB_Triangle
		{
			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int submeshIdx;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19BB")]
			private int[] vs;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x47988B8", Offset = "0x47988B8", VA = "0x47988B8")]
			public bool isSame(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x4798BC0", Offset = "0x4798BC0", VA = "0x4798BC0")]
			public bool sharesVerts(MB_Triangle obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x47986C4", Offset = "0x47986C4", VA = "0x47986C4")]
			public void Initialize(int[] ts, int idx, int sIdx)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x4798624", Offset = "0x4798624", VA = "0x4798624")]
			public MB_Triangle()
			{
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x478F5E4", Offset = "0x478F5E4", VA = "0x478F5E4")]
		public static Texture2D createTextureCopy(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x4796F68", Offset = "0x4796F68", VA = "0x4796F68")]
		public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x477C930", Offset = "0x477C930", VA = "0x477C930")]
		public static Material[] GetGOMaterials(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x477C518", Offset = "0x477C518", VA = "0x477C518")]
		public static Mesh GetMesh(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x4797150", Offset = "0x4797150", VA = "0x4797150")]
		public static Renderer GetRenderer(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x4797458", Offset = "0x4797458", VA = "0x4797458")]
		public static void DisableRendererInSource(GameObject go)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x4797784", Offset = "0x4797784", VA = "0x4797784")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x477D488", Offset = "0x477D488", VA = "0x477D488")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x479783C", Offset = "0x479783C", VA = "0x479783C")]
		public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x478B3C0", Offset = "0x478B3C0", VA = "0x478B3C0")]
		public static void setSolidColor(Texture2D t, Color c)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x478CFF4", Offset = "0x478CFF4", VA = "0x478CFF4")]
		public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x477DC04", Offset = "0x477DC04", VA = "0x477DC04")]
		public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x47916FC", Offset = "0x47916FC", VA = "0x47916FC")]
		public static int doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x4799360", Offset = "0x4799360", VA = "0x4799360")]
		public static bool GetBounds(GameObject go, out Bounds b)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x478B0D4", Offset = "0x478B0D4", VA = "0x478B0D4")]
		public static void Destroy(UnityEngine.Object o)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x47999EC", Offset = "0x47999EC", VA = "0x47999EC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x55F2BAC")]
			private StringReader json;

			[Token(Token = "0x170000E1")]
			private char PeekChar
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x47A3E0C", Offset = "0x47A3E0C", VA = "0x47A3E0C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000E2")]
			private char NextChar
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x47A39B4", Offset = "0x47A39B4", VA = "0x47A39B4")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000E3")]
			private string NextWord
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x47A3AD4", Offset = "0x47A3AD4", VA = "0x47A3AD4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0x47A2454", Offset = "0x47A2454", VA = "0x47A2454")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x47A1E80", Offset = "0x47A1E80", VA = "0x47A1E80")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x47A204C", Offset = "0x47A204C", VA = "0x47A204C")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x47A1BB8", Offset = "0x47A1BB8", VA = "0x47A1BB8")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x47A2168", Offset = "0x47A2168", VA = "0x47A2168", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x47A21C4", Offset = "0x47A21C4", VA = "0x47A21C4")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x47A32CC", Offset = "0x47A32CC", VA = "0x47A32CC")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x47A2104", Offset = "0x47A2104", VA = "0x47A2104")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x47A34F4", Offset = "0x47A34F4", VA = "0x47A34F4")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x47A2B6C", Offset = "0x47A2B6C", VA = "0x47A2B6C")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x47A3798", Offset = "0x47A3798", VA = "0x47A3798")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x47A3C70", Offset = "0x47A3C70", VA = "0x47A3C70")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000166")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private StringBuilder builder;

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x3A8C998", Offset = "0x3A8C998", VA = "0x3A8C998")]
			private Serializer()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x3A8CA40", Offset = "0x3A8CA40", VA = "0x3A8CA40")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x3A8CB34", Offset = "0x3A8CB34", VA = "0x3A8CB34")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x3A8D8C8", Offset = "0x3A8D8C8", VA = "0x3A8D8C8")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x3A8D4D8", Offset = "0x3A8D4D8", VA = "0x3A8D4D8")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x3A8CED0", Offset = "0x3A8CED0", VA = "0x3A8CED0")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x3A8DDA8", Offset = "0x3A8DDA8", VA = "0x3A8DDA8")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x47A1B38", Offset = "0x47A1B38", VA = "0x47A1B38")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x47A1E40", Offset = "0x47A1E40", VA = "0x47A1E40")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ParseHandler m_ParseHandler;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x527B490", Offset = "0x527B490", VA = "0x527B490")]
		public HeatmapDataParser()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x527B4C0", Offset = "0x527B4C0", VA = "0x527B4C0")]
		public void LoadData(string path, ParseHandler handler, bool asResource = false)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x527B674", Offset = "0x527B674", VA = "0x527B674")]
		protected void LoadStream(string path)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x527B590", Offset = "0x527B590", VA = "0x527B590")]
		protected void LoadResource(string path)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x527B910", Offset = "0x527B910", VA = "0x527B910")]
		protected void ConsumeHeatmapData(string text)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class HeatmapEvent
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19D3")]
		private static Dictionary<string, object> s_Dictionary;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x527D684", Offset = "0x527D684", VA = "0x527D684")]
		public static AnalyticsResult Send(string eventName, Vector3 v, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x527E0AC", Offset = "0x527E0AC", VA = "0x527E0AC")]
		public static AnalyticsResult Send(string eventName, Vector3 v, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x527E370", Offset = "0x527E370", VA = "0x527E370")]
		public static AnalyticsResult Send(string eventName, Vector3 v, float time, float rotation, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x527E560", Offset = "0x527E560", VA = "0x527E560")]
		public static AnalyticsResult Send(string eventName, Transform trans, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x527E9BC", Offset = "0x527E9BC", VA = "0x527E9BC")]
		public static AnalyticsResult Send(string eventName, Transform trans, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x527EC18", Offset = "0x527EC18", VA = "0x527EC18")]
		public static AnalyticsResult Send(string eventName, Vector3 v, Vector3 v1, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x527EFD4", Offset = "0x527EFD4", VA = "0x527EFD4")]
		public static AnalyticsResult Send(string eventName, Vector3 v, Vector3 v1, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x527DF40", Offset = "0x527DF40", VA = "0x527DF40")]
		protected static AnalyticsResult Commit(string eventName)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x527D7D4", Offset = "0x527D7D4", VA = "0x527D7D4")]
		protected static void AddXY(float x, float y)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x527D9A4", Offset = "0x527D9A4", VA = "0x527D9A4")]
		protected static void AddZ(float z)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x527E214", Offset = "0x527E214", VA = "0x527E214")]
		protected static void AddTime(float time)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x527E7A4", Offset = "0x527E7A4", VA = "0x527E7A4")]
		protected static void AddRotation(Vector3 r)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x527EDBC", Offset = "0x527EDBC", VA = "0x527EDBC")]
		protected static void AddDestination(Vector3 v)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x527DB00", Offset = "0x527DB00", VA = "0x527DB00")]
		protected static void AddOptions(Dictionary<string, object> options)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x527F198", Offset = "0x527F198", VA = "0x527F198")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rotation;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19D3")]
		public Vector3 destination;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
		public float density;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55F2BEC")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x106E2D0", Offset = "0x106E2D0")]
		void UpdateColors(Color[] colors);

		[Token(Token = "0x6000797")]
		void UpdateGradient(Gradient gradient);

		[Token(Token = "0x6000798")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x106E30C", Offset = "0x106E30C")]
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
