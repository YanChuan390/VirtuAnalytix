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
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9E0A6C", Offset = "0x9E0A6C")]
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
	[Address(RVA = "0x101CB70", Offset = "0x101CB70", VA = "0x101CB70")]
	public void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x101CD30", Offset = "0x101CD30", VA = "0x101CD30", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x101D03C", Offset = "0x101D03C", VA = "0x101D03C")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000004")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x102C2F0", Offset = "0x102C2F0", VA = "0x102C2F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x102C3CC", Offset = "0x102C3CC", VA = "0x102C3CC")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0AA4", Offset = "0x9E0AA4")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x102C3D4", Offset = "0x102C3D4", VA = "0x102C3D4")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x102C490", Offset = "0x102C490", VA = "0x102C490")]
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
		[Address(RVA = "0x1197204", Offset = "0x1197204", VA = "0x1197204")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x119766C", Offset = "0x119766C", VA = "0x119766C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1197670", Offset = "0x1197670", VA = "0x1197670")]
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
			[Address(RVA = "0x11980BC", Offset = "0x11980BC", VA = "0x11980BC")]
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
			[Address(RVA = "0x11980C4", Offset = "0x11980C4", VA = "0x11980C4")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1197688", Offset = "0x1197688", VA = "0x1197688")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x11980B4", Offset = "0x11980B4", VA = "0x11980B4")]
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
			[Address(RVA = "0x11982A0", Offset = "0x11982A0", VA = "0x11982A0")]
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
		[Address(RVA = "0x1198130", Offset = "0x1198130", VA = "0x1198130")]
		private void Start()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1198158", Offset = "0x1198158", VA = "0x1198158")]
		private void Update()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1198298", Offset = "0x1198298", VA = "0x1198298")]
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
		[Address(RVA = "0x11982B0", Offset = "0x11982B0", VA = "0x11982B0")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1198324", Offset = "0x1198324", VA = "0x1198324")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x119832C", Offset = "0x119832C", VA = "0x119832C")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1198334", Offset = "0x1198334", VA = "0x1198334")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1198494", Offset = "0x1198494", VA = "0x1198494")]
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
		[Address(RVA = "0x118CA8C", Offset = "0x118CA8C", VA = "0x118CA8C")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x118D820", Offset = "0x118D820", VA = "0x118D820")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x118DFDC", Offset = "0x118DFDC", VA = "0x118DFDC")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1664", Offset = "0x9E1664")]
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
				[Address(RVA = "0x1198C28", Offset = "0x1198C28", VA = "0x1198C28", Slot = "4")]
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
				[Address(RVA = "0x1198C90", Offset = "0x1198C90", VA = "0x1198C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1198998", Offset = "0x1198998", VA = "0x1198998")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x11989CC", Offset = "0x11989CC", VA = "0x11989CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x11989D0", Offset = "0x11989D0", VA = "0x11989D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1198C30", Offset = "0x1198C30", VA = "0x1198C30", Slot = "8")]
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
		[Address(RVA = "0x11984E8", Offset = "0x11984E8", VA = "0x11984E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x119890C", Offset = "0x119890C", VA = "0x119890C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2B18", Offset = "0x9E2B18")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x119885C", Offset = "0x119885C", VA = "0x119885C")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x11989C4", Offset = "0x11989C4", VA = "0x11989C4")]
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
		[Address(RVA = "0x1198C98", Offset = "0x1198C98", VA = "0x1198C98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1198CCC", Offset = "0x1198CCC", VA = "0x1198CCC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1198F40", Offset = "0x1198F40", VA = "0x1198F40")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class FOVKick
	{
		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1674", Offset = "0x9E1674")]
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
				[Address(RVA = "0x1199418", Offset = "0x1199418", VA = "0x1199418", Slot = "4")]
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
				[Address(RVA = "0x1199480", Offset = "0x1199480", VA = "0x1199480", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x119905C", Offset = "0x119905C", VA = "0x119905C")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x11992A8", Offset = "0x11992A8", VA = "0x11992A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x11992AC", Offset = "0x11992AC", VA = "0x11992AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1199420", Offset = "0x1199420", VA = "0x1199420", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1684", Offset = "0x9E1684")]
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
				[Address(RVA = "0x1199238", Offset = "0x1199238", VA = "0x1199238", Slot = "4")]
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
				[Address(RVA = "0x11992A0", Offset = "0x11992A0", VA = "0x11992A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1199088", Offset = "0x1199088", VA = "0x1199088")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x11990B4", Offset = "0x11990B4", VA = "0x11990B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x11990B8", Offset = "0x11990B8", VA = "0x11990B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1199240", Offset = "0x1199240", VA = "0x1199240", Slot = "8")]
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
		[Address(RVA = "0x118CA40", Offset = "0x118CA40", VA = "0x118CA40")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1198F74", Offset = "0x1198F74", VA = "0x1198F74")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1199054", Offset = "0x1199054", VA = "0x1199054")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x118D9BC", Offset = "0x118D9BC", VA = "0x118D9BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2B7C", Offset = "0x9E2B7C")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x118D940", Offset = "0x118D940", VA = "0x118D940")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2BE0", Offset = "0x9E2BE0")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x118DFC0", Offset = "0x118DFC0", VA = "0x118DFC0")]
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
		[Address(RVA = "0x1199488", Offset = "0x1199488", VA = "0x1199488")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1199568", Offset = "0x1199568", VA = "0x1199568")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1694", Offset = "0x9E1694")]
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
				[Address(RVA = "0x11997F8", Offset = "0x11997F8", VA = "0x11997F8", Slot = "4")]
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
				[Address(RVA = "0x1199860", Offset = "0x1199860", VA = "0x1199860", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x11995D0", Offset = "0x11995D0", VA = "0x11995D0")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x11995FC", Offset = "0x11995FC", VA = "0x11995FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1199600", Offset = "0x1199600", VA = "0x1199600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1199800", Offset = "0x1199800", VA = "0x1199800", Slot = "8")]
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
		[Address(RVA = "0x11995C8", Offset = "0x11995C8", VA = "0x11995C8")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x118CD6C", Offset = "0x118CD6C", VA = "0x118CD6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2C44", Offset = "0x9E2C44")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x118E228", Offset = "0x118E228", VA = "0x118E228")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E16A4", Offset = "0x9E16A4")]
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
				[Address(RVA = "0x1199C68", Offset = "0x1199C68", VA = "0x1199C68", Slot = "4")]
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
				[Address(RVA = "0x1199CD0", Offset = "0x1199CD0", VA = "0x1199CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x11999F4", Offset = "0x11999F4", VA = "0x11999F4")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1199A28", Offset = "0x1199A28", VA = "0x1199A28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1199A2C", Offset = "0x1199A2C", VA = "0x1199A2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1199C70", Offset = "0x1199C70", VA = "0x1199C70", Slot = "8")]
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
		[Address(RVA = "0x1199868", Offset = "0x1199868", VA = "0x1199868")]
		private void Start()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x11965A4", Offset = "0x11965A4", VA = "0x11965A4")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1199968", Offset = "0x1199968", VA = "0x1199968")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2CA8", Offset = "0x9E2CA8")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1199A20", Offset = "0x1199A20", VA = "0x1199A20")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E16B4", Offset = "0x9E16B4")]
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
				[Address(RVA = "0x119A100", Offset = "0x119A100", VA = "0x119A100", Slot = "4")]
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
				[Address(RVA = "0x119A168", Offset = "0x119A168", VA = "0x119A168", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1199D54", Offset = "0x1199D54", VA = "0x1199D54")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1199DA0", Offset = "0x1199DA0", VA = "0x1199DA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1199DA4", Offset = "0x1199DA4", VA = "0x1199DA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x119A108", Offset = "0x119A108", VA = "0x119A108", Slot = "8")]
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
		[Address(RVA = "0x1199CD8", Offset = "0x1199CD8", VA = "0x1199CD8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2D0C", Offset = "0x9E2D0C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1199D80", Offset = "0x1199D80", VA = "0x1199D80")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1199D8C", Offset = "0x1199D8C", VA = "0x1199D8C")]
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
		[Address(RVA = "0x119A170", Offset = "0x119A170", VA = "0x119A170")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x119A174", Offset = "0x119A174", VA = "0x119A174")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x119A190", Offset = "0x119A190", VA = "0x119A190")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x119A4EC", Offset = "0x119A4EC", VA = "0x119A4EC")]
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
		[Address(RVA = "0x119A57C", Offset = "0x119A57C", VA = "0x119A57C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x119A5E8", Offset = "0x119A5E8", VA = "0x119A5E8")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x119A6C0", Offset = "0x119A6C0", VA = "0x119A6C0")]
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
		[Address(RVA = "0x119A6C8", Offset = "0x119A6C8", VA = "0x119A6C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x119A704", Offset = "0x119A704", VA = "0x119A704")]
		private void Update()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x119AB38", Offset = "0x119AB38", VA = "0x119AB38")]
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
		[Address(RVA = "0x119ABF8", Offset = "0x119ABF8", VA = "0x119ABF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x119ABFC", Offset = "0x119ABFC", VA = "0x119ABFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x119AF28", Offset = "0x119AF28", VA = "0x119AF28")]
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
			[Address(RVA = "0x119B6E4", Offset = "0x119B6E4", VA = "0x119B6E4")]
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
			[Address(RVA = "0x119B2D4", Offset = "0x119B2D4", VA = "0x119B2D4")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E16C4", Offset = "0x9E16C4")]
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
				[Address(RVA = "0x119B3B4", Offset = "0x119B3B4", VA = "0x119B3B4", Slot = "4")]
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
				[Address(RVA = "0x119B41C", Offset = "0x119B41C", VA = "0x119B41C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x119B1DC", Offset = "0x119B1DC", VA = "0x119B1DC")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x119B2DC", Offset = "0x119B2DC", VA = "0x119B2DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0x119B2E0", Offset = "0x119B2E0", VA = "0x119B2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x119B3BC", Offset = "0x119B3BC", VA = "0x119B3BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E16D4", Offset = "0x9E16D4")]
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
				[Address(RVA = "0x119B4FC", Offset = "0x119B4FC", VA = "0x119B4FC", Slot = "4")]
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
				[Address(RVA = "0x119B564", Offset = "0x119B564", VA = "0x119B564", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x119B208", Offset = "0x119B208", VA = "0x119B208")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x119B424", Offset = "0x119B424", VA = "0x119B424", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x119B428", Offset = "0x119B428", VA = "0x119B428", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x119B504", Offset = "0x119B504", VA = "0x119B504", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E16E4", Offset = "0x9E16E4")]
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
				[Address(RVA = "0x119B674", Offset = "0x119B674", VA = "0x119B674", Slot = "4")]
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
				[Address(RVA = "0x119B6DC", Offset = "0x119B6DC", VA = "0x119B6DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x119B234", Offset = "0x119B234", VA = "0x119B234")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x119B56C", Offset = "0x119B56C", VA = "0x119B56C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x119B570", Offset = "0x119B570", VA = "0x119B570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x119B67C", Offset = "0x119B67C", VA = "0x119B67C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x119AF3C", Offset = "0x119AF3C", VA = "0x119AF3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x119B068", Offset = "0x119B068", VA = "0x119B068")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2D70", Offset = "0x9E2D70")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x119B0E4", Offset = "0x119B0E4", VA = "0x119B0E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2DD4", Offset = "0x9E2DD4")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x119B160", Offset = "0x119B160", VA = "0x119B160")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2E38", Offset = "0x9E2E38")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x119B260", Offset = "0x119B260", VA = "0x119B260")]
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
		[Address(RVA = "0x119B6EC", Offset = "0x119B6EC", VA = "0x119B6EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x119B744", Offset = "0x119B744", VA = "0x119B744")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x119B7E4", Offset = "0x119B7E4", VA = "0x119B7E4")]
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
			[Address(RVA = "0x119C660", Offset = "0x119C660", VA = "0x119C660")]
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
			[Address(RVA = "0x119BFD8", Offset = "0x119BFD8", VA = "0x119BFD8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1D34", Offset = "0x9E1D34")]
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
			[Address(RVA = "0x119B7F4", Offset = "0x119B7F4", VA = "0x119B7F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2E9C", Offset = "0x9E2E9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x119B7FC", Offset = "0x119B7FC", VA = "0x119B7FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2EAC", Offset = "0x9E2EAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x119B804", Offset = "0x119B804", VA = "0x119B804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x119B820", Offset = "0x119B820", VA = "0x119B820")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x119BB70", Offset = "0x119BB70", VA = "0x119BB70")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x119BC80", Offset = "0x119BC80", VA = "0x119BC80")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x119BFE8", Offset = "0x119BFE8", VA = "0x119BFE8")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x119B87C", Offset = "0x119B87C", VA = "0x119B87C")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x119C350", Offset = "0x119C350", VA = "0x119C350")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x119C5D8", Offset = "0x119C5D8", VA = "0x119C5D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x119C358", Offset = "0x119C358", VA = "0x119C358")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x119C5E0", Offset = "0x119C5E0", VA = "0x119C5E0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1DB4", Offset = "0x9E1DB4")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1DC4", Offset = "0x9E1DC4")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1DD4", Offset = "0x9E1DD4")]
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
			[Address(RVA = "0x119C6CC", Offset = "0x119C6CC", VA = "0x119C6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2EBC", Offset = "0x9E2EBC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x119C6E0", Offset = "0x119C6E0", VA = "0x119C6E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2ECC", Offset = "0x9E2ECC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x119C6F4", Offset = "0x119C6F4", VA = "0x119C6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2EDC", Offset = "0x9E2EDC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x119C708", Offset = "0x119C708", VA = "0x119C708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2EEC", Offset = "0x9E2EEC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x119C71C", Offset = "0x119C71C", VA = "0x119C71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2EFC", Offset = "0x9E2EFC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x119C730", Offset = "0x119C730", VA = "0x119C730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2F0C", Offset = "0x9E2F0C")]
			private set
			{
			}
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x119C744", Offset = "0x119C744", VA = "0x119C744")]
		private void Start()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x119C838", Offset = "0x119C838", VA = "0x119C838")]
		public void Reset()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x119C910", Offset = "0x119C910", VA = "0x119C910")]
		private void Update()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x119CE78", Offset = "0x119CE78", VA = "0x119CE78")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x119D050", Offset = "0x119D050", VA = "0x119D050")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0B08", Offset = "0x9E0B08")]
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
		[Address(RVA = "0x11949B4", Offset = "0x11949B4", VA = "0x11949B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1194A50", Offset = "0x1194A50", VA = "0x1194A50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1194F10", Offset = "0x1194F10", VA = "0x1194F10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1195458", Offset = "0x1195458", VA = "0x1195458")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E16F4", Offset = "0x9E16F4")]
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
				[Address(RVA = "0x1195C9C", Offset = "0x1195C9C", VA = "0x1195C9C", Slot = "4")]
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
				[Address(RVA = "0x1195D04", Offset = "0x1195D04", VA = "0x1195D04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x11954E8", Offset = "0x11954E8", VA = "0x11954E8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x11956A0", Offset = "0x11956A0", VA = "0x11956A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x11956A4", Offset = "0x11956A4", VA = "0x11956A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1195CA4", Offset = "0x1195CA4", VA = "0x1195CA4", Slot = "8")]
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
		[Address(RVA = "0x119546C", Offset = "0x119546C", VA = "0x119546C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2F1C", Offset = "0x9E2F1C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1195514", Offset = "0x1195514", VA = "0x1195514")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1195698", Offset = "0x1195698", VA = "0x1195698")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1704", Offset = "0x9E1704")]
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
				[Address(RVA = "0x11960E0", Offset = "0x11960E0", VA = "0x11960E0", Slot = "4")]
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
				[Address(RVA = "0x1196148", Offset = "0x1196148", VA = "0x1196148", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1195D88", Offset = "0x1195D88", VA = "0x1195D88")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1195DC4", Offset = "0x1195DC4", VA = "0x1195DC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1195DC8", Offset = "0x1195DC8", VA = "0x1195DC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x11960E8", Offset = "0x11960E8", VA = "0x11960E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1195D0C", Offset = "0x1195D0C", VA = "0x1195D0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2F80", Offset = "0x9E2F80")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1195DB4", Offset = "0x1195DB4", VA = "0x1195DB4")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1714", Offset = "0x9E1714")]
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
				[Address(RVA = "0x11965D0", Offset = "0x11965D0", VA = "0x11965D0", Slot = "4")]
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
				[Address(RVA = "0x1196638", Offset = "0x1196638", VA = "0x1196638", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1196248", Offset = "0x1196248", VA = "0x1196248")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x11962A0", Offset = "0x11962A0", VA = "0x11962A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x11962A4", Offset = "0x11962A4", VA = "0x11962A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x11965D8", Offset = "0x11965D8", VA = "0x11965D8", Slot = "8")]
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
		[Address(RVA = "0x1196150", Offset = "0x1196150", VA = "0x1196150")]
		private void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x11961B0", Offset = "0x11961B0", VA = "0x11961B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E2FE4", Offset = "0x9E2FE4")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1196274", Offset = "0x1196274", VA = "0x1196274")]
		public void Reset()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x119627C", Offset = "0x119627C", VA = "0x119627C")]
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
		[Address(RVA = "0x1196640", Offset = "0x1196640", VA = "0x1196640")]
		private void Start()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x11966A0", Offset = "0x11966A0", VA = "0x11966A0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x119672C", Offset = "0x119672C", VA = "0x119672C")]
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
		[Address(RVA = "0x119673C", Offset = "0x119673C", VA = "0x119673C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x11967B4", Offset = "0x11967B4", VA = "0x11967B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1196A14", Offset = "0x1196A14", VA = "0x1196A14")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1196A3C", Offset = "0x1196A3C", VA = "0x1196A3C")]
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
		[Address(RVA = "0x1196A4C", Offset = "0x1196A4C", VA = "0x1196A4C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1196C10", Offset = "0x1196C10", VA = "0x1196C10")]
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
		[Address(RVA = "0x1196C2C", Offset = "0x1196C2C", VA = "0x1196C2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1196DB8", Offset = "0x1196DB8", VA = "0x1196DB8")]
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
		[Address(RVA = "0x1196DC8", Offset = "0x1196DC8", VA = "0x1196DC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1196E88", Offset = "0x1196E88", VA = "0x1196E88")]
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
		[Address(RVA = "0x1196E90", Offset = "0x1196E90", VA = "0x1196E90")]
		private void Start()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1196EF0", Offset = "0x1196EF0", VA = "0x1196EF0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1197180", Offset = "0x1197180", VA = "0x1197180")]
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
		[Address(RVA = "0x1CF124C", Offset = "0x1CF124C", VA = "0x1CF124C")]
		private void Update()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1CF1490", Offset = "0x1CF1490", VA = "0x1CF1490")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0B7C", Offset = "0x9E0B7C")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1CECEC0", Offset = "0x1CECEC0", VA = "0x1CECEC0")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1CECEE4", Offset = "0x1CECEE4", VA = "0x1CECEE4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1CECF44", Offset = "0x1CECF44", VA = "0x1CECF44")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1CECFA4", Offset = "0x1CECFA4", VA = "0x1CECFA4")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0BF0", Offset = "0x9E0BF0")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1CECFAC", Offset = "0x1CECFAC", VA = "0x1CECFAC")]
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
		[Address(RVA = "0x1CECFB4", Offset = "0x1CECFB4", VA = "0x1CECFB4")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1CED028", Offset = "0x1CED028", VA = "0x1CED028")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0C64", Offset = "0x9E0C64")]
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
		[Address(RVA = "0x1CED06C", Offset = "0x1CED06C", VA = "0x1CED06C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1CED160", Offset = "0x1CED160", VA = "0x1CED160")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1CED474", Offset = "0x1CED474", VA = "0x1CED474")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1CED528", Offset = "0x1CED528", VA = "0x1CED528")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1CED630", Offset = "0x1CED630", VA = "0x1CED630")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1CEDF10", Offset = "0x1CEDF10", VA = "0x1CEDF10")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1CEDF70", Offset = "0x1CEDF70", VA = "0x1CEDF70")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1CEE068", Offset = "0x1CEE068", VA = "0x1CEE068")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1CEE0C8", Offset = "0x1CEE0C8", VA = "0x1CEE0C8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1CED7B0", Offset = "0x1CED7B0", VA = "0x1CED7B0")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1CEE128", Offset = "0x1CEE128", VA = "0x1CEE128")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1CEE628", Offset = "0x1CEE628", VA = "0x1CEE628")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1CEE18C", Offset = "0x1CEE18C", VA = "0x1CEE18C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1CEE860", Offset = "0x1CEE860", VA = "0x1CEE860")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1CEE444", Offset = "0x1CEE444", VA = "0x1CEE444")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1CEE880", Offset = "0x1CEE880", VA = "0x1CEE880")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0CD8", Offset = "0x9E0CD8")]
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
		[Address(RVA = "0x1CEE8FC", Offset = "0x1CEE8FC", VA = "0x1CEE8FC")]
		public void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1CEE9F8", Offset = "0x1CEE9F8", VA = "0x1CEE9F8")]
		public void Update()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1CEEC44", Offset = "0x1CEEC44", VA = "0x1CEEC44")]
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
		[Address(RVA = "0x1CEEC4C", Offset = "0x1CEEC4C", VA = "0x1CEEC4C")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1CF08F0", Offset = "0x1CF08F0", VA = "0x1CF08F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1CF0BFC", Offset = "0x1CF0BFC", VA = "0x1CF0BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1CF020C", Offset = "0x1CF020C", VA = "0x1CF020C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1CEF704", Offset = "0x1CEF704", VA = "0x1CEF704")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1CEF6F0", Offset = "0x1CEF6F0", VA = "0x1CEF6F0")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1CEF5A8", Offset = "0x1CEF5A8", VA = "0x1CEF5A8")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1CF070C", Offset = "0x1CF070C", VA = "0x1CF070C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1CF0468", Offset = "0x1CF0468", VA = "0x1CF0468")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1CF0E88", Offset = "0x1CF0E88", VA = "0x1CF0E88")]
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
		[Address(RVA = "0x1CF0F7C", Offset = "0x1CF0F7C", VA = "0x1CF0F7C")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1CF10FC", Offset = "0x1CF10FC", VA = "0x1CF10FC")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1CF11B0", Offset = "0x1CF11B0", VA = "0x1CF11B0")]
		public void Update()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1CF1234", Offset = "0x1CF1234", VA = "0x1CF1234")]
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
		[Address(RVA = "0x1CF1498", Offset = "0x1CF1498", VA = "0x1CF1498")]
		public void Start()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1CF149C", Offset = "0x1CF149C", VA = "0x1CF149C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1CF166C", Offset = "0x1CF166C", VA = "0x1CF166C")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1CF1774", Offset = "0x1CF1774", VA = "0x1CF1774")]
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
		[Address(RVA = "0x1190DA0", Offset = "0x1190DA0", VA = "0x1190DA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1191068", Offset = "0x1191068", VA = "0x1191068")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11911F8", Offset = "0x11911F8", VA = "0x11911F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1191278", Offset = "0x1191278", VA = "0x1191278", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1191360", Offset = "0x1191360", VA = "0x1191360", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1191408", Offset = "0x1191408", VA = "0x1191408")]
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
		[Address(RVA = "0x119147C", Offset = "0x119147C", VA = "0x119147C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1191480", Offset = "0x1191480", VA = "0x1191480")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1191568", Offset = "0x1191568", VA = "0x1191568")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1191650", Offset = "0x1191650", VA = "0x1191650")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1191738", Offset = "0x1191738", VA = "0x1191738")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1191820", Offset = "0x1191820", VA = "0x1191820")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1191908", Offset = "0x1191908", VA = "0x1191908")]
		public void Update()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x119190C", Offset = "0x119190C", VA = "0x119190C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2A50", Offset = "0x9E2A50")]
			private string <name>k__BackingField;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2A60", Offset = "0x9E2A60")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700005A")]
			public string name
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x1192790", Offset = "0x1192790", VA = "0x1192790")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4304", Offset = "0x9E4304")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x1192798", Offset = "0x1192798", VA = "0x1192798")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4314", Offset = "0x9E4314")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x11927A0", Offset = "0x11927A0", VA = "0x11927A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4324", Offset = "0x9E4324")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x11927A8", Offset = "0x11927A8", VA = "0x11927A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4334", Offset = "0x9E4334")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005C")]
			public float GetValue
			{
				[Token(Token = "0x600039F")]
				[Address(RVA = "0x1192808", Offset = "0x1192808", VA = "0x1192808")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700005D")]
			public float GetValueRaw
			{
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x1192810", Offset = "0x1192810", VA = "0x1192810")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1190F38", Offset = "0x1190F38", VA = "0x1190F38")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x11927B4", Offset = "0x11927B4", VA = "0x11927B4")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1191210", Offset = "0x1191210", VA = "0x1191210")]
			public void Remove()
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x1192800", Offset = "0x1192800", VA = "0x1192800")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000090")]
		public class VirtualButton
		{
			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2A70", Offset = "0x9E2A70")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2A80", Offset = "0x9E2A80")]
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
				[Address(RVA = "0x1192818", Offset = "0x1192818", VA = "0x1192818")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4344", Offset = "0x9E4344")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x1192820", Offset = "0x1192820", VA = "0x1192820")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4354", Offset = "0x9E4354")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0x1192828", Offset = "0x1192828", VA = "0x1192828")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4364", Offset = "0x9E4364")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x1192830", Offset = "0x1192830", VA = "0x1192830")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4374", Offset = "0x9E4374")]
				private set
				{
				}
			}

			[Token(Token = "0x17000060")]
			public bool GetButton
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x11929A8", Offset = "0x11929A8", VA = "0x11929A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000061")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x11929B0", Offset = "0x11929B0", VA = "0x11929B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000062")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x11929E0", Offset = "0x11929E0", VA = "0x11929E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x119283C", Offset = "0x119283C", VA = "0x119283C")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1192884", Offset = "0x1192884", VA = "0x1192884")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x11928D8", Offset = "0x11928D8", VA = "0x11928D8")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1192914", Offset = "0x1192914", VA = "0x1192914")]
			public void Released()
			{
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1192940", Offset = "0x1192940", VA = "0x1192940")]
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
			[Address(RVA = "0x1192410", Offset = "0x1192410", VA = "0x1192410")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1191914", Offset = "0x1191914", VA = "0x1191914")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11919C8", Offset = "0x11919C8", VA = "0x11919C8")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1190EC0", Offset = "0x1190EC0", VA = "0x1190EC0")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1191AE8", Offset = "0x1191AE8", VA = "0x1191AE8")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1190F78", Offset = "0x1190F78", VA = "0x1190F78")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1191CF0", Offset = "0x1191CF0", VA = "0x1191CF0")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1191E90", Offset = "0x1191E90", VA = "0x1191E90")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1191FE0", Offset = "0x1191FE0", VA = "0x1191FE0")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1190FF0", Offset = "0x1190FF0", VA = "0x1190FF0")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x118B610", Offset = "0x118B610", VA = "0x118B610")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1192214", Offset = "0x1192214", VA = "0x1192214")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1192184", Offset = "0x1192184", VA = "0x1192184")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x119227C", Offset = "0x119227C", VA = "0x119227C")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x118CCEC", Offset = "0x118CCEC", VA = "0x118CCEC")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x11922FC", Offset = "0x11922FC", VA = "0x11922FC")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x11914E8", Offset = "0x11914E8", VA = "0x11914E8")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x11915D0", Offset = "0x11915D0", VA = "0x11915D0")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x11916B8", Offset = "0x11916B8", VA = "0x11916B8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1191888", Offset = "0x1191888", VA = "0x1191888")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x11917A0", Offset = "0x11917A0", VA = "0x11917A0")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x119237C", Offset = "0x119237C", VA = "0x119237C")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x119248C", Offset = "0x119248C", VA = "0x119248C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1192588", Offset = "0x1192588", VA = "0x1192588")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1192690", Offset = "0x1192690", VA = "0x1192690")]
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
		[Address(RVA = "0x1192A10", Offset = "0x1192A10", VA = "0x1192A10")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1192A14", Offset = "0x1192A14", VA = "0x1192A14")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1192A94", Offset = "0x1192A94", VA = "0x1192A94")]
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
		[Address(RVA = "0x1192A9C", Offset = "0x1192A9C", VA = "0x1192A9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1192C14", Offset = "0x1192C14", VA = "0x1192C14")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1192C50", Offset = "0x1192C50", VA = "0x1192C50")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1192AA0", Offset = "0x1192AA0", VA = "0x1192AA0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1192D40", Offset = "0x1192D40", VA = "0x1192D40", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1192F30", Offset = "0x1192F30", VA = "0x1192F30", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1192F78", Offset = "0x1192F78", VA = "0x1192F78", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1192F7C", Offset = "0x1192F7C", VA = "0x1192F7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1192FCC", Offset = "0x1192FCC", VA = "0x1192FCC")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x119304C", Offset = "0x119304C", VA = "0x119304C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x119305C", Offset = "0x119305C", VA = "0x119305C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1193054", Offset = "0x1193054", VA = "0x1193054")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1193138", Offset = "0x1193138", VA = "0x1193138")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x11933A4", Offset = "0x11933A4", VA = "0x11933A4")]
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
			[Address(RVA = "0x11942AC", Offset = "0x11942AC", VA = "0x11942AC")]
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
		[Address(RVA = "0x1193F1C", Offset = "0x1193F1C", VA = "0x1193F1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1193FF8", Offset = "0x1193FF8", VA = "0x1193FF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1194284", Offset = "0x1194284", VA = "0x1194284")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x119429C", Offset = "0x119429C", VA = "0x119429C")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0D8C", Offset = "0x9E0D8C")]
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
		[Address(RVA = "0x11942B4", Offset = "0x11942B4", VA = "0x11942B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x119442C", Offset = "0x119442C", VA = "0x119442C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x11942B8", Offset = "0x11942B8", VA = "0x11942B8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x11944B8", Offset = "0x11944B8", VA = "0x11944B8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1194524", Offset = "0x1194524", VA = "0x1194524", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x11945D4", Offset = "0x11945D4", VA = "0x11945D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x11947A8", Offset = "0x11947A8", VA = "0x11947A8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1194820", Offset = "0x1194820", VA = "0x1194820")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1194914", Offset = "0x1194914", VA = "0x1194914")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1DE4", Offset = "0x9E1DE4")]
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
			[Address(RVA = "0x119499C", Offset = "0x119499C", VA = "0x119499C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3048", Offset = "0x9E3048")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x11949A8", Offset = "0x11949A8", VA = "0x11949A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3058", Offset = "0x9E3058")]
			private set
			{
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1191A80", Offset = "0x1191A80", VA = "0x1191A80")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1191B60", Offset = "0x1191B60", VA = "0x1191B60")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1191BC8", Offset = "0x1191BC8", VA = "0x1191BC8")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1191D68", Offset = "0x1191D68", VA = "0x1191D68")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1191F48", Offset = "0x1191F48", VA = "0x1191F48")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1192058", Offset = "0x1192058", VA = "0x1192058")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x11920F0", Offset = "0x11920F0", VA = "0x11920F0")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x119253C", Offset = "0x119253C", VA = "0x119253C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x119263C", Offset = "0x119263C", VA = "0x119263C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1192740", Offset = "0x1192740", VA = "0x1192740")]
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
		[Address(RVA = "0x1193B70", Offset = "0x1193B70", VA = "0x1193B70")]
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
		[Address(RVA = "0x11933AC", Offset = "0x11933AC", VA = "0x11933AC")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x119344C", Offset = "0x119344C", VA = "0x119344C")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x11934E4", Offset = "0x11934E4", VA = "0x11934E4", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1193580", Offset = "0x1193580", VA = "0x1193580", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1193638", Offset = "0x1193638", VA = "0x1193638", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x11936E4", Offset = "0x11936E4", VA = "0x11936E4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1193784", Offset = "0x1193784", VA = "0x1193784", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1193824", Offset = "0x1193824", VA = "0x1193824", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x11938C0", Offset = "0x11938C0", VA = "0x11938C0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1193968", Offset = "0x1193968", VA = "0x1193968", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1193A18", Offset = "0x1193A18", VA = "0x1193A18", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1193AC8", Offset = "0x1193AC8", VA = "0x1193AC8", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1193B64", Offset = "0x1193B64", VA = "0x1193B64", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x11919C0", Offset = "0x11919C0", VA = "0x11919C0")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1193C54", Offset = "0x1193C54", VA = "0x1193C54", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1193C68", Offset = "0x1193C68", VA = "0x1193C68", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1193C74", Offset = "0x1193C74", VA = "0x1193C74", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1193C80", Offset = "0x1193C80", VA = "0x1193C80", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1193C8C", Offset = "0x1193C8C", VA = "0x1193C8C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1193CF8", Offset = "0x1193CF8", VA = "0x1193CF8", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1193D64", Offset = "0x1193D64", VA = "0x1193D64", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1193DD0", Offset = "0x1193DD0", VA = "0x1193DD0", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1193E3C", Offset = "0x1193E3C", VA = "0x1193E3C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1193EA8", Offset = "0x1193EA8", VA = "0x1193EA8", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1193F14", Offset = "0x1193F14", VA = "0x1193F14", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x11919C4", Offset = "0x11919C4", VA = "0x11919C4")]
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
		[Address(RVA = "0x1CE9650", Offset = "0x1CE9650", VA = "0x1CE9650")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1CE96B0", Offset = "0x1CE96B0", VA = "0x1CE96B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1CE96E4", Offset = "0x1CE96E4", VA = "0x1CE96E4")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0DF0", Offset = "0x9E0DF0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E1DF4", Offset = "0x9E1DF4")]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E1E34", Offset = "0x9E1E34")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E1EE8", Offset = "0x9E1EE8")]
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
		[Address(RVA = "0x1CE96EC", Offset = "0x1CE96EC", VA = "0x1CE96EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1CE9788", Offset = "0x1CE9788", VA = "0x1CE9788")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1CEA124", Offset = "0x1CEA124", VA = "0x1CEA124")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1CEA3C0", Offset = "0x1CEA3C0", VA = "0x1CEA3C0")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1CEA3F0", Offset = "0x1CEA3F0", VA = "0x1CEA3F0")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0E54", Offset = "0x9E0E54")]
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
		[Address(RVA = "0x1CEA438", Offset = "0x1CEA438", VA = "0x1CEA438")]
		private void StartSound()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1CEA630", Offset = "0x1CEA630", VA = "0x1CEA630")]
		private void StopSound()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1CEA710", Offset = "0x1CEA710", VA = "0x1CEA710")]
		private void Update()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1CEA520", Offset = "0x1CEA520", VA = "0x1CEA520")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1CEAB08", Offset = "0x1CEAB08", VA = "0x1CEAB08")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1CEAB20", Offset = "0x1CEAB20", VA = "0x1CEAB20")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E1FE8", Offset = "0x9E1FE8")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2028", Offset = "0x9E2028")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2108", Offset = "0x9E2108")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2118", Offset = "0x9E2118")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2128", Offset = "0x9E2128")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2138", Offset = "0x9E2138")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool Skidding
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1CEAB4C", Offset = "0x1CEAB4C", VA = "0x1CEAB4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3068", Offset = "0x9E3068")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1CEAB54", Offset = "0x1CEAB54", VA = "0x1CEAB54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3078", Offset = "0x9E3078")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float BrakeInput
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1CEAB60", Offset = "0x1CEAB60", VA = "0x1CEAB60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3088", Offset = "0x9E3088")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1CEAB68", Offset = "0x1CEAB68", VA = "0x1CEAB68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3098", Offset = "0x9E3098")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1CEAB70", Offset = "0x1CEAB70", VA = "0x1CEAB70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1CEA0D0", Offset = "0x1CEA0D0", VA = "0x1CEA0D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float MaxSpeed
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1CEAB78", Offset = "0x1CEAB78", VA = "0x1CEAB78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public float Revs
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1CEAB80", Offset = "0x1CEAB80", VA = "0x1CEAB80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E30A8", Offset = "0x9E30A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1CEAB88", Offset = "0x1CEAB88", VA = "0x1CEAB88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E30B8", Offset = "0x9E30B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float AccelInput
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1CEAB90", Offset = "0x1CEAB90", VA = "0x1CEAB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E30C8", Offset = "0x9E30C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1CEAB98", Offset = "0x1CEAB98", VA = "0x1CEAB98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E30D8", Offset = "0x9E30D8")]
			private set
			{
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1CEABA0", Offset = "0x1CEABA0", VA = "0x1CEABA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1CEACFC", Offset = "0x1CEACFC", VA = "0x1CEACFC")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1CEAE34", Offset = "0x1CEAE34", VA = "0x1CEAE34")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1CEAE48", Offset = "0x1CEAE48", VA = "0x1CEAE48")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1CEAE60", Offset = "0x1CEAE60", VA = "0x1CEAE60")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1CEAF6C", Offset = "0x1CEAF6C", VA = "0x1CEAF6C")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1CE9DFC", Offset = "0x1CE9DFC", VA = "0x1CE9DFC")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1CEB590", Offset = "0x1CEB590", VA = "0x1CEB590")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1CEB2B8", Offset = "0x1CEB2B8", VA = "0x1CEB2B8")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1CEB040", Offset = "0x1CEB040", VA = "0x1CEB040")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1CEB6CC", Offset = "0x1CEB6CC", VA = "0x1CEB6CC")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1CEB838", Offset = "0x1CEB838", VA = "0x1CEB838")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1CEBA00", Offset = "0x1CEBA00", VA = "0x1CEBA00")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1CEBF8C", Offset = "0x1CEBF8C", VA = "0x1CEBF8C")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1CEBDF0", Offset = "0x1CEBDF0", VA = "0x1CEBDF0")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1CEBFD4", Offset = "0x1CEBFD4", VA = "0x1CEBFD4")]
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
		[Address(RVA = "0x1CEC0F8", Offset = "0x1CEC0F8", VA = "0x1CEC0F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1CEC158", Offset = "0x1CEC158", VA = "0x1CEC158")]
		private void Update()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1CEC204", Offset = "0x1CEC204", VA = "0x1CEC204")]
		private void RightCar()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1CEC348", Offset = "0x1CEC348", VA = "0x1CEC348")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0EB8", Offset = "0x9E0EB8")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1CEC35C", Offset = "0x1CEC35C", VA = "0x1CEC35C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1CEC3BC", Offset = "0x1CEC3BC", VA = "0x1CEC3BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1CEC46C", Offset = "0x1CEC46C", VA = "0x1CEC46C")]
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
		[Address(RVA = "0x1CEC474", Offset = "0x1CEC474", VA = "0x1CEC474")]
		private void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1CEC4B0", Offset = "0x1CEC4B0", VA = "0x1CEC4B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1CEC598", Offset = "0x1CEC598", VA = "0x1CEC598")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1724", Offset = "0x9E1724")]
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
				[Address(RVA = "0x1CEC794", Offset = "0x1CEC794", VA = "0x1CEC794", Slot = "4")]
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
				[Address(RVA = "0x1CEC7FC", Offset = "0x1CEC7FC", VA = "0x1CEC7FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1CEC61C", Offset = "0x1CEC61C", VA = "0x1CEC61C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1CEC650", Offset = "0x1CEC650", VA = "0x1CEC650", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1CEC654", Offset = "0x1CEC654", VA = "0x1CEC654", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1CEC79C", Offset = "0x1CEC79C", VA = "0x1CEC79C", Slot = "8")]
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
		[Address(RVA = "0x1CEC5A0", Offset = "0x1CEC5A0", VA = "0x1CEC5A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E30E8", Offset = "0x9E30E8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1CEC648", Offset = "0x1CEC648", VA = "0x1CEC648")]
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
		[Address(RVA = "0x1CEC804", Offset = "0x1CEC804", VA = "0x1CEC804")]
		private void Start()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1CEC868", Offset = "0x1CEC868", VA = "0x1CEC868")]
		private void Update()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1CEC990", Offset = "0x1CEC990", VA = "0x1CEC990")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0F1C", Offset = "0x9E0F1C")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1734", Offset = "0x9E1734")]
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
				[Address(RVA = "0x1CECE50", Offset = "0x1CECE50", VA = "0x1CECE50", Slot = "4")]
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
				[Address(RVA = "0x1CECEB8", Offset = "0x1CECEB8", VA = "0x1CECEB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1CECC48", Offset = "0x1CECC48", VA = "0x1CECC48")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1CECC7C", Offset = "0x1CECC7C", VA = "0x1CECC7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1CECC80", Offset = "0x1CECC80", VA = "0x1CECC80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1CECE58", Offset = "0x1CECE58", VA = "0x1CECE58", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2178", Offset = "0x9E2178")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2188", Offset = "0x9E2188")]
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
			[Address(RVA = "0x1CEC998", Offset = "0x1CEC998", VA = "0x1CEC998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E314C", Offset = "0x9E314C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1CEC9A0", Offset = "0x1CEC9A0", VA = "0x1CEC9A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E315C", Offset = "0x9E315C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool PlayingAudio
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1CEC9AC", Offset = "0x1CEC9AC", VA = "0x1CEC9AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E316C", Offset = "0x9E316C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1CEC9B4", Offset = "0x1CEC9B4", VA = "0x1CEC9B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E317C", Offset = "0x9E317C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1CEC9C0", Offset = "0x1CEC9C0", VA = "0x1CEC9C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1CEBC68", Offset = "0x1CEBC68", VA = "0x1CEBC68")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1CEBE5C", Offset = "0x1CEBE5C", VA = "0x1CEBE5C")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1CEBE94", Offset = "0x1CEBE94", VA = "0x1CEBE94")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1CECBCC", Offset = "0x1CECBCC", VA = "0x1CECBCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E318C", Offset = "0x9E318C")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1CEBEC8", Offset = "0x1CEBEC8", VA = "0x1CEBEC8")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1CECC74", Offset = "0x1CECC74", VA = "0x1CECC74")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0F80", Offset = "0x9E0F80")]
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
		[Address(RVA = "0x119D06C", Offset = "0x119D06C", VA = "0x119D06C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x119D0E8", Offset = "0x119D0E8", VA = "0x119D0E8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x119D0F0", Offset = "0x119D0F0", VA = "0x119D0F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x119D430", Offset = "0x119D430", VA = "0x119D430")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x119D438", Offset = "0x119D438", VA = "0x119D438")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2A90", Offset = "0x9E2A90")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2AA8", Offset = "0x9E2AA8")]
			public float windMasterVolume;

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x119D904", Offset = "0x119D904", VA = "0x119D904")]
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
		[Address(RVA = "0x119D458", Offset = "0x119D458", VA = "0x119D458")]
		private void Awake()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x119D690", Offset = "0x119D690", VA = "0x119D690")]
		private void Update()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x119D850", Offset = "0x119D850", VA = "0x119D850")]
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
			[Address(RVA = "0x119DD2C", Offset = "0x119DD2C", VA = "0x119DD2C")]
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
		[Address(RVA = "0x119D920", Offset = "0x119D920", VA = "0x119D920")]
		private void Start()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x119D9F0", Offset = "0x119D9F0", VA = "0x119D9F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x119DBC8", Offset = "0x119DBC8", VA = "0x119DBC8")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x119DD1C", Offset = "0x119DD1C", VA = "0x119DD1C")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E0FE4", Offset = "0x9E0FE4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E23B8", Offset = "0x9E23B8")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E23C8", Offset = "0x9E23C8")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E23D8", Offset = "0x9E23D8")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E23E8", Offset = "0x9E23E8")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E23F8", Offset = "0x9E23F8")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2408", Offset = "0x9E2408")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2418", Offset = "0x9E2418")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2428", Offset = "0x9E2428")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2438", Offset = "0x9E2438")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2448", Offset = "0x9E2448")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2458", Offset = "0x9E2458")]
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
			[Address(RVA = "0x119DD34", Offset = "0x119DD34", VA = "0x119DD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E31F0", Offset = "0x9E31F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x119DD3C", Offset = "0x119DD3C", VA = "0x119DD3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3200", Offset = "0x9E3200")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float Throttle
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x119DD44", Offset = "0x119DD44", VA = "0x119DD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3210", Offset = "0x9E3210")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x119DD4C", Offset = "0x119DD4C", VA = "0x119DD4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3220", Offset = "0x9E3220")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool AirBrakes
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x119DD54", Offset = "0x119DD54", VA = "0x119DD54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3230", Offset = "0x9E3230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x119DD5C", Offset = "0x119DD5C", VA = "0x119DD5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3240", Offset = "0x9E3240")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float ForwardSpeed
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x119DD68", Offset = "0x119DD68", VA = "0x119DD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3250", Offset = "0x9E3250")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x119DD70", Offset = "0x119DD70", VA = "0x119DD70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3260", Offset = "0x9E3260")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float EnginePower
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x119DD78", Offset = "0x119DD78", VA = "0x119DD78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3270", Offset = "0x9E3270")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x119DD80", Offset = "0x119DD80", VA = "0x119DD80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3280", Offset = "0x9E3280")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float MaxEnginePower
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x119DD88", Offset = "0x119DD88", VA = "0x119DD88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float RollAngle
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x119DD90", Offset = "0x119DD90", VA = "0x119DD90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3290", Offset = "0x9E3290")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x119DD98", Offset = "0x119DD98", VA = "0x119DD98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32A0", Offset = "0x9E32A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float PitchAngle
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x119DDA0", Offset = "0x119DDA0", VA = "0x119DDA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32B0", Offset = "0x9E32B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x119DDA8", Offset = "0x119DDA8", VA = "0x119DDA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32C0", Offset = "0x9E32C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float RollInput
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x119DDB0", Offset = "0x119DDB0", VA = "0x119DDB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32D0", Offset = "0x9E32D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x119DDB8", Offset = "0x119DDB8", VA = "0x119DDB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32E0", Offset = "0x9E32E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float PitchInput
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x119DDC0", Offset = "0x119DDC0", VA = "0x119DDC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32F0", Offset = "0x9E32F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x119DDC8", Offset = "0x119DDC8", VA = "0x119DDC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3300", Offset = "0x9E3300")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float YawInput
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x119DDD0", Offset = "0x119DDD0", VA = "0x119DDD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3310", Offset = "0x9E3310")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x119DDD8", Offset = "0x119DDD8", VA = "0x119DDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3320", Offset = "0x9E3320")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float ThrottleInput
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x119DDE0", Offset = "0x119DDE0", VA = "0x119DDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3330", Offset = "0x9E3330")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x119DDE8", Offset = "0x119DDE8", VA = "0x119DDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3340", Offset = "0x9E3340")]
			private set
			{
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x119DDF0", Offset = "0x119DDF0", VA = "0x119DDF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x119D3BC", Offset = "0x119D3BC", VA = "0x119D3BC")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x119DF5C", Offset = "0x119DF5C", VA = "0x119DF5C")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x119E044", Offset = "0x119E044", VA = "0x119E044")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x119E1C0", Offset = "0x119E1C0", VA = "0x119E1C0")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x119E2AC", Offset = "0x119E2AC", VA = "0x119E2AC")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x119E364", Offset = "0x119E364", VA = "0x119E364")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x119E428", Offset = "0x119E428", VA = "0x119E428")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x119E4D4", Offset = "0x119E4D4", VA = "0x119E4D4")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x119E7A0", Offset = "0x119E7A0", VA = "0x119E7A0")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x119E9C4", Offset = "0x119E9C4", VA = "0x119E9C4")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x119EC30", Offset = "0x119EC30", VA = "0x119EC30")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x119EDC0", Offset = "0x119EDC0", VA = "0x119EDC0")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x119EDCC", Offset = "0x119EDCC", VA = "0x119EDCC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x119EDD4", Offset = "0x119EDD4", VA = "0x119EDD4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2498", Offset = "0x9E2498")]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E24D8", Offset = "0x9E24D8")]
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
		[Address(RVA = "0x1CE81C8", Offset = "0x1CE81C8", VA = "0x1CE81C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1CE8298", Offset = "0x1CE8298", VA = "0x1CE8298")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1CE8478", Offset = "0x1CE8478", VA = "0x1CE8478")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1048", Offset = "0x9E1048")]
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
		[Address(RVA = "0x1CE849C", Offset = "0x1CE849C", VA = "0x1CE849C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1CE84FC", Offset = "0x1CE84FC", VA = "0x1CE84FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1CE8600", Offset = "0x1CE8600", VA = "0x1CE8600")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1CE8738", Offset = "0x1CE8738", VA = "0x1CE8738")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E10AC", Offset = "0x9E10AC")]
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
		[Address(RVA = "0x1CE874C", Offset = "0x1CE874C", VA = "0x1CE874C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1CE87AC", Offset = "0x1CE87AC", VA = "0x1CE87AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1CE88C8", Offset = "0x1CE88C8", VA = "0x1CE88C8")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1CE89C0", Offset = "0x1CE89C0", VA = "0x1CE89C0")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1110", Offset = "0x9E1110")]
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
		[Address(RVA = "0x1CE89D4", Offset = "0x1CE89D4", VA = "0x1CE89D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1CE8C7C", Offset = "0x1CE8C7C", VA = "0x1CE8C7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1CE8B4C", Offset = "0x1CE8B4C", VA = "0x1CE8B4C")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1CE8E04", Offset = "0x1CE8E04", VA = "0x1CE8E04")]
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
		[Address(RVA = "0x1CE8E0C", Offset = "0x1CE8E0C", VA = "0x1CE8E0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1CE8EB4", Offset = "0x1CE8EB4", VA = "0x1CE8EB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1CE8FA0", Offset = "0x1CE8FA0", VA = "0x1CE8FA0")]
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
		[Address(RVA = "0x1CE8FBC", Offset = "0x1CE8FBC", VA = "0x1CE8FBC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1CE903C", Offset = "0x1CE903C", VA = "0x1CE903C")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1CE9238", Offset = "0x1CE9238", VA = "0x1CE9238")]
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
		[Address(RVA = "0x1CE925C", Offset = "0x1CE925C", VA = "0x1CE925C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1CE9364", Offset = "0x1CE9364", VA = "0x1CE9364")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1CE960C", Offset = "0x1CE960C", VA = "0x1CE960C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1CE9648", Offset = "0x1CE9648", VA = "0x1CE9648")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1174", Offset = "0x9E1174")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1174", Offset = "0x9E1174")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2568", Offset = "0x9E2568")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2578", Offset = "0x9E2578")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000023")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x118F7F8", Offset = "0x118F7F8", VA = "0x118F7F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3350", Offset = "0x9E3350")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x118F800", Offset = "0x118F800", VA = "0x118F800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3360", Offset = "0x9E3360")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x118F808", Offset = "0x118F808", VA = "0x118F808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3370", Offset = "0x9E3370")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x118F810", Offset = "0x118F810", VA = "0x118F810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3380", Offset = "0x9E3380")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x118F818", Offset = "0x118F818", VA = "0x118F818")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x118F8CC", Offset = "0x118F8CC", VA = "0x118F8CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x118FBA8", Offset = "0x118FBA8", VA = "0x118FBA8")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x118FBB0", Offset = "0x118FBB0", VA = "0x118FBB0")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1200", Offset = "0x9E1200")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1200", Offset = "0x9E1200")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1200", Offset = "0x9E1200")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E25B8", Offset = "0x9E25B8")]
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
		[Address(RVA = "0x118FBB8", Offset = "0x118FBB8", VA = "0x118FBB8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x118F9F0", Offset = "0x118F9F0", VA = "0x118F9F0")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1190168", Offset = "0x1190168", VA = "0x1190168")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1190404", Offset = "0x1190404", VA = "0x1190404")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x11905BC", Offset = "0x11905BC", VA = "0x11905BC")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1190054", Offset = "0x1190054", VA = "0x1190054")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x118FF14", Offset = "0x118FF14", VA = "0x118FF14")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x118FE44", Offset = "0x118FE44", VA = "0x118FE44")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1190808", Offset = "0x1190808", VA = "0x1190808")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x118FCB0", Offset = "0x118FCB0", VA = "0x118FCB0")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1190938", Offset = "0x1190938", VA = "0x1190938")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E12B4", Offset = "0x9E12B4")]
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
		[Address(RVA = "0x1190958", Offset = "0x1190958", VA = "0x1190958")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1190A74", Offset = "0x1190A74", VA = "0x1190A74")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1190AF4", Offset = "0x1190AF4", VA = "0x1190AF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1190D98", Offset = "0x1190D98", VA = "0x1190D98")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1318", Offset = "0x9E1318")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1318", Offset = "0x9E1318")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2668", Offset = "0x9E2668")]
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
		[Address(RVA = "0x118C914", Offset = "0x118C914", VA = "0x118C914")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x118CB84", Offset = "0x118CB84", VA = "0x118CB84")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x118CDE8", Offset = "0x118CDE8", VA = "0x118CDE8")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x118CE3C", Offset = "0x118CE3C", VA = "0x118CE3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x118D398", Offset = "0x118D398", VA = "0x118D398")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x118D3D8", Offset = "0x118D3D8", VA = "0x118D3D8")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x118D6B0", Offset = "0x118D6B0", VA = "0x118D6B0")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x118D4DC", Offset = "0x118D4DC", VA = "0x118D4DC")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x118D200", Offset = "0x118D200", VA = "0x118D200")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x118CC98", Offset = "0x118CC98", VA = "0x118CC98")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x118DD28", Offset = "0x118DD28", VA = "0x118DD28")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x118DEA8", Offset = "0x118DEA8", VA = "0x118DEA8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2778", Offset = "0x9E2778")]
		public float RunningStrideLengthen;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x118E230", Offset = "0x118E230", VA = "0x118E230")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x118E288", Offset = "0x118E288", VA = "0x118E288")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x118E498", Offset = "0x118E498", VA = "0x118E498")]
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
		[Address(RVA = "0x118CB30", Offset = "0x118CB30", VA = "0x118CB30")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x118DA38", Offset = "0x118DA38", VA = "0x118DA38")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x118E5FC", Offset = "0x118E5FC", VA = "0x118E5FC")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x118D6A0", Offset = "0x118D6A0", VA = "0x118D6A0")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x118E630", Offset = "0x118E630", VA = "0x118E630")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x118E534", Offset = "0x118E534", VA = "0x118E534")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x118E6AC", Offset = "0x118E6AC", VA = "0x118E6AC")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E13A4", Offset = "0x9E13A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E13A4", Offset = "0x9E13A4")]
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
			[Address(RVA = "0x118F444", Offset = "0x118F444", VA = "0x118F444")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x118F618", Offset = "0x118F618", VA = "0x118F618")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E2AE0", Offset = "0x9E2AE0")]
			public float shellOffset;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x118F7DC", Offset = "0x118F7DC", VA = "0x118F7DC")]
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
			[Address(RVA = "0x118E474", Offset = "0x118E474", VA = "0x118E474")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public bool Grounded
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x118E6E0", Offset = "0x118E6E0", VA = "0x118E6E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public bool Jumping
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x118E6E8", Offset = "0x118E6E8", VA = "0x118E6E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public bool Running
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x118E490", Offset = "0x118E490", VA = "0x118E490")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x118E6F0", Offset = "0x118E6F0", VA = "0x118E6F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x118E7B4", Offset = "0x118E7B4", VA = "0x118E7B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x118EA48", Offset = "0x118EA48", VA = "0x118EA48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x118F10C", Offset = "0x118F10C", VA = "0x118F10C")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x118F1C4", Offset = "0x118F1C4", VA = "0x118F1C4")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x118F05C", Offset = "0x118F05C", VA = "0x118F05C")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x118E840", Offset = "0x118E840", VA = "0x118E840")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x118EE74", Offset = "0x118EE74", VA = "0x118EE74")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x118F510", Offset = "0x118F510", VA = "0x118F510")]
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
			[Address(RVA = "0x118A900", Offset = "0x118A900", VA = "0x118A900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x118A4FC", Offset = "0x118A4FC", VA = "0x118A4FC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x118A674", Offset = "0x118A674", VA = "0x118A674")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x118A748", Offset = "0x118A748", VA = "0x118A748")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x118A820", Offset = "0x118A820", VA = "0x118A820")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000200")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x118A5B8", Offset = "0x118A5B8", VA = "0x118A5B8")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x118A8F8", Offset = "0x118A8F8", VA = "0x118A8F8", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x118A908", Offset = "0x118A908", VA = "0x118A908")]
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
		[Address(RVA = "0x118A918", Offset = "0x118A918", VA = "0x118A918", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x118AE8C", Offset = "0x118AE8C", VA = "0x118AE8C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2850", Offset = "0x9E2850")]
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
		[Address(RVA = "0x118AF48", Offset = "0x118AF48", VA = "0x118AF48", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x118B09C", Offset = "0x118B09C", VA = "0x118B09C")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x118B48C", Offset = "0x118B48C", VA = "0x118B48C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x118B4B0", Offset = "0x118B4B0", VA = "0x118B4B0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x118B0FC", Offset = "0x118B0FC", VA = "0x118B0FC")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x118B678", Offset = "0x118B678", VA = "0x118B678")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E2910", Offset = "0x9E2910")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x118B6A0", Offset = "0x118B6A0", VA = "0x118B6A0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x118BB44", Offset = "0x118BB44", VA = "0x118BB44")]
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
		[Address(RVA = "0x118BB84", Offset = "0x118BB84", VA = "0x118BB84", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x118B830", Offset = "0x118B830", VA = "0x118B830", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x118BB6C", Offset = "0x118BB6C", VA = "0x118BB6C")]
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
		[Address(RVA = "0x118B008", Offset = "0x118B008", VA = "0x118B008", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x118AF38", Offset = "0x118AF38", VA = "0x118AF38")]
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
			[Address(RVA = "0x118C3E0", Offset = "0x118C3E0", VA = "0x118C3E0", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x118BCE0", Offset = "0x118BCE0", VA = "0x118BCE0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2970", Offset = "0x9E2970")]
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
			[Address(RVA = "0x118BBC8", Offset = "0x118BBC8", VA = "0x118BBC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3390", Offset = "0x9E3390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x118BBD0", Offset = "0x118BBD0", VA = "0x118BBD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E33A0", Offset = "0x9E33A0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x118BBDC", Offset = "0x118BBDC", VA = "0x118BBDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x118BCE8", Offset = "0x118BCE8", VA = "0x118BCE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x118C360", Offset = "0x118C360", VA = "0x118C360")]
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
		[Address(RVA = "0x118C4E8", Offset = "0x118C4E8", VA = "0x118C4E8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x118C740", Offset = "0x118C740", VA = "0x118C740", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x118C8BC", Offset = "0x118C8BC", VA = "0x118C8BC", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x118C560", Offset = "0x118C560", VA = "0x118C560")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x118C8F8", Offset = "0x118C8F8", VA = "0x118C8F8")]
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
		[Address(RVA = "0x1CF177C", Offset = "0x1CF177C", VA = "0x1CF177C")]
		private void Start()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1CF188C", Offset = "0x1CF188C", VA = "0x1CF188C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1CF1BAC", Offset = "0x1CF1BAC", VA = "0x1CF1BAC")]
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
		[Address(RVA = "0x1CF1BC0", Offset = "0x1CF1BC0", VA = "0x1CF1BC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1CF1C30", Offset = "0x1CF1C30", VA = "0x1CF1C30")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1CF1CDC", Offset = "0x1CF1CDC", VA = "0x1CF1CDC")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1CF1D88", Offset = "0x1CF1D88", VA = "0x1CF1D88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1CF1D8C", Offset = "0x1CF1D8C", VA = "0x1CF1D8C")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1CF1FE4", Offset = "0x1CF1FE4", VA = "0x1CF1FE4")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9E1440", Offset = "0x9E1440")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1CF1FF8", Offset = "0x1CF1FF8", VA = "0x1CF1FF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1CF2058", Offset = "0x1CF2058", VA = "0x1CF2058")]
		private void Update()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1CF20DC", Offset = "0x1CF20DC", VA = "0x1CF20DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1CF2460", Offset = "0x1CF2460", VA = "0x1CF2460")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9E29D0", Offset = "0x9E29D0")]
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
		[Address(RVA = "0x1CF2468", Offset = "0x1CF2468", VA = "0x1CF2468")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1CF2558", Offset = "0x1CF2558", VA = "0x1CF2558")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1CF2180", Offset = "0x1CF2180", VA = "0x1CF2180")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1CF2764", Offset = "0x1CF2764", VA = "0x1CF2764")]
		private void Flip()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1CF27E0", Offset = "0x1CF27E0", VA = "0x1CF27E0")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1CF2808", Offset = "0x1CF2808", VA = "0x1CF2808")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1CF28C4", Offset = "0x1CF28C4", VA = "0x1CF28C4")]
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
		[Address(RVA = "0x102C498", Offset = "0x102C498", VA = "0x102C498")]
		internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x102CA9C", Offset = "0x102CA9C", VA = "0x102CA9C")]
		internal static void DestroyInstance(GameObject instance)
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9E14A4", Offset = "0x9E14A4")]
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
			[Address(RVA = "0x1189D04", Offset = "0x1189D04", VA = "0x1189D04", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public SpawnPool Item
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x1189E38", Offset = "0x1189E38", VA = "0x1189E38", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x1189F78", Offset = "0x1189F78", VA = "0x1189F78", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1189FE4", Offset = "0x1189FE4", VA = "0x1189FE4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public ICollection<SpawnPool> Values
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x118A050", Offset = "0x118A050", VA = "0x118A050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x118A0BC", Offset = "0x118A0BC", VA = "0x118A0BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.IsReadOnly
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x118A0C4", Offset = "0x118A0C4", VA = "0x118A0C4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1188BC4", Offset = "0x1188BC4", VA = "0x1188BC4")]
		public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1188D1C", Offset = "0x1188D1C", VA = "0x1188D1C")]
		public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1188EAC", Offset = "0x1188EAC", VA = "0x1188EAC")]
		public SpawnPool Create(string poolName)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1188F44", Offset = "0x1188F44", VA = "0x1188F44")]
		public SpawnPool Create(string poolName, GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1189060", Offset = "0x1189060", VA = "0x1189060")]
		private bool assertValidPoolName(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1189214", Offset = "0x1189214", VA = "0x1189214", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x11892F4", Offset = "0x11892F4", VA = "0x11892F4")]
		public bool Destroy(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x118942C", Offset = "0x118942C", VA = "0x118942C")]
		public void DestroyAll()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1189614", Offset = "0x1189614", VA = "0x1189614")]
		internal void Add(SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1189AD8", Offset = "0x1189AD8", VA = "0x1189AD8", Slot = "9")]
		public void Add(string key, SpawnPool value)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1189B44", Offset = "0x1189B44", VA = "0x1189B44")]
		internal bool Remove(SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1189C98", Offset = "0x1189C98", VA = "0x1189C98", Slot = "10")]
		public bool Remove(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x11891AC", Offset = "0x11891AC", VA = "0x11891AC", Slot = "8")]
		public bool ContainsKey(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1189C30", Offset = "0x1189C30", VA = "0x1189C30")]
		public bool ContainsValue(SpawnPool pool)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1189D5C", Offset = "0x1189D5C", VA = "0x1189D5C", Slot = "11")]
		public bool TryGetValue(string poolName, out SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1189DCC", Offset = "0x1189DCC", VA = "0x1189DCC", Slot = "16")]
		public bool Contains(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x118A0CC", Offset = "0x118A0CC", VA = "0x118A0CC", Slot = "14")]
		public void Add(KeyValuePair<string, SpawnPool> item)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x118A138", Offset = "0x118A138", VA = "0x118A138", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x118A1A4", Offset = "0x118A1A4", VA = "0x118A1A4")]
		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x118A210", Offset = "0x118A210", VA = "0x118A210", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x118A27C", Offset = "0x118A27C", VA = "0x118A27C", Slot = "18")]
		public bool Remove(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x118A2E8", Offset = "0x118A2E8", VA = "0x118A2E8", Slot = "19")]
		public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x118A378", Offset = "0x118A378", VA = "0x118A378", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x118A408", Offset = "0x118A408", VA = "0x118A408")]
		public SpawnPoolsDict()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9E14DC", Offset = "0x9E14DC")]
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
		[Address(RVA = "0x102D058", Offset = "0x102D058", VA = "0x102D058")]
		private void Start()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x102D464", Offset = "0x102D464", VA = "0x102D464")]
		public PreRuntimePoolItem()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9E1514", Offset = "0x9E1514")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9E1514", Offset = "0x9E1514")]
	public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
	{
		[Token(Token = "0x20000A4")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000A5")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1744", Offset = "0x9E1744")]
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
				[Address(RVA = "0x11879D8", Offset = "0x11879D8", VA = "0x11879D8", Slot = "4")]
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
				[Address(RVA = "0x1187A40", Offset = "0x1187A40", VA = "0x1187A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x11878A4", Offset = "0x11878A4", VA = "0x11878A4")]
			[DebuggerHidden]
			public <DoDespawnAfterSeconds>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x11878D0", Offset = "0x11878D0", VA = "0x11878D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x11878D4", Offset = "0x11878D4", VA = "0x11878D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x11879E0", Offset = "0x11879E0", VA = "0x11879E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1754", Offset = "0x9E1754")]
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
				[Address(RVA = "0x1187D1C", Offset = "0x1187D1C", VA = "0x1187D1C", Slot = "4")]
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
				[Address(RVA = "0x1187D84", Offset = "0x1187D84", VA = "0x1187D84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1187BC4", Offset = "0x1187BC4", VA = "0x1187BC4")]
			[DebuggerHidden]
			public <ListForAudioStop>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1187BF0", Offset = "0x1187BF0", VA = "0x1187BF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1187BF4", Offset = "0x1187BF4", VA = "0x1187BF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1187D24", Offset = "0x1187D24", VA = "0x1187D24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1764", Offset = "0x9E1764")]
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
				[Address(RVA = "0x1188034", Offset = "0x1188034", VA = "0x1188034", Slot = "4")]
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
				[Address(RVA = "0x118809C", Offset = "0x118809C", VA = "0x118809C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1187D8C", Offset = "0x1187D8C", VA = "0x1187D8C")]
			[DebuggerHidden]
			public <ListenForEmitDespawn>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1187DB8", Offset = "0x1187DB8", VA = "0x1187DB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1187DBC", Offset = "0x1187DBC", VA = "0x1187DBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x118803C", Offset = "0x118803C", VA = "0x118803C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1774", Offset = "0x9E1774")]
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
				[Address(RVA = "0x1187B54", Offset = "0x1187B54", VA = "0x1187B54", Slot = "4")]
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
				[Address(RVA = "0x1187BBC", Offset = "0x1187BBC", VA = "0x1187BBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1187A48", Offset = "0x1187A48", VA = "0x1187A48")]
			[DebuggerHidden]
			public <GetEnumerator>d__73(int <>1__state)
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1187A74", Offset = "0x1187A74", VA = "0x1187A74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1187A78", Offset = "0x1187A78", VA = "0x1187A78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1187B5C", Offset = "0x1187B5C", VA = "0x1187B5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1784", Offset = "0x9E1784")]
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
				[Address(RVA = "0x11881B0", Offset = "0x11881B0", VA = "0x11881B0", Slot = "4")]
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
				[Address(RVA = "0x1188218", Offset = "0x1188218", VA = "0x1188218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x11880A4", Offset = "0x11880A4", VA = "0x11880A4")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x11880D0", Offset = "0x11880D0", VA = "0x11880D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x11880D4", Offset = "0x11880D4", VA = "0x11880D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x11881B8", Offset = "0x11881B8", VA = "0x11881B8", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2A30", Offset = "0x9E2A30")]
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
			[Address(RVA = "0x1030414", Offset = "0x1030414", VA = "0x1030414")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x103041C", Offset = "0x103041C", VA = "0x103041C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Transform group
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x10304F4", Offset = "0x10304F4", VA = "0x10304F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E33B0", Offset = "0x9E33B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x10304FC", Offset = "0x10304FC", VA = "0x10304FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E33C0", Offset = "0x9E33C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Dictionary<string, PrefabPool> prefabPools
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1030504", Offset = "0x1030504", VA = "0x1030504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public Transform Item
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x103299C", Offset = "0x103299C", VA = "0x103299C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1032A14", Offset = "0x1032A14", VA = "0x1032A14", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int Count
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1032B5C", Offset = "0x1032B5C", VA = "0x1032B5C", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1032E24", Offset = "0x1032E24", VA = "0x1032E24", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1030620", Offset = "0x1030620", VA = "0x1030620")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x102E7C0", Offset = "0x102E7C0", VA = "0x102E7C0")]
		internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x102DB84", Offset = "0x102DB84", VA = "0x102DB84")]
		internal void DestroyInstance(GameObject instance)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1030ADC", Offset = "0x1030ADC", VA = "0x1030ADC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1030924", Offset = "0x1030924", VA = "0x1030924")]
		public void CreatePrefabPool(PrefabPool prefabPool)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x102D184", Offset = "0x102D184", VA = "0x102D184")]
		public void Add(Transform instance, string prefabName, bool despawn, bool parent)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1030EB0", Offset = "0x1030EB0", VA = "0x1030EB0", Slot = "11")]
		public void Add(Transform item)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1030F1C", Offset = "0x1030F1C", VA = "0x1030F1C")]
		public void Remove(Transform item)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1030F88", Offset = "0x1030F88", VA = "0x1030F88")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x10313C8", Offset = "0x10313C8", VA = "0x10313C8")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10314BC", Offset = "0x10314BC", VA = "0x10314BC")]
		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x10315A8", Offset = "0x10315A8", VA = "0x10315A8")]
		public Transform Spawn(Transform prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x103169C", Offset = "0x103169C", VA = "0x103169C")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1031734", Offset = "0x1031734", VA = "0x1031734")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10317C4", Offset = "0x10317C4", VA = "0x10317C4")]
		public Transform Spawn(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x10317FC", Offset = "0x10317FC", VA = "0x10317FC")]
		public Transform Spawn(GameObject prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x103183C", Offset = "0x103183C", VA = "0x103183C")]
		public Transform Spawn(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1031870", Offset = "0x1031870", VA = "0x1031870")]
		public Transform Spawn(string prefabName, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x10318AC", Offset = "0x10318AC", VA = "0x10318AC")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1031938", Offset = "0x1031938", VA = "0x1031938")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10319CC", Offset = "0x10319CC", VA = "0x10319CC")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1031B28", Offset = "0x1031B28", VA = "0x1031B28")]
		public AudioSource Spawn(AudioSource prefab)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1031C18", Offset = "0x1031C18", VA = "0x1031C18")]
		public AudioSource Spawn(AudioSource prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10319D4", Offset = "0x10319D4", VA = "0x10319D4")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1031DA4", Offset = "0x1031DA4", VA = "0x1031DA4")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1031DAC", Offset = "0x1031DAC", VA = "0x1031DAC")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1031F8C", Offset = "0x1031F8C", VA = "0x1031F8C")]
		public void Despawn(Transform instance)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x10321B4", Offset = "0x10321B4", VA = "0x10321B4")]
		public void Despawn(Transform instance, Transform parent)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x103223C", Offset = "0x103223C", VA = "0x103223C")]
		public void Despawn(Transform instance, float seconds)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1032340", Offset = "0x1032340", VA = "0x1032340")]
		public void Despawn(Transform instance, float seconds, Transform parent)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1032270", Offset = "0x1032270", VA = "0x1032270")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E33D0", Offset = "0x9E33D0")]
		private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1032374", Offset = "0x1032374", VA = "0x1032374")]
		public void DespawnAll()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1032434", Offset = "0x1032434", VA = "0x1032434")]
		public bool IsSpawned(Transform instance)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1030CE0", Offset = "0x1030CE0", VA = "0x1030CE0")]
		public PrefabPool GetPrefabPool(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x103249C", Offset = "0x103249C", VA = "0x103249C")]
		public PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x103264C", Offset = "0x103264C", VA = "0x103264C")]
		public Transform GetPrefab(Transform instance)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x103272C", Offset = "0x103272C", VA = "0x103272C")]
		public GameObject GetPrefab(GameObject instance)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1031D0C", Offset = "0x1031D0C", VA = "0x1031D0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E3434", Offset = "0x9E3434")]
		private IEnumerator ListForAudioStop(AudioSource src)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1031EF4", Offset = "0x1031EF4", VA = "0x1031EF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E3498", Offset = "0x9E3498")]
		private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1032820", Offset = "0x1032820", VA = "0x1032820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1032A80", Offset = "0x1032A80", VA = "0x1032A80", Slot = "13")]
		public bool Contains(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1032AEC", Offset = "0x1032AEC", VA = "0x1032AEC", Slot = "14")]
		public void CopyTo(Transform[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1032BAC", Offset = "0x1032BAC", VA = "0x1032BAC", Slot = "16")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E34FC", Offset = "0x9E34FC")]
		public IEnumerator<Transform> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1032C28", Offset = "0x1032C28", VA = "0x1032C28", Slot = "17")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E3560", Offset = "0x9E3560")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1032CA4", Offset = "0x1032CA4", VA = "0x1032CA4", Slot = "6")]
		public int IndexOf(Transform item)
		{
			return default(int);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1032D04", Offset = "0x1032D04", VA = "0x1032D04", Slot = "7")]
		public void Insert(int index, Transform item)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1032D64", Offset = "0x1032D64", VA = "0x1032D64", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1032DC4", Offset = "0x1032DC4", VA = "0x1032DC4", Slot = "12")]
		public void Clear()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1032E84", Offset = "0x1032E84", VA = "0x1032E84", Slot = "15")]
		private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1032EE4", Offset = "0x1032EE4", VA = "0x1032EE4")]
		public SpawnPool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class PrefabPool
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1794", Offset = "0x9E1794")]
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
				[Address(RVA = "0x102F688", Offset = "0x102F688", VA = "0x102F688", Slot = "4")]
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
				[Address(RVA = "0x102F6F0", Offset = "0x102F6F0", VA = "0x102F6F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x102DF68", Offset = "0x102DF68", VA = "0x102DF68")]
			[DebuggerHidden]
			public <CullDespawned>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x102F0FC", Offset = "0x102F0FC", VA = "0x102F0FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x102F100", Offset = "0x102F100", VA = "0x102F100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x102F690", Offset = "0x102F690", VA = "0x102F690", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E17A4", Offset = "0x9E17A4")]
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
				[Address(RVA = "0x102F908", Offset = "0x102F908", VA = "0x102F908", Slot = "4")]
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
				[Address(RVA = "0x102F970", Offset = "0x102F970", VA = "0x102F970", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x102EFA8", Offset = "0x102EFA8", VA = "0x102EFA8")]
			[DebuggerHidden]
			public <PreloadOverTime>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x102F6F8", Offset = "0x102F6F8", VA = "0x102F6F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x102F6FC", Offset = "0x102F6FC", VA = "0x102F6FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x102F910", Offset = "0x102F910", VA = "0x102F910", Slot = "8")]
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
			[Address(RVA = "0x102D4DC", Offset = "0x102D4DC", VA = "0x102D4DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public List<Transform> spawned
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x102DB9C", Offset = "0x102DB9C", VA = "0x102DB9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public List<Transform> despawned
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x102DC0C", Offset = "0x102DC0C", VA = "0x102DC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public int totalCount
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x102DC7C", Offset = "0x102DC7C", VA = "0x102DC7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		internal bool preloaded
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x102DCDC", Offset = "0x102DCDC", VA = "0x102DCDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x102DCE4", Offset = "0x102DCE4", VA = "0x102DCE4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x102D520", Offset = "0x102D520", VA = "0x102D520")]
		public PrefabPool(Transform prefab)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x102D634", Offset = "0x102D634", VA = "0x102D634")]
		public PrefabPool()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x102D708", Offset = "0x102D708", VA = "0x102D708")]
		internal void inspectorInstanceConstructor()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x102D7C8", Offset = "0x102D7C8", VA = "0x102D7C8")]
		internal void SelfDestruct()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x102DCF0", Offset = "0x102DCF0", VA = "0x102DCF0")]
		internal bool DespawnInstance(Transform xform)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x102DD0C", Offset = "0x102DD0C", VA = "0x102DD0C")]
		internal bool DespawnInstance(Transform xform, bool sendEventMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x102DEEC", Offset = "0x102DEEC", VA = "0x102DEEC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E35C4", Offset = "0x9E35C4")]
		internal IEnumerator CullDespawned()
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x102DF94", Offset = "0x102DF94", VA = "0x102DF94")]
		internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x102E6E4", Offset = "0x102E6E4", VA = "0x102E6E4")]
		public Transform SpawnNew()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x102E30C", Offset = "0x102E30C", VA = "0x102E30C")]
		public Transform SpawnNew(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x102E888", Offset = "0x102E888", VA = "0x102E888")]
		private void SetRecursively(Transform xform, int layer)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x102EB00", Offset = "0x102EB00", VA = "0x102EB00")]
		internal void AddUnpooled(Transform inst, bool despawn)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x102EBA4", Offset = "0x102EBA4", VA = "0x102EBA4")]
		internal void PreloadInstances()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x102EF2C", Offset = "0x102EF2C", VA = "0x102EF2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9E3628", Offset = "0x9E3628")]
		private IEnumerator PreloadOverTime()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x102EFD4", Offset = "0x102EFD4", VA = "0x102EFD4")]
		public bool Contains(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x102E7D8", Offset = "0x102E7D8", VA = "0x102E7D8")]
		private void nameInstance(Transform instance)
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9E1574", Offset = "0x9E1574")]
	public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Transform> _prefabs;

		[Token(Token = "0x1700003C")]
		public int Count
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x102FB88", Offset = "0x102FB88", VA = "0x102FB88", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public Transform Item
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x102FDFC", Offset = "0x102FDFC", VA = "0x102FDFC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x102FF3C", Offset = "0x102FF3C", VA = "0x102FF3C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x102FFA8", Offset = "0x102FFA8", VA = "0x102FFA8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public ICollection<Transform> Values
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1030000", Offset = "0x1030000", VA = "0x1030000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1030058", Offset = "0x1030058", VA = "0x1030058")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1030060", Offset = "0x1030060", VA = "0x1030060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x102F978", Offset = "0x102F978", VA = "0x102F978", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x102FA58", Offset = "0x102FA58", VA = "0x102FA58")]
		internal void _Add(string prefabName, Transform prefab)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x102FAC8", Offset = "0x102FAC8", VA = "0x102FAC8")]
		internal bool _Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x102FB30", Offset = "0x102FB30", VA = "0x102FB30")]
		internal void _Clear()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x102FBE0", Offset = "0x102FBE0", VA = "0x102FBE0", Slot = "8")]
		public bool ContainsKey(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x102FC48", Offset = "0x102FC48", VA = "0x102FC48", Slot = "11")]
		public bool TryGetValue(string prefabName, out Transform prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x102FCB8", Offset = "0x102FCB8", VA = "0x102FCB8", Slot = "9")]
		public void Add(string key, Transform value)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x102FD24", Offset = "0x102FD24", VA = "0x102FD24", Slot = "10")]
		public bool Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x102FD90", Offset = "0x102FD90", VA = "0x102FD90", Slot = "16")]
		public bool Contains(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1030068", Offset = "0x1030068", VA = "0x1030068", Slot = "14")]
		public void Add(KeyValuePair<string, Transform> item)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x10300D4", Offset = "0x10300D4", VA = "0x10300D4", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1030134", Offset = "0x1030134", VA = "0x1030134")]
		private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x10301A0", Offset = "0x10301A0", VA = "0x10301A0", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x103020C", Offset = "0x103020C", VA = "0x103020C", Slot = "18")]
		public bool Remove(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1030278", Offset = "0x1030278", VA = "0x1030278", Slot = "19")]
		public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1030308", Offset = "0x1030308", VA = "0x1030308", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1030398", Offset = "0x1030398", VA = "0x1030398")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E17B4", Offset = "0x9E17B4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x1021AA8", Offset = "0x1021AA8", VA = "0x1021AA8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1022298", Offset = "0x1022298", VA = "0x1022298")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x10222B4", Offset = "0x10222B4", VA = "0x10222B4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E17C4", Offset = "0x9E17C4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1021BFC", Offset = "0x1021BFC", VA = "0x1021BFC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x10222D0", Offset = "0x10222D0", VA = "0x10222D0")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x10222EC", Offset = "0x10222EC", VA = "0x10222EC")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E17D4", Offset = "0x9E17D4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1021D64", Offset = "0x1021D64", VA = "0x1021D64")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1022308", Offset = "0x1022308", VA = "0x1022308")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1022348", Offset = "0x1022348", VA = "0x1022348")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1021934", Offset = "0x1021934", VA = "0x1021934")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1021AB0", Offset = "0x1021AB0", VA = "0x1021AB0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1021C04", Offset = "0x1021C04", VA = "0x1021C04")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1021D6C", Offset = "0x1021D6C", VA = "0x1021D6C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1021DE4", Offset = "0x1021DE4", VA = "0x1021DE4")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1021E5C", Offset = "0x1021E5C", VA = "0x1021E5C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1021EC4", Offset = "0x1021EC4", VA = "0x1021EC4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1021F4C", Offset = "0x1021F4C", VA = "0x1021F4C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1021FB4", Offset = "0x1021FB4", VA = "0x1021FB4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x102201C", Offset = "0x102201C", VA = "0x102201C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1022084", Offset = "0x1022084", VA = "0x1022084")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x10220EC", Offset = "0x10220EC", VA = "0x10220EC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x102215C", Offset = "0x102215C", VA = "0x102215C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x10221C8", Offset = "0x10221C8", VA = "0x10221C8")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1022230", Offset = "0x1022230", VA = "0x1022230")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200006C")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E17E4", Offset = "0x9E17E4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x102236C", Offset = "0x102236C", VA = "0x102236C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1023678", Offset = "0x1023678", VA = "0x1023678")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E17F4", Offset = "0x9E17F4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x102250C", Offset = "0x102250C", VA = "0x102250C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x10237B4", Offset = "0x10237B4", VA = "0x10237B4")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1804", Offset = "0x9E1804")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x10226AC", Offset = "0x10226AC", VA = "0x10226AC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x10237D0", Offset = "0x10237D0", VA = "0x10237D0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1814", Offset = "0x9E1814")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x102284C", Offset = "0x102284C", VA = "0x102284C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x10237EC", Offset = "0x10237EC", VA = "0x10237EC")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1824", Offset = "0x9E1824")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1022854", Offset = "0x1022854", VA = "0x1022854")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1023808", Offset = "0x1023808", VA = "0x1023808")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1834", Offset = "0x9E1834")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1022A50", Offset = "0x1022A50", VA = "0x1022A50")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1023824", Offset = "0x1023824", VA = "0x1023824")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1844", Offset = "0x9E1844")]
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
			[Address(RVA = "0x1022F08", Offset = "0x1022F08", VA = "0x1022F08")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1023840", Offset = "0x1023840", VA = "0x1023840")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x102385C", Offset = "0x102385C", VA = "0x102385C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1023890", Offset = "0x1023890", VA = "0x1023890")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x10238AC", Offset = "0x10238AC", VA = "0x10238AC")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x10238C8", Offset = "0x10238C8", VA = "0x10238C8")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1854", Offset = "0x9E1854")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x102310C", Offset = "0x102310C", VA = "0x102310C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1023988", Offset = "0x1023988", VA = "0x1023988")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1864", Offset = "0x9E1864")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1023330", Offset = "0x1023330", VA = "0x1023330")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x10239A4", Offset = "0x10239A4", VA = "0x10239A4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x10239C0", Offset = "0x10239C0", VA = "0x10239C0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1874", Offset = "0x9E1874")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x10234C0", Offset = "0x10234C0", VA = "0x10234C0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1023AC4", Offset = "0x1023AC4", VA = "0x1023AC4")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1884", Offset = "0x9E1884")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1023670", Offset = "0x1023670", VA = "0x1023670")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1023694", Offset = "0x1023694", VA = "0x1023694")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x10236B0", Offset = "0x10236B0", VA = "0x10236B0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x101EDE0", Offset = "0x101EDE0", VA = "0x101EDE0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1022374", Offset = "0x1022374", VA = "0x1022374")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1022514", Offset = "0x1022514", VA = "0x1022514")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x10226B4", Offset = "0x10226B4", VA = "0x10226B4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x101F0D8", Offset = "0x101F0D8", VA = "0x101F0D8")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x102285C", Offset = "0x102285C", VA = "0x102285C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1022A58", Offset = "0x1022A58", VA = "0x1022A58")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1022F10", Offset = "0x1022F10", VA = "0x1022F10")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1023114", Offset = "0x1023114", VA = "0x1023114")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1023338", Offset = "0x1023338", VA = "0x1023338")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x10234C8", Offset = "0x10234C8", VA = "0x10234C8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1894", Offset = "0x9E1894")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1023AE0", Offset = "0x1023AE0", VA = "0x1023AE0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1024764", Offset = "0x1024764", VA = "0x1024764")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E18A4", Offset = "0x9E18A4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1023C6C", Offset = "0x1023C6C", VA = "0x1023C6C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1024780", Offset = "0x1024780", VA = "0x1024780")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E18B4", Offset = "0x9E18B4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1023DF8", Offset = "0x1023DF8", VA = "0x1023DF8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x102479C", Offset = "0x102479C", VA = "0x102479C")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E18C4", Offset = "0x9E18C4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1023E00", Offset = "0x1023E00", VA = "0x1023E00")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x10247B8", Offset = "0x10247B8", VA = "0x10247B8")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E18D4", Offset = "0x9E18D4")]
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
			[Address(RVA = "0x10241B4", Offset = "0x10241B4", VA = "0x10241B4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x10247D4", Offset = "0x10247D4", VA = "0x10247D4")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x10247F0", Offset = "0x10247F0", VA = "0x10247F0")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x102480C", Offset = "0x102480C", VA = "0x102480C")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1024840", Offset = "0x1024840", VA = "0x1024840")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x102485C", Offset = "0x102485C", VA = "0x102485C")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1024878", Offset = "0x1024878", VA = "0x1024878")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E18E4", Offset = "0x9E18E4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1024478", Offset = "0x1024478", VA = "0x1024478")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x10249A0", Offset = "0x10249A0", VA = "0x10249A0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x1024A30", Offset = "0x1024A30", VA = "0x1024A30")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E18F4", Offset = "0x9E18F4")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x102475C", Offset = "0x102475C", VA = "0x102475C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1024AD4", Offset = "0x1024AD4", VA = "0x1024AD4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1024AF0", Offset = "0x1024AF0", VA = "0x1024AF0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x101EF60", Offset = "0x101EF60", VA = "0x101EF60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1023AE8", Offset = "0x1023AE8", VA = "0x1023AE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1023C74", Offset = "0x1023C74", VA = "0x1023C74")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x101F254", Offset = "0x101F254", VA = "0x101F254")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1023E08", Offset = "0x1023E08", VA = "0x1023E08")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x10241BC", Offset = "0x10241BC", VA = "0x10241BC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1024480", Offset = "0x1024480", VA = "0x1024480")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1904", Offset = "0x9E1904")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1024C1C", Offset = "0x1024C1C", VA = "0x1024C1C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1025000", Offset = "0x1025000", VA = "0x1025000")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x102501C", Offset = "0x102501C", VA = "0x102501C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1914", Offset = "0x9E1914")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1024C24", Offset = "0x1024C24", VA = "0x1024C24")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1025038", Offset = "0x1025038", VA = "0x1025038")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1025054", Offset = "0x1025054", VA = "0x1025054")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1924", Offset = "0x9E1924")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1024FF8", Offset = "0x1024FF8", VA = "0x1024FF8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1025070", Offset = "0x1025070", VA = "0x1025070")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x102507C", Offset = "0x102507C", VA = "0x102507C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x101F518", Offset = "0x101F518", VA = "0x101F518")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x101F974", Offset = "0x101F974", VA = "0x101F974")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1024C2C", Offset = "0x1024C2C", VA = "0x1024C2C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1024E04", Offset = "0x1024E04", VA = "0x1024E04")]
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
			[Address(RVA = "0x101E9B8", Offset = "0x101E9B8", VA = "0x101E9B8")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1934", Offset = "0x9E1934")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1025128", Offset = "0x1025128", VA = "0x1025128")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x10283C8", Offset = "0x10283C8", VA = "0x10283C8")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x10283E4", Offset = "0x10283E4", VA = "0x10283E4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1944", Offset = "0x9E1944")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1025130", Offset = "0x1025130", VA = "0x1025130")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1028638", Offset = "0x1028638", VA = "0x1028638")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x102865C", Offset = "0x102865C", VA = "0x102865C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1954", Offset = "0x9E1954")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1025138", Offset = "0x1025138", VA = "0x1025138")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x1028CC4", Offset = "0x1028CC4", VA = "0x1028CC4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x1028CE8", Offset = "0x1028CE8", VA = "0x1028CE8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1964", Offset = "0x9E1964")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x10252B4", Offset = "0x10252B4", VA = "0x10252B4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1029190", Offset = "0x1029190", VA = "0x1029190")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x10291B4", Offset = "0x10291B4", VA = "0x10291B4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1974", Offset = "0x9E1974")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1025408", Offset = "0x1025408", VA = "0x1025408")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x10292A0", Offset = "0x10292A0", VA = "0x10292A0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x10292C4", Offset = "0x10292C4", VA = "0x10292C4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1984", Offset = "0x9E1984")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1025580", Offset = "0x1025580", VA = "0x1025580")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x10292E8", Offset = "0x10292E8", VA = "0x10292E8")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1029304", Offset = "0x1029304", VA = "0x1029304")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1994", Offset = "0x9E1994")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x10258DC", Offset = "0x10258DC", VA = "0x10258DC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1029320", Offset = "0x1029320", VA = "0x1029320")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x10293A0", Offset = "0x10293A0", VA = "0x10293A0")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E19A4", Offset = "0x9E19A4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1025A58", Offset = "0x1025A58", VA = "0x1025A58")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x10293FC", Offset = "0x10293FC", VA = "0x10293FC")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x102947C", Offset = "0x102947C", VA = "0x102947C")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E19B4", Offset = "0x9E19B4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1025BD4", Offset = "0x1025BD4", VA = "0x1025BD4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x10294D8", Offset = "0x10294D8", VA = "0x10294D8")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1029558", Offset = "0x1029558", VA = "0x1029558")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E19C4", Offset = "0x9E19C4")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1025D50", Offset = "0x1025D50", VA = "0x1025D50")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1028400", Offset = "0x1028400", VA = "0x1028400")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1028420", Offset = "0x1028420", VA = "0x1028420")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E19D4", Offset = "0x9E19D4")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1025EA4", Offset = "0x1025EA4", VA = "0x1025EA4")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x102843C", Offset = "0x102843C", VA = "0x102843C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x102845C", Offset = "0x102845C", VA = "0x102845C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E19E4", Offset = "0x9E19E4")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x1026008", Offset = "0x1026008", VA = "0x1026008")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x1028478", Offset = "0x1028478", VA = "0x1028478")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1028494", Offset = "0x1028494", VA = "0x1028494")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E19F4", Offset = "0x9E19F4")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1026184", Offset = "0x1026184", VA = "0x1026184")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x10284B0", Offset = "0x10284B0", VA = "0x10284B0")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x10284CC", Offset = "0x10284CC", VA = "0x10284CC")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A04", Offset = "0x9E1A04")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x102630C", Offset = "0x102630C", VA = "0x102630C")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x10284E8", Offset = "0x10284E8", VA = "0x10284E8")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1028504", Offset = "0x1028504", VA = "0x1028504")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A14", Offset = "0x9E1A14")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1026494", Offset = "0x1026494", VA = "0x1026494")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x1028520", Offset = "0x1028520", VA = "0x1028520")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x102853C", Offset = "0x102853C", VA = "0x102853C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A24", Offset = "0x9E1A24")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x102649C", Offset = "0x102649C", VA = "0x102649C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x1028558", Offset = "0x1028558", VA = "0x1028558")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x1028574", Offset = "0x1028574", VA = "0x1028574")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A34", Offset = "0x9E1A34")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1026638", Offset = "0x1026638", VA = "0x1026638")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x1028590", Offset = "0x1028590", VA = "0x1028590")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x10285AC", Offset = "0x10285AC", VA = "0x10285AC")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A44", Offset = "0x9E1A44")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x10267D4", Offset = "0x10267D4", VA = "0x10267D4")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x10285C8", Offset = "0x10285C8", VA = "0x10285C8")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x10285E4", Offset = "0x10285E4", VA = "0x10285E4")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A54", Offset = "0x9E1A54")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x1026970", Offset = "0x1026970", VA = "0x1026970")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1028600", Offset = "0x1028600", VA = "0x1028600")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x102861C", Offset = "0x102861C", VA = "0x102861C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A64", Offset = "0x9E1A64")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1026AEC", Offset = "0x1026AEC", VA = "0x1026AEC")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1028680", Offset = "0x1028680", VA = "0x1028680")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x102869C", Offset = "0x102869C", VA = "0x102869C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A74", Offset = "0x9E1A74")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1026C68", Offset = "0x1026C68", VA = "0x1026C68")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x10286B8", Offset = "0x10286B8", VA = "0x10286B8")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x10286D4", Offset = "0x10286D4", VA = "0x10286D4")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A84", Offset = "0x9E1A84")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1026DCC", Offset = "0x1026DCC", VA = "0x1026DCC")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x10286F0", Offset = "0x10286F0", VA = "0x10286F0")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x102870C", Offset = "0x102870C", VA = "0x102870C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1A94", Offset = "0x9E1A94")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1026F50", Offset = "0x1026F50", VA = "0x1026F50")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1028728", Offset = "0x1028728", VA = "0x1028728")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1028744", Offset = "0x1028744", VA = "0x1028744")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AA4", Offset = "0x9E1AA4")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x10270D4", Offset = "0x10270D4", VA = "0x10270D4")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1028760", Offset = "0x1028760", VA = "0x1028760")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x102877C", Offset = "0x102877C", VA = "0x102877C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AB4", Offset = "0x9E1AB4")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x10270DC", Offset = "0x10270DC", VA = "0x10270DC")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1028798", Offset = "0x1028798", VA = "0x1028798")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x10287B4", Offset = "0x10287B4", VA = "0x10287B4")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AC4", Offset = "0x9E1AC4")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x10270E4", Offset = "0x10270E4", VA = "0x10270E4")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x10287D0", Offset = "0x10287D0", VA = "0x10287D0")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1028860", Offset = "0x1028860", VA = "0x1028860")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AD4", Offset = "0x9E1AD4")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1027284", Offset = "0x1027284", VA = "0x1027284")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1028904", Offset = "0x1028904", VA = "0x1028904")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1028994", Offset = "0x1028994", VA = "0x1028994")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AE4", Offset = "0x9E1AE4")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x102728C", Offset = "0x102728C", VA = "0x102728C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1028A38", Offset = "0x1028A38", VA = "0x1028A38")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1028AC8", Offset = "0x1028AC8", VA = "0x1028AC8")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AF4", Offset = "0x9E1AF4")]
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
			[Address(RVA = "0x1027638", Offset = "0x1027638", VA = "0x1027638")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1028B6C", Offset = "0x1028B6C", VA = "0x1028B6C")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1028B88", Offset = "0x1028B88", VA = "0x1028B88")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1028BA4", Offset = "0x1028BA4", VA = "0x1028BA4")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1028BD8", Offset = "0x1028BD8", VA = "0x1028BD8")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1028BF4", Offset = "0x1028BF4", VA = "0x1028BF4")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1028C10", Offset = "0x1028C10", VA = "0x1028C10")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B04", Offset = "0x9E1B04")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x10277A8", Offset = "0x10277A8", VA = "0x10277A8")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1028D0C", Offset = "0x1028D0C", VA = "0x1028D0C")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1028D7C", Offset = "0x1028D7C", VA = "0x1028D7C")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B14", Offset = "0x9E1B14")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1027908", Offset = "0x1027908", VA = "0x1027908")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1028DC8", Offset = "0x1028DC8", VA = "0x1028DC8")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1028DE4", Offset = "0x1028DE4", VA = "0x1028DE4")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B24", Offset = "0x9E1B24")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1027A68", Offset = "0x1027A68", VA = "0x1027A68")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1028E00", Offset = "0x1028E00", VA = "0x1028E00")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1028E1C", Offset = "0x1028E1C", VA = "0x1028E1C")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B34", Offset = "0x9E1B34")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1027BD4", Offset = "0x1027BD4", VA = "0x1027BD4")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1028E38", Offset = "0x1028E38", VA = "0x1028E38")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1028E5C", Offset = "0x1028E5C", VA = "0x1028E5C")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B44", Offset = "0x9E1B44")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1027BDC", Offset = "0x1027BDC", VA = "0x1027BDC")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1028E80", Offset = "0x1028E80", VA = "0x1028E80")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1028EA4", Offset = "0x1028EA4", VA = "0x1028EA4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B54", Offset = "0x9E1B54")]
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
			[Address(RVA = "0x1027DA4", Offset = "0x1027DA4", VA = "0x1027DA4")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1028EC8", Offset = "0x1028EC8", VA = "0x1028EC8")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1028ED0", Offset = "0x1028ED0", VA = "0x1028ED0")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B64", Offset = "0x9E1B64")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1027DAC", Offset = "0x1027DAC", VA = "0x1027DAC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1028F70", Offset = "0x1028F70", VA = "0x1028F70")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1028F94", Offset = "0x1028F94", VA = "0x1028F94")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B74", Offset = "0x9E1B74")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1027DB4", Offset = "0x1027DB4", VA = "0x1027DB4")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1028FB8", Offset = "0x1028FB8", VA = "0x1028FB8")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1028FDC", Offset = "0x1028FDC", VA = "0x1028FDC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B84", Offset = "0x9E1B84")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1027FB8", Offset = "0x1027FB8", VA = "0x1027FB8")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1029000", Offset = "0x1029000", VA = "0x1029000")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x102900C", Offset = "0x102900C", VA = "0x102900C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1B94", Offset = "0x9E1B94")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x10281BC", Offset = "0x10281BC", VA = "0x10281BC")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x10290C8", Offset = "0x10290C8", VA = "0x10290C8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x10290D4", Offset = "0x10290D4", VA = "0x10290D4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1BA4", Offset = "0x9E1BA4")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x10283C0", Offset = "0x10283C0", VA = "0x10283C0")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x10291D8", Offset = "0x10291D8", VA = "0x10291D8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x10291E4", Offset = "0x10291E4", VA = "0x10291E4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x101FD58", Offset = "0x101FD58", VA = "0x101FD58")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x101F68C", Offset = "0x101F68C", VA = "0x101F68C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x101FAC0", Offset = "0x101FAC0", VA = "0x101FAC0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1025140", Offset = "0x1025140", VA = "0x1025140")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x10252BC", Offset = "0x10252BC", VA = "0x10252BC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1025410", Offset = "0x1025410", VA = "0x1025410")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1025588", Offset = "0x1025588", VA = "0x1025588")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1025768", Offset = "0x1025768", VA = "0x1025768")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x10258E4", Offset = "0x10258E4", VA = "0x10258E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1025A60", Offset = "0x1025A60", VA = "0x1025A60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1025BDC", Offset = "0x1025BDC", VA = "0x1025BDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1025D58", Offset = "0x1025D58", VA = "0x1025D58")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1025EAC", Offset = "0x1025EAC", VA = "0x1025EAC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1026010", Offset = "0x1026010", VA = "0x1026010")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x102618C", Offset = "0x102618C", VA = "0x102618C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1026314", Offset = "0x1026314", VA = "0x1026314")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x101EC64", Offset = "0x101EC64", VA = "0x101EC64")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x10264A4", Offset = "0x10264A4", VA = "0x10264A4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1026640", Offset = "0x1026640", VA = "0x1026640")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x10267DC", Offset = "0x10267DC", VA = "0x10267DC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1026978", Offset = "0x1026978", VA = "0x1026978")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1026AF4", Offset = "0x1026AF4", VA = "0x1026AF4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1026C70", Offset = "0x1026C70", VA = "0x1026C70")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1026DD4", Offset = "0x1026DD4", VA = "0x1026DD4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1026F58", Offset = "0x1026F58", VA = "0x1026F58")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x101F3A4", Offset = "0x101F3A4", VA = "0x101F3A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1020088", Offset = "0x1020088", VA = "0x1020088")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x10270EC", Offset = "0x10270EC", VA = "0x10270EC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1020248", Offset = "0x1020248", VA = "0x1020248")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1027294", Offset = "0x1027294", VA = "0x1027294")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1027640", Offset = "0x1027640", VA = "0x1027640")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x10277B0", Offset = "0x10277B0", VA = "0x10277B0")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1027910", Offset = "0x1027910", VA = "0x1027910")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1027A70", Offset = "0x1027A70", VA = "0x1027A70")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x101F800", Offset = "0x101F800", VA = "0x101F800")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1027BE4", Offset = "0x1027BE4", VA = "0x1027BE4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x101FC0C", Offset = "0x101FC0C", VA = "0x101FC0C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x101FEA4", Offset = "0x101FEA4", VA = "0x101FEA4")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1027DBC", Offset = "0x1027DBC", VA = "0x1027DBC")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1027FC0", Offset = "0x1027FC0", VA = "0x1027FC0")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x10281C4", Offset = "0x10281C4", VA = "0x10281C4")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1BB4", Offset = "0x9E1BB4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x102A068", Offset = "0x102A068", VA = "0x102A068")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x102A898", Offset = "0x102A898", VA = "0x102A898")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x102A8BC", Offset = "0x102A8BC", VA = "0x102A8BC")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1BC4", Offset = "0x9E1BC4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x102A240", Offset = "0x102A240", VA = "0x102A240")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x102A8E0", Offset = "0x102A8E0", VA = "0x102A8E0")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x102A904", Offset = "0x102A904", VA = "0x102A904")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1BD4", Offset = "0x9E1BD4")]
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
			[Address(RVA = "0x102A928", Offset = "0x102A928", VA = "0x102A928", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x102AB6C", Offset = "0x102AB6C", VA = "0x102AB6C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1BE4", Offset = "0x9E1BE4")]
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
			[Address(RVA = "0x102B27C", Offset = "0x102B27C", VA = "0x102B27C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x102B4E4", Offset = "0x102B4E4", VA = "0x102B4E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1BF4", Offset = "0x9E1BF4")]
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
			[Address(RVA = "0x102ADD0", Offset = "0x102ADD0", VA = "0x102ADD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x102B000", Offset = "0x102B000", VA = "0x102B000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C04", Offset = "0x9E1C04")]
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
			[Address(RVA = "0x102AB78", Offset = "0x102AB78", VA = "0x102AB78", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x102ADC4", Offset = "0x102ADC4", VA = "0x102ADC4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C14", Offset = "0x9E1C14")]
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
			[Address(RVA = "0x102B00C", Offset = "0x102B00C", VA = "0x102B00C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x102B270", Offset = "0x102B270", VA = "0x102B270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C24", Offset = "0x9E1C24")]
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
			[Address(RVA = "0x102B4F0", Offset = "0x102B4F0", VA = "0x102B4F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x102B728", Offset = "0x102B728", VA = "0x102B728", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x10295B4", Offset = "0x10295B4", VA = "0x10295B4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1029790", Offset = "0x1029790", VA = "0x1029790")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1029980", Offset = "0x1029980", VA = "0x1029980")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1029A54", Offset = "0x1029A54", VA = "0x1029A54")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1029B28", Offset = "0x1029B28", VA = "0x1029B28")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1029BFC", Offset = "0x1029BFC", VA = "0x1029BFC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1029CE0", Offset = "0x1029CE0", VA = "0x1029CE0")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1029DC4", Offset = "0x1029DC4", VA = "0x1029DC4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1029E98", Offset = "0x1029E98", VA = "0x1029E98")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x102A070", Offset = "0x102A070", VA = "0x102A070")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x102A248", Offset = "0x102A248", VA = "0x102A248")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9E3C0C", Offset = "0x9E3C0C")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x102A350", Offset = "0x102A350", VA = "0x102A350")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9E3C80", Offset = "0x9E3C80")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x102A458", Offset = "0x102A458", VA = "0x102A458")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9E3CF4", Offset = "0x9E3CF4")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x102A560", Offset = "0x102A560", VA = "0x102A560")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9E3D68", Offset = "0x9E3D68")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x102A678", Offset = "0x102A678", VA = "0x102A678")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9E3DDC", Offset = "0x9E3DDC")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x102A790", Offset = "0x102A790", VA = "0x102A790")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9E3E50", Offset = "0x9E3E50")]
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
				[Address(RVA = "0x102163C", Offset = "0x102163C", VA = "0x102163C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1021670", Offset = "0x1021670", VA = "0x1021670")]
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
				[Address(RVA = "0x1021834", Offset = "0x1021834", VA = "0x1021834", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1021898", Offset = "0x1021898", VA = "0x1021898")]
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
				[Address(RVA = "0x1021738", Offset = "0x1021738", VA = "0x1021738", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1021754", Offset = "0x1021754", VA = "0x1021754")]
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
				[Address(RVA = "0x10216A4", Offset = "0x10216A4", VA = "0x10216A4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x10216F0", Offset = "0x10216F0", VA = "0x10216F0")]
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
				[Address(RVA = "0x1021788", Offset = "0x1021788", VA = "0x1021788", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x10217EC", Offset = "0x10217EC", VA = "0x10217EC")]
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
				[Address(RVA = "0x10218CC", Offset = "0x10218CC", VA = "0x10218CC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1021900", Offset = "0x1021900", VA = "0x1021900")]
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
			[Address(RVA = "0x102B878", Offset = "0x102B878", VA = "0x102B878")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x102B980", Offset = "0x102B980", VA = "0x102B980")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x102BA10", Offset = "0x102BA10", VA = "0x102BA10")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x102BAA0", Offset = "0x102BAA0", VA = "0x102BAA0")]
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
		[Address(RVA = "0x102B734", Offset = "0x102B734", VA = "0x102B734")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x102B7D8", Offset = "0x102B7D8", VA = "0x102B7D8")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9E160C", Offset = "0x9E160C")]
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
			[Address(RVA = "0x101D044", Offset = "0x101D044", VA = "0x101D044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3EE4", Offset = "0x9E3EE4")]
			add
			{
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x101D0F8", Offset = "0x101D0F8", VA = "0x101D0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3EF4", Offset = "0x9E3EF4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x101D1AC", Offset = "0x101D1AC", VA = "0x101D1AC")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x101D220", Offset = "0x101D220", VA = "0x101D220")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x101E750", Offset = "0x101E750", VA = "0x101E750")]
		private void Start()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x101E794", Offset = "0x101E794", VA = "0x101E794")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x101E798", Offset = "0x101E798", VA = "0x101E798")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x101D270", Offset = "0x101D270", VA = "0x101D270")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x102042C", Offset = "0x102042C", VA = "0x102042C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x10204A8", Offset = "0x10204A8", VA = "0x10204A8", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1020524", Offset = "0x1020524", VA = "0x1020524", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x10205A0", Offset = "0x10205A0", VA = "0x10205A0", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x102061C", Offset = "0x102061C", VA = "0x102061C", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1020698", Offset = "0x1020698", VA = "0x1020698", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1020794", Offset = "0x1020794", VA = "0x1020794", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x10207A4", Offset = "0x10207A4", VA = "0x10207A4", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1020B58", Offset = "0x1020B58", VA = "0x1020B58", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1020BD8", Offset = "0x1020BD8", VA = "0x1020BD8", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1020C68", Offset = "0x1020C68", VA = "0x1020C68")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1020CF4", Offset = "0x1020CF4", VA = "0x1020CF4")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1020D5C", Offset = "0x1020D5C", VA = "0x1020D5C")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1020DC4", Offset = "0x1020DC4", VA = "0x1020DC4")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1020E50", Offset = "0x1020E50", VA = "0x1020E50")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1020EB8", Offset = "0x1020EB8", VA = "0x1020EB8")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1020F44", Offset = "0x1020F44", VA = "0x1020F44")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1020FAC", Offset = "0x1020FAC", VA = "0x1020FAC")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x10210E0", Offset = "0x10210E0", VA = "0x10210E0")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1021170", Offset = "0x1021170", VA = "0x1021170")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x10211F0", Offset = "0x10211F0", VA = "0x10211F0")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x102128C", Offset = "0x102128C", VA = "0x102128C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1021310", Offset = "0x1021310", VA = "0x1021310")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x101E7FC", Offset = "0x101E7FC", VA = "0x101E7FC")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x10213FC", Offset = "0x10213FC", VA = "0x10213FC")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x101E7E4", Offset = "0x101E7E4", VA = "0x101E7E4")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x10208C0", Offset = "0x10208C0", VA = "0x10208C0")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1021438", Offset = "0x1021438", VA = "0x1021438")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1021630", Offset = "0x1021630", VA = "0x1021630")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3F04", Offset = "0x9E3F04")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C34", Offset = "0x9E1C34")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x102BF60", Offset = "0x102BF60", VA = "0x102BF60")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x102C29C", Offset = "0x102C29C", VA = "0x102C29C")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x102C2B8", Offset = "0x102C2B8", VA = "0x102C2B8")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C44", Offset = "0x9E1C44")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x102C294", Offset = "0x102C294", VA = "0x102C294")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x102C2D4", Offset = "0x102C2D4", VA = "0x102C2D4")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x102BBE8", Offset = "0x102BBE8", VA = "0x102BBE8")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x102BC38", Offset = "0x102BC38", VA = "0x102BC38")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x102BF68", Offset = "0x102BF68", VA = "0x102BF68")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
