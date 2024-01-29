using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AdvancedFPSCounter.CountersData;
using CodeStage.AdvancedFPSCounter.Labels;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x2000002")]
	public class APITester : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int selectedTab;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string[] tabs;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FPSLevel currentFPSLevel;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1198E94", Offset = "0x1198E94", VA = "0x1198E94")]
		public APITester()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1199138", Offset = "0x1199138", VA = "0x1199138")]
		private void Start()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1199310", Offset = "0x1199310", VA = "0x1199310")]
		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1199318", Offset = "0x1199318", VA = "0x1199318")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x119B16C", Offset = "0x119B16C", VA = "0x119B16C")]
		private void DrawCommonTab()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x119C1F0", Offset = "0x119C1F0", VA = "0x119C1F0")]
		private void DrawLookFeelTab()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x119D540", Offset = "0x119D540", VA = "0x119D540")]
		private void DrawFPSCounterTab()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x119FD80", Offset = "0x119FD80", VA = "0x119FD80")]
		private void DrawMemoryCounterTab()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x11A1194", Offset = "0x11A1194", VA = "0x11A1194")]
		private void DrawDeviceInfoTab()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x11A2AF4", Offset = "0x11A2AF4", VA = "0x11A2AF4")]
		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			return default(float);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x11A2FC8", Offset = "0x11A2FC8", VA = "0x11A2FC8")]
		private Color ColorSliders(string caption, Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x11A2CE8", Offset = "0x11A2CE8", VA = "0x11A2CE8")]
		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A1C88", Offset = "0x3A1C88")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x3A1C88", Offset = "0x3A1C88")]
	public class AFPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000004")]
		private const string MENU_PATH = "Code Stage/Advanced FPS Counter";

		[Token(Token = "0x4000005")]
		private const string COMPONENT_NAME = "Advanced FPS Counter";

		[Token(Token = "0x4000006")]
		internal const string LOG_PREFIX = "<b>[AFPSCounter]:</b> ";

		[Token(Token = "0x4000007")]
		internal const char NEW_LINE = '\n';

		[Token(Token = "0x4000008")]
		internal const char SPACE = ' ';

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FPSCounterData fpsCounter;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MemoryCounterData memoryCounter;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public DeviceInfoCounterData deviceInfoCounter;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3494", Offset = "0x3A3494")]
		public KeyCode hotKey;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A34C8", Offset = "0x3A34C8")]
		public bool circleGesture;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A34FC", Offset = "0x3A34FC")]
		public bool hotKeyCtrl;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3568", Offset = "0x3A3568")]
		public bool hotKeyShift;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A35B4", Offset = "0x3A35B4")]
		public bool hotKeyAlt;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A35FC", Offset = "0x3A35FC")]
		[SerializeField]
		private bool keepAlive;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Canvas canvas;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool externalCanvas;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DrawableLabel[] labels;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int anchorsCount;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int cachedVSync;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int cachedFrameRate;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool inited;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private readonly List<Vector2> gesturePoints;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int gestureCount;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3644", Offset = "0x3A3644")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A368C", Offset = "0x3A368C")]
		[SerializeField]
		private bool forceFrameRate;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A36D4", Offset = "0x3A36D4")]
		[SerializeField]
		private int forcedFrameRate;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3714", Offset = "0x3A3714")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A375C", Offset = "0x3A375C")]
		[SerializeField]
		private Color backgroundColor;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A37B8", Offset = "0x3A37B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A37B8", Offset = "0x3A37B8")]
		[SerializeField]
		private int backgroundPadding;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3830", Offset = "0x3A3830")]
		[SerializeField]
		private bool shadow;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3878", Offset = "0x3A3878")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A38D4", Offset = "0x3A38D4")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3934", Offset = "0x3A3934")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A397C", Offset = "0x3A397C")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A39DC", Offset = "0x3A39DC")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3A3C", Offset = "0x3A3A3C")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3A84", Offset = "0x3A3A84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A3A84", Offset = "0x3A3A84")]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3B04", Offset = "0x3A3B04")]
		[SerializeField]
		private Font labelsFont;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3B68", Offset = "0x3A3B68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A3B68", Offset = "0x3A3B68")]
		[SerializeField]
		private int fontSize;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3C00", Offset = "0x3A3C00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A3C00", Offset = "0x3A3C00")]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3C7C", Offset = "0x3A3C7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A3C7C", Offset = "0x3A3C7C")]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3D14", Offset = "0x3A3D14")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3D5C", Offset = "0x3A3D5C")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3DC8", Offset = "0x3A3DC8")]
		[SerializeField]
		private int sortingOrder;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3E10", Offset = "0x3A3E10")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A3E10", Offset = "0x3A3E10")]
		private static AFPSCounter <Instance>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool KeepAlive
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1193ECC", Offset = "0x1193ECC", VA = "0x1193ECC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1193ED4", Offset = "0x1193ED4", VA = "0x1193ED4")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1193EDC", Offset = "0x1193EDC", VA = "0x1193EDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x11948A8", Offset = "0x11948A8", VA = "0x11948A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x11948B0", Offset = "0x11948B0", VA = "0x11948B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1194910", Offset = "0x1194910", VA = "0x1194910")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1194918", Offset = "0x1194918", VA = "0x1194918")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool Background
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1194968", Offset = "0x1194968", VA = "0x1194968")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x1194970", Offset = "0x1194970", VA = "0x1194970")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Color BackgroundColor
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1194A78", Offset = "0x1194A78", VA = "0x1194A78")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1194A88", Offset = "0x1194A88", VA = "0x1194A88")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int BackgroundPadding
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1194BE8", Offset = "0x1194BE8", VA = "0x1194BE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1194BF0", Offset = "0x1194BF0", VA = "0x1194BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool Shadow
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1194CE8", Offset = "0x1194CE8", VA = "0x1194CE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1194CF0", Offset = "0x1194CF0", VA = "0x1194CF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Color ShadowColor
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1194DF8", Offset = "0x1194DF8", VA = "0x1194DF8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1194E08", Offset = "0x1194E08", VA = "0x1194E08")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1194F68", Offset = "0x1194F68", VA = "0x1194F68")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1194F7C", Offset = "0x1194F7C", VA = "0x1194F7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool Outline
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x119511C", Offset = "0x119511C", VA = "0x119511C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1195124", Offset = "0x1195124", VA = "0x1195124")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color OutlineColor
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x119522C", Offset = "0x119522C", VA = "0x119522C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x119523C", Offset = "0x119523C", VA = "0x119523C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x119539C", Offset = "0x119539C", VA = "0x119539C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x11953B0", Offset = "0x11953B0", VA = "0x11953B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool AutoScale
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1195550", Offset = "0x1195550", VA = "0x1195550")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1195558", Offset = "0x1195558", VA = "0x1195558")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float ScaleFactor
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1195658", Offset = "0x1195658", VA = "0x1195658")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1195660", Offset = "0x1195660", VA = "0x1195660")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Font LabelsFont
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x11957B8", Offset = "0x11957B8", VA = "0x11957B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x11957C0", Offset = "0x11957C0", VA = "0x11957C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public int FontSize
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1195924", Offset = "0x1195924", VA = "0x1195924")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x119592C", Offset = "0x119592C", VA = "0x119592C")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float LineSpacing
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1195ABC", Offset = "0x1195ABC", VA = "0x1195ABC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1195AC4", Offset = "0x1195AC4", VA = "0x1195AC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public int CountersSpacing
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1195C78", Offset = "0x1195C78", VA = "0x1195C78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1195C80", Offset = "0x1195C80", VA = "0x1195C80")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1195D40", Offset = "0x1195D40", VA = "0x1195D40")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1195D54", Offset = "0x1195D54", VA = "0x1195D54")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool PixelPerfect
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1195F9C", Offset = "0x1195F9C", VA = "0x1195F9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1195FA4", Offset = "0x1195FA4", VA = "0x1195FA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public int SortingOrder
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x119601C", Offset = "0x119601C", VA = "0x119601C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1196024", Offset = "0x1196024", VA = "0x1196024")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1196114", Offset = "0x1196114", VA = "0x1196114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEAFC", Offset = "0x3AEAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1196178", Offset = "0x1196178", VA = "0x1196178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB0C", Offset = "0x3AEB0C")]
			private set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1193988", Offset = "0x1193988", VA = "0x1193988")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x11961DC", Offset = "0x11961DC", VA = "0x11961DC")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1196534", Offset = "0x1196534", VA = "0x1196534")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x119653C", Offset = "0x119653C", VA = "0x119653C")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1196540", Offset = "0x1196540", VA = "0x1196540")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x11967D0", Offset = "0x11967D0", VA = "0x11967D0")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x11963E4", Offset = "0x11963E4", VA = "0x11963E4")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x11968CC", Offset = "0x11968CC", VA = "0x11968CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1197338", Offset = "0x1197338", VA = "0x1197338")]
		private void Start()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1197494", Offset = "0x1197494", VA = "0x1197494")]
		private void Update()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1197B38", Offset = "0x1197B38", VA = "0x1197B38")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1197B3C", Offset = "0x1197B3C", VA = "0x1197B3C")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x11941B8", Offset = "0x11941B8", VA = "0x11941B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x119478C", Offset = "0x119478C", VA = "0x119478C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1197EDC", Offset = "0x1197EDC", VA = "0x1197EDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x11982A0", Offset = "0x11982A0", VA = "0x11982A0")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1194244", Offset = "0x1194244", VA = "0x1194244")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1196B18", Offset = "0x1196B18", VA = "0x1196B18")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1197004", Offset = "0x1197004", VA = "0x1197004")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x119668C", Offset = "0x119668C", VA = "0x119668C")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x11974E0", Offset = "0x11974E0", VA = "0x11974E0")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x11975F8", Offset = "0x11975F8", VA = "0x11975F8")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1197B14", Offset = "0x1197B14", VA = "0x1197B14")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1197C08", Offset = "0x1197C08", VA = "0x1197C08")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1197CF8", Offset = "0x1197CF8", VA = "0x1197CF8")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1194908", Offset = "0x1194908", VA = "0x1194908")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1197E54", Offset = "0x1197E54", VA = "0x1197E54")]
		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A1CE8", Offset = "0x3A1CE8")]
	public abstract class BaseCounterData
	{
		[Token(Token = "0x4000032")]
		protected const string BOLD_START = "<b>";

		[Token(Token = "0x4000033")]
		protected const string BOLD_END = "</b>";

		[Token(Token = "0x4000034")]
		protected const string ITALIC_START = "<i>";

		[Token(Token = "0x4000035")]
		protected const string ITALIC_END = "</i>";

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal StringBuilder text;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal bool dirty;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected AFPSCounter main;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected string colorCached;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool inited;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		protected bool enabled;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3E54", Offset = "0x3A3E54")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3E9C", Offset = "0x3A3E9C")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3F04", Offset = "0x3A3F04")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3F5C", Offset = "0x3A3F5C")]
		protected string extraText;

		[Token(Token = "0x17000018")]
		public bool Enabled
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1197B98", Offset = "0x1197B98", VA = "0x1197B98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x11A3378", Offset = "0x11A3378", VA = "0x11A3378")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x119830C", Offset = "0x119830C", VA = "0x119830C")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x11A3514", Offset = "0x11A3514", VA = "0x11A3514")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Color Color
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x11A4078", Offset = "0x11A4078", VA = "0x11A4078")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x11A4088", Offset = "0x11A4088", VA = "0x11A4088")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public FontStyle Style
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x11A33FC", Offset = "0x11A33FC", VA = "0x11A33FC")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x11A3404", Offset = "0x11A3404", VA = "0x11A3404")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public string ExtraText
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x11A418C", Offset = "0x11A418C", VA = "0x11A418C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x11A3450", Offset = "0x11A3450", VA = "0x11A3450")]
			set
			{
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x11A4068", Offset = "0x11A4068", VA = "0x11A4068")]
		protected BaseCounterData()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x11A4128", Offset = "0x11A4128", VA = "0x11A4128")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x11A4194", Offset = "0x11A4194", VA = "0x11A4194", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x6000062")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1196B10", Offset = "0x1196B10", VA = "0x1196B10")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x119823C", Offset = "0x119823C", VA = "0x119823C")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x11A41A8", Offset = "0x11A41A8", VA = "0x11A41A8", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x11A4310", Offset = "0x11A4310", VA = "0x11A4310", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x11A4398", Offset = "0x11A4398", VA = "0x11A4398", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x11A439C", Offset = "0x11A439C", VA = "0x11A439C", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x11A43A0", Offset = "0x11A43A0", VA = "0x11A43A0", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600006A")]
		protected abstract bool HasData();

		[Token(Token = "0x600006B")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x11A43A4", Offset = "0x11A43A4", VA = "0x11A43A4")]
		protected void ApplyTextStyles()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public abstract class UpdatebleCounterData : BaseCounterData
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected Coroutine updateCoroutine;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected WaitForSecondsUnscaled cachedWaitForSecondsUnscaled;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A3F90", Offset = "0x3A3F90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A3F90", Offset = "0x3A3F90")]
		[SerializeField]
		protected float updateInterval;

		[Token(Token = "0x1700001D")]
		public float UpdateInterval
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x11A35A0", Offset = "0x11A35A0", VA = "0x11A35A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x11A35A8", Offset = "0x11A35A8", VA = "0x11A35A8")]
			set
			{
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x11A5440", Offset = "0x11A5440", VA = "0x11A5440")]
		protected UpdatebleCounterData()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x11A7F4C", Offset = "0x11A7F4C", VA = "0x11A7F4C", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x11A6B74", Offset = "0x11A6B74", VA = "0x11A6B74", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x11A6BAC", Offset = "0x11A6BAC", VA = "0x11A6BAC", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000073")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x11A7F50", Offset = "0x11A7F50", VA = "0x11A7F50")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x11A7FA0", Offset = "0x11A7FA0", VA = "0x11A7FA0")]
		private void StoptUpdateCoroutine()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x11A7ED4", Offset = "0x11A7ED4", VA = "0x11A7ED4")]
		private void CacheWaitForSeconds()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A1D1C", Offset = "0x3A1D1C")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A400C", Offset = "0x3A400C")]
		[SerializeField]
		private bool platform;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4074", Offset = "0x3A4074")]
		[SerializeField]
		private bool cpuModel;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A40BC", Offset = "0x3A40BC")]
		[SerializeField]
		private bool gpuModel;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4114", Offset = "0x3A4114")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4188", Offset = "0x3A4188")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A41D0", Offset = "0x3A41D0")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4228", Offset = "0x3A4228")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A42A0", Offset = "0x3A42A0")]
		[SerializeField]
		private bool deviceModel;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4310", Offset = "0x3A4310")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4310", Offset = "0x3A4310")]
		private string <LastValue>k__BackingField;

		[Token(Token = "0x1700001E")]
		public bool Platform
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x11A3D88", Offset = "0x11A3D88", VA = "0x11A3D88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x11A3D90", Offset = "0x11A3D90", VA = "0x11A3D90")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool CpuModel
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x11A3DE4", Offset = "0x11A3DE4", VA = "0x11A3DE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x11A3DEC", Offset = "0x11A3DEC", VA = "0x11A3DEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool GpuModel
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x11A3E40", Offset = "0x11A3E40", VA = "0x11A3E40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x11A3E48", Offset = "0x11A3E48", VA = "0x11A3E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool GpuApi
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x11A3E9C", Offset = "0x11A3E9C", VA = "0x11A3E9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x11A3EA4", Offset = "0x11A3EA4", VA = "0x11A3EA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool GpuSpec
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x11A3EF8", Offset = "0x11A3EF8", VA = "0x11A3EF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x11A3F00", Offset = "0x11A3F00", VA = "0x11A3F00")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool RamSize
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x11A3F54", Offset = "0x11A3F54", VA = "0x11A3F54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x11A3F5C", Offset = "0x11A3F5C", VA = "0x11A3F5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool ScreenData
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x11A3FB0", Offset = "0x11A3FB0", VA = "0x11A3FB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x11A3FB8", Offset = "0x11A3FB8", VA = "0x11A3FB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool DeviceModel
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x11A400C", Offset = "0x11A400C", VA = "0x11A400C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x11A4014", Offset = "0x11A4014", VA = "0x11A4014")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public string LastValue
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x11A2AEC", Offset = "0x11A2AEC", VA = "0x11A2AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB1C", Offset = "0x3AEB1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x11A4690", Offset = "0x11A4690", VA = "0x11A4690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB2C", Offset = "0x3AEB2C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1193E38", Offset = "0x1193E38", VA = "0x1193E38")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x11A4698", Offset = "0x11A4698", VA = "0x11A4698", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x11A5338", Offset = "0x11A5338", VA = "0x11A5338", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x11A5374", Offset = "0x11A5374", VA = "0x11A5374", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A1D50", Offset = "0x3A1D50")]
	public class FPSCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3354", Offset = "0x3A3354")]
		private sealed class <UpdateCounter>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <previousUpdateTime>__1;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <previousUpdateFrames>__1;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float <timeElapsed>__1;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <framesChanged>__1;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal FPSCounterData $this;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal object $current;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x17000109")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000916")]
				[Address(RVA = "0x11A6F84", Offset = "0x11A6F84", VA = "0x11A6F84", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000917")]
				[Address(RVA = "0x11A6F8C", Offset = "0x11A6F8C", VA = "0x11A6F8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x11A6C34", Offset = "0x11A6C34", VA = "0x11A6C34")]
			[DebuggerHidden]
			public <UpdateCounter>c__Iterator0()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x11A6DBC", Offset = "0x11A6DBC", VA = "0x11A6DBC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x11A6F94", Offset = "0x11A6F94", VA = "0x11A6F94", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x11A6FA8", Offset = "0x11A6FA8", VA = "0x11A6FA8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400004C")]
		private const string COLOR_TEXT_START = "<color=#{0}>";

		[Token(Token = "0x400004D")]
		private const string COLOR_TEXT_END = "</color>";

		[Token(Token = "0x400004E")]
		private const string FPS_TEXT_START = "<color=#{0}>FPS: ";

		[Token(Token = "0x400004F")]
		private const string MS_TEXT_START = " <color=#{0}>[";

		[Token(Token = "0x4000050")]
		private const string MS_TEXT_END = " MS]</color>";

		[Token(Token = "0x4000051")]
		private const string MIN_TEXT_START = "<color=#{0}>MIN: ";

		[Token(Token = "0x4000052")]
		private const string MAX_TEXT_START = "<color=#{0}>MAX: ";

		[Token(Token = "0x4000053")]
		private const string AVG_TEXT_START = "<color=#{0}>AVG: ";

		[Token(Token = "0x4000054")]
		private const string RENDER_TEXT_START = "<color=#{0}>REN: ";

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int warningLevelValue;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int criticalLevelValue;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4344", Offset = "0x3A4344")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4378", Offset = "0x3A4378")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A43AC", Offset = "0x3A43AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A43AC", Offset = "0x3A43AC")]
		public int minMaxIntervalsToSkip;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal float newValue;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string colorCachedMs;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private string colorCachedMin;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string colorCachedMax;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private string colorCachedAvg;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string colorCachedRender;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private string colorWarningCached;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string colorWarningCachedMs;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private string colorWarningCachedMin;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string colorWarningCachedMax;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private string colorWarningCachedAvg;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string colorCriticalCached;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private string colorCriticalCachedMs;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string colorCriticalCachedMin;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private string colorCriticalCachedMax;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string colorCriticalCachedAvg;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int currentAverageSamples;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float currentAverageRaw;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float[] accumulatedAverageSamples;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int minMaxIntervalsSkipped;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float renderTimeBank;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int previousFrameCount;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4434", Offset = "0x3A4434")]
		[SerializeField]
		private bool milliseconds;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A44A8", Offset = "0x3A44A8")]
		[SerializeField]
		private bool average;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A44F0", Offset = "0x3A44F0")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAF")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4560", Offset = "0x3A4560")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A45CC", Offset = "0x3A45CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A45CC", Offset = "0x3A45CC")]
		[SerializeField]
		private int averageSamples;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4630", Offset = "0x3A4630")]
		[SerializeField]
		private bool minMax;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4678", Offset = "0x3A4678")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A46E8", Offset = "0x3A46E8")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB7")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4754", Offset = "0x3A4754")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A479C", Offset = "0x3A479C")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A47E4", Offset = "0x3A47E4")]
		[SerializeField]
		private bool renderNewLine;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4850", Offset = "0x3A4850")]
		[SerializeField]
		private bool renderAutoAdd;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4898", Offset = "0x3A4898")]
		[SerializeField]
		private Color colorWarning;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A48E0", Offset = "0x3A48E0")]
		[SerializeField]
		private Color colorCritical;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A495C", Offset = "0x3A495C")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A49C0", Offset = "0x3A49C0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A49C0", Offset = "0x3A49C0")]
		private int <LastValue>k__BackingField;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A49F4", Offset = "0x3A49F4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A49F4", Offset = "0x3A49F4")]
		private float <LastMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4A28", Offset = "0x3A4A28")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4A28", Offset = "0x3A4A28")]
		private float <LastRenderValue>k__BackingField;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4A5C", Offset = "0x3A4A5C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4A5C", Offset = "0x3A4A5C")]
		private int <LastAverageValue>k__BackingField;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4A90", Offset = "0x3A4A90")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4A90", Offset = "0x3A4A90")]
		private float <LastAverageMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4AC4", Offset = "0x3A4AC4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4AC4", Offset = "0x3A4AC4")]
		private int <LastMinimumValue>k__BackingField;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4AF8", Offset = "0x3A4AF8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4AF8", Offset = "0x3A4AF8")]
		private int <LastMaximumValue>k__BackingField;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4B2C", Offset = "0x3A4B2C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4B2C", Offset = "0x3A4B2C")]
		private float <LastMinMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4B60", Offset = "0x3A4B60")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4B60", Offset = "0x3A4B60")]
		private float <LastMaxMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4B94", Offset = "0x3A4B94")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4B94", Offset = "0x3A4B94")]
		private FPSLevel <CurrentFpsLevel>k__BackingField;

		[Token(Token = "0x17000027")]
		public bool Milliseconds
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x11A3608", Offset = "0x11A3608", VA = "0x11A3608")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x11A3610", Offset = "0x11A3610", VA = "0x11A3610")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool Average
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x11A3670", Offset = "0x11A3670", VA = "0x11A3670")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x11A3678", Offset = "0x11A3678", VA = "0x11A3678")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x11A37D8", Offset = "0x11A37D8", VA = "0x11A37D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x11A37E0", Offset = "0x11A37E0", VA = "0x11A37E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool AverageNewLine
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x11A3840", Offset = "0x11A3840", VA = "0x11A3840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x11A3848", Offset = "0x11A3848", VA = "0x11A3848")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int AverageSamples
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x11A36D8", Offset = "0x11A36D8", VA = "0x11A36D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x11A36E0", Offset = "0x11A36E0", VA = "0x11A36E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool MinMax
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x11A38F8", Offset = "0x11A38F8", VA = "0x11A38F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x11A3900", Offset = "0x11A3900", VA = "0x11A3900")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x11A3968", Offset = "0x11A3968", VA = "0x11A3968")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x11A3970", Offset = "0x11A3970", VA = "0x11A3970")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x11A3A60", Offset = "0x11A3A60", VA = "0x11A3A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x11A3A68", Offset = "0x11A3A68", VA = "0x11A3A68")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x11A3A04", Offset = "0x11A3A04", VA = "0x11A3A04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x11A3A0C", Offset = "0x11A3A0C", VA = "0x11A3A0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool Render
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x11A3B10", Offset = "0x11A3B10", VA = "0x11A3B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x11A3B18", Offset = "0x11A3B18", VA = "0x11A3B18")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool RenderNewLine
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x11A3B94", Offset = "0x11A3B94", VA = "0x11A3B94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x11A3B9C", Offset = "0x11A3B9C", VA = "0x11A3B9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x11A581C", Offset = "0x11A581C", VA = "0x11A581C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x11A5824", Offset = "0x11A5824", VA = "0x11A5824")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Color ColorWarning
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x11A587C", Offset = "0x11A587C", VA = "0x11A587C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x11A588C", Offset = "0x11A588C", VA = "0x11A588C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Color ColorCritical
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x11A5A5C", Offset = "0x11A5A5C", VA = "0x11A5A5C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x11A5A6C", Offset = "0x11A5A6C", VA = "0x11A5A6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Color ColorRender
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x11A5C3C", Offset = "0x11A5C3C", VA = "0x11A5C3C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x11A5C4C", Offset = "0x11A5C4C", VA = "0x11A5C4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int LastValue
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x11A2A7C", Offset = "0x11A2A7C", VA = "0x11A2A7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB3C", Offset = "0x3AEB3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x11A5CEC", Offset = "0x11A5CEC", VA = "0x11A5CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB4C", Offset = "0x3AEB4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x11A2A84", Offset = "0x11A2A84", VA = "0x11A2A84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB5C", Offset = "0x3AEB5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x11A5564", Offset = "0x11A5564", VA = "0x11A5564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB6C", Offset = "0x3AEB6C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public float LastRenderValue
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x11A2ABC", Offset = "0x11A2ABC", VA = "0x11A2ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB7C", Offset = "0x3AEB7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x11A5CF4", Offset = "0x11A5CF4", VA = "0x11A5CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB8C", Offset = "0x3AEB8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int LastAverageValue
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x11A2A8C", Offset = "0x11A2A8C", VA = "0x11A2A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEB9C", Offset = "0x3AEB9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x11A5CFC", Offset = "0x11A5CFC", VA = "0x11A5CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEBAC", Offset = "0x3AEBAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x11A2A94", Offset = "0x11A2A94", VA = "0x11A2A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEBBC", Offset = "0x3AEBBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x11A556C", Offset = "0x11A556C", VA = "0x11A556C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEBCC", Offset = "0x3AEBCC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int LastMinimumValue
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x11A2A9C", Offset = "0x11A2A9C", VA = "0x11A2A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEBDC", Offset = "0x3AEBDC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x11A5D04", Offset = "0x11A5D04", VA = "0x11A5D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEBEC", Offset = "0x3AEBEC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public int LastMaximumValue
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x11A2AAC", Offset = "0x11A2AAC", VA = "0x11A2AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEBFC", Offset = "0x3AEBFC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x11A5D0C", Offset = "0x11A5D0C", VA = "0x11A5D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC0C", Offset = "0x3AEC0C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x11A2AA4", Offset = "0x11A2AA4", VA = "0x11A2AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC1C", Offset = "0x3AEC1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x11A5574", Offset = "0x11A5574", VA = "0x11A5574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC2C", Offset = "0x3AEC2C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x11A2AB4", Offset = "0x11A2AB4", VA = "0x11A2AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC3C", Offset = "0x3AEC3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x11A557C", Offset = "0x11A557C", VA = "0x11A557C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC4C", Offset = "0x3AEC4C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x11A2AC4", Offset = "0x11A2AC4", VA = "0x11A2AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC5C", Offset = "0x3AEC5C")]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x11A5D14", Offset = "0x11A5D14", VA = "0x11A5D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC6C", Offset = "0x3AEC6C")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1199204", Offset = "0x1199204", VA = "0x1199204")]
			add
			{
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x11A5458", Offset = "0x11A5458", VA = "0x11A5458")]
			remove
			{
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1193C24", Offset = "0x1193C24", VA = "0x1193C24")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11A389C", Offset = "0x11A389C", VA = "0x11A389C")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x11A3ABC", Offset = "0x11A3ABC", VA = "0x11A3ABC")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1197BA0", Offset = "0x1197BA0", VA = "0x1197BA0")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11A5D1C", Offset = "0x11A5D1C", VA = "0x11A5D1C")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x11A5D44", Offset = "0x11A5D44", VA = "0x11A5D44", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x11A6A10", Offset = "0x11A6A10", VA = "0x11A6A10", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x11A6B78", Offset = "0x11A6B78", VA = "0x11A6B78", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x11A6BB0", Offset = "0x11A6BB0", VA = "0x11A6BB0", Slot = "13")]
		[DebuggerHidden]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x11A6C3C", Offset = "0x11A6C3C", VA = "0x11A6C3C", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11A6C44", Offset = "0x11A6C44", VA = "0x11A6C44", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x11A5920", Offset = "0x11A5920", VA = "0x11A5920")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x11A5B00", Offset = "0x11A5B00", VA = "0x11A5B00")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x11A6970", Offset = "0x11A6970", VA = "0x11A6970")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x11A56C8", Offset = "0x11A56C8", VA = "0x11A56C8")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x11A5584", Offset = "0x11A5584", VA = "0x11A5584")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A1D84", Offset = "0x3A1D84")]
	public class MemoryCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3364", Offset = "0x3A3364")]
		private sealed class <UpdateCounter>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal MemoryCounterData $this;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600091C")]
				[Address(RVA = "0x11A7E28", Offset = "0x11A7E28", VA = "0x11A7E28", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600091D")]
				[Address(RVA = "0x11A7E30", Offset = "0x11A7E30", VA = "0x11A7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x11A7C44", Offset = "0x11A7C44", VA = "0x11A7C44")]
			[DebuggerHidden]
			public <UpdateCounter>c__Iterator0()
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x11A7D38", Offset = "0x11A7D38", VA = "0x11A7D38", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x11A7E38", Offset = "0x11A7E38", VA = "0x11A7E38", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x11A7E4C", Offset = "0x11A7E4C", VA = "0x11A7E4C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400008A")]
		public const long MEMORY_DIVIDER = 1048576L;

		[Token(Token = "0x400008B")]
		private const string TEXT_START = "<color=#{0}>";

		[Token(Token = "0x400008C")]
		private const string LINE_START_TOTAL = "MEM TOTAL: ";

		[Token(Token = "0x400008D")]
		private const string LINE_START_ALLOCATED = "MEM ALLOC: ";

		[Token(Token = "0x400008E")]
		private const string LINE_START_MONO = "MEM MONO: ";

		[Token(Token = "0x400008F")]
		private const string LINE_END = " MB";

		[Token(Token = "0x4000090")]
		private const string TEXT_END = "</color>";

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4BC8", Offset = "0x3A4BC8")]
		[SerializeField]
		private bool precise;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4C10", Offset = "0x3A4C10")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4C58", Offset = "0x3A4C58")]
		[SerializeField]
		private bool allocated;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4CA0", Offset = "0x3A4CA0")]
		[SerializeField]
		private bool monoUsage;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4CE8", Offset = "0x3A4CE8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4CE8", Offset = "0x3A4CE8")]
		private long <LastTotalValue>k__BackingField;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4D1C", Offset = "0x3A4D1C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4D1C", Offset = "0x3A4D1C")]
		private long <LastAllocatedValue>k__BackingField;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A4D50", Offset = "0x3A4D50")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A4D50", Offset = "0x3A4D50")]
		private long <LastMonoValue>k__BackingField;

		[Token(Token = "0x17000040")]
		public bool Precise
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x11A2ACC", Offset = "0x11A2ACC", VA = "0x11A2ACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x11A3BF0", Offset = "0x11A3BF0", VA = "0x11A3BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool Total
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x11A3C44", Offset = "0x11A3C44", VA = "0x11A3C44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x11A3C4C", Offset = "0x11A3C4C", VA = "0x11A3C4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool Allocated
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x11A3CB0", Offset = "0x11A3CB0", VA = "0x11A3CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x11A3CB8", Offset = "0x11A3CB8", VA = "0x11A3CB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool MonoUsage
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x11A3D1C", Offset = "0x11A3D1C", VA = "0x11A3D1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x11A3D24", Offset = "0x11A3D24", VA = "0x11A3D24")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public long LastTotalValue
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x11A2AD4", Offset = "0x11A2AD4", VA = "0x11A2AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC8C", Offset = "0x3AEC8C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x11A7030", Offset = "0x11A7030", VA = "0x11A7030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEC9C", Offset = "0x3AEC9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x11A2ADC", Offset = "0x11A2ADC", VA = "0x11A2ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AECAC", Offset = "0x3AECAC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x11A7040", Offset = "0x11A7040", VA = "0x11A7040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AECBC", Offset = "0x3AECBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public long LastMonoValue
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x11A2AE4", Offset = "0x11A2AE4", VA = "0x11A2AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AECCC", Offset = "0x3AECCC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x11A7050", Offset = "0x11A7050", VA = "0x11A7050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AECDC", Offset = "0x3AECDC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1193DAC", Offset = "0x1193DAC", VA = "0x1193DAC")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x11A7060", Offset = "0x11A7060", VA = "0x11A7060", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x11A76B8", Offset = "0x11A76B8", VA = "0x11A76B8", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x11A7B70", Offset = "0x11A7B70", VA = "0x11A7B70", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x11A7BC0", Offset = "0x11A7BC0", VA = "0x11A7BC0", Slot = "13")]
		[DebuggerHidden]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x11A7C4C", Offset = "0x11A7C4C", VA = "0x11A7C4C", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x11A7C7C", Offset = "0x11A7C7C", VA = "0x11A7C7C", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x2000009")]
	public enum FPSLevel : byte
	{
		[Token(Token = "0x4000099")]
		Normal,
		[Token(Token = "0x400009A")]
		Warning,
		[Token(Token = "0x400009B")]
		Critical
	}
	[Token(Token = "0x200000A")]
	public enum OperationMode : byte
	{
		[Token(Token = "0x400009D")]
		Disabled,
		[Token(Token = "0x400009E")]
		Background,
		[Token(Token = "0x400009F")]
		Normal
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	[Token(Token = "0x200000B")]
	internal class DrawableLabel
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameObject container;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal LabelAnchor anchor;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal StringBuilder newText;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool dirty;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject labelGameObject;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private RectTransform labelTransform;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ContentSizeFitter labelFitter;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private HorizontalLayoutGroup labelGroup;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject uiTextGameObject;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Text uiText;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Font font;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int fontSize;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float lineSpacing;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector2 pixelOffset;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private readonly LabelEffect background;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image backgroundImage;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly LabelEffect shadow;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Shadow shadowComponent;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private readonly LabelEffect outline;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Outline outlineComponent;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1198DAC", Offset = "0x1198DAC", VA = "0x1198DAC")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1198314", Offset = "0x1198314", VA = "0x1198314")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1194028", Offset = "0x1194028", VA = "0x1194028")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1198284", Offset = "0x1198284", VA = "0x1198284")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1195904", Offset = "0x1195904", VA = "0x1195904")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x11959F0", Offset = "0x11959F0", VA = "0x11959F0")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1195EB8", Offset = "0x1195EB8", VA = "0x1195EB8")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1195BA4", Offset = "0x1195BA4", VA = "0x1195BA4")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1194A44", Offset = "0x1194A44", VA = "0x1194A44")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1194B9C", Offset = "0x1194B9C", VA = "0x1194B9C")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1194CB4", Offset = "0x1194CB4", VA = "0x1194CB4")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1194DC4", Offset = "0x1194DC4", VA = "0x1194DC4")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1194F1C", Offset = "0x1194F1C", VA = "0x1194F1C")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x11950E0", Offset = "0x11950E0", VA = "0x11950E0")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x11951F8", Offset = "0x11951F8", VA = "0x11951F8")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1195350", Offset = "0x1195350", VA = "0x1195350")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1195514", Offset = "0x1195514", VA = "0x1195514")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x11A872C", Offset = "0x11A872C", VA = "0x11A872C")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x11A7FF4", Offset = "0x11A7FF4", VA = "0x11A7FF4")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x11A8EBC", Offset = "0x11A8EBC", VA = "0x11A8EBC")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x11A8080", Offset = "0x11A8080", VA = "0x11A8080")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x11A833C", Offset = "0x11A833C", VA = "0x11A833C")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x11A85F8", Offset = "0x11A85F8", VA = "0x11A85F8")]
		private void ApplyFont()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public enum LabelAnchor : byte
	{
		[Token(Token = "0x40000B5")]
		UpperLeft,
		[Token(Token = "0x40000B6")]
		UpperRight,
		[Token(Token = "0x40000B7")]
		LowerLeft,
		[Token(Token = "0x40000B8")]
		LowerRight,
		[Token(Token = "0x40000B9")]
		UpperCenter,
		[Token(Token = "0x40000BA")]
		LowerCenter
	}
}
[Token(Token = "0x200000D")]
internal class LabelEffect
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool enabled;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Color color;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 distance;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int padding;

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1198C8C", Offset = "0x1198C8C", VA = "0x1198C8C")]
	internal LabelEffect(bool enabled, Color color, int padding)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1198D5C", Offset = "0x1198D5C", VA = "0x1198D5C")]
	internal LabelEffect(bool enabled, Color color, Vector2 distance)
	{
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x3A1DB8", Offset = "0x3A1DB8")]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool recording;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float renderTime;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x11A93B8", Offset = "0x11A93B8", VA = "0x11A93B8")]
		public AFPSRenderRecorder()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x11A93C0", Offset = "0x11A93C0", VA = "0x11A93C0")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x11A94C8", Offset = "0x11A94C8", VA = "0x11A94C8")]
		private void OnPostRender()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x200000F")]
	internal class UIUtils
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x11A93B0", Offset = "0x11A93B0", VA = "0x11A93B0")]
		public UIUtils()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1198A14", Offset = "0x1198A14", VA = "0x1198A14")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class WaitForSecondsUnscaled : CustomYieldInstruction
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly float waitTime;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float runUntil;

		[Token(Token = "0x17000047")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x11A9688", Offset = "0x11A9688", VA = "0x11A9688", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x11A7FD4", Offset = "0x11A7FD4", VA = "0x11A7FD4")]
		public WaitForSecondsUnscaled(float time)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x11A6F5C", Offset = "0x11A6F5C", VA = "0x11A6F5C")]
		public new void Reset()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000011")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK aimIK;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform pin;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x11B5AF8", Offset = "0x11B5AF8", VA = "0x11B5AF8")]
		public AimBoxing()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x11B5B00", Offset = "0x11B5B00", VA = "0x11B5B00")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK ik;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4D84", Offset = "0x3A4D84")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x11B5BF8", Offset = "0x11B5BF8", VA = "0x11B5BF8")]
		public AimSwing()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x11B5C9C", Offset = "0x11B5C9C", VA = "0x11B5C9C")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4DB8", Offset = "0x3A4DB8")]
		public AimPoser aimPoser;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4DEC", Offset = "0x3A4DEC")]
		public AimIK aim;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4E20", Offset = "0x3A4E20")]
		public LookAtIK lookAt;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4E54", Offset = "0x3A4E54")]
		public Animator animator;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4EA8", Offset = "0x3A4EA8")]
		public float crossfadeTime;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A4EFC", Offset = "0x3A4EFC")]
		public float minAimDistance;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD95CCC", Offset = "0xD95CCC", VA = "0xD95CCC")]
		public SimpleAimingSystem()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD95CE8", Offset = "0xD95CE8", VA = "0xD95CE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD95D40", Offset = "0xD95D40", VA = "0xD95D40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD95F0C", Offset = "0xD95F0C", VA = "0xD95F0C")]
		private void Pose()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD961E4", Offset = "0xD961E4", VA = "0xD961E4")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD966D0", Offset = "0xD966D0", VA = "0xD966D0")]
		private void DirectCrossFade(string state, float target)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK aimIK;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float min;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float max;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lerpSpeed;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RaycastHit hit;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 offset;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD97988", Offset = "0xD97988", VA = "0xD97988")]
		public TerrainOffset()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD97A00", Offset = "0xD97A00", VA = "0xD97A00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD97D28", Offset = "0xD97D28", VA = "0xD97D28")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000015")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A4F50", Offset = "0x3A4F50")]
		public Animator animator;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BipedIK bipedIK;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A4F84", Offset = "0x3A4F84")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A4FB8", Offset = "0x3A4FB8")]
		public float lookAtWeight;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A4FD0", Offset = "0x3A4FD0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A4FE8", Offset = "0x3A4FE8")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5000", Offset = "0x3A5000")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5018", Offset = "0x3A5018")]
		public float lookAtClampWeight;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5030", Offset = "0x3A5030")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5048", Offset = "0x3A5048")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A5060", Offset = "0x3A5060")]
		public Transform footTargetBiped;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5094", Offset = "0x3A5094")]
		public float footPositionWeight;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A50AC", Offset = "0x3A50AC")]
		public float footRotationWeight;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A50C4", Offset = "0x3A50C4")]
		public Transform handTargetBiped;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A50F8", Offset = "0x3A50F8")]
		public float handPositionWeight;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5110", Offset = "0x3A5110")]
		public float handRotationWeight;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x11B86AC", Offset = "0x11B86AC", VA = "0x11B86AC")]
		public BipedIKvsAnimatorIK()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x11B86D0", Offset = "0x11B86D0", VA = "0x11B86D0")]
		private void OnAnimatorIK(int layer)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float scale;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform body;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float legRotationWeight;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rootPositionSpeed;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float breatheSpeed;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float breatheMagnitude;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float height;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minHeight;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float raycastHeight;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float raycastDistance;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sine;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD8D008", Offset = "0xD8D008", VA = "0xD8D008")]
		public MechSpider()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD8D068", Offset = "0xD8D068", VA = "0xD8D068")]
		private void Update()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD8DE08", Offset = "0xD8DE08", VA = "0xD8DE08")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD8D9BC", Offset = "0xD8D9BC", VA = "0xD8D9BC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000017")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform cameraTransform;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float speed;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float turnSpeed;

		[Token(Token = "0x17000048")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xD8E068", Offset = "0xD8E068", VA = "0xD8E068")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD8E048", Offset = "0xD8E048", VA = "0xD8E048")]
		public MechSpiderController()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD8E118", Offset = "0xD8E118", VA = "0xD8E118")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3374", Offset = "0x3A3374")]
		private sealed class <Step>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Vector3 stepStartPosition;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 targetPosition;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal MechSpiderLeg $this;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal object $current;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int $PC;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000922")]
				[Address(RVA = "0xD8F820", Offset = "0xD8F820", VA = "0xD8F820", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000923")]
				[Address(RVA = "0xD8F828", Offset = "0xD8F828", VA = "0xD8F828", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0xD8F1F4", Offset = "0xD8F1F4", VA = "0xD8F1F4")]
			[DebuggerHidden]
			public <Step>c__Iterator0()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0xD8F1FC", Offset = "0xD8F1FC", VA = "0xD8F1FC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xD8F830", Offset = "0xD8F830", VA = "0xD8F830", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xD8F844", Offset = "0xD8F844", VA = "0xD8F844", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 offset;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxOffset;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float stepSpeed;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float footHeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float velocityPrediction;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float raycastFocus;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ParticleSystem sand;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IK ik;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float stepProgress;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastStepTime;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RaycastHit hit;

		[Token(Token = "0x17000049")]
		public bool isStepping
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xD8E4F0", Offset = "0xD8E4F0", VA = "0xD8E4F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 position
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xD8DFE4", Offset = "0xD8DFE4", VA = "0xD8DFE4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xD8E50C", Offset = "0xD8E50C", VA = "0xD8E50C")]
			set
			{
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD8E488", Offset = "0xD8E488", VA = "0xD8E488")]
		public MechSpiderLeg()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD8E584", Offset = "0xD8E584", VA = "0xD8E584")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD8E5EC", Offset = "0xD8E5EC", VA = "0xD8E5EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD8E870", Offset = "0xD8E870", VA = "0xD8E870")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD8EDEC", Offset = "0xD8EDEC", VA = "0xD8EDEC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD8EF28", Offset = "0xD8EF28", VA = "0xD8EF28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD8EE48", Offset = "0xD8EE48", VA = "0xD8EE48")]
		[DebuggerHidden]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ParticleSystem particles;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD8F8CC", Offset = "0xD8F8CC", VA = "0xD8F8CC")]
		public MechSpiderParticles()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD8F8D4", Offset = "0xD8F8D4", VA = "0xD8F8D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD8FA04", Offset = "0xD8FA04", VA = "0xD8FA04")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200001B")]
		public struct Warp
		{
			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5238", Offset = "0x3A5238")]
			public int animationLayer;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5294", Offset = "0x3A5294")]
			public string animationState;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A52EC", Offset = "0x3A52EC")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5354", Offset = "0x3A5354")]
			public Transform warpFrom;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5388", Offset = "0x3A5388")]
			public Transform warpTo;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A53D4", Offset = "0x3A53D4")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		public enum EffectorMode
		{
			[Token(Token = "0x400011C")]
			PositionOffset,
			[Token(Token = "0x400011D")]
			Position
		}

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5128", Offset = "0x3A5128")]
		public Animator animator;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5180", Offset = "0x3A5180")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x3A51B4", Offset = "0x3A51B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A51B4", Offset = "0x3A51B4")]
		public Warp[] warps;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EffectorMode lastMode;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x11B5E2C", Offset = "0x11B5E2C", VA = "0x11B5E2C")]
		public AnimationWarping()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x11B5E34", Offset = "0x11B5E34", VA = "0x11B5E34", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x11B5E54", Offset = "0x11B5E54", VA = "0x11B5E54")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x11B616C", Offset = "0x11B616C", VA = "0x11B616C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x11B6778", Offset = "0x11B6778", VA = "0x11B6778")]
		private void OnDisable()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1DC8", Offset = "0x3A1DC8")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotateSpeed;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float blendSpeed;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxAngle;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rootMotionWeight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Animator animator;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected Vector3 velocity;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x11B6840", Offset = "0x11B6840", VA = "0x11B6840")]
		public AnimatorController3rdPerson()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x11B6868", Offset = "0x11B6868", VA = "0x11B6868", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x11B68D0", Offset = "0x11B68D0", VA = "0x11B68D0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x11B6B80", Offset = "0x11B6B80", VA = "0x11B6B80", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1E40", Offset = "0x3A1E40")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1E40", Offset = "0x3A1E40")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5420", Offset = "0x3A5420")]
		public float headLookWeight;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Recoil recoil;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AimIK aim;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x11B6EE8", Offset = "0x11B6EE8", VA = "0x11B6EE8")]
		public AnimatorController3rdPersonIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x11B6F18", Offset = "0x11B6F18", VA = "0x11B6F18", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x11B71E0", Offset = "0x11B71E0", VA = "0x11B71E0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x11B7260", Offset = "0x11B7260", VA = "0x11B7260")]
		private void Read()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x11B749C", Offset = "0x11B749C", VA = "0x11B749C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x11B7518", Offset = "0x11B7518", VA = "0x11B7518")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x11B7E70", Offset = "0x11B7E70", VA = "0x11B7E70")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x11B7B90", Offset = "0x11B7B90", VA = "0x11B7B90")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x11B8308", Offset = "0x11B8308", VA = "0x11B8308")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1EE4", Offset = "0x3A1EE4")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x11BA758", Offset = "0x11BA758", VA = "0x11BA758")]
		public CharacterAnimationThirdPersonIK()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x11BA798", Offset = "0x11BA798", VA = "0x11BA798", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x11BA808", Offset = "0x11BA808", VA = "0x11BA808", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x11BAB78", Offset = "0x11BAB78", VA = "0x11BAB78")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1F5C", Offset = "0x3A1F5C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700004B")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xD820B0", Offset = "0xD820B0", VA = "0xD820B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004C")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xD82160", Offset = "0xD82160", VA = "0xD82160")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD81D08", Offset = "0xD81D08", VA = "0xD81D08")]
		public CharacterController3rdPerson()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD81D10", Offset = "0xD81D10", VA = "0xD81D10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD81D9C", Offset = "0xD81D9C", VA = "0xD81D9C")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5448", Offset = "0x3A5448")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xD85778", Offset = "0xD85778", VA = "0xD85778")]
		public EffectorOffset()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xD85780", Offset = "0xD85780", VA = "0xD85780", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float forceMlp;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float upForce;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AnimationCurve scale;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float weight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD86214", Offset = "0xD86214", VA = "0xD86214")]
		public ExplosionDemo()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xD862C8", Offset = "0xD862C8", VA = "0xD862C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xD863B8", Offset = "0xD863B8", VA = "0xD863B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xD86B40", Offset = "0xD86B40", VA = "0xD86B40")]
		private void SetEffectorWeights(float w)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000024")]
		public class Limb
		{
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float mappingWeight;

			[Token(Token = "0x600014F")]
			[Address(RVA = "0xD8706C", Offset = "0xD8706C", VA = "0xD8706C")]
			public Limb()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0xD86EE8", Offset = "0xD86EE8", VA = "0xD86EE8")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool disableAfterStart;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Limb leftArm;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Limb rightArm;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Limb leftLeg;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Limb rightLeg;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rootPin;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xD86C90", Offset = "0xD86C90", VA = "0xD86C90")]
		public FBBIKSettings()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xD86CA0", Offset = "0xD86CA0", VA = "0xD86CA0")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD86FB4", Offset = "0xD86FB4", VA = "0xD86FB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD87068", Offset = "0xD87068", VA = "0xD87068")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float weight;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xD8707C", Offset = "0xD8707C", VA = "0xD8707C")]
		public FBIKBendGoal()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xD87084", Offset = "0xD87084", VA = "0xD87084")]
		private void Start()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xD87110", Offset = "0xD87110", VA = "0xD87110")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5460", Offset = "0x3A5460")]
		public Transform target;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A54A8", Offset = "0x3A54A8")]
		public Transform pin;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A54DC", Offset = "0x3A54DC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A552C", Offset = "0x3A552C")]
		public AimIK aim;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5560", Offset = "0x3A5560")]
		public float weight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5594", Offset = "0x3A5594")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A55E8", Offset = "0x3A55E8")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xD87260", Offset = "0xD87260", VA = "0xD87260")]
		public FBIKBoxing()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD87268", Offset = "0xD87268", VA = "0xD87268")]
		private void Start()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xD872D0", Offset = "0xD872D0", VA = "0xD872D0")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftHanded;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xD875BC", Offset = "0xD875BC", VA = "0xD875BC")]
		public FBIKHandsOnProp()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xD875C4", Offset = "0xD875C4", VA = "0xD875C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xD87724", Offset = "0xD87724", VA = "0xD87724")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xD877FC", Offset = "0xD877FC", VA = "0xD877FC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xD87FE0", Offset = "0xD87FE0", VA = "0xD87FE0")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5644", Offset = "0x3A5644")]
		public float aimWeight;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A565C", Offset = "0x3A565C")]
		public float sightWeight;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5674", Offset = "0x3A5674")]
		public float maxAngle;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5700", Offset = "0x3A5700")]
		private float cameraRecoilWeight;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool updateFrame;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD88188", Offset = "0xD88188", VA = "0xD88188")]
		public FPSAiming()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xD881B0", Offset = "0xD881B0", VA = "0xD881B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD883EC", Offset = "0xD883EC", VA = "0xD883EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD883F8", Offset = "0xD883F8", VA = "0xD883F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xD888D4", Offset = "0xD888D4", VA = "0xD888D4")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xD88C40", Offset = "0xD88C40", VA = "0xD88C40")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD88554", Offset = "0xD88554", VA = "0xD88554")]
		private void RotateCharacter()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1FD4", Offset = "0x3A1FD4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A1FD4", Offset = "0x3A1FD4")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5738", Offset = "0x3A5738")]
		public float walkSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float sVel;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animator animator;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD89DBC", Offset = "0xD89DBC", VA = "0xD89DBC")]
		public FPSCharacter()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD89DCC", Offset = "0xD89DCC", VA = "0xD89DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD89E50", Offset = "0xD89E50", VA = "0xD89E50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xD8A000", Offset = "0xD8A000", VA = "0xD8A000")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string colliderName;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xD8A2F8", Offset = "0xD8A2F8", VA = "0xD8A2F8")]
		public HitReactionTrigger()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xD8A308", Offset = "0xD8A308", VA = "0xD8A308")]
		private void Update()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD8A54C", Offset = "0xD8A54C", VA = "0xD8A54C")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform rightHandTarget;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandTarget;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float crossFade;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD8AA48", Offset = "0xD8AA48", VA = "0xD8AA48")]
		public HoldingHands()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD8AA5C", Offset = "0xD8AA5C", VA = "0xD8AA5C")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD8ACD4", Offset = "0xD8ACD4", VA = "0xD8ACD4")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem character1;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractionSystem character2;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject handShake;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xD8B2F4", Offset = "0xD8B2F4", VA = "0xD8B2F4")]
		public InteractionC2CDemo()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xD8B2FC", Offset = "0xD8B2FC", VA = "0xD8B2FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xD8B3F0", Offset = "0xD8B3F0", VA = "0xD8B3F0")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool interrupt;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject ball;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public InteractionObject benchHands;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionObject button;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public InteractionObject cigarette;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject door;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool isSitting;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xD8B610", Offset = "0xD8B610", VA = "0xD8B610")]
		public InteractionDemo()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD8B618", Offset = "0xD8B618", VA = "0xD8B618")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A2078", Offset = "0x3A2078")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5770", Offset = "0x3A5770")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A57CC", Offset = "0x3A57CC")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xD8BB94", Offset = "0xD8BB94", VA = "0xD8BB94")]
		public InteractionSystemTestGUI()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD8BB9C", Offset = "0xD8BB9C", VA = "0xD8BB9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD8BC04", Offset = "0xD8BC04", VA = "0xD8BC04")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000030")]
		public class Partner
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform mouth;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform mouthTarget;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float bodyWeightVertical;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float neckRotationWeight;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float headTiltAngle;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700004D")]
			private Transform neck
			{
				[Token(Token = "0x600017B")]
				[Address(RVA = "0xD8CF2C", Offset = "0xD8CF2C", VA = "0xD8CF2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0xD8CC70", Offset = "0xD8CC70", VA = "0xD8CC70")]
			public Partner()
			{
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0xD8BFC4", Offset = "0xD8BFC4", VA = "0xD8BFC4")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0xD8C074", Offset = "0xD8C074", VA = "0xD8C074")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0xD8CC98", Offset = "0xD8CC98", VA = "0xD8CC98")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Partner partner1;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Partner partner2;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float weight;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD8BF6C", Offset = "0xD8BF6C", VA = "0xD8BF6C")]
		public KissingRig()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xD8BF7C", Offset = "0xD8BF7C", VA = "0xD8BF7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD8BFF4", Offset = "0xD8BFF4", VA = "0xD8BFF4")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public enum Mode
		{
			[Token(Token = "0x40001A8")]
			Position,
			[Token(Token = "0x40001A9")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000033")]
		public class Absorber
		{
			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5914", Offset = "0x3A5914")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5948", Offset = "0x3A5948")]
			public float weight;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 position;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion rotation;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private IKEffector e;

			[Token(Token = "0x6000183")]
			[Address(RVA = "0xD908EC", Offset = "0xD908EC", VA = "0xD908EC")]
			public Absorber()
			{
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0xD90018", Offset = "0xD90018", VA = "0xD90018")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0xD90328", Offset = "0xD90328", VA = "0xD90328")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0xD90384", Offset = "0xD90384", VA = "0xD90384")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0xD905DC", Offset = "0xD905DC", VA = "0xD905DC")]
			public void SetRotation(float w)
			{
			}
		}

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A582C", Offset = "0x3A582C")]
		public Mode mode;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5860", Offset = "0x3A5860")]
		public Absorber[] absorbers;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A58AC", Offset = "0x3A58AC")]
		public AnimationCurve falloff;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A58E0", Offset = "0x3A58E0")]
		public float falloffSpeed;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float timer;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float w;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Mode initialMode;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xD8FDCC", Offset = "0xD8FDCC", VA = "0xD8FDCC")]
		public MotionAbsorb()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xD8FDDC", Offset = "0xD8FDDC", VA = "0xD8FDDC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xD8FF50", Offset = "0xD8FF50", VA = "0xD8FF50")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xD90190", Offset = "0xD90190", VA = "0xD90190", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD9051C", Offset = "0xD9051C", VA = "0xD9051C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xD90738", Offset = "0xD90738", VA = "0xD90738", Slot = "6")]
		protected override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Animator animator;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform cube;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cubeRandomPosition;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xD909A0", Offset = "0xD909A0", VA = "0xD909A0")]
		public MotionAbsorbCharacter()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xD909B4", Offset = "0xD909B4", VA = "0xD909B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xD90A68", Offset = "0xD90A68", VA = "0xD90A68")]
		private void Update()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xD90B40", Offset = "0xD90B40", VA = "0xD90B40")]
		private void SwingStart()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class EffectorLink
		{
			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float weightMultiplier;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A59A8", Offset = "0x3A59A8")]
			public Vector3 localPosition;

			[Token(Token = "0x600018F")]
			[Address(RVA = "0xD91FE8", Offset = "0xD91FE8", VA = "0xD91FE8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xD91AEC", Offset = "0xD91AEC", VA = "0xD91AEC")]
		public OffsetEffector()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xD91AF4", Offset = "0xD91AF4", VA = "0xD91AF4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xD91C9C", Offset = "0xD91C9C", VA = "0xD91C9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A20F0", Offset = "0x3A20F0")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A59B8", Offset = "0x3A59B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A59B8", Offset = "0x3A59B8")]
		public float weight;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5A24", Offset = "0x3A5A24")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5A88", Offset = "0x3A5A88")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A5A88", Offset = "0x3A5A88")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5AD0", Offset = "0x3A5AD0")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A5AD0", Offset = "0x3A5AD0")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float lastWeight;

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xD91FF8", Offset = "0xD91FF8", VA = "0xD91FF8")]
		public PendulumExample()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xD920B0", Offset = "0xD920B0", VA = "0xD920B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xD9259C", Offset = "0xD9259C", VA = "0xD9259C")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject obj;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pivot;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform holdPoint;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float pickUpTime;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float holdWeight;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float holdWeightVel;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700004E")]
		private bool holding
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xD93350", Offset = "0xD93350", VA = "0xD93350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xD93100", Offset = "0xD93100", VA = "0xD93100")]
		protected PickUp2Handed()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xD93114", Offset = "0xD93114", VA = "0xD93114")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000195")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xD93380", Offset = "0xD93380", VA = "0xD93380")]
		private void Start()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xD936AC", Offset = "0xD936AC", VA = "0xD936AC")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xD9390C", Offset = "0xD9390C", VA = "0xD9390C")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xD93A40", Offset = "0xD93A40", VA = "0xD93A40")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD93BF0", Offset = "0xD93BF0", VA = "0xD93BF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD93E78", Offset = "0xD93E78", VA = "0xD93E78")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xD941EC", Offset = "0xD941EC", VA = "0xD941EC")]
		public PickUpBox()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xD94200", Offset = "0xD94200", VA = "0xD94200", Slot = "4")]
		protected override void RotatePivot()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xD944F0", Offset = "0xD944F0", VA = "0xD944F0")]
		public PickUpSphere()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xD94504", Offset = "0xD94504", VA = "0xD94504", Slot = "4")]
		protected override void RotatePivot()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Rigidbody pelvis;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xD95234", Offset = "0xD95234", VA = "0xD95234")]
		public RagdollUtilityDemo()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xD9523C", Offset = "0xD9523C", VA = "0xD9523C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD952B8", Offset = "0xD952B8", VA = "0xD952B8")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A2168", Offset = "0x3A2168")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float magnitude;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Recoil recoil;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD95514", Offset = "0xD95514", VA = "0xD95514")]
		public RecoilTest()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD95524", Offset = "0xD95524", VA = "0xD95524")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD9558C", Offset = "0xD9558C", VA = "0xD9558C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD955F8", Offset = "0xD955F8", VA = "0xD955F8")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3384", Offset = "0x3A3384")]
		private sealed class <ResetObject>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float resetTime;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Poser <poser>__0;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ResetInteractionObject $this;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object $current;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int $PC;

			[Token(Token = "0x1700010F")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000928")]
				[Address(RVA = "0xD95C20", Offset = "0xD95C20", VA = "0xD95C20", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000110")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000929")]
				[Address(RVA = "0xD95C28", Offset = "0xD95C28", VA = "0xD95C28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0xD9589C", Offset = "0xD9589C", VA = "0xD9589C")]
			[DebuggerHidden]
			public <ResetObject>c__Iterator0()
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0xD958A4", Offset = "0xD958A4", VA = "0xD958A4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xD95C30", Offset = "0xD95C30", VA = "0xD95C30", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xD95C44", Offset = "0xD95C44", VA = "0xD95C44", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float resetDelay;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform defaultParent;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD95674", Offset = "0xD95674", VA = "0xD95674")]
		public ResetInteractionObject()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xD95684", Offset = "0xD95684", VA = "0xD95684")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xD957A8", Offset = "0xD957A8", VA = "0xD957A8")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xD957F0", Offset = "0xD957F0", VA = "0xD957F0")]
		[DebuggerHidden]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A21E0", Offset = "0x3A21E0")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3394", Offset = "0x3A3394")]
		private sealed class <ResetDelayed>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SoccerDemo $this;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000111")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600092E")]
				[Address(RVA = "0xD978DC", Offset = "0xD978DC", VA = "0xD978DC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000112")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092F")]
				[Address(RVA = "0xD978E4", Offset = "0xD978E4", VA = "0xD978E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0xD976C0", Offset = "0xD976C0", VA = "0xD976C0")]
			[DebuggerHidden]
			public <ResetDelayed>c__Iterator0()
			{
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0xD976C8", Offset = "0xD976C8", VA = "0xD976C8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0xD978EC", Offset = "0xD978EC", VA = "0xD978EC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0xD97900", Offset = "0xD97900", VA = "0xD97900", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Animator animator;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD97528", Offset = "0xD97528", VA = "0xD97528")]
		public SoccerDemo()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD97530", Offset = "0xD97530", VA = "0xD97530")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD9763C", Offset = "0xD9763C", VA = "0xD9763C")]
		[DebuggerHidden]
		private IEnumerator ResetDelayed()
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000040")]
		public class EffectorLink
		{
			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool enabled;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform spherecastFrom;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float spherecastRadius;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float minDistance;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LayerMask touchLayers;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float lerpSpeed;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float minSwitchTime;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float releaseDistance;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool sliding;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float raycastDistance;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool inTouch;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private RaycastHit hit;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 targetPosition;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Quaternion targetRotation;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private bool initiated;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float nextSwitchTime;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float speedF;

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xD994C8", Offset = "0xD994C8", VA = "0xD994C8")]
			public EffectorLink()
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xD98070", Offset = "0xD98070", VA = "0xD98070")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xD9952C", Offset = "0xD9952C", VA = "0xD9952C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xD98698", Offset = "0xD98698", VA = "0xD98698")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xD99610", Offset = "0xD99610", VA = "0xD99610")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xD9982C", Offset = "0xD9982C", VA = "0xD9982C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xD998D8", Offset = "0xD998D8", VA = "0xD998D8")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xD99984", Offset = "0xD99984", VA = "0xD99984")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xD99198", Offset = "0xD99198", VA = "0xD99198")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}
		}

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD97FEC", Offset = "0xD97FEC", VA = "0xD97FEC")]
		public TouchWalls()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD97FF4", Offset = "0xD97FF4", VA = "0xD97FF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD98604", Offset = "0xD98604", VA = "0xD98604")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD99080", Offset = "0xD99080", VA = "0xD99080")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5BB8", Offset = "0x3A5BB8")]
		public Transform to;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5C0C", Offset = "0x3A5C0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5C0C", Offset = "0x3A5C0C")]
		public float transferMotion;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 lastPosition;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xD99A30", Offset = "0xD99A30", VA = "0xD99A30")]
		public TransferMotion()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD99A44", Offset = "0xD99A44", VA = "0xD99A44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD99A94", Offset = "0xD99A94", VA = "0xD99A94")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5C78", Offset = "0x3A5C78")]
		public Transform leftHandTarget;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD99E60", Offset = "0xD99E60", VA = "0xD99E60")]
		public TwoHandedProp()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD99E68", Offset = "0xD99E68", VA = "0xD99E68")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD9A158", Offset = "0xD9A158", VA = "0xD9A158")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD9A5F4", Offset = "0xD9A5F4", VA = "0xD9A5F4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD9A7B0", Offset = "0xD9A7B0", VA = "0xD9A7B0")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float enableInputAtProgress;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xD9AE30", Offset = "0xD9AE30", VA = "0xD9AE30")]
		public UserControlInteractions()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xD9AE68", Offset = "0xD9AE68", VA = "0xD9AE68", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xD9B440", Offset = "0xD9B440", VA = "0xD9B440")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject[] characters;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD8A0E4", Offset = "0xD8A0E4", VA = "0xD8A0E4")]
		public GrounderDemo()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD8A0EC", Offset = "0xD8A0EC", VA = "0xD8A0EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD8A258", Offset = "0xD8A258", VA = "0xD8A258")]
		public void Activate(int index)
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A33A4", Offset = "0x3A33A4")]
		private sealed class <SwitchRotation>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <angle>__1;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3 <axis>__1;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal PlatformRotator $this;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal object $current;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0xD95188", Offset = "0xD95188", VA = "0xD95188", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000935")]
				[Address(RVA = "0xD95190", Offset = "0xD95190", VA = "0xD95190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0xD94CDC", Offset = "0xD94CDC", VA = "0xD94CDC")]
			[DebuggerHidden]
			public <SwitchRotation>c__Iterator0()
			{
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0xD94F6C", Offset = "0xD94F6C", VA = "0xD94F6C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xD95198", Offset = "0xD95198", VA = "0xD95198", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xD951AC", Offset = "0xD951AC", VA = "0xD951AC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float maxAngle;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float switchRotationTime;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float random;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSpeed;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 movePosition;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float moveSpeed;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int characterLayer;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion targetRotation;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 targetPosition;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 velocity;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody r;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xD947C0", Offset = "0xD947C0", VA = "0xD947C0")]
		public PlatformRotator()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xD947F8", Offset = "0xD947F8", VA = "0xD947F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xD949E0", Offset = "0xD949E0", VA = "0xD949E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xD9495C", Offset = "0xD9495C", VA = "0xD9495C")]
		[DebuggerHidden]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xD94CE4", Offset = "0xD94CE4", VA = "0xD94CE4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xD94E2C", Offset = "0xD94E2C", VA = "0xD94E2C")]
		private void OnCollisionExit(Collision collision)
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbIK limbIK;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5D08", Offset = "0x3A5D08")]
		public float weight;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x11B84F4", Offset = "0x11B84F4", VA = "0x11B84F4")]
		public BendGoal()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x11B8504", Offset = "0x11B8504", VA = "0x11B8504")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x11B8590", Offset = "0x11B8590", VA = "0x11B8590")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000048")]
		public class Part
		{
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xD99E58", Offset = "0xD99E58", VA = "0xD99E58")]
			public Part()
			{
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xD99CD0", Offset = "0xD99CD0", VA = "0xD99CD0")]
			public void AimAt(Transform target)
			{
			}
		}

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Part[] parts;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD99C4C", Offset = "0xD99C4C", VA = "0xD99C4C")]
		public Turret()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD99C54", Offset = "0xD99C54", VA = "0xD99C54")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string colliderName;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD8A6A0", Offset = "0xD8A6A0", VA = "0xD8A6A0")]
		public HitReactionVRIKTrigger()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD8A6B0", Offset = "0xD8A6B0", VA = "0xD8A6B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD8A8F4", Offset = "0xD8A8F4", VA = "0xD8A8F4")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5D40", Offset = "0x3A5D40")]
		public VRIK ik;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5D9C", Offset = "0x3A5D9C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5DEC", Offset = "0x3A5DEC")]
		public Transform headTracker;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5E24", Offset = "0x3A5E24")]
		public Transform bodyTracker;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5E58", Offset = "0x3A5E58")]
		public Transform leftHandTracker;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5E8C", Offset = "0x3A5E8C")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5EC0", Offset = "0x3A5EC0")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5EF4", Offset = "0x3A5EF4")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3A5F28", Offset = "0x3A5F28")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD9B630", Offset = "0xD9B630", VA = "0xD9B630")]
		public VRIKCalibrationController()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xD9B6AC", Offset = "0xD9B6AC", VA = "0xD9B6AC")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VRIK ik;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD9B878", Offset = "0xD9B878", VA = "0xD9B878")]
		public VRIKPlatform()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xD9B924", Offset = "0xD9B924", VA = "0xD9B924")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD9B9BC", Offset = "0xD9B9BC", VA = "0xD9B9BC")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VRIK ik;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trackingSpace;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform platform;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool moveToPlatform;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform lastPlatform;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xD9BC90", Offset = "0xD9BC90", VA = "0xD9BC90")]
		public VRIKPlatformController()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xD9BD44", Offset = "0xD9BD44", VA = "0xD9BD44")]
		private void LateUpdate()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2258", Offset = "0x3A2258")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2258", Offset = "0x3A2258")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xD9EFE8", Offset = "0xD9EFE8", VA = "0xD9EFE8")]
		public BipedIK()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xD9F1E8", Offset = "0xD9F1E8", VA = "0xD9F1E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AED3C", Offset = "0x3AED3C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xD9F248", Offset = "0xD9F248", VA = "0xD9F248")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AED70", Offset = "0x3AED70")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xD9F2A8", Offset = "0xD9F2A8", VA = "0xD9F2A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEDA4", Offset = "0x3AEDA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD9F308", Offset = "0xD9F308", VA = "0xD9F308")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEDD8", Offset = "0x3AEDD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xD9F368", Offset = "0xD9F368", VA = "0xD9F368")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xD9F440", Offset = "0xD9F440", VA = "0xD9F440")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xD9F470", Offset = "0xD9F470", VA = "0xD9F470")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xD9F4A8", Offset = "0xD9F4A8", VA = "0xD9F4A8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xD9F4E0", Offset = "0xD9F4E0", VA = "0xD9F4E0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xD9F534", Offset = "0xD9F534", VA = "0xD9F534")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xD9F590", Offset = "0xD9F590", VA = "0xD9F590")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xD9F5D8", Offset = "0xD9F5D8", VA = "0xD9F5D8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xD9F618", Offset = "0xD9F618", VA = "0xD9F618")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xD9F6A4", Offset = "0xD9F6A4", VA = "0xD9F6A4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xD9F708", Offset = "0xD9F708", VA = "0xD9F708")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xD9F76C", Offset = "0xD9F76C", VA = "0xD9F76C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xD9F398", Offset = "0xD9F398", VA = "0xD9F398")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xD9F7B4", Offset = "0xD9F7B4", VA = "0xD9F7B4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xD9F7C4", Offset = "0xD9F7C4", VA = "0xD9F7C4")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xD9F7D4", Offset = "0xD9F7D4", VA = "0xD9F7D4")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xD9FCB4", Offset = "0xD9FCB4", VA = "0xD9FCB4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xD9FDC0", Offset = "0xD9FDC0", VA = "0xD9FDC0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xDA03D0", Offset = "0xDA03D0", VA = "0xDA03D0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xDA0B5C", Offset = "0xDA0B5C", VA = "0xDA0B5C")]
		public void LogWarning(string message)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverAim aim;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Constraints pelvis;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700004F")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xD9FACC", Offset = "0xD9FACC", VA = "0xD9FACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xDA0B90", Offset = "0xDA0B90", VA = "0xDA0B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xD9F084", Offset = "0xD9F084", VA = "0xD9F084")]
		public BipedIKSolvers()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xDA00D4", Offset = "0xDA00D4", VA = "0xDA00D4")]
		public void AssignReferences(BipedReferences references)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float weight;

		[Token(Token = "0x17000051")]
		public bool isValid
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xDA13D4", Offset = "0xDA13D4", VA = "0xDA13D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xDA13CC", Offset = "0xDA13CC", VA = "0xDA13CC")]
		protected Constraint()
		{
		}

		[Token(Token = "0x6000200")]
		public abstract void UpdateConstraint();
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xDA1460", Offset = "0xDA1460", VA = "0xDA1460")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xDA1468", Offset = "0xDA1468", VA = "0xDA1468")]
		public ConstraintPosition(Transform transform)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xDA1488", Offset = "0xDA1488", VA = "0xDA1488", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x17000052")]
		private bool positionChanged
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xDA1870", Offset = "0xDA1870", VA = "0xDA1870")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xDA15B4", Offset = "0xDA15B4", VA = "0xDA15B4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xDA15BC", Offset = "0xDA15BC", VA = "0xDA15BC")]
		public ConstraintPositionOffset(Transform transform)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xDA15DC", Offset = "0xDA15DC", VA = "0xDA15DC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion rotation;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xDA193C", Offset = "0xDA193C", VA = "0xDA193C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xDA1944", Offset = "0xDA1944", VA = "0xDA1944")]
		public ConstraintRotation(Transform transform)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xDA1964", Offset = "0xDA1964", VA = "0xDA1964", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion offset;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x17000053")]
		private bool rotationChanged
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xDA1D60", Offset = "0xDA1D60", VA = "0xDA1D60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xDA1AA0", Offset = "0xDA1AA0", VA = "0xDA1AA0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xDA1AA8", Offset = "0xDA1AA8", VA = "0xDA1AA8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xDA1AC8", Offset = "0xDA1AC8", VA = "0xDA1AC8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class Constraints
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionOffset;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5F70", Offset = "0x3A5F70")]
		public float positionWeight;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 rotation;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5F88", Offset = "0x3A5F88")]
		public float rotationWeight;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xDA0B88", Offset = "0xDA0B88", VA = "0xDA0B88")]
		public Constraints()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xDA1E34", Offset = "0xDA1E34", VA = "0xDA1E34")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xDA0354", Offset = "0xDA0354", VA = "0xDA0354")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xDA06BC", Offset = "0xDA06BC", VA = "0xDA06BC")]
		public void Update()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000056")]
		public enum DOF
		{
			[Token(Token = "0x400025F")]
			One,
			[Token(Token = "0x4000260")]
			Three
		}

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A5FA0", Offset = "0x3A5FA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A5FA0", Offset = "0x3A5FA0")]
		public float weight;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6008", Offset = "0x3A6008")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6008", Offset = "0x3A6008")]
		public float rotationWeight;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6058", Offset = "0x3A6058")]
		public DOF rotationDOF;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A608C", Offset = "0x3A608C")]
		public Transform bone1;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A60D8", Offset = "0x3A60D8")]
		public Transform bone2;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6124", Offset = "0x3A6124")]
		public Transform bone3;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6158", Offset = "0x3A6158")]
		public Transform tip;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A618C", Offset = "0x3A618C")]
		public Transform target;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A61C0", Offset = "0x3A61C0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A61C0", Offset = "0x3A61C0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000054")]
		public bool initiated
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1798488", Offset = "0x1798488", VA = "0x1798488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEE0C", Offset = "0x3AEE0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1798490", Offset = "0x1798490", VA = "0x1798490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEE1C", Offset = "0x3AEE1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1798498", Offset = "0x1798498", VA = "0x1798498")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x17984CC", Offset = "0x17984CC", VA = "0x17984CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1798504", Offset = "0x1798504", VA = "0x1798504")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1798534", Offset = "0x1798534", VA = "0x1798534")]
			set
			{
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1798474", Offset = "0x1798474", VA = "0x1798474")]
		public Finger()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1798574", Offset = "0x1798574", VA = "0x1798574")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x17986BC", Offset = "0x17986BC", VA = "0x17986BC")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1798EDC", Offset = "0x1798EDC", VA = "0x1798EDC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1799028", Offset = "0x1799028", VA = "0x1799028")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1799164", Offset = "0x1799164", VA = "0x1799164")]
		public void Update(float masterWeight)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A61F4", Offset = "0x3A61F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A61F4", Offset = "0x3A61F4")]
		public float weight;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A6260", Offset = "0x3A6260")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A6260", Offset = "0x3A6260")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000057")]
		public bool initiated
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x179980C", Offset = "0x179980C", VA = "0x179980C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEE2C", Offset = "0x3AEE2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1799814", Offset = "0x1799814", VA = "0x1799814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEE3C", Offset = "0x3AEE3C")]
			private set
			{
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1799790", Offset = "0x1799790", VA = "0x1799790")]
		public FingerRig()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x179981C", Offset = "0x179981C", VA = "0x179981C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x17998A4", Offset = "0x17998A4", VA = "0x17998A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEE4C", Offset = "0x3AEE4C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1799D50", Offset = "0x1799D50", VA = "0x1799D50")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1799F90", Offset = "0x1799F90", VA = "0x1799F90")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1799BFC", Offset = "0x1799BFC", VA = "0x1799BFC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x179A188", Offset = "0x179A188", VA = "0x179A188", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x179A284", Offset = "0x179A284", VA = "0x179A284")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x179A308", Offset = "0x179A308", VA = "0x179A308")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x179A388", Offset = "0x179A388", VA = "0x179A388")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x179A3F8", Offset = "0x179A3F8", VA = "0x179A3F8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x179A3FC", Offset = "0x179A3FC", VA = "0x179A3FC", Slot = "6")]
		protected override void FixTransforms()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000059")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6294", Offset = "0x3A6294")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6294", Offset = "0x3A6294")]
		public float weight;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A62E4", Offset = "0x3A62E4")]
		public Grounding solver;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A6348", Offset = "0x3A6348")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A6348", Offset = "0x3A6348")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000058")]
		public bool initiated
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x179BB60", Offset = "0x179BB60", VA = "0x179BB60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEE84", Offset = "0x3AEE84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x179BB68", Offset = "0x179BB68", VA = "0x179BB68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEE94", Offset = "0x3AEE94")]
			protected set
			{
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x179B9F0", Offset = "0x179B9F0", VA = "0x179B9F0")]
		protected Grounder()
		{
		}

		[Token(Token = "0x600022E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x179BB70", Offset = "0x179BB70", VA = "0x179BB70")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x179BF38", Offset = "0x179BF38", VA = "0x179BF38")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x179BD20", Offset = "0x179BD20", VA = "0x179BD20")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x179BF64", Offset = "0x179BF64", VA = "0x179BF64")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000235")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000236")]
		protected abstract void OpenScriptReference();
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2308", Offset = "0x3A2308")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2308", Offset = "0x3A2308")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A637C", Offset = "0x3A637C")]
		public BipedIK ik;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A63C0", Offset = "0x3A63C0")]
		public float spineBend;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A63F4", Offset = "0x3A63F4")]
		public float spineSpeed;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform[] feet;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastWeight;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x179C4AC", Offset = "0x179C4AC", VA = "0x179C4AC")]
		public GrounderBipedIK()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x179C550", Offset = "0x179C550", VA = "0x179C550", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEEA4", Offset = "0x3AEEA4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x179C5B0", Offset = "0x179C5B0", VA = "0x179C5B0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEED8", Offset = "0x3AEED8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x179C610", Offset = "0x179C610", VA = "0x179C610", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x179C764", Offset = "0x179C764", VA = "0x179C764")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x179C890", Offset = "0x179C890", VA = "0x179C890")]
		private void Update()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x179C968", Offset = "0x179C968", VA = "0x179C968")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x179D244", Offset = "0x179D244", VA = "0x179D244")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x179D2E8", Offset = "0x179D2E8", VA = "0x179D2E8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x179DE6C", Offset = "0x179DE6C", VA = "0x179DE6C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x179E0AC", Offset = "0x179E0AC", VA = "0x179E0AC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x179E368", Offset = "0x179E368", VA = "0x179E368")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2394", Offset = "0x3A2394")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2394", Offset = "0x3A2394")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200005C")]
		public class SpineEffector
		{
			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A64E0", Offset = "0x3A64E0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6528", Offset = "0x3A6528")]
			public float horizontalWeight;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A658C", Offset = "0x3A658C")]
			public float verticalWeight;

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x179FB14", Offset = "0x179FB14", VA = "0x179FB14")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x179FB24", Offset = "0x179FB24", VA = "0x179FB24")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6428", Offset = "0x3A6428")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6478", Offset = "0x3A6478")]
		public float spineBend;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A64AC", Offset = "0x3A64AC")]
		public float spineSpeed;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform[] feet;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool firstSolve;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x179E648", Offset = "0x179E648", VA = "0x179E648")]
		public GrounderFBBIK()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x179E6E8", Offset = "0x179E6E8", VA = "0x179E6E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEF0C", Offset = "0x3AEF0C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x179E748", Offset = "0x179E748", VA = "0x179E748", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEF40", Offset = "0x3AEF40")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x179E7A8", Offset = "0x179E7A8", VA = "0x179E7A8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEF74", Offset = "0x3AEF74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x179E808", Offset = "0x179E808", VA = "0x179E808", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x179E8BC", Offset = "0x179E8BC", VA = "0x179E8BC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x179E980", Offset = "0x179E980", VA = "0x179E980")]
		private void Update()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x179EE38", Offset = "0x179EE38", VA = "0x179EE38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x179EE44", Offset = "0x179EE44", VA = "0x179EE44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x179EA60", Offset = "0x179EA60", VA = "0x179EA60")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x179EE50", Offset = "0x179EE50", VA = "0x179EE50")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x179F568", Offset = "0x179F568", VA = "0x179F568")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x179F7D8", Offset = "0x179F7D8", VA = "0x179F7D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x179F960", Offset = "0x179F960", VA = "0x179F960")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A242C", Offset = "0x3A242C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A242C", Offset = "0x3A242C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IK[] legs;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A65DC", Offset = "0x3A65DC")]
		public Transform pelvis;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6640", Offset = "0x3A6640")]
		public Transform characterRoot;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6674", Offset = "0x3A6674")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6674", Offset = "0x3A6674")]
		public float rootRotationWeight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A66C4", Offset = "0x3A66C4")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A66F8", Offset = "0x3A66F8")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] feet;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int solvedFeet;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool solved;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastWeight;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x179FB60", Offset = "0x179FB60", VA = "0x179FB60")]
		public GrounderIK()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x179FC04", Offset = "0x179FC04", VA = "0x179FC04", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEFA8", Offset = "0x3AEFA8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x179FC64", Offset = "0x179FC64", VA = "0x179FC64", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AEFDC", Offset = "0x3AEFDC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x179FCC4", Offset = "0x179FCC4", VA = "0x179FCC4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x179FCEC", Offset = "0x179FCEC", VA = "0x179FCEC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x179FF58", Offset = "0x179FF58", VA = "0x179FF58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x17A00CC", Offset = "0x17A00CC", VA = "0x17A00CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x17A0A1C", Offset = "0x17A0A1C", VA = "0x17A0A1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x17A1134", Offset = "0x17A1134", VA = "0x17A1134")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x17A1450", Offset = "0x17A1450", VA = "0x17A1450")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x17A1A28", Offset = "0x17A1A28", VA = "0x17A1A28")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x17A1CD8", Offset = "0x17A1CD8", VA = "0x17A1CD8")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A24B4", Offset = "0x3A24B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A24B4", Offset = "0x3A24B4")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200005F")]
		public struct Foot
		{
			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Transform transform;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Quaternion rotation;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x49760C", Offset = "0x49760C", VA = "0x49760C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6758", Offset = "0x3A6758")]
		public Grounding forelegSolver;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A67AC", Offset = "0x3A67AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A67AC", Offset = "0x3A67AC")]
		public float rootRotationWeight;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A67FC", Offset = "0x3A67FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A67FC", Offset = "0x3A67FC")]
		public float minRootRotation;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6850", Offset = "0x3A6850")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6850", Offset = "0x3A6850")]
		public float maxRootRotation;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A68A4", Offset = "0x3A68A4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A68D8", Offset = "0x3A68D8")]
		public float maxLegOffset;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A693C", Offset = "0x3A693C")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A69A4", Offset = "0x3A69A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A69A4", Offset = "0x3A69A4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A69F4", Offset = "0x3A69F4")]
		public Transform characterRoot;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6A28", Offset = "0x3A6A28")]
		public Transform pelvis;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6A5C", Offset = "0x3A6A5C")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6A90", Offset = "0x3A6A90")]
		public Transform head;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IK[] legs;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public IK[] forelegs;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A6AFC", Offset = "0x3A6AFC")]
		public Vector3 gravity;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Foot[] feet;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int solvedFeet;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool solved;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float angle;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Transform forefeetRoot;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion headRotation;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float lastWeight;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x17A2010", Offset = "0x17A2010", VA = "0x17A2010")]
		public GrounderQuadruped()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x17A2190", Offset = "0x17A2190", VA = "0x17A2190", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF010", Offset = "0x3AF010")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17A21F0", Offset = "0x17A21F0", VA = "0x17A21F0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF044", Offset = "0x3AF044")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x17A2250", Offset = "0x17A2250", VA = "0x17A2250", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x17A2298", Offset = "0x17A2298", VA = "0x17A2298")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x17A2424", Offset = "0x17A2424", VA = "0x17A2424")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x17A261C", Offset = "0x17A261C", VA = "0x17A261C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x17A26F4", Offset = "0x17A26F4", VA = "0x17A26F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x17A27D4", Offset = "0x17A27D4", VA = "0x17A27D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x17A2C74", Offset = "0x17A2C74", VA = "0x17A2C74")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x17A3284", Offset = "0x17A3284", VA = "0x17A3284")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x17A33DC", Offset = "0x17A33DC", VA = "0x17A33DC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x17A3A88", Offset = "0x17A3A88", VA = "0x17A3A88")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x17A458C", Offset = "0x17A458C", VA = "0x17A458C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x17A495C", Offset = "0x17A495C", VA = "0x17A495C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x17A4B08", Offset = "0x17A4B08", VA = "0x17A4B08")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x17A4F90", Offset = "0x17A4F90", VA = "0x17A4F90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x17A4FC4", Offset = "0x17A4FC4", VA = "0x17A4FC4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2544", Offset = "0x3A2544")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6B0C", Offset = "0x3A6B0C")]
		public VRIK ik;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform[] feet;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x17A52E8", Offset = "0x17A52E8", VA = "0x17A52E8")]
		public GrounderVRIK()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x17A5358", Offset = "0x17A5358", VA = "0x17A5358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF078", Offset = "0x3AF078")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x17A535C", Offset = "0x17A535C", VA = "0x17A535C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF0AC", Offset = "0x3AF0AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x17A5360", Offset = "0x17A5360", VA = "0x17A5360", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF0E0", Offset = "0x3AF0E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x17A5364", Offset = "0x17A5364", VA = "0x17A5364", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x17A538C", Offset = "0x17A538C", VA = "0x17A538C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x17A5450", Offset = "0x17A5450", VA = "0x17A5450")]
		private void Update()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x17A5528", Offset = "0x17A5528", VA = "0x17A5528")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x17A5924", Offset = "0x17A5924", VA = "0x17A5924")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x17A5D6C", Offset = "0x17A5D6C", VA = "0x17A5D6C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x17A5EB8", Offset = "0x17A5EB8", VA = "0x17A5EB8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x17A6230", Offset = "0x17A6230", VA = "0x17A6230")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x17A63B8", Offset = "0x17A63B8", VA = "0x17A63B8")]
		private void OnDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		public enum Quality
		{
			[Token(Token = "0x40002C6")]
			Fastest,
			[Token(Token = "0x40002C7")]
			Simple,
			[Token(Token = "0x40002C8")]
			Best
		}

		[Token(Token = "0x2000063")]
		public class Leg
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A71FC", Offset = "0x3A71FC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A71FC", Offset = "0x3A71FC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7230", Offset = "0x3A7230")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7230", Offset = "0x3A7230")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7264", Offset = "0x3A7264")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7264", Offset = "0x3A7264")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7298", Offset = "0x3A7298")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7298", Offset = "0x3A7298")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A72CC", Offset = "0x3A72CC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A72CC", Offset = "0x3A72CC")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7300", Offset = "0x3A7300")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7300", Offset = "0x3A7300")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7334", Offset = "0x3A7334")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7334", Offset = "0x3A7334")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool invertFootCenter;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Grounding grounding;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float deltaTime;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion r;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private RaycastHit heelHit;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 up;

			[Token(Token = "0x17000061")]
			public bool isGrounded
			{
				[Token(Token = "0x600029C")]
				[Address(RVA = "0x17A7D24", Offset = "0x17A7D24", VA = "0x17A7D24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF1B4", Offset = "0x3AF1B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029D")]
				[Address(RVA = "0x17A87B4", Offset = "0x17A87B4", VA = "0x17A87B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF1C4", Offset = "0x3AF1C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000062")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0x179C234", Offset = "0x179C234", VA = "0x179C234")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF1D4", Offset = "0x3AF1D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600029F")]
				[Address(RVA = "0x17A87BC", Offset = "0x17A87BC", VA = "0x17A87BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF1E4", Offset = "0x3AF1E4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public bool initiated
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0x17A87C8", Offset = "0x17A87C8", VA = "0x17A87C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF1F4", Offset = "0x3AF1F4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002A1")]
				[Address(RVA = "0x17A87D0", Offset = "0x17A87D0", VA = "0x17A87D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF204", Offset = "0x3AF204")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public float heightFromGround
			{
				[Token(Token = "0x60002A2")]
				[Address(RVA = "0x17A87D8", Offset = "0x17A87D8", VA = "0x17A87D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF214", Offset = "0x3AF214")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002A3")]
				[Address(RVA = "0x17A87E0", Offset = "0x17A87E0", VA = "0x17A87E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF224", Offset = "0x3AF224")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public Vector3 velocity
			{
				[Token(Token = "0x60002A4")]
				[Address(RVA = "0x17A87E8", Offset = "0x17A87E8", VA = "0x17A87E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF234", Offset = "0x3AF234")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002A5")]
				[Address(RVA = "0x17A87FC", Offset = "0x17A87FC", VA = "0x17A87FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF244", Offset = "0x3AF244")]
				private set
				{
				}
			}

			[Token(Token = "0x17000066")]
			public Transform transform
			{
				[Token(Token = "0x60002A6")]
				[Address(RVA = "0x179C248", Offset = "0x179C248", VA = "0x179C248")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF254", Offset = "0x3AF254")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002A7")]
				[Address(RVA = "0x17A8808", Offset = "0x17A8808", VA = "0x17A8808")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF264", Offset = "0x3AF264")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public float IKOffset
			{
				[Token(Token = "0x60002A8")]
				[Address(RVA = "0x17A7D1C", Offset = "0x17A7D1C", VA = "0x17A7D1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF274", Offset = "0x3AF274")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002A9")]
				[Address(RVA = "0x17A8810", Offset = "0x17A8810", VA = "0x17A8810")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF284", Offset = "0x3AF284")]
				private set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0x17A96C0", Offset = "0x17A96C0", VA = "0x17A96C0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000069")]
			private float rootYOffset
			{
				[Token(Token = "0x60002B7")]
				[Address(RVA = "0x17A9ABC", Offset = "0x17A9ABC", VA = "0x17A9ABC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x17A6D48", Offset = "0x17A6D48", VA = "0x17A6D48")]
			public Leg()
			{
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x17A6E40", Offset = "0x17A6E40", VA = "0x17A6E40")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x17A8818", Offset = "0x17A8818", VA = "0x17A8818")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x17A81B4", Offset = "0x17A81B4", VA = "0x17A81B4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x17A6FA8", Offset = "0x17A6FA8", VA = "0x17A6FA8")]
			public void Process()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x17A9074", Offset = "0x17A9074", VA = "0x17A9074")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x17A8878", Offset = "0x17A8878", VA = "0x17A8878")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x17A98D8", Offset = "0x17A98D8", VA = "0x17A98D8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x17A8CD0", Offset = "0x17A8CD0", VA = "0x17A8CD0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x17A8DD0", Offset = "0x17A8DD0", VA = "0x17A8DD0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x17A9A28", Offset = "0x17A9A28", VA = "0x17A9A28")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x17A9794", Offset = "0x17A9794", VA = "0x17A9794")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x17A9C44", Offset = "0x17A9C44", VA = "0x17A9C44")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000064")]
		public class Pelvis
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7368", Offset = "0x3A7368")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7368", Offset = "0x3A7368")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A739C", Offset = "0x3A739C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A739C", Offset = "0x3A739C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Grounding grounding;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float damperF;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool initiated;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float lastTime;

			[Token(Token = "0x1700006A")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60002B9")]
				[Address(RVA = "0x179DE58", Offset = "0x179DE58", VA = "0x179DE58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF294", Offset = "0x3AF294")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002BA")]
				[Address(RVA = "0x17A9DCC", Offset = "0x17A9DCC", VA = "0x17A9DCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF2A4", Offset = "0x3AF2A4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public float heightOffset
			{
				[Token(Token = "0x60002BB")]
				[Address(RVA = "0x17A4954", Offset = "0x17A4954", VA = "0x17A4954")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF2B4", Offset = "0x3AF2B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002BC")]
				[Address(RVA = "0x17A9DD8", Offset = "0x17A9DD8", VA = "0x17A9DD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF2C4", Offset = "0x3AF2C4")]
				private set
				{
				}
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x17A6E38", Offset = "0x17A6E38", VA = "0x17A6E38")]
			public Pelvis()
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x17A6F80", Offset = "0x17A6F80", VA = "0x17A6F80")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x17A80A4", Offset = "0x17A80A4", VA = "0x17A80A4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x17A9DE0", Offset = "0x17A9DE0", VA = "0x17A9DE0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x17A7D2C", Offset = "0x17A7D2C", VA = "0x17A7D2C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6B58", Offset = "0x3A6B58")]
		public LayerMask layers;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6B8C", Offset = "0x3A6B8C")]
		public float maxStep;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6BC0", Offset = "0x3A6BC0")]
		public float heightOffset;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6C0C", Offset = "0x3A6C0C")]
		public float footSpeed;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6C60", Offset = "0x3A6C60")]
		public float footRadius;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6C94", Offset = "0x3A6C94")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A6C94", Offset = "0x3A6C94")]
		public float footCenterOffset;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6D0C", Offset = "0x3A6D0C")]
		public float prediction;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6D74", Offset = "0x3A6D74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6D74", Offset = "0x3A6D74")]
		public float footRotationWeight;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6DF8", Offset = "0x3A6DF8")]
		public float footRotationSpeed;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6E5C", Offset = "0x3A6E5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6E5C", Offset = "0x3A6E5C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6EB0", Offset = "0x3A6EB0")]
		public bool rotateSolver;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6EE4", Offset = "0x3A6EE4")]
		public float pelvisSpeed;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6F3C", Offset = "0x3A6F3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A6F3C", Offset = "0x3A6F3C")]
		public float pelvisDamper;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A6FC4", Offset = "0x3A6FC4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7028", Offset = "0x3A7028")]
		public float liftPelvisWeight;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A705C", Offset = "0x3A705C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7090", Offset = "0x3A7090")]
		public bool overstepFallsDown;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A70C4", Offset = "0x3A70C4")]
		public Quality quality;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A70F8", Offset = "0x3A70F8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A70F8", Offset = "0x3A70F8")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A712C", Offset = "0x3A712C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A712C", Offset = "0x3A712C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7160", Offset = "0x3A7160")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7160", Offset = "0x3A7160")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A7194", Offset = "0x3A7194")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A7194", Offset = "0x3A7194")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A71C8", Offset = "0x3A71C8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A71C8", Offset = "0x3A71C8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool initiated;

		[Token(Token = "0x17000059")]
		public Leg[] legs
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x179BD18", Offset = "0x179BD18", VA = "0x179BD18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF114", Offset = "0x3AF114")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x17A6670", Offset = "0x17A6670", VA = "0x17A6670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF124", Offset = "0x3AF124")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x179DE50", Offset = "0x179DE50", VA = "0x179DE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF134", Offset = "0x3AF134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x17A6678", Offset = "0x17A6678", VA = "0x17A6678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF144", Offset = "0x3AF144")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool isGrounded
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x17A6680", Offset = "0x17A6680", VA = "0x17A6680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF154", Offset = "0x3AF154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x17A6688", Offset = "0x17A6688", VA = "0x17A6688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF164", Offset = "0x3AF164")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public Transform root
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x179C22C", Offset = "0x179C22C", VA = "0x179C22C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF174", Offset = "0x3AF174")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x17A6690", Offset = "0x17A6690", VA = "0x17A6690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF184", Offset = "0x3AF184")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x17A3A68", Offset = "0x17A3A68", VA = "0x17A3A68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF194", Offset = "0x3AF194")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x17A6698", Offset = "0x17A6698", VA = "0x17A6698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF1A4", Offset = "0x3AF1A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool rootGrounded
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x17A66F0", Offset = "0x17A66F0", VA = "0x17A66F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public Vector3 up
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x179DFC4", Offset = "0x179DFC4", VA = "0x179DFC4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000060")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x17A82D0", Offset = "0x17A82D0", VA = "0x17A82D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x179BAE8", Offset = "0x179BAE8", VA = "0x179BAE8")]
		public Grounding()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x17A674C", Offset = "0x17A674C", VA = "0x17A674C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x17A6C40", Offset = "0x17A6C40", VA = "0x17A6C40")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x179CEC4", Offset = "0x179CEC4", VA = "0x179CEC4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x179DB84", Offset = "0x179DB84", VA = "0x179DB84")]
		public void Update()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x17A072C", Offset = "0x17A072C", VA = "0x17A072C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x179C6C4", Offset = "0x179C6C4", VA = "0x179C6C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x17A6F90", Offset = "0x17A6F90", VA = "0x17A6F90")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x17A83B8", Offset = "0x17A83B8", VA = "0x17A83B8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x17A853C", Offset = "0x17A853C", VA = "0x17A853C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x17A8678", Offset = "0x17A8678", VA = "0x17A8678")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A25A4", Offset = "0x3A25A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A25A4", Offset = "0x3A25A4")]
	public class AimIK : IK
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverAim solver;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD9DE60", Offset = "0xD9DE60", VA = "0xD9DE60")]
		public AimIK()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD9DEDC", Offset = "0xD9DEDC", VA = "0xD9DEDC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF2D4", Offset = "0x3AF2D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD9DF3C", Offset = "0xD9DF3C", VA = "0xD9DF3C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF308", Offset = "0x3AF308")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xD9DF9C", Offset = "0xD9DF9C", VA = "0xD9DF9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF33C", Offset = "0x3AF33C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD9DFFC", Offset = "0xD9DFFC", VA = "0xD9DFFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF370", Offset = "0x3AF370")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xD9E05C", Offset = "0xD9E05C", VA = "0xD9E05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF3A4", Offset = "0x3AF3A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD9E0BC", Offset = "0xD9E0BC", VA = "0xD9E0BC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2624", Offset = "0x3A2624")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverArm solver;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xD9ED8C", Offset = "0xD9ED8C", VA = "0xD9ED8C")]
		public ArmIK()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD9EE08", Offset = "0xD9EE08", VA = "0xD9EE08", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF3D8", Offset = "0x3AF3D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xD9EE94", Offset = "0xD9EE94", VA = "0xD9EE94", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF40C", Offset = "0x3AF40C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD9EF20", Offset = "0xD9EF20", VA = "0xD9EF20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF440", Offset = "0x3AF440")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xD9EF80", Offset = "0xD9EF80", VA = "0xD9EF80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF474", Offset = "0x3AF474")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xD9EFE0", Offset = "0xD9EFE0", VA = "0xD9EFE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2678", Offset = "0x3A2678")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2678", Offset = "0x3A2678")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xDA11C8", Offset = "0xDA11C8", VA = "0xDA11C8")]
		public CCDIK()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xDA1244", Offset = "0xDA1244", VA = "0xDA1244", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF4A8", Offset = "0x3AF4A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xDA12A4", Offset = "0xDA12A4", VA = "0xDA12A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF4DC", Offset = "0x3AF4DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xDA1304", Offset = "0xDA1304", VA = "0xDA1304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF510", Offset = "0x3AF510")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xDA1364", Offset = "0xDA1364", VA = "0xDA1364")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF544", Offset = "0x3AF544")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xDA13C4", Offset = "0xDA13C4", VA = "0xDA13C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2728", Offset = "0x3A2728")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2728", Offset = "0x3A2728")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xDA1EC0", Offset = "0xDA1EC0", VA = "0xDA1EC0")]
		public FABRIK()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xDA1F3C", Offset = "0xDA1F3C", VA = "0xDA1F3C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF578", Offset = "0x3AF578")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xDA1F9C", Offset = "0xDA1F9C", VA = "0xDA1F9C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF5AC", Offset = "0x3AF5AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xDA1FFC", Offset = "0xDA1FFC", VA = "0xDA1FFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF5E0", Offset = "0x3AF5E0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xDA205C", Offset = "0xDA205C", VA = "0xDA205C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF614", Offset = "0x3AF614")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xDA20BC", Offset = "0xDA20BC", VA = "0xDA20BC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A27D8", Offset = "0x3A27D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A27D8", Offset = "0x3A27D8")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xDA2B0C", Offset = "0xDA2B0C", VA = "0xDA2B0C")]
		public FABRIKRoot()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xDA2B88", Offset = "0xDA2B88", VA = "0xDA2B88", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF648", Offset = "0x3AF648")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xDA2BE8", Offset = "0xDA2BE8", VA = "0xDA2BE8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF67C", Offset = "0x3AF67C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xDA2C48", Offset = "0xDA2C48", VA = "0xDA2C48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF6B0", Offset = "0x3AF6B0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xDA2CA8", Offset = "0xDA2CA8", VA = "0xDA2CA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF6E4", Offset = "0x3AF6E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xDA2D08", Offset = "0xDA2D08", VA = "0xDA2D08", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A288C", Offset = "0x3A288C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A288C", Offset = "0x3A288C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x179A410", Offset = "0x179A410", VA = "0x179A410")]
		public FullBodyBipedIK()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x179A4B8", Offset = "0x179A4B8", VA = "0x179A4B8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF718", Offset = "0x3AF718")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x179A518", Offset = "0x179A518", VA = "0x179A518", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF74C", Offset = "0x3AF74C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x179A578", Offset = "0x179A578", VA = "0x179A578")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF780", Offset = "0x3AF780")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x179A5D8", Offset = "0x179A5D8", VA = "0x179A5D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF7C4", Offset = "0x3AF7C4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x179A638", Offset = "0x179A638", VA = "0x179A638")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF80C", Offset = "0x3AF80C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x179A698", Offset = "0x179A698", VA = "0x179A698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF840", Offset = "0x3AF840")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x179A6F8", Offset = "0x179A6F8", VA = "0x179A6F8")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x179A738", Offset = "0x179A738", VA = "0x179A738", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x179A740", Offset = "0x179A740", VA = "0x179A740")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x179A9E4", Offset = "0x179A9E4", VA = "0x179A9E4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x179AE70", Offset = "0x179AE70", VA = "0x179AE70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF874", Offset = "0x3AF874")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x179AEA8", Offset = "0x179AEA8", VA = "0x179AEA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF8AC", Offset = "0x3AF8AC")]
		private void AutoDetectReferences()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x179A4B0", Offset = "0x179A4B0", VA = "0x179A4B0")]
		protected IK()
		{
		}

		[Token(Token = "0x60002EE")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x17AD770", Offset = "0x17AD770", VA = "0x17AD770", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x17AD82C", Offset = "0x17AD82C", VA = "0x17AD82C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x17AD8B4", Offset = "0x17AD8B4", VA = "0x17AD8B4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F2")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60002F3")]
		protected abstract void OpenScriptReference();
	}
	[Token(Token = "0x200006C")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A73D0", Offset = "0x3A73D0")]
		public IK[] IKComponents;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7404", Offset = "0x3A7404")]
		public Animator animator;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool fixedFrame;

		[Token(Token = "0x1700006C")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x17B1344", Offset = "0x17B1344", VA = "0x17B1344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x17B133C", Offset = "0x17B133C", VA = "0x17B133C")]
		public IKExecutionOrder()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x17B140C", Offset = "0x17B140C", VA = "0x17B140C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x17B14A0", Offset = "0x17B14A0", VA = "0x17B14A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x17B15D4", Offset = "0x17B15D4", VA = "0x17B15D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x17B1604", Offset = "0x17B1604", VA = "0x17B1604")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x17B14C4", Offset = "0x17B14C4", VA = "0x17B14C4")]
		private void FixTransforms()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2918", Offset = "0x3A2918")]
	public class LegIK : IK
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLeg solver;

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x14E7EA8", Offset = "0x14E7EA8", VA = "0x14E7EA8")]
		public LegIK()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x14E7F24", Offset = "0x14E7F24", VA = "0x14E7F24", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF8E0", Offset = "0x3AF8E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x14E7FB0", Offset = "0x14E7FB0", VA = "0x14E7FB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF914", Offset = "0x3AF914")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x14E803C", Offset = "0x14E803C", VA = "0x14E803C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF948", Offset = "0x3AF948")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x14E809C", Offset = "0x14E809C", VA = "0x14E809C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF97C", Offset = "0x3AF97C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x14E80FC", Offset = "0x14E80FC", VA = "0x14E80FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A296C", Offset = "0x3A296C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A296C", Offset = "0x3A296C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x14E8104", Offset = "0x14E8104", VA = "0x14E8104")]
		public LimbIK()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x14E8180", Offset = "0x14E8180", VA = "0x14E8180", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF9B0", Offset = "0x3AF9B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x14E81E0", Offset = "0x14E81E0", VA = "0x14E81E0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AF9E4", Offset = "0x3AF9E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x14E8240", Offset = "0x14E8240", VA = "0x14E8240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFA18", Offset = "0x3AFA18")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x14E82A0", Offset = "0x14E82A0", VA = "0x14E82A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFA4C", Offset = "0x3AFA4C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x14E8300", Offset = "0x14E8300", VA = "0x14E8300", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2A1C", Offset = "0x3A2A1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2A1C", Offset = "0x3A2A1C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14E966C", Offset = "0x14E966C", VA = "0x14E966C")]
		public LookAtIK()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x14E96E8", Offset = "0x14E96E8", VA = "0x14E96E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFA80", Offset = "0x3AFA80")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x14E9748", Offset = "0x14E9748", VA = "0x14E9748", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFAB4", Offset = "0x3AFAB4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x14E97A8", Offset = "0x14E97A8", VA = "0x14E97A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFAE8", Offset = "0x3AFAE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x14E9808", Offset = "0x14E9808", VA = "0x14E9808")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFB1C", Offset = "0x3AFB1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x14E9868", Offset = "0x14E9868", VA = "0x14E9868", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2AD0", Offset = "0x3A2AD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2AD0", Offset = "0x3A2AD0")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x12EC6BC", Offset = "0x12EC6BC", VA = "0x12EC6BC")]
		public TrigonometricIK()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x12EC738", Offset = "0x12EC738", VA = "0x12EC738", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFB50", Offset = "0x3AFB50")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x12EC798", Offset = "0x12EC798", VA = "0x12EC798", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFB84", Offset = "0x3AFB84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x12EC7F8", Offset = "0x12EC7F8", VA = "0x12EC7F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFBB8", Offset = "0x3AFBB8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12EC858", Offset = "0x12EC858", VA = "0x12EC858")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFBEC", Offset = "0x3AFBEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x12EC8B8", Offset = "0x12EC8B8", VA = "0x12EC8B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2B88", Offset = "0x3A2B88")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public class References
		{
			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform root;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform pelvis;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform spine;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7500", Offset = "0x3A7500")]
			public Transform chest;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7534", Offset = "0x3A7534")]
			public Transform neck;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Transform head;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7568", Offset = "0x3A7568")]
			public Transform leftShoulder;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Transform leftUpperArm;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform leftForearm;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Transform leftHand;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A759C", Offset = "0x3A759C")]
			public Transform rightShoulder;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Transform rightUpperArm;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform rightForearm;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Transform rightHand;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A75D0", Offset = "0x3A75D0")]
			public Transform leftThigh;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7604", Offset = "0x3A7604")]
			public Transform leftCalf;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7638", Offset = "0x3A7638")]
			public Transform leftFoot;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A766C", Offset = "0x3A766C")]
			public Transform leftToes;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A76A0", Offset = "0x3A76A0")]
			public Transform rightThigh;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A76D4", Offset = "0x3A76D4")]
			public Transform rightCalf;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7708", Offset = "0x3A7708")]
			public Transform rightFoot;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A773C", Offset = "0x3A773C")]
			public Transform rightToes;

			[Token(Token = "0x1700006D")]
			public bool isFilled
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x12EE850", Offset = "0x12EE850", VA = "0x12EE850")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006E")]
			public bool isEmpty
			{
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x12EE1D0", Offset = "0x12EE1D0", VA = "0x12EE1D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x12ED8EC", Offset = "0x12ED8EC", VA = "0x12ED8EC")]
			public References()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x12EF0C8", Offset = "0x12EF0C8", VA = "0x12EF0C8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x12EDA8C", Offset = "0x12EDA8C", VA = "0x12EDA8C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x3A7438", Offset = "0x3A7438")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7438", Offset = "0x3A7438")]
		public References references;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A74C0", Offset = "0x3A74C0")]
		public IKSolverVR solver;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12ED84C", Offset = "0x12ED84C", VA = "0x12ED84C")]
		public VRIK()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x12ED8F4", Offset = "0x12ED8F4", VA = "0x12ED8F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFC20", Offset = "0x3AFC20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12ED980", Offset = "0x12ED980", VA = "0x12ED980", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFC54", Offset = "0x3AFC54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x12EDA0C", Offset = "0x12EDA0C", VA = "0x12EDA0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFC88", Offset = "0x3AFC88")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x12EDA6C", Offset = "0x12EDA6C", VA = "0x12EDA6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFCD4", Offset = "0x3AFCD4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x12EE0EC", Offset = "0x12EE0EC", VA = "0x12EE0EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFD08", Offset = "0x3AFD08")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x12EE124", Offset = "0x12EE124", VA = "0x12EE124", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x12EE12C", Offset = "0x12EE12C", VA = "0x12EE12C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12EEF0C", Offset = "0x12EEF0C", VA = "0x12EEF0C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FABRIK ik;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7770", Offset = "0x3A7770")]
		public float pull;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7788", Offset = "0x3A7788")]
		public float pin;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] children;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xDA20C4", Offset = "0xDA20C4", VA = "0xDA20C4")]
		public FABRIKChain()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDA2144", Offset = "0xDA2144", VA = "0xDA2144")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xDA2238", Offset = "0xDA2238", VA = "0xDA2238")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xDA2268", Offset = "0xDA2268", VA = "0xDA2268")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xDA2910", Offset = "0xDA2910", VA = "0xDA2910")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xDA23FC", Offset = "0xDA23FC", VA = "0xDA23FC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000074")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xDA2D10", Offset = "0xDA2D10", VA = "0xDA2D10")]
		public FBBIKArmBending()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xDA2D18", Offset = "0xDA2D18", VA = "0xDA2D18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xDA3644", Offset = "0xDA3644", VA = "0xDA3644")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xDA3988", Offset = "0xDA3988", VA = "0xDA3988")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public class BendBone
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7F4C", Offset = "0x3A7F4C")]
			public Transform transform;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7F98", Offset = "0x3A7F98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7F98", Offset = "0x3A7F98")]
			public float weight;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x17923D0", Offset = "0x17923D0", VA = "0x17923D0")]
			public BendBone()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1792484", Offset = "0x1792484", VA = "0x1792484")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1792554", Offset = "0x1792554", VA = "0x1792554")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x17925A4", Offset = "0x17925A4", VA = "0x17925A4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A77A0", Offset = "0x3A77A0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A77D4", Offset = "0x3A77D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A77D4", Offset = "0x3A77D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A77D4", Offset = "0x3A77D4")]
		public float positionWeight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A786C", Offset = "0x3A786C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A786C", Offset = "0x3A786C")]
		public float bodyWeight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A78E8", Offset = "0x3A78E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A78E8", Offset = "0x3A78E8")]
		public float thighWeight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7964", Offset = "0x3A7964")]
		public bool handsPullBody;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A7998", Offset = "0x3A7998")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7998", Offset = "0x3A7998")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7998", Offset = "0x3A7998")]
		public float rotationWeight;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7A3C", Offset = "0x3A7A3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7A3C", Offset = "0x3A7A3C")]
		public float bodyClampWeight;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7AA8", Offset = "0x3A7AA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7AA8", Offset = "0x3A7AA8")]
		public float headClampWeight;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7B14", Offset = "0x3A7B14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7B14", Offset = "0x3A7B14")]
		public float bendWeight;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7B64", Offset = "0x3A7B64")]
		public BendBone[] bendBones;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A7BB0", Offset = "0x3A7BB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7BB0", Offset = "0x3A7BB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7BB0", Offset = "0x3A7BB0")]
		public float CCDWeight;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7C24", Offset = "0x3A7C24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7C24", Offset = "0x3A7C24")]
		public float roll;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7CA4", Offset = "0x3A7CA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7CA4", Offset = "0x3A7CA4")]
		public float damper;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7D0C", Offset = "0x3A7D0C")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A7D78", Offset = "0x3A7D78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7D78", Offset = "0x3A7D78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7D78", Offset = "0x3A7D78")]
		public float postStretchWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7DF4", Offset = "0x3A7DF4")]
		public float maxStretch;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7E3C", Offset = "0x3A7E3C")]
		public float stretchDamper;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7E90", Offset = "0x3A7E90")]
		public bool fixHead;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A7EC4", Offset = "0x3A7EC4")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x3A7EF8", Offset = "0x3A7EF8")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A7F34", Offset = "0x3A7F34")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform[] chestBones;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 offset;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 headToBody;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float shoulderDist;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float leftShoulderDist;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float rightShoulderDist;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int bendBonesCount;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int ccdBonesCount;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int stretchBonesCount;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int chestBonesCount;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xDA3B30", Offset = "0xDA3B30", VA = "0xDA3B30")]
		public FBBIKHeadEffector()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xDA3CF0", Offset = "0xDA3CF0", VA = "0xDA3CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xDA4398", Offset = "0xDA4398", VA = "0xDA4398")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xDA4B80", Offset = "0xDA4B80", VA = "0xDA4B80")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xDA527C", Offset = "0xDA527C", VA = "0xDA527C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xDA60E4", Offset = "0xDA60E4", VA = "0xDA60E4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xDA6600", Offset = "0xDA6600", VA = "0xDA6600")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xDA6BD8", Offset = "0xDA6BD8", VA = "0xDA6BD8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xDA7C98", Offset = "0xDA7C98", VA = "0xDA7C98")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xDA5D0C", Offset = "0xDA5D0C", VA = "0xDA5D0C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xDA7FAC", Offset = "0xDA7FAC", VA = "0xDA7FAC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xDA7ADC", Offset = "0xDA7ADC", VA = "0xDA7ADC")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xDA78FC", Offset = "0xDA78FC", VA = "0xDA78FC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xDA8504", Offset = "0xDA8504", VA = "0xDA8504")]
		private void OnDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public class ChildConstraint
		{
			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float pushElasticity;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pullElasticity;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A80A0", Offset = "0x3A80A0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A80A0", Offset = "0x3A80A0")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A80D4", Offset = "0x3A80D4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A80D4", Offset = "0x3A80D4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float crossFade;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float inverseCrossFade;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int chain1Index;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int chain2Index;

			[Token(Token = "0x1700006F")]
			public float nominalDistance
			{
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x1798454", Offset = "0x1798454", VA = "0x1798454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFD4C", Offset = "0x3AFD4C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x179845C", Offset = "0x179845C", VA = "0x179845C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFD5C", Offset = "0x3AFD5C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public bool isRigid
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x1798464", Offset = "0x1798464", VA = "0x1798464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFD6C", Offset = "0x3AFD6C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x179846C", Offset = "0x179846C", VA = "0x179846C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFD7C", Offset = "0x3AFD7C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x179841C", Offset = "0x179841C", VA = "0x179841C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1793A44", Offset = "0x1793A44", VA = "0x1793A44")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x17948E8", Offset = "0x17948E8", VA = "0x17948E8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1797F10", Offset = "0x1797F10", VA = "0x1797F10")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public enum Smoothing
		{
			[Token(Token = "0x4000366")]
			None,
			[Token(Token = "0x4000367")]
			Exponential,
			[Token(Token = "0x4000368")]
			Cubic
		}

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8004", Offset = "0x3A8004")]
		public float pin;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A801C", Offset = "0x3A801C")]
		public float pull;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8034", Offset = "0x3A8034")]
		public float push;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A804C", Offset = "0x3A804C")]
		public float pushParent;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8068", Offset = "0x3A8068")]
		public float reach;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] children;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float rootLength;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool initiated;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float length;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float distance;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private IKSolver.Point p;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float reachForce;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float pullParentSum;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] crossFades;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float sqrMag1;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sqrMag2;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float sqrMagDif;

		[Token(Token = "0x400035A")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x17925FC", Offset = "0x17925FC", VA = "0x17925FC")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1792798", Offset = "0x1792798", VA = "0x1792798")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17928BC", Offset = "0x17928BC", VA = "0x17928BC")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1792A1C", Offset = "0x1792A1C", VA = "0x1792A1C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1792B30", Offset = "0x1792B30", VA = "0x1792B30")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1792C78", Offset = "0x1792C78", VA = "0x1792C78")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1793ECC", Offset = "0x1793ECC", VA = "0x1793ECC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1792F54", Offset = "0x1792F54", VA = "0x1792F54")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1794C20", Offset = "0x1794C20", VA = "0x1794C20")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1795208", Offset = "0x1795208", VA = "0x1795208")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x179588C", Offset = "0x179588C", VA = "0x179588C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1796910", Offset = "0x1796910", VA = "0x1796910")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x179754C", Offset = "0x179754C", VA = "0x179754C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1797A54", Offset = "0x1797A54", VA = "0x1797A54")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x179740C", Offset = "0x179740C", VA = "0x179740C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x17966BC", Offset = "0x17966BC", VA = "0x17966BC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1797378", Offset = "0x1797378", VA = "0x1797378")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1797C8C", Offset = "0x1797C8C", VA = "0x1797C8C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x179712C", Offset = "0x179712C", VA = "0x179712C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1797788", Offset = "0x1797788", VA = "0x1797788")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone1;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone2;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone3;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bendGoal;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 direction;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8108", Offset = "0x3A8108")]
		public float weight;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float clampF;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int chainIndex1;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int nodeIndex1;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int chainIndex2;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int nodeIndex2;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int chainIndex3;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int nodeIndex3;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8120", Offset = "0x3A8120")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8120", Offset = "0x3A8120")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000071")]
		public bool initiated
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1795E8C", Offset = "0x1795E8C", VA = "0x1795E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFD8C", Offset = "0x3AFD8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x17ADD58", Offset = "0x17ADD58", VA = "0x17ADD58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFD9C", Offset = "0x3AFD9C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x17926E8", Offset = "0x17926E8", VA = "0x17926E8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x17AD934", Offset = "0x17AD934", VA = "0x17AD934")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x17AD9FC", Offset = "0x17AD9FC", VA = "0x17AD9FC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1793AB4", Offset = "0x1793AB4", VA = "0x1793AB4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1793AC0", Offset = "0x1793AC0", VA = "0x1793AC0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17AE090", Offset = "0x17AE090", VA = "0x17AE090")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17AE368", Offset = "0x17AE368", VA = "0x17AE368")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1795E94", Offset = "0x1795E94", VA = "0x1795E94")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x17ADD60", Offset = "0x17ADD60", VA = "0x17ADD60")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x17ADEF8", Offset = "0x17ADEF8", VA = "0x17ADEF8")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKEffector
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8154", Offset = "0x3A8154")]
		public float positionWeight;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A816C", Offset = "0x3A816C")]
		public float rotationWeight;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8184", Offset = "0x3A8184")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8184", Offset = "0x3A8184")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool effectChildNodes;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A81B8", Offset = "0x3A81B8")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] childBones;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform planeBone1;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform planeBone2;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Transform planeBone3;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float posW;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float rotW;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] localPositions;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool usePlaneNodes;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool firstUpdate;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int chainIndex;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int nodeIndex;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[] childChainIndexes;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000072")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x17AEE20", Offset = "0x17AEE20", VA = "0x17AEE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFDAC", Offset = "0x3AFDAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x17AEE28", Offset = "0x17AEE28", VA = "0x17AEE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFDBC", Offset = "0x3AFDBC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x17AE9FC", Offset = "0x17AE9FC", VA = "0x17AE9FC")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x17AEBB0", Offset = "0x17AEBB0", VA = "0x17AEBB0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x17AED74", Offset = "0x17AED74", VA = "0x17AED74")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x17AEE30", Offset = "0x17AEE30", VA = "0x17AEE30")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x17AEF54", Offset = "0x17AEF54", VA = "0x17AEF54")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x17AF534", Offset = "0x17AF534", VA = "0x17AF534")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x17AF99C", Offset = "0x17AF99C", VA = "0x17AF99C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x17AFB8C", Offset = "0x17AFB8C", VA = "0x17AFB8C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x17AFC94", Offset = "0x17AFC94", VA = "0x17AFC94")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x17B0640", Offset = "0x17B0640", VA = "0x17B0640")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x17B06D8", Offset = "0x17B06D8", VA = "0x17B06D8")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x17B09B4", Offset = "0x17B09B4", VA = "0x17B09B4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x17B0EF0", Offset = "0x17B0EF0", VA = "0x17B0EF0")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public class BoneMap
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int chainIndex;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nodeIndex;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 planePosition;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 ikPosition;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public float length;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Transform planeBone1;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Transform planeBone2;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Transform planeBone3;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int plane1ChainIndex;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private int plane1NodeIndex;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private int plane2ChainIndex;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private int plane2NodeIndex;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int plane3ChainIndex;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000073")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x17B1A3C", Offset = "0x17B1A3C", VA = "0x17B1A3C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000074")]
			public bool isNodeBone
			{
				[Token(Token = "0x600037E")]
				[Address(RVA = "0x17B1C30", Offset = "0x17B1C30", VA = "0x17B1C30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x17B235C", Offset = "0x17B235C", VA = "0x17B235C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x17B19B0", Offset = "0x17B19B0", VA = "0x17B19B0")]
			public BoneMap()
			{
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x17B19E8", Offset = "0x17B19E8", VA = "0x17B19E8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x17B1B14", Offset = "0x17B1B14", VA = "0x17B1B14")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x17B1B98", Offset = "0x17B1B98", VA = "0x17B1B98")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x17B1C44", Offset = "0x17B1C44", VA = "0x17B1C44")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x17B1D40", Offset = "0x17B1D40", VA = "0x17B1D40")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x17B1D48", Offset = "0x17B1D48", VA = "0x17B1D48")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x17B1F0C", Offset = "0x17B1F0C", VA = "0x17B1F0C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x17B205C", Offset = "0x17B205C", VA = "0x17B205C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x17B2154", Offset = "0x17B2154", VA = "0x17B2154")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x17B25FC", Offset = "0x17B25FC", VA = "0x17B25FC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x17B2644", Offset = "0x17B2644", VA = "0x17B2644")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x17B2694", Offset = "0x17B2694", VA = "0x17B2694")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x17B26E0", Offset = "0x17B26E0", VA = "0x17B26E0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x17B2890", Offset = "0x17B2890", VA = "0x17B2890")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x17B2C88", Offset = "0x17B2C88", VA = "0x17B2C88")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x17B2CD4", Offset = "0x17B2CD4", VA = "0x17B2CD4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x17B2E98", Offset = "0x17B2E98", VA = "0x17B2E98")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x17B2F10", Offset = "0x17B2F10", VA = "0x17B2F10")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x17B31DC", Offset = "0x17B31DC", VA = "0x17B31DC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x17B34A0", Offset = "0x17B34A0", VA = "0x17B34A0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x17B35C8", Offset = "0x17B35C8", VA = "0x17B35C8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x17B29E8", Offset = "0x17B29E8", VA = "0x17B29E8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x17B16D4", Offset = "0x17B16D4", VA = "0x17B16D4")]
		public IKMapping()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17B16DC", Offset = "0x17B16DC", VA = "0x17B16DC", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x17B16E4", Offset = "0x17B16E4", VA = "0x17B16E4", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x17B16E8", Offset = "0x17B16E8", VA = "0x17B16E8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x17B1870", Offset = "0x17B1870", VA = "0x17B1870")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A81D0", Offset = "0x3A81D0")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoneMap boneMap;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x17B380C", Offset = "0x17B380C", VA = "0x17B380C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x17B38B0", Offset = "0x17B38B0", VA = "0x17B38B0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x17B395C", Offset = "0x17B395C", VA = "0x17B395C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x17B3A14", Offset = "0x17B3A14", VA = "0x17B3A14")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x17B3A3C", Offset = "0x17B3A3C", VA = "0x17B3A3C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x17B3A68", Offset = "0x17B3A68", VA = "0x17B3A68", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x17B3B40", Offset = "0x17B3B40", VA = "0x17B3B40")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x17B3B68", Offset = "0x17B3B68", VA = "0x17B3B68")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public enum BoneMapType
		{
			[Token(Token = "0x40003BF")]
			Parent,
			[Token(Token = "0x40003C0")]
			Bone1,
			[Token(Token = "0x40003C1")]
			Bone2,
			[Token(Token = "0x40003C2")]
			Bone3
		}

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform parentBone;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone1;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone2;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bone3;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A81E8", Offset = "0x3A81E8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8200", Offset = "0x3A8200")]
		public float weight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BoneMap boneMap1;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap boneMap2;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap boneMap3;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x17B3BA8", Offset = "0x17B3BA8", VA = "0x17B3BA8")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x17B3CE8", Offset = "0x17B3CE8", VA = "0x17B3CE8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x17B3E60", Offset = "0x17B3E60", VA = "0x17B3E60", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x17B3EE0", Offset = "0x17B3EE0", VA = "0x17B3EE0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x17B3FD0", Offset = "0x17B3FD0", VA = "0x17B3FD0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x17B3E4C", Offset = "0x17B3E4C", VA = "0x17B3E4C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x17B4400", Offset = "0x17B4400", VA = "0x17B4400")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x17B4504", Offset = "0x17B4504", VA = "0x17B4504")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x17B4618", Offset = "0x17B4618", VA = "0x17B4618", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x17B49D0", Offset = "0x17B49D0", VA = "0x17B49D0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x17B4AD0", Offset = "0x17B4AD0", VA = "0x17B4AD0")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform[] spineBones;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftThighBone;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightThighBone;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8218", Offset = "0x3A8218")]
		public int iterations;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8234", Offset = "0x3A8234")]
		public float twistWeight;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int rootNodeIndex;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap[] spine;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private BoneMap leftThigh;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap rightThigh;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool useFABRIK;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x17B4D5C", Offset = "0x17B4D5C", VA = "0x17B4D5C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17B4EC0", Offset = "0x17B4EC0", VA = "0x17B4EC0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x17B507C", Offset = "0x17B507C", VA = "0x17B507C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x17B5054", Offset = "0x17B5054", VA = "0x17B5054")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x17B5474", Offset = "0x17B5474", VA = "0x17B5474")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x17B5500", Offset = "0x17B5500", VA = "0x17B5500")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x17B55C8", Offset = "0x17B55C8", VA = "0x17B55C8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x17B60F4", Offset = "0x17B60F4", VA = "0x17B60F4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x17B6138", Offset = "0x17B6138", VA = "0x17B6138")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x17B664C", Offset = "0x17B664C", VA = "0x17B664C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x17B6D84", Offset = "0x17B6D84", VA = "0x17B6D84")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x17B6FE0", Offset = "0x17B6FE0", VA = "0x17B6FE0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x17B7214", Offset = "0x17B7214", VA = "0x17B7214")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class Point
		{
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A833C", Offset = "0x3A833C")]
			public float weight;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 solverPosition;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion solverRotation;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1844154", Offset = "0x1844154", VA = "0x1844154")]
			public Point()
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1844248", Offset = "0x1844248", VA = "0x1844248")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x18442CC", Offset = "0x18442CC", VA = "0x18442CC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x18444A0", Offset = "0x18444A0", VA = "0x18444A0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x18444E8", Offset = "0x18444E8", VA = "0x18444E8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1844530", Offset = "0x1844530", VA = "0x1844530")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x18445B4", Offset = "0x18445B4", VA = "0x18445B4")]
			public void UpdateSolverLocalState()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public class Bone : Point
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool isLimited;

			[Token(Token = "0x17000077")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x17B8608", Offset = "0x17B8608", VA = "0x17B8608")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0x17B8734", Offset = "0x17B8734", VA = "0x17B8734")]
				set
				{
				}
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x17B838C", Offset = "0x17B838C", VA = "0x17B838C")]
			public Bone()
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x17B8454", Offset = "0x17B8454", VA = "0x17B8454")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x17B8524", Offset = "0x17B8524", VA = "0x17B8524")]
			public Bone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x17B87C8", Offset = "0x17B87C8", VA = "0x17B87C8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x17B8B04", Offset = "0x17B8B04", VA = "0x17B8B04")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x17B8FC0", Offset = "0x17B8FC0", VA = "0x17B8FC0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x17B9270", Offset = "0x17B9270", VA = "0x17B9270")]
			public void SetToSolverPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class Node : Point
		{
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float effectorPositionWeight;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float effectorRotationWeight;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 offset;

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1844150", Offset = "0x1844150", VA = "0x1844150")]
			public Node()
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1844208", Offset = "0x1844208", VA = "0x1844208")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1844224", Offset = "0x1844224", VA = "0x1844224")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000086")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000087")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A824C", Offset = "0x3A824C")]
		public Vector3 IKPosition;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A825C", Offset = "0x3A825C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A825C", Offset = "0x3A825C")]
		public float IKPositionWeight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A82D8", Offset = "0x3A82D8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A82D8", Offset = "0x3A82D8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected bool firstInitiation;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A830C", Offset = "0x3A830C")]
		protected Transform root;

		[Token(Token = "0x17000076")]
		public bool initiated
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x179C888", Offset = "0x179C888", VA = "0x179C888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFDCC", Offset = "0x3AFDCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x17B78A8", Offset = "0x17B78A8", VA = "0x17B78A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFDDC", Offset = "0x3AFDDC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x17B77D4", Offset = "0x17B77D4", VA = "0x17B77D4")]
		protected IKSolver()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x17B77EC", Offset = "0x17B77EC", VA = "0x17B77EC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1798D08", Offset = "0x1798D08", VA = "0x1798D08")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1799720", Offset = "0x1799720", VA = "0x1799720")]
		public void Update()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x17B78B0", Offset = "0x17B78B0", VA = "0x17B78B0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x17B78C4", Offset = "0x17B78C4", VA = "0x17B78C4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x17B78D0", Offset = "0x17B78D0", VA = "0x17B78D0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x17B78D8", Offset = "0x17B78D8", VA = "0x17B78D8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x17ABDD8", Offset = "0x17ABDD8", VA = "0x17ABDD8")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60003C0")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60003C1")]
		public abstract void FixTransforms();

		[Token(Token = "0x60003C2")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60003C3")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60003C4")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x17B796C", Offset = "0x17B796C", VA = "0x17B796C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x17B7984", Offset = "0x17B7984", VA = "0x17B7984")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x17B7B20", Offset = "0x17B7B20", VA = "0x17B7B20")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x17B7BE8", Offset = "0x17B7BE8", VA = "0x17B7BE8")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform transform;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 axis;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 poleAxis;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 polePosition;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8354", Offset = "0x3A8354")]
		public float poleWeight;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform poleTarget;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A836C", Offset = "0x3A836C")]
		public float clampWeight;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8384", Offset = "0x3A8384")]
		public int clampSmoothing;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float step;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform lastTransform;

		[Token(Token = "0x17000078")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1844AE4", Offset = "0x1844AE4", VA = "0x1844AE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000079")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1844BBC", Offset = "0x1844BBC", VA = "0x1844BBC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007A")]
		protected override int minBones
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1845EA8", Offset = "0x1845EA8", VA = "0x1845EA8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007B")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x18466C8", Offset = "0x18466C8", VA = "0x18466C8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1844894", Offset = "0x1844894", VA = "0x1844894")]
		public IKSolverAim()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x18449E8", Offset = "0x18449E8", VA = "0x18449E8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1844C94", Offset = "0x1844C94", VA = "0x1844C94", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1845020", Offset = "0x1845020", VA = "0x1845020", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1845CC0", Offset = "0x1845CC0", VA = "0x1845CC0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1845804", Offset = "0x1845804", VA = "0x1845804")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1845EB0", Offset = "0x1845EB0", VA = "0x1845EB0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A839C", Offset = "0x3A839C")]
		public float IKRotationWeight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Point chest;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Point shoulder;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Point upperArm;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Point forearm;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Point hand;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool isLeft;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3[] positions;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x18467D4", Offset = "0x18467D4", VA = "0x18467D4")]
		public IKSolverArm()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1846AEC", Offset = "0x1846AEC", VA = "0x1846AEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x18470C0", Offset = "0x18470C0", VA = "0x18470C0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1847188", Offset = "0x1847188", VA = "0x1847188", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x18473A8", Offset = "0x18473A8", VA = "0x18473A8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x18475E8", Offset = "0x18475E8", VA = "0x18475E8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1847668", Offset = "0x1847668", VA = "0x1847668", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x18476F8", Offset = "0x18476F8", VA = "0x18476F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1847E18", Offset = "0x1847E18", VA = "0x1847E18", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1847E3C", Offset = "0x1847E3C", VA = "0x1847E3C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x18477AC", Offset = "0x18477AC", VA = "0x18477AC")]
		private void Read()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1847EF0", Offset = "0x1847EF0", VA = "0x1847EF0")]
		private void Write()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x184A1A0", Offset = "0x184A1A0", VA = "0x184A1A0")]
		public IKSolverCCD()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x184A1A4", Offset = "0x184A1A4", VA = "0x184A1A4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x184A2FC", Offset = "0x184A2FC", VA = "0x184A2FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x184AD18", Offset = "0x184AD18", VA = "0x184AD18", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x184B788", Offset = "0x184B788", VA = "0x184B788")]
		private void Solve(Vector3 targetPosition)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool[] limitedBones;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700007C")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x184E1DC", Offset = "0x184E1DC", VA = "0x184E1DC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x184C3F0", Offset = "0x184C3F0", VA = "0x184C3F0")]
		public IKSolverFABRIK()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x184C47C", Offset = "0x184C47C", VA = "0x184C47C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x184D1B4", Offset = "0x184D1B4", VA = "0x184D1B4")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x184D318", Offset = "0x184D318", VA = "0x184D318", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x184D3E8", Offset = "0x184D3E8", VA = "0x184D3E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x184DD20", Offset = "0x184DD20", VA = "0x184DD20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x184E1E4", Offset = "0x184E1E4", VA = "0x184E1E4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x184C554", Offset = "0x184C554", VA = "0x184C554")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x184D2BC", Offset = "0x184D2BC", VA = "0x184D2BC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x184E14C", Offset = "0x184E14C", VA = "0x184E14C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x184CDD0", Offset = "0x184CDD0", VA = "0x184CDD0")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x184F0D4", Offset = "0x184F0D4", VA = "0x184F0D4")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x184F218", Offset = "0x184F218", VA = "0x184F218")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x184F3BC", Offset = "0x184F3BC", VA = "0x184F3BC")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x184F560", Offset = "0x184F560", VA = "0x184F560")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x184D8F4", Offset = "0x184D8F4", VA = "0x184D8F4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x184DB08", Offset = "0x184DB08", VA = "0x184DB08")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x184F848", Offset = "0x184F848", VA = "0x184F848")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x184E740", Offset = "0x184E740", VA = "0x184E740")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x184D28C", Offset = "0x184D28C", VA = "0x184D28C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1850624", Offset = "0x1850624", VA = "0x1850624")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x184FAA0", Offset = "0x184FAA0", VA = "0x184FAA0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x184E330", Offset = "0x184E330", VA = "0x184E330")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x184E540", Offset = "0x184E540", VA = "0x184E540")]
		private void MapToSolverPositionsLimited()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int iterations;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A83B4", Offset = "0x3A83B4")]
		public float rootPin;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool[] isRoot;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x185085C", Offset = "0x185085C", VA = "0x185085C")]
		public IKSolverFABRIKRoot()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x18508D8", Offset = "0x18508D8", VA = "0x18508D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1851BC4", Offset = "0x1851BC4", VA = "0x1851BC4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1851CBC", Offset = "0x1851CBC", VA = "0x1851CBC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1851DCC", Offset = "0x1851DCC", VA = "0x1851DCC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1851F40", Offset = "0x1851F40", VA = "0x1851F40")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1852088", Offset = "0x1852088", VA = "0x1852088", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x18528D4", Offset = "0x18528D4", VA = "0x18528D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1852B84", Offset = "0x1852B84", VA = "0x1852B84", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x18529B8", Offset = "0x18529B8", VA = "0x18529B8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1852420", Offset = "0x1852420", VA = "0x1852420")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A83CC", Offset = "0x3A83CC")]
		public int iterations;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FBIKChain[] chain;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public IKEffector[] effectors;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool FABRIKPass;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1852C58", Offset = "0x1852C58", VA = "0x1852C58")]
		public IKSolverFullBody()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1852D54", Offset = "0x1852D54", VA = "0x1852D54")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1852E9C", Offset = "0x1852E9C", VA = "0x1852E9C")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1852EFC", Offset = "0x1852EFC", VA = "0x1852EFC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x18530CC", Offset = "0x18530CC", VA = "0x18530CC")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1853160", Offset = "0x1853160", VA = "0x1853160")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x18531F4", Offset = "0x18531F4", VA = "0x18531F4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1853474", Offset = "0x1853474", VA = "0x1853474", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x18536C8", Offset = "0x18536C8", VA = "0x18536C8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x18539BC", Offset = "0x18539BC", VA = "0x18539BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1853B00", Offset = "0x1853B00", VA = "0x1853B00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1853C68", Offset = "0x1853C68", VA = "0x1853C68", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1853E7C", Offset = "0x1853E7C", VA = "0x1853E7C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1854100", Offset = "0x1854100", VA = "0x1854100", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1854598", Offset = "0x1854598", VA = "0x1854598", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1854C0C", Offset = "0x1854C0C", VA = "0x1854C0C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1854C74", Offset = "0x1854C74", VA = "0x1854C74", Slot = "15")]
		protected virtual void WritePose()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400041B")]
		Body,
		[Token(Token = "0x400041C")]
		LeftShoulder,
		[Token(Token = "0x400041D")]
		RightShoulder,
		[Token(Token = "0x400041E")]
		LeftThigh,
		[Token(Token = "0x400041F")]
		RightThigh,
		[Token(Token = "0x4000420")]
		LeftHand,
		[Token(Token = "0x4000421")]
		RightHand,
		[Token(Token = "0x4000422")]
		LeftFoot,
		[Token(Token = "0x4000423")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000425")]
		LeftArm,
		[Token(Token = "0x4000426")]
		RightArm,
		[Token(Token = "0x4000427")]
		LeftLeg,
		[Token(Token = "0x4000428")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rootNode;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A83E8", Offset = "0x3A83E8")]
		public float spineStiffness;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8400", Offset = "0x3A8400")]
		public float pullBodyVertical;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A841C", Offset = "0x3A841C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8438", Offset = "0x3A8438")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8438", Offset = "0x3A8438")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 offset;

		[Token(Token = "0x1700007D")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1854DF8", Offset = "0x1854DF8", VA = "0x1854DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1855044", Offset = "0x1855044", VA = "0x1855044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x185504C", Offset = "0x185504C", VA = "0x185504C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1855054", Offset = "0x1855054", VA = "0x1855054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x185505C", Offset = "0x185505C", VA = "0x185505C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1855064", Offset = "0x1855064", VA = "0x1855064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x185506C", Offset = "0x185506C", VA = "0x185506C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1855074", Offset = "0x1855074", VA = "0x1855074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x185507C", Offset = "0x185507C", VA = "0x185507C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1855084", Offset = "0x1855084", VA = "0x1855084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x18550C4", Offset = "0x18550C4", VA = "0x18550C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1855104", Offset = "0x1855104", VA = "0x1855104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1855144", Offset = "0x1855144", VA = "0x1855144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1855184", Offset = "0x1855184", VA = "0x1855184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x18551C4", Offset = "0x18551C4", VA = "0x18551C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1855204", Offset = "0x1855204", VA = "0x1855204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1855244", Offset = "0x1855244", VA = "0x1855244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1855284", Offset = "0x1855284", VA = "0x1855284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1858954", Offset = "0x1858954", VA = "0x1858954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFDEC", Offset = "0x3AFDEC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1858968", Offset = "0x1858968", VA = "0x1858968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFDFC", Offset = "0x3AFDFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1854DE8", Offset = "0x1854DE8", VA = "0x1854DE8")]
		public IKSolverFullBodyBiped()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x18552C4", Offset = "0x18552C4", VA = "0x18552C4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1855448", Offset = "0x1855448", VA = "0x1855448")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1855330", Offset = "0x1855330", VA = "0x1855330")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x185554C", Offset = "0x185554C", VA = "0x185554C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1854E00", Offset = "0x1854E00", VA = "0x1854E00")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x18556B0", Offset = "0x18556B0", VA = "0x18556B0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x18557C8", Offset = "0x18557C8", VA = "0x18557C8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x18558E0", Offset = "0x18558E0", VA = "0x18558E0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1855A0C", Offset = "0x1855A0C", VA = "0x1855A0C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1855A14", Offset = "0x1855A14", VA = "0x1855A14")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1855A54", Offset = "0x1855A54", VA = "0x1855A54")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1855B80", Offset = "0x1855B80", VA = "0x1855B80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1855EB8", Offset = "0x1855EB8", VA = "0x1855EB8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1857F48", Offset = "0x1857F48", VA = "0x1857F48")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x18585EC", Offset = "0x18585EC", VA = "0x18585EC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x18586A8", Offset = "0x18586A8", VA = "0x18586A8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x18583E4", Offset = "0x18583E4", VA = "0x18583E4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x18584E8", Offset = "0x18584E8", VA = "0x18584E8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1858974", Offset = "0x1858974", VA = "0x1858974")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1858A58", Offset = "0x1858A58", VA = "0x1858A58", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1858CA8", Offset = "0x1858CA8", VA = "0x1858CA8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1858EB0", Offset = "0x1858EB0", VA = "0x1858EB0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x18590D8", Offset = "0x18590D8", VA = "0x18590D8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x18593D4", Offset = "0x18593D4", VA = "0x18593D4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x18599D4", Offset = "0x18599D4", VA = "0x18599D4", Slot = "15")]
		protected override void WritePose()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float tolerance;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int maxIterations;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useRotationLimits;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool XY;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Bone[] bones;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float chainLength;

		[Token(Token = "0x17000090")]
		protected virtual int minBones
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x185A714", Offset = "0x185A714", VA = "0x185A714", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000091")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x185A71C", Offset = "0x185A71C", VA = "0x185A71C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x185A724", Offset = "0x185A724", VA = "0x185A724", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x185A734", Offset = "0x185A734", VA = "0x185A734", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		protected float positionOffset
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x184B6B4", Offset = "0x184B6B4", VA = "0x184B6B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1844964", Offset = "0x1844964", VA = "0x1844964")]
		public IKSolverHeuristic()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1859B24", Offset = "0x1859B24", VA = "0x1859B24")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1859D64", Offset = "0x1859D64", VA = "0x1859D64")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1859F40", Offset = "0x1859F40", VA = "0x1859F40", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1859FCC", Offset = "0x1859FCC", VA = "0x1859FCC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x185A078", Offset = "0x185A078", VA = "0x185A078", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x185A5C4", Offset = "0x185A5C4", VA = "0x185A5C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x185A5CC", Offset = "0x185A5CC", VA = "0x185A5CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x185A72C", Offset = "0x185A72C", VA = "0x185A72C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x185A730", Offset = "0x185A730", VA = "0x185A730", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x184A3BC", Offset = "0x184A3BC", VA = "0x184A3BC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x184B15C", Offset = "0x184B15C", VA = "0x184B15C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x185A93C", Offset = "0x185A93C", VA = "0x185A93C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A846C", Offset = "0x3A846C")]
		public float IKRotationWeight;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Point pelvis;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Point thigh;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Point calf;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Point foot;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Point toe;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3[] positions;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x185AD20", Offset = "0x185AD20", VA = "0x185AD20")]
		public IKSolverLeg()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x185AEA0", Offset = "0x185AEA0", VA = "0x185AEA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x185B474", Offset = "0x185B474", VA = "0x185B474")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x185B53C", Offset = "0x185B53C", VA = "0x185B53C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x185B75C", Offset = "0x185B75C", VA = "0x185B75C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x185B99C", Offset = "0x185B99C", VA = "0x185B99C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x185BA1C", Offset = "0x185BA1C", VA = "0x185BA1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x185BAAC", Offset = "0x185BAAC", VA = "0x185BAAC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x185C1CC", Offset = "0x185C1CC", VA = "0x185C1CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x185C1F0", Offset = "0x185C1F0", VA = "0x185C1F0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x185BB60", Offset = "0x185BB60", VA = "0x185BB60")]
		private void Read()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x185C364", Offset = "0x185C364", VA = "0x185C364")]
		private void Write()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public enum BendModifier
		{
			[Token(Token = "0x4000453")]
			Animation,
			[Token(Token = "0x4000454")]
			Target,
			[Token(Token = "0x4000455")]
			Parent,
			[Token(Token = "0x4000456")]
			Arm,
			[Token(Token = "0x4000457")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x497E34", Offset = "0x497E34", VA = "0x497E34")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8484", Offset = "0x3A8484")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A849C", Offset = "0x3A849C")]
		public float bendModifierWeight;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform bendGoal;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000095")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x185E634", Offset = "0x185E634", VA = "0x185E634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x185C6C8", Offset = "0x185C6C8", VA = "0x185C6C8")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x185C8A4", Offset = "0x185C8A4", VA = "0x185C8A4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x185C934", Offset = "0x185C934", VA = "0x185C934")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x185C9B0", Offset = "0x185C9B0", VA = "0x185C9B0")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x185CAE4", Offset = "0x185CAE4", VA = "0x185CAE4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x185D35C", Offset = "0x185D35C", VA = "0x185D35C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x185E4AC", Offset = "0x185E4AC", VA = "0x185E4AC", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x185CFC0", Offset = "0x185CFC0", VA = "0x185CFC0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x185D4E4", Offset = "0x185D4E4", VA = "0x185D4E4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x1700009C")]
			public Vector3 forward
			{
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0x186138C", Offset = "0x186138C", VA = "0x186138C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x185E8F8", Offset = "0x185E8F8", VA = "0x185E8F8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x18600F0", Offset = "0x18600F0", VA = "0x18600F0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x186068C", Offset = "0x186068C", VA = "0x186068C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1861944", Offset = "0x1861944", VA = "0x1861944")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LookAtBone[] spine;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LookAtBone head;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A84B4", Offset = "0x3A84B4")]
		public float bodyWeight;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A84CC", Offset = "0x3A84CC")]
		public float headWeight;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A84E4", Offset = "0x3A84E4")]
		public float eyesWeight;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A84FC", Offset = "0x3A84FC")]
		public float clampWeight;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8514", Offset = "0x3A8514")]
		public float clampWeightHead;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A852C", Offset = "0x3A852C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8544", Offset = "0x3A8544")]
		public int clampSmoothing;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3[] headForwards;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000096")]
		private bool spineIsValid
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x185F49C", Offset = "0x185F49C", VA = "0x185F49C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x185F78C", Offset = "0x185F78C", VA = "0x185F78C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		private bool headIsValid
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x185F60C", Offset = "0x185F60C", VA = "0x185F60C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x185F7BC", Offset = "0x185F7BC", VA = "0x185F7BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x185F61C", Offset = "0x185F61C", VA = "0x185F61C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x185F85C", Offset = "0x185F85C", VA = "0x185F85C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x185E6C0", Offset = "0x185E6C0", VA = "0x185E6C0")]
		public IKSolverLookAt()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x185E900", Offset = "0x185E900", VA = "0x185E900")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x185E994", Offset = "0x185E994", VA = "0x185E994")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x185EA44", Offset = "0x185EA44", VA = "0x185EA44")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x185EB10", Offset = "0x185EB10", VA = "0x185EB10")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x185EC04", Offset = "0x185EC04", VA = "0x185EC04")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x185ED20", Offset = "0x185ED20", VA = "0x185ED20")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x185EE74", Offset = "0x185EE74", VA = "0x185EE74", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x185F02C", Offset = "0x185F02C", VA = "0x185F02C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x185F208", Offset = "0x185F208", VA = "0x185F208", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x185F88C", Offset = "0x185F88C", VA = "0x185F88C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x185FBEC", Offset = "0x185FBEC", VA = "0x185FBEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x185FDFC", Offset = "0x185FDFC", VA = "0x185FDFC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1860110", Offset = "0x1860110", VA = "0x1860110", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x18607F8", Offset = "0x18607F8", VA = "0x18607F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1860938", Offset = "0x1860938", VA = "0x1860938")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1860C88", Offset = "0x1860C88", VA = "0x1860C88")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1861010", Offset = "0x1861010", VA = "0x1861010")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1861464", Offset = "0x1861464", VA = "0x1861464")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x185FEB4", Offset = "0x185FEB4", VA = "0x185FEB4")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1861ADC", Offset = "0x1861ADC", VA = "0x1861ADC")]
			public TrigonometricBone()
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x18638C4", Offset = "0x18638C4", VA = "0x18638C4")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x1864988", Offset = "0x1864988", VA = "0x1864988")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x185CA0C", Offset = "0x185CA0C", VA = "0x185CA0C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A855C", Offset = "0x3A855C")]
		public float IKRotationWeight;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 bendNormal;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected bool directHierarchy;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x185C750", Offset = "0x185C750", VA = "0x185C750")]
		public IKSolverTrigonometric()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1861AE4", Offset = "0x1861AE4", VA = "0x1861AE4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1861D60", Offset = "0x1861D60", VA = "0x1861D60")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1861F94", Offset = "0x1861F94", VA = "0x1861F94")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1861FA4", Offset = "0x1861FA4", VA = "0x1861FA4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1862038", Offset = "0x1862038", VA = "0x1862038")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1862048", Offset = "0x1862048", VA = "0x1862048")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1862050", Offset = "0x1862050", VA = "0x1862050", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x18621C8", Offset = "0x18621C8", VA = "0x18621C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1862348", Offset = "0x1862348", VA = "0x1862348", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x18623AC", Offset = "0x18623AC", VA = "0x18623AC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1862420", Offset = "0x1862420", VA = "0x1862420", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1862A1C", Offset = "0x1862A1C", VA = "0x1862A1C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1862AA0", Offset = "0x1862AA0", VA = "0x1862AA0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1863230", Offset = "0x1863230", VA = "0x1863230")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1863484", Offset = "0x1863484", VA = "0x1863484", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x186374C", Offset = "0x186374C", VA = "0x186374C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x186364C", Offset = "0x186364C", VA = "0x186364C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1863AE4", Offset = "0x1863AE4", VA = "0x1863AE4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1864A88", Offset = "0x1864A88", VA = "0x1864A88", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1864A8C", Offset = "0x1864A8C", VA = "0x1864A8C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1864A90", Offset = "0x1864A90", VA = "0x1864A90", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x18645F8", Offset = "0x18645F8", VA = "0x18645F8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200009C")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40004B5")]
				YawPitch,
				[Token(Token = "0x40004B6")]
				FromTo
			}

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8760", Offset = "0x3A8760")]
			public Transform target;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A879C", Offset = "0x3A879C")]
			public Transform bendGoal;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A87D0", Offset = "0x3A87D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A87D0", Offset = "0x3A87D0")]
			public float positionWeight;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8840", Offset = "0x3A8840")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8840", Offset = "0x3A8840")]
			public float rotationWeight;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A88B0", Offset = "0x3A88B0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8910", Offset = "0x3A8910")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8910", Offset = "0x3A8910")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8978", Offset = "0x3A8978")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8978", Offset = "0x3A8978")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A89C8", Offset = "0x3A89C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A89C8", Offset = "0x3A89C8")]
			public float bendGoalWeight;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8A18", Offset = "0x3A8A18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8A18", Offset = "0x3A8A18")]
			public float swivelOffset;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8A98", Offset = "0x3A8A98")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8ACC", Offset = "0x3A8ACC")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8B00", Offset = "0x3A8B00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8B00", Offset = "0x3A8B00")]
			public float armLengthMlp;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8B78", Offset = "0x3A8B78")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A8BAC", Offset = "0x3A8BAC")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A8BBC", Offset = "0x3A8BBC")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A8BCC", Offset = "0x3A8BCC")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A8BDC", Offset = "0x3A8BDC")]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8BEC", Offset = "0x3A8BEC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8BEC", Offset = "0x3A8BEC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8C20", Offset = "0x3A8C20")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8C20", Offset = "0x3A8C20")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private bool hasShoulder;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion chestRotation;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestForward;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Vector3 chestUp;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40004B2")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40004B3")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x1700009E")]
			public Vector3 position
			{
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0x186B020", Offset = "0x186B020", VA = "0x186B020")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE2C", Offset = "0x3AFE2C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0x186B034", Offset = "0x186B034", VA = "0x186B034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE3C", Offset = "0x3AFE3C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public Quaternion rotation
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x186B040", Offset = "0x186B040", VA = "0x186B040")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE4C", Offset = "0x3AFE4C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0x186B050", Offset = "0x186B050", VA = "0x186B050")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE5C", Offset = "0x3AFE5C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60004E9")]
				[Address(RVA = "0x186B060", Offset = "0x186B060", VA = "0x186B060")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0x186B0A0", Offset = "0x186B0A0", VA = "0x186B0A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60004EB")]
				[Address(RVA = "0x186B0E8", Offset = "0x186B0E8", VA = "0x186B0E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private VirtualBone hand
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x186B13C", Offset = "0x186B13C", VA = "0x186B13C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1846950", Offset = "0x1846950", VA = "0x1846950")]
			public Arm()
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x186B190", Offset = "0x186B190", VA = "0x186B190", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x186BE68", Offset = "0x186BE68", VA = "0x186BE68", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x186C164", Offset = "0x186C164", VA = "0x186C164", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x186C21C", Offset = "0x186C21C", VA = "0x186C21C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1848254", Offset = "0x1848254", VA = "0x1848254")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x186D110", Offset = "0x186D110", VA = "0x186D110", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x186D1A8", Offset = "0x186D1A8", VA = "0x186D1A8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x186C85C", Offset = "0x186C85C", VA = "0x186C85C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x186C95C", Offset = "0x186C95C", VA = "0x186C95C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x186D598", Offset = "0x186D598", VA = "0x186D598")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8C54", Offset = "0x3A8C54")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8C54", Offset = "0x3A8C54")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8C88", Offset = "0x3A8C88")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8C88", Offset = "0x3A8C88")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A8CBC", Offset = "0x3A8CBC")]
			public VirtualBone[] bones;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			protected bool initiated;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			protected int index;

			[Token(Token = "0x170000A4")]
			public float sqrMag
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0x14C9078", Offset = "0x14C9078", VA = "0x14C9078")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE6C", Offset = "0x3AFE6C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0x14C9080", Offset = "0x14C9080", VA = "0x14C9080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE7C", Offset = "0x3AFE7C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public float mag
			{
				[Token(Token = "0x60004FF")]
				[Address(RVA = "0x14C9088", Offset = "0x14C9088", VA = "0x14C9088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE8C", Offset = "0x3AFE8C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000500")]
				[Address(RVA = "0x14C9090", Offset = "0x14C9090", VA = "0x14C9090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE9C", Offset = "0x3AFE9C")]
				private set
				{
				}
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x14C8FA8", Offset = "0x14C8FA8", VA = "0x14C8FA8")]
			protected BodyPart()
			{
			}

			[Token(Token = "0x60004F8")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60004F9")]
			public abstract void PreSolve();

			[Token(Token = "0x60004FA")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60004FB")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60004FC")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x14C9098", Offset = "0x14C9098", VA = "0x14C9098")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x14C97B4", Offset = "0x14C97B4", VA = "0x14C97B4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x14C99A8", Offset = "0x14C99A8", VA = "0x14C99A8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x14C9D80", Offset = "0x14C9D80", VA = "0x14C9D80")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x14C9DB4", Offset = "0x14C9DB4", VA = "0x14C9DB4")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x14CA008", Offset = "0x14CA008", VA = "0x14CA008")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x14CA260", Offset = "0x14CA260", VA = "0x14CA260")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x14CA414", Offset = "0x14CA414", VA = "0x14CA414")]
			public void Visualize()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009E")]
		public class Footstep
		{
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float stepSpeed;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 position;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isSupportLeg;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A8CCC", Offset = "0x3A8CCC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A8CCC", Offset = "0x3A8CCC")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 stepFrom;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 stepTo;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Quaternion stepToRot;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float supportLegW;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float supportLegWV;

			[Token(Token = "0x170000A6")]
			public bool isStepping
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x14CA6D0", Offset = "0x14CA6D0", VA = "0x14CA6D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A7")]
			public float stepProgress
			{
				[Token(Token = "0x600050B")]
				[Address(RVA = "0x14CA6EC", Offset = "0x14CA6EC", VA = "0x14CA6EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFEAC", Offset = "0x3AFEAC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x14CA6F4", Offset = "0x14CA6F4", VA = "0x14CA6F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFEBC", Offset = "0x3AFEBC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x14CA450", Offset = "0x14CA450", VA = "0x14CA450")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x14CA650", Offset = "0x14CA650", VA = "0x14CA650")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x14CA6FC", Offset = "0x14CA6FC", VA = "0x14CA6FC")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x14CA84C", Offset = "0x14CA84C", VA = "0x14CA84C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x14CAA5C", Offset = "0x14CAA5C", VA = "0x14CAA5C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x14CAC80", Offset = "0x14CAC80", VA = "0x14CAC80")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8D00", Offset = "0x3A8D00")]
			public Transform target;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8D44", Offset = "0x3A8D44")]
			public Transform bendGoal;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8D78", Offset = "0x3A8D78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8D78", Offset = "0x3A8D78")]
			public float positionWeight;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8DEC", Offset = "0x3A8DEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8DEC", Offset = "0x3A8DEC")]
			public float rotationWeight;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8E60", Offset = "0x3A8E60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8E60", Offset = "0x3A8E60")]
			public float bendGoalWeight;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8EB0", Offset = "0x3A8EB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8EB0", Offset = "0x3A8EB0")]
			public float swivelOffset;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8F30", Offset = "0x3A8F30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8F30", Offset = "0x3A8F30")]
			public float bendToTargetWeight;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8F80", Offset = "0x3A8F80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A8F80", Offset = "0x3A8F80")]
			public float legLengthMlp;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8FF8", Offset = "0x3A8FF8")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A902C", Offset = "0x3A902C")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A903C", Offset = "0x3A903C")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A904C", Offset = "0x3A904C")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A905C", Offset = "0x3A905C")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A906C", Offset = "0x3A906C")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A907C", Offset = "0x3A907C")]
			public float currentMag;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A908C", Offset = "0x3A908C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A908C", Offset = "0x3A908C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A90C0", Offset = "0x3A90C0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A90C0", Offset = "0x3A90C0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A90F4", Offset = "0x3A90F4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A90F4", Offset = "0x3A90F4")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A9128", Offset = "0x3A9128")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A9128", Offset = "0x3A9128")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Vector3 footPosition;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion footRotation;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 bendNormal;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000A8")]
			public Vector3 position
			{
				[Token(Token = "0x6000513")]
				[Address(RVA = "0x14CB074", Offset = "0x14CB074", VA = "0x14CB074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFECC", Offset = "0x3AFECC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000514")]
				[Address(RVA = "0x14CB088", Offset = "0x14CB088", VA = "0x14CB088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFEDC", Offset = "0x3AFEDC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000515")]
				[Address(RVA = "0x14CB094", Offset = "0x14CB094", VA = "0x14CB094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFEEC", Offset = "0x3AFEEC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000516")]
				[Address(RVA = "0x14CB0A4", Offset = "0x14CB0A4", VA = "0x14CB0A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFEFC", Offset = "0x3AFEFC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			public bool hasToes
			{
				[Token(Token = "0x6000517")]
				[Address(RVA = "0x14CB0B4", Offset = "0x14CB0B4", VA = "0x14CB0B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF0C", Offset = "0x3AFF0C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000518")]
				[Address(RVA = "0x14CB0BC", Offset = "0x14CB0BC", VA = "0x14CB0BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF1C", Offset = "0x3AFF1C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000519")]
				[Address(RVA = "0x14CB0C4", Offset = "0x14CB0C4", VA = "0x14CB0C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private VirtualBone calf
			{
				[Token(Token = "0x600051A")]
				[Address(RVA = "0x14CB104", Offset = "0x14CB104", VA = "0x14CB104")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone foot
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0x14CB144", Offset = "0x14CB144", VA = "0x14CB144")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private VirtualBone toes
			{
				[Token(Token = "0x600051C")]
				[Address(RVA = "0x14CB184", Offset = "0x14CB184", VA = "0x14CB184")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0x14CB1C4", Offset = "0x14CB1C4", VA = "0x14CB1C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600051E")]
				[Address(RVA = "0x14CB214", Offset = "0x14CB214", VA = "0x14CB214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF2C", Offset = "0x3AFF2C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600051F")]
				[Address(RVA = "0x14CB228", Offset = "0x14CB228", VA = "0x14CB228")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF3C", Offset = "0x3AFF3C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x14CAF28", Offset = "0x14CAF28", VA = "0x14CAF28")]
			public Leg()
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x14CB234", Offset = "0x14CB234", VA = "0x14CB234", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x14CBCD8", Offset = "0x14CBCD8", VA = "0x14CBCD8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x14CC7B4", Offset = "0x14CC7B4", VA = "0x14CC7B4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0x14CC684", Offset = "0x14CC684", VA = "0x14CC684")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x14CC3A8", Offset = "0x14CC3A8", VA = "0x14CC3A8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x14CCF7C", Offset = "0x14CCF7C", VA = "0x14CCF7C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x14CD7A8", Offset = "0x14CD7A8", VA = "0x14CD7A8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x14CE82C", Offset = "0x14CE82C", VA = "0x14CE82C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x14CEC0C", Offset = "0x14CEC0C", VA = "0x14CEC0C", Slot = "8")]
			public override void ResetOffsets()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class Locomotion
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A915C", Offset = "0x3A915C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A915C", Offset = "0x3A915C")]
			public float weight;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A91D8", Offset = "0x3A91D8")]
			public float footDistance;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9238", Offset = "0x3A9238")]
			public float stepThreshold;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A926C", Offset = "0x3A926C")]
			public float angleThreshold;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A92A0", Offset = "0x3A92A0")]
			public float comAngleMlp;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A92D4", Offset = "0x3A92D4")]
			public float maxVelocity;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9308", Offset = "0x3A9308")]
			public float velocityFactor;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9368", Offset = "0x3A9368")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9368", Offset = "0x3A9368")]
			public float maxLegStretch;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A93BC", Offset = "0x3A93BC")]
			public float rootSpeed;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A93F0", Offset = "0x3A93F0")]
			public float stepSpeed;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9430", Offset = "0x3A9430")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9498", Offset = "0x3A9498")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A94CC", Offset = "0x3A94CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A94CC", Offset = "0x3A94CC")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9520", Offset = "0x3A9520")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9554", Offset = "0x3A9554")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A95A0", Offset = "0x3A95A0")]
			public Vector3 offset;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A95F8", Offset = "0x3A95F8")]
			public bool blockingEnabled;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9608", Offset = "0x3A9608")]
			public LayerMask blockingLayers;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9618", Offset = "0x3A9618")]
			public float raycastRadius;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9628", Offset = "0x3A9628")]
			public float raycastHeight;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9638", Offset = "0x3A9638")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9694", Offset = "0x3A9694")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A96F0", Offset = "0x3A96F0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A96F0", Offset = "0x3A96F0")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Footstep[] footsteps;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int leftFootIndex;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private int rightFootIndex;

			[Token(Token = "0x170000B1")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600052A")]
				[Address(RVA = "0x14CEE3C", Offset = "0x14CEE3C", VA = "0x14CEE3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF4C", Offset = "0x3AFF4C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600052B")]
				[Address(RVA = "0x14CEE50", Offset = "0x14CEE50", VA = "0x14CEE50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF5C", Offset = "0x3AFF5C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000531")]
				[Address(RVA = "0x14D269C", Offset = "0x14D269C", VA = "0x14D269C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B3")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x14D2700", Offset = "0x14D2700", VA = "0x14D2700")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B4")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x14D2764", Offset = "0x14D2764", VA = "0x14D2764")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000B5")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000534")]
				[Address(RVA = "0x14D27C4", Offset = "0x14D27C4", VA = "0x14D27C4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x14CED10", Offset = "0x14CED10", VA = "0x14CED10")]
			public Locomotion()
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x14CEE5C", Offset = "0x14CEE5C", VA = "0x14CEE5C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x14CF2CC", Offset = "0x14CF2CC", VA = "0x14CF2CC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x14CF73C", Offset = "0x14CF73C", VA = "0x14CF73C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x14CFC64", Offset = "0x14CFC64", VA = "0x14CFC64")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x14CFEA0", Offset = "0x14CFEA0", VA = "0x14CFEA0")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x14D2200", Offset = "0x14D2200", VA = "0x14D2200")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x14D23D8", Offset = "0x14D23D8", VA = "0x14D23D8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x14D2474", Offset = "0x14D2474", VA = "0x14D2474")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000A1")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9724", Offset = "0x3A9724")]
			public Transform headTarget;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9764", Offset = "0x3A9764")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A97BC", Offset = "0x3A97BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A97BC", Offset = "0x3A97BC")]
			public float positionWeight;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A982C", Offset = "0x3A982C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A982C", Offset = "0x3A982C")]
			public float rotationWeight;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A989C", Offset = "0x3A989C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A989C", Offset = "0x3A989C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A990C", Offset = "0x3A990C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A990C", Offset = "0x3A990C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A997C", Offset = "0x3A997C")]
			public Transform chestGoal;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A99B0", Offset = "0x3A99B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A99B0", Offset = "0x3A99B0")]
			public float chestGoalWeight;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9A20", Offset = "0x3A9A20")]
			public float minHeadHeight;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9A88", Offset = "0x3A9A88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9A88", Offset = "0x3A9A88")]
			public float bodyPosStiffness;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9AD8", Offset = "0x3A9AD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9AD8", Offset = "0x3A9AD8")]
			public float bodyRotStiffness;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9B28", Offset = "0x3A9B28")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3A9B28", Offset = "0x3A9B28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9B28", Offset = "0x3A9B28")]
			public float neckStiffness;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9BAC", Offset = "0x3A9BAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9BAC", Offset = "0x3A9BAC")]
			public float rotateChestByHands;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9BFC", Offset = "0x3A9BFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9BFC", Offset = "0x3A9BFC")]
			public float chestClampWeight;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9C5C", Offset = "0x3A9C5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9C5C", Offset = "0x3A9C5C")]
			public float headClampWeight;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9CBC", Offset = "0x3A9CBC")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9CF0", Offset = "0x3A9CF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9CF0", Offset = "0x3A9CF0")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9D74", Offset = "0x3A9D74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9D74", Offset = "0x3A9D74")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9DC8", Offset = "0x3A9DC8")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9DD8", Offset = "0x3A9DD8")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9DE8", Offset = "0x3A9DE8")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9DF8", Offset = "0x3A9DF8")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E08", Offset = "0x3A9E08")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E18", Offset = "0x3A9E18")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E28", Offset = "0x3A9E28")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E38", Offset = "0x3A9E38")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E48", Offset = "0x3A9E48")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E58", Offset = "0x3A9E58")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E68", Offset = "0x3A9E68")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E78", Offset = "0x3A9E78")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E88", Offset = "0x3A9E88")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3A9E98", Offset = "0x3A9E98")]
			public Vector3 headPosition;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A9EA8", Offset = "0x3A9EA8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A9EA8", Offset = "0x3A9EA8")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int pelvisIndex;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int spineIndex;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int chestIndex;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int neckIndex;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private int headIndex;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private float length;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private bool hasChest;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
			private bool hasNeck;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
			private bool hasLegs;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float headHeight;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private float sizeMlp;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private Vector3 chestForward;

			[Token(Token = "0x170000B6")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000539")]
				[Address(RVA = "0x14D2170", Offset = "0x14D2170", VA = "0x14D2170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x14D2AA8", Offset = "0x14D2AA8", VA = "0x14D2AA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			public VirtualBone chest
			{
				[Token(Token = "0x600053B")]
				[Address(RVA = "0x14D2AF0", Offset = "0x14D2AF0", VA = "0x14D2AF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone neck
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x14D2B44", Offset = "0x14D2B44", VA = "0x14D2B44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			public VirtualBone head
			{
				[Token(Token = "0x600053D")]
				[Address(RVA = "0x14D21B8", Offset = "0x14D21B8", VA = "0x14D21B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0x14D2B8C", Offset = "0x14D2B8C", VA = "0x14D2B8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF6C", Offset = "0x3AFF6C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x14D2B9C", Offset = "0x14D2B9C", VA = "0x14D2B9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF7C", Offset = "0x3AFF7C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x14D2828", Offset = "0x14D2828", VA = "0x14D2828")]
			public Spine()
			{
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0x14D2BAC", Offset = "0x14D2BAC", VA = "0x14D2BAC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x14D3D14", Offset = "0x14D3D14", VA = "0x14D3D14", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x14D4074", Offset = "0x14D4074", VA = "0x14D4074", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x14D47A8", Offset = "0x14D47A8", VA = "0x14D47A8")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x14D4ED4", Offset = "0x14D4ED4", VA = "0x14D4ED4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x14D5B84", Offset = "0x14D5B84", VA = "0x14D5B84")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x14D668C", Offset = "0x14D668C", VA = "0x14D668C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x14D72B4", Offset = "0x14D72B4", VA = "0x14D72B4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x14D769C", Offset = "0x14D769C", VA = "0x14D769C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x14D4A04", Offset = "0x14D4A04", VA = "0x14D4A04")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x14D6188", Offset = "0x14D6188", VA = "0x14D6188")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x14D5660", Offset = "0x14D5660", VA = "0x14D5660")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x14D77F4", Offset = "0x14D77F4", VA = "0x14D77F4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x14D6368", Offset = "0x14D6368", VA = "0x14D6368")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x14D5E0C", Offset = "0x14D5E0C", VA = "0x14D5E0C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000539")]
			Pelvis,
			[Token(Token = "0x400053A")]
			Chest,
			[Token(Token = "0x400053B")]
			Head,
			[Token(Token = "0x400053C")]
			LeftHand,
			[Token(Token = "0x400053D")]
			RightHand,
			[Token(Token = "0x400053E")]
			LeftFoot,
			[Token(Token = "0x400053F")]
			RightFoot,
			[Token(Token = "0x4000540")]
			LeftHeel,
			[Token(Token = "0x4000541")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000543")]
			Pelvis,
			[Token(Token = "0x4000544")]
			Chest,
			[Token(Token = "0x4000545")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public class VirtualBone
		{
			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 readPosition;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion readRotation;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Quaternion solverRotation;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float length;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float sqrMag;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 axis;

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x14CBC1C", Offset = "0x14CBC1C", VA = "0x14CBC1C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x14CBC84", Offset = "0x14CBC84", VA = "0x14CBC84")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x14D7CC8", Offset = "0x14D7CC8", VA = "0x14D7CC8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x14C91CC", Offset = "0x14C91CC", VA = "0x14C91CC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x14C9AB0", Offset = "0x14C9AB0", VA = "0x14C9AB0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x14D80D4", Offset = "0x14D80D4", VA = "0x14D80D4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x14D8448", Offset = "0x14D8448", VA = "0x14D8448")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x14D87F8", Offset = "0x14D87F8", VA = "0x14D87F8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x14CDF68", Offset = "0x14CDF68", VA = "0x14CDF68")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x14D88F0", Offset = "0x14D88F0", VA = "0x14D88F0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x14D6B24", Offset = "0x14D6B24", VA = "0x14D6B24")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x14D8B44", Offset = "0x14D8B44", VA = "0x14D8B44")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x14D8C84", Offset = "0x14D8C84", VA = "0x14D8C84")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool hasChest;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool hasNeck;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool hasShoulders;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool hasToes;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool hasLegs;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] readPositions;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 rootV;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int supportLegIndex;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8574", Offset = "0x3A8574")]
		public bool plantFeet;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A85A8", Offset = "0x3A85A8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3A85A8", Offset = "0x3A85A8")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A85DC", Offset = "0x3A85DC")]
		public Spine spine;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A861C", Offset = "0x3A861C")]
		public Arm leftArm;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A8660", Offset = "0x3A8660")]
		public Arm rightArm;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A86A4", Offset = "0x3A86A4")]
		public Leg leftLeg;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A86E8", Offset = "0x3A86E8")]
		public Leg rightLeg;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A872C", Offset = "0x3A872C")]
		public Locomotion locomotion;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Leg[] legs;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Arm[] arms;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 headPosition;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700009D")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3B1434", Offset = "0x3B1434")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x18675CC", Offset = "0x18675CC", VA = "0x18675CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE0C", Offset = "0x3AFE0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x186A708", Offset = "0x186A708", VA = "0x186A708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFE1C", Offset = "0x3AFE1C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1864A94", Offset = "0x1864A94", VA = "0x1864A94")]
		public IKSolverVR()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1864C78", Offset = "0x1864C78", VA = "0x1864C78")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x18652E4", Offset = "0x18652E4", VA = "0x18652E4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x18650B0", Offset = "0x18650B0", VA = "0x18650B0")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x18660D0", Offset = "0x18660D0", VA = "0x18660D0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x18664F8", Offset = "0x18664F8", VA = "0x18664F8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x18665C4", Offset = "0x18665C4", VA = "0x18665C4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x18667A4", Offset = "0x18667A4", VA = "0x18667A4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x186697C", Offset = "0x186697C", VA = "0x186697C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x18675D4", Offset = "0x18675D4", VA = "0x18675D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1867828", Offset = "0x1867828", VA = "0x1867828", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1867AC8", Offset = "0x1867AC8", VA = "0x1867AC8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1867B58", Offset = "0x1867B58", VA = "0x1867B58", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1867BE8", Offset = "0x1867BE8", VA = "0x1867BE8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1867ECC", Offset = "0x1867ECC", VA = "0x1867ECC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1865754", Offset = "0x1865754", VA = "0x1865754")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1865988", Offset = "0x1865988", VA = "0x1865988")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1865F40", Offset = "0x1865F40", VA = "0x1865F40")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1866B70", Offset = "0x1866B70", VA = "0x1866B70")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x18682A4", Offset = "0x18682A4", VA = "0x18682A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x18682EC", Offset = "0x18682EC", VA = "0x18682EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x186A22C", Offset = "0x186A22C", VA = "0x186A22C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1866DC0", Offset = "0x1866DC0", VA = "0x1866DC0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1868364", Offset = "0x1868364", VA = "0x1868364")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x186A658", Offset = "0x186A658", VA = "0x186A658")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x186A6B4", Offset = "0x186A6B4", VA = "0x186A6B4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x186A010", Offset = "0x186A010", VA = "0x186A010")]
		private void Write()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x186A710", Offset = "0x186A710", VA = "0x186A710")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000A5")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IK ik;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9EDC", Offset = "0x3A9EDC")]
		public Transform parent;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9F10", Offset = "0x3A9F10")]
		public Transform child;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9F44", Offset = "0x3A9F44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9F44", Offset = "0x3A9F44")]
		public float weight;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3A9FC0", Offset = "0x3A9FC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3A9FC0", Offset = "0x3A9FC0")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA010", Offset = "0x3AA010")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AA010", Offset = "0x3AA010")]
		public float twistAngleOffset;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 axis;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x12EC8C0", Offset = "0x12EC8C0", VA = "0x12EC8C0")]
		public TwistRelaxer()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x12EC990", Offset = "0x12EC990", VA = "0x12EC990")]
		public void Relax()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x12ECEF4", Offset = "0x12ECEF4", VA = "0x12ECEF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x12ED558", Offset = "0x12ED558", VA = "0x12ED558")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x12ED5F4", Offset = "0x12ED5F4", VA = "0x12ED5F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x12ED690", Offset = "0x12ED690", VA = "0x12ED690")]
		private void OnDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AA088", Offset = "0x3AA088")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AA088", Offset = "0x3AA088")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AA0BC", Offset = "0x3AA0BC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AA0BC", Offset = "0x3AA0BC")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AA0F0", Offset = "0x3AA0F0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AA0F0", Offset = "0x3AA0F0")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Poser poser;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IKEffector effector;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float timer;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float length;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float weight;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float fadeInSpeed;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float defaultPull;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float defaultReach;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float defaultPush;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPushParent;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float resetTimer;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool pullUsed;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		private bool reachUsed;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool pushUsed;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool pushParentUsed;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool pickedUp;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		private bool defaults;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform target;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private List<bool> triggered;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool started;

		[Token(Token = "0x170000BC")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x14D998C", Offset = "0x14D998C", VA = "0x14D998C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF8C", Offset = "0x3AFF8C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x14D9984", Offset = "0x14D9984", VA = "0x14D9984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFF9C", Offset = "0x3AFF9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public bool isPaused
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x14D9994", Offset = "0x14D9994", VA = "0x14D9994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFFAC", Offset = "0x3AFFAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x14D999C", Offset = "0x14D999C", VA = "0x14D999C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFFBC", Offset = "0x3AFFBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x14D99A4", Offset = "0x14D99A4", VA = "0x14D99A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFFCC", Offset = "0x3AFFCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x14D99AC", Offset = "0x14D99AC", VA = "0x14D99AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AFFDC", Offset = "0x3AFFDC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public bool inInteraction
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x14D99B4", Offset = "0x14D99B4", VA = "0x14D99B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public float progress
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x14DDB04", Offset = "0x14DDB04", VA = "0x14DDB04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x14D98F0", Offset = "0x14D98F0", VA = "0x14D98F0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x14D9A40", Offset = "0x14D9A40", VA = "0x14D9A40")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x14D9B44", Offset = "0x14D9B44", VA = "0x14D9B44")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x14D9DDC", Offset = "0x14D9DDC", VA = "0x14D9DDC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x14DA498", Offset = "0x14DA498", VA = "0x14DA498")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x14DA8F0", Offset = "0x14DA8F0", VA = "0x14DA8F0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x14DA984", Offset = "0x14DA984", VA = "0x14DA984")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x14DB9F0", Offset = "0x14DB9F0", VA = "0x14DB9F0")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x14DCCB4", Offset = "0x14DCCB4", VA = "0x14DCCB4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x14DD244", Offset = "0x14DD244", VA = "0x14DD244")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x14DD908", Offset = "0x14DD908", VA = "0x14DD908")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x14DE054", Offset = "0x14DE054", VA = "0x14DE054")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA124", Offset = "0x3AA124")]
		public LookAtIK ik;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA158", Offset = "0x3AA158")]
		public float lerpSpeed;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA1B0", Offset = "0x3AA1B0")]
		public float weightSpeed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AA208", Offset = "0x3AA208")]
		public bool isPaused;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform lookAtTarget;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float stopLookTime;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float weight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x14DE43C", Offset = "0x14DE43C", VA = "0x14DE43C")]
		public InteractionLookAt()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x14DE458", Offset = "0x14DE458", VA = "0x14DE458")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x14DE6A4", Offset = "0x14DE6A4", VA = "0x14DE6A4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x14DE798", Offset = "0x14DE798", VA = "0x14DE798")]
		public void Update()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x14DEAF0", Offset = "0x14DEAF0", VA = "0x14DEAF0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x14DECD4", Offset = "0x14DECD4", VA = "0x14DECD4")]
		public void SolveHead()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2BD8", Offset = "0x3A2BD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2BD8", Offset = "0x3A2BD8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class InteractionEvent
		{
			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA31C", Offset = "0x3AA31C")]
			public float time;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA378", Offset = "0x3AA378")]
			public bool pause;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA3AC", Offset = "0x3AA3AC")]
			public bool pickUp;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA3E0", Offset = "0x3AA3E0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA434", Offset = "0x3AA434")]
			public Message[] messages;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA4A0", Offset = "0x3AA4A0")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x14E08EC", Offset = "0x14E08EC", VA = "0x14E08EC")]
			public InteractionEvent()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x14DDB44", Offset = "0x14DDB44", VA = "0x14DDB44")]
			public void Activate(Transform t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Message
		{
			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA4F4", Offset = "0x3AA4F4")]
			public string function;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA544", Offset = "0x3AA544")]
			public GameObject recipient;

			[Token(Token = "0x4000592")]
			private const string empty = "";

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x14E0A80", Offset = "0x14E0A80", VA = "0x14E0A80")]
			public Message()
			{
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x14E08F4", Offset = "0x14E08F4", VA = "0x14E08F4")]
			public void Send(Transform t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA58C", Offset = "0x3AA58C")]
			public Animator animator;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA5F8", Offset = "0x3AA5F8")]
			public Animation animation;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA62C", Offset = "0x3AA62C")]
			public string animationState;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA67C", Offset = "0x3AA67C")]
			public float crossfadeTime;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA6C0", Offset = "0x3AA6C0")]
			public int layer;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA6F4", Offset = "0x3AA6F4")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000599")]
			private const string empty = "";

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x14E0514", Offset = "0x14E0514", VA = "0x14E0514")]
			public AnimatorEvent()
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x14E0528", Offset = "0x14E0528", VA = "0x14E0528")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x14E064C", Offset = "0x14E064C", VA = "0x14E064C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x14E0768", Offset = "0x14E0768", VA = "0x14E0768")]
			private void Activate(Animation animation)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000AD")]
			public enum Type
			{
				[Token(Token = "0x400059D")]
				PositionWeight,
				[Token(Token = "0x400059E")]
				RotationWeight,
				[Token(Token = "0x400059F")]
				PositionOffsetX,
				[Token(Token = "0x40005A0")]
				PositionOffsetY,
				[Token(Token = "0x40005A1")]
				PositionOffsetZ,
				[Token(Token = "0x40005A2")]
				Pull,
				[Token(Token = "0x40005A3")]
				Reach,
				[Token(Token = "0x40005A4")]
				RotateBoneWeight,
				[Token(Token = "0x40005A5")]
				Push,
				[Token(Token = "0x40005A6")]
				PushParent,
				[Token(Token = "0x40005A7")]
				PoserWeight
			}

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA75C", Offset = "0x3AA75C")]
			public Type type;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA7C4", Offset = "0x3AA7C4")]
			public AnimationCurve curve;

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x14E0A98", Offset = "0x14E0A98", VA = "0x14E0A98")]
			public WeightCurve()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x14DF984", Offset = "0x14DF984", VA = "0x14DF984")]
			public float GetValue(float timer)
			{
				return default(float);
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		public class Multiplier
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA804", Offset = "0x3AA804")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA84C", Offset = "0x3AA84C")]
			public float multiplier;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA8A0", Offset = "0x3AA8A0")]
			public WeightCurve.Type result;

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x14E0A88", Offset = "0x14E0A88", VA = "0x14E0A88")]
			public Multiplier()
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x14E0370", Offset = "0x14E0370", VA = "0x14E0370")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA218", Offset = "0x3AA218")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA24C", Offset = "0x3AA24C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA280", Offset = "0x3AA280")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AA2B4", Offset = "0x3AA2B4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AA2B4", Offset = "0x3AA2B4")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AA2E8", Offset = "0x3AA2E8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AA2E8", Offset = "0x3AA2E8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000C1")]
		public float length
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x14DB34C", Offset = "0x14DB34C", VA = "0x14DB34C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0124", Offset = "0x3B0124")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x14DF0EC", Offset = "0x14DF0EC", VA = "0x14DF0EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0134", Offset = "0x3B0134")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x14DF0F4", Offset = "0x14DF0F4", VA = "0x14DF0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0144", Offset = "0x3B0144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x14DF0FC", Offset = "0x14DF0FC", VA = "0x14DF0FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0154", Offset = "0x3B0154")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x14DF450", Offset = "0x14DF450", VA = "0x14DF450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x14DDED4", Offset = "0x14DDED4", VA = "0x14DDED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x14DEE38", Offset = "0x14DEE38", VA = "0x14DEE38")]
		public InteractionObject()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x14DEEAC", Offset = "0x14DEEAC", VA = "0x14DEEAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AFFEC", Offset = "0x3AFFEC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x14DEF0C", Offset = "0x14DEF0C", VA = "0x14DEF0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0020", Offset = "0x3B0020")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x14DEF6C", Offset = "0x14DEF6C", VA = "0x14DEF6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0054", Offset = "0x3B0054")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x14DEFCC", Offset = "0x14DEFCC", VA = "0x14DEFCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0088", Offset = "0x3B0088")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x14DF02C", Offset = "0x14DF02C", VA = "0x14DF02C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B00BC", Offset = "0x3B00BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x14DF08C", Offset = "0x14DF08C", VA = "0x14DF08C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B00F0", Offset = "0x3B00F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x14DF104", Offset = "0x14DF104", VA = "0x14DF104")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x14DF4F4", Offset = "0x14DF4F4", VA = "0x14DF4F4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x14DB260", Offset = "0x14DB260", VA = "0x14DB260")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x14DF7A4", Offset = "0x14DF7A4", VA = "0x14DF7A4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x14DAFCC", Offset = "0x14DAFCC", VA = "0x14DAFCC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x14DB258", Offset = "0x14DB258", VA = "0x14DB258")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x14DC4BC", Offset = "0x14DC4BC", VA = "0x14DC4BC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x14DD590", Offset = "0x14DD590", VA = "0x14DD590")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x14E03B4", Offset = "0x14E03B4", VA = "0x14E03B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x14DF9B8", Offset = "0x14DF9B8", VA = "0x14DF9B8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x14DF7AC", Offset = "0x14DF7AC", VA = "0x14DF7AC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x14E02D4", Offset = "0x14E02D4", VA = "0x14E02D4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x14E03B8", Offset = "0x14E03B8", VA = "0x14E03B8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x14E0454", Offset = "0x14E0454", VA = "0x14E0454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0164", Offset = "0x3B0164")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x14E04B4", Offset = "0x14E04B4", VA = "0x14E04B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0198", Offset = "0x3B0198")]
		private void OpenScriptReference()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2C38", Offset = "0x3A2C38")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2C38", Offset = "0x3A2C38")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000B1")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA904", Offset = "0x3AA904")]
		public string targetTag;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA938", Offset = "0x3AA938")]
		public float fadeInTime;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA98C", Offset = "0x3AA98C")]
		public float speed;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AA9E0", Offset = "0x3AA9E0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AAA14", Offset = "0x3AAA14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAA14", Offset = "0x3AAA14")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3AAA14", Offset = "0x3AAA14")]
		public Collider characterCollider;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAAA0", Offset = "0x3AAAA0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3AAAA0", Offset = "0x3AAAA0")]
		public Transform FPSCamera;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAB00", Offset = "0x3AAB00")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAB34", Offset = "0x3AAB34")]
		public float camRaycastDistance;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AAB8C", Offset = "0x3AAB8C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AAB8C", Offset = "0x3AAB8C")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x3AABC0", Offset = "0x3AABC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AABC0", Offset = "0x3AABC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAC20", Offset = "0x3AAC20")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Collider lastCollider;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Collider c;

		[Token(Token = "0x170000C5")]
		public bool inInteraction
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x14E1258", Offset = "0x14E1258", VA = "0x14E1258")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C6")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x14D9B3C", Offset = "0x14D9B3C", VA = "0x14D9B3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x14E3F00", Offset = "0x14E3F00", VA = "0x14E3F00")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x14E27EC", Offset = "0x14E27EC", VA = "0x14E27EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0304", Offset = "0x3B0304")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x14E3F08", Offset = "0x14E3F08", VA = "0x14E3F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0314", Offset = "0x3B0314")]
			private set
			{
			}
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x14E0AA0", Offset = "0x14E0AA0", VA = "0x14E0AA0")]
		public InteractionSystem()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x14E1018", Offset = "0x14E1018", VA = "0x14E1018")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B01CC", Offset = "0x3B01CC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x14E1078", Offset = "0x14E1078", VA = "0x14E1078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0200", Offset = "0x3B0200")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x14E10D8", Offset = "0x14E10D8", VA = "0x14E10D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0234", Offset = "0x3B0234")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x14E1138", Offset = "0x14E1138", VA = "0x14E1138")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0268", Offset = "0x3B0268")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x14E1198", Offset = "0x14E1198", VA = "0x14E1198")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B029C", Offset = "0x3B029C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x14E11F8", Offset = "0x14E11F8", VA = "0x14E11F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B02D0", Offset = "0x3B02D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x14E1474", Offset = "0x14E1474", VA = "0x14E1474")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x14E15D0", Offset = "0x14E15D0", VA = "0x14E15D0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x14E1728", Offset = "0x14E1728", VA = "0x14E1728")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x14E1830", Offset = "0x14E1830", VA = "0x14E1830")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x14E19C4", Offset = "0x14E19C4", VA = "0x14E19C4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x14E1B78", Offset = "0x14E1B78", VA = "0x14E1B78")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x14E1C70", Offset = "0x14E1C70", VA = "0x14E1C70")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x14E1D68", Offset = "0x14E1D68", VA = "0x14E1D68")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x14E1E60", Offset = "0x14E1E60", VA = "0x14E1E60")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x14E1EFC", Offset = "0x14E1EFC", VA = "0x14E1EFC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x14E1F98", Offset = "0x14E1F98", VA = "0x14E1F98")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x14E2024", Offset = "0x14E2024", VA = "0x14E2024")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x14E2120", Offset = "0x14E2120", VA = "0x14E2120")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x14E2248", Offset = "0x14E2248", VA = "0x14E2248")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x14E239C", Offset = "0x14E239C", VA = "0x14E239C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x14E27F4", Offset = "0x14E27F4", VA = "0x14E27F4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x14E2ADC", Offset = "0x14E2ADC", VA = "0x14E2ADC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x14E2F00", Offset = "0x14E2F00", VA = "0x14E2F00")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x14E334C", Offset = "0x14E334C", VA = "0x14E334C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x14E33B4", Offset = "0x14E33B4", VA = "0x14E33B4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x14E34BC", Offset = "0x14E34BC", VA = "0x14E34BC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x14E3648", Offset = "0x14E3648", VA = "0x14E3648")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x14E3838", Offset = "0x14E3838", VA = "0x14E3838")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x14E3D74", Offset = "0x14E3D74", VA = "0x14E3D74")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x14E3064", Offset = "0x14E3064", VA = "0x14E3064")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x14E3F10", Offset = "0x14E3F10", VA = "0x14E3F10")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x14E4AF4", Offset = "0x14E4AF4", VA = "0x14E4AF4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x14E4B1C", Offset = "0x14E4B1C", VA = "0x14E4B1C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x14E4B44", Offset = "0x14E4B44", VA = "0x14E4B44")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x14E4B6C", Offset = "0x14E4B6C", VA = "0x14E4B6C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x14E4BF4", Offset = "0x14E4BF4", VA = "0x14E4BF4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x14E4D68", Offset = "0x14E4D68", VA = "0x14E4D68")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x14E4EA0", Offset = "0x14E4EA0", VA = "0x14E4EA0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x14E5368", Offset = "0x14E5368", VA = "0x14E5368")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x14E548C", Offset = "0x14E548C", VA = "0x14E548C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x14E581C", Offset = "0x14E581C", VA = "0x14E581C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x14E474C", Offset = "0x14E474C", VA = "0x14E474C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x14E5964", Offset = "0x14E5964", VA = "0x14E5964")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x14E5B24", Offset = "0x14E5B24", VA = "0x14E5B24")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x14E5BF4", Offset = "0x14E5BF4", VA = "0x14E5BF4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x14E5D34", Offset = "0x14E5D34", VA = "0x14E5D34")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x14E5D5C", Offset = "0x14E5D5C", VA = "0x14E5D5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x14E1360", Offset = "0x14E1360", VA = "0x14E1360")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x14E267C", Offset = "0x14E267C", VA = "0x14E267C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x14E641C", Offset = "0x14E641C", VA = "0x14E641C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0324", Offset = "0x3B0324")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x14E647C", Offset = "0x14E647C", VA = "0x14E647C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0358", Offset = "0x3B0358")]
		private void OpenScriptReference()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2C98", Offset = "0x3A2C98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2C98", Offset = "0x3A2C98")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public class Multiplier
		{
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAE60", Offset = "0x3AAE60")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAEC4", Offset = "0x3AAEC4")]
			public float multiplier;

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x14E69F8", Offset = "0x14E69F8", VA = "0x14E69F8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAC74", Offset = "0x3AAC74")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AACC0", Offset = "0x3AACC0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AACF4", Offset = "0x3AACF4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAD28", Offset = "0x3AAD28")]
		public Transform pivot;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAD5C", Offset = "0x3AAD5C")]
		public Vector3 twistAxis;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AADC4", Offset = "0x3AADC4")]
		public float twistWeight;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AADF8", Offset = "0x3AADF8")]
		public float swingWeight;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAE2C", Offset = "0x3AAE2C")]
		public bool rotateOnce;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Transform lastPivot;

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x14E6644", Offset = "0x14E6644", VA = "0x14E6644")]
		public InteractionTarget()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x14E66F8", Offset = "0x14E66F8", VA = "0x14E66F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B038C", Offset = "0x3B038C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x14E6758", Offset = "0x14E6758", VA = "0x14E6758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B03C0", Offset = "0x3B03C0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x14E67B8", Offset = "0x14E67B8", VA = "0x14E67B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B03F4", Offset = "0x3B03F4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x14E6818", Offset = "0x14E6818", VA = "0x14E6818")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0428", Offset = "0x3B0428")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x14E6878", Offset = "0x14E6878", VA = "0x14E6878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B045C", Offset = "0x3B045C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x14E68D8", Offset = "0x14E68D8", VA = "0x14E68D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0490", Offset = "0x3B0490")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x14DF894", Offset = "0x14DF894", VA = "0x14DF894")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x14DDF78", Offset = "0x14DDF78", VA = "0x14DDF78")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x14DB354", Offset = "0x14DB354", VA = "0x14DB354")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x14E6938", Offset = "0x14E6938", VA = "0x14E6938")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B04C4", Offset = "0x3B04C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x14E6998", Offset = "0x14E6998", VA = "0x14E6998")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B04F8", Offset = "0x3B04F8")]
		private void OpenScriptReference()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2CF8", Offset = "0x3A2CF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2CF8", Offset = "0x3A2CF8")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAF48", Offset = "0x3AAF48")]
			public bool use;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAF7C", Offset = "0x3AAF7C")]
			public Vector2 offset;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAFB0", Offset = "0x3AAFB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AAFB0", Offset = "0x3AAFB0")]
			public float angleOffset;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB034", Offset = "0x3AB034")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB034", Offset = "0x3AB034")]
			public float maxAngle;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB088", Offset = "0x3AB088")]
			public float radius;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB0BC", Offset = "0x3AB0BC")]
			public bool orbit;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB0F0", Offset = "0x3AB0F0")]
			public bool fixYAxis;

			[Token(Token = "0x170000C8")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x14E7404", Offset = "0x14E7404", VA = "0x14E7404")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C9")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x14E7440", Offset = "0x14E7440", VA = "0x14E7440")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x14E73E8", Offset = "0x14E73E8", VA = "0x14E73E8")]
			public CharacterPosition()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x14E7558", Offset = "0x14E7558", VA = "0x14E7558")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class CameraPosition
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB124", Offset = "0x3AB124")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB158", Offset = "0x3AB158")]
			public Vector3 direction;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB18C", Offset = "0x3AB18C")]
			public float maxDistance;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB1EC", Offset = "0x3AB1EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB1EC", Offset = "0x3AB1EC")]
			public float maxAngle;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB240", Offset = "0x3AB240")]
			public bool fixYAxis;

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x14E6D44", Offset = "0x14E6D44", VA = "0x14E6D44")]
			public CameraPosition()
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x14E6E14", Offset = "0x14E6E14", VA = "0x14E6E14")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x14E7050", Offset = "0x14E7050", VA = "0x14E7050")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000B8")]
			public class Interaction
			{
				[Token(Token = "0x40005E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB408", Offset = "0x3AB408")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40005E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB45C", Offset = "0x3AB45C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000602")]
				[Address(RVA = "0x14E7EA0", Offset = "0x14E7EA0", VA = "0x14E7EA0")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB274", Offset = "0x3AB274")]
			[SerializeField]
			public string name;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB2A4", Offset = "0x3AB2A4")]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB2D4", Offset = "0x3AB2D4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB338", Offset = "0x3AB338")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB3A0", Offset = "0x3AB3A0")]
			public Interaction[] interactions;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x14E7E90", Offset = "0x14E7E90", VA = "0x14E7E90")]
			public Range()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x14E6B98", Offset = "0x14E6B98", VA = "0x14E6B98")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AAF14", Offset = "0x3AAF14")]
		public Range[] ranges;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x14E6A00", Offset = "0x14E6A00", VA = "0x14E6A00")]
		public InteractionTrigger()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x14E6A74", Offset = "0x14E6A74", VA = "0x14E6A74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B052C", Offset = "0x3B052C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x14E6AD4", Offset = "0x14E6AD4", VA = "0x14E6AD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0560", Offset = "0x3B0560")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x14E6B34", Offset = "0x14E6B34", VA = "0x14E6B34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0594", Offset = "0x3B0594")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x14E6B94", Offset = "0x14E6B94", VA = "0x14E6B94")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x14E512C", Offset = "0x14E512C", VA = "0x14E512C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B9")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class Map
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform bone;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform target;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x179B414", Offset = "0x179B414", VA = "0x179B414")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x179B96C", Offset = "0x179B96C", VA = "0x179B96C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x179B8E4", Offset = "0x179B8E4", VA = "0x179B8E4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x179B638", Offset = "0x179B638", VA = "0x179B638")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Map[] maps;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x179AFD0", Offset = "0x179AFD0", VA = "0x179AFD0")]
		public GenericPoser()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x179AFD8", Offset = "0x179AFD8", VA = "0x179AFD8", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B05C8", Offset = "0x3B05C8")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x179B4D0", Offset = "0x179B4D0", VA = "0x179B4D0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x179B4D4", Offset = "0x179B4D4", VA = "0x179B4D4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x179B858", Offset = "0x179B858", VA = "0x179B858", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x179B444", Offset = "0x179B444", VA = "0x179B444")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x179B2F0", Offset = "0x179B2F0", VA = "0x179B2F0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform[] children;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform _poseRoot;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] poseChildren;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x17A9E74", Offset = "0x17A9E74", VA = "0x17A9E74")]
		public HandPoser()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x17A9E7C", Offset = "0x17A9E7C", VA = "0x17A9E7C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x17A9F64", Offset = "0x17A9F64", VA = "0x17A9F64", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x17AA208", Offset = "0x17AA208", VA = "0x17AA208", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x17AA3AC", Offset = "0x17AA3AC", VA = "0x17AA3AC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x17A9FD4", Offset = "0x17A9FD4", VA = "0x17A9FD4")]
		protected void StoreDefaultState()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform poseRoot;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB4A8", Offset = "0x3AB4A8")]
		public float weight;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB4C0", Offset = "0x3AB4C0")]
		public float localRotationWeight;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB4D8", Offset = "0x3AB4D8")]
		public float localPositionWeight;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool initiated;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x14EB9AC", Offset = "0x14EB9AC", VA = "0x14EB9AC")]
		protected Poser()
		{
		}

		[Token(Token = "0x6000615")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x14EB9C0", Offset = "0x14EB9C0", VA = "0x14EB9C0")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000617")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000618")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000619")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x14EB9D0", Offset = "0x14EB9D0", VA = "0x14EB9D0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x14EBA20", Offset = "0x14EBA20", VA = "0x14EBA20", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x14EBA58", Offset = "0x14EBA58", VA = "0x14EBA58", Slot = "6")]
		protected override void FixTransforms()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A2D58", Offset = "0x3A2D58")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public class Rigidbone
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody r;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform t;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider collider;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Joint joint;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody c;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool updateAnchor;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float deltaTime;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 lastPosition;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion lastRotation;

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x14EC2F0", Offset = "0x14EC2F0", VA = "0x14EC2F0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x14ED458", Offset = "0x14ED458", VA = "0x14ED458")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x14ED130", Offset = "0x14ED130", VA = "0x14ED130")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000BF")]
		public class Child
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform t;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 localPosition;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion localRotation;

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x14EC4F4", Offset = "0x14EC4F4", VA = "0x14EC4F4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x14ED698", Offset = "0x14ED698", VA = "0x14ED698")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x14ED614", Offset = "0x14ED614", VA = "0x14ED614")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A33C4", Offset = "0x3A33C4")]
		private sealed class <DisableRagdollSmooth>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RagdollUtility $this;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x14EDF78", Offset = "0x14EDF78", VA = "0x14EDF78", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0x14EDF80", Offset = "0x14EDF80", VA = "0x14EDF80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x14EC584", Offset = "0x14EC584", VA = "0x14EC584")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>c__Iterator0()
			{
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x14EDAA0", Offset = "0x14EDAA0", VA = "0x14EDAA0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x14EDF88", Offset = "0x14EDF88", VA = "0x14EDF88", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x14EDF9C", Offset = "0x14EDF9C", VA = "0x14EDF9C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB4F0", Offset = "0x3AB4F0")]
		public IK ik;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB524", Offset = "0x3AB524")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB58C", Offset = "0x3AB58C")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB5F8", Offset = "0x3AB5F8")]
		public float applyVelocity;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB65C", Offset = "0x3AB65C")]
		public float applyAngularVelocity;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Child[] children;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private IK[] allIKComponents;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool[] fixTransforms;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float ragdollWeight;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float ragdollWeightV;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool fixedFrame;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000CA")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x14EBB94", Offset = "0x14EBB94", VA = "0x14EBB94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		private bool ikUsed
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x14ECAD8", Offset = "0x14ECAD8", VA = "0x14ECAD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x14EBA74", Offset = "0x14EBA74", VA = "0x14EBA74")]
		public RagdollUtility()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x14EBB64", Offset = "0x14EBB64", VA = "0x14EBB64")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x14EBC3C", Offset = "0x14EBC3C", VA = "0x14EBC3C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x14EBD78", Offset = "0x14EBD78", VA = "0x14EBD78")]
		public void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x14EBCF4", Offset = "0x14EBCF4", VA = "0x14EBCF4")]
		[DebuggerHidden]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x14EC58C", Offset = "0x14EC58C", VA = "0x14EC58C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x14EC960", Offset = "0x14EC960", VA = "0x14EC960")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x14ECA10", Offset = "0x14ECA10", VA = "0x14ECA10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x14ECCE4", Offset = "0x14ECCE4", VA = "0x14ECCE4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x14ECAA4", Offset = "0x14ECAA4", VA = "0x14ECAA4")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x14ECCB0", Offset = "0x14ECCB0", VA = "0x14ECCB0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x14ECD78", Offset = "0x14ECD78", VA = "0x14ECD78")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x14ECD08", Offset = "0x14ECD08", VA = "0x14ECD08")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x14EBC84", Offset = "0x14EBC84", VA = "0x14EBC84")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x14EC998", Offset = "0x14EC998", VA = "0x14EC998")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x14ED8E4", Offset = "0x14ED8E4", VA = "0x14ED8E4")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 axis;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB690", Offset = "0x3AB690")]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool initiated;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool applicationQuit;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000CC")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x12E7650", Offset = "0x12E7650", VA = "0x12E7650")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CD")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x12E768C", Offset = "0x12E768C", VA = "0x12E768C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x12E7130", Offset = "0x12E7130", VA = "0x12E7130")]
		protected RotationLimit()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x12E71D4", Offset = "0x12E71D4", VA = "0x12E71D4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x12E7234", Offset = "0x12E7234", VA = "0x12E7234")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x12E756C", Offset = "0x12E756C", VA = "0x12E756C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x12E7620", Offset = "0x12E7620", VA = "0x12E7620")]
		public void Disable()
		{
		}

		[Token(Token = "0x600063C")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x12E7450", Offset = "0x12E7450", VA = "0x12E7450")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x12E7760", Offset = "0x12E7760", VA = "0x12E7760")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x12E7764", Offset = "0x12E7764", VA = "0x12E7764")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x12E7870", Offset = "0x12E7870", VA = "0x12E7870")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x12E7988", Offset = "0x12E7988", VA = "0x12E7988")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x12E7CA0", Offset = "0x12E7CA0", VA = "0x12E7CA0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2DD0", Offset = "0x3A2DD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2DD0", Offset = "0x3A2DD0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB6A0", Offset = "0x3AB6A0")]
		public float limit;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB6BC", Offset = "0x3AB6BC")]
		public float twistLimit;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x12E7D9C", Offset = "0x12E7D9C", VA = "0x12E7D9C")]
		public RotationLimitAngle()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x12E7DB8", Offset = "0x12E7DB8", VA = "0x12E7DB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0614", Offset = "0x3B0614")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x12E7E18", Offset = "0x12E7E18", VA = "0x12E7E18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0648", Offset = "0x3B0648")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x12E7E78", Offset = "0x12E7E78", VA = "0x12E7E78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B067C", Offset = "0x3B067C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x12E7ED8", Offset = "0x12E7ED8", VA = "0x12E7ED8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B06B0", Offset = "0x3B06B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x12E7F38", Offset = "0x12E7F38", VA = "0x12E7F38", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x12E7FE4", Offset = "0x12E7FE4", VA = "0x12E7FE4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2E68", Offset = "0x3A2E68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2E68", Offset = "0x3A2E68")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool useLimits;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float min;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float max;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB6D8", Offset = "0x3AB6D8")]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion lastRotation;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x12E82D8", Offset = "0x12E82D8", VA = "0x12E82D8")]
		public RotationLimitHinge()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x12E83A0", Offset = "0x12E83A0", VA = "0x12E83A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B06E4", Offset = "0x3B06E4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x12E8400", Offset = "0x12E8400", VA = "0x12E8400")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0718", Offset = "0x3B0718")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x12E8460", Offset = "0x12E8460", VA = "0x12E8460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B074C", Offset = "0x3B074C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x12E84C0", Offset = "0x12E84C0", VA = "0x12E84C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0780", Offset = "0x3B0780")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x12E8520", Offset = "0x12E8520", VA = "0x12E8520", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x12E856C", Offset = "0x12E856C", VA = "0x12E856C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2F00", Offset = "0x3A2F00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2F00", Offset = "0x3A2F00")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class ReachCone
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float volume;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 S;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 B;

			[Token(Token = "0x170000CE")]
			public Vector3 o
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x12EB318", Offset = "0x12EB318", VA = "0x12EB318")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CF")]
			public Vector3 a
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x12EB368", Offset = "0x12EB368", VA = "0x12EB368")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D0")]
			public Vector3 b
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x12EB3B8", Offset = "0x12EB3B8", VA = "0x12EB3B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D1")]
			public Vector3 c
			{
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x12EB408", Offset = "0x12EB408", VA = "0x12EB408")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D2")]
			public bool isValid
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x12EA120", Offset = "0x12EA120", VA = "0x12EA120")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x12EA920", Offset = "0x12EA920", VA = "0x12EA920")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x12EAB14", Offset = "0x12EAB14", VA = "0x12EAB14")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class LimitPoint
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 point;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float tangentWeight;

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x12EA138", Offset = "0x12EA138", VA = "0x12EA138")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB6E8", Offset = "0x3AB6E8")]
		public float twistLimit;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB704", Offset = "0x3AB704")]
		public int smoothIterations;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB720", Offset = "0x3AB720")]
		public LimitPoint[] points;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB750", Offset = "0x3AB750")]
		public Vector3[] P;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB780", Offset = "0x3AB780")]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x12E8914", Offset = "0x12E8914", VA = "0x12E8914")]
		public RotationLimitPolygonal()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x12E8990", Offset = "0x12E8990", VA = "0x12E8990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B07B4", Offset = "0x3B07B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x12E89F0", Offset = "0x12E89F0", VA = "0x12E89F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B07E8", Offset = "0x3B07E8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x12E8A50", Offset = "0x12E8A50", VA = "0x12E8A50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B081C", Offset = "0x3B081C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x12E8AB0", Offset = "0x12E8AB0", VA = "0x12E8AB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0850", Offset = "0x3B0850")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x12E8B10", Offset = "0x12E8B10", VA = "0x12E8B10")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x12E9218", Offset = "0x12E9218", VA = "0x12E9218", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x12E92FC", Offset = "0x12E92FC", VA = "0x12E92FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x12E9BB4", Offset = "0x12E9BB4", VA = "0x12E9BB4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x12E8BB8", Offset = "0x12E8BB8", VA = "0x12E8BB8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x12EA1E0", Offset = "0x12EA1E0", VA = "0x12EA1E0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x12EAD14", Offset = "0x12EAD14", VA = "0x12EAD14")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x12EAD5C", Offset = "0x12EAD5C", VA = "0x12EAD5C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x12EAEC4", Offset = "0x12EAEC4", VA = "0x12EAEC4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x12E9750", Offset = "0x12E9750", VA = "0x12E9750")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x12EB070", Offset = "0x12EB070", VA = "0x12EB070")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3A2F60", Offset = "0x3A2F60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3A2F60", Offset = "0x3A2F60")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB7B0", Offset = "0x3AB7B0")]
		public float twistLimit;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AB7CC", Offset = "0x3AB7CC")]
		public AnimationCurve spline;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x12EB458", Offset = "0x12EB458", VA = "0x12EB458")]
		public RotationLimitSpline()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x12EB468", Offset = "0x12EB468", VA = "0x12EB468")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0884", Offset = "0x3B0884")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x12EB4C8", Offset = "0x12EB4C8", VA = "0x12EB4C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B08B8", Offset = "0x3B08B8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x12EB528", Offset = "0x12EB528", VA = "0x12EB528")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B08EC", Offset = "0x3B08EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x12EB588", Offset = "0x12EB588", VA = "0x12EB588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3B0920", Offset = "0x3B0920")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x12EB5E8", Offset = "0x12EB5E8", VA = "0x12EB5E8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x12EB61C", Offset = "0x12EB61C", VA = "0x12EB61C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x12EB6C8", Offset = "0x12EB6C8", VA = "0x12EB6C8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x20000C7")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A33D4", Offset = "0x3A33D4")]
		private sealed class <TurnToTarget>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AimController $this;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000117")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000940")]
				[Address(RVA = "0xD9DDB4", Offset = "0xD9DDB4", VA = "0xD9DDB4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0xD9DDBC", Offset = "0xD9DDBC", VA = "0xD9DDBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xD9DB74", Offset = "0xD9DB74", VA = "0xD9DB74")]
			[DebuggerHidden]
			public <TurnToTarget>c__Iterator0()
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xD9DB7C", Offset = "0xD9DB7C", VA = "0xD9DB7C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xD9DDC4", Offset = "0xD9DDC4", VA = "0xD9DDC4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0xD9DDD8", Offset = "0xD9DDD8", VA = "0xD9DDD8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB7FC", Offset = "0x3AB7FC")]
		public AimIK ik;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB830", Offset = "0x3AB830")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AB830", Offset = "0x3AB830")]
		public float weight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AB898", Offset = "0x3AB898")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB898", Offset = "0x3AB898")]
		public Transform target;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB8F8", Offset = "0x3AB8F8")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB92C", Offset = "0x3AB92C")]
		public float weightSmoothTime;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AB98C", Offset = "0x3AB98C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB98C", Offset = "0x3AB98C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AB9EC", Offset = "0x3AB9EC")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABA20", Offset = "0x3ABA20")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABA54", Offset = "0x3ABA54")]
		public float slerpSpeed;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABA88", Offset = "0x3ABA88")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABABC", Offset = "0x3ABABC")]
		public float minDistance;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABAF0", Offset = "0x3ABAF0")]
		public Vector3 offset;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ABB24", Offset = "0x3ABB24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABB24", Offset = "0x3ABB24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ABB24", Offset = "0x3ABB24")]
		public float maxRootAngle;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABBA0", Offset = "0x3ABBA0")]
		public bool turnToTarget;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABBD4", Offset = "0x3ABBD4")]
		public float turnToTargetTime;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ABC08", Offset = "0x3ABC08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABC08", Offset = "0x3ABC08")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABC68", Offset = "0x3ABC68")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float switchWeight;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeightV;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float weightV;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 dir;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool turningToTarget;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float turnToTargetMlpV;

		[Token(Token = "0x170000D3")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0xD9C7EC", Offset = "0xD9C7EC", VA = "0xD9C7EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD9C584", Offset = "0xD9C584", VA = "0xD9C584")]
		public AimController()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xD9C694", Offset = "0xD9C694", VA = "0xD9C694")]
		private void Start()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xD9C980", Offset = "0xD9C980", VA = "0xD9C980")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xD9D478", Offset = "0xD9D478", VA = "0xD9D478")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xD9D678", Offset = "0xD9D678", VA = "0xD9D678")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xD9DAF0", Offset = "0xD9DAF0", VA = "0xD9DAF0")]
		[DebuggerHidden]
		private IEnumerator TurnToTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class Pose
		{
			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool visualize;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string name;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float yaw;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float pitch;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float angleBuffer;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0xD9E4E8", Offset = "0xD9E4E8", VA = "0xD9E4E8")]
			public Pose()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0xD9E144", Offset = "0xD9E144", VA = "0xD9E144")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0xD9E4E0", Offset = "0xD9E4E0", VA = "0xD9E4E0")]
			public void SetAngleBuffer(float value)
			{
			}
		}

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float angleBuffer;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Pose[] poses;

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xD9E0C4", Offset = "0xD9E0C4", VA = "0xD9E0C4")]
		public AimPoser()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xD96494", Offset = "0xD96494", VA = "0xD96494")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xD965F4", Offset = "0xD965F4", VA = "0xD965F4")]
		public void SetPoseActive(Pose pose)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000CC")]
			public class EffectorLink
			{
				[Token(Token = "0x4000657")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABECC", Offset = "0x3ABECC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000658")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABF00", Offset = "0x3ABF00")]
				public float weight;

				[Token(Token = "0x6000683")]
				[Address(RVA = "0xD9ED84", Offset = "0xD9ED84", VA = "0xD9ED84")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABCE0", Offset = "0x3ABCE0")]
			public Transform transform;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABD38", Offset = "0x3ABD38")]
			public Transform relativeTo;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABDA4", Offset = "0x3ABDA4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABDD8", Offset = "0x3ABDD8")]
			public float verticalWeight;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABE40", Offset = "0x3ABE40")]
			public float horizontalWeight;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABE74", Offset = "0x3ABE74")]
			public float speed;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool firstUpdate;

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xD9ED30", Offset = "0xD9ED30", VA = "0xD9ED30")]
			public Body()
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0xD9E698", Offset = "0xD9E698", VA = "0xD9E698")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0xD9ED50", Offset = "0xD9ED50", VA = "0xD9ED50")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABC9C", Offset = "0x3ABC9C")]
		public Body[] bodies;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xD9E510", Offset = "0xD9E510", VA = "0xD9E510")]
		public Amplifier()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xD9E518", Offset = "0xD9E518", VA = "0xD9E518", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABF34", Offset = "0x3ABF34")]
		public float tiltSpeed;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABF74", Offset = "0x3ABF74")]
		public float tiltSensitivity;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABFB8", Offset = "0x3ABFB8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ABFEC", Offset = "0x3ABFEC")]
		public OffsetPose poseRight;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float tiltAngle;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xDA0E74", Offset = "0xDA0E74", VA = "0xDA0E74")]
		public BodyTilt()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xDA0E94", Offset = "0xDA0E94", VA = "0xDA0E94", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xDA0EF0", Offset = "0xDA0EF0", VA = "0xDA0EF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC088", Offset = "0x3AC088")]
			public string name;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC0BC", Offset = "0x3AC0BC")]
			public Collider collider;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC0F0", Offset = "0x3AC0F0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC138", Offset = "0x3AC138")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC138", Offset = "0x3AC138")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC16C", Offset = "0x3AC16C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC16C", Offset = "0x3AC16C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC1A0", Offset = "0x3AC1A0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC1A0", Offset = "0x3AC1A0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC1D4", Offset = "0x3AC1D4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC1D4", Offset = "0x3AC1D4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000D5")]
			public bool inProgress
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x17AAA1C", Offset = "0x17AAA1C", VA = "0x17AAA1C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D6")]
			protected float crossFader
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x17AB0FC", Offset = "0x17AB0FC", VA = "0x17AB0FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0964", Offset = "0x3B0964")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x17AB104", Offset = "0x17AB104", VA = "0x17AB104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0974", Offset = "0x3B0974")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			protected float timer
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x17AB0F4", Offset = "0x17AB0F4", VA = "0x17AB0F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0984", Offset = "0x3B0984")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x17AB10C", Offset = "0x17AB10C", VA = "0x17AB10C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0994", Offset = "0x3B0994")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			protected Vector3 force
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x17AB114", Offset = "0x17AB114", VA = "0x17AB114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B09A4", Offset = "0x3B09A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x17AB128", Offset = "0x17AB128", VA = "0x17AB128")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B09B4", Offset = "0x3B09B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			protected Vector3 point
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x17AB134", Offset = "0x17AB134", VA = "0x17AB134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B09C4", Offset = "0x3B09C4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000694")]
				[Address(RVA = "0x17AB148", Offset = "0x17AB148", VA = "0x17AB148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B09D4", Offset = "0x3B09D4")]
				private set
				{
				}
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x17AB0E0", Offset = "0x17AB0E0", VA = "0x17AB0E0")]
			protected HitPoint()
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x17AAF88", Offset = "0x17AAF88", VA = "0x17AAF88")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x17AAB60", Offset = "0x17AAB60", VA = "0x17AAB60")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000697")]
			protected abstract float GetLength();

			[Token(Token = "0x6000698")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000699")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000D1")]
			public class EffectorLink
			{
				[Token(Token = "0x400066E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC2C8", Offset = "0x3AC2C8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400066F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC2FC", Offset = "0x3AC2FC")]
				public float weight;

				[Token(Token = "0x4000670")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x4000671")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x600069E")]
				[Address(RVA = "0x17ABF80", Offset = "0x17ABF80", VA = "0x17ABF80")]
				public EffectorLink()
				{
				}

				[Token(Token = "0x600069F")]
				[Address(RVA = "0x17ABDE0", Offset = "0x17ABDE0", VA = "0x17ABDE0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60006A0")]
				[Address(RVA = "0x17ABB3C", Offset = "0x17ABB3C", VA = "0x17ABB3C")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC208", Offset = "0x3AC208")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC23C", Offset = "0x3AC23C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC270", Offset = "0x3AC270")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x17AB868", Offset = "0x17AB868", VA = "0x17AB868")]
			public HitPointEffector()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x17AB87C", Offset = "0x17AB87C", VA = "0x17AB87C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x17ABAC4", Offset = "0x17ABAC4", VA = "0x17ABAC4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x17ABB50", Offset = "0x17ABB50", VA = "0x17ABB50", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000D3")]
			public class BoneLink
			{
				[Token(Token = "0x4000675")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC398", Offset = "0x3AC398")]
				public Transform bone;

				[Token(Token = "0x4000676")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC3CC", Offset = "0x3AC3CC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AC3CC", Offset = "0x3AC3CC")]
				public float weight;

				[Token(Token = "0x4000677")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x4000678")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x17AB7A0", Offset = "0x17AB7A0", VA = "0x17AB7A0")]
				public BoneLink()
				{
				}

				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x17AB5DC", Offset = "0x17AB5DC", VA = "0x17AB5DC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x17AB2C4", Offset = "0x17AB2C4", VA = "0x17AB2C4")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC330", Offset = "0x3AC330")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC364", Offset = "0x3AC364")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x17AB154", Offset = "0x17AB154", VA = "0x17AB154")]
			public HitPointBone()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x17AB168", Offset = "0x17AB168", VA = "0x17AB168", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x17AB24C", Offset = "0x17AB24C", VA = "0x17AB24C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x17AB2D8", Offset = "0x17AB2D8", VA = "0x17AB2D8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}
		}

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC020", Offset = "0x3AC020")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC054", Offset = "0x3AC054")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000D4")]
		public bool inProgress
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x17AA924", Offset = "0x17AA924", VA = "0x17AA924")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x17AA91C", Offset = "0x17AA91C", VA = "0x17AA91C")]
		public HitReaction()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x17AAA38", Offset = "0x17AAA38", VA = "0x17AAA38", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x17AACCC", Offset = "0x17AACCC", VA = "0x17AACCC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public abstract class Offset
		{
			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC484", Offset = "0x3AC484")]
			public string name;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC4B8", Offset = "0x3AC4B8")]
			public Collider collider;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC4EC", Offset = "0x3AC4EC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC534", Offset = "0x3AC534")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC534", Offset = "0x3AC534")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC568", Offset = "0x3AC568")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC568", Offset = "0x3AC568")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC59C", Offset = "0x3AC59C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC59C", Offset = "0x3AC59C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AC5D0", Offset = "0x3AC5D0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AC5D0", Offset = "0x3AC5D0")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000DA")]
			protected float crossFader
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x17AC670", Offset = "0x17AC670", VA = "0x17AC670")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B09E4", Offset = "0x3B09E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x17AC678", Offset = "0x17AC678", VA = "0x17AC678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B09F4", Offset = "0x3B09F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			protected float timer
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x17AC680", Offset = "0x17AC680", VA = "0x17AC680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A04", Offset = "0x3B0A04")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x17AC688", Offset = "0x17AC688", VA = "0x17AC688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A14", Offset = "0x3B0A14")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			protected Vector3 force
			{
				[Token(Token = "0x60006B0")]
				[Address(RVA = "0x17AC690", Offset = "0x17AC690", VA = "0x17AC690")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A24", Offset = "0x3B0A24")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006B1")]
				[Address(RVA = "0x17AC6A4", Offset = "0x17AC6A4", VA = "0x17AC6A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A34", Offset = "0x3B0A34")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			protected Vector3 point
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x17AC6B0", Offset = "0x17AC6B0", VA = "0x17AC6B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A44", Offset = "0x3B0A44")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x17AC6C4", Offset = "0x17AC6C4", VA = "0x17AC6C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A54", Offset = "0x3B0A54")]
				private set
				{
				}
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x17AC65C", Offset = "0x17AC65C", VA = "0x17AC65C")]
			protected Offset()
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x17AC4FC", Offset = "0x17AC4FC", VA = "0x17AC4FC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x17AC0B0", Offset = "0x17AC0B0", VA = "0x17AC0B0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006B6")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60006B7")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60006B8")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D7")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC6CC", Offset = "0x3AC6CC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400068A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC700", Offset = "0x3AC700")]
				public float weight;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x400068C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x17ACF10", Offset = "0x17ACF10", VA = "0x17ACF10")]
				public PositionOffsetLink()
				{
				}

				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x17ACDA4", Offset = "0x17ACDA4", VA = "0x17ACDA4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x17ACA98", Offset = "0x17ACA98", VA = "0x17ACA98")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC604", Offset = "0x3AC604")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC638", Offset = "0x3AC638")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC66C", Offset = "0x3AC66C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x17AC6D0", Offset = "0x17AC6D0", VA = "0x17AC6D0")]
			public PositionOffset()
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x17AC6EC", Offset = "0x17AC6EC", VA = "0x17AC6EC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x17ACA20", Offset = "0x17ACA20", VA = "0x17ACA20", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x17ACAAC", Offset = "0x17ACAAC", VA = "0x17ACAAC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D9")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000690")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC79C", Offset = "0x3AC79C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000691")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC7D0", Offset = "0x3AC7D0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AC7D0", Offset = "0x3AC7D0")]
				public float weight;

				[Token(Token = "0x4000692")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x4000693")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x17AD6A8", Offset = "0x17AD6A8", VA = "0x17AD6A8")]
				public RotationOffsetLink()
				{
				}

				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x17AD504", Offset = "0x17AD504", VA = "0x17AD504")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x17AD108", Offset = "0x17AD108", VA = "0x17AD108")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC734", Offset = "0x3AC734")]
			public int curveIndex;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC768", Offset = "0x3AC768")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x17ACF18", Offset = "0x17ACF18", VA = "0x17ACF18")]
			public RotationOffset()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x17ACF2C", Offset = "0x17ACF2C", VA = "0x17ACF2C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x17AD090", Offset = "0x17AD090", VA = "0x17AD090", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x17AD11C", Offset = "0x17AD11C", VA = "0x17AD11C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}
		}

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC41C", Offset = "0x3AC41C")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC450", Offset = "0x3AC450")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x17ABF88", Offset = "0x17ABF88", VA = "0x17ABF88")]
		public HitReactionVRIK()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x17ABF90", Offset = "0x17ABF90", VA = "0x17ABF90", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x17AC228", Offset = "0x17AC228", VA = "0x17AC228")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000DC")]
			public class EffectorLink
			{
				[Token(Token = "0x40006A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACAA4", Offset = "0x3ACAA4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACAD8", Offset = "0x3ACAD8")]
				public float weight;

				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x14D98E8", Offset = "0x14D98E8", VA = "0x14D98E8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC8A8", Offset = "0x3AC8A8")]
			public Transform transform;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC910", Offset = "0x3AC910")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC944", Offset = "0x3AC944")]
			public float speed;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC994", Offset = "0x3AC994")]
			public float acceleration;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC9F8", Offset = "0x3AC9F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AC9F8", Offset = "0x3AC9F8")]
			public float matchVelocity;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACA5C", Offset = "0x3ACA5C")]
			public float gravity;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 delta;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 direction;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 lastPosition;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool firstUpdate;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x14D98C0", Offset = "0x14D98C0", VA = "0x14D98C0")]
			public Body()
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x14D9070", Offset = "0x14D9070", VA = "0x14D9070")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x14D92AC", Offset = "0x14D92AC", VA = "0x14D92AC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}
		}

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC820", Offset = "0x3AC820")]
		public Body[] bodies;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AC860", Offset = "0x3AC860")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x14D8FD0", Offset = "0x14D8FD0", VA = "0x14D8FD0")]
		public Inertia()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x14D8FF0", Offset = "0x14D8FF0", VA = "0x14D8FF0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x14D91B8", Offset = "0x14D91B8", VA = "0x14D91B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LookAtIK ik;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ACB0C", Offset = "0x3ACB0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACB0C", Offset = "0x3ACB0C")]
		public Transform target;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ACB6C", Offset = "0x3ACB6C")]
		public float weight;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACB84", Offset = "0x3ACB84")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACBB8", Offset = "0x3ACBB8")]
		public float weightSmoothTime;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ACC1C", Offset = "0x3ACC1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACC1C", Offset = "0x3ACC1C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACC7C", Offset = "0x3ACC7C")]
		public float maxRadiansDelta;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACCB0", Offset = "0x3ACCB0")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACCE4", Offset = "0x3ACCE4")]
		public float slerpSpeed;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACD18", Offset = "0x3ACD18")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACD4C", Offset = "0x3ACD4C")]
		public float minDistance;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ACD80", Offset = "0x3ACD80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACD80", Offset = "0x3ACD80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ACD80", Offset = "0x3ACD80")]
		public float maxRootAngle;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform lastTarget;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float switchWeight;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float switchWeightV;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float weightV;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 dir;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000DE")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x14E8514", Offset = "0x14E8514", VA = "0x14E8514")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x14E8308", Offset = "0x14E8308", VA = "0x14E8308")]
		public LookAtController()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x14E83EC", Offset = "0x14E83EC", VA = "0x14E83EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x14E86A8", Offset = "0x14E86A8", VA = "0x14E86A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x14E9060", Offset = "0x14E9060", VA = "0x14E9060")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x14E9260", Offset = "0x14E9260", VA = "0x14E9260")]
		private void RootRotation()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class OffsetLimits
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACE80", Offset = "0x3ACE80")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACED8", Offset = "0x3ACED8")]
			public float spring;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACF0C", Offset = "0x3ACF0C")]
			public bool x;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACF40", Offset = "0x3ACF40")]
			public bool y;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACF74", Offset = "0x3ACF74")]
			public bool z;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACFA8", Offset = "0x3ACFA8")]
			public float minX;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACFDC", Offset = "0x3ACFDC")]
			public float maxX;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD010", Offset = "0x3AD010")]
			public float minY;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD044", Offset = "0x3AD044")]
			public float maxY;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD078", Offset = "0x3AD078")]
			public float minZ;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD0AC", Offset = "0x3AD0AC")]
			public float maxZ;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x14EA200", Offset = "0x14EA200", VA = "0x14EA200")]
			public OffsetLimits()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x14E9A68", Offset = "0x14E9A68", VA = "0x14E9A68")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x14EA208", Offset = "0x14EA208", VA = "0x14EA208")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x14EA264", Offset = "0x14EA264", VA = "0x14EA264")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A33E4", Offset = "0x3A33E4")]
		private sealed class <Initiate>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal OffsetModifier $this;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x14EA154", Offset = "0x14EA154", VA = "0x14EA154", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x14EA15C", Offset = "0x14EA15C", VA = "0x14EA15C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x14E9918", Offset = "0x14E9918", VA = "0x14E9918")]
			[DebuggerHidden]
			public <Initiate>c__Iterator0()
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x14E9F0C", Offset = "0x14E9F0C", VA = "0x14E9F0C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x14EA164", Offset = "0x14EA164", VA = "0x14EA164", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x14EA178", Offset = "0x14EA178", VA = "0x14EA178", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACDFC", Offset = "0x3ACDFC")]
		public float weight;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ACE30", Offset = "0x3ACE30")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float lastTime;

		[Token(Token = "0x170000DF")]
		protected float deltaTime
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x14D9284", Offset = "0x14D9284", VA = "0x14D9284")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x14D8FE0", Offset = "0x14D8FE0", VA = "0x14D8FE0")]
		protected OffsetModifier()
		{
		}

		[Token(Token = "0x60006D6")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x14E9870", Offset = "0x14E9870", VA = "0x14E9870", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x14E9894", Offset = "0x14E9894", VA = "0x14E9894")]
		[DebuggerHidden]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x14E9920", Offset = "0x14E9920", VA = "0x14E9920")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x14D97BC", Offset = "0x14D97BC", VA = "0x14D97BC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x14E9D64", Offset = "0x14E9D64", VA = "0x14E9D64", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A33F4", Offset = "0x3A33F4")]
		private sealed class <Initiate>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal OffsetModifierVRIK $this;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700011B")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x14EA988", Offset = "0x14EA988", VA = "0x14EA988", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600094D")]
				[Address(RVA = "0x14EA990", Offset = "0x14EA990", VA = "0x14EA990", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x14EA448", Offset = "0x14EA448", VA = "0x14EA448")]
			[DebuggerHidden]
			public <Initiate>c__Iterator0()
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x14EA740", Offset = "0x14EA740", VA = "0x14EA740", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x14EA998", Offset = "0x14EA998", VA = "0x14EA998", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x14EA9AC", Offset = "0x14EA9AC", VA = "0x14EA9AC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD0E0", Offset = "0x3AD0E0")]
		public float weight;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD114", Offset = "0x3AD114")]
		public VRIK ik;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float lastTime;

		[Token(Token = "0x170000E0")]
		protected float deltaTime
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x14EA378", Offset = "0x14EA378", VA = "0x14EA378")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x14EA368", Offset = "0x14EA368", VA = "0x14EA368")]
		protected OffsetModifierVRIK()
		{
		}

		[Token(Token = "0x60006E2")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x14EA3A0", Offset = "0x14EA3A0", VA = "0x14EA3A0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x14EA3C4", Offset = "0x14EA3C4", VA = "0x14EA3C4")]
		[DebuggerHidden]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x14EA450", Offset = "0x14EA450", VA = "0x14EA450")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x14EA598", Offset = "0x14EA598", VA = "0x14EA598", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class EffectorLink
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 offset;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 pin;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x14EB104", Offset = "0x14EB104", VA = "0x14EB104")]
			public EffectorLink()
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x14EABA0", Offset = "0x14EABA0", VA = "0x14EABA0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}
		}

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x14EAA34", Offset = "0x14EAA34", VA = "0x14EAA34")]
		public OffsetPose()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x14EAAA8", Offset = "0x14EAAA8", VA = "0x14EAAA8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x14EB040", Offset = "0x14EB040", VA = "0x14EB040")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000E5")]
			public class EffectorLink
			{
				[Token(Token = "0x40006D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD374", Offset = "0x3AD374")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD3C4", Offset = "0x3AD3C4")]
				public float weight;

				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x14EB9A4", Offset = "0x14EB9A4", VA = "0x14EB9A4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD1B4", Offset = "0x3AD1B4")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD1E8", Offset = "0x3AD1E8")]
			public Transform raycastTo;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD21C", Offset = "0x3AD21C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AD21C", Offset = "0x3AD21C")]
			public float raycastRadius;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD26C", Offset = "0x3AD26C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD2BC", Offset = "0x3AD2BC")]
			public float smoothTimeIn;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD2F0", Offset = "0x3AD2F0")]
			public float smoothTimeOut;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD324", Offset = "0x3AD324")]
			public LayerMask layers;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector3 offset;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offsetV;

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x14EB478", Offset = "0x14EB478", VA = "0x14EB478")]
			public Avoider()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x14EB1BC", Offset = "0x14EB1BC", VA = "0x14EB1BC")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x14EB498", Offset = "0x14EB498", VA = "0x14EB498")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x14EB69C", Offset = "0x14EB69C", VA = "0x14EB69C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD160", Offset = "0x3AD160")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x14EB10C", Offset = "0x14EB10C", VA = "0x14EB10C")]
		public PenetrationAvoidance()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x14EB11C", Offset = "0x14EB11C", VA = "0x14EB11C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000E8")]
			public class EffectorLink
			{
				[Token(Token = "0x40006F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD89C", Offset = "0x3AD89C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD8D0", Offset = "0x3AD8D0")]
				public float weight;

				[Token(Token = "0x6000702")]
				[Address(RVA = "0x12E7128", Offset = "0x12E7128", VA = "0x12E7128")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD730", Offset = "0x3AD730")]
			public Vector3 offset;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD79C", Offset = "0x3AD79C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AD79C", Offset = "0x3AD79C")]
			public float additivity;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD7EC", Offset = "0x3AD7EC")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD840", Offset = "0x3AD840")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x12E6CE0", Offset = "0x12E6CE0", VA = "0x12E6CE0")]
			public RecoilOffset()
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x12E6CFC", Offset = "0x12E6CFC", VA = "0x12E6CFC")]
			public void Start()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x12E6DE8", Offset = "0x12E6DE8", VA = "0x12E6DE8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public enum Handedness
		{
			[Token(Token = "0x40006FA")]
			Right,
			[Token(Token = "0x40006FB")]
			Left
		}

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD424", Offset = "0x3AD424")]
		public AimIK aimIK;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD458", Offset = "0x3AD458")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD48C", Offset = "0x3AD48C")]
		public Handedness handedness;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD4DC", Offset = "0x3AD4DC")]
		public bool twoHanded;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD524", Offset = "0x3AD524")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD558", Offset = "0x3AD558")]
		public float magnitudeRandom;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD58C", Offset = "0x3AD58C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD5F8", Offset = "0x3AD5F8")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD664", Offset = "0x3AD664")]
		public float blendTime;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x3AD6D0", Offset = "0x3AD6D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD6D0", Offset = "0x3AD6D0")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AD720", Offset = "0x3AD720")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float magnitudeMlp;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float endTime;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion handRotation;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion randomRotation;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float length;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool initiated;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float blendWeight;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float w;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool handRotationsSet;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000E1")]
		public bool isFinished
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x14EE11C", Offset = "0x14EE11C", VA = "0x14EE11C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x14EF530", Offset = "0x14EF530", VA = "0x14EF530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x14EF584", Offset = "0x14EF584", VA = "0x14EF584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x14EF4E0", Offset = "0x14EF4E0", VA = "0x14EF4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x14EF508", Offset = "0x14EF508", VA = "0x14EF508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x14EE024", Offset = "0x14EE024", VA = "0x14EE024")]
		public Recoil()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x14EE150", Offset = "0x14EE150", VA = "0x14EE150")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x14EE1A8", Offset = "0x14EE1A8", VA = "0x14EE1A8")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x14EE400", Offset = "0x14EE400", VA = "0x14EE400", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x14EF5D8", Offset = "0x14EF5D8", VA = "0x14EF5D8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x14EF768", Offset = "0x14EF768", VA = "0x14EF768")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x14EF7C4", Offset = "0x14EF7C4", VA = "0x14EF7C4", Slot = "6")]
		protected override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD904", Offset = "0x3AD904")]
		public float weight;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD94C", Offset = "0x3AD94C")]
		public float offset;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool skip;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x12EBB0C", Offset = "0x12EBB0C", VA = "0x12EBB0C")]
		public ShoulderRotator()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x12EBB28", Offset = "0x12EBB28", VA = "0x12EBB28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x12EBCA4", Offset = "0x12EBCA4", VA = "0x12EBCA4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x12EBDF8", Offset = "0x12EBDF8", VA = "0x12EBDF8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x12EC4A8", Offset = "0x12EC4A8", VA = "0x12EC4A8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x12EC514", Offset = "0x12EC514", VA = "0x12EC514")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Settings
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD980", Offset = "0x3AD980")]
			public float scaleMlp;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AD9C8", Offset = "0x3AD9C8")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADA1C", Offset = "0x3ADA1C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADA6C", Offset = "0x3ADA6C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADAA0", Offset = "0x3ADAA0")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADB08", Offset = "0x3ADB08")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADB3C", Offset = "0x3ADB3C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADB70", Offset = "0x3ADB70")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADBA4", Offset = "0x3ADBA4")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x3ADC0C", Offset = "0x3ADC0C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADC0C", Offset = "0x3ADC0C")]
			public Vector3 headOffset;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADC5C", Offset = "0x3ADC5C")]
			public Vector3 handOffset;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADC90", Offset = "0x3ADC90")]
			public float footForwardOffset;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADCF8", Offset = "0x3ADCF8")]
			public float footInwardOffset;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3ADD5C", Offset = "0x3ADD5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ADD5C", Offset = "0x3ADD5C")]
			public float footHeadingOffset;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ADDEC", Offset = "0x3ADDEC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ADE04", Offset = "0x3ADE04")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x12F43E4", Offset = "0x12F43E4", VA = "0x12F43E4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000EE")]
			public class Target
			{
				[Token(Token = "0x400071C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool used;

				[Token(Token = "0x400071D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public Vector3 localPosition;

				[Token(Token = "0x400071E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Quaternion localRotation;

				[Token(Token = "0x6000710")]
				[Address(RVA = "0x12F2BF0", Offset = "0x12F2BF0", VA = "0x12F2BF0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000711")]
				[Address(RVA = "0x12F3E20", Offset = "0x12F3E20", VA = "0x12F3E20")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float scale;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Target head;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Target leftHand;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Target rightHand;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target pelvis;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Target leftFoot;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target rightFoot;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Target leftLegGoal;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightLegGoal;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x12F1C0C", Offset = "0x12F1C0C", VA = "0x12F1C0C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x12EF87C", Offset = "0x12EF87C", VA = "0x12EF87C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x12EFAB8", Offset = "0x12EFAB8", VA = "0x12EFAB8")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x12F1D90", Offset = "0x12F1D90", VA = "0x12F1D90")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x12F2D14", Offset = "0x12F2D14", VA = "0x12F2D14")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x12F3EB0", Offset = "0x12F3EB0", VA = "0x12F3EB0")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADE1C", Offset = "0x3ADE1C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3ADE1C", Offset = "0x3ADE1C")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private VRIK ik;

		[Token(Token = "0x170000E6")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x12F2D00", Offset = "0x12F2D00", VA = "0x12F2D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A84", Offset = "0x3B0A84")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x12F4564", Offset = "0x12F4564", VA = "0x12F4564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0A94", Offset = "0x3B0A94")]
			private set
			{
			}
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x12F455C", Offset = "0x12F455C", VA = "0x12F455C")]
		public VRIKRootController()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x12F4570", Offset = "0x12F4570", VA = "0x12F4570")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x12F28F4", Offset = "0x12F28F4", VA = "0x12F28F4")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x12F41BC", Offset = "0x12F41BC", VA = "0x12F41BC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x12F46F4", Offset = "0x12F46F4", VA = "0x12F46F4")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x12F4E60", Offset = "0x12F4E60", VA = "0x12F4E60")]
		private void OnDestroy()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x20000F0")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		public enum UpdateMode
		{
			[Token(Token = "0x400074A")]
			Update,
			[Token(Token = "0x400074B")]
			FixedUpdate,
			[Token(Token = "0x400074C")]
			LateUpdate,
			[Token(Token = "0x400074D")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rotationSpace;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool lockCursor;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ADE50", Offset = "0x3ADE50")]
		public bool smoothFollow;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float followSpeed;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ADE84", Offset = "0x3ADE84")]
		public float rotationSensitivity;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMinLimit;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float yMaxLimit;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool rotateAlways;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ADEB8", Offset = "0x3ADEB8")]
		public float distance;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float minDistance;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxDistance;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float zoomSpeed;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float zoomSensitivity;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3ADEF0", Offset = "0x3ADEF0")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float blockingRadius;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float blockingSmoothTime;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3ADF28", Offset = "0x3ADF28")]
		public float blockedOffset;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADF40", Offset = "0x3ADF40")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3ADF40", Offset = "0x3ADF40")]
		private float <x>k__BackingField;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADF74", Offset = "0x3ADF74")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3ADF74", Offset = "0x3ADF74")]
		private float <y>k__BackingField;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADFA8", Offset = "0x3ADFA8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3ADFA8", Offset = "0x3ADFA8")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 targetDistance;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 position;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion rotation;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera cam;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool fixedFrame;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion r;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 lastUp;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blockedDistance;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float blockedDistanceV;

		[Token(Token = "0x170000E7")]
		public float x
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x11B4820", Offset = "0x11B4820", VA = "0x11B4820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0AA4", Offset = "0x3B0AA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x11B4828", Offset = "0x11B4828", VA = "0x11B4828")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0AB4", Offset = "0x3B0AB4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public float y
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x11B4830", Offset = "0x11B4830", VA = "0x11B4830")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0AC4", Offset = "0x3B0AC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x11B4838", Offset = "0x11B4838", VA = "0x11B4838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0AD4", Offset = "0x3B0AD4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public float distanceTarget
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x11B4840", Offset = "0x11B4840", VA = "0x11B4840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0AE4", Offset = "0x3B0AE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x11B4848", Offset = "0x11B4848", VA = "0x11B4848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0AF4", Offset = "0x3B0AF4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		private float zoomAdd
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x11B55F4", Offset = "0x11B55F4", VA = "0x11B55F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x11B46A0", Offset = "0x11B46A0", VA = "0x11B46A0")]
		public CameraController()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x11B4850", Offset = "0x11B4850", VA = "0x11B4850", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x11B4A00", Offset = "0x11B4A00", VA = "0x11B4A00", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x11B4A54", Offset = "0x11B4A54", VA = "0x11B4A54", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x11B4AB0", Offset = "0x11B4AB0", VA = "0x11B4AB0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x11B4B14", Offset = "0x11B4B14", VA = "0x11B4B14")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x11B4A30", Offset = "0x11B4A30", VA = "0x11B4A30")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x11B4D00", Offset = "0x11B4D00", VA = "0x11B4D00")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x11B5528", Offset = "0x11B5528", VA = "0x11B5528")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000F2")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationSensitivity;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float yMinLimit;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float yMaxLimit;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float x;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float y;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x11B5684", Offset = "0x11B5684", VA = "0x11B5684")]
		public CameraControllerFPS()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x11B56B0", Offset = "0x11B56B0", VA = "0x11B56B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x11B5700", Offset = "0x11B5700", VA = "0x11B5700")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x11B58F4", Offset = "0x11B58F4", VA = "0x11B58F4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000F3")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool smoothFollow;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected bool animatePhysics;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 localPosition;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion localRotation;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000EB")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x11B9078", Offset = "0x11B9078", VA = "0x11B9078", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x11B901C", Offset = "0x11B901C", VA = "0x11B901C")]
		protected CharacterAnimationBase()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x11B9038", Offset = "0x11B9038", VA = "0x11B9038", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x11B9080", Offset = "0x11B9080", VA = "0x11B9080")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x11B9178", Offset = "0x11B9178", VA = "0x11B9178", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x11B94FC", Offset = "0x11B94FC", VA = "0x11B94FC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x11B9870", Offset = "0x11B9870", VA = "0x11B9870", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x11B950C", Offset = "0x11B950C", VA = "0x11B950C")]
		private void SmoothFollow()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A2FC0", Offset = "0x3A2FC0")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Animator animator;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x11B9880", Offset = "0x11B9880", VA = "0x11B9880")]
		public CharacterAnimationSimple()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x11B989C", Offset = "0x11B989C", VA = "0x11B989C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x11B990C", Offset = "0x11B990C", VA = "0x11B990C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x11B9A64", Offset = "0x11B9A64", VA = "0x11B9A64")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A3038", Offset = "0x3A3038")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3AE03C", Offset = "0x3AE03C")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Animator animator;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 lastForward;

		[Token(Token = "0x4000765")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000766")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float deltaAngle;

		[Token(Token = "0x170000EC")]
		public override bool animationGrounded
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x11B9DA0", Offset = "0x11B9DA0", VA = "0x11B9DA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x11B9C78", Offset = "0x11B9C78", VA = "0x11B9C78")]
		public CharacterAnimationThirdPerson()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x11B9CB8", Offset = "0x11B9CB8", VA = "0x11B9CB8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x11B9D6C", Offset = "0x11B9D6C", VA = "0x11B9D6C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x11B9EEC", Offset = "0x11B9EEC", VA = "0x11B9EEC", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x11BA54C", Offset = "0x11BA54C", VA = "0x11BA54C")]
		private void OnAnimatorMove()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A30B0", Offset = "0x3A30B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A30B0", Offset = "0x3A30B0")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE07C", Offset = "0x3AE07C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE07C", Offset = "0x3AE07C")]
		public Transform gravityTarget;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE0E4", Offset = "0x3AE0E4")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Rigidbody r;

		[Token(Token = "0x4000772")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float originalHeight;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x11BAD68", Offset = "0x11BAD68", VA = "0x11BAD68")]
		protected CharacterBase()
		{
		}

		[Token(Token = "0x6000741")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x11BADA0", Offset = "0x11BADA0", VA = "0x11BADA0")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x11BAF68", Offset = "0x11BAF68", VA = "0x11BAF68", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x11BB1AC", Offset = "0x11BB1AC", VA = "0x11BB1AC", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x11BB514", Offset = "0x11BB514", VA = "0x11BB514")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x11BB60C", Offset = "0x11BB60C", VA = "0x11BB60C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x11BB880", Offset = "0x11BB880", VA = "0x11BB880")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x11BBAA4", Offset = "0x11BBAA4", VA = "0x11BBAA4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x11BBAD8", Offset = "0x11BBAD8", VA = "0x11BBAD8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x11BBB0C", Offset = "0x11BBB0C", VA = "0x11BBB0C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000F7")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public enum MoveMode
		{
			[Token(Token = "0x40007AE")]
			Directional,
			[Token(Token = "0x40007AF")]
			Strafe
		}

		[Token(Token = "0x20000F9")]
		public struct AnimState
		{
			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE17C", Offset = "0x3AE17C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CameraController cam;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE1B0", Offset = "0x3AE1B0")]
		public MoveMode moveMode;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool smoothPhysics;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float platformFriction;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float groundStickyEffect;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE1E8", Offset = "0x3AE1E8")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float turnSpeed;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE21C", Offset = "0x3AE21C")]
		public float airSpeed;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float airControl;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jumpPower;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE25C", Offset = "0x3AE25C")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float wallRunMaxLength;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3AE2AC", Offset = "0x3AE2AC")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE2E4", Offset = "0x3AE2E4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE2E4", Offset = "0x3AE2E4")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public AnimState animState;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Animator animator;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 normal;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RaycastHit hit;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float jumpLeg;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float jumpEndTime;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float forwardMlp;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float groundDistance;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float lastAirTime;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float stickyForce;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float wallRunWeight;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool fixedFrame;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float wallRunEndTime;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 gravity;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private float velocityY;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool doubleJumped;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
		private bool jumpReleased;

		[Token(Token = "0x170000ED")]
		public bool onGround
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xD823C4", Offset = "0xD823C4", VA = "0xD823C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0B04", Offset = "0x3B0B04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xD823CC", Offset = "0xD823CC", VA = "0xD823CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0B14", Offset = "0x3B0B14")]
			private set
			{
			}
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xD82210", Offset = "0xD82210", VA = "0xD82210")]
		public CharacterThirdPerson()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xD823D4", Offset = "0xD823D4", VA = "0xD823D4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xD825A4", Offset = "0xD825A4", VA = "0xD825A4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xD82638", Offset = "0xD82638", VA = "0xD82638", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD82784", Offset = "0xD82784", VA = "0xD82784")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD83C5C", Offset = "0xD83C5C", VA = "0xD83C5C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD840F0", Offset = "0xD840F0", VA = "0xD840F0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD83054", Offset = "0xD83054", VA = "0xD83054")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD84244", Offset = "0xD84244", VA = "0xD84244")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xD84A5C", Offset = "0xD84A5C", VA = "0xD84A5C")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xD83D68", Offset = "0xD83D68", VA = "0xD83D68")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xD84B20", Offset = "0xD84B20", VA = "0xD84B20", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xD850F4", Offset = "0xD850F4", VA = "0xD850F4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD854E4", Offset = "0xD854E4", VA = "0xD854E4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xD836EC", Offset = "0xD836EC", VA = "0xD836EC")]
		private void GroundCheck()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A3154", Offset = "0x3A3154")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public enum RotationMode
		{
			[Token(Token = "0x40007C5")]
			Smooth,
			[Token(Token = "0x40007C6")]
			Linear
		}

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE318", Offset = "0x3AE318")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE380", Offset = "0x3AE380")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE3DC", Offset = "0x3AE3DC")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE42C", Offset = "0x3AE42C")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE474", Offset = "0x3AE474")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE4D0", Offset = "0x3AE4D0")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE544", Offset = "0x3AE544")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE544", Offset = "0x3AE544")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float speed;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float angleVel;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float speedVel;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private CharacterController characterController;

		[Token(Token = "0x170000EE")]
		public bool isGrounded
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0xD86B38", Offset = "0xD86B38", VA = "0xD86B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0B24", Offset = "0x3B0B24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0xD9680C", Offset = "0xD9680C", VA = "0xD9680C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0B34", Offset = "0x3B0B34")]
			private set
			{
			}
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xD967E0", Offset = "0xD967E0", VA = "0xD967E0")]
		public SimpleLocomotion()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xD96814", Offset = "0xD96814", VA = "0xD96814")]
		private void Start()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD968BC", Offset = "0xD968BC", VA = "0xD968BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD971E0", Offset = "0xD971E0", VA = "0xD971E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xD96930", Offset = "0xD96930", VA = "0xD96930")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xD96E6C", Offset = "0xD96E6C", VA = "0xD96E6C")]
		private void Move()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xD97230", Offset = "0xD97230", VA = "0xD97230")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xD97360", Offset = "0xD97360", VA = "0xD97360")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000FC")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform moveTarget;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float stoppingDistance;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stoppingThreshold;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Navigator navigator;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xD9A958", Offset = "0xD9A958", VA = "0xD9A958")]
		public UserControlAI()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xD9A9B0", Offset = "0xD9A9B0", VA = "0xD9A9B0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD9AA30", Offset = "0xD9AA30", VA = "0xD9AA30", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xD9ADE4", Offset = "0xD9ADE4", VA = "0xD9ADE4")]
		private void OnDrawGizmos()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000FE")]
		public struct State
		{
			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool walkByDefault;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool canCrouch;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool canJump;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public State state;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform cam;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xD9A98C", Offset = "0xD9A98C", VA = "0xD9A98C")]
		public UserControlThirdPerson()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xD9A9F4", Offset = "0xD9A9F4", VA = "0xD9A9F4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xD9AFFC", Offset = "0xD9AFFC", VA = "0xD9AFFC", Slot = "5")]
		protected virtual void Update()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x11B84B0", Offset = "0x11B84B0", VA = "0x11B84B0")]
		public ApplicationQuit()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x11B84B8", Offset = "0x11B84B8", VA = "0x11B84B8")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xD97410", Offset = "0xD97410", VA = "0xD97410")]
		public SlowMo()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xD97424", Offset = "0xD97424", VA = "0xD97424")]
		private void Update()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xD97450", Offset = "0xD97450", VA = "0xD97450")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000101")]
	public enum Axis
	{
		[Token(Token = "0x40007DA")]
		X,
		[Token(Token = "0x40007DB")]
		Y,
		[Token(Token = "0x40007DC")]
		Z
	}
	[Token(Token = "0x2000102")]
	public class AxisTools
	{
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x11A97B4", Offset = "0x11A97B4", VA = "0x11A97B4")]
		public AxisTools()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x11A97BC", Offset = "0x11A97BC", VA = "0x11A97BC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x11A98BC", Offset = "0x11A98BC", VA = "0x11A98BC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x11A9998", Offset = "0x11A9998", VA = "0x11A9998")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x11A9BE4", Offset = "0x11A9BE4", VA = "0x11A9BE4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x11A9AF4", Offset = "0x11A9AF4", VA = "0x11A9AF4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x11A9D40", Offset = "0x11A9D40", VA = "0x11A9D40")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000103")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class LimbOrientation
		{
			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x11AA320", Offset = "0x11AA320", VA = "0x11AA320")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x170000EF")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x11AA0CC", Offset = "0x11AA0CC", VA = "0x11AA0CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x11AA378", Offset = "0x11AA378", VA = "0x11AA378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x11AA094", Offset = "0x11AA094", VA = "0x11AA094")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public enum BoneType
		{
			[Token(Token = "0x40007F7")]
			Unassigned,
			[Token(Token = "0x40007F8")]
			Spine,
			[Token(Token = "0x40007F9")]
			Head,
			[Token(Token = "0x40007FA")]
			Arm,
			[Token(Token = "0x40007FB")]
			Leg,
			[Token(Token = "0x40007FC")]
			Tail,
			[Token(Token = "0x40007FD")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000107")]
		public enum BoneSide
		{
			[Token(Token = "0x40007FF")]
			Center,
			[Token(Token = "0x4000800")]
			Left,
			[Token(Token = "0x4000801")]
			Right
		}

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string[] typeRight;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeSpine;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string[] typeHead;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeArm;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string[] typeLeg;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeTail;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static string[] typeEye;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeExclude;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static string[] pelvis;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] hand;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static string[] foot;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x11AA5CC", Offset = "0x11AA5CC", VA = "0x11AA5CC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x11AA9CC", Offset = "0x11AA9CC", VA = "0x11AA9CC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x11AACB8", Offset = "0x11AACB8", VA = "0x11AACB8")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x11AAD50", Offset = "0x11AAD50", VA = "0x11AAD50")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x11AAE04", Offset = "0x11AAE04", VA = "0x11AAE04")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x11AA7F0", Offset = "0x11AA7F0", VA = "0x11AA7F0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x11AABF0", Offset = "0x11AABF0", VA = "0x11AABF0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x11AB9B4", Offset = "0x11AB9B4", VA = "0x11AB9B4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x11AB654", Offset = "0x11AB654", VA = "0x11AB654")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x11AB804", Offset = "0x11AB804", VA = "0x11AB804")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x11AB084", Offset = "0x11AB084", VA = "0x11AB084")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x11AB17C", Offset = "0x11AB17C", VA = "0x11AB17C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x11AB274", Offset = "0x11AB274", VA = "0x11AB274")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x11AB36C", Offset = "0x11AB36C", VA = "0x11AB36C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x11AB464", Offset = "0x11AB464", VA = "0x11AB464")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x11AB55C", Offset = "0x11AB55C", VA = "0x11AB55C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x11ABCC0", Offset = "0x11ABCC0", VA = "0x11ABCC0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x11AAF60", Offset = "0x11AAF60", VA = "0x11AAF60")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x11ABC34", Offset = "0x11ABC34", VA = "0x11ABC34")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x11ABD58", Offset = "0x11ABD58", VA = "0x11ABD58")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x11ABE38", Offset = "0x11ABE38", VA = "0x11ABE38")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x11ABB58", Offset = "0x11ABB58", VA = "0x11ABB58")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x11ABA50", Offset = "0x11ABA50", VA = "0x11ABA50")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000108")]
	public class BipedReferences
	{
		[Token(Token = "0x2000109")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000F3")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0x11B4698", Offset = "0x11B4698", VA = "0x11B4698")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x480958", Offset = "0x480958", VA = "0x480958")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform root;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform pelvis;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform leftThigh;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftCalf;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftFoot;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform rightThigh;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightCalf;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Transform rightFoot;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperArm;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Transform leftForearm;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHand;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform rightUpperArm;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightForearm;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform rightHand;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform head;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Transform[] spine;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] eyes;

		[Token(Token = "0x170000F1")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x11AF804", Offset = "0x11AF804", VA = "0x11AF804", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F2")]
		public bool isEmpty
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x11AFDB0", Offset = "0x11AFDB0", VA = "0x11AFDB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x11AF780", Offset = "0x11AF780", VA = "0x11AF780")]
		public BipedReferences()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x11AFDC4", Offset = "0x11AFDC4", VA = "0x11AFDC4", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x11B03C8", Offset = "0x11B03C8", VA = "0x11B03C8", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x11B099C", Offset = "0x11B099C", VA = "0x11B099C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x11B12D4", Offset = "0x11B12D4", VA = "0x11B12D4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x11B0C34", Offset = "0x11B0C34", VA = "0x11B0C34")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x11B2040", Offset = "0x11B2040", VA = "0x11B2040")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x11B2164", Offset = "0x11B2164", VA = "0x11B2164")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x11B287C", Offset = "0x11B287C", VA = "0x11B287C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x11B25F4", Offset = "0x11B25F4", VA = "0x11B25F4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x11B23C0", Offset = "0x11B23C0", VA = "0x11B23C0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x11B224C", Offset = "0x11B224C", VA = "0x11B224C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x11B2740", Offset = "0x11B2740", VA = "0x11B2740")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x11B29B0", Offset = "0x11B29B0", VA = "0x11B29B0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x11B3C04", Offset = "0x11B3C04", VA = "0x11B3C04")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x11B330C", Offset = "0x11B330C", VA = "0x11B330C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x11B4064", Offset = "0x11B4064", VA = "0x11B4064")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x11B38E8", Offset = "0x11B38E8", VA = "0x11B38E8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x11B406C", Offset = "0x11B406C", VA = "0x11B406C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x11B4074", Offset = "0x11B4074", VA = "0x11B4074")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x11B429C", Offset = "0x11B429C", VA = "0x11B429C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x11B4544", Offset = "0x11B4544", VA = "0x11B4544")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200010A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x3AE5B8", Offset = "0x3AE5B8")]
		public string text;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x11B59C0", Offset = "0x11B59C0", VA = "0x11B59C0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string text;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x11B59C8", Offset = "0x11B59C8", VA = "0x11B59C8")]
		public DemoGUIMessage()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x11B5A0C", Offset = "0x11B5A0C", VA = "0x11B5A0C")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class Hierarchy
	{
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x12F5008", Offset = "0x12F5008", VA = "0x12F5008")]
		public Hierarchy()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x12F5010", Offset = "0x12F5010", VA = "0x12F5010")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x12F529C", Offset = "0x12F529C", VA = "0x12F529C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x12F50A8", Offset = "0x12F50A8", VA = "0x12F50A8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x12F53FC", Offset = "0x12F53FC", VA = "0x12F53FC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x12F555C", Offset = "0x12F555C", VA = "0x12F555C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x12F58D8", Offset = "0x12F58D8", VA = "0x12F58D8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x12F5A58", Offset = "0x12F5A58", VA = "0x12F5A58")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x12F5C84", Offset = "0x12F5C84", VA = "0x12F5C84")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x12F6144", Offset = "0x12F6144", VA = "0x12F6144")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x12F5E6C", Offset = "0x12F5E6C", VA = "0x12F5E6C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010D")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string color;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x12F6368", Offset = "0x12F6368", VA = "0x12F6368")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x12F63E4", Offset = "0x12F63E4", VA = "0x12F63E4")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010E")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400081B")]
		None,
		[Token(Token = "0x400081C")]
		InOutCubic,
		[Token(Token = "0x400081D")]
		InOutQuintic,
		[Token(Token = "0x400081E")]
		InOutSine,
		[Token(Token = "0x400081F")]
		InQuintic,
		[Token(Token = "0x4000820")]
		InQuartic,
		[Token(Token = "0x4000821")]
		InCubic,
		[Token(Token = "0x4000822")]
		InQuadratic,
		[Token(Token = "0x4000823")]
		InElastic,
		[Token(Token = "0x4000824")]
		InElasticSmall,
		[Token(Token = "0x4000825")]
		InElasticBig,
		[Token(Token = "0x4000826")]
		InSine,
		[Token(Token = "0x4000827")]
		InBack,
		[Token(Token = "0x4000828")]
		OutQuintic,
		[Token(Token = "0x4000829")]
		OutQuartic,
		[Token(Token = "0x400082A")]
		OutCubic,
		[Token(Token = "0x400082B")]
		OutInCubic,
		[Token(Token = "0x400082C")]
		OutInQuartic,
		[Token(Token = "0x400082D")]
		OutElastic,
		[Token(Token = "0x400082E")]
		OutElasticSmall,
		[Token(Token = "0x400082F")]
		OutElasticBig,
		[Token(Token = "0x4000830")]
		OutSine,
		[Token(Token = "0x4000831")]
		OutBack,
		[Token(Token = "0x4000832")]
		OutBackCubic,
		[Token(Token = "0x4000833")]
		OutBackQuartic,
		[Token(Token = "0x4000834")]
		BackInCubic,
		[Token(Token = "0x4000835")]
		BackInQuartic
	}
	[Token(Token = "0x200010F")]
	public class Interp
	{
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x12F6460", Offset = "0x12F6460", VA = "0x12F6460")]
		public Interp()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x12F6468", Offset = "0x12F6468", VA = "0x12F6468")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x12F710C", Offset = "0x12F710C", VA = "0x12F710C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x12F722C", Offset = "0x12F722C", VA = "0x12F722C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x12F682C", Offset = "0x12F682C", VA = "0x12F682C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x12F6848", Offset = "0x12F6848", VA = "0x12F6848")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x12F6880", Offset = "0x12F6880", VA = "0x12F6880")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x12F68CC", Offset = "0x12F68CC", VA = "0x12F68CC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x12F68F4", Offset = "0x12F68F4", VA = "0x12F68F4")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x12F6918", Offset = "0x12F6918", VA = "0x12F6918")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x12F693C", Offset = "0x12F693C", VA = "0x12F693C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x12F695C", Offset = "0x12F695C", VA = "0x12F695C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x12F69B4", Offset = "0x12F69B4", VA = "0x12F69B4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x12F69FC", Offset = "0x12F69FC", VA = "0x12F69FC")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x12F6A34", Offset = "0x12F6A34", VA = "0x12F6A34")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x12F734C", Offset = "0x12F734C", VA = "0x12F734C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x12F6A78", Offset = "0x12F6A78", VA = "0x12F6A78")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x12F6AB0", Offset = "0x12F6AB0", VA = "0x12F6AB0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x12F6AF0", Offset = "0x12F6AF0", VA = "0x12F6AF0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x12F6B34", Offset = "0x12F6B34", VA = "0x12F6B34")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x12F6B88", Offset = "0x12F6B88", VA = "0x12F6B88")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x12F6BFC", Offset = "0x12F6BFC", VA = "0x12F6BFC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x12F6C70", Offset = "0x12F6C70", VA = "0x12F6C70")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x12F6CD4", Offset = "0x12F6CD4", VA = "0x12F6CD4")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x12F6D38", Offset = "0x12F6D38", VA = "0x12F6D38")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x12F6DF0", Offset = "0x12F6DF0", VA = "0x12F6DF0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x12F6EA4", Offset = "0x12F6EA4", VA = "0x12F6EA4")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x12F7390", Offset = "0x12F7390", VA = "0x12F7390")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x12F6F68", Offset = "0x12F6F68", VA = "0x12F6F68")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x12F707C", Offset = "0x12F707C", VA = "0x12F707C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x12F70BC", Offset = "0x12F70BC", VA = "0x12F70BC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000110")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string color;

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x12F74A8", Offset = "0x12F74A8", VA = "0x12F74A8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x12F7524", Offset = "0x12F7524", VA = "0x12F7524")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x12F75A0", Offset = "0x12F75A0", VA = "0x12F75A0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x12F75E8", Offset = "0x12F75E8", VA = "0x12F75E8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x12F768C", Offset = "0x12F768C", VA = "0x12F768C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x12F75EC", Offset = "0x12F75EC", VA = "0x12F75EC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x12F7690", Offset = "0x12F7690", VA = "0x12F7690")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x12F7720", Offset = "0x12F7720", VA = "0x12F7720")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x12F7740", Offset = "0x12F7740", VA = "0x12F7740")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x12F7778", Offset = "0x12F7778", VA = "0x12F7778")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x12F77C8", Offset = "0x12F77C8", VA = "0x12F77C8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x12F7918", Offset = "0x12F7918", VA = "0x12F7918")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x12F7A10", Offset = "0x12F7A10", VA = "0x12F7A10")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x12F7A74", Offset = "0x12F7A74", VA = "0x12F7A74")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x2000112")]
	public class Navigator
	{
		[Token(Token = "0x2000113")]
		public enum State
		{
			[Token(Token = "0x4000847")]
			Idle,
			[Token(Token = "0x4000848")]
			Seeking,
			[Token(Token = "0x4000849")]
			OnPath
		}

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE5C8", Offset = "0x3AE5C8")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE628", Offset = "0x3AE628")]
		public float cornerRadius;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE65C", Offset = "0x3AE65C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE690", Offset = "0x3AE690")]
		public float maxSampleDistance;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE6F0", Offset = "0x3AE6F0")]
		public float nextPathInterval;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE73C", Offset = "0x3AE73C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE73C", Offset = "0x3AE73C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE770", Offset = "0x3AE770")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE770", Offset = "0x3AE770")]
		private State <state>k__BackingField;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform transform;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cornerIndex;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3[] corners;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NavMeshPath path;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool initiated;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float nextPathTime;

		[Token(Token = "0x170000F4")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0xD90DB8", Offset = "0xD90DB8", VA = "0xD90DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0BB4", Offset = "0x3B0BB4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xD90DCC", Offset = "0xD90DCC", VA = "0xD90DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0BC4", Offset = "0x3B0BC4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public State state
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xD90DD8", Offset = "0xD90DD8", VA = "0xD90DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0BD4", Offset = "0x3B0BD4")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0xD90DE0", Offset = "0xD90DE0", VA = "0xD90DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0BE4", Offset = "0x3B0BE4")]
			private set
			{
			}
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD90D20", Offset = "0xD90D20", VA = "0xD90D20")]
		public Navigator()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xD90DE8", Offset = "0xD90DE8", VA = "0xD90DE8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD90ED0", Offset = "0xD90ED0", VA = "0xD90ED0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD915EC", Offset = "0xD915EC", VA = "0xD915EC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD91654", Offset = "0xD91654", VA = "0xD91654")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD9146C", Offset = "0xD9146C", VA = "0xD9146C")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD9150C", Offset = "0xD9150C", VA = "0xD9150C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD917F0", Offset = "0xD917F0", VA = "0xD917F0")]
		public void Visualize()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000114")]
	public static class QuaTools
	{
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x12F7B0C", Offset = "0x12F7B0C", VA = "0x12F7B0C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x12F7C3C", Offset = "0x12F7C3C", VA = "0x12F7C3C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x12F7D6C", Offset = "0x12F7D6C", VA = "0x12F7D6C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x12F7EB0", Offset = "0x12F7EB0", VA = "0x12F7EB0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x12F7FF4", Offset = "0x12F7FF4", VA = "0x12F7FF4")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x12F81DC", Offset = "0x12F81DC", VA = "0x12F81DC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x12F82DC", Offset = "0x12F82DC", VA = "0x12F82DC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x12F844C", Offset = "0x12F844C", VA = "0x12F844C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x12F879C", Offset = "0x12F879C", VA = "0x12F879C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x12F8A2C", Offset = "0x12F8A2C", VA = "0x12F8A2C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x12F1C14", Offset = "0x12F1C14", VA = "0x12F1C14")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000115")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x170000F6")]
		public static T instance
		{
			[Token(Token = "0x6000804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000803")]
		protected Singleton()
		{
		}

		[Token(Token = "0x6000805")]
		protected virtual void Awake()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3AE7A4", Offset = "0x3AE7A4")]
		public bool fixTransforms;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Animator animator;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animation legacy;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool updateFrame;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool componentInitiated;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool skipSolverUpdate;

		[Token(Token = "0x170000F7")]
		private bool animatePhysics
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x12F8D34", Offset = "0x12F8D34", VA = "0x12F8D34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F8")]
		private bool isAnimated
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x12F914C", Offset = "0x12F914C", VA = "0x12F914C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x12F8BE4", Offset = "0x12F8BE4", VA = "0x12F8BE4")]
		public SolverManager()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x12F8BF4", Offset = "0x12F8BF4", VA = "0x12F8BF4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x12F8CA8", Offset = "0x12F8CA8", VA = "0x12F8CA8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x12F8CAC", Offset = "0x12F8CAC", VA = "0x12F8CAC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x12F8CB0", Offset = "0x12F8CB0", VA = "0x12F8CB0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x12F8CB4", Offset = "0x12F8CB4", VA = "0x12F8CB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x12F8D30", Offset = "0x12F8D30", VA = "0x12F8D30")]
		private void Start()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x12F8CDC", Offset = "0x12F8CDC", VA = "0x12F8CDC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x12F90FC", Offset = "0x12F90FC", VA = "0x12F90FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x12F8E6C", Offset = "0x12F8E6C", VA = "0x12F8E6C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x12F9224", Offset = "0x12F9224", VA = "0x12F9224")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x12F9280", Offset = "0x12F9280", VA = "0x12F9280")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x12F92E0", Offset = "0x12F92E0", VA = "0x12F92E0")]
		public void UpdateSolverExternal()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject target;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x12F931C", Offset = "0x12F931C", VA = "0x12F931C")]
		public TriggerEventBroadcaster()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x12F9324", Offset = "0x12F9324", VA = "0x12F9324")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x12F9400", Offset = "0x12F9400", VA = "0x12F9400")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x12F94DC", Offset = "0x12F94DC", VA = "0x12F94DC")]
		private void OnTriggerExit(Collider collider)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public static class V3Tools
	{
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x12F95B8", Offset = "0x12F95B8", VA = "0x12F95B8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x12F96CC", Offset = "0x12F96CC", VA = "0x12F96CC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x12F97E0", Offset = "0x12F97E0", VA = "0x12F97E0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x12F990C", Offset = "0x12F990C", VA = "0x12F990C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x12F9A6C", Offset = "0x12F9A6C", VA = "0x12F9A6C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x12F9D24", Offset = "0x12F9D24", VA = "0x12F9D24")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x12F9FD0", Offset = "0x12F9FD0", VA = "0x12F9FD0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x12FA1E8", Offset = "0x12FA1E8", VA = "0x12FA1E8")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000119")]
	public static class Warning
	{
		[Token(Token = "0x200011A")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x12FA404", Offset = "0x12FA404", VA = "0x12FA404")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x12E778C", Offset = "0x12E778C", VA = "0x12E778C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200011B")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string axisName;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float axisValue;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float responseSpeed;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x12FA8CC", Offset = "0x12FA8CC", VA = "0x12FA8CC")]
		public AxisTouchButton()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x12FA94C", Offset = "0x12FA94C", VA = "0x12FA94C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x12FACB0", Offset = "0x12FACB0", VA = "0x12FACB0")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x12FAED4", Offset = "0x12FAED4", VA = "0x12FAED4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x12FAF80", Offset = "0x12FAF80", VA = "0x12FAF80", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x12FB0A8", Offset = "0x12FB0A8", VA = "0x12FB0A8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Name;

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x12FB170", Offset = "0x12FB170", VA = "0x12FB170")]
		public ButtonHandler()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x12FB178", Offset = "0x12FB178", VA = "0x12FB178")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x12FB17C", Offset = "0x12FB17C", VA = "0x12FB17C")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x12FB2B8", Offset = "0x12FB2B8", VA = "0x12FB2B8")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x12FB3F4", Offset = "0x12FB3F4", VA = "0x12FB3F4")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x12FB530", Offset = "0x12FB530", VA = "0x12FB530")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x12FB66C", Offset = "0x12FB66C", VA = "0x12FB66C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x12FB7A8", Offset = "0x12FB7A8", VA = "0x12FB7A8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200011E")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400085E")]
			Hardware,
			[Token(Token = "0x400085F")]
			Touch
		}

		[Token(Token = "0x200011F")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE7D8", Offset = "0x3AE7D8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE7D8", Offset = "0x3AE7D8")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private float m_Value;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE80C", Offset = "0x3AE80C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE80C", Offset = "0x3AE80C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x170000FA")]
			public string name
			{
				[Token(Token = "0x6000851")]
				[Address(RVA = "0x12FCC20", Offset = "0x12FCC20", VA = "0x12FCC20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0BF4", Offset = "0x3B0BF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000852")]
				[Address(RVA = "0x12FCC10", Offset = "0x12FCC10", VA = "0x12FCC10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C04", Offset = "0x3B0C04")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000853")]
				[Address(RVA = "0x12FCC28", Offset = "0x12FCC28", VA = "0x12FCC28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C14", Offset = "0x3B0C14")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000854")]
				[Address(RVA = "0x12FCC18", Offset = "0x12FCC18", VA = "0x12FCC18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C24", Offset = "0x3B0C24")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			public float GetValue
			{
				[Token(Token = "0x6000857")]
				[Address(RVA = "0x12FB098", Offset = "0x12FB098", VA = "0x12FB098")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000FD")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000858")]
				[Address(RVA = "0x12FCC30", Offset = "0x12FCC30", VA = "0x12FCC30")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x12FAB30", Offset = "0x12FAB30", VA = "0x12FAB30")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x12FCBE8", Offset = "0x12FCBE8", VA = "0x12FCBE8")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x12FAEFC", Offset = "0x12FAEFC", VA = "0x12FAEFC")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x12FB0A0", Offset = "0x12FB0A0", VA = "0x12FB0A0")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000120")]
		public class VirtualButton
		{
			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE840", Offset = "0x3AE840")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE840", Offset = "0x3AE840")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE874", Offset = "0x3AE874")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE874", Offset = "0x3AE874")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_Pressed;

			[Token(Token = "0x170000FE")]
			public string name
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0x12FCCB8", Offset = "0x12FCCB8", VA = "0x12FCCB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C34", Offset = "0x3B0C34")]
				get
				{
					return null;
				}
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x12FCCA8", Offset = "0x12FCCA8", VA = "0x12FCCA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C44", Offset = "0x3B0C44")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600085D")]
				[Address(RVA = "0x12FCCC0", Offset = "0x12FCCC0", VA = "0x12FCCC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C54", Offset = "0x3B0C54")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600085E")]
				[Address(RVA = "0x12FCCB0", Offset = "0x12FCCB0", VA = "0x12FCCB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C64", Offset = "0x3B0C64")]
				private set
				{
				}
			}

			[Token(Token = "0x17000100")]
			public bool GetButton
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x12FCDA0", Offset = "0x12FCDA0", VA = "0x12FCDA0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000101")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000863")]
				[Address(RVA = "0x12FCDA8", Offset = "0x12FCDA8", VA = "0x12FCDA8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000102")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0x12FCDD4", Offset = "0x12FCDD4", VA = "0x12FCDD4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x12FCC38", Offset = "0x12FCC38", VA = "0x12FCC38")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x12FCC70", Offset = "0x12FCC70", VA = "0x12FCC70")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x12FCCC8", Offset = "0x12FCCC8", VA = "0x12FCCC8")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x12FCCF8", Offset = "0x12FCCF8", VA = "0x12FCCF8")]
			public void Released()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x12FCD1C", Offset = "0x12FCD1C", VA = "0x12FCD1C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x170000F9")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x12FC7A4", Offset = "0x12FC7A4", VA = "0x12FC7A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x12FB7AC", Offset = "0x12FB7AC", VA = "0x12FB7AC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x12FB864", Offset = "0x12FB864", VA = "0x12FB864")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x12FAA84", Offset = "0x12FAA84", VA = "0x12FAA84")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x12FB9D4", Offset = "0x12FB9D4", VA = "0x12FB9D4")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x12FAB58", Offset = "0x12FAB58", VA = "0x12FAB58")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x12FBCB0", Offset = "0x12FBCB0", VA = "0x12FBCB0")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x12FBF0C", Offset = "0x12FBF0C", VA = "0x12FBF0C")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x12FC0D0", Offset = "0x12FC0D0", VA = "0x12FC0D0")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x12FAC04", Offset = "0x12FAC04", VA = "0x12FAC04")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x12FC2F4", Offset = "0x12FC2F4", VA = "0x12FC2F4")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x12FC438", Offset = "0x12FC438", VA = "0x12FC438")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x12FC378", Offset = "0x12FC378", VA = "0x12FC378")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x12FC4BC", Offset = "0x12FC4BC", VA = "0x12FC4BC")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x12FC574", Offset = "0x12FC574", VA = "0x12FC574")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x12FC62C", Offset = "0x12FC62C", VA = "0x12FC62C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x12FB200", Offset = "0x12FB200", VA = "0x12FB200")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x12FB33C", Offset = "0x12FB33C", VA = "0x12FB33C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x12FB478", Offset = "0x12FB478", VA = "0x12FB478")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x12FB6F0", Offset = "0x12FB6F0", VA = "0x12FB6F0")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x12FB5B4", Offset = "0x12FB5B4", VA = "0x12FB5B4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x12FC6E4", Offset = "0x12FC6E4", VA = "0x12FC6E4")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x12FC85C", Offset = "0x12FC85C", VA = "0x12FC85C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x12FC988", Offset = "0x12FC988", VA = "0x12FC988")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x12FCAB8", Offset = "0x12FCAB8", VA = "0x12FCAB8")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string axis;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x12FCE00", Offset = "0x12FCE00", VA = "0x12FCE00")]
		public InputAxisScrollbar()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x12FCE08", Offset = "0x12FCE08", VA = "0x12FCE08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x12FCE0C", Offset = "0x12FCE0C", VA = "0x12FCE0C")]
		public void HandleInput(float value)
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x2000123")]
		public enum AxisOption
		{
			[Token(Token = "0x4000873")]
			Both,
			[Token(Token = "0x4000874")]
			OnlyHorizontal,
			[Token(Token = "0x4000875")]
			OnlyVertical
		}

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MovementRange;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AxisOption axesToUse;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string horizontalAxisName;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string verticalAxisName;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_UseX;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_UseY;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x12FCEB0", Offset = "0x12FCEB0", VA = "0x12FCEB0")]
		public Joystick()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x12FCF38", Offset = "0x12FCF38", VA = "0x12FCF38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x12FD11C", Offset = "0x12FD11C", VA = "0x12FD11C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x12FCF90", Offset = "0x12FCF90", VA = "0x12FCF90")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x12FD270", Offset = "0x12FD270", VA = "0x12FD270", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x12FD4E0", Offset = "0x12FD4E0", VA = "0x12FD4E0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x12FD548", Offset = "0x12FD548", VA = "0x12FD548", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x12FD54C", Offset = "0x12FD54C", VA = "0x12FD54C")]
		private void OnDisable()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x3A31DC", Offset = "0x3A31DC")]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x12FD5AC", Offset = "0x12FD5AC", VA = "0x12FD5AC")]
		public MobileControlRig()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x12FD5B4", Offset = "0x12FD5B4", VA = "0x12FD5B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x12FD5BC", Offset = "0x12FD5BC", VA = "0x12FD5BC")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x12FD5C4", Offset = "0x12FD5C4", VA = "0x12FD5C4")]
		private void EnableControlRig(bool enabled)
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000125")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x12FB85C", Offset = "0x12FB85C", VA = "0x12FB85C")]
		public MobileInput()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x12FDA24", Offset = "0x12FDA24", VA = "0x12FDA24")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x12FDAE0", Offset = "0x12FDAE0", VA = "0x12FDAE0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x12FDB8C", Offset = "0x12FDB8C", VA = "0x12FDB8C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x12FDC60", Offset = "0x12FDC60", VA = "0x12FDC60", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x12FDD50", Offset = "0x12FDD50", VA = "0x12FDD50", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x12FDE34", Offset = "0x12FDE34", VA = "0x12FDE34", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x12FDF0C", Offset = "0x12FDF0C", VA = "0x12FDF0C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x12FDFE8", Offset = "0x12FDFE8", VA = "0x12FDFE8", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x12FE0C0", Offset = "0x12FE0C0", VA = "0x12FE0C0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x12FE1A4", Offset = "0x12FE1A4", VA = "0x12FE1A4", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x12FE2BC", Offset = "0x12FE2BC", VA = "0x12FE2BC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x12FE3D4", Offset = "0x12FE3D4", VA = "0x12FE3D4", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x12FE4D0", Offset = "0x12FE4D0", VA = "0x12FE4D0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000126")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x12FB860", Offset = "0x12FB860", VA = "0x12FB860")]
		public StandaloneInput()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x12FE4F8", Offset = "0x12FE4F8", VA = "0x12FE4F8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x12FE510", Offset = "0x12FE510", VA = "0x12FE510", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x12FE51C", Offset = "0x12FE51C", VA = "0x12FE51C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x12FE528", Offset = "0x12FE528", VA = "0x12FE528", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x12FE534", Offset = "0x12FE534", VA = "0x12FE534", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x12FE5D0", Offset = "0x12FE5D0", VA = "0x12FE5D0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x12FE66C", Offset = "0x12FE66C", VA = "0x12FE66C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x12FE708", Offset = "0x12FE708", VA = "0x12FE708", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x12FE7A4", Offset = "0x12FE7A4", VA = "0x12FE7A4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x12FE840", Offset = "0x12FE840", VA = "0x12FE840", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x12FE8DC", Offset = "0x12FE8DC", VA = "0x12FE8DC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000127")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		public enum AxisOptions
		{
			[Token(Token = "0x400087C")]
			ForwardAxis,
			[Token(Token = "0x400087D")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000129")]
		public class AxisMapping
		{
			[Token(Token = "0x200012A")]
			public enum MappingType
			{
				[Token(Token = "0x4000881")]
				NamedAxis,
				[Token(Token = "0x4000882")]
				MousePositionX,
				[Token(Token = "0x4000883")]
				MousePositionY,
				[Token(Token = "0x4000884")]
				MousePositionZ
			}

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MappingType type;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string axisName;

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x12FED3C", Offset = "0x12FED3C", VA = "0x12FED3C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisMapping mapping;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fullTiltAngle;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float centreAngleOffset;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x12FE8F0", Offset = "0x12FE8F0", VA = "0x12FE8F0")]
		public TiltInput()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x12FE904", Offset = "0x12FE904", VA = "0x12FE904")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x12FE9EC", Offset = "0x12FE9EC", VA = "0x12FE9EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x12FED14", Offset = "0x12FED14", VA = "0x12FED14")]
		private void OnDisable()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A31EC", Offset = "0x3A31EC")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x200012C")]
		public enum AxisOption
		{
			[Token(Token = "0x4000898")]
			Both,
			[Token(Token = "0x4000899")]
			OnlyHorizontal,
			[Token(Token = "0x400089A")]
			OnlyVertical
		}

		[Token(Token = "0x200012D")]
		public enum ControlStyle
		{
			[Token(Token = "0x400089C")]
			Absolute,
			[Token(Token = "0x400089D")]
			Relative,
			[Token(Token = "0x400089E")]
			Swipe
		}

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string horizontalAxisName;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string verticalAxisName;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Xsensitivity;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Ysensitivity;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_UseX;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_UseY;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Dragging;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_Id;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_Center;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Image m_Image;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x12FED44", Offset = "0x12FED44", VA = "0x12FED44")]
		public TouchPad()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x12FEDD4", Offset = "0x12FEDD4", VA = "0x12FEDD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x12FEE9C", Offset = "0x12FEE9C", VA = "0x12FEE9C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x12FF028", Offset = "0x12FF028", VA = "0x12FF028")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x12FF0B8", Offset = "0x12FF0B8", VA = "0x12FF0B8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x12FF1B0", Offset = "0x12FF1B0", VA = "0x12FF1B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x12FF444", Offset = "0x12FF444", VA = "0x12FF444", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x12FF4EC", Offset = "0x12FF4EC", VA = "0x12FF4EC")]
		private void OnDisable()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE8A8", Offset = "0x3AE8A8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE8A8", Offset = "0x3AE8A8")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000103")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x12FE4E4", Offset = "0x12FE4E4", VA = "0x12FE4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C74", Offset = "0x3B0C74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x12FF628", Offset = "0x12FF628", VA = "0x12FF628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0C84", Offset = "0x3B0C84")]
			private set
			{
			}
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x12FD930", Offset = "0x12FD930", VA = "0x12FD930")]
		protected VirtualInput()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x12FB954", Offset = "0x12FB954", VA = "0x12FB954")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x12FBA80", Offset = "0x12FBA80", VA = "0x12FBA80")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x12FBB00", Offset = "0x12FBB00", VA = "0x12FBB00")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x12FBD5C", Offset = "0x12FBD5C", VA = "0x12FBD5C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x12FC018", Offset = "0x12FC018", VA = "0x12FC018")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x12FC17C", Offset = "0x12FC17C", VA = "0x12FC17C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x12FC234", Offset = "0x12FC234", VA = "0x12FC234")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x12FC93C", Offset = "0x12FC93C", VA = "0x12FC93C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x12FCA68", Offset = "0x12FCA68", VA = "0x12FCA68")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x12FCB98", Offset = "0x12FCB98", VA = "0x12FCB98")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60008A8")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60008A9")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60008AA")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60008AB")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x60008AC")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60008AD")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60008AE")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60008AF")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60008B0")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60008B1")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60008B2")]
		public abstract Vector3 MousePosition();
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200012F")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000130")]
		public enum Mode
		{
			[Token(Token = "0x40008A9")]
			Trigger,
			[Token(Token = "0x40008AA")]
			Replace,
			[Token(Token = "0x40008AB")]
			Activate,
			[Token(Token = "0x40008AC")]
			Enable,
			[Token(Token = "0x40008AD")]
			Animate,
			[Token(Token = "0x40008AE")]
			Deactivate
		}

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Mode action;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object target;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GameObject source;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int triggerCount;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool repeatTrigger;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x12FF634", Offset = "0x12FF634", VA = "0x12FF634")]
		public ActivateTrigger()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x12FF64C", Offset = "0x12FF64C", VA = "0x12FF64C")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x12FFBA0", Offset = "0x12FFBA0", VA = "0x12FFBA0")]
		private void OnTriggerEnter(Collider other)
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Shader original;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Shader replacement;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1300C98", Offset = "0x1300C98", VA = "0x1300C98")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000133")]
		public class ReplacementList
		{
			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1300CA0", Offset = "0x1300CA0", VA = "0x1300CA0")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x12FFBA4", Offset = "0x12FFBA4", VA = "0x12FFBA4")]
		public AutoMobileShaderSwitch()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x12FFBAC", Offset = "0x12FFBAC", VA = "0x12FFBAC")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 value;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Space space;

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1300F0C", Offset = "0x1300F0C", VA = "0x1300F0C")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool ignoreTimescale;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_LastRealTime;

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1300D14", Offset = "0x1300D14", VA = "0x1300D14")]
		public AutoMoveAndRotate()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1300D1C", Offset = "0x1300D1C", VA = "0x1300D1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1300D38", Offset = "0x1300D38", VA = "0x1300D38")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class CameraRefocus
	{
		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Camera Camera;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Parent;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Refocus;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1300F1C", Offset = "0x1300F1C", VA = "0x1300F1C")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1300F5C", Offset = "0x1300F5C", VA = "0x1300F5C")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1300F64", Offset = "0x1300F64", VA = "0x1300F64")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1300F6C", Offset = "0x1300F6C", VA = "0x1300F6C")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1301110", Offset = "0x1301110", VA = "0x1301110")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000137")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float HorizontalBobRange;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float VerticalBobRange;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_CyclePositionX;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_CyclePositionY;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Time;

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1301190", Offset = "0x1301190", VA = "0x1301190")]
		public CurveControlledBob()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x130142C", Offset = "0x130142C", VA = "0x130142C")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x130152C", Offset = "0x130152C", VA = "0x130152C")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000138")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3404", Offset = "0x3A3404")]
		private sealed class <DragObject>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <oldDrag>__0;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <oldAngularDrag>__0;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Camera <mainCamera>__0;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Ray <ray>__1;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal float distance;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal DragRigidbody $this;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal object $current;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;

			[Token(Token = "0x1700011D")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000952")]
				[Address(RVA = "0x13021BC", Offset = "0x13021BC", VA = "0x13021BC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000953")]
				[Address(RVA = "0x13021C4", Offset = "0x13021C4", VA = "0x13021C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x1301D20", Offset = "0x1301D20", VA = "0x1301D20")]
			[DebuggerHidden]
			public <DragObject>c__Iterator0()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1301D28", Offset = "0x1301D28", VA = "0x1301D28", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x13021CC", Offset = "0x13021CC", VA = "0x13021CC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x13021E0", Offset = "0x13021E0", VA = "0x13021E0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40008C7")]
		private const float k_Spring = 50f;

		[Token(Token = "0x40008C8")]
		private const float k_Damper = 5f;

		[Token(Token = "0x40008C9")]
		private const float k_Drag = 10f;

		[Token(Token = "0x40008CA")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x40008CB")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x40008CC")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1301674", Offset = "0x1301674", VA = "0x1301674")]
		public DragRigidbody()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x130167C", Offset = "0x130167C", VA = "0x130167C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1301C74", Offset = "0x1301C74", VA = "0x1301C74")]
		[DebuggerHidden]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1301BA8", Offset = "0x1301BA8", VA = "0x1301BA8")]
		private Camera FindCamera()
		{
			return null;
		}
	}
	[Token(Token = "0x2000139")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Light sunLight;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minHeight;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float minShadowDistance;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minShadowBias;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxHeight;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxShadowDistance;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxShadowBias;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float adaptTime;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_SmoothHeight;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_ChangeSpeed;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_OriginalStrength;

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x1302268", Offset = "0x1302268", VA = "0x1302268")]
		public DynamicShadowSettings()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x13022B0", Offset = "0x13022B0", VA = "0x13022B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x13022E4", Offset = "0x13022E4", VA = "0x13022E4")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1303148", Offset = "0x1303148", VA = "0x1303148")]
		public FollowTarget()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x13031A8", Offset = "0x13031A8", VA = "0x13031A8")]
		private void LateUpdate()
		{
		}
	}
}
[Token(Token = "0x200013B")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A3264", Offset = "0x3A3264")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x11A96BC", Offset = "0x11A96BC", VA = "0x11A96BC")]
	public ForcedReset()
	{
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x11A96C4", Offset = "0x11A96C4", VA = "0x11A96C4")]
	private void Update()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x200013C")]
	public class FOVKick
	{
		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3414", Offset = "0x3A3414")]
		private sealed class <FOVKickUp>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <t>__0;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal FOVKick $this;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x1700011F")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000958")]
				[Address(RVA = "0x1302ED8", Offset = "0x1302ED8", VA = "0x1302ED8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0x1302EE0", Offset = "0x1302EE0", VA = "0x1302EE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x130284C", Offset = "0x130284C", VA = "0x130284C")]
			[DebuggerHidden]
			public <FOVKickUp>c__Iterator0()
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1302C30", Offset = "0x1302C30", VA = "0x1302C30", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1302EE8", Offset = "0x1302EE8", VA = "0x1302EE8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1302EFC", Offset = "0x1302EFC", VA = "0x1302EFC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3424", Offset = "0x3A3424")]
		private sealed class <FOVKickDown>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <t>__0;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal FOVKick $this;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000121")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600095E")]
				[Address(RVA = "0x1302B84", Offset = "0x1302B84", VA = "0x1302B84", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0x1302B8C", Offset = "0x1302B8C", VA = "0x1302B8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x13028D8", Offset = "0x13028D8", VA = "0x13028D8")]
			[DebuggerHidden]
			public <FOVKickDown>c__Iterator1()
			{
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x13028E0", Offset = "0x13028E0", VA = "0x13028E0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1302B94", Offset = "0x1302B94", VA = "0x1302B94", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1302BA8", Offset = "0x1302BA8", VA = "0x1302BA8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Camera Camera;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x3AE8EC", Offset = "0x3AE8EC")]
		public float originalFov;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float FOVIncrease;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float TimeToIncrease;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float TimeToDecrease;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x130262C", Offset = "0x130262C", VA = "0x130262C")]
		public FOVKick()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x130264C", Offset = "0x130264C", VA = "0x130264C")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1302688", Offset = "0x1302688", VA = "0x1302688")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x13027C0", Offset = "0x13027C0", VA = "0x13027C0")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x13027C8", Offset = "0x13027C8", VA = "0x13027C8")]
		[DebuggerHidden]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1302854", Offset = "0x1302854", VA = "0x1302854")]
		[DebuggerHidden]
		public IEnumerator FOVKickDown()
		{
			return null;
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3A32DC", Offset = "0x3A32DC")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40008E1")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int m_FpsAccumulator;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_CurrentFps;

		[Token(Token = "0x40008E5")]
		private const string display = "{0} FPS";

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GUIText m_GuiText;

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1302F84", Offset = "0x1302F84", VA = "0x1302F84")]
		public FPSCounter()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1302F8C", Offset = "0x1302F8C", VA = "0x1302F8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x130300C", Offset = "0x130300C", VA = "0x130300C")]
		private void Update()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013E")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3434", Offset = "0x3A3434")]
		private sealed class <DoBobCycle>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <t>__0;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal LerpControlledBob $this;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000123")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x1303618", Offset = "0x1303618", VA = "0x1303618", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000124")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000965")]
				[Address(RVA = "0x1303620", Offset = "0x1303620", VA = "0x1303620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1303344", Offset = "0x1303344", VA = "0x1303344")]
			[DebuggerHidden]
			public <DoBobCycle>c__Iterator0()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x130334C", Offset = "0x130334C", VA = "0x130334C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1303628", Offset = "0x1303628", VA = "0x1303628", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x130363C", Offset = "0x130363C", VA = "0x130363C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float BobDuration;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float BobAmount;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_Offset;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x13032B0", Offset = "0x13032B0", VA = "0x13032B0")]
		public LerpControlledBob()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x13032B8", Offset = "0x13032B8", VA = "0x13032B8")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x13032C0", Offset = "0x13032C0", VA = "0x13032C0")]
		[DebuggerHidden]
		public IEnumerator DoBobCycle()
		{
			return null;
		}
	}
	[Token(Token = "0x200013F")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3444", Offset = "0x3A3444")]
		private sealed class <ResetCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float delay;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Transform[] $locvar0;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $locvar1;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal ObjectResetter $this;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal object $current;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool $disposing;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $PC;

			[Token(Token = "0x17000125")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600096A")]
				[Address(RVA = "0x1303D0C", Offset = "0x1303D0C", VA = "0x1303D0C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000126")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0x1303D14", Offset = "0x1303D14", VA = "0x1303D14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x13038E4", Offset = "0x13038E4", VA = "0x13038E4")]
			[DebuggerHidden]
			public <ResetCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x13038EC", Offset = "0x13038EC", VA = "0x13038EC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x1303D1C", Offset = "0x1303D1C", VA = "0x1303D1C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x1303D30", Offset = "0x1303D30", VA = "0x1303D30", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vector3 originalPosition;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Quaternion originalRotation;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Transform> originalStructure;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x13036C4", Offset = "0x13036C4", VA = "0x13036C4")]
		public ObjectResetter()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x13036CC", Offset = "0x13036CC", VA = "0x13036CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x1303814", Offset = "0x1303814", VA = "0x1303814")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x1303838", Offset = "0x1303838", VA = "0x1303838")]
		[DebuggerHidden]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}
	}
	[Token(Token = "0x2000140")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3454", Offset = "0x3A3454")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ParticleSystem[] <systems>__0;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal ParticleSystem[] $locvar0;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $locvar1;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal float <stopTime>__0;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ParticleSystem[] $locvar2;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int $locvar3;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ParticleSystemDestroyer $this;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal object $current;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int $PC;

			[Token(Token = "0x17000127")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000970")]
				[Address(RVA = "0x1304338", Offset = "0x1304338", VA = "0x1304338", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000128")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000971")]
				[Address(RVA = "0x1304340", Offset = "0x1304340", VA = "0x1304340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x1303E58", Offset = "0x1303E58", VA = "0x1303E58")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x1303E6C", Offset = "0x1303E6C", VA = "0x1303E6C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1304348", Offset = "0x1304348", VA = "0x1304348", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x130435C", Offset = "0x130435C", VA = "0x130435C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float minDuration;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float maxDuration;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_MaxLifetime;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_EarlyStop;

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1303DB8", Offset = "0x1303DB8", VA = "0x1303DB8")]
		public ParticleSystemDestroyer()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1303DD4", Offset = "0x1303DD4", VA = "0x1303DD4")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1303E60", Offset = "0x1303E60", VA = "0x1303E60")]
		public void Stop()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40008F7")]
			Standalone,
			[Token(Token = "0x40008F8")]
			Mobile
		}

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x13043E4", Offset = "0x13043E4", VA = "0x13043E4")]
		public PlatformSpecificContent()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1304474", Offset = "0x1304474", VA = "0x1304474")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1304478", Offset = "0x1304478", VA = "0x1304478")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x130448C", Offset = "0x130448C", VA = "0x130448C")]
		private void EnableContent(bool enabled)
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GUIText camSwitchButton;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject[] objects;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1304968", Offset = "0x1304968", VA = "0x1304968")]
		public SimpleActivatorMenu()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1304970", Offset = "0x1304970", VA = "0x1304970")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x13049FC", Offset = "0x13049FC", VA = "0x13049FC")]
		public void NextCamera()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector2 rotationRange;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationSpeed;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float dampingTime;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool relative;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1304B48", Offset = "0x1304B48", VA = "0x1304B48")]
		public SimpleMouseRotator()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1304C40", Offset = "0x1304C40", VA = "0x1304C40")]
		private void Start()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1304C98", Offset = "0x1304C98", VA = "0x1304C98")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x130521C", Offset = "0x130521C", VA = "0x130521C")]
		public SmoothFollow()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x130523C", Offset = "0x130523C", VA = "0x130523C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1305240", Offset = "0x1305240", VA = "0x1305240")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000147")]
		public enum Action
		{
			[Token(Token = "0x400090D")]
			Activate,
			[Token(Token = "0x400090E")]
			Deactivate,
			[Token(Token = "0x400090F")]
			Destroy,
			[Token(Token = "0x4000910")]
			ReloadLevel,
			[Token(Token = "0x4000911")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public class Entry
		{
			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject target;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Action action;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delay;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x1305FF4", Offset = "0x1305FF4", VA = "0x1305FF4")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public class Entries
		{
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Entry[] entries;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x130575C", Offset = "0x130575C", VA = "0x130575C")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3464", Offset = "0x3A3464")]
		private sealed class <Activate>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Entry entry;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000129")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x1305B90", Offset = "0x1305B90", VA = "0x1305B90", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000977")]
				[Address(RVA = "0x1305B98", Offset = "0x1305B98", VA = "0x1305B98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x1305A58", Offset = "0x1305A58", VA = "0x1305A58")]
			[DebuggerHidden]
			public <Activate>c__Iterator0()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x1305A70", Offset = "0x1305A70", VA = "0x1305A70", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x1305BA0", Offset = "0x1305BA0", VA = "0x1305BA0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x1305BB4", Offset = "0x1305BB4", VA = "0x1305BB4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3474", Offset = "0x3A3474")]
		private sealed class <Deactivate>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Entry entry;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700012B")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x1305D5C", Offset = "0x1305D5C", VA = "0x1305D5C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x1305D64", Offset = "0x1305D64", VA = "0x1305D64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x1305A60", Offset = "0x1305A60", VA = "0x1305A60")]
			[DebuggerHidden]
			public <Deactivate>c__Iterator1()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x1305C3C", Offset = "0x1305C3C", VA = "0x1305C3C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x1305D6C", Offset = "0x1305D6C", VA = "0x1305D6C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1305D80", Offset = "0x1305D80", VA = "0x1305D80", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A3484", Offset = "0x3A3484")]
		private sealed class <ReloadLevel>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Entry entry;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700012D")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000982")]
				[Address(RVA = "0x1305F48", Offset = "0x1305F48", VA = "0x1305F48", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000983")]
				[Address(RVA = "0x1305F50", Offset = "0x1305F50", VA = "0x1305F50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1305A68", Offset = "0x1305A68", VA = "0x1305A68")]
			[DebuggerHidden]
			public <ReloadLevel>c__Iterator2()
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1305E08", Offset = "0x1305E08", VA = "0x1305E08", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x1305F58", Offset = "0x1305F58", VA = "0x1305F58", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x1305F6C", Offset = "0x1305F6C", VA = "0x1305F6C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Entries entries;

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x13056E0", Offset = "0x13056E0", VA = "0x13056E0")]
		public TimedObjectActivator()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1305764", Offset = "0x1305764", VA = "0x1305764")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x13058CC", Offset = "0x13058CC", VA = "0x13058CC")]
		[DebuggerHidden]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1305950", Offset = "0x1305950", VA = "0x1305950")]
		[DebuggerHidden]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x13059D4", Offset = "0x13059D4", VA = "0x13059D4")]
		[DebuggerHidden]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}
	}
	[Token(Token = "0x200014A")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x1305FFC", Offset = "0x1305FFC", VA = "0x1305FFC")]
		public TimedObjectDestructor()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x130600C", Offset = "0x130600C", VA = "0x130600C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1306078", Offset = "0x1306078", VA = "0x1306078")]
		private void DestroyNow()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		public class WaypointList
		{
			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform[] items;

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x13061D0", Offset = "0x13061D0", VA = "0x13061D0")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200014D")]
		public struct RoutePoint
		{
			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x480DF8", Offset = "0x480DF8", VA = "0x480DF8")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WaypointList waypointList;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int numPoints;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] points;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float[] distances;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE9BC", Offset = "0x3AE9BC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AE9BC", Offset = "0x3AE9BC")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int p0n;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int p1n;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int p2n;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int p3n;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float i;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 P0;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 P1;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P2;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P3;

		[Token(Token = "0x17000104")]
		public float Length
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1306244", Offset = "0x1306244", VA = "0x1306244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D24", Offset = "0x3B0D24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x130624C", Offset = "0x130624C", VA = "0x130624C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D34", Offset = "0x3B0D34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x1306254", Offset = "0x1306254", VA = "0x1306254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x1306144", Offset = "0x1306144", VA = "0x1306144")]
		public WaypointCircuit()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1306278", Offset = "0x1306278", VA = "0x1306278")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1306810", Offset = "0x1306810", VA = "0x1306810")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x130694C", Offset = "0x130694C", VA = "0x130694C")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1306E94", Offset = "0x1306E94", VA = "0x1306E94")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x13062F0", Offset = "0x13062F0", VA = "0x13062F0")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1307270", Offset = "0x1307270", VA = "0x1307270")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x13076B0", Offset = "0x13076B0", VA = "0x13076B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1307278", Offset = "0x1307278", VA = "0x1307278")]
		private void DrawGizmos(bool selected)
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200014F")]
		public enum ProgressStyle
		{
			[Token(Token = "0x400093C")]
			SmoothAlongRoute,
			[Token(Token = "0x400093D")]
			PointToPoint
		}

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEA60", Offset = "0x3AEA60")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AEA60", Offset = "0x3AEA60")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEA94", Offset = "0x3AEA94")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AEA94", Offset = "0x3AEA94")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEAC8", Offset = "0x3AEAC8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x3AEAC8", Offset = "0x3AEAC8")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform target;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float progressDistance;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int progressNum;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float speed;

		[Token(Token = "0x17000106")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x13076F0", Offset = "0x13076F0", VA = "0x13076F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D44", Offset = "0x3B0D44")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x1307708", Offset = "0x1307708", VA = "0x1307708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D54", Offset = "0x3B0D54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x130772C", Offset = "0x130772C", VA = "0x130772C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D64", Offset = "0x3B0D64")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x1307744", Offset = "0x1307744", VA = "0x1307744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D74", Offset = "0x3B0D74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x1307768", Offset = "0x1307768", VA = "0x1307768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D84", Offset = "0x3B0D84")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1307780", Offset = "0x1307780", VA = "0x1307780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0D94", Offset = "0x3B0D94")]
			private set
			{
			}
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x13076B8", Offset = "0x13076B8", VA = "0x13076B8")]
		public WaypointProgressTracker()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x13077A4", Offset = "0x13077A4", VA = "0x13077A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x13078E0", Offset = "0x13078E0", VA = "0x13078E0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1307A74", Offset = "0x1307A74", VA = "0x1307A74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x13082A4", Offset = "0x13082A4", VA = "0x13082A4")]
		private void OnDrawGizmos()
		{
		}
	}
}
