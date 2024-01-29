using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using CodeStage.AdvancedFPSCounter.CountersData;
using CodeStage.AdvancedFPSCounter.Labels;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal class LabelEffect
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 distance;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	public int padding;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x14F630C", Offset = "0x14F630C", VA = "0x14F630C")]
	internal LabelEffect(bool enabled, Color color, int padding)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x14F63D8", Offset = "0x14F63D8", VA = "0x14F63D8")]
	internal LabelEffect(bool enabled, Color color, Vector2 distance)
	{
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x2000003")]
	public class APITester : MonoBehaviour
	{
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		private int selectedTab;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		private readonly string[] tabs;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		private FPSLevel currentFPSLevel;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x14F6538", Offset = "0x14F6538", VA = "0x14F6538")]
		private void Start()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x14F6678", Offset = "0x14F6678", VA = "0x14F6678")]
		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x14F6680", Offset = "0x14F6680", VA = "0x14F6680")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x14F79CC", Offset = "0x14F79CC", VA = "0x14F79CC")]
		private void DrawCommonTab()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x14F86FC", Offset = "0x14F86FC", VA = "0x14F86FC")]
		private void DrawLookFeelTab()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x14F9410", Offset = "0x14F9410", VA = "0x14F9410")]
		private void DrawFPSCounterTab()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x14FAC48", Offset = "0x14FAC48", VA = "0x14FAC48")]
		private void DrawMemoryCounterTab()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x14FBB2C", Offset = "0x14FBB2C", VA = "0x14FBB2C")]
		private void DrawDeviceInfoTab()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x14FCC50", Offset = "0x14FCC50", VA = "0x14FCC50")]
		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			return default(float);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x14FD1EC", Offset = "0x14FD1EC", VA = "0x14FD1EC")]
		private Color ColorSliders(string caption, Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x14FCF58", Offset = "0x14FCF58", VA = "0x14FCF58")]
		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x14FE1A0", Offset = "0x14FE1A0", VA = "0x14FE1A0")]
		public APITester()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x724BD0", Offset = "0x724BD0")]
	[DisallowMultipleComponent]
	public class AFPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000008")]
		private const string MENU_PATH = "Code Stage/Advanced FPS Counter";

		[Token(Token = "0x4000009")]
		private const string COMPONENT_NAME = "Advanced FPS Counter";

		[Token(Token = "0x400000A")]
		internal const string LOG_PREFIX = "<b>[AFPSCounter]:</b> ";

		[Token(Token = "0x400000B")]
		internal const char NEW_LINE = '\n';

		[Token(Token = "0x400000C")]
		internal const char SPACE = ' ';

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public FPSCounterData fpsCounter;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		public MemoryCounterData memoryCounter;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x28")]
		public DeviceInfoCounterData deviceInfoCounter;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724D2C", Offset = "0x724D2C")]
		public KeyCode hotKey;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724D64", Offset = "0x724D64")]
		public bool circleGesture;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724D9C", Offset = "0x724D9C")]
		public bool hotKeyCtrl;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724DD4", Offset = "0x724DD4")]
		public bool hotKeyShift;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724E0C", Offset = "0x724E0C")]
		public bool hotKeyAlt;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724E44", Offset = "0x724E44")]
		[SerializeField]
		private bool keepAlive;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		private Canvas canvas;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x48")]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x50")]
		private bool externalCanvas;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x58")]
		private DrawableLabel[] labels;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x60")]
		private int anchorsCount;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x64")]
		private int cachedVSync;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x68")]
		private int cachedFrameRate;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x6C")]
		private bool inited;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<Vector2> gesturePoints;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x78")]
		private int gestureCount;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724E90", Offset = "0x724E90")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x7D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724EDC", Offset = "0x724EDC")]
		[SerializeField]
		private bool forceFrameRate;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x724F28", Offset = "0x724F28")]
		[SerializeField]
		private int forcedFrameRate;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724F6C", Offset = "0x724F6C")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x724FB8", Offset = "0x724FB8")]
		[SerializeField]
		private Color backgroundColor;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725004", Offset = "0x725004")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x725004", Offset = "0x725004")]
		[SerializeField]
		private int backgroundPadding;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725068", Offset = "0x725068")]
		[SerializeField]
		private bool shadow;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7250B4", Offset = "0x7250B4")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725100", Offset = "0x725100")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72514C", Offset = "0x72514C")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725198", Offset = "0x725198")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7251E4", Offset = "0x7251E4")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725230", Offset = "0x725230")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72527C", Offset = "0x72527C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x72527C", Offset = "0x72527C")]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7252E0", Offset = "0x7252E0")]
		[SerializeField]
		private Font labelsFont;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72532C", Offset = "0x72532C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x72532C", Offset = "0x72532C")]
		[SerializeField]
		private int fontSize;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725394", Offset = "0x725394")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x725394", Offset = "0x725394")]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7253F8", Offset = "0x7253F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7253F8", Offset = "0x7253F8")]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72545C", Offset = "0x72545C")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7254A8", Offset = "0x7254A8")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7254F4", Offset = "0x7254F4")]
		[SerializeField]
		private int sortingOrder;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x725540", Offset = "0x725540")]
		private static AFPSCounter <Instance>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool KeepAlive
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x14F24EC", Offset = "0x14F24EC", VA = "0x14F24EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x14F24F4", Offset = "0x14F24F4", VA = "0x14F24F4")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x14F24FC", Offset = "0x14F24FC", VA = "0x14F24FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x14F2B98", Offset = "0x14F2B98", VA = "0x14F2B98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x14F2BA0", Offset = "0x14F2BA0", VA = "0x14F2BA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x14F2C0C", Offset = "0x14F2C0C", VA = "0x14F2C0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x14F2C14", Offset = "0x14F2C14", VA = "0x14F2C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool Background
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x14F2C6C", Offset = "0x14F2C6C", VA = "0x14F2C6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x14F2C74", Offset = "0x14F2C74", VA = "0x14F2C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Color BackgroundColor
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x14F2D44", Offset = "0x14F2D44", VA = "0x14F2D44")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x14F2D50", Offset = "0x14F2D50", VA = "0x14F2D50")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int BackgroundPadding
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x14F2E54", Offset = "0x14F2E54", VA = "0x14F2E54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x14F2E5C", Offset = "0x14F2E5C", VA = "0x14F2E5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool Shadow
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x14F2F28", Offset = "0x14F2F28", VA = "0x14F2F28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x14F2F30", Offset = "0x14F2F30", VA = "0x14F2F30")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Color ShadowColor
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x14F3000", Offset = "0x14F3000", VA = "0x14F3000")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x14F300C", Offset = "0x14F300C", VA = "0x14F300C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x14F3110", Offset = "0x14F3110", VA = "0x14F3110")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x14F3118", Offset = "0x14F3118", VA = "0x14F3118")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool Outline
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x14F3244", Offset = "0x14F3244", VA = "0x14F3244")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x14F324C", Offset = "0x14F324C", VA = "0x14F324C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color OutlineColor
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x14F331C", Offset = "0x14F331C", VA = "0x14F331C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x14F3328", Offset = "0x14F3328", VA = "0x14F3328")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x14F342C", Offset = "0x14F342C", VA = "0x14F342C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x14F3434", Offset = "0x14F3434", VA = "0x14F3434")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool AutoScale
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x14F3560", Offset = "0x14F3560", VA = "0x14F3560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x14F3568", Offset = "0x14F3568", VA = "0x14F3568")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float ScaleFactor
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x14F3638", Offset = "0x14F3638", VA = "0x14F3638")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x14F3640", Offset = "0x14F3640", VA = "0x14F3640")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Font LabelsFont
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x14F3738", Offset = "0x14F3738", VA = "0x14F3738")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x14F3740", Offset = "0x14F3740", VA = "0x14F3740")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public int FontSize
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x14F3874", Offset = "0x14F3874", VA = "0x14F3874")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x14F387C", Offset = "0x14F387C", VA = "0x14F387C")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float LineSpacing
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x14F39C4", Offset = "0x14F39C4", VA = "0x14F39C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x14F39CC", Offset = "0x14F39CC", VA = "0x14F39CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public int CountersSpacing
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x14F3B6C", Offset = "0x14F3B6C", VA = "0x14F3B6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x14F3B74", Offset = "0x14F3B74", VA = "0x14F3B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x14F3C20", Offset = "0x14F3C20", VA = "0x14F3C20")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x14F3C28", Offset = "0x14F3C28", VA = "0x14F3C28")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool PixelPerfect
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x14F3DE8", Offset = "0x14F3DE8", VA = "0x14F3DE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x14F3DF0", Offset = "0x14F3DF0", VA = "0x14F3DF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public int SortingOrder
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x14F3E68", Offset = "0x14F3E68", VA = "0x14F3E68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x14F3E70", Offset = "0x14F3E70", VA = "0x14F3E70")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x14F43D8", Offset = "0x14F43D8", VA = "0x14F43D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7262CC", Offset = "0x7262CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x14F4428", Offset = "0x14F4428", VA = "0x14F4428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7262DC", Offset = "0x7262DC")]
			private set
			{
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x14F3F3C", Offset = "0x14F3F3C", VA = "0x14F3F3C")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x14F447C", Offset = "0x14F447C", VA = "0x14F447C")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x14F46EC", Offset = "0x14F46EC", VA = "0x14F46EC")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x14F46F4", Offset = "0x14F46F4", VA = "0x14F46F4")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x14F46FC", Offset = "0x14F46FC", VA = "0x14F46FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7262EC", Offset = "0x7262EC")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x14F4700", Offset = "0x14F4700", VA = "0x14F4700")]
		public static void SelfDestroy()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x14F48D8", Offset = "0x14F48D8", VA = "0x14F48D8")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x14F45EC", Offset = "0x14F45EC", VA = "0x14F45EC")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x14F4998", Offset = "0x14F4998", VA = "0x14F4998")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x14F50EC", Offset = "0x14F50EC", VA = "0x14F50EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x14F51F8", Offset = "0x14F51F8", VA = "0x14F51F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x14F5728", Offset = "0x14F5728", VA = "0x14F5728")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x14F572C", Offset = "0x14F572C", VA = "0x14F572C")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x14F2728", Offset = "0x14F2728", VA = "0x14F2728")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x14F2ABC", Offset = "0x14F2ABC", VA = "0x14F2ABC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x14F59E4", Offset = "0x14F59E4", VA = "0x14F59E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x14F5CA0", Offset = "0x14F5CA0", VA = "0x14F5CA0")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x14F27A4", Offset = "0x14F27A4", VA = "0x14F27A4")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x14F4B30", Offset = "0x14F4B30", VA = "0x14F4B30")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x14F4E5C", Offset = "0x14F4E5C", VA = "0x14F4E5C")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x14F47F4", Offset = "0x14F47F4", VA = "0x14F47F4")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x14F5244", Offset = "0x14F5244", VA = "0x14F5244")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x14F5348", Offset = "0x14F5348", VA = "0x14F5348")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x14F5704", Offset = "0x14F5704", VA = "0x14F5704")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x14F57C4", Offset = "0x14F57C4", VA = "0x14F57C4")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x14F5860", Offset = "0x14F5860", VA = "0x14F5860")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x14F2C04", Offset = "0x14F2C04", VA = "0x14F2C04")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x14F5954", Offset = "0x14F5954", VA = "0x14F5954")]
		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public enum FPSLevel : byte
	{
		[Token(Token = "0x4000037")]
		Normal,
		[Token(Token = "0x4000038")]
		Warning,
		[Token(Token = "0x4000039")]
		Critical
	}
	[Token(Token = "0x2000006")]
	public enum OperationMode : byte
	{
		[Token(Token = "0x400003B")]
		Disabled,
		[Token(Token = "0x400003C")]
		Background,
		[Token(Token = "0x400003D")]
		Normal
	}
	[Token(Token = "0x2000007")]
	internal class UIUtils
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x14F61A8", Offset = "0x14F61A8", VA = "0x14F61A8")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1502200", Offset = "0x1502200", VA = "0x1502200")]
		public UIUtils()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class WaitForSecondsUnscaled : CustomYieldInstruction
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		private readonly float waitTime;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x14")]
		private float runUntil;

		[Token(Token = "0x17000018")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1502414", Offset = "0x1502414", VA = "0x1502414", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1500A04", Offset = "0x1500A04", VA = "0x1500A04")]
		public new void Reset()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1501580", Offset = "0x1501580", VA = "0x1501580")]
		public WaitForSecondsUnscaled(float time)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		private bool recording;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x1C")]
		private float renderTime;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1502208", Offset = "0x1502208", VA = "0x1502208")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x15022D0", Offset = "0x15022D0", VA = "0x15022D0")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x150240C", Offset = "0x150240C", VA = "0x150240C")]
		public AFPSRenderRecorder()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	[Token(Token = "0x200000A")]
	internal class DrawableLabel
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		internal GameObject container;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x18")]
		internal LabelAnchor anchor;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		internal StringBuilder newText;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		internal bool dirty;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x30")]
		private GameObject labelGameObject;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform labelTransform;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x40")]
		private ContentSizeFitter labelFitter;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x48")]
		private HorizontalLayoutGroup labelGroup;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x50")]
		private GameObject uiTextGameObject;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x58")]
		private Text uiText;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x60")]
		private Font font;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x68")]
		private int fontSize;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x6C")]
		private float lineSpacing;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 pixelOffset;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x78")]
		private readonly LabelEffect background;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x80")]
		private Image backgroundImage;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x88")]
		private readonly LabelEffect shadow;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x90")]
		private Shadow shadowComponent;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x98")]
		private readonly LabelEffect outline;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xA0")]
		private Outline outlineComponent;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x14F6444", Offset = "0x14F6444", VA = "0x14F6444")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x14F5CF8", Offset = "0x14F5CF8", VA = "0x14F5CF8")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x14F2600", Offset = "0x14F2600", VA = "0x14F2600")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x14F5C7C", Offset = "0x14F5C7C", VA = "0x14F5C7C")]
		internal void Destroy()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x14F384C", Offset = "0x14F384C", VA = "0x14F384C")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x14F3920", Offset = "0x14F3920", VA = "0x14F3920")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x14F3D38", Offset = "0x14F3D38", VA = "0x14F3D38")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x14F3AC8", Offset = "0x14F3AC8", VA = "0x14F3AC8")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x14F2D24", Offset = "0x14F2D24", VA = "0x14F2D24")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x14F2E34", Offset = "0x14F2E34", VA = "0x14F2E34")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x14F2F0C", Offset = "0x14F2F0C", VA = "0x14F2F0C")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x14F2FE0", Offset = "0x14F2FE0", VA = "0x14F2FE0")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x14F30F0", Offset = "0x14F30F0", VA = "0x14F30F0")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x14F3228", Offset = "0x14F3228", VA = "0x14F3228")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x14F32FC", Offset = "0x14F32FC", VA = "0x14F32FC")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x14F340C", Offset = "0x14F340C", VA = "0x14F340C")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x14F3544", Offset = "0x14F3544", VA = "0x14F3544")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1501A7C", Offset = "0x1501A7C", VA = "0x1501A7C")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15015B4", Offset = "0x15015B4", VA = "0x15015B4")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1501F5C", Offset = "0x1501F5C", VA = "0x1501F5C")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1501618", Offset = "0x1501618", VA = "0x1501618")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15017D0", Offset = "0x15017D0", VA = "0x15017D0")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1501988", Offset = "0x1501988", VA = "0x1501988")]
		private void ApplyFont()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public enum LabelAnchor : byte
	{
		[Token(Token = "0x4000057")]
		UpperLeft,
		[Token(Token = "0x4000058")]
		UpperRight,
		[Token(Token = "0x4000059")]
		LowerLeft,
		[Token(Token = "0x400005A")]
		LowerRight,
		[Token(Token = "0x400005B")]
		UpperCenter,
		[Token(Token = "0x400005C")]
		LowerCenter
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x724C2C", Offset = "0x724C2C")]
	public abstract class BaseCounterData
	{
		[Token(Token = "0x400005D")]
		protected const string BOLD_START = "<b>";

		[Token(Token = "0x400005E")]
		protected const string BOLD_END = "</b>";

		[Token(Token = "0x400005F")]
		protected const string ITALIC_START = "<i>";

		[Token(Token = "0x4000060")]
		protected const string ITALIC_END = "</i>";

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		internal StringBuilder text;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		internal bool dirty;

		[NonSerialized]
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x20")]
		protected AFPSCounter main;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		protected string colorCached;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x30")]
		protected bool inited;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool enabled;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725560", Offset = "0x725560")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7255AC", Offset = "0x7255AC")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7255F8", Offset = "0x7255F8")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725644", Offset = "0x725644")]
		protected string extraText;

		[Token(Token = "0x17000019")]
		public bool Enabled
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x14FE32C", Offset = "0x14FE32C", VA = "0x14FE32C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x14FD4FC", Offset = "0x14FD4FC", VA = "0x14FD4FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x14FE334", Offset = "0x14FE334", VA = "0x14FE334")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x14FD624", Offset = "0x14FD624", VA = "0x14FD624")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Color Color
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x14FE33C", Offset = "0x14FE33C", VA = "0x14FE33C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x14FE348", Offset = "0x14FE348", VA = "0x14FE348")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public FontStyle Style
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x14FE44C", Offset = "0x14FE44C", VA = "0x14FE44C")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x14FD578", Offset = "0x14FD578", VA = "0x14FD578")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public string ExtraText
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x14FE454", Offset = "0x14FE454", VA = "0x14FE454")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x14FD5CC", Offset = "0x14FD5CC", VA = "0x14FD5CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x14FE3F0", Offset = "0x14FE3F0", VA = "0x14FE3F0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x14FE45C", Offset = "0x14FE45C", VA = "0x14FE45C", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x6000083")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x14FE46C", Offset = "0x14FE46C", VA = "0x14FE46C")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x14F5C30", Offset = "0x14F5C30", VA = "0x14F5C30")]
		internal void Destroy()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x14FE474", Offset = "0x14FE474", VA = "0x14FE474", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x14FE594", Offset = "0x14FE594", VA = "0x14FE594", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x14FE608", Offset = "0x14FE608", VA = "0x14FE608", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x14FE60C", Offset = "0x14FE60C", VA = "0x14FE60C", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x14FE610", Offset = "0x14FE610", VA = "0x14FE610", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600008B")]
		protected abstract bool HasData();

		[Token(Token = "0x600008C")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x14FE614", Offset = "0x14FE614", VA = "0x14FE614")]
		protected void ApplyTextStyles()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x14FE7A8", Offset = "0x14FE7A8", VA = "0x14FE7A8")]
		protected BaseCounterData()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public abstract class UpdatebleCounterData : BaseCounterData
	{
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x50")]
		protected Coroutine updateCoroutine;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x58")]
		protected WaitForSecondsUnscaled cachedWaitForSecondsUnscaled;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72567C", Offset = "0x72567C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x72567C", Offset = "0x72567C")]
		[SerializeField]
		protected float updateInterval;

		[Token(Token = "0x1700001E")]
		public float UpdateInterval
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x1501494", Offset = "0x1501494", VA = "0x1501494")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x14FD698", Offset = "0x14FD698", VA = "0x14FD698")]
			set
			{
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x150150C", Offset = "0x150150C", VA = "0x150150C", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15006E0", Offset = "0x15006E0", VA = "0x15006E0", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1500720", Offset = "0x1500720", VA = "0x1500720", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000094")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1501510", Offset = "0x1501510", VA = "0x1501510")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x150155C", Offset = "0x150155C", VA = "0x150155C")]
		private void StoptUpdateCoroutine()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x150149C", Offset = "0x150149C", VA = "0x150149C")]
		private void CacheWaitForSeconds()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x14FFC78", Offset = "0x14FFC78", VA = "0x14FFC78")]
		protected UpdatebleCounterData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x724C64", Offset = "0x724C64")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7256E4", Offset = "0x7256E4")]
		[SerializeField]
		private bool platform;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725730", Offset = "0x725730")]
		[SerializeField]
		private bool cpuModel;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72577C", Offset = "0x72577C")]
		[SerializeField]
		private bool cpuModelNewLine;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x53")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7257C8", Offset = "0x7257C8")]
		[SerializeField]
		private bool gpuModel;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725814", Offset = "0x725814")]
		[SerializeField]
		private bool gpuModelNewLine;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725860", Offset = "0x725860")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x56")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7258AC", Offset = "0x7258AC")]
		[SerializeField]
		private bool gpuApiNewLine;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x57")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7258F8", Offset = "0x7258F8")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725944", Offset = "0x725944")]
		[SerializeField]
		private bool gpuSpecNewLine;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x59")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725990", Offset = "0x725990")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x5A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7259DC", Offset = "0x7259DC")]
		[SerializeField]
		private bool ramSizeNewLine;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x5B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725A28", Offset = "0x725A28")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725A74", Offset = "0x725A74")]
		[SerializeField]
		private bool screenDataNewLine;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725AC0", Offset = "0x725AC0")]
		[SerializeField]
		private bool deviceModel;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x5E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725B0C", Offset = "0x725B0C")]
		[SerializeField]
		private bool deviceModelNewLine;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x725B58", Offset = "0x725B58")]
		private string <LastValue>k__BackingField;

		[Token(Token = "0x1700001F")]
		public bool Platform
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x14FE7B8", Offset = "0x14FE7B8", VA = "0x14FE7B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x14FDEA0", Offset = "0x14FDEA0", VA = "0x14FDEA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool CpuModel
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x14FE7C0", Offset = "0x14FE7C0", VA = "0x14FE7C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x14FDF00", Offset = "0x14FDF00", VA = "0x14FDF00")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool CpuModelNewLine
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x14FE7C8", Offset = "0x14FE7C8", VA = "0x14FE7C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x14FE7D0", Offset = "0x14FE7D0", VA = "0x14FE7D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool GpuModel
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x14FE830", Offset = "0x14FE830", VA = "0x14FE830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x14FDF60", Offset = "0x14FDF60", VA = "0x14FDF60")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool GpuModelNewLine
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x14FE838", Offset = "0x14FE838", VA = "0x14FE838")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x14FE840", Offset = "0x14FE840", VA = "0x14FE840")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool GpuApi
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x14FE8A0", Offset = "0x14FE8A0", VA = "0x14FE8A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x14FDFC0", Offset = "0x14FDFC0", VA = "0x14FDFC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool GpuApiNewLine
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x14FE8A8", Offset = "0x14FE8A8", VA = "0x14FE8A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x14FE8B0", Offset = "0x14FE8B0", VA = "0x14FE8B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool GpuSpec
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x14FE910", Offset = "0x14FE910", VA = "0x14FE910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x14FE020", Offset = "0x14FE020", VA = "0x14FE020")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool GpuSpecNewLine
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x14FE918", Offset = "0x14FE918", VA = "0x14FE918")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x14FE920", Offset = "0x14FE920", VA = "0x14FE920")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool RamSize
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x14FE980", Offset = "0x14FE980", VA = "0x14FE980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x14FE080", Offset = "0x14FE080", VA = "0x14FE080")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool RamSizeNewLine
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x14FE988", Offset = "0x14FE988", VA = "0x14FE988")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x14FE990", Offset = "0x14FE990", VA = "0x14FE990")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool ScreenData
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x14FE9F0", Offset = "0x14FE9F0", VA = "0x14FE9F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x14FE0E0", Offset = "0x14FE0E0", VA = "0x14FE0E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool ScreenDataNewLine
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x14FE9F8", Offset = "0x14FE9F8", VA = "0x14FE9F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x14FEA00", Offset = "0x14FEA00", VA = "0x14FEA00")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool DeviceModel
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x14FEA60", Offset = "0x14FEA60", VA = "0x14FEA60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x14FE140", Offset = "0x14FE140", VA = "0x14FE140")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool DeviceModelNewLine
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x14FEA68", Offset = "0x14FEA68", VA = "0x14FEA68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x14FEA70", Offset = "0x14FEA70", VA = "0x14FEA70")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public string LastValue
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x14FEAD0", Offset = "0x14FEAD0", VA = "0x14FEAD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726324", Offset = "0x726324")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x14FEAD8", Offset = "0x14FEAD8", VA = "0x14FEAD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726334", Offset = "0x726334")]
			private set
			{
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x14F4360", Offset = "0x14F4360", VA = "0x14F4360")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x14FEAE0", Offset = "0x14FEAE0", VA = "0x14FEAE0", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x14FF38C", Offset = "0x14FF38C", VA = "0x14FF38C", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x14FF3BC", Offset = "0x14FF3BC", VA = "0x14FF3BC", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x724C9C", Offset = "0x724C9C")]
	public class FPSCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x724D0C", Offset = "0x724D0C")]
		private sealed class <UpdateCounter>d__147 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x20")]
			public FPSCounterData <>4__this;

			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x28")]
			private float <previousUpdateTime>5__2;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x2C")]
			private int <previousUpdateFrames>5__3;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x1500A34", Offset = "0x1500A34", VA = "0x1500A34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600011B")]
				[Address(RVA = "0x1500A9C", Offset = "0x1500A9C", VA = "0x1500A9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1500794", Offset = "0x1500794", VA = "0x1500794")]
			[DebuggerHidden]
			public <UpdateCounter>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x15008F4", Offset = "0x15008F4", VA = "0x15008F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x15008F8", Offset = "0x15008F8", VA = "0x15008F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1500A3C", Offset = "0x1500A3C", VA = "0x1500A3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400007E")]
		private const string COLOR_TEXT_START = "<color=#{0}>";

		[Token(Token = "0x400007F")]
		private const string COLOR_TEXT_END = "</color>";

		[Token(Token = "0x4000080")]
		private const string FPS_TEXT_START = "<color=#{0}>FPS: ";

		[Token(Token = "0x4000081")]
		private const string MS_TEXT_START = " <color=#{0}>[";

		[Token(Token = "0x4000082")]
		private const string MS_TEXT_END = " MS]</color>";

		[Token(Token = "0x4000083")]
		private const string MIN_TEXT_START = "<color=#{0}>MIN: ";

		[Token(Token = "0x4000084")]
		private const string MAX_TEXT_START = "<color=#{0}>MAX: ";

		[Token(Token = "0x4000085")]
		private const string AVG_TEXT_START = "<color=#{0}>AVG: ";

		[Token(Token = "0x4000086")]
		private const string RENDER_TEXT_START = "<color=#{0}>REN: ";

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x64")]
		public int warningLevelValue;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x68")]
		public int criticalLevelValue;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725B68", Offset = "0x725B68")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725BA0", Offset = "0x725BA0")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725BD8", Offset = "0x725BD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x725BD8", Offset = "0x725BD8")]
		public int minMaxIntervalsToSkip;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x80")]
		internal float newValue;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x88")]
		private string colorCachedMs;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x90")]
		private string colorCachedMin;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x98")]
		private string colorCachedMax;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xA0")]
		private string colorCachedAvg;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xA8")]
		private string colorCachedRender;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xB0")]
		private string colorWarningCached;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xB8")]
		private string colorWarningCachedMs;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xC0")]
		private string colorWarningCachedMin;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xC8")]
		private string colorWarningCachedMax;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xD0")]
		private string colorWarningCachedAvg;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xD8")]
		private string colorCriticalCached;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xE0")]
		private string colorCriticalCachedMs;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xE8")]
		private string colorCriticalCachedMin;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xF0")]
		private string colorCriticalCachedMax;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xF8")]
		private string colorCriticalCachedAvg;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x100")]
		private int currentAverageSamples;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x104")]
		private float currentAverageRaw;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x108")]
		private float[] accumulatedAverageSamples;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x110")]
		private int minMaxIntervalsSkipped;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x114")]
		private float renderTimeBank;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x118")]
		private int previousFrameCount;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725C3C", Offset = "0x725C3C")]
		[SerializeField]
		private bool milliseconds;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x11D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725C88", Offset = "0x725C88")]
		[SerializeField]
		private bool average;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x11E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725CD4", Offset = "0x725CD4")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x11F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725D20", Offset = "0x725D20")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725D6C", Offset = "0x725D6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x725D6C", Offset = "0x725D6C")]
		[SerializeField]
		private int averageSamples;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725DD4", Offset = "0x725DD4")]
		[SerializeField]
		private bool minMax;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x125")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725E20", Offset = "0x725E20")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x126")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725E6C", Offset = "0x725E6C")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x127")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725EB8", Offset = "0x725EB8")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725F04", Offset = "0x725F04")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x129")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725F50", Offset = "0x725F50")]
		[SerializeField]
		private bool renderNewLine;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x12A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725F9C", Offset = "0x725F9C")]
		[SerializeField]
		private bool renderAutoAdd;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x725FE8", Offset = "0x725FE8")]
		[SerializeField]
		private Color colorWarning;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x726034", Offset = "0x726034")]
		[SerializeField]
		private Color colorCritical;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x14C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x726080", Offset = "0x726080")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7260CC", Offset = "0x7260CC")]
		private int <LastValue>k__BackingField;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7260DC", Offset = "0x7260DC")]
		private float <LastMillisecondsValue>k__BackingField;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7260EC", Offset = "0x7260EC")]
		private float <LastRenderValue>k__BackingField;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7260FC", Offset = "0x7260FC")]
		private int <LastAverageValue>k__BackingField;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72610C", Offset = "0x72610C")]
		private float <LastAverageMillisecondsValue>k__BackingField;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72611C", Offset = "0x72611C")]
		private int <LastMinimumValue>k__BackingField;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72612C", Offset = "0x72612C")]
		private int <LastMaximumValue>k__BackingField;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72613C", Offset = "0x72613C")]
		private float <LastMinMillisecondsValue>k__BackingField;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72614C", Offset = "0x72614C")]
		private float <LastMaxMillisecondsValue>k__BackingField;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72615C", Offset = "0x72615C")]
		private FPSLevel <CurrentFpsLevel>k__BackingField;

		[Token(Token = "0x1700002F")]
		public bool Milliseconds
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x14FF4E4", Offset = "0x14FF4E4", VA = "0x14FF4E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x14FD740", Offset = "0x14FD740", VA = "0x14FD740")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool Average
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x14FF4EC", Offset = "0x14FF4EC", VA = "0x14FF4EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x14FD7A8", Offset = "0x14FD7A8", VA = "0x14FD7A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x14FF4F4", Offset = "0x14FF4F4", VA = "0x14FF4F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x14FD8FC", Offset = "0x14FD8FC", VA = "0x14FD8FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool AverageNewLine
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x14FF4FC", Offset = "0x14FF4FC", VA = "0x14FF4FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x14FD964", Offset = "0x14FD964", VA = "0x14FD964")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public int AverageSamples
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x14FF504", Offset = "0x14FF504", VA = "0x14FF504")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x14FD814", Offset = "0x14FD814", VA = "0x14FD814")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool MinMax
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x14FF50C", Offset = "0x14FF50C", VA = "0x14FF50C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x14FDA20", Offset = "0x14FDA20", VA = "0x14FDA20")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x14FF514", Offset = "0x14FF514", VA = "0x14FF514")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x14FDA90", Offset = "0x14FDA90", VA = "0x14FDA90")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x14FF51C", Offset = "0x14FF51C", VA = "0x14FF51C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x14FDB70", Offset = "0x14FDB70", VA = "0x14FDB70")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x14FF524", Offset = "0x14FF524", VA = "0x14FF524")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x14FDB10", Offset = "0x14FDB10", VA = "0x14FDB10")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool Render
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x14FF52C", Offset = "0x14FF52C", VA = "0x14FF52C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x14FDC20", Offset = "0x14FDC20", VA = "0x14FDC20")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool RenderNewLine
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x14FF728", Offset = "0x14FF728", VA = "0x14FF728")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x14FDCA8", Offset = "0x14FDCA8", VA = "0x14FDCA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x14FF730", Offset = "0x14FF730", VA = "0x14FF730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x14FF738", Offset = "0x14FF738", VA = "0x14FF738")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Color ColorWarning
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x14FF79C", Offset = "0x14FF79C", VA = "0x14FF79C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x14FF7B0", Offset = "0x14FF7B0", VA = "0x14FF7B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Color ColorCritical
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x14FF954", Offset = "0x14FF954", VA = "0x14FF954")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x14FF968", Offset = "0x14FF968", VA = "0x14FF968")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Color ColorRender
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x14FFB0C", Offset = "0x14FFB0C", VA = "0x14FFB0C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x14FFB20", Offset = "0x14FFB20", VA = "0x14FFB20")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int LastValue
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x14FFBD8", Offset = "0x14FFBD8", VA = "0x14FFBD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726364", Offset = "0x726364")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x14FFBE0", Offset = "0x14FFBE0", VA = "0x14FFBE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726374", Offset = "0x726374")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x14FFBE8", Offset = "0x14FFBE8", VA = "0x14FFBE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726384", Offset = "0x726384")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x14FFBF0", Offset = "0x14FFBF0", VA = "0x14FFBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726394", Offset = "0x726394")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public float LastRenderValue
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x14FFBF8", Offset = "0x14FFBF8", VA = "0x14FFBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7263A4", Offset = "0x7263A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x14FFC00", Offset = "0x14FFC00", VA = "0x14FFC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7263B4", Offset = "0x7263B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int LastAverageValue
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x14FFC08", Offset = "0x14FFC08", VA = "0x14FFC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7263C4", Offset = "0x7263C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x14FFC10", Offset = "0x14FFC10", VA = "0x14FFC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7263D4", Offset = "0x7263D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x14FFC18", Offset = "0x14FFC18", VA = "0x14FFC18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7263E4", Offset = "0x7263E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x14FFC20", Offset = "0x14FFC20", VA = "0x14FFC20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7263F4", Offset = "0x7263F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int LastMinimumValue
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x14FFC28", Offset = "0x14FFC28", VA = "0x14FFC28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726404", Offset = "0x726404")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x14FFC30", Offset = "0x14FFC30", VA = "0x14FFC30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726414", Offset = "0x726414")]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int LastMaximumValue
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x14FFC38", Offset = "0x14FFC38", VA = "0x14FFC38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726424", Offset = "0x726424")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x14FFC40", Offset = "0x14FFC40", VA = "0x14FFC40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726434", Offset = "0x726434")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x14FFC48", Offset = "0x14FFC48", VA = "0x14FFC48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726444", Offset = "0x726444")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x14FFC50", Offset = "0x14FFC50", VA = "0x14FFC50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726454", Offset = "0x726454")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x14FFC58", Offset = "0x14FFC58", VA = "0x14FFC58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726464", Offset = "0x726464")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x14FFC60", Offset = "0x14FFC60", VA = "0x14FFC60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726474", Offset = "0x726474")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x14FFC68", Offset = "0x14FFC68", VA = "0x14FFC68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726484", Offset = "0x726484")]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x14FFC70", Offset = "0x14FFC70", VA = "0x14FFC70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726494", Offset = "0x726494")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x14F65D4", Offset = "0x14F65D4", VA = "0x14F65D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726344", Offset = "0x726344")]
			add
			{
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x14FF440", Offset = "0x14FF440", VA = "0x14FF440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726354", Offset = "0x726354")]
			remove
			{
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x14F4174", Offset = "0x14F4174", VA = "0x14F4174")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x14FD9C4", Offset = "0x14FD9C4", VA = "0x14FD9C4")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x14FDBD0", Offset = "0x14FDBD0", VA = "0x14FDBD0")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x14F5758", Offset = "0x14F5758", VA = "0x14F5758")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x14FFC90", Offset = "0x14FFC90", VA = "0x14FFC90")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x14FFCB0", Offset = "0x14FFCB0", VA = "0x14FFCB0", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x15005E0", Offset = "0x15005E0", VA = "0x15005E0", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x15006E4", Offset = "0x15006E4", VA = "0x15006E4", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1500724", Offset = "0x1500724", VA = "0x1500724", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7264A4", Offset = "0x7264A4")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x15007C0", Offset = "0x15007C0", VA = "0x15007C0", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x15007C8", Offset = "0x15007C8", VA = "0x15007C8", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x14FF860", Offset = "0x14FF860", VA = "0x14FF860")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x14FFA18", Offset = "0x14FFA18", VA = "0x14FFA18")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1500564", Offset = "0x1500564", VA = "0x1500564")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x14FF630", Offset = "0x14FF630", VA = "0x14FF630")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x14FF534", Offset = "0x14FF534", VA = "0x14FF534")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x724CD4", Offset = "0x724CD4")]
	public class MemoryCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x724D1C", Offset = "0x724D1C")]
		private sealed class <UpdateCounter>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x20")]
			public MemoryCounterData <>4__this;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600011F")]
				[Address(RVA = "0x1501424", Offset = "0x1501424", VA = "0x1501424", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000121")]
				[Address(RVA = "0x150148C", Offset = "0x150148C", VA = "0x150148C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x15012C0", Offset = "0x15012C0", VA = "0x15012C0")]
			[DebuggerHidden]
			public <UpdateCounter>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x150138C", Offset = "0x150138C", VA = "0x150138C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1501390", Offset = "0x1501390", VA = "0x1501390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x150142C", Offset = "0x150142C", VA = "0x150142C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000BC")]
		public const long MEMORY_DIVIDER = 1048576L;

		[Token(Token = "0x40000BD")]
		private const string TEXT_START = "<color=#{0}>";

		[Token(Token = "0x40000BE")]
		private const string LINE_START_TOTAL = "MEM TOTAL: ";

		[Token(Token = "0x40000BF")]
		private const string LINE_START_ALLOCATED = "MEM ALLOC: ";

		[Token(Token = "0x40000C0")]
		private const string LINE_START_MONO = "MEM MONO: ";

		[Token(Token = "0x40000C1")]
		private const string LINE_END = " MB";

		[Token(Token = "0x40000C2")]
		private const string TEXT_END = "</color>";

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72616C", Offset = "0x72616C")]
		[SerializeField]
		private bool precise;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7261B8", Offset = "0x7261B8")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x66")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x726204", Offset = "0x726204")]
		[SerializeField]
		private bool allocated;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x67")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x726250", Offset = "0x726250")]
		[SerializeField]
		private bool monoUsage;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72629C", Offset = "0x72629C")]
		private long <LastTotalValue>k__BackingField;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7262AC", Offset = "0x7262AC")]
		private long <LastAllocatedValue>k__BackingField;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7262BC", Offset = "0x7262BC")]
		private long <LastMonoValue>k__BackingField;

		[Token(Token = "0x17000048")]
		public bool Precise
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1500AA4", Offset = "0x1500AA4", VA = "0x1500AA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x14FDD08", Offset = "0x14FDD08", VA = "0x14FDD08")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool Total
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1500AAC", Offset = "0x1500AAC", VA = "0x1500AAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x14FDD68", Offset = "0x14FDD68", VA = "0x14FDD68")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool Allocated
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1500AB4", Offset = "0x1500AB4", VA = "0x1500AB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x14FDDD0", Offset = "0x14FDDD0", VA = "0x14FDDD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool MonoUsage
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1500ABC", Offset = "0x1500ABC", VA = "0x1500ABC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x14FDE38", Offset = "0x14FDE38", VA = "0x14FDE38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public long LastTotalValue
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1500AC4", Offset = "0x1500AC4", VA = "0x1500AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726508", Offset = "0x726508")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1500ACC", Offset = "0x1500ACC", VA = "0x1500ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726518", Offset = "0x726518")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1500AD4", Offset = "0x1500AD4", VA = "0x1500AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726528", Offset = "0x726528")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1500ADC", Offset = "0x1500ADC", VA = "0x1500ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726538", Offset = "0x726538")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public long LastMonoValue
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1500AE4", Offset = "0x1500AE4", VA = "0x1500AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726548", Offset = "0x726548")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1500AEC", Offset = "0x1500AEC", VA = "0x1500AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726558", Offset = "0x726558")]
			private set
			{
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x14F42E0", Offset = "0x14F42E0", VA = "0x14F42E0")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1500AF4", Offset = "0x1500AF4", VA = "0x1500AF4", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1500F68", Offset = "0x1500F68", VA = "0x1500F68", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x150120C", Offset = "0x150120C", VA = "0x150120C", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1501250", Offset = "0x1501250", VA = "0x1501250", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x726568", Offset = "0x726568")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x15012EC", Offset = "0x15012EC", VA = "0x15012EC", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1501314", Offset = "0x1501314", VA = "0x1501314", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
