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
	[Il2CppDummyDll.FieldOffset(Offset = "0x10FB")]
	private static Color s_MediumDensityColor;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private static Color s_LowDensityColor;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2F7F060", Offset = "0x2F7F060", VA = "0x2F7F060")]
	public GradientContainer()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBE988", Offset = "0xCBE988")]
public class HeatmapController : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120ECC")]
	public string dataPath;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string[] options;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int optionIndex;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int oldOptionIndex;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1103")]
	public float pointSize;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private float oldPointSize;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120EDC")]
	private HeatmapDataParser m_DataParser;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<string, HeatPoint[]> m_Data;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Gradient gradient;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_MaxDensity;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110B")]
	private float m_MaxTime;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private Vector3 m_LowSpace;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120EEC")]
	private Vector3 m_HighSpace;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2F7F74C", Offset = "0x2F7F74C", VA = "0x2F7F74C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2F7F834", Offset = "0x2F7F834", VA = "0x2F7F834")]
	private void LoadData()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2F7F920", Offset = "0x2F7F920", VA = "0x2F7F920")]
	private void parseHandler(Dictionary<string, HeatPoint[]> heatData, string[] options)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2F7F984", Offset = "0x2F7F984", VA = "0x2F7F984")]
	private void Render()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2F80244", Offset = "0x2F80244", VA = "0x2F80244")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2F7FE70", Offset = "0x2F7FE70", VA = "0x2F7FE70")]
	private void SetLimits(HeatPoint[] points)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2F804A8", Offset = "0x2F804A8", VA = "0x2F804A8")]
	public HeatmapController()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBEA38", Offset = "0xCBEA38")]
public class HeatmapMeshRenderer : MonoBehaviour, IHeatmapRenderer
{
	[Serializable]
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0D58", Offset = "0xCC0D58")]
	private sealed class <>c
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4120F3C")]
		public static readonly <>c <>9;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<Vector3[], IEnumerable<Vector3>> <>9__54_0;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<Color32[], IEnumerable<Color32>> <>9__54_1;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2C43234", Offset = "0x2C43234", VA = "0x2C43234")]
		public <>c()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2C43264", Offset = "0x2C43264", VA = "0x2C43264")]
		internal IEnumerable<Vector3> <RenderSubmap>b__54_0(Vector3[] x)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2C43288", Offset = "0x2C43288", VA = "0x2C43288")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120EFC")]
	private float m_HighThreshold;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowThreshold;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_StartTime;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_EndTime;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111B")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC1118", Offset = "0xCC1118")]
	private float m_ParticleSize;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private bool m_Tips;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F0C")]
	private HeatPoint[] m_Data;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_MaxDensity;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowX;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_LowY;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1123")]
	private float m_LowZ;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private float m_HighX;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F1C")]
	private float m_HighY;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_HighZ;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderShape m_RenderStyle;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderDirection m_RenderDirection;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x112B")]
	private Shader m_Shader;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Material[] m_Materials;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F2C")]
	private Gradient m_Gradient;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_RenderState;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<GameObject> m_GameObjects;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC1168", Offset = "0xCC1168")]
	private bool <allowRender>k__BackingField;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1133")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC11A4", Offset = "0xCC11A4")]
	private int <currentPoints>k__BackingField;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC11E0", Offset = "0xCC11E0")]
	private int <totalPoints>k__BackingField;

	[Token(Token = "0x17000001")]
	public float pointSize
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2F811BC", Offset = "0x2F811BC", VA = "0x2F811BC", Slot = "12")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2F811EC", Offset = "0x2F811EC", VA = "0x2F811EC", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public bool activateTips
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2F81270", Offset = "0x2F81270", VA = "0x2F81270", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2F812B4", Offset = "0x2F812B4", VA = "0x2F812B4", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool allowRender
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2F8157C", Offset = "0x2F8157C", VA = "0x2F8157C", Slot = "14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCBB8", Offset = "0xCCCBB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2F815C0", Offset = "0x2F815C0", VA = "0x2F815C0", Slot = "15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCBF4", Offset = "0xCCCBF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public int currentPoints
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2F8160C", Offset = "0x2F8160C", VA = "0x2F8160C", Slot = "18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCC30", Offset = "0xCCCC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2F8163C", Offset = "0x2F8163C", VA = "0x2F8163C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCC6C", Offset = "0xCCCC6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int totalPoints
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2F81674", Offset = "0x2F81674", VA = "0x2F81674", Slot = "19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCCA8", Offset = "0xCCCCA8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2F816A4", Offset = "0x2F816A4", VA = "0x2F816A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCCE4", Offset = "0xCCCCE4")]
		set
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2F80630", Offset = "0x2F80630", VA = "0x2F80630")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2F806C4", Offset = "0x2F806C4", VA = "0x2F806C4", Slot = "4")]
	public void UpdatePointData(HeatPoint[] newData, float newMaxDensity)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2F80728", Offset = "0x2F80728", VA = "0x2F80728", Slot = "5")]
	public void UpdateColors(Color[] colors)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2F80740", Offset = "0x2F80740", VA = "0x2F80740", Slot = "7")]
	public void UpdateThresholds(float[] threshholds)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2F80758", Offset = "0x2F80758", VA = "0x2F80758", Slot = "6")]
	public void UpdateGradient(Gradient gradient)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2F80F44", Offset = "0x2F80F44", VA = "0x2F80F44", Slot = "8")]
	public void UpdateRenderMask(float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2F816DC", Offset = "0x2F816DC", VA = "0x2F816DC", Slot = "9")]
	public void UpdateTimeLimits(float startTime, float endTime)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2F817AC", Offset = "0x2F817AC", VA = "0x2F817AC", Slot = "11")]
	public void UpdateRenderStyle(RenderShape style, RenderDirection direction)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2F81870", Offset = "0x2F81870", VA = "0x2F81870", Slot = "10")]
	public void RenderHeatmap()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2F81EC8", Offset = "0x2F81EC8", VA = "0x2F81EC8")]
	private void CreatePoints()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2F830D8", Offset = "0x2F830D8", VA = "0x2F830D8")]
	private void RenderSubmap(GameObject go, List<HeatPoint> submap)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2F87E9C", Offset = "0x2F87E9C", VA = "0x2F87E9C")]
	private Color32[] AddColorsToMesh(int count, HeatPoint pt)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2F84270", Offset = "0x2F84270", VA = "0x2F84270")]
	private Vector3[] AddCubeVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2F84A18", Offset = "0x2F84A18", VA = "0x2F84A18")]
	private int[] AddCubeTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2F84BF4", Offset = "0x2F84BF4", VA = "0x2F84BF4")]
	private Vector3[] AddArrowVectorsToMesh(Vector3 position, Vector3 rotation)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2F85428", Offset = "0x2F85428", VA = "0x2F85428")]
	private int[] AddArrowTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2F85604", Offset = "0x2F85604", VA = "0x2F85604")]
	private Vector3[] AddSquareVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2F85DE4", Offset = "0x2F85DE4", VA = "0x2F85DE4")]
	private int[] AddSquareTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2F86030", Offset = "0x2F86030", VA = "0x2F86030")]
	private Vector3[] AddTriVectorsToMesh(float x, float y, float z)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2F86628", Offset = "0x2F86628", VA = "0x2F86628")]
	private int[] AddTriTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2F86794", Offset = "0x2F86794", VA = "0x2F86794")]
	private Vector3[] AddP2PVectorsToMesh(Vector3 fromVector, Vector3 toVector)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2F876A8", Offset = "0x2F876A8", VA = "0x2F876A8")]
	private int[] AddP2PTrisToMesh(int offset)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2F82EE4", Offset = "0x2F82EE4", VA = "0x2F82EE4")]
	private bool hasData()
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2F82FC0", Offset = "0x2F82FC0", VA = "0x2F82FC0")]
	private int GetVecticesForShape()
	{
		return default(int);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2F88138", Offset = "0x2F88138", VA = "0x2F88138")]
	private int GetTrianglesForShape()
	{
		return default(int);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2F88250", Offset = "0x2F88250", VA = "0x2F88250")]
	private Color PickGradientColor(float percent)
	{
		return default(Color);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2F80978", Offset = "0x2F80978", VA = "0x2F80978")]
	public static bool CompareGradients(Gradient gradient, Gradient otherGradient)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2F882C0", Offset = "0x2F882C0", VA = "0x2F882C0")]
	public HeatmapMeshRenderer()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBEAE8", Offset = "0xCBEAE8")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBEAE8", Offset = "0xCBEAE8")]
[ExecuteInEditMode]
public class HeatmapSubmap : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<HeatPoint> m_PointData;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x113B")]
	public int m_TrianglesPerShape;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2C432AC", Offset = "0x2C432AC", VA = "0x2C432AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2C433E4", Offset = "0x2C433E4", VA = "0x2C433E4")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F4C")]
	private static AndroidJavaClass m_deviceStatusInterfaceClass;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2C5E13C", Offset = "0x2C5E13C", VA = "0x2C5E13C")]
	public static double Uptime()
	{
		return default(double);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2C5E30C", Offset = "0x2C5E30C", VA = "0x2C5E30C")]
	public static void InitMach()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2C5E31C", Offset = "0x2C5E31C", VA = "0x2C5E31C")]
	public MachBinding()
	{
	}
}
[Token(Token = "0x2000007")]
public class MachTest : MonoBehaviour
{
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2C5E40C", Offset = "0x2C5E40C", VA = "0x2C5E40C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2C5E4F0", Offset = "0x2C5E4F0", VA = "0x2C5E4F0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2C5E7A4", Offset = "0x2C5E7A4", VA = "0x2C5E7A4")]
	public static double GetDeviceUptime()
	{
		return default(double);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2C5E7B8", Offset = "0x2C5E7B8", VA = "0x2C5E7B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2C5E7E8", Offset = "0x2C5E7E8", VA = "0x2C5E7E8")]
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
	[Address(RVA = "0x34BE62C", Offset = "0x34BE62C", VA = "0x34BE62C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x34BEA44", Offset = "0x34BEA44", VA = "0x34BEA44")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000009")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2C57914", Offset = "0x2C57914", VA = "0x2C57914")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2C579B8", Offset = "0x2C579B8", VA = "0x2C579B8")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x1143")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F5C")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2C5A93C", Offset = "0x2C5A93C", VA = "0x2C5A93C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2C5AADC", Offset = "0x2C5AADC", VA = "0x2C5AADC")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2C5B500", Offset = "0x2C5B500", VA = "0x2C5B500")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x200000B")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2C58E20", Offset = "0x2C58E20", VA = "0x2C58E20")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2C58EC4", Offset = "0x2C58EC4", VA = "0x2C58EC4")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0D94", Offset = "0xCC0D94")]
	private sealed class <largeNumber>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int <>1__state;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4120F6C")]
		private object <>2__current;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x2C58514", Offset = "0x2C58514", VA = "0x2C58514", Slot = "4")]
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
			[Address(RVA = "0x2C585E4", Offset = "0x2C585E4", VA = "0x2C585E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2C57FC8", Offset = "0x2C57FC8", VA = "0x2C57FC8")]
		[DebuggerHidden]
		public <largeNumber>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2C5816C", Offset = "0x2C5816C", VA = "0x2C5816C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2C58180", Offset = "0x2C58180", VA = "0x2C58180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2C58544", Offset = "0x2C58544", VA = "0x2C58544", Slot = "8")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MB3_MeshBaker mbd;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114B")]
	private GameObject[] objs;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2C579E8", Offset = "0x2C579E8", VA = "0x2C579E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2C57F0C", Offset = "0x2C57F0C", VA = "0x2C57F0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCCD20", Offset = "0xCCCD20")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2C58010", Offset = "0x2C58010", VA = "0x2C58010")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2C580B4", Offset = "0x2C580B4", VA = "0x2C580B4")]
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
	[Address(RVA = "0x2C58614", Offset = "0x2C58614", VA = "0x2C58614")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2C586C0", Offset = "0x2C586C0", VA = "0x2C586C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2C58804", Offset = "0x2C58804", VA = "0x2C58804")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2C588A8", Offset = "0x2C588A8", VA = "0x2C588A8")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x200000E")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1153")]
	public int axis;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2C588D8", Offset = "0x2C588D8", VA = "0x2C588D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2C58AA4", Offset = "0x2C58AA4", VA = "0x2C58AA4")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000F")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2C58AD4", Offset = "0x2C58AD4", VA = "0x2C58AD4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2C58B78", Offset = "0x2C58B78", VA = "0x2C58B78")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x2000010")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F7C")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x115B")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private GameObject swordInstance;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F8C")]
	private GameObject glassesInstance;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private GameObject hatInstance;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2C58EF4", Offset = "0x2C58EF4", VA = "0x2C58EF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2C591D8", Offset = "0x2C591D8", VA = "0x2C591D8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2C5A664", Offset = "0x2C5A664", VA = "0x2C5A664")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2C5A90C", Offset = "0x2C5A90C", VA = "0x2C5A90C")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x1163")]
	public string[] texPropertyNames;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2C568B0", Offset = "0x2C568B0", VA = "0x2C568B0")]
	public MB_AtlasesAndRects()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class MB_MultiMaterial
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Material combinedMaterial;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120F9C")]
	public List<Material> sourceMaterials;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2C44750", Offset = "0x2C44750", VA = "0x2C44750")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect atlasSubrectMaterialOnly;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2C444E8", Offset = "0x2C444E8", VA = "0x2C444E8")]
	public MB_MaterialAndUVRect(Material m, Rect destRect, Rect matTilingTransformRect)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2C58BA8", Offset = "0x2C58BA8", VA = "0x2C58BA8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2C58C1C", Offset = "0x2C58C1C", VA = "0x2C58C1C", Slot = "0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x4120FBC")]
		private MB2_TextureBakeResults tbr;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] numTimesMatAppearsInAtlas;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MB_MaterialAndUVRect[] matsAndSrcUVRect;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2C452F0", Offset = "0x2C452F0", VA = "0x2C452F0")]
		public Material2AtlasRectangleMapper(MB2_TextureBakeResults res)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2C45ADC", Offset = "0x2C45ADC", VA = "0x2C45ADC")]
		public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, MB3_MeshCombinerSingle.MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out Rect rectInAtlas, out Rect subrectInAtlasMatTiling, ref string errorMsg)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x116B")]
	public MB_AtlasesAndRects[] combinedMaterialInfo;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public Material[] materials;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120FAC")]
	public Rect[] prefabUVRects;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_MaterialAndUVRect[] materialsAndUVRects;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material resultMaterial;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1173")]
	public bool doMultiMaterial;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2C43414", Offset = "0x2C43414", VA = "0x2C43414")]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(Renderer r)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2C44808", Offset = "0x2C44808", VA = "0x2C44808")]
	public bool ContainsMaterial(Material m)
	{
		return default(bool);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2C44BC0", Offset = "0x2C44BC0", VA = "0x2C44BC0")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2C452C0", Offset = "0x2C452C0", VA = "0x2C452C0")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x117B")]
	private Transform[] bones;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2C46894", Offset = "0x2C46894", VA = "0x2C46894")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2C46AFC", Offset = "0x2C46AFC", VA = "0x2C46AFC")]
	private void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2C46C3C", Offset = "0x2C46C3C", VA = "0x2C46C3C")]
	public MB2_UpdateSkinnedMeshBoundsFromBones()
	{
	}
}
[Token(Token = "0x2000016")]
public class MB2_UpdateSkinnedMeshBoundsFromBounds : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public List<GameObject> objects;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120FCC")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2C46C6C", Offset = "0x2C46C6C", VA = "0x2C46C6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2C472C0", Offset = "0x2C472C0", VA = "0x2C472C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2C4742C", Offset = "0x2C4742C", VA = "0x2C4742C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1183")]
		public GameObject resultPrefab;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2C4956C", Offset = "0x2C4956C", VA = "0x2C4956C")]
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
	[Address(RVA = "0x2C4953C", Offset = "0x2C4953C", VA = "0x2C4953C")]
	public MB3_BatchPrefabBaker()
	{
	}
}
[Token(Token = "0x2000018")]
public class MB3_BoneWeightCopier : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public GameObject inputGameObject;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120FDC")]
	public GameObject outputPrefab;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float radius;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public SkinnedMeshRenderer seamMesh;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string outputFolder;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2C4959C", Offset = "0x2C4959C", VA = "0x2C4959C")]
	public MB3_BoneWeightCopier()
	{
	}
}
[Token(Token = "0x2000019")]
public class MB3_DisableHiddenAnimations : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118B")]
	public List<Animation> animationsToCull;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2C495E4", Offset = "0x2C495E4", VA = "0x2C495E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2C497D8", Offset = "0x2C497D8", VA = "0x2C497D8")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2C499F8", Offset = "0x2C499F8", VA = "0x2C499F8")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2C49C18", Offset = "0x2C49C18", VA = "0x2C49C18")]
	public MB3_DisableHiddenAnimations()
	{
	}
}
[Token(Token = "0x200001A")]
public class MB3_MeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected MB3_MeshCombinerSingle _meshCombiner;

	[Token(Token = "0x17000006")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2C49CD0", Offset = "0x2C49CD0", VA = "0x2C49CD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2C49D00", Offset = "0x2C49D00", VA = "0x2C49D00")]
	public void BuildSceneMeshObject()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2C49D64", Offset = "0x2C49D64", VA = "0x2C49D64", Slot = "23")]
	public virtual bool ShowHide(GameObject[] gos, GameObject[] deleteGOs)
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2C49DE8", Offset = "0x2C49DE8", VA = "0x2C49DE8", Slot = "24")]
	public virtual void ApplyShowHide()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2C49E30", Offset = "0x2C49E30", VA = "0x2C49E30", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2C49F7C", Offset = "0x2C49F7C", VA = "0x2C49F7C", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2C4A0C8", Offset = "0x2C4A0C8", VA = "0x2C4A0C8")]
	public MB3_MeshBaker()
	{
	}
}
[Token(Token = "0x200001B")]
public abstract class MB3_MeshBakerCommon : MB3_MeshBakerRoot
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120FEC")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool useObjsToMeshFromTexBaker;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool clearBuffersAfterBake;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string bakeAssetsInPlaceFolderPath;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1193")]
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
		[Address(RVA = "0x2C4A1CC", Offset = "0x2C4A1CC", VA = "0x2C4A1CC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2C4A224", Offset = "0x2C4A224", VA = "0x2C4A224", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2C4A284", Offset = "0x2C4A284", VA = "0x2C4A284", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2C4A690", Offset = "0x2C4A690", VA = "0x2C4A690")]
	public void EnableDisableSourceObjectRenderers(bool show)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2C4A994", Offset = "0x2C4A994", VA = "0x2C4A994", Slot = "8")]
	public virtual void ClearMesh()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2C4A9E4", Offset = "0x2C4A9E4", VA = "0x2C4A9E4", Slot = "9")]
	public virtual void DestroyMesh()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2C4AA34", Offset = "0x2C4AA34", VA = "0x2C4AA34", Slot = "10")]
	public virtual void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2C4AA94", Offset = "0x2C4AA94", VA = "0x2C4AA94", Slot = "11")]
	public virtual int GetNumObjectsInCombined()
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2C4AAEC", Offset = "0x2C4AAEC", VA = "0x2C4AAEC", Slot = "12")]
	public virtual int GetNumVerticesFor(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2C4AB54", Offset = "0x2C4AB54", VA = "0x2C4AB54")]
	public MB3_TextureBaker GetTextureBaker()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	[Token(Token = "0x600007C")]
	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true);

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2C4ADC8", Offset = "0x2C4ADC8", VA = "0x2C4ADC8", Slot = "15")]
	public virtual void Apply([Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2C4AED0", Offset = "0x2C4AED0", VA = "0x2C4AED0", Slot = "16")]
	public virtual void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2C4B180", Offset = "0x2C4B180", VA = "0x2C4B180", Slot = "17")]
	public virtual bool CombinedMeshContains(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2C4B1FC", Offset = "0x2C4B1FC", VA = "0x2C4B1FC", Slot = "18")]
	public virtual void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV1 = false, bool updateUV2 = false, bool updateColors = false, bool updateSkinningInfo = false)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2C4B47C", Offset = "0x2C4B47C", VA = "0x2C4B47C", Slot = "19")]
	public virtual void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2C4B4F4", Offset = "0x2C4B4F4", VA = "0x2C4B4F4", Slot = "20")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2C4B56C", Offset = "0x2C4B56C", VA = "0x2C4B56C", Slot = "21")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2C4B5E4", Offset = "0x2C4B5E4", VA = "0x2C4B5E4", Slot = "22")]
	protected virtual bool _ValidateForUpdateSkinnedMeshBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2C4A170", Offset = "0x2C4A170", VA = "0x2C4A170")]
	protected MB3_MeshBakerCommon()
	{
	}
}
[Token(Token = "0x200001C")]
public class MB3_MeshBakerGrouper : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public MB3_MeshBakerGrouperCore grouper;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4120FFC")]
	[HideInInspector]
	public Bounds sourceObjectBounds;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2C4BAA0", Offset = "0x2C4BAA0", VA = "0x2C4BAA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2C4D850", Offset = "0x2C4D850", VA = "0x2C4D850")]
	public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2C4DDC4", Offset = "0x2C4DDC4", VA = "0x2C4DDC4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 cellSize;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A3")]
		public int pieNumSegments;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 pieAxis;

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2C4EAD0", Offset = "0x2C4EAD0", VA = "0x2C4EAD0")]
		public Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2C4F66C", Offset = "0x2C4F66C", VA = "0x2C4F66C")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsNone(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2C4F978", Offset = "0x2C4F978", VA = "0x2C4F978")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsGrid(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2C5055C", Offset = "0x2C5055C", VA = "0x2C5055C")]
		public Dictionary<string, List<Renderer>> FilterIntoGroupsPie(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2C514F4", Offset = "0x2C514F4", VA = "0x2C514F4")]
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
	[Address(RVA = "0x2C4DF0C", Offset = "0x2C4DF0C", VA = "0x2C4DF0C")]
	public void DoClustering(MB3_TextureBaker tb)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2C4EC6C", Offset = "0x2C4EC6C", VA = "0x2C4EC6C")]
	private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2C4F010", Offset = "0x2C4F010", VA = "0x2C4F010")]
	private void AddMeshBaker(MB3_TextureBaker tb, string key, List<Renderer> gaws)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2C4F63C", Offset = "0x2C4F63C", VA = "0x2C4F63C")]
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
	[Address(RVA = "0x2C515E4", Offset = "0x2C515E4", VA = "0x2C515E4", Slot = "6")]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2C51600", Offset = "0x2C51600", VA = "0x2C51600")]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2C4BA70", Offset = "0x2C4BA70", VA = "0x2C4BA70")]
	protected MB3_MeshBakerRoot()
	{
	}
}
[Token(Token = "0x200001F")]
public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412101C")]
	[SerializeField]
	protected MB3_MultiMeshCombiner _meshCombiner;

	[Token(Token = "0x1700000A")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2C52A8C", Offset = "0x2C52A8C", VA = "0x2C52A8C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2C52ABC", Offset = "0x2C52ABC", VA = "0x2C52ABC", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2C52D9C", Offset = "0x2C52D9C", VA = "0x2C52D9C", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2C5307C", Offset = "0x2C5307C", VA = "0x2C5307C")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected int _atlasPadding;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11AB")]
	[SerializeField]
	protected int _maxAtlasSize;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected bool _resizePowerOfTwoTextures;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412102C")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11B3")]
	[SerializeField]
	protected List<ShaderTextureProperty> _customShaderProperties;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	[SerializeField]
	protected List<string> _customShaderPropNames_Depricated;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412103C")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11BB")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x1700000B")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2C53124", Offset = "0x2C53124", VA = "0x2C53124", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2C53154", Offset = "0x2C53154", VA = "0x2C53154", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public virtual int atlasPadding
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2C5318C", Offset = "0x2C5318C", VA = "0x2C5318C", Slot = "7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2C531BC", Offset = "0x2C531BC", VA = "0x2C531BC", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public virtual int maxAtlasSize
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2C531F4", Offset = "0x2C531F4", VA = "0x2C531F4", Slot = "9")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2C53224", Offset = "0x2C53224", VA = "0x2C53224", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual bool resizePowerOfTwoTextures
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2C5325C", Offset = "0x2C5325C", VA = "0x2C5325C", Slot = "11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2C532A0", Offset = "0x2C532A0", VA = "0x2C532A0", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public virtual bool fixOutOfBoundsUVs
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2C532EC", Offset = "0x2C532EC", VA = "0x2C532EC", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2C53330", Offset = "0x2C53330", VA = "0x2C53330", Slot = "14")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public virtual int maxTilingBakeSize
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2C5337C", Offset = "0x2C5337C", VA = "0x2C5337C", Slot = "15")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2C533AC", Offset = "0x2C533AC", VA = "0x2C533AC", Slot = "16")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2C533E4", Offset = "0x2C533E4", VA = "0x2C533E4", Slot = "17")]
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2C53414", Offset = "0x2C53414", VA = "0x2C53414", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2C5344C", Offset = "0x2C5344C", VA = "0x2C5344C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2C53490", Offset = "0x2C53490", VA = "0x2C53490")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2C534DC", Offset = "0x2C534DC", VA = "0x2C534DC", Slot = "19")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2C5350C", Offset = "0x2C5350C", VA = "0x2C5350C", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public virtual List<string> customShaderPropNames
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2C53544", Offset = "0x2C53544", VA = "0x2C53544", Slot = "21")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2C53574", Offset = "0x2C53574", VA = "0x2C53574", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public virtual bool doMultiMaterial
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2C535AC", Offset = "0x2C535AC", VA = "0x2C535AC", Slot = "23")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2C535F0", Offset = "0x2C535F0", VA = "0x2C535F0", Slot = "24")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public virtual Material resultMaterial
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2C5363C", Offset = "0x2C5363C", VA = "0x2C5363C", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2C5366C", Offset = "0x2C5366C", VA = "0x2C5366C", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool considerNonTextureProperties
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2C536A4", Offset = "0x2C536A4", VA = "0x2C536A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2C536E8", Offset = "0x2C536E8", VA = "0x2C536E8")]
		set
		{
		}
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2C53734", Offset = "0x2C53734", VA = "0x2C53734", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2C53818", Offset = "0x2C53818", VA = "0x2C53818")]
	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2C53864", Offset = "0x2C53864", VA = "0x2C53864")]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2C53FE4", Offset = "0x2C53FE4", VA = "0x2C53FE4")]
	private MB_AtlasesAndRects[] _CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2C568E0", Offset = "0x2C568E0", VA = "0x2C568E0")]
	private void unpackMat2RectMap(MB2_TextureBakeResults tbr)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2C56D5C", Offset = "0x2C56D5C", VA = "0x2C56D5C")]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2C5731C", Offset = "0x2C5731C", VA = "0x2C5731C")]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2C55844", Offset = "0x2C55844", VA = "0x2C55844")]
	private bool _ValidateResultMaterials()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2C57764", Offset = "0x2C57764", VA = "0x2C57764")]
	public MB3_TextureBaker()
	{
	}
}
[Token(Token = "0x2000021")]
public class MB_TextureCombinerRenderTexture
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412104C")]
	private Material mat;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private RenderTexture _destinationTexture;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Camera myCamera;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int _padding;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C3")]
	private bool _isNormalMap;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412105C")]
	private bool _considerNonTextureProperties;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Rect[] rs;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<MB3_TextureCombiner.MB_TexSet> textureSets;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11CB")]
	private int indexOfTexSetToRender;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	private ShaderTextureProperty _texPropertyName;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412106C")]
	private TextureBlender _resultMaterialTextureBlender;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Texture2D targTex;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MB3_TextureCombiner combiner;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2C476D8", Offset = "0x2C476D8", VA = "0x2C476D8")]
	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB3_TextureCombiner.MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, TextureBlender resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2C48010", Offset = "0x2C48010", VA = "0x2C48010")]
	public void OnRenderObject()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2C5DD7C", Offset = "0x2C5DD7C", VA = "0x2C5DD7C")]
	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2C5DCC4", Offset = "0x2C5DCC4", VA = "0x2C5DCC4")]
	private bool IsOpenGL()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2C5BC00", Offset = "0x2C5BC00", VA = "0x2C5BC00")]
	private void CopyScaledAndTiledToAtlas(MB3_TextureCombiner.MB_TexSet texSet, MB3_TextureCombiner.MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, TextureBlender resultMatTexBlender)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2C5B530", Offset = "0x2C5B530", VA = "0x2C5B530")]
	private void _printTexture(Texture2D t)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2C47694", Offset = "0x2C47694", VA = "0x2C47694")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D3")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public int width;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412107C")]
	public int height;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int padding;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isNormalMap;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11DB")]
	public bool considerNonTextureProperties;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public TextureBlender resultMaterialTextureBlender;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412108C")]
	public Rect[] rects;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Texture2D tex1;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<MB3_TextureCombiner.MB_TexSet> textureSets;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int indexOfTexSetToRender;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11E3")]
	public ShaderTextureProperty texPropertyName;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x412109C")]
	public Texture2D testTex;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Material testMat;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2C4745C", Offset = "0x2C4745C", VA = "0x2C4745C")]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2C47F90", Offset = "0x2C47F90", VA = "0x2C47F90")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2C494F8", Offset = "0x2C494F8", VA = "0x2C494F8")]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
[Token(Token = "0x2000023")]
public class BulletHole : MonoBehaviour
{
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0DD0", Offset = "0xCC0DD0")]
	private sealed class <DestroyDelayed>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11EB")]
		private object <>2__current;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public BulletHole <>4__this;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x34BEE70", Offset = "0x34BEE70", VA = "0x34BEE70", Slot = "4")]
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
			[Address(RVA = "0x34BEF40", Offset = "0x34BEF40", VA = "0x34BEF40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x34BEB78", Offset = "0x34BEB78", VA = "0x34BEB78")]
		[DebuggerHidden]
		public <DestroyDelayed>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x34BEC04", Offset = "0x34BEC04", VA = "0x34BEC04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x34BEC18", Offset = "0x34BEC18", VA = "0x34BEC18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x34BEEA0", Offset = "0x34BEEA0", VA = "0x34BEEA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float lifeTime;

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x34BEA74", Offset = "0x34BEA74", VA = "0x34BEA74")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x34BEABC", Offset = "0x34BEABC", VA = "0x34BEABC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCCDD0", Offset = "0xCCCDD0")]
	private IEnumerator DestroyDelayed()
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x34BEBC0", Offset = "0x34BEBC0", VA = "0x34BEBC0")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x41210AC")]
	public Mode action;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public UnityEngine.Object target;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject source;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int triggerCount;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11F3")]
	public bool repeatTrigger;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x34BDF6C", Offset = "0x34BDF6C", VA = "0x34BDF6C")]
	private void DoActivateTrigger()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x34BE5A0", Offset = "0x34BE5A0", VA = "0x34BE5A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x34BE5D4", Offset = "0x34BE5D4", VA = "0x34BE5D4")]
	public ActivateTrigger()
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBEC3C", Offset = "0xCBEC3C")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x3FD3758", Offset = "0x3FD3758", VA = "0x3FD3758")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3FD37C0", Offset = "0x3FD37C0", VA = "0x3FD37C0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3FD3860", Offset = "0x3FD3860", VA = "0x3FD3860")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3FD3900", Offset = "0x3FD3900", VA = "0x3FD3900")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBED08", Offset = "0xCBED08")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3FD3930", Offset = "0x3FD3930", VA = "0x3FD3930")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MeshContainer
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41210CC")]
		public Mesh mesh;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3[] vertices;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3[] normals;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3FD3960", Offset = "0x3FD3960", VA = "0x3FD3960")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3FD3A04", Offset = "0x3FD3A04", VA = "0x3FD3A04")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBEDD4", Offset = "0xCBEDD4")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1203")]
		public bool reflectSkybox;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Color clearColor;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41210DC")]
		public string reflectionSampler;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120B")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3FD3A8C", Offset = "0x3FD3A8C", VA = "0x3FD3A8C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3FD3C28", Offset = "0x3FD3C28", VA = "0x3FD3C28")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3FD427C", Offset = "0x3FD427C", VA = "0x3FD427C")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3FD43C4", Offset = "0x3FD43C4", VA = "0x3FD43C4")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3FD4594", Offset = "0x3FD4594", VA = "0x3FD4594")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3FD5B18", Offset = "0x3FD5B18", VA = "0x3FD5B18")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3FD5BD4", Offset = "0x3FD5BD4", VA = "0x3FD5BD4")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x3FD5DF0", Offset = "0x3FD5DF0", VA = "0x3FD5DF0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x3FD5E90", Offset = "0x3FD5E90", VA = "0x3FD5E90")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3FD48BC", Offset = "0x3FD48BC", VA = "0x3FD48BC")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x3FD5F30", Offset = "0x3FD5F30", VA = "0x3FD5F30")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x3FD68D0", Offset = "0x3FD68D0", VA = "0x3FD68D0")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x3FD600C", Offset = "0x3FD600C", VA = "0x3FD600C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x3FD6CD4", Offset = "0x3FD6CD4", VA = "0x3FD6CD4")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x3FD64A0", Offset = "0x3FD64A0", VA = "0x3FD64A0")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3FD6D5C", Offset = "0x3FD6D5C", VA = "0x3FD6D5C")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBEEA0", Offset = "0xCBEEA0")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41210EC")]
		public Transform specularLight;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3FD6E18", Offset = "0x3FD6E18", VA = "0x3FD6E18")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x3FD6FAC", Offset = "0x3FD6FAC", VA = "0x3FD6FAC")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x3FD739C", Offset = "0x3FD739C", VA = "0x3FD739C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1213")]
		public int textureSize;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41210FC")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121B")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412110C")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3FD73CC", Offset = "0x3FD73CC", VA = "0x3FD73CC")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3FDAFD4", Offset = "0x3FDAFD4", VA = "0x3FDAFD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x3FDA03C", Offset = "0x3FDA03C", VA = "0x3FDA03C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x3FD8DE8", Offset = "0x3FD8DE8", VA = "0x3FD8DE8")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x3FD8D64", Offset = "0x3FD8D64", VA = "0x3FD8D64")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x3FD8A64", Offset = "0x3FD8A64", VA = "0x3FD8A64")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3FDABA4", Offset = "0x3FDABA4", VA = "0x3FDABA4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x3FDA644", Offset = "0x3FDA644", VA = "0x3FDA644")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x3FDB8E8", Offset = "0x3FDB8E8", VA = "0x3FDB8E8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x412112C")]
		public Material sharedMaterial;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool edgeBlend;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x3FDBAFC", Offset = "0x3FDBAFC", VA = "0x3FDBAFC")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x3FDBE44", Offset = "0x3FDBE44", VA = "0x3FDBE44")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x3FDBFC4", Offset = "0x3FDBFC4", VA = "0x3FDBFC4")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x3FDC0DC", Offset = "0x3FDC0DC", VA = "0x3FDC0DC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1233")]
		public WaterBase waterBase;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x3FDC138", Offset = "0x3FDC138", VA = "0x3FDC138")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x3FDC168", Offset = "0x3FDC168", VA = "0x3FDC168")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x3FDC5B4", Offset = "0x3FDC5B4", VA = "0x3FDC5B4")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x3FDC7E0", Offset = "0x3FDC7E0", VA = "0x3FDC7E0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform target;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412113C")]
		public Transform rotationSpace;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateMode updateMode;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool lockCursor;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool smoothFollow;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x123B")]
		public float followSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float distance;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412114C")]
		public float minDistance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxDistance;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSpeed;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSensitivity;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1243")]
		public float rotationSensitivity;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float yMinLimit;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412115C")]
		public float yMaxLimit;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateAlways;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124B")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412116C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC1618", Offset = "0xCC1618")]
		private float <x>k__BackingField;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC1654", Offset = "0xCC1654")]
		private float <y>k__BackingField;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC1690", Offset = "0xCC1690")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1253")]
		private Vector3 position;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion rotation;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412117C")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
			[Address(RVA = "0x2C721DC", Offset = "0x2C721DC", VA = "0x2C721DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCE80", Offset = "0xCCCE80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2C7220C", Offset = "0x2C7220C", VA = "0x2C7220C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCEBC", Offset = "0xCCCEBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float y
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2C72244", Offset = "0x2C72244", VA = "0x2C72244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCEF8", Offset = "0xCCCEF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2C72274", Offset = "0x2C72274", VA = "0x2C72274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCF34", Offset = "0xCCCF34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float distanceTarget
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2C722AC", Offset = "0x2C722AC", VA = "0x2C722AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCF70", Offset = "0xCCCF70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2C722DC", Offset = "0x2C722DC", VA = "0x2C722DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCCFAC", Offset = "0xCCCFAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		private float zoomAdd
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2C72E90", Offset = "0x2C72E90", VA = "0x2C72E90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2C72314", Offset = "0x2C72314", VA = "0x2C72314", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2C72648", Offset = "0x2C72648", VA = "0x2C72648", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2C726DC", Offset = "0x2C726DC", VA = "0x2C726DC", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2C7273C", Offset = "0x2C7273C", VA = "0x2C7273C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2C727A8", Offset = "0x2C727A8", VA = "0x2C727A8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2C72698", Offset = "0x2C72698", VA = "0x2C72698")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2C72FBC", Offset = "0x2C72FBC", VA = "0x2C72FBC")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2C72CD4", Offset = "0x2C72CD4", VA = "0x2C72CD4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2C73AB8", Offset = "0x2C73AB8", VA = "0x2C73AB8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1263")]
		public float yMaxLimit;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float x;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412119C")]
		private float y;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2C73CC4", Offset = "0x2C73CC4", VA = "0x2C73CC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2C73D8C", Offset = "0x2C73D8C", VA = "0x2C73D8C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2C740DC", Offset = "0x2C740DC", VA = "0x2C740DC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2C74298", Offset = "0x2C74298", VA = "0x2C74298")]
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
		[Address(RVA = "0x2C624FC", Offset = "0x2C624FC", VA = "0x2C624FC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2C626BC", Offset = "0x2C626BC", VA = "0x2C626BC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2C628E4", Offset = "0x2C628E4", VA = "0x2C628E4")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2C62CF4", Offset = "0x2C62CF4", VA = "0x2C62CF4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2C62B74", Offset = "0x2C62B74", VA = "0x2C62B74")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2C62F84", Offset = "0x2C62F84", VA = "0x2C62F84")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2C63554", Offset = "0x2C63554", VA = "0x2C63554")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1273")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x2C639E8", Offset = "0x2C639E8", VA = "0x2C639E8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41211AC")]
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
			[Address(RVA = "0x2C63614", Offset = "0x2C63614", VA = "0x2C63614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2C63AE0", Offset = "0x2C63AE0", VA = "0x2C63AE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2C63584", Offset = "0x2C63584", VA = "0x2C63584")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x41211BC")]
		public static string[] typeLeft;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeRight;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeSpine;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeHead;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127B")]
		public static string[] typeArm;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeLeg;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41211CC")]
		public static string[] typeTail;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeEye;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExclude;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1283")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41211DC")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] pelvis;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128B")]
		public static string[] hand;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public static string[] foot;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2C63EB4", Offset = "0x2C63EB4", VA = "0x2C63EB4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2C6469C", Offset = "0x2C6469C", VA = "0x2C6469C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2C64C04", Offset = "0x2C64C04", VA = "0x2C64C04")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2C64D4C", Offset = "0x2C64D4C", VA = "0x2C64D4C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2C64EE0", Offset = "0x2C64EE0", VA = "0x2C64EE0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2C64260", Offset = "0x2C64260", VA = "0x2C64260")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2C64A48", Offset = "0x2C64A48", VA = "0x2C64A48")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2C666D8", Offset = "0x2C666D8", VA = "0x2C666D8")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2C66170", Offset = "0x2C66170", VA = "0x2C66170")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2C66424", Offset = "0x2C66424", VA = "0x2C66424")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2C65468", Offset = "0x2C65468", VA = "0x2C65468")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2C65694", Offset = "0x2C65694", VA = "0x2C65694")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2C658C0", Offset = "0x2C658C0", VA = "0x2C658C0")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2C65AEC", Offset = "0x2C65AEC", VA = "0x2C65AEC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2C65D18", Offset = "0x2C65D18", VA = "0x2C65D18")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2C65F44", Offset = "0x2C65F44", VA = "0x2C65F44")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2C66BBC", Offset = "0x2C66BBC", VA = "0x2C66BBC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2C651F8", Offset = "0x2C651F8", VA = "0x2C651F8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2C66A60", Offset = "0x2C66A60", VA = "0x2C66A60")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2C66CE0", Offset = "0x2C66CE0", VA = "0x2C66CE0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2C66EF0", Offset = "0x2C66EF0", VA = "0x2C66EF0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C66954", Offset = "0x2C66954", VA = "0x2C66954")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2C66810", Offset = "0x2C66810", VA = "0x2C66810")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x412122C")]
			public bool includeEyes;

			[Token(Token = "0x170000B0")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x2C72154", Offset = "0x2C72154", VA = "0x2C72154")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x2C720DC", Offset = "0x2C720DC", VA = "0x2C720DC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412120C")]
		public Transform root;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pelvis;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftThigh;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftCalf;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A3")]
		public Transform leftFoot;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rightThigh;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412121C")]
		public Transform rightCalf;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightFoot;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftForearm;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12AB")]
		public Transform leftHand;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412122C")]
		public Transform rightForearm;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHand;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform head;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] spine;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12B3")]
		public Transform[] eyes;

		[Token(Token = "0x1700001E")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2C691A4", Offset = "0x2C691A4", VA = "0x2C691A4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public bool isEmpty
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2C69E14", Offset = "0x2C69E14", VA = "0x2C69E14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2C69E68", Offset = "0x2C69E68", VA = "0x2C69E68", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2C6ABA0", Offset = "0x2C6ABA0", VA = "0x2C6ABA0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2C6B9F0", Offset = "0x2C6B9F0", VA = "0x2C6B9F0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2C6CB3C", Offset = "0x2C6CB3C", VA = "0x2C6CB3C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2C6C09C", Offset = "0x2C6C09C", VA = "0x2C6C09C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2C6E144", Offset = "0x2C6E144", VA = "0x2C6E144")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2C6E600", Offset = "0x2C6E600", VA = "0x2C6E600")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2C6F88C", Offset = "0x2C6F88C", VA = "0x2C6F88C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2C6F3A4", Offset = "0x2C6F3A4", VA = "0x2C6F3A4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2C6EE94", Offset = "0x2C6EE94", VA = "0x2C6EE94")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2C6EA84", Offset = "0x2C6EA84", VA = "0x2C6EA84")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2C6F67C", Offset = "0x2C6F67C", VA = "0x2C6F67C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2C6FAF4", Offset = "0x2C6FAF4", VA = "0x2C6FAF4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2C711D8", Offset = "0x2C711D8", VA = "0x2C711D8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2C704C4", Offset = "0x2C704C4", VA = "0x2C704C4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2C71650", Offset = "0x2C71650", VA = "0x2C71650")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2C70D68", Offset = "0x2C70D68", VA = "0x2C70D68")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2C71678", Offset = "0x2C71678", VA = "0x2C71678")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2C716A0", Offset = "0x2C716A0", VA = "0x2C716A0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C71A74", Offset = "0x2C71A74", VA = "0x2C71A74")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C71E9C", Offset = "0x2C71E9C", VA = "0x2C71E9C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C6BFD4", Offset = "0x2C6BFD4", VA = "0x2C6BFD4")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0xCC16CC", Offset = "0xCC16CC")]
		public string text;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C7430C", Offset = "0x2C7430C", VA = "0x2C7430C")]
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
		[Address(RVA = "0x2C7433C", Offset = "0x2C7433C", VA = "0x2C7433C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2C7447C", Offset = "0x2C7447C", VA = "0x2C7447C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Hierarchy
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x3233498", Offset = "0x3233498", VA = "0x3233498")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x32339E8", Offset = "0x32339E8", VA = "0x32339E8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x3233604", Offset = "0x3233604", VA = "0x3233604")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x3233CA0", Offset = "0x3233CA0", VA = "0x3233CA0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x3233F78", Offset = "0x3233F78", VA = "0x3233F78")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x3234498", Offset = "0x3234498", VA = "0x3234498")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x3234750", Offset = "0x3234750", VA = "0x3234750")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x3234B64", Offset = "0x3234B64", VA = "0x3234B64")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x32354F4", Offset = "0x32354F4", VA = "0x32354F4")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x3234F98", Offset = "0x3234F98", VA = "0x3234F98")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x3235970", Offset = "0x3235970", VA = "0x3235970")]
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
		[Address(RVA = "0x3211794", Offset = "0x3211794", VA = "0x3211794")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3237D0C", Offset = "0x3237D0C", VA = "0x3237D0C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x3237EF8", Offset = "0x3237EF8", VA = "0x3237EF8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x32359A0", Offset = "0x32359A0", VA = "0x32359A0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x3235A10", Offset = "0x3235A10", VA = "0x3235A10")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3235B30", Offset = "0x3235B30", VA = "0x3235B30")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x3235CAC", Offset = "0x3235CAC", VA = "0x3235CAC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x3235D8C", Offset = "0x3235D8C", VA = "0x3235D8C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x3235E48", Offset = "0x3235E48", VA = "0x3235E48")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x3235EF0", Offset = "0x3235EF0", VA = "0x3235EF0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x3235F88", Offset = "0x3235F88", VA = "0x3235F88")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3236168", Offset = "0x3236168", VA = "0x3236168")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x3236304", Offset = "0x3236304", VA = "0x3236304")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x3236448", Offset = "0x3236448", VA = "0x3236448")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x32381C8", Offset = "0x32381C8", VA = "0x32381C8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x32365A4", Offset = "0x32365A4", VA = "0x32365A4")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x32366C4", Offset = "0x32366C4", VA = "0x32366C4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x3236824", Offset = "0x3236824", VA = "0x3236824")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x3236980", Offset = "0x3236980", VA = "0x3236980")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3236B28", Offset = "0x3236B28", VA = "0x3236B28")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x3236D1C", Offset = "0x3236D1C", VA = "0x3236D1C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x3236F10", Offset = "0x3236F10", VA = "0x3236F10")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x32370C8", Offset = "0x32370C8", VA = "0x32370C8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x3237280", Offset = "0x3237280", VA = "0x3237280")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x32373F8", Offset = "0x32373F8", VA = "0x32373F8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x3237554", Offset = "0x3237554", VA = "0x3237554")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x3238324", Offset = "0x3238324", VA = "0x3238324")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x32376F4", Offset = "0x32376F4", VA = "0x32376F4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x3237ABC", Offset = "0x3237ABC", VA = "0x3237ABC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x3237BD4", Offset = "0x3237BD4", VA = "0x3237BD4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x32386F8", Offset = "0x32386F8", VA = "0x32386F8")]
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
		[Address(RVA = "0x3238728", Offset = "0x3238728", VA = "0x3238728")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x32387E0", Offset = "0x32387E0", VA = "0x32387E0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x32388A0", Offset = "0x32388A0", VA = "0x32388A0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x32389E0", Offset = "0x32389E0", VA = "0x32389E0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3238C7C", Offset = "0x3238C7C", VA = "0x3238C7C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3238A38", Offset = "0x3238A38", VA = "0x3238A38")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3238CD4", Offset = "0x3238CD4", VA = "0x3238CD4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x3238F00", Offset = "0x3238F00", VA = "0x3238F00")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x3238FB4", Offset = "0x3238FB4", VA = "0x3238FB4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x32390CC", Offset = "0x32390CC", VA = "0x32390CC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3239240", Offset = "0x3239240", VA = "0x3239240")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x32394B8", Offset = "0x32394B8", VA = "0x32394B8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x32396D4", Offset = "0x32396D4", VA = "0x32396D4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x32397B0", Offset = "0x32397B0", VA = "0x32397B0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class QuaTools
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x3239858", Offset = "0x3239858", VA = "0x3239858")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x3239A50", Offset = "0x3239A50", VA = "0x3239A50")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x321E54C", Offset = "0x321E54C", VA = "0x321E54C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3207DA4", Offset = "0x3207DA4", VA = "0x3207DA4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x32274EC", Offset = "0x32274EC", VA = "0x32274EC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x3239C48", Offset = "0x3239C48", VA = "0x3239C48")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x323A2DC", Offset = "0x323A2DC", VA = "0x323A2DC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x323A7A8", Offset = "0x323A7A8", VA = "0x323A7A8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x12E3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1708", Offset = "0xCC1708")]
		public float timeStep;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC176C", Offset = "0xCC176C")]
		public bool fixTransforms;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412129C")]
		private float lastTime;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animation legacy;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12EB")]
		private bool componentInitiated;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x323ADAC", Offset = "0x323ADAC", VA = "0x323ADAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		private bool isAnimated
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x323B53C", Offset = "0x323B53C", VA = "0x323B53C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x323AB18", Offset = "0x323AB18", VA = "0x323AB18")]
		public void Disable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x323AC40", Offset = "0x323AC40", VA = "0x323AC40", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x323AC54", Offset = "0x323AC54", VA = "0x323AC54", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x323AC68", Offset = "0x323AC68", VA = "0x323AC68", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x323AC7C", Offset = "0x323AC7C", VA = "0x323AC7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x323AD7C", Offset = "0x323AD7C", VA = "0x323AD7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x323ACD8", Offset = "0x323ACD8", VA = "0x323ACD8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x323B49C", Offset = "0x323B49C", VA = "0x323B49C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x323B028", Offset = "0x323B028", VA = "0x323B028")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x323B71C", Offset = "0x323B71C", VA = "0x323B71C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x323B7D4", Offset = "0x323B7D4", VA = "0x323B7D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x323B944", Offset = "0x323B944", VA = "0x323B944")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x323BA5C", Offset = "0x323BA5C", VA = "0x323BA5C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41212AC")]
		public GameObject target;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x323BAA0", Offset = "0x323BAA0", VA = "0x323BAA0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x323BC08", Offset = "0x323BC08", VA = "0x323BC08")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x323BD70", Offset = "0x323BD70", VA = "0x323BD70")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x323BED8", Offset = "0x323BED8", VA = "0x323BED8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class V3Tools
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x323BF08", Offset = "0x323BF08", VA = "0x323BF08")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x323C0FC", Offset = "0x323C0FC", VA = "0x323C0FC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x323C32C", Offset = "0x323C32C", VA = "0x323C32C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x323C8E8", Offset = "0x323C8E8", VA = "0x323C8E8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x323CEBC", Offset = "0x323CEBC", VA = "0x323CEBC")]
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
		[Address(RVA = "0x323D2A8", Offset = "0x323D2A8", VA = "0x323D2A8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x320F9B4", Offset = "0x320F9B4", VA = "0x320F9B4")]
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
		[Address(RVA = "0x2C744E4", Offset = "0x2C744E4", VA = "0x2C744E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C74614", Offset = "0x2C74614", VA = "0x2C74614")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12F3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC17D0", Offset = "0xCC17D0")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1834", Offset = "0xCC1834")]
		public AimIK aim;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41212BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1898", Offset = "0xCC1898")]
		public LookAtIK lookAt;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC18FC", Offset = "0xCC18FC")]
		public Animator animator;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1960", Offset = "0xCC1960")]
		public float crossfadeTime;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC19C4", Offset = "0xCC19C4")]
		public float minAimDistance;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12FB")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x26918B4", Offset = "0x26918B4", VA = "0x26918B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2691934", Offset = "0x2691934", VA = "0x2691934")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2691C28", Offset = "0x2691C28", VA = "0x2691C28")]
		private void Pose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x26920F0", Offset = "0x26920F0", VA = "0x26920F0")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2692870", Offset = "0x2692870", VA = "0x2692870")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2692A44", Offset = "0x2692A44", VA = "0x2692A44")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41212CC")]
		public AimIK aimIK;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1303")]
		public float max;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float lerpSpeed;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41212DC")]
		private RaycastHit hit;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 offset;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x269496C", Offset = "0x269496C", VA = "0x269496C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2694EE4", Offset = "0x2694EE4", VA = "0x2694EE4")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x26953E4", Offset = "0x26953E4", VA = "0x26953E4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x130B")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41212EC")]
		public float lookAtWeight;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1313")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41212FC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float footPositionWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131B")]
		public float footRotationWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412130C")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float handPositionWeight;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float handRotationWeight;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x266EB7C", Offset = "0x266EB7C", VA = "0x266EB7C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x266FA98", Offset = "0x266FA98", VA = "0x266FA98")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1323")]
		public float scale;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform body;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412131C")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float legRotationWeight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132B")]
		public float breatheSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float breatheMagnitude;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412132C")]
		public float height;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minHeight;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastHeight;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastDistance;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1333")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412133C")]
		private float sine;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit rootHit;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2685334", Offset = "0x2685334", VA = "0x2685334")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x26869F4", Offset = "0x26869F4", VA = "0x26869F4")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2686358", Offset = "0x2686358", VA = "0x2686358")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2686D40", Offset = "0x2686D40", VA = "0x2686D40")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x133B")]
		public float speed;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float turnSpeed;

		[Token(Token = "0x17000023")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2686E40", Offset = "0x2686E40", VA = "0x2686E40")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2686F40", Offset = "0x2686F40", VA = "0x2686F40")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x268742C", Offset = "0x268742C", VA = "0x268742C")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0E0C", Offset = "0xCC0E0C")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1353")]
			private int <>1__state;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private object <>2__current;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x412137C")]
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
				[Address(RVA = "0x26893E8", Offset = "0x26893E8", VA = "0x26893E8", Slot = "4")]
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
				[Address(RVA = "0x26894B8", Offset = "0x26894B8", VA = "0x26894B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x26888E0", Offset = "0x26888E0", VA = "0x26888E0")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x26889F4", Offset = "0x26889F4", VA = "0x26889F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x2688A08", Offset = "0x2688A08", VA = "0x2688A08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x2689418", Offset = "0x2689418", VA = "0x2689418", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412134C")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minDelay;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1343")]
		public float maxOffset;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float stepSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412135C")]
		public float footHeight;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float velocityPrediction;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float raycastFocus;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134B")]
		public ParticleSystem sand;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private IK ik;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412136C")]
		private float stepProgress;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
			[Address(RVA = "0x2687488", Offset = "0x2687488", VA = "0x2687488")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 position
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x2686CD0", Offset = "0x2686CD0", VA = "0x2686CD0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2687508", Offset = "0x2687508", VA = "0x2687508")]
			set
			{
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2687598", Offset = "0x2687598", VA = "0x2687598")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x268791C", Offset = "0x268791C", VA = "0x268791C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2688258", Offset = "0x2688258", VA = "0x2688258")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x26887A8", Offset = "0x26887A8", VA = "0x26887A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCD18C", Offset = "0xCCD18C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2688928", Offset = "0x2688928", VA = "0x2688928")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x135B")]
		private ParticleSystem particles;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x26894E8", Offset = "0x26894E8", VA = "0x26894E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x268965C", Offset = "0x268965C", VA = "0x268965C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2689810", Offset = "0x2689810", VA = "0x2689810")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9EB8", Offset = "0xCC9EB8")]
			public int animationLayer;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1353")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9F1C", Offset = "0xCC9F1C")]
			public string animationState;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9F80", Offset = "0xCC9F80")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x412138C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9FE4", Offset = "0xCC9FE4")]
			public Transform warpFrom;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA048", Offset = "0xCCA048")]
			public Transform warpTo;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA0AC", Offset = "0xCCA0AC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1A28", Offset = "0xCC1A28")]
		public Animator animator;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412138C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1A8C", Offset = "0xCC1A8C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCC1AF0", Offset = "0xCC1AF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1AF0", Offset = "0xCC1AF0")]
		public Warp[] warps;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private EffectorMode lastMode;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C74644", Offset = "0x2C74644", VA = "0x2C74644", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2C7468C", Offset = "0x2C7468C", VA = "0x2C7468C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2C74BD0", Offset = "0x2C74BD0", VA = "0x2C74BD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C755E8", Offset = "0x2C755E8", VA = "0x2C755E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2C757C4", Offset = "0x2C757C4", VA = "0x2C757C4")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF05C", Offset = "0xCBF05C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41213AC")]
		public float rotateSpeed;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float blendSpeed;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxAngle;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float moveSpeed;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1373")]
		public float rootMotionWeight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected Animator animator;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41213BC")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveInput;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 velocity;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2C757F4", Offset = "0x2C757F4", VA = "0x2C757F4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2C75880", Offset = "0x2C75880", VA = "0x2C75880")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C75CD0", Offset = "0x2C75CD0", VA = "0x2C75CD0", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C76394", Offset = "0x2C76394", VA = "0x2C76394")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF10C", Offset = "0xCBF10C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF10C", Offset = "0xCBF10C")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool useIK;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x137B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC1BBC", Offset = "0xCC1BBC")]
		public float headLookWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41213CC")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AimIK aim;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1383")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41213DC")]
		private Vector3 aimTarget;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C76420", Offset = "0x2C76420", VA = "0x2C76420")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2C764C4", Offset = "0x2C764C4", VA = "0x2C764C4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2C766D0", Offset = "0x2C766D0", VA = "0x2C766D0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2C768F0", Offset = "0x2C768F0", VA = "0x2C768F0")]
		private void Read()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2C76BE0", Offset = "0x2C76BE0", VA = "0x2C76BE0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2C76C94", Offset = "0x2C76C94", VA = "0x2C76C94")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2C77530", Offset = "0x2C77530", VA = "0x2C77530")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2C779A4", Offset = "0x2C779A4", VA = "0x2C779A4")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF208", Offset = "0xCBF208")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x26718E8", Offset = "0x26718E8", VA = "0x26718E8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2671988", Offset = "0x2671988", VA = "0x2671988", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2671E64", Offset = "0x2671E64", VA = "0x2671E64")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2672218", Offset = "0x2672218", VA = "0x2672218")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF2B8", Offset = "0xCBF2B8")]
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
			[Address(RVA = "0x2673E48", Offset = "0x2673E48", VA = "0x2673E48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x2673F44", Offset = "0x2673F44", VA = "0x2673F44")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2673880", Offset = "0x2673880", VA = "0x2673880")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2673944", Offset = "0x2673944", VA = "0x2673944")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2674040", Offset = "0x2674040", VA = "0x2674040")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC1C40", Offset = "0xCC1C40")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41213EC")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1393")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41213FC")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2679B48", Offset = "0x2679B48", VA = "0x2679B48", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x267ABEC", Offset = "0x267ABEC", VA = "0x267ABEC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x139B")]
		public float upForce;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412140C")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve scale;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A3")]
		private Vector3 defaultScale;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Rigidbody r;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412141C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x267AC1C", Offset = "0x267AC1C", VA = "0x267AC1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x267AD34", Offset = "0x267AD34", VA = "0x267AD34")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x267B7A4", Offset = "0x267B7A4", VA = "0x267B7A4")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x267B934", Offset = "0x267B934", VA = "0x267B934")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x13B3")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float mappingWeight;

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x267BDE4", Offset = "0x267BDE4", VA = "0x267BDE4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x267C0A4", Offset = "0x267C0A4", VA = "0x267C0A4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb leftArm;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13AB")]
		public Limb rightArm;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Limb leftLeg;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412142C")]
		public Limb rightLeg;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rootPin;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x267BA40", Offset = "0x267BA40", VA = "0x267BA40")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x267BEF8", Offset = "0x267BEF8", VA = "0x267BEF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x267C030", Offset = "0x267C030", VA = "0x267C030")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x267C060", Offset = "0x267C060", VA = "0x267C060")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x412143C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x267C0E8", Offset = "0x267C0E8", VA = "0x267C0E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x267C1E0", Offset = "0x267C1E0", VA = "0x267C1E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x267C3D0", Offset = "0x267C3D0", VA = "0x267C3D0")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1C88", Offset = "0xCC1C88")]
		public Transform target;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13BB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1CEC", Offset = "0xCC1CEC")]
		public Transform pin;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1D50", Offset = "0xCC1D50")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121460")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1DB4", Offset = "0xCC1DB4")]
		public AimIK aim;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1E18", Offset = "0xCC1E18")]
		public float weight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1E7C", Offset = "0xCC1E7C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC1EE0", Offset = "0xCC1EE0")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C3")]
		private Animator animator;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x267C400", Offset = "0x267C400", VA = "0x267C400")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x267C48C", Offset = "0x267C48C", VA = "0x267C48C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x267C908", Offset = "0x267C908", VA = "0x267C908")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121470")]
		public bool leftHanded;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x267C938", Offset = "0x267C938", VA = "0x267C938")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x267CA68", Offset = "0x267CA68", VA = "0x267CA68")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x267CBBC", Offset = "0x267CBBC", VA = "0x267CBBC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x267D8D0", Offset = "0x267D8D0", VA = "0x267D8D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x267DAB0", Offset = "0x267DAB0", VA = "0x267DAB0")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC1F44", Offset = "0xCC1F44")]
		public float aimWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC1F8C", Offset = "0xCC1F8C")]
		public float sightWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC1FD4", Offset = "0xCC1FD4")]
		public float maxAngle;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13CB")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121480")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D3")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121490")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recoil recoil;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13DB")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2184", Offset = "0xCC2184")]
		public float cameraRecoilWeight;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x267DAE0", Offset = "0x267DAE0", VA = "0x267DAE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x267DE30", Offset = "0x267DE30", VA = "0x267DE30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x267DE60", Offset = "0x267DE60", VA = "0x267DE60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x267E61C", Offset = "0x267E61C", VA = "0x267E61C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x267E974", Offset = "0x267E974", VA = "0x267E974")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x267E048", Offset = "0x267E048", VA = "0x267E048")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2680218", Offset = "0x2680218", VA = "0x2680218")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF368", Offset = "0xCBF368")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF368", Offset = "0xCBF368")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC21CC", Offset = "0xCC21CC")]
		public float walkSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41214A0")]
		private float sVel;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x268029C", Offset = "0x268029C", VA = "0x268029C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2680354", Offset = "0x2680354", VA = "0x2680354")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x26806D4", Offset = "0x26806D4", VA = "0x26806D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x26808C8", Offset = "0x26808C8", VA = "0x26808C8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x13E3")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private string colliderName;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2681A94", Offset = "0x2681A94", VA = "0x2681A94")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2681D84", Offset = "0x2681D84", VA = "0x2681D84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2681ECC", Offset = "0x2681ECC", VA = "0x2681ECC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41214B0")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHandTarget;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13EB")]
		public float crossFade;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float speed;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41214C0")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2681F10", Offset = "0x2681F10", VA = "0x2681F10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2682248", Offset = "0x2682248", VA = "0x2682248")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2682A24", Offset = "0x2682A24", VA = "0x2682A24")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x13F3")]
		public InteractionObject handShake;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2682A68", Offset = "0x2682A68", VA = "0x2682A68")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2682BB0", Offset = "0x2682BB0", VA = "0x2682BB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2682E3C", Offset = "0x2682E3C", VA = "0x2682E3C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41214D0")]
		public bool interrupt;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject ball;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject benchMain;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject benchHands;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13FB")]
		public InteractionObject button;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionObject cigarette;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41214E0")]
		public InteractionObject door;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isSitting;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2682E6C", Offset = "0x2682E6C", VA = "0x2682E6C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2683764", Offset = "0x2683764", VA = "0x2683764")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF464", Offset = "0xCBF464")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC228C", Offset = "0xCC228C")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC230C", Offset = "0xCC230C")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1403")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2683794", Offset = "0x2683794", VA = "0x2683794")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2683820", Offset = "0x2683820", VA = "0x2683820")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2683CE0", Offset = "0x2683CE0", VA = "0x2683CE0")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x140B")]
			public Transform mouth;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform mouthTarget;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121500")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float bodyWeightVertical;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1413")]
			public float neckRotationWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float headTiltAngle;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121510")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000B3")]
			private Transform neck
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x26851A0", Offset = "0x26851A0", VA = "0x26851A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x2683D78", Offset = "0x2683D78", VA = "0x2683D78")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x2683EB4", Offset = "0x2683EB4", VA = "0x2683EB4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x2684E20", Offset = "0x2684E20", VA = "0x2684E20")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x26852A0", Offset = "0x26852A0", VA = "0x26852A0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Partner partner1;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41214F0")]
		public Partner partner2;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int iterations;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2683D10", Offset = "0x2683D10", VA = "0x2683D10")]
		private void Start()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2683DD0", Offset = "0x2683DD0", VA = "0x2683DD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2684DDC", Offset = "0x2684DDC", VA = "0x2684DDC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA110", Offset = "0xCCA110")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA174", Offset = "0xCCA174")]
			public float weight;

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x268A92C", Offset = "0x268A92C", VA = "0x268A92C")]
			public void SetToBone(IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x268AAD4", Offset = "0x268AAD4", VA = "0x268AAD4")]
			public void SetEffectorWeights(IKSolverFullBodyBiped solver, float w)
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x268ACD4", Offset = "0x268ACD4", VA = "0x268ACD4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0E48", Offset = "0xCC0E48")]
		private sealed class <AbsorbMotion>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1423")]
			private int <>1__state;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private object <>2__current;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121530")]
			public MotionAbsorb <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x268ABD4", Offset = "0x268ABD4", VA = "0x268ABD4", Slot = "4")]
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
				[Address(RVA = "0x268ACA4", Offset = "0x268ACA4", VA = "0x268ACA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x268A264", Offset = "0x268A264", VA = "0x268A264")]
			[DebuggerHidden]
			public <AbsorbMotion>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x268A300", Offset = "0x268A300", VA = "0x268A300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x268A314", Offset = "0x268A314", VA = "0x268A314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x268AC04", Offset = "0x268AC04", VA = "0x268AC04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC238C", Offset = "0xCC238C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC23F0", Offset = "0xCC23F0")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2454", Offset = "0xCC2454")]
		public float weight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC24B8", Offset = "0xCC24B8")]
		public AnimationCurve falloff;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121520")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC251C", Offset = "0xCC251C")]
		public float falloffSpeed;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x268A12C", Offset = "0x268A12C", VA = "0x268A12C")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x268A1A8", Offset = "0x268A1A8", VA = "0x268A1A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCD23C", Offset = "0xCCD23C")]
		private IEnumerator AbsorbMotion()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x268A2AC", Offset = "0x268A2AC", VA = "0x268A2AC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform cube;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142B")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121540")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x268AD18", Offset = "0x268AD18", VA = "0x268AD18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x268ADF4", Offset = "0x268ADF4", VA = "0x268ADF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x268AF34", Offset = "0x268AF34", VA = "0x268AF34")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x268B210", Offset = "0x268B210", VA = "0x268B210")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1433")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float weightMultiplier;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121550")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x268BA44", Offset = "0x268BA44", VA = "0x268BA44")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x268B258", Offset = "0x268B258", VA = "0x268B258", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x268B4EC", Offset = "0x268B4EC", VA = "0x268B4EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x268BA14", Offset = "0x268BA14", VA = "0x268BA14")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF514", Offset = "0xCBF514")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2580", Offset = "0xCC2580")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2580", Offset = "0xCC2580")]
		public float weight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC261C", Offset = "0xCC261C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2680", Offset = "0xCC2680")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2700", Offset = "0xCC2700")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121560")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1443")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121570")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144B")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float lastWeight;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x268BA88", Offset = "0x268BA88", VA = "0x268BA88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x268C1F8", Offset = "0x268C1F8", VA = "0x268C1F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x268D2A0", Offset = "0x268D2A0", VA = "0x268D2A0")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121580")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject obj;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pivot;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1453")]
		public Transform holdPoint;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float pickUpTime;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121590")]
		private float holdWeight;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
			[Address(RVA = "0x268DDAC", Offset = "0x268DDAC", VA = "0x268DDAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x268DB18", Offset = "0x268DB18", VA = "0x268DB18")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600021B")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x268DE1C", Offset = "0x268DE1C", VA = "0x268DE1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x268E090", Offset = "0x268E090", VA = "0x268E090")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x268E3E4", Offset = "0x268E3E4", VA = "0x268E3E4")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x268E580", Offset = "0x268E580", VA = "0x268E580")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x268E828", Offset = "0x268E828", VA = "0x268E828")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x268EBDC", Offset = "0x268EBDC", VA = "0x268EBDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x268EF04", Offset = "0x268EF04", VA = "0x268EF04")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x268EF4C", Offset = "0x268EF4C", VA = "0x268EF4C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x268F3B4", Offset = "0x268F3B4", VA = "0x268F3B4")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x268F3E4", Offset = "0x268F3E4", VA = "0x268F3E4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x268F794", Offset = "0x268F794", VA = "0x268F794")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145B")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform root;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41215A0")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2690924", Offset = "0x2690924", VA = "0x2690924")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x26909C8", Offset = "0x26909C8", VA = "0x26909C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2690D6C", Offset = "0x2690D6C", VA = "0x2690D6C")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF5C4", Offset = "0xCBF5C4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float magnitude;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Recoil recoil;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2690D9C", Offset = "0x2690D9C", VA = "0x2690D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2690E28", Offset = "0x2690E28", VA = "0x2690E28")]
		private void Update()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2690ED0", Offset = "0x2690ED0", VA = "0x2690ED0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2690F74", Offset = "0x2690F74", VA = "0x2690F74")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0E84", Offset = "0xCC0E84")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x146B")]
			public float resetTime;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x26917B4", Offset = "0x26917B4", VA = "0x26917B4", Slot = "4")]
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
				[Address(RVA = "0x2691884", Offset = "0x2691884", VA = "0x2691884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x2691274", Offset = "0x2691274", VA = "0x2691274")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x2691300", Offset = "0x2691300", VA = "0x2691300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x2691314", Offset = "0x2691314", VA = "0x2691314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x26917E4", Offset = "0x26917E4", VA = "0x26917E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float resetDelay;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1463")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41215B0")]
		private Transform defaultParent;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody r;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2690FB8", Offset = "0x2690FB8", VA = "0x2690FB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x269110C", Offset = "0x269110C", VA = "0x269110C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2691190", Offset = "0x2691190", VA = "0x2691190")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCD2EC", Offset = "0xCCD2EC")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x26912BC", Offset = "0x26912BC", VA = "0x26912BC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF674", Offset = "0xCBF674")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0EC0", Offset = "0xCC0EC0")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1473")]
			private object <>2__current;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x269486C", Offset = "0x269486C", VA = "0x269486C", Slot = "4")]
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
				[Address(RVA = "0x269493C", Offset = "0x269493C", VA = "0x269493C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x269450C", Offset = "0x269450C", VA = "0x269450C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x2694584", Offset = "0x2694584", VA = "0x2694584", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x2694598", Offset = "0x2694598", VA = "0x2694598", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x269489C", Offset = "0x269489C", VA = "0x269489C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41215C0")]
		private Animator animator;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x269430C", Offset = "0x269430C", VA = "0x269430C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2694450", Offset = "0x2694450", VA = "0x2694450")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCD39C", Offset = "0xCCD39C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2694554", Offset = "0x2694554", VA = "0x2694554")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x147B")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41215E0")]
			public float spherecastRadius;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float minDistance;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float lerpSpeed;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1483")]
			public float minSwitchTime;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float releaseDistance;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41215F0")]
			public bool sliding;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float raycastDistance;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool inTouch;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148B")]
			private RaycastHit hit;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121600")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool initiated;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float nextSwitchTime;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float speedF;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x2695594", Offset = "0x2695594", VA = "0x2695594")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x26971EC", Offset = "0x26971EC", VA = "0x26971EC")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x2695C28", Offset = "0x2695C28", VA = "0x2695C28")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x26973D4", Offset = "0x26973D4", VA = "0x26973D4")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x2697710", Offset = "0x2697710", VA = "0x2697710")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x2697870", Offset = "0x2697870", VA = "0x2697870")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x26979D0", Offset = "0x26979D0", VA = "0x26979D0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x2696F28", Offset = "0x2696F28", VA = "0x2696F28")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x2697B30", Offset = "0x2697B30", VA = "0x2697B30")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41215D0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x269548C", Offset = "0x269548C", VA = "0x269548C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2695B34", Offset = "0x2695B34", VA = "0x2695B34")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2696D44", Offset = "0x2696D44", VA = "0x2696D44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x26971BC", Offset = "0x26971BC", VA = "0x26971BC")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1493")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC29D8", Offset = "0xCC29D8")]
		public Transform to;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2A3C", Offset = "0xCC2A3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2A3C", Offset = "0xCC2A3C")]
		public float transferMotion;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121610")]
		private Vector3 lastPosition;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2697BFC", Offset = "0x2697BFC", VA = "0x2697BFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2697C74", Offset = "0x2697C74", VA = "0x2697C74")]
		private void Update()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2697F28", Offset = "0x2697F28", VA = "0x2697F28")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149B")]
		public float enableInputAtProgress;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2698870", Offset = "0x2698870", VA = "0x2698870", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x269935C", Offset = "0x269935C", VA = "0x269935C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2699674", Offset = "0x2699674", VA = "0x2699674")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public GameObject[] characters;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2681764", Offset = "0x2681764", VA = "0x2681764")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2681938", Offset = "0x2681938", VA = "0x2681938")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2681A64", Offset = "0x2681A64", VA = "0x2681A64")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0EFC", Offset = "0xCC0EFC")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121640")]
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
				[Address(RVA = "0x2690824", Offset = "0x2690824", VA = "0x2690824", Slot = "4")]
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
				[Address(RVA = "0x26908F4", Offset = "0x26908F4", VA = "0x26908F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x268FF70", Offset = "0x268FF70", VA = "0x268FF70")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x2690480", Offset = "0x2690480", VA = "0x2690480", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x2690494", Offset = "0x2690494", VA = "0x2690494", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x2690854", Offset = "0x2690854", VA = "0x2690854", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121620")]
		public float maxAngle;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float switchRotationTime;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float random;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotationSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A3")]
		public Vector3 movePosition;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float moveSpeed;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121630")]
		public int characterLayer;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14AB")]
		private Vector3 velocity;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Rigidbody r;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x268F7C4", Offset = "0x268F7C4", VA = "0x268F7C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x268FA78", Offset = "0x268FA78", VA = "0x268FA78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x268F9BC", Offset = "0x268F9BC", VA = "0x268F9BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCD44C", Offset = "0xCCD44C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x268FFB8", Offset = "0x268FFB8", VA = "0x268FFB8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x26901E8", Offset = "0x26901E8", VA = "0x26901E8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x26903E8", Offset = "0x26903E8", VA = "0x26903E8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B3")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2B8C", Offset = "0xCC2B8C")]
		public float weight;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x266E8CC", Offset = "0x266E8CC", VA = "0x266E8CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x266E9C4", Offset = "0x266E9C4", VA = "0x266E9C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x266EB38", Offset = "0x266EB38", VA = "0x266EB38")]
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
			[Address(RVA = "0x2698078", Offset = "0x2698078", VA = "0x2698078")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x26982B8", Offset = "0x26982B8", VA = "0x26982B8")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform target;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121650")]
		public Part[] parts;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2697F70", Offset = "0x2697F70", VA = "0x2697F70")]
		private void Update()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2698288", Offset = "0x2698288", VA = "0x2698288")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF724", Offset = "0xCBF724")]
	public class FixFeet : MonoBehaviour
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2BD4", Offset = "0xCC2BD4")]
		public float weight;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14BB")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 relativePosL;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121660")]
		private Vector3 relativePosR;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion relativeRotL;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion relativeRotR;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x268090C", Offset = "0x268090C", VA = "0x268090C")]
		private void Start()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x26809AC", Offset = "0x26809AC", VA = "0x26809AC")]
		public void Sample()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2680EA0", Offset = "0x2680EA0", VA = "0x2680EA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2681720", Offset = "0x2681720", VA = "0x2681720")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C3")]
		private Transform[] children;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121670")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2689840", Offset = "0x2689840", VA = "0x2689840")]
		private void Start()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2689B48", Offset = "0x2689B48", VA = "0x2689B48")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2689E84", Offset = "0x2689E84", VA = "0x2689E84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x268A064", Offset = "0x268A064", VA = "0x268A064")]
		public Mirror()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Phone : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0F38", Offset = "0xCC0F38")]
		private sealed class <EnableDisplay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int <>1__state;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121680")]
			private object <>2__current;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Phone <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x268DA18", Offset = "0x268DA18", VA = "0x268DA18", Slot = "4")]
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
				[Address(RVA = "0x268DAE8", Offset = "0x268DAE8", VA = "0x268DAE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x268D5F0", Offset = "0x268D5F0", VA = "0x268D5F0")]
			[DebuggerHidden]
			public <EnableDisplay>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x268D81C", Offset = "0x268D81C", VA = "0x268D81C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x268D830", Offset = "0x268D830", VA = "0x268D830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x268DA48", Offset = "0x268DA48", VA = "0x268DA48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2C1C", Offset = "0xCC2C1C")]
		public Collider pickUpCollider;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2C80", Offset = "0xCC2C80")]
		public InteractionObject pickUpObject;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2CE4", Offset = "0xCC2CE4")]
		public GameObject display;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14CB")]
		private Transform parent;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x268D3A0", Offset = "0x268D3A0", VA = "0x268D3A0")]
		private void OnPickUp()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x268D534", Offset = "0x268D534", VA = "0x268D534")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCD4FC", Offset = "0xCCD4FC")]
		private IEnumerator EnableDisplay()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x268D638", Offset = "0x268D638", VA = "0x268D638")]
		private void OnButton1()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x268D64C", Offset = "0x268D64C", VA = "0x268D64C")]
		private void OnButton2()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x268D70C", Offset = "0x268D70C", VA = "0x268D70C")]
		private void DropPhone()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x268D7EC", Offset = "0x268D7EC", VA = "0x268D7EC")]
		public Phone()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF7D4", Offset = "0xCBF7D4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x14EB")]
			public Transform bendGoalLeftArm;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Transform bendGoalRightArm;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41216D0")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1503")]
			public Transform transform;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 value;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x269DD70", Offset = "0x269DD70", VA = "0x269DD70")]
			public BoneRotationOffset()
			{
			}
		}

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC2D48", Offset = "0xCC2D48")]
		public VRAnimatorController animatorController;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2DAC", Offset = "0xCC2DAC")]
		public WeaponBase currentWeapon;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D3")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC2E10", Offset = "0xCC2E10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2E10", Offset = "0xCC2E10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2E10", Offset = "0xCC2E10")]
		public float weight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2EF4", Offset = "0xCC2EF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC2EF4", Offset = "0xCC2EF4")]
		public float spineTwistWeight;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121690")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC2F90", Offset = "0xCC2F90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC2F90", Offset = "0xCC2F90")]
		public Handedness handedness;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC303C", Offset = "0xCC303C")]
		public float sideOffset;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC30A0", Offset = "0xCC30A0")]
		public Targets leftHandedTargets;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3104", Offset = "0xCC3104")]
		public Targets rightHandedTargets;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14DB")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3168", Offset = "0xCC3168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3168", Offset = "0xCC3168")]
		public Transform weaponsPivot;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3214", Offset = "0xCC3214")]
		public Transform weaponsAnchor;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41216A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3278", Offset = "0xCC3278")]
		public Transform pivotMotionTarget;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC32DC", Offset = "0xCC32DC")]
		public float lerpSpeed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3340", Offset = "0xCC3340")]
		public float pivotMotionSmoothSpeed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC33A4", Offset = "0xCC33A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC33A4", Offset = "0xCC33A4")]
		public float pivotMotionWeight;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3440", Offset = "0xCC3440")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC3440", Offset = "0xCC3440")]
		public float aimVerticalLimit;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC34DC", Offset = "0xCC34DC")]
		public float aimZ;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41216B0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poserLeftHand;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poserRightHand;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14EB")]
		private Vector3 pivotRelativePosition;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 weaponsPivotLocalPosition;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41216C0")]
		private Vector3 defaultWeaponsAnchorLocalPosition;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimVel;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimRandom;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float x;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F3")]
		private float y;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float aimWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41216D0")]
		private Vector3 cameraPosition;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastCharacterPosition;

		[Token(Token = "0x17000029")]
		private Transform cam
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x269972C", Offset = "0x269972C", VA = "0x269972C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform characterController
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2699770", Offset = "0x2699770", VA = "0x2699770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private Targets targets
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x269C0E8", Offset = "0x269C0E8", VA = "0x269C0E8")]
			get
			{
				return default(Targets);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x26997B4", Offset = "0x26997B4", VA = "0x26997B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x269A164", Offset = "0x269A164", VA = "0x269A164")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x269C144", Offset = "0x269C144", VA = "0x269C144")]
		private void RotateWeapon(float horAdd, float vertAdd)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2699CC0", Offset = "0x2699CC0", VA = "0x2699CC0")]
		private Vector3 TargetsCameraPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2699BB0", Offset = "0x2699BB0", VA = "0x2699BB0")]
		private void SetHandedness(Handedness h)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x269D094", Offset = "0x269D094", VA = "0x269D094")]
		private void TwistSpine()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x269D530", Offset = "0x269D530", VA = "0x269D530")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x269D8E8", Offset = "0x269D8E8", VA = "0x269D8E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x269DAC8", Offset = "0x269DAC8", VA = "0x269DAC8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x269DC84", Offset = "0x269DC84", VA = "0x269DC84")]
		public VRAimingController()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF884", Offset = "0xCBF884")]
	public class VRAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41216F0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3540", Offset = "0xCC3540")]
		public VRSetup oculusSetup;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform characterController;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform cam;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC35A4", Offset = "0xCC35A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC35A4", Offset = "0xCC35A4")]
		public Vector3 cameraOffset;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3650", Offset = "0xCC3650")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC36B4", Offset = "0xCC36B4")]
		public float linearAcceleration;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121700")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3718", Offset = "0xCC3718")]
		public float maxViewAngle;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC377C", Offset = "0xCC377C")]
		public float locomotionSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC37E0", Offset = "0xCC37E0")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1513")]
		private Vector3 velocityC;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool rootCorrection;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121710")]
		private Vector3 playerVelocity;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
			[Address(RVA = "0x269DDA0", Offset = "0x269DDA0", VA = "0x269DDA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD5AC", Offset = "0xCCD5AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x269DDE0", Offset = "0x269DDE0", VA = "0x269DDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD5E8", Offset = "0xCCD5E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x269DE40", Offset = "0x269DE40", VA = "0x269DE40")]
		private void Start()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x269E298", Offset = "0x269E298", VA = "0x269E298")]
		private void Update()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x269EC80", Offset = "0x269EC80", VA = "0x269EC80")]
		private Vector3 GetVelocityTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x269C894", Offset = "0x269C894", VA = "0x269C894")]
		public void RotateCharacter(Vector3 forward, float maxAngle, [Optional] Transform fix)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x269F034", Offset = "0x269F034", VA = "0x269F034")]
		public VRAnimatorController()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF934", Offset = "0xCBF934")]
	public class VRCharacterController : MonoBehaviour
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151B")]
		public float moveSpeed;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float rotationSpeed;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121720")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC381C", Offset = "0xCC381C")]
		public float rotationRatchet;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public KeyCode ratchetRight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public KeyCode ratchetLeft;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform forwardDirection;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1523")]
		private CharacterController characterController;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x269F0C4", Offset = "0x269F0C4", VA = "0x269F0C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x269F224", Offset = "0x269F224", VA = "0x269F224")]
		private void Update()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x269F994", Offset = "0x269F994", VA = "0x269F994")]
		public VRCharacterController()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBF9E4", Offset = "0xCBF9E4")]
	public class VRInteractionController : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3864", Offset = "0xCC3864")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC3864", Offset = "0xCC3864")]
		public float triggerTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC3900", Offset = "0xCC3900")]
		private InteractionSystem <interactionSystem>k__BackingField;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC393C", Offset = "0xCC393C")]
		private InteractionTrigger <currentTrigger>k__BackingField;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x1700002D")]
		public InteractionSystem interactionSystem
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x269FA28", Offset = "0x269FA28", VA = "0x269FA28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD624", Offset = "0xCCD624")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x269FA58", Offset = "0x269FA58", VA = "0x269FA58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD660", Offset = "0xCCD660")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float triggerProgress
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x269FA90", Offset = "0x269FA90", VA = "0x269FA90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public InteractionTrigger currentTrigger
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x269FB18", Offset = "0x269FB18", VA = "0x269FB18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD69C", Offset = "0xCCD69C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x269FB48", Offset = "0x269FB48", VA = "0x269FB48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD6D8", Offset = "0xCCD6D8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x269FB80", Offset = "0x269FB80", VA = "0x269FB80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x269FC18", Offset = "0x269FC18", VA = "0x269FC18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x269FE40", Offset = "0x269FE40", VA = "0x269FE40")]
		private bool CanTrigger(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x269FF20", Offset = "0x269FF20", VA = "0x269FF20")]
		public VRInteractionController()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBFA94", Offset = "0xCBFA94")]
	public class VRInteractionUI : MonoBehaviour
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3978", Offset = "0xCC3978")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3978", Offset = "0xCC3978")]
		public Slider slider;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3A24", Offset = "0xCC3A24")]
		public AnimationCurve alphaToProgress;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3A88", Offset = "0xCC3A88")]
		public Transform cursor;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121740")]
		private VRInteractionController interactionController;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Image[] sliderImages;

		[Token(Token = "0x40002A4")]
		private const string showCursorTag = "ShowCursor";

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x269FF64", Offset = "0x269FF64", VA = "0x269FF64")]
		private void Start()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x26A0030", Offset = "0x26A0030", VA = "0x26A0030")]
		private void Update()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x26A0070", Offset = "0x26A0070", VA = "0x26A0070")]
		private void UpdateInteractionSlider()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x26A0480", Offset = "0x26A0480", VA = "0x26A0480")]
		private void UpdateCursor()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x26A0810", Offset = "0x26A0810", VA = "0x26A0810")]
		private void SetSliderAlpha(float a)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x26A0D2C", Offset = "0x26A0D2C", VA = "0x26A0D2C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1533")]
		public GameObject model;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public GameObject[] enableOnR;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121750")]
		public VRCharacterController characterController;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool disableMovement;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC3AEC", Offset = "0xCC3AEC")]
		private bool <isFinished>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float moveSpeed;

		[Token(Token = "0x17000030")]
		public bool isFinished
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x26A0D5C", Offset = "0x26A0D5C", VA = "0x26A0D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD714", Offset = "0xCCD714")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x26A0DA0", Offset = "0x26A0DA0", VA = "0x26A0DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD750", Offset = "0xCCD750")]
			private set
			{
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x26A0DEC", Offset = "0x26A0DEC", VA = "0x26A0DEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x26A104C", Offset = "0x26A104C", VA = "0x26A104C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x26A162C", Offset = "0x26A162C", VA = "0x26A162C")]
		public VRSetup()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public abstract class WeaponBase : MonoBehaviour
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153B")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3B28", Offset = "0xCC3B28")]
		public Vector3 recoilDirection;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float recoilAngleVertical;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121760")]
		public float recoilAngleHorizontal;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float recoilRandom;

		[Token(Token = "0x6000287")]
		public abstract void Fire();

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x26A165C", Offset = "0x26A165C", VA = "0x26A165C")]
		protected WeaponBase()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class WeaponRifle : WeaponBase
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3B8C", Offset = "0xCC3B8C")]
		public Transform shootFrom;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float range;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1543")]
		public LayerMask hitLayers;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3BF0", Offset = "0xCC3BF0")]
		public ParticleSystem muzzleFlash;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121770")]
		public ParticleSystem muzzleSmoke;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bulletHole;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem bulletHit;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float smokeFadeOutSpeed;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154B")]
		private float smokeEmission;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x26A179C", Offset = "0x26A179C", VA = "0x26A179C", Slot = "4")]
		public override void Fire()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x26A1C84", Offset = "0x26A1C84", VA = "0x26A1C84")]
		private void Update()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x26A1F0C", Offset = "0x26A1F0C", VA = "0x26A1F0C")]
		public WeaponRifle()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool smoothFollow;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121780")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastPosition;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 localPosition;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion localRotation;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1553")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000031")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x266FB94", Offset = "0x266FB94", VA = "0x266FB94", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x266FB34", Offset = "0x266FB34", VA = "0x266FB34", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x266FBB8", Offset = "0x266FBB8", VA = "0x266FBB8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x266FD38", Offset = "0x266FD38", VA = "0x266FD38", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x267019C", Offset = "0x267019C", VA = "0x267019C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2670634", Offset = "0x2670634", VA = "0x2670634")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBFB44", Offset = "0xCBFB44")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121790")]
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
		[Address(RVA = "0x2670690", Offset = "0x2670690", VA = "0x2670690", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2670730", Offset = "0x2670730", VA = "0x2670730", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x267092C", Offset = "0x267092C", VA = "0x267092C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2670C00", Offset = "0x2670C00", VA = "0x2670C00")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBFBF4", Offset = "0xCBFBF4")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x155B")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41217A0")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC3DBC", Offset = "0xCC3DBC")]
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
			[Address(RVA = "0x2670D60", Offset = "0x2670D60", VA = "0x2670D60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2670C30", Offset = "0x2670C30", VA = "0x2670C30", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2670D08", Offset = "0x2670D08", VA = "0x2670D08", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2670F40", Offset = "0x2670F40", VA = "0x2670F40", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x267178C", Offset = "0x267178C", VA = "0x267178C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2671860", Offset = "0x2671860", VA = "0x2671860")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBFCA4", Offset = "0xCBFCA4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBFCA4", Offset = "0xCBFCA4")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41217B0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC3E2C", Offset = "0xCC3E2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3E2C", Offset = "0xCC3E2C")]
		public Transform gravityTarget;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC3ED8", Offset = "0xCC3ED8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x156B")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41217C0")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		protected float originalHeight;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41217D0")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600029C")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2672248", Offset = "0x2672248", VA = "0x2672248")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x26724F8", Offset = "0x26724F8", VA = "0x26724F8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2672778", Offset = "0x2672778", VA = "0x2672778", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2672C50", Offset = "0x2672C50", VA = "0x2672C50")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2672DD0", Offset = "0x2672DD0", VA = "0x2672DD0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x26731AC", Offset = "0x26731AC", VA = "0x26731AC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2673510", Offset = "0x2673510", VA = "0x2673510")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2673568", Offset = "0x2673568", VA = "0x2673568")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x26735C0", Offset = "0x26735C0", VA = "0x26735C0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x26737D4", Offset = "0x26737D4", VA = "0x26737D4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x15B3")]
			public bool crouch;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool onGround;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121860")]
			public bool isStrafing;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float yVelocity;
		}

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC4084", Offset = "0xCC4084")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x157B")]
		public CameraController cam;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC40E8", Offset = "0xCC40E8")]
		public MoveMode moveMode;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41217E0")]
		public bool smoothPhysics;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float platformFriction;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1583")]
		public float groundStickyEffect;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41217F0")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC414C", Offset = "0xCC414C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float turnSpeed;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158B")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC41B0", Offset = "0xCC41B0")]
		public float airSpeed;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float airControl;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121800")]
		public float jumpPower;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC4214", Offset = "0xCC4214")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1593")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121810")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC4294", Offset = "0xCC4294")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC42F8", Offset = "0xCC42F8")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public AnimState animState;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121820")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 normal;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A3")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private RaycastHit hit;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121830")]
		private float jumpLeg;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float jumpEndTime;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float forwardMlp;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float groundDistance;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15AB")]
		private float lastAirTime;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float stickyForce;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121840")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunWeight;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B3")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121850")]
		private bool fixedFrame;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunEndTime;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 gravity;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15BB")]
		private float velocityY;

		[Token(Token = "0x17000033")]
		public bool onGround
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2674070", Offset = "0x2674070", VA = "0x2674070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD78C", Offset = "0xCCD78C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x26740B4", Offset = "0x26740B4", VA = "0x26740B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD7C8", Offset = "0xCCD7C8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2674100", Offset = "0x2674100", VA = "0x2674100", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x26743F0", Offset = "0x26743F0", VA = "0x26743F0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x26744B0", Offset = "0x26744B0", VA = "0x26744B0", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x26746DC", Offset = "0x26746DC", VA = "0x26746DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2676A44", Offset = "0x2676A44", VA = "0x2676A44", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x267731C", Offset = "0x267731C", VA = "0x267731C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x267514C", Offset = "0x267514C", VA = "0x267514C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x267758C", Offset = "0x267758C", VA = "0x267758C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2678464", Offset = "0x2678464", VA = "0x2678464")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2676CA0", Offset = "0x2676CA0", VA = "0x2676CA0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2678658", Offset = "0x2678658", VA = "0x2678658", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2678EFC", Offset = "0x2678EFC", VA = "0x2678EFC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2679538", Offset = "0x2679538", VA = "0x2679538", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2676000", Offset = "0x2676000", VA = "0x2676000")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2679970", Offset = "0x2679970", VA = "0x2679970")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCBFDA0", Offset = "0xCBFDA0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4334", Offset = "0xCC4334")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC43B4", Offset = "0xCC43B4")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15CB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4434", Offset = "0xCC4434")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC44B4", Offset = "0xCC44B4")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121880")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4534", Offset = "0xCC4534")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC45B4", Offset = "0xCC45B4")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC4634", Offset = "0xCC4634")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D3")]
		private float speed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float angleVel;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121890")]
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
			[Address(RVA = "0x2692AA4", Offset = "0x2692AA4", VA = "0x2692AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD804", Offset = "0xCCD804")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2692AE8", Offset = "0x2692AE8", VA = "0x2692AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCD840", Offset = "0xCCD840")]
			private set
			{
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2692B34", Offset = "0x2692B34", VA = "0x2692B34")]
		private void Start()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2692C24", Offset = "0x2692C24", VA = "0x2692C24")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2693C5C", Offset = "0x2693C5C", VA = "0x2693C5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2692CBC", Offset = "0x2692CBC", VA = "0x2692CBC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2693640", Offset = "0x2693640", VA = "0x2693640")]
		private void Move()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2693CC4", Offset = "0x2693CC4", VA = "0x2693CC4")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2693EE4", Offset = "0x2693EE4", VA = "0x2693EE4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2693FE4", Offset = "0x2693FE4", VA = "0x2693FE4")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41218A0")]
		public Transform moveTarget;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stoppingDistance;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stoppingThreshold;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x26982E8", Offset = "0x26982E8", VA = "0x26982E8", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x26987B8", Offset = "0x26987B8", VA = "0x26987B8")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x15DB")]
			public bool crouch;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public bool jump;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41218B0")]
			public int actionIndex;
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool walkByDefault;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E3")]
		public bool canCrouch;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool canJump;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41218B0")]
		public State state;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Transform cam;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x26996D4", Offset = "0x26996D4", VA = "0x26996D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2698B20", Offset = "0x2698B20", VA = "0x2698B20", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2698814", Offset = "0x2698814", VA = "0x2698814")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x266E81C", Offset = "0x266E81C", VA = "0x266E81C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x266E89C", Offset = "0x266E89C", VA = "0x266E89C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F3")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x269406C", Offset = "0x269406C", VA = "0x269406C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x26940F4", Offset = "0x26940F4", VA = "0x26940F4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x26942C4", Offset = "0x26942C4", VA = "0x26942C4")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCBFE50", Offset = "0xCBFE50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCBFE50", Offset = "0xCBFE50")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public BipedReferences references;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41218D0")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x33AC324", Offset = "0x33AC324", VA = "0x33AC324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCD87C", Offset = "0xCCD87C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x33AC3A8", Offset = "0x33AC3A8", VA = "0x33AC3A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCD8E0", Offset = "0xCCD8E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x33AC42C", Offset = "0x33AC42C", VA = "0x33AC42C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCD944", Offset = "0xCCD944")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x33AC4B0", Offset = "0x33AC4B0", VA = "0x33AC4B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCD9A8", Offset = "0xCCD9A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x33AC534", Offset = "0x33AC534", VA = "0x33AC534")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x33AC6F8", Offset = "0x33AC6F8", VA = "0x33AC6F8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x33AC75C", Offset = "0x33AC75C", VA = "0x33AC75C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x33AC7C8", Offset = "0x33AC7C8", VA = "0x33AC7C8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x33AC834", Offset = "0x33AC834", VA = "0x33AC834")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x33AC8C4", Offset = "0x33AC8C4", VA = "0x33AC8C4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x33ACA2C", Offset = "0x33ACA2C", VA = "0x33ACA2C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x33ACA98", Offset = "0x33ACA98", VA = "0x33ACA98")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x33ACB10", Offset = "0x33ACB10", VA = "0x33ACB10")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x33ACBDC", Offset = "0x33ACBDC", VA = "0x33ACBDC")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x33ACC68", Offset = "0x33ACC68", VA = "0x33ACC68")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x33ACCF4", Offset = "0x33ACCF4", VA = "0x33ACCF4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x33AC598", Offset = "0x33AC598", VA = "0x33AC598")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x33ACD60", Offset = "0x33ACD60", VA = "0x33ACD60")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x33ACD90", Offset = "0x33ACD90", VA = "0x33ACD90")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x33ACDC0", Offset = "0x33ACDC0", VA = "0x33ACDC0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x33AD3C8", Offset = "0x33AD3C8", VA = "0x33AD3C8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x33AD524", Offset = "0x33AD524", VA = "0x33AD524", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x33ADEA8", Offset = "0x33ADEA8", VA = "0x33ADEA8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x33AE828", Offset = "0x33AE828", VA = "0x33AE828")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x33AE88C", Offset = "0x33AE88C", VA = "0x33AE88C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15FB")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41218E0")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverAim aim;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Constraints pelvis;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1603")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000035")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x33AD198", Offset = "0x33AD198", VA = "0x33AD198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x33AEB88", Offset = "0x33AEB88", VA = "0x33AEB88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x33AD904", Offset = "0x33AD904", VA = "0x33AD904")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x33AE968", Offset = "0x33AE968", VA = "0x33AE968")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform transform;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41218F0")]
		public float weight;

		[Token(Token = "0x17000037")]
		public bool isValid
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x33AF7B0", Offset = "0x33AF7B0", VA = "0x33AF7B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EA")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x33AF8CC", Offset = "0x33AF8CC", VA = "0x33AF8CC")]
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
		[Address(RVA = "0x33AF8FC", Offset = "0x33AF8FC", VA = "0x33AF8FC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x33AFACC", Offset = "0x33AFACC", VA = "0x33AFACC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x33AFAFC", Offset = "0x33AFAFC", VA = "0x33AFAFC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x160B")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool initiated;

		[Token(Token = "0x17000038")]
		private bool positionChanged
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x33AFF40", Offset = "0x33AFF40", VA = "0x33AFF40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x33AFB44", Offset = "0x33AFB44", VA = "0x33AFB44", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x33B0074", Offset = "0x33B0074", VA = "0x33B0074")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x33B00A4", Offset = "0x33B00A4", VA = "0x33B00A4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121900")]
		public Quaternion rotation;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x33B00EC", Offset = "0x33B00EC", VA = "0x33B00EC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x33B02CC", Offset = "0x33B02CC", VA = "0x33B02CC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x33B02FC", Offset = "0x33B02FC", VA = "0x33B02FC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1613")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121910")]
		private bool initiated;

		[Token(Token = "0x17000039")]
		private bool rotationChanged
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x33B0734", Offset = "0x33B0734", VA = "0x33B0734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x33B0344", Offset = "0x33B0344", VA = "0x33B0344", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x33B0864", Offset = "0x33B0864", VA = "0x33B0864")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x33B0894", Offset = "0x33B0894", VA = "0x33B0894")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC4760", Offset = "0xCC4760")]
		public float positionWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121920")]
		public Vector3 rotation;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC47A8", Offset = "0xCC47A8")]
		public float rotationWeight;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x33B08DC", Offset = "0x33B08DC", VA = "0x33B08DC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x33ADDD4", Offset = "0x33ADDD4", VA = "0x33ADDD4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x33AE250", Offset = "0x33AE250", VA = "0x33AE250")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x33AEE80", Offset = "0x33AEE80", VA = "0x33AEE80")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC47F0", Offset = "0xCC47F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC47F0", Offset = "0xCC47F0")]
		public float weight;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC488C", Offset = "0xCC488C")]
		public Transform bone1;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1623")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC48F0", Offset = "0xCC48F0")]
		public Transform bone2;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4954", Offset = "0xCC4954")]
		public Transform bone3;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121930")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC49B8", Offset = "0xCC49B8")]
		public Transform tip;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4A1C", Offset = "0xCC4A1C")]
		public Transform target;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC4A80", Offset = "0xCC4A80")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolverLimb solver;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162B")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121940")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x33C3100", Offset = "0x33C3100", VA = "0x33C3100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDA0C", Offset = "0xCCDA0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x33C3144", Offset = "0x33C3144", VA = "0x33C3144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDA48", Offset = "0xCCDA48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x33C3190", Offset = "0x33C3190", VA = "0x33C3190")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x33C31E4", Offset = "0x33C31E4", VA = "0x33C31E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x33C3258", Offset = "0x33C3258", VA = "0x33C3258")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x33C32B4", Offset = "0x33C32B4", VA = "0x33C32B4")]
			set
			{
			}
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x33C33FC", Offset = "0x33C33FC", VA = "0x33C33FC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x33C36C4", Offset = "0x33C36C4", VA = "0x33C36C4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x33C3C20", Offset = "0x33C3C20", VA = "0x33C3C20")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x33C3DEC", Offset = "0x33C3DEC", VA = "0x33C3DEC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x33C43E0", Offset = "0x33C43E0", VA = "0x33C43E0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4ABC", Offset = "0xCC4ABC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC4ABC", Offset = "0xCC4ABC")]
		public float weight;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Finger[] fingers;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC4B58", Offset = "0xCC4B58")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700003D")]
		public bool initiated
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x33C4424", Offset = "0x33C4424", VA = "0x33C4424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDA84", Offset = "0xCCDA84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x33C4468", Offset = "0x33C4468", VA = "0x33C4468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDAC0", Offset = "0xCCDAC0")]
			private set
			{
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x33C44B4", Offset = "0x33C44B4", VA = "0x33C44B4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x33C4604", Offset = "0x33C4604", VA = "0x33C4604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDAFC", Offset = "0xCCDAFC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x33C4D98", Offset = "0x33C4D98", VA = "0x33C4D98")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x33C5180", Offset = "0x33C5180", VA = "0x33C5180")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x33C4BAC", Offset = "0x33C4BAC", VA = "0x33C4BAC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x33C54C0", Offset = "0x33C54C0", VA = "0x33C54C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x33C5650", Offset = "0x33C5650", VA = "0x33C5650")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x33C578C", Offset = "0x33C578C", VA = "0x33C578C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x33C5884", Offset = "0x33C5884", VA = "0x33C5884", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x33C58B4", Offset = "0x33C58B4", VA = "0x33C58B4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x33C58E4", Offset = "0x33C58E4", VA = "0x33C58E4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1633")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4B94", Offset = "0xCC4B94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC4B94", Offset = "0xCC4B94")]
		public float weight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4C30", Offset = "0xCC4C30")]
		public Grounding solver;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121950")]
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
		[Address(RVA = "0x33C7C94", Offset = "0x33C7C94", VA = "0x33C7C94")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x33C8260", Offset = "0x33C8260", VA = "0x33C8260")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x33C7F30", Offset = "0x33C7F30", VA = "0x33C7F30")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x33C82C4", Offset = "0x33C82C4", VA = "0x33C82C4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600031C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x33C86E8", Offset = "0x33C86E8", VA = "0x33C86E8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCBFEFC", Offset = "0xCBFEFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCBFEFC", Offset = "0xCBFEFC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4C94", Offset = "0xCC4C94")]
		public BipedIK ik;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4CF8", Offset = "0xCC4CF8")]
		public float spineBend;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4D5C", Offset = "0xCC4D5C")]
		public float spineSpeed;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121960")]
		private Transform[] feet;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1643")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float lastWeight;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x33C8C20", Offset = "0x33C8C20", VA = "0x33C8C20", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDB60", Offset = "0xCCDB60")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x33C8CA4", Offset = "0x33C8CA4", VA = "0x33C8CA4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDBC4", Offset = "0xCCDBC4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x33C8D28", Offset = "0x33C8D28", VA = "0x33C8D28", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x33C8F68", Offset = "0x33C8F68", VA = "0x33C8F68")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x33C91A4", Offset = "0x33C91A4", VA = "0x33C91A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x33C934C", Offset = "0x33C934C", VA = "0x33C934C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x33C9E0C", Offset = "0x33C9E0C", VA = "0x33C9E0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x33C9EEC", Offset = "0x33C9EEC", VA = "0x33C9EEC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x33CB3CC", Offset = "0x33CB3CC", VA = "0x33CB3CC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x33CB698", Offset = "0x33CB698", VA = "0x33CB698")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x33CBA60", Offset = "0x33CBA60", VA = "0x33CBA60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x33CBD4C", Offset = "0x33CBD4C", VA = "0x33CBD4C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCBFFA8", Offset = "0xCBFFA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCBFFA8", Offset = "0xCBFFA8")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200011B")]
		public class SpineEffector
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA214", Offset = "0xCCA214")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA278", Offset = "0xCCA278")]
			public float horizontalWeight;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA2DC", Offset = "0xCCA2DC")]
			public float verticalWeight;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x33CDD1C", Offset = "0x33CDD1C", VA = "0x33CDD1C")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121970")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4DC0", Offset = "0xCC4DC0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4E24", Offset = "0xCC4E24")]
		public float spineBend;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4E88", Offset = "0xCC4E88")]
		public float spineSpeed;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164B")]
		private Transform[] feet;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121980")]
		private bool firstSolve;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x33CBE4C", Offset = "0x33CBE4C", VA = "0x33CBE4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDC28", Offset = "0xCCDC28")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x33CBED0", Offset = "0x33CBED0", VA = "0x33CBED0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDC8C", Offset = "0xCCDC8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x33CBF54", Offset = "0x33CBF54", VA = "0x33CBF54", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDCF0", Offset = "0xCCDCF0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x33CBFD8", Offset = "0x33CBFD8", VA = "0x33CBFD8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x33CC0D0", Offset = "0x33CC0D0", VA = "0x33CC0D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x33CC280", Offset = "0x33CC280", VA = "0x33CC280")]
		private void Update()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x33CC7D0", Offset = "0x33CC7D0", VA = "0x33CC7D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x33CC800", Offset = "0x33CC800", VA = "0x33CC800")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x33CC438", Offset = "0x33CC438", VA = "0x33CC438")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x33CC830", Offset = "0x33CC830", VA = "0x33CC830")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x33CD314", Offset = "0x33CD314", VA = "0x33CD314")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x33CD740", Offset = "0x33CD740", VA = "0x33CD740")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x33CDA14", Offset = "0x33CDA14", VA = "0x33CDA14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x33CDC14", Offset = "0x33CDC14", VA = "0x33CDC14")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0054", Offset = "0xCC0054")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0054", Offset = "0xCC0054")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1653")]
		public IK[] legs;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4EEC", Offset = "0xCC4EEC")]
		public Transform pelvis;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121990")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4F50", Offset = "0xCC4F50")]
		public Transform characterRoot;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC4FB4", Offset = "0xCC4FB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC4FB4", Offset = "0xCC4FB4")]
		public float rootRotationWeight;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5050", Offset = "0xCC5050")]
		public float rootRotationSpeed;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC50B4", Offset = "0xCC50B4")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165B")]
		private Transform[] feet;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41219A0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int solvedFeet;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool solved;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1663")]
		private float lastWeight;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x33CDD60", Offset = "0x33CDD60", VA = "0x33CDD60", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDD54", Offset = "0xCCDD54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x33CDDE4", Offset = "0x33CDDE4", VA = "0x33CDDE4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDDB8", Offset = "0xCCDDB8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x33CDE68", Offset = "0x33CDE68", VA = "0x33CDE68", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x33CDEB0", Offset = "0x33CDEB0", VA = "0x33CDEB0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x33CE310", Offset = "0x33CE310", VA = "0x33CE310")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x33CE560", Offset = "0x33CE560", VA = "0x33CE560")]
		private void Update()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x33CF344", Offset = "0x33CF344", VA = "0x33CF344")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x33CF928", Offset = "0x33CF928", VA = "0x33CF928")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x33CFEB0", Offset = "0x33CFEB0", VA = "0x33CFEB0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x33D0104", Offset = "0x33D0104", VA = "0x33D0104")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x33D0520", Offset = "0x33D0520", VA = "0x33D0520")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x33D08B0", Offset = "0x33D08B0", VA = "0x33D08B0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0100", Offset = "0xCC0100")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0100", Offset = "0xCC0100")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200011C")]
		public struct Foot
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x167B")]
			public Transform transform;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Quaternion rotation;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41219F0")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x33D2164", Offset = "0x33D2164", VA = "0x33D2164")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5118", Offset = "0xCC5118")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41219B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC517C", Offset = "0xCC517C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC517C", Offset = "0xCC517C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5218", Offset = "0xCC5218")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC5218", Offset = "0xCC5218")]
		public float minRootRotation;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC52B4", Offset = "0xCC52B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC52B4", Offset = "0xCC52B4")]
		public float maxRootRotation;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5350", Offset = "0xCC5350")]
		public float rootRotationSpeed;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x166B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC53B4", Offset = "0xCC53B4")]
		public float maxLegOffset;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5418", Offset = "0xCC5418")]
		public float maxForeLegOffset;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41219C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC547C", Offset = "0xCC547C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC547C", Offset = "0xCC547C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5518", Offset = "0xCC5518")]
		public Transform characterRoot;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC557C", Offset = "0xCC557C")]
		public Transform pelvis;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC55E0", Offset = "0xCC55E0")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1673")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5644", Offset = "0xCC5644")]
		public Transform head;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IK[] legs;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41219D0")]
		public IK[] forelegs;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Foot[] feet;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167B")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41219E0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int solvedFeet;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1683")]
		private bool solved;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float angle;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41219F0")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headRotation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x33D09B0", Offset = "0x33D09B0", VA = "0x33D09B0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDE1C", Offset = "0xCCDE1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x33D0A34", Offset = "0x33D0A34", VA = "0x33D0A34", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCDE80", Offset = "0xCCDE80")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x33D0AB8", Offset = "0x33D0AB8", VA = "0x33D0AB8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x33D0B20", Offset = "0x33D0B20", VA = "0x33D0B20")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x33D0EDC", Offset = "0x33D0EDC", VA = "0x33D0EDC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x33D1250", Offset = "0x33D1250", VA = "0x33D1250")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x33D13A8", Offset = "0x33D13A8", VA = "0x33D13A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x33D1560", Offset = "0x33D1560", VA = "0x33D1560")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x33D1B90", Offset = "0x33D1B90", VA = "0x33D1B90")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x33D2210", Offset = "0x33D2210", VA = "0x33D2210")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x33D24E4", Offset = "0x33D24E4", VA = "0x33D24E4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x33D2CF4", Offset = "0x33D2CF4", VA = "0x33D2CF4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x33D3F98", Offset = "0x33D3F98", VA = "0x33D3F98")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x33D4540", Offset = "0x33D4540", VA = "0x33D4540")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x33D48CC", Offset = "0x33D48CC", VA = "0x33D48CC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x33D4FD4", Offset = "0x33D4FD4", VA = "0x33D4FD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x33D5054", Offset = "0x33D5054", VA = "0x33D5054")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x33D53C4", Offset = "0x33D53C4", VA = "0x33D53C4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA340", Offset = "0xCCA340")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16B3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA37C", Offset = "0xCCA37C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA3B8", Offset = "0xCCA3B8")]
			private Quaternion <rotationOffset>k__BackingField;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA3F4", Offset = "0xCCA3F4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA430", Offset = "0xCCA430")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA46C", Offset = "0xCCA46C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA4A8", Offset = "0xCCA4A8")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16BB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA4E4", Offset = "0xCCA4E4")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Grounding grounding;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121A60")]
			private float lastTime;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float deltaTime;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C3")]
			private Quaternion r;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private RaycastHit heelHit;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121A70")]
			private Vector3 up;

			[Token(Token = "0x170000BE")]
			public bool isGrounded
			{
				[Token(Token = "0x6000806")]
				[Address(RVA = "0x33D8EF8", Offset = "0x33D8EF8", VA = "0x33D8EF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD10C8", Offset = "0xCD10C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000807")]
				[Address(RVA = "0x33D8F3C", Offset = "0x33D8F3C", VA = "0x33D8F3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1104", Offset = "0xCD1104")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x33D8F88", Offset = "0x33D8F88", VA = "0x33D8F88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1140", Offset = "0xCD1140")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000809")]
				[Address(RVA = "0x33D8FC8", Offset = "0x33D8FC8", VA = "0x33D8FC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD117C", Offset = "0xCD117C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public Quaternion rotationOffset
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0x33D9028", Offset = "0x33D9028", VA = "0x33D9028")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD11B8", Offset = "0xCD11B8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600080B")]
				[Address(RVA = "0x33D9070", Offset = "0x33D9070", VA = "0x33D9070")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD11F4", Offset = "0xCD11F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public bool initiated
			{
				[Token(Token = "0x600080C")]
				[Address(RVA = "0x33D91A0", Offset = "0x33D91A0", VA = "0x33D91A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1230", Offset = "0xCD1230")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600080D")]
				[Address(RVA = "0x33D91E4", Offset = "0x33D91E4", VA = "0x33D91E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD126C", Offset = "0xCD126C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public float heightFromGround
			{
				[Token(Token = "0x600080E")]
				[Address(RVA = "0x33D9230", Offset = "0x33D9230", VA = "0x33D9230")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD12A8", Offset = "0xCD12A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600080F")]
				[Address(RVA = "0x33D9260", Offset = "0x33D9260", VA = "0x33D9260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD12E4", Offset = "0xCD12E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0x33D9298", Offset = "0x33D9298", VA = "0x33D9298")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1320", Offset = "0xCD1320")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000811")]
				[Address(RVA = "0x33D92D8", Offset = "0x33D92D8", VA = "0x33D92D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD135C", Offset = "0xCD135C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public Transform transform
			{
				[Token(Token = "0x6000812")]
				[Address(RVA = "0x33D9338", Offset = "0x33D9338", VA = "0x33D9338")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1398", Offset = "0xCD1398")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x33D9368", Offset = "0x33D9368", VA = "0x33D9368")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD13D4", Offset = "0xCD13D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public float IKOffset
			{
				[Token(Token = "0x6000814")]
				[Address(RVA = "0x33D93A0", Offset = "0x33D93A0", VA = "0x33D93A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1410", Offset = "0xCD1410")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x33D93D0", Offset = "0x33D93D0", VA = "0x33D93D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD144C", Offset = "0xCD144C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600081A")]
				[Address(RVA = "0x33DA838", Offset = "0x33DA838", VA = "0x33DA838")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C7")]
			private float rootYOffset
			{
				[Token(Token = "0x6000823")]
				[Address(RVA = "0x33DADDC", Offset = "0x33DADDC", VA = "0x33DADDC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x33D6664", Offset = "0x33D6664", VA = "0x33D6664")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x33D9408", Offset = "0x33D9408", VA = "0x33D9408")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x33D86D8", Offset = "0x33D86D8", VA = "0x33D86D8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x33D68B8", Offset = "0x33D68B8", VA = "0x33D68B8")]
			public void Process()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x33DA1E4", Offset = "0x33DA1E4", VA = "0x33DA1E4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x33D94C4", Offset = "0x33D94C4", VA = "0x33D94C4")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x33DAB2C", Offset = "0x33DAB2C", VA = "0x33DAB2C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x33D9A64", Offset = "0x33D9A64", VA = "0x33D9A64")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x33D9C38", Offset = "0x33D9C38", VA = "0x33D9C38")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x33DACF4", Offset = "0x33DACF4", VA = "0x33DACF4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x33DA98C", Offset = "0x33DA98C", VA = "0x33DA98C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x33DB018", Offset = "0x33DB018", VA = "0x33DB018")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x33D6550", Offset = "0x33D6550", VA = "0x33D6550")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200011F")]
		public class Pelvis
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA520", Offset = "0xCCA520")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA55C", Offset = "0xCCA55C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Grounding grounding;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16CB")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float damperF;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121A80")]
			private bool initiated;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float lastTime;

			[Token(Token = "0x170000C8")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000825")]
				[Address(RVA = "0x33DB26C", Offset = "0x33DB26C", VA = "0x33DB26C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1488", Offset = "0xCD1488")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000826")]
				[Address(RVA = "0x33DB2AC", Offset = "0x33DB2AC", VA = "0x33DB2AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD14C4", Offset = "0xCD14C4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public float heightOffset
			{
				[Token(Token = "0x6000827")]
				[Address(RVA = "0x33DB30C", Offset = "0x33DB30C", VA = "0x33DB30C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1500", Offset = "0xCD1500")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000828")]
				[Address(RVA = "0x33DB33C", Offset = "0x33DB33C", VA = "0x33DB33C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD153C", Offset = "0xCD153C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x33D67F0", Offset = "0x33D67F0", VA = "0x33D67F0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x33D854C", Offset = "0x33D854C", VA = "0x33D854C")]
			public void Reset()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x33DB374", Offset = "0x33DB374", VA = "0x33DB374")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x33D7EC0", Offset = "0x33D7EC0", VA = "0x33D7EC0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x33D6634", Offset = "0x33D6634", VA = "0x33D6634")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC56E4", Offset = "0xCC56E4")]
		public LayerMask layers;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5748", Offset = "0xCC5748")]
		public float maxStep;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC57AC", Offset = "0xCC57AC")]
		public float heightOffset;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1693")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5810", Offset = "0xCC5810")]
		public float footSpeed;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5874", Offset = "0xCC5874")]
		public float footRadius;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121A10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC58D8", Offset = "0xCC58D8")]
		public float prediction;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC593C", Offset = "0xCC593C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC593C", Offset = "0xCC593C")]
		public float footRotationWeight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC59D8", Offset = "0xCC59D8")]
		public float footRotationSpeed;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5A3C", Offset = "0xCC5A3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC5A3C", Offset = "0xCC5A3C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5AD8", Offset = "0xCC5AD8")]
		public bool rotateSolver;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5B3C", Offset = "0xCC5B3C")]
		public float pelvisSpeed;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121A20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5BA0", Offset = "0xCC5BA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC5BA0", Offset = "0xCC5BA0")]
		public float pelvisDamper;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5C3C", Offset = "0xCC5C3C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5CA0", Offset = "0xCC5CA0")]
		public float liftPelvisWeight;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5D04", Offset = "0xCC5D04")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5D68", Offset = "0xCC5D68")]
		public Quality quality;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC5DCC", Offset = "0xCC5DCC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121A30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC5E08", Offset = "0xCC5E08")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC5E44", Offset = "0xCC5E44")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC5E80", Offset = "0xCC5E80")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC5EBC", Offset = "0xCC5EBC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16AB")]
		private bool initiated;

		[Token(Token = "0x1700003E")]
		public Leg[] legs
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x33D555C", Offset = "0x33D555C", VA = "0x33D555C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDEE4", Offset = "0xCCDEE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x33D558C", Offset = "0x33D558C", VA = "0x33D558C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDF20", Offset = "0xCCDF20")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x33D55C4", Offset = "0x33D55C4", VA = "0x33D55C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDF5C", Offset = "0xCCDF5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x33D55F4", Offset = "0x33D55F4", VA = "0x33D55F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDF98", Offset = "0xCCDF98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool isGrounded
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x33D562C", Offset = "0x33D562C", VA = "0x33D562C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCDFD4", Offset = "0xCCDFD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x33D5670", Offset = "0x33D5670", VA = "0x33D5670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCE010", Offset = "0xCCE010")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Transform root
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x33D56BC", Offset = "0x33D56BC", VA = "0x33D56BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCE04C", Offset = "0xCCE04C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x33D56EC", Offset = "0x33D56EC", VA = "0x33D56EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCE088", Offset = "0xCCE088")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x33D5724", Offset = "0x33D5724", VA = "0x33D5724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCE0C4", Offset = "0xCCE0C4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x33D574C", Offset = "0x33D574C", VA = "0x33D574C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCE100", Offset = "0xCCE100")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x33D57B8", Offset = "0x33D57B8", VA = "0x33D57B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 up
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x33CB57C", Offset = "0x33CB57C", VA = "0x33CB57C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		private bool useRootRotation
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x33D888C", Offset = "0x33D888C", VA = "0x33D888C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x33D58AC", Offset = "0x33D58AC", VA = "0x33D58AC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x33D6254", Offset = "0x33D6254", VA = "0x33D6254")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x33C9858", Offset = "0x33C9858", VA = "0x33C9858")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x33CAC0C", Offset = "0x33CAC0C", VA = "0x33CAC0C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x33CEEAC", Offset = "0x33CEEAC", VA = "0x33CEEAC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x33C8E20", Offset = "0x33C8E20", VA = "0x33C8E20")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x33D6854", Offset = "0x33D6854", VA = "0x33D6854")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x33D8A14", Offset = "0x33D8A14", VA = "0x33D8A14")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x33D8CFC", Offset = "0x33D8CFC", VA = "0x33D8CFC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x33C87A0", Offset = "0x33C87A0", VA = "0x33C87A0")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC01AC", Offset = "0xCC01AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC01AC", Offset = "0xCC01AC")]
	public class AimIK : IK
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverAim solver;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x26A1F68", Offset = "0x26A1F68", VA = "0x26A1F68", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE13C", Offset = "0xCCE13C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x26A1FEC", Offset = "0x26A1FEC", VA = "0x26A1FEC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE1A0", Offset = "0xCCE1A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x26A2070", Offset = "0x26A2070", VA = "0x26A2070")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE204", Offset = "0xCCE204")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x26A20F4", Offset = "0x26A20F4", VA = "0x26A20F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE268", Offset = "0xCCE268")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x26A2178", Offset = "0x26A2178", VA = "0x26A2178")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE2CC", Offset = "0xCCE2CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x26A21FC", Offset = "0x26A21FC", VA = "0x26A21FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x26A222C", Offset = "0x26A222C", VA = "0x26A222C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0258", Offset = "0xCC0258")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0258", Offset = "0xCC0258")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x33AF498", Offset = "0x33AF498", VA = "0x33AF498", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE330", Offset = "0xCCE330")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x33AF51C", Offset = "0x33AF51C", VA = "0x33AF51C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE394", Offset = "0xCCE394")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x33AF5A0", Offset = "0x33AF5A0", VA = "0x33AF5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE3F8", Offset = "0xCCE3F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x33AF624", Offset = "0x33AF624", VA = "0x33AF624")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE45C", Offset = "0xCCE45C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x33AF6A8", Offset = "0x33AF6A8", VA = "0x33AF6A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x33AF6D8", Offset = "0x33AF6D8", VA = "0x33AF6D8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0304", Offset = "0xCC0304")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0304", Offset = "0xCC0304")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D3")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x33B09F8", Offset = "0x33B09F8", VA = "0x33B09F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE4C0", Offset = "0xCCE4C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x33B0A7C", Offset = "0x33B0A7C", VA = "0x33B0A7C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE524", Offset = "0xCCE524")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x33B0B00", Offset = "0x33B0B00", VA = "0x33B0B00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE588", Offset = "0xCCE588")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x33B0B84", Offset = "0x33B0B84", VA = "0x33B0B84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE5EC", Offset = "0xCCE5EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x33B0C08", Offset = "0x33B0C08", VA = "0x33B0C08", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x33B0C38", Offset = "0x33B0C38", VA = "0x33B0C38")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC03B0", Offset = "0xCC03B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC03B0", Offset = "0xCC03B0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x33B1C24", Offset = "0x33B1C24", VA = "0x33B1C24", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE650", Offset = "0xCCE650")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x33B1CA8", Offset = "0x33B1CA8", VA = "0x33B1CA8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE6B4", Offset = "0xCCE6B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x33B1D2C", Offset = "0x33B1D2C", VA = "0x33B1D2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE718", Offset = "0xCCE718")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x33B1DB0", Offset = "0x33B1DB0", VA = "0x33B1DB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE77C", Offset = "0xCCE77C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x33B1E34", Offset = "0x33B1E34", VA = "0x33B1E34", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x33B1E64", Offset = "0x33B1E64", VA = "0x33B1E64")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC045C", Offset = "0xCC045C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC045C", Offset = "0xCC045C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121A90")]
		public BipedReferences references;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x33C599C", Offset = "0x33C599C", VA = "0x33C599C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE7E0", Offset = "0xCCE7E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x33C5A20", Offset = "0x33C5A20", VA = "0x33C5A20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE844", Offset = "0xCCE844")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x33C5AA4", Offset = "0x33C5AA4", VA = "0x33C5AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE8A8", Offset = "0xCCE8A8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x33C5B28", Offset = "0x33C5B28", VA = "0x33C5B28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE90C", Offset = "0xCCE90C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x33C5BAC", Offset = "0x33C5BAC", VA = "0x33C5BAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE970", Offset = "0xCCE970")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x33C5C30", Offset = "0x33C5C30", VA = "0x33C5C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCE9D4", Offset = "0xCCE9D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x33C5CB4", Offset = "0x33C5CB4", VA = "0x33C5CB4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x33C5D34", Offset = "0x33C5D34", VA = "0x33C5D34", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x33C5D64", Offset = "0x33C5D64", VA = "0x33C5D64")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x33C62B8", Offset = "0x33C62B8", VA = "0x33C62B8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x33C6948", Offset = "0x33C6948", VA = "0x33C6948")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEA38", Offset = "0xCCEA38")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x33C69B0", Offset = "0x33C69B0", VA = "0x33C69B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEA9C", Offset = "0xCCEA9C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x33C6BB4", Offset = "0x33C6BB4", VA = "0x33C6BB4")]
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
		[Address(RVA = "0x33DF338", Offset = "0x33DF338", VA = "0x33DF338", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x33DF418", Offset = "0x33DF418", VA = "0x33DF418", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x33DF4BC", Offset = "0x33DF4BC", VA = "0x33DF4BC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000397")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000398")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x33AF780", Offset = "0x33AF780", VA = "0x33AF780")]
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
		[Address(RVA = "0x38C6B0C", Offset = "0x38C6B0C", VA = "0x38C6B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x38C6C00", Offset = "0x38C6C00", VA = "0x38C6C00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x38C6E34", Offset = "0x38C6E34", VA = "0x38C6E34")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0508", Offset = "0xCC0508")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0508", Offset = "0xCC0508")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb solver;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x3220FFC", Offset = "0x3220FFC", VA = "0x3220FFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEB00", Offset = "0xCCEB00")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x3221080", Offset = "0x3221080", VA = "0x3221080", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEB64", Offset = "0xCCEB64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x3221104", Offset = "0x3221104", VA = "0x3221104")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEBC8", Offset = "0xCCEBC8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x3221188", Offset = "0x3221188", VA = "0x3221188")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEC2C", Offset = "0xCCEC2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x322120C", Offset = "0x322120C", VA = "0x322120C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x322123C", Offset = "0x322123C", VA = "0x322123C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC05B4", Offset = "0xCC05B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC05B4", Offset = "0xCC05B4")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16DB")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x32212E4", Offset = "0x32212E4", VA = "0x32212E4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEC90", Offset = "0xCCEC90")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x3221368", Offset = "0x3221368", VA = "0x3221368", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCECF4", Offset = "0xCCECF4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x32213EC", Offset = "0x32213EC", VA = "0x32213EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCED58", Offset = "0xCCED58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x3221470", Offset = "0x3221470", VA = "0x3221470")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEDBC", Offset = "0xCCEDBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x32214F4", Offset = "0x32214F4", VA = "0x32214F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x3221524", Offset = "0x3221524", VA = "0x3221524")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0660", Offset = "0xCC0660")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0660", Offset = "0xCC0660")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x3232548", Offset = "0x3232548", VA = "0x3232548", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEE20", Offset = "0xCCEE20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x32325CC", Offset = "0x32325CC", VA = "0x32325CC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEE84", Offset = "0xCCEE84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x3232650", Offset = "0x3232650", VA = "0x3232650")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEEE8", Offset = "0xCCEEE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x32326D4", Offset = "0x32326D4", VA = "0x32326D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCEF4C", Offset = "0xCCEF4C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x3232758", Offset = "0x3232758", VA = "0x3232758", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x3232788", Offset = "0x3232788", VA = "0x3232788")]
		public TrigonometricIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121AA0")]
		public FABRIK ik;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC5EF8", Offset = "0xCC5EF8")]
		public float pull;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC5F40", Offset = "0xCC5F40")]
		public float pin;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x33B0CE0", Offset = "0x33B0CE0", VA = "0x33B0CE0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x33B0EE4", Offset = "0x33B0EE4", VA = "0x33B0EE4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x33B0F3C", Offset = "0x33B0F3C", VA = "0x33B0F3C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x33B18E0", Offset = "0x33B18E0", VA = "0x33B18E0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x33B1188", Offset = "0x33B1188", VA = "0x33B1188")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x33B1B5C", Offset = "0x33B1B5C", VA = "0x33B1B5C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E3")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121AB0")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16EB")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool initiated;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x33B1F0C", Offset = "0x33B1F0C", VA = "0x33B1F0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x33B2B7C", Offset = "0x33B2B7C", VA = "0x33B2B7C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x33B2FA8", Offset = "0x33B2FA8", VA = "0x33B2FA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x33B3188", Offset = "0x33B3188", VA = "0x33B3188")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA598", Offset = "0xCCA598")]
			public Transform transform;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x172B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA5FC", Offset = "0xCCA5FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCA5FC", Offset = "0xCCA5FC")]
			public float weight;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x33B9F5C", Offset = "0x33B9F5C", VA = "0x33B9F5C")]
			public BendBone()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x33BA04C", Offset = "0x33BA04C", VA = "0x33BA04C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x33B41C4", Offset = "0x33B41C4", VA = "0x33B41C4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x33B4B34", Offset = "0x33B4B34", VA = "0x33B4B34")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121AC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5F88", Offset = "0xCC5F88")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCC5FEC", Offset = "0xCC5FEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC5FEC", Offset = "0xCC5FEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC5FEC", Offset = "0xCC5FEC")]
		public float positionWeight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC60D0", Offset = "0xCC60D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC60D0", Offset = "0xCC60D0")]
		public float bodyWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC616C", Offset = "0xCC616C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC616C", Offset = "0xCC616C")]
		public float thighWeight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F3")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCC6208", Offset = "0xCC6208")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6208", Offset = "0xCC6208")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6208", Offset = "0xCC6208")]
		public float rotationWeight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC62EC", Offset = "0xCC62EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC62EC", Offset = "0xCC62EC")]
		public float bodyClampWeight;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121AD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6388", Offset = "0xCC6388")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6388", Offset = "0xCC6388")]
		public float headClampWeight;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6424", Offset = "0xCC6424")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6424", Offset = "0xCC6424")]
		public float bendWeight;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC64C0", Offset = "0xCC64C0")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCC6524", Offset = "0xCC6524")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6524", Offset = "0xCC6524")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6524", Offset = "0xCC6524")]
		public float CCDWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16FB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6608", Offset = "0xCC6608")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6608", Offset = "0xCC6608")]
		public float roll;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC66A4", Offset = "0xCC66A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC66A4", Offset = "0xCC66A4")]
		public float damper;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121AE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6740", Offset = "0xCC6740")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCC67A4", Offset = "0xCC67A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC67A4", Offset = "0xCC67A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC67A4", Offset = "0xCC67A4")]
		public float postStretchWeight;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6888", Offset = "0xCC6888")]
		public float maxStretch;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC68EC", Offset = "0xCC68EC")]
		public float stretchDamper;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1703")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC6950", Offset = "0xCC6950")]
		public bool fixHead;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC69B4", Offset = "0xCC69B4")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121AF0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCC6A18", Offset = "0xCC6A18")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6A7C", Offset = "0xCC6A7C")]
		public float chestDirectionWeight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] chestBones;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170B")]
		private Vector3 offset;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 headToBody;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B00")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1713")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float shoulderDist;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B10")]
		private float leftShoulderDist;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float rightShoulderDist;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion chestRotation;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171B")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B20")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1723")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int bendBonesCount;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B30")]
		private int ccdBonesCount;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int stretchBonesCount;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chestBonesCount;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x33B31B8", Offset = "0x33B31B8", VA = "0x33B31B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x33B3770", Offset = "0x33B3770", VA = "0x33B3770")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x33B4234", Offset = "0x33B4234", VA = "0x33B4234")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x33B4BA4", Offset = "0x33B4BA4", VA = "0x33B4BA4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x33B610C", Offset = "0x33B610C", VA = "0x33B610C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x33B67F8", Offset = "0x33B67F8", VA = "0x33B67F8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x33B6FA8", Offset = "0x33B6FA8", VA = "0x33B6FA8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x33B8A88", Offset = "0x33B8A88", VA = "0x33B8A88")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x33B5AC4", Offset = "0x33B5AC4", VA = "0x33B5AC4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x33B8F08", Offset = "0x33B8F08", VA = "0x33B8F08")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x33B8820", Offset = "0x33B8820", VA = "0x33B8820")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x33B83E8", Offset = "0x33B83E8", VA = "0x33B83E8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x33B97C4", Offset = "0x33B97C4", VA = "0x33B97C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x33B9CA8", Offset = "0x33B9CA8", VA = "0x33B9CA8")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float pushElasticity;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121B80")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA710", Offset = "0xCCA710")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1753")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCA74C", Offset = "0xCCA74C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float crossFade;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121B90")]
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
				[Address(RVA = "0x33C2F78", Offset = "0x33C2F78", VA = "0x33C2F78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1578", Offset = "0xCD1578")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x33C2FA8", Offset = "0x33C2FA8", VA = "0x33C2FA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD15B4", Offset = "0xCD15B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public bool isRigid
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x33C2FE0", Offset = "0x33C2FE0", VA = "0x33C2FE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD15F0", Offset = "0xCD15F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000835")]
				[Address(RVA = "0x33C3024", Offset = "0x33C3024", VA = "0x33C3024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD162C", Offset = "0xCD162C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x33C3070", Offset = "0x33C3070", VA = "0x33C3070")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x33BBDA8", Offset = "0x33BBDA8", VA = "0x33BBDA8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x33BD238", Offset = "0x33BD238", VA = "0x33BD238")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x33C27C8", Offset = "0x33C27C8", VA = "0x33C27C8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6AC4", Offset = "0xCC6AC4")]
		public float pin;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6B0C", Offset = "0xCC6B0C")]
		public float pull;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6B54", Offset = "0xCC6B54")]
		public float push;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6B9C", Offset = "0xCC6B9C")]
		public float pushParent;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1733")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6BE8", Offset = "0xCC6BE8")]
		public float reach;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B50")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x173B")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float rootLength;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B60")]
		private bool initiated;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float length;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float distance;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolver.Point p;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1743")]
		private float reachForce;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float pullParentSum;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121B70")]
		private float[] crossFades;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
		[Address(RVA = "0x33BA16C", Offset = "0x33BA16C", VA = "0x33BA16C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x33BA3E4", Offset = "0x33BA3E4", VA = "0x33BA3E4")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x33BA5D4", Offset = "0x33BA5D4", VA = "0x33BA5D4")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x33BA794", Offset = "0x33BA794", VA = "0x33BA794")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x33BA978", Offset = "0x33BA978", VA = "0x33BA978")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x33BAC38", Offset = "0x33BAC38", VA = "0x33BAC38")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x33BC51C", Offset = "0x33BC51C", VA = "0x33BC51C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x33BB044", Offset = "0x33BB044", VA = "0x33BB044")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x33BD78C", Offset = "0x33BD78C", VA = "0x33BD78C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x33BE16C", Offset = "0x33BE16C", VA = "0x33BE16C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x33BECAC", Offset = "0x33BECAC", VA = "0x33BECAC")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x33C0920", Offset = "0x33C0920", VA = "0x33C0920")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x33C195C", Offset = "0x33C195C", VA = "0x33C195C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x33C2060", Offset = "0x33C2060", VA = "0x33C2060")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x33C174C", Offset = "0x33C174C", VA = "0x33C174C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x33C04B4", Offset = "0x33C04B4", VA = "0x33C04B4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x33C1658", Offset = "0x33C1658", VA = "0x33C1658")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x33C2318", Offset = "0x33C2318", VA = "0x33C2318")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x33C1388", Offset = "0x33C1388", VA = "0x33C1388")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x33C1CB8", Offset = "0x33C1CB8", VA = "0x33C1CB8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone3;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1763")]
		public Transform bendGoal;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 direction;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121BB0")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6C30", Offset = "0xCC6C30")]
		public float weight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x176B")]
		public float clampF;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int chainIndex1;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121BC0")]
		private int nodeIndex1;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chainIndex2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex2;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chainIndex3;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1773")]
		private int nodeIndex3;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC6C78", Offset = "0xCC6C78")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000046")]
		public bool initiated
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x33DFB38", Offset = "0x33DFB38", VA = "0x33DFB38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCEFB0", Offset = "0xCCEFB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x33DFB7C", Offset = "0x33DFB7C", VA = "0x33DFB7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCEFEC", Offset = "0xCCEFEC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x33DF55C", Offset = "0x33DF55C", VA = "0x33DF55C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x33BA2F0", Offset = "0x33BA2F0", VA = "0x33BA2F0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x33DFBC8", Offset = "0x33DFBC8", VA = "0x33DFBC8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x33BBE64", Offset = "0x33BBE64", VA = "0x33BBE64")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x33BBECC", Offset = "0x33BBECC", VA = "0x33BBECC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x33E0108", Offset = "0x33E0108", VA = "0x33E0108")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x33E05A8", Offset = "0x33E05A8", VA = "0x33E05A8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x33BF59C", Offset = "0x33BF59C", VA = "0x33BF59C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x33DFCF8", Offset = "0x33DFCF8", VA = "0x33DFCF8")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x33DFF00", Offset = "0x33DFF00", VA = "0x33DFF00")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121BD0")]
		public Transform bone;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6CB4", Offset = "0xCC6CB4")]
		public float positionWeight;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6CFC", Offset = "0xCC6CFC")]
		public float rotationWeight;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x177B")]
		public Vector3 position;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Quaternion rotation;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121BE0")]
		public Vector3 positionOffset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC6D44", Offset = "0xCC6D44")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool effectChildNodes;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6D80", Offset = "0xCC6D80")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1783")]
		public Transform[] childBones;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform planeBone1;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121BF0")]
		public Transform planeBone2;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform planeBone3;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float posW;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178B")]
		private float rotW;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C00")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool firstUpdate;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1793")]
		private int chainIndex;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int nodeIndex;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C10")]
		private int plane1ChainIndex;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane1NodeIndex;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2ChainIndex;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179B")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C20")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000047")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x33E1000", Offset = "0x33E1000", VA = "0x33E1000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF028", Offset = "0xCCF028")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x33E1044", Offset = "0x33E1044", VA = "0x33E1044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF064", Offset = "0xCCF064")]
			private set
			{
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x33B9704", Offset = "0x33B9704", VA = "0x33B9704")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x33E1090", Offset = "0x33E1090", VA = "0x33E1090")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x33E123C", Offset = "0x33E123C", VA = "0x33E123C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x33E1514", Offset = "0x33E1514", VA = "0x33E1514")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x33E1824", Offset = "0x33E1824", VA = "0x33E1824")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x33E2220", Offset = "0x33E2220", VA = "0x33E2220")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x33E28C4", Offset = "0x33E28C4", VA = "0x33E28C4")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x33E2B74", Offset = "0x33E2B74", VA = "0x33E2B74")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x33E2CF8", Offset = "0x33E2CF8", VA = "0x33E2CF8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x33E3C70", Offset = "0x33E3C70", VA = "0x33E3C70")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x33E3D44", Offset = "0x33E3D44", VA = "0x33E3D44")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x33E4220", Offset = "0x33E4220", VA = "0x33E4220")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x33E4900", Offset = "0x33E4900", VA = "0x33E4900")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x17A3")]
			public int nodeIndex;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121C30")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 planePosition;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17AB")]
			public Vector3 ikPosition;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121C40")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float length;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Transform planeBone1;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17B3")]
			private Transform planeBone2;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Transform planeBone3;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121C50")]
			private int plane1ChainIndex;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane1NodeIndex;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2NodeIndex;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17BB")]
			private int plane3ChainIndex;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000CC")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600083B")]
				[Address(RVA = "0x38C75D0", Offset = "0x38C75D0", VA = "0x38C75D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CD")]
			public bool isNodeBone
			{
				[Token(Token = "0x600083E")]
				[Address(RVA = "0x38C78C0", Offset = "0x38C78C0", VA = "0x38C78C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CE")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000852")]
				[Address(RVA = "0x38C8468", Offset = "0x38C8468", VA = "0x38C8468")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x38C7408", Offset = "0x38C7408", VA = "0x38C7408")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x38C770C", Offset = "0x38C770C", VA = "0x38C770C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x38C77D0", Offset = "0x38C77D0", VA = "0x38C77D0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x38C7948", Offset = "0x38C7948", VA = "0x38C7948")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x38C7AAC", Offset = "0x38C7AAC", VA = "0x38C7AAC")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x38C7AF0", Offset = "0x38C7AF0", VA = "0x38C7AF0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x38C7D98", Offset = "0x38C7D98", VA = "0x38C7D98")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x38C7F8C", Offset = "0x38C7F8C", VA = "0x38C7F8C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x38C80FC", Offset = "0x38C80FC", VA = "0x38C80FC")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x38C8888", Offset = "0x38C8888", VA = "0x38C8888")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x38C88F8", Offset = "0x38C88F8", VA = "0x38C88F8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x38C8968", Offset = "0x38C8968", VA = "0x38C8968")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x38C89D8", Offset = "0x38C89D8", VA = "0x38C89D8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x38C8D18", Offset = "0x38C8D18", VA = "0x38C8D18")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x38C9420", Offset = "0x38C9420", VA = "0x38C9420")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x38C94A8", Offset = "0x38C94A8", VA = "0x38C94A8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x38C9798", Offset = "0x38C9798", VA = "0x38C9798")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x38C9858", Offset = "0x38C9858", VA = "0x38C9858")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x38C9CF4", Offset = "0x38C9CF4", VA = "0x38C9CF4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x38CA140", Offset = "0x38CA140", VA = "0x38CA140")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x38CA2F4", Offset = "0x38CA2F4", VA = "0x38CA2F4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x38C8F4C", Offset = "0x38C8F4C", VA = "0x38C8F4C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x38CA664", Offset = "0x38CA664", VA = "0x38CA664")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x38C6E64", Offset = "0x38C6E64", VA = "0x38C6E64", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x38C6E90", Offset = "0x38C6E90", VA = "0x38C6E90", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x38C6EA8", Offset = "0x38C6EA8", VA = "0x38C6EA8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x38C71C8", Offset = "0x38C71C8", VA = "0x38C71C8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x38C73D8", Offset = "0x38C73D8", VA = "0x38C73D8")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C60")]
		public Transform bone;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6DC8", Offset = "0xCC6DC8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x38CA700", Offset = "0x38CA700", VA = "0x38CA700", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x38CA8E0", Offset = "0x38CA8E0", VA = "0x38CA8E0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x38CA998", Offset = "0x38CA998", VA = "0x38CA998")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x38CAA68", Offset = "0x38CAA68", VA = "0x38CAA68")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x38CAAB0", Offset = "0x38CAAB0", VA = "0x38CAAB0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x38CAB08", Offset = "0x38CAB08", VA = "0x38CAB08", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x38CAC14", Offset = "0x38CAC14", VA = "0x38CAC14")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x38CAC5C", Offset = "0x38CAC5C", VA = "0x38CAC5C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C3")]
		public Transform bone1;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Transform bone2;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C70")]
		public Transform bone3;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6E10", Offset = "0xCC6E10")]
		public float maintainRotationWeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6E58", Offset = "0xCC6E58")]
		public float weight;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17CB")]
		private BoneMap boneMap1;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C80")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x38CACD0", Offset = "0x38CACD0", VA = "0x38CACD0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x38CAED4", Offset = "0x38CAED4", VA = "0x38CAED4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x38CB0E8", Offset = "0x38CB0E8", VA = "0x38CB0E8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x38CB780", Offset = "0x38CB780", VA = "0x38CB780")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x38CB8B0", Offset = "0x38CB8B0", VA = "0x38CB8B0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x38CBA2C", Offset = "0x38CBA2C", VA = "0x38CBA2C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x38CBAAC", Offset = "0x38CBAAC", VA = "0x38CBAAC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x38CBC44", Offset = "0x38CBC44", VA = "0x38CBC44")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x38CBE14", Offset = "0x38CBE14", VA = "0x38CBE14", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x38CC378", Offset = "0x38CC378", VA = "0x38CC378")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x38CC524", Offset = "0x38CC524", VA = "0x38CC524")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121C90")]
		public Transform[] spineBones;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftThighBone;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17DB")]
		public Transform rightThighBone;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6EA0", Offset = "0xCC6EA0")]
		public int iterations;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121CA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6EEC", Offset = "0xCC6EEC")]
		public float twistWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int rootNodeIndex;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap[] spine;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17E3")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneMap leftThigh;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121CB0")]
		private BoneMap rightThigh;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool useFABRIK;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x38CC8D0", Offset = "0x38CC8D0", VA = "0x38CC8D0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x38CD30C", Offset = "0x38CD30C", VA = "0x38CD30C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x38CD488", Offset = "0x38CD488", VA = "0x38CD488")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x38CD660", Offset = "0x38CD660", VA = "0x38CD660")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x38CD6F8", Offset = "0x38CD6F8", VA = "0x38CD6F8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x38CD7DC", Offset = "0x38CD7DC", VA = "0x38CD7DC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x38CD99C", Offset = "0x38CD99C", VA = "0x38CD99C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x38CE988", Offset = "0x38CE988", VA = "0x38CE988")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x38CEA60", Offset = "0x38CEA60", VA = "0x38CEA60")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x38CF074", Offset = "0x38CF074", VA = "0x38CF074")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x38CF9A4", Offset = "0x38CF9A4", VA = "0x38CF9A4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x38CFC74", Offset = "0x38CFC74", VA = "0x38CFC74")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x38CFF34", Offset = "0x38CFF34", VA = "0x38CFF34")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Transform transform;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121CD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCA788", Offset = "0xCCA788")]
			public float weight;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17FB")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x38D48BC", Offset = "0x38D48BC", VA = "0x38D48BC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x38D4980", Offset = "0x38D4980", VA = "0x38D4980")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x38D4C5C", Offset = "0x38D4C5C", VA = "0x38D4C5C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x38D4CCC", Offset = "0x38D4CCC", VA = "0x38D4CCC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x38D4D3C", Offset = "0x38D4D3C", VA = "0x38D4D3C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x38D4E00", Offset = "0x38D4E00", VA = "0x38D4E00")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x38D4044", Offset = "0x38D4044", VA = "0x38D4044")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000126")]
		public class Bone : Point
		{
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float length;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121CE0")]
			public float sqrMag;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
				[Address(RVA = "0x38D2674", Offset = "0x38D2674", VA = "0x38D2674")]
				get
				{
					return null;
				}
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x38D28BC", Offset = "0x38D28BC", VA = "0x38D28BC")]
				set
				{
				}
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x38D29EC", Offset = "0x38D29EC", VA = "0x38D29EC")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x38D2F6C", Offset = "0x38D2F6C", VA = "0x38D2F6C")]
			public void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x38D3608", Offset = "0x38D3608", VA = "0x38D3608")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x38D3AC8", Offset = "0x38D3AC8", VA = "0x38D3AC8")]
			public Quaternion GetSolverSwing(Vector3 swingTarget, float weight = 1f)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x38D3EB4", Offset = "0x38D3EB4", VA = "0x38D3EB4")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x38D3F24", Offset = "0x38D3F24", VA = "0x38D3F24")]
			public Bone()
			{
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x38D4134", Offset = "0x38D4134", VA = "0x38D4134")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x38D426C", Offset = "0x38D426C", VA = "0x38D426C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000127")]
		public class Node : Point
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1803")]
			public float length;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121CF0")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 offset;

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x38D47E4", Offset = "0x38D47E4", VA = "0x38D47E4")]
			public Node()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x38D4814", Offset = "0x38D4814", VA = "0x38D4814")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x38D485C", Offset = "0x38D485C", VA = "0x38D485C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC6F70", Offset = "0xCC6F70")]
		public float IKPositionWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC6FB8", Offset = "0xCC6FB8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121CC0")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool firstInitiation;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17F3")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000048")]
		public bool initiated
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x38D0F2C", Offset = "0x38D0F2C", VA = "0x38D0F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF0A0", Offset = "0xCCF0A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x38D0F70", Offset = "0x38D0F70", VA = "0x38D0F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF0DC", Offset = "0xCCF0DC")]
			private set
			{
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x38D0680", Offset = "0x38D0680", VA = "0x38D0680")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x38D0758", Offset = "0x38D0758", VA = "0x38D0758")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x38C6D08", Offset = "0x38C6D08", VA = "0x38C6D08")]
		public void Update()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x38D0D10", Offset = "0x38D0D10", VA = "0x38D0D10", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x38D0D50", Offset = "0x38D0D50", VA = "0x38D0D50")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x38D0DB0", Offset = "0x38D0DB0", VA = "0x38D0DB0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x38D0DE0", Offset = "0x38D0DE0", VA = "0x38D0DE0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x38D0EFC", Offset = "0x38D0EFC", VA = "0x38D0EFC")]
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
		[Address(RVA = "0x38D0FBC", Offset = "0x38D0FBC", VA = "0x38D0FBC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x38D101C", Offset = "0x38D101C", VA = "0x38D101C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x38D1310", Offset = "0x38D1310", VA = "0x38D1310")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x38D14A4", Offset = "0x38D14A4", VA = "0x38D14A4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x38D1FD4", Offset = "0x38D1FD4", VA = "0x38D1FD4")]
		public static void SolverRotateBonesAroundPoint(Bone[] bones, int index, Vector3 point, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x38D2478", Offset = "0x38D2478", VA = "0x38D2478")]
		public static void SolverRotate(Bone[] bones, int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x38D2618", Offset = "0x38D2618", VA = "0x38D2618")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x180B")]
		public Vector3 poleAxis;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Vector3 polePosition;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7050", Offset = "0xCC7050")]
		public float poleWeight;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform poleTarget;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7098", Offset = "0xCC7098")]
		public float clampWeight;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC70E0", Offset = "0xCC70E0")]
		public int clampSmoothing;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1813")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float step;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D10")]
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
			[Address(RVA = "0x38D5154", Offset = "0x38D5154", VA = "0x38D5154")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x38D5290", Offset = "0x38D5290", VA = "0x38D5290")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		protected override int minBones
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x38D72F4", Offset = "0x38D72F4", VA = "0x38D72F4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x38D810C", Offset = "0x38D810C", VA = "0x38D810C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x38D4FC0", Offset = "0x38D4FC0", VA = "0x38D4FC0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x38D53CC", Offset = "0x38D53CC", VA = "0x38D53CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x38D5958", Offset = "0x38D5958", VA = "0x38D5958", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x38D6FEC", Offset = "0x38D6FEC", VA = "0x38D6FEC")]
		private void Solve()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x38D6714", Offset = "0x38D6714", VA = "0x38D6714")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x38D7310", Offset = "0x38D7310", VA = "0x38D7310")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x38D8238", Offset = "0x38D8238", VA = "0x38D8238")]
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
		[Address(RVA = "0x38D8440", Offset = "0x38D8440", VA = "0x38D8440")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x38D865C", Offset = "0x38D865C", VA = "0x38D865C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x38D9324", Offset = "0x38D9324", VA = "0x38D9324", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x38DA418", Offset = "0x38DA418", VA = "0x38DA418")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x38DB500", Offset = "0x38DB500", VA = "0x38DB500")]
		public static void SolveVirtual(Bone[] bones, Vector3 targetPosition, float weight)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x38DBAE0", Offset = "0x38DBAE0", VA = "0x38DBAE0")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181B")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool[] limitedBones;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D20")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x38DE4F4", Offset = "0x38DE4F4", VA = "0x38DE4F4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x38DBB10", Offset = "0x38DBB10", VA = "0x38DBB10")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x38DCBC8", Offset = "0x38DCBC8", VA = "0x38DCBC8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x38DCE50", Offset = "0x38DCE50", VA = "0x38DCE50", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x38DCF7C", Offset = "0x38DCF7C", VA = "0x38DCF7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x38DDB44", Offset = "0x38DDB44", VA = "0x38DDB44", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x38DE518", Offset = "0x38DE518", VA = "0x38DE518")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x38DBC2C", Offset = "0x38DBC2C", VA = "0x38DBC2C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x38DCDB4", Offset = "0x38DCDB4", VA = "0x38DCDB4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x38DE404", Offset = "0x38DE404", VA = "0x38DE404")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x38DC69C", Offset = "0x38DC69C", VA = "0x38DC69C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x38DFC2C", Offset = "0x38DFC2C", VA = "0x38DFC2C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x38DFE30", Offset = "0x38DFE30", VA = "0x38DFE30")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x38E0098", Offset = "0x38E0098", VA = "0x38E0098")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x38E02CC", Offset = "0x38E02CC", VA = "0x38E02CC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x38DD614", Offset = "0x38DD614", VA = "0x38DD614")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x38DD8B4", Offset = "0x38DD8B4", VA = "0x38DD8B4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x38E06BC", Offset = "0x38E06BC", VA = "0x38E06BC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x38DECE8", Offset = "0x38DECE8", VA = "0x38DECE8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x38DCCE8", Offset = "0x38DCCE8", VA = "0x38DCCE8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x38E1814", Offset = "0x38E1814", VA = "0x38E1814")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x38E09F8", Offset = "0x38E09F8", VA = "0x38E09F8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x38DE774", Offset = "0x38DE774", VA = "0x38DE774")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x38DEA7C", Offset = "0x38DEA7C", VA = "0x38DEA7C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x38E1AD4", Offset = "0x38E1AD4", VA = "0x38E1AD4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7128", Offset = "0xCC7128")]
		public float rootPin;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1823")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool[] isRoot;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D30")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x38E1BA8", Offset = "0x38E1BA8", VA = "0x38E1BA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x38E3078", Offset = "0x38E3078", VA = "0x38E3078", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x38E31C8", Offset = "0x38E31C8", VA = "0x38E31C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x38E3318", Offset = "0x38E3318", VA = "0x38E3318", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x38E3550", Offset = "0x38E3550", VA = "0x38E3550")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x38E3754", Offset = "0x38E3754", VA = "0x38E3754", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x38E4418", Offset = "0x38E4418", VA = "0x38E4418", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x38E4850", Offset = "0x38E4850", VA = "0x38E4850", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x38E4588", Offset = "0x38E4588", VA = "0x38E4588")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x38E3D74", Offset = "0x38E3D74", VA = "0x38E3D74")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x38E49C4", Offset = "0x38E49C4", VA = "0x38E49C4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7170", Offset = "0xCC7170")]
		public int iterations;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182B")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D40")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1833")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D50")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x38E4A7C", Offset = "0x38E4A7C", VA = "0x38E4A7C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x38E4C9C", Offset = "0x38E4C9C", VA = "0x38E4C9C")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x38E4D70", Offset = "0x38E4D70", VA = "0x38E4D70")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x38C8C6C", Offset = "0x38C8C6C", VA = "0x38C8C6C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x38C7494", Offset = "0x38C7494", VA = "0x38C7494")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x38E5040", Offset = "0x38E5040", VA = "0x38E5040", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x38E53BC", Offset = "0x38E53BC", VA = "0x38E53BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x38E5714", Offset = "0x38E5714", VA = "0x38E5714", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x38E5D14", Offset = "0x38E5D14", VA = "0x38E5D14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x38E5F20", Offset = "0x38E5F20", VA = "0x38E5F20", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x38E6160", Offset = "0x38E6160", VA = "0x38E6160", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x38E6504", Offset = "0x38E6504", VA = "0x38E6504", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x38E68F0", Offset = "0x38E68F0", VA = "0x38E68F0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x38E6F78", Offset = "0x38E6F78", VA = "0x38E6F78", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x38E77A4", Offset = "0x38E77A4", VA = "0x38E77A4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x38E7824", Offset = "0x38E7824", VA = "0x38E7824", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x38E7A9C", Offset = "0x38E7A9C", VA = "0x38E7A9C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D80")]
		public Transform rootNode;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC71B8", Offset = "0xCC71B8")]
		public float spineStiffness;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7200", Offset = "0xCC7200")]
		public float pullBodyVertical;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC724C", Offset = "0xCC724C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1853")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC7298", Offset = "0xCC7298")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 offset;

		[Token(Token = "0x1700004E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x38E7C08", Offset = "0x38E7C08", VA = "0x38E7C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x38E8008", Offset = "0x38E8008", VA = "0x38E8008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x38E8048", Offset = "0x38E8048", VA = "0x38E8048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x38E8088", Offset = "0x38E8088", VA = "0x38E8088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x38E80C8", Offset = "0x38E80C8", VA = "0x38E80C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x38E8108", Offset = "0x38E8108", VA = "0x38E8108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x38E8148", Offset = "0x38E8148", VA = "0x38E8148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x38E8188", Offset = "0x38E8188", VA = "0x38E8188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x38E81C8", Offset = "0x38E81C8", VA = "0x38E81C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x38E8208", Offset = "0x38E8208", VA = "0x38E8208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x38E8268", Offset = "0x38E8268", VA = "0x38E8268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x38E82C8", Offset = "0x38E82C8", VA = "0x38E82C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x38E8328", Offset = "0x38E8328", VA = "0x38E8328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x38E8388", Offset = "0x38E8388", VA = "0x38E8388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x38E83DC", Offset = "0x38E83DC", VA = "0x38E83DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x38E843C", Offset = "0x38E843C", VA = "0x38E843C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x38E849C", Offset = "0x38E849C", VA = "0x38E849C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x38E84FC", Offset = "0x38E84FC", VA = "0x38E84FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x38ED344", Offset = "0x38ED344", VA = "0x38ED344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF118", Offset = "0xCCF118")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x38ED384", Offset = "0x38ED384", VA = "0x38ED384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF154", Offset = "0xCCF154")]
			private set
			{
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x38E8550", Offset = "0x38E8550", VA = "0x38E8550")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x38E87C4", Offset = "0x38E87C4", VA = "0x38E87C4")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x38E85F4", Offset = "0x38E85F4", VA = "0x38E85F4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x38E8960", Offset = "0x38E8960", VA = "0x38E8960")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x38E7C48", Offset = "0x38E7C48", VA = "0x38E7C48")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x38E8D20", Offset = "0x38E8D20", VA = "0x38E8D20")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x38E8EF0", Offset = "0x38E8EF0", VA = "0x38E8EF0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x38E90B4", Offset = "0x38E90B4", VA = "0x38E90B4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x38E9410", Offset = "0x38E9410", VA = "0x38E9410")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x38E9440", Offset = "0x38E9440", VA = "0x38E9440")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x38E9494", Offset = "0x38E9494", VA = "0x38E9494")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x38E96B4", Offset = "0x38E96B4", VA = "0x38E96B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x38E9BFC", Offset = "0x38E9BFC", VA = "0x38E9BFC")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x38EC104", Offset = "0x38EC104", VA = "0x38EC104")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x38ECCCC", Offset = "0x38ECCCC", VA = "0x38ECCCC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x38ECDD8", Offset = "0x38ECDD8", VA = "0x38ECDD8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x38EC8C4", Offset = "0x38EC8C4", VA = "0x38EC8C4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x38ECAC8", Offset = "0x38ECAC8", VA = "0x38ECAC8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x38ED3E4", Offset = "0x38ED3E4", VA = "0x38ED3E4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x38ED5E0", Offset = "0x38ED5E0", VA = "0x38ED5E0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x38ED930", Offset = "0x38ED930", VA = "0x38ED930")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x38EDCF4", Offset = "0x38EDCF4", VA = "0x38EDCF4")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x38EE098", Offset = "0x38EE098", VA = "0x38EE098")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x38EE528", Offset = "0x38EE528", VA = "0x38EE528", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x38EECB4", Offset = "0x38EECB4", VA = "0x38EECB4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x38EEE7C", Offset = "0x38EEE7C", VA = "0x38EEE7C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121D90")]
		public Transform target;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float tolerance;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int maxIterations;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useRotationLimits;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x185B")]
		public bool XY;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Bone[] bones;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121DA0")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float chainLength;

		[Token(Token = "0x17000061")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x38F00C8", Offset = "0x38F00C8", VA = "0x38F00C8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x38F00E4", Offset = "0x38F00E4", VA = "0x38F00E4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x38F0108", Offset = "0x38F0108", VA = "0x38F0108", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x38F0154", Offset = "0x38F0154", VA = "0x38F0154", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000065")]
		protected float positionOffset
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x38DA2D0", Offset = "0x38DA2D0", VA = "0x38DA2D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x38EEED0", Offset = "0x38EEED0", VA = "0x38EEED0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x38EF25C", Offset = "0x38EF25C", VA = "0x38EF25C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x38EF4DC", Offset = "0x38EF4DC", VA = "0x38EF4DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x38EF5C0", Offset = "0x38EF5C0", VA = "0x38EF5C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x38EF6D8", Offset = "0x38EF6D8", VA = "0x38EF6D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x38EFE60", Offset = "0x38EFE60", VA = "0x38EFE60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x38EFEA8", Offset = "0x38EFEA8", VA = "0x38EFEA8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x38F012C", Offset = "0x38F012C", VA = "0x38F012C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x38F0140", Offset = "0x38F0140", VA = "0x38F0140", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x38D8774", Offset = "0x38D8774", VA = "0x38D8774")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x38D9B40", Offset = "0x38D9B40", VA = "0x38D9B40")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x38F03BC", Offset = "0x38F03BC", VA = "0x38F03BC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x38D8370", Offset = "0x38D8370", VA = "0x38D8370")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121DD0")]
			public Vector3 direction;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 axis;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float dot;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x38F3A50", Offset = "0x38F3A50", VA = "0x38F3A50")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1863")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC72D4", Offset = "0xCC72D4")]
		public float maintainRotationWeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC731C", Offset = "0xCC731C")]
		public float bendModifierWeight;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121DB0")]
		public Transform bendGoal;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x186B")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121DC0")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1873")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000066")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x38F39D4", Offset = "0x38F39D4", VA = "0x38F39D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x38F09E8", Offset = "0x38F09E8", VA = "0x38F09E8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x38F0AA8", Offset = "0x38F0AA8", VA = "0x38F0AA8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x38F0B54", Offset = "0x38F0B54", VA = "0x38F0B54", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x38F1794", Offset = "0x38F1794", VA = "0x38F1794", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x38F342C", Offset = "0x38F342C", VA = "0x38F342C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x38F368C", Offset = "0x38F368C", VA = "0x38F368C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x38F38E4", Offset = "0x38F38E4", VA = "0x38F38E4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x38F12FC", Offset = "0x38F12FC", VA = "0x38F12FC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x38F1A78", Offset = "0x38F1A78", VA = "0x38F1A78")]
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
				[Address(RVA = "0x38F8484", Offset = "0x38F8484", VA = "0x38F8484")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x38F94A4", Offset = "0x38F94A4", VA = "0x38F94A4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x38F66BC", Offset = "0x38F66BC", VA = "0x38F66BC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x38F7118", Offset = "0x38F7118", VA = "0x38F7118")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x38F8EBC", Offset = "0x38F8EBC", VA = "0x38F8EBC")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1883")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public LookAtBone head;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121DF0")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7364", Offset = "0xCC7364")]
		public float bodyWeight;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC73AC", Offset = "0xCC73AC")]
		public float headWeight;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC73F4", Offset = "0xCC73F4")]
		public float eyesWeight;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC743C", Offset = "0xCC743C")]
		public float clampWeight;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7484", Offset = "0xCC7484")]
		public float clampWeightHead;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC74CC", Offset = "0xCC74CC")]
		public float clampWeightEyes;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7514", Offset = "0xCC7514")]
		public int clampSmoothing;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1893")]
		private Vector3[] headForwards;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000067")]
		private bool spineIsValid
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x38F5064", Offset = "0x38F5064", VA = "0x38F5064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x38F5678", Offset = "0x38F5678", VA = "0x38F5678")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		private bool headIsValid
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x38F532C", Offset = "0x38F532C", VA = "0x38F532C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x38F56F4", Offset = "0x38F56F4", VA = "0x38F56F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x38F53B0", Offset = "0x38F53B0", VA = "0x38F53B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x38F5824", Offset = "0x38F5824", VA = "0x38F5824")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x38F3B10", Offset = "0x38F3B10", VA = "0x38F3B10")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x38F3C2C", Offset = "0x38F3C2C", VA = "0x38F3C2C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x38F3D7C", Offset = "0x38F3D7C", VA = "0x38F3D7C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x38F3EFC", Offset = "0x38F3EFC", VA = "0x38F3EFC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x38F40AC", Offset = "0x38F40AC", VA = "0x38F40AC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x38F42BC", Offset = "0x38F42BC", VA = "0x38F42BC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x38F44FC", Offset = "0x38F44FC", VA = "0x38F44FC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x38F47EC", Offset = "0x38F47EC", VA = "0x38F47EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x38F4B10", Offset = "0x38F4B10", VA = "0x38F4B10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x38F58A0", Offset = "0x38F58A0", VA = "0x38F58A0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x38F5E10", Offset = "0x38F5E10", VA = "0x38F5E10", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x38F6278", Offset = "0x38F6278", VA = "0x38F6278")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x38F6704", Offset = "0x38F6704", VA = "0x38F6704", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x38F7340", Offset = "0x38F7340", VA = "0x38F7340", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x38F7538", Offset = "0x38F7538", VA = "0x38F7538")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x38F7994", Offset = "0x38F7994", VA = "0x38F7994")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x38F7F64", Offset = "0x38F7F64", VA = "0x38F7F64")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x38F85C0", Offset = "0x38F85C0", VA = "0x38F85C0")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x38F63C0", Offset = "0x38F63C0", VA = "0x38F63C0")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x38F9140", Offset = "0x38F9140", VA = "0x38F9140")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x18A3")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x3207A14", Offset = "0x3207A14", VA = "0x3207A14")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x3207F28", Offset = "0x3207F28", VA = "0x3207F28")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x32080C4", Offset = "0x32080C4", VA = "0x32080C4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x3208200", Offset = "0x3208200", VA = "0x3208200")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E10")]
		public Transform target;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC755C", Offset = "0xCC755C")]
		public float IKRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 bendNormal;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x189B")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E20")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool directHierarchy;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x38F94D4", Offset = "0x38F94D4", VA = "0x38F94D4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x38F9950", Offset = "0x38F9950", VA = "0x38F9950")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x38F9CE8", Offset = "0x38F9CE8", VA = "0x38F9CE8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x38F9E18", Offset = "0x38F9E18", VA = "0x38F9E18")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x38F9F34", Offset = "0x38F9F34", VA = "0x38F9F34")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x38F9F7C", Offset = "0x38F9F7C", VA = "0x38F9F7C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x38F9FAC", Offset = "0x38F9FAC", VA = "0x38F9FAC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x38FA0F4", Offset = "0x38FA0F4", VA = "0x38FA0F4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x38FA3F0", Offset = "0x38FA3F0", VA = "0x38FA3F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x38FA478", Offset = "0x38FA478", VA = "0x38FA478", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x38FA500", Offset = "0x38FA500", VA = "0x38FA500", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x38FAC70", Offset = "0x38FAC70", VA = "0x38FAC70")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x38FAD60", Offset = "0x38FAD60", VA = "0x38FAD60")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x38FBBA0", Offset = "0x38FBBA0", VA = "0x38FBBA0")]
		public static void SolveVirtual(Bone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x38FC750", Offset = "0x38FC750", VA = "0x38FC750")]
		public static void SolveVirtualPositions(Bone bone1, Bone bone2, Bone bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x38FB710", Offset = "0x38FB710", VA = "0x38FB710")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x38FD11C", Offset = "0x38FD11C", VA = "0x38FD11C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x38FD590", Offset = "0x38FD590", VA = "0x38FD590")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x38FD408", Offset = "0x38FD408", VA = "0x38FD408")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x38FD81C", Offset = "0x38FD81C", VA = "0x38FD81C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x38FEF68", Offset = "0x38FEF68", VA = "0x38FEF68", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x38FEF7C", Offset = "0x38FEF7C", VA = "0x38FEF7C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x38FEF90", Offset = "0x38FEF90", VA = "0x38FEF90", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x38FE8FC", Offset = "0x38FE8FC", VA = "0x38FE8FC")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x38F3764", Offset = "0x38F3764", VA = "0x38F3764")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC75A4", Offset = "0xCC75A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC75A4", Offset = "0xCC75A4")]
		public float weight;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7640", Offset = "0xCC7640")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC7640", Offset = "0xCC7640")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC76DC", Offset = "0xCC76DC")]
		public Transform parent;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7740", Offset = "0xCC7740")]
		public Transform child;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC77A4", Offset = "0xCC77A4")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18AB")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7808", Offset = "0xCC7808")]
		public Vector3 axis;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E40")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x3232830", Offset = "0x3232830", VA = "0x3232830")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x3233008", Offset = "0x3233008", VA = "0x3233008")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x3233334", Offset = "0x3233334", VA = "0x3233334")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x3233364", Offset = "0x3233364", VA = "0x3233364")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC786C", Offset = "0xCC786C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC78A8", Offset = "0xCC78A8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC78E4", Offset = "0xCC78E4")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18B3")]
		private Poser poser;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private IKEffector effector;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E50")]
		private float timer;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float length;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weight;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float fadeInSpeed;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18BB")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E60")]
		private float defaultPull;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultReach;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPush;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPushParent;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C3")]
		private float resetTimer;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E70")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pullUsed;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool reachUsed;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pushUsed;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18CB")]
		private bool pushParentUsed;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool pickedUp;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E80")]
		private bool defaults;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18D3")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121E90")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform target;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<bool> triggered;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18DB")]
		private bool started;

		[Token(Token = "0x1700006D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x3209348", Offset = "0x3209348", VA = "0x3209348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF190", Offset = "0xCCF190")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x3209378", Offset = "0x3209378", VA = "0x3209378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF1CC", Offset = "0xCCF1CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isPaused
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x32093B0", Offset = "0x32093B0", VA = "0x32093B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF208", Offset = "0xCCF208")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x32093F4", Offset = "0x32093F4", VA = "0x32093F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF244", Offset = "0xCCF244")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x3209440", Offset = "0x3209440", VA = "0x3209440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF280", Offset = "0xCCF280")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x3209470", Offset = "0x3209470", VA = "0x3209470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF2BC", Offset = "0xCCF2BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool inInteraction
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x32094A8", Offset = "0x32094A8", VA = "0x32094A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public float progress
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x320FF70", Offset = "0x320FF70", VA = "0x320FF70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x32095C8", Offset = "0x32095C8", VA = "0x32095C8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x320969C", Offset = "0x320969C", VA = "0x320969C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x3209818", Offset = "0x3209818", VA = "0x3209818")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x3209C14", Offset = "0x3209C14", VA = "0x3209C14")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x320A7E0", Offset = "0x320A7E0", VA = "0x320A7E0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x320AE2C", Offset = "0x320AE2C", VA = "0x320AE2C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x320AF60", Offset = "0x320AF60", VA = "0x320AF60")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x320CB94", Offset = "0x320CB94", VA = "0x320CB94")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x320E680", Offset = "0x320E680", VA = "0x320E680")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x320EEEC", Offset = "0x320EEEC", VA = "0x320EEEC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x320FB60", Offset = "0x320FB60", VA = "0x320FB60")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x32107DC", Offset = "0x32107DC", VA = "0x32107DC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7920", Offset = "0xCC7920")]
		public LookAtIK ik;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121EA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7984", Offset = "0xCC7984")]
		public float lerpSpeed;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC79E8", Offset = "0xCC79E8")]
		public float weightSpeed;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18E3")]
		private float stopLookTime;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float weight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121EB0")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x3210DCC", Offset = "0x3210DCC", VA = "0x3210DCC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x321117C", Offset = "0x321117C", VA = "0x321117C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x3212138", Offset = "0x3212138", VA = "0x3212138")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x3212460", Offset = "0x3212460", VA = "0x3212460")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x32126AC", Offset = "0x32126AC", VA = "0x32126AC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC070C", Offset = "0xCC070C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC070C", Offset = "0xCC070C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class InteractionEvent
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18F3")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA7D0", Offset = "0xCCA7D0")]
			public float time;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA834", Offset = "0xCCA834")]
			public bool pause;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121ED0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA898", Offset = "0xCCA898")]
			public bool pickUp;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA8FC", Offset = "0xCCA8FC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA960", Offset = "0xCCA960")]
			public Message[] messages;

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x3210030", Offset = "0x3210030", VA = "0x3210030")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x3215774", Offset = "0x3215774", VA = "0x3215774")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCA9C4", Offset = "0xCCA9C4")]
			public string function;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18FB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAA28", Offset = "0xCCAA28")]
			public GameObject recipient;

			[Token(Token = "0x4000726")]
			private const string empty = "";

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x321556C", Offset = "0x321556C", VA = "0x321556C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x32157A4", Offset = "0x32157A4", VA = "0x32157A4")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121EE0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAA8C", Offset = "0xCCAA8C")]
			public Animator animator;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAAF0", Offset = "0xCCAAF0")]
			public Animation animation;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAB54", Offset = "0xCCAB54")]
			public string animationState;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCABB8", Offset = "0xCCABB8")]
			public float crossfadeTime;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1903")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAC1C", Offset = "0xCCAC1C")]
			public int layer;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAC80", Offset = "0xCCAC80")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400072D")]
			private const string empty = "";

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x3214FB0", Offset = "0x3214FB0", VA = "0x3214FB0")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x32151F4", Offset = "0x32151F4", VA = "0x32151F4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x3215370", Offset = "0x3215370", VA = "0x3215370")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x3215524", Offset = "0x3215524", VA = "0x3215524")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCACE4", Offset = "0xCCACE4")]
			public Type type;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAD48", Offset = "0xCCAD48")]
			public AnimationCurve curve;

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x321381C", Offset = "0x321381C", VA = "0x321381C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x3215818", Offset = "0x3215818", VA = "0x3215818")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCADAC", Offset = "0xCCADAC")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x191B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAE10", Offset = "0xCCAE10")]
			public float multiplier;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAE74", Offset = "0xCCAE74")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x3214C4C", Offset = "0x3214C4C", VA = "0x3214C4C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x32157D4", Offset = "0x32157D4", VA = "0x32157D4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7A88", Offset = "0xCC7A88")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7AEC", Offset = "0xCC7AEC")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7B50", Offset = "0xCC7B50")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18EB")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121EC0")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC7BB4", Offset = "0xCC7BB4")]
		private float <length>k__BackingField;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC7BF0", Offset = "0xCC7BF0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000072")]
		public float length
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x3212A20", Offset = "0x3212A20", VA = "0x3212A20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF550", Offset = "0xCCF550")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x3212A50", Offset = "0x3212A50", VA = "0x3212A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF58C", Offset = "0xCCF58C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x3212A88", Offset = "0x3212A88", VA = "0x3212A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF5C8", Offset = "0xCCF5C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x3212AB8", Offset = "0x3212AB8", VA = "0x3212AB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF604", Offset = "0xCCF604")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x3212FE8", Offset = "0x3212FE8", VA = "0x3212FE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x3210564", Offset = "0x3210564", VA = "0x3210564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x3212708", Offset = "0x3212708", VA = "0x3212708")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF2F8", Offset = "0xCCF2F8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x321278C", Offset = "0x321278C", VA = "0x321278C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF35C", Offset = "0xCCF35C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x3212810", Offset = "0x3212810", VA = "0x3212810")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF3C0", Offset = "0xCCF3C0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x3212894", Offset = "0x3212894", VA = "0x3212894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF424", Offset = "0xCCF424")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x3212918", Offset = "0x3212918", VA = "0x3212918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF488", Offset = "0xCCF488")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x321299C", Offset = "0x321299C", VA = "0x321299C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF4EC", Offset = "0xCCF4EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x3212AF0", Offset = "0x3212AF0", VA = "0x3212AF0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x3213134", Offset = "0x3213134", VA = "0x3213134")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x320BE2C", Offset = "0x320BE2C", VA = "0x320BE2C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x321350C", Offset = "0x321350C", VA = "0x321350C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x320BAE4", Offset = "0x320BAE4", VA = "0x320BAE4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x320BDEC", Offset = "0x320BDEC", VA = "0x320BDEC")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x320DC2C", Offset = "0x320DC2C", VA = "0x320DC2C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x320F3F0", Offset = "0x320F3F0", VA = "0x320F3F0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x3214CC0", Offset = "0x3214CC0", VA = "0x3214CC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x321387C", Offset = "0x321387C", VA = "0x321387C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x321353C", Offset = "0x321353C", VA = "0x321353C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x3214B34", Offset = "0x3214B34", VA = "0x3214B34")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x3214CF0", Offset = "0x3214CF0", VA = "0x3214CF0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x3214E08", Offset = "0x3214E08", VA = "0x3214E08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF640", Offset = "0xCCF640")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x3214E8C", Offset = "0x3214E8C", VA = "0x3214E8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF6A4", Offset = "0xCCF6A4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x3214F10", Offset = "0x3214F10", VA = "0x3214F10")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC07B8", Offset = "0xCC07B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC07B8", Offset = "0xCC07B8")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000134")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7C2C", Offset = "0xCC7C2C")]
		public string targetTag;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7C90", Offset = "0xCC7C90")]
		public float fadeInTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7CF4", Offset = "0xCC7CF4")]
		public float speed;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7D58", Offset = "0xCC7D58")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1923")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCC7DBC", Offset = "0xCC7DBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7DBC", Offset = "0xCC7DBC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCC7DBC", Offset = "0xCC7DBC")]
		public Collider characterCollider;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7EB0", Offset = "0xCC7EB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCC7EB0", Offset = "0xCC7EB0")]
		public Transform FPSCamera;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7F5C", Offset = "0xCC7F5C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC7FC0", Offset = "0xCC7FC0")]
		public float camRaycastDistance;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC8024", Offset = "0xCC8024")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192B")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F40")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1933")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F50")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCC8060", Offset = "0xCC8060")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8060", Offset = "0xCC8060")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC810C", Offset = "0xCC810C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x193B")]
		private Collider lastCollider;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Collider c;

		[Token(Token = "0x17000076")]
		public bool inInteraction
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x3215B60", Offset = "0x3215B60", VA = "0x3215B60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x321A80C", Offset = "0x321A80C", VA = "0x321A80C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x321A83C", Offset = "0x321A83C", VA = "0x321A83C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF960", Offset = "0xCCF960")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x321A86C", Offset = "0x321A86C", VA = "0x321A86C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCF99C", Offset = "0xCCF99C")]
			private set
			{
			}
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x3215848", Offset = "0x3215848", VA = "0x3215848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF708", Offset = "0xCCF708")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x32158CC", Offset = "0x32158CC", VA = "0x32158CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF76C", Offset = "0xCCF76C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x3215950", Offset = "0x3215950", VA = "0x3215950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF7D0", Offset = "0xCCF7D0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x32159D4", Offset = "0x32159D4", VA = "0x32159D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF834", Offset = "0xCCF834")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x3215A58", Offset = "0x3215A58", VA = "0x3215A58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF898", Offset = "0xCCF898")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x3215ADC", Offset = "0x3215ADC", VA = "0x3215ADC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF8FC", Offset = "0xCCF8FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x3215F80", Offset = "0x3215F80", VA = "0x3215F80")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x321620C", Offset = "0x321620C", VA = "0x321620C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x3216460", Offset = "0x3216460", VA = "0x3216460")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x3216634", Offset = "0x3216634", VA = "0x3216634")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x3216904", Offset = "0x3216904", VA = "0x3216904")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x3216C30", Offset = "0x3216C30", VA = "0x3216C30")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x3216E08", Offset = "0x3216E08", VA = "0x3216E08")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x3216FE0", Offset = "0x3216FE0", VA = "0x3216FE0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x32171B8", Offset = "0x32171B8", VA = "0x32171B8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x32172D4", Offset = "0x32172D4", VA = "0x32172D4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x32173F0", Offset = "0x32173F0", VA = "0x32173F0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x32174D8", Offset = "0x32174D8", VA = "0x32174D8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x321768C", Offset = "0x321768C", VA = "0x321768C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x3217838", Offset = "0x3217838", VA = "0x3217838")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x3217A5C", Offset = "0x3217A5C", VA = "0x3217A5C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x3218218", Offset = "0x3218218", VA = "0x3218218")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x32187A8", Offset = "0x32187A8", VA = "0x32187A8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x3218F24", Offset = "0x3218F24", VA = "0x3218F24")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x32195A8", Offset = "0x32195A8", VA = "0x32195A8")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x3219680", Offset = "0x3219680", VA = "0x3219680")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x32197F4", Offset = "0x32197F4", VA = "0x32197F4")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x3219A58", Offset = "0x3219A58", VA = "0x3219A58")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x3219DD4", Offset = "0x3219DD4", VA = "0x3219DD4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x321A5C8", Offset = "0x321A5C8", VA = "0x321A5C8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x321914C", Offset = "0x321914C", VA = "0x321914C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x321A8A4", Offset = "0x321A8A4", VA = "0x321A8A4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x321B764", Offset = "0x321B764", VA = "0x321B764")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x321B7B8", Offset = "0x321B7B8", VA = "0x321B7B8")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x321B80C", Offset = "0x321B80C", VA = "0x321B80C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x321B860", Offset = "0x321B860", VA = "0x321B860")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x321B948", Offset = "0x321B948", VA = "0x321B948")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x321BB44", Offset = "0x321BB44", VA = "0x321BB44")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x321BCE8", Offset = "0x321BCE8", VA = "0x321BCE8")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x321C524", Offset = "0x321C524", VA = "0x321C524")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x321C754", Offset = "0x321C754", VA = "0x321C754")]
		private void Update()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x321CC20", Offset = "0x321CC20", VA = "0x321CC20")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x321B05C", Offset = "0x321B05C", VA = "0x321B05C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x321CE3C", Offset = "0x321CE3C", VA = "0x321CE3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x321D124", Offset = "0x321D124", VA = "0x321D124")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x321D28C", Offset = "0x321D28C", VA = "0x321D28C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x321D4B0", Offset = "0x321D4B0", VA = "0x321D4B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x3215D38", Offset = "0x3215D38", VA = "0x3215D38")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x3217F7C", Offset = "0x3217F7C", VA = "0x3217F7C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x321D974", Offset = "0x321D974", VA = "0x321D974")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCF9D8", Offset = "0xCCF9D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x321D9F8", Offset = "0x321D9F8", VA = "0x321D9F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFA3C", Offset = "0xCCFA3C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x321DA7C", Offset = "0x321DA7C", VA = "0x321DA7C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0864", Offset = "0xCC0864")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0864", Offset = "0xCC0864")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class Multiplier
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAED8", Offset = "0xCCAED8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAF3C", Offset = "0xCCAF3C")]
			public float multiplier;

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x321EAA0", Offset = "0x321EAA0", VA = "0x321EAA0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8170", Offset = "0xCC8170")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC81D4", Offset = "0xCC81D4")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8238", Offset = "0xCC8238")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC829C", Offset = "0xCC829C")]
		public Transform pivot;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1943")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8300", Offset = "0xCC8300")]
		public Vector3 twistAxis;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8364", Offset = "0xCC8364")]
		public float twistWeight;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC83C8", Offset = "0xCC83C8")]
		public float swingWeight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC842C", Offset = "0xCC842C")]
		public bool rotateOnce;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lastPivot;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x321E234", Offset = "0x321E234", VA = "0x321E234")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFAA0", Offset = "0xCCFAA0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x321E2B8", Offset = "0x321E2B8", VA = "0x321E2B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFB04", Offset = "0xCCFB04")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x321E33C", Offset = "0x321E33C", VA = "0x321E33C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFB68", Offset = "0xCCFB68")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x321E3C0", Offset = "0x321E3C0", VA = "0x321E3C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFBCC", Offset = "0xCCFBCC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x321E444", Offset = "0x321E444", VA = "0x321E444")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFC30", Offset = "0xCCFC30")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x321E4C8", Offset = "0x321E4C8", VA = "0x321E4C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFC94", Offset = "0xCCFC94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x32136B8", Offset = "0x32136B8", VA = "0x32136B8")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x32106B0", Offset = "0x32106B0", VA = "0x32106B0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x320C060", Offset = "0x320C060", VA = "0x320C060")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x321E890", Offset = "0x321E890", VA = "0x321E890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFCF8", Offset = "0xCCFCF8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x321E914", Offset = "0x321E914", VA = "0x321E914")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFD5C", Offset = "0xCCFD5C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x321E998", Offset = "0x321E998", VA = "0x321E998")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0910", Offset = "0xCC0910")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0910", Offset = "0xCC0910")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCAFA0", Offset = "0xCCAFA0")]
			public bool use;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB004", Offset = "0xCCB004")]
			public Vector2 offset;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB068", Offset = "0xCCB068")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCB068", Offset = "0xCCB068")]
			public float angleOffset;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1953")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB108", Offset = "0xCCB108")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCB108", Offset = "0xCCB108")]
			public float maxAngle;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB1A4", Offset = "0xCCB1A4")]
			public float radius;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121F90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB208", Offset = "0xCCB208")]
			public bool orbit;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB26C", Offset = "0xCCB26C")]
			public bool fixYAxis;

			[Token(Token = "0x170000D1")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600088F")]
				[Address(RVA = "0x321FBAC", Offset = "0x321FBAC", VA = "0x321FBAC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x321FC5C", Offset = "0x321FC5C", VA = "0x321FC5C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x321FE0C", Offset = "0x321FE0C", VA = "0x321FE0C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x3220F2C", Offset = "0x3220F2C", VA = "0x3220F2C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB2D0", Offset = "0xCCB2D0")]
			public Collider lookAtTarget;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB334", Offset = "0xCCB334")]
			public Vector3 direction;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x195B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB398", Offset = "0xCCB398")]
			public float maxDistance;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB3FC", Offset = "0xCCB3FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCB3FC", Offset = "0xCCB3FC")]
			public float maxAngle;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121FA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB498", Offset = "0xCCB498")]
			public bool fixYAxis;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x321EFF0", Offset = "0x321EFF0", VA = "0x321EFF0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x321F3FC", Offset = "0x321F3FC", VA = "0x321F3FC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x321FA7C", Offset = "0x321FA7C", VA = "0x321FA7C")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x4121FB0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC66C", Offset = "0xCCC66C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC6D0", Offset = "0xCCC6D0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000947")]
				[Address(RVA = "0x3220FCC", Offset = "0x3220FCC", VA = "0x3220FCC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB5B4", Offset = "0xCCB5B4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1963")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB618", Offset = "0xCCB618")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB67C", Offset = "0xCCB67C")]
			public Interaction[] interactions;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x321EC70", Offset = "0x321EC70", VA = "0x321EC70")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x3220F88", Offset = "0x3220F88", VA = "0x3220F88")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121F80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8490", Offset = "0xCC8490")]
		public Range[] ranges;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x321EAD0", Offset = "0x321EAD0", VA = "0x321EAD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFDC0", Offset = "0xCCFDC0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x321EB54", Offset = "0x321EB54", VA = "0x321EB54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFE24", Offset = "0xCCFE24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x321EBD8", Offset = "0x321EBD8", VA = "0x321EBD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFE88", Offset = "0xCCFE88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x321EC5C", Offset = "0x321EC5C", VA = "0x321EC5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x321C160", Offset = "0x321C160", VA = "0x321C160")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x321EF50", Offset = "0x321EF50", VA = "0x321EF50")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x196B")]
			public Transform target;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4121FC0")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x33C72C0", Offset = "0x33C72C0", VA = "0x33C72C0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x33C7414", Offset = "0x33C7414", VA = "0x33C7414")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x33C75BC", Offset = "0x33C75BC", VA = "0x33C75BC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x33C7960", Offset = "0x33C7960", VA = "0x33C7960")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Map[] maps;

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x33C6C90", Offset = "0x33C6C90", VA = "0x33C6C90", Slot = "4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCCFEEC", Offset = "0xCCFEEC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x33C7330", Offset = "0x33C7330", VA = "0x33C7330", Slot = "5")]
		public override void StoreDefaultState()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x33C74D8", Offset = "0x33C74D8", VA = "0x33C74D8", Slot = "6")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x33C7158", Offset = "0x33C7158", VA = "0x33C7158")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x33C7680", Offset = "0x33C7680", VA = "0x33C7680")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x33C7C64", Offset = "0x33C7C64", VA = "0x33C7C64")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1973")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x33DB45C", Offset = "0x33DB45C", VA = "0x33DB45C", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x33DB4FC", Offset = "0x33DB4FC", VA = "0x33DB4FC", Slot = "5")]
		public override void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x33DB770", Offset = "0x33DB770", VA = "0x33DB770", Slot = "6")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x33DB938", Offset = "0x33DB938", VA = "0x33DB938", Slot = "4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x33DBAD8", Offset = "0x33DBAD8", VA = "0x33DBAD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x33DC258", Offset = "0x33DC258", VA = "0x33DC258")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class Poser : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121FD0")]
		public Transform poseRoot;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC84F4", Offset = "0xCC84F4")]
		public float weight;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC853C", Offset = "0xCC853C")]
		public float localRotationWeight;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC8584", Offset = "0xCC8584")]
		public float localPositionWeight;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x197B")]
		public bool fixTransforms;

		[Token(Token = "0x6000585")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000586")]
		public abstract void StoreDefaultState();

		[Token(Token = "0x6000587")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x322362C", Offset = "0x322362C", VA = "0x322362C", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x322365C", Offset = "0x322365C", VA = "0x322365C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x32236A8", Offset = "0x32236A8", VA = "0x32236A8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCC09BC", Offset = "0xCC09BC")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public class Rigidbone
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody r;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1993")]
			public Transform t;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Collider collider;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122010")]
			public Joint joint;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody c;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool updateAnchor;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x199B")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float deltaTime;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122020")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion lastRotation;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x32242C4", Offset = "0x32242C4", VA = "0x32242C4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x322607C", Offset = "0x322607C", VA = "0x322607C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x3225B88", Offset = "0x3225B88", VA = "0x3225B88")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x19A3")]
			public Quaternion localRotation;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x32245C8", Offset = "0x32245C8", VA = "0x32245C8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x322645C", Offset = "0x322645C", VA = "0x322645C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x3226398", Offset = "0x3226398", VA = "0x3226398")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0F74", Offset = "0xCC0F74")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122030")]
			private object <>2__current;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x32273EC", Offset = "0x32273EC", VA = "0x32273EC", Slot = "4")]
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
				[Address(RVA = "0x32274BC", Offset = "0x32274BC", VA = "0x32274BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x32246B0", Offset = "0x32246B0", VA = "0x32246B0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x3226B84", Offset = "0x3226B84", VA = "0x3226B84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x3226B98", Offset = "0x3226B98", VA = "0x3226B98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x322741C", Offset = "0x322741C", VA = "0x322741C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC85CC", Offset = "0xCC85CC")]
		public IK ik;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121FE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8630", Offset = "0xCC8630")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8694", Offset = "0xCC8694")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC86F8", Offset = "0xCC86F8")]
		public float applyVelocity;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC875C", Offset = "0xCC875C")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1983")]
		private Animator animator;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4121FF0")]
		private Child[] children;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198B")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float ragdollWeight;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122000")]
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
			[Address(RVA = "0x3223788", Offset = "0x3223788", VA = "0x3223788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		private bool ikUsed
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x32250BC", Offset = "0x32250BC", VA = "0x32250BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x3223714", Offset = "0x3223714", VA = "0x3223714")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x32238BC", Offset = "0x32238BC", VA = "0x32238BC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x3223AFC", Offset = "0x3223AFC", VA = "0x3223AFC")]
		public void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x3223A40", Offset = "0x3223A40", VA = "0x3223A40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCCFF50", Offset = "0xCCFF50")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x32246F8", Offset = "0x32246F8", VA = "0x32246F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x3224D8C", Offset = "0x3224D8C", VA = "0x3224D8C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x3224F24", Offset = "0x3224F24", VA = "0x3224F24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x32254C0", Offset = "0x32254C0", VA = "0x32254C0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x3225044", Offset = "0x3225044", VA = "0x3225044")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x3225438", Offset = "0x3225438", VA = "0x3225438")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x3225610", Offset = "0x3225610", VA = "0x3225610")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x3225518", Offset = "0x3225518", VA = "0x3225518")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x3223948", Offset = "0x3223948", VA = "0x3223948")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x3224E1C", Offset = "0x3224E1C", VA = "0x3224E1C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x322680C", Offset = "0x322680C", VA = "0x322680C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x32269FC", Offset = "0x32269FC", VA = "0x32269FC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x19AB")]
		private bool initiated;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool applicationQuit;

		[Token(Token = "0x1700007B")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x322A8C4", Offset = "0x322A8C4", VA = "0x322A8C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x322A984", Offset = "0x322A984", VA = "0x322A984")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x322A1E8", Offset = "0x322A1E8", VA = "0x322A1E8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x322A260", Offset = "0x322A260", VA = "0x322A260")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x322A754", Offset = "0x322A754", VA = "0x322A754")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x322A83C", Offset = "0x322A83C", VA = "0x322A83C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005A3")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x322A5B4", Offset = "0x322A5B4", VA = "0x322A5B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x322AAAC", Offset = "0x322AAAC", VA = "0x322AAAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x322AADC", Offset = "0x322AADC", VA = "0x322AADC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x322AB40", Offset = "0x322AB40", VA = "0x322AB40")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x322AD24", Offset = "0x322AD24", VA = "0x322AD24")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x322B21C", Offset = "0x322B21C", VA = "0x322B21C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x322B37C", Offset = "0x322B37C", VA = "0x322B37C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0A6C", Offset = "0xCC0A6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0A6C", Offset = "0xCC0A6C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122040")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC87FC", Offset = "0xCC87FC")]
		public float limit;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC8844", Offset = "0xCC8844")]
		public float twistLimit;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x322B460", Offset = "0x322B460", VA = "0x322B460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0000", Offset = "0xCD0000")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x322B4E4", Offset = "0x322B4E4", VA = "0x322B4E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0064", Offset = "0xCD0064")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x322B568", Offset = "0x322B568", VA = "0x322B568")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD00C8", Offset = "0xCD00C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x322B5EC", Offset = "0x322B5EC", VA = "0x322B5EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD012C", Offset = "0xCD012C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x322B670", Offset = "0x322B670", VA = "0x322B670", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x322B7B0", Offset = "0x322B7B0", VA = "0x322B7B0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x322BD14", Offset = "0x322BD14", VA = "0x322BD14")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0B18", Offset = "0xCC0B18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0B18", Offset = "0xCC0B18")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useLimits;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19B3")]
		public float max;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122050")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastAngle;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x322BD70", Offset = "0x322BD70", VA = "0x322BD70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0190", Offset = "0xCD0190")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x322BDF4", Offset = "0x322BDF4", VA = "0x322BDF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD01F4", Offset = "0xCD01F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x322BE78", Offset = "0x322BE78", VA = "0x322BE78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0258", Offset = "0xCD0258")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x322BEFC", Offset = "0x322BEFC", VA = "0x322BEFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD02BC", Offset = "0xCD02BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x322BF80", Offset = "0x322BF80", VA = "0x322BF80", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x322C034", Offset = "0x322C034", VA = "0x322C034")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x322C760", Offset = "0x322C760", VA = "0x322C760")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0BC4", Offset = "0xCC0BC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0BC4", Offset = "0xCC0BC4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 S;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C3")]
			public Vector3 B;

			[Token(Token = "0x170000D5")]
			public Vector3 o
			{
				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x3230938", Offset = "0x3230938", VA = "0x3230938")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D6")]
			public Vector3 a
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x3230998", Offset = "0x3230998", VA = "0x3230998")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D7")]
			public Vector3 b
			{
				[Token(Token = "0x60008AA")]
				[Address(RVA = "0x32309F8", Offset = "0x32309F8", VA = "0x32309F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D8")]
			public Vector3 c
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x3230A58", Offset = "0x3230A58", VA = "0x3230A58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D9")]
			public bool isValid
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x322E814", Offset = "0x322E814", VA = "0x322E814")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x322F60C", Offset = "0x322F60C", VA = "0x322F60C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x322F8E8", Offset = "0x322F8E8", VA = "0x322F8E8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public class LimitPoint
		{
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3 point;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122070")]
			public float tangentWeight;

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x322E890", Offset = "0x322E890", VA = "0x322E890")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC88C8", Offset = "0xCC88C8")]
		public float twistLimit;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC8910", Offset = "0xCC8910")]
		public int smoothIterations;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19BB")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122060")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x322C870", Offset = "0x322C870", VA = "0x322C870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0320", Offset = "0xCD0320")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x322C8F4", Offset = "0x322C8F4", VA = "0x322C8F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0384", Offset = "0xCD0384")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x322C978", Offset = "0x322C978", VA = "0x322C978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD03E8", Offset = "0xCD03E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x322C9FC", Offset = "0x322C9FC", VA = "0x322C9FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD044C", Offset = "0xCD044C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x322CA80", Offset = "0x322CA80", VA = "0x322CA80")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x322D398", Offset = "0x322D398", VA = "0x322D398", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x322D518", Offset = "0x322D518", VA = "0x322D518")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x322E05C", Offset = "0x322E05C", VA = "0x322E05C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x322CB6C", Offset = "0x322CB6C", VA = "0x322CB6C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x322E97C", Offset = "0x322E97C", VA = "0x322E97C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x322FC54", Offset = "0x322FC54", VA = "0x322FC54")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x322FD84", Offset = "0x322FD84", VA = "0x322FD84")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x3230050", Offset = "0x3230050", VA = "0x3230050")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x322D938", Offset = "0x322D938", VA = "0x322D938")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x32303E0", Offset = "0x32303E0", VA = "0x32303E0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x3230880", Offset = "0x3230880", VA = "0x3230880")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCC0C70", Offset = "0xCC0C70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCC0C70", Offset = "0xCC0C70")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCC8A6C", Offset = "0xCC8A6C")]
		public float twistLimit;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x3230AB8", Offset = "0x3230AB8", VA = "0x3230AB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD04B0", Offset = "0xCD04B0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x3230B3C", Offset = "0x3230B3C", VA = "0x3230B3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0514", Offset = "0xCD0514")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x3230BC0", Offset = "0x3230BC0", VA = "0x3230BC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD0578", Offset = "0xCD0578")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x3230C44", Offset = "0x3230C44", VA = "0x3230C44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCD05DC", Offset = "0xCD05DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x3230CC8", Offset = "0x3230CC8", VA = "0x3230CC8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x3230D20", Offset = "0x3230D20", VA = "0x3230D20", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x3230E60", Offset = "0x3230E60", VA = "0x3230E60")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x32315F0", Offset = "0x32315F0", VA = "0x32315F0")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public bool visualize;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122080")]
			public string name;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float yaw;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float pitch;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19D3")]
			private float angleBuffer;

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x26A22D4", Offset = "0x26A22D4", VA = "0x26A22D4")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x26A2A50", Offset = "0x26A2A50", VA = "0x26A2A50")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x26A2A88", Offset = "0x26A2A88", VA = "0x26A2A88")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float angleBuffer;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19CB")]
		public Pose[] poses;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x26924C8", Offset = "0x26924C8", VA = "0x26924C8")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x26926CC", Offset = "0x26926CC", VA = "0x26926CC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x26A2998", Offset = "0x26A2998", VA = "0x26A2998")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC734", Offset = "0xCCC734")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x19E3")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC798", Offset = "0xCCC798")]
				public float weight;

				[Token(Token = "0x6000948")]
				[Address(RVA = "0x33AC2F4", Offset = "0x33AC2F4", VA = "0x33AC2F4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122090")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB6E0", Offset = "0xCCB6E0")]
			public Transform transform;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB744", Offset = "0xCCB744")]
			public Transform relativeTo;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB7A8", Offset = "0xCCB7A8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB80C", Offset = "0xCCB80C")]
			public float verticalWeight;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19DB")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB870", Offset = "0xCCB870")]
			public float horizontalWeight;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB8D4", Offset = "0xCCB8D4")]
			public float speed;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41220A0")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool firstUpdate;

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x26A2D38", Offset = "0x26A2D38", VA = "0x26A2D38")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x26A38BC", Offset = "0x26A38BC", VA = "0x26A38BC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x26A3A0C", Offset = "0x26A3A0C", VA = "0x26A3A0C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8B10", Offset = "0xCC8B10")]
		public Body[] bodies;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x26A2AFC", Offset = "0x26A2AFC", VA = "0x26A2AFC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x26A388C", Offset = "0x26A388C", VA = "0x26A388C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8B74", Offset = "0xCC8B74")]
		public float tiltSpeed;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41220B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8BD8", Offset = "0xCC8BD8")]
		public float tiltSensitivity;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8C3C", Offset = "0xCC8C3C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8CA0", Offset = "0xCC8CA0")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float tiltAngle;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19EB")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x33AEEB0", Offset = "0x33AEEB0", VA = "0x33AEEB0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x33AEF34", Offset = "0x33AEF34", VA = "0x33AEF34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x33AF438", Offset = "0x33AF438", VA = "0x33AF438")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB938", Offset = "0xCCB938")]
			public string name;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCB99C", Offset = "0xCCB99C")]
			public string colliderSearchName;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBA00", Offset = "0xCCBA00")]
			public Collider collider;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19F3")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBA64", Offset = "0xCCBA64")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCBAE4", Offset = "0xCCBAE4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41220D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCBB20", Offset = "0xCCBB20")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCBB5C", Offset = "0xCCBB5C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCCBB98", Offset = "0xCCBB98")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float length;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19FB")]
			private float crossFadeSpeed;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private float lastTime;

			[Token(Token = "0x170000DA")]
			protected float crossFader
			{
				[Token(Token = "0x60008B6")]
				[Address(RVA = "0x33DD9F4", Offset = "0x33DD9F4", VA = "0x33DD9F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1794", Offset = "0xCD1794")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008B7")]
				[Address(RVA = "0x33DDA24", Offset = "0x33DDA24", VA = "0x33DDA24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD17D0", Offset = "0xCD17D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			protected float timer
			{
				[Token(Token = "0x60008B8")]
				[Address(RVA = "0x33DDA5C", Offset = "0x33DDA5C", VA = "0x33DDA5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD180C", Offset = "0xCD180C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008B9")]
				[Address(RVA = "0x33DDA8C", Offset = "0x33DDA8C", VA = "0x33DDA8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1848", Offset = "0xCD1848")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			protected Vector3 force
			{
				[Token(Token = "0x60008BA")]
				[Address(RVA = "0x33DDAC4", Offset = "0x33DDAC4", VA = "0x33DDAC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1884", Offset = "0xCD1884")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008BB")]
				[Address(RVA = "0x33DDB04", Offset = "0x33DDB04", VA = "0x33DDB04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD18C0", Offset = "0xCD18C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			protected Vector3 point
			{
				[Token(Token = "0x60008BC")]
				[Address(RVA = "0x33DDB64", Offset = "0x33DDB64", VA = "0x33DDB64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD18FC", Offset = "0xCD18FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008BD")]
				[Address(RVA = "0x33DDBA4", Offset = "0x33DDBA4", VA = "0x33DDBA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD1938", Offset = "0xCD1938")]
				private set
				{
				}
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x33DD72C", Offset = "0x33DD72C", VA = "0x33DD72C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x33DCF04", Offset = "0x33DCF04", VA = "0x33DCF04")]
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
			[Address(RVA = "0x33DDC04", Offset = "0x33DDC04", VA = "0x33DDC04")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC7FC", Offset = "0xCCC7FC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000824")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1A03")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC860", Offset = "0xCCC860")]
				public float weight;

				[Token(Token = "0x4000825")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				private Vector3 lastValue;

				[Token(Token = "0x4000826")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x41220F0")]
				private Vector3 current;

				[Token(Token = "0x6000949")]
				[Address(RVA = "0x33DF058", Offset = "0x33DF058", VA = "0x33DF058")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600094A")]
				[Address(RVA = "0x33DEBA4", Offset = "0x33DEBA4", VA = "0x33DEBA4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600094B")]
				[Address(RVA = "0x33DF308", Offset = "0x33DF308", VA = "0x33DF308")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41220E0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBBD4", Offset = "0xCCBBD4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBC38", Offset = "0xCCBC38")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBC9C", Offset = "0xCCBC9C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x33DE7B8", Offset = "0x33DE7B8", VA = "0x33DE7B8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x33DEAAC", Offset = "0x33DEAAC", VA = "0x33DEAAC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x33DEBFC", Offset = "0x33DEBFC", VA = "0x33DEBFC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x33DF2D8", Offset = "0x33DF2D8", VA = "0x33DF2D8")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x1A0B")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC8C4", Offset = "0xCCC8C4")]
				public string boneSearchName;

				[Token(Token = "0x4000828")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC928", Offset = "0xCCC928")]
				public Transform bone;

				[Token(Token = "0x4000829")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4122100")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC98C", Offset = "0xCCC98C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCC98C", Offset = "0xCCC98C")]
				public float weight;

				[Token(Token = "0x400082A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion lastValue;

				[Token(Token = "0x400082B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion current;

				[Token(Token = "0x600094C")]
				[Address(RVA = "0x33DE3B0", Offset = "0x33DE3B0", VA = "0x33DE3B0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600094D")]
				[Address(RVA = "0x33DDE50", Offset = "0x33DDE50", VA = "0x33DDE50")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600094E")]
				[Address(RVA = "0x33DE69C", Offset = "0x33DE69C", VA = "0x33DE69C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBD00", Offset = "0xCCBD00")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBD64", Offset = "0xCCBD64")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x33DDC4C", Offset = "0x33DDC4C", VA = "0x33DDC4C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x33DDD58", Offset = "0x33DDD58", VA = "0x33DDD58", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x33DDEA8", Offset = "0x33DDEA8", VA = "0x33DDEA8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x33DE66C", Offset = "0x33DE66C", VA = "0x33DE66C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8D04", Offset = "0xCC8D04")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41220C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8D68", Offset = "0xCC8D68")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x33DC288", Offset = "0x33DC288", VA = "0x33DC288", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x33DC778", Offset = "0x33DC778", VA = "0x33DC778")]
		public Transform FindDeepChild(Transform aParent, string aName)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x33DCCDC", Offset = "0x33DCCDC", VA = "0x33DCCDC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x33DD22C", Offset = "0x33DD22C", VA = "0x33DD22C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x33DD9C4", Offset = "0x33DD9C4", VA = "0x33DD9C4")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x1A23")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCCA28", Offset = "0xCCCA28")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCCA8C", Offset = "0xCCCA8C")]
				public float weight;

				[Token(Token = "0x600094F")]
				[Address(RVA = "0x3209318", Offset = "0x3209318", VA = "0x3209318")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBDC8", Offset = "0xCCBDC8")]
			public Transform transform;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122110")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBE2C", Offset = "0xCCBE2C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBE90", Offset = "0xCCBE90")]
			public float speed;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBEF4", Offset = "0xCCBEF4")]
			public float acceleration;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBF58", Offset = "0xCCBF58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCBF58", Offset = "0xCCBF58")]
			public float matchVelocity;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A1B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCBFF4", Offset = "0xCCBFF4")]
			public float gravity;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 delta;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122120")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 direction;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool firstUpdate;

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x3208328", Offset = "0x3208328", VA = "0x3208328")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x32086D4", Offset = "0x32086D4", VA = "0x32086D4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x32092A4", Offset = "0x32092A4", VA = "0x32092A4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8DCC", Offset = "0xCC8DCC")]
		public Body[] bodies;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A13")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8E30", Offset = "0xCC8E30")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x3208230", Offset = "0x3208230", VA = "0x3208230")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x3208530", Offset = "0x3208530", VA = "0x3208530", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x3209230", Offset = "0x3209230", VA = "0x3209230")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC058", Offset = "0xCCC058")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A2B")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC0BC", Offset = "0xCCC0BC")]
			public float spring;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC120", Offset = "0xCCC120")]
			public bool x;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122140")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC184", Offset = "0xCCC184")]
			public bool y;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC1E8", Offset = "0xCCC1E8")]
			public bool z;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC24C", Offset = "0xCCC24C")]
			public float minX;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC2B0", Offset = "0xCCC2B0")]
			public float maxX;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A33")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC314", Offset = "0xCCC314")]
			public float minY;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC378", Offset = "0xCCC378")]
			public float maxY;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122150")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC3DC", Offset = "0xCCC3DC")]
			public float minZ;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC440", Offset = "0xCCC440")]
			public float maxZ;

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x32219B0", Offset = "0x32219B0", VA = "0x32219B0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x322267C", Offset = "0x322267C", VA = "0x322267C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x32227CC", Offset = "0x32227CC", VA = "0x32227CC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x3222A30", Offset = "0x3222A30", VA = "0x3222A30")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0FB0", Offset = "0xCC0FB0")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A3B")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D6")]
				[Address(RVA = "0x322257C", Offset = "0x322257C", VA = "0x322257C", Slot = "4")]
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
				[Address(RVA = "0x322264C", Offset = "0x322264C", VA = "0x322264C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x32216D0", Offset = "0x32216D0", VA = "0x32216D0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x32221F8", Offset = "0x32221F8", VA = "0x32221F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x322220C", Offset = "0x322220C", VA = "0x322220C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x32225AC", Offset = "0x32225AC", VA = "0x32225AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8E94", Offset = "0xCC8E94")]
		public float weight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8EF8", Offset = "0xCC8EF8")]
		[SerializeField]
		protected FullBodyBipedIK ik;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastTime;

		[Token(Token = "0x1700007D")]
		protected float deltaTime
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x320868C", Offset = "0x320868C", VA = "0x320868C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E2")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x32215CC", Offset = "0x32215CC", VA = "0x32215CC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x3221614", Offset = "0x3221614", VA = "0x3221614")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCD0640", Offset = "0xCD0640")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x3221718", Offset = "0x3221718", VA = "0x3221718")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x3209088", Offset = "0x3209088", VA = "0x3209088")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x3222018", Offset = "0x3222018", VA = "0x3222018", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x3209260", Offset = "0x3209260", VA = "0x3209260")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122160")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 offset;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pin;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x3222BAC", Offset = "0x3222BAC", VA = "0x3222BAC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x32235FC", Offset = "0x32235FC", VA = "0x32235FC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x3222A60", Offset = "0x3222A60", VA = "0x3222A60")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x3223334", Offset = "0x3223334", VA = "0x3223334")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x322355C", Offset = "0x322355C", VA = "0x322355C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCCAF0", Offset = "0xCCCAF0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCCB54", Offset = "0xCCCB54")]
				public float weight;

				[Token(Token = "0x6000950")]
				[Address(RVA = "0x322A1B8", Offset = "0x322A1B8", VA = "0x322A1B8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC4A4", Offset = "0xCCC4A4")]
			public Vector3 offset;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC508", Offset = "0xCCC508")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCCC508", Offset = "0xCCC508")]
			public float additivity;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC5A4", Offset = "0xCCC5A4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A63")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCCC608", Offset = "0xCCC608")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41221B0")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x3227E24", Offset = "0x3227E24", VA = "0x3227E24")]
			public void Start()
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x32293F8", Offset = "0x32293F8", VA = "0x32293F8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x322A158", Offset = "0x322A158", VA = "0x322A158")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A43")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8F78", Offset = "0xCC8F78")]
		public AimIK aimIK;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC8FDC", Offset = "0xCC8FDC")]
		public Handedness handedness;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122170")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9040", Offset = "0xCC9040")]
		public bool twoHanded;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC90A4", Offset = "0xCC90A4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9108", Offset = "0xCC9108")]
		public float magnitudeRandom;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC916C", Offset = "0xCC916C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC91D0", Offset = "0xCC91D0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9234", Offset = "0xCC9234")]
		public float blendTime;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122180")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCC9298", Offset = "0xCC9298")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9298", Offset = "0xCC9298")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float magnitudeMlp;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float endTime;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A53")]
		private Quaternion handRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122190")]
		private Quaternion randomRotation;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float length;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float blendWeight;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A5B")]
		private float w;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41221A0")]
		private bool handRotationsSet;

		[Token(Token = "0x1700007E")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x3229A2C", Offset = "0x3229A2C", VA = "0x3229A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x3229AF8", Offset = "0x3229AF8", VA = "0x3229AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x3229994", Offset = "0x3229994", VA = "0x3229994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x32299E0", Offset = "0x32299E0", VA = "0x32299E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x3227760", Offset = "0x3227760", VA = "0x3227760")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x32279D8", Offset = "0x32279D8", VA = "0x32279D8")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x3227FA8", Offset = "0x3227FA8", VA = "0x3227FA8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x3229BC4", Offset = "0x3229BC4", VA = "0x3229BC4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x3229DEC", Offset = "0x3229DEC", VA = "0x3229DEC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x3229FF8", Offset = "0x3229FF8", VA = "0x3229FF8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41221C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC9364", Offset = "0xCC9364")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCC93C8", Offset = "0xCC93C8")]
		public float offset;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool skip;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x3231634", Offset = "0x3231634", VA = "0x3231634")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x3231790", Offset = "0x3231790", VA = "0x3231790")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x32319F8", Offset = "0x32319F8", VA = "0x32319F8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x3232270", Offset = "0x3232270", VA = "0x3232270")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x3232308", Offset = "0x3232308", VA = "0x3232308")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x32324E8", Offset = "0x32324E8", VA = "0x32324E8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A73")]
		private Vector2 _HALF_UV;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2F73B68", Offset = "0x2F73B68", VA = "0x2F73B68", Slot = "4")]
		public string version()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2F73BDC", Offset = "0x2F73BDC", VA = "0x2F73BDC", Slot = "5")]
		public int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2F73BF8", Offset = "0x2F73BF8", VA = "0x2F73BF8", Slot = "6")]
		public int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2F73C14", Offset = "0x2F73C14", VA = "0x2F73C14", Slot = "7")]
		public bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2F73C78", Offset = "0x2F73C78", VA = "0x2F73C78", Slot = "8")]
		public void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x2F73CE4", Offset = "0x2F73CE4", VA = "0x2F73CE4", Slot = "9")]
		public void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x2F73D50", Offset = "0x2F73D50", VA = "0x2F73D50", Slot = "10")]
		public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2F73E4C", Offset = "0x2F73E4C", VA = "0x2F73E4C", Slot = "11")]
		public bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2F73F2C", Offset = "0x2F73F2C", VA = "0x2F73F2C")]
		public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2F74270", Offset = "0x2F74270", VA = "0x2F74270", Slot = "12")]
		public Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2F746E8", Offset = "0x2F746E8", VA = "0x2F746E8", Slot = "13")]
		public void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2F74754", Offset = "0x2F74754", VA = "0x2F74754", Slot = "14")]
		public void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2F747AC", Offset = "0x2F747AC", VA = "0x2F747AC", Slot = "15")]
		public void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2F74804", Offset = "0x2F74804", VA = "0x2F74804", Slot = "16")]
		public Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2F74864", Offset = "0x2F74864", VA = "0x2F74864", Slot = "17")]
		public Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x2F74AA8", Offset = "0x2F74AA8", VA = "0x2F74AA8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private bool m_doTintColor;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41221D0")]
		private Color m_tintColor;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultColor;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_defaultMetallic;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_defaultGlossiness;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A7B")]
		private Color m_defaultEmission;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_defaultNormal;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x2F77ED4", Offset = "0x2F77ED4", VA = "0x2F77ED4", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2F77EFC", Offset = "0x2F77EFC", VA = "0x2F77EFC", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x2F78094", Offset = "0x2F78094", VA = "0x2F78094", Slot = "6")]
		public Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2F78320", Offset = "0x2F78320", VA = "0x2F78320", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x2F78624", Offset = "0x2F78624", VA = "0x2F78624", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2F7871C", Offset = "0x2F7871C", VA = "0x2F7871C", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2F7840C", Offset = "0x2F7840C", VA = "0x2F7840C")]
		public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2F79EEC", Offset = "0x2F79EEC", VA = "0x2F79EEC")]
		public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2F527C0", Offset = "0x2F527C0", VA = "0x2F527C0")]
		public TextureBlenderFallback()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class TextureBlenderLegacyBumpDiffuse : TextureBlender
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41221E0")]
		private bool doColor;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_tintColor;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultTintColor;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2F7A0B0", Offset = "0x2F7A0B0", VA = "0x2F7A0B0", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2F7A1F4", Offset = "0x2F7A1F4", VA = "0x2F7A1F4", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2F7A30C", Offset = "0x2F7A30C", VA = "0x2F7A30C", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2F7A598", Offset = "0x2F7A598", VA = "0x2F7A598", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x2F7A660", Offset = "0x2F7A660", VA = "0x2F7A660", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2F7A714", Offset = "0x2F7A714", VA = "0x2F7A714", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2F7ABD0", Offset = "0x2F7ABD0", VA = "0x2F7ABD0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A83")]
		private Color m_tintColor;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private Color m_defaultTintColor;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2F7AC38", Offset = "0x2F7AC38", VA = "0x2F7AC38", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2F7AD7C", Offset = "0x2F7AD7C", VA = "0x2F7AD7C", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2F7AE94", Offset = "0x2F7AE94", VA = "0x2F7AE94", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2F7B120", Offset = "0x2F7B120", VA = "0x2F7B120", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2F7B1E8", Offset = "0x2F7B1E8", VA = "0x2F7B1E8", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x2F7B29C", Offset = "0x2F7B29C", VA = "0x2F7B29C", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x2F7B684", Offset = "0x2F7B684", VA = "0x2F7B684")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x41221F0")]
		private Color m_tintColor;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_emission;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Prop propertyToDo;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultColor;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8B")]
		private float m_defaultMetallic;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float m_defaultGlossiness;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122200")]
		private Color m_defaultEmission;

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x2F7B6EC", Offset = "0x2F7B6EC", VA = "0x2F7B6EC", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2F7B7A4", Offset = "0x2F7B7A4", VA = "0x2F7B7A4", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2F7BAF8", Offset = "0x2F7BAF8", VA = "0x2F7BAF8", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x2F7BFB4", Offset = "0x2F7BFB4", VA = "0x2F7BFB4", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2F7C1EC", Offset = "0x2F7C1EC", VA = "0x2F7C1EC", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2F7C484", Offset = "0x2F7C484", VA = "0x2F7C484", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x2F7D26C", Offset = "0x2F7D26C", VA = "0x2F7D26C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122210")]
		private Color m_tintColor;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_emission;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Prop propertyToDo;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Color m_defaultColor;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A9B")]
		private Color m_defaultSpecular;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private float m_defaultGlossiness;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122220")]
		private Color m_defaultEmission;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2F7D324", Offset = "0x2F7D324", VA = "0x2F7D324", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2F7D3DC", Offset = "0x2F7D3DC", VA = "0x2F7D3DC", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2F7D730", Offset = "0x2F7D730", VA = "0x2F7D730", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2F7DBEC", Offset = "0x2F7DBEC", VA = "0x2F7DBEC", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2F7DE4C", Offset = "0x2F7DE4C", VA = "0x2F7DE4C", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2F7E104", Offset = "0x2F7E104", VA = "0x2F7E104", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2F7EF70", Offset = "0x2F7EF70", VA = "0x2F7EF70")]
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
		[Address(RVA = "0x34C0130", Offset = "0x34C0130", VA = "0x34C0130")]
		public static void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x34C0658", Offset = "0x34C0658", VA = "0x34C0658")]
		public static string Error(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x34C07FC", Offset = "0x34C07FC", VA = "0x34C07FC")]
		public static string Warn(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x34C09A0", Offset = "0x34C09A0", VA = "0x34C09A0")]
		public static string Info(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x34C0B44", Offset = "0x34C0B44", VA = "0x34C0B44")]
		public static string LogDebug(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x34C0CE8", Offset = "0x34C0CE8", VA = "0x34C0CE8")]
		public static string Trace(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x34C0E8C", Offset = "0x34C0E8C", VA = "0x34C0E8C")]
		public MB2_Log()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class ObjectLog
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122290")]
		private int pos;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string[] logMessages;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2F77630", Offset = "0x2F77630", VA = "0x2F77630")]
		private void _CacheLogMessage(string msg)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2F7775C", Offset = "0x2F7775C", VA = "0x2F7775C")]
		public ObjectLog(short bufferSize)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2F7780C", Offset = "0x2F7780C", VA = "0x2F7780C")]
		public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2F77884", Offset = "0x2F77884", VA = "0x2F77884")]
		public void Error(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2F778E8", Offset = "0x2F778E8", VA = "0x2F778E8")]
		public void Warn(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2F7794C", Offset = "0x2F7794C", VA = "0x2F7794C")]
		public void Info(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2F779B0", Offset = "0x2F779B0", VA = "0x2F779B0")]
		public void LogDebug(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2F77A14", Offset = "0x2F77A14", VA = "0x2F77A14")]
		public void Trace(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2F77A78", Offset = "0x2F77A78", VA = "0x2F77A78")]
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
		[Address(RVA = "0x2F72950", Offset = "0x2F72950", VA = "0x2F72950")]
		private static MBVersionInterface _CreateMBVersionConcrete()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2F72A9C", Offset = "0x2F72A9C", VA = "0x2F72A9C")]
		public static string version()
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2F72BB4", Offset = "0x2F72BB4", VA = "0x2F72BB4")]
		public static int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x2F72CCC", Offset = "0x2F72CCC", VA = "0x2F72CCC")]
		public static int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x2F72DE4", Offset = "0x2F72DE4", VA = "0x2F72DE4")]
		public static bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x2F72F20", Offset = "0x2F72F20", VA = "0x2F72F20")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2F73064", Offset = "0x2F73064", VA = "0x2F73064")]
		public static void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2F731A8", Offset = "0x2F731A8", VA = "0x2F731A8")]
		public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x2F732D0", Offset = "0x2F732D0", VA = "0x2F732D0")]
		public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x2F7340C", Offset = "0x2F7340C", VA = "0x2F7340C")]
		public static Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x2F73568", Offset = "0x2F73568", VA = "0x2F73568")]
		public static void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2F736AC", Offset = "0x2F736AC", VA = "0x2F736AC")]
		public static void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2F737DC", Offset = "0x2F737DC", VA = "0x2F737DC")]
		public static void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2F7390C", Offset = "0x2F7390C", VA = "0x2F7390C")]
		public static Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2F73A10", Offset = "0x2F73A10", VA = "0x2F73A10")]
		public static Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2F73B38", Offset = "0x2F73B38", VA = "0x2F73B38")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x41222A0")]
			public int x;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int y;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int w;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int h;

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x34C85C4", Offset = "0x34C85C4", VA = "0x34C85C4")]
			public PixRect()
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x34C2BD0", Offset = "0x34C2BD0", VA = "0x34C2BD0")]
			public PixRect(int xx, int yy, int ww, int hh)
			{
			}
		}

		[Token(Token = "0x200014D")]
		private class Image
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AE3")]
			public int imgId;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int w;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41222B0")]
			public int h;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int y;

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x34C7868", Offset = "0x34C7868", VA = "0x34C7868")]
			public Image(int id, int tw, int th, int padding, int minImageSizeX, int minImageSizeY)
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x34C7FD4", Offset = "0x34C7FD4", VA = "0x34C7FD4")]
			public Image(Image im)
			{
			}
		}

		[Token(Token = "0x200014E")]
		private class ImgIDComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x34C83DC", Offset = "0x34C83DC", VA = "0x34C83DC", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x34C7C40", Offset = "0x34C7C40", VA = "0x34C7C40")]
			public ImgIDComparer()
			{
			}
		}

		[Token(Token = "0x200014F")]
		private class ImageHeightComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x34C8204", Offset = "0x34C8204", VA = "0x34C8204", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x34C7A44", Offset = "0x34C7A44", VA = "0x34C7A44")]
			public ImageHeightComparer()
			{
			}
		}

		[Token(Token = "0x2000150")]
		private class ImageWidthComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x34C82F0", Offset = "0x34C82F0", VA = "0x34C82F0", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x34C7A74", Offset = "0x34C7A74", VA = "0x34C7A74")]
			public ImageWidthComparer()
			{
			}
		}

		[Token(Token = "0x2000151")]
		private class ImageAreaComparer : IComparer<Image>
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x34C80D0", Offset = "0x34C80D0", VA = "0x34C80D0", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x34C7AA4", Offset = "0x34C7AA4", VA = "0x34C7AA4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AEB")]
			public int h;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Node root;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41222C0")]
			public bool fitsInMaxSize;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float efficiency;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float squareness;

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x34C3CC0", Offset = "0x34C3CC0", VA = "0x34C3CC0")]
			public void Set(int ww, int hh, Node r, bool fits, float e, float sq)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x34C7B04", Offset = "0x34C7B04", VA = "0x34C7B04")]
			public float GetScore(bool doPowerOfTwoScore)
			{
				return default(float);
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x34C7AD4", Offset = "0x34C7AD4", VA = "0x34C7AD4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AF3")]
			public PixRect r;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Image img;

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x34C84C8", Offset = "0x34C84C8", VA = "0x34C84C8")]
			private bool isLeaf()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x34C2C60", Offset = "0x34C2C60", VA = "0x34C2C60")]
			public Node Insert(Image im, bool handed)
			{
				return null;
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x34C2B30", Offset = "0x34C2B30", VA = "0x34C2B30")]
			public Node()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ADB")]
		private ProbeResult bestRoot;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public bool doPowerOfTwoTextures;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x34C0EBC", Offset = "0x34C0EBC", VA = "0x34C0EBC")]
		private static void printTree(Node r, string spc)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x34C10EC", Offset = "0x34C10EC", VA = "0x34C10EC")]
		private static void flattenTree(Node r, List<Image> putHere)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x34C1420", Offset = "0x34C1420", VA = "0x34C1420")]
		private static void drawGizmosNode(Node r)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x34C1A58", Offset = "0x34C1A58", VA = "0x34C1A58")]
		private static Texture2D createFilledTex(Color c, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x34C1D44", Offset = "0x34C1D44", VA = "0x34C1D44")]
		public void DrawGizmos()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x34C1DC4", Offset = "0x34C1DC4", VA = "0x34C1DC4")]
		private bool Probe(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDim, ProbeResult pr)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x34C3730", Offset = "0x34C3730", VA = "0x34C3730")]
		private void GetExtent(Node r, ref int x, ref int y)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x34C3D84", Offset = "0x34C3D84", VA = "0x34C3D84")]
		private int StepWidthHeight(int oldVal, int step, int maxDim)
		{
			return default(int);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x34C3EB8", Offset = "0x34C3EB8", VA = "0x34C3EB8")]
		public int RoundToNearestPositivePowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x34C3B68", Offset = "0x34C3B68", VA = "0x34C3B68")]
		public int CeilToNearestPowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x34C4054", Offset = "0x34C4054", VA = "0x34C4054")]
		public Rect[] GetRects(List<Vector2> imgWidthHeights, int maxDimension, int padding, out int outW, out int outH)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x34C4208", Offset = "0x34C4208", VA = "0x34C4208")]
		private Rect[] _GetRects(List<Vector2> imgWidthHeights, int maxDimension, int padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, out int outW, out int outH, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x34C7C70", Offset = "0x34C7C70", VA = "0x34C7C70")]
		public void RunTestHarness()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x34C7F78", Offset = "0x34C7F78", VA = "0x34C7F78")]
		public MB2_TexturePacker()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class MB3_CopyBoneWeights
	{
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x34C85F4", Offset = "0x34C85F4", VA = "0x34C85F4")]
		public static void CopyBoneWeightsFromSeamMeshToOtherMeshes(float radius, Mesh seamMesh, Mesh[] targetMeshes)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x34C9804", Offset = "0x34C9804", VA = "0x34C9804")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x41222D0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AFB")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected GameObject _resultSceneObject;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41222E0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B03")]
		[SerializeField]
		protected bool _doNorm;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _doTan;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41222F0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _doUV4;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0B")]
		[SerializeField]
		public float uv2UnwrappingParamsHardAngle;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		public float uv2UnwrappingParamsPackMargin;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122300")]
		protected bool _usingTemporaryTextureBakeResult;

		[Token(Token = "0x17000082")]
		public static bool EVAL_VERSION
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x34C9834", Offset = "0x34C9834", VA = "0x34C9834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public virtual MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x34C9854", Offset = "0x34C9854", VA = "0x34C9854", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x34C9884", Offset = "0x34C9884", VA = "0x34C9884", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public virtual MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x34C98BC", Offset = "0x34C98BC", VA = "0x34C98BC", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x34C98EC", Offset = "0x34C98EC", VA = "0x34C98EC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public string name
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x34C9924", Offset = "0x34C9924", VA = "0x34C9924")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x34C9954", Offset = "0x34C9954", VA = "0x34C9954")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public virtual MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x34C998C", Offset = "0x34C998C", VA = "0x34C998C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x34C99BC", Offset = "0x34C99BC", VA = "0x34C99BC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public virtual GameObject resultSceneObject
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x34C99F4", Offset = "0x34C99F4", VA = "0x34C99F4", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x34C9A24", Offset = "0x34C9A24", VA = "0x34C9A24", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public virtual Renderer targetRenderer
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x34C9A5C", Offset = "0x34C9A5C", VA = "0x34C9A5C", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x34C9A8C", Offset = "0x34C9A8C", VA = "0x34C9A8C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public virtual MB_RenderType renderType
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x34C9CF0", Offset = "0x34C9CF0", VA = "0x34C9CF0", Slot = "14")]
			get
			{
				return default(MB_RenderType);
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x34C9D20", Offset = "0x34C9D20", VA = "0x34C9D20", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public virtual MB2_OutputOptions outputOption
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x34C9D58", Offset = "0x34C9D58", VA = "0x34C9D58", Slot = "16")]
			get
			{
				return default(MB2_OutputOptions);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x34C9D88", Offset = "0x34C9D88", VA = "0x34C9D88", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public virtual MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x34C9DC0", Offset = "0x34C9DC0", VA = "0x34C9DC0", Slot = "18")]
			get
			{
				return default(MB2_LightmapOptions);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x34C9DF0", Offset = "0x34C9DF0", VA = "0x34C9DF0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public virtual bool doNorm
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x34C9E28", Offset = "0x34C9E28", VA = "0x34C9E28", Slot = "20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x34C9E6C", Offset = "0x34C9E6C", VA = "0x34C9E6C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual bool doTan
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x34C9EB8", Offset = "0x34C9EB8", VA = "0x34C9EB8", Slot = "22")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x34C9EFC", Offset = "0x34C9EFC", VA = "0x34C9EFC", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual bool doCol
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x34C9F48", Offset = "0x34C9F48", VA = "0x34C9F48", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x34C9F8C", Offset = "0x34C9F8C", VA = "0x34C9F8C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual bool doUV
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x34C9FD8", Offset = "0x34C9FD8", VA = "0x34C9FD8", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x34CA01C", Offset = "0x34CA01C", VA = "0x34CA01C", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public virtual bool doUV1
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x34CA068", Offset = "0x34CA068", VA = "0x34CA068", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x34CA08C", Offset = "0x34CA08C", VA = "0x34CA08C", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public virtual bool doUV3
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x34CA16C", Offset = "0x34CA16C", VA = "0x34CA16C", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x34CA1B0", Offset = "0x34CA1B0", VA = "0x34CA1B0", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public virtual bool doUV4
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x34CA1FC", Offset = "0x34CA1FC", VA = "0x34CA1FC", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x34CA240", Offset = "0x34CA240", VA = "0x34CA240", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x34CA0AC", Offset = "0x34CA0AC", VA = "0x34CA0AC", Slot = "30")]
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
		[Address(RVA = "0x34CA28C", Offset = "0x34CA28C", VA = "0x34CA28C", Slot = "44")]
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
		[Address(RVA = "0x34CA2C4", Offset = "0x34CA2C4", VA = "0x34CA2C4")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x34CAC8C", Offset = "0x34CAC8C", VA = "0x34CAC8C")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x34CB0A4", Offset = "0x34CB0A4", VA = "0x34CB0A4", Slot = "55")]
		protected virtual bool _CheckIfAllObjsToAddUseSameMaterialsAndCreateTemporaryTextrueBakeResult(GameObject[] gos)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x34CB920", Offset = "0x34CB920", VA = "0x34CB920")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B2B")]
			public int vertIdx;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int numVerts;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122340")]
			public int[] indexesOfBonesUsed;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int lightmapIndex;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 lightmapTilingOffset;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool show;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B33")]
			public bool invertTriangles;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int[] submeshTriIdxs;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122350")]
			public int[] submeshNumTris;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int[] targetSubmeshIdxs;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect[] uvRects;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect[] uvSubRectInAtlas;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B3B")]
			public Rect[] uvRectsInSrcFull;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Rect[] obUVRects;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122360")]
			public int[][] _submeshTris;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool _beingDeleted;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _triangleIdxAdjustment;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform[] _tmpCachedBones;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B43")]
			public Matrix4x4[] _tmpCachedBindposes;

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x34E8574", Offset = "0x34E8574", VA = "0x34E8574", Slot = "4")]
			public int CompareTo(MB_DynamicGameObject b)
			{
				return default(int);
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x34D8D2C", Offset = "0x34D8D2C", VA = "0x34D8D2C")]
			public MB_DynamicGameObject()
			{
			}
		}

		[Token(Token = "0x2000156")]
		public class MeshChannels
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector3[] vertices;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122370")]
			public Vector3[] normals;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4[] tangents;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv0raw;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2[] uv0modified;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4B")]
			public Vector2[] uv2;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector2[] uv3;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122380")]
			public Vector2[] uv4;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Color[] colors;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BoneWeight[] boneWeights;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Matrix4x4[] bindPoses;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B53")]
			public int[] triangles;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x34E85CC", Offset = "0x34E85CC", VA = "0x34E85CC")]
			public MeshChannels()
			{
			}
		}

		[Token(Token = "0x2000157")]
		public class MeshChannelsCache
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private MB3_MeshCombinerSingle mc;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122390")]
			protected Dictionary<int, MeshChannels> meshID2MeshChannels;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector2 _HALF_UV;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x34D8B80", Offset = "0x34D8B80", VA = "0x34D8B80")]
			public MeshChannelsCache(MB3_MeshCombinerSingle mcs)
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x34DA32C", Offset = "0x34DA32C", VA = "0x34DA32C")]
			public Vector3[] GetVertices(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x34DA548", Offset = "0x34DA548", VA = "0x34DA548")]
			public Vector3[] GetNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x34DA760", Offset = "0x34DA760", VA = "0x34DA760")]
			public Vector4[] GetTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x34CEF5C", Offset = "0x34CEF5C", VA = "0x34CEF5C")]
			public Vector2[] GetUv0Raw(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x34E90EC", Offset = "0x34E90EC", VA = "0x34E90EC")]
			public Vector2[] GetUv0Modified(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x34DCFE4", Offset = "0x34DCFE4", VA = "0x34DCFE4")]
			public Vector2[] GetUv2(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x34DBC90", Offset = "0x34DBC90", VA = "0x34DBC90")]
			public Vector2[] GetUv3(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x34DBEF0", Offset = "0x34DBEF0", VA = "0x34DBEF0")]
			public Vector2[] GetUv4(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x34DC150", Offset = "0x34DC150", VA = "0x34DC150")]
			public Color[] GetColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x34E7A68", Offset = "0x34E7A68", VA = "0x34E7A68")]
			public Matrix4x4[] GetBindposes(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x34E2C88", Offset = "0x34E2C88", VA = "0x34E2C88")]
			public BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x34EA0D8", Offset = "0x34EA0D8", VA = "0x34EA0D8")]
			public int[] GetTriangles(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x34E9608", Offset = "0x34E9608", VA = "0x34E9608")]
			private Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x34E85FC", Offset = "0x34E85FC", VA = "0x34E85FC")]
			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x34E8980", Offset = "0x34E8980", VA = "0x34E8980")]
			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x34E8DCC", Offset = "0x34E8DCC", VA = "0x34E8DCC")]
			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x34E92E8", Offset = "0x34E92E8", VA = "0x34E92E8")]
			private Vector2[] _getMeshUV2s(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x34E993C", Offset = "0x34E993C", VA = "0x34E993C")]
			public static Matrix4x4[] _getBindPoses(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x34E9C70", Offset = "0x34E9C70", VA = "0x34E9C70")]
			public static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x34EA2F4", Offset = "0x34EA2F4", VA = "0x34EA2F4")]
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
			[Address(RVA = "0x34E7CC0", Offset = "0x34E7CC0", VA = "0x34E7CC0")]
			public BoneAndBindpose(Transform t, Matrix4x4 bp)
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x34E81DC", Offset = "0x34E81DC", VA = "0x34E81DC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x34E84C8", Offset = "0x34E84C8", VA = "0x34E84C8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC0FEC", Offset = "0xCC0FEC")]
		private sealed class <>c__DisplayClass49_0
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B5B")]
			public GameObject[] _goToAdd;

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x34D7CCC", Offset = "0x34D7CCC", VA = "0x34D7CCC")]
			public <>c__DisplayClass49_0()
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC1028", Offset = "0xCC1028")]
		private sealed class <>c__DisplayClass49_1
		{
			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public int i;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41223A0")]
			public <>c__DisplayClass49_0 CS$<>8__locals1;

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x34D8CFC", Offset = "0x34D8CFC", VA = "0x34D8CFC")]
			public <>c__DisplayClass49_1()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x34E80F8", Offset = "0x34E80F8", VA = "0x34E80F8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B13")]
		private Dictionary<int, MB_DynamicGameObject> _instance2combined_map;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Vector3[] verts;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122310")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector2[] uv2s;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1B")]
		[SerializeField]
		private Vector2[] uv3s;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private Vector2[] uv4s;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122320")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Mesh _mesh;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B23")]
		private int[][] submeshTris;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private BoneWeight[] boneWeights;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122330")]
		private GameObject[] empty;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] emptyIDs;

		[Token(Token = "0x17000093")]
		public override MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x34CC034", Offset = "0x34CC034", VA = "0x34CC034", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public override MB_RenderType renderType
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x34CC324", Offset = "0x34CC324", VA = "0x34CC324", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public override GameObject resultSceneObject
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x34CC4C4", Offset = "0x34CC4C4", VA = "0x34CC4C4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x34CC76C", Offset = "0x34CC76C", VA = "0x34CC76C")]
		private MB_DynamicGameObject instance2Combined_MapGet(int gameObjectID)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x34CC814", Offset = "0x34CC814", VA = "0x34CC814")]
		private void instance2Combined_MapAdd(int gameObjectID, MB_DynamicGameObject dgo)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x34CC8C4", Offset = "0x34CC8C4", VA = "0x34CC8C4")]
		private void instance2Combined_MapRemove(int gameObjectID)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x34CC964", Offset = "0x34CC964", VA = "0x34CC964")]
		private bool instance2Combined_MapTryGetValue(int gameObjectID, out MB_DynamicGameObject dgo)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x34CCA30", Offset = "0x34CCA30", VA = "0x34CCA30")]
		private int instance2Combined_MapCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x34CCAC8", Offset = "0x34CCAC8", VA = "0x34CCAC8")]
		private void instance2Combined_MapClear()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x34CCB58", Offset = "0x34CCB58", VA = "0x34CCB58")]
		private bool instance2Combined_MapContainsKey(int gameObjectID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x34CCC14", Offset = "0x34CCC14", VA = "0x34CCC14", Slot = "41")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x34CCCAC", Offset = "0x34CCCAC", VA = "0x34CCCAC", Slot = "40")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x34CCD84", Offset = "0x34CCD84", VA = "0x34CCD84")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x34CCEE0", Offset = "0x34CCEE0", VA = "0x34CCEE0")]
		public Transform[] GetBones()
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x34CCF10", Offset = "0x34CCF10", VA = "0x34CCF10", Slot = "35")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x34CCFAC", Offset = "0x34CCFAC", VA = "0x34CCFAC", Slot = "42")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x34CD018", Offset = "0x34CD018", VA = "0x34CD018", Slot = "43")]
		public override int GetNumVerticesFor(int instanceID)
		{
			return default(int);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x34CD0B0", Offset = "0x34CD0B0", VA = "0x34CD0B0")]
		private void _initialize()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x34CDCF4", Offset = "0x34CDCF4", VA = "0x34CDCF4")]
		private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x34CE8F4", Offset = "0x34CE8F4", VA = "0x34CE8F4")]
		private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults, MeshChannelsCache meshChannelCache)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x34CF174", Offset = "0x34CF174", VA = "0x34CF174")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x34CF7E0", Offset = "0x34CF7E0", VA = "0x34CF7E0")]
		private bool _validateMeshFlags()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x34CFC54", Offset = "0x34CFC54", VA = "0x34CFC54")]
		private bool _showHide(GameObject[] goToShow, GameObject[] goToHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x34D0394", Offset = "0x34D0394", VA = "0x34D0394")]
		private bool _addToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x34DA978", Offset = "0x34DA978", VA = "0x34DA978")]
		private void _copyAndAdjustUVsFromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x34DB708", Offset = "0x34DB708", VA = "0x34DB708")]
		private void _copyAndAdjustUV2FromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x34DD1FC", Offset = "0x34DD1FC", VA = "0x34DD1FC", Slot = "51")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x34DD22C", Offset = "0x34DD22C", VA = "0x34DD22C", Slot = "52")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x34DD850", Offset = "0x34DD850", VA = "0x34DD850", Slot = "54")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x34DDEB4", Offset = "0x34DDEB4", VA = "0x34DDEB4")]
		private int _getNumBones(Renderer r)
		{
			return default(int);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x34DE0C8", Offset = "0x34DE0C8", VA = "0x34DE0C8")]
		private Transform[] _getBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x34DE10C", Offset = "0x34DE10C", VA = "0x34DE10C", Slot = "45")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x34DE2D4", Offset = "0x34DE2D4", VA = "0x34DE2D4", Slot = "56")]
		public virtual void ApplyShowHide()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x34DF1BC", Offset = "0x34DF1BC", VA = "0x34DF1BC", Slot = "46")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x34DE844", Offset = "0x34DE844", VA = "0x34DE844")]
		public int[][] GetSubmeshTrisWithShowHideApplied()
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x34E0F20", Offset = "0x34E0F20", VA = "0x34E0F20", Slot = "47")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x34E1118", Offset = "0x34E1118", VA = "0x34E1118")]
		private void _updateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x34E16A8", Offset = "0x34E16A8", VA = "0x34E16A8")]
		private void _updateGameObject(GameObject go, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x34E2EF0", Offset = "0x34E2EF0", VA = "0x34E2EF0")]
		public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x34E2F5C", Offset = "0x34E2F5C", VA = "0x34E2F5C", Slot = "48")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x34E338C", Offset = "0x34E338C", VA = "0x34E338C", Slot = "49")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x34E446C", Offset = "0x34E446C", VA = "0x34E446C", Slot = "50")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x34E4528", Offset = "0x34E4528", VA = "0x34E4528", Slot = "36")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x34E48C0", Offset = "0x34E48C0", VA = "0x34E48C0", Slot = "37")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x34E4A44", Offset = "0x34E4A44", VA = "0x34E4A44", Slot = "38")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x34E4C30", Offset = "0x34E4C30", VA = "0x34E4C30", Slot = "39")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x34D7CFC", Offset = "0x34D7CFC", VA = "0x34D7CFC")]
		public bool ValidateTargRendererAndMeshAndResultSceneObj()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x34E4E54", Offset = "0x34E4E54", VA = "0x34E4E54")]
		public static Renderer BuildSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, bool createNewChild = false, [Optional] GameObject[] objsToBeAdded)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x34E4274", Offset = "0x34E4274", VA = "0x34E4274")]
		public void BuildSceneMeshObject([Optional] GameObject[] gos, bool createNewChild = false)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x34D95F0", Offset = "0x34D95F0", VA = "0x34D95F0")]
		private bool IsMirrored(Matrix4x4 tm)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x34E6EF8", Offset = "0x34E6EF8", VA = "0x34E6EF8", Slot = "53")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x34D87E8", Offset = "0x34D87E8", VA = "0x34D87E8")]
		private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x34D8EE8", Offset = "0x34D8EE8", VA = "0x34D8EE8")]
		private void _CollectBonesToAddForDGO(MB_DynamicGameObject dgo, List<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Renderer r, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x34D9938", Offset = "0x34D9938", VA = "0x34D9938")]
		private void _CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(List<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Transform[] nbones, Matrix4x4[] nbindPoses, BoneWeight[] nboneWeights, int totalDeleteVerts)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x34DC368", Offset = "0x34DC368", VA = "0x34DC368")]
		private void _AddBonesToNewBonesArrayAndAdjustBWIndexes(MB_DynamicGameObject dgo, Renderer r, int vertsIdx, Transform[] nbones, BoneWeight[] nboneWeights, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x34E7D4C", Offset = "0x34E7D4C", VA = "0x34E7D4C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x41223B0")]
			public MB3_MeshCombinerSingle combinedMesh;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int extraSpace;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numVertsInListToDelete;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int numVertsInListToAdd;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B6B")]
			public List<GameObject> gosToAdd;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public List<int> gosToDelete;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41223C0")]
			public List<GameObject> gosToUpdate;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isDirty;

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x2F4E630", Offset = "0x2F4E630", VA = "0x2F4E630")]
			public CombinedMesh(int maxNumVertsInMesh, GameObject resultSceneObject, MB2_LogLevel ll)
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x2F4E844", Offset = "0x2F4E844", VA = "0x2F4E844")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<int, CombinedMesh> obj2MeshCombinerMap;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B63")]
		[SerializeField]
		public List<CombinedMesh> meshCombiners;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		private int _maxVertsInMesh;

		[Token(Token = "0x17000096")]
		public override MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x34EB7F0", Offset = "0x34EB7F0", VA = "0x34EB7F0", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x34EB820", Offset = "0x34EB820", VA = "0x34EB820", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public override MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x34EBB1C", Offset = "0x34EBB1C", VA = "0x34EBB1C", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x34EB99C", Offset = "0x34EB99C", VA = "0x34EB99C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int maxVertsInMesh
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x34EBB4C", Offset = "0x34EBB4C", VA = "0x34EBB4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x34EBB7C", Offset = "0x34EBB7C", VA = "0x34EBB7C")]
			set
			{
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x34EBDBC", Offset = "0x34EBDBC", VA = "0x34EBDBC", Slot = "41")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x34EBE54", Offset = "0x34EBE54", VA = "0x34EBE54", Slot = "42")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x34EBFB0", Offset = "0x34EBFB0", VA = "0x34EBFB0", Slot = "43")]
		public override int GetNumVerticesFor(int gameObjectID)
		{
			return default(int);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x34EC0EC", Offset = "0x34EC0EC", VA = "0x34EC0EC", Slot = "40")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x34EC2D4", Offset = "0x34EC2D4", VA = "0x34EC2D4", Slot = "35")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x34EC41C", Offset = "0x34EC41C", VA = "0x34EC41C", Slot = "50")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x34EC4F4", Offset = "0x34EC4F4", VA = "0x34EC4F4")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x34ECB60", Offset = "0x34ECB60", VA = "0x34ECB60", Slot = "45")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x34ECD8C", Offset = "0x34ECD8C", VA = "0x34ECD8C", Slot = "46")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x34ED15C", Offset = "0x34ED15C", VA = "0x34ED15C", Slot = "51")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x34ED2B4", Offset = "0x34ED2B4", VA = "0x34ED2B4", Slot = "52")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x34ED40C", Offset = "0x34ED40C", VA = "0x34ED40C", Slot = "54")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x34ED564", Offset = "0x34ED564", VA = "0x34ED564", Slot = "47")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x34EDED4", Offset = "0x34EDED4", VA = "0x34EDED4", Slot = "48")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x34EE304", Offset = "0x34EE304", VA = "0x34EE304", Slot = "49")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x34EEB80", Offset = "0x34EEB80", VA = "0x34EEB80")]
		private bool _validate(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x34EFB10", Offset = "0x34EFB10", VA = "0x34EFB10")]
		private void _distributeAmongBakers(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x34F0C7C", Offset = "0x34F0C7C", VA = "0x34F0C7C")]
		private bool _bakeStep1(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x34F2DB8", Offset = "0x34F2DB8", VA = "0x34F2DB8", Slot = "36")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x34F2F10", Offset = "0x34F2F10", VA = "0x34F2F10", Slot = "37")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x34F2F40", Offset = "0x34F2F40", VA = "0x34F2F40", Slot = "38")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x34F32A8", Offset = "0x34F32A8", VA = "0x34F32A8", Slot = "39")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x34F29DC", Offset = "0x34F29DC", VA = "0x34F29DC")]
		private void _setMBValues(MB3_MeshCombinerSingle targ)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x34F3644", Offset = "0x34F3644", VA = "0x34F3644", Slot = "53")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x34F379C", Offset = "0x34F379C", VA = "0x34F379C")]
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
		[Address(RVA = "0x2F709C0", Offset = "0x2F709C0", VA = "0x2F709C0")]
		public ShaderTextureProperty(string n, bool norm)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2F6723C", Offset = "0x2F6723C", VA = "0x2F6723C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8B")]
			public Texture2D t;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public float texelDensity;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122400")]
			public DRect fullSamplingRect;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DRect matTilingRect;

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x2F71A38", Offset = "0x2F71A38", VA = "0x2F71A38")]
			public MeshBakerMaterialTexture()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x2F71A68", Offset = "0x2F71A68", VA = "0x2F71A68")]
			public MeshBakerMaterialTexture(Texture2D tx)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x2F5BA94", Offset = "0x2F5BA94", VA = "0x2F5BA94")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B93")]
			public DRect obUVRectIfTilingSame;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public DRect samplingRectMatAndUVTiling;

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x2F5C098", Offset = "0x2F5C098", VA = "0x2F5C098")]
			public MatAndTransformToMerged(Material m)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x2F71690", Offset = "0x2F71690", VA = "0x2F71690", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x2F71974", Offset = "0x2F71974", VA = "0x2F71974", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200015E")]
		public class SamplingRectEnclosesComparer : IComparer<MatAndTransformToMerged>
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x2F71AB0", Offset = "0x2F71AB0", VA = "0x2F71AB0", Slot = "4")]
			public int Compare(MatAndTransformToMerged x, MatAndTransformToMerged y)
			{
				return default(int);
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x2F6CE88", Offset = "0x2F6CE88", VA = "0x2F6CE88")]
			public SamplingRectEnclosesComparer()
			{
			}
		}

		[Token(Token = "0x200015F")]
		public class MB_TexSet
		{
			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122410")]
			public MeshBakerMaterialTexture[] ts;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<MatAndTransformToMerged> mats;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<GameObject> gos;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool allTexturesUseSameMatTiling;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B9B")]
			public Vector2 obUVoffset;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public Vector2 obUVscale;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122420")]
			public int idealWidth;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int idealHeight;

			[Token(Token = "0x170000E0")]
			public DRect obUVrect
			{
				[Token(Token = "0x600091C")]
				[Address(RVA = "0x2F7133C", Offset = "0x2F7133C", VA = "0x2F7133C")]
				get
				{
					return default(DRect);
				}
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x2F5BCD0", Offset = "0x2F5BCD0", VA = "0x2F5BCD0")]
			public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale)
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x2F70C54", Offset = "0x2F70C54", VA = "0x2F70C54")]
			public bool IsEqual(object obj, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, TextureBlender resultMaterialTextureBlender)
			{
				return default(bool);
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x2F6B6C8", Offset = "0x2F6B6C8", VA = "0x2F6B6C8")]
			public void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x2F6BB10", Offset = "0x2F6BB10", VA = "0x2F6BB10")]
			public void CalcMatAndUVSamplingRectsIfAllMatTilingSame()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x2F6C070", Offset = "0x2F6C070", VA = "0x2F6C070")]
			public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, TextureBlender resultMaterialTextureBlender)
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x2F6B18C", Offset = "0x2F6B18C", VA = "0x2F6B18C")]
			internal string GetDescription()
			{
				return null;
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x2F713D4", Offset = "0x2F713D4", VA = "0x2F713D4")]
			internal string GetMatSubrectDescriptions()
			{
				return null;
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC1064", Offset = "0xCC1064")]
		private sealed class <>c__DisplayClass58_0
		{
			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<ShaderTextureProperty> texPropertyNames;

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x2F52144", Offset = "0x2F52144", VA = "0x2F52144")]
			public <>c__DisplayClass58_0()
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC10A0", Offset = "0xCC10A0")]
		private sealed class <>c__DisplayClass58_1
		{
			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BA3")]
			public <>c__DisplayClass58_0 CS$<>8__locals1;

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x2F52174", Offset = "0x2F52174", VA = "0x2F52174")]
			public <>c__DisplayClass58_1()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x2F70A34", Offset = "0x2F70A34", VA = "0x2F70A34")]
			internal bool <_CollectPropertyNames>b__0(ShaderTextureProperty x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCC10DC", Offset = "0xCC10DC")]
		private sealed class <>c__DisplayClass61_0
		{
			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			public MB_TexSet setOfTexs;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122430")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x2F5B7E8", Offset = "0x2F5B7E8", VA = "0x2F5B7E8")]
			public <>c__DisplayClass61_0()
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x2F70B5C", Offset = "0x2F70B5C", VA = "0x2F70B5C")]
			internal bool <__Step1_CollectDistinctMatTexturesAndUsedObjects>b__0(MB_TexSet x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B73")]
		public static bool DO_INTEGRITY_CHECKS;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41223D0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected int _maxAtlasSize;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B7B")]
		[SerializeField]
		protected bool _resizePowerOfTwoTextures;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _fixOutOfBoundsUVs;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41223E0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _meshBakerTexturePackerForcePowerOfTwo;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B83")]
		[SerializeField]
		protected List<ShaderTextureProperty> _customShaderPropNames;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		[SerializeField]
		protected bool _normalizeTexelDensity;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41223F0")]
		[SerializeField]
		protected bool _considerNonTextureProperties;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
			[Address(RVA = "0x2F4EBE4", Offset = "0x2F4EBE4", VA = "0x2F4EBE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x2F4EC14", Offset = "0x2F4EC14", VA = "0x2F4EC14")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int atlasPadding
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x2F4EC4C", Offset = "0x2F4EC4C", VA = "0x2F4EC4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x2F4EC7C", Offset = "0x2F4EC7C", VA = "0x2F4EC7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public int maxAtlasSize
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x2F4ECB4", Offset = "0x2F4ECB4", VA = "0x2F4ECB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x2F4ECE4", Offset = "0x2F4ECE4", VA = "0x2F4ECE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool resizePowerOfTwoTextures
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x2F4ED1C", Offset = "0x2F4ED1C", VA = "0x2F4ED1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x2F4ED60", Offset = "0x2F4ED60", VA = "0x2F4ED60")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool fixOutOfBoundsUVs
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x2F4EDAC", Offset = "0x2F4EDAC", VA = "0x2F4EDAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x2F4EDF0", Offset = "0x2F4EDF0", VA = "0x2F4EDF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public int maxTilingBakeSize
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x2F4EE3C", Offset = "0x2F4EE3C", VA = "0x2F4EE3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x2F4EE6C", Offset = "0x2F4EE6C", VA = "0x2F4EE6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool saveAtlasesAsAssets
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x2F4EEA4", Offset = "0x2F4EEA4", VA = "0x2F4EEA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2F4EEE8", Offset = "0x2F4EEE8", VA = "0x2F4EEE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public MB2_PackingAlgorithmEnum packingAlgorithm
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x2F4EF34", Offset = "0x2F4EF34", VA = "0x2F4EF34")]
			get
			{
				return default(MB2_PackingAlgorithmEnum);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2F4EF64", Offset = "0x2F4EF64", VA = "0x2F4EF64")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool meshBakerTexturePackerForcePowerOfTwo
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2F4EF9C", Offset = "0x2F4EF9C", VA = "0x2F4EF9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2F4EFE0", Offset = "0x2F4EFE0", VA = "0x2F4EFE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public List<ShaderTextureProperty> customShaderPropNames
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2F4F02C", Offset = "0x2F4F02C", VA = "0x2F4F02C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x2F4F05C", Offset = "0x2F4F05C", VA = "0x2F4F05C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool considerNonTextureProperties
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x2F4F094", Offset = "0x2F4F094", VA = "0x2F4F094")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x2F4F0D8", Offset = "0x2F4F0D8", VA = "0x2F4F0D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2F4F124", Offset = "0x2F4F124", VA = "0x2F4F124")]
		public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, [Optional] MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2F5020C", Offset = "0x2F5020C", VA = "0x2F5020C")]
		private static bool InterfaceFilter(Type typeObj, object criteriaObj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2F502AC", Offset = "0x2F502AC", VA = "0x2F502AC")]
		private void _LoadTextureBlenders()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2F50CFC", Offset = "0x2F50CFC", VA = "0x2F50CFC")]
		private bool _CollectPropertyNames(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2F4F1D0", Offset = "0x2F4F1D0", VA = "0x2F4F1D0")]
		private bool _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2F528B4", Offset = "0x2F528B4", VA = "0x2F528B4")]
		private bool __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2F5377C", Offset = "0x2F5377C", VA = "0x2F5377C")]
		private bool __Step1_CollectDistinctMatTexturesAndUsedObjects(List<GameObject> allObjsToMesh, List<Material> allowedMaterialsFilter, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface textureEditorMethods, List<MB_TexSet> distinctMaterialTextures, List<GameObject> usedObjsToMesh)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2F557C0", Offset = "0x2F557C0", VA = "0x2F557C0")]
		private int __Step2_CalculateIdealSizesForTexturesInAtlasAndPadding(List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor)
		{
			return default(int);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2F57D0C", Offset = "0x2F57D0C", VA = "0x2F57D0C")]
		private void __Step3_BuildAndSaveAtlasesAndStoreResults(ProgressUpdateDelegate progressInfo, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, int _padding, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2F6215C", Offset = "0x2F6215C", VA = "0x2F6215C")]
		private Rect[] __CreateAtlasesMBTexturePacker(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2F6425C", Offset = "0x2F6425C", VA = "0x2F6425C")]
		private Rect[] __CreateAtlasesMBTexturePackerFast(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x2F5FC90", Offset = "0x2F5FC90", VA = "0x2F5FC90")]
		private Rect[] __CreateAtlasesUnityTexturePacker(ProgressUpdateDelegate progressInfo, int numAtlases, List<MB_TexSet> distinctMaterialTextures, List<ShaderTextureProperty> texPropertyNames, bool[] allTexturesAreNullAndSameColor, Material resultMaterial, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, int _padding)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x2F6A6C8", Offset = "0x2F6A6C8", VA = "0x2F6A6C8")]
		private void _addWatermark(Texture2D[] texToPack)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x2F6ABE4", Offset = "0x2F6ABE4", VA = "0x2F6ABE4")]
		private Texture2D _addWatermark(Texture2D texToPack)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x2F6A6E0", Offset = "0x2F6A6E0", VA = "0x2F6A6E0")]
		private Texture2D _copyTexturesIntoAtlas(Texture2D[] texToPack, int padding, Rect[] rs, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x2F5FC04", Offset = "0x2F5FC04", VA = "0x2F5FC04")]
		private bool IsPowerOfTwo(int x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2F5C218", Offset = "0x2F5C218", VA = "0x2F5C218")]
		private void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures, bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x2F5F09C", Offset = "0x2F5F09C", VA = "0x2F5F09C")]
		private Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2F695F0", Offset = "0x2F695F0", VA = "0x2F695F0")]
		public Texture2D GetAdjustedForScaleAndOffset2(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2F6CEB8", Offset = "0x2F6CEB8", VA = "0x2F6CEB8")]
		internal static DRect GetSourceSamplingRect(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2F6A178", Offset = "0x2F6A178", VA = "0x2F6A178")]
		private Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2F67404", Offset = "0x2F67404", VA = "0x2F67404")]
		public void CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, bool _fixOutOfBoundsUVs, int maxSize, Color[][] atlasPixels, int atlasWidth, bool isNormalMap, [Optional] ProgressUpdateDelegate progressInfo)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2F68E80", Offset = "0x2F68E80", VA = "0x2F68E80")]
		public Texture2D _createTemporaryTexture(int w, int h, TextureFormat texFormat, bool mipMaps)
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2F6D114", Offset = "0x2F6D114", VA = "0x2F6D114")]
		internal Texture2D _createTextureCopy(Texture2D t)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2F6A074", Offset = "0x2F6A074", VA = "0x2F6A074")]
		private Texture2D _resizeTexture(Texture2D t, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2F534D4", Offset = "0x2F534D4", VA = "0x2F534D4")]
		private void _destroyTemporaryTextures()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2F6D344", Offset = "0x2F6D344", VA = "0x2F6D344")]
		public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2F52608", Offset = "0x2F52608", VA = "0x2F52608")]
		private TextureBlender FindMatchingTextureBlender(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2F66348", Offset = "0x2F66348", VA = "0x2F66348")]
		private void AdjustNonTextureProperties(Material mat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, bool considerTintColor, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2F69214", Offset = "0x2F69214", VA = "0x2F69214")]
		public static Color GetColorIfNoTexture(ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2F6FB64", Offset = "0x2F6FB64", VA = "0x2F6FB64")]
		private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2F5B27C", Offset = "0x2F5B27C", VA = "0x2F5B27C")]
		private float GetSubmeshArea(Mesh m, int submeshIdx)
		{
			return default(float);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2F6F984", Offset = "0x2F6F984", VA = "0x2F6F984")]
		private string PrintList(List<GameObject> gos)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2F6FF24", Offset = "0x2F6FF24", VA = "0x2F6FF24")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double width;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9B")]
		public double height;

		[Token(Token = "0x170000A4")]
		public Vector2 min
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x34BF3B8", Offset = "0x34BF3B8", VA = "0x34BF3B8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector2 max
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x34BF448", Offset = "0x34BF448", VA = "0x34BF448")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170000A6")]
		public Vector2 size
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x34BF510", Offset = "0x34BF510", VA = "0x34BF510")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x34BEF70", Offset = "0x34BEF70", VA = "0x34BEF70")]
		public DRect(Rect r)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x34BF080", Offset = "0x34BF080", VA = "0x34BF080")]
		public DRect(Vector2 o, Vector2 s)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x34BF1E8", Offset = "0x34BF1E8", VA = "0x34BF1E8")]
		public DRect(float xx, float yy, float w, float h)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x34BF278", Offset = "0x34BF278", VA = "0x34BF278")]
		public DRect(double xx, double yy, double w, double h)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x34BF2F8", Offset = "0x34BF2F8", VA = "0x34BF2F8")]
		public Rect GetRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x34BF5A0", Offset = "0x34BF5A0", VA = "0x34BF5A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x34BF7E0", Offset = "0x34BF7E0", VA = "0x34BF7E0")]
		public static bool operator ==(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x34BF914", Offset = "0x34BF914", VA = "0x34BF914")]
		public static bool operator !=(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x34BFA88", Offset = "0x34BFA88", VA = "0x34BFA88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x34BFCA8", Offset = "0x34BFCA8", VA = "0x34BFCA8")]
		public bool Encloses(DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x34C007C", Offset = "0x34C007C", VA = "0x34C007C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000EB")]
	public class MB3_UVTransformUtility
	{
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2F71CF0", Offset = "0x2F71CF0", VA = "0x2F71CF0")]
		public static float TransformX(DRect r, double x)
		{
			return default(float);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2F6CCC8", Offset = "0x2F6CCC8", VA = "0x2F6CCC8")]
		public static DRect CombineTransforms(ref DRect r1, ref DRect r2)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2F71DA8", Offset = "0x2F71DA8", VA = "0x2F71DA8")]
		public static Rect CombineTransforms(ref Rect r1, ref Rect r2)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2F6B564", Offset = "0x2F6B564", VA = "0x2F6B564")]
		public static DRect InverseTransform(ref DRect t)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2F6C814", Offset = "0x2F6C814", VA = "0x2F6C814")]
		public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
		{
			return default(DRect);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2F6B028", Offset = "0x2F6B028", VA = "0x2F6B028")]
		public static void InvertHierarchy(ref DRect uvRect, ref DRect matRect)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2F71FBC", Offset = "0x2F71FBC", VA = "0x2F71FBC")]
		public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2F7237C", Offset = "0x2F7237C", VA = "0x2F7237C")]
		public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2F727A0", Offset = "0x2F727A0", VA = "0x2F727A0")]
		internal static Vector2 TransformPoint(ref DRect r, Vector2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2F72920", Offset = "0x2F72920", VA = "0x2F72920")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
			public Rect uvRect;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4122430")]
			public bool hasOutOfBoundsUVs;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BB3")]
			private int submeshIdx;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
			private int[] vs;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x2F764CC", Offset = "0x2F764CC", VA = "0x2F764CC")]
			public bool isSame(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x2F767D4", Offset = "0x2F767D4", VA = "0x2F767D4")]
			public bool sharesVerts(MB_Triangle obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x2F762D8", Offset = "0x2F762D8", VA = "0x2F762D8")]
			public void Initialize(int[] ts, int idx, int sIdx)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x2F76238", Offset = "0x2F76238", VA = "0x2F76238")]
			public MB_Triangle()
			{
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2F6D1F8", Offset = "0x2F6D1F8", VA = "0x2F6D1F8")]
		public static Texture2D createTextureCopy(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2F74B7C", Offset = "0x2F74B7C", VA = "0x2F74B7C")]
		public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2F5A544", Offset = "0x2F5A544", VA = "0x2F5A544")]
		public static Material[] GetGOMaterials(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2F5A12C", Offset = "0x2F5A12C", VA = "0x2F5A12C")]
		public static Mesh GetMesh(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x2F74D64", Offset = "0x2F74D64", VA = "0x2F74D64")]
		public static Renderer GetRenderer(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2F7506C", Offset = "0x2F7506C", VA = "0x2F7506C")]
		public static void DisableRendererInSource(GameObject go)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2F75398", Offset = "0x2F75398", VA = "0x2F75398")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2F5B09C", Offset = "0x2F5B09C", VA = "0x2F5B09C")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2F75450", Offset = "0x2F75450", VA = "0x2F75450")]
		public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2F68FD4", Offset = "0x2F68FD4", VA = "0x2F68FD4")]
		public static void setSolidColor(Texture2D t, Color c)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2F6AC08", Offset = "0x2F6AC08", VA = "0x2F6AC08")]
		public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2F5B818", Offset = "0x2F5B818", VA = "0x2F5B818")]
		public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2F6F310", Offset = "0x2F6F310", VA = "0x2F6F310")]
		public static int doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2F76F74", Offset = "0x2F76F74", VA = "0x2F76F74")]
		public static bool GetBounds(GameObject go, out Bounds b)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2F68CE8", Offset = "0x2F68CE8", VA = "0x2F68CE8")]
		public static void Destroy(UnityEngine.Object o)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2F77600", Offset = "0x2F77600", VA = "0x2F77600")]
		public MB_Utility()
		{
		}
	}
}
namespace MiniJSON
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
				[Address(RVA = "0x2C60BE0", Offset = "0x2C60BE0", VA = "0x2C60BE0")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000E2")]
			private char NextChar
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x2C60788", Offset = "0x2C60788", VA = "0x2C60788")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x170000E3")]
			private string NextWord
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x2C608A8", Offset = "0x2C608A8", VA = "0x2C608A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0x2C5F228", Offset = "0x2C5F228", VA = "0x2C5F228")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x2C5EC54", Offset = "0x2C5EC54", VA = "0x2C5EC54")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x2C5EE20", Offset = "0x2C5EE20", VA = "0x2C5EE20")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x2C5E898", Offset = "0x2C5E898", VA = "0x2C5E898")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x2C5EF3C", Offset = "0x2C5EF3C", VA = "0x2C5EF3C", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x2C5EF98", Offset = "0x2C5EF98", VA = "0x2C5EF98")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x2C600A0", Offset = "0x2C600A0", VA = "0x2C600A0")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x2C5EED8", Offset = "0x2C5EED8", VA = "0x2C5EED8")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x2C602C8", Offset = "0x2C602C8", VA = "0x2C602C8")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x2C5F940", Offset = "0x2C5F940", VA = "0x2C5F940")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x2C6056C", Offset = "0x2C6056C", VA = "0x2C6056C")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x2C60A44", Offset = "0x2C60A44", VA = "0x2C60A44")]
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
			[Address(RVA = "0x2C60D00", Offset = "0x2C60D00", VA = "0x2C60D00")]
			private Serializer()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x2C5EB60", Offset = "0x2C5EB60", VA = "0x2C5EB60")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x2C60DA8", Offset = "0x2C60DA8", VA = "0x2C60DA8")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x2C61B3C", Offset = "0x2C61B3C", VA = "0x2C61B3C")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x2C6174C", Offset = "0x2C6174C", VA = "0x2C6174C")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x2C61144", Offset = "0x2C61144", VA = "0x2C61144")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x2C6201C", Offset = "0x2C6201C", VA = "0x2C6201C")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2C5E818", Offset = "0x2C5E818", VA = "0x2C5E818")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2C5EB20", Offset = "0x2C5EB20", VA = "0x2C5EB20")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BCB")]
		private ParseHandler m_ParseHandler;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x323D8FC", Offset = "0x323D8FC", VA = "0x323D8FC")]
		public HeatmapDataParser()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x323D92C", Offset = "0x323D92C", VA = "0x323D92C")]
		public void LoadData(string path, ParseHandler handler, bool asResource = false)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x323DAE0", Offset = "0x323DAE0", VA = "0x323DAE0")]
		protected void LoadStream(string path)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x323D9FC", Offset = "0x323D9FC", VA = "0x323D9FC")]
		protected void LoadResource(string path)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x323DD7C", Offset = "0x323DD7C", VA = "0x323DD7C")]
		protected void ConsumeHeatmapData(string text)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class HeatmapEvent
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0000")]
		private static Dictionary<string, object> s_Dictionary;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x3FD1B60", Offset = "0x3FD1B60", VA = "0x3FD1B60")]
		public static AnalyticsResult Send(string eventName, Vector3 v, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x3FD2588", Offset = "0x3FD2588", VA = "0x3FD2588")]
		public static AnalyticsResult Send(string eventName, Vector3 v, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x3FD284C", Offset = "0x3FD284C", VA = "0x3FD284C")]
		public static AnalyticsResult Send(string eventName, Vector3 v, float time, float rotation, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x3FD2A3C", Offset = "0x3FD2A3C", VA = "0x3FD2A3C")]
		public static AnalyticsResult Send(string eventName, Transform trans, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x3FD2E98", Offset = "0x3FD2E98", VA = "0x3FD2E98")]
		public static AnalyticsResult Send(string eventName, Transform trans, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x3FD30F4", Offset = "0x3FD30F4", VA = "0x3FD30F4")]
		public static AnalyticsResult Send(string eventName, Vector3 v, Vector3 v1, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x3FD34B0", Offset = "0x3FD34B0", VA = "0x3FD34B0")]
		public static AnalyticsResult Send(string eventName, Vector3 v, Vector3 v1, float time, [Optional] Dictionary<string, object> options)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x3FD241C", Offset = "0x3FD241C", VA = "0x3FD241C")]
		protected static AnalyticsResult Commit(string eventName)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x3FD1CB0", Offset = "0x3FD1CB0", VA = "0x3FD1CB0")]
		protected static void AddXY(float x, float y)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x3FD1E80", Offset = "0x3FD1E80", VA = "0x3FD1E80")]
		protected static void AddZ(float z)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x3FD26F0", Offset = "0x3FD26F0", VA = "0x3FD26F0")]
		protected static void AddTime(float time)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x3FD2C80", Offset = "0x3FD2C80", VA = "0x3FD2C80")]
		protected static void AddRotation(Vector3 r)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x3FD3298", Offset = "0x3FD3298", VA = "0x3FD3298")]
		protected static void AddDestination(Vector3 v)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x3FD1FDC", Offset = "0x3FD1FDC", VA = "0x3FD1FDC")]
		protected static void AddOptions(Dictionary<string, object> options)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x3FD3674", Offset = "0x3FD3674", VA = "0x3FD3674")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BCB")]
		public Vector3 rotation;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBFFF0")]
		public Vector3 destination;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4122490")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCD06F0", Offset = "0xCD06F0")]
		void UpdateColors(Color[] colors);

		[Token(Token = "0x6000797")]
		void UpdateGradient(Gradient gradient);

		[Token(Token = "0x6000798")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCD072C", Offset = "0xCD072C")]
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
