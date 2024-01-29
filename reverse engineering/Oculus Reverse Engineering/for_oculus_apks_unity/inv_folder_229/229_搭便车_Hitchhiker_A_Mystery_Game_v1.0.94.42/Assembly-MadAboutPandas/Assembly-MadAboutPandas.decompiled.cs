using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using MadAboutPandas.Utility;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace MadAboutPandas.Utility
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA78768", Offset = "0xA78768")]
	public class CrossSceneEvent : ScriptableObject
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78938", Offset = "0xA78938")]
		[SerializeField]
		private bool _active;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78984", Offset = "0xA78984")]
		private UnityEvent _onEvent;

		[Token(Token = "0x17000001")]
		public bool IsActive
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x26FDBF4", Offset = "0x26FDBF4", VA = "0x26FDBF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x26FDBFC", Offset = "0x26FDBFC", VA = "0x26FDBFC")]
			set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x26FDBC4", Offset = "0x26FDBC4", VA = "0x26FDBC4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x26FDBD8", Offset = "0x26FDBD8", VA = "0x26FDBD8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x26FDC08", Offset = "0x26FDC08", VA = "0x26FDC08")]
		public void AddListener(UnityAction action)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x26FDC24", Offset = "0x26FDC24", VA = "0x26FDC24")]
		public void RemoveListener(UnityAction action)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x26FDC40", Offset = "0x26FDC40", VA = "0x26FDC40")]
		public void Invoke()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x26FDC68", Offset = "0x26FDC68", VA = "0x26FDC68")]
		public CrossSceneEvent()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class CrossSceneEventListener : MonoBehaviour
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA789D0", Offset = "0xA789D0")]
		[SerializeField]
		private CrossSceneEvent[] _events;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78A1C", Offset = "0xA78A1C")]
		private UnityEvent _onEvent;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x26FDC78", Offset = "0x26FDC78", VA = "0x26FDC78", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x26FDD48", Offset = "0x26FDD48", VA = "0x26FDD48", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x26FDE18", Offset = "0x26FDE18", VA = "0x26FDE18", Slot = "6")]
		protected virtual void OnEvent()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x26FDE5C", Offset = "0x26FDE5C", VA = "0x26FDE5C")]
		public CrossSceneEventListener()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class CrossSceneObject<TInstance, TReference> : MonoBehaviour where TInstance : class where TReference : ICrossSceneReference<TInstance>
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78A68", Offset = "0xA78A68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78A68", Offset = "0xA78A68")]
		[SerializeField]
		protected TReference _crossSceneReference;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IHandle _crossSceneHandle;

		[Token(Token = "0x17000002")]
		public virtual TInstance Instance
		{
			[Token(Token = "0x600000D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000E")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600000F")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000010")]
		public CrossSceneObject()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class CrossSceneReference<TInstance> : ScriptableObject, ICrossSceneReference<TInstance> where TInstance : class
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IHandle _handle;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78AD8", Offset = "0xA78AD8")]
		private UnityEvent <OnRegistered>k__BackingField;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78AE8", Offset = "0xA78AE8")]
		private UnityEvent <OnDeregistered>k__BackingField;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78AF8", Offset = "0xA78AF8")]
		private TInstance <Instance>k__BackingField;

		[Token(Token = "0x17000003")]
		public UnityEvent OnRegistered
		{
			[Token(Token = "0x6000011")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78FEC", Offset = "0xA78FEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000012")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78FFC", Offset = "0xA78FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public UnityEvent OnDeregistered
		{
			[Token(Token = "0x6000013")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7900C", Offset = "0xA7900C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7901C", Offset = "0xA7901C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public TInstance Instance
		{
			[Token(Token = "0x6000015")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7902C", Offset = "0xA7902C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7903C", Offset = "0xA7903C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool IsRegistered
		{
			[Token(Token = "0x6000017")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000018")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000019")]
		public IHandle Register(TInstance instance, [Optional] IHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		public bool CheckHandle(IHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		public bool Deregister(IHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		public CrossSceneReference()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public interface ICrossSceneReference<TInstance> where TInstance : class
	{
		[Token(Token = "0x17000007")]
		UnityEvent OnRegistered
		{
			[Token(Token = "0x600001D")]
			get;
		}

		[Token(Token = "0x17000008")]
		UnityEvent OnDeregistered
		{
			[Token(Token = "0x600001E")]
			get;
		}

		[Token(Token = "0x17000009")]
		TInstance Instance
		{
			[Token(Token = "0x600001F")]
			get;
		}

		[Token(Token = "0x1700000A")]
		bool IsRegistered
		{
			[Token(Token = "0x6000020")]
			get;
		}

		[Token(Token = "0x6000021")]
		IHandle Register(TInstance instance, [Optional] IHandle handle);

		[Token(Token = "0x6000022")]
		bool CheckHandle(IHandle handle);

		[Token(Token = "0x6000023")]
		bool Deregister(IHandle handle);
	}
	[Token(Token = "0x2000007")]
	public class Handle : IHandle
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x26FDEFC", Offset = "0x26FDEFC", VA = "0x26FDEFC")]
		public Handle()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA787C8", Offset = "0xA787C8")]
	public class HandleAsset : ScriptableObject, IHandle
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x26FDF04", Offset = "0x26FDF04", VA = "0x26FDF04")]
		public HandleAsset()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public interface IHandle
	{
	}
}
namespace MadAboutPandas.UI
{
	[Token(Token = "0x200000A")]
	public class MultiGraphicsButton : Button
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78B08", Offset = "0xA78B08")]
		[SerializeField]
		protected Graphic[] _additionalGraphics;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x26FE7CC", Offset = "0x26FE7CC", VA = "0x26FE7CC", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x26FE8D8", Offset = "0x26FE8D8", VA = "0x26FE8D8")]
		private void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x26FE870", Offset = "0x26FE870", VA = "0x26FE870")]
		private Color GetStateColor(SelectionState state)
		{
			return default(Color);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x26FEA84", Offset = "0x26FEA84", VA = "0x26FEA84")]
		public MultiGraphicsButton()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class RectTransformUtility
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] rectCorners;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x26FEAEC", Offset = "0x26FEAEC", VA = "0x26FEAEC")]
		public static Rect RectTransformToWorldRect(RectTransform rectTransform)
		{
			return default(Rect);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x26FEC28", Offset = "0x26FEC28", VA = "0x26FEC28")]
		public static Rect RectTransformToLocalRect(RectTransform rectTransform)
		{
			return default(Rect);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x26FED00", Offset = "0x26FED00", VA = "0x26FED00")]
		public static Rect RectTransformToRelativeRect(RectTransform childTransform, RectTransform parentTransform)
		{
			return default(Rect);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x26FEE34", Offset = "0x26FEE34", VA = "0x26FEE34")]
		public static float GetScaleToFitRectTransform(RectTransform srcTransform, RectTransform dstTransform)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200000C")]
	public static class ScrollRectUtility
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x26FEFA0", Offset = "0x26FEFA0", VA = "0x26FEFA0")]
		public static Rect TrimContentRect(Vector2 contentPivot, Rect viewportRect, Rect contentRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x26FF07C", Offset = "0x26FF07C", VA = "0x26FF07C")]
		public static Rect TrimContentRect(Vector2 contentPivot, RectTransform viewportTrans, RectTransform contentTrans)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x26FF150", Offset = "0x26FF150", VA = "0x26FF150")]
		public static Rect TrimContentRect(ScrollRect scrollRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x26FF18C", Offset = "0x26FF18C", VA = "0x26FF18C")]
		public static Vector2 DenormalizePosition(Vector2 normalizedPosition, Rect trimmedRect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x26FF218", Offset = "0x26FF218", VA = "0x26FF218")]
		public static Vector2 DenormalizePosition(ScrollRect scrollRect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x26FF27C", Offset = "0x26FF27C", VA = "0x26FF27C")]
		public static Vector2 NormalizePosition(Vector2 denormalizedPosition, Rect trimmedRect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x26FF334", Offset = "0x26FF334", VA = "0x26FF334")]
		public static Vector2 NormalizePosition(Vector2 denormalizedPosition, ScrollRect scrollRect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x26FF380", Offset = "0x26FF380", VA = "0x26FF380")]
		public static Vector2 GetNormalizedTileOffset(Vector2 scrollAmount, Vector2 tileCount, ScrollRect scrollRect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x26FF46C", Offset = "0x26FF46C", VA = "0x26FF46C")]
		public static void ScrollTiledList(Vector2 scrollAmount, Vector2 tileCount, ScrollRect scrollRect)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x26FF518", Offset = "0x26FF518", VA = "0x26FF518")]
		public static void ScrollListToSelection(RectTransform selectionTrans, ScrollRect scrollRect)
		{
		}
	}
}
namespace MadAboutPandas.ScreenFlow
{
	[Token(Token = "0x200000D")]
	public class CanvasScreen : CrossSceneObject<IScreen, CrossSceneScreen>, IScreen
	{
		[Token(Token = "0x200000E")]
		public enum InitialVisibility
		{
			[Token(Token = "0x4000019")]
			Auto,
			[Token(Token = "0x400001A")]
			Visible,
			[Token(Token = "0x400001B")]
			HideOnAwake,
			[Token(Token = "0x400001C")]
			HideOnStart,
			[Token(Token = "0x400001D")]
			HideOnSecondUpdate
		}

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78B54", Offset = "0xA78B54")]
		[SerializeField]
		private Canvas exclusiveParentCanvas;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78BA0", Offset = "0xA78BA0")]
		[SerializeField]
		public bool isManaged;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool useLazyInit;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78BFC", Offset = "0xA78BFC")]
		[SerializeField]
		protected bool _autoFitToParent;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78C48", Offset = "0xA78C48")]
		protected InitialVisibility _initialVisibility;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78C94", Offset = "0xA78C94")]
		[SerializeField]
		protected RectTransform _subScreenParent;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _updateCounter;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78CE0", Offset = "0xA78CE0")]
		private RectTransform <RectTransform>k__BackingField;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78CF0", Offset = "0xA78CF0")]
		private Transform <Transform>k__BackingField;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78D00", Offset = "0xA78D00")]
		private IScreenFader <ScreenFader>k__BackingField;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool isInitialized_Internal;

		[Token(Token = "0x1700000B")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x26FC6D0", Offset = "0x26FC6D0", VA = "0x26FC6D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7904C", Offset = "0xA7904C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x26FC6D8", Offset = "0x26FC6D8", VA = "0x26FC6D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7905C", Offset = "0xA7905C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Transform Transform
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x26FC6E0", Offset = "0x26FC6E0", VA = "0x26FC6E0", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7906C", Offset = "0xA7906C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x26FC6E8", Offset = "0x26FC6E8", VA = "0x26FC6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7907C", Offset = "0xA7907C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public IScreenFader ScreenFader
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x26FC6F0", Offset = "0x26FC6F0", VA = "0x26FC6F0", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7908C", Offset = "0xA7908C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x26FC6F8", Offset = "0x26FC6F8", VA = "0x26FC6F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7909C", Offset = "0xA7909C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public CrossSceneScreen CrossSceneScreen
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x26FC700", Offset = "0x26FC700", VA = "0x26FC700", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public bool IsVisible
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x26FC708", Offset = "0x26FC708", VA = "0x26FC708", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsFading
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x26FC8F0", Offset = "0x26FC8F0", VA = "0x26FC8F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x26FC320", Offset = "0x26FC320", VA = "0x26FC320", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x26FC3F8", Offset = "0x26FC3F8", VA = "0x26FC3F8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x26FC648", Offset = "0x26FC648", VA = "0x26FC648")]
		private void Start()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x26FC65C", Offset = "0x26FC65C", VA = "0x26FC65C", Slot = "13")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x26FC684", Offset = "0x26FC684", VA = "0x26FC684", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x26FC72C", Offset = "0x26FC72C", VA = "0x26FC72C")]
		private void Init_Internal()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x26FC598", Offset = "0x26FC598", VA = "0x26FC598")]
		private void Show_Internal()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x26FC5F0", Offset = "0x26FC5F0", VA = "0x26FC5F0")]
		private void Hide_Internal()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x26FC774", Offset = "0x26FC774", VA = "0x26FC774", Slot = "14")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x26FC778", Offset = "0x26FC778", VA = "0x26FC778", Slot = "15")]
		public virtual void Show()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x26FC834", Offset = "0x26FC834", VA = "0x26FC834", Slot = "16")]
		public virtual void Hide()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x26FC450", Offset = "0x26FC450", VA = "0x26FC450")]
		public void FitToParent()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x26FCA94", Offset = "0x26FCA94", VA = "0x26FCA94")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x26FCC7C", Offset = "0x26FCC7C", VA = "0x26FCC7C")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x26FCE64", Offset = "0x26FCE64", VA = "0x26FCE64")]
		public void SetSubScreenParent(RectTransform subScreenParent)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x26FCEA8", Offset = "0x26FCEA8", VA = "0x26FCEA8")]
		public CanvasScreen()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA78828", Offset = "0xA78828")]
	public class GenericScreenFader
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78D10", Offset = "0xA78D10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78D10", Offset = "0xA78D10")]
		protected float fadeDuration;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78D80", Offset = "0xA78D80")]
		[SerializeField]
		protected bool resetFadeLevel;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected IScreen screen;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78DCC", Offset = "0xA78DCC")]
		private float <CurrentFadeLevel>k__BackingField;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78DDC", Offset = "0xA78DDC")]
		private float <TargetFadeLevel>k__BackingField;

		[Token(Token = "0x17000011")]
		public float CurrentFadeLevel
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x26FDEB0", Offset = "0x26FDEB0", VA = "0x26FDEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA790AC", Offset = "0xA790AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x26FDEB8", Offset = "0x26FDEB8", VA = "0x26FDEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA790BC", Offset = "0xA790BC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float TargetFadeLevel
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x26FDEC0", Offset = "0x26FDEC0", VA = "0x26FDEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA790CC", Offset = "0xA790CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x26FDEC8", Offset = "0x26FDEC8", VA = "0x26FDEC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA790DC", Offset = "0xA790DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsFading
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x26FDED0", Offset = "0x26FDED0", VA = "0x26FDED0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x26FDEE0", Offset = "0x26FDEE0", VA = "0x26FDEE0")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x26FDEE4", Offset = "0x26FDEE4", VA = "0x26FDEE4")]
		public GenericScreenFader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class CanvasScreenGroup : CrossSceneObject<IScreen, CrossSceneScreen>
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78DEC", Offset = "0xA78DEC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78DEC", Offset = "0xA78DEC")]
		[SerializeField]
		protected ScreenGroupBreakdown _breakdown;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78E5C", Offset = "0xA78E5C")]
		protected List<CanvasScreen> _screens;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78EA8", Offset = "0xA78EA8")]
		[SerializeField]
		protected List<CanvasScreenGroup> _groups;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78EF4", Offset = "0xA78EF4")]
		protected ScreenGroup<IScreen> screenGroup;

		[Token(Token = "0x17000014")]
		public ScreenGroup<IScreen> ScreenGroup
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x26FCF00", Offset = "0x26FCF00", VA = "0x26FCF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x26FCF08", Offset = "0x26FCF08", VA = "0x26FCF08")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public override IScreen Instance
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x26FD0E0", Offset = "0x26FD0E0", VA = "0x26FD0E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x26FCF10", Offset = "0x26FCF10", VA = "0x26FCF10", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x26FD094", Offset = "0x26FD094", VA = "0x26FD094", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x26FD0E8", Offset = "0x26FD0E8", VA = "0x26FD0E8")]
		public void ShowAll()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x26FD13C", Offset = "0x26FD13C", VA = "0x26FD13C")]
		public void HideAll()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x26FD190", Offset = "0x26FD190", VA = "0x26FD190")]
		public void ShowExclusive(CanvasScreen screen)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x26FD1F4", Offset = "0x26FD1F4", VA = "0x26FD1F4")]
		public void HideExclusive(CanvasScreen screen)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x26FD258", Offset = "0x26FD258", VA = "0x26FD258")]
		public void ShowGroupExclusive(CanvasScreenGroup group)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x26FD2C0", Offset = "0x26FD2C0", VA = "0x26FD2C0")]
		public void HideGroupExclusive(CanvasScreenGroup group)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x26FD328", Offset = "0x26FD328", VA = "0x26FD328")]
		public void FadeInAll()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x26FD37C", Offset = "0x26FD37C", VA = "0x26FD37C")]
		public void FadeOutAll()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x26FD3D0", Offset = "0x26FD3D0", VA = "0x26FD3D0")]
		public void FadeInExclusive(CanvasScreen screen)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x26FD434", Offset = "0x26FD434", VA = "0x26FD434")]
		public void FadeOutExclusive(CanvasScreen screen)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x26FD498", Offset = "0x26FD498", VA = "0x26FD498")]
		public void FadeInGroupExclusive(CanvasScreenGroup group)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x26FD500", Offset = "0x26FD500", VA = "0x26FD500")]
		public void FadeOutGroupExclusive(CanvasScreenGroup group)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x26FD568", Offset = "0x26FD568", VA = "0x26FD568")]
		public CanvasScreenGroup()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class CanvasScreenHistory : MonoBehaviour
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected List<CanvasScreen> _startScreens;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ScreenHistory<IScreen> _screenHistory;

		[Token(Token = "0x17000016")]
		public ScreenHistory<IScreen> ScreenHistory
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x26FD698", Offset = "0x26FD698", VA = "0x26FD698")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x26FD6A0", Offset = "0x26FD6A0", VA = "0x26FD6A0")]
			set
			{
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x26FD6A8", Offset = "0x26FD6A8", VA = "0x26FD6A8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x26FD7B0", Offset = "0x26FD7B0", VA = "0x26FD7B0")]
		public void Clear()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x26FD804", Offset = "0x26FD804", VA = "0x26FD804")]
		public void ClearFade()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x26FD858", Offset = "0x26FD858", VA = "0x26FD858")]
		public void Push(CanvasScreenGroup group)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x26FD8C0", Offset = "0x26FD8C0", VA = "0x26FD8C0")]
		public void PushFade(CanvasScreenGroup group)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x26FD928", Offset = "0x26FD928", VA = "0x26FD928")]
		public void PushScreen(CanvasScreen screen)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x26FD98C", Offset = "0x26FD98C", VA = "0x26FD98C")]
		public void PushScreenFade(CanvasScreen screen)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x26FD9F0", Offset = "0x26FD9F0", VA = "0x26FD9F0")]
		public void Pop()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x26FDA44", Offset = "0x26FDA44", VA = "0x26FDA44")]
		public void PopFade()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x26FDA98", Offset = "0x26FDA98", VA = "0x26FDA98")]
		public void Restore()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x26FDAEC", Offset = "0x26FDAEC", VA = "0x26FDAEC")]
		public void RestoreFade()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x26FDB40", Offset = "0x26FDB40", VA = "0x26FDB40")]
		public CanvasScreenHistory()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA78888", Offset = "0xA78888")]
	public class CrossSceneScreen : CrossSceneReference<IScreen>
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x26FDE64", Offset = "0x26FDE64", VA = "0x26FDE64")]
		public CrossSceneScreen()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class ImposterScreen : MonoBehaviour, IScreen, IScreenFader
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA78F3C", Offset = "0xA78F3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA78F3C", Offset = "0xA78F3C")]
		protected CrossSceneScreen _crossSceneScreen;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78FAC", Offset = "0xA78FAC")]
		private IScreen <Screen>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool IsRegistered
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x26FDF0C", Offset = "0x26FDF0C", VA = "0x26FDF0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public IScreen Screen
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x26FDFB4", Offset = "0x26FDFB4", VA = "0x26FDFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA790EC", Offset = "0xA790EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x26FDFBC", Offset = "0x26FDFBC", VA = "0x26FDFBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA790FC", Offset = "0xA790FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool HasScreen
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x26FDFC4", Offset = "0x26FDFC4", VA = "0x26FDFC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public bool IsFading
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x26FE264", Offset = "0x26FE264", VA = "0x26FE264", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public Transform Transform
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x26FE3B4", Offset = "0x26FE3B4", VA = "0x26FE3B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public IScreenFader ScreenFader
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x26FE46C", Offset = "0x26FE46C", VA = "0x26FE46C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public CrossSceneScreen CrossSceneScreen
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x26FE528", Offset = "0x26FE528", VA = "0x26FE528", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public bool IsVisible
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x26FE530", Offset = "0x26FE530", VA = "0x26FE530", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x26FDFD4", Offset = "0x26FDFD4", VA = "0x26FDFD4", Slot = "13")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x26FE180", Offset = "0x26FE180", VA = "0x26FE180", Slot = "14")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x26FE26C", Offset = "0x26FE26C", VA = "0x26FE26C", Slot = "11")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x26FE384", Offset = "0x26FE384", VA = "0x26FE384", Slot = "12")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x26FE5EC", Offset = "0x26FE5EC", VA = "0x26FE5EC", Slot = "8")]
		public void Show()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x26FE6A8", Offset = "0x26FE6A8", VA = "0x26FE6A8", Slot = "9")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x26FE29C", Offset = "0x26FE29C", VA = "0x26FE29C")]
		private void ShowError()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x26FE764", Offset = "0x26FE764", VA = "0x26FE764", Slot = "15")]
		protected virtual void ApplyScreen()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x26FE7B8", Offset = "0x26FE7B8", VA = "0x26FE7B8", Slot = "16")]
		protected virtual void ClearScreen()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x26FE7C4", Offset = "0x26FE7C4", VA = "0x26FE7C4")]
		public ImposterScreen()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public interface IScreen
	{
		[Token(Token = "0x1700001F")]
		Transform Transform
		{
			[Token(Token = "0x600008D")]
			get;
		}

		[Token(Token = "0x17000020")]
		IScreenFader ScreenFader
		{
			[Token(Token = "0x600008E")]
			get;
		}

		[Token(Token = "0x17000021")]
		CrossSceneScreen CrossSceneScreen
		{
			[Token(Token = "0x600008F")]
			get;
		}

		[Token(Token = "0x17000022")]
		bool IsVisible
		{
			[Token(Token = "0x6000090")]
			get;
		}

		[Token(Token = "0x6000091")]
		void Show();

		[Token(Token = "0x6000092")]
		void Hide();
	}
	[Token(Token = "0x2000015")]
	public interface IScreenFader
	{
		[Token(Token = "0x17000023")]
		bool IsFading
		{
			[Token(Token = "0x6000093")]
			get;
		}

		[Token(Token = "0x6000094")]
		void FadeIn();

		[Token(Token = "0x6000095")]
		void FadeOut();
	}
	[Token(Token = "0x2000016")]
	public static class ScreenFaderUtility
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x26FC8F4", Offset = "0x26FC8F4", VA = "0x26FC8F4")]
		public static bool IsFading(IScreen screen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x26FCA98", Offset = "0x26FCA98", VA = "0x26FCA98")]
		public static bool FadeInOrShow(IScreen screen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x26FCC80", Offset = "0x26FCC80", VA = "0x26FCC80")]
		public static bool FadeOutOrHide(IScreen screen)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000017")]
	public enum ScreenGroupBreakdown
	{
		[Token(Token = "0x400002C")]
		ParentsOnly,
		[Token(Token = "0x400002D")]
		ChildrenOnly
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class ScreenGroup<TScreen> : IScreen, IScreenFader where TScreen : class, IScreen
	{
		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA788E8", Offset = "0xA788E8")]
		private sealed class <EnumerateScreens>d__23 : IEnumerator<TScreen>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TScreen <>2__current;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ScreenGroup<TScreen> <>4__this;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<TScreen> <e>5__3;

			[Token(Token = "0x1700002B")]
			private TScreen System.Collections.Generic.IEnumerator<TScreen>.Current
			{
				[Token(Token = "0x60000B6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B3")]
			[DebuggerHidden]
			public <EnumerateScreens>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60000B4")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B5")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B7")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA788F8", Offset = "0xA788F8")]
		private sealed class <EnumerateScreens>d__24 : IEnumerator<TScreen>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TScreen <>2__current;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ScreenGroup<TScreen> <>4__this;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool visible;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<TScreen> <e>5__2;

			[Token(Token = "0x1700002D")]
			private TScreen System.Collections.Generic.IEnumerator<TScreen>.Current
			{
				[Token(Token = "0x60000BC")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BE")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B9")]
			[DebuggerHidden]
			public <EnumerateScreens>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60000BA")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BB")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BD")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78908", Offset = "0xA78908")]
		private sealed class <EnumerateScreensExcluding>d__25 : IEnumerator<TScreen>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TScreen <>2__current;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ScreenGroup<TScreen> <>4__this;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TScreen screen;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<TScreen> <e>5__2;

			[Token(Token = "0x1700002F")]
			private TScreen System.Collections.Generic.IEnumerator<TScreen>.Current
			{
				[Token(Token = "0x60000C2")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BF")]
			[DebuggerHidden]
			public <EnumerateScreensExcluding>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x60000C0")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C1")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C3")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78918", Offset = "0xA78918")]
		private sealed class <EnumerateScreensExcluding>d__26 : IEnumerator<TScreen>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TScreen <>2__current;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ScreenGroup<TScreen> <>4__this;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool visible;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TScreen screen;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<TScreen> <e>5__2;

			[Token(Token = "0x17000031")]
			private TScreen System.Collections.Generic.IEnumerator<TScreen>.Current
			{
				[Token(Token = "0x60000C8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000032")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CA")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C5")]
			[DebuggerHidden]
			public <EnumerateScreensExcluding>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60000C6")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C7")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C9")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78FBC", Offset = "0xA78FBC")]
		private List<TScreen> <Screens>k__BackingField;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78FCC", Offset = "0xA78FCC")]
		private ScreenGroupBreakdown <Breakdown>k__BackingField;

		[Token(Token = "0x17000024")]
		public List<TScreen> Screens
		{
			[Token(Token = "0x6000099")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7910C", Offset = "0xA7910C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7911C", Offset = "0xA7911C")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public ScreenGroupBreakdown Breakdown
		{
			[Token(Token = "0x600009B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7912C", Offset = "0xA7912C")]
			get
			{
				return default(ScreenGroupBreakdown);
			}
			[Token(Token = "0x600009C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7913C", Offset = "0xA7913C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform Transform
		{
			[Token(Token = "0x600009D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public IScreenFader ScreenFader
		{
			[Token(Token = "0x600009E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public CrossSceneScreen CrossSceneScreen
		{
			[Token(Token = "0x600009F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsVisible
		{
			[Token(Token = "0x60000A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public bool IsFading
		{
			[Token(Token = "0x60000A5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A0")]
		public void Show()
		{
		}

		[Token(Token = "0x60000A1")]
		public void Hide()
		{
		}

		[Token(Token = "0x60000A2")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x60000A3")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x60000A6")]
		public ScreenGroup()
		{
		}

		[Token(Token = "0x60000A7")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7914C", Offset = "0xA7914C")]
		public IEnumerator<TScreen> EnumerateScreens()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA791AC", Offset = "0xA791AC")]
		public IEnumerator<TScreen> EnumerateScreens(bool visible)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7920C", Offset = "0xA7920C")]
		public IEnumerator<TScreen> EnumerateScreensExcluding(TScreen screen)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7926C", Offset = "0xA7926C")]
		public IEnumerator<TScreen> EnumerateScreensExcluding(TScreen screen, bool visible)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		public void ShowAll()
		{
		}

		[Token(Token = "0x60000AC")]
		public void HideAll()
		{
		}

		[Token(Token = "0x60000AD")]
		public void ShowExclusive(TScreen screen)
		{
		}

		[Token(Token = "0x60000AE")]
		public void HideExclusive(TScreen screen)
		{
		}

		[Token(Token = "0x60000AF")]
		public void FadeInAll()
		{
		}

		[Token(Token = "0x60000B0")]
		public void FadeOutAll()
		{
		}

		[Token(Token = "0x60000B1")]
		public void FadeInExclusive(TScreen screen)
		{
		}

		[Token(Token = "0x60000B2")]
		public void FadeOutExclusive(TScreen screen)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ScreenHistory<TScreen> : IScreen, IScreenFader where TScreen : class, IScreen
	{
		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78928", Offset = "0xA78928")]
		private sealed class <EnumerateScreens>d__19 : IEnumerator<TScreen>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TScreen <>2__current;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ScreenHistory<TScreen> <>4__this;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x1700003A")]
			private TScreen System.Collections.Generic.IEnumerator<TScreen>.Current
			{
				[Token(Token = "0x60000E5")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E2")]
			[DebuggerHidden]
			public <EnumerateScreens>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60000E3")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E4")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E6")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA78FDC", Offset = "0xA78FDC")]
		private List<TScreen> <Screens>k__BackingField;

		[Token(Token = "0x17000033")]
		public List<TScreen> Screens
		{
			[Token(Token = "0x60000CB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7940C", Offset = "0xA7940C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7941C", Offset = "0xA7941C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Transform Transform
		{
			[Token(Token = "0x60000CD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IScreenFader ScreenFader
		{
			[Token(Token = "0x60000CE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public CrossSceneScreen CrossSceneScreen
		{
			[Token(Token = "0x60000CF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public bool IsVisible
		{
			[Token(Token = "0x60000D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsFading
		{
			[Token(Token = "0x60000D3")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public TScreen TopScreen
		{
			[Token(Token = "0x60000D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D1")]
		public void Show()
		{
		}

		[Token(Token = "0x60000D2")]
		public void Hide()
		{
		}

		[Token(Token = "0x60000D4")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x60000D5")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x60000D6")]
		public TScreen GetScreen(int offsetFromTop)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7942C", Offset = "0xA7942C")]
		public IEnumerator<TScreen> EnumerateScreens()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		public ScreenHistory()
		{
		}

		[Token(Token = "0x60000DA")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000DB")]
		public void ClearFade()
		{
		}

		[Token(Token = "0x60000DC")]
		public void Push(TScreen screen)
		{
		}

		[Token(Token = "0x60000DD")]
		public void PushFade(TScreen screen)
		{
		}

		[Token(Token = "0x60000DE")]
		public void Pop()
		{
		}

		[Token(Token = "0x60000DF")]
		public void PopFade()
		{
		}

		[Token(Token = "0x60000E0")]
		public void Restore()
		{
		}

		[Token(Token = "0x60000E1")]
		public void RestoreFade()
		{
		}
	}
}
