using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Animancer;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using DG.Tweening;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Pico.Platform;
using Pico.Platform.Models;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9814", Offset = "0x6D9814")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xCC193C", Offset = "0xCC193C", VA = "0xCC193C")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D984C", Offset = "0x6D984C")]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xFC2BBC", Offset = "0xFC2BBC", VA = "0xFC2BBC")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
public class BehaviorSelection : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	private enum BehaviorSelectionType
	{
		[Token(Token = "0x4000014")]
		MoveTowards,
		[Token(Token = "0x4000015")]
		RotateTowards,
		[Token(Token = "0x4000016")]
		Seek,
		[Token(Token = "0x4000017")]
		Flee,
		[Token(Token = "0x4000018")]
		Pursue,
		[Token(Token = "0x4000019")]
		Evade,
		[Token(Token = "0x400001A")]
		Follow,
		[Token(Token = "0x400001B")]
		Patrol,
		[Token(Token = "0x400001C")]
		Cover,
		[Token(Token = "0x400001D")]
		Wander,
		[Token(Token = "0x400001E")]
		Search,
		[Token(Token = "0x400001F")]
		WithinDistance,
		[Token(Token = "0x4000020")]
		CanSeeObject,
		[Token(Token = "0x4000021")]
		CanHearObject,
		[Token(Token = "0x4000022")]
		Flock,
		[Token(Token = "0x4000023")]
		LeaderFollow,
		[Token(Token = "0x4000024")]
		Queue,
		[Token(Token = "0x4000025")]
		Last
	}

	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9884", Offset = "0x6D9884")]
	private sealed class <EnableBehavior>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviorSelection <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x18DDD70", Offset = "0x18DDD70", VA = "0x18DDD70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x18DDDB8", Offset = "0x18DDDB8", VA = "0x18DDDB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x18DDC38", Offset = "0x18DDC38", VA = "0x18DDC38")]
		[DebuggerHidden]
		public <EnableBehavior>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x18DDC64", Offset = "0x18DDC64", VA = "0x18DDC64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x18DDC68", Offset = "0x18DDC68", VA = "0x18DDC68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x18DDD78", Offset = "0x18DDD78", VA = "0x18DDD78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject marker;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject mainBot;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject flockGroup;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject followGroup;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject queueGroup;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] waypoints;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] waypointsA;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GUISkin descriptionGUISkin;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3[] flockGroupPosition;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] followGroupPosition;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] queueGroupPosition;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Quaternion[] flockGroupRotation;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion[] followGroupRotation;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Quaternion[] queueGroupRotation;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<int, BehaviorTree> behaviorTreeGroup;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Animation markerAnimation;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private BehaviorSelectionType selectionType;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private BehaviorSelectionType prevSelectionType;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x111B074", Offset = "0x111B074", VA = "0x111B074")]
	public void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x111C2BC", Offset = "0x111C2BC", VA = "0x111C2BC")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x111C9B4", Offset = "0x111C9B4", VA = "0x111C9B4")]
	private string Description()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x111C870", Offset = "0x111C870", VA = "0x111C870")]
	private static string SplitCamelCase(string s)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x111B750", Offset = "0x111B750", VA = "0x111B750")]
	private void SelectionChanged()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x111CAE4", Offset = "0x111CAE4", VA = "0x111CAE4")]
	private void DisableAll()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x111D040", Offset = "0x111D040", VA = "0x111D040")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F89C4", Offset = "0x6F89C4")]
	private IEnumerator EnableBehavior()
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x111D0B8", Offset = "0x111D0B8", VA = "0x111D0B8")]
	public BehaviorSelection()
	{
	}
}
[Token(Token = "0x2000007")]
public class Rotate : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotVector3;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xFD2080", Offset = "0xFD2080", VA = "0xFD2080")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xFD2084", Offset = "0xFD2084", VA = "0xFD2084")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xFD20EC", Offset = "0xFD20EC", VA = "0xFD20EC")]
	public Rotate()
	{
	}
}
[Token(Token = "0x2000008")]
public class Top : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text _rankText;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text _nameText;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Text _timeText;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xCA26C0", Offset = "0xCA26C0", VA = "0xCA26C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xCA27E8", Offset = "0xCA27E8", VA = "0xCA27E8")]
	public void Init(int rank, string playerName, int time)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xCA28EC", Offset = "0xCA28EC", VA = "0xCA28EC")]
	public Top()
	{
	}
}
namespace Game
{
	[Token(Token = "0x2000009")]
	public class CardCreate : Singleton<CardCreate>, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9894", Offset = "0x6D9894")]
		private sealed class <WaitEnabled>d__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CardCreate <>4__this;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x18DE9A4", Offset = "0x18DE9A4", VA = "0x18DE9A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x18DE9EC", Offset = "0x18DE9EC", VA = "0x18DE9EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x18DE78C", Offset = "0x18DE78C", VA = "0x18DE78C")]
			[DebuggerHidden]
			public <WaitEnabled>d__54(int <>1__state)
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x18DE7B8", Offset = "0x18DE7B8", VA = "0x18DE7B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x18DE7BC", Offset = "0x18DE7BC", VA = "0x18DE7BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x18DE9AC", Offset = "0x18DE9AC", VA = "0x18DE9AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98A4", Offset = "0x6D98A4")]
		private sealed class <EnterGame>d__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CardCreate <>4__this;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000041")]
				[Address(RVA = "0x18DE73C", Offset = "0x18DE73C", VA = "0x18DE73C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000043")]
				[Address(RVA = "0x18DE784", Offset = "0x18DE784", VA = "0x18DE784", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x18DE5C4", Offset = "0x18DE5C4", VA = "0x18DE5C4")]
			[DebuggerHidden]
			public <EnterGame>d__67(int <>1__state)
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x18DE5F0", Offset = "0x18DE5F0", VA = "0x18DE5F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x18DE5F4", Offset = "0x18DE5F4", VA = "0x18DE5F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x18DE744", Offset = "0x18DE744", VA = "0x18DE744", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int currentCardNumber;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform panel;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform mask;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject cardPrefab;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Sprite> cardTypes;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int cardTypeNumber;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int groupNumber;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int rectNumber;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int rect1Number;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int rect2Number;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int rect3Number;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int rect4Number;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject cardPanelPrefab;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<GameObject> bigCardsPanels;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<GameObject> smallCardsPanels;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GameObject> currentCards;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<RectTransform> pencilBoxPoss;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<GameObject> pencilBoxCards;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject pencilBox;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform slotsPanel;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject cardItem;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float cardBoundX;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float cardBoundY;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject _currentPanel;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int currentPencilBoxPos;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> _panelCardSlots;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<GameObject> moveCardPanels;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int pointerMove;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _currentRow;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int _currentColumn;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Dictionary<GameObject, List<GameObject>> CoverToOthers;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Dictionary<CardType, List<GameObject>> CardSlots;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Vector3 returnCardPos;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public GameObject returnCardParent;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int returnCardOrder;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public List<GameObject> returnCardCovers;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public GameObject returnCard;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public GameObject canvas;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector2 _canvasSize;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int nowLevel;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1122760", Offset = "0x1122760", VA = "0x1122760")]
		public CardCreate(List<GameObject> panelCardSlots)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1122860", Offset = "0x1122860", VA = "0x1122860", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1122ACC", Offset = "0x1122ACC", VA = "0x1122ACC")]
		public void RestartLevel()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1122AD4", Offset = "0x1122AD4", VA = "0x1122AD4")]
		public void LoadCardManager(int level)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1123900", Offset = "0x1123900", VA = "0x1123900")]
		public void Start()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1122938", Offset = "0x1122938", VA = "0x1122938")]
		public void Init()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1123904", Offset = "0x1123904", VA = "0x1123904")]
		public void Restart()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1121448", Offset = "0x1121448", VA = "0x1121448")]
		public void RemoveCard(GameObject g)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x11220CC", Offset = "0x11220CC", VA = "0x11220CC")]
		public void GameResult()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1123BB4", Offset = "0x1123BB4", VA = "0x1123BB4")]
		public void RefreshCard()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1123E64", Offset = "0x1123E64", VA = "0x1123E64")]
		public void CircleCard()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x11240D8", Offset = "0x11240D8", VA = "0x11240D8")]
		public void CloseAll()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x11240DC", Offset = "0x11240DC", VA = "0x11240DC")]
		private void EditorCreate()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x11243FC", Offset = "0x11243FC", VA = "0x11243FC")]
		private void CreateCardPanel(int level)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1124D60", Offset = "0x1124D60", VA = "0x1124D60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F8A74", Offset = "0x6F8A74")]
		private IEnumerator WaitEnabled()
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1124DD8", Offset = "0x1124DD8", VA = "0x1124DD8")]
		private void CloseLayouts()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1124F1C", Offset = "0x1124F1C", VA = "0x1124F1C")]
		public void AllLeftAndRight(List<GameObject> panels)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x11251F0", Offset = "0x11251F0", VA = "0x11251F0")]
		public void LeftAndRight(GameObject g)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x11255C4", Offset = "0x11255C4", VA = "0x11255C4")]
		public void UpAndDown(GameObject g)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x11259A0", Offset = "0x11259A0", VA = "0x11259A0")]
		public void OrderCoverLap()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1125CA0", Offset = "0x1125CA0", VA = "0x1125CA0")]
		public void OverLap(GameObject targetObject, List<GameObject> targetCards)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1126258", Offset = "0x1126258", VA = "0x1126258")]
		public int GetAllCardNumber()
		{
			return default(int);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x11264EC", Offset = "0x11264EC", VA = "0x11264EC")]
		public void CorrectCardNumber(int currentNumber)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x112669C", Offset = "0x112669C", VA = "0x112669C")]
		public void ReCombine()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1126A34", Offset = "0x1126A34", VA = "0x1126A34")]
		public void CloseAllCardButton(bool isClose)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1126B90", Offset = "0x1126B90", VA = "0x1126B90")]
		public void AddCardTypeImage()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1126F84", Offset = "0x1126F84", VA = "0x1126F84")]
		public void CloseSmallLayout()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x11271FC", Offset = "0x11271FC", VA = "0x11271FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F8AD4", Offset = "0x6F8AD4")]
		public IEnumerator EnterGame()
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1125084", Offset = "0x1125084", VA = "0x1125084")]
		public void SaveCurrentRectCard(GameObject g)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1124758", Offset = "0x1124758", VA = "0x1124758")]
		public Vector3 NewRandomPanelPos(GameObject obj)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1124AE4", Offset = "0x1124AE4", VA = "0x1124AE4")]
		public void ClipPanelSize(GameObject obj, int sum)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1127274", Offset = "0x1127274", VA = "0x1127274", Slot = "5")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x11272E4", Offset = "0x11272E4", VA = "0x11272E4")]
		public void NextLevel()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class CardManager : Singleton<CardManager>
	{
		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98B4", Offset = "0x6D98B4")]
		private sealed class <WaitDelete>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CardManager <>4__this;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000050")]
				[Address(RVA = "0x18DF13C", Offset = "0x18DF13C", VA = "0x18DF13C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x18DF184", Offset = "0x18DF184", VA = "0x18DF184", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x18DED24", Offset = "0x18DED24", VA = "0x18DED24")]
			[DebuggerHidden]
			public <WaitDelete>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x18DED50", Offset = "0x18DED50", VA = "0x18DED50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x18DED54", Offset = "0x18DED54", VA = "0x18DED54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x18DF144", Offset = "0x18DF144", VA = "0x18DF144", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LevelScriptable[] _levelData;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite[] cardTypes;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] smallCardPrefab;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject bigCardPrefab;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<BigCardsPanel> bigCardPanels;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<SmallCardsPanel> smallCardPanels;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform panel;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject canvas;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 _canvasSize;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<GameObject> _deleteCardList;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x112752C", Offset = "0x112752C", VA = "0x112752C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1127578", Offset = "0x1127578", VA = "0x1127578")]
		private void Start()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x11275BC", Offset = "0x11275BC", VA = "0x11275BC")]
		private void InitLevel()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x112762C", Offset = "0x112762C", VA = "0x112762C")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1122B70", Offset = "0x1122B70", VA = "0x1122B70")]
		public void LoadLevel(int level)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1127730", Offset = "0x1127730", VA = "0x1127730")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F8BD4", Offset = "0x6F8BD4")]
		private IEnumerator WaitDelete()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x11276C8", Offset = "0x11276C8", VA = "0x11276C8")]
		private LevelScriptable GetData(int level)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x11277A8", Offset = "0x11277A8", VA = "0x11277A8")]
		public CardManager()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1127840", Offset = "0x1127840", VA = "0x1127840")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8C34", Offset = "0x6F8C34")]
		private void <InitLevel>g__TestCount|12_0()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class GameResultCommand : AbstractCommand
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xCC79D4", Offset = "0xCC79D4", VA = "0xCC79D4", Slot = "7")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xCC7AAC", Offset = "0xCC7AAC", VA = "0xCC7AAC")]
		public GameResultCommand()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class GetTopCommand : AbstractCommand
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xCD7908", Offset = "0xCD7908", VA = "0xCD7908", Slot = "7")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xCD7954", Offset = "0xCD7954", VA = "0xCD7954")]
		public GetTopCommand()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class SkinInitCommand : AbstractCommand
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0xC9B9FC", Offset = "0xC9B9FC", VA = "0xC9B9FC", Slot = "7")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xC9BA48", Offset = "0xC9BA48", VA = "0xC9BA48")]
		public SkinInitCommand()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class TpPlayCommand : AbstractCommand
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0xCA456C", Offset = "0xCA456C", VA = "0xCA456C", Slot = "7")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xCA45C0", Offset = "0xCA45C0", VA = "0xCA45C0")]
		public TpPlayCommand()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class WearSkinCommand : AbstractCommand
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int skinId;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x18DCD94", Offset = "0x18DCD94", VA = "0x18DCD94", Slot = "7")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x18DCE24", Offset = "0x18DCE24", VA = "0x18DCE24")]
		public WearSkinCommand()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class ExitEvent
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xCC1FF4", Offset = "0xCC1FF4", VA = "0xCC1FF4")]
		public ExitEvent()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class GameWinEvent
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int level;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xCC7AA4", Offset = "0xCC7AA4", VA = "0xCC7AA4")]
		public GameWinEvent()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class GetTopEvent
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xCD795C", Offset = "0xCD795C", VA = "0xCD795C")]
		public GetTopEvent()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class LogInDailyEvent
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0xFC6D9C", Offset = "0xFC6D9C", VA = "0xFC6D9C")]
		public LogInDailyEvent()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class SkinEvent
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int level;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xC9B9F4", Offset = "0xC9B9F4", VA = "0xC9B9F4")]
		public SkinEvent()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class SkinInitEvent
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0xC9BA50", Offset = "0xC9BA50", VA = "0xC9BA50")]
		public SkinInitEvent()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class TopChangeEvent
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0xCA28F4", Offset = "0xCA28F4", VA = "0xCA28F4")]
		public TopChangeEvent()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class UnLockSkinEvent
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int skinId;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x18DA898", Offset = "0x18DA898", VA = "0x18DA898")]
		public UnLockSkinEvent()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class WearSkinEvent
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int skinId;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x18DCE1C", Offset = "0x18DCE1C", VA = "0x18DCE1C")]
		public WearSkinEvent()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Sheep : SerializedMonoBehaviour
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected AnimancerComponent animancer;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected AnimationClip idle;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected AnimationClip walk;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected AnimationClip eat;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xC9AF50", Offset = "0xC9AF50", VA = "0xC9AF50")]
		public void PlayIdle()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xC9AF7C", Offset = "0xC9AF7C", VA = "0xC9AF7C")]
		public void PlayWalk()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xC9AFA8", Offset = "0xC9AFA8", VA = "0xC9AFA8")]
		public void PlayEat()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xC9AFD4", Offset = "0xC9AFD4", VA = "0xC9AFD4")]
		public Sheep()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TopSheep : Sheep
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int top;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform namePanel;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text topText;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image topImage;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SkinnedMeshRenderer renderer;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Material[] skin;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[OdinSerialize]
		private Dictionary<int, GameObject[]> skinOtherObj;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xCA3108", Offset = "0xCA3108", VA = "0xCA3108")]
		private void Start()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xCA3130", Offset = "0xCA3130", VA = "0xCA3130")]
		private void Update()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xCA319C", Offset = "0xCA319C", VA = "0xCA319C")]
		public void Init(int top, int skinId, string name)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xCA34B4", Offset = "0xCA34B4", VA = "0xCA34B4")]
		public TopSheep()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public enum ModeType
	{
		[Token(Token = "0x400007A")]
		DailyMode,
		[Token(Token = "0x400007B")]
		LevelMode
	}
	[Token(Token = "0x200001F")]
	public class GameManager : Singleton<GameManager>, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98C4", Offset = "0x6D98C4")]
		private sealed class <Test>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x18DF2F4", Offset = "0x18DF2F4", VA = "0x18DF2F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x18DF33C", Offset = "0x18DF33C", VA = "0x18DF33C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x18DF228", Offset = "0x18DF228", VA = "0x18DF228")]
			[DebuggerHidden]
			public <Test>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x18DF254", Offset = "0x18DF254", VA = "0x18DF254", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x18DF258", Offset = "0x18DF258", VA = "0x18DF258", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x18DF2FC", Offset = "0x18DF2FC", VA = "0x18DF2FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text text;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform tpPlayAnchor;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TeleportationProvider tpProvider;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TrackedDeviceGraphicRaycaster raycaster;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform ui;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TopSheep[] topSheepArray;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IGameModel _gameModel;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xCC620C", Offset = "0xCC620C", VA = "0xCC620C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xCC637C", Offset = "0xCC637C", VA = "0xCC637C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xCC652C", Offset = "0xCC652C", VA = "0xCC652C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F8C94", Offset = "0x6F8C94")]
		private IEnumerator Test()
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xCC65DC", Offset = "0xCC65DC", VA = "0xCC65DC", Slot = "5")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xCC664C", Offset = "0xCC664C", VA = "0xCC664C")]
		public void Log(string str)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xCC6650", Offset = "0xCC6650", VA = "0xCC6650")]
		public void Tp()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xCC6588", Offset = "0xCC6588", VA = "0xCC6588")]
		public void Play(bool isPlay)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xCC6700", Offset = "0xCC6700", VA = "0xCC6700")]
		private void SetTopSheep(Dictionary<int, TopData> v)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xCC68A8", Offset = "0xCC68A8", VA = "0xCC68A8")]
		public GameManager()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class GameWin : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject winMessage;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 EndScale;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 BeginScale;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float scaleTime;

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xCC7BE8", Offset = "0xCC7BE8", VA = "0xCC7BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xCC7C4C", Offset = "0xCC7C4C", VA = "0xCC7C4C")]
		public GameWin()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public interface IGameModel : IModel, IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
	{
		[Token(Token = "0x1700000B")]
		BindableProperty<int[]> Item
		{
			[Token(Token = "0x600007F")]
			get;
		}

		[Token(Token = "0x1700000C")]
		BindableProperty<int> Level
		{
			[Token(Token = "0x6000080")]
			get;
		}

		[Token(Token = "0x1700000D")]
		BindableProperty<int> DailyWinTime
		{
			[Token(Token = "0x6000081")]
			get;
		}

		[Token(Token = "0x1700000E")]
		BindableProperty<Dictionary<int, int>> Skin
		{
			[Token(Token = "0x6000082")]
			get;
		}

		[Token(Token = "0x1700000F")]
		BindableProperty<int> NowSkin
		{
			[Token(Token = "0x6000083")]
			get;
		}

		[Token(Token = "0x17000010")]
		BindableProperty<Dictionary<int, TopData>> Top
		{
			[Token(Token = "0x6000084")]
			get;
		}

		[Token(Token = "0x17000011")]
		BindableProperty<TopData> TopSelf
		{
			[Token(Token = "0x6000085")]
			get;
		}

		[Token(Token = "0x17000012")]
		BindableProperty<DateTime[]> LoginTime
		{
			[Token(Token = "0x6000086")]
			get;
		}

		[Token(Token = "0x17000013")]
		Dictionary<int, string> SkinText
		{
			[Token(Token = "0x6000087")]
			get;
		}
	}
	[Token(Token = "0x2000023")]
	public class GameModel : AbstractModel, IGameModel, IModel, IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
	{
		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98D4", Offset = "0x6D98D4")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IStorage storage;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameModel <>4__this;

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x18DF344", Offset = "0x18DF344", VA = "0x18DF344")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x18DF34C", Offset = "0x18DF34C", VA = "0x18DF34C")]
			internal void <OnInit>b__0(int[] v)
			{
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x18DF43C", Offset = "0x18DF43C", VA = "0x18DF43C")]
			internal void <OnInit>b__1(int v)
			{
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x18DF52C", Offset = "0x18DF52C", VA = "0x18DF52C")]
			internal void <OnInit>b__2(int v)
			{
			}

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x18DF61C", Offset = "0x18DF61C", VA = "0x18DF61C")]
			internal void <OnInit>b__3(DateTime[] v)
			{
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x18DF70C", Offset = "0x18DF70C", VA = "0x18DF70C")]
			internal void <OnInit>b__4(Dictionary<int, int> v)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x18DF7FC", Offset = "0x18DF7FC", VA = "0x18DF7FC")]
			internal void <OnInit>b__5(int v)
			{
			}
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6548", Offset = "0x6E6548")]
		private readonly BindableProperty<int[]> <Item>k__BackingField;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6558", Offset = "0x6E6558")]
		private readonly BindableProperty<int> <Level>k__BackingField;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6568", Offset = "0x6E6568")]
		private readonly BindableProperty<int> <DailyWinTime>k__BackingField;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6578", Offset = "0x6E6578")]
		private readonly BindableProperty<Dictionary<int, int>> <Skin>k__BackingField;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6588", Offset = "0x6E6588")]
		private readonly BindableProperty<int> <NowSkin>k__BackingField;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6598", Offset = "0x6E6598")]
		private readonly BindableProperty<Dictionary<int, TopData>> <Top>k__BackingField;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E65A8", Offset = "0x6E65A8")]
		private readonly BindableProperty<TopData> <TopSelf>k__BackingField;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E65B8", Offset = "0x6E65B8")]
		private readonly BindableProperty<DateTime[]> <LoginTime>k__BackingField;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E65C8", Offset = "0x6E65C8")]
		private readonly Dictionary<int, string> <SkinText>k__BackingField;

		[Token(Token = "0x17000014")]
		public BindableProperty<int[]> Item
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xCC68F4", Offset = "0xCC68F4", VA = "0xCC68F4", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8D44", Offset = "0x6F8D44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public BindableProperty<int> Level
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xCC68FC", Offset = "0xCC68FC", VA = "0xCC68FC", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8D54", Offset = "0x6F8D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public BindableProperty<int> DailyWinTime
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xCC6904", Offset = "0xCC6904", VA = "0xCC6904", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8D64", Offset = "0x6F8D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public BindableProperty<Dictionary<int, int>> Skin
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xCC690C", Offset = "0xCC690C", VA = "0xCC690C", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8D74", Offset = "0x6F8D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public BindableProperty<int> NowSkin
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xCC6914", Offset = "0xCC6914", VA = "0xCC6914", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8D84", Offset = "0x6F8D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public BindableProperty<Dictionary<int, TopData>> Top
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xCC691C", Offset = "0xCC691C", VA = "0xCC691C", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8D94", Offset = "0x6F8D94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public BindableProperty<TopData> TopSelf
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xCC6924", Offset = "0xCC6924", VA = "0xCC6924", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8DA4", Offset = "0x6F8DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public BindableProperty<DateTime[]> LoginTime
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xCC692C", Offset = "0xCC692C", VA = "0xCC692C", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8DB4", Offset = "0x6F8DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public Dictionary<int, string> SkinText
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xCC6934", Offset = "0xCC6934", VA = "0xCC6934", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8DC4", Offset = "0x6F8DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xCC693C", Offset = "0xCC693C", VA = "0xCC693C", Slot = "7")]
		protected override void OnInit()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xCC7394", Offset = "0xCC7394", VA = "0xCC7394")]
		public GameModel()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6D98E4", Offset = "0x6D98E4")]
	public class LevelScriptable : ScriptableObject
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string date;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BigCardData[] bigData;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SmallCardData[] smallData;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFC5F94", Offset = "0xFC5F94", VA = "0xFC5F94")]
		public LevelScriptable()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class BigCardData
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Pos;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Row;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Column;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Layer;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CardData> CardData;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x111D14C", Offset = "0x111D14C", VA = "0x111D14C")]
		public BigCardData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class SmallCardData
	{
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Pos;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Type;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<CardData> CardData;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xC9E46C", Offset = "0xC9E46C", VA = "0xC9E46C")]
		public SmallCardData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class CardData
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int SpriteID;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Index;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1127404", Offset = "0x1127404", VA = "0x1127404")]
		public CardData()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class TopData
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int rank;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int time;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int skin;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xCA28FC", Offset = "0xCA28FC", VA = "0xCA28FC")]
		public TopData()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public interface IUserModel : IModel, IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
	{
		[Token(Token = "0x1700001D")]
		BindableProperty<User> User
		{
			[Token(Token = "0x600009F")]
			get;
		}
	}
	[Token(Token = "0x200002B")]
	public class UserModel : AbstractModel, IUserModel, IModel, IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E65D8", Offset = "0x6E65D8")]
		private readonly BindableProperty<User> <User>k__BackingField;

		[Token(Token = "0x1700001E")]
		public BindableProperty<User> User
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x18DAEDC", Offset = "0x18DAEDC", VA = "0x18DAEDC", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8DD4", Offset = "0x6F8DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x18DAEE4", Offset = "0x18DAEE4", VA = "0x18DAEE4", Slot = "7")]
		protected override void OnInit()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x18DAFAC", Offset = "0x18DAFAC", VA = "0x18DAFAC")]
		public UserModel()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x18DB034", Offset = "0x18DB034", VA = "0x18DB034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8DE4", Offset = "0x6F8DE4")]
		private void <OnInit>b__3_0(Message<User> msg)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class MusicManager : Singleton<MusicManager>
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clickMusicClip;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip destroyMusicClip;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip gamebgm;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip winGameMusicClip;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip refreshMusicClip;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource _audioSource;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFCA6AC", Offset = "0xFCA6AC", VA = "0xFCA6AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFCA738", Offset = "0xFCA738", VA = "0xFCA738")]
		public void OnPlayClickMusic()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFCA75C", Offset = "0xFCA75C", VA = "0xFCA75C")]
		public void OnPlayDestroyMusic()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFCA780", Offset = "0xFCA780", VA = "0xFCA780")]
		public void OnPlayWinGame()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFCA7A4", Offset = "0xFCA7A4", VA = "0xFCA7A4")]
		public void OnPlayRefreshCard()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFCA7C8", Offset = "0xFCA7C8", VA = "0xFCA7C8")]
		public MusicManager()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class SkyRotate : MonoBehaviour
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Skybox _skybox;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _rotation;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Rotation;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xC9DCCC", Offset = "0xC9DCCC", VA = "0xC9DCCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xC9DD28", Offset = "0xC9DD28", VA = "0xC9DD28")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xC9DE44", Offset = "0xC9DE44", VA = "0xC9DE44")]
		public SkyRotate()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class Tools
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xCA26B8", Offset = "0xCA26B8", VA = "0xCA26B8")]
		public static void ExitGame()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public interface IArchitecture
	{
		[Token(Token = "0x60000AF")]
		void RegisterSystem<T>(T system) where T : ISystem;

		[Token(Token = "0x60000B0")]
		void RegisterModel<T>(T model) where T : IModel;

		[Token(Token = "0x60000B1")]
		void RegisterUtility<T>(T utility) where T : IUtility;

		[Token(Token = "0x60000B2")]
		T GetSystem<T>() where T : class, ISystem;

		[Token(Token = "0x60000B3")]
		T GetModel<T>() where T : class, IModel;

		[Token(Token = "0x60000B4")]
		T GetUtility<T>() where T : class, IUtility;

		[Token(Token = "0x60000B5")]
		void SendCommand<T>() where T : ICommand, new();

		[Token(Token = "0x60000B6")]
		void SendCommand<T>(T command) where T : ICommand;

		[Token(Token = "0x60000B7")]
		TResult SendQuery<TResult>(IQuery<TResult> query);

		[Token(Token = "0x60000B8")]
		void SendEvent<T>() where T : new();

		[Token(Token = "0x60000B9")]
		void SendEvent<T>(T e);

		[Token(Token = "0x60000BA")]
		IUnRegister RegisterEvent<T>(Action<T> onEvent);

		[Token(Token = "0x60000BB")]
		void UnRegisterEvent<T>(Action<T> onEvent);
	}
	[Token(Token = "0x2000030")]
	public abstract class Architecture<T> : IArchitecture where T : Architecture<T>, new()
	{
		[Serializable]
		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D994C", Offset = "0x6D994C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x60000D1")]
			public <>c()
			{
			}

			[Token(Token = "0x60000D2")]
			internal void <.cctor>b__27_0(T architecture)
			{
			}
		}

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool mInited;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<ISystem> mSystems;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<IModel> mModels;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<T> OnRegisterPatch;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T mArchitecture;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IOCContainer mContainer;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TypeEventSystem mTypeEventSystem;

		[Token(Token = "0x1700001F")]
		public static IArchitecture Interface
		{
			[Token(Token = "0x60000BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BD")]
		private static void MakeSureArchitecture()
		{
		}

		[Token(Token = "0x60000BE")]
		protected abstract void Init();

		[Token(Token = "0x60000BF")]
		public void RegisterSystem<TSystem>(TSystem system) where TSystem : ISystem
		{
		}

		[Token(Token = "0x60000C0")]
		public void RegisterModel<TModel>(TModel model) where TModel : IModel
		{
		}

		[Token(Token = "0x60000C1")]
		public void RegisterUtility<TUtility>(TUtility utility) where TUtility : IUtility
		{
		}

		[Token(Token = "0x60000C2")]
		public TSystem GetSystem<TSystem>() where TSystem : class, ISystem
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		public TModel GetModel<TModel>() where TModel : class, IModel
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		public TUtility GetUtility<TUtility>() where TUtility : class, IUtility
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		public void SendCommand<TCommand>() where TCommand : ICommand, new()
		{
		}

		[Token(Token = "0x60000C6")]
		public void SendCommand<TCommand>(TCommand command) where TCommand : ICommand
		{
		}

		[Token(Token = "0x60000C7")]
		protected virtual void ExecuteCommand(ICommand command)
		{
		}

		[Token(Token = "0x60000C8")]
		public TResult SendQuery<TResult>(IQuery<TResult> query)
		{
			return (TResult)null;
		}

		[Token(Token = "0x60000C9")]
		protected virtual TResult DoQuery<TResult>(IQuery<TResult> query)
		{
			return (TResult)null;
		}

		[Token(Token = "0x60000CA")]
		public void SendEvent<TEvent>() where TEvent : new()
		{
		}

		[Token(Token = "0x60000CB")]
		public void SendEvent<TEvent>(TEvent e)
		{
		}

		[Token(Token = "0x60000CC")]
		public IUnRegister RegisterEvent<TEvent>(Action<TEvent> onEvent)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		public void UnRegisterEvent<TEvent>(Action<TEvent> onEvent)
		{
		}

		[Token(Token = "0x60000CE")]
		protected Architecture()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public interface IOnEvent<T>
	{
		[Token(Token = "0x60000D3")]
		void OnEvent(T e);
	}
	[Token(Token = "0x2000033")]
	public static class OnGlobalEventExtension
	{
		[Token(Token = "0x60000D4")]
		public static IUnRegister RegisterEvent<T>(this IOnEvent<T> self) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		public static void UnRegisterEvent<T>(this IOnEvent<T> self) where T : struct
		{
		}
	}
	[Token(Token = "0x2000034")]
	public interface IController : IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
	}
	[Token(Token = "0x2000035")]
	public interface ISystem : IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x60000D6")]
		void Init();
	}
	[Token(Token = "0x2000036")]
	public abstract class AbstractSystem : ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IArchitecture mArchitecture;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1119408", Offset = "0x1119408", VA = "0x1119408", Slot = "5")]
		private IArchitecture Game.IBelongToArchitecture.GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1119410", Offset = "0x1119410", VA = "0x1119410", Slot = "6")]
		private void Game.ICanSetArchitecture.SetArchitecture(IArchitecture architecture)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1119418", Offset = "0x1119418", VA = "0x1119418", Slot = "4")]
		private void Game.ISystem.Init()
		{
		}

		[Token(Token = "0x60000DA")]
		protected abstract void OnInit();

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1119424", Offset = "0x1119424", VA = "0x1119424")]
		protected AbstractSystem()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public interface IModel : IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
	{
		[Token(Token = "0x60000DC")]
		void Init();
	}
	[Token(Token = "0x2000038")]
	public abstract class AbstractModel : IModel, IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IArchitecture mArchitecturel;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x11193E4", Offset = "0x11193E4", VA = "0x11193E4", Slot = "5")]
		private IArchitecture Game.IBelongToArchitecture.GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x11193EC", Offset = "0x11193EC", VA = "0x11193EC", Slot = "6")]
		private void Game.ICanSetArchitecture.SetArchitecture(IArchitecture architecture)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11193F4", Offset = "0x11193F4", VA = "0x11193F4", Slot = "4")]
		private void Game.IModel.Init()
		{
		}

		[Token(Token = "0x60000E0")]
		protected abstract void OnInit();

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1119400", Offset = "0x1119400", VA = "0x1119400")]
		protected AbstractModel()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public interface IUtility
	{
	}
	[Token(Token = "0x200003A")]
	public interface ICommand : IBelongToArchitecture, ICanSetArchitecture, ICanGetSystem, ICanGetModel, ICanGetUtility, ICanSendEvent, ICanSendCommand, ICanSendQuery
	{
		[Token(Token = "0x60000E2")]
		void Execute();
	}
	[Token(Token = "0x200003B")]
	public abstract class AbstractCommand : ICommand, IBelongToArchitecture, ICanSetArchitecture, ICanGetSystem, ICanGetModel, ICanGetUtility, ICanSendEvent, ICanSendCommand, ICanSendQuery
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IArchitecture mArchitecture;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x11193C0", Offset = "0x11193C0", VA = "0x11193C0", Slot = "5")]
		private IArchitecture Game.IBelongToArchitecture.GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x11193C8", Offset = "0x11193C8", VA = "0x11193C8", Slot = "6")]
		private void Game.ICanSetArchitecture.SetArchitecture(IArchitecture architecture)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x11193D0", Offset = "0x11193D0", VA = "0x11193D0", Slot = "4")]
		private void Game.ICommand.Execute()
		{
		}

		[Token(Token = "0x60000E6")]
		protected abstract void OnExecute();

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x11193DC", Offset = "0x11193DC", VA = "0x11193DC")]
		protected AbstractCommand()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public interface IQuery<TResult> : IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetSystem, ICanSendQuery
	{
		[Token(Token = "0x60000E8")]
		TResult Do();
	}
	[Token(Token = "0x200003D")]
	public abstract class AbstractQuery<T> : IQuery<T>, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetSystem, ICanSendQuery
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IArchitecture mArchitecture;

		[Token(Token = "0x60000E9")]
		public T Do()
		{
			return (T)null;
		}

		[Token(Token = "0x60000EA")]
		protected abstract T OnDo();

		[Token(Token = "0x60000EB")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		public void SetArchitecture(IArchitecture architecture)
		{
		}

		[Token(Token = "0x60000ED")]
		protected AbstractQuery()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public interface IBelongToArchitecture
	{
		[Token(Token = "0x60000EE")]
		IArchitecture GetArchitecture();
	}
	[Token(Token = "0x200003F")]
	public interface ICanSetArchitecture
	{
		[Token(Token = "0x60000EF")]
		void SetArchitecture(IArchitecture architecture);
	}
	[Token(Token = "0x2000040")]
	public interface ICanGetModel : IBelongToArchitecture
	{
	}
	[Token(Token = "0x2000041")]
	public static class CanGetModelExtension
	{
		[Token(Token = "0x60000F0")]
		public static T GetModel<T>(this ICanGetModel self) where T : class, IModel
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public interface ICanGetSystem : IBelongToArchitecture
	{
	}
	[Token(Token = "0x2000043")]
	public static class CanGetSystemExtension
	{
		[Token(Token = "0x60000F1")]
		public static T GetSystem<T>(this ICanGetSystem self) where T : class, ISystem
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	public interface ICanGetUtility : IBelongToArchitecture
	{
	}
	[Token(Token = "0x2000045")]
	public static class CanGetUtilityExtension
	{
		[Token(Token = "0x60000F2")]
		public static T GetUtility<T>(this ICanGetUtility self) where T : class, IUtility
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public interface ICanRegisterEvent : IBelongToArchitecture
	{
	}
	[Token(Token = "0x2000047")]
	public static class CanRegisterEventExtension
	{
		[Token(Token = "0x60000F3")]
		public static IUnRegister RegisterEvent<T>(this ICanRegisterEvent self, Action<T> onEvent)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		public static void UnRegisterEvent<T>(this ICanRegisterEvent self, Action<T> onEvent)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public interface ICanSendCommand : IBelongToArchitecture
	{
	}
	[Token(Token = "0x2000049")]
	public static class CanSendCommandExtension
	{
		[Token(Token = "0x60000F5")]
		public static void SendCommand<T>(this ICanSendCommand self) where T : ICommand, new()
		{
		}

		[Token(Token = "0x60000F6")]
		public static void SendCommand<T>(this ICanSendCommand self, T command) where T : ICommand
		{
		}
	}
	[Token(Token = "0x200004A")]
	public interface ICanSendEvent : IBelongToArchitecture
	{
	}
	[Token(Token = "0x200004B")]
	public static class CanSendEventExtension
	{
		[Token(Token = "0x60000F7")]
		public static void SendEvent<T>(this ICanSendEvent self) where T : new()
		{
		}

		[Token(Token = "0x60000F8")]
		public static void SendEvent<T>(this ICanSendEvent self, T e)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public interface ICanSendQuery : IBelongToArchitecture
	{
	}
	[Token(Token = "0x200004D")]
	public static class CanSendQueryExtension
	{
		[Token(Token = "0x60000F9")]
		public static TResult SendQuery<TResult>(this ICanSendQuery self, IQuery<TResult> query)
		{
			return (TResult)null;
		}
	}
	[Token(Token = "0x200004E")]
	public interface IUnRegister
	{
		[Token(Token = "0x60000FA")]
		void UnRegister();
	}
	[Token(Token = "0x200004F")]
	public interface IUnRegisterList
	{
		[Token(Token = "0x17000020")]
		List<IUnRegister> UnregisterList
		{
			[Token(Token = "0x60000FB")]
			get;
		}
	}
	[Token(Token = "0x2000050")]
	public static class IUnRegisterListExtension
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xFBECD8", Offset = "0xFBECD8", VA = "0xFBECD8")]
		public static void AddToUnregisterList(this IUnRegister self, IUnRegisterList unRegisterList)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xFBEDB0", Offset = "0xFBEDB0", VA = "0xFBEDB0")]
		public static void UnRegisterAll(this IUnRegisterList self)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public struct CustomUnRegister : IUnRegister
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E65E8", Offset = "0x6E65E8")]
		private System.Action <mOnUnRegister>k__BackingField;

		[Token(Token = "0x17000021")]
		private System.Action mOnUnRegister
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x112BC58", Offset = "0x112BC58", VA = "0x112BC58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8ED4", Offset = "0x6F8ED4")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x112BC60", Offset = "0x112BC60", VA = "0x112BC60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F0C", Offset = "0x6F8F0C")]
			set
			{
			}
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x112BC68", Offset = "0x112BC68", VA = "0x112BC68")]
		public CustomUnRegister(System.Action onUnRegsiter)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x112BC70", Offset = "0x112BC70", VA = "0x112BC70", Slot = "4")]
		public void UnRegister()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class UnRegisterOnDestroyTrigger : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly HashSet<IUnRegister> mUnRegisters;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x18DA980", Offset = "0x18DA980", VA = "0x18DA980")]
		public void AddUnRegister(IUnRegister unRegister)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x18DA9E4", Offset = "0x18DA9E4", VA = "0x18DA9E4")]
		public void RemoveUnRegister(IUnRegister unRegister)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x18DAA48", Offset = "0x18DAA48", VA = "0x18DAA48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x18DABF8", Offset = "0x18DABF8", VA = "0x18DABF8")]
		public UnRegisterOnDestroyTrigger()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public static class UnRegisterExtension
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x18DA8A0", Offset = "0x18DA8A0", VA = "0x18DA8A0")]
		public static IUnRegister UnRegisterWhenGameObjectDestroyed(this IUnRegister unRegister, GameObject gameObject)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public class TypeEventSystem
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly EasyEvents mEvents;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypeEventSystem Global;

		[Token(Token = "0x6000107")]
		public void Send<T>() where T : new()
		{
		}

		[Token(Token = "0x6000108")]
		public void Send<T>(T e)
		{
		}

		[Token(Token = "0x6000109")]
		public IUnRegister Register<T>(Action<T> onEvent)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		public void UnRegister<T>(Action<T> onEvent)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x18D87E0", Offset = "0x18D87E0", VA = "0x18D87E0")]
		public TypeEventSystem()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class IOCContainer
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<Type, object> mInstances;

		[Token(Token = "0x600010D")]
		public void Register<T>(T instance)
		{
		}

		[Token(Token = "0x600010E")]
		public T Get<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFBEC54", Offset = "0xFBEC54", VA = "0xFBEC54")]
		public IOCContainer()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public interface IBindableProperty<T> : IReadonlyBindableProperty<T>
	{
		[Token(Token = "0x17000022")]
		new T Value
		{
			[Token(Token = "0x6000110")]
			get;
			[Token(Token = "0x6000111")]
			set;
		}

		[Token(Token = "0x6000112")]
		void SetValueWithoutEvent(T newValue);
	}
	[Token(Token = "0x2000057")]
	public interface IReadonlyBindableProperty<T>
	{
		[Token(Token = "0x17000023")]
		T Value
		{
			[Token(Token = "0x6000113")]
			get;
		}

		[Token(Token = "0x6000114")]
		IUnRegister RegisterWithInitValue(Action<T> action);

		[Token(Token = "0x6000115")]
		void UnRegister(Action<T> onValueChanged);

		[Token(Token = "0x6000116")]
		IUnRegister Register(Action<T> onValueChanged);
	}
	[Token(Token = "0x2000058")]
	public class BindableProperty<T> : IBindableProperty<T>, IReadonlyBindableProperty<T>
	{
		[Serializable]
		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99FC", Offset = "0x6D99FC")]
		private sealed class <>c
		{
			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<T> <>9__0_0;

			[Token(Token = "0x6000123")]
			public <>c()
			{
			}

			[Token(Token = "0x6000124")]
			internal void <.ctor>b__0_0(T v)
			{
			}
		}

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T mValue;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> mOnValueChanged;

		[Token(Token = "0x17000024")]
		public T Value
		{
			[Token(Token = "0x6000118")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000119")]
			set
			{
			}
		}

		[Token(Token = "0x6000117")]
		public BindableProperty([Optional] T defaultValue)
		{
		}

		[Token(Token = "0x600011A")]
		protected virtual void SetValue(T newValue)
		{
		}

		[Token(Token = "0x600011B")]
		protected virtual T GetValue()
		{
			return (T)null;
		}

		[Token(Token = "0x600011C")]
		public void SetValueWithoutEvent(T newValue)
		{
		}

		[Token(Token = "0x600011D")]
		public IUnRegister Register(Action<T> onValueChanged)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		public IUnRegister RegisterWithInitValue(Action<T> onValueChanged)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		public static implicit operator T(BindableProperty<T> property)
		{
			return (T)null;
		}

		[Token(Token = "0x6000120")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		public void UnRegister(Action<T> onValueChanged)
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class BindablePropertyUnRegister<T> : IUnRegister
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E65F8", Offset = "0x6E65F8")]
		private BindableProperty<T> <BindableProperty>k__BackingField;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6608", Offset = "0x6E6608")]
		private Action<T> <OnValueChanged>k__BackingField;

		[Token(Token = "0x17000025")]
		public BindableProperty<T> BindableProperty
		{
			[Token(Token = "0x6000125")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F2C", Offset = "0x6F8F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F3C", Offset = "0x6F8F3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Action<T> OnValueChanged
		{
			[Token(Token = "0x6000127")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F4C", Offset = "0x6F8F4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F5C", Offset = "0x6F8F5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000129")]
		public void UnRegister()
		{
		}

		[Token(Token = "0x600012A")]
		public BindablePropertyUnRegister()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public interface IEasyEvent
	{
	}
	[Token(Token = "0x200005C")]
	public class EasyEvent : IEasyEvent
	{
		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A0C", Offset = "0x6D9A0C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EasyEvent <>4__this;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public System.Action onEvent;

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x18DF1FC", Offset = "0x18DF1FC", VA = "0x18DF1FC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x18DF204", Offset = "0x18DF204", VA = "0x18DF204")]
			internal void <Register>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A1C", Offset = "0x6D9A1C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static System.Action <>9__4_0;

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x18DF1F0", Offset = "0x18DF1F0", VA = "0x18DF1F0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x18DF1F8", Offset = "0x18DF1F8", VA = "0x18DF1F8")]
			internal void <.ctor>b__4_0()
			{
			}
		}

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Action mOnEvent;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xCC1554", Offset = "0xCC1554", VA = "0xCC1554")]
		public IUnRegister Register(System.Action onEvent)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xCC16AC", Offset = "0xCC16AC", VA = "0xCC16AC")]
		public void UnRegister(System.Action onEvent)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xCC1738", Offset = "0xCC1738", VA = "0xCC1738")]
		public void Trigger()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xCC174C", Offset = "0xCC174C", VA = "0xCC174C")]
		public EasyEvent()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class EasyEvent<T> : IEasyEvent
	{
		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A2C", Offset = "0x6D9A2C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EasyEvent<T> <>4__this;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onEvent;

			[Token(Token = "0x6000138")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000139")]
			internal void <Register>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A3C", Offset = "0x6D9A3C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<T> <>9__4_0;

			[Token(Token = "0x600013B")]
			public <>c()
			{
			}

			[Token(Token = "0x600013C")]
			internal void <.ctor>b__4_0(T e)
			{
			}
		}

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> mOnEvent;

		[Token(Token = "0x6000134")]
		public IUnRegister Register(Action<T> onEvent)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		public void UnRegister(Action<T> onEvent)
		{
		}

		[Token(Token = "0x6000136")]
		public void Trigger(T t)
		{
		}

		[Token(Token = "0x6000137")]
		public EasyEvent()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class EasyEvent<T, K> : IEasyEvent
	{
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A4C", Offset = "0x6D9A4C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EasyEvent<T, K> <>4__this;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, K> onEvent;

			[Token(Token = "0x6000141")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000142")]
			internal void <Register>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A5C", Offset = "0x6D9A5C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<T, K> <>9__4_0;

			[Token(Token = "0x6000144")]
			public <>c()
			{
			}

			[Token(Token = "0x6000145")]
			internal void <.ctor>b__4_0(T t, K k)
			{
			}
		}

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T, K> mOnEvent;

		[Token(Token = "0x600013D")]
		public IUnRegister Register(Action<T, K> onEvent)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		public void UnRegister(Action<T, K> onEvent)
		{
		}

		[Token(Token = "0x600013F")]
		public void Trigger(T t, K k)
		{
		}

		[Token(Token = "0x6000140")]
		public EasyEvent()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class EasyEvent<T, K, S> : IEasyEvent
	{
		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A6C", Offset = "0x6D9A6C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EasyEvent<T, K, S> <>4__this;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, K, S> onEvent;

			[Token(Token = "0x600014A")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600014B")]
			internal void <Register>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A7C", Offset = "0x6D9A7C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<T, K, S> <>9__4_0;

			[Token(Token = "0x600014D")]
			public <>c()
			{
			}

			[Token(Token = "0x600014E")]
			internal void <.ctor>b__4_0(T t, K k, S s)
			{
			}
		}

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T, K, S> mOnEvent;

		[Token(Token = "0x6000146")]
		public IUnRegister Register(Action<T, K, S> onEvent)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		public void UnRegister(Action<T, K, S> onEvent)
		{
		}

		[Token(Token = "0x6000148")]
		public void Trigger(T t, K k, S s)
		{
		}

		[Token(Token = "0x6000149")]
		public EasyEvent()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class EasyEvents
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static EasyEvents mGlobalEvents;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<Type, IEasyEvent> mTypeEvents;

		[Token(Token = "0x600014F")]
		public static T Get<T>() where T : IEasyEvent
		{
			return (T)null;
		}

		[Token(Token = "0x6000150")]
		public static void Register<T>() where T : IEasyEvent, new()
		{
		}

		[Token(Token = "0x6000151")]
		public void AddEvent<T>() where T : IEasyEvent, new()
		{
		}

		[Token(Token = "0x6000152")]
		public T GetEvent<T>() where T : IEasyEvent
		{
			return (T)null;
		}

		[Token(Token = "0x6000153")]
		public T GetOrAddEvent<T>() where T : IEasyEvent, new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xCC1858", Offset = "0xCC1858", VA = "0xCC1858")]
		public EasyEvents()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public interface IGameSystem : ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
	}
	[Token(Token = "0x200006A")]
	public class GameSystem : AbstractSystem, IGameSystem, ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A8C", Offset = "0x6D9A8C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IGameModel gameModel;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameSystem <>4__this;

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x18DFA60", Offset = "0x18DFA60", VA = "0x18DFA60")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x18DFA68", Offset = "0x18DFA68", VA = "0x18DFA68")]
			internal void <OnInit>b__0(GameWinEvent e)
			{
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xCC7AB4", Offset = "0xCC7AB4", VA = "0xCC7AB4", Slot = "7")]
		protected override void OnInit()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xCC7BD8", Offset = "0xCC7BD8", VA = "0xCC7BD8")]
		private void Win()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xCC7BDC", Offset = "0xCC7BDC", VA = "0xCC7BDC")]
		private void Fail()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xCC7BE0", Offset = "0xCC7BE0", VA = "0xCC7BE0")]
		public GameSystem()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public interface IItemSystem : ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x600015C")]
		void AddItem(int[] item);

		[Token(Token = "0x600015D")]
		void UseItem(int id);

		[Token(Token = "0x600015E")]
		void DailyItem();
	}
	[Token(Token = "0x200006D")]
	public class ItemSystem : AbstractSystem, IItemSystem, ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] _dailyItem;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xFC3600", Offset = "0xFC3600", VA = "0xFC3600", Slot = "7")]
		protected override void OnInit()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xFC36A8", Offset = "0xFC36A8", VA = "0xFC36A8", Slot = "8")]
		public void AddItem(int[] item)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xFC36E8", Offset = "0xFC36E8", VA = "0xFC36E8", Slot = "9")]
		public void UseItem(int id)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xFC3728", Offset = "0xFC3728", VA = "0xFC3728", Slot = "10")]
		public void DailyItem()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xFC3768", Offset = "0xFC3768", VA = "0xFC3768")]
		private void OnLogInDaily()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xFC3C5C", Offset = "0xFC3C5C", VA = "0xFC3C5C")]
		public ItemSystem()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xFC3CF8", Offset = "0xFC3CF8", VA = "0xFC3CF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F6C", Offset = "0x6F8F6C")]
		private void <OnInit>b__1_0(LogInDailyEvent e)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public interface ISkinSystem : ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
	}
	[Token(Token = "0x200006F")]
	public class SkinSystem : AbstractSystem, ISkinSystem, ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xC9BE80", Offset = "0xC9BE80", VA = "0xC9BE80", Slot = "7")]
		protected override void OnInit()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xC9C020", Offset = "0xC9C020", VA = "0xC9C020")]
		private void SkinInit()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xC9CE58", Offset = "0xC9CE58", VA = "0xC9CE58")]
		private void ChangeSkin(int skinId)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xC9D018", Offset = "0xC9D018", VA = "0xC9D018")]
		private void SkinUnLock(int level)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xC9DC90", Offset = "0xC9DC90", VA = "0xC9DC90")]
		public SkinSystem()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xC9DC98", Offset = "0xC9DC98", VA = "0xC9DC98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F7C", Offset = "0x6F8F7C")]
		private void <OnInit>b__0_0(SkinEvent e)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xC9DCB0", Offset = "0xC9DCB0", VA = "0xC9DCB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F8C", Offset = "0x6F8F8C")]
		private void <OnInit>b__0_1(WearSkinEvent e)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xC9DCC8", Offset = "0xC9DCC8", VA = "0xC9DCC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F9C", Offset = "0x6F8F9C")]
		private void <OnInit>b__0_2(SkinInitEvent e)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public interface ITopSystem : ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
	}
	[Token(Token = "0x2000071")]
	public class TopSystem : AbstractSystem, ITopSystem, ISystem, IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility, ICanRegisterEvent, ICanSendEvent, ICanGetSystem
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A9C", Offset = "0x6D9A9C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TopSystem <>4__this;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IUserModel userModel;

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x18E072C", Offset = "0x18E072C", VA = "0x18E072C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x18E0734", Offset = "0x18E0734", VA = "0x18E0734")]
			internal void <OnInit>b__0(TopChangeEvent e)
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x18E0960", Offset = "0x18E0960", VA = "0x18E0960")]
			internal void <OnInit>b__1(GetTopEvent e)
			{
			}
		}

		[Token(Token = "0x40000E1")]
		private const string DailyWinTime = "DailyWinTime";

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IGameModel _gameModel;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xCA34BC", Offset = "0xCA34BC", VA = "0xCA34BC", Slot = "7")]
		protected override void OnInit()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xCA3688", Offset = "0xCA3688", VA = "0xCA3688")]
		private void OnLeaderboardGetEntriesByIds(Message<LeaderboardEntryList> message)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xCA3968", Offset = "0xCA3968", VA = "0xCA3968")]
		private void OnLeaderboardGetEntries(Message<LeaderboardEntryList> message)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xCA3D0C", Offset = "0xCA3D0C", VA = "0xCA3D0C")]
		private void OnLeaderboardWriteEntry(Message<bool> message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xCA3DF8", Offset = "0xCA3DF8", VA = "0xCA3DF8")]
		private void TopExamples()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xCA41E0", Offset = "0xCA41E0", VA = "0xCA41E0")]
		public TopSystem()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xCA41E8", Offset = "0xCA41E8", VA = "0xCA41E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FAC", Offset = "0x6F8FAC")]
		internal static void <TopExamples>g__OnLeaderboardGet|6_0(Message<LeaderboardList> message)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xCA42D4", Offset = "0xCA42D4", VA = "0xCA42D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FBC", Offset = "0x6F8FBC")]
		internal static void <TopExamples>g__OnLeaderboardGetEntries|6_1(Message<LeaderboardEntryList> message)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xCA43C0", Offset = "0xCA43C0", VA = "0xCA43C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FCC", Offset = "0x6F8FCC")]
		internal static void <TopExamples>g__OnLeaderboardWriteEntry|6_2(Message<bool> message)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xCA44AC", Offset = "0xCA44AC", VA = "0xCA44AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FDC", Offset = "0x6F8FDC")]
		internal static void <TopExamples>g__OnLeaderboardWriteEntryWithSupplementaryMetric|6_3(Message<bool> message)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xCA44EC", Offset = "0xCA44EC", VA = "0xCA44EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FEC", Offset = "0x6F8FEC")]
		internal static void <TopExamples>g__OnLeaderboardGetEntriesByIds|6_4(Message<LeaderboardEntryList> message)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xCA452C", Offset = "0xCA452C", VA = "0xCA452C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FFC", Offset = "0x6F8FFC")]
		internal static void <TopExamples>g__OnLeaderboardGetEntriesAfterRank|6_5(Message<LeaderboardEntryList> message)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class BigCardsPanel : MonoBehaviour
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int row;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int column;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int layer;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Card> cards;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[,] cardArrays;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> currentCards;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isRect;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isEnd;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x111D154", Offset = "0x111D154", VA = "0x111D154")]
		private void Awake()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x111D1DC", Offset = "0x111D1DC", VA = "0x111D1DC")]
		public void UpdateCardArray(int max)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x111D328", Offset = "0x111D328", VA = "0x111D328")]
		public BigCardsPanel()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public enum CardType
	{
		[Token(Token = "0x40000EE")]
		Card1 = 1,
		[Token(Token = "0x40000EF")]
		Card2,
		[Token(Token = "0x40000F0")]
		Card3,
		[Token(Token = "0x40000F1")]
		Card4,
		[Token(Token = "0x40000F2")]
		Card5,
		[Token(Token = "0x40000F3")]
		Card6,
		[Token(Token = "0x40000F4")]
		Card7,
		[Token(Token = "0x40000F5")]
		Card8,
		[Token(Token = "0x40000F6")]
		Card9,
		[Token(Token = "0x40000F7")]
		Card10,
		[Token(Token = "0x40000F8")]
		Card11,
		[Token(Token = "0x40000F9")]
		Card12,
		[Token(Token = "0x40000FA")]
		Card13,
		[Token(Token = "0x40000FB")]
		Card14,
		[Token(Token = "0x40000FC")]
		Card15,
		[Token(Token = "0x40000FD")]
		Card16
	}
	[Token(Token = "0x2000075")]
	public class Card : MonoBehaviour
	{
		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9AAC", Offset = "0x6D9AAC")]
		private sealed class <MoveCardToPencilBox>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Card <>4__this;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private CardCreate <cardCreate>5__2;

			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool <isMove>5__3;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <insert>5__4;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__5;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x18DE3A8", Offset = "0x18DE3A8", VA = "0x18DE3A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0x18DE3F0", Offset = "0x18DE3F0", VA = "0x18DE3F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x18DDDC0", Offset = "0x18DDDC0", VA = "0x18DDDC0")]
			[DebuggerHidden]
			public <MoveCardToPencilBox>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x18DDDEC", Offset = "0x18DDDEC", VA = "0x18DDDEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x18DDDF0", Offset = "0x18DDDF0", VA = "0x18DDDF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x18DE3B0", Offset = "0x18DE3B0", VA = "0x18DE3B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9ABC", Offset = "0x6D9ABC")]
		private sealed class <MoveToCenter>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Card <>4__this;

			[Token(Token = "0x17000029")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000195")]
				[Address(RVA = "0x18DE574", Offset = "0x18DE574", VA = "0x18DE574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000197")]
				[Address(RVA = "0x18DE5BC", Offset = "0x18DE5BC", VA = "0x18DE5BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x18DE3F8", Offset = "0x18DE3F8", VA = "0x18DE3F8")]
			[DebuggerHidden]
			public <MoveToCenter>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x18DE424", Offset = "0x18DE424", VA = "0x18DE424", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x18DE428", Offset = "0x18DE428", VA = "0x18DE428", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x18DE57C", Offset = "0x18DE57C", VA = "0x18DE57C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject cardBoomEffect;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int coveredNumber;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CardType cardType;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color coverColor;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image cardTypeImage;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform cardArea;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _hierarchy;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _owner;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isBigCard;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector2 center;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float moveToCenterTime;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Tween _move;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Tween _tween;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1120F6C", Offset = "0x1120F6C", VA = "0x1120F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x112102C", Offset = "0x112102C", VA = "0x112102C")]
		public void SetMove()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1121130", Offset = "0x1121130", VA = "0x1121130")]
		public void OnClick()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1121768", Offset = "0x1121768", VA = "0x1121768")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F900C", Offset = "0x6F900C")]
		public IEnumerator MoveCardToPencilBox()
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x11217E0", Offset = "0x11217E0", VA = "0x11217E0")]
		public void ClassifyCard(GameObject card, int insertPos)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1122290", Offset = "0x1122290", VA = "0x1122290")]
		public void OnClickDown(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x11224C0", Offset = "0x11224C0", VA = "0x11224C0")]
		public void OnClickUp(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1122644", Offset = "0x1122644", VA = "0x1122644")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x11226B4", Offset = "0x11226B4", VA = "0x11226B4")]
		public void BeginRefresh()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x11226E0", Offset = "0x11226E0", VA = "0x11226E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F906C", Offset = "0x6F906C")]
		public IEnumerator MoveToCenter()
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1122758", Offset = "0x1122758", VA = "0x1122758")]
		public Card()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class CardDestroyEffect : MonoBehaviour
	{
		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9ACC", Offset = "0x6D9ACC")]
		private sealed class <PlayAnimation>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CardDestroyEffect <>4__this;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<Sprite>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600019F")]
				[Address(RVA = "0x18DECD4", Offset = "0x18DECD4", VA = "0x18DECD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001A1")]
				[Address(RVA = "0x18DED1C", Offset = "0x18DED1C", VA = "0x18DED1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x18DE9F4", Offset = "0x18DE9F4", VA = "0x18DE9F4")]
			[DebuggerHidden]
			public <PlayAnimation>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x18DEA20", Offset = "0x18DEA20", VA = "0x18DEA20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x18DEA90", Offset = "0x18DEA90", VA = "0x18DEA90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x18DEA3C", Offset = "0x18DEA3C", VA = "0x18DEA3C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x18DECDC", Offset = "0x18DECDC", VA = "0x18DECDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Sprite> sprites;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float playTime;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _intervalTime;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image _image;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x112740C", Offset = "0x112740C", VA = "0x112740C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x11274AC", Offset = "0x11274AC", VA = "0x11274AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F916C", Offset = "0x6F916C")]
		public IEnumerator PlayAnimation()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1127524", Offset = "0x1127524", VA = "0x1127524")]
		public CardDestroyEffect()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Level : MonoBehaviour, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _lock;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text _text;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button _btn;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xFC5074", Offset = "0xFC5074", VA = "0xFC5074")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xFC51EC", Offset = "0xFC51EC", VA = "0xFC51EC")]
		private void OnBtnClick()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xFC54D8", Offset = "0xFC54D8", VA = "0xFC54D8")]
		public void Init(int lv, bool isLock)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xFC5558", Offset = "0xFC5558", VA = "0xFC5558", Slot = "4")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xFC55C8", Offset = "0xFC55C8", VA = "0xFC55C8")]
		public Level()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public interface IPanel
	{
		[Token(Token = "0x60001A7")]
		void Open();

		[Token(Token = "0x60001A8")]
		void Close();
	}
	[Token(Token = "0x200007C")]
	public class Panel : MonoBehaviour, IPanel
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9ADC", Offset = "0x6D9ADC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Panel <>4__this;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int count;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityAction <>9__0;

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x18DFDE0", Offset = "0x18DFDE0", VA = "0x18DFDE0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x18DFDE8", Offset = "0x18DFDE8", VA = "0x18DFDE8")]
			internal void <Close>b__0()
			{
			}
		}

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIState type;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected DOTweenAnimation[] DoTweenAnimations;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xFCBEAC", Offset = "0xFCBEAC", VA = "0xFCBEAC", Slot = "6")]
		public virtual void Open()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xFC52F8", Offset = "0xFC52F8", VA = "0xFC52F8", Slot = "5")]
		public void Close()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xFCBF74", Offset = "0xFCBF74", VA = "0xFCBF74", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xFC5F88", Offset = "0xFC5F88", VA = "0xFC5F88")]
		public Panel()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ExitPanel : Panel
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xCC1FFC", Offset = "0xCC1FFC", VA = "0xCC1FFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xCC2168", Offset = "0xCC2168", VA = "0xCC2168")]
		public ExitPanel()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class FailPanel : Panel
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xCC2178", Offset = "0xCC2178", VA = "0xCC2178")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xCC22F0", Offset = "0xCC22F0", VA = "0xCC22F0")]
		private void OnRestart()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xCC2354", Offset = "0xCC2354", VA = "0xCC2354")]
		private void OnBack()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xCC240C", Offset = "0xCC240C", VA = "0xCC240C")]
		public FailPanel()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class HomePanel : Panel, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xCDAA18", Offset = "0xCDAA18", VA = "0xCDAA18")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xCDACA0", Offset = "0xCDACA0", VA = "0xCDACA0")]
		private void OnSkin()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xCDAD58", Offset = "0xCDAD58", VA = "0xCDAD58")]
		private void OnTop()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xCDAE58", Offset = "0xCDAE58", VA = "0xCDAE58")]
		private void OnDailyMode()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xCDAF1C", Offset = "0xCDAF1C", VA = "0xCDAF1C")]
		private void OnLevelMode()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xCDAFD4", Offset = "0xCDAFD4", VA = "0xCDAFD4", Slot = "8")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xCDB044", Offset = "0xCDB044", VA = "0xCDB044")]
		public HomePanel()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class LevelPanel : Panel, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Level> _levelList;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button _upBtn;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Button _downBtn;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _movePanel;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IGameModel _gameModel;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 _firstPos;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 _secondPos;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xFC55D0", Offset = "0xFC55D0", VA = "0xFC55D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xFC5C7C", Offset = "0xFC5C7C", VA = "0xFC5C7C")]
		private void OnLevelChange(int obj)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xFC5D00", Offset = "0xFC5D00", VA = "0xFC5D00")]
		private void OnDownBtnClick()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC5D60", VA = "0xFC5D60")]
		private void OnUpBtnClick()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xFC5DC0", Offset = "0xFC5DC0", VA = "0xFC5DC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xFC5F00", Offset = "0xFC5F00", VA = "0xFC5F00", Slot = "8")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xFC5F70", Offset = "0xFC5F70", VA = "0xFC5F70")]
		public LevelPanel()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xFC5F90", Offset = "0xFC5F90", VA = "0xFC5F90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F921C", Offset = "0x6F921C")]
		private void <Start>b__7_0()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class SkinPanel : Panel, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Skin[] _skinArray;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xC9BA58", Offset = "0xC9BA58", VA = "0xC9BA58")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xC9BE08", Offset = "0xC9BE08", VA = "0xC9BE08", Slot = "8")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xC9BE78", Offset = "0xC9BE78", VA = "0xC9BE78")]
		public SkinPanel()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class TopPanel : Panel, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9AEC", Offset = "0x6D9AEC")]
		private sealed class <SetTopSelf>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TopPanel <>4__this;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TopData topData;

			[Token(Token = "0x1700002D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x18E06DC", Offset = "0x18E06DC", VA = "0x18E06DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x18E0724", Offset = "0x18E0724", VA = "0x18E0724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x18E05A8", Offset = "0x18E05A8", VA = "0x18E05A8")]
			[DebuggerHidden]
			public <SetTopSelf>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x18E05D4", Offset = "0x18E05D4", VA = "0x18E05D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x18E05D8", Offset = "0x18E05D8", VA = "0x18E05D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x18E06E4", Offset = "0x18E06E4", VA = "0x18E06E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9AFC", Offset = "0x6D9AFC")]
		private sealed class <SetTop>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<int, TopData> topDatas;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TopPanel <>4__this;

			[Token(Token = "0x1700002F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x18E0558", Offset = "0x18E0558", VA = "0x18E0558", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x18E05A0", Offset = "0x18E05A0", VA = "0x18E05A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x18E035C", Offset = "0x18E035C", VA = "0x18E035C")]
			[DebuggerHidden]
			public <SetTop>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x18E0388", Offset = "0x18E0388", VA = "0x18E0388", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x18E038C", Offset = "0x18E038C", VA = "0x18E038C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x18E0560", Offset = "0x18E0560", VA = "0x18E0560", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Top[] _tops;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IGameModel _gameModel;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xCA2904", Offset = "0xCA2904", VA = "0xCA2904")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xCA2C74", Offset = "0xCA2C74", VA = "0xCA2C74")]
		public void Init()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xCA2CC0", Offset = "0xCA2CC0", VA = "0xCA2CC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xCA2F10", Offset = "0xCA2F10", VA = "0xCA2F10")]
		private void OnTopSelfChanged(TopData obj)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xCA2F3C", Offset = "0xCA2F3C", VA = "0xCA2F3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F922C", Offset = "0x6F922C")]
		private IEnumerator SetTopSelf(TopData topData)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xCA2FD0", Offset = "0xCA2FD0", VA = "0xCA2FD0")]
		private void OnTopChanged(Dictionary<int, TopData> obj)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xCA2FFC", Offset = "0xCA2FFC", VA = "0xCA2FFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F928C", Offset = "0x6F928C")]
		private IEnumerator SetTop(Dictionary<int, TopData> topDatas)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xCA3090", Offset = "0xCA3090", VA = "0xCA3090", Slot = "8")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xCA3100", Offset = "0xCA3100", VA = "0xCA3100")]
		public TopPanel()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class WinPanel : Panel
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x18DCE2C", Offset = "0x18DCE2C", VA = "0x18DCE2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x18DCFA4", Offset = "0x18DCFA4", VA = "0x18DCFA4")]
		private void OnContinue()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x18DD018", Offset = "0x18DD018", VA = "0x18DD018")]
		private void OnBack()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x18DD0D0", Offset = "0x18DD0D0", VA = "0x18DD0D0")]
		public WinPanel()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class Skin : MonoBehaviour, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite sprite1;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite sprite2;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image img;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Toggle _toggle;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Text _text;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _id;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xC9B4A0", Offset = "0xC9B4A0", VA = "0xC9B4A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC9B52C", Offset = "0xC9B52C", VA = "0xC9B52C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC9B66C", Offset = "0xC9B66C", VA = "0xC9B66C")]
		public void InitSkin(int id, bool isHave, bool isWare, string info)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC9B7AC", Offset = "0xC9B7AC", VA = "0xC9B7AC", Slot = "4")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC9B81C", Offset = "0xC9B81C", VA = "0xC9B81C")]
		public Skin()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xC9B824", Offset = "0xC9B824", VA = "0xC9B824")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F938C", Offset = "0x6F938C")]
		private void <Start>b__7_0(bool isOn)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xC9B950", Offset = "0xC9B950", VA = "0xC9B950")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F939C", Offset = "0x6F939C")]
		private void <Start>b__7_1(UnLockSkinEvent e)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class SmallCardsPanel : MonoBehaviour
	{
		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9B0C", Offset = "0x6D9B0C")]
		private sealed class <CloseLayouts>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SmallCardsPanel <>4__this;

			[Token(Token = "0x17000031")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x18E030C", Offset = "0x18E030C", VA = "0x18E030C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000032")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x18E0354", Offset = "0x18E0354", VA = "0x18E0354", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x18E0144", Offset = "0x18E0144", VA = "0x18E0144")]
			[DebuggerHidden]
			public <CloseLayouts>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x18E0170", Offset = "0x18E0170", VA = "0x18E0170", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x18E0174", Offset = "0x18E0174", VA = "0x18E0174", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x18E0314", Offset = "0x18E0314", VA = "0x18E0314", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isPlay;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int cardsNumber;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int level;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject cardPrefab;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int panelOrder;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<GameObject> cards;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CardData> cardData;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _addPreCount;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xC9E474", Offset = "0xC9E474", VA = "0xC9E474")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xC9E4B8", Offset = "0xC9E4B8", VA = "0xC9E4B8")]
		private void PlayInit()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xC9E868", Offset = "0xC9E868", VA = "0xC9E868")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F93AC", Offset = "0x6F93AC")]
		private IEnumerator CloseLayouts()
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xC9E8E0", Offset = "0xC9E8E0", VA = "0xC9E8E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xC9E49C", Offset = "0xC9E49C", VA = "0xC9E49C")]
		private void Init()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xC9E8E4", Offset = "0xC9E8E4", VA = "0xC9E8E4")]
		public void AddCard(int addCount, bool isFirst)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xC9E77C", Offset = "0xC9E77C", VA = "0xC9E77C")]
		public void UpdateCoverMessage(GameObject g, int orderNumber)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xC9EBD8", Offset = "0xC9EBD8", VA = "0xC9EBD8")]
		public void AddCard(GameObject card)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xC9EE3C", Offset = "0xC9EE3C", VA = "0xC9EE3C")]
		public void RemoveCard(GameObject g)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xC9F18C", Offset = "0xC9F18C", VA = "0xC9F18C")]
		public SmallCardsPanel()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public enum UIState
	{
		[Token(Token = "0x400014B")]
		None,
		[Token(Token = "0x400014C")]
		Exit,
		[Token(Token = "0x400014D")]
		Fail,
		[Token(Token = "0x400014E")]
		Level,
		[Token(Token = "0x400014F")]
		Skin,
		[Token(Token = "0x4000150")]
		Top,
		[Token(Token = "0x4000151")]
		Win,
		[Token(Token = "0x4000152")]
		Home
	}
	[Token(Token = "0x200008B")]
	public enum ButtonType
	{
		[Token(Token = "0x4000154")]
		None,
		[Token(Token = "0x4000155")]
		primary,
		[Token(Token = "0x4000156")]
		Secondary
	}
	[Token(Token = "0x200008C")]
	public class UIManager : Singleton<UIManager>, IController, IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel, ICanRegisterEvent, ICanSendQuery
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9B1C", Offset = "0x6D9B1C")]
		private sealed class <>c
		{
			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static TweenCallback <>9__28_0;

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x18E0C48", Offset = "0x18E0C48", VA = "0x18E0C48")]
			public <>c()
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x18E0C50", Offset = "0x18E0C50", VA = "0x18E0C50")]
			internal void <RefreshCard>b__28_0()
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9B2C", Offset = "0x6D9B2C")]
		private sealed class <RefreshCard>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			[Token(Token = "0x17000033")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x18E1AD8", Offset = "0x18E1AD8", VA = "0x18E1AD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000034")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x18E1B20", Offset = "0x18E1B20", VA = "0x18E1B20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x18D9750", Offset = "0x18D9750", VA = "0x18D9750")]
			[DebuggerHidden]
			public <RefreshCard>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0x18E16D8", Offset = "0x18E16D8", VA = "0x18E16D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x18E16DC", Offset = "0x18E16DC", VA = "0x18E16DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x18E1AE0", Offset = "0x18E1AE0", VA = "0x18E1AE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9B3C", Offset = "0x6D9B3C")]
		private sealed class <MoveCard>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<GameObject> <cards>5__2;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<GameObject> <pencilBoxCards>5__3;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<RectTransform> <pencilBoxPoss>5__4;

			[Token(Token = "0x17000035")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0x18E1688", Offset = "0x18E1688", VA = "0x18E1688", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000216")]
				[Address(RVA = "0x18E16D0", Offset = "0x18E16D0", VA = "0x18E16D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x18DA670", Offset = "0x18DA670", VA = "0x18DA670")]
			[DebuggerHidden]
			public <MoveCard>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x18E0CB8", Offset = "0x18E0CB8", VA = "0x18E0CB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x18E0CBC", Offset = "0x18E0CBC", VA = "0x18E0CBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x18E1690", Offset = "0x18E1690", VA = "0x18E1690", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float refreshIntervel;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button moveButton;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button returnButton;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button refreshButton;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform playerUI;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text _moveBtnText;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Text _returnBtnText;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text _refreshBtnText;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UIState uiState;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public InputDeviceCharacteristics controllerCharacteristics;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputDevice targetDevice;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private HomePanel _homePanel;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ExitPanel _exitPanel;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FailPanel _failPanel;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private LevelPanel _levelPanel;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private SkinPanel _skinPanel;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TopPanel _topPanel;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private WinPanel _winPanel;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonType _buttonType;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IGameModel _gameModel;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x18D88B0", Offset = "0x18D88B0", VA = "0x18D88B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x18D8D1C", Offset = "0x18D8D1C", VA = "0x18D8D1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x18D8FFC", Offset = "0x18D8FFC", VA = "0x18D8FFC")]
		private void OnItemChanged(int[] obj)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x18D9178", Offset = "0x18D9178", VA = "0x18D9178")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x18D8C68", Offset = "0x18D8C68", VA = "0x18D8C68")]
		private void TryInitialize()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x18D917C", Offset = "0x18D917C", VA = "0x18D917C")]
		private void UpdateInput()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x18D9414", Offset = "0x18D9414", VA = "0x18D9414")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x18D9454", Offset = "0x18D9454", VA = "0x18D9454")]
		public void OnClickRefreshCard()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x18D96D8", Offset = "0x18D96D8", VA = "0x18D96D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F945C", Offset = "0x6F945C")]
		public IEnumerator RefreshCard()
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x18D977C", Offset = "0x18D977C", VA = "0x18D977C")]
		public void OnClickRerunCard()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x18DA3A4", Offset = "0x18DA3A4", VA = "0x18DA3A4")]
		public void OnClickMoveCard()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x18DA5F8", Offset = "0x18DA5F8", VA = "0x18DA5F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F94BC", Offset = "0x6F94BC")]
		public IEnumerator MoveCard()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x18DA69C", Offset = "0x18DA69C", VA = "0x18DA69C")]
		public void OnClickAgainGame()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x18DA6FC", Offset = "0x18DA6FC", VA = "0x18DA6FC")]
		public void GameFail()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x18DA76C", Offset = "0x18DA76C", VA = "0x18DA76C")]
		public void GameWin()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x18DA7DC", Offset = "0x18DA7DC", VA = "0x18DA7DC", Slot = "5")]
		public IArchitecture GetArchitecture()
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x18DA84C", Offset = "0x18DA84C", VA = "0x18DA84C")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public static class ByteTool
	{
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x111EC5C", Offset = "0x111EC5C", VA = "0x111EC5C")]
		public static byte[] IntToBytes(int value)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x111ECFC", Offset = "0x111ECFC", VA = "0x111ECFC")]
		public static int BytesToInt(byte[] src, int offset)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000091")]
	public interface IStorage : IUtility
	{
		[Token(Token = "0x6000219")]
		void Save<T>(string key, T value);

		[Token(Token = "0x600021A")]
		T Load<T>(string key, T defaultValue);

		[Token(Token = "0x600021B")]
		bool HasKey<T>(string key);
	}
	[Token(Token = "0x2000092")]
	public class ES3Storage : IStorage, IUtility
	{
		[Token(Token = "0x600021C")]
		public void Save<T>(string key, T value)
		{
		}

		[Token(Token = "0x600021D")]
		public T Load<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x600021E")]
		public bool HasKey<T>(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xCC154C", Offset = "0xCC154C", VA = "0xCC154C")]
		public ES3Storage()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public abstract class Singleton<T> : MonoBehaviour where T : Component
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T _instance;

		[Token(Token = "0x17000037")]
		public static T Instance
		{
			[Token(Token = "0x6000220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000221")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000222")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class VRSheep : Architecture<VRSheep>
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x18DB8C8", Offset = "0x18DB8C8", VA = "0x18DB8C8", Slot = "17")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x18DBAB8", Offset = "0x18DBAB8", VA = "0x18DBAB8")]
		public VRSheep()
		{
		}
	}
}
namespace FlatKit
{
	[Token(Token = "0x2000095")]
	public class UvScroller : MonoBehaviour
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material targetMaterial;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedX;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedY;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 offset;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 initOffset;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x18DB7DC", Offset = "0x18DB7DC", VA = "0x18DB7DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x18DB824", Offset = "0x18DB824", VA = "0x18DB824")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x18DB848", Offset = "0x18DB848", VA = "0x18DB848")]
		private void Update()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x18DB8C0", Offset = "0x18DB8C0", VA = "0x18DB8C0")]
		public UvScroller()
		{
		}
	}
	[Token(Token = "0x2000096")]
	internal class BlitTexturePass : ScriptableRenderPass
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string CopyEffectShaderName;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ProfilingSampler _profilingSampler;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material _effectMaterial;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material _copyMaterial;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RenderTargetHandle _temporaryColorTexture;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x111D5E0", Offset = "0x111D5E0", VA = "0x111D5E0")]
		public void Setup(Material effectMaterial, bool useDepth, bool useNormals, bool useColor)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x111D79C", Offset = "0x111D79C", VA = "0x111D79C", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x111D840", Offset = "0x111D840", VA = "0x111D840", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x111DE00", Offset = "0x111DE00", VA = "0x111DE00")]
		private static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x111DED8", Offset = "0x111DED8", VA = "0x111DED8")]
		public BlitTexturePass()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class FlatKitFog : ScriptableRendererFeature
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6628", Offset = "0x6E6628")]
		public FogSettings settings;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private Material _effectMaterial;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BlitTexturePass _blitTexturePass;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private Shader _blitShader;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTargetHandle _fogTexture;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Texture2D _lutDepth;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Texture2D _lutHeight;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string FogShaderName;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int DistanceLut;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int Near;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int Far;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int UseDistanceFog;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int UseDistanceFogOnSky;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int DistanceFogIntensity;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int HeightLut;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int LowWorldY;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int HighWorldY;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int UseHeightFog;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int UseHeightFogOnSky;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int HeightFogIntensity;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int DistanceHeightBlend;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xCC2C04", Offset = "0xCC2C04", VA = "0xCC2C04", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xCC2D98", Offset = "0xCC2D98", VA = "0xCC2D98", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xCC33F4", Offset = "0xCC33F4", VA = "0xCC33F4", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xCC2EC8", Offset = "0xCC2EC8", VA = "0xCC2EC8")]
		private bool CreateMaterials()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xCC3080", Offset = "0xCC3080", VA = "0xCC3080")]
		private void SetMaterialProperties()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xCC345C", Offset = "0xCC345C", VA = "0xCC345C")]
		private void UpdateDistanceLut()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xCC3674", Offset = "0xCC3674", VA = "0xCC3674")]
		private void UpdateHeightLut()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xCC388C", Offset = "0xCC388C", VA = "0xCC388C")]
		public FlatKitFog()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6D9B4C", Offset = "0x6D9B4C")]
	public class FogSettings : ScriptableObject
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E66D0", Offset = "0x6E66D0")]
		public bool useDistance;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Gradient distanceGradient;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float near;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float far;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E6708", Offset = "0x6E6708")]
		public float distanceFogIntensity;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useDistanceFogOnSky;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6720", Offset = "0x6E6720")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E6720", Offset = "0x6E6720")]
		public bool useHeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Gradient heightGradient;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float low;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float high;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E676C", Offset = "0x6E676C")]
		public float heightFogIntensity;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool useHeightFogOnSky;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6784", Offset = "0x6E6784")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E6784", Offset = "0x6E6784")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E6784", Offset = "0x6E6784")]
		public float distanceHeightBlend;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E67E8", Offset = "0x6E67E8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E67E8", Offset = "0x6E67E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E67E8", Offset = "0x6E67E8")]
		public RenderPassEvent renderEvent;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xCC5878", Offset = "0xCC5878", VA = "0xCC5878")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xCC5954", Offset = "0xCC5954", VA = "0xCC5954")]
		public FogSettings()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class FlatKitOutline : ScriptableRendererFeature
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6858", Offset = "0x6E6858")]
		public OutlineSettings settings;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private Material _effectMaterial;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BlitTexturePass _blitTexturePass;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private Shader _blitShader;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string OutlineShaderName;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int EdgeColor;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int Thickness;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int DepthThresholdMin;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int DepthThresholdMax;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int NormalThresholdMin;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int NormalThresholdMax;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int ColorThresholdMin;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int ColorThresholdMax;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xCC3B38", Offset = "0xCC3B38", VA = "0xCC3B38", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xCC3CC4", Offset = "0xCC3CC4", VA = "0xCC3CC4", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xCC42F8", Offset = "0xCC42F8", VA = "0xCC42F8", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xCC3DFC", Offset = "0xCC3DFC", VA = "0xCC3DFC")]
		private bool CreateMaterials()
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xCC3FB4", Offset = "0xCC3FB4", VA = "0xCC3FB4")]
		private void SetMaterialProperties()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xCC4360", Offset = "0xCC4360", VA = "0xCC4360")]
		public FlatKitOutline()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6D9BAC", Offset = "0x6D9BAC")]
	public class OutlineSettings : ScriptableObject
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color edgeColor;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E6900", Offset = "0x6E6900")]
		public int thickness;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6918", Offset = "0x6E6918")]
		public bool resolutionInvariant;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6950", Offset = "0x6E6950")]
		public bool useDepth;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool useNormals;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		public bool useColor;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E6960", Offset = "0x6E6960")]
		public float minDepthThreshold;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxDepthThreshold;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6998", Offset = "0x6E6998")]
		public float minNormalsThreshold;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxNormalsThreshold;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E69A8", Offset = "0x6E69A8")]
		public float minColorThreshold;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxColorThreshold;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E69B8", Offset = "0x6E69B8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E69B8", Offset = "0x6E69B8")]
		public RenderPassEvent renderEvent;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6A04", Offset = "0x6E6A04")]
		public bool outlineOnly;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xFCBD2C", Offset = "0xFCBD2C", VA = "0xFCBD2C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xFCBE54", Offset = "0xFCBE54", VA = "0xFCBE54")]
		public OutlineSettings()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class Buoyancy : MonoBehaviour
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6A14", Offset = "0x6E6A14")]
		public Transform water;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6A4C", Offset = "0x6E6A4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6A4C", Offset = "0x6E6A4C")]
		public float size;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6A98", Offset = "0x6E6A98")]
		public float amplitude;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6AD0", Offset = "0x6E6AD0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6AD0", Offset = "0x6E6AD0")]
		public Material overrideWaterMaterial;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _material;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _speed;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _amplitude;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _frequency;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _direction;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalPosition;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x111E464", Offset = "0x111E464", VA = "0x111E464")]
		private void Start()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x111E60C", Offset = "0x111E60C", VA = "0x111E60C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x111E8AC", Offset = "0x111E8AC", VA = "0x111E8AC")]
		private Vector2 GradientNoiseDir(Vector2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x111E980", Offset = "0x111E980", VA = "0x111E980")]
		private float GradientNoise(Vector2 p)
		{
			return default(float);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x111E7A8", Offset = "0x111E7A8", VA = "0x111E7A8")]
		private Vector3 GetNormalWS(Vector3 positionOS)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x111EB5C", Offset = "0x111EB5C", VA = "0x111EB5C")]
		private float SineWave(Vector3 positionOS, float offset)
		{
			return default(float);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x111E6E8", Offset = "0x111E6E8", VA = "0x111E6E8")]
		private float GetHeightOS(Vector3 positionOS)
		{
			return default(float);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x111EC4C", Offset = "0x111EC4C", VA = "0x111EC4C")]
		public Buoyancy()
		{
		}
	}
}
namespace Dustyroom
{
	[Token(Token = "0x200009C")]
	public class LinearMotion : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		public enum TranslationMode
		{
			[Token(Token = "0x40001D3")]
			Off,
			[Token(Token = "0x40001D4")]
			XAxis,
			[Token(Token = "0x40001D5")]
			YAxis,
			[Token(Token = "0x40001D6")]
			ZAxis,
			[Token(Token = "0x40001D7")]
			Vector
		}

		[Token(Token = "0x200009E")]
		public enum RotationMode
		{
			[Token(Token = "0x40001D9")]
			Off,
			[Token(Token = "0x40001DA")]
			XAxis,
			[Token(Token = "0x40001DB")]
			YAxis,
			[Token(Token = "0x40001DC")]
			ZAxis,
			[Token(Token = "0x40001DD")]
			Vector
		}

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TranslationMode translationMode;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 translationVector;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float translationSpeed;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RotationMode rotationMode;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 rotationAxis;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float rotationSpeed;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useLocalCoordinate;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float translationAcceleration;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rotationAcceleration;

		[Token(Token = "0x17000038")]
		private Vector3 TranslationVector
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xFC5F9C", Offset = "0xFC5F9C", VA = "0xFC5F9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000039")]
		private Vector3 RotationVector
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xFC6040", Offset = "0xFC6040", VA = "0xFC6040")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xFC60E4", Offset = "0xFC60E4", VA = "0xFC60E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xFC62EC", Offset = "0xFC62EC", VA = "0xFC62EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xFC630C", Offset = "0xFC630C", VA = "0xFC630C")]
		public LinearMotion()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class OrbitMotion : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		public enum TargetMode
		{
			[Token(Token = "0x40001F8")]
			Transform,
			[Token(Token = "0x40001F9")]
			Position
		}

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TargetMode targetMode;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetTransform;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool followTargetTransform;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 targetOffset;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 targetPosition;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6B1C", Offset = "0x6E6B1C")]
		public float distanceHorizontal;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceVertical;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float xSpeed;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float ySpeed;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float damping;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6B2C", Offset = "0x6E6B2C")]
		public bool clampAngle;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float yMinLimit;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float yMaxLimit;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6B3C", Offset = "0x6E6B3C")]
		public bool allowZoom;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float distanceMin;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float distanceMax;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _x;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _y;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6B4C", Offset = "0x6E6B4C")]
		public bool autoMovement;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float autoSpeedX;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float autoSpeedY;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float autoSpeedDistance;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6E6B5C", Offset = "0x6E6B5C")]
		public bool interactive;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _lastMoveTime;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public float timeSinceLastMove;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xFCB620", Offset = "0xFCB620", VA = "0xFCB620")]
		private void Start()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xFCB7C8", Offset = "0xFCB7C8", VA = "0xFCB7C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xFCBC74", Offset = "0xFCBC74", VA = "0xFCBC74")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xFCBCA4", Offset = "0xFCBCA4", VA = "0xFCBCA4")]
		public OrbitMotion()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D9C0C", Offset = "0x6D9C0C")]
	public class BehaviorTree : Behavior
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x111D13C", Offset = "0x111D13C", VA = "0x111D13C")]
		public BehaviorTree()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class ExternalBehaviorTree : ExternalBehavior
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCC2170", Offset = "0xCC2170", VA = "0xCC2170")]
		public ExternalBehaviorTree()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class SharedAnimationCurve : SharedVariable<AnimationCurve>
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xC99B4C", Offset = "0xC99B4C", VA = "0xC99B4C")]
		public static implicit operator SharedAnimationCurve(AnimationCurve value)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xC99BBC", Offset = "0xC99BBC", VA = "0xC99BBC")]
		public SharedAnimationCurve()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class SharedBehaviour : SharedVariable<Behaviour>
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xC99C08", Offset = "0xC99C08", VA = "0xC99C08")]
		public static explicit operator SharedBehaviour(Behaviour value)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xC99C78", Offset = "0xC99C78", VA = "0xC99C78")]
		public SharedBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class SharedBool : SharedVariable<bool>
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xC88BD4", Offset = "0xC88BD4", VA = "0xC88BD4")]
		public static implicit operator SharedBool(bool value)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xC99CC4", Offset = "0xC99CC4", VA = "0xC99CC4")]
		public SharedBool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class SharedCollider : SharedVariable<Collider>
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xC99D10", Offset = "0xC99D10", VA = "0xC99D10")]
		public static implicit operator SharedCollider(Collider value)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xC99D80", Offset = "0xC99D80", VA = "0xC99D80")]
		public SharedCollider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class SharedColor : SharedVariable<Color>
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xC8A228", Offset = "0xC8A228", VA = "0xC8A228")]
		public static implicit operator SharedColor(Color value)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xC99DCC", Offset = "0xC99DCC", VA = "0xC99DCC")]
		public SharedColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class SharedFloat : SharedVariable<float>
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0xC8A968", Offset = "0xC8A968", VA = "0xC8A968")]
		public static implicit operator SharedFloat(float value)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xC99E18", Offset = "0xC99E18", VA = "0xC99E18")]
		public SharedFloat()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class SharedGameObject : SharedVariable<GameObject>
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xC99E64", Offset = "0xC99E64", VA = "0xC99E64")]
		public static implicit operator SharedGameObject(GameObject value)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xC99ED4", Offset = "0xC99ED4", VA = "0xC99ED4")]
		public SharedGameObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class SharedGameObjectList : SharedVariable<List<GameObject>>
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xC99F20", Offset = "0xC99F20", VA = "0xC99F20")]
		public static implicit operator SharedGameObjectList(List<GameObject> value)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xC99F90", Offset = "0xC99F90", VA = "0xC99F90")]
		public SharedGameObjectList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class SharedInt : SharedVariable<int>
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xC8B10C", Offset = "0xC8B10C", VA = "0xC8B10C")]
		public static implicit operator SharedInt(int value)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xC9A348", Offset = "0xC9A348", VA = "0xC9A348")]
		public SharedInt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class SharedLayerMask : SharedVariable<LayerMask>
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xC9A394", Offset = "0xC9A394", VA = "0xC9A394")]
		public static implicit operator SharedLayerMask(LayerMask value)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xC9A418", Offset = "0xC9A418", VA = "0xC9A418")]
		public SharedLayerMask()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class SharedMaterial : SharedVariable<Material>
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC9A464", Offset = "0xC9A464", VA = "0xC9A464")]
		public static implicit operator SharedMaterial(Material value)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC9A4D4", Offset = "0xC9A4D4", VA = "0xC9A4D4")]
		public SharedMaterial()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class SharedObject : SharedVariable<UnityEngine.Object>
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC9A520", Offset = "0xC9A520", VA = "0xC9A520")]
		public static explicit operator SharedObject(UnityEngine.Object value)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xC9A590", Offset = "0xC9A590", VA = "0xC9A590")]
		public SharedObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class SharedObjectList : SharedVariable<List<UnityEngine.Object>>
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xC9A5DC", Offset = "0xC9A5DC", VA = "0xC9A5DC")]
		public static implicit operator SharedObjectList(List<UnityEngine.Object> value)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xC9A64C", Offset = "0xC9A64C", VA = "0xC9A64C")]
		public SharedObjectList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class SharedQuaternion : SharedVariable<Quaternion>
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xC8F400", Offset = "0xC8F400", VA = "0xC8F400")]
		public static implicit operator SharedQuaternion(Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xC9A698", Offset = "0xC9A698", VA = "0xC9A698")]
		public SharedQuaternion()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class SharedRect : SharedVariable<Rect>
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xC94F58", Offset = "0xC94F58", VA = "0xC94F58")]
		public static implicit operator SharedRect(Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xC9A6E4", Offset = "0xC9A6E4", VA = "0xC9A6E4")]
		public SharedRect()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class SharedString : SharedVariable<string>
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xC892E0", Offset = "0xC892E0", VA = "0xC892E0")]
		public static implicit operator SharedString(string value)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xC9A730", Offset = "0xC9A730", VA = "0xC9A730")]
		public SharedString()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class SharedTransform : SharedVariable<Transform>
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xC9A77C", Offset = "0xC9A77C", VA = "0xC9A77C")]
		public static implicit operator SharedTransform(Transform value)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xC9A7EC", Offset = "0xC9A7EC", VA = "0xC9A7EC")]
		public SharedTransform()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class SharedTransformList : SharedVariable<List<Transform>>
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xC9A838", Offset = "0xC9A838", VA = "0xC9A838")]
		public static implicit operator SharedTransformList(List<Transform> value)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xC9A8A8", Offset = "0xC9A8A8", VA = "0xC9A8A8")]
		public SharedTransformList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class SharedUInt : SharedVariable<uint>
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xC9AC4C", Offset = "0xC9AC4C", VA = "0xC9AC4C")]
		public static implicit operator SharedUInt(uint value)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xC9ACB0", Offset = "0xC9ACB0", VA = "0xC9ACB0")]
		public SharedUInt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class SharedVector2 : SharedVariable<Vector2>
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xC953AC", Offset = "0xC953AC", VA = "0xC953AC")]
		public static implicit operator SharedVector2(Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xC9ACFC", Offset = "0xC9ACFC", VA = "0xC9ACFC")]
		public SharedVector2()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class SharedVector2Int : SharedVariable<Vector2Int>
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xC9AD48", Offset = "0xC9AD48", VA = "0xC9AD48")]
		public static implicit operator SharedVector2Int(Vector2Int value)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xC9ADAC", Offset = "0xC9ADAC", VA = "0xC9ADAC")]
		public SharedVector2Int()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class SharedVector3 : SharedVariable<Vector3>
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xC895B4", Offset = "0xC895B4", VA = "0xC895B4")]
		public static implicit operator SharedVector3(Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xC9ADF8", Offset = "0xC9ADF8", VA = "0xC9ADF8")]
		public SharedVector3()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class SharedVector3Int : SharedVariable<Vector3Int>
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xC9AE44", Offset = "0xC9AE44", VA = "0xC9AE44")]
		public static implicit operator SharedVector3Int(Vector3Int value)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xC9AEB8", Offset = "0xC9AEB8", VA = "0xC9AEB8")]
		public SharedVector3Int()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class SharedVector4 : SharedVariable<Vector4>
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xC955D4", Offset = "0xC955D4", VA = "0xC955D4")]
		public static implicit operator SharedVector4(Vector4 value)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xC9AF04", Offset = "0xC9AF04", VA = "0xC9AF04")]
		public SharedVector4()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.ObjectDrawers
{
	[Token(Token = "0x20000BB")]
	public class FloatSliderAttribute : ObjectDrawerAttribute
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float min;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float max;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xCC5134", Offset = "0xCC5134", VA = "0xCC5134")]
		public FloatSliderAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class IntSliderAttribute : ObjectDrawerAttribute
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int min;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int max;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xFBFAA4", Offset = "0xFBFAA4", VA = "0xFBFAA4")]
		public IntSliderAttribute(int min, int max)
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks
{
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9C44", Offset = "0x6D9C44")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9C44", Offset = "0x6D9C44")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9C44", Offset = "0x6D9C44")]
	public class BehaviorTreeReference : BehaviorReference
	{
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x111D144", Offset = "0x111D144", VA = "0x111D144")]
		public BehaviorTreeReference()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9CC8", Offset = "0x6D9CC8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9CC8", Offset = "0x6D9CC8")]
	public class Idle : Action
	{
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xFBF0F0", Offset = "0xFBF0F0", VA = "0xFBF0F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xFBF0F8", Offset = "0xFBF0F8", VA = "0xFBF0F8")]
		public Idle()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9D28", Offset = "0x6D9D28")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9D28", Offset = "0x6D9D28")]
	public class Log : Action
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6B7C", Offset = "0x6E6B7C")]
		public SharedString text;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6BB4", Offset = "0x6E6BB4")]
		public SharedBool logError;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6BEC", Offset = "0x6E6BEC")]
		public SharedBool logTime;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xFC6694", Offset = "0xFC6694", VA = "0xFC6694", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xFC6844", Offset = "0xFC6844", VA = "0xFC6844", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xFC68D8", Offset = "0xFC68D8", VA = "0xFC68D8")]
		public Log()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9D88", Offset = "0x6D9D88")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9D88", Offset = "0x6D9D88")]
	public class PerformInterruption : Action
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6C24", Offset = "0x6E6C24")]
		public Interrupt[] interruptTasks;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6C5C", Offset = "0x6E6C5C")]
		public SharedBool interruptSuccess;

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xFCD340", Offset = "0xFCD340", VA = "0xFCD340", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xFCD404", Offset = "0xFCD404", VA = "0xFCD404", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xFCD448", Offset = "0xFCD448", VA = "0xFCD448")]
		public PerformInterruption()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9DE8", Offset = "0x6D9DE8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9DE8", Offset = "0x6D9DE8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6D9DE8", Offset = "0x6D9DE8")]
	public class GetFieldValue : Action
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6C94", Offset = "0x6E6C94")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6CCC", Offset = "0x6E6CCC")]
		public SharedString componentName;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6D04", Offset = "0x6E6D04")]
		public SharedString fieldName;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6D3C", Offset = "0x6E6D3C")]
		[RequiredField]
		public SharedVariable fieldValue;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xCCCE4C", Offset = "0xCCCE4C", VA = "0xCCCE4C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xCCD130", Offset = "0xCCD130", VA = "0xCCD130", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xCCD184", Offset = "0xCCD184", VA = "0xCCD184")]
		public GetFieldValue()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9E6C", Offset = "0x6D9E6C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6D9E6C", Offset = "0x6D9E6C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9E6C", Offset = "0x6D9E6C")]
	public class GetPropertyValue : Action
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6D88", Offset = "0x6E6D88")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6DC0", Offset = "0x6E6DC0")]
		public SharedString componentName;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6DF8", Offset = "0x6E6DF8")]
		public SharedString propertyName;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6E30", Offset = "0x6E6E30")]
		public SharedVariable propertyValue;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xCD3308", Offset = "0xCD3308", VA = "0xCD3308", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xCD35F0", Offset = "0xCD35F0", VA = "0xCD35F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xCD3644", Offset = "0xCD3644", VA = "0xCD3644")]
		public GetPropertyValue()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9EF0", Offset = "0x6D9EF0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9EF0", Offset = "0x6D9EF0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6D9EF0", Offset = "0x6D9EF0")]
	public class InvokeMethod : Action
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6E7C", Offset = "0x6E6E7C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6EB4", Offset = "0x6E6EB4")]
		public SharedString componentName;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6EEC", Offset = "0x6E6EEC")]
		public SharedString methodName;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6F24", Offset = "0x6E6F24")]
		public SharedVariable parameter1;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6F5C", Offset = "0x6E6F5C")]
		public SharedVariable parameter2;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6F94", Offset = "0x6E6F94")]
		public SharedVariable parameter3;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E6FCC", Offset = "0x6E6FCC")]
		public SharedVariable parameter4;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7004", Offset = "0x6E7004")]
		public SharedVariable storeResult;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xFBFF24", Offset = "0xFBFF24", VA = "0xFBFF24", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xFC04B8", Offset = "0xFC04B8", VA = "0xFC04B8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xFC054C", Offset = "0xFC054C", VA = "0xFC054C")]
		public InvokeMethod()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9F74", Offset = "0x6D9F74")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9F74", Offset = "0x6D9F74")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6D9F74", Offset = "0x6D9F74")]
	public class SetFieldValue : Action
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E703C", Offset = "0x6E703C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7074", Offset = "0x6E7074")]
		public SharedString componentName;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E70AC", Offset = "0x6E70AC")]
		public SharedString fieldName;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E70E4", Offset = "0x6E70E4")]
		public SharedVariable fieldValue;

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xC8C044", Offset = "0xC8C044", VA = "0xC8C044", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xC8C328", Offset = "0xC8C328", VA = "0xC8C328", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xC8C37C", Offset = "0xC8C37C", VA = "0xC8C37C")]
		public SetFieldValue()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6D9FF8", Offset = "0x6D9FF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6D9FF8", Offset = "0x6D9FF8")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6D9FF8", Offset = "0x6D9FF8")]
	public class SetPropertyValue : Action
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E711C", Offset = "0x6E711C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7154", Offset = "0x6E7154")]
		public SharedString componentName;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E718C", Offset = "0x6E718C")]
		public SharedString propertyName;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E71C4", Offset = "0x6E71C4")]
		public SharedVariable propertyValue;

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xC92200", Offset = "0xC92200", VA = "0xC92200", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xC924F0", Offset = "0xC924F0", VA = "0xC924F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xC92544", Offset = "0xC92544", VA = "0xC92544")]
		public SetPropertyValue()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA07C", Offset = "0x6DA07C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA07C", Offset = "0x6DA07C")]
	public class RestartBehaviorTree : Action
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E71FC", Offset = "0x6E71FC")]
		public SharedGameObject behaviorGameObject;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7234", Offset = "0x6E7234")]
		public SharedInt group;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Behavior behavior;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xFD15F8", Offset = "0xFD15F8", VA = "0xFD15F8", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xFD17AC", Offset = "0xFD17AC", VA = "0xFD17AC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xFD1850", Offset = "0xFD1850", VA = "0xFD1850", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xFD185C", Offset = "0xFD185C", VA = "0xFD185C")]
		public RestartBehaviorTree()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6DA0DC", Offset = "0x6DA0DC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA0DC", Offset = "0x6DA0DC")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA0DC", Offset = "0x6DA0DC")]
	public class SendEvent : Action
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E726C", Offset = "0x6E726C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E72A4", Offset = "0x6E72A4")]
		public SharedString eventName;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E72DC", Offset = "0x6E72DC")]
		public SharedInt group;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7314", Offset = "0x6E7314")]
		[SharedRequired]
		public SharedVariable argument1;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7360", Offset = "0x6E7360")]
		[SharedRequired]
		public SharedVariable argument2;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E73AC", Offset = "0x6E73AC")]
		[SharedRequired]
		public SharedVariable argument3;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BehaviorTree behaviorTree;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xFD3FA4", Offset = "0xFD3FA4", VA = "0xFD3FA4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xFD4158", Offset = "0xFD4158", VA = "0xFD4158", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xFD43A8", Offset = "0xFD43A8", VA = "0xFD43A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xFD4414", Offset = "0xFD4414", VA = "0xFD4414")]
		public SendEvent()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA160", Offset = "0x6DA160")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA160", Offset = "0x6DA160")]
	public class StackedAction : Action
	{
		[Token(Token = "0x20000C9")]
		public enum ComparisonType
		{
			[Token(Token = "0x4000229")]
			Sequence,
			[Token(Token = "0x400022A")]
			Selector
		}

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[InspectTask]
		public Action[] actions;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7408", Offset = "0x6E7408")]
		public ComparisonType comparisonType;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7440", Offset = "0x6E7440")]
		public bool graphLabel;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xC9F5C8", Offset = "0xC9F5C8", VA = "0xC9F5C8", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xC9F6B8", Offset = "0xC9F6B8", VA = "0xC9F6B8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xC9F728", Offset = "0xC9F728", VA = "0xC9F728", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xC9F7D4", Offset = "0xC9F7D4", VA = "0xC9F7D4", Slot = "8")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xC9F844", Offset = "0xC9F844", VA = "0xC9F844", Slot = "7")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xC9F8B4", Offset = "0xC9F8B4", VA = "0xC9F8B4", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xC9F924", Offset = "0xC9F924", VA = "0xC9F924", Slot = "21")]
		public override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xC9F9A8", Offset = "0xC9F9A8", VA = "0xC9F9A8", Slot = "25")]
		public override void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xC9FA2C", Offset = "0xC9FA2C", VA = "0xC9FA2C", Slot = "22")]
		public override void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xC9FAB0", Offset = "0xC9FAB0", VA = "0xC9FAB0", Slot = "26")]
		public override void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xC9FB34", Offset = "0xC9FB34", VA = "0xC9FB34", Slot = "19")]
		public override void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xC9FBB8", Offset = "0xC9FBB8", VA = "0xC9FBB8", Slot = "23")]
		public override void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xC9FC3C", Offset = "0xC9FC3C", VA = "0xC9FC3C", Slot = "20")]
		public override void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xC9FCC0", Offset = "0xC9FCC0", VA = "0xC9FCC0", Slot = "24")]
		public override void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xC9FD44", Offset = "0xC9FD44", VA = "0xC9FD44", Slot = "18")]
		public override string OnDrawNodeText()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xC9FE8C", Offset = "0xC9FE8C", VA = "0xC9FE8C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xC9FF00", Offset = "0xC9FF00", VA = "0xC9FF00")]
		public StackedAction()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA1C0", Offset = "0x6DA1C0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA1C0", Offset = "0x6DA1C0")]
	public class StartBehaviorTree : Action
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7478", Offset = "0x6E7478")]
		public SharedGameObject behaviorGameObject;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E74B0", Offset = "0x6E74B0")]
		public SharedInt group;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E74E8", Offset = "0x6E74E8")]
		public SharedBool waitForCompletion;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7520", Offset = "0x6E7520")]
		public SharedBool synchronizeVariables;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool behaviorComplete;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Behavior behavior;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xCA0848", Offset = "0xCA0848", VA = "0xCA0848", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xCA0BB0", Offset = "0xCA0BB0", VA = "0xCA0BB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xCA0C6C", Offset = "0xCA0C6C", VA = "0xCA0C6C")]
		private void BehaviorEnded(Behavior behavior)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xCA0C78", Offset = "0xCA0C78", VA = "0xCA0C78", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xCA0D88", Offset = "0xCA0D88", VA = "0xCA0D88", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xCA0DF8", Offset = "0xCA0DF8", VA = "0xCA0DF8")]
		public StartBehaviorTree()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA220", Offset = "0x6DA220")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA220", Offset = "0x6DA220")]
	public class StopBehaviorTree : Action
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7558", Offset = "0x6E7558")]
		public SharedGameObject behaviorGameObject;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7590", Offset = "0x6E7590")]
		public SharedInt group;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E75C8", Offset = "0x6E75C8")]
		public SharedBool pauseBehavior;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Behavior behavior;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xCA1D3C", Offset = "0xCA1D3C", VA = "0xCA1D3C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xCA1EF0", Offset = "0xCA1EF0", VA = "0xCA1EF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xCA1FB0", Offset = "0xCA1FB0", VA = "0xCA1FB0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xCA2008", Offset = "0xCA2008", VA = "0xCA2008")]
		public StopBehaviorTree()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA280", Offset = "0x6DA280")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA280", Offset = "0x6DA280")]
	public class Wait : Action
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7600", Offset = "0x6E7600")]
		public SharedFloat waitTime;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7638", Offset = "0x6E7638")]
		public SharedBool randomWait;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7670", Offset = "0x6E7670")]
		public SharedFloat randomWaitMin;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E76A8", Offset = "0x6E76A8")]
		public SharedFloat randomWaitMax;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float waitDuration;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float startTime;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float pauseTime;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x18DBB30", Offset = "0x18DBB30", VA = "0x18DBB30", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x18DBC08", Offset = "0x18DBC08", VA = "0x18DBC08", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x18DBC40", Offset = "0x18DBC40", VA = "0x18DBC40", Slot = "10")]
		public override void OnPause(bool paused)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x18DBC94", Offset = "0x18DBC94", VA = "0x18DBC94", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x18DBD28", Offset = "0x18DBD28", VA = "0x18DBD28")]
		public Wait()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA2E0", Offset = "0x6DA2E0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA2E0", Offset = "0x6DA2E0")]
	public class Parallel : Composite
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus[] executionStatus;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xFCBFE0", Offset = "0xFCBFE0", VA = "0xFCBFE0", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xFCC054", Offset = "0xFCC054", VA = "0xFCC054", Slot = "40")]
		public override void OnChildStarted(int childIndex)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xFCC0A0", Offset = "0xFCC0A0", VA = "0xFCC0A0", Slot = "32")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xFCC0A8", Offset = "0xFCC0A8", VA = "0xFCC0A8", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xFCC0B0", Offset = "0xFCC0B0", VA = "0xFCC0B0", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xFCC108", Offset = "0xFCC108", VA = "0xFCC108", Slot = "38")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xFCC144", Offset = "0xFCC144", VA = "0xFCC144", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xFCC1D4", Offset = "0xFCC1D4", VA = "0xFCC1D4", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xFCC22C", Offset = "0xFCC22C", VA = "0xFCC22C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xFCC284", Offset = "0xFCC284", VA = "0xFCC284")]
		public Parallel()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA340", Offset = "0x6DA340")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA340", Offset = "0x6DA340")]
	public class ParallelComplete : Composite
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus[] executionStatus;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xFCC28C", Offset = "0xFCC28C", VA = "0xFCC28C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xFCC300", Offset = "0xFCC300", VA = "0xFCC300", Slot = "40")]
		public override void OnChildStarted(int childIndex)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xFCC34C", Offset = "0xFCC34C", VA = "0xFCC34C", Slot = "32")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xFCC354", Offset = "0xFCC354", VA = "0xFCC354", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xFCC35C", Offset = "0xFCC35C", VA = "0xFCC35C", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xFCC3B4", Offset = "0xFCC3B4", VA = "0xFCC3B4", Slot = "38")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xFCC3F0", Offset = "0xFCC3F0", VA = "0xFCC3F0", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xFCC448", Offset = "0xFCC448", VA = "0xFCC448", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xFCC4BC", Offset = "0xFCC4BC", VA = "0xFCC4BC", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xFCC514", Offset = "0xFCC514", VA = "0xFCC514")]
		public ParallelComplete()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA3A0", Offset = "0x6DA3A0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA3A0", Offset = "0x6DA3A0")]
	public class ParallelSelector : Composite
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus[] executionStatus;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xFCC51C", Offset = "0xFCC51C", VA = "0xFCC51C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xFCC590", Offset = "0xFCC590", VA = "0xFCC590", Slot = "40")]
		public override void OnChildStarted(int childIndex)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xFCC5DC", Offset = "0xFCC5DC", VA = "0xFCC5DC", Slot = "32")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xFCC5E4", Offset = "0xFCC5E4", VA = "0xFCC5E4", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xFCC5EC", Offset = "0xFCC5EC", VA = "0xFCC5EC", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xFCC644", Offset = "0xFCC644", VA = "0xFCC644", Slot = "38")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xFCC680", Offset = "0xFCC680", VA = "0xFCC680", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xFCC6D8", Offset = "0xFCC6D8", VA = "0xFCC6D8", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xFCC768", Offset = "0xFCC768", VA = "0xFCC768", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xFCC7C0", Offset = "0xFCC7C0", VA = "0xFCC7C0")]
		public ParallelSelector()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA400", Offset = "0x6DA400")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA400", Offset = "0x6DA400")]
	public class PrioritySelector : Composite
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> childrenExecutionOrder;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xFCEBF8", Offset = "0xFCEBF8", VA = "0xFCEBF8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xFCEDB8", Offset = "0xFCEDB8", VA = "0xFCEDB8", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xFCEE24", Offset = "0xFCEE24", VA = "0xFCEE24", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xFCEE90", Offset = "0xFCEE90", VA = "0xFCEE90", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xFCEEA0", Offset = "0xFCEEA0", VA = "0xFCEEA0", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xFCEEA8", Offset = "0xFCEEA8", VA = "0xFCEEA8", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xFCEEB0", Offset = "0xFCEEB0", VA = "0xFCEEB0")]
		public PrioritySelector()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA460", Offset = "0x6DA460")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA460", Offset = "0x6DA460")]
	public class RandomSelector : Composite
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E76E0", Offset = "0x6E76E0")]
		public int seed;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7718", Offset = "0x6E7718")]
		public bool useSeed;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> childIndexList;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Stack<int> childrenExecutionOrder;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TaskStatus executionStatus;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xFCFE58", Offset = "0xFCFE58", VA = "0xFCFE58", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xFCFF24", Offset = "0xFCFF24", VA = "0xFCFF24", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xFD0084", Offset = "0xFD0084", VA = "0xFD0084", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xFD00D8", Offset = "0xFD00D8", VA = "0xFD00D8", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xFD0140", Offset = "0xFD0140", VA = "0xFD0140", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xFD01C0", Offset = "0xFD01C0", VA = "0xFD01C0", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xFD0220", Offset = "0xFD0220", VA = "0xFD0220", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xFD0278", Offset = "0xFD0278", VA = "0xFD0278", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xFCFF28", Offset = "0xFCFF28", VA = "0xFCFF28")]
		private void ShuffleChilden()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xFD0284", Offset = "0xFD0284", VA = "0xFD0284")]
		public RandomSelector()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA4C0", Offset = "0x6DA4C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA4C0", Offset = "0x6DA4C0")]
	public class RandomSequence : Composite
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7750", Offset = "0x6E7750")]
		public int seed;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7788", Offset = "0x6E7788")]
		public bool useSeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> childIndexList;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Stack<int> childrenExecutionOrder;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TaskStatus executionStatus;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xFD0354", Offset = "0xFD0354", VA = "0xFD0354", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xFD0420", Offset = "0xFD0420", VA = "0xFD0420", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xFD0580", Offset = "0xFD0580", VA = "0xFD0580", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xFD05D4", Offset = "0xFD05D4", VA = "0xFD05D4", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xFD063C", Offset = "0xFD063C", VA = "0xFD063C", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xFD06BC", Offset = "0xFD06BC", VA = "0xFD06BC", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xFD071C", Offset = "0xFD071C", VA = "0xFD071C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xFD0774", Offset = "0xFD0774", VA = "0xFD0774", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xFD0424", Offset = "0xFD0424", VA = "0xFD0424")]
		private void ShuffleChilden()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xFD0780", Offset = "0xFD0780", VA = "0xFD0780")]
		public RandomSequence()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA520", Offset = "0x6DA520")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA520", Offset = "0x6DA520")]
	public class Selector : Composite
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xFD3C74", Offset = "0xFD3C74", VA = "0xFD3C74", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xFD3C7C", Offset = "0xFD3C7C", VA = "0xFD3C7C", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xFD3CE8", Offset = "0xFD3CE8", VA = "0xFD3CE8", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xFD3CF8", Offset = "0xFD3CF8", VA = "0xFD3CF8", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xFD3D00", Offset = "0xFD3D00", VA = "0xFD3D00", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xFD3D08", Offset = "0xFD3D08", VA = "0xFD3D08")]
		public Selector()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA580", Offset = "0x6DA580")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA580", Offset = "0x6DA580")]
	public class SelectorEvaluator : Composite
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int storedCurrentChildIndex;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TaskStatus storedExecutionStatus;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xFD3D10", Offset = "0xFD3D10", VA = "0xFD3D10", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xFD3D18", Offset = "0xFD3D18", VA = "0xFD3D18", Slot = "40")]
		public override void OnChildStarted(int childIndex)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xFD3D2C", Offset = "0xFD3D2C", VA = "0xFD3D2C", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xFD3DB0", Offset = "0xFD3DB0", VA = "0xFD3DB0", Slot = "38")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xFD3E50", Offset = "0xFD3E50", VA = "0xFD3E50", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xFD3E58", Offset = "0xFD3E58", VA = "0xFD3E58", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xFD3E60", Offset = "0xFD3E60", VA = "0xFD3E60", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xFD3E68", Offset = "0xFD3E68", VA = "0xFD3E68", Slot = "32")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xFD3E70", Offset = "0xFD3E70", VA = "0xFD3E70", Slot = "36")]
		public override bool CanReevaluate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xFD3E78", Offset = "0xFD3E78", VA = "0xFD3E78", Slot = "44")]
		public override bool OnReevaluationStarted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xFD3E9C", Offset = "0xFD3E9C", VA = "0xFD3E9C", Slot = "45")]
		public override void OnReevaluationEnded(TaskStatus status)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xFD3F94", Offset = "0xFD3F94", VA = "0xFD3F94")]
		public SelectorEvaluator()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA5E0", Offset = "0x6DA5E0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA5E0", Offset = "0x6DA5E0")]
	public class Sequence : Composite
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xFD45C4", Offset = "0xFD45C4", VA = "0xFD45C4", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xFD45CC", Offset = "0xFD45CC", VA = "0xFD45CC", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xFD4638", Offset = "0xFD4638", VA = "0xFD4638", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xFD4648", Offset = "0xFD4648", VA = "0xFD4648", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xFD4650", Offset = "0xFD4650", VA = "0xFD4650", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xFD4658", Offset = "0xFD4658", VA = "0xFD4658")]
		public Sequence()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA640", Offset = "0x6DA640")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA640", Offset = "0x6DA640")]
	public class UtilitySelector : Composite
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float highestUtility;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private TaskStatus executionStatus;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool reevaluating;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<int> availableChildren;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x18DB244", Offset = "0x18DB244", VA = "0x18DB244", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x18DB354", Offset = "0x18DB354", VA = "0x18DB354", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x18DB35C", Offset = "0x18DB35C", VA = "0x18DB35C", Slot = "40")]
		public override void OnChildStarted(int childIndex)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x18DB368", Offset = "0x18DB368", VA = "0x18DB368", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x18DB3DC", Offset = "0x18DB3DC", VA = "0x18DB3DC", Slot = "38")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x18DB548", Offset = "0x18DB548", VA = "0x18DB548", Slot = "43")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x18DB554", Offset = "0x18DB554", VA = "0x18DB554", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x18DB560", Offset = "0x18DB560", VA = "0x18DB560", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x18DB568", Offset = "0x18DB568", VA = "0x18DB568", Slot = "32")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x18DB570", Offset = "0x18DB570", VA = "0x18DB570", Slot = "36")]
		public override bool CanReevaluate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x18DB578", Offset = "0x18DB578", VA = "0x18DB578", Slot = "44")]
		public override bool OnReevaluationStarted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x18DB598", Offset = "0x18DB598", VA = "0x18DB598", Slot = "45")]
		public override void OnReevaluationEnded(TaskStatus status)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x18DB758", Offset = "0x18DB758", VA = "0x18DB758")]
		public UtilitySelector()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA6A0", Offset = "0x6DA6A0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DA6A0", Offset = "0x6DA6A0")]
	public class HasReceivedEvent : Conditional
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E77C0", Offset = "0x6E77C0")]
		public SharedString eventName;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E77F8", Offset = "0x6E77F8")]
		[SharedRequired]
		public SharedVariable storedValue1;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7844", Offset = "0x6E7844")]
		[SharedRequired]
		public SharedVariable storedValue2;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7890", Offset = "0x6E7890")]
		[SharedRequired]
		public SharedVariable storedValue3;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool eventReceived;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool registered;

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xCD9F38", Offset = "0xCD9F38", VA = "0xCD9F38", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xCDA1F8", Offset = "0xCDA1F8", VA = "0xCDA1F8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xCDA20C", Offset = "0xCDA20C", VA = "0xCDA20C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xCDA4CC", Offset = "0xCDA4CC", VA = "0xCDA4CC")]
		private void ReceivedEvent()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xCDA4D8", Offset = "0xCDA4D8", VA = "0xCDA4D8")]
		private void ReceivedEvent(object arg1)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xCDA538", Offset = "0xCDA538", VA = "0xCDA538")]
		private void ReceivedEvent(object arg1, object arg2)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xCDA5D4", Offset = "0xCDA5D4", VA = "0xCDA5D4")]
		private void ReceivedEvent(object arg1, object arg2, object arg3)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xCDA6A0", Offset = "0xCDA6A0", VA = "0xCDA6A0", Slot = "15")]
		public override void OnBehaviorComplete()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xCDA954", Offset = "0xCDA954", VA = "0xCDA954", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xCDA9B0", Offset = "0xCDA9B0", VA = "0xCDA9B0")]
		public HasReceivedEvent()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA700", Offset = "0x6DA700")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA700", Offset = "0x6DA700")]
	public class HasEnteredCollision : Conditional
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E78DC", Offset = "0x6E78DC")]
		public SharedString tag;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7914", Offset = "0x6E7914")]
		public SharedGameObject collidedGameObject;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool enteredCollision;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xCD8F88", Offset = "0xCD8F88", VA = "0xCD8F88", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xCD8F9C", Offset = "0xCD8F9C", VA = "0xCD8F9C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xCD8FA4", Offset = "0xCD8FA4", VA = "0xCD8FA4", Slot = "19")]
		public override void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xCD909C", Offset = "0xCD909C", VA = "0xCD909C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xCD9108", Offset = "0xCD9108", VA = "0xCD9108")]
		public HasEnteredCollision()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA760", Offset = "0x6DA760")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA760", Offset = "0x6DA760")]
	public class HasEnteredCollision2D : Conditional
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E794C", Offset = "0x6E794C")]
		public SharedString tag;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7984", Offset = "0x6E7984")]
		public SharedGameObject collidedGameObject;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool enteredCollision;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xCD9170", Offset = "0xCD9170", VA = "0xCD9170", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xCD9184", Offset = "0xCD9184", VA = "0xCD9184", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xCD918C", Offset = "0xCD918C", VA = "0xCD918C", Slot = "23")]
		public override void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xCD9284", Offset = "0xCD9284", VA = "0xCD9284", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xCD92F0", Offset = "0xCD92F0", VA = "0xCD92F0")]
		public HasEnteredCollision2D()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA7C0", Offset = "0x6DA7C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA7C0", Offset = "0x6DA7C0")]
	public class HasEnteredTrigger : Conditional
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E79BC", Offset = "0x6E79BC")]
		public SharedString tag;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E79F4", Offset = "0x6E79F4")]
		public SharedGameObject otherGameObject;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool enteredTrigger;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xCD9358", Offset = "0xCD9358", VA = "0xCD9358", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xCD936C", Offset = "0xCD936C", VA = "0xCD936C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xCD9374", Offset = "0xCD9374", VA = "0xCD9374", Slot = "21")]
		public override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xCD946C", Offset = "0xCD946C", VA = "0xCD946C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xCD94D8", Offset = "0xCD94D8", VA = "0xCD94D8")]
		public HasEnteredTrigger()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA820", Offset = "0x6DA820")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA820", Offset = "0x6DA820")]
	public class HasEnteredTrigger2D : Conditional
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7A2C", Offset = "0x6E7A2C")]
		public SharedString tag;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7A64", Offset = "0x6E7A64")]
		public SharedGameObject otherGameObject;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool enteredTrigger;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xCD9540", Offset = "0xCD9540", VA = "0xCD9540", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xCD9554", Offset = "0xCD9554", VA = "0xCD9554", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xCD955C", Offset = "0xCD955C", VA = "0xCD955C", Slot = "25")]
		public override void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xCD9654", Offset = "0xCD9654", VA = "0xCD9654", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xCD96C0", Offset = "0xCD96C0", VA = "0xCD96C0")]
		public HasEnteredTrigger2D()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA880", Offset = "0x6DA880")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA880", Offset = "0x6DA880")]
	public class HasExitedCollision : Conditional
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7A9C", Offset = "0x6E7A9C")]
		public SharedString tag;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7AD4", Offset = "0x6E7AD4")]
		public SharedGameObject collidedGameObject;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool exitedCollision;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xCD9728", Offset = "0xCD9728", VA = "0xCD9728", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xCD973C", Offset = "0xCD973C", VA = "0xCD973C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xCD9744", Offset = "0xCD9744", VA = "0xCD9744", Slot = "20")]
		public override void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xCD983C", Offset = "0xCD983C", VA = "0xCD983C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xCD9848", Offset = "0xCD9848", VA = "0xCD9848")]
		public HasExitedCollision()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA8E0", Offset = "0x6DA8E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA8E0", Offset = "0x6DA8E0")]
	public class HasExitedCollision2D : Conditional
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7B0C", Offset = "0x6E7B0C")]
		public SharedString tag;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7B44", Offset = "0x6E7B44")]
		public SharedGameObject collidedGameObject;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool exitedCollision;

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xCD98B0", Offset = "0xCD98B0", VA = "0xCD98B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xCD98C4", Offset = "0xCD98C4", VA = "0xCD98C4", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xCD98CC", Offset = "0xCD98CC", VA = "0xCD98CC", Slot = "24")]
		public override void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xCD99C4", Offset = "0xCD99C4", VA = "0xCD99C4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xCD9A30", Offset = "0xCD9A30", VA = "0xCD9A30")]
		public HasExitedCollision2D()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA940", Offset = "0x6DA940")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA940", Offset = "0x6DA940")]
	public class HasExitedTrigger : Conditional
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7B7C", Offset = "0x6E7B7C")]
		public SharedString tag;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7BB4", Offset = "0x6E7BB4")]
		public SharedGameObject otherGameObject;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool exitedTrigger;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xCD9A98", Offset = "0xCD9A98", VA = "0xCD9A98", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xCD9AAC", Offset = "0xCD9AAC", VA = "0xCD9AAC", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xCD9AB4", Offset = "0xCD9AB4", VA = "0xCD9AB4", Slot = "22")]
		public override void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xCD9BAC", Offset = "0xCD9BAC", VA = "0xCD9BAC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xCD9C18", Offset = "0xCD9C18", VA = "0xCD9C18")]
		public HasExitedTrigger()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DA9A0", Offset = "0x6DA9A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DA9A0", Offset = "0x6DA9A0")]
	public class HasExitedTrigger2D : Conditional
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7BEC", Offset = "0x6E7BEC")]
		public SharedString tag;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7C24", Offset = "0x6E7C24")]
		public SharedGameObject otherGameObject;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool exitedTrigger;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xCD9C80", Offset = "0xCD9C80", VA = "0xCD9C80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xCD9C94", Offset = "0xCD9C94", VA = "0xCD9C94", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xCD9C9C", Offset = "0xCD9C9C", VA = "0xCD9C9C", Slot = "26")]
		public override void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xCD9D94", Offset = "0xCD9D94", VA = "0xCD9D94", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xCD9E00", Offset = "0xCD9E00", VA = "0xCD9E00")]
		public HasExitedTrigger2D()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAA00", Offset = "0x6DAA00")]
	public class RandomProbability : Conditional
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7C5C", Offset = "0x6E7C5C")]
		public SharedFloat successProbability;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7C94", Offset = "0x6E7C94")]
		public SharedInt seed;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7CCC", Offset = "0x6E7CCC")]
		public SharedBool useSeed;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xFCFCA4", Offset = "0xFCFCA4", VA = "0xFCFCA4", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xFCFD34", Offset = "0xFCFD34", VA = "0xFCFD34", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xFCFDAC", Offset = "0xFCFDAC", VA = "0xFCFDAC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xFCFE18", Offset = "0xFCFE18", VA = "0xFCFE18")]
		public RandomProbability()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAA38", Offset = "0x6DAA38")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DAA38", Offset = "0x6DAA38")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAA38", Offset = "0x6DAA38")]
	public class CompareFieldValue : Conditional
	{
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7D04", Offset = "0x6E7D04")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7D3C", Offset = "0x6E7D3C")]
		public SharedString componentName;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7D74", Offset = "0x6E7D74")]
		public SharedString fieldName;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7DAC", Offset = "0x6E7DAC")]
		public SharedVariable compareValue;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1128670", Offset = "0x1128670", VA = "0x1128670", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1128994", Offset = "0x1128994", VA = "0x1128994", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x11289E8", Offset = "0x11289E8", VA = "0x11289E8")]
		public CompareFieldValue()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAABC", Offset = "0x6DAABC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DAABC", Offset = "0x6DAABC")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAABC", Offset = "0x6DAABC")]
	public class ComparePropertyValue : Conditional
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7DE4", Offset = "0x6E7DE4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7E1C", Offset = "0x6E7E1C")]
		public SharedString componentName;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7E54", Offset = "0x6E7E54")]
		public SharedString propertyName;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7E8C", Offset = "0x6E7E8C")]
		public SharedVariable compareValue;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1128A98", Offset = "0x1128A98", VA = "0x1128A98", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1128DC0", Offset = "0x1128DC0", VA = "0x1128DC0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1128E14", Offset = "0x1128E14", VA = "0x1128E14")]
		public ComparePropertyValue()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAB40", Offset = "0x6DAB40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAB40", Offset = "0x6DAB40")]
	public class StackedConditional : Conditional
	{
		[Token(Token = "0x20000E4")]
		public enum ComparisonType
		{
			[Token(Token = "0x4000289")]
			Sequence,
			[Token(Token = "0x400028A")]
			Selector
		}

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[InspectTask]
		public Conditional[] conditionals;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7ED4", Offset = "0x6E7ED4")]
		public ComparisonType comparisonType;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7F0C", Offset = "0x6E7F0C")]
		public bool graphLabel;

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xC9FF08", Offset = "0xC9FF08", VA = "0xC9FF08", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xC9FFF8", Offset = "0xC9FFF8", VA = "0xC9FFF8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xCA0068", Offset = "0xCA0068", VA = "0xCA0068", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xCA0114", Offset = "0xCA0114", VA = "0xCA0114", Slot = "8")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xCA0184", Offset = "0xCA0184", VA = "0xCA0184", Slot = "7")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xCA01F4", Offset = "0xCA01F4", VA = "0xCA01F4", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xCA0264", Offset = "0xCA0264", VA = "0xCA0264", Slot = "21")]
		public override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xCA02E8", Offset = "0xCA02E8", VA = "0xCA02E8", Slot = "25")]
		public override void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xCA036C", Offset = "0xCA036C", VA = "0xCA036C", Slot = "22")]
		public override void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xCA03F0", Offset = "0xCA03F0", VA = "0xCA03F0", Slot = "26")]
		public override void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xCA0474", Offset = "0xCA0474", VA = "0xCA0474", Slot = "19")]
		public override void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xCA04F8", Offset = "0xCA04F8", VA = "0xCA04F8", Slot = "23")]
		public override void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xCA057C", Offset = "0xCA057C", VA = "0xCA057C", Slot = "20")]
		public override void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xCA0600", Offset = "0xCA0600", VA = "0xCA0600", Slot = "24")]
		public override void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xCA0684", Offset = "0xCA0684", VA = "0xCA0684", Slot = "18")]
		public override string OnDrawNodeText()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xCA07CC", Offset = "0xCA07CC", VA = "0xCA07CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xCA0840", Offset = "0xCA0840", VA = "0xCA0840")]
		public StackedConditional()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DABA0", Offset = "0x6DABA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DABA0", Offset = "0x6DABA0")]
	public class ConditionalEvaluator : Decorator
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7F44", Offset = "0x6E7F44")]
		public SharedBool reevaluate;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[InspectTask]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7F7C", Offset = "0x6E7F7C")]
		public Conditional conditionalTask;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E7FC8", Offset = "0x6E7FC8")]
		public bool graphLabel;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private TaskStatus executionStatus;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool checkConditionalTask;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool conditionalTaskFailed;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x112A6E4", Offset = "0x112A6E4", VA = "0x112A6E4", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x112A75C", Offset = "0x112A75C", VA = "0x112A75C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x112A774", Offset = "0x112A774", VA = "0x112A774", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x112A7D4", Offset = "0x112A7D4", VA = "0x112A7D4", Slot = "36")]
		public override bool CanReevaluate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x112A828", Offset = "0x112A828", VA = "0x112A828", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x112A878", Offset = "0x112A878", VA = "0x112A878", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x112A880", Offset = "0x112A880", VA = "0x112A880", Slot = "42")]
		public override TaskStatus OverrideStatus()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x112A888", Offset = "0x112A888", VA = "0x112A888", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x112A898", Offset = "0x112A898", VA = "0x112A898", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x112A8C0", Offset = "0x112A8C0", VA = "0x112A8C0", Slot = "18")]
		public override string OnDrawNodeText()
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x112A944", Offset = "0x112A944", VA = "0x112A944", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x112A950", Offset = "0x112A950", VA = "0x112A950")]
		public ConditionalEvaluator()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAC00", Offset = "0x6DAC00")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAC00", Offset = "0x6DAC00")]
	public class Cooldown : Decorator
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SharedFloat duration;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float cooldownTime;

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x112A960", Offset = "0x112A960", VA = "0x112A960", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x112A9F0", Offset = "0x112A9F0", VA = "0x112A9F0", Slot = "33")]
		public override int CurrentChildIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x112AA04", Offset = "0x112AA04", VA = "0x112AA04", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x112AA3C", Offset = "0x112AA3C", VA = "0x112AA3C", Slot = "42")]
		public override TaskStatus OverrideStatus()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x112AA78", Offset = "0x112AA78", VA = "0x112AA78", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x112AA90", Offset = "0x112AA90", VA = "0x112AA90", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x112AA9C", Offset = "0x112AA9C", VA = "0x112AA9C")]
		public Cooldown()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAC60", Offset = "0x6DAC60")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAC60", Offset = "0x6DAC60")]
	public class Interrupt : Decorator
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskStatus interruptStatus;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private TaskStatus executionStatus;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xFBFADC", Offset = "0xFBFADC", VA = "0xFBFADC", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xFBFAF8", Offset = "0xFBFAF8", VA = "0xFBFAF8", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xFBFB00", Offset = "0xFBFB00", VA = "0xFBFB00")]
		public void DoInterrupt(TaskStatus status)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xFBFB90", Offset = "0xFBFB90", VA = "0xFBFB90", Slot = "42")]
		public override TaskStatus OverrideStatus()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xFBFB98", Offset = "0xFBFB98", VA = "0xFBFB98", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xFBFBA8", Offset = "0xFBFBA8", VA = "0xFBFBA8")]
		public Interrupt()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DACC0", Offset = "0x6DACC0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DACC0", Offset = "0x6DACC0")]
	public class Inverter : Decorator
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xFBFED0", Offset = "0xFBFED0", VA = "0xFBFED0", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xFBFEEC", Offset = "0xFBFEEC", VA = "0xFBFEEC", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xFBFEF4", Offset = "0xFBFEF4", VA = "0xFBFEF4", Slot = "35")]
		public override TaskStatus Decorate(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xFBFF14", Offset = "0xFBFF14", VA = "0xFBFF14", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xFBFF1C", Offset = "0xFBFF1C", VA = "0xFBFF1C")]
		public Inverter()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAD20", Offset = "0x6DAD20")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAD20", Offset = "0x6DAD20")]
	public class Repeater : Decorator
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8000", Offset = "0x6E8000")]
		public SharedInt count;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8038", Offset = "0x6E8038")]
		public SharedBool repeatForever;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8070", Offset = "0x6E8070")]
		public SharedBool endOnFailure;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int executionCount;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private TaskStatus executionStatus;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xFD10E4", Offset = "0xFD10E4", VA = "0xFD10E4", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xFD11BC", Offset = "0xFD11BC", VA = "0xFD11BC", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xFD11CC", Offset = "0xFD11CC", VA = "0xFD11CC", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xFD11D4", Offset = "0xFD11D4", VA = "0xFD11D4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xFD1224", Offset = "0xFD1224", VA = "0xFD1224")]
		public Repeater()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAD80", Offset = "0x6DAD80")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAD80", Offset = "0x6DAD80")]
	public class ReturnFailure : Decorator
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xFD1D24", Offset = "0xFD1D24", VA = "0xFD1D24", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xFD1D40", Offset = "0xFD1D40", VA = "0xFD1D40", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xFD1D48", Offset = "0xFD1D48", VA = "0xFD1D48", Slot = "35")]
		public override TaskStatus Decorate(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xFD1D54", Offset = "0xFD1D54", VA = "0xFD1D54", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xFD1D5C", Offset = "0xFD1D5C", VA = "0xFD1D5C")]
		public ReturnFailure()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DADE0", Offset = "0x6DADE0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DADE0", Offset = "0x6DADE0")]
	public class ReturnSuccess : Decorator
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xFD1D64", Offset = "0xFD1D64", VA = "0xFD1D64", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xFD1D80", Offset = "0xFD1D80", VA = "0xFD1D80", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xFD1D88", Offset = "0xFD1D88", VA = "0xFD1D88", Slot = "35")]
		public override TaskStatus Decorate(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xFD1D98", Offset = "0xFD1D98", VA = "0xFD1D98", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xFD1DA0", Offset = "0xFD1DA0", VA = "0xFD1DA0")]
		public ReturnSuccess()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAE40", Offset = "0x6DAE40")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAE40", Offset = "0x6DAE40")]
	public class TaskGuard : Decorator
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E80A8", Offset = "0x6E80A8")]
		public SharedInt maxTaskAccessCount;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E80E0", Offset = "0x6E80E0")]
		[LinkedTask]
		public TaskGuard[] linkedTaskGuards;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E812C", Offset = "0x6E812C")]
		public SharedBool waitUntilTaskAvailable;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int executingTasks;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool executing;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xCA244C", Offset = "0xCA244C", VA = "0xCA244C", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xCA24C4", Offset = "0xCA24C4", VA = "0xCA24C4", Slot = "39")]
		public override void OnChildStarted()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xCA2568", Offset = "0xCA2568", VA = "0xCA2568", Slot = "41")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xCA253C", Offset = "0xCA253C", VA = "0xCA253C")]
		public void taskExecuting(bool increase)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xCA25E8", Offset = "0xCA25E8", VA = "0xCA25E8", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xCA2664", Offset = "0xCA2664", VA = "0xCA2664", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xCA26B0", Offset = "0xCA26B0", VA = "0xCA26B0")]
		public TaskGuard()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAEA0", Offset = "0x6DAEA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAEA0", Offset = "0x6DAEA0")]
	public class UntilFailure : Decorator
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x18DAC7C", Offset = "0x18DAC7C", VA = "0x18DAC7C", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x18DAC90", Offset = "0x18DAC90", VA = "0x18DAC90", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x18DAC98", Offset = "0x18DAC98", VA = "0x18DAC98", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x18DACA0", Offset = "0x18DACA0", VA = "0x18DACA0")]
		public UntilFailure()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAF00", Offset = "0x6DAF00")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAF00", Offset = "0x6DAF00")]
	public class UntilSuccess : Decorator
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x18DACA8", Offset = "0x18DACA8", VA = "0x18DACA8", Slot = "34")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x18DACB8", Offset = "0x18DACB8", VA = "0x18DACB8", Slot = "37")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x18DACC0", Offset = "0x18DACC0", VA = "0x18DACC0", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x18DACC8", Offset = "0x18DACC8", VA = "0x18DACC8")]
		public UntilSuccess()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6DAF60", Offset = "0x6DAF60")]
	public class EntryTask : ParentTask
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xCC1944", Offset = "0xCC1944", VA = "0xCC1944", Slot = "31")]
		public override int MaxChildren()
		{
			return default(int);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xCC194C", Offset = "0xCC194C", VA = "0xCC194C")]
		public EntryTask()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DAF98", Offset = "0x6DAF98")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAF98", Offset = "0x6DAF98")]
	public class Angle : Action
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8164", Offset = "0x6E8164")]
		public SharedVector3 firstVector3;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E819C", Offset = "0x6E819C")]
		public SharedVector3 secondVector3;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E81D4", Offset = "0x6E81D4")]
		public SharedFloat storeResult;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x111ADCC", Offset = "0x111ADCC", VA = "0x111ADCC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x111AEA4", Offset = "0x111AEA4", VA = "0x111AEA4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x111AF18", Offset = "0x111AF18", VA = "0x111AF18")]
		public Angle()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DAFF8", Offset = "0x6DAFF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DAFF8", Offset = "0x6DAFF8")]
	public class ClampMagnitude : Action
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8220", Offset = "0x6E8220")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8258", Offset = "0x6E8258")]
		public SharedFloat maxLength;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8290", Offset = "0x6E8290")]
		[RequiredField]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1128314", Offset = "0x1128314", VA = "0x1128314", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x11283F0", Offset = "0x11283F0", VA = "0x11283F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1128464", Offset = "0x1128464", VA = "0x1128464")]
		public ClampMagnitude()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB058", Offset = "0x6DB058")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB058", Offset = "0x6DB058")]
	public class Distance : Action
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E82DC", Offset = "0x6E82DC")]
		public SharedVector3 firstVector3;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8314", Offset = "0x6E8314")]
		public SharedVector3 secondVector3;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E834C", Offset = "0x6E834C")]
		public SharedFloat storeResult;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x112C0B8", Offset = "0x112C0B8", VA = "0x112C0B8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x112C190", Offset = "0x112C190", VA = "0x112C190", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x112C204", Offset = "0x112C204", VA = "0x112C204")]
		public Distance()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB0B8", Offset = "0x6DB0B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB0B8", Offset = "0x6DB0B8")]
	public class Dot : Action
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8398", Offset = "0x6E8398")]
		public SharedVector3 leftHandSide;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E83D0", Offset = "0x6E83D0")]
		public SharedVector3 rightHandSide;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8408", Offset = "0x6E8408")]
		public SharedFloat storeResult;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x112C494", Offset = "0x112C494", VA = "0x112C494", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x112C560", Offset = "0x112C560", VA = "0x112C560", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x112C5D4", Offset = "0x112C5D4", VA = "0x112C5D4")]
		public Dot()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB118", Offset = "0x6DB118")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB118", Offset = "0x6DB118")]
	public class GetForwardVector : Action
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8454", Offset = "0x6E8454")]
		[RequiredField]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xCCD81C", Offset = "0xCCD81C", VA = "0xCCD81C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xCCD884", Offset = "0xCCD884", VA = "0xCCD884", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xCCD8BC", Offset = "0xCCD8BC", VA = "0xCCD8BC")]
		public GetForwardVector()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB178", Offset = "0x6DB178")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB178", Offset = "0x6DB178")]
	public class GetMagnitude : Action
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E84A0", Offset = "0x6E84A0")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E84D8", Offset = "0x6E84D8")]
		public SharedFloat storeResult;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xCD0C48", Offset = "0xCD0C48", VA = "0xCD0C48", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xCD0CF0", Offset = "0xCD0CF0", VA = "0xCD0CF0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xCD0D44", Offset = "0xCD0D44", VA = "0xCD0D44")]
		public GetMagnitude()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB1D8", Offset = "0x6DB1D8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB1D8", Offset = "0x6DB1D8")]
	public class GetRightVector : Action
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8524", Offset = "0x6E8524")]
		[RequiredField]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xCD4940", Offset = "0xCD4940", VA = "0xCD4940", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xCD49A8", Offset = "0xCD49A8", VA = "0xCD49A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xCD49E0", Offset = "0xCD49E0", VA = "0xCD49E0")]
		public GetRightVector()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB238", Offset = "0x6DB238")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB238", Offset = "0x6DB238")]
	public class GetSqrMagnitude : Action
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8570", Offset = "0x6E8570")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E85A8", Offset = "0x6E85A8")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xCD6774", Offset = "0xCD6774", VA = "0xCD6774", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xCD681C", Offset = "0xCD681C", VA = "0xCD681C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xCD6870", Offset = "0xCD6870", VA = "0xCD6870")]
		public GetSqrMagnitude()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB298", Offset = "0x6DB298")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB298", Offset = "0x6DB298")]
	public class GetUpVector : Action
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E85F4", Offset = "0x6E85F4")]
		[RequiredField]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xCD7C74", Offset = "0xCD7C74", VA = "0xCD7C74", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xCD7CDC", Offset = "0xCD7CDC", VA = "0xCD7CDC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xCD7D14", Offset = "0xCD7D14", VA = "0xCD7D14")]
		public GetUpVector()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB2F8", Offset = "0x6DB2F8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB2F8", Offset = "0x6DB2F8")]
	public class GetVector2 : Action
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8640", Offset = "0x6E8640")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8678", Offset = "0x6E8678")]
		[RequiredField]
		public SharedVector2 storeResult;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xCD7F84", Offset = "0xCD7F84", VA = "0xCD7F84", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xCD8008", Offset = "0xCD8008", VA = "0xCD8008", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xCD8060", Offset = "0xCD8060", VA = "0xCD8060")]
		public GetVector2()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB358", Offset = "0x6DB358")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB358", Offset = "0x6DB358")]
	public class GetXYZ : Action
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E86C4", Offset = "0x6E86C4")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E86FC", Offset = "0x6E86FC")]
		public SharedFloat storeX;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8748", Offset = "0x6E8748")]
		public SharedFloat storeY;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8794", Offset = "0x6E8794")]
		public SharedFloat storeZ;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xCD8C10", Offset = "0xCD8C10", VA = "0xCD8C10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xCD8CEC", Offset = "0xCD8CEC", VA = "0xCD8CEC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xCD8D78", Offset = "0xCD8D78", VA = "0xCD8D78")]
		public GetXYZ()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB3B8", Offset = "0x6DB3B8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB3B8", Offset = "0x6DB3B8")]
	public class Lerp : Action
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E87E0", Offset = "0x6E87E0")]
		public SharedVector3 fromVector3;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8818", Offset = "0x6E8818")]
		public SharedVector3 toVector3;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8850", Offset = "0x6E8850")]
		public SharedFloat lerpAmount;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8888", Offset = "0x6E8888")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xFC4D74", Offset = "0xFC4D74", VA = "0xFC4D74", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xFC4E94", Offset = "0xFC4E94", VA = "0xFC4E94", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xFC4F0C", Offset = "0xFC4F0C", VA = "0xFC4F0C")]
		public Lerp()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB418", Offset = "0x6DB418")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB418", Offset = "0x6DB418")]
	public class MoveTowards : Action
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E88D4", Offset = "0x6E88D4")]
		public SharedVector3 currentPosition;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E890C", Offset = "0x6E890C")]
		public SharedVector3 targetPosition;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8944", Offset = "0x6E8944")]
		public SharedFloat speed;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E897C", Offset = "0x6E897C")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xFC8B08", Offset = "0xFC8B08", VA = "0xFC8B08", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xFC8C30", Offset = "0xFC8C30", VA = "0xFC8C30", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xFC8CC4", Offset = "0xFC8CC4", VA = "0xFC8CC4")]
		public MoveTowards()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB478", Offset = "0x6DB478")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB478", Offset = "0x6DB478")]
	public class Multiply : Action
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E89C8", Offset = "0x6E89C8")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8A00", Offset = "0x6E8A00")]
		public SharedFloat multiplyBy;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8A38", Offset = "0x6E8A38")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xFCA55C", Offset = "0xFCA55C", VA = "0xFCA55C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xFCA630", Offset = "0xFCA630", VA = "0xFCA630", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xFCA6A4", Offset = "0xFCA6A4", VA = "0xFCA6A4")]
		public Multiply()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB4D8", Offset = "0x6DB4D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB4D8", Offset = "0x6DB4D8")]
	public class Normalize : Action
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8A84", Offset = "0x6E8A84")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8ABC", Offset = "0x6E8ABC")]
		[RequiredField]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xFCB144", Offset = "0xFCB144", VA = "0xFCB144", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xFCB1D0", Offset = "0xFCB1D0", VA = "0xFCB1D0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xFCB228", Offset = "0xFCB228", VA = "0xFCB228")]
		public Normalize()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB538", Offset = "0x6DB538")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB538", Offset = "0x6DB538")]
	public class Operator : Action
	{
		[Token(Token = "0x2000100")]
		public enum Operation
		{
			[Token(Token = "0x40002D0")]
			Add,
			[Token(Token = "0x40002D1")]
			Subtract,
			[Token(Token = "0x40002D2")]
			Scale
		}

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8B08", Offset = "0x6E8B08")]
		public Operation operation;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8B40", Offset = "0x6E8B40")]
		public SharedVector3 firstVector3;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8B78", Offset = "0x6E8B78")]
		public SharedVector3 secondVector3;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8BB0", Offset = "0x6E8BB0")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xFCB418", Offset = "0xFCB418", VA = "0xFCB418", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xFCB59C", Offset = "0xFCB59C", VA = "0xFCB59C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xFCB618", Offset = "0xFCB618", VA = "0xFCB618")]
		public Operator()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB598", Offset = "0x6DB598")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB598", Offset = "0x6DB598")]
	public class RotateTowards : Action
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8BE8", Offset = "0x6E8BE8")]
		public SharedVector3 currentRotation;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8C20", Offset = "0x6E8C20")]
		public SharedVector3 targetRotation;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8C58", Offset = "0x6E8C58")]
		public SharedFloat maxDegreesDelta;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8C90", Offset = "0x6E8C90")]
		public SharedFloat maxMagnitudeDelta;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8CC8", Offset = "0x6E8CC8")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xFD2CB4", Offset = "0xFD2CB4", VA = "0xFD2CB4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xFD2E00", Offset = "0xFD2E00", VA = "0xFD2E00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xFD2EB0", Offset = "0xFD2EB0", VA = "0xFD2EB0")]
		public RotateTowards()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB5F8", Offset = "0x6DB5F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB5F8", Offset = "0x6DB5F8")]
	public class SetValue : Action
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8D14", Offset = "0x6E8D14")]
		public SharedVector3 vector3Value;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8D4C", Offset = "0x6E8D4C")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xC98BC4", Offset = "0xC98BC4", VA = "0xC98BC4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xC98C48", Offset = "0xC98C48", VA = "0xC98C48", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xC98C98", Offset = "0xC98C98", VA = "0xC98C98")]
		public SetValue()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB658", Offset = "0x6DB658")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB658", Offset = "0x6DB658")]
	public class SetXYZ : Action
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8D84", Offset = "0x6E8D84")]
		public SharedVector3 vector3Variable;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8DBC", Offset = "0x6E8DBC")]
		public SharedFloat xValue;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8DF4", Offset = "0x6E8DF4")]
		public SharedFloat yValue;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8E2C", Offset = "0x6E8E2C")]
		public SharedFloat zValue;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xC99990", Offset = "0xC99990", VA = "0xC99990", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xC99AD4", Offset = "0xC99AD4", VA = "0xC99AD4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xC99B44", Offset = "0xC99B44", VA = "0xC99B44")]
		public SetXYZ()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB6B8", Offset = "0x6DB6B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB6B8", Offset = "0x6DB6B8")]
	public class ClampMagnitude : Action
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8E64", Offset = "0x6E8E64")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8E9C", Offset = "0x6E8E9C")]
		public SharedFloat maxLength;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8ED4", Offset = "0x6E8ED4")]
		public SharedVector2 storeResult;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x11281CC", Offset = "0x11281CC", VA = "0x11281CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1128298", Offset = "0x1128298", VA = "0x1128298", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x112830C", Offset = "0x112830C", VA = "0x112830C")]
		public ClampMagnitude()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB718", Offset = "0x6DB718")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB718", Offset = "0x6DB718")]
	public class Distance : Action
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8F20", Offset = "0x6E8F20")]
		public SharedVector2 firstVector2;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8F58", Offset = "0x6E8F58")]
		public SharedVector2 secondVector2;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8F90", Offset = "0x6E8F90")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x112BF78", Offset = "0x112BF78", VA = "0x112BF78", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x112C03C", Offset = "0x112C03C", VA = "0x112C03C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x112C0B0", Offset = "0x112C0B0", VA = "0x112C0B0")]
		public Distance()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB778", Offset = "0x6DB778")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB778", Offset = "0x6DB778")]
	public class Dot : Action
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E8FDC", Offset = "0x6E8FDC")]
		public SharedVector2 leftHandSide;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9014", Offset = "0x6E9014")]
		public SharedVector2 rightHandSide;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E904C", Offset = "0x6E904C")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x112C360", Offset = "0x112C360", VA = "0x112C360", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x112C418", Offset = "0x112C418", VA = "0x112C418", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x112C48C", Offset = "0x112C48C", VA = "0x112C48C")]
		public Dot()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB7D8", Offset = "0x6DB7D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB7D8", Offset = "0x6DB7D8")]
	public class GetMagnitude : Action
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9098", Offset = "0x6E9098")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E90D0", Offset = "0x6E90D0")]
		public SharedFloat storeResult;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xCD0B4C", Offset = "0xCD0B4C", VA = "0xCD0B4C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xCD0BEC", Offset = "0xCD0BEC", VA = "0xCD0BEC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xCD0C40", Offset = "0xCD0C40", VA = "0xCD0C40")]
		public GetMagnitude()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB838", Offset = "0x6DB838")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB838", Offset = "0x6DB838")]
	public class GetRightVector : Action
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E911C", Offset = "0x6E911C")]
		public SharedVector2 storeResult;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xCD4898", Offset = "0xCD4898", VA = "0xCD4898", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xCD4900", Offset = "0xCD4900", VA = "0xCD4900", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xCD4938", Offset = "0xCD4938", VA = "0xCD4938")]
		public GetRightVector()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB898", Offset = "0x6DB898")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB898", Offset = "0x6DB898")]
	public class GetSqrMagnitude : Action
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9168", Offset = "0x6E9168")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E91A0", Offset = "0x6E91A0")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xCD6678", Offset = "0xCD6678", VA = "0xCD6678", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xCD6718", Offset = "0xCD6718", VA = "0xCD6718", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xCD676C", Offset = "0xCD676C", VA = "0xCD676C")]
		public GetSqrMagnitude()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB8F8", Offset = "0x6DB8F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB8F8", Offset = "0x6DB8F8")]
	public class GetUpVector : Action
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E91EC", Offset = "0x6E91EC")]
		public SharedVector2 storeResult;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xCD7BCC", Offset = "0xCD7BCC", VA = "0xCD7BCC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xCD7C34", Offset = "0xCD7C34", VA = "0xCD7C34", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xCD7C6C", Offset = "0xCD7C6C", VA = "0xCD7C6C")]
		public GetUpVector()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB958", Offset = "0x6DB958")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB958", Offset = "0x6DB958")]
	public class GetVector3 : Action
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9238", Offset = "0x6E9238")]
		public SharedVector2 vector3Variable;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9270", Offset = "0x6E9270")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xCD8068", Offset = "0xCD8068", VA = "0xCD8068", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xCD80F0", Offset = "0xCD80F0", VA = "0xCD80F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xCD8148", Offset = "0xCD8148", VA = "0xCD8148")]
		public GetVector3()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DB9B8", Offset = "0x6DB9B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DB9B8", Offset = "0x6DB9B8")]
	public class GetXY : Action
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E92BC", Offset = "0x6E92BC")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E92F4", Offset = "0x6E92F4")]
		public SharedFloat storeX;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9340", Offset = "0x6E9340")]
		public SharedFloat storeY;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xCD8AEC", Offset = "0xCD8AEC", VA = "0xCD8AEC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xCD8BA0", Offset = "0xCD8BA0", VA = "0xCD8BA0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xCD8C08", Offset = "0xCD8C08", VA = "0xCD8C08")]
		public GetXY()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBA18", Offset = "0x6DBA18")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBA18", Offset = "0x6DBA18")]
	public class Lerp : Action
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E938C", Offset = "0x6E938C")]
		public SharedVector2 fromVector2;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E93C4", Offset = "0x6E93C4")]
		public SharedVector2 toVector2;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E93FC", Offset = "0x6E93FC")]
		public SharedFloat lerpAmount;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9434", Offset = "0x6E9434")]
		public SharedVector2 storeResult;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xFC4BD4", Offset = "0xFC4BD4", VA = "0xFC4BD4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xFC4CD8", Offset = "0xFC4CD8", VA = "0xFC4CD8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xFC4D6C", Offset = "0xFC4D6C", VA = "0xFC4D6C")]
		public Lerp()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBA78", Offset = "0x6DBA78")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBA78", Offset = "0x6DBA78")]
	public class MoveTowards : Action
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9480", Offset = "0x6E9480")]
		public SharedVector2 currentPosition;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E94B8", Offset = "0x6E94B8")]
		public SharedVector2 targetPosition;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E94F0", Offset = "0x6E94F0")]
		public SharedFloat speed;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9528", Offset = "0x6E9528")]
		public SharedVector2 storeResult;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xFC895C", Offset = "0xFC895C", VA = "0xFC895C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xFC8A6C", Offset = "0xFC8A6C", VA = "0xFC8A6C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xFC8B00", Offset = "0xFC8B00", VA = "0xFC8B00")]
		public MoveTowards()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBAD8", Offset = "0x6DBAD8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBAD8", Offset = "0x6DBAD8")]
	public class Multiply : Action
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9574", Offset = "0x6E9574")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E95AC", Offset = "0x6E95AC")]
		public SharedFloat multiplyBy;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E95E4", Offset = "0x6E95E4")]
		public SharedVector2 storeResult;

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xFCA428", Offset = "0xFCA428", VA = "0xFCA428", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xFCA4EC", Offset = "0xFCA4EC", VA = "0xFCA4EC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xFCA554", Offset = "0xFCA554", VA = "0xFCA554")]
		public Multiply()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBB38", Offset = "0x6DBB38")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBB38", Offset = "0x6DBB38")]
	public class Normalize : Action
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9630", Offset = "0x6E9630")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9668", Offset = "0x6E9668")]
		public SharedVector2 storeResult;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xFCB044", Offset = "0xFCB044", VA = "0xFCB044", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xFCB0E4", Offset = "0xFCB0E4", VA = "0xFCB0E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xFCB13C", Offset = "0xFCB13C", VA = "0xFCB13C")]
		public Normalize()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBB98", Offset = "0x6DBB98")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBB98", Offset = "0x6DBB98")]
	public class Operator : Action
	{
		[Token(Token = "0x2000112")]
		public enum Operation
		{
			[Token(Token = "0x4000304")]
			Add,
			[Token(Token = "0x4000305")]
			Subtract,
			[Token(Token = "0x4000306")]
			Scale
		}

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E96B4", Offset = "0x6E96B4")]
		public Operation operation;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E96EC", Offset = "0x6E96EC")]
		public SharedVector2 firstVector2;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9724", Offset = "0x6E9724")]
		public SharedVector2 secondVector2;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E975C", Offset = "0x6E975C")]
		public SharedVector2 storeResult;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xFCB230", Offset = "0xFCB230", VA = "0xFCB230", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xFCB394", Offset = "0xFCB394", VA = "0xFCB394", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xFCB410", Offset = "0xFCB410", VA = "0xFCB410")]
		public Operator()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBBF8", Offset = "0x6DBBF8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBBF8", Offset = "0x6DBBF8")]
	public class SetValue : Action
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9794", Offset = "0x6E9794")]
		public SharedVector2 vector2Value;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E97CC", Offset = "0x6E97CC")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xC98AE8", Offset = "0xC98AE8", VA = "0xC98AE8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xC98B6C", Offset = "0xC98B6C", VA = "0xC98B6C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xC98BBC", Offset = "0xC98BBC", VA = "0xC98BBC")]
		public SetValue()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBC58", Offset = "0x6DBC58")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBC58", Offset = "0x6DBC58")]
	public class SetXY : Action
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9804", Offset = "0x6E9804")]
		public SharedVector2 vector2Variable;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E983C", Offset = "0x6E983C")]
		public SharedFloat xValue;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9874", Offset = "0x6E9874")]
		public SharedFloat yValue;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xC99820", Offset = "0xC99820", VA = "0xC99820", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xC99924", Offset = "0xC99924", VA = "0xC99924", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xC99988", Offset = "0xC99988", VA = "0xC99988")]
		public SetXY()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBCB8", Offset = "0x6DBCB8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBCB8", Offset = "0x6DBCB8")]
	public class Find : Action
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E98AC", Offset = "0x6E98AC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E98E4", Offset = "0x6E98E4")]
		public SharedString transformName;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E991C", Offset = "0x6E991C")]
		public SharedTransform storeValue;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xCC2550", Offset = "0xCC2550", VA = "0xCC2550", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xCC2660", Offset = "0xCC2660", VA = "0xCC2660", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xCC27F8", Offset = "0xCC27F8", VA = "0xCC27F8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xCC283C", Offset = "0xCC283C", VA = "0xCC283C")]
		public Find()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBD18", Offset = "0x6DBD18")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBD18", Offset = "0x6DBD18")]
	public class GetAngleToTarget : Action
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9968", Offset = "0x6E9968")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E99A0", Offset = "0x6E99A0")]
		public SharedGameObject targetObject;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E99D8", Offset = "0x6E99D8")]
		public SharedVector3 targetPosition;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9A10", Offset = "0x6E9A10")]
		public SharedBool ignoreHeight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9A48", Offset = "0x6E9A48")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform targetTransform;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xCC7F60", Offset = "0xCC7F60", VA = "0xCC7F60", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xCC8070", Offset = "0xCC8070", VA = "0xCC8070", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xCC82E0", Offset = "0xCC82E0", VA = "0xCC82E0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xCC836C", Offset = "0xCC836C", VA = "0xCC836C")]
		public GetAngleToTarget()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBD78", Offset = "0x6DBD78")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBD78", Offset = "0x6DBD78")]
	public class GetChild : Action
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9A94", Offset = "0x6E9A94")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9ACC", Offset = "0x6E9ACC")]
		public SharedInt index;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9B04", Offset = "0x6E9B04")]
		public SharedTransform storeValue;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xCCA754", Offset = "0xCCA754", VA = "0xCCA754", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xCCA864", Offset = "0xCCA864", VA = "0xCCA864", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xCCA998", Offset = "0xCCA998", VA = "0xCCA998", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xCCA9E8", Offset = "0xCCA9E8", VA = "0xCCA9E8")]
		public GetChild()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBDD8", Offset = "0x6DBDD8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBDD8", Offset = "0x6DBDD8")]
	public class GetChildCount : Action
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9B50", Offset = "0x6E9B50")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9B88", Offset = "0x6E9B88")]
		[RequiredField]
		public SharedInt storeValue;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xCCA9F0", Offset = "0xCCA9F0", VA = "0xCCA9F0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xCCAB00", Offset = "0xCCAB00", VA = "0xCCAB00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xCCAC0C", Offset = "0xCCAC0C", VA = "0xCCAC0C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xCCAC50", Offset = "0xCCAC50", VA = "0xCCAC50")]
		public GetChildCount()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBE38", Offset = "0x6DBE38")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBE38", Offset = "0x6DBE38")]
	public class GetEulerAngles : Action
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9BD4", Offset = "0x6E9BD4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9C0C", Offset = "0x6E9C0C")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xCCCBE4", Offset = "0xCCCBE4", VA = "0xCCCBE4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xCCCCF4", Offset = "0xCCCCF4", VA = "0xCCCCF4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xCCCDFC", Offset = "0xCCCDFC", VA = "0xCCCDFC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xCCCE44", Offset = "0xCCCE44", VA = "0xCCCE44")]
		public GetEulerAngles()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBE98", Offset = "0x6DBE98")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBE98", Offset = "0x6DBE98")]
	public class GetForwardVector : Action
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9C58", Offset = "0x6E9C58")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9C90", Offset = "0x6E9C90")]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xCCD5B4", Offset = "0xCCD5B4", VA = "0xCCD5B4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xCCD6C4", Offset = "0xCCD6C4", VA = "0xCCD6C4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xCCD7CC", Offset = "0xCCD7CC", VA = "0xCCD7CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xCCD814", Offset = "0xCCD814", VA = "0xCCD814")]
		public GetForwardVector()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBEF8", Offset = "0x6DBEF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBEF8", Offset = "0x6DBEF8")]
	public class GetLocalEulerAngles : Action
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9CDC", Offset = "0x6E9CDC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9D14", Offset = "0x6E9D14")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xCCFCC0", Offset = "0xCCFCC0", VA = "0xCCFCC0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xCCFDD0", Offset = "0xCCFDD0", VA = "0xCCFDD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xCCFED8", Offset = "0xCCFED8", VA = "0xCCFED8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xCCFF20", Offset = "0xCCFF20", VA = "0xCCFF20")]
		public GetLocalEulerAngles()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBF58", Offset = "0x6DBF58")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBF58", Offset = "0x6DBF58")]
	public class GetLocalPosition : Action
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9D60", Offset = "0x6E9D60")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9D98", Offset = "0x6E9D98")]
		public SharedVector3 storeValue;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xCCFF28", Offset = "0xCCFF28", VA = "0xCCFF28", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xCD0038", Offset = "0xCD0038", VA = "0xCD0038", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xCD0140", Offset = "0xCD0140", VA = "0xCD0140", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xCD0188", Offset = "0xCD0188", VA = "0xCD0188")]
		public GetLocalPosition()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DBFB8", Offset = "0x6DBFB8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DBFB8", Offset = "0x6DBFB8")]
	public class GetLocalRotation : Action
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9DE4", Offset = "0x6E9DE4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9E1C", Offset = "0x6E9E1C")]
		[RequiredField]
		public SharedQuaternion storeValue;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xCD0190", Offset = "0xCD0190", VA = "0xCD0190", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xCD02A0", Offset = "0xCD02A0", VA = "0xCD02A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xCD03A8", Offset = "0xCD03A8", VA = "0xCD03A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xCD03F0", Offset = "0xCD03F0", VA = "0xCD03F0")]
		public GetLocalRotation()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC018", Offset = "0x6DC018")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC018", Offset = "0x6DC018")]
	public class GetLocalScale : Action
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9E68", Offset = "0x6E9E68")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9EA0", Offset = "0x6E9EA0")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xCD03F8", Offset = "0xCD03F8", VA = "0xCD03F8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xCD0508", Offset = "0xCD0508", VA = "0xCD0508", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xCD0610", Offset = "0xCD0610", VA = "0xCD0610", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xCD0658", Offset = "0xCD0658", VA = "0xCD0658")]
		public GetLocalScale()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC078", Offset = "0x6DC078")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC078", Offset = "0x6DC078")]
	public class GetParent : Action
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9EEC", Offset = "0x6E9EEC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9F24", Offset = "0x6E9F24")]
		public SharedTransform storeValue;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xCD1FC4", Offset = "0xCD1FC4", VA = "0xCD1FC4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xCD20D4", Offset = "0xCD20D4", VA = "0xCD20D4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xCD21E0", Offset = "0xCD21E0", VA = "0xCD21E0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xCD2214", Offset = "0xCD2214", VA = "0xCD2214")]
		public GetParent()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC0D8", Offset = "0x6DC0D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC0D8", Offset = "0x6DC0D8")]
	public class GetPosition : Action
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9F70", Offset = "0x6E9F70")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9FA8", Offset = "0x6E9FA8")]
		public SharedVector3 storeValue;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xCD2E38", Offset = "0xCD2E38", VA = "0xCD2E38", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xCD2F48", Offset = "0xCD2F48", VA = "0xCD2F48", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xCD3050", Offset = "0xCD3050", VA = "0xCD3050", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xCD3098", Offset = "0xCD3098", VA = "0xCD3098")]
		public GetPosition()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC138", Offset = "0x6DC138")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC138", Offset = "0x6DC138")]
	public class GetRightVector : Action
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E9FF4", Offset = "0x6E9FF4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA02C", Offset = "0x6EA02C")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xCD4630", Offset = "0xCD4630", VA = "0xCD4630", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xCD4740", Offset = "0xCD4740", VA = "0xCD4740", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xCD4848", Offset = "0xCD4848", VA = "0xCD4848", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xCD4890", Offset = "0xCD4890", VA = "0xCD4890")]
		public GetRightVector()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC198", Offset = "0x6DC198")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC198", Offset = "0x6DC198")]
	public class GetRotation : Action
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA078", Offset = "0x6EA078")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA0B0", Offset = "0x6EA0B0")]
		public SharedQuaternion storeValue;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xCD4EB4", Offset = "0xCD4EB4", VA = "0xCD4EB4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xCD4FC4", Offset = "0xCD4FC4", VA = "0xCD4FC4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xCD50CC", Offset = "0xCD50CC", VA = "0xCD50CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xCD5114", Offset = "0xCD5114", VA = "0xCD5114")]
		public GetRotation()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC1F8", Offset = "0x6DC1F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC1F8", Offset = "0x6DC1F8")]
	public class GetUpVector : Action
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA0FC", Offset = "0x6EA0FC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA134", Offset = "0x6EA134")]
		public SharedVector3 storeValue;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xCD7964", Offset = "0xCD7964", VA = "0xCD7964", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xCD7A74", Offset = "0xCD7A74", VA = "0xCD7A74", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xCD7B7C", Offset = "0xCD7B7C", VA = "0xCD7B7C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xCD7BC4", Offset = "0xCD7BC4", VA = "0xCD7BC4")]
		public GetUpVector()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC258", Offset = "0x6DC258")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC258", Offset = "0x6DC258")]
	public class IsChildOf : Conditional
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA180", Offset = "0x6EA180")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA1B8", Offset = "0x6EA1B8")]
		public SharedTransform transformName;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xFC0900", Offset = "0xFC0900", VA = "0xFC0900", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xFC0A10", Offset = "0xFC0A10", VA = "0xFC0A10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xFC0B24", Offset = "0xFC0B24", VA = "0xFC0B24", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xFC0B58", Offset = "0xFC0B58", VA = "0xFC0B58")]
		public IsChildOf()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC2B8", Offset = "0x6DC2B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC2B8", Offset = "0x6DC2B8")]
	public class LookAt : Action
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA1F0", Offset = "0x6EA1F0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA228", Offset = "0x6EA228")]
		public SharedGameObject targetLookAt;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA260", Offset = "0x6EA260")]
		public SharedVector3 worldPosition;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA298", Offset = "0x6EA298")]
		public Vector3 worldUp;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform targetTransform;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xFC6E6C", Offset = "0xFC6E6C", VA = "0xFC6E6C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xFC6F7C", Offset = "0xFC6F7C", VA = "0xFC6F7C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xFC7120", Offset = "0xFC7120", VA = "0xFC7120", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xFC7188", Offset = "0xFC7188", VA = "0xFC7188")]
		public LookAt()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC318", Offset = "0x6DC318")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC318", Offset = "0x6DC318")]
	public class Rotate : Action
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA2D0", Offset = "0x6EA2D0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA308", Offset = "0x6EA308")]
		public SharedVector3 eulerAngles;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA340", Offset = "0x6EA340")]
		public Space relativeTo;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xFD20F4", Offset = "0xFD20F4", VA = "0xFD20F4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xFD2204", Offset = "0xFD2204", VA = "0xFD2204", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xFD2310", Offset = "0xFD2310", VA = "0xFD2310", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xFD2364", Offset = "0xFD2364", VA = "0xFD2364")]
		public Rotate()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC378", Offset = "0x6DC378")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC378", Offset = "0x6DC378")]
	public class RotateAround : Action
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA378", Offset = "0x6EA378")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA3B0", Offset = "0x6EA3B0")]
		public SharedVector3 point;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA3E8", Offset = "0x6EA3E8")]
		public SharedVector3 axis;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA420", Offset = "0x6EA420")]
		public SharedFloat angle;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform targetTransform;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xFD2374", Offset = "0xFD2374", VA = "0xFD2374", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xFD2484", Offset = "0xFD2484", VA = "0xFD2484", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xFD2614", Offset = "0xFD2614", VA = "0xFD2614", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xFD2698", Offset = "0xFD2698", VA = "0xFD2698")]
		public RotateAround()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC3D8", Offset = "0x6DC3D8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC3D8", Offset = "0x6DC3D8")]
	public class SetEulerAngles : Action
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA458", Offset = "0x6EA458")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA490", Offset = "0x6EA490")]
		public SharedVector3 eulerAngles;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xC8BDE0", Offset = "0xC8BDE0", VA = "0xC8BDE0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xC8BEF0", Offset = "0xC8BEF0", VA = "0xC8BEF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xC8BFF8", Offset = "0xC8BFF8", VA = "0xC8BFF8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xC8C03C", Offset = "0xC8C03C", VA = "0xC8C03C")]
		public SetEulerAngles()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC438", Offset = "0x6DC438")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC438", Offset = "0x6DC438")]
	public class SetForwardVector : Action
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA4C8", Offset = "0x6EA4C8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA500", Offset = "0x6EA500")]
		public SharedVector3 position;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xC8C914", Offset = "0xC8C914", VA = "0xC8C914", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xC8CA24", Offset = "0xC8CA24", VA = "0xC8CA24", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xC8CB2C", Offset = "0xC8CB2C", VA = "0xC8CB2C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xC8CB70", Offset = "0xC8CB70", VA = "0xC8CB70")]
		public SetForwardVector()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC498", Offset = "0x6DC498")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC498", Offset = "0x6DC498")]
	public class SetLocalEulerAngles : Action
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA538", Offset = "0x6EA538")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA570", Offset = "0x6EA570")]
		public SharedVector3 localEulerAngles;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xC8ECDC", Offset = "0xC8ECDC", VA = "0xC8ECDC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xC8EDEC", Offset = "0xC8EDEC", VA = "0xC8EDEC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xC8EEF4", Offset = "0xC8EEF4", VA = "0xC8EEF4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xC8EF38", Offset = "0xC8EF38", VA = "0xC8EF38")]
		public SetLocalEulerAngles()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC4F8", Offset = "0x6DC4F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC4F8", Offset = "0x6DC4F8")]
	public class SetLocalPosition : Action
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA5A8", Offset = "0x6EA5A8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA5E0", Offset = "0x6EA5E0")]
		public SharedVector3 localPosition;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xC8EF40", Offset = "0xC8EF40", VA = "0xC8EF40", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xC8F050", Offset = "0xC8F050", VA = "0xC8F050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xC8F158", Offset = "0xC8F158", VA = "0xC8F158", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xC8F19C", Offset = "0xC8F19C", VA = "0xC8F19C")]
		public SetLocalPosition()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC558", Offset = "0x6DC558")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC558", Offset = "0x6DC558")]
	public class SetLocalRotation : Action
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA618", Offset = "0x6EA618")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA650", Offset = "0x6EA650")]
		public SharedQuaternion localRotation;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xC8F1A4", Offset = "0xC8F1A4", VA = "0xC8F1A4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xC8F2B4", Offset = "0xC8F2B4", VA = "0xC8F2B4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xC8F3BC", Offset = "0xC8F3BC", VA = "0xC8F3BC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xC8F484", Offset = "0xC8F484", VA = "0xC8F484")]
		public SetLocalRotation()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC5B8", Offset = "0x6DC5B8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC5B8", Offset = "0x6DC5B8")]
	public class SetLocalScale : Action
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA688", Offset = "0x6EA688")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA6C0", Offset = "0x6EA6C0")]
		public SharedVector3 localScale;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xC8F48C", Offset = "0xC8F48C", VA = "0xC8F48C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xC8F59C", Offset = "0xC8F59C", VA = "0xC8F59C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xC8F6A4", Offset = "0xC8F6A4", VA = "0xC8F6A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xC8F6E8", Offset = "0xC8F6E8", VA = "0xC8F6E8")]
		public SetLocalScale()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC618", Offset = "0x6DC618")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC618", Offset = "0x6DC618")]
	public class SetParent : Action
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA6F8", Offset = "0x6EA6F8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA730", Offset = "0x6EA730")]
		public SharedTransform parent;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xC91370", Offset = "0xC91370", VA = "0xC91370", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xC91480", Offset = "0xC91480", VA = "0xC91480", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xC9158C", Offset = "0xC9158C", VA = "0xC9158C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xC915C0", Offset = "0xC915C0", VA = "0xC915C0")]
		public SetParent()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC678", Offset = "0x6DC678")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC678", Offset = "0x6DC678")]
	public class SetPosition : Action
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA768", Offset = "0x6EA768")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA7A0", Offset = "0x6EA7A0")]
		public SharedVector3 position;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xC91D38", Offset = "0xC91D38", VA = "0xC91D38", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xC91E48", Offset = "0xC91E48", VA = "0xC91E48", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xC91F50", Offset = "0xC91F50", VA = "0xC91F50", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xC91F94", Offset = "0xC91F94", VA = "0xC91F94")]
		public SetPosition()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC6D8", Offset = "0x6DC6D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC6D8", Offset = "0x6DC6D8")]
	public class SetRightVector : Action
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA7D8", Offset = "0x6EA7D8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA810", Offset = "0x6EA810")]
		public SharedVector3 position;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xC9312C", Offset = "0xC9312C", VA = "0xC9312C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xC9323C", Offset = "0xC9323C", VA = "0xC9323C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xC93344", Offset = "0xC93344", VA = "0xC93344", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xC93388", Offset = "0xC93388", VA = "0xC93388")]
		public SetRightVector()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC738", Offset = "0x6DC738")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC738", Offset = "0x6DC738")]
	public class SetRotation : Action
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA848", Offset = "0x6EA848")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA880", Offset = "0x6EA880")]
		public SharedQuaternion rotation;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xC93820", Offset = "0xC93820", VA = "0xC93820", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xC93930", Offset = "0xC93930", VA = "0xC93930", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xC93A38", Offset = "0xC93A38", VA = "0xC93A38", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xC93A7C", Offset = "0xC93A7C", VA = "0xC93A7C")]
		public SetRotation()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC798", Offset = "0x6DC798")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC798", Offset = "0x6DC798")]
	public class SetUpVector : Action
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA8B8", Offset = "0x6EA8B8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA8F0", Offset = "0x6EA8F0")]
		public SharedVector3 position;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xC98620", Offset = "0xC98620", VA = "0xC98620", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xC98730", Offset = "0xC98730", VA = "0xC98730", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xC98838", Offset = "0xC98838", VA = "0xC98838", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xC9887C", Offset = "0xC9887C", VA = "0xC9887C")]
		public SetUpVector()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC7F8", Offset = "0x6DC7F8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC7F8", Offset = "0x6DC7F8")]
	public class Translate : Action
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA928", Offset = "0x6EA928")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA960", Offset = "0x6EA960")]
		public SharedVector3 translation;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA998", Offset = "0x6EA998")]
		public Space relativeTo;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xCA45C8", Offset = "0xCA45C8", VA = "0xCA45C8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xCA46D8", Offset = "0xCA46D8", VA = "0xCA46D8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xCA47E4", Offset = "0xCA47E4", VA = "0xCA47E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xCA4834", Offset = "0xCA4834", VA = "0xCA4834")]
		public Translate()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC858", Offset = "0x6DC858")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC858", Offset = "0x6DC858")]
	public class IsPaused : Conditional
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EA9D0", Offset = "0x6EA9D0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xFC1EA0", Offset = "0xFC1EA0", VA = "0xFC1EA0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xFC1FB0", Offset = "0xFC1FB0", VA = "0xFC1FB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xFC2098", Offset = "0xFC2098", VA = "0xFC2098", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xFC20A4", Offset = "0xFC20A4", VA = "0xFC20A4")]
		public IsPaused()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC8B8", Offset = "0x6DC8B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC8B8", Offset = "0x6DC8B8")]
	public class IsPlaying : Conditional
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAA08", Offset = "0x6EAA08")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xFC22B8", Offset = "0xFC22B8", VA = "0xFC22B8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xFC23C8", Offset = "0xFC23C8", VA = "0xFC23C8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xFC24B0", Offset = "0xFC24B0", VA = "0xFC24B0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xFC24BC", Offset = "0xFC24BC", VA = "0xFC24BC")]
		public IsPlaying()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC918", Offset = "0x6DC918")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC918", Offset = "0x6DC918")]
	public class Pause : Action
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAA40", Offset = "0x6EAA40")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xFCCD34", Offset = "0xFCCD34", VA = "0xFCCD34", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xFCCE44", Offset = "0xFCCE44", VA = "0xFCCE44", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xFCCF24", Offset = "0xFCCF24", VA = "0xFCCF24", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xFCCF30", Offset = "0xFCCF30", VA = "0xFCCF30")]
		public Pause()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC978", Offset = "0x6DC978")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC978", Offset = "0x6DC978")]
	public class Play : Action
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAA78", Offset = "0x6EAA78")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAAB0", Offset = "0x6EAAB0")]
		public PlayableAsset playableAsset;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAAE8", Offset = "0x6EAAE8")]
		public SharedBool stopWhenComplete;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PlayableDirector playableDirector;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool playbackStarted;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xFCD450", Offset = "0xFCD450", VA = "0xFCD450", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xFCD55C", Offset = "0xFCD55C", VA = "0xFCD55C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xFCD710", Offset = "0xFCD710", VA = "0xFCD710", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xFCD760", Offset = "0xFCD760", VA = "0xFCD760")]
		public Play()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DC9D8", Offset = "0x6DC9D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DC9D8", Offset = "0x6DC9D8")]
	public class Resume : Action
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAB20", Offset = "0x6EAB20")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAB58", Offset = "0x6EAB58")]
		public SharedBool stopWhenComplete;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PlayableDirector playableDirector;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool playbackStarted;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xFD1864", Offset = "0xFD1864", VA = "0xFD1864", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xFD1970", Offset = "0xFD1970", VA = "0xFD1970", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xFD1AD0", Offset = "0xFD1AD0", VA = "0xFD1AD0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xFD1B14", Offset = "0xFD1B14", VA = "0xFD1B14")]
		public Resume()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCA38", Offset = "0x6DCA38")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCA38", Offset = "0x6DCA38")]
	public class Stop : Action
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAB90", Offset = "0x6EAB90")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xCA1264", Offset = "0xCA1264", VA = "0xCA1264", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xCA1374", Offset = "0xCA1374", VA = "0xCA1374", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xCA1454", Offset = "0xCA1454", VA = "0xCA1454", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xCA1460", Offset = "0xCA1460", VA = "0xCA1460")]
		public Stop()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTime
{
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCA98", Offset = "0x6DCA98")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCA98", Offset = "0x6DCA98")]
	public class GetDeltaTime : Action
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EABC8", Offset = "0x6EABC8")]
		public SharedFloat storeResult;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xCCB77C", Offset = "0xCCB77C", VA = "0xCCB77C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xCCB7E4", Offset = "0xCCB7E4", VA = "0xCCB7E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xCCB818", Offset = "0xCCB818", VA = "0xCCB818")]
		public GetDeltaTime()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCAF8", Offset = "0x6DCAF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCAF8", Offset = "0x6DCAF8")]
	public class GetRealtimeSinceStartup : Action
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAC00", Offset = "0x6EAC00")]
		public SharedFloat storeResult;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xCD4328", Offset = "0xCD4328", VA = "0xCD4328", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xCD4390", Offset = "0xCD4390", VA = "0xCD4390", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xCD43C4", Offset = "0xCD43C4", VA = "0xCD43C4")]
		public GetRealtimeSinceStartup()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCB58", Offset = "0x6DCB58")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCB58", Offset = "0x6DCB58")]
	public class GetTime : Action
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAC38", Offset = "0x6EAC38")]
		public SharedFloat storeResult;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xCD7558", Offset = "0xCD7558", VA = "0xCD7558", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xCD75C0", Offset = "0xCD75C0", VA = "0xCD75C0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xCD75F4", Offset = "0xCD75F4", VA = "0xCD75F4")]
		public GetTime()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCBB8", Offset = "0x6DCBB8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCBB8", Offset = "0x6DCBB8")]
	public class GetTimeScale : Action
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAC70", Offset = "0x6EAC70")]
		public SharedFloat storeResult;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xCD7864", Offset = "0xCD7864", VA = "0xCD7864", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xCD78CC", Offset = "0xCD78CC", VA = "0xCD78CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xCD7900", Offset = "0xCD7900", VA = "0xCD7900")]
		public GetTimeScale()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCC18", Offset = "0x6DCC18")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCC18", Offset = "0x6DCC18")]
	public class SetTimeScale : Action
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EACA8", Offset = "0x6EACA8")]
		public SharedFloat timeScale;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC980C8", Offset = "0xC980C8", VA = "0xC980C8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xC9812C", Offset = "0xC9812C", VA = "0xC9812C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xC98184", Offset = "0xC98184", VA = "0xC98184")]
		public SetTimeScale()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCC78", Offset = "0x6DCC78")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCC78", Offset = "0x6DCC78")]
	public class BuildString : Action
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EACE0", Offset = "0x6EACE0")]
		public SharedString[] source;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAD18", Offset = "0x6EAD18")]
		[RequiredField]
		public SharedString storeResult;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x111E300", Offset = "0x111E300", VA = "0x111E300", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x111E428", Offset = "0x111E428", VA = "0x111E428", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x111E45C", Offset = "0x111E45C", VA = "0x111E45C")]
		public BuildString()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCCD8", Offset = "0x6DCCD8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCCD8", Offset = "0x6DCCD8")]
	public class CompareTo : Action
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAD64", Offset = "0x6EAD64")]
		public SharedString firstString;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAD9C", Offset = "0x6EAD9C")]
		public SharedString secondString;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EADD4", Offset = "0x6EADD4")]
		public SharedInt storeResult;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x112A58C", Offset = "0x112A58C", VA = "0x112A58C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x112A648", Offset = "0x112A648", VA = "0x112A648", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x112A6DC", Offset = "0x112A6DC", VA = "0x112A6DC")]
		public CompareTo()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCD38", Offset = "0x6DCD38")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCD38", Offset = "0x6DCD38")]
	public class Format : Action
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAE20", Offset = "0x6EAE20")]
		public SharedString format;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAE58", Offset = "0x6EAE58")]
		public SharedGenericVariable[] variables;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAE90", Offset = "0x6EAE90")]
		[RequiredField]
		public SharedString storeResult;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object[] variableValues;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xCC5D80", Offset = "0xCC5D80", VA = "0xCC5D80", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xCC5DE8", Offset = "0xCC5DE8", VA = "0xCC5DE8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xCC603C", Offset = "0xCC603C", VA = "0xCC603C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xCC60B8", Offset = "0xCC60B8", VA = "0xCC60B8")]
		public Format()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCD98", Offset = "0x6DCD98")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCD98", Offset = "0x6DCD98")]
	public class GetLength : Action
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAEDC", Offset = "0x6EAEDC")]
		public SharedString targetString;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAF14", Offset = "0x6EAF14")]
		public SharedInt storeResult;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xCCFBB4", Offset = "0xCCFBB4", VA = "0xCCFBB4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xCCFC40", Offset = "0xCCFC40", VA = "0xCCFC40", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xCCFCB8", Offset = "0xCCFCB8", VA = "0xCCFCB8")]
		public GetLength()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCDF8", Offset = "0x6DCDF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCDF8", Offset = "0x6DCDF8")]
	public class GetRandomString : Action
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAF60", Offset = "0x6EAF60")]
		public SharedString[] source;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAF98", Offset = "0x6EAF98")]
		public SharedString storeResult;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xCD3FDC", Offset = "0xCD3FDC", VA = "0xCD3FDC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xCD4098", Offset = "0xCD4098", VA = "0xCD4098", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xCD40CC", Offset = "0xCD40CC", VA = "0xCD40CC")]
		public GetRandomString()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCE58", Offset = "0x6DCE58")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCE58", Offset = "0x6DCE58")]
	public class GetSubstring : Action
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EAFE4", Offset = "0x6EAFE4")]
		public SharedString targetString;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB01C", Offset = "0x6EB01C")]
		public SharedInt startIndex;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB054", Offset = "0x6EB054")]
		public SharedInt length;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB08C", Offset = "0x6EB08C")]
		[RequiredField]
		public SharedString storeResult;

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xCD6D40", Offset = "0xCD6D40", VA = "0xCD6D40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xCD6E6C", Offset = "0xCD6E6C", VA = "0xCD6E6C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xCD6F1C", Offset = "0xCD6F1C", VA = "0xCD6F1C")]
		public GetSubstring()
		{
		}
	}
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCEB8", Offset = "0x6DCEB8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCEB8", Offset = "0x6DCEB8")]
	public class IsNullOrEmpty : Conditional
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB0D8", Offset = "0x6EB0D8")]
		public SharedString targetString;

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xFC1B38", Offset = "0xFC1B38", VA = "0xFC1B38", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xFC1BA4", Offset = "0xFC1BA4", VA = "0xFC1BA4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xFC1C00", Offset = "0xFC1C00", VA = "0xFC1C00")]
		public IsNullOrEmpty()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCF18", Offset = "0x6DCF18")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCF18", Offset = "0x6DCF18")]
	public class Replace : Action
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB110", Offset = "0x6EB110")]
		public SharedString targetString;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB148", Offset = "0x6EB148")]
		public SharedString oldString;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB180", Offset = "0x6EB180")]
		public SharedString newString;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB1B8", Offset = "0x6EB1B8")]
		[RequiredField]
		public SharedString storeResult;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFD1264", Offset = "0xFD1264", VA = "0xFD1264", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFD133C", Offset = "0xFD133C", VA = "0xFD133C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFD13EC", Offset = "0xFD13EC", VA = "0xFD13EC")]
		public Replace()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCF78", Offset = "0x6DCF78")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCF78", Offset = "0x6DCF78")]
	public class SetString : Action
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB204", Offset = "0x6EB204")]
		[RequiredField]
		public SharedString variable;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB250", Offset = "0x6EB250")]
		public SharedString value;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xC979EC", Offset = "0xC979EC", VA = "0xC979EC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xC97A74", Offset = "0xC97A74", VA = "0xC97A74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC97AE4", Offset = "0xC97AE4", VA = "0xC97AE4")]
		public SetString()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnitySphereCollider
{
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DCFD8", Offset = "0x6DCFD8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DCFD8", Offset = "0x6DCFD8")]
	public class GetCenter : Action
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB288", Offset = "0x6EB288")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB2C0", Offset = "0x6EB2C0")]
		public SharedVector3 storeValue;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xCCA294", Offset = "0xCCA294", VA = "0xCCA294", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xCCA3A4", Offset = "0xCCA3A4", VA = "0xCCA3A4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xCCA4AC", Offset = "0xCCA4AC", VA = "0xCCA4AC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xCCA4E4", Offset = "0xCCA4E4", VA = "0xCCA4E4")]
		public GetCenter()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD038", Offset = "0x6DD038")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD038", Offset = "0x6DD038")]
	public class GetRadius : Action
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB30C", Offset = "0x6EB30C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB344", Offset = "0x6EB344")]
		public SharedFloat storeValue;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xCD3D78", Offset = "0xCD3D78", VA = "0xCD3D78", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xCD3E88", Offset = "0xCD3E88", VA = "0xCD3E88", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xCD3F90", Offset = "0xCD3F90", VA = "0xCD3F90", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xCD3FD4", Offset = "0xCD3FD4", VA = "0xCD3FD4")]
		public GetRadius()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD098", Offset = "0x6DD098")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD098", Offset = "0x6DD098")]
	public class SetCenter : Action
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB390", Offset = "0x6EB390")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB3C8", Offset = "0x6EB3C8")]
		public SharedVector3 center;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC89B04", Offset = "0xC89B04", VA = "0xC89B04", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC89C14", Offset = "0xC89C14", VA = "0xC89C14", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xC89D1C", Offset = "0xC89D1C", VA = "0xC89D1C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xC89D60", Offset = "0xC89D60", VA = "0xC89D60")]
		public SetCenter()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD0F8", Offset = "0x6DD0F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD0F8", Offset = "0x6DD0F8")]
	public class SetRadius : Action
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB400", Offset = "0x6EB400")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB438", Offset = "0x6EB438")]
		public SharedFloat radius;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xC92C6C", Offset = "0xC92C6C", VA = "0xC92C6C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xC92D7C", Offset = "0xC92D7C", VA = "0xC92D7C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC92E84", Offset = "0xC92E84", VA = "0xC92E84", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC92EC4", Offset = "0xC92EC4", VA = "0xC92EC4")]
		public SetRadius()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD158", Offset = "0x6DD158")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD158", Offset = "0x6DD158")]
	public class CompareSharedBool : Conditional
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB470", Offset = "0x6EB470")]
		public SharedBool variable;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB4A8", Offset = "0x6EB4A8")]
		public SharedBool compareTo;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1128E1C", Offset = "0x1128E1C", VA = "0x1128E1C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1128EB4", Offset = "0x1128EB4", VA = "0x1128EB4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1128F04", Offset = "0x1128F04", VA = "0x1128F04")]
		public CompareSharedBool()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD1B8", Offset = "0x6DD1B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD1B8", Offset = "0x6DD1B8")]
	public class CompareSharedColor : Conditional
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB4E0", Offset = "0x6EB4E0")]
		public SharedColor variable;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB518", Offset = "0x6EB518")]
		public SharedColor compareTo;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1128F0C", Offset = "0x1128F0C", VA = "0x1128F0C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1128FA0", Offset = "0x1128FA0", VA = "0x1128FA0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1128FF8", Offset = "0x1128FF8", VA = "0x1128FF8")]
		public CompareSharedColor()
		{
		}
	}
	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD218", Offset = "0x6DD218")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD218", Offset = "0x6DD218")]
	public class CompareSharedFloat : Conditional
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB550", Offset = "0x6EB550")]
		public SharedFloat variable;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB588", Offset = "0x6EB588")]
		public SharedFloat compareTo;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1129000", Offset = "0x1129000", VA = "0x1129000", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1129090", Offset = "0x1129090", VA = "0x1129090", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x11290E0", Offset = "0x11290E0", VA = "0x11290E0")]
		public CompareSharedFloat()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD278", Offset = "0x6DD278")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD278", Offset = "0x6DD278")]
	public class CompareSharedGameObject : Conditional
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB5C0", Offset = "0x6EB5C0")]
		public SharedGameObject variable;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB5F8", Offset = "0x6EB5F8")]
		public SharedGameObject compareTo;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x11290E8", Offset = "0x11290E8", VA = "0x11290E8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x11292B8", Offset = "0x11292B8", VA = "0x11292B8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x11292EC", Offset = "0x11292EC", VA = "0x11292EC")]
		public CompareSharedGameObject()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD2D8", Offset = "0x6DD2D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD2D8", Offset = "0x6DD2D8")]
	public class CompareSharedGameObjectList : Conditional
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB630", Offset = "0x6EB630")]
		public SharedGameObjectList variable;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB668", Offset = "0x6EB668")]
		public SharedGameObjectList compareTo;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x11292F4", Offset = "0x11292F4", VA = "0x11292F4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x11294E4", Offset = "0x11294E4", VA = "0x11294E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1129518", Offset = "0x1129518", VA = "0x1129518")]
		public CompareSharedGameObjectList()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD338", Offset = "0x6DD338")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD338", Offset = "0x6DD338")]
	public class CompareSharedInt : Conditional
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB6A0", Offset = "0x6EB6A0")]
		public SharedInt variable;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB6D8", Offset = "0x6EB6D8")]
		public SharedInt compareTo;

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1129520", Offset = "0x1129520", VA = "0x1129520", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x11295B4", Offset = "0x11295B4", VA = "0x11295B4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1129604", Offset = "0x1129604", VA = "0x1129604")]
		public CompareSharedInt()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD398", Offset = "0x6DD398")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD398", Offset = "0x6DD398")]
	public class CompareSharedObject : Conditional
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB710", Offset = "0x6EB710")]
		public SharedObject variable;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB748", Offset = "0x6EB748")]
		public SharedObject compareTo;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x112960C", Offset = "0x112960C", VA = "0x112960C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x11297DC", Offset = "0x11297DC", VA = "0x11297DC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1129810", Offset = "0x1129810", VA = "0x1129810")]
		public CompareSharedObject()
		{
		}
	}
	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD3F8", Offset = "0x6DD3F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD3F8", Offset = "0x6DD3F8")]
	public class CompareSharedObjectList : Conditional
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB780", Offset = "0x6EB780")]
		public SharedObjectList variable;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB7B8", Offset = "0x6EB7B8")]
		public SharedObjectList compareTo;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1129818", Offset = "0x1129818", VA = "0x1129818", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1129A08", Offset = "0x1129A08", VA = "0x1129A08", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1129A3C", Offset = "0x1129A3C", VA = "0x1129A3C")]
		public CompareSharedObjectList()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD458", Offset = "0x6DD458")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD458", Offset = "0x6DD458")]
	public class CompareSharedQuaternion : Conditional
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB7F0", Offset = "0x6EB7F0")]
		public SharedQuaternion variable;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB828", Offset = "0x6EB828")]
		public SharedQuaternion compareTo;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1129A44", Offset = "0x1129A44", VA = "0x1129A44", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1129AD8", Offset = "0x1129AD8", VA = "0x1129AD8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1129B30", Offset = "0x1129B30", VA = "0x1129B30")]
		public CompareSharedQuaternion()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD4B8", Offset = "0x6DD4B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD4B8", Offset = "0x6DD4B8")]
	public class CompareSharedRect : Conditional
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB860", Offset = "0x6EB860")]
		public SharedRect variable;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB898", Offset = "0x6EB898")]
		public SharedRect compareTo;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1129B38", Offset = "0x1129B38", VA = "0x1129B38", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1129BCC", Offset = "0x1129BCC", VA = "0x1129BCC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1129C34", Offset = "0x1129C34", VA = "0x1129C34")]
		public CompareSharedRect()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD518", Offset = "0x6DD518")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD518", Offset = "0x6DD518")]
	public class CompareSharedString : Conditional
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB8D0", Offset = "0x6EB8D0")]
		public SharedString variable;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB908", Offset = "0x6EB908")]
		public SharedString compareTo;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1129C3C", Offset = "0x1129C3C", VA = "0x1129C3C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1129CCC", Offset = "0x1129CCC", VA = "0x1129CCC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1129D44", Offset = "0x1129D44", VA = "0x1129D44")]
		public CompareSharedString()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD578", Offset = "0x6DD578")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD578", Offset = "0x6DD578")]
	public class CompareSharedTransform : Conditional
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB940", Offset = "0x6EB940")]
		public SharedTransform variable;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB978", Offset = "0x6EB978")]
		public SharedTransform compareTo;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1129D4C", Offset = "0x1129D4C", VA = "0x1129D4C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1129F1C", Offset = "0x1129F1C", VA = "0x1129F1C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1129F50", Offset = "0x1129F50", VA = "0x1129F50")]
		public CompareSharedTransform()
		{
		}
	}
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD5D8", Offset = "0x6DD5D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD5D8", Offset = "0x6DD5D8")]
	public class CompareSharedTransformList : Conditional
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB9B0", Offset = "0x6EB9B0")]
		public SharedTransformList variable;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EB9E8", Offset = "0x6EB9E8")]
		public SharedTransformList compareTo;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1129F58", Offset = "0x1129F58", VA = "0x1129F58", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x112A148", Offset = "0x112A148", VA = "0x112A148", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x112A17C", Offset = "0x112A17C", VA = "0x112A17C")]
		public CompareSharedTransformList()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD638", Offset = "0x6DD638")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD638", Offset = "0x6DD638")]
	public class CompareSharedVector2 : Conditional
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBA20", Offset = "0x6EBA20")]
		public SharedVector2 variable;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBA58", Offset = "0x6EBA58")]
		public SharedVector2 compareTo;

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x112A184", Offset = "0x112A184", VA = "0x112A184", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x112A20C", Offset = "0x112A20C", VA = "0x112A20C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x112A264", Offset = "0x112A264", VA = "0x112A264")]
		public CompareSharedVector2()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD698", Offset = "0x6DD698")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD698", Offset = "0x6DD698")]
	public class CompareSharedVector3 : Conditional
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBA90", Offset = "0x6EBA90")]
		public SharedVector3 variable;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBAC8", Offset = "0x6EBAC8")]
		public SharedVector3 compareTo;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x112A26C", Offset = "0x112A26C", VA = "0x112A26C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x112A304", Offset = "0x112A304", VA = "0x112A304", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x112A35C", Offset = "0x112A35C", VA = "0x112A35C")]
		public CompareSharedVector3()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD6F8", Offset = "0x6DD6F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD6F8", Offset = "0x6DD6F8")]
	public class CompareSharedVector4 : Conditional
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBB00", Offset = "0x6EBB00")]
		public SharedVector4 variable;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBB38", Offset = "0x6EBB38")]
		public SharedVector4 compareTo;

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x112A364", Offset = "0x112A364", VA = "0x112A364", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x112A404", Offset = "0x112A404", VA = "0x112A404", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x112A45C", Offset = "0x112A45C", VA = "0x112A45C")]
		public CompareSharedVector4()
		{
		}
	}
	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD758", Offset = "0x6DD758")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD758", Offset = "0x6DD758")]
	public class SetSharedBool : Action
	{
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBB70", Offset = "0x6EBB70")]
		public SharedBool targetValue;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBBA8", Offset = "0x6EBBA8")]
		[RequiredField]
		public SharedBool targetVariable;

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xC9467C", Offset = "0xC9467C", VA = "0xC9467C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xC94704", Offset = "0xC94704", VA = "0xC94704", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xC9474C", Offset = "0xC9474C", VA = "0xC9474C")]
		public SetSharedBool()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD7B8", Offset = "0x6DD7B8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD7B8", Offset = "0x6DD7B8")]
	public class SetSharedColor : Action
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBBF4", Offset = "0x6EBBF4")]
		public SharedColor targetValue;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBC2C", Offset = "0x6EBC2C")]
		[RequiredField]
		public SharedColor targetVariable;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC94754", Offset = "0xC94754", VA = "0xC94754", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xC947D8", Offset = "0xC947D8", VA = "0xC947D8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xC94828", Offset = "0xC94828", VA = "0xC94828")]
		public SetSharedColor()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD818", Offset = "0x6DD818")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD818", Offset = "0x6DD818")]
	public class SetSharedFloat : Action
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBC78", Offset = "0x6EBC78")]
		public SharedFloat targetValue;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBCB0", Offset = "0x6EBCB0")]
		[RequiredField]
		public SharedFloat targetVariable;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC94830", Offset = "0xC94830", VA = "0xC94830", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xC948B4", Offset = "0xC948B4", VA = "0xC948B4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xC948FC", Offset = "0xC948FC", VA = "0xC948FC")]
		public SetSharedFloat()
		{
		}
	}
	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD878", Offset = "0x6DD878")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD878", Offset = "0x6DD878")]
	public class SetSharedGameObject : Action
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBCFC", Offset = "0x6EBCFC")]
		public SharedGameObject targetValue;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBD34", Offset = "0x6EBD34")]
		[RequiredField]
		public SharedGameObject targetVariable;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBD80", Offset = "0x6EBD80")]
		public SharedBool valueCanBeNull;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xC94904", Offset = "0xC94904", VA = "0xC94904", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xC94A1C", Offset = "0xC94A1C", VA = "0xC94A1C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xC94A6C", Offset = "0xC94A6C", VA = "0xC94A6C")]
		public SetSharedGameObject()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD8D8", Offset = "0x6DD8D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD8D8", Offset = "0x6DD8D8")]
	public class SetSharedGameObjectList : Action
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBDB8", Offset = "0x6EBDB8")]
		public SharedGameObjectList targetValue;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBDF0", Offset = "0x6EBDF0")]
		public SharedGameObjectList targetVariable;

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xC94A74", Offset = "0xC94A74", VA = "0xC94A74", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xC94AFC", Offset = "0xC94AFC", VA = "0xC94AFC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xC94B30", Offset = "0xC94B30", VA = "0xC94B30")]
		public SetSharedGameObjectList()
		{
		}
	}
	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD938", Offset = "0x6DD938")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD938", Offset = "0x6DD938")]
	public class SetSharedInt : Action
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBE3C", Offset = "0x6EBE3C")]
		public SharedInt targetValue;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBE74", Offset = "0x6EBE74")]
		public SharedInt targetVariable;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xC94B38", Offset = "0xC94B38", VA = "0xC94B38", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xC94BC0", Offset = "0xC94BC0", VA = "0xC94BC0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xC94C08", Offset = "0xC94C08", VA = "0xC94C08")]
		public SetSharedInt()
		{
		}
	}
	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD998", Offset = "0x6DD998")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD998", Offset = "0x6DD998")]
	public class SetSharedObject : Action
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBEC0", Offset = "0x6EBEC0")]
		public SharedObject targetValue;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBEF8", Offset = "0x6EBEF8")]
		public SharedObject targetVariable;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xC94C10", Offset = "0xC94C10", VA = "0xC94C10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xC94C98", Offset = "0xC94C98", VA = "0xC94C98", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xC94CCC", Offset = "0xC94CCC", VA = "0xC94CCC")]
		public SetSharedObject()
		{
		}
	}
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DD9F8", Offset = "0x6DD9F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DD9F8", Offset = "0x6DD9F8")]
	public class SetSharedObjectList : Action
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBF44", Offset = "0x6EBF44")]
		public SharedObjectList targetValue;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBF7C", Offset = "0x6EBF7C")]
		public SharedObjectList targetVariable;

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xC94CD4", Offset = "0xC94CD4", VA = "0xC94CD4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xC94D5C", Offset = "0xC94D5C", VA = "0xC94D5C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xC94D90", Offset = "0xC94D90", VA = "0xC94D90")]
		public SetSharedObjectList()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDA58", Offset = "0x6DDA58")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDA58", Offset = "0x6DDA58")]
	public class SetSharedQuaternion : Action
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EBFC8", Offset = "0x6EBFC8")]
		public SharedQuaternion targetValue;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC000", Offset = "0x6EC000")]
		[RequiredField]
		public SharedQuaternion targetVariable;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xC94D98", Offset = "0xC94D98", VA = "0xC94D98", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xC94E1C", Offset = "0xC94E1C", VA = "0xC94E1C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xC94E6C", Offset = "0xC94E6C", VA = "0xC94E6C")]
		public SetSharedQuaternion()
		{
		}
	}
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDAB8", Offset = "0x6DDAB8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDAB8", Offset = "0x6DDAB8")]
	public class SetSharedRect : Action
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC04C", Offset = "0x6EC04C")]
		public SharedRect targetValue;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC084", Offset = "0x6EC084")]
		[RequiredField]
		public SharedRect targetVariable;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xC94E74", Offset = "0xC94E74", VA = "0xC94E74", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xC94EF8", Offset = "0xC94EF8", VA = "0xC94EF8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xC94FDC", Offset = "0xC94FDC", VA = "0xC94FDC")]
		public SetSharedRect()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDB18", Offset = "0x6DDB18")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDB18", Offset = "0x6DDB18")]
	public class SetSharedString : Action
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC0D0", Offset = "0x6EC0D0")]
		public SharedString targetValue;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC108", Offset = "0x6EC108")]
		public SharedString targetVariable;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xC94FE4", Offset = "0xC94FE4", VA = "0xC94FE4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xC9506C", Offset = "0xC9506C", VA = "0xC9506C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xC950DC", Offset = "0xC950DC", VA = "0xC950DC")]
		public SetSharedString()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDB78", Offset = "0x6DDB78")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDB78", Offset = "0x6DDB78")]
	public class SetSharedTransform : Action
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC154", Offset = "0x6EC154")]
		public SharedTransform targetValue;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC18C", Offset = "0x6EC18C")]
		public SharedTransform targetVariable;

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xC950E4", Offset = "0xC950E4", VA = "0xC950E4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xC951D8", Offset = "0xC951D8", VA = "0xC951D8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xC9520C", Offset = "0xC9520C", VA = "0xC9520C")]
		public SetSharedTransform()
		{
		}
	}
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDBD8", Offset = "0x6DDBD8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDBD8", Offset = "0x6DDBD8")]
	public class SetSharedTransformList : Action
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC1D8", Offset = "0x6EC1D8")]
		public SharedTransformList targetValue;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC210", Offset = "0x6EC210")]
		[RequiredField]
		public SharedTransformList targetVariable;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xC95214", Offset = "0xC95214", VA = "0xC95214", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xC9529C", Offset = "0xC9529C", VA = "0xC9529C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC952D0", Offset = "0xC952D0", VA = "0xC952D0")]
		public SetSharedTransformList()
		{
		}
	}
	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDC38", Offset = "0x6DDC38")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDC38", Offset = "0x6DDC38")]
	public class SetSharedVector2 : Action
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC25C", Offset = "0x6EC25C")]
		public SharedVector2 targetValue;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC294", Offset = "0x6EC294")]
		public SharedVector2 targetVariable;

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC952D8", Offset = "0xC952D8", VA = "0xC952D8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xC9535C", Offset = "0xC9535C", VA = "0xC9535C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xC9541C", Offset = "0xC9541C", VA = "0xC9541C")]
		public SetSharedVector2()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDC98", Offset = "0x6DDC98")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDC98", Offset = "0x6DDC98")]
	public class SetSharedVector3 : Action
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC2E0", Offset = "0x6EC2E0")]
		public SharedVector3 targetValue;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC318", Offset = "0x6EC318")]
		public SharedVector3 targetVariable;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xC95424", Offset = "0xC95424", VA = "0xC95424", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xC954A8", Offset = "0xC954A8", VA = "0xC954A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xC954F8", Offset = "0xC954F8", VA = "0xC954F8")]
		public SetSharedVector3()
		{
		}
	}
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDCF8", Offset = "0x6DDCF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDCF8", Offset = "0x6DDCF8")]
	public class SetSharedVector4 : Action
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC364", Offset = "0x6EC364")]
		public SharedVector4 targetValue;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC39C", Offset = "0x6EC39C")]
		public SharedVector4 targetVariable;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC95500", Offset = "0xC95500", VA = "0xC95500", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC95584", Offset = "0xC95584", VA = "0xC95584", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xC95658", Offset = "0xC95658", VA = "0xC95658")]
		public SetSharedVector4()
		{
		}
	}
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDD58", Offset = "0x6DDD58")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDD58", Offset = "0x6DDD58")]
	public class SharedGameObjectToTransform : Action
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC3E8", Offset = "0x6EC3E8")]
		public SharedGameObject sharedGameObject;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC420", Offset = "0x6EC420")]
		public SharedTransform sharedTransform;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xC99FDC", Offset = "0xC99FDC", VA = "0xC99FDC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC9A0EC", Offset = "0xC9A0EC", VA = "0xC9A0EC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC9A120", Offset = "0xC9A120", VA = "0xC9A120")]
		public SharedGameObjectToTransform()
		{
		}
	}
	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDDB8", Offset = "0x6DDDB8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDDB8", Offset = "0x6DDDB8")]
	public class SharedGameObjectsToGameObjectList : Action
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC46C", Offset = "0x6EC46C")]
		public SharedGameObject[] gameObjects;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC4A4", Offset = "0x6EC4A4")]
		[RequiredField]
		public SharedGameObjectList storedGameObjectList;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xC9A128", Offset = "0xC9A128", VA = "0xC9A128", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xC9A1C0", Offset = "0xC9A1C0", VA = "0xC9A1C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC9A30C", Offset = "0xC9A30C", VA = "0xC9A30C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC9A340", Offset = "0xC9A340", VA = "0xC9A340")]
		public SharedGameObjectsToGameObjectList()
		{
		}
	}
	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDE18", Offset = "0x6DDE18")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDE18", Offset = "0x6DDE18")]
	public class SharedTransformToGameObject : Action
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC4F0", Offset = "0x6EC4F0")]
		public SharedTransform sharedTransform;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC528", Offset = "0x6EC528")]
		public SharedGameObject sharedGameObject;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xC9A8F4", Offset = "0xC9A8F4", VA = "0xC9A8F4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xC9A9F0", Offset = "0xC9A9F0", VA = "0xC9A9F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC9AA24", Offset = "0xC9AA24", VA = "0xC9AA24")]
		public SharedTransformToGameObject()
		{
		}
	}
	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDE78", Offset = "0x6DDE78")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDE78", Offset = "0x6DDE78")]
	public class SharedTransformsToTransformList : Action
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC574", Offset = "0x6EC574")]
		public SharedTransform[] transforms;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC5AC", Offset = "0x6EC5AC")]
		public SharedTransformList storedTransformList;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC9AA2C", Offset = "0xC9AA2C", VA = "0xC9AA2C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xC9AAC4", Offset = "0xC9AAC4", VA = "0xC9AAC4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xC9AC10", Offset = "0xC9AC10", VA = "0xC9AC10", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC9AC44", Offset = "0xC9AC44", VA = "0xC9AC44")]
		public SharedTransformsToTransformList()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDED8", Offset = "0x6DDED8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDED8", Offset = "0x6DDED8")]
	public class AddForce : Action
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC5F8", Offset = "0x6EC5F8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC630", Offset = "0x6EC630")]
		public SharedVector2 force;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1119B10", Offset = "0x1119B10", VA = "0x1119B10", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1119C20", Offset = "0x1119C20", VA = "0x1119C20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1119D28", Offset = "0x1119D28", VA = "0x1119D28", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1119D70", Offset = "0x1119D70", VA = "0x1119D70")]
		public AddForce()
		{
		}
	}
	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDF38", Offset = "0x6DDF38")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDF38", Offset = "0x6DDF38")]
	public class AddForceAtPosition : Action
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC668", Offset = "0x6EC668")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC6A0", Offset = "0x6EC6A0")]
		public SharedVector2 force;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC6D8", Offset = "0x6EC6D8")]
		public SharedVector2 position;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x111A058", Offset = "0x111A058", VA = "0x111A058", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x111A168", Offset = "0x111A168", VA = "0x111A168", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x111A2A8", Offset = "0x111A2A8", VA = "0x111A2A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x111A310", Offset = "0x111A310", VA = "0x111A310")]
		public AddForceAtPosition()
		{
		}
	}
	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDF98", Offset = "0x6DDF98")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDF98", Offset = "0x6DDF98")]
	public class AddTorque : Action
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC710", Offset = "0x6EC710")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC748", Offset = "0x6EC748")]
		public SharedFloat torque;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x111A9DC", Offset = "0x111A9DC", VA = "0x111A9DC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x111AAEC", Offset = "0x111AAEC", VA = "0x111AAEC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x111ABF4", Offset = "0x111ABF4", VA = "0x111ABF4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x111AC38", Offset = "0x111AC38", VA = "0x111AC38")]
		public AddTorque()
		{
		}
	}
	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DDFF8", Offset = "0x6DDFF8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DDFF8", Offset = "0x6DDFF8")]
	public class GetAngularDrag : Action
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC780", Offset = "0x6EC780")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC7B8", Offset = "0x6EC7B8")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xCC8610", Offset = "0xCC8610", VA = "0xCC8610", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xCC8720", Offset = "0xCC8720", VA = "0xCC8720", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xCC8828", Offset = "0xCC8828", VA = "0xCC8828", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xCC886C", Offset = "0xCC886C", VA = "0xCC886C")]
		public GetAngularDrag()
		{
		}
	}
	[Token(Token = "0x2000174")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE058", Offset = "0x6DE058")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE058", Offset = "0x6DE058")]
	public class GetAngularVelocity : Action
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC804", Offset = "0x6EC804")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC83C", Offset = "0x6EC83C")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xCC8D40", Offset = "0xCC8D40", VA = "0xCC8D40", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xCC8E50", Offset = "0xCC8E50", VA = "0xCC8E50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xCC8F58", Offset = "0xCC8F58", VA = "0xCC8F58", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xCC8F9C", Offset = "0xCC8F9C", VA = "0xCC8F9C")]
		public GetAngularVelocity()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE0B8", Offset = "0x6DE0B8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE0B8", Offset = "0x6DE0B8")]
	public class GetDrag : Action
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC888", Offset = "0x6EC888")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC8C0", Offset = "0x6EC8C0")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xCCBF54", Offset = "0xCCBF54", VA = "0xCCBF54", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xCCC064", Offset = "0xCCC064", VA = "0xCCC064", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xCCC16C", Offset = "0xCCC16C", VA = "0xCCC16C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xCCC1B0", Offset = "0xCCC1B0", VA = "0xCCC1B0")]
		public GetDrag()
		{
		}
	}
	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE118", Offset = "0x6DE118")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE118", Offset = "0x6DE118")]
	public class GetGravityScale : Action
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC90C", Offset = "0x6EC90C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC944", Offset = "0x6EC944")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xCCDB2C", Offset = "0xCCDB2C", VA = "0xCCDB2C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xCCDC3C", Offset = "0xCCDC3C", VA = "0xCCDC3C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xCCDD44", Offset = "0xCCDD44", VA = "0xCCDD44", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xCCDD88", Offset = "0xCCDD88", VA = "0xCCDD88")]
		public GetGravityScale()
		{
		}
	}
	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE178", Offset = "0x6DE178")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE178", Offset = "0x6DE178")]
	public class GetIsKinematic : Action
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC990", Offset = "0x6EC990")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC9C8", Offset = "0x6EC9C8")]
		public SharedBool storeValue;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xCCF27C", Offset = "0xCCF27C", VA = "0xCCF27C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xCCF38C", Offset = "0xCCF38C", VA = "0xCCF38C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xCCF498", Offset = "0xCCF498", VA = "0xCCF498", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xCCF4DC", Offset = "0xCCF4DC", VA = "0xCCF4DC")]
		public GetIsKinematic()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE1D8", Offset = "0x6DE1D8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE1D8", Offset = "0x6DE1D8")]
	public class GetMass : Action
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECA14", Offset = "0x6ECA14")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECA4C", Offset = "0x6ECA4C")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xCD0FB0", Offset = "0xCD0FB0", VA = "0xCD0FB0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xCD10C0", Offset = "0xCD10C0", VA = "0xCD10C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xCD11C8", Offset = "0xCD11C8", VA = "0xCD11C8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xCD120C", Offset = "0xCD120C", VA = "0xCD120C")]
		public GetMass()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE238", Offset = "0x6DE238")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE238", Offset = "0x6DE238")]
	public class GetPosition : Action
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECA98", Offset = "0x6ECA98")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECAD0", Offset = "0x6ECAD0")]
		public SharedVector2 storeValue;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xCD2BD0", Offset = "0xCD2BD0", VA = "0xCD2BD0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xCD2CE0", Offset = "0xCD2CE0", VA = "0xCD2CE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xCD2DE8", Offset = "0xCD2DE8", VA = "0xCD2DE8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xCD2E30", Offset = "0xCD2E30", VA = "0xCD2E30")]
		public GetPosition()
		{
		}
	}
	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE298", Offset = "0x6DE298")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE298", Offset = "0x6DE298")]
	public class GetRotation : Action
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECB1C", Offset = "0x6ECB1C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECB54", Offset = "0x6ECB54")]
		public SharedFloat storeValue;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xCD4C50", Offset = "0xCD4C50", VA = "0xCD4C50", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xCD4D60", Offset = "0xCD4D60", VA = "0xCD4D60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xCD4E68", Offset = "0xCD4E68", VA = "0xCD4E68", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xCD4EAC", Offset = "0xCD4EAC", VA = "0xCD4EAC")]
		public GetRotation()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE2F8", Offset = "0x6DE2F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE2F8", Offset = "0x6DE2F8")]
	public class GetVelocity : Action
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECBA0", Offset = "0x6ECBA0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECBD8", Offset = "0x6ECBD8")]
		[RequiredField]
		public SharedVector2 storeValue;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xCD8620", Offset = "0xCD8620", VA = "0xCD8620", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xCD8730", Offset = "0xCD8730", VA = "0xCD8730", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xCD8838", Offset = "0xCD8838", VA = "0xCD8838", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xCD8880", Offset = "0xCD8880", VA = "0xCD8880")]
		public GetVelocity()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE358", Offset = "0x6DE358")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE358", Offset = "0x6DE358")]
	public class IsKinematic : Conditional
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECC24", Offset = "0x6ECC24")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xFC14C8", Offset = "0xFC14C8", VA = "0xFC14C8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xFC15D8", Offset = "0xFC15D8", VA = "0xFC15D8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xFC16C0", Offset = "0xFC16C0", VA = "0xFC16C0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xFC16CC", Offset = "0xFC16CC", VA = "0xFC16CC")]
		public IsKinematic()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE3B8", Offset = "0x6DE3B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE3B8", Offset = "0x6DE3B8")]
	public class IsSleeping : Conditional
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECC5C", Offset = "0x6ECC5C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xFC2DD0", Offset = "0xFC2DD0", VA = "0xFC2DD0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xFC2EE0", Offset = "0xFC2EE0", VA = "0xFC2EE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xFC2FC8", Offset = "0xFC2FC8", VA = "0xFC2FC8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xFC2FD4", Offset = "0xFC2FD4", VA = "0xFC2FD4")]
		public IsSleeping()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE418", Offset = "0x6DE418")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE418", Offset = "0x6DE418")]
	public class MovePosition : Action
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECC94", Offset = "0x6ECC94")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECCCC", Offset = "0x6ECCCC")]
		public SharedVector2 position;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xFC7DBC", Offset = "0xFC7DBC", VA = "0xFC7DBC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFC7ECC", Offset = "0xFC7ECC", VA = "0xFC7ECC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xFC7FD4", Offset = "0xFC7FD4", VA = "0xFC7FD4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xFC801C", Offset = "0xFC801C", VA = "0xFC801C")]
		public MovePosition()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE478", Offset = "0x6DE478")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE478", Offset = "0x6DE478")]
	public class MoveRotation : Action
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECD04", Offset = "0x6ECD04")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECD3C", Offset = "0x6ECD3C")]
		public SharedFloat rotation;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xFC828C", Offset = "0xFC828C", VA = "0xFC828C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xFC839C", Offset = "0xFC839C", VA = "0xFC839C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xFC84A4", Offset = "0xFC84A4", VA = "0xFC84A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xFC84E8", Offset = "0xFC84E8", VA = "0xFC84E8")]
		public MoveRotation()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE4D8", Offset = "0x6DE4D8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE4D8", Offset = "0x6DE4D8")]
	public class SetAngularDrag : Action
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECD74", Offset = "0x6ECD74")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECDAC", Offset = "0x6ECDAC")]
		public SharedFloat angularDrag;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xFD4C20", Offset = "0xFD4C20", VA = "0xFD4C20", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xFD4D30", Offset = "0xFD4D30", VA = "0xFD4D30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xFD4E38", Offset = "0xFD4E38", VA = "0xFD4E38", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xFD4E7C", Offset = "0xFD4E7C", VA = "0xFD4E7C")]
		public SetAngularDrag()
		{
		}
	}
	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE538", Offset = "0x6DE538")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE538", Offset = "0x6DE538")]
	public class SetAngularVelocity : Action
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECDE4", Offset = "0x6ECDE4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECE1C", Offset = "0x6ECE1C")]
		public SharedFloat angularVelocity;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xFD5350", Offset = "0xFD5350", VA = "0xFD5350", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xFD5460", Offset = "0xFD5460", VA = "0xFD5460", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xFD5568", Offset = "0xFD5568", VA = "0xFD5568", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xFD55AC", Offset = "0xFD55AC", VA = "0xFD55AC")]
		public SetAngularVelocity()
		{
		}
	}
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE598", Offset = "0x6DE598")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE598", Offset = "0x6DE598")]
	public class SetDrag : Action
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECE54", Offset = "0x6ECE54")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECE8C", Offset = "0x6ECE8C")]
		public SharedFloat drag;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xC8B3D8", Offset = "0xC8B3D8", VA = "0xC8B3D8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xC8B4E8", Offset = "0xC8B4E8", VA = "0xC8B4E8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xC8B5F0", Offset = "0xC8B5F0", VA = "0xC8B5F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xC8B630", Offset = "0xC8B630", VA = "0xC8B630")]
		public SetDrag()
		{
		}
	}
	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE5F8", Offset = "0x6DE5F8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE5F8", Offset = "0x6DE5F8")]
	public class SetGravityScale : Action
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECEC4", Offset = "0x6ECEC4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECEFC", Offset = "0x6ECEFC")]
		public SharedFloat gravityScale;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xC8CDDC", Offset = "0xC8CDDC", VA = "0xC8CDDC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xC8CEEC", Offset = "0xC8CEEC", VA = "0xC8CEEC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xC8CFF4", Offset = "0xC8CFF4", VA = "0xC8CFF4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xC8D034", Offset = "0xC8D034", VA = "0xC8D034")]
		public SetGravityScale()
		{
		}
	}
	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE658", Offset = "0x6DE658")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE658", Offset = "0x6DE658")]
	public class SetIsKinematic : Action
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECF34", Offset = "0x6ECF34")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECF6C", Offset = "0x6ECF6C")]
		public SharedBool isKinematic;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xC8E420", Offset = "0xC8E420", VA = "0xC8E420", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xC8E530", Offset = "0xC8E530", VA = "0xC8E530", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xC8E63C", Offset = "0xC8E63C", VA = "0xC8E63C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xC8E67C", Offset = "0xC8E67C", VA = "0xC8E67C")]
		public SetIsKinematic()
		{
		}
	}
	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE6B8", Offset = "0x6DE6B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE6B8", Offset = "0x6DE6B8")]
	public class SetMass : Action
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECFA4", Offset = "0x6ECFA4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECFDC", Offset = "0x6ECFDC")]
		public SharedFloat mass;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xC902B4", Offset = "0xC902B4", VA = "0xC902B4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xC903C4", Offset = "0xC903C4", VA = "0xC903C4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xC904CC", Offset = "0xC904CC", VA = "0xC904CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xC9050C", Offset = "0xC9050C", VA = "0xC9050C")]
		public SetMass()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE718", Offset = "0x6DE718")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE718", Offset = "0x6DE718")]
	public class SetVelocity : Action
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED014", Offset = "0x6ED014")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED04C", Offset = "0x6ED04C")]
		public SharedVector2 velocity;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xC98F04", Offset = "0xC98F04", VA = "0xC98F04", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xC99014", Offset = "0xC99014", VA = "0xC99014", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xC9911C", Offset = "0xC9911C", VA = "0xC9911C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xC99160", Offset = "0xC99160", VA = "0xC99160")]
		public SetVelocity()
		{
		}
	}
	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE778", Offset = "0x6DE778")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE778", Offset = "0x6DE778")]
	public class Sleep : Conditional
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED084", Offset = "0x6ED084")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xC9E0BC", Offset = "0xC9E0BC", VA = "0xC9E0BC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xC9E1CC", Offset = "0xC9E1CC", VA = "0xC9E1CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xC9E2AC", Offset = "0xC9E2AC", VA = "0xC9E2AC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xC9E2B8", Offset = "0xC9E2B8", VA = "0xC9E2B8")]
		public Sleep()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE7D8", Offset = "0x6DE7D8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE7D8", Offset = "0x6DE7D8")]
	public class WakeUp : Conditional
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED0BC", Offset = "0x6ED0BC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x18DC470", Offset = "0x18DC470", VA = "0x18DC470", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x18DC580", Offset = "0x18DC580", VA = "0x18DC580", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x18DC660", Offset = "0x18DC660", VA = "0x18DC660", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x18DC66C", Offset = "0x18DC66C", VA = "0x18DC66C")]
		public WakeUp()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	[Token(Token = "0x2000189")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE838", Offset = "0x6DE838")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE838", Offset = "0x6DE838")]
	public class AddExplosionForce : Action
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED0F4", Offset = "0x6ED0F4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED12C", Offset = "0x6ED12C")]
		public SharedFloat explosionForce;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED164", Offset = "0x6ED164")]
		public SharedVector3 explosionPosition;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED19C", Offset = "0x6ED19C")]
		public SharedFloat explosionRadius;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED1D4", Offset = "0x6ED1D4")]
		public float upwardsModifier;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED20C", Offset = "0x6ED20C")]
		public ForceMode forceMode;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1119554", Offset = "0x1119554", VA = "0x1119554", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1119664", Offset = "0x1119664", VA = "0x1119664", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11197E4", Offset = "0x11197E4", VA = "0x11197E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x111986C", Offset = "0x111986C", VA = "0x111986C")]
		public AddExplosionForce()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "RequiredComponentAttribute", RVA = "0x6DE898", Offset = "0x6DE898")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE898", Offset = "0x6DE898")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE898", Offset = "0x6DE898")]
	public class AddForce : Action
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED244", Offset = "0x6ED244")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED27C", Offset = "0x6ED27C")]
		public SharedVector3 force;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED2B4", Offset = "0x6ED2B4")]
		public ForceMode forceMode;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1119874", Offset = "0x1119874", VA = "0x1119874", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1119984", Offset = "0x1119984", VA = "0x1119984", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1119A90", Offset = "0x1119A90", VA = "0x1119A90", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1119B08", Offset = "0x1119B08", VA = "0x1119B08")]
		public AddForce()
		{
		}
	}
	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE940", Offset = "0x6DE940")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE940", Offset = "0x6DE940")]
	public class AddForceAtPosition : Action
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED2EC", Offset = "0x6ED2EC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED324", Offset = "0x6ED324")]
		public SharedVector3 force;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED35C", Offset = "0x6ED35C")]
		public SharedVector3 position;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED394", Offset = "0x6ED394")]
		public ForceMode forceMode;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1119D78", Offset = "0x1119D78", VA = "0x1119D78", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1119E88", Offset = "0x1119E88", VA = "0x1119E88", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1119FE0", Offset = "0x1119FE0", VA = "0x1119FE0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x111A050", Offset = "0x111A050", VA = "0x111A050")]
		public AddForceAtPosition()
		{
		}
	}
	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DE9A0", Offset = "0x6DE9A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DE9A0", Offset = "0x6DE9A0")]
	public class AddRelativeForce : Action
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED3CC", Offset = "0x6ED3CC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED404", Offset = "0x6ED404")]
		public SharedVector3 force;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED43C", Offset = "0x6ED43C")]
		public ForceMode forceMode;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x111A318", Offset = "0x111A318", VA = "0x111A318", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x111A428", Offset = "0x111A428", VA = "0x111A428", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x111A534", Offset = "0x111A534", VA = "0x111A534", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x111A584", Offset = "0x111A584", VA = "0x111A584")]
		public AddRelativeForce()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEA00", Offset = "0x6DEA00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEA00", Offset = "0x6DEA00")]
	public class AddRelativeTorque : Action
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED474", Offset = "0x6ED474")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED4AC", Offset = "0x6ED4AC")]
		public SharedVector3 torque;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED4E4", Offset = "0x6ED4E4")]
		public ForceMode forceMode;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x111A58C", Offset = "0x111A58C", VA = "0x111A58C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x111A69C", Offset = "0x111A69C", VA = "0x111A69C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x111A710", Offset = "0x111A710", VA = "0x111A710", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x111A760", Offset = "0x111A760", VA = "0x111A760")]
		public AddRelativeTorque()
		{
		}
	}
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEA60", Offset = "0x6DEA60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEA60", Offset = "0x6DEA60")]
	public class AddTorque : Action
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED51C", Offset = "0x6ED51C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED554", Offset = "0x6ED554")]
		public SharedVector3 torque;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED58C", Offset = "0x6ED58C")]
		public ForceMode forceMode;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x111A768", Offset = "0x111A768", VA = "0x111A768", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x111A878", Offset = "0x111A878", VA = "0x111A878", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x111A984", Offset = "0x111A984", VA = "0x111A984", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x111A9D4", Offset = "0x111A9D4", VA = "0x111A9D4")]
		public AddTorque()
		{
		}
	}
	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEAC0", Offset = "0x6DEAC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEAC0", Offset = "0x6DEAC0")]
	public class GetAngularDrag : Action
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED5C4", Offset = "0x6ED5C4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED5FC", Offset = "0x6ED5FC")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xCC83AC", Offset = "0xCC83AC", VA = "0xCC83AC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xCC84BC", Offset = "0xCC84BC", VA = "0xCC84BC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xCC85C4", Offset = "0xCC85C4", VA = "0xCC85C4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xCC8608", Offset = "0xCC8608", VA = "0xCC8608")]
		public GetAngularDrag()
		{
		}
	}
	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEB20", Offset = "0x6DEB20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEB20", Offset = "0x6DEB20")]
	public class GetAngularVelocity : Action
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED648", Offset = "0x6ED648")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED680", Offset = "0x6ED680")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xCC8AD8", Offset = "0xCC8AD8", VA = "0xCC8AD8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xCC8BE8", Offset = "0xCC8BE8", VA = "0xCC8BE8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xCC8CF0", Offset = "0xCC8CF0", VA = "0xCC8CF0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xCC8D38", Offset = "0xCC8D38", VA = "0xCC8D38")]
		public GetAngularVelocity()
		{
		}
	}
	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEB80", Offset = "0x6DEB80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEB80", Offset = "0x6DEB80")]
	public class GetCenterOfMass : Action
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED6CC", Offset = "0x6ED6CC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED704", Offset = "0x6ED704")]
		public SharedVector3 storeValue;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xCCA4EC", Offset = "0xCCA4EC", VA = "0xCCA4EC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xCCA5FC", Offset = "0xCCA5FC", VA = "0xCCA5FC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xCCA704", Offset = "0xCCA704", VA = "0xCCA704", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xCCA74C", Offset = "0xCCA74C", VA = "0xCCA74C")]
		public GetCenterOfMass()
		{
		}
	}
	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEBE0", Offset = "0x6DEBE0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEBE0", Offset = "0x6DEBE0")]
	public class GetDrag : Action
	{
		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED750", Offset = "0x6ED750")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED788", Offset = "0x6ED788")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xCCBCF0", Offset = "0xCCBCF0", VA = "0xCCBCF0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xCCBE00", Offset = "0xCCBE00", VA = "0xCCBE00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xCCBF08", Offset = "0xCCBF08", VA = "0xCCBF08", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xCCBF4C", Offset = "0xCCBF4C", VA = "0xCCBF4C")]
		public GetDrag()
		{
		}
	}
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEC40", Offset = "0x6DEC40")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEC40", Offset = "0x6DEC40")]
	public class GetFreezeRotation : Action
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED7D4", Offset = "0x6ED7D4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED80C", Offset = "0x6ED80C")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xCCD8C4", Offset = "0xCCD8C4", VA = "0xCCD8C4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xCCD9D4", Offset = "0xCCD9D4", VA = "0xCCD9D4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xCCDAE0", Offset = "0xCCDAE0", VA = "0xCCDAE0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xCCDB24", Offset = "0xCCDB24", VA = "0xCCDB24")]
		public GetFreezeRotation()
		{
		}
	}
	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DECA0", Offset = "0x6DECA0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DECA0", Offset = "0x6DECA0")]
	public class GetIsKinematic : Action
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED858", Offset = "0x6ED858")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED890", Offset = "0x6ED890")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xCCF014", Offset = "0xCCF014", VA = "0xCCF014", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xCCF124", Offset = "0xCCF124", VA = "0xCCF124", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xCCF230", Offset = "0xCCF230", VA = "0xCCF230", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xCCF274", Offset = "0xCCF274", VA = "0xCCF274")]
		public GetIsKinematic()
		{
		}
	}
	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DED00", Offset = "0x6DED00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DED00", Offset = "0x6DED00")]
	public class GetMass : Action
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED8DC", Offset = "0x6ED8DC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED914", Offset = "0x6ED914")]
		public SharedFloat storeValue;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xCD0D4C", Offset = "0xCD0D4C", VA = "0xCD0D4C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xCD0E5C", Offset = "0xCD0E5C", VA = "0xCD0E5C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xCD0F64", Offset = "0xCD0F64", VA = "0xCD0F64", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xCD0FA8", Offset = "0xCD0FA8", VA = "0xCD0FA8")]
		public GetMass()
		{
		}
	}
	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DED60", Offset = "0x6DED60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DED60", Offset = "0x6DED60")]
	public class GetPosition : Action
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED960", Offset = "0x6ED960")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED998", Offset = "0x6ED998")]
		public SharedVector3 storeValue;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xCD2968", Offset = "0xCD2968", VA = "0xCD2968", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xCD2A78", Offset = "0xCD2A78", VA = "0xCD2A78", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xCD2B80", Offset = "0xCD2B80", VA = "0xCD2B80", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xCD2BC8", Offset = "0xCD2BC8", VA = "0xCD2BC8")]
		public GetPosition()
		{
		}
	}
	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEDC0", Offset = "0x6DEDC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEDC0", Offset = "0x6DEDC0")]
	public class GetRotation : Action
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ED9E4", Offset = "0x6ED9E4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDA1C", Offset = "0x6EDA1C")]
		[RequiredField]
		public SharedQuaternion storeValue;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xCD49E8", Offset = "0xCD49E8", VA = "0xCD49E8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xCD4AF8", Offset = "0xCD4AF8", VA = "0xCD4AF8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xCD4C00", Offset = "0xCD4C00", VA = "0xCD4C00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xCD4C48", Offset = "0xCD4C48", VA = "0xCD4C48")]
		public GetRotation()
		{
		}
	}
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEE20", Offset = "0x6DEE20")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEE20", Offset = "0x6DEE20")]
	public class GetUseGravity : Action
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDA68", Offset = "0x6EDA68")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDAA0", Offset = "0x6EDAA0")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xCD7D1C", Offset = "0xCD7D1C", VA = "0xCD7D1C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xCD7E2C", Offset = "0xCD7E2C", VA = "0xCD7E2C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xCD7F38", Offset = "0xCD7F38", VA = "0xCD7F38", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xCD7F7C", Offset = "0xCD7F7C", VA = "0xCD7F7C")]
		public GetUseGravity()
		{
		}
	}
	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEE80", Offset = "0x6DEE80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEE80", Offset = "0x6DEE80")]
	public class GetVelocity : Action
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDAEC", Offset = "0x6EDAEC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDB24", Offset = "0x6EDB24")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xCD83B8", Offset = "0xCD83B8", VA = "0xCD83B8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xCD84C8", Offset = "0xCD84C8", VA = "0xCD84C8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xCD85D0", Offset = "0xCD85D0", VA = "0xCD85D0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xCD8618", Offset = "0xCD8618", VA = "0xCD8618")]
		public GetVelocity()
		{
		}
	}
	[Token(Token = "0x200019A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEEE0", Offset = "0x6DEEE0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEEE0", Offset = "0x6DEEE0")]
	public class IsKinematic : Conditional
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDB70", Offset = "0x6EDB70")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xFC12BC", Offset = "0xFC12BC", VA = "0xFC12BC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFC13CC", Offset = "0xFC13CC", VA = "0xFC13CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xFC14B4", Offset = "0xFC14B4", VA = "0xFC14B4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xFC14C0", Offset = "0xFC14C0", VA = "0xFC14C0")]
		public IsKinematic()
		{
		}
	}
	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEF40", Offset = "0x6DEF40")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEF40", Offset = "0x6DEF40")]
	public class IsSleeping : Conditional
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDBA8", Offset = "0x6EDBA8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xFC2BC4", Offset = "0xFC2BC4", VA = "0xFC2BC4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xFC2CD4", Offset = "0xFC2CD4", VA = "0xFC2CD4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xFC2DBC", Offset = "0xFC2DBC", VA = "0xFC2DBC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xFC2DC8", Offset = "0xFC2DC8", VA = "0xFC2DC8")]
		public IsSleeping()
		{
		}
	}
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DEFA0", Offset = "0x6DEFA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DEFA0", Offset = "0x6DEFA0")]
	public class MovePosition : Action
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDBE0", Offset = "0x6EDBE0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDC18", Offset = "0x6EDC18")]
		public SharedVector3 position;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xFC7B54", Offset = "0xFC7B54", VA = "0xFC7B54", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xFC7C64", Offset = "0xFC7C64", VA = "0xFC7C64", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xFC7D6C", Offset = "0xFC7D6C", VA = "0xFC7D6C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFC7DB4", Offset = "0xFC7DB4", VA = "0xFC7DB4")]
		public MovePosition()
		{
		}
	}
	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF000", Offset = "0x6DF000")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF000", Offset = "0x6DF000")]
	public class MoveRotation : Action
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDC50", Offset = "0x6EDC50")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDC88", Offset = "0x6EDC88")]
		public SharedQuaternion rotation;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFC8024", Offset = "0xFC8024", VA = "0xFC8024", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xFC8134", Offset = "0xFC8134", VA = "0xFC8134", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xFC823C", Offset = "0xFC823C", VA = "0xFC823C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFC8284", Offset = "0xFC8284", VA = "0xFC8284")]
		public MoveRotation()
		{
		}
	}
	[Token(Token = "0x200019E")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF060", Offset = "0x6DF060")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF060", Offset = "0x6DF060")]
	public class SetAngularDrag : Action
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDCC0", Offset = "0x6EDCC0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDCF8", Offset = "0x6EDCF8")]
		public SharedFloat angularDrag;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFD49BC", Offset = "0xFD49BC", VA = "0xFD49BC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFD4ACC", Offset = "0xFD4ACC", VA = "0xFD4ACC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xFD4BD4", Offset = "0xFD4BD4", VA = "0xFD4BD4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFD4C18", Offset = "0xFD4C18", VA = "0xFD4C18")]
		public SetAngularDrag()
		{
		}
	}
	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF0C0", Offset = "0x6DF0C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF0C0", Offset = "0x6DF0C0")]
	public class SetAngularVelocity : Action
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDD30", Offset = "0x6EDD30")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDD68", Offset = "0x6EDD68")]
		public SharedVector3 angularVelocity;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFD50E8", Offset = "0xFD50E8", VA = "0xFD50E8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFD51F8", Offset = "0xFD51F8", VA = "0xFD51F8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFD5300", Offset = "0xFD5300", VA = "0xFD5300", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFD5348", Offset = "0xFD5348", VA = "0xFD5348")]
		public SetAngularVelocity()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF120", Offset = "0x6DF120")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF120", Offset = "0x6DF120")]
	public class SetCenterOfMass : Action
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDDA0", Offset = "0x6EDDA0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDDD8", Offset = "0x6EDDD8")]
		public SharedVector3 centerOfMass;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xC89D68", Offset = "0xC89D68", VA = "0xC89D68", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xC89E78", Offset = "0xC89E78", VA = "0xC89E78", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xC89F80", Offset = "0xC89F80", VA = "0xC89F80", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xC89FC4", Offset = "0xC89FC4", VA = "0xC89FC4")]
		public SetCenterOfMass()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF180", Offset = "0x6DF180")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF180", Offset = "0x6DF180")]
	public class SetConstraints : Action
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDE10", Offset = "0x6EDE10")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDE48", Offset = "0x6EDE48")]
		public RigidbodyConstraints constraints;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xC8A2B4", Offset = "0xC8A2B4", VA = "0xC8A2B4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xC8A3C4", Offset = "0xC8A3C4", VA = "0xC8A3C4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xC8A4A8", Offset = "0xC8A4A8", VA = "0xC8A4A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xC8A4D8", Offset = "0xC8A4D8", VA = "0xC8A4D8")]
		public SetConstraints()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF1E0", Offset = "0x6DF1E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF1E0", Offset = "0x6DF1E0")]
	public class SetDrag : Action
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDE80", Offset = "0x6EDE80")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDEB8", Offset = "0x6EDEB8")]
		public SharedFloat drag;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xC8B178", Offset = "0xC8B178", VA = "0xC8B178", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xC8B288", Offset = "0xC8B288", VA = "0xC8B288", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xC8B390", Offset = "0xC8B390", VA = "0xC8B390", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xC8B3D0", Offset = "0xC8B3D0", VA = "0xC8B3D0")]
		public SetDrag()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF240", Offset = "0x6DF240")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF240", Offset = "0x6DF240")]
	public class SetFreezeRotation : Action
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDEF0", Offset = "0x6EDEF0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDF28", Offset = "0x6EDF28")]
		public SharedBool freezeRotation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xC8CB78", Offset = "0xC8CB78", VA = "0xC8CB78", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xC8CC88", Offset = "0xC8CC88", VA = "0xC8CC88", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xC8CD94", Offset = "0xC8CD94", VA = "0xC8CD94", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xC8CDD4", Offset = "0xC8CDD4", VA = "0xC8CDD4")]
		public SetFreezeRotation()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF2A0", Offset = "0x6DF2A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF2A0", Offset = "0x6DF2A0")]
	public class SetIsKinematic : Action
	{
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDF60", Offset = "0x6EDF60")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDF98", Offset = "0x6EDF98")]
		public SharedBool isKinematic;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xC8E1BC", Offset = "0xC8E1BC", VA = "0xC8E1BC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xC8E2CC", Offset = "0xC8E2CC", VA = "0xC8E2CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xC8E3D8", Offset = "0xC8E3D8", VA = "0xC8E3D8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xC8E418", Offset = "0xC8E418", VA = "0xC8E418")]
		public SetIsKinematic()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF300", Offset = "0x6DF300")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF300", Offset = "0x6DF300")]
	public class SetMass : Action
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EDFD0", Offset = "0x6EDFD0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE008", Offset = "0x6EE008")]
		public SharedFloat mass;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xC90054", Offset = "0xC90054", VA = "0xC90054", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xC90164", Offset = "0xC90164", VA = "0xC90164", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xC9026C", Offset = "0xC9026C", VA = "0xC9026C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xC902AC", Offset = "0xC902AC", VA = "0xC902AC")]
		public SetMass()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF360", Offset = "0x6DF360")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF360", Offset = "0x6DF360")]
	public class SetPosition : Action
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE040", Offset = "0x6EE040")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE078", Offset = "0x6EE078")]
		public SharedVector3 position;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xC91AD4", Offset = "0xC91AD4", VA = "0xC91AD4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xC91BE4", Offset = "0xC91BE4", VA = "0xC91BE4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xC91CEC", Offset = "0xC91CEC", VA = "0xC91CEC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xC91D30", Offset = "0xC91D30", VA = "0xC91D30")]
		public SetPosition()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF3C0", Offset = "0x6DF3C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF3C0", Offset = "0x6DF3C0")]
	public class SetRotation : Action
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE0B0", Offset = "0x6EE0B0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE0E8", Offset = "0x6EE0E8")]
		public SharedQuaternion rotation;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xC935BC", Offset = "0xC935BC", VA = "0xC935BC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xC936CC", Offset = "0xC936CC", VA = "0xC936CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xC937D4", Offset = "0xC937D4", VA = "0xC937D4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xC93818", Offset = "0xC93818", VA = "0xC93818")]
		public SetRotation()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF420", Offset = "0x6DF420")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF420", Offset = "0x6DF420")]
	public class SetUseGravity : Action
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE120", Offset = "0x6EE120")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE158", Offset = "0x6EE158")]
		public SharedBool useGravity;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xC98884", Offset = "0xC98884", VA = "0xC98884", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xC98994", Offset = "0xC98994", VA = "0xC98994", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xC98AA0", Offset = "0xC98AA0", VA = "0xC98AA0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC98AE0", Offset = "0xC98AE0", VA = "0xC98AE0")]
		public SetUseGravity()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF480", Offset = "0x6DF480")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF480", Offset = "0x6DF480")]
	public class SetVelocity : Action
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE190", Offset = "0x6EE190")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE1C8", Offset = "0x6EE1C8")]
		public SharedVector3 velocity;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC98CA0", Offset = "0xC98CA0", VA = "0xC98CA0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xC98DB0", Offset = "0xC98DB0", VA = "0xC98DB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xC98EB8", Offset = "0xC98EB8", VA = "0xC98EB8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xC98EFC", Offset = "0xC98EFC", VA = "0xC98EFC")]
		public SetVelocity()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF4E0", Offset = "0x6DF4E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF4E0", Offset = "0x6DF4E0")]
	public class Sleep : Conditional
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE200", Offset = "0x6EE200")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xC9DEB8", Offset = "0xC9DEB8", VA = "0xC9DEB8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xC9DFC8", Offset = "0xC9DFC8", VA = "0xC9DFC8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xC9E0A8", Offset = "0xC9E0A8", VA = "0xC9E0A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xC9E0B4", Offset = "0xC9E0B4", VA = "0xC9E0B4")]
		public Sleep()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF540", Offset = "0x6DF540")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF540", Offset = "0x6DF540")]
	public class UseGravity : Conditional
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE238", Offset = "0x6EE238")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x18DACD0", Offset = "0x18DACD0", VA = "0x18DACD0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x18DADE0", Offset = "0x18DADE0", VA = "0x18DADE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x18DAEC8", Offset = "0x18DAEC8", VA = "0x18DAEC8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x18DAED4", Offset = "0x18DAED4", VA = "0x18DAED4")]
		public UseGravity()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF5A0", Offset = "0x6DF5A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF5A0", Offset = "0x6DF5A0")]
	public class WakeUp : Conditional
	{
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE270", Offset = "0x6EE270")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x18DC26C", Offset = "0x18DC26C", VA = "0x18DC26C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x18DC37C", Offset = "0x18DC37C", VA = "0x18DC37C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x18DC45C", Offset = "0x18DC45C", VA = "0x18DC45C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x18DC468", Offset = "0x18DC468", VA = "0x18DC468")]
		public WakeUp()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRenderer
{
	[Token(Token = "0x20001AD")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF600", Offset = "0x6DF600")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF600", Offset = "0x6DF600")]
	public class IsVisible : Conditional
	{
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE2A8", Offset = "0x6EE2A8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer renderer;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xFC33F4", Offset = "0xFC33F4", VA = "0xFC33F4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xFC3504", Offset = "0xFC3504", VA = "0xFC3504", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xFC35EC", Offset = "0xFC35EC", VA = "0xFC35EC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xFC35F8", Offset = "0xFC35F8", VA = "0xFC35F8")]
		public IsVisible()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF660", Offset = "0x6DF660")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF660", Offset = "0x6DF660")]
	public class SetMaterial : Action
	{
		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE2E0", Offset = "0x6EE2E0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE318", Offset = "0x6EE318")]
		public SharedMaterial material;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer renderer;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xC90514", Offset = "0xC90514", VA = "0xC90514", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xC90624", Offset = "0xC90624", VA = "0xC90624", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xC90730", Offset = "0xC90730", VA = "0xC90730", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xC90764", Offset = "0xC90764", VA = "0xC90764")]
		public SetMaterial()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	[Token(Token = "0x20001AF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF6C0", Offset = "0x6DF6C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF6C0", Offset = "0x6DF6C0")]
	public class Angle : Action
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE350", Offset = "0x6EE350")]
		public SharedQuaternion firstRotation;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE388", Offset = "0x6EE388")]
		public SharedQuaternion secondRotation;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE3C0", Offset = "0x6EE3C0")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x111AC40", Offset = "0x111AC40", VA = "0x111AC40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x111AD5C", Offset = "0x111AD5C", VA = "0x111AD5C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x111ADC4", Offset = "0x111ADC4", VA = "0x111ADC4")]
		public Angle()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF720", Offset = "0x6DF720")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF720", Offset = "0x6DF720")]
	public class AngleAxis : Action
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE40C", Offset = "0x6EE40C")]
		public SharedFloat degrees;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE444", Offset = "0x6EE444")]
		public SharedVector3 axis;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE47C", Offset = "0x6EE47C")]
		public SharedQuaternion storeResult;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x111AF20", Offset = "0x111AF20", VA = "0x111AF20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x111AFF8", Offset = "0x111AFF8", VA = "0x111AFF8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x111B06C", Offset = "0x111B06C", VA = "0x111B06C")]
		public AngleAxis()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF780", Offset = "0x6DF780")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF780", Offset = "0x6DF780")]
	public class Dot : Action
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE4C8", Offset = "0x6EE4C8")]
		public SharedQuaternion leftRotation;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE500", Offset = "0x6EE500")]
		public SharedQuaternion rightRotation;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE538", Offset = "0x6EE538")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x112C20C", Offset = "0x112C20C", VA = "0x112C20C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x112C2F0", Offset = "0x112C2F0", VA = "0x112C2F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x112C358", Offset = "0x112C358", VA = "0x112C358")]
		public Dot()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF7E0", Offset = "0x6DF7E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF7E0", Offset = "0x6DF7E0")]
	public class Euler : Action
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE584", Offset = "0x6EE584")]
		public SharedVector3 eulerVector;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE5BC", Offset = "0x6EE5BC")]
		[RequiredField]
		public SharedQuaternion storeResult;

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xCC1954", Offset = "0xCC1954", VA = "0xCC1954", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xCC19E0", Offset = "0xCC19E0", VA = "0xCC19E0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xCC1A38", Offset = "0xCC1A38", VA = "0xCC1A38")]
		public Euler()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF840", Offset = "0x6DF840")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF840", Offset = "0x6DF840")]
	public class FromToRotation : Action
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE608", Offset = "0x6EE608")]
		public SharedVector3 fromDirection;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE640", Offset = "0x6EE640")]
		public SharedVector3 toDirection;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE678", Offset = "0x6EE678")]
		[RequiredField]
		public SharedQuaternion storeResult;

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xCC60C0", Offset = "0xCC60C0", VA = "0xCC60C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xCC6198", Offset = "0xCC6198", VA = "0xCC6198", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xCC6204", Offset = "0xCC6204", VA = "0xCC6204")]
		public FromToRotation()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF8A0", Offset = "0x6DF8A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF8A0", Offset = "0x6DF8A0")]
	public class Identity : Action
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE6C4", Offset = "0x6EE6C4")]
		[RequiredField]
		public SharedQuaternion storeResult;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xFBF048", Offset = "0xFBF048", VA = "0xFBF048", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xFBF0B0", Offset = "0xFBF0B0", VA = "0xFBF0B0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xFBF0E8", Offset = "0xFBF0E8", VA = "0xFBF0E8")]
		public Identity()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF900", Offset = "0x6DF900")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF900", Offset = "0x6DF900")]
	public class Inverse : Action
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE710", Offset = "0x6EE710")]
		public SharedQuaternion targetQuaternion;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE748", Offset = "0x6EE748")]
		public SharedQuaternion storeResult;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xFBFDF0", Offset = "0xFBFDF0", VA = "0xFBFDF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xFBFE7C", Offset = "0xFBFE7C", VA = "0xFBFE7C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xFBFEC8", Offset = "0xFBFEC8", VA = "0xFBFEC8")]
		public Inverse()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF960", Offset = "0x6DF960")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF960", Offset = "0x6DF960")]
	public class Lerp : Action
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE794", Offset = "0x6EE794")]
		public SharedQuaternion fromQuaternion;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE7CC", Offset = "0x6EE7CC")]
		public SharedQuaternion toQuaternion;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE804", Offset = "0x6EE804")]
		public SharedFloat amount;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE83C", Offset = "0x6EE83C")]
		[RequiredField]
		public SharedQuaternion storeResult;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xFC4A20", Offset = "0xFC4A20", VA = "0xFC4A20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xFC4B54", Offset = "0xFC4B54", VA = "0xFC4B54", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xFC4BCC", Offset = "0xFC4BCC", VA = "0xFC4BCC")]
		public Lerp()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DF9C0", Offset = "0x6DF9C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DF9C0", Offset = "0x6DF9C0")]
	public class LookRotation : Action
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE888", Offset = "0x6EE888")]
		public SharedVector3 forwardVector;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE8C0", Offset = "0x6EE8C0")]
		public SharedVector3 secondVector3;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE8F8", Offset = "0x6EE8F8")]
		[RequiredField]
		public SharedQuaternion storeResult;

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xFC7190", Offset = "0xFC7190", VA = "0xFC7190", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xFC7268", Offset = "0xFC7268", VA = "0xFC7268", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFC72C0", Offset = "0xFC72C0", VA = "0xFC72C0")]
		public LookRotation()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFA20", Offset = "0x6DFA20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFA20", Offset = "0x6DFA20")]
	public class RotateTowards : Action
	{
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE944", Offset = "0x6EE944")]
		public SharedQuaternion fromQuaternion;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE97C", Offset = "0x6EE97C")]
		public SharedQuaternion toQuaternion;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE9B4", Offset = "0x6EE9B4")]
		public SharedFloat maxDeltaDegrees;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EE9EC", Offset = "0x6EE9EC")]
		public SharedQuaternion storeResult;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xFD2B00", Offset = "0xFD2B00", VA = "0xFD2B00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xFD2C34", Offset = "0xFD2C34", VA = "0xFD2C34", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xFD2CAC", Offset = "0xFD2CAC", VA = "0xFD2CAC")]
		public RotateTowards()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFA80", Offset = "0x6DFA80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFA80", Offset = "0x6DFA80")]
	public class Slerp : Action
	{
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEA38", Offset = "0x6EEA38")]
		public SharedQuaternion fromQuaternion;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEA70", Offset = "0x6EEA70")]
		public SharedQuaternion toQuaternion;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEAA8", Offset = "0x6EEAA8")]
		public SharedFloat amount;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEAE0", Offset = "0x6EEAE0")]
		[RequiredField]
		public SharedQuaternion storeResult;

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xC9E2C0", Offset = "0xC9E2C0", VA = "0xC9E2C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xC9E3F4", Offset = "0xC9E3F4", VA = "0xC9E3F4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xC9E464", Offset = "0xC9E464", VA = "0xC9E464")]
		public Slerp()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	[Token(Token = "0x20001BA")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFAE0", Offset = "0x6DFAE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFAE0", Offset = "0x6DFAE0")]
	public class DeleteAll : Action
	{
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x112BCAC", Offset = "0x112BCAC", VA = "0x112BCAC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x112BCC8", Offset = "0x112BCC8", VA = "0x112BCC8")]
		public DeleteAll()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFB40", Offset = "0x6DFB40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFB40", Offset = "0x6DFB40")]
	public class DeleteKey : Action
	{
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEB2C", Offset = "0x6EEB2C")]
		public SharedString key;

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x112BCD0", Offset = "0x112BCD0", VA = "0x112BCD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x112BD34", Offset = "0x112BD34", VA = "0x112BD34", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x112BD90", Offset = "0x112BD90", VA = "0x112BD90")]
		public DeleteKey()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFBA0", Offset = "0x6DFBA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFBA0", Offset = "0x6DFBA0")]
	public class GetFloat : Action
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEB64", Offset = "0x6EEB64")]
		public SharedString key;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEB9C", Offset = "0x6EEB9C")]
		public SharedFloat defaultValue;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEBD4", Offset = "0x6EEBD4")]
		public SharedFloat storeResult;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xCCD18C", Offset = "0xCCD18C", VA = "0xCCD18C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xCCD248", Offset = "0xCCD248", VA = "0xCCD248", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xCCD2DC", Offset = "0xCCD2DC", VA = "0xCCD2DC")]
		public GetFloat()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFC00", Offset = "0x6DFC00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFC00", Offset = "0x6DFC00")]
	public class GetInt : Action
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEC20", Offset = "0x6EEC20")]
		public SharedString key;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEC58", Offset = "0x6EEC58")]
		public SharedInt defaultValue;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEC90", Offset = "0x6EEC90")]
		public SharedInt storeResult;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xCCE98C", Offset = "0xCCE98C", VA = "0xCCE98C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xCCEA50", Offset = "0xCCEA50", VA = "0xCCEA50", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xCCEAE4", Offset = "0xCCEAE4", VA = "0xCCEAE4")]
		public GetInt()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFC60", Offset = "0x6DFC60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFC60", Offset = "0x6DFC60")]
	public class GetString : Action
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EECDC", Offset = "0x6EECDC")]
		public SharedString key;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EED14", Offset = "0x6EED14")]
		public SharedString defaultValue;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EED4C", Offset = "0x6EED4C")]
		[RequiredField]
		public SharedString storeResult;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xCD6ADC", Offset = "0xCD6ADC", VA = "0xCD6ADC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xCD6B94", Offset = "0xCD6B94", VA = "0xCD6B94", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xCD6C28", Offset = "0xCD6C28", VA = "0xCD6C28")]
		public GetString()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFCC0", Offset = "0x6DFCC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFCC0", Offset = "0x6DFCC0")]
	public class HasKey : Conditional
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EED98", Offset = "0x6EED98")]
		public SharedString key;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xCD9E68", Offset = "0xCD9E68", VA = "0xCD9E68", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xCD9ED4", Offset = "0xCD9ED4", VA = "0xCD9ED4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xCD9F30", Offset = "0xCD9F30", VA = "0xCD9F30")]
		public HasKey()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFD20", Offset = "0x6DFD20")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFD20", Offset = "0x6DFD20")]
	public class Save : Action
	{
		[Token(Token = "0x6000685")]
		[Address(RVA = "0xFD30BC", Offset = "0xFD30BC", VA = "0xFD30BC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xFD30D8", Offset = "0xFD30D8", VA = "0xFD30D8")]
		public Save()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFD80", Offset = "0x6DFD80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFD80", Offset = "0x6DFD80")]
	public class SetFloat : Action
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEDD0", Offset = "0x6EEDD0")]
		public SharedString key;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEE08", Offset = "0x6EEE08")]
		public SharedFloat value;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xC8C458", Offset = "0xC8C458", VA = "0xC8C458", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xC8C4EC", Offset = "0xC8C4EC", VA = "0xC8C4EC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xC8C55C", Offset = "0xC8C55C", VA = "0xC8C55C")]
		public SetFloat()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFDE0", Offset = "0x6DFDE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFDE0", Offset = "0x6DFDE0")]
	public class SetInt : Action
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEE40", Offset = "0x6EEE40")]
		public SharedString key;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEE78", Offset = "0x6EEE78")]
		public SharedInt value;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xC8DA9C", Offset = "0xC8DA9C", VA = "0xC8DA9C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xC8DB34", Offset = "0xC8DB34", VA = "0xC8DB34", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xC8DBA4", Offset = "0xC8DBA4", VA = "0xC8DBA4")]
		public SetInt()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFE40", Offset = "0x6DFE40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFE40", Offset = "0x6DFE40")]
	public class SetString : Action
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEEB0", Offset = "0x6EEEB0")]
		public SharedString key;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEEE8", Offset = "0x6EEEE8")]
		public SharedString value;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xC978F0", Offset = "0xC978F0", VA = "0xC978F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xC97974", Offset = "0xC97974", VA = "0xC97974", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xC979E4", Offset = "0xC979E4", VA = "0xC979E4")]
		public SetString()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics2D
{
	[Token(Token = "0x20001C4")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFEA0", Offset = "0x6DFEA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFEA0", Offset = "0x6DFEA0")]
	public class Circlecast : Action
	{
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEF20", Offset = "0x6EEF20")]
		public SharedGameObject originGameObject;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEF58", Offset = "0x6EEF58")]
		public SharedVector2 originPosition;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEF90", Offset = "0x6EEF90")]
		public SharedFloat radius;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EEFC8", Offset = "0x6EEFC8")]
		public SharedVector2 direction;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF000", Offset = "0x6EF000")]
		public SharedFloat distance;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF038", Offset = "0x6EF038")]
		public LayerMask layerMask;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF070", Offset = "0x6EF070")]
		public Space space;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF0A8", Offset = "0x6EF0A8")]
		public SharedGameObject storeHitObject;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF0F4", Offset = "0x6EF0F4")]
		public SharedVector2 storeHitPoint;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF140", Offset = "0x6EF140")]
		public SharedVector2 storeHitNormal;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF18C", Offset = "0x6EF18C")]
		[SharedRequired]
		public SharedFloat storeHitDistance;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1127D18", Offset = "0x1127D18", VA = "0x1127D18", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x11280C0", Offset = "0x11280C0", VA = "0x11280C0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1128178", Offset = "0x1128178", VA = "0x1128178")]
		public Circlecast()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFF00", Offset = "0x6DFF00")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFF00", Offset = "0x6DFF00")]
	public class Linecast : Action
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF1D8", Offset = "0x6EF1D8")]
		public SharedVector2 startPosition;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF210", Offset = "0x6EF210")]
		public SharedVector2 endPosition;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF248", Offset = "0x6EF248")]
		public LayerMask layerMask;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xFC64D8", Offset = "0xFC64D8", VA = "0xFC64D8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xFC65F4", Offset = "0xFC65F4", VA = "0xFC65F4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xFC6660", Offset = "0xFC6660", VA = "0xFC6660")]
		public Linecast()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFF60", Offset = "0x6DFF60")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFF60", Offset = "0x6DFF60")]
	public class Raycast : Action
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF280", Offset = "0x6EF280")]
		public SharedGameObject originGameObject;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF2B8", Offset = "0x6EF2B8")]
		public SharedVector2 originPosition;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF2F0", Offset = "0x6EF2F0")]
		public SharedVector2 direction;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF328", Offset = "0x6EF328")]
		public SharedFloat distance;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF360", Offset = "0x6EF360")]
		public LayerMask layerMask;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF398", Offset = "0x6EF398")]
		public Space space;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF3D0", Offset = "0x6EF3D0")]
		[SharedRequired]
		public SharedGameObject storeHitObject;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF41C", Offset = "0x6EF41C")]
		public SharedVector2 storeHitPoint;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF468", Offset = "0x6EF468")]
		[SharedRequired]
		public SharedVector2 storeHitNormal;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF4B4", Offset = "0x6EF4B4")]
		public SharedFloat storeHitDistance;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xFD0C64", Offset = "0xFD0C64", VA = "0xFD0C64", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xFD0FF4", Offset = "0xFD0FF4", VA = "0xFD0FF4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xFD1090", Offset = "0xFD1090", VA = "0xFD1090")]
		public Raycast()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics
{
	[Token(Token = "0x20001C7")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6DFFC0", Offset = "0x6DFFC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6DFFC0", Offset = "0x6DFFC0")]
	public class Linecast : Action
	{
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF500", Offset = "0x6EF500")]
		public SharedVector3 startPosition;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF538", Offset = "0x6EF538")]
		public SharedVector3 endPosition;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF570", Offset = "0x6EF570")]
		public LayerMask layerMask;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xFC6368", Offset = "0xFC6368", VA = "0xFC6368", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xFC6438", Offset = "0xFC6438", VA = "0xFC6438", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xFC64A4", Offset = "0xFC64A4", VA = "0xFC64A4")]
		public Linecast()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0020", Offset = "0x6E0020")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0020", Offset = "0x6E0020")]
	public class Raycast : Action
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF5A8", Offset = "0x6EF5A8")]
		public SharedGameObject originGameObject;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF5E0", Offset = "0x6EF5E0")]
		public SharedVector3 originPosition;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF618", Offset = "0x6EF618")]
		public SharedVector3 direction;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF650", Offset = "0x6EF650")]
		public SharedFloat distance;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF688", Offset = "0x6EF688")]
		public LayerMask layerMask;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF6C0", Offset = "0x6EF6C0")]
		public Space space;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF6F8", Offset = "0x6EF6F8")]
		[SharedRequired]
		public SharedGameObject storeHitObject;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF744", Offset = "0x6EF744")]
		[SharedRequired]
		public SharedVector3 storeHitPoint;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF790", Offset = "0x6EF790")]
		[SharedRequired]
		public SharedVector3 storeHitNormal;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF7DC", Offset = "0x6EF7DC")]
		public SharedFloat storeHitDistance;

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xFD0850", Offset = "0xFD0850", VA = "0xFD0850", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xFD0B74", Offset = "0xFD0B74", VA = "0xFD0B74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xFD0C10", Offset = "0xFD0C10", VA = "0xFD0C10")]
		public Raycast()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0080", Offset = "0x6E0080")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0080", Offset = "0x6E0080")]
	public class SphereCast : Action
	{
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF828", Offset = "0x6EF828")]
		public SharedGameObject originGameObject;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF860", Offset = "0x6EF860")]
		public SharedVector3 originPosition;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF898", Offset = "0x6EF898")]
		public SharedFloat radius;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF8D0", Offset = "0x6EF8D0")]
		public SharedVector3 direction;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF908", Offset = "0x6EF908")]
		public SharedFloat distance;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF940", Offset = "0x6EF940")]
		public LayerMask layerMask;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF978", Offset = "0x6EF978")]
		public Space space;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF9B0", Offset = "0x6EF9B0")]
		public SharedGameObject storeHitObject;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EF9FC", Offset = "0x6EF9FC")]
		[SharedRequired]
		public SharedVector3 storeHitPoint;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFA48", Offset = "0x6EFA48")]
		[SharedRequired]
		public SharedVector3 storeHitNormal;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFA94", Offset = "0x6EFA94")]
		public SharedFloat storeHitDistance;

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xC9F194", Offset = "0xC9F194", VA = "0xC9F194", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xC9F4D0", Offset = "0xC9F4D0", VA = "0xC9F4D0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xC9F578", Offset = "0xC9F578", VA = "0xC9F578")]
		public SphereCast()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	[Token(Token = "0x20001CA")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E00E0", Offset = "0x6E00E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E00E0", Offset = "0x6E00E0")]
	public class Clear : Action
	{
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFAE0", Offset = "0x6EFAE0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x112846C", Offset = "0x112846C", VA = "0x112846C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x112857C", Offset = "0x112857C", VA = "0x112857C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x112865C", Offset = "0x112865C", VA = "0x112865C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1128668", Offset = "0x1128668", VA = "0x1128668")]
		public Clear()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0140", Offset = "0x6E0140")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0140", Offset = "0x6E0140")]
	public class GetDuration : Action
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFB18", Offset = "0x6EFB18")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFB50", Offset = "0x6EFB50")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xCCC1B8", Offset = "0xCCC1B8", VA = "0xCCC1B8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xCCC2C8", Offset = "0xCCC2C8", VA = "0xCCC2C8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xCCC3EC", Offset = "0xCCC3EC", VA = "0xCCC3EC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xCCC430", Offset = "0xCCC430", VA = "0xCCC430")]
		public GetDuration()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E01A0", Offset = "0x6E01A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E01A0", Offset = "0x6E01A0")]
	public class GetEmissionRate : Action
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFB9C", Offset = "0x6EFB9C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFBD4", Offset = "0x6EFBD4")]
		public SharedFloat storeResult;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xCCC438", Offset = "0xCCC438", VA = "0xCCC438", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xCCC548", Offset = "0xCCC548", VA = "0xCCC548", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xCCC64C", Offset = "0xCCC64C", VA = "0xCCC64C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xCCC690", Offset = "0xCCC690", VA = "0xCCC690")]
		public GetEmissionRate()
		{
		}
	}
	[Token(Token = "0x20001CD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0200", Offset = "0x6E0200")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0200", Offset = "0x6E0200")]
	public class GetEnableEmission : Action
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFC20", Offset = "0x6EFC20")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFC58", Offset = "0x6EFC58")]
		public SharedBool storeResult;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xCCC698", Offset = "0xCCC698", VA = "0xCCC698", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xCCC7A8", Offset = "0xCCC7A8", VA = "0xCCC7A8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xCCC8D0", Offset = "0xCCC8D0", VA = "0xCCC8D0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xCCC914", Offset = "0xCCC914", VA = "0xCCC914")]
		public GetEnableEmission()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0260", Offset = "0x6E0260")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0260", Offset = "0x6E0260")]
	public class GetLoop : Action
	{
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFCA4", Offset = "0x6EFCA4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFCDC", Offset = "0x6EFCDC")]
		public SharedBool storeResult;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xCD08C8", Offset = "0xCD08C8", VA = "0xCD08C8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xCD09D8", Offset = "0xCD09D8", VA = "0xCD09D8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xCD0B00", Offset = "0xCD0B00", VA = "0xCD0B00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xCD0B44", Offset = "0xCD0B44", VA = "0xCD0B44")]
		public GetLoop()
		{
		}
	}
	[Token(Token = "0x20001CF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E02C0", Offset = "0x6E02C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E02C0", Offset = "0x6E02C0")]
	public class GetMaxParticles : Action
	{
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFD28", Offset = "0x6EFD28")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFD60", Offset = "0x6EFD60")]
		public SharedFloat storeResult;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xCD1478", Offset = "0xCD1478", VA = "0xCD1478", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xCD1588", Offset = "0xCD1588", VA = "0xCD1588", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xCD16B0", Offset = "0xCD16B0", VA = "0xCD16B0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xCD16F4", Offset = "0xCD16F4", VA = "0xCD16F4")]
		public GetMaxParticles()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0320", Offset = "0x6E0320")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0320", Offset = "0x6E0320")]
	public class GetParticleCount : Action
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFDAC", Offset = "0x6EFDAC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFDE4", Offset = "0x6EFDE4")]
		public SharedFloat storeResult;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xCD221C", Offset = "0xCD221C", VA = "0xCD221C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xCD232C", Offset = "0xCD232C", VA = "0xCD232C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xCD2438", Offset = "0xCD2438", VA = "0xCD2438", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xCD247C", Offset = "0xCD247C", VA = "0xCD247C")]
		public GetParticleCount()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0380", Offset = "0x6E0380")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0380", Offset = "0x6E0380")]
	public class GetPlaybackSpeed : Action
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFE30", Offset = "0x6EFE30")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFE68", Offset = "0x6EFE68")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xCD26E8", Offset = "0xCD26E8", VA = "0xCD26E8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xCD27F8", Offset = "0xCD27F8", VA = "0xCD27F8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xCD291C", Offset = "0xCD291C", VA = "0xCD291C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xCD2960", Offset = "0xCD2960", VA = "0xCD2960")]
		public GetPlaybackSpeed()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E03E0", Offset = "0x6E03E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E03E0", Offset = "0x6E03E0")]
	public class GetTime : Action
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFEB4", Offset = "0x6EFEB4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFEEC", Offset = "0x6EFEEC")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xCD72F4", Offset = "0xCD72F4", VA = "0xCD72F4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xCD7404", Offset = "0xCD7404", VA = "0xCD7404", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xCD750C", Offset = "0xCD750C", VA = "0xCD750C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xCD7550", Offset = "0xCD7550", VA = "0xCD7550")]
		public GetTime()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0440", Offset = "0x6E0440")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0440", Offset = "0x6E0440")]
	public class IsAlive : Conditional
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFF38", Offset = "0x6EFF38")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xFC0554", Offset = "0xFC0554", VA = "0xFC0554", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xFC0664", Offset = "0xFC0664", VA = "0xFC0664", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xFC074C", Offset = "0xFC074C", VA = "0xFC074C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xFC0758", Offset = "0xFC0758", VA = "0xFC0758")]
		public IsAlive()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E04A0", Offset = "0x6E04A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E04A0", Offset = "0x6E04A0")]
	public class IsPaused : Conditional
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFF70", Offset = "0x6EFF70")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xFC20AC", Offset = "0xFC20AC", VA = "0xFC20AC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xFC21BC", Offset = "0xFC21BC", VA = "0xFC21BC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xFC22A4", Offset = "0xFC22A4", VA = "0xFC22A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xFC22B0", Offset = "0xFC22B0", VA = "0xFC22B0")]
		public IsPaused()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0500", Offset = "0x6E0500")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0500", Offset = "0x6E0500")]
	public class IsPlaying : Conditional
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFFA8", Offset = "0x6EFFA8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xFC29B0", Offset = "0xFC29B0", VA = "0xFC29B0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xFC2AC0", Offset = "0xFC2AC0", VA = "0xFC2AC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xFC2BA8", Offset = "0xFC2BA8", VA = "0xFC2BA8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xFC2BB4", Offset = "0xFC2BB4", VA = "0xFC2BB4")]
		public IsPlaying()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0560", Offset = "0x6E0560")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0560", Offset = "0x6E0560")]
	public class IsStopped : Conditional
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EFFE0", Offset = "0x6EFFE0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xFC31E8", Offset = "0xFC31E8", VA = "0xFC31E8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFC32F8", Offset = "0xFC32F8", VA = "0xFC32F8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xFC33E0", Offset = "0xFC33E0", VA = "0xFC33E0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xFC33EC", Offset = "0xFC33EC", VA = "0xFC33EC")]
		public IsStopped()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E05C0", Offset = "0x6E05C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E05C0", Offset = "0x6E05C0")]
	public class Pause : Action
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0018", Offset = "0x6F0018")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xFCD13C", Offset = "0xFCD13C", VA = "0xFCD13C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFCD24C", Offset = "0xFCD24C", VA = "0xFCD24C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFCD32C", Offset = "0xFCD32C", VA = "0xFCD32C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFCD338", Offset = "0xFCD338", VA = "0xFCD338")]
		public Pause()
		{
		}
	}
	[Token(Token = "0x20001D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0620", Offset = "0x6E0620")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0620", Offset = "0x6E0620")]
	public class Play : Action
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0050", Offset = "0x6F0050")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xFCDF00", Offset = "0xFCDF00", VA = "0xFCDF00", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xFCE010", Offset = "0xFCE010", VA = "0xFCE010", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xFCE0F0", Offset = "0xFCE0F0", VA = "0xFCE0F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFCE0FC", Offset = "0xFCE0FC", VA = "0xFCE0FC")]
		public Play()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0680", Offset = "0x6E0680")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0680", Offset = "0x6E0680")]
	public class SetEmissionRate : Action
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0088", Offset = "0x6F0088")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F00C0", Offset = "0x6F00C0")]
		public SharedFloat emissionRate;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xC8B638", Offset = "0xC8B638", VA = "0xC8B638", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xC8B748", Offset = "0xC8B748", VA = "0xC8B748", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xC8B84C", Offset = "0xC8B84C", VA = "0xC8B84C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xC8B88C", Offset = "0xC8B88C", VA = "0xC8B88C")]
		public SetEmissionRate()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E06E0", Offset = "0x6E06E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E06E0", Offset = "0x6E06E0")]
	public class SetEnableEmission : Action
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F00F8", Offset = "0x6F00F8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0130", Offset = "0x6F0130")]
		public SharedBool enable;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xC8B894", Offset = "0xC8B894", VA = "0xC8B894", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xC8B9A4", Offset = "0xC8B9A4", VA = "0xC8B9A4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xC8BAC8", Offset = "0xC8BAC8", VA = "0xC8BAC8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xC8BB08", Offset = "0xC8BB08", VA = "0xC8BB08")]
		public SetEnableEmission()
		{
		}
	}
	[Token(Token = "0x20001DB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0740", Offset = "0x6E0740")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0740", Offset = "0x6E0740")]
	public class SetLoop : Action
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0168", Offset = "0x6F0168")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F01A0", Offset = "0x6F01A0")]
		public SharedBool loop;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xC8FDD8", Offset = "0xC8FDD8", VA = "0xC8FDD8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xC8FEE8", Offset = "0xC8FEE8", VA = "0xC8FEE8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xC9000C", Offset = "0xC9000C", VA = "0xC9000C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xC9004C", Offset = "0xC9004C", VA = "0xC9004C")]
		public SetLoop()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E07A0", Offset = "0x6E07A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E07A0", Offset = "0x6E07A0")]
	public class SetMaxParticles : Action
	{
		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F01D8", Offset = "0x6F01D8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0210", Offset = "0x6F0210")]
		public SharedInt maxParticles;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xC909CC", Offset = "0xC909CC", VA = "0xC909CC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xC90ADC", Offset = "0xC90ADC", VA = "0xC90ADC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xC90C00", Offset = "0xC90C00", VA = "0xC90C00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xC90C40", Offset = "0xC90C40", VA = "0xC90C40")]
		public SetMaxParticles()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0800", Offset = "0x6E0800")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0800", Offset = "0x6E0800")]
	public class SetPlaybackSpeed : Action
	{
		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0248", Offset = "0x6F0248")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0280", Offset = "0x6F0280")]
		public SharedFloat playbackSpeed;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC91828", Offset = "0xC91828", VA = "0xC91828", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC91938", Offset = "0xC91938", VA = "0xC91938", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xC91A58", Offset = "0xC91A58", VA = "0xC91A58", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xC91A98", Offset = "0xC91A98", VA = "0xC91A98")]
		public SetPlaybackSpeed()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0860", Offset = "0x6E0860")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0860", Offset = "0x6E0860")]
	public class SetStartColor : Action
	{
		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F02B8", Offset = "0x6F02B8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F02F0", Offset = "0x6F02F0")]
		public SharedColor startColor;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xC96708", Offset = "0xC96708", VA = "0xC96708", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xC96818", Offset = "0xC96818", VA = "0xC96818", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xC96960", Offset = "0xC96960", VA = "0xC96960", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xC969A4", Offset = "0xC969A4", VA = "0xC969A4")]
		public SetStartColor()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E08C0", Offset = "0x6E08C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E08C0", Offset = "0x6E08C0")]
	public class SetStartDelay : Action
	{
		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0328", Offset = "0x6F0328")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0360", Offset = "0x6F0360")]
		public SharedFloat startDelay;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xC969AC", Offset = "0xC969AC", VA = "0xC969AC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xC96ABC", Offset = "0xC96ABC", VA = "0xC96ABC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xC96BF8", Offset = "0xC96BF8", VA = "0xC96BF8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xC96C38", Offset = "0xC96C38", VA = "0xC96C38")]
		public SetStartDelay()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0920", Offset = "0x6E0920")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0920", Offset = "0x6E0920")]
	public class SetStartLifetime : Action
	{
		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0398", Offset = "0x6F0398")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F03D0", Offset = "0x6F03D0")]
		public SharedFloat startLifetime;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xC96C40", Offset = "0xC96C40", VA = "0xC96C40", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xC96D50", Offset = "0xC96D50", VA = "0xC96D50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xC96E8C", Offset = "0xC96E8C", VA = "0xC96E8C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xC96ECC", Offset = "0xC96ECC", VA = "0xC96ECC")]
		public SetStartLifetime()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0980", Offset = "0x6E0980")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0980", Offset = "0x6E0980")]
	public class SetStartRotation : Action
	{
		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0408", Offset = "0x6F0408")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0440", Offset = "0x6F0440")]
		public SharedFloat startRotation;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xC96ED4", Offset = "0xC96ED4", VA = "0xC96ED4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xC96FE4", Offset = "0xC96FE4", VA = "0xC96FE4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xC97120", Offset = "0xC97120", VA = "0xC97120", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xC97160", Offset = "0xC97160", VA = "0xC97160")]
		public SetStartRotation()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E09E0", Offset = "0x6E09E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E09E0", Offset = "0x6E09E0")]
	public class SetStartSize : Action
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0478", Offset = "0x6F0478")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F04B0", Offset = "0x6F04B0")]
		public SharedFloat startSize;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xC97168", Offset = "0xC97168", VA = "0xC97168", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xC97278", Offset = "0xC97278", VA = "0xC97278", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xC973B4", Offset = "0xC973B4", VA = "0xC973B4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xC973F4", Offset = "0xC973F4", VA = "0xC973F4")]
		public SetStartSize()
		{
		}
	}
	[Token(Token = "0x20001E3")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0A40", Offset = "0x6E0A40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0A40", Offset = "0x6E0A40")]
	public class SetStartSpeed : Action
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F04E8", Offset = "0x6F04E8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0520", Offset = "0x6F0520")]
		public SharedFloat startSpeed;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xC973FC", Offset = "0xC973FC", VA = "0xC973FC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xC9750C", Offset = "0xC9750C", VA = "0xC9750C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xC97648", Offset = "0xC97648", VA = "0xC97648", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xC97688", Offset = "0xC97688", VA = "0xC97688")]
		public SetStartSpeed()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0AA0", Offset = "0x6E0AA0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0AA0", Offset = "0x6E0AA0")]
	public class SetTime : Action
	{
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0558", Offset = "0x6F0558")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0590", Offset = "0x6F0590")]
		public SharedFloat time;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xC97E68", Offset = "0xC97E68", VA = "0xC97E68", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xC97F78", Offset = "0xC97F78", VA = "0xC97F78", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xC98080", Offset = "0xC98080", VA = "0xC98080", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xC980C0", Offset = "0xC980C0", VA = "0xC980C0")]
		public SetTime()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0B00", Offset = "0x6E0B00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0B00", Offset = "0x6E0B00")]
	public class Simulate : Action
	{
		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F05C8", Offset = "0x6F05C8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0600", Offset = "0x6F0600")]
		public SharedFloat time;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xC9B240", Offset = "0xC9B240", VA = "0xC9B240", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xC9B350", Offset = "0xC9B350", VA = "0xC9B350", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xC9B458", Offset = "0xC9B458", VA = "0xC9B458", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xC9B498", Offset = "0xC9B498", VA = "0xC9B498")]
		public Simulate()
		{
		}
	}
	[Token(Token = "0x20001E6")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0B60", Offset = "0x6E0B60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0B60", Offset = "0x6E0B60")]
	public class Stop : Action
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0638", Offset = "0x6F0638")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xCA1B38", Offset = "0xCA1B38", VA = "0xCA1B38", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xCA1C48", Offset = "0xCA1C48", VA = "0xCA1C48", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xCA1D28", Offset = "0xCA1D28", VA = "0xCA1D28", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xCA1D34", Offset = "0xCA1D34", VA = "0xCA1D34")]
		public Stop()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	[Token(Token = "0x20001E7")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0BC0", Offset = "0x6E0BC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0BC0", Offset = "0x6E0BC0")]
	public class GetAcceleration : Action
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0670", Offset = "0x6F0670")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F06A8", Offset = "0x6F06A8")]
		public SharedFloat storeValue;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xCC7CFC", Offset = "0xCC7CFC", VA = "0xCC7CFC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xCC7E0C", Offset = "0xCC7E0C", VA = "0xCC7E0C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xCC7F14", Offset = "0xCC7F14", VA = "0xCC7F14", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xCC7F58", Offset = "0xCC7F58", VA = "0xCC7F58")]
		public GetAcceleration()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0C20", Offset = "0x6E0C20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0C20", Offset = "0x6E0C20")]
	public class GetAngularSpeed : Action
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F06F4", Offset = "0x6F06F4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F072C", Offset = "0x6F072C")]
		public SharedFloat storeValue;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xCC8874", Offset = "0xCC8874", VA = "0xCC8874", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xCC8984", Offset = "0xCC8984", VA = "0xCC8984", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xCC8A8C", Offset = "0xCC8A8C", VA = "0xCC8A8C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xCC8AD0", Offset = "0xCC8AD0", VA = "0xCC8AD0")]
		public GetAngularSpeed()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0C80", Offset = "0x6E0C80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0C80", Offset = "0x6E0C80")]
	public class GetDestination : Action
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0778", Offset = "0x6F0778")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F07B0", Offset = "0x6F07B0")]
		public SharedVector3 storeValue;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xCCB820", Offset = "0xCCB820", VA = "0xCCB820", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xCCB930", Offset = "0xCCB930", VA = "0xCCB930", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xCCBA38", Offset = "0xCCBA38", VA = "0xCCBA38", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xCCBA80", Offset = "0xCCBA80", VA = "0xCCBA80")]
		public GetDestination()
		{
		}
	}
	[Token(Token = "0x20001EA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0CE0", Offset = "0x6E0CE0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0CE0", Offset = "0x6E0CE0")]
	public class GetIsStopped : Action
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F07FC", Offset = "0x6F07FC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0834", Offset = "0x6F0834")]
		public SharedBool storeValue;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xCCF4E4", Offset = "0xCCF4E4", VA = "0xCCF4E4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xCCF5F4", Offset = "0xCCF5F4", VA = "0xCCF5F4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xCCF700", Offset = "0xCCF700", VA = "0xCCF700", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xCCF734", Offset = "0xCCF734", VA = "0xCCF734")]
		public GetIsStopped()
		{
		}
	}
	[Token(Token = "0x20001EB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0D40", Offset = "0x6E0D40")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0D40", Offset = "0x6E0D40")]
	public class GetRemainingDistance : Action
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0880", Offset = "0x6F0880")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F08B8", Offset = "0x6F08B8")]
		[SharedRequired]
		public SharedFloat storeValue;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xCD43CC", Offset = "0xCD43CC", VA = "0xCD43CC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xCD44DC", Offset = "0xCD44DC", VA = "0xCD44DC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xCD45E4", Offset = "0xCD45E4", VA = "0xCD45E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xCD4628", Offset = "0xCD4628", VA = "0xCD4628")]
		public GetRemainingDistance()
		{
		}
	}
	[Token(Token = "0x20001EC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0DA0", Offset = "0x6E0DA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0DA0", Offset = "0x6E0DA0")]
	public class GetSpeed : Action
	{
		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0904", Offset = "0x6F0904")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F093C", Offset = "0x6F093C")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xCD5F5C", Offset = "0xCD5F5C", VA = "0xCD5F5C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xCD606C", Offset = "0xCD606C", VA = "0xCD606C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xCD6174", Offset = "0xCD6174", VA = "0xCD6174", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xCD61B8", Offset = "0xCD61B8", VA = "0xCD61B8")]
		public GetSpeed()
		{
		}
	}
	[Token(Token = "0x20001ED")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0E00", Offset = "0x6E0E00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0E00", Offset = "0x6E0E00")]
	public class IsStopped : Conditional
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0988", Offset = "0x6F0988")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xFC2FDC", Offset = "0xFC2FDC", VA = "0xFC2FDC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xFC30EC", Offset = "0xFC30EC", VA = "0xFC30EC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xFC31D4", Offset = "0xFC31D4", VA = "0xFC31D4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xFC31E0", Offset = "0xFC31E0", VA = "0xFC31E0")]
		public IsStopped()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0E60", Offset = "0x6E0E60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0E60", Offset = "0x6E0E60")]
	public class Move : Action
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F09C0", Offset = "0x6F09C0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F09F8", Offset = "0x6F09F8")]
		public SharedVector3 offset;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xFC78EC", Offset = "0xFC78EC", VA = "0xFC78EC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xFC79FC", Offset = "0xFC79FC", VA = "0xFC79FC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xFC7B04", Offset = "0xFC7B04", VA = "0xFC7B04", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xFC7B4C", Offset = "0xFC7B4C", VA = "0xFC7B4C")]
		public Move()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0EC0", Offset = "0x6E0EC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0EC0", Offset = "0x6E0EC0")]
	public class ResetPath : Action
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0A30", Offset = "0x6F0A30")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xFD13F4", Offset = "0xFD13F4", VA = "0xFD13F4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xFD1504", Offset = "0xFD1504", VA = "0xFD1504", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xFD15E4", Offset = "0xFD15E4", VA = "0xFD15E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xFD15F0", Offset = "0xFD15F0", VA = "0xFD15F0")]
		public ResetPath()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0F20", Offset = "0x6E0F20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0F20", Offset = "0x6E0F20")]
	public class Resume : Action
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0A68", Offset = "0x6F0A68")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xFD1B1C", Offset = "0xFD1B1C", VA = "0xFD1B1C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xFD1C2C", Offset = "0xFD1C2C", VA = "0xFD1C2C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xFD1D10", Offset = "0xFD1D10", VA = "0xFD1D10", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xFD1D1C", Offset = "0xFD1D1C", VA = "0xFD1D1C")]
		public Resume()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0F80", Offset = "0x6E0F80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0F80", Offset = "0x6E0F80")]
	public class SetAcceleration : Action
	{
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0AA0", Offset = "0x6F0AA0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0AD8", Offset = "0x6F0AD8")]
		public SharedFloat acceleration;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xFD4660", Offset = "0xFD4660", VA = "0xFD4660", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xFD4770", Offset = "0xFD4770", VA = "0xFD4770", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xFD4878", Offset = "0xFD4878", VA = "0xFD4878", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xFD48BC", Offset = "0xFD48BC", VA = "0xFD48BC")]
		public SetAcceleration()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E0FE0", Offset = "0x6E0FE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E0FE0", Offset = "0x6E0FE0")]
	public class SetAngularSpeed : Action
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0B10", Offset = "0x6F0B10")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0B48", Offset = "0x6F0B48")]
		public SharedFloat angularSpeed;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xFD4E84", Offset = "0xFD4E84", VA = "0xFD4E84", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xFD4F94", Offset = "0xFD4F94", VA = "0xFD4F94", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xFD509C", Offset = "0xFD509C", VA = "0xFD509C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xFD50E0", Offset = "0xFD50E0", VA = "0xFD50E0")]
		public SetAngularSpeed()
		{
		}
	}
	[Token(Token = "0x20001F3")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1040", Offset = "0x6E1040")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1040", Offset = "0x6E1040")]
	public class SetDestination : Action
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0B80", Offset = "0x6F0B80")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SharedRequired]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0BB8", Offset = "0x6F0BB8")]
		public SharedVector3 destination;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xC8AC44", Offset = "0xC8AC44", VA = "0xC8AC44", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xC8AD54", Offset = "0xC8AD54", VA = "0xC8AD54", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xC8AE64", Offset = "0xC8AE64", VA = "0xC8AE64", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xC8AEA8", Offset = "0xC8AEA8", VA = "0xC8AEA8")]
		public SetDestination()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E10A0", Offset = "0x6E10A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E10A0", Offset = "0x6E10A0")]
	public class SetIsStopped : Action
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0C04", Offset = "0x6F0C04")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0C3C", Offset = "0x6F0C3C")]
		public SharedBool isStopped;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xC8E684", Offset = "0xC8E684", VA = "0xC8E684", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xC8E794", Offset = "0xC8E794", VA = "0xC8E794", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xC8E8A0", Offset = "0xC8E8A0", VA = "0xC8E8A0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xC8E8AC", Offset = "0xC8E8AC", VA = "0xC8E8AC")]
		public SetIsStopped()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1100", Offset = "0x6E1100")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1100", Offset = "0x6E1100")]
	public class SetSpeed : Action
	{
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0C74", Offset = "0x6F0C74")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0CAC", Offset = "0x6F0CAC")]
		public SharedFloat speed;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xC95FE8", Offset = "0xC95FE8", VA = "0xC95FE8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xC960F8", Offset = "0xC960F8", VA = "0xC960F8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xC96200", Offset = "0xC96200", VA = "0xC96200", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xC96240", Offset = "0xC96240", VA = "0xC96240")]
		public SetSpeed()
		{
		}
	}
	[Token(Token = "0x20001F6")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1160", Offset = "0x6E1160")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1160", Offset = "0x6E1160")]
	public class Stop : Action
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0CE4", Offset = "0x6F0CE4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xCA1930", Offset = "0xCA1930", VA = "0xCA1930", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xCA1A40", Offset = "0xCA1A40", VA = "0xCA1A40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xCA1B24", Offset = "0xCA1B24", VA = "0xCA1B24", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xCA1B30", Offset = "0xCA1B30", VA = "0xCA1B30")]
		public Stop()
		{
		}
	}
	[Token(Token = "0x20001F7")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E11C0", Offset = "0x6E11C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E11C0", Offset = "0x6E11C0")]
	public class Warp : Action
	{
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0D1C", Offset = "0x6F0D1C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0D54", Offset = "0x6F0D54")]
		public SharedVector3 newPosition;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x18DCB2C", Offset = "0x18DCB2C", VA = "0x18DCB2C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x18DCC3C", Offset = "0x18DCC3C", VA = "0x18DCC3C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x18DCD44", Offset = "0x18DCD44", VA = "0x18DCD44", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x18DCD8C", Offset = "0x18DCD8C", VA = "0x18DCD8C")]
		public Warp()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	[Token(Token = "0x20001F8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1220", Offset = "0x6E1220")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1220", Offset = "0x6E1220")]
	public class BoolComparison : Conditional
	{
		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0D8C", Offset = "0x6F0D8C")]
		public SharedBool bool1;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0DC4", Offset = "0x6F0DC4")]
		public SharedBool bool2;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x111DF44", Offset = "0x111DF44", VA = "0x111DF44", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x111DFC4", Offset = "0x111DFC4", VA = "0x111DFC4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x111E014", Offset = "0x111E014", VA = "0x111E014")]
		public BoolComparison()
		{
		}
	}
	[Token(Token = "0x20001F9")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1280", Offset = "0x6E1280")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1280", Offset = "0x6E1280")]
	public class BoolFlip : Action
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0DFC", Offset = "0x6F0DFC")]
		public SharedBool boolVariable;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x111E01C", Offset = "0x111E01C", VA = "0x111E01C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x111E0A4", Offset = "0x111E0A4", VA = "0x111E0A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x111E0FC", Offset = "0x111E0FC", VA = "0x111E0FC")]
		public BoolFlip()
		{
		}
	}
	[Token(Token = "0x20001FA")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E12E0", Offset = "0x6E12E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E12E0", Offset = "0x6E12E0")]
	public class BoolOperator : Action
	{
		[Token(Token = "0x20001FB")]
		public enum Operation
		{
			[Token(Token = "0x4000632")]
			AND,
			[Token(Token = "0x4000633")]
			OR,
			[Token(Token = "0x4000634")]
			NAND,
			[Token(Token = "0x4000635")]
			XOR
		}

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0E34", Offset = "0x6F0E34")]
		public Operation operation;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0E6C", Offset = "0x6F0E6C")]
		public SharedBool bool1;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0EA4", Offset = "0x6F0EA4")]
		public SharedBool bool2;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0EDC", Offset = "0x6F0EDC")]
		public SharedBool storeResult;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x111E104", Offset = "0x111E104", VA = "0x111E104", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x111E2A4", Offset = "0x111E2A4", VA = "0x111E2A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x111E2F8", Offset = "0x111E2F8", VA = "0x111E2F8")]
		public BoolOperator()
		{
		}
	}
	[Token(Token = "0x20001FC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1340", Offset = "0x6E1340")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1340", Offset = "0x6E1340")]
	public class FloatAbs : Action
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0F14", Offset = "0x6F0F14")]
		public SharedFloat floatVariable;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xCC49DC", Offset = "0xCC49DC", VA = "0xCC49DC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xCC4A60", Offset = "0xCC4A60", VA = "0xCC4A60", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xCC4A94", Offset = "0xCC4A94", VA = "0xCC4A94")]
		public FloatAbs()
		{
		}
	}
	[Token(Token = "0x20001FD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E13A0", Offset = "0x6E13A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E13A0", Offset = "0x6E13A0")]
	public class FloatClamp : Action
	{
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0F4C", Offset = "0x6F0F4C")]
		public SharedFloat floatVariable;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0F84", Offset = "0x6F0F84")]
		public SharedFloat minValue;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0FBC", Offset = "0x6F0FBC")]
		public SharedFloat maxValue;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xCC4A9C", Offset = "0xCC4A9C", VA = "0xCC4A9C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xCC4B68", Offset = "0xCC4B68", VA = "0xCC4B68", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xCC4BD4", Offset = "0xCC4BD4", VA = "0xCC4BD4")]
		public FloatClamp()
		{
		}
	}
	[Token(Token = "0x20001FE")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1400", Offset = "0x6E1400")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1400", Offset = "0x6E1400")]
	public class FloatComparison : Conditional
	{
		[Token(Token = "0x20001FF")]
		public enum Operation
		{
			[Token(Token = "0x400063E")]
			LessThan,
			[Token(Token = "0x400063F")]
			LessThanOrEqualTo,
			[Token(Token = "0x4000640")]
			EqualTo,
			[Token(Token = "0x4000641")]
			NotEqualTo,
			[Token(Token = "0x4000642")]
			GreaterThanOrEqualTo,
			[Token(Token = "0x4000643")]
			GreaterThan
		}

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F0FF4", Offset = "0x6F0FF4")]
		public Operation operation;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F102C", Offset = "0x6F102C")]
		public SharedFloat float1;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1064", Offset = "0x6F1064")]
		public SharedFloat float2;

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xCC4BDC", Offset = "0xCC4BDC", VA = "0xCC4BDC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xCC4DD0", Offset = "0xCC4DD0", VA = "0xCC4DD0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xCC4E40", Offset = "0xCC4E40", VA = "0xCC4E40")]
		public FloatComparison()
		{
		}
	}
	[Token(Token = "0x2000200")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1460", Offset = "0x6E1460")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1460", Offset = "0x6E1460")]
	public class FloatOperator : Action
	{
		[Token(Token = "0x2000201")]
		public enum Operation
		{
			[Token(Token = "0x4000649")]
			Add,
			[Token(Token = "0x400064A")]
			Subtract,
			[Token(Token = "0x400064B")]
			Multiply,
			[Token(Token = "0x400064C")]
			Divide,
			[Token(Token = "0x400064D")]
			Min,
			[Token(Token = "0x400064E")]
			Max,
			[Token(Token = "0x400064F")]
			Modulo
		}

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F109C", Offset = "0x6F109C")]
		public Operation operation;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F10D4", Offset = "0x6F10D4")]
		public SharedFloat float1;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F110C", Offset = "0x6F110C")]
		public SharedFloat float2;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1144", Offset = "0x6F1144")]
		public SharedFloat storeResult;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xCC4E48", Offset = "0xCC4E48", VA = "0xCC4E48", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xCC50BC", Offset = "0xCC50BC", VA = "0xCC50BC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xCC512C", Offset = "0xCC512C", VA = "0xCC512C")]
		public FloatOperator()
		{
		}
	}
	[Token(Token = "0x2000202")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E14C0", Offset = "0x6E14C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E14C0", Offset = "0x6E14C0")]
	public class IntAbs : Action
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F117C", Offset = "0x6F117C")]
		public SharedInt intVariable;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xFBF330", Offset = "0xFBF330", VA = "0xFBF330", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xFBF3BC", Offset = "0xFBF3BC", VA = "0xFBF3BC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xFBF3F0", Offset = "0xFBF3F0", VA = "0xFBF3F0")]
		public IntAbs()
		{
		}
	}
	[Token(Token = "0x2000203")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1520", Offset = "0x6E1520")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1520", Offset = "0x6E1520")]
	public class IntClamp : Action
	{
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F11B4", Offset = "0x6F11B4")]
		public SharedInt intVariable;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F11EC", Offset = "0x6F11EC")]
		public SharedInt minValue;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1224", Offset = "0x6F1224")]
		public SharedInt maxValue;

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xFBF3F8", Offset = "0xFBF3F8", VA = "0xFBF3F8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xFBF4C8", Offset = "0xFBF4C8", VA = "0xFBF4C8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xFBF534", Offset = "0xFBF534", VA = "0xFBF534")]
		public IntClamp()
		{
		}
	}
	[Token(Token = "0x2000204")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1580", Offset = "0x6E1580")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1580", Offset = "0x6E1580")]
	public class IntComparison : Conditional
	{
		[Token(Token = "0x2000205")]
		public enum Operation
		{
			[Token(Token = "0x4000658")]
			LessThan,
			[Token(Token = "0x4000659")]
			LessThanOrEqualTo,
			[Token(Token = "0x400065A")]
			EqualTo,
			[Token(Token = "0x400065B")]
			NotEqualTo,
			[Token(Token = "0x400065C")]
			GreaterThanOrEqualTo,
			[Token(Token = "0x400065D")]
			GreaterThan
		}

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F125C", Offset = "0x6F125C")]
		public Operation operation;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1294", Offset = "0x6F1294")]
		public SharedInt integer1;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F12CC", Offset = "0x6F12CC")]
		public SharedInt integer2;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xFBF53C", Offset = "0xFBF53C", VA = "0xFBF53C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xFBF720", Offset = "0xFBF720", VA = "0xFBF720", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xFBF790", Offset = "0xFBF790", VA = "0xFBF790")]
		public IntComparison()
		{
		}
	}
	[Token(Token = "0x2000206")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E15E0", Offset = "0x6E15E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E15E0", Offset = "0x6E15E0")]
	public class IntOperator : Action
	{
		[Token(Token = "0x2000207")]
		public enum Operation
		{
			[Token(Token = "0x4000663")]
			Add,
			[Token(Token = "0x4000664")]
			Subtract,
			[Token(Token = "0x4000665")]
			Multiply,
			[Token(Token = "0x4000666")]
			Divide,
			[Token(Token = "0x4000667")]
			Min,
			[Token(Token = "0x4000668")]
			Max,
			[Token(Token = "0x4000669")]
			Modulo
		}

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1304", Offset = "0x6F1304")]
		public Operation operation;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F133C", Offset = "0x6F133C")]
		public SharedInt integer1;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1374", Offset = "0x6F1374")]
		public SharedInt integer2;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F13AC", Offset = "0x6F13AC")]
		[RequiredField]
		public SharedInt storeResult;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xFBF798", Offset = "0xFBF798", VA = "0xFBF798", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xFBFA2C", Offset = "0xFBFA2C", VA = "0xFBFA2C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xFBFA9C", Offset = "0xFBFA9C", VA = "0xFBFA9C")]
		public IntOperator()
		{
		}
	}
	[Token(Token = "0x2000208")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1640", Offset = "0x6E1640")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1640", Offset = "0x6E1640")]
	public class IsFloatPositive : Conditional
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F13F8", Offset = "0x6F13F8")]
		public SharedFloat floatVariable;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xFC0C90", Offset = "0xFC0C90", VA = "0xFC0C90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xFC0CF4", Offset = "0xFC0CF4", VA = "0xFC0CF4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xFC0D28", Offset = "0xFC0D28", VA = "0xFC0D28")]
		public IsFloatPositive()
		{
		}
	}
	[Token(Token = "0x2000209")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E16A0", Offset = "0x6E16A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E16A0", Offset = "0x6E16A0")]
	public class IsIntPositive : Conditional
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1430", Offset = "0x6F1430")]
		public SharedInt intVariable;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xFC11AC", Offset = "0xFC11AC", VA = "0xFC11AC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xFC1210", Offset = "0xFC1210", VA = "0xFC1210", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xFC1244", Offset = "0xFC1244", VA = "0xFC1244")]
		public IsIntPositive()
		{
		}
	}
	[Token(Token = "0x200020A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1700", Offset = "0x6E1700")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1700", Offset = "0x6E1700")]
	public class Lerp : Action
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1468", Offset = "0x6F1468")]
		public SharedFloat fromValue;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F14A0", Offset = "0x6F14A0")]
		public SharedFloat toValue;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F14D8", Offset = "0x6F14D8")]
		public SharedFloat lerpAmount;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1510", Offset = "0x6F1510")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xFC48C0", Offset = "0xFC48C0", VA = "0xFC48C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xFC4990", Offset = "0xFC4990", VA = "0xFC4990", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xFC4A18", Offset = "0xFC4A18", VA = "0xFC4A18")]
		public Lerp()
		{
		}
	}
	[Token(Token = "0x200020B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1760", Offset = "0x6E1760")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1760", Offset = "0x6E1760")]
	public class LerpAngle : Action
	{
		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F155C", Offset = "0x6F155C")]
		public SharedFloat fromValue;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1594", Offset = "0x6F1594")]
		public SharedFloat toValue;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F15CC", Offset = "0x6F15CC")]
		public SharedFloat lerpAmount;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1604", Offset = "0x6F1604")]
		public SharedFloat storeResult;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xFC4F14", Offset = "0xFC4F14", VA = "0xFC4F14", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xFC4FE4", Offset = "0xFC4FE4", VA = "0xFC4FE4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xFC506C", Offset = "0xFC506C", VA = "0xFC506C")]
		public LerpAngle()
		{
		}
	}
	[Token(Token = "0x200020C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E17C0", Offset = "0x6E17C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E17C0", Offset = "0x6E17C0")]
	public class RandomBool : Action
	{
		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1650", Offset = "0x6F1650")]
		public SharedBool storeResult;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xFCF970", Offset = "0xFCF970", VA = "0xFCF970", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xFCF9E4", Offset = "0xFCF9E4", VA = "0xFCF9E4")]
		public RandomBool()
		{
		}
	}
	[Token(Token = "0x200020D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1820", Offset = "0x6E1820")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1820", Offset = "0x6E1820")]
	public class RandomFloat : Action
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1688", Offset = "0x6F1688")]
		public SharedFloat min;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F16C0", Offset = "0x6F16C0")]
		public SharedFloat max;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F16F8", Offset = "0x6F16F8")]
		public bool inclusive;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1730", Offset = "0x6F1730")]
		public SharedFloat storeResult;

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xFCF9EC", Offset = "0xFCF9EC", VA = "0xFCF9EC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xFCFAB8", Offset = "0xFCFAB8", VA = "0xFCFAB8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xFCFB44", Offset = "0xFCFB44", VA = "0xFCFB44")]
		public RandomFloat()
		{
		}
	}
	[Token(Token = "0x200020E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1880", Offset = "0x6E1880")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1880", Offset = "0x6E1880")]
	public class RandomInt : Action
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1768", Offset = "0x6F1768")]
		public SharedInt min;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F17A0", Offset = "0x6F17A0")]
		public SharedInt max;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F17D8", Offset = "0x6F17D8")]
		public bool inclusive;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1810", Offset = "0x6F1810")]
		public SharedInt storeResult;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xFCFB4C", Offset = "0xFCFB4C", VA = "0xFCFB4C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xFCFC10", Offset = "0xFCFC10", VA = "0xFCFC10", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xFCFC9C", Offset = "0xFCFC9C", VA = "0xFCFC9C")]
		public RandomInt()
		{
		}
	}
	[Token(Token = "0x200020F")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E18E0", Offset = "0x6E18E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E18E0", Offset = "0x6E18E0")]
	public class SetBool : Action
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1848", Offset = "0x6F1848")]
		public SharedBool boolValue;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1880", Offset = "0x6F1880")]
		public SharedBool storeResult;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xC88E74", Offset = "0xC88E74", VA = "0xC88E74", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xC88EFC", Offset = "0xC88EFC", VA = "0xC88EFC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xC88F2C", Offset = "0xC88F2C", VA = "0xC88F2C")]
		public SetBool()
		{
		}
	}
	[Token(Token = "0x2000210")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1940", Offset = "0x6E1940")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1940", Offset = "0x6E1940")]
	public class SetFloat : Action
	{
		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F18B8", Offset = "0x6F18B8")]
		public SharedFloat floatValue;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F18F0", Offset = "0x6F18F0")]
		public SharedFloat storeResult;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xC8C384", Offset = "0xC8C384", VA = "0xC8C384", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xC8C408", Offset = "0xC8C408", VA = "0xC8C408", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xC8C450", Offset = "0xC8C450", VA = "0xC8C450")]
		public SetFloat()
		{
		}
	}
	[Token(Token = "0x2000211")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E19A0", Offset = "0x6E19A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E19A0", Offset = "0x6E19A0")]
	public class SetInt : Action
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1928", Offset = "0x6F1928")]
		public SharedInt intValue;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1960", Offset = "0x6F1960")]
		public SharedInt storeResult;

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xC8D9C4", Offset = "0xC8D9C4", VA = "0xC8D9C4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xC8DA4C", Offset = "0xC8DA4C", VA = "0xC8DA4C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xC8DA94", Offset = "0xC8DA94", VA = "0xC8DA94")]
		public SetInt()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	[Token(Token = "0x2000212")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1A00", Offset = "0x6E1A00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1A00", Offset = "0x6E1A00")]
	public class GetColor : Action
	{
		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1998", Offset = "0x6F1998")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F19D0", Offset = "0x6F19D0")]
		[RequiredField]
		public SharedColor storeValue;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xCCAC58", Offset = "0xCCAC58", VA = "0xCCAC58", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xCCAD68", Offset = "0xCCAD68", VA = "0xCCAD68", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xCCAE60", Offset = "0xCCAE60", VA = "0xCCAE60", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xCCAEA8", Offset = "0xCCAEA8", VA = "0xCCAEA8")]
		public GetColor()
		{
		}
	}
	[Token(Token = "0x2000213")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1A60", Offset = "0x6E1A60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1A60", Offset = "0x6E1A60")]
	public class GetCookieSize : Action
	{
		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1A1C", Offset = "0x6F1A1C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1A54", Offset = "0x6F1A54")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xCCB038", Offset = "0xCCB038", VA = "0xCCB038", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xCCB148", Offset = "0xCCB148", VA = "0xCCB148", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xCCB240", Offset = "0xCCB240", VA = "0xCCB240", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xCCB284", Offset = "0xCCB284", VA = "0xCCB284")]
		public GetCookieSize()
		{
		}
	}
	[Token(Token = "0x2000214")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1AC0", Offset = "0x6E1AC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1AC0", Offset = "0x6E1AC0")]
	public class GetIntensity : Action
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1AA0", Offset = "0x6F1AA0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1AD8", Offset = "0x6F1AD8")]
		public SharedFloat storeValue;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xCCEDC0", Offset = "0xCCEDC0", VA = "0xCCEDC0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xCCEED0", Offset = "0xCCEED0", VA = "0xCCEED0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xCCEFC8", Offset = "0xCCEFC8", VA = "0xCCEFC8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xCCF00C", Offset = "0xCCF00C", VA = "0xCCF00C")]
		public GetIntensity()
		{
		}
	}
	[Token(Token = "0x2000215")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1B20", Offset = "0x6E1B20")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1B20", Offset = "0x6E1B20")]
	public class GetRange : Action
	{
		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1B24", Offset = "0x6F1B24")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1B5C", Offset = "0x6F1B5C")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xCD40D4", Offset = "0xCD40D4", VA = "0xCD40D4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xCD41E4", Offset = "0xCD41E4", VA = "0xCD41E4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xCD42DC", Offset = "0xCD42DC", VA = "0xCD42DC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xCD4320", Offset = "0xCD4320", VA = "0xCD4320")]
		public GetRange()
		{
		}
	}
	[Token(Token = "0x2000216")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1B80", Offset = "0x6E1B80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1B80", Offset = "0x6E1B80")]
	public class GetShadowBias : Action
	{
		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1BA8", Offset = "0x6F1BA8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1BE0", Offset = "0x6F1BE0")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xCD511C", Offset = "0xCD511C", VA = "0xCD511C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xCD522C", Offset = "0xCD522C", VA = "0xCD522C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xCD5324", Offset = "0xCD5324", VA = "0xCD5324", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xCD5368", Offset = "0xCD5368", VA = "0xCD5368")]
		public GetShadowBias()
		{
		}
	}
	[Token(Token = "0x2000217")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1BE0", Offset = "0x6E1BE0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1BE0", Offset = "0x6E1BE0")]
	public class GetShadowStrength : Action
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1C2C", Offset = "0x6F1C2C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1C64", Offset = "0x6F1C64")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xCD5370", Offset = "0xCD5370", VA = "0xCD5370", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xCD5480", Offset = "0xCD5480", VA = "0xCD5480", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xCD5578", Offset = "0xCD5578", VA = "0xCD5578", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xCD55BC", Offset = "0xCD55BC", VA = "0xCD55BC")]
		public GetShadowStrength()
		{
		}
	}
	[Token(Token = "0x2000218")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1C40", Offset = "0x6E1C40")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1C40", Offset = "0x6E1C40")]
	public class GetSpotAngle : Action
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1CB0", Offset = "0x6F1CB0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1CE8", Offset = "0x6F1CE8")]
		public SharedFloat storeValue;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xCD61C0", Offset = "0xCD61C0", VA = "0xCD61C0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xCD62D0", Offset = "0xCD62D0", VA = "0xCD62D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xCD63C8", Offset = "0xCD63C8", VA = "0xCD63C8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xCD640C", Offset = "0xCD640C", VA = "0xCD640C")]
		public GetSpotAngle()
		{
		}
	}
	[Token(Token = "0x2000219")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1CA0", Offset = "0x6E1CA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1CA0", Offset = "0x6E1CA0")]
	public class SetColor : Action
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1D34", Offset = "0x6F1D34")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1D6C", Offset = "0x6F1D6C")]
		public SharedColor color;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xC89FCC", Offset = "0xC89FCC", VA = "0xC89FCC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xC8A0DC", Offset = "0xC8A0DC", VA = "0xC8A0DC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xC8A1E4", Offset = "0xC8A1E4", VA = "0xC8A1E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xC8A2AC", Offset = "0xC8A2AC", VA = "0xC8A2AC")]
		public SetColor()
		{
		}
	}
	[Token(Token = "0x200021A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1D00", Offset = "0x6E1D00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1D00", Offset = "0x6E1D00")]
	public class SetCookie : Action
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1DA4", Offset = "0x6F1DA4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1DDC", Offset = "0x6F1DDC")]
		public Texture2D cookie;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xC8A4E0", Offset = "0xC8A4E0", VA = "0xC8A4E0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xC8A5F0", Offset = "0xC8A5F0", VA = "0xC8A5F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xC8A6D4", Offset = "0xC8A6D4", VA = "0xC8A6D4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xC8A708", Offset = "0xC8A708", VA = "0xC8A708")]
		public SetCookie()
		{
		}
	}
	[Token(Token = "0x200021B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1D60", Offset = "0x6E1D60")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1D60", Offset = "0x6E1D60")]
	public class SetCookieSize : Action
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1E14", Offset = "0x6F1E14")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1E4C", Offset = "0x6F1E4C")]
		public SharedFloat cookieSize;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xC8A710", Offset = "0xC8A710", VA = "0xC8A710", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xC8A820", Offset = "0xC8A820", VA = "0xC8A820", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xC8A928", Offset = "0xC8A928", VA = "0xC8A928", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xC8A9F4", Offset = "0xC8A9F4", VA = "0xC8A9F4")]
		public SetCookieSize()
		{
		}
	}
	[Token(Token = "0x200021C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1DC0", Offset = "0x6E1DC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1DC0", Offset = "0x6E1DC0")]
	public class SetCullingMask : Action
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1E84", Offset = "0x6F1E84")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1EBC", Offset = "0x6F1EBC")]
		public LayerMask cullingMask;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xC8A9FC", Offset = "0xC8A9FC", VA = "0xC8A9FC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xC8AB0C", Offset = "0xC8AB0C", VA = "0xC8AB0C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xC8AC00", Offset = "0xC8AC00", VA = "0xC8AC00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xC8AC3C", Offset = "0xC8AC3C", VA = "0xC8AC3C")]
		public SetCullingMask()
		{
		}
	}
	[Token(Token = "0x200021D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1E20", Offset = "0x6E1E20")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1E20", Offset = "0x6E1E20")]
	public class SetIntensity : Action
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1EF4", Offset = "0x6F1EF4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1F2C", Offset = "0x6F1F2C")]
		public SharedFloat intensity;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xC8DF5C", Offset = "0xC8DF5C", VA = "0xC8DF5C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xC8E06C", Offset = "0xC8E06C", VA = "0xC8E06C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xC8E174", Offset = "0xC8E174", VA = "0xC8E174", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xC8E1B4", Offset = "0xC8E1B4", VA = "0xC8E1B4")]
		public SetIntensity()
		{
		}
	}
	[Token(Token = "0x200021E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1E80", Offset = "0x6E1E80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1E80", Offset = "0x6E1E80")]
	public class SetRange : Action
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1F64", Offset = "0x6F1F64")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1F9C", Offset = "0x6F1F9C")]
		public SharedFloat range;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xC92ECC", Offset = "0xC92ECC", VA = "0xC92ECC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xC92FDC", Offset = "0xC92FDC", VA = "0xC92FDC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xC930E4", Offset = "0xC930E4", VA = "0xC930E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xC93124", Offset = "0xC93124", VA = "0xC93124")]
		public SetRange()
		{
		}
	}
	[Token(Token = "0x200021F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1EE0", Offset = "0x6E1EE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1EE0", Offset = "0x6E1EE0")]
	public class SetShadowBias : Action
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F1FD4", Offset = "0x6F1FD4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F200C", Offset = "0x6F200C")]
		public SharedFloat shadowBias;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xC93FB4", Offset = "0xC93FB4", VA = "0xC93FB4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xC940C4", Offset = "0xC940C4", VA = "0xC940C4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xC941CC", Offset = "0xC941CC", VA = "0xC941CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xC9420C", Offset = "0xC9420C", VA = "0xC9420C")]
		public SetShadowBias()
		{
		}
	}
	[Token(Token = "0x2000220")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1F40", Offset = "0x6E1F40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1F40", Offset = "0x6E1F40")]
	public class SetShadowSoftnessStrength : Action
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2044", Offset = "0x6F2044")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F207C", Offset = "0x6F207C")]
		public SharedFloat shadowStrength;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xC94214", Offset = "0xC94214", VA = "0xC94214", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xC94324", Offset = "0xC94324", VA = "0xC94324", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xC9442C", Offset = "0xC9442C", VA = "0xC9442C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xC9446C", Offset = "0xC9446C", VA = "0xC9446C")]
		public SetShadowSoftnessStrength()
		{
		}
	}
	[Token(Token = "0x2000221")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E1FA0", Offset = "0x6E1FA0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E1FA0", Offset = "0x6E1FA0")]
	public class SetShadows : Action
	{
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F20B4", Offset = "0x6F20B4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F20EC", Offset = "0x6F20EC")]
		public LightShadows shadows;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xC94474", Offset = "0xC94474", VA = "0xC94474", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xC94584", Offset = "0xC94584", VA = "0xC94584", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xC94668", Offset = "0xC94668", VA = "0xC94668", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xC94674", Offset = "0xC94674", VA = "0xC94674")]
		public SetShadows()
		{
		}
	}
	[Token(Token = "0x2000222")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2000", Offset = "0x6E2000")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2000", Offset = "0x6E2000")]
	public class SetSpotAngle : Action
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2124", Offset = "0x6F2124")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F215C", Offset = "0x6F215C")]
		public SharedFloat spotAngle;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xC96248", Offset = "0xC96248", VA = "0xC96248", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xC96358", Offset = "0xC96358", VA = "0xC96358", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xC96460", Offset = "0xC96460", VA = "0xC96460", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xC964A0", Offset = "0xC964A0", VA = "0xC964A0")]
		public SetSpotAngle()
		{
		}
	}
	[Token(Token = "0x2000223")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2060", Offset = "0x6E2060")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2060", Offset = "0x6E2060")]
	public class SetType : Action
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2194", Offset = "0x6F2194")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F21CC", Offset = "0x6F21CC")]
		public LightType type;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light light;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xC98418", Offset = "0xC98418", VA = "0xC98418", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xC98528", Offset = "0xC98528", VA = "0xC98528", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xC9860C", Offset = "0xC9860C", VA = "0xC9860C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xC98618", Offset = "0xC98618", VA = "0xC98618")]
		public SetType()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLayerMask
{
	[Token(Token = "0x2000224")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E20C0", Offset = "0x6E20C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E20C0", Offset = "0x6E20C0")]
	public class GetLayer : Action
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2204", Offset = "0x6F2204")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F223C", Offset = "0x6F223C")]
		public SharedString storeResult;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xCCF7EC", Offset = "0xCCF7EC", VA = "0xCCF7EC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xCCF898", Offset = "0xCCF898", VA = "0xCCF898", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xCCF904", Offset = "0xCCF904", VA = "0xCCF904")]
		public GetLayer()
		{
		}
	}
	[Token(Token = "0x2000225")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2120", Offset = "0x6E2120")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2120", Offset = "0x6E2120")]
	public class SetLayer : Action
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2288", Offset = "0x6F2288")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F22C0", Offset = "0x6F22C0")]
		public SharedString layerName;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xC8E8B4", Offset = "0xC8E8B4", VA = "0xC8E8B4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xC8E968", Offset = "0xC8E968", VA = "0xC8E968", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xC8E9D0", Offset = "0xC8E9D0", VA = "0xC8E9D0")]
		public SetLayer()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	[Token(Token = "0x2000226")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2180", Offset = "0x6E2180")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2180", Offset = "0x6E2180")]
	public class GetAcceleration : Action
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F22F8", Offset = "0x6F22F8")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xCC7C54", Offset = "0xCC7C54", VA = "0xCC7C54", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xCC7CBC", Offset = "0xCC7CBC", VA = "0xCC7CBC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xCC7CF4", Offset = "0xCC7CF4", VA = "0xCC7CF4")]
		public GetAcceleration()
		{
		}
	}
	[Token(Token = "0x2000227")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E21E0", Offset = "0x6E21E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E21E0", Offset = "0x6E21E0")]
	public class GetAxis : Action
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2344", Offset = "0x6F2344")]
		public SharedString axisName;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F237C", Offset = "0x6F237C")]
		public SharedFloat multiplier;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F23B4", Offset = "0x6F23B4")]
		[RequiredField]
		public SharedFloat storeResult;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xCC9498", Offset = "0xCC9498", VA = "0xCC9498", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xCC956C", Offset = "0xCC956C", VA = "0xCC956C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xCC9600", Offset = "0xCC9600", VA = "0xCC9600")]
		public GetAxis()
		{
		}
	}
	[Token(Token = "0x2000228")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2240", Offset = "0x6E2240")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2240", Offset = "0x6E2240")]
	public class GetAxisRaw : Action
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2400", Offset = "0x6F2400")]
		public SharedString axisName;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2438", Offset = "0x6F2438")]
		public SharedFloat multiplier;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2470", Offset = "0x6F2470")]
		public SharedFloat storeResult;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xCC9608", Offset = "0xCC9608", VA = "0xCC9608", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xCC96DC", Offset = "0xCC96DC", VA = "0xCC96DC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xCC9770", Offset = "0xCC9770", VA = "0xCC9770")]
		public GetAxisRaw()
		{
		}
	}
	[Token(Token = "0x2000229")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E22A0", Offset = "0x6E22A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E22A0", Offset = "0x6E22A0")]
	public class GetButton : Action
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F24BC", Offset = "0x6F24BC")]
		public SharedString buttonName;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F24F4", Offset = "0x6F24F4")]
		[RequiredField]
		public SharedBool storeResult;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xCC9A4C", Offset = "0xCC9A4C", VA = "0xCC9A4C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xCC9ADC", Offset = "0xCC9ADC", VA = "0xCC9ADC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xCC9B54", Offset = "0xCC9B54", VA = "0xCC9B54")]
		public GetButton()
		{
		}
	}
	[Token(Token = "0x200022A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2300", Offset = "0x6E2300")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2300", Offset = "0x6E2300")]
	public class GetKey : Action
	{
		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2540", Offset = "0x6F2540")]
		public KeyCode key;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2578", Offset = "0x6F2578")]
		public SharedBool storeResult;

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xCCF73C", Offset = "0xCCF73C", VA = "0xCCF73C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xCCF7AC", Offset = "0xCCF7AC", VA = "0xCCF7AC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xCCF7E4", Offset = "0xCCF7E4", VA = "0xCCF7E4")]
		public GetKey()
		{
		}
	}
	[Token(Token = "0x200022B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2360", Offset = "0x6E2360")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2360", Offset = "0x6E2360")]
	public class GetMouseButton : Action
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F25C4", Offset = "0x6F25C4")]
		public SharedInt buttonIndex;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F25FC", Offset = "0x6F25FC")]
		[RequiredField]
		public SharedBool storeResult;

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xCD1960", Offset = "0xCD1960", VA = "0xCD1960", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xCD19F0", Offset = "0xCD19F0", VA = "0xCD19F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xCD1A40", Offset = "0xCD1A40", VA = "0xCD1A40")]
		public GetMouseButton()
		{
		}
	}
	[Token(Token = "0x200022C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E23C0", Offset = "0x6E23C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E23C0", Offset = "0x6E23C0")]
	public class GetMousePosition : Action
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2648", Offset = "0x6F2648")]
		public SharedVector3 storeResult;

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xCD1A48", Offset = "0xCD1A48", VA = "0xCD1A48", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xCD1AB0", Offset = "0xCD1AB0", VA = "0xCD1AB0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xCD1AE8", Offset = "0xCD1AE8", VA = "0xCD1AE8")]
		public GetMousePosition()
		{
		}
	}
	[Token(Token = "0x200022D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2420", Offset = "0x6E2420")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2420", Offset = "0x6E2420")]
	public class IsButtonDown : Conditional
	{
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2694", Offset = "0x6F2694")]
		public SharedString buttonName;

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xFC0760", Offset = "0xFC0760", VA = "0xFC0760", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xFC07CC", Offset = "0xFC07CC", VA = "0xFC07CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xFC0828", Offset = "0xFC0828", VA = "0xFC0828")]
		public IsButtonDown()
		{
		}
	}
	[Token(Token = "0x200022E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2480", Offset = "0x6E2480")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2480", Offset = "0x6E2480")]
	public class IsButtonUp : Conditional
	{
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F26CC", Offset = "0x6F26CC")]
		public SharedString buttonName;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xFC0830", Offset = "0xFC0830", VA = "0xFC0830", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xFC089C", Offset = "0xFC089C", VA = "0xFC089C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xFC08F8", Offset = "0xFC08F8", VA = "0xFC08F8")]
		public IsButtonUp()
		{
		}
	}
	[Token(Token = "0x200022F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E24E0", Offset = "0x6E24E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E24E0", Offset = "0x6E24E0")]
	public class IsKeyDown : Conditional
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2704", Offset = "0x6F2704")]
		public KeyCode key;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xFC124C", Offset = "0xFC124C", VA = "0xFC124C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xFC1274", Offset = "0xFC1274", VA = "0xFC1274", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xFC127C", Offset = "0xFC127C", VA = "0xFC127C")]
		public IsKeyDown()
		{
		}
	}
	[Token(Token = "0x2000230")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2540", Offset = "0x6E2540")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2540", Offset = "0x6E2540")]
	public class IsKeyUp : Conditional
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F273C", Offset = "0x6F273C")]
		public KeyCode key;

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xFC1284", Offset = "0xFC1284", VA = "0xFC1284", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xFC12AC", Offset = "0xFC12AC", VA = "0xFC12AC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xFC12B4", Offset = "0xFC12B4", VA = "0xFC12B4")]
		public IsKeyUp()
		{
		}
	}
	[Token(Token = "0x2000231")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E25A0", Offset = "0x6E25A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E25A0", Offset = "0x6E25A0")]
	public class IsMouseDown : Conditional
	{
		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2774", Offset = "0x6F2774")]
		public SharedInt buttonIndex;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xFC16D4", Offset = "0xFC16D4", VA = "0xFC16D4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xFC1740", Offset = "0xFC1740", VA = "0xFC1740", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xFC1774", Offset = "0xFC1774", VA = "0xFC1774")]
		public IsMouseDown()
		{
		}
	}
	[Token(Token = "0x2000232")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2600", Offset = "0x6E2600")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2600", Offset = "0x6E2600")]
	public class IsMouseUp : Conditional
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F27AC", Offset = "0x6F27AC")]
		public SharedInt buttonIndex;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xFC177C", Offset = "0xFC177C", VA = "0xFC177C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xFC17E8", Offset = "0xFC17E8", VA = "0xFC17E8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xFC181C", Offset = "0xFC181C", VA = "0xFC181C")]
		public IsMouseUp()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	[Token(Token = "0x2000233")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2660", Offset = "0x6E2660")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2660", Offset = "0x6E2660")]
	public class ActiveInHierarchy : Conditional
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F27E4", Offset = "0x6F27E4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x111942C", Offset = "0x111942C", VA = "0x111942C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x11194AC", Offset = "0x11194AC", VA = "0x11194AC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x11194B8", Offset = "0x11194B8", VA = "0x11194B8")]
		public ActiveInHierarchy()
		{
		}
	}
	[Token(Token = "0x2000234")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E26C0", Offset = "0x6E26C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E26C0", Offset = "0x6E26C0")]
	public class ActiveSelf : Conditional
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F281C", Offset = "0x6F281C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x11194C0", Offset = "0x11194C0", VA = "0x11194C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1119540", Offset = "0x1119540", VA = "0x1119540", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x111954C", Offset = "0x111954C", VA = "0x111954C")]
		public ActiveSelf()
		{
		}
	}
	[Token(Token = "0x2000235")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2720", Offset = "0x6E2720")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2720", Offset = "0x6E2720")]
	public class CompareLayerMask : Conditional
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2854", Offset = "0x6F2854")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F288C", Offset = "0x6F288C")]
		public LayerMask layermask;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x11289F0", Offset = "0x11289F0", VA = "0x11289F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1128A84", Offset = "0x1128A84", VA = "0x1128A84", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1128A90", Offset = "0x1128A90", VA = "0x1128A90")]
		public CompareLayerMask()
		{
		}
	}
	[Token(Token = "0x2000236")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2780", Offset = "0x6E2780")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2780", Offset = "0x6E2780")]
	public class CompareTag : Conditional
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F28C4", Offset = "0x6F28C4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F28FC", Offset = "0x6F28FC")]
		public SharedString tag;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x112A464", Offset = "0x112A464", VA = "0x112A464", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x112A518", Offset = "0x112A518", VA = "0x112A518", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x112A584", Offset = "0x112A584", VA = "0x112A584")]
		public CompareTag()
		{
		}
	}
	[Token(Token = "0x2000237")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E27E0", Offset = "0x6E27E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E27E0", Offset = "0x6E27E0")]
	public class Destroy : Action
	{
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2934", Offset = "0x6F2934")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F296C", Offset = "0x6F296C")]
		public float time;

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x112BD98", Offset = "0x112BD98", VA = "0x112BD98", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x112BE80", Offset = "0x112BE80", VA = "0x112BE80", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x112BEB0", Offset = "0x112BEB0", VA = "0x112BEB0")]
		public Destroy()
		{
		}
	}
	[Token(Token = "0x2000238")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2840", Offset = "0x6E2840")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2840", Offset = "0x6E2840")]
	public class DestroyImmediate : Action
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F29A4", Offset = "0x6F29A4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x112BEB8", Offset = "0x112BEB8", VA = "0x112BEB8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x112BF64", Offset = "0x112BF64", VA = "0x112BF64", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x112BF70", Offset = "0x112BF70", VA = "0x112BF70")]
		public DestroyImmediate()
		{
		}
	}
	[Token(Token = "0x2000239")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E28A0", Offset = "0x6E28A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E28A0", Offset = "0x6E28A0")]
	public class Find : Action
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F29DC", Offset = "0x6F29DC")]
		public SharedString gameObjectName;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2A14", Offset = "0x6F2A14")]
		[RequiredField]
		public SharedGameObject storeValue;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xCC2414", Offset = "0xCC2414", VA = "0xCC2414", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xCC2514", Offset = "0xCC2514", VA = "0xCC2514", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xCC2548", Offset = "0xCC2548", VA = "0xCC2548")]
		public Find()
		{
		}
	}
	[Token(Token = "0x200023A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2900", Offset = "0x6E2900")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2900", Offset = "0x6E2900")]
	public class FindGameObjectsWithTag : Action
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2A60", Offset = "0x6F2A60")]
		public SharedString tag;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2A98", Offset = "0x6F2A98")]
		[RequiredField]
		public SharedGameObjectList storeValue;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xCC2844", Offset = "0xCC2844", VA = "0xCC2844", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xCC2944", Offset = "0xCC2944", VA = "0xCC2944", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xCC29C4", Offset = "0xCC29C4", VA = "0xCC29C4")]
		public FindGameObjectsWithTag()
		{
		}
	}
	[Token(Token = "0x200023B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2960", Offset = "0x6E2960")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2960", Offset = "0x6E2960")]
	public class FindWithTag : Action
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2AE4", Offset = "0x6F2AE4")]
		public SharedString tag;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2B1C", Offset = "0x6F2B1C")]
		public SharedBool random;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2B54", Offset = "0x6F2B54")]
		[RequiredField]
		public SharedGameObject storeValue;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xCC29CC", Offset = "0xCC29CC", VA = "0xCC29CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xCC2B7C", Offset = "0xCC2B7C", VA = "0xCC2B7C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xCC2BFC", Offset = "0xCC2BFC", VA = "0xCC2BFC")]
		public FindWithTag()
		{
		}
	}
	[Token(Token = "0x200023C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E29C0", Offset = "0x6E29C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E29C0", Offset = "0x6E29C0")]
	public class GetComponent : Action
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2BA0", Offset = "0x6F2BA0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2BD8", Offset = "0x6F2BD8")]
		public SharedString type;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2C10", Offset = "0x6F2C10")]
		public SharedObject storeValue;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xCCAEB0", Offset = "0xCCAEB0", VA = "0xCCAEB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xCCAF88", Offset = "0xCCAF88", VA = "0xCCAF88", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xCCB030", Offset = "0xCCB030", VA = "0xCCB030")]
		public GetComponent()
		{
		}
	}
	[Token(Token = "0x200023D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2A20", Offset = "0x6E2A20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2A20", Offset = "0x6E2A20")]
	public class GetTag : Action
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2C5C", Offset = "0x6F2C5C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2C94", Offset = "0x6F2C94")]
		public SharedString storeValue;

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xCD6F78", Offset = "0xCD6F78", VA = "0xCD6F78", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xCD701C", Offset = "0xCD701C", VA = "0xCD701C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xCD7088", Offset = "0xCD7088", VA = "0xCD7088")]
		public GetTag()
		{
		}
	}
	[Token(Token = "0x200023E")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2A80", Offset = "0x6E2A80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2A80", Offset = "0x6E2A80")]
	public class Instantiate : Action
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2CE0", Offset = "0x6F2CE0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2D18", Offset = "0x6F2D18")]
		public SharedVector3 position;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2D50", Offset = "0x6F2D50")]
		public SharedQuaternion rotation;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2D88", Offset = "0x6F2D88")]
		[SharedRequired]
		public SharedGameObject storeResult;

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFBF100", Offset = "0xFBF100", VA = "0xFBF100", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xFBF284", Offset = "0xFBF284", VA = "0xFBF284", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFBF2EC", Offset = "0xFBF2EC", VA = "0xFBF2EC")]
		public Instantiate()
		{
		}
	}
	[Token(Token = "0x200023F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2AE0", Offset = "0x6E2AE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2AE0", Offset = "0x6E2AE0")]
	public class SendMessage : Action
	{
		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2DD4", Offset = "0x6F2DD4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2E0C", Offset = "0x6F2E0C")]
		public SharedString message;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2E44", Offset = "0x6F2E44")]
		public SharedGenericVariable value;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFD441C", Offset = "0xFD441C", VA = "0xFD441C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xFD4550", Offset = "0xFD4550", VA = "0xFD4550", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xFD45BC", Offset = "0xFD45BC", VA = "0xFD45BC")]
		public SendMessage()
		{
		}
	}
	[Token(Token = "0x2000240")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2B40", Offset = "0x6E2B40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2B40", Offset = "0x6E2B40")]
	public class SetActive : Action
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2E7C", Offset = "0x6F2E7C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2EB4", Offset = "0x6F2EB4")]
		public SharedBool active;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xFD48C4", Offset = "0xFD48C4", VA = "0xFD48C4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xFD4970", Offset = "0xFD4970", VA = "0xFD4970", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xFD49B4", Offset = "0xFD49B4", VA = "0xFD49B4")]
		public SetActive()
		{
		}
	}
	[Token(Token = "0x2000241")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2BA0", Offset = "0x6E2BA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2BA0", Offset = "0x6E2BA0")]
	public class SetTag : Action
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2EEC", Offset = "0x6F2EEC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2F24", Offset = "0x6F2F24")]
		public SharedString tag;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xC97AEC", Offset = "0xC97AEC", VA = "0xC97AEC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xC97B98", Offset = "0xC97B98", VA = "0xC97B98", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xC97C00", Offset = "0xC97C00", VA = "0xC97C00")]
		public SetTag()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityDebug
{
	[Token(Token = "0x2000242")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2C00", Offset = "0x6E2C00")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2C00", Offset = "0x6E2C00")]
	public class DrawLine : Action
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2F5C", Offset = "0x6F2F5C")]
		public SharedVector3 start;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2F94", Offset = "0x6F2F94")]
		public SharedVector3 end;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F2FCC", Offset = "0x6F2FCC")]
		public SharedColor color;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3004", Offset = "0x6F3004")]
		public SharedFloat duration;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F303C", Offset = "0x6F303C")]
		public SharedBool depthTest;

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xCC10CC", Offset = "0xCC10CC", VA = "0xCC10CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xCC1254", Offset = "0xCC1254", VA = "0xCC1254", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xCC1304", Offset = "0xCC1304", VA = "0xCC1304")]
		public DrawLine()
		{
		}
	}
	[Token(Token = "0x2000243")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2C60", Offset = "0x6E2C60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2C60", Offset = "0x6E2C60")]
	public class DrawRay : Action
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3074", Offset = "0x6F3074")]
		public SharedVector3 start;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F30AC", Offset = "0x6F30AC")]
		public SharedVector3 direction;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F30E4", Offset = "0x6F30E4")]
		public SharedColor color;

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xCC1364", Offset = "0xCC1364", VA = "0xCC1364", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xCC1490", Offset = "0xCC1490", VA = "0xCC1490", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xCC1508", Offset = "0xCC1508", VA = "0xCC1508")]
		public DrawRay()
		{
		}
	}
	[Token(Token = "0x2000244")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2CC0", Offset = "0x6E2CC0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E2CC0", Offset = "0x6E2CC0")]
	public class LogFormat : Action
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F311C", Offset = "0x6F311C")]
		public SharedString textFormat;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3154", Offset = "0x6F3154")]
		public SharedBool logError;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SharedVariable arg0;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SharedVariable arg1;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SharedVariable arg2;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public SharedVariable arg3;

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFC68E0", Offset = "0xFC68E0", VA = "0xFC68E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFC69F0", Offset = "0xFC69F0", VA = "0xFC69F0")]
		private object[] buildParamsArray()
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFC6CA4", Offset = "0xFC6CA4", VA = "0xFC6CA4")]
		private bool isValid(SharedVariable sv)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFC6CD4", Offset = "0xFC6CD4", VA = "0xFC6CD4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFC6D94", Offset = "0xFC6D94", VA = "0xFC6D94")]
		public LogFormat()
		{
		}
	}
	[Token(Token = "0x2000245")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2D20", Offset = "0x6E2D20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2D20", Offset = "0x6E2D20")]
	public class LogValue : Action
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F318C", Offset = "0x6F318C")]
		public SharedGenericVariable variable;

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xFC6DA4", Offset = "0xFC6DA4", VA = "0xFC6DA4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xFC6E58", Offset = "0xFC6E58", VA = "0xFC6E58", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xFC6E64", Offset = "0xFC6E64", VA = "0xFC6E64")]
		public LogValue()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.Collider
{
	[Token(Token = "0x2000246")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2D80", Offset = "0x6E2D80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2D80", Offset = "0x6E2D80")]
	public class GetEnabled : Action
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F31C4", Offset = "0x6F31C4")]
		public SharedCollider specifiedCollider;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F31FC", Offset = "0x6F31FC")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xCCC91C", Offset = "0xCCC91C", VA = "0xCCC91C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xCCCA04", Offset = "0xCCCA04", VA = "0xCCCA04", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xCCCA78", Offset = "0xCCCA78", VA = "0xCCCA78")]
		public GetEnabled()
		{
		}
	}
	[Token(Token = "0x2000247")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2DE0", Offset = "0x6E2DE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2DE0", Offset = "0x6E2DE0")]
	public class SetEnabled : Action
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3248", Offset = "0x6F3248")]
		public SharedCollider specifiedCollider;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3280", Offset = "0x6F3280")]
		public SharedBool enabled;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xC8BB10", Offset = "0xC8BB10", VA = "0xC8BB10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xC8BC00", Offset = "0xC8BC00", VA = "0xC8BC00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xC8BC70", Offset = "0xC8BC70", VA = "0xC8BC70")]
		public SetEnabled()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCircleCollider2D
{
	[Token(Token = "0x2000248")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2E40", Offset = "0x6E2E40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2E40", Offset = "0x6E2E40")]
	public class GetOffset : Action
	{
		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F32B8", Offset = "0x6F32B8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F32F0", Offset = "0x6F32F0")]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xCD1D58", Offset = "0xCD1D58", VA = "0xCD1D58", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xCD1E68", Offset = "0xCD1E68", VA = "0xCD1E68", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xCD1F74", Offset = "0xCD1F74", VA = "0xCD1F74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xCD1FBC", Offset = "0xCD1FBC", VA = "0xCD1FBC")]
		public GetOffset()
		{
		}
	}
	[Token(Token = "0x2000249")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2EA0", Offset = "0x6E2EA0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2EA0", Offset = "0x6E2EA0")]
	public class GetRadius : Action
	{
		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F333C", Offset = "0x6F333C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3374", Offset = "0x6F3374")]
		public SharedFloat storeValue;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xCD3B14", Offset = "0xCD3B14", VA = "0xCD3B14", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xCD3C24", Offset = "0xCD3C24", VA = "0xCD3C24", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xCD3D2C", Offset = "0xCD3D2C", VA = "0xCD3D2C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xCD3D70", Offset = "0xCD3D70", VA = "0xCD3D70")]
		public GetRadius()
		{
		}
	}
	[Token(Token = "0x200024A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2F00", Offset = "0x6E2F00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2F00", Offset = "0x6E2F00")]
	public class SetOffset : Action
	{
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F33C0", Offset = "0x6F33C0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F33F8", Offset = "0x6F33F8")]
		public SharedVector3 offset;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xC9110C", Offset = "0xC9110C", VA = "0xC9110C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xC9121C", Offset = "0xC9121C", VA = "0xC9121C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xC91324", Offset = "0xC91324", VA = "0xC91324", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xC91368", Offset = "0xC91368", VA = "0xC91368")]
		public SetOffset()
		{
		}
	}
	[Token(Token = "0x200024B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2F60", Offset = "0x6E2F60")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2F60", Offset = "0x6E2F60")]
	public class SetRadius : Action
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3430", Offset = "0x6F3430")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3468", Offset = "0x6F3468")]
		public SharedFloat radius;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xC92A0C", Offset = "0xC92A0C", VA = "0xC92A0C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xC92B1C", Offset = "0xC92B1C", VA = "0xC92B1C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xC92C24", Offset = "0xC92C24", VA = "0xC92C24", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xC92C64", Offset = "0xC92C64", VA = "0xC92C64")]
		public SetRadius()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	[Token(Token = "0x200024C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E2FC0", Offset = "0x6E2FC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E2FC0", Offset = "0x6E2FC0")]
	public class GetCenter : Action
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F34A0", Offset = "0x6F34A0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F34D8", Offset = "0x6F34D8")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xCCA02C", Offset = "0xCCA02C", VA = "0xCCA02C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xCCA13C", Offset = "0xCCA13C", VA = "0xCCA13C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xCCA244", Offset = "0xCCA244", VA = "0xCCA244", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xCCA28C", Offset = "0xCCA28C", VA = "0xCCA28C")]
		public GetCenter()
		{
		}
	}
	[Token(Token = "0x200024D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3020", Offset = "0x6E3020")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3020", Offset = "0x6E3020")]
	public class GetHeight : Action
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3524", Offset = "0x6F3524")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F355C", Offset = "0x6F355C")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xCCE258", Offset = "0xCCE258", VA = "0xCCE258", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xCCE368", Offset = "0xCCE368", VA = "0xCCE368", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xCCE470", Offset = "0xCCE470", VA = "0xCCE470", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xCCE4B4", Offset = "0xCCE4B4", VA = "0xCCE4B4")]
		public GetHeight()
		{
		}
	}
	[Token(Token = "0x200024E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3080", Offset = "0x6E3080")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3080", Offset = "0x6E3080")]
	public class GetRadius : Action
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F35A8", Offset = "0x6F35A8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F35E0", Offset = "0x6F35E0")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xCD38B0", Offset = "0xCD38B0", VA = "0xCD38B0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xCD39C0", Offset = "0xCD39C0", VA = "0xCD39C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xCD3AC8", Offset = "0xCD3AC8", VA = "0xCD3AC8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xCD3B0C", Offset = "0xCD3B0C", VA = "0xCD3B0C")]
		public GetRadius()
		{
		}
	}
	[Token(Token = "0x200024F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E30E0", Offset = "0x6E30E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E30E0", Offset = "0x6E30E0")]
	public class GetSlopeLimit : Action
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F362C", Offset = "0x6F362C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3664", Offset = "0x6F3664")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xCD5A94", Offset = "0xCD5A94", VA = "0xCD5A94", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xCD5BA4", Offset = "0xCD5BA4", VA = "0xCD5BA4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xCD5CAC", Offset = "0xCD5CAC", VA = "0xCD5CAC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xCD5CF0", Offset = "0xCD5CF0", VA = "0xCD5CF0")]
		public GetSlopeLimit()
		{
		}
	}
	[Token(Token = "0x2000250")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3140", Offset = "0x6E3140")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3140", Offset = "0x6E3140")]
	public class GetStepOffset : Action
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F36B0", Offset = "0x6F36B0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F36E8", Offset = "0x6F36E8")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xCD6878", Offset = "0xCD6878", VA = "0xCD6878", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xCD6988", Offset = "0xCD6988", VA = "0xCD6988", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xCD6A90", Offset = "0xCD6A90", VA = "0xCD6A90", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xCD6AD4", Offset = "0xCD6AD4", VA = "0xCD6AD4")]
		public GetStepOffset()
		{
		}
	}
	[Token(Token = "0x2000251")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E31A0", Offset = "0x6E31A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E31A0", Offset = "0x6E31A0")]
	public class GetVelocity : Action
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3734", Offset = "0x6F3734")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F376C", Offset = "0x6F376C")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xCD8150", Offset = "0xCD8150", VA = "0xCD8150", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xCD8260", Offset = "0xCD8260", VA = "0xCD8260", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xCD8368", Offset = "0xCD8368", VA = "0xCD8368", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xCD83B0", Offset = "0xCD83B0", VA = "0xCD83B0")]
		public GetVelocity()
		{
		}
	}
	[Token(Token = "0x2000252")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3200", Offset = "0x6E3200")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3200", Offset = "0x6E3200")]
	public class HasColliderHit : Conditional
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F37B8", Offset = "0x6F37B8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F37F0", Offset = "0x6F37F0")]
		public SharedString tag;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3828", Offset = "0x6F3828")]
		public SharedGameObject collidedGameObject;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool enteredCollision;

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xCD8D88", Offset = "0xCD8D88", VA = "0xCD8D88", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xCD8D9C", Offset = "0xCD8D9C", VA = "0xCD8D9C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xCD8DA4", Offset = "0xCD8DA4", VA = "0xCD8DA4", Slot = "27")]
		public override void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xCD8EA4", Offset = "0xCD8EA4", VA = "0xCD8EA4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xCD8F20", Offset = "0xCD8F20", VA = "0xCD8F20")]
		public HasColliderHit()
		{
		}
	}
	[Token(Token = "0x2000253")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3260", Offset = "0x6E3260")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3260", Offset = "0x6E3260")]
	public class IsGrounded : Conditional
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3860", Offset = "0x6F3860")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xFC0D30", Offset = "0xFC0D30", VA = "0xFC0D30", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xFC0E40", Offset = "0xFC0E40", VA = "0xFC0E40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xFC0F28", Offset = "0xFC0F28", VA = "0xFC0F28", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xFC0F34", Offset = "0xFC0F34", VA = "0xFC0F34")]
		public IsGrounded()
		{
		}
	}
	[Token(Token = "0x2000254")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E32C0", Offset = "0x6E32C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E32C0", Offset = "0x6E32C0")]
	public class Move : Action
	{
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3898", Offset = "0x6F3898")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F38D0", Offset = "0x6F38D0")]
		public SharedVector3 motion;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xFC7684", Offset = "0xFC7684", VA = "0xFC7684", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xFC7794", Offset = "0xFC7794", VA = "0xFC7794", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xFC789C", Offset = "0xFC789C", VA = "0xFC789C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xFC78E4", Offset = "0xFC78E4", VA = "0xFC78E4")]
		public Move()
		{
		}
	}
	[Token(Token = "0x2000255")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3320", Offset = "0x6E3320")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3320", Offset = "0x6E3320")]
	public class SetCenter : Action
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3908", Offset = "0x6F3908")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3940", Offset = "0x6F3940")]
		public SharedVector3 center;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xC898A0", Offset = "0xC898A0", VA = "0xC898A0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xC899B0", Offset = "0xC899B0", VA = "0xC899B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xC89AB8", Offset = "0xC89AB8", VA = "0xC89AB8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xC89AFC", Offset = "0xC89AFC", VA = "0xC89AFC")]
		public SetCenter()
		{
		}
	}
	[Token(Token = "0x2000256")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3380", Offset = "0x6E3380")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3380", Offset = "0x6E3380")]
	public class SetHeight : Action
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3978", Offset = "0x6F3978")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F39B0", Offset = "0x6F39B0")]
		public SharedFloat height;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xC8D29C", Offset = "0xC8D29C", VA = "0xC8D29C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xC8D3AC", Offset = "0xC8D3AC", VA = "0xC8D3AC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xC8D4B4", Offset = "0xC8D4B4", VA = "0xC8D4B4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xC8D4F4", Offset = "0xC8D4F4", VA = "0xC8D4F4")]
		public SetHeight()
		{
		}
	}
	[Token(Token = "0x2000257")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E33E0", Offset = "0x6E33E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E33E0", Offset = "0x6E33E0")]
	public class SetRadius : Action
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F39E8", Offset = "0x6F39E8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3A20", Offset = "0x6F3A20")]
		public SharedFloat radius;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xC927AC", Offset = "0xC927AC", VA = "0xC927AC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xC928BC", Offset = "0xC928BC", VA = "0xC928BC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xC929C4", Offset = "0xC929C4", VA = "0xC929C4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xC92A04", Offset = "0xC92A04", VA = "0xC92A04")]
		public SetRadius()
		{
		}
	}
	[Token(Token = "0x2000258")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3440", Offset = "0x6E3440")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3440", Offset = "0x6E3440")]
	public class SetSlopeLimit : Action
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3A58", Offset = "0x6F3A58")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3A90", Offset = "0x6F3A90")]
		public SharedFloat slopeLimit;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xC95B28", Offset = "0xC95B28", VA = "0xC95B28", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xC95C38", Offset = "0xC95C38", VA = "0xC95C38", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xC95D40", Offset = "0xC95D40", VA = "0xC95D40", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xC95D80", Offset = "0xC95D80", VA = "0xC95D80")]
		public SetSlopeLimit()
		{
		}
	}
	[Token(Token = "0x2000259")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E34A0", Offset = "0x6E34A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E34A0", Offset = "0x6E34A0")]
	public class SetStepOffset : Action
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3AC8", Offset = "0x6F3AC8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3B00", Offset = "0x6F3B00")]
		public SharedFloat stepOffset;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xC97690", Offset = "0xC97690", VA = "0xC97690", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xC977A0", Offset = "0xC977A0", VA = "0xC977A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xC978A8", Offset = "0xC978A8", VA = "0xC978A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xC978E8", Offset = "0xC978E8", VA = "0xC978E8")]
		public SetStepOffset()
		{
		}
	}
	[Token(Token = "0x200025A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3500", Offset = "0x6E3500")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3500", Offset = "0x6E3500")]
	public class SimpleMove : Action
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3B38", Offset = "0x6F3B38")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3B70", Offset = "0x6F3B70")]
		public SharedVector3 speed;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xC9AFDC", Offset = "0xC9AFDC", VA = "0xC9AFDC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xC9B0EC", Offset = "0xC9B0EC", VA = "0xC9B0EC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xC9B1F4", Offset = "0xC9B1F4", VA = "0xC9B1F4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xC9B238", Offset = "0xC9B238", VA = "0xC9B238")]
		public SimpleMove()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	[Token(Token = "0x200025B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3560", Offset = "0x6E3560")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3560", Offset = "0x6E3560")]
	public class GetCenter : Action
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3BA8", Offset = "0x6F3BA8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3BE0", Offset = "0x6F3BE0")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xCC9DC4", Offset = "0xCC9DC4", VA = "0xCC9DC4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xCC9ED4", Offset = "0xCC9ED4", VA = "0xCC9ED4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xCC9FDC", Offset = "0xCC9FDC", VA = "0xCC9FDC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xCCA024", Offset = "0xCCA024", VA = "0xCCA024")]
		public GetCenter()
		{
		}
	}
	[Token(Token = "0x200025C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E35C0", Offset = "0x6E35C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E35C0", Offset = "0x6E35C0")]
	public class GetDirection : Action
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3C2C", Offset = "0x6F3C2C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3C64", Offset = "0x6F3C64")]
		public SharedInt storeValue;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xCCBA88", Offset = "0xCCBA88", VA = "0xCCBA88", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xCCBB98", Offset = "0xCCBB98", VA = "0xCCBB98", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xCCBCA4", Offset = "0xCCBCA4", VA = "0xCCBCA4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xCCBCE8", Offset = "0xCCBCE8", VA = "0xCCBCE8")]
		public GetDirection()
		{
		}
	}
	[Token(Token = "0x200025D")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3620", Offset = "0x6E3620")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3620", Offset = "0x6E3620")]
	public class GetHeight : Action
	{
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3CB0", Offset = "0x6F3CB0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3CE8", Offset = "0x6F3CE8")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xCCDFF4", Offset = "0xCCDFF4", VA = "0xCCDFF4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xCCE104", Offset = "0xCCE104", VA = "0xCCE104", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xCCE20C", Offset = "0xCCE20C", VA = "0xCCE20C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xCCE250", Offset = "0xCCE250", VA = "0xCCE250")]
		public GetHeight()
		{
		}
	}
	[Token(Token = "0x200025E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3680", Offset = "0x6E3680")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3680", Offset = "0x6E3680")]
	public class GetRadius : Action
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3D34", Offset = "0x6F3D34")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3D6C", Offset = "0x6F3D6C")]
		public SharedFloat storeValue;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xCD364C", Offset = "0xCD364C", VA = "0xCD364C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xCD375C", Offset = "0xCD375C", VA = "0xCD375C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xCD3864", Offset = "0xCD3864", VA = "0xCD3864", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xCD38A8", Offset = "0xCD38A8", VA = "0xCD38A8")]
		public GetRadius()
		{
		}
	}
	[Token(Token = "0x200025F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E36E0", Offset = "0x6E36E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E36E0", Offset = "0x6E36E0")]
	public class SetCenter : Action
	{
		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3DB8", Offset = "0x6F3DB8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3DF0", Offset = "0x6F3DF0")]
		public SharedVector3 center;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xC8963C", Offset = "0xC8963C", VA = "0xC8963C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xC8974C", Offset = "0xC8974C", VA = "0xC8974C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xC89854", Offset = "0xC89854", VA = "0xC89854", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xC89898", Offset = "0xC89898", VA = "0xC89898")]
		public SetCenter()
		{
		}
	}
	[Token(Token = "0x2000260")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3740", Offset = "0x6E3740")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3740", Offset = "0x6E3740")]
	public class SetDirection : Action
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3E28", Offset = "0x6F3E28")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3E60", Offset = "0x6F3E60")]
		public SharedInt direction;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xC8AEB0", Offset = "0xC8AEB0", VA = "0xC8AEB0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xC8AFC0", Offset = "0xC8AFC0", VA = "0xC8AFC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xC8B0CC", Offset = "0xC8B0CC", VA = "0xC8B0CC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xC8B170", Offset = "0xC8B170", VA = "0xC8B170")]
		public SetDirection()
		{
		}
	}
	[Token(Token = "0x2000261")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E37A0", Offset = "0x6E37A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E37A0", Offset = "0x6E37A0")]
	public class SetHeight : Action
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3E98", Offset = "0x6F3E98")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3ED0", Offset = "0x6F3ED0")]
		public SharedFloat direction;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xC8D03C", Offset = "0xC8D03C", VA = "0xC8D03C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xC8D14C", Offset = "0xC8D14C", VA = "0xC8D14C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xC8D254", Offset = "0xC8D254", VA = "0xC8D254", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xC8D294", Offset = "0xC8D294", VA = "0xC8D294")]
		public SetHeight()
		{
		}
	}
	[Token(Token = "0x2000262")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3800", Offset = "0x6E3800")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3800", Offset = "0x6E3800")]
	public class SetRadius : Action
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3F08", Offset = "0x6F3F08")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3F40", Offset = "0x6F3F40")]
		public SharedFloat radius;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xC9254C", Offset = "0xC9254C", VA = "0xC9254C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xC9265C", Offset = "0xC9265C", VA = "0xC9265C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xC92764", Offset = "0xC92764", VA = "0xC92764", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xC927A4", Offset = "0xC927A4", VA = "0xC927A4")]
		public SetRadius()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider2D
{
	[Token(Token = "0x2000263")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3860", Offset = "0x6E3860")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3860", Offset = "0x6E3860")]
	public class GetSize : Action
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3F78", Offset = "0x6F3F78")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3FB0", Offset = "0x6F3FB0")]
		public SharedVector2 storeValue;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoxCollider2D boxCollider2D;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xCD582C", Offset = "0xCD582C", VA = "0xCD582C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xCD593C", Offset = "0xCD593C", VA = "0xCD593C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xCD5A44", Offset = "0xCD5A44", VA = "0xCD5A44", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xCD5A8C", Offset = "0xCD5A8C", VA = "0xCD5A8C")]
		public GetSize()
		{
		}
	}
	[Token(Token = "0x2000264")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E38C0", Offset = "0x6E38C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E38C0", Offset = "0x6E38C0")]
	public class SetSize : Action
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F3FFC", Offset = "0x6F3FFC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4034", Offset = "0x6F4034")]
		public SharedVector2 size;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoxCollider2D boxCollider2D;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xC958C4", Offset = "0xC958C4", VA = "0xC958C4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xC959D4", Offset = "0xC959D4", VA = "0xC959D4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xC95ADC", Offset = "0xC95ADC", VA = "0xC95ADC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xC95B20", Offset = "0xC95B20", VA = "0xC95B20")]
		public SetSize()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider
{
	[Token(Token = "0x2000265")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3920", Offset = "0x6E3920")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3920", Offset = "0x6E3920")]
	public class GetCenter : Action
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F406C", Offset = "0x6F406C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F40A4", Offset = "0x6F40A4")]
		public SharedVector3 storeValue;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xCC9B5C", Offset = "0xCC9B5C", VA = "0xCC9B5C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xCC9C6C", Offset = "0xCC9C6C", VA = "0xCC9C6C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xCC9D74", Offset = "0xCC9D74", VA = "0xCC9D74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xCC9DBC", Offset = "0xCC9DBC", VA = "0xCC9DBC")]
		public GetCenter()
		{
		}
	}
	[Token(Token = "0x2000266")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3980", Offset = "0x6E3980")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3980", Offset = "0x6E3980")]
	public class GetSize : Action
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F40F0", Offset = "0x6F40F0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4128", Offset = "0x6F4128")]
		public SharedVector3 storeValue;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xCD55C4", Offset = "0xCD55C4", VA = "0xCD55C4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xCD56D4", Offset = "0xCD56D4", VA = "0xCD56D4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xCD57DC", Offset = "0xCD57DC", VA = "0xCD57DC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xCD5824", Offset = "0xCD5824", VA = "0xCD5824")]
		public GetSize()
		{
		}
	}
	[Token(Token = "0x2000267")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E39E0", Offset = "0x6E39E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E39E0", Offset = "0x6E39E0")]
	public class SetCenter : Action
	{
		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4174", Offset = "0x6F4174")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F41AC", Offset = "0x6F41AC")]
		public SharedVector3 center;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xC89358", Offset = "0xC89358", VA = "0xC89358", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xC89468", Offset = "0xC89468", VA = "0xC89468", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xC89570", Offset = "0xC89570", VA = "0xC89570", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xC89634", Offset = "0xC89634", VA = "0xC89634")]
		public SetCenter()
		{
		}
	}
	[Token(Token = "0x2000268")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3A40", Offset = "0x6E3A40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3A40", Offset = "0x6E3A40")]
	public class SetSize : Action
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F41E4", Offset = "0x6F41E4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F421C", Offset = "0x6F421C")]
		public SharedVector3 size;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xC95660", Offset = "0xC95660", VA = "0xC95660", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xC95770", Offset = "0xC95770", VA = "0xC95770", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xC95878", Offset = "0xC95878", VA = "0xC95878", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xC958BC", Offset = "0xC958BC", VA = "0xC958BC")]
		public SetSize()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBehaviour
{
	[Token(Token = "0x2000269")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3AA0", Offset = "0x6E3AA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3AA0", Offset = "0x6E3AA0")]
	public class GetEnabled : Action
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4254", Offset = "0x6F4254")]
		public SharedBehaviour specifiedObject;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F428C", Offset = "0x6F428C")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xCCCA80", Offset = "0xCCCA80", VA = "0xCCCA80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xCCCB68", Offset = "0xCCCB68", VA = "0xCCCB68", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xCCCBDC", Offset = "0xCCCBDC", VA = "0xCCCBDC")]
		public GetEnabled()
		{
		}
	}
	[Token(Token = "0x200026A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3B00", Offset = "0x6E3B00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3B00", Offset = "0x6E3B00")]
	public class IsEnabled : Conditional
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F42D8", Offset = "0x6F42D8")]
		public SharedObject specifiedObject;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFC0B60", Offset = "0xFC0B60", VA = "0xFC0B60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFC0C28", Offset = "0xFC0C28", VA = "0xFC0C28", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFC0C88", Offset = "0xFC0C88", VA = "0xFC0C88")]
		public IsEnabled()
		{
		}
	}
	[Token(Token = "0x200026B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3B60", Offset = "0x6E3B60")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3B60", Offset = "0x6E3B60")]
	public class SetEnabled : Action
	{
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4310", Offset = "0x6F4310")]
		public SharedBehaviour specifiedObject;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4348", Offset = "0x6F4348")]
		public SharedBool enabled;

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xC8BC78", Offset = "0xC8BC78", VA = "0xC8BC78", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xC8BD68", Offset = "0xC8BD68", VA = "0xC8BD68", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xC8BDD8", Offset = "0xC8BDD8", VA = "0xC8BDD8")]
		public SetEnabled()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	[Token(Token = "0x200026C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3BC0", Offset = "0x6E3BC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3BC0", Offset = "0x6E3BC0")]
	public class GetIgnoreListenerPause : Action
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4380", Offset = "0x6F4380")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F43B8", Offset = "0x6F43B8")]
		public SharedBool storeValue;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xCCE4BC", Offset = "0xCCE4BC", VA = "0xCCE4BC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xCCE5CC", Offset = "0xCCE5CC", VA = "0xCCE5CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xCCE6D8", Offset = "0xCCE6D8", VA = "0xCCE6D8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xCCE71C", Offset = "0xCCE71C", VA = "0xCCE71C")]
		public GetIgnoreListenerPause()
		{
		}
	}
	[Token(Token = "0x200026D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3C20", Offset = "0x6E3C20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3C20", Offset = "0x6E3C20")]
	public class GetIgnoreListenerVolume : Action
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4404", Offset = "0x6F4404")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F443C", Offset = "0x6F443C")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xCCE724", Offset = "0xCCE724", VA = "0xCCE724", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xCCE834", Offset = "0xCCE834", VA = "0xCCE834", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xCCE940", Offset = "0xCCE940", VA = "0xCCE940", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xCCE984", Offset = "0xCCE984", VA = "0xCCE984")]
		public GetIgnoreListenerVolume()
		{
		}
	}
	[Token(Token = "0x200026E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3C80", Offset = "0x6E3C80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3C80", Offset = "0x6E3C80")]
	public class GetLoop : Action
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4488", Offset = "0x6F4488")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F44C0", Offset = "0x6F44C0")]
		[RequiredField]
		public SharedBool storeValue;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xCD0660", Offset = "0xCD0660", VA = "0xCD0660", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xCD0770", Offset = "0xCD0770", VA = "0xCD0770", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xCD087C", Offset = "0xCD087C", VA = "0xCD087C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xCD08C0", Offset = "0xCD08C0", VA = "0xCD08C0")]
		public GetLoop()
		{
		}
	}
	[Token(Token = "0x200026F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3CE0", Offset = "0x6E3CE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3CE0", Offset = "0x6E3CE0")]
	public class GetMaxDistance : Action
	{
		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F450C", Offset = "0x6F450C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4544", Offset = "0x6F4544")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xCD1214", Offset = "0xCD1214", VA = "0xCD1214", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xCD1324", Offset = "0xCD1324", VA = "0xCD1324", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xCD142C", Offset = "0xCD142C", VA = "0xCD142C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xCD1470", Offset = "0xCD1470", VA = "0xCD1470")]
		public GetMaxDistance()
		{
		}
	}
	[Token(Token = "0x2000270")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3D40", Offset = "0x6E3D40")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3D40", Offset = "0x6E3D40")]
	public class GetMinDistance : Action
	{
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4590", Offset = "0x6F4590")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F45C8", Offset = "0x6F45C8")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xCD16FC", Offset = "0xCD16FC", VA = "0xCD16FC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xCD180C", Offset = "0xCD180C", VA = "0xCD180C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xCD1914", Offset = "0xCD1914", VA = "0xCD1914", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xCD1958", Offset = "0xCD1958", VA = "0xCD1958")]
		public GetMinDistance()
		{
		}
	}
	[Token(Token = "0x2000271")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3DA0", Offset = "0x6E3DA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3DA0", Offset = "0x6E3DA0")]
	public class GetMute : Action
	{
		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4614", Offset = "0x6F4614")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F464C", Offset = "0x6F464C")]
		public SharedBool storeValue;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xCD1AF0", Offset = "0xCD1AF0", VA = "0xCD1AF0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xCD1C00", Offset = "0xCD1C00", VA = "0xCD1C00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xCD1D0C", Offset = "0xCD1D0C", VA = "0xCD1D0C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xCD1D50", Offset = "0xCD1D50", VA = "0xCD1D50")]
		public GetMute()
		{
		}
	}
	[Token(Token = "0x2000272")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3E00", Offset = "0x6E3E00")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3E00", Offset = "0x6E3E00")]
	public class GetPitch : Action
	{
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4698", Offset = "0x6F4698")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F46D0", Offset = "0x6F46D0")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xCD2484", Offset = "0xCD2484", VA = "0xCD2484", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xCD2594", Offset = "0xCD2594", VA = "0xCD2594", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xCD269C", Offset = "0xCD269C", VA = "0xCD269C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xCD26E0", Offset = "0xCD26E0", VA = "0xCD26E0")]
		public GetPitch()
		{
		}
	}
	[Token(Token = "0x2000273")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3E60", Offset = "0x6E3E60")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3E60", Offset = "0x6E3E60")]
	public class GetPriority : Action
	{
		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F471C", Offset = "0x6F471C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4754", Offset = "0x6F4754")]
		public SharedInt storeValue;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xCD30A0", Offset = "0xCD30A0", VA = "0xCD30A0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xCD31B0", Offset = "0xCD31B0", VA = "0xCD31B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xCD32BC", Offset = "0xCD32BC", VA = "0xCD32BC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xCD3300", Offset = "0xCD3300", VA = "0xCD3300")]
		public GetPriority()
		{
		}
	}
	[Token(Token = "0x2000274")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3EC0", Offset = "0x6E3EC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3EC0", Offset = "0x6E3EC0")]
	public class GetSpread : Action
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F47A0", Offset = "0x6F47A0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F47D8", Offset = "0x6F47D8")]
		public SharedFloat storeValue;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xCD6414", Offset = "0xCD6414", VA = "0xCD6414", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xCD6524", Offset = "0xCD6524", VA = "0xCD6524", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xCD662C", Offset = "0xCD662C", VA = "0xCD662C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xCD6670", Offset = "0xCD6670", VA = "0xCD6670")]
		public GetSpread()
		{
		}
	}
	[Token(Token = "0x2000275")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3F20", Offset = "0x6E3F20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3F20", Offset = "0x6E3F20")]
	public class GetTime : Action
	{
		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4824", Offset = "0x6F4824")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F485C", Offset = "0x6F485C")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xCD7090", Offset = "0xCD7090", VA = "0xCD7090", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xCD71A0", Offset = "0xCD71A0", VA = "0xCD71A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xCD72A8", Offset = "0xCD72A8", VA = "0xCD72A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xCD72EC", Offset = "0xCD72EC", VA = "0xCD72EC")]
		public GetTime()
		{
		}
	}
	[Token(Token = "0x2000276")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3F80", Offset = "0x6E3F80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3F80", Offset = "0x6E3F80")]
	public class GetTimeSamples : Action
	{
		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F48A8", Offset = "0x6F48A8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F48E0", Offset = "0x6F48E0")]
		public SharedFloat storeValue;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xCD75FC", Offset = "0xCD75FC", VA = "0xCD75FC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xCD770C", Offset = "0xCD770C", VA = "0xCD770C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xCD7818", Offset = "0xCD7818", VA = "0xCD7818", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xCD785C", Offset = "0xCD785C", VA = "0xCD785C")]
		public GetTimeSamples()
		{
		}
	}
	[Token(Token = "0x2000277")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E3FE0", Offset = "0x6E3FE0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E3FE0", Offset = "0x6E3FE0")]
	public class GetVolume : Action
	{
		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F492C", Offset = "0x6F492C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4964", Offset = "0x6F4964")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xCD8888", Offset = "0xCD8888", VA = "0xCD8888", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xCD8998", Offset = "0xCD8998", VA = "0xCD8998", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xCD8AA0", Offset = "0xCD8AA0", VA = "0xCD8AA0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xCD8AE4", Offset = "0xCD8AE4", VA = "0xCD8AE4")]
		public GetVolume()
		{
		}
	}
	[Token(Token = "0x2000278")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4040", Offset = "0x6E4040")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4040", Offset = "0x6E4040")]
	public class IsPlaying : Conditional
	{
		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F49B0", Offset = "0x6F49B0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xFC27A4", Offset = "0xFC27A4", VA = "0xFC27A4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xFC28B4", Offset = "0xFC28B4", VA = "0xFC28B4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xFC299C", Offset = "0xFC299C", VA = "0xFC299C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xFC29A8", Offset = "0xFC29A8", VA = "0xFC29A8")]
		public IsPlaying()
		{
		}
	}
	[Token(Token = "0x2000279")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E40A0", Offset = "0x6E40A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E40A0", Offset = "0x6E40A0")]
	public class Pause : Action
	{
		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F49E8", Offset = "0x6F49E8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xFCCF38", Offset = "0xFCCF38", VA = "0xFCCF38", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xFCD048", Offset = "0xFCD048", VA = "0xFCD048", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xFCD128", Offset = "0xFCD128", VA = "0xFCD128", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xFCD134", Offset = "0xFCD134", VA = "0xFCD134")]
		public Pause()
		{
		}
	}
	[Token(Token = "0x200027A")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4100", Offset = "0x6E4100")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4100", Offset = "0x6E4100")]
	public class Play : Action
	{
		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4A20", Offset = "0x6F4A20")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xFCDCFC", Offset = "0xFCDCFC", VA = "0xFCDCFC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xFCDE0C", Offset = "0xFCDE0C", VA = "0xFCDE0C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xFCDEEC", Offset = "0xFCDEEC", VA = "0xFCDEEC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xFCDEF8", Offset = "0xFCDEF8", VA = "0xFCDEF8")]
		public Play()
		{
		}
	}
	[Token(Token = "0x200027B")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4160", Offset = "0x6E4160")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4160", Offset = "0x6E4160")]
	public class PlayDelayed : Action
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4A58", Offset = "0x6F4A58")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4A90", Offset = "0x6F4A90")]
		public SharedFloat delay;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xFCE104", Offset = "0xFCE104", VA = "0xFCE104", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xFCE214", Offset = "0xFCE214", VA = "0xFCE214", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xFCE31C", Offset = "0xFCE31C", VA = "0xFCE31C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xFCE360", Offset = "0xFCE360", VA = "0xFCE360")]
		public PlayDelayed()
		{
		}
	}
	[Token(Token = "0x200027C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E41C0", Offset = "0x6E41C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E41C0", Offset = "0x6E41C0")]
	public class PlayOneShot : Action
	{
		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4AC8", Offset = "0x6F4AC8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4B00", Offset = "0x6F4B00")]
		public SharedObject clip;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4B38", Offset = "0x6F4B38")]
		public SharedFloat volumeScale;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource audioSource;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xFCE3A0", Offset = "0xFCE3A0", VA = "0xFCE3A0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xFCE4B0", Offset = "0xFCE4B0", VA = "0xFCE4B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xFCE618", Offset = "0xFCE618", VA = "0xFCE618", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xFCE668", Offset = "0xFCE668", VA = "0xFCE668")]
		public PlayOneShot()
		{
		}
	}
	[Token(Token = "0x200027D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4220", Offset = "0x6E4220")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4220", Offset = "0x6E4220")]
	public class PlayScheduled : Action
	{
		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4B70", Offset = "0x6F4B70")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4BA8", Offset = "0x6F4BA8")]
		public SharedFloat time;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xFCE958", Offset = "0xFCE958", VA = "0xFCE958", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xFCEA68", Offset = "0xFCEA68", VA = "0xFCEA68", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xFCEB74", Offset = "0xFCEB74", VA = "0xFCEB74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xFCEBB8", Offset = "0xFCEBB8", VA = "0xFCEBB8")]
		public PlayScheduled()
		{
		}
	}
	[Token(Token = "0x200027E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4280", Offset = "0x6E4280")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4280", Offset = "0x6E4280")]
	public class SetAudioClip : Action
	{
		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4BE0", Offset = "0x6F4BE0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4C18", Offset = "0x6F4C18")]
		public AudioClip audioClip;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xC88C44", Offset = "0xC88C44", VA = "0xC88C44", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xC88D54", Offset = "0xC88D54", VA = "0xC88D54", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xC88E38", Offset = "0xC88E38", VA = "0xC88E38", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xC88E6C", Offset = "0xC88E6C", VA = "0xC88E6C")]
		public SetAudioClip()
		{
		}
	}
	[Token(Token = "0x200027F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E42E0", Offset = "0x6E42E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E42E0", Offset = "0x6E42E0")]
	public class SetIgnoreListenerVolume : Action
	{
		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4C50", Offset = "0x6F4C50")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4C88", Offset = "0x6F4C88")]
		public SharedBool ignoreListenerVolume;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xC8D760", Offset = "0xC8D760", VA = "0xC8D760", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xC8D870", Offset = "0xC8D870", VA = "0xC8D870", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xC8D97C", Offset = "0xC8D97C", VA = "0xC8D97C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xC8D9BC", Offset = "0xC8D9BC", VA = "0xC8D9BC")]
		public SetIgnoreListenerVolume()
		{
		}
	}
	[Token(Token = "0x2000280")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4340", Offset = "0x6E4340")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4340", Offset = "0x6E4340")]
	public class SetIgnoreListenerPause : Action
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4CC0", Offset = "0x6F4CC0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4CF8", Offset = "0x6F4CF8")]
		public SharedBool ignoreListenerPause;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xC8D4FC", Offset = "0xC8D4FC", VA = "0xC8D4FC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xC8D60C", Offset = "0xC8D60C", VA = "0xC8D60C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xC8D718", Offset = "0xC8D718", VA = "0xC8D718", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xC8D758", Offset = "0xC8D758", VA = "0xC8D758")]
		public SetIgnoreListenerPause()
		{
		}
	}
	[Token(Token = "0x2000281")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E43A0", Offset = "0x6E43A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E43A0", Offset = "0x6E43A0")]
	public class SetLoop : Action
	{
		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4D30", Offset = "0x6F4D30")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4D68", Offset = "0x6F4D68")]
		public SharedBool loop;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xC8FB74", Offset = "0xC8FB74", VA = "0xC8FB74", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xC8FC84", Offset = "0xC8FC84", VA = "0xC8FC84", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xC8FD90", Offset = "0xC8FD90", VA = "0xC8FD90", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xC8FDD0", Offset = "0xC8FDD0", VA = "0xC8FDD0")]
		public SetLoop()
		{
		}
	}
	[Token(Token = "0x2000282")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4400", Offset = "0x6E4400")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4400", Offset = "0x6E4400")]
	public class SetMaxDistance : Action
	{
		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4DA0", Offset = "0x6F4DA0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4DD8", Offset = "0x6F4DD8")]
		public SharedFloat maxDistance;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xC9076C", Offset = "0xC9076C", VA = "0xC9076C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xC9087C", Offset = "0xC9087C", VA = "0xC9087C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xC90984", Offset = "0xC90984", VA = "0xC90984", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xC909C4", Offset = "0xC909C4", VA = "0xC909C4")]
		public SetMaxDistance()
		{
		}
	}
	[Token(Token = "0x2000283")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4460", Offset = "0x6E4460")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4460", Offset = "0x6E4460")]
	public class SetMinDistance : Action
	{
		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4E10", Offset = "0x6F4E10")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4E48", Offset = "0x6F4E48")]
		public SharedFloat minDistance;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xC90C48", Offset = "0xC90C48", VA = "0xC90C48", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xC90D58", Offset = "0xC90D58", VA = "0xC90D58", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xC90E60", Offset = "0xC90E60", VA = "0xC90E60", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xC90EA0", Offset = "0xC90EA0", VA = "0xC90EA0")]
		public SetMinDistance()
		{
		}
	}
	[Token(Token = "0x2000284")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E44C0", Offset = "0x6E44C0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E44C0", Offset = "0x6E44C0")]
	public class SetMute : Action
	{
		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4E80", Offset = "0x6F4E80")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4EB8", Offset = "0x6F4EB8")]
		public SharedBool mute;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xC90EA8", Offset = "0xC90EA8", VA = "0xC90EA8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xC90FB8", Offset = "0xC90FB8", VA = "0xC90FB8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xC910C4", Offset = "0xC910C4", VA = "0xC910C4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xC91104", Offset = "0xC91104", VA = "0xC91104")]
		public SetMute()
		{
		}
	}
	[Token(Token = "0x2000285")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4520", Offset = "0x6E4520")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4520", Offset = "0x6E4520")]
	public class SetPitch : Action
	{
		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4EF0", Offset = "0x6F4EF0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4F28", Offset = "0x6F4F28")]
		public SharedFloat pitch;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xC915C8", Offset = "0xC915C8", VA = "0xC915C8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xC916D8", Offset = "0xC916D8", VA = "0xC916D8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xC917E0", Offset = "0xC917E0", VA = "0xC917E0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xC91820", Offset = "0xC91820", VA = "0xC91820")]
		public SetPitch()
		{
		}
	}
	[Token(Token = "0x2000286")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4580", Offset = "0x6E4580")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4580", Offset = "0x6E4580")]
	public class SetPriority : Action
	{
		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4F60", Offset = "0x6F4F60")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4F98", Offset = "0x6F4F98")]
		public SharedInt priority;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xC91F9C", Offset = "0xC91F9C", VA = "0xC91F9C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xC920AC", Offset = "0xC920AC", VA = "0xC920AC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xC921B8", Offset = "0xC921B8", VA = "0xC921B8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xC921F8", Offset = "0xC921F8", VA = "0xC921F8")]
		public SetPriority()
		{
		}
	}
	[Token(Token = "0x2000287")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E45E0", Offset = "0x6E45E0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E45E0", Offset = "0x6E45E0")]
	public class SetRolloffMode : Action
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F4FD0", Offset = "0x6F4FD0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5008", Offset = "0x6F5008")]
		public AudioRolloffMode rolloffMode;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xC93390", Offset = "0xC93390", VA = "0xC93390", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xC934A0", Offset = "0xC934A0", VA = "0xC934A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xC93584", Offset = "0xC93584", VA = "0xC93584", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xC935B4", Offset = "0xC935B4", VA = "0xC935B4")]
		public SetRolloffMode()
		{
		}
	}
	[Token(Token = "0x2000288")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4640", Offset = "0x6E4640")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4640", Offset = "0x6E4640")]
	public class SetScheduledEndTime : Action
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5040", Offset = "0x6F5040")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5078", Offset = "0x6F5078")]
		public SharedFloat time;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xC93A84", Offset = "0xC93A84", VA = "0xC93A84", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xC93B94", Offset = "0xC93B94", VA = "0xC93B94", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xC93CA0", Offset = "0xC93CA0", VA = "0xC93CA0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xC93CE0", Offset = "0xC93CE0", VA = "0xC93CE0")]
		public SetScheduledEndTime()
		{
		}
	}
	[Token(Token = "0x2000289")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E46A0", Offset = "0x6E46A0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E46A0", Offset = "0x6E46A0")]
	public class SetScheduledStartTime : Action
	{
		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F50B0", Offset = "0x6F50B0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F50E8", Offset = "0x6F50E8")]
		public SharedFloat time;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xC93D1C", Offset = "0xC93D1C", VA = "0xC93D1C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xC93E2C", Offset = "0xC93E2C", VA = "0xC93E2C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xC93F38", Offset = "0xC93F38", VA = "0xC93F38", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xC93F78", Offset = "0xC93F78", VA = "0xC93F78")]
		public SetScheduledStartTime()
		{
		}
	}
	[Token(Token = "0x200028A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4700", Offset = "0x6E4700")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4700", Offset = "0x6E4700")]
	public class SetSpread : Action
	{
		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5120", Offset = "0x6F5120")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5158", Offset = "0x6F5158")]
		public SharedFloat spread;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xC964A8", Offset = "0xC964A8", VA = "0xC964A8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xC965B8", Offset = "0xC965B8", VA = "0xC965B8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xC966C0", Offset = "0xC966C0", VA = "0xC966C0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xC96700", Offset = "0xC96700", VA = "0xC96700")]
		public SetSpread()
		{
		}
	}
	[Token(Token = "0x200028B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4760", Offset = "0x6E4760")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4760", Offset = "0x6E4760")]
	public class SetTime : Action
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5190", Offset = "0x6F5190")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F51C8", Offset = "0x6F51C8")]
		public SharedFloat time;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xC97C08", Offset = "0xC97C08", VA = "0xC97C08", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xC97D18", Offset = "0xC97D18", VA = "0xC97D18", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xC97E20", Offset = "0xC97E20", VA = "0xC97E20", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xC97E60", Offset = "0xC97E60", VA = "0xC97E60")]
		public SetTime()
		{
		}
	}
	[Token(Token = "0x200028C")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E47C0", Offset = "0x6E47C0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E47C0", Offset = "0x6E47C0")]
	public class SetVelocityUpdateMode : Action
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5200", Offset = "0x6F5200")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5238", Offset = "0x6F5238")]
		public AudioVelocityUpdateMode velocityUpdateMode;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xC99168", Offset = "0xC99168", VA = "0xC99168", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xC99278", Offset = "0xC99278", VA = "0xC99278", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xC9935C", Offset = "0xC9935C", VA = "0xC9935C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xC9938C", Offset = "0xC9938C", VA = "0xC9938C")]
		public SetVelocityUpdateMode()
		{
		}
	}
	[Token(Token = "0x200028D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4820", Offset = "0x6E4820")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4820", Offset = "0x6E4820")]
	public class SetVolume : Action
	{
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5270", Offset = "0x6F5270")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F52A8", Offset = "0x6F52A8")]
		public SharedFloat volume;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xC99394", Offset = "0xC99394", VA = "0xC99394", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xC994A4", Offset = "0xC994A4", VA = "0xC994A4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xC995AC", Offset = "0xC995AC", VA = "0xC995AC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xC995EC", Offset = "0xC995EC", VA = "0xC995EC")]
		public SetVolume()
		{
		}
	}
	[Token(Token = "0x200028E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4880", Offset = "0x6E4880")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4880", Offset = "0x6E4880")]
	public class Stop : Action
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F52E0", Offset = "0x6F52E0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xCA172C", Offset = "0xCA172C", VA = "0xCA172C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xCA183C", Offset = "0xCA183C", VA = "0xCA183C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xCA191C", Offset = "0xCA191C", VA = "0xCA191C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xCA1928", Offset = "0xCA1928", VA = "0xCA1928")]
		public Stop()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	[Token(Token = "0x200028F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E48E0", Offset = "0x6E48E0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E48E0", Offset = "0x6E48E0")]
	public class CrossFade : Action
	{
		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5318", Offset = "0x6F5318")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5350", Offset = "0x6F5350")]
		public SharedString stateName;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5388", Offset = "0x6F5388")]
		public SharedFloat transitionDuration;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F53C0", Offset = "0x6F53C0")]
		public int layer;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F53F8", Offset = "0x6F53F8")]
		public float normalizedTime;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x112B690", Offset = "0x112B690", VA = "0x112B690", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x112B7A0", Offset = "0x112B7A0", VA = "0x112B7A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x112B8E8", Offset = "0x112B8E8", VA = "0x112B8E8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x112B97C", Offset = "0x112B97C", VA = "0x112B97C")]
		public CrossFade()
		{
		}
	}
	[Token(Token = "0x2000290")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4940", Offset = "0x6E4940")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4940", Offset = "0x6E4940")]
	public class GetApplyRootMotion : Action
	{
		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5430", Offset = "0x6F5430")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5468", Offset = "0x6F5468")]
		public SharedBool storeValue;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xCC9230", Offset = "0xCC9230", VA = "0xCC9230", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xCC9340", Offset = "0xCC9340", VA = "0xCC9340", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xCC944C", Offset = "0xCC944C", VA = "0xCC944C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xCC9490", Offset = "0xCC9490", VA = "0xCC9490")]
		public GetApplyRootMotion()
		{
		}
	}
	[Token(Token = "0x2000291")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E49A0", Offset = "0x6E49A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E49A0", Offset = "0x6E49A0")]
	public class GetBoolParameter : Action
	{
		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F54B4", Offset = "0x6F54B4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F54EC", Offset = "0x6F54EC")]
		public SharedString paramaterName;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5524", Offset = "0x6F5524")]
		public SharedBool storeValue;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xCC9778", Offset = "0xCC9778", VA = "0xCC9778", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xCC9888", Offset = "0xCC9888", VA = "0xCC9888", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xCC99BC", Offset = "0xCC99BC", VA = "0xCC99BC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xCC9A44", Offset = "0xCC9A44", VA = "0xCC9A44")]
		public GetBoolParameter()
		{
		}
	}
	[Token(Token = "0x2000292")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4A00", Offset = "0x6E4A00")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4A00", Offset = "0x6E4A00")]
	public class GetDeltaPosition : Action
	{
		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5570", Offset = "0x6F5570")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F55A8", Offset = "0x6F55A8")]
		[RequiredField]
		public SharedVector3 storeValue;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xCCB28C", Offset = "0xCCB28C", VA = "0xCCB28C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xCCB39C", Offset = "0xCCB39C", VA = "0xCCB39C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xCCB4A4", Offset = "0xCCB4A4", VA = "0xCCB4A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xCCB4EC", Offset = "0xCCB4EC", VA = "0xCCB4EC")]
		public GetDeltaPosition()
		{
		}
	}
	[Token(Token = "0x2000293")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4A60", Offset = "0x6E4A60")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4A60", Offset = "0x6E4A60")]
	public class GetDeltaRotation : Action
	{
		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F55F4", Offset = "0x6F55F4")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F562C", Offset = "0x6F562C")]
		[RequiredField]
		public SharedQuaternion storeValue;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xCCB4F4", Offset = "0xCCB4F4", VA = "0xCCB4F4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xCCB604", Offset = "0xCCB604", VA = "0xCCB604", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xCCB70C", Offset = "0xCCB70C", VA = "0xCCB70C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xCCB774", Offset = "0xCCB774", VA = "0xCCB774")]
		public GetDeltaRotation()
		{
		}
	}
	[Token(Token = "0x2000294")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4AC0", Offset = "0x6E4AC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4AC0", Offset = "0x6E4AC0")]
	public class GetFloatParameter : Action
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5678", Offset = "0x6F5678")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F56B0", Offset = "0x6F56B0")]
		public SharedString paramaterName;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F56E8", Offset = "0x6F56E8")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xCCD2E4", Offset = "0xCCD2E4", VA = "0xCCD2E4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xCCD3F4", Offset = "0xCCD3F4", VA = "0xCCD3F4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xCCD524", Offset = "0xCCD524", VA = "0xCCD524", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xCCD5AC", Offset = "0xCCD5AC", VA = "0xCCD5AC")]
		public GetFloatParameter()
		{
		}
	}
	[Token(Token = "0x2000295")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4B20", Offset = "0x6E4B20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4B20", Offset = "0x6E4B20")]
	public class GetGravityWeight : Action
	{
		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5734", Offset = "0x6F5734")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F576C", Offset = "0x6F576C")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xCCDD90", Offset = "0xCCDD90", VA = "0xCCDD90", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xCCDEA0", Offset = "0xCCDEA0", VA = "0xCCDEA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xCCDFA8", Offset = "0xCCDFA8", VA = "0xCCDFA8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xCCDFEC", Offset = "0xCCDFEC", VA = "0xCCDFEC")]
		public GetGravityWeight()
		{
		}
	}
	[Token(Token = "0x2000296")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4B80", Offset = "0x6E4B80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4B80", Offset = "0x6E4B80")]
	public class GetIntegerParameter : Action
	{
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F57B8", Offset = "0x6F57B8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F57F0", Offset = "0x6F57F0")]
		public SharedString paramaterName;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5828", Offset = "0x6F5828")]
		public SharedInt storeValue;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xCCEAEC", Offset = "0xCCEAEC", VA = "0xCCEAEC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xCCEBFC", Offset = "0xCCEBFC", VA = "0xCCEBFC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xCCED30", Offset = "0xCCED30", VA = "0xCCED30", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xCCEDB8", Offset = "0xCCEDB8", VA = "0xCCEDB8")]
		public GetIntegerParameter()
		{
		}
	}
	[Token(Token = "0x2000297")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4BE0", Offset = "0x6E4BE0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4BE0", Offset = "0x6E4BE0")]
	public class GetLayerWeight : Action
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5874", Offset = "0x6F5874")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F58AC", Offset = "0x6F58AC")]
		public SharedInt index;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F58E4", Offset = "0x6F58E4")]
		public SharedFloat storeValue;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xCCF90C", Offset = "0xCCF90C", VA = "0xCCF90C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xCCFA1C", Offset = "0xCCFA1C", VA = "0xCCFA1C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xCCFB4C", Offset = "0xCCFB4C", VA = "0xCCFB4C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xCCFBAC", Offset = "0xCCFBAC", VA = "0xCCFBAC")]
		public GetLayerWeight()
		{
		}
	}
	[Token(Token = "0x2000298")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4C40", Offset = "0x6E4C40")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4C40", Offset = "0x6E4C40")]
	public class GetSpeed : Action
	{
		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5930", Offset = "0x6F5930")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5968", Offset = "0x6F5968")]
		[RequiredField]
		public SharedFloat storeValue;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xCD5CF8", Offset = "0xCD5CF8", VA = "0xCD5CF8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xCD5E08", Offset = "0xCD5E08", VA = "0xCD5E08", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xCD5F10", Offset = "0xCD5F10", VA = "0xCD5F10", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xCD5F54", Offset = "0xCD5F54", VA = "0xCD5F54")]
		public GetSpeed()
		{
		}
	}
	[Token(Token = "0x2000299")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4CA0", Offset = "0x6E4CA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4CA0", Offset = "0x6E4CA0")]
	public class GetStringToHash : Action
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F59B4", Offset = "0x6F59B4")]
		public SharedString stateName;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F59EC", Offset = "0x6F59EC")]
		[RequiredField]
		public SharedInt storeValue;

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xCD6C30", Offset = "0xCD6C30", VA = "0xCD6C30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xCD6CC0", Offset = "0xCD6CC0", VA = "0xCD6CC0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xCD6D38", Offset = "0xCD6D38", VA = "0xCD6D38")]
		public GetStringToHash()
		{
		}
	}
	[Token(Token = "0x200029A")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4D00", Offset = "0x6E4D00")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4D00", Offset = "0x6E4D00")]
	public class InterruptMatchTarget : Action
	{
		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5A38", Offset = "0x6F5A38")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5A70", Offset = "0x6F5A70")]
		public bool completeMatch;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xFBFBB8", Offset = "0xFBFBB8", VA = "0xFBFBB8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xFBFCC8", Offset = "0xFBFCC8", VA = "0xFBFCC8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xFBFDAC", Offset = "0xFBFDAC", VA = "0xFBFDAC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xFBFDE0", Offset = "0xFBFDE0", VA = "0xFBFDE0")]
		public InterruptMatchTarget()
		{
		}
	}
	[Token(Token = "0x200029B")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4D60", Offset = "0x6E4D60")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4D60", Offset = "0x6E4D60")]
	public class IsInTransition : Conditional
	{
		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5AA8", Offset = "0x6F5AA8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5AE0", Offset = "0x6F5AE0")]
		public SharedInt index;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xFC0F3C", Offset = "0xFC0F3C", VA = "0xFC0F3C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xFC104C", Offset = "0xFC104C", VA = "0xFC104C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xFC1160", Offset = "0xFC1160", VA = "0xFC1160", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xFC11A4", Offset = "0xFC11A4", VA = "0xFC11A4")]
		public IsInTransition()
		{
		}
	}
	[Token(Token = "0x200029C")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4DC0", Offset = "0x6E4DC0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4DC0", Offset = "0x6E4DC0")]
	public class IsName : Conditional
	{
		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5B18", Offset = "0x6F5B18")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5B50", Offset = "0x6F5B50")]
		public SharedInt index;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5B88", Offset = "0x6F5B88")]
		public SharedString name;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xFC1824", Offset = "0xFC1824", VA = "0xFC1824", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xFC1934", Offset = "0xFC1934", VA = "0xFC1934", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xFC1AA8", Offset = "0xFC1AA8", VA = "0xFC1AA8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xFC1B30", Offset = "0xFC1B30", VA = "0xFC1B30")]
		public IsName()
		{
		}
	}
	[Token(Token = "0x200029D")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4E20", Offset = "0x6E4E20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4E20", Offset = "0x6E4E20")]
	public class IsParameterControlledByCurve : Conditional
	{
		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5BC0", Offset = "0x6F5BC0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5BF8", Offset = "0x6F5BF8")]
		public SharedString paramaterName;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xFC1C08", Offset = "0xFC1C08", VA = "0xFC1C08", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xFC1D18", Offset = "0xFC1D18", VA = "0xFC1D18", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xFC1E2C", Offset = "0xFC1E2C", VA = "0xFC1E2C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xFC1E98", Offset = "0xFC1E98", VA = "0xFC1E98")]
		public IsParameterControlledByCurve()
		{
		}
	}
	[Token(Token = "0x200029E")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4E80", Offset = "0x6E4E80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4E80", Offset = "0x6E4E80")]
	public class MatchTarget : Action
	{
		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5C30", Offset = "0x6F5C30")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5C68", Offset = "0x6F5C68")]
		public SharedVector3 matchPosition;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5CA0", Offset = "0x6F5CA0")]
		public SharedQuaternion matchRotation;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5CD8", Offset = "0x6F5CD8")]
		public AvatarTarget targetBodyPart;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5D10", Offset = "0x6F5D10")]
		public Vector3 weightMaskPosition;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5D48", Offset = "0x6F5D48")]
		public float weightMaskRotation;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5D80", Offset = "0x6F5D80")]
		public float startNormalizedTime;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5DB8", Offset = "0x6F5DB8")]
		public float targetNormalizedTime;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Animator animator;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xFC7304", Offset = "0xFC7304", VA = "0xFC7304", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xFC7414", Offset = "0xFC7414", VA = "0xFC7414", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xFC75E8", Offset = "0xFC75E8", VA = "0xFC75E8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xFC7674", Offset = "0xFC7674", VA = "0xFC7674")]
		public MatchTarget()
		{
		}
	}
	[Token(Token = "0x200029F")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4EE0", Offset = "0x6E4EE0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4EE0", Offset = "0x6E4EE0")]
	public class Play : Action
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5DF0", Offset = "0x6F5DF0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5E28", Offset = "0x6F5E28")]
		public SharedString stateName;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5E60", Offset = "0x6F5E60")]
		public int layer;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5E98", Offset = "0x6F5E98")]
		public float normalizedTime;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xFCDA50", Offset = "0xFCDA50", VA = "0xFCDA50", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xFCDB60", Offset = "0xFCDB60", VA = "0xFCDB60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xFCDC74", Offset = "0xFCDC74", VA = "0xFCDC74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xFCDCEC", Offset = "0xFCDCEC", VA = "0xFCDCEC")]
		public Play()
		{
		}
	}
	[Token(Token = "0x20002A0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4F40", Offset = "0x6E4F40")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4F40", Offset = "0x6E4F40")]
	public class SetApplyRootMotion : Action
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5ED0", Offset = "0x6F5ED0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5F08", Offset = "0x6F5F08")]
		public SharedBool rootMotion;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xC88978", Offset = "0xC88978", VA = "0xC88978", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xC88A88", Offset = "0xC88A88", VA = "0xC88A88", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xC88B94", Offset = "0xC88B94", VA = "0xC88B94", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xC88C3C", Offset = "0xC88C3C", VA = "0xC88C3C")]
		public SetApplyRootMotion()
		{
		}
	}
	[Token(Token = "0x20002A1")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E4FA0", Offset = "0x6E4FA0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E4FA0", Offset = "0x6E4FA0")]
	public class SetBoolParameter : Action
	{
		[Token(Token = "0x20002A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5000", Offset = "0x6E5000")]
		private sealed class <ResetValue>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SetBoolParameter <>4__this;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool origVale;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009B7")]
				[Address(RVA = "0x18DFEF4", Offset = "0x18DFEF4", VA = "0x18DFEF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B9")]
				[Address(RVA = "0x18DFF3C", Offset = "0x18DFF3C", VA = "0x18DFF3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x18DFE44", Offset = "0x18DFE44", VA = "0x18DFE44")]
			[DebuggerHidden]
			public <ResetValue>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x18DFE70", Offset = "0x18DFE70", VA = "0x18DFE70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x18DFE74", Offset = "0x18DFE74", VA = "0x18DFE74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x18DFEFC", Offset = "0x18DFEFC", VA = "0x18DFEFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5F40", Offset = "0x6F5F40")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5F78", Offset = "0x6F5F78")]
		public SharedString paramaterName;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5FB0", Offset = "0x6F5FB0")]
		public SharedBool boolValue;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F5FE8", Offset = "0x6F5FE8")]
		public bool setOnce;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int hashID;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xC88F34", Offset = "0xC88F34", VA = "0xC88F34", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xC89044", Offset = "0xC89044", VA = "0xC89044", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xC891D4", Offset = "0xC891D4", VA = "0xC891D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F95BC", Offset = "0x6F95BC")]
		public IEnumerator ResetValue(bool origVale)
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xC89260", Offset = "0xC89260", VA = "0xC89260", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xC89350", Offset = "0xC89350", VA = "0xC89350")]
		public SetBoolParameter()
		{
		}
	}
	[Token(Token = "0x20002A3")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5010", Offset = "0x6E5010")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5010", Offset = "0x6E5010")]
	public class SetFloatParameter : Action
	{
		[Token(Token = "0x20002A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5070", Offset = "0x6E5070")]
		private sealed class <ResetValue>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SetFloatParameter <>4__this;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float origVale;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x18DFFF4", Offset = "0x18DFFF4", VA = "0x18DFFF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x18E003C", Offset = "0x18E003C", VA = "0x18E003C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x18DFF44", Offset = "0x18DFF44", VA = "0x18DFF44")]
			[DebuggerHidden]
			public <ResetValue>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x18DFF70", Offset = "0x18DFF70", VA = "0x18DFF70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x18DFF74", Offset = "0x18DFF74", VA = "0x18DFF74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x18DFFFC", Offset = "0x18DFFFC", VA = "0x18DFFFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6020", Offset = "0x6F6020")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6058", Offset = "0x6F6058")]
		public SharedString paramaterName;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6090", Offset = "0x6F6090")]
		public SharedFloat floatValue;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F60C8", Offset = "0x6F60C8")]
		public bool setOnce;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int hashID;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xC8C564", Offset = "0xC8C564", VA = "0xC8C564", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xC8C674", Offset = "0xC8C674", VA = "0xC8C674", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xC8C804", Offset = "0xC8C804", VA = "0xC8C804")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F966C", Offset = "0x6F966C")]
		public IEnumerator ResetValue(float origVale)
		{
			return null;
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xC8C88C", Offset = "0xC8C88C", VA = "0xC8C88C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xC8C90C", Offset = "0xC8C90C", VA = "0xC8C90C")]
		public SetFloatParameter()
		{
		}
	}
	[Token(Token = "0x20002A5")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5080", Offset = "0x6E5080")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5080", Offset = "0x6E5080")]
	public class SetIntegerParameter : Action
	{
		[Token(Token = "0x20002A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50E0", Offset = "0x6E50E0")]
		private sealed class <ResetValue>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SetIntegerParameter <>4__this;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int origVale;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x18E00F4", Offset = "0x18E00F4", VA = "0x18E00F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0x18E013C", Offset = "0x18E013C", VA = "0x18E013C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x18E0044", Offset = "0x18E0044", VA = "0x18E0044")]
			[DebuggerHidden]
			public <ResetValue>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x18E0070", Offset = "0x18E0070", VA = "0x18E0070", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x18E0074", Offset = "0x18E0074", VA = "0x18E0074", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x18E00FC", Offset = "0x18E00FC", VA = "0x18E00FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6100", Offset = "0x6F6100")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6138", Offset = "0x6F6138")]
		public SharedString paramaterName;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6170", Offset = "0x6F6170")]
		public SharedInt intValue;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F61A8", Offset = "0x6F61A8")]
		public bool setOnce;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int hashID;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xC8DBAC", Offset = "0xC8DBAC", VA = "0xC8DBAC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xC8DCBC", Offset = "0xC8DCBC", VA = "0xC8DCBC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xC8DE4C", Offset = "0xC8DE4C", VA = "0xC8DE4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F971C", Offset = "0x6F971C")]
		public IEnumerator ResetValue(int origVale)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xC8DED4", Offset = "0xC8DED4", VA = "0xC8DED4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xC8DF54", Offset = "0xC8DF54", VA = "0xC8DF54")]
		public SetIntegerParameter()
		{
		}
	}
	[Token(Token = "0x20002A7")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E50F0", Offset = "0x6E50F0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E50F0", Offset = "0x6E50F0")]
	public class SetLayerWeight : Action
	{
		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F61E0", Offset = "0x6F61E0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6218", Offset = "0x6F6218")]
		public SharedInt index;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6250", Offset = "0x6F6250")]
		public SharedFloat weight;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xC8EA34", Offset = "0xC8EA34", VA = "0xC8EA34", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xC8EB44", Offset = "0xC8EB44", VA = "0xC8EB44", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xC8EC7C", Offset = "0xC8EC7C", VA = "0xC8EC7C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xC8ECD4", Offset = "0xC8ECD4", VA = "0xC8ECD4")]
		public SetLayerWeight()
		{
		}
	}
	[Token(Token = "0x20002A8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5150", Offset = "0x6E5150")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5150", Offset = "0x6E5150")]
	public class SetLookAtPosition : Action
	{
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6288", Offset = "0x6F6288")]
		public SharedVector3 position;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator animator;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionSet;

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xC8F6F0", Offset = "0xC8F6F0", VA = "0xC8F6F0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xC8F754", Offset = "0xC8F754", VA = "0xC8F754", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xC8F82C", Offset = "0xC8F82C", VA = "0xC8F82C", Slot = "28")]
		public override void OnAnimatorIK()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xC8F8E4", Offset = "0xC8F8E4", VA = "0xC8F8E4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xC8F918", Offset = "0xC8F918", VA = "0xC8F918")]
		public SetLookAtPosition()
		{
		}
	}
	[Token(Token = "0x20002A9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E51B0", Offset = "0x6E51B0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E51B0", Offset = "0x6E51B0")]
	public class SetLookAtWeight : Action
	{
		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F62C0", Offset = "0x6F62C0")]
		public SharedFloat weight;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F62F8", Offset = "0x6F62F8")]
		public float bodyWeight;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6330", Offset = "0x6F6330")]
		public float headWeight;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6368", Offset = "0x6F6368")]
		public float eyesWeight;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F63A0", Offset = "0x6F63A0")]
		public float clampWeight;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool weightSet;

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xC8F920", Offset = "0xC8F920", VA = "0xC8F920", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xC8F984", Offset = "0xC8F984", VA = "0xC8F984", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xC8FA5C", Offset = "0xC8FA5C", VA = "0xC8FA5C", Slot = "28")]
		public override void OnAnimatorIK()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xC8FB1C", Offset = "0xC8FB1C", VA = "0xC8FB1C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xC8FB5C", Offset = "0xC8FB5C", VA = "0xC8FB5C")]
		public SetLookAtWeight()
		{
		}
	}
	[Token(Token = "0x20002AA")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5210", Offset = "0x6E5210")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5210", Offset = "0x6E5210")]
	public class SetSpeed : Action
	{
		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F63D8", Offset = "0x6F63D8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6410", Offset = "0x6F6410")]
		public SharedFloat speed;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xC95D88", Offset = "0xC95D88", VA = "0xC95D88", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xC95E98", Offset = "0xC95E98", VA = "0xC95E98", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xC95FA0", Offset = "0xC95FA0", VA = "0xC95FA0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xC95FE0", Offset = "0xC95FE0", VA = "0xC95FE0")]
		public SetSpeed()
		{
		}
	}
	[Token(Token = "0x20002AB")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5270", Offset = "0x6E5270")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5270", Offset = "0x6E5270")]
	public class SetTrigger : Action
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6448", Offset = "0x6F6448")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6480", Offset = "0x6F6480")]
		public SharedString paramaterName;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xC9818C", Offset = "0xC9818C", VA = "0xC9818C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xC9829C", Offset = "0xC9829C", VA = "0xC9829C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xC983A8", Offset = "0xC983A8", VA = "0xC983A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xC98410", Offset = "0xC98410", VA = "0xC98410")]
		public SetTrigger()
		{
		}
	}
	[Token(Token = "0x20002AC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E52D0", Offset = "0x6E52D0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E52D0", Offset = "0x6E52D0")]
	public class StartPlayback : Action
	{
		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F64B8", Offset = "0x6F64B8")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator animator;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xCA0E34", Offset = "0xCA0E34", VA = "0xCA0E34", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xCA0F44", Offset = "0xCA0F44", VA = "0xCA0F44", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xCA1024", Offset = "0xCA1024", VA = "0xCA1024", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xCA1030", Offset = "0xCA1030", VA = "0xCA1030")]
		public StartPlayback()
		{
		}
	}
	[Token(Token = "0x20002AD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5330", Offset = "0x6E5330")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5330", Offset = "0x6E5330")]
	public class StartRecording : Action
	{
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F64F0", Offset = "0x6F64F0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6528", Offset = "0x6F6528")]
		public int frameCount;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xCA1038", Offset = "0xCA1038", VA = "0xCA1038", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xCA1148", Offset = "0xCA1148", VA = "0xCA1148", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xCA122C", Offset = "0xCA122C", VA = "0xCA122C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xCA125C", Offset = "0xCA125C", VA = "0xCA125C")]
		public StartRecording()
		{
		}
	}
	[Token(Token = "0x20002AE")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5390", Offset = "0x6E5390")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5390", Offset = "0x6E5390")]
	public class StopPlayback : Action
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6560", Offset = "0x6F6560")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator animator;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xCA2044", Offset = "0xCA2044", VA = "0xCA2044", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xCA2154", Offset = "0xCA2154", VA = "0xCA2154", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xCA2234", Offset = "0xCA2234", VA = "0xCA2234", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xCA2240", Offset = "0xCA2240", VA = "0xCA2240")]
		public StopPlayback()
		{
		}
	}
	[Token(Token = "0x20002AF")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E53F0", Offset = "0x6E53F0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E53F0", Offset = "0x6E53F0")]
	public class StopRecording : Action
	{
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6598", Offset = "0x6F6598")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator animator;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xCA2248", Offset = "0xCA2248", VA = "0xCA2248", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xCA2358", Offset = "0xCA2358", VA = "0xCA2358", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xCA2438", Offset = "0xCA2438", VA = "0xCA2438", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xCA2444", Offset = "0xCA2444", VA = "0xCA2444")]
		public StopRecording()
		{
		}
	}
	[Token(Token = "0x20002B0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5450", Offset = "0x6E5450")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5450", Offset = "0x6E5450")]
	public class WaitForState : Action
	{
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F65D0", Offset = "0x6F65D0")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6608", Offset = "0x6F6608")]
		public SharedString stateName;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6640", Offset = "0x6F6640")]
		public SharedInt layer;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator animator;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int stateHash;

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x18DBDC8", Offset = "0x18DBDC8", VA = "0x18DBDC8", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x18DBE2C", Offset = "0x18DBE2C", VA = "0x18DBE2C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x18DC054", Offset = "0x18DC054", VA = "0x18DC054", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x18DC1A4", Offset = "0x18DC1A4", VA = "0x18DC1A4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x18DC22C", Offset = "0x18DC22C", VA = "0x18DC22C")]
		public WaitForState()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	[Token(Token = "0x20002B1")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E54B0", Offset = "0x6E54B0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E54B0", Offset = "0x6E54B0")]
	public class Blend : Action
	{
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6678", Offset = "0x6F6678")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F66B0", Offset = "0x6F66B0")]
		public SharedString animationName;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F66E8", Offset = "0x6F66E8")]
		public float targetWeight;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6720", Offset = "0x6F6720")]
		public float fadeLength;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animation animation;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x111D330", Offset = "0x111D330", VA = "0x111D330", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x111D440", Offset = "0x111D440", VA = "0x111D440", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x111D550", Offset = "0x111D550", VA = "0x111D550", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x111D5CC", Offset = "0x111D5CC", VA = "0x111D5CC")]
		public Blend()
		{
		}
	}
	[Token(Token = "0x20002B2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5510", Offset = "0x6E5510")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5510", Offset = "0x6E5510")]
	public class CrossFade : Action
	{
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6758", Offset = "0x6F6758")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6790", Offset = "0x6F6790")]
		public SharedString animationName;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F67C8", Offset = "0x6F67C8")]
		public SharedFloat animationSpeed;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6800", Offset = "0x6F6800")]
		public SharedFloat fadeLength;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6838", Offset = "0x6F6838")]
		public PlayMode playMode;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animation animation;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x112B210", Offset = "0x112B210", VA = "0x112B210", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x112B320", Offset = "0x112B320", VA = "0x112B320", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x112B56C", Offset = "0x112B56C", VA = "0x112B56C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x112B630", Offset = "0x112B630", VA = "0x112B630")]
		public CrossFade()
		{
		}
	}
	[Token(Token = "0x20002B3")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5570", Offset = "0x6E5570")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5570", Offset = "0x6E5570")]
	public class CrossFadeQueued : Action
	{
		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6870", Offset = "0x6F6870")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F68A8", Offset = "0x6F68A8")]
		public SharedString animationName;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F68E0", Offset = "0x6F68E0")]
		public float fadeLength;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6918", Offset = "0x6F6918")]
		public QueueMode queue;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6950", Offset = "0x6F6950")]
		public PlayMode playMode;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animation animation;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x112B98C", Offset = "0x112B98C", VA = "0x112B98C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x112BA9C", Offset = "0x112BA9C", VA = "0x112BA9C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x112BBB0", Offset = "0x112BBB0", VA = "0x112BBB0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x112BC44", Offset = "0x112BC44", VA = "0x112BC44")]
		public CrossFadeQueued()
		{
		}
	}
	[Token(Token = "0x20002B4")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E55D0", Offset = "0x6E55D0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E55D0", Offset = "0x6E55D0")]
	public class GetAnimatePhysics : Action
	{
		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6988", Offset = "0x6F6988")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F69C0", Offset = "0x6F69C0")]
		public SharedBool storeValue;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animation animation;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xCC8FA4", Offset = "0xCC8FA4", VA = "0xCC8FA4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xCC90B4", Offset = "0xCC90B4", VA = "0xCC90B4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xCC91C0", Offset = "0xCC91C0", VA = "0xCC91C0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xCC9228", Offset = "0xCC9228", VA = "0xCC9228")]
		public GetAnimatePhysics()
		{
		}
	}
	[Token(Token = "0x20002B5")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5630", Offset = "0x6E5630")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5630", Offset = "0x6E5630")]
	public class IsPlaying : Conditional
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6A0C", Offset = "0x6F6A0C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6A44", Offset = "0x6F6A44")]
		public SharedString animationName;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animation animation;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xFC24C4", Offset = "0xFC24C4", VA = "0xFC24C4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xFC25D4", Offset = "0xFC25D4", VA = "0xFC25D4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xFC2720", Offset = "0xFC2720", VA = "0xFC2720", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xFC279C", Offset = "0xFC279C", VA = "0xFC279C")]
		public IsPlaying()
		{
		}
	}
	[Token(Token = "0x20002B6")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5690", Offset = "0x6E5690")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5690", Offset = "0x6E5690")]
	public class Play : Action
	{
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6A7C", Offset = "0x6F6A7C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6AB4", Offset = "0x6F6AB4")]
		public SharedString animationName;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6AEC", Offset = "0x6F6AEC")]
		public PlayMode playMode;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animation animation;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xFCD768", Offset = "0xFCD768", VA = "0xFCD768", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xFCD878", Offset = "0xFCD878", VA = "0xFCD878", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xFCD9C0", Offset = "0xFCD9C0", VA = "0xFCD9C0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xFCDA48", Offset = "0xFCDA48", VA = "0xFCDA48")]
		public Play()
		{
		}
	}
	[Token(Token = "0x20002B7")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E56F0", Offset = "0x6E56F0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E56F0", Offset = "0x6E56F0")]
	public class PlayQueued : Action
	{
		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6B24", Offset = "0x6F6B24")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6B5C", Offset = "0x6F6B5C")]
		public SharedString animationName;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6B94", Offset = "0x6F6B94")]
		public QueueMode queue;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6BCC", Offset = "0x6F6BCC")]
		public PlayMode playMode;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animation animation;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xFCE6A8", Offset = "0xFCE6A8", VA = "0xFCE6A8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xFCE7B8", Offset = "0xFCE7B8", VA = "0xFCE7B8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xFCE8C8", Offset = "0xFCE8C8", VA = "0xFCE8C8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xFCE950", Offset = "0xFCE950", VA = "0xFCE950")]
		public PlayQueued()
		{
		}
	}
	[Token(Token = "0x20002B8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5750", Offset = "0x6E5750")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5750", Offset = "0x6E5750")]
	public class Rewind : Action
	{
		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6C04", Offset = "0x6F6C04")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6C3C", Offset = "0x6F6C3C")]
		public SharedString animationName;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animation animation;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xFD1DA8", Offset = "0xFD1DA8", VA = "0xFD1DA8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xFD1EB8", Offset = "0xFD1EB8", VA = "0xFD1EB8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xFD1FFC", Offset = "0xFD1FFC", VA = "0xFD1FFC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xFD2078", Offset = "0xFD2078", VA = "0xFD2078")]
		public Rewind()
		{
		}
	}
	[Token(Token = "0x20002B9")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E57B0", Offset = "0x6E57B0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E57B0", Offset = "0x6E57B0")]
	public class Sample : Action
	{
		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6C74", Offset = "0x6F6C74")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animation animation;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xFD2EB8", Offset = "0xFD2EB8", VA = "0xFD2EB8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xFD2FC8", Offset = "0xFD2FC8", VA = "0xFD2FC8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xFD30A8", Offset = "0xFD30A8", VA = "0xFD30A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xFD30B4", Offset = "0xFD30B4", VA = "0xFD30B4")]
		public Sample()
		{
		}
	}
	[Token(Token = "0x20002BA")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5810", Offset = "0x6E5810")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5810", Offset = "0x6E5810")]
	public class SetAnimatePhysics : Action
	{
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6CAC", Offset = "0x6F6CAC")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6CE4", Offset = "0x6F6CE4")]
		public SharedBool animatePhysics;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animation animation;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xC886EC", Offset = "0xC886EC", VA = "0xC886EC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xC887FC", Offset = "0xC887FC", VA = "0xC887FC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xC88908", Offset = "0xC88908", VA = "0xC88908", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xC88970", Offset = "0xC88970", VA = "0xC88970")]
		public SetAnimatePhysics()
		{
		}
	}
	[Token(Token = "0x20002BB")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5870", Offset = "0x6E5870")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5870", Offset = "0x6E5870")]
	public class SetWrapMode : Action
	{
		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6D1C", Offset = "0x6F6D1C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6D54", Offset = "0x6F6D54")]
		public WrapMode wrapMode;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animation animation;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xC995F4", Offset = "0xC995F4", VA = "0xC995F4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xC99704", Offset = "0xC99704", VA = "0xC99704", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xC997E8", Offset = "0xC997E8", VA = "0xC997E8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xC99818", Offset = "0xC99818", VA = "0xC99818")]
		public SetWrapMode()
		{
		}
	}
	[Token(Token = "0x20002BC")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E58D0", Offset = "0x6E58D0")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E58D0", Offset = "0x6E58D0")]
	public class Stop : Action
	{
		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6D8C", Offset = "0x6F6D8C")]
		public SharedGameObject targetGameObject;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6DC4", Offset = "0x6F6DC4")]
		public SharedString animationName;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animation animation;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xCA1468", Offset = "0xCA1468", VA = "0xCA1468", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xCA1578", Offset = "0xCA1578", VA = "0xCA1578", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xCA16BC", Offset = "0xCA16BC", VA = "0xCA16BC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xCA1724", Offset = "0xCA1724", VA = "0xCA1724")]
		public Stop()
		{
		}
	}
}
namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	[Token(Token = "0x20002BD")]
	public abstract class GroupMovement : Action
	{
		[Token(Token = "0x6000A2B")]
		protected abstract bool SetDestination(int index, Vector3 target);

		[Token(Token = "0x6000A2C")]
		protected abstract Vector3 Velocity(int index);

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xCD8D80", Offset = "0xCD8D80", VA = "0xCD8D80")]
		protected GroupMovement()
		{
		}
	}
	[Token(Token = "0x20002BE")]
	public abstract class Movement : Action
	{
		[Token(Token = "0x6000A2E")]
		protected abstract bool SetDestination(Vector3 destination);

		[Token(Token = "0x6000A2F")]
		protected abstract void UpdateRotation(bool update);

		[Token(Token = "0x6000A30")]
		protected abstract bool HasPath();

		[Token(Token = "0x6000A31")]
		protected abstract Vector3 Velocity();

		[Token(Token = "0x6000A32")]
		protected abstract bool HasArrived();

		[Token(Token = "0x6000A33")]
		protected abstract void Stop();

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xFC8CCC", Offset = "0xFC8CCC", VA = "0xFC8CCC")]
		protected Movement()
		{
		}
	}
	[Token(Token = "0x20002BF")]
	public static class MovementUtility
	{
		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<GameObject, Dictionary<Type, Component>> gameObjectComponentMap;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<GameObject, Dictionary<Type, Component>> gameObjectParentComponentMap;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<GameObject, Dictionary<Type, Component[]>> gameObjectComponentsMap;

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xFC8CD4", Offset = "0xFC8CD4", VA = "0xFC8CD4")]
		public static GameObject WithinSight(Transform transform, Vector3 positionOffset, float fieldOfViewAngle, float viewDistance, Collider[] overlapColliders, LayerMask objectLayerMask, Vector3 targetOffset, LayerMask ignoreLayerMask, bool useTargetBone, HumanBodyBones targetBone, bool drawDebugRay)
		{
			return null;
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xFC9430", Offset = "0xFC9430", VA = "0xFC9430")]
		public static GameObject WithinSight2D(Transform transform, Vector3 positionOffset, float fieldOfViewAngle, float viewDistance, Collider2D[] overlapColliders, LayerMask objectLayerMask, Vector3 targetOffset, float angleOffset2D, LayerMask ignoreLayerMask, bool drawDebugRay)
		{
			return null;
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xFC96A4", Offset = "0xFC96A4", VA = "0xFC96A4")]
		public static GameObject WithinSight(Transform transform, Vector3 positionOffset, float fieldOfViewAngle, float viewDistance, GameObject targetObject, Vector3 targetOffset, LayerMask ignoreLayerMask, bool useTargetBone, HumanBodyBones targetBone, bool drawDebugRay)
		{
			return null;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xFC97D4", Offset = "0xFC97D4", VA = "0xFC97D4")]
		public static GameObject WithinSight2D(Transform transform, Vector3 positionOffset, float fieldOfViewAngle, float viewDistance, GameObject targetObject, Vector3 targetOffset, float angleOffset2D, LayerMask ignoreLayerMask, bool useTargetBone, HumanBodyBones targetBone, bool drawDebugRay)
		{
			return null;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xFC8F38", Offset = "0xFC8F38", VA = "0xFC8F38")]
		public static GameObject WithinSight(Transform transform, Vector3 positionOffset, float fieldOfViewAngle, float viewDistance, GameObject targetObject, Vector3 targetOffset, bool usePhysics2D, float angleOffset2D, out float angle, int ignoreLayerMask, bool useTargetBone, HumanBodyBones targetBone, bool drawDebugRay)
		{
			return null;
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xFC9908", Offset = "0xFC9908", VA = "0xFC9908")]
		public static Transform LineOfSight(Transform transform, Vector3 positionOffset, GameObject targetObject, Vector3 targetOffset, bool usePhysics2D, int ignoreLayerMask, bool drawDebugRay)
		{
			return null;
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xFC9B10", Offset = "0xFC9B10", VA = "0xFC9B10")]
		public static bool IsAncestor(Transform target, Transform hitTransform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xFC9B6C", Offset = "0xFC9B6C", VA = "0xFC9B6C")]
		public static GameObject WithinHearingRange(Transform transform, Vector3 positionOffset, float audibilityThreshold, float hearingRadius, Collider[] overlapColliders, LayerMask objectLayerMask)
		{
			return null;
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xFC9FB8", Offset = "0xFC9FB8", VA = "0xFC9FB8")]
		public static GameObject WithinHearingRange2D(Transform transform, Vector3 positionOffset, float audibilityThreshold, float hearingRadius, Collider2D[] overlapColliders, LayerMask objectLayerMask)
		{
			return null;
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xFCA1D4", Offset = "0xFCA1D4", VA = "0xFCA1D4")]
		public static GameObject WithinHearingRange(Transform transform, Vector3 positionOffset, float audibilityThreshold, GameObject targetObject)
		{
			return null;
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xFC9D60", Offset = "0xFC9D60", VA = "0xFC9D60")]
		public static GameObject WithinHearingRange(Transform transform, Vector3 positionOffset, float audibilityThreshold, GameObject targetObject, ref float audibility)
		{
			return null;
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xFCA268", Offset = "0xFCA268", VA = "0xFCA268")]
		public static void DrawLineOfSight(Transform transform, Vector3 positionOffset, float fieldOfViewAngle, float angleOffset, float viewDistance, bool usePhysics2D)
		{
		}

		[Token(Token = "0x6000A41")]
		public static T GetComponentForType<T>(GameObject target) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000A42")]
		public static T GetParentComponentForType<T>(GameObject target) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000A43")]
		public static T[] GetComponentsForType<T>(GameObject target) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xFCA26C", Offset = "0xFCA26C", VA = "0xFCA26C")]
		public static void ClearCache()
		{
		}
	}
	[Token(Token = "0x20002C0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5930", Offset = "0x6E5930")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5930", Offset = "0x6E5930")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5930", Offset = "0x6E5930")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5930", Offset = "0x6E5930")]
	public class CanHearObject : Conditional
	{
		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6DFC", Offset = "0x6F6DFC")]
		public bool usePhysics2D;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6E34", Offset = "0x6F6E34")]
		public SharedGameObject targetObject;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6E6C", Offset = "0x6F6E6C")]
		public SharedGameObjectList targetObjects;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6EA4", Offset = "0x6F6EA4")]
		public SharedString targetTag;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6EDC", Offset = "0x6F6EDC")]
		public LayerMask objectLayerMask;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6F14", Offset = "0x6F6F14")]
		public int maxCollisionCount;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6F4C", Offset = "0x6F6F4C")]
		public SharedFloat hearingRadius;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6F84", Offset = "0x6F6F84")]
		public SharedFloat audibilityThreshold;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6FBC", Offset = "0x6F6FBC")]
		public SharedVector3 offset;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F6FF4", Offset = "0x6F6FF4")]
		public SharedGameObject returnedObject;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Collider[] overlapColliders;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Collider2D[] overlap2DColliders;

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x111ED7C", Offset = "0x111ED7C", VA = "0x111ED7C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x111F69C", Offset = "0x111F69C", VA = "0x111F69C", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x111F6F4", Offset = "0x111F6F4", VA = "0x111F6F4", Slot = "17")]
		public override void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x111F6F8", Offset = "0x111F6F8", VA = "0x111F6F8", Slot = "15")]
		public override void OnBehaviorComplete()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x111F754", Offset = "0x111F754", VA = "0x111F754")]
		public CanHearObject()
		{
		}
	}
	[Token(Token = "0x20002C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E59D8", Offset = "0x6E59D8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E59D8", Offset = "0x6E59D8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E59D8", Offset = "0x6E59D8")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E59D8", Offset = "0x6E59D8")]
	public class CanSeeObject : Conditional
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F702C", Offset = "0x6F702C")]
		public bool usePhysics2D;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7064", Offset = "0x6F7064")]
		public SharedGameObject targetObject;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F709C", Offset = "0x6F709C")]
		public SharedGameObjectList targetObjects;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F70D4", Offset = "0x6F70D4")]
		public SharedString targetTag;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F710C", Offset = "0x6F710C")]
		public LayerMask objectLayerMask;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7144", Offset = "0x6F7144")]
		public int maxCollisionCount;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F717C", Offset = "0x6F717C")]
		public LayerMask ignoreLayerMask;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F71B4", Offset = "0x6F71B4")]
		public SharedFloat fieldOfViewAngle;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F71EC", Offset = "0x6F71EC")]
		public SharedFloat viewDistance;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7224", Offset = "0x6F7224")]
		public SharedVector3 offset;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F725C", Offset = "0x6F725C")]
		public SharedVector3 targetOffset;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7294", Offset = "0x6F7294")]
		public SharedFloat angleOffset2D;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F72CC", Offset = "0x6F72CC")]
		public SharedBool useTargetBone;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7304", Offset = "0x6F7304")]
		public HumanBodyBones targetBone;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F733C", Offset = "0x6F733C")]
		public SharedBool drawDebugRay;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7374", Offset = "0x6F7374")]
		public SharedBool disableAgentColliderLayer;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F73AC", Offset = "0x6F73AC")]
		public SharedGameObject returnedObject;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject[] agentColliderGameObjects;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int[] originalColliderLayer;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Collider[] overlapColliders;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider2D[] overlap2DColliders;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int ignoreRaycastLayer;

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x111F7C0", Offset = "0x111F7C0", VA = "0x111F7C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1120BDC", Offset = "0x1120BDC", VA = "0x1120BDC", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1120D28", Offset = "0x1120D28", VA = "0x1120D28", Slot = "17")]
		public override void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1120E6C", Offset = "0x1120E6C", VA = "0x1120E6C", Slot = "15")]
		public override void OnBehaviorComplete()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1120EC8", Offset = "0x1120EC8", VA = "0x1120EC8")]
		public CanSeeObject()
		{
		}
	}
	[Token(Token = "0x20002C2")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5A80", Offset = "0x6E5A80")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5A80", Offset = "0x6E5A80")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5A80", Offset = "0x6E5A80")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5A80", Offset = "0x6E5A80")]
	public class Cover : NavMeshMovement
	{
		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F73E4", Offset = "0x6F73E4")]
		public SharedFloat maxCoverDistance;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F741C", Offset = "0x6F741C")]
		public LayerMask availableLayerCovers;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7454", Offset = "0x6F7454")]
		public SharedInt maxRaycasts;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F748C", Offset = "0x6F748C")]
		public SharedFloat rayStep;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F74C4", Offset = "0x6F74C4")]
		public SharedFloat coverOffset;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F74FC", Offset = "0x6F74FC")]
		public SharedBool lookAtCoverPoint;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7534", Offset = "0x6F7534")]
		public SharedFloat rotationEpsilon;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F756C", Offset = "0x6F756C")]
		public SharedFloat maxLookAtRotationDelta;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 coverPoint;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 coverTarget;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool foundCover;

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x112AAE4", Offset = "0x112AAE4", VA = "0x112AAE4", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x112AE80", Offset = "0x112AE80", VA = "0x112AE80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x112B074", Offset = "0x112B074", VA = "0x112B074", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x112B140", Offset = "0x112B140", VA = "0x112B140")]
		public Cover()
		{
		}
	}
	[Token(Token = "0x20002C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5B28", Offset = "0x6E5B28")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5B28", Offset = "0x6E5B28")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5B28", Offset = "0x6E5B28")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5B28", Offset = "0x6E5B28")]
	public class Evade : NavMeshMovement
	{
		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F75A4", Offset = "0x6F75A4")]
		public SharedFloat evadeDistance;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F75DC", Offset = "0x6F75DC")]
		public SharedFloat lookAheadDistance;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7614", Offset = "0x6F7614")]
		public SharedFloat targetDistPrediction;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F764C", Offset = "0x6F764C")]
		public SharedFloat targetDistPredictionMult;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7684", Offset = "0x6F7684")]
		public SharedGameObject target;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 targetPosition;

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xCC1A40", Offset = "0xCC1A40", VA = "0xCC1A40", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xCC1D30", Offset = "0xCC1D30", VA = "0xCC1D30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xCC1ADC", Offset = "0xCC1ADC", VA = "0xCC1ADC")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xCC1EA8", Offset = "0xCC1EA8", VA = "0xCC1EA8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xCC1F54", Offset = "0xCC1F54", VA = "0xCC1F54")]
		public Evade()
		{
		}
	}
	[Token(Token = "0x20002C4")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5BD0", Offset = "0x6E5BD0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5BD0", Offset = "0x6E5BD0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5BD0", Offset = "0x6E5BD0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5BD0", Offset = "0x6E5BD0")]
	public class Flee : NavMeshMovement
	{
		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F76BC", Offset = "0x6F76BC")]
		public SharedFloat fleedDistance;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F76F4", Offset = "0x6F76F4")]
		public SharedFloat lookAheadDistance;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F772C", Offset = "0x6F772C")]
		public SharedGameObject target;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool hasMoved;

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xCC4530", Offset = "0xCC4530", VA = "0xCC4530", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xCC46A8", Offset = "0xCC46A8", VA = "0xCC46A8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xCC4570", Offset = "0xCC4570", VA = "0xCC4570")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xCC48A8", Offset = "0xCC48A8", VA = "0xCC48A8", Slot = "31")]
		protected override bool SetDestination(Vector3 destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xCC4918", Offset = "0xCC4918", VA = "0xCC4918", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xCC4980", Offset = "0xCC4980", VA = "0xCC4980")]
		public Flee()
		{
		}
	}
	[Token(Token = "0x20002C5")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5C78", Offset = "0x6E5C78")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5C78", Offset = "0x6E5C78")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5C78", Offset = "0x6E5C78")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5C78", Offset = "0x6E5C78")]
	public class Flock : NavMeshGroupMovement
	{
		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7764", Offset = "0x6F7764")]
		public SharedFloat neighborDistance;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F779C", Offset = "0x6F779C")]
		public SharedFloat lookAheadDistance;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F77D4", Offset = "0x6F77D4")]
		public SharedFloat alignmentWeight;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F780C", Offset = "0x6F780C")]
		public SharedFloat cohesionWeight;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7844", Offset = "0x6F7844")]
		public SharedFloat separationWeight;

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xCC516C", Offset = "0xCC516C", VA = "0xCC516C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xCC53C8", Offset = "0xCC53C8", VA = "0xCC53C8")]
		private void DetermineFlockParameters(int index, out Vector3 alignment, out Vector3 cohesion, out Vector3 separation)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xCC5704", Offset = "0xCC5704", VA = "0xCC5704", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xCC57BC", Offset = "0xCC57BC", VA = "0xCC57BC")]
		public Flock()
		{
		}
	}
	[Token(Token = "0x20002C6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5D20", Offset = "0x6E5D20")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5D20", Offset = "0x6E5D20")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5D20", Offset = "0x6E5D20")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5D20", Offset = "0x6E5D20")]
	public class Follow : NavMeshMovement
	{
		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F787C", Offset = "0x6F787C")]
		public SharedGameObject target;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F78B4", Offset = "0x6F78B4")]
		public SharedFloat moveDistance;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool hasMoved;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xCC5988", Offset = "0xCC5988", VA = "0xCC5988", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xCC5AEC", Offset = "0xCC5AEC", VA = "0xCC5AEC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xCC5CF4", Offset = "0xCC5CF4", VA = "0xCC5CF4", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xCC5D40", Offset = "0xCC5D40", VA = "0xCC5D40")]
		public Follow()
		{
		}
	}
	[Token(Token = "0x20002C7")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5DC8", Offset = "0x6E5DC8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5DC8", Offset = "0x6E5DC8")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5DC8", Offset = "0x6E5DC8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5DC8", Offset = "0x6E5DC8")]
	public class LeaderFollow : NavMeshGroupMovement
	{
		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F78EC", Offset = "0x6F78EC")]
		public SharedFloat neighborDistance;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7924", Offset = "0x6F7924")]
		public SharedFloat leaderBehindDistance;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F795C", Offset = "0x6F795C")]
		public SharedFloat separationDistance;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7994", Offset = "0x6F7994")]
		public SharedFloat aheadDistance;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F79CC", Offset = "0x6F79CC")]
		public SharedGameObject leader;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform leaderTransform;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private NavMeshAgent leaderAgent;

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xFC3CFC", Offset = "0xFC3CFC", VA = "0xFC3CFC", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xFC4074", Offset = "0xFC4074", VA = "0xFC4074", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xFC433C", Offset = "0xFC433C", VA = "0xFC433C")]
		private Vector3 LeaderBehindPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xFC44D0", Offset = "0xFC44D0", VA = "0xFC44D0")]
		private Vector3 DetermineSeparation(int agentIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xFC442C", Offset = "0xFC442C", VA = "0xFC442C")]
		public bool LeaderLookingAtAgent(int agentIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xFC4708", Offset = "0xFC4708", VA = "0xFC4708", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xFC47C4", Offset = "0xFC47C4", VA = "0xFC47C4")]
		public LeaderFollow()
		{
		}
	}
	[Token(Token = "0x20002C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5E70", Offset = "0x6E5E70")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5E70", Offset = "0x6E5E70")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5E70", Offset = "0x6E5E70")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5E70", Offset = "0x6E5E70")]
	public class MoveTowards : Action
	{
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7A04", Offset = "0x6F7A04")]
		public SharedFloat speed;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7A3C", Offset = "0x6F7A3C")]
		public SharedFloat arriveDistance;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7A74", Offset = "0x6F7A74")]
		public SharedBool lookAtTarget;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7AAC", Offset = "0x6F7AAC")]
		public SharedFloat maxLookAtRotationDelta;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7AE4", Offset = "0x6F7AE4")]
		public SharedGameObject target;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7B1C", Offset = "0x6F7B1C")]
		public SharedVector3 targetPosition;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xFC84F0", Offset = "0xFC84F0", VA = "0xFC84F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xFC87AC", Offset = "0xFC87AC", VA = "0xFC87AC")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xFC88A8", Offset = "0xFC88A8", VA = "0xFC88A8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xFC88FC", Offset = "0xFC88FC", VA = "0xFC88FC")]
		public MoveTowards()
		{
		}
	}
	[Token(Token = "0x20002C9")]
	public abstract class NavMeshGroupMovement : GroupMovement
	{
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7B54", Offset = "0x6F7B54")]
		public SharedGameObject[] agents;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7B8C", Offset = "0x6F7B8C")]
		public SharedFloat speed;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7BC4", Offset = "0x6F7BC4")]
		public SharedFloat angularSpeed;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private NavMeshAgent[] navMeshAgents;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Transform[] transforms;

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xFC3DC0", Offset = "0xFC3DC0", VA = "0xFC3DC0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xFCA814", Offset = "0xFCA814", VA = "0xFCA814", Slot = "31")]
		protected override bool SetDestination(int index, Vector3 target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xFCA8F8", Offset = "0xFCA8F8", VA = "0xFCA8F8", Slot = "32")]
		protected override Vector3 Velocity(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xFCA93C", Offset = "0xFCA93C", VA = "0xFCA93C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xFC47B8", Offset = "0xFC47B8", VA = "0xFC47B8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xFC4860", Offset = "0xFC4860", VA = "0xFC4860")]
		protected NavMeshGroupMovement()
		{
		}
	}
	[Token(Token = "0x20002CA")]
	public abstract class NavMeshMovement : Movement
	{
		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7BFC", Offset = "0x6F7BFC")]
		public SharedFloat speed;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7C34", Offset = "0x6F7C34")]
		public SharedFloat angularSpeed;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7C6C", Offset = "0x6F7C6C")]
		public SharedFloat arriveDistance;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7CA4", Offset = "0x6F7CA4")]
		public SharedBool stopOnTaskEnd;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7CDC", Offset = "0x6F7CDC")]
		public SharedBool updateRotation;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected NavMeshAgent navMeshAgent;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool startUpdateRotation;

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xFCAA28", Offset = "0xFCAA28", VA = "0xFCAA28", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xFCAA84", Offset = "0xFCAA84", VA = "0xFCAA84", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xFCAB84", Offset = "0xFCAB84", VA = "0xFCAB84", Slot = "31")]
		protected override bool SetDestination(Vector3 destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xFCABEC", Offset = "0xFCABEC", VA = "0xFCABEC", Slot = "32")]
		protected override void UpdateRotation(bool update)
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xFCAC34", Offset = "0xFCAC34", VA = "0xFCAC34", Slot = "33")]
		protected override bool HasPath()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xFCACCC", Offset = "0xFCACCC", VA = "0xFCACCC", Slot = "34")]
		protected override Vector3 Velocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xFCACE8", Offset = "0xFCACE8", VA = "0xFCACE8")]
		protected bool SamplePosition(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xFCAD64", Offset = "0xFCAD64", VA = "0xFCAD64", Slot = "35")]
		protected override bool HasArrived()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xFCAE00", Offset = "0xFCAE00", VA = "0xFCAE00", Slot = "36")]
		protected override void Stop()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xFCAE64", Offset = "0xFCAE64", VA = "0xFCAE64", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xFCAEF0", Offset = "0xFCAEF0", VA = "0xFCAEF0", Slot = "15")]
		public override void OnBehaviorComplete()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xFCAF00", Offset = "0xFCAF00", VA = "0xFCAF00", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xFCAF8C", Offset = "0xFCAF8C", VA = "0xFCAF8C")]
		protected NavMeshMovement()
		{
		}
	}
	[Token(Token = "0x20002CB")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5F18", Offset = "0x6E5F18")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5F18", Offset = "0x6E5F18")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5F18", Offset = "0x6E5F18")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5F18", Offset = "0x6E5F18")]
	public class Patrol : NavMeshMovement
	{
		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7D14", Offset = "0x6F7D14")]
		public SharedBool randomPatrol;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7D4C", Offset = "0x6F7D4C")]
		public SharedFloat waypointPauseDuration;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7D84", Offset = "0x6F7D84")]
		public SharedGameObjectList waypoints;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int waypointIndex;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float waypointReachedTime;

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xFCC7C8", Offset = "0xFCC7C8", VA = "0xFCC7C8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xFCCA9C", Offset = "0xFCCA9C", VA = "0xFCCA9C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xFCC9B8", Offset = "0xFCC9B8", VA = "0xFCC9B8")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xFCCC74", Offset = "0xFCCC74", VA = "0xFCCC74", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xFCCCD8", Offset = "0xFCCCD8", VA = "0xFCCCD8", Slot = "17")]
		public override void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xFCCCDC", Offset = "0xFCCCDC", VA = "0xFCCCDC")]
		public Patrol()
		{
		}
	}
	[Token(Token = "0x20002CC")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E5FC0", Offset = "0x6E5FC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E5FC0", Offset = "0x6E5FC0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E5FC0", Offset = "0x6E5FC0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E5FC0", Offset = "0x6E5FC0")]
	public class Pursue : NavMeshMovement
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7DBC", Offset = "0x6F7DBC")]
		public SharedFloat targetDistPrediction;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7DF4", Offset = "0x6F7DF4")]
		public SharedFloat targetDistPredictionMult;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7E2C", Offset = "0x6F7E2C")]
		public SharedGameObject target;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 targetPosition;

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xFCEF34", Offset = "0xFCEF34", VA = "0xFCEF34", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xFCF190", Offset = "0xFCF190", VA = "0xFCF190", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xFCEFCC", Offset = "0xFCEFCC", VA = "0xFCEFCC")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xFCF1E8", Offset = "0xFCF1E8", VA = "0xFCF1E8", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xFCF258", Offset = "0xFCF258", VA = "0xFCF258")]
		public Pursue()
		{
		}
	}
	[Token(Token = "0x20002CD")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E6068", Offset = "0x6E6068")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E6068", Offset = "0x6E6068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E6068", Offset = "0x6E6068")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E6068", Offset = "0x6E6068")]
	public class Queue : NavMeshGroupMovement
	{
		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7E64", Offset = "0x6F7E64")]
		public SharedFloat neighborDistance;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7E9C", Offset = "0x6F7E9C")]
		public SharedFloat separationDistance;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7ED4", Offset = "0x6F7ED4")]
		public SharedFloat maxQueueAheadDistance;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7F0C", Offset = "0x6F7F0C")]
		public SharedFloat maxQueueRadius;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7F44", Offset = "0x6F7F44")]
		public SharedFloat slowDownSpeed;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7F7C", Offset = "0x6F7F7C")]
		public SharedGameObject target;

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xFCF2BC", Offset = "0xFCF2BC", VA = "0xFCF2BC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xFCF46C", Offset = "0xFCF46C", VA = "0xFCF46C")]
		private bool AgentAhead(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xFCF5B8", Offset = "0xFCF5B8", VA = "0xFCF5B8")]
		private Vector3 DetermineSeparation(int agentIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xFCF7F0", Offset = "0xFCF7F0", VA = "0xFCF7F0", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xFCF8B4", Offset = "0xFCF8B4", VA = "0xFCF8B4")]
		public Queue()
		{
		}
	}
	[Token(Token = "0x20002CE")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E6110", Offset = "0x6E6110")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E6110", Offset = "0x6E6110")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E6110", Offset = "0x6E6110")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E6110", Offset = "0x6E6110")]
	public class RotateTowards : Action
	{
		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7FB4", Offset = "0x6F7FB4")]
		public bool usePhysics2D;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F7FEC", Offset = "0x6F7FEC")]
		public SharedFloat rotationEpsilon;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8024", Offset = "0x6F8024")]
		public SharedFloat maxLookAtRotationDelta;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F805C", Offset = "0x6F805C")]
		public SharedBool onlyY;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8094", Offset = "0x6F8094")]
		public SharedGameObject target;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F80CC", Offset = "0x6F80CC")]
		public SharedVector3 targetRotation;

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xFD26A0", Offset = "0xFD26A0", VA = "0xFD26A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xFD2820", Offset = "0xFD2820", VA = "0xFD2820")]
		private Quaternion Target()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xFD2A04", Offset = "0xFD2A04", VA = "0xFD2A04", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xFD2AA4", Offset = "0xFD2AA4", VA = "0xFD2AA4")]
		public RotateTowards()
		{
		}
	}
	[Token(Token = "0x20002CF")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E61B8", Offset = "0x6E61B8")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E61B8", Offset = "0x6E61B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E61B8", Offset = "0x6E61B8")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E61B8", Offset = "0x6E61B8")]
	public class Search : NavMeshMovement
	{
		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8104", Offset = "0x6F8104")]
		public SharedFloat minWanderDistance;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F813C", Offset = "0x6F813C")]
		public SharedFloat maxWanderDistance;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8174", Offset = "0x6F8174")]
		public SharedFloat wanderRate;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F81AC", Offset = "0x6F81AC")]
		public SharedFloat minPauseDuration;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F81E4", Offset = "0x6F81E4")]
		public SharedFloat maxPauseDuration;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F821C", Offset = "0x6F821C")]
		public SharedInt targetRetries;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8254", Offset = "0x6F8254")]
		public SharedFloat fieldOfViewAngle;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F828C", Offset = "0x6F828C")]
		public SharedFloat viewDistance;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F82C4", Offset = "0x6F82C4")]
		public LayerMask ignoreLayerMask;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F82FC", Offset = "0x6F82FC")]
		public SharedBool senseAudio;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8334", Offset = "0x6F8334")]
		public SharedFloat hearingRadius;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F836C", Offset = "0x6F836C")]
		public SharedVector3 offset;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F83A4", Offset = "0x6F83A4")]
		public SharedVector3 targetOffset;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F83DC", Offset = "0x6F83DC")]
		public LayerMask objectLayerMask;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8414", Offset = "0x6F8414")]
		public int maxCollisionCount;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F844C", Offset = "0x6F844C")]
		public SharedBool useTargetBone;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8484", Offset = "0x6F8484")]
		public HumanBodyBones targetBone;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F84BC", Offset = "0x6F84BC")]
		public SharedBool drawDebugRay;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F84F4", Offset = "0x6F84F4")]
		public SharedFloat audibilityThreshold;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F852C", Offset = "0x6F852C")]
		public SharedGameObject returnedObject;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float pauseTime;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float destinationReachTime;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Collider[] overlapColliders;

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xFD30E0", Offset = "0xFD30E0", VA = "0xFD30E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xFD3564", Offset = "0xFD3564", VA = "0xFD3564")]
		private bool TrySetTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xFD3758", Offset = "0xFD3758", VA = "0xFD3758", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xFD38DC", Offset = "0xFD38DC", VA = "0xFD38DC")]
		public Search()
		{
		}
	}
	[Token(Token = "0x20002D0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E6260", Offset = "0x6E6260")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E6260", Offset = "0x6E6260")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E6260", Offset = "0x6E6260")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E6260", Offset = "0x6E6260")]
	public class Seek : NavMeshMovement
	{
		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8564", Offset = "0x6F8564")]
		public SharedGameObject target;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F859C", Offset = "0x6F859C")]
		public SharedVector3 targetPosition;

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xFD3A98", Offset = "0xFD3A98", VA = "0xFD3A98", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xFD3BCC", Offset = "0xFD3BCC", VA = "0xFD3BCC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xFD3AD0", Offset = "0xFD3AD0", VA = "0xFD3AD0")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xFD3C24", Offset = "0xFD3C24", VA = "0xFD3C24", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xFD3C70", Offset = "0xFD3C70", VA = "0xFD3C70")]
		public Seek()
		{
		}
	}
	[Token(Token = "0x20002D1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E6308", Offset = "0x6E6308")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E6308", Offset = "0x6E6308")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E6308", Offset = "0x6E6308")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E6308", Offset = "0x6E6308")]
	public class Wander : NavMeshMovement
	{
		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F85D4", Offset = "0x6F85D4")]
		public SharedFloat minWanderDistance;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F860C", Offset = "0x6F860C")]
		public SharedFloat maxWanderDistance;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8644", Offset = "0x6F8644")]
		public SharedFloat wanderRate;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F867C", Offset = "0x6F867C")]
		public SharedFloat minPauseDuration;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F86B4", Offset = "0x6F86B4")]
		public SharedFloat maxPauseDuration;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F86EC", Offset = "0x6F86EC")]
		public SharedInt targetRetries;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float pauseTime;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float destinationReachTime;

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x18DC674", Offset = "0x18DC674", VA = "0x18DC674", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x18DC790", Offset = "0x18DC790", VA = "0x18DC790")]
		private bool TrySetTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x18DC988", Offset = "0x18DC988", VA = "0x18DC988", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x18DCA54", Offset = "0x18DCA54", VA = "0x18DCA54")]
		public Wander()
		{
		}
	}
	[Token(Token = "0x20002D2")]
	[AttributeAttribute(Name = "TaskCategoryAttribute", RVA = "0x6E63B0", Offset = "0x6E63B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6E63B0", Offset = "0x6E63B0")]
	[AttributeAttribute(Name = "TaskIconAttribute", RVA = "0x6E63B0", Offset = "0x6E63B0")]
	[AttributeAttribute(Name = "TaskDescriptionAttribute", RVA = "0x6E63B0", Offset = "0x6E63B0")]
	public class WithinDistance : Conditional
	{
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8724", Offset = "0x6F8724")]
		public bool usePhysics2D;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F875C", Offset = "0x6F875C")]
		public SharedGameObject targetObject;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8794", Offset = "0x6F8794")]
		public SharedString targetTag;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F87CC", Offset = "0x6F87CC")]
		public LayerMask objectLayerMask;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8804", Offset = "0x6F8804")]
		public int maxCollisionCount;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F883C", Offset = "0x6F883C")]
		public SharedFloat magnitude;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8874", Offset = "0x6F8874")]
		public SharedBool lineOfSight;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F88AC", Offset = "0x6F88AC")]
		public LayerMask ignoreLayerMask;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F88E4", Offset = "0x6F88E4")]
		public SharedVector3 offset;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F891C", Offset = "0x6F891C")]
		public SharedVector3 targetOffset;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F8954", Offset = "0x6F8954")]
		public SharedBool drawDebugRay;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F898C", Offset = "0x6F898C")]
		public SharedGameObject returnedObject;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> objects;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float sqrMagnitude;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool overlapCast;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Collider[] overlapColliders;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Collider2D[] overlap2DColliders;

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x18DD0D8", Offset = "0x18DD0D8", VA = "0x18DD0D8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x18DD34C", Offset = "0x18DD34C", VA = "0x18DD34C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x18DDA70", Offset = "0x18DDA70", VA = "0x18DDA70", Slot = "16")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x18DDBA4", Offset = "0x18DDBA4", VA = "0x18DDBA4", Slot = "17")]
		public override void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x18DDBA8", Offset = "0x18DDBA8", VA = "0x18DDBA8")]
		public WithinDistance()
		{
		}
	}
}
