using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RuntimeInspectorNamespace;

[Token(Token = "0x2000002")]
public class ColorWheelControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	[Token(Token = "0x2000038")]
	public delegate void OnColorChangedDelegate(Color32 color);

	[Token(Token = "0x4000001")]
	private const float RGB_CONST = 2f / (float)Math.PI;

	[Token(Token = "0x4000002")]
	private const float G_CONST = (float)Math.PI * 2f / 3f;

	[Token(Token = "0x4000003")]
	private const float B_CONST = 4.1887903f;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color m_color;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF61B4", Offset = "0xDF61B4")]
	private float <Alpha>k__BackingField;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform rectTransform;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform SelectorOut;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform SelectorIn;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private WindowDragHandler colorPickerWindow;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float outer;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector2 inner;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material mat;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool draggingOuter;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool draggingInner;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float halfSize;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float halfSizeSqr;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float outerCirclePaddingSqr;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float innerSquareHalfSize;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int pointerId;

	[Token(Token = "0x17000001")]
	public Color Color
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x161F5E8", Offset = "0x161F5E8", VA = "0x161F5E8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x161F5F4", Offset = "0x161F5F4", VA = "0x161F5F4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public float Alpha
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x161F6A0", Offset = "0x161F6A0", VA = "0x161F6A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D24", Offset = "0xDF6D24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x161F6A8", Offset = "0x161F6A8", VA = "0x161F6A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D34", Offset = "0xDF6D34")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event OnColorChangedDelegate OnColorChanged
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x161E5F8", Offset = "0x161E5F8", VA = "0x161E5F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D44", Offset = "0xDF6D44")]
		add
		{
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x161F6B0", Offset = "0x161F6B0", VA = "0x161F6B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D54", Offset = "0xDF6D54")]
		remove
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x161F754", Offset = "0x161F754", VA = "0x161F754")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x161F8DC", Offset = "0x161F8DC", VA = "0x161F8DC")]
	private void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x161F868", Offset = "0x161F868", VA = "0x161F868")]
	private void UpdateProperties()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x161E818", Offset = "0x161E818", VA = "0x161E818")]
	public void PickColor(Color c)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x161FBD4", Offset = "0x161FBD4", VA = "0x161FBD4", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x161FEE4", Offset = "0x161FEE4", VA = "0x161FEE4", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x161FFF0", Offset = "0x161FFF0", VA = "0x161FFF0", Slot = "6")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x161FD44", Offset = "0x161FD44", VA = "0x161FD44")]
	private void GetSelectedColor(Vector2 pointerPos)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x16200D4", Offset = "0x16200D4", VA = "0x16200D4")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x161FA88", Offset = "0x161FA88", VA = "0x161FA88")]
	private Color GetCurrentBaseColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x161F96C", Offset = "0x161F96C", VA = "0x161F96C")]
	private void UpdateSelectors()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x16201E8", Offset = "0x16201E8", VA = "0x16201E8")]
	public ColorWheelControl()
	{
	}
}
[Token(Token = "0x2000003")]
public class RuntimeHierarchy : SkinnedWindow
{
	[Token(Token = "0x2000039")]
	public delegate void SelectionChangedDelegate(Transform selection);

	[Token(Token = "0x200003A")]
	public delegate void DoubleClickDelegate(Transform selection);

	[Token(Token = "0x4000015")]
	private const string POOL_OBJECT_NAME = "RuntimeHierarchyPool";

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float refreshInterval;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float nextRefreshTime;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_objectNamesRefreshInterval;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int poolCapacity;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform poolParent;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int aliveHierarchies;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<HierarchyItem> sceneDrawerPool;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<HierarchyItem> transformDrawerPool;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_exposeUnityScenes;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool m_exposeDontDestroyOnLoadScene;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string[] pseudoScenesOrder;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool m_createDraggedReferenceOnHold;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float m_draggedReferenceHoldTime;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool m_canReorganizeItems;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float doubleClickThreshold;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float lastClickTime;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private RuntimeInspector m_connectedInspector;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ScrollRect scrollView;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private RectTransform drawArea;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image background;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image scrollbar;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<HierarchyItemRoot> sceneDrawers;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private HierarchyItemRoot sceneDrawerPrefab;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private HierarchyItemTransform transformDrawerPrefab;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private HierarchyItem currentlySelectedDrawer;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Dictionary<string, HierarchyItemRoot> pseudoSceneDrawers;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Transform m_currentSelection;

	[Token(Token = "0x17000003")]
	public float ObjectNamesRefreshInterval
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x22D1710", Offset = "0x22D1710", VA = "0x22D1710")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000004")]
	public bool ExposeUnityScenes
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x22D1718", Offset = "0x22D1718", VA = "0x22D1718")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x22D1720", Offset = "0x22D1720", VA = "0x22D1720")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public bool ExposeDontDestroyOnLoadScene
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x22D1B90", Offset = "0x22D1B90", VA = "0x22D1B90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x22D1B98", Offset = "0x22D1B98", VA = "0x22D1B98")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool CreateDraggedReferenceOnHold
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x22D1D58", Offset = "0x22D1D58", VA = "0x22D1D58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x22D1D60", Offset = "0x22D1D60", VA = "0x22D1D60")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public float DraggedReferenceHoldTime
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x22D1D6C", Offset = "0x22D1D6C", VA = "0x22D1D6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x22D1D74", Offset = "0x22D1D74", VA = "0x22D1D74")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool CanReorganizeItems
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x22D1D7C", Offset = "0x22D1D7C", VA = "0x22D1D7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x22D1D84", Offset = "0x22D1D84", VA = "0x22D1D84")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public RuntimeInspector ConnectedInspector
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x22D1D90", Offset = "0x22D1D90", VA = "0x22D1D90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x22D1D98", Offset = "0x22D1D98", VA = "0x22D1D98")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Transform CurrentSelection
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x22D2674", Offset = "0x22D2674", VA = "0x22D2674")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x22D267C", Offset = "0x22D267C", VA = "0x22D267C")]
		private set
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event SelectionChangedDelegate OnSelectionChanged
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x22D23E4", Offset = "0x22D23E4", VA = "0x22D23E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D64", Offset = "0xDF6D64")]
		add
		{
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x22D2488", Offset = "0x22D2488", VA = "0x22D2488")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D74", Offset = "0xDF6D74")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event DoubleClickDelegate OnItemDoubleClicked
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x22D252C", Offset = "0x22D252C", VA = "0x22D252C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D84", Offset = "0xDF6D84")]
		add
		{
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x22D25D0", Offset = "0x22D25D0", VA = "0x22D25D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6D94", Offset = "0xDF6D94")]
		remove
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x22D2B20", Offset = "0x22D2B20", VA = "0x22D2B20", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x22D2DB4", Offset = "0x22D2DB4", VA = "0x22D2DB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x22D2F2C", Offset = "0x22D2F2C", VA = "0x22D2F2C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x22D3144", Offset = "0x22D3144", VA = "0x22D3144", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x22D31D4", Offset = "0x22D31D4", VA = "0x22D31D4")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x22D3270", Offset = "0x22D3270", VA = "0x22D3270")]
	public void RefreshNameOf(Transform target)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x22D343C", Offset = "0x22D343C", VA = "0x22D343C", Slot = "6")]
	protected override void RefreshSkin()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x22D3554", Offset = "0x22D3554", VA = "0x22D3554")]
	public void OnClicked(HierarchyItem drawer)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x22D3B5C", Offset = "0x22D3B5C", VA = "0x22D3B5C")]
	public bool Select(Transform selection)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x22D3EA4", Offset = "0x22D3EA4", VA = "0x22D3EA4")]
	public void Deselect()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x22D1824", Offset = "0x22D1824", VA = "0x22D1824")]
	private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x22D19E8", Offset = "0x22D19E8", VA = "0x22D19E8")]
	private void OnSceneUnloaded(Scene arg0)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x22D1BFC", Offset = "0x22D1BFC", VA = "0x22D1BFC")]
	private Scene GetDontDestroyOnLoadScene()
	{
		return default(Scene);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x22D3F90", Offset = "0x22D3F90", VA = "0x22D3F90")]
	public void AddToPseudoScene(string scene, Transform transform)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x22D40A8", Offset = "0x22D40A8", VA = "0x22D40A8")]
	public void AddToPseudoScene(string scene, IEnumerable<Transform> transforms)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x22D4328", Offset = "0x22D4328", VA = "0x22D4328")]
	public void RemoveFromPseudoScene(string scene, Transform transform, bool deleteSceneIfEmpty)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x22D4518", Offset = "0x22D4518", VA = "0x22D4518")]
	public void RemoveFromPseudoScene(string scene, IEnumerable<Transform> transforms, bool deleteSceneIfEmpty)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x22D3FC4", Offset = "0x22D3FC4", VA = "0x22D3FC4")]
	private HierarchyRootPseudoScene GetPseudoScene(string scene, bool createIfNotExists)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x22D498C", Offset = "0x22D498C", VA = "0x22D498C")]
	public void CreatePseudoScene(string scene)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x22D47D8", Offset = "0x22D47D8", VA = "0x22D47D8")]
	private HierarchyRootPseudoScene CreatePseudoSceneInternal(string scene)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x22D4A14", Offset = "0x22D4A14", VA = "0x22D4A14")]
	public void DeleteAllPseudoScenes()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x22D43AC", Offset = "0x22D43AC", VA = "0x22D43AC")]
	public void DeletePseudoScene(string scene)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x22D3EAC", Offset = "0x22D3EAC", VA = "0x22D3EAC")]
	private HierarchyItemRoot InstantiateSceneDrawer(IHierarchyRootContent target)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x22D4CF8", Offset = "0x22D4CF8", VA = "0x22D4CF8")]
	public HierarchyItemTransform InstantiateTransformDrawer(Transform drawerParent)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x22D4B5C", Offset = "0x22D4B5C", VA = "0x22D4B5C")]
	private HierarchyItem InstantiateDrawer(List<HierarchyItem> drawerPool, HierarchyItem drawerPrefab, Transform drawerParent)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x22D4DBC", Offset = "0x22D4DBC", VA = "0x22D4DBC")]
	public void PoolDrawer(HierarchyItem drawer)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x22D5004", Offset = "0x22D5004", VA = "0x22D5004")]
	public RuntimeHierarchy()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x22D5180", Offset = "0x22D5180", VA = "0x22D5180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6DA4", Offset = "0xDF6DA4")]
	private void <Awake>b__59_0(Transform transform)
	{
	}
}
[Token(Token = "0x2000004")]
public class HierarchyDragDropListener : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HierarchyItem hierarchyItem;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RuntimeHierarchy m_hierarchy;

	[Token(Token = "0x1700000B")]
	private RuntimeHierarchy Hierarchy
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1625DE0", Offset = "0x1625DE0", VA = "0x1625DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1625EC0", Offset = "0x1625EC0", VA = "0x1625EC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1625F88", Offset = "0x1625F88", VA = "0x1625F88", Slot = "4")]
	public void OnDrop(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x16266F8", Offset = "0x16266F8", VA = "0x16266F8")]
	public HierarchyDragDropListener()
	{
	}
}
[Token(Token = "0x2000005")]
public class PseudoSceneSourceTransform : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RuntimeHierarchy m_hierarchy;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_sceneName;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_hideOnDisable;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HashSet<Transform> childrenCurrent;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HashSet<Transform> childrenNew;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool updateChildren;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isEnabled;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool isQuitting;

	[Token(Token = "0x1700000C")]
	public RuntimeHierarchy Hierarchy
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x162F940", Offset = "0x162F940", VA = "0x162F940")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x162F948", Offset = "0x162F948", VA = "0x162F948")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public string SceneName
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x162FC84", Offset = "0x162FC84", VA = "0x162FC84")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x162FC8C", Offset = "0x162FC8C", VA = "0x162FC8C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public bool HideOnDisable
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x162FCF4", Offset = "0x162FCF4", VA = "0x162FCF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x162FCFC", Offset = "0x162FCFC", VA = "0x162FCFC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	private bool ShouldUpdateChildren
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x162FD30", Offset = "0x162FD30", VA = "0x162FD30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x162FDD0", Offset = "0x162FDD0", VA = "0x162FDD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x162FDDC", Offset = "0x162FDDC", VA = "0x162FDDC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x162FDF8", Offset = "0x162FDF8", VA = "0x162FDF8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x162FE04", Offset = "0x162FE04", VA = "0x162FE04")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x162FE10", Offset = "0x162FE10", VA = "0x162FE10")]
	private void Update()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x162FB98", Offset = "0x162FB98", VA = "0x162FB98")]
	private void AddChildrenToScene()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x162F9FC", Offset = "0x162F9FC", VA = "0x162F9FC")]
	private void RemoveChildrenFromScene()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x162FF78", Offset = "0x162FF78", VA = "0x162FF78")]
	public PseudoSceneSourceTransform()
	{
	}
}
[Token(Token = "0x2000006")]
public abstract class HierarchyItem : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Color NORMAL_COLOR;

	[Token(Token = "0x400003E")]
	protected const float INACTIVE_ITEM_TEXT_ALPHA = 0.57f;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool initialized;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RuntimeHierarchy m_hierarchy;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_skinVersion;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UISkin m_skin;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected LayoutGroup layoutGroup;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected RectTransform contentTransform;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Text nameText;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected RectTransform drawArea;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected PointerEventListener clickListener;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Image background;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PointerEventListener expandToggle;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image expandArrow;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected List<HierarchyItemTransform> children;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool m_isExpanded;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	protected bool m_isSelected;

	[Token(Token = "0x17000010")]
	public RuntimeHierarchy Hierarchy
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1626700", Offset = "0x1626700", VA = "0x1626700")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1626708", Offset = "0x1626708", VA = "0x1626708")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public UISkin Skin
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x16267C0", Offset = "0x16267C0", VA = "0x16267C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x16267C8", Offset = "0x16267C8", VA = "0x16267C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	protected abstract bool IsValid
	{
		[Token(Token = "0x600005A")]
		get;
	}

	[Token(Token = "0x17000013")]
	protected abstract int ChildCount
	{
		[Token(Token = "0x600005B")]
		get;
	}

	[Token(Token = "0x17000014")]
	protected virtual bool IsActive
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x16268A8", Offset = "0x16268A8", VA = "0x16268A8", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x16268B0", Offset = "0x16268B0", VA = "0x16268B0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public bool IsExpanded
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x16268B4", Offset = "0x16268B4", VA = "0x16268B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1626598", Offset = "0x1626598", VA = "0x1626598")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool IsSelected
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1626968", Offset = "0x1626968", VA = "0x1626968")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1626970", Offset = "0x1626970", VA = "0x1626970")]
		set
		{
		}
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1626A60", Offset = "0x1626A60", VA = "0x1626A60", Slot = "8")]
	protected virtual void Initialize()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1626B6C", Offset = "0x1626B6C", VA = "0x1626B6C", Slot = "9")]
	public virtual void Unbind()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x16268BC", Offset = "0x16268BC", VA = "0x16268BC")]
	private void ClearChildren()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1626BB8", Offset = "0x1626BB8", VA = "0x1626BB8", Slot = "10")]
	protected virtual void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1626D50", Offset = "0x1626D50", VA = "0x1626D50", Slot = "11")]
	public virtual void Refresh()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1627394", Offset = "0x1627394", VA = "0x1627394")]
	public void RefreshNameOf(Transform target)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x16274FC", Offset = "0x16274FC", VA = "0x16274FC", Slot = "12")]
	protected virtual void RefreshContent()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x16272E4", Offset = "0x16272E4", VA = "0x16272E4")]
	private void GenerateChildItem(Transform child, int index)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1627578", Offset = "0x1627578", VA = "0x1627578")]
	public HierarchyItem SelectTransform(Transform target, [Optional] Transform nextInPath)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x162793C", Offset = "0x162793C", VA = "0x162793C")]
	protected int IndexOf(Transform transform)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	protected abstract Transform GetChild(int index);

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1627A18", Offset = "0x1627A18", VA = "0x1627A18")]
	protected HierarchyItem()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1627AA8", Offset = "0x1627AA8", VA = "0x1627AA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6DB4", Offset = "0xDF6DB4")]
	private void <Initialize>b__36_0(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1627AC8", Offset = "0x1627AC8", VA = "0x1627AC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6DC4", Offset = "0xDF6DC4")]
	private void <Initialize>b__36_1(PointerEventData eventData)
	{
	}
}
[Token(Token = "0x2000007")]
public class HierarchyItemRoot : HierarchyItem
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<GameObject> childObjects;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF63C4", Offset = "0xDF63C4")]
	private IHierarchyRootContent <Content>k__BackingField;

	[Token(Token = "0x17000017")]
	protected override bool IsValid
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1627AD8", Offset = "0x1627AD8", VA = "0x1627AD8", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	protected override int ChildCount
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1627B88", Offset = "0x1627B88", VA = "0x1627B88", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000019")]
	public IHierarchyRootContent Content
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1627BD8", Offset = "0x1627BD8", VA = "0x1627BD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6DD4", Offset = "0xDF6DD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1627BE0", Offset = "0x1627BE0", VA = "0x1627BE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6DE4", Offset = "0xDF6DE4")]
		private set
		{
		}
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1627BE8", Offset = "0x1627BE8", VA = "0x1627BE8")]
	public void BindTo(IHierarchyRootContent target)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1627DD4", Offset = "0x1627DD4", VA = "0x1627DD4", Slot = "9")]
	public override void Unbind()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1627E44", Offset = "0x1627E44", VA = "0x1627E44", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1627EF4", Offset = "0x1627EF4", VA = "0x1627EF4", Slot = "12")]
	protected override void RefreshContent()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x162802C", Offset = "0x162802C", VA = "0x162802C", Slot = "13")]
	protected override Transform GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x16280AC", Offset = "0x16280AC", VA = "0x16280AC")]
	public HierarchyItemRoot()
	{
	}
}
[Token(Token = "0x2000008")]
public class HierarchyItemTransform : HierarchyItem
{
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF60E4", Offset = "0xDF60E4")]
	private sealed class <CreateReferenceItemCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HierarchyItemTransform <>4__this;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PointerEventData eventData;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x16288E8", Offset = "0x16288E8", VA = "0x16288E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1628950", Offset = "0x1628950", VA = "0x1628950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1628750", Offset = "0x1628750", VA = "0x1628750")]
		[DebuggerHidden]
		public <CreateReferenceItemCoroutine>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x16287AC", Offset = "0x16287AC", VA = "0x16287AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x16287B0", Offset = "0x16287B0", VA = "0x16287B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x16288F0", Offset = "0x16288F0", VA = "0x16288F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF63D4", Offset = "0xDF63D4")]
	private Transform <BoundTransform>k__BackingField;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private IEnumerator pointerHeldCoroutine;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float nextNameRefreshTime;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool m_isActive;

	[Token(Token = "0x1700001A")]
	protected override bool IsValid
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1628128", Offset = "0x1628128", VA = "0x1628128", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	protected override int ChildCount
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x16281A0", Offset = "0x16281A0", VA = "0x16281A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001C")]
	public Transform BoundTransform
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x16281BC", Offset = "0x16281BC", VA = "0x16281BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6DF4", Offset = "0xDF6DF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x16281C4", Offset = "0x16281C4", VA = "0x16281C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6E04", Offset = "0xDF6E04")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	protected override bool IsActive
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x16281CC", Offset = "0x16281CC", VA = "0x16281CC", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x16281D4", Offset = "0x16281D4", VA = "0x16281D4", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x16282A0", Offset = "0x16282A0", VA = "0x16282A0", Slot = "8")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1627500", Offset = "0x1627500", VA = "0x1627500")]
	public void BindTo(Transform target)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x16284C8", Offset = "0x16284C8", VA = "0x16284C8", Slot = "11")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x162856C", Offset = "0x162856C", VA = "0x162856C")]
	private void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x16286DC", Offset = "0x16286DC", VA = "0x16286DC")]
	private void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1628724", Offset = "0x1628724", VA = "0x1628724", Slot = "9")]
	public override void Unbind()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1628644", Offset = "0x1628644", VA = "0x1628644")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF6E14", Offset = "0xDF6E14")]
	private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x162877C", Offset = "0x162877C", VA = "0x162877C", Slot = "13")]
	protected override Transform GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1628798", Offset = "0x1628798", VA = "0x1628798")]
	public HierarchyItemTransform()
	{
	}
}
[Token(Token = "0x2000009")]
public class HierarchyRootPseudoScene : IHierarchyRootContent
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string name;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF63E4", Offset = "0xDF63E4")]
	private List<GameObject> <Children>k__BackingField;

	[Token(Token = "0x1700001E")]
	public bool IsValid
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1628958", Offset = "0x1628958", VA = "0x1628958", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public int ChildCount
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1628960", Offset = "0x1628960", VA = "0x1628960", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000020")]
	public string Name
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x16289B0", Offset = "0x16289B0", VA = "0x16289B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public List<GameObject> Children
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x16289B8", Offset = "0x16289B8", VA = "0x16289B8", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6E78", Offset = "0xDF6E78")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x16289C0", Offset = "0x16289C0", VA = "0x16289C0", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6E88", Offset = "0xDF6E88")]
		set
		{
		}
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x16289C8", Offset = "0x16289C8", VA = "0x16289C8")]
	public HierarchyRootPseudoScene(string name)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x16289FC", Offset = "0x16289FC", VA = "0x16289FC")]
	public void AddChild(Transform child)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1628AB8", Offset = "0x1628AB8", VA = "0x1628AB8")]
	public void RemoveChild(Transform child)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1628B34", Offset = "0x1628B34", VA = "0x1628B34", Slot = "9")]
	public void Refresh()
	{
	}
}
[Token(Token = "0x200000A")]
public class HierarchyRootScene : IHierarchyRootContent
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF63F4", Offset = "0xDF63F4")]
	private Scene <Scene>k__BackingField;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6404", Offset = "0xDF6404")]
	private List<GameObject> <Children>k__BackingField;

	[Token(Token = "0x17000022")]
	public bool IsValid
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1628C24", Offset = "0x1628C24", VA = "0x1628C24", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public int ChildCount
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1628C54", Offset = "0x1628C54", VA = "0x1628C54", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000024")]
	public string Name
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1628CA4", Offset = "0x1628CA4", VA = "0x1628CA4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000025")]
	public Scene Scene
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1628CD0", Offset = "0x1628CD0", VA = "0x1628CD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6E98", Offset = "0xDF6E98")]
		get
		{
			return default(Scene);
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1628CD8", Offset = "0x1628CD8", VA = "0x1628CD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6EA8", Offset = "0xDF6EA8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public List<GameObject> Children
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1628CE0", Offset = "0x1628CE0", VA = "0x1628CE0", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6EB8", Offset = "0xDF6EB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1628CE8", Offset = "0x1628CE8", VA = "0x1628CE8", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6EC8", Offset = "0xDF6EC8")]
		set
		{
		}
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1628CF0", Offset = "0x1628CF0", VA = "0x1628CF0")]
	public HierarchyRootScene(Scene target)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1628D1C", Offset = "0x1628D1C", VA = "0x1628D1C", Slot = "9")]
	public void Refresh()
	{
	}
}
[Token(Token = "0x200000B")]
public interface IHierarchyRootContent
{
	[Token(Token = "0x17000027")]
	bool IsValid
	{
		[Token(Token = "0x600009B")]
		get;
	}

	[Token(Token = "0x17000028")]
	int ChildCount
	{
		[Token(Token = "0x600009C")]
		get;
	}

	[Token(Token = "0x17000029")]
	string Name
	{
		[Token(Token = "0x600009D")]
		get;
	}

	[Token(Token = "0x1700002A")]
	List<GameObject> Children
	{
		[Token(Token = "0x600009E")]
		get;
		[Token(Token = "0x600009F")]
		set;
	}

	[Token(Token = "0x60000A0")]
	void Refresh();
}
[Token(Token = "0x200000C")]
public class RuntimeInspector : SkinnedWindow
{
	[Token(Token = "0x200003C")]
	public delegate object InspectedObjectChangingDelegate(object previousInspectedObject, object newInspectedObject);

	[Token(Token = "0x4000058")]
	private const string POOL_OBJECT_NAME = "RuntimeInspectorPool";

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private object m_inspectedObject;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float refreshInterval;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float nextRefreshTime;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_debugMode;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[SerializeField]
	private bool m_exposePrivateFields;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[SerializeField]
	private bool m_exposePublicFields;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	[SerializeField]
	private bool m_exposePrivateProperties;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool m_exposePublicProperties;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[SerializeField]
	private bool m_arrayIndicesStartAtOne;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[SerializeField]
	private bool m_useTitleCaseNaming;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int m_nestLimit;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int poolCapacity;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform poolParent;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int aliveInspectors;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<Type, List<InspectorField>> drawersPool;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RuntimeHierarchy m_connectedHierarchy;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private RuntimeInspectorSettings[] settings;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ScrollRect scrollView;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RectTransform drawArea;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image background;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image scrollbar;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private InspectorField currentDrawer;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool inspectLock;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool isDirty;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public InspectedObjectChangingDelegate OnInspectedObjectChanging;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Dictionary<Type, InspectorField> typeToDrawer;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<Type, InspectorField> typeToReferenceDrawer;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<VariableSet> hiddenVariables;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<VariableSet> exposedVariables;

	[Token(Token = "0x1700002B")]
	public object InspectedObject
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x22D53E8", Offset = "0x22D53E8", VA = "0x22D53E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public bool IsBound
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x22D53F0", Offset = "0x22D53F0", VA = "0x22D53F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002D")]
	public bool DebugMode
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x22D5464", Offset = "0x22D5464", VA = "0x22D5464")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x22D546C", Offset = "0x22D546C", VA = "0x22D546C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public bool ExposePrivateFields
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x22D5494", Offset = "0x22D5494", VA = "0x22D5494")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x22D549C", Offset = "0x22D549C", VA = "0x22D549C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public bool ExposePublicFields
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x22D54C4", Offset = "0x22D54C4", VA = "0x22D54C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x22D54CC", Offset = "0x22D54CC", VA = "0x22D54CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public bool ExposePrivateProperties
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x22D54F4", Offset = "0x22D54F4", VA = "0x22D54F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x22D54FC", Offset = "0x22D54FC", VA = "0x22D54FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public bool ExposePublicProperties
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x22D5524", Offset = "0x22D5524", VA = "0x22D5524")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x22D552C", Offset = "0x22D552C", VA = "0x22D552C")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public bool ArrayIndicesStartAtOne
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x22D5554", Offset = "0x22D5554", VA = "0x22D5554")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x22D555C", Offset = "0x22D555C", VA = "0x22D555C")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public bool UseTitleCaseNaming
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x22D5584", Offset = "0x22D5584", VA = "0x22D5584")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x22D558C", Offset = "0x22D558C", VA = "0x22D558C")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public int NestLimit
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x22D55B4", Offset = "0x22D55B4", VA = "0x22D55B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x22D55BC", Offset = "0x22D55BC", VA = "0x22D55BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public RuntimeHierarchy ConnectedHierarchy
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x22D55D8", Offset = "0x22D55D8", VA = "0x22D55D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x22D55E0", Offset = "0x22D55E0", VA = "0x22D55E0")]
		set
		{
		}
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x22D55E8", Offset = "0x22D55E8", VA = "0x22D55E8", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x22D5A3C", Offset = "0x22D5A3C", VA = "0x22D5A3C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x22D5B78", Offset = "0x22D5B78", VA = "0x22D5B78", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x22D5C88", Offset = "0x22D5C88", VA = "0x22D5C88")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x22D5D44", Offset = "0x22D5D44", VA = "0x22D5D44", Slot = "6")]
	protected override void RefreshSkin()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x22D1EA0", Offset = "0x22D1EA0", VA = "0x22D1EA0")]
	public void Inspect(object obj)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x22D526C", Offset = "0x22D526C", VA = "0x22D526C")]
	public void StopInspect()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x22D61D4", Offset = "0x22D61D4", VA = "0x22D61D4")]
	public InspectorField CreateDrawerForType(Type type, Transform drawerParent, int depth, bool drawObjectsAsFields = true)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x22D66CC", Offset = "0x22D66CC", VA = "0x22D66CC")]
	private InspectorField InstantiateDrawer(InspectorField drawer, Transform drawerParent)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x22D6490", Offset = "0x22D6490", VA = "0x22D6490")]
	private InspectorField GetDrawerForType(Type type, bool drawObjectsAsFields)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x22D68E0", Offset = "0x22D68E0", VA = "0x22D68E0")]
	public void PoolDrawer(InspectorField drawer)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x22D6AC4", Offset = "0x22D6AC4", VA = "0x22D6AC4")]
	public ExposedVariablesEnumerator GetExposedVariablesForType(Type type)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x22D7298", Offset = "0x22D7298", VA = "0x22D7298")]
	public RuntimeInspector()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x22D7450", Offset = "0x22D7450", VA = "0x22D7450")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6ED8", Offset = "0xDF6ED8")]
	private object <Inspect>b__67_0()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x22D7458", Offset = "0x22D7458", VA = "0x22D7458")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6EE8", Offset = "0xDF6EE8")]
	private void <Inspect>b__67_1(object value)
	{
	}
}
[Token(Token = "0x200000D")]
public enum ButtonVisibility
{
	[Token(Token = "0x4000077")]
	None,
	[Token(Token = "0x4000078")]
	InitializedObjects,
	[Token(Token = "0x4000079")]
	UninitializedObjects
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xDF5E88", Offset = "0xDF5E88")]
public class RuntimeInspectorButtonAttribute : Attribute
{
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string m_label;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_isInitializer;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private ButtonVisibility m_visibility;

	[Token(Token = "0x17000036")]
	public string Label
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x22D74B0", Offset = "0x22D74B0", VA = "0x22D74B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public bool IsInitializer
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x22D74B8", Offset = "0x22D74B8", VA = "0x22D74B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000038")]
	public ButtonVisibility Visibility
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x22D74C0", Offset = "0x22D74C0", VA = "0x22D74C0")]
		get
		{
			return default(ButtonVisibility);
		}
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x22D74C8", Offset = "0x22D74C8", VA = "0x22D74C8")]
	public RuntimeInspectorButtonAttribute(string label, bool isInitializer, ButtonVisibility visibility)
	{
	}
}
[Token(Token = "0x200000F")]
public class ArrayField : ExpandableInspectorField, IDropHandler, IEventSystemHandler
{
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF60F4", Offset = "0xDF60F4")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int j;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArrayField <>4__this;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x161AE1C", Offset = "0x161AE1C", VA = "0x161AE1C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x161C02C", Offset = "0x161C02C", VA = "0x161C02C")]
		internal object <GenerateElements>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x161C0C0", Offset = "0x161C0C0", VA = "0x161C0C0")]
		internal void <GenerateElements>b__1(object value)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6104", Offset = "0xDF6104")]
	private sealed class <>c__DisplayClass13_1
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int j;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArrayField <>4__this;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x161AF6C", Offset = "0x161AF6C", VA = "0x161AF6C")]
		public <>c__DisplayClass13_1()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x161C17C", Offset = "0x161C17C", VA = "0x161C17C")]
		internal object <GenerateElements>b__2()
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x161C288", Offset = "0x161C288", VA = "0x161C288")]
		internal void <GenerateElements>b__3(object value)
		{
		}
	}

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private LayoutElement sizeLayoutElement;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Text sizeText;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private BoundInputField sizeInput;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isArray;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Type elementType;

	[Token(Token = "0x17000039")]
	protected override int Length
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1619CB8", Offset = "0x1619CB8", VA = "0x1619CB8", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1619E10", Offset = "0x1619E10", VA = "0x1619E10", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x161A1DC", Offset = "0x161A1DC", VA = "0x161A1DC", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x161A2D8", Offset = "0x161A2D8", VA = "0x161A2D8", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x161A374", Offset = "0x161A374", VA = "0x161A374", Slot = "8")]
	protected override void OnUnbound()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x161A4AC", Offset = "0x161A4AC", VA = "0x161A4AC", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x161A77C", Offset = "0x161A77C", VA = "0x161A77C", Slot = "11")]
	protected override void OnDepthChanged()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x161A8EC", Offset = "0x161A8EC", VA = "0x161A8EC", Slot = "14")]
	protected override void GenerateElements()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x161AF74", Offset = "0x161AF74", VA = "0x161AF74", Slot = "16")]
	public void OnDrop(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x161B8EC", Offset = "0x161B8EC", VA = "0x161B8EC")]
	private bool OnSizeInputBeingChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x161B1F0", Offset = "0x161B1F0", VA = "0x161B1F0")]
	private bool OnSizeChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x161B928", Offset = "0x161B928", VA = "0x161B928")]
	private object GetTemplateElement(object value)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x161BF6C", Offset = "0x161BF6C", VA = "0x161BF6C")]
	public ArrayField()
	{
	}
}
[Token(Token = "0x2000010")]
public class BoolField : InspectorField
{
	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image toggleBackground;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Toggle input;

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x161C398", Offset = "0x161C398", VA = "0x161C398", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x161C440", Offset = "0x161C440", VA = "0x161C440", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x161C4C4", Offset = "0x161C4C4", VA = "0x161C4C4")]
	private void OnValueChanged(bool input)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x161C534", Offset = "0x161C534", VA = "0x161C534", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x161C714", Offset = "0x161C714", VA = "0x161C714", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x161C7A8", Offset = "0x161C7A8", VA = "0x161C7A8")]
	public BoolField()
	{
	}
}
[Token(Token = "0x2000011")]
public class BoundsField : InspectorField
{
	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Vector3Field inputCenter;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector3Field inputExtents;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private MemberInfo centerVariable;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private MemberInfo extentsVariable;

	[Token(Token = "0x1700003A")]
	protected override float HeightMultiplier
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x161CE68", Offset = "0x161CE68", VA = "0x161CE68", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x161CE70", Offset = "0x161CE70", VA = "0x161CE70", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x161CF4C", Offset = "0x161CF4C", VA = "0x161CF4C", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x161CFD0", Offset = "0x161CFD0", VA = "0x161CFD0", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x161D4B8", Offset = "0x161D4B8", VA = "0x161D4B8", Slot = "9")]
	protected override void OnInspectorChanged()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x161D5AC", Offset = "0x161D5AC", VA = "0x161D5AC", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x161D6DC", Offset = "0x161D6DC", VA = "0x161D6DC", Slot = "11")]
	protected override void OnDepthChanged()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x161D858", Offset = "0x161D858", VA = "0x161D858", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x161D8A0", Offset = "0x161D8A0", VA = "0x161D8A0")]
	public BoundsField()
	{
	}
}
[Token(Token = "0x2000012")]
public class ColorField : InspectorField
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PointerEventListener inputColor;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Image colorImg;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isColor32;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x161D8B0", Offset = "0x161D8B0", VA = "0x161D8B0", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x161DA24", Offset = "0x161DA24", VA = "0x161DA24", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x161DB08", Offset = "0x161DB08", VA = "0x161DB08", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x161DBAC", Offset = "0x161DBAC", VA = "0x161DBAC")]
	private void ShowColorPicker(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x161DF80", Offset = "0x161DF80", VA = "0x161DF80")]
	private void OnColorChanged(Color32 color)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x161E054", Offset = "0x161E054", VA = "0x161E054", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x161E138", Offset = "0x161E138", VA = "0x161E138")]
	public ColorField()
	{
	}
}
[Token(Token = "0x2000013")]
public class DecimalField : InspectorField
{
	[Token(Token = "0x200003F")]
	private struct NumberParser
	{
		[Token(Token = "0x2000051")]
		private delegate bool ParseFunc(string input, out object value);

		[Token(Token = "0x2000052")]
		private delegate bool EqualsFunc(object value1, object value2);

		[Serializable]
		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6194", Offset = "0xDF6194")]
		private sealed class <>c
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static ParseFunc <>9__4_0;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static EqualsFunc <>9__4_1;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static ParseFunc <>9__4_2;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static EqualsFunc <>9__4_3;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static ParseFunc <>9__4_4;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static EqualsFunc <>9__4_5;

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x16213D0", Offset = "0x16213D0", VA = "0x16213D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x16213D8", Offset = "0x16213D8", VA = "0x16213D8")]
			internal bool <.ctor>b__4_0(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x162146C", Offset = "0x162146C", VA = "0x162146C")]
			internal bool <.ctor>b__4_1(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x1621530", Offset = "0x1621530", VA = "0x1621530")]
			internal bool <.ctor>b__4_2(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x16215E4", Offset = "0x16215E4", VA = "0x16215E4")]
			internal bool <.ctor>b__4_3(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x16216A8", Offset = "0x16216A8", VA = "0x16216A8")]
			internal bool <.ctor>b__4_4(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x162175C", Offset = "0x162175C", VA = "0x162175C")]
			internal bool <.ctor>b__4_5(object value1, object value2)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ParseFunc parseFunction;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly EqualsFunc equalsFunction;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC44BF0", Offset = "0xC44BF0", VA = "0xC44BF0")]
		public NumberParser(Type fieldType)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC44BF8", Offset = "0xC44BF8", VA = "0xC44BF8")]
		public bool TryParse(string input, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC44C10", Offset = "0xC44C10", VA = "0xC44C10")]
		public bool ValuesAreEqual(object value1, object value2)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField input;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private NumberParser parser;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1620294", Offset = "0x1620294", VA = "0x1620294", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1620390", Offset = "0x1620390", VA = "0x1620390", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x16204B8", Offset = "0x16204B8", VA = "0x16204B8", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1620A2C", Offset = "0x1620A2C", VA = "0x1620A2C")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1620A98", Offset = "0x1620A98", VA = "0x1620A98", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1620AC8", Offset = "0x1620AC8", VA = "0x1620AC8", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1620B48", Offset = "0x1620B48", VA = "0x1620B48")]
	public DecimalField()
	{
	}
}
[Token(Token = "0x2000014")]
public class EnumField : InspectorField
{
	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image background;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image dropdownArrow;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RectTransform templateTransform;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image templateBackground;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image templateCheckmark;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text templateText;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Dropdown input;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, List<string>> enumNames;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<Type, List<object>> enumValues;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<string> currEnumNames;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<object> currEnumValues;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x16231F0", Offset = "0x16231F0", VA = "0x16231F0", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1623294", Offset = "0x1623294", VA = "0x1623294", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x16232B8", Offset = "0x16232B8", VA = "0x16232B8", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1623594", Offset = "0x1623594", VA = "0x1623594")]
	private void OnValueChanged(int input)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1623610", Offset = "0x1623610", VA = "0x1623610", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x16237B8", Offset = "0x16237B8", VA = "0x16237B8", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1623844", Offset = "0x1623844", VA = "0x1623844")]
	public EnumField()
	{
	}
}
[Token(Token = "0x2000015")]
public class ExposedMethodField : InspectorField
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Button invokeButton;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected ExposedMethod boundMethod;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1624990", Offset = "0x1624990", VA = "0x1624990", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1624A14", Offset = "0x1624A14", VA = "0x1624A14", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1624AA8", Offset = "0x1624AA8", VA = "0x1624AA8", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1624AD4", Offset = "0x1624AD4", VA = "0x1624AD4", Slot = "11")]
	protected override void OnDepthChanged()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1623DF0", Offset = "0x1623DF0", VA = "0x1623DF0")]
	public void SetBoundMethod(ExposedMethod boundMethod)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1624B94", Offset = "0x1624B94", VA = "0x1624B94")]
	public void InvokeMethod()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1624BF0", Offset = "0x1624BF0", VA = "0x1624BF0")]
	public ExposedMethodField()
	{
	}
}
[Token(Token = "0x2000016")]
public class GameObjectField : ExpandableInspectorField
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string currentTag;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private List<Component> components;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private StringField nameField;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private StringField tagField;

	[Token(Token = "0x1700003B")]
	protected override int Length
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x16250F4", Offset = "0x16250F4", VA = "0x16250F4", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1625148", Offset = "0x1625148", VA = "0x1625148", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x16251CC", Offset = "0x16251CC", VA = "0x16251CC", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1625250", Offset = "0x1625250", VA = "0x1625250", Slot = "8")]
	protected override void OnUnbound()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x16252B0", Offset = "0x16252B0", VA = "0x16252B0", Slot = "14")]
	protected override void GenerateElements()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x16256DC", Offset = "0x16256DC", VA = "0x16256DC", Slot = "15")]
	protected override void ClearElements()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x16257D4", Offset = "0x16257D4", VA = "0x16257D4", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1625948", Offset = "0x1625948", VA = "0x1625948")]
	public GameObjectField()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x16259C4", Offset = "0x16259C4", VA = "0x16259C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6EF8", Offset = "0xDF6EF8")]
	private object <GenerateElements>b__9_0()
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1625A5C", Offset = "0x1625A5C", VA = "0x1625A5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F08", Offset = "0xDF6F08")]
	private void <GenerateElements>b__9_1(object value)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1625B10", Offset = "0x1625B10", VA = "0x1625B10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F18", Offset = "0xDF6F18")]
	private object <GenerateElements>b__9_2()
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1625B7C", Offset = "0x1625B7C", VA = "0x1625B7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F28", Offset = "0xDF6F28")]
	private void <GenerateElements>b__9_3(object value)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1625CA0", Offset = "0x1625CA0", VA = "0x1625CA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F38", Offset = "0xDF6F38")]
	private object <GenerateElements>b__9_4()
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1625D40", Offset = "0x1625D40", VA = "0x1625D40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F48", Offset = "0xDF6F48")]
	private void <GenerateElements>b__9_5(object value)
	{
	}
}
[Token(Token = "0x2000017")]
public abstract class InspectorField : MonoBehaviour
{
	[Token(Token = "0x2000040")]
	public delegate object Getter();

	[Token(Token = "0x2000041")]
	public delegate void Setter(object value);

	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6114", Offset = "0xDF6114")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InspectorField parent;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x16293B4", Offset = "0x16293B4", VA = "0x16293B4")]
		public <>c__DisplayClass37_0()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6124", Offset = "0xDF6124")]
	private sealed class <>c__DisplayClass37_1
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FieldInfo field;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass37_0 CS$<>8__locals1;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x16293BC", Offset = "0x16293BC", VA = "0x16293BC")]
		public <>c__DisplayClass37_1()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x16296FC", Offset = "0x16296FC", VA = "0x16296FC")]
		internal object <BindTo>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1629738", Offset = "0x1629738", VA = "0x1629738")]
		internal void <BindTo>b__1(object value)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1629770", Offset = "0x1629770", VA = "0x1629770")]
		internal object <BindTo>b__2()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x16297AC", Offset = "0x16297AC", VA = "0x16297AC")]
		internal void <BindTo>b__3(object value)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6134", Offset = "0xDF6134")]
	private sealed class <>c__DisplayClass37_2
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertyInfo property;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass37_0 CS$<>8__locals2;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x16293C4", Offset = "0x16293C4", VA = "0x16293C4")]
		public <>c__DisplayClass37_2()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1629808", Offset = "0x1629808", VA = "0x1629808")]
		internal object <BindTo>b__4()
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1629848", Offset = "0x1629848", VA = "0x1629848")]
		internal void <BindTo>b__5(object value)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x162988C", Offset = "0x162988C", VA = "0x162988C")]
		internal object <BindTo>b__6()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x16298CC", Offset = "0x16298CC", VA = "0x16298CC")]
		internal void <BindTo>b__7(object value)
		{
		}
	}

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RuntimeInspector m_inspector;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_skinVersion;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UISkin m_skin;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Type m_boundVariableType;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private object m_value;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_depth;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected LayoutElement layoutElement;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected Text variableNameText;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image variableNameMask;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Getter getter;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Setter setter;

	[Token(Token = "0x1700003C")]
	public RuntimeInspector Inspector
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1628D9C", Offset = "0x1628D9C", VA = "0x1628D9C")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x161D4F8", Offset = "0x161D4F8", VA = "0x161D4F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public UISkin Skin
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1628DA4", Offset = "0x1628DA4", VA = "0x1628DA4")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x161D5EC", Offset = "0x161D5EC", VA = "0x161D5EC")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	protected Type BoundVariableType
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1628DAC", Offset = "0x1628DAC", VA = "0x1628DAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	protected object Value
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1628DB4", Offset = "0x1628DB4", VA = "0x1628DB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x161B6AC", Offset = "0x161B6AC", VA = "0x161B6AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public int Depth
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1629150", Offset = "0x1629150", VA = "0x1629150")]
		protected get
		{
			return default(int);
		}
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x161D838", Offset = "0x161D838", VA = "0x161D838")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public string Name
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1629158", Offset = "0x1629158", VA = "0x1629158")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1629208", Offset = "0x1629208", VA = "0x1629208")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public string NameRaw
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x16292FC", Offset = "0x16292FC", VA = "0x16292FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x161AEBC", Offset = "0x161AEBC", VA = "0x161AEBC")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	protected virtual float HeightMultiplier
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x16293AC", Offset = "0x16293AC", VA = "0x16293AC", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600011E")]
	public abstract bool SupportsType(Type type);

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x161C43C", Offset = "0x161C43C", VA = "0x161C43C", Slot = "6")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x161D058", Offset = "0x161D058", VA = "0x161D058")]
	public void BindTo(InspectorField parent, MemberInfo member, [Optional] string variableName)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x161AE4C", Offset = "0x161AE4C", VA = "0x161AE4C")]
	public void BindTo(Type variableType, string variableName, Getter getter, Setter setter)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1623F50", Offset = "0x1623F50", VA = "0x1623F50")]
	public void Unbind()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x161A370", Offset = "0x161A370", VA = "0x161A370", Slot = "7")]
	protected virtual void OnBound()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x162395C", Offset = "0x162395C", VA = "0x162395C", Slot = "8")]
	protected virtual void OnUnbound()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x161D4F4", Offset = "0x161D4F4", VA = "0x161D4F4", Slot = "9")]
	protected virtual void OnInspectorChanged()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x161C5AC", Offset = "0x161C5AC", VA = "0x161C5AC", Slot = "10")]
	protected virtual void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x161D760", Offset = "0x161D760", VA = "0x161D760", Slot = "11")]
	protected virtual void OnDepthChanged()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x161C7A4", Offset = "0x161C7A4", VA = "0x161C7A4", Slot = "12")]
	public virtual void Refresh()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x16293CC", Offset = "0x16293CC", VA = "0x16293CC")]
	private void RefreshValue()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x161C7B8", Offset = "0x161C7B8", VA = "0x161C7B8")]
	protected InspectorField()
	{
	}
}
[Token(Token = "0x2000018")]
public abstract class ExpandableInspectorField : InspectorField
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6144", Offset = "0xDF6144")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Component component;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1624330", Offset = "0x1624330", VA = "0x1624330")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1624670", Offset = "0x1624670", VA = "0x1624670")]
		internal object <CreateDrawerForComponent>b__0()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6154", Offset = "0xDF6154")]
	private sealed class <>c
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Setter <>9__22_1;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1624664", Offset = "0x1624664", VA = "0x1624664")]
		public <>c()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x162466C", Offset = "0x162466C", VA = "0x162466C")]
		internal void <CreateDrawerForComponent>b__22_1(object value)
		{
		}
	}

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected RectTransform drawArea;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PointerEventListener expandToggle;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private RectTransform expandToggleTransform;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private LayoutGroup layoutGroup;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image expandArrow;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected List<InspectorField> elements;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<ExposedMethodField> exposedMethods;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool m_isExpanded;

	[Token(Token = "0x17000044")]
	protected virtual int Length
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1623904", Offset = "0x1623904", VA = "0x1623904", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000045")]
	public bool IsExpanded
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1623954", Offset = "0x1623954", VA = "0x1623954")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x161B798", Offset = "0x161B798", VA = "0x161B798")]
		set
		{
		}
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1619F88", Offset = "0x1619F88", VA = "0x1619F88", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x161A3D4", Offset = "0x161A3D4", VA = "0x161A3D4", Slot = "8")]
	protected override void OnUnbound()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x161A508", Offset = "0x161A508", VA = "0x161A508", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x161A800", Offset = "0x161A800", VA = "0x161A800", Slot = "11")]
	protected override void OnDepthChanged()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1623968", Offset = "0x1623968", VA = "0x1623968")]
	protected void RegenerateElements()
	{
	}

	[Token(Token = "0x6000133")]
	protected abstract void GenerateElements();

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1623A64", Offset = "0x1623A64", VA = "0x1623A64")]
	private void GenerateMethods()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1623E40", Offset = "0x1623E40", VA = "0x1623E40", Slot = "15")]
	protected virtual void ClearElements()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1623FBC", Offset = "0x1623FBC", VA = "0x1623FBC", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1624098", Offset = "0x1624098", VA = "0x1624098")]
	protected InspectorField CreateDrawerForComponent(Component component, [Optional] string variableName)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1624338", Offset = "0x1624338", VA = "0x1624338")]
	protected InspectorField CreateDrawerForVariable(MemberInfo variable, [Optional] string variableName)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x16244D4", Offset = "0x16244D4", VA = "0x16244D4")]
	protected InspectorField CreateDrawer(Type variableType, string variableName, Getter getter, Setter setter, bool drawObjectsAsFields = true)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x161BF70", Offset = "0x161BF70", VA = "0x161BF70")]
	protected ExpandableInspectorField()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x16245E0", Offset = "0x16245E0", VA = "0x16245E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F58", Offset = "0xDF6F58")]
	private void <Initialize>b__13_0(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x16245F0", Offset = "0x16245F0", VA = "0x16245F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F68", Offset = "0xDF6F68")]
	private object <GenerateMethods>b__19_0()
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x16245F8", Offset = "0x16245F8", VA = "0x16245F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6F78", Offset = "0xDF6F78")]
	private void <GenerateMethods>b__19_1(object value)
	{
	}
}
[Token(Token = "0x2000019")]
public class IntegerField : InspectorField
{
	[Token(Token = "0x2000047")]
	private struct NumberParser
	{
		[Token(Token = "0x2000054")]
		private delegate bool ParseFunc(string input, out object value);

		[Token(Token = "0x2000055")]
		private delegate bool EqualsFunc(object value1, object value2);

		[Serializable]
		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF61A4", Offset = "0xDF61A4")]
		private sealed class <>c
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static ParseFunc <>9__4_0;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static EqualsFunc <>9__4_1;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static ParseFunc <>9__4_2;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static EqualsFunc <>9__4_3;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static ParseFunc <>9__4_4;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static EqualsFunc <>9__4_5;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static ParseFunc <>9__4_6;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static EqualsFunc <>9__4_7;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static ParseFunc <>9__4_8;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static EqualsFunc <>9__4_9;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static ParseFunc <>9__4_10;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static EqualsFunc <>9__4_11;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static ParseFunc <>9__4_12;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static EqualsFunc <>9__4_13;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static ParseFunc <>9__4_14;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static EqualsFunc <>9__4_15;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static ParseFunc <>9__4_16;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static EqualsFunc <>9__4_17;

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x162B590", Offset = "0x162B590", VA = "0x162B590")]
			public <>c()
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x162B598", Offset = "0x162B598", VA = "0x162B598")]
			internal bool <.ctor>b__4_0(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x162B62C", Offset = "0x162B62C", VA = "0x162B62C")]
			internal bool <.ctor>b__4_1(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x162B6E8", Offset = "0x162B6E8", VA = "0x162B6E8")]
			internal bool <.ctor>b__4_2(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x162B77C", Offset = "0x162B77C", VA = "0x162B77C")]
			internal bool <.ctor>b__4_3(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x162B838", Offset = "0x162B838", VA = "0x162B838")]
			internal bool <.ctor>b__4_4(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x162B8D4", Offset = "0x162B8D4", VA = "0x162B8D4")]
			internal bool <.ctor>b__4_5(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x162B990", Offset = "0x162B990", VA = "0x162B990")]
			internal bool <.ctor>b__4_6(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x162BA2C", Offset = "0x162BA2C", VA = "0x162BA2C")]
			internal bool <.ctor>b__4_7(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x162BAE8", Offset = "0x162BAE8", VA = "0x162BAE8")]
			internal bool <.ctor>b__4_8(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x162BB7C", Offset = "0x162BB7C", VA = "0x162BB7C")]
			internal bool <.ctor>b__4_9(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x162BC38", Offset = "0x162BC38", VA = "0x162BC38")]
			internal bool <.ctor>b__4_10(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x162BCCC", Offset = "0x162BCCC", VA = "0x162BCCC")]
			internal bool <.ctor>b__4_11(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x162BD88", Offset = "0x162BD88", VA = "0x162BD88")]
			internal bool <.ctor>b__4_12(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x162BE1C", Offset = "0x162BE1C", VA = "0x162BE1C")]
			internal bool <.ctor>b__4_13(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x162BED8", Offset = "0x162BED8", VA = "0x162BED8")]
			internal bool <.ctor>b__4_14(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x162BF6C", Offset = "0x162BF6C", VA = "0x162BF6C")]
			internal bool <.ctor>b__4_15(object value1, object value2)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x162C028", Offset = "0x162C028", VA = "0x162C028")]
			internal bool <.ctor>b__4_16(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x162C0D4", Offset = "0x162C0D4", VA = "0x162C0D4")]
			internal bool <.ctor>b__4_17(object value1, object value2)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ParseFunc parseFunction;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly EqualsFunc equalsFunction;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xC44F14", Offset = "0xC44F14", VA = "0xC44F14")]
		public NumberParser(Type fieldType)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xC44F1C", Offset = "0xC44F1C", VA = "0xC44F1C")]
		public bool TryParse(string input, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xC44F34", Offset = "0xC44F34", VA = "0xC44F34")]
		public bool ValuesAreEqual(object value1, object value2)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField input;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private NumberParser parser;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x162999C", Offset = "0x162999C", VA = "0x162999C", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1629A98", Offset = "0x1629A98", VA = "0x1629A98", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1629D78", Offset = "0x1629D78", VA = "0x1629D78", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x162ABEC", Offset = "0x162ABEC", VA = "0x162ABEC")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x162AC58", Offset = "0x162AC58", VA = "0x162AC58", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x162AC88", Offset = "0x162AC88", VA = "0x162AC88", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x162AD08", Offset = "0x162AD08", VA = "0x162AD08")]
	public IntegerField()
	{
	}
}
[Token(Token = "0x200001A")]
public class ObjectField : ExpandableInspectorField
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Button initializeObjectButton;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool elementsInitialized;

	[Token(Token = "0x17000046")]
	protected override int Length
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x162C258", Offset = "0x162C258", VA = "0x162C258", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x162C328", Offset = "0x162C328", VA = "0x162C328", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x162C3C4", Offset = "0x162C3C4", VA = "0x162C3C4", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x162C4B8", Offset = "0x162C4B8", VA = "0x162C4B8", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x162C4C0", Offset = "0x162C4C0", VA = "0x162C4C0", Slot = "14")]
	protected override void GenerateElements()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x162C908", Offset = "0x162C908", VA = "0x162C908", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x162C750", Offset = "0x162C750", VA = "0x162C750")]
	private bool CanInitializeNewObject()
	{
		return default(bool);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x162C934", Offset = "0x162C934", VA = "0x162C934")]
	private void InitializeObject()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x162C9D8", Offset = "0x162C9D8", VA = "0x162C9D8")]
	public ObjectField()
	{
	}
}
[Token(Token = "0x200001B")]
public class ObjectReferenceField : InspectorField, IDropHandler, IEventSystemHandler
{
	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PointerEventListener input;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PointerEventListener inspectReferenceButton;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Image inspectReferenceImage;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected Image background;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected Text referenceNameText;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x162C9DC", Offset = "0x162C9DC", VA = "0x162C9DC", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x162CB24", Offset = "0x162CB24", VA = "0x162CB24", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x162CBB4", Offset = "0x162CBB4", VA = "0x162CBB4")]
	private void ShowReferencePicker(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x162CF48", Offset = "0x162CF48", VA = "0x162CF48")]
	private void InspectReference(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x162D024", Offset = "0x162D024", VA = "0x162D024", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x162D0C4", Offset = "0x162D0C4", VA = "0x162D0C4", Slot = "14")]
	protected virtual void OnReferenceChanged(UnityEngine.Object reference)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x162D2B0", Offset = "0x162D2B0", VA = "0x162D2B0", Slot = "13")]
	public void OnDrop(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x162D390", Offset = "0x162D390", VA = "0x162D390", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x162D5FC", Offset = "0x162D5FC", VA = "0x162D5FC", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x162D6B4", Offset = "0x162D6B4", VA = "0x162D6B4")]
	public ObjectReferenceField()
	{
	}
}
[Token(Token = "0x200001C")]
public class RectField : InspectorField
{
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField inputX;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BoundInputField inputY;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private BoundInputField inputW;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private BoundInputField inputH;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text labelX;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text labelY;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text labelW;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Text labelH;

	[Token(Token = "0x17000047")]
	protected override float HeightMultiplier
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1630028", Offset = "0x1630028", VA = "0x1630028", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1630030", Offset = "0x1630030", VA = "0x1630030", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x16302D0", Offset = "0x16302D0", VA = "0x16302D0", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1630354", Offset = "0x1630354", VA = "0x1630354", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x16304D4", Offset = "0x16304D4", VA = "0x16304D4")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1630698", Offset = "0x1630698", VA = "0x1630698", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1630738", Offset = "0x1630738", VA = "0x1630738", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1630990", Offset = "0x1630990", VA = "0x1630990")]
	public RectField()
	{
	}
}
[Token(Token = "0x200001D")]
public class StringField : InspectorField
{
	[Token(Token = "0x2000048")]
	public enum Mode
	{
		[Token(Token = "0x4000188")]
		OnValueChange,
		[Token(Token = "0x4000189")]
		OnSubmit
	}

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField input;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Mode m_setterMode;

	[Token(Token = "0x17000048")]
	public Mode SetterMode
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x22D9BCC", Offset = "0x22D9BCC", VA = "0x22D9BCC")]
		get
		{
			return default(Mode);
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x22D9BD4", Offset = "0x22D9BD4", VA = "0x22D9BD4")]
		set
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x22D9BDC", Offset = "0x22D9BDC", VA = "0x22D9BDC", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x22D9D4C", Offset = "0x22D9D4C", VA = "0x22D9D4C", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x22D9DD0", Offset = "0x22D9DD0", VA = "0x22D9DD0")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x22D9DF8", Offset = "0x22D9DF8", VA = "0x22D9DF8")]
	private bool OnValueSubmitted(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x22D9E24", Offset = "0x22D9E24", VA = "0x22D9E24", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x22D9E5C", Offset = "0x22D9E5C", VA = "0x22D9E5C", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x22D9EFC", Offset = "0x22D9EFC", VA = "0x22D9EFC")]
	public StringField()
	{
	}
}
[Token(Token = "0x200001E")]
public class TextureReferenceField : ObjectReferenceField
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private RawImage referencePreview;

	[Token(Token = "0x17000049")]
	protected override float HeightMultiplier
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x22D9F04", Offset = "0x22D9F04", VA = "0x22D9F04", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x22D9F0C", Offset = "0x22D9F0C", VA = "0x22D9F0C", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x22D9FFC", Offset = "0x22D9FFC", VA = "0x22D9FFC", Slot = "14")]
	protected override void OnReferenceChanged(UnityEngine.Object reference)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x22DA118", Offset = "0x22DA118", VA = "0x22DA118")]
	public TextureReferenceField()
	{
	}
}
[Token(Token = "0x200001F")]
public class Vector2Field : InspectorField
{
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField inputX;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BoundInputField inputY;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text labelX;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text labelY;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x22DAB34", Offset = "0x22DAB34", VA = "0x22DAB34", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x22DACB8", Offset = "0x22DACB8", VA = "0x22DACB8", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x22DAD3C", Offset = "0x22DAD3C", VA = "0x22DAD3C", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x22DAE40", Offset = "0x22DAE40", VA = "0x22DAE40")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x22DAF64", Offset = "0x22DAF64", VA = "0x22DAF64", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x22DAFC8", Offset = "0x22DAFC8", VA = "0x22DAFC8", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x22DB118", Offset = "0x22DB118", VA = "0x22DB118")]
	public Vector2Field()
	{
	}
}
[Token(Token = "0x2000020")]
public class Vector3Field : InspectorField
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField inputX;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BoundInputField inputY;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private BoundInputField inputZ;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text labelX;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text labelY;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text labelZ;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x22DB120", Offset = "0x22DB120", VA = "0x22DB120", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x22DB328", Offset = "0x22DB328", VA = "0x22DB328", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x22DB3AC", Offset = "0x22DB3AC", VA = "0x22DB3AC", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x22DB4E4", Offset = "0x22DB4E4", VA = "0x22DB4E4")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x22DB658", Offset = "0x22DB658", VA = "0x22DB658", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x22DB6DC", Offset = "0x22DB6DC", VA = "0x22DB6DC", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x22DB870", Offset = "0x22DB870", VA = "0x22DB870")]
	public Vector3Field()
	{
	}
}
[Token(Token = "0x2000021")]
public class Vector4Field : InspectorField
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BoundInputField inputX;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BoundInputField inputY;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private BoundInputField inputZ;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private BoundInputField inputW;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text labelX;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text labelY;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text labelZ;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Text labelW;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool isQuaternion;

	[Token(Token = "0x1700004A")]
	protected override float HeightMultiplier
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x22DB878", Offset = "0x22DB878", VA = "0x22DB878", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x22DB880", Offset = "0x22DB880", VA = "0x22DB880", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x22DBB0C", Offset = "0x22DBB0C", VA = "0x22DBB0C", Slot = "5")]
	public override bool SupportsType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x22DBBF0", Offset = "0x22DBBF0", VA = "0x22DBBF0", Slot = "7")]
	protected override void OnBound()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x22DBDC4", Offset = "0x22DBDC4", VA = "0x22DBDC4")]
	private bool OnValueChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x22DC070", Offset = "0x22DC070", VA = "0x22DC070", Slot = "10")]
	protected override void OnSkinChanged()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x22DC114", Offset = "0x22DC114", VA = "0x22DC114", Slot = "12")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x22DC300", Offset = "0x22DC300", VA = "0x22DC300")]
	public Vector4Field()
	{
	}
}
[Token(Token = "0x2000022")]
public class BoundInputField : MonoBehaviour
{
	[Token(Token = "0x2000049")]
	public delegate bool OnValueChangedDelegate(BoundInputField source, string input);

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool inputValid;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private InputField inputField;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Image inputFieldBackground;

	[NonSerialized]
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string DefaultEmptyValue;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string recentText;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_skinVersion;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UISkin m_skin;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool inputAltered;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public OnValueChangedDelegate OnValueChanged;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public OnValueChangedDelegate OnValueSubmitted;

	[Token(Token = "0x1700004B")]
	public string Text
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x161C7C8", Offset = "0x161C7C8", VA = "0x161C7C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x161A418", Offset = "0x161A418", VA = "0x161A418")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public UISkin Skin
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x161C7E4", Offset = "0x161C7E4", VA = "0x161C7E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x161A674", Offset = "0x161A674", VA = "0x161A674")]
		set
		{
		}
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x161C7EC", Offset = "0x161C7EC", VA = "0x161C7EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x161A070", Offset = "0x161A070", VA = "0x161A070")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x161C7F0", Offset = "0x161C7F0", VA = "0x161C7F0")]
	private void InputFieldValueChanged(string str)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x161CCB0", Offset = "0x161CCB0", VA = "0x161CCB0")]
	private void InputFieldValueSubmitted(string str)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x161CD84", Offset = "0x161CD84", VA = "0x161CD84")]
	public BoundInputField()
	{
	}
}
[Token(Token = "0x2000023")]
public class ColorPicker : SkinnedWindow
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ColorPicker m_instance;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image panel;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ColorWheelControl colorWheel;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ColorPickerAlphaSlider alphaSlider;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text rgbaText;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BoundInputField rInput;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BoundInputField gInput;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BoundInputField bInput;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BoundInputField aInput;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LayoutElement rgbaLayoutElement;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private LayoutElement buttonsLayoutElement;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button cancelButton;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Button okButton;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Color initialValue;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ColorWheelControl.OnColorChangedDelegate onColorChanged;

	[Token(Token = "0x1700004D")]
	public static ColorPicker Instance
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x161DCC4", Offset = "0x161DCC4", VA = "0x161DCC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x161E148", Offset = "0x161E148", VA = "0x161E148", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x161E25C", Offset = "0x161E25C", VA = "0x161E25C")]
	private void Start()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x161DE04", Offset = "0x161DE04", VA = "0x161DE04")]
	public void Show(ColorWheelControl.OnColorChangedDelegate onColorChanged, Color initialColor)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x161E9E0", Offset = "0x161E9E0", VA = "0x161E9E0")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x161ECB4", Offset = "0x161ECB4", VA = "0x161ECB4")]
	public void Close()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x161ECF8", Offset = "0x161ECF8", VA = "0x161ECF8", Slot = "6")]
	protected override void RefreshSkin()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x161E6B0", Offset = "0x161E6B0", VA = "0x161E6B0")]
	private void OnSelectedColorChanged(Color32 color)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x161EE4C", Offset = "0x161EE4C", VA = "0x161EE4C")]
	private void OnAlphaChanged(float alpha)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x161EF1C", Offset = "0x161EF1C", VA = "0x161EF1C")]
	private bool OnRGBAChanged(BoundInputField source, string input)
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x161F11C", Offset = "0x161F11C", VA = "0x161F11C")]
	public ColorPicker()
	{
	}
}
[Token(Token = "0x2000024")]
public class ColorPickerAlphaSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
{
	[Token(Token = "0x200004A")]
	public delegate void OnValueChangedDelegate(float alpha);

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectTransform;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image alphaImage;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform selector;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_value;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OnValueChangedDelegate OnValueChanged;

	[Token(Token = "0x1700004E")]
	public float Value
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x161F124", Offset = "0x161F124", VA = "0x161F124")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x161E958", Offset = "0x161E958", VA = "0x161E958")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public Color Color
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x161F12C", Offset = "0x161F12C", VA = "0x161F12C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x161E930", Offset = "0x161E930", VA = "0x161E930")]
		set
		{
		}
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x161F150", Offset = "0x161F150", VA = "0x161F150")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x161F1D0", Offset = "0x161F1D0", VA = "0x161F1D0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x161F1D4", Offset = "0x161F1D4", VA = "0x161F1D4", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x161F548", Offset = "0x161F548", VA = "0x161F548")]
	public ColorPickerAlphaSlider()
	{
	}
}
[Token(Token = "0x2000025")]
public class DraggedReferenceItem : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
{
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6164", Offset = "0xDF6164")]
	private sealed class <ValidatePointer>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DraggedReferenceItem <>4__this;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <nextValidation>5__2;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1621FC0", Offset = "0x1621FC0", VA = "0x1621FC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1622028", Offset = "0x1622028", VA = "0x1622028", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1621DCC", Offset = "0x1621DCC", VA = "0x1621DCC")]
		[DebuggerHidden]
		public <ValidatePointer>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1621E7C", Offset = "0x1621E7C", VA = "0x1621E7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1621E80", Offset = "0x1621E80", VA = "0x1621E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1621FC8", Offset = "0x1621FC8", VA = "0x1621FC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F7")]
	private const float VALIDATE_INTERVAL = 5f;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectTransform;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera worldCamera;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform canvasTransform;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LayoutElement borderLayoutElement;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image background;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text referenceName;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityEngine.Object m_reference;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PointerEventData draggingPointer;

	[Token(Token = "0x17000050")]
	public UnityEngine.Object Reference
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1621900", Offset = "0x1621900", VA = "0x1621900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1621908", Offset = "0x1621908", VA = "0x1621908")]
	public void Initialize(Canvas canvas, UnityEngine.Object reference, PointerEventData draggingPointer, UISkin skin)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1621D50", Offset = "0x1621D50", VA = "0x1621D50")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF6F88", Offset = "0xDF6F88")]
	private IEnumerator ValidatePointer()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1621C78", Offset = "0x1621C78", VA = "0x1621C78", Slot = "4")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1621DF8", Offset = "0x1621DF8", VA = "0x1621DF8", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1621E74", Offset = "0x1621E74", VA = "0x1621E74")]
	public DraggedReferenceItem()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDF5EC0", Offset = "0xDF5EC0")]
public class DraggedReferenceSourceCamera : MonoBehaviour
{
	[Token(Token = "0x200004C")]
	public delegate UnityEngine.Object RaycastHitProcesserDelegate(RaycastHit hit);

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera _camera;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UISkin draggedReferenceSkin;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float holdTime;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask interactableObjectsMask;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float raycastRange;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool pointerDown;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float pointerDownTime;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector2 pointerDownPos;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityEngine.Object hitObject;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DraggedReferenceItem draggedReference;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private PointerEventData draggingPointer;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RaycastHitProcesserDelegate ProcessRaycastHit;

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1622030", Offset = "0x1622030", VA = "0x1622030")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1622090", Offset = "0x1622090", VA = "0x1622090")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1622C88", Offset = "0x1622C88", VA = "0x1622C88")]
	public DraggedReferenceSourceCamera()
	{
	}
}
[Token(Token = "0x2000027")]
public class DraggedReferenceSourceUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler
{
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6174", Offset = "0xDF6174")]
	private sealed class <CreateReferenceItemCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DraggedReferenceSourceUI <>4__this;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PointerEventData eventData;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <dragThreshold>5__2;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1623180", Offset = "0x1623180", VA = "0x1623180", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x16231E8", Offset = "0x16231E8", VA = "0x16231E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1622F7C", Offset = "0x1622F7C", VA = "0x1622F7C")]
		[DebuggerHidden]
		public <CreateReferenceItemCoroutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1622FBC", Offset = "0x1622FBC", VA = "0x1622FBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1622FC0", Offset = "0x1622FC0", VA = "0x1622FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1623188", Offset = "0x1623188", VA = "0x1623188", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEngine.Object m_reference;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UISkin draggedReferenceSkin;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float holdTime;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator pointerHeldCoroutine;

	[Token(Token = "0x17000051")]
	public UnityEngine.Object Reference
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1622D80", Offset = "0x1622D80", VA = "0x1622D80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1622D88", Offset = "0x1622D88", VA = "0x1622D88")]
		set
		{
		}
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1622D90", Offset = "0x1622D90", VA = "0x1622D90", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1622EEC", Offset = "0x1622EEC", VA = "0x1622EEC", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1622F34", Offset = "0x1622F34", VA = "0x1622F34", Slot = "6")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1622E54", Offset = "0x1622E54", VA = "0x1622E54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF6FEC", Offset = "0xDF6FEC")]
	private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData)
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1622FA8", Offset = "0x1622FA8", VA = "0x1622FA8")]
	public DraggedReferenceSourceUI()
	{
	}
}
[Token(Token = "0x2000028")]
public struct ExposedMethod
{
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly MethodInfo method;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private readonly RuntimeInspectorButtonAttribute properties;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly bool isExtensionMethod;

	[Token(Token = "0x17000052")]
	public string Label
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xC44D70", Offset = "0xC44D70", VA = "0xC44D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public bool IsInitializer
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xC44D8C", Offset = "0xC44D8C", VA = "0xC44D8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000054")]
	public bool VisibleWhenInitialized
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xC44DA8", Offset = "0xC44DA8", VA = "0xC44DA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000055")]
	public bool VisibleWhenUninitialized
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xC44DC8", Offset = "0xC44DC8", VA = "0xC44DC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xC44DE8", Offset = "0xC44DE8", VA = "0xC44DE8")]
	public ExposedMethod(MethodInfo method, RuntimeInspectorButtonAttribute properties, bool isExtensionMethod)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xC44E34", Offset = "0xC44E34", VA = "0xC44E34")]
	public void Call(object source)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xC44E3C", Offset = "0xC44E3C", VA = "0xC44E3C")]
	public object CallAndReturnValue(object source)
	{
		return null;
	}
}
[Token(Token = "0x2000029")]
public struct ExposedExtensionMethodHolder
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public readonly Type extendedType;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public readonly MethodInfo method;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly RuntimeInspectorButtonAttribute properties;

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xC44D2C", Offset = "0xC44D2C", VA = "0xC44D2C")]
	public ExposedExtensionMethodHolder(Type extendedType, MethodInfo method, RuntimeInspectorButtonAttribute properties)
	{
	}
}
[Token(Token = "0x200002A")]
public class ExposedVariablesEnumerator : IEnumerator<MemberInfo>, IEnumerator, IDisposable, IEnumerable<MemberInfo>, IEnumerable
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int index;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MemberInfo[] variables;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<VariableSet> hiddenVariables;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<VariableSet> exposedVariables;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool debugMode;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool exposePrivateFields;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool exposePublicFields;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	private bool exposePrivateProperties;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool exposePublicProperties;

	[Token(Token = "0x17000056")]
	public MemberInfo Current
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1624C00", Offset = "0x1624C00", VA = "0x1624C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000057")]
	private object System.Collections.IEnumerator.Current
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1624C40", Offset = "0x1624C40", VA = "0x1624C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1624C44", Offset = "0x1624C44", VA = "0x1624C44")]
	public ExposedVariablesEnumerator(MemberInfo[] variables, List<VariableSet> hiddenVariables, List<VariableSet> exposedVariables, bool debugMode, bool exposePrivateFields, bool exposePublicFields, bool exposePrivateProperties, bool exposePublicProperties)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1624D08", Offset = "0x1624D08", VA = "0x1624D08", Slot = "5")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1624D0C", Offset = "0x1624D0C", VA = "0x1624D0C", Slot = "9")]
	public IEnumerator<MemberInfo> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1624D10", Offset = "0x1624D10", VA = "0x1624D10", Slot = "10")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1624D14", Offset = "0x1624D14", VA = "0x1624D14", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x16250E8", Offset = "0x16250E8", VA = "0x16250E8", Slot = "8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1624F00", Offset = "0x1624F00", VA = "0x1624F00")]
	private bool IsVariableInExposedVariablesList(string variableName)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1624FC8", Offset = "0x1624FC8", VA = "0x1624FC8")]
	private bool ShouldExposeVariable(MemberInfo variable)
	{
		return default(bool);
	}
}
[Token(Token = "0x200002B")]
public class ObjectReferencePicker : SkinnedWindow, IListViewAdapter
{
	[Token(Token = "0x200004E")]
	public delegate void OnReferenceChanged(UnityEngine.Object reference);

	[Serializable]
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6184", Offset = "0xDF6184")]
	private sealed class <>c
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<UnityEngine.Object> <>9__33_0;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x162F0C4", Offset = "0x162F0C4", VA = "0x162F0C4")]
		public <>c()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x162F0CC", Offset = "0x162F0CC", VA = "0x162F0CC")]
		internal int <GenerateReferenceItems>b__33_0(UnityEngine.Object ref1, UnityEngine.Object ref2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400011F")]
	private const string SPRITE_ATLAS_PREFIX = "SpriteAtlasTexture-";

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ObjectReferencePicker m_instance;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OnReferenceChanged onReferenceChanged;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image panel;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image scrollbar;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private InputField searchBar;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image searchIcon;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image searchBarBackground;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text selectPromptText;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LayoutElement searchBarLayoutElement;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LayoutElement buttonsLayoutElement;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Button cancelButton;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button okButton;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RecycledListView listView;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image listViewBackground;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private ObjectReferencePickerItem referenceItemPrefab;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<UnityEngine.Object> references;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<UnityEngine.Object> filteredReferences;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private UnityEngine.Object initialValue;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private UnityEngine.Object currentlySelectedObject;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ObjectReferencePickerItem currentlySelectedItem;

	[Token(Token = "0x17000058")]
	public static ObjectReferencePicker Instance
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x162CCA8", Offset = "0x162CCA8", VA = "0x162CCA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000059")]
	public int Count
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x162D6C4", Offset = "0x162D6C4", VA = "0x162D6C4", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005A")]
	public float ItemHeight
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x162D714", Offset = "0x162D714", VA = "0x162D714", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x162D734", Offset = "0x162D734", VA = "0x162D734", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x162CDE8", Offset = "0x162CDE8", VA = "0x162CDE8")]
	public void Show(OnReferenceChanged onReferenceChanged, Type referenceType, UnityEngine.Object[] references, UnityEngine.Object initialReference)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x162DD34", Offset = "0x162DD34", VA = "0x162DD34")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x162E15C", Offset = "0x162E15C", VA = "0x162E15C")]
	public void Close()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x162E224", Offset = "0x162E224", VA = "0x162E224", Slot = "6")]
	protected override void RefreshSkin()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x162D960", Offset = "0x162D960", VA = "0x162D960")]
	private void GenerateReferenceItems(UnityEngine.Object[] references, Type referenceType)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x162E8EC", Offset = "0x162E8EC", VA = "0x162E8EC", Slot = "9")]
	public RecycledListItem CreateItem(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x162E5DC", Offset = "0x162E5DC", VA = "0x162E5DC")]
	private void OnSearchTextChanged(string value)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x162EB34", Offset = "0x162EB34", VA = "0x162EB34", Slot = "10")]
	public void SetItemContent(RecycledListItem item)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x162EE70", Offset = "0x162EE70", VA = "0x162EE70", Slot = "11")]
	public void OnItemClicked(RecycledListItem item)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x162EFAC", Offset = "0x162EFAC", VA = "0x162EFAC")]
	public ObjectReferencePicker()
	{
	}
}
[Token(Token = "0x200002C")]
public class ObjectReferencePickerItem : RecycledListItem
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6AF4", Offset = "0xDF6AF4")]
	private UnityEngine.Object <Reference>k__BackingField;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_skinVersion;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UISkin m_skin;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image background;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RawImage texturePreview;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LayoutElement texturePreviewLayoutElement;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text referenceNameText;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool m_isSelected;

	[Token(Token = "0x1700005B")]
	public UnityEngine.Object Reference
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x162F198", Offset = "0x162F198", VA = "0x162F198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7050", Offset = "0xDF7050")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x162F1A0", Offset = "0x162F1A0", VA = "0x162F1A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7060", Offset = "0xDF7060")]
		private set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public UISkin Skin
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x162F1A8", Offset = "0x162F1A8", VA = "0x162F1A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x162E990", Offset = "0x162E990", VA = "0x162E990")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public bool IsSelected
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x162F1B0", Offset = "0x162F1B0", VA = "0x162F1B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x162EDB4", Offset = "0x162EDB4", VA = "0x162EDB4")]
		set
		{
		}
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x162F1B8", Offset = "0x162F1B8", VA = "0x162F1B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x162EC68", Offset = "0x162EC68", VA = "0x162EC68")]
	public void SetContent(UnityEngine.Object reference)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x162F28C", Offset = "0x162F28C", VA = "0x162F28C")]
	public ObjectReferencePickerItem()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x162F29C", Offset = "0x162F29C", VA = "0x162F29C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7070", Offset = "0xDF7070")]
	private void <Awake>b__17_0(PointerEventData eventData)
	{
	}
}
[Token(Token = "0x200002D")]
public class PointerEventListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
{
	[Token(Token = "0x2000050")]
	public delegate void PointerEvent(PointerEventData eventData);

	[Token(Token = "0x14000004")]
	public event PointerEvent PointerDown
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1628380", Offset = "0x1628380", VA = "0x1628380")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7080", Offset = "0xDF7080")]
		add
		{
		}
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x162F358", Offset = "0x162F358", VA = "0x162F358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7090", Offset = "0xDF7090")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event PointerEvent PointerUp
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1628424", Offset = "0x1628424", VA = "0x1628424")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF70A0", Offset = "0xDF70A0")]
		add
		{
		}
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x162F3FC", Offset = "0x162F3FC", VA = "0x162F3FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF70B0", Offset = "0xDF70B0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event PointerEvent PointerClick
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x161D980", Offset = "0x161D980", VA = "0x161D980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF70C0", Offset = "0xDF70C0")]
		add
		{
		}
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x162F4A0", Offset = "0x162F4A0", VA = "0x162F4A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF70D0", Offset = "0xDF70D0")]
		remove
		{
		}
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x162F544", Offset = "0x162F544", VA = "0x162F544", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x162F8E8", Offset = "0x162F8E8", VA = "0x162F8E8", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x162F8F8", Offset = "0x162F8F8", VA = "0x162F8F8", Slot = "6")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x162F908", Offset = "0x162F908", VA = "0x162F908")]
	public PointerEventListener()
	{
	}
}
[Token(Token = "0x200002E")]
public interface IListViewAdapter
{
	[Token(Token = "0x1700005E")]
	int Count
	{
		[Token(Token = "0x60001E3")]
		get;
	}

	[Token(Token = "0x1700005F")]
	float ItemHeight
	{
		[Token(Token = "0x60001E4")]
		get;
	}

	[Token(Token = "0x60001E5")]
	RecycledListItem CreateItem(Transform parent);

	[Token(Token = "0x60001E6")]
	void SetItemContent(RecycledListItem item);

	[Token(Token = "0x60001E7")]
	void OnItemClicked(RecycledListItem item);
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDF5F24", Offset = "0xDF5F24")]
public class RecycledListItem : MonoBehaviour
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6B64", Offset = "0xDF6B64")]
	private object <Tag>k__BackingField;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF6B74", Offset = "0xDF6B74")]
	private int <Position>k__BackingField;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IListViewAdapter adapter;

	[Token(Token = "0x17000060")]
	public object Tag
	{
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x16309A0", Offset = "0x16309A0", VA = "0x16309A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF70E0", Offset = "0xDF70E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x16309A8", Offset = "0x16309A8", VA = "0x16309A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF70F0", Offset = "0xDF70F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public int Position
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x16309B0", Offset = "0x16309B0", VA = "0x16309B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7100", Offset = "0xDF7100")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x16309B8", Offset = "0x16309B8", VA = "0x16309B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7110", Offset = "0xDF7110")]
		set
		{
		}
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x16309C0", Offset = "0x16309C0", VA = "0x16309C0")]
	internal void SetAdapter(IListViewAdapter adapter)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x162F2A0", Offset = "0x162F2A0", VA = "0x162F2A0")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x162F294", Offset = "0x162F294", VA = "0x162F294")]
	public RecycledListItem()
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xDF5F88", Offset = "0xDF5F88")]
public class RecycledListView : MonoBehaviour
{
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform viewportTransform;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform contentTransform;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float itemHeight;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _1OverItemHeight;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float viewportHeight;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, RecycledListItem> items;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Stack<RecycledListItem> pooledItems;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private IListViewAdapter adapter;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isDirty;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int currentTopIndex;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int currentBottomIndex;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x16309C8", Offset = "0x16309C8", VA = "0x16309C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1630A7C", Offset = "0x1630A7C", VA = "0x1630A7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x162D884", Offset = "0x162D884", VA = "0x162D884")]
	public void SetAdapter(IListViewAdapter adapter)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x162E744", Offset = "0x162E744", VA = "0x162E744")]
	public void UpdateList()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x162E3FC", Offset = "0x162E3FC", VA = "0x162E3FC")]
	public void ResetList()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1630F34", Offset = "0x1630F34", VA = "0x1630F34")]
	private void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1630AE8", Offset = "0x1630AE8", VA = "0x1630AE8")]
	private void UpdateItemsInTheList(bool updateAllVisibleItems = false)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1630F40", Offset = "0x1630F40", VA = "0x1630F40")]
	private void CreateItemsBetweenIndices(int topIndex, int bottomIndex)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x16310A4", Offset = "0x16310A4", VA = "0x16310A4")]
	private void CreateItemAtIndex(int index)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1630E6C", Offset = "0x1630E6C", VA = "0x1630E6C")]
	private void DestroyItemsBetweenIndices(int topIndex, int bottomIndex)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1630F8C", Offset = "0x1630F8C", VA = "0x1630F8C")]
	private void UpdateItemContentsBetweenIndices(int topIndex, int bottomIndex)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x163125C", Offset = "0x163125C", VA = "0x163125C")]
	public RecycledListView()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1631314", Offset = "0x1631314", VA = "0x1631314")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDF7120", Offset = "0xDF7120")]
	private void <Start>b__11_0(Vector2 pos)
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xDF5FEC", Offset = "0xDF5FEC")]
public class RuntimeInspectorSettings : ScriptableObject
{
	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InspectorField[] m_standardDrawers;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InspectorField[] m_referenceDrawers;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private VariableSet[] m_hiddenVariables;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private VariableSet[] m_exposedVariables;

	[Token(Token = "0x17000062")]
	public InspectorField[] StandardDrawers
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x22D751C", Offset = "0x22D751C", VA = "0x22D751C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000063")]
	public InspectorField[] ReferenceDrawers
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x22D7524", Offset = "0x22D7524", VA = "0x22D7524")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000064")]
	public VariableSet[] HiddenVariables
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x22D752C", Offset = "0x22D752C", VA = "0x22D752C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public VariableSet[] ExposedVariables
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x22D7534", Offset = "0x22D7534", VA = "0x22D7534")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x22D753C", Offset = "0x22D753C", VA = "0x22D753C")]
	public RuntimeInspectorSettings()
	{
	}
}
[Token(Token = "0x2000032")]
public static class RuntimeInspectorUtils
{
	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, MemberInfo[]> typeToVariables;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<Type, ExposedMethod[]> typeToExposedMethods;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static HashSet<Type> serializableUnityTypes;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<ExposedExtensionMethodHolder> exposedExtensionMethods;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Canvas m_draggedReferenceItemsCanvas;

	[Token(Token = "0x17000066")]
	public static Type ExposedExtensionMethodsHolder
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x22D7544", Offset = "0x22D7544", VA = "0x22D7544")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public static Canvas DraggedReferenceItemsCanvas
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x22D78DC", Offset = "0x22D78DC", VA = "0x22D78DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x22D30A8", Offset = "0x22D30A8", VA = "0x22D30A8")]
	public static bool IsNull(this object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x22D7B34", Offset = "0x22D7B34", VA = "0x22D7B34")]
	public static string ToTitleCase(this string str)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x22D7E68", Offset = "0x22D7E68", VA = "0x22D7E68")]
	public static string GetName(this UnityEngine.Object obj)
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x22D62CC", Offset = "0x22D62CC", VA = "0x22D62CC")]
	public static string GetNameWithType(this object obj, [Optional] Type defaultType)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x22D7F1C", Offset = "0x22D7F1C", VA = "0x22D7F1C")]
	public static Texture GetTexture(this UnityEngine.Object obj)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x22D8024", Offset = "0x22D8024", VA = "0x22D8024")]
	public static Color Tint(this Color color, float tintAmount)
	{
		return default(Color);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x22D8058", Offset = "0x22D8058", VA = "0x22D8058")]
	public static DraggedReferenceItem CreateDraggedReferenceItem(UnityEngine.Object reference, PointerEventData draggingPointer, [Optional] UISkin skin)
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x22D8178", Offset = "0x22D8178", VA = "0x22D8178")]
	public static UnityEngine.Object GetAssignableObjectFromDraggedReferenceItem(PointerEventData draggingPointer, Type assignableType)
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x22D8454", Offset = "0x22D8454", VA = "0x22D8454")]
	private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x22D8570", Offset = "0x22D8570", VA = "0x22D8570")]
	public static bool IsPointerValid(this PointerEventData eventData)
	{
		return default(bool);
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x22D6DB8", Offset = "0x22D6DB8", VA = "0x22D6DB8")]
	public static MemberInfo[] GetAllVariables(this Type type)
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x22D8914", Offset = "0x22D8914", VA = "0x22D8914")]
	public static ExposedMethod[] GetExposedMethods(this Type type)
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x22D8D84", Offset = "0x22D8D84", VA = "0x22D8D84")]
	public static bool ShouldExposeInInspector(this MemberInfo variable, bool debugMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x22D8614", Offset = "0x22D8614", VA = "0x22D8614")]
	private static bool IsSerializable(this Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x22D8F48", Offset = "0x22D8F48", VA = "0x22D8F48")]
	public static object Instantiate(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x22D9154", Offset = "0x22D9154", VA = "0x22D9154")]
	public static Type GetType(string typeName)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x22D75A8", Offset = "0x22D75A8", VA = "0x22D75A8")]
	private static void GetExposedExtensionMethods(Type type)
	{
	}
}
[Serializable]
[Token(Token = "0x2000033")]
public class VariableSet
{
	[Token(Token = "0x4000156")]
	private const string INCLUDE_ALL_VARIABLES = "*";

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_type;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string[] m_variables;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HashSet<string> variables;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x22D589C", Offset = "0x22D589C", VA = "0x22D589C")]
	public bool Init()
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x22DAA38", Offset = "0x22DAA38", VA = "0x22DAA38")]
	private void AddAllVariablesToSet()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x22DAB2C", Offset = "0x22DAB2C", VA = "0x22DAB2C")]
	public VariableSet()
	{
	}
}
[Token(Token = "0x2000034")]
public class WindowDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x400015B")]
	private const int NON_EXISTING_TOUCH = -98456;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectTransform;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int pointerId;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector2 initialTouchPos;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x22DC308", Offset = "0x22DC308", VA = "0x22DC308")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x22DC388", Offset = "0x22DC388", VA = "0x22DC388", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x22DC474", Offset = "0x22DC474", VA = "0x22DC474", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x22DC5CC", Offset = "0x22DC5CC", VA = "0x22DC5CC", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x22DC5FC", Offset = "0x22DC5FC", VA = "0x22DC5FC")]
	public WindowDragHandler()
	{
	}
}
[Token(Token = "0x2000035")]
public static class SkinUtils
{
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x22D987C", Offset = "0x22D987C", VA = "0x22D987C")]
	public static void SetSkinText(this Text text, UISkin skin)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x22D98E0", Offset = "0x22D98E0", VA = "0x22D98E0")]
	public static void SetSkinInputFieldText(this Text text, UISkin skin)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x22D9944", Offset = "0x22D9944", VA = "0x22D9944")]
	public static void SetSkinButtonText(this Text text, UISkin skin)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x22D99A8", Offset = "0x22D99A8", VA = "0x22D99A8")]
	public static void SetSkinButton(this Button button, UISkin skin)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x22D9A38", Offset = "0x22D9A38", VA = "0x22D9A38")]
	public static void SetWidth(this LayoutElement layoutElement, float width)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x22D9A8C", Offset = "0x22D9A8C", VA = "0x22D9A8C")]
	public static void SetHeight(this LayoutElement layoutElement, float height)
	{
	}
}
[Token(Token = "0x2000036")]
public abstract class SkinnedWindow : MonoBehaviour
{
	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UISkin m_skin;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_skinVersion;

	[Token(Token = "0x17000068")]
	public UISkin Skin
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x22D9AE0", Offset = "0x22D9AE0", VA = "0x22D9AE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x22D9AE8", Offset = "0x22D9AE8", VA = "0x22D9AE8")]
		set
		{
		}
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x22D2D3C", Offset = "0x22D2D3C", VA = "0x22D2D3C", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x22D319C", Offset = "0x22D319C", VA = "0x22D319C", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000227")]
	protected abstract void RefreshSkin();

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x22D50F0", Offset = "0x22D50F0", VA = "0x22D50F0")]
	protected SkinnedWindow()
	{
	}
}
[Token(Token = "0x2000037")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xDF6078", Offset = "0xDF6078")]
public class UISkin : ScriptableObject
{
	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_version;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Font m_font;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_fontSize;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int m_lineHeight;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_indentAmount;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color m_windowColor;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Color m_backgroundColor;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private Color m_textColor;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private Color m_scrollbarColor;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private Color m_expandArrowColor;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private Color m_inputFieldNormalBackgroundColor;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	private Color m_inputFieldInvalidBackgroundColor;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private Color m_inputFieldTextColor;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private Color m_toggleCheckmarkColor;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[SerializeField]
	private Color m_buttonBackgroundColor;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private Color m_buttonTextColor;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[SerializeField]
	private Color m_selectedItemBackgroundColor;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[SerializeField]
	private Color m_selectedItemTextColor;

	[Token(Token = "0x17000069")]
	public int Version
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x22DA120", Offset = "0x22DA120", VA = "0x22DA120")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700006A")]
	public Font Font
	{
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x22DA158", Offset = "0x22DA158", VA = "0x22DA158")]
		get
		{
			return null;
		}
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x22DA160", Offset = "0x22DA160", VA = "0x22DA160")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public int FontSize
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x22DA204", Offset = "0x22DA204", VA = "0x22DA204")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x22DA20C", Offset = "0x22DA20C", VA = "0x22DA20C")]
		set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public int LineHeight
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x22DA22C", Offset = "0x22DA22C", VA = "0x22DA22C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x22DA234", Offset = "0x22DA234", VA = "0x22DA234")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public int IndentAmount
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x22DA254", Offset = "0x22DA254", VA = "0x22DA254")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x22DA25C", Offset = "0x22DA25C", VA = "0x22DA25C")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public Color WindowColor
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x22DA27C", Offset = "0x22DA27C", VA = "0x22DA27C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x22DA288", Offset = "0x22DA288", VA = "0x22DA288")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public Color BackgroundColor
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x22DA300", Offset = "0x22DA300", VA = "0x22DA300")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x22DA30C", Offset = "0x22DA30C", VA = "0x22DA30C")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public Color TextColor
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x22DA384", Offset = "0x22DA384", VA = "0x22DA384")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x22DA390", Offset = "0x22DA390", VA = "0x22DA390")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public Color ScrollbarColor
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x22DA408", Offset = "0x22DA408", VA = "0x22DA408")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x22DA414", Offset = "0x22DA414", VA = "0x22DA414")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public Color ExpandArrowColor
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x22DA48C", Offset = "0x22DA48C", VA = "0x22DA48C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x22DA498", Offset = "0x22DA498", VA = "0x22DA498")]
		set
		{
		}
	}

	[Token(Token = "0x17000073")]
	public Color InputFieldNormalBackgroundColor
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x22DA510", Offset = "0x22DA510", VA = "0x22DA510")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x22DA51C", Offset = "0x22DA51C", VA = "0x22DA51C")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public Color InputFieldInvalidBackgroundColor
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x22DA594", Offset = "0x22DA594", VA = "0x22DA594")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x22DA5A0", Offset = "0x22DA5A0", VA = "0x22DA5A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public Color InputFieldTextColor
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x22DA618", Offset = "0x22DA618", VA = "0x22DA618")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x22DA624", Offset = "0x22DA624", VA = "0x22DA624")]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public Color ToggleCheckmarkColor
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x22DA69C", Offset = "0x22DA69C", VA = "0x22DA69C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x22DA6A8", Offset = "0x22DA6A8", VA = "0x22DA6A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public Color ButtonBackgroundColor
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x22DA720", Offset = "0x22DA720", VA = "0x22DA720")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x22DA72C", Offset = "0x22DA72C", VA = "0x22DA72C")]
		set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public Color ButtonTextColor
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x22DA7A4", Offset = "0x22DA7A4", VA = "0x22DA7A4")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x22DA7B0", Offset = "0x22DA7B0", VA = "0x22DA7B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000079")]
	public Color SelectedItemBackgroundColor
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x22DA828", Offset = "0x22DA828", VA = "0x22DA828")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x22DA834", Offset = "0x22DA834", VA = "0x22DA834")]
		set
		{
		}
	}

	[Token(Token = "0x1700007A")]
	public Color SelectedItemTextColor
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x22DA8AC", Offset = "0x22DA8AC", VA = "0x22DA8AC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x22DA8B8", Offset = "0x22DA8B8", VA = "0x22DA8B8")]
		set
		{
		}
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x22DA128", Offset = "0x22DA128", VA = "0x22DA128")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xDF7250", Offset = "0xDF7250")]
	private void Invalidate()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x22DA930", Offset = "0x22DA930", VA = "0x22DA930")]
	public UISkin()
	{
	}
}
