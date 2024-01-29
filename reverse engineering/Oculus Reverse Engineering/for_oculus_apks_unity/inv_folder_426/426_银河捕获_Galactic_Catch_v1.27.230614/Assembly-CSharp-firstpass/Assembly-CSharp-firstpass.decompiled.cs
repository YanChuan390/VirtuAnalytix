using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xABA508", Offset = "0xABA508")]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IDictionary<TKey, TValue> _dictionary;

	[Token(Token = "0x17000001")]
	public ICollection<TKey> Keys
	{
		[Token(Token = "0x6000004")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public ICollection<TValue> Values
	{
		[Token(Token = "0x6000007")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public TValue Item
	{
		[Token(Token = "0x6000008")]
		get
		{
			return (TValue)null;
		}
	}

	[Token(Token = "0x17000004")]
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (TValue)null;
		}
		[Token(Token = "0x600000A")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int Count
	{
		[Token(Token = "0x600000F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000001")]
	public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
	{
	}

	[Token(Token = "0x6000002")]
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value)
	{
	}

	[Token(Token = "0x6000003")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	public bool TryGetValue(TKey key, out TValue value)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
	}

	[Token(Token = "0x600000C")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear()
	{
	}

	[Token(Token = "0x600000D")]
	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000011")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	private static Exception ReadOnlyException()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x11222F4", Offset = "0x11222F4", VA = "0x11222F4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x11224B4", Offset = "0x11224B4", VA = "0x11224B4", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x11227C0", Offset = "0x11227C0", VA = "0x11227C0")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000004")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1131A74", Offset = "0x1131A74", VA = "0x1131A74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1131B50", Offset = "0x1131B50", VA = "0x1131B50")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA540", Offset = "0xABA540")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1131B58", Offset = "0x1131B58", VA = "0x1131B58")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1131C14", Offset = "0x1131C14", VA = "0x1131C14")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000006")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000076")]
		public enum Mode
		{
			[Token(Token = "0x40002C7")]
			Trigger,
			[Token(Token = "0x40002C8")]
			Replace,
			[Token(Token = "0x40002C9")]
			Activate,
			[Token(Token = "0x40002CA")]
			Enable,
			[Token(Token = "0x40002CB")]
			Animate,
			[Token(Token = "0x40002CC")]
			Deactivate
		}

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1330408", Offset = "0x1330408", VA = "0x1330408")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1330870", Offset = "0x1330870", VA = "0x1330870")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1330874", Offset = "0x1330874", VA = "0x1330874")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x13312C0", Offset = "0x13312C0", VA = "0x13312C0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public class ReplacementList
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x13312C8", Offset = "0x13312C8", VA = "0x13312C8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x133088C", Offset = "0x133088C", VA = "0x133088C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x13312B8", Offset = "0x13312B8", VA = "0x13312B8")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x13314A4", Offset = "0x13314A4", VA = "0x13314A4")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1331334", Offset = "0x1331334", VA = "0x1331334")]
		private void Start()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x133135C", Offset = "0x133135C", VA = "0x133135C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x133149C", Offset = "0x133149C", VA = "0x133149C")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class CameraRefocus
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x13314B4", Offset = "0x13314B4", VA = "0x13314B4")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1331528", Offset = "0x1331528", VA = "0x1331528")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1331530", Offset = "0x1331530", VA = "0x1331530")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1331538", Offset = "0x1331538", VA = "0x1331538")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1331698", Offset = "0x1331698", VA = "0x1331698")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1325C90", Offset = "0x1325C90", VA = "0x1325C90")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1326A24", Offset = "0x1326A24", VA = "0x1326A24")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x13271E0", Offset = "0x13271E0", VA = "0x13271E0")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB100", Offset = "0xABB100")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000042")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600034E")]
				[Address(RVA = "0x1331E2C", Offset = "0x1331E2C", VA = "0x1331E2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000350")]
				[Address(RVA = "0x1331E94", Offset = "0x1331E94", VA = "0x1331E94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1331B9C", Offset = "0x1331B9C", VA = "0x1331B9C")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1331BD0", Offset = "0x1331BD0", VA = "0x1331BD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1331BD4", Offset = "0x1331BD4", VA = "0x1331BD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1331E34", Offset = "0x1331E34", VA = "0x1331E34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001B")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400001C")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400001D")]
		private const float k_Drag = 10f;

		[Token(Token = "0x400001E")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x400001F")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000020")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x13316EC", Offset = "0x13316EC", VA = "0x13316EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1331B10", Offset = "0x1331B10", VA = "0x1331B10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC5B4", Offset = "0xABC5B4")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1331A60", Offset = "0x1331A60", VA = "0x1331A60")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1331BC8", Offset = "0x1331BC8", VA = "0x1331BC8")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1331E9C", Offset = "0x1331E9C", VA = "0x1331E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1331ED0", Offset = "0x1331ED0", VA = "0x1331ED0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1332144", Offset = "0x1332144", VA = "0x1332144")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class FOVKick
	{
		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB110", Offset = "0xABB110")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000044")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x133261C", Offset = "0x133261C", VA = "0x133261C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000045")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x1332684", Offset = "0x1332684", VA = "0x1332684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1332260", Offset = "0x1332260", VA = "0x1332260")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x13324AC", Offset = "0x13324AC", VA = "0x13324AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x13324B0", Offset = "0x13324B0", VA = "0x13324B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1332624", Offset = "0x1332624", VA = "0x1332624", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB120", Offset = "0xABB120")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000046")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x133243C", Offset = "0x133243C", VA = "0x133243C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000047")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x13324A4", Offset = "0x13324A4", VA = "0x13324A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x133228C", Offset = "0x133228C", VA = "0x133228C")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x13322B8", Offset = "0x13322B8", VA = "0x13322B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x13322BC", Offset = "0x13322BC", VA = "0x13322BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1332444", Offset = "0x1332444", VA = "0x1332444", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1325C44", Offset = "0x1325C44", VA = "0x1325C44")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1332178", Offset = "0x1332178", VA = "0x1332178")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1332258", Offset = "0x1332258", VA = "0x1332258")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1326BC0", Offset = "0x1326BC0", VA = "0x1326BC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC618", Offset = "0xABC618")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1326B44", Offset = "0x1326B44", VA = "0x1326B44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC67C", Offset = "0xABC67C")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x13271C4", Offset = "0x13271C4", VA = "0x13271C4")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x133268C", Offset = "0x133268C", VA = "0x133268C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x133276C", Offset = "0x133276C", VA = "0x133276C")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB130", Offset = "0xABB130")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000048")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x13329FC", Offset = "0x13329FC", VA = "0x13329FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000049")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000362")]
				[Address(RVA = "0x1332A64", Offset = "0x1332A64", VA = "0x1332A64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x13327D4", Offset = "0x13327D4", VA = "0x13327D4")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x1332800", Offset = "0x1332800", VA = "0x1332800", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1332804", Offset = "0x1332804", VA = "0x1332804", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1332A04", Offset = "0x1332A04", VA = "0x1332A04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x13327CC", Offset = "0x13327CC", VA = "0x13327CC")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1325F70", Offset = "0x1325F70", VA = "0x1325F70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC6E0", Offset = "0xABC6E0")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x132742C", Offset = "0x132742C", VA = "0x132742C")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB140", Offset = "0xABB140")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700004A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000366")]
				[Address(RVA = "0x1332E6C", Offset = "0x1332E6C", VA = "0x1332E6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000368")]
				[Address(RVA = "0x1332ED4", Offset = "0x1332ED4", VA = "0x1332ED4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1332BF8", Offset = "0x1332BF8", VA = "0x1332BF8")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1332C2C", Offset = "0x1332C2C", VA = "0x1332C2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1332C30", Offset = "0x1332C30", VA = "0x1332C30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1332E74", Offset = "0x1332E74", VA = "0x1332E74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1332A6C", Offset = "0x1332A6C", VA = "0x1332A6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x132F7A8", Offset = "0x132F7A8", VA = "0x132F7A8")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1332B6C", Offset = "0x1332B6C", VA = "0x1332B6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC744", Offset = "0xABC744")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1332C24", Offset = "0x1332C24", VA = "0x1332C24")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB150", Offset = "0xABB150")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700004C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0x1333304", Offset = "0x1333304", VA = "0x1333304", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x133336C", Offset = "0x133336C", VA = "0x133336C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1332F58", Offset = "0x1332F58", VA = "0x1332F58")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1332FA4", Offset = "0x1332FA4", VA = "0x1332FA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1332FA8", Offset = "0x1332FA8", VA = "0x1332FA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x133330C", Offset = "0x133330C", VA = "0x133330C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1332EDC", Offset = "0x1332EDC", VA = "0x1332EDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC7A8", Offset = "0xABC7A8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1332F84", Offset = "0x1332F84", VA = "0x1332F84")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1332F90", Offset = "0x1332F90", VA = "0x1332F90")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000080")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40002EF")]
			Standalone,
			[Token(Token = "0x40002F0")]
			Mobile
		}

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1333374", Offset = "0x1333374", VA = "0x1333374")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1333378", Offset = "0x1333378", VA = "0x1333378")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1333394", Offset = "0x1333394", VA = "0x1333394")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x13336F0", Offset = "0x13336F0", VA = "0x13336F0")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text camSwitchButton;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1333780", Offset = "0x1333780", VA = "0x1333780")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x13337EC", Offset = "0x13337EC", VA = "0x13337EC")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x13338C4", Offset = "0x13338C4", VA = "0x13338C4")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x13338CC", Offset = "0x13338CC", VA = "0x13338CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1333908", Offset = "0x1333908", VA = "0x1333908")]
		private void Update()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1333D3C", Offset = "0x1333D3C", VA = "0x1333D3C")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1333DFC", Offset = "0x1333DFC", VA = "0x1333DFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1333E00", Offset = "0x1333E00", VA = "0x1333E00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x133412C", Offset = "0x133412C", VA = "0x133412C")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000081")]
		public enum Action
		{
			[Token(Token = "0x40002F2")]
			Activate,
			[Token(Token = "0x40002F3")]
			Deactivate,
			[Token(Token = "0x40002F4")]
			Destroy,
			[Token(Token = "0x40002F5")]
			ReloadLevel,
			[Token(Token = "0x40002F6")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public class Entry
		{
			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x13348E8", Offset = "0x13348E8", VA = "0x13348E8")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000083")]
		public class Entries
		{
			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x13344D8", Offset = "0x13344D8", VA = "0x13344D8")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB160", Offset = "0xABB160")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700004E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000374")]
				[Address(RVA = "0x13345B8", Offset = "0x13345B8", VA = "0x13345B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000376")]
				[Address(RVA = "0x1334620", Offset = "0x1334620", VA = "0x1334620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x13343E0", Offset = "0x13343E0", VA = "0x13343E0")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x13344E0", Offset = "0x13344E0", VA = "0x13344E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0x13344E4", Offset = "0x13344E4", VA = "0x13344E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x13345C0", Offset = "0x13345C0", VA = "0x13345C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB170", Offset = "0xABB170")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600037A")]
				[Address(RVA = "0x1334700", Offset = "0x1334700", VA = "0x1334700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037C")]
				[Address(RVA = "0x1334768", Offset = "0x1334768", VA = "0x1334768", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x133440C", Offset = "0x133440C", VA = "0x133440C")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x1334628", Offset = "0x1334628", VA = "0x1334628", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x133462C", Offset = "0x133462C", VA = "0x133462C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x1334708", Offset = "0x1334708", VA = "0x1334708", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB180", Offset = "0xABB180")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000380")]
				[Address(RVA = "0x1334878", Offset = "0x1334878", VA = "0x1334878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x13348E0", Offset = "0x13348E0", VA = "0x13348E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x1334438", Offset = "0x1334438", VA = "0x1334438")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1334770", Offset = "0x1334770", VA = "0x1334770", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1334774", Offset = "0x1334774", VA = "0x1334774", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1334880", Offset = "0x1334880", VA = "0x1334880", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1334140", Offset = "0x1334140", VA = "0x1334140")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x133426C", Offset = "0x133426C", VA = "0x133426C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC80C", Offset = "0xABC80C")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x13342E8", Offset = "0x13342E8", VA = "0x13342E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC870", Offset = "0xABC870")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1334364", Offset = "0x1334364", VA = "0x1334364")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC8D4", Offset = "0xABC8D4")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1334464", Offset = "0x1334464", VA = "0x1334464")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x13348F0", Offset = "0x13348F0", VA = "0x13348F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1334948", Offset = "0x1334948", VA = "0x1334948")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x13349E8", Offset = "0x13349E8", VA = "0x13349E8")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public class WaypointList
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1335864", Offset = "0x1335864", VA = "0x1335864")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000088")]
		public struct RoutePoint
		{
			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x13351DC", Offset = "0x13351DC", VA = "0x13351DC")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB7D0", Offset = "0xABB7D0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000007")]
		public float Length
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x13349F8", Offset = "0x13349F8", VA = "0x13349F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC938", Offset = "0xABC938")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1334A00", Offset = "0x1334A00", VA = "0x1334A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC948", Offset = "0xABC948")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1334A08", Offset = "0x1334A08", VA = "0x1334A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1334A24", Offset = "0x1334A24", VA = "0x1334A24")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1334D74", Offset = "0x1334D74", VA = "0x1334D74")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1334E84", Offset = "0x1334E84", VA = "0x1334E84")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x13351EC", Offset = "0x13351EC", VA = "0x13351EC")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1334A80", Offset = "0x1334A80", VA = "0x1334A80")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1335554", Offset = "0x1335554", VA = "0x1335554")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x13357DC", Offset = "0x13357DC", VA = "0x13357DC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x133555C", Offset = "0x133555C", VA = "0x133555C")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x13357E4", Offset = "0x13357E4", VA = "0x13357E4")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000089")]
		public enum ProgressStyle
		{
			[Token(Token = "0x4000309")]
			SmoothAlongRoute,
			[Token(Token = "0x400030A")]
			PointToPoint
		}

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB850", Offset = "0xABB850")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB860", Offset = "0xABB860")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB870", Offset = "0xABB870")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000009")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x13358D0", Offset = "0x13358D0", VA = "0x13358D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC958", Offset = "0xABC958")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x13358E4", Offset = "0x13358E4", VA = "0x13358E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC968", Offset = "0xABC968")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x13358F8", Offset = "0x13358F8", VA = "0x13358F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC978", Offset = "0xABC978")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x133590C", Offset = "0x133590C", VA = "0x133590C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC988", Offset = "0xABC988")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1335920", Offset = "0x1335920", VA = "0x1335920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC998", Offset = "0xABC998")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x1335934", Offset = "0x1335934", VA = "0x1335934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC9A8", Offset = "0xABC9A8")]
			private set
			{
			}
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1335948", Offset = "0x1335948", VA = "0x1335948")]
		private void Start()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1335A3C", Offset = "0x1335A3C", VA = "0x1335A3C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1335B14", Offset = "0x1335B14", VA = "0x1335B14")]
		private void Update()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x133607C", Offset = "0x133607C", VA = "0x133607C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1336254", Offset = "0x1336254", VA = "0x1336254")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA5A4", Offset = "0xABA5A4")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x132DBB8", Offset = "0x132DBB8", VA = "0x132DBB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x132DC54", Offset = "0x132DC54", VA = "0x132DC54")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x132E114", Offset = "0x132E114", VA = "0x132E114")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x132E65C", Offset = "0x132E65C", VA = "0x132E65C")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB190", Offset = "0xABB190")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x132EEA0", Offset = "0x132EEA0", VA = "0x132EEA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600038A")]
				[Address(RVA = "0x132EF08", Offset = "0x132EF08", VA = "0x132EF08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x132E6EC", Offset = "0x132E6EC", VA = "0x132E6EC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x132E8A4", Offset = "0x132E8A4", VA = "0x132E8A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x132E8A8", Offset = "0x132E8A8", VA = "0x132E8A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x132EEA8", Offset = "0x132EEA8", VA = "0x132EEA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x132E670", Offset = "0x132E670", VA = "0x132E670")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABC9B8", Offset = "0xABC9B8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x132E718", Offset = "0x132E718", VA = "0x132E718")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x132E89C", Offset = "0x132E89C", VA = "0x132E89C")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB1A0", Offset = "0xABB1A0")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0x132F2E4", Offset = "0x132F2E4", VA = "0x132F2E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x132F34C", Offset = "0x132F34C", VA = "0x132F34C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x132EF8C", Offset = "0x132EF8C", VA = "0x132EF8C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x132EFC8", Offset = "0x132EFC8", VA = "0x132EFC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x132EFCC", Offset = "0x132EFCC", VA = "0x132EFCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x132F2EC", Offset = "0x132F2EC", VA = "0x132F2EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x132EF10", Offset = "0x132EF10", VA = "0x132EF10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCA1C", Offset = "0xABCA1C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x132EFB8", Offset = "0x132EFB8", VA = "0x132EFB8")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB1B0", Offset = "0xABB1B0")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x132F7D4", Offset = "0x132F7D4", VA = "0x132F7D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x132F83C", Offset = "0x132F83C", VA = "0x132F83C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x132F44C", Offset = "0x132F44C", VA = "0x132F44C")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x132F4A4", Offset = "0x132F4A4", VA = "0x132F4A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x132F4A8", Offset = "0x132F4A8", VA = "0x132F4A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x132F7DC", Offset = "0x132F7DC", VA = "0x132F7DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x132F354", Offset = "0x132F354", VA = "0x132F354")]
		private void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x132F3B4", Offset = "0x132F3B4", VA = "0x132F3B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCA80", Offset = "0xABCA80")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x132F478", Offset = "0x132F478", VA = "0x132F478")]
		public void Reset()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x132F480", Offset = "0x132F480", VA = "0x132F480")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x132F844", Offset = "0x132F844", VA = "0x132F844")]
		private void Start()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x132F8A4", Offset = "0x132F8A4", VA = "0x132F8A4")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x132F930", Offset = "0x132F930", VA = "0x132F930")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x132F940", Offset = "0x132F940", VA = "0x132F940")]
		private void Start()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x132F9B8", Offset = "0x132F9B8", VA = "0x132F9B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x132FC18", Offset = "0x132FC18", VA = "0x132FC18")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x132FC40", Offset = "0x132FC40", VA = "0x132FC40")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x132FC50", Offset = "0x132FC50", VA = "0x132FC50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x132FE14", Offset = "0x132FE14", VA = "0x132FE14")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x132FE30", Offset = "0x132FE30", VA = "0x132FE30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x132FFBC", Offset = "0x132FFBC", VA = "0x132FFBC")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x132FFCC", Offset = "0x132FFCC", VA = "0x132FFCC")]
		private void Start()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x133008C", Offset = "0x133008C", VA = "0x133008C")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1330094", Offset = "0x1330094", VA = "0x1330094")]
		private void Start()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x13300F4", Offset = "0x13300F4", VA = "0x13300F4")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1330384", Offset = "0x1330384", VA = "0x1330384")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1F30E70", Offset = "0x1F30E70", VA = "0x1F30E70")]
		private void Update()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1F310B4", Offset = "0x1F310B4", VA = "0x1F310B4")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA618", Offset = "0xABA618")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1F2CAE4", Offset = "0x1F2CAE4", VA = "0x1F2CAE4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1F2CB08", Offset = "0x1F2CB08", VA = "0x1F2CB08")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1F2CB68", Offset = "0x1F2CB68", VA = "0x1F2CB68")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1F2CBC8", Offset = "0x1F2CBC8", VA = "0x1F2CBC8")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA68C", Offset = "0xABA68C")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1F2CBD0", Offset = "0x1F2CBD0", VA = "0x1F2CBD0")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MeshContainer
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1F2CBD8", Offset = "0x1F2CBD8", VA = "0x1F2CBD8")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1F2CC4C", Offset = "0x1F2CC4C", VA = "0x1F2CC4C")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA700", Offset = "0xABA700")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1F2CC90", Offset = "0x1F2CC90", VA = "0x1F2CC90")]
		public void Start()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1F2CD84", Offset = "0x1F2CD84", VA = "0x1F2CD84")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1F2D098", Offset = "0x1F2D098", VA = "0x1F2D098")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1F2D14C", Offset = "0x1F2D14C", VA = "0x1F2D14C")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1F2D254", Offset = "0x1F2D254", VA = "0x1F2D254")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1F2DB34", Offset = "0x1F2DB34", VA = "0x1F2DB34")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1F2DB94", Offset = "0x1F2DB94", VA = "0x1F2DB94")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1F2DC8C", Offset = "0x1F2DC8C", VA = "0x1F2DC8C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1F2DCEC", Offset = "0x1F2DCEC", VA = "0x1F2DCEC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1F2D3D4", Offset = "0x1F2D3D4", VA = "0x1F2D3D4")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1F2DD4C", Offset = "0x1F2DD4C", VA = "0x1F2DD4C")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1F2E24C", Offset = "0x1F2E24C", VA = "0x1F2E24C")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1F2DDB0", Offset = "0x1F2DDB0", VA = "0x1F2DDB0")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1F2E484", Offset = "0x1F2E484", VA = "0x1F2E484")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1F2E068", Offset = "0x1F2E068", VA = "0x1F2E068")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1F2E4A4", Offset = "0x1F2E4A4", VA = "0x1F2E4A4")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA774", Offset = "0xABA774")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1F2E520", Offset = "0x1F2E520", VA = "0x1F2E520")]
		public void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1F2E61C", Offset = "0x1F2E61C", VA = "0x1F2E61C")]
		public void Update()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1F2E868", Offset = "0x1F2E868", VA = "0x1F2E868")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x200008D")]
		public enum WaterMode
		{
			[Token(Token = "0x4000317")]
			Simple,
			[Token(Token = "0x4000318")]
			Reflective,
			[Token(Token = "0x4000319")]
			Refractive
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1F2E870", Offset = "0x1F2E870", VA = "0x1F2E870")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1F30514", Offset = "0x1F30514", VA = "0x1F30514")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1F30820", Offset = "0x1F30820", VA = "0x1F30820")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1F2FE30", Offset = "0x1F2FE30", VA = "0x1F2FE30")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1F2F328", Offset = "0x1F2F328", VA = "0x1F2F328")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1F2F314", Offset = "0x1F2F314", VA = "0x1F2F314")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1F2F1CC", Offset = "0x1F2F1CC", VA = "0x1F2F1CC")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1F30330", Offset = "0x1F30330", VA = "0x1F30330")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1F3008C", Offset = "0x1F3008C", VA = "0x1F3008C")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1F30AAC", Offset = "0x1F30AAC", VA = "0x1F30AAC")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000B8")]
		High = 2,
		[Token(Token = "0x40000B9")]
		Medium = 1,
		[Token(Token = "0x40000BA")]
		Low = 0
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1F30BA0", Offset = "0x1F30BA0", VA = "0x1F30BA0")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1F30D20", Offset = "0x1F30D20", VA = "0x1F30D20")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1F30DD4", Offset = "0x1F30DD4", VA = "0x1F30DD4")]
		public void Update()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1F30E58", Offset = "0x1F30E58", VA = "0x1F30E58")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1F310BC", Offset = "0x1F310BC", VA = "0x1F310BC")]
		public void Start()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1F310C0", Offset = "0x1F310C0", VA = "0x1F310C0")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1F31290", Offset = "0x1F31290", VA = "0x1F31290")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1F31398", Offset = "0x1F31398", VA = "0x1F31398")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200002E")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1329FA4", Offset = "0x1329FA4", VA = "0x1329FA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x132A26C", Offset = "0x132A26C", VA = "0x132A26C")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x132A3FC", Offset = "0x132A3FC", VA = "0x132A3FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x132A47C", Offset = "0x132A47C", VA = "0x132A47C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x132A564", Offset = "0x132A564", VA = "0x132A564", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x132A60C", Offset = "0x132A60C", VA = "0x132A60C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x132A680", Offset = "0x132A680", VA = "0x132A680")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x132A684", Offset = "0x132A684", VA = "0x132A684")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x132A76C", Offset = "0x132A76C", VA = "0x132A76C")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x132A854", Offset = "0x132A854", VA = "0x132A854")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x132A93C", Offset = "0x132A93C", VA = "0x132A93C")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x132AA24", Offset = "0x132AA24", VA = "0x132AA24")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x132AB0C", Offset = "0x132AB0C", VA = "0x132AB0C")]
		public void Update()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x132AB10", Offset = "0x132AB10", VA = "0x132AB10")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200008E")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400031B")]
			Hardware,
			[Token(Token = "0x400031C")]
			Touch
		}

		[Token(Token = "0x200008F")]
		public class VirtualAxis
		{
			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC4EC", Offset = "0xABC4EC")]
			private string <name>k__BackingField;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC4FC", Offset = "0xABC4FC")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700005A")]
			public string name
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x132B994", Offset = "0x132B994", VA = "0x132B994")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDDA0", Offset = "0xABDDA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x132B99C", Offset = "0x132B99C", VA = "0x132B99C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDDB0", Offset = "0xABDDB0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x132B9A4", Offset = "0x132B9A4", VA = "0x132B9A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDDC0", Offset = "0xABDDC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x132B9AC", Offset = "0x132B9AC", VA = "0x132B9AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDDD0", Offset = "0xABDDD0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005C")]
			public float GetValue
			{
				[Token(Token = "0x600039F")]
				[Address(RVA = "0x132BA0C", Offset = "0x132BA0C", VA = "0x132BA0C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700005D")]
			public float GetValueRaw
			{
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x132BA14", Offset = "0x132BA14", VA = "0x132BA14")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x132A13C", Offset = "0x132A13C", VA = "0x132A13C")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x132B9B8", Offset = "0x132B9B8", VA = "0x132B9B8")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x132A414", Offset = "0x132A414", VA = "0x132A414")]
			public void Remove()
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x132BA04", Offset = "0x132BA04", VA = "0x132BA04")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000090")]
		public class VirtualButton
		{
			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC50C", Offset = "0xABC50C")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC51C", Offset = "0xABC51C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700005E")]
			public string name
			{
				[Token(Token = "0x60003A1")]
				[Address(RVA = "0x132BA1C", Offset = "0x132BA1C", VA = "0x132BA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDDE0", Offset = "0xABDDE0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x132BA24", Offset = "0x132BA24", VA = "0x132BA24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDDF0", Offset = "0xABDDF0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0x132BA2C", Offset = "0x132BA2C", VA = "0x132BA2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDE00", Offset = "0xABDE00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x132BA34", Offset = "0x132BA34", VA = "0x132BA34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABDE10", Offset = "0xABDE10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000060")]
			public bool GetButton
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x132BBAC", Offset = "0x132BBAC", VA = "0x132BBAC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000061")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x132BBB4", Offset = "0x132BBB4", VA = "0x132BBB4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000062")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x132BBE4", Offset = "0x132BBE4", VA = "0x132BBE4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x132BA40", Offset = "0x132BA40", VA = "0x132BA40")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x132BA88", Offset = "0x132BA88", VA = "0x132BA88")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x132BADC", Offset = "0x132BADC", VA = "0x132BADC")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x132BB18", Offset = "0x132BB18", VA = "0x132BB18")]
			public void Released()
			{
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x132BB44", Offset = "0x132BB44", VA = "0x132BB44")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000C")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x132B614", Offset = "0x132B614", VA = "0x132B614")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x132AB18", Offset = "0x132AB18", VA = "0x132AB18")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x132ABCC", Offset = "0x132ABCC", VA = "0x132ABCC")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x132A0C4", Offset = "0x132A0C4", VA = "0x132A0C4")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x132ACEC", Offset = "0x132ACEC", VA = "0x132ACEC")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x132A17C", Offset = "0x132A17C", VA = "0x132A17C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x132AEF4", Offset = "0x132AEF4", VA = "0x132AEF4")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x132B094", Offset = "0x132B094", VA = "0x132B094")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x132B1E4", Offset = "0x132B1E4", VA = "0x132B1E4")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x132A1F4", Offset = "0x132A1F4", VA = "0x132A1F4")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1324814", Offset = "0x1324814", VA = "0x1324814")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x132B418", Offset = "0x132B418", VA = "0x132B418")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x132B388", Offset = "0x132B388", VA = "0x132B388")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x132B480", Offset = "0x132B480", VA = "0x132B480")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1325EF0", Offset = "0x1325EF0", VA = "0x1325EF0")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x132B500", Offset = "0x132B500", VA = "0x132B500")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x132A6EC", Offset = "0x132A6EC", VA = "0x132A6EC")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x132A7D4", Offset = "0x132A7D4", VA = "0x132A7D4")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x132A8BC", Offset = "0x132A8BC", VA = "0x132A8BC")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x132AA8C", Offset = "0x132AA8C", VA = "0x132AA8C")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x132A9A4", Offset = "0x132A9A4", VA = "0x132A9A4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x132B580", Offset = "0x132B580", VA = "0x132B580")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x132B690", Offset = "0x132B690", VA = "0x132B690")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x132B78C", Offset = "0x132B78C", VA = "0x132B78C")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x132B894", Offset = "0x132B894", VA = "0x132B894")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x132BC14", Offset = "0x132BC14", VA = "0x132BC14")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x132BC18", Offset = "0x132BC18", VA = "0x132BC18")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x132BC98", Offset = "0x132BC98", VA = "0x132BC98")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000091")]
		public enum AxisOption
		{
			[Token(Token = "0x4000326")]
			Both,
			[Token(Token = "0x4000327")]
			OnlyHorizontal,
			[Token(Token = "0x4000328")]
			OnlyVertical
		}

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x132BCA0", Offset = "0x132BCA0", VA = "0x132BCA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x132BE18", Offset = "0x132BE18", VA = "0x132BE18")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x132BE54", Offset = "0x132BE54", VA = "0x132BE54")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x132BCA4", Offset = "0x132BCA4", VA = "0x132BCA4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x132BF44", Offset = "0x132BF44", VA = "0x132BF44", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x132C134", Offset = "0x132C134", VA = "0x132C134", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x132C17C", Offset = "0x132C17C", VA = "0x132C17C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x132C180", Offset = "0x132C180", VA = "0x132C180")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x132C1D0", Offset = "0x132C1D0", VA = "0x132C1D0")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x132C250", Offset = "0x132C250", VA = "0x132C250")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x132C260", Offset = "0x132C260", VA = "0x132C260")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x132C258", Offset = "0x132C258", VA = "0x132C258")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x132C33C", Offset = "0x132C33C", VA = "0x132C33C")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x132C5A8", Offset = "0x132C5A8", VA = "0x132C5A8")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000092")]
		public enum AxisOptions
		{
			[Token(Token = "0x400032A")]
			ForwardAxis,
			[Token(Token = "0x400032B")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class AxisMapping
		{
			[Token(Token = "0x2000101")]
			public enum MappingType
			{
				[Token(Token = "0x4000436")]
				NamedAxis,
				[Token(Token = "0x4000437")]
				MousePositionX,
				[Token(Token = "0x4000438")]
				MousePositionY,
				[Token(Token = "0x4000439")]
				MousePositionZ
			}

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x132D4B0", Offset = "0x132D4B0", VA = "0x132D4B0")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x132D120", Offset = "0x132D120", VA = "0x132D120")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x132D1FC", Offset = "0x132D1FC", VA = "0x132D1FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x132D488", Offset = "0x132D488", VA = "0x132D488")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x132D4A0", Offset = "0x132D4A0", VA = "0x132D4A0")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA828", Offset = "0xABA828")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000094")]
		public enum AxisOption
		{
			[Token(Token = "0x400032F")]
			Both,
			[Token(Token = "0x4000330")]
			OnlyHorizontal,
			[Token(Token = "0x4000331")]
			OnlyVertical
		}

		[Token(Token = "0x2000095")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000333")]
			Absolute,
			[Token(Token = "0x4000334")]
			Relative,
			[Token(Token = "0x4000335")]
			Swipe
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x132D4B8", Offset = "0x132D4B8", VA = "0x132D4B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x132D630", Offset = "0x132D630", VA = "0x132D630")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x132D4BC", Offset = "0x132D4BC", VA = "0x132D4BC")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x132D6BC", Offset = "0x132D6BC", VA = "0x132D6BC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x132D728", Offset = "0x132D728", VA = "0x132D728", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x132D7D8", Offset = "0x132D7D8", VA = "0x132D7D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x132D9AC", Offset = "0x132D9AC", VA = "0x132D9AC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x132DA24", Offset = "0x132DA24", VA = "0x132DA24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x132DB18", Offset = "0x132DB18", VA = "0x132DB18")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB880", Offset = "0xABB880")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000D")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x132DBA0", Offset = "0x132DBA0", VA = "0x132DBA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCAE4", Offset = "0xABCAE4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x132DBAC", Offset = "0x132DBAC", VA = "0x132DBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCAF4", Offset = "0xABCAF4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x132AC84", Offset = "0x132AC84", VA = "0x132AC84")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x132AD64", Offset = "0x132AD64", VA = "0x132AD64")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x132ADCC", Offset = "0x132ADCC", VA = "0x132ADCC")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x132AF6C", Offset = "0x132AF6C", VA = "0x132AF6C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x132B14C", Offset = "0x132B14C", VA = "0x132B14C")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x132B25C", Offset = "0x132B25C", VA = "0x132B25C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x132B2F4", Offset = "0x132B2F4", VA = "0x132B2F4")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x132B740", Offset = "0x132B740", VA = "0x132B740")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x132B840", Offset = "0x132B840", VA = "0x132B840")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x132B944", Offset = "0x132B944", VA = "0x132B944")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600010D")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600010E")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600010F")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000110")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000111")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000112")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000113")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000114")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000115")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000116")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000117")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x132CD74", Offset = "0x132CD74", VA = "0x132CD74")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000037")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x132C5B0", Offset = "0x132C5B0", VA = "0x132C5B0")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x132C650", Offset = "0x132C650", VA = "0x132C650")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x132C6E8", Offset = "0x132C6E8", VA = "0x132C6E8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x132C784", Offset = "0x132C784", VA = "0x132C784", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x132C83C", Offset = "0x132C83C", VA = "0x132C83C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x132C8E8", Offset = "0x132C8E8", VA = "0x132C8E8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x132C988", Offset = "0x132C988", VA = "0x132C988", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x132CA28", Offset = "0x132CA28", VA = "0x132CA28", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x132CAC4", Offset = "0x132CAC4", VA = "0x132CAC4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x132CB6C", Offset = "0x132CB6C", VA = "0x132CB6C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x132CC1C", Offset = "0x132CC1C", VA = "0x132CC1C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x132CCCC", Offset = "0x132CCCC", VA = "0x132CCCC", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x132CD68", Offset = "0x132CD68", VA = "0x132CD68", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x132ABC4", Offset = "0x132ABC4", VA = "0x132ABC4")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x132CE58", Offset = "0x132CE58", VA = "0x132CE58", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x132CE6C", Offset = "0x132CE6C", VA = "0x132CE6C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x132CE78", Offset = "0x132CE78", VA = "0x132CE78", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x132CE84", Offset = "0x132CE84", VA = "0x132CE84", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x132CE90", Offset = "0x132CE90", VA = "0x132CE90", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x132CEFC", Offset = "0x132CEFC", VA = "0x132CEFC", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x132CF68", Offset = "0x132CF68", VA = "0x132CF68", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x132CFD4", Offset = "0x132CFD4", VA = "0x132CFD4", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x132D040", Offset = "0x132D040", VA = "0x132D040", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x132D0AC", Offset = "0x132D0AC", VA = "0x132D0AC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x132D118", Offset = "0x132D118", VA = "0x132D118", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x132ABC8", Offset = "0x132ABC8", VA = "0x132ABC8")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Car
{
	[Token(Token = "0x2000039")]
	public class BrakeLight : MonoBehaviour
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController car;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer m_Renderer;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1F29274", Offset = "0x1F29274", VA = "0x1F29274")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1F292D4", Offset = "0x1F292D4", VA = "0x1F292D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1F29308", Offset = "0x1F29308", VA = "0x1F29308")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA88C", Offset = "0xABA88C")]
	public class CarAIControl : MonoBehaviour
	{
		[Token(Token = "0x2000096")]
		public enum BrakeCondition
		{
			[Token(Token = "0x4000337")]
			NeverBrake,
			[Token(Token = "0x4000338")]
			TargetDirectionDifference,
			[Token(Token = "0x4000339")]
			TargetDistance
		}

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABB890", Offset = "0xABB890")]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABB8D0", Offset = "0xABB8D0")]
		private float m_CautiousMaxAngle;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_CautiousMaxDistance;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_CautiousAngularVelocityFactor;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SteerSensitivity;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_AccelSensitivity;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BrakeSensitivity;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABB984", Offset = "0xABB984")]
		private float m_AccelWanderAmount;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AccelWanderSpeed;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BrakeCondition m_BrakeCondition;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_Driving;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_StopWhenTargetReached;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_ReachTargetThreshold;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_RandomPerlin;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CarController m_CarController;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_AvoidOtherCarTime;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_AvoidOtherCarSlowdown;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_AvoidPathOffset;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1F29310", Offset = "0x1F29310", VA = "0x1F29310")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1F293AC", Offset = "0x1F293AC", VA = "0x1F293AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1F29D48", Offset = "0x1F29D48", VA = "0x1F29D48")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1F29FE4", Offset = "0x1F29FE4", VA = "0x1F29FE4")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1F2A014", Offset = "0x1F2A014", VA = "0x1F2A014")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA8F0", Offset = "0xABA8F0")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x2000097")]
		public enum EngineAudioOptions
		{
			[Token(Token = "0x400033B")]
			Simple,
			[Token(Token = "0x400033C")]
			FourChannel
		}

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EngineAudioOptions engineSoundStyle;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip lowAccelClip;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip lowDecelClip;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip highAccelClip;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip highDecelClip;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchMultiplier;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lowPitchMin;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lowPitchMax;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float highPitchMultiplier;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxRolloffDistance;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dopplerLevel;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useDoppler;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource m_LowAccel;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource m_LowDecel;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource m_HighAccel;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AudioSource m_HighDecel;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_StartedSound;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CarController m_CarController;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1F2A05C", Offset = "0x1F2A05C", VA = "0x1F2A05C")]
		private void StartSound()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1F2A254", Offset = "0x1F2A254", VA = "0x1F2A254")]
		private void StopSound()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1F2A334", Offset = "0x1F2A334", VA = "0x1F2A334")]
		private void Update()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1F2A144", Offset = "0x1F2A144", VA = "0x1F2A144")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1F2A72C", Offset = "0x1F2A72C", VA = "0x1F2A72C")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1F2A744", Offset = "0x1F2A744", VA = "0x1F2A744")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal enum CarDriveType
	{
		[Token(Token = "0x400011A")]
		FrontWheelDrive,
		[Token(Token = "0x400011B")]
		RearWheelDrive,
		[Token(Token = "0x400011C")]
		FourWheelDrive
	}
	[Token(Token = "0x200003D")]
	internal enum SpeedType
	{
		[Token(Token = "0x400011E")]
		MPH,
		[Token(Token = "0x400011F")]
		KPH
	}
	[Token(Token = "0x200003E")]
	public class CarController : MonoBehaviour
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarDriveType m_CarDriveType;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_WheelMeshes;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WheelEffects[] m_WheelEffects;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MaximumSteerAngle;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABBA84", Offset = "0xABBA84")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABBAC4", Offset = "0xABBAC4")]
		[SerializeField]
		private float m_TractionControl;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ReverseTorque;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Downforce;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedType m_SpeedType;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_Topspeed;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private static int NoOfGears;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_RevRangeBoundary;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SlipLimit;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BrakeTorque;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] m_WheelMeshLocalRotations;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Prevpos;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 m_Pos;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_SteerAngle;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_GearNum;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_GearFactor;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float m_OldRotation;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float m_CurrentTorque;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400013B")]
		private const float k_ReversingThreshold = 0.01f;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBBA4", Offset = "0xABBBA4")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBBB4", Offset = "0xABBBB4")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBBC4", Offset = "0xABBBC4")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBBD4", Offset = "0xABBBD4")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool Skidding
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1F2A770", Offset = "0x1F2A770", VA = "0x1F2A770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB04", Offset = "0xABCB04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1F2A778", Offset = "0x1F2A778", VA = "0x1F2A778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB14", Offset = "0xABCB14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float BrakeInput
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1F2A784", Offset = "0x1F2A784", VA = "0x1F2A784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB24", Offset = "0xABCB24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1F2A78C", Offset = "0x1F2A78C", VA = "0x1F2A78C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB34", Offset = "0xABCB34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1F2A794", Offset = "0x1F2A794", VA = "0x1F2A794")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1F29CF4", Offset = "0x1F29CF4", VA = "0x1F29CF4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float MaxSpeed
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1F2A79C", Offset = "0x1F2A79C", VA = "0x1F2A79C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public float Revs
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1F2A7A4", Offset = "0x1F2A7A4", VA = "0x1F2A7A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB44", Offset = "0xABCB44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1F2A7AC", Offset = "0x1F2A7AC", VA = "0x1F2A7AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB54", Offset = "0xABCB54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float AccelInput
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1F2A7B4", Offset = "0x1F2A7B4", VA = "0x1F2A7B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB64", Offset = "0xABCB64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1F2A7BC", Offset = "0x1F2A7BC", VA = "0x1F2A7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCB74", Offset = "0xABCB74")]
			private set
			{
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1F2A7C4", Offset = "0x1F2A7C4", VA = "0x1F2A7C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1F2A920", Offset = "0x1F2A920", VA = "0x1F2A920")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1F2AA58", Offset = "0x1F2AA58", VA = "0x1F2AA58")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1F2AA6C", Offset = "0x1F2AA6C", VA = "0x1F2AA6C")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1F2AA84", Offset = "0x1F2AA84", VA = "0x1F2AA84")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1F2AB90", Offset = "0x1F2AB90", VA = "0x1F2AB90")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1F29A20", Offset = "0x1F29A20", VA = "0x1F29A20")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1F2B1B4", Offset = "0x1F2B1B4", VA = "0x1F2B1B4")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1F2AEDC", Offset = "0x1F2AEDC", VA = "0x1F2AEDC")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1F2AC64", Offset = "0x1F2AC64", VA = "0x1F2AC64")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1F2B2F0", Offset = "0x1F2B2F0", VA = "0x1F2B2F0")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1F2B45C", Offset = "0x1F2B45C", VA = "0x1F2B45C")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1F2B624", Offset = "0x1F2B624", VA = "0x1F2B624")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1F2BBB0", Offset = "0x1F2BBB0", VA = "0x1F2BBB0")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1F2BA14", Offset = "0x1F2BA14", VA = "0x1F2BA14")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1F2BBF8", Offset = "0x1F2BBF8", VA = "0x1F2BBF8")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class CarSelfRighting : MonoBehaviour
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_WaitTime;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_VelocityThreshold;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastOkTime;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1F2BD1C", Offset = "0x1F2BD1C", VA = "0x1F2BD1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1F2BD7C", Offset = "0x1F2BD7C", VA = "0x1F2BD7C")]
		private void Update()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1F2BE28", Offset = "0x1F2BE28", VA = "0x1F2BE28")]
		private void RightCar()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1F2BF6C", Offset = "0x1F2BF6C", VA = "0x1F2BF6C")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA954", Offset = "0xABA954")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1F2BF80", Offset = "0x1F2BF80", VA = "0x1F2BF80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1F2BFE0", Offset = "0x1F2BFE0", VA = "0x1F2BFE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1F2C090", Offset = "0x1F2C090", VA = "0x1F2C090")]
		public CarUserControl()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class Mudguard : MonoBehaviour
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController carController;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1F2C098", Offset = "0x1F2C098", VA = "0x1F2C098")]
		private void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1F2C0D4", Offset = "0x1F2C0D4", VA = "0x1F2C0D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1F2C1BC", Offset = "0x1F2C1BC", VA = "0x1F2C1BC")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB1C0", Offset = "0xABB1C0")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkidTrail <>4__this;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0x1F2C3B8", Offset = "0x1F2C3B8", VA = "0x1F2C3B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x1F2C420", Offset = "0x1F2C420", VA = "0x1F2C420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1F2C240", Offset = "0x1F2C240", VA = "0x1F2C240")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1F2C274", Offset = "0x1F2C274", VA = "0x1F2C274", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1F2C278", Offset = "0x1F2C278", VA = "0x1F2C278", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1F2C3C0", Offset = "0x1F2C3C0", VA = "0x1F2C3C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1F2C1C4", Offset = "0x1F2C1C4", VA = "0x1F2C1C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCB84", Offset = "0xABCB84")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1F2C26C", Offset = "0x1F2C26C", VA = "0x1F2C26C")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Suspension : MonoBehaviour
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject wheel;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetOriginalPosition;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_Origin;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1F2C428", Offset = "0x1F2C428", VA = "0x1F2C428")]
		private void Start()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1F2C48C", Offset = "0x1F2C48C", VA = "0x1F2C48C")]
		private void Update()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1F2C5B4", Offset = "0x1F2C5B4", VA = "0x1F2C5B4")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABA9B8", Offset = "0xABA9B8")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB1D0", Offset = "0xABB1D0")]
		private sealed class <StartSkidTrail>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WheelEffects <>4__this;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x1F2CA74", Offset = "0x1F2CA74", VA = "0x1F2CA74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B9")]
				[Address(RVA = "0x1F2CADC", Offset = "0x1F2CADC", VA = "0x1F2CADC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1F2C86C", Offset = "0x1F2C86C", VA = "0x1F2C86C")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1F2C8A0", Offset = "0x1F2C8A0", VA = "0x1F2C8A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1F2C8A4", Offset = "0x1F2C8A4", VA = "0x1F2C8A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1F2CA7C", Offset = "0x1F2CA7C", VA = "0x1F2CA7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform SkidTrailPrefab;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform skidTrailsDetachedParent;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem skidParticles;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBC14", Offset = "0xABBC14")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBC24", Offset = "0xABBC24")]
		private bool <PlayingAudio>k__BackingField;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_SkidTrail;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WheelCollider m_WheelCollider;

		[Token(Token = "0x17000015")]
		public bool skidding
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1F2C5BC", Offset = "0x1F2C5BC", VA = "0x1F2C5BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCBE8", Offset = "0xABCBE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1F2C5C4", Offset = "0x1F2C5C4", VA = "0x1F2C5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCBF8", Offset = "0xABCBF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool PlayingAudio
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1F2C5D0", Offset = "0x1F2C5D0", VA = "0x1F2C5D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCC08", Offset = "0xABCC08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1F2C5D8", Offset = "0x1F2C5D8", VA = "0x1F2C5D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCC18", Offset = "0xABCC18")]
			private set
			{
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1F2C5E4", Offset = "0x1F2C5E4", VA = "0x1F2C5E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1F2B88C", Offset = "0x1F2B88C", VA = "0x1F2B88C")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1F2BA80", Offset = "0x1F2BA80", VA = "0x1F2BA80")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1F2BAB8", Offset = "0x1F2BAB8", VA = "0x1F2BAB8")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1F2C7F0", Offset = "0x1F2C7F0", VA = "0x1F2C7F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCC28", Offset = "0xABCC28")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1F2BAEC", Offset = "0x1F2BAEC", VA = "0x1F2BAEC")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1F2C898", Offset = "0x1F2C898", VA = "0x1F2C898")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAA1C", Offset = "0xABAA1C")]
	public class AeroplaneAiControl : MonoBehaviour
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RollSensitivity;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_PitchSensitivity;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MaxClimbAngle;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MaxRollAngle;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SpeedEffect;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_TakeoffHeight;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_AeroplaneController;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_RandomPerlin;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_TakenOff;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1336270", Offset = "0x1336270", VA = "0x1336270")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x13362EC", Offset = "0x13362EC", VA = "0x13362EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x13362F4", Offset = "0x13362F4", VA = "0x13362F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1336634", Offset = "0x1336634", VA = "0x1336634")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x133663C", Offset = "0x133663C", VA = "0x133663C")]
		public AeroplaneAiControl()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009A")]
		public class AdvancedSetttings
		{
			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float engineMinDistance;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float engineMaxDistance;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float engineDopplerLevel;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC52C", Offset = "0xABC52C")]
			public float engineMasterVolume;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float windMinDistance;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float windMaxDistance;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float windDopplerLevel;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC544", Offset = "0xABC544")]
			public float windMasterVolume;

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1336B08", Offset = "0x1336B08", VA = "0x1336B08")]
			public AdvancedSetttings()
			{
			}
		}

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_EngineSound;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_EngineMinThrottlePitch;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_EngineMaxThrottlePitch;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_EngineFwdSpeedMultiplier;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip m_WindSound;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_WindBasePitch;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_WindSpeedPitchFactor;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_WindMaxSpeedVolume;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AdvancedSetttings m_AdvancedSetttings;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource m_EngineSoundSource;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource m_WindSoundSource;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x133665C", Offset = "0x133665C", VA = "0x133665C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1336894", Offset = "0x1336894", VA = "0x1336894")]
		private void Update()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1336A54", Offset = "0x1336A54", VA = "0x1336A54")]
		public AeroplaneAudio()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public class ControlSurface
		{
			[Token(Token = "0x2000102")]
			public enum Type
			{
				[Token(Token = "0x400043B")]
				Aileron,
				[Token(Token = "0x400043C")]
				Elevator,
				[Token(Token = "0x400043D")]
				Rudder,
				[Token(Token = "0x400043E")]
				RuddervatorNegative,
				[Token(Token = "0x400043F")]
				RuddervatorPositive
			}

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float amount;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Type type;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public Quaternion originalLocalRotation;

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1336F30", Offset = "0x1336F30", VA = "0x1336F30")]
			public ControlSurface()
			{
			}
		}

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Smoothing;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControlSurface[] m_ControlSurfaces;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1336B24", Offset = "0x1336B24", VA = "0x1336B24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1336BF4", Offset = "0x1336BF4", VA = "0x1336BF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1336DCC", Offset = "0x1336DCC", VA = "0x1336DCC")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1336F20", Offset = "0x1336F20", VA = "0x1336F20")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAA80", Offset = "0xABAA80")]
	public class AeroplaneController : MonoBehaviour
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxEnginePower;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Lift;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ZeroLiftSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_RollEffect;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PitchEffect;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_YawEffect;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BankedTurnEffect;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AerodynamicEffect;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AutoTurnPitch;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_AutoRollLevel;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AutoPitchLevel;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_AirBrakesEffect;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_ThrottleChangeSpeed;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_DragIncreaseFactor;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBE54", Offset = "0xABBE54")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBE64", Offset = "0xABBE64")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBE74", Offset = "0xABBE74")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBE84", Offset = "0xABBE84")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBE94", Offset = "0xABBE94")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBEA4", Offset = "0xABBEA4")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBEB4", Offset = "0xABBEB4")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBEC4", Offset = "0xABBEC4")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBED4", Offset = "0xABBED4")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBEE4", Offset = "0xABBEE4")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABBEF4", Offset = "0xABBEF4")]
		private float <ThrottleInput>k__BackingField;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_OriginalDrag;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_OriginalAngularDrag;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_AeroFactor;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_Immobilized;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_BankedTurnAmount;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x17000017")]
		public float Altitude
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1336F38", Offset = "0x1336F38", VA = "0x1336F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCC8C", Offset = "0xABCC8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1336F40", Offset = "0x1336F40", VA = "0x1336F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCC9C", Offset = "0xABCC9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float Throttle
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1336F48", Offset = "0x1336F48", VA = "0x1336F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCCAC", Offset = "0xABCCAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1336F50", Offset = "0x1336F50", VA = "0x1336F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCCBC", Offset = "0xABCCBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool AirBrakes
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1336F58", Offset = "0x1336F58", VA = "0x1336F58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCCCC", Offset = "0xABCCCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1336F60", Offset = "0x1336F60", VA = "0x1336F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCCDC", Offset = "0xABCCDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float ForwardSpeed
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1336F6C", Offset = "0x1336F6C", VA = "0x1336F6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCCEC", Offset = "0xABCCEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1336F74", Offset = "0x1336F74", VA = "0x1336F74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCCFC", Offset = "0xABCCFC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float EnginePower
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1336F7C", Offset = "0x1336F7C", VA = "0x1336F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD0C", Offset = "0xABCD0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1336F84", Offset = "0x1336F84", VA = "0x1336F84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD1C", Offset = "0xABCD1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float MaxEnginePower
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1336F8C", Offset = "0x1336F8C", VA = "0x1336F8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float RollAngle
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1336F94", Offset = "0x1336F94", VA = "0x1336F94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD2C", Offset = "0xABCD2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1336F9C", Offset = "0x1336F9C", VA = "0x1336F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD3C", Offset = "0xABCD3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float PitchAngle
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1336FA4", Offset = "0x1336FA4", VA = "0x1336FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD4C", Offset = "0xABCD4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1336FAC", Offset = "0x1336FAC", VA = "0x1336FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD5C", Offset = "0xABCD5C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float RollInput
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1336FB4", Offset = "0x1336FB4", VA = "0x1336FB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD6C", Offset = "0xABCD6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1336FBC", Offset = "0x1336FBC", VA = "0x1336FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD7C", Offset = "0xABCD7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float PitchInput
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1336FC4", Offset = "0x1336FC4", VA = "0x1336FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD8C", Offset = "0xABCD8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1336FCC", Offset = "0x1336FCC", VA = "0x1336FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCD9C", Offset = "0xABCD9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float YawInput
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1336FD4", Offset = "0x1336FD4", VA = "0x1336FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCDAC", Offset = "0xABCDAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1336FDC", Offset = "0x1336FDC", VA = "0x1336FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCDBC", Offset = "0xABCDBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float ThrottleInput
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1336FE4", Offset = "0x1336FE4", VA = "0x1336FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCDCC", Offset = "0xABCDCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1336FEC", Offset = "0x1336FEC", VA = "0x1336FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCDDC", Offset = "0xABCDDC")]
			private set
			{
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1336FF4", Offset = "0x1336FF4", VA = "0x1336FF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x13365C0", Offset = "0x13365C0", VA = "0x13365C0")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1337160", Offset = "0x1337160", VA = "0x1337160")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1337248", Offset = "0x1337248", VA = "0x1337248")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x13373C4", Offset = "0x13373C4", VA = "0x13373C4")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x13374B0", Offset = "0x13374B0", VA = "0x13374B0")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1337568", Offset = "0x1337568", VA = "0x1337568")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x133762C", Offset = "0x133762C", VA = "0x133762C")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x13376D8", Offset = "0x13376D8", VA = "0x13376D8")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x13379A4", Offset = "0x13379A4", VA = "0x13379A4")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1337BC8", Offset = "0x1337BC8", VA = "0x1337BC8")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1337E34", Offset = "0x1337E34", VA = "0x1337E34")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1337FC4", Offset = "0x1337FC4", VA = "0x1337FC4")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1337FD0", Offset = "0x1337FD0", VA = "0x1337FD0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1337FD8", Offset = "0x1337FD8", VA = "0x1337FD8")]
		public AeroplaneController()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class AeroplanePropellerAnimator : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PropellorModel;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PropellorBlur;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D[] m_PropellorBlurTextures;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABBF34", Offset = "0xABBF34")]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABBF74", Offset = "0xABBF74")]
		private float m_ThrottleBlurEnd;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxRpm;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_PropellorBlurState;

		[Token(Token = "0x4000197")]
		private const float k_RpmToDps = 60f;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer m_PropellorModelRenderer;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer m_PropellorBlurRenderer;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1F27DEC", Offset = "0x1F27DEC", VA = "0x1F27DEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1F27EBC", Offset = "0x1F27EBC", VA = "0x1F27EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1F2809C", Offset = "0x1F2809C", VA = "0x1F2809C")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAAE4", Offset = "0xABAAE4")]
	public class AeroplaneUserControl2Axis : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1F280C0", Offset = "0x1F280C0", VA = "0x1F280C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1F28120", Offset = "0x1F28120", VA = "0x1F28120")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1F28224", Offset = "0x1F28224", VA = "0x1F28224")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1F2835C", Offset = "0x1F2835C", VA = "0x1F2835C")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAB48", Offset = "0xABAB48")]
	public class AeroplaneUserControl4Axis : MonoBehaviour
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_Throttle;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_AirBrakes;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Yaw;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1F28370", Offset = "0x1F28370", VA = "0x1F28370")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1F283D0", Offset = "0x1F283D0", VA = "0x1F283D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1F284EC", Offset = "0x1F284EC", VA = "0x1F284EC")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1F285E4", Offset = "0x1F285E4", VA = "0x1F285E4")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABABAC", Offset = "0xABABAC")]
	public class JetParticleEffect : MonoBehaviour
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color minColour;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Jet;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_System;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_OriginalStartSize;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_OriginalLifetime;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color m_OriginalStartColor;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1F285F8", Offset = "0x1F285F8", VA = "0x1F285F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1F288A0", Offset = "0x1F288A0", VA = "0x1F288A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1F28770", Offset = "0x1F28770", VA = "0x1F28770")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1F28A28", Offset = "0x1F28A28", VA = "0x1F28A28")]
		public JetParticleEffect()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class LandingGear : MonoBehaviour
	{
		[Token(Token = "0x200009C")]
		private enum GearState
		{
			[Token(Token = "0x4000350")]
			Raised = -1,
			[Token(Token = "0x4000351")]
			Lowered = 1
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float raiseAtAltitude;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lowerAtAltitude;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GearState m_State;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1F28A30", Offset = "0x1F28A30", VA = "0x1F28A30")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1F28AD8", Offset = "0x1F28AD8", VA = "0x1F28AD8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1F28BC4", Offset = "0x1F28BC4", VA = "0x1F28BC4")]
		public LandingGear()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x200004E")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001B3")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1F28BE0", Offset = "0x1F28BE0", VA = "0x1F28BE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1F28C60", Offset = "0x1F28C60", VA = "0x1F28C60")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1F28E5C", Offset = "0x1F28E5C", VA = "0x1F28E5C")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1F28E80", Offset = "0x1F28E80", VA = "0x1F28E80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1F28F88", Offset = "0x1F28F88", VA = "0x1F28F88")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1F29230", Offset = "0x1F29230", VA = "0x1F29230")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1F2926C", Offset = "0x1F2926C", VA = "0x1F2926C")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAC10", Offset = "0xABAC10")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAC10", Offset = "0xABAC10")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC004", Offset = "0xABC004")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC014", Offset = "0xABC014")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000023")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x13289FC", Offset = "0x13289FC", VA = "0x13289FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCDEC", Offset = "0xABCDEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1328A04", Offset = "0x1328A04", VA = "0x1328A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCDFC", Offset = "0xABCDFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1328A0C", Offset = "0x1328A0C", VA = "0x1328A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCE0C", Offset = "0xABCE0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1328A14", Offset = "0x1328A14", VA = "0x1328A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCE1C", Offset = "0xABCE1C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1328A1C", Offset = "0x1328A1C", VA = "0x1328A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1328AD0", Offset = "0x1328AD0", VA = "0x1328AD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1328DAC", Offset = "0x1328DAC", VA = "0x1328DAC")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1328DB4", Offset = "0x1328DB4", VA = "0x1328DB4")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAC9C", Offset = "0xABAC9C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAC9C", Offset = "0xABAC9C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAC9C", Offset = "0xABAC9C")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC054", Offset = "0xABC054")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40001C9")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1328DBC", Offset = "0x1328DBC", VA = "0x1328DBC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1328BF4", Offset = "0x1328BF4", VA = "0x1328BF4")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x132936C", Offset = "0x132936C", VA = "0x132936C")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1329608", Offset = "0x1329608", VA = "0x1329608")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x13297C0", Offset = "0x13297C0", VA = "0x13297C0")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1329258", Offset = "0x1329258", VA = "0x1329258")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1329118", Offset = "0x1329118", VA = "0x1329118")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1329048", Offset = "0x1329048", VA = "0x1329048")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1329A0C", Offset = "0x1329A0C", VA = "0x1329A0C")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1328EB4", Offset = "0x1328EB4", VA = "0x1328EB4")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1329B3C", Offset = "0x1329B3C", VA = "0x1329B3C")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAD50", Offset = "0xABAD50")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1329B5C", Offset = "0x1329B5C", VA = "0x1329B5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1329C78", Offset = "0x1329C78", VA = "0x1329C78")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1329CF8", Offset = "0x1329CF8", VA = "0x1329CF8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1329F9C", Offset = "0x1329F9C", VA = "0x1329F9C")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABADB4", Offset = "0xABADB4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABADB4", Offset = "0xABADB4")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC104", Offset = "0xABC104")]
		private float m_RunstepLenghten;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1325B18", Offset = "0x1325B18", VA = "0x1325B18")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1325D88", Offset = "0x1325D88", VA = "0x1325D88")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1325FEC", Offset = "0x1325FEC", VA = "0x1325FEC")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1326040", Offset = "0x1326040", VA = "0x1326040")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x132659C", Offset = "0x132659C", VA = "0x132659C")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x13265DC", Offset = "0x13265DC", VA = "0x13265DC")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x13268B4", Offset = "0x13268B4", VA = "0x13268B4")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x13266E0", Offset = "0x13266E0", VA = "0x13266E0")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1326404", Offset = "0x1326404", VA = "0x1326404")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1325E9C", Offset = "0x1325E9C", VA = "0x1325E9C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1326F2C", Offset = "0x1326F2C", VA = "0x1326F2C")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x13270AC", Offset = "0x13270AC", VA = "0x13270AC")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC214", Offset = "0xABC214")]
		public float RunningStrideLengthen;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1327434", Offset = "0x1327434", VA = "0x1327434")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x132748C", Offset = "0x132748C", VA = "0x132748C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x132769C", Offset = "0x132769C", VA = "0x132769C")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class MouseLook
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1325D34", Offset = "0x1325D34", VA = "0x1325D34")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1326C3C", Offset = "0x1326C3C", VA = "0x1326C3C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1327800", Offset = "0x1327800", VA = "0x1327800")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x13268A4", Offset = "0x13268A4", VA = "0x13268A4")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1327834", Offset = "0x1327834", VA = "0x1327834")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1327738", Offset = "0x1327738", VA = "0x1327738")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x13278B0", Offset = "0x13278B0", VA = "0x13278B0")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAE40", Offset = "0xABAE40")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAE40", Offset = "0xABAE40")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009D")]
		public class MovementSettings
		{
			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1328648", Offset = "0x1328648", VA = "0x1328648")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x132881C", Offset = "0x132881C", VA = "0x132881C")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009E")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xABC57C", Offset = "0xABC57C")]
			public float shellOffset;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x13289E0", Offset = "0x13289E0", VA = "0x13289E0")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000025")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1327678", Offset = "0x1327678", VA = "0x1327678")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public bool Grounded
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x13278E4", Offset = "0x13278E4", VA = "0x13278E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public bool Jumping
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x13278EC", Offset = "0x13278EC", VA = "0x13278EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public bool Running
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1327694", Offset = "0x1327694", VA = "0x1327694")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x13278F4", Offset = "0x13278F4", VA = "0x13278F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x13279B8", Offset = "0x13279B8", VA = "0x13279B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1327C4C", Offset = "0x1327C4C", VA = "0x1327C4C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1328310", Offset = "0x1328310", VA = "0x1328310")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x13283C8", Offset = "0x13283C8", VA = "0x13283C8")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1328260", Offset = "0x1328260", VA = "0x1328260")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1327A44", Offset = "0x1327A44", VA = "0x1327A44")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1328078", Offset = "0x1328078", VA = "0x1328078")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1328714", Offset = "0x1328714", VA = "0x1328714")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000057")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public enum UpdateType
		{
			[Token(Token = "0x4000360")]
			FixedUpdate,
			[Token(Token = "0x4000361")]
			LateUpdate,
			[Token(Token = "0x4000362")]
			ManualUpdate
		}

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000029")]
		public Transform Target
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1323B04", Offset = "0x1323B04", VA = "0x1323B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1323700", Offset = "0x1323700", VA = "0x1323700", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1323878", Offset = "0x1323878", VA = "0x1323878")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x132394C", Offset = "0x132394C", VA = "0x132394C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1323A24", Offset = "0x1323A24", VA = "0x1323A24")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000200")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x13237BC", Offset = "0x13237BC", VA = "0x13237BC")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1323AFC", Offset = "0x1323AFC", VA = "0x1323AFC", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1323B0C", Offset = "0x1323B0C", VA = "0x1323B0C")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1323B1C", Offset = "0x1323B1C", VA = "0x1323B1C", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1324090", Offset = "0x1324090", VA = "0x1324090")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC2EC", Offset = "0xABC2EC")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x400022C")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x132414C", Offset = "0x132414C", VA = "0x132414C", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x13242A0", Offset = "0x13242A0", VA = "0x13242A0")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1324690", Offset = "0x1324690", VA = "0x1324690")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x13246B4", Offset = "0x13246B4", VA = "0x13246B4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1324300", Offset = "0x1324300", VA = "0x1324300")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x132487C", Offset = "0x132487C", VA = "0x132487C")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC3AC", Offset = "0xABC3AC")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x13248A4", Offset = "0x13248A4", VA = "0x13248A4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1324D48", Offset = "0x1324D48", VA = "0x1324D48")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1324D88", Offset = "0x1324D88", VA = "0x1324D88", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1324A34", Offset = "0x1324A34", VA = "0x1324A34", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1324D70", Offset = "0x1324D70", VA = "0x1324D70")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x132420C", Offset = "0x132420C", VA = "0x132420C", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x132413C", Offset = "0x132413C", VA = "0x132413C")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x13255E4", Offset = "0x13255E4", VA = "0x13255E4", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1324EE4", Offset = "0x1324EE4", VA = "0x1324EE4")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC40C", Offset = "0xABC40C")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700002A")]
		public bool protecting
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1324DCC", Offset = "0x1324DCC", VA = "0x1324DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCE2C", Offset = "0xABCE2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1324DD4", Offset = "0x1324DD4", VA = "0x1324DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCE3C", Offset = "0xABCE3C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1324DE0", Offset = "0x1324DE0", VA = "0x1324DE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1324EEC", Offset = "0x1324EEC", VA = "0x1324EEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1325564", Offset = "0x1325564", VA = "0x1325564")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x13256EC", Offset = "0x13256EC", VA = "0x13256EC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1325944", Offset = "0x1325944", VA = "0x1325944", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1325AC0", Offset = "0x1325AC0", VA = "0x1325AC0", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1325764", Offset = "0x1325764", VA = "0x1325764")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1325AFC", Offset = "0x1325AFC", VA = "0x1325AFC")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets._2D
{
	[Token(Token = "0x200005F")]
	public class Camera2DFollow : MonoBehaviour
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1F313A0", Offset = "0x1F313A0", VA = "0x1F313A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1F314B0", Offset = "0x1F314B0", VA = "0x1F314B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1F317D0", Offset = "0x1F317D0", VA = "0x1F317D0")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1F317E4", Offset = "0x1F317E4", VA = "0x1F317E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1F31854", Offset = "0x1F31854", VA = "0x1F31854")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1F31900", Offset = "0x1F31900", VA = "0x1F31900")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1F319AC", Offset = "0x1F319AC", VA = "0x1F319AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1F319B0", Offset = "0x1F319B0", VA = "0x1F319B0")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1F31C08", Offset = "0x1F31C08", VA = "0x1F31C08")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xABAEDC", Offset = "0xABAEDC")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1F31C1C", Offset = "0x1F31C1C", VA = "0x1F31C1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1F31C7C", Offset = "0x1F31C7C", VA = "0x1F31C7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1F31D00", Offset = "0x1F31D00", VA = "0x1F31D00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1F32084", Offset = "0x1F32084", VA = "0x1F32084")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xABC46C", Offset = "0xABC46C")]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x400026A")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x400026D")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1F3208C", Offset = "0x1F3208C", VA = "0x1F3208C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1F3217C", Offset = "0x1F3217C", VA = "0x1F3217C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1F31DA4", Offset = "0x1F31DA4", VA = "0x1F31DA4")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1F32388", Offset = "0x1F32388", VA = "0x1F32388")]
		private void Flip()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1F32404", Offset = "0x1F32404", VA = "0x1F32404")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1F3242C", Offset = "0x1F3242C", VA = "0x1F3242C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1F324E8", Offset = "0x1F324E8", VA = "0x1F324E8")]
		public Restarter()
		{
		}
	}
}
namespace PathologicalGames
{
	[Token(Token = "0x2000064")]
	public static class PoolManager
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SpawnPoolsDict Pools;
	}
	[Token(Token = "0x2000065")]
	public static class InstanceHandler
	{
		[Token(Token = "0x20000A1")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000A2")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static InstantiateDelegate InstantiateDelegates;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static DestroyDelegate DestroyDelegates;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1131C1C", Offset = "0x1131C1C", VA = "0x1131C1C")]
		internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1132220", Offset = "0x1132220", VA = "0x1132220")]
		internal static void DestroyInstance(GameObject instance)
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xABAF40", Offset = "0xABAF40")]
	public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
	{
		[Token(Token = "0x20000A3")]
		public delegate void OnCreatedDelegate(SpawnPool pool);

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Dictionary<string, OnCreatedDelegate> onCreatedDelegates;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, SpawnPool> _pools;

		[Token(Token = "0x1700002B")]
		public int Count
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1322F08", Offset = "0x1322F08", VA = "0x1322F08", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public SpawnPool Item
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x132303C", Offset = "0x132303C", VA = "0x132303C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x132317C", Offset = "0x132317C", VA = "0x132317C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x13231E8", Offset = "0x13231E8", VA = "0x13231E8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public ICollection<SpawnPool> Values
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1323254", Offset = "0x1323254", VA = "0x1323254", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x13232C0", Offset = "0x13232C0", VA = "0x13232C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.IsReadOnly
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x13232C8", Offset = "0x13232C8", VA = "0x13232C8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1321DC8", Offset = "0x1321DC8", VA = "0x1321DC8")]
		public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1321F20", Offset = "0x1321F20", VA = "0x1321F20")]
		public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x13220B0", Offset = "0x13220B0", VA = "0x13220B0")]
		public SpawnPool Create(string poolName)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1322148", Offset = "0x1322148", VA = "0x1322148")]
		public SpawnPool Create(string poolName, GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1322264", Offset = "0x1322264", VA = "0x1322264")]
		private bool assertValidPoolName(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1322418", Offset = "0x1322418", VA = "0x1322418", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x13224F8", Offset = "0x13224F8", VA = "0x13224F8")]
		public bool Destroy(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1322630", Offset = "0x1322630", VA = "0x1322630")]
		public void DestroyAll()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1322818", Offset = "0x1322818", VA = "0x1322818")]
		internal void Add(SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1322CDC", Offset = "0x1322CDC", VA = "0x1322CDC", Slot = "9")]
		public void Add(string key, SpawnPool value)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1322D48", Offset = "0x1322D48", VA = "0x1322D48")]
		internal bool Remove(SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1322E9C", Offset = "0x1322E9C", VA = "0x1322E9C", Slot = "10")]
		public bool Remove(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x13223B0", Offset = "0x13223B0", VA = "0x13223B0", Slot = "8")]
		public bool ContainsKey(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1322E34", Offset = "0x1322E34", VA = "0x1322E34")]
		public bool ContainsValue(SpawnPool pool)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1322F60", Offset = "0x1322F60", VA = "0x1322F60", Slot = "11")]
		public bool TryGetValue(string poolName, out SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1322FD0", Offset = "0x1322FD0", VA = "0x1322FD0", Slot = "16")]
		public bool Contains(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x13232D0", Offset = "0x13232D0", VA = "0x13232D0", Slot = "14")]
		public void Add(KeyValuePair<string, SpawnPool> item)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x132333C", Offset = "0x132333C", VA = "0x132333C", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x13233A8", Offset = "0x13233A8", VA = "0x13233A8")]
		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1323414", Offset = "0x1323414", VA = "0x1323414", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1323480", Offset = "0x1323480", VA = "0x1323480", Slot = "18")]
		public bool Remove(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x13234EC", Offset = "0x13234EC", VA = "0x13234EC", Slot = "19")]
		public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x132357C", Offset = "0x132357C", VA = "0x132357C", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x132360C", Offset = "0x132360C", VA = "0x132360C")]
		public SpawnPoolsDict()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xABAF78", Offset = "0xABAF78")]
	public class PreRuntimePoolItem : MonoBehaviour
	{
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poolName;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string prefabName;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool despawnOnStart;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool doNotReparent;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x11327DC", Offset = "0x11327DC", VA = "0x11327DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1132BE8", Offset = "0x1132BE8", VA = "0x1132BE8")]
		public PreRuntimePoolItem()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xABAFB0", Offset = "0xABAFB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xABAFB0", Offset = "0xABAFB0")]
	public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
	{
		[Token(Token = "0x20000A4")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000A5")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB1E0", Offset = "0xABB1E0")]
		private sealed class <DoDespawnAfterSeconds>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform instance;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float seconds;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool useParent;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SpawnPool <>4__this;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform parent;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private GameObject <go>5__2;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0x1320BDC", Offset = "0x1320BDC", VA = "0x1320BDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0x1320C44", Offset = "0x1320C44", VA = "0x1320C44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1320AA8", Offset = "0x1320AA8", VA = "0x1320AA8")]
			[DebuggerHidden]
			public <DoDespawnAfterSeconds>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1320AD4", Offset = "0x1320AD4", VA = "0x1320AD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1320AD8", Offset = "0x1320AD8", VA = "0x1320AD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1320BE4", Offset = "0x1320BE4", VA = "0x1320BE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB1F0", Offset = "0xABB1F0")]
		private sealed class <ListForAudioStop>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioSource src;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpawnPool <>4__this;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject <srcGameObject>5__2;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0x1320F20", Offset = "0x1320F20", VA = "0x1320F20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0x1320F88", Offset = "0x1320F88", VA = "0x1320F88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1320DC8", Offset = "0x1320DC8", VA = "0x1320DC8")]
			[DebuggerHidden]
			public <ListForAudioStop>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1320DF4", Offset = "0x1320DF4", VA = "0x1320DF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1320DF8", Offset = "0x1320DF8", VA = "0x1320DF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1320F28", Offset = "0x1320F28", VA = "0x1320F28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB200", Offset = "0xABB200")]
		private sealed class <ListenForEmitDespawn>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystem emitter;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpawnPool <>4__this;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <safetimer>5__2;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject <emitterGO>5__3;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x1321238", Offset = "0x1321238", VA = "0x1321238", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E6")]
				[Address(RVA = "0x13212A0", Offset = "0x13212A0", VA = "0x13212A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1320F90", Offset = "0x1320F90", VA = "0x1320F90")]
			[DebuggerHidden]
			public <ListenForEmitDespawn>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1320FBC", Offset = "0x1320FBC", VA = "0x1320FBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1320FC0", Offset = "0x1320FC0", VA = "0x1320FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1321240", Offset = "0x1321240", VA = "0x1321240", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB210", Offset = "0xABB210")]
		private sealed class <GetEnumerator>d__73 : IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700006D")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x60003EA")]
				[Address(RVA = "0x1320D58", Offset = "0x1320D58", VA = "0x1320D58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0x1320DC0", Offset = "0x1320DC0", VA = "0x1320DC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1320C4C", Offset = "0x1320C4C", VA = "0x1320C4C")]
			[DebuggerHidden]
			public <GetEnumerator>d__73(int <>1__state)
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1320C78", Offset = "0x1320C78", VA = "0x1320C78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1320C7C", Offset = "0x1320C7C", VA = "0x1320C7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1320D60", Offset = "0x1320D60", VA = "0x1320D60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB220", Offset = "0xABB220")]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0x13213B4", Offset = "0x13213B4", VA = "0x13213B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x132141C", Offset = "0x132141C", VA = "0x132141C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x13212A8", Offset = "0x13212A8", VA = "0x13212A8")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x13212D4", Offset = "0x13212D4", VA = "0x13212D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x13212D8", Offset = "0x13212D8", VA = "0x13212D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x13213BC", Offset = "0x13213BC", VA = "0x13213BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poolName;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool matchPoolScale;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool matchPoolLayer;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool dontReparent;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool _dontDestroyOnLoad;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool logMessages;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<PrefabPool> _perPrefabPoolOptions;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<object, bool> prefabsFoldOutStates;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxParticleDespawnTime;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABC4CC", Offset = "0xABC4CC")]
		private Transform <group>k__BackingField;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PrefabsDict prefabs;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<object, bool> _editorListItemStates;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<PrefabPool> _prefabPools;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InstantiateDelegate instantiateDelegates;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DestroyDelegate destroyDelegates;

		[Token(Token = "0x17000031")]
		public bool dontDestroyOnLoad
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1135B98", Offset = "0x1135B98", VA = "0x1135B98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x1135BA0", Offset = "0x1135BA0", VA = "0x1135BA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Transform group
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1135C78", Offset = "0x1135C78", VA = "0x1135C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCE4C", Offset = "0xABCE4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1135C80", Offset = "0x1135C80", VA = "0x1135C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABCE5C", Offset = "0xABCE5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Dictionary<string, PrefabPool> prefabPools
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1135C88", Offset = "0x1135C88", VA = "0x1135C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public Transform Item
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1138120", Offset = "0x1138120", VA = "0x1138120", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1138198", Offset = "0x1138198", VA = "0x1138198", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int Count
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x11382E0", Offset = "0x11382E0", VA = "0x11382E0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x11385A8", Offset = "0x11385A8", VA = "0x11385A8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1135DA4", Offset = "0x1135DA4", VA = "0x1135DA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1133F44", Offset = "0x1133F44", VA = "0x1133F44")]
		internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1133308", Offset = "0x1133308", VA = "0x1133308")]
		internal void DestroyInstance(GameObject instance)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1136260", Offset = "0x1136260", VA = "0x1136260")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x11360A8", Offset = "0x11360A8", VA = "0x11360A8")]
		public void CreatePrefabPool(PrefabPool prefabPool)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1132908", Offset = "0x1132908", VA = "0x1132908")]
		public void Add(Transform instance, string prefabName, bool despawn, bool parent)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1136634", Offset = "0x1136634", VA = "0x1136634", Slot = "11")]
		public void Add(Transform item)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x11366A0", Offset = "0x11366A0", VA = "0x11366A0")]
		public void Remove(Transform item)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x113670C", Offset = "0x113670C", VA = "0x113670C")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1136B4C", Offset = "0x1136B4C", VA = "0x1136B4C")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1136C40", Offset = "0x1136C40", VA = "0x1136C40")]
		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1136D2C", Offset = "0x1136D2C", VA = "0x1136D2C")]
		public Transform Spawn(Transform prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1136E20", Offset = "0x1136E20", VA = "0x1136E20")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1136EB8", Offset = "0x1136EB8", VA = "0x1136EB8")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1136F48", Offset = "0x1136F48", VA = "0x1136F48")]
		public Transform Spawn(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1136F80", Offset = "0x1136F80", VA = "0x1136F80")]
		public Transform Spawn(GameObject prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1136FC0", Offset = "0x1136FC0", VA = "0x1136FC0")]
		public Transform Spawn(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1136FF4", Offset = "0x1136FF4", VA = "0x1136FF4")]
		public Transform Spawn(string prefabName, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1137030", Offset = "0x1137030", VA = "0x1137030")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x11370BC", Offset = "0x11370BC", VA = "0x11370BC")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1137150", Offset = "0x1137150", VA = "0x1137150")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x11372AC", Offset = "0x11372AC", VA = "0x11372AC")]
		public AudioSource Spawn(AudioSource prefab)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x113739C", Offset = "0x113739C", VA = "0x113739C")]
		public AudioSource Spawn(AudioSource prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1137158", Offset = "0x1137158", VA = "0x1137158")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1137528", Offset = "0x1137528", VA = "0x1137528")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1137530", Offset = "0x1137530", VA = "0x1137530")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1137710", Offset = "0x1137710", VA = "0x1137710")]
		public void Despawn(Transform instance)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1137938", Offset = "0x1137938", VA = "0x1137938")]
		public void Despawn(Transform instance, Transform parent)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x11379C0", Offset = "0x11379C0", VA = "0x11379C0")]
		public void Despawn(Transform instance, float seconds)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1137AC4", Offset = "0x1137AC4", VA = "0x1137AC4")]
		public void Despawn(Transform instance, float seconds, Transform parent)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x11379F4", Offset = "0x11379F4", VA = "0x11379F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCE6C", Offset = "0xABCE6C")]
		private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1137AF8", Offset = "0x1137AF8", VA = "0x1137AF8")]
		public void DespawnAll()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1137BB8", Offset = "0x1137BB8", VA = "0x1137BB8")]
		public bool IsSpawned(Transform instance)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1136464", Offset = "0x1136464", VA = "0x1136464")]
		public PrefabPool GetPrefabPool(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1137C20", Offset = "0x1137C20", VA = "0x1137C20")]
		public PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1137DD0", Offset = "0x1137DD0", VA = "0x1137DD0")]
		public Transform GetPrefab(Transform instance)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1137EB0", Offset = "0x1137EB0", VA = "0x1137EB0")]
		public GameObject GetPrefab(GameObject instance)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1137490", Offset = "0x1137490", VA = "0x1137490")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCED0", Offset = "0xABCED0")]
		private IEnumerator ListForAudioStop(AudioSource src)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1137678", Offset = "0x1137678", VA = "0x1137678")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCF34", Offset = "0xABCF34")]
		private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1137FA4", Offset = "0x1137FA4", VA = "0x1137FA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1138204", Offset = "0x1138204", VA = "0x1138204", Slot = "13")]
		public bool Contains(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1138270", Offset = "0x1138270", VA = "0x1138270", Slot = "14")]
		public void CopyTo(Transform[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1138330", Offset = "0x1138330", VA = "0x1138330", Slot = "16")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCF98", Offset = "0xABCF98")]
		public IEnumerator<Transform> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x11383AC", Offset = "0x11383AC", VA = "0x11383AC", Slot = "17")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABCFFC", Offset = "0xABCFFC")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1138428", Offset = "0x1138428", VA = "0x1138428", Slot = "6")]
		public int IndexOf(Transform item)
		{
			return default(int);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1138488", Offset = "0x1138488", VA = "0x1138488", Slot = "7")]
		public void Insert(int index, Transform item)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x11384E8", Offset = "0x11384E8", VA = "0x11384E8", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1138548", Offset = "0x1138548", VA = "0x1138548", Slot = "12")]
		public void Clear()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1138608", Offset = "0x1138608", VA = "0x1138608", Slot = "15")]
		private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1138668", Offset = "0x1138668", VA = "0x1138668")]
		public SpawnPool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class PrefabPool
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB230", Offset = "0xABB230")]
		private sealed class <CullDespawned>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabPool <>4__this;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F6")]
				[Address(RVA = "0x1134E0C", Offset = "0x1134E0C", VA = "0x1134E0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x1134E74", Offset = "0x1134E74", VA = "0x1134E74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x11336EC", Offset = "0x11336EC", VA = "0x11336EC")]
			[DebuggerHidden]
			public <CullDespawned>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1134880", Offset = "0x1134880", VA = "0x1134880", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1134884", Offset = "0x1134884", VA = "0x1134884", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1134E14", Offset = "0x1134E14", VA = "0x1134E14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB240", Offset = "0xABB240")]
		private sealed class <PreloadOverTime>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabPool <>4__this;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <remainder>5__2;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <numPerFrame>5__3;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <numThisFrame>5__4;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <i>5__5;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <n>5__6;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003FC")]
				[Address(RVA = "0x113508C", Offset = "0x113508C", VA = "0x113508C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FE")]
				[Address(RVA = "0x11350F4", Offset = "0x11350F4", VA = "0x11350F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x113472C", Offset = "0x113472C", VA = "0x113472C")]
			[DebuggerHidden]
			public <PreloadOverTime>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1134E7C", Offset = "0x1134E7C", VA = "0x1134E7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1134E80", Offset = "0x1134E80", VA = "0x1134E80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1135094", Offset = "0x1135094", VA = "0x1135094", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform prefab;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal GameObject prefabGO;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int preloadAmount;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool preloadTime;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int preloadFrames;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float preloadDelay;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool limitInstances;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int limitAmount;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool limitFIFO;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool cullDespawned;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int cullAbove;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int cullDelay;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int cullMaxPerPass;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool _logMessages;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool forceLoggingSilent;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpawnPool spawnPool;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool cullingActive;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal List<Transform> _despawned;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _preloaded;

		[Token(Token = "0x17000037")]
		public bool logMessages
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1132C60", Offset = "0x1132C60", VA = "0x1132C60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public List<Transform> spawned
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x1133320", Offset = "0x1133320", VA = "0x1133320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public List<Transform> despawned
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1133390", Offset = "0x1133390", VA = "0x1133390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public int totalCount
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1133400", Offset = "0x1133400", VA = "0x1133400")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		internal bool preloaded
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1133460", Offset = "0x1133460", VA = "0x1133460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1133468", Offset = "0x1133468", VA = "0x1133468")]
			private set
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1132CA4", Offset = "0x1132CA4", VA = "0x1132CA4")]
		public PrefabPool(Transform prefab)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1132DB8", Offset = "0x1132DB8", VA = "0x1132DB8")]
		public PrefabPool()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1132E8C", Offset = "0x1132E8C", VA = "0x1132E8C")]
		internal void inspectorInstanceConstructor()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1132F4C", Offset = "0x1132F4C", VA = "0x1132F4C")]
		internal void SelfDestruct()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1133474", Offset = "0x1133474", VA = "0x1133474")]
		internal bool DespawnInstance(Transform xform)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1133490", Offset = "0x1133490", VA = "0x1133490")]
		internal bool DespawnInstance(Transform xform, bool sendEventMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1133670", Offset = "0x1133670", VA = "0x1133670")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABD060", Offset = "0xABD060")]
		internal IEnumerator CullDespawned()
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1133718", Offset = "0x1133718", VA = "0x1133718")]
		internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1133E68", Offset = "0x1133E68", VA = "0x1133E68")]
		public Transform SpawnNew()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1133A90", Offset = "0x1133A90", VA = "0x1133A90")]
		public Transform SpawnNew(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x113400C", Offset = "0x113400C", VA = "0x113400C")]
		private void SetRecursively(Transform xform, int layer)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1134284", Offset = "0x1134284", VA = "0x1134284")]
		internal void AddUnpooled(Transform inst, bool despawn)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1134328", Offset = "0x1134328", VA = "0x1134328")]
		internal void PreloadInstances()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x11346B0", Offset = "0x11346B0", VA = "0x11346B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xABD0C4", Offset = "0xABD0C4")]
		private IEnumerator PreloadOverTime()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1134758", Offset = "0x1134758", VA = "0x1134758")]
		public bool Contains(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1133F5C", Offset = "0x1133F5C", VA = "0x1133F5C")]
		private void nameInstance(Transform instance)
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xABB010", Offset = "0xABB010")]
	public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Transform> _prefabs;

		[Token(Token = "0x1700003C")]
		public int Count
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x113530C", Offset = "0x113530C", VA = "0x113530C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public Transform Item
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1135580", Offset = "0x1135580", VA = "0x1135580", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x11356C0", Offset = "0x11356C0", VA = "0x11356C0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x113572C", Offset = "0x113572C", VA = "0x113572C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public ICollection<Transform> Values
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1135784", Offset = "0x1135784", VA = "0x1135784", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x11357DC", Offset = "0x11357DC", VA = "0x11357DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x11357E4", Offset = "0x11357E4", VA = "0x11357E4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x11350FC", Offset = "0x11350FC", VA = "0x11350FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x11351DC", Offset = "0x11351DC", VA = "0x11351DC")]
		internal void _Add(string prefabName, Transform prefab)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x113524C", Offset = "0x113524C", VA = "0x113524C")]
		internal bool _Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x11352B4", Offset = "0x11352B4", VA = "0x11352B4")]
		internal void _Clear()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1135364", Offset = "0x1135364", VA = "0x1135364", Slot = "8")]
		public bool ContainsKey(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x11353CC", Offset = "0x11353CC", VA = "0x11353CC", Slot = "11")]
		public bool TryGetValue(string prefabName, out Transform prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x113543C", Offset = "0x113543C", VA = "0x113543C", Slot = "9")]
		public void Add(string key, Transform value)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x11354A8", Offset = "0x11354A8", VA = "0x11354A8", Slot = "10")]
		public bool Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1135514", Offset = "0x1135514", VA = "0x1135514", Slot = "16")]
		public bool Contains(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x11357EC", Offset = "0x11357EC", VA = "0x11357EC", Slot = "14")]
		public void Add(KeyValuePair<string, Transform> item)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1135858", Offset = "0x1135858", VA = "0x1135858", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x11358B8", Offset = "0x11358B8", VA = "0x11358B8")]
		private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1135924", Offset = "0x1135924", VA = "0x1135924", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1135990", Offset = "0x1135990", VA = "0x1135990", Slot = "18")]
		public bool Remove(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x11359FC", Offset = "0x11359FC", VA = "0x11359FC", Slot = "19")]
		public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1135A8C", Offset = "0x1135A8C", VA = "0x1135A8C", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1135B1C", Offset = "0x1135B1C", VA = "0x1135B1C")]
		public PrefabsDict()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200006B")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB250", Offset = "0xABB250")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x112722C", Offset = "0x112722C", VA = "0x112722C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1127A1C", Offset = "0x1127A1C", VA = "0x1127A1C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x1127A38", Offset = "0x1127A38", VA = "0x1127A38")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB260", Offset = "0xABB260")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1127380", Offset = "0x1127380", VA = "0x1127380")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1127A54", Offset = "0x1127A54", VA = "0x1127A54")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1127A70", Offset = "0x1127A70", VA = "0x1127A70")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB270", Offset = "0xABB270")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x11274E8", Offset = "0x11274E8", VA = "0x11274E8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1127A8C", Offset = "0x1127A8C", VA = "0x1127A8C")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1127ACC", Offset = "0x1127ACC", VA = "0x1127ACC")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x11270B8", Offset = "0x11270B8", VA = "0x11270B8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1127234", Offset = "0x1127234", VA = "0x1127234")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1127388", Offset = "0x1127388", VA = "0x1127388")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x11274F0", Offset = "0x11274F0", VA = "0x11274F0")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1127568", Offset = "0x1127568", VA = "0x1127568")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x11275E0", Offset = "0x11275E0", VA = "0x11275E0")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1127648", Offset = "0x1127648", VA = "0x1127648")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11276D0", Offset = "0x11276D0", VA = "0x11276D0")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1127738", Offset = "0x1127738", VA = "0x1127738")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11277A0", Offset = "0x11277A0", VA = "0x11277A0")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1127808", Offset = "0x1127808", VA = "0x1127808")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1127870", Offset = "0x1127870", VA = "0x1127870")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11278E0", Offset = "0x11278E0", VA = "0x11278E0")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x112794C", Offset = "0x112794C", VA = "0x112794C")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11279B4", Offset = "0x11279B4", VA = "0x11279B4")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200006C")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB280", Offset = "0xABB280")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1127AF0", Offset = "0x1127AF0", VA = "0x1127AF0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1128DFC", Offset = "0x1128DFC", VA = "0x1128DFC")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB290", Offset = "0xABB290")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x1127C90", Offset = "0x1127C90", VA = "0x1127C90")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1128F38", Offset = "0x1128F38", VA = "0x1128F38")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB2A0", Offset = "0xABB2A0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1127E30", Offset = "0x1127E30", VA = "0x1127E30")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1128F54", Offset = "0x1128F54", VA = "0x1128F54")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB2B0", Offset = "0xABB2B0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1127FD0", Offset = "0x1127FD0", VA = "0x1127FD0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1128F70", Offset = "0x1128F70", VA = "0x1128F70")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB2C0", Offset = "0xABB2C0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1127FD8", Offset = "0x1127FD8", VA = "0x1127FD8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1128F8C", Offset = "0x1128F8C", VA = "0x1128F8C")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB2D0", Offset = "0xABB2D0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x11281D4", Offset = "0x11281D4", VA = "0x11281D4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1128FA8", Offset = "0x1128FA8", VA = "0x1128FA8")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB2E0", Offset = "0xABB2E0")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x112868C", Offset = "0x112868C", VA = "0x112868C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1128FC4", Offset = "0x1128FC4", VA = "0x1128FC4")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1128FE0", Offset = "0x1128FE0", VA = "0x1128FE0")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1129014", Offset = "0x1129014", VA = "0x1129014")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1129030", Offset = "0x1129030", VA = "0x1129030")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x112904C", Offset = "0x112904C", VA = "0x112904C")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB2F0", Offset = "0xABB2F0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1128890", Offset = "0x1128890", VA = "0x1128890")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x112910C", Offset = "0x112910C", VA = "0x112910C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB300", Offset = "0xABB300")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1128AB4", Offset = "0x1128AB4", VA = "0x1128AB4")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1129128", Offset = "0x1129128", VA = "0x1129128")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1129144", Offset = "0x1129144", VA = "0x1129144")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB310", Offset = "0xABB310")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1128C44", Offset = "0x1128C44", VA = "0x1128C44")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1129248", Offset = "0x1129248", VA = "0x1129248")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB320", Offset = "0xABB320")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1128DF4", Offset = "0x1128DF4", VA = "0x1128DF4")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1128E18", Offset = "0x1128E18", VA = "0x1128E18")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x1128E34", Offset = "0x1128E34", VA = "0x1128E34")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1124564", Offset = "0x1124564", VA = "0x1124564")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1127AF8", Offset = "0x1127AF8", VA = "0x1127AF8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1127C98", Offset = "0x1127C98", VA = "0x1127C98")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1127E38", Offset = "0x1127E38", VA = "0x1127E38")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x112485C", Offset = "0x112485C", VA = "0x112485C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1127FE0", Offset = "0x1127FE0", VA = "0x1127FE0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x11281DC", Offset = "0x11281DC", VA = "0x11281DC")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1128694", Offset = "0x1128694", VA = "0x1128694")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1128898", Offset = "0x1128898", VA = "0x1128898")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1128ABC", Offset = "0x1128ABC", VA = "0x1128ABC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1128C4C", Offset = "0x1128C4C", VA = "0x1128C4C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB330", Offset = "0xABB330")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1129264", Offset = "0x1129264", VA = "0x1129264")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1129EE8", Offset = "0x1129EE8", VA = "0x1129EE8")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB340", Offset = "0xABB340")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x11293F0", Offset = "0x11293F0", VA = "0x11293F0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1129F04", Offset = "0x1129F04", VA = "0x1129F04")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB350", Offset = "0xABB350")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x112957C", Offset = "0x112957C", VA = "0x112957C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x1129F20", Offset = "0x1129F20", VA = "0x1129F20")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB360", Offset = "0xABB360")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1129584", Offset = "0x1129584", VA = "0x1129584")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x1129F3C", Offset = "0x1129F3C", VA = "0x1129F3C")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB370", Offset = "0xABB370")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1129938", Offset = "0x1129938", VA = "0x1129938")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x1129F58", Offset = "0x1129F58", VA = "0x1129F58")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x1129F74", Offset = "0x1129F74", VA = "0x1129F74")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x1129F90", Offset = "0x1129F90", VA = "0x1129F90")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1129FC4", Offset = "0x1129FC4", VA = "0x1129FC4")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1129FE0", Offset = "0x1129FE0", VA = "0x1129FE0")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1129FFC", Offset = "0x1129FFC", VA = "0x1129FFC")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB380", Offset = "0xABB380")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1129BFC", Offset = "0x1129BFC", VA = "0x1129BFC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x112A124", Offset = "0x112A124", VA = "0x112A124")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x112A1B4", Offset = "0x112A1B4", VA = "0x112A1B4")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB390", Offset = "0xABB390")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1129EE0", Offset = "0x1129EE0", VA = "0x1129EE0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x112A258", Offset = "0x112A258", VA = "0x112A258")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x112A274", Offset = "0x112A274", VA = "0x112A274")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x11246E4", Offset = "0x11246E4", VA = "0x11246E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x112926C", Offset = "0x112926C", VA = "0x112926C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11293F8", Offset = "0x11293F8", VA = "0x11293F8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11249D8", Offset = "0x11249D8", VA = "0x11249D8")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x112958C", Offset = "0x112958C", VA = "0x112958C")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1129940", Offset = "0x1129940", VA = "0x1129940")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1129C04", Offset = "0x1129C04", VA = "0x1129C04")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB3A0", Offset = "0xABB3A0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x112A3A0", Offset = "0x112A3A0", VA = "0x112A3A0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x112A784", Offset = "0x112A784", VA = "0x112A784")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x112A7A0", Offset = "0x112A7A0", VA = "0x112A7A0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB3B0", Offset = "0xABB3B0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x112A3A8", Offset = "0x112A3A8", VA = "0x112A3A8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x112A7BC", Offset = "0x112A7BC", VA = "0x112A7BC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x112A7D8", Offset = "0x112A7D8", VA = "0x112A7D8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB3C0", Offset = "0xABB3C0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x112A77C", Offset = "0x112A77C", VA = "0x112A77C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x112A7F4", Offset = "0x112A7F4", VA = "0x112A7F4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x112A800", Offset = "0x112A800", VA = "0x112A800")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1124C9C", Offset = "0x1124C9C", VA = "0x1124C9C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11250F8", Offset = "0x11250F8", VA = "0x11250F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x112A3B0", Offset = "0x112A3B0", VA = "0x112A3B0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x112A588", Offset = "0x112A588", VA = "0x112A588")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20000C5")]
		public static class Utils
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x112413C", Offset = "0x112413C", VA = "0x112413C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB3D0", Offset = "0xABB3D0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x112A8AC", Offset = "0x112A8AC", VA = "0x112A8AC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x112DB4C", Offset = "0x112DB4C", VA = "0x112DB4C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x112DB68", Offset = "0x112DB68", VA = "0x112DB68")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB3E0", Offset = "0xABB3E0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x112A8B4", Offset = "0x112A8B4", VA = "0x112A8B4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x112DDBC", Offset = "0x112DDBC", VA = "0x112DDBC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x112DDE0", Offset = "0x112DDE0", VA = "0x112DDE0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB3F0", Offset = "0xABB3F0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x112A8BC", Offset = "0x112A8BC", VA = "0x112A8BC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x112E448", Offset = "0x112E448", VA = "0x112E448")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x112E46C", Offset = "0x112E46C", VA = "0x112E46C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB400", Offset = "0xABB400")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x112AA38", Offset = "0x112AA38", VA = "0x112AA38")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x112E914", Offset = "0x112E914", VA = "0x112E914")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x112E938", Offset = "0x112E938", VA = "0x112E938")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB410", Offset = "0xABB410")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x112AB8C", Offset = "0x112AB8C", VA = "0x112AB8C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x112EA24", Offset = "0x112EA24", VA = "0x112EA24")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x112EA48", Offset = "0x112EA48", VA = "0x112EA48")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB420", Offset = "0xABB420")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x112AD04", Offset = "0x112AD04", VA = "0x112AD04")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x112EA6C", Offset = "0x112EA6C", VA = "0x112EA6C")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x112EA88", Offset = "0x112EA88", VA = "0x112EA88")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB430", Offset = "0xABB430")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x112B060", Offset = "0x112B060", VA = "0x112B060")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x112EAA4", Offset = "0x112EAA4", VA = "0x112EAA4")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x112EB24", Offset = "0x112EB24", VA = "0x112EB24")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB440", Offset = "0xABB440")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x112B1DC", Offset = "0x112B1DC", VA = "0x112B1DC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x112EB80", Offset = "0x112EB80", VA = "0x112EB80")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x112EC00", Offset = "0x112EC00", VA = "0x112EC00")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB450", Offset = "0xABB450")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x112B358", Offset = "0x112B358", VA = "0x112B358")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x112EC5C", Offset = "0x112EC5C", VA = "0x112EC5C")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x112ECDC", Offset = "0x112ECDC", VA = "0x112ECDC")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB460", Offset = "0xABB460")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x112B4D4", Offset = "0x112B4D4", VA = "0x112B4D4")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x112DB84", Offset = "0x112DB84", VA = "0x112DB84")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x112DBA4", Offset = "0x112DBA4", VA = "0x112DBA4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB470", Offset = "0xABB470")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x112B628", Offset = "0x112B628", VA = "0x112B628")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x112DBC0", Offset = "0x112DBC0", VA = "0x112DBC0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x112DBE0", Offset = "0x112DBE0", VA = "0x112DBE0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB480", Offset = "0xABB480")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x112B78C", Offset = "0x112B78C", VA = "0x112B78C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x112DBFC", Offset = "0x112DBFC", VA = "0x112DBFC")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x112DC18", Offset = "0x112DC18", VA = "0x112DC18")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB490", Offset = "0xABB490")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x112B908", Offset = "0x112B908", VA = "0x112B908")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x112DC34", Offset = "0x112DC34", VA = "0x112DC34")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x112DC50", Offset = "0x112DC50", VA = "0x112DC50")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB4A0", Offset = "0xABB4A0")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x112BA90", Offset = "0x112BA90", VA = "0x112BA90")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x112DC6C", Offset = "0x112DC6C", VA = "0x112DC6C")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x112DC88", Offset = "0x112DC88", VA = "0x112DC88")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB4B0", Offset = "0xABB4B0")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x112BC18", Offset = "0x112BC18", VA = "0x112BC18")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x112DCA4", Offset = "0x112DCA4", VA = "0x112DCA4")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x112DCC0", Offset = "0x112DCC0", VA = "0x112DCC0")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB4C0", Offset = "0xABB4C0")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x112BC20", Offset = "0x112BC20", VA = "0x112BC20")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x112DCDC", Offset = "0x112DCDC", VA = "0x112DCDC")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x112DCF8", Offset = "0x112DCF8", VA = "0x112DCF8")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB4D0", Offset = "0xABB4D0")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x112BDBC", Offset = "0x112BDBC", VA = "0x112BDBC")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x112DD14", Offset = "0x112DD14", VA = "0x112DD14")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x112DD30", Offset = "0x112DD30", VA = "0x112DD30")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB4E0", Offset = "0xABB4E0")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x112BF58", Offset = "0x112BF58", VA = "0x112BF58")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x112DD4C", Offset = "0x112DD4C", VA = "0x112DD4C")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x112DD68", Offset = "0x112DD68", VA = "0x112DD68")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB4F0", Offset = "0xABB4F0")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x112C0F4", Offset = "0x112C0F4", VA = "0x112C0F4")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x112DD84", Offset = "0x112DD84", VA = "0x112DD84")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x112DDA0", Offset = "0x112DDA0", VA = "0x112DDA0")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB500", Offset = "0xABB500")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x112C270", Offset = "0x112C270", VA = "0x112C270")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x112DE04", Offset = "0x112DE04", VA = "0x112DE04")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x112DE20", Offset = "0x112DE20", VA = "0x112DE20")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB510", Offset = "0xABB510")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x112C3EC", Offset = "0x112C3EC", VA = "0x112C3EC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x112DE3C", Offset = "0x112DE3C", VA = "0x112DE3C")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x112DE58", Offset = "0x112DE58", VA = "0x112DE58")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB520", Offset = "0xABB520")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x112C550", Offset = "0x112C550", VA = "0x112C550")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x112DE74", Offset = "0x112DE74", VA = "0x112DE74")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x112DE90", Offset = "0x112DE90", VA = "0x112DE90")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB530", Offset = "0xABB530")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x112C6D4", Offset = "0x112C6D4", VA = "0x112C6D4")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x112DEAC", Offset = "0x112DEAC", VA = "0x112DEAC")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x112DEC8", Offset = "0x112DEC8", VA = "0x112DEC8")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB540", Offset = "0xABB540")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x112C858", Offset = "0x112C858", VA = "0x112C858")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x112DEE4", Offset = "0x112DEE4", VA = "0x112DEE4")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x112DF00", Offset = "0x112DF00", VA = "0x112DF00")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB550", Offset = "0xABB550")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x112C860", Offset = "0x112C860", VA = "0x112C860")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x112DF1C", Offset = "0x112DF1C", VA = "0x112DF1C")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x112DF38", Offset = "0x112DF38", VA = "0x112DF38")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB560", Offset = "0xABB560")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x112C868", Offset = "0x112C868", VA = "0x112C868")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x112DF54", Offset = "0x112DF54", VA = "0x112DF54")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x112DFE4", Offset = "0x112DFE4", VA = "0x112DFE4")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB570", Offset = "0xABB570")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x112CA08", Offset = "0x112CA08", VA = "0x112CA08")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x112E088", Offset = "0x112E088", VA = "0x112E088")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x112E118", Offset = "0x112E118", VA = "0x112E118")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB580", Offset = "0xABB580")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x112CA10", Offset = "0x112CA10", VA = "0x112CA10")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x112E1BC", Offset = "0x112E1BC", VA = "0x112E1BC")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x112E24C", Offset = "0x112E24C", VA = "0x112E24C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB590", Offset = "0xABB590")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x112CDBC", Offset = "0x112CDBC", VA = "0x112CDBC")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x112E2F0", Offset = "0x112E2F0", VA = "0x112E2F0")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x112E30C", Offset = "0x112E30C", VA = "0x112E30C")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x112E328", Offset = "0x112E328", VA = "0x112E328")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x112E35C", Offset = "0x112E35C", VA = "0x112E35C")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x112E378", Offset = "0x112E378", VA = "0x112E378")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x112E394", Offset = "0x112E394", VA = "0x112E394")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB5A0", Offset = "0xABB5A0")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x112CF2C", Offset = "0x112CF2C", VA = "0x112CF2C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x112E490", Offset = "0x112E490", VA = "0x112E490")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x112E500", Offset = "0x112E500", VA = "0x112E500")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB5B0", Offset = "0xABB5B0")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x112D08C", Offset = "0x112D08C", VA = "0x112D08C")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x112E54C", Offset = "0x112E54C", VA = "0x112E54C")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x112E568", Offset = "0x112E568", VA = "0x112E568")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB5C0", Offset = "0xABB5C0")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x112D1EC", Offset = "0x112D1EC", VA = "0x112D1EC")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x112E584", Offset = "0x112E584", VA = "0x112E584")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x112E5A0", Offset = "0x112E5A0", VA = "0x112E5A0")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB5D0", Offset = "0xABB5D0")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x112D358", Offset = "0x112D358", VA = "0x112D358")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x112E5BC", Offset = "0x112E5BC", VA = "0x112E5BC")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x112E5E0", Offset = "0x112E5E0", VA = "0x112E5E0")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB5E0", Offset = "0xABB5E0")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x112D360", Offset = "0x112D360", VA = "0x112D360")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x112E604", Offset = "0x112E604", VA = "0x112E604")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x112E628", Offset = "0x112E628", VA = "0x112E628")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB5F0", Offset = "0xABB5F0")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x112D528", Offset = "0x112D528", VA = "0x112D528")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x112E64C", Offset = "0x112E64C", VA = "0x112E64C")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x112E654", Offset = "0x112E654", VA = "0x112E654")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB600", Offset = "0xABB600")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x112D530", Offset = "0x112D530", VA = "0x112D530")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x112E6F4", Offset = "0x112E6F4", VA = "0x112E6F4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x112E718", Offset = "0x112E718", VA = "0x112E718")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB610", Offset = "0xABB610")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x112D538", Offset = "0x112D538", VA = "0x112D538")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x112E73C", Offset = "0x112E73C", VA = "0x112E73C")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x112E760", Offset = "0x112E760", VA = "0x112E760")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB620", Offset = "0xABB620")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x112D73C", Offset = "0x112D73C", VA = "0x112D73C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x112E784", Offset = "0x112E784", VA = "0x112E784")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x112E790", Offset = "0x112E790", VA = "0x112E790")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB630", Offset = "0xABB630")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x112D940", Offset = "0x112D940", VA = "0x112D940")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x112E84C", Offset = "0x112E84C", VA = "0x112E84C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x112E858", Offset = "0x112E858", VA = "0x112E858")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB640", Offset = "0xABB640")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x112DB44", Offset = "0x112DB44", VA = "0x112DB44")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x112E95C", Offset = "0x112E95C", VA = "0x112E95C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x112E968", Offset = "0x112E968", VA = "0x112E968")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11254DC", Offset = "0x11254DC", VA = "0x11254DC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1124E10", Offset = "0x1124E10", VA = "0x1124E10")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1125244", Offset = "0x1125244", VA = "0x1125244")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x112A8C4", Offset = "0x112A8C4", VA = "0x112A8C4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x112AA40", Offset = "0x112AA40", VA = "0x112AA40")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x112AB94", Offset = "0x112AB94", VA = "0x112AB94")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x112AD0C", Offset = "0x112AD0C", VA = "0x112AD0C")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x112AEEC", Offset = "0x112AEEC", VA = "0x112AEEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x112B068", Offset = "0x112B068", VA = "0x112B068")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x112B1E4", Offset = "0x112B1E4", VA = "0x112B1E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x112B360", Offset = "0x112B360", VA = "0x112B360")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x112B4DC", Offset = "0x112B4DC", VA = "0x112B4DC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x112B630", Offset = "0x112B630", VA = "0x112B630")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x112B794", Offset = "0x112B794", VA = "0x112B794")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x112B910", Offset = "0x112B910", VA = "0x112B910")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x112BA98", Offset = "0x112BA98", VA = "0x112BA98")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11243E8", Offset = "0x11243E8", VA = "0x11243E8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x112BC28", Offset = "0x112BC28", VA = "0x112BC28")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x112BDC4", Offset = "0x112BDC4", VA = "0x112BDC4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x112BF60", Offset = "0x112BF60", VA = "0x112BF60")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x112C0FC", Offset = "0x112C0FC", VA = "0x112C0FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x112C278", Offset = "0x112C278", VA = "0x112C278")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x112C3F4", Offset = "0x112C3F4", VA = "0x112C3F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x112C558", Offset = "0x112C558", VA = "0x112C558")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x112C6DC", Offset = "0x112C6DC", VA = "0x112C6DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1124B28", Offset = "0x1124B28", VA = "0x1124B28")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x112580C", Offset = "0x112580C", VA = "0x112580C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x112C870", Offset = "0x112C870", VA = "0x112C870")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11259CC", Offset = "0x11259CC", VA = "0x11259CC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x112CA18", Offset = "0x112CA18", VA = "0x112CA18")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x112CDC4", Offset = "0x112CDC4", VA = "0x112CDC4")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x112CF34", Offset = "0x112CF34", VA = "0x112CF34")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x112D094", Offset = "0x112D094", VA = "0x112D094")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x112D1F4", Offset = "0x112D1F4", VA = "0x112D1F4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1124F84", Offset = "0x1124F84", VA = "0x1124F84")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x112D368", Offset = "0x112D368", VA = "0x112D368")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1125390", Offset = "0x1125390", VA = "0x1125390")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1125628", Offset = "0x1125628", VA = "0x1125628")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x112D540", Offset = "0x112D540", VA = "0x112D540")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x112D744", Offset = "0x112D744", VA = "0x112D744")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x112D948", Offset = "0x112D948", VA = "0x112D948")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB650", Offset = "0xABB650")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x112F7EC", Offset = "0x112F7EC", VA = "0x112F7EC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x113001C", Offset = "0x113001C", VA = "0x113001C")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1130040", Offset = "0x1130040", VA = "0x1130040")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB660", Offset = "0xABB660")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x112F9C4", Offset = "0x112F9C4", VA = "0x112F9C4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1130064", Offset = "0x1130064", VA = "0x1130064")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x1130088", Offset = "0x1130088", VA = "0x1130088")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB670", Offset = "0xABB670")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x11300AC", Offset = "0x11300AC", VA = "0x11300AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x11302F0", Offset = "0x11302F0", VA = "0x11302F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB680", Offset = "0xABB680")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1130A00", Offset = "0x1130A00", VA = "0x1130A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1130C68", Offset = "0x1130C68", VA = "0x1130C68", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB690", Offset = "0xABB690")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1130554", Offset = "0x1130554", VA = "0x1130554", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1130784", Offset = "0x1130784", VA = "0x1130784", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB6A0", Offset = "0xABB6A0")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x11302FC", Offset = "0x11302FC", VA = "0x11302FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1130548", Offset = "0x1130548", VA = "0x1130548", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB6B0", Offset = "0xABB6B0")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1130790", Offset = "0x1130790", VA = "0x1130790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x11309F4", Offset = "0x11309F4", VA = "0x11309F4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB6C0", Offset = "0xABB6C0")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1130C74", Offset = "0x1130C74", VA = "0x1130C74", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1130EAC", Offset = "0x1130EAC", VA = "0x1130EAC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x112ED38", Offset = "0x112ED38", VA = "0x112ED38")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x112EF14", Offset = "0x112EF14", VA = "0x112EF14")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x112F104", Offset = "0x112F104", VA = "0x112F104")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x112F1D8", Offset = "0x112F1D8", VA = "0x112F1D8")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x112F2AC", Offset = "0x112F2AC", VA = "0x112F2AC")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x112F380", Offset = "0x112F380", VA = "0x112F380")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x112F464", Offset = "0x112F464", VA = "0x112F464")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x112F548", Offset = "0x112F548", VA = "0x112F548")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x112F61C", Offset = "0x112F61C", VA = "0x112F61C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x112F7F4", Offset = "0x112F7F4", VA = "0x112F7F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x112F9CC", Offset = "0x112F9CC", VA = "0x112F9CC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xABD6A8", Offset = "0xABD6A8")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x112FAD4", Offset = "0x112FAD4", VA = "0x112FAD4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xABD71C", Offset = "0xABD71C")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x112FBDC", Offset = "0x112FBDC", VA = "0x112FBDC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xABD790", Offset = "0xABD790")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x112FCE4", Offset = "0x112FCE4", VA = "0x112FCE4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xABD804", Offset = "0xABD804")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x112FDFC", Offset = "0x112FDFC", VA = "0x112FDFC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xABD878", Offset = "0xABD878")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x112FF14", Offset = "0x112FF14", VA = "0x112FF14")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xABD8EC", Offset = "0xABD8EC")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20000F6")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000075")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60004D1")]
				[Address(RVA = "0x1126DC0", Offset = "0x1126DC0", VA = "0x1126DC0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1126DF4", Offset = "0x1126DF4", VA = "0x1126DF4")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000076")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0x1126FB8", Offset = "0x1126FB8", VA = "0x1126FB8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x112701C", Offset = "0x112701C", VA = "0x112701C")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000077")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x1126EBC", Offset = "0x1126EBC", VA = "0x1126EBC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1126ED8", Offset = "0x1126ED8", VA = "0x1126ED8")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000F9")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000078")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60004D7")]
				[Address(RVA = "0x1126E28", Offset = "0x1126E28", VA = "0x1126E28", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1126E74", Offset = "0x1126E74", VA = "0x1126E74")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20000FA")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000079")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60004D9")]
				[Address(RVA = "0x1126F0C", Offset = "0x1126F0C", VA = "0x1126F0C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1126F70", Offset = "0x1126F70", VA = "0x1126F70")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20000FB")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700007A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x1127050", Offset = "0x1127050", VA = "0x1127050", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1127084", Offset = "0x1127084", VA = "0x1127084")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000072")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20000FC")]
		public static class Physics
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1130FFC", Offset = "0x1130FFC", VA = "0x1130FFC")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1131104", Offset = "0x1131104", VA = "0x1131104")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1131194", Offset = "0x1131194", VA = "0x1131194")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1131224", Offset = "0x1131224", VA = "0x1131224")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1130EB8", Offset = "0x1130EB8", VA = "0x1130EB8")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1130F5C", Offset = "0x1130F5C", VA = "0x1130F5C")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xABB0A8", Offset = "0xABB0A8")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x20000FD")]
		public enum AnimationType
		{
			[Token(Token = "0x400040C")]
			None,
			[Token(Token = "0x400040D")]
			Move,
			[Token(Token = "0x400040E")]
			LocalMove,
			[Token(Token = "0x400040F")]
			Rotate,
			[Token(Token = "0x4000410")]
			LocalRotate,
			[Token(Token = "0x4000411")]
			Scale,
			[Token(Token = "0x4000412")]
			Color,
			[Token(Token = "0x4000413")]
			Fade,
			[Token(Token = "0x4000414")]
			Text,
			[Token(Token = "0x4000415")]
			PunchPosition,
			[Token(Token = "0x4000416")]
			PunchRotation,
			[Token(Token = "0x4000417")]
			PunchScale,
			[Token(Token = "0x4000418")]
			ShakePosition,
			[Token(Token = "0x4000419")]
			ShakeRotation,
			[Token(Token = "0x400041A")]
			ShakeScale,
			[Token(Token = "0x400041B")]
			CameraAspect,
			[Token(Token = "0x400041C")]
			CameraBackgroundColor,
			[Token(Token = "0x400041D")]
			CameraFieldOfView,
			[Token(Token = "0x400041E")]
			CameraOrthoSize,
			[Token(Token = "0x400041F")]
			CameraPixelRect,
			[Token(Token = "0x4000420")]
			CameraRect,
			[Token(Token = "0x4000421")]
			UIWidthHeight
		}

		[Token(Token = "0x20000FE")]
		public enum TargetType
		{
			[Token(Token = "0x4000423")]
			Unset,
			[Token(Token = "0x4000424")]
			Camera,
			[Token(Token = "0x4000425")]
			CanvasGroup,
			[Token(Token = "0x4000426")]
			Image,
			[Token(Token = "0x4000427")]
			Light,
			[Token(Token = "0x4000428")]
			RectTransform,
			[Token(Token = "0x4000429")]
			Renderer,
			[Token(Token = "0x400042A")]
			SpriteRenderer,
			[Token(Token = "0x400042B")]
			Rigidbody,
			[Token(Token = "0x400042C")]
			Rigidbody2D,
			[Token(Token = "0x400042D")]
			Text,
			[Token(Token = "0x400042E")]
			Transform,
			[Token(Token = "0x400042F")]
			tk2dBaseSprite,
			[Token(Token = "0x4000430")]
			tk2dTextMesh,
			[Token(Token = "0x4000431")]
			TextMeshPro,
			[Token(Token = "0x4000432")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x11227C8", Offset = "0x11227C8", VA = "0x11227C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABD980", Offset = "0xABD980")]
			add
			{
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x112287C", Offset = "0x112287C", VA = "0x112287C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABD990", Offset = "0xABD990")]
			remove
			{
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1122930", Offset = "0x1122930", VA = "0x1122930")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x11229A4", Offset = "0x11229A4", VA = "0x11229A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1123ED4", Offset = "0x1123ED4", VA = "0x1123ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1123F18", Offset = "0x1123F18", VA = "0x1123F18")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1123F1C", Offset = "0x1123F1C", VA = "0x1123F1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x11229F4", Offset = "0x11229F4", VA = "0x11229F4")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1125BB0", Offset = "0x1125BB0", VA = "0x1125BB0", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1125C2C", Offset = "0x1125C2C", VA = "0x1125C2C", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1125CA8", Offset = "0x1125CA8", VA = "0x1125CA8", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1125D24", Offset = "0x1125D24", VA = "0x1125D24", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1125DA0", Offset = "0x1125DA0", VA = "0x1125DA0", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1125E1C", Offset = "0x1125E1C", VA = "0x1125E1C", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1125F18", Offset = "0x1125F18", VA = "0x1125F18", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1125F28", Offset = "0x1125F28", VA = "0x1125F28", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x11262DC", Offset = "0x11262DC", VA = "0x11262DC", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x112635C", Offset = "0x112635C", VA = "0x112635C", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x11263EC", Offset = "0x11263EC", VA = "0x11263EC")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1126478", Offset = "0x1126478", VA = "0x1126478")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x11264E0", Offset = "0x11264E0", VA = "0x11264E0")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1126548", Offset = "0x1126548", VA = "0x1126548")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x11265D4", Offset = "0x11265D4", VA = "0x11265D4")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x112663C", Offset = "0x112663C", VA = "0x112663C")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11266C8", Offset = "0x11266C8", VA = "0x11266C8")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1126730", Offset = "0x1126730", VA = "0x1126730")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1126864", Offset = "0x1126864", VA = "0x1126864")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11268F4", Offset = "0x11268F4", VA = "0x11268F4")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1126974", Offset = "0x1126974", VA = "0x1126974")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1126A10", Offset = "0x1126A10", VA = "0x1126A10")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1126A94", Offset = "0x1126A94", VA = "0x1126A94")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1123F80", Offset = "0x1123F80", VA = "0x1123F80")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1126B80", Offset = "0x1126B80", VA = "0x1126B80")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1123F68", Offset = "0x1123F68", VA = "0x1123F68")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1126044", Offset = "0x1126044", VA = "0x1126044")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1126BBC", Offset = "0x1126BBC", VA = "0x1126BBC")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1126DB4", Offset = "0x1126DB4", VA = "0x1126DB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABD9A0", Offset = "0xABD9A0")]
		private void <CreateTween>b__47_0()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000344")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000075")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB6D0", Offset = "0xABB6D0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x11316E4", Offset = "0x11316E4", VA = "0x11316E4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1131A20", Offset = "0x1131A20", VA = "0x1131A20")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1131A3C", Offset = "0x1131A3C", VA = "0x1131A3C")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xABB6E0", Offset = "0xABB6E0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1131A18", Offset = "0x1131A18", VA = "0x1131A18")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1131A58", Offset = "0x1131A58", VA = "0x1131A58")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x113136C", Offset = "0x113136C", VA = "0x113136C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x11313BC", Offset = "0x11313BC", VA = "0x11313BC")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x11316EC", Offset = "0x11316EC", VA = "0x11316EC")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
