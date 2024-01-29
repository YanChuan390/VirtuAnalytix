using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using Jundroo.SimplePlanes.ModTools;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BoundsTest : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66A48", Offset = "0xA66A48")]
	private sealed class <RestoreRotationAndRemoveOutliers>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public BoundsTest <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2499210", Offset = "0x2499210", VA = "0x2499210", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2499258", Offset = "0x2499258", VA = "0x2499258", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x248DD6C", Offset = "0x248DD6C", VA = "0x248DD6C")]
		[DebuggerHidden]
		public <RestoreRotationAndRemoveOutliers>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2499148", Offset = "0x2499148", VA = "0x2499148", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x249914C", Offset = "0x249914C", VA = "0x249914C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2499218", Offset = "0x2499218", VA = "0x2499218", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public Bounds HullBounds;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 GridStartPoint;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 GridEndPoint;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 RotationOffset;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ShipContainer;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x60")]
	public GameObject GridPointMarker;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GridPointHolder;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x70")]
	private bool _firstFrame;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x74")]
	private int _framesPassed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x248D1D4", Offset = "0x248D1D4", VA = "0x248D1D4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x248D274", Offset = "0x248D274", VA = "0x248D274")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x248D2BC", Offset = "0x248D2BC", VA = "0x248D2BC")]
	private void FirstFrameLateUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x248D99C", Offset = "0x248D99C", VA = "0x248D99C")]
	public void BuildGrid()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x248DD00", Offset = "0x248DD00", VA = "0x248DD00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA66E18", Offset = "0xA66E18")]
	public IEnumerator RestoreRotationAndRemoveOutliers()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x248D5B4", Offset = "0x248D5B4", VA = "0x248D5B4")]
	public static Bounds GetMainAircraftBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x248DD98", Offset = "0x248DD98", VA = "0x248DD98")]
	public BoundsTest()
	{
	}
}
[Token(Token = "0x2000004")]
public static class ExtensionMethods
{
	[Token(Token = "0x600000E")]
	public static List<T> ToList<T>(this T[] Array)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public class FineTunerSettings : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	public enum PivotMode
	{
		[Token(Token = "0x4000017")]
		FirstSelected,
		[Token(Token = "0x4000018")]
		Center
	}

	[Token(Token = "0x400000D")]
	private const string DefaultFNudgeKey = "FTDefaultFNudge";

	[Token(Token = "0x400000E")]
	private const string PivotModeKey = "FTPivotMode";

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66A88", Offset = "0xA66A88")]
	private static float <DefaultFNudge>k__BackingField;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66A98", Offset = "0xA66A98")]
	private static PivotMode <Pivot>k__BackingField;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField DefaultFNudgeField;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Dropdown PivotModeDropdown;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button SaveButton;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x30")]
	private float defaultFNudgeValue;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x34")]
	private PivotMode pivotValue;

	[Token(Token = "0x17000003")]
	public static float DefaultFNudge
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x248EE10", Offset = "0x248EE10", VA = "0x248EE10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66ED8", Offset = "0xA66ED8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x248EE74", Offset = "0x248EE74", VA = "0x248EE74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66EE8", Offset = "0xA66EE8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static PivotMode Pivot
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x248EEE4", Offset = "0x248EEE4", VA = "0x248EEE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66EF8", Offset = "0xA66EF8")]
		get
		{
			return default(PivotMode);
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x248EF48", Offset = "0x248EF48", VA = "0x248EF48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F08", Offset = "0xA66F08")]
		private set
		{
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x248EFB0", Offset = "0x248EFB0", VA = "0x248EFB0")]
	private static void Save()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x248F5A8", Offset = "0x248F5A8", VA = "0x248F5A8")]
	public static void Load()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x248F6EC", Offset = "0x248F6EC", VA = "0x248F6EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x248F8A0", Offset = "0x248F8A0", VA = "0x248F8A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x248F9CC", Offset = "0x248F9CC", VA = "0x248F9CC")]
	private void SaveButtonClicked()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x248FAC0", Offset = "0x248FAC0", VA = "0x248FAC0")]
	private void PivotModeChanged(int mode)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x248FAC8", Offset = "0x248FAC8", VA = "0x248FAC8")]
	private void DefaultFNudgeEdited(string value)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x248FB08", Offset = "0x248FB08", VA = "0x248FB08")]
	public FineTunerSettings()
	{
	}
}
[Token(Token = "0x2000007")]
public class FineTunerTool : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	public enum SelectionMode
	{
		[Token(Token = "0x4000041")]
		Single,
		[Token(Token = "0x4000042")]
		MultiSelect,
		[Token(Token = "0x4000043")]
		MultiEdit
	}

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	public bool DebugMode;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RotationManager Rotations;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PositionManager Positions;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button CloseButton;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button MultiToolButton;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x40")]
	private Text MultiToolText;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button AddMultiPartButton;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private LayerMask PartLayer;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66B38", Offset = "0xA66B38")]
	private static MonoBehaviour <SelectedPartScript>k__BackingField;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66B48", Offset = "0xA66B48")]
	private GameObject <EditorWidget>k__BackingField;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x60")]
	private MonoBehaviour SelectedPartMaterial;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x68")]
	private Collider SelectedPartCollider;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x70")]
	private MonoBehaviour LastSelectedPartScript;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x78")]
	private GameObject DesignerGameObject;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x80")]
	private MonoBehaviour DesignerScript;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x88")]
	private object Designer;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x90")]
	private FieldInfo SelectedPartField;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x98")]
	private PropertyInfo SelectedPartColliderProperty;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0xA0")]
	private PropertyInfo SelectedMaterialProperty;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0xA8")]
	private PropertyInfo MaterialIsSelectedProperty;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0xB0")]
	private PropertyInfo MaterialIsHiddenProperty;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 LastEulerAngles;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 LastPosition;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0xD0")]
	private MonoBehaviour GUIScript;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0xD8")]
	private MethodInfo GetSelectedFlyout;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0xE0")]
	private bool OtherGUIOut;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0xE1")]
	private bool OtherGUIOutLastFrame;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x8")]
	public static SelectionMode Mode;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0xC")]
	public static SelectionMode LastMode;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x10")]
	public static List<MonoBehaviour> CurrentlySelectedParts;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject ParentAdjuster;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0xF0")]
	private PropertyInfo SelectedToolProperty;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0xF8")]
	private Type SelectedToolType;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x100")]
	private FieldInfo SelectedTransformField;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x108")]
	private object SelectedTool;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x110")]
	private Transform SelectedTransform;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x18")]
	private static Transform UIRoot;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x20")]
	private static MonoBehaviour StatusMessage;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x28")]
	private static MethodInfo ShowMessage;

	[Token(Token = "0x17000005")]
	public static MonoBehaviour SelectedPartScript
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x248FB7C", Offset = "0x248FB7C", VA = "0x248FB7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F18", Offset = "0xA66F18")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x248FBE0", Offset = "0x248FBE0", VA = "0x248FBE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F28", Offset = "0xA66F28")]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject EditorWidget
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x248FC48", Offset = "0x248FC48", VA = "0x248FC48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F38", Offset = "0xA66F38")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x248FC50", Offset = "0x248FC50", VA = "0x248FC50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F48", Offset = "0xA66F48")]
		private set
		{
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x248C0EC", Offset = "0x248C0EC", VA = "0x248C0EC")]
	public static void DisableDeletionInput()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x248C2F0", Offset = "0x248C2F0", VA = "0x248C2F0")]
	public static void EnableDeltionInput()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x248FC58", Offset = "0x248FC58", VA = "0x248FC58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x24903D4", Offset = "0x24903D4", VA = "0x24903D4")]
	public void BenchmarkFindMethods()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x24907D4", Offset = "0x24907D4", VA = "0x24907D4")]
	private bool IsDraggingParts()
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x24909D0", Offset = "0x24909D0", VA = "0x24909D0")]
	private void MultiSelectCurrentPart()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2490E84", Offset = "0x2490E84", VA = "0x2490E84")]
	private void CycleMode()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2491F14", Offset = "0x2491F14", VA = "0x2491F14")]
	private void CancelMultiSelect()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2491388", Offset = "0x2491388", VA = "0x2491388")]
	private void SwitchToMultiEdit()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2492454", Offset = "0x2492454", VA = "0x2492454")]
	private void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2491FA0", Offset = "0x2491FA0", VA = "0x2491FA0")]
	public void DeGhostSelectedParts()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2493F38", Offset = "0x2493F38", VA = "0x2493F38")]
	public void UnparentAdjusterChildren()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x248F120", Offset = "0x248F120", VA = "0x248F120")]
	public static void ShowStatusMessageInDesigner(string Message, float Time = 5f)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2493FE0", Offset = "0x2493FE0", VA = "0x2493FE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2493E80", Offset = "0x2493E80", VA = "0x2493E80")]
	private void EnsureParentAdjusterExistance()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x249405C", Offset = "0x249405C", VA = "0x249405C")]
	public static string GetUsername()
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x249230C", Offset = "0x249230C", VA = "0x249230C")]
	public void DebugLog(object message)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x249418C", Offset = "0x249418C", VA = "0x249418C")]
	public FineTunerTool()
	{
	}
}
[Token(Token = "0x2000009")]
public class BlockDeleteInputOnFocus : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField TextField;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x20")]
	private bool FocusedLastFrame;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x248BF04", Offset = "0x248BF04", VA = "0x248BF04")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x248BF9C", Offset = "0x248BF9C", VA = "0x248BF9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x248C060", Offset = "0x248C060", VA = "0x248C060")]
	private void Update()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x248C298", Offset = "0x248C298", VA = "0x248C298")]
	public void EndEditOrSubmit(string NewValue)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x248C49C", Offset = "0x248C49C", VA = "0x248C49C")]
	public BlockDeleteInputOnFocus()
	{
	}
}
[Token(Token = "0x200000A")]
public class BlockPartSelection : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform MyTransform;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66B68", Offset = "0xA66B68")]
	private static GameObject <EditorWidget>k__BackingField;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x8")]
	private static List<BlockPartSelection> ActiveBlockers;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x10")]
	private static bool EnabledEditorWidget;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x11")]
	private static bool EnabledLastToggle;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x14")]
	private static int FramesSinceToggle;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x20")]
	private bool MouseDownOnThis;

	[Token(Token = "0x17000007")]
	public static GameObject EditorWidget
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x248C4A4", Offset = "0x248C4A4", VA = "0x248C4A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F58", Offset = "0xA66F58")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x248C508", Offset = "0x248C508", VA = "0x248C508")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66F68", Offset = "0xA66F68")]
		private set
		{
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x248C570", Offset = "0x248C570", VA = "0x248C570")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x248C810", Offset = "0x248C810", VA = "0x248C810")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x248C8F4", Offset = "0x248C8F4", VA = "0x248C8F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x248CB2C", Offset = "0x248CB2C", VA = "0x248CB2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x248C6A8", Offset = "0x248C6A8", VA = "0x248C6A8")]
	public static void EmergencyEnableSelection()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x248CF54", Offset = "0x248CF54", VA = "0x248CF54")]
	private bool PointerInRectTransform()
	{
		return default(bool);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x248D04C", Offset = "0x248D04C", VA = "0x248D04C")]
	private bool PointInRectTransform(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x248D128", Offset = "0x248D128", VA = "0x248D128")]
	public BlockPartSelection()
	{
	}
}
[Token(Token = "0x200000B")]
public class CameraHaltOnHover : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool OnDragOnly;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 CameraLastPosition;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x28")]
	private Quaternion CameraLastRotation;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x38")]
	private Transform EditorCamera;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x40")]
	private bool MouseDown;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x248DDA8", Offset = "0x248DDA8", VA = "0x248DDA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x248DDE0", Offset = "0x248DDE0", VA = "0x248DDE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x248DE40", Offset = "0x248DE40", VA = "0x248DE40")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x248DEA0", Offset = "0x248DEA0", VA = "0x248DEA0", Slot = "4")]
	public void OnPointerDown(PointerEventData pointer)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x248DF18", Offset = "0x248DF18", VA = "0x248DF18", Slot = "5")]
	public void OnPointerUp(PointerEventData pointer)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x248DF20", Offset = "0x248DF20", VA = "0x248DF20", Slot = "6")]
	public void OnDrag(PointerEventData pointer)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x248DF90", Offset = "0x248DF90", VA = "0x248DF90")]
	public CameraHaltOnHover()
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
public class CanvasScaleFactor : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int scaleByHeight;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x1C")]
	private int lastHeight;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x20")]
	private CanvasScaler scaler;

	[Token(Token = "0x17000008")]
	private CanvasScaler Scaler
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x248DF98", Offset = "0x248DF98", VA = "0x248DF98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x248E038", Offset = "0x248E038", VA = "0x248E038")]
	private void Update()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x248E0AC", Offset = "0x248E0AC", VA = "0x248E0AC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xA66F78", Offset = "0xA66F78")]
	private void ForceUpdate()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x248E238", Offset = "0x248E238", VA = "0x248E238")]
	public CanvasScaleFactor()
	{
	}
}
[Token(Token = "0x200000D")]
public class ClickDetector : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66B98", Offset = "0xA66B98")]
	private static bool <Clicked>k__BackingField;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66BA8", Offset = "0xA66BA8")]
	private static bool <ClickedLastFrame>k__BackingField;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66BB8", Offset = "0xA66BB8")]
	private static bool <DelayedClicked>k__BackingField;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66BC8", Offset = "0xA66BC8")]
	private static bool <DelayedClickedLastFrame>k__BackingField;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x18")]
	private int FramesUntilDelayedClick;

	[Token(Token = "0x17000009")]
	public static bool Clicked
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x248E24C", Offset = "0x248E24C", VA = "0x248E24C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66FB0", Offset = "0xA66FB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x248E298", Offset = "0x248E298", VA = "0x248E298")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66FC0", Offset = "0xA66FC0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public static bool ClickedLastFrame
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x248E2EC", Offset = "0x248E2EC", VA = "0x248E2EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66FD0", Offset = "0xA66FD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x248E338", Offset = "0x248E338", VA = "0x248E338")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66FE0", Offset = "0xA66FE0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool DelayedClicked
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x248E38C", Offset = "0x248E38C", VA = "0x248E38C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66FF0", Offset = "0xA66FF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x248E3D8", Offset = "0x248E3D8", VA = "0x248E3D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67000", Offset = "0xA67000")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public static bool DelayedClickedLastFrame
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x248E42C", Offset = "0x248E42C", VA = "0x248E42C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67010", Offset = "0xA67010")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x248E478", Offset = "0x248E478", VA = "0x248E478")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67020", Offset = "0xA67020")]
		private set
		{
		}
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x248E4CC", Offset = "0x248E4CC", VA = "0x248E4CC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x248E6A4", Offset = "0x248E6A4", VA = "0x248E6A4")]
	public void OnPress(bool MouseDown)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x248E6F8", Offset = "0x248E6F8", VA = "0x248E6F8")]
	public ClickDetector()
	{
	}
}
[Token(Token = "0x200000E")]
public class CloseButton : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x18")]
	private BlockPartSelection SelectionHandler;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x20")]
	private Button TriggerButton;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x248E708", Offset = "0x248E708", VA = "0x248E708")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x248E7F8", Offset = "0x248E7F8", VA = "0x248E7F8")]
	public void CloseFineTuneTool()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x248ED60", Offset = "0x248ED60", VA = "0x248ED60")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x248EE08", Offset = "0x248EE08", VA = "0x248EE08")]
	public CloseButton()
	{
	}
}
[Token(Token = "0x200000F")]
public class InputBlocker : MonoBehaviour
{
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform rect;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x20")]
	private BoxCollider blockCollider;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject devConsoleBlockerResource;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x28")]
	private int framesEnabled;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x8")]
	private static float? GameScale;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x10")]
	private static PropertyInfo UiScale;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x18")]
	private static object GameSettings;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2494230", Offset = "0x2494230", VA = "0x2494230")]
	private void Awake()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2494360", Offset = "0x2494360", VA = "0x2494360")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2494770", Offset = "0x2494770", VA = "0x2494770")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2494810", Offset = "0x2494810", VA = "0x2494810")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x24948D8", Offset = "0x24948D8", VA = "0x24948D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2494D2C", Offset = "0x2494D2C", VA = "0x2494D2C")]
	public InputBlocker()
	{
	}
}
[Token(Token = "0x2000010")]
public class MenuOptions : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField NudgeIncrementField;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66BE8", Offset = "0xA66BE8")]
	private static float <NudgeIncrement>k__BackingField;

	[Token(Token = "0x1700000D")]
	public static float NudgeIncrement
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2494D38", Offset = "0x2494D38", VA = "0x2494D38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67030", Offset = "0xA67030")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2494D84", Offset = "0x2494D84", VA = "0x2494D84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67040", Offset = "0xA67040")]
		private set
		{
		}
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2494DDC", Offset = "0x2494DDC", VA = "0x2494DDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2494FD8", Offset = "0x2494FD8", VA = "0x2494FD8")]
	private void SetNudgeIncrement(string NewValue)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2495050", Offset = "0x2495050", VA = "0x2495050")]
	public MenuOptions()
	{
	}
}
[Token(Token = "0x2000011")]
public class SafeArea : MonoBehaviour
{
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform Panel;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x20")]
	private Rect LastSafeArea;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2495ABC", Offset = "0x2495ABC", VA = "0x2495ABC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2495B94", Offset = "0x2495B94", VA = "0x2495B94")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2495B14", Offset = "0x2495B14", VA = "0x2495B14")]
	private void Refresh()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2495B98", Offset = "0x2495B98", VA = "0x2495B98")]
	private Rect GetSafeArea()
	{
		return default(Rect);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2495BA0", Offset = "0x2495BA0", VA = "0x2495BA0")]
	private void ApplySafeArea(Rect r)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2495F78", Offset = "0x2495F78", VA = "0x2495F78")]
	public SafeArea()
	{
	}
}
[Token(Token = "0x2000012")]
public class NumberInput : MonoBehaviour
{
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField TextField;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button UpButton;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button DownButton;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66C28", Offset = "0xA66C28")]
	private float <RealValue>k__BackingField;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x34")]
	private bool FocusedLastFrame;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x38")]
	private KeyCode[] UpdateInput;

	[Token(Token = "0x1700000E")]
	public float RealValue
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2495058", Offset = "0x2495058", VA = "0x2495058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67050", Offset = "0xA67050")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2495060", Offset = "0x2495060", VA = "0x2495060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67060", Offset = "0xA67060")]
		private set
		{
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2495068", Offset = "0x2495068", VA = "0x2495068")]
	private void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x24951E0", Offset = "0x24951E0", VA = "0x24951E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2495348", Offset = "0x2495348", VA = "0x2495348")]
	public void SetValue(float NewValue)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x24952F8", Offset = "0x24952F8", VA = "0x24952F8")]
	private void InputNewNumber(string NewValue)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x24953CC", Offset = "0x24953CC", VA = "0x24953CC")]
	public void EndEditOrSubmit(string NewValue)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2495468", Offset = "0x2495468", VA = "0x2495468")]
	public void NudgeUp()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2495540", Offset = "0x2495540", VA = "0x2495540")]
	public void NudgeDown()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2495618", Offset = "0x2495618", VA = "0x2495618")]
	public NumberInput()
	{
	}
}
[Token(Token = "0x2000013")]
public class PositionManager : MonoBehaviour
{
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private NumberInput XAxis;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NumberInput YAxis;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private NumberInput ZAxis;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66C68", Offset = "0xA66C68")]
	private float <X>k__BackingField;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66C78", Offset = "0xA66C78")]
	private float <Y>k__BackingField;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66C88", Offset = "0xA66C88")]
	private float <Z>k__BackingField;

	[Token(Token = "0x1700000F")]
	public float X
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x24957BC", Offset = "0x24957BC", VA = "0x24957BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67070", Offset = "0xA67070")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x24957C4", Offset = "0x24957C4", VA = "0x24957C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67080", Offset = "0xA67080")]
		private set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public float Y
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x24957CC", Offset = "0x24957CC", VA = "0x24957CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67090", Offset = "0xA67090")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x24957D4", Offset = "0x24957D4", VA = "0x24957D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA670A0", Offset = "0xA670A0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float Z
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x24957DC", Offset = "0x24957DC", VA = "0x24957DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA670B0", Offset = "0xA670B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x24957E4", Offset = "0x24957E4", VA = "0x24957E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA670C0", Offset = "0xA670C0")]
		private set
		{
		}
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x24957EC", Offset = "0x24957EC", VA = "0x24957EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x24923F4", Offset = "0x24923F4", VA = "0x24923F4")]
	public void SetGUIPositions(float XPosition, float YPosition, float ZPosition)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x24958FC", Offset = "0x24958FC", VA = "0x24958FC")]
	public PositionManager()
	{
	}
}
[Token(Token = "0x2000014")]
public class RotationManager : MonoBehaviour
{
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SliderValue XAxis;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SliderValue YAxis;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SliderValue ZAxis;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66CC8", Offset = "0xA66CC8")]
	private float <X>k__BackingField;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66CD8", Offset = "0xA66CD8")]
	private float <Y>k__BackingField;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66CE8", Offset = "0xA66CE8")]
	private float <Z>k__BackingField;

	[Token(Token = "0x17000012")]
	public float X
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2495904", Offset = "0x2495904", VA = "0x2495904")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA670D0", Offset = "0xA670D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x249590C", Offset = "0x249590C", VA = "0x249590C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA670E0", Offset = "0xA670E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float Y
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2495914", Offset = "0x2495914", VA = "0x2495914")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA670F0", Offset = "0xA670F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x249591C", Offset = "0x249591C", VA = "0x249591C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67100", Offset = "0xA67100")]
		private set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float Z
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2495924", Offset = "0x2495924", VA = "0x2495924")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67110", Offset = "0xA67110")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x249592C", Offset = "0x249592C", VA = "0x249592C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67120", Offset = "0xA67120")]
		private set
		{
		}
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2495934", Offset = "0x2495934", VA = "0x2495934")]
	private void Update()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2492394", Offset = "0x2492394", VA = "0x2492394")]
	public void SetGUIRotations(float XRot, float YRot, float ZRot)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2495AB4", Offset = "0x2495AB4", VA = "0x2495AB4")]
	public RotationManager()
	{
	}
}
[Token(Token = "0x2000015")]
public class SliderValue : MonoBehaviour
{
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Slider MySlider;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputField TextField;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66D18", Offset = "0xA66D18")]
	private float <RealValue>k__BackingField;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x2C")]
	private bool FocusedLastFrame;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x30")]
	private KeyCode[] UpdateInput;

	[Token(Token = "0x17000015")]
	public float RealValue
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2498328", Offset = "0x2498328", VA = "0x2498328")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67130", Offset = "0xA67130")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2498330", Offset = "0x2498330", VA = "0x2498330")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67140", Offset = "0xA67140")]
		private set
		{
		}
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2498338", Offset = "0x2498338", VA = "0x2498338")]
	private void Start()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2498488", Offset = "0x2498488", VA = "0x2498488")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2495A44", Offset = "0x2495A44", VA = "0x2495A44")]
	public void SetValue(float NewValue)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2498648", Offset = "0x2498648", VA = "0x2498648")]
	private void SliderChanged(float NewValue)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x24985A0", Offset = "0x24985A0", VA = "0x24985A0")]
	private void InputNewNumber(string NewValue)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x24986CC", Offset = "0x24986CC", VA = "0x24986CC")]
	private void FieldEndEdit(string NewValue)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x24986A8", Offset = "0x24986A8", VA = "0x24986A8")]
	private float RotationalClamp(float Value, float Min, float Max)
	{
		return default(float);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2498820", Offset = "0x2498820", VA = "0x2498820")]
	public SliderValue()
	{
	}
}
[Token(Token = "0x2000016")]
public class OtherToggleButton : MonoBehaviour
{
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject ThingToToggle;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x20")]
	private Button TriggerButton;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	private MonoBehaviour GUIScript;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2495698", Offset = "0x2495698", VA = "0x2495698", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2495750", Offset = "0x2495750", VA = "0x2495750", Slot = "5")]
	public virtual void ToggleIt()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2495794", Offset = "0x2495794", VA = "0x2495794", Slot = "6")]
	public virtual void SetItActive(bool active = true)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x24957B4", Offset = "0x24957B4", VA = "0x24957B4")]
	public OtherToggleButton()
	{
	}
}
[Token(Token = "0x2000017")]
public class ScaleTool : MonoBehaviour
{
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField Width;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputField Height;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private InputField Length;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Toggle CalculateMass;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Toggle ScaleEnginePower;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Toggle RelativeScale;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Toggle ScaleOnlySelectedPart;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button ScaleButton;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x58")]
	private PropertyInfo PartInfo;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x60")]
	private PropertyInfo PartScale;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x68")]
	private PropertyInfo MassScale;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x70")]
	private PropertyInfo EngineInfo;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x78")]
	private PropertyInfo PowerMultiplier;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x80")]
	private PropertyInfo CarEngineInfo;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x88")]
	private FieldInfo CarEnginePower;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x90")]
	private object Part;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x98")]
	private object Engine;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0xA0")]
	private object CarEngine;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2495FD0", Offset = "0x2495FD0", VA = "0x2495FD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x249606C", Offset = "0x249606C", VA = "0x249606C")]
	private void Scale()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x249732C", Offset = "0x249732C", VA = "0x249732C")]
	private void ScalePart(MonoBehaviour OriginalPart)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x24970AC", Offset = "0x24970AC", VA = "0x24970AC")]
	private void ScaleSelected()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2496090", Offset = "0x2496090", VA = "0x2496090")]
	private void ScaleAll()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2498244", Offset = "0x2498244", VA = "0x2498244")]
	public Vector3 DivideVectors(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2498254", Offset = "0x2498254", VA = "0x2498254")]
	public ScaleTool()
	{
	}
}
[Token(Token = "0x2000018")]
public class ToggleManager : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject FineTuneTool;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] ThingsToDisableOnClose;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite ButtonSprite;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66DE8", Offset = "0xA66DE8")]
	private static ToggleManager <Instance>k__BackingField;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x30")]
	private MonoBehaviour GUIScript;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x38")]
	private MethodInfo SetSelectedFlyout;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x40")]
	private MethodInfo GetSelectedFlyout;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x48")]
	private MethodInfo SetFlyoutShow;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66DF8", Offset = "0xA66DF8")]
	private static Collider <UndoCollider>k__BackingField;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA66E08", Offset = "0xA66E08")]
	private static Collider <RedoCollider>k__BackingField;

	[Token(Token = "0x17000016")]
	public static ToggleManager Instance
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x24988A0", Offset = "0x24988A0", VA = "0x24988A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67150", Offset = "0xA67150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x24988EC", Offset = "0x24988EC", VA = "0x24988EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67160", Offset = "0xA67160")]
		private set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool ToolActive
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x249893C", Offset = "0x249893C", VA = "0x249893C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static Collider UndoCollider
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2498958", Offset = "0x2498958", VA = "0x2498958")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67170", Offset = "0xA67170")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x24989A4", Offset = "0x24989A4", VA = "0x24989A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67180", Offset = "0xA67180")]
		private set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public static Collider RedoCollider
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x24989F4", Offset = "0x24989F4", VA = "0x24989F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA67190", Offset = "0xA67190")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2498A40", Offset = "0x2498A40", VA = "0x2498A40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA671A0", Offset = "0xA671A0")]
		private set
		{
		}
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2498A90", Offset = "0x2498A90", VA = "0x2498A90")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2499060", Offset = "0x2499060", VA = "0x2499060")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x24990B0", Offset = "0x24990B0", VA = "0x24990B0")]
	public void ToggleFineTuneTool()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x248E894", Offset = "0x248E894", VA = "0x248E894")]
	public void SetFineTuneToolActive(bool active = true)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x24990EC", Offset = "0x24990EC", VA = "0x24990EC")]
	public ToggleManager()
	{
	}
}
[Token(Token = "0x2000019")]
public class ServiceProvider : SimplePlanesModServiceProvider
{
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ServiceProvider _instance;

	[Token(Token = "0x1700001A")]
	public static ServiceProvider Instance
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2498264", Offset = "0x2498264", VA = "0x2498264")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x249825C", Offset = "0x249825C", VA = "0x249825C")]
	private ServiceProvider()
	{
	}
}
