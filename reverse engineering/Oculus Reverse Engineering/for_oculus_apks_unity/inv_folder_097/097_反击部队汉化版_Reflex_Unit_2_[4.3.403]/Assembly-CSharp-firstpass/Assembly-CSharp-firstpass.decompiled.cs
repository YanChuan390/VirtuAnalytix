using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class VDColorHandler : VDColorHandlerBase
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1036D18", Offset = "0x1036D18", VA = "0x1036D18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1036FDC", Offset = "0x1036FDC", VA = "0x1036FDC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1037020", Offset = "0x1037020", VA = "0x1037020")]
	public void SetColors()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1036DB0", Offset = "0x1036DB0", VA = "0x1036DB0")]
	public void SetMesh()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10370E4", Offset = "0x10370E4", VA = "0x10370E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1037154", Offset = "0x1037154", VA = "0x1037154")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x103725C", Offset = "0x103725C", VA = "0x103725C")]
	public VDColorHandler()
	{
	}
}
[Token(Token = "0x2000003")]
public class VDColorHandlerBase : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Color32[] colors;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Color32[] tempColors;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Mesh coloredMesh;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Mesh originalMesh;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1037260", Offset = "0x1037260", VA = "0x1037260")]
	public VDColorHandlerBase()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class VDSampler : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D tex;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color32[] lum;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10372D0", Offset = "0x10372D0", VA = "0x10372D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1037374", Offset = "0x1037374", VA = "0x1037374")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1037558", Offset = "0x1037558", VA = "0x1037558")]
	public VDSampler()
	{
	}
}
[Token(Token = "0x2000005")]
public class VertexDirtSettingsStruct
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string occluderShader;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float samplingBias;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float samplingDistance;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float samplingAngle;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool edgeSmooth;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool invertNormals;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float edgeSmoothBias;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CameraClearFlags skyMode;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool disableOccluders;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color customSkyColor;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Color customShadowColor;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool useCustomSkyColor;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool useCustomShadowColor;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool useSkyCube;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material skyCube;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int blendModeIndex;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int colorOutputIndex;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int luminanceOutputIndex;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int bakeLayerMask;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1038FF8", Offset = "0x1038FF8", VA = "0x1038FF8")]
	public VertexDirtSettingsStruct()
	{
	}
}
[Token(Token = "0x2000006")]
public static class VertexDirt
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector3[] v;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector3[] n;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Color32[] c;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static VertexSample vertexSample;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int sampleWidth;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int sampleHeight;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int rgbBakingMode;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static int alphaBakingMode;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static VertexDirtSettingsStruct settings;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1037560", Offset = "0x1037560", VA = "0x1037560")]
	public static void Dirt(Transform[] sels)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1037C28", Offset = "0x1037C28", VA = "0x1037C28")]
	public static void UpdateShaderVariables()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1037DAC", Offset = "0x1037DAC", VA = "0x1037DAC")]
	private static void PrepareVertices(Transform go)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10381F4", Offset = "0x10381F4", VA = "0x10381F4")]
	public static void PrepareColors()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1038284", Offset = "0x1038284", VA = "0x1038284")]
	private static void SmoothVertices()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1038728", Offset = "0x1038728", VA = "0x1038728")]
	private static void CalcColors(GameObject camGO, Camera cam)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1037480", Offset = "0x1037480", VA = "0x1037480")]
	public static void SetColorSample(Color32 c)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1038EA4", Offset = "0x1038EA4", VA = "0x1038EA4")]
	public static Color ColorAndLuminance(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1038ED4", Offset = "0x1038ED4", VA = "0x1038ED4")]
	public static Color32 MultiplyColor32(Color c0, Color c1)
	{
		return default(Color32);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1038B80", Offset = "0x1038B80", VA = "0x1038B80")]
	private static void ApplyColors(Transform go)
	{
	}
}
[Token(Token = "0x2000007")]
public class VertexSample
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color32 color;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int index;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isCalulated;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1038FA8", Offset = "0x1038FA8", VA = "0x1038FA8")]
	public VertexSample()
	{
	}
}
[Token(Token = "0x2000008")]
public class CommonOnScreenControl : MonoBehaviour
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x102B0E4", Offset = "0x102B0E4", VA = "0x102B0E4")]
	public CommonOnScreenControl()
	{
	}
}
namespace CnControls
{
	[Token(Token = "0x2000009")]
	public class CnInputManager
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CnInputManager _instance;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, List<VirtualAxis>> _virtualAxisDictionary;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<VirtualButton>> _virtualButtonsDictionary;

		[Token(Token = "0x17000001")]
		private static CnInputManager Instance
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1028BE4", Offset = "0x1028BE4", VA = "0x1028BE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static int TouchCount
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1028CEC", Offset = "0x1028CEC", VA = "0x1028CEC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1028C54", Offset = "0x1028C54", VA = "0x1028C54")]
		private CnInputManager()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1028CF4", Offset = "0x1028CF4", VA = "0x1028CF4")]
		public static Touch GetTouch(int touchIndex)
		{
			return default(Touch);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1028CFC", Offset = "0x1028CFC", VA = "0x1028CFC")]
		public static float GetAxis(string axisName)
		{
			return default(float);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1028E04", Offset = "0x1028E04", VA = "0x1028E04")]
		public static float GetAxisRaw(string axisName)
		{
			return default(float);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1028D04", Offset = "0x1028D04", VA = "0x1028D04")]
		private static float GetAxis(string axisName, bool isRaw)
		{
			return default(float);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1029098", Offset = "0x1029098", VA = "0x1029098")]
		public static bool GetButton(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1029134", Offset = "0x1029134", VA = "0x1029134")]
		public static bool GetButtonDown(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x102928C", Offset = "0x102928C", VA = "0x102928C")]
		public static bool GetButtonUp(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x10293E4", Offset = "0x10293E4", VA = "0x10293E4")]
		public static bool GetPointerInside(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1028E0C", Offset = "0x1028E0C", VA = "0x1028E0C")]
		public static bool AxisExists(string axisName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1028F98", Offset = "0x1028F98", VA = "0x1028F98")]
		public static bool ButtonExists(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1029528", Offset = "0x1029528", VA = "0x1029528")]
		public static void RegisterVirtualAxis(VirtualAxis virtualAxis)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x102962C", Offset = "0x102962C", VA = "0x102962C")]
		public static void UnregisterVirtualAxis(VirtualAxis virtualAxis)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1029754", Offset = "0x1029754", VA = "0x1029754")]
		public static void RegisterVirtualButton(VirtualButton virtualButton)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1029858", Offset = "0x1029858", VA = "0x1029858")]
		public static void UnregisterVirtualButton(VirtualButton virtualButton)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1028E70", Offset = "0x1028E70", VA = "0x1028E70")]
		private static float GetVirtualAxisValue(List<VirtualAxis> virtualAxisList, string axisName, bool isRaw)
		{
			return default(float);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x10291D0", Offset = "0x10291D0", VA = "0x10291D0")]
		private static bool GetAnyVirtualButtonDown(List<VirtualButton> virtualButtons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1029328", Offset = "0x1029328", VA = "0x1029328")]
		private static bool GetAnyVirtualButtonUp(List<VirtualButton> virtualButtons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1029468", Offset = "0x1029468", VA = "0x1029468")]
		private static bool GetAnyVirtualPointerInside(List<VirtualButton> virtualButtons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1028FFC", Offset = "0x1028FFC", VA = "0x1028FFC")]
		private static bool GetAnyVirtualButton(List<VirtualButton> virtualButtons)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000A")]
	public class VirtualAxis
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF618", Offset = "0x6DF618")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF628", Offset = "0x6DF628")]
		private float <Value>k__BackingField;

		[Token(Token = "0x17000003")]
		public string Name
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x102B0A0", Offset = "0x102B0A0", VA = "0x102B0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFDB8", Offset = "0x6DFDB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x102B0A8", Offset = "0x102B0A8", VA = "0x102B0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFDC8", Offset = "0x6DFDC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float Value
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x102B0B0", Offset = "0x102B0B0", VA = "0x102B0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFDD8", Offset = "0x6DFDD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x102B0B8", Offset = "0x102B0B8", VA = "0x102B0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFDE8", Offset = "0x6DFDE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1029DD0", Offset = "0x1029DD0", VA = "0x1029DD0")]
		public VirtualAxis(string name)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class VirtualButton
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF638", Offset = "0x6DF638")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF648", Offset = "0x6DF648")]
		private bool <IsPressed>k__BackingField;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _lastPressedFrame;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _lastReleasedFrame;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _lastExitFrame;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _lastEnterFrame;

		[Token(Token = "0x17000005")]
		public string Name
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x102B0C0", Offset = "0x102B0C0", VA = "0x102B0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFDF8", Offset = "0x6DFDF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x102B0C8", Offset = "0x102B0C8", VA = "0x102B0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE08", Offset = "0x6DFE08")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool IsPressed
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x102B0D0", Offset = "0x102B0D0", VA = "0x102B0D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE18", Offset = "0x6DFE18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x102B0D8", Offset = "0x102B0D8", VA = "0x102B0D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE28", Offset = "0x6DFE28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool GetButton
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1029A38", Offset = "0x1029A38", VA = "0x1029A38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool GetButtonDown
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1029970", Offset = "0x1029970", VA = "0x1029970")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public bool GetButtonUp
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x10299B0", Offset = "0x10299B0", VA = "0x10299B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool GetPointerInside
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x10299F0", Offset = "0x10299F0", VA = "0x10299F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x102A5A4", Offset = "0x102A5A4", VA = "0x102A5A4")]
		public VirtualButton(string name)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x102A6B8", Offset = "0x102A6B8", VA = "0x102A6B8")]
		public void Press()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x102A618", Offset = "0x102A618", VA = "0x102A618")]
		public void Release()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x102A72C", Offset = "0x102A72C", VA = "0x102A72C")]
		public void Exit()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x102A798", Offset = "0x102A798", VA = "0x102A798")]
		public void Enter()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class Dpad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DpadAxis[] DpadAxis;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF658", Offset = "0x6DF658")]
		private Camera <CurrentEventCamera>k__BackingField;

		[Token(Token = "0x1700000B")]
		public Camera CurrentEventCamera
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1029A40", Offset = "0x1029A40", VA = "0x1029A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE38", Offset = "0x6DFE38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1029A48", Offset = "0x1029A48", VA = "0x1029A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE48", Offset = "0x6DFE48")]
			set
			{
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1029A50", Offset = "0x1029A50", VA = "0x1029A50", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1029C18", Offset = "0x1029C18", VA = "0x1029C18", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1029CCC", Offset = "0x1029CCC", VA = "0x1029CCC")]
		public Dpad()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class DpadAxis : MonoBehaviour
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AxisName;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AxisMultiplier;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF668", Offset = "0x6DF668")]
		private RectTransform <RectTransform>k__BackingField;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF678", Offset = "0x6DF678")]
		private int <LastFingerId>k__BackingField;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VirtualAxis _virtualAxis;

		[Token(Token = "0x1700000C")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1029CD4", Offset = "0x1029CD4", VA = "0x1029CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE58", Offset = "0x6DFE58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1029CDC", Offset = "0x1029CDC", VA = "0x1029CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE68", Offset = "0x6DFE68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int LastFingerId
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1029CE4", Offset = "0x1029CE4", VA = "0x1029CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE78", Offset = "0x6DFE78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1029CEC", Offset = "0x1029CEC", VA = "0x1029CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE88", Offset = "0x6DFE88")]
			set
			{
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1029CF4", Offset = "0x1029CF4", VA = "0x1029CF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1029D4C", Offset = "0x1029D4C", VA = "0x1029D4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1029DFC", Offset = "0x1029DFC", VA = "0x1029DFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1029B78", Offset = "0x1029B78", VA = "0x1029B78")]
		public void Press(Vector2 screenPoint, Camera eventCamera, int pointerId)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1029C9C", Offset = "0x1029C9C", VA = "0x1029C9C")]
		public void TryRelease(int pointerId)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1029E04", Offset = "0x1029E04", VA = "0x1029E04")]
		public DpadAxis()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class SensitiveJoystick : SimpleJoystick
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationCurve SensitivityCurve;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1029E90", Offset = "0x1029E90", VA = "0x1029E90", Slot = "9")]
		public override void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x102A340", Offset = "0x102A340", VA = "0x102A340")]
		public SensitiveJoystick()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class SimpleButton : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler, IPointerExitHandler, IPointerEnterHandler
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool cancelOnExit;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ButtonName;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VirtualButton _virtualButton;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x102A51C", Offset = "0x102A51C", VA = "0x102A51C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x102A5DC", Offset = "0x102A5DC", VA = "0x102A5DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x102A644", Offset = "0x102A644", VA = "0x102A644", Slot = "4")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x102A678", Offset = "0x102A678", VA = "0x102A678", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x102A6F4", Offset = "0x102A6F4", VA = "0x102A6F4", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x102A754", Offset = "0x102A754", VA = "0x102A754", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x102A7CC", Offset = "0x102A7CC", VA = "0x102A7CC")]
		public SimpleButton()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[Flags]
	public enum ControlMovementDirection
	{
		[Token(Token = "0x400003D")]
		Horizontal = 1,
		[Token(Token = "0x400003E")]
		Vertical = 2,
		[Token(Token = "0x400003F")]
		Both = 3
	}
	[Token(Token = "0x2000011")]
	public class SimpleJoystick : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF688", Offset = "0x6DF688")]
		private Camera <CurrentEventCamera>k__BackingField;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MovementRange;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string HorizontalAxisName;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string VerticalAxisName;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string StickButtonName;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6DF698", Offset = "0x6DF698")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF698", Offset = "0x6DF698")]
		public bool HideOnRelease;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF6E8", Offset = "0x6DF6E8")]
		public bool MoveBase;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF720", Offset = "0x6DF720")]
		public bool SnapsToFinger;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF758", Offset = "0x6DF758")]
		public ControlMovementDirection JoystickMoveAxis;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF790", Offset = "0x6DF790")]
		public Image JoystickBase;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF7C8", Offset = "0x6DF7C8")]
		public Image Stick;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF800", Offset = "0x6DF800")]
		public RectTransform TouchZone;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool releaseWhenLeave;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool touched;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector2 _initialStickPosition;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 _intermediateStickPosition;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector2 _initialBasePosition;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _baseTransform;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _stickTransform;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _oneOverMovementRange;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected VirtualAxis HorizintalAxis;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected VirtualAxis VerticalAxis;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected VirtualButton StickButton;

		[Token(Token = "0x1700000E")]
		public Camera CurrentEventCamera
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x102A824", Offset = "0x102A824", VA = "0x102A824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFE98", Offset = "0x6DFE98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x102A82C", Offset = "0x102A82C", VA = "0x102A82C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFEA8", Offset = "0x6DFEA8")]
			set
			{
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x102A834", Offset = "0x102A834", VA = "0x102A834")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x102A984", Offset = "0x102A984", VA = "0x102A984")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x102AAC4", Offset = "0x102AAC4", VA = "0x102AAC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1029F9C", Offset = "0x1029F9C", VA = "0x1029F9C", Slot = "9")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x102AB28", Offset = "0x102AB28", VA = "0x102AB28", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x102ABC4", Offset = "0x102ABC4", VA = "0x102ABC4", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x102A920", Offset = "0x102A920", VA = "0x102A920")]
		private void Hide(bool isHidden)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x102AD4C", Offset = "0x102AD4C", VA = "0x102AD4C", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x102AD58", Offset = "0x102AD58", VA = "0x102AD58", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x102A48C", Offset = "0x102A48C", VA = "0x102A48C")]
		public SimpleJoystick()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Touchpad : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF838", Offset = "0x6DF838")]
		private Camera <CurrentEventCamera>k__BackingField;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string HorizontalAxisName;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string VerticalAxisName;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreserveInertia;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Friction;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VirtualAxis _horizintalAxis;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VirtualAxis _verticalAxis;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _lastDragFrameNumber;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _isCurrentlyTweaking;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF848", Offset = "0x6DF848")]
		public ControlMovementDirection ControlMoveAxis;

		[Token(Token = "0x1700000F")]
		public Camera CurrentEventCamera
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x102AD60", Offset = "0x102AD60", VA = "0x102AD60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFEB8", Offset = "0x6DFEB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x102AD68", Offset = "0x102AD68", VA = "0x102AD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFEC8", Offset = "0x6DFEC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x102AD70", Offset = "0x102AD70", VA = "0x102AD70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x102AE28", Offset = "0x102AE28", VA = "0x102AE28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x102AE50", Offset = "0x102AE50", VA = "0x102AE50", Slot = "7")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x102AEB4", Offset = "0x102AEB4", VA = "0x102AEB4", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x102AEEC", Offset = "0x102AEEC", VA = "0x102AEEC", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x102AF00", Offset = "0x102AF00", VA = "0x102AF00")]
		private void Update()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x102B020", Offset = "0x102B020", VA = "0x102B020")]
		public Touchpad()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class EmptyGraphic : Graphic
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1029E0C", Offset = "0x1029E0C", VA = "0x1029E0C", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1029E28", Offset = "0x1029E28", VA = "0x1029E28")]
		public EmptyGraphic()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Token(Token = "0x2000014")]
	public static class Extensions
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x102B438", Offset = "0x102B438", VA = "0x102B438")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x102B814", Offset = "0x102B814", VA = "0x102B814")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x102BC0C", Offset = "0x102BC0C", VA = "0x102BC0C")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x102BC78", Offset = "0x102BC78", VA = "0x102BC78")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x102BDCC", Offset = "0x102BDCC", VA = "0x102BDCC")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x102C174", Offset = "0x102C174", VA = "0x102C174")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x102C444", Offset = "0x102C444", VA = "0x102C444")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000015")]
	public class FriendInfo
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF880", Offset = "0x6DF880")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF890", Offset = "0x6DF890")]
		private bool <IsOnline>k__BackingField;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF8A0", Offset = "0x6DF8A0")]
		private string <Room>k__BackingField;

		[Token(Token = "0x17000010")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E0548", Offset = "0x6E0548")]
		public string Name
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x102C4A0", Offset = "0x102C4A0", VA = "0x102C4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public string UserId
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x102C4A8", Offset = "0x102C4A8", VA = "0x102C4A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFF48", Offset = "0x6DFF48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x102C4B0", Offset = "0x102C4B0", VA = "0x102C4B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFF58", Offset = "0x6DFF58")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsOnline
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x102C4B8", Offset = "0x102C4B8", VA = "0x102C4B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFF68", Offset = "0x6DFF68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x102C4C0", Offset = "0x102C4C0", VA = "0x102C4C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFF78", Offset = "0x6DFF78")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public string Room
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x102C4CC", Offset = "0x102C4CC", VA = "0x102C4CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFF88", Offset = "0x6DFF88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x102C4D4", Offset = "0x102C4D4", VA = "0x102C4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFF98", Offset = "0x6DFF98")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool IsInRoom
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x102C4DC", Offset = "0x102C4DC", VA = "0x102C4DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x102C508", Offset = "0x102C508", VA = "0x102C508", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x102C5A8", Offset = "0x102C5A8", VA = "0x102C5A8")]
		public FriendInfo()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public enum ClientState
	{
		[Token(Token = "0x4000065")]
		PeerCreated = 0,
		[Token(Token = "0x4000066")]
		Authenticating = 1,
		[Token(Token = "0x4000067")]
		Authenticated = 2,
		[Token(Token = "0x4000068")]
		JoinedLobby = 3,
		[Token(Token = "0x4000069")]
		DisconnectingFromMasterserver = 4,
		[Token(Token = "0x400006A")]
		ConnectingToGameserver = 5,
		[Token(Token = "0x400006B")]
		ConnectedToGameserver = 6,
		[Token(Token = "0x400006C")]
		Joining = 7,
		[Token(Token = "0x400006D")]
		Joined = 8,
		[Token(Token = "0x400006E")]
		Leaving = 9,
		[Token(Token = "0x400006F")]
		DisconnectingFromGameserver = 10,
		[Token(Token = "0x4000070")]
		ConnectingToMasterserver = 11,
		[Token(Token = "0x4000071")]
		Disconnecting = 12,
		[Token(Token = "0x4000072")]
		Disconnected = 13,
		[Token(Token = "0x4000073")]
		ConnectedToMasterserver = 14,
		[Token(Token = "0x4000074")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DF8B0", Offset = "0x6DF8B0")]
		ConnectedToMaster = 14,
		[Token(Token = "0x4000075")]
		ConnectingToNameServer = 15,
		[Token(Token = "0x4000076")]
		ConnectedToNameServer = 16,
		[Token(Token = "0x4000077")]
		DisconnectingFromNameServer = 17
	}
	[Token(Token = "0x2000017")]
	internal enum JoinType
	{
		[Token(Token = "0x4000079")]
		CreateRoom,
		[Token(Token = "0x400007A")]
		JoinRoom,
		[Token(Token = "0x400007B")]
		JoinRandomRoom,
		[Token(Token = "0x400007C")]
		JoinOrCreateRoom
	}
	[Token(Token = "0x2000018")]
	public enum DisconnectCause
	{
		[Token(Token = "0x400007E")]
		None,
		[Token(Token = "0x400007F")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x4000080")]
		ExceptionOnConnect,
		[Token(Token = "0x4000081")]
		DisconnectByServer,
		[Token(Token = "0x4000082")]
		TimeoutDisconnect,
		[Token(Token = "0x4000083")]
		Exception,
		[Token(Token = "0x4000084")]
		InvalidAuthentication,
		[Token(Token = "0x4000085")]
		MaxCcuReached,
		[Token(Token = "0x4000086")]
		InvalidRegion,
		[Token(Token = "0x4000087")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x4000088")]
		CustomAuthenticationFailed,
		[Token(Token = "0x4000089")]
		DisconnectByServerLogic,
		[Token(Token = "0x400008A")]
		AuthenticationTicketExpired
	}
	[Token(Token = "0x2000019")]
	public enum ServerConnection
	{
		[Token(Token = "0x400008C")]
		MasterServer,
		[Token(Token = "0x400008D")]
		GameServer,
		[Token(Token = "0x400008E")]
		NameServer
	}
	[Token(Token = "0x200001A")]
	public enum EncryptionMode
	{
		[Token(Token = "0x4000090")]
		PayloadEncryption = 0,
		[Token(Token = "0x4000091")]
		DatagramEncryption = 10,
		[Token(Token = "0x4000092")]
		DatagramEncryptionRandomSequence = 11
	}
	[Token(Token = "0x200001B")]
	public static class EncryptionDataParameters
	{
		[Token(Token = "0x4000093")]
		public const byte Mode = 0;

		[Token(Token = "0x4000094")]
		public const byte Secret1 = 1;

		[Token(Token = "0x4000095")]
		public const byte Secret2 = 2;
	}
	[Token(Token = "0x200001C")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadBalancingPeer loadBalancingPeer;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF8E8", Offset = "0x6DF8E8")]
		private string <AppVersion>k__BackingField;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF8F8", Offset = "0x6DF8F8")]
		private string <AppId>k__BackingField;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF908", Offset = "0x6DF908")]
		private AuthenticationValues <AuthValues>k__BackingField;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AuthModeOption AuthMode;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EncryptionMode EncryptionMode;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ConnectionProtocol ExpectedProtocol;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF918", Offset = "0x6DF918")]
		private bool <IsUsingNameServer>k__BackingField;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string NameServerHost;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string NameServerHttp;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF928", Offset = "0x6DF928")]
		private string <MasterServerAddress>k__BackingField;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF938", Offset = "0x6DF938")]
		private string <GameServerAddress>k__BackingField;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF948", Offset = "0x6DF948")]
		private ServerConnection <Server>k__BackingField;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ClientState state;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF988", Offset = "0x6DF988")]
		private DisconnectCause <DisconnectedCause>k__BackingField;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool inLobby;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF998", Offset = "0x6DF998")]
		private TypedLobby <CurrentLobby>k__BackingField;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool autoJoinLobby;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool EnableLobbyStatistics;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF9A8", Offset = "0x6DF9A8")]
		private Player <LocalPlayer>k__BackingField;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Room CurrentRoom;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF9B8", Offset = "0x6DF9B8")]
		private int <PlayersOnMasterCount>k__BackingField;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF9C8", Offset = "0x6DF9C8")]
		private int <PlayersInRoomsCount>k__BackingField;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF9D8", Offset = "0x6DF9D8")]
		private int <RoomsCount>k__BackingField;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private JoinType lastJoinType;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool didAuthenticate;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF9E8", Offset = "0x6DF9E8")]
		private List<FriendInfo> <FriendList>k__BackingField;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string[] friendListRequested;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int friendListTimestamp;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isFetchingFriendList;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF9F8", Offset = "0x6DF9F8")]
		private string[] <AvailableRegions>k__BackingField;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFA08", Offset = "0x6DFA08")]
		private string[] <AvailableRegionsServers>k__BackingField;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFA18", Offset = "0x6DFA18")]
		private string <CloudRegion>k__BackingField;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] encryptionSecret;

		[Token(Token = "0x17000015")]
		public string AppVersion
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x102C5B8", Offset = "0x102C5B8", VA = "0x102C5B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFFA8", Offset = "0x6DFFA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x102C5C0", Offset = "0x102C5C0", VA = "0x102C5C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFFB8", Offset = "0x6DFFB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public string AppId
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x102C5C8", Offset = "0x102C5C8", VA = "0x102C5C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFFC8", Offset = "0x6DFFC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x102C5D0", Offset = "0x102C5D0", VA = "0x102C5D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFFD8", Offset = "0x6DFFD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x102C5D8", Offset = "0x102C5D8", VA = "0x102C5D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFFE8", Offset = "0x6DFFE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x102C5E0", Offset = "0x102C5E0", VA = "0x102C5E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFFF8", Offset = "0x6DFFF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public ConnectionProtocol TransportProtocol
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x102C5E8", Offset = "0x102C5E8", VA = "0x102C5E8")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x102C604", Offset = "0x102C604", VA = "0x102C604")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x102C718", Offset = "0x102C718", VA = "0x102C718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private string TokenForInit
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x102C734", Offset = "0x102C734", VA = "0x102C734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public bool IsUsingNameServer
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x102C754", Offset = "0x102C754", VA = "0x102C754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0008", Offset = "0x6E0008")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x102C75C", Offset = "0x102C75C", VA = "0x102C75C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0018", Offset = "0x6E0018")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public string NameServerAddress
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x102C768", Offset = "0x102C768", VA = "0x102C768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public string CurrentServerAddress
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x102C8F8", Offset = "0x102C8F8", VA = "0x102C8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public string MasterServerAddress
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x102C914", Offset = "0x102C914", VA = "0x102C914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0028", Offset = "0x6E0028")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x102C91C", Offset = "0x102C91C", VA = "0x102C91C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0038", Offset = "0x6E0038")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public string GameServerAddress
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x102C924", Offset = "0x102C924", VA = "0x102C924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0048", Offset = "0x6E0048")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x102C92C", Offset = "0x102C92C", VA = "0x102C92C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0058", Offset = "0x6E0058")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public ServerConnection Server
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x102C934", Offset = "0x102C934", VA = "0x102C934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0068", Offset = "0x6E0068")]
			get
			{
				return default(ServerConnection);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x102C93C", Offset = "0x102C93C", VA = "0x102C93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0078", Offset = "0x6E0078")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public ClientState State
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x102C944", Offset = "0x102C944", VA = "0x102C944")]
			get
			{
				return default(ClientState);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x102C94C", Offset = "0x102C94C", VA = "0x102C94C")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool IsConnected
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x102C9C4", Offset = "0x102C9C4", VA = "0x102C9C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public bool IsConnectedAndReady
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x102C9F0", Offset = "0x102C9F0", VA = "0x102C9F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public DisconnectCause DisconnectedCause
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x102CDFC", Offset = "0x102CDFC", VA = "0x102CDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E00E8", Offset = "0x6E00E8")]
			get
			{
				return default(DisconnectCause);
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x102CE04", Offset = "0x102CE04", VA = "0x102CE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E00F8", Offset = "0x6E00F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public TypedLobby CurrentLobby
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x102CE0C", Offset = "0x102CE0C", VA = "0x102CE0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0108", Offset = "0x6E0108")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x102CE14", Offset = "0x102CE14", VA = "0x102CE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0118", Offset = "0x6E0118")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool AutoJoinLobby
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x102CE1C", Offset = "0x102CE1C", VA = "0x102CE1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x102CE24", Offset = "0x102CE24", VA = "0x102CE24")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x102CE30", Offset = "0x102CE30", VA = "0x102CE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x102CE38", Offset = "0x102CE38", VA = "0x102CE38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Player LocalPlayer
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x102CE40", Offset = "0x102CE40", VA = "0x102CE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0128", Offset = "0x6E0128")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x102CE48", Offset = "0x102CE48", VA = "0x102CE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0138", Offset = "0x6E0138")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string NickName
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x102CE50", Offset = "0x102CE50", VA = "0x102CE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x102CE6C", Offset = "0x102CE6C", VA = "0x102CE6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public string UserId
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x102CEF4", Offset = "0x102CEF4", VA = "0x102CEF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x102CF0C", Offset = "0x102CF0C", VA = "0x102CF0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int PlayersOnMasterCount
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x102CF94", Offset = "0x102CF94", VA = "0x102CF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0148", Offset = "0x6E0148")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x102CF9C", Offset = "0x102CF9C", VA = "0x102CF9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0158", Offset = "0x6E0158")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x102CFA4", Offset = "0x102CFA4", VA = "0x102CFA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0168", Offset = "0x6E0168")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x102CFAC", Offset = "0x102CFAC", VA = "0x102CFAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0178", Offset = "0x6E0178")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public int RoomsCount
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x102CFB4", Offset = "0x102CFB4", VA = "0x102CFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0188", Offset = "0x6E0188")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x102CFBC", Offset = "0x102CFBC", VA = "0x102CFBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0198", Offset = "0x6E0198")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public List<FriendInfo> FriendList
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x102CFC4", Offset = "0x102CFC4", VA = "0x102CFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E01A8", Offset = "0x6E01A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x102CFCC", Offset = "0x102CFCC", VA = "0x102CFCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E01B8", Offset = "0x6E01B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int FriendListAge
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x102CFD4", Offset = "0x102CFD4", VA = "0x102CFD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x102D018", Offset = "0x102D018", VA = "0x102D018")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public string[] AvailableRegions
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x102D044", Offset = "0x102D044", VA = "0x102D044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E01C8", Offset = "0x6E01C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x102D04C", Offset = "0x102D04C", VA = "0x102D04C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E01D8", Offset = "0x6E01D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public string[] AvailableRegionsServers
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x102D054", Offset = "0x102D054", VA = "0x102D054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E01E8", Offset = "0x6E01E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x102D05C", Offset = "0x102D05C", VA = "0x102D05C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E01F8", Offset = "0x6E01F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public string CloudRegion
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x102D064", Offset = "0x102D064", VA = "0x102D064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0208", Offset = "0x6E0208")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x102D06C", Offset = "0x102D06C", VA = "0x102D06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0218", Offset = "0x6E0218")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x102CA24", Offset = "0x102CA24", VA = "0x102CA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0088", Offset = "0x6E0088")]
			add
			{
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x102CAC8", Offset = "0x102CAC8", VA = "0x102CAC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0098", Offset = "0x6E0098")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<EventData> OnEventAction
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x102CB6C", Offset = "0x102CB6C", VA = "0x102CB6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E00A8", Offset = "0x6E00A8")]
			add
			{
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x102CC10", Offset = "0x102CC10", VA = "0x102CC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E00B8", Offset = "0x6E00B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x102CCB4", Offset = "0x102CCB4", VA = "0x102CCB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E00C8", Offset = "0x6E00C8")]
			add
			{
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x102CD58", Offset = "0x102CD58", VA = "0x102CD58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E00D8", Offset = "0x6E00D8")]
			remove
			{
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x102D074", Offset = "0x102D074", VA = "0x102D074")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x102D224", Offset = "0x102D224", VA = "0x102D224")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x102C76C", Offset = "0x102C76C", VA = "0x102C76C")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x102D264", Offset = "0x102D264", VA = "0x102D264")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x102D310", Offset = "0x102D310", VA = "0x102D310", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x102D38C", Offset = "0x102D38C", VA = "0x102D38C")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x102D46C", Offset = "0x102D46C", VA = "0x102D46C")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x102D5F0", Offset = "0x102D5F0", VA = "0x102D5F0")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x102D574", Offset = "0x102D574", VA = "0x102D574")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x102D640", Offset = "0x102D640", VA = "0x102D640")]
		public void Service()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x102D658", Offset = "0x102D658", VA = "0x102D658")]
		private void DisconnectToReconnect()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x102D6BC", Offset = "0x102D6BC", VA = "0x102D6BC")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x102D734", Offset = "0x102D734", VA = "0x102D734")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x102D790", Offset = "0x102D790", VA = "0x102D790")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x102DA68", Offset = "0x102DA68", VA = "0x102DA68")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x102DB18", Offset = "0x102DB18", VA = "0x102DB18")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x102DB3C", Offset = "0x102DB3C", VA = "0x102DB3C")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x102DD20", Offset = "0x102DD20", VA = "0x102DD20")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x102DBDC", Offset = "0x102DBDC", VA = "0x102DBDC")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x102DDC8", Offset = "0x102DDC8", VA = "0x102DDC8")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x102DE90", Offset = "0x102DE90", VA = "0x102DE90")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x102DF54", Offset = "0x102DF54", VA = "0x102DF54")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x102E03C", Offset = "0x102E03C", VA = "0x102E03C")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x102E11C", Offset = "0x102E11C", VA = "0x102E11C")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x102E128", Offset = "0x102E128", VA = "0x102E128")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x102E1B4", Offset = "0x102E1B4", VA = "0x102E1B4")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x102E1D8", Offset = "0x102E1D8", VA = "0x102E1D8")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x102E580", Offset = "0x102E580", VA = "0x102E580")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E0228", Offset = "0x6E0228")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x102E42C", Offset = "0x102E42C", VA = "0x102E42C")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x102E950", Offset = "0x102E950", VA = "0x102E950")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x102EB10", Offset = "0x102EB10", VA = "0x102EB10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E0260", Offset = "0x6E0260")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x102E9E4", Offset = "0x102E9E4", VA = "0x102E9E4")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x102EDD0", Offset = "0x102EDD0", VA = "0x102EDD0", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x102EDEC", Offset = "0x102EDEC", VA = "0x102EDEC", Slot = "10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E0298", Offset = "0x6E0298")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x102EE80", Offset = "0x102EE80", VA = "0x102EE80", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x102EE9C", Offset = "0x102EE9C", VA = "0x102EE9C")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x102F200", Offset = "0x102F200", VA = "0x102F200")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x102F2F0", Offset = "0x102F2F0", VA = "0x102F2F0")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x102F444", Offset = "0x102F444", VA = "0x102F444")]
		private void CleanCachedValues()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x102F4EC", Offset = "0x102F4EC", VA = "0x102F4EC")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x102F6F8", Offset = "0x102F6F8", VA = "0x102F6F8")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x102F804", Offset = "0x102F804", VA = "0x102F804", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x102F948", Offset = "0x102F948", VA = "0x102F948", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x102FA90", Offset = "0x102FA90", VA = "0x102FA90", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x102FBA8", Offset = "0x102FBA8", VA = "0x102FBA8", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1030AF4", Offset = "0x1030AF4", VA = "0x1030AF4", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1031084", Offset = "0x1031084", VA = "0x1031084", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1031A94", Offset = "0x1031A94", VA = "0x1031A94", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10307B8", Offset = "0x10307B8", VA = "0x10307B8")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1031B10", Offset = "0x1031B10", VA = "0x1031B10")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001D")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Token(Token = "0x2000038")]
		private enum RoomOptionBit
		{
			[Token(Token = "0x40001CC")]
			CheckUserOnJoin = 1,
			[Token(Token = "0x40001CD")]
			DeleteCacheOnLeave = 2,
			[Token(Token = "0x40001CE")]
			SuppressRoomEvents = 4,
			[Token(Token = "0x40001CF")]
			PublishUserId = 8,
			[Token(Token = "0x40001D0")]
			DeleteNullProps = 0x10,
			[Token(Token = "0x40001D1")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal static Type PingImplementation;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<byte, object> opParameters;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1031D1C", Offset = "0x1031D1C", VA = "0x1031D1C")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x102D1A4", Offset = "0x102D1A4", VA = "0x102D1A4")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1031DC4", Offset = "0x1031DC4", VA = "0x1031DC4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6E02D0", Offset = "0x6E02D0")]
		private void ConfigUnitySockets()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1032030", Offset = "0x1032030", VA = "0x1032030", Slot = "17")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1032108", Offset = "0x1032108", VA = "0x1032108", Slot = "18")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10322E4", Offset = "0x10322E4", VA = "0x10322E4", Slot = "19")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x10323FC", Offset = "0x10323FC", VA = "0x10323FC")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1032858", Offset = "0x1032858", VA = "0x1032858", Slot = "20")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1032AFC", Offset = "0x1032AFC", VA = "0x1032AFC", Slot = "21")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1032E0C", Offset = "0x1032E0C", VA = "0x1032E0C", Slot = "22")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1033130", Offset = "0x1033130", VA = "0x1033130", Slot = "23")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x103326C", Offset = "0x103326C", VA = "0x103326C", Slot = "24")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1033530", Offset = "0x1033530", VA = "0x1033530", Slot = "25")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x103360C", Offset = "0x103360C", VA = "0x103360C")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x102E65C", Offset = "0x102E65C", VA = "0x102E65C")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1033654", Offset = "0x1033654", VA = "0x1033654")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1033710", Offset = "0x1033710", VA = "0x1033710")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x102EBB8", Offset = "0x102EBB8", VA = "0x102EBB8")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1033744", Offset = "0x1033744", VA = "0x1033744", Slot = "26")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1033A54", Offset = "0x1033A54", VA = "0x1033A54", Slot = "27")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1033D78", Offset = "0x1033D78", VA = "0x1033D78", Slot = "28")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1033F0C", Offset = "0x1033F0C", VA = "0x1033F0C", Slot = "29")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1034130", Offset = "0x1034130", VA = "0x1034130", Slot = "30")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001E")]
	public class OpJoinRandomRoomParams
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hashtable ExpectedCustomRoomProperties;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte ExpectedMaxPlayers;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public MatchmakingMode MatchingType;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby TypedLobby;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SqlLobbyFilter;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ExpectedUsers;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x102DDC0", Offset = "0x102DDC0", VA = "0x102DDC0")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class EnterRoomParams
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string RoomName;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoomOptions RoomOptions;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby Lobby;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hashtable PlayerProperties;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool OnGameServer;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool CreateIfNotExists;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool RejoinOnly;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] ExpectedUsers;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x102B418", Offset = "0x102B418", VA = "0x102B418")]
		public EnterRoomParams()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class ErrorCode
	{
		[Token(Token = "0x40000CF")]
		public const int Ok = 0;

		[Token(Token = "0x40000D0")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40000D1")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFA28", Offset = "0x6DFA28")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40000D2")]
		public const int InvalidOperation = -2;

		[Token(Token = "0x40000D3")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40000D4")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40000D5")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40000D6")]
		public const int GameFull = 32765;

		[Token(Token = "0x40000D7")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40000D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFA60", Offset = "0x6DFA60")]
		public const int AlreadyMatched = 32763;

		[Token(Token = "0x40000D9")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40000DA")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40000DB")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40000DC")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40000DD")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40000DE")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40000DF")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x40000E0")]
		public const int AuthenticationTicketExpired = 32753;

		[Token(Token = "0x40000E1")]
		public const int PluginReportedError = 32752;

		[Token(Token = "0x40000E2")]
		public const int PluginMismatch = 32751;

		[Token(Token = "0x40000E3")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Token(Token = "0x40000E4")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Token(Token = "0x40000E5")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Token(Token = "0x40000E6")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Token(Token = "0x40000E7")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Token(Token = "0x40000E8")]
		public const int HttpLimitReached = 32745;

		[Token(Token = "0x40000E9")]
		public const int ExternalHttpCallFailed = 32744;

		[Token(Token = "0x40000EA")]
		public const int SlotError = 32742;

		[Token(Token = "0x40000EB")]
		public const int InvalidEncryptionParameters = 32741;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x102B428", Offset = "0x102B428", VA = "0x102B428")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ActorProperties
	{
		[Token(Token = "0x40000EC")]
		public const byte PlayerName = byte.MaxValue;

		[Token(Token = "0x40000ED")]
		public const byte IsInactive = 254;

		[Token(Token = "0x40000EE")]
		public const byte UserId = 253;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x102B0EC", Offset = "0x102B0EC", VA = "0x102B0EC")]
		public ActorProperties()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class GamePropertyKey
	{
		[Token(Token = "0x40000EF")]
		public const byte MaxPlayers = byte.MaxValue;

		[Token(Token = "0x40000F0")]
		public const byte IsVisible = 254;

		[Token(Token = "0x40000F1")]
		public const byte IsOpen = 253;

		[Token(Token = "0x40000F2")]
		public const byte PlayerCount = 252;

		[Token(Token = "0x40000F3")]
		public const byte Removed = 251;

		[Token(Token = "0x40000F4")]
		public const byte PropsListedInLobby = 250;

		[Token(Token = "0x40000F5")]
		public const byte CleanupCacheOnLeave = 249;

		[Token(Token = "0x40000F6")]
		public const byte MasterClientId = 248;

		[Token(Token = "0x40000F7")]
		public const byte ExpectedUsers = 247;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x102C5B0", Offset = "0x102C5B0", VA = "0x102C5B0")]
		public GamePropertyKey()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class EventCode
	{
		[Token(Token = "0x40000F8")]
		public const byte GameList = 230;

		[Token(Token = "0x40000F9")]
		public const byte GameListUpdate = 229;

		[Token(Token = "0x40000FA")]
		public const byte QueueState = 228;

		[Token(Token = "0x40000FB")]
		public const byte Match = 227;

		[Token(Token = "0x40000FC")]
		public const byte AppStats = 226;

		[Token(Token = "0x40000FD")]
		public const byte LobbyStats = 224;

		[Token(Token = "0x40000FE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFA98", Offset = "0x6DFA98")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x40000FF")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x4000100")]
		public const byte Leave = 254;

		[Token(Token = "0x4000101")]
		public const byte PropertiesChanged = 253;

		[Token(Token = "0x4000102")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFAD0", Offset = "0x6DFAD0")]
		public const byte SetProperties = 253;

		[Token(Token = "0x4000103")]
		public const byte ErrorInfo = 251;

		[Token(Token = "0x4000104")]
		public const byte CacheSliceChanged = 250;

		[Token(Token = "0x4000105")]
		public const byte AuthEvent = 223;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x102B430", Offset = "0x102B430", VA = "0x102B430")]
		public EventCode()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class ParameterCode
	{
		[Token(Token = "0x4000106")]
		public const byte SuppressRoomEvents = 237;

		[Token(Token = "0x4000107")]
		public const byte EmptyRoomTTL = 236;

		[Token(Token = "0x4000108")]
		public const byte PlayerTTL = 235;

		[Token(Token = "0x4000109")]
		public const byte EventForward = 234;

		[Token(Token = "0x400010A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFB08", Offset = "0x6DFB08")]
		public const byte IsComingBack = 233;

		[Token(Token = "0x400010B")]
		public const byte IsInactive = 233;

		[Token(Token = "0x400010C")]
		public const byte CheckUserOnJoin = 232;

		[Token(Token = "0x400010D")]
		public const byte ExpectedValues = 231;

		[Token(Token = "0x400010E")]
		public const byte Address = 230;

		[Token(Token = "0x400010F")]
		public const byte PeerCount = 229;

		[Token(Token = "0x4000110")]
		public const byte GameCount = 228;

		[Token(Token = "0x4000111")]
		public const byte MasterPeerCount = 227;

		[Token(Token = "0x4000112")]
		public const byte UserId = 225;

		[Token(Token = "0x4000113")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x4000114")]
		public const byte Position = 223;

		[Token(Token = "0x4000115")]
		public const byte MatchMakingType = 223;

		[Token(Token = "0x4000116")]
		public const byte GameList = 222;

		[Token(Token = "0x4000117")]
		public const byte Secret = 221;

		[Token(Token = "0x4000118")]
		public const byte AppVersion = 220;

		[Token(Token = "0x4000119")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFB40", Offset = "0x6DFB40")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x400011A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFB78", Offset = "0x6DFB78")]
		public const byte AzureLocalNodeId = 209;

		[Token(Token = "0x400011B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFBB0", Offset = "0x6DFBB0")]
		public const byte AzureMasterNodeId = 208;

		[Token(Token = "0x400011C")]
		public const byte RoomName = byte.MaxValue;

		[Token(Token = "0x400011D")]
		public const byte Broadcast = 250;

		[Token(Token = "0x400011E")]
		public const byte ActorList = 252;

		[Token(Token = "0x400011F")]
		public const byte ActorNr = 254;

		[Token(Token = "0x4000120")]
		public const byte PlayerProperties = 249;

		[Token(Token = "0x4000121")]
		public const byte CustomEventContent = 245;

		[Token(Token = "0x4000122")]
		public const byte Data = 245;

		[Token(Token = "0x4000123")]
		public const byte Code = 244;

		[Token(Token = "0x4000124")]
		public const byte GameProperties = 248;

		[Token(Token = "0x4000125")]
		public const byte Properties = 251;

		[Token(Token = "0x4000126")]
		public const byte TargetActorNr = 253;

		[Token(Token = "0x4000127")]
		public const byte ReceiverGroup = 246;

		[Token(Token = "0x4000128")]
		public const byte Cache = 247;

		[Token(Token = "0x4000129")]
		public const byte CleanupCacheOnLeave = 241;

		[Token(Token = "0x400012A")]
		public const byte Group = 240;

		[Token(Token = "0x400012B")]
		public const byte Remove = 239;

		[Token(Token = "0x400012C")]
		public const byte PublishUserId = 239;

		[Token(Token = "0x400012D")]
		public const byte Add = 238;

		[Token(Token = "0x400012E")]
		public const byte Info = 218;

		[Token(Token = "0x400012F")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x4000130")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x4000131")]
		public const byte JoinMode = 215;

		[Token(Token = "0x4000132")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x4000133")]
		public const byte MasterClientId = 203;

		[Token(Token = "0x4000134")]
		public const byte FindFriendsRequestList = 1;

		[Token(Token = "0x4000135")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Token(Token = "0x4000136")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Token(Token = "0x4000137")]
		public const byte LobbyName = 213;

		[Token(Token = "0x4000138")]
		public const byte LobbyType = 212;

		[Token(Token = "0x4000139")]
		public const byte LobbyStats = 211;

		[Token(Token = "0x400013A")]
		public const byte Region = 210;

		[Token(Token = "0x400013B")]
		public const byte UriPath = 209;

		[Token(Token = "0x400013C")]
		public const byte WebRpcParameters = 208;

		[Token(Token = "0x400013D")]
		public const byte WebRpcReturnCode = 207;

		[Token(Token = "0x400013E")]
		public const byte WebRpcReturnMessage = 206;

		[Token(Token = "0x400013F")]
		public const byte CacheSliceIndex = 205;

		[Token(Token = "0x4000140")]
		public const byte Plugins = 204;

		[Token(Token = "0x4000141")]
		public const byte NickName = 202;

		[Token(Token = "0x4000142")]
		public const byte PluginName = 201;

		[Token(Token = "0x4000143")]
		public const byte PluginVersion = 200;

		[Token(Token = "0x4000144")]
		public const byte ExpectedProtocol = 195;

		[Token(Token = "0x4000145")]
		public const byte CustomInitData = 194;

		[Token(Token = "0x4000146")]
		public const byte EncryptionMode = 193;

		[Token(Token = "0x4000147")]
		public const byte EncryptionData = 192;

		[Token(Token = "0x4000148")]
		public const byte RoomOptionFlags = 191;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10342E4", Offset = "0x10342E4", VA = "0x10342E4")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class OperationCode
	{
		[Token(Token = "0x4000149")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFBE8", Offset = "0x6DFBE8")]
		public const byte ExchangeKeysForEncryption = 250;

		[Token(Token = "0x400014A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFC20", Offset = "0x6DFC20")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x400014B")]
		public const byte AuthenticateOnce = 231;

		[Token(Token = "0x400014C")]
		public const byte Authenticate = 230;

		[Token(Token = "0x400014D")]
		public const byte JoinLobby = 229;

		[Token(Token = "0x400014E")]
		public const byte LeaveLobby = 228;

		[Token(Token = "0x400014F")]
		public const byte CreateGame = 227;

		[Token(Token = "0x4000150")]
		public const byte JoinGame = 226;

		[Token(Token = "0x4000151")]
		public const byte JoinRandomGame = 225;

		[Token(Token = "0x4000152")]
		public const byte Leave = 254;

		[Token(Token = "0x4000153")]
		public const byte RaiseEvent = 253;

		[Token(Token = "0x4000154")]
		public const byte SetProperties = 252;

		[Token(Token = "0x4000155")]
		public const byte GetProperties = 251;

		[Token(Token = "0x4000156")]
		public const byte ChangeGroups = 248;

		[Token(Token = "0x4000157")]
		public const byte FindFriends = 222;

		[Token(Token = "0x4000158")]
		public const byte GetLobbyStats = 221;

		[Token(Token = "0x4000159")]
		public const byte GetRegions = 220;

		[Token(Token = "0x400015A")]
		public const byte WebRpc = 219;

		[Token(Token = "0x400015B")]
		public const byte ServerSettings = 218;

		[Token(Token = "0x400015C")]
		public const byte GetGameList = 217;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10342DC", Offset = "0x10342DC", VA = "0x10342DC")]
		public OperationCode()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public enum JoinMode : byte
	{
		[Token(Token = "0x400015E")]
		Default,
		[Token(Token = "0x400015F")]
		CreateIfNotExists,
		[Token(Token = "0x4000160")]
		JoinOrRejoin,
		[Token(Token = "0x4000161")]
		RejoinOnly
	}
	[Token(Token = "0x2000027")]
	public enum MatchmakingMode : byte
	{
		[Token(Token = "0x4000163")]
		FillRoom,
		[Token(Token = "0x4000164")]
		SerialMatching,
		[Token(Token = "0x4000165")]
		RandomMatching
	}
	[Token(Token = "0x2000028")]
	public enum ReceiverGroup : byte
	{
		[Token(Token = "0x4000167")]
		Others,
		[Token(Token = "0x4000168")]
		All,
		[Token(Token = "0x4000169")]
		MasterClient
	}
	[Token(Token = "0x2000029")]
	public enum EventCaching : byte
	{
		[Token(Token = "0x400016B")]
		DoNotCache = 0,
		[Token(Token = "0x400016C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFC30", Offset = "0x6DFC30")]
		MergeCache = 1,
		[Token(Token = "0x400016D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFC40", Offset = "0x6DFC40")]
		ReplaceCache = 2,
		[Token(Token = "0x400016E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFC50", Offset = "0x6DFC50")]
		RemoveCache = 3,
		[Token(Token = "0x400016F")]
		AddToRoomCache = 4,
		[Token(Token = "0x4000170")]
		AddToRoomCacheGlobal = 5,
		[Token(Token = "0x4000171")]
		RemoveFromRoomCache = 6,
		[Token(Token = "0x4000172")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Token(Token = "0x4000173")]
		SliceIncreaseIndex = 10,
		[Token(Token = "0x4000174")]
		SliceSetIndex = 11,
		[Token(Token = "0x4000175")]
		SlicePurgeIndex = 12,
		[Token(Token = "0x4000176")]
		SlicePurgeUpToIndex = 13
	}
	[Token(Token = "0x200002A")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Token(Token = "0x4000178")]
		None = 0,
		[Token(Token = "0x4000179")]
		Game = 1,
		[Token(Token = "0x400017A")]
		Actor = 2,
		[Token(Token = "0x400017B")]
		GameAndActor = 3
	}
	[Token(Token = "0x200002B")]
	public class RoomOptions
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isVisible;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool isOpen;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte MaxPlayers;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PlayerTtl;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int EmptyRoomTtl;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool cleanupCacheOnLeave;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hashtable CustomRoomProperties;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] CustomRoomPropertiesForLobby;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Plugins;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFC60", Offset = "0x6DFC60")]
		private bool <SuppressRoomEvents>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFC70", Offset = "0x6DFC70")]
		private bool <PublishUserId>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFC80", Offset = "0x6DFC80")]
		private bool <DeleteNullProperties>k__BackingField;

		[Token(Token = "0x17000034")]
		public bool IsVisible
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1036514", Offset = "0x1036514", VA = "0x1036514")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x103651C", Offset = "0x103651C", VA = "0x103651C")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool IsOpen
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1036528", Offset = "0x1036528", VA = "0x1036528")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1036530", Offset = "0x1036530", VA = "0x1036530")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool CleanupCacheOnLeave
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x103653C", Offset = "0x103653C", VA = "0x103653C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1036544", Offset = "0x1036544", VA = "0x1036544")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool SuppressRoomEvents
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1036550", Offset = "0x1036550", VA = "0x1036550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0308", Offset = "0x6E0308")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1036558", Offset = "0x1036558", VA = "0x1036558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0318", Offset = "0x6E0318")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool PublishUserId
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1036564", Offset = "0x1036564", VA = "0x1036564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0328", Offset = "0x6E0328")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x103656C", Offset = "0x103656C", VA = "0x103656C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0338", Offset = "0x6E0338")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool DeleteNullProperties
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1036578", Offset = "0x1036578", VA = "0x1036578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0348", Offset = "0x6E0348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1036580", Offset = "0x1036580", VA = "0x1036580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0358", Offset = "0x6E0358")]
			set
			{
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10327E8", Offset = "0x10327E8", VA = "0x10327E8")]
		public RoomOptions()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class RaiseEventOptions
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RaiseEventOptions Default;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventCaching CachingOption;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte InterestGroup;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] TargetActors;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReceiverGroup Receivers;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DFC90", Offset = "0x6DFC90")]
		public byte SequenceChannel;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WebFlags Flags;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1034B38", Offset = "0x1034B38", VA = "0x1034B38")]
		public RaiseEventOptions()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public enum LobbyType : byte
	{
		[Token(Token = "0x4000190")]
		Default = 0,
		[Token(Token = "0x4000191")]
		SqlLobby = 2,
		[Token(Token = "0x4000192")]
		AsyncRandomLobby = 3
	}
	[Token(Token = "0x200002E")]
	public class TypedLobby
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LobbyType Type;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypedLobby Default;

		[Token(Token = "0x1700003A")]
		public bool IsDefault
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x10322C8", Offset = "0x10322C8", VA = "0x10322C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x103658C", Offset = "0x103658C", VA = "0x103658C")]
		public TypedLobby()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10365F4", Offset = "0x10365F4", VA = "0x10365F4")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1036630", Offset = "0x1036630", VA = "0x1036630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PlayerCount;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RoomCount;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1036718", Offset = "0x1036718", VA = "0x1036718", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1031A30", Offset = "0x1031A30", VA = "0x1031A30")]
		public TypedLobbyInfo()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public enum AuthModeOption
	{
		[Token(Token = "0x4000199")]
		Auth,
		[Token(Token = "0x400019A")]
		AuthOnce,
		[Token(Token = "0x400019B")]
		AuthOnceWss
	}
	[Token(Token = "0x2000031")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x400019D")]
		Custom = 0,
		[Token(Token = "0x400019E")]
		Steam = 1,
		[Token(Token = "0x400019F")]
		Facebook = 2,
		[Token(Token = "0x40001A0")]
		Oculus = 3,
		[Token(Token = "0x40001A1")]
		PlayStation = 4,
		[Token(Token = "0x40001A2")]
		Xbox = 5,
		[Token(Token = "0x40001A3")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000032")]
	public class AuthenticationValues
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFCC8", Offset = "0x6DFCC8")]
		private string <AuthGetParameters>k__BackingField;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFCD8", Offset = "0x6DFCD8")]
		private object <AuthPostData>k__BackingField;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFCE8", Offset = "0x6DFCE8")]
		private string <Token>k__BackingField;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFCF8", Offset = "0x6DFCF8")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x1700003B")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x102B0F4", Offset = "0x102B0F4", VA = "0x102B0F4")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x102B0FC", Offset = "0x102B0FC", VA = "0x102B0FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public string AuthGetParameters
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x102B104", Offset = "0x102B104", VA = "0x102B104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0368", Offset = "0x6E0368")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x102B10C", Offset = "0x102B10C", VA = "0x102B10C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0378", Offset = "0x6E0378")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public object AuthPostData
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x102B114", Offset = "0x102B114", VA = "0x102B114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0388", Offset = "0x6E0388")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x102B11C", Offset = "0x102B11C", VA = "0x102B11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0398", Offset = "0x6E0398")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public string Token
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x102B124", Offset = "0x102B124", VA = "0x102B124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E03A8", Offset = "0x6E03A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x102B12C", Offset = "0x102B12C", VA = "0x102B12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E03B8", Offset = "0x6E03B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public string UserId
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x102B134", Offset = "0x102B134", VA = "0x102B134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E03C8", Offset = "0x6E03C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x102B13C", Offset = "0x102B13C", VA = "0x102B13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E03D8", Offset = "0x6E03D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x102B144", Offset = "0x102B144", VA = "0x102B144")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x102B154", Offset = "0x102B154", VA = "0x102B154")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x102B188", Offset = "0x102B188", VA = "0x102B188", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x102B1C8", Offset = "0x102B1C8", VA = "0x102B1C8", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x102B1D0", Offset = "0x102B1D0", VA = "0x102B1D0", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x102B384", Offset = "0x102B384", VA = "0x102B384", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	public class Player
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD08", Offset = "0x6DFD08")]
		private Room <RoomReference>k__BackingField;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int actorID;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly bool IsLocal;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string nickName;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD18", Offset = "0x6DFD18")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD28", Offset = "0x6DFD28")]
		private bool <IsInactive>k__BackingField;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD38", Offset = "0x6DFD38")]
		private Hashtable <CustomProperties>k__BackingField;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object TagObject;

		[Token(Token = "0x17000040")]
		protected internal Room RoomReference
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x10342EC", Offset = "0x10342EC", VA = "0x10342EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E03E8", Offset = "0x6E03E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x10342F4", Offset = "0x10342F4", VA = "0x10342F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E03F8", Offset = "0x6E03F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int ID
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x10342FC", Offset = "0x10342FC", VA = "0x10342FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public string NickName
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1034304", Offset = "0x1034304", VA = "0x1034304")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x102CE7C", Offset = "0x102CE7C", VA = "0x102CE7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public string UserId
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x10343E4", Offset = "0x10343E4", VA = "0x10343E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0408", Offset = "0x6E0408")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x10343EC", Offset = "0x10343EC", VA = "0x10343EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0418", Offset = "0x6E0418")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsMasterClient
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x10343F4", Offset = "0x10343F4", VA = "0x10343F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public bool IsInactive
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1034418", Offset = "0x1034418", VA = "0x1034418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0428", Offset = "0x6E0428")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1034420", Offset = "0x1034420", VA = "0x1034420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0438", Offset = "0x6E0438")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x103442C", Offset = "0x103442C", VA = "0x103442C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0448", Offset = "0x6E0448")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1034434", Offset = "0x1034434", VA = "0x1034434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0458", Offset = "0x6E0458")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Hashtable AllProperties
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x10309A4", Offset = "0x10309A4", VA = "0x10309A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x103443C", Offset = "0x103443C", VA = "0x103443C")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x102F88C", Offset = "0x102F88C", VA = "0x102F88C")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1034448", Offset = "0x1034448", VA = "0x1034448")]
		public Player Get(int id)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1034460", Offset = "0x1034460", VA = "0x1034460")]
		public Player GetNext()
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10345FC", Offset = "0x10345FC", VA = "0x10345FC")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1034468", Offset = "0x1034468", VA = "0x1034468")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1034610", Offset = "0x1034610", VA = "0x1034610", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1034850", Offset = "0x1034850", VA = "0x1034850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10348DC", Offset = "0x10348DC", VA = "0x10348DC")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1034A6C", Offset = "0x1034A6C", VA = "0x1034A6C", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1034B30", Offset = "0x1034B30", VA = "0x1034B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x102F434", Offset = "0x102F434", VA = "0x102F434")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x102E33C", Offset = "0x102E33C", VA = "0x102E33C")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x103430C", Offset = "0x103430C", VA = "0x103430C")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Room : RoomInfo
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal int PlayerTTL;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int RoomTTL;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD48", Offset = "0x6DFD48")]
		private LoadBalancingClient <LoadBalancingClient>k__BackingField;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, Player> players;

		[Token(Token = "0x17000048")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1034C10", Offset = "0x1034C10", VA = "0x1034C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0468", Offset = "0x6E0468")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1034C18", Offset = "0x1034C18", VA = "0x1034C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0478", Offset = "0x6E0478")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public new string Name
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1034C20", Offset = "0x1034C20", VA = "0x1034C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1034C28", Offset = "0x1034C28", VA = "0x1034C28")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public new bool IsOpen
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1034C30", Offset = "0x1034C30", VA = "0x1034C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1034C38", Offset = "0x1034C38", VA = "0x1034C38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public new bool IsVisible
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1034D6C", Offset = "0x1034D6C", VA = "0x1034D6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1034D74", Offset = "0x1034D74", VA = "0x1034D74")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public new byte MaxPlayers
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1034EA8", Offset = "0x1034EA8", VA = "0x1034EA8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1034EB0", Offset = "0x1034EB0", VA = "0x1034EB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public new byte PlayerCount
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1034FD8", Offset = "0x1034FD8", VA = "0x1034FD8")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700004E")]
		public Dictionary<int, Player> Players
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1035030", Offset = "0x1035030", VA = "0x1035030")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1035038", Offset = "0x1035038", VA = "0x1035038")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public string[] ExpectedUsers
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1035040", Offset = "0x1035040", VA = "0x1035040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public int MasterClientId
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1035048", Offset = "0x1035048", VA = "0x1035048")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public string[] PropertiesListedInLobby
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1035050", Offset = "0x1035050", VA = "0x1035050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1035058", Offset = "0x1035058", VA = "0x1035058")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool AutoCleanUp
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1035060", Offset = "0x1035060", VA = "0x1035060")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x102F9B8", Offset = "0x102F9B8", VA = "0x102F9B8")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1035068", Offset = "0x1035068", VA = "0x1035068", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x103513C", Offset = "0x103513C", VA = "0x103513C")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x10351FC", Offset = "0x10351FC", VA = "0x10351FC", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1035270", Offset = "0x1035270", VA = "0x1035270", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10352A8", Offset = "0x10352A8", VA = "0x10352A8")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1035438", Offset = "0x1035438", VA = "0x1035438", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10354CC", Offset = "0x10354CC", VA = "0x10354CC", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1035560", Offset = "0x1035560", VA = "0x1035560", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10355D8", Offset = "0x10355D8", VA = "0x10355D8")]
		public void ClearExpectedUsers()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10356F4", Offset = "0x10356F4", VA = "0x10356F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10358E8", Offset = "0x10358E8", VA = "0x10358E8")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000035")]
	public class RoomInfo
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal bool removedFromList;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable customProperties;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte maxPlayers;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string[] expectedUsers;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool isOpen;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isVisible;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool autoCleanUp;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string name;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int masterClientId;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string[] propertiesListedInLobby;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD58", Offset = "0x6DFD58")]
		private int <PlayerCount>k__BackingField;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD68", Offset = "0x6DFD68")]
		private bool <IsLocalClientInside>k__BackingField;

		[Token(Token = "0x17000053")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1035B10", Offset = "0x1035B10", VA = "0x1035B10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public string Name
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1035B18", Offset = "0x1035B18", VA = "0x1035B18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public int PlayerCount
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1035B20", Offset = "0x1035B20", VA = "0x1035B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0488", Offset = "0x6E0488")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1035B28", Offset = "0x1035B28", VA = "0x1035B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0498", Offset = "0x6E0498")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool IsLocalClientInside
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1035B30", Offset = "0x1035B30", VA = "0x1035B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E04A8", Offset = "0x6E04A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1035B38", Offset = "0x1035B38", VA = "0x1035B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E04B8", Offset = "0x6E04B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public byte MaxPlayers
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1035B44", Offset = "0x1035B44", VA = "0x1035B44")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsOpen
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1035B4C", Offset = "0x1035B4C", VA = "0x1035B4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public bool IsVisible
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1035B54", Offset = "0x1035B54", VA = "0x1035B54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1030A50", Offset = "0x1030A50", VA = "0x1030A50")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1035B5C", Offset = "0x1035B5C", VA = "0x1035B5C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1035C10", Offset = "0x1035C10", VA = "0x1035C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1035C30", Offset = "0x1035C30", VA = "0x1035C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1035E24", Offset = "0x1035E24", VA = "0x1035E24")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x103604C", Offset = "0x103604C", VA = "0x103604C", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class WebRpcResponse
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD78", Offset = "0x6DFD78")]
		private string <Name>k__BackingField;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD88", Offset = "0x6DFD88")]
		private int <ReturnCode>k__BackingField;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFD98", Offset = "0x6DFD98")]
		private string <DebugMessage>k__BackingField;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFDA8", Offset = "0x6DFDA8")]
		private Dictionary<string, object> <Parameters>k__BackingField;

		[Token(Token = "0x1700005A")]
		public string Name
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x10369AC", Offset = "0x10369AC", VA = "0x10369AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E04C8", Offset = "0x6E04C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x10369B4", Offset = "0x10369B4", VA = "0x10369B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E04D8", Offset = "0x6E04D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public int ReturnCode
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x10369BC", Offset = "0x10369BC", VA = "0x10369BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E04E8", Offset = "0x6E04E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x10369C4", Offset = "0x10369C4", VA = "0x10369C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E04F8", Offset = "0x6E04F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public string DebugMessage
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x10369CC", Offset = "0x10369CC", VA = "0x10369CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0508", Offset = "0x6E0508")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x10369D4", Offset = "0x10369D4", VA = "0x10369D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0518", Offset = "0x6E0518")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x10369DC", Offset = "0x10369DC", VA = "0x10369DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0528", Offset = "0x6E0528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x10369E4", Offset = "0x10369E4", VA = "0x10369E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0538", Offset = "0x6E0538")]
			private set
			{
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x10369EC", Offset = "0x10369EC", VA = "0x10369EC")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1036B88", Offset = "0x1036B88", VA = "0x1036B88")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	public class WebFlags
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WebFlags Default;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte WebhookFlags;

		[Token(Token = "0x40001C7")]
		public const byte HttpForwardConst = 1;

		[Token(Token = "0x40001C8")]
		public const byte SendAuthCookieConst = 2;

		[Token(Token = "0x40001C9")]
		public const byte SendSyncConst = 4;

		[Token(Token = "0x40001CA")]
		public const byte SendStateConst = 8;

		[Token(Token = "0x1700005E")]
		public bool HttpForward
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1033648", Offset = "0x1033648", VA = "0x1033648")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x10368B0", Offset = "0x10368B0", VA = "0x10368B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool SendAuthCookie
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x10368CC", Offset = "0x10368CC", VA = "0x10368CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x10368D8", Offset = "0x10368D8", VA = "0x10368D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool SendSync
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x10368F4", Offset = "0x10368F4", VA = "0x10368F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1036900", Offset = "0x1036900", VA = "0x1036900")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool SendState
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x103691C", Offset = "0x103691C", VA = "0x103691C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1036928", Offset = "0x1036928", VA = "0x1036928")]
			set
			{
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x102E630", Offset = "0x102E630", VA = "0x102E630")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
